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
    public partial class Form2 : AcrylicUI.Forms.AcrylicForm
    {
        public Form2()
        {
            InitializeComponent();
            // Make sure you set this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // Program.cs : Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            this.Text = "";
            this.ShowIcon = false;
            this.acrylicGroupBox1.ForeColor = Colors.Text;
        }

      
    }
}
