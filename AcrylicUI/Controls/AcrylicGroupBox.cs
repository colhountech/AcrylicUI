using AcrylicUI.Resources;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AcrylicUI.Controls
{
    public partial class AcrylicGroupBox : GroupBox
    {
        private Color _borderColor = Colors.DarkBorder;

        [Category("Appearance")]
        [Description("Determines the color of the border.")]
        [DefaultValue(typeof(Color), "0x333333")] // Colors.BtnOutline
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        //[Category("Appearance")]
        //[Description("Determines background color.")]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        //[DefaultValue(typeof(Color), "0x00FFFFFF")] // Colors.Transparent
        //public override Color BackColor
        //{
        //    get { return base.BackColor; }
        //    set
        //    {
        //        base.BackColor = value;
        //        Invalidate();
        //    }
        //}
        [Category("Appearance")]
        [Description("Determines the foreground color.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(Color), "0xEBEBEB")] // Colors.Text
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
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
            //g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            var rect = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);
            var stringSize = g.MeasureString(Text, Font);

            var textColor = ForeColor;
            var fillColor = BackColor;
            var borderColor = _borderColor;

            using (var b = new SolidBrush(fillColor))
            {
                g.FillRectangle(b, rect);
            }

            using (var p = new Pen(borderColor, Scale(Consts.PEN_WIDTH)))
            {
                var borderRect = new Rectangle(0, (int)stringSize.Height / 2, rect.Width - Scale(Consts.PEN_WIDTH), rect.Height - ((int)stringSize.Height / 2) - Scale(Consts.PEN_WIDTH));
                g.DrawRectangle(p, borderRect);
            }

            var textRect = new Rectangle(rect.Left + Scale(Consts.CONTROL_PADDING),
                    rect.Top,
                    rect.Width - (Consts.CONTROL_PADDING * 2),
                    (int)stringSize.Height);

            using (var b2 = new SolidBrush(fillColor))
            {
                var modRect = new Rectangle(textRect.Left, textRect.Top, Math.Min(textRect.Width, (int)stringSize.Width), textRect.Height);

                //clear border behind Text
                g.SetClip(modRect, CombineMode.Replace);
                g.Clear(Color.Transparent);
                g.ResetClip();

                // now fill with fillcolor
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
