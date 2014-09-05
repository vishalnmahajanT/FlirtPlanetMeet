using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.internal']/class[@name='Utility']"
	[global::Android.Runtime.Register ("com/facebook/internal/Utility", DoNotGenerateAcw=true)]
	public sealed partial class Utility : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.internal']/class[@name='Utility']/field[@name='DEFAULT_STREAM_BUFFER_SIZE']"
		[Register ("DEFAULT_STREAM_BUFFER_SIZE")]
		public const int DefaultStreamBufferSize = (int) 8192;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/internal/Utility", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Utility); }
		}

		internal Utility (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.internal']/class[@name='Utility']/constructor[@name='Utility' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Utility () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Utility)) {
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

		static IntPtr id_arrayList_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Utility']/method[@name='arrayList' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("arrayList", "([Ljava/lang/Object;)Ljava/util/ArrayList;", "")]
		public static global::System.Collections.IList ArrayList (params global:: Java.Lang.Object[] p0)
		{
			if (id_arrayList_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_arrayList_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "arrayList", "([Ljava/lang/Object;)Ljava/util/ArrayList;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_arrayList_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_buildUri_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Utility']/method[@name='buildUri' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("buildUri", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/net/Uri;", "")]
		public static global::Android.Net.Uri BuildUri (string p0, string p1, global::Android.OS.Bundle p2)
		{
			if (id_buildUri_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_buildUri_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "buildUri", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/net/Uri;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_buildUri_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_, new JValue (native_p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_clearFacebookCookies_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Utility']/method[@name='clearFacebookCookies' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearFacebookCookies", "(Landroid/content/Context;)V", "")]
		public static void ClearFacebookCookies (global::Android.Content.Context p0)
		{
			if (id_clearFacebookCookies_Landroid_content_Context_ == IntPtr.Zero)
				id_clearFacebookCookies_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "clearFacebookCookies", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_clearFacebookCookies_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_closeQuietly_Ljava_io_Closeable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Utility']/method[@name='closeQuietly' and count(parameter)=1 and parameter[1][@type='java.io.Closeable']]"
		[Register ("closeQuietly", "(Ljava/io/Closeable;)V", "")]
		public static void CloseQuietly (global::Java.IO.ICloseable p0)
		{
			if (id_closeQuietly_Ljava_io_Closeable_ == IntPtr.Zero)
				id_closeQuietly_Ljava_io_Closeable_ = JNIEnv.GetStaticMethodID (class_ref, "closeQuietly", "(Ljava/io/Closeable;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_closeQuietly_Ljava_io_Closeable_, new JValue (p0));
		}

		static IntPtr id_disconnectQuietly_Ljava_net_URLConnection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Utility']/method[@name='disconnectQuietly' and count(parameter)=1 and parameter[1][@type='java.net.URLConnection']]"
		[Register ("disconnectQuietly", "(Ljava/net/URLConnection;)V", "")]
		public static void DisconnectQuietly (global::Java.Net.URLConnection p0)
		{
			if (id_disconnectQuietly_Ljava_net_URLConnection_ == IntPtr.Zero)
				id_disconnectQuietly_Ljava_net_URLConnection_ = JNIEnv.GetStaticMethodID (class_ref, "disconnectQuietly", "(Ljava/net/URLConnection;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_disconnectQuietly_Ljava_net_URLConnection_, new JValue (p0));
		}

		static IntPtr id_getMetadataApplicationId_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Utility']/method[@name='getMetadataApplicationId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getMetadataApplicationId", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetMetadataApplicationId (global::Android.Content.Context p0)
		{
			if (id_getMetadataApplicationId_Landroid_content_Context_ == IntPtr.Zero)
				id_getMetadataApplicationId_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getMetadataApplicationId", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMetadataApplicationId_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getStringPropertyAsJSON_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Utility']/method[@name='getStringPropertyAsJSON' and count(parameter)=3 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getStringPropertyAsJSON", "(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", "")]
		public static global::Java.Lang.Object GetStringPropertyAsJSON (global::Org.Json.JSONObject p0, string p1, string p2)
		{
			if (id_getStringPropertyAsJSON_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getStringPropertyAsJSON_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getStringPropertyAsJSON", "(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStringPropertyAsJSON_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static IntPtr id_isNullOrEmpty_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Utility']/method[@name='isNullOrEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isNullOrEmpty", "(Ljava/lang/String;)Z", "")]
		public static bool IsNullOrEmpty (string p0)
		{
			if (id_isNullOrEmpty_Ljava_lang_String_ == IntPtr.Zero)
				id_isNullOrEmpty_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isNullOrEmpty", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNullOrEmpty_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_isNullOrEmpty_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Utility']/method[@name='isNullOrEmpty' and count(parameter)=1 and parameter[1][@type='java.util.Collection']]"
		[Register ("isNullOrEmpty", "(Ljava/util/Collection;)Z", "")]
		public static bool IsNullOrEmpty (global::System.Collections.ICollection p0)
		{
			if (id_isNullOrEmpty_Ljava_util_Collection_ == IntPtr.Zero)
				id_isNullOrEmpty_Ljava_util_Collection_ = JNIEnv.GetStaticMethodID (class_ref, "isNullOrEmpty", "(Ljava/util/Collection;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNullOrEmpty_Ljava_util_Collection_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_isSubset_Ljava_util_Collection_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Utility']/method[@name='isSubset' and count(parameter)=2 and parameter[1][@type='java.util.Collection'] and parameter[2][@type='java.util.Collection']]"
		[Register ("isSubset", "(Ljava/util/Collection;Ljava/util/Collection;)Z", "")]
		public static bool IsSubset (global::System.Collections.ICollection p0, global::System.Collections.ICollection p1)
		{
			if (id_isSubset_Ljava_util_Collection_Ljava_util_Collection_ == IntPtr.Zero)
				id_isSubset_Ljava_util_Collection_Ljava_util_Collection_ = JNIEnv.GetStaticMethodID (class_ref, "isSubset", "(Ljava/util/Collection;Ljava/util/Collection;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p1);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSubset_Ljava_util_Collection_Ljava_util_Collection_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_logd_Ljava_lang_String_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Utility']/method[@name='logd' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("logd", "(Ljava/lang/String;Ljava/lang/Exception;)V", "")]
		public static void Logd (string p0, global::Java.Lang.Exception p1)
		{
			if (id_logd_Ljava_lang_String_Ljava_lang_Exception_ == IntPtr.Zero)
				id_logd_Ljava_lang_String_Ljava_lang_Exception_ = JNIEnv.GetStaticMethodID (class_ref, "logd", "(Ljava/lang/String;Ljava/lang/Exception;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_logd_Ljava_lang_String_Ljava_lang_Exception_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_logd_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Utility']/method[@name='logd' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("logd", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void Logd (string p0, string p1)
		{
			if (id_logd_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_logd_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "logd", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_logd_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_putObjectInBundle_Landroid_os_Bundle_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Utility']/method[@name='putObjectInBundle' and count(parameter)=3 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("putObjectInBundle", "(Landroid/os/Bundle;Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public static void PutObjectInBundle (global::Android.OS.Bundle p0, string p1, global::Java.Lang.Object p2)
		{
			if (id_putObjectInBundle_Landroid_os_Bundle_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_putObjectInBundle_Landroid_os_Bundle_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "putObjectInBundle", "(Landroid/os/Bundle;Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_putObjectInBundle_Landroid_os_Bundle_Ljava_lang_String_Ljava_lang_Object_, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_queryAppAttributionSupportAndWait_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Utility']/method[@name='queryAppAttributionSupportAndWait' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("queryAppAttributionSupportAndWait", "(Ljava/lang/String;)Z", "")]
		public static bool QueryAppAttributionSupportAndWait (string p0)
		{
			if (id_queryAppAttributionSupportAndWait_Ljava_lang_String_ == IntPtr.Zero)
				id_queryAppAttributionSupportAndWait_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "queryAppAttributionSupportAndWait", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_queryAppAttributionSupportAndWait_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_readStreamToString_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Utility']/method[@name='readStreamToString' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("readStreamToString", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static string ReadStreamToString (global::System.IO.Stream p0)
		{
			if (id_readStreamToString_Ljava_io_InputStream_ == IntPtr.Zero)
				id_readStreamToString_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "readStreamToString", "(Ljava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_readStreamToString_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_stringsEqualOrEmpty_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Utility']/method[@name='stringsEqualOrEmpty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("stringsEqualOrEmpty", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static bool StringsEqualOrEmpty (string p0, string p1)
		{
			if (id_stringsEqualOrEmpty_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_stringsEqualOrEmpty_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "stringsEqualOrEmpty", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_stringsEqualOrEmpty_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_unmodifiableCollection_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Utility']/method[@name='unmodifiableCollection' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("unmodifiableCollection", "([Ljava/lang/Object;)Ljava/util/Collection;", "")]
		public static global::System.Collections.ICollection UnmodifiableCollection (params global:: Java.Lang.Object[] p0)
		{
			if (id_unmodifiableCollection_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_unmodifiableCollection_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "unmodifiableCollection", "([Ljava/lang/Object;)Ljava/util/Collection;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::System.Collections.ICollection __ret = global::Android.Runtime.JavaCollection.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_unmodifiableCollection_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}
}
