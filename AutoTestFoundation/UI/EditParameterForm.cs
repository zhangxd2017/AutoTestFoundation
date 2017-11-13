using AutoTestFoundation.Util;
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

namespace AutoTestFoundation.UI
{
    public partial class EditParameterForm : Form
    {

        public string parameter = null;

        public EditParameterForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string value = EditParameterTextBox.Text.Trim();
            if (!RegUtil.IsJson(value))
            {
                MessageBox.Show("格式不正确，请检查");
                return;
            }
            parameter = RegUtil.TrimInvisiable(value);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
