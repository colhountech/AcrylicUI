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
    public partial class Form1 : AcrylicUI.Forms.AcrylicForm
    {

        public Form1()
        {

            InitializeComponent();
            // Make sure you set this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // Program.cs : Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);

            this.Text = string.Empty;
            this.ShowIcon = false;
            this.btnUpdateDpi.Default = false; // change this to true for a more prominent button


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BtnUpdateDpi_Click(this, null);
        }



        private void BtnUpdateDpi_Click(object sender, EventArgs e)
        {
            txtDpi.Text = String.Empty;
            txtAutoScaleFactor.Text = string.Empty;

            // Create a reference to the OS version of Windows 10 Creators Update.
            Version OsMinVersion = new Version(10, 0, 15063, 0);

            // Compare the current version to the minimum required version.
            var compatible = Environment.OSVersion.Version.CompareTo(OsMinVersion);
            txtWinVer.Text = $"{Environment.OSVersion.VersionString}: Compat: {compatible}";

            txtDpi.Text = $"{this.DeviceDpi}";

            var scale = (float)Drawing.GetDpi(this.Handle) / (float)96f;

            txtAutoScaleFactor.Text = scale.ToString();
        }

    }
}
