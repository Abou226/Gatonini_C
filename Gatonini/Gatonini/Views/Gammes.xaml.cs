using Gatonini.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Style = Models.Style;

namespace Gatonini.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Gammes : ContentPage
    {
        public Gammes(Style style)
        {
            InitializeComponent();
            BindingContext = new GammesViewModel(this.Navigation, style);
        }
    }
}