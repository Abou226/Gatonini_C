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

[assembly: Dependency(typeof(ClientService<Vente>))]
[assembly: Dependency(typeof(ClientService<Num_Vente>))]
[assembly: Dependency(typeof(ClientService<Panier>))]
[assembly: Dependency(typeof(ClientService<Gamme>))]
[assembly: Dependency(typeof(ClientService<PanierReservation>))]
[assembly: Dependency(typeof(ClientService<Reservation>))]
[assembly: Dependency(typeof(ClientService<Heure>))]
[assembly: Dependency(typeof(ClientService<Marque>))]
[assembly: Dependency(typeof(ClientService<Model>))]
[assembly: Dependency(typeof(ClientService<Taille>))]

[assembly: Dependency(typeof(ClientInitial))]

namespace Gatonini
{
    public class ProductDetailViewModel : BaseVM.BaseViewModel
    {
        public Model Model { get; set; }
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
        public ICommand BackCommand { get; set; }

        public IMessage MessageAlert { get; }

        private decimal _prix_reel;

        public decimal Prix_Reel
        {
            get => _prix_reel;
            set
            {
                if (_prix_reel == value)
                    return;
                _prix_reel = value;
                OnPropertyChanged();

            }
        }

        private bool _usine;

        public bool Usine
        {
            get { return _usine; }
            set 
            {
                if (_usine == value)
                    return;

                _usine = value;
                OnPropertyChanged();
            }
        }


        public ICommand AddItem { get; }
        private string _adresse_livraison;

        public string Adresse_Livraison
        {
            get => _adresse_livraison;
            set
            {
                if (_adresse_livraison == value)
                    return;
                _adresse_livraison = value;
                OnPropertyChanged();
            }
        }

        private DateTime _date_livraison = DateTime.Today;

        public DateTime Date_Livraison
        {
            get => _date_livraison;
            set
            {
                if (_date_livraison == value)
                    return;

                _date_livraison = value;
                OnPropertyChanged();
                GetHeuresAsync();
            }
        }

            
        public IDataService<Num_Vente> Num_VenteService { get; }
        private string _mention;

        public string Mention
        {
            get => _mention;
            set
            {
                if (_mention == value)
                    return;

                _mention = value;
                OnPropertyChanged();
            }
        }

        private Heure heure;

        public Heure Heure
        {
            get => heure;
            set
            {
                if (heure == value)
                    return;
                heure = value;
                OnPropertyChanged();
            }
        }

        private bool isGateau;

        public bool IsGateau
        {
            get { return isGateau; }
            set 
            {
                if (isGateau == value)
                    return;
                isGateau = value;
                OnPropertyChanged();
            }
        }


        private Taille _taille;

        public Taille Taille
        {
            get => _taille;
            set
            {
                if (_taille == value)
                    return;

                _taille = value;
                OnPropertyChanged();
                if (!string.IsNullOrWhiteSpace(Taille.Name))
                {
                    if(Taille.Categorie.Name == "Gateau" || Taille.Categorie.Name == "Gâteau")
                    {
                        Prix_Reel = Gamme.Prix_Unité * Convert.ToDecimal(Taille.Name);
                        
                        OnPropertyChanged(nameof(Prix_Reel));
                    }
                    else
                    {
                        
                        Prix_Reel = Gamme.Prix_Unité * Convert.ToDecimal(Taille.Name);
                        OnPropertyChanged(nameof(Prix_Reel));
                    }
                }
                else
                {
                    Prix_Reel = 0;
                    OnPropertyChanged(nameof(Prix_Reel));
                }
            }
        }


        

        private string _contact_client;

        public string Contact_Client
        {
            get => _contact_client;
            set
            {
                if (_contact_client == value)
                    return;

                _contact_client = value;
                OnPropertyChanged();
            }
        }

        private string _contact_livraison;
        public string Contact_Livraison
        {
            get => _contact_livraison;
            set
            {
                if (_contact_livraison == value)
                    return;

                _contact_livraison = value;
                OnPropertyChanged();
            }
        }

        public INavigation Navigation { get; }
        private Gamme gamme;

        public Gamme Gamme
        {
            get { return gamme; }
            set 
            {
                if (gamme == value)
                    return;

                gamme = value;
                OnPropertyChanged();
                
                Special = gamme.Style.Style_Special;
            }
        }


