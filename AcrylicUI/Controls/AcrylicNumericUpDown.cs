using AcrylicUI.Resources;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Security;
using System.Windows.Forms;

namespace AcrylicUI.Controls
{
    public class AcrylicNumericUpDown : NumericUpDown
    {

        private IconFactory _iconFactory;
        private Image _arrowStandardIcon;
        private Image _arrowClickedIcon;
        private Image _arrowDisabledIcon;
        private Image _arrowHotIcon;


        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Color ForeColor { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Color BackColor { get; set; }

        private bool _mouseDown;

        public AcrylicNumericUpDown()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                   ControlStyles.ResizeRedraw |
                   ControlStyles.UserPaint, true);

            base.ForeColor = Color.Gainsboro;
            base.BackColor = Colors.LightBackground;
            
            Controls[0].Paint += DarkNumericUpDown_Paint;

            try
            {
                // Prevent flickering, only if our assembly has reflection permission
                Type type = Controls[0].GetType();
                BindingFlags flags = BindingFlags.NonPublic | BindingFlags.Instance;
                MethodInfo method = type.GetMethod("SetStyle", flags);

                if (method != null)
                {
                    object[] param = { ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true };
                    method.Invoke(Controls[0], param);
                }
            }
            catch (SecurityException)
            {
                // Don't do anything, we are running in a trusted contex
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            _mouseDown = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            _mouseDown = false;
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            Invalidate();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            Invalidate();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            Invalidate();
        }

        protected override void OnTextBoxLostFocus(object source, EventArgs e)
        {
            base.OnTextBoxLostFocus(source, e);
            Invalidate();
        }

        private void DarkNumericUpDown_Paint(object sender, PaintEventArgs e)
        {

            var dpiScale = IconFactory.GetDpiScale(this.Handle);
            _iconFactory = new IconFactory(IconFactory.GetDpiScale(Handle));

            // Down Glyph
            _arrowHotIcon = _iconFactory.BitmapFromSvg(Icons.ASX_GlyphDown_blue_16x);
            _arrowStandardIcon = _iconFactory.BitmapFromSvg(Icons.GlyphDown_71GrayNoHaloSmall_16x);
            _arrowClickedIcon = _iconFactory.BitmapFromSvg(Icons.ASX_GlyphDown_blue_16x);
            _arrowDisabledIcon = _iconFactory.BitmapFromSvg(Icons.ASX_GlyphDown_grey_16x);



            var g = e.Graphics;
            var rect = e.ClipRectangle;

            var fillColor = Colors.HeaderBackground;

            using (var b = new SolidBrush(fillColor))
            {
                g.FillRectangle(b, rect);
            }

            var mousePos = Controls[0].PointToClient(Cursor.Position);

            var upArea = new Rectangle(0, 0, rect.Width, rect.Height / 2);
            var upHot = upArea.Contains(mousePos);

            var upIcon = upHot ? _arrowHotIcon.Clone() as Image : _arrowStandardIcon.Clone() as Image;
            if (upHot && _mouseDown)
                upIcon = _arrowClickedIcon.Clone() as Image;

            upIcon.RotateFlip(RotateFlipType.RotateNoneFlipY);
            g.DrawImageUnscaled(upIcon, (upArea.Width / 2) - (upIcon.Width / 2), (upArea.Height / 2) - (upIcon.Height / 2));

            var downArea = new Rectangle(0, rect.Height / 2, rect.Width, rect.Height / 2);
            var downHot = downArea.Contains(mousePos);

            var downIcon = downHot ? _arrowHotIcon.Clone() as Image : _arrowStandardIcon.Clone() as Image;
            if (downHot && _mouseDown)
                downIcon = _arrowClickedIcon.Clone() as Image;

            g.DrawImageUnscaled(downIcon, (downArea.Width / 2) - (downIcon.Width / 2), downArea.Top + (downArea.Height / 2) - (downIcon.Height / 2));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var g = e.Graphics;
            var rect = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);

            var borderColor = Colors.GreySelection;

            if (Focused && TabStop)
                borderColor = Colors.BlueHighlight;

            using (var p = new Pen(borderColor, 1))
            {
                var modRect = new Rectangle(rect.Left, rect.Top, rect.Width - 1, rect.Height - 1);
                g.DrawRectangle(p, modRect);
            }
        }
    }
}
