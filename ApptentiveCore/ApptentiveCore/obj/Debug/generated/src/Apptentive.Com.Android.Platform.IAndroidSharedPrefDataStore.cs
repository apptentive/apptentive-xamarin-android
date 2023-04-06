using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Apptentive.Com.Android.Platform {

	// Metadata.xml XPath class reference: path="/api/package[@name='apptentive.com.android.platform']/class[@name='AndroidSharedPrefDataStore.DefaultImpls']"
	[global::Android.Runtime.Register ("apptentive/com/android/platform/AndroidSharedPrefDataStore$DefaultImpls", DoNotGenerateAcw=true)]
	public sealed partial class AndroidSharedPrefDataStoreDefaultImpls : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/platform/AndroidSharedPrefDataStore$DefaultImpls", typeof (AndroidSharedPrefDataStoreDefaultImpls));

		internal static IntPtr class_ref {
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
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal AndroidSharedPrefDataStoreDefaultImpls (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='apptentive.com.android.platform']/interface[@name='AndroidSharedPrefDataStore']"
	[Register ("apptentive/com/android/platform/AndroidSharedPrefDataStore", "", "Apptentive.Com.Android.Platform.IAndroidSharedPrefDataStoreInvoker")]
	public partial interface IAndroidSharedPrefDataStore : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.platform']/interface[@name='AndroidSharedPrefDataStore']/method[@name='containsKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("containsKey", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetContainsKey_Ljava_lang_String_Ljava_lang_String_Handler:Apptentive.Com.Android.Platform.IAndroidSharedPrefDataStoreInvoker, ApptentiveCore")]
		bool ContainsKey (string file, string keyEntry);

		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.platform']/interface[@name='AndroidSharedPrefDataStore']/method[@name='getBoolean' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("getBoolean", "(Ljava/lang/String;Ljava/lang/String;Z)Z", "GetGetBoolean_Ljava_lang_String_Ljava_lang_String_ZHandler:Apptentive.Com.Android.Platform.IAndroidSharedPrefDataStoreInvoker, ApptentiveCore")]
		bool GetBoolean (string file, string keyEntry, bool defaultValue);

		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.platform']/interface[@name='AndroidSharedPrefDataStore']/method[@name='getSharedPrefForSDK' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSharedPrefForSDK", "(Ljava/lang/String;)Landroid/content/SharedPreferences;", "GetGetSharedPrefForSDK_Ljava_lang_String_Handler:Apptentive.Com.Android.Platform.IAndroidSharedPrefDataStoreInvoker, ApptentiveCore")]
		global::Android.Content.ISharedPreferences GetSharedPrefForSDK (string file);

		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.platform']/interface[@name='AndroidSharedPrefDataStore']/method[@name='getString' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Apptentive.Com.Android.Platform.IAndroidSharedPrefDataStoreInvoker, ApptentiveCore")]
		string GetString (string file, string keyEntry, string defaultValue);

		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.platform']/interface[@name='AndroidSharedPrefDataStore']/method[@name='putBoolean' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("putBoolean", "(Ljava/lang/String;Ljava/lang/String;Z)V", "GetPutBoolean_Ljava_lang_String_Ljava_lang_String_ZHandler:Apptentive.Com.Android.Platform.IAndroidSharedPrefDataStoreInvoker, ApptentiveCore")]
		void PutBoolean (string file, string keyEntry, bool value);

		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.platform']/interface[@name='AndroidSharedPrefDataStore']/method[@name='putString' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("putString", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetPutString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Apptentive.Com.Android.Platform.IAndroidSharedPrefDataStoreInvoker, ApptentiveCore")]
		void PutString (string file, string keyEntry, string value);

	}

	[global::Android.Runtime.Register ("apptentive/com/android/platform/AndroidSharedPrefDataStore", DoNotGenerateAcw=true)]
	internal partial class IAndroidSharedPrefDataStoreInvoker : global::Java.Lang.Object, IAndroidSharedPrefDataStore {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/platform/AndroidSharedPrefDataStore", typeof (IAndroidSharedPrefDataStoreInvoker));

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

		public static IAndroidSharedPrefDataStore GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAndroidSharedPrefDataStore> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'apptentive.com.android.platform.AndroidSharedPrefDataStore'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAndroidSharedPrefDataStoreInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_containsKey_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetContainsKey_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_containsKey_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_containsKey_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_Z (n_ContainsKey_Ljava_lang_String_Ljava_lang_String_));
			return cb_containsKey_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_ContainsKey_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_file, IntPtr native_keyEntry)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Platform.IAndroidSharedPrefDataStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var file = JNIEnv.GetString (native_file, JniHandleOwnership.DoNotTransfer);
			var keyEntry = JNIEnv.GetString (native_keyEntry, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsKey (file, keyEntry);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_containsKey_Ljava_lang_String_Ljava_lang_String_;
		public unsafe bool ContainsKey (string file, string keyEntry)
		{
			if (id_containsKey_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_containsKey_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "containsKey", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_file = JNIEnv.NewString ((string)file);
			IntPtr native_keyEntry = JNIEnv.NewString ((string)keyEntry);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_file);
			__args [1] = new JValue (native_keyEntry);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_containsKey_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_file);
			JNIEnv.DeleteLocalRef (native_keyEntry);
			return __ret;
		}

		static Delegate cb_getBoolean_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGetBoolean_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_getBoolean_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_getBoolean_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLZ_Z (n_GetBoolean_Ljava_lang_String_Ljava_lang_String_Z));
			return cb_getBoolean_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static bool n_GetBoolean_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_file, IntPtr native_keyEntry, bool defaultValue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Platform.IAndroidSharedPrefDataStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var file = JNIEnv.GetString (native_file, JniHandleOwnership.DoNotTransfer);
			var keyEntry = JNIEnv.GetString (native_keyEntry, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetBoolean (file, keyEntry, defaultValue);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getBoolean_Ljava_lang_String_Ljava_lang_String_Z;
		public unsafe bool GetBoolean (string file, string keyEntry, bool defaultValue)
		{
			if (id_getBoolean_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_getBoolean_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "getBoolean", "(Ljava/lang/String;Ljava/lang/String;Z)Z");
			IntPtr native_file = JNIEnv.NewString ((string)file);
			IntPtr native_keyEntry = JNIEnv.NewString ((string)keyEntry);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_file);
			__args [1] = new JValue (native_keyEntry);
			__args [2] = new JValue (defaultValue);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getBoolean_Ljava_lang_String_Ljava_lang_String_Z, __args);
			JNIEnv.DeleteLocalRef (native_file);
			JNIEnv.DeleteLocalRef (native_keyEntry);
			return __ret;
		}

		static Delegate cb_getSharedPrefForSDK_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSharedPrefForSDK_Ljava_lang_String_Handler ()
		{
			if (cb_getSharedPrefForSDK_Ljava_lang_String_ == null)
				cb_getSharedPrefForSDK_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_GetSharedPrefForSDK_Ljava_lang_String_));
			return cb_getSharedPrefForSDK_Ljava_lang_String_;
		}

		static IntPtr n_GetSharedPrefForSDK_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_file)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Platform.IAndroidSharedPrefDataStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var file = JNIEnv.GetString (native_file, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSharedPrefForSDK (file));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getSharedPrefForSDK_Ljava_lang_String_;
		public unsafe global::Android.Content.ISharedPreferences GetSharedPrefForSDK (string file)
		{
			if (id_getSharedPrefForSDK_Ljava_lang_String_ == IntPtr.Zero)
				id_getSharedPrefForSDK_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getSharedPrefForSDK", "(Ljava/lang/String;)Landroid/content/SharedPreferences;");
			IntPtr native_file = JNIEnv.NewString ((string)file);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_file);
			var __ret = global::Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferences> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSharedPrefForSDK_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_file);
			return __ret;
		}

		static Delegate cb_getString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_L (n_GetString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_));
			return cb_getString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_file, IntPtr native_keyEntry, IntPtr native_defaultValue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Platform.IAndroidSharedPrefDataStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var file = JNIEnv.GetString (native_file, JniHandleOwnership.DoNotTransfer);
			var keyEntry = JNIEnv.GetString (native_keyEntry, JniHandleOwnership.DoNotTransfer);
			var defaultValue = JNIEnv.GetString (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (file, keyEntry, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe string GetString (string file, string keyEntry, string defaultValue)
		{
			if (id_getString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getString", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_file = JNIEnv.NewString ((string)file);
			IntPtr native_keyEntry = JNIEnv.NewString ((string)keyEntry);
			IntPtr native_defaultValue = JNIEnv.NewString ((string)defaultValue);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_file);
			__args [1] = new JValue (native_keyEntry);
			__args [2] = new JValue (native_defaultValue);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_file);
			JNIEnv.DeleteLocalRef (native_keyEntry);
			JNIEnv.DeleteLocalRef (native_defaultValue);
			return __ret;
		}

		static Delegate cb_putBoolean_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetPutBoolean_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_putBoolean_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_putBoolean_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLZ_V (n_PutBoolean_Ljava_lang_String_Ljava_lang_String_Z));
			return cb_putBoolean_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static void n_PutBoolean_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_file, IntPtr native_keyEntry, bool value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Platform.IAndroidSharedPrefDataStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var file = JNIEnv.GetString (native_file, JniHandleOwnership.DoNotTransfer);
			var keyEntry = JNIEnv.GetString (native_keyEntry, JniHandleOwnership.DoNotTransfer);
			__this.PutBoolean (file, keyEntry, value);
		}
