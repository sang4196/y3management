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
using Y3.Models.DB;
using Y3.Utility;
using Y3.Utility.Enums;

namespace Y3.Forms.Popup
{
    public partial class popLocker : Form
    {
        private enum eButton
        {
            END = 0,
            USER = 1,
            TRAINER,
            CLOSE,
            SAVE
        }

        private eUserType _type;
        private int _id;
        private string _name;
        private int _lockerNo;
        private DateTime _endDate;
        private Locker _locker;
        private bool isUse = false;

        public int OWNER_ID
        {
            get { return _id; }
            set
            {
                _id = value;
                txtOwnerId.Text = OWNER_ID.ToString();
            }
        }

        public string OWNER_NAME
        {
            get { return _name; }
            set
            {
                _name = value;
                txtOwnerName.Text = OWNER_NAME;
            }
        }

        public DateTime END_DATE
        {
            get { return _endDate; }
            set
            {
                _endDate = value;
                dtEndDate.Value = value;
                if (_endDate == DateTime.MinValue) chkNoLimit.Checked = true;
            }
        }

        public popLocker(eUserType userType, int ownerId, int lockerNo)
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;

            this._type = userType;
            this.OWNER_ID = ownerId;
            this._lockerNo = lockerNo;

            txtLockerNo.Text = _lockerNo.ToString();
            _locker = Core.MODELS.GetLockerByNo(_lockerNo);

            InitEvent();

            InitControl();
            LoadData();
        }

        private void InitEvent()
        {
            chkNoLimit.CheckedChanged += ChkNoLimit_CheckedChanged;

            btnEnd.Click += Btn_Click;
            btnUser.Click += Btn_Click;
            btnTrainer.Click += Btn_Click;
            btnClose.Click += Btn_Click;
            btnSave.Click += Btn_Click;

            btn1m.Click += BtnDt_Click;
            btn3m.Click += BtnDt_Click;
            btn6m.Click += BtnDt_Click;
            btn12m.Click += BtnDt_Click;
            btnP1m.Click += BtnDt_Click;
        }

        private void BtnDt_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int plusMonth = int.Parse(btn.Tag.ToString());

            if (plusMonth > 0)
            {
                dtEndDate.Value = isUse ? END_DATE.AddMonths(plusMonth) : DateTime.Now.AddMonths(plusMonth);
            }
            else
            {
                dtEndDate.Value = isUse ? END_DATE.AddMonths(1) : dtEndDate.Value.AddMonths(1);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int selectIdx = int.Parse(btn.Tag.ToString());

            switch (selectIdx)
            {
                case (int)eButton.END:
                    UseEnd();
                    break;
                case (int)eButton.USER:
                    LoadOwner(eUserType.USER);
                    break;
                case (int)eButton.TRAINER:
                    LoadOwner(eUserType.TRAINER);
                    break;
                case (int)eButton.CLOSE:
                    this.Close();
                    break;
                case (int)eButton.SAVE:
                    SaveLocker();
                    break;
            }
        }

        private void ChkNoLimit_CheckedChanged(object sender, EventArgs e)
        {
            dtEndDate.Enabled = !chkNoLimit.Checked;
        }

        private void InitControl()
        {
            txtOwnerId.Text = string.Empty;
            txtOwnerName.Text = string.Empty;
            dtEndDate.Value = DateTime.Now;
            dtEndDate.Enabled = true;
        }

        private void LoadOwner(eUserType type)
        {
            if (isUse)
            {
                MessageBox.Show("사용중인 락커입니다.\n마감처리를 먼저 해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            popUser pop = new popUser(type);

            if (pop.ShowDialog() == DialogResult.OK)
            {
                OWNER_ID = pop.ID;
                OWNER_NAME = pop.NAME;
                _type = type;
            }
        }

        private string GetOwnerNameById(int id)
        {
            string rtn = string.Empty;
            if (_type == eUserType.USER)
            {
                User user = Core.MODELS.GetUserById(OWNER_ID);
                if (user != null)
                {
                    rtn = user.Name;
                }
            }
            else
            {
                Trainer trainer = Core.MODELS.GetTrainerById(OWNER_ID);
                if (trainer != null)
                {
                    rtn = trainer.Name;
                }
            }
            return rtn;
        }

        private void SaveLocker()
        {
            if(Core.MODELS.GetLockerByOwnerId(_type, OWNER_ID) != null)
            {
                MessageBox.Show("이미 사용 중인 락커가 있습니다. 다시 확인해 주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_locker == null)
            {
                _locker = new Locker();
                _locker.LockerNo = _lockerNo;
            }
            _locker.OwnerType = (int)_type;
            _locker.OwnerId = OWNER_ID;
            _locker.OwnerName = GetOwnerNameById(OWNER_ID);
            _locker.EndDate = chkNoLimit.Checked ? DateTime.MinValue : TimeUtil.GetStartDay(dtEndDate.Value);

            if (Core.MODELS.SaveLocker(_locker, _locker.Id == 0 ? eDBQueryType.INSERT : eDBQueryType.UPDATE))
            {
                MessageBox.Show("저장 성공!", "저장 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isUse = true;
                Core.Instance._frmMain.UpdateLocker(_locker);
            }
            else
            {
                MessageBox.Show("저장 실패!", "저장 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UseEnd(bool isChange = false)
        {
            bool rtn = true;
            if (_locker != null)
            {
                if (_locker.OwnerId == 0) return false;

                if (_locker.EndDate >= TimeUtil.GetStartDay(DateTime.Now))
                {
                    if (MessageBox.Show("아직 기간이 남은 락커입니다. 변경 하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    {
                        return false;
                    }
                }
                else
                {
                    if (MessageBox.Show("사용마감 처리 하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    {
                        return false;
                    }
                }

                _locker.OwnerId = 0;
                _locker.OwnerName = string.Empty;
                _locker.OwnerType = (int)eUserType.NONE;

                if (!Core.MODELS.SaveLocker(_locker, eDBQueryType.UPDATE))
                {
                    MessageBox.Show("락커 마감처리 실패.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    isUse = false;
                    Core.Instance._frmMain.EndLocker(_lockerNo);
                    InitControl();
                }
            }
            return rtn;
        }

        private void LoadData()
        {
            txtOwnerId.Text = OWNER_ID.ToString();
            if (OWNER_ID != 0)
            {
                if (_locker != null)
                {
                    if (_locker.EndDate != DateTime.MinValue)
                    {
                        dtEndDate.Value = _locker.EndDate;
                        chkNoLimit.Checked = false;
                    }
                    else
                    {
                        chkNoLimit.Checked = true;
                    }
                }
                txtOwnerName.Text = GetOwnerNameById(OWNER_ID);
                OWNER_NAME = _locker.OwnerName;
                END_DATE = _locker.EndDate;
                isUse = true;
            }
        }


    }
}
