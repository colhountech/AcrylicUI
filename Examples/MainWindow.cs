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
            this.BackColor = AcrylicUI.Resources.Colors.GreyBackground;

        }

        private void acrylicButton1_Click(object sender, EventArgs e)
        {
            var form = new Form1_GetDpi();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void acrylicButton2_Click(object sender, EventArgs e)
        {
            var form = new Form2_Buttons();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void acrylicButton3_Click(object sender, EventArgs e)
        {
            var form = new Form3_AlertPanel();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void acrylicButton4_Click(object sender, EventArgs e)
        {
            var form = new Form4_GlassPanel();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void acrylicButton5_Click(object sender, EventArgs e)
        {
            var form = new Form5_Borderless();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void acrylicButton6_Click(object sender, EventArgs e)
        {
            var form = new Form6_DockPanel();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void acrylicButton7_Click(object sender, EventArgs e)
        {
            var form = new Form7_ListItems();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void acrylicButton8_Click(object sender, EventArgs e)
        {
            var form = new Form8_Blank();
            form.StartPosition = FormStartPosition.CenterParent; 
            form.ShowDialog(this);
        }

        private void acrylicButton9_Click(object sender, EventArgs e)
        {
            var form = new Form9_BlankGlass();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void acrylicButton10_Click(object sender, EventArgs e)
        {
            var form = new Form10_Panels();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void acrylicButton11_Click(object sender, EventArgs e)
        {
            var form = new Form11_Labels();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void acrylicButton12_Click(object sender, EventArgs e)
        {
            var form = new Form12_Dialogs();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void acrylicButton13_Click(object sender, EventArgs e)
        {
            var form = new Form13_TreeView();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void acrylicButton14_Click(object sender, EventArgs e)
        {

            var form = new Form14_SectionPanel();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void acrylicButton15_Click(object sender, EventArgs e)
        {
            var form = new Form15_ComboBox();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }
    }
}
