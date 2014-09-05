using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='Settings']"
	[global::Android.Runtime.Register ("com/facebook/Settings", DoNotGenerateAcw=true)]
	public sealed partial class Settings : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/Settings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Settings); }
		}

		internal Settings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='Settings']/constructor[@name='Settings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Settings () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Settings)) {
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

		static IntPtr id_getExecutor;
		static IntPtr id_setExecutor_Ljava_util_concurrent_Executor_;
		public static global::Java.Util.Concurrent.IExecutor Executor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Settings']/method[@name='getExecutor' and count(parameter)=0]"
			[Register ("getExecutor", "()Ljava/util/concurrent/Executor;", "GetGetExecutorHandler")]
			get {
				if (id_getExecutor == IntPtr.Zero)
					id_getExecutor = JNIEnv.GetStaticMethodID (class_ref, "getExecutor", "()Ljava/util/concurrent/Executor;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getExecutor), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Settings']/method[@name='setExecutor' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Executor']]"
			[Register ("setExecutor", "(Ljava/util/concurrent/Executor;)V", "GetSetExecutor_Ljava_util_concurrent_Executor_Handler")]
			set {
				if (id_setExecutor_Ljava_util_concurrent_Executor_ == IntPtr.Zero)
					id_setExecutor_Ljava_util_concurrent_Executor_ = JNIEnv.GetStaticMethodID (class_ref, "setExecutor", "(Ljava/util/concurrent/Executor;)V");
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setExecutor_Ljava_util_concurrent_Executor_, new JValue (value));
			}
		}

		static IntPtr id_getLoggingBehaviors;
		public static global::System.Collections.Generic.ICollection<global::Xamarin.FacebookBinding.LoggingBehavior> LoggingBehaviors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Settings']/method[@name='getLoggingBehaviors' and count(parameter)=0]"
			[Register ("getLoggingBehaviors", "()Ljava/util/Set;", "GetGetLoggingBehaviorsHandler")]
			get {
				if (id_getLoggingBehaviors == IntPtr.Zero)
					id_getLoggingBehaviors = JNIEnv.GetStaticMethodID (class_ref, "getLoggingBehaviors", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<global::Xamarin.FacebookBinding.LoggingBehavior>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLoggingBehaviors), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getMigrationBundle;
		public static string MigrationBundle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Settings']/method[@name='getMigrationBundle' and count(parameter)=0]"
			[Register ("getMigrationBundle", "()Ljava/lang/String;", "GetGetMigrationBundleHandler")]
			get {
				if (id_getMigrationBundle == IntPtr.Zero)
					id_getMigrationBundle = JNIEnv.GetStaticMethodID (class_ref, "getMigrationBundle", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMigrationBundle), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getSdkVersion;
		public static string SdkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Settings']/method[@name='getSdkVersion' and count(parameter)=0]"
			[Register ("getSdkVersion", "()Ljava/lang/String;", "GetGetSdkVersionHandler")]
			get {
				if (id_getSdkVersion == IntPtr.Zero)
					id_getSdkVersion = JNIEnv.GetStaticMethodID (class_ref, "getSdkVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSdkVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getShouldAutoPublishInstall;
		static IntPtr id_setShouldAutoPublishInstall_Z;
		public static bool ShouldAutoPublishInstall {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Settings']/method[@name='getShouldAutoPublishInstall' and count(parameter)=0]"
			[Register ("getShouldAutoPublishInstall", "()Z", "GetGetShouldAutoPublishInstallHandler")]
			get {
				if (id_getShouldAutoPublishInstall == IntPtr.Zero)
					id_getShouldAutoPublishInstall = JNIEnv.GetStaticMethodID (class_ref, "getShouldAutoPublishInstall", "()Z");
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_getShouldAutoPublishInstall);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Settings']/method[@name='setShouldAutoPublishInstall' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShouldAutoPublishInstall", "(Z)V", "GetSetShouldAutoPublishInstall_ZHandler")]
			set {
				if (id_setShouldAutoPublishInstall_Z == IntPtr.Zero)
					id_setShouldAutoPublishInstall_Z = JNIEnv.GetStaticMethodID (class_ref, "setShouldAutoPublishInstall", "(Z)V");
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setShouldAutoPublishInstall_Z, new JValue (value));
			}
		}

		static IntPtr id_addLoggingBehavior_Lcom_facebook_LoggingBehavior_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Settings']/method[@name='addLoggingBehavior' and count(parameter)=1 and parameter[1][@type='com.facebook.LoggingBehavior']]"
		[Register ("addLoggingBehavior", "(Lcom/facebook/LoggingBehavior;)V", "")]
		public static void AddLoggingBehavior (global::Xamarin.FacebookBinding.LoggingBehavior p0)
		{
			if (id_addLoggingBehavior_Lcom_facebook_LoggingBehavior_ == IntPtr.Zero)
				id_addLoggingBehavior_Lcom_facebook_LoggingBehavior_ = JNIEnv.GetStaticMethodID (class_ref, "addLoggingBehavior", "(Lcom/facebook/LoggingBehavior;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_addLoggingBehavior_Lcom_facebook_LoggingBehavior_, new JValue (p0));
		}

		static IntPtr id_clearLoggingBehaviors;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Settings']/method[@name='clearLoggingBehaviors' and count(parameter)=0]"
		[Register ("clearLoggingBehaviors", "()V", "")]
		public static void ClearLoggingBehaviors ()
		{
			if (id_clearLoggingBehaviors == IntPtr.Zero)
				id_clearLoggingBehaviors = JNIEnv.GetStaticMethodID (class_ref, "clearLoggingBehaviors", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_clearLoggingBehaviors);
		}

		static IntPtr id_getAttributionId_Landroid_content_ContentResolver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Settings']/method[@name='getAttributionId' and count(parameter)=1 and parameter[1][@type='android.content.ContentResolver']]"
		[Register ("getAttributionId", "(Landroid/content/ContentResolver;)Ljava/lang/String;", "")]
		public static string GetAttributionId (global::Android.Content.ContentResolver p0)
		{
			if (id_getAttributionId_Landroid_content_ContentResolver_ == IntPtr.Zero)
				id_getAttributionId_Landroid_content_ContentResolver_ = JNIEnv.GetStaticMethodID (class_ref, "getAttributionId", "(Landroid/content/ContentResolver;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAttributionId_Landroid_content_ContentResolver_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_isLoggingBehaviorEnabled_Lcom_facebook_LoggingBehavior_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Settings']/method[@name='isLoggingBehaviorEnabled' and count(parameter)=1 and parameter[1][@type='com.facebook.LoggingBehavior']]"
		[Register ("isLoggingBehaviorEnabled", "(Lcom/facebook/LoggingBehavior;)Z", "")]
		public static bool IsLoggingBehaviorEnabled (global::Xamarin.FacebookBinding.LoggingBehavior p0)
		{
			if (id_isLoggingBehaviorEnabled_Lcom_facebook_LoggingBehavior_ == IntPtr.Zero)
				id_isLoggingBehaviorEnabled_Lcom_facebook_LoggingBehavior_ = JNIEnv.GetStaticMethodID (class_ref, "isLoggingBehaviorEnabled", "(Lcom/facebook/LoggingBehavior;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isLoggingBehaviorEnabled_Lcom_facebook_LoggingBehavior_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_publishInstallAndWait_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Settings']/method[@name='publishInstallAndWait' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("publishInstallAndWait", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static bool PublishInstallAndWait (global::Android.Content.Context p0, string p1)
		{
			if (id_publishInstallAndWait_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_publishInstallAndWait_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "publishInstallAndWait", "(Landroid/content/Context;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_publishInstallAndWait_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_publishInstallAndWaitForResponse_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Settings']/method[@name='publishInstallAndWaitForResponse' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("publishInstallAndWaitForResponse", "(Landroid/content/Context;Ljava/lang/String;)Lcom/facebook/Response;", "")]
		public static global::Xamarin.FacebookBinding.Response PublishInstallAndWaitForResponse (global::Android.Content.Context p0, string p1)
		{
			if (id_publishInstallAndWaitForResponse_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_publishInstallAndWaitForResponse_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "publishInstallAndWaitForResponse", "(Landroid/content/Context;Ljava/lang/String;)Lcom/facebook/Response;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Xamarin.FacebookBinding.Response __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response> (JNIEnv.CallStaticObjectMethod  (class_ref, id_publishInstallAndWaitForResponse_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_publishInstallAsync_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Settings']/method[@name='publishInstallAsync' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("publishInstallAsync", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static void PublishInstallAsync (global::Android.Content.Context p0, string p1)
		{
			if (id_publishInstallAsync_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_publishInstallAsync_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "publishInstallAsync", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_publishInstallAsync_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_publishInstallAsync_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_Request_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Settings']/method[@name='publishInstallAsync' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.facebook.Request.Callback']]"
		[Register ("publishInstallAsync", "(Landroid/content/Context;Ljava/lang/String;Lcom/facebook/Request$Callback;)V", "")]
		public static void PublishInstallAsync (global::Android.Content.Context p0, string p1, global::Xamarin.FacebookBinding.Request.ICallback p2)
		{
			if (id_publishInstallAsync_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_Request_Callback_ == IntPtr.Zero)
				id_publishInstallAsync_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_Request_Callback_ = JNIEnv.GetStaticMethodID (class_ref, "publishInstallAsync", "(Landroid/content/Context;Ljava/lang/String;Lcom/facebook/Request$Callback;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_publishInstallAsync_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_Request_Callback_, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_removeLoggingBehavior_Lcom_facebook_LoggingBehavior_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Settings']/method[@name='removeLoggingBehavior' and count(parameter)=1 and parameter[1][@type='com.facebook.LoggingBehavior']]"
		[Register ("removeLoggingBehavior", "(Lcom/facebook/LoggingBehavior;)V", "")]
		public static void RemoveLoggingBehavior (global::Xamarin.FacebookBinding.LoggingBehavior p0)
		{
			if (id_removeLoggingBehavior_Lcom_facebook_LoggingBehavior_ == IntPtr.Zero)
				id_removeLoggingBehavior_Lcom_facebook_LoggingBehavior_ = JNIEnv.GetStaticMethodID (class_ref, "removeLoggingBehavior", "(Lcom/facebook/LoggingBehavior;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_removeLoggingBehavior_Lcom_facebook_LoggingBehavior_, new JValue (p0));
		}

	}
}
