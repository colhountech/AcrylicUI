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
    public partial class Form9_BlankGlass : AcrylicUI.Forms.AcrylicForm
    {
        public Form9_BlankGlass()
        {
            InitializeComponent();
            // Make sure you set this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // Program.cs : Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            SetupUIDefaults();

        }

        private void SetupUIDefaults()
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BlurOpacity = 10;
            this.BackColor = Colors.GreyBackground;            
            this.Icon = new IconFactory(IconFactory.GetDpiScale(Handle)).IconFromSvg(Icons.Cube_16x_svg);
            this.Text = "";
        }
    }
}
