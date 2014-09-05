using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding.XAndroid {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']"
	[global::Android.Runtime.Register ("com/facebook/android/Facebook", DoNotGenerateAcw=true)]
	public partial class Facebook : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/field[@name='ATTRIBUTION_ID_COLUMN_NAME']"
		[Register ("ATTRIBUTION_ID_COLUMN_NAME")]
		[Obsolete ("deprecated")]
		public const string AttributionIdColumnName = (string) "aid";

		static IntPtr ATTRIBUTION_ID_CONTENT_URI_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/field[@name='ATTRIBUTION_ID_CONTENT_URI']"
		[Register ("ATTRIBUTION_ID_CONTENT_URI")]
		public static global::Android.Net.Uri AttributionIdContentUri {
			get {
				if (ATTRIBUTION_ID_CONTENT_URI_jfieldId == IntPtr.Zero)
					ATTRIBUTION_ID_CONTENT_URI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ATTRIBUTION_ID_CONTENT_URI", "Landroid/net/Uri;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ATTRIBUTION_ID_CONTENT_URI_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ATTRIBUTION_ID_CONTENT_URI_jfieldId == IntPtr.Zero)
					ATTRIBUTION_ID_CONTENT_URI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ATTRIBUTION_ID_CONTENT_URI", "Landroid/net/Uri;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, ATTRIBUTION_ID_CONTENT_URI_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/field[@name='CANCEL_URI']"
		[Register ("CANCEL_URI")]
		[Obsolete ("deprecated")]
		public const string CancelUri = (string) "fbconnect://cancel";

		static IntPtr DIALOG_BASE_URL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/field[@name='DIALOG_BASE_URL']"
		[Register ("DIALOG_BASE_URL")]
		protected static string DialogBaseUrl {
			get {
				if (DIALOG_BASE_URL_jfieldId == IntPtr.Zero)
					DIALOG_BASE_URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DIALOG_BASE_URL", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DIALOG_BASE_URL_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DIALOG_BASE_URL_jfieldId == IntPtr.Zero)
					DIALOG_BASE_URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DIALOG_BASE_URL", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, DIALOG_BASE_URL_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/field[@name='EXPIRES']"
		[Register ("EXPIRES")]
		[Obsolete ("deprecated")]
		public const string Expires = (string) "expires_in";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/field[@name='FB_APP_SIGNATURE']"
		[Register ("FB_APP_SIGNATURE")]
		[Obsolete ("deprecated")]
		public const string FbAppSignature = (string) "30820268308201d102044a9c4610300d06092a864886f70d0101040500307a310b3009060355040613025553310b3009060355040813024341311230100603550407130950616c6f20416c746f31183016060355040a130f46616365626f6f6b204d6f62696c653111300f060355040b130846616365626f6f6b311d301b0603550403131446616365626f6f6b20436f72706f726174696f6e3020170d3039303833313231353231365a180f32303530303932353231353231365a307a310b3009060355040613025553310b3009060355040813024341311230100603550407130950616c6f20416c746f31183016060355040a130f46616365626f6f6b204d6f62696c653111300f060355040b130846616365626f6f6b311d301b0603550403131446616365626f6f6b20436f72706f726174696f6e30819f300d06092a864886f70d010101050003818d0030818902818100c207d51df8eb8c97d93ba0c8c1002c928fab00dc1b42fca5e66e99cc3023ed2d214d822bc59e8e35ddcf5f44c7ae8ade50d7e0c434f500e6c131f4a2834f987fc46406115de2018ebbb0d5a3c261bd97581ccfef76afc7135a6d59e8855ecd7eacc8f8737e794c60a761c536b72b11fac8e603f5da1a2d54aa103b8a13c0dbc10203010001300d06092a864886f70d0101040500038181005ee9be8bcbb250648d3b741290a82a1c9dc2e76a0af2f2228f1d9f9c4007529c446a70175c5a900d5141812866db46be6559e2141616483998211f4a673149fb2232a10d247663b26a9031e15f84bc1c74d141ff98a02d76f85b2c8ab2571b6469b232d8e768a7f7ca04f7abe4a775615916c07940656b58717457b42bd928a2";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/field[@name='FORCE_DIALOG_AUTH']"
		[Register ("FORCE_DIALOG_AUTH")]
		[Obsolete ("deprecated")]
		public const int ForceDialogAuth = (int) -1;

		static IntPtr GRAPH_BASE_URL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/field[@name='GRAPH_BASE_URL']"
		[Register ("GRAPH_BASE_URL")]
		protected static string GraphBaseUrl {
			get {
				if (GRAPH_BASE_URL_jfieldId == IntPtr.Zero)
					GRAPH_BASE_URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GRAPH_BASE_URL", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GRAPH_BASE_URL_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (GRAPH_BASE_URL_jfieldId == IntPtr.Zero)
					GRAPH_BASE_URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GRAPH_BASE_URL", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, GRAPH_BASE_URL_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/field[@name='REDIRECT_URI']"
		[Register ("REDIRECT_URI")]
		[Obsolete ("deprecated")]
		public const string RedirectUri = (string) "fbconnect://success";

		static IntPtr RESTSERVER_URL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/field[@name='RESTSERVER_URL']"
		[Register ("RESTSERVER_URL")]
		protected static string RestserverUrl {
			get {
				if (RESTSERVER_URL_jfieldId == IntPtr.Zero)
					RESTSERVER_URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESTSERVER_URL", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RESTSERVER_URL_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (RESTSERVER_URL_jfieldId == IntPtr.Zero)
					RESTSERVER_URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESTSERVER_URL", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, RESTSERVER_URL_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/field[@name='SINGLE_SIGN_ON_DISABLED']"
		[Register ("SINGLE_SIGN_ON_DISABLED")]
		[Obsolete ("deprecated")]
		public const string SingleSignOnDisabled = (string) "service_disabled";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/field[@name='TOKEN']"
		[Register ("TOKEN")]
		[Obsolete ("deprecated")]
		public const string Token = (string) "access_token";
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.android']/interface[@name='Facebook.DialogListener']"
		[Register ("com/facebook/android/Facebook$DialogListener", "", "Xamarin.FacebookBinding.XAndroid.Facebook/IDialogListenerInvoker")]
		public partial interface IDialogListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/interface[@name='Facebook.DialogListener']/method[@name='onCancel' and count(parameter)=0]"
			[Register ("onCancel", "()V", "GetOnCancelHandler:Xamarin.FacebookBinding.XAndroid.Facebook/IDialogListenerInvoker, Xamarin.Facebook")]
			void OnCancel ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/interface[@name='Facebook.DialogListener']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("onComplete", "(Landroid/os/Bundle;)V", "GetOnComplete_Landroid_os_Bundle_Handler:Xamarin.FacebookBinding.XAndroid.Facebook/IDialogListenerInvoker, Xamarin.Facebook")]
			void OnComplete (global::Android.OS.Bundle p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/interface[@name='Facebook.DialogListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.facebook.android.DialogError']]"
			[Register ("onError", "(Lcom/facebook/android/DialogError;)V", "GetOnError_Lcom_facebook_android_DialogError_Handler:Xamarin.FacebookBinding.XAndroid.Facebook/IDialogListenerInvoker, Xamarin.Facebook")]
			void OnError (global::Xamarin.FacebookBinding.XAndroid.DialogError p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/interface[@name='Facebook.DialogListener']/method[@name='onFacebookError' and count(parameter)=1 and parameter[1][@type='com.facebook.android.FacebookError']]"
			[Register ("onFacebookError", "(Lcom/facebook/android/FacebookError;)V", "GetOnFacebookError_Lcom_facebook_android_FacebookError_Handler:Xamarin.FacebookBinding.XAndroid.Facebook/IDialogListenerInvoker, Xamarin.Facebook")]
			void OnFacebookError (global::Xamarin.FacebookBinding.XAndroid.FacebookError p0);

		}

		[global::Android.Runtime.Register ("com/facebook/android/Facebook$DialogListener", DoNotGenerateAcw=true)]
		internal class IDialogListenerInvoker : global::Java.Lang.Object, IDialogListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/android/Facebook$DialogListener");
			IntPtr class_ref;

			public static IDialogListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDialogListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.android.Facebook.DialogListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDialogListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IDialogListenerInvoker); }
			}

			static Delegate cb_onCancel;
#pragma warning disable 0169
			static Delegate GetOnCancelHandler ()
			{
				if (cb_onCancel == null)
					cb_onCancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCancel);
				return cb_onCancel;
			}

			static void n_OnCancel (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCancel ();
			}
#pragma warning restore 0169

			IntPtr id_onCancel;
			public void OnCancel ()
			{
				if (id_onCancel == IntPtr.Zero)
					id_onCancel = JNIEnv.GetMethodID (class_ref, "onCancel", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onCancel);
			}

			static Delegate cb_onComplete_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetOnComplete_Landroid_os_Bundle_Handler ()
			{
				if (cb_onComplete_Landroid_os_Bundle_ == null)
					cb_onComplete_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnComplete_Landroid_os_Bundle_);
				return cb_onComplete_Landroid_os_Bundle_;
			}

			static void n_OnComplete_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnComplete (p0);
			}
#pragma warning restore 0169

			IntPtr id_onComplete_Landroid_os_Bundle_;
			public void OnComplete (global::Android.OS.Bundle p0)
			{
				if (id_onComplete_Landroid_os_Bundle_ == IntPtr.Zero)
					id_onComplete_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Landroid/os/Bundle;)V");
				JNIEnv.CallVoidMethod (Handle, id_onComplete_Landroid_os_Bundle_, new JValue (p0));
			}

			static Delegate cb_onError_Lcom_facebook_android_DialogError_;
