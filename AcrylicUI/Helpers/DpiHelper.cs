using System;
using System.Windows.Forms;

namespace AcrylicUI.Helpers
{
    public static class DpiHelper
    {
        private const float DEFAULT_DPI = 96f;

        public static float GetDpiScale(Control control)
        {
            var form = control.FindForm();
            var handle = form?.Handle ?? control.Handle;
            return (float)Drawing.GetDpi(handle) / DEFAULT_DPI;
        }

        public static int Scale(Control control, int pixel)
        {
            var dpiScale = GetDpiScale(control);
            return (int)(pixel * dpiScale);
        }

        public static void UpdateScale(Control control, Action onDpiChanged)
        {
            var dpiScale = GetDpiScale(control);
            onDpiChanged?.Invoke();
        }
    }
}
