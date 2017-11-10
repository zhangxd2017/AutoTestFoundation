namespace AutoTestFoundation.UI
{
    partial class LogoutForm
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
            this.LogoutTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SettingButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LogoutTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoutTableLayoutPanel
            // 
            this.LogoutTableLayoutPanel.ColumnCount = 7;
            this.LogoutTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.LogoutTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.LogoutTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.LogoutTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.LogoutTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.LogoutTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.LogoutTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.LogoutTableLayoutPanel.Controls.Add(this.SettingButton, 1, 1);
            this.LogoutTableLayoutPanel.Controls.Add(this.LogoutButton, 3, 1);
            this.LogoutTableLayoutPanel.Controls.Add(this.CloseButton, 5, 1);
            this.LogoutTableLayoutPanel.Controls.Add(this.TitleLabel, 0, 0);
            this.LogoutTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoutTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoutTableLayoutPanel.Name = "LogoutTableLayoutPanel";
            this.LogoutTableLayoutPanel.RowCount = 3;
            this.LogoutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.LogoutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LogoutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.LogoutTableLayoutPanel.Size = new System.Drawing.Size(574, 229);
            this.LogoutTableLayoutPanel.TabIndex = 0;
            // 
            // SettingButton
            // 
            this.SettingButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingButton.Location = new System.Drawing.Point(31, 140);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(131, 51);
            this.SettingButton.TabIndex = 0;
            this.SettingButton.Text = "设置";
            this.SettingButton.UseVisualStyleBackColor = true;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoutButton.Location = new System.Drawing.Point(219, 140);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(131, 51);
            this.LogoutButton.TabIndex = 1;
            this.LogoutButton.Text = "注销";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseButton.Location = new System.Drawing.Point(407, 140);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(131, 51);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "关闭";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.LogoutTableLayoutPanel.SetColumnSpan(this.TitleLabel, 7);
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TitleLabel.Location = new System.Drawing.Point(3, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(568, 137);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "当前登陆账号";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(574, 229);
            this.Controls.Add(this.LogoutTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogoutForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LogoutForm";
            this.Load += new System.EventHandler(this.LogoutForm_Load);
            this.LogoutTableLayoutPanel.ResumeLayout(false);
            this.LogoutTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LogoutTableLayoutPanel;
        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label TitleLabel;
    }
}