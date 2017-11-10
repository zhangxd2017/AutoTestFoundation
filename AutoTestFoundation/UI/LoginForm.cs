using AutoTestFoundation.Constant;
using AutoTestFoundation.Manager;
using AutoTestFoundation.Model;
using AutoTestFoundation.Util;
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
    public partial class LoginForm : Form
    {
        [DllImport("user32")]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
        

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 300, WindowsMessage.AW_SLIDE | WindowsMessage.AW_ACTIVE | WindowsMessage.AW_VER_NEGATIVE);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.Empty.Equals(AccountTextBox.Text))
            {
                MessageBox.Show("请输入用户名");
            }
            else if (string.Empty.Equals(PasswordTextBox.Text))
            {
                MessageBox.Show("请输入密码");
            }
            else if (!UserManager.GetUserManager().ContainsUserName(AccountTextBox.Text))
            {
                MessageBox.Show("不存在的用户名");
                AccountTextBox.Text = "";
                PasswordTextBox.Text = "";
                AccountTextBox.Focus();
            }
            else if (!UserManager.GetUserManager().ValidateUserNameAndPassword(AccountTextBox.Text, PasswordTextBox.Text))
            {
                MessageBox.Show("密码不正确");
                PasswordTextBox.Text = "";
                AccountTextBox.Focus();
            }
            else
            {
                UserManager.GetUserManager().SetCurrentUser(new User(AccountTextBox.Text, PasswordTextBox.Text));
                MessageBox.Show("登陆成功");
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            AccountTextBox.Focus();
        }

        private void AccountTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PasswordTextBox.Focus();
            }
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton.PerformClick();
            }
        }
    }
}
