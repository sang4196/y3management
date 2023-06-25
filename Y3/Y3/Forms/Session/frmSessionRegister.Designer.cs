namespace Y3.Forms.Session
{
    partial class frmSessionRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboSearchTrainer = new System.Windows.Forms.ComboBox();
            this.dtSearchDate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grid_SessionList = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtSessionPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSessionNo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dtLoad = new System.Windows.Forms.DateTimePicker();
            this.btnSessionDel = new System.Windows.Forms.Button();
            this.btnSessionInit = new System.Windows.Forms.Button();
            this.btnSessionUpdate = new System.Windows.Forms.Button();
            this.txtSessionUseCount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTrainerNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTrainerName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSessionTotalPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSessionPriceName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSessionPriceNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUserNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grid_sessionPirce = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grid_UserList = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SessionList)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sessionPirce)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_UserList)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboSearchTrainer);
            this.panel1.Controls.Add(this.dtSearchDate);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 41);
            this.panel1.TabIndex = 0;
            // 
            // comboSearchTrainer
            // 
            this.comboSearchTrainer.Font = new System.Drawing.Font("굴림", 11F);
            this.comboSearchTrainer.FormattingEnabled = true;
            this.comboSearchTrainer.Location = new System.Drawing.Point(350, 8);
            this.comboSearchTrainer.Name = "comboSearchTrainer";
            this.comboSearchTrainer.Size = new System.Drawing.Size(121, 23);
            this.comboSearchTrainer.TabIndex = 3;
            // 
            // dtSearchDate
            // 
            this.dtSearchDate.CustomFormat = "yyyy-MM";
            this.dtSearchDate.Font = new System.Drawing.Font("굴림", 11F);
            this.dtSearchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSearchDate.Location = new System.Drawing.Point(117, 8);
            this.dtSearchDate.Name = "dtSearchDate";
            this.dtSearchDate.Size = new System.Drawing.Size(101, 24);
            this.dtSearchDate.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(11, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 1;
            this.label15.Text = "조회 월 : ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(244, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 0;
            this.label14.Text = "트레이너 : ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 435F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1194, 700);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grid_SessionList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(429, 694);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "리스트";
            // 
            // grid_SessionList
            // 
            this.grid_SessionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_SessionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_SessionList.Location = new System.Drawing.Point(3, 26);
            this.grid_SessionList.Name = "grid_SessionList";
            this.grid_SessionList.RowTemplate.Height = 23;
            this.grid_SessionList.Size = new System.Drawing.Size(423, 665);
            this.grid_SessionList.TabIndex = 0;
            this.grid_SessionList.Tag = "0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(438, 3);
            this.panel2.Name = "panel2";
            this.tableLayoutPanel1.SetRowSpan(this.panel2, 2);
            this.panel2.Size = new System.Drawing.Size(753, 694);
            this.panel2.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtSessionPrice);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtSessionNo);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.btnLoad);
            this.groupBox4.Controls.Add(this.dtLoad);
            this.groupBox4.Controls.Add(this.btnSessionDel);
            this.groupBox4.Controls.Add(this.btnSessionInit);
            this.groupBox4.Controls.Add(this.btnSessionUpdate);
            this.groupBox4.Controls.Add(this.txtSessionUseCount);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtTrainerNo);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtTrainerName);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtSessionTotalPrice);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtSessionPriceName);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtSessionPriceNo);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtUserNo);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtUserName);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(0, 311);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(753, 383);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " 세션등록 ";
            // 
            // txtSessionPrice
            // 
            this.txtSessionPrice.Enabled = false;
            this.txtSessionPrice.Location = new System.Drawing.Point(148, 253);
            this.txtSessionPrice.Name = "txtSessionPrice";
            this.txtSessionPrice.Size = new System.Drawing.Size(176, 30);
            this.txtSessionPrice.TabIndex = 52;
            this.txtSessionPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 51;
            this.label2.Text = "세션가격 : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSessionNo
            // 
            this.txtSessionNo.Enabled = false;
            this.txtSessionNo.Location = new System.Drawing.Point(148, 33);
            this.txtSessionNo.Name = "txtSessionNo";
            this.txtSessionNo.Size = new System.Drawing.Size(176, 30);
            this.txtSessionNo.TabIndex = 50;
            this.txtSessionNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(16, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 23);
            this.label16.TabIndex = 49;
            this.label16.Text = "세션번호 : ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Location = new System.Drawing.Point(514, 333);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(99, 33);
            this.btnLoad.TabIndex = 48;
            this.btnLoad.Tag = "3";
            this.btnLoad.Text = "불러오기";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // dtLoad
            // 
            this.dtLoad.CustomFormat = "yyyy-MM";
            this.dtLoad.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.dtLoad.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLoad.Location = new System.Drawing.Point(401, 334);
            this.dtLoad.Name = "dtLoad";
            this.dtLoad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtLoad.Size = new System.Drawing.Size(107, 27);
            this.dtLoad.TabIndex = 47;
            // 
            // btnSessionDel
            // 
            this.btnSessionDel.ForeColor = System.Drawing.Color.Black;
            this.btnSessionDel.Location = new System.Drawing.Point(619, 333);
            this.btnSessionDel.Name = "btnSessionDel";
            this.btnSessionDel.Size = new System.Drawing.Size(99, 33);
            this.btnSessionDel.TabIndex = 46;
            this.btnSessionDel.Tag = "2";
            this.btnSessionDel.Text = "삭제";
            this.btnSessionDel.UseVisualStyleBackColor = true;
            // 
            // btnSessionInit
            // 
            this.btnSessionInit.ForeColor = System.Drawing.Color.Black;
            this.btnSessionInit.Location = new System.Drawing.Point(619, 255);
            this.btnSessionInit.Name = "btnSessionInit";
            this.btnSessionInit.Size = new System.Drawing.Size(99, 33);
            this.btnSessionInit.TabIndex = 45;
            this.btnSessionInit.Tag = "0";
            this.btnSessionInit.Text = "초기화";
            this.btnSessionInit.UseVisualStyleBackColor = true;
            // 
            // btnSessionUpdate
            // 
            this.btnSessionUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnSessionUpdate.Location = new System.Drawing.Point(619, 294);
            this.btnSessionUpdate.Name = "btnSessionUpdate";
            this.btnSessionUpdate.Size = new System.Drawing.Size(99, 33);
            this.btnSessionUpdate.TabIndex = 44;
            this.btnSessionUpdate.Tag = "1";
            this.btnSessionUpdate.Text = "등록";
            this.btnSessionUpdate.UseVisualStyleBackColor = true;
            // 
            // txtSessionUseCount
            // 
            this.txtSessionUseCount.Location = new System.Drawing.Point(542, 179);
            this.txtSessionUseCount.Name = "txtSessionUseCount";
            this.txtSessionUseCount.Size = new System.Drawing.Size(176, 30);
            this.txtSessionUseCount.TabIndex = 41;
            this.txtSessionUseCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(384, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 23);
            this.label11.TabIndex = 40;
            this.label11.Text = "세션횟수 : ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTrainerNo
            // 
            this.txtTrainerNo.Enabled = false;
            this.txtTrainerNo.Location = new System.Drawing.Point(542, 35);
            this.txtTrainerNo.Name = "txtTrainerNo";
            this.txtTrainerNo.Size = new System.Drawing.Size(176, 30);
            this.txtTrainerNo.TabIndex = 39;
            this.txtTrainerNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(367, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 23);
            this.label10.TabIndex = 38;
            this.label10.Text = "트레이너 번호 : ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTrainerName
            // 
            this.txtTrainerName.Enabled = false;
            this.txtTrainerName.Location = new System.Drawing.Point(542, 67);
            this.txtTrainerName.Name = "txtTrainerName";
            this.txtTrainerName.Size = new System.Drawing.Size(176, 30);
            this.txtTrainerName.TabIndex = 37;
            this.txtTrainerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(367, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 23);
            this.label12.TabIndex = 36;
            this.label12.Text = "트레이너 이름 : ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSessionTotalPrice
            // 
            this.txtSessionTotalPrice.Enabled = false;
            this.txtSessionTotalPrice.Location = new System.Drawing.Point(148, 331);
            this.txtSessionTotalPrice.Name = "txtSessionTotalPrice";
            this.txtSessionTotalPrice.Size = new System.Drawing.Size(176, 30);
            this.txtSessionTotalPrice.TabIndex = 35;
            this.txtSessionTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 23);
            this.label6.TabIndex = 34;
            this.label6.Text = "지급금액 : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSessionPriceName
            // 
            this.txtSessionPriceName.Enabled = false;
            this.txtSessionPriceName.Location = new System.Drawing.Point(148, 217);
            this.txtSessionPriceName.Name = "txtSessionPriceName";
            this.txtSessionPriceName.Size = new System.Drawing.Size(176, 30);
            this.txtSessionPriceName.TabIndex = 27;
            this.txtSessionPriceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "세션이름 : ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSessionPriceNo
            // 
            this.txtSessionPriceNo.Enabled = false;
            this.txtSessionPriceNo.Location = new System.Drawing.Point(148, 181);
            this.txtSessionPriceNo.Name = "txtSessionPriceNo";
            this.txtSessionPriceNo.Size = new System.Drawing.Size(176, 30);
            this.txtSessionPriceNo.TabIndex = 25;
            this.txtSessionPriceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 23);
            this.label9.TabIndex = 24;
            this.label9.Text = "세션번호 : ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUserNo
            // 
            this.txtUserNo.Enabled = false;
            this.txtUserNo.Location = new System.Drawing.Point(148, 74);
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.Size = new System.Drawing.Size(176, 30);
            this.txtUserNo.TabIndex = 17;
            this.txtUserNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "회원번호 : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(148, 110);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(176, 30);
            this.txtUserName.TabIndex = 13;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "회원이름 : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(753, 311);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " 데이터 ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grid_sessionPirce);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(373, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 282);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " 세션 ";
            // 
            // grid_sessionPirce
            // 
            this.grid_sessionPirce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_sessionPirce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_sessionPirce.Location = new System.Drawing.Point(3, 22);
            this.grid_sessionPirce.Name = "grid_sessionPirce";
            this.grid_sessionPirce.RowTemplate.Height = 23;
            this.grid_sessionPirce.Size = new System.Drawing.Size(371, 257);
            this.grid_sessionPirce.TabIndex = 1;
            this.grid_sessionPirce.Tag = "2";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.grid_UserList);
            this.groupBox5.Controls.Add(this.panel3);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(3, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(370, 282);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = " 회원 ";
            // 
            // grid_UserList
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_UserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_UserList.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_UserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_UserList.Location = new System.Drawing.Point(3, 47);
            this.grid_UserList.Name = "grid_UserList";
            this.grid_UserList.RowTemplate.Height = 23;
            this.grid_UserList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_UserList.Size = new System.Drawing.Size(364, 232);
            this.grid_UserList.TabIndex = 7;
            this.grid_UserList.Tag = "1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSearchUser);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 25);
            this.panel3.TabIndex = 2;
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchUser.Location = new System.Drawing.Point(27, 0);
            this.txtSearchUser.Multiline = true;
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(337, 25);
            this.txtSearchUser.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Y3.Properties.Resources.icons8_search_32;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmSessionRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1194, 741);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "frmSessionRegister";
            this.Text = "frmSessionRegister";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_SessionList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_sessionPirce)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_UserList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboSearchTrainer;
        private System.Windows.Forms.DateTimePicker dtSearchDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtSessionUseCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTrainerNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTrainerName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSessionTotalPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSessionPriceName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSessionPriceNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUserNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grid_sessionPirce;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView grid_UserList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView grid_SessionList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DateTimePicker dtLoad;
        private System.Windows.Forms.Button btnSessionDel;
        private System.Windows.Forms.Button btnSessionInit;
        private System.Windows.Forms.Button btnSessionUpdate;
        private System.Windows.Forms.TextBox txtSessionNo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSessionPrice;
        private System.Windows.Forms.Label label2;
    }
}