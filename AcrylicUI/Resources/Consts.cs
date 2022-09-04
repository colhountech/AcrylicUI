using System.Drawing;

namespace AcrylicUI.Resources
{
    public sealed class Consts
    {

        // Acrylic Consts
        public const byte DEFAULT_OPACITY = 210;
        public const byte SOLIDGRADIENT = 0xff;

        // Drawing Consts
        public const int DEFAULT_DPI = 96;
        public const int PEN_WIDTH = 1;
        public const int BUTTON_XOFFSET = 4;
        public const int BUTTON_XOFFSET_PLUS_PEN = BUTTON_XOFFSET + PEN_WIDTH;
        public const int BUTTON_PADDING = 8;
        public const int CONTROL_PADDING = 12;  // use increments of 4, with 12 minimum
        public const int CONTROL_HEIGHT = 36;
        public const int LISTITEM_HEIGHT = 32;
        public const int LISTITEM_PADDING = 6;
        public const int LISTITEM_OFFSET = 12;
        public const int CONTROL_BUTTON_PADDING = 5;
        public const int CONTROL_BUTTON_XOFFSET = 3;
        public const int CONTROL_BUTTON_XOFFSET_PLUS_PEN = CONTROL_BUTTON_XOFFSET + PEN_WIDTH;

        public const int TAB_CLOSE_BUTTON_SIZE = 8;

        // Button
        public const int BUTTON_HEIGHT = 32; // units of 4 or 8
        public const int BUTTON_WIDTH = 160;
        public const int ICON_SIZE = 16;

        public const int ARC_RADIUS = 8;
        public const int SMALL_ARC_RADIUS = 4;
        public const int TINY_ARC_RADIUS = 2;

        // Docking Tabls / Dialogs

        public static int Padding = 10;
        public const int ImagePadding = 5;

        //

        public static int ScrollBarSize = 15;
        public static int ArrowButtonSize = 15;
        public static int MinimumThumbSize = 11;

        public static int CheckBoxSize = 12;
        public static int RadioButtonSize = 12;

        public const int ToolWindowHeaderSize = 24;
        public const int DocumentTabAreaSize = 24;
        public const int ToolWindowTabAreaSize = 21;



    }
    //  Color.FromArgb(0xff, 0x42, 0x42, 0x42)
    public sealed class Colors
    {
        public static Color Transparent
        {
            get { return Color.Transparent; }
        }

        public static Color GreyBackground
        {
            get { return Color.FromArgb(31, 31, 31); }
        }

        // Acrylic Title Label

        public static Color AcrylicDropShadow
        {
            get { return Color.FromArgb(10, 31, 31, 31); } // Dark Border, low opacity
        }


        //  Acrylc Glass Panels

        public static Color AcrylicOuterPanel
        {
            get { return Color.FromArgb(40, 88, 88, 88); }
        }
        public static Color AcrylicInnerPanel
        {
            get { return Color.FromArgb(90, 88, 88, 88); }
        }

        public static Color AcrylicHairline
        {
            get { return Color.FromArgb(99, 99, 99, 99); }
        }

        public static Color HeaderBackground
        {
            get { return Color.FromArgb(41, 40, 42); } //57, 60, 62
        }

