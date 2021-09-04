using Acr.UserDialogs;
using Gatonini.BaseVM;
using Gatonini.Models;
using Gatonini.Services;
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

[assembly: Dependency(typeof(DataService<Produit>))]
[assembly: Dependency(typeof(DataService<Categorie>))]
[assembly: Dependency(typeof(DataService<Payement>))]
[assembly: Dependency(typeof(DataService<Commande>))]
[assembly: Dependency(typeof(BaseViewModel))]
[assembly: Dependency(typeof(InitialService))]

namespace Gatonini
{
    public class HomeViewModel : BaseVM.BaseViewModel
    {
        public IBaseViewModel BaseVM { get; }
        public IDataService<Produit> ProduitService { get; }
        public ObservableCollection<Section> Sections { get; }
        public ObservableCollection<Departement> Departements { get; }
        public INavigation Navigation { get; }
        public IDataService<Commande> CommandeService { get; }
        public IDataService<Payement> PayementService { get; }
        public ICommand DepartementTapped { get; }
        public IInitialService Initial { get; }
        public HomeViewModel()
        {
            CommandeService = DependencyService.Get<IDataService<Commande>>();
            DepartementTapped = new Command(OnDepartementTapped);
            PayementService = DependencyService.Get<IDataService<Payement>>();
        }

        private void OnDepartementTapped(object obj)
        {
            var departement = ((Departement)obj);

        }

        public HomeViewModel(INavigation navigation) : this()
        {

        }

        private void GetSection(Departement departement)
        {
            var list = new List<Section>()
            {
                new Section()
                {
                    Name = "Reservations",
                    Departement = new Departement()
                    {
                        Name = "Commerciaux",
                    },
                },
                new Section()
                {
                    Name = "Payements",
                    Departement = new Departement()
                    {
                        Name = "Commerciaux",
                    },
                },
                new Section()
                {
                    Name = "Livraisons",
                    Departement = new Departement()
                    {
                        Name = "Commerciaux",
                    },
                },
                new Section()
                {
                    Name = "Livraisons",
                    Departement = new Departement()
                    {
                        Name = "Logistique",
                    },
                },
                new Section()
                {
                    Name = "Prevision Gateaux",
                    Departement = new Departement()
                    {
                        Name = "Logistique",
                    },
                },
                new Section()
                {
                    Name = "Ingredients",
                    Departement = new Departement()
                    {
                        Name = "Stock",
                    },
                },
                new Section()
                {
                    Name = "Usage Ingrdient",
                    Departement = new Departement()
                    {
                        Name = "Stock",
                    },
                },
                new Section()
                {
                    Name = "Etape Finition",
                    Departement = new Departement()
                    {
                        Name = "Cuisine",
                    },
                }, 
                new Section()
                {
                    Name = "Gateau Bases",
                    Departement = new Departement()
                    {
                        Name = "Cuisine",
                    },
                },
                new Section()
                {
                    Name = "Requette Gateau Base",
                    Departement = new Departement()
                    {
                        Name = "Cuisine",
                    },
                },
                new Section()
                {
                    Name = "Requette Ingredient",
                    Departement = new Departement()
                    {
                        Name = "Cuisine",
                    },
                },
                new Section()
                {
                    Name = "Rapprt Requette Base",
                    Departement = new Departement()
                    {
                        Name = "Cuisine",
                    },
                },
                new Section()
                {
                    Name = "Rapprt Requette Base",
                    Departement = new Departement()
                    {
                        Name = "Stock",
                    },
                },
                new Section()
                {
                    Name = "Requette Ingredient",
                    Departement = new Departement()
                    {
                        Name = "Cuisine",
                    },
                },
                new Section()
                {
                    Name = "Requette Ingredient",
                    Departement = new Departement()
                    {
                        Name = "Stock",
                    },
                },
                new Section()
                {
                    Name = "Achat Ingredient",
                    Departement = new Departement()
                    {
                        Name = "Stock",
                    },
                },
                new Section()
                {
                    Name = "Fournisseur",
                    Departement = new Departement()
                    {
                        Name = "Stock",
                    },
                },
                new Section()
                {
                    Name = "Attribution Livraison",
                    Departement = new Departement()
                    {
                        Name = "Logistique",
                    },
                }
            };

            var s = from d in list where d.Departement == departement orderby d.Name select d;
            Sections.Clear();
            foreach (var item in s)
            {
                Sections.Add(item);
            }
        }

        private void GetDepartement()
        {
            var list = new List<Section>()
            {
                new Section()
                {
                    Name = "Reservations",
                    Departement = new Departement()
                    {
                        Name = "Commerciaux",
                    },
                },
                new Section()
                {
                    Name = "Payements",
                    Departement = new Departement()
                    {
                        Name = "Commerciaux",
                    },
                },
                new Section()
                {
                    Name = "Livraisons",
                    Departement = new Departement()
                    {
                        Name = "Commerciaux",
                    },
                },
                new Section()
                {
                    Name = "Livraisons",
                    Departement = new Departement()
                    {
                        Name = "Logistique",
                    },
                },
                new Section()
                {
                    Name = "Prevision Gateaux",
                    Departement = new Departement()
                    {
                        Name = "Logistique",
                    },
                },
                new Section()
                {
                    Name = "Ingredients",
                    Departement = new Departement()
                    {
                        Name = "Stock",
                    },
                },
                new Section()
                {
                    Name = "Usage Ingrdient",
                    Departement = new Departement()
                    {
                        Name = "Stock",
                    },
                },
                new Section()
                {
                    Name = "Etape Finition",
                    Departement = new Departement()
                    {
                        Name = "Cuisine",
                    },
                },
                new Section()
                {
                    Name = "Gateau Bases",
                    Departement = new Departement()
                    {
                        Name = "Cuisine",
                    },
                },
                new Section()
                {
                    Name = "Requette Gateau Base",
                    Departement = new Departement()
                    {
                        Name = "Cuisine",
                    },
                },
                new Section()
                {
                    Name = "Requette Ingredient",
                    Departement = new Departement()
                    {
                        Name = "Cuisine",
                    },
                },
                new Section()
                {
                    Name = "Rapprt Requette Base",
                    Departement = new Departement()
                    {
                        Name = "Cuisine",
                    },
                },
                new Section()
                {
                    Name = "Rapprt Requette Base",
                    Departement = new Departement()
                    {
                        Name = "Stock",
                    },
                },
                new Section()
                {
                    Name = "Requette Ingredient",
                    Departement = new Departement()
                    {
                        Name = "Cuisine",
                    },
                },
                new Section()
                {
                    Name = "Requette Ingredient",
                    Departement = new Departement()
                    {
                        Name = "Stock",
                    },
                },
                new Section()
                {
                    Name = "Achat Ingredient",
                    Departement = new Departement()
                    {
                        Name = "Stock",
                    },
                },
                new Section()
                {
                    Name = "Fournisseur",
                    Departement = new Departement()
                    {
                        Name = "Stock",
                    },
                },
                new Section()
                {
                    Name = "Attribution Livraison",
                    Departement = new Departement()
                    {
                        Name = "Logistique",
                    },
                }
            };

            var s = from d in list group d by new { Departement = d.Departement }
            into gr  
                    select new Departement 
                    { Name = gr.Key.Departement.Name };
            Departements.Clear();
            foreach (var item in s)
            {
                Departements.Add(item);
            }
        }
    }
}
