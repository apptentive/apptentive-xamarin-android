using Android.App;
using Android.Widget;
using Android.OS;
using ApptentiveKit.Android;
using System;
using Android.Content;
using Android.Gms.Common;
using Android.Util;
using Kotlin;
using Xamarin.Essentials;
using Android.Support.V7.App;
using AndroidX.Fragment.App;
using AndroidX.Lifecycle;
using Firebase.Messaging;
using Firebase.Iid;


namespace ApptentiveSample
{
    [Activity(Label = "ApptentiveSample", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, IApptentiveActivityInfo
    {
        TextView unreadMessagesTextView;

        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            ApptentiveKit.Apptentive.RegisterActivityInfoCallback(this);

            // Controls
            var eventNameEditText = FindViewById<EditText>(Resource.Id.eventEditText);

            var messageCenterButton = FindViewById<Button>(Resource.Id.messageCenterButton);
            messageCenterButton.Click += delegate
            {
                ApptentiveKit.Apptentive.ShowMessageCenter((shown) => Console.WriteLine("Message Center shown: " + shown));
            };

            var engageButton = FindViewById<Button>(Resource.Id.engageButton);
            engageButton.Click += delegate
            {
                var eventName = eventNameEditText.Text;
                Console.WriteLine("Event Name: " + eventName);
                ApptentiveKit.Apptentive.Engage(eventName, null, (engaged) => Console.WriteLine("Interaction engaged: " + engaged));
            };

            var canShowInteractionButton = FindViewById<Button>(Resource.Id.canShowInteractionButton);
            canShowInteractionButton.Click += delegate
            {
                var eventName = eventNameEditText.Text;
                var canShowInteraction = ApptentiveKit.Apptentive.CanShowInteraction(eventName);
                if (canShowInteraction)
                {
                    Toast.MakeText(this, "Interaction can be shown", ToastLength.Long).Show();
                }
                else {
                    Toast.MakeText(this, "Interaction cannot be shown", ToastLength.Long).Show();
                }
            };

            var userDataButton = FindViewById<Button>(Resource.Id.userDataButton);
            userDataButton.Click += delegate
            {
                var intent = new Intent(this, typeof(UserDataActivity));
                StartActivity(intent);
            };

            var customDataButton = FindViewById<Button>(Resource.Id.customDataButton);
            customDataButton.Click += delegate
            {
                var intent = new Intent(this, typeof(CustomDataActivity));
                StartActivity(intent);
            };

            var updateUnreadMessageCountButton = FindViewById<Button>(Resource.Id.updateUnreadMessageCount);
            updateUnreadMessageCountButton.Click += delegate {

                UpdateUnreadMessagesCount();
            };

          

            //Removed Until Implemented.
            //var authenticationButton = FindViewById<Button>(Resource.Id.authenticationButton);
            //authenticationButton.Click += delegate
            //{
            //    var intent = new Intent(this, typeof(LoginActivity));
            //    StartActivity(intent);
            //};

            unreadMessagesTextView = FindViewById<TextView>(Resource.Id.unreadMessagesText);

            UpdateUnreadMessagesCount();
          
        }

        protected override void OnResume()
        {
            base.OnResume();
            CheckGooglePlayServicesAvailable();
        }

        public Activity ApptentiveActivityInfo
        {
            get
            {
                return this;
            }
        }

        public Activity GetApptentiveActivityInfo()
        {
            return this;
        }

        void UpdateUnreadMessagesCount()
        {
            unreadMessagesTextView.Text = "Unread messages: " + ApptentiveKit.Apptentive.GetUnreadMessageCount();
        }

        #region IUnreadMessagesListener

        public void OnUnreadMessageCountChanged(int count)
        {
            RunOnUiThread(delegate ()
            {
                UpdateUnreadMessagesCount();
            });
        }

        #endregion

        #region GooglePlayServices

        private void CheckGooglePlayServicesAvailable()
        {
            int resultCode = GoogleApiAvailability.Instance.IsGooglePlayServicesAvailable(this);
            if (resultCode != ConnectionResult.Success)
            {
                if (GoogleApiAvailability.Instance.IsUserResolvableError(resultCode))
                {
                    ShowToast(GoogleApiAvailability.Instance.GetErrorString(resultCode));
                }
                else
                {
                    ShowToast("This device is not supported");
                }
            }
            else
            {
                ShowToast("Google Play Services is availabl.");
            }
        }

       

        #endregion

        #region Helpers

        private void ShowToast(string message)
        {
            Toast.MakeText(this, message, ToastLength.Long).Show();
        }

        #endregion
    }
}

