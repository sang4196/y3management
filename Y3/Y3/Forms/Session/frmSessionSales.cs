using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Y3.Models;
using Y3.Models.DB;
using Y3.Utility.Enums;

namespace Y3.Forms.Session
{
    public partial class frmSessionSales : Form
    {
        private enum eButton
        {
            INIT = 0,
            UPDATE,
            DELETE,
        }

        public frmSessionSales()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;

            InitEvent();
            InitGrid();
            SetComboTrainer();
        }

        private void InitEvent()
        {
            this.VisibleChanged += FrmSessionSales_VisibleChanged;

            btnSessionInit.Click += Btn_Click;
            btnSessionUpdate.Click += Btn_Click;
            btnSessionDel.Click += Btn_Click;

            comboSearchTrainer.SelectedValueChanged += ComboSearchTrainer_SelectedValueChanged;

            dtSearchDate.ValueChanged += DtSearchDate_ValueChanged;

            grid_SalesList.CellDoubleClick += Grid_SalesList_CellDoubleClick;
        }

        #region UI Event

        private void FrmSessionSales_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false) return;

            SetComboTrainer();
        }
        private void Grid_SalesList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSalesNo.Text = grid_SalesList.CurrentRow.Cells["Id"].Value.ToString();
            txtTrainerNo.Text = grid_SalesList.CurrentRow.Cells["TrainerId"].Value.ToString();
            txtTrainerName.Text = grid_SalesList.CurrentRow.Cells["TrainerName"].Value.ToString();
            txtsalesPrice.Text = grid_SalesList.CurrentRow.Cells["SalesPrice"].Value.ToString();
            txtMemo.Text = grid_SalesList.CurrentRow.Cells["Memo"].Value.ToString();
        }

        private void DtSearchDate_ValueChanged(object sender, EventArgs e)
        {
            LoadSalesData();
        }

        private void ComboSearchTrainer_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadSalesData();

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
                    UpdateSales();
                    break;
                case (int)eButton.DELETE:
                    DeleteSales();
                    break;
            }
        }

        #endregion
        private void LoadSalesData()
        {
            if (comboSearchTrainer.SelectedValue == null || comboSearchTrainer.SelectedIndex == 0) return;

            grid_SalesList.DataSource = Core.M_TRAINER_SALES.GetDataTable((int)comboSearchTrainer.SelectedValue, dtSearchDate.Value);

            InitControl();
        }

        private void SetComboTrainer()
        {
            comboSearchTrainer.DataSource = Core.M_TRAINER.GetCombo();
            comboSearchTrainer.DisplayMember = "Name";
            comboSearchTrainer.ValueMember = "Id";
        }

        private void DeleteSales()
        {
            if (txtSalesNo.Text == string.Empty) return;

            int id = int.Parse(txtSalesNo.Text);

            if (MessageBox.Show("정말 삭제 하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            TrainerSales d = new TrainerSales()
            {
                Id = id,
            };

            if (Core.M_TRAINER_SALES.Save(d, eDBQueryType.DELETE))
            {
                LoadSalesData();
            }
        }

        private void UpdateSales()
        {
            string salesId = txtSalesNo.Text;
            string salesPrice = txtsalesPrice.Text;
            string trainerID = comboSearchTrainer.SelectedValue.ToString();
            string trainerName = comboSearchTrainer.Text;
            string memo = txtMemo.Text;
            DateTime sessionDate = dtSearchDate.Value;

            if (trainerID == string.Empty || trainerID == "0" || salesPrice == string.Empty)
            {
                MessageBox.Show("트레이너, 매출금액은 필수 항목입니다.\n", "오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 중복체크 필요없을듯


            TrainerSales d = new TrainerSales()
            {
                Id = salesId == "" ? 0 : int.Parse(salesId),
                SalesPrice = int.Parse(salesPrice),
                TrainerId = int.Parse(trainerID),
                TrainerName = trainerName,
                SalesDate = sessionDate,
                Memo = memo,
            };

            if (Core.M_TRAINER_SALES.Save(d, d.Id != 0 ? eDBQueryType.UPDATE : eDBQueryType.INSERT))
            {
                LoadSalesData();
            }
        }

        private void InitControl()
        {
            txtSalesNo.Text = string.Empty;
            txtsalesPrice.Text = string.Empty;
            //txtTrainerName.Text = string.Empty;
            //txtTrainerNo.Text = string.Empty;
            txtMemo.Text = string.Empty;
        }

        private void InitGrid()
        {
            Core.Instance.SetGridCol_Text(grid_SalesList, new DataGridViewTextBoxColumn(), "Id", "Id", true, 70, false);
            Core.Instance.SetGridCol_Text(grid_SalesList, new DataGridViewTextBoxColumn(), "TrainerId", "TR ID", true, 90, false);
            Core.Instance.SetGridCol_Text(grid_SalesList, new DataGridViewTextBoxColumn(), "TrainerName", "TR 이름", true, 120, false);
            Core.Instance.SetGridCol_Text(grid_SalesList, new DataGridViewTextBoxColumn(), "SalesPrice", "매출금액", true, 100);
            Core.Instance.SetGridCol_Text(grid_SalesList, new DataGridViewTextBoxColumn(), "SalesDate", "매출금액", true, 150, false);
            Core.Instance.SetGridCol_Text(grid_SalesList, new DataGridViewTextBoxColumn(), "Memo", "메모", true, 400);
            // 헤더
            grid_SalesList.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            grid_SalesList.ColumnHeadersDefaultCellStyle.Font = new Font("굴림", 10f, FontStyle.Bold);
            grid_SalesList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 셀
            grid_SalesList.DefaultCellStyle.ForeColor = Color.Black;
            grid_SalesList.DefaultCellStyle.Font = new Font("굴림", 9, FontStyle.Regular);
            grid_SalesList.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid_SalesList.Columns["SalesPrice"].DefaultCellStyle.Format = "###,###";

            grid_SalesList.RowHeadersVisible = false;
            grid_SalesList.AllowUserToAddRows = false;
        }
    }
}
