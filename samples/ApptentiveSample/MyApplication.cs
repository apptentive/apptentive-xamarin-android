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

            var configuration = new ApptentiveConfiguration("", "");
            configuration.ShouldInheritAppTheme = false;
            configuration.LogLevel = Apptentive.Com.Android.Util.LogLevel.Verbose;
            ApptentiveSDK.Android.Apptentive.Register(this, configuration);
        }
    }
}
