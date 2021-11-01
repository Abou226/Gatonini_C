using Acr.UserDialogs;
using Amazon.S3;
using BaseVM;
using Gatonini;
using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Essentials;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileUploadService))]
[assembly: Dependency(typeof(InitialService))]

namespace Gatonini
{
    public abstract class BaseObjectViewModel<T> : BaseVM.BaseViewModel where T : class, new()
    {
        public ICommand AddCommand { get; }

        [Required(ErrorMessage = "Le nom est requis")]
        [StringLength(60, ErrorMessage = "La taille du nom ne peut dépasser 60 characters")]
        public string Name { get; set; }
        public bool IsRunning { get; set; }
        public ICommand BackCommand { get; }
        public ICommand DeleteCommand { get; }
        public string Description { get; set; }
        public IDataService<T> ClientService { get; }
        public IFileUploadService FileUpload { get; }
        public IAmazonS3 S3Client { get; }
        public ICommand RefreshCommand { get; }
        public INavigation Navigation { get; }
        public ICommand PickImageCommand { get; }
        private ImageSource _pictureSource;
        public ImageSource PictureSource
        {
            get => _pictureSource;
            set
            {
                if (_pictureSource == value)
                    return;

                _pictureSource = value;
                OnPropertyChanged();
            }
        }
        public string FileName { get; set; }
        public int NormalHeight { get; set; } = 65;
        public int NormalWidth { get; set; } = 70;
        public string FilePath { get; set; }
        public ObservableCollection<T> Items { get; }
        public IInitialService Initial { get; }
        public IBaseViewModel BaseVM { get; }
        public T Item { get; }
        public BaseObjectViewModel()
        {
            BackCommand = new Command(OnBackCommand);
            BaseVM = DependencyService.Get<IBaseViewModel>();
            FileUpload = DependencyService.Get<IFileUploadService>();
            RefreshCommand = new Command(OnRefreshCommand);
            PickImageCommand = new Command(OnPickImageCommand);
            DeleteCommand = new Command(OnDeleteCommand);
            Item = new T();
            ClientService = DependencyService.Get<IDataService<T>>();
            Initial = DependencyService.Get<IInitialService>();
            Items = new ObservableCollection<T>();
            AddCommand = new Command(OnAddCommand);
            OnRefreshCommand(null);
        }

        private async void OnDeleteCommand(object obj)
        {
            //await Delete(obj);
        }

        private async void OnPickImageCommand(object obj)
        {

            var result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions()
            {
                Title = "Veillez selectionner une Image"
            });

            if (result != null && !string.IsNullOrWhiteSpace(result.FileName))
            {
                FileName = result.FileName;
                FilePath = result.FullPath;

                var stream = await result.OpenReadAsync();
                PictureSource = ImageSource.FromStream(() => stream);
            }
        }

        private async void OnBackCommand(object obj)
        {
            await Navigation.PopAsync();
        }

        public async void OnRefreshCommand(object obj)
        {
            if (BaseVM.IsInternetOn)
            {
                if (obj is string)
                {
                    var re = (string)obj;
                    if (re == "Refresh")
                    {
                        IsRunning = true;
                        UserDialogs.Instance.ShowLoading("Chargement");
                        await GetItems(Item);
                        UserDialogs.Instance.HideLoading();
                    }
                    IsRunning = false;
                }
                if (IsRunning)
                    return;

                try
                {
                    IsRunning = true;
                    UserDialogs.Instance.ShowLoading("Chargement");
                    await GetItems(Item);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Echec operation: {ex.Message}");
                    if (ex.Message.Contains("Unauthorize"))
                    {
                        var result = await Initial.Get(new LogInModel() { Token = await SecureStorage.GetAsync("Token"), Password = "d", Username = "d" });
                        OnRefreshCommand(obj);
                    }
                    else OnRefreshCommand(obj);
                    //await Application.Current.MainPage.DisplayAlert("Error!", ex.Message, "OK");
                }
                finally
                {
                    IsRunning = false;
                    UserDialogs.Instance.HideLoading();
                }
            }
        }

        private async Task GetItems(T value)
        {
            var t = value;
            string p = "";
            var ty = t.GetType();
            var ps = "";
            //if (ty.Contains('.'))
            {
                var d = t.GetType().ToString().Split('.');
                foreach (var item in d)
                {
                    ps = item;
                }
            }

            var list = await ClientService.GetItemsAsync(await SecureStorage.GetAsync("Token"), ps + "s");
            Items.Clear();
            if (list.Count() != 0)
            {
                foreach (var item in list)
                {
                    Items.Add(item);
                }
            }
        }

        public abstract void OnAddCommand(object obj);
    }
}

