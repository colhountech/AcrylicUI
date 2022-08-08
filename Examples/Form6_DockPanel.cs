using AcrylicUI;
using AcrylicUI.Controls;
using AcrylicUI.Docking;
using AcrylicUI.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples
{
    public partial class Form6_DockPanel : AcrylicUI.Forms.AcrylicForm
    {

        #region Fields for Borderless Windows
        private readonly int borderSize = 2;
        private readonly bool _flatBorder = true;
        private Size _restoreSize;
        #endregion


        public Form6_DockPanel()
        {
            InitializeComponent();
            // Make sure you set this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // Program.cs : Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);

            SetupUIDefaults();

            // Add the dock panel message filter to filter through for dock panel splitter
            // input before letting events pass through to the rest of the application.
            Application.AddMessageFilter(DockPanel.DockResizeFilter);


            

            // Tool Tasks
            this.toolTaskSettings.DefaultDockArea = DockArea.Bottom;
            
            // Inbox
            this.inboxControl.DefaultDockArea = DockArea.Left;

            // Outbox
            this.outboxControl.DefaultDockArea = DockArea.Right;

            DockPanel.AddContent(this.toolTaskSettings);    // The order added sets the tab order
            DockPanel.AddContent(this.outboxControl);
            DockPanel.AddContent(this.inboxControl);        // Active Control

            HookEvents();


        }

        private void SetupUIDefaults()
        {
            // Colors
            this.IsAcrylic = false;
            this.pnlTask.IsAcrylic = false;
            this.BackColor = Colors.MontereyPanel;

            // Windows 11 Hack
            RoundCorners();

            // Don't change this: NoBorder with Resize Hack
            var designSize = this.ClientSize;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Size = designSize;
            this._restoreSize = designSize; // save for restore

        }

        private void HookEvents()
        {
            this.Load += new System.EventHandler(this.MainWindow_Load);

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var dpiScale = IconFactory.GetDpiScale(this.Handle);
            this.pnlTask.Icon = new IconFactory(IconFactory.GetDpiScale(Handle)).BitmapFromSvg(Icons.Cube_16x_svg);
            this.pnlTask.SectionHeader = "CT Studio";
        }


    }
}
