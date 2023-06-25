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
using Y3.Utility;

namespace Y3.Forms.Session
{
    public partial class frmSessionStats : Form
    {
        private enum eDataType
        {
            MONTH,
            CUSTOM
        }

        private List<DataGridView> _grid = new List<DataGridView>();
        private List<DataGridView> _gridMonth = new List<DataGridView>();
        private DataTable _monthDT;
        private DataTable _commonDT;

        private List<SessionPrice> _sessionPrice = new List<SessionPrice>();
        private List<Trainer> _trainer = new List<Trainer>();
        private List<TrainerSales> _trainerSales = new List<TrainerSales>();

        public frmSessionStats()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;

            InitEvent();

            _grid.Add(gridMonth);
            _grid.Add(gridSearch);

            _gridMonth.Add(gridSessionCount);
            _gridMonth.Add(gridIncome);
            _gridMonth.Add(gridSales);

            _monthDT = new DataTable();
            _monthDT.Columns.Add("TrainerName");
            _monthDT.Columns.Add("Total", typeof(int));
            _monthDT.Columns.Add("Avg", typeof(int));
            for (int i = 1; i <= 12; i++)
            {
                _monthDT.Columns.Add(i.ToString(), typeof(int));
            }

            groupBox1.Text = $" {DateTime.Now.ToString(TimeUtil.TIME_FORMAT_6)} 세션 별 ";
            groupBox2.Text = $" {DateTime.Now.ToString(TimeUtil.TIME_FORMAT_8)}년 월별 수업 수";
            groupBox4.Text = $" {DateTime.Now.ToString(TimeUtil.TIME_FORMAT_8)}년 월별 수입 ";
            groupBox5.Text = $" {DateTime.Now.ToString(TimeUtil.TIME_FORMAT_8)}년 월별 매출 ";
        }

        private void InitEvent()
        {
            this.VisibleChanged += FrmSessionMain_VisibleChanged;

            btnYearSearch.Click += BtnYearSearch_Click;
            btnSearch.Click += BtnSearch_Click;
        }


        #region UI Event

        private void BtnYearSearch_Click(object sender, EventArgs e)
        {
            LoadMonthlyData();

            groupBox2.Text = $" {dtSearchYear.Value.ToString(TimeUtil.TIME_FORMAT_8)}년 월별 수업 수";
            groupBox4.Text = $" {dtSearchYear.Value.ToString(TimeUtil.TIME_FORMAT_8)}년 월별 수입 ";
            groupBox5.Text = $" {dtSearchYear.Value.ToString(TimeUtil.TIME_FORMAT_8)}년 월별 매출 ";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            LoadData(eDataType.CUSTOM);
        }

