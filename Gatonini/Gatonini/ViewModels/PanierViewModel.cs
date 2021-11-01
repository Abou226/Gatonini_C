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

[assembly: Dependency(typeof(ClientService<Reservation>))]
[assembly: Dependency(typeof(ClientService<Num_Vente>))]
[assembly: Dependency(typeof(ClientService<PanierReservation>))]
[assembly: Dependency(typeof(ClientService<Panier>))]
[assembly: Dependency(typeof(ClientInitial))]
[assembly: Dependency(typeof(BaseViewModel))]

namespace Gatonini
{
    public class PanierViewModel : BaseVM.BaseViewModel
    {
        public IBaseViewModel BaseVM { get; }
        private bool _isRunning;

        public bool IsRunning
        {
            get { return _isRunning; }
            set 
            {
                if (_isRunning == value)
                    return;
                _isRunning = value;
                OnPropertyChanged();
            }
        }

        public INavigation Navigation { get; }
        public IInitialService Initial { get; }

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

        public ObservableCollection<PanierReservation> Items { get; }
        public IDataService<PanierReservation> PanierService { get; }
        public IDataService<Reservation> ReservationService { get; }
        public ICommand BackCommand { get; }
       
        public ICommand BuyCommand { get; }

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

        public ICommand DeleteCommand { get; }
        public ICommand RefreshCommand { get; }

        public IDataService<Num_Vente> Num_VenteService { get; }

        public PanierViewModel(INavigation navigation):this()
        {
            Navigation = navigation;
        }
        public PanierViewModel()
        {
            Title = "Panier";
            Items = new ObservableCollection<PanierReservation>();
            BaseVM = DependencyService.Get<IBaseViewModel>();
            PanierService = DependencyService.Get<IDataService<PanierReservation>>();
            Num_VenteService = DependencyService.Get<IDataService<Num_Vente>>();
            ReservationService = DependencyService.Get<IDataService<Reservation>>();
            DeleteCommand = new Command(OnAnnuléeCommand);
            Initial = DependencyService.Get<IInitialService>();
            RefreshCommand = new Command(OnRefreshCommand);
            BuyCommand = new Command(OnAddCommand);
            BackCommand = new Command(OnBackCommand);
            IsNotBusy = false;
            GetPaniersAsync();
        }

        private async void OnRefreshCommand(object obj)
        {
            await GetPaniersAsync();
        }

        private async void OnBackCommand(object obj)
        {
            await Navigation.PopAsync();
        }

        private async void OnAnnuléeCommand(object obj)
        {
            var value = ((PanierReservation)obj);
            if (BaseVM.IsInternetOn)
            {
                if (IsRunning)
                    return;

                try
                {
                    IsRunning = true;
                    UserDialogs.Instance.ShowLoading("Suppression");
                    PanierService.ProjectId = await SecureStorage.GetAsync("Source");
                    var item = await PanierService.DeleteAsync(await SecureStorage.GetAsync("Token"), value, "PanierReservations/" + value.Id.ToString());

                    var items = await PanierService.GetItemsAsync(await SecureStorage.GetAsync("Token"), "PanierReservations");
                    Items.Clear();
                    Total = 0;
                    if (items.Count() != 0)
                    {
                        foreach (var ite in items)
                        {
                            Total += ite.Prix_Vente_Unité;
                            ite.Designation = ite.Gamme.Marque.Name + "-" + ite.Gamme.Style.Name;
                            ite.Autres_Info = ite.Taille.Name + " parts, " + ite.Model.Name;
                            if (ite.Gamme.Url == null)
                                ite.Gamme.Url = ite.Gamme.Marque.Url;
                            Items.Add(ite);
                        }
                    }
                }
                catch (Exception e)
                {
                    if (e.Message.Contains("Unauthorize"))
                    {
                        var result = DependencyService.Get<IInitialService>().Get(new LogInModel() { Token = await SecureStorage.GetAsync("Token") });
                        await GetPaniersAsync();
                    }
                    else if (e.Message.Contains("host"))
                    {
                        BaseVM.IsInternetOn = false;
                    }
                    else DependencyService.Get<IMessage>().LongAlert("Erreur" + e.Message);
                }
                finally
                {
                    IsRunning = false;
                    UserDialogs.Instance.HideLoading();
                }
            }
        }

