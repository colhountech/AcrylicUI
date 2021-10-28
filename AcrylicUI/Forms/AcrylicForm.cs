using AcrylicUI.Resources;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace AcrylicUI.Forms
{
    public partial class AcrylicForm : Form
    {
        #region Field Region

        private Color _blurColor = Colors.GreyBackground;
        private byte _blurOpacity = Consts.DEFAULT_OPACITY;

        #endregion


        #region Constructor Region

        public AcrylicForm()
        {
            InitializeComponent();
        }

        #endregion


        #region Property Region



        [Category("Appearance")]
        [Description("Determines the blur background color.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BlurColor
        {
            get { return _blurColor; }
            set
            {
                _blurColor = value;
                var acrylic = Color.FromArgb(_blurOpacity, _blurColor);
                WindowComposition.EnableAcrylic(this, acrylic);

            }
        }

        [Category("Appearance")]
        [Description("Determines the blur opacity.")]
        [DefaultValue(Consts.DEFAULT_OPACITY)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Byte BlurOpacity
        {
            get { return _blurOpacity; }
            set
            {
                _blurOpacity = value;
                var acrylic = Color.FromArgb(_blurOpacity, _blurColor);
                WindowComposition.EnableAcrylic(this, acrylic);
            }
        }

        bool _enableAcrylic = false;


        [Category("Appearance")]
        [Description("Determines the acrylic glass effect background.")]
        [DefaultValue(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool IsAcrylic
        {
            get
            {
                return _enableAcrylic;
            }
            set
            {
                _enableAcrylic = value;
                {
                    if (_enableAcrylic)
                    {
                        var acrylic = Color.FromArgb(_blurOpacity, _blurColor);
                        WindowComposition.EnableAcrylic(this, acrylic);
                    }
                    else
                    {
                        var acrylic = Color.FromArgb(Consts.SOLIDGRADIENT, _blurColor);
                        WindowComposition.EnableAcrylic(this, acrylic);
                    }
                }
            }

        }

        #endregion


        #region Paint Region

        protected override void OnHandleCreated(EventArgs e)
        {
            IsAcrylic = true;
            base.OnHandleCreated(e);
        }

     
        

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Transparent);
        }

        #endregion


        #region FormWindowState changes

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.IsAcrylic = false;

                    break;
                case FormWindowState.Normal: //Restored form (After)
                    this.IsAcrylic = true;
                    break;
            }
        }
        #endregion
    }
}
