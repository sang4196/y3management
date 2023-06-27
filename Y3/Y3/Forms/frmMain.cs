using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Y3.Forms.Popup;
using Y3.Models;
using Y3.Properties;
using Y3.UserControls;
using Y3.Utility;
using Y3.Utility.Enums;
using static Y3.Enums;

namespace Y3.Forms
{
    public partial class frmMain : Form
    {
        private enum eLockerButton
        {
            NO_PLUS = 0,
            NO_MINUS,
            OWNER_PLUS,
            OWNER_MINUS,
        }

        private enum eButton
        {
            MAIN = 0,

            FINANCE = 100,
            FINANCE_MAIN = 101,

            SESSION = 200,
            SESSION_STATS = 201,
            SESSION_REGISTER = 202,
            SESSION_SALES = 203,

            SETTING = 900,
            SETTING_USER = 901,
            SETTING_SESSION = 902,

            EXIT = 9999
        }

        // 창 이동
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        static extern bool ReleaseCapture();
        //

        const int SUBMENU_COUNT = 3;

        private Panel[] _subPanels = new Panel[SUBMENU_COUNT];
        private Dictionary<int, UCLocker> _lockers = new Dictionary<int, UCLocker>();

        

        public frmMain()
        {
            InitializeComponent();

            this.AutoScaleMode = AutoScaleMode.Dpi;

            InitEvent();
            InitControl();

            Core.Instance._frmMain = this;
            Core.Instance.InitCore();

            MakeLocker();
        }

        private void InitEvent()
        {
            pictureBox_logo.MouseDown += PictureBox1_MouseDown;

            btnMain.Click += BtnMenu_Click;
            btnFinance.Click += BtnMenu_Click;
            btnFinanceSubMain.Click += BtnSub_Click;

            btnSession.Click += BtnMenu_Click;
            btnSessionSubMain.Click += BtnSub_Click;
            btnSessionReg.Click += BtnSub_Click;
            btnSessionSales.Click += BtnSub_Click;

            btnSetting.Click += BtnMenu_Click;
            btnSettingUser.Click += BtnSub_Click;
            btnSettingTrainer.Click += BtnSub_Click;
            btnSettingSession.Click += BtnSub_Click;

            btnExist.Click += BtnMenu_Click;
            btn_minimize.Click += Btn_minimize_Click;

            btnNoMinus.Click += BtnLockerFont_Click;
            btnNoPlus.Click += BtnLockerFont_Click;
            btnOwnerMinus.Click += BtnLockerFont_Click;
            btnOwnerPlus.Click += BtnLockerFont_Click;
        }

        #region UI Event

        private void BtnLockerFont_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int selectIdx = int.Parse(btn.Tag.ToString());

            switch (selectIdx)
            {
                case (int)eLockerButton.NO_PLUS:
                    Core.CONFIG.LOCKER_NO_FONT_SIZE += 0.25f;
                    break;
                case (int)eLockerButton.NO_MINUS:
                    Core.CONFIG.LOCKER_NO_FONT_SIZE -= 0.25f;
                    break;
                case (int)eLockerButton.OWNER_PLUS:
                    Core.CONFIG.LOCKER_OWNER_FONT_SIZE += 0.25f;
                    break;
                case (int)eLockerButton.OWNER_MINUS:
                    Core.CONFIG.LOCKER_OWNER_FONT_SIZE -= 0.25f;
                    break;
            }
            Core.Instance.SaveConfig();

            foreach (int item in _lockers.Keys)
            {
                _lockers[item].SetNoFontSize(Core.CONFIG.LOCKER_NO_FONT_SIZE);
                _lockers[item].SetOwnerFontSize(Core.CONFIG.LOCKER_OWNER_FONT_SIZE);
            }
        }

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            //hideSubmenu();
            Button btn = (Button)sender;
            int selectIdx = int.Parse(btn.Tag.ToString());
            string subtitle = string.Empty;

            switch (selectIdx)
            {
                // sub menu
                // finance
                case (int)eButton.FINANCE_MAIN:
                    openChildForm(Core.FORM_FINANCE_MAIN);
                    subtitle = " ▶ 가계부";
                    break;

                // session
                case (int)eButton.SESSION_STATS:
                    openChildForm(Core.FORM_SESSION_MAIN);
                    subtitle = " ▶ 세션정산";
                    break;
                case (int)eButton.SESSION_REGISTER:
                    openChildForm(Core.FORM_SESSION_REGISTER);
                    subtitle = " ▶ 세션정산";
                    break;
                case (int)eButton.SESSION_SALES:
                    openChildForm(Core.FORM_SESSION_SALES);
                    subtitle = " ▶ 세션정산";
                    break;

                // setting
                case (int)eButton.SETTING_USER:
                    openChildForm(Core.FORM_SETTING_USER);
                    subtitle = " ▶ 설정";
                    break;
                case (int)eButton.SETTING_SESSION:
                    openChildForm(Core.FORM_SETTING_SESSION);
                    subtitle = " ▶ 설정";
                    break;
            }
            ChangeMenuName($"{subtitle} - {btn.Text}");
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int selectIdx = int.Parse(btn.Tag.ToString());

