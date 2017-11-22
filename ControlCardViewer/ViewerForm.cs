using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCardViewer
{
    public partial class ViewerForm : Form
    {

        MemoryMappedFile mappedFile = null;
        MemoryMappedViewAccessor accessor = null;

        private List<RadioButton> radioButtons = new List<RadioButton>();

        public ViewerForm()
        {
            InitializeComponent();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    Label label = new Label();
                    if (i <= 3)
                    {
                        label.Location = new Point(6 + 18 * j, 40 + 30 * i);
                    }
                    else
                    {
                        label.Location = new Point(6 + 18 * j, 80 + 30 * i);
                    }
                    label.Size = new Size(18, 12);
                    label.AutoSize = false;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Text = (i > 3 ? ((i - 4) * 16 + j + 1) : (i * 16 + j + 1)).ToString();
                    this.Controls.Add(label);
                    Panel panel = new Panel();
                    if (i <= 3)
                    {
                        panel.Location = new Point(6 + 18 * j, 52 + 30 * i);
                    }
                    else
                    {
                        panel.Location = new Point(6 + 18 * j, 92 + 30 * i);
                    }
                    panel.Size = new Size(18, 18);
                    RadioButton radioButton = new RadioButton();
                    radioButton.AutoCheck = false;
                    radioButton.CheckAlign = ContentAlignment.MiddleCenter;
                    radioButton.Dock = DockStyle.Fill;
                    if (i <= 3)
                    {
                        radioButton.Enabled = false;
                    }
                    else
                    {
                        radioButton.Name = ((i - 4) * 16 + j + 1).ToString();
                        radioButton.Click += RadioButtonClick;
                    }
                    radioButtons.Add(radioButton);
                    panel.Controls.Add(radioButton);
                    Controls.Add(panel);
                }
            }
            Label inLabel = new Label();
            inLabel.Location = new Point(6, 20);
            inLabel.AutoSize = true;
            inLabel.Text = "控制卡输入";
            inLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(inLabel);
            Label outLabel = new Label();
            outLabel.Location = new Point(6, 180);
            outLabel.AutoSize = true;
            outLabel.Text = "控制卡输出";
            outLabel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(outLabel);
        }

        private void RadioButtonClick(object sender, EventArgs e)
        {
            int index = 63 + int.Parse(((RadioButton)sender).Name);
            radioButtons[index].Checked = !radioButtons[index].Checked;
        }

        private void ViewerForm_Shown(object sender, EventArgs e)
        {
            //ShowData(new byte[] { 0xFE, 0xDC, 0xBA, 0x98, 0x76, 0x54, 0x32, 0x10,
            //                      0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF});
            try
            {
                mappedFile = MemoryMappedFile.OpenExisting("MainForm", MemoryMappedFileRights.Read);
                accessor = mappedFile.CreateViewAccessor(0, 0, MemoryMappedFileAccess.Read);
                ReadMemoryTimer.Enabled = true;
            }
            catch
            {
                MessageBox.Show("没有检测到控制卡数据，请先打开测试主程序");
                return;
            }
        }

        private void ReadMemoryTimer_Tick(object sender, EventArgs e)
        {
            if (accessor != null)
            {
                byte[] readData = new byte[16];
                try
                {
                    accessor.ReadArray(0, readData, 0, 16);
                    ShowData(readData);
                }catch
                {
                    if (accessor != null)
                    {
                        accessor.Dispose();
                        accessor = null;
                    }
                }
            }
        }

        private void ViewerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (accessor != null)
            {
                accessor.Dispose();
                accessor = null;
            }
            if (mappedFile != null)
            {
                mappedFile.Dispose();
                mappedFile = null;
            }
        }

        /// <summary>
        /// 控制卡IO值 高64位为In 低64位为Out 默认高电平
        /// </summary>
        /// <param name="data"></param>
        private void ShowData(byte[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                byte value = data[i];
                for (int j = 0; j < 8; j++)
                {
                    radioButtons[8 * i + j].Checked = (value & (1 << (7-j))) > 0;
                }
            }
        }
    }
}
