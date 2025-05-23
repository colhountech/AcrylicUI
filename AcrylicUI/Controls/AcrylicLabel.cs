﻿using AcrylicUI.Resources;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AcrylicUI.Controls
{
    public class AcrylicLabel : Label
    {
        #region Field Region

        private bool _autoUpdateHeight;
        private bool _isGrowing;

        #endregion

        #region Property Region

        [Category("Layout")]
        [Description("Enables automatic height sizing based on the contents of the label.")]
        [DefaultValue(false)]
        public bool AutoUpdateHeight
        {
            get { return _autoUpdateHeight; }
            set
            {
                _autoUpdateHeight = value;

                if (_autoUpdateHeight)
                {
                    AutoSize = false;
                    ResizeLabel();
                }
            }
        }

        [Category("Appearance")]
        [Description("Determines the color of the background.")]
        [DefaultValue(typeof(Color), "0x00FFFFFF")] // Color.Transparent
        public new Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                Invalidate();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public new bool AutoSize
        {
            get { return base.AutoSize; }
            set
            {
                base.AutoSize = value;

                if (AutoSize)
                    AutoUpdateHeight = false;
            }
        }

        #endregion

        #region Constructor Region

        public AcrylicLabel()
        {
            ForeColor = Colors.LightText;
            base.BackColor = Colors.Transparent;
        }

        #endregion

        #region Method Region

     
        private void ResizeLabel()
        {
            if (!_autoUpdateHeight || _isGrowing)
                return;

            try
            {
                _isGrowing = true;
                var sz = new Size(Width, int.MaxValue);
                sz = TextRenderer.MeasureText(Text, Font, sz, TextFormatFlags.WordBreak);
                Height = sz.Height + Padding.Vertical;
            }
            finally
            {
                _isGrowing = false;
            }
        }

        #endregion

        #region Event Handler Region

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            ResizeLabel();
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            ResizeLabel();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            ResizeLabel();
        }

        #endregion
    }
}
