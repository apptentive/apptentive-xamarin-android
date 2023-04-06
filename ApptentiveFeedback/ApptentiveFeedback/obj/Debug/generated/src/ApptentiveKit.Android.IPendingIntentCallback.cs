using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace ApptentiveKit.Android {

	// Metadata.xml XPath interface reference: path="/api/package[@name='apptentive.com.android.feedback']/interface[@name='PendingIntentCallback']"
	[Register ("apptentive/com/android/feedback/PendingIntentCallback", "", "ApptentiveKit.Android.IPendingIntentCallbackInvoker")]
	public partial interface IPendingIntentCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback']/interface[@name='PendingIntentCallback']/method[@name='onPendingIntent' and count(parameter)=1 and parameter[1][@type='android.app.PendingIntent']]"
		[Register ("onPendingIntent", "(Landroid/app/PendingIntent;)V", "GetOnPendingIntent_Landroid_app_PendingIntent_Handler:ApptentiveKit.Android.IPendingIntentCallbackInvoker, ApptentiveFeedback")]
		void OnPendingIntent (global::Android.App.PendingIntent p0);

	}

	[global::Android.Runtime.Register ("apptentive/com/android/feedback/PendingIntentCallback", DoNotGenerateAcw=true)]
	internal partial class IPendingIntentCallbackInvoker : global::Java.Lang.Object, IPendingIntentCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/feedback/PendingIntentCallback", typeof (IPendingIntentCallbackInvoker));

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

		public static IPendingIntentCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPendingIntentCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'apptentive.com.android.feedback.PendingIntentCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPendingIntentCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onPendingIntent_Landroid_app_PendingIntent_;
#pragma warning disable 0169
		static Delegate GetOnPendingIntent_Landroid_app_PendingIntent_Handler ()
		{
			if (cb_onPendingIntent_Landroid_app_PendingIntent_ == null)
				cb_onPendingIntent_Landroid_app_PendingIntent_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnPendingIntent_Landroid_app_PendingIntent_));
			return cb_onPendingIntent_Landroid_app_PendingIntent_;
		}

		static void n_OnPendingIntent_Landroid_app_PendingIntent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::ApptentiveKit.Android.IPendingIntentCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPendingIntent (p0);
		}
#pragma warning restore 0169

		IntPtr id_onPendingIntent_Landroid_app_PendingIntent_;
		public unsafe void OnPendingIntent (global::Android.App.PendingIntent p0)
		{
			if (id_onPendingIntent_Landroid_app_PendingIntent_ == IntPtr.Zero)
				id_onPendingIntent_Landroid_app_PendingIntent_ = JNIEnv.GetMethodID (class_ref, "onPendingIntent", "(Landroid/app/PendingIntent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPendingIntent_Landroid_app_PendingIntent_, __args);
		}

	}
}