        private async Task GetPaniersAsync()
        {
            if (BaseVM.IsInternetOn)
            {
                if (IsNotBusy)
                    return;

                try
                {
                    IsNotBusy = false;
                    PanierService.ProjectId = await SecureStorage.GetAsync("Source");
                    var items = await PanierService.GetItemsAsync(await SecureStorage.GetAsync("Token"), "PanierReservations");
                    Items.Clear();
                    Total = 0;
                    Quantité = items.Count();
                    if (items.Count() != 0)
                    {
                        foreach (var item in items)
                        {
                            Total += item.Prix_Vente_Unité;
                            item.Designation = item.Gamme.Marque.Name + "-" + item.Gamme.Style.Name;
                            item.Autres_Info = item.Taille.Name + " parts, " + item.Model.Name;
                            if (item.Gamme.Url == null)
                                item.Gamme.Url = item.Gamme.Marque.Url;
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
                        await GetPaniersAsync();
                    }
                    else if (ex.Message.Contains("host"))
                    {
                        await GetPaniersAsync();
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
                DependencyService.Get<IMessage>().ShortAlert("Problème de connection internet, veillez verifier votre connection !");
            }
        }

        public async void OnAddCommand(object obj)
        {
            if (BaseVM.IsInternetOn)
            {
                if (IsNotBusy)
                    return;

                var valid = await Application.Current.MainPage.DisplayAlert("Confirmation", "Voulez-vous passer cette/ces commande(s) ?", "Oui", "Non");
                if (valid)
                {
                    try
                    {
                        if (Items.Count != 0)
                        {
                            IsRunning = true;
                            IsNotBusy = false;
                            //IsProgressBarVisible = true;
                            UserDialogs.Instance.ShowLoading("Validation....");
                            List<Reservation> list = new List<Reservation>();
                            foreach (var item in Items)
                            {
                                Reservation reservation = new Reservation();
                                reservation.Contact_Livraison = item.Contact_Livraison;
                                reservation.DateOfCreation = DateTime.Now;
                                reservation.Date_Livraison = item.Date_Livraison;
                                reservation.GammeId = item.GammeId;
                                reservation.Heure_Livraison = item.Heure_Livraison;
                                reservation.Mention = item.Mention;
                                reservation.Prix_Vente_Unité = item.Prix_Vente_Unité;
                                reservation.Quantité = Convert.ToInt32(item.Quantité);
                                reservation.Details_Adresse = item.Details_Adresse;
                                reservation.PanierId = item.Id;
                                reservation.ModelId = item.ModelId;
                                reservation.TailleId = item.TailleId;
                                reservation.MarqueId = item.MarqueId;
                                reservation.EntrepriseId = (Guid)item.EntrepriseId;
                                list.Add(reservation);
                            }

                            ReservationService.ProjectId = await SecureStorage.GetAsync("Source");
                            var result = await ReservationService.AddListAsync(list, await SecureStorage.GetAsync("Token"));
                            UserDialogs.Instance.HideLoading();
                            IsRunning = false;
                            await GetPaniersAsync();
                            //if (result != null)
                            {
                                DependencyService.Get<IMessage>().ShortAlert("Opération effectuée avec succès !");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Echec operation: {ex.Message}");
                        if (ex.Message.Contains("Unauthorize"))
                        {
                            var result = await Initial.Get(new LogInModel() { Token = await SecureStorage.GetAsync("Token") });
                            OnAddCommand(obj);
                        }
                        else
                            DependencyService.Get<IMessage>().ShortAlert("Erreur : " + ex.Message);
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
}
