using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AcrylicUI.Resources;

// Copyright (C) ColhounTech Limited. All rights Reserved
// Author: Micheal Colhoun
// Date: Oct 2021
// Based on DarkUI.DarkForm by Robbin Perrins

namespace AcrylicUI.Controls
{

    public class WindowPanel : Panel
    {
        #region Field Region

        public event EventHandler OnMenuClicked;

        private Image _icon;
        private Image _iconMazimizeCache;
        private Image _iconMazimizeHotCache;
        private Image _iconRestoreCache;
        private Image _iconRestoreHotCache;
        private string _sectionHeader;
        private float _dpiScale = 0f;
        private bool _profileFeature = false;
        private bool _hamburgerMenuFeature = false;
        private bool _hasRoundCorners = false;


        //private const int PEN_WIDTH = 1;
        //private const int CONTROL_BUTTON_XOFFSET = 3;
        //private const int CONTROL_BUTTON_XOFFSET_PLUS_PEN = CONTROL_BUTTON_XOFFSET + PEN_WIDTH;
        //private const int CONTROL_BUTTON_PADDING = 5;
        //private const int CONTROL_HEIGHT = 25;
        //private const int ARC_RADIUS = 8;

        private ControlButton _close = new ControlButton();
        private ControlButton _max = new ControlButton();
        private ControlButton _min = new ControlButton();
        private ControlButton _profile = new ControlButton();
        private ControlButton _menu = new ControlButton();

        #endregion

        #region Property Region

        public bool RoundCorners
        {
            get
            {
                return _hasRoundCorners;
            }
            set
            {
                _hasRoundCorners = value;
            }

        }

