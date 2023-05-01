
using Android.App;
using Android.Media;
using Firebase.Messaging;
using System;
using ApptentiveSDK;
using Android.Content;
using Android.Support.V4.App;
using Android.OS;
using static Firebase.Messaging.RemoteMessage;

namespace ApptentiveSample
{
    [Service]
    [IntentFilter(new[] { "com.google.firebase.MESSAGING_EVENT" })]
    public class MyFirebaseMessagingService : FirebaseMessagingService
    {
        const string TAG = "MyFirebaseMsgService";

        public override void OnNewToken(string token)
        {
            ApptentiveSDK.Apptentive.SetPushNotificationIntegration(this, ApptentiveSDK.Apptentive.PushProviderApptentive, token);
        }

        public override void OnMessageReceived(RemoteMessage message)
        {
            var data = message.Data;

            String title = null;
            String body = null;
         
            var isPush = ApptentiveSDK.Apptentive.IsApptentivePushNotification(data);
            var channel = new NotificationChannel("channel_id", "channel_name", NotificationImportance.Default)
            {
                Description = "channel_description"
            };
            var notificationManager = GetSystemService(NotificationService) as NotificationManager;
            notificationManager.CreateNotificationChannel(channel);
            int notificationId = 1;
            if (ApptentiveSDK.Apptentive.IsApptentivePushNotification(data))
            {
          
                title = ApptentiveSDK.Apptentive.GetTitleFromApptentivePush(data);
                body = ApptentiveSDK.Apptentive.GetBodyFromApptentivePush(data);
                ApptentiveSDK.Apptentive.BuildPendingIntentFromPushNotification(this,(pendingIntent) =>
                {
                    // This push is from Apptentive, but not for the active conversation, so we can't safely display it.
                    if (pendingIntent == null)
                    {
                        Console.WriteLine(TAG, "Push notification was not for the active conversation. Doing nothing.");
                        return;
                    }

                    ShowNotification(pendingIntent, title, body, notificationId, notificationManager);

                }, data);
            }
            else
                {
                    Intent intent = new Intent(this, typeof(MainActivity));
                    intent.AddFlags(ActivityFlags.ClearTop);
                    var pushNotification = message.GetNotification();
                    if (pushNotification != null)
                    {
                        title = pushNotification.Title;
                        body = pushNotification.Body;
                    }
                    var pendingIntent = PendingIntent.GetActivity(this, 0 /* Request code */, intent, PendingIntentFlags.OneShot);
                 ShowNotification(pendingIntent, title, body, notificationId, notificationManager);
            }
           }


        private void ShowNotification(PendingIntent pendingIntent, string title, string body, int notificationId, NotificationManager notificationManager)
        {
            var defaultSoundUri = RingtoneManager.GetDefaultUri(RingtoneType.Notification);
            var notificationBuilder = new NotificationCompat.Builder(this, "channel_id")
                .SetSmallIcon(Resource.Drawable.apptentive_ic_send)
                .SetContentTitle(title)
                .SetContentText(body)
                .SetAutoCancel(true)
                .SetSound(defaultSoundUri)
                .SetContentIntent(pendingIntent);
            notificationManager.Notify(0, notificationBuilder.Build());
            notificationManager.Notify(notificationId, notificationBuilder.Build());
        }
    }
}