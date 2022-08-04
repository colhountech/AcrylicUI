using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace AcrylicForm1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Make sure you set
            // Form1.cs:  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // Program.cs : Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);

            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var mainWindows = serviceProvider.GetRequiredService<MainWindow>();
                Application.Run(mainWindows);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .AddEnvironmentVariables()
                .Build();

            var settings = config
           .GetSection(Dashboard.SectionName)
           .Get<Dashboard>();

            services
                .Configure<Dashboard>(config.GetSection(Dashboard.SectionName))
                .AddLogging(x => x
                    .AddConsole()
                    .AddDebug())
                .AddScoped<MainWindow>()
                 .AddOptions()
                .AddHttpClient("WebApi", c => c.BaseAddress = new Uri(settings.ApplicationUrl))
                 ;
        }
    }
}