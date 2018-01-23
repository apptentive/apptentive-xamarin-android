using System;
using Android.App;
using Android.Content;
using Android.Media;
using Android.Support.V4.App;
using Android.Util;
using ApptentiveSDK.Android;
using Firebase.Messaging;

namespace ApptentiveSample
{
    [Service]
    [IntentFilter(new[] { "com.google.firebase.MESSAGING_EVENT" })]
    public class MyFirebaseMessagingService : FirebaseMessagingService
    {
        const string TAG = "MyFirebaseMsgService";

        /**
         * Called when message is received.
         */

        public override void OnMessageReceived(RemoteMessage message)
        {
            LogPushBundle(message);
            var data = message.Data;

            String title = null;
            String body = null;

            if (Apptentive.IsApptentivePushNotification(data))
            {
                Log.Error(TAG, "Apptentive push.");
                title = Apptentive.GetTitleFromApptentivePush(data);
                body = Apptentive.GetBodyFromApptentivePush(data);
                Apptentive.BuildPendingIntentFromPushNotification((pendingIntent) =>
                {
                    // This push is from Apptentive, but not for the active conversation, so we can't safely display it.
                    if (pendingIntent == null)
                    {
                        Log.Error(TAG, "Push notification was not for the active conversation. Doing nothing.");
                        return;
                    }

                    ShowNotification(pendingIntent, title, body);
                    
                }, data);
            }
            else
            {
                Log.Error(TAG, "Non-Apptentive push.");
                Intent intent = new Intent(this, typeof(MainActivity));
                intent.AddFlags(ActivityFlags.ClearTop);
                var pushNotification = message.GetNotification();
                if (pushNotification != null)
                {
                    title = pushNotification.Title;
                    body = pushNotification.Body;
                }
                var pendingIntent = PendingIntent.GetActivity(this, 0 /* Request code */, intent, PendingIntentFlags.OneShot);
                ShowNotification(pendingIntent, title, body);
            }
        }

        private void ShowNotification(PendingIntent pendingIntent, string title, string body)
        {
            Log.Error(TAG, "Title: " + title);
            Log.Error(TAG, "Body: " + body);

            var defaultSoundUri = RingtoneManager.GetDefaultUri(RingtoneType.Notification);
            var notificationBuilder = new NotificationCompat.Builder(this)
                .SetSmallIcon(Resource.Drawable.apptentive_status_gear)
                .SetContentTitle(title)
                .SetContentText(body)
                .SetAutoCancel(true)
                .SetSound(defaultSoundUri)
                .SetContentIntent(pendingIntent);
            var notificationManager = (NotificationManager)GetSystemService(Context.NotificationService);
            notificationManager.Notify(0, notificationBuilder.Build());
        }

        private void LogPushBundle(RemoteMessage remoteMessage)
        {
            var data = remoteMessage.Data;
            Log.Error(TAG, "Push Data:");
            foreach (var e in data)
            {
                Log.Error(TAG, "  " + e.Key + " : " + e.Value);
            }
            Log.Error(TAG, data["title"] + ": " + data["body"]);
        }
    }
}
