using AcrylicUI.Resources;
using System.Drawing;
using System.Windows.Forms;

namespace AcrylicUI.Controls
{
    public static class TextBlurExtentions
    {
        /// <summary>
        /// Simulate gausian blur. 
        /// TODO: Needs Scaling
        /// </summary>
        /// <param name="label"></param>
        /// <param name="g"></param>
        /// <param name="textSize"></param>
        /// <param name="height"></param>
        public static void DrawTextBlur(this Control control, Rectangle rect, Graphics g, string text, Font font)
        {

            var blurColor = new SolidBrush(Colors.AcrylicDropShadow);
            var textSize = g.MeasureString(text, font);

            if (textSize.Height > 3) SubBlur(g, textSize, 3);
            if (textSize.Height > 5) SubBlur(g, textSize, 5);
            if (textSize.Height > 8) SubBlur(g, textSize, 8);
            if (textSize.Height > 12) SubBlur(g, textSize, 12);
            //if (textSize.Height > 14) SubBlur(g, textSize, 14);

            void SubBlur(Graphics g, SizeF textSize, float height)
            {
                var offset = (rect.Height - height) / 2;
                var blurRect = new Rectangle(rect.X, rect.Y + (int)(offset + 2), (int)(textSize.Width - offset - 1), (int)height);
                var rectRounded = Drawing.RoundedRectange(blurRect, Consts.TINY_ARC_RADIUS);
                g.FillPath(blurColor, rectRounded);
            }
        }


    }
}
