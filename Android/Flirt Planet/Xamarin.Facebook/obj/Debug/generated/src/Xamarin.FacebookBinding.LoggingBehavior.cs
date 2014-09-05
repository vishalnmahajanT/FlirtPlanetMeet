using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='LoggingBehavior']"
	[global::Android.Runtime.Register ("com/facebook/LoggingBehavior", DoNotGenerateAcw=true)]
	public sealed partial class LoggingBehavior : global::Java.Lang.Enum {


		static IntPtr CACHE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='LoggingBehavior']/field[@name='CACHE']"
		[Register ("CACHE")]
		public static global::Xamarin.FacebookBinding.LoggingBehavior Cache {
			get {
				if (CACHE_jfieldId == IntPtr.Zero)
					CACHE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CACHE", "Lcom/facebook/LoggingBehavior;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CACHE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.LoggingBehavior> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CACHE_jfieldId == IntPtr.Zero)
					CACHE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CACHE", "Lcom/facebook/LoggingBehavior;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CACHE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr DEVELOPER_ERRORS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='LoggingBehavior']/field[@name='DEVELOPER_ERRORS']"
		[Register ("DEVELOPER_ERRORS")]
		public static global::Xamarin.FacebookBinding.LoggingBehavior DeveloperErrors {
			get {
				if (DEVELOPER_ERRORS_jfieldId == IntPtr.Zero)
					DEVELOPER_ERRORS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVELOPER_ERRORS", "Lcom/facebook/LoggingBehavior;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVELOPER_ERRORS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.LoggingBehavior> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DEVELOPER_ERRORS_jfieldId == IntPtr.Zero)
					DEVELOPER_ERRORS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVELOPER_ERRORS", "Lcom/facebook/LoggingBehavior;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DEVELOPER_ERRORS_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr INCLUDE_ACCESS_TOKENS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='LoggingBehavior']/field[@name='INCLUDE_ACCESS_TOKENS']"
		[Register ("INCLUDE_ACCESS_TOKENS")]
		public static global::Xamarin.FacebookBinding.LoggingBehavior IncludeAccessTokens {
			get {
				if (INCLUDE_ACCESS_TOKENS_jfieldId == IntPtr.Zero)
					INCLUDE_ACCESS_TOKENS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INCLUDE_ACCESS_TOKENS", "Lcom/facebook/LoggingBehavior;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INCLUDE_ACCESS_TOKENS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.LoggingBehavior> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (INCLUDE_ACCESS_TOKENS_jfieldId == IntPtr.Zero)
					INCLUDE_ACCESS_TOKENS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INCLUDE_ACCESS_TOKENS", "Lcom/facebook/LoggingBehavior;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, INCLUDE_ACCESS_TOKENS_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr INCLUDE_RAW_RESPONSES_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='LoggingBehavior']/field[@name='INCLUDE_RAW_RESPONSES']"
		[Register ("INCLUDE_RAW_RESPONSES")]
		public static global::Xamarin.FacebookBinding.LoggingBehavior IncludeRawResponses {
			get {
				if (INCLUDE_RAW_RESPONSES_jfieldId == IntPtr.Zero)
					INCLUDE_RAW_RESPONSES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INCLUDE_RAW_RESPONSES", "Lcom/facebook/LoggingBehavior;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INCLUDE_RAW_RESPONSES_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.LoggingBehavior> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (INCLUDE_RAW_RESPONSES_jfieldId == IntPtr.Zero)
					INCLUDE_RAW_RESPONSES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INCLUDE_RAW_RESPONSES", "Lcom/facebook/LoggingBehavior;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, INCLUDE_RAW_RESPONSES_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr REQUESTS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='LoggingBehavior']/field[@name='REQUESTS']"
		[Register ("REQUESTS")]
		public static global::Xamarin.FacebookBinding.LoggingBehavior Requests {
			get {
				if (REQUESTS_jfieldId == IntPtr.Zero)
					REQUESTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REQUESTS", "Lcom/facebook/LoggingBehavior;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REQUESTS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.LoggingBehavior> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (REQUESTS_jfieldId == IntPtr.Zero)
					REQUESTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REQUESTS", "Lcom/facebook/LoggingBehavior;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, REQUESTS_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/LoggingBehavior", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LoggingBehavior); }
		}

		internal LoggingBehavior (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='LoggingBehavior']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/facebook/LoggingBehavior;", "")]
		public static global::Xamarin.FacebookBinding.LoggingBehavior ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/facebook/LoggingBehavior;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Xamarin.FacebookBinding.LoggingBehavior __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.LoggingBehavior> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='LoggingBehavior']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/facebook/LoggingBehavior;", "")]
		public static global::Xamarin.FacebookBinding.LoggingBehavior[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/facebook/LoggingBehavior;");
			return (global::Xamarin.FacebookBinding.LoggingBehavior[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Xamarin.FacebookBinding.LoggingBehavior));
		}

	}
}
