using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
//using Android.Support.V7.App;
using Android.Gms.Common.Apis;
using Android.Gms.Common;
using System.Threading.Tasks;
using Android.Gms.Auth.Api.SignIn;
using Android.Gms.Auth.Api;
using Firebase.Auth;
using AndroidX.AppCompat.App;
using Services;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using Xamarin.Essentials;
using Xamarin.Forms;
using Acr.UserDialogs;
using Models;
using System.Net.Http;

[assembly: Dependency(typeof(DataService<Client>))]
[assembly: Dependency(typeof(DataService<object,Secrets>))]
[assembly: Dependency(typeof(DataService<RefreshToken>))]
namespace Gatonini.Droid.Activities
{
    [Activity(Label = "Google Login", Theme = "@style/Theme.AppCompat.Light.DarkActionBar")]
    public class GoogleLoginActivity : AppCompatActivity, GoogleApiClient.IConnectionCallbacks, GoogleApiClient.IOnConnectionFailedListener
    {
        const string TAG = "GoogleLoginActivity";

        const int RC_SIGN_IN = 9001;

        const string KEY_IS_RESOLVING = "is_resolving";
        const string KEY_SHOULD_RESOLVE = "should_resolve";
        public IDataService<Client> Client { get; }
        public IDataService<RefreshToken> Token { get; }
        public IInitialService Initial { get; }
        public IDataService<object,Secrets> Secret { get; }

        public GoogleLoginActivity()
        {
            Client = DependencyService.Get<IDataService<Client>>();
            Token = DependencyService.Get<IDataService<RefreshToken>>();
            Initial = DependencyService.Get<IInitialService>();
            Secret = DependencyService.Get<IDataService<object,Secrets>>();
        }

        static GoogleApiClient mGoogleApiClient;

        bool mIsResolving = false;

        bool mShouldResolve = false;

       
        private static GoogleSignInAccount mAuth;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            GoogleSignInOptions gso3 = new GoogleSignInOptions.Builder(GoogleSignInOptions.DefaultSignIn)
                                    .RequestProfile()
                                    .Build();

            GoogleSignInOptions gso = new GoogleSignInOptions.Builder(GoogleSignInOptions.DefaultSignIn)
              .RequestIdToken("305630054608-j8rgvpv10gnnvu24v9e0n51lcm79u0oa.apps.googleusercontent.com")
              .RequestEmail()
                .Build();

            mGoogleApiClient = new GoogleApiClient.Builder(this)
                .AddConnectionCallbacks(this)
                .AddOnConnectionFailedListener(this)
                .AddApi(Auth.GOOGLE_SIGN_IN_API, gso)
                .Build();

            Intent signInIntent = Auth.GoogleSignInApi.GetSignInIntent(mGoogleApiClient);
            StartActivityForResult(signInIntent, RC_SIGN_IN);
        }

        private void HandleResult(GoogleSignInAccount result)
        {
            if (result != null)
            {
                Intent myIntent = new Intent(this, typeof(GoogleLoginActivity));
                myIntent.PutExtra("result", result);
                SetResult(Result.Ok, myIntent);
            }
            Finish();
        }

        private async void UpdateData(bool isSignedIn)
        {
            if (isSignedIn)
            {
                HandleResult(mAuth);
            }
            else
            {
                await System.Threading.Tasks.Task.Delay(2000);
                mShouldResolve = true;
                mGoogleApiClient.Connect();
            }
        }

        protected override void OnStart()
        {
            base.OnStart();
            mGoogleApiClient.Connect();
        }

        protected override void OnStop()
        {
            base.OnStop();
            mGoogleApiClient.Disconnect();
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
            UserDialogs.Init(this);
            outState.PutBoolean(KEY_IS_RESOLVING, mIsResolving);
            outState.PutBoolean(KEY_SHOULD_RESOLVE, mIsResolving);
        }

