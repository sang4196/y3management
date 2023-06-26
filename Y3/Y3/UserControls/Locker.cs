using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Y3.Utility;
using Y3.Utility.Enums;

namespace Y3.UserControls
{
    public partial class Locker : UserControl
    {
        private int _lockerNo;

        public delegate void ButtonClickEventHandler(eUserType userType, int userId, int lockNo);
        public event ButtonClickEventHandler ButtonClickEvent;
                
        private int _ownerId;
        private string _ownerName;
        private eUserType _userType;

        public int LOCKER_NO
        {
            set
            {
                _lockerNo = value;
                SetLockerTitle(_lockerNo.ToString());
                this.Tag = _lockerNo.ToString();
            }
        }
        public eUserType USER_TYPE
        {
            set
            {
                _userType = value;
            }
        }
        public Locker()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            btn_locker.Click += Btn_locker_Click;
        }

        private void Btn_locker_Click(object sender, EventArgs e)
        {
            // 0 - user
            // 1 - trainer
            ButtonClickEvent(_userType, _ownerId, _lockerNo);
        }

        public void SetLockerTitle(string title)
        {
            label_lockerNo.Text = title;
        }

        public void SetLockerOwner(int ownerId, string lockerOwner)
        {
            _ownerId = ownerId;
            _ownerName = lockerOwner;
            UpdateLockerOwner();
        }

        private void UpdateLockerOwner()
        {
            btn_locker.Text = _ownerName;
        }

        public void InitOwner()
        {
            SetLockerTitle(_lockerNo.ToString());
            _ownerId = 0;
            _ownerName = string.Empty;
        }

        public void SetNoFontSize(float fontSize) 
        {
            label_lockerNo.Font = new Font(label_lockerNo.Font.FontFamily, fontSize);
        }

        public void SetOwnerFontSize(float fontSize)
        {
            btn_locker.Font = new Font(btn_locker.Font.FontFamily, fontSize);
        }

        public void ChangeNoBackColor(Color color)
        {
            label_lockerNo.BackColor = color;
        }

        public void SetEndDate(DateTime endData)
        {
            SetLockerTitle($"{_lockerNo} ( ~{endData.ToString(TimeUtil.TIME_FORMAT_5)})");
        }
    }
}
