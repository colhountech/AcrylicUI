using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace AcrylicUI
{
    public static class WinProcExtentsions
    {
        /// <summary>
        /// Sends the specified message to a window or windows. 
        /// The SendMessage function calls the window procedure for the specified window 
        /// and does not return until the window procedure has processed the message.
        /// </summary>
        /// <param name="hWnd">A handle to the window whose window procedure will receive the message</param>
        /// <param name="Msg">The message to be sent. E.g. WM_NCLBUTTONDOWN</param>
        /// <param name="wParam">e.g. HT_CAPTION</param>
        /// <param name="lParam">e.g. 0</param>
        /// <returns></returns>
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                        int Msg, int wParam, int lParam);

        /// <summary>
        /// Releases the mouse capture from a window in the current thread and 
        /// restores normal mouse input processing. 
        /// 
        /// A window that has captured the mouse ( with SetCapture ) receives 
        /// all mouse input, of the position of the cursor, except when a mouse button
        /// is clicked while the cursor hot spot is in the window of another thread.
        /// 
        /// An application calls this function after calling the SetCapture function.
        ///
        /// </summary>
        /// <returns></returns>
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public static void TitleBarHit(IntPtr handle)
        {

            ReleaseCapture();
            SendMessage(handle, WinUserH.WM_NCLBUTTONDOWN, WinUserH.HT_CAPTION, 0);
        }


        private const int _ = 12; // Grip Size

        public static Rectangle Top(this Size clientSize)
        {
            return new Rectangle(0, 0, clientSize.Width, _);
        }

        public static Rectangle Left(this Size clientSize)
        {
            return new Rectangle(0, 0, _, clientSize.Height);
        }


        public static Rectangle Bottom(this Size clientSize)
        {
            return new Rectangle(0, clientSize.Height - _, clientSize.Width, _);
        }



        public static Rectangle Right(this Size clientSize)
        {
            return new Rectangle(clientSize.Width - _, 0, _, clientSize.Height);
        }

        public static Rectangle TopLeft(this Size clientSize)
        {

            return new Rectangle(0, 0, _, _);
        }

        public static Rectangle TopRight(this Size clientSize)
        {
            return new Rectangle(clientSize.Width - _, 0, _, _);
        }

        public static Rectangle BottomLeft(this Size clientSize)
        {
            return new Rectangle(0, clientSize.Height - _, _, _);
        }

        public static Rectangle BottomRight(this Size clientSize)
        {
            return new Rectangle(clientSize.Width - _, clientSize.Height - _, _, _);
        }
    }

}
