using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton']"
	[global::Android.Runtime.Register ("com/facebook/widget/LoginButton", DoNotGenerateAcw=true)]
	public partial class LoginButton : global::Android.Widget.Button {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton.LoginButtonCallback']"
		[global::Android.Runtime.Register ("com/facebook/widget/LoginButton$LoginButtonCallback", DoNotGenerateAcw=true)]
		public partial class LoginButtonCallback : global::Java.Lang.Object, global::Xamarin.FacebookBinding.Session.IStatusCallback {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/widget/LoginButton$LoginButtonCallback", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LoginButtonCallback); }
			}

			protected LoginButtonCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Xamarin.FacebookBinding.Widget.LoginButton.LoginButtonCallback __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.LoginButtonCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.Session p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.SessionState p1 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionState> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Exception p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.Call (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_call_Lcom_facebook_Session_Lcom_facebook_SessionState_Ljava_lang_Exception_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton.LoginButtonCallback']/method[@name='call' and count(parameter)=3 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='com.facebook.SessionState'] and parameter[3][@type='java.lang.Exception']]"
			[Register ("call", "(Lcom/facebook/Session;Lcom/facebook/SessionState;Ljava/lang/Exception;)V", "GetCall_Lcom_facebook_Session_Lcom_facebook_SessionState_Ljava_lang_Exception_Handler")]
			public virtual void Call (global::Xamarin.FacebookBinding.Session p0, global::Xamarin.FacebookBinding.SessionState p1, global::Java.Lang.Exception p2)
			{
				if (id_call_Lcom_facebook_Session_Lcom_facebook_SessionState_Ljava_lang_Exception_ == IntPtr.Zero)
					id_call_Lcom_facebook_Session_Lcom_facebook_SessionState_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "call", "(Lcom/facebook/Session;Lcom/facebook/SessionState;Ljava/lang/Exception;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_call_Lcom_facebook_Session_Lcom_facebook_SessionState_Ljava_lang_Exception_, new JValue (p0), new JValue (p1), new JValue (p2));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "call", "(Lcom/facebook/Session;Lcom/facebook/SessionState;Ljava/lang/Exception;)V"), new JValue (p0), new JValue (p1), new JValue (p2));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton.LoginButtonProperties']"
		[global::Android.Runtime.Register ("com/facebook/widget/LoginButton$LoginButtonProperties", DoNotGenerateAcw=true)]
		public partial class LoginButtonProperties : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/widget/LoginButton$LoginButtonProperties", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LoginButtonProperties); }
			}

			protected LoginButtonProperties (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getDefaultAudience;
#pragma warning disable 0169
			static Delegate GetGetDefaultAudienceHandler ()
			{
				if (cb_getDefaultAudience == null)
					cb_getDefaultAudience = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultAudience);
				return cb_getDefaultAudience;
			}

			static IntPtr n_GetDefaultAudience (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.Widget.LoginButton.LoginButtonProperties __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.LoginButtonProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.DefaultAudience);
			}
#pragma warning restore 0169

			static Delegate cb_setDefaultAudience_Lcom_facebook_SessionDefaultAudience_;
#pragma warning disable 0169
			static Delegate GetSetDefaultAudience_Lcom_facebook_SessionDefaultAudience_Handler ()
			{
				if (cb_setDefaultAudience_Lcom_facebook_SessionDefaultAudience_ == null)
					cb_setDefaultAudience_Lcom_facebook_SessionDefaultAudience_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDefaultAudience_Lcom_facebook_SessionDefaultAudience_);
				return cb_setDefaultAudience_Lcom_facebook_SessionDefaultAudience_;
			}

			static void n_SetDefaultAudience_Lcom_facebook_SessionDefaultAudience_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Widget.LoginButton.LoginButtonProperties __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.LoginButtonProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.SessionDefaultAudience p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionDefaultAudience> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.DefaultAudience = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getDefaultAudience;
			static IntPtr id_setDefaultAudience_Lcom_facebook_SessionDefaultAudience_;
			public virtual global::Xamarin.FacebookBinding.SessionDefaultAudience DefaultAudience {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton.LoginButtonProperties']/method[@name='getDefaultAudience' and count(parameter)=0]"
				[Register ("getDefaultAudience", "()Lcom/facebook/SessionDefaultAudience;", "GetGetDefaultAudienceHandler")]
				get {
					if (id_getDefaultAudience == IntPtr.Zero)
						id_getDefaultAudience = JNIEnv.GetMethodID (class_ref, "getDefaultAudience", "()Lcom/facebook/SessionDefaultAudience;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionDefaultAudience> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultAudience), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionDefaultAudience> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultAudience", "()Lcom/facebook/SessionDefaultAudience;")), JniHandleOwnership.TransferLocalRef);
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton.LoginButtonProperties']/method[@name='setDefaultAudience' and count(parameter)=1 and parameter[1][@type='com.facebook.SessionDefaultAudience']]"
				[Register ("setDefaultAudience", "(Lcom/facebook/SessionDefaultAudience;)V", "GetSetDefaultAudience_Lcom_facebook_SessionDefaultAudience_Handler")]
				set {
					if (id_setDefaultAudience_Lcom_facebook_SessionDefaultAudience_ == IntPtr.Zero)
						id_setDefaultAudience_Lcom_facebook_SessionDefaultAudience_ = JNIEnv.GetMethodID (class_ref, "setDefaultAudience", "(Lcom/facebook/SessionDefaultAudience;)V");

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDefaultAudience_Lcom_facebook_SessionDefaultAudience_, new JValue (value));
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultAudience", "(Lcom/facebook/SessionDefaultAudience;)V"), new JValue (value));
				}
			}

			static Delegate cb_getLoginBehavior;
#pragma warning disable 0169
			static Delegate GetGetLoginBehaviorHandler ()
			{
				if (cb_getLoginBehavior == null)
					cb_getLoginBehavior = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLoginBehavior);
				return cb_getLoginBehavior;
			}

			static IntPtr n_GetLoginBehavior (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.Widget.LoginButton.LoginButtonProperties __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.LoginButtonProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.LoginBehavior);
			}
#pragma warning restore 0169

			static Delegate cb_setLoginBehavior_Lcom_facebook_SessionLoginBehavior_;
