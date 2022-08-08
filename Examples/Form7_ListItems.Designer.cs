
namespace Examples
{
    partial class Form7_ListItems
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
            this.acrylicListView1 = new AcrylicUI.Controls.AcrylicListView();
            this.acrylicTextBox1 = new AcrylicUI.Controls.AcrylicTextBox();
            this.acrylicButton1 = new AcrylicUI.Controls.AcrylicButton();
            this.windowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowPanel1
            // 
            this.windowPanel1.Controls.Add(this.acrylicListView1);
            this.windowPanel1.Controls.Add(this.acrylicTextBox1);
            this.windowPanel1.Controls.Add(this.acrylicButton1);
            this.windowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowPanel1.Icon = null;
            this.windowPanel1.IsAcrylic = false;
            this.windowPanel1.Location = new System.Drawing.Point(0, 0);
            this.windowPanel1.Name = "windowPanel1";
            this.windowPanel1.RoundCorners = false;
            this.windowPanel1.SectionHeader = null;
            this.windowPanel1.Size = new System.Drawing.Size(447, 450);
            this.windowPanel1.TabIndex = 0;
            // 
            // acrylicListView1
            // 
            this.acrylicListView1.AlternateBackground = false;
            this.acrylicListView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.acrylicListView1.IsAcrylic = true;
            this.acrylicListView1.Location = new System.Drawing.Point(1, 36);
            this.acrylicListView1.Name = "acrylicListView1";
            this.acrylicListView1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.acrylicListView1.Size = new System.Drawing.Size(150, 413);
            this.acrylicListView1.TabIndex = 2;
            this.acrylicListView1.Text = "acrylicListView1";
            // 
            // acrylicTextBox1
            // 
            this.acrylicTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.acrylicTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.acrylicTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.acrylicTextBox1.Location = new System.Drawing.Point(214, 54);
            this.acrylicTextBox1.Name = "acrylicTextBox1";
            this.acrylicTextBox1.PlaceholderText = "Enter Text";
            this.acrylicTextBox1.Size = new System.Drawing.Size(184, 23);
            this.acrylicTextBox1.TabIndex = 3;
            // 
            // acrylicButton1
            // 
            this.acrylicButton1.Default = false;
            this.acrylicButton1.HasRoundedCorners = false;
            this.acrylicButton1.Image = null;
            this.acrylicButton1.ImagePadding = 6;
            this.acrylicButton1.Location = new System.Drawing.Point(214, 83);
            this.acrylicButton1.Name = "acrylicButton1";
            this.acrylicButton1.Padding = new System.Windows.Forms.Padding(6);
            this.acrylicButton1.Size = new System.Drawing.Size(80, 32);
            this.acrylicButton1.TabIndex = 0;
            this.acrylicButton1.Text = "Add to List";
            this.acrylicButton1.UseVisualStyleBackColor = false;
            this.acrylicButton1.Click += new System.EventHandler(this.acrylicButton1_Click);
            // 
            // Form7_ListItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.windowPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form7_ListItems";
            this.Text = "Form5";
            this.windowPanel1.ResumeLayout(false);
            this.windowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AcrylicUI.Controls.WindowPanel windowPanel1;
        private AcrylicUI.Controls.AcrylicButton acrylicButton1;
        private AcrylicUI.Controls.AcrylicTextBox acrylicTextBox1;
        private AcrylicUI.Controls.AcrylicListView acrylicListView1;
    }
}