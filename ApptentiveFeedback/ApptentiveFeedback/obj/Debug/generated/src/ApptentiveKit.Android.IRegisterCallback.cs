using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace ApptentiveKit.Android {

	// Metadata.xml XPath interface reference: path="/api/package[@name='apptentive.com.android.feedback']/interface[@name='RegisterCallback']"
	[Register ("apptentive/com/android/feedback/RegisterCallback", "", "ApptentiveKit.Android.IRegisterCallbackInvoker")]
	public partial interface IRegisterCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback']/interface[@name='RegisterCallback']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='apptentive.com.android.feedback.RegisterResult']]"
		[Register ("onComplete", "(Lapptentive/com/android/feedback/RegisterResult;)V", "GetOnComplete_Lapptentive_com_android_feedback_RegisterResult_Handler:ApptentiveKit.Android.IRegisterCallbackInvoker, ApptentiveFeedback")]
		void OnComplete (global::ApptentiveKit.Android.RegisterResult p0);

	}

	[global::Android.Runtime.Register ("apptentive/com/android/feedback/RegisterCallback", DoNotGenerateAcw=true)]
	internal partial class IRegisterCallbackInvoker : global::Java.Lang.Object, IRegisterCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/feedback/RegisterCallback", typeof (IRegisterCallbackInvoker));

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

		public static IRegisterCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRegisterCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'apptentive.com.android.feedback.RegisterCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRegisterCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onComplete_Lapptentive_com_android_feedback_RegisterResult_;
#pragma warning disable 0169
		static Delegate GetOnComplete_Lapptentive_com_android_feedback_RegisterResult_Handler ()
		{
			if (cb_onComplete_Lapptentive_com_android_feedback_RegisterResult_ == null)
				cb_onComplete_Lapptentive_com_android_feedback_RegisterResult_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnComplete_Lapptentive_com_android_feedback_RegisterResult_));
			return cb_onComplete_Lapptentive_com_android_feedback_RegisterResult_;
		}

		static void n_OnComplete_Lapptentive_com_android_feedback_RegisterResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::ApptentiveKit.Android.IRegisterCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::ApptentiveKit.Android.RegisterResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete (p0);
		}
#pragma warning restore 0169

		IntPtr id_onComplete_Lapptentive_com_android_feedback_RegisterResult_;
		public unsafe void OnComplete (global::ApptentiveKit.Android.RegisterResult p0)
		{
			if (id_onComplete_Lapptentive_com_android_feedback_RegisterResult_ == IntPtr.Zero)
				id_onComplete_Lapptentive_com_android_feedback_RegisterResult_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Lapptentive/com/android/feedback/RegisterResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete_Lapptentive_com_android_feedback_RegisterResult_, __args);
		}

	}
}
