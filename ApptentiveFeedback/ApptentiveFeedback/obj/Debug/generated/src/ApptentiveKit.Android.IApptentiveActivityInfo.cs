using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace ApptentiveKit.Android {

	// Metadata.xml XPath interface reference: path="/api/package[@name='apptentive.com.android.feedback']/interface[@name='ApptentiveActivityInfo']"
	[Register ("apptentive/com/android/feedback/ApptentiveActivityInfo", "", "ApptentiveKit.Android.IApptentiveActivityInfoInvoker")]
	public partial interface IApptentiveActivityInfo : IJavaObject, IJavaPeerable {
		global::Android.App.Activity ApptentiveActivityInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback']/interface[@name='ApptentiveActivityInfo']/method[@name='getApptentiveActivityInfo' and count(parameter)=0]"
			[Register ("getApptentiveActivityInfo", "()Landroid/app/Activity;", "GetGetApptentiveActivityInfoHandler:ApptentiveKit.Android.IApptentiveActivityInfoInvoker, ApptentiveFeedback")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("apptentive/com/android/feedback/ApptentiveActivityInfo", DoNotGenerateAcw=true)]
	internal partial class IApptentiveActivityInfoInvoker : global::Java.Lang.Object, IApptentiveActivityInfo {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/feedback/ApptentiveActivityInfo", typeof (IApptentiveActivityInfoInvoker));

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

		public static IApptentiveActivityInfo GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApptentiveActivityInfo> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'apptentive.com.android.feedback.ApptentiveActivityInfo'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApptentiveActivityInfoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getApptentiveActivityInfo;
#pragma warning disable 0169
		static Delegate GetGetApptentiveActivityInfoHandler ()
		{
			if (cb_getApptentiveActivityInfo == null)
				cb_getApptentiveActivityInfo = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetApptentiveActivityInfo));
			return cb_getApptentiveActivityInfo;
		}

		static IntPtr n_GetApptentiveActivityInfo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::ApptentiveKit.Android.IApptentiveActivityInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ApptentiveActivityInfo);
		}
#pragma warning restore 0169

		IntPtr id_getApptentiveActivityInfo;
		public unsafe global::Android.App.Activity ApptentiveActivityInfo {
			get {
				if (id_getApptentiveActivityInfo == IntPtr.Zero)
					id_getApptentiveActivityInfo = JNIEnv.GetMethodID (class_ref, "getApptentiveActivityInfo", "()Landroid/app/Activity;");
				return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApptentiveActivityInfo), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
