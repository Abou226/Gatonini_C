using Gatonini.BaseVM;
using Gatonini.Models;
using Gatonini.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Plugin.Connectivity;
using System;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: Dependency(typeof(BaseViewModel))]
[assembly: Dependency(typeof(DataService<Test>))]
namespace Gatonini
{
    public partial class App : Application
    {
        public IBaseViewModel BaseVM { get; }
        public IDataService<Test> Test { get; }
        public App()
        {
            InitializeComponent();
            BaseVM = DependencyService.Get<IBaseViewModel>();
            Test = DependencyService.Get<IDataService<Test>>();
            Device.StartTimer(TimeSpan.FromSeconds(BaseVM.InternetCheckTime), () =>
            {
                // Do something
                CheckConnection();
                return true; // True = Repeat again, False = Stop the timer
            });
        }

        private async void CheckConnection()
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                do
                {
                    try
                    {
                        var result = await Test.GetItemsAsync(await SecureStorage.GetAsync("Token"), "Tests");
                        //if(result == null)
                        {
                            BaseVM.IsInternetOn = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("host"))
                        {
                            BaseVM.IsInternetOn = false;
                        }
                        else BaseVM.IsInternetOn = true;
                    }
                } while (!BaseVM.IsInternetOn);
            }
            else
            {
                BaseVM.IsInternetOn = false;
            }
        }

        public App(IHost host) : this() => Host = host;


        public static IHost Host { get; private set; }

        public static IHostBuilder BuildHost() =>
            XamarinHost.CreateDefaultBuilder<App>()
            .ConfigureServices((context, services) =>
            {
                services.AddScoped<HomePage>();
                services.AddScoped<LogInPage>();
                services.AddScoped<SignUpPage>();
                services.AddScoped(typeof(IDataService<>), typeof(DataService<>));
                services.AddScoped<IBaseViewModel, BaseViewModel>();
                services.AddScoped<IInitialService, InitialService>();
                services.AddScoped<IFileUploadService, FileUploadService>();
                services.AddScoped<ILogInService, LogInService>();
                services.AddScoped<ISignUpService, SignUpService>();
            });


        protected override async void OnStart()
        {
            await Host.StartAsync();
            //SecureStorage.RemoveAll();
            var token = await SecureStorage.GetAsync("Token");
            if (string.IsNullOrWhiteSpace(token))
            {
                MainPage = new NavigationPage(Host.Services.GetRequiredService<LogInPage>());
            }
            else
            {
                MainPage = new NavigationPage(Host.Services.GetRequiredService<HomePage>());
            }
        }

        protected override void OnSleep()
        {
            Task.Run(async () => await Host.SleepAsync());
        }

        protected override void OnResume()
        {
            Task.Run(async () => await Host.ResumeAsync());
        }
    }
}
