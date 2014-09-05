using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='SessionDefaultAudience']"
	[global::Android.Runtime.Register ("com/facebook/SessionDefaultAudience", DoNotGenerateAcw=true)]
	public sealed partial class SessionDefaultAudience : global::Java.Lang.Enum {


		static IntPtr EVERYONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='SessionDefaultAudience']/field[@name='EVERYONE']"
		[Register ("EVERYONE")]
		public static global::Xamarin.FacebookBinding.SessionDefaultAudience Everyone {
			get {
				if (EVERYONE_jfieldId == IntPtr.Zero)
					EVERYONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVERYONE", "Lcom/facebook/SessionDefaultAudience;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EVERYONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionDefaultAudience> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EVERYONE_jfieldId == IntPtr.Zero)
					EVERYONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVERYONE", "Lcom/facebook/SessionDefaultAudience;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EVERYONE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr FRIENDS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='SessionDefaultAudience']/field[@name='FRIENDS']"
		[Register ("FRIENDS")]
		public static global::Xamarin.FacebookBinding.SessionDefaultAudience Friends {
			get {
				if (FRIENDS_jfieldId == IntPtr.Zero)
					FRIENDS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FRIENDS", "Lcom/facebook/SessionDefaultAudience;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FRIENDS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionDefaultAudience> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FRIENDS_jfieldId == IntPtr.Zero)
					FRIENDS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FRIENDS", "Lcom/facebook/SessionDefaultAudience;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, FRIENDS_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr NONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='SessionDefaultAudience']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Xamarin.FacebookBinding.SessionDefaultAudience None {
			get {
				if (NONE_jfieldId == IntPtr.Zero)
					NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/facebook/SessionDefaultAudience;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionDefaultAudience> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NONE_jfieldId == IntPtr.Zero)
					NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/facebook/SessionDefaultAudience;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, NONE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr ONLY_ME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='SessionDefaultAudience']/field[@name='ONLY_ME']"
		[Register ("ONLY_ME")]
		public static global::Xamarin.FacebookBinding.SessionDefaultAudience OnlyMe {
			get {
				if (ONLY_ME_jfieldId == IntPtr.Zero)
					ONLY_ME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ONLY_ME", "Lcom/facebook/SessionDefaultAudience;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ONLY_ME_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionDefaultAudience> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ONLY_ME_jfieldId == IntPtr.Zero)
					ONLY_ME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ONLY_ME", "Lcom/facebook/SessionDefaultAudience;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, ONLY_ME_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/SessionDefaultAudience", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SessionDefaultAudience); }
		}

		internal SessionDefaultAudience (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='SessionDefaultAudience']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/facebook/SessionDefaultAudience;", "")]
		public static global::Xamarin.FacebookBinding.SessionDefaultAudience ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/facebook/SessionDefaultAudience;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Xamarin.FacebookBinding.SessionDefaultAudience __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionDefaultAudience> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='SessionDefaultAudience']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/facebook/SessionDefaultAudience;", "")]
		public static global::Xamarin.FacebookBinding.SessionDefaultAudience[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/facebook/SessionDefaultAudience;");
			return (global::Xamarin.FacebookBinding.SessionDefaultAudience[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Xamarin.FacebookBinding.SessionDefaultAudience));
		}

	}
}
