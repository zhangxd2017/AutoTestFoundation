using AutoTestFoundation.Manager;
using AutoTestFoundation.UI;
using AutoTestFoundation.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AutoTestFoundation.Constant;

namespace AutoTestFoundation
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public delegate void DoInMainThread();

        #region 全局变量

        private bool isMouseDown = false;
        private MouseDirection direction = MouseDirection.None;

        private int titleClickCount = 0;
        private System.Threading.Timer titleClickTimer = null;
        #endregion


        public MainForm()
        {
            InitializeComponent();
        }

        #region 窗口事件
        private void MainForm_Load(object sender, EventArgs e)
        {
            //用户头像
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
        #endregion

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

        private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("TitleLabel_MouseDown");
            if (titleClickTimer == null)
            {
                titleClickTimer = new System.Threading.Timer(TitleClickExecute, null, 500, System.Threading.Timeout.Infinite);
            }
            titleClickCount++;
        }
        #endregion

        private void InitDataGrid()
        {
            List<Item> items = ItemManager.GetItemManager().GetItems();
            if (items.Count > 0)
            {
                foreach (Item item in items)
                {
                    DataGridViewRow viewRow = new DataGridViewRow();
                    //序号
                    DataGridViewTextBoxCell indexCell = new DataGridViewTextBoxCell();
                    indexCell.Value = item.Index;
                    viewRow.Cells.Add(indexCell);
                    //名称
                    DataGridViewTextBoxCell nameCell = new DataGridViewTextBoxCell();
                    nameCell.Value = item.ItemText;
                    viewRow.Cells.Add(nameCell);
                    //进度
                    DataGridViewTextBoxCell progressCell = new DataGridViewTextBoxCell();
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
            else
            {
                MessageBox.Show("无法加载测试项，请检查配置文件");
            }
        }

        void TitleClickExecute(object obj)
        {
            if (titleClickCount > 1)
            {
                ChangeWindow();
            }
            else
            {
                MoveWindow();
            }
            titleClickCount = 0;
            if (titleClickTimer != null)
            {
                titleClickTimer.Dispose();
                titleClickTimer = null;
            }
        }

        private void MoveWindow()
        {
            if (InvokeRequired)
            {
                Invoke(new DoInMainThread(MoveWindow));
                return;
            }
            ReleaseCapture();
            SendMessage(this.Handle, WindowMessage.WM_SYSCOMMAND, WindowMessage.SC_MOVE + WindowMessage.HTCAPTION, 0);
        }

        private void ChangeWindow()
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
    }
}
