using AcrylicUI.Renderers;
using System;
using System.Windows.Forms;

namespace AcrylicUI.Controls
{
    public class AcrylicMenuStrip : MenuStrip
    {
        #region Constructor Region

        public AcrylicMenuStrip()
        {
            Renderer = new AcrylicMenuRenderer();
            Padding = new Padding(3, 2, 0, 2);
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
                (Renderer as AcrylicMenuRenderer)?.UpdateScale(dpi);

            }

        }
        #endregion
    }
}
