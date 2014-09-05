using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.widget']/class[@name='UserSettingsFragment']"
	[global::Android.Runtime.Register ("com/facebook/widget/UserSettingsFragment", DoNotGenerateAcw=true)]
	public partial class UserSettingsFragment : global::Xamarin.FacebookBinding.Widget.FacebookFragment {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/widget/UserSettingsFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UserSettingsFragment); }
		}

		protected UserSettingsFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.widget']/class[@name='UserSettingsFragment']/constructor[@name='UserSettingsFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public UserSettingsFragment () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (UserSettingsFragment)) {
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
			global::Xamarin.FacebookBinding.Widget.UserSettingsFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.UserSettingsFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Xamarin.FacebookBinding.Widget.UserSettingsFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.UserSettingsFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.SessionDefaultAudience p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionDefaultAudience> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DefaultAudience = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultAudience;
		static IntPtr id_setDefaultAudience_Lcom_facebook_SessionDefaultAudience_;
		public virtual global::Xamarin.FacebookBinding.SessionDefaultAudience DefaultAudience {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='UserSettingsFragment']/method[@name='getDefaultAudience' and count(parameter)=0]"
			[Register ("getDefaultAudience", "()Lcom/facebook/SessionDefaultAudience;", "GetGetDefaultAudienceHandler")]
			get {
				if (id_getDefaultAudience == IntPtr.Zero)
					id_getDefaultAudience = JNIEnv.GetMethodID (class_ref, "getDefaultAudience", "()Lcom/facebook/SessionDefaultAudience;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionDefaultAudience> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultAudience), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionDefaultAudience> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultAudience", "()Lcom/facebook/SessionDefaultAudience;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='UserSettingsFragment']/method[@name='setDefaultAudience' and count(parameter)=1 and parameter[1][@type='com.facebook.SessionDefaultAudience']]"
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
			global::Xamarin.FacebookBinding.Widget.UserSettingsFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.UserSettingsFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Xamarin.FacebookBinding.Widget.UserSettingsFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.UserSettingsFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.SessionLoginBehavior p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionLoginBehavior> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoginBehavior = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLoginBehavior;
		static IntPtr id_setLoginBehavior_Lcom_facebook_SessionLoginBehavior_;
		public virtual global::Xamarin.FacebookBinding.SessionLoginBehavior LoginBehavior {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='UserSettingsFragment']/method[@name='getLoginBehavior' and count(parameter)=0]"
			[Register ("getLoginBehavior", "()Lcom/facebook/SessionLoginBehavior;", "GetGetLoginBehaviorHandler")]
			get {
				if (id_getLoginBehavior == IntPtr.Zero)
					id_getLoginBehavior = JNIEnv.GetMethodID (class_ref, "getLoginBehavior", "()Lcom/facebook/SessionLoginBehavior;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionLoginBehavior> (JNIEnv.CallObjectMethod  (Handle, id_getLoginBehavior), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionLoginBehavior> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLoginBehavior", "()Lcom/facebook/SessionLoginBehavior;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='UserSettingsFragment']/method[@name='setLoginBehavior' and count(parameter)=1 and parameter[1][@type='com.facebook.SessionLoginBehavior']]"
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
			global::Xamarin.FacebookBinding.Widget.UserSettingsFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.UserSettingsFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Xamarin.FacebookBinding.Widget.UserSettingsFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.UserSettingsFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListener p0 = (global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListener)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnErrorListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOnErrorListener;
		static IntPtr id_setOnErrorListener_Lcom_facebook_widget_LoginButton_OnErrorListener_;
		public virtual global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListener OnErrorListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='UserSettingsFragment']/method[@name='getOnErrorListener' and count(parameter)=0]"
			[Register ("getOnErrorListener", "()Lcom/facebook/widget/LoginButton$OnErrorListener;", "GetGetOnErrorListenerHandler")]
			get {
				if (id_getOnErrorListener == IntPtr.Zero)
					id_getOnErrorListener = JNIEnv.GetMethodID (class_ref, "getOnErrorListener", "()Lcom/facebook/widget/LoginButton$OnErrorListener;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListener> (JNIEnv.CallObjectMethod  (Handle, id_getOnErrorListener), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.LoginButton.IOnErrorListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnErrorListener", "()Lcom/facebook/widget/LoginButton$OnErrorListener;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='UserSettingsFragment']/method[@name='setOnErrorListener' and count(parameter)=1 and parameter[1][@type='com.facebook.widget.LoginButton.OnErrorListener']]"
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
			global::Xamarin.FacebookBinding.Widget.UserSettingsFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.UserSettingsFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Xamarin.FacebookBinding.Widget.UserSettingsFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.UserSettingsFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.Session.IStatusCallback p0 = (global::Xamarin.FacebookBinding.Session.IStatusCallback)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.IStatusCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SessionStatusCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSessionStatusCallback;
		static IntPtr id_setSessionStatusCallback_Lcom_facebook_Session_StatusCallback_;
		public virtual global::Xamarin.FacebookBinding.Session.IStatusCallback SessionStatusCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='UserSettingsFragment']/method[@name='getSessionStatusCallback' and count(parameter)=0]"
			[Register ("getSessionStatusCallback", "()Lcom/facebook/Session$StatusCallback;", "GetGetSessionStatusCallbackHandler")]
			get {
				if (id_getSessionStatusCallback == IntPtr.Zero)
					id_getSessionStatusCallback = JNIEnv.GetMethodID (class_ref, "getSessionStatusCallback", "()Lcom/facebook/Session$StatusCallback;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.IStatusCallback> (JNIEnv.CallObjectMethod  (Handle, id_getSessionStatusCallback), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session.IStatusCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSessionStatusCallback", "()Lcom/facebook/Session$StatusCallback;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='UserSettingsFragment']/method[@name='setSessionStatusCallback' and count(parameter)=1 and parameter[1][@type='com.facebook.Session.StatusCallback']]"
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
			global::Xamarin.FacebookBinding.Widget.UserSettingsFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.UserSettingsFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearPermissions ();
		}
#pragma warning restore 0169

		static IntPtr id_clearPermissions;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='UserSettingsFragment']/method[@name='clearPermissions' and count(parameter)=0]"
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

		static Delegate cb_onActivityCreated_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnActivityCreated_Landroid_os_Bundle_Handler ()
		{
			if (cb_onActivityCreated_Landroid_os_Bundle_ == null)
				cb_onActivityCreated_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityCreated_Landroid_os_Bundle_);
			return cb_onActivityCreated_Landroid_os_Bundle_;
		}

		static void n_OnActivityCreated_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Widget.UserSettingsFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.UserSettingsFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityCreated (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityCreated_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='UserSettingsFragment']/method[@name='onActivityCreated' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onActivityCreated", "(Landroid/os/Bundle;)V", "GetOnActivityCreated_Landroid_os_Bundle_Handler")]
		public override void OnActivityCreated (global::Android.OS.Bundle p0)
		{
			if (id_onActivityCreated_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onActivityCreated_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onActivityCreated", "(Landroid/os/Bundle;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onActivityCreated_Landroid_os_Bundle_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityCreated", "(Landroid/os/Bundle;)V"), new JValue (p0));
		}

		static Delegate cb_onActivityResult_IILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnActivityResult_IILandroid_content_Intent_Handler ()
		{
			if (cb_onActivityResult_IILandroid_content_Intent_ == null)
				cb_onActivityResult_IILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_OnActivityResult_IILandroid_content_Intent_);
			return cb_onActivityResult_IILandroid_content_Intent_;
		}

		static void n_OnActivityResult_IILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Xamarin.FacebookBinding.Widget.UserSettingsFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.UserSettingsFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityResult (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityResult_IILandroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='UserSettingsFragment']/method[@name='onActivityResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("onActivityResult", "(IILandroid/content/Intent;)V", "GetOnActivityResult_IILandroid_content_Intent_Handler")]
		public override void OnActivityResult (int p0, int p1, global::Android.Content.Intent p2)
		{
			if (id_onActivityResult_IILandroid_content_Intent_ == IntPtr.Zero)
				id_onActivityResult_IILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onActivityResult", "(IILandroid/content/Intent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onActivityResult_IILandroid_content_Intent_, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityResult", "(IILandroid/content/Intent;)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Widget.UserSettingsFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.UserSettingsFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='UserSettingsFragment']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		public override void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onDestroy);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDestroy", "()V"));
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
			global::Xamarin.FacebookBinding.Widget.UserSettingsFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.UserSettingsFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.SessionState p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionState> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnSessionStateChange (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onSessionStateChange_Lcom_facebook_SessionState_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='UserSettingsFragment']/method[@name='onSessionStateChange' and count(parameter)=2 and parameter[1][@type='com.facebook.SessionState'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("onSessionStateChange", "(Lcom/facebook/SessionState;Ljava/lang/Exception;)V", "GetOnSessionStateChange_Lcom_facebook_SessionState_Ljava_lang_Exception_Handler")]
		protected override void OnSessionStateChange (global::Xamarin.FacebookBinding.SessionState p0, global::Java.Lang.Exception p1)
		{
			if (id_onSessionStateChange_Lcom_facebook_SessionState_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onSessionStateChange_Lcom_facebook_SessionState_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onSessionStateChange", "(Lcom/facebook/SessionState;Ljava/lang/Exception;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onSessionStateChange_Lcom_facebook_SessionState_Ljava_lang_Exception_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSessionStateChange", "(Lcom/facebook/SessionState;Ljava/lang/Exception;)V"), new JValue (p0), new JValue (p1));
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
			global::Xamarin.FacebookBinding.Widget.UserSettingsFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.UserSettingsFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPublishPermissions (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPublishPermissions_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='UserSettingsFragment']/method[@name='setPublishPermissions' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
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
			global::Xamarin.FacebookBinding.Widget.UserSettingsFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.UserSettingsFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetReadPermissions (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setReadPermissions_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='UserSettingsFragment']/method[@name='setReadPermissions' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
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
			global::Xamarin.FacebookBinding.Widget.UserSettingsFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.UserSettingsFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.Session p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSession (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSession_Lcom_facebook_Session_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='UserSettingsFragment']/method[@name='setSession' and count(parameter)=1 and parameter[1][@type='com.facebook.Session']]"
		[Register ("setSession", "(Lcom/facebook/Session;)V", "GetSetSession_Lcom_facebook_Session_Handler")]
		public override void SetSession (global::Xamarin.FacebookBinding.Session p0)
		{
			if (id_setSession_Lcom_facebook_Session_ == IntPtr.Zero)
				id_setSession_Lcom_facebook_Session_ = JNIEnv.GetMethodID (class_ref, "setSession", "(Lcom/facebook/Session;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setSession_Lcom_facebook_Session_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSession", "(Lcom/facebook/Session;)V"), new JValue (p0));
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
}
