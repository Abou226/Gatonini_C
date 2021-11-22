using Gatonini.ViewModels;
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
    public partial class OtoCheckPage : ContentPage
    {
        public OtoCheckPage(string telephone)
        {
            InitializeComponent();
            BindingContext = new OtpCheckViewModel(this.Navigation, telephone);
        }
    }
}