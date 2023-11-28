using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Y3.Models;

namespace Y3.Forms
{
    public partial class frmLock : Form
    {
        public frmLock()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;

            InitEvent();
        }

        private void InitEvent()
        {
            btnLogin.Click += BtnLogin_Click;
            btnClose.Click += BtnClose_Click;

            txtPassword.KeyDown += TxtPassword_KeyDown;
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            Core.Instance.InitCore();

            if (!txtPassword.Text.Equals("0419"))
            {
                MessageBox.Show("비밀번호가 틀립니다.", "비밀번호 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Hide();
            new frmMain().ShowDialog();
        }
    }
}