#pragma warning disable 0169
			static Delegate GetOnError_Lcom_facebook_android_DialogError_Handler ()
			{
				if (cb_onError_Lcom_facebook_android_DialogError_ == null)
					cb_onError_Lcom_facebook_android_DialogError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Lcom_facebook_android_DialogError_);
				return cb_onError_Lcom_facebook_android_DialogError_;
			}

			static void n_OnError_Lcom_facebook_android_DialogError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.XAndroid.DialogError p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.DialogError> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onError_Lcom_facebook_android_DialogError_;
			public void OnError (global::Xamarin.FacebookBinding.XAndroid.DialogError p0)
			{
				if (id_onError_Lcom_facebook_android_DialogError_ == IntPtr.Zero)
					id_onError_Lcom_facebook_android_DialogError_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/facebook/android/DialogError;)V");
				JNIEnv.CallVoidMethod (Handle, id_onError_Lcom_facebook_android_DialogError_, new JValue (p0));
			}

			static Delegate cb_onFacebookError_Lcom_facebook_android_FacebookError_;
#pragma warning disable 0169
			static Delegate GetOnFacebookError_Lcom_facebook_android_FacebookError_Handler ()
			{
				if (cb_onFacebookError_Lcom_facebook_android_FacebookError_ == null)
					cb_onFacebookError_Lcom_facebook_android_FacebookError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFacebookError_Lcom_facebook_android_FacebookError_);
				return cb_onFacebookError_Lcom_facebook_android_FacebookError_;
			}

			static void n_OnFacebookError_Lcom_facebook_android_FacebookError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.XAndroid.FacebookError p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.FacebookError> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFacebookError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onFacebookError_Lcom_facebook_android_FacebookError_;
			public void OnFacebookError (global::Xamarin.FacebookBinding.XAndroid.FacebookError p0)
			{
				if (id_onFacebookError_Lcom_facebook_android_FacebookError_ == IntPtr.Zero)
					id_onFacebookError_Lcom_facebook_android_FacebookError_ = JNIEnv.GetMethodID (class_ref, "onFacebookError", "(Lcom/facebook/android/FacebookError;)V");
				JNIEnv.CallVoidMethod (Handle, id_onFacebookError_Lcom_facebook_android_FacebookError_, new JValue (p0));
			}

		}

		public partial class DialogCompleteEventArgs : global::System.EventArgs {

			public DialogCompleteEventArgs (global::Android.OS.Bundle p0)
			{
				this.p0 = p0;
			}

			global::Android.OS.Bundle p0;
			public global::Android.OS.Bundle P0 {
				get { return p0; }
			}
		}

		public partial class DialogErrorEventArgs : global::System.EventArgs {

			public DialogErrorEventArgs (global::Xamarin.FacebookBinding.XAndroid.DialogError p0)
			{
				this.p0 = p0;
			}

			global::Xamarin.FacebookBinding.XAndroid.DialogError p0;
			public global::Xamarin.FacebookBinding.XAndroid.DialogError P0 {
				get { return p0; }
			}
		}

		public partial class DialogFacebookErrorEventArgs : global::System.EventArgs {

			public DialogFacebookErrorEventArgs (global::Xamarin.FacebookBinding.XAndroid.FacebookError p0)
			{
				this.p0 = p0;
			}

			global::Xamarin.FacebookBinding.XAndroid.FacebookError p0;
			public global::Xamarin.FacebookBinding.XAndroid.FacebookError P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/facebook/android/Facebook_DialogListenerImplementor")]
		internal sealed class IDialogListenerImplementor : global::Java.Lang.Object, IDialogListener {

			object sender;

			public IDialogListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/facebook/android/Facebook_DialogListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnCancelHandler;
#pragma warning restore 0649

			public void OnCancel ()
			{
				var __h = OnCancelHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<DialogCompleteEventArgs> OnCompleteHandler;
#pragma warning restore 0649

			public void OnComplete (global::Android.OS.Bundle p0)
			{
				var __h = OnCompleteHandler;
				if (__h != null)
					__h (sender, new DialogCompleteEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<DialogErrorEventArgs> OnErrorHandler;
#pragma warning restore 0649

			public void OnError (global::Xamarin.FacebookBinding.XAndroid.DialogError p0)
			{
				var __h = OnErrorHandler;
				if (__h != null)
					__h (sender, new DialogErrorEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<DialogFacebookErrorEventArgs> OnFacebookErrorHandler;
#pragma warning restore 0649

			public void OnFacebookError (global::Xamarin.FacebookBinding.XAndroid.FacebookError p0)
			{
				var __h = OnFacebookErrorHandler;
				if (__h != null)
					__h (sender, new DialogFacebookErrorEventArgs (p0));
			}

			internal static bool __IsEmpty (IDialogListenerImplementor value)
			{
				return value.OnCancelHandler == null && value.OnCompleteHandler == null && value.OnErrorHandler == null && value.OnFacebookErrorHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.android']/interface[@name='Facebook.ServiceListener']"
		[Register ("com/facebook/android/Facebook$ServiceListener", "", "Xamarin.FacebookBinding.XAndroid.Facebook/IServiceListenerInvoker")]
		public partial interface IServiceListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/interface[@name='Facebook.ServiceListener']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("onComplete", "(Landroid/os/Bundle;)V", "GetOnComplete_Landroid_os_Bundle_Handler:Xamarin.FacebookBinding.XAndroid.Facebook/IServiceListenerInvoker, Xamarin.Facebook")]
			void OnComplete (global::Android.OS.Bundle p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/interface[@name='Facebook.ServiceListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Error']]"
			[Register ("onError", "(Ljava/lang/Error;)V", "GetOnError_Ljava_lang_Error_Handler:Xamarin.FacebookBinding.XAndroid.Facebook/IServiceListenerInvoker, Xamarin.Facebook")]
			void OnError (global::Java.Lang.Error p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/interface[@name='Facebook.ServiceListener']/method[@name='onFacebookError' and count(parameter)=1 and parameter[1][@type='com.facebook.android.FacebookError']]"
			[Register ("onFacebookError", "(Lcom/facebook/android/FacebookError;)V", "GetOnFacebookError_Lcom_facebook_android_FacebookError_Handler:Xamarin.FacebookBinding.XAndroid.Facebook/IServiceListenerInvoker, Xamarin.Facebook")]
			void OnFacebookError (global::Xamarin.FacebookBinding.XAndroid.FacebookError p0);

		}

		[global::Android.Runtime.Register ("com/facebook/android/Facebook$ServiceListener", DoNotGenerateAcw=true)]
		internal class IServiceListenerInvoker : global::Java.Lang.Object, IServiceListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/android/Facebook$ServiceListener");
			IntPtr class_ref;

			public static IServiceListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IServiceListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.android.Facebook.ServiceListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IServiceListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IServiceListenerInvoker); }
			}

			static Delegate cb_onComplete_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetOnComplete_Landroid_os_Bundle_Handler ()
			{
				if (cb_onComplete_Landroid_os_Bundle_ == null)
					cb_onComplete_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnComplete_Landroid_os_Bundle_);
				return cb_onComplete_Landroid_os_Bundle_;
			}

			static void n_OnComplete_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.XAndroid.Facebook.IServiceListener __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook.IServiceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnComplete (p0);
			}
#pragma warning restore 0169

			IntPtr id_onComplete_Landroid_os_Bundle_;
			public void OnComplete (global::Android.OS.Bundle p0)
			{
				if (id_onComplete_Landroid_os_Bundle_ == IntPtr.Zero)
					id_onComplete_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Landroid/os/Bundle;)V");
				JNIEnv.CallVoidMethod (Handle, id_onComplete_Landroid_os_Bundle_, new JValue (p0));
			}

			static Delegate cb_onError_Ljava_lang_Error_;
#pragma warning disable 0169
			static Delegate GetOnError_Ljava_lang_Error_Handler ()
			{
				if (cb_onError_Ljava_lang_Error_ == null)
					cb_onError_Ljava_lang_Error_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_lang_Error_);
				return cb_onError_Ljava_lang_Error_;
			}

			static void n_OnError_Ljava_lang_Error_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.XAndroid.Facebook.IServiceListener __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook.IServiceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Error p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Error> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onError_Ljava_lang_Error_;
			public void OnError (global::Java.Lang.Error p0)
			{
				if (id_onError_Ljava_lang_Error_ == IntPtr.Zero)
					id_onError_Ljava_lang_Error_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Error;)V");
				JNIEnv.CallVoidMethod (Handle, id_onError_Ljava_lang_Error_, new JValue (p0));
			}

			static Delegate cb_onFacebookError_Lcom_facebook_android_FacebookError_;
