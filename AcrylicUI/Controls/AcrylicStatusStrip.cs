using AcrylicUI.Resources;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AcrylicUI.Controls
{
    public class AcrylicStatusStrip : StatusStrip
    {
        private bool _isAcrylicEnabled;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool IsAcrylicEnabled
        {
            get
            {
                return _isAcrylicEnabled;
            }
            set
            {
                _isAcrylicEnabled = value;
            }
        }


        [Category("Appearance")]
        [Description("Determines the color of the background.")]
        [DefaultValue(typeof(Color), "#313131")]
        public new Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                Invalidate();
            }
        }

        #region Constructor Region

        public AcrylicStatusStrip()
        {
            AutoSize = false;
            BackColor = Colors.GreyBackground;
            ForeColor = Colors.LightText;
            Padding = new Padding(0, 5, 0, 3);
            Size = new Size(Size.Width, 24);
            SizingGrip = false;
        }

        #endregion

        #region Paint Region

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            base.OnPaint(e);
         
            // Ligher Upper Border
            using (var p = new Pen(Colors.MontereyPanel))
            {
                  g.DrawLine(p, ClientRectangle.Left, 0, ClientRectangle.Right, 0);
            } 

            // Darker lower Shadow
            using (var p = new Pen(Colors.MontereyDark))
            {
                g.DrawLine(p, ClientRectangle.Left, 1, ClientRectangle.Right, 1);
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            var g = e.Graphics;

        

            using (var b = new SolidBrush(BackColor))
            {
                g.Clear(BackColor);
                g.FillRectangle(b, ClientRectangle);
            }
           
        }

        #endregion
    }
}
