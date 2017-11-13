namespace AutoTestFoundation.UI
{
    partial class EditParameterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditParameterForm));
            this.EditParameterTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EditParameterTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.EditParameterTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditParameterTableLayoutPanel
            // 
            this.EditParameterTableLayoutPanel.ColumnCount = 3;
            this.EditParameterTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EditParameterTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.EditParameterTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.EditParameterTableLayoutPanel.Controls.Add(this.EditParameterTextBox, 0, 0);
            this.EditParameterTableLayoutPanel.Controls.Add(this.SaveButton, 1, 1);
            this.EditParameterTableLayoutPanel.Controls.Add(this.CancelButton, 2, 1);
            this.EditParameterTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditParameterTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.EditParameterTableLayoutPanel.Name = "EditParameterTableLayoutPanel";
            this.EditParameterTableLayoutPanel.RowCount = 2;
            this.EditParameterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EditParameterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.EditParameterTableLayoutPanel.Size = new System.Drawing.Size(574, 529);
            this.EditParameterTableLayoutPanel.TabIndex = 0;
            // 
            // EditParameterTextBox
            // 
            this.EditParameterTableLayoutPanel.SetColumnSpan(this.EditParameterTextBox, 3);
            this.EditParameterTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditParameterTextBox.Location = new System.Drawing.Point(3, 3);
            this.EditParameterTextBox.Multiline = true;
            this.EditParameterTextBox.Name = "EditParameterTextBox";
            this.EditParameterTextBox.Size = new System.Drawing.Size(568, 443);
            this.EditParameterTextBox.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveButton.Location = new System.Drawing.Point(339, 469);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(110, 40);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "确定";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelButton.Location = new System.Drawing.Point(459, 469);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(110, 40);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "取消";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EditParameterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(123)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(574, 529);
            this.Controls.Add(this.EditParameterTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditParameterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "参数设置";
            this.EditParameterTableLayoutPanel.ResumeLayout(false);
            this.EditParameterTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel EditParameterTableLayoutPanel;
        private System.Windows.Forms.TextBox EditParameterTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
    }
}