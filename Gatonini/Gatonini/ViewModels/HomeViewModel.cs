using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using BaseVM;
using Gatonini.Views;
using Models;
using Services;
using Xamarin.Essentials;
using Xamarin.Forms;

using Style = Models.Style;

[assembly: Dependency(typeof(DataService<Secrets>))]
[assembly: Dependency(typeof(ClientService<RefreshToken>))]
[assembly: Dependency(typeof(ClientService<Style>))]
[assembly: Dependency(typeof(ClientService<string>))]
[assembly: Dependency(typeof(ClientService<List<Gamme>>))]
[assembly: Dependency(typeof(ClientService<Categorie>))]
[assembly: Dependency(typeof(ClientService<Gamme>))]
[assembly: Dependency(typeof(BaseViewModel))]
[assembly: Dependency(typeof(ClientInitial))]

namespace Gatonini.ViewModels
{
    public class HomeViewModel : BaseVM.BaseViewModel
    {
        private ICommand _logoutCommand;
        private IAuthService _authService;
        public IDataService<Secrets> Secret { get; }
        public ObservableCollection<Style> Styles { get; }
        public ICommand ProfileCommand { get; }
        public IDataService<Style> StyleServices { get; }
        public INavigation Navigation { get; }
        public IDataService<RefreshToken> Token { get; }
        public IDataService<string> SourceService { get; }
        private string _profilePic;

        public IDataService<List<Gamme>> GammeListService { get; }
        public string ProfilePic
        {
            get { return _profilePic; }
            set 
            {
                if (_profilePic == value)
                    return;

                _profilePic = value;
                OnPropertyChanged();
            }
        }


        public HomeViewModel()
        {
            Title = "Gatonini";
            _authService = DependencyService.Get<IAuthService>();
            GammeListService = DependencyService.Get<IDataService<List<Gamme>>>();
            Styles = new ObservableCollection<Style>();
            StyleTappedCommand = new Command(OnStyleTappedCommand);
            GammeTapped = new Command(OnGammeTapped);
            PanierCommand = new Command(OnPanierCommand);
            CategorieService = DependencyService.Get<IDataService<Categorie>>();
            GammeService = DependencyService.Get<IDataService<Gamme>>();
            StyleServices = DependencyService.Get<IDataService<Style>>();
            Styles = new ObservableCollection<Style>();
            Initial = DependencyService.Get<IInitialService>();
            SourceService = DependencyService.Get<IDataService<string>>();
            VentesCommand = new Command(OnVenteCommand);
            LivraisonCommand = new Command(OnLivraisonCommand);
            BaseVM = DependencyService.Get<IBaseViewModel>();
            RefreshCommand = new Command(OnRefreshCommand);
            Secret = DependencyService.Get<IDataService<Secrets>>();
            GammeLists = new ObservableCollection<GammeList>();
            PayementCommand = new Command(OnPayementCommand);
            SettingCommand = new Command(OnSettingCommand);
            Catégories = new ObservableCollection<Categorie>();
            Gammes = new ObservableCollection<Gamme>();
            ProfileCommand = new Command(OnProfileCommand);
            FirstLunch = true;
            Token = DependencyService.Get<IDataService<RefreshToken>>();
            Init();
            GetGammesAsync();
        }

        private async void OnProfileCommand(object obj)
        {
            await Navigation.PushAsync(new ProfilePage());
        }

        private async void OnStyleTappedCommand(object obj)
        {
            if (IsNotBusy)
                return;
            IsNotBusy = true;
            var style = ((GammeList)obj).Gammes.First().Style;
            await Navigation.PushAsync(new Gammes(style));
            IsNotBusy = false;
        }

        async Task Init()
        {
            ProfilePic = await SecureStorage.GetAsync("ProfilePic");
        }

        private async Task GetSource()
        {
            var source = await SourceService.GetProjectSourcesAsync("GatoniniSource");
            await SecureStorage.SetAsync("Source", source);
        }
        
        public ICommand RefreshCommand { get; }
        private bool _isRunning;
        public bool IsRunning
        {
            get => _isRunning;
            set
            {
                if (_isRunning == value)
                    return;
                _isRunning = value;
                OnPropertyChanged();
            }
        }

        private bool firstLunch = true;

        public bool FirstLunch
        {
            get { return firstLunch; }
            set 
            {
                if (firstLunch == value)
                    return;
                firstLunch = value;
                OnPropertyChanged();
            }
        }


        public ICommand SettingCommand { get; }
        public ICommand VentesCommand { get; }
        public ICommand GammeTapped { get; }
        public IBaseViewModel BaseVM { get; }
        public ICommand LivraisonCommand { get; }
        public IInitialService Initial { get; }
        public ICommand PanierCommand { get; }
        public ICommand PayementCommand { get; }
        public IDataService<Categorie> CategorieService { get; }
        public ICommand StyleTappedCommand { get; }
        public IDataService<Gamme> GammeService { get; }
        public ObservableCollection<Categorie> Catégories { get; }
        public ObservableCollection<Gamme> Gammes { get; }
        public ObservableCollection<GammeList> GammeLists { get; }

