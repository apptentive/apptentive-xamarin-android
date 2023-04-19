
using Android.App;
using Android.Media;
using Firebase.Messaging;
using System;

namespace ApptentiveSample
{
    [Service]
    [IntentFilter(new[] { "com.google.firebase.MESSAGING_EVENT" })]
    public class MyFirebaseMessagingService : FirebaseMessagingService
    {
        const string TAG = "MyFirebaseMsgService";



        public override void OnNewToken(string token)
        {

        }



        public override void OnMessageReceived(RemoteMessage message)
        {
           // LogPushBundle(message);
            var data = message.Data;

            String title = null;
            String body = null;
            //var apptentive = new ApptentiveKit.Android.Apptentive();
            //var isPush = apptentive.IsApptentivePushNotification(data);
            //if (apptentive.IsApptentivePushNotification(data))
            //{
            //   // Log.Error(TAG, "Apptentive push.");

            //    //title = apptentive.GetTitleFromApptentivePush(data);
            //    //body = apptentive.GetBodyFromApptentivePush(data);
            ////    apptentive.BuildPendingIntentFromPushNotification((pendingIntent) =>
            ////    {
            ////        // This push is from Apptentive, but not for the active conversation, so we can't safely display it.
            ////        if (pendingIntent == null)
            ////        {
            ////            Log.Error(TAG, "Push notification was not for the active conversation. Doing nothing.");
            ////            return;
            ////        }

            //        //        ShowNotification(pendingIntent, title, body);

            //        //    }, data);
            //        //}
            //else
            //    {
            //        Log.Error(TAG, "Non-Apptentive push.");
            //        Intent intent = new Intent(this, typeof(MainActivity));
            //        intent.AddFlags(ActivityFlags.ClearTop);
            //        var pushNotification = message.GetNotification();
            //        if (pushNotification != null)
            //        {
            //            title = pushNotification.Title;
            //            body = pushNotification.Body;
            //        }
            //        var pendingIntent = PendingIntent.GetActivity(this, 0 /* Request code */, intent, PendingIntentFlags.OneShot);
            //        ShowNotification(pendingIntent, title, body);
            //    }
            //}
        }

        //[Obsolete]
        //private void ShowNotification(PendingIntent pendingIntent, string title, string body)
        //{
        //    Log.Error(TAG, "Title: " + title);
        //    Log.Error(TAG, "Body: " + body);

        //    var defaultSoundUri = RingtoneManager.GetDefaultUri(RingtoneType.Notification);
        //    var notificationBuilder = new NotificationCompat.Builder(this)
        //        .SetSmallIcon(Resource.Drawable.apptentive_ic_preview)
        //        .SetContentTitle(title)
        //        .SetContentText(body)
        //        .SetAutoCancel(true)
        //        .SetSound(defaultSoundUri)
        //        .SetContentIntent(pendingIntent);
        //    var notificationManager = (NotificationManager)GetSystemService(Context.NotificationService);
        //    notificationManager.Notify(0, notificationBuilder.Build());
        //}

        //private void LogPushBundle(RemoteMessage remoteMessage)
        //{
        //    var data = remoteMessage.Data;
        //    Log.Error(TAG, "Push Data:");
        //    foreach (var e in data)
        //    {
        //        Log.Error(TAG, "  " + e.Key + " : " + e.Value);
        //    }
        //    Log.Error(TAG, data["title"] + ": " + data["body"]);
        //}
    }
}













//using System;

//using Android.App;
//using Android.Content;
//using Android.OS;

//namespace ApptentiveSample
//{
//	[Service (Label = "FirebaseService")]	
//	[IntentFilter(new String[]{"com.yourname.FirebaseService"})]		
//	public class FirebaseService : Service
//	{
//		IBinder binder;

//		public override StartCommandResult OnStartCommand (Android.Content.Intent intent, StartCommandFlags flags, int startId)
//		{
//			// start your service logic here

//			// Return the correct StartCommandResult for the type of service you are building
//			return StartCommandResult.NotSticky;
//		}

//		public override IBinder OnBind (Intent intent)
//		{
//			binder = new FirebaseServiceBinder (this);
//			return binder;
//		}
//	}

//	public class FirebaseServiceBinder : Binder
//	{
//		readonly FirebaseService service;

//		public FirebaseServiceBinder (FirebaseService service)
//		{
//			this.service = service;
//		}

//		public FirebaseService GetFirebaseService ()
//		{
//			return service;
//		}
//	}			
//}

