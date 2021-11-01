using Models;
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
    public partial class ProductDetail : ContentPage
    {
        public ProductDetail(Gamme g)
        {
            InitializeComponent();
            BindingContext = new ProductDetailViewModel(g, this.Navigation);
        }
    }
}