namespace Examples
{
    partial class Form14_SectionPanel
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
            this.acrylicPanel1 = new AcrylicUI.Controls.AcrylicPanel();
            this.acrylicSectionPanel1 = new AcrylicUI.Controls.AcrylicSectionPanel();
            this.acrylicPanel1.SuspendLayout();
            this.acrylicSectionPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // acrylicPanel1
            // 
            this.acrylicPanel1.Controls.Add(this.acrylicSectionPanel1);
            this.acrylicPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.acrylicPanel1.Location = new System.Drawing.Point(507, 0);
            this.acrylicPanel1.Name = "acrylicPanel1";
            this.acrylicPanel1.Padding = new System.Windows.Forms.Padding(12);
            this.acrylicPanel1.Size = new System.Drawing.Size(293, 426);
            this.acrylicPanel1.TabIndex = 1;
            // 
            // acrylicSectionPanel1
            // 
            this.acrylicSectionPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acrylicSectionPanel1.Location = new System.Drawing.Point(12, 12);
            this.acrylicSectionPanel1.Name = "acrylicSectionPanel1";
            this.acrylicSectionPanel1.SectionHeader = "Tree View";
            this.acrylicSectionPanel1.Size = new System.Drawing.Size(269, 402);
            this.acrylicSectionPanel1.TabIndex = 0;
 
            // 
            // Form14_SectionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.acrylicPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form14_SectionPanel";
            this.Text = "Form1";
            this.acrylicPanel1.ResumeLayout(false);
            this.acrylicSectionPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private AcrylicUI.Controls.AcrylicPanel acrylicPanel1;
        private AcrylicUI.Controls.AcrylicSectionPanel acrylicSectionPanel1;
    }
}