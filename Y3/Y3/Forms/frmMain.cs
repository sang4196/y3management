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
using Y3.Properties;
using static Y3.Enums;

namespace Y3.Forms
{
    public partial class frmMain : Form
    {
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

        public frmMain()
        {
            InitializeComponent();

            this.AutoScaleMode = AutoScaleMode.Dpi;

            InitEvent();
            InitControl();

            Core.Instance._frmMain = this;
            Core.Instance.InitCore();

            InitBirthday();
        }

        private void InitBirthday()
        {
            var user = Core.MODELS.GetMonthBirthUser();
            var trainer = Core.MODELS.GetMonthBirthTrainer();
            foreach (var item in user)
            {
                listBoxBirthUser.Items.Add(item.GetBirthString());
            }
            foreach (var item in trainer)
            {
                listBoxBirthTrainer.Items.Add(item.GetBirthString());
            }
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
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        private void ChangeMenuName(string name)
        {
            label_menuName.Text = name;
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

            switch(selectIdx)
            {
                // main menu
                case (int)eButton.MAIN:
                    SubMenuInit();
                    InitBirthday();
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
