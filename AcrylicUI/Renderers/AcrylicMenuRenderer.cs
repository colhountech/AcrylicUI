using AcrylicUI.Resources;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AcrylicUI.Renderers
{
    public class AcrylicMenuRenderer : ToolStripRenderer
    {
        const int _padding = 1;
        const int _itemPadding = 2;
        const int _line_width = 1;
        const int _seperatorGap = 3;

        #region Initialisation Region

        protected override void Initialize(ToolStrip toolStrip)
        {

            base.Initialize(toolStrip);
            toolStrip.BackColor = Colors.GreyBackground;
            toolStrip.ForeColor = Colors.LightText;
        }

        protected override void InitializeItem(ToolStripItem item)
        {
            base.InitializeItem(item);

            item.BackColor = Colors.GreyBackground;
            item.ForeColor = Colors.LightText;

            if (item.GetType() == typeof(ToolStripSeparator))
            {
                item.Margin = new Padding(0, 0, 0, Scale(_padding));
            }
        }

        #endregion

        #region Render Region

        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            var g = e.Graphics;
            using (var b = new SolidBrush(Colors.GreyBackground))
            {
                g.FillRectangle(b, e.AffectedBounds);
            }
        }

        protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
        {
            var g = e.Graphics;

            var rect = new Rectangle(0, 0, e.ToolStrip.Width - Scale(_padding), e.ToolStrip.Height - Scale(_padding));

            using (var p = new Pen(Colors.LightBorder))
            {
                g.DrawRectangle(p, rect);
            }
        }

        protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e)
        {
            var g = e.Graphics;

            var rect = new Rectangle(e.ImageRectangle.Left - Scale(_itemPadding), e.ImageRectangle.Top - Scale(_itemPadding),
                                         e.ImageRectangle.Width + Scale(_itemPadding * 2), e.ImageRectangle.Height + Scale(_itemPadding * 2));

            using (var b = new SolidBrush(Colors.LightBorder))
            {
                g.FillRectangle(b, rect);
            }

            using (var p = new Pen(Colors.BlueHighlight))
            {
                var modRect = new Rectangle(rect.Left, rect.Top, rect.Width - Scale(_itemPadding), rect.Height - Scale(_itemPadding));
                g.DrawRectangle(p, modRect);
            }

            if (e.Item.ImageIndex == -1 && String.IsNullOrEmpty(e.Item.ImageKey) && e.Item.Image == null)
            {
                g.DrawImageUnscaled(MenuIcons.tick, new Point(e.ImageRectangle.Left, e.ImageRectangle.Top));
            }
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            var g = e.Graphics;

            var rect = new Rectangle(_line_width, Scale(_seperatorGap), e.Item.Width, Scale(_line_width));

            using (var b = new SolidBrush(Colors.LightBorder))
            {
                g.FillRectangle(b, rect);
            }
        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            e.ArrowColor = Colors.LightText;
            e.ArrowRectangle = new Rectangle(new Point(e.ArrowRectangle.Left, e.ArrowRectangle.Top - Scale(_padding)), e.ArrowRectangle.Size);

            base.OnRenderArrow(e);
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            var g = e.Graphics;

            e.Item.ForeColor = e.Item.Enabled ? Colors.LightText : Colors.DisabledText;

            if (e.Item.Enabled)
            {

                var bgColor = e.Item.Selected ? Colors.GreyHighlight : e.Item.BackColor;

                // Normal item
                var rect = new Rectangle(Scale(_itemPadding), 0, e.Item.Width - Scale(_seperatorGap), e.Item.Height);

                using (var b = new SolidBrush(bgColor))
                {
                    g.FillRectangle(b, rect);
                }

                // Header item on open menu
                if (e.Item.GetType() == typeof(ToolStripMenuItem))
                {
                    if (((ToolStripMenuItem)e.Item).DropDown.Visible && e.Item.IsOnDropDown == false)
                    {
                        using (var b = new SolidBrush(Colors.GreySelection))
                        {
                            g.FillRectangle(b, rect);
                        }
                    }
                }
            }
        }

        #endregion

        #region Dpi Scale

        private const float DEFAULT_DPI = 96f;
        protected float _dpiScale = 1;

        // call at init too
        public virtual void UpdateScale(float dpi)
        {
            var newDpiScale = dpi / (float)DEFAULT_DPI;
            if (newDpiScale != _dpiScale)
            {
                _dpiScale = newDpiScale;
            }
        }

        protected virtual int Scale(int pixel)
        {
            return (int)(pixel * _dpiScale);
        }

        #endregion

    }
}
