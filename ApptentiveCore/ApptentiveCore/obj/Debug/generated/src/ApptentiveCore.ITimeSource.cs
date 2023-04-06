using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace ApptentiveCore {

	// Metadata.xml XPath interface reference: path="/api/package[@name='apptentive.com.android.core']/interface[@name='TimeSource']"
	[Register ("apptentive/com/android/core/TimeSource", "", "ApptentiveCore.ITimeSourceInvoker")]
	public partial interface ITimeSource : IJavaObject, IJavaPeerable {
		double TimeSeconds {
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.core']/interface[@name='TimeSource']/method[@name='getTimeSeconds' and count(parameter)=0]"
			[Register ("getTimeSeconds", "()D", "GetGetTimeSecondsHandler:ApptentiveCore.ITimeSourceInvoker, ApptentiveCore")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("apptentive/com/android/core/TimeSource", DoNotGenerateAcw=true)]
	internal partial class ITimeSourceInvoker : global::Java.Lang.Object, ITimeSource {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/core/TimeSource", typeof (ITimeSourceInvoker));

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

		public static ITimeSource GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITimeSource> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'apptentive.com.android.core.TimeSource'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITimeSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getTimeSeconds;
#pragma warning disable 0169
		static Delegate GetGetTimeSecondsHandler ()
		{
			if (cb_getTimeSeconds == null)
				cb_getTimeSeconds = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_D (n_GetTimeSeconds));
			return cb_getTimeSeconds;
		}

		static double n_GetTimeSeconds (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::ApptentiveCore.ITimeSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeSeconds;
		}
#pragma warning restore 0169

		IntPtr id_getTimeSeconds;
		public unsafe double TimeSeconds {
			get {
				if (id_getTimeSeconds == IntPtr.Zero)
					id_getTimeSeconds = JNIEnv.GetMethodID (class_ref, "getTimeSeconds", "()D");
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getTimeSeconds);
			}
		}

	}
}
