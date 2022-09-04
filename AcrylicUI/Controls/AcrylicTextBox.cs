using AcrylicUI.Resources;
using System;
using System.Windows.Forms;

namespace AcrylicUI.Controls
{
    public partial class AcrylicTextBox : TextBox
    {
        public AcrylicTextBox()
        {
            BackColor = Colors.DarkGrey;
            ForeColor = Colors.Text;
            Padding = new Padding(Scale(Consts.BUTTON_PADDING));
            BorderStyle = BorderStyle.FixedSingle;
        }
        #region Dpi Scale

        private const float DEFAULT_DPI = 96f;
        private float _dpiScale = 1;

        // call at init too
        private void UpdateScale()
        {
            var form = FindForm();
            if (form is null)
            {

            }
            var handle = form?.Handle ?? this.Handle;

            var newDpiScale = (float)Drawing.GetDpi(handle) / (float)DEFAULT_DPI;
            if (newDpiScale != _dpiScale)
            {
                _dpiScale = newDpiScale;

                // TODO
                // update Icons
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateScale();
        }
        private int Scale(int pixel)
        {
            return (int)(pixel * _dpiScale);
        }

        #endregion
    }
}
