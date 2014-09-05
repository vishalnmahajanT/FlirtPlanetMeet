using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='AccessToken']"
	[global::Android.Runtime.Register ("com/facebook/AccessToken", DoNotGenerateAcw=true)]
	public sealed partial class AccessToken : global::Java.Lang.Object, global::Java.IO.ISerializable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='AccessToken.SerializationProxyV1']"
		[global::Android.Runtime.Register ("com/facebook/AccessToken$SerializationProxyV1", DoNotGenerateAcw=true)]
		public partial class SerializationProxyV1 : global::Java.Lang.Object, global::Java.IO.ISerializable {

			protected SerializationProxyV1 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/AccessToken", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AccessToken); }
		}

		internal AccessToken (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getExpires;
		public global::Java.Util.Date Expires {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='AccessToken']/method[@name='getExpires' and count(parameter)=0]"
			[Register ("getExpires", "()Ljava/util/Date;", "GetGetExpiresHandler")]
			get {
				if (id_getExpires == IntPtr.Zero)
					id_getExpires = JNIEnv.GetMethodID (class_ref, "getExpires", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getExpires), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getLastRefresh;
		public global::Java.Util.Date LastRefresh {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='AccessToken']/method[@name='getLastRefresh' and count(parameter)=0]"
			[Register ("getLastRefresh", "()Ljava/util/Date;", "GetGetLastRefreshHandler")]
			get {
				if (id_getLastRefresh == IntPtr.Zero)
					id_getLastRefresh = JNIEnv.GetMethodID (class_ref, "getLastRefresh", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getLastRefresh), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getPermissions;
		public global::System.Collections.Generic.IList<string> Permissions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='AccessToken']/method[@name='getPermissions' and count(parameter)=0]"
			[Register ("getPermissions", "()Ljava/util/List;", "GetGetPermissionsHandler")]
			get {
				if (id_getPermissions == IntPtr.Zero)
					id_getPermissions = JNIEnv.GetMethodID (class_ref, "getPermissions", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPermissions), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getSource;
		public global::Xamarin.FacebookBinding.AccessTokenSource Source {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='AccessToken']/method[@name='getSource' and count(parameter)=0]"
			[Register ("getSource", "()Lcom/facebook/AccessTokenSource;", "GetGetSourceHandler")]
			get {
				if (id_getSource == IntPtr.Zero)
					id_getSource = JNIEnv.GetMethodID (class_ref, "getSource", "()Lcom/facebook/AccessTokenSource;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.AccessTokenSource> (JNIEnv.CallObjectMethod  (Handle, id_getSource), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getToken;
		public string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='AccessToken']/method[@name='getToken' and count(parameter)=0]"
			[Register ("getToken", "()Ljava/lang/String;", "GetGetTokenHandler")]
			get {
				if (id_getToken == IntPtr.Zero)
					id_getToken = JNIEnv.GetMethodID (class_ref, "getToken", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getToken), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_createFromExistingAccessToken_Ljava_lang_String_Ljava_util_Date_Ljava_util_Date_Lcom_facebook_AccessTokenSource_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='AccessToken']/method[@name='createFromExistingAccessToken' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Date'] and parameter[3][@type='java.util.Date'] and parameter[4][@type='com.facebook.AccessTokenSource'] and parameter[5][@type='java.util.List']]"
		[Register ("createFromExistingAccessToken", "(Ljava/lang/String;Ljava/util/Date;Ljava/util/Date;Lcom/facebook/AccessTokenSource;Ljava/util/List;)Lcom/facebook/AccessToken;", "")]
		public static global::Xamarin.FacebookBinding.AccessToken CreateFromExistingAccessToken (string p0, global::Java.Util.Date p1, global::Java.Util.Date p2, global::Xamarin.FacebookBinding.AccessTokenSource p3, global::System.Collections.Generic.IList<string> p4)
		{
			if (id_createFromExistingAccessToken_Ljava_lang_String_Ljava_util_Date_Ljava_util_Date_Lcom_facebook_AccessTokenSource_Ljava_util_List_ == IntPtr.Zero)
				id_createFromExistingAccessToken_Ljava_lang_String_Ljava_util_Date_Ljava_util_Date_Lcom_facebook_AccessTokenSource_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "createFromExistingAccessToken", "(Ljava/lang/String;Ljava/util/Date;Ljava/util/Date;Lcom/facebook/AccessTokenSource;Ljava/util/List;)Lcom/facebook/AccessToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p4 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p4);
			global::Xamarin.FacebookBinding.AccessToken __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.AccessToken> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFromExistingAccessToken_Ljava_lang_String_Ljava_util_Date_Ljava_util_Date_Lcom_facebook_AccessTokenSource_Ljava_util_List_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (native_p4)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p4);
			return __ret;
		}

		static IntPtr id_createFromNativeLinkingIntent_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='AccessToken']/method[@name='createFromNativeLinkingIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("createFromNativeLinkingIntent", "(Landroid/content/Intent;)Lcom/facebook/AccessToken;", "")]
		public static global::Xamarin.FacebookBinding.AccessToken CreateFromNativeLinkingIntent (global::Android.Content.Intent p0)
		{
			if (id_createFromNativeLinkingIntent_Landroid_content_Intent_ == IntPtr.Zero)
				id_createFromNativeLinkingIntent_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "createFromNativeLinkingIntent", "(Landroid/content/Intent;)Lcom/facebook/AccessToken;");
			global::Xamarin.FacebookBinding.AccessToken __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.AccessToken> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFromNativeLinkingIntent_Landroid_content_Intent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
