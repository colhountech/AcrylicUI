using AcrylicUI.Platform.Windows;
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
        bool _isAcrylcWhileResizing = false;//this is still buggy in windows. turn off for now 
        bool _isAcrylicWhenMaximized = true;
        #endregion


        #region Constructor Region

        public AcrylicForm()
        {
            InitializeComponent();
            UpdateScale();
        }

        #endregion

        #region Property Region

        [Category("Appearance")]
        [Description("Determines the blur background color.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(Color), "0x1F1F1F")] // Colors.GreyBackground
        public new Color BackColor
        {
            get { return _blurColor; }
            set
            {
                base.BackColor = _blurColor;
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
            else // Rewizing
            {
                if (_isAcrylcWhileResizing)
                {
                    var acrylic = Color.FromArgb(_blurOpacity, _blurColor);
                    WindowComposition.EnableAcrylic(this, acrylic);
                    Console.WriteLine("_isAcrylcWhileResizing");
                }
                else
                {
                    MakeSolid();
                }
            }
        }

        #endregion

        #region Paint Region

        protected override void OnHandleCreated(EventArgs e)
        {
            _wasAcrylicActive = _isAcrylicActiveNow;
            _isAcrylicActiveNow = true;
            base.OnHandleCreated(e);
            Win32Hacks.DarkThemeTitleBar(this.Handle);
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
            UpdateScale();
            AdjustForm();

        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)

                    _wasAcrylicActive = _isAcrylicActiveNow;
                    _isAcrylicActiveNow = _isAcrylicWhenMaximized;

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
        //protected override void OnResize(EventArgs e)
        //{
        //    base.OnResize(e);
        //    UpdateScale();
        //}
        protected int Scale(int pixel)
        {
            return (int)(pixel * _dpiScale);
        }

        #endregion
    }
}