#pragma warning disable 0169
			static Delegate GetSetLoginBehavior_Lcom_facebook_SessionLoginBehavior_Handler ()
			{
				if (cb_setLoginBehavior_Lcom_facebook_SessionLoginBehavior_ == null)
					cb_setLoginBehavior_Lcom_facebook_SessionLoginBehavior_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLoginBehavior_Lcom_facebook_SessionLoginBehavior_);
				return cb_setLoginBehavior_Lcom_facebook_SessionLoginBehavior_;
			}

			static void n_SetLoginBehavior_Lcom_facebook_SessionLoginBehavior_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Widget.LoginButton.LoginButtonProperties __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.LoginButtonProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.SessionLoginBehavior p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionLoginBehavior> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.LoginBehavior = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getLoginBehavior;
			static IntPtr id_setLoginBehavior_Lcom_facebook_SessionLoginBehavior_;
			public virtual global::Xamarin.FacebookBinding.SessionLoginBehavior LoginBehavior {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton.LoginButtonProperties']/method[@name='getLoginBehavior' and count(parameter)=0]"
				[Register ("getLoginBehavior", "()Lcom/facebook/SessionLoginBehavior;", "GetGetLoginBehaviorHandler")]
				get {
					if (id_getLoginBehavior == IntPtr.Zero)
						id_getLoginBehavior = JNIEnv.GetMethodID (class_ref, "getLoginBehavior", "()Lcom/facebook/SessionLoginBehavior;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionLoginBehavior> (JNIEnv.CallObjectMethod  (Handle, id_getLoginBehavior), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionLoginBehavior> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLoginBehavior", "()Lcom/facebook/SessionLoginBehavior;")), JniHandleOwnership.TransferLocalRef);
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton.LoginButtonProperties']/method[@name='setLoginBehavior' and count(parameter)=1 and parameter[1][@type='com.facebook.SessionLoginBehavior']]"
				[Register ("setLoginBehavior", "(Lcom/facebook/SessionLoginBehavior;)V", "GetSetLoginBehavior_Lcom_facebook_SessionLoginBehavior_Handler")]
				set {
					if (id_setLoginBehavior_Lcom_facebook_SessionLoginBehavior_ == IntPtr.Zero)
						id_setLoginBehavior_Lcom_facebook_SessionLoginBehavior_ = JNIEnv.GetMethodID (class_ref, "setLoginBehavior", "(Lcom/facebook/SessionLoginBehavior;)V");

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setLoginBehavior_Lcom_facebook_SessionLoginBehavior_, new JValue (value));
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLoginBehavior", "(Lcom/facebook/SessionLoginBehavior;)V"), new JValue (value));
				}
			}

			static Delegate cb_getOnErrorListener;
#pragma warning disable 0169
			static Delegate GetGetOnErrorListenerHandler ()
			{
				if (cb_getOnErrorListener == null)
					cb_getOnErrorListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnErrorListener);
				return cb_getOnErrorListener;
			}

			static IntPtr n_GetOnErrorListener (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.Widget.LoginButton.LoginButtonProperties __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.LoginButtonProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.OnErrorListener);
			}
#pragma warning restore 0169

			static Delegate cb_setOnErrorListener_Lcom_facebook_widget_LoginButton_OnErrorListener_;
#pragma warning disable 0169
			static Delegate GetSetOnErrorListener_Lcom_facebook_widget_LoginButton_OnErrorListener_Handler ()
			{
				if (cb_setOnErrorListener_Lcom_facebook_widget_LoginButton_OnErrorListener_ == null)
					cb_setOnErrorListener_Lcom_facebook_widget_LoginButton_OnErrorListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnErrorListener_Lcom_facebook_widget_LoginButton_OnErrorListener_);
				return cb_setOnErrorListener_Lcom_facebook_widget_LoginButton_OnErrorListener_;
			}

			static void n_SetOnErrorListener_Lcom_facebook_widget_LoginButton_OnErrorListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Widget.LoginButton.LoginButtonProperties __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.LoginButtonProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListener p0 = (global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListener)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnErrorListener = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getOnErrorListener;
			static IntPtr id_setOnErrorListener_Lcom_facebook_widget_LoginButton_OnErrorListener_;
			public virtual global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListener OnErrorListener {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton.LoginButtonProperties']/method[@name='getOnErrorListener' and count(parameter)=0]"
				[Register ("getOnErrorListener", "()Lcom/facebook/widget/LoginButton$OnErrorListener;", "GetGetOnErrorListenerHandler")]
				get {
					if (id_getOnErrorListener == IntPtr.Zero)
						id_getOnErrorListener = JNIEnv.GetMethodID (class_ref, "getOnErrorListener", "()Lcom/facebook/widget/LoginButton$OnErrorListener;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListener> (JNIEnv.CallObjectMethod  (Handle, id_getOnErrorListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnErrorListener", "()Lcom/facebook/widget/LoginButton$OnErrorListener;")), JniHandleOwnership.TransferLocalRef);
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton.LoginButtonProperties']/method[@name='setOnErrorListener' and count(parameter)=1 and parameter[1][@type='com.facebook.widget.LoginButton.OnErrorListener']]"
				[Register ("setOnErrorListener", "(Lcom/facebook/widget/LoginButton$OnErrorListener;)V", "GetSetOnErrorListener_Lcom_facebook_widget_LoginButton_OnErrorListener_Handler")]
				set {
					if (id_setOnErrorListener_Lcom_facebook_widget_LoginButton_OnErrorListener_ == IntPtr.Zero)
						id_setOnErrorListener_Lcom_facebook_widget_LoginButton_OnErrorListener_ = JNIEnv.GetMethodID (class_ref, "setOnErrorListener", "(Lcom/facebook/widget/LoginButton$OnErrorListener;)V");

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setOnErrorListener_Lcom_facebook_widget_LoginButton_OnErrorListener_, new JValue (value));
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnErrorListener", "(Lcom/facebook/widget/LoginButton$OnErrorListener;)V"), new JValue (value));
				}
			}

			static Delegate cb_getSessionStatusCallback;
#pragma warning disable 0169
			static Delegate GetGetSessionStatusCallbackHandler ()
			{
				if (cb_getSessionStatusCallback == null)
					cb_getSessionStatusCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSessionStatusCallback);
				return cb_getSessionStatusCallback;
			}

			static IntPtr n_GetSessionStatusCallback (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.Widget.LoginButton.LoginButtonProperties __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.LoginButtonProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SessionStatusCallback);
			}
#pragma warning restore 0169

			static Delegate cb_setSessionStatusCallback_Lcom_facebook_Session_StatusCallback_;
