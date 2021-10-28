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
    public partial class Form2 : AcrylicUI.Forms.AcrylicForm
    {
        public Form2()
        {
            InitializeComponent();
            this.Text = "";
            this.ShowIcon = false;
        }

        private void AcrylicButton4_Click(object sender, EventArgs e)
        {
            var Form1 = new Form1();
            Form1.ShowDialog();
        }

        private void AcrylicButton5_Click(object sender, EventArgs e)
        {

        }
    }
}
