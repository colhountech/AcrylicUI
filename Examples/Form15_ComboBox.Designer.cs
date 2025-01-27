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
            acrylicComboBox1 = new AcrylicUI.Controls.AcrylicComboBox();
            acrylicComboBox2 = new AcrylicUI.Controls.AcrylicComboBox();
            acrylicTitle1 = new AcrylicUI.Controls.AcrylicTitle();
            acrylicLabel1 = new AcrylicUI.Controls.AcrylicLabel();
            acrylicLabel2 = new AcrylicUI.Controls.AcrylicLabel();
            SuspendLayout();
            // 
            // acrylicComboBox1
            // 
            acrylicComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            acrylicComboBox1.FormattingEnabled = true;
            acrylicComboBox1.Items.AddRange(new object[] {
            "English",
            "French",
            "Spanish"});
            acrylicComboBox1.Location = new System.Drawing.Point(117, 56);
            acrylicComboBox1.Name = "acrylicComboBox1";
            acrylicComboBox1.Size = new System.Drawing.Size(161, 24);
            acrylicComboBox1.TabIndex = 0;
            // 
            // acrylicComboBox2
            // 
            acrylicComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            acrylicComboBox2.FormattingEnabled = true;
            acrylicComboBox2.Items.AddRange(new object[] {
            "See Source Code",
            "On How to Make a Combox Readonly",
            "You can\'t select this",
            "..or this!",
            "Muhaaahaa!"});
            acrylicComboBox2.Location = new System.Drawing.Point(117, 86);
            acrylicComboBox2.Name = "acrylicComboBox2";
            acrylicComboBox2.Size = new System.Drawing.Size(161, 24);
            acrylicComboBox2.TabIndex = 1;
            acrylicComboBox2.SelectedIndexChanged += new System.EventHandler(acrylicComboBox2_SelectedIndexChanged);
            // 
            // acrylicTitle1
            // 
            acrylicTitle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            acrylicTitle1.Location = new System.Drawing.Point(34, 30);
            acrylicTitle1.Name = "acrylicTitle1";
            acrylicTitle1.Size = new System.Drawing.Size(244, 23);
            acrylicTitle1.TabIndex = 2;
            acrylicTitle1.Text = "acrylicTitle1";
            // 
            // acrylicLabel1
            // 
            acrylicLabel1.AutoSize = true;
            acrylicLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            acrylicLabel1.Location = new System.Drawing.Point(52, 59);
            acrylicLabel1.Name = "acrylicLabel1";
            acrylicLabel1.Size = new System.Drawing.Size(59, 15);
            acrylicLabel1.TabIndex = 3;
            acrylicLabel1.Text = "Language";
            acrylicLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // acrylicLabel2
            // 
            acrylicLabel2.AutoSize = true;
            acrylicLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            acrylicLabel2.Location = new System.Drawing.Point(55, 89);
            acrylicLabel2.Name = "acrylicLabel2";
            acrylicLabel2.Size = new System.Drawing.Size(56, 15);
            acrylicLabel2.TabIndex = 4;
            acrylicLabel2.Text = "Readonly";
            acrylicLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form15_ComboBox
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(acrylicLabel2);
            Controls.Add(acrylicLabel1);
            Controls.Add(acrylicTitle1);
            Controls.Add(acrylicComboBox2);
            Controls.Add(acrylicComboBox1);
            Location = new System.Drawing.Point(0, 0);
            Name = "Form15_ComboBox";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private AcrylicUI.Controls.AcrylicComboBox acrylicComboBox1;
        private AcrylicUI.Controls.AcrylicComboBox acrylicComboBox2;
        private AcrylicUI.Controls.AcrylicTitle acrylicTitle1;
        private AcrylicUI.Controls.AcrylicLabel acrylicLabel1;
        private AcrylicUI.Controls.AcrylicLabel acrylicLabel2;
    }
}