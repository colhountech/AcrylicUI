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
    public partial class AcrylicGroupBox : GroupBox
    {
        private Color _borderColor = Colors.BtnOutline;

        [Category("Appearance")]
        [Description("Determines the color of the border.")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        public AcrylicGroupBox()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.ResizeRedraw |
                    ControlStyles.UserPaint, true);

            ResizeRedraw = true;
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            var rect = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);
            var stringSize = g.MeasureString(Text, Font);

            var textColor = Colors.Text;
            var fillColor = Colors.Transparent;

            using (var b = new SolidBrush(fillColor))
            {
                g.FillRectangle(b, rect);
            }

            using (var p = new Pen(BorderColor, Scale(Consts.PEN_WIDTH)))
            {
                var borderRect = new Rectangle(0, (int)stringSize.Height / 2, rect.Width - Scale(Consts.PEN_WIDTH), rect.Height - ((int)stringSize.Height / 2) - Scale(Consts.PEN_WIDTH));
                g.DrawRectangle(p, borderRect);
            }

            var textRect = new Rectangle(rect.Left + Scale (Consts.CONTROL_PADDING),
                    rect.Top,
                    rect.Width - (Consts.CONTROL_PADDING * 2),
                    (int)stringSize.Height);

            using (var b2 = new SolidBrush(fillColor))
            {
                var modRect = new Rectangle(textRect.Left, textRect.Top, Math.Min(textRect.Width, (int)stringSize.Width), textRect.Height);
                g.FillRectangle(b2, modRect);
            }

            using (var b = new SolidBrush(textColor))
            {
                var stringFormat = new StringFormat
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Near,
                    FormatFlags = StringFormatFlags.NoWrap,
                    Trimming = StringTrimming.EllipsisCharacter
                };

                g.DrawString(Text, Font, b, textRect, stringFormat);
            }
        }
        #region Dpi Scale

        private const float DEFAULT_DPI = 96f;
        private float _dpiScale = DEFAULT_DPI;

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
