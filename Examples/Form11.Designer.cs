﻿namespace Examples
{
    partial class Form11
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
            this.acrylicLabel1 = new AcrylicUI.Controls.AcrylicLabel();
            this.SuspendLayout();
            // 
            // acrylicLabel1
            // 
            this.acrylicLabel1.AutoSize = true;
            this.acrylicLabel1.BackColor = System.Drawing.Color.Transparent;
            this.acrylicLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.acrylicLabel1.Location = new System.Drawing.Point(123, 92);
            this.acrylicLabel1.Name = "acrylicLabel1";
            this.acrylicLabel1.Size = new System.Drawing.Size(111, 25);
            this.acrylicLabel1.TabIndex = 0;
            this.acrylicLabel1.Text = "acrylicLabel1";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BlurColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.acrylicLabel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form11";
            this.Text = "Form11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AcrylicUI.Controls.AcrylicLabel acrylicLabel1;
    }
}