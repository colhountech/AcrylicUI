using AcrylicUI.Renderers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AcrylicUI.Controls
{
    public class AcrylicToolStrip : ToolStrip
    {
        #region Constructor Region

        public AcrylicToolStrip()
        {
            Renderer = new AcrylicToolStripRenderer();
            Padding = new Padding(5, 0, 1, 0);
            AutoSize = false;
            Size = new Size(1, 28);
        }

        #endregion

        #region Dpi Scale
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateScale();
        }

        private void UpdateScale()
        {
            var form = FindForm();
            var handle = form?.Handle ?? this.Handle;

            var dpi = (float)Drawing.GetDpi(handle);
            if (dpi > 0)
            {
                (Renderer as AcrylicToolStripRenderer)?.UpdateScale(dpi);

            }

        }
        #endregion

    }
}