#pragma warning disable 0169
			static Delegate GetOnFacebookError_Lcom_facebook_android_FacebookError_Handler ()
			{
				if (cb_onFacebookError_Lcom_facebook_android_FacebookError_ == null)
					cb_onFacebookError_Lcom_facebook_android_FacebookError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFacebookError_Lcom_facebook_android_FacebookError_);
				return cb_onFacebookError_Lcom_facebook_android_FacebookError_;
			}

			static void n_OnFacebookError_Lcom_facebook_android_FacebookError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.XAndroid.Facebook.IServiceListener __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook.IServiceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.XAndroid.FacebookError p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.FacebookError> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFacebookError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onFacebookError_Lcom_facebook_android_FacebookError_;
			public void OnFacebookError (global::Xamarin.FacebookBinding.XAndroid.FacebookError p0)
			{
				if (id_onFacebookError_Lcom_facebook_android_FacebookError_ == IntPtr.Zero)
					id_onFacebookError_Lcom_facebook_android_FacebookError_ = JNIEnv.GetMethodID (class_ref, "onFacebookError", "(Lcom/facebook/android/FacebookError;)V");
				JNIEnv.CallVoidMethod (Handle, id_onFacebookError_Lcom_facebook_android_FacebookError_, new JValue (p0));
			}

		}

		public partial class ServiceCompleteEventArgs : global::System.EventArgs {

			public ServiceCompleteEventArgs (global::Android.OS.Bundle p0)
			{
				this.p0 = p0;
			}

			global::Android.OS.Bundle p0;
			public global::Android.OS.Bundle P0 {
				get { return p0; }
			}
		}

		public partial class ServiceErrorEventArgs : global::System.EventArgs {

			public ServiceErrorEventArgs (global::Java.Lang.Error p0)
			{
				this.p0 = p0;
			}

			global::Java.Lang.Error p0;
			public global::Java.Lang.Error P0 {
				get { return p0; }
			}
		}

		public partial class ServiceFacebookErrorEventArgs : global::System.EventArgs {

			public ServiceFacebookErrorEventArgs (global::Xamarin.FacebookBinding.XAndroid.FacebookError p0)
			{
				this.p0 = p0;
			}

			global::Xamarin.FacebookBinding.XAndroid.FacebookError p0;
			public global::Xamarin.FacebookBinding.XAndroid.FacebookError P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/facebook/android/Facebook_ServiceListenerImplementor")]
		internal sealed class IServiceListenerImplementor : global::Java.Lang.Object, IServiceListener {

			object sender;

			public IServiceListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/facebook/android/Facebook_ServiceListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ServiceCompleteEventArgs> OnCompleteHandler;
#pragma warning restore 0649

			public void OnComplete (global::Android.OS.Bundle p0)
			{
				var __h = OnCompleteHandler;
				if (__h != null)
					__h (sender, new ServiceCompleteEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<ServiceErrorEventArgs> OnErrorHandler;
#pragma warning restore 0649

			public void OnError (global::Java.Lang.Error p0)
			{
				var __h = OnErrorHandler;
				if (__h != null)
					__h (sender, new ServiceErrorEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<ServiceFacebookErrorEventArgs> OnFacebookErrorHandler;
#pragma warning restore 0649

			public void OnFacebookError (global::Xamarin.FacebookBinding.XAndroid.FacebookError p0)
			{
				var __h = OnFacebookErrorHandler;
				if (__h != null)
					__h (sender, new ServiceFacebookErrorEventArgs (p0));
			}

			internal static bool __IsEmpty (IServiceListenerImplementor value)
			{
				return value.OnCompleteHandler == null && value.OnErrorHandler == null && value.OnFacebookErrorHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook.SetterTokenCachingStrategy']"
		[global::Android.Runtime.Register ("com/facebook/android/Facebook$SetterTokenCachingStrategy", DoNotGenerateAcw=true)]
		public partial class SetterTokenCachingStrategy : global::Xamarin.FacebookBinding.TokenCachingStrategy {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/android/Facebook$SetterTokenCachingStrategy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SetterTokenCachingStrategy); }
			}

			protected SetterTokenCachingStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Xamarin.FacebookBinding.XAndroid.Facebook.SetterTokenCachingStrategy __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook.SetterTokenCachingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Clear ();
			}
#pragma warning restore 0169

			static IntPtr id_clear;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook.SetterTokenCachingStrategy']/method[@name='clear' and count(parameter)=0]"
			[Register ("clear", "()V", "GetClearHandler")]
			public override void Clear ()
			{
				if (id_clear == IntPtr.Zero)
					id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
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
				global::Xamarin.FacebookBinding.XAndroid.Facebook.SetterTokenCachingStrategy __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook.SetterTokenCachingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Load ());
			}
#pragma warning restore 0169

			static IntPtr id_load;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook.SetterTokenCachingStrategy']/method[@name='load' and count(parameter)=0]"
			[Register ("load", "()Landroid/os/Bundle;", "GetLoadHandler")]
			public override global::Android.OS.Bundle Load ()
			{
				if (id_load == IntPtr.Zero)
					id_load = JNIEnv.GetMethodID (class_ref, "load", "()Landroid/os/Bundle;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_load), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "load", "()Landroid/os/Bundle;")), JniHandleOwnership.TransferLocalRef);
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
				global::Xamarin.FacebookBinding.XAndroid.Facebook.SetterTokenCachingStrategy __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook.SetterTokenCachingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Save (p0);
			}
#pragma warning restore 0169

			static IntPtr id_save_Landroid_os_Bundle_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook.SetterTokenCachingStrategy']/method[@name='save' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("save", "(Landroid/os/Bundle;)V", "GetSave_Landroid_os_Bundle_Handler")]
			public override void Save (global::Android.OS.Bundle p0)
			{
				if (id_save_Landroid_os_Bundle_ == IntPtr.Zero)
					id_save_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "save", "(Landroid/os/Bundle;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_save_Landroid_os_Bundle_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "save", "(Landroid/os/Bundle;)V"), new JValue (p0));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook.TokenRefreshConnectionHandler']"
		[global::Android.Runtime.Register ("com/facebook/android/Facebook$TokenRefreshConnectionHandler", DoNotGenerateAcw=true)]
		public partial class TokenRefreshConnectionHandler : global::Android.OS.Handler {

			protected TokenRefreshConnectionHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook.TokenRefreshServiceConnection']"
		[global::Android.Runtime.Register ("com/facebook/android/Facebook$TokenRefreshServiceConnection", DoNotGenerateAcw=true)]
		public partial class TokenRefreshServiceConnection : global::Java.Lang.Object, global::Android.Content.IServiceConnection {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/android/Facebook$TokenRefreshServiceConnection", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TokenRefreshServiceConnection); }
			}

			protected TokenRefreshServiceConnection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_facebook_android_Facebook_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook.TokenRefreshServiceConnection']/constructor[@name='Facebook.TokenRefreshServiceConnection' and count(parameter)=3 and parameter[1][@type='com.facebook.android.Facebook'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.facebook.android.Facebook.ServiceListener']]"
			[Register (".ctor", "(Lcom/facebook/android/Facebook;Landroid/content/Context;Lcom/facebook/android/Facebook$ServiceListener;)V", "")]
			public TokenRefreshServiceConnection (global::Xamarin.FacebookBinding.XAndroid.Facebook __self, global::Android.Content.Context p1, global::Xamarin.FacebookBinding.XAndroid.Facebook.IServiceListener p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (TokenRefreshServiceConnection)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;Lcom/facebook/android/Facebook$ServiceListener;)V", new JValue (__self), new JValue (p1), new JValue (p2)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;Lcom/facebook/android/Facebook$ServiceListener;)V", new JValue (__self), new JValue (p1), new JValue (p2));
					return;
				}

				if (id_ctor_Lcom_facebook_android_Facebook_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_ == IntPtr.Zero)
					id_ctor_Lcom_facebook_android_Facebook_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/android/Facebook;Landroid/content/Context;Lcom/facebook/android/Facebook$ServiceListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_android_Facebook_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_, new JValue (__self), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_facebook_android_Facebook_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_, new JValue (__self), new JValue (p1), new JValue (p2));
			}

			static Delegate cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_;
