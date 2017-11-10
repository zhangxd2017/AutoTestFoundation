using AutoTestFoundation.Constant;
using AutoTestFoundation.Manager;
using AutoTestFoundation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTestFoundation.UI
{
    public partial class LogoutForm : Form
    {
        [DllImport("user32")]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);

        public LogoutForm()
        {
            InitializeComponent();
            TitleLabel.Text = "当前登陆账号：" + UserManager.GetUserManager().GetCurrentUser().Name;
        }

        private void LogoutForm_Load(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 300, WindowsMessage.AW_SLIDE | WindowsMessage.AW_ACTIVE | WindowsMessage.AW_VER_NEGATIVE);
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            UserManager.GetUserManager().SetCurrentUser(User.TestUser);
            MessageBox.Show("已注销登陆");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
