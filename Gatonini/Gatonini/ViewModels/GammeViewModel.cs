using Acr.UserDialogs;
using BaseVM;
using Gatonini.Views;
using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Style = Models.Style;

[assembly: Dependency(typeof(ClientService<Gamme>))]
[assembly: Dependency(typeof(ClientInitial))]
[assembly: Dependency(typeof(BaseViewModel))]

namespace Gatonini.ViewModels
{
    public class GammesViewModel : BaseVM.BaseViewModel
    {
        public ICommand BackCommand { get; }
        public ICommand TappedGamme { get; }
        public INavigation Navigation { get; }
        public IBaseViewModel BaseVM { get; }
        public IInitialService Initial { get; }
        public ObservableCollection<Gamme> Items { get;}
        public IDataService<Gamme> GammeService { get; }
        private bool isRunning;

        public bool IsRunning
        {
            get { return isRunning; }
            set 
            {
                if (isRunning == value)
                    return;

                isRunning = value;
                OnPropertyChanged();
            }
        }

        public Style Style { get; set; }
        public GammesViewModel(INavigation navigation = null, Style style = null) : this()
        {
            Title = style.Name;
            Navigation = navigation;
            Style = style;
            GetGammesAsync();
        }

        public GammesViewModel()
        {
            
            Items = new ObservableCollection<Gamme>();
            Initial = DependencyService.Get<IInitialService>();
            BaseVM = DependencyService.Get<IBaseViewModel>();
            GammeService = DependencyService.Get<IDataService<Gamme>>();
            BackCommand = new Command(OnBackCommand);
            TappedGamme = new Command(OnTappedGamme);
        }

        private async void OnTappedGamme(object obj)
        {
            var de = ((Gamme)obj);
            await Navigation.PushAsync(new ProductDetail(de));
        }

        private async void OnBackCommand(object obj)
        {
            await Navigation.PopAsync();
        }

        private async Task GetGammesAsync()
        {
            if (BaseVM.IsInternetOn)
            {
                if (IsNotBusy)
                    return;

                try
                {
                    IsNotBusy = false;
                    GammeService.ProjectId = await SecureStorage.GetAsync("Source");
                    var items = await GammeService.GetItemsAsync(await SecureStorage.GetAsync("Token"), "Gammes/by_style/"+Style.Id.ToString());
                    Items.Clear();
                    
                    if (items.Count() != 0)
                    {
                        foreach (var item in items)
                        {
                            Items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Echec operation: {ex.Message}");
                    if (ex.Message.Contains("Unauthorize"))
                    {
                        var result = await Initial.Get(new LogInModel() { Token = await SecureStorage.GetAsync("Token"), Password = "d", Username = "d" });
                        await GetGammesAsync();
                    }
                    else if (ex.Message.Contains("host"))
                    {
                        DependencyService.Get<IMessage>().ShortAlert("Erreur: Veillez verifier votre connection internet");
                        await GetGammesAsync();
                    }
                    //else DependencyService.Get<IMessage>().ShortAlert("Erreur : " + ex.Message);
                }
                finally
                {
                    IsRunning = false;
                    IsNotBusy = true;
                    UserDialogs.Instance.HideLoading();
                }
            }
            else
            {
                DependencyService.Get<IMessage>().ShortAlert("Problème de connection internet, veillez verifier votre connection !");
            }
        }
    }
}