#pragma warning disable 0169
			static Delegate GetOnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_Handler ()
			{
				if (cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ == null)
					cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_);
				return cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_;
			}

			static void n_OnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Xamarin.FacebookBinding.XAndroid.Facebook.TokenRefreshServiceConnection __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook.TokenRefreshServiceConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.ComponentName p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.IBinder p1 = (global::Android.OS.IBinder)global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnServiceConnected (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook.TokenRefreshServiceConnection']/method[@name='onServiceConnected' and count(parameter)=2 and parameter[1][@type='android.content.ComponentName'] and parameter[2][@type='android.os.IBinder']]"
			[Register ("onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V", "GetOnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_Handler")]
			public virtual void OnServiceConnected (global::Android.Content.ComponentName p0, global::Android.OS.IBinder p1)
			{
				if (id_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ == IntPtr.Zero)
					id_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ = JNIEnv.GetMethodID (class_ref, "onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_, new JValue (p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V"), new JValue (p0), new JValue (p1));
			}

			static Delegate cb_onServiceDisconnected_Landroid_content_ComponentName_;
#pragma warning disable 0169
			static Delegate GetOnServiceDisconnected_Landroid_content_ComponentName_Handler ()
			{
				if (cb_onServiceDisconnected_Landroid_content_ComponentName_ == null)
					cb_onServiceDisconnected_Landroid_content_ComponentName_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnServiceDisconnected_Landroid_content_ComponentName_);
				return cb_onServiceDisconnected_Landroid_content_ComponentName_;
			}

			static void n_OnServiceDisconnected_Landroid_content_ComponentName_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.XAndroid.Facebook.TokenRefreshServiceConnection __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook.TokenRefreshServiceConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.ComponentName p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnServiceDisconnected (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onServiceDisconnected_Landroid_content_ComponentName_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook.TokenRefreshServiceConnection']/method[@name='onServiceDisconnected' and count(parameter)=1 and parameter[1][@type='android.content.ComponentName']]"
			[Register ("onServiceDisconnected", "(Landroid/content/ComponentName;)V", "GetOnServiceDisconnected_Landroid_content_ComponentName_Handler")]
			public virtual void OnServiceDisconnected (global::Android.Content.ComponentName p0)
			{
				if (id_onServiceDisconnected_Landroid_content_ComponentName_ == IntPtr.Zero)
					id_onServiceDisconnected_Landroid_content_ComponentName_ = JNIEnv.GetMethodID (class_ref, "onServiceDisconnected", "(Landroid/content/ComponentName;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onServiceDisconnected_Landroid_content_ComponentName_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onServiceDisconnected", "(Landroid/content/ComponentName;)V"), new JValue (p0));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/android/Facebook", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Facebook); }
		}

		protected Facebook (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/constructor[@name='Facebook' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public Facebook (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (Facebook)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getAccessExpires;
#pragma warning disable 0169
		static Delegate GetGetAccessExpiresHandler ()
		{
			if (cb_getAccessExpires == null)
				cb_getAccessExpires = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAccessExpires);
			return cb_getAccessExpires;
		}

		static long n_GetAccessExpires (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AccessExpires;
		}
#pragma warning restore 0169

		static Delegate cb_setAccessExpires_J;
#pragma warning disable 0169
		static Delegate GetSetAccessExpires_JHandler ()
		{
			if (cb_setAccessExpires_J == null)
				cb_setAccessExpires_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetAccessExpires_J);
			return cb_setAccessExpires_J;
		}

		static void n_SetAccessExpires_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AccessExpires = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAccessExpires;
		static IntPtr id_setAccessExpires_J;
		[Obsolete (@"deprecated")]
		public virtual long AccessExpires {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='getAccessExpires' and count(parameter)=0]"
			[Register ("getAccessExpires", "()J", "GetGetAccessExpiresHandler")]
			get {
				if (id_getAccessExpires == IntPtr.Zero)
					id_getAccessExpires = JNIEnv.GetMethodID (class_ref, "getAccessExpires", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getAccessExpires);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccessExpires", "()J"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='setAccessExpires' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setAccessExpires", "(J)V", "GetSetAccessExpires_JHandler")]
			set {
				if (id_setAccessExpires_J == IntPtr.Zero)
					id_setAccessExpires_J = JNIEnv.GetMethodID (class_ref, "setAccessExpires", "(J)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAccessExpires_J, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAccessExpires", "(J)V"), new JValue (value));
			}
		}

		static Delegate cb_getAccessToken;
