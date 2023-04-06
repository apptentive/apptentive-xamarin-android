using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "apptentive.com.android.feedback", Managed="ApptentiveKit.Android")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "apptentive.com.android.feedback.engagement.interactions", Managed="Apptentive.Com.Android.Feedback.Engagement.Interactions")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.apptentive.android.sdk", Managed="Com.Apptentive.Android.Sdk")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.apptentive.android.sdk.encryption.resolvers", Managed="Com.Apptentive.Android.Sdk.Encryption.Resolvers")]

delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Enum | AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

