namespace Examples
{
    partial class Form13_TreeView
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
            this.acrylicTreeView1 = new AcrylicUI.Controls.AcrylicTreeView();
            this.SuspendLayout();
            // 
            // acrylicLabel1
            // 
            this.acrylicLabel1.AutoSize = true;
            this.acrylicLabel1.BackColor = System.Drawing.Color.Transparent;
            this.acrylicLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.acrylicLabel1.Location = new System.Drawing.Point(33, 19);
            this.acrylicLabel1.Name = "acrylicLabel1";
            this.acrylicLabel1.Size = new System.Drawing.Size(53, 15);
            this.acrylicLabel1.TabIndex = 8;
            this.acrylicLabel1.Text = "TreeView";
            // 
            // acrylicTreeView1
            // 
            this.acrylicTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acrylicTreeView1.Location = new System.Drawing.Point(0, 0);
            this.acrylicTreeView1.MaxDragChange = 20;
            this.acrylicTreeView1.Name = "acrylicTreeView1";
            this.acrylicTreeView1.Size = new System.Drawing.Size(800, 450);
            this.acrylicTreeView1.TabIndex = 9;
            this.acrylicTreeView1.Text = "acrylicTreeView1";
            // 
            // Form13_TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = AcrylicUI.Resources.Colors.GreyBackground;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.acrylicTreeView1);
            this.Controls.Add(this.acrylicLabel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form13_TreeView";
            this.Text = "Form13 - TreeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AcrylicUI.Controls.AcrylicLabel acrylicLabel1;
        private AcrylicUI.Controls.AcrylicTreeView acrylicTreeView1;
    }
}