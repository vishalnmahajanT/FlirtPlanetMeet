using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='AccessTokenSource']"
	[global::Android.Runtime.Register ("com/facebook/AccessTokenSource", DoNotGenerateAcw=true)]
	public sealed partial class AccessTokenSource : global::Java.Lang.Enum {


		static IntPtr CLIENT_TOKEN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='AccessTokenSource']/field[@name='CLIENT_TOKEN']"
		[Register ("CLIENT_TOKEN")]
		public static global::Xamarin.FacebookBinding.AccessTokenSource ClientToken {
			get {
				if (CLIENT_TOKEN_jfieldId == IntPtr.Zero)
					CLIENT_TOKEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIENT_TOKEN", "Lcom/facebook/AccessTokenSource;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLIENT_TOKEN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.AccessTokenSource> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CLIENT_TOKEN_jfieldId == IntPtr.Zero)
					CLIENT_TOKEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIENT_TOKEN", "Lcom/facebook/AccessTokenSource;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CLIENT_TOKEN_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr FACEBOOK_APPLICATION_NATIVE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='AccessTokenSource']/field[@name='FACEBOOK_APPLICATION_NATIVE']"
		[Register ("FACEBOOK_APPLICATION_NATIVE")]
		public static global::Xamarin.FacebookBinding.AccessTokenSource FacebookApplicationNative {
			get {
				if (FACEBOOK_APPLICATION_NATIVE_jfieldId == IntPtr.Zero)
					FACEBOOK_APPLICATION_NATIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FACEBOOK_APPLICATION_NATIVE", "Lcom/facebook/AccessTokenSource;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FACEBOOK_APPLICATION_NATIVE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.AccessTokenSource> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FACEBOOK_APPLICATION_NATIVE_jfieldId == IntPtr.Zero)
					FACEBOOK_APPLICATION_NATIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FACEBOOK_APPLICATION_NATIVE", "Lcom/facebook/AccessTokenSource;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, FACEBOOK_APPLICATION_NATIVE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr FACEBOOK_APPLICATION_SERVICE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='AccessTokenSource']/field[@name='FACEBOOK_APPLICATION_SERVICE']"
		[Register ("FACEBOOK_APPLICATION_SERVICE")]
		public static global::Xamarin.FacebookBinding.AccessTokenSource FacebookApplicationService {
			get {
				if (FACEBOOK_APPLICATION_SERVICE_jfieldId == IntPtr.Zero)
					FACEBOOK_APPLICATION_SERVICE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FACEBOOK_APPLICATION_SERVICE", "Lcom/facebook/AccessTokenSource;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FACEBOOK_APPLICATION_SERVICE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.AccessTokenSource> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FACEBOOK_APPLICATION_SERVICE_jfieldId == IntPtr.Zero)
					FACEBOOK_APPLICATION_SERVICE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FACEBOOK_APPLICATION_SERVICE", "Lcom/facebook/AccessTokenSource;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, FACEBOOK_APPLICATION_SERVICE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr FACEBOOK_APPLICATION_WEB_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='AccessTokenSource']/field[@name='FACEBOOK_APPLICATION_WEB']"
		[Register ("FACEBOOK_APPLICATION_WEB")]
		public static global::Xamarin.FacebookBinding.AccessTokenSource FacebookApplicationWeb {
			get {
				if (FACEBOOK_APPLICATION_WEB_jfieldId == IntPtr.Zero)
					FACEBOOK_APPLICATION_WEB_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FACEBOOK_APPLICATION_WEB", "Lcom/facebook/AccessTokenSource;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FACEBOOK_APPLICATION_WEB_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.AccessTokenSource> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FACEBOOK_APPLICATION_WEB_jfieldId == IntPtr.Zero)
					FACEBOOK_APPLICATION_WEB_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FACEBOOK_APPLICATION_WEB", "Lcom/facebook/AccessTokenSource;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, FACEBOOK_APPLICATION_WEB_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr NONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='AccessTokenSource']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Xamarin.FacebookBinding.AccessTokenSource None {
			get {
				if (NONE_jfieldId == IntPtr.Zero)
					NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/facebook/AccessTokenSource;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.AccessTokenSource> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NONE_jfieldId == IntPtr.Zero)
					NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/facebook/AccessTokenSource;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, NONE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr TEST_USER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='AccessTokenSource']/field[@name='TEST_USER']"
		[Register ("TEST_USER")]
		public static global::Xamarin.FacebookBinding.AccessTokenSource TestUser {
			get {
				if (TEST_USER_jfieldId == IntPtr.Zero)
					TEST_USER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEST_USER", "Lcom/facebook/AccessTokenSource;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEST_USER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.AccessTokenSource> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TEST_USER_jfieldId == IntPtr.Zero)
					TEST_USER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEST_USER", "Lcom/facebook/AccessTokenSource;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, TEST_USER_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr WEB_VIEW_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='AccessTokenSource']/field[@name='WEB_VIEW']"
		[Register ("WEB_VIEW")]
		public static global::Xamarin.FacebookBinding.AccessTokenSource WebView {
			get {
				if (WEB_VIEW_jfieldId == IntPtr.Zero)
					WEB_VIEW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WEB_VIEW", "Lcom/facebook/AccessTokenSource;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WEB_VIEW_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.AccessTokenSource> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (WEB_VIEW_jfieldId == IntPtr.Zero)
					WEB_VIEW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WEB_VIEW", "Lcom/facebook/AccessTokenSource;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, WEB_VIEW_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/AccessTokenSource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AccessTokenSource); }
		}

		internal AccessTokenSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='AccessTokenSource']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/facebook/AccessTokenSource;", "")]
		public static global::Xamarin.FacebookBinding.AccessTokenSource ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/facebook/AccessTokenSource;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Xamarin.FacebookBinding.AccessTokenSource __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.AccessTokenSource> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='AccessTokenSource']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/facebook/AccessTokenSource;", "")]
		public static global::Xamarin.FacebookBinding.AccessTokenSource[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/facebook/AccessTokenSource;");
			return (global::Xamarin.FacebookBinding.AccessTokenSource[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Xamarin.FacebookBinding.AccessTokenSource));
		}

	}
}
