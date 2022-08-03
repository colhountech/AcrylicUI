using AcrylicUI.Controls;
using AcrylicUI.Resources;

namespace AcrylicUI.Forms
{
    partial class AcrylicDialog
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
            this.pnlFooter = new AcrylicUI.Controls.AcrylicPanel();
            this.flowInner = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOk = new AcrylicUI.Controls.AcrylicButton();
            this.btnCancel = new AcrylicUI.Controls.AcrylicButton();
            this.btnClose = new AcrylicUI.Controls.AcrylicButton();
            this.btnYes = new AcrylicUI.Controls.AcrylicButton();
            this.btnNo = new AcrylicUI.Controls.AcrylicButton();
            this.btnAbort = new AcrylicUI.Controls.AcrylicButton();
            this.btnRetry = new AcrylicUI.Controls.AcrylicButton();
            this.btnIgnore = new AcrylicUI.Controls.AcrylicButton();
            this.btnApply = new AcrylicUI.Controls.AcrylicButton();
            this.pnlFooter.SuspendLayout();
            this.flowInner.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnlFooter.Controls.Add(this.flowInner);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 357);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(767, 45);
            this.pnlFooter.TabIndex = 1;
            // 
            // flowInner
            // 
            this.flowInner.Controls.Add(this.btnOk);
            this.flowInner.Controls.Add(this.btnCancel);
            this.flowInner.Controls.Add(this.btnClose);
            this.flowInner.Controls.Add(this.btnYes);
            this.flowInner.Controls.Add(this.btnNo);
            this.flowInner.Controls.Add(this.btnAbort);
            this.flowInner.Controls.Add(this.btnRetry);
            this.flowInner.Controls.Add(this.btnIgnore);
            this.flowInner.Controls.Add(this.btnApply);
            this.flowInner.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowInner.Location = new System.Drawing.Point(24, 0);
            this.flowInner.Name = "flowInner";
            this.flowInner.Padding = new System.Windows.Forms.Padding(12);
            this.flowInner.Size = new System.Drawing.Size(743, 45);
            this.flowInner.TabIndex = 10014;
            // 
            // btnOk
            // 
            this.btnOk.Default = false;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Image = null;
            this.btnOk.ImagePadding = 6;
            this.btnOk.Location = new System.Drawing.Point(12, 12);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Padding = new System.Windows.Forms.Padding(5);
            this.btnOk.Size = new System.Drawing.Size(75, 26);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Default = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = null;
            this.btnCancel.ImagePadding = 6;
            this.btnCancel.Location = new System.Drawing.Point(87, 12);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Default = false;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = null;
            this.btnClose.ImagePadding = 6;
            this.btnClose.Location = new System.Drawing.Point(162, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(5);
            this.btnClose.Size = new System.Drawing.Size(75, 26);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnYes
            // 
            this.btnYes.Default = false;
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.Image = null;
            this.btnYes.ImagePadding = 6;
            this.btnYes.Location = new System.Drawing.Point(237, 12);
            this.btnYes.Margin = new System.Windows.Forms.Padding(0);
            this.btnYes.Name = "btnYes";
            this.btnYes.Padding = new System.Windows.Forms.Padding(5);
            this.btnYes.Size = new System.Drawing.Size(75, 26);
            this.btnYes.TabIndex = 6;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            // 
            // btnNo
            // 
            this.btnNo.Default = false;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.Image = null;
            this.btnNo.ImagePadding = 6;
            this.btnNo.Location = new System.Drawing.Point(312, 12);
            this.btnNo.Margin = new System.Windows.Forms.Padding(0);
            this.btnNo.Name = "btnNo";
            this.btnNo.Padding = new System.Windows.Forms.Padding(5);
            this.btnNo.Size = new System.Drawing.Size(75, 26);
            this.btnNo.TabIndex = 7;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            // 
            // btnAbort
            // 
            this.btnAbort.Default = false;
            this.btnAbort.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnAbort.Image = null;
            this.btnAbort.ImagePadding = 6;
            this.btnAbort.Location = new System.Drawing.Point(387, 12);
            this.btnAbort.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Padding = new System.Windows.Forms.Padding(5);
            this.btnAbort.Size = new System.Drawing.Size(75, 26);
            this.btnAbort.TabIndex = 8;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = false;
            // 
            // btnRetry
            // 
            this.btnRetry.Default = false;
            this.btnRetry.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnRetry.Image = null;
            this.btnRetry.ImagePadding = 6;
            this.btnRetry.Location = new System.Drawing.Point(462, 12);
            this.btnRetry.Margin = new System.Windows.Forms.Padding(0);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Padding = new System.Windows.Forms.Padding(5);
            this.btnRetry.Size = new System.Drawing.Size(75, 26);
            this.btnRetry.TabIndex = 9;
            this.btnRetry.Text = "Retry";
            this.btnRetry.UseVisualStyleBackColor = false;
            // 
            // btnIgnore
            // 
            this.btnIgnore.Default = false;
            this.btnIgnore.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnIgnore.Image = null;
            this.btnIgnore.ImagePadding = 6;
            this.btnIgnore.Location = new System.Drawing.Point(537, 12);
            this.btnIgnore.Margin = new System.Windows.Forms.Padding(0);
            this.btnIgnore.Name = "btnIgnore";
            this.btnIgnore.Padding = new System.Windows.Forms.Padding(5);
            this.btnIgnore.Size = new System.Drawing.Size(75, 26);
            this.btnIgnore.TabIndex = 10;
            this.btnIgnore.Text = "Ignore";
            this.btnIgnore.UseVisualStyleBackColor = false;
            // 
            // btnApply
            // 
            this.btnApply.Default = false;
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.Continue;
            this.btnApply.Image = null;
            this.btnApply.ImagePadding = 6;
            this.btnApply.Location = new System.Drawing.Point(612, 12);
            this.btnApply.Margin = new System.Windows.Forms.Padding(0);
            this.btnApply.Name = "btnApply";
            this.btnApply.Padding = new System.Windows.Forms.Padding(5);
            this.btnApply.Size = new System.Drawing.Size(75, 26);
            this.btnApply.TabIndex = 9;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            // 
            // AcrylicDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(767, 402);
            this.Controls.Add(this.pnlFooter);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "AcrylicDialog";
            this.Text = "AcrylicDialog";
            this.pnlFooter.ResumeLayout(false);
            this.flowInner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AcrylicPanel pnlFooter;
        private System.Windows.Forms.FlowLayoutPanel flowInner;
    }
}