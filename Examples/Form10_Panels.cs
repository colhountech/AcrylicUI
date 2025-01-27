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
    public partial class Form10_Panels : AcrylicForm
    {
        public Form10_Panels()
        {
            InitializeComponent();
            // Make sure you set AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // Program.cs : Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            Text = "";
            IsAcrylic = true;            
            AutoScaleMode = AutoScaleMode.Dpi;
        }
    }
}
