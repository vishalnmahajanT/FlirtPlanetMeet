using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='FacebookDialogException']"
	[global::Android.Runtime.Register ("com/facebook/FacebookDialogException", DoNotGenerateAcw=true)]
	public partial class FacebookDialogException : global::Xamarin.FacebookBinding.FacebookException {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/FacebookDialogException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FacebookDialogException); }
		}

		protected FacebookDialogException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='FacebookDialogException']/constructor[@name='FacebookDialogException' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;ILjava/lang/String;)V", "")]
		public FacebookDialogException (string p0, int p1, string p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (FacebookDialogException)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;ILjava/lang/String;)V", new JValue (native_p0), new JValue (p1), new JValue (native_p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;ILjava/lang/String;)V", new JValue (native_p0), new JValue (p1), new JValue (native_p2));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_Ljava_lang_String_ILjava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_ILjava_lang_String_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_ILjava_lang_String_, new JValue (native_p0), new JValue (p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_getErrorCode;
#pragma warning disable 0169
		static Delegate GetGetErrorCodeHandler ()
		{
			if (cb_getErrorCode == null)
				cb_getErrorCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetErrorCode);
			return cb_getErrorCode;
		}

		static int n_GetErrorCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.FacebookDialogException __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.FacebookDialogException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ErrorCode;
		}
#pragma warning restore 0169

		static IntPtr id_getErrorCode;
		public virtual int ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='FacebookDialogException']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()I", "GetGetErrorCodeHandler")]
			get {
				if (id_getErrorCode == IntPtr.Zero)
					id_getErrorCode = JNIEnv.GetMethodID (class_ref, "getErrorCode", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getErrorCode);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorCode", "()I"));
			}
		}

		static Delegate cb_getFailingUrl;
#pragma warning disable 0169
		static Delegate GetGetFailingUrlHandler ()
		{
			if (cb_getFailingUrl == null)
				cb_getFailingUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFailingUrl);
			return cb_getFailingUrl;
		}

		static IntPtr n_GetFailingUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.FacebookDialogException __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.FacebookDialogException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FailingUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getFailingUrl;
		public virtual string FailingUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='FacebookDialogException']/method[@name='getFailingUrl' and count(parameter)=0]"
			[Register ("getFailingUrl", "()Ljava/lang/String;", "GetGetFailingUrlHandler")]
			get {
				if (id_getFailingUrl == IntPtr.Zero)
					id_getFailingUrl = JNIEnv.GetMethodID (class_ref, "getFailingUrl", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFailingUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFailingUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
