
namespace Examples
{
    partial class Form7
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
            this.acrylicButton1 = new AcrylicUI.Controls.AcrylicButton();
            this.acrylicTextBox1 = new AcrylicUI.Controls.AcrylicTextBox();
            this.windowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowPanel1
            // 
            this.windowPanel1.Controls.Add(this.acrylicTextBox1);
            this.windowPanel1.Controls.Add(this.acrylicButton1);
            this.windowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowPanel1.Icon = null;
            this.windowPanel1.IsAcrylicEnabled = false;
            this.windowPanel1.Location = new System.Drawing.Point(0, 0);
            this.windowPanel1.Name = "windowPanel1";
            this.windowPanel1.RoundCorners = false;
            this.windowPanel1.SectionHeader = null;
            this.windowPanel1.Size = new System.Drawing.Size(800, 450);
            this.windowPanel1.TabIndex = 0;
            // 
            // acrylicButton1
            // 
            this.acrylicButton1.Default = false;
            this.acrylicButton1.ImagePadding = 6;
            this.acrylicButton1.Location = new System.Drawing.Point(12, 92);
            this.acrylicButton1.Name = "acrylicButton1";
            this.acrylicButton1.Padding = new System.Windows.Forms.Padding(6);
            this.acrylicButton1.Size = new System.Drawing.Size(160, 32);
            this.acrylicButton1.TabIndex = 0;
            this.acrylicButton1.Text = "acrylicButton1";
            this.acrylicButton1.UseVisualStyleBackColor = false;
            // 
            // acrylicTextBox1
            // 
            this.acrylicTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.acrylicTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.acrylicTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.acrylicTextBox1.Location = new System.Drawing.Point(12, 54);
            this.acrylicTextBox1.Name = "acrylicTextBox1";
            this.acrylicTextBox1.Size = new System.Drawing.Size(160, 23);
            this.acrylicTextBox1.TabIndex = 1;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.windowPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form7";
            this.Text = "Form5";
            this.windowPanel1.ResumeLayout(false);
            this.windowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AcrylicUI.Controls.WindowPanel windowPanel1;
        private AcrylicUI.Controls.AcrylicButton acrylicButton1;
        private AcrylicUI.Controls.AcrylicTextBox acrylicTextBox1;
    }
}