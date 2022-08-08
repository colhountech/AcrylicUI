
using AcrylicUI.Controls;
using AcrylicUI.Docking;

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
            this.pnlTask = new AcrylicUI.Controls.WindowPanel();
            this.pnlInner = new System.Windows.Forms.Panel();
            this.DockPanel = new AcrylicUI.Docking.DockPanel();
            this.inboxControl = new AcrylicUI.Controls.BoxControl();
            this.outboxControl = new AcrylicUI.Controls.BoxControl();
            this.toolTaskSettings = new AcrylicUI.Controls.BoxControl();
            this.pnlTask.SuspendLayout();
            this.pnlInner.SuspendLayout();
            this.DockPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTask
            // 
            this.pnlTask.Controls.Add(this.pnlInner);
            this.pnlTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTask.Icon = null;
            this.pnlTask.IsAcrylic = false;
            this.pnlTask.Location = new System.Drawing.Point(0, 0);
            this.pnlTask.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTask.Name = "pnlTask";
            this.pnlTask.RoundCorners = false;
            this.pnlTask.SectionHeader = null;
            this.pnlTask.Size = new System.Drawing.Size(800, 450);
            this.pnlTask.TabIndex = 0;
            this.pnlTask.TabStop = false;
            // 
            // pnlInner
            // 
            this.pnlInner.Controls.Add(this.DockPanel);
            this.pnlInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInner.Location = new System.Drawing.Point(1, 25);
            this.pnlInner.Margin = new System.Windows.Forms.Padding(0);
            this.pnlInner.Name = "pnlInner";
            this.pnlInner.Padding = new System.Windows.Forms.Padding(1, 25, 1, 1);
            this.pnlInner.Size = new System.Drawing.Size(818, 409);
            this.pnlInner.TabIndex = 0;
            this.pnlInner.TabStop = false;            
            // 
            // DockPanel
            // 
            this.DockPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.DockPanel.Controls.Add(this.inboxControl);
            this.DockPanel.Controls.Add(this.outboxControl);
            this.DockPanel.Controls.Add(this.toolTaskSettings);
            this.DockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DockPanel.Location = new System.Drawing.Point(1, 25);
            this.DockPanel.Name = "DockPanel";
            this.DockPanel.Size = new System.Drawing.Size(816, 383);
            this.DockPanel.TabIndex = 0;
            
            // 
            // inboxControl
            // 
            this.inboxControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.inboxControl.DefaultDockArea = AcrylicUI.Docking.DockArea.Left;
            this.inboxControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.inboxControl.DockText = "Inbox Control";
            this.inboxControl.Icon = null;
            this.inboxControl.Location = new System.Drawing.Point(0, 0);
            this.inboxControl.Name = "inboxControl";
            this.inboxControl.SerializationKey = null;
            this.inboxControl.Size = new System.Drawing.Size(150, 383);
            this.inboxControl.TabIndex = 0;
            // 
            // outboxControl
            // 
            this.outboxControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.outboxControl.DefaultDockArea = AcrylicUI.Docking.DockArea.Right;
            this.outboxControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.outboxControl.DockText = "Outbox Control";
            this.outboxControl.Icon = null;
            this.outboxControl.Location = new System.Drawing.Point(666, 0);
            this.outboxControl.Name = "outboxControl";
            this.outboxControl.SerializationKey = null;
            this.outboxControl.Size = new System.Drawing.Size(150, 383);
            this.outboxControl.TabIndex = 1;
            // 
            // toolTaskSettings
            // 
            this.toolTaskSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolTaskSettings.DefaultDockArea = AcrylicUI.Docking.DockArea.Bottom;
            this.toolTaskSettings.DockText = "Task Settings";
            this.toolTaskSettings.Icon = null;
            this.toolTaskSettings.Location = new System.Drawing.Point(155, 275);
            this.toolTaskSettings.Name = "toolTaskSettings";
            this.toolTaskSettings.SerializationKey = null;
            this.toolTaskSettings.Size = new System.Drawing.Size(500, 133);
            this.toolTaskSettings.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(820, 435);
            this.Controls.Add(this.pnlTask);
            this.Location = new System.Drawing.Point(0, 0);
            this.DoubleBuffered = true;
            this.Name = "Form5";
            this.Text = "Form5";
            this.pnlTask.ResumeLayout(false);
            this.pnlInner.ResumeLayout(false);
            this.DockPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AcrylicUI.Controls.WindowPanel pnlTask;
        private System.Windows.Forms.Panel pnlInner;
        private AcrylicUI.Controls.BoxControl outboxControl;
        private AcrylicUI.Controls.BoxControl inboxControl;
        private AcrylicUI.Controls.BoxControl toolTaskSettings;
        private AcrylicUI.Docking.DockPanel DockPanel;
    }
}