#pragma warning disable 0169
			static Delegate GetSetSessionStatusCallback_Lcom_facebook_Session_StatusCallback_Handler ()
			{
				if (cb_setSessionStatusCallback_Lcom_facebook_Session_StatusCallback_ == null)
					cb_setSessionStatusCallback_Lcom_facebook_Session_StatusCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSessionStatusCallback_Lcom_facebook_Session_StatusCallback_);
				return cb_setSessionStatusCallback_Lcom_facebook_Session_StatusCallback_;
			}

			static void n_SetSessionStatusCallback_Lcom_facebook_Session_StatusCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Widget.LoginButton.LoginButtonProperties __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.LoginButtonProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.Session.IStatusCallback p0 = (global::Xamarin.FacebookBinding.Session.IStatusCallback)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.IStatusCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SessionStatusCallback = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getSessionStatusCallback;
			static IntPtr id_setSessionStatusCallback_Lcom_facebook_Session_StatusCallback_;
			public virtual global::Xamarin.FacebookBinding.Session.IStatusCallback SessionStatusCallback {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton.LoginButtonProperties']/method[@name='getSessionStatusCallback' and count(parameter)=0]"
				[Register ("getSessionStatusCallback", "()Lcom/facebook/Session$StatusCallback;", "GetGetSessionStatusCallbackHandler")]
				get {
					if (id_getSessionStatusCallback == IntPtr.Zero)
						id_getSessionStatusCallback = JNIEnv.GetMethodID (class_ref, "getSessionStatusCallback", "()Lcom/facebook/Session$StatusCallback;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.IStatusCallback> (JNIEnv.CallObjectMethod  (Handle, id_getSessionStatusCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.IStatusCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSessionStatusCallback", "()Lcom/facebook/Session$StatusCallback;")), JniHandleOwnership.TransferLocalRef);
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton.LoginButtonProperties']/method[@name='setSessionStatusCallback' and count(parameter)=1 and parameter[1][@type='com.facebook.Session.StatusCallback']]"
				[Register ("setSessionStatusCallback", "(Lcom/facebook/Session$StatusCallback;)V", "GetSetSessionStatusCallback_Lcom_facebook_Session_StatusCallback_Handler")]
				set {
					if (id_setSessionStatusCallback_Lcom_facebook_Session_StatusCallback_ == IntPtr.Zero)
						id_setSessionStatusCallback_Lcom_facebook_Session_StatusCallback_ = JNIEnv.GetMethodID (class_ref, "setSessionStatusCallback", "(Lcom/facebook/Session$StatusCallback;)V");

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSessionStatusCallback_Lcom_facebook_Session_StatusCallback_, new JValue (value));
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSessionStatusCallback", "(Lcom/facebook/Session$StatusCallback;)V"), new JValue (value));
				}
			}

			static Delegate cb_clearPermissions;
#pragma warning disable 0169
			static Delegate GetClearPermissionsHandler ()
			{
				if (cb_clearPermissions == null)
					cb_clearPermissions = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearPermissions);
				return cb_clearPermissions;
			}

			static void n_ClearPermissions (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.Widget.LoginButton.LoginButtonProperties __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.LoginButtonProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ClearPermissions ();
			}
#pragma warning restore 0169

			static IntPtr id_clearPermissions;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton.LoginButtonProperties']/method[@name='clearPermissions' and count(parameter)=0]"
			[Register ("clearPermissions", "()V", "GetClearPermissionsHandler")]
			public virtual void ClearPermissions ()
			{
				if (id_clearPermissions == IntPtr.Zero)
					id_clearPermissions = JNIEnv.GetMethodID (class_ref, "clearPermissions", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearPermissions);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearPermissions", "()V"));
			}

			static Delegate cb_setPublishPermissions_Ljava_util_List_Lcom_facebook_Session_;
