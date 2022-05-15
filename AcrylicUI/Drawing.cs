using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace AcrylicUI
{
    public static class Drawing
    {

        public static GraphicsPath RoundedRectange(Rectangle modRect, int radius)
        {
            int d = radius * 2;
            Size size = new(d, d);
            Rectangle arc = new(modRect.Location, size);
            GraphicsPath path = new();
            if (radius == 0)
            {
                path.AddRectangle(modRect);
                return path;
            }
            // top left arc
            path.AddArc(arc, 180, 90);

            // top right arc
            arc.X = modRect.Right - d;
            path.AddArc(arc, 270, 90);

            // bottom right arc
            arc.Y = modRect.Bottom - d;
            path.AddArc(arc, 0, 90);

            //bottom left arc
            arc.X = modRect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();

            return path;
        }


        public static GraphicsPath RoundedBottomCorners(Rectangle modRect, int radius)
        {
            int d = radius * 2;
            Size size = new(d, d);
            Rectangle arc = new(modRect.Location, size);
            GraphicsPath path = new();
            if (radius == 0)
            {
                path.AddRectangle(modRect);
                return path;
            }
            // top left corner
           // var topLeft = arc.Location;
            //var topRight = topLeft.Offset(modRect.Width, 0);


            //path.AddLine(arc.Location, arc.Location.Offset( )
            //// top left arc
            //path.AddArc(arc, 180, 90);

            //// top right arc
            //arc.X = modRect.Right - d;
            //path.AddArc(arc, 270, 90);

            // bottom right arc
            arc.Y = modRect.Bottom - d;
            path.AddArc(arc, 0, 90);

            //bottom left arc
            arc.X = modRect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();

            return path;
        }


        public static uint GetDpi(IntPtr hwnd)
        {
            return GetDpiForWindow(hwnd);
        }

        [DllImport("user32.dll")]
        private static extern uint GetDpiForWindow(IntPtr hwnd);


    }
}