#pragma warning restore 0169

		IntPtr id_putBoolean_Ljava_lang_String_Ljava_lang_String_Z;
		public unsafe void PutBoolean (string file, string keyEntry, bool value)
		{
			if (id_putBoolean_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_putBoolean_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "putBoolean", "(Ljava/lang/String;Ljava/lang/String;Z)V");
			IntPtr native_file = JNIEnv.NewString ((string)file);
			IntPtr native_keyEntry = JNIEnv.NewString ((string)keyEntry);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_file);
			__args [1] = new JValue (native_keyEntry);
			__args [2] = new JValue (value);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putBoolean_Ljava_lang_String_Ljava_lang_String_Z, __args);
			JNIEnv.DeleteLocalRef (native_file);
			JNIEnv.DeleteLocalRef (native_keyEntry);
		}

		static Delegate cb_putString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_putString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_putString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_PutString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_));
			return cb_putString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_PutString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_file, IntPtr native_keyEntry, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Platform.IAndroidSharedPrefDataStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var file = JNIEnv.GetString (native_file, JniHandleOwnership.DoNotTransfer);
			var keyEntry = JNIEnv.GetString (native_keyEntry, JniHandleOwnership.DoNotTransfer);
			var value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.PutString (file, keyEntry, value);
		}
#pragma warning restore 0169

		IntPtr id_putString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void PutString (string file, string keyEntry, string value)
		{
			if (id_putString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_putString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "putString", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_file = JNIEnv.NewString ((string)file);
			IntPtr native_keyEntry = JNIEnv.NewString ((string)keyEntry);
			IntPtr native_value = JNIEnv.NewString ((string)value);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_file);
			__args [1] = new JValue (native_keyEntry);
			__args [2] = new JValue (native_value);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_file);
			JNIEnv.DeleteLocalRef (native_keyEntry);
			JNIEnv.DeleteLocalRef (native_value);
		}

	}
}
