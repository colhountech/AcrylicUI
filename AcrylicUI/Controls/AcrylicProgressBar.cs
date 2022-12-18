using AcrylicUI.Resources;
using System.Drawing;
using System.Windows.Forms;

namespace AcrylicUI.Controls
{
    public partial class AcrylicProgressBar : ProgressBar
    {
        public AcrylicProgressBar()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.BackColor = Colors.GreyBackground;            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(Colors.GreyBackground);

            int width = (int)((double)this.Value / this.Maximum * this.Width);

            e.Graphics.FillRectangle(Brushes.Lime, 0, 0, width, this.Height); 
            
        }
    }
}