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

namespace Apptentive.Com.Android.Encryption {

	// Metadata.xml XPath class reference: path="/api/package[@name='apptentive.com.android.encryption']/class[@name='EncryptionStatusKt']"
	[global::Android.Runtime.Register ("apptentive/com/android/encryption/EncryptionStatusKt", DoNotGenerateAcw=true)]
	public sealed partial class EncryptionStatusKt : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/encryption/EncryptionStatusKt", typeof (EncryptionStatusKt));

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

		internal EncryptionStatusKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.encryption']/class[@name='EncryptionStatusKt']/method[@name='getEncryptionStatus' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getEncryptionStatus", "(Z)Lapptentive/com/android/encryption/EncryptionStatus;", "")]
		public static unsafe global::Apptentive.Com.Android.Encryption.EncryptionStatus GetEncryptionStatus (bool obj)
		{
			const string __id = "getEncryptionStatus.(Z)Lapptentive/com/android/encryption/EncryptionStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (obj);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Encryption.EncryptionStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