        public Marque Marque { get; set; }
        public Style Style { get; set; }
        public ICommand CurrentItem { get; }
        public ObservableCollection<Gamme> Gammes { get; }
        public ObservableCollection<Taille> Tailles { get; }
        public ObservableCollection<Model> Models { get; }
        
        public IDataService<Gamme> GammeService { get; }
        public IDataService<Heure> HeureService { get; }
        public IDataService<Marque> MarqueService { get; }
        public IDataService<Taille> TailleService { get; }
        public ObservableCollection<Marque> Marques { get; }
        public Command GammeChangedCommand { get; }
        public IDataService<Reservation> ReservationService { get; }
        public IDataService<Model> ModelService { get; }

        private bool special;

        public bool Special
        {
            get { return special; }
            set 
            {
                if (special == value)
                    return;
                special = value;
                OnPropertyChanged();
            }
        }

        public IDataService<PanierReservation> PanierVenteService { get; }
        public IInitialService Initial { get; }
        public ICommand BuyCommand { get; }
        public ICommand PanierCommand { get; }
        public IBaseViewModel BaseVM { get; }
        public ObservableCollection<Heure> Heures { get; }

        public ProductDetailViewModel(Gamme gamme, INavigation navigation) : this()
        {
            Gamme = gamme;
            Navigation = navigation;
            Title = Gamme.Marque.Name;
            Marque = Gamme.Marque;
            Style = Gamme.Style;
            if (Gamme.Categorie.Name == "Gateau" || Gamme.Categorie.Name == "Gâteau"
                || Gamme.Categorie.Name == "Gateaux" || Gamme.Categorie.Name == "Gâteaux")
                IsGateau = true;
            GetProductsAsync(Gamme);
            IsNotBusy = false;
        }

        private Quartier _quartier;

        public Quartier Quartier
        {
            get { return _quartier; }
            set 
            {
                if (_quartier == value)
                    return;

                _quartier = value;
                OnPropertyChanged();
            }
        }


        public ProductDetailViewModel()
        {
            Title = "Details Offres";
            BaseVM = DependencyService.Get<IBaseViewModel>();
            //Taille = new Taille();
            CurrentItem = new Command(OnCurrentItem);
            TailleService = DependencyService.Get<IDataService<Taille>>();
            HeureService = DependencyService.Get<IDataService<Heure>>();
            ReservationService = DependencyService.Get<IDataService<Reservation>>();
            Heures = new ObservableCollection<Heure>();
            Heures = new ObservableCollection<Heure>();
            GammeChangedCommand = new Command(OnGammeChangedCommand);
            Initial = DependencyService.Get<IInitialService>();
            PanierVenteService = DependencyService.Get<IDataService<PanierReservation>>();
            MarqueService = DependencyService.Get<IDataService<Marque>>();
            Marques = new ObservableCollection<Marque>();
            Num_VenteService = DependencyService.Get<IDataService<Num_Vente>>();
            ModelService = DependencyService.Get<IDataService<Model>>();
            BuyCommand = new Command(OnBuyCommand);
            Gammes = new ObservableCollection<Gamme>();
            MessageAlert = DependencyService.Get<IMessage>();
            Models = new ObservableCollection<Model>();
            Tailles = new ObservableCollection<Taille>();
            GammeService = DependencyService.Get<IDataService<Gamme>>();
            BackCommand = new Command(OnBackCommand);
            AddItem = new Command(OnAddItem);
            PanierCommand = new Command(OnPanierCommand);
        }

        private void OnGammeChangedCommand(object obj)
        {
            if(obj != null)
            {
                Gamme = ((Gamme)obj);
                Taille = null;
                Marque = Gamme.Marque;
                Style = Gamme.Style;
            }
        }

        private void OnCurrentItem(object obj)
        {
            if (obj != null)
            {
                Gamme = ((Gamme)obj);
                Marque = Gamme.Marque;
                Style = Gamme.Style;
            }
        }

        private async void OnPanierCommand(object obj)
        {
            await Navigation.PushAsync(new PanierPage());
        }