        private void FrmSessionMain_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false) return;

            gridMonth.DataSource = null;
            gridSearch.DataSource = null;
            gridIncome.DataSource = null;
            gridSales.DataSource = null;
            gridSessionCount.DataSource = null;
            gridMonth.Columns.Clear();
            gridSearch.Columns.Clear();
            gridIncome.Columns.Clear();
            gridSales.Columns.Clear();
            gridSessionCount.Columns.Clear();

            _sessionPrice = Core.MODELS.GetSessionPrices();
            _trainer = Core.MODELS.GetTrainers();
            _trainerSales = Core.MODELS.GetTrainerSales();

            _commonDT = new DataTable();
            _commonDT.Columns.Add("TrainerName");
            _commonDT.Columns.Add("TotalPrice", typeof(int));
            _commonDT.Columns.Add("TotalCount", typeof(int));
            foreach (SessionPrice sp in _sessionPrice)
            {
                _commonDT.Columns.Add(sp.Id.ToString(), typeof(int));
            }

            InitGrid();
            LoadData(eDataType.MONTH);
            LoadMonthlyData();
        }

        #endregion
        private void LoadMonthlyData()
        {
            DateTime searchYear = dtSearchYear.Value;
            // 시작날짜 해당년도 1월1일 00시00분00초
            // 끝날짜 해당년도 12월31일 23시59분59초
            DateTime startDt = new DateTime(searchYear.Year, 1, 1, 00, 00, 00);
            DateTime endDt = new DateTime(searchYear.Year, 12, 31, 23, 59, 59);

            DataTable dtIncome = _monthDT.Clone();
            DataTable dtSessionCount = _monthDT.Clone();
            DataTable dtSales = _monthDT.Clone();
            DataRow drIncome = dtIncome.NewRow();
            DataRow drSessionCount = dtSessionCount.NewRow();
            DataRow drSales = dtSales.NewRow();
            foreach (Trainer trainer in _trainer)
            {
                drIncome = dtIncome.NewRow();
                drSessionCount = dtSessionCount.NewRow();
                drSales = dtSales.NewRow();

                List<Models.Session> sessions = Core.MODELS.GetSessions(trainer.Id, startDt, endDt);
                decimal totalPrice = sessions.Sum(p => p.SessionTotalPrice);
                int totalCount = sessions.Sum(p => p.SessionCount);

                drIncome["TrainerName"] = trainer.Name;
                drIncome["Total"] = totalPrice;
                drIncome["Avg"] = totalPrice / 12;
                drSessionCount["TrainerName"] = trainer.Name;
                drSessionCount["Total"] = totalCount;
                drSessionCount["Avg"] = totalCount / 12;

                List<TrainerSales> ts = Core.MODELS.GetTrainerSales(trainer.Id, startDt, endDt);
                long totalSales = ts.Sum(p => p.SalesPrice);
                drSales["TrainerName"] = trainer.Name;
                drSales["Total"] = totalSales;
                drSales["Avg"] = totalSales / 12;

                for (int i = 1; i <= 12; i++)
                {
                    List<Models.Session> filter = sessions.Where(p => p.Date.Month == i).ToList();
                    List<TrainerSales> filterTs = ts.Where(p => p.SalesDate.Month == i).ToList();
                    if (filter.Count > 0)
                    {
                        drIncome[i.ToString()] = filter.Sum(p => p.SessionTotalPrice);
                        drSessionCount[i.ToString()] = filter.Sum(p => p.SessionCount);
                    }
                    else
                    {
                        drIncome[i.ToString()] = 0;
                        drSessionCount[i.ToString()] = 0;
                    }

                    if (filterTs.Count > 0)
                    {
                        drSales[i.ToString()] = filterTs.Sum(p => p.SalesPrice);
                    }
                    else
                    {
                        drSales[i.ToString()] = 0;
                    }
                }
                dtIncome.Rows.Add(drIncome);
                dtSessionCount.Rows.Add(drSessionCount);
                dtSales.Rows.Add(drSales);
            }

            gridIncome.DataSource = dtIncome;
            gridSessionCount.DataSource = dtSessionCount;
            gridSales.DataSource = dtSales;
        }

        private void LoadData(eDataType dataType)
        {
            DateTime startDt = DateTime.Now;
            DateTime endDt = DateTime.Now;
            DateTime searchStart = dtSearchStart.Value;
            DateTime searchEnd = dtSearchEnd.Value;
            DataGridView grid = null;

            switch (dataType)
            {
                case eDataType.MONTH:
                    startDt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 0, 0, 0);
                    endDt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month), 23, 59, 59);
                    grid = gridMonth;
                    break;
                case eDataType.CUSTOM:
                    
                    startDt = new DateTime(searchStart.Year, searchStart.Month, 1, 0, 0, 0);
                    endDt = new DateTime(searchEnd.Year, searchEnd.Month, DateTime.DaysInMonth(searchEnd.Year, searchEnd.Month), 23, 59, 59);
                    grid = gridSearch;
                    break;
            }

            DataTable dt = _commonDT.Clone();
            DataRow dr = dt.NewRow();
            foreach (Trainer trainer in _trainer)
            {
                dr = dt.NewRow();
                List<Models.Session> sessions = Core.MODELS.GetSessions(trainer.Id, startDt, endDt);
                decimal totalPrice = sessions.Sum(p => p.SessionTotalPrice);
                int totalCount = sessions.Sum(p => p.SessionCount);

                dr["TrainerName"] = trainer.Name;
                dr["TotalPrice"] = totalPrice;
                dr["TotalCount"] = totalCount;

                foreach (SessionPrice sessionPrice in _sessionPrice)
                {
                    List<Models.Session> filter = sessions.Where(p => p.SessionPriceId == sessionPrice.Id).ToList();
                    if (filter.Count > 0) dr[sessionPrice.Id.ToString()] = filter?.Sum(p => p.SessionCount);
                    else dr[sessionPrice.Id.ToString()] = 0;
                }
                dt.Rows.Add(dr);
            }
            grid.DataSource = dt;
        }

        private void InitGrid()
        {
            foreach (DataGridView grid in _grid)
            {
                Core.Instance.SetGridCol_Text(grid, new DataGridViewTextBoxColumn(), "TrainerName", "트레이너", true, 100);
                Core.Instance.SetGridCol_Text(grid, new DataGridViewTextBoxColumn(), "TotalPrice", "총 금액", true, 100);
                Core.Instance.SetGridCol_Text(grid, new DataGridViewTextBoxColumn(), "TotalCount", "합계", true, 100);

                foreach (SessionPrice sp in _sessionPrice)
                {
                    Core.Instance.SetGridCol_Text(grid, new DataGridViewTextBoxColumn(), sp.Id.ToString(), sp.SessionName, true, 90);
                    grid.Columns[sp.Id.ToString()].DefaultCellStyle.Format = "###,###";
                }

                // 헤더
                grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                grid.ColumnHeadersDefaultCellStyle.Font = new Font("굴림", 10f, FontStyle.Bold);
                grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                // 셀
                grid.DefaultCellStyle.ForeColor = Color.Black;
                grid.DefaultCellStyle.Font = new Font("굴림", 9, FontStyle.Regular);
                grid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                grid.Columns["TotalPrice"].DefaultCellStyle.Format = "###,###";
                grid.Columns["TotalCount"].DefaultCellStyle.Format = "###,###";

                grid.Columns["TotalPrice"].DefaultCellStyle.BackColor = Color.LightPink;
                grid.Columns["TotalCount"].DefaultCellStyle.BackColor = Color.LightPink;

                grid.RowHeadersVisible = false;
                grid.AllowUserToAddRows = false;
            }

            foreach (DataGridView grid in _gridMonth)
            {
                Core.Instance.SetGridCol_Text(grid, new DataGridViewTextBoxColumn(), "TrainerName", "트레이너", true, 100);
                Core.Instance.SetGridCol_Text(grid, new DataGridViewTextBoxColumn(), "Total", "합계", true, 100);
                Core.Instance.SetGridCol_Text(grid, new DataGridViewTextBoxColumn(), "Avg", "평균", true, 100);

                for (int i = 1; i <= 12; i++)
                {
                    Core.Instance.SetGridCol_Text(grid, new DataGridViewTextBoxColumn(), i.ToString(), $"{i}월", true, 90);
                    grid.Columns[i.ToString()].DefaultCellStyle.Format = "###,###";
                }

                InitMonthGridDetail(grid);
            }
        }

        private void InitMonthGridDetail(DataGridView grid)
        {
            // 헤더
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("굴림", 10f, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 셀
            grid.DefaultCellStyle.ForeColor = Color.Black;
            grid.DefaultCellStyle.Font = new Font("굴림", 9, FontStyle.Regular);
            grid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid.Columns["Total"].DefaultCellStyle.Format = "###,###";
            grid.Columns["Avg"].DefaultCellStyle.Format = "###,###";

            grid.Columns["Total"].DefaultCellStyle.BackColor = Color.LightPink;
            grid.Columns["Avg"].DefaultCellStyle.BackColor = Color.LightPink;

            grid.RowHeadersVisible = false;
            grid.AllowUserToAddRows = false;
        }
    }
}
