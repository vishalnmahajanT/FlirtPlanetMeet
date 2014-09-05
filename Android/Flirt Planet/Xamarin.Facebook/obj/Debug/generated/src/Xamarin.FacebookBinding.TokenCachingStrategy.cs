using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']"
	[global::Android.Runtime.Register ("com/facebook/TokenCachingStrategy", DoNotGenerateAcw=true)]
	public abstract partial class TokenCachingStrategy : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/field[@name='EXPIRATION_DATE_KEY']"
		[Register ("EXPIRATION_DATE_KEY")]
		public const string ExpirationDateKey = (string) "com.facebook.TokenCachingStrategy.ExpirationDate";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/field[@name='LAST_REFRESH_DATE_KEY']"
		[Register ("LAST_REFRESH_DATE_KEY")]
		public const string LastRefreshDateKey = (string) "com.facebook.TokenCachingStrategy.LastRefreshDate";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/field[@name='PERMISSIONS_KEY']"
		[Register ("PERMISSIONS_KEY")]
		public const string PermissionsKey = (string) "com.facebook.TokenCachingStrategy.Permissions";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/field[@name='TOKEN_KEY']"
		[Register ("TOKEN_KEY")]
		public const string TokenKey = (string) "com.facebook.TokenCachingStrategy.Token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/field[@name='TOKEN_SOURCE_KEY']"
		[Register ("TOKEN_SOURCE_KEY")]
		public const string TokenSourceKey = (string) "com.facebook.TokenCachingStrategy.AccessTokenSource";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/field[@name='USER_FBID_KEY']"
		[Register ("USER_FBID_KEY")]
		public const string UserFbidKey = (string) "com.facebook.TokenCachingStrategy.UserFBID";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/TokenCachingStrategy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TokenCachingStrategy); }
		}

		protected TokenCachingStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/constructor[@name='TokenCachingStrategy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public TokenCachingStrategy () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (TokenCachingStrategy)) {
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

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.TokenCachingStrategy __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TokenCachingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public abstract void Clear ();

		static IntPtr id_getExpirationDate_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/method[@name='getExpirationDate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getExpirationDate", "(Landroid/os/Bundle;)Ljava/util/Date;", "")]
		public static global::Java.Util.Date GetExpirationDate (global::Android.OS.Bundle p0)
		{
			if (id_getExpirationDate_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getExpirationDate_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "getExpirationDate", "(Landroid/os/Bundle;)Ljava/util/Date;");
			global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getExpirationDate_Landroid_os_Bundle_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getExpirationMilliseconds_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/method[@name='getExpirationMilliseconds' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getExpirationMilliseconds", "(Landroid/os/Bundle;)J", "")]
		public static long GetExpirationMilliseconds (global::Android.OS.Bundle p0)
		{
			if (id_getExpirationMilliseconds_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getExpirationMilliseconds_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "getExpirationMilliseconds", "(Landroid/os/Bundle;)J");
			long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getExpirationMilliseconds_Landroid_os_Bundle_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_getLastRefreshDate_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/method[@name='getLastRefreshDate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getLastRefreshDate", "(Landroid/os/Bundle;)Ljava/util/Date;", "")]
		public static global::Java.Util.Date GetLastRefreshDate (global::Android.OS.Bundle p0)
		{
			if (id_getLastRefreshDate_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getLastRefreshDate_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "getLastRefreshDate", "(Landroid/os/Bundle;)Ljava/util/Date;");
			global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLastRefreshDate_Landroid_os_Bundle_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getLastRefreshMilliseconds_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/method[@name='getLastRefreshMilliseconds' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getLastRefreshMilliseconds", "(Landroid/os/Bundle;)J", "")]
		public static long GetLastRefreshMilliseconds (global::Android.OS.Bundle p0)
		{
			if (id_getLastRefreshMilliseconds_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getLastRefreshMilliseconds_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "getLastRefreshMilliseconds", "(Landroid/os/Bundle;)J");
			long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getLastRefreshMilliseconds_Landroid_os_Bundle_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_getPermissions_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/method[@name='getPermissions' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getPermissions", "(Landroid/os/Bundle;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<string> GetPermissions (global::Android.OS.Bundle p0)
		{
			if (id_getPermissions_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getPermissions_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "getPermissions", "(Landroid/os/Bundle;)Ljava/util/List;");
			global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPermissions_Landroid_os_Bundle_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getSource_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/method[@name='getSource' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getSource", "(Landroid/os/Bundle;)Lcom/facebook/AccessTokenSource;", "")]
		public static global::Xamarin.FacebookBinding.AccessTokenSource GetSource (global::Android.OS.Bundle p0)
		{
			if (id_getSource_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getSource_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "getSource", "(Landroid/os/Bundle;)Lcom/facebook/AccessTokenSource;");
			global::Xamarin.FacebookBinding.AccessTokenSource __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.AccessTokenSource> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSource_Landroid_os_Bundle_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getToken_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/method[@name='getToken' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getToken", "(Landroid/os/Bundle;)Ljava/lang/String;", "")]
		public static string GetToken (global::Android.OS.Bundle p0)
		{
			if (id_getToken_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getToken_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "getToken", "(Landroid/os/Bundle;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getToken_Landroid_os_Bundle_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_hasTokenInformation_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/method[@name='hasTokenInformation' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("hasTokenInformation", "(Landroid/os/Bundle;)Z", "")]
		public static bool HasTokenInformation (global::Android.OS.Bundle p0)
		{
			if (id_hasTokenInformation_Landroid_os_Bundle_ == IntPtr.Zero)
				id_hasTokenInformation_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "hasTokenInformation", "(Landroid/os/Bundle;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasTokenInformation_Landroid_os_Bundle_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_load;
#pragma warning disable 0169
		static Delegate GetLoadHandler ()
		{
			if (cb_load == null)
				cb_load = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Load);
			return cb_load;
		}

		static IntPtr n_Load (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.TokenCachingStrategy __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TokenCachingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Load ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/method[@name='load' and count(parameter)=0]"
		[Register ("load", "()Landroid/os/Bundle;", "GetLoadHandler")]
		public abstract global::Android.OS.Bundle Load ();

		static IntPtr id_putExpirationDate_Landroid_os_Bundle_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/method[@name='putExpirationDate' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='java.util.Date']]"
		[Register ("putExpirationDate", "(Landroid/os/Bundle;Ljava/util/Date;)V", "")]
		public static void PutExpirationDate (global::Android.OS.Bundle p0, global::Java.Util.Date p1)
		{
			if (id_putExpirationDate_Landroid_os_Bundle_Ljava_util_Date_ == IntPtr.Zero)
				id_putExpirationDate_Landroid_os_Bundle_Ljava_util_Date_ = JNIEnv.GetStaticMethodID (class_ref, "putExpirationDate", "(Landroid/os/Bundle;Ljava/util/Date;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_putExpirationDate_Landroid_os_Bundle_Ljava_util_Date_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_putExpirationMilliseconds_Landroid_os_Bundle_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/method[@name='putExpirationMilliseconds' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='long']]"
		[Register ("putExpirationMilliseconds", "(Landroid/os/Bundle;J)V", "")]
		public static void PutExpirationMilliseconds (global::Android.OS.Bundle p0, long p1)
		{
			if (id_putExpirationMilliseconds_Landroid_os_Bundle_J == IntPtr.Zero)
				id_putExpirationMilliseconds_Landroid_os_Bundle_J = JNIEnv.GetStaticMethodID (class_ref, "putExpirationMilliseconds", "(Landroid/os/Bundle;J)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_putExpirationMilliseconds_Landroid_os_Bundle_J, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_putLastRefreshDate_Landroid_os_Bundle_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/method[@name='putLastRefreshDate' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='java.util.Date']]"
		[Register ("putLastRefreshDate", "(Landroid/os/Bundle;Ljava/util/Date;)V", "")]
		public static void PutLastRefreshDate (global::Android.OS.Bundle p0, global::Java.Util.Date p1)
		{
			if (id_putLastRefreshDate_Landroid_os_Bundle_Ljava_util_Date_ == IntPtr.Zero)
				id_putLastRefreshDate_Landroid_os_Bundle_Ljava_util_Date_ = JNIEnv.GetStaticMethodID (class_ref, "putLastRefreshDate", "(Landroid/os/Bundle;Ljava/util/Date;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_putLastRefreshDate_Landroid_os_Bundle_Ljava_util_Date_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_putLastRefreshMilliseconds_Landroid_os_Bundle_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/method[@name='putLastRefreshMilliseconds' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='long']]"
		[Register ("putLastRefreshMilliseconds", "(Landroid/os/Bundle;J)V", "")]
		public static void PutLastRefreshMilliseconds (global::Android.OS.Bundle p0, long p1)
		{
			if (id_putLastRefreshMilliseconds_Landroid_os_Bundle_J == IntPtr.Zero)
				id_putLastRefreshMilliseconds_Landroid_os_Bundle_J = JNIEnv.GetStaticMethodID (class_ref, "putLastRefreshMilliseconds", "(Landroid/os/Bundle;J)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_putLastRefreshMilliseconds_Landroid_os_Bundle_J, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_putPermissions_Landroid_os_Bundle_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/method[@name='putPermissions' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='java.util.List']]"
		[Register ("putPermissions", "(Landroid/os/Bundle;Ljava/util/List;)V", "")]
		public static void PutPermissions (global::Android.OS.Bundle p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_putPermissions_Landroid_os_Bundle_Ljava_util_List_ == IntPtr.Zero)
				id_putPermissions_Landroid_os_Bundle_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "putPermissions", "(Landroid/os/Bundle;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_putPermissions_Landroid_os_Bundle_Ljava_util_List_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_putSource_Landroid_os_Bundle_Lcom_facebook_AccessTokenSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/method[@name='putSource' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.facebook.AccessTokenSource']]"
		[Register ("putSource", "(Landroid/os/Bundle;Lcom/facebook/AccessTokenSource;)V", "")]
		public static void PutSource (global::Android.OS.Bundle p0, global::Xamarin.FacebookBinding.AccessTokenSource p1)
		{
			if (id_putSource_Landroid_os_Bundle_Lcom_facebook_AccessTokenSource_ == IntPtr.Zero)
				id_putSource_Landroid_os_Bundle_Lcom_facebook_AccessTokenSource_ = JNIEnv.GetStaticMethodID (class_ref, "putSource", "(Landroid/os/Bundle;Lcom/facebook/AccessTokenSource;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_putSource_Landroid_os_Bundle_Lcom_facebook_AccessTokenSource_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_putToken_Landroid_os_Bundle_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/method[@name='putToken' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='java.lang.String']]"
		[Register ("putToken", "(Landroid/os/Bundle;Ljava/lang/String;)V", "")]
		public static void PutToken (global::Android.OS.Bundle p0, string p1)
		{
			if (id_putToken_Landroid_os_Bundle_Ljava_lang_String_ == IntPtr.Zero)
				id_putToken_Landroid_os_Bundle_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "putToken", "(Landroid/os/Bundle;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_putToken_Landroid_os_Bundle_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_save_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSave_Landroid_os_Bundle_Handler ()
		{
			if (cb_save_Landroid_os_Bundle_ == null)
				cb_save_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Save_Landroid_os_Bundle_);
			return cb_save_Landroid_os_Bundle_;
		}

		static void n_Save_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.TokenCachingStrategy __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TokenCachingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Save (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/method[@name='save' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("save", "(Landroid/os/Bundle;)V", "GetSave_Landroid_os_Bundle_Handler")]
		public abstract void Save (global::Android.OS.Bundle p0);

	}

	[global::Android.Runtime.Register ("com/facebook/TokenCachingStrategy", DoNotGenerateAcw=true)]
	internal partial class TokenCachingStrategyInvoker : TokenCachingStrategy {

		public TokenCachingStrategyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (TokenCachingStrategyInvoker); }
		}

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public override void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_clear);
		}

		static IntPtr id_load;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/method[@name='load' and count(parameter)=0]"
		[Register ("load", "()Landroid/os/Bundle;", "GetLoadHandler")]
		public override global::Android.OS.Bundle Load ()
		{
			if (id_load == IntPtr.Zero)
				id_load = JNIEnv.GetMethodID (class_ref, "load", "()Landroid/os/Bundle;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_load), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_save_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TokenCachingStrategy']/method[@name='save' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("save", "(Landroid/os/Bundle;)V", "GetSave_Landroid_os_Bundle_Handler")]
		public override void Save (global::Android.OS.Bundle p0)
		{
			if (id_save_Landroid_os_Bundle_ == IntPtr.Zero)
				id_save_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "save", "(Landroid/os/Bundle;)V");
			JNIEnv.CallVoidMethod  (Handle, id_save_Landroid_os_Bundle_, new JValue (p0));
		}

	}

}
