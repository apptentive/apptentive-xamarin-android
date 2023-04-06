using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "apptentive.com.android.feedback.rating.interaction", Managed="Apptentive.Com.Android.Feedback.Rating.Interaction")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.example.feedback", Managed="Com.Example.Feedback")]

#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Enum | AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

