using AutoTestFoundation.UI;
using AutoTestFoundation.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTestFoundation
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            InvokeUtil.InitPowerShell();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (new SplashForm().ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
