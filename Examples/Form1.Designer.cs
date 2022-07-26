
namespace Examples
{
    partial class Form1_GetDpi
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
            this.pnlPadding = new System.Windows.Forms.Panel();
            this.grpDpiSettings = new AcrylicUI.Controls.AcrylicGroupBox();
            this.txtAutoScaleFactor = new AcrylicUI.Controls.AcrylicTextBox();
            this.lblAutoScaleFactor = new System.Windows.Forms.Label();
            this.txtWinVer = new AcrylicUI.Controls.AcrylicTextBox();
            this.lblWinVer = new System.Windows.Forms.Label();
            this.txtSystemDpi = new System.Windows.Forms.TextBox();
            this.lblDpi = new System.Windows.Forms.Label();
            this.pnlPadding.SuspendLayout();
            this.grpDpiSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPadding
            // 
            this.pnlPadding.BackColor = System.Drawing.Color.Transparent;
            this.pnlPadding.Controls.Add(this.grpDpiSettings);
            this.pnlPadding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPadding.Location = new System.Drawing.Point(0, 0);
            this.pnlPadding.Name = "pnlPadding";
            this.pnlPadding.Padding = new System.Windows.Forms.Padding(24);
            this.pnlPadding.Size = new System.Drawing.Size(482, 210);
            this.pnlPadding.TabIndex = 8;
            // 
            // grpDpiSettings
            // 
            this.grpDpiSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpDpiSettings.Controls.Add(this.txtAutoScaleFactor);
            this.grpDpiSettings.Controls.Add(this.lblAutoScaleFactor);
            this.grpDpiSettings.Controls.Add(this.txtWinVer);
            this.grpDpiSettings.Controls.Add(this.lblWinVer);
            this.grpDpiSettings.Controls.Add(this.txtSystemDpi);
            this.grpDpiSettings.Controls.Add(this.lblDpi);
            this.grpDpiSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpDpiSettings.Location = new System.Drawing.Point(20, 33);
            this.grpDpiSettings.Name = "grpDpiSettings";
            this.grpDpiSettings.Size = new System.Drawing.Size(453, 158);
            this.grpDpiSettings.TabIndex = 8;
            this.grpDpiSettings.TabStop = false;
            this.grpDpiSettings.Text = "Dpi Settings";
            // 
            // txtAutoScaleFactor
            // 
            this.txtAutoScaleFactor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtAutoScaleFactor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAutoScaleFactor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtAutoScaleFactor.Location = new System.Drawing.Point(144, 104);
            this.txtAutoScaleFactor.Name = "txtAutoScaleFactor";
            this.txtAutoScaleFactor.Size = new System.Drawing.Size(275, 23);
            this.txtAutoScaleFactor.TabIndex = 13;
            this.txtAutoScaleFactor.Text = "0";
            // 
            // lblAutoScaleFactor
            // 
            this.lblAutoScaleFactor.AutoSize = true;
            this.lblAutoScaleFactor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.lblAutoScaleFactor.Location = new System.Drawing.Point(15, 107);
            this.lblAutoScaleFactor.Name = "lblAutoScaleFactor";
            this.lblAutoScaleFactor.Size = new System.Drawing.Size(105, 15);
            this.lblAutoScaleFactor.TabIndex = 12;
            this.lblAutoScaleFactor.Text = "Auto Scale Factor :";
            // 
            // txtWinVer
            // 
            this.txtWinVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtWinVer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWinVer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtWinVer.Location = new System.Drawing.Point(144, 68);
            this.txtWinVer.Name = "txtWinVer";
            this.txtWinVer.Size = new System.Drawing.Size(275, 23);
            this.txtWinVer.TabIndex = 11;
            this.txtWinVer.Text = "0";
            // 
            // lblWinVer
            // 
            this.lblWinVer.AutoSize = true;
            this.lblWinVer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.lblWinVer.Location = new System.Drawing.Point(15, 71);
            this.lblWinVer.Name = "lblWinVer";
            this.lblWinVer.Size = new System.Drawing.Size(50, 15);
            this.lblWinVer.TabIndex = 10;
            this.lblWinVer.Text = "WinVer :";
            // 
            // txtSystemDpi
            // 
            this.txtSystemDpi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtSystemDpi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSystemDpi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtSystemDpi.Location = new System.Drawing.Point(144, 32);
            this.txtSystemDpi.Name = "txtSystemDpi";
            this.txtSystemDpi.Size = new System.Drawing.Size(275, 23);
            this.txtSystemDpi.TabIndex = 9;
            this.txtSystemDpi.Text = "0";
            // 
            // lblDpi
            // 
            this.lblDpi.AutoSize = true;
            this.lblDpi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.lblDpi.Location = new System.Drawing.Point(15, 35);
            this.lblDpi.Name = "lblDpi";
            this.lblDpi.Size = new System.Drawing.Size(72, 15);
            this.lblDpi.TabIndex = 8;
            this.lblDpi.Text = "System Dpi :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = AcrylicUI.Resources.Colors.GreyBackground;
            this.ClientSize = new System.Drawing.Size(482, 210);
            this.Controls.Add(this.pnlPadding);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlPadding.ResumeLayout(false);
            this.grpDpiSettings.ResumeLayout(false);
            this.grpDpiSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPadding;
        private AcrylicUI.Controls.AcrylicGroupBox grpDpiSettings;
        
        private System.Windows.Forms.Label lblAutoScaleFactor;
        private AcrylicUI.Controls.AcrylicTextBox txtAutoScaleFactor;
        private AcrylicUI.Controls.AcrylicTextBox txtWinVer;
        private System.Windows.Forms.TextBox txtSystemDpi;
        private System.Windows.Forms.Label lblWinVer;
        
        private System.Windows.Forms.Label lblDpi;
    }
}