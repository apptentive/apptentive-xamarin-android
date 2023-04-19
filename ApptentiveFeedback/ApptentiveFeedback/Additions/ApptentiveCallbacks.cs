using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Widget;
using ApptentiveKit.Android;
using Java.Interop;
using Apptentive.Com.Android.Util;
using Apptentive.Com.Android;
using ApptentiveCore;
using ApptentiveKit;
using Java.Security;
using static Android.OS.Build;
using static Android.Provider.Telephony.Sms;
using static Android.Provider.Contacts.Intents;
using static Android.Provider.ContactsContract.CommonDataKinds;
using Apptentive.Com.Android.Feedback.Engagement.Interactions;
using Android.Telecom;
using Android.Views;
using static Android.Graphics.Paint;
using Android.OS;

namespace ApptentiveKit
{
    public partial class Apptentive
    {
    
        /// <summary>
        /// Registers the ApptentiveKit.Android SDK.
        /// </summary>
        /// <param name="application"> The main application.</param>
        /// <param name="configuration">The ApptentiveConfiguration object.</param>
        /// <param name="onCompletion">Called after successful or failed registration is conducted.</param>

        public static void Register(Application application, ApptentiveKit.Android.ApptentiveConfiguration configuration, Action<bool> onCompletion = null)
        {
            ApptentiveKit.Android.Apptentive.Register(application, configuration, new RegisterCallback(onCompletion));
        }

        /// <summary>
        /// Registers the current activity to the Apptentive SDK so that interactions can be displayed. 
        /// </summary>
        /// <param name="activity">The current activity of the application.</param>
        public static void RegisterActivityInfoCallback(IApptentiveActivityInfo activity)
        {
            try
            {
                ApptentiveKit.Android.Apptentive.RegisterApptentiveActivityInfoCallback(activity);
            }
            catch (Exception ex)
            {
                Console.WriteLine("MyApp", "Error registering Apptentive activity info callback: " + ex.Message);
            }
        }

        /// <summary>
        /// Unregisters the current activity from the Apptentive SDK.
        /// </summary>
        public static void UnregisterActivityInfoCallback()
        {
            ApptentiveKit.Android.Apptentive.UnregisterApptentiveActivityInfoCallback();

        }

        /// <summary>
        /// Gets the number of unread messages from MessageCenter.
        /// </summary>
        /// <returns>The numnber of unread messages.</returns>
        public static int GetUnreadMessageCount()
        {
          return ApptentiveKit.Android.Apptentive.UnreadMessageCount;
        }

        /// <summary>
        /// This method takes a unique event of type [String], stores a record of that event having been visited, determines if there is an interaction that is able to run for this event, and then
        /// runs it. Only one interaction at most will run per invocation of this method. This task is performed asynchronously.
        /// </summary>
        /// <param name="onCompletion">Called after we check if a interaction can be presented or not.</param>
        /// <param name="customData">A Map of String keys to Object values. Objects may be Strings, Numbers, or Booleans.If any message is sent by the Person, this data is sent with it, and then cleared. If no message is sent, this data is discarded.</param>
        /// <param name="eventName">The event's string value</param>
        public static void Engage(String eventName, IDictionary<string, Java.Lang.Object> customData = null, Action<bool> onCompletion = null)
        {
            ApptentiveKit.Android.Apptentive.Engage(eventName, customData, new EngagementCallback(onCompletion));
        }

        /// <summary>
        /// Opens the Apptentive Message Center UI Activity, and allows custom data to be sent with the next message the user sends. If the user sends multiple messages, this data will only be sent
        /// with the first message sent after this method is invoked. Additional invocations of this method with custom data will repeat this process.
        /// If Message Center is closed without a message being sent, the custom data is cleared. This task is performed asynchronously. Message Center
        /// configuration may not have been downloaded yet when this is called.
        /// </summary>
        /// <param name="onCompletion">Called after we check to see if Message Center can be displayed, but before it is displayed.</param>
        /// <param name="customData">A Map of String keys to Object values. Objects may be Strings, Numbers, or Booleans.If any message is sent by the Person, this data is sent with it, and then cleared. If no message is sent, this data is discarded.</param>
        public static void ShowMessageCenter(Action<bool> onCompletion, IDictionary<string, Java.Lang.Object> customData = null)
        {
            ApptentiveKit.Android.Apptentive.ShowMessageCenter(customData, new EngagementCallback(onCompletion));
        }

