namespace Y3.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.versionString = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelSubmenuSetting = new System.Windows.Forms.Panel();
            this.btnSettingSession = new System.Windows.Forms.Button();
            this.btnSettingTrainer = new System.Windows.Forms.Button();
            this.btnSettingUser = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.panelSubmenuSession = new System.Windows.Forms.Panel();
            this.btnSessionSales = new System.Windows.Forms.Button();
            this.btnSessionReg = new System.Windows.Forms.Button();
            this.btnSessionSubMain = new System.Windows.Forms.Button();
            this.btnSession = new System.Windows.Forms.Button();
            this.panelSubmenuFinance = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnFinanceSubMain = new System.Windows.Forms.Button();
            this.btnFinance = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnExist = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.panelWindow = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.label_menuName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_locker = new System.Windows.Forms.TableLayoutPanel();
            this.btnNoPlus = new System.Windows.Forms.Button();
            this.btnNoMinus = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOwnerMinus = new System.Windows.Forms.Button();
            this.btnOwnerPlus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelSubmenuSetting.SuspendLayout();
            this.panelSubmenuSession.SuspendLayout();
            this.panelSubmenuFinance.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panelWindow.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionString});
            this.statusStrip1.Location = new System.Drawing.Point(0, 775);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1447, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // versionString
            // 
            this.versionString.Name = "versionString";
            this.versionString.Size = new System.Drawing.Size(121, 17);
            this.versionString.Text = "toolStripStatusLabel1";
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.panelSubmenuSetting);
            this.panelSideMenu.Controls.Add(this.btnSetting);
            this.panelSideMenu.Controls.Add(this.panelSubmenuSession);
            this.panelSideMenu.Controls.Add(this.btnSession);
            this.panelSideMenu.Controls.Add(this.panelSubmenuFinance);
            this.panelSideMenu.Controls.Add(this.btnFinance);
            this.panelSideMenu.Controls.Add(this.btnMain);
            this.panelSideMenu.Controls.Add(this.btnExist);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 775);
            this.panelSideMenu.TabIndex = 3;
            // 
            // panelSubmenuSetting
            // 
            this.panelSubmenuSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubmenuSetting.Controls.Add(this.btnSettingSession);
            this.panelSubmenuSetting.Controls.Add(this.btnSettingTrainer);
            this.panelSubmenuSetting.Controls.Add(this.btnSettingUser);
            this.panelSubmenuSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenuSetting.Location = new System.Drawing.Point(0, 524);
            this.panelSubmenuSetting.Name = "panelSubmenuSetting";
            this.panelSubmenuSetting.Size = new System.Drawing.Size(250, 122);
            this.panelSubmenuSetting.TabIndex = 13;
            // 
            // btnSettingSession
            // 
            this.btnSettingSession.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettingSession.FlatAppearance.BorderSize = 0;
            this.btnSettingSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingSession.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettingSession.Location = new System.Drawing.Point(0, 80);
            this.btnSettingSession.Name = "btnSettingSession";
            this.btnSettingSession.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSettingSession.Size = new System.Drawing.Size(250, 40);
            this.btnSettingSession.TabIndex = 3;
            this.btnSettingSession.Tag = "903";
            this.btnSettingSession.Text = "세션관련";
            this.btnSettingSession.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettingSession.UseVisualStyleBackColor = true;
            this.btnSettingSession.Visible = false;
            // 
            // btnSettingTrainer
            // 
            this.btnSettingTrainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettingTrainer.FlatAppearance.BorderSize = 0;
            this.btnSettingTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingTrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingTrainer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettingTrainer.Location = new System.Drawing.Point(0, 40);
            this.btnSettingTrainer.Name = "btnSettingTrainer";
            this.btnSettingTrainer.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSettingTrainer.Size = new System.Drawing.Size(250, 40);
            this.btnSettingTrainer.TabIndex = 2;
            this.btnSettingTrainer.Tag = "902";
            this.btnSettingTrainer.Text = "세션관련";
            this.btnSettingTrainer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettingTrainer.UseVisualStyleBackColor = true;
            // 
            // btnSettingUser
            // 
            this.btnSettingUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettingUser.FlatAppearance.BorderSize = 0;
            this.btnSettingUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettingUser.Location = new System.Drawing.Point(0, 0);
            this.btnSettingUser.Name = "btnSettingUser";
            this.btnSettingUser.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSettingUser.Size = new System.Drawing.Size(250, 40);
            this.btnSettingUser.TabIndex = 1;
            this.btnSettingUser.Tag = "901";
            this.btnSettingUser.Text = "유저관리";
            this.btnSettingUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettingUser.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSetting.Location = new System.Drawing.Point(0, 479);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(250, 45);
            this.btnSetting.TabIndex = 12;
            this.btnSetting.Tag = "900";
            this.btnSetting.Text = "설정";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // panelSubmenuSession
            // 
            this.panelSubmenuSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubmenuSession.Controls.Add(this.btnSessionSales);
            this.panelSubmenuSession.Controls.Add(this.btnSessionReg);
            this.panelSubmenuSession.Controls.Add(this.btnSessionSubMain);
            this.panelSubmenuSession.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenuSession.Location = new System.Drawing.Point(0, 357);
            this.panelSubmenuSession.Name = "panelSubmenuSession";
            this.panelSubmenuSession.Size = new System.Drawing.Size(250, 122);
            this.panelSubmenuSession.TabIndex = 11;
            // 
            // btnSessionSales
            // 
            this.btnSessionSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSessionSales.FlatAppearance.BorderSize = 0;
            this.btnSessionSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSessionSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSessionSales.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSessionSales.Location = new System.Drawing.Point(0, 80);
            this.btnSessionSales.Name = "btnSessionSales";
            this.btnSessionSales.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSessionSales.Size = new System.Drawing.Size(250, 40);
            this.btnSessionSales.TabIndex = 3;
            this.btnSessionSales.Tag = "203";
            this.btnSessionSales.Text = "개인 매출등록";
            this.btnSessionSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSessionSales.UseVisualStyleBackColor = true;
            // 
            // btnSessionReg
            // 
            this.btnSessionReg.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSessionReg.FlatAppearance.BorderSize = 0;
            this.btnSessionReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSessionReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSessionReg.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSessionReg.Location = new System.Drawing.Point(0, 40);
            this.btnSessionReg.Name = "btnSessionReg";
            this.btnSessionReg.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSessionReg.Size = new System.Drawing.Size(250, 40);
            this.btnSessionReg.TabIndex = 2;
            this.btnSessionReg.Tag = "202";
            this.btnSessionReg.Text = "세션진행 등록";
            this.btnSessionReg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSessionReg.UseVisualStyleBackColor = true;
            // 
            // btnSessionSubMain
            // 
            this.btnSessionSubMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSessionSubMain.FlatAppearance.BorderSize = 0;
            this.btnSessionSubMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSessionSubMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSessionSubMain.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSessionSubMain.Location = new System.Drawing.Point(0, 0);
            this.btnSessionSubMain.Name = "btnSessionSubMain";
            this.btnSessionSubMain.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSessionSubMain.Size = new System.Drawing.Size(250, 40);
            this.btnSessionSubMain.TabIndex = 1;
            this.btnSessionSubMain.Tag = "201";
            this.btnSessionSubMain.Text = "세션현황";
            this.btnSessionSubMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSessionSubMain.UseVisualStyleBackColor = true;
            // 
            // btnSession
            // 
            this.btnSession.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSession.FlatAppearance.BorderSize = 0;
            this.btnSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSession.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSession.Location = new System.Drawing.Point(0, 312);
            this.btnSession.Name = "btnSession";
            this.btnSession.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSession.Size = new System.Drawing.Size(250, 45);
            this.btnSession.TabIndex = 10;
            this.btnSession.Tag = "200";
            this.btnSession.Text = "세션정산";
            this.btnSession.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSession.UseVisualStyleBackColor = true;
            // 
            // panelSubmenuFinance
            // 
            this.panelSubmenuFinance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubmenuFinance.Controls.Add(this.button4);
            this.panelSubmenuFinance.Controls.Add(this.button3);
            this.panelSubmenuFinance.Controls.Add(this.btnFinanceSubMain);
            this.panelSubmenuFinance.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenuFinance.Location = new System.Drawing.Point(0, 190);
            this.panelSubmenuFinance.Name = "panelSubmenuFinance";
            this.panelSubmenuFinance.Size = new System.Drawing.Size(250, 122);
            this.panelSubmenuFinance.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Gainsboro;
            this.button4.Location = new System.Drawing.Point(0, 80);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(250, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Location = new System.Drawing.Point(0, 40);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(250, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnFinanceSubMain
            // 
            this.btnFinanceSubMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFinanceSubMain.FlatAppearance.BorderSize = 0;
            this.btnFinanceSubMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanceSubMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanceSubMain.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFinanceSubMain.Location = new System.Drawing.Point(0, 0);
            this.btnFinanceSubMain.Name = "btnFinanceSubMain";
            this.btnFinanceSubMain.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFinanceSubMain.Size = new System.Drawing.Size(250, 40);
            this.btnFinanceSubMain.TabIndex = 1;
            this.btnFinanceSubMain.Tag = "101";
            this.btnFinanceSubMain.Text = "메인";
            this.btnFinanceSubMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinanceSubMain.UseVisualStyleBackColor = true;
            // 
            // btnFinance
            // 
            this.btnFinance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFinance.FlatAppearance.BorderSize = 0;
            this.btnFinance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinance.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFinance.Location = new System.Drawing.Point(0, 145);
            this.btnFinance.Name = "btnFinance";
            this.btnFinance.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFinance.Size = new System.Drawing.Size(250, 45);
            this.btnFinance.TabIndex = 8;
            this.btnFinance.Tag = "100";
            this.btnFinance.Text = "가계부(준비중)";
            this.btnFinance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinance.UseVisualStyleBackColor = true;
            // 
            // btnMain
            // 
            this.btnMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMain.Location = new System.Drawing.Point(0, 100);
            this.btnMain.Name = "btnMain";
            this.btnMain.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMain.Size = new System.Drawing.Size(250, 45);
            this.btnMain.TabIndex = 7;
            this.btnMain.Tag = "0";
            this.btnMain.Text = "메인화면";
            this.btnMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMain.UseVisualStyleBackColor = true;
            // 
            // btnExist
            // 
            this.btnExist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExist.FlatAppearance.BorderSize = 0;
            this.btnExist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExist.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExist.Location = new System.Drawing.Point(0, 730);
            this.btnExist.Name = "btnExist";
            this.btnExist.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExist.Size = new System.Drawing.Size(250, 45);
            this.btnExist.TabIndex = 6;
            this.btnExist.Tag = "9999";
            this.btnExist.Text = "프로그램 종료";
            this.btnExist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExist.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox_logo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 1;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(250, 100);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // panelWindow
            // 
            this.panelWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelWindow.Controls.Add(this.panelMain);
            this.panelWindow.Controls.Add(this.panel1);
            this.panelWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWindow.Location = new System.Drawing.Point(250, 0);
            this.panelWindow.Name = "panelWindow";
            this.panelWindow.Size = new System.Drawing.Size(1197, 775);
            this.panelWindow.TabIndex = 5;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tableLayoutPanel_locker);
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 35);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1197, 740);
            this.panelMain.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1197, 156);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(335, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(512, 150);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_minimize);
            this.panel1.Controls.Add(this.label_menuName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 35);
            this.panel1.TabIndex = 0;
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btn_minimize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.Location = new System.Drawing.Point(1164, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(33, 35);
            this.btn_minimize.TabIndex = 6;
            this.btn_minimize.Text = "_";
            this.btn_minimize.UseVisualStyleBackColor = false;
            // 
            // label_menuName
            // 
            this.label_menuName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.label_menuName.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_menuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label_menuName.ForeColor = System.Drawing.Color.LightGray;
            this.label_menuName.Location = new System.Drawing.Point(0, 0);
            this.label_menuName.Name = "label_menuName";
            this.label_menuName.Size = new System.Drawing.Size(1164, 35);
            this.label_menuName.TabIndex = 5;
            this.label_menuName.Text = " ▶ 메인화면";
            this.label_menuName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnOwnerMinus);
            this.panel3.Controls.Add(this.btnOwnerPlus);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnNoMinus);
            this.panel3.Controls.Add(this.btnNoPlus);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 156);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1197, 33);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel_locker
            // 
            this.tableLayoutPanel_locker.ColumnCount = 2;
            this.tableLayoutPanel_locker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.95155F));
            this.tableLayoutPanel_locker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.04845F));
            this.tableLayoutPanel_locker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_locker.Location = new System.Drawing.Point(0, 189);
            this.tableLayoutPanel_locker.Name = "tableLayoutPanel_locker";
            this.tableLayoutPanel_locker.RowCount = 2;
            this.tableLayoutPanel_locker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.59589F));
            this.tableLayoutPanel_locker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.40411F));
            this.tableLayoutPanel_locker.Size = new System.Drawing.Size(1197, 551);
            this.tableLayoutPanel_locker.TabIndex = 4;
            // 
            // btnNoPlus
            // 
            this.btnNoPlus.Location = new System.Drawing.Point(1001, 4);
            this.btnNoPlus.Name = "btnNoPlus";
            this.btnNoPlus.Size = new System.Drawing.Size(23, 23);
            this.btnNoPlus.TabIndex = 0;
            this.btnNoPlus.Tag = "0";
            this.btnNoPlus.Text = "＋";
            this.btnNoPlus.UseVisualStyleBackColor = true;
            // 
            // btnNoMinus
            // 
            this.btnNoMinus.Location = new System.Drawing.Point(1030, 4);
            this.btnNoMinus.Name = "btnNoMinus";
            this.btnNoMinus.Size = new System.Drawing.Size(23, 23);
            this.btnNoMinus.TabIndex = 1;
            this.btnNoMinus.Tag = "1";
            this.btnNoMinus.Text = "－";
            this.btnNoMinus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(934, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "락커번호 - ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1077, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = " 사용자 - ";
            // 
            // btnOwnerMinus
            // 
            this.btnOwnerMinus.Location = new System.Drawing.Point(1165, 4);
            this.btnOwnerMinus.Name = "btnOwnerMinus";
            this.btnOwnerMinus.Size = new System.Drawing.Size(23, 23);
            this.btnOwnerMinus.TabIndex = 4;
            this.btnOwnerMinus.Tag = "3";
            this.btnOwnerMinus.Text = "－";
            this.btnOwnerMinus.UseVisualStyleBackColor = true;
            // 
            // btnOwnerPlus
            // 
            this.btnOwnerPlus.Location = new System.Drawing.Point(1136, 4);
            this.btnOwnerPlus.Name = "btnOwnerPlus";
            this.btnOwnerPlus.Size = new System.Drawing.Size(23, 23);
            this.btnOwnerPlus.TabIndex = 3;
            this.btnOwnerPlus.Tag = "2";
            this.btnOwnerPlus.Text = "＋";
            this.btnOwnerPlus.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "사용가능";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Green;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(72, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "회원사용";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightBlue;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(138, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "트레이너";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(270, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "기간지남";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(204, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "마감임박";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1447, 797);
            this.Controls.Add(this.panelWindow);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "1447, 797";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            this.panelSubmenuSetting.ResumeLayout(false);
            this.panelSubmenuSession.ResumeLayout(false);
            this.panelSubmenuFinance.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.panelWindow.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel versionString;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelSubmenuSetting;
        private System.Windows.Forms.Button btnSettingSession;
        private System.Windows.Forms.Button btnSettingTrainer;
        private System.Windows.Forms.Button btnSettingUser;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Panel panelSubmenuSession;
        private System.Windows.Forms.Button btnSessionSales;
        private System.Windows.Forms.Button btnSessionReg;
        private System.Windows.Forms.Button btnSessionSubMain;
        private System.Windows.Forms.Button btnSession;
        private System.Windows.Forms.Panel panelSubmenuFinance;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnFinanceSubMain;
        private System.Windows.Forms.Button btnFinance;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Panel panelWindow;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Label label_menuName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_locker;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNoPlus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOwnerMinus;
        private System.Windows.Forms.Button btnOwnerPlus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNoMinus;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

