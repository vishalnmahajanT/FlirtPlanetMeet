using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.internal']/class[@name='SessionAuthorizationType']"
	[global::Android.Runtime.Register ("com/facebook/internal/SessionAuthorizationType", DoNotGenerateAcw=true)]
	public sealed partial class SessionAuthorizationType : global::Java.Lang.Enum {


		static IntPtr PUBLISH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.internal']/class[@name='SessionAuthorizationType']/field[@name='PUBLISH']"
		[Register ("PUBLISH")]
		public static global::Xamarin.FacebookBinding.Internal.SessionAuthorizationType Publish {
			get {
				if (PUBLISH_jfieldId == IntPtr.Zero)
					PUBLISH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PUBLISH", "Lcom/facebook/internal/SessionAuthorizationType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PUBLISH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Internal.SessionAuthorizationType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PUBLISH_jfieldId == IntPtr.Zero)
					PUBLISH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PUBLISH", "Lcom/facebook/internal/SessionAuthorizationType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, PUBLISH_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr READ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.internal']/class[@name='SessionAuthorizationType']/field[@name='READ']"
		[Register ("READ")]
		public static global::Xamarin.FacebookBinding.Internal.SessionAuthorizationType Read {
			get {
				if (READ_jfieldId == IntPtr.Zero)
					READ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "READ", "Lcom/facebook/internal/SessionAuthorizationType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, READ_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Internal.SessionAuthorizationType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (READ_jfieldId == IntPtr.Zero)
					READ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "READ", "Lcom/facebook/internal/SessionAuthorizationType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, READ_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/internal/SessionAuthorizationType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SessionAuthorizationType); }
		}

		internal SessionAuthorizationType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='SessionAuthorizationType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/facebook/internal/SessionAuthorizationType;", "")]
		public static global::Xamarin.FacebookBinding.Internal.SessionAuthorizationType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/facebook/internal/SessionAuthorizationType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Xamarin.FacebookBinding.Internal.SessionAuthorizationType __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Internal.SessionAuthorizationType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='SessionAuthorizationType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/facebook/internal/SessionAuthorizationType;", "")]
		public static global::Xamarin.FacebookBinding.Internal.SessionAuthorizationType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/facebook/internal/SessionAuthorizationType;");
			return (global::Xamarin.FacebookBinding.Internal.SessionAuthorizationType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Xamarin.FacebookBinding.Internal.SessionAuthorizationType));
		}

	}
}