        [Category("Appearance")]
        [Description("Determines the acrylic glass effect background.")]
        [DefaultValue(true)]
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
            }
        }

        [Category("Appearance")]
        [Description("Determines if the Profile feature is enabled")]
        [Browsable(true)]
        [DefaultValue(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool ProfileFeature
        {
            get { return _profileFeature; }
            set
            {
                _profileFeature = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Determines if the Profile feature is enabled")]
        [Browsable(true)]
        [DefaultValue(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool HamburgerMenuFeature
        {
            get { return _hamburgerMenuFeature; }
            set
            {
                _hamburgerMenuFeature = value;
                Invalidate();
            }
        }



        [Category("Appearance")]
        [Description("Determines the icon that will appear in the content tabs and headers.")]
        public Image Icon
        {
            get { return _icon; }
            set
            {
                _icon = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Padding Padding
        {
            get { return base.Padding; }
        }

        [Category("Appearance")]
        [Description("The section header text associated with this control.")]
        public string SectionHeader
        {
            get { return _sectionHeader; }
            set
            {
                _sectionHeader = value;
                Invalidate();
            }
        }

        #endregion

        #region Constructor Region

        public WindowPanel()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);       
            if (_hasRoundCorners)
            {
                base.Padding = new Padding(Consts.PEN_WIDTH, Consts.CONTROL_HEIGHT, Consts.PEN_WIDTH, Consts.ARC_RADIUS); // Top spacing for esthetics, Lower spacing for arc
            }
            else
            {
                base.Padding = new Padding(Consts.PEN_WIDTH, Consts.CONTROL_HEIGHT, Consts.PEN_WIDTH, Consts.PEN_WIDTH); // Top spacing for esthetics
            }
            UpdateScale();
            UpdateControlButtons();



        }

        private void UpdateScale()
        {
            var newDpiScale = (float)GetDpiForWindow(this.Handle) / (float)96f;
            if (newDpiScale != _dpiScale)
            {
                _dpiScale = newDpiScale;

                // update cache before max icon
                _iconMazimizeCache = new IconFactory(_dpiScale).GreyBitmapFromSvg(Icons.ChromeRestore_16x_svg);
                _iconMazimizeHotCache = new IconFactory(_dpiScale).WhiteBitmapFromSvg(Icons.ChromeRestore_16x_svg);
                _iconRestoreCache = new IconFactory(_dpiScale).GreyBitmapFromSvg(Icons.ChromeMaximize_16x_svg);
                _iconRestoreHotCache = new IconFactory(_dpiScale).WhiteBitmapFromSvg(Icons.ChromeMaximize_16x_svg);


                //
                //close
                //
                _close.Icon?.Dispose();
                _close.Icon = new IconFactory(_dpiScale).GreyBitmapFromSvg(Icons.ChromeClose_16x_svg);
                _close.IconHot?.Dispose();
                _close.IconHot = new IconFactory(_dpiScale).WhiteBitmapFromSvg(Icons.ChromeClose_16x_svg);

                //
                // max
                //

                _max.Icon?.Dispose();
                _max.IconHot?.Dispose();
                UpdateMaxIcon();

                //
                // min
                //
                _min.Icon?.Dispose();
                _min.Icon = new IconFactory(_dpiScale).GreyBitmapFromSvg(Icons.ChromeMinimize_16x_svg);
                _min.IconHot?.Dispose();
                _min.IconHot = new IconFactory(_dpiScale).WhiteBitmapFromSvg(Icons.ChromeMinimize_16x_svg);
                //
                // profile
                //
                _profile.Icon?.Dispose();
                _profile.Icon = new IconFactory(_dpiScale).BitmapFromSvg(Icons.UserProfile_16x_svg);
                _profile.IconHot?.Dispose();
                _profile.IconHot = new IconFactory(_dpiScale).BitmapFromSvg(Icons.UserProfile_16x_svg);
                //
                // menu
                //
                _menu.Icon?.Dispose();
                _menu.Icon = new IconFactory(_dpiScale).DarkColorFromSvg(Icons.HamburgerMenu_16x_svg,
                    backColorHex: "#fff6f6f6",
                    newBackColorHex: "#001ff1f1",
                    foreColorHex: "#ff424242",
                    newForeColorHex: "ff7e7e7e"
                    );
                _menu.IconHot?.Dispose();
                _menu.IconHot = new IconFactory(_dpiScale).WhiteBitmapFromSvg(Icons.HamburgerMenu_16x_svg);

            }
        }

        private void UpdateMaxIcon()
        {
            var state = FindForm()?.WindowState;

            if (state == FormWindowState.Maximized)
            {
                _max.Icon = _iconMazimizeCache;
                _max.IconHot = _iconMazimizeHotCache;

            }
            else
            {
                _max.Icon = _iconRestoreCache;
                _max.IconHot = _iconRestoreHotCache;
            }
        }

        private void UpdateControlButtons()
        {
            int xMenuButtonOffset = 0;

            if (_hamburgerMenuFeature)
            {
                xMenuButtonOffset = Scale(Consts.CONTROL_BUTTON_PADDING) + Scale(Consts.CONTROL_BUTTON_XOFFSET);
                _menu.Rect = new Rectangle
                {
                    X = xMenuButtonOffset,
                    Y = ClientRectangle.Top + (Scale(Consts.CONTROL_HEIGHT) / 2) - (_menu.Icon.Height / 2),
                    Width = _menu.Icon.Width,
                    Height = _menu.Icon.Height

                };
            }
          
            var xCloseButtonOffset = _close.Icon.Width + Scale(Consts.CONTROL_BUTTON_PADDING) + Scale(Consts.CONTROL_BUTTON_XOFFSET);

            _close.Rect = new Rectangle
            {
                X = ClientRectangle.Right - xCloseButtonOffset,
                Y = ClientRectangle.Top + (Scale(Consts.CONTROL_HEIGHT) / 2) - (_close.Icon.Height / 2),
                Width = _close.Icon.Width,
                Height = _close.Icon.Height
            };

            var xMaxButtonOffset = xCloseButtonOffset + _max.Icon.Width + Scale(Consts.CONTROL_BUTTON_PADDING * 3 );

            _max.Rect = new Rectangle
            {

                X = ClientRectangle.Right - xMaxButtonOffset,
                Y = ClientRectangle.Top + (Scale(Consts.CONTROL_HEIGHT) / 2) - (_max.Icon.Height / 2),
                Width = _max.Icon.Width,
                Height = _max.Icon.Height

            };

            var xMinButtonOffset = xMaxButtonOffset + _min.Icon.Width + Scale(Consts.CONTROL_BUTTON_PADDING * 3);

            _min.Rect = new Rectangle
            {

                X = ClientRectangle.Right - xMinButtonOffset,
                Y = ClientRectangle.Top + (Scale(Consts.CONTROL_HEIGHT) / 2) - (_min.Icon.Height / 2),
                Width = _min.Icon.Width,
                Height = _min.Icon.Height

            };

            var xProfileButtonOffset = xMinButtonOffset + _min.Icon.Width + Scale(Consts.CONTROL_BUTTON_PADDING * 3);

            _profile.Rect = new Rectangle
            {

                X = ClientRectangle.Right - xProfileButtonOffset,
                Y = ClientRectangle.Top + (Scale(Consts.CONTROL_HEIGHT) / 2) - (_profile.Icon.Height / 2),
                Width = _profile.Icon.Width,
                Height = _profile.Icon.Height

            };


        }

        private int Scale(int pixel)
        {
            return (int)(pixel * _dpiScale);
        }
        
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateScale();
            UpdateControlButtons();
        }


        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            UpdateMaxIcon();
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

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            //
            // close
            //

            if (_close.Rect.Contains(e.Location) || _close.IsPressed)
            {
                if (!_close.IsHot)
                {
                    _close.IsHot = true;
                    Invalidate();
                }
            }
            else
            {
                if (_close.IsHot)
                {
                    _close.IsHot = false;
                    Invalidate();
                }

            }
           
            //
            // max
            // 
            if (_max.Rect.Contains(e.Location) || _max.IsPressed)
            {

                if (!_max.IsHot)
                {
                    _max.IsHot = true;
                    Invalidate();
                }
            }
            else
            {
                if (_max.IsHot)
                {
                    _max.IsHot = false;
                    Invalidate();
                }
            }

            //
            // menu
            //

            if (_hamburgerMenuFeature)
            {
                if (_menu.Rect.Contains(e.Location) || _menu.IsPressed)
                {
                    if (!_menu.IsHot)
                    {
                        _menu.IsHot = true;
                        Invalidate();
                    }
                }
                else
                {
                    if (_menu.IsHot)
                    {
                        _menu.IsHot = false;
                        Invalidate();
                    }

                }
            }
            //
            // Min
            //
            if (_min.Rect.Contains(e.Location) || _min.IsPressed)
            {
                if (!_min.IsHot)
                {
                    _min.IsHot = true;
                    Invalidate();
                }
            }
            else
            {
                if (_min.IsHot)
                {
                    _min.IsHot = false;
                    Invalidate();
                }

            }
            //
            // profile
            //
    
            if (_profile.Rect.Contains(e.Location) || _profile.IsPressed)
            {
                if (!_profile.IsHot)
                {
                    _profile.IsHot = true;
                    Invalidate();
                }
            }
            else
            {
                if (_profile.IsHot)
                {
                    _profile.IsHot = false;
                    Invalidate();
                }

            }
      

        }

       
        // in your code
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            // 
            // Close 
            //
            if (_close.Rect.Contains(e.Location) && _close.IsPressed)
            {
                WinUserH.PostMessage(this.Parent.Handle, WinUserH.WM_CLOSE, IntPtr.Zero, IntPtr.Zero);

            }
            _close.IsPressed = false;
            _close.IsHot = false;

            //
            // Max
            //
            if (_max.Rect.Contains(e.Location) && _max.IsPressed)
            {
                var form = FindForm();
                if ((form?.WindowState) == FormWindowState.Maximized)
                {
                    WinUserH.ShowWindow(form.Handle, WinUserH.SW_RESTORE);
                }
                else
                {
                    WinUserH.ShowWindow(form.Handle, WinUserH.SW_MAXIMIZE);
                }

            }

            _max.IsPressed = false;
            _max.IsHot = false;                  

            //
            // Min
            //
            if (_min.Rect.Contains(e.Location) && _min.IsPressed)
            {
                var handle = FindForm()?.Handle;

                if (handle is not null)
                    WinUserH.ShowWindow((IntPtr)handle, WinUserH.SW_MINIMIZE);
            }
            _min.IsPressed = false;
            _min.IsHot = false;

            //
            // Profile
            //
            if (_profile.Rect.Contains(e.Location) && _profile.IsPressed)
            {
                // TODO: Do something. 
             
            }
            _profile.IsPressed = false;
            _profile.IsHot = false;

            //
            // Menu
            //
            if (_hamburgerMenuFeature)
            {
                if (_menu.Rect.Contains(e.Location) && _menu.IsPressed)
                {
                    // TODO: Do something. 
                    OnMenuClicked?.Invoke(this, new EventArgs());

                }
                _menu.IsPressed = false;
                _menu.IsHot = false;
            }

            // Done

            Invalidate();
        }


        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            //
            // Menu
            //

            if (_hamburgerMenuFeature)
            {
                if (_menu.Rect.Contains(e.Location))
                {
                    _menu.IsPressed = true;
                    _menu.IsHot = true;
                    Invalidate();
                    return;
                }
            }
            //
            // Close
            //
            if (_close.Rect.Contains(e.Location))
            {
                _close.IsPressed = true;
                _close.IsHot = true;
                Invalidate();
                return;
            }
            //
            // Max
            // 
            if (_max.Rect.Contains(e.Location))
            {
                _max.IsPressed = true;
                _max.IsHot = true;
                Invalidate();
                Console.WriteLine("_max.IsPressed");
                return;
            }

            //
            // Min
            //
            if (_min.Rect.Contains(e.Location))
            {
                _min.IsPressed = true;
                _min.IsHot = true;
                Invalidate();
                return;
            }
            //
            // Profile
            //
            if (_profile.Rect.Contains(e.Location))
            {
                _profile.IsPressed = true;
                _profile.IsHot = true;
                Invalidate();
                return;
            }
        }

        #endregion

        #region Paint Region

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            var rect = ClientRectangle;

            // Fill body
            if (IsAcrylic )
            {
                e.Graphics.Clear(Color.Transparent);
            }
            else
            {
                e.Graphics.Clear(Colors.GreyBackground);
                //using (var b = new SolidBrush(Colors.GreyBackground))
                //{
                //    g.FillRectangle(b, rect);
                //}
            }

            // Draw header
            var bgColor = ContainsFocus ? Colors.BlueBackground : Colors.HeaderBackground;
            var darkColor = ContainsFocus ? Colors.DarkBlueBorder : Colors.DarkBorder;
            var lightColor = ContainsFocus ? Colors.LightBlueBorder : Colors.LightBorder;

            if (_hasRoundCorners is false)
            {
                using (var b = new SolidBrush(bgColor))
                {
                    var bgRect = new Rectangle(0, 0, rect.Width, Scale(Consts.CONTROL_HEIGHT));
                    g.FillRectangle(b, bgRect);
                }

                using (var p = new Pen(darkColor))
                {
                    g.DrawLine(p, rect.Left, 0, rect.Right, 0);
                    g.DrawLine(p,
                        rect.Left, Scale(Consts.CONTROL_HEIGHT) - Scale(Consts.PEN_WIDTH),
                        rect.Right, Scale(Consts.CONTROL_HEIGHT) - Scale(Consts.PEN_WIDTH));
                }

                using (var p = new Pen(lightColor))
                {
                    g.DrawLine(p,
                        rect.Left, Scale(Consts.PEN_WIDTH),
                        rect.Right, Scale(Consts.PEN_WIDTH));
                }
            }


            // Draw Section Header
            //  var xMenuButtonOffset = Scale(CONTROL_BUTTON_PADDING * 2);
            //var xMenuButtonOffset = Scale(CONTROL_BUTTON_PADDING * 2 );

            int xMenuButtonOffset = 0;

            if (_hamburgerMenuFeature)
            {
                xMenuButtonOffset = Scale(Consts.CONTROL_BUTTON_PADDING) + Scale(Consts.CONTROL_BUTTON_XOFFSET);
                //
                // Hamburger Menu button
                //
                var menuImg = _menu.IsHot ? _menu.IconHot : _menu.Icon;
                g.DrawImage(menuImg, _menu.Rect.Left + xMenuButtonOffset, _menu.Rect.Top);
            }

            var xOffset = xMenuButtonOffset + _menu.Rect.Width + Scale(Consts.CONTROL_BUTTON_PADDING * 3);

            if (_icon is not null)
            {
                // Draw Icon
                var iconRect = new Rectangle
                {
                    X = ClientRectangle.Left + xOffset,
                    Y = ClientRectangle.Top + (Scale(Consts.CONTROL_HEIGHT) / 2) - (_icon.Height / 2),
                    Width = _icon.Width,
                    Height = _icon.Height
                };


                g.DrawImage(_icon, iconRect);


                xOffset += _icon.Width + Consts.CONTROL_BUTTON_XOFFSET;
            }
            // Draw Text Title 

            using (var b = new SolidBrush(Colors.LightText))
            {
                var textRect = new Rectangle(xOffset, 0, rect.Width - Scale(Consts.CONTROL_BUTTON_XOFFSET_PLUS_PEN) - xOffset, Scale(Consts.CONTROL_HEIGHT));

                var format = new StringFormat
                {
                    Alignment = StringAlignment.Near,
                    LineAlignment = StringAlignment.Center,
                    FormatFlags = StringFormatFlags.NoWrap,
                    Trimming = StringTrimming.EllipsisCharacter
                };

                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                g.DrawString(SectionHeader, Font, b, textRect, format);
            }


            // Draw border
            /*
            if (_isAcrylicEnabled)
            {
                Console.WriteLine($"Drawing Border {rect.Width} {rect.Height}");
                using (var p = new Pen(Colors.DarkBorder, Scale(PEN_WIDTH)))
                {
                    var modRect = new Rectangle(rect.Left, rect.Top,
                                         rect.Width - Scale(PEN_WIDTH),
                                         rect.Height - Scale(PEN_WIDTH));

                    if (_hasRoundCorners)
                    {
                        using (GraphicsPath border = Drawing.RoundedRectange(modRect, Scale(ARC_RADIUS)))
                        {
                            g.DrawPath(p, border);
                        }
                    }
                    else
                    {
                        g.DrawRectangle(p, modRect);
                    }
                }
            }*/

            //
            // Min button
            //
            var minImg = _min.IsHot ? _min.IconHot : _min.Icon;
            g.DrawImage(minImg, _min.Rect.Left, _min.Rect.Top);

            //
            // Max button
            //
            var maxImg = _max.IsHot ? _max.IconHot : _max.Icon;
            g.DrawImage(maxImg, _max.Rect.Left, _max.Rect.Top);


            //
            // Close button
            //
            var closeImg = _close.IsHot ? _close.IconHot : _close.Icon;
            g.DrawImage(closeImg, _close.Rect.Left, _close.Rect.Top);


            if (_profileFeature)
            {
                //
                // Profile button
                //
                var profileImg = _profile.IsHot ? _profile.IconHot : _profile.Icon;
                g.DrawImage(profileImg, _profile.Rect.Left, _profile.Rect.Top);
            }          
        }

        //public static GraphicsPath RoundedRectange(Rectangle modRect, int radius)
        //{
        //    int d = radius * 2;
        //    Size size = new Size(d, d);
        //    Rectangle arc = new Rectangle(modRect.Location, size);
        //    GraphicsPath path = new();
        //    if (radius == 0)
        //    {
        //        path.AddRectangle(modRect);
        //        return path;
        //    }
        //    // top left arc
        //    path.AddArc(arc, 180, 90);

        //    // top righ arc
        //    arc.X = modRect.Right - d;
        //    path.AddArc(arc, 270, 90);

        //    // bottom right arc
        //    arc.Y = modRect.Bottom - d;
        //    path.AddArc(arc, 0, 90);

        //    //bottom left arc
        //    arc.X = modRect.Left;
        //    path.AddArc(arc, 90, 90);

        //    path.CloseFigure();
        
        //    return path;
        //}

        protected override void OnPaintBackground(PaintEventArgs e)
        {
         
            // Absorb event
        }



        #endregion

        #region Win32 Hacks

        private int _showSnapOverlay;
        private bool _isAcrylic;

        protected override void WndProc(ref Message message)
        {
#if SKIP
            switch (message.Msg)
            {
                case WinUserH.WM_NCHITTEST:
                    //Console.WriteLine($"WinUserH.WM_NCHITTEST:  { message.LParam}");
                    break;
                case 13:
                    Console.WriteLine($"WinUserH.WM_GETTEXT:  { message.LParam}");
                    break;
               case 14:
                    Console.WriteLine($"WinUserH.WM_GETTEXTLENGTH:  { message.LParam}");
                    break;
                case 15:
                    Console.WriteLine($"WinUserH.WM_PAINT:  { message.LParam}");
                    break;
                case 20:
                    Console.WriteLine($"WinUserH.WM_ERASEBKGND:  { message.LParam}");
                    break;
                case 32:
                    Console.WriteLine($"WinUserH.WM_SETCURSOR:  { message.LParam}");
                    break;
                case 512:
                    Console.WriteLine($"WinUserH.WM_MOUSEFIRST:  { message.LParam}");
                    break;
                case 673:
                    Console.WriteLine($"WinUserH.WM_MOUSEHOVER:  { message.LParam}");
                    break;
                default:
                    Console.WriteLine($"{message.Msg}");
                    break;
            }

#endif
            if (_showSnapOverlay > 100) _showSnapOverlay = 0;

            // Don't Process a Hit Test, Allow Underlying Windows to Process
            if (message.Msg == WinUserH.WM_NCHITTEST)
            {                
                base.WndProc(ref message);

                if ((int)message.Result == WinUserH.HT_CLIENT)
                {
                    var cursor = this.PointToClient(Cursor.Position);                  

                    if (IsControlBoxHit(cursor))
                    {
                        if (_max.IsPressed) _showSnapOverlay = 0;
                        if (_max.IsHot && _showSnapOverlay++ > 30)
                        {
                            message.Result = (IntPtr)(WinUserH.HT_MAXBUTTON);
                            //Console.WriteLine($"SENT--> HT_MAXBUTTON {_showSnapOverlay}");
                        }


                        return;
                    }
                    _showSnapOverlay = 0;
                    message.Result = (IntPtr)(WinUserH.HT_TRANSPARENT);

                }
            }

            else base.WndProc(ref message);
        }

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private bool IsControlBoxHit(Point cursor)
        {
            bool absorbHit = false;

            absorbHit |= _min.Rect.Contains(cursor);
            absorbHit |= _min.IsHot;
            absorbHit |= _max.Rect.Contains(cursor);
            absorbHit |= _max.IsHot;
            absorbHit |= _close.Rect.Contains(cursor);
            absorbHit |= _close.IsHot;
            absorbHit |= _profile.Rect.Contains(cursor);
            absorbHit |= _profile.IsHot;

            if (HamburgerMenuFeature)
            {
                absorbHit |= _menu.Rect.Contains(cursor);
                absorbHit |= _menu.IsHot;
            }
            return absorbHit;
        }

        public static void CheckResizeClientAreaHit(Size clientSize, ref Message message, Point cursor)
        {
            // resize client area                       
            if (clientSize.TopLeft().Contains(cursor))
                message.Result = WinUserH.HT_TOPLEFT;
            else if (clientSize.TopRight().Contains(cursor))
                message.Result = WinUserH.HT_TOPRIGHT;
            else if (clientSize.BottomLeft().Contains(cursor))
                message.Result = WinUserH.HT_BOTTOMLEFT;
            else if (clientSize.BottomRight().Contains(cursor))
                message.Result = WinUserH.HT_BOTTOMRIGHT;
            else if (clientSize.Top().Contains(cursor))
                message.Result = WinUserH.HT_TOP;
            else if (clientSize.Left().Contains(cursor))
                message.Result = WinUserH.HT_LEFT;
            else if (clientSize.Right().Contains(cursor))
                message.Result = WinUserH.HT_RIGHT;
            else if (clientSize.Bottom().Contains(cursor))
                message.Result = WinUserH.HT_BOTTOM;
        }

        [DllImport("user32.dll")]
        private static extern uint GetDpiForWindow(IntPtr hwnd);

        #endregion
    }
}