        /// <summary>
        /// Call this method to see whether or not Message Center can be displayed.
        /// This task is performed asynchronously.
        /// </summary>
        /// <param name="onCompletion">Called after we check to see if Message Center can be displayed, but before it is displayed. Called with true if an Interaction will be displayed, else false.</param>
        public static void CanShowMessageCenter(Action<bool> onCompletion)
        {
            ApptentiveKit.Android.Apptentive.CanShowMessageCenter(new BooleanCallback(onCompletion));
        }

        /// <summary>
        /// Returns whether or not an engage event will display an Interaction.
        /// </summary>
        /// <param name="eventName">The string name of the event.</param>
        /// <returns></returns>
        public static bool CanShowInteraction(String eventName)
        {
            return ApptentiveKit.Android.Apptentive.CanShowInteraction(eventName);
        }

        /// <summary>
        /// Sets the user's name. This name will be sent to the Apptentive server and displayed in
        /// conversations you have with this person.This name will be the definitive username for this
        /// user, unless one is provided directly by the user through an Apptentive UI.
        /// </summary>
        /// <param name="name">The name of the user.</param>
        public static void SetPersonName(String name)
        {
            ApptentiveKit.Android.Apptentive.PersonName = name;

        }

        /// <summary>
        /// Retrieves the user's name.
        /// </summary>
        /// <returns>The user's name if set.</returns>
        public static string GetPersonName()
        {
            return ApptentiveKit.Android.Apptentive.PersonName;
        }

        /// <summary>
        /// Sets the user's email address. This email address will be sent to the Apptentive server to
        /// allow out of app communication, and to help provide more context about this user.This email
        /// will be the definitive email address for this user, unless one is provided directly by the
        /// user through an Apptentive UI.
        /// </summary>
        /// <param name="email">The email of the user.</param>
        public static void SetPersonEmail(String email)
        {
            ApptentiveKit.Android.Apptentive.PersonEmail = email;
        }

        /// <summary>
        /// Retrieves the user's email.
        /// </summary>
        /// <returns>The email of the user if set.</returns>
        public static string GetPersonEmail()
        {
            return ApptentiveKit.Android.Apptentive.PersonEmail;
        }

        /// <summary>
        /// Add a custom data String to the Person. Custom data will be sent to the server, is displayed
        /// in the Conversation view, and can be used in Interaction targeting.
        /// </summary>
        /// <param name="key">The key to store the data under.</param>
        /// <param name="value">A String value.</param>
        public static void AddCustomPersonData(String key, String value)
        {
            ApptentiveKit.Android.Apptentive.AddCustomPersonData(key, value);
        }

        /// <summary>
        /// Add a custom data int to the Person. Custom data will be sent to the server, is displayed
        /// in the Conversation view, and can be used in Interaction targeting.
        /// </summary>
        /// <param name="key">The key to store the data under.</param>
        /// <param name="value">A int value.</param>
        public static void AddCustomPersonData(String key, int value)
        {
            Java.Lang.Integer intValue = Java.Lang.Integer.ValueOf(value);
            Java.Lang.Number numberValue = (Java.Lang.Number)intValue;

            ApptentiveKit.Android.Apptentive.AddCustomPersonData(key, numberValue);
        }

        /// <summary>
        /// Add a custom data bool to the Person. Custom data will be sent to the server, is displayed
        /// in the Conversation view, and can be used in Interaction targeting.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void AddCustomPersonData(String key, bool value)
        {
            Java.Lang.Boolean javaValue = Java.Lang.Boolean.ValueOf(value);
            ApptentiveKit.Android.Apptentive.AddCustomPersonData(key, javaValue);
        }

