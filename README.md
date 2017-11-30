# Apptentive Xamarin Android SDK

## Register Apptentive
Register Apptentive in your Application class.

```
using System;
using Android.App;
using Android.Runtime;
using ApptentiveSDK.Android;

namespace ApptentiveSample
{
    [Application]
    public class MyApplication : Application
    {
        public MyApplication(IntPtr handle, JniHandleOwnership ownerShip)
            : base(handle, ownerShip)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();
            Apptentive.Register(this, "Your Apptentive Key", "Your Apptentive Signature");
        }
    }

}
```
Make sure you use the Apptentive App Key and Signature for the Android app you created in the Apptentive console. Sharing these keys between two apps, or using keys from the wrong platform is not supported, and will lead to incorrect behavior. You can find them [here](https://be.apptentive.com/apps/current/settings/api).

## Message Center

See: [How to Use Message Center](https://learn.apptentive.com/knowledge-base/how-to-use-message-center/)

### Showing Message Center

With the Apptentive Message Center your customers can send feedback, and you can reply, all without making them leave the app. Handling support inside the app will increase the number of support messages received and ensure a better customer experience.

Message Center lets customers see all the messages they have send you, read all of your replies, and even send screenshots that may help debug issues.

Add [Message Center](http://learn.apptentive.com/knowledge-base/apptentive-android-sdk-features/#message-center) to talk to your customers.

Find a place in your app where you can add a button that opens Message Center. Your setings page is a good place.

```
var messageCenterButton = FindViewById<Button>(...);
messageCenterButton.Click += delegate
{
    Apptentive.ShowMessageCenter(context);
};
```

### Checking Unread Message Count

You can also check to see how many messages are waiting to be read in the customer’s Message Center.
```
var unreadMessageCount = Apptentive.UnreadMessageCount;
if (unreadMessageCount > 0)
{
    Console.WriteLine("You have {0} unread messages", unreadMessageCount);
}
```

### Unread Message Count Notification

You can receive a callback when a new unread message comes in. You can use this callback to notify your customer, and display a badge letting them know how many unread messages are waiting for them. Because this listener could be called at any time, you should store the value returned from this method, and then perform any user interaction you desire at the appropriate time.
```
public class MainActivity : Activity, IUnreadMessagesListener
{
    TextView unreadMessagesTextView;

    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        
        ...

        unreadMessagesTextView = FindViewById<TextView>(...);

        Apptentive.AddUnreadMessagesListener(this);
    }

    public void OnUnreadMessageCountChanged(int count)
    {
        RunOnUiThread(delegate ()
        {
            unreadMessagesTextView.Text = "Unread messages: " + Apptentive.UnreadMessageCount;
        });
    }
}
```

The listener will not be run on the UI thread, and may be called from a different Activity than the one that is set on the listener. The correct way of setting Apptentive listeners is to create a listener with the same lifecycle as it’s intended usage, then passing it to Apptentive. For example, if the listener is going to be used in a specific activity, make the listener an Activity data member. This way, when the activity is gone, the listener will automatically be garbage collected and Apptentive will know about this through WeakReference (and we’ll stop calling the listener).

## Events

Events record user interaction. You can use them to determine if and when an Interaction will be shown to your customer. You will use these Events later to target Interactions, and to determine whether an Interaction can be shown. You trigger an Event with the `Engage()` method. This will record the Event, and then check to see if any Interactions targeted to that Event are allowed to be displayed, based on the logic you set up in the Apptentive Dashboard.
  
```
var engageButton = FindViewById<Button>(...);
engageButton.Click += delegate
{
    Apptentive.Engage(this, "my_event");
};
```

You can add an Event almost anywhere in your app, just remember that if you want to show an Interaction at that Event, it needs to be a place where launching an Activity will not cause a problem in your app.

## Push Notifications
Apptentive can send push notifications to ensure your customers see your replies to their feedback in Message Center.

### Firebase Cloud Messaging
If you are using Firebase Cloud Messaging (FCM) directly, without another push provider layered on top, please follow these instructions.
- Follow the FCM instructions to [Set Up a Firebase Cloud Messaging Client App.]
(https://developer.xamarin.com/guides/android/application_fundamentals/notifications/firebase-cloud-messaging/)
- Go to [Integrations](https://be.apptentive.com/apps/current/settings/integrations), choose Apptentive Push, and enter your FCM Server Key.
- In your `FirebaseInstanceIdService`, pass Apptentive your **token**.
```
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
```
- In your `FirebaseMessagingService`, get the title, body, and `PendingIntent` from the incoming push, and create a `Notification` to display to your customer. If the returned `PendingIntent` is null, then the push did not come from Apptentive, and you should handle it yourself.
```
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
            var data = message.Data;

            PendingIntent pendingIntent = null;
            String title = null;
            String body = null;

            if (Apptentive.IsApptentivePushNotification(data))
            {
                Log.Error(TAG, "Apptentive push.");
                title = Apptentive.GetTitleFromApptentivePush(data);
                body = Apptentive.GetBodyFromApptentivePush(data);
                pendingIntent = Apptentive.BuildPendingIntentFromPushNotification(data);

                // This push is from Apptentive, but not for the active conversation, so we can't safely display it.
                if (pendingIntent == null)
                {
                    Log.Error(TAG, "Push notification was not for the active conversation. Doing nothing.");
                    return;
                }

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
            else
            {
                // Non-Apptentive push
            }
        }
    }
}
```
