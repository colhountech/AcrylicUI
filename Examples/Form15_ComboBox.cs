using AcrylicUI.Controls;
using AcrylicUI.Forms;
using System.Text.Json;

namespace Examples
{
    public partial class Form15_ComboBox: AcrylicForm
    {

        public Form15_ComboBox()
        {
            // Make sure you set:
            //  * Form1.cs:  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            //  * Program.cs : Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            InitializeComponent();
        }

        private void acrylicComboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var comboBox = acrylicComboBox2;

            if (comboBox.SelectedIndex != 0)
            {
                comboBox.SelectedIndex = 0;
            }                
        }
    }
}
