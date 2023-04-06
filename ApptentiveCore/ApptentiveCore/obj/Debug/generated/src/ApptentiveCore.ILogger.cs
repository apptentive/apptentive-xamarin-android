using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace ApptentiveCore {

	// Metadata.xml XPath interface reference: path="/api/package[@name='apptentive.com.android.core']/interface[@name='Logger']"
	[Register ("apptentive/com/android/core/Logger", "", "ApptentiveCore.ILoggerInvoker")]
	public partial interface ILogger : IJavaObject, IJavaPeerable {
		bool IsMainQueue {
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.core']/interface[@name='Logger']/method[@name='isMainQueue' and count(parameter)=0]"
			[Register ("isMainQueue", "()Z", "GetIsMainQueueHandler:ApptentiveCore.ILoggerInvoker, ApptentiveCore")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.core']/interface[@name='Logger']/method[@name='log' and count(parameter)=2 and parameter[1][@type='apptentive.com.android.util.LogLevel'] and parameter[2][@type='java.lang.String']]"
		[Register ("log", "(Lapptentive/com/android/util/LogLevel;Ljava/lang/String;)V", "GetLog_Lapptentive_com_android_util_LogLevel_Ljava_lang_String_Handler:ApptentiveCore.ILoggerInvoker, ApptentiveCore")]
		void Log (global::Apptentive.Com.Android.Util.LogLevel logLevel, string message);

		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.core']/interface[@name='Logger']/method[@name='log' and count(parameter)=2 and parameter[1][@type='apptentive.com.android.util.LogLevel'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("log", "(Lapptentive/com/android/util/LogLevel;Ljava/lang/Throwable;)V", "GetLog_Lapptentive_com_android_util_LogLevel_Ljava_lang_Throwable_Handler:ApptentiveCore.ILoggerInvoker, ApptentiveCore")]
		void Log (global::Apptentive.Com.Android.Util.LogLevel logLevel, global::Java.Lang.Throwable throwable);

	}

	[global::Android.Runtime.Register ("apptentive/com/android/core/Logger", DoNotGenerateAcw=true)]
	internal partial class ILoggerInvoker : global::Java.Lang.Object, ILogger {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/core/Logger", typeof (ILoggerInvoker));

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

		public static ILogger GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILogger> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'apptentive.com.android.core.Logger'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoggerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isMainQueue;
#pragma warning disable 0169
		static Delegate GetIsMainQueueHandler ()
		{
			if (cb_isMainQueue == null)
				cb_isMainQueue = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_IsMainQueue));
			return cb_isMainQueue;
		}

		static bool n_IsMainQueue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::ApptentiveCore.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMainQueue;
		}
#pragma warning restore 0169

		IntPtr id_isMainQueue;
		public unsafe bool IsMainQueue {
			get {
				if (id_isMainQueue == IntPtr.Zero)
					id_isMainQueue = JNIEnv.GetMethodID (class_ref, "isMainQueue", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMainQueue);
			}
		}

		static Delegate cb_log_Lapptentive_com_android_util_LogLevel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLog_Lapptentive_com_android_util_LogLevel_Ljava_lang_String_Handler ()
		{
			if (cb_log_Lapptentive_com_android_util_LogLevel_Ljava_lang_String_ == null)
				cb_log_Lapptentive_com_android_util_LogLevel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_Log_Lapptentive_com_android_util_LogLevel_Ljava_lang_String_));
			return cb_log_Lapptentive_com_android_util_LogLevel_Ljava_lang_String_;
		}

		static void n_Log_Lapptentive_com_android_util_LogLevel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_logLevel, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::ApptentiveCore.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var logLevel = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Util.LogLevel> (native_logLevel, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.Log (logLevel, message);
		}
#pragma warning restore 0169

		IntPtr id_log_Lapptentive_com_android_util_LogLevel_Ljava_lang_String_;
		public unsafe void Log (global::Apptentive.Com.Android.Util.LogLevel logLevel, string message)
		{
			if (id_log_Lapptentive_com_android_util_LogLevel_Ljava_lang_String_ == IntPtr.Zero)
				id_log_Lapptentive_com_android_util_LogLevel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "log", "(Lapptentive/com/android/util/LogLevel;Ljava/lang/String;)V");
			IntPtr native_message = JNIEnv.NewString ((string)message);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((logLevel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logLevel).Handle);
			__args [1] = new JValue (native_message);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_log_Lapptentive_com_android_util_LogLevel_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_message);
		}

		static Delegate cb_log_Lapptentive_com_android_util_LogLevel_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetLog_Lapptentive_com_android_util_LogLevel_Ljava_lang_Throwable_Handler ()
		{
			if (cb_log_Lapptentive_com_android_util_LogLevel_Ljava_lang_Throwable_ == null)
				cb_log_Lapptentive_com_android_util_LogLevel_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_Log_Lapptentive_com_android_util_LogLevel_Ljava_lang_Throwable_));
			return cb_log_Lapptentive_com_android_util_LogLevel_Ljava_lang_Throwable_;
		}

		static void n_Log_Lapptentive_com_android_util_LogLevel_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_logLevel, IntPtr native_throwable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::ApptentiveCore.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var logLevel = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Util.LogLevel> (native_logLevel, JniHandleOwnership.DoNotTransfer);
			var throwable = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_throwable, JniHandleOwnership.DoNotTransfer);
			__this.Log (logLevel, throwable);
		}
#pragma warning restore 0169

		IntPtr id_log_Lapptentive_com_android_util_LogLevel_Ljava_lang_Throwable_;
		public unsafe void Log (global::Apptentive.Com.Android.Util.LogLevel logLevel, global::Java.Lang.Throwable throwable)
		{
			if (id_log_Lapptentive_com_android_util_LogLevel_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_log_Lapptentive_com_android_util_LogLevel_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "log", "(Lapptentive/com/android/util/LogLevel;Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((logLevel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logLevel).Handle);
			__args [1] = new JValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_log_Lapptentive_com_android_util_LogLevel_Ljava_lang_Throwable_, __args);
		}

	}
}
