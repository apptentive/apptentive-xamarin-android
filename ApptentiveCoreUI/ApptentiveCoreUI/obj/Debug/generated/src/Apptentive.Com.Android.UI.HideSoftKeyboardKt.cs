//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Apptentive.Com.Android.UI {

	// Metadata.xml XPath class reference: path="/api/package[@name='apptentive.com.android.ui']/class[@name='HideSoftKeyboardKt']"
	[global::Android.Runtime.Register ("apptentive/com/android/ui/HideSoftKeyboardKt", DoNotGenerateAcw=true)]
	public sealed partial class HideSoftKeyboardKt : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/ui/HideSoftKeyboardKt", typeof (HideSoftKeyboardKt));

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

		internal HideSoftKeyboardKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.ui']/class[@name='HideSoftKeyboardKt']/method[@name='hideSoftKeyboard' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("hideSoftKeyboard", "(Landroid/view/View;)V", "")]
		public static unsafe void HideSoftKeyboard (global::Android.Views.View obj)
		{
			const string __id = "hideSoftKeyboard.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

	}
}
