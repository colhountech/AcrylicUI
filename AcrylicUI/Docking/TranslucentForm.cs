using System.Drawing;
using System.Windows.Forms;

namespace AcrylicUI.Docking
{
    internal class TranslucentForm : Form
    {
        #region Property Region

        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }

        #endregion

        #region Constructor Region

        public TranslucentForm(Color backColor, double opacity = 0.6)
        {
            StartPosition = FormStartPosition.Manual;
            FormBorderStyle = FormBorderStyle.None;
            Size = new Size(1, 1);
            ShowInTaskbar = false;
            AllowTransparency = true;
            Opacity = opacity;
            BackColor = backColor;
        }

        #endregion
    }
}
