using AutoTestFoundation.Manager;
using AutoTestFoundation.UI;
using AutoTestFoundation.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AutoTestFoundation.Constant;
using AutoTestFoundation.View;
using System.Threading;
using System.Drawing;
using AutoTestFoundation.Util;
using System.Drawing.Text;

namespace AutoTestFoundation
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public delegate void DoInMainThread(object[] objs);
        public delegate int DoTest(Item item);
        #region 全局变量

        private bool isMouseDown = false;
        private MouseDirection direction = MouseDirection.None;

        private int titleClickCount = 0;
        private System.Threading.Timer titleClickTimer = null;

        private const int TEST_INTERVAL = 100;

        List<Item> items = new List<Item>();

        private bool stopOnFail = true;

        private PrivateFontCollection pfc;

        private DateTime testStartTime;

        private int passCount = 0, failCount = 0, totalCount = 0;

        private string logFilePath = null;
        #endregion

        public MainForm()
        {
            string timeFontPath = PathUtil.CurrentPath + "digital-7.ttf";
            pfc = new PrivateFontCollection();
            pfc.AddFontFile(timeFontPath);
            InitializeComponent();
        }

        #region 窗口事件
        private void MainForm_Load(object sender, EventArgs e)
        {
            //标题栏
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            //测试项
            InitDataGrid();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            direction = MouseDirection.None;
        }

        private void MainForm_MouseLeave(object sender, EventArgs e)
        {
            isMouseDown = false;
            direction = MouseDirection.None;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            //鼠标移动过程中，坐标时刻在改变 
            //当鼠标移动时横坐标距离窗体右边缘5像素以内且纵坐标距离下边缘也在5像素以内时，要将光标变为倾斜的箭头形状，同时拖拽方向direction置为MouseDirection.Declining 
            if (e.Location.X >= this.Width - 5 && e.Location.Y > this.Height - 5)
            {
                this.Cursor = Cursors.SizeNWSE;
                direction = MouseDirection.Declining;
            }
            //当鼠标移动时横坐标距离窗体右边缘5像素以内时，要将光标变为倾斜的箭头形状，同时拖拽方向direction置为MouseDirection.Herizontal
            else if (e.Location.X >= this.Width - 5)
            {
                this.Cursor = Cursors.SizeWE;
                direction = MouseDirection.Herizontal;
            }
            //同理当鼠标移动时纵坐标距离窗体下边缘5像素以内时，要将光标变为倾斜的箭头形状，同时拖拽方向direction置为MouseDirection.Vertical
            else if (e.Location.Y >= this.Height - 5)
            {
                this.Cursor = Cursors.SizeNS;
                direction = MouseDirection.Vertical;
            }
            //否则，以外的窗体区域，鼠标星座均为单向箭头（默认）             
            else
                this.Cursor = Cursors.Arrow;
            //设定好方向后，调用下面方法，改变窗体大小  
            ResizeWindow();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            InitView();
        }
        #endregion

        #region 控件事件
        private void UserPictureBox_Click(object sender, EventArgs e)
        {
            if (UserManager.GetUserManager().GetCurrentUser().IsAdmin())
            {
                DialogResult result = new MaskForm<LogoutForm>().ShowDialog(this);
                if (DialogResult.OK == result)
                {
                    UpdateUser();
                }
                else if (DialogResult.Yes == result)
                {
                    if (DialogResult.OK == new SettingForm().ShowDialog(this))
                    {
                        //更新
                    }
                }
            }
            else
            {
                if (DialogResult.OK == new MaskForm<LoginForm>().ShowDialog(this))
                {
                    UpdateUser();
                }
            }
        }

        private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (titleClickTimer == null)
            {
                titleClickTimer = new System.Threading.Timer(TitleClickExecute, null, 500, System.Threading.Timeout.Infinite);
            }
            titleClickCount++;
        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            OnTest();
        }

        private void TestTimer_Tick(object sender, EventArgs e)
        {
            UpdateTime(new object[] {DateTime.Now });
        }

        private void ClosePictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.close_focus;
        }

        private void ClosePictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.close;
        }

        private void ClosePictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region 自定义方法
        private void InitView()
        {
            //改变控件字体大小
            TitleLabel.Font = new Font(TitleLabel.Font.FontFamily, TitleLabel.Height / 4);
            ResultLabel.Font = new Font(ResultLabel.Font.FontFamily, ResultLabel.Height / 4);
            TimeLabel.Font = new Font(pfc.Families[0], TimeLabel.Height / 4);
            PassLabel.Font = new Font(PassLabel.Font.FontFamily, PassLabel.Height / 4);
            FailLabel.Font = new Font(FailLabel.Font.FontFamily, FailLabel.Height / 4);
            TotalLabel.Font = new Font(TotalLabel.Font.FontFamily, TotalLabel.Height / 4);
            PercentLabel.Font = new Font(PercentLabel.Font.FontFamily, PercentLabel.Height / 4);
        }


        private void InitDataGrid()
        {
            List<Item> tmpItems = ItemManager.GetItemManager().GetItems();
            if (tmpItems.Count > 0)
            {
                items.Clear();
                foreach (Item item in tmpItems)
                {
                    if (item.NeedTest)
                    {
                        items.Add(item);
                        DataGridViewRow viewRow = new DataGridViewRow();
                        //序号
                        DataGridViewTextBoxCell indexCell = new DataGridViewTextBoxCell();
                        indexCell.Value = item.Index;
                        viewRow.Cells.Add(indexCell);
                        //名称
                        DataGridViewTextBoxCell nameCell = new DataGridViewTextBoxCell();
                        nameCell.Value = item.ItemName;
                        viewRow.Cells.Add(nameCell);
                        //进度
                        DataGridViewProgressBarCell progressCell = new DataGridViewProgressBarCell();
                        progressCell.Value = 0;
                        viewRow.Cells.Add(progressCell);
                        //结果
                        DataGridViewTextBoxCell resultCell = new DataGridViewTextBoxCell();
                        viewRow.Cells.Add(resultCell);
                        //时间
                        DataGridViewTextBoxCell timeCell = new DataGridViewTextBoxCell();
                        viewRow.Cells.Add(timeCell);
                        MainDataGridView.Rows.Add(viewRow);
                    }
                }
                MainDataGridView.ClearSelection();
            }
            else
            {
                MessageBox.Show("无法加载测试项，请检查配置文件");
            }
        }

        private void UpdateUser()
        {
            if (UserManager.GetUserManager().GetCurrentUser().IsAdmin())
            {
                UserPictureBox.Image = Properties.Resources.admin;
            }
            else
            {
                UserPictureBox.Image = Properties.Resources.user;
            }
        }

        void TitleClickExecute(object obj)
        {
            if (titleClickCount > 1)
            {
                ChangeWindow(new object[] { });
            }
            else
            {
                MoveWindow(new object[] { });
            }
            titleClickCount = 0;
            if (titleClickTimer != null)
            {
                titleClickTimer.Dispose();
                titleClickTimer = null;
            }
        }

        private void MoveWindow(object[] objs)
        {
            if (InvokeRequired)
            {
                Invoke(new DoInMainThread(MoveWindow));
                return;
            }
            ReleaseCapture();
            SendMessage(this.Handle, WindowsMessage.WM_SYSCOMMAND, WindowsMessage.SC_MOVE + WindowsMessage.HTCAPTION, 0);
        }

        private void ChangeWindow(object[] objs)
        {
            if (InvokeRequired)
            {
                Invoke(new DoInMainThread(ChangeWindow));
                return;
            }
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void ResizeWindow()
        {
            //这个判断很重要，只有在鼠标按下时才能拖拽改变窗体大小，如果不作判断，那么鼠标弹起和按下时，窗体都可以改变 
            if (!isMouseDown)
                return;
            //MousePosition的参考点是屏幕的左上角，表示鼠标当前相对于屏幕左上角的坐标this.left和this.top的参考点也是屏幕，属性MousePosition是该程序的重点
            if (direction == MouseDirection.Declining)
            {
                //此行代码在mousemove事件中已经写过，在此再写一遍，并不多余，一定要写
                this.Cursor = Cursors.SizeNWSE;
                //下面是改变窗体宽和高的代码，不明白的可以仔细思考一下
                this.Width = MousePosition.X - this.Left;
                this.Height = MousePosition.Y - this.Top;
            }
            //以下同理
            if (direction == MouseDirection.Herizontal)
            {
                this.Cursor = Cursors.SizeWE;
                this.Width = MousePosition.X - this.Left;
            }
            else if (direction == MouseDirection.Vertical)
            {
                this.Cursor = Cursors.SizeNS;
                this.Height = MousePosition.Y - this.Top;
            }
            //即使鼠标按下，但是不在窗口右和下边缘，那么也不能改变窗口大小
            else
                this.Cursor = Cursors.Arrow;
        }
        #endregion

        #region 测试核心方法

        Random random = new Random();

        private int OnItemTest(Item item)
        {
            Console.WriteLine("OnItemTest" + Environment.CurrentManagedThreadId);
            Thread.Sleep(1000);
            return random.Next(99) > 0 ? 0 : 1;
        }

        private void OnTest()
        {
            bool allResult = true;
            OnStart();
            for (int i = 0; i < items.Count; i++)
            {
                DateTime startTime = DateTime.Now;
                MainDataGridView.Rows[i].Selected = true;
                if (i > items.Count / 4)
                {
                    MainDataGridView.FirstDisplayedScrollingRowIndex = i - items.Count / 4;
                }
                int result = TestItemTest(items[i], i);
                TimeSpan ts = DateTime.Now - startTime;
                if (ts.Hours > 0)
                {
                    UpdateResult(i, result == ResultCode.RESULT_SUCCESS, string.Format("{0:00}:{1:00}.{2:000}", 59, 59, 999));
                }
                else
                {
                    UpdateResult(i, result == ResultCode.RESULT_SUCCESS, string.Format("{0:00}:{1:00}.{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds));
                }
                
                if (result != ResultCode.RESULT_SUCCESS)
                {
                    allResult = false;
                    if (stopOnFail)
                        break;
                }
            }
            OnEnd(allResult);
        }

        private int TestItemTest(Item item, int index)
        {
            int result = ResultCode.RESULT_TIME_OUT;
            int maxCount = item.TimeOut / TEST_INTERVAL;
            for (int i = 0; i < item.RepeatCount; i++)
            {
                int count = 0;
                UpdateProgress(index, 0);
                DoTest doTest = OnItemTest;
                IAsyncResult asyncResult = doTest.BeginInvoke(item, null, null);
                while (!asyncResult.AsyncWaitHandle.WaitOne(TEST_INTERVAL, false))
                {
                    if (count++ >= maxCount)
                    {
                        UpdateProgress(index, 100);
                        return result;
                    }
                    UpdateProgress(index, count * 100 / maxCount);
                    Application.DoEvents();
                }
                result = doTest.EndInvoke(asyncResult);
                if (result == ResultCode.RESULT_SUCCESS)
                {
                    break;
                }
            }
            UpdateProgress(index, 100);
            return result;
        }

        private void UpdateProgress(int index, int value)
        {
            DataGridViewProgressBarCell cell = (DataGridViewProgressBarCell)MainDataGridView.Rows[index].Cells[2];
            cell.Value = value;
        }

        private void UpdateResult(int index, bool success, string time)
        {
            MainDataGridView.ClearSelection();
            DataGridViewTextBoxCell indexCell = (DataGridViewTextBoxCell)MainDataGridView.Rows[index].Cells[0];
            DataGridViewTextBoxCell nameCell = (DataGridViewTextBoxCell)MainDataGridView.Rows[index].Cells[1];
            DataGridViewTextBoxCell resultCell = (DataGridViewTextBoxCell)MainDataGridView.Rows[index].Cells[3];
            DataGridViewTextBoxCell timeCell = (DataGridViewTextBoxCell)MainDataGridView.Rows[index].Cells[4];
            if (success)
            {
                indexCell.Style.ForeColor = Color.Blue;
                nameCell.Style.ForeColor = Color.Blue;
                resultCell.Value = "成功";
                resultCell.Style.ForeColor = Color.Blue;
                timeCell.Value = time;
                timeCell.Style.ForeColor = Color.Blue;
            }
            else
            {
                indexCell.Style.ForeColor = Color.Red;
                nameCell.Style.ForeColor = Color.Red;
                resultCell.Value = "失败";
                resultCell.Style.ForeColor = Color.Red;
                timeCell.Value = time;
                timeCell.Style.ForeColor = Color.Red;
            }
        }

        private void UpdateState(int state)
        {
            switch (state)
            {
                case StateCode.STATE_TESTING:
                    ResultLabel.Text = "测试中";
                    ResultLabel.BackColor = Color.Blue;
                    break;
                case StateCode.STATE_PASS:
                    ResultLabel.Text = "成功";
                    ResultLabel.BackColor = Color.Green;
                    break;
                case StateCode.STATE_FAIL:
                    ResultLabel.Text = "失败";
                    ResultLabel.BackColor = Color.Red;
                    break;
            }
        }

        private void UpdateTime(object[] objs)
        {
            if (InvokeRequired)
            {
                Invoke(new DoInMainThread(UpdateTime));
                return;
            }
            if (objs.Length > 0 && objs[0] is DateTime)
            {
                DateTime dateTime = (DateTime)objs[0];
                TimeSpan ts = dateTime - testStartTime;
                if (ts.Hours > 0)
                {
                    TimeLabel.Text = string.Format("{0:00} : {1:00} . {2:000}", 59, 59, 999);
                }
                else
                {
                    TimeLabel.Text = string.Format("{0:00} : {1:00} . {2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds);
                }
            }
        }

        private void UpdatePercent()
        {
            PassLabel.Text = "成功 : " + passCount;
            FailLabel.Text = "失败 : " + failCount;
            TotalLabel.Text = "总数 : " + totalCount;
            int percent = passCount * 100 / totalCount;
            PercentLabel.Text = percent + "%";
            if (percent > 95)
            {
                PercentLabel.ForeColor = Color.LightGreen;
            }
            else if (percent > 90)
            {
                PercentLabel.ForeColor = Color.YellowGreen;
            }
            else if (percent > 85)
            {
                PercentLabel.ForeColor = Color.Orange;
            }
            else
            {
                PercentLabel.ForeColor = Color.Red;
            }
        }

        private void OnStart()
        {
            UpdateState(StateCode.STATE_TESTING);
            for (int i = 0; i < MainDataGridView.Rows.Count; i++)
            {
                DataGridViewTextBoxCell indexCell = (DataGridViewTextBoxCell)MainDataGridView.Rows[i].Cells[0];
                DataGridViewTextBoxCell nameCell = (DataGridViewTextBoxCell)MainDataGridView.Rows[i].Cells[1];
                DataGridViewProgressBarCell progressCell = (DataGridViewProgressBarCell)MainDataGridView.Rows[i].Cells[2];
                DataGridViewTextBoxCell resultCell = (DataGridViewTextBoxCell)MainDataGridView.Rows[i].Cells[3];
                DataGridViewTextBoxCell timeCell = (DataGridViewTextBoxCell)MainDataGridView.Rows[i].Cells[4];
                indexCell.Style.ForeColor = SystemColors.WindowText;
                nameCell.Style.ForeColor = SystemColors.WindowText;
                progressCell.Value = 0;
                resultCell.Value = "";
                resultCell.Style.ForeColor = SystemColors.WindowText;
                timeCell.Value = "";
                timeCell.Style.ForeColor = SystemColors.WindowText;
            }
            MainDataGridView.FirstDisplayedScrollingRowIndex = 0;
            testStartTime = DateTime.Now;
            TimeLabel.Text = string.Format("{0:00} : {1:00} . {2:000}", 0, 0, 0);
            TestTimer.Enabled = true;
        }

        private void OnEnd(bool success)
        {
            UpdateState(success ? StateCode.STATE_PASS : StateCode.STATE_FAIL);
            TestTimer.Enabled = false;
            UpdateTime(new object[] { DateTime.Now });
            totalCount++;
            if (success)
                passCount++;
            else
                failCount++;
            UpdatePercent();
        }

        
        #endregion
    }
}
