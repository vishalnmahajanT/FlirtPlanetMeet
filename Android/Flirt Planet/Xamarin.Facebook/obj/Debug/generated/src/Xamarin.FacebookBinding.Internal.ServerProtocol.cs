using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.internal']/class[@name='ServerProtocol']"
	[global::Android.Runtime.Register ("com/facebook/internal/ServerProtocol", DoNotGenerateAcw=true)]
	public sealed partial class ServerProtocol : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.internal']/class[@name='ServerProtocol']/field[@name='BATCHED_REST_METHOD_URL_BASE']"
		[Register ("BATCHED_REST_METHOD_URL_BASE")]
		public const string BatchedRestMethodUrlBase = (string) "method/";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.internal']/class[@name='ServerProtocol']/field[@name='DIALOG_AUTHORITY']"
		[Register ("DIALOG_AUTHORITY")]
		public const string DialogAuthority = (string) "m.facebook.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.internal']/class[@name='ServerProtocol']/field[@name='DIALOG_PARAM_ACCESS_TOKEN']"
		[Register ("DIALOG_PARAM_ACCESS_TOKEN")]
		public const string DialogParamAccessToken = (string) "access_token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.internal']/class[@name='ServerProtocol']/field[@name='DIALOG_PARAM_APP_ID']"
		[Register ("DIALOG_PARAM_APP_ID")]
		public const string DialogParamAppId = (string) "app_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.internal']/class[@name='ServerProtocol']/field[@name='DIALOG_PARAM_CLIENT_ID']"
		[Register ("DIALOG_PARAM_CLIENT_ID")]
		public const string DialogParamClientId = (string) "client_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.internal']/class[@name='ServerProtocol']/field[@name='DIALOG_PARAM_DISPLAY']"
		[Register ("DIALOG_PARAM_DISPLAY")]
		public const string DialogParamDisplay = (string) "display";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.internal']/class[@name='ServerProtocol']/field[@name='DIALOG_PARAM_REDIRECT_URI']"
		[Register ("DIALOG_PARAM_REDIRECT_URI")]
		public const string DialogParamRedirectUri = (string) "redirect_uri";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.internal']/class[@name='ServerProtocol']/field[@name='DIALOG_PARAM_SCOPE']"
		[Register ("DIALOG_PARAM_SCOPE")]
		public const string DialogParamScope = (string) "scope";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.internal']/class[@name='ServerProtocol']/field[@name='DIALOG_PARAM_TYPE']"
		[Register ("DIALOG_PARAM_TYPE")]
		public const string DialogParamType = (string) "type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.internal']/class[@name='ServerProtocol']/field[@name='DIALOG_PATH']"
		[Register ("DIALOG_PATH")]
		public const string DialogPath = (string) "dialog/";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.internal']/class[@name='ServerProtocol']/field[@name='GRAPH_URL']"
		[Register ("GRAPH_URL")]
		public const string GraphUrl = (string) "https://graph.facebook.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.internal']/class[@name='ServerProtocol']/field[@name='GRAPH_URL_BASE']"
		[Register ("GRAPH_URL_BASE")]
		public const string GraphUrlBase = (string) "https://graph.facebook.com/";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.internal']/class[@name='ServerProtocol']/field[@name='REST_URL_BASE']"
		[Register ("REST_URL_BASE")]
		public const string RestUrlBase = (string) "https://api.facebook.com/method/";

		static IntPtr errorsProxyAuthDisabled_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.internal']/class[@name='ServerProtocol']/field[@name='errorsProxyAuthDisabled']"
		[Register ("errorsProxyAuthDisabled")]
		public static global::System.Collections.ICollection ErrorsProxyAuthDisabled {
			get {
				if (errorsProxyAuthDisabled_jfieldId == IntPtr.Zero)
					errorsProxyAuthDisabled_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "errorsProxyAuthDisabled", "Ljava/util/Collection;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, errorsProxyAuthDisabled_jfieldId);
				return global::Android.Runtime.JavaCollection.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (errorsProxyAuthDisabled_jfieldId == IntPtr.Zero)
					errorsProxyAuthDisabled_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "errorsProxyAuthDisabled", "Ljava/util/Collection;");
				IntPtr native_value = global::Android.Runtime.JavaCollection.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, errorsProxyAuthDisabled_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr errorsUserCanceled_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.internal']/class[@name='ServerProtocol']/field[@name='errorsUserCanceled']"
		[Register ("errorsUserCanceled")]
		public static global::System.Collections.ICollection ErrorsUserCanceled {
			get {
				if (errorsUserCanceled_jfieldId == IntPtr.Zero)
					errorsUserCanceled_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "errorsUserCanceled", "Ljava/util/Collection;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, errorsUserCanceled_jfieldId);
				return global::Android.Runtime.JavaCollection.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (errorsUserCanceled_jfieldId == IntPtr.Zero)
					errorsUserCanceled_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "errorsUserCanceled", "Ljava/util/Collection;");
				IntPtr native_value = global::Android.Runtime.JavaCollection.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, errorsUserCanceled_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/internal/ServerProtocol", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ServerProtocol); }
		}

		internal ServerProtocol (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.internal']/class[@name='ServerProtocol']/constructor[@name='ServerProtocol' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ServerProtocol () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ServerProtocol)) {
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

	}
}
