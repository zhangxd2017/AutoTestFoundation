namespace AutoTestFoundation.UI
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.SettingTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ConfigLabel = new System.Windows.Forms.Label();
            this.ConfigComboBox = new System.Windows.Forms.ComboBox();
            this.SettingUserTabControl = new AutoTestFoundation.View.UserTabControl();
            this.ItemTabPage = new System.Windows.Forms.TabPage();
            this.ItemTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SettingDataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExecute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParamerters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRepeatCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNeedTest = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AddButton = new System.Windows.Forms.PictureBox();
            this.RemoveButton = new System.Windows.Forms.PictureBox();
            this.UpButton = new System.Windows.Forms.PictureBox();
            this.DownButton = new System.Windows.Forms.PictureBox();
            this.ConfigTabPage = new System.Windows.Forms.TabPage();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SettingTableLayoutPanel.SuspendLayout();
            this.SettingUserTabControl.SuspendLayout();
            this.ItemTabPage.SuspendLayout();
            this.ItemTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownButton)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingTableLayoutPanel
            // 
            this.SettingTableLayoutPanel.ColumnCount = 5;
            this.SettingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.SettingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SettingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SettingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SettingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SettingTableLayoutPanel.Controls.Add(this.ConfigLabel, 0, 0);
            this.SettingTableLayoutPanel.Controls.Add(this.ConfigComboBox, 1, 0);
            this.SettingTableLayoutPanel.Controls.Add(this.SettingUserTabControl, 0, 1);
            this.SettingTableLayoutPanel.Controls.Add(this.SaveButton, 3, 3);
            this.SettingTableLayoutPanel.Controls.Add(this.CancelButton, 4, 3);
            this.SettingTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingTableLayoutPanel.Name = "SettingTableLayoutPanel";
            this.SettingTableLayoutPanel.RowCount = 5;
            this.SettingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SettingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.SettingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.SettingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.SettingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.SettingTableLayoutPanel.Size = new System.Drawing.Size(1000, 700);
            this.SettingTableLayoutPanel.TabIndex = 0;
            // 
            // ConfigLabel
            // 
            this.ConfigLabel.AutoSize = true;
            this.ConfigLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigLabel.ForeColor = System.Drawing.Color.White;
            this.ConfigLabel.Location = new System.Drawing.Point(3, 0);
            this.ConfigLabel.Name = "ConfigLabel";
            this.ConfigLabel.Size = new System.Drawing.Size(294, 70);
            this.ConfigLabel.TabIndex = 0;
            this.ConfigLabel.Text = "配置文件";
            this.ConfigLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfigComboBox
            // 
            this.ConfigComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConfigComboBox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConfigComboBox.FormattingEnabled = true;
            this.ConfigComboBox.Location = new System.Drawing.Point(303, 12);
            this.ConfigComboBox.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.ConfigComboBox.Name = "ConfigComboBox";
            this.ConfigComboBox.Size = new System.Drawing.Size(194, 48);
            this.ConfigComboBox.TabIndex = 1;
            // 
            // SettingUserTabControl
            // 
            this.SettingUserTabControl.Alpha = ((byte)(16));
            this.SettingUserTabControl.BgColor = System.Drawing.Color.Transparent;
            this.SettingUserTabControl.BordColor = System.Drawing.Color.Transparent;
            this.SettingTableLayoutPanel.SetColumnSpan(this.SettingUserTabControl, 5);
            this.SettingUserTabControl.Controls.Add(this.ItemTabPage);
            this.SettingUserTabControl.Controls.Add(this.ConfigTabPage);
            this.SettingUserTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingUserTabControl.Location = new System.Drawing.Point(3, 73);
            this.SettingUserTabControl.Name = "SettingUserTabControl";
            this.SettingUserTabControl.SelectedIndex = 0;
            this.SettingUserTabControl.Size = new System.Drawing.Size(994, 554);
            this.SettingUserTabControl.TabIndex = 2;
            this.SettingUserTabControl.TextColor = System.Drawing.Color.Gray;
            this.SettingUserTabControl.TextSeleColor = System.Drawing.Color.Black;
            this.SettingUserTabControl.TitleColor = System.Drawing.Color.Transparent;
            this.SettingUserTabControl.TitleSeleColor = System.Drawing.Color.White;
            // 
            // ItemTabPage
            // 
            this.ItemTabPage.BackColor = System.Drawing.Color.Transparent;
            this.ItemTabPage.Controls.Add(this.ItemTableLayoutPanel);
            this.ItemTabPage.Location = new System.Drawing.Point(8, 35);
            this.ItemTabPage.Name = "ItemTabPage";
            this.ItemTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemTabPage.Size = new System.Drawing.Size(978, 511);
            this.ItemTabPage.TabIndex = 0;
            this.ItemTabPage.Text = "测试项设置";
            // 
            // ItemTableLayoutPanel
            // 
            this.ItemTableLayoutPanel.ColumnCount = 2;
            this.ItemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ItemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.ItemTableLayoutPanel.Controls.Add(this.SettingDataGridView, 0, 0);
            this.ItemTableLayoutPanel.Controls.Add(this.AddButton, 1, 1);
            this.ItemTableLayoutPanel.Controls.Add(this.RemoveButton, 1, 2);
            this.ItemTableLayoutPanel.Controls.Add(this.UpButton, 1, 3);
            this.ItemTableLayoutPanel.Controls.Add(this.DownButton, 1, 4);
            this.ItemTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.ItemTableLayoutPanel.Name = "ItemTableLayoutPanel";
            this.ItemTableLayoutPanel.RowCount = 6;
            this.ItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.ItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.ItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.ItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.ItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ItemTableLayoutPanel.Size = new System.Drawing.Size(972, 505);
            this.ItemTableLayoutPanel.TabIndex = 1;
            // 
            // SettingDataGridView
            // 
            this.SettingDataGridView.AllowUserToAddRows = false;
            this.SettingDataGridView.AllowUserToDeleteRows = false;
            this.SettingDataGridView.AllowUserToResizeColumns = false;
            this.SettingDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SettingDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SettingDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SettingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SettingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIndex,
            this.ColumnName,
            this.ColumnExecute,
            this.ColumnParamerters,
            this.ColumnTimeOut,
            this.ColumnRepeatCount,
            this.ColumnNeedTest});
            this.SettingDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingDataGridView.Location = new System.Drawing.Point(3, 3);
            this.SettingDataGridView.Name = "SettingDataGridView";
            this.SettingDataGridView.RowHeadersVisible = false;
            this.ItemTableLayoutPanel.SetRowSpan(this.SettingDataGridView, 6);
            this.SettingDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SettingDataGridView.RowTemplate.Height = 37;
            this.SettingDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SettingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.SettingDataGridView.Size = new System.Drawing.Size(866, 499);
            this.SettingDataGridView.TabIndex = 0;
            this.SettingDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SettingDataGridView_CellClick);
            this.SettingDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SettingDataGridView_CellDoubleClick);
            // 
            // ColumnIndex
            // 
            this.ColumnIndex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnIndex.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnIndex.FillWeight = 5F;
            this.ColumnIndex.HeaderText = "序号";
            this.ColumnIndex.Name = "ColumnIndex";
            this.ColumnIndex.ReadOnly = true;
            this.ColumnIndex.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnName.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnName.FillWeight = 15F;
            this.ColumnName.HeaderText = "名称";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnExecute
            // 
            this.ColumnExecute.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnExecute.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnExecute.FillWeight = 30F;
            this.ColumnExecute.HeaderText = "执行文件";
            this.ColumnExecute.Name = "ColumnExecute";
            this.ColumnExecute.ReadOnly = true;
            this.ColumnExecute.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnParamerters
            // 
            this.ColumnParamerters.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnParamerters.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnParamerters.FillWeight = 30F;
            this.ColumnParamerters.HeaderText = "参数";
            this.ColumnParamerters.Name = "ColumnParamerters";
            this.ColumnParamerters.ReadOnly = true;
            this.ColumnParamerters.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnTimeOut
            // 
            this.ColumnTimeOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnTimeOut.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColumnTimeOut.FillWeight = 10F;
            this.ColumnTimeOut.HeaderText = "超时";
            this.ColumnTimeOut.Name = "ColumnTimeOut";
            this.ColumnTimeOut.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnRepeatCount
            // 
            this.ColumnRepeatCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnRepeatCount.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColumnRepeatCount.FillWeight = 5F;
            this.ColumnRepeatCount.HeaderText = "重试";
            this.ColumnRepeatCount.Name = "ColumnRepeatCount";
            this.ColumnRepeatCount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnNeedTest
            // 
            this.ColumnNeedTest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNeedTest.FillWeight = 5F;
            this.ColumnNeedTest.HeaderText = "是否测试";
            this.ColumnNeedTest.Name = "ColumnNeedTest";
            this.ColumnNeedTest.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Image = global::AutoTestFoundation.Properties.Resources.add;
            this.AddButton.Location = new System.Drawing.Point(875, 37);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 100);
            this.AddButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddButton.TabIndex = 1;
            this.AddButton.TabStop = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddButton_MouseDown);
            this.AddButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddButton_MouseUp);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveButton.Image = global::AutoTestFoundation.Properties.Resources.delete;
            this.RemoveButton.Location = new System.Drawing.Point(875, 145);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(94, 104);
            this.RemoveButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.TabStop = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            this.RemoveButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RemoveButton_MouseDown);
            this.RemoveButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RemoveButton_MouseUp);
            // 
            // UpButton
            // 
            this.UpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpButton.Image = global::AutoTestFoundation.Properties.Resources.up;
            this.UpButton.Location = new System.Drawing.Point(875, 255);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(94, 104);
            this.UpButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UpButton.TabIndex = 3;
            this.UpButton.TabStop = false;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            this.UpButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpButton_MouseDown);
            this.UpButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UpButton_MouseUp);
            // 
            // DownButton
            // 
            this.DownButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DownButton.Image = global::AutoTestFoundation.Properties.Resources.down;
            this.DownButton.Location = new System.Drawing.Point(875, 365);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(94, 104);
            this.DownButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DownButton.TabIndex = 4;
            this.DownButton.TabStop = false;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            this.DownButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DownButton_MouseDown);
            this.DownButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DownButton_MouseUp);
            // 
            // ConfigTabPage
            // 
            this.ConfigTabPage.BackColor = System.Drawing.Color.Transparent;
            this.ConfigTabPage.Location = new System.Drawing.Point(8, 35);
            this.ConfigTabPage.Name = "ConfigTabPage";
            this.ConfigTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ConfigTabPage.Size = new System.Drawing.Size(978, 511);
            this.ConfigTabPage.TabIndex = 1;
            this.ConfigTabPage.Text = "配置设置";
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveButton.Location = new System.Drawing.Point(620, 640);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(160, 50);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelButton.Location = new System.Drawing.Point(820, 640);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(160, 50);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "取消";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(123)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.SettingTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.SettingTableLayoutPanel.ResumeLayout(false);
            this.SettingTableLayoutPanel.PerformLayout();
            this.SettingUserTabControl.ResumeLayout(false);
            this.ItemTabPage.ResumeLayout(false);
            this.ItemTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SettingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel SettingTableLayoutPanel;
        private System.Windows.Forms.Label ConfigLabel;
        private System.Windows.Forms.ComboBox ConfigComboBox;
        private System.Windows.Forms.Button SaveButton;
        private View.UserTabControl SettingUserTabControl;
        private System.Windows.Forms.TabPage ItemTabPage;
        private System.Windows.Forms.TableLayoutPanel ItemTableLayoutPanel;
        private System.Windows.Forms.DataGridView SettingDataGridView;
        private System.Windows.Forms.PictureBox AddButton;
        private System.Windows.Forms.PictureBox RemoveButton;
        private System.Windows.Forms.PictureBox UpButton;
        private System.Windows.Forms.PictureBox DownButton;
        private System.Windows.Forms.TabPage ConfigTabPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExecute;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParamerters;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTimeOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRepeatCount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnNeedTest;
        private System.Windows.Forms.Button CancelButton;
    }
}