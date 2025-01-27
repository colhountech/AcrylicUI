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
            // Make sure you set AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // Program.cs : Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            Text = "";
            ShowIcon = false;
            acrylicGroupBox1.ForeColor = Colors.Text;

            // TextImageRelation = TextImageRelation.ImageBeforeText;
            acrylicButton9.SvgIcon = Media.SvgIcons.FolderClosed_16x_svg;           
            acrylicButton13.SvgIcon = Media.SvgIcons.FolderClosed_16x_svg;
            acrylicButton14.SvgIcon = Media.SvgIcons.FolderClosed_16x_svg;            
            acrylicButton15.SvgIcon = Media.SvgIcons.FolderClosed_16x_svg;            
            acrylicButton16.SvgIcon = Media.SvgIcons.FolderClosed_16x_svg;

            //// TextImageRelation = TextImageRelation.ImageBeforeText;

            acrylicButton17.SvgIcon = Media.SvgIcons.FolderClosed_16x_svg;   
            acrylicButton18.SvgIcon = Media.SvgIcons.FolderClosed_16x_svg;   
            acrylicButton19.SvgIcon = Media.SvgIcons.FolderClosed_16x_svg;   
            acrylicButton20.SvgIcon = Media.SvgIcons.FolderClosed_16x_svg;   
            acrylicButton21.SvgIcon = Media.SvgIcons.FolderClosed_16x_svg;

        }


    }
}
