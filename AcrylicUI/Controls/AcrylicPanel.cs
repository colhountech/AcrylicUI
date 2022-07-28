using AcrylicUI.Resources;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AcrylicUI.Controls
{
    public class AcrylicPanel : Panel
    {
        #region Constructor Region

        public AcrylicPanel()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);

            base.Padding = new Padding(0);
        }

        #endregion

        #region Event Handler Region

        protected override void OnEnter(System.EventArgs e)
        {
            base.OnEnter(e);

            Invalidate();
        }

        protected override void OnLeave(System.EventArgs e)
        {
            base.OnLeave(e);

            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (Controls.Count > 0)
                Controls[0].Focus();
        }

        #endregion
        private bool _hasRoundedCorners;

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

        #region Paint Region

        protected override void OnPaint(PaintEventArgs e)
        {
                        
            var borderColor = Colors.DarkBorder;
            var fillColor = Colors.GreyBackground;
            if (this.BackColor == Color.Transparent)
            {
                fillColor = Colors.Transparent;
            }
            if (this.ForeColor == Color.Transparent)
            {
                borderColor = Colors.Transparent;
            }

            var g = e.Graphics;
           // g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            var rect = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);
            var arcRadius = Scale(Consts.SMALL_ARC_RADIUS);
            var rectRounded = Drawing.RoundedRectange(rect, arcRadius);

            // get pen width
            var penWidth = Scale(Consts.PEN_WIDTH) / 2;
            penWidth = penWidth == 0 ? 1 : penWidth;

            // fill panel
            using (var b = new SolidBrush(fillColor))
            {
                g.Clear(Colors.Transparent);
                if (HasRoundedCorners)
                {
                    g.FillPath(b, rectRounded);
                }
                else
                {
                    g.FillRectangle(b, rect);
                }
            }

            // draw border
            using (var p = new Pen(borderColor, penWidth))
            {
                var modRect = new Rectangle(
                    rect.Left,
                    rect.Top,
                    rect.Width - penWidth,
                    rect.Height - penWidth);

                var modRectRounded = Drawing.RoundedRectange(modRect, arcRadius);
                if (HasRoundedCorners)
                {
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
            if (form is null)
            {

            }
            var handle = form?.Handle ?? this.Handle;

            var newDpiScale = (float)Drawing.GetDpi(handle) / (float)DEFAULT_DPI;
            if (newDpiScale != _dpiScale)
            {
                _dpiScale = newDpiScale;

                // TODO
                // update Icons
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateScale();
        }
        private int Scale(int pixel)
        {
            return (int)(pixel * _dpiScale);
        }

        #endregion

    }
}
