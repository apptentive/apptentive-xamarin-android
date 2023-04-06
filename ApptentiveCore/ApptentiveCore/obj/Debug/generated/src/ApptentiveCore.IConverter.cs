using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace ApptentiveCore {

	// Metadata.xml XPath interface reference: path="/api/package[@name='apptentive.com.android.core']/interface[@name='Converter']"
	[Register ("apptentive/com/android/core/Converter", "", "ApptentiveCore.IConverterInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Source", "Target"})]
	public partial interface IConverter : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.core']/interface[@name='Converter']/method[@name='convert' and count(parameter)=1 and parameter[1][@type='Source']]"
		[Register ("convert", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetConvert_Ljava_lang_Object_Handler:ApptentiveCore.IConverterInvoker, ApptentiveCore")]
		global::Java.Lang.Object Convert (global::Java.Lang.Object source);

	}

	[global::Android.Runtime.Register ("apptentive/com/android/core/Converter", DoNotGenerateAcw=true)]
	internal partial class IConverterInvoker : global::Java.Lang.Object, IConverter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/core/Converter", typeof (IConverterInvoker));

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

		public static IConverter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConverter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'apptentive.com.android.core.Converter'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConverterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_convert_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetConvert_Ljava_lang_Object_Handler ()
		{
			if (cb_convert_Ljava_lang_Object_ == null)
				cb_convert_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_Convert_Ljava_lang_Object_));
			return cb_convert_Ljava_lang_Object_;
		}

		static IntPtr n_Convert_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			var __this = global::Java.Lang.Object.GetObject<global::ApptentiveCore.IConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_source, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Convert (source));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_convert_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Convert (global::Java.Lang.Object source)
		{
			if (id_convert_Ljava_lang_Object_ == IntPtr.Zero)
				id_convert_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "convert", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_source = JNIEnv.ToLocalJniHandle (source);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_source);
			var __ret = (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_convert_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_source);
			return __ret;
		}

	}
}