        /// <summary>
        /// Remove a piece of custom data from the Person. 
        /// </summary>
        /// <param name="key">The key to remove.</param>
        public static void RemoveCustomPersonData(String key)
        {
            ApptentiveKit.Android.Apptentive.RemoveCustomPersonData(key);
        }

        /// <summary>
        /// Add a custom data String to the Person. Custom data will be sent to the server, is displayed
        /// in the Conversation view, and can be used in Interaction targeting.
        /// </summary>
        /// <param name="key">The key to store the data under.</param>
        /// <param name="value">A String value.</param>
        public static void AddCustomDeviceData(String key, String value)
        {
            ApptentiveKit.Android.Apptentive.AddCustomDeviceData(key, value);
        }

        /// <summary>
        /// Add a custom data int to the Person. Custom data will be sent to the server, is displayed
        /// in the Conversation view, and can be used in Interaction targeting.
        /// </summary>
        /// <param name="key">The key to store the data under.</param>
        /// <param name="value">A int value.</param>
        public static void AddCustomDeviceData(String key, int value)
        {
            Java.Lang.Integer intValue = Java.Lang.Integer.ValueOf(value);
            Java.Lang.Number numberValue = (Java.Lang.Number)intValue;

            ApptentiveKit.Android.Apptentive.AddCustomDeviceData(key, numberValue);
        }

        /// <summary>
        /// Add a custom data bool to the Person. Custom data will be sent to the server, is displayed
        /// in the Conversation view, and can be used in Interaction targeting.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void AddCustomDeviceData(String key, bool value)
        {
            Java.Lang.Boolean javaValue = Java.Lang.Boolean.ValueOf(value);
            ApptentiveKit.Android.Apptentive.AddCustomDeviceData(key, javaValue);
        }

        /// <summary>
        /// Sends a text message to the server. This message will be visible in the conversation view
        /// on the server, but will not be shown in the client's Message Center.
        /// </summary>
        /// <param name="text">The message you wish to send.</param>
        public static void SendAttachmentText(String text)
        {
            ApptentiveKit.Android.Apptentive.SendAttachmentText(text);
        }

        /// <summary>
        /// Sends a file to the server. This file will be visible in the conversation view on the server,
        /// but will not be shown in the client's Message Center. A local copy of this file will be made
        /// until the message is transmitted, at which point the temporary file will be deleted.
        /// </summary>
        /// <param name="uri">The URI path of the local resource file.</param>
        public static void SendAttachmentFile(String uri)
        {
            ApptentiveKit.Android.Apptentive.SendAttachmentFile(uri);
        }

        /// <summary>
        /// Remove a piece of custom data from the device. Calls to this method are idempotent.
        /// </summary>
        /// <param name="key">The key to remove.</param>
        public static void RemoveCustomDeviceData(String key)
        {
            ApptentiveKit.Android.Apptentive.RemoveCustomDeviceData(key);
        }

        /// <summary>
        /// Sends push provider information to our server to allow us to send pushes to this device when
        /// you reply to your customers.Only one push provider is allowed to be active at a time, so you
        /// should only call this method once.
        /// </summary>
        /// <param name="context">The current context of the app.</param>
        /// <param name="pushProvider">The selected push provider value.</param>
        /// <param name="token">The token provided by the push provider.</param>
        public static void SetPushNotificationIntegration(Context context, int pushProvider, String token)
        {
            ApptentiveKit.Android.Apptentive.SetPushNotificationIntegration(context, pushProvider, token);
        }

        /// <summary>
        /// Determines whether this Intent is a push notification sent from Apptentive.
        /// </summary>
        /// <param name="intent">The received intent received in the broadcast receiver.</param>
        /// <returns>`true` if the intent came from and should be handled by Apptentive.</returns>
        public static bool IsApptentivePushNotification(Intent intent)
        {
            return ApptentiveKit.Android.Apptentive.IsApptentivePushNotification(intent);
        }

        /// <summary>
        /// Determines whether push payload data came from an Apptentive Push Notification.
        /// This method is also used for Urban Airship.
        /// </summary>
        /// <param name="data">The push payload data obtained through FCM `onMessageReceived()`, when using FCM</param>
        /// <returns>`true` if the push came from, and should be handled by Apptentive.</returns>
        public static bool IsApptentivePushNotification(IDictionary<string, string> data)
        {
            return ApptentiveKit.Android.Apptentive.IsApptentivePushNotification(data);
        }

