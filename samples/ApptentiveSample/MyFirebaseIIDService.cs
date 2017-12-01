using System;
using Android.App;
using Firebase.Iid;
using Android.Util;
using ApptentiveSDK.Android;

namespace ApptentiveSample
{
    [Service]
    [IntentFilter(new[] { "com.google.firebase.INSTANCE_ID_EVENT" })]
    public class MyFirebaseIIDService : FirebaseInstanceIdService
    {
        const string TAG = "MyFirebaseIIDService";
        public override void OnTokenRefresh()
        {
            var refreshedToken = FirebaseInstanceId.Instance.Token;
            Log.Debug(TAG, "Refreshed token: " + refreshedToken);
            Apptentive.SetPushNotificationIntegration(Apptentive.PushProviderApptentive, refreshedToken);
        }
    }
}
