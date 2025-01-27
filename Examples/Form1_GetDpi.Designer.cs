
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
            pnlPadding = new System.Windows.Forms.Panel();
            grpDpiSettings = new AcrylicUI.Controls.AcrylicGroupBox();
            txtAutoScaleFactor = new AcrylicUI.Controls.AcrylicTextBox();
            lblAutoScaleFactor = new System.Windows.Forms.Label();
            txtWinVer = new AcrylicUI.Controls.AcrylicTextBox();
            lblWinVer = new System.Windows.Forms.Label();
            txtSystemDpi = new System.Windows.Forms.TextBox();
            lblDpi = new System.Windows.Forms.Label();
            pnlPadding.SuspendLayout();
            grpDpiSettings.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPadding
            // 
            pnlPadding.BackColor = System.Drawing.Color.Transparent;
            pnlPadding.Controls.Add(grpDpiSettings);
            pnlPadding.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlPadding.Location = new System.Drawing.Point(0, 0);
            pnlPadding.Name = "pnlPadding";
            pnlPadding.Padding = new System.Windows.Forms.Padding(24);
            pnlPadding.Size = new System.Drawing.Size(482, 210);
            pnlPadding.TabIndex = 8;
            // 
            // grpDpiSettings
            // 
            grpDpiSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            grpDpiSettings.Controls.Add(txtAutoScaleFactor);
            grpDpiSettings.Controls.Add(lblAutoScaleFactor);
            grpDpiSettings.Controls.Add(txtWinVer);
            grpDpiSettings.Controls.Add(lblWinVer);
            grpDpiSettings.Controls.Add(txtSystemDpi);
            grpDpiSettings.Controls.Add(lblDpi);
            grpDpiSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            grpDpiSettings.Location = new System.Drawing.Point(20, 33);
            grpDpiSettings.Name = "grpDpiSettings";
            grpDpiSettings.Size = new System.Drawing.Size(453, 158);
            grpDpiSettings.TabIndex = 8;
            grpDpiSettings.TabStop = false;
            grpDpiSettings.Text = "Dpi Settings";
            // 
            // txtAutoScaleFactor
            // 
            txtAutoScaleFactor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            txtAutoScaleFactor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtAutoScaleFactor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            txtAutoScaleFactor.Location = new System.Drawing.Point(144, 104);
            txtAutoScaleFactor.Name = "txtAutoScaleFactor";
            txtAutoScaleFactor.Size = new System.Drawing.Size(275, 23);
            txtAutoScaleFactor.TabIndex = 13;
            txtAutoScaleFactor.Text = "0";
            // 
            // lblAutoScaleFactor
            // 
            lblAutoScaleFactor.AutoSize = true;
            lblAutoScaleFactor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            lblAutoScaleFactor.Location = new System.Drawing.Point(15, 107);
            lblAutoScaleFactor.Name = "lblAutoScaleFactor";
            lblAutoScaleFactor.Size = new System.Drawing.Size(105, 15);
            lblAutoScaleFactor.TabIndex = 12;
            lblAutoScaleFactor.Text = "Auto Scale Factor :";
            // 
            // txtWinVer
            // 
            txtWinVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            txtWinVer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtWinVer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            txtWinVer.Location = new System.Drawing.Point(144, 68);
            txtWinVer.Name = "txtWinVer";
            txtWinVer.Size = new System.Drawing.Size(275, 23);
            txtWinVer.TabIndex = 11;
            txtWinVer.Text = "0";
            // 
            // lblWinVer
            // 
            lblWinVer.AutoSize = true;
            lblWinVer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            lblWinVer.Location = new System.Drawing.Point(15, 71);
            lblWinVer.Name = "lblWinVer";
            lblWinVer.Size = new System.Drawing.Size(50, 15);
            lblWinVer.TabIndex = 10;
            lblWinVer.Text = "WinVer :";
            // 
            // txtSystemDpi
            // 
            txtSystemDpi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            txtSystemDpi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSystemDpi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            txtSystemDpi.Location = new System.Drawing.Point(144, 32);
            txtSystemDpi.Name = "txtSystemDpi";
            txtSystemDpi.Size = new System.Drawing.Size(275, 23);
            txtSystemDpi.TabIndex = 9;
            txtSystemDpi.Text = "0";
            // 
            // lblDpi
            // 
            lblDpi.AutoSize = true;
            lblDpi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            lblDpi.Location = new System.Drawing.Point(15, 35);
            lblDpi.Name = "lblDpi";
            lblDpi.Size = new System.Drawing.Size(72, 15);
            lblDpi.TabIndex = 8;
            lblDpi.Text = "System Dpi :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = AcrylicUI.Resources.Colors.GreyBackground;
            ClientSize = new System.Drawing.Size(482, 210);
            Controls.Add(pnlPadding);
            Location = new System.Drawing.Point(0, 0);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Form1";
            Load += new System.EventHandler(Form1_Load);
            pnlPadding.ResumeLayout(false);
            grpDpiSettings.ResumeLayout(false);
            grpDpiSettings.PerformLayout();
            ResumeLayout(false);

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