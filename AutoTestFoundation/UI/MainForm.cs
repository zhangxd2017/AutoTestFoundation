using AutoTestFoundation.Manager;
using AutoTestFoundation.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTestFoundation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region 控件事件
        private void UserPictureBox_Click(object sender, EventArgs e)
        {
            if (UserManager.GetUserManager().GetCurrentUser().IsAdmin())
            {
                if (DialogResult.OK == new MaskForm<LogoutForm>().ShowDialog(this))
                {

                }
            }
            else
            {
                if (DialogResult.OK == new MaskForm<LoginForm>().ShowDialog(this))
                {

                }
            }
        }
        #endregion
    }
}
