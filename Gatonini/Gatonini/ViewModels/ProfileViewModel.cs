using Acr.UserDialogs;
using BaseVM;
using Gatonini.Views;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

using Sms = Models.Sms;
[assembly: Dependency(typeof(DataService<Sms>))]
[assembly: Dependency(typeof(DataService<EditObject>))]
[assembly: Dependency(typeof(DataService<Client>))]
[assembly: Dependency(typeof(InitialService))]
[assembly: Dependency(typeof(BaseViewModel))]

namespace Gatonini.ViewModels
{
    public class ProfileViewModel : BaseVM.BaseViewModel
    {
        private string username;
        public string Username
        {
            get { return username; }
            set 
            {
                if (username == value)
                    return;

                username = value;
                OnPropertyChanged();
            }
        }

        public string Email { get; set; }
        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set 
            {
                if (prenom == value)
                    return;

                prenom = value;
                OnPropertyChanged();
            }
        }

        private string nom;

        public string Nom
        {
            get { return nom; }
            set 
            {
                if (nom == value)
                    return;

                nom = value;
                OnPropertyChanged();
            }
        }

        private string adresse;

        public string Adresse
        {
            get { return adresse; }
            set 
            {
                if (adresse == value)
                    return;
                adresse = value;
                OnPropertyChanged();
            }
        }

        private string telephone;

        public string Telephone
        {
            get { return telephone; }
            set 
            {
                if (telephone == value)
                    return;
                telephone = value;
                OnPropertyChanged();
            }
        }

        public ICommand OtpSend { get; }
        public ICommand OtpCheck { get; }

        public IBaseViewModel BaseVM { get; }
        public IInitialService Initial { get; }
        public IDataService<EditObject> EditService { get; }
        public IDataService<Client> ClientService { get; }
        public ICommand EditCommand { get; }
        public ICommand BackCommand { get; }
        public INavigation Navigation { get; }

        public IDataService<Sms> SmsService { get; }

        public FileResult FileResult { get; set; }
        private ImageSource imageSource;
        public ImageSource PictureSource
        {
            get { return imageSource; }
            set
            {
                if (imageSource == value)
                    return;
                imageSource = value;
                OnPropertyChanged();
            }
        }

        private Stream stream1;
        public Stream Stream
        {
            get { return stream1; }
            set
            {
                if (stream1 == value)
                    return;

                stream1 = value;
                OnPropertyChanged();
            }
        }

        private string photoUrl;
        public string PhotoUrl
        {
            get { return photoUrl; }
            set 
            {
                if (photoUrl == value)
                    return;
                photoUrl = value;
                OnPropertyChanged();
            }
        }

        public ICommand ProfileImageCommand { get; }
        public IFormFile Image { get; set; }
        public IDataService<Models.File> FileService { get; }
        public ProfileViewModel(INavigation navigation = null)
        {
            Title = "Profile";
            Navigation = navigation;
            EditCommand = new Command(OnEditCommand);
            ClientService = DependencyService.Get<IDataService<Client>>();
            EditService = DependencyService.Get<IDataService<EditObject>>();
            BackCommand = new Command(OnBackCommand);
            ProfileImageCommand = new Command(OnProfileImageCommand);
            SmsService = DependencyService.Get<IDataService<Sms>>();
            FileService = DependencyService.Get<IDataService<Models.File>>();
            BaseVM = DependencyService.Get<IBaseViewModel>();
            Initial = DependencyService.Get<IInitialService>();
            OtpCheck = new Command(OnOtpCheck);
            OtpSend = new Command(OnOtpSend);
            GetClientInfo();
        }

