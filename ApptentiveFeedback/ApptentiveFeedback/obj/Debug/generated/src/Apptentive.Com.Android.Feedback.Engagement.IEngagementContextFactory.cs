using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Apptentive.Com.Android.Feedback.Engagement {

	// Metadata.xml XPath interface reference: path="/api/package[@name='apptentive.com.android.feedback.engagement']/interface[@name='EngagementContextFactory']"
	[Register ("apptentive/com/android/feedback/engagement/EngagementContextFactory", "", "Apptentive.Com.Android.Feedback.Engagement.IEngagementContextFactoryInvoker")]
	public partial interface IEngagementContextFactory : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback.engagement']/interface[@name='EngagementContextFactory']/method[@name='engagementContext' and count(parameter)=0]"
		[Register ("engagementContext", "()Lapptentive/com/android/feedback/engagement/EngagementContext;", "GetEngagementContextHandler:Apptentive.Com.Android.Feedback.Engagement.IEngagementContextFactoryInvoker, ApptentiveFeedback")]
		global::Apptentive.Com.Android.Feedback.Engagement.EngagementContext EngagementContext ();

	}

	[global::Android.Runtime.Register ("apptentive/com/android/feedback/engagement/EngagementContextFactory", DoNotGenerateAcw=true)]
	internal partial class IEngagementContextFactoryInvoker : global::Java.Lang.Object, IEngagementContextFactory {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/feedback/engagement/EngagementContextFactory", typeof (IEngagementContextFactoryInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IEngagementContextFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEngagementContextFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'apptentive.com.android.feedback.engagement.EngagementContextFactory'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEngagementContextFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_engagementContext;
#pragma warning disable 0169
		static Delegate GetEngagementContextHandler ()
		{
			if (cb_engagementContext == null)
				cb_engagementContext = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_EngagementContext));
			return cb_engagementContext;
		}

		static IntPtr n_EngagementContext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Feedback.Engagement.IEngagementContextFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EngagementContext ());
		}
#pragma warning restore 0169

		IntPtr id_engagementContext;
		public unsafe global::Apptentive.Com.Android.Feedback.Engagement.EngagementContext EngagementContext ()
		{
			if (id_engagementContext == IntPtr.Zero)
				id_engagementContext = JNIEnv.GetMethodID (class_ref, "engagementContext", "()Lapptentive/com/android/feedback/engagement/EngagementContext;");
			return global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Feedback.Engagement.EngagementContext> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_engagementContext), JniHandleOwnership.TransferLocalRef);
		}

	}
}
