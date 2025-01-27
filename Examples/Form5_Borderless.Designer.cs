
using AcrylicUI.Resources;

namespace Examples
{
    partial class Form5_Borderless
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
            windowPanel1 = new AcrylicUI.Controls.WindowPanel();
            acrylicGlassPanel2 = new AcrylicUI.Controls.AcrylicGlassPanel();
            acrylicGlassPanel3 = new AcrylicUI.Controls.AcrylicGlassPanel();
            acrylicGlassPanel1 = new AcrylicUI.Controls.AcrylicGlassPanel();
            acrylicStatusStrip1 = new AcrylicUI.Controls.AcrylicStatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            windowPanel1.SuspendLayout();
            acrylicStatusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // windowPanel1
            // 
            windowPanel1.Controls.Add(acrylicStatusStrip1);
            windowPanel1.Controls.Add(acrylicGlassPanel2);
            windowPanel1.Controls.Add(acrylicGlassPanel3);
            windowPanel1.Controls.Add(acrylicGlassPanel1);
            windowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            windowPanel1.Icon = null;
            windowPanel1.Location = new System.Drawing.Point(0, 0);
            windowPanel1.Name = "windowPanel1";
            windowPanel1.RoundCorners = false;
            windowPanel1.SectionHeader = null;
            windowPanel1.Size = new System.Drawing.Size(418, 450);
            windowPanel1.TabIndex = 0;
            // 
            // acrylicGlassPanel2
            // 
            acrylicGlassPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            acrylicGlassPanel2.BackColor = System.Drawing.Color.FromArgb(40, 88, 88, 88);
            acrylicGlassPanel2.ForeColor = System.Drawing.Color.FromArgb(99, 99, 99, 99);
            acrylicGlassPanel2.Location = new System.Drawing.Point(35, 222);
            acrylicGlassPanel2.Margin = new System.Windows.Forms.Padding(2);
            acrylicGlassPanel2.Name = "acrylicGlassPanel2";
            acrylicGlassPanel2.Size = new System.Drawing.Size(330, 150);
            acrylicGlassPanel2.TabIndex = 4;
            // 
            // acrylicGlassPanel3
            // 
            acrylicGlassPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            acrylicGlassPanel3.BackColor = System.Drawing.Color.FromArgb(40, 88, 88, 88);
            acrylicGlassPanel3.ForeColor = System.Drawing.Color.FromArgb(99, 99, 99, 99);
            acrylicGlassPanel3.HasRoundedCorners = true;
            acrylicGlassPanel3.Location = new System.Drawing.Point(54, 81);
            acrylicGlassPanel3.Margin = new System.Windows.Forms.Padding(2);
            acrylicGlassPanel3.Name = "acrylicGlassPanel3";
            acrylicGlassPanel3.Size = new System.Drawing.Size(294, 61);
            acrylicGlassPanel3.TabIndex = 2;
            // 
            // acrylicGlassPanel1
            // 
            acrylicGlassPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            acrylicGlassPanel1.BackColor = System.Drawing.Color.FromArgb(40, 88, 88, 88);
            acrylicGlassPanel1.ForeColor = System.Drawing.Color.FromArgb(99, 99, 99, 99);
            acrylicGlassPanel1.Location = new System.Drawing.Point(35, 61);
            acrylicGlassPanel1.Margin = new System.Windows.Forms.Padding(2);
            acrylicGlassPanel1.Name = "acrylicGlassPanel1";
            acrylicGlassPanel1.Size = new System.Drawing.Size(330, 150);
            acrylicGlassPanel1.TabIndex = 3;
            // 
            // acrylicStatusStrip1
            // 
            acrylicStatusStrip1.AutoSize = false;
            acrylicStatusStrip1.BackColor = System.Drawing.Color.FromArgb(31, 31, 31);
            acrylicStatusStrip1.ForeColor = System.Drawing.Color.FromArgb(192, 192, 192);
            acrylicStatusStrip1.IsAcrylicEnabled = false;
            acrylicStatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel1 });
            acrylicStatusStrip1.Location = new System.Drawing.Point(1, 425);
            acrylicStatusStrip1.Name = "acrylicStatusStrip1";
            acrylicStatusStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            acrylicStatusStrip1.Size = new System.Drawing.Size(416, 24);
            acrylicStatusStrip1.SizingGrip = false;
            acrylicStatusStrip1.TabIndex = 5;
            acrylicStatusStrip1.Text = "Ready";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(118, 11);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form5_Borderless
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(418, 450);
            Controls.Add(windowPanel1);
            Location = new System.Drawing.Point(0, 0);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "Form5_Borderless";
            Text = "Form5";
            windowPanel1.ResumeLayout(false);
            acrylicStatusStrip1.ResumeLayout(false);
            acrylicStatusStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AcrylicUI.Controls.WindowPanel windowPanel1;
        private AcrylicUI.Controls.AcrylicGlassPanel acrylicGlassPanel3;
        private AcrylicUI.Controls.AcrylicGlassPanel acrylicGlassPanel2;
        private AcrylicUI.Controls.AcrylicGlassPanel acrylicGlassPanel1;
        private AcrylicUI.Controls.AcrylicStatusStrip acrylicStatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}