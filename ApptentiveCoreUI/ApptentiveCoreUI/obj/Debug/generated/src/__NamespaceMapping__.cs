using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "apptentive.com.android", Managed="Apptentive.Com.Android")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "apptentive.com.android.core", Managed="Apptentive.Com.Android.Core")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "apptentive.com.android.ui", Managed="Apptentive.Com.Android.UI")]

delegate int _JniMarshal_PPL_I (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Enum | AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

