using System;
using System.Runtime.InteropServices;

namespace AcrylicUI.Platform.Windows
{
    public class Win32Hacks
    {
        #region Windows DarkTheme Hack

        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        public static void DarkThemeTitleBar(IntPtr hwnd)
        {
            if (DwmSetWindowAttribute(hwnd, 19, new[] { 1 }, 4) != 0)
            {
                DwmSetWindowAttribute(hwnd, 20, new[] { 1 }, 4);
            }
        }
        #endregion


        #region Animate Window Hacks

        [DllImport("user32.dll")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);

        public static void AnimateShow(IntPtr hwnd)
        {
            AnimateWindow(hwnd, 200, AnimateWindowFlags.AW_SLIDE | AnimateWindowFlags.AW_VER_NEGATIVE | AnimateWindowFlags.AW_ACTIVATE);
        }

        public static void AnimateHide(IntPtr hwnd)
        {
            AnimateWindow(hwnd, 200, AnimateWindowFlags.AW_SLIDE | AnimateWindowFlags.AW_VER_POSITIVE | AnimateWindowFlags.AW_HIDE);
        }

        enum AnimateWindowFlags : uint
        {
            AW_HOR_POSITIVE = 0x00000001,
            AW_HOR_NEGATIVE = 0x00000002,
            AW_VER_POSITIVE = 0x00000004,
            AW_VER_NEGATIVE = 0x00000008,
            AW_CENTER = 0x00000010,
            AW_HIDE = 0x00010000,
            AW_ACTIVATE = 0x00020000,
            AW_SLIDE = 0x00040000,
            AW_BLEND = 0x00080000
        }

        #endregion
    }
}