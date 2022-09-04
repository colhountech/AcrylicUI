using AcrylicUI.Resources;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AcrylicUI.Docking
{
    [ToolboxItem(false)]
    [Docking(DockingBehavior.Ask)]
    public class ToolWindow : DockContent
    {
        #region Field Region

        private Rectangle _closeButtonRect;
        private bool _closeButtonHot = false;
        private bool _closeButtonPressed = false;

        private Rectangle _headerRect;
        private bool _shouldDrag;

        #endregion

        #region Property Region

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Padding Padding
        {
            get { return base.Padding; }
        }

        [Category("Appearance")]
        [Description("Determines the acrylic glass effect background.")]
        [DefaultValue(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool IsAcrylic
        {
            get
            {
                return _isAcrylic;
            }
            set
            {
                _isAcrylic = value;
                _defaultBgColor = (IsAcrylic) ? Colors.AcrylicOuterPanel : Colors.GreyBackground;
                _defaultHeaderColor = (IsAcrylic) ? Colors.AcrylicInnerPanel : Colors.HeaderBackground;
                _defaultHeaderActiveColor = (IsAcrylic) ? Colors.AcrylicInnerPanel : Colors.BlueBackground;

            }
        }
        #endregion

        #region Constructor Region

        public ToolWindow()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);

            BackColor = Colors.GreyBackground;
            base.Padding = new Padding(0, Scale(Consts.ToolWindowHeaderSize), 0, 0);

            UpdateCloseButton();
        }

        #endregion

        #region Method Region

        private bool IsActive()
        {
            if (DockPanel == null)
                return false;

            return DockPanel.ActiveContent == this;
        }

        private void UpdateCloseButton()
        {
            _headerRect = new Rectangle
            {
                X = ClientRectangle.Left,
                Y = ClientRectangle.Top,
                Width = ClientRectangle.Width,
                Height = Scale(Consts.ToolWindowHeaderSize)
            };

            _closeButtonRect = new Rectangle
            {
                X = ClientRectangle.Right - DockIcons.tw_close.Width - Scale(Consts.CONTROL_BUTTON_PADDING),
                Y = ClientRectangle.Top + (Scale(Consts.ToolWindowHeaderSize) / 2) - ( DockIcons.tw_close.Height / 2),
                Width = DockIcons.tw_close.Width,
                Height = DockIcons.tw_close.Height
            };
        }

        #endregion

        #region Event Handler Region

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateScale();
            UpdateCloseButton();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (_closeButtonRect.Contains(e.Location) || _closeButtonPressed)
            {
                if (!_closeButtonHot)
                {
                    _closeButtonHot = true;
                    Invalidate();
                }
            }
            else
            {
                if (_closeButtonHot)
                {
                    _closeButtonHot = false;
                    Invalidate();
                }

                if (_shouldDrag)
                {
                    DockPanel.DragContent(this);
                    return;
                }
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (_closeButtonRect.Contains(e.Location))
            {
                _closeButtonPressed = true;
                _closeButtonHot = true;
                Invalidate();
                return;
            }

            if (_headerRect.Contains(e.Location))
            {
                _shouldDrag = true;
                return;
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (_closeButtonRect.Contains(e.Location) && _closeButtonPressed)
                Close();

            _closeButtonPressed = false;
            _closeButtonHot = false;

            _shouldDrag = false;

            Invalidate();
        }

        #endregion

        #region Paint Region

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;

            // Fill body
            using (var b = new SolidBrush(_defaultBgColor))
            {
                g.FillRectangle(b, ClientRectangle);
            }

            var isActive = IsActive();

            // Draw header
            var bgColor = isActive ? _defaultHeaderActiveColor : _defaultHeaderColor;
            var darkColor = isActive ? Colors.DarkBlueBorder : Colors.DarkBorder;
            var lightColor = isActive ? Colors.LightBlueBorder : Colors.LightBorder;

            using (var b = new SolidBrush(bgColor))
            {
                var bgRect = new Rectangle(0, 0, ClientRectangle.Width, Scale(Consts.ToolWindowHeaderSize));
                g.FillRectangle(b, bgRect);
            }

            using (var p = new Pen(darkColor))
            {
                g.DrawLine(p, ClientRectangle.Left, 0, ClientRectangle.Right, 0);
                g.DrawLine(p, ClientRectangle.Left, Scale(Consts.ToolWindowHeaderSize) - Scale(1), ClientRectangle.Right, Scale(Consts.ToolWindowHeaderSize) - Scale(1));
            }

            using (var p = new Pen(lightColor))
            {
                g.DrawLine(p, ClientRectangle.Left, Scale(1), ClientRectangle.Right, Scale(1));
            }

            var xOffset = Scale(2);

            // Draw icon
            if (Icon != null)
            {
                g.DrawImageUnscaled(Icon, ClientRectangle.Left + Scale(5), ClientRectangle.Top + (Scale(Consts.ToolWindowHeaderSize) / 2) - (Icon.Height / 2) + Scale(1));
                xOffset = Icon.Width + Scale(8);
            }

            // Draw text
            using (var b = new SolidBrush(Colors.LightText))
            {
                var textRect = new Rectangle(xOffset, 0, ClientRectangle.Width - Scale(4) - xOffset, Scale(Consts.ToolWindowHeaderSize));

                var format = new StringFormat
                {
                    Alignment = StringAlignment.Near,
                    LineAlignment = StringAlignment.Center,
                    FormatFlags = StringFormatFlags.NoWrap,
                    Trimming = StringTrimming.EllipsisCharacter
                };
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
                g.DrawString(DockText, Font, b, textRect, format);
            }

            // Close button
            var img = _closeButtonHot ? DockIcons.tw_close_selected : DockIcons.tw_close;

            if (isActive)
                img = _closeButtonHot ? DockIcons.tw_active_close_selected : DockIcons.tw_active_close;

            g.DrawImageUnscaled(img, _closeButtonRect.Left, _closeButtonRect.Top);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Absorb event
        }

        #endregion

        #region Dpi Scale

        private const float DEFAULT_DPI = 96f;
        private float _dpiScale = 1;
        private bool _isAcrylic;
        private Color _defaultBgColor;
        private Color _defaultHeaderColor;
        private Color _defaultHeaderActiveColor;

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
        private int Scale(int pixel)
        {
            return (int)(pixel * _dpiScale);
        }

        #endregion

    }
}
