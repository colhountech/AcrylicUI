using AcrylicUI.Controls;
using AcrylicUI.Resources;
using System;
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
        protected AcrylicButton btnApply;

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
            this.BackColor = Colors.GreyBackground;

            _buttons = new List<AcrylicButton>
                {
                    btnAbort, btnRetry, btnIgnore, btnOk,
                    btnCancel, btnClose, btnYes, btnNo, btnApply
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
                    btnOk.Default = true;
                    ActiveControl = btnOk;
                    ShowButton(btnOk, true);
                    AcceptButton = btnOk;
                    break;
                case AcrylicDialogButton.Close:
                    btnClose.Default = true;
                    ActiveControl = btnClose;
                    ShowButton(btnClose, true);
                    AcceptButton = btnClose;
                    CancelButton = btnClose;
                    break;
                case AcrylicDialogButton.OkCancel:
                    btnOk.Default = true;
                    ActiveControl = btnOk;
                    ShowButton(btnOk);
                    ShowButton(btnCancel, true);
                    AcceptButton = btnOk;
                    CancelButton = btnCancel;
                    break;
                case AcrylicDialogButton.OKCancelApply:
                    btnOk.Default = true;
                    ActiveControl = btnOk;
                    ShowButton(btnOk);
                    ShowButton(btnCancel);
                    ShowButton(btnApply, true);
                    AcceptButton = btnOk;
                    CancelButton = btnCancel;
                    break;
                case AcrylicDialogButton.AbortRetryIgnore:
                    btnAbort.Default = true;
                    ActiveControl = btnAbort;
                    ShowButton(btnAbort);
                    ShowButton(btnRetry);
                    ShowButton(btnIgnore, true);
                    AcceptButton = btnAbort;
                    CancelButton = btnIgnore;
                    break;
                case AcrylicDialogButton.RetryCancel:
                    btnRetry.Default = true;
                    ActiveControl = btnRetry;
                    ShowButton(btnRetry);
                    ShowButton(btnCancel, true);
                    AcceptButton = btnRetry;
                    CancelButton = btnCancel;
                    break;
                case AcrylicDialogButton.YesNo:
                    btnYes.Default = true;
                    ActiveControl = btnYes;
                    ShowButton(btnYes);
                    ShowButton(btnNo, true);
                    AcceptButton = btnYes;
                    CancelButton = btnNo;
                    break;
                case AcrylicDialogButton.YesNoCancel:
                    btnYes.Default = true;
                    ActiveControl = btnYes;
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

                flowInner.Width = width;
                TotalButtonSize = width;
            }
        }

        #endregion
    }
}
