using Acr.UserDialogs;
using BaseVM;
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

[assembly: Dependency(typeof(ClientService<Payement>))]
[assembly: Dependency(typeof(BaseViewModel))]
[assembly: Dependency(typeof(ClientInitial))]

namespace Gatonini
{
    public class RapportPayementViewModel : BaseVM.BaseViewModel
    {
        public IBaseViewModel BaseVM { get; }
        public bool IsRunning { get; set; }
        public ICommand RefreshCommand { get; }
        public INavigation Navigation { get; }
        public IInitialService Initial { get; }

        private int _quantité;

        public int Quantité
        {
            get { return _quantité; }
            set
            {
                if (_quantité == value)
                    return;

                _quantité = value;
                OnPropertyChanged();
            }
        }

        private DateTime _end = DateTime.Today;
        public DateTime End
        {
            get => _end;
            set
            {
                if (_end == value)
                    return;

                _end = value;
                OnPropertyChanged();
            }
        }

        private DateTime _start = DateTime.Today;
        public DateTime Start
        {
            get => _start;
            set
            {
                if (_start == value)
                    return;

                _start = value;
                OnPropertyChanged();
            }
        }

        private decimal _total;

        public decimal Total
        {
            get => _total;
            set
            {
                if (_total == value)
                    return;
                _total = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Payement> Items { get; }
        public ObservableCollection<Payement> InitialItems { get; }
        public IDataService<Payement> ClientService { get; }
        public RapportPayementViewModel(INavigation navigation) : this()
        {
            Navigation = navigation;
            GetItemsAsync();
        }
        public ICommand BuyCommand { get; }
        public ICommand AnnuléeCommand { get; }
        public ICommand BackCommand { get; }

        public RapportPayementViewModel()
        {
            Title = "Payements";
            Items = new ObservableCollection<Payement>();
            BackCommand = new Command(OnBackCommand);
            BaseVM = DependencyService.Get<IBaseViewModel>();
            RefreshCommand = new Command(OnRefreshCommand);
            InitialItems = new ObservableCollection<Payement>();
            ClientService = DependencyService.Get<IDataService<Payement>>();
            AnnuléeCommand = new Command(OnAnnuléeCommand);
            Initial = DependencyService.Get<IInitialService>();
            IsNotBusy = false;
        }

        private void OnSearchCommand(object obj)
        {
            var search = ((string)obj);
            if (!string.IsNullOrWhiteSpace(search))
            {
                if (Items.Count() != 0)
                {
                    var items = (from d in Items
                                where d.Nature.Contains(search)
                                || d.Montant.ToString().Equals(search)
                                || d.Num_Operation.Contains(search)
                                || d.Type.Contains(search)
                                select d).ToList();
                    //if (items.Count() != 0)
                    {
                        Items.Clear();
                        Total = 0;
                        Quantité = items.Count();
                        foreach (var item in items)
                        {
                            Total += item.Montant;
                            Items.Add(item);
                        }
                    }
                }
            }
            else
            {
                Items.Clear();
                foreach (var item in InitialItems)
                {
                    Items.Add(item);
                }
            }
        }

        private async void OnRefreshCommand(object obj)
        {
            await GetItemsAsync();
        }

        private async void OnBackCommand(object obj)
        {
            await Navigation.PopAsync();
        }

        private void OnAnnuléeCommand(object obj)
        {
            if (BaseVM.IsInternetOn)
            {
                if (IsNotBusy)
                {
                    try
                    {
                        //var item = await PanierService.DeleteAsync()
                    }
                    catch (Exception e)
                    {

                    }
                }
            }
        }

        private async Task GetItemsAsync()
        {
            if (BaseVM.IsInternetOn)
            {
                if (IsNotBusy)
                    return;

                try
                {
                    IsNotBusy = false;
                    ClientService.ProjectId = await SecureStorage.GetAsync("Source");
                    var items = await ClientService.GetItemsAsync(await SecureStorage.GetAsync("Token"), "Payements/" + Start.ToString("MM-dd-yyyy") + "/" + End.ToString("MM-dd-yyyy"));
                    Quantité = items.Count();
                    if (items.Count() != 0)
                    {
                        Items.Clear();
                        Total = 0;

                        InitialItems.Clear();
                        foreach (var item in items)
                        {
                            Total += item.Montant;
                            Items.Add(item);
                            InitialItems.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Echec operation: {ex.Message}");
                    if (ex.Message.Contains("Unauthorize"))
                    {
                        var result = await Initial.Get(new LogInModel() { Token = await SecureStorage.GetAsync("Token"), Password = "d", Username = "d" });
                        await GetItemsAsync();
                    }
                    else if (ex.Message.Contains("host"))
                    {
                        await GetItemsAsync();
                    }
                    else DependencyService.Get<IMessage>().ShortAlert("Erreur : " + ex.Message);
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
                await Application.Current.MainPage.DisplayAlert("No internet", "Problème de connection internet, veillez verifier votre connection !", "OK");
            }
        }
    }
}
