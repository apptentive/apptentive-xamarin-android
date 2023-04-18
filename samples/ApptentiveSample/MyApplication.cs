﻿using System;
using Android.App;
using Android.Runtime;
using ApptentiveKit.Android;

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

            var configuration = new ApptentiveKit.Android.ApptentiveConfiguration("", "");
            configuration.LogLevel = Apptentive.Com.Android.Util.LogLevel.Verbose;
            ApptentiveKit.Apptentive.Register(this, configuration);
        }
    }

}
