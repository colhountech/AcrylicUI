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
    public partial class Form3_AlertPanel : AcrylicUI.Forms.AcrylicForm
    {
        public Form3_AlertPanel()
        {
            InitializeComponent();
            // Make sure you set AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // Program.cs : Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);

            BlurOpacity = 0xff;
            BackColor = AcrylicUI.Resources.Colors.GreyBackground;

            MaximizeBox = false;
            MinimizeBox = false;
            Text = "";
            var appImage = new IconFactory(IconFactory.GetDpiScale(Handle)).BitmapFromSvg(Icons.Cube_16x_svg);
            var appIcon = Icon.FromHandle(new Bitmap(appImage).GetHicon());

            ShowIcon = true;
            Icon = appIcon;
            BackColor = Colors.DarkPanel;
            ForeColor = Colors.Text;
            MinimumSize = Size;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            
            acrylicButton1.Image = new IconFactory(IconFactory.GetDpiScale(Handle)).BitmapFromSvg(Icons.Cube_16x_svg);
            acrylicButton2.Image = new IconFactory(IconFactory.GetDpiScale(Handle)).BitmapFromSvg(Icons.Cube_16x_svg);

        }
    }
}
