using AcrylicUI.Resources;

namespace Examples
{
    partial class Form8
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.acrylicButton3 = new AcrylicUI.Controls.AcrylicButton();
            this.acrylicButton2 = new AcrylicUI.Controls.AcrylicButton();
            this.acrylicButton1 = new AcrylicUI.Controls.AcrylicButton();
            this.pnlInner = new System.Windows.Forms.Panel();
            this.windowPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowPanel1
            // 
            this.windowPanel1.Controls.Add(this.panel1);
            this.windowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowPanel1.BackColor = Colors.MontereyPanel;
            this.windowPanel1.Icon = null;
            this.windowPanel1.IsAcrylicEnabled = false;
            this.windowPanel1.Location = new System.Drawing.Point(0, 0);
            this.windowPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.windowPanel1.Name = "windowPanel1";
            this.windowPanel1.RoundCorners = false;
            this.windowPanel1.SectionHeader = null;
            this.windowPanel1.Size = new System.Drawing.Size(1600, 900);
            this.windowPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.acrylicButton3);
            this.panel1.Controls.Add(this.acrylicButton1);
            this.panel1.Controls.Add(this.acrylicButton2);
            this.panel1.Location = new System.Drawing.Point(4, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1592, 721);
            this.panel1.TabIndex = 3;
            // 
            // acrylicButton3
            // 
            this.acrylicButton3.Default = false;
            this.acrylicButton3.ImagePadding = 6;
            this.acrylicButton3.Location = new System.Drawing.Point(23, 287);
            this.acrylicButton3.Name = "acrylicButton3";
            this.acrylicButton3.Padding = new System.Windows.Forms.Padding(6);
            this.acrylicButton3.Size = new System.Drawing.Size(1522, 64);
            this.acrylicButton3.TabIndex = 2;
            this.acrylicButton3.Text = "acrylicButton3";
            this.acrylicButton3.UseVisualStyleBackColor = false;
            // 
            // acrylicButton2
            // 
            this.acrylicButton2.Default = false;
            this.acrylicButton2.ImagePadding = 6;
            this.acrylicButton2.Location = new System.Drawing.Point(23, 190);
            this.acrylicButton2.Name = "acrylicButton2";
            this.acrylicButton2.Padding = new System.Windows.Forms.Padding(6);
            this.acrylicButton2.Size = new System.Drawing.Size(1522, 64);
            this.acrylicButton2.TabIndex = 1;
            this.acrylicButton2.Text = "acrylicButton2";
            this.acrylicButton2.UseVisualStyleBackColor = false;
            // 
            // acrylicButton1
            // 
            this.acrylicButton1.Default = false;
            this.acrylicButton1.ImagePadding = 6;
            this.acrylicButton1.Location = new System.Drawing.Point(23, 103);
            this.acrylicButton1.Name = "acrylicButton1";
            this.acrylicButton1.Padding = new System.Windows.Forms.Padding(6);
            this.acrylicButton1.Size = new System.Drawing.Size(1522, 64);
            this.acrylicButton1.TabIndex = 0;
            this.acrylicButton1.Text = "acrylicButton1";
            this.acrylicButton1.UseVisualStyleBackColor = false;
            // 
            // pnlInner
            // 
            this.pnlInner.Location = new System.Drawing.Point(0, 0);
            this.pnlInner.Name = "pnlInner";
            this.pnlInner.Size = new System.Drawing.Size(200, 100);
            this.pnlInner.TabIndex = 0;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BlurColor =  Colors.MontereyPanel;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.windowPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(12);
            this.Name = "Form8";
            this.windowPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AcrylicUI.Controls.WindowPanel windowPanel1;
        private System.Windows.Forms.Panel pnlInner;
        private System.Windows.Forms.Panel panel1;
        private AcrylicUI.Controls.AcrylicButton acrylicButton3;
        private AcrylicUI.Controls.AcrylicButton acrylicButton2;
        private AcrylicUI.Controls.AcrylicButton acrylicButton1;
    }
}