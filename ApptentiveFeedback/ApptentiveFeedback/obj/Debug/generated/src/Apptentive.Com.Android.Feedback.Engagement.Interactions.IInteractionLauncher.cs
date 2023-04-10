using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Apptentive.Com.Android.Feedback.Engagement.Interactions {

	// Metadata.xml XPath interface reference: path="/api/package[@name='apptentive.com.android.feedback.engagement.interactions']/interface[@name='InteractionLauncher']"
	[Register ("apptentive/com/android/feedback/engagement/interactions/InteractionLauncher", "", "Apptentive.Com.Android.Feedback.Engagement.Interactions.IInteractionLauncherInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends apptentive.com.android.feedback.engagement.interactions.Interaction"})]
	public partial interface IInteractionLauncher : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='apptentive.com.android.feedback.engagement.interactions']/interface[@name='InteractionLauncher']/method[@name='launchInteraction' and count(parameter)=2 and parameter[1][@type='apptentive.com.android.feedback.engagement.EngagementContext'] and parameter[2][@type='T']]"
		[Register ("launchInteraction", "(Lapptentive/com/android/feedback/engagement/EngagementContext;Lapptentive/com/android/feedback/engagement/interactions/Interaction;)V", "GetLaunchInteraction_Lapptentive_com_android_feedback_engagement_EngagementContext_Lapptentive_com_android_feedback_engagement_interactions_Interaction_Handler:Apptentive.Com.Android.Feedback.Engagement.Interactions.IInteractionLauncherInvoker, ApptentiveFeedback")]
		void LaunchInteraction (global::Apptentive.Com.Android.Feedback.Engagement.EngagementContext engagementContext, global::Java.Lang.Object interaction);

	}

	[global::Android.Runtime.Register ("apptentive/com/android/feedback/engagement/interactions/InteractionLauncher", DoNotGenerateAcw=true)]
	internal partial class IInteractionLauncherInvoker : global::Java.Lang.Object, IInteractionLauncher {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/feedback/engagement/interactions/InteractionLauncher", typeof (IInteractionLauncherInvoker));

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

		public static IInteractionLauncher GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInteractionLauncher> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'apptentive.com.android.feedback.engagement.interactions.InteractionLauncher'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInteractionLauncherInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_launchInteraction_Lapptentive_com_android_feedback_engagement_EngagementContext_Lapptentive_com_android_feedback_engagement_interactions_Interaction_;
#pragma warning disable 0169
		static Delegate GetLaunchInteraction_Lapptentive_com_android_feedback_engagement_EngagementContext_Lapptentive_com_android_feedback_engagement_interactions_Interaction_Handler ()
		{
			if (cb_launchInteraction_Lapptentive_com_android_feedback_engagement_EngagementContext_Lapptentive_com_android_feedback_engagement_interactions_Interaction_ == null)
				cb_launchInteraction_Lapptentive_com_android_feedback_engagement_EngagementContext_Lapptentive_com_android_feedback_engagement_interactions_Interaction_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_LaunchInteraction_Lapptentive_com_android_feedback_engagement_EngagementContext_Lapptentive_com_android_feedback_engagement_interactions_Interaction_));
			return cb_launchInteraction_Lapptentive_com_android_feedback_engagement_EngagementContext_Lapptentive_com_android_feedback_engagement_interactions_Interaction_;
		}

		static void n_LaunchInteraction_Lapptentive_com_android_feedback_engagement_EngagementContext_Lapptentive_com_android_feedback_engagement_interactions_Interaction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_engagementContext, IntPtr native_interaction)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Feedback.Engagement.Interactions.IInteractionLauncher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var engagementContext = global::Java.Lang.Object.GetObject<global::Apptentive.Com.Android.Feedback.Engagement.EngagementContext> (native_engagementContext, JniHandleOwnership.DoNotTransfer);
			var interaction = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_interaction, JniHandleOwnership.DoNotTransfer);
			__this.LaunchInteraction (engagementContext, interaction);
		}
#pragma warning restore 0169

		IntPtr id_launchInteraction_Lapptentive_com_android_feedback_engagement_EngagementContext_Lapptentive_com_android_feedback_engagement_interactions_Interaction_;
		public unsafe void LaunchInteraction (global::Apptentive.Com.Android.Feedback.Engagement.EngagementContext engagementContext, global::Java.Lang.Object interaction)
		{
			if (id_launchInteraction_Lapptentive_com_android_feedback_engagement_EngagementContext_Lapptentive_com_android_feedback_engagement_interactions_Interaction_ == IntPtr.Zero)
				id_launchInteraction_Lapptentive_com_android_feedback_engagement_EngagementContext_Lapptentive_com_android_feedback_engagement_interactions_Interaction_ = JNIEnv.GetMethodID (class_ref, "launchInteraction", "(Lapptentive/com/android/feedback/engagement/EngagementContext;Lapptentive/com/android/feedback/engagement/interactions/Interaction;)V");
			IntPtr native_interaction = JNIEnv.ToLocalJniHandle (interaction);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((engagementContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) engagementContext).Handle);
			__args [1] = new JValue (native_interaction);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_launchInteraction_Lapptentive_com_android_feedback_engagement_EngagementContext_Lapptentive_com_android_feedback_engagement_interactions_Interaction_, __args);
			JNIEnv.DeleteLocalRef (native_interaction);
		}

	}
}
