using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Y3.Models.DB;
using Y3.Models;
using Y3.Utility.Enums;
using MySqlX.XDevAPI;
using Y3.Utility;
using System.Runtime.Remoting;

namespace Y3.Forms.Session
{
    public partial class frmSessionRegister : Form
    {
        private enum eGrid
        {
            SESSION = 0,
            USER,
            SESSION_PRICE,
        }

        private enum eButton
        {
            INIT = 0,
            UPDATE,
            DELETE,
            LOAD,
        }

        public frmSessionRegister()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;

            InitEvent();
            InitGrid();

            LoadSessionData();
            LoadUserData();
            LoadSessionPriceData();
            SetComboTrainer();
        }
        private void InitEvent()
        {
            this.VisibleChanged += FrmSessionRegister_VisibleChanged;

            comboSearchTrainer.SelectedValueChanged += ComboSearchTrainer_SelectedValueChanged;

            dtSearchDate.ValueChanged += DtSearchDate_ValueChanged;

            grid_SessionList.CellDoubleClick += Grid_CellDoubleClick;
            grid_UserList.CellDoubleClick += Grid_CellDoubleClick;
            grid_sessionPirce.CellDoubleClick += Grid_CellDoubleClick;

            btnSessionInit.Click += Btn_Click;
            btnSessionUpdate.Click += Btn_Click;
            btnSessionDel.Click += Btn_Click;
            btnLoad.Click += Btn_Click;

            txtSessionUseCount.KeyPress += TxtSessionUseCount_KeyPress;
            txtSessionUseCount.KeyUp += TxtSessionUseCount_KeyUp;
        }

        #region UI Event

        private void TxtSessionUseCount_KeyUp(object sender, KeyEventArgs e)
        {
            string spId = txtSessionPrice.Text;
            string count = txtSessionUseCount.Text;

            if (count == "0" || count == string.Empty) txtSessionTotalPrice.Text = "";
            else if (spId != string.Empty)
            {
                txtSessionTotalPrice.Text = (int.Parse(spId) * int.Parse(count)).ToString();
            }
        }

        private void TxtSessionUseCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Core.Instance.TypingOnlyNumber(sender, e, false, false);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int selectIdx = int.Parse(btn.Tag.ToString());

