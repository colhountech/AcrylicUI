using AcrylicUI;
using AcrylicUI.Controls;
using AcrylicUI.Resources;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Examples
{
    public partial class Form8_Blank 
    {
        #region Fields for Borderless Windows
        private int borderSize = 2;
        private bool _flatBorder = true;
        private Size _restoreSize;
        #endregion

        #region fix FormWindowState changes


        private void SetupUIDefaults()
        {
            // turn off transparency for now

            this.IsAcrylic = false;
            this.windowPanel1.IsAcrylic = false;
            // color defaults
            // Panel Background
            //this.BackColor = Colors.GreyBackground;
            //this.windowPanel1.BackColor = Color.Red;
            //this.BlurColor = Color.Green;
            // innerPanel
            //panel1.BackColor = Colors.GreyBackground;
            


            // Windows 11 Hack
            RoundCorners();

            // Don't change this: NoBorder with Resize Hack
            var designSize = this.ClientSize;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Size = designSize;
            this._restoreSize = designSize; // save for restore

        }

     

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            _restoreSize = ClientSize;
            this.WindowState = (this.WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal);
            AdjustForm();
        }

        #endregion

        #region Min/Max/Restore for catching resize events to adjust form

        private void BtnMin_Click(object sender, EventArgs e)
        {
            _restoreSize = ClientSize;
            this.WindowState = FormWindowState.Minimized;
            AdjustForm();
        }

        protected override void OnResize(EventArgs e)
        {
            
            AdjustForm();
            base.OnResize(e);
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 8);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)                    
                        this.Padding = new Padding(borderSize);                    
                    break;
            }
        }



        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Clicks == 2) // DoubleClick
            {
                BtnMaximize_Click(this, e);
            }
            else
            {
                WinProcExtentsions.TitleBarHit(Handle);
            }
        }


        #endregion

        #region Window, No Border Hacks

        protected override void WndProc(ref Message message)
        {
            // Resize Window
            if (message.Msg == WinUserH.WM_NCHITTEST)
            {
                base.WndProc(ref message);

                if (this.WindowState == FormWindowState.Normal)
                {
                    if ((int)message.Result == WinUserH.HT_CLIENT)
                    {
                        var cursor = this.PointToClient(Cursor.Position);
                        WindowPanel.CheckResizeClientAreaHit(this.ClientSize, ref message, cursor);
                    }
                }
                return;
            }

            // Remove border and keep snap window
            if (message.Msg == WinUserH.WM_NCCALCSIZE && message.WParam.ToInt32() == 1)
            {
                return;
            }

            // Keep form size when it is minimized and restored.            
            if (message.Msg == WinUserH.WM_SYSCOMMAND)
            {
                int wParam = (message.WParam.ToInt32() & 0xFFF0);
                if (wParam == WinUserH.SC_MINIMIZE)
                {
                    //save client size
                    _restoreSize = this.ClientSize;
                }
                if (wParam == WinUserH.SC_RESTORE)
                {
                    // restore client size
                    this.Size = _restoreSize;
                }
            }

            base.WndProc(ref message);
        }



        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            if (!_flatBorder)
                return;

            var g = e.Graphics;

            using (var p = new Pen(Colors.DarkBorder))
            {
                var modRect = new Rectangle(ClientRectangle.Location, new Size(ClientRectangle.Width - 1, ClientRectangle.Height - 1));
                g.DrawRectangle(p, modRect);
            }
        }

        [DllImport("user32.dll")]
        private static extern uint GetDpiForWindow(IntPtr hwnd);

        /// <summary>
        /// Add DropShadow to top level windows
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }


        #endregion

        #region Round Corners

     

        private void RoundCorners()
        {
            bool isWindows11 = IsWindows11OrGreater();

            if (isWindows11)
            {
                var attribute = DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE;
                var preference = DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUND;
                DwmSetWindowAttribute(this.Handle, attribute, ref preference, sizeof(uint));
            }
            this.windowPanel1.RoundCorners = isWindows11;
        }

        private bool IsWindows11OrGreater()
        {

            // Create a reference to the OS version of Windows 11
            Version Os11Version = new Version(10, 0, 22000, 0);

            // Compare the current version to the minimum required version.
            var compatible = Environment.OSVersion.Version.CompareTo(Os11Version);  // 0 

            return compatible >= 0;
        }

        public enum DWMWINDOWATTRIBUTE
        {
            DWMWA_WINDOW_CORNER_PREFERENCE = 33
        }

        // The DWM_WINDOW_CORNER_PREFERENCE enum for DwmSetWindowAttribute's third parameter, which tells the function
        // what value of the enum to set.
        public enum DWM_WINDOW_CORNER_PREFERENCE
        {
            DWMWCP_DEFAULT = 0,
            DWMWCP_DONOTROUND = 1,
            DWMWCP_ROUND = 2,
            DWMWCP_ROUNDSMALL = 3
        }

        // Import dwmapi.dll and define DwmSetWindowAttribute in C# corresponding to the native function.
        [DllImport("dwmapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern long DwmSetWindowAttribute(IntPtr hwnd,
                                                         DWMWINDOWATTRIBUTE attribute,
                                                         ref DWM_WINDOW_CORNER_PREFERENCE pvAttribute,
                                                         uint cbAttribute);

        #endregion
    }
}
