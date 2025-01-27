using AcrylicUI.Helpers;
using System;
using System.Windows.Forms;

namespace AcrylicUI.Extensions
{
    public static class ControlExtensions
    {
        public static void ApplyDpiScaling(this Control control, Action onDpiChanged)
        {
            control.Resize += (sender, e) => DpiHelper.UpdateScale(control, onDpiChanged);
            DpiHelper.UpdateScale(control, onDpiChanged);
        }

        public static int ScaleDpi(this Control control, int pixel)
        {
            return DpiHelper.Scale(control, pixel);
        }
    }
}