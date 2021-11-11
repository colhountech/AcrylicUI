using AcrylicUI.Renderers;
using System.Windows.Forms;

namespace AcrylicUI.Controls
{
    public class AcrylicContextMenu : ContextMenuStrip
    {
        #region Constructor Region

        public AcrylicContextMenu()
        {
            Renderer = new AcrylicMenuRenderer();
        }

        #endregion
    }
}
