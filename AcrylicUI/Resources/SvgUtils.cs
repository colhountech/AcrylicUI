using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using Svg;


namespace AcrylicUI.Resources
{
    public class SvgUtils
    {
        private float _dpiScale;

        public SvgUtils(float dpiScale)
        {
            _dpiScale = dpiScale;
        }

        public static float GetDpiScale(IntPtr handle)

        {
            return (float)GetDpiForWindow(handle) / (float) Consts.DEFULAT_DPI;
        }


        public  int Scale (int pixel)
        {
            return (int)((float)pixel * _dpiScale);
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



        public Image NamedColorBitmapFromSvg(byte[] bytes, Color sourceColor, Color replaceColor, int width, int height )
        {
            using (var stream = new MemoryStream(bytes))
            {
                var svgDoc = SvgDocument.Open<SvgDocument>(stream, null);
                foreach (Svg.SvgElement item in svgDoc.Children)
                {

                    ChangeFill(item, sourceColor, replaceColor);
                }


                var color = new SvgColourServer(replaceColor);
                svgDoc.Fill = color;
                return svgDoc.Draw(Scale(width), Scale(height));
            }
        }

        private  void ChangeFill(SvgElement element, Color sourceColor, Color replaceColor)
        {
            if (element is SvgPath)
            {
                // {#f6f6f6} // 424242 f0eff1
                if (((element as SvgPath).Fill as SvgColourServer).Colour.ToArgb() == sourceColor.ToArgb())
                {
                    (element as SvgPath).Fill = new SvgColourServer(replaceColor);
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

        public  Image BitmapFromSvg(byte[] bytes, int width = Consts.ICON_SIZE, int height = Consts.ICON_SIZE)
        {

            using (var stream = new MemoryStream(bytes))
            {
                var svgDoc = SvgDocument.Open<SvgDocument>(stream, null);
                return svgDoc.Draw( Scale(width), Scale(height));
            }
        }


        [DllImport("user32.dll")]
        private static extern uint GetDpiForWindow(IntPtr hwnd);

    }
}
