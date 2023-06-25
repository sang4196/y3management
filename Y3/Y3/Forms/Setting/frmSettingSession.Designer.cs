namespace Y3.Forms.Setting
{
    partial class frmSettingSession
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSessionDel = new System.Windows.Forms.Button();
            this.btnSessionInit = new System.Windows.Forms.Button();
            this.btnSessionUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSessionTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSessionDeduct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSessionPer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSessionPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSessionName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSessionNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grid_sessionPirce = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSTDel = new System.Windows.Forms.Button();
            this.comboTrainer = new System.Windows.Forms.ComboBox();
            this.btnSTInit = new System.Windows.Forms.Button();
            this.btnSTUpdate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboSession = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSTPer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSTNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grid_ST = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sessionPirce)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ST)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1194, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "세션 타입";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSessionDel);
            this.groupBox3.Controls.Add(this.btnSessionInit);
            this.groupBox3.Controls.Add(this.btnSessionUpdate);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtSessionTotal);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtSessionDeduct);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtSessionPer);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtSessionPrice);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtSessionName);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtSessionNo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(528, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(663, 341);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "세션 정보 등록";
            // 
            // btnSessionDel
            // 
            this.btnSessionDel.ForeColor = System.Drawing.Color.Black;
            this.btnSessionDel.Location = new System.Drawing.Point(555, 291);
            this.btnSessionDel.Name = "btnSessionDel";
            this.btnSessionDel.Size = new System.Drawing.Size(99, 33);
            this.btnSessionDel.TabIndex = 27;
            this.btnSessionDel.Tag = "2";
            this.btnSessionDel.Text = "삭제";
            this.btnSessionDel.UseVisualStyleBackColor = true;
            // 
            // btnSessionInit
            // 
            this.btnSessionInit.ForeColor = System.Drawing.Color.Black;
            this.btnSessionInit.Location = new System.Drawing.Point(555, 213);
            this.btnSessionInit.Name = "btnSessionInit";
            this.btnSessionInit.Size = new System.Drawing.Size(99, 33);
            this.btnSessionInit.TabIndex = 26;
            this.btnSessionInit.Tag = "0";
            this.btnSessionInit.Text = "초기화";
            this.btnSessionInit.UseVisualStyleBackColor = true;
            // 
            // btnSessionUpdate
            // 
            this.btnSessionUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnSessionUpdate.Location = new System.Drawing.Point(555, 252);
            this.btnSessionUpdate.Name = "btnSessionUpdate";
            this.btnSessionUpdate.Size = new System.Drawing.Size(99, 33);
            this.btnSessionUpdate.TabIndex = 25;
            this.btnSessionUpdate.Tag = "1";
            this.btnSessionUpdate.Text = "등록";
            this.btnSessionUpdate.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("굴림", 8F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(388, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(278, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "지급금액 = (세션가격 - (세션가격 * 공제률)) * 지급률";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSessionTotal
            // 
            this.txtSessionTotal.Enabled = false;
            this.txtSessionTotal.Location = new System.Drawing.Point(478, 88);
            this.txtSessionTotal.Name = "txtSessionTotal";
            this.txtSessionTotal.Size = new System.Drawing.Size(176, 26);
            this.txtSessionTotal.TabIndex = 23;
            this.txtSessionTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(346, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "지급금액 : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSessionDeduct
            // 
            this.txtSessionDeduct.Location = new System.Drawing.Point(478, 56);
            this.txtSessionDeduct.Name = "txtSessionDeduct";
            this.txtSessionDeduct.Size = new System.Drawing.Size(176, 26);
            this.txtSessionDeduct.TabIndex = 21;
            this.txtSessionDeduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(346, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "공제률(%) : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSessionPer
            // 
            this.txtSessionPer.Location = new System.Drawing.Point(478, 24);
            this.txtSessionPer.Name = "txtSessionPer";
            this.txtSessionPer.Size = new System.Drawing.Size(176, 26);
            this.txtSessionPer.TabIndex = 19;
            this.txtSessionPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(346, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "지급률(%) : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSessionPrice
            // 
            this.txtSessionPrice.Location = new System.Drawing.Point(139, 89);
            this.txtSessionPrice.Name = "txtSessionPrice";
            this.txtSessionPrice.Size = new System.Drawing.Size(176, 26);
            this.txtSessionPrice.TabIndex = 17;
            this.txtSessionPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "세션가격 : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSessionName
            // 
            this.txtSessionName.Location = new System.Drawing.Point(139, 57);
            this.txtSessionName.Name = "txtSessionName";
            this.txtSessionName.Size = new System.Drawing.Size(176, 26);
            this.txtSessionName.TabIndex = 15;
            this.txtSessionName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "세션이름 : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSessionNo
            // 
            this.txtSessionNo.Enabled = false;
            this.txtSessionNo.Location = new System.Drawing.Point(139, 25);
            this.txtSessionNo.Name = "txtSessionNo";
            this.txtSessionNo.Size = new System.Drawing.Size(176, 26);
            this.txtSessionNo.TabIndex = 13;
            this.txtSessionNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "번호 : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grid_sessionPirce);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 341);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "리스트";
            // 
            // grid_sessionPirce
            // 
            this.grid_sessionPirce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_sessionPirce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_sessionPirce.Location = new System.Drawing.Point(3, 22);
            this.grid_sessionPirce.Name = "grid_sessionPirce";
            this.grid_sessionPirce.RowTemplate.Height = 23;
            this.grid_sessionPirce.Size = new System.Drawing.Size(519, 316);
            this.grid_sessionPirce.TabIndex = 1;
            this.grid_sessionPirce.Tag = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(0, 370);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1194, 371);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "트레이너별 세션 설정";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnSTDel);
            this.groupBox6.Controls.Add(this.comboTrainer);
            this.groupBox6.Controls.Add(this.btnSTInit);
            this.groupBox6.Controls.Add(this.btnSTUpdate);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.comboSession);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.txtSTPer);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.txtSTNo);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(528, 26);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(663, 342);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "정보 등록";
            // 
            // btnSTDel
            // 
            this.btnSTDel.ForeColor = System.Drawing.Color.Black;
            this.btnSTDel.Location = new System.Drawing.Point(555, 300);
            this.btnSTDel.Name = "btnSTDel";
            this.btnSTDel.Size = new System.Drawing.Size(99, 33);
            this.btnSTDel.TabIndex = 30;
            this.btnSTDel.Tag = "12";
            this.btnSTDel.Text = "삭제";
            this.btnSTDel.UseVisualStyleBackColor = true;
            // 
            // comboTrainer
            // 
            this.comboTrainer.FormattingEnabled = true;
            this.comboTrainer.Location = new System.Drawing.Point(139, 99);
            this.comboTrainer.Name = "comboTrainer";
            this.comboTrainer.Size = new System.Drawing.Size(176, 24);
            this.comboTrainer.TabIndex = 33;
            // 
            // btnSTInit
            // 
            this.btnSTInit.ForeColor = System.Drawing.Color.Black;
            this.btnSTInit.Location = new System.Drawing.Point(555, 222);
            this.btnSTInit.Name = "btnSTInit";
            this.btnSTInit.Size = new System.Drawing.Size(99, 33);
            this.btnSTInit.TabIndex = 29;
            this.btnSTInit.Tag = "10";
            this.btnSTInit.Text = "초기화";
            this.btnSTInit.UseVisualStyleBackColor = true;
            // 
            // btnSTUpdate
            // 
            this.btnSTUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnSTUpdate.Location = new System.Drawing.Point(555, 261);
            this.btnSTUpdate.Name = "btnSTUpdate";
            this.btnSTUpdate.Size = new System.Drawing.Size(99, 33);
            this.btnSTUpdate.TabIndex = 28;
            this.btnSTUpdate.Tag = "11";
            this.btnSTUpdate.Text = "등록";
            this.btnSTUpdate.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(7, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 23);
            this.label11.TabIndex = 32;
            this.label11.Text = "트레이너 : ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboSession
            // 
            this.comboSession.FormattingEnabled = true;
            this.comboSession.Location = new System.Drawing.Point(139, 65);
            this.comboSession.Name = "comboSession";
            this.comboSession.Size = new System.Drawing.Size(176, 24);
            this.comboSession.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(7, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 23);
            this.label10.TabIndex = 30;
            this.label10.Text = "세션 : ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSTPer
            // 
            this.txtSTPer.Location = new System.Drawing.Point(139, 133);
            this.txtSTPer.Name = "txtSTPer";
            this.txtSTPer.Size = new System.Drawing.Size(176, 26);
            this.txtSTPer.TabIndex = 29;
            this.txtSTPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(7, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 23);
            this.label9.TabIndex = 28;
            this.label9.Text = "지급률(%) : ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSTNo
            // 
            this.txtSTNo.Enabled = false;
            this.txtSTNo.Location = new System.Drawing.Point(139, 29);
            this.txtSTNo.Name = "txtSTNo";
            this.txtSTNo.Size = new System.Drawing.Size(176, 26);
            this.txtSTNo.TabIndex = 15;
            this.txtSTNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "번호 : ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.grid_ST);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(3, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(525, 342);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "리스트";
            // 
            // grid_ST
            // 
            this.grid_ST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_ST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_ST.Location = new System.Drawing.Point(3, 22);
            this.grid_ST.Name = "grid_ST";
            this.grid_ST.RowTemplate.Height = 23;
            this.grid_ST.Size = new System.Drawing.Size(519, 317);
            this.grid_ST.TabIndex = 0;
            this.grid_ST.Tag = "1";
            // 
            // frmSettingSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1194, 741);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSettingSession";
            this.Text = "frmSettingSession";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_sessionPirce)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_ST)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grid_sessionPirce;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSessionNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSessionDeduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSessionPer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSessionPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSessionName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSessionTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSessionDel;
        private System.Windows.Forms.Button btnSessionInit;
        private System.Windows.Forms.Button btnSessionUpdate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtSTPer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSTNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView grid_ST;
        private System.Windows.Forms.Button btnSTDel;
        private System.Windows.Forms.ComboBox comboTrainer;
        private System.Windows.Forms.Button btnSTInit;
        private System.Windows.Forms.Button btnSTUpdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboSession;
        private System.Windows.Forms.Label label10;
    }
}