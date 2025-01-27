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
            // Make sure you set AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // Program.cs : Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);

            SetupUIDefaults();

            // Add the dock panel message filter to filter through for dock panel splitter
            // input before letting events pass through to the rest of the application.
            Application.AddMessageFilter(DockPanel.DockResizeFilter);


            

            // Tool Tasks
            toolTaskSettings.DefaultDockArea = DockArea.Bottom;
            
            // Inbox
            inboxControl.DefaultDockArea = DockArea.Left;

            // Outbox
            outboxControl.DefaultDockArea = DockArea.Right;

            DockPanel.AddContent(toolTaskSettings);    // The order added sets the tab order
            DockPanel.AddContent(outboxControl);
            DockPanel.AddContent(inboxControl);        // Active Control
            var doc1 = new Document();
            doc1.DockText = "Document 1";
            DockPanel.AddContent(doc1);

            var doc2 = new Document();
            doc2.DockText = "Document 2";
            DockPanel.AddContent(doc2);

            var doc3 = new Document();
            doc3.DockText = "Document 3";
            DockPanel.AddContent(doc3);


            var doc4 = new Document();
            doc4.DockText = "Document 4";
            DockPanel.AddContent(doc4);



            HookEvents();


        }

        private void SetupUIDefaults()
        {
            // Colors
            IsAcrylic = false;
            pnlTask.IsAcrylic = false;
            BackColor = Colors.MontereyPanel;
            DockPanel.BackColor = Colors.MontereyDark;


            // Windows 11 Hack
            RoundCorners();

            // Don't change this: NoBorder with Resize Hack
            var designSize = ClientSize;
            FormBorderStyle = FormBorderStyle.Sizable;
            Size = designSize;
            _restoreSize = designSize; // save for restore

        }

        private void HookEvents()
        {
            Load += new System.EventHandler(MainWindow_Load);

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var dpiScale = IconFactory.GetDpiScale(Handle);
            pnlTask.Icon = new IconFactory(IconFactory.GetDpiScale(Handle)).BitmapFromSvg(Icons.Cube_16x_svg);
            pnlTask.SectionHeader = "";
            mnuMain.Location = new System.Drawing.Point(36, 3); // Overlay Menu on Top Control Bar
        }


    }
}
