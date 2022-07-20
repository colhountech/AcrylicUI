using AcrylicUI.Renderers;
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
    }
}
