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
using Y3.Models;
using Y3.Utility;
using Y3.Utility.Enums;

namespace Y3.UserControls
{
    public partial class UCLocker : UserControl
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

        private int OWNER_ID
        {
            set
            {
                _ownerId = value;
            }
        }

        private string OWNER_NAME
        {
            set
            {
                _ownerName = value;
                btn_locker.Text = value;
            }
        }
        private eUserType USER_TYPE
        {
            get { return _userType; }
            set
            {
                _userType = value;
                SetOwnerColor();
            }
        }
        public UCLocker()
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

        public void SetOwnerColor(Color color)
        {
            btn_locker.BackColor = color;
        }

        public void SetOwnerColor()
        {
            Color color = Color.White;
            switch (USER_TYPE)
            {
                case eUserType.NONE:
                    color = Color.White;
                    break;
                case eUserType.USER:
                    color = Color.Green;
                    break;
                case eUserType.TRAINER:
                    color = Color.LightBlue;
                    break;
            }
            btn_locker.BackColor = color;
        }

        public void SetLockerOwner(Locker locker)
        {
            string ownerName = string.Empty;
            USER_TYPE = (eUserType)locker.OwnerType;
            OWNER_ID = locker.OwnerId;
            if (locker.EndDate == DateTime.MinValue || locker.EndDate >= TimeUtil.GetStartDay(DateTime.Now))
            {
                ownerName = locker.OwnerName;
            }
            else
            {
                ownerName = $"{locker.OwnerName} ({(locker.EndDate - TimeUtil.GetStartDay(DateTime.Now)).Days})";
            }
            OWNER_NAME = ownerName;

            if (USER_TYPE != eUserType.NONE)
            {
                string title = string.Empty;
                if (locker.EndDate == DateTime.MinValue)
                    title = $"{_lockerNo} (기한없음)";
                else
                    title = $"{_lockerNo} ( ~{locker.EndDate.ToString(TimeUtil.TIME_FORMAT_5)})";

                SetLockerTitle(title);
            }
        }

        public void InitOwner()
        {
            SetLockerTitle(_lockerNo.ToString());
            USER_TYPE = eUserType.NONE;
            OWNER_ID = 0;
            OWNER_NAME = string.Empty;
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
    }
}
