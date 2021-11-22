using System.Linq;
using System.Text.RegularExpressions;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Telephony;
using Java.Lang;
using Xamarin.Forms;
using BaseVM;
using Gatonini.ViewModels;

namespace Gatonini.Droid
{
    [BroadcastReceiver(Enabled = true, Label = "SMS Receiver")]
    [IntentFilter(new string[] { "android.provider.Telephony.SMS_RECEIVED", Intent.CategoryDefault })]
    public class SmsReceiver : BroadcastReceiver
    {
        private const string IntentAction = "android.provider.Telephony.SMS_RECEIVED";
        private static readonly string Sender = "+4560992";
        private static readonly string[] OtpMessageBodyKeywordSet = {"votre", "code", "de", "verification." }; //You must define your own Keywords
        public override void OnReceive(Context context, Intent intent)
        {
            try
            {
                if (intent.Action != IntentAction) return;
                var bundle = intent.Extras;
                if (bundle == null) return;
                var pdus = bundle.Get("pdus");
                // var castedPdus = JNIEnv.GetArray(pdus.Handle);
                var castedPdus = JNIEnv.GetArray<Object>(pdus.Handle);
                var msgs = new SmsMessage[castedPdus.Length];
                var sb = new StringBuilder();
                string sender = null;
                for (var i = 0; i < msgs.Length; i++)
                {
                    var bytes = new byte[JNIEnv.GetArrayLength(castedPdus[i].Handle)];
                    JNIEnv.CopyArray(castedPdus[i].Handle, bytes);
                    string format = bundle.GetString("format");
                    msgs[i] = SmsMessage.CreateFromPdu(bytes, format);
                    if (sender == null)
                        sender = msgs[i].OriginatingAddress;
                    sb.Append(string.Format("SMS From: {0}{1}Body: {2}{1}", msgs[i].OriginatingAddress,
                        System.Environment.NewLine, msgs[i].MessageBody));
                    //Toast.MakeText(context, sb.ToString(), ToastLength.Long).Show();
                    //Log.Error("Vahid", sb.ToString());

                    var msgBody = msgs[i].MessageBody;
                    if (!sender.Contains(Sender)) return;
                    bool foundKeyword = OtpMessageBodyKeywordSet.Any(k => msgBody.Contains(k));

                    if (!foundKeyword) return;
                    var code = ExtractNumber(msgBody);
                    MessagingCenter.Send(new OtpCheckViewModel(), "OtpReceived", code);
                }
            }
            catch (System.Exception ex)
            {
                //Toast.MakeText(context, ex.Message, ToastLength.Long).Show();
            }
        }

        private static string ExtractNumber(string text)
        {
            if (string.IsNullOrEmpty(text)) return "";
            var regPattern = @"\d+";
            var number = Regex.Match(text, regPattern).Value;
            return number;
        }

    }
}