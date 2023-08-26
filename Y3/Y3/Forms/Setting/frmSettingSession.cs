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

namespace Y3.Forms.Setting
{
    public partial class frmSettingSession : Form
    {
        private enum eButton
        {
            S_INIT = 0,
            S_UPDATE = 1,
            S_DELETE = 2,

            ST_INIT = 10,
            ST_UPDATE = 11,
            ST_DELETE = 12,
        }

        private enum eGrid
        {
            SESSION = 0,
            SESSION_T = 1,
        }

        public frmSettingSession()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;

            InitEvent();
            InitGrid();
            LoadSessionData();
            LoadSTData();
        }

        #region UI Event
        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            int selectIdx = int.Parse(grid.Tag.ToString());

            switch (selectIdx)
            {
                case (int)eGrid.SESSION:
                    {
                        txtSessionNo.Text = grid_sessionPirce.CurrentRow.Cells["Id"].Value.ToString();
                        txtSessionName.Text = grid_sessionPirce.CurrentRow.Cells["SessionName"].Value.ToString();
                        txtSessionPrice.Text = decimal.Parse(grid_sessionPirce.CurrentRow.Cells["Price"].Value.ToString()).ToString("00");
                        txtSessionPer.Text = decimal.Parse(grid_sessionPirce.CurrentRow.Cells["Percentage"].Value.ToString()).ToString("00");
                        txtSessionDeduct.Text = decimal.Parse(grid_sessionPirce.CurrentRow.Cells["Deduct"].Value.ToString()).ToString("00");
                        txtSessionTotal.Text = decimal.Parse(grid_sessionPirce.CurrentRow.Cells["FinalPrice"].Value.ToString()).ToString("00");
                    }
                    break;
                case (int)eGrid.SESSION_T:
                    {
                        txtSTNo.Text = grid_ST.CurrentRow.Cells["Id"].Value.ToString();
                        comboSession.Text = grid_ST.CurrentRow.Cells["SessionName"].Value.ToString();
                        comboTrainer.Text = grid_ST.CurrentRow.Cells["TrainerName"].Value.ToString();
                        txtSTPer.Text = decimal.Parse(grid_ST.CurrentRow.Cells["Percentage"].Value.ToString()).ToString("00");
                    }
                    break;
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int selectIdx = int.Parse(btn.Tag.ToString());

            switch (selectIdx)
            {
                // session price
                case (int)eButton.S_INIT:
                    InitSessionControl();
                    break;
                case (int)eButton.S_UPDATE:
                    UpdateSessionPrice();
                    break;
                case (int)eButton.S_DELETE:
                    DeleteSessionPrice();
                    break;

                // session trainer
                case (int)eButton.ST_INIT:
                    InitSTControl();
                    break;
                case (int)eButton.ST_UPDATE:
                    UpdateST();
                    break;
                case (int)eButton.ST_DELETE:
                    DeleteST();
                    break;
            }
        }

