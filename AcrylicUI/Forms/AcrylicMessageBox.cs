using AcrylicUI.Resources;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AcrylicUI.Forms
{
    public partial class AcrylicMessageBox : AcrylicDialog
    {
        #region Field Region

        const int _MAX_MODAL_WIDTH = 350;
        const int _DEFAULT_MODAL_WIDTH = 260;
        const int _DEFAULT_MODAL_HEIGHT = 140; // 124
        const int _DEFAULT_ICON_SIZE = 32;
        const int _LEFT_TEXT_MARGIN = 10;
        const int _MESSAGE_PADDING_WIDTH = 25;
        const int _MESSAGE_PADDING_HEIGHT = 10;
        const int _DEFAULT_BUTTON_GAP = 15;
        const int _TOTAL_WIDTH_PADDING = 25;

        private string _message;
        
        private int _maximumWidth = _MAX_MODAL_WIDTH; // But scale it later
        
        private AcrylicMessageBoxIcon _statusIcon = AcrylicMessageBoxIcon.None;

        private IconFactory _iconFactory;
        private Image _iconInformation;
        private Image _iconWarning;
        private Image _iconError;
        
        #endregion

        #region Property Region

        [Description("Determines the maximum width of the message box when it autosizes around the displayed message.")]
        [DefaultValue(350)]
        public int MaximumWidth
        {
            get { return _maximumWidth; }
            set
            {
                _maximumWidth = value;
                CalculateSize();
            }
        }

        #endregion

        #region Constructor Region

        public AcrylicMessageBox()
        {
            _maximumWidth = this.Scale(_MAX_MODAL_WIDTH);
            InitializeComponent();

            this.IsAcrylic = false;
            var dpiScale = IconFactory.GetDpiScale(this.Handle);
            _iconFactory = new IconFactory(IconFactory.GetDpiScale(Handle));

            _iconInformation = _iconFactory.BitmapFromSvg(Icons.StatusAlert_16x_svg, _DEFAULT_ICON_SIZE, _DEFAULT_ICON_SIZE); 
            _iconWarning = _iconFactory.BitmapFromSvg(Icons.StatusWarning_16x_svg, _DEFAULT_ICON_SIZE, _DEFAULT_ICON_SIZE); 
            _iconError = _iconFactory.BitmapFromSvg(Icons.StatusCriticalError_16x_svg, _DEFAULT_ICON_SIZE, _DEFAULT_ICON_SIZE);
        }

        public AcrylicMessageBox(string message, string title, AcrylicMessageBoxIcon icon, AcrylicDialogButton buttons)
            : this()
        {
            Text = title;
            _message = message;

            DialogButtons = buttons;
            SetIcon(icon);
        }

        public AcrylicMessageBox(string message)
            : this(message, null, AcrylicMessageBoxIcon.None, AcrylicDialogButton.Ok)
        { }

        public AcrylicMessageBox(string message, string title)
            : this(message, title, AcrylicMessageBoxIcon.None, AcrylicDialogButton.Ok)
        { }

        public AcrylicMessageBox(string message, string title, AcrylicDialogButton buttons)
            : this(message, title, AcrylicMessageBoxIcon.None, buttons)
        { }

        public AcrylicMessageBox(string message, string title, AcrylicMessageBoxIcon icon)
            : this(message, title, icon, AcrylicDialogButton.Ok)
        { }

        #endregion

        #region Static Method Region

        public static DialogResult ShowInformation(string message, string caption, AcrylicDialogButton buttons = AcrylicDialogButton.Ok)
        {
            return ShowDialog(message, caption, AcrylicMessageBoxIcon.Information, buttons);
        }

        public static DialogResult ShowWarning(string message, string caption, AcrylicDialogButton buttons = AcrylicDialogButton.Ok)
        {
            return ShowDialog(message, caption, AcrylicMessageBoxIcon.Warning, buttons);
        }

        public static DialogResult ShowError(string message, string caption, AcrylicDialogButton buttons = AcrylicDialogButton.Ok)
        {
            return ShowDialog(message, caption, AcrylicMessageBoxIcon.Error, buttons);
        }

        private static DialogResult ShowDialog(string message, string caption, AcrylicMessageBoxIcon icon, AcrylicDialogButton buttons)
        {
            using (var dlg = new AcrylicMessageBox(message, caption, icon, buttons))
            {
                var result = dlg.ShowDialog();
                return result;
            }
        }

        #endregion

        #region Method Region

        private void SetIcon(AcrylicMessageBoxIcon icon)
        {
            _statusIcon = icon;

            switch (_statusIcon)
            {
                case AcrylicMessageBoxIcon.None:
                    picIcon.Visible = false;
                    lblText.Left = Scale(_LEFT_TEXT_MARGIN);
                    break;
                case AcrylicMessageBoxIcon.Information:
                    picIcon.Image = _iconInformation;
                    break;
                case AcrylicMessageBoxIcon.Warning:
                    picIcon.Image = _iconWarning;
                    break;
                case AcrylicMessageBoxIcon.Error:
                    picIcon.Image = _iconError;
                    break;
            }
        }

        private void CalculateSize()
        {

            var width = Scale(_DEFAULT_MODAL_WIDTH);
            var height = Scale(_DEFAULT_MODAL_HEIGHT);
            // Reset form back to original size
            Size = new Size(width, height);

            lblText.Text = string.Empty;
            lblText.AutoSize = true;
            lblText.Text = _message;

            // Set the minimum dialog size to whichever is bigger - the original size or the buttons.
            var minWidth = Math.Max(width, TotalButtonSize + Scale(_DEFAULT_BUTTON_GAP));

            // Calculate the total size of the message
            var totalWidth = lblText.Right + Scale(_TOTAL_WIDTH_PADDING);

            // Make sure we're not making the dialog bigger than the maximum size
            if (totalWidth < _maximumWidth)
            {
                // Width is smaller than the maximum width.
                // This means we can have a single-line message box.
                // Move the label to accomodate this.
                width = totalWidth;
                lblText.Top = picIcon.Top + (picIcon.Height / 2) - (lblText.Height / 2);
            }
            else
            {
                // Width is larger than the maximum width.
                // Change the label size and wrap it.
                width = _maximumWidth;
                var offsetHeight = Height - picIcon.Height;
                lblText.AutoUpdateHeight = true;
                lblText.Width = width - lblText.Left - Scale(_MESSAGE_PADDING_WIDTH);
                height = offsetHeight + lblText.Height;
            }

            // Force the width to the minimum width
            if (width < minWidth)
                width = minWidth;

            // Set the new size of the dialog
            Size = new Size(width, height);
        }

        #endregion

        #region Event Handler Region

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);            
            ResizeIcons();
            CalculateSize();
        }

        #endregion

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ResizeIcons();
        }

        private void ResizeIcons()
        {
            if (_iconFactory is not null && _statusIcon != AcrylicMessageBoxIcon.None)
            {
                _iconFactory = new IconFactory(IconFactory.GetDpiScale(Handle));

                _iconInformation = _iconFactory?.BitmapFromSvg(Icons.StatusAlert_16x_svg, _DEFAULT_ICON_SIZE, _DEFAULT_ICON_SIZE);
                _iconWarning = _iconFactory?.BitmapFromSvg(Icons.StatusWarning_16x_svg, _DEFAULT_ICON_SIZE, _DEFAULT_ICON_SIZE);
                _iconError = _iconFactory?.BitmapFromSvg(Icons.StatusCriticalError_16x_svg, _DEFAULT_ICON_SIZE, _DEFAULT_ICON_SIZE);

                switch (_statusIcon)
                {
                    case AcrylicMessageBoxIcon.Information:
                        picIcon.Image = _iconInformation;
                        break;
                    case AcrylicMessageBoxIcon.Warning:
                        picIcon.Image = _iconWarning;
                        break;
                    case AcrylicMessageBoxIcon.Error:
                        picIcon.Image = _iconError;
                        break;
                }
            }            
        }
    }
}