        public static Color DefaulBlueButtonFill
        {
            get { return Color.FromArgb(26, 82, 170); }
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
            get { return Color.FromArgb(245, 245, 245); }
        }
        public static Color LightText
        {
            get { return Color.FromArgb(192, 192, 192); } // Gainsboro 220, White Smoke 245
        }
        public static Color DisabledText
        {
            get { return Color.FromArgb(126, 126, 126); } // Silver 192
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
            get { return Color.FromArgb(60, 60, 60); }
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

        public static Color GreyShadow
        {
            get { return Color.FromArgb(0xff, 0x42, 0x42, 0x42); }
        }

        public static Color DarkPanel
        {
            get { return Color.FromArgb(26, 28, 30); }
        }


        public static Color DarkBorder
        {
            get { return Color.FromArgb(51, 51, 51); }
        }

        public static Color LightBorder
        {
            get { return Color.FromArgb(81, 81, 81); }
        }

        // WindowPanel
        public static Color BlueBackground
        {
            get { return Color.FromArgb(63, 61, 61); } //66, 77, 95
        }

        public static Color DarkBlueBorder
        {
            get { return Color.FromArgb(48, 46, 43); } // 51, 61, 78
        }

        public static Color LightBlueBorder
        {
            get { return Color.FromArgb(83, 81, 80); } // 86, 97, 114
        }


        // Dock Panel

        public static Color BlueSelection
        {
            get { return Color.FromArgb(75, 110, 175); }
        }

        public static Color DarkGreySelection
        {
            get { return Color.FromArgb(82, 82, 82); }
        }

        public static Color DarkBackground
        {
            get { return Color.FromArgb(43, 43, 43); }
        }
        public static Color MediumBackground
        {
            get { return Color.FromArgb(49, 51, 53); }
        }

        public static Color LightBackground
        {
            get { return Color.FromArgb(69, 73, 74); }
        }

        public static Color LighterBackground
        {
            get { return Color.FromArgb(95, 101, 102); }
        }

        public static Color LightestBackground
        {
            get { return Color.FromArgb(178, 178, 178); }
        }
        public static Color BlueHighlight
        {
            get { return Color.FromArgb(104, 151, 187); }
        }
        public static Color GreyHighlight
        {
            get { return Color.FromArgb(61, 61, 61); }
        }
        public static Color GreySelection
        {
            get { return Color.FromArgb(46, 46, 46); }
        }
        public static Color MontereyPanel
        {
            get { return Color.FromArgb(54, 52, 57); }
        }

        public static Color MontereyInnerPanel
        {
            get { return Color.FromArgb(32, 29, 37); }
        }
        public static Color ActiveControl
        {
            // get { return Color.FromArgb(159, 178, 196); }
            get { return Color.FromArgb(54, 52, 57); } //             MontereyPanel
        }

        // New Colors
        public static Color TitleBarActive // Not used
        {
            get { return Color.FromArgb(0x38, 0x2E, 0x37); } //Brown ~Valentino
        }

        public static Color TitleBarInActive // Not used
        {
            get { return Color.FromArgb(55, 46, 55); } //RedderBrown
        }
        public static Color InnerBorder // Not used
        {
            get { return Color.FromArgb(115, 109, 115); } // LightGrey
        }
        public static Color OuterBorder // Not used
        {
            get { return Color.FromArgb(23, 23, 23); } //  DarkOutline
        }
        public static Color SideDockBackground // Not used
        {
            get { return Color.FromArgb(0x25, 0x28, 0x2e); } //   #  More Blue Tints in Brown, ~Bunker (#292C2F)
        }
        public static Color SideDockHeader // Not used
        {
            get { return Color.FromArgb(0x14, 0x14, 0x14); } //   #141414 Eerie Black
        }
        public static Color SideDockInactiveHeader // Not used
        {
            get { return Color.FromArgb(0x14, 0x14, 0x14); } //   #141414 Eerie Black
        }
        public static Color EmptyDesktop // Not used
        {
            get { return Color.FromArgb(0x26, 0x26, 0x26); } //    #262626  Grey15
        }
        // Document Colors
        public static Color DocumentBackcolor
        {
            get { return Color.FromArgb(0x1e, 0x1e, 0x1e); } //    #1E1E1E (~ Nero #252525)
        }
        public static Color DocumentTitleTab           // Not used
        {
            get { return Color.FromArgb(0x1c, 0x1c, 0x1c); } //     #1C1C1C (~ Nero #252525)
        }
        public static Color DocumentTextColor           // Not used
        {
            get { return Color.FromArgb(0xdc, 0xdc, 0xdc); } //      #DCDCDC (Gainsboro)
        }
        public static Color DocumentGreenText           // Not used
        {
            get { return Color.FromArgb(0x54, 0xc8, 0xb0); } //      #54C8B0 (#59BAA3 Puerto Rico)
        }
        public static Color DocumentBlueText           // Not used
        {
            get { return Color.FromArgb(0x58, 0x9C, 0xD3); } //      #589CD3 (#5BA0D0 Picton Blue)
        }
        public static Color DocumentRedText           // Not used
        {
            get { return Color.FromArgb(0xD6, 0x4F, 0x51); } //      #D64F51(#CD525B Mandy)
        }
        public static Color DocumentScrollbar           // Not used
        {
            get { return Color.FromArgb(0x30, 0x30, 0x30); }
        }
        public static Color ConsoleText // Not used
        {
            get { return Color.FromArgb(0x19, 0x19, 0x19); }
        }
        public static Color StatusText // Not used
        {
            get { return Color.FromArgb(0x89, 0x89, 0x89); } //  ~ #8B8685 Suva Grey
        }
        // DataGrid
        public static Color DataGridTitleBar
        {
            get { return Color.FromArgb(0x2D, 0x24, 0x2D); } //  #2D242D ~Mardi Gras (#352225)
        }
        public static Color DataGridEvenRow
        {
            get { return Color.FromArgb(0x2f, 0x25, 0x2e); } //  #2f252e   ~Mardi Gras (#352225)
        }
        public static Color DataGridOddRow
        {
            get { return Color.FromArgb(0x39, 0x2F, 0x38); } //  #392F38  ~Valentino (#382C38)
        }
        public static Color DataGridTitleText // Not used
        {
            get { return Color.FromArgb(0xff, 0xff, 0xff); } //  White
        }
        public static Color DataGridRowText
        {
            get { return Color.FromArgb(0xDF, 0xDE, 0xDF); } //  #DFDEDF  ~Snuff but less pink
        }
        public static Color DataGridSelectionBackground
        {
            get { return Color.FromArgb(0x71, 0x6A, 0x70); } //  Gradient Light #716A70 (~Old Lavender) to Dark #574F56 (~Purple Taupe #50404D)
        }
        public static Color DataGridSelectedText
        {
            get { return Color.FromArgb(0xDC, 0xEA, 0xF7); } //  (white) #DCEAF7
        }
        public static Color DataGridSelectionFocussedBackground
        {
            get { return Color.FromArgb(0x20, 0x7B, 0xDD); } //  #207BDD (~ Dodger Blue)
        }
        public static Color DataGridDrag
        {
            get { return Color.FromArgb(0xD3, 0xD3, 0xD3); } //  LightGray
        }

    }



}
