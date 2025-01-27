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
    public partial class Form11_Labels : AcrylicForm
    {
        public Form11_Labels()
        {
            InitializeComponent();
            // Make sure you set AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // Program.cs : Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            Text = "";
            IsAcrylic = true;
            BackColor = AcrylicUI.Resources.Colors.GreyBackground;
            AutoScaleMode = AutoScaleMode.Dpi;
        }
    }
}
