namespace Y3.Forms.Session
{
    partial class frmSessionSales
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboSearchTrainer = new System.Windows.Forms.ComboBox();
            this.dtSearchDate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grid_SalesList = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSalesNo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSessionDel = new System.Windows.Forms.Button();
            this.btnSessionInit = new System.Windows.Forms.Button();
            this.btnSessionUpdate = new System.Windows.Forms.Button();
            this.txtsalesPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTrainerNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTrainerName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SalesList)).BeginInit();
            this.groupBox4.SuspendLayout();
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
            this.panel1.TabIndex = 1;
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
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 435F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1194, 700);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grid_SalesList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1188, 344);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "리스트";
            // 
            // grid_SalesList
            // 
            this.grid_SalesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_SalesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_SalesList.Location = new System.Drawing.Point(3, 26);
            this.grid_SalesList.Name = "grid_SalesList";
            this.grid_SalesList.RowTemplate.Height = 23;
            this.grid_SalesList.Size = new System.Drawing.Size(1182, 315);
            this.grid_SalesList.TabIndex = 0;
            this.grid_SalesList.Tag = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMemo);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtSalesNo);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.btnSessionDel);
            this.groupBox4.Controls.Add(this.btnSessionInit);
            this.groupBox4.Controls.Add(this.btnSessionUpdate);
            this.groupBox4.Controls.Add(this.txtsalesPrice);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtTrainerNo);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtTrainerName);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(3, 353);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1188, 344);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " 매출 등록 ";
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(590, 78);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(268, 81);
            this.txtMemo.TabIndex = 51;
            this.txtMemo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(458, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 23);
            this.label6.TabIndex = 52;
            this.label6.Text = "메모 : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSalesNo
            // 
            this.txtSalesNo.Enabled = false;
            this.txtSalesNo.Location = new System.Drawing.Point(192, 42);
            this.txtSalesNo.Name = "txtSalesNo";
            this.txtSalesNo.Size = new System.Drawing.Size(176, 30);
            this.txtSalesNo.TabIndex = 50;
            this.txtSalesNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(60, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 23);
            this.label16.TabIndex = 49;
            this.label16.Text = "번호 : ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSessionDel
            // 
            this.btnSessionDel.ForeColor = System.Drawing.Color.Black;
            this.btnSessionDel.Location = new System.Drawing.Point(1068, 289);
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
            this.btnSessionInit.Location = new System.Drawing.Point(1068, 211);
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
            this.btnSessionUpdate.Location = new System.Drawing.Point(1068, 250);
            this.btnSessionUpdate.Name = "btnSessionUpdate";
            this.btnSessionUpdate.Size = new System.Drawing.Size(99, 33);
            this.btnSessionUpdate.TabIndex = 44;
            this.btnSessionUpdate.Tag = "1";
            this.btnSessionUpdate.Text = "등록";
            this.btnSessionUpdate.UseVisualStyleBackColor = true;
            // 
            // txtsalesPrice
            // 
            this.txtsalesPrice.Location = new System.Drawing.Point(590, 42);
            this.txtsalesPrice.Name = "txtsalesPrice";
            this.txtsalesPrice.Size = new System.Drawing.Size(176, 30);
            this.txtsalesPrice.TabIndex = 41;
            this.txtsalesPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(432, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 23);
            this.label11.TabIndex = 40;
            this.label11.Text = "매출금액 : ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTrainerNo
            // 
            this.txtTrainerNo.Enabled = false;
            this.txtTrainerNo.Location = new System.Drawing.Point(192, 78);
            this.txtTrainerNo.Name = "txtTrainerNo";
            this.txtTrainerNo.Size = new System.Drawing.Size(176, 30);
            this.txtTrainerNo.TabIndex = 39;
            this.txtTrainerNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(17, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 23);
            this.label10.TabIndex = 38;
            this.label10.Text = "트레이너 번호 : ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTrainerName
            // 
            this.txtTrainerName.Enabled = false;
            this.txtTrainerName.Location = new System.Drawing.Point(192, 114);
            this.txtTrainerName.Name = "txtTrainerName";
            this.txtTrainerName.Size = new System.Drawing.Size(176, 30);
            this.txtTrainerName.TabIndex = 37;
            this.txtTrainerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(17, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 23);
            this.label12.TabIndex = 36;
            this.label12.Text = "트레이너 이름 : ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmSessionSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1194, 741);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "frmSessionSales";
            this.Text = "frmSessionSales";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_SalesList)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboSearchTrainer;
        private System.Windows.Forms.DateTimePicker dtSearchDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grid_SalesList;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSalesNo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSessionDel;
        private System.Windows.Forms.Button btnSessionInit;
        private System.Windows.Forms.Button btnSessionUpdate;
        private System.Windows.Forms.TextBox txtsalesPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTrainerNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTrainerName;
        private System.Windows.Forms.Label label12;
    }
}