namespace AutoTestFoundation.UI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AccountLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.AccountTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LoginTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginTableLayoutPanel
            // 
            this.LoginTableLayoutPanel.ColumnCount = 6;
            this.LoginTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.LoginTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.LoginTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LoginTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LoginTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.LoginTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.LoginTableLayoutPanel.Controls.Add(this.AccountLabel, 1, 1);
            this.LoginTableLayoutPanel.Controls.Add(this.PasswordLabel, 1, 2);
            this.LoginTableLayoutPanel.Controls.Add(this.LoginButton, 1, 4);
            this.LoginTableLayoutPanel.Controls.Add(this.CloseButton, 4, 4);
            this.LoginTableLayoutPanel.Controls.Add(this.AccountTextBox, 3, 1);
            this.LoginTableLayoutPanel.Controls.Add(this.PasswordTextBox, 3, 2);
            this.LoginTableLayoutPanel.Controls.Add(this.TitleLabel, 0, 0);
            this.LoginTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginTableLayoutPanel.Name = "LoginTableLayoutPanel";
            this.LoginTableLayoutPanel.RowCount = 6;
            this.LoginTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.LoginTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.LoginTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.LoginTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.LoginTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.LoginTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.LoginTableLayoutPanel.Size = new System.Drawing.Size(600, 500);
            this.LoginTableLayoutPanel.TabIndex = 0;
            // 
            // AccountLabel
            // 
            this.AccountLabel.AutoSize = true;
            this.AccountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountLabel.Location = new System.Drawing.Point(33, 175);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(174, 75);
            this.AccountLabel.TabIndex = 0;
            this.AccountLabel.Text = "用户名";
            this.AccountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordLabel.Location = new System.Drawing.Point(33, 250);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(174, 75);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "密  码";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginButton
            // 
            this.LoginTableLayoutPanel.SetColumnSpan(this.LoginButton, 2);
            this.LoginButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginButton.Location = new System.Drawing.Point(33, 353);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(234, 69);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "确定";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseButton.Location = new System.Drawing.Point(333, 353);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(234, 69);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "关闭";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AccountTextBox
            // 
            this.LoginTableLayoutPanel.SetColumnSpan(this.AccountTextBox, 2);
            this.AccountTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountTextBox.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AccountTextBox.Location = new System.Drawing.Point(280, 185);
            this.AccountTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.AccountTextBox.MaxLength = 20;
            this.AccountTextBox.Name = "AccountTextBox";
            this.AccountTextBox.Size = new System.Drawing.Size(280, 47);
            this.AccountTextBox.TabIndex = 4;
            this.AccountTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AccountTextBox_KeyDown);
            // 
            // PasswordTextBox
            // 
            this.LoginTableLayoutPanel.SetColumnSpan(this.PasswordTextBox, 2);
            this.PasswordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordTextBox.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordTextBox.Location = new System.Drawing.Point(280, 260);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.PasswordTextBox.MaxLength = 20;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(280, 47);
            this.PasswordTextBox.TabIndex = 5;
            this.PasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.LoginTableLayoutPanel.SetColumnSpan(this.TitleLabel, 6);
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TitleLabel.Location = new System.Drawing.Point(3, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(594, 175);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "登录";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.LoginTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            this.LoginTableLayoutPanel.ResumeLayout(false);
            this.LoginTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LoginTableLayoutPanel;
        private System.Windows.Forms.Label AccountLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox AccountTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label TitleLabel;
    }
}