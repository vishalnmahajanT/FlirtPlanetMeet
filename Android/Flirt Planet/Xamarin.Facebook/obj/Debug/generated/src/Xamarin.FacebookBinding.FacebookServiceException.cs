using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='FacebookServiceException']"
	[global::Android.Runtime.Register ("com/facebook/FacebookServiceException", DoNotGenerateAcw=true)]
	public partial class FacebookServiceException : global::Xamarin.FacebookBinding.FacebookException {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/FacebookServiceException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FacebookServiceException); }
		}

		protected FacebookServiceException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_facebook_FacebookRequestError_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='FacebookServiceException']/constructor[@name='FacebookServiceException' and count(parameter)=2 and parameter[1][@type='com.facebook.FacebookRequestError'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/facebook/FacebookRequestError;Ljava/lang/String;)V", "")]
		public FacebookServiceException (global::Xamarin.FacebookBinding.FacebookRequestError p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (FacebookServiceException)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/facebook/FacebookRequestError;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/facebook/FacebookRequestError;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Lcom_facebook_FacebookRequestError_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Lcom_facebook_FacebookRequestError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/FacebookRequestError;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_FacebookRequestError_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_facebook_FacebookRequestError_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_getRequestError;
		public global::Xamarin.FacebookBinding.FacebookRequestError RequestError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='FacebookServiceException']/method[@name='getRequestError' and count(parameter)=0]"
			[Register ("getRequestError", "()Lcom/facebook/FacebookRequestError;", "GetGetRequestErrorHandler")]
			get {
				if (id_getRequestError == IntPtr.Zero)
					id_getRequestError = JNIEnv.GetMethodID (class_ref, "getRequestError", "()Lcom/facebook/FacebookRequestError;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.FacebookRequestError> (JNIEnv.CallObjectMethod  (Handle, id_getRequestError), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='FacebookServiceException']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}
}