#pragma warning disable 0169
		static Delegate GetGetAccessTokenHandler ()
		{
			if (cb_getAccessToken == null)
				cb_getAccessToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccessToken);
			return cb_getAccessToken;
		}

		static IntPtr n_GetAccessToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccessToken);
		}
#pragma warning restore 0169

		static Delegate cb_setAccessToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAccessToken_Ljava_lang_String_Handler ()
		{
			if (cb_setAccessToken_Ljava_lang_String_ == null)
				cb_setAccessToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAccessToken_Ljava_lang_String_);
			return cb_setAccessToken_Ljava_lang_String_;
		}

		static void n_SetAccessToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AccessToken = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAccessToken;
		static IntPtr id_setAccessToken_Ljava_lang_String_;
		[Obsolete (@"deprecated")]
		public virtual string AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='getAccessToken' and count(parameter)=0]"
			[Register ("getAccessToken", "()Ljava/lang/String;", "GetGetAccessTokenHandler")]
			get {
				if (id_getAccessToken == IntPtr.Zero)
					id_getAccessToken = JNIEnv.GetMethodID (class_ref, "getAccessToken", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAccessToken), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccessToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='setAccessToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAccessToken", "(Ljava/lang/String;)V", "GetSetAccessToken_Ljava_lang_String_Handler")]
			set {
				if (id_setAccessToken_Ljava_lang_String_ == IntPtr.Zero)
					id_setAccessToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAccessToken", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAccessToken_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAccessToken", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getAppId;
#pragma warning disable 0169
		static Delegate GetGetAppIdHandler ()
		{
			if (cb_getAppId == null)
				cb_getAppId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppId);
			return cb_getAppId;
		}

		static IntPtr n_GetAppId (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppId);
		}
#pragma warning restore 0169

		static Delegate cb_setAppId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppId_Ljava_lang_String_Handler ()
		{
			if (cb_setAppId_Ljava_lang_String_ == null)
				cb_setAppId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppId_Ljava_lang_String_);
			return cb_setAppId_Ljava_lang_String_;
		}

		static void n_SetAppId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAppId;
		static IntPtr id_setAppId_Ljava_lang_String_;
		[Obsolete (@"deprecated")]
		public virtual string AppId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='getAppId' and count(parameter)=0]"
			[Register ("getAppId", "()Ljava/lang/String;", "GetGetAppIdHandler")]
			get {
				if (id_getAppId == IntPtr.Zero)
					id_getAppId = JNIEnv.GetMethodID (class_ref, "getAppId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAppId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='setAppId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppId", "(Ljava/lang/String;)V", "GetSetAppId_Ljava_lang_String_Handler")]
			set {
				if (id_setAppId_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAppId_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppId", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_isSessionValid;
#pragma warning disable 0169
		static Delegate GetIsSessionValidHandler ()
		{
			if (cb_isSessionValid == null)
				cb_isSessionValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSessionValid);
			return cb_isSessionValid;
		}

		static bool n_IsSessionValid (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSessionValid;
		}
#pragma warning restore 0169

		static IntPtr id_isSessionValid;
		[Obsolete (@"deprecated")]
		public virtual bool IsSessionValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='isSessionValid' and count(parameter)=0]"
			[Register ("isSessionValid", "()Z", "GetIsSessionValidHandler")]
			get {
				if (id_isSessionValid == IntPtr.Zero)
					id_isSessionValid = JNIEnv.GetMethodID (class_ref, "isSessionValid", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isSessionValid);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSessionValid", "()Z"));
			}
		}

		static Delegate cb_getLastAccessUpdate;
#pragma warning disable 0169
		static Delegate GetGetLastAccessUpdateHandler ()
		{
			if (cb_getLastAccessUpdate == null)
				cb_getLastAccessUpdate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLastAccessUpdate);
			return cb_getLastAccessUpdate;
		}

		static long n_GetLastAccessUpdate (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastAccessUpdate;
		}
#pragma warning restore 0169

		static IntPtr id_getLastAccessUpdate;
		[Obsolete (@"deprecated")]
		public virtual long LastAccessUpdate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='getLastAccessUpdate' and count(parameter)=0]"
			[Register ("getLastAccessUpdate", "()J", "GetGetLastAccessUpdateHandler")]
			get {
				if (id_getLastAccessUpdate == IntPtr.Zero)
					id_getLastAccessUpdate = JNIEnv.GetMethodID (class_ref, "getLastAccessUpdate", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getLastAccessUpdate);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastAccessUpdate", "()J"));
			}
		}

		static IntPtr id_getSession;
		static IntPtr id_setSession_Lcom_facebook_Session_;
		[Obsolete (@"deprecated")]
		public global::Xamarin.FacebookBinding.Session Session {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='getSession' and count(parameter)=0]"
			[Register ("getSession", "()Lcom/facebook/Session;", "GetGetSessionHandler")]
			get {
				if (id_getSession == IntPtr.Zero)
					id_getSession = JNIEnv.GetMethodID (class_ref, "getSession", "()Lcom/facebook/Session;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (JNIEnv.CallObjectMethod  (Handle, id_getSession), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='setSession' and count(parameter)=1 and parameter[1][@type='com.facebook.Session']]"
			[Register ("setSession", "(Lcom/facebook/Session;)V", "GetSetSession_Lcom_facebook_Session_Handler")]
			set {
				if (id_setSession_Lcom_facebook_Session_ == IntPtr.Zero)
					id_setSession_Lcom_facebook_Session_ = JNIEnv.GetMethodID (class_ref, "setSession", "(Lcom/facebook/Session;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSession_Lcom_facebook_Session_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSession", "(Lcom/facebook/Session;)V"), new JValue (value));
			}
		}

		static Delegate cb_getShouldAutoPublishInstall;
#pragma warning disable 0169
		static Delegate GetGetShouldAutoPublishInstallHandler ()
		{
			if (cb_getShouldAutoPublishInstall == null)
				cb_getShouldAutoPublishInstall = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetShouldAutoPublishInstall);
			return cb_getShouldAutoPublishInstall;
		}

		static bool n_GetShouldAutoPublishInstall (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldAutoPublishInstall;
		}
#pragma warning restore 0169

		static Delegate cb_setShouldAutoPublishInstall_Z;
