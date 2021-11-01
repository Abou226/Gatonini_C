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
    public partial class StyleDetail : ContentPage
    {
        public StyleDetail(Style style)
        {
            InitializeComponent();
            BindingContext = new StyleDetailViewModel(style);
        }
    }
}