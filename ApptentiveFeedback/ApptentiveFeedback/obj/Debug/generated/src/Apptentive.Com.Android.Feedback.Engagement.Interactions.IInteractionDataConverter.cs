using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Apptentive.Com.Android.Feedback.Engagement.Interactions {

	// Metadata.xml XPath interface reference: path="/api/package[@name='apptentive.com.android.feedback.engagement.interactions']/interface[@name='InteractionDataConverter']"
	[Register ("apptentive/com/android/feedback/engagement/interactions/InteractionDataConverter", "", "Apptentive.Com.Android.Feedback.Engagement.Interactions.IInteractionDataConverterInvoker")]
	public partial interface IInteractionDataConverter : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback.engagement.interactions']/interface[@name='InteractionDataConverter']/method[@name='convert' and count(parameter)=1 and parameter[1][@type='apptentive.com.android.feedback.engagement.interactions.InteractionData']]"
		[Register ("convert", "(Lapptentive/com/android/feedback/engagement/interactions/InteractionData;)Lapptentive/com/android/feedback/engagement/interactions/Interaction;", "GetConvert_Lapptentive_com_android_feedback_engagement_interactions_InteractionData_Handler:Apptentive.Com.Android.Feedback.Engagement.Interactions.IInteractionDataConverterInvoker, ApptentiveFeedback")]
		global::Apptentive.Com.Android.Feedback.Engagement.Interactions.Interaction Convert (global::Apptentive.Com.Android.Feedback.Engagement.Interactions.InteractionData data);

	}

	[global::Android.Runtime.Register ("apptentive/com/android/feedback/engagement/interactions/InteractionDataConverter", DoNotGenerateAcw=true)]
	internal partial class IInteractionDataConverterInvoker : global::Java.Lang.Object, IInteractionDataConverter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/feedback/engagement/interactions/InteractionDataConverter", typeof (IInteractionDataConverterInvoker));

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

		public static IInteractionDataConverter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInteractionDataConverter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'apptentive.com.android.feedback.engagement.interactions.InteractionDataConverter'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInteractionDataConverterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_convert_Lapptentive_com_android_feedback_engagement_interactions_InteractionData_;
#pragma warning disable 0169
		static Delegate GetConvert_Lapptentive_com_android_feedback_engagement_interactions_InteractionData_Handler ()
		{
			if (cb_convert_Lapptentive_com_android_feedback_engagement_interactions_InteractionData_ == null)
				cb_convert_Lapptentive_com_android_feedback_engagement_interactions_InteractionData_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_Convert_Lapptentive_com_android_feedback_engagement_interactions_InteractionData_));
			return cb_convert_Lapptentive_com_android_feedback_engagement_interactions_InteractionData_;
		}

		static IntPtr n_Convert_Lapptentive_com_android_feedback_engagement_interactions_InteractionData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Feedback.Engagement.Interactions.IInteractionDataConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Feedback.Engagement.Interactions.InteractionData> (native_data, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Convert (data));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_convert_Lapptentive_com_android_feedback_engagement_interactions_InteractionData_;
		public unsafe global::Apptentive.Com.Android.Feedback.Engagement.Interactions.Interaction Convert (global::Apptentive.Com.Android.Feedback.Engagement.Interactions.InteractionData data)
		{
			if (id_convert_Lapptentive_com_android_feedback_engagement_interactions_InteractionData_ == IntPtr.Zero)
				id_convert_Lapptentive_com_android_feedback_engagement_interactions_InteractionData_ = JNIEnv.GetMethodID (class_ref, "convert", "(Lapptentive/com/android/feedback/engagement/interactions/InteractionData;)Lapptentive/com/android/feedback/engagement/interactions/Interaction;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Feedback.Engagement.Interactions.Interaction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_convert_Lapptentive_com_android_feedback_engagement_interactions_InteractionData_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
