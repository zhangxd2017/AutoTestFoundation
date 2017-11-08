using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTestFoundation.UI
{
    public partial class MaskForm<T> : Form
        where T:Form, new()
    {
        public MaskForm()
        {
            this.ShowInTaskbar = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Black;
            this.Opacity = 0.66D;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Width = Owner.Width;
            Height = Owner.Height;
            Location = new Point(Owner.Location.X, Owner.Location.Y);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Form targetForm = new T();
            targetForm.TopLevel = true;
            DialogResult = targetForm.ShowDialog(this);
            Close();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MaskForm
            // 
            this.ClientSize = new System.Drawing.Size(274, 229);
            this.Name = "MaskForm";
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);

        }
    }
}
