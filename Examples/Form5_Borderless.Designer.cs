
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
            this.windowPanel1 = new AcrylicUI.Controls.WindowPanel();
            this.acrylicGlassPanel2 = new AcrylicUI.Controls.AcrylicGlassPanel();
            this.acrylicGlassPanel3 = new AcrylicUI.Controls.AcrylicGlassPanel();
            this.acrylicGlassPanel1 = new AcrylicUI.Controls.AcrylicGlassPanel();
            this.lblStatus = new AcrylicUI.Controls.AcrylicLabel();
            this.windowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowPanel1
            // 
            this.windowPanel1.Controls.Add(this.lblStatus);
            this.windowPanel1.Controls.Add(this.acrylicGlassPanel2);
            this.windowPanel1.Controls.Add(this.acrylicGlassPanel3);
            this.windowPanel1.Controls.Add(this.acrylicGlassPanel1);
            this.windowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowPanel1.HamburgerMenuFeature = false;
            this.windowPanel1.Icon = null;
            this.windowPanel1.IsAcrylic = true;
            this.windowPanel1.Location = new System.Drawing.Point(0, 0);
            this.windowPanel1.Name = "windowPanel1";
            this.windowPanel1.ProfileFeature = false;
            this.windowPanel1.RoundCorners = false;
            this.windowPanel1.SectionHeader = null;
            this.windowPanel1.Size = new System.Drawing.Size(418, 450);
            this.windowPanel1.TabIndex = 0;
            // 
            // acrylicGlassPanel2
            // 
            this.acrylicGlassPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.acrylicGlassPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.acrylicGlassPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.acrylicGlassPanel2.Location = new System.Drawing.Point(35, 222);
            this.acrylicGlassPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acrylicGlassPanel2.Name = "acrylicGlassPanel2";
            this.acrylicGlassPanel2.Size = new System.Drawing.Size(330, 150);
            this.acrylicGlassPanel2.TabIndex = 4;
            // 
            // acrylicGlassPanel3
            // 
            this.acrylicGlassPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.acrylicGlassPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.acrylicGlassPanel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.acrylicGlassPanel3.HasRoundedCorners = true;
            this.acrylicGlassPanel3.Location = new System.Drawing.Point(54, 81);
            this.acrylicGlassPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acrylicGlassPanel3.Name = "acrylicGlassPanel3";
            this.acrylicGlassPanel3.Size = new System.Drawing.Size(294, 61);
            this.acrylicGlassPanel3.TabIndex = 2;
            // 
            // acrylicGlassPanel1
            // 
            this.acrylicGlassPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.acrylicGlassPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.acrylicGlassPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.acrylicGlassPanel1.Location = new System.Drawing.Point(35, 61);
            this.acrylicGlassPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acrylicGlassPanel1.Name = "acrylicGlassPanel1";
            this.acrylicGlassPanel1.Size = new System.Drawing.Size(330, 150);
            this.acrylicGlassPanel1.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblStatus.Location = new System.Drawing.Point(1, 426);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(416, 23);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Ready";
            // 
            // Form5_Borderless
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(418, 450);
            this.Controls.Add(this.windowPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form5_Borderless";
            this.Text = "Form5";
            this.windowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AcrylicUI.Controls.WindowPanel windowPanel1;
        private AcrylicUI.Controls.AcrylicGlassPanel acrylicGlassPanel3;
        private AcrylicUI.Controls.AcrylicGlassPanel acrylicGlassPanel2;
        private AcrylicUI.Controls.AcrylicGlassPanel acrylicGlassPanel1;
        private AcrylicUI.Controls.AcrylicLabel lblStatus;
    }
}