            switch (selectIdx)
            {
                // main menu
                case (int)eButton.MAIN:
                    SubMenuInit();
                    openChildForm(null);
                    ChangeMenuName(" ▶ 메인화면");
                    break;
                case (int)eButton.FINANCE:
                    //showSubmenu(panelSubmenuFinance);
                    break;
                case (int)eButton.SESSION:
                    showSubmenu(panelSubmenuSession);
                    break;
                case (int)eButton.SETTING:
                    showSubmenu(panelSubmenuSetting);
                    break;
                case (int)eButton.EXIT:
                    Core.Instance.CloseProc();
                    break;
            }
        }
        private void Locker_ButtonClickEvent(Utility.Enums.eUserType userType, int userId, int lockNo)
        {
            popLocker pop = new popLocker(userType, userId, lockNo);
            pop.ShowDialog();
        }

        #endregion

        private void MakeLocker()
        {
            int lockerCount = 0;
            int lockerLength = (int)Math.Floor(Math.Sqrt(Core.CONFIG.LOCKER_COUNT)) + 1;
            tableLayoutPanel_locker.Controls.Clear();
            tableLayoutPanel_locker.ColumnStyles.Clear();
            tableLayoutPanel_locker.RowStyles.Clear();

            tableLayoutPanel_locker.RowCount = lockerLength;
            tableLayoutPanel_locker.ColumnCount = lockerLength;

            _lockers.Clear();
            for (int c = 0; c < lockerLength; c++)
            {
                tableLayoutPanel_locker.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / lockerLength));

                for (int r = 0; r < lockerLength; r++)
                {
                    if (c == 0)
                    {
                        tableLayoutPanel_locker.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / lockerLength));
                    }

                    if (lockerCount < Core.CONFIG.LOCKER_COUNT)
                    {
                        UCLocker locker = new UCLocker();
                        locker.LOCKER_NO = ++lockerCount;
                        locker.SetNoFontSize(Core.CONFIG.LOCKER_NO_FONT_SIZE);
                        locker.SetOwnerFontSize(Core.CONFIG.LOCKER_OWNER_FONT_SIZE);
                        locker.ButtonClickEvent += Locker_ButtonClickEvent;
                        _lockers.Add(lockerCount, locker);
                        tableLayoutPanel_locker.Controls.Add(locker, r, c);
                    }
                }
            }

            foreach (Locker item in Core.MODELS.GetLockers())
            {
                if (item.OwnerId != 0)
                {
                    _lockers[item.LockerNo].SetLockerOwner(item);

                    SetLockerColor(item);
                }
            }

            
        }

        private void SetLockerColor(Locker item)
        {
            if (item.EndDate != DateTime.MinValue)
            {
                if (TimeUtil.GetStartDay(DateTime.Now) > item.EndDate)
                {
                    _lockers[item.LockerNo].SetOwnerColor(Color.Red);
                }
                else if (TimeUtil.GetStartDay(DateTime.Now).AddDays(7) >= item.EndDate)
                {
                    _lockers[item.LockerNo].SetOwnerColor(Color.Yellow);
                }
            }
        }

        public void EndLocker(int lockerNo)
        {
            _lockers[lockerNo].InitOwner();
        }

        public void UpdateLocker(Locker locker)
        {
            _lockers[locker.LockerNo].SetLockerOwner(locker);
            SetLockerColor(locker);
        }

        private void InitControl()
        {
            ChangeStatusString(false);

            SubMenuInit();
        }

        public void ChangeStatusString(bool isDBConnect)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate { ChangeStatusString(isDBConnect); }));
            }
            versionString.Text = $"Ver {Application.ProductVersion.ToString()}  DBConnect - {isDBConnect}";
        }

        private void SubMenuInit()
        {
            _subPanels[0] = panelSubmenuFinance;
            _subPanels[1] = panelSubmenuSession;
            _subPanels[2] = panelSubmenuSetting;

            for (int i = 0; i < SUBMENU_COUNT; i++)
            {
                _subPanels[i].Visible = false;
            }
        }

        
        private void ChangeMenuName(string name)
        {
            label_menuName.Text = name;
        }

        

        private void hideSubmenu()
        {
            for (int i = 0; i < SUBMENU_COUNT; i++)
            {
                if (_subPanels[i].Visible == true)
                    _subPanels[i].Visible = false;
            }
        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Hide();
            if (childForm != null)
            {
                panelMain.Hide();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelWindow.Controls.Add(childForm);
                panelWindow.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            else
            {
                panelMain.Show();
            }
        }

    }
}
