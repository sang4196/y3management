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

namespace Y3.UserControls
{
    public partial class Locker : UserControl
    {
        private int _lockerNo;
        public int LOCKER_NO { 
            set
            {
                _lockerNo = value;
                SetLockerTitle(_lockerNo.ToString());
            } 
        }
        Dictionary<int, string> _owners = new Dictionary<int, string>();
        public Locker()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public void SetLockerTitle(string title)
        {
            label_lockerNo.Text = title;
        }

        public void SetLockerOwner(int ownerId, string lockerOwner)
        {
            _owners.Add(ownerId, lockerOwner);
            UpdateLockerOwner();
        }

        private void UpdateLockerOwner()
        {
            btn_locker.Text = string.Join("\n", _owners.Values.ToArray());
        }

        public void InitOwner()
        {
            SetLockerTitle(_lockerNo.ToString());
            _owners.Clear();
        }

        public void DeleteLockerOwner(int ownerId)
        {
            _owners.Remove(ownerId);
            UpdateLockerOwner();
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