#pragma warning disable 0169
			static Delegate GetSetPublishPermissions_Ljava_util_List_Lcom_facebook_Session_Handler ()
			{
				if (cb_setPublishPermissions_Ljava_util_List_Lcom_facebook_Session_ == null)
					cb_setPublishPermissions_Ljava_util_List_Lcom_facebook_Session_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPublishPermissions_Ljava_util_List_Lcom_facebook_Session_);
				return cb_setPublishPermissions_Ljava_util_List_Lcom_facebook_Session_;
			}

			static void n_SetPublishPermissions_Ljava_util_List_Lcom_facebook_Session_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Xamarin.FacebookBinding.Widget.LoginButton.LoginButtonProperties __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.LoginButtonProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.Collections.Generic.IList<string> p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.Session p1 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.SetPublishPermissions (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_setPublishPermissions_Ljava_util_List_Lcom_facebook_Session_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton.LoginButtonProperties']/method[@name='setPublishPermissions' and count(parameter)=2 and parameter[1][@type='java.util.List'] and parameter[2][@type='com.facebook.Session']]"
			[Register ("setPublishPermissions", "(Ljava/util/List;Lcom/facebook/Session;)V", "GetSetPublishPermissions_Ljava_util_List_Lcom_facebook_Session_Handler")]
			public virtual void SetPublishPermissions (global::System.Collections.Generic.IList<string> p0, global::Xamarin.FacebookBinding.Session p1)
			{
				if (id_setPublishPermissions_Ljava_util_List_Lcom_facebook_Session_ == IntPtr.Zero)
					id_setPublishPermissions_Ljava_util_List_Lcom_facebook_Session_ = JNIEnv.GetMethodID (class_ref, "setPublishPermissions", "(Ljava/util/List;Lcom/facebook/Session;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPublishPermissions_Ljava_util_List_Lcom_facebook_Session_, new JValue (native_p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPublishPermissions", "(Ljava/util/List;Lcom/facebook/Session;)V"), new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_setReadPermissions_Ljava_util_List_Lcom_facebook_Session_;
#pragma warning disable 0169
			static Delegate GetSetReadPermissions_Ljava_util_List_Lcom_facebook_Session_Handler ()
			{
				if (cb_setReadPermissions_Ljava_util_List_Lcom_facebook_Session_ == null)
					cb_setReadPermissions_Ljava_util_List_Lcom_facebook_Session_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetReadPermissions_Ljava_util_List_Lcom_facebook_Session_);
				return cb_setReadPermissions_Ljava_util_List_Lcom_facebook_Session_;
			}

			static void n_SetReadPermissions_Ljava_util_List_Lcom_facebook_Session_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Xamarin.FacebookBinding.Widget.LoginButton.LoginButtonProperties __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.LoginButtonProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.Collections.Generic.IList<string> p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.Session p1 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.SetReadPermissions (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_setReadPermissions_Ljava_util_List_Lcom_facebook_Session_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton.LoginButtonProperties']/method[@name='setReadPermissions' and count(parameter)=2 and parameter[1][@type='java.util.List'] and parameter[2][@type='com.facebook.Session']]"
			[Register ("setReadPermissions", "(Ljava/util/List;Lcom/facebook/Session;)V", "GetSetReadPermissions_Ljava_util_List_Lcom_facebook_Session_Handler")]
			public virtual void SetReadPermissions (global::System.Collections.Generic.IList<string> p0, global::Xamarin.FacebookBinding.Session p1)
			{
				if (id_setReadPermissions_Ljava_util_List_Lcom_facebook_Session_ == IntPtr.Zero)
					id_setReadPermissions_Ljava_util_List_Lcom_facebook_Session_ = JNIEnv.GetMethodID (class_ref, "setReadPermissions", "(Ljava/util/List;Lcom/facebook/Session;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setReadPermissions_Ljava_util_List_Lcom_facebook_Session_, new JValue (native_p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReadPermissions", "(Ljava/util/List;Lcom/facebook/Session;)V"), new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
			}

#region "Event implementation for Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListener"
			public event EventHandler<global::Xamarin.FacebookBinding.Widget.LoginButton.ErrorEventArgs> Error {
				add {
					global::Java.Interop.EventHelper.AddEventHandler<global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListener, global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListenerImplementor>(
							ref weak_implementor___SetOnErrorListener,
							__CreateIOnErrorListenerImplementor,
							__v => OnErrorListener = __v,
							__h => __h.Handler += value);
				}
				remove {
					global::Java.Interop.EventHelper.RemoveEventHandler<global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListener, global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListenerImplementor>(
							ref weak_implementor___SetOnErrorListener,
							global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListenerImplementor.__IsEmpty,
							__v => OnErrorListener = null,
							__h => __h.Handler -= value);
				}
			}

			WeakReference weak_implementor___SetOnErrorListener;

			global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListenerImplementor __CreateIOnErrorListenerImplementor ()
			{
				return new global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListenerImplementor (this);
			}
#endregion
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton.LoginClickListener']"
		[global::Android.Runtime.Register ("com/facebook/widget/LoginButton$LoginClickListener", DoNotGenerateAcw=true)]
		public partial class LoginClickListener : global::Java.Lang.Object, global::Android.Views.View.IOnClickListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/widget/LoginButton$LoginClickListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LoginClickListener); }
			}

			protected LoginClickListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onClick_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetOnClick_Landroid_view_View_Handler ()
			{
				if (cb_onClick_Landroid_view_View_ == null)
					cb_onClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnClick_Landroid_view_View_);
				return cb_onClick_Landroid_view_View_;
			}

			static void n_OnClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Widget.LoginButton.LoginClickListener __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.LoginClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnClick (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onClick_Landroid_view_View_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton.LoginClickListener']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("onClick", "(Landroid/view/View;)V", "GetOnClick_Landroid_view_View_Handler")]
			public virtual void OnClick (global::Android.Views.View p0)
			{
				if (id_onClick_Landroid_view_View_ == IntPtr.Zero)
					id_onClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onClick", "(Landroid/view/View;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onClick_Landroid_view_View_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onClick", "(Landroid/view/View;)V"), new JValue (p0));
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.widget']/interface[@name='LoginButton.OnErrorListener']"
		[Register ("com/facebook/widget/LoginButton$OnErrorListener", "", "Xamarin.FacebookBinding.Widget.LoginButton/IOnErrorListenerInvoker")]
		public partial interface IOnErrorListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/interface[@name='LoginButton.OnErrorListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.facebook.FacebookException']]"
			[Register ("onError", "(Lcom/facebook/FacebookException;)V", "GetOnError_Lcom_facebook_FacebookException_Handler:Xamarin.FacebookBinding.Widget.LoginButton/IOnErrorListenerInvoker, Xamarin.Facebook")]
			void OnError (global::Xamarin.FacebookBinding.FacebookException p0);

		}

		[global::Android.Runtime.Register ("com/facebook/widget/LoginButton$OnErrorListener", DoNotGenerateAcw=true)]
		internal class IOnErrorListenerInvoker : global::Java.Lang.Object, IOnErrorListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/widget/LoginButton$OnErrorListener");
			IntPtr class_ref;

			public static IOnErrorListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnErrorListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.widget.LoginButton.OnErrorListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnErrorListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnErrorListenerInvoker); }
			}

			static Delegate cb_onError_Lcom_facebook_FacebookException_;
#pragma warning disable 0169
			static Delegate GetOnError_Lcom_facebook_FacebookException_Handler ()
			{
				if (cb_onError_Lcom_facebook_FacebookException_ == null)
					cb_onError_Lcom_facebook_FacebookException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Lcom_facebook_FacebookException_);
				return cb_onError_Lcom_facebook_FacebookException_;
			}

			static void n_OnError_Lcom_facebook_FacebookException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListener __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.FacebookException p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.FacebookException> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onError_Lcom_facebook_FacebookException_;
			public void OnError (global::Xamarin.FacebookBinding.FacebookException p0)
			{
				if (id_onError_Lcom_facebook_FacebookException_ == IntPtr.Zero)
					id_onError_Lcom_facebook_FacebookException_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/facebook/FacebookException;)V");
				JNIEnv.CallVoidMethod (Handle, id_onError_Lcom_facebook_FacebookException_, new JValue (p0));
			}

		}

		public partial class ErrorEventArgs : global::System.EventArgs {

			public ErrorEventArgs (global::Xamarin.FacebookBinding.FacebookException p0)
			{
				this.p0 = p0;
			}

			global::Xamarin.FacebookBinding.FacebookException p0;
			public global::Xamarin.FacebookBinding.FacebookException P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/facebook/widget/LoginButton_OnErrorListenerImplementor")]
		internal sealed class IOnErrorListenerImplementor : global::Java.Lang.Object, IOnErrorListener {

			object sender;

			public IOnErrorListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/facebook/widget/LoginButton_OnErrorListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ErrorEventArgs> Handler;
#pragma warning restore 0649

			public void OnError (global::Xamarin.FacebookBinding.FacebookException p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ErrorEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnErrorListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.widget']/interface[@name='LoginButton.UserInfoChangedCallback']"
		[Register ("com/facebook/widget/LoginButton$UserInfoChangedCallback", "", "Xamarin.FacebookBinding.Widget.LoginButton/IUserInfoChangedCallbackInvoker")]
		public partial interface IUserInfoChangedCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/interface[@name='LoginButton.UserInfoChangedCallback']/method[@name='onUserInfoFetched' and count(parameter)=1 and parameter[1][@type='com.facebook.model.GraphUser']]"
			[Register ("onUserInfoFetched", "(Lcom/facebook/model/GraphUser;)V", "GetOnUserInfoFetched_Lcom_facebook_model_GraphUser_Handler:Xamarin.FacebookBinding.Widget.LoginButton/IUserInfoChangedCallbackInvoker, Xamarin.Facebook")]
			void OnUserInfoFetched (global::Xamarin.FacebookBinding.Model.IGraphUser p0);

		}

		[global::Android.Runtime.Register ("com/facebook/widget/LoginButton$UserInfoChangedCallback", DoNotGenerateAcw=true)]
		internal class IUserInfoChangedCallbackInvoker : global::Java.Lang.Object, IUserInfoChangedCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/widget/LoginButton$UserInfoChangedCallback");
			IntPtr class_ref;

			public static IUserInfoChangedCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IUserInfoChangedCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.widget.LoginButton.UserInfoChangedCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IUserInfoChangedCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IUserInfoChangedCallbackInvoker); }
			}

			static Delegate cb_onUserInfoFetched_Lcom_facebook_model_GraphUser_;