        private async void OnOtpSend(object obj)
        {
            if (BaseVM.IsInternetOn)
            {
                if (IsNotBusy)
                    return;

                try
                {
                    IsNotBusy = false;
                    if (!string.IsNullOrWhiteSpace(Telephone))
                    {
                        UserDialogs.Instance.ShowLoading("Validation.....");
                        
                        List<Sms> list = new List<Sms>();
                        list.Add(new Sms() { Telephone = Telephone, SenderId = "Gatonini", Type = "Promotional" });
                        var item = await SmsService.SimplePostAsync(list, await SecureStorage.GetAsync("Token"), "clientsms/otp_send");

                        if (item != null)
                        {
                            UserDialogs.Instance.HideLoading();
                            IsNotBusy = true;
                            await Navigation.PushAsync(new OtoCheckPage(Telephone));
                        }
                        else DependencyService.Get<IMessage>().LongAlert("Erreur: verification non envoyée");
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Echec operation: {ex.Message}");
                    if (ex.Message.Contains("Unauthorize"))
                    {
                        var result = await Initial.Get(new LogInModel()
                        { Token = await SecureStorage.GetAsync("Token"), Password = "d", Username = "d" });

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

        private void OnOtpCheck(object obj)
        {
            
        }

        private async void OnProfileImageCommand(object obj)
        {
            var result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions()
            {
                Title = "Veillez selectionner une Image"
            });

            if (result != null && !string.IsNullOrWhiteSpace(result.FileName))
            {
                FileResult = result;
                var stream = await result.OpenReadAsync();
                PictureSource = ImageSource.FromStream(() => stream);
            }
        }

        private async void OnBackCommand(object obj)
        {
            await Navigation.PopAsync();
        }

        private async Task GetClientInfo()
        {
            if (BaseVM.IsInternetOn)
            {
                if (IsNotBusy)
                    return;

                try
                {
                    IsNotBusy = false;
                    UserDialogs.Instance.ShowLoading("Chargement....");
                    if(!string.IsNullOrWhiteSpace(await SecureStorage.GetAsync("Token")))
                    {
                        var item = await ClientService.GetItemAsync(await SecureStorage.GetAsync("Token"), "clients/baseinfo");
                        if (item != null)
                        {
                            Prenom = item.Prenom;
                            Nom = item.Nom;
                            Telephone = item.Telephone;
                            Email = item.Email;
                            PictureSource = item.PhotoUrl;
                            IsNotBusy = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Echec operation: {ex.Message}");
                    if (ex.Message.Contains("Unauthorize"))
                    {
                        var result = await Initial.Get(new LogInModel()
                        { Token = await SecureStorage.GetAsync("Token"), Password = "d", Username = "d" });

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

        private async void OnEditCommand(object obj)
        {
            if (BaseVM.IsInternetOn)
            {
                if (IsNotBusy)
                    return;

                try
                {
                    IsNotBusy = false;
                    if(!string.IsNullOrWhiteSpace(Prenom) 
                        && !string.IsNullOrWhiteSpace(Nom) 
                        && !string.IsNullOrWhiteSpace(Email) 
                        && !string.IsNullOrWhiteSpace(Telephone))
                    {
                        UserDialogs.Instance.ShowLoading("Validation.....");
                        if (FileResult != null && !string.IsNullOrWhiteSpace(FileResult.FileName))
                        {
                            Stream = await FileResult.OpenReadAsync();
                            Image = new FormFile(Stream, Stream.Position, Stream.Length, FileResult.FileName, FileResult.FileName);
                            var result = await FileService.AddFormDataAsync(new Models.File()
                            {
                                Image = Image,
                                Url = "d",
                            }, await SecureStorage.GetAsync("Token"), "upload");
                        }

                        List<EditObject> list = new List<EditObject>();
                        list.Add(new EditObject() { Op = "Replace", Value = Prenom, Path = "Prenom" });
                        list.Add(new EditObject() { Op = "Replace", Value = Nom, Path = "Nom" });
                        list.Add(new EditObject() { Op = "Replace", Value = PhotoUrl, Path = "PhotoUrl" });
                        var item = await EditService.UpdateListAsync(list, await SecureStorage.GetAsync("Token"), "clients");

                        if (item.Count() != 0)
                        {
                            IsNotBusy = true;
                            DependencyService.Get<IMessage>().LongAlert("Modification effectuées avec succès");
                        }else DependencyService.Get<IMessage>().LongAlert("Erreur: Modification non effectuée");
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Echec operation: {ex.Message}");
                    if (ex.Message.Contains("Unauthorize"))
                    {
                        var result = await Initial.Get(new LogInModel()
                        { Token = await SecureStorage.GetAsync("Token"), Password = "d", Username = "d" });
                        
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
    }
}
