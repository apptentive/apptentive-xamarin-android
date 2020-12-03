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

            var configuration = new ApptentiveConfiguration("ANDROID-XAMARIN-ANDROID", "22527498ae05c9605dd746cd7c5cb33c");
            configuration.SetLogLevel(ApptentiveLog.Level.Verbose);
            configuration.SetShouldSanitizeLogMessages(false);
            Apptentive.Register(this, configuration);
        }
    }

}
