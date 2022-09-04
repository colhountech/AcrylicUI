using AcrylicUI.Resources;
using Svg;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AcrylicUI.Controls
{
    [ToolboxBitmap(typeof(Button))]
    [DefaultEvent("Click")]
    public class AcrylicButton : Button
    {
        #region Field Region

        private AcrylicControlState _buttonState = AcrylicControlState.Normal;

        private bool _isDefault = false; // remove this after testing
        private bool _spacePressed;
        private bool _hasRoundedCorners = true;
        private int _iconSize = 16;
        private readonly int _padding = Consts.Padding / 2;
        private int _imagePadding = Consts.ImagePadding;

        #endregion

        #region Designer Property Region

        public new string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                Invalidate();
            }
        }

        protected override Size DefaultSize
        {
            get
            {
                return new Size(Consts.BUTTON_WIDTH, Consts.BUTTON_HEIGHT);
            }
        }



        public new bool Enabled
        {
            get { return base.Enabled; }
            set
            {
                base.Enabled = value;
                Invalidate();
            }
        }

        public bool Default
        {
            get { return _isDefault; }
            set
            {
                _isDefault = value;
                Invalidate();
            }
        }


        [Category("Appearance")]
        [Description("Determines if the buttons have Rounded Corners.")]
        [DefaultValue(true)]
        public bool HasRoundedCorners
        {
            get { return _hasRoundedCorners; }
            set
            {
                _hasRoundedCorners = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Determines the amount of padding between the image and text.")]
        [DefaultValue(Consts.BUTTON_XOFFSET)]
        public int ImagePadding
        {
            get { return Scale(_imagePadding); }
            set
            {
                _imagePadding = value;
                Invalidate();
            }
        }

        #endregion

        #region Code Property Region

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool AutoEllipsis
        {
            get { return false; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public AcrylicControlState ButtonState
        {
            get { return _buttonState; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new ContentAlignment ImageAlign
        {
            get { return base.ImageAlign; }
        }


        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(ContentAlignment), "MiddleCenter")]

        public new ContentAlignment TextAlign
        {
            get { return base.TextAlign; }
            set { base.TextAlign = value; }
        }

        #region Icon

        private byte[] _svgIcon;

        public byte[] SvgIcon
        {
            set
            {
                _svgIcon = value;
                RescaleImage();
            }
        }

        private void RescaleImage()
        {
            if (_svgIcon is not null)
            {
                using (var stream = new MemoryStream(_svgIcon))
                {
                    var svgDoc = SvgDocument.Open<SvgDocument>(stream, null);
                    base.Image = svgDoc.Draw(Scale(_iconSize), Scale(_iconSize));
                }
            }
        }

        /// <summary>
        /// Set the svgIcon before getting the Icon
        /// call the UpdateScale(dpiScale) before gettingIcon
        /// 
        /// </summary>
        public new Image Image
        {
            get
            {
                // fall back to base Image if set
                if (base.Image is not null)
                {
                    return base.Image;
                }

                return null;

                //if (_svgIcon is null) return null;

                //using (var stream = new MemoryStream(_svgIcon))
                //{
                //    var svgDoc = SvgDocument.Open<SvgDocument>(stream, null);
                //    return svgDoc.Draw(Scale(_iconSize), Scale(_iconSize));
                //}

            }
            set
            {
                base.Image = value;
            }

        }
        #endregion
        #endregion

        #region Constructor Region

        public AcrylicButton()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);

            base.UseVisualStyleBackColor = false;

            SetButtonState(AcrylicControlState.Normal);
            Padding = new Padding(_padding);
            UpdateScale();

        }

        #endregion

        #region Method Region

        private void SetButtonState(AcrylicControlState buttonState)
        {
            if (_buttonState != buttonState)
            {
                _buttonState = buttonState;
                Invalidate();
            }
        }

        #endregion

        #region Event Handler Region

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            var form = FindForm();
            if (form != null)
            {
                if (form.AcceptButton == this)
                    _isDefault = true;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (_spacePressed)
                return;

            if (e.Button == MouseButtons.Left)
            {
                if (ClientRectangle.Contains(e.Location))
                    SetButtonState(AcrylicControlState.Pressed);
                else
                    SetButtonState(AcrylicControlState.Hover);
            }
            else
            {
                SetButtonState(AcrylicControlState.Hover);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (!ClientRectangle.Contains(e.Location))
                return;

            SetButtonState(AcrylicControlState.Pressed);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (_spacePressed)
                return;

            SetButtonState(AcrylicControlState.Normal);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            if (_spacePressed)
                return;

            SetButtonState(AcrylicControlState.Normal);
        }

        protected override void OnMouseCaptureChanged(EventArgs e)
        {
            base.OnMouseCaptureChanged(e);

            if (_spacePressed)
                return;

            var location = Cursor.Position;

            if (!ClientRectangle.Contains(location))
                SetButtonState(AcrylicControlState.Normal);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);

            Invalidate();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);

            _spacePressed = false;

            var location = Cursor.Position;

            if (!ClientRectangle.Contains(location))
                SetButtonState(AcrylicControlState.Normal);
            else
                SetButtonState(AcrylicControlState.Hover);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Space)
            {
                _spacePressed = true;
                SetButtonState(AcrylicControlState.Pressed);
            }
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            if (e.KeyCode == Keys.Space)
            {
                _spacePressed = false;

                var location = Cursor.Position;

                if (!ClientRectangle.Contains(location))
                    SetButtonState(AcrylicControlState.Normal);
                else
                    SetButtonState(AcrylicControlState.Hover);
            }
        }

        public override void NotifyDefault(bool value)
        {
            base.NotifyDefault(value);

            if (!DesignMode)
                return;

            _isDefault = value;
            Invalidate();
        }

        #endregion

        #region Paint Region
        //protected override void OnPaintBackground(PaintEventArgs pevent)
        //{
        //    // absorb event
        //}

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            var rect = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);
            var arcRadius = Scale(Consts.SMALL_ARC_RADIUS);

            var rectRounded = Drawing.RoundedRectange(rect, arcRadius);

            var textColor = Colors.Text;
            var borderColor = Colors.BtnOutline;
            var fillColor = _isDefault ? Colors.DefaulBlueButtonFill : Colors.BtnFill;

            if (Enabled)
            {
                if (Focused && TabStop)
                    borderColor = _isDefault ? Colors.FocusWhiteOutline : Colors.FocusBlueOutline; // TODO: Create TabStop Colors

                switch (ButtonState)
                {
                    case AcrylicControlState.Hover:
                        fillColor = _isDefault ? Colors.DefaulBlueButtonFill : Colors.BtnHotFill;
                        borderColor = Colors.BtnHotOutline;
                        break;
                    case AcrylicControlState.Pressed:
                        fillColor = _isDefault ? Colors.DefaulBlueButtonPressedFill : Colors.BtnPressedFill;
                        textColor = _isDefault ? Colors.DefaulBlueButtonPressedText : Colors.Text;

                        borderColor = Colors.BtnPressedOutline;
                        break;
                }

            }
            else
            {
                textColor = Colors.DisabledText;
                fillColor = Colors.DisabledFill;
                borderColor = Colors.DisabledOutline;
            }

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

            var textOffsetX = 0;
            var textOffsetY = 0;

            if (Image != null)
            {
                var stringSize = g.MeasureString(Text, Font, rect.Size);

                var x = (ClientSize.Width / 2) - (Image.Size.Width / 2);
                var y = (ClientSize.Height / 2) - (Image.Size.Height / 2);

                switch (TextImageRelation)
                {
                    case TextImageRelation.ImageAboveText:
                        textOffsetY = (Image.Size.Height / 2) + Scale(ImagePadding / 2);
                        y -= ((int)(stringSize.Height / 2) + Scale(ImagePadding / 2));
                        break;
                    case TextImageRelation.TextAboveImage:
                        textOffsetY = ((Image.Size.Height / 2) + Scale(ImagePadding / 2)) * -Scale(Consts.PEN_WIDTH);
                        y += ((int)(stringSize.Height / 2) + Scale(ImagePadding / 2));
                        break;
                    case TextImageRelation.ImageBeforeText:

                        textOffsetX = 0;
                        x = Scale(ImagePadding) + Scale(Consts.PEN_WIDTH); ;

                        break;
                    case TextImageRelation.TextBeforeImage:
                        x = ClientSize.Width - Image.Size.Width - Scale(ImagePadding) - Scale(Consts.PEN_WIDTH);
                        break;
                }

                g.DrawImage(Image, x, y);
            }

            using (var b = new SolidBrush(textColor))
            {
                var modRect = new Rectangle(rect.Left + textOffsetX + Padding.Left, // TODO: Scaling
                                            rect.Top + textOffsetY + Padding.Top, rect.Width - Padding.Horizontal,
                                            rect.Height - Padding.Vertical);

                var stringFormat = new StringFormat
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Center,
                    Trimming = StringTrimming.EllipsisCharacter
                };
                switch (TextAlign)
                {
                    case ContentAlignment.MiddleCenter:
                    case ContentAlignment.TopCenter:
                    case ContentAlignment.BottomCenter:
                        stringFormat.Alignment = StringAlignment.Center;
                        break;
                    case ContentAlignment.MiddleLeft:
                    case ContentAlignment.TopLeft:
                    case ContentAlignment.BottomLeft:
                        stringFormat.Alignment = StringAlignment.Near;
                        break;
                    case ContentAlignment.MiddleRight:
                    case ContentAlignment.TopRight:
                    case ContentAlignment.BottomRight:
                        stringFormat.Alignment = StringAlignment.Far;
                        break;
                }
                g.DrawString(Text, Font, b, modRect, stringFormat);
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
            RescaleImage();
        }
        private int Scale(int pixel)
        {
            return (int)(pixel * _dpiScale);
        }

        #endregion



    }
}
