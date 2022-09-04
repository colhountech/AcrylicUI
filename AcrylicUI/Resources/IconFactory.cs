using Svg;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;


namespace AcrylicUI.Resources
{
    public class IconFactory
    {
        private float _dpiScale;

        public IconFactory(float dpiScale)
        {
            _dpiScale = dpiScale;
        }

        public static float GetDpiScale(IntPtr handle)

        {
            return (float)GetDpiForWindow(handle) / (float)Consts.DEFAULT_DPI;
        }


        public int Scale(int pixel)
        {
            return ((int)Math.Ceiling((float)pixel * _dpiScale));
        }

        public Image GreyBitmapFromSvg(byte[] bytes, int width = Consts.ICON_SIZE, int height = Consts.ICON_SIZE)
        {
            var sourceColor = Color.FromArgb(0xff, 0x21, 0x21, 0x21); // Hack for Chrome Close/Min/max/Restore button
            var replaceColor = Colors.DisabledText;

            return NamedColorBitmapFromSvg(bytes, sourceColor, replaceColor, width, height);
        }

        public Image WhiteBitmapFromSvg(byte[] bytes, int width = Consts.ICON_SIZE, int height = Consts.ICON_SIZE)
        {
            var sourceColor = Color.FromArgb(0xff, 0x21, 0x21, 0x21); // Hack for Chrome Close/Min/max/Restore button
            var replaceColor = Color.White;

            return NamedColorBitmapFromSvg(bytes, sourceColor, replaceColor, width, height);
        }

        public Image BlueBitmapFromSvg(byte[] bytes, int width = Consts.ICON_SIZE, int height = Consts.ICON_SIZE)
        {
            var sourceColor = Color.FromArgb(0xff, 0xf6, 0xf6, 0xf6); // // Hack to make white outline GlyphRight_16x to blue
            var replaceColor = Colors.BlueSelection;

            return NamedColorBitmapFromSvg(bytes, sourceColor, replaceColor, width, height);
        }

        public Image DarkColorFromSvg(byte[] bytes,
            string backColorHex = "#FF424242", // fill
            string newBackColorHex = "#FF424242",
            string foreColorHex = "#FFF6F6F6",  // outline
            string newForeColorHex = "#FFF6F6F6",
            int width = Consts.ICON_SIZE, int height = Consts.ICON_SIZE)
        {
            var backColor = Color.FromArgb(GetColorFromHexString(backColorHex));
            var newBackColor = Color.FromArgb(GetColorFromHexString(newBackColorHex));
            var foreColor = Color.FromArgb(GetColorFromHexString(foreColorHex));
            var newForeColor = Color.FromArgb(GetColorFromHexString(newForeColorHex));

            using (var stream = new MemoryStream(bytes))
            {
                var svgDoc = SvgDocument.Open<SvgDocument>(stream, null);
                foreach (Svg.SvgElement item in svgDoc.Children)
                {

                    ChangeFill(item, backColor, newBackColor);
                    ChangeFill(item, foreColor, newForeColor);
                }


                var color = new SvgColourServer(newBackColor);
                svgDoc.Fill = color;
                return svgDoc.Draw(Scale(width), Scale(height));
            }
        }

        private int GetColorFromHexString(string backColorHex)
        {
            if (backColorHex.StartsWith('#'))
            {
                var str = backColorHex.Substring(1);
                return Convert.ToInt32(str, 16);
            }
            return Convert.ToInt32(backColorHex, 16);
        }

        public Image NamedColorBitmapFromSvg(byte[] bytes, Color backColor, Color newBackColor, int width = Consts.ICON_SIZE, int height = Consts.ICON_SIZE)
        {
            using (var stream = new MemoryStream(bytes))
            {
                var svgDoc = SvgDocument.Open<SvgDocument>(stream, null);
                foreach (Svg.SvgElement item in svgDoc.Children)
                {

                    ChangeFill(item, backColor, newBackColor);
                }


                var color = new SvgColourServer(newBackColor);
                svgDoc.Fill = color;
                return svgDoc.Draw(Scale(width), Scale(height));
            }
        }

        private void ChangeFill(SvgElement element, Color sourceColor, Color replaceColor)
        {
            if (element is SvgPath)
            {

                if (((element as SvgPath).Fill as SvgColourServer).Colour.ToArgb() == sourceColor.ToArgb())
                {
                    (element as SvgPath).Fill = new SvgColourServer(replaceColor);
                   // Console.WriteLine($"replaced #{sourceColor.A:X2}{sourceColor.R:X2}{sourceColor.G:X2}{sourceColor.B:X2} with #{replaceColor.A:X2}{replaceColor.R:X2}{replaceColor.G:X2}{replaceColor.B:X2} ");
                }
                else
                {
                    var c = ((element as SvgPath).Fill as SvgColourServer).Colour;
                   // Console.WriteLine($"Didn't replace Color:#{c.A:X2}{c.R:X2}{c.G:X2}{c.B:X2}");
                }
            }

            if (element.Children.Count > 0) // f0eff1 //212121
            {
                foreach (var item in element.Children)
                {
                    ChangeFill(item, sourceColor, replaceColor);
                }
            }
        }

        public Image BitmapFromSvg(byte[] bytes, int width = Consts.ICON_SIZE, int height = Consts.ICON_SIZE)
        {

            using (var stream = new MemoryStream(bytes))
            {
                var svgDoc = SvgDocument.Open<SvgDocument>(stream, null);
                return svgDoc.Draw(Scale(width), Scale(height));
            }
        }

        public Icon IconFromSvg(byte[] bytes, int width = Consts.ICON_SIZE, int height = Consts.ICON_SIZE)
        {
            Image icon = BitmapFromSvg(bytes, Scale(width), Scale(height));
            return Icon.FromHandle(new Bitmap(icon).GetHicon());
        }

        [DllImport("user32.dll")]
        private static extern uint GetDpiForWindow(IntPtr hwnd);

    }
}
