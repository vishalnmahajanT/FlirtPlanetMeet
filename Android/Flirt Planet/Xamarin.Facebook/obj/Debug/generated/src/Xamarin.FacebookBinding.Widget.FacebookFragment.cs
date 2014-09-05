using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.widget']/class[@name='FacebookFragment']"
	[global::Android.Runtime.Register ("com/facebook/widget/FacebookFragment", DoNotGenerateAcw=true)]
	public partial class FacebookFragment : global::Android.Support.V4.App.Fragment {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.widget']/class[@name='FacebookFragment.DefaultSessionStatusCallback']"
		[global::Android.Runtime.Register ("com/facebook/widget/FacebookFragment$DefaultSessionStatusCallback", DoNotGenerateAcw=true)]
		public partial class DefaultSessionStatusCallback : global::Java.Lang.Object, global::Xamarin.FacebookBinding.Session.IStatusCallback {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/widget/FacebookFragment$DefaultSessionStatusCallback", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DefaultSessionStatusCallback); }
			}

			protected DefaultSessionStatusCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Xamarin.FacebookBinding.Widget.FacebookFragment.DefaultSessionStatusCallback __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.FacebookFragment.DefaultSessionStatusCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.Session p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.SessionState p1 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionState> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Exception p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.Call (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_call_Lcom_facebook_Session_Lcom_facebook_SessionState_Ljava_lang_Exception_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='FacebookFragment.DefaultSessionStatusCallback']/method[@name='call' and count(parameter)=3 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='com.facebook.SessionState'] and parameter[3][@type='java.lang.Exception']]"
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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/widget/FacebookFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FacebookFragment); }
		}

		protected FacebookFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAccessToken;
		protected string AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='FacebookFragment']/method[@name='getAccessToken' and count(parameter)=0]"
			[Register ("getAccessToken", "()Ljava/lang/String;", "GetGetAccessTokenHandler")]
			get {
				if (id_getAccessToken == IntPtr.Zero)
					id_getAccessToken = JNIEnv.GetMethodID (class_ref, "getAccessToken", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAccessToken), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getExpirationDate;
		protected global::Java.Util.Date ExpirationDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='FacebookFragment']/method[@name='getExpirationDate' and count(parameter)=0]"
			[Register ("getExpirationDate", "()Ljava/util/Date;", "GetGetExpirationDateHandler")]
			get {
				if (id_getExpirationDate == IntPtr.Zero)
					id_getExpirationDate = JNIEnv.GetMethodID (class_ref, "getExpirationDate", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getExpirationDate), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isSessionOpen;
		protected bool IsSessionOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='FacebookFragment']/method[@name='isSessionOpen' and count(parameter)=0]"
			[Register ("isSessionOpen", "()Z", "GetIsSessionOpenHandler")]
			get {
				if (id_isSessionOpen == IntPtr.Zero)
					id_isSessionOpen = JNIEnv.GetMethodID (class_ref, "isSessionOpen", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isSessionOpen);
			}
		}

		static IntPtr id_getSession;
		protected global::Xamarin.FacebookBinding.Session Session {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='FacebookFragment']/method[@name='getSession' and count(parameter)=0]"
			[Register ("getSession", "()Lcom/facebook/Session;", "GetGetSessionHandler")]
			get {
				if (id_getSession == IntPtr.Zero)
					id_getSession = JNIEnv.GetMethodID (class_ref, "getSession", "()Lcom/facebook/Session;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (JNIEnv.CallObjectMethod  (Handle, id_getSession), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getSessionPermissions;
		protected global::System.Collections.Generic.IList<string> SessionPermissions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='FacebookFragment']/method[@name='getSessionPermissions' and count(parameter)=0]"
			[Register ("getSessionPermissions", "()Ljava/util/List;", "GetGetSessionPermissionsHandler")]
			get {
				if (id_getSessionPermissions == IntPtr.Zero)
					id_getSessionPermissions = JNIEnv.GetMethodID (class_ref, "getSessionPermissions", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getSessionPermissions), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getSessionState;
		protected global::Xamarin.FacebookBinding.SessionState SessionState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='FacebookFragment']/method[@name='getSessionState' and count(parameter)=0]"
			[Register ("getSessionState", "()Lcom/facebook/SessionState;", "GetGetSessionStateHandler")]
			get {
				if (id_getSessionState == IntPtr.Zero)
					id_getSessionState = JNIEnv.GetMethodID (class_ref, "getSessionState", "()Lcom/facebook/SessionState;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionState> (JNIEnv.CallObjectMethod  (Handle, id_getSessionState), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_closeSession;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='FacebookFragment']/method[@name='closeSession' and count(parameter)=0]"
		[Register ("closeSession", "()V", "")]
		protected void CloseSession ()
		{
			if (id_closeSession == IntPtr.Zero)
				id_closeSession = JNIEnv.GetMethodID (class_ref, "closeSession", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_closeSession);
		}

		static IntPtr id_closeSessionAndClearTokenInformation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='FacebookFragment']/method[@name='closeSessionAndClearTokenInformation' and count(parameter)=0]"
		[Register ("closeSessionAndClearTokenInformation", "()V", "")]
		protected void CloseSessionAndClearTokenInformation ()
		{
			if (id_closeSessionAndClearTokenInformation == IntPtr.Zero)
				id_closeSessionAndClearTokenInformation = JNIEnv.GetMethodID (class_ref, "closeSessionAndClearTokenInformation", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_closeSessionAndClearTokenInformation);
		}

		static Delegate cb_onSessionStateChange_Lcom_facebook_SessionState_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnSessionStateChange_Lcom_facebook_SessionState_Ljava_lang_Exception_Handler ()
		{
			if (cb_onSessionStateChange_Lcom_facebook_SessionState_Ljava_lang_Exception_ == null)
				cb_onSessionStateChange_Lcom_facebook_SessionState_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSessionStateChange_Lcom_facebook_SessionState_Ljava_lang_Exception_);
			return cb_onSessionStateChange_Lcom_facebook_SessionState_Ljava_lang_Exception_;
		}

		static void n_OnSessionStateChange_Lcom_facebook_SessionState_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Xamarin.FacebookBinding.Widget.FacebookFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.FacebookFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.SessionState p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionState> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnSessionStateChange (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onSessionStateChange_Lcom_facebook_SessionState_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='FacebookFragment']/method[@name='onSessionStateChange' and count(parameter)=2 and parameter[1][@type='com.facebook.SessionState'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("onSessionStateChange", "(Lcom/facebook/SessionState;Ljava/lang/Exception;)V", "GetOnSessionStateChange_Lcom_facebook_SessionState_Ljava_lang_Exception_Handler")]
		protected virtual void OnSessionStateChange (global::Xamarin.FacebookBinding.SessionState p0, global::Java.Lang.Exception p1)
		{
			if (id_onSessionStateChange_Lcom_facebook_SessionState_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onSessionStateChange_Lcom_facebook_SessionState_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onSessionStateChange", "(Lcom/facebook/SessionState;Ljava/lang/Exception;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onSessionStateChange_Lcom_facebook_SessionState_Ljava_lang_Exception_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSessionStateChange", "(Lcom/facebook/SessionState;Ljava/lang/Exception;)V"), new JValue (p0), new JValue (p1));
		}

		static IntPtr id_openSession;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='FacebookFragment']/method[@name='openSession' and count(parameter)=0]"
		[Register ("openSession", "()V", "")]
		protected void OpenSession ()
		{
			if (id_openSession == IntPtr.Zero)
				id_openSession = JNIEnv.GetMethodID (class_ref, "openSession", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_openSession);
		}

		static IntPtr id_openSessionForPublish_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='FacebookFragment']/method[@name='openSessionForPublish' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List']]"
		[Register ("openSessionForPublish", "(Ljava/lang/String;Ljava/util/List;)V", "")]
		protected void OpenSessionForPublish (string p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_openSessionForPublish_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_openSessionForPublish_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "openSessionForPublish", "(Ljava/lang/String;Ljava/util/List;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			JNIEnv.CallVoidMethod  (Handle, id_openSessionForPublish_Ljava_lang_String_Ljava_util_List_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_openSessionForPublish_Ljava_lang_String_Ljava_util_List_Lcom_facebook_SessionLoginBehavior_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='FacebookFragment']/method[@name='openSessionForPublish' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List'] and parameter[3][@type='com.facebook.SessionLoginBehavior'] and parameter[4][@type='int']]"
		[Register ("openSessionForPublish", "(Ljava/lang/String;Ljava/util/List;Lcom/facebook/SessionLoginBehavior;I)V", "")]
		protected void OpenSessionForPublish (string p0, global::System.Collections.Generic.IList<string> p1, global::Xamarin.FacebookBinding.SessionLoginBehavior p2, int p3)
		{
			if (id_openSessionForPublish_Ljava_lang_String_Ljava_util_List_Lcom_facebook_SessionLoginBehavior_I == IntPtr.Zero)
				id_openSessionForPublish_Ljava_lang_String_Ljava_util_List_Lcom_facebook_SessionLoginBehavior_I = JNIEnv.GetMethodID (class_ref, "openSessionForPublish", "(Ljava/lang/String;Ljava/util/List;Lcom/facebook/SessionLoginBehavior;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			JNIEnv.CallVoidMethod  (Handle, id_openSessionForPublish_Ljava_lang_String_Ljava_util_List_Lcom_facebook_SessionLoginBehavior_I, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_openSessionForRead_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='FacebookFragment']/method[@name='openSessionForRead' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List']]"
		[Register ("openSessionForRead", "(Ljava/lang/String;Ljava/util/List;)V", "")]
		protected void OpenSessionForRead (string p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_openSessionForRead_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_openSessionForRead_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "openSessionForRead", "(Ljava/lang/String;Ljava/util/List;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			JNIEnv.CallVoidMethod  (Handle, id_openSessionForRead_Ljava_lang_String_Ljava_util_List_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_openSessionForRead_Ljava_lang_String_Ljava_util_List_Lcom_facebook_SessionLoginBehavior_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='FacebookFragment']/method[@name='openSessionForRead' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List'] and parameter[3][@type='com.facebook.SessionLoginBehavior'] and parameter[4][@type='int']]"
		[Register ("openSessionForRead", "(Ljava/lang/String;Ljava/util/List;Lcom/facebook/SessionLoginBehavior;I)V", "")]
		protected void OpenSessionForRead (string p0, global::System.Collections.Generic.IList<string> p1, global::Xamarin.FacebookBinding.SessionLoginBehavior p2, int p3)
		{
			if (id_openSessionForRead_Ljava_lang_String_Ljava_util_List_Lcom_facebook_SessionLoginBehavior_I == IntPtr.Zero)
				id_openSessionForRead_Ljava_lang_String_Ljava_util_List_Lcom_facebook_SessionLoginBehavior_I = JNIEnv.GetMethodID (class_ref, "openSessionForRead", "(Ljava/lang/String;Ljava/util/List;Lcom/facebook/SessionLoginBehavior;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			JNIEnv.CallVoidMethod  (Handle, id_openSessionForRead_Ljava_lang_String_Ljava_util_List_Lcom_facebook_SessionLoginBehavior_I, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
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
			global::Xamarin.FacebookBinding.Widget.FacebookFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.FacebookFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.Session p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSession (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSession_Lcom_facebook_Session_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='FacebookFragment']/method[@name='setSession' and count(parameter)=1 and parameter[1][@type='com.facebook.Session']]"
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

	}
}
