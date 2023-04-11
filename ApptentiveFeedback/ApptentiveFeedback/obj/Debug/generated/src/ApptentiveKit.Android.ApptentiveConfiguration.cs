//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace ApptentiveKit.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='apptentive.com.android.feedback']/class[@name='ApptentiveConfiguration']"
	[global::Android.Runtime.Register ("apptentive/com/android/feedback/ApptentiveConfiguration", DoNotGenerateAcw=true)]
	public sealed partial class ApptentiveConfiguration : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/feedback/ApptentiveConfiguration", typeof (ApptentiveConfiguration));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal ApptentiveConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='apptentive.com.android.feedback']/class[@name='ApptentiveConfiguration']/constructor[@name='ApptentiveConfiguration' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe ApptentiveConfiguration (string apptentiveKey, string apptentiveSignature) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_apptentiveKey = JNIEnv.NewString ((string)apptentiveKey);
			IntPtr native_apptentiveSignature = JNIEnv.NewString ((string)apptentiveSignature);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_apptentiveKey);
				__args [1] = new JniArgumentValue (native_apptentiveSignature);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_apptentiveKey);
				JNIEnv.DeleteLocalRef (native_apptentiveSignature);
			}
		}

		public unsafe string ApptentiveKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback']/class[@name='ApptentiveConfiguration']/method[@name='getApptentiveKey' and count(parameter)=0]"
			[Register ("getApptentiveKey", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getApptentiveKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string ApptentiveSignature {
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback']/class[@name='ApptentiveConfiguration']/method[@name='getApptentiveSignature' and count(parameter)=0]"
			[Register ("getApptentiveSignature", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getApptentiveSignature.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string CustomAppStoreURL {
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback']/class[@name='ApptentiveConfiguration']/method[@name='getCustomAppStoreURL' and count(parameter)=0]"
			[Register ("getCustomAppStoreURL", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getCustomAppStoreURL.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback']/class[@name='ApptentiveConfiguration']/method[@name='setCustomAppStoreURL' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCustomAppStoreURL", "(Ljava/lang/String;)V", "")]
			set {
				const string __id = "setCustomAppStoreURL.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe string DistributionName {
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback']/class[@name='ApptentiveConfiguration']/method[@name='getDistributionName' and count(parameter)=0]"
			[Register ("getDistributionName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getDistributionName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback']/class[@name='ApptentiveConfiguration']/method[@name='setDistributionName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDistributionName", "(Ljava/lang/String;)V", "")]
			set {
				const string __id = "setDistributionName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe string DistributionVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback']/class[@name='ApptentiveConfiguration']/method[@name='getDistributionVersion' and count(parameter)=0]"
			[Register ("getDistributionVersion", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getDistributionVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback']/class[@name='ApptentiveConfiguration']/method[@name='setDistributionVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDistributionVersion", "(Ljava/lang/String;)V", "")]
			set {
				const string __id = "setDistributionVersion.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe global::Apptentive.Com.Android.Util.LogLevel LogLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback']/class[@name='ApptentiveConfiguration']/method[@name='getLogLevel' and count(parameter)=0]"
			[Register ("getLogLevel", "()Lapptentive/com/android/util/LogLevel;", "")]
			get {
				const string __id = "getLogLevel.()Lapptentive/com/android/util/LogLevel;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Util.LogLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback']/class[@name='ApptentiveConfiguration']/method[@name='setLogLevel' and count(parameter)=1 and parameter[1][@type='apptentive.com.android.util.LogLevel']]"
			[Register ("setLogLevel", "(Lapptentive/com/android/util/LogLevel;)V", "")]
			set {
				const string __id = "setLogLevel.(Lapptentive/com/android/util/LogLevel;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe long RatingInteractionThrottleLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback']/class[@name='ApptentiveConfiguration']/method[@name='getRatingInteractionThrottleLength' and count(parameter)=0]"
			[Register ("getRatingInteractionThrottleLength", "()J", "")]
			get {
				const string __id = "getRatingInteractionThrottleLength.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback']/class[@name='ApptentiveConfiguration']/method[@name='setRatingInteractionThrottleLength' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setRatingInteractionThrottleLength", "(J)V", "")]
			set {
				const string __id = "setRatingInteractionThrottleLength.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool ShouldEncryptStorage {
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback']/class[@name='ApptentiveConfiguration']/method[@name='getShouldEncryptStorage' and count(parameter)=0]"
			[Register ("getShouldEncryptStorage", "()Z", "")]
			get {
				const string __id = "getShouldEncryptStorage.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback']/class[@name='ApptentiveConfiguration']/method[@name='setShouldEncryptStorage' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShouldEncryptStorage", "(Z)V", "")]
			set {
				const string __id = "setShouldEncryptStorage.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool ShouldInheritAppTheme {
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback']/class[@name='ApptentiveConfiguration']/method[@name='getShouldInheritAppTheme' and count(parameter)=0]"
			[Register ("getShouldInheritAppTheme", "()Z", "")]
			get {
				const string __id = "getShouldInheritAppTheme.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback']/class[@name='ApptentiveConfiguration']/method[@name='setShouldInheritAppTheme' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShouldInheritAppTheme", "(Z)V", "")]
			set {
				const string __id = "setShouldInheritAppTheme.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool ShouldSanitizeLogMessages {
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback']/class[@name='ApptentiveConfiguration']/method[@name='getShouldSanitizeLogMessages' and count(parameter)=0]"
			[Register ("getShouldSanitizeLogMessages", "()Z", "")]
			get {
				const string __id = "getShouldSanitizeLogMessages.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback']/class[@name='ApptentiveConfiguration']/method[@name='setShouldSanitizeLogMessages' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShouldSanitizeLogMessages", "(Z)V", "")]
			set {
				const string __id = "setShouldSanitizeLogMessages.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback']/class[@name='ApptentiveConfiguration']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()Ljava/lang/String;", "")]
		public unsafe string Component1 ()
		{
			const string __id = "component1.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback']/class[@name='ApptentiveConfiguration']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()Ljava/lang/String;", "")]
		public unsafe string Component2 ()
		{
			const string __id = "component2.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback']/class[@name='ApptentiveConfiguration']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;)Lapptentive/com/android/feedback/ApptentiveConfiguration;", "")]
		public unsafe global::ApptentiveKit.Android.ApptentiveConfiguration Copy (string apptentiveKey, string apptentiveSignature)
		{
			const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;)Lapptentive/com/android/feedback/ApptentiveConfiguration;";
			IntPtr native_apptentiveKey = JNIEnv.NewString ((string)apptentiveKey);
			IntPtr native_apptentiveSignature = JNIEnv.NewString ((string)apptentiveSignature);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_apptentiveKey);
				__args [1] = new JniArgumentValue (native_apptentiveSignature);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::ApptentiveKit.Android.ApptentiveConfiguration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_apptentiveKey);
				JNIEnv.DeleteLocalRef (native_apptentiveSignature);
			}
		}

	}
}