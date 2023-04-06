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

namespace Apptentive.Com.Android.Feedback.Engagement.Interactions {

	// Metadata.xml XPath class reference: path="/api/package[@name='apptentive.com.android.feedback.engagement.interactions']/class[@name='InteractionResponseData']"
	[global::Android.Runtime.Register ("apptentive/com/android/feedback/engagement/interactions/InteractionResponseData", DoNotGenerateAcw=true)]
	public sealed partial class InteractionResponseData : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/feedback/engagement/interactions/InteractionResponseData", typeof (InteractionResponseData));

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

		internal InteractionResponseData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='apptentive.com.android.feedback.engagement.interactions']/class[@name='InteractionResponseData']/constructor[@name='InteractionResponseData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InteractionResponseData () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		public unsafe global::System.Collections.Generic.ICollection<global::Apptentive.Com.Android.Feedback.Engagement.Interactions.InteractionResponse> Responses {
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback.engagement.interactions']/class[@name='InteractionResponseData']/method[@name='getResponses' and count(parameter)=0]"
			[Register ("getResponses", "()Ljava/util/Set;", "")]
			get {
				const string __id = "getResponses.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<global::Apptentive.Com.Android.Feedback.Engagement.Interactions.InteractionResponse>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback.engagement.interactions']/class[@name='InteractionResponseData']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()Ljava/util/Set;", "")]
		public unsafe global::System.Collections.Generic.ICollection<global::Apptentive.Com.Android.Feedback.Engagement.Interactions.InteractionResponse> Component1 ()
		{
			const string __id = "component1.()Ljava/util/Set;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaSet<global::Apptentive.Com.Android.Feedback.Engagement.Interactions.InteractionResponse>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback.engagement.interactions']/class[@name='InteractionResponseData']/method[@name='invokesForVersionCode' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("invokesForVersionCode", "(J)J", "")]
		public unsafe long InvokesForVersionCode (long versionCode)
		{
			const string __id = "invokesForVersionCode.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (versionCode);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback.engagement.interactions']/class[@name='InteractionResponseData']/method[@name='invokesForVersionName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("invokesForVersionName", "(Ljava/lang/String;)J", "")]
		public unsafe long InvokesForVersionName (string versionName)
		{
			const string __id = "invokesForVersionName.(Ljava/lang/String;)J";
			IntPtr native_versionName = JNIEnv.NewString ((string)versionName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_versionName);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_versionName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback.engagement.interactions']/class[@name='InteractionResponseData']/method[@name='totalInvokes' and count(parameter)=0]"
		[Register ("totalInvokes", "()J", "")]
		public unsafe long TotalInvokes ()
		{
			const string __id = "totalInvokes.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
