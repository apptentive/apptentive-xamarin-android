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

            var configuration = new ApptentiveConfiguration("Your Apptentive Key", "Your Apptentive Signature");
            configuration.SetLogLevel(ApptentiveLog.Level.Verbose);
            configuration.SetShouldSanitizeLogMessages(false);
            Apptentive.Register(this, configuration);
        }
    }

}
