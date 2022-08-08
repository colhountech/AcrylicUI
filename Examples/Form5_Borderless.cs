using AcrylicUI;
using AcrylicUI.Controls;
using AcrylicUI.Platform.Windows;
using AcrylicUI.Resources;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace Examples
{
    public partial class Form5_Borderless : AcrylicUI.Forms.AcrylicForm
    {

        #region Fields for Borderless Windows
        private int borderSize = 0;
        private bool _flatBorder = true;
        private Size _restoreSize;
        #endregion


        public Form5_Borderless()
        {
            InitializeComponent();
            // Make sure you set this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // Program.cs : Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            SetupUIDefaults();
            HookEvents();
            RoundCorners(IsWindowsCreatorOrLater());

            this.acrylicGlassPanel3.BackColor = Colors.AcrylicInnerPanel;
            this.acrylicGlassPanel3.ForeColor = Colors.AcrylicHairline;







        }

        #region fix FormWindowState changes


        private void SetupUIDefaults()
        {
            // Don't change this: NoBorder with Resize Hack
            var designSize = this.ClientSize;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Size = designSize;
            this._restoreSize = designSize; // save for restore
            this.windowPanel1.ProfileFeature = false;
            this.windowPanel1.IsAcrylic = true;
            this.BlurOpacity = 10;
            this.BackColor = AcrylicUI.Resources.Colors.GreyBackground;

        }

        public bool IsWindowsCreatorOrLater()
        {
            // Create a reference to the OS version of Windows 10 Creators Update.
            Version OsMinVersion = new Version(10, 0, 15063, 0);

            // Compare the current version to the minimum required version.
            var compatible = Environment.OSVersion.Version.CompareTo(OsMinVersion);
            Console.WriteLine($"{Environment.OSVersion.VersionString}: Compat: {compatible}");

            return compatible == 1;
        }
        private void HookEvents()
        {
            this.Load += new System.EventHandler(this.MainWindow_Load);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var dpiScale = IconFactory.GetDpiScale(this.Handle);
            this.windowPanel1.Icon = new IconFactory(IconFactory.GetDpiScale(Handle)).BitmapFromSvg(Icons.Cube_16x_svg);
            this.windowPanel1.SectionHeader = "CT Studio";
            this.windowPanel1.OnMenuClicked += WindowPanel1_OnMenuClicked;
        }

        private void WindowPanel1_OnMenuClicked(object sender, EventArgs e)
        {
            lblStatus.Text = "Menu Was Clicked";
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
            base.OnResize(e);
            AdjustForm();
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

        #region Windows AcrylicTheme Hack

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Win32Hacks.DarkThemeTitleBar(this.Handle);
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


        private void RoundCorners(bool _isWindows11)
        {
            if (_isWindows11)
            {
                var attribute = DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE;
                var preference = DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUND;
                DwmSetWindowAttribute(this.Handle, attribute, ref preference, sizeof(uint));
            }
            this.windowPanel1.RoundCorners = _isWindows11;
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
