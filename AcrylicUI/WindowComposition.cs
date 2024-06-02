using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AcrylicUI
{
    public class WindowComposition
    {
        public static void EnableAcrylic(IWin32Window window, Color blurColor)
        {
            if (window is null)
                throw new ArgumentNullException(nameof(window));

            var accentPolicy = new AccentPolicy
            {
                AccentState = ACCENT.ENABLE_ACRYLICBLURBEHIND,
                GradientColor = ToAbgr(blurColor)
            };
            if (blurColor.A == 0xff)
            {
                accentPolicy.AccentState = ACCENT.ENABLE_GRADIENT;
                //accentPolicy.AccentState = ACCENT.DISABLED;
            }
            unsafe
            {
                SetWindowCompositionAttribute(new HandleRef(window, window.Handle), new WindowCompositionAttributeData
                {
                    Attribute = WCA.ACCENT_POLICY,
                    Data = &accentPolicy,
                    DataLength = Marshal.SizeOf<AccentPolicy>()
                });
            }
        }
        [Flags]
        public enum DWMWINDOWATTRIBUTE
        {
            DWMWA_USE_IMMERSIVE_DARK_MODE= 20,
            DWMWA_SYSTEMBACKDROP_TYPE= 38
        }

        public enum BlurMode
        {
            None = 1,
            Acrylic = 3,
            Mica = 2,
            Tabbed = 4
        }

        public static void SetWindowBlur(IntPtr handle, int color, BlurMode mode)
        {
            SetWindowAttribute(
                handle,
                DWMWINDOWATTRIBUTE.DWMWA_USE_IMMERSIVE_DARK_MODE,
                color);
            SetWindowAttribute(
                handle,
                DWMWINDOWATTRIBUTE.DWMWA_SYSTEMBACKDROP_TYPE,
                (int)mode);
        }

        public static void EnableMica(IntPtr handle, Color blurColor)
        {
            int color = blurColor.ToArgb(); ;

            SetWindowBlur(handle, color, BlurMode.Mica);
        }

        private static uint ToAbgr(Color color)
        {
            return ((uint)color.A << 24)
                | ((uint)color.B << 16)
                | ((uint)color.G << 8)
                | color.R;
        }

        [DllImport("dwmapi.dll")]
        static extern int DwmSetWindowAttribute(IntPtr hwnd, DWMWINDOWATTRIBUTE dwAttribute, ref int pvAttribute, int cbAttribute);

        [DllImport("user32.dll")]
        private static extern int SetWindowCompositionAttribute(HandleRef hWnd, in WindowCompositionAttributeData data);
        public static int SetWindowAttribute(IntPtr hwnd, DWMWINDOWATTRIBUTE attribute, int parameter)
           => DwmSetWindowAttribute(hwnd, attribute, ref parameter, Marshal.SizeOf<int>());
        private unsafe struct WindowCompositionAttributeData
        {
            public WCA Attribute;
            public void* Data;
            public int DataLength;
        }

        private enum WCA
        {
            ACCENT_POLICY = 19
        }

        private enum ACCENT
        {
            DISABLED = 0,
            ENABLE_GRADIENT = 1,
            ENABLE_TRANSPARENTGRADIENT = 2,
            ENABLE_BLURBEHIND = 3,
            ENABLE_ACRYLICBLURBEHIND = 4,
            INVALID_STATE = 5
        }

        private struct AccentPolicy
        {
            public ACCENT AccentState;
            public uint AccentFlags;
            public uint GradientColor;
            public uint AnimationId;

        }
    }
}
