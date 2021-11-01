using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Message = Gatonini.Droid.Message;
[assembly: Xamarin.Forms.Dependency(typeof(Message))]

namespace Gatonini.Droid
{
    public class Message : IMessage
    {
        public Message()
        {
        }
        public void ShortAlert(string message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Short).Show();
        }
        public void LongAlert(string message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Long).Show();
        }
    }
}