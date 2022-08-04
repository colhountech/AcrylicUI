using AcrylicUI.Forms;
using AcrylicUI.Platform.Windows;
using AcrylicUI.Resources;

namespace AcrylicForm1
{
    public partial class MainWindow : AcrylicForm
    {
        // Make sure you set
        // Form1.cs:  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        // Program.cs : Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);

        public MainWindow()
        {
            InitializeComponent();
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Text = "MainWindow";
            this.IsAcrylic = true;
            this.BackColor = Colors.GreyBackground;
            this.BlurOpacity = 190;

        }

    }
}
