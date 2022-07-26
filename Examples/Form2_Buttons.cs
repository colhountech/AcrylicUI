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
    public partial class Form2_Buttons : AcrylicUI.Forms.AcrylicForm
    {
        public Form2_Buttons()
        {
            InitializeComponent();
            // Make sure you set this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // Program.cs : Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            this.Text = "";
            this.ShowIcon = false;
            this.acrylicGroupBox1.ForeColor = Colors.Text;

            // TextImageRelation = TextImageRelation.ImageBeforeText;
            this.acrylicButton9.SvgIcon = Media.SvgIcons.FolderClosed_16x_svg;           
            this.acrylicButton13.SvgIcon = Media.SvgIcons.FolderClosed_16x_svg;
            this.acrylicButton14.SvgIcon = Media.SvgIcons.FolderClosed_16x_svg;            
            this.acrylicButton15.SvgIcon = Media.SvgIcons.FolderClosed_16x_svg;            
            this.acrylicButton16.SvgIcon = Media.SvgIcons.FolderClosed_16x_svg;

            //// TextImageRelation = TextImageRelation.ImageBeforeText;

            this.acrylicButton17.SvgIcon = Media.SvgIcons.FolderClosed_16x_svg;   
            this.acrylicButton18.SvgIcon = Media.SvgIcons.FolderClosed_16x_svg;   
            this.acrylicButton19.SvgIcon = Media.SvgIcons.FolderClosed_16x_svg;   
            this.acrylicButton20.SvgIcon = Media.SvgIcons.FolderClosed_16x_svg;   
            this.acrylicButton21.SvgIcon = Media.SvgIcons.FolderClosed_16x_svg;

        }


    }
}
