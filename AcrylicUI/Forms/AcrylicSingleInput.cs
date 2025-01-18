using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcrylicUI.Forms
{
    public partial class AcrylicSingleInput : AcrylicDialog
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string TextName
        {
            get { return this.txtName.Text; }

            set { this.txtName.Text = value; }
        }
        public AcrylicSingleInput()
        {
            InitializeComponent();
            this.IsAcrylic = false;
            this.Text = "Input String";
        }

        private void AcrylicSingleInput_Load(object sender, System.EventArgs e)
        {
            this.txtName.Focus();
        }
    }
}
