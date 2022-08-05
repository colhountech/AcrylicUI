
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
            this.windowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowPanel1
            // 
            this.windowPanel1.Controls.Add(this.acrylicGlassPanel2);
            this.windowPanel1.Controls.Add(this.acrylicGlassPanel3);
            this.windowPanel1.Controls.Add(this.acrylicGlassPanel1);
            this.windowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowPanel1.Icon = null;
            this.windowPanel1.IsAcrylicEnabled = true;
            this.windowPanel1.Location = new System.Drawing.Point(0, 0);
            this.windowPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.windowPanel1.Name = "windowPanel1";
            this.windowPanel1.ProfileFeature = false;
            this.windowPanel1.RoundCorners = false;
            this.windowPanel1.SectionHeader = null;
            this.windowPanel1.Size = new System.Drawing.Size(732, 788);
            this.windowPanel1.TabIndex = 0;
            // 
            // acrylicGlassPanel2
            // 
            this.acrylicGlassPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.acrylicGlassPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.acrylicGlassPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.acrylicGlassPanel2.Location = new System.Drawing.Point(61, 389);
            this.acrylicGlassPanel2.Name = "acrylicGlassPanel2";
            this.acrylicGlassPanel2.Size = new System.Drawing.Size(578, 262);
            this.acrylicGlassPanel2.TabIndex = 4;
            // 
            // acrylicGlassPanel3
            // 
            this.acrylicGlassPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.acrylicGlassPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.acrylicGlassPanel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.acrylicGlassPanel3.HasRoundedCorners = true;
            this.acrylicGlassPanel3.Location = new System.Drawing.Point(95, 142);
            this.acrylicGlassPanel3.Name = "acrylicGlassPanel3";
            this.acrylicGlassPanel3.Size = new System.Drawing.Size(515, 107);
            this.acrylicGlassPanel3.TabIndex = 2;
            // 
            // acrylicGlassPanel1
            // 
            this.acrylicGlassPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.acrylicGlassPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.acrylicGlassPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.acrylicGlassPanel1.Location = new System.Drawing.Point(61, 106);
            this.acrylicGlassPanel1.Name = "acrylicGlassPanel1";
            this.acrylicGlassPanel1.Size = new System.Drawing.Size(578, 262);
            this.acrylicGlassPanel1.TabIndex = 3;
            // 
            // Form5_Borderless
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(732, 788);
            this.Controls.Add(this.windowPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(9);
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
    }
}