using AcrylicUI.Renderers;
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
    }
}
