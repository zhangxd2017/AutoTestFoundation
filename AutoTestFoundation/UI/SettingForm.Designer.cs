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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.SettingTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ConfigLabel = new System.Windows.Forms.Label();
            this.ConfigComboBox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ConfigTabPage = new System.Windows.Forms.TabPage();
            this.ItemTabPage = new System.Windows.Forms.TabPage();
            this.ItemTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SettingDataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnNeedTest = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnRepeatCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParamerters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExecute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SettingUserTabControl = new AutoTestFoundation.View.UserTabControl();
            this.SettingTableLayoutPanel.SuspendLayout();
            this.ItemTabPage.SuspendLayout();
            this.ItemTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingDataGridView)).BeginInit();
            this.SettingUserTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingTableLayoutPanel
            // 
            this.SettingTableLayoutPanel.ColumnCount = 4;
            this.SettingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.SettingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.SettingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SettingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SettingTableLayoutPanel.Controls.Add(this.ConfigLabel, 0, 0);
            this.SettingTableLayoutPanel.Controls.Add(this.ConfigComboBox, 1, 0);
            this.SettingTableLayoutPanel.Controls.Add(this.SettingUserTabControl, 0, 1);
            this.SettingTableLayoutPanel.Controls.Add(this.SaveButton, 2, 2);
            this.SettingTableLayoutPanel.Controls.Add(this.CancelButton, 3, 2);
            this.SettingTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingTableLayoutPanel.Name = "SettingTableLayoutPanel";
            this.SettingTableLayoutPanel.RowCount = 3;
            this.SettingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SettingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.SettingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
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
            this.ConfigComboBox.Size = new System.Drawing.Size(294, 48);
            this.ConfigComboBox.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveButton.Location = new System.Drawing.Point(603, 633);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(194, 64);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelButton.Location = new System.Drawing.Point(803, 633);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(194, 64);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "取消";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // ConfigTabPage
            // 
            this.ConfigTabPage.Location = new System.Drawing.Point(8, 39);
            this.ConfigTabPage.Name = "ConfigTabPage";
            this.ConfigTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ConfigTabPage.Size = new System.Drawing.Size(978, 507);
            this.ConfigTabPage.TabIndex = 1;
            this.ConfigTabPage.Text = "配置设置";
            this.ConfigTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemTabPage
            // 
            this.ItemTabPage.Controls.Add(this.ItemTableLayoutPanel);
            this.ItemTabPage.Location = new System.Drawing.Point(8, 39);
            this.ItemTabPage.Name = "ItemTabPage";
            this.ItemTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemTabPage.Size = new System.Drawing.Size(978, 507);
            this.ItemTabPage.TabIndex = 0;
            this.ItemTabPage.Text = "测试项设置";
            this.ItemTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemTableLayoutPanel
            // 
            this.ItemTableLayoutPanel.ColumnCount = 2;
            this.ItemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ItemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.ItemTableLayoutPanel.Controls.Add(this.SettingDataGridView, 0, 0);
            this.ItemTableLayoutPanel.Controls.Add(this.pictureBox1, 1, 1);
            this.ItemTableLayoutPanel.Controls.Add(this.pictureBox2, 1, 2);
            this.ItemTableLayoutPanel.Controls.Add(this.pictureBox3, 1, 3);
            this.ItemTableLayoutPanel.Controls.Add(this.pictureBox4, 1, 4);
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
            this.ItemTableLayoutPanel.Size = new System.Drawing.Size(972, 501);
            this.ItemTableLayoutPanel.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(875, 363);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(94, 50);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(875, 253);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(94, 50);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(875, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::AutoTestFoundation.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(875, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // SettingDataGridView
            // 
            this.SettingDataGridView.AllowUserToAddRows = false;
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
            this.SettingDataGridView.RowTemplate.Height = 37;
            this.SettingDataGridView.Size = new System.Drawing.Size(866, 495);
            this.SettingDataGridView.TabIndex = 0;
            // 
            // ColumnNeedTest
            // 
            this.ColumnNeedTest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNeedTest.HeaderText = "是否测试";
            this.ColumnNeedTest.Name = "ColumnNeedTest";
            // 
            // ColumnRepeatCount
            // 
            this.ColumnRepeatCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnRepeatCount.HeaderText = "重试";
            this.ColumnRepeatCount.Name = "ColumnRepeatCount";
            // 
            // ColumnTimeOut
            // 
            this.ColumnTimeOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTimeOut.HeaderText = "超时";
            this.ColumnTimeOut.Name = "ColumnTimeOut";
            // 
            // ColumnParamerters
            // 
            this.ColumnParamerters.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnParamerters.HeaderText = "参数";
            this.ColumnParamerters.Name = "ColumnParamerters";
            // 
            // ColumnExecute
            // 
            this.ColumnExecute.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnExecute.HeaderText = "执行文件";
            this.ColumnExecute.Name = "ColumnExecute";
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "名称";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnIndex
            // 
            this.ColumnIndex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnIndex.HeaderText = "序号";
            this.ColumnIndex.Name = "ColumnIndex";
            // 
            // SettingUserTabControl
            // 
            this.SettingTableLayoutPanel.SetColumnSpan(this.SettingUserTabControl, 4);
            this.SettingUserTabControl.Controls.Add(this.ItemTabPage);
            this.SettingUserTabControl.Controls.Add(this.ConfigTabPage);
            this.SettingUserTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingUserTabControl.Location = new System.Drawing.Point(3, 73);
            this.SettingUserTabControl.Name = "SettingUserTabControl";
            this.SettingUserTabControl.SelectedIndex = 0;
            this.SettingUserTabControl.Size = new System.Drawing.Size(994, 554);
            this.SettingUserTabControl.TabIndex = 2;
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
            this.SettingTableLayoutPanel.ResumeLayout(false);
            this.SettingTableLayoutPanel.PerformLayout();
            this.ItemTabPage.ResumeLayout(false);
            this.ItemTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingDataGridView)).EndInit();
            this.SettingUserTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel SettingTableLayoutPanel;
        private System.Windows.Forms.Label ConfigLabel;
        private System.Windows.Forms.ComboBox ConfigComboBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private View.UserTabControl SettingUserTabControl;
        private System.Windows.Forms.TabPage ItemTabPage;
        private System.Windows.Forms.TableLayoutPanel ItemTableLayoutPanel;
        private System.Windows.Forms.DataGridView SettingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExecute;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParamerters;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTimeOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRepeatCount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnNeedTest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TabPage ConfigTabPage;
    }
}