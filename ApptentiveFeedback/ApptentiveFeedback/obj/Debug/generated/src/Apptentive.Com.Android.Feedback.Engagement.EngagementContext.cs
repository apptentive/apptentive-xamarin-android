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

namespace Apptentive.Com.Android.Feedback.Engagement {

	// Metadata.xml XPath class reference: path="/api/package[@name='apptentive.com.android.feedback.engagement']/class[@name='EngagementContext']"
	[global::Android.Runtime.Register ("apptentive/com/android/feedback/engagement/EngagementContext", DoNotGenerateAcw=true)]
	public partial class EngagementContext : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/feedback/engagement/EngagementContext", typeof (EngagementContext));

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

		protected EngagementContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::Android.App.Activity AppActivity {
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback.engagement']/class[@name='EngagementContext']/method[@name='getAppActivity' and count(parameter)=0]"
			[Register ("getAppActivity", "()Landroid/app/Activity;", "")]
			get {
				const string __id = "getAppActivity.()Landroid/app/Activity;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Apptentive.Com.Android.Concurrent.Executors Executors {
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback.engagement']/class[@name='EngagementContext']/method[@name='getExecutors' and count(parameter)=0]"
			[Register ("getExecutors", "()Lapptentive/com/android/concurrent/Executors;", "")]
			get {
				const string __id = "getExecutors.()Lapptentive/com/android/concurrent/Executors;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Concurrent.Executors> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
