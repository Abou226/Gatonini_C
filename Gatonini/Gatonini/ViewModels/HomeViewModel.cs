using Acr.UserDialogs;
using Gatonini.BaseVM;
using Gatonini.Models;
using Gatonini.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

[assembly: Dependency(typeof(DataService<Reservation>))]
[assembly: Dependency(typeof(DataService<Payement>))]
[assembly: Dependency(typeof(DataService<Livraison>))]

[assembly: Dependency(typeof(DataService<Categorie>))]
[assembly: Dependency(typeof(DataService<Departement>))]
[assembly: Dependency(typeof(BaseViewModel))]
[assembly: Dependency(typeof(InitialService))]
namespace Gatonini
{
    public class HomeViewModel : BaseVM.BaseViewModel
    {
        public INavigation Navigation { get; }
        public IInitialService Initial { get; }
        public ObservableCollection<Departement> Departements { get; }
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

        public ObservableCollection<Section> Sections { get; }
        public ObservableCollection<object> Details { get; }
        public ICommand SectionTapped { get; }
        public ICommand ReservationCommand { get; }
        public ICommand LivraisonCommand { get; }
        public ICommand PayementCommand { get; }
        public ICommand DepartementTapped { get; }
        public IDataService<Payement> PayementService { get; }
        public IDataService<Livraison> LivraisonService { get; }
        public IDataService<Reservation> ReservationService { get; }
        public IBaseViewModel BaseVM { get; }
        public HomeViewModel()
        {
            Departements = new ObservableCollection<Departement>();
            Sections = new ObservableCollection<Section>();
            BaseVM = DependencyService.Get<IBaseViewModel>();
            ReservationCommand = new Command(OnReservationCommand);
            Details = new ObservableCollection<object>();
            PayementService = DependencyService.Get<IDataService<Payement>>();
            LivraisonService = DependencyService.Get<IDataService<Livraison>>();
            ReservationService = DependencyService.Get<IDataService<Reservation>>();
            Initial = DependencyService.Get<IInitialService>();
            DepartementTapped = new Command(OnDepartementTapped);
            LivraisonCommand = new Command(OnLivraisonCommand);
            PayementCommand = new Command(OnPayementCommand);
            SectionTapped = new Command(OnSectionTapped);
            GetDepartements();
        }

        private void OnPayementCommand(object obj)
        {
            
        }

        private void OnLivraisonCommand(object obj)
        {
            
        }

        private void OnReservationCommand(object obj)
        {
            
        }

        private async void OnSectionTapped(object obj)
        {
            await DetailsAsync((Section)obj);
        }

        private async void OnDepartementTapped(object obj)
        {
           await GetSections(((Departement)obj).Name);
        }

        public HomeViewModel(INavigation navigation) : this()
        {
            Navigation = navigation;
        }

        public bool Admin { get; set; }
        public bool IsRunning { get; set; }

        private async Task GetDepartements()
        {
            var items = new ObservableCollection<Departement>() { 
                new Departement()
                {
                    Name = "Commerciaux",
                    Url = "Sales.png",
                },
                new Departement()
                {
                    Name = "Logistique",
                    Url = "delivery",
                },
                new Departement()
                {
                    Name = "Cuisine",
                    Url = "Cook.png"
                },
                new Departement()
                {
                    Name = "Administration",
                    Url = "Admin",
                }, new Departement()
                {
                    Name = "Gestion",
                }
            };

            Departements.Clear();
            foreach (var item in items)
            {
                Departements.Add(item);
            }
        }

        private async Task GetSections(string departement)
        {
            var items = new List<Section>()
            {
                new Section()
                {
                    Name = "Livraison",
                    Departement = new Departement()
                    {
                        Name = "Logistique",
                    },
                   
                },
                new Section()
                {
                    Name = "Etape Finition",
                    Departement = new Departement(){Name = "Cuisine"}
                },
                new Section()
                {
                    Name = "Requette Base",
                    Departement = new Departement(){Name = "Cuisine"},
                },
                new Section()
                {
                    Name = "Payement",
                    Departement = new Departement()
                    {
                        Name = "Commerciaux"
                    }
                },
                new Section()
                {
                    Name = "Payement",
                    Departement = new Departement()
                    {
                        Name = "Gestion"
                    }
                },
                new Section()
                {
                    Name = "Reservations",
                    Departement = new Departement()
                    {
                        Name = "Commerciaux"
                    }
                },
                new Section()
                {
                    Name = "Reservation",
                    Departement = new Departement()
                    {
                        Name = "Gestion"
                    }
                },
                new Section()
                {
                    Name = "Livraision",
                    Departement = new Departement()
                    {
                        Name = "Commerciaux"
                    }
                },
            };
            var ites = from d in items where d.Departement.Name.Contains(departement) select d;
            Sections.Clear();
            foreach (var item in ites)
            {
                Sections.Add(item);
            }
        }  

        private async Task DetailsAsync(Section section)
        {
            if (BaseVM.IsInternetOn)
            {
                if (IsRunning)
                    return;

                try
                {
                    IsRunning = true;
                    IEnumerable<object> items;
                    if (section.Name == "Payement")
                    {
                        items = await PayementService.GetItemsAsync(await SecureStorage.GetAsync("Token"), "Payements/" + DateToString(Start, End));
                        items = (ObservableCollection<Payement>)items;
                    }
                    else if (section.Name == "Livraison")
                    {
                        items = await LivraisonService.GetItemsAsync(await SecureStorage.GetAsync("Token"), "Livraisons/" + DateToString(Start, End));
                        items = (ObservableCollection<Livraison>)items;
                    }
                    else if (section.Name == "Reservations")
                    {
                        items = await ReservationService.GetItemsAsync(await SecureStorage.GetAsync("Token"), "Reservations/" + DateToString(Start, End));
                        items = (ObservableCollection<Reservation>)items;
                    }
                    else if (section.Name == "Etape Finition")
                    {
                        items = await PayementService.GetItemsAsync(await SecureStorage.GetAsync("Token"), "Reservations/finition/" + DateToString(Start, End));
                        items = (ObservableCollection<Reservation>)items;
                    }
                    else items = null;
                    
                    Details.Clear();
                    foreach (var item in items)
                    {
                        Details.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Echec operation: {ex.Message}");
                    if (ex.Message.Contains("Unauthorize"))
                    {
                        var result = await Initial.Get(new LogInModel() { Token = await SecureStorage.GetAsync("Token"), Password = "d", Username = "d" });
                        await SecureStorage.SetAsync("Token", result.Token);
                        await SecureStorage.SetAsync("AwsAccessKey", result.AwsAccessKey);
                        await SecureStorage.SetAsync("AwsSecretKey", result.AwsSecretKey);
                        await SecureStorage.SetAsync("BucketName", result.BucketName);
                        IsRunning = false;
                        await DetailsAsync(section);
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
                    UserDialogs.Instance.HideLoading();
                }
            }
        }
    }
}
