using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='HttpMethod']"
	[global::Android.Runtime.Register ("com/facebook/HttpMethod", DoNotGenerateAcw=true)]
	public sealed partial class HttpMethod : global::Java.Lang.Enum {


		static IntPtr DELETE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='HttpMethod']/field[@name='DELETE']"
		[Register ("DELETE")]
		public static global::Xamarin.FacebookBinding.HttpMethod Delete {
			get {
				if (DELETE_jfieldId == IntPtr.Zero)
					DELETE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DELETE", "Lcom/facebook/HttpMethod;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DELETE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.HttpMethod> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DELETE_jfieldId == IntPtr.Zero)
					DELETE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DELETE", "Lcom/facebook/HttpMethod;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DELETE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr GET_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='HttpMethod']/field[@name='GET']"
		[Register ("GET")]
		public static global::Xamarin.FacebookBinding.HttpMethod Get {
			get {
				if (GET_jfieldId == IntPtr.Zero)
					GET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GET", "Lcom/facebook/HttpMethod;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GET_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.HttpMethod> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (GET_jfieldId == IntPtr.Zero)
					GET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GET", "Lcom/facebook/HttpMethod;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, GET_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr POST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='HttpMethod']/field[@name='POST']"
		[Register ("POST")]
		public static global::Xamarin.FacebookBinding.HttpMethod Post {
			get {
				if (POST_jfieldId == IntPtr.Zero)
					POST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POST", "Lcom/facebook/HttpMethod;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, POST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.HttpMethod> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (POST_jfieldId == IntPtr.Zero)
					POST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POST", "Lcom/facebook/HttpMethod;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, POST_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/HttpMethod", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpMethod); }
		}

		internal HttpMethod (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='HttpMethod']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/facebook/HttpMethod;", "")]
		public static global::Xamarin.FacebookBinding.HttpMethod ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/facebook/HttpMethod;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Xamarin.FacebookBinding.HttpMethod __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.HttpMethod> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='HttpMethod']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/facebook/HttpMethod;", "")]
		public static global::Xamarin.FacebookBinding.HttpMethod[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/facebook/HttpMethod;");
			return (global::Xamarin.FacebookBinding.HttpMethod[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Xamarin.FacebookBinding.HttpMethod));
		}

	}
}
