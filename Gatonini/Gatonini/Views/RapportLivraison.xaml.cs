using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gatonini.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RapportLivraison : ContentPage
    {
        public RapportLivraison()
        {
            InitializeComponent();
            BindingContext = new RapportLivraisonViewModel(this.Navigation);
        }
    }
}