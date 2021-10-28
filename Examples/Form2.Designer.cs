
namespace Examples
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.acrylicButton1 = new AcrylicUI.Controls.AcrylicButton();
            this.acrylicButton2 = new AcrylicUI.Controls.AcrylicButton();
            this.acrylicButton3 = new AcrylicUI.Controls.AcrylicButton();
            this.acrylicButton4 = new AcrylicUI.Controls.AcrylicButton();
            this.acrylicGroupBox1 = new AcrylicUI.Controls.AcrylicGroupBox();
            this.acrylicButton6 = new AcrylicUI.Controls.AcrylicButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.acrylicGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // acrylicButton1
            // 
            this.acrylicButton1.Default = false;
            this.acrylicButton1.ImagePadding = 6;
            this.acrylicButton1.Location = new System.Drawing.Point(12, 24);
            this.acrylicButton1.Name = "acrylicButton1";
            this.acrylicButton1.Padding = new System.Windows.Forms.Padding(6);
            this.acrylicButton1.Size = new System.Drawing.Size(160, 32);
            this.acrylicButton1.TabIndex = 0;
            this.acrylicButton1.Text = "Normal";
            this.acrylicButton1.UseVisualStyleBackColor = false;
            // 
            // acrylicButton2
            // 
            this.acrylicButton2.Default = true;
            this.acrylicButton2.ImagePadding = 6;
            this.acrylicButton2.Location = new System.Drawing.Point(12, 68);
            this.acrylicButton2.Name = "acrylicButton2";
            this.acrylicButton2.Padding = new System.Windows.Forms.Padding(6);
            this.acrylicButton2.Size = new System.Drawing.Size(160, 32);
            this.acrylicButton2.TabIndex = 1;
            this.acrylicButton2.Text = "Default";
            this.acrylicButton2.UseVisualStyleBackColor = false;
            // 
            // acrylicButton3
            // 
            this.acrylicButton3.Default = false;
            this.acrylicButton3.Enabled = false;
            this.acrylicButton3.ImagePadding = 6;
            this.acrylicButton3.Location = new System.Drawing.Point(12, 112);
            this.acrylicButton3.Name = "acrylicButton3";
            this.acrylicButton3.Padding = new System.Windows.Forms.Padding(6);
            this.acrylicButton3.Size = new System.Drawing.Size(160, 32);
            this.acrylicButton3.TabIndex = 2;
            this.acrylicButton3.Text = "Disabled";
            this.acrylicButton3.UseVisualStyleBackColor = false;
            // 
            // acrylicButton4
            // 
            this.acrylicButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acrylicButton4.Default = false;
            this.acrylicButton4.ImagePadding = 6;
            this.acrylicButton4.Location = new System.Drawing.Point(46, 49);
            this.acrylicButton4.Name = "acrylicButton4";
            this.acrylicButton4.Padding = new System.Windows.Forms.Padding(6);
            this.acrylicButton4.Size = new System.Drawing.Size(160, 32);
            this.acrylicButton4.TabIndex = 3;
            this.acrylicButton4.Text = "GetDpi";
            this.acrylicButton4.UseVisualStyleBackColor = false;
            this.acrylicButton4.Click += new System.EventHandler(this.AcrylicButton4_Click);
            // 
            // acrylicGroupBox1
            // 
            this.acrylicGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acrylicGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.acrylicGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.acrylicGroupBox1.Controls.Add(this.acrylicButton1);
            this.acrylicGroupBox1.Controls.Add(this.acrylicButton2);
            this.acrylicGroupBox1.Controls.Add(this.acrylicButton3);
            this.acrylicGroupBox1.Location = new System.Drawing.Point(44, 89);
            this.acrylicGroupBox1.Name = "acrylicGroupBox1";
            this.acrylicGroupBox1.Size = new System.Drawing.Size(184, 162);
            this.acrylicGroupBox1.TabIndex = 4;
            this.acrylicGroupBox1.TabStop = false;
            this.acrylicGroupBox1.Text = "Buttons";
            // 
            // acrylicButton6
            // 
            this.acrylicButton6.Default = false;
            this.acrylicButton6.ImagePadding = 5;
            this.acrylicButton6.Location = new System.Drawing.Point(287, 270);
            this.acrylicButton6.Name = "acrylicButton6";
            this.acrylicButton6.Padding = new System.Windows.Forms.Padding(6);
            this.acrylicButton6.Size = new System.Drawing.Size(64, 64);
            this.acrylicButton6.TabIndex = 6;
            this.acrylicButton6.Text = "PicBtn";
            this.acrylicButton6.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(382, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 381);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(922, 418);
            this.Controls.Add(this.acrylicButton6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.acrylicButton4);
            this.Controls.Add(this.acrylicGroupBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form2";
            this.Text = "Form2";
            this.acrylicGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AcrylicUI.Controls.AcrylicButton acrylicButton1;
        private AcrylicUI.Controls.AcrylicButton acrylicButton2;
        private AcrylicUI.Controls.AcrylicButton acrylicButton3;
        private AcrylicUI.Controls.AcrylicButton acrylicButton4;
        private AcrylicUI.Controls.AcrylicGroupBox acrylicGroupBox1;
        private AcrylicUI.Controls.AcrylicButton acrylicButton6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}