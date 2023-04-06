using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Apptentive.Com.Android.Encryption {

	// Metadata.xml XPath interface reference: path="/api/package[@name='apptentive.com.android.encryption']/interface[@name='Encryption']"
	[Register ("apptentive/com/android/encryption/Encryption", "", "Apptentive.Com.Android.Encryption.IEncryptionInvoker")]
	public partial interface IEncryption : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.encryption']/interface[@name='Encryption']/method[@name='decrypt' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decrypt", "([B)[B", "GetDecrypt_arrayBHandler:Apptentive.Com.Android.Encryption.IEncryptionInvoker, ApptentiveCore")]
		byte[] Decrypt (byte[] data);

		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.encryption']/interface[@name='Encryption']/method[@name='decrypt' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("decrypt", "(Ljava/io/InputStream;)[B", "GetDecrypt_Ljava_io_InputStream_Handler:Apptentive.Com.Android.Encryption.IEncryptionInvoker, ApptentiveCore")]
		byte[] Decrypt (global::System.IO.Stream inputStream);

		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.encryption']/interface[@name='Encryption']/method[@name='encrypt' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encrypt", "([B)[B", "GetEncrypt_arrayBHandler:Apptentive.Com.Android.Encryption.IEncryptionInvoker, ApptentiveCore")]
		byte[] Encrypt (byte[] data);

	}

	[global::Android.Runtime.Register ("apptentive/com/android/encryption/Encryption", DoNotGenerateAcw=true)]
	internal partial class IEncryptionInvoker : global::Java.Lang.Object, IEncryption {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/encryption/Encryption", typeof (IEncryptionInvoker));

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

		public static IEncryption GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEncryption> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'apptentive.com.android.encryption.Encryption'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEncryptionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_decrypt_arrayB;
#pragma warning disable 0169
		static Delegate GetDecrypt_arrayBHandler ()
		{
			if (cb_decrypt_arrayB == null)
				cb_decrypt_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_Decrypt_arrayB));
			return cb_decrypt_arrayB;
		}

		static IntPtr n_Decrypt_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Encryption.IEncryption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Decrypt (data));
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_decrypt_arrayB;
		public unsafe byte[] Decrypt (byte[] data)
		{
			if (id_decrypt_arrayB == IntPtr.Zero)
				id_decrypt_arrayB = JNIEnv.GetMethodID (class_ref, "decrypt", "([B)[B");
			IntPtr native_data = JNIEnv.NewArray (data);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_data);
			var __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decrypt_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (data != null) {
				JNIEnv.CopyArray (native_data, data);
				JNIEnv.DeleteLocalRef (native_data);
			}
			return __ret;
		}

		static Delegate cb_decrypt_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetDecrypt_Ljava_io_InputStream_Handler ()
		{
			if (cb_decrypt_Ljava_io_InputStream_ == null)
				cb_decrypt_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_Decrypt_Ljava_io_InputStream_));
			return cb_decrypt_Ljava_io_InputStream_;
		}

		static IntPtr n_Decrypt_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inputStream)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Encryption.IEncryption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var inputStream = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_inputStream, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Decrypt (inputStream));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_decrypt_Ljava_io_InputStream_;
		public unsafe byte[] Decrypt (global::System.IO.Stream inputStream)
		{
			if (id_decrypt_Ljava_io_InputStream_ == IntPtr.Zero)
				id_decrypt_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "decrypt", "(Ljava/io/InputStream;)[B");
			IntPtr native_inputStream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (inputStream);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_inputStream);
			var __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decrypt_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_inputStream);
			return __ret;
		}

		static Delegate cb_encrypt_arrayB;
#pragma warning disable 0169
		static Delegate GetEncrypt_arrayBHandler ()
		{
			if (cb_encrypt_arrayB == null)
				cb_encrypt_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_Encrypt_arrayB));
			return cb_encrypt_arrayB;
		}

		static IntPtr n_Encrypt_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Encryption.IEncryption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Encrypt (data));
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_encrypt_arrayB;
		public unsafe byte[] Encrypt (byte[] data)
		{
			if (id_encrypt_arrayB == IntPtr.Zero)
				id_encrypt_arrayB = JNIEnv.GetMethodID (class_ref, "encrypt", "([B)[B");
			IntPtr native_data = JNIEnv.NewArray (data);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_data);
			var __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encrypt_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (data != null) {
				JNIEnv.CopyArray (native_data, data);
				JNIEnv.DeleteLocalRef (native_data);
			}
			return __ret;
		}

	}
}
