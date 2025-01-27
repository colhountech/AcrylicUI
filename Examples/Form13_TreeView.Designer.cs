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
            acrylicLabel1 = new AcrylicUI.Controls.AcrylicLabel();
            acrylicTreeView1 = new AcrylicUI.Controls.AcrylicTreeView();
            SuspendLayout();
            // 
            // acrylicLabel1
            // 
            acrylicLabel1.AutoSize = true;
            acrylicLabel1.BackColor = System.Drawing.Color.Transparent;
            acrylicLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            acrylicLabel1.Location = new System.Drawing.Point(33, 19);
            acrylicLabel1.Name = "acrylicLabel1";
            acrylicLabel1.Size = new System.Drawing.Size(53, 15);
            acrylicLabel1.TabIndex = 8;
            acrylicLabel1.Text = "TreeView";
            // 
            // acrylicTreeView1
            // 
            acrylicTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            acrylicTreeView1.Location = new System.Drawing.Point(0, 0);
            acrylicTreeView1.MaxDragChange = 20;
            acrylicTreeView1.Name = "acrylicTreeView1";
            acrylicTreeView1.Size = new System.Drawing.Size(800, 450);
            acrylicTreeView1.TabIndex = 9;
            acrylicTreeView1.Text = "acrylicTreeView1";
            // 
            // Form13_TreeView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = AcrylicUI.Resources.Colors.GreyBackground;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(acrylicTreeView1);
            Controls.Add(acrylicLabel1);
            Location = new System.Drawing.Point(0, 0);
            Name = "Form13_TreeView";
            Text = "Form13 - TreeView";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private AcrylicUI.Controls.AcrylicLabel acrylicLabel1;
        private AcrylicUI.Controls.AcrylicTreeView acrylicTreeView1;
    }
}