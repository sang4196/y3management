using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Y3.Utility.Enums;

namespace Y3.Forms.Popup
{
    public partial class popLocker : Form
    {
        public popLocker(eUserType userType, int ownerId, int lockerNo)
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;

        }
    }
}
