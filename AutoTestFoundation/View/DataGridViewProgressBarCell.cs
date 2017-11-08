using System.Drawing;
using System.Windows.Forms;

namespace AutoTestFoundation.View
{
    class DataGridViewProgressBarCell : DataGridViewCell
    {

        protected Color ProgressBarColor = Color.Green; //进度条的默认背景颜色,绿色

        public DataGridViewProgressBarCell()
        {
            this.ValueType = typeof(int);
        }

        //设置进度条的背景色；
        public DataGridViewProgressBarCell(Color progressBarColor)
            : base()
        {
            ProgressBarColor = progressBarColor;
        }

        public class DataGridViewProgressBarColumn : DataGridViewColumn
        {
            public DataGridViewProgressBarColumn()
                : base(new DataGridViewProgressBarCell())
            {
                CellTemplate = new DataGridViewProgressBarCell();
            }
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            using (SolidBrush backBrush = new SolidBrush(cellStyle.BackColor))
            {
                graphics.FillRectangle(backBrush, cellBounds);
            }
            base.PaintBorder(graphics, clipBounds, cellBounds, cellStyle, advancedBorderStyle);

            using (SolidBrush brush = new SolidBrush(ProgressBarColor))
            {
                if (value == null)
                    value = 0;
                int num = (int)value;
                float percent = num / 100F;

                graphics.FillRectangle(brush, cellBounds.X, cellBounds.Y + 1, cellBounds.Width * percent, cellBounds.Height - 3);

                string text = string.Format("{0}%", num);
                SizeF rf = graphics.MeasureString(text, cellStyle.Font);
                float x = cellBounds.X + (cellBounds.Width - rf.Width) / 2f;
                float y = cellBounds.Y + (cellBounds.Height - rf.Height) / 2f;
                graphics.DrawString(text, cellStyle.Font, new SolidBrush(cellStyle.ForeColor), x, y);
            }
        }
    }
}
