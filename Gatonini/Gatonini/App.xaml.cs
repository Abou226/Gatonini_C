using Models;
using Plugin.Connectivity;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Microsoft.Extensions.DependencyInjection;
using Gatonini.Views;
using BaseVM;
using Services;
using System.Linq;

[assembly: Dependency(typeof(BaseViewModel))]
[assembly: Dependency(typeof(ClientService<Test>))]
[assembly: Dependency(typeof(ClientService<Entreprise>))]
[assembly: Dependency(typeof(ClientService<RefreshToken>))]

namespace Gatonini
{
    public partial class App : Application
    {
        public IBaseViewModel BaseVM { get; }
        public IDataService<Entreprise> EntrepriseData { get; }
        public IDataService<RefreshToken> Token { get; }
        public IInitialService Initial { get; }
        public IDataService<Test> Test { get; }
        public App()
        {
            InitializeComponent();
            BaseVM = DependencyService.Get<IBaseViewModel>();
            Test = DependencyService.Get<IDataService<Test>>();
            EntrepriseData = DependencyService.Get<IDataService<Entreprise>>();
            Token = DependencyService.Get<IDataService<RefreshToken>>();
            Device.StartTimer(TimeSpan.FromSeconds(BaseVM.InternetCheckTime), () =>
            {
                // Do something
                CheckConnection();
                return true; // True = Repeat again, False = Stop the timer
            });

            OSAppTheme currentTheme = Application.Current.RequestedTheme;
            if (currentTheme == OSAppTheme.Dark)
            {
                Resources["Primary"] = Resources["ThirdColor"];
                Resources["ThirdColor"] = Resources["Primary"];
            }
            else if (currentTheme == OSAppTheme.Light)
            {
                Resources["Primary"] = Resources["Primary"];
                Resources["ThirdColor"] = Resources["ThirdColor"];
            }
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


        protected override async void OnStart()
        {
            //await Host.StartAsync();
            ////SecureStorage.RemoveAll();
            var token = await SecureStorage.GetAsync("Token");
            if (string.IsNullOrWhiteSpace(token))
            {
                MainPage = new NavigationPage(new LoginPage());
            }
            else
            {
                MainPage = new NavigationPage(new HomePage());
            }
        }

        protected override void OnSleep()
        {
            //Task.Run(async () => await Host.SleepAsync());
        }

        protected override void OnResume()
        {
            //Task.Run(async () => await Host.ResumeAsync());
        }
    }
}
