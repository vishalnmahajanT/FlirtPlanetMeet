using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='Session']"
	[global::Android.Runtime.Register ("com/facebook/Session", DoNotGenerateAcw=true)]
	public partial class Session : global::Java.Lang.Object, global::Java.IO.ISerializable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='Session']/field[@name='ACTION_ACTIVE_SESSION_CLOSED']"
		[Register ("ACTION_ACTIVE_SESSION_CLOSED")]
		public const string ActionActiveSessionClosed = (string) "com.facebook.sdk.ACTIVE_SESSION_CLOSED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='Session']/field[@name='ACTION_ACTIVE_SESSION_OPENED']"
		[Register ("ACTION_ACTIVE_SESSION_OPENED")]
		public const string ActionActiveSessionOpened = (string) "com.facebook.sdk.ACTIVE_SESSION_OPENED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='Session']/field[@name='ACTION_ACTIVE_SESSION_SET']"
		[Register ("ACTION_ACTIVE_SESSION_SET")]
		public const string ActionActiveSessionSet = (string) "com.facebook.sdk.ACTIVE_SESSION_SET";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='Session']/field[@name='ACTION_ACTIVE_SESSION_UNSET']"
		[Register ("ACTION_ACTIVE_SESSION_UNSET")]
		public const string ActionActiveSessionUnset = (string) "com.facebook.sdk.ACTIVE_SESSION_UNSET";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='Session']/field[@name='APPLICATION_ID_PROPERTY']"
		[Register ("APPLICATION_ID_PROPERTY")]
		public const string ApplicationIdProperty = (string) "com.facebook.sdk.ApplicationId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='Session']/field[@name='DEFAULT_AUTHORIZE_ACTIVITY_CODE']"
		[Register ("DEFAULT_AUTHORIZE_ACTIVITY_CODE")]
		public const int DefaultAuthorizeActivityCode = (int) 64206;

		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='Session']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, TAG_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='Session']/field[@name='WEB_VIEW_ERROR_CODE_KEY']"
		[Register ("WEB_VIEW_ERROR_CODE_KEY")]
		public const string WebViewErrorCodeKey = (string) "com.facebook.sdk.WebViewErrorCode";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='Session']/field[@name='WEB_VIEW_FAILING_URL_KEY']"
		[Register ("WEB_VIEW_FAILING_URL_KEY")]
		public const string WebViewFailingUrlKey = (string) "com.facebook.sdk.FailingUrl";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='Session.AuthorizationRequest']"
		[global::Android.Runtime.Register ("com/facebook/Session$AuthorizationRequest", DoNotGenerateAcw=true)]
		public partial class AuthorizationRequest : global::Java.Lang.Object, global::Java.IO.ISerializable {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='Session.AuthorizationRequest.AuthRequestSerializationProxyV1']"
			[global::Android.Runtime.Register ("com/facebook/Session$AuthorizationRequest$AuthRequestSerializationProxyV1", DoNotGenerateAcw=true)]
			public partial class AuthRequestSerializationProxyV1 : global::Java.Lang.Object, global::Java.IO.ISerializable {

				protected AuthRequestSerializationProxyV1 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/Session$AuthorizationRequest", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AuthorizationRequest); }
			}

			protected AuthorizationRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_setIsLegacy_Z;