        private void TxtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Core.Instance.TypingOnlyNumber(sender, e, true, false);
        }

        private void FrmSettingSession_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false) return;

            SetComboSession();
            SetComboTrainer();
        }

        private void TxtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSessionPrice.Text == string.Empty || txtSessionPer.Text == string.Empty || txtSessionDeduct.Text == string.Empty)
                return;

            decimal price = decimal.Parse(txtSessionPrice.Text);
            decimal per = decimal.Parse(txtSessionPer.Text);
            decimal deduct = decimal.Parse(txtSessionDeduct.Text);

            txtSessionTotal.Text = Core.Instance.CalcTotalPrice(price, per, deduct).ToString("00");
        }
        #endregion

        private void SetComboTrainer()
        {
            comboTrainer.DataSource = Core.M_TRAINER.GetCombo();
            comboTrainer.DisplayMember = "Name";
            comboTrainer.ValueMember = "Id";
        }

        private void SetComboSession()
        {
            comboSession.DataSource = Core.M_SESSION_PRICE.GetCombo();
            comboSession.DisplayMember = "SessionName";
            comboSession.ValueMember = "Id";
        }

        private void InitEvent()
        {
            this.VisibleChanged += FrmSettingSession_VisibleChanged;
            grid_sessionPirce.CellDoubleClick += Grid_CellDoubleClick;
            grid_ST.CellDoubleClick += Grid_CellDoubleClick;

            btnSessionInit.Click += Btn_Click;
            btnSessionUpdate.Click += Btn_Click;
            btnSessionDel.Click += Btn_Click;

            btnSTInit.Click += Btn_Click;
            btnSTUpdate.Click += Btn_Click;
            btnSTDel.Click += Btn_Click;

            txtSessionPrice.KeyPress += TxtPrice_KeyPress;
            txtSessionPer.KeyPress += TxtPrice_KeyPress;
            txtSessionDeduct.KeyPress += TxtPrice_KeyPress;
            txtSessionPrice.KeyUp += TxtPrice_KeyUp;
            txtSessionPer.KeyUp += TxtPrice_KeyUp;
            txtSessionDeduct.KeyUp += TxtPrice_KeyUp;

            txtSTPer.KeyPress += TxtPrice_KeyPress;
        }

        private void InitGrid()
        {
            #region SessionPrice
            Core.Instance.SetGridCol_Text(grid_sessionPirce, new DataGridViewTextBoxColumn(), "Id", "Id", true, 70, false);
            Core.Instance.SetGridCol_Text(grid_sessionPirce, new DataGridViewTextBoxColumn(), "SessionName", "세션이름", true, 100);
            Core.Instance.SetGridCol_Text(grid_sessionPirce, new DataGridViewTextBoxColumn(), "Price", "가격", true, 100);
            Core.Instance.SetGridCol_Text(grid_sessionPirce, new DataGridViewTextBoxColumn(), "Percentage", "지급률(%)", true, 105);
            Core.Instance.SetGridCol_Text(grid_sessionPirce, new DataGridViewTextBoxColumn(), "Deduct", "공제률(%)", true, 105);
            Core.Instance.SetGridCol_Text(grid_sessionPirce, new DataGridViewTextBoxColumn(), "FinalPrice", "지급금액", true, 105);
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

            #region SessionTrainer
            Core.Instance.SetGridCol_Text(grid_ST, new DataGridViewTextBoxColumn(), "Id", "Id", true, 70, false);
            Core.Instance.SetGridCol_Text(grid_ST, new DataGridViewTextBoxColumn(), "SessionId", "Id", true, 70, false);
            Core.Instance.SetGridCol_Text(grid_ST, new DataGridViewTextBoxColumn(), "TrainerId", "Id", true, 70, false);
            Core.Instance.SetGridCol_Text(grid_ST, new DataGridViewTextBoxColumn(), "TrainerName", "트레이너", true, 100);
            Core.Instance.SetGridCol_Text(grid_ST, new DataGridViewTextBoxColumn(), "SessionName", "세션", true, 100);
            Core.Instance.SetGridCol_Text(grid_ST, new DataGridViewTextBoxColumn(), "Percentage", "지급률(%)", true, 105);
            // 헤더
            grid_ST.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            grid_ST.ColumnHeadersDefaultCellStyle.Font = new Font("굴림", 10f, FontStyle.Bold);
            grid_ST.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 셀
            grid_ST.DefaultCellStyle.ForeColor = Color.Black;
            grid_ST.DefaultCellStyle.Font = new Font("굴림", 9, FontStyle.Regular);
            grid_ST.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid_ST.Columns["Percentage"].DefaultCellStyle.Format = "###,###";

            grid_ST.RowHeadersVisible = false;
            grid_ST.AllowUserToAddRows = false;
            #endregion
        }

        private void InitSessionControl()
        {
            txtSessionNo.Text = string.Empty;
            txtSessionName.Text = string.Empty;
            txtSessionPrice.Text = string.Empty;
            txtSessionPer.Text = string.Empty;
            txtSessionDeduct.Text = string.Empty;
            txtSessionTotal.Text = string.Empty;
        }

        private void InitSTControl()
        {
            txtSTNo.Text = string.Empty;
            txtSTPer.Text = string.Empty;
            comboSession.SelectedValue = 0;
            comboTrainer.SelectedValue = 0;
        }

        private void LoadSessionData()
        {
            grid_sessionPirce.DataSource = Core.M_SESSION_PRICE.GetDataTable();
        }


        private void LoadSTData()
        {
            grid_ST.DataSource = Core.M_SESSION_TRAINER.GetDataTable();
        }

        private void UpdateSessionPrice()
        {
            string sessionNo = txtSessionNo.Text;
            string sessionName = txtSessionName.Text;
            string price = txtSessionPrice.Text;
            string per = txtSessionPer.Text;
            string deduct = txtSessionDeduct.Text;
            string finalPrice = txtSessionTotal.Text;

            if (sessionName == string.Empty || price == string.Empty || per == string.Empty || deduct == string.Empty)
            {
                MessageBox.Show("세션이름, 가격, 지급률, 공제률은 필수 항목입니다.\n", "오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 중복체크
            // 이름만 중복 체크
            if (Core.M_SESSION_PRICE.Duplication(sessionName))
            {
                MessageBox.Show("동일한 세션이름이 존재합니다.\n", "오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SessionPrice d = new SessionPrice()
            {
                Id = sessionNo == "" ? 0 : int.Parse(sessionNo),
                SessionName = sessionName,
                Price = decimal.Parse(price),
                Percentage = decimal.Parse(per),
                Deduct = decimal.Parse(deduct),
                FinalPrice = decimal.Parse(finalPrice),
            };

            DBSessionPrice save = new DBSessionPrice(d, d.Id != 0 ? eDBQueryType.UPDATE : eDBQueryType.INSERT);

            if (Core.MARIA.Save(save, out long outId))
            {
                MessageBox.Show("저장 성공!", "저장 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                d.Id = (int)outId == 0 ? d.Id : (int)outId;
                Core.M_SESSION_PRICE.UpdateData(d);
                InitSessionControl();
                LoadSessionData();
                SetComboSession();
            }
            else
            {
                MessageBox.Show("저장 실패!", "저장 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateST()
        {
            string STNo = txtSTNo.Text;
            string STTrainerId = comboTrainer.SelectedValue.ToString();
            string STTrainer = comboTrainer.Text;
            string STSessionId = comboSession.SelectedValue.ToString();
            string STSession = comboSession.Text;
            string STper = txtSTPer.Text;

            if (STTrainer == "선택" || STSession == "선택" || STper == string.Empty)
            {
                MessageBox.Show("트레이너, 세션, 지급률은 필수 항목입니다.\n", "오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 중복체크
            // 세션id, TR ID 동시 체크
            if (Core.M_SESSION_TRAINER.Duplication(int.Parse(STSessionId), int.Parse(STTrainerId)))
            {
                MessageBox.Show("해당 트레이너의 세션 설정이 존재합니다.\n", "오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SessionTrainer d = new SessionTrainer()
            {
                Id = STNo == "" ? 0 : int.Parse(STNo),
                SessionId = int.Parse(STSessionId),
                SessionName = STSession,
                TrainerId = int.Parse(STTrainerId),
                TrainerName = STTrainer,
                Percentage = decimal.Parse(STper),
            };

            DBSessionTrainer save = new DBSessionTrainer(d, d.Id != 0 ? eDBQueryType.UPDATE : eDBQueryType.INSERT);

            if (Core.MARIA.Save(save, out long outId))
            {
                MessageBox.Show("저장 성공!", "저장 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                d.Id = (int)outId == 0 ? d.Id : (int)outId;
                Core.M_SESSION_TRAINER.UpdateData(d);
                InitSTControl();
                LoadSTData();
            }
            else
            {
                MessageBox.Show("저장 실패!", "저장 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteSessionPrice()
        {
            if (txtSessionNo.Text == string.Empty) return;

            int id = int.Parse(txtSessionNo.Text);

            if (MessageBox.Show("정말 삭제 하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            SessionPrice d = new SessionPrice()
            {
                Id = id,
            };
            DBSessionPrice save = new DBSessionPrice(d, eDBQueryType.DELETE);

            if (Core.MARIA.Save(save, out long outId))
            {
                MessageBox.Show("삭제 성공!", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                d.Id = (int)outId == 0 ? d.Id : (int)outId;
                Core.M_SESSION_PRICE.UpdateData(d, eDBQueryType.DELETE);
                InitSessionControl();
                LoadSessionData();
            }
            else
            {
                MessageBox.Show("삭제 실패!", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteST()
        {
            if (txtSTNo.Text == string.Empty) return;

            int id = int.Parse(txtSTNo.Text);

            if (MessageBox.Show("정말 삭제 하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            SessionTrainer d = new SessionTrainer()
            {
                Id = id,
            };
            DBSessionTrainer save = new DBSessionTrainer(d, eDBQueryType.DELETE);

            if (Core.MARIA.Save(save, out long outId))
            {
                MessageBox.Show("삭제 성공!", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                d.Id = (int)outId == 0 ? d.Id : (int)outId;
                Core.M_SESSION_TRAINER.UpdateData(d, eDBQueryType.DELETE);
                InitSTControl();
                LoadSTData();
            }
            else
            {
                MessageBox.Show("삭제 실패!", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
