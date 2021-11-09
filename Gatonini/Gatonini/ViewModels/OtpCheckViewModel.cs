using Acr.UserDialogs;
using BaseVM;
using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

[assembly: Dependency(typeof(ClientService<Models.Sms>))]
[assembly: Dependency(typeof(InitialService))]

namespace Gatonini.ViewModels
{
    public class OtpCheckViewModel : BaseVM.BaseViewModel
    {
        public INavigation Navigation { get; }
        public IDataService<Models.EditObject> EditService { get; }
        public IBaseViewModel BaseVM { get; }
        public ICommand OtpCheckCommand { get; }
        public IInitialService Initial { get; }
        public string Telephone { get; set; }
        public OtpCheckViewModel(INavigation navigation)
        {
            Navigation = navigation;
            Initial = DependencyService.Get<IInitialService>();
            EditService = DependencyService.Get<IDataService<Models.EditObject>>();
            OtpCheckCommand = new Command(OnOtpCheckCommand);
            BaseVM = DependencyService.Get<IBaseViewModel>();
        }

        private async void OnOtpCheckCommand(object obj)
        {
            if (BaseVM.IsInternetOn)
            {
                if (IsNotBusy)
                    return;

                try
                {
                    IsNotBusy = false;
                    if (!string.IsNullOrWhiteSpace(A) 
                        && !string.IsNullOrWhiteSpace(B) 
                        && !string.IsNullOrWhiteSpace(C) 
                        && !string.IsNullOrWhiteSpace(D) 
                        && !string.IsNullOrWhiteSpace(E) 
                        && !string.IsNullOrWhiteSpace(F))
                    {
                        UserDialogs.Instance.ShowLoading("Verification.....");

                        var code = $"{A}{B}{C}{D}{E}{F}";
                        List<EditObject> list = new List<EditObject>();
                        list.Add(new EditObject() { Op = "Replace", Value = Telephone, Path = "Telephone" });
                        var item = await EditService.UpdateListAsync(list, await SecureStorage.GetAsync("Token"), $"otp_check/{code}" );

                        if (item != null)
                        {
                            IsNotBusy = true;
                            DependencyService.Get<IMessage>().LongAlert("Verification effectuées avec succès");
                        }
                        else DependencyService.Get<IMessage>().LongAlert("Erreur: Verification non effectuée");
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Echec operation: {ex.Message}");
                    if (ex.Message.Contains("Unauthorize"))
                    {
                        var result = await Initial.Get(new LogInModel()
                        {
                            Token = await SecureStorage.GetAsync("Token"),
                            Password = "d",
                            Username = "d"
                        });
                    }
                    else if (ex.Message.Contains("host"))
                    {
                        DependencyService.Get<IMessage>().LongAlert("Erreur: Veillez verifier votre connection internet");
                    }
                    //else DependencyService.Get<IMessage>().ShortAlert("Erreur : " + ex.Message);
                }
                finally
                {
                    //IsRunning = false;
                    IsNotBusy = true;
                    UserDialogs.Instance.HideLoading();
                }
            }
        }

        private string a;

        public string A
        {
            get { return a; }
            set 
            {
                if (a == value)
                    return;
                a = value;
                OnPropertyChanged();
            }
        }

        private string b;

        public string B
        {
            get { return b; }
            set 
            {
                if (b == value)
                    return;

                b = value;
                OnPropertyChanged();
            }
        }

        private string c;

        public string C
        {
            get { return c; }
            set 
            {
                if (c == value)
                    return;

                c = value;
                OnPropertyChanged();
            }
        }

        private string d;

        public string D
        {
            get { return d; }
            set 
            {
                if (d == value)
                    return;

                d = value;
                OnPropertyChanged();
            }
        }

        private string e;

        public string E
        {
            get { return e; }
            set 
            {
                if (e == value)
                    return;

                e = value;
                OnPropertyChanged();
            }
        }


        private string f;

        public string F
        {
            get { return f; }
            set 
            {
                if (f == value)
                    return;

                f = value;
                OnPropertyChanged();
                if (!string.IsNullOrWhiteSpace(A)
                        && !string.IsNullOrWhiteSpace(B)
                        && !string.IsNullOrWhiteSpace(C)
                        && !string.IsNullOrWhiteSpace(D)
                        && !string.IsNullOrWhiteSpace(E)
                        && !string.IsNullOrWhiteSpace(F))
                {
                    OnOtpCheckCommand(null);
                }
            }
        }
    }
}