#pragma warning disable 0169
		static Delegate GetSetShouldAutoPublishInstall_ZHandler ()
		{
			if (cb_setShouldAutoPublishInstall_Z == null)
				cb_setShouldAutoPublishInstall_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShouldAutoPublishInstall_Z);
			return cb_setShouldAutoPublishInstall_Z;
		}

		static void n_SetShouldAutoPublishInstall_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShouldAutoPublishInstall = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getShouldAutoPublishInstall;
		static IntPtr id_setShouldAutoPublishInstall_Z;
		[Obsolete (@"deprecated")]
		public virtual bool ShouldAutoPublishInstall {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='getShouldAutoPublishInstall' and count(parameter)=0]"
			[Register ("getShouldAutoPublishInstall", "()Z", "GetGetShouldAutoPublishInstallHandler")]
			get {
				if (id_getShouldAutoPublishInstall == IntPtr.Zero)
					id_getShouldAutoPublishInstall = JNIEnv.GetMethodID (class_ref, "getShouldAutoPublishInstall", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getShouldAutoPublishInstall);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShouldAutoPublishInstall", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='setShouldAutoPublishInstall' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShouldAutoPublishInstall", "(Z)V", "GetSetShouldAutoPublishInstall_ZHandler")]
			set {
				if (id_setShouldAutoPublishInstall_Z == IntPtr.Zero)
					id_setShouldAutoPublishInstall_Z = JNIEnv.GetMethodID (class_ref, "setShouldAutoPublishInstall", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setShouldAutoPublishInstall_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShouldAutoPublishInstall", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_authorize_Landroid_app_Activity_Lcom_facebook_android_Facebook_DialogListener_;
#pragma warning disable 0169
		static Delegate GetAuthorize_Landroid_app_Activity_Lcom_facebook_android_Facebook_DialogListener_Handler ()
		{
			if (cb_authorize_Landroid_app_Activity_Lcom_facebook_android_Facebook_DialogListener_ == null)
				cb_authorize_Landroid_app_Activity_Lcom_facebook_android_Facebook_DialogListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Authorize_Landroid_app_Activity_Lcom_facebook_android_Facebook_DialogListener_);
			return cb_authorize_Landroid_app_Activity_Lcom_facebook_android_Facebook_DialogListener_;
		}

		static void n_Authorize_Landroid_app_Activity_Lcom_facebook_android_Facebook_DialogListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener p1 = (global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Authorize (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_authorize_Landroid_app_Activity_Lcom_facebook_android_Facebook_DialogListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='authorize' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.facebook.android.Facebook.DialogListener']]"
		[Register ("authorize", "(Landroid/app/Activity;Lcom/facebook/android/Facebook$DialogListener;)V", "GetAuthorize_Landroid_app_Activity_Lcom_facebook_android_Facebook_DialogListener_Handler")]
		public virtual void Authorize (global::Android.App.Activity p0, global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener p1)
		{
			if (id_authorize_Landroid_app_Activity_Lcom_facebook_android_Facebook_DialogListener_ == IntPtr.Zero)
				id_authorize_Landroid_app_Activity_Lcom_facebook_android_Facebook_DialogListener_ = JNIEnv.GetMethodID (class_ref, "authorize", "(Landroid/app/Activity;Lcom/facebook/android/Facebook$DialogListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_authorize_Landroid_app_Activity_Lcom_facebook_android_Facebook_DialogListener_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "authorize", "(Landroid/app/Activity;Lcom/facebook/android/Facebook$DialogListener;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_authorize_Landroid_app_Activity_arrayLjava_lang_String_Lcom_facebook_android_Facebook_DialogListener_;
#pragma warning disable 0169
		static Delegate GetAuthorize_Landroid_app_Activity_arrayLjava_lang_String_Lcom_facebook_android_Facebook_DialogListener_Handler ()
		{
			if (cb_authorize_Landroid_app_Activity_arrayLjava_lang_String_Lcom_facebook_android_Facebook_DialogListener_ == null)
				cb_authorize_Landroid_app_Activity_arrayLjava_lang_String_Lcom_facebook_android_Facebook_DialogListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Authorize_Landroid_app_Activity_arrayLjava_lang_String_Lcom_facebook_android_Facebook_DialogListener_);
			return cb_authorize_Landroid_app_Activity_arrayLjava_lang_String_Lcom_facebook_android_Facebook_DialogListener_;
		}

		static void n_Authorize_Landroid_app_Activity_arrayLjava_lang_String_Lcom_facebook_android_Facebook_DialogListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener p2 = (global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Authorize (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_authorize_Landroid_app_Activity_arrayLjava_lang_String_Lcom_facebook_android_Facebook_DialogListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='authorize' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='com.facebook.android.Facebook.DialogListener']]"
		[Register ("authorize", "(Landroid/app/Activity;[Ljava/lang/String;Lcom/facebook/android/Facebook$DialogListener;)V", "GetAuthorize_Landroid_app_Activity_arrayLjava_lang_String_Lcom_facebook_android_Facebook_DialogListener_Handler")]
		public virtual void Authorize (global::Android.App.Activity p0, string[] p1, global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener p2)
		{
			if (id_authorize_Landroid_app_Activity_arrayLjava_lang_String_Lcom_facebook_android_Facebook_DialogListener_ == IntPtr.Zero)
				id_authorize_Landroid_app_Activity_arrayLjava_lang_String_Lcom_facebook_android_Facebook_DialogListener_ = JNIEnv.GetMethodID (class_ref, "authorize", "(Landroid/app/Activity;[Ljava/lang/String;Lcom/facebook/android/Facebook$DialogListener;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_authorize_Landroid_app_Activity_arrayLjava_lang_String_Lcom_facebook_android_Facebook_DialogListener_, new JValue (p0), new JValue (native_p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "authorize", "(Landroid/app/Activity;[Ljava/lang/String;Lcom/facebook/android/Facebook$DialogListener;)V"), new JValue (p0), new JValue (native_p1), new JValue (p2));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_authorize_Landroid_app_Activity_arrayLjava_lang_String_ILcom_facebook_android_Facebook_DialogListener_;
#pragma warning disable 0169
		static Delegate GetAuthorize_Landroid_app_Activity_arrayLjava_lang_String_ILcom_facebook_android_Facebook_DialogListener_Handler ()
		{
			if (cb_authorize_Landroid_app_Activity_arrayLjava_lang_String_ILcom_facebook_android_Facebook_DialogListener_ == null)
				cb_authorize_Landroid_app_Activity_arrayLjava_lang_String_ILcom_facebook_android_Facebook_DialogListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr>) n_Authorize_Landroid_app_Activity_arrayLjava_lang_String_ILcom_facebook_android_Facebook_DialogListener_);
			return cb_authorize_Landroid_app_Activity_arrayLjava_lang_String_ILcom_facebook_android_Facebook_DialogListener_;
		}

		static void n_Authorize_Landroid_app_Activity_arrayLjava_lang_String_ILcom_facebook_android_Facebook_DialogListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener p3 = (global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Authorize (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_authorize_Landroid_app_Activity_arrayLjava_lang_String_ILcom_facebook_android_Facebook_DialogListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='authorize' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='int'] and parameter[4][@type='com.facebook.android.Facebook.DialogListener']]"
		[Register ("authorize", "(Landroid/app/Activity;[Ljava/lang/String;ILcom/facebook/android/Facebook$DialogListener;)V", "GetAuthorize_Landroid_app_Activity_arrayLjava_lang_String_ILcom_facebook_android_Facebook_DialogListener_Handler")]
		public virtual void Authorize (global::Android.App.Activity p0, string[] p1, int p2, global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener p3)
		{
			if (id_authorize_Landroid_app_Activity_arrayLjava_lang_String_ILcom_facebook_android_Facebook_DialogListener_ == IntPtr.Zero)
				id_authorize_Landroid_app_Activity_arrayLjava_lang_String_ILcom_facebook_android_Facebook_DialogListener_ = JNIEnv.GetMethodID (class_ref, "authorize", "(Landroid/app/Activity;[Ljava/lang/String;ILcom/facebook/android/Facebook$DialogListener;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_authorize_Landroid_app_Activity_arrayLjava_lang_String_ILcom_facebook_android_Facebook_DialogListener_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "authorize", "(Landroid/app/Activity;[Ljava/lang/String;ILcom/facebook/android/Facebook$DialogListener;)V"), new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_authorizeCallback_IILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetAuthorizeCallback_IILandroid_content_Intent_Handler ()
		{
			if (cb_authorizeCallback_IILandroid_content_Intent_ == null)
				cb_authorizeCallback_IILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_AuthorizeCallback_IILandroid_content_Intent_);
			return cb_authorizeCallback_IILandroid_content_Intent_;
		}

		static void n_AuthorizeCallback_IILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AuthorizeCallback (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_authorizeCallback_IILandroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='authorizeCallback' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("authorizeCallback", "(IILandroid/content/Intent;)V", "GetAuthorizeCallback_IILandroid_content_Intent_Handler")]
		public virtual void AuthorizeCallback (int p0, int p1, global::Android.Content.Intent p2)
		{
			if (id_authorizeCallback_IILandroid_content_Intent_ == IntPtr.Zero)
				id_authorizeCallback_IILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "authorizeCallback", "(IILandroid/content/Intent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_authorizeCallback_IILandroid_content_Intent_, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "authorizeCallback", "(IILandroid/content/Intent;)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_dialog_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_Facebook_DialogListener_;
#pragma warning disable 0169
		static Delegate GetDialog_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_Facebook_DialogListener_Handler ()
		{
			if (cb_dialog_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_Facebook_DialogListener_ == null)
				cb_dialog_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_Facebook_DialogListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Dialog_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_Facebook_DialogListener_);
			return cb_dialog_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_Facebook_DialogListener_;
		}

		static void n_Dialog_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_Facebook_DialogListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener p3 = (global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Dialog (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_dialog_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_Facebook_DialogListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='dialog' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='com.facebook.android.Facebook.DialogListener']]"
		[Register ("dialog", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/android/Facebook$DialogListener;)V", "GetDialog_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_Facebook_DialogListener_Handler")]
		public virtual void Dialog (global::Android.Content.Context p0, string p1, global::Android.OS.Bundle p2, global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener p3)
		{
			if (id_dialog_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_Facebook_DialogListener_ == IntPtr.Zero)
				id_dialog_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_Facebook_DialogListener_ = JNIEnv.GetMethodID (class_ref, "dialog", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/android/Facebook$DialogListener;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dialog_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_Facebook_DialogListener_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dialog", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/android/Facebook$DialogListener;)V"), new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_dialog_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_android_Facebook_DialogListener_;
#pragma warning disable 0169
		static Delegate GetDialog_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_android_Facebook_DialogListener_Handler ()
		{
			if (cb_dialog_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_android_Facebook_DialogListener_ == null)
				cb_dialog_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_android_Facebook_DialogListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Dialog_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_android_Facebook_DialogListener_);
			return cb_dialog_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_android_Facebook_DialogListener_;
		}

		static void n_Dialog_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_android_Facebook_DialogListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener p2 = (global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Dialog (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_dialog_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_android_Facebook_DialogListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='dialog' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.facebook.android.Facebook.DialogListener']]"
		[Register ("dialog", "(Landroid/content/Context;Ljava/lang/String;Lcom/facebook/android/Facebook$DialogListener;)V", "GetDialog_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_android_Facebook_DialogListener_Handler")]
		public virtual void Dialog (global::Android.Content.Context p0, string p1, global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener p2)
		{
			if (id_dialog_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_android_Facebook_DialogListener_ == IntPtr.Zero)
				id_dialog_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_android_Facebook_DialogListener_ = JNIEnv.GetMethodID (class_ref, "dialog", "(Landroid/content/Context;Ljava/lang/String;Lcom/facebook/android/Facebook$DialogListener;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dialog_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_android_Facebook_DialogListener_, new JValue (p0), new JValue (native_p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dialog", "(Landroid/content/Context;Ljava/lang/String;Lcom/facebook/android/Facebook$DialogListener;)V"), new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_extendAccessToken_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_;
#pragma warning disable 0169
		static Delegate GetExtendAccessToken_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_Handler ()
		{
			if (cb_extendAccessToken_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_ == null)
				cb_extendAccessToken_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_ExtendAccessToken_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_);
			return cb_extendAccessToken_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_;
		}

		static bool n_ExtendAccessToken_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.XAndroid.Facebook.IServiceListener p1 = (global::Xamarin.FacebookBinding.XAndroid.Facebook.IServiceListener)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook.IServiceListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ExtendAccessToken (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_extendAccessToken_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='extendAccessToken' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.facebook.android.Facebook.ServiceListener']]"
		[Register ("extendAccessToken", "(Landroid/content/Context;Lcom/facebook/android/Facebook$ServiceListener;)Z", "GetExtendAccessToken_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_Handler")]
		public virtual bool ExtendAccessToken (global::Android.Content.Context p0, global::Xamarin.FacebookBinding.XAndroid.Facebook.IServiceListener p1)
		{
			if (id_extendAccessToken_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_ == IntPtr.Zero)
				id_extendAccessToken_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_ = JNIEnv.GetMethodID (class_ref, "extendAccessToken", "(Landroid/content/Context;Lcom/facebook/android/Facebook$ServiceListener;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_extendAccessToken_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "extendAccessToken", "(Landroid/content/Context;Lcom/facebook/android/Facebook$ServiceListener;)Z"), new JValue (p0), new JValue (p1));
			return __ret;
		}

		static Delegate cb_extendAccessTokenIfNeeded_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_;
#pragma warning disable 0169
		static Delegate GetExtendAccessTokenIfNeeded_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_Handler ()
		{
			if (cb_extendAccessTokenIfNeeded_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_ == null)
				cb_extendAccessTokenIfNeeded_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_ExtendAccessTokenIfNeeded_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_);
			return cb_extendAccessTokenIfNeeded_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_;
		}

		static bool n_ExtendAccessTokenIfNeeded_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.XAndroid.Facebook.IServiceListener p1 = (global::Xamarin.FacebookBinding.XAndroid.Facebook.IServiceListener)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook.IServiceListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ExtendAccessTokenIfNeeded (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_extendAccessTokenIfNeeded_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='extendAccessTokenIfNeeded' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.facebook.android.Facebook.ServiceListener']]"
		[Register ("extendAccessTokenIfNeeded", "(Landroid/content/Context;Lcom/facebook/android/Facebook$ServiceListener;)Z", "GetExtendAccessTokenIfNeeded_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_Handler")]
		public virtual bool ExtendAccessTokenIfNeeded (global::Android.Content.Context p0, global::Xamarin.FacebookBinding.XAndroid.Facebook.IServiceListener p1)
		{
			if (id_extendAccessTokenIfNeeded_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_ == IntPtr.Zero)
				id_extendAccessTokenIfNeeded_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_ = JNIEnv.GetMethodID (class_ref, "extendAccessTokenIfNeeded", "(Landroid/content/Context;Lcom/facebook/android/Facebook$ServiceListener;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_extendAccessTokenIfNeeded_Landroid_content_Context_Lcom_facebook_android_Facebook_ServiceListener_, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "extendAccessTokenIfNeeded", "(Landroid/content/Context;Lcom/facebook/android/Facebook$ServiceListener;)Z"), new JValue (p0), new JValue (p1));
			return __ret;
		}

		static IntPtr id_getAttributionId_Landroid_content_ContentResolver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='getAttributionId' and count(parameter)=1 and parameter[1][@type='android.content.ContentResolver']]"
		[Register ("getAttributionId", "(Landroid/content/ContentResolver;)Ljava/lang/String;", "")]
		public static string GetAttributionId (global::Android.Content.ContentResolver p0)
		{
			if (id_getAttributionId_Landroid_content_ContentResolver_ == IntPtr.Zero)
				id_getAttributionId_Landroid_content_ContentResolver_ = JNIEnv.GetStaticMethodID (class_ref, "getAttributionId", "(Landroid/content/ContentResolver;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAttributionId_Landroid_content_ContentResolver_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_logout_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetLogout_Landroid_content_Context_Handler ()
		{
			if (cb_logout_Landroid_content_Context_ == null)
				cb_logout_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Logout_Landroid_content_Context_);
			return cb_logout_Landroid_content_Context_;
		}

		static IntPtr n_Logout_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Logout (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_logout_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='logout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("logout", "(Landroid/content/Context;)Ljava/lang/String;", "GetLogout_Landroid_content_Context_Handler")]
		public virtual string Logout (global::Android.Content.Context p0)
		{
			if (id_logout_Landroid_content_Context_ == IntPtr.Zero)
				id_logout_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "logout", "(Landroid/content/Context;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_logout_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logout", "(Landroid/content/Context;)Ljava/lang/String;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_publishInstall_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetPublishInstall_Landroid_content_Context_Handler ()
		{
			if (cb_publishInstall_Landroid_content_Context_ == null)
				cb_publishInstall_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_PublishInstall_Landroid_content_Context_);
			return cb_publishInstall_Landroid_content_Context_;
		}

		static bool n_PublishInstall_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.PublishInstall (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_publishInstall_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='publishInstall' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("publishInstall", "(Landroid/content/Context;)Z", "GetPublishInstall_Landroid_content_Context_Handler")]
		public virtual bool PublishInstall (global::Android.Content.Context p0)
		{
			if (id_publishInstall_Landroid_content_Context_ == IntPtr.Zero)
				id_publishInstall_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "publishInstall", "(Landroid/content/Context;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_publishInstall_Landroid_content_Context_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "publishInstall", "(Landroid/content/Context;)Z"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_request_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetRequest_Landroid_os_Bundle_Handler ()
		{
			if (cb_request_Landroid_os_Bundle_ == null)
				cb_request_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Request_Landroid_os_Bundle_);
			return cb_request_Landroid_os_Bundle_;
		}

		static IntPtr n_Request_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Request (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_request_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='request' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("request", "(Landroid/os/Bundle;)Ljava/lang/String;", "GetRequest_Landroid_os_Bundle_Handler")]
		public virtual string Request (global::Android.OS.Bundle p0)
		{
			if (id_request_Landroid_os_Bundle_ == IntPtr.Zero)
				id_request_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "request", "(Landroid/os/Bundle;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_request_Landroid_os_Bundle_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "request", "(Landroid/os/Bundle;)Ljava/lang/String;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_request_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRequest_Ljava_lang_String_Handler ()
		{
			if (cb_request_Ljava_lang_String_ == null)
				cb_request_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Request_Ljava_lang_String_);
			return cb_request_Ljava_lang_String_;
		}

		static IntPtr n_Request_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Request (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_request_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='request' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("request", "(Ljava/lang/String;)Ljava/lang/String;", "GetRequest_Ljava_lang_String_Handler")]
		public virtual string Request (string p0)
		{
			if (id_request_Ljava_lang_String_ == IntPtr.Zero)
				id_request_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "request", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_request_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "request", "(Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_request_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetRequest_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_request_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_request_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Request_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_request_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static IntPtr n_Request_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Request (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_request_Ljava_lang_String_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='request' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("request", "(Ljava/lang/String;Landroid/os/Bundle;)Ljava/lang/String;", "GetRequest_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public virtual string Request (string p0, global::Android.OS.Bundle p1)
		{
			if (id_request_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_request_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "request", "(Ljava/lang/String;Landroid/os/Bundle;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_request_Ljava_lang_String_Landroid_os_Bundle_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "request", "(Ljava/lang/String;Landroid/os/Bundle;)Ljava/lang/String;"), new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRequest_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Handler ()
		{
			if (cb_request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_ == null)
				cb_request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_);
			return cb_request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_;
		}

		static IntPtr n_Request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Request (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='request' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='java.lang.String']]"
		[Register ("request", "(Ljava/lang/String;Landroid/os/Bundle;Ljava/lang/String;)Ljava/lang/String;", "GetRequest_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Handler")]
		public virtual string Request (string p0, global::Android.OS.Bundle p1, string p2)
		{
			if (id_request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_ == IntPtr.Zero)
				id_request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "request", "(Ljava/lang/String;Landroid/os/Bundle;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "request", "(Ljava/lang/String;Landroid/os/Bundle;Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_setAccessExpiresIn_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAccessExpiresIn_Ljava_lang_String_Handler ()
		{
			if (cb_setAccessExpiresIn_Ljava_lang_String_ == null)
				cb_setAccessExpiresIn_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAccessExpiresIn_Ljava_lang_String_);
			return cb_setAccessExpiresIn_Ljava_lang_String_;
		}

		static void n_SetAccessExpiresIn_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAccessExpiresIn (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAccessExpiresIn_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='setAccessExpiresIn' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAccessExpiresIn", "(Ljava/lang/String;)V", "GetSetAccessExpiresIn_Ljava_lang_String_Handler")]
		public virtual void SetAccessExpiresIn (string p0)
		{
			if (id_setAccessExpiresIn_Ljava_lang_String_ == IntPtr.Zero)
				id_setAccessExpiresIn_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAccessExpiresIn", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setAccessExpiresIn_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAccessExpiresIn", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setTokenFromCache_Ljava_lang_String_JJ;
#pragma warning disable 0169
		static Delegate GetSetTokenFromCache_Ljava_lang_String_JJHandler ()
		{
			if (cb_setTokenFromCache_Ljava_lang_String_JJ == null)
				cb_setTokenFromCache_Ljava_lang_String_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, long>) n_SetTokenFromCache_Ljava_lang_String_JJ);
			return cb_setTokenFromCache_Ljava_lang_String_JJ;
		}

		static void n_SetTokenFromCache_Ljava_lang_String_JJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTokenFromCache (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setTokenFromCache_Ljava_lang_String_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='setTokenFromCache' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("setTokenFromCache", "(Ljava/lang/String;JJ)V", "GetSetTokenFromCache_Ljava_lang_String_JJHandler")]
		public virtual void SetTokenFromCache (string p0, long p1, long p2)
		{
			if (id_setTokenFromCache_Ljava_lang_String_JJ == IntPtr.Zero)
				id_setTokenFromCache_Ljava_lang_String_JJ = JNIEnv.GetMethodID (class_ref, "setTokenFromCache", "(Ljava/lang/String;JJ)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setTokenFromCache_Ljava_lang_String_JJ, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTokenFromCache", "(Ljava/lang/String;JJ)V"), new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_shouldExtendAccessToken;
#pragma warning disable 0169
		static Delegate GetShouldExtendAccessTokenHandler ()
		{
			if (cb_shouldExtendAccessToken == null)
				cb_shouldExtendAccessToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShouldExtendAccessToken);
			return cb_shouldExtendAccessToken;
		}

		static bool n_ShouldExtendAccessToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.XAndroid.Facebook __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.Facebook> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldExtendAccessToken ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldExtendAccessToken;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='Facebook']/method[@name='shouldExtendAccessToken' and count(parameter)=0]"
		[Register ("shouldExtendAccessToken", "()Z", "GetShouldExtendAccessTokenHandler")]
		public virtual bool ShouldExtendAccessToken ()
		{
			if (id_shouldExtendAccessToken == IntPtr.Zero)
				id_shouldExtendAccessToken = JNIEnv.GetMethodID (class_ref, "shouldExtendAccessToken", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_shouldExtendAccessToken);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldExtendAccessToken", "()Z"));
		}

	}
}
