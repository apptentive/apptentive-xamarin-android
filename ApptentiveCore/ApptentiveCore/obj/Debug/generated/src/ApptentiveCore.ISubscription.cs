using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace ApptentiveCore {

	// Metadata.xml XPath interface reference: path="/api/package[@name='apptentive.com.android.core']/interface[@name='Subscription']"
	[Register ("apptentive/com/android/core/Subscription", "", "ApptentiveCore.ISubscriptionInvoker")]
	public partial interface ISubscription : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.core']/interface[@name='Subscription']/method[@name='unsubscribe' and count(parameter)=0]"
		[Register ("unsubscribe", "()V", "GetUnsubscribeHandler:ApptentiveCore.ISubscriptionInvoker, ApptentiveCore")]
		void Unsubscribe ();

	}

	[global::Android.Runtime.Register ("apptentive/com/android/core/Subscription", DoNotGenerateAcw=true)]
	internal partial class ISubscriptionInvoker : global::Java.Lang.Object, ISubscription {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/core/Subscription", typeof (ISubscriptionInvoker));

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

		public static ISubscription GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISubscription> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'apptentive.com.android.core.Subscription'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISubscriptionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_unsubscribe;
#pragma warning disable 0169
		static Delegate GetUnsubscribeHandler ()
		{
			if (cb_unsubscribe == null)
				cb_unsubscribe = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Unsubscribe));
			return cb_unsubscribe;
		}

		static void n_Unsubscribe (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::ApptentiveCore.ISubscription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Unsubscribe ();
		}
#pragma warning restore 0169

		IntPtr id_unsubscribe;
		public unsafe void Unsubscribe ()
		{
			if (id_unsubscribe == IntPtr.Zero)
				id_unsubscribe = JNIEnv.GetMethodID (class_ref, "unsubscribe", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unsubscribe);
		}

	}
}
