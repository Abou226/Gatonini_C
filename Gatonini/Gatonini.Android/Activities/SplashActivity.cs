using Acr.UserDialogs.Infrastructure;
using Android.App;
using Android.Content;
using Android.Locations;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gatonini.Droid.Activities
{
    [Activity(Label = "Gatonini", Theme = "@style/MyTheme.Splash", Icon = "@mipmap/icon", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : AppCompatActivity, ILocationListener
    {
        static readonly string TAG = "X:" + typeof(SplashActivity).Name;

        Location currentLocation;
        LocationManager locationManager;
        string locationProvider;

        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState, persistentState);
            Log.Debug(TAG, "SplashActivity.OnCreate");
            //InitializeLocationManager();
        }

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
            Log.Debug(TAG, "Using " + locationProvider + ".");
        }

        public void OnLocationChanged(Location location)
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

        // Launches the startup task
        protected override void OnResume()
        {
            base.OnResume();
            Task startupWork = new Task(() => { SimulateStartup(); });
            startupWork.Start();
            //locationManager.RequestLocationUpdates(locationProvider, 0, 0, this);
        }

        protected override void OnPause()
        {
            base.OnPause();
            //locationManager.RemoveUpdates(this);
        }

        // Simulates background work that happens behind the splash screen
        async void SimulateStartup()
        {
            Log.Debug(TAG, "Performing some startup work that takes a bit of time.");
            //await Task.Delay(8000); // Simulate a bit of startup work.
            Log.Debug(TAG, "Startup work is finished - starting MainActivity.");
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}