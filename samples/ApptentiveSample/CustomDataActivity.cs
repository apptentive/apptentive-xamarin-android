
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ApptentiveKit.Android;

namespace ApptentiveSample
{
    [Activity(Label = "CustomDataActivity")]
    public class CustomDataActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.CustomData);

            EditText personStringKey = FindViewById<EditText>(Resource.Id.personStringKey);
            EditText personIntKey = FindViewById<EditText>(Resource.Id.personIntKey);
            EditText personBoolKey = FindViewById<EditText>(Resource.Id.personBoolKey);
            EditText personStringValue = FindViewById<EditText>(Resource.Id.personStringValue);
            EditText personIntValue = FindViewById<EditText>(Resource.Id.personIntValue);
            Android.Widget.Switch personBoolValue = FindViewById<Android.Widget.Switch>(Resource.Id.personBoolValue);
            EditText deviceStringKey = FindViewById<EditText>(Resource.Id.deviceStringKey);
            EditText deviceIntKey = FindViewById<EditText>(Resource.Id.deviceIntKey);
            EditText deviceBoolKey = FindViewById<EditText>(Resource.Id.deviceBoolKey);
            EditText deviceStringValue = FindViewById<EditText>(Resource.Id.deviceStringValue);
            EditText deviceIntValue = FindViewById<EditText>(Resource.Id.deviceIntValue);
            Android.Widget.Switch deviceBoolValue = FindViewById<Android.Widget.Switch>(Resource.Id.deviceBoolValue);

            FindViewById<Button>(Resource.Id.addPersonCustomDataButton).Click += delegate {
                //person string
                ApptentiveKit.Apptentive.AddCustomPersonData(personStringKey.Text, personStringValue.Text);
                //person int
                if (int.TryParse(personIntValue.Text, out int intValue))
                {
                    ApptentiveKit.Apptentive.AddCustomPersonData(personStringKey.Text, intValue);
                }
                //person bool
                ApptentiveKit.Apptentive.AddCustomPersonData(personStringKey.Text, personBoolValue.Checked);

            };

          
            FindViewById<Button>(Resource.Id.addDeviceDataButton).Click += delegate {
                //device string
                ApptentiveKit.Apptentive.AddCustomDeviceData(deviceStringKey.Text, deviceStringValue.Text);
                //device int
                if (int.TryParse(personIntValue.Text, out int deviceIntValue))
                {
                    ApptentiveKit.Apptentive.AddCustomDeviceData(deviceIntKey.Text, deviceIntValue);
                }
                //device bool
                ApptentiveKit.Apptentive.AddCustomDeviceData(deviceBoolKey.Text, deviceBoolValue.Checked);
            };

           
            FindViewById<Button>(Resource.Id.removeCustomData).Click += delegate {
                ApptentiveKit.Apptentive.RemoveCustomPersonData(personStringKey.Text);
                ApptentiveKit.Apptentive.RemoveCustomPersonData(personIntKey.Text);
                ApptentiveKit.Apptentive.RemoveCustomPersonData(personBoolKey.Text);
                ApptentiveKit.Apptentive.RemoveCustomDeviceData(deviceStringKey.Text);
                ApptentiveKit.Apptentive.RemoveCustomDeviceData(deviceIntKey.Text);
                ApptentiveKit.Apptentive.RemoveCustomDeviceData(deviceBoolKey.Text);
            };

                FindViewById<Button>(Resource.Id.saveButton).Click += delegate {
              Finish();
            };

           }
  }
}

