using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "apptentive.com.android.feedback.dependencyprovider", Managed="Apptentive.Com.Android.Feedback.Dependencyprovider")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "apptentive.com.android.feedback.messagecenter", Managed="Apptentive.Com.Android.Feedback.Messagecenter")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "apptentive.com.android.feedback.messagecenter.utils", Managed="Apptentive.Com.Android.Feedback.Messagecenter.Utils")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "apptentive.com.android.feedback.messagecenter.view", Managed="Apptentive.Com.Android.Feedback.Messagecenter.View")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "apptentive.com.android.feedback.messagecenter.viewmodel", Managed="Apptentive.Com.Android.Feedback.Messagecenter.Viewmodel")]

#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Enum | AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

