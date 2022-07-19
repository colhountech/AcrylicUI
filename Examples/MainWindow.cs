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
    public partial class MainWindow : AcrylicUI.Forms.AcrylicForm
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Text = "";
            this.IsAcrylic = true;
            this.BlurColor = Colors.GreyBackground; // This keeps getting overwritten when you change Designer properties
            
        }

        private void acrylicButton1_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void acrylicButton2_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void acrylicButton3_Click(object sender, EventArgs e)
        {
            var form = new Form3();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void acrylicButton4_Click(object sender, EventArgs e)
        {
            var form = new Form4();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void acrylicButton5_Click(object sender, EventArgs e)
        {
            var form = new Form5();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void acrylicButton6_Click(object sender, EventArgs e)
        {
            var form = new Form6();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void acrylicButton7_Click(object sender, EventArgs e)
        {
            var form = new Form7();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void acrylicButton8_Click(object sender, EventArgs e)
        {
            var form = new Form8();
            form.StartPosition = FormStartPosition.CenterParent; 
            form.ShowDialog(this);
        }

        private void acrylicButton9_Click(object sender, EventArgs e)
        {
            var form = new Form9();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void acrylicButton10_Click(object sender, EventArgs e)
        {
            var form = new Form10();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void acrylicButton11_Click(object sender, EventArgs e)
        {
            var form = new Form11();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void acrylicButton12_Click(object sender, EventArgs e)
        {
            var form = new Form12_Dialogs();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }
    }
}