        /// <summary>
        /// Use this method in your push receiver to build a PendingIntent when an Apptentive push
        /// notification is received.Pass the generated PendingIntent to
        /// [androidx.core.app.NotificationCompat.Builder.setContentIntent] to allow Apptentive
        /// to display Interactions such as Message Center.Calling this method for a push [Intent] that
        /// did not come from Apptentive will return a null object. If you receive a `null` object, your
        /// app will need to handle this notification itself.
        /// </summary>
        /// <param name="context">The current context of the app.</param>
        /// <param name="onCompletion">Called after we check to see Apptentive can launch an Interaction from this
        /// push. Called with a PendingIntent to launch an Apptentive Interaction
        /// if the push data came from Apptentive, and an Interaction can be shown, or
        /// `null`.</param>
        /// <param name="intent">An Intent containing the Apptentive Push data. Pass in what you receive
        /// in the Service or BroadcastReceiver that is used by your chosen push provider.</param>
        public static void BuildPendingIntentFromPushNotification(Context context, Action<PendingIntent> onCompletion, Intent intent)
        {
            ApptentiveKit.Android.Apptentive.BuildPendingIntentFromPushNotification(context, new PendingIntentCallback(onCompletion), intent);
        }

        /// <summary>
        /// Use this method in your push receiver to build a PendingIntent when an Apptentive push
        /// notification is received.Pass the generated PendingIntent to
        /// [androidx.core.app.NotificationCompat.Builder.setContentIntent] to allow Apptentive
        /// to display Interactions such as Message Center.Calling this method for a push Intent that
        /// did not come from Apptentive will return a null object. If you receive a `null` object, your
        /// app will need to handle this notification itself.
        /// </summary>
        /// <param name="context">The current context of the app.</param>
        /// <param name="onCompletion">Called after we check to see Apptentive can launch an Interaction from this
        /// push. Called with a PendingIntent to launch an Apptentive Interaction
        /// if the push data came from Apptentive, and an Interaction can be shown, or
        /// `null`.</param>
        /// <param name="data">Contains the Apptentive
        /// Push data. Pass in what you receive in the the Service or BroadcastReceiver
        /// that is used by your chosen push provider.</param>
        public static void BuildPendingIntentFromPushNotification(Context context, Action<PendingIntent> onCompletion, IDictionary<string, string> data)
        {
            ApptentiveKit.Android.Apptentive.BuildPendingIntentFromPushNotification(context, new PendingIntentCallback(onCompletion), data);
        }

#nullable enable
        /// <summary>
        /// Use this method in your push receiver to get the notification title you can use to construct
        /// an android.app.Notification object.
        /// </summary>
        /// <param name="intent">An Intent containing the Apptentive Push data. Pass in what you receive
        /// in the Service or BroadcastReceiver that is used by your chosen push provider.</param>
        /// <returns>A String or null.</returns>
        public static string? GetTitleFromApptentivePush(Intent intent)
        {
            return ApptentiveKit.Android.Apptentive.GetTitleFromApptentivePush(intent);
        }

        /// <summary>
        /// Use this method in your push receiver to get the notification body you can use to construct
        /// an android.app.Notification object.
        /// </summary>
        /// <param name="intent">An Intent containing the Apptentive Push data. Pass in what you receive
        /// in the Service or BroadcastReceiver that is used by your chosen push provider.</param>
        /// <returns>A String or null.</returns>
        public static string? GetBodyFromApptentivePush(Intent intent)
        {
            return ApptentiveKit.Android.Apptentive.GetBodyFromApptentivePush(intent);
        }

        /// <summary>
        /// Use this method in your push receiver to get the notification title you can use to construct
        /// an android.app.Notification object.
        /// </summary>
        /// <param name="bundle">A Bundle containing the Apptentive Push data. Pass in what you receive in
        /// the the or that is used by your chosen push provider.</param>
        /// <returns>A string or null value.</returns>
        public static string? GetTitleFromApptentivePush(Bundle bundle)
        {
            return ApptentiveKit.Android.Apptentive.GetTitleFromApptentivePush(bundle);
        }

