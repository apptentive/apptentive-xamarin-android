using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Apptentive.Com.Android.Encryption {

	// Metadata.xml XPath interface reference: path="/api/package[@name='apptentive.com.android.encryption']/interface[@name='KeyResolver']"
	[Register ("apptentive/com/android/encryption/KeyResolver", "", "Apptentive.Com.Android.Encryption.IKeyResolverInvoker")]
	public partial interface IKeyResolver : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.encryption']/interface[@name='KeyResolver']/method[@name='resolveKey' and count(parameter)=0]"
		[Register ("resolveKey", "()Lapptentive/com/android/encryption/EncryptionKey;", "GetResolveKeyHandler:Apptentive.Com.Android.Encryption.IKeyResolverInvoker, ApptentiveCore")]
		global::Apptentive.Com.Android.Encryption.EncryptionKey ResolveKey ();

	}

	[global::Android.Runtime.Register ("apptentive/com/android/encryption/KeyResolver", DoNotGenerateAcw=true)]
	internal partial class IKeyResolverInvoker : global::Java.Lang.Object, IKeyResolver {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/encryption/KeyResolver", typeof (IKeyResolverInvoker));

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

		public static IKeyResolver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IKeyResolver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'apptentive.com.android.encryption.KeyResolver'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IKeyResolverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_resolveKey;
#pragma warning disable 0169
		static Delegate GetResolveKeyHandler ()
		{
			if (cb_resolveKey == null)
				cb_resolveKey = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_ResolveKey));
			return cb_resolveKey;
		}

		static IntPtr n_ResolveKey (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Encryption.IKeyResolver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResolveKey ());
		}
#pragma warning restore 0169

		IntPtr id_resolveKey;
		public unsafe global::Apptentive.Com.Android.Encryption.EncryptionKey ResolveKey ()
		{
			if (id_resolveKey == IntPtr.Zero)
				id_resolveKey = JNIEnv.GetMethodID (class_ref, "resolveKey", "()Lapptentive/com/android/encryption/EncryptionKey;");
			return global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Encryption.EncryptionKey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_resolveKey), JniHandleOwnership.TransferLocalRef);
		}

	}
}