#pragma warning disable 0169
			static Delegate GetOnUserInfoFetched_Lcom_facebook_model_GraphUser_Handler ()
			{
				if (cb_onUserInfoFetched_Lcom_facebook_model_GraphUser_ == null)
					cb_onUserInfoFetched_Lcom_facebook_model_GraphUser_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUserInfoFetched_Lcom_facebook_model_GraphUser_);
				return cb_onUserInfoFetched_Lcom_facebook_model_GraphUser_;
			}

			static void n_OnUserInfoFetched_Lcom_facebook_model_GraphUser_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Widget.LoginButton.IUserInfoChangedCallback __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.IUserInfoChangedCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.Model.IGraphUser p0 = (global::Xamarin.FacebookBinding.Model.IGraphUser)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnUserInfoFetched (p0);
			}
#pragma warning restore 0169

			IntPtr id_onUserInfoFetched_Lcom_facebook_model_GraphUser_;
			public void OnUserInfoFetched (global::Xamarin.FacebookBinding.Model.IGraphUser p0)
			{
				if (id_onUserInfoFetched_Lcom_facebook_model_GraphUser_ == IntPtr.Zero)
					id_onUserInfoFetched_Lcom_facebook_model_GraphUser_ = JNIEnv.GetMethodID (class_ref, "onUserInfoFetched", "(Lcom/facebook/model/GraphUser;)V");
				JNIEnv.CallVoidMethod (Handle, id_onUserInfoFetched_Lcom_facebook_model_GraphUser_, new JValue (p0));
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/widget/LoginButton", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LoginButton); }
		}

		protected LoginButton (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton']/constructor[@name='LoginButton' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public LoginButton (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LoginButton)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton']/constructor[@name='LoginButton' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public LoginButton (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LoginButton)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton']/constructor[@name='LoginButton' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public LoginButton (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LoginButton)) {
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

		static Delegate cb_getDefaultAudience;
#pragma warning disable 0169
		static Delegate GetGetDefaultAudienceHandler ()
		{
			if (cb_getDefaultAudience == null)
				cb_getDefaultAudience = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultAudience);
			return cb_getDefaultAudience;
		}

		static IntPtr n_GetDefaultAudience (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Widget.LoginButton __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultAudience);
		}
#pragma warning restore 0169

		static Delegate cb_setDefaultAudience_Lcom_facebook_SessionDefaultAudience_;
#pragma warning disable 0169
		static Delegate GetSetDefaultAudience_Lcom_facebook_SessionDefaultAudience_Handler ()
		{
			if (cb_setDefaultAudience_Lcom_facebook_SessionDefaultAudience_ == null)
				cb_setDefaultAudience_Lcom_facebook_SessionDefaultAudience_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDefaultAudience_Lcom_facebook_SessionDefaultAudience_);
			return cb_setDefaultAudience_Lcom_facebook_SessionDefaultAudience_;
		}

		static void n_SetDefaultAudience_Lcom_facebook_SessionDefaultAudience_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Widget.LoginButton __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.SessionDefaultAudience p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionDefaultAudience> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DefaultAudience = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultAudience;
		static IntPtr id_setDefaultAudience_Lcom_facebook_SessionDefaultAudience_;
		public virtual global::Xamarin.FacebookBinding.SessionDefaultAudience DefaultAudience {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton']/method[@name='getDefaultAudience' and count(parameter)=0]"
			[Register ("getDefaultAudience", "()Lcom/facebook/SessionDefaultAudience;", "GetGetDefaultAudienceHandler")]
			get {
				if (id_getDefaultAudience == IntPtr.Zero)
					id_getDefaultAudience = JNIEnv.GetMethodID (class_ref, "getDefaultAudience", "()Lcom/facebook/SessionDefaultAudience;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionDefaultAudience> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultAudience), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionDefaultAudience> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultAudience", "()Lcom/facebook/SessionDefaultAudience;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton']/method[@name='setDefaultAudience' and count(parameter)=1 and parameter[1][@type='com.facebook.SessionDefaultAudience']]"
			[Register ("setDefaultAudience", "(Lcom/facebook/SessionDefaultAudience;)V", "GetSetDefaultAudience_Lcom_facebook_SessionDefaultAudience_Handler")]
			set {
				if (id_setDefaultAudience_Lcom_facebook_SessionDefaultAudience_ == IntPtr.Zero)
					id_setDefaultAudience_Lcom_facebook_SessionDefaultAudience_ = JNIEnv.GetMethodID (class_ref, "setDefaultAudience", "(Lcom/facebook/SessionDefaultAudience;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDefaultAudience_Lcom_facebook_SessionDefaultAudience_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultAudience", "(Lcom/facebook/SessionDefaultAudience;)V"), new JValue (value));
			}
		}

		static Delegate cb_getLoginBehavior;
#pragma warning disable 0169
		static Delegate GetGetLoginBehaviorHandler ()
		{
			if (cb_getLoginBehavior == null)
				cb_getLoginBehavior = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLoginBehavior);
			return cb_getLoginBehavior;
		}

		static IntPtr n_GetLoginBehavior (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Widget.LoginButton __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LoginBehavior);
		}
#pragma warning restore 0169

		static Delegate cb_setLoginBehavior_Lcom_facebook_SessionLoginBehavior_;
