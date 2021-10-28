using System.Drawing;

namespace AcrylicUI.Resources
{
    public sealed class Consts
    {
        
        // Acrylic Consts
        public const byte DEFAULT_OPACITY = 210;
        public const byte SOLIDGRADIENT = 0xff;

        // Drawing Consts
        public const int PEN_WIDTH = 1;        
        public const int BUTTON_XOFFSET = 4;
        public const int BUTTON_XOFFSET_PLUS_PEN = BUTTON_XOFFSET + PEN_WIDTH;
        public const int BUTTON_PADDING = 8;
        public const int CONTROL_PADDING = 12;  // use increments of 4, with 12 minimum
        public const int CONTROL_HEIGHT = 24;
        public const int ARC_RADIUS = 8;
        public const int SMALL_ARC_RADIUS = 4;

        

    }

    public sealed class Colors
    {
        public static Color GreyBackground // Blur Background
        {
            get { return Color.FromArgb(62, 58, 60); }
        }
        public static Color DefaulBlueButtonFill 
        {
            get { return Color.FromArgb(26,82,170); }
        }
        public static Color DefaulBlueButtonPressedFill 
        {
            get { return Color.FromArgb(23, 72, 150); }
        }
        public static Color DefaulBlueButtonPressedText 
        {
            get { return Color.FromArgb(185, 185, 185); }
        }

        public static Color IconColor // Color of Blue Icon
        {
            get { return Color.FromArgb(28, 137, 255); }
        }

        // Normal Buttons
        public static Color Text //  Label Font Color
        {
            get { return Color.FromArgb(235, 235, 235); }
        }
        public static Color DisabledText
        {
            get { return Color.FromArgb(126, 126, 126); }
        }
        public static Color DisabledFill
        {
            get { return Color.FromArgb(52, 52, 52); }
        }

        public static Color DisabledOutline
        {
            get { return Color.FromArgb(58, 58, 58); }
        }


        public static Color BtnOutline
        {
            get { return Color.FromArgb(69, 69, 69); }
        }

        public static Color BtnFill 
        {
            get { return Color.FromArgb(55, 55, 55); } 
        }

        public static Color BtnHotFill 
        {
            get { return Color.FromArgb(60,60,60); }
        }
        public static Color BtnHotOutline
        {
            get { return Color.FromArgb(74, 74, 74); }
        }
        public static Color BtnPressedFill 
        {
            get { return Color.FromArgb(52, 48, 48); }
        }
        public static Color BtnPressedOutline
        {
            get { return Color.FromArgb(68, 63, 64); }
        }

        public static Color DarkGrey
        {
            get { return Color.FromArgb(43, 43, 43); }
        }

        public static Color MediumGrey
        {
            get { return Color.FromArgb(49, 51, 53); }
        }

        public static Color LightGrey
        {
            get { return Color.FromArgb(69, 73, 74); }
        }


    }



}
