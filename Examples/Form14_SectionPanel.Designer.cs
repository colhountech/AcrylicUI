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
            acrylicPanel1 = new AcrylicUI.Controls.AcrylicPanel();
            acrylicSectionPanel1 = new AcrylicUI.Controls.AcrylicSectionPanel();
            acrylicPanel1.SuspendLayout();
            acrylicSectionPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // acrylicPanel1
            // 
            acrylicPanel1.Controls.Add(acrylicSectionPanel1);
            acrylicPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            acrylicPanel1.Location = new System.Drawing.Point(507, 0);
            acrylicPanel1.Name = "acrylicPanel1";
            acrylicPanel1.Padding = new System.Windows.Forms.Padding(12);
            acrylicPanel1.Size = new System.Drawing.Size(293, 426);
            acrylicPanel1.TabIndex = 1;
            // 
            // acrylicSectionPanel1
            // 
            acrylicSectionPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            acrylicSectionPanel1.Location = new System.Drawing.Point(12, 12);
            acrylicSectionPanel1.Name = "acrylicSectionPanel1";
            acrylicSectionPanel1.SectionHeader = "Tree View";
            acrylicSectionPanel1.Size = new System.Drawing.Size(269, 402);
            acrylicSectionPanel1.TabIndex = 0;
 
            // 
            // Form14_SectionPanel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(acrylicPanel1);
            Location = new System.Drawing.Point(0, 0);
            Name = "Form14_SectionPanel";
            Text = "Form1";
            acrylicPanel1.ResumeLayout(false);
            acrylicSectionPanel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private AcrylicUI.Controls.AcrylicPanel acrylicPanel1;
        private AcrylicUI.Controls.AcrylicSectionPanel acrylicSectionPanel1;
    }
}