#pragma warning disable 0169
		static Delegate GetSetLoginBehavior_Lcom_facebook_SessionLoginBehavior_Handler ()
		{
			if (cb_setLoginBehavior_Lcom_facebook_SessionLoginBehavior_ == null)
				cb_setLoginBehavior_Lcom_facebook_SessionLoginBehavior_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLoginBehavior_Lcom_facebook_SessionLoginBehavior_);
			return cb_setLoginBehavior_Lcom_facebook_SessionLoginBehavior_;
		}

		static void n_SetLoginBehavior_Lcom_facebook_SessionLoginBehavior_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Widget.LoginButton __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.SessionLoginBehavior p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionLoginBehavior> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoginBehavior = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLoginBehavior;
		static IntPtr id_setLoginBehavior_Lcom_facebook_SessionLoginBehavior_;
		public virtual global::Xamarin.FacebookBinding.SessionLoginBehavior LoginBehavior {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton']/method[@name='getLoginBehavior' and count(parameter)=0]"
			[Register ("getLoginBehavior", "()Lcom/facebook/SessionLoginBehavior;", "GetGetLoginBehaviorHandler")]
			get {
				if (id_getLoginBehavior == IntPtr.Zero)
					id_getLoginBehavior = JNIEnv.GetMethodID (class_ref, "getLoginBehavior", "()Lcom/facebook/SessionLoginBehavior;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionLoginBehavior> (JNIEnv.CallObjectMethod  (Handle, id_getLoginBehavior), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionLoginBehavior> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLoginBehavior", "()Lcom/facebook/SessionLoginBehavior;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton']/method[@name='setLoginBehavior' and count(parameter)=1 and parameter[1][@type='com.facebook.SessionLoginBehavior']]"
			[Register ("setLoginBehavior", "(Lcom/facebook/SessionLoginBehavior;)V", "GetSetLoginBehavior_Lcom_facebook_SessionLoginBehavior_Handler")]
			set {
				if (id_setLoginBehavior_Lcom_facebook_SessionLoginBehavior_ == IntPtr.Zero)
					id_setLoginBehavior_Lcom_facebook_SessionLoginBehavior_ = JNIEnv.GetMethodID (class_ref, "setLoginBehavior", "(Lcom/facebook/SessionLoginBehavior;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLoginBehavior_Lcom_facebook_SessionLoginBehavior_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLoginBehavior", "(Lcom/facebook/SessionLoginBehavior;)V"), new JValue (value));
			}
		}

		static Delegate cb_getOnErrorListener;
#pragma warning disable 0169
		static Delegate GetGetOnErrorListenerHandler ()
		{
			if (cb_getOnErrorListener == null)
				cb_getOnErrorListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnErrorListener);
			return cb_getOnErrorListener;
		}

		static IntPtr n_GetOnErrorListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Widget.LoginButton __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnErrorListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnErrorListener_Lcom_facebook_widget_LoginButton_OnErrorListener_;
#pragma warning disable 0169
		static Delegate GetSetOnErrorListener_Lcom_facebook_widget_LoginButton_OnErrorListener_Handler ()
		{
			if (cb_setOnErrorListener_Lcom_facebook_widget_LoginButton_OnErrorListener_ == null)
				cb_setOnErrorListener_Lcom_facebook_widget_LoginButton_OnErrorListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnErrorListener_Lcom_facebook_widget_LoginButton_OnErrorListener_);
			return cb_setOnErrorListener_Lcom_facebook_widget_LoginButton_OnErrorListener_;
		}

		static void n_SetOnErrorListener_Lcom_facebook_widget_LoginButton_OnErrorListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Widget.LoginButton __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListener p0 = (global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListener)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnErrorListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOnErrorListener;
		static IntPtr id_setOnErrorListener_Lcom_facebook_widget_LoginButton_OnErrorListener_;
		public virtual global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListener OnErrorListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton']/method[@name='getOnErrorListener' and count(parameter)=0]"
			[Register ("getOnErrorListener", "()Lcom/facebook/widget/LoginButton$OnErrorListener;", "GetGetOnErrorListenerHandler")]
			get {
				if (id_getOnErrorListener == IntPtr.Zero)
					id_getOnErrorListener = JNIEnv.GetMethodID (class_ref, "getOnErrorListener", "()Lcom/facebook/widget/LoginButton$OnErrorListener;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListener> (JNIEnv.CallObjectMethod  (Handle, id_getOnErrorListener), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnErrorListener", "()Lcom/facebook/widget/LoginButton$OnErrorListener;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton']/method[@name='setOnErrorListener' and count(parameter)=1 and parameter[1][@type='com.facebook.widget.LoginButton.OnErrorListener']]"
			[Register ("setOnErrorListener", "(Lcom/facebook/widget/LoginButton$OnErrorListener;)V", "GetSetOnErrorListener_Lcom_facebook_widget_LoginButton_OnErrorListener_Handler")]
			set {
				if (id_setOnErrorListener_Lcom_facebook_widget_LoginButton_OnErrorListener_ == IntPtr.Zero)
					id_setOnErrorListener_Lcom_facebook_widget_LoginButton_OnErrorListener_ = JNIEnv.GetMethodID (class_ref, "setOnErrorListener", "(Lcom/facebook/widget/LoginButton$OnErrorListener;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnErrorListener_Lcom_facebook_widget_LoginButton_OnErrorListener_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnErrorListener", "(Lcom/facebook/widget/LoginButton$OnErrorListener;)V"), new JValue (value));
			}
		}

		static Delegate cb_getSessionStatusCallback;
#pragma warning disable 0169
		static Delegate GetGetSessionStatusCallbackHandler ()
		{
			if (cb_getSessionStatusCallback == null)
				cb_getSessionStatusCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSessionStatusCallback);
			return cb_getSessionStatusCallback;
		}

		static IntPtr n_GetSessionStatusCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Widget.LoginButton __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SessionStatusCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setSessionStatusCallback_Lcom_facebook_Session_StatusCallback_;
#pragma warning disable 0169
		static Delegate GetSetSessionStatusCallback_Lcom_facebook_Session_StatusCallback_Handler ()
		{
			if (cb_setSessionStatusCallback_Lcom_facebook_Session_StatusCallback_ == null)
				cb_setSessionStatusCallback_Lcom_facebook_Session_StatusCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSessionStatusCallback_Lcom_facebook_Session_StatusCallback_);
			return cb_setSessionStatusCallback_Lcom_facebook_Session_StatusCallback_;
		}

		static void n_SetSessionStatusCallback_Lcom_facebook_Session_StatusCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Widget.LoginButton __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.Session.IStatusCallback p0 = (global::Xamarin.FacebookBinding.Session.IStatusCallback)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.IStatusCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SessionStatusCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSessionStatusCallback;
		static IntPtr id_setSessionStatusCallback_Lcom_facebook_Session_StatusCallback_;
		public virtual global::Xamarin.FacebookBinding.Session.IStatusCallback SessionStatusCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton']/method[@name='getSessionStatusCallback' and count(parameter)=0]"
			[Register ("getSessionStatusCallback", "()Lcom/facebook/Session$StatusCallback;", "GetGetSessionStatusCallbackHandler")]
			get {
				if (id_getSessionStatusCallback == IntPtr.Zero)
					id_getSessionStatusCallback = JNIEnv.GetMethodID (class_ref, "getSessionStatusCallback", "()Lcom/facebook/Session$StatusCallback;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.IStatusCallback> (JNIEnv.CallObjectMethod  (Handle, id_getSessionStatusCallback), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.IStatusCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSessionStatusCallback", "()Lcom/facebook/Session$StatusCallback;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton']/method[@name='setSessionStatusCallback' and count(parameter)=1 and parameter[1][@type='com.facebook.Session.StatusCallback']]"
			[Register ("setSessionStatusCallback", "(Lcom/facebook/Session$StatusCallback;)V", "GetSetSessionStatusCallback_Lcom_facebook_Session_StatusCallback_Handler")]
			set {
				if (id_setSessionStatusCallback_Lcom_facebook_Session_StatusCallback_ == IntPtr.Zero)
					id_setSessionStatusCallback_Lcom_facebook_Session_StatusCallback_ = JNIEnv.GetMethodID (class_ref, "setSessionStatusCallback", "(Lcom/facebook/Session$StatusCallback;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSessionStatusCallback_Lcom_facebook_Session_StatusCallback_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSessionStatusCallback", "(Lcom/facebook/Session$StatusCallback;)V"), new JValue (value));
			}
		}

		static Delegate cb_getUserInfoChangedCallback;