        /// <summary>
        /// Use this method in your push receiver to get the notification body you can use to construct
        /// an android.app.Notification object.
        /// </summary>
        /// <param name="bundle">An Bundle containing the Apptentive Push data. Pass in what you receive
        /// in the Service or BroadcastReceiver that is used by your chosen push provider.</param>
        /// <returns>A String or null.</returns>
        public static string? GetBodyFromApptentivePush(Bundle bundle)
        {
            return ApptentiveKit.Android.Apptentive.GetBodyFromApptentivePush(bundle);
        }

        /// <summary>
        /// Use this method in your push receiver to get the notification title you can use to construct
        /// an android.app.Notification object.
        /// </summary>
        /// <param name="data">A Dictionary containing the Apptentive Push data. Pass in what you receive in
        /// the the or that is used by your chosen push provider.</param>
        /// <returns>A string or null value.</returns>
        public static string? GetTitleFromApptentivePush(IDictionary<string, string> data)
        {
            return ApptentiveKit.Android.Apptentive.GetTitleFromApptentivePush(data);
        }

        /// <summary>
        /// Use this method in your push receiver to get the notification body you can use to construct
        /// an android.app.Notification object.
        /// </summary>
        /// <param name="data">An Dictionary containing the Apptentive Push data. Pass in what you receive
        /// in the Service or BroadcastReceiver that is used by your chosen push provider.</param>
        /// <returns>A String or null.</returns>
        public static string? GetBodyFromApptentivePush(IDictionary<string, string> data)
        {
            return ApptentiveKit.Android.Apptentive.GetBodyFromApptentivePush(data);
        }

        internal interface IEngagementCallback : IJavaObject
        {
            void OnComplete(EngagementResult result);
        }

        internal interface IRegisterCallback : IJavaObject
        {
            void OnComplete(RegisterResult result);
        }

       internal interface IBooleanCallback
        {
            void OnFinish(Boolean result);
        }

    }

    public class PendingIntentCallback : Java.Lang.Object, IPendingIntentCallback
    {
        private readonly Action<PendingIntent?> onCompletion;


        public PendingIntentCallback(Action<PendingIntent?> onCompletion)
        {
            this.onCompletion = onCompletion;
        }

        public void OnPendingIntent(PendingIntent pendingIntent)
        {
            if (pendingIntent != null)
            {
                onCompletion.Invoke(pendingIntent);
            }
            else {
                onCompletion.Invoke(null);
            }
        }

    }

    public class BooleanCallback : Java.Lang.Object, IBooleanCallback
    {
        private readonly Action<bool> onCompletion;

        public BooleanCallback(Action<bool> onCompletion)
        {
            this.onCompletion = onCompletion;
        }

        public void OnFinish(Java.Lang.Boolean result)
        {
            if (result.BooleanValue())
            {
                onCompletion?.Invoke(true);
            }

            else
            {
                onCompletion?.Invoke(false);
            }
        }
    }

    public class  RegisterCallback : Java.Lang.Object, IRegisterCallback
    {
        private readonly Action<bool> onCompletion;

        public RegisterCallback(Action<bool> onCompletion)
        {
            this.onCompletion = onCompletion;
        }


        public void OnComplete(RegisterResult result)
        {
            if (result is RegisterResult.Success)
            {
                onCompletion?.Invoke(true);
            }

            else
            {
                onCompletion?.Invoke(false);
            }
        }
    }


    public class EngagementCallback : Java.Lang.Object, IEngagementCallback
    {
        private readonly Action<bool> onCompletion;

        public EngagementCallback(Action<bool> onCompletion)
        {
            this.onCompletion = onCompletion;
        }

    
        public void OnComplete(EngagementResult result)
        {
            if (result is EngagementResult.InteractionShown)
            {
                onCompletion?.Invoke(true);
            }

            else
            {
                onCompletion?.Invoke(false);
            }
        }
    }
}