        public HomeViewModel(INavigation navigation) : this()
        {
            Navigation = navigation;
        }

        private async void OnPayementCommand(object obj)
        {
            await Navigation.PushAsync(new RapportPayement());
        }

        private async void OnPanierCommand(object obj)
        {
            await Navigation.PushAsync(new PanierPage());
        }

        private async void OnLivraisonCommand(object obj)
        {
            await Navigation.PushAsync(new RapportLivraison());
        }

        private async void OnVenteCommand(object obj)
        {
            await Navigation.PushAsync(new ReservationPage());
        }

        private async void OnGammeTapped(object obj)
        {
            var de = ((Gamme)obj);
            await Navigation.PushAsync(new ProductDetail(de));
        }

        private async void OnSettingCommand(object obj)
        {
            await Navigation.PushAsync(new ProfilePage());
        }

        private async void OnRefreshCommand(object obj)
        {
            await GetGammesAsync();
        }

        private async Task GetGammesAsync()
        {
            if (BaseVM.IsInternetOn || FirstLunch)
            {
                if(!FirstLunch)
                    if (IsRunning)
                        return;

                try
                {
                    IsRunning = true;
                    
                    await GetSource();

                    UserDialogs.Instance.ShowLoading("Chargement.....");
                    await TokenManagement();

                    GammeService.ProjectId = await SecureStorage.GetAsync("Source");
                    var gammes = await GammeService.GetItemsAsync(await SecureStorage.GetAsync("Token"), "Gammes");
                    Styles.Clear();
                    GammeLists.Clear();
                    if (gammes.Count() != 0)
                    {
                        Styles.Clear();
                        foreach (var items in gammes.GroupBy(x => x.StyleId))
                        {
                            var gammeList = new GammeList();
                            var id = items.Key.Value;
                            var fr = (from d in gammes where d.StyleId == id select d);
                            Styles.Add(fr.First().Style);
                            gammeList.Title = fr.First().Style.Name;
                            gammeList.Id = (Guid)fr.First().StyleId;

                            Gammes.Clear();
                            foreach (var itemss in fr)
                            {
                                Gammes.Add(itemss);
                                gammeList.Gammes.Add(itemss);
                            }

                            GammeLists.Add(gammeList);
                        }
                    }
                }
                catch (Exception ex)
                {
                    await InitializeInfo(ex, GetGammesAsync());
                }
                finally
                {
                    IsRunning = false;
                    FirstLunch = false;
                    await Task.Delay(5000);
                    UserDialogs.Instance.HideLoading();
                }
            }
        }

        
        private async Task TokenManagement()
        {
            try
            {
                var tok = await SecureStorage.GetAsync("Token");
                if (!string.IsNullOrWhiteSpace(tok))
                {
                    var token = await Token.PostAsync(new LogInModel() { Token = await SecureStorage.GetAsync("Token"), Username = "d", Password = "d" },
                    await SecureStorage.GetAsync("Token"), "authclient/TokenCheck");
                    if (token == null)
                    {
                        var resul = await Initial.Get(new LogInModel() { Token = await SecureStorage.GetAsync("Token") });
                        if (resul != null)
                        {
                            await SecureStorage.SetAsync("Token", resul.Token);
                            await SecureStorage.SetAsync("Email", resul.Email);
                            await SecureStorage.SetAsync("ProfilePic", resul.ProfilePic);
                        }
                    }
                }
                else
                {
                    var token = await Secret.GetItemAsync(null, "authclient/useremail/" + await SecureStorage.GetAsync("Email"));
                    if (token != null)
                    {
                        await SecureStorage.SetAsync("Token", token.Token);
                        await SecureStorage.SetAsync("Prenom", token.Prenom);
                        await SecureStorage.SetAsync("Nom", token.Nom);
                        await SecureStorage.SetAsync("Email", token.Email);
                        await SecureStorage.SetAsync("ProfilePic", token.ProfilePic);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private async Task InitializeInfo(Exception ex, Task action)
        {
            Debug.WriteLine($"Echec operation: {ex.Message}");
            if (ex.Message.Contains("Unauthorize"))
            {
                var result = await Initial.Get(new LogInModel() { Token = await SecureStorage.GetAsync("Token"), Password = "d", Username = "d" });
                await SecureStorage.SetAsync("Token", result.Token);
                await SecureStorage.SetAsync("Prenom", result.Prenom);
                await SecureStorage.SetAsync("Nom", result.Nom);
                await SecureStorage.SetAsync("ProfilePic", result.ProfilePic);
                IsRunning = false;
                await action;
            }
            else if (ex.Message.Contains("host"))
            {
                BaseVM.IsInternetOn = false;
                DependencyService.Get<IMessage>().ShortAlert("Erreur: Veillez verifier votre connection internet");
            }
            //else DependencyService.Get<IMessage>().ShortAlert("Erreur : "+ex.Message);
        }
    }
}
