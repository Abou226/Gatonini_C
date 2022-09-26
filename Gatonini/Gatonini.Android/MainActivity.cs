using System;
using Firebase;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Acr.UserDialogs;
using Android.Content;
using Android.Gms.Auth.Api.SignIn;
using Xamarin.Forms;
using Firebase.Auth;
using System.Net.Http.Headers;
using System.Net.Http;
using Xamarin.Essentials;
using Android.Locations;
using System.Collections.Generic;
using System.Linq;
using Plugin.FirebasePushNotification;
using Xamarin.Forms.Internals;
using Gatonini.Droid.Services;

namespace Gatonini.Droid
{
    [Activity(Label = "Gatonini", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity, ILocationListener
    {
        public static FirebaseApp app;
        FirebaseAuth firebaseAuth;
        //ICallbackManager callback;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            firebaseAuth = InitFirebaseAuth();
            UserDialogs.Init(this);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            //InitializeLocationManager();
            FirebasePushNotificationManager.ProcessIntent(this, Intent);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private FirebaseAuth InitFirebaseAuth()
        {
            //var app = FirebaseApp.InitializeApp(this);
            FirebaseAuth auth;
            if (app == null)
            {
                var options = new FirebaseOptions.Builder()
                .SetProjectId("")
                .SetApplicationId("")
                .SetApiKey("")
                .SetStorageBucket("")
                .Build();

                //if (app == null)
                app = FirebaseApp.InitializeApp(this, options);
                auth = FirebaseAuth.Instance;
            }
            else
            {
                auth = FirebaseAuth.Instance;
            }
            return auth;
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            if (requestCode == AuthService.REQ_AUTH && resultCode == Result.Ok)
            {
                GoogleSignInAccount sg = (GoogleSignInAccount)data.GetParcelableExtra("result");
                MessagingCenter.Send(AuthService.KEY_AUTH, AuthService.KEY_AUTH, sg.IdToken);
            }
        }

        Android.Locations.Location currentLocation;
        LocationManager locationManager;
        string locationProvider;

        private void InitializeLocationManager()
        {
            locationManager = (LocationManager)GetSystemService(LocationService);
            Criteria criteriaForLocationService = new Criteria
            {
                Accuracy = Accuracy.Fine
            };
            IList<string> acceptableLocationProviders = locationManager.GetProviders(criteriaForLocationService, true);
            if (acceptableLocationProviders.Any())
            {
                locationProvider = acceptableLocationProviders.First();
            }
            else
            {
                locationProvider = string.Empty;
            }
            //Log.Debug(TAG, "Using " + locationProvider + ".");
        }

        public void OnLocationChanged(Android.Locations.Location location)
        {
            currentLocation = location;
            if (currentLocation == null)
            {
                //Error Message  
            }
            else
            {
                //txtlatitu.Text = currentLocation.Latitude.ToString();
                //txtlong.Text = currentLocation.Longitude.ToString();
            }
        }

        public void OnProviderDisabled(string provider)
        {
            
        }

        public void OnProviderEnabled(string provider)
        {
            
        }

        public void OnStatusChanged(string provider, [GeneratedEnum] Availability status, Bundle extras)
        {
            
        }

        protected override void OnResume()
        {
            base.OnResume();
            //locationManager.RequestLocationUpdates(locationProvider, 0, 0, this);
        }
        protected override void OnPause()
        {
            base.OnPause();
            //locationManager.RemoveUpdates(this);
        }
    }
}
