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
    public partial class Form3 : AcrylicUI.Forms.AcrylicForm
    {
        public Form3()
        {
            InitializeComponent();
            this.BlurOpacity = 0xff;
            this.BlurColor = Colors.DarkPanel;

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "";
            var appImage = new IconFactory(IconFactory.GetDpiScale(Handle)).BitmapFromSvg(Icons.Cube_16x_svg);
            var appIcon = Icon.FromHandle(new Bitmap(appImage).GetHicon());

            this.ShowIcon = true;
            this.Icon = appIcon;
            this.BackColor = Colors.DarkPanel;
            this.ForeColor = Colors.Text;
            this.MinimumSize = this.Size;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
            this.acrylicButton1.Image = new IconFactory(IconFactory.GetDpiScale(Handle)).BitmapFromSvg(Icons.Cube_16x_svg);
            this.acrylicButton2.Image = new IconFactory(IconFactory.GetDpiScale(Handle)).BitmapFromSvg(Icons.Cube_16x_svg);

        }
    }
}
