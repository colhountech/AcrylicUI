using AcrylicUI.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcrylicUI.Controls
{
    /// <summary>
    /// Don't set the background color. it's solid
    /// Set the background color it's acrylic???
    /// </summary>
    public partial class AcrylicGlassPanel : UserControl
    {
        #region Field Region
        private bool _hasRoundedCorners;
        private Color _blurColor = Colors.GreyBackground;


        #endregion

        #region Property Region
        [Category("Appearance")]
        [Description("Determines if the buttons have Rounded Corners.")]
        [DefaultValue(false)]
        public bool HasRoundedCorners
        {
            get { return _hasRoundedCorners; }
            set
            {
                _hasRoundedCorners = value;
                Invalidate();
            }
        }
        #endregion

        public AcrylicGlassPanel()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.ResizeRedraw |
                    ControlStyles.UserPaint, true);

            BackColor = Colors.AcrylicOuterPanel; //or Colors.AcrylicInnerPanel;
            ForeColor = Colors.AcrylicHairline;
        }
      
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateScale();
        }

        #region Paint Region
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // absorb event
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            var rect = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);
            var arcRadius = Scale(Consts.SMALL_ARC_RADIUS);

            var rectRounded = Drawing.RoundedRectange(rect, arcRadius);

            var borderColor = ForeColor;
            var fillColor = BackColor;

            using (var b = new SolidBrush(fillColor))
            {
                 g.Clear(Colors.Transparent);
                if (_hasRoundedCorners)
                {
                    g.FillPath(b, rectRounded);
                }
                else
                {
                    g.FillRectangle(b, rect);
                }
            }

            var penWidth = Scale(Consts.PEN_WIDTH) / 2;
            penWidth = penWidth == 0 ? 1 : penWidth;

            using (var p = new Pen(borderColor, penWidth))
            {
                var modRect = new Rectangle(
                    rect.Left,
                    rect.Top,
                    rect.Width - penWidth,
                    rect.Height - penWidth);

                if (_hasRoundedCorners)
                {
                    var modRectRounded = Drawing.RoundedRectange(modRect, arcRadius);
                    g.DrawPath(p, modRectRounded);
                }
                else
                {
                    g.DrawRectangle(p, modRect);

                }
            }
        }

        #endregion

        #region Dpi Scale

        private const float DEFAULT_DPI = 96f;
        private float _dpiScale = 1;

        // call at init too
        private void UpdateScale()
        {
            var form = FindForm();            
            var handle = form?.Handle ?? this.Handle;

            var newDpiScale = (float)Drawing.GetDpi(handle) / (float)DEFAULT_DPI;
            if (newDpiScale != _dpiScale)
            {
                _dpiScale = newDpiScale;

                // TODO
                // update Icons
            }
        }      
        private int Scale(int pixel)
        {
            return (int)(pixel * _dpiScale);
        }
        #endregion
    }
}