        private async Task GetHeuresAsync()
        {
            if (BaseVM.IsInternetOn)
            {
                if (IsNotBusy)
                    return;

                try
                {
                    IsRunning = true;
                    IsNotBusy = false;
                    UserDialogs.Instance.ShowLoading("Chargement.....");

                    HeureService.ProjectId = await SecureStorage.GetAsync("Source");
                    var heures = await HeureService.GetItemsAsync(await SecureStorage.GetAsync("Token"), "Heures/" + Date_Livraison.ToString("MM-dd-yyyy"));
                    Heures.Clear();
                    if (heures.Count() != 0)
                    {
                        foreach (var item in heures)
                        {
                            Heures.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Echec operation: {ex.Message}");
                    if (ex.Message.Contains("Unauthorize"))
                    {
                        var result = await Initial.Get(new LogInModel() { Token = await SecureStorage.GetAsync("Token"), Password = "d", Username = "d" });
                        await SecureStorage.SetAsync("Token", result.Token);
                        await SecureStorage.SetAsync("Prenom", result.Prenom);
                        await SecureStorage.SetAsync("Nom", result.Nom);
                        await SecureStorage.SetAsync("ProfilePic", result.ProfilePic);
                        await GetHeuresAsync();
                    }
                    else if (ex.Message.Contains("host"))
                    {
                        await GetHeuresAsync();
                    }
                    else MessageAlert.LongAlert("Erreur" + ex.Message);
                }
                finally
                {
                    IsRunning = false;
                    IsNotBusy = true;
                    UserDialogs.Instance.HideLoading();
                }
            }
            else MessageAlert.ShortAlert("Veillez verifier votre connection internet");
        }
        private async Task GetProductsAsync(Gamme gamme)
        {
            if (BaseVM.IsInternetOn)
            {
                if (IsNotBusy)
                    return;

                try
                {
                    IsRunning = true;
                    IsNotBusy = false;
                    UserDialogs.Instance.ShowLoading("Chargement.....");
                    GammeService.ProjectId = await SecureStorage.GetAsync("Source");
                    var items = await GammeService.GetItemsAsync(await SecureStorage.GetAsync("Token"), "Gammes/single/"+Gamme.Id.ToString());
                    Gammes.Clear();
                    if (items.Count() != 0)
                    {
                        Marque = items.First().Marque;
                        Style = items.First().Style;
                        foreach (var item in items)
                        {
                            if (item.Url == null)
                                item.Url = item.Marque.Url;
                            //item.Designation = item.Marque.Name + "-" + item.Style.Name;
                            if (item.Prix_Min == 0)
                            {
                                item.Prix_Min = item.Prix_Unité * 6;
                            }
                            Gammes.Add(item);
                        }
                        Gamme = Gammes.First();
                    }

                    ModelService.ProjectId = await SecureStorage.GetAsync("Source");
                    var models = await ModelService.GetItemsAsync(await SecureStorage.GetAsync("Token"), "Models");
                    Models.Clear();
                    if (models.Count() != 0)
                    {
                        foreach (var item in models)
                        {
                            Models.Add(item);
                        }
                    }

                    if (Special)
                    {
                        MarqueService.ProjectId = await SecureStorage.GetAsync("Source");
                        var marques = await MarqueService.GetItemsAsync(await SecureStorage.GetAsync("Token"), "Marques");
                        Marques.Clear();
                        if (marques.Count() != 0)
                        {
                            foreach (var item in marques)
                            {
                                Marques.Add(item);
                            }
                        }
                    }
                    

                    HeureService.ProjectId = await SecureStorage.GetAsync("Source");
                    var heures = await HeureService.GetItemsAsync(await SecureStorage.GetAsync("Token"), "Heures/" + Date_Livraison.ToString("MM-dd-yyyy"));
                    Heures.Clear();
                    if(heures.Count() != 0)
                    {
                        foreach (var item in heures)
                        {
                            Heures.Add(item);
                        }
                    }

                    if (IsGateau)
                    {
                        TailleService.ProjectId = await SecureStorage.GetAsync("Source");
                        var tailles = await TailleService.GetItemsAsync(await SecureStorage.GetAsync("Token"), "Tailles");
                        Tailles.Clear();
                        if (tailles.Count() != 0)
                        {
                            foreach (var item in tailles)
                            {
                                Tailles.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Echec operation: {ex.Message}");
                    if (ex.Message.Contains("Unauthorize"))
                    {
                        var result = await Initial.Get(new LogInModel() { Token = await SecureStorage.GetAsync("Token"), Password = "d", Username = "d" });
                        await SecureStorage.SetAsync("Token", result.Token);
                        await SecureStorage.SetAsync("Prenom", result.Prenom);
                        await SecureStorage.SetAsync("Nom", result.Nom);
                        await SecureStorage.SetAsync("ProfilePic", result.ProfilePic);
                        await GetProductsAsync(gamme);
                    }
                    else if (ex.Message.Contains("host"))
                    {
                        await GetProductsAsync(gamme);
                    }
                    else MessageAlert.LongAlert("Erreur" + ex.Message);
                }
                finally
                {
                    IsRunning = false;
                    IsNotBusy = true;
                    UserDialogs.Instance.HideLoading();
                }
            }
            else MessageAlert.ShortAlert("Veillez verifier votre connection internet");
        }

        private async void OnBuyCommand(object obj)
        {
            if (Prix_Reel != 0 && Taille != null && Model != null
                && !string.IsNullOrWhiteSpace(Adresse_Livraison) 
                && !string.IsNullOrWhiteSpace(Mention)
                && Heure != null && !string.IsNullOrWhiteSpace(Contact_Livraison))
            {
                var valide = await Application.Current.MainPage.DisplayAlert("Confirmation", "Voulez-vous passer cette commande ?", "Oui", "Non");
                if (valide)
                {
                    if (BaseVM.IsInternetOn)
                    {
                        if (IsNotBusy)
                            return;

                        try
                        {
                            IsRunning = true;
                            IsNotBusy = false;
                            UserDialogs.Instance.ShowLoading("Validation");
                            //var num_vente = await Num_VenteService.GetItemAsync(await SecureStorage.GetAsync("Token"), "Num_Ventes/create");

                            //if (num_vente != null)
                            {
                                var list = new List<Reservation>();
                                if (Special)
                                {
                                    if(Marque != null)
                                    {
                                        list.Add(new Reservation()
                                        {
                                            Contact_Livraison = Contact_Livraison,
                                            Prix_Vente_Unité = Prix_Reel,
                                            Quantité = 1,
                                            Date_Livraison = Date_Livraison,
                                            Heure_Livraison = Heure.Name,
                                            Mention = Mention,
                                            Details_Adresse = Adresse_Livraison,
                                            EntrepriseId = Gamme.Entreprise.Id,
                                            DateOfCreation = DateTime.Now,
                                            GammeId = Gamme.Id,
                                            TailleId = Taille.Id,
                                            ModelId = Model.Id,
                                            MarqueId = Marque.Id,
                                        });
                                        ReservationService.ProjectId = await SecureStorage.GetAsync("Source");
                                        var item = await ReservationService.AddListAsync(list, await SecureStorage.GetAsync("Token"));
                                        ClearData();
                                        if (item != null)
                                            MessageAlert.LongAlert("Commande effectué avec succès");
                                    }
                                    else DependencyService.Get<IMessage>().LongAlert("Veillez selectionner une saveur..");
                                    
                                }
                                else
                                {
                                    list.Add(new Reservation()
                                    {
                                        Contact_Livraison = Contact_Livraison,
                                        Prix_Vente_Unité = Prix_Reel,
                                        Quantité = 1,
                                        Date_Livraison = Date_Livraison,
                                        Heure_Livraison = Heure.Name,
                                        Mention = Mention,
                                        Details_Adresse = Adresse_Livraison,
                                        EntrepriseId = Gamme.Entreprise.Id,
                                        DateOfCreation = DateTime.Now,
                                        GammeId = Gamme.Id,
                                        TailleId = Taille.Id,
                                        ModelId = Model.Id,
                                    });
                                    ReservationService.ProjectId = await SecureStorage.GetAsync("Source");
                                    var item = await ReservationService.AddListAsync(list, await SecureStorage.GetAsync("Token"));
                                    ClearData();
                                    if (item != null)
                                        MessageAlert.LongAlert("Commande effectué avec succès");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"Echec operation: {ex.Message}");
                            if (ex.Message.Contains("Unauthorize"))
                            {
                                var result = await Initial.Get(new LogInModel() { Token = await SecureStorage.GetAsync("Token") });
                                await SecureStorage.SetAsync("Token", result.Token);
                                await SecureStorage.SetAsync("Prenom", result.Prenom);
                                await SecureStorage.SetAsync("Nom", result.Nom);
                                await SecureStorage.SetAsync("ProfilePic", result.ProfilePic);
                                OnBuyCommand(obj);
                            }
                            else MessageAlert.LongAlert("Erreur" + ex.Message);
                        }
                        finally
                        {
                            IsRunning = false;
                            IsNotBusy = true;
                            UserDialogs.Instance.HideLoading();
                        }
                    }
                    else MessageAlert.ShortAlert("Veillez verifier votre connection internet");
                }
            }
            else MessageAlert.ShortAlert("Veillez remplir tous les champs de données");
        }

        private void ClearData()
        {
            Adresse_Livraison = null;
            Contact_Livraison = null;
            Contact_Client = null;
            Heure = null;
            Mention = null;
        }

        private async void OnAddItem(object obj)
        {
            if (!IsGateau)
            {
                Taille.Name = "d";
            }
            if (Prix_Reel != 0 && Taille != null && Model != null
                && !string.IsNullOrWhiteSpace(Adresse_Livraison) 
                && !string.IsNullOrWhiteSpace(Mention)
                && Heure != null 
                && !string.IsNullOrWhiteSpace(Contact_Livraison))
            {
                if (BaseVM.IsInternetOn)
                {
                    if (IsNotBusy)
                        return;

                    try
                    {
                        IsRunning = true;
                        IsNotBusy = false;
                        if (Taille.Name == "d")
                            Taille.Name = null;
                        UserDialogs.Instance.ShowLoading("Validation");
                        var list = new List<PanierReservation>();

                        if (Special)
                        {
                            if (Marque != null)
                            {
                                list.Add(new PanierReservation()
                                {
                                    Contact_Livraison = Contact_Livraison,
                                    Prix_Vente_Unité = Prix_Reel,
                                    Mention = Mention,
                                    Quantité = 1,
                                    Date_Livraison = Date_Livraison,
                                    Heure_Livraison = Heure.Name,
                                    Adresse_Livraison = Adresse_Livraison,
                                    Details_Adresse = Adresse_Livraison,
                                    GammeId = Gamme.Id,
                                    TailleId = Taille.Id,
                                    ModelId = Model.Id,
                                    MarqueId = Marque.Id,
                                    EntrepriseId = Gamme.EntrepriseId,
                                });
                                PanierVenteService.ProjectId = await SecureStorage.GetAsync("Source");
                                var item = await PanierVenteService.AddListAsync(list, await SecureStorage.GetAsync("Token"));

                                ClearData();
                                if (item != null)
                                    MessageAlert.LongAlert("Element ajouté à votre panier avec succès.");
                            }
                            else DependencyService.Get<IMessage>().LongAlert("Veillez selectionner une saveur..");
                        }
                        else
                        {
                            list.Add(new PanierReservation()
                            {
                                Contact_Livraison = Contact_Livraison,
                                Prix_Vente_Unité = Prix_Reel,
                                Mention = Mention,
                                Quantité = 1,
                                Date_Livraison = Date_Livraison,
                                Heure_Livraison = Heure.Name,
                                Adresse_Livraison = Adresse_Livraison,
                                Details_Adresse = Adresse_Livraison,
                                GammeId = Gamme.Id,
                                TailleId = Taille.Id,
                                ModelId = Model.Id,
                                EntrepriseId = Gamme.EntrepriseId,
                            });
                            PanierVenteService.ProjectId = await SecureStorage.GetAsync("Source");
                            var item = await PanierVenteService.AddListAsync(list, await SecureStorage.GetAsync("Token"));

                            ClearData();
                            if (item != null)
                                MessageAlert.LongAlert("Element ajouté à votre panier avec succès.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Echec operation: {ex.Message}");
                        if (ex.Message.Contains("Unauthorize"))
                        {
                            var result = await Initial.Get(new LogInModel() { Token = await SecureStorage.GetAsync("Token") });
                            OnBuyCommand(obj);
                        }
                        else
                            MessageAlert.LongAlert("Erreur" + ex.Message);
                    }
                    finally
                    {
                        IsRunning = false;
                        IsNotBusy = true;
                        UserDialogs.Instance.HideLoading();
                    }
                }
                else MessageAlert.ShortAlert("Veillez verifier votre connection internet");
            }
            else MessageAlert.ShortAlert("Veillez remplir tous les champs de données");
        }

        private async void OnBackCommand(object obj)
        {
            await Navigation.PopAsync();
        }
    }
}
