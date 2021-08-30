using System;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;

namespace Gatonini.BaseVM
{
    public class BaseViewModel : INotifyPropertyChanged, IBaseViewModel
    {
        public const string baseurl = "http://gatoniniserver-dev.us-east-1.elasticbeanstalk.com/";

        public HttpClient httpClient;
        public HttpClient Client => httpClient ?? (httpClient = new HttpClient());

        public BaseViewModel()
        {
            Client.BaseAddress = new Uri(baseurl);
        }

        public static string DateToString(DateTime start, DateTime end)
        {
            return start.ToString("MM-dd-yyyy") + "/" + end.ToString("MM-dd-yyyy");
        }


        string title = "Gatonini";
        public string Title
        {
            get => title;
            set
            {
                if (title == value)
                    return;
                title = value;
                OnPropertyChanged();
            }
        }

        private bool isInternetOn;

        public bool IsInternetOn
        {
            get => isInternetOn;
            set
            {
                if (isInternetOn == value)
                    return;

                isInternetOn = value;
                OnPropertyChanged();
            }
        }

        private int _internetCheckTime = 1;

        public int InternetCheckTime
        {
            get => _internetCheckTime;
            set
            {
                if (_internetCheckTime == value)
                    return;

                _internetCheckTime = value;
                OnPropertyChanged();
            }
        }


        private static bool _staticNotBusy;

        public static bool StaticNotBusy
        {
            get { return _staticNotBusy; }
            set
            {
                _staticNotBusy = value;
            }
        }

        bool isNotBusy;
        public bool IsNotBusy
        {
            get => isNotBusy;
            set
            {
                if (StaticNotBusy == value || isNotBusy == value)
                    return;

                isNotBusy = StaticNotBusy;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsBusy));
            }
        }

        private bool _messageVisibility;

        public bool MessageVisibility
        {
            get => _messageVisibility;
            set
            {
                if (_messageVisibility == value)
                    return;

                _messageVisibility = value;
                OnPropertyChanged();
            }
        }

        private string _message;
        public string Message
        {
            get => _message;
            set
            {
                if (_message == value)
                    return;
                _message = value;
                OnPropertyChanged();
            }
        }


        //public bool IsAllBusy => !IsNotAllBusy;

        //bool isNotAllBusy;
        //public bool IsNotAllBusy
        //{
        //    get => isNotAllBusy;
        //    set
        //    {
        //        if (isNotAllBusy == value)
        //            return;
        //        isNotAllBusy = value;
        //        OnPropertyChanged();
        //        OnPropertyChanged(nameof(IsAllBusy));
        //    }
        //}

        public bool IsBusy => !IsNotBusy;
        private bool _refreshCatégorie;
        public bool RefreshCatégorie
        {
            get => _refreshCatégorie;
            set
            {
                if (_refreshCatégorie == value)
                    return;
                _refreshCatégorie = value;
                OnPropertyChanged();
            }
        }

        private bool _refreshTaille;
        public bool RefreshTaille
        {
            get => _refreshTaille;
            set
            {
                if (_refreshTaille == value)
                    return;
                _refreshTaille = value;
                OnPropertyChanged();
            }
        }

        private bool _refreshModel;
        public bool RefreshModel
        {
            get => _refreshModel;
            set
            {
                if (_refreshModel == value)
                    return;
                _refreshModel = value;

                OnPropertyChanged();
            }
        }

        private bool _refreshProduit;
        public bool RefreshProduit
        {
            get => _refreshProduit;
            set
            {
                if (_refreshProduit == value)
                    return;
                _refreshProduit = value;
                OnPropertyChanged();
            }
        }

        private bool _refreshMarque;
        public bool RefreshMarque
        {
            get => _refreshMarque;
            set
            {
                if (_refreshMarque == value)
                    return;
                _refreshMarque = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