#pragma warning disable 0169
			static Delegate GetSetIsLegacy_ZHandler ()
			{
				if (cb_setIsLegacy_Z == null)
					cb_setIsLegacy_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsLegacy_Z);
				return cb_setIsLegacy_Z;
			}

			static void n_SetIsLegacy_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Xamarin.FacebookBinding.Session.AuthorizationRequest __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.AuthorizationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetIsLegacy (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setIsLegacy_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session.AuthorizationRequest']/method[@name='setIsLegacy' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsLegacy", "(Z)V", "GetSetIsLegacy_ZHandler")]
			public virtual void SetIsLegacy (bool p0)
			{
				if (id_setIsLegacy_Z == IntPtr.Zero)
					id_setIsLegacy_Z = JNIEnv.GetMethodID (class_ref, "setIsLegacy", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setIsLegacy_Z, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsLegacy", "(Z)V"), new JValue (p0));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='Session.AutoPublishAsyncTask']"
		[global::Android.Runtime.Register ("com/facebook/Session$AutoPublishAsyncTask", DoNotGenerateAcw=true)]
		public partial class AutoPublishAsyncTask : global::Android.OS.AsyncTask {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/Session$AutoPublishAsyncTask", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AutoPublishAsyncTask); }
			}

			protected AutoPublishAsyncTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_facebook_Session_Ljava_lang_String_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='Session.AutoPublishAsyncTask']/constructor[@name='Session.AutoPublishAsyncTask' and count(parameter)=3 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.Context']]"
			[Register (".ctor", "(Lcom/facebook/Session;Ljava/lang/String;Landroid/content/Context;)V", "")]
			public AutoPublishAsyncTask (global::Xamarin.FacebookBinding.Session __self, string p1, global::Android.Content.Context p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);;
				if (GetType () != typeof (AutoPublishAsyncTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Landroid/content/Context;)V", new JValue (__self), new JValue (native_p1), new JValue (p2)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Landroid/content/Context;)V", new JValue (__self), new JValue (native_p1), new JValue (p2));
					JNIEnv.DeleteLocalRef (native_p1);
					return;
				}

				if (id_ctor_Lcom_facebook_Session_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Lcom_facebook_Session_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/Session;Ljava/lang/String;Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_Session_Ljava_lang_String_Landroid_content_Context_, new JValue (__self), new JValue (native_p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_facebook_Session_Ljava_lang_String_Landroid_content_Context_, new JValue (__self), new JValue (native_p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p1);
			}

			static Delegate cb_onPostExecute_Ljava_util_Collection_;
#pragma warning disable 0169
			static Delegate GetOnPostExecute_Ljava_util_Collection_Handler ()
			{
				if (cb_onPostExecute_Ljava_util_Collection_ == null)
					cb_onPostExecute_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPostExecute_Ljava_util_Collection_);
				return cb_onPostExecute_Ljava_util_Collection_;
			}

			static void n_OnPostExecute_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Session.AutoPublishAsyncTask __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.AutoPublishAsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.Collections.Generic.ICollection<Xamarin.FacebookBinding.Response> p0 = global::Android.Runtime.JavaCollection<global::Xamarin.FacebookBinding.Response>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPostExecute (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onPostExecute_Ljava_util_Collection_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session.AutoPublishAsyncTask']/method[@name='onPostExecute' and count(parameter)=1 and parameter[1][@type='java.util.Collection']]"
			[Register ("onPostExecute", "(Ljava/util/Collection;)V", "GetOnPostExecute_Ljava_util_Collection_Handler")]
			protected virtual void OnPostExecute (global::System.Collections.Generic.ICollection<global::Xamarin.FacebookBinding.Response> p0)
			{
				if (id_onPostExecute_Ljava_util_Collection_ == IntPtr.Zero)
					id_onPostExecute_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "onPostExecute", "(Ljava/util/Collection;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaCollection<global::Xamarin.FacebookBinding.Response>.ToLocalJniHandle (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onPostExecute_Ljava_util_Collection_, new JValue (native_p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPostExecute", "(Ljava/util/Collection;)V"), new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='Session.Builder']"
		[global::Android.Runtime.Register ("com/facebook/Session$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/Session$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='Session.Builder']/constructor[@name='Session.Builder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public Builder (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Builder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
			}

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/facebook/Session;", "")]
			public global::Xamarin.FacebookBinding.Session Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/facebook/Session;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_setApplicationId_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session.Builder']/method[@name='setApplicationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setApplicationId", "(Ljava/lang/String;)Lcom/facebook/Session$Builder;", "")]
			public global::Xamarin.FacebookBinding.Session.Builder SetApplicationId (string p0)
			{
				if (id_setApplicationId_Ljava_lang_String_ == IntPtr.Zero)
					id_setApplicationId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setApplicationId", "(Ljava/lang/String;)Lcom/facebook/Session$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Xamarin.FacebookBinding.Session.Builder __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setApplicationId_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_setTokenCachingStrategy_Lcom_facebook_TokenCachingStrategy_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session.Builder']/method[@name='setTokenCachingStrategy' and count(parameter)=1 and parameter[1][@type='com.facebook.TokenCachingStrategy']]"
			[Register ("setTokenCachingStrategy", "(Lcom/facebook/TokenCachingStrategy;)Lcom/facebook/Session$Builder;", "")]
			public global::Xamarin.FacebookBinding.Session.Builder SetTokenCachingStrategy (global::Xamarin.FacebookBinding.TokenCachingStrategy p0)
			{
				if (id_setTokenCachingStrategy_Lcom_facebook_TokenCachingStrategy_ == IntPtr.Zero)
					id_setTokenCachingStrategy_Lcom_facebook_TokenCachingStrategy_ = JNIEnv.GetMethodID (class_ref, "setTokenCachingStrategy", "(Lcom/facebook/TokenCachingStrategy;)Lcom/facebook/Session$Builder;");
				global::Xamarin.FacebookBinding.Session.Builder __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setTokenCachingStrategy_Lcom_facebook_TokenCachingStrategy_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='Session.NewPermissionsRequest']"
		[global::Android.Runtime.Register ("com/facebook/Session$NewPermissionsRequest", DoNotGenerateAcw=true)]
		public sealed partial class NewPermissionsRequest : global::Xamarin.FacebookBinding.Session.AuthorizationRequest {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/Session$NewPermissionsRequest", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NewPermissionsRequest); }
			}

			internal NewPermissionsRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_app_Activity_Ljava_util_List_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='Session.NewPermissionsRequest']/constructor[@name='Session.NewPermissionsRequest' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.util.List']]"
			[Register (".ctor", "(Landroid/app/Activity;Ljava/util/List;)V", "")]
			public NewPermissionsRequest (global::Android.App.Activity p0, global::System.Collections.Generic.IList<string> p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);;
				if (GetType () != typeof (NewPermissionsRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Activity;Ljava/util/List;)V", new JValue (p0), new JValue (native_p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/app/Activity;Ljava/util/List;)V", new JValue (p0), new JValue (native_p1));
					JNIEnv.DeleteLocalRef (native_p1);
					return;
				}

				if (id_ctor_Landroid_app_Activity_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_Ljava_util_List_, new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_app_Activity_Ljava_util_List_, new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
			}

			static IntPtr id_ctor_Landroid_support_v4_app_Fragment_Ljava_util_List_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='Session.NewPermissionsRequest']/constructor[@name='Session.NewPermissionsRequest' and count(parameter)=2 and parameter[1][@type='android.support.v4.app.Fragment'] and parameter[2][@type='java.util.List']]"
			[Register (".ctor", "(Landroid/support/v4/app/Fragment;Ljava/util/List;)V", "")]
			public NewPermissionsRequest (global::Android.Support.V4.App.Fragment p0, global::System.Collections.Generic.IList<string> p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);;
				if (GetType () != typeof (NewPermissionsRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/support/v4/app/Fragment;Ljava/util/List;)V", new JValue (p0), new JValue (native_p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/support/v4/app/Fragment;Ljava/util/List;)V", new JValue (p0), new JValue (native_p1));
					JNIEnv.DeleteLocalRef (native_p1);
					return;
				}

				if (id_ctor_Landroid_support_v4_app_Fragment_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Landroid_support_v4_app_Fragment_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/support/v4/app/Fragment;Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_support_v4_app_Fragment_Ljava_util_List_, new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_support_v4_app_Fragment_Ljava_util_List_, new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
			}

			static IntPtr id_setCallback_Lcom_facebook_Session_StatusCallback_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session.NewPermissionsRequest']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.facebook.Session.StatusCallback']]"
			[Register ("setCallback", "(Lcom/facebook/Session$StatusCallback;)Lcom/facebook/Session$NewPermissionsRequest;", "")]
			public global::Xamarin.FacebookBinding.Session.NewPermissionsRequest SetCallback (global::Xamarin.FacebookBinding.Session.IStatusCallback p0)
			{
				if (id_setCallback_Lcom_facebook_Session_StatusCallback_ == IntPtr.Zero)
					id_setCallback_Lcom_facebook_Session_StatusCallback_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lcom/facebook/Session$StatusCallback;)Lcom/facebook/Session$NewPermissionsRequest;");
				global::Xamarin.FacebookBinding.Session.NewPermissionsRequest __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.NewPermissionsRequest> (JNIEnv.CallObjectMethod  (Handle, id_setCallback_Lcom_facebook_Session_StatusCallback_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_setDefaultAudience_Lcom_facebook_SessionDefaultAudience_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session.NewPermissionsRequest']/method[@name='setDefaultAudience' and count(parameter)=1 and parameter[1][@type='com.facebook.SessionDefaultAudience']]"
			[Register ("setDefaultAudience", "(Lcom/facebook/SessionDefaultAudience;)Lcom/facebook/Session$NewPermissionsRequest;", "")]
			public global::Xamarin.FacebookBinding.Session.NewPermissionsRequest SetDefaultAudience (global::Xamarin.FacebookBinding.SessionDefaultAudience p0)
			{
				if (id_setDefaultAudience_Lcom_facebook_SessionDefaultAudience_ == IntPtr.Zero)
					id_setDefaultAudience_Lcom_facebook_SessionDefaultAudience_ = JNIEnv.GetMethodID (class_ref, "setDefaultAudience", "(Lcom/facebook/SessionDefaultAudience;)Lcom/facebook/Session$NewPermissionsRequest;");
				global::Xamarin.FacebookBinding.Session.NewPermissionsRequest __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.NewPermissionsRequest> (JNIEnv.CallObjectMethod  (Handle, id_setDefaultAudience_Lcom_facebook_SessionDefaultAudience_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_setLoginBehavior_Lcom_facebook_SessionLoginBehavior_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session.NewPermissionsRequest']/method[@name='setLoginBehavior' and count(parameter)=1 and parameter[1][@type='com.facebook.SessionLoginBehavior']]"
			[Register ("setLoginBehavior", "(Lcom/facebook/SessionLoginBehavior;)Lcom/facebook/Session$NewPermissionsRequest;", "")]
			public global::Xamarin.FacebookBinding.Session.NewPermissionsRequest SetLoginBehavior (global::Xamarin.FacebookBinding.SessionLoginBehavior p0)
			{
				if (id_setLoginBehavior_Lcom_facebook_SessionLoginBehavior_ == IntPtr.Zero)
					id_setLoginBehavior_Lcom_facebook_SessionLoginBehavior_ = JNIEnv.GetMethodID (class_ref, "setLoginBehavior", "(Lcom/facebook/SessionLoginBehavior;)Lcom/facebook/Session$NewPermissionsRequest;");
				global::Xamarin.FacebookBinding.Session.NewPermissionsRequest __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.NewPermissionsRequest> (JNIEnv.CallObjectMethod  (Handle, id_setLoginBehavior_Lcom_facebook_SessionLoginBehavior_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_setRequestCode_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session.NewPermissionsRequest']/method[@name='setRequestCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRequestCode", "(I)Lcom/facebook/Session$NewPermissionsRequest;", "")]
			public global::Xamarin.FacebookBinding.Session.NewPermissionsRequest SetRequestCode (int p0)
			{
				if (id_setRequestCode_I == IntPtr.Zero)
					id_setRequestCode_I = JNIEnv.GetMethodID (class_ref, "setRequestCode", "(I)Lcom/facebook/Session$NewPermissionsRequest;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.NewPermissionsRequest> (JNIEnv.CallObjectMethod  (Handle, id_setRequestCode_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='Session.OpenRequest']"
		[global::Android.Runtime.Register ("com/facebook/Session$OpenRequest", DoNotGenerateAcw=true)]
		public sealed partial class OpenRequest : global::Xamarin.FacebookBinding.Session.AuthorizationRequest {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/Session$OpenRequest", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (OpenRequest); }
			}

			internal OpenRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_app_Activity_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='Session.OpenRequest']/constructor[@name='Session.OpenRequest' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
			[Register (".ctor", "(Landroid/app/Activity;)V", "")]
			public OpenRequest (global::Android.App.Activity p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (OpenRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Activity;)V", new JValue (p0)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/app/Activity;)V", new JValue (p0));
					return;
				}

				if (id_ctor_Landroid_app_Activity_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_, new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_app_Activity_, new JValue (p0));
			}

			static IntPtr id_ctor_Landroid_support_v4_app_Fragment_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='Session.OpenRequest']/constructor[@name='Session.OpenRequest' and count(parameter)=1 and parameter[1][@type='android.support.v4.app.Fragment']]"
			[Register (".ctor", "(Landroid/support/v4/app/Fragment;)V", "")]
			public OpenRequest (global::Android.Support.V4.App.Fragment p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (OpenRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/support/v4/app/Fragment;)V", new JValue (p0)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/support/v4/app/Fragment;)V", new JValue (p0));
					return;
				}

				if (id_ctor_Landroid_support_v4_app_Fragment_ == IntPtr.Zero)
					id_ctor_Landroid_support_v4_app_Fragment_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/support/v4/app/Fragment;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_support_v4_app_Fragment_, new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_support_v4_app_Fragment_, new JValue (p0));
			}

			static IntPtr id_setCallback_Lcom_facebook_Session_StatusCallback_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session.OpenRequest']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.facebook.Session.StatusCallback']]"
			[Register ("setCallback", "(Lcom/facebook/Session$StatusCallback;)Lcom/facebook/Session$OpenRequest;", "")]
			public global::Xamarin.FacebookBinding.Session.OpenRequest SetCallback (global::Xamarin.FacebookBinding.Session.IStatusCallback p0)
			{
				if (id_setCallback_Lcom_facebook_Session_StatusCallback_ == IntPtr.Zero)
					id_setCallback_Lcom_facebook_Session_StatusCallback_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lcom/facebook/Session$StatusCallback;)Lcom/facebook/Session$OpenRequest;");
				global::Xamarin.FacebookBinding.Session.OpenRequest __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.OpenRequest> (JNIEnv.CallObjectMethod  (Handle, id_setCallback_Lcom_facebook_Session_StatusCallback_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_setDefaultAudience_Lcom_facebook_SessionDefaultAudience_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session.OpenRequest']/method[@name='setDefaultAudience' and count(parameter)=1 and parameter[1][@type='com.facebook.SessionDefaultAudience']]"
			[Register ("setDefaultAudience", "(Lcom/facebook/SessionDefaultAudience;)Lcom/facebook/Session$OpenRequest;", "")]
			public global::Xamarin.FacebookBinding.Session.OpenRequest SetDefaultAudience (global::Xamarin.FacebookBinding.SessionDefaultAudience p0)
			{
				if (id_setDefaultAudience_Lcom_facebook_SessionDefaultAudience_ == IntPtr.Zero)
					id_setDefaultAudience_Lcom_facebook_SessionDefaultAudience_ = JNIEnv.GetMethodID (class_ref, "setDefaultAudience", "(Lcom/facebook/SessionDefaultAudience;)Lcom/facebook/Session$OpenRequest;");
				global::Xamarin.FacebookBinding.Session.OpenRequest __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.OpenRequest> (JNIEnv.CallObjectMethod  (Handle, id_setDefaultAudience_Lcom_facebook_SessionDefaultAudience_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_setLoginBehavior_Lcom_facebook_SessionLoginBehavior_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session.OpenRequest']/method[@name='setLoginBehavior' and count(parameter)=1 and parameter[1][@type='com.facebook.SessionLoginBehavior']]"
			[Register ("setLoginBehavior", "(Lcom/facebook/SessionLoginBehavior;)Lcom/facebook/Session$OpenRequest;", "")]
			public global::Xamarin.FacebookBinding.Session.OpenRequest SetLoginBehavior (global::Xamarin.FacebookBinding.SessionLoginBehavior p0)
			{
				if (id_setLoginBehavior_Lcom_facebook_SessionLoginBehavior_ == IntPtr.Zero)
					id_setLoginBehavior_Lcom_facebook_SessionLoginBehavior_ = JNIEnv.GetMethodID (class_ref, "setLoginBehavior", "(Lcom/facebook/SessionLoginBehavior;)Lcom/facebook/Session$OpenRequest;");
				global::Xamarin.FacebookBinding.Session.OpenRequest __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.OpenRequest> (JNIEnv.CallObjectMethod  (Handle, id_setLoginBehavior_Lcom_facebook_SessionLoginBehavior_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_setPermissions_Ljava_util_List_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session.OpenRequest']/method[@name='setPermissions' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
			[Register ("setPermissions", "(Ljava/util/List;)Lcom/facebook/Session$OpenRequest;", "")]
			public global::Xamarin.FacebookBinding.Session.OpenRequest SetPermissions (global::System.Collections.Generic.IList<string> p0)
			{
				if (id_setPermissions_Ljava_util_List_ == IntPtr.Zero)
					id_setPermissions_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setPermissions", "(Ljava/util/List;)Lcom/facebook/Session$OpenRequest;");
				IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
				global::Xamarin.FacebookBinding.Session.OpenRequest __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.OpenRequest> (JNIEnv.CallObjectMethod  (Handle, id_setPermissions_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_setRequestCode_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session.OpenRequest']/method[@name='setRequestCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRequestCode", "(I)Lcom/facebook/Session$OpenRequest;", "")]
			public global::Xamarin.FacebookBinding.Session.OpenRequest SetRequestCode (int p0)
			{
				if (id_setRequestCode_I == IntPtr.Zero)
					id_setRequestCode_I = JNIEnv.GetMethodID (class_ref, "setRequestCode", "(I)Lcom/facebook/Session$OpenRequest;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.OpenRequest> (JNIEnv.CallObjectMethod  (Handle, id_setRequestCode_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='Session.SerializationProxyV1']"
		[global::Android.Runtime.Register ("com/facebook/Session$SerializationProxyV1", DoNotGenerateAcw=true)]
		public partial class SerializationProxyV1 : global::Java.Lang.Object, global::Java.IO.ISerializable {

			protected SerializationProxyV1 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook']/interface[@name='Session.StartActivityDelegate']"
		[Register ("com/facebook/Session$StartActivityDelegate", "", "Xamarin.FacebookBinding.Session/IStartActivityDelegateInvoker")]
		public partial interface IStartActivityDelegate : IJavaObject {

			global::Android.App.Activity ActivityContext {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/interface[@name='Session.StartActivityDelegate']/method[@name='getActivityContext' and count(parameter)=0]"
				[Register ("getActivityContext", "()Landroid/app/Activity;", "GetGetActivityContextHandler:Xamarin.FacebookBinding.Session/IStartActivityDelegateInvoker, Xamarin.Facebook")] get;
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/interface[@name='Session.StartActivityDelegate']/method[@name='startActivityForResult' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='int']]"
			[Register ("startActivityForResult", "(Landroid/content/Intent;I)V", "GetStartActivityForResult_Landroid_content_Intent_IHandler:Xamarin.FacebookBinding.Session/IStartActivityDelegateInvoker, Xamarin.Facebook")]
			void StartActivityForResult (global::Android.Content.Intent p0, int p1);

		}

		[global::Android.Runtime.Register ("com/facebook/Session$StartActivityDelegate", DoNotGenerateAcw=true)]
		internal class IStartActivityDelegateInvoker : global::Java.Lang.Object, IStartActivityDelegate {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/Session$StartActivityDelegate");
			IntPtr class_ref;

			public static IStartActivityDelegate GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IStartActivityDelegate> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.Session.StartActivityDelegate"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IStartActivityDelegateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IStartActivityDelegateInvoker); }
			}

			static Delegate cb_getActivityContext;
#pragma warning disable 0169
			static Delegate GetGetActivityContextHandler ()
			{
				if (cb_getActivityContext == null)
					cb_getActivityContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActivityContext);
				return cb_getActivityContext;
			}

			static IntPtr n_GetActivityContext (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.Session.IStartActivityDelegate __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.IStartActivityDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ActivityContext);
			}
#pragma warning restore 0169

			IntPtr id_getActivityContext;
			public global::Android.App.Activity ActivityContext {
				get {
					if (id_getActivityContext == IntPtr.Zero)
						id_getActivityContext = JNIEnv.GetMethodID (class_ref, "getActivityContext", "()Landroid/app/Activity;");
					return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (JNIEnv.CallObjectMethod (Handle, id_getActivityContext), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_startActivityForResult_Landroid_content_Intent_I;
#pragma warning disable 0169
			static Delegate GetStartActivityForResult_Landroid_content_Intent_IHandler ()
			{
				if (cb_startActivityForResult_Landroid_content_Intent_I == null)
					cb_startActivityForResult_Landroid_content_Intent_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_StartActivityForResult_Landroid_content_Intent_I);
				return cb_startActivityForResult_Landroid_content_Intent_I;
			}

			static void n_StartActivityForResult_Landroid_content_Intent_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::Xamarin.FacebookBinding.Session.IStartActivityDelegate __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.IStartActivityDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.StartActivityForResult (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_startActivityForResult_Landroid_content_Intent_I;
			public void StartActivityForResult (global::Android.Content.Intent p0, int p1)
			{
				if (id_startActivityForResult_Landroid_content_Intent_I == IntPtr.Zero)
					id_startActivityForResult_Landroid_content_Intent_I = JNIEnv.GetMethodID (class_ref, "startActivityForResult", "(Landroid/content/Intent;I)V");
				JNIEnv.CallVoidMethod (Handle, id_startActivityForResult_Landroid_content_Intent_I, new JValue (p0), new JValue (p1));
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook']/interface[@name='Session.StatusCallback']"
		[Register ("com/facebook/Session$StatusCallback", "", "Xamarin.FacebookBinding.Session/IStatusCallbackInvoker")]
		public partial interface IStatusCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/interface[@name='Session.StatusCallback']/method[@name='call' and count(parameter)=3 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='com.facebook.SessionState'] and parameter[3][@type='java.lang.Exception']]"
			[Register ("call", "(Lcom/facebook/Session;Lcom/facebook/SessionState;Ljava/lang/Exception;)V", "GetCall_Lcom_facebook_Session_Lcom_facebook_SessionState_Ljava_lang_Exception_Handler:Xamarin.FacebookBinding.Session/IStatusCallbackInvoker, Xamarin.Facebook")]
			void Call (global::Xamarin.FacebookBinding.Session p0, global::Xamarin.FacebookBinding.SessionState p1, global::Java.Lang.Exception p2);

		}

		[global::Android.Runtime.Register ("com/facebook/Session$StatusCallback", DoNotGenerateAcw=true)]
		internal class IStatusCallbackInvoker : global::Java.Lang.Object, IStatusCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/Session$StatusCallback");
			IntPtr class_ref;

			public static IStatusCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IStatusCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.Session.StatusCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IStatusCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IStatusCallbackInvoker); }
			}

			static Delegate cb_call_Lcom_facebook_Session_Lcom_facebook_SessionState_Ljava_lang_Exception_;
#pragma warning disable 0169
			static Delegate GetCall_Lcom_facebook_Session_Lcom_facebook_SessionState_Ljava_lang_Exception_Handler ()
			{
				if (cb_call_Lcom_facebook_Session_Lcom_facebook_SessionState_Ljava_lang_Exception_ == null)
					cb_call_Lcom_facebook_Session_Lcom_facebook_SessionState_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Call_Lcom_facebook_Session_Lcom_facebook_SessionState_Ljava_lang_Exception_);
				return cb_call_Lcom_facebook_Session_Lcom_facebook_SessionState_Ljava_lang_Exception_;
			}

			static void n_Call_Lcom_facebook_Session_Lcom_facebook_SessionState_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Xamarin.FacebookBinding.Session.IStatusCallback __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.IStatusCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.Session p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.SessionState p1 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionState> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Exception p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.Call (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_call_Lcom_facebook_Session_Lcom_facebook_SessionState_Ljava_lang_Exception_;
			public void Call (global::Xamarin.FacebookBinding.Session p0, global::Xamarin.FacebookBinding.SessionState p1, global::Java.Lang.Exception p2)
			{
				if (id_call_Lcom_facebook_Session_Lcom_facebook_SessionState_Ljava_lang_Exception_ == IntPtr.Zero)
					id_call_Lcom_facebook_Session_Lcom_facebook_SessionState_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "call", "(Lcom/facebook/Session;Lcom/facebook/SessionState;Ljava/lang/Exception;)V");
				JNIEnv.CallVoidMethod (Handle, id_call_Lcom_facebook_Session_Lcom_facebook_SessionState_Ljava_lang_Exception_, new JValue (p0), new JValue (p1), new JValue (p2));
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='Session.TokenRefreshRequest']"
		[global::Android.Runtime.Register ("com/facebook/Session$TokenRefreshRequest", DoNotGenerateAcw=true)]
		public partial class TokenRefreshRequest : global::Java.Lang.Object, global::Android.Content.IServiceConnection {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/Session$TokenRefreshRequest", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TokenRefreshRequest); }
			}

			protected TokenRefreshRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_bind;
#pragma warning disable 0169
			static Delegate GetBindHandler ()
			{
				if (cb_bind == null)
					cb_bind = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Bind);
				return cb_bind;
			}

			static void n_Bind (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.Session.TokenRefreshRequest __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.TokenRefreshRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Bind ();
			}
#pragma warning restore 0169

			static IntPtr id_bind;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session.TokenRefreshRequest']/method[@name='bind' and count(parameter)=0]"
			[Register ("bind", "()V", "GetBindHandler")]
			public virtual void Bind ()
			{
				if (id_bind == IntPtr.Zero)
					id_bind = JNIEnv.GetMethodID (class_ref, "bind", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_bind);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bind", "()V"));
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
				global::Xamarin.FacebookBinding.Session.TokenRefreshRequest __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.TokenRefreshRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.ComponentName p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.IBinder p1 = (global::Android.OS.IBinder)global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnServiceConnected (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session.TokenRefreshRequest']/method[@name='onServiceConnected' and count(parameter)=2 and parameter[1][@type='android.content.ComponentName'] and parameter[2][@type='android.os.IBinder']]"
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
				global::Xamarin.FacebookBinding.Session.TokenRefreshRequest __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.TokenRefreshRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.ComponentName p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnServiceDisconnected (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onServiceDisconnected_Landroid_content_ComponentName_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session.TokenRefreshRequest']/method[@name='onServiceDisconnected' and count(parameter)=1 and parameter[1][@type='android.content.ComponentName']]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='Session.TokenRefreshRequestHandler']"
		[global::Android.Runtime.Register ("com/facebook/Session$TokenRefreshRequestHandler", DoNotGenerateAcw=true)]
		public partial class TokenRefreshRequestHandler : global::Android.OS.Handler {

			protected TokenRefreshRequestHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/Session", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Session); }
		}

		protected Session (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='Session']/constructor[@name='Session' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public Session (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Session)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_getAccessToken;
		public string AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session']/method[@name='getAccessToken' and count(parameter)=0]"
			[Register ("getAccessToken", "()Ljava/lang/String;", "GetGetAccessTokenHandler")]
			get {
				if (id_getAccessToken == IntPtr.Zero)
					id_getAccessToken = JNIEnv.GetMethodID (class_ref, "getAccessToken", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAccessToken), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getActiveSession;
		static IntPtr id_setActiveSession_Lcom_facebook_Session_;
		public static global::Xamarin.FacebookBinding.Session ActiveSession {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session']/method[@name='getActiveSession' and count(parameter)=0]"
			[Register ("getActiveSession", "()Lcom/facebook/Session;", "GetGetActiveSessionHandler")]
			get {
				if (id_getActiveSession == IntPtr.Zero)
					id_getActiveSession = JNIEnv.GetStaticMethodID (class_ref, "getActiveSession", "()Lcom/facebook/Session;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getActiveSession), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session']/method[@name='setActiveSession' and count(parameter)=1 and parameter[1][@type='com.facebook.Session']]"
			[Register ("setActiveSession", "(Lcom/facebook/Session;)V", "GetSetActiveSession_Lcom_facebook_Session_Handler")]
			set {
				if (id_setActiveSession_Lcom_facebook_Session_ == IntPtr.Zero)
					id_setActiveSession_Lcom_facebook_Session_ = JNIEnv.GetStaticMethodID (class_ref, "setActiveSession", "(Lcom/facebook/Session;)V");
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setActiveSession_Lcom_facebook_Session_, new JValue (value));
			}
		}

		static IntPtr id_getApplicationId;
		public string ApplicationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session']/method[@name='getApplicationId' and count(parameter)=0]"
			[Register ("getApplicationId", "()Ljava/lang/String;", "GetGetApplicationIdHandler")]
			get {
				if (id_getApplicationId == IntPtr.Zero)
					id_getApplicationId = JNIEnv.GetMethodID (class_ref, "getApplicationId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getApplicationId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getAuthorizationBundle;
		public global::Android.OS.Bundle AuthorizationBundle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session']/method[@name='getAuthorizationBundle' and count(parameter)=0]"
			[Register ("getAuthorizationBundle", "()Landroid/os/Bundle;", "GetGetAuthorizationBundleHandler")]
			get {
				if (id_getAuthorizationBundle == IntPtr.Zero)
					id_getAuthorizationBundle = JNIEnv.GetMethodID (class_ref, "getAuthorizationBundle", "()Landroid/os/Bundle;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_getAuthorizationBundle), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getExpirationDate;
		public global::Java.Util.Date ExpirationDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session']/method[@name='getExpirationDate' and count(parameter)=0]"
			[Register ("getExpirationDate", "()Ljava/util/Date;", "GetGetExpirationDateHandler")]
			get {
				if (id_getExpirationDate == IntPtr.Zero)
					id_getExpirationDate = JNIEnv.GetMethodID (class_ref, "getExpirationDate", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getExpirationDate), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isClosed;
		public bool IsClosed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session']/method[@name='isClosed' and count(parameter)=0]"
			[Register ("isClosed", "()Z", "GetIsClosedHandler")]
			get {
				if (id_isClosed == IntPtr.Zero)
					id_isClosed = JNIEnv.GetMethodID (class_ref, "isClosed", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isClosed);
			}
		}

		static IntPtr id_isOpened;
		public bool IsOpened {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session']/method[@name='isOpened' and count(parameter)=0]"
			[Register ("isOpened", "()Z", "GetIsOpenedHandler")]
			get {
				if (id_isOpened == IntPtr.Zero)
					id_isOpened = JNIEnv.GetMethodID (class_ref, "isOpened", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isOpened);
			}
		}

		static IntPtr id_getPermissions;
		public global::System.Collections.Generic.IList<string> Permissions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session']/method[@name='getPermissions' and count(parameter)=0]"
			[Register ("getPermissions", "()Ljava/util/List;", "GetGetPermissionsHandler")]
			get {
				if (id_getPermissions == IntPtr.Zero)
					id_getPermissions = JNIEnv.GetMethodID (class_ref, "getPermissions", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPermissions), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getState;
		public global::Xamarin.FacebookBinding.SessionState State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Lcom/facebook/SessionState;", "GetGetStateHandler")]
			get {
				if (id_getState == IntPtr.Zero)
					id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()Lcom/facebook/SessionState;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionState> (JNIEnv.CallObjectMethod  (Handle, id_getState), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_addCallback_Lcom_facebook_Session_StatusCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session']/method[@name='addCallback' and count(parameter)=1 and parameter[1][@type='com.facebook.Session.StatusCallback']]"
		[Register ("addCallback", "(Lcom/facebook/Session$StatusCallback;)V", "")]
		public void AddCallback (global::Xamarin.FacebookBinding.Session.IStatusCallback p0)
		{
			if (id_addCallback_Lcom_facebook_Session_StatusCallback_ == IntPtr.Zero)
				id_addCallback_Lcom_facebook_Session_StatusCallback_ = JNIEnv.GetMethodID (class_ref, "addCallback", "(Lcom/facebook/Session$StatusCallback;)V");
			JNIEnv.CallVoidMethod  (Handle, id_addCallback_Lcom_facebook_Session_StatusCallback_, new JValue (p0));
		}

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_close);
		}

		static IntPtr id_closeAndClearTokenInformation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session']/method[@name='closeAndClearTokenInformation' and count(parameter)=0]"
		[Register ("closeAndClearTokenInformation", "()V", "")]
		public void CloseAndClearTokenInformation ()
		{
			if (id_closeAndClearTokenInformation == IntPtr.Zero)
				id_closeAndClearTokenInformation = JNIEnv.GetMethodID (class_ref, "closeAndClearTokenInformation", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_closeAndClearTokenInformation);
		}

		static IntPtr id_onActivityResult_Landroid_app_Activity_IILandroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session']/method[@name='onActivityResult' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.content.Intent']]"
		[Register ("onActivityResult", "(Landroid/app/Activity;IILandroid/content/Intent;)Z", "")]
		public bool OnActivityResult (global::Android.App.Activity p0, int p1, int p2, global::Android.Content.Intent p3)
		{
			if (id_onActivityResult_Landroid_app_Activity_IILandroid_content_Intent_ == IntPtr.Zero)
				id_onActivityResult_Landroid_app_Activity_IILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onActivityResult", "(Landroid/app/Activity;IILandroid/content/Intent;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_onActivityResult_Landroid_app_Activity_IILandroid_content_Intent_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			return __ret;
		}

		static IntPtr id_open_Lcom_facebook_AccessToken_Lcom_facebook_Session_StatusCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session']/method[@name='open' and count(parameter)=2 and parameter[1][@type='com.facebook.AccessToken'] and parameter[2][@type='com.facebook.Session.StatusCallback']]"
		[Register ("open", "(Lcom/facebook/AccessToken;Lcom/facebook/Session$StatusCallback;)V", "")]
		public void Open (global::Xamarin.FacebookBinding.AccessToken p0, global::Xamarin.FacebookBinding.Session.IStatusCallback p1)
		{
			if (id_open_Lcom_facebook_AccessToken_Lcom_facebook_Session_StatusCallback_ == IntPtr.Zero)
				id_open_Lcom_facebook_AccessToken_Lcom_facebook_Session_StatusCallback_ = JNIEnv.GetMethodID (class_ref, "open", "(Lcom/facebook/AccessToken;Lcom/facebook/Session$StatusCallback;)V");
			JNIEnv.CallVoidMethod  (Handle, id_open_Lcom_facebook_AccessToken_Lcom_facebook_Session_StatusCallback_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_openActiveSession_Landroid_app_Activity_ZLcom_facebook_Session_StatusCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session']/method[@name='openActiveSession' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='boolean'] and parameter[3][@type='com.facebook.Session.StatusCallback']]"
		[Register ("openActiveSession", "(Landroid/app/Activity;ZLcom/facebook/Session$StatusCallback;)Lcom/facebook/Session;", "")]
		public static global::Xamarin.FacebookBinding.Session OpenActiveSession (global::Android.App.Activity p0, bool p1, global::Xamarin.FacebookBinding.Session.IStatusCallback p2)
		{
			if (id_openActiveSession_Landroid_app_Activity_ZLcom_facebook_Session_StatusCallback_ == IntPtr.Zero)
				id_openActiveSession_Landroid_app_Activity_ZLcom_facebook_Session_StatusCallback_ = JNIEnv.GetStaticMethodID (class_ref, "openActiveSession", "(Landroid/app/Activity;ZLcom/facebook/Session$StatusCallback;)Lcom/facebook/Session;");
			global::Xamarin.FacebookBinding.Session __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (JNIEnv.CallStaticObjectMethod  (class_ref, id_openActiveSession_Landroid_app_Activity_ZLcom_facebook_Session_StatusCallback_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_openActiveSession_Landroid_content_Context_Landroid_support_v4_app_Fragment_ZLcom_facebook_Session_StatusCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session']/method[@name='openActiveSession' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.support.v4.app.Fragment'] and parameter[3][@type='boolean'] and parameter[4][@type='com.facebook.Session.StatusCallback']]"
		[Register ("openActiveSession", "(Landroid/content/Context;Landroid/support/v4/app/Fragment;ZLcom/facebook/Session$StatusCallback;)Lcom/facebook/Session;", "")]
		public static global::Xamarin.FacebookBinding.Session OpenActiveSession (global::Android.Content.Context p0, global::Android.Support.V4.App.Fragment p1, bool p2, global::Xamarin.FacebookBinding.Session.IStatusCallback p3)
		{
			if (id_openActiveSession_Landroid_content_Context_Landroid_support_v4_app_Fragment_ZLcom_facebook_Session_StatusCallback_ == IntPtr.Zero)
				id_openActiveSession_Landroid_content_Context_Landroid_support_v4_app_Fragment_ZLcom_facebook_Session_StatusCallback_ = JNIEnv.GetStaticMethodID (class_ref, "openActiveSession", "(Landroid/content/Context;Landroid/support/v4/app/Fragment;ZLcom/facebook/Session$StatusCallback;)Lcom/facebook/Session;");
			global::Xamarin.FacebookBinding.Session __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (JNIEnv.CallStaticObjectMethod  (class_ref, id_openActiveSession_Landroid_content_Context_Landroid_support_v4_app_Fragment_ZLcom_facebook_Session_StatusCallback_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_openActiveSessionFromCache_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session']/method[@name='openActiveSessionFromCache' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("openActiveSessionFromCache", "(Landroid/content/Context;)Lcom/facebook/Session;", "")]
		public static global::Xamarin.FacebookBinding.Session OpenActiveSessionFromCache (global::Android.Content.Context p0)
		{
			if (id_openActiveSessionFromCache_Landroid_content_Context_ == IntPtr.Zero)
				id_openActiveSessionFromCache_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "openActiveSessionFromCache", "(Landroid/content/Context;)Lcom/facebook/Session;");
			global::Xamarin.FacebookBinding.Session __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (JNIEnv.CallStaticObjectMethod  (class_ref, id_openActiveSessionFromCache_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_openActiveSessionWithAccessToken_Landroid_content_Context_Lcom_facebook_AccessToken_Lcom_facebook_Session_StatusCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session']/method[@name='openActiveSessionWithAccessToken' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.facebook.AccessToken'] and parameter[3][@type='com.facebook.Session.StatusCallback']]"
		[Register ("openActiveSessionWithAccessToken", "(Landroid/content/Context;Lcom/facebook/AccessToken;Lcom/facebook/Session$StatusCallback;)Lcom/facebook/Session;", "")]
		public static global::Xamarin.FacebookBinding.Session OpenActiveSessionWithAccessToken (global::Android.Content.Context p0, global::Xamarin.FacebookBinding.AccessToken p1, global::Xamarin.FacebookBinding.Session.IStatusCallback p2)
		{
			if (id_openActiveSessionWithAccessToken_Landroid_content_Context_Lcom_facebook_AccessToken_Lcom_facebook_Session_StatusCallback_ == IntPtr.Zero)
				id_openActiveSessionWithAccessToken_Landroid_content_Context_Lcom_facebook_AccessToken_Lcom_facebook_Session_StatusCallback_ = JNIEnv.GetStaticMethodID (class_ref, "openActiveSessionWithAccessToken", "(Landroid/content/Context;Lcom/facebook/AccessToken;Lcom/facebook/Session$StatusCallback;)Lcom/facebook/Session;");
			global::Xamarin.FacebookBinding.Session __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (JNIEnv.CallStaticObjectMethod  (class_ref, id_openActiveSessionWithAccessToken_Landroid_content_Context_Lcom_facebook_AccessToken_Lcom_facebook_Session_StatusCallback_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_openForPublish_Lcom_facebook_Session_OpenRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session']/method[@name='openForPublish' and count(parameter)=1 and parameter[1][@type='com.facebook.Session.OpenRequest']]"
		[Register ("openForPublish", "(Lcom/facebook/Session$OpenRequest;)V", "")]
		public void OpenForPublish (global::Xamarin.FacebookBinding.Session.OpenRequest p0)
		{
			if (id_openForPublish_Lcom_facebook_Session_OpenRequest_ == IntPtr.Zero)
				id_openForPublish_Lcom_facebook_Session_OpenRequest_ = JNIEnv.GetMethodID (class_ref, "openForPublish", "(Lcom/facebook/Session$OpenRequest;)V");
			JNIEnv.CallVoidMethod  (Handle, id_openForPublish_Lcom_facebook_Session_OpenRequest_, new JValue (p0));
		}

		static IntPtr id_openForRead_Lcom_facebook_Session_OpenRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session']/method[@name='openForRead' and count(parameter)=1 and parameter[1][@type='com.facebook.Session.OpenRequest']]"
		[Register ("openForRead", "(Lcom/facebook/Session$OpenRequest;)V", "")]
		public void OpenForRead (global::Xamarin.FacebookBinding.Session.OpenRequest p0)
		{
			if (id_openForRead_Lcom_facebook_Session_OpenRequest_ == IntPtr.Zero)
				id_openForRead_Lcom_facebook_Session_OpenRequest_ = JNIEnv.GetMethodID (class_ref, "openForRead", "(Lcom/facebook/Session$OpenRequest;)V");
			JNIEnv.CallVoidMethod  (Handle, id_openForRead_Lcom_facebook_Session_OpenRequest_, new JValue (p0));
		}

		static IntPtr id_removeCallback_Lcom_facebook_Session_StatusCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session']/method[@name='removeCallback' and count(parameter)=1 and parameter[1][@type='com.facebook.Session.StatusCallback']]"
		[Register ("removeCallback", "(Lcom/facebook/Session$StatusCallback;)V", "")]
		public void RemoveCallback (global::Xamarin.FacebookBinding.Session.IStatusCallback p0)
		{
			if (id_removeCallback_Lcom_facebook_Session_StatusCallback_ == IntPtr.Zero)
				id_removeCallback_Lcom_facebook_Session_StatusCallback_ = JNIEnv.GetMethodID (class_ref, "removeCallback", "(Lcom/facebook/Session$StatusCallback;)V");
			JNIEnv.CallVoidMethod  (Handle, id_removeCallback_Lcom_facebook_Session_StatusCallback_, new JValue (p0));
		}

		static IntPtr id_requestNewPublishPermissions_Lcom_facebook_Session_NewPermissionsRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session']/method[@name='requestNewPublishPermissions' and count(parameter)=1 and parameter[1][@type='com.facebook.Session.NewPermissionsRequest']]"
		[Register ("requestNewPublishPermissions", "(Lcom/facebook/Session$NewPermissionsRequest;)V", "")]
		public void RequestNewPublishPermissions (global::Xamarin.FacebookBinding.Session.NewPermissionsRequest p0)
		{
			if (id_requestNewPublishPermissions_Lcom_facebook_Session_NewPermissionsRequest_ == IntPtr.Zero)
				id_requestNewPublishPermissions_Lcom_facebook_Session_NewPermissionsRequest_ = JNIEnv.GetMethodID (class_ref, "requestNewPublishPermissions", "(Lcom/facebook/Session$NewPermissionsRequest;)V");
			JNIEnv.CallVoidMethod  (Handle, id_requestNewPublishPermissions_Lcom_facebook_Session_NewPermissionsRequest_, new JValue (p0));
		}

		static IntPtr id_requestNewReadPermissions_Lcom_facebook_Session_NewPermissionsRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session']/method[@name='requestNewReadPermissions' and count(parameter)=1 and parameter[1][@type='com.facebook.Session.NewPermissionsRequest']]"
		[Register ("requestNewReadPermissions", "(Lcom/facebook/Session$NewPermissionsRequest;)V", "")]
		public void RequestNewReadPermissions (global::Xamarin.FacebookBinding.Session.NewPermissionsRequest p0)
		{
			if (id_requestNewReadPermissions_Lcom_facebook_Session_NewPermissionsRequest_ == IntPtr.Zero)
				id_requestNewReadPermissions_Lcom_facebook_Session_NewPermissionsRequest_ = JNIEnv.GetMethodID (class_ref, "requestNewReadPermissions", "(Lcom/facebook/Session$NewPermissionsRequest;)V");
			JNIEnv.CallVoidMethod  (Handle, id_requestNewReadPermissions_Lcom_facebook_Session_NewPermissionsRequest_, new JValue (p0));
		}

		static IntPtr id_restoreSession_Landroid_content_Context_Lcom_facebook_TokenCachingStrategy_Lcom_facebook_Session_StatusCallback_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session']/method[@name='restoreSession' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.facebook.TokenCachingStrategy'] and parameter[3][@type='com.facebook.Session.StatusCallback'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("restoreSession", "(Landroid/content/Context;Lcom/facebook/TokenCachingStrategy;Lcom/facebook/Session$StatusCallback;Landroid/os/Bundle;)Lcom/facebook/Session;", "")]
		public static global::Xamarin.FacebookBinding.Session RestoreSession (global::Android.Content.Context p0, global::Xamarin.FacebookBinding.TokenCachingStrategy p1, global::Xamarin.FacebookBinding.Session.IStatusCallback p2, global::Android.OS.Bundle p3)
		{
			if (id_restoreSession_Landroid_content_Context_Lcom_facebook_TokenCachingStrategy_Lcom_facebook_Session_StatusCallback_Landroid_os_Bundle_ == IntPtr.Zero)
				id_restoreSession_Landroid_content_Context_Lcom_facebook_TokenCachingStrategy_Lcom_facebook_Session_StatusCallback_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "restoreSession", "(Landroid/content/Context;Lcom/facebook/TokenCachingStrategy;Lcom/facebook/Session$StatusCallback;Landroid/os/Bundle;)Lcom/facebook/Session;");
			global::Xamarin.FacebookBinding.Session __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (JNIEnv.CallStaticObjectMethod  (class_ref, id_restoreSession_Landroid_content_Context_Lcom_facebook_TokenCachingStrategy_Lcom_facebook_Session_StatusCallback_Landroid_os_Bundle_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_saveSession_Lcom_facebook_Session_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Session']/method[@name='saveSession' and count(parameter)=2 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("saveSession", "(Lcom/facebook/Session;Landroid/os/Bundle;)V", "")]
		public static void SaveSession (global::Xamarin.FacebookBinding.Session p0, global::Android.OS.Bundle p1)
		{
			if (id_saveSession_Lcom_facebook_Session_Landroid_os_Bundle_ == IntPtr.Zero)
				id_saveSession_Lcom_facebook_Session_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "saveSession", "(Lcom/facebook/Session;Landroid/os/Bundle;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_saveSession_Lcom_facebook_Session_Landroid_os_Bundle_, new JValue (p0), new JValue (p1));
		}

	}
}
