using Gatonini.BaseVM;
using Gatonini.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Gatonini.Services
{
    public class HomeService : BaseViewModel
    {
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public Uri ProfilePicture { get; set; }

        public ObservableCollection<Categorie> Catégories { get; }
        public ObservableCollection<Product> Products { get; }

        public HomeService()
        {
            Catégories = new ObservableCollection<Categorie>();

            Products = new ObservableCollection<Product>();
        }

        private async void OnCatégorieSelected(Categorie obj)
        {
            IsNotBusy = true;
        }

    }
}
