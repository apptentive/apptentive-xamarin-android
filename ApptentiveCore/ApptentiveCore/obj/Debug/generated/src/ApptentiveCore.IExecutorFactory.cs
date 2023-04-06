using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace ApptentiveCore {

	// Metadata.xml XPath class reference: path="/api/package[@name='apptentive.com.android.core']/class[@name='ExecutorFactory.DefaultImpls']"
	[global::Android.Runtime.Register ("apptentive/com/android/core/ExecutorFactory$DefaultImpls", DoNotGenerateAcw=true)]
	public sealed partial class ExecutorFactoryDefaultImpls : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/core/ExecutorFactory$DefaultImpls", typeof (ExecutorFactoryDefaultImpls));

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

		internal ExecutorFactoryDefaultImpls (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='apptentive.com.android.core']/interface[@name='ExecutorFactory']"
	[Register ("apptentive/com/android/core/ExecutorFactory", "", "ApptentiveCore.IExecutorFactoryInvoker")]
	public partial interface IExecutorFactory : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.core']/interface[@name='ExecutorFactory']/method[@name='createConcurrentQueue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("createConcurrentQueue", "(Ljava/lang/String;Ljava/lang/Integer;)Lapptentive/com/android/concurrent/ExecutorQueue;", "GetCreateConcurrentQueue_Ljava_lang_String_Ljava_lang_Integer_Handler:ApptentiveCore.IExecutorFactoryInvoker, ApptentiveCore")]
		global::Apptentive.Com.Android.Concurrent.ExecutorQueue CreateConcurrentQueue (string name, global::Java.Lang.Integer p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.core']/interface[@name='ExecutorFactory']/method[@name='createMainQueue' and count(parameter)=0]"
		[Register ("createMainQueue", "()Lapptentive/com/android/concurrent/ExecutorQueue;", "GetCreateMainQueueHandler:ApptentiveCore.IExecutorFactoryInvoker, ApptentiveCore")]
		global::Apptentive.Com.Android.Concurrent.ExecutorQueue CreateMainQueue ();

		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.core']/interface[@name='ExecutorFactory']/method[@name='createSerialQueue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createSerialQueue", "(Ljava/lang/String;)Lapptentive/com/android/concurrent/ExecutorQueue;", "GetCreateSerialQueue_Ljava_lang_String_Handler:ApptentiveCore.IExecutorFactoryInvoker, ApptentiveCore")]
		global::Apptentive.Com.Android.Concurrent.ExecutorQueue CreateSerialQueue (string name);

	}

	[global::Android.Runtime.Register ("apptentive/com/android/core/ExecutorFactory", DoNotGenerateAcw=true)]
	internal partial class IExecutorFactoryInvoker : global::Java.Lang.Object, IExecutorFactory {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/core/ExecutorFactory", typeof (IExecutorFactoryInvoker));

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

		public static IExecutorFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IExecutorFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'apptentive.com.android.core.ExecutorFactory'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IExecutorFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createConcurrentQueue_Ljava_lang_String_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetCreateConcurrentQueue_Ljava_lang_String_Ljava_lang_Integer_Handler ()
		{
			if (cb_createConcurrentQueue_Ljava_lang_String_Ljava_lang_Integer_ == null)
				cb_createConcurrentQueue_Ljava_lang_String_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_L (n_CreateConcurrentQueue_Ljava_lang_String_Ljava_lang_Integer_));
			return cb_createConcurrentQueue_Ljava_lang_String_Ljava_lang_Integer_;
		}

		static IntPtr n_CreateConcurrentQueue_Ljava_lang_String_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::ApptentiveCore.IExecutorFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateConcurrentQueue (name, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createConcurrentQueue_Ljava_lang_String_Ljava_lang_Integer_;
		public unsafe global::Apptentive.Com.Android.Concurrent.ExecutorQueue CreateConcurrentQueue (string name, global::Java.Lang.Integer p1)
		{
			if (id_createConcurrentQueue_Ljava_lang_String_Ljava_lang_Integer_ == IntPtr.Zero)
				id_createConcurrentQueue_Ljava_lang_String_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "createConcurrentQueue", "(Ljava/lang/String;Ljava/lang/Integer;)Lapptentive/com/android/concurrent/ExecutorQueue;");
			IntPtr native_name = JNIEnv.NewString ((string)name);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_name);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Concurrent.ExecutorQueue> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createConcurrentQueue_Ljava_lang_String_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_name);
			return __ret;
		}

		static Delegate cb_createMainQueue;
#pragma warning disable 0169
		static Delegate GetCreateMainQueueHandler ()
		{
			if (cb_createMainQueue == null)
				cb_createMainQueue = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_CreateMainQueue));
			return cb_createMainQueue;
		}

		static IntPtr n_CreateMainQueue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::ApptentiveCore.IExecutorFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateMainQueue ());
		}
#pragma warning restore 0169

		IntPtr id_createMainQueue;
		public unsafe global::Apptentive.Com.Android.Concurrent.ExecutorQueue CreateMainQueue ()
		{
			if (id_createMainQueue == IntPtr.Zero)
				id_createMainQueue = JNIEnv.GetMethodID (class_ref, "createMainQueue", "()Lapptentive/com/android/concurrent/ExecutorQueue;");
			return global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Concurrent.ExecutorQueue> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createMainQueue), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_createSerialQueue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateSerialQueue_Ljava_lang_String_Handler ()
		{
			if (cb_createSerialQueue_Ljava_lang_String_ == null)
				cb_createSerialQueue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_CreateSerialQueue_Ljava_lang_String_));
			return cb_createSerialQueue_Ljava_lang_String_;
		}

		static IntPtr n_CreateSerialQueue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::ApptentiveCore.IExecutorFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSerialQueue (name));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createSerialQueue_Ljava_lang_String_;
		public unsafe global::Apptentive.Com.Android.Concurrent.ExecutorQueue CreateSerialQueue (string name)
		{
			if (id_createSerialQueue_Ljava_lang_String_ == IntPtr.Zero)
				id_createSerialQueue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createSerialQueue", "(Ljava/lang/String;)Lapptentive/com/android/concurrent/ExecutorQueue;");
			IntPtr native_name = JNIEnv.NewString ((string)name);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_name);
			var __ret = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Concurrent.ExecutorQueue> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createSerialQueue_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_name);
			return __ret;
		}

	}
}
