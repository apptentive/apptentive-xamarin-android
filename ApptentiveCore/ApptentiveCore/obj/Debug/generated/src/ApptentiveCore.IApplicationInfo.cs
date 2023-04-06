using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace ApptentiveCore {

	// Metadata.xml XPath interface reference: path="/api/package[@name='apptentive.com.android.core']/interface[@name='ApplicationInfo']"
	[Register ("apptentive/com/android/core/ApplicationInfo", "", "ApptentiveCore.IApplicationInfoInvoker")]
	public partial interface IApplicationInfo : IJavaObject, IJavaPeerable {
		int VersionCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.core']/interface[@name='ApplicationInfo']/method[@name='getVersionCode' and count(parameter)=0]"
			[Register ("getVersionCode", "()I", "GetGetVersionCodeHandler:ApptentiveCore.IApplicationInfoInvoker, ApptentiveCore")]
			get; 
		}

		string VersionName {
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.core']/interface[@name='ApplicationInfo']/method[@name='getVersionName' and count(parameter)=0]"
			[Register ("getVersionName", "()Ljava/lang/String;", "GetGetVersionNameHandler:ApptentiveCore.IApplicationInfoInvoker, ApptentiveCore")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("apptentive/com/android/core/ApplicationInfo", DoNotGenerateAcw=true)]
	internal partial class IApplicationInfoInvoker : global::Java.Lang.Object, IApplicationInfo {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/core/ApplicationInfo", typeof (IApplicationInfoInvoker));

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

		public static IApplicationInfo GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApplicationInfo> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'apptentive.com.android.core.ApplicationInfo'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApplicationInfoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getVersionCode;
#pragma warning disable 0169
		static Delegate GetGetVersionCodeHandler ()
		{
			if (cb_getVersionCode == null)
				cb_getVersionCode = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetVersionCode));
			return cb_getVersionCode;
		}

		static int n_GetVersionCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::ApptentiveCore.IApplicationInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VersionCode;
		}
#pragma warning restore 0169

		IntPtr id_getVersionCode;
		public unsafe int VersionCode {
			get {
				if (id_getVersionCode == IntPtr.Zero)
					id_getVersionCode = JNIEnv.GetMethodID (class_ref, "getVersionCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVersionCode);
			}
		}

		static Delegate cb_getVersionName;
#pragma warning disable 0169
		static Delegate GetGetVersionNameHandler ()
		{
			if (cb_getVersionName == null)
				cb_getVersionName = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetVersionName));
			return cb_getVersionName;
		}

		static IntPtr n_GetVersionName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::ApptentiveCore.IApplicationInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VersionName);
		}
#pragma warning restore 0169

		IntPtr id_getVersionName;
		public unsafe string VersionName {
			get {
				if (id_getVersionName == IntPtr.Zero)
					id_getVersionName = JNIEnv.GetMethodID (class_ref, "getVersionName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVersionName), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
