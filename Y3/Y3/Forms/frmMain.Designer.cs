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
            this.label_menuName = new System.Windows.Forms.Label();
            this.panelWindow = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxBirthTrainer = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxBirthUser = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelSubmenuSetting.SuspendLayout();
            this.panelSubmenuSession.SuspendLayout();
            this.panelSubmenuFinance.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panelWindow.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // label_menuName
            // 
            this.label_menuName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.label_menuName.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_menuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label_menuName.ForeColor = System.Drawing.Color.LightGray;
            this.label_menuName.Location = new System.Drawing.Point(250, 0);
            this.label_menuName.Name = "label_menuName";
            this.label_menuName.Size = new System.Drawing.Size(1197, 34);
            this.label_menuName.TabIndex = 4;
            this.label_menuName.Text = " ▶ 메인화면";
            this.label_menuName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelWindow
            // 
            this.panelWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelWindow.Controls.Add(this.panelMain);
            this.panelWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWindow.Location = new System.Drawing.Point(250, 34);
            this.panelWindow.Name = "panelWindow";
            this.panelWindow.Size = new System.Drawing.Size(1197, 741);
            this.panelWindow.TabIndex = 5;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tableLayoutPanel1);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1197, 741);
            this.panelMain.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 156);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1197, 585);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(592, 579);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "          이번 달 생일!          ";
            this.groupBox1.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(586, 550);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxBirthTrainer);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(3, 278);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(580, 269);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " 트레이너";
            // 
            // listBoxBirthTrainer
            // 
            this.listBoxBirthTrainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxBirthTrainer.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBoxBirthTrainer.FormattingEnabled = true;
            this.listBoxBirthTrainer.ItemHeight = 19;
            this.listBoxBirthTrainer.Location = new System.Drawing.Point(3, 25);
            this.listBoxBirthTrainer.Name = "listBoxBirthTrainer";
            this.listBoxBirthTrainer.Size = new System.Drawing.Size(574, 241);
            this.listBoxBirthTrainer.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxBirthUser);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 269);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " 회원";
            // 
            // listBoxBirthUser
            // 
            this.listBoxBirthUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxBirthUser.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBoxBirthUser.FormattingEnabled = true;
            this.listBoxBirthUser.ItemHeight = 19;
            this.listBoxBirthUser.Location = new System.Drawing.Point(3, 25);
            this.listBoxBirthUser.Name = "listBoxBirthUser";
            this.listBoxBirthUser.Size = new System.Drawing.Size(574, 241);
            this.listBoxBirthUser.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 156);
            this.panel1.TabIndex = 1;
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1447, 797);
            this.Controls.Add(this.panelWindow);
            this.Controls.Add(this.label_menuName);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Label label_menuName;
        private System.Windows.Forms.Panel panelWindow;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxBirthTrainer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxBirthUser;
    }
}

