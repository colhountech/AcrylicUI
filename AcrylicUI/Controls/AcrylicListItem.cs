using AcrylicUI.Resources;
using System;
using System.Drawing;

namespace AcrylicUI.Controls
{
    public class AcrylicListItem
    {
        #region Event Region

        public event EventHandler TextChanged;

        #endregion

        #region Field Region

        private string _text;

        #endregion

        #region Property Region

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;

                if (TextChanged != null)
                    TextChanged(this, new EventArgs());
            }
        }

        public Rectangle Area { get; set; }

        public Color TextColor { get; set; }

        public FontStyle FontStyle { get; set; }

        public Bitmap Icon { get; set; }

        public object Tag { get; set; }

        #endregion

        #region Constructor Region

        public AcrylicListItem()
        {
            TextColor = Colors.LightText;
            FontStyle = FontStyle.Regular;
        }

        public AcrylicListItem(string text)
            : this()
        {
            Text = text;
        }
        public AcrylicListItem(string text, Icon icon)
          : this()
        {
            Text = text;
            Icon = Icon;
        }
        #endregion
    }
}