using MainApp.ViewModels;
using MainApp.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace MainApp
{
 
    public partial class App : Application
    {
        private readonly IHost? host;

        public App()
        {
            host = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddSingleton<MainViewModel>();
                    services.AddSingleton<MainWindow>();

                    services.AddTransient<GetStartedViewModel>();
                    services.AddTransient<GetStartedView>();
                    services.AddTransient<AddItemViewModel>();
                    services.AddTransient<AddItemView>();
                    services.AddTransient<ListItemsViewModel>();
                    services.AddTransient<ListItemsView>();

                })
                .Build();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindow = host!.Services.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }
    }


}
