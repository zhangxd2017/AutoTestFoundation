using AutoTestFoundation.Manager;
using AutoTestFoundation.Model;
using AutoTestFoundation.Util;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace AutoTestFoundation.UI
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Shown(object sender, EventArgs e)
        {
            //USB插入监听
            USBManager.GetUSBManager();

            //读取配置文件并初始化用户以及
            string appConfigPath = PathUtil.GetAppConfig();
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                Application.DoEvents();
            }
            if (File.Exists(appConfigPath))
            {
                string applicationStr = File.ReadAllText(appConfigPath);
                AppConfig application = JsonConvert.DeserializeObject<AppConfig>(applicationStr);
                if (application != null && application.DataBaseName != null)
                {
                    ItemManager.GetItemManager().InitWithConfig(PathUtil.GetConfigPath() + application.DataBaseName);
                    ConfigManager.GetConfigManager().InitWithConfig(PathUtil.GetConfigPath() + application.DataBaseName);
                }
                this.DialogResult = DialogResult.OK;
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(50);
                    this.Opacity = 1 - i * 0.1;
                    Application.DoEvents();
                }
            }
            else
            {
                MessageBox.Show("无法找到配置文件：" + appConfigPath + "\r\n请检查",
                    "严重错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            Close();
        }
    }
}
