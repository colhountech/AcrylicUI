namespace Examples
{
    partial class Form15_ComboBox
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
            this.acrylicComboBox1 = new AcrylicUI.Controls.AcrylicComboBox();
            this.acrylicComboBox2 = new AcrylicUI.Controls.AcrylicComboBox();
            this.acrylicTitle1 = new AcrylicUI.Controls.AcrylicTitle();
            this.acrylicLabel1 = new AcrylicUI.Controls.AcrylicLabel();
            this.acrylicLabel2 = new AcrylicUI.Controls.AcrylicLabel();
            this.SuspendLayout();
            // 
            // acrylicComboBox1
            // 
            this.acrylicComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.acrylicComboBox1.FormattingEnabled = true;
            this.acrylicComboBox1.Items.AddRange(new object[] {
            "English",
            "French",
            "Spanish"});
            this.acrylicComboBox1.Location = new System.Drawing.Point(117, 56);
            this.acrylicComboBox1.Name = "acrylicComboBox1";
            this.acrylicComboBox1.Size = new System.Drawing.Size(161, 24);
            this.acrylicComboBox1.TabIndex = 0;
            // 
            // acrylicComboBox2
            // 
            this.acrylicComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.acrylicComboBox2.FormattingEnabled = true;
            this.acrylicComboBox2.Items.AddRange(new object[] {
            "See Source Code",
            "On How to Make a Combox Readonly",
            "You can\'t select this",
            "..or this!",
            "Muhaaahaa!"});
            this.acrylicComboBox2.Location = new System.Drawing.Point(117, 86);
            this.acrylicComboBox2.Name = "acrylicComboBox2";
            this.acrylicComboBox2.Size = new System.Drawing.Size(161, 24);
            this.acrylicComboBox2.TabIndex = 1;
            this.acrylicComboBox2.SelectedIndexChanged += new System.EventHandler(this.acrylicComboBox2_SelectedIndexChanged);
            // 
            // acrylicTitle1
            // 
            this.acrylicTitle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.acrylicTitle1.Location = new System.Drawing.Point(34, 30);
            this.acrylicTitle1.Name = "acrylicTitle1";
            this.acrylicTitle1.Size = new System.Drawing.Size(244, 23);
            this.acrylicTitle1.TabIndex = 2;
            this.acrylicTitle1.Text = "acrylicTitle1";
            // 
            // acrylicLabel1
            // 
            this.acrylicLabel1.AutoSize = true;
            this.acrylicLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.acrylicLabel1.Location = new System.Drawing.Point(52, 59);
            this.acrylicLabel1.Name = "acrylicLabel1";
            this.acrylicLabel1.Size = new System.Drawing.Size(59, 15);
            this.acrylicLabel1.TabIndex = 3;
            this.acrylicLabel1.Text = "Language";
            this.acrylicLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // acrylicLabel2
            // 
            this.acrylicLabel2.AutoSize = true;
            this.acrylicLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.acrylicLabel2.Location = new System.Drawing.Point(55, 89);
            this.acrylicLabel2.Name = "acrylicLabel2";
            this.acrylicLabel2.Size = new System.Drawing.Size(56, 15);
            this.acrylicLabel2.TabIndex = 4;
            this.acrylicLabel2.Text = "Readonly";
            this.acrylicLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form15_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.acrylicLabel2);
            this.Controls.Add(this.acrylicLabel1);
            this.Controls.Add(this.acrylicTitle1);
            this.Controls.Add(this.acrylicComboBox2);
            this.Controls.Add(this.acrylicComboBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form15_ComboBox";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AcrylicUI.Controls.AcrylicComboBox acrylicComboBox1;
        private AcrylicUI.Controls.AcrylicComboBox acrylicComboBox2;
        private AcrylicUI.Controls.AcrylicTitle acrylicTitle1;
        private AcrylicUI.Controls.AcrylicLabel acrylicLabel1;
        private AcrylicUI.Controls.AcrylicLabel acrylicLabel2;
    }
}