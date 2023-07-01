using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Y3.Forms;

namespace Y3
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process[] processes = null;
            string currentProcess = Process.GetCurrentProcess().ProcessName.ToUpper();
            processes = Process.GetProcessesByName(currentProcess);
            if (processes.Length > 1)
            {
                MessageBox.Show("프로그램이 이미 실행중입니다.");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLock());
        }
    }
}