#pragma warning disable 0169
		static Delegate GetGetUserInfoChangedCallbackHandler ()
		{
			if (cb_getUserInfoChangedCallback == null)
				cb_getUserInfoChangedCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserInfoChangedCallback);
			return cb_getUserInfoChangedCallback;
		}

		static IntPtr n_GetUserInfoChangedCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Widget.LoginButton __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UserInfoChangedCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setUserInfoChangedCallback_Lcom_facebook_widget_LoginButton_UserInfoChangedCallback_;
#pragma warning disable 0169
		static Delegate GetSetUserInfoChangedCallback_Lcom_facebook_widget_LoginButton_UserInfoChangedCallback_Handler ()
		{
			if (cb_setUserInfoChangedCallback_Lcom_facebook_widget_LoginButton_UserInfoChangedCallback_ == null)
				cb_setUserInfoChangedCallback_Lcom_facebook_widget_LoginButton_UserInfoChangedCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserInfoChangedCallback_Lcom_facebook_widget_LoginButton_UserInfoChangedCallback_);
			return cb_setUserInfoChangedCallback_Lcom_facebook_widget_LoginButton_UserInfoChangedCallback_;
		}

		static void n_SetUserInfoChangedCallback_Lcom_facebook_widget_LoginButton_UserInfoChangedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Widget.LoginButton __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.Widget.LoginButton.IUserInfoChangedCallback p0 = (global::Xamarin.FacebookBinding.Widget.LoginButton.IUserInfoChangedCallback)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.IUserInfoChangedCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserInfoChangedCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserInfoChangedCallback;
		static IntPtr id_setUserInfoChangedCallback_Lcom_facebook_widget_LoginButton_UserInfoChangedCallback_;
		public virtual global::Xamarin.FacebookBinding.Widget.LoginButton.IUserInfoChangedCallback UserInfoChangedCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton']/method[@name='getUserInfoChangedCallback' and count(parameter)=0]"
			[Register ("getUserInfoChangedCallback", "()Lcom/facebook/widget/LoginButton$UserInfoChangedCallback;", "GetGetUserInfoChangedCallbackHandler")]
			get {
				if (id_getUserInfoChangedCallback == IntPtr.Zero)
					id_getUserInfoChangedCallback = JNIEnv.GetMethodID (class_ref, "getUserInfoChangedCallback", "()Lcom/facebook/widget/LoginButton$UserInfoChangedCallback;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.IUserInfoChangedCallback> (JNIEnv.CallObjectMethod  (Handle, id_getUserInfoChangedCallback), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.IUserInfoChangedCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserInfoChangedCallback", "()Lcom/facebook/widget/LoginButton$UserInfoChangedCallback;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton']/method[@name='setUserInfoChangedCallback' and count(parameter)=1 and parameter[1][@type='com.facebook.widget.LoginButton.UserInfoChangedCallback']]"
			[Register ("setUserInfoChangedCallback", "(Lcom/facebook/widget/LoginButton$UserInfoChangedCallback;)V", "GetSetUserInfoChangedCallback_Lcom_facebook_widget_LoginButton_UserInfoChangedCallback_Handler")]
			set {
				if (id_setUserInfoChangedCallback_Lcom_facebook_widget_LoginButton_UserInfoChangedCallback_ == IntPtr.Zero)
					id_setUserInfoChangedCallback_Lcom_facebook_widget_LoginButton_UserInfoChangedCallback_ = JNIEnv.GetMethodID (class_ref, "setUserInfoChangedCallback", "(Lcom/facebook/widget/LoginButton$UserInfoChangedCallback;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setUserInfoChangedCallback_Lcom_facebook_widget_LoginButton_UserInfoChangedCallback_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserInfoChangedCallback", "(Lcom/facebook/widget/LoginButton$UserInfoChangedCallback;)V"), new JValue (value));
			}
		}

		static Delegate cb_clearPermissions;
#pragma warning disable 0169
		static Delegate GetClearPermissionsHandler ()
		{
			if (cb_clearPermissions == null)
				cb_clearPermissions = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearPermissions);
			return cb_clearPermissions;
		}

		static void n_ClearPermissions (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Widget.LoginButton __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearPermissions ();
		}
#pragma warning restore 0169

		static IntPtr id_clearPermissions;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton']/method[@name='clearPermissions' and count(parameter)=0]"
		[Register ("clearPermissions", "()V", "GetClearPermissionsHandler")]
		public virtual void ClearPermissions ()
		{
			if (id_clearPermissions == IntPtr.Zero)
				id_clearPermissions = JNIEnv.GetMethodID (class_ref, "clearPermissions", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clearPermissions);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearPermissions", "()V"));
		}

		static Delegate cb_onActivityResult_IILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnActivityResult_IILandroid_content_Intent_Handler ()
		{
			if (cb_onActivityResult_IILandroid_content_Intent_ == null)
				cb_onActivityResult_IILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, bool>) n_OnActivityResult_IILandroid_content_Intent_);
			return cb_onActivityResult_IILandroid_content_Intent_;
		}

		static bool n_OnActivityResult_IILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Xamarin.FacebookBinding.Widget.LoginButton __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnActivityResult (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onActivityResult_IILandroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton']/method[@name='onActivityResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("onActivityResult", "(IILandroid/content/Intent;)Z", "GetOnActivityResult_IILandroid_content_Intent_Handler")]
		public virtual bool OnActivityResult (int p0, int p1, global::Android.Content.Intent p2)
		{
			if (id_onActivityResult_IILandroid_content_Intent_ == IntPtr.Zero)
				id_onActivityResult_IILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onActivityResult", "(IILandroid/content/Intent;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onActivityResult_IILandroid_content_Intent_, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityResult", "(IILandroid/content/Intent;)Z"), new JValue (p0), new JValue (p1), new JValue (p2));
			return __ret;
		}

		static Delegate cb_onFinishInflate;
#pragma warning disable 0169
		static Delegate GetOnFinishInflateHandler ()
		{
			if (cb_onFinishInflate == null)
				cb_onFinishInflate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFinishInflate);
			return cb_onFinishInflate;
		}

		static void n_OnFinishInflate (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Widget.LoginButton __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFinishInflate ();
		}
