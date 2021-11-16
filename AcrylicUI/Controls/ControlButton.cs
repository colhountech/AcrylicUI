using System.Drawing;

// Copyright (C) ColhounTech Limited. All rights Reserved
// Author: Micheal Colhoun
// Date: Oct 2021
// Based on DarkUI.DarkForm by Robin Perrins


namespace AcrylicUI.Controls
{
    public class ControlButton
    {
        private const int SIZE = 16;
        private Image _icon;
        private Image _iconHot;


        public Image Icon
        {
            get
            {
                return _icon;
            }
            set
            {
                var temp = value;
                // fix width /heightclock

                _icon = value;
            }
        }


        public Image IconHot
        {
            get
            {
                return _iconHot;
            }
            set
            {
                _iconHot = value;
            }
        }


        public Rectangle Rect { get; set; }
        public bool IsHot { get; set; } = false;
        public bool IsPressed { get; set; } = false;
    }
}
