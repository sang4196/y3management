namespace Y3.Forms.admin
{
    partial class frmAdminRegister
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTrainerSalary = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTrainerDel = new System.Windows.Forms.Button();
            this.btnTrainerInit = new System.Windows.Forms.Button();
            this.txtTrainerNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTrainerUpdate = new System.Windows.Forms.Button();
            this.txtTrainerName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.grid_TrainerList = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUserDel = new System.Windows.Forms.Button();
            this.btnUserInit = new System.Windows.Forms.Button();
            this.txtUserNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUserUpdate = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grid_UserList = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.comboUserTrainer = new System.Windows.Forms.ComboBox();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_TrainerList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_UserList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(0, 370);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1194, 371);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " 어드민 정보";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboUserTrainer);
            this.groupBox5.Controls.Add(this.txtTrainerSalary);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.btnTrainerDel);
            this.groupBox5.Controls.Add(this.btnTrainerInit);
            this.groupBox5.Controls.Add(this.txtTrainerNo);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.btnTrainerUpdate);
            this.groupBox5.Controls.Add(this.txtTrainerName);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(508, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(683, 342);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = " 어드민 정보 등록";
            // 
            // txtTrainerSalary
            // 
            this.txtTrainerSalary.Location = new System.Drawing.Point(139, 103);
            this.txtTrainerSalary.Name = "txtTrainerSalary";
            this.txtTrainerSalary.Size = new System.Drawing.Size(176, 26);
            this.txtTrainerSalary.TabIndex = 2;
            this.txtTrainerSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(7, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "비밀번호 : ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnTrainerDel
            // 
            this.btnTrainerDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrainerDel.ForeColor = System.Drawing.Color.Black;
            this.btnTrainerDel.Location = new System.Drawing.Point(574, 300);
            this.btnTrainerDel.Name = "btnTrainerDel";
            this.btnTrainerDel.Size = new System.Drawing.Size(99, 33);
            this.btnTrainerDel.TabIndex = 14;
            this.btnTrainerDel.Tag = "12";
            this.btnTrainerDel.Text = "삭제";
            this.btnTrainerDel.UseVisualStyleBackColor = true;
            // 
            // btnTrainerInit
            // 
            this.btnTrainerInit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrainerInit.ForeColor = System.Drawing.Color.Black;
            this.btnTrainerInit.Location = new System.Drawing.Point(574, 222);
            this.btnTrainerInit.Name = "btnTrainerInit";
            this.btnTrainerInit.Size = new System.Drawing.Size(99, 33);
            this.btnTrainerInit.TabIndex = 12;
            this.btnTrainerInit.Tag = "10";
            this.btnTrainerInit.Text = "초기화";
            this.btnTrainerInit.UseVisualStyleBackColor = true;
            // 
            // txtTrainerNo
            // 
            this.txtTrainerNo.Enabled = false;
            this.txtTrainerNo.Location = new System.Drawing.Point(139, 31);
            this.txtTrainerNo.Name = "txtTrainerNo";
            this.txtTrainerNo.Size = new System.Drawing.Size(176, 26);
            this.txtTrainerNo.TabIndex = 11;
            this.txtTrainerNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "번호 : ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnTrainerUpdate
            // 
            this.btnTrainerUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrainerUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnTrainerUpdate.Location = new System.Drawing.Point(574, 261);
            this.btnTrainerUpdate.Name = "btnTrainerUpdate";
            this.btnTrainerUpdate.Size = new System.Drawing.Size(99, 33);
            this.btnTrainerUpdate.TabIndex = 9;
            this.btnTrainerUpdate.Tag = "11";
            this.btnTrainerUpdate.Text = "등록";
            this.btnTrainerUpdate.UseVisualStyleBackColor = true;
            // 
            // txtTrainerName
            // 
            this.txtTrainerName.Location = new System.Drawing.Point(139, 67);
            this.txtTrainerName.Name = "txtTrainerName";
            this.txtTrainerName.Size = new System.Drawing.Size(176, 26);
            this.txtTrainerName.TabIndex = 1;
            this.txtTrainerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(7, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "아이디 : ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.grid_TrainerList);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(3, 26);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(505, 342);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = " 리스트";
            // 
            // grid_TrainerList
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_TrainerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_TrainerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_TrainerList.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_TrainerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_TrainerList.Location = new System.Drawing.Point(3, 22);
            this.grid_TrainerList.Name = "grid_TrainerList";
            this.grid_TrainerList.RowTemplate.Height = 23;
            this.grid_TrainerList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_TrainerList.Size = new System.Drawing.Size(499, 317);
            this.grid_TrainerList.TabIndex = 2;
            this.grid_TrainerList.Tag = "1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1194, 370);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " 센터 정보";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUserDel);
            this.groupBox2.Controls.Add(this.btnUserInit);
            this.groupBox2.Controls.Add(this.txtUserNo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnUserUpdate);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(508, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(683, 341);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " 센터 정보 등록";
            // 
            // btnUserDel
            // 
            this.btnUserDel.ForeColor = System.Drawing.Color.Black;
            this.btnUserDel.Location = new System.Drawing.Point(574, 291);
            this.btnUserDel.Name = "btnUserDel";
            this.btnUserDel.Size = new System.Drawing.Size(99, 33);
            this.btnUserDel.TabIndex = 14;
            this.btnUserDel.Tag = "2";
            this.btnUserDel.Text = "삭제";
            this.btnUserDel.UseVisualStyleBackColor = true;
            // 
            // btnUserInit
            // 
            this.btnUserInit.ForeColor = System.Drawing.Color.Black;
            this.btnUserInit.Location = new System.Drawing.Point(574, 213);
            this.btnUserInit.Name = "btnUserInit";
            this.btnUserInit.Size = new System.Drawing.Size(99, 33);
            this.btnUserInit.TabIndex = 12;
            this.btnUserInit.Tag = "0";
            this.btnUserInit.Text = "초기화";
            this.btnUserInit.UseVisualStyleBackColor = true;
            // 
            // txtUserNo
            // 
            this.txtUserNo.Enabled = false;
            this.txtUserNo.Location = new System.Drawing.Point(139, 31);
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.Size = new System.Drawing.Size(176, 26);
            this.txtUserNo.TabIndex = 11;
            this.txtUserNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "번호 : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUserUpdate.Location = new System.Drawing.Point(574, 252);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(99, 33);
            this.btnUserUpdate.TabIndex = 9;
            this.btnUserUpdate.Tag = "1";
            this.btnUserUpdate.Text = "등록";
            this.btnUserUpdate.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(139, 63);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(176, 26);
            this.txtUserName.TabIndex = 11;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "센터이름 : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grid_UserList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 341);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " 리스트";
            // 
            // grid_UserList
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_UserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_UserList.DefaultCellStyle = dataGridViewCellStyle4;
            this.grid_UserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_UserList.Location = new System.Drawing.Point(3, 22);
            this.grid_UserList.Name = "grid_UserList";
            this.grid_UserList.RowTemplate.Height = 23;
            this.grid_UserList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_UserList.Size = new System.Drawing.Size(499, 316);
            this.grid_UserList.TabIndex = 4;
            this.grid_UserList.Tag = "0";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(361, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 23);
            this.label15.TabIndex = 22;
            this.label15.Text = "트레이너 : ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboUserTrainer
            // 
            this.comboUserTrainer.FormattingEnabled = true;
            this.comboUserTrainer.ItemHeight = 16;
            this.comboUserTrainer.Location = new System.Drawing.Point(493, 32);
            this.comboUserTrainer.Name = "comboUserTrainer";
            this.comboUserTrainer.Size = new System.Drawing.Size(176, 24);
            this.comboUserTrainer.TabIndex = 23;
            // 
            // frmAdminRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1194, 741);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmAdminRegister";
            this.Text = "frmAdmin";
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_TrainerList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_UserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboUserTrainer;
        private System.Windows.Forms.TextBox txtTrainerSalary;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTrainerDel;
        private System.Windows.Forms.Button btnTrainerInit;
        private System.Windows.Forms.TextBox txtTrainerNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTrainerUpdate;
        private System.Windows.Forms.TextBox txtTrainerName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView grid_TrainerList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUserDel;
        private System.Windows.Forms.Button btnUserInit;
        private System.Windows.Forms.TextBox txtUserNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUserUpdate;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grid_UserList;
    }
}