#pragma warning restore 0169

		static IntPtr id_onFinishInflate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton']/method[@name='onFinishInflate' and count(parameter)=0]"
		[Register ("onFinishInflate", "()V", "GetOnFinishInflateHandler")]
		public virtual void OnFinishInflate ()
		{
			if (id_onFinishInflate == IntPtr.Zero)
				id_onFinishInflate = JNIEnv.GetMethodID (class_ref, "onFinishInflate", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onFinishInflate);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFinishInflate", "()V"));
		}

		static Delegate cb_setApplicationId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetApplicationId_Ljava_lang_String_Handler ()
		{
			if (cb_setApplicationId_Ljava_lang_String_ == null)
				cb_setApplicationId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetApplicationId_Ljava_lang_String_);
			return cb_setApplicationId_Ljava_lang_String_;
		}

		static void n_SetApplicationId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Widget.LoginButton __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetApplicationId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setApplicationId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton']/method[@name='setApplicationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setApplicationId", "(Ljava/lang/String;)V", "GetSetApplicationId_Ljava_lang_String_Handler")]
		public virtual void SetApplicationId (string p0)
		{
			if (id_setApplicationId_Ljava_lang_String_ == IntPtr.Zero)
				id_setApplicationId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setApplicationId", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setApplicationId_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setApplicationId", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setFragment_Landroid_support_v4_app_Fragment_;
#pragma warning disable 0169
		static Delegate GetSetFragment_Landroid_support_v4_app_Fragment_Handler ()
		{
			if (cb_setFragment_Landroid_support_v4_app_Fragment_ == null)
				cb_setFragment_Landroid_support_v4_app_Fragment_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFragment_Landroid_support_v4_app_Fragment_);
			return cb_setFragment_Landroid_support_v4_app_Fragment_;
		}

		static void n_SetFragment_Landroid_support_v4_app_Fragment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Widget.LoginButton __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.App.Fragment p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.Fragment> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetFragment (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFragment_Landroid_support_v4_app_Fragment_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton']/method[@name='setFragment' and count(parameter)=1 and parameter[1][@type='android.support.v4.app.Fragment']]"
		[Register ("setFragment", "(Landroid/support/v4/app/Fragment;)V", "GetSetFragment_Landroid_support_v4_app_Fragment_Handler")]
		public virtual void SetFragment (global::Android.Support.V4.App.Fragment p0)
		{
			if (id_setFragment_Landroid_support_v4_app_Fragment_ == IntPtr.Zero)
				id_setFragment_Landroid_support_v4_app_Fragment_ = JNIEnv.GetMethodID (class_ref, "setFragment", "(Landroid/support/v4/app/Fragment;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setFragment_Landroid_support_v4_app_Fragment_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFragment", "(Landroid/support/v4/app/Fragment;)V"), new JValue (p0));
		}

		static Delegate cb_setPublishPermissions_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetPublishPermissions_Ljava_util_List_Handler ()
		{
			if (cb_setPublishPermissions_Ljava_util_List_ == null)
				cb_setPublishPermissions_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPublishPermissions_Ljava_util_List_);
			return cb_setPublishPermissions_Ljava_util_List_;
		}

		static void n_SetPublishPermissions_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Widget.LoginButton __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPublishPermissions (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPublishPermissions_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton']/method[@name='setPublishPermissions' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("setPublishPermissions", "(Ljava/util/List;)V", "GetSetPublishPermissions_Ljava_util_List_Handler")]
		public virtual void SetPublishPermissions (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_setPublishPermissions_Ljava_util_List_ == IntPtr.Zero)
				id_setPublishPermissions_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setPublishPermissions", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPublishPermissions_Ljava_util_List_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPublishPermissions", "(Ljava/util/List;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setReadPermissions_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetReadPermissions_Ljava_util_List_Handler ()
		{
			if (cb_setReadPermissions_Ljava_util_List_ == null)
				cb_setReadPermissions_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetReadPermissions_Ljava_util_List_);
			return cb_setReadPermissions_Ljava_util_List_;
		}

		static void n_SetReadPermissions_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Widget.LoginButton __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetReadPermissions (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setReadPermissions_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton']/method[@name='setReadPermissions' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("setReadPermissions", "(Ljava/util/List;)V", "GetSetReadPermissions_Ljava_util_List_Handler")]
		public virtual void SetReadPermissions (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_setReadPermissions_Ljava_util_List_ == IntPtr.Zero)
				id_setReadPermissions_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setReadPermissions", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setReadPermissions_Ljava_util_List_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReadPermissions", "(Ljava/util/List;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setSession_Lcom_facebook_Session_;
#pragma warning disable 0169
		static Delegate GetSetSession_Lcom_facebook_Session_Handler ()
		{
			if (cb_setSession_Lcom_facebook_Session_ == null)
				cb_setSession_Lcom_facebook_Session_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSession_Lcom_facebook_Session_);
			return cb_setSession_Lcom_facebook_Session_;
		}

		static void n_SetSession_Lcom_facebook_Session_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Widget.LoginButton __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.Session p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSession (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSession_Lcom_facebook_Session_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='LoginButton']/method[@name='setSession' and count(parameter)=1 and parameter[1][@type='com.facebook.Session']]"
		[Register ("setSession", "(Lcom/facebook/Session;)V", "GetSetSession_Lcom_facebook_Session_Handler")]
		public virtual void SetSession (global::Xamarin.FacebookBinding.Session p0)
		{
			if (id_setSession_Lcom_facebook_Session_ == IntPtr.Zero)
				id_setSession_Lcom_facebook_Session_ = JNIEnv.GetMethodID (class_ref, "setSession", "(Lcom/facebook/Session;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setSession_Lcom_facebook_Session_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSession", "(Lcom/facebook/Session;)V"), new JValue (p0));
		}

#region "Event implementation for Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListener"
		public event EventHandler<global::Xamarin.FacebookBinding.Widget.LoginButton.ErrorEventArgs> ErrorEvent {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListener, global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListenerImplementor>(
						ref weak_implementor___SetOnErrorListener,
						__CreateIOnErrorListenerImplementor,
						__v => OnErrorListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListener, global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListenerImplementor>(
						ref weak_implementor___SetOnErrorListener,
						global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListenerImplementor.__IsEmpty,
						__v => OnErrorListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOnErrorListener;

		global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListenerImplementor __CreateIOnErrorListenerImplementor ()
		{
			return new global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListenerImplementor (this);
		}
#endregion
	}
}
