using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Apptentive.Com.Android.Feedback.Engagement {

	// Metadata.xml XPath interface reference: path="/api/package[@name='apptentive.com.android.feedback.engagement']/interface[@name='InteractionEngagement']"
	[Register ("apptentive/com/android/feedback/engagement/InteractionEngagement", "", "Apptentive.Com.Android.Feedback.Engagement.IInteractionEngagementInvoker")]
	public partial interface IInteractionEngagement : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback.engagement']/interface[@name='InteractionEngagement']/method[@name='engage' and count(parameter)=2 and parameter[1][@type='apptentive.com.android.feedback.engagement.EngagementContext'] and parameter[2][@type='apptentive.com.android.feedback.engagement.interactions.Interaction']]"
		[Register ("engage", "(Lapptentive/com/android/feedback/engagement/EngagementContext;Lapptentive/com/android/feedback/engagement/interactions/Interaction;)Lapptentive/com/android/feedback/EngagementResult;", "GetEngage_Lapptentive_com_android_feedback_engagement_EngagementContext_Lapptentive_com_android_feedback_engagement_interactions_Interaction_Handler:Apptentive.Com.Android.Feedback.Engagement.IInteractionEngagementInvoker, ApptentiveFeedback")]
		global::ApptentiveKit.Android.EngagementResult Engage (global::Apptentive.Com.Android.Feedback.Engagement.EngagementContext context, global::Apptentive.Com.Android.Feedback.Engagement.Interactions.Interaction interaction);

	}

	[global::Android.Runtime.Register ("apptentive/com/android/feedback/engagement/InteractionEngagement", DoNotGenerateAcw=true)]
	internal partial class IInteractionEngagementInvoker : global::Java.Lang.Object, IInteractionEngagement {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/feedback/engagement/InteractionEngagement", typeof (IInteractionEngagementInvoker));

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

		public static IInteractionEngagement GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInteractionEngagement> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'apptentive.com.android.feedback.engagement.InteractionEngagement'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInteractionEngagementInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_engage_Lapptentive_com_android_feedback_engagement_EngagementContext_Lapptentive_com_android_feedback_engagement_interactions_Interaction_;
#pragma warning disable 0169
		static Delegate GetEngage_Lapptentive_com_android_feedback_engagement_EngagementContext_Lapptentive_com_android_feedback_engagement_interactions_Interaction_Handler ()
		{
			if (cb_engage_Lapptentive_com_android_feedback_engagement_EngagementContext_Lapptentive_com_android_feedback_engagement_interactions_Interaction_ == null)
				cb_engage_Lapptentive_com_android_feedback_engagement_EngagementContext_Lapptentive_com_android_feedback_engagement_interactions_Interaction_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_L (n_Engage_Lapptentive_com_android_feedback_engagement_EngagementContext_Lapptentive_com_android_feedback_engagement_interactions_Interaction_));
			return cb_engage_Lapptentive_com_android_feedback_engagement_EngagementContext_Lapptentive_com_android_feedback_engagement_interactions_Interaction_;
		}

		static IntPtr n_Engage_Lapptentive_com_android_feedback_engagement_EngagementContext_Lapptentive_com_android_feedback_engagement_interactions_Interaction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_interaction)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Feedback.Engagement.IInteractionEngagement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Feedback.Engagement.EngagementContext> (native_context, JniHandleOwnership.DoNotTransfer);
			var interaction = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Feedback.Engagement.Interactions.Interaction> (native_interaction, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Engage (context, interaction));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_engage_Lapptentive_com_android_feedback_engagement_EngagementContext_Lapptentive_com_android_feedback_engagement_interactions_Interaction_;
		public unsafe global::ApptentiveKit.Android.EngagementResult Engage (global::Apptentive.Com.Android.Feedback.Engagement.EngagementContext context, global::Apptentive.Com.Android.Feedback.Engagement.Interactions.Interaction interaction)
		{
			if (id_engage_Lapptentive_com_android_feedback_engagement_EngagementContext_Lapptentive_com_android_feedback_engagement_interactions_Interaction_ == IntPtr.Zero)
				id_engage_Lapptentive_com_android_feedback_engagement_EngagementContext_Lapptentive_com_android_feedback_engagement_interactions_Interaction_ = JNIEnv.GetMethodID (class_ref, "engage", "(Lapptentive/com/android/feedback/engagement/EngagementContext;Lapptentive/com/android/feedback/engagement/interactions/Interaction;)Lapptentive/com/android/feedback/EngagementResult;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
			__args [1] = new JValue ((interaction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interaction).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::ApptentiveKit.Android.EngagementResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_engage_Lapptentive_com_android_feedback_engagement_EngagementContext_Lapptentive_com_android_feedback_engagement_interactions_Interaction_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
