using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using BaseVM;
using Gatonini.Views;
using Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseViewModel))]

namespace Gatonini.ViewModels
{
    public class SignUpViewModel: BaseVM.BaseViewModel
    {
        private ICommand _loginCommand;
        private ICommand _signupCommand;
        private string _username;
        public INavigation Navigation { get; }
        private string _password;
        public IBaseViewModel BaseVM { get; }
        private IUserDialogs _userDialogService;
        private ICommand _loginGoogleCommand;

        private IAuthService _authService;

        public SignUpViewModel(IUserDialogs userDialogsService) : this()
        {
            _userDialogService = userDialogsService;
        }
        public SignUpViewModel(INavigation navigation) : this()
        {
            Navigation = navigation;
        }
        public SignUpViewModel()
        {
            _authService = DependencyService.Get<IAuthService>();
            Title = "Gatonini";
            BaseVM = DependencyService.Get<IBaseViewModel>();
            MessagingCenter.Subscribe<string, string>(this, _authService.getAuthKey(), (sender, args) =>
            {
                LoginGoogle(args);
            });
        }

        public ICommand LoginGoogleCommand
        {
            get { return _loginGoogleCommand = _loginGoogleCommand ?? new Command(LoginGoogleCommandExecute); }
        }

        private async Task LoginGoogle(string token)
        {
            if (await _authService.SignInWithGoogle(token))
            {
                Application.Current.MainPage = new NavigationPage(new HomePage());
            }
        }


        private void LoginGoogleCommandExecute(object obj)
        {
            _authService.SignInWithGoogle();
        }

        public ICommand LoginCommand
        {
            get { return _loginCommand = _loginCommand ?? new Command(LoginCommandExecute); }
        }
        public ICommand SignUpCommand
        {
            get { return _signupCommand = _signupCommand ?? new Command(SignUpCommandExecute); }
        }
        private async void LoginCommandExecute(object obj)
        {
            await Navigation.PushAsync(new LoginPage());
        }
        private async void SignUpCommandExecute(object obj)
        {
            if (await _authService.SignUp(Username, Password))
            {
                Application.Current.MainPage = new NavigationPage(new HomePage());
            }
            else
            {
                _userDialogService.Toast("Nom d'utilisateur ou mot de passe incorrect");
            }
        }
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
    }
}
