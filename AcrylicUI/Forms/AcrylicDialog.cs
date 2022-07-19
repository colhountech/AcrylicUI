using System;
using AcrylicUI.Controls;
using AcrylicUI.Resources;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace AcrylicUI.Forms
{
    public partial class AcrylicDialog : AcrylicForm
    {
        #region Field Region

        private AcrylicDialogButton _dialogButtons = AcrylicDialogButton.Ok;
        private List<AcrylicButton> _buttons;

        #endregion

        #region Button Region

        protected AcrylicButton btnOk;
        protected AcrylicButton btnCancel;
        protected AcrylicButton btnClose;
        protected AcrylicButton btnYes;
        protected AcrylicButton btnNo;
        protected AcrylicButton btnAbort;
        protected AcrylicButton btnRetry;
        protected AcrylicButton btnIgnore;

        #endregion

        #region Property Region

        [Description("Determines the type of the dialog window.")]
        [DefaultValue(AcrylicDialogButton.Ok)]
        public AcrylicDialogButton DialogButtons
        {
            get { return _dialogButtons; }
            set
            {
                if (_dialogButtons == value)
                    return;

                _dialogButtons = value;
                SetButtons();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int TotalButtonSize { get; private set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new IButtonControl AcceptButton
        {
            get { return base.AcceptButton; }
            private set { base.AcceptButton = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new IButtonControl CancelButton
        {
            get { return base.CancelButton; }
            private set { base.CancelButton = value; }
        }

        #endregion

        #region Constructor Region

        public AcrylicDialog()
        {
            InitializeComponent();


            this.IsAcrylic = false;
            this.BlurColor = Colors.GreyBackground;

            _buttons = new List<AcrylicButton>
                {
                    btnAbort, btnRetry, btnIgnore, btnOk,
                    btnCancel, btnClose, btnYes, btnNo
                };          
        }

        #endregion

        #region Event Handler Region

        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);

            SetButtons();
        }

        #endregion

        #region Method Region

        private void SetButtons()
        {
            foreach (var btn in _buttons)
                btn.Visible = false;

            switch (_dialogButtons)
            {
                case AcrylicDialogButton.Ok:
                    ShowButton(btnOk, true);
                    AcceptButton = btnOk;
                    break;
                case AcrylicDialogButton.Close:
                    ShowButton(btnClose, true);
                    AcceptButton = btnClose;
                    CancelButton = btnClose;
                    break;
                case AcrylicDialogButton.OkCancel:
                    ShowButton(btnOk);
                    ShowButton(btnCancel, true);
                    AcceptButton = btnOk;
                    CancelButton = btnCancel;
                    break;
                case AcrylicDialogButton.AbortRetryIgnore:
                    ShowButton(btnAbort);
                    ShowButton(btnRetry);
                    ShowButton(btnIgnore, true);
                    AcceptButton = btnAbort;
                    CancelButton = btnIgnore;
                    break;
                case AcrylicDialogButton.RetryCancel:
                    ShowButton(btnRetry);
                    ShowButton(btnCancel, true);
                    AcceptButton = btnRetry;
                    CancelButton = btnCancel;
                    break;
                case AcrylicDialogButton.YesNo:
                    ShowButton(btnYes);
                    ShowButton(btnNo, true);
                    AcceptButton = btnYes;
                    CancelButton = btnNo;
                    break;
                case AcrylicDialogButton.YesNoCancel:
                    ShowButton(btnYes);
                    ShowButton(btnNo);
                    ShowButton(btnCancel, true);
                    AcceptButton = btnYes;
                    CancelButton = btnCancel;
                    break;
            }

            SetFlowSize();
        }

        private void ShowButton(AcrylicButton button, bool isLast = false)
        {
            button.SendToBack();

            if (!isLast)
                button.Margin = new Padding(0, 0, Scale(10), 0);

            button.Visible = true;
        }

        protected void SetFlowSize()
        {
            if (flowInner is not null && _buttons is not null)
            {
                var width = flowInner.Padding.Horizontal;                

                foreach (var btn in _buttons)
                {
                    if (btn.Visible)
                        width += btn.Width + btn.Margin.Right;
                }

                width += Scale(2); // Magin Number to stop wrapping of Dialog buttons

                flowInner.Width = width;
                TotalButtonSize = width;
            }
        }

        #endregion
    }
}
