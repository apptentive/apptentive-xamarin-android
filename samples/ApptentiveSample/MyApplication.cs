using System;
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

            var configuration = new ApptentiveKit.Android.ApptentiveConfiguration("ANDROID-XAMARIN-ANDROID", "22527498ae05c9605dd746cd7c5cb33c");
            configuration.LogLevel = Apptentive.Com.Android.Util.LogLevel.Verbose;
            configuration.CustomAppStoreURL = "https://www.alchemer.com";
            configuration.DistributionVersion = "0.0";
            configuration.DistributionName = "XOLOFACTS";
            ApptentiveKit.Apptentive.Register(this, configuration);
        }
    }

}
