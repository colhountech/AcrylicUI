﻿using AcrylicUI.Forms;
using AcrylicUI.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples
{
    public partial class Form8_Blank : AcrylicForm
    {
        public Form8_Blank()
        {
            InitializeComponent();
            SetupUIDefaults();
            HookEvents();
        }

        private void HookEvents()
        {
            Load += new System.EventHandler(MainWindow_Load);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var dpiScale = IconFactory.GetDpiScale(Handle);
            windowPanel1.Icon = new IconFactory(IconFactory.GetDpiScale(Handle)).BitmapFromSvg(Icons.Cube_16x_svg);
            windowPanel1.SectionHeader = "CT Studio";
           

        }

    }

}

