using Acr.UserDialogs;
using Gatonini;
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

[assembly: Dependency(typeof(SignUpService))]
[assembly: Dependency(typeof(BaseViewModel))]
namespace Gatonini
{
    public class SignUpViewModel : SignUpService
    {
        public INavigation Navigation { get; set; }
        public ISignUpService SignUp { get; }
        public IBaseViewModel BaseVM { get; }
        public ILogInService LogIn { get; }

        public bool IsRunning { get; set; }
        public SignUpViewModel(INavigation navigation) : this()
        {
            Navigation = navigation;
        }

        public SignUpViewModel()
        {
            SignUp = DependencyService.Get<ISignUpService>();
            LogIn = DependencyService.Get<ILogInService>();
            SignUpCommand = new Command(OnSignUpCommand);
            EyeCommandConfirm = new Command(OnEyeConfirmCommand);
            EyeCommand = new Command(OnEyeCommand);
            BaseVM = DependencyService.Get<IBaseViewModel>();
            FacebookCommand = new Command(OnFacebook);
            GoogleCommand = new Command(OnGoogle);
            TwitterCommand = new Command(OnTwitter);
            LogInCommand = new Command(async () =>
            {
                await Navigation.PushAsync(new LogInPage());
            });
        }

        private void OnEyeConfirmCommand(object obj)
        {
            if (IsPasswordConfirm)
            {
                IsPasswordConfirm = false;
                EyeImageConfirm = "invisible.png";
            }
            else
            {
                IsPasswordConfirm = true;
                EyeImageConfirm = "eye.png";
            }
        }

        private async void OnSignUpCommand(object obj)
        {
            if (BaseVM.IsInternetOn)
            {
                if (IsRunning)
                    return;
                if (string.IsNullOrWhiteSpace(Username) ||
                    string.IsNullOrWhiteSpace(Password)
                    || string.IsNullOrWhiteSpace(PasswordConfirm))
                    return;

                if (PasswordConfirm != Password)
                    return;

                try
                {
                    IsRunning = true;
                    UserDialogs.Instance.ShowLoading("Validation....");

                    var result = await SignUp.SignUpAsync(new LogInModel() { Username = Username, Password = Password });
                    if (result != null && !string.IsNullOrWhiteSpace(result.Token))
                    {
                        await SecureStorage.SetAsync("Token", result.Token);
                        await SecureStorage.SetAsync("AwsAccessKey", result.AwsAccessKey);
                        await SecureStorage.SetAsync("AwsSecretKey", result.AwsSecretKey);
                        await SecureStorage.SetAsync("BucketName", result.BucketName);
                        Application.Current.MainPage = new NavigationPage(new HomePage());
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    IsRunning = false;
                    UserDialogs.Instance.HideLoading();
                }
            }
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

        private bool isPasswordConfirm = true;
        public bool IsPasswordConfirm
        {
            get => isPasswordConfirm;
            set
            {
                if (isPasswordConfirm == value)
                    return;
                isPasswordConfirm = value;
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
        private string eyeImageConfirm = "eye.png";
        public string EyeImageConfirm
        {
            get => eyeImageConfirm;
            set
            {
                if (eyeImageConfirm == value)
                    return;
                eyeImageConfirm = value;
                OnPropertyChanged();
            }
        }
        public Command ForgotPasswordTapped { get; }
        public ICommand EyeCommand { get; }
        public ICommand EyeCommandConfirm { get; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }

        public ICommand SignUpCommand
        {
            get;
        }

        public ICommand LogInCommand
        {
            get;
        }

        public ICommand FacebookCommand
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
                Application.Current.MainPage = new NavigationPage(new HomePage());
            }
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

        public ICommand GoogleCommand
        {
            get;
        }

        public ICommand TwitterCommand
        {
            get;
        }
    }
}
