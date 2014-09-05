using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='SessionLoginBehavior']"
	[global::Android.Runtime.Register ("com/facebook/SessionLoginBehavior", DoNotGenerateAcw=true)]
	public sealed partial class SessionLoginBehavior : global::Java.Lang.Enum {


		static IntPtr SSO_ONLY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='SessionLoginBehavior']/field[@name='SSO_ONLY']"
		[Register ("SSO_ONLY")]
		public static global::Xamarin.FacebookBinding.SessionLoginBehavior SsoOnly {
			get {
				if (SSO_ONLY_jfieldId == IntPtr.Zero)
					SSO_ONLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SSO_ONLY", "Lcom/facebook/SessionLoginBehavior;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SSO_ONLY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionLoginBehavior> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SSO_ONLY_jfieldId == IntPtr.Zero)
					SSO_ONLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SSO_ONLY", "Lcom/facebook/SessionLoginBehavior;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SSO_ONLY_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SSO_WITH_FALLBACK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='SessionLoginBehavior']/field[@name='SSO_WITH_FALLBACK']"
		[Register ("SSO_WITH_FALLBACK")]
		public static global::Xamarin.FacebookBinding.SessionLoginBehavior SsoWithFallback {
			get {
				if (SSO_WITH_FALLBACK_jfieldId == IntPtr.Zero)
					SSO_WITH_FALLBACK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SSO_WITH_FALLBACK", "Lcom/facebook/SessionLoginBehavior;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SSO_WITH_FALLBACK_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionLoginBehavior> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SSO_WITH_FALLBACK_jfieldId == IntPtr.Zero)
					SSO_WITH_FALLBACK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SSO_WITH_FALLBACK", "Lcom/facebook/SessionLoginBehavior;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SSO_WITH_FALLBACK_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SUPPRESS_SSO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='SessionLoginBehavior']/field[@name='SUPPRESS_SSO']"
		[Register ("SUPPRESS_SSO")]
		public static global::Xamarin.FacebookBinding.SessionLoginBehavior SuppressSso {
			get {
				if (SUPPRESS_SSO_jfieldId == IntPtr.Zero)
					SUPPRESS_SSO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUPPRESS_SSO", "Lcom/facebook/SessionLoginBehavior;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUPPRESS_SSO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionLoginBehavior> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SUPPRESS_SSO_jfieldId == IntPtr.Zero)
					SUPPRESS_SSO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUPPRESS_SSO", "Lcom/facebook/SessionLoginBehavior;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SUPPRESS_SSO_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/SessionLoginBehavior", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SessionLoginBehavior); }
		}

		internal SessionLoginBehavior (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='SessionLoginBehavior']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/facebook/SessionLoginBehavior;", "")]
		public static global::Xamarin.FacebookBinding.SessionLoginBehavior ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/facebook/SessionLoginBehavior;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Xamarin.FacebookBinding.SessionLoginBehavior __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionLoginBehavior> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='SessionLoginBehavior']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/facebook/SessionLoginBehavior;", "")]
		public static global::Xamarin.FacebookBinding.SessionLoginBehavior[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/facebook/SessionLoginBehavior;");
			return (global::Xamarin.FacebookBinding.SessionLoginBehavior[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Xamarin.FacebookBinding.SessionLoginBehavior));
		}

	}
}
