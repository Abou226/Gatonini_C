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

[assembly: Dependency(typeof(ClientService<Vente>))]
[assembly: Dependency(typeof(ClientService<Reservation>))]
[assembly: Dependency(typeof(BaseViewModel))]
[assembly: Dependency(typeof(ClientService<EditObject>))]
[assembly: Dependency(typeof(ClientInitial))]

namespace Gatonini
{
    public class VenteViewModel : BaseVM.BaseViewModel
    {
        public IBaseViewModel BaseVM { get; }
        public ICommand RefreshCommand { get; }
        public bool IsRunning { get; set; }
        public INavigation Navigation { get; }
        public IInitialService Initial { get; }

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

        private string searchText;

        public string SearchText
        {
            get { return searchText; }
            set 
            {
                if (searchText == value)
                    return;

                searchText = value;
                OnPropertyChanged();
                OnSearchCommand(searchText);
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

        public ObservableCollection<Reservation> Items { get; }
        public ObservableCollection<Reservation> InitialItems { get; }
        public IDataService<Reservation> ClientService { get; }
        public ICommand BackCommand { get; }
        public ICommand SearchCommand { get; }
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
        public IDataService<EditObject> EditService { get; }

        public VenteViewModel(INavigation navigation): this()
        {
            Navigation = navigation;
            GetVentes(Start, End);
        }

        public VenteViewModel()
        {
            Title = "Commandes";
            Items = new ObservableCollection<Reservation>();
            BaseVM = DependencyService.Get<IBaseViewModel>();
            BackCommand = new Command(OnBackCommand);
            InitialItems = new ObservableCollection<Reservation>();
            SearchCommand = new Command(OnSearchCommand);
            ClientService = DependencyService.Get<IDataService<Reservation>>();
            AnnuléeCommand = new Command(OnAnnuléeCommand);
            Initial = DependencyService.Get<IInitialService>();
            RefreshCommand = new Command(OnRefreshCommand);
            EditService = DependencyService.Get<IDataService<EditObject>>();
            IsNotBusy = false;
        }

        private async void OnBackCommand(object obj)
        {
            await Navigation.PopAsync();
        }

        private async void OnRefreshCommand(object obj)
        {
            await GetVentes(Start, End);
        }

        private async void OnAnnuléeCommand(object obj)
        {
            var result = await Application.Current.MainPage.DisplayAlert("Confirmation", "Voulez-vous vraiment annuler cette commande ?", "Oui", "Non");
            if(result)
            {
                await Annulée(((Reservation)obj));
            }
        }

        private void OnSearchCommand(object obj)
        {
            var search = ((string)obj);
            if (!string.IsNullOrWhiteSpace(search))
            {
                if (Items.Count() != 0)
                {
                    var items = (from d in Items
                                where d.Details_Adresse.Contains(search)
                                || d.Autres_Info.Contains(search)
                                || d.Client.Nom.Contains(search) 
                                || d.Client.Prenom.Contains(search)
                                || d.Contact_Livraison.Contains(search)
                                || d.Prix_Vente_Unité.ToString().Equals(search)
                                || d.Designation.Contains(search)
                                select d).ToList();
                    //if (items.Count() != 0)
                    {
                        Items.Clear();
                        Total = 0;
                        Quantité = items.Count();
                        if(items.Count() != 0)
                        foreach (var item in items)
                        {
                            Total += item.Prix_Vente_Unité;
                            Items.Add(item);
                        }
                    }
                }
            }
            else
            {
                Items.Clear();
                Total = 0;
                Quantité = InitialItems.Count();
                foreach (var item in InitialItems)
                {
                    Total += item.Prix_Vente_Unité;
                    Items.Add(item);
                }
            }
        }

        private async Task Annulée(Reservation reservation)
        {
            if (BaseVM.IsInternetOn)
            {
                if (IsNotBusy)
                    return;

                try
                {
                    IsNotBusy = false;
                    List<EditObject> list = new List<EditObject>();
                    list.Add(new EditObject() { Op = "Replace", Value = "True", Path = "Annulée" });
                    var item = await EditService.UpdateListAsync(list, await SecureStorage.GetAsync("Token"), "reservations/" + reservation.Id.ToString());

                    if (item.Count() != 0)
                    {
                        IsNotBusy = true;
                        DependencyService.Get<IMessage>().LongAlert("Element annulé avec succès");
                        await GetVentes(Start, End);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Echec operation: {ex.Message}");
                    if (ex.Message.Contains("Unauthorize"))
                    {
                        var result = await Initial.Get(new LogInModel()
                        { Token = await SecureStorage.GetAsync("Token"), Password = "d", Username = "d" });
                        await GetVentes(Start, Start);
                    }
                    else if (ex.Message.Contains("host"))
                    {
                        DependencyService.Get<IMessage>().LongAlert("Erreur: Veillez verifier votre connection internet");
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
        }

        public ICommand AnnuléeCommand { get; set; }

        public void OnAddCommand(object obj)
        {

        }

        private async Task GetVentes(DateTime start, DateTime end)
        {
            if (BaseVM.IsInternetOn)
            {
                if (IsNotBusy)
                    return;

                try
                {
                    IsRunning = true;
                    IsNotBusy = false;
                    UserDialogs.Instance.ShowLoading("Chargement....");
                    ClientService.ProjectId = await SecureStorage.GetAsync("Source");
                    var Vente = await ClientService.GetItemsAsync(await SecureStorage.GetAsync("Token"), "reservations/" + start.ToString("MM-dd-yyyy") + "/" + end.ToString("MM-dd-yyyy"));
                    Items.Clear();
                    Total = 0;
                    Quantité = Vente.Count();
                    InitialItems.Clear();
                    if (Vente.Count() != 0)
                    {
                        foreach (var item in Vente)
                        {
                            Total += item.Prix_Vente_Unité;
                            string marque = "";
                            if (item.Gamme.Marque == null)
                                marque = item.Marque.Name;
                            else marque = item.Gamme.Marque.Name;
                            item.Designation = marque + "_" + item.Gamme.Style.Name;
                            item.Autres_Info = item.Taille.Name + " parts, " + item.Model.Name;
                            if (item.Gamme.Url == null)
                                item.Gamme.Url = item.Gamme.Marque.Url;
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
                        var result = await Initial.Get(new LogInModel()
                        { Token = await SecureStorage.GetAsync("Token"), Password = "d", Username = "d" });
                        await GetVentes(start, end);
                    }
                    else if (ex.Message.Contains("host"))
                    {
                        BaseVM.IsInternetOn = false;
                    }
                    else await Application.Current.MainPage.DisplayAlert("Erreur", ex.Message, "Ok");
                }
                finally
                {
                    IsRunning = false;
                    IsNotBusy = true;
                    UserDialogs.Instance.HideLoading();
                }
            }
        }
    }
}
