using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Y3.Models;
using Y3.Models.DB;
using Y3.Utility.Enums;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Y3.Forms.Setting
{
    public partial class frmSettingUser : Form
    {
        private enum eButton
        {
            USER_INIT = 0,
            USER_UPDATE = 1,
            USER_DELETE = 2,

            TRAINER_INIT = 10,
            TRAINER_UPDATE = 11,
            TRAINER_DELETE = 12,
        }

        private enum eCheckBox
        {
            USER_PHONE = 0,
            USER_BIRTHDAY = 1,

            TRAINER_PHONE = 10,
            TRAINER_BIRTHDAY = 11,
        }

        private enum eGrid
        {
            USER = 0,
            TRAINER = 1,
        }

        List<User> users = new List<User>();
        public frmSettingUser()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;

            InitEvent();
            InitGrid();

            LoadUserData();
            LoadTrainerData();
            SetComboTrainer();
        }
        private void InitEvent()
        {
            this.VisibleChanged += FrmSettingUser_VisibleChanged;
            grid_UserList.CellDoubleClick += Grid_List_CellDoubleClick;
            grid_TrainerList.CellDoubleClick += Grid_List_CellDoubleClick;

            btnUserInit.Click += Btn_Click;
            btnUserUpdate.Click += Btn_Click;
            btnUserDel.Click += Btn_Click;

            btnTrainerInit.Click += Btn_Click;
            btnTrainerUpdate.Click += Btn_Click;
            btnTrainerDel.Click += Btn_Click;

            chkUserPhone.CheckedChanged += Chk_CheckedChanged;
            chkUserBirthday.CheckedChanged += Chk_CheckedChanged;
            chkTrainerPhone.CheckedChanged += Chk_CheckedChanged;
            chkTrainerBirthday.CheckedChanged += Chk_CheckedChanged;

            txtSearchUser.KeyUp += TxtSearchUser_KeyUp;

            txtUserPhone.KeyPress += Txt_KeyPress;
            txtTrainerPhone.KeyPress += Txt_KeyPress;
            txtTrainerSalary.KeyPress += Txt_KeyPress;
            txtUserServiceCnt.KeyPress += Txt_KeyPress;
            txtUserSessionCnt.KeyPress += Txt_KeyPress;
        }


        #region UI Event

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Core.Instance.TypingOnlyNumber(sender, e, false, false);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int selectIdx = int.Parse(btn.Tag.ToString());

            switch (selectIdx)
            {
                // User
                case (int)eButton.USER_INIT:
                    InitUserControl();
                    break;
                case (int)eButton.USER_UPDATE:
                    UpdateUser();
                    break;
                case (int)eButton.USER_DELETE:
                    DeleteUser();
                    break;

                // Trainer
                case (int)eButton.TRAINER_INIT:
                    InitTrainerControl();
                    break;
                case (int)eButton.TRAINER_UPDATE:
                    UpdateTrainer();
                    break;
                case (int)eButton.TRAINER_DELETE:
                    DeleteTrainer();
                    break;
            }
        }

        private void Grid_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            int selectIdx = int.Parse(grid.Tag.ToString());
            DateTime dtNow = DateTime.Now;
            switch (selectIdx)
            {
                case (int)eGrid.USER:
                    {
                        txtUserNo.Text = grid_UserList.CurrentRow.Cells["Id"].Value.ToString();
                        txtUserName.Text = grid_UserList.CurrentRow.Cells["Name"].Value.ToString();
                        txtUserPhone.Text = Core.Instance.ReversePhoneNumber(grid_UserList.CurrentRow.Cells["PhoneNumber"].Value.ToString());
                        dtUserBirthday.Value = DateTime.Parse(grid_UserList.CurrentRow.Cells["BirthDay"].Value.ToString()) == DateTime.MinValue ? dtNow : DateTime.Parse(grid_UserList.CurrentRow.Cells["BirthDay"].Value.ToString());
                        comboUserSession.Text = grid_UserList.CurrentRow.Cells["SessionName"].Value.ToString() == "" ? "선택" : grid_UserList.CurrentRow.Cells["SessionName"].Value.ToString();
                        txtUserMemo.Text = grid_UserList.CurrentRow.Cells["Memo"].Value.ToString();
                        txtUserSessionCnt.Text = grid_UserList.CurrentRow.Cells["RemainSession"].Value.ToString();
                        txtUserServiceCnt.Text = grid_UserList.CurrentRow.Cells["RemainService"].Value.ToString();
                        comboUserTrainer.Text = grid_UserList.CurrentRow.Cells["TrainerName"].Value.ToString() == "" ? "선택" : grid_UserList.CurrentRow.Cells["TrainerName"].Value.ToString();

                        if (txtUserPhone.Text == string.Empty)
                            chkUserPhone.Checked = true;
                        else
                            chkUserPhone.Checked = false;

                        if (dtUserBirthday.Value == dtNow)
                            chkUserBirthday.Checked = true;
                        else
                            chkUserBirthday.Checked = false;
                    }
                    break;
                case (int)eGrid.TRAINER:
                    {
                        txtTrainerNo.Text = grid_TrainerList.CurrentRow.Cells["Id"].Value.ToString();
                        txtTrainerName.Text = grid_TrainerList.CurrentRow.Cells["Name"].Value.ToString();
                        txtTrainerPhone.Text = Core.Instance.ReversePhoneNumber(grid_TrainerList.CurrentRow.Cells["PhoneNumber"].Value.ToString());
                        dtTrainerBirthday.Value = DateTime.Parse(grid_TrainerList.CurrentRow.Cells["BirthDay"].Value.ToString()) == DateTime.MinValue ? dtNow : DateTime.Parse(grid_TrainerList.CurrentRow.Cells["BirthDay"].Value.ToString());
                        txtTrainerSalary.Text = grid_TrainerList.CurrentRow.Cells["Salary"].Value.ToString();
                        txtTrainerMemo.Text = grid_TrainerList.CurrentRow.Cells["Memo"].Value.ToString();

                        if (txtTrainerPhone.Text == string.Empty)
                            chkTrainerPhone.Checked = true;
                        else
                            chkTrainerPhone.Checked = false;

                        if (dtTrainerBirthday.Value == dtNow)
                            chkTrainerBirthday.Checked = true;
                        else   
                            chkTrainerBirthday.Checked = false;
                    }
                    break;
            }
            
        }

        private void Chk_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            int selectIdx = int.Parse(chk.Tag.ToString());
            bool check = (bool)chk.Checked;

            switch (selectIdx)
            {
                // user
                case (int)eCheckBox.USER_PHONE:
                    ChangeEnable(txtUserPhone, !check);
                    break;
                case (int)eCheckBox.USER_BIRTHDAY:
                    ChangeEnable(dtUserBirthday, !check);
                    break;

                // trainer
                case (int)eCheckBox.TRAINER_PHONE:
                    ChangeEnable(txtTrainerPhone, !check);
                    break;
                case (int)eCheckBox.TRAINER_BIRTHDAY:
                    ChangeEnable(dtTrainerBirthday, !check);
                    break;
            }
        }
        private void TxtSearchUser_KeyUp(object sender, KeyEventArgs e)
        {
            string filter = txtSearchUser.Text;
            LoadUserData(filter);
        }
        private void FrmSettingUser_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false) return;

            comboUserSession.DataSource = Core.M_SESSION_PRICE.GetCombo();
            comboUserSession.DisplayMember = "SessionName";
            comboUserSession.ValueMember = "Id";

            LoadUserData();
            LoadTrainerData();
        }
        #endregion

        private void InitUserControl()
        {
            txtUserNo.Text = "";
            txtUserName.Text = "";
            txtUserPhone.Text = "";
            txtUserMemo.Text = "";
            dtUserBirthday.Value = DateTime.Now;
            comboUserSession.SelectedValue = 0;
            comboUserTrainer.SelectedValue = 0;
            chkUserPhone.Checked = false;
            chkUserBirthday.Checked = false;

            txtUserSessionCnt.Text = "";
            txtUserServiceCnt.Text = "";
        }

        private void InitTrainerControl()
        {
            txtTrainerNo.Text = "";
            txtTrainerName.Text = "";
            txtTrainerPhone.Text = "";
            txtTrainerMemo.Text = "";
            txtTrainerSalary.Text = "";
            dtTrainerBirthday.Value = DateTime.Now;
            chkTrainerPhone.Checked = false;
            chkTrainerBirthday.Checked = false;
        }

        private void SetComboTrainer()
        {
            comboUserTrainer.DataSource = Core.M_TRAINER.GetCombo();
            comboUserTrainer.DisplayMember = "Name";
            comboUserTrainer.ValueMember = "Id";
        }

        private void LoadUserData(string filter = "")
        {
            DataTable dt = Core.M_USER.GetDataTable();
            if (filter != "")
            {
                DataTable dtFilter = ((DataTable)grid_UserList.DataSource).Clone();
                var var = dt.AsEnumerable()
                        .Where(row => row.Field<String>("Name").Contains(filter)
                                || row.Field<String>("PhoneNumber").Contains(filter));

                if (var.ToList().Count > 0)
                {
                    dtFilter = var.OrderByDescending(row => row.Field<int>("Id")).CopyToDataTable();
                }

                grid_UserList.DataSource = dtFilter;
            }
            else
            {
                grid_UserList.DataSource = dt;
            }
        }

        private void LoadTrainerData()
        {
            grid_TrainerList.DataSource = Core.M_TRAINER.GetDataTable();
        }

        private void UpdateUser()
        {
            if (txtUserName.Text == string.Empty)
            {
                MessageBox.Show("이름은 필수 항목입니다.\n이름을 입력해주세요.", "이름 오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!chkUserPhone.Checked)
            {
                if (txtUserPhone.Text.Length < 10)
                {
                    MessageBox.Show("핸드폰 번호를 정확히 입력해주세요.", "핸드폰번호 오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            string userId = txtUserNo.Text;
            string userName = txtUserName.Text;
            string userPhone = txtUserPhone.Text;
            DateTime userBirth = dtUserBirthday.Value;
            string userSessionId = comboUserSession.SelectedValue.ToString();
            string userSessionName = comboUserSession.Text;
            string userMemo = txtUserMemo.Text;
            int userSessionCnt = txtUserSessionCnt.Text == string.Empty || userSessionId == "0" ? 0 : int.Parse(txtUserSessionCnt.Text);
            int userServiceCnt = txtUserServiceCnt.Text == string.Empty || userSessionId == "0" ? 0 : int.Parse(txtUserServiceCnt.Text);
            string userTrainerId = comboUserTrainer.SelectedValue.ToString();
            string userTrainerName = comboUserTrainer.Text;

            User u = new User()
            {
                Id = userId == "" ? 0 : int.Parse(userId),
                Name = userName,
                PhoneNumber = chkUserPhone.Checked ? "" : Core.Instance.MakePhoneNumber(userPhone),
                BirthDay = chkUserBirthday.Checked ? DateTime.MinValue : userBirth,
                SessionId = int.Parse(userSessionId),
                SessionName = userSessionName == "선택" ? "" : userSessionName,
                RemainSession = userSessionCnt,
                RemainService = userServiceCnt,
                TrainerId = int.Parse(userTrainerId),
                TrainerName = userTrainerName,
                Memo = userMemo,
            };

            DBUser d = new DBUser(u, u.Id != 0 ? eDBQueryType.UPDATE : eDBQueryType.INSERT);

            if (Core.MARIA.Save(d, out long outId))
            {
                MessageBox.Show("저장 성공!", "저장 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                u.Id = (int)outId == 0 ? u.Id : (int)outId;
                Core.M_USER.UpdateData(u);
                InitUserControl();
                LoadUserData();
            }
            else
            {
                MessageBox.Show("저장 실패!", "저장 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTrainer()
        {
            if (txtTrainerName.Text == string.Empty || txtTrainerSalary.Text == string.Empty)
            {
                MessageBox.Show("이름, 기본급은 필수 항목입니다.", "이름 오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!chkTrainerPhone.Checked)
            {
                if (txtTrainerPhone.Text.Length < 10)
                {
                    MessageBox.Show("핸드폰 번호를 정확히 입력해주세요.", "핸드폰번호 오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            string trainerId = txtTrainerNo.Text;
            string trainerName = txtTrainerName.Text;
            string trainerPhone = txtTrainerPhone.Text;
            DateTime trainerBirth = dtTrainerBirthday.Value;
            string trainerSalary = txtTrainerSalary.Text;
            string trainerMemo = txtTrainerMemo.Text;

            Trainer u = new Trainer()
            {
                Id = trainerId == "" ? 0 : int.Parse(trainerId),
                Name = trainerName,
                PhoneNumber = chkTrainerPhone.Checked ? "" : Core.Instance.MakePhoneNumber(trainerPhone),
                BirthDay = chkTrainerBirthday.Checked ? DateTime.MinValue : trainerBirth,
                Salary = int.Parse(trainerSalary),
                Memo = trainerMemo,
            };

            DBTrainer d = new DBTrainer(u, u.Id != 0 ? eDBQueryType.UPDATE : eDBQueryType.INSERT);

            if (Core.MARIA.Save(d, out long outId))
            {
                MessageBox.Show("저장 성공!", "저장 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                u.Id = (int)outId == 0 ? u.Id : (int)outId;
                Core.M_TRAINER.UpdateData(u);
                InitTrainerControl();
                LoadTrainerData();
                SetComboTrainer();
            }
            else
            {
                MessageBox.Show("저장 실패!", "저장 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteUser()
        {
            if (txtUserNo.Text == string.Empty) return;

            int id = int.Parse(txtUserNo.Text);

            if (MessageBox.Show("정말 삭제 하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            User u = new User()
            {
                Id = id,
            };
            DBUser d = new DBUser(u, eDBQueryType.DELETE);

            if (Core.MARIA.Save(d, out long outId))
            {
                MessageBox.Show("삭제 성공!", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                u.Id = (int)outId == 0 ? u.Id : (int)outId;
                Core.M_USER.UpdateData(u, eDBQueryType.DELETE);
                InitUserControl();
                LoadUserData();
            }
            else
            {
                MessageBox.Show("삭제 실패!", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteTrainer()
        {
            if (txtTrainerNo.Text == string.Empty) return;

            int id = int.Parse(txtTrainerNo.Text);

            if (MessageBox.Show("정말 삭제 하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            Trainer u = new Trainer()
            {
                Id = id,
            };
            DBTrainer d = new DBTrainer(u, eDBQueryType.DELETE);

            if (Core.MARIA.Save(d, out long outId))
            {
                MessageBox.Show("삭제 성공!", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                u.Id = (int)outId == 0 ? u.Id : (int)outId;
                Core.M_TRAINER.UpdateData(u, eDBQueryType.DELETE);
                InitTrainerControl();
                LoadTrainerData();
            }
            else
            {
                MessageBox.Show("삭제 실패!", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeEnable(Control control, bool onoff)
        {
            control.Enabled = onoff;
        }

        
        private void InitGrid()
        {
            #region User
            Core.Instance.SetGridCol_Text(grid_UserList, new DataGridViewTextBoxColumn(), "Id", "Id", true, 70, false);
            Core.Instance.SetGridCol_Text(grid_UserList, new DataGridViewTextBoxColumn(), "Name", "이름", true, 80);
            Core.Instance.SetGridCol_Text(grid_UserList, new DataGridViewTextBoxColumn(), "PhoneNumber", "핸드폰 번호", true, 120);
            Core.Instance.SetGridCol_Text(grid_UserList, new DataGridViewTextBoxColumn(), "SessionId", "세션", true, 70, false);
            Core.Instance.SetGridCol_Text(grid_UserList, new DataGridViewTextBoxColumn(), "SessionName", "세션", true, 70);
            Core.Instance.SetGridCol_Text(grid_UserList, new DataGridViewTextBoxColumn(), "RemainSession", "잔여 횟수", true, 100);
            Core.Instance.SetGridCol_Text(grid_UserList, new DataGridViewTextBoxColumn(), "RemainService", "잔여 서비스", true, 120);
            Core.Instance.SetGridCol_Text(grid_UserList, new DataGridViewTextBoxColumn(), "TrainerId", "세션", true, 70, false);
            Core.Instance.SetGridCol_Text(grid_UserList, new DataGridViewTextBoxColumn(), "TrainerName", "담당", true, 70);
            Core.Instance.SetGridCol_Text(grid_UserList, new DataGridViewTextBoxColumn(), "LockerNo", "락커번호", true, 100);
            Core.Instance.SetGridCol_Text(grid_UserList, new DataGridViewTextBoxColumn(), "BirthDay", "생일", true, 90);
            Core.Instance.SetGridCol_Text(grid_UserList, new DataGridViewTextBoxColumn(), "Memo", "메모", true, 200);
            // 헤더
            grid_UserList.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            grid_UserList.ColumnHeadersDefaultCellStyle.Font = new Font("굴림", 10f, FontStyle.Bold);
            // 셀
            grid_UserList.DefaultCellStyle.ForeColor = Color.Black;
            grid_UserList.DefaultCellStyle.Font = new Font("굴림", 9, FontStyle.Regular);

            grid_UserList.Columns["BirthDay"].DefaultCellStyle.Format = "yyyy-MM-dd";
            grid_UserList.Columns["RemainSession"].DefaultCellStyle.Format = "###,###";
            grid_UserList.Columns["RemainService"].DefaultCellStyle.Format = "###,###";
            grid_UserList.Columns["LockerNo"].DefaultCellStyle.Format = "###,###";

            grid_UserList.RowHeadersVisible = false;
            grid_UserList.AllowUserToAddRows = false;
            #endregion

            #region Trainer
            Core.Instance.SetGridCol_Text(grid_TrainerList, new DataGridViewTextBoxColumn(), "Id", "Id", true, 70, false);
            Core.Instance.SetGridCol_Text(grid_TrainerList, new DataGridViewTextBoxColumn(), "Name", "이름", true, 80);
            Core.Instance.SetGridCol_Text(grid_TrainerList, new DataGridViewTextBoxColumn(), "PhoneNumber", "핸드폰 번호", true, 120);
            Core.Instance.SetGridCol_Text(grid_TrainerList, new DataGridViewTextBoxColumn(), "Salary", "기본급", true, 120);
            Core.Instance.SetGridCol_Text(grid_TrainerList, new DataGridViewTextBoxColumn(), "LockerNo", "락커번호", true, 100);
            Core.Instance.SetGridCol_Text(grid_TrainerList, new DataGridViewTextBoxColumn(), "BirthDay", "생일", true, 90);
            Core.Instance.SetGridCol_Text(grid_TrainerList, new DataGridViewTextBoxColumn(), "Memo", "메모", true, 270);
            // 헤더
            grid_TrainerList.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            grid_TrainerList.ColumnHeadersDefaultCellStyle.Font = new Font("굴림", 10f, FontStyle.Bold);
            // 셀
            grid_TrainerList.DefaultCellStyle.ForeColor = Color.Black;
            grid_TrainerList.DefaultCellStyle.Font = new Font("굴림", 9, FontStyle.Regular);

            grid_TrainerList.Columns["BirthDay"].DefaultCellStyle.Format = "yyyy-MM-dd";
            grid_TrainerList.Columns["Salary"].DefaultCellStyle.Format = "###,###";
            grid_TrainerList.Columns["LockerNo"].DefaultCellStyle.Format = "###,###";

            grid_TrainerList.RowHeadersVisible = false;
            grid_TrainerList.AllowUserToAddRows = false;
            #endregion
        }
    }
}
