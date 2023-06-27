using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Y3.Utility.Enums;

namespace Y3.Forms.Popup
{
    public partial class popUser : Form
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        private eUserType _type;

        public popUser(eUserType userType)
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;

            _type = userType;

            InitEvent();
            InitGrid();

            if (userType == eUserType.USER)
            {
                groupBox1.Text = " 회원 리스트 ";
                LoadUserData();
            }
            else
            {
                groupBox1.Text = " 트레이너 리스트 ";
                panel1.Visible = false;
                LoadTrainerData();
            }
        }

        private void InitEvent()
        {
            txtSearchUser.KeyUp += TxtSearchUser_KeyUp;

            btnChoose.Click += BtnChoose_Click;
            btnClose.Click += BtnClose_Click;

            grid_List.CellDoubleClick += Grid_List_CellDoubleClick;
        }

        private void Grid_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = (int)e.RowIndex;
            ID = int.Parse(grid_List.Rows[r].Cells["Id"].Value.ToString());
            NAME = grid_List.Rows[r].Cells["Name"].Value.ToString();

            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnChoose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            int r = grid_List.SelectedCells[0].RowIndex;

            ID = int.Parse(grid_List.Rows[r].Cells["Id"].Value.ToString());
            NAME = grid_List.Rows[r].Cells["Name"].Value.ToString();

            this.Close();
        }
        private void TxtSearchUser_KeyUp(object sender, KeyEventArgs e)
        {
            string filter = txtSearchUser.Text;
            LoadUserData(filter);
        }

        private void InitGrid()
        {
            if(_type == eUserType.USER)
            {
                Core.Instance.SetGridCol_Text(grid_List, new DataGridViewTextBoxColumn(), "Id", "Id", true, 70, false);
                Core.Instance.SetGridCol_Text(grid_List, new DataGridViewTextBoxColumn(), "Name", "이름", true, 80);
                Core.Instance.SetGridCol_Text(grid_List, new DataGridViewTextBoxColumn(), "PhoneNumber", "핸드폰 번호", true, 120);
                Core.Instance.SetGridCol_Text(grid_List, new DataGridViewTextBoxColumn(), "LockerNo", "락커번호", true, 100);
                Core.Instance.SetGridCol_Text(grid_List, new DataGridViewTextBoxColumn(), "SessionId", "세션", true, 70, false);
                Core.Instance.SetGridCol_Text(grid_List, new DataGridViewTextBoxColumn(), "SessionName", "세션", true, 70);
                Core.Instance.SetGridCol_Text(grid_List, new DataGridViewTextBoxColumn(), "RemainSession", "잔여 횟수", true, 100);
                Core.Instance.SetGridCol_Text(grid_List, new DataGridViewTextBoxColumn(), "RemainService", "잔여 서비스", true, 120);
                Core.Instance.SetGridCol_Text(grid_List, new DataGridViewTextBoxColumn(), "BirthDay", "생일", true, 90, false);
                Core.Instance.SetGridCol_Text(grid_List, new DataGridViewTextBoxColumn(), "Memo", "메모", true, 200);
                
                grid_List.Columns["BirthDay"].DefaultCellStyle.Format = "yyyy-MM-dd";
                grid_List.Columns["RemainSession"].DefaultCellStyle.Format = "###,###";
                grid_List.Columns["RemainService"].DefaultCellStyle.Format = "###,###";
                grid_List.Columns["LockerNo"].DefaultCellStyle.Format = "###,###";
            }
            else
            {
                Core.Instance.SetGridCol_Text(grid_List, new DataGridViewTextBoxColumn(), "Id", "Id", true, 70, false);
                Core.Instance.SetGridCol_Text(grid_List, new DataGridViewTextBoxColumn(), "Name", "이름", true, 80);
                Core.Instance.SetGridCol_Text(grid_List, new DataGridViewTextBoxColumn(), "PhoneNumber", "핸드폰 번호", true, 120);
                Core.Instance.SetGridCol_Text(grid_List, new DataGridViewTextBoxColumn(), "Salary", "기본급", true, 120);
                Core.Instance.SetGridCol_Text(grid_List, new DataGridViewTextBoxColumn(), "LockerNo", "락커번호", true, 100);
                Core.Instance.SetGridCol_Text(grid_List, new DataGridViewTextBoxColumn(), "BirthDay", "생일", true, 90);
                Core.Instance.SetGridCol_Text(grid_List, new DataGridViewTextBoxColumn(), "Memo", "메모", true, 270);

                grid_List.Columns["BirthDay"].DefaultCellStyle.Format = "yyyy-MM-dd";
                grid_List.Columns["Salary"].DefaultCellStyle.Format = "###,###";
            }

            // 헤더
            grid_List.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            grid_List.ColumnHeadersDefaultCellStyle.Font = new Font("굴림", 10f, FontStyle.Bold);
            // 셀
            grid_List.DefaultCellStyle.ForeColor = Color.Black;
            grid_List.DefaultCellStyle.Font = new Font("굴림", 9, FontStyle.Regular);

            grid_List.MultiSelect = false;
            grid_List.RowHeadersVisible = false;
            grid_List.AllowUserToAddRows = false;
        }

        private void LoadTrainerData()
        {
            grid_List.DataSource = Core.MODELS.GetTrainersDataTable();
        }

        private void LoadUserData(string filter = "")
        {
            DataTable dt = Core.MODELS.GetUsersDataTable();
            if (filter != "")
            {
                DataTable dtFilter = ((DataTable)grid_List.DataSource).Clone();
                var var = dt.AsEnumerable()
                        .Where(row => row.Field<String>("Name").Contains(filter)
                                || row.Field<String>("PhoneNumber").Contains(filter));

                if (var.ToList().Count > 0)
                {
                    dtFilter = var.OrderByDescending(row => row.Field<int>("Id")).CopyToDataTable();
                }

                grid_List.DataSource = dtFilter;
            }
            else
            {
                grid_List.DataSource = dt;
            }
        }
    }
}
