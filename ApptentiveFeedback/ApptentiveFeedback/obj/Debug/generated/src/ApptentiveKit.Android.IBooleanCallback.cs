using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace ApptentiveKit.Android {

	// Metadata.xml XPath interface reference: path="/api/package[@name='apptentive.com.android.feedback']/interface[@name='BooleanCallback']"
	[Register ("apptentive/com/android/feedback/BooleanCallback", "", "ApptentiveKit.Android.IBooleanCallbackInvoker")]
	public partial interface IBooleanCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback']/interface[@name='BooleanCallback']/method[@name='onFinish' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("onFinish", "(Ljava/lang/Boolean;)V", "GetOnFinish_Ljava_lang_Boolean_Handler:ApptentiveKit.Android.IBooleanCallbackInvoker, ApptentiveFeedback")]
		void OnFinish (global::Java.Lang.Boolean p0);

	}

	[global::Android.Runtime.Register ("apptentive/com/android/feedback/BooleanCallback", DoNotGenerateAcw=true)]
	internal partial class IBooleanCallbackInvoker : global::Java.Lang.Object, IBooleanCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/feedback/BooleanCallback", typeof (IBooleanCallbackInvoker));

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

		public static IBooleanCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBooleanCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'apptentive.com.android.feedback.BooleanCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBooleanCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFinish_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetOnFinish_Ljava_lang_Boolean_Handler ()
		{
			if (cb_onFinish_Ljava_lang_Boolean_ == null)
				cb_onFinish_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnFinish_Ljava_lang_Boolean_));
			return cb_onFinish_Ljava_lang_Boolean_;
		}

		static void n_OnFinish_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::ApptentiveKit.Android.IBooleanCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFinish (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFinish_Ljava_lang_Boolean_;
		public unsafe void OnFinish (global::Java.Lang.Boolean p0)
		{
			if (id_onFinish_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_onFinish_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "onFinish", "(Ljava/lang/Boolean;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFinish_Ljava_lang_Boolean_, __args);
		}

	}
}