            switch (selectIdx)
            {
                case (int)eButton.INIT:
                    InitControl();
                    break;
                case (int)eButton.UPDATE:
                    UpdateSession();
                    break;
                case (int)eButton.DELETE:
                    DeleteSession();
                    break;
                case (int)eButton.LOAD:
                    LoadBeforeSession();
                    break;
            }
        }

        private void LoadBeforeSession()
        {
            DateTime dt = dtLoad.Value;

            if (txtTrainerNo.Text == string.Empty)
            {
                MessageBox.Show("트레이너를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboSearchTrainer.Focus();
                return;
            }

            if (MessageBox.Show($"{comboSearchTrainer.Text} 트레이너의 {dt.ToString("yyyy-MM")} 데이터를 불러오시겠습니까?", "불러오기", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            List<Models.Session> data =  Core.MODELS.GetSessions((int)comboSearchTrainer.SelectedValue, dt);

            if (data.Count > 0)
            {
                if (MessageBox.Show($"{comboSearchTrainer.Text} 트레이너의 {dt.ToString("yyyy-MM")} 데이터\n총 {data.Count}개 검색되었습니다.\n저장 하시겠습니까?", "저장", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                data = data.Select(p => (Models.Session)p.Clone()).ToList();
                data = data.Select(p => { p.Date = dtSearchDate.Value; return p; }).ToList();

                DBSession save = new DBSession(data, eDBQueryType.INSERT);

                if (Core.MARIA.MultiSave(save, out long id))
                {
                    MessageBox.Show("저장 성공!", "저장 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (id != 0)
                    {
                        foreach (Models.Session item in data)
                        {
                            item.Id = (int)id;
                            id += 1;
                        }
                    }
                    Core.MODELS.AddSessions(data);
                    LoadSessionData();
                }
                else
                {
                    MessageBox.Show("저장 실패!", "저장 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"{comboSearchTrainer.Text} 트레이너의 {dt.ToString("yyyy-MM")} 데이터가 없습니다.", "불러오기 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteSession()
        {
            if (txtSessionNo.Text == string.Empty) return;

            int id = int.Parse(txtSessionNo.Text);
            int userId = int.Parse(txtUserNo.Text);
            bool isRecovery = false;

            if (MessageBox.Show("정말 삭제 하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (MessageBox.Show("데이터 삭제 후 해당 회원에게 세션 횟수를 복원 시키겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                isRecovery = true;
            }

            Models.Session session = Core.MODELS.GetSessionById(id);
            User user = Core.MODELS.GetUserById(userId);
            if (isRecovery && (user.SessionId != session.SessionPriceId))
            {
                MessageBox.Show("삭제 실패!\n삭제하려는 데이터의 세션과 해당 유저의 세션이 상이합니다.", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Models.Session d = new Models.Session()
            {
                Id = id,
            };
            DBSession save = new DBSession(d, eDBQueryType.DELETE);

            if (Core.MARIA.Save(save, out long outId))
            {
                MessageBox.Show("삭제 성공!", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                d.Id = (int)outId == 0 ? d.Id : (int)outId;
                Core.MODELS.UpdateSessionData(d, eDBQueryType.DELETE);

                if (isRecovery)
                {
                    if (session.IsService)
                    {
                        user.RemainService += session.SessionCount;
                    }
                    else
                    {
                        user.RemainSession += session.SessionCount;
                    }
                    Core.MODELS.SaveUser(user, eDBQueryType.UPDATE);
                }

                LoadSessionData();
                LoadUserData();
            }
            else
            {
                MessageBox.Show("삭제 실패!", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSession()
        {
            string sessionNo = txtSessionNo.Text;
            string userId = txtUserNo.Text;
            string userName = txtUserName.Text;
            string sessionPriceID = txtSessionPriceNo.Text;
            string sessionPriceName = txtSessionPriceName.Text;
            string trainerID = comboSearchTrainer.SelectedValue.ToString();
            string trainerName = comboSearchTrainer.Text;
            DateTime sessionDate = dtSearchDate.Value;
            string sessionCount = txtSessionUseCount.Text;
            string sessionTotalPrice = txtSessionTotalPrice.Text;

            if (userId == string.Empty || sessionPriceID == string.Empty || trainerID == "0" || sessionCount == string.Empty)
            {
                MessageBox.Show("유저, 트레이너, 세션, 세션횟수는 필수 항목입니다.\n", "오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int totalSessioning = int.Parse(sessionCount);
            User u = Core.MODELS.GetUserById(int.Parse(userId));
            if (totalSessioning < 1)
            {
                MessageBox.Show("세션 진행횟수가 잘못되었습니다. 1이상의 숫자를 입력해주세요.\n", "오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((u.RemainSession + u.RemainService) - totalSessioning < 0)
            {
                MessageBox.Show("세션 진행횟수가 남은 횟수보다 많습니다.\n", "오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 중복체크 필요없을듯

            List<Models.Session> saveList = new List<Models.Session>();

            // 기본 세션수보다 진행수가 높을경우 서비스가격으로 들어가야함.
            // shlee 서비스일경우 25000원 - 서비스 설정 추가필요
            int remain = u.RemainSession;
            int sessioning = totalSessioning;
            // 기본 남은세션이 소모세션보다 적을때
            if (remain - totalSessioning < 0)
            {
                sessioning -= remain;

                if (remain != 0)
                {
                    Models.Session d1 = new Models.Session()
                    {
                        Id = sessionNo == "" ? 0 : int.Parse(sessionNo),
                        UserId = int.Parse(userId),
                        UserName = userName,
                        SessionPriceId = int.Parse(sessionPriceID),
                        SessionPriceName = sessionPriceName,
                        TrainerId = int.Parse(trainerID),
                        TrainerName = trainerName,
                        Date = sessionDate,
                        SessionCount = remain,
                        SessionTotalPrice = int.Parse(sessionTotalPrice)
                    };
                    saveList.Add(d1);
                }
                if(sessioning > 0)
                {
                    Models.Session d2 = new Models.Session()
                    {
                        Id = sessionNo == "" ? 0 : int.Parse(sessionNo),
                        UserId = int.Parse(userId),
                        UserName = userName,
                        SessionPriceId = int.Parse(sessionPriceID),
                        SessionPriceName = sessionPriceName,
                        TrainerId = int.Parse(trainerID),
                        TrainerName = trainerName,
                        Date = sessionDate,
                        SessionCount = sessioning,
                        SessionTotalPrice = 25000 * sessioning,
                        IsService = true
                    };
                    saveList.Add(d2);
                }
            }
            else
            {
                Models.Session d1 = new Models.Session()
                {
                    Id = sessionNo == "" ? 0 : int.Parse(sessionNo),
                    UserId = int.Parse(userId),
                    UserName = userName,
                    SessionPriceId = int.Parse(sessionPriceID),
                    SessionPriceName = sessionPriceName,
                    TrainerId = int.Parse(trainerID),
                    TrainerName = trainerName,
                    Date = sessionDate,
                    SessionCount = sessioning,
                    SessionTotalPrice = int.Parse(sessionTotalPrice)
                };
                saveList.Add(d1);
            }

            eDBQueryType saveType = saveList[0].Id != 0 ? eDBQueryType.UPDATE : eDBQueryType.INSERT;
            DBSession save = new DBSession(saveList, saveType);

            if (Core.MARIA.MultiSave(save, out long outId))
            {
                MessageBox.Show("저장 성공!", "저장 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // outid 0일경우는 update, delete성공
                // insert성공시 해당 로우 아이디반환
                if (outId != 0)
                {
                    // insert성공시
                    // 저장했던 객체에 id부여
                    foreach (Models.Session item in saveList)
                    {
                        item.Id = (int)outId;
                        outId += 1;
                    }
                    Core.MODELS.MinusUserSessionCount(u.Id, totalSessioning);
                }
                Core.MODELS.UpdateSessionData(saveList);
                LoadSessionData();
                LoadUserData();
            }
            else
            {
                MessageBox.Show("저장 실패!", "저장 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            int selectIdx = int.Parse(grid.Tag.ToString());

            switch (selectIdx)
            {
                case (int)eGrid.SESSION:
                    {
                        txtSessionNo.Text = grid_SessionList.CurrentRow.Cells["Id"].Value.ToString();

                        // user
                        txtUserNo.Text = grid_SessionList.CurrentRow.Cells["UserId"].Value.ToString();
                        txtUserName.Text = grid_SessionList.CurrentRow.Cells["UserName"].Value.ToString();

                        // session price
                        txtSessionPriceNo.Text = grid_SessionList.CurrentRow.Cells["SessionPriceId"].Value.ToString();
                        txtSessionPriceName.Text = grid_SessionList.CurrentRow.Cells["SessionPriceName"].Value.ToString();
                        txtSessionTotalPrice.Text = grid_SessionList.CurrentRow.Cells["SessionTotalPrice"].Value.ToString();

                        // trainer
                        //txtTrainerNo.Text = grid_SessionList.CurrentRow.Cells["TrainerId"].Value.ToString();
                        //txtTrainerName.Text = grid_SessionList.CurrentRow.Cells["TrainerName"].Value.ToString();
                        
                        txtSessionUseCount.Text = grid_SessionList.CurrentRow.Cells["SessionCount"].Value.ToString();

                        txtSessionPrice.Text = ((int)(decimal.Parse(txtSessionTotalPrice.Text) / decimal.Parse(txtSessionUseCount.Text))).ToString();

                        txtSessionUseCount.Enabled = false;
                    }
                    break;
                case (int)eGrid.SESSION_PRICE:
                    {
                        string trNo = txtTrainerNo.Text;
                        // session price
                        txtSessionPriceNo.Text = grid_sessionPirce.CurrentRow.Cells["Id"].Value.ToString();
                        txtSessionPriceName.Text = grid_sessionPirce.CurrentRow.Cells["SessionName"].Value.ToString();
                        txtSessionPrice.Text = trNo == string.Empty ? decimal.Parse(grid_sessionPirce.CurrentRow.Cells["FinalPrice"].Value.ToString()).ToString("00")
                                                                    : Core.MODELS.GetSessionTrainerTotalPrice(int.Parse(txtSessionPriceNo.Text), int.Parse(trNo)).ToString("00");

                        txtSessionNo.Text = string.Empty;

                        string spId = txtSessionPriceNo.Text;
                        string count = txtSessionUseCount.Text;
                        if (count != string.Empty)
                        {
                            txtSessionTotalPrice.Text = (int.Parse(spId) * int.Parse(count)).ToString();
                        }
                    }
                    break;
                case (int)eGrid.USER:
                    {
                        // user
                        string trId = comboSearchTrainer.SelectedValue.ToString();
                        if (trId == "0")
                        {
                            MessageBox.Show("트레이너를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            comboSearchTrainer.Focus();
                            return;
                        }

                        string spId = grid_UserList.CurrentRow.Cells["SessionId"].Value.ToString();
                        string spName = grid_UserList.CurrentRow.Cells["SessionName"].Value.ToString();
                        decimal price = 0;
                        // 세션 아이디 있는지 체크
                        if (spId == string.Empty || spId == "0")
                        {
                            MessageBox.Show("세션이 등록되지 않은 회원입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        // 해당 세션 존재체크
                        SessionPrice sp = Core.MODELS.GetSessionPriceById(int.Parse(spId));
                        if (sp == null)
                        {
                            MessageBox.Show("세션이 존재하지 않습니다.\n관리자에게 문의 바랍니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        SessionTrainer st = Core.MODELS.GetSessionTrainerByTrIdAndSessionID(int.Parse(trId), sp.Id);
                        if (st == null)
                        {
                            price = sp.FinalPrice;
                        }
                        else
                        {
                            price = Core.MODELS.GetSessionTrainerTotalPrice(sp.Id, int.Parse(trId));
                        }

                        txtUserNo.Text = grid_UserList.CurrentRow.Cells["Id"].Value.ToString();
                        txtUserName.Text = grid_UserList.CurrentRow.Cells["Name"].Value.ToString();

                        txtSessionPriceName.Text = spName;
                        txtSessionPrice.Text = price.ToString("00");
                        txtSessionPriceNo.Text = grid_UserList.CurrentRow.Cells["SessionId"].Value.ToString();

                        txtSessionNo.Text = string.Empty;
                        txtSessionUseCount.Enabled = true;
                        txtSessionUseCount.Text = string.Empty;
                    }
                    break;
            }
        }

        private void DtSearchDate_ValueChanged(object sender, EventArgs e)
        {
            LoadSessionData();
        }

        private void ComboSearchTrainer_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadSessionData();

            if (comboSearchTrainer.SelectedIndex != 0)
            {
                txtTrainerNo.Text = comboSearchTrainer.SelectedValue.ToString();
                txtTrainerName.Text = comboSearchTrainer.Text;
            }
            else
            {
                txtTrainerNo.Text = string.Empty;
                txtTrainerName.Text = string.Empty;
            }
        }

        private void FrmSessionRegister_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false) return;

            comboSearchTrainer.DataSource = Core.MODELS.GetTrainersCombo();
            comboSearchTrainer.DisplayMember = "Name";
            comboSearchTrainer.ValueMember = "Id";

            LoadUserData();
            SetComboTrainer();
            LoadSessionData();
        }
        #endregion

        private void SetComboTrainer()
        {
            comboSearchTrainer.DataSource = Core.MODELS.GetTrainersCombo();
            comboSearchTrainer.DisplayMember = "Name";
            comboSearchTrainer.ValueMember = "Id";
        }

        private void LoadSessionPriceData()
        {
            grid_sessionPirce.DataSource = Core.MODELS.GetSessionPriceDataTable();
        }

        private void LoadUserData()
        {
            grid_UserList.DataSource = Core.MODELS.GetUsersDataTable();
        }

        private void LoadSessionData()
        {
            if (comboSearchTrainer.SelectedValue == null || comboSearchTrainer.SelectedIndex == 0)
            {
                if (grid_SessionList.DataSource != null)
                    grid_SessionList.DataSource = ((DataTable)grid_SessionList.DataSource).Clone();
                return;
            }

            grid_SessionList.DataSource = Core.MODELS.GetSessionsDataTable((int)comboSearchTrainer.SelectedValue, dtSearchDate.Value);

            int rowCnt = grid_SessionList.Rows.Count;
            for (int i = 0; i < rowCnt; i++)
            {
                if (Convert.ToBoolean(grid_SessionList.Rows[i].Cells["IsService"].Value))
                {
                    grid_SessionList.Rows[i].Cells["SessionTotalPrice"].Style.BackColor = Color.Yellow;
                }
            }

            InitControl();
        }

        private void InitControl()
        {
            txtSessionNo.Text = string.Empty;

            // user
            txtUserNo.Text = string.Empty;
            txtUserName.Text = string.Empty;

            // session price
            txtSessionPriceNo.Text = string.Empty;
            txtSessionPriceName.Text = string.Empty;
            txtSessionTotalPrice.Text = string.Empty;
            txtSessionPrice.Text = string.Empty;

            // trainer
            //txtTrainerName.Text = string.Empty;

            txtSessionUseCount.Text = string.Empty;
            txtSessionUseCount.Enabled = true;
        }

        private void InitGrid()
        {
            #region Session
            Core.Instance.SetGridCol_Text(grid_SessionList, new DataGridViewTextBoxColumn(), "Id", "Id", true, 70, false);
            Core.Instance.SetGridCol_Text(grid_SessionList, new DataGridViewTextBoxColumn(), "Date", "세션소모 월", true, 80, false);
            Core.Instance.SetGridCol_Text(grid_SessionList, new DataGridViewTextBoxColumn(), "TrainerId", "TR ID", true, 90, false);
            Core.Instance.SetGridCol_Text(grid_SessionList, new DataGridViewTextBoxColumn(), "TrainerName", "TR 이름", true, 120, false);
            Core.Instance.SetGridCol_Text(grid_SessionList, new DataGridViewTextBoxColumn(), "UserId", "회원ID", true, 270, false);
            Core.Instance.SetGridCol_Text(grid_SessionList, new DataGridViewTextBoxColumn(), "UserName", "회원이름", true, 95);
            Core.Instance.SetGridCol_Text(grid_SessionList, new DataGridViewTextBoxColumn(), "SessionPriceId", "세션종류ID", true, 95, false);
            Core.Instance.SetGridCol_Text(grid_SessionList, new DataGridViewTextBoxColumn(), "SessionPriceName", "세션이름", true, 90);
            Core.Instance.SetGridCol_Text(grid_SessionList, new DataGridViewTextBoxColumn(), "SessionCount", "세션소모 수", true, 115);
            Core.Instance.SetGridCol_Text(grid_SessionList, new DataGridViewTextBoxColumn(), "IsService", "서비스여부", true, 105, false);
            Core.Instance.SetGridCol_Text(grid_SessionList, new DataGridViewTextBoxColumn(), "SessionTotalPrice", "가격", true, 100);
            // 헤더
            grid_SessionList.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            grid_SessionList.ColumnHeadersDefaultCellStyle.Font = new Font("굴림", 10f, FontStyle.Bold);
            grid_SessionList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 셀
            grid_SessionList.DefaultCellStyle.ForeColor = Color.Black;
            grid_SessionList.DefaultCellStyle.Font = new Font("굴림", 9, FontStyle.Regular);
            grid_SessionList.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid_SessionList.Columns["Date"].DefaultCellStyle.Format = "yyyy-MM";
            grid_SessionList.Columns["SessionTotalPrice"].DefaultCellStyle.Format = "###,###";

            grid_SessionList.RowHeadersVisible = false;
            grid_SessionList.AllowUserToAddRows = false;
            #endregion

            #region User
            Core.Instance.SetGridCol_Text(grid_UserList, new DataGridViewTextBoxColumn(), "Id", "Id", true, 70, false);
            Core.Instance.SetGridCol_Text(grid_UserList, new DataGridViewTextBoxColumn(), "Name", "이름", true, 80);
            Core.Instance.SetGridCol_Text(grid_UserList, new DataGridViewTextBoxColumn(), "BirthDay", "생일", true, 90, false);
            Core.Instance.SetGridCol_Text(grid_UserList, new DataGridViewTextBoxColumn(), "PhoneNumber", "핸드폰 번호", true, 120);
            Core.Instance.SetGridCol_Text(grid_UserList, new DataGridViewTextBoxColumn(), "SessionId", "세션", true, 70, false);
            Core.Instance.SetGridCol_Text(grid_UserList, new DataGridViewTextBoxColumn(), "SessionName", "세션", true, 70);
            Core.Instance.SetGridCol_Text(grid_UserList, new DataGridViewTextBoxColumn(), "RemainSession", "잔여 횟수", true, 100);
            Core.Instance.SetGridCol_Text(grid_UserList, new DataGridViewTextBoxColumn(), "RemainService", "잔여 서비스", true, 120);
            Core.Instance.SetGridCol_Text(grid_UserList, new DataGridViewTextBoxColumn(), "LockerNo", "라커번호", true, 100, false);
            Core.Instance.SetGridCol_Text(grid_UserList, new DataGridViewTextBoxColumn(), "Memo", "메모", true, 200);
            // 헤더
            grid_UserList.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            grid_UserList.ColumnHeadersDefaultCellStyle.Font = new Font("굴림", 10f, FontStyle.Bold);
            grid_UserList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 셀
            grid_UserList.DefaultCellStyle.ForeColor = Color.Black;
            grid_UserList.DefaultCellStyle.Font = new Font("굴림", 9, FontStyle.Regular);
            grid_UserList.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid_UserList.Columns["BirthDay"].DefaultCellStyle.Format = "yyyy-MM-dd";

            grid_UserList.RowHeadersVisible = false;
            grid_UserList.AllowUserToAddRows = false;
            #endregion

            #region SessionPrice
            Core.Instance.SetGridCol_Text(grid_sessionPirce, new DataGridViewTextBoxColumn(), "Id", "Id", true, 70, false);
            Core.Instance.SetGridCol_Text(grid_sessionPirce, new DataGridViewTextBoxColumn(), "SessionName", "세션이름", true, 115);
            Core.Instance.SetGridCol_Text(grid_sessionPirce, new DataGridViewTextBoxColumn(), "Price", "가격", true, 115);
            Core.Instance.SetGridCol_Text(grid_sessionPirce, new DataGridViewTextBoxColumn(), "Percentage", "지급률(%)", true, 105, false);
            Core.Instance.SetGridCol_Text(grid_sessionPirce, new DataGridViewTextBoxColumn(), "Deduct", "공제률(%)", true, 105, false);
            Core.Instance.SetGridCol_Text(grid_sessionPirce, new DataGridViewTextBoxColumn(), "FinalPrice", "지급금액", true, 115);
            // 헤더
            grid_sessionPirce.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            grid_sessionPirce.ColumnHeadersDefaultCellStyle.Font = new Font("굴림", 10f, FontStyle.Bold);
            grid_sessionPirce.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 셀
            grid_sessionPirce.DefaultCellStyle.ForeColor = Color.Black;
            grid_sessionPirce.DefaultCellStyle.Font = new Font("굴림", 9, FontStyle.Regular);
            grid_sessionPirce.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid_sessionPirce.Columns["Price"].DefaultCellStyle.Format = "###,###";
            grid_sessionPirce.Columns["Percentage"].DefaultCellStyle.Format = "###,###";
            grid_sessionPirce.Columns["Deduct"].DefaultCellStyle.Format = "###,###";
            grid_sessionPirce.Columns["FinalPrice"].DefaultCellStyle.Format = "###,###";

            grid_sessionPirce.RowHeadersVisible = false;
            grid_sessionPirce.AllowUserToAddRows = false;
            #endregion

            
        }


    }
}
