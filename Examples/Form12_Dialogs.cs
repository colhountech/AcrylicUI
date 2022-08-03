using AcrylicUI.Forms;
using AcrylicUI.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples
{
    public partial class Form12_Dialogs : AcrylicForm
    {
        public Form12_Dialogs()
        {
            InitializeComponent();
            // Make sure you set this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // Program.cs : Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            this.Text = "";
            this.IsAcrylic = true;
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void DefaultDialog_Click(object sender, EventArgs e)
        {
            using (var form = new AcrylicDialog())
            {
                form.Text = "";
                form.ShowDialog();
            }
        }

        private void acrylicButton2_Click(object sender, EventArgs e)
        {
            using (var form = new AcrylicDialog())
            {
                form.DialogButtons = AcrylicDialogButton.Ok;
                form.Text = "";
                form.ShowDialog();
            }
        }

        private void acrylicButton3_Click(object sender, EventArgs e)
        {
            using (var form = new AcrylicDialog())
            {
                form.DialogButtons = AcrylicDialogButton.Close;
                form.Text = "";
                form.ShowDialog();
            }
                
        }

        private void acrylicButton4_Click(object sender, EventArgs e)
        {
            using (var form = new AcrylicDialog())
            {
                form.DialogButtons = AcrylicDialogButton.OkCancel;
                form.Text = "";
                form.ShowDialog();
            }
        }

        private void acrylicButton5_Click(object sender, EventArgs e)
        {
            using (var form = new AcrylicDialog())
            {
                form.DialogButtons = AcrylicDialogButton.YesNo;
                form.Text = "";
                form.ShowDialog();
            }
        }

        private void acrylicButton6_Click(object sender, EventArgs e)
        {
            using (var form = new AcrylicDialog())
            {
                form.DialogButtons = AcrylicDialogButton.YesNoCancel;
                form.Text = "";
                form.ShowDialog();
            }
        }

        private void acrylicButton20_Click(object sender, EventArgs e)
        {
            using (var form = new AcrylicDialog())
            {
                form.DialogButtons = AcrylicDialogButton.OKCancelApply;
                form.Text = "";
                form.ShowDialog();
            }
        }

        private void acrylicButton7_Click(object sender, EventArgs e)
        {
            using (var form = new AcrylicDialog())
            {
                form.DialogButtons = AcrylicDialogButton.AbortRetryIgnore;
                form.Text = "";
                form.ShowDialog();
            }
        }

        private void acrylicButton8_Click(object sender, EventArgs e)
        {
            using (var form = new AcrylicDialog())
            {
                form.DialogButtons = AcrylicDialogButton.RetryCancel;
                form.Text = "";
                form.ShowDialog();
            }
        }

        private void acrylicButton16_Click(object sender, EventArgs e)
        {
            AcrylicMessageBox.ShowInformation("Message", "Caption");

        }

        private void acrylicButton15_Click(object sender, EventArgs e)
        {
            AcrylicMessageBox.ShowInformation("Text", "Caption");
        }

        private void acrylicButton14_Click(object sender, EventArgs e)
        {
            AcrylicMessageBox.ShowWarning("Text", "Caption");
        }

        private void acrylicButton13_Click(object sender, EventArgs e)
        {
            AcrylicMessageBox.ShowError("Text", "Caption");
        }

        private void acrylicButton12_Click(object sender, EventArgs e)
        {
            AcrylicMessageBox.ShowInformation("Text", "Caption", AcrylicDialogButton.YesNo);
        }

        private void acrylicButton11_Click(object sender, EventArgs e)
        {
            AcrylicMessageBox.ShowWarning("Text", "Caption", AcrylicDialogButton.YesNo);
        }

        private void acrylicButton9_Click_1(object sender, EventArgs e)
        {
            AcrylicMessageBox.ShowError("Text", "Caption", AcrylicDialogButton.YesNo);

        }

        private void acrylicButton19_Click(object sender, EventArgs e)
        {
            AcrylicMessageBox.ShowInformation("Text", "Caption", AcrylicDialogButton.AbortRetryIgnore);
        }

        private void acrylicButton17_Click(object sender, EventArgs e)
        {
            AcrylicMessageBox.ShowError("Text", "Caption", AcrylicDialogButton.AbortRetryIgnore);
        }

        private void acrylicButton18_Click(object sender, EventArgs e)
        {
            AcrylicMessageBox.ShowWarning("Text", "Caption", AcrylicDialogButton.AbortRetryIgnore);
        }

        private void acrylicButton10_Click(object sender, EventArgs e)
        {
            AcrylicMessageBox.ShowInformation("This is a longer Message that spans at least one line and probably more", "Caption Goes Here");
        }

    }
    
}
