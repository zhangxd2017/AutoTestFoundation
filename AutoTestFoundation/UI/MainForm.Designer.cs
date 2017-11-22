namespace AutoTestFoundation
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProgress = new AutoTestFoundation.View.DataGridViewProgressBarCell.DataGridViewProgressBarColumn();
            this.ColumnResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.LogTextBox = new System.Windows.Forms.RichTextBox();
            this.PreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.CountTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.FailLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.PercentLabel = new System.Windows.Forms.Label();
            this.UserPictureBox = new System.Windows.Forms.PictureBox();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.SNLabel = new System.Windows.Forms.Label();
            this.ClosePictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridViewProgressBarColumn1 = new AutoTestFoundation.View.DataGridViewProgressBarCell.DataGridViewProgressBarColumn();
            this.TestTimer = new System.Windows.Forms.Timer(this.components);
            this.CardTimer = new System.Windows.Forms.Timer(this.components);
            this.MainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).BeginInit();
            this.CountTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(123)))), ((int)(((byte)(191)))));
            this.MainTableLayoutPanel.ColumnCount = 4;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MainTableLayoutPanel.Controls.Add(this.MainDataGridView, 0, 2);
            this.MainTableLayoutPanel.Controls.Add(this.ContentPanel, 2, 2);
            this.MainTableLayoutPanel.Controls.Add(this.TitleLabel, 1, 0);
            this.MainTableLayoutPanel.Controls.Add(this.ResultLabel, 0, 4);
            this.MainTableLayoutPanel.Controls.Add(this.CountTableLayoutPanel, 2, 4);
            this.MainTableLayoutPanel.Controls.Add(this.UserPictureBox, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.StartStopButton, 3, 1);
            this.MainTableLayoutPanel.Controls.Add(this.SNLabel, 0, 3);
            this.MainTableLayoutPanel.Controls.Add(this.ClosePictureBox, 3, 0);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(5, 5);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 5;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.22223F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(1000, 720);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // MainDataGridView
            // 
            this.MainDataGridView.AllowUserToAddRows = false;
            this.MainDataGridView.AllowUserToDeleteRows = false;
            this.MainDataGridView.AllowUserToResizeColumns = false;
            this.MainDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIndex,
            this.ColumnName,
            this.ColumnProgress,
            this.ColumnResult,
            this.ColumnTime});
            this.MainTableLayoutPanel.SetColumnSpan(this.MainDataGridView, 2);
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.MainDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDataGridView.Location = new System.Drawing.Point(3, 125);
            this.MainDataGridView.MultiSelect = false;
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.ReadOnly = true;
            this.MainDataGridView.RowHeadersVisible = false;
            this.MainDataGridView.RowTemplate.Height = 60;
            this.MainDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainDataGridView.Size = new System.Drawing.Size(594, 398);
            this.MainDataGridView.TabIndex = 0;
            // 
            // ColumnIndex
            // 
            this.ColumnIndex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnIndex.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnIndex.HeaderText = "序号";
            this.ColumnIndex.Name = "ColumnIndex";
            this.ColumnIndex.ReadOnly = true;
            this.ColumnIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnName.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnName.HeaderText = "名称";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnProgress
            // 
            this.ColumnProgress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnProgress.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnProgress.HeaderText = "进度";
            this.ColumnProgress.Name = "ColumnProgress";
            this.ColumnProgress.ReadOnly = true;
            this.ColumnProgress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnResult
            // 
            this.ColumnResult.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnResult.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnResult.HeaderText = "结果";
            this.ColumnResult.Name = "ColumnResult";
            this.ColumnResult.ReadOnly = true;
            this.ColumnResult.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnTime
            // 
            this.ColumnTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnTime.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnTime.HeaderText = "时间";
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            this.ColumnTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ContentPanel
            // 
            this.MainTableLayoutPanel.SetColumnSpan(this.ContentPanel, 2);
            this.ContentPanel.Controls.Add(this.LogTextBox);
            this.ContentPanel.Controls.Add(this.PreviewPictureBox);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(603, 125);
            this.ContentPanel.Name = "ContentPanel";
            this.MainTableLayoutPanel.SetRowSpan(this.ContentPanel, 2);
            this.ContentPanel.Size = new System.Drawing.Size(394, 498);
            this.ContentPanel.TabIndex = 1;
            // 
            // LogTextBox
            // 
            this.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTextBox.Location = new System.Drawing.Point(0, 0);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(394, 498);
            this.LogTextBox.TabIndex = 1;
            this.LogTextBox.Text = "";
            // 
            // PreviewPictureBox
            // 
            this.PreviewPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PreviewPictureBox.Location = new System.Drawing.Point(0, 0);
            this.PreviewPictureBox.Name = "PreviewPictureBox";
            this.PreviewPictureBox.Size = new System.Drawing.Size(394, 0);
            this.PreviewPictureBox.TabIndex = 0;
            this.PreviewPictureBox.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.MainTableLayoutPanel.SetColumnSpan(this.TitleLabel, 2);
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(153, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.MainTableLayoutPanel.SetRowSpan(this.TitleLabel, 2);
            this.TitleLabel.Size = new System.Drawing.Size(694, 122);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseDown);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.BackColor = System.Drawing.Color.Blue;
            this.MainTableLayoutPanel.SetColumnSpan(this.ResultLabel, 2);
            this.ResultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultLabel.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResultLabel.ForeColor = System.Drawing.Color.White;
            this.ResultLabel.Location = new System.Drawing.Point(3, 626);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(594, 94);
            this.ResultLabel.TabIndex = 3;
            this.ResultLabel.Text = "等待测试";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CountTableLayoutPanel
            // 
            this.CountTableLayoutPanel.ColumnCount = 3;
            this.MainTableLayoutPanel.SetColumnSpan(this.CountTableLayoutPanel, 2);
            this.CountTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CountTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CountTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CountTableLayoutPanel.Controls.Add(this.TimeLabel, 0, 0);
            this.CountTableLayoutPanel.Controls.Add(this.PassLabel, 1, 0);
            this.CountTableLayoutPanel.Controls.Add(this.FailLabel, 1, 1);
            this.CountTableLayoutPanel.Controls.Add(this.TotalLabel, 1, 2);
            this.CountTableLayoutPanel.Controls.Add(this.PercentLabel, 2, 0);
            this.CountTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CountTableLayoutPanel.Location = new System.Drawing.Point(603, 629);
            this.CountTableLayoutPanel.Name = "CountTableLayoutPanel";
            this.CountTableLayoutPanel.RowCount = 3;
            this.CountTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CountTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CountTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CountTableLayoutPanel.Size = new System.Drawing.Size(394, 88);
            this.CountTableLayoutPanel.TabIndex = 4;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeLabel.ForeColor = System.Drawing.Color.White;
            this.TimeLabel.Location = new System.Drawing.Point(3, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.CountTableLayoutPanel.SetRowSpan(this.TimeLabel, 3);
            this.TimeLabel.Size = new System.Drawing.Size(191, 88);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "00 : 00 : 000";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PassLabel.ForeColor = System.Drawing.Color.LightGreen;
            this.PassLabel.Location = new System.Drawing.Point(200, 0);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(92, 29);
            this.PassLabel.TabIndex = 1;
            this.PassLabel.Text = "成功 : 0";
            this.PassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FailLabel
            // 
            this.FailLabel.AutoSize = true;
            this.FailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FailLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.FailLabel.Location = new System.Drawing.Point(200, 29);
            this.FailLabel.Name = "FailLabel";
            this.FailLabel.Size = new System.Drawing.Size(92, 29);
            this.FailLabel.TabIndex = 2;
            this.FailLabel.Text = "失败 : 0";
            this.FailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalLabel.ForeColor = System.Drawing.Color.White;
            this.TotalLabel.Location = new System.Drawing.Point(200, 58);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(92, 30);
            this.TotalLabel.TabIndex = 3;
            this.TotalLabel.Text = "总数 : 0";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PercentLabel
            // 
            this.PercentLabel.AutoSize = true;
            this.PercentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PercentLabel.ForeColor = System.Drawing.Color.White;
            this.PercentLabel.Location = new System.Drawing.Point(298, 0);
            this.PercentLabel.Name = "PercentLabel";
            this.CountTableLayoutPanel.SetRowSpan(this.PercentLabel, 3);
            this.PercentLabel.Size = new System.Drawing.Size(93, 88);
            this.PercentLabel.TabIndex = 4;
            this.PercentLabel.Text = "100%";
            this.PercentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserPictureBox.Image = global::AutoTestFoundation.Properties.Resources.user;
            this.UserPictureBox.Location = new System.Drawing.Point(20, 20);
            this.UserPictureBox.Margin = new System.Windows.Forms.Padding(20);
            this.UserPictureBox.Name = "UserPictureBox";
            this.MainTableLayoutPanel.SetRowSpan(this.UserPictureBox, 2);
            this.UserPictureBox.Size = new System.Drawing.Size(110, 82);
            this.UserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPictureBox.TabIndex = 5;
            this.UserPictureBox.TabStop = false;
            this.UserPictureBox.Click += new System.EventHandler(this.UserPictureBox_Click);
            // 
            // StartStopButton
            // 
            this.StartStopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartStopButton.Location = new System.Drawing.Point(853, 63);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(144, 56);
            this.StartStopButton.TabIndex = 7;
            this.StartStopButton.Text = "开始";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // SNLabel
            // 
            this.SNLabel.AutoSize = true;
            this.SNLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainTableLayoutPanel.SetColumnSpan(this.SNLabel, 2);
            this.SNLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SNLabel.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SNLabel.ForeColor = System.Drawing.Color.White;
            this.SNLabel.Location = new System.Drawing.Point(3, 526);
            this.SNLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.SNLabel.Name = "SNLabel";
            this.SNLabel.Size = new System.Drawing.Size(594, 97);
            this.SNLabel.TabIndex = 8;
            this.SNLabel.Text = "当前测试：";
            this.SNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClosePictureBox
            // 
            this.ClosePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClosePictureBox.Image = global::AutoTestFoundation.Properties.Resources.close;
            this.ClosePictureBox.Location = new System.Drawing.Point(947, 3);
            this.ClosePictureBox.Name = "ClosePictureBox";
            this.ClosePictureBox.Size = new System.Drawing.Size(50, 50);
            this.ClosePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClosePictureBox.TabIndex = 6;
            this.ClosePictureBox.TabStop = false;
            this.ClosePictureBox.Click += new System.EventHandler(this.ClosePictureBox_Click);
            this.ClosePictureBox.MouseEnter += new System.EventHandler(this.ClosePictureBox_MouseEnter);
            this.ClosePictureBox.MouseLeave += new System.EventHandler(this.ClosePictureBox_MouseLeave);
            // 
            // dataGridViewProgressBarColumn1
            // 
            this.dataGridViewProgressBarColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewProgressBarColumn1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewProgressBarColumn1.HeaderText = "进度";
            this.dataGridViewProgressBarColumn1.Name = "dataGridViewProgressBarColumn1";
            this.dataGridViewProgressBarColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TestTimer
            // 
            this.TestTimer.Interval = 20;
            this.TestTimer.Tick += new System.EventHandler(this.TestTimer_Tick);
            // 
            // CardTimer
            // 
            this.CardTimer.Tick += new System.EventHandler(this.CardTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(123)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1010, 730);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "赛远科技";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.MainTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            this.ContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).EndInit();
            this.CountTableLayoutPanel.ResumeLayout(false);
            this.CountTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.DataGridView MainDataGridView;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.PictureBox PreviewPictureBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TableLayoutPanel CountTableLayoutPanel;
        private System.Windows.Forms.PictureBox UserPictureBox;
        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private View.DataGridViewProgressBarCell.DataGridViewProgressBarColumn ColumnProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private View.DataGridViewProgressBarCell.DataGridViewProgressBarColumn dataGridViewProgressBarColumn1;
        private System.Windows.Forms.RichTextBox LogTextBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer TestTimer;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label FailLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label PercentLabel;
        private System.Windows.Forms.Label SNLabel;
        private System.Windows.Forms.PictureBox ClosePictureBox;
        private System.Windows.Forms.Timer CardTimer;
    }
}

