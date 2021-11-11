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
    public partial class Form4 : AcrylicUI.Forms.AcrylicForm
    {
        public Form4()
        {
            InitializeComponent();
            this.BlurOpacity = 1;
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

            // 10 minutes

            // Snooze
            this.acrylicButton1.Image = new IconFactory(IconFactory.GetDpiScale(Handle)).BitmapFromSvg(Icons.Cube_16x_svg);
            // Dismiss
            this.acrylicButton3.Image = new IconFactory(IconFactory.GetDpiScale(Handle)).BitmapFromSvg(Icons.Cube_16x_svg);



        }
    }
}
