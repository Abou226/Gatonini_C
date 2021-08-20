using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;

namespace Gatonini.BaseVM
{
    public interface IBaseViewModel
    {
        HttpClient Client { get; }
        bool IsBusy { get; }
        bool IsInternetOn { get; set; }
        int InternetCheckTime { get; set; }
        bool RefreshCatégorie { get; set; }
        bool RefreshTaille { get; set; }
        bool RefreshModel { get; set; }
        bool RefreshProduit { get; set; }
        bool RefreshMarque { get; set; }
        bool IsNotBusy { get; set; }
        string Message { get; set; }
        bool MessageVisibility { get; set; }
        string Title { get; set; }

        event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = "");
    }
}