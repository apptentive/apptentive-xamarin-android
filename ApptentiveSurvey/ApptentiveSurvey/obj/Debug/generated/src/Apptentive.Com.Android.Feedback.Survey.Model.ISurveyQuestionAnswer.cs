using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Apptentive.Com.Android.Feedback.Survey.Model {

	// Metadata.xml XPath interface reference: path="/api/package[@name='apptentive.com.android.feedback.survey.model']/interface[@name='SurveyQuestionAnswer']"
	[Register ("apptentive/com/android/feedback/survey/model/SurveyQuestionAnswer", "", "Apptentive.Com.Android.Feedback.Survey.Model.ISurveyQuestionAnswerInvoker")]
	public partial interface ISurveyQuestionAnswer : IJavaObject, IJavaPeerable {
	}

	[global::Android.Runtime.Register ("apptentive/com/android/feedback/survey/model/SurveyQuestionAnswer", DoNotGenerateAcw=true)]
	internal partial class ISurveyQuestionAnswerInvoker : global::Java.Lang.Object, ISurveyQuestionAnswer {
		static readonly JniPeerMembers _members = new XAPeerMembers ("apptentive/com/android/feedback/survey/model/SurveyQuestionAnswer", typeof (ISurveyQuestionAnswerInvoker));

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

		public static ISurveyQuestionAnswer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISurveyQuestionAnswer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'apptentive.com.android.feedback.survey.model.SurveyQuestionAnswer'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISurveyQuestionAnswerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}
}
