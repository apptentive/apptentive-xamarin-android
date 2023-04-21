using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Widget;
using ApptentiveSDK.Android;
using Java.Interop;
using Apptentive.Com.Android.Util;
using Apptentive.Com.Android;
using ApptentiveCore;
using Java.Security;
using Apptentive.Com.Android.Feedback.Engagement.Interactions;
using Android.OS;


namespace ApptentiveSDK.Android
{
    public partial class Apptentive
    {
    
        /// <summary>
        /// Registers the ApptentiveKit.Android SDK.
        /// </summary>
        /// <param name="application"> The main application.</param>
        /// <param name="configuration">The ApptentiveConfiguration object.</param>
        /// <param name="onCompletion">Called after successful or failed registration is conducted.</param>

        public static void Register(Application application, ApptentiveConfiguration configuration, Action<bool> onCompletion = null)
        {
            configuration.DistributionName = "Xamarin";
            configuration.DistributionVersion = "6.0.4";
            ApptentiveSDK.Android.Apptentive.Register(application, configuration, new RegisterCallback(onCompletion));
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
            ApptentiveSDK.Android.Apptentive.Engage(eventName, customData, new EngagementCallback(onCompletion));
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
            ApptentiveSDK.Android.Apptentive.ShowMessageCenter(customData, new EngagementCallback(onCompletion));
        }

        /// <summary>
        /// Call this method to see whether or not Message Center can be displayed.
        /// This task is performed asynchronously.
        /// </summary>
        /// <param name="onCompletion">Called after we check to see if Message Center can be displayed, but before it is displayed. Called with true if an Interaction will be displayed, else false.</param>
        public static void CanShowMessageCenter(Action<bool> onCompletion)
        {
            ApptentiveSDK.Android.Apptentive.CanShowMessageCenter(new BooleanCallback(onCompletion));
        }

        /// <summary>
        /// Returns whether or not an engage event will display an Interaction.
        /// </summary>
        /// <param name="eventName">The string name of the event.</param>
        /// <returns></returns>
        public static bool QueryCanShowInteraction(String eventName)
        {
            return ApptentiveSDK.Android.Apptentive.CanShowInteraction(eventName);
        }

        /// <summary>
        /// Use this method in your push receiver to build a PendingIntent when an Apptentive push
        /// notification is received.Pass the generated PendingIntent to
        /// androidx.core.app.NotificationCompat.Builder.setContentIntent to allow Apptentive
        /// to display Interactions such as Message Center.Calling this method for a push Intent that
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
            ApptentiveSDK.Android.Apptentive.BuildPendingIntentFromPushNotification(context, new PendingIntentCallback(onCompletion), intent);
        }

        /// <summary>
        /// Use this method in your push receiver to build a PendingIntent when an Apptentive push
        /// notification is received.Pass the generated PendingIntent to
        /// androidx.core.app.NotificationCompat.Builder.setContentIntent to allow Apptentive
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
            ApptentiveSDK.Android.Apptentive.BuildPendingIntentFromPushNotification(context, new PendingIntentCallback(onCompletion), data);
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
    #nullable enable
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
