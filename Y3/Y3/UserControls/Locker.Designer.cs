namespace Y3.UserControls
{
    partial class Locker
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_lockerNo = new System.Windows.Forms.Label();
            this.btn_locker = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 148);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label_lockerNo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_locker, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(146, 146);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label_lockerNo
            // 
            this.label_lockerNo.BackColor = System.Drawing.Color.White;
            this.label_lockerNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_lockerNo.ForeColor = System.Drawing.Color.Black;
            this.label_lockerNo.Location = new System.Drawing.Point(0, 0);
            this.label_lockerNo.Margin = new System.Windows.Forms.Padding(0);
            this.label_lockerNo.Name = "label_lockerNo";
            this.label_lockerNo.Size = new System.Drawing.Size(146, 29);
            this.label_lockerNo.TabIndex = 0;
            this.label_lockerNo.Text = "label1";
            this.label_lockerNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_locker
            // 
            this.btn_locker.BackColor = System.Drawing.Color.White;
            this.btn_locker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_locker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_locker.ForeColor = System.Drawing.Color.Black;
            this.btn_locker.Location = new System.Drawing.Point(0, 29);
            this.btn_locker.Margin = new System.Windows.Forms.Padding(0);
            this.btn_locker.Name = "btn_locker";
            this.btn_locker.Size = new System.Drawing.Size(146, 117);
            this.btn_locker.TabIndex = 1;
            this.btn_locker.UseVisualStyleBackColor = false;
            // 
            // Locker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Locker";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_lockerNo;
        private System.Windows.Forms.Button btn_locker;
    }
}
