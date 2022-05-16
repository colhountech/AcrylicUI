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

        bool _isAcrylic = true;
        bool _isAcrylicActiveNow = true;
        bool _wasAcrylicActive = true;
        #endregion


        #region Constructor Region

        public AcrylicForm()
        {
            InitializeComponent();
        }

        #endregion


        #region Property Region

        // Override the Back Color to avoid confusion. The BackColor and Blur Color are the same now
        public override Color BackColor
        {
            get
            {
                return BlurColor;
            }
            set
            {
                BlurColor = value;
            }
        }

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
                if (_isAcrylic & _isAcrylicActiveNow)
                    MakeAcrylic();
                else
                    MakeSolid();
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

                if (_isAcrylic & _isAcrylicActiveNow)
                    MakeAcrylic();
                else
                    MakeSolid();
            }
        }

        

        [Category("Appearance")]
        [Description("Determines the acrylic glass effect background.")]
        [DefaultValue(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool IsAcrylic
        {
            get
            {
                return _isAcrylic;
            }
            set
            {
                _isAcrylic = value;
                {
                    if (_isAcrylic & _isAcrylicActiveNow)                    
                        MakeAcrylic();                    
                    else                    
                        MakeSolid();                    
                }
            }

        }

        private void MakeSolid()
        {
            var solid = Color.FromArgb(Consts.SOLIDGRADIENT, _blurColor);
            WindowComposition.EnableAcrylic(this, solid);
        }

        private void MakeAcrylic()
        {
            if (!_isResizing)
            {
                var acrylic = Color.FromArgb(_blurOpacity, _blurColor);
                WindowComposition.EnableAcrylic(this, acrylic);
            }
            else
            {
                MakeSolid();
            }
        }

        #endregion


        #region Paint Region

        protected override void OnHandleCreated(EventArgs e)
        {
            _wasAcrylicActive = _isAcrylicActiveNow;
            _isAcrylicActiveNow = true;
            base.OnHandleCreated(e);
        }




        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Transparent);
            //e.Graphics.Clear(Colors.GreyBackground);
        }

      
        #endregion


        #region FormWindowState changes




        private bool _isResizing = false;
        protected override void OnResizeBegin(EventArgs e)
        {
            _isResizing = true;
            _wasAcrylicActive = _isAcrylicActiveNow;
            _isAcrylicActiveNow = false;

            if (_isAcrylic & _isAcrylicActiveNow)
                MakeAcrylic();
            else
                MakeSolid();

            base.OnResizeBegin(e);
        }
        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);

            _isResizing = false;
            _wasAcrylicActive = _isAcrylicActiveNow;
            _isAcrylicActiveNow = true;

            if (_isAcrylic & _isAcrylicActiveNow)
                MakeAcrylic();
            else
                MakeSolid();
        }


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

                    _wasAcrylicActive = _isAcrylicActiveNow;
                    _isAcrylicActiveNow = false;

                    if (_isAcrylic & _isAcrylicActiveNow)
                        MakeAcrylic();
                    else
                        MakeSolid();

                    break;
                case FormWindowState.Normal: //Restored form (After)


                    if (_wasAcrylicActive == _isAcrylicActiveNow)
                        return;


                    _wasAcrylicActive = _isAcrylicActiveNow;
                    _isAcrylicActiveNow = true;

                    if (_isAcrylic & _isAcrylicActiveNow)
                        MakeAcrylic();
                    else
                        MakeSolid();

                    break;
            }
        }
        #endregion
    }
}
