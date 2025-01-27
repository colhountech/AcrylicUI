
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
            windowPanel1 = new AcrylicUI.Controls.WindowPanel();
            acrylicListView1 = new AcrylicUI.Controls.AcrylicListView();
            acrylicTextBox1 = new AcrylicUI.Controls.AcrylicTextBox();
            acrylicButton1 = new AcrylicUI.Controls.AcrylicButton();
            windowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // windowPanel1
            // 
            windowPanel1.Controls.Add(acrylicListView1);
            windowPanel1.Controls.Add(acrylicTextBox1);
            windowPanel1.Controls.Add(acrylicButton1);
            windowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            windowPanel1.Icon = null;
            windowPanel1.IsAcrylic = false;
            windowPanel1.Location = new System.Drawing.Point(0, 0);
            windowPanel1.Name = "windowPanel1";
            windowPanel1.RoundCorners = false;
            windowPanel1.SectionHeader = null;
            windowPanel1.Size = new System.Drawing.Size(447, 450);
            windowPanel1.TabIndex = 0;
            // 
            // acrylicListView1
            // 
            acrylicListView1.AlternateBackground = false;
            acrylicListView1.Dock = System.Windows.Forms.DockStyle.Left;
            acrylicListView1.IsAcrylic = true;
            acrylicListView1.Location = new System.Drawing.Point(1, 36);
            acrylicListView1.Name = "acrylicListView1";
            acrylicListView1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            acrylicListView1.Size = new System.Drawing.Size(150, 413);
            acrylicListView1.TabIndex = 2;
            acrylicListView1.Text = "acrylicListView1";
            // 
            // acrylicTextBox1
            // 
            acrylicTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            acrylicTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            acrylicTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            acrylicTextBox1.Location = new System.Drawing.Point(214, 54);
            acrylicTextBox1.Name = "acrylicTextBox1";
            acrylicTextBox1.PlaceholderText = "Enter Text";
            acrylicTextBox1.Size = new System.Drawing.Size(184, 23);
            acrylicTextBox1.TabIndex = 3;
            // 
            // acrylicButton1
            // 
            acrylicButton1.Default = false;
            acrylicButton1.HasRoundedCorners = false;
            acrylicButton1.Image = null;
            acrylicButton1.ImagePadding = 6;
            acrylicButton1.Location = new System.Drawing.Point(214, 83);
            acrylicButton1.Name = "acrylicButton1";
            acrylicButton1.Padding = new System.Windows.Forms.Padding(6);
            acrylicButton1.Size = new System.Drawing.Size(80, 32);
            acrylicButton1.TabIndex = 0;
            acrylicButton1.Text = "Add to List";
            acrylicButton1.UseVisualStyleBackColor = false;
            acrylicButton1.Click += new System.EventHandler(acrylicButton1_Click);
            // 
            // Form7_ListItems
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(447, 450);
            Controls.Add(windowPanel1);
            Location = new System.Drawing.Point(0, 0);
            Name = "Form7_ListItems";
            Text = "Form5";
            windowPanel1.ResumeLayout(false);
            windowPanel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private AcrylicUI.Controls.WindowPanel windowPanel1;
        private AcrylicUI.Controls.AcrylicButton acrylicButton1;
        private AcrylicUI.Controls.AcrylicTextBox acrylicTextBox1;
        private AcrylicUI.Controls.AcrylicListView acrylicListView1;
    }
}