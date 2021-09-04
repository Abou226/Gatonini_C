using Acr.UserDialogs;
using Gatonini.BaseVM;
using Gatonini.Models;
using Gatonini.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

[assembly: Dependency(typeof(LogInService))]
[assembly: Dependency(typeof(BaseViewModel))]

namespace GatoniniAdmin
{
    public class LogInViewModel : LogInService
    {
        public INavigation Navigation { get; set; }
        public IBaseViewModel BaseVM { get; }
        public ILogInService LogIn { get; }

        private bool isPassword = true;
        public bool IsPassword
        {
            get => isPassword;
            set
            {
                if (isPassword == value)
                    return;
                isPassword = value;
                OnPropertyChanged();
            }
        }



        private string eyeImage = "eye.png";
        public string EyeImage
        {
            get => eyeImage;
            set
            {
                if (eyeImage == value)
                    return;
                eyeImage = value;
                OnPropertyChanged();
            }
        }
        public Command ForgotPasswordTapped { get; }
        public ICommand EyeCommand { get; }
        public LogInViewModel(INavigation navigation)
        {
            Navigation = navigation;
            ForgotPasswordTapped = new Command(OnItemSelected);
            LogIn = DependencyService.Get<ILogInService>();
            BaseVM = DependencyService.Get<IBaseViewModel>();
            LogInCommand = new Command(OnLogIn);
            EyeCommand = new Command(OnEyeCommand);
            FacebookCommand = new Command(OnFacebook);
            TwitterCommand = new Command(OnTwitter);
            GoogleCommand = new Command(OnGoogle);
            SignUp = new Command(async () =>
            {
                await Navigation.PushAsync(new SignUpPage());
            });
        }

        private async void OnFacebook(object obj)
        {
            await ExternalLogInAsync("Facebook");
        }

        private async void OnTwitter(object obj)
        {
            await ExternalLogInAsync("Twitter");
        }

        private async void OnGoogle(object obj)
        {
            await ExternalLogInAsync("Google");
        }

        private void OnEyeCommand(object obj)
        {
            if (IsPassword)
            {
                IsPassword = false;
                EyeImage = "invisible.png";
            }
            else
            {
                IsPassword = true;
                EyeImage = "eye.png";
            }
        }

        private async void OnLogIn(object obj)
        {
            if (BaseVM.IsInternetOn)
            {
                if (string.IsNullOrWhiteSpace(Username) ||
                        string.IsNullOrWhiteSpace(Password))
                    return;

                UserDialogs.Instance.ShowLoading("Validation.....");
                var result = await LogIn.LogInAsync(new LogInModel()
                { Username = this.Username, Password = this.Password });
                UserDialogs.Instance.HideLoading();
                if (string.IsNullOrWhiteSpace(Message))
                {
                    Message = "Utilisateur incorrect !";
                    MessageVisibility = true;
                }

                if (result != null && !string.IsNullOrWhiteSpace(result.Token))
                {
                    UserDialogs.Instance.ShowLoading("Lancement.....");
                    await SecureStorage.SetAsync("Token", result.Token);
                    await SecureStorage.SetAsync("AwsAccessKey", result.AwsAccessKey);
                    await SecureStorage.SetAsync("AwsSecretKey", result.AwsSecretKey);
                    await SecureStorage.SetAsync("BucketName", result.BucketName);
                    Application.Current.MainPage = new NavigationPage(new Home());
                    UserDialogs.Instance.HideLoading();
                }
            }
            else
            {
                Message = "Erreur internet !";
                MessageVisibility = true;
            }
        }

        public LogInViewModel()
        {
            Title = "Gain Master";
            ForgotPasswordTapped = new Command(OnItemSelected);
            LogIn = DependencyService.Get<ILogInService>();
        }

        private async void OnItemSelected(object obj)
        {

        }

        private string username;
        public string Username
        {
            get => username;
            set
            {
                if (username == value)
                    return;

                username = value;
                MessageVisibility = false;
                OnPropertyChanged(nameof(MessageVisibility));
            }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                if (_password == value)
                    return;
                _password = value;

                MessageVisibility = false;
                OnPropertyChanged(nameof(MessageVisibility));
            }
        }

        public Command LogInCommand
        {
            get;
        }



        private async Task ExternalLogInAsync(string provider)
        {
            var authurl = new Uri(baseurl + "api/Auth/ExternalLogin/" + provider);
            var callbackurl = new Uri("Gatonini://");

            var result = await WebAuthenticator.AuthenticateAsync(authurl, callbackurl);

            await SecureStorage.SetAsync("SocialToken", result.AccessToken);
            var response = await DependencyService.Get<IDataService<UserProfile>>().GetItemAsync("api/ExternalUserByAccessToken/" + provider);
            if (response != null)
            {
                await SecureStorage.SetAsync("Token", response.Token);
                await SecureStorage.SetAsync("AwsAccessKey", response.AwsAccessKey);
                await SecureStorage.SetAsync("AwsSecretKey", response.AwsSecretKey);
                await SecureStorage.SetAsync("BucketName", response.BucketName);
                await SecureStorage.SetAsync("PicUrl", response.Url);
                await SecureStorage.SetAsync("UserId", response.UserId.ToString());
                await SecureStorage.SetAsync("Prenom", response.Prenom);
                await SecureStorage.SetAsync("Nom", response.Nom);
                await SecureStorage.SetAsync("Email", response.Email);
                Application.Current.MainPage = new NavigationPage(new Home());
            }
        }

        public ICommand FacebookCommand { get; }
        public ICommand GoogleCommand { get; }
        public ICommand TwitterCommand { get; }

        public ICommand SignUp { get; }
    }
}
