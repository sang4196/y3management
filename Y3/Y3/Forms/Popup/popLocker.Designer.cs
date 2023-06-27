namespace Y3.Forms.Popup
{
    partial class popLocker
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
            this.txtLockerNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnTrainer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtOwnerId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkNoLimit = new System.Windows.Forms.CheckBox();
            this.btn6m = new System.Windows.Forms.Button();
            this.btn12m = new System.Windows.Forms.Button();
            this.btnP1m = new System.Windows.Forms.Button();
            this.btn3m = new System.Windows.Forms.Button();
            this.btn1m = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLockerNo
            // 
            this.txtLockerNo.Enabled = false;
            this.txtLockerNo.Location = new System.Drawing.Point(135, 65);
            this.txtLockerNo.Name = "txtLockerNo";
            this.txtLockerNo.Size = new System.Drawing.Size(176, 30);
            this.txtLockerNo.TabIndex = 19;
            this.txtLockerNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "라커번호 : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Enabled = false;
            this.txtOwnerName.Location = new System.Drawing.Point(135, 102);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(176, 30);
            this.txtOwnerName.TabIndex = 21;
            this.txtOwnerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "소유자 : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "사용기한 : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.White;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.ForeColor = System.Drawing.Color.Black;
            this.btnEnd.Location = new System.Drawing.Point(450, 55);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(110, 110);
            this.btnEnd.TabIndex = 26;
            this.btnEnd.Tag = "0";
            this.btnEnd.Text = "사용마감";
            this.btnEnd.UseVisualStyleBackColor = false;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Green;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.ForeColor = System.Drawing.Color.Black;
            this.btnUser.Location = new System.Drawing.Point(566, 55);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(110, 110);
            this.btnUser.TabIndex = 27;
            this.btnUser.Tag = "1";
            this.btnUser.Text = "회원선택";
            this.btnUser.UseVisualStyleBackColor = false;
            // 
            // btnTrainer
            // 
            this.btnTrainer.BackColor = System.Drawing.Color.LightBlue;
            this.btnTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainer.ForeColor = System.Drawing.Color.Black;
            this.btnTrainer.Location = new System.Drawing.Point(682, 55);
            this.btnTrainer.Name = "btnTrainer";
            this.btnTrainer.Size = new System.Drawing.Size(110, 110);
            this.btnTrainer.TabIndex = 28;
            this.btnTrainer.Tag = "2";
            this.btnTrainer.Text = "트레이너";
            this.btnTrainer.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(125, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "~";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtEndDate
            // 
            this.dtEndDate.CustomFormat = "yyyy-MM-dd";
            this.dtEndDate.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndDate.Location = new System.Drawing.Point(158, 175);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtEndDate.Size = new System.Drawing.Size(153, 27);
            this.dtEndDate.TabIndex = 32;
            // 
            // txtOwnerId
            // 
            this.txtOwnerId.Enabled = false;
            this.txtOwnerId.Location = new System.Drawing.Point(135, 29);
            this.txtOwnerId.Name = "txtOwnerId";
            this.txtOwnerId.Size = new System.Drawing.Size(176, 30);
            this.txtOwnerId.TabIndex = 23;
            this.txtOwnerId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOwnerId.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "소유자아디 : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 41);
            this.panel1.TabIndex = 33;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(766, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 41);
            this.btnClose.TabIndex = 7;
            this.btnClose.Tag = "3";
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(766, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "락커정보";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkNoLimit
            // 
            this.chkNoLimit.AutoSize = true;
            this.chkNoLimit.ForeColor = System.Drawing.Color.White;
            this.chkNoLimit.Location = new System.Drawing.Point(317, 176);
            this.chkNoLimit.Name = "chkNoLimit";
            this.chkNoLimit.Size = new System.Drawing.Size(112, 24);
            this.chkNoLimit.TabIndex = 34;
            this.chkNoLimit.Text = "기한없음";
            this.chkNoLimit.UseVisualStyleBackColor = true;
            // 
            // btn6m
            // 
            this.btn6m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6m.Font = new System.Drawing.Font("굴림", 8F);
            this.btn6m.ForeColor = System.Drawing.Color.White;
            this.btn6m.Location = new System.Drawing.Point(149, 148);
            this.btn6m.Name = "btn6m";
            this.btn6m.Size = new System.Drawing.Size(50, 23);
            this.btn6m.TabIndex = 35;
            this.btn6m.Tag = "6";
            this.btn6m.Text = "6개월";
            this.btn6m.UseVisualStyleBackColor = true;
            // 
            // btn12m
            // 
            this.btn12m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn12m.Font = new System.Drawing.Font("굴림", 8F);
            this.btn12m.ForeColor = System.Drawing.Color.White;
            this.btn12m.Location = new System.Drawing.Point(205, 148);
            this.btn12m.Name = "btn12m";
            this.btn12m.Size = new System.Drawing.Size(50, 23);
            this.btn12m.TabIndex = 36;
            this.btn12m.Tag = "12";
            this.btn12m.Text = "12개월";
            this.btn12m.UseVisualStyleBackColor = true;
            // 
            // btnP1m
            // 
            this.btnP1m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnP1m.Font = new System.Drawing.Font("굴림", 8F);
            this.btnP1m.ForeColor = System.Drawing.Color.White;
            this.btnP1m.Location = new System.Drawing.Point(261, 148);
            this.btnP1m.Name = "btnP1m";
            this.btnP1m.Size = new System.Drawing.Size(50, 23);
            this.btnP1m.TabIndex = 37;
            this.btnP1m.Tag = "-1";
            this.btnP1m.Text = "+1개월";
            this.btnP1m.UseVisualStyleBackColor = true;
            // 
            // btn3m
            // 
            this.btn3m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3m.Font = new System.Drawing.Font("굴림", 8F);
            this.btn3m.ForeColor = System.Drawing.Color.White;
            this.btn3m.Location = new System.Drawing.Point(93, 148);
            this.btn3m.Name = "btn3m";
            this.btn3m.Size = new System.Drawing.Size(50, 23);
            this.btn3m.TabIndex = 38;
            this.btn3m.Tag = "3";
            this.btn3m.Text = "3개월";
            this.btn3m.UseVisualStyleBackColor = true;
            // 
            // btn1m
            // 
            this.btn1m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1m.Font = new System.Drawing.Font("굴림", 8F);
            this.btn1m.ForeColor = System.Drawing.Color.White;
            this.btn1m.Location = new System.Drawing.Point(37, 148);
            this.btn1m.Name = "btn1m";
            this.btn1m.Size = new System.Drawing.Size(50, 23);
            this.btn1m.TabIndex = 39;
            this.btn1m.Tag = "1";
            this.btn1m.Text = "1개월";
            this.btn1m.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(682, 173);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 34);
            this.btnSave.TabIndex = 40;
            this.btnSave.Tag = "4";
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // popLocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(804, 220);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btn1m);
            this.Controls.Add(this.btn3m);
            this.Controls.Add(this.btnP1m);
            this.Controls.Add(this.btn12m);
            this.Controls.Add(this.btn6m);
            this.Controls.Add(this.chkNoLimit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.txtOwnerId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTrainer);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOwnerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLockerNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "popLocker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "popLocker";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLockerNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnTrainer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.TextBox txtOwnerId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkNoLimit;
        private System.Windows.Forms.Button btn6m;
        private System.Windows.Forms.Button btn12m;
        private System.Windows.Forms.Button btnP1m;
        private System.Windows.Forms.Button btn3m;
        private System.Windows.Forms.Button btn1m;
        private System.Windows.Forms.Button btnSave;
    }
}