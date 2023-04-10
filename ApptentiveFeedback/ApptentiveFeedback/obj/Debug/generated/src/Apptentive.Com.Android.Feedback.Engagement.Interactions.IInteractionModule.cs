using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Apptentive.Com.Android.Feedback.Engagement.Interactions {

	// Metadata.xml XPath interface reference: path="/api/package[@name='apptentive.com.android.feedback.engagement.interactions']/interface[@name='InteractionModule']"
	[Register ("apptentive/com/android/feedback/engagement/interactions/InteractionModule", "", "Apptentive.Com.Android.Feedback.Engagement.Interactions.IInteractionModuleInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends apptentive.com.android.feedback.engagement.interactions.Interaction"})]
	public partial interface IInteractionModule : IJavaObject, IJavaPeerable {
		global::Java.Lang.Class InteractionClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback.engagement.interactions']/interface[@name='InteractionModule']/method[@name='getInteractionClass' and count(parameter)=0]"
			[Register ("getInteractionClass", "()Ljava/lang/Class;", "GetGetInteractionClassHandler:Apptentive.Com.Android.Feedback.Engagement.Interactions.IInteractionModuleInvoker, ApptentiveFeedback")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback.engagement.interactions']/interface[@name='InteractionModule']/method[@name='provideInteractionLauncher' and count(parameter)=0]"
		[Register ("provideInteractionLauncher", "()Lapptentive/com/android/feedback/engagement/interactions/InteractionLauncher;", "GetProvideInteractionLauncherHandler:Apptentive.Com.Android.Feedback.Engagement.Interactions.IInteractionModuleInvoker, ApptentiveFeedback")]
		global::Apptentive.Com.Android.Feedback.Engagement.Interactions.IInteractionLauncher ProvideInteractionLauncher ();

		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback.engagement.interactions']/interface[@name='InteractionModule']/method[@name='provideInteractionTypeConverter' and count(parameter)=0]"
		[Register ("provideInteractionTypeConverter", "()Lapptentive/com/android/feedback/engagement/interactions/InteractionTypeConverter;", "GetProvideInteractionTypeConverterHandler:Apptentive.Com.Android.Feedback.Engagement.Interactions.IInteractionModuleInvoker, ApptentiveFeedback")]
		global::Apptentive.Com.Android.Feedback.Engagement.Interactions.IInteractionTypeConverter ProvideInteractionTypeConverter ();

	}

	[global::Android.Runtime.Register ("apptentive/com/android/feedback/engagement/interactions/InteractionModule", DoNotGenerateAcw=true)]
	internal partial class IInteractionModuleInvoker : global::Java.Lang.Object, IInteractionModule {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/feedback/engagement/interactions/InteractionModule", typeof (IInteractionModuleInvoker));

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

		public static IInteractionModule GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInteractionModule> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'apptentive.com.android.feedback.engagement.interactions.InteractionModule'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInteractionModuleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getInteractionClass;
#pragma warning disable 0169
		static Delegate GetGetInteractionClassHandler ()
		{
			if (cb_getInteractionClass == null)
				cb_getInteractionClass = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetInteractionClass));
			return cb_getInteractionClass;
		}

		static IntPtr n_GetInteractionClass (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Feedback.Engagement.Interactions.IInteractionModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InteractionClass);
		}
#pragma warning restore 0169

		IntPtr id_getInteractionClass;
		public unsafe global::Java.Lang.Class InteractionClass {
			get {
				if (id_getInteractionClass == IntPtr.Zero)
					id_getInteractionClass = JNIEnv.GetMethodID (class_ref, "getInteractionClass", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInteractionClass), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_provideInteractionLauncher;
#pragma warning disable 0169
		static Delegate GetProvideInteractionLauncherHandler ()
		{
			if (cb_provideInteractionLauncher == null)
				cb_provideInteractionLauncher = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_ProvideInteractionLauncher));
			return cb_provideInteractionLauncher;
		}

		static IntPtr n_ProvideInteractionLauncher (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Feedback.Engagement.Interactions.IInteractionModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ProvideInteractionLauncher ());
		}
#pragma warning restore 0169

		IntPtr id_provideInteractionLauncher;
		public unsafe global::Apptentive.Com.Android.Feedback.Engagement.Interactions.IInteractionLauncher ProvideInteractionLauncher ()
		{
			if (id_provideInteractionLauncher == IntPtr.Zero)
				id_provideInteractionLauncher = JNIEnv.GetMethodID (class_ref, "provideInteractionLauncher", "()Lapptentive/com/android/feedback/engagement/interactions/InteractionLauncher;");
			return global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Feedback.Engagement.Interactions.IInteractionLauncher> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_provideInteractionLauncher), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_provideInteractionTypeConverter;
#pragma warning disable 0169
		static Delegate GetProvideInteractionTypeConverterHandler ()
		{
			if (cb_provideInteractionTypeConverter == null)
				cb_provideInteractionTypeConverter = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_ProvideInteractionTypeConverter));
			return cb_provideInteractionTypeConverter;
		}

		static IntPtr n_ProvideInteractionTypeConverter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Feedback.Engagement.Interactions.IInteractionModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ProvideInteractionTypeConverter ());
		}
#pragma warning restore 0169

		IntPtr id_provideInteractionTypeConverter;
		public unsafe global::Apptentive.Com.Android.Feedback.Engagement.Interactions.IInteractionTypeConverter ProvideInteractionTypeConverter ()
		{
			if (id_provideInteractionTypeConverter == IntPtr.Zero)
				id_provideInteractionTypeConverter = JNIEnv.GetMethodID (class_ref, "provideInteractionTypeConverter", "()Lapptentive/com/android/feedback/engagement/interactions/InteractionTypeConverter;");
			return global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Feedback.Engagement.Interactions.IInteractionTypeConverter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_provideInteractionTypeConverter), JniHandleOwnership.TransferLocalRef);
		}

	}
}
