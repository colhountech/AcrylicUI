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
            this.SuspendLayout();
            // 
            // windowPanel1
            // 
            this.windowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowPanel1.IsAcrylicEnabled = false;
            this.windowPanel1.Location = new System.Drawing.Point(0, 0);
            this.windowPanel1.Name = "windowPanel1";
            this.windowPanel1.RoundCorners = false;
            this.windowPanel1.Size = new System.Drawing.Size(800, 450);
            this.windowPanel1.TabIndex = 0;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BlurColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.windowPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form8";
            this.ResumeLayout(false);

        }

        #endregion

        private AcrylicUI.Controls.WindowPanel windowPanel1;
    }
}