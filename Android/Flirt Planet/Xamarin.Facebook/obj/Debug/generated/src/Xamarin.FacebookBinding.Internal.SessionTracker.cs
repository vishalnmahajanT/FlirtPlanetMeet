using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.internal']/class[@name='SessionTracker']"
	[global::Android.Runtime.Register ("com/facebook/internal/SessionTracker", DoNotGenerateAcw=true)]
	public partial class SessionTracker : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.internal']/class[@name='SessionTracker.ActiveSessionBroadcastReceiver']"
		[global::Android.Runtime.Register ("com/facebook/internal/SessionTracker$ActiveSessionBroadcastReceiver", DoNotGenerateAcw=true)]
		public partial class ActiveSessionBroadcastReceiver : global::Android.Content.BroadcastReceiver {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/internal/SessionTracker$ActiveSessionBroadcastReceiver", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ActiveSessionBroadcastReceiver); }
			}

			protected ActiveSessionBroadcastReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
			static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler ()
			{
				if (cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
					cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReceive_Landroid_content_Context_Landroid_content_Intent_);
				return cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
			}

			static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Xamarin.FacebookBinding.Internal.SessionTracker.ActiveSessionBroadcastReceiver __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Internal.SessionTracker.ActiveSessionBroadcastReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnReceive (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onReceive_Landroid_content_Context_Landroid_content_Intent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='SessionTracker.ActiveSessionBroadcastReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
			[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
			public override void OnReceive (global::Android.Content.Context p0, global::Android.Content.Intent p1)
			{
				if (id_onReceive_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
					id_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onReceive_Landroid_content_Context_Landroid_content_Intent_, new JValue (p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V"), new JValue (p0), new JValue (p1));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.internal']/class[@name='SessionTracker.CallbackWrapper']"
		[global::Android.Runtime.Register ("com/facebook/internal/SessionTracker$CallbackWrapper", DoNotGenerateAcw=true)]
		public partial class CallbackWrapper : global::Java.Lang.Object, global::Xamarin.FacebookBinding.Session.IStatusCallback {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/internal/SessionTracker$CallbackWrapper", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CallbackWrapper); }
			}

			protected CallbackWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_facebook_internal_SessionTracker_Lcom_facebook_Session_StatusCallback_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.internal']/class[@name='SessionTracker.CallbackWrapper']/constructor[@name='SessionTracker.CallbackWrapper' and count(parameter)=2 and parameter[1][@type='com.facebook.internal.SessionTracker'] and parameter[2][@type='com.facebook.Session.StatusCallback']]"
			[Register (".ctor", "(Lcom/facebook/internal/SessionTracker;Lcom/facebook/Session$StatusCallback;)V", "")]
			public CallbackWrapper (global::Xamarin.FacebookBinding.Internal.SessionTracker __self, global::Xamarin.FacebookBinding.Session.IStatusCallback p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (CallbackWrapper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/facebook/Session$StatusCallback;)V", new JValue (__self), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/facebook/Session$StatusCallback;)V", new JValue (__self), new JValue (p1));
					return;
				}

				if (id_ctor_Lcom_facebook_internal_SessionTracker_Lcom_facebook_Session_StatusCallback_ == IntPtr.Zero)
					id_ctor_Lcom_facebook_internal_SessionTracker_Lcom_facebook_Session_StatusCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/internal/SessionTracker;Lcom/facebook/Session$StatusCallback;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_internal_SessionTracker_Lcom_facebook_Session_StatusCallback_, new JValue (__self), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_facebook_internal_SessionTracker_Lcom_facebook_Session_StatusCallback_, new JValue (__self), new JValue (p1));
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
				global::Xamarin.FacebookBinding.Internal.SessionTracker.CallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Internal.SessionTracker.CallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.Session p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.SessionState p1 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionState> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Exception p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.Call (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_call_Lcom_facebook_Session_Lcom_facebook_SessionState_Ljava_lang_Exception_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='SessionTracker.CallbackWrapper']/method[@name='call' and count(parameter)=3 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='com.facebook.SessionState'] and parameter[3][@type='java.lang.Exception']]"
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
				return JNIEnv.FindClass ("com/facebook/internal/SessionTracker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SessionTracker); }
		}

		protected SessionTracker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_facebook_Session_StatusCallback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.internal']/class[@name='SessionTracker']/constructor[@name='SessionTracker' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.facebook.Session.StatusCallback']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/facebook/Session$StatusCallback;)V", "")]
		public SessionTracker (global::Android.Content.Context p0, global::Xamarin.FacebookBinding.Session.IStatusCallback p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SessionTracker)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/facebook/Session$StatusCallback;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/facebook/Session$StatusCallback;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Lcom_facebook_Session_StatusCallback_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lcom_facebook_Session_StatusCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/facebook/Session$StatusCallback;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_facebook_Session_StatusCallback_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_facebook_Session_StatusCallback_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_facebook_Session_StatusCallback_Lcom_facebook_Session_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.internal']/class[@name='SessionTracker']/constructor[@name='SessionTracker' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.facebook.Session.StatusCallback'] and parameter[3][@type='com.facebook.Session'] and parameter[4][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/facebook/Session$StatusCallback;Lcom/facebook/Session;Z)V", "")]
		public SessionTracker (global::Android.Content.Context p0, global::Xamarin.FacebookBinding.Session.IStatusCallback p1, global::Xamarin.FacebookBinding.Session p2, bool p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SessionTracker)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/facebook/Session$StatusCallback;Lcom/facebook/Session;Z)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/facebook/Session$StatusCallback;Lcom/facebook/Session;Z)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				return;
			}

			if (id_ctor_Landroid_content_Context_Lcom_facebook_Session_StatusCallback_Lcom_facebook_Session_Z == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lcom_facebook_Session_StatusCallback_Lcom_facebook_Session_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/facebook/Session$StatusCallback;Lcom/facebook/Session;Z)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_facebook_Session_StatusCallback_Lcom_facebook_Session_Z, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_facebook_Session_StatusCallback_Lcom_facebook_Session_Z, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static Delegate cb_isTracking;
#pragma warning disable 0169
		static Delegate GetIsTrackingHandler ()
		{
			if (cb_isTracking == null)
				cb_isTracking = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTracking);
			return cb_isTracking;
		}

		static bool n_IsTracking (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Internal.SessionTracker __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Internal.SessionTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTracking;
		}
#pragma warning restore 0169

		static IntPtr id_isTracking;
		public virtual bool IsTracking {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='SessionTracker']/method[@name='isTracking' and count(parameter)=0]"
			[Register ("isTracking", "()Z", "GetIsTrackingHandler")]
			get {
				if (id_isTracking == IntPtr.Zero)
					id_isTracking = JNIEnv.GetMethodID (class_ref, "isTracking", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isTracking);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isTracking", "()Z"));
			}
		}

		static Delegate cb_isTrackingActiveSession;
#pragma warning disable 0169
		static Delegate GetIsTrackingActiveSessionHandler ()
		{
			if (cb_isTrackingActiveSession == null)
				cb_isTrackingActiveSession = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTrackingActiveSession);
			return cb_isTrackingActiveSession;
		}

		static bool n_IsTrackingActiveSession (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Internal.SessionTracker __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Internal.SessionTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTrackingActiveSession;
		}
#pragma warning restore 0169

		static IntPtr id_isTrackingActiveSession;
		public virtual bool IsTrackingActiveSession {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='SessionTracker']/method[@name='isTrackingActiveSession' and count(parameter)=0]"
			[Register ("isTrackingActiveSession", "()Z", "GetIsTrackingActiveSessionHandler")]
			get {
				if (id_isTrackingActiveSession == IntPtr.Zero)
					id_isTrackingActiveSession = JNIEnv.GetMethodID (class_ref, "isTrackingActiveSession", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isTrackingActiveSession);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isTrackingActiveSession", "()Z"));
			}
		}

		static Delegate cb_getOpenSession;
#pragma warning disable 0169
		static Delegate GetGetOpenSessionHandler ()
		{
			if (cb_getOpenSession == null)
				cb_getOpenSession = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOpenSession);
			return cb_getOpenSession;
		}

		static IntPtr n_GetOpenSession (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Internal.SessionTracker __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Internal.SessionTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OpenSession);
		}
#pragma warning restore 0169

		static IntPtr id_getOpenSession;
		public virtual global::Xamarin.FacebookBinding.Session OpenSession {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='SessionTracker']/method[@name='getOpenSession' and count(parameter)=0]"
			[Register ("getOpenSession", "()Lcom/facebook/Session;", "GetGetOpenSessionHandler")]
			get {
				if (id_getOpenSession == IntPtr.Zero)
					id_getOpenSession = JNIEnv.GetMethodID (class_ref, "getOpenSession", "()Lcom/facebook/Session;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (JNIEnv.CallObjectMethod  (Handle, id_getOpenSession), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOpenSession", "()Lcom/facebook/Session;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSession;
#pragma warning disable 0169
		static Delegate GetGetSessionHandler ()
		{
			if (cb_getSession == null)
				cb_getSession = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSession);
			return cb_getSession;
		}

		static IntPtr n_GetSession (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Internal.SessionTracker __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Internal.SessionTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Session);
		}
#pragma warning restore 0169

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
			global::Xamarin.FacebookBinding.Internal.SessionTracker __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Internal.SessionTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.Session p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Session = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSession;
		static IntPtr id_setSession_Lcom_facebook_Session_;
		public virtual global::Xamarin.FacebookBinding.Session Session {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='SessionTracker']/method[@name='getSession' and count(parameter)=0]"
			[Register ("getSession", "()Lcom/facebook/Session;", "GetGetSessionHandler")]
			get {
				if (id_getSession == IntPtr.Zero)
					id_getSession = JNIEnv.GetMethodID (class_ref, "getSession", "()Lcom/facebook/Session;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (JNIEnv.CallObjectMethod  (Handle, id_getSession), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSession", "()Lcom/facebook/Session;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='SessionTracker']/method[@name='setSession' and count(parameter)=1 and parameter[1][@type='com.facebook.Session']]"
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

		static Delegate cb_startTracking;
#pragma warning disable 0169
		static Delegate GetStartTrackingHandler ()
		{
			if (cb_startTracking == null)
				cb_startTracking = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartTracking);
			return cb_startTracking;
		}

		static void n_StartTracking (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Internal.SessionTracker __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Internal.SessionTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartTracking ();
		}
#pragma warning restore 0169

		static IntPtr id_startTracking;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='SessionTracker']/method[@name='startTracking' and count(parameter)=0]"
		[Register ("startTracking", "()V", "GetStartTrackingHandler")]
		public virtual void StartTracking ()
		{
			if (id_startTracking == IntPtr.Zero)
				id_startTracking = JNIEnv.GetMethodID (class_ref, "startTracking", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_startTracking);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startTracking", "()V"));
		}

		static Delegate cb_stopTracking;
#pragma warning disable 0169
		static Delegate GetStopTrackingHandler ()
		{
			if (cb_stopTracking == null)
				cb_stopTracking = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopTracking);
			return cb_stopTracking;
		}

		static void n_StopTracking (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Internal.SessionTracker __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Internal.SessionTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopTracking ();
		}
#pragma warning restore 0169

		static IntPtr id_stopTracking;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='SessionTracker']/method[@name='stopTracking' and count(parameter)=0]"
		[Register ("stopTracking", "()V", "GetStopTrackingHandler")]
		public virtual void StopTracking ()
		{
			if (id_stopTracking == IntPtr.Zero)
				id_stopTracking = JNIEnv.GetMethodID (class_ref, "stopTracking", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_stopTracking);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopTracking", "()V"));
		}

	}
}
