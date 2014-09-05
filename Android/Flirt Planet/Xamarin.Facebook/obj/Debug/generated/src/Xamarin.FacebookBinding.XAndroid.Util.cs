using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding.XAndroid {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.android']/class[@name='Util']"
	[global::Android.Runtime.Register ("com/facebook/android/Util", DoNotGenerateAcw=true)]
	public sealed partial class Util : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/android/Util", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Util); }
		}

		internal Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.android']/class[@name='Util']/constructor[@name='Util' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Util () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Util)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static IntPtr id_decodeUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Util']/method[@name='decodeUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeUrl", "(Ljava/lang/String;)Landroid/os/Bundle;", "")]
		public static global::Android.OS.Bundle DecodeUrl (string p0)
		{
			if (id_decodeUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeUrl_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeUrl", "(Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeUrl_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_encodePostBody_Landroid_os_Bundle_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Util']/method[@name='encodePostBody' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='java.lang.String']]"
		[Register ("encodePostBody", "(Landroid/os/Bundle;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string EncodePostBody (global::Android.OS.Bundle p0, string p1)
		{
			if (id_encodePostBody_Landroid_os_Bundle_Ljava_lang_String_ == IntPtr.Zero)
				id_encodePostBody_Landroid_os_Bundle_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encodePostBody", "(Landroid/os/Bundle;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodePostBody_Landroid_os_Bundle_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_encodeUrl_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Util']/method[@name='encodeUrl' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("encodeUrl", "(Landroid/os/Bundle;)Ljava/lang/String;", "")]
		public static string EncodeUrl (global::Android.OS.Bundle p0)
		{
			if (id_encodeUrl_Landroid_os_Bundle_ == IntPtr.Zero)
				id_encodeUrl_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "encodeUrl", "(Landroid/os/Bundle;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeUrl_Landroid_os_Bundle_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_openUrl_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Util']/method[@name='openUrl' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("openUrl", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Ljava/lang/String;", "")]
		public static string OpenUrl (string p0, string p1, global::Android.OS.Bundle p2)
		{
			if (id_openUrl_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_openUrl_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "openUrl", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_openUrl_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_, new JValue (native_p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_parseJson_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Util']/method[@name='parseJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseJson", "(Ljava/lang/String;)Lorg/json/JSONObject;", "")]
		public static global::Org.Json.JSONObject ParseJson (string p0)
		{
			if (id_parseJson_Ljava_lang_String_ == IntPtr.Zero)
				id_parseJson_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseJson", "(Ljava/lang/String;)Lorg/json/JSONObject;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseJson_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_parseUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Util']/method[@name='parseUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseUrl", "(Ljava/lang/String;)Landroid/os/Bundle;", "")]
		public static global::Android.OS.Bundle ParseUrl (string p0)
		{
			if (id_parseUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_parseUrl_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseUrl", "(Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseUrl_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_showAlert_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Util']/method[@name='showAlert' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("showAlert", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void ShowAlert (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_showAlert_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_showAlert_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "showAlert", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_showAlert_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}
}
