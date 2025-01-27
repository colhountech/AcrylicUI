
using AcrylicUI.Controls;
using AcrylicUI.Docking;
using AcrylicUI.Resources;

namespace Examples
{
    partial class Form6_DockPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTask = new AcrylicUI.Controls.WindowPanel();
            pnlInner = new System.Windows.Forms.Panel();
            DockPanel = new AcrylicUI.Docking.DockPanel();
            inboxControl = new AcrylicUI.Controls.BoxControl();
            outboxControl = new AcrylicUI.Controls.BoxControl();
            toolTaskSettings = new AcrylicUI.Controls.BoxControl();
            mnuMain = new AcrylicUI.Controls.AcrylicMenuStrip();
            mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();            
            pnlTask.SuspendLayout();
            pnlInner.SuspendLayout();
            DockPanel.SuspendLayout();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTask
            // 
            pnlTask.Controls.Add(mnuMain);
            pnlTask.Controls.Add(pnlInner);
            pnlTask.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlTask.Icon = null;
            pnlTask.IsAcrylic = false;
            pnlTask.Location = new System.Drawing.Point(0, 0);
            pnlTask.Margin = new System.Windows.Forms.Padding(0);
            pnlTask.Name = "pnlTask";
            pnlTask.RoundCorners = false;
            pnlTask.SectionHeader = null;
            pnlTask.Size = new System.Drawing.Size(820, 435);
            pnlTask.TabIndex = 0;
            // 
            // pnlInner
            // 
            pnlInner.Controls.Add(DockPanel);
            pnlInner.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlInner.Location = new System.Drawing.Point(1, 1);
            pnlInner.Margin = new System.Windows.Forms.Padding(0);
            pnlInner.Name = "pnlInner";
            //pnlInner.Padding = new System.Windows.Forms.Padding(1, 25, 1, 1);
            pnlInner.Size = new System.Drawing.Size(818, 398);
            pnlInner.TabIndex = 0;
            // 
            // DockPanel
            // 
            DockPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            DockPanel.Controls.Add(inboxControl);
            DockPanel.Controls.Add(outboxControl);
            DockPanel.Controls.Add(toolTaskSettings);
            DockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            DockPanel.Location = new System.Drawing.Point(1, 25);
            DockPanel.Name = "DockPanel";
            DockPanel.Size = new System.Drawing.Size(816, 383);
            DockPanel.TabIndex = 0;
            // 
            // inboxControl
            // 
            inboxControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            inboxControl.DefaultDockArea = AcrylicUI.Docking.DockArea.Left;
            inboxControl.Dock = System.Windows.Forms.DockStyle.Left;
            inboxControl.DockText = "Inbox Control";
            inboxControl.Icon = null;
            inboxControl.Location = new System.Drawing.Point(0, 0);
            inboxControl.Name = "inboxControl";
            inboxControl.SerializationKey = null;
            inboxControl.Size = new System.Drawing.Size(150, 383);
            inboxControl.TabIndex = 0;
            // 
            // outboxControl
            // 
            outboxControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            outboxControl.DefaultDockArea = AcrylicUI.Docking.DockArea.Right;
            outboxControl.Dock = System.Windows.Forms.DockStyle.Right;
            outboxControl.DockText = "Outbox Control";
            outboxControl.Icon = null;
            outboxControl.Location = new System.Drawing.Point(666, 0);
            outboxControl.Name = "outboxControl";
            outboxControl.SerializationKey = null;
            outboxControl.Size = new System.Drawing.Size(150, 383);
            outboxControl.TabIndex = 1;
            // 
            // toolTaskSettings
            // 
            toolTaskSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            toolTaskSettings.DefaultDockArea = AcrylicUI.Docking.DockArea.Bottom;
            toolTaskSettings.DockText = "Task Settings";
            toolTaskSettings.Icon = null;
            toolTaskSettings.Location = new System.Drawing.Point(155, 275);
            toolTaskSettings.Name = "toolTaskSettings";
            toolTaskSettings.SerializationKey = null;
            toolTaskSettings.Size = new System.Drawing.Size(500, 133);
            toolTaskSettings.TabIndex = 2;
            // 
            // mnuMain
            // 
            mnuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            mnuMain.Dock = System.Windows.Forms.DockStyle.None;
            mnuMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            mnuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            mnuFile});
            mnuMain.Name = "mnuMain";
            mnuMain.Padding = new System.Windows.Forms.Padding(4, 5, 0, 5);
            mnuMain.Size = new System.Drawing.Size(150, 29);
            mnuMain.TabIndex = 1;
            mnuMain.Text = "mnuMain";
            // 
            // mnuFile
            // 
            mnuFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            mnuFileExit});
            mnuFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new System.Drawing.Size(37, 19);
            mnuFile.Text = "&File";
            // 
            // mnuFileExit
            // 
            mnuFileExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            mnuFileExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            mnuFileExit.Name = "mnuFileExit";
            mnuFileExit.Size = new System.Drawing.Size(180, 22);
            mnuFileExit.Text = "E&xit";
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(820, 435);
            Controls.Add(pnlTask);
            Location = new System.Drawing.Point(0, 0);
            MainMenuStrip = mnuMain;
            Name = "Form6_DockPanel";
            Text = "Form5";
            pnlTask.ResumeLayout(false);
            pnlInner.ResumeLayout(false);
            DockPanel.ResumeLayout(false);
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private AcrylicUI.Controls.WindowPanel pnlTask;
        private System.Windows.Forms.Panel pnlInner;
        private AcrylicUI.Controls.AcrylicMenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private AcrylicUI.Controls.BoxControl outboxControl;
        private AcrylicUI.Controls.BoxControl inboxControl;
        private AcrylicUI.Controls.BoxControl toolTaskSettings;
        private AcrylicUI.Docking.DockPanel DockPanel;
    }
}