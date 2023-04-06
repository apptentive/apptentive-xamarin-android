using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "apptentive.com.android.concurrent", Managed="Apptentive.Com.Android.Concurrent")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "apptentive.com.android.core", Managed="ApptentiveCore")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "apptentive.com.android.debug", Managed="Apptentive.Com.Android.Debug")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "apptentive.com.android.encryption", Managed="Apptentive.Com.Android.Encryption")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "apptentive.com.android.feedback.platform", Managed="Apptentive.Com.Android.Feedback.Platform")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "apptentive.com.android.platform", Managed="Apptentive.Com.Android.Platform")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "apptentive.com.android.util", Managed="Apptentive.Com.Android.Util")]

delegate double _JniMarshal_PP_D (IntPtr jnienv, IntPtr klass);
delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate bool _JniMarshal_PPLL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate IntPtr _JniMarshal_PPLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPLLZ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, bool p2);
delegate bool _JniMarshal_PPLLZ_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, bool p2);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Enum | AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

