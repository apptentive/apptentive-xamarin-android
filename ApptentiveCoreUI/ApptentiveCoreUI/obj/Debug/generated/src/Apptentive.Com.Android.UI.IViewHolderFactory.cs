using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Apptentive.Com.Android.UI {

	// Metadata.xml XPath interface reference: path="/api/package[@name='apptentive.com.android.ui']/interface[@name='ViewHolderFactory']"
	[Register ("apptentive/com/android/ui/ViewHolderFactory", "", "Apptentive.Com.Android.UI.IViewHolderFactoryInvoker")]
	public partial interface IViewHolderFactory : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.ui']/interface[@name='ViewHolderFactory']/method[@name='createItemView' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
		[Register ("createItemView", "(Landroid/view/ViewGroup;)Landroid/view/View;", "GetCreateItemView_Landroid_view_ViewGroup_Handler:Apptentive.Com.Android.UI.IViewHolderFactoryInvoker, ApptentiveCoreUI")]
		global::Android.Views.View CreateItemView (global::Android.Views.ViewGroup parent);

	}

	[global::Android.Runtime.Register ("apptentive/com/android/ui/ViewHolderFactory", DoNotGenerateAcw=true)]
	internal partial class IViewHolderFactoryInvoker : global::Java.Lang.Object, IViewHolderFactory {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/ui/ViewHolderFactory", typeof (IViewHolderFactoryInvoker));

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

		public static IViewHolderFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IViewHolderFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'apptentive.com.android.ui.ViewHolderFactory'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IViewHolderFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createItemView_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetCreateItemView_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_createItemView_Landroid_view_ViewGroup_ == null)
				cb_createItemView_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_CreateItemView_Landroid_view_ViewGroup_));
			return cb_createItemView_Landroid_view_ViewGroup_;
		}

		static IntPtr n_CreateItemView_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.UI.IViewHolderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parent = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_parent, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateItemView (parent));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createItemView_Landroid_view_ViewGroup_;
		public unsafe global::Android.Views.View CreateItemView (global::Android.Views.ViewGroup parent)
		{
			if (id_createItemView_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_createItemView_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "createItemView", "(Landroid/view/ViewGroup;)Landroid/view/View;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createItemView_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
