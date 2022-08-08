using System;
using System.Runtime.InteropServices;

namespace AcrylicUI
{
    public sealed class WinUserH // Winuser.h
    {
        // WM_NCHITTEST message
        // Sent to a window in order to determine what part of the window
        // corresponds to a particular screen coordinate.
        //
        // If the mouse is not captured, the message is sent to the window beneath the cursor.
        // Otherwise, the message is sent to the window that has captured the mouse.
        // 
        // The return value of WM_NCHITTEST message
        // indicating the position of the cursor hot spot.
        public const int WM_NCHITTEST = 0x0084;

        // HTCAPTION = Hit was in a Title Bar
        public static int HT_CAPTION = 0x2;
        // HTCLIENT  = Hit was  in the client area of the window
        public static int HT_CLIENT = 1;

        // HTLEFT = Hit was Left border of a window, allows resize horizontally to the left
        public static IntPtr HT_MAXBUTTON = (IntPtr)09;

        // HTLEFT = Hit was Left border of a window, allows resize horizontally to the left
        public static IntPtr HT_LEFT = (IntPtr)10;
        // HTRIGHT = Hit was ight border of a window, allows resize horizontally to the right
        public static IntPtr HT_RIGHT = (IntPtr)11; 
        // HTTOP= Hit was Upper-horizontal border of a window, allows resize vertically up
        public static IntPtr HT_TOP = (IntPtr)12;   
        // HTTOPLEFT= Hit was Upper-left corner of a window border, allows resize diagonally to the left
        public static IntPtr HT_TOPLEFT = (IntPtr)13;
        // HTTOPRIGHT= Hit was Upper-right corner of a window border, allows resize diagonally to the right
        public static IntPtr HT_TOPRIGHT = (IntPtr)14;
        // HTBOTTOM= Hit was Lower-horizontal border of a window, allows resize vertically down
        public static IntPtr HT_BOTTOM = (IntPtr)15; 
        // HTBOTTOMLEFT = Hit was Lower-left corner of a window border, allows resize diagonally to the left
        public static IntPtr HT_BOTTOMLEFT = (IntPtr)16;
        // HTBOTTOMRIGHT = Hit was Lower-right corner of a window border, allows resize diagonally to the right
        public static IntPtr HT_BOTTOMRIGHT = (IntPtr)17;
        // HT_CLOSE = Hit was In a Close button.
        public static IntPtr HT_CLOSE = (IntPtr)20;


        // HTTRANSPARENT = Hit is Transparent, allow underlying windows to process
        // In a window currently covered by another window in the same thread
        // (the message will be sent to underlying windows in the same thread until
        // one of them returns a code that is not HTTRANSPARENT).
        public static int HT_TRANSPARENT = -1;



        // WM = Window Message
        // NC = Non Client, the part of the window that's not the client area, the borders and the title bar.
        // L = Left button,
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int WM_NCLBUTTONUP = 0xA2;


        // Sent when the size and position of a window's client area must be calculated.
        // By processing this message, an application can control the content of the
        // window's client area when the size or position of the window changes.
        // CALC SIZE = Calculate Size of Client Area
        public const int WM_NCCALCSIZE = 0x0083;


        // A window receives this message when the user chooses a command from the Window menu
        // (formerly known as the system or control menu) or when the user chooses
        // the maximize button, minimize button, restore button, or close button.
        // wParam will be set to one of these.

        public const int WM_SYSCOMMAND = 0x0112;

        // Closes the window.
        public const int SC_CLOSE = 0xF060;

        // Maximizes the window.
        public const int SC_MAXIMIZE = 0xF030;
        // Minimizes the window.
        public const int SC_MINIMIZE = 0xF020; 

        // Restores the window to its normal position and size.
        public const int SC_RESTORE = 0xF120;

        //SendMessage(handle, WM_SYSCOMMAND, SC_RESTORE, 0);


        public static int resizeAreaSize = 10;


        //
        // Show Windows
        //

        public const int SW_RESTORE = 9;
        public const int SW_MAXIMIZE = 3;
        public const int SW_MINIMIZE = 6;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowWindow(IntPtr hWnd, int cmd);

        public const uint WM_CLOSE = 0x0010;

        


        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        public const int WMSZ_BOTTOM = 6;       // Bottom edge
        public const int WMSZ_BOTTOMLEFT = 7;   // Bottom-left corner
        public const int WMSZ_BOTTOMRIGHT = 8;  // Bottom-right corner
        public const int WMSZ_LEFT = 1;         // Left edge
        public const int WMSZ_RIGHT = 2;        // Right edge
        public const int WMSZ_TOP = 3;          // Top edge
        public const int WMSZ_TOPLEFT = 4;      // Top-left corner
        public const int WMSZ_TOPRIGHT = 5;     // Top-right corner

        // Sent one time to a window, after it has exited the moving or sizing modal loop.
        // The window enters the moving or sizing modal loop when the user clicks the
        // window's title bar or sizing border, or when the window passes the WM_SYSCOMMAND message
        // to the DefWindowProc function and the wParam parameter of the message specifies
        // the SC_MOVE or SC_SIZE value. The operation is complete when DefWindowProc returns.


        public const int WM_EXITSIZEMOVE = 0x0232;

    }
}

