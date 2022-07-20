using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using Svg;


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
            return (float)GetDpiForWindow(handle) / (float) Consts.DEFULAT_DPI;
        }


        public  int Scale (int pixel)
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



        public Image NamedColorBitmapFromSvg(byte[] bytes, Color sourceColor, Color replaceColor, int width = Consts.ICON_SIZE, int height = Consts.ICON_SIZE)
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
                //var c = ((element as SvgPath).Fill as SvgColourServer).Colour;
                //Console.WriteLine($"Color:#{c.R:X2}{c.G:X2}{c.B:X2}");
                // # Color:#F6F6F6    Color:#F6F6F6   Color:#424242

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

        public Icon IconFromSvg(byte[] bytes, int width = Consts.ICON_SIZE, int height = Consts.ICON_SIZE)
        {
            Image icon  = BitmapFromSvg(bytes, Scale(width), Scale(height));
            return Icon.FromHandle(new Bitmap(icon).GetHicon());            
        }

        [DllImport("user32.dll")]
        private static extern uint GetDpiForWindow(IntPtr hwnd);

    }
}