        protected override async void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            // Result returned from launching the Intent from GoogleSignInApi.getSignInIntent(...);
            if (requestCode == RC_SIGN_IN)
            {
                var result = Android.Gms.Auth.Api.Auth.GoogleSignInApi.GetSignInResultFromIntent(data);
                if (result.IsSuccess)
                {
                    // Google Sign In was successful, authenticate with Firebase
                    UserDialogs.Instance.ShowLoading("Finalisation");
                    try
                    {
                        //HttpClient cl = new HttpClient();
                        ////cl.BaseAddress = new Uri(BaseViewModel.baseurl);
                        //var authHeader = new AuthenticationHeaderValue("bearer", await SecureStorage.GetAsync("Token"));
                        //cl.DefaultRequestHeaders.Authorization = authHeader;
                        //var us = await cl.GetStringAsync("https://api.Gatonini.com/api/users/email/" + result.SignInAccount.Email);
                        //var al = ConvertSingle<User>.FromJson(us);
                        var u = await Client.GetItemAsync(await SecureStorage.GetAsync("Token"), "clients/email/" + result.SignInAccount.Email);
                        if (u == null)
                        {
                            Client user = new Client();
                            user.Email = result.SignInAccount.Email;
                            user.Prenom = result.SignInAccount.GivenName;
                            user.Nom = result.SignInAccount.FamilyName;
                            user.PhotoUrl = result.SignInAccount.PhotoUrl.Scheme.ToString()+""+result.SignInAccount.PhotoUrl.EncodedSchemeSpecificPart.ToString();

                            var list = new List<Client>();
                            list.Add(user);
                            var users = await Client.AddListAsync(list, null);
                            await SecureStorage.SetAsync("Email", user.Email);
                            if(users != null)
                            {
                                //var token = await Secret.GetAsync(null, "authclient/useremail/" + result.SignInAccount.Email);
                                //if(token != null)
                                //{
                                //    await SecureStorage.SetAsync("Token", token.First().Token);
                                //    await SecureStorage.SetAsync("Prenom", token.First().Prenom);
                                //    await SecureStorage.SetAsync("Nom", token.First().Nom);
                                //    await SecureStorage.SetAsync("ProfilePic", token.First().ProfilePic);
                                //}
                            }
                            else
                            {
                                //var token = await Secret.GetAsync(null, "authclient/useremail/" + result.SignInAccount.Email);
                                //if (token != null)
                                //{
                                //    await SecureStorage.SetAsync("Token", token.First().Token);
                                //    await SecureStorage.SetAsync("Prenom", token.First().Prenom);
                                //    await SecureStorage.SetAsync("Nom", token.First().Nom);
                                //    await SecureStorage.SetAsync("ProfilePic", result.SignInAccount.PhotoUrl.Scheme.ToString() + "" + result.SignInAccount.PhotoUrl.EncodedSchemeSpecificPart.ToString());
                                //}
                            }
                        }
                        await SecureStorage.SetAsync("Email", result.SignInAccount.Email);
                    }
                    catch (Exception ex)
                    {
                        HttpClient cl = new HttpClient();
                        //cl.BaseAddress = new Uri(BaseViewModel.baseurl);
                        var authHeader = new AuthenticationHeaderValue("bearer", await SecureStorage.GetAsync("Token"));
                        cl.DefaultRequestHeaders.Authorization = authHeader;
                        var us = await cl.GetStringAsync("https://quitaye.mahalfial.com/api/clients/email/" + result.SignInAccount.Email);
                        var al = ConvertSingle<User>.FromJson(us);

                        var message = ex.Message;
                    }
                    UserDialogs.Instance.HideLoading();

                    HandleResult(result.SignInAccount);
                }
                else
                {
                    // Google Sign In failed, update UI appropriately
                    // [START_EXCLUDE]
                    HandleResult(null);
                    // [END_EXCLUDE]
                }
            }
        }

        public void OnConnected(Bundle connectionHint)
        {
            UpdateData(false);
        }

        public void OnConnectionSuspended(int cause)
        {

        }

        public void OnConnectionFailed(ConnectionResult result)
        {
            if (!mIsResolving && mShouldResolve)
            {
                if (result.HasResolution)
                {
                    try
                    {
                        result.StartResolutionForResult(this, RC_SIGN_IN);
                        mIsResolving = true;
                    }
                    catch (IntentSender.SendIntentException e)
                    {
                        mIsResolving = false;
                        mGoogleApiClient.Connect();
                    }
                }
                else
                {
                    ShowErrorDialog(result);
                }
            }
            else
            {
                UpdateData(false);
            }
        }

        class DialogInterfaceOnCancelListener : Java.Lang.Object, IDialogInterfaceOnCancelListener
        {
            public Action<IDialogInterface> OnCancelImpl { get; set; }

            public void OnCancel(IDialogInterface dialog)
            {
                OnCancelImpl(dialog);
            }
        }

        void ShowErrorDialog(ConnectionResult connectionResult)
        {
            int errorCode = connectionResult.ErrorCode;

            if (GoogleApiAvailability.Instance.IsUserResolvableError(errorCode))
            {

                var listener = new DialogInterfaceOnCancelListener();
                listener.OnCancelImpl = (dialog) =>
                {

                    mShouldResolve = false;
                };
                GoogleApiAvailability.Instance.GetErrorDialog(this, errorCode, RC_SIGN_IN, listener).Show();
            }
            else
            {
                mShouldResolve = false;
            }
            HandleResult(mAuth);
        }
    }
}
