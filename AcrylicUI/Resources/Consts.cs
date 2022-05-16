using System.Drawing;

namespace AcrylicUI.Resources
{
    public sealed class Consts
    {
        
        // Acrylic Consts
        public const byte DEFAULT_OPACITY = 210;
        public const byte SOLIDGRADIENT = 0xff;

        // Drawing Consts
        public const int DEFULAT_DPI = 96;
        public const int PEN_WIDTH = 1;        
        public const int BUTTON_XOFFSET = 4;
        public const int BUTTON_XOFFSET_PLUS_PEN = BUTTON_XOFFSET + PEN_WIDTH;
        public const int BUTTON_PADDING = 8;
        public const int CONTROL_PADDING = 12;  // use increments of 4, with 12 minimum
        public const int CONTROL_HEIGHT = 24;
        public const int TAB_CLOSE_BUTTON_SIZE = 8;

        // Button
        public const int BUTTON_HEIGHT = 32; // units of 4 or 8
        public const int BUTTON_WIDTH = 160;
        public const int ICON_SIZE = 16;

        public const int ARC_RADIUS = 8;
        public const int SMALL_ARC_RADIUS = 4;

        // Docking Tabls
        
        public static int Padding = 10;

        public static int ScrollBarSize = 15;
        public static int ArrowButtonSize = 15;
        public static int MinimumThumbSize = 11;

        public static int CheckBoxSize = 12;
        public static int RadioButtonSize = 12;

        public const int ToolWindowHeaderSize = 25;
        public const int DocumentTabAreaSize = 24;
        public const int ToolWindowTabAreaSize = 21;



    }

    public sealed class Colors
    {
        public static Color Transparent 
        {
            get { return Color.Transparent; }
        }

        public static Color GreyBackground 
        {
            get { return Color.FromArgb(51, 51, 51); }
        }
        public static Color MediumBackground 
        {
            get { return Color.FromArgb(49, 51, 53); }
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

        public static Color FocusBlueOutline
        {
            get { return Color.FromArgb(28, 137, 255); }
        }
        public static Color FocusWhiteOutline
        {
            get { return Color.FromArgb(126, 126, 126); }
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

        public static Color DarkPanel
        {
            get { return Color.FromArgb(26,28,30); }
        }
        // WindowPanel
        public static Color BlueBackground
        {
            get { return Color.FromArgb(66, 77, 95); }
        }
        public static Color HeaderBackground
        {
            get { return Color.FromArgb(57, 60, 62); }
        }

        public static Color DarkBlueBorder
        {
            get { return Color.FromArgb(51, 61, 78); }
        }
        public static Color DarkBorder
        {
            get { return Color.FromArgb(51, 51, 51); }
        }
        public static Color LightBlueBorder
        {
            get { return Color.FromArgb(86, 97, 114); }
        }
        public static Color LightBorder
        {
            get { return Color.FromArgb(81, 81, 81); }
        }
        public static Color LightText
        {
            get { return Color.FromArgb(220, 220, 220); }
        }
        // Dock Panel

        public static Color BlueSelection
        {
            get { return Color.FromArgb(75, 110, 175); }
        }

        public static Color GreySelection
        {
            get { return Color.FromArgb(92, 92, 92); }
        }
        public static Color DarkBackground
        {
            get { return Color.FromArgb(43, 43, 43); }
        }
        public static Color BlueHighlight
        {
            get { return Color.FromArgb(104, 151, 187); }
        }
        public static Color GreyHighlight
        {
            get { return Color.FromArgb(122, 128, 132); }
        }
        public static Color MontereyPanel
        {
            get { return Color.FromArgb(54, 52, 57); }
        }

        public static Color MontereyInnerPanel 
        { 
            get { return Color.FromArgb(32, 29, 37); }
        }
    }



}
