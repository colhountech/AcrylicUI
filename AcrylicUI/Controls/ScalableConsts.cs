namespace AcrylicUI.Controls
{
    public class ScalableConsts
    {

        public ScalableConsts()
        {
            UpdateScale();
        }

        #region Constants
        private const int _lineWidth = 1;
        private const int _offset = 2;
        private const int _padding = 3;
        private const int _spacing = 5;
        private const int _textGap = 4;

        // AcrylicTreeView Constants

        // these are read/write
        private int _itemHeight = 20;
        private int _indent = 20;

        // these are ready only
        private readonly int _expandAreaSize = 16;
        private readonly int _iconSize = 16;
        private readonly int _plusIconSize = 12;



        #endregion

        #region 'Scalable' Constants


        public int ItemHeight
        {
            get { return Scale(_itemHeight); }
            set { _itemHeight = value; }
        }

        public int Indent
        {
            get { return Scale(_indent); }
            set { _indent = value; }
        }

        public int LineWidthSize
        {
            get { return Scale(_lineWidth); }
        }

        public int OffsetSize
        {
            get { return Scale(_offset); }
        }

        public int PaddingSize
        {
            get { return Scale(_padding); }
        }


        public int TextGapSize
        {
            get { return Scale(_textGap); }

        }

        public int SpacingSize
        {
            get { return Scale(_spacing); }
        }


        //AcrylicTreeView Constants

        public int ExpandAreaSize
        {
            get { return Scale(_expandAreaSize); }
        }
        public int IconSize
        {
            get { return Scale(_iconSize); }
        }
        public int PlusIconSize
        {
            get { return Scale(_plusIconSize); }
        }

        #endregion


        #region Dpi Scale

        private const float DEFAULT_DPI = 96f;
        protected float _dpiScale = 1f;


        // call at init too
        public virtual void UpdateScale(float newDpiScale = 1f)
        {

            if (newDpiScale != _dpiScale)
            {
                _dpiScale = newDpiScale;
            }
        }
        public int Scale(int pixel)
        {
            return (int)(pixel * _dpiScale);
        }

        #endregion

    }
}

