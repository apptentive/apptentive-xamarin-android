﻿
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
    [Activity(Label = "UserDataActivity")]
    public class UserDataActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.UserData);

            var personNameEditText = FindViewById<EditText>(Resource.Id.personNameEditText);
            personNameEditText.Text = ApptentiveKit.Apptentive.GetPersonName();

            var personEmailEditText = FindViewById<EditText>(Resource.Id.personEmailEditText);
            personEmailEditText.Text = ApptentiveKit.Apptentive.GetPersonEmail();

            var saveButton = FindViewById<Button>(Resource.Id.saveButton);
            saveButton.Click += delegate
            {
                ApptentiveKit.Apptentive.SetPersonName(personNameEditText.Text);
                ApptentiveKit.Apptentive.SetPersonEmail(personEmailEditText.Text);
                Finish();
            };
        }
    }
}
