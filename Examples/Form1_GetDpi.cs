using AcrylicUI;
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

namespace Examples
{
    public partial class Form1_GetDpi : AcrylicUI.Forms.AcrylicForm
    {

        public Form1_GetDpi()
        {

            InitializeComponent();
            // Make sure you set AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // Program.cs : Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);

            Text = string.Empty;
            ShowIcon = false;
            BackColor = Colors.GreyBackground;
            MinimumSize = Size;
            grpDpiSettings.BorderColor = Colors.BtnOutline;
            grpDpiSettings.BackColor = Colors.Transparent;
            grpDpiSettings.ForeColor = Colors.Text;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
          
            // Create a reference to the OS version of Windows 10 Creators Update.
            Version OsMinVersion = new Version(10, 0, 15063, 0);

            // Compare the current version to the minimum required version.
            var compatible = Environment.OSVersion.Version.CompareTo(OsMinVersion);
            txtWinVer.Text = $"{Environment.OSVersion.VersionString}: Compat: {compatible}";
        }

        protected override void OnResize(EventArgs e)
        {
            SuspendLayout();
            base.OnResize(e);
            ScaleText();

            ResumeLayout();           
        }

        private void ScaleText()
        {
            if (txtSystemDpi != null)
            {
                txtSystemDpi.Text = $"{DeviceDpi}";
                var scale = (float)Drawing.GetDpi(Handle) / (float)96f;
                txtAutoScaleFactor.Text = scale.ToString();
            }         
        }


    }
}
