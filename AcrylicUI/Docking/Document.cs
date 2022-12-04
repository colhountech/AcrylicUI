using AcrylicUI.Resources;
using System.ComponentModel;
using System.Drawing;

namespace AcrylicUI.Docking
{
    [ToolboxItem(false)]
    public class Document : DockContent
    {
        #region Property Region

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new DockArea DefaultDockArea
        {
            get { return base.DefaultDockArea; }
        }

        #endregion

        #region Constructor Region

        public Document()
        {
            BackColor = Color.Black;
            base.DefaultDockArea = DockArea.Document;
        }

        #endregion
    }
}
