using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding.XAndroid {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.android']/class[@name='AsyncFacebookRunner']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/facebook/android/AsyncFacebookRunner", DoNotGenerateAcw=true)]
	public partial class AsyncFacebookRunner : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.android']/interface[@name='AsyncFacebookRunner.RequestListener']"
		[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
		[Register ("com/facebook/android/AsyncFacebookRunner$RequestListener", "", "Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner/IRequestListenerInvoker")]
		public partial interface IRequestListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/interface[@name='AsyncFacebookRunner.RequestListener']/method[@name='onComplete' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
			[Register ("onComplete", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetOnComplete_Ljava_lang_String_Ljava_lang_Object_Handler:Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner/IRequestListenerInvoker, Xamarin.Facebook")]
			void OnComplete (string p0, global::Java.Lang.Object p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/interface[@name='AsyncFacebookRunner.RequestListener']/method[@name='onFacebookError' and count(parameter)=2 and parameter[1][@type='com.facebook.android.FacebookError'] and parameter[2][@type='java.lang.Object']]"
			[Register ("onFacebookError", "(Lcom/facebook/android/FacebookError;Ljava/lang/Object;)V", "GetOnFacebookError_Lcom_facebook_android_FacebookError_Ljava_lang_Object_Handler:Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner/IRequestListenerInvoker, Xamarin.Facebook")]
			void OnFacebookError (global::Xamarin.FacebookBinding.XAndroid.FacebookError p0, global::Java.Lang.Object p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/interface[@name='AsyncFacebookRunner.RequestListener']/method[@name='onFileNotFoundException' and count(parameter)=2 and parameter[1][@type='java.io.FileNotFoundException'] and parameter[2][@type='java.lang.Object']]"
			[Register ("onFileNotFoundException", "(Ljava/io/FileNotFoundException;Ljava/lang/Object;)V", "GetOnFileNotFoundException_Ljava_io_FileNotFoundException_Ljava_lang_Object_Handler:Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner/IRequestListenerInvoker, Xamarin.Facebook")]
			void OnFileNotFoundException (global::Java.IO.FileNotFoundException p0, global::Java.Lang.Object p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/interface[@name='AsyncFacebookRunner.RequestListener']/method[@name='onIOException' and count(parameter)=2 and parameter[1][@type='java.io.IOException'] and parameter[2][@type='java.lang.Object']]"
			[Register ("onIOException", "(Ljava/io/IOException;Ljava/lang/Object;)V", "GetOnIOException_Ljava_io_IOException_Ljava_lang_Object_Handler:Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner/IRequestListenerInvoker, Xamarin.Facebook")]
			void OnIOException (global::Java.IO.IOException p0, global::Java.Lang.Object p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/interface[@name='AsyncFacebookRunner.RequestListener']/method[@name='onMalformedURLException' and count(parameter)=2 and parameter[1][@type='java.net.MalformedURLException'] and parameter[2][@type='java.lang.Object']]"
			[Register ("onMalformedURLException", "(Ljava/net/MalformedURLException;Ljava/lang/Object;)V", "GetOnMalformedURLException_Ljava_net_MalformedURLException_Ljava_lang_Object_Handler:Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner/IRequestListenerInvoker, Xamarin.Facebook")]
			void OnMalformedURLException (global::Java.Net.MalformedURLException p0, global::Java.Lang.Object p1);

		}

		[global::Android.Runtime.Register ("com/facebook/android/AsyncFacebookRunner$RequestListener", DoNotGenerateAcw=true)]
		internal class IRequestListenerInvoker : global::Java.Lang.Object, IRequestListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/android/AsyncFacebookRunner$RequestListener");
			IntPtr class_ref;

			public static IRequestListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRequestListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.android.AsyncFacebookRunner.RequestListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRequestListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IRequestListenerInvoker); }
			}

			static Delegate cb_onComplete_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnComplete_Ljava_lang_String_Ljava_lang_Object_Handler ()
			{
				if (cb_onComplete_Ljava_lang_String_Ljava_lang_Object_ == null)
					cb_onComplete_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnComplete_Ljava_lang_String_Ljava_lang_Object_);
				return cb_onComplete_Ljava_lang_String_Ljava_lang_Object_;
			}

			static void n_OnComplete_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnComplete (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onComplete_Ljava_lang_String_Ljava_lang_Object_;
			public void OnComplete (string p0, global::Java.Lang.Object p1)
			{
				if (id_onComplete_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
					id_onComplete_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Ljava/lang/String;Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JNIEnv.CallVoidMethod (Handle, id_onComplete_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onFacebookError_Lcom_facebook_android_FacebookError_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnFacebookError_Lcom_facebook_android_FacebookError_Ljava_lang_Object_Handler ()
			{
				if (cb_onFacebookError_Lcom_facebook_android_FacebookError_Ljava_lang_Object_ == null)
					cb_onFacebookError_Lcom_facebook_android_FacebookError_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFacebookError_Lcom_facebook_android_FacebookError_Ljava_lang_Object_);
				return cb_onFacebookError_Lcom_facebook_android_FacebookError_Ljava_lang_Object_;
			}

			static void n_OnFacebookError_Lcom_facebook_android_FacebookError_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.XAndroid.FacebookError p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.FacebookError> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnFacebookError (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onFacebookError_Lcom_facebook_android_FacebookError_Ljava_lang_Object_;
			public void OnFacebookError (global::Xamarin.FacebookBinding.XAndroid.FacebookError p0, global::Java.Lang.Object p1)
			{
				if (id_onFacebookError_Lcom_facebook_android_FacebookError_Ljava_lang_Object_ == IntPtr.Zero)
					id_onFacebookError_Lcom_facebook_android_FacebookError_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onFacebookError", "(Lcom/facebook/android/FacebookError;Ljava/lang/Object;)V");
				JNIEnv.CallVoidMethod (Handle, id_onFacebookError_Lcom_facebook_android_FacebookError_Ljava_lang_Object_, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_onFileNotFoundException_Ljava_io_FileNotFoundException_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnFileNotFoundException_Ljava_io_FileNotFoundException_Ljava_lang_Object_Handler ()
			{
				if (cb_onFileNotFoundException_Ljava_io_FileNotFoundException_Ljava_lang_Object_ == null)
					cb_onFileNotFoundException_Ljava_io_FileNotFoundException_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFileNotFoundException_Ljava_io_FileNotFoundException_Ljava_lang_Object_);
				return cb_onFileNotFoundException_Ljava_io_FileNotFoundException_Ljava_lang_Object_;
			}

			static void n_OnFileNotFoundException_Ljava_io_FileNotFoundException_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.IO.FileNotFoundException p0 = global::Java.Lang.Object.GetObject<global::Java.IO.FileNotFoundException> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnFileNotFoundException (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onFileNotFoundException_Ljava_io_FileNotFoundException_Ljava_lang_Object_;
			public void OnFileNotFoundException (global::Java.IO.FileNotFoundException p0, global::Java.Lang.Object p1)
			{
				if (id_onFileNotFoundException_Ljava_io_FileNotFoundException_Ljava_lang_Object_ == IntPtr.Zero)
					id_onFileNotFoundException_Ljava_io_FileNotFoundException_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onFileNotFoundException", "(Ljava/io/FileNotFoundException;Ljava/lang/Object;)V");
				JNIEnv.CallVoidMethod (Handle, id_onFileNotFoundException_Ljava_io_FileNotFoundException_Ljava_lang_Object_, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_onIOException_Ljava_io_IOException_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnIOException_Ljava_io_IOException_Ljava_lang_Object_Handler ()
			{
				if (cb_onIOException_Ljava_io_IOException_Ljava_lang_Object_ == null)
					cb_onIOException_Ljava_io_IOException_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnIOException_Ljava_io_IOException_Ljava_lang_Object_);
				return cb_onIOException_Ljava_io_IOException_Ljava_lang_Object_;
			}

			static void n_OnIOException_Ljava_io_IOException_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.IO.IOException p0 = global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnIOException (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onIOException_Ljava_io_IOException_Ljava_lang_Object_;
			public void OnIOException (global::Java.IO.IOException p0, global::Java.Lang.Object p1)
			{
				if (id_onIOException_Ljava_io_IOException_Ljava_lang_Object_ == IntPtr.Zero)
					id_onIOException_Ljava_io_IOException_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onIOException", "(Ljava/io/IOException;Ljava/lang/Object;)V");
				JNIEnv.CallVoidMethod (Handle, id_onIOException_Ljava_io_IOException_Ljava_lang_Object_, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_onMalformedURLException_Ljava_net_MalformedURLException_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnMalformedURLException_Ljava_net_MalformedURLException_Ljava_lang_Object_Handler ()
			{
				if (cb_onMalformedURLException_Ljava_net_MalformedURLException_Ljava_lang_Object_ == null)
					cb_onMalformedURLException_Ljava_net_MalformedURLException_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnMalformedURLException_Ljava_net_MalformedURLException_Ljava_lang_Object_);
				return cb_onMalformedURLException_Ljava_net_MalformedURLException_Ljava_lang_Object_;
			}

			static void n_OnMalformedURLException_Ljava_net_MalformedURLException_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Net.MalformedURLException p0 = global::Java.Lang.Object.GetObject<global::Java.Net.MalformedURLException> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnMalformedURLException (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onMalformedURLException_Ljava_net_MalformedURLException_Ljava_lang_Object_;
			public void OnMalformedURLException (global::Java.Net.MalformedURLException p0, global::Java.Lang.Object p1)
			{
				if (id_onMalformedURLException_Ljava_net_MalformedURLException_Ljava_lang_Object_ == IntPtr.Zero)
					id_onMalformedURLException_Ljava_net_MalformedURLException_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onMalformedURLException", "(Ljava/net/MalformedURLException;Ljava/lang/Object;)V");
				JNIEnv.CallVoidMethod (Handle, id_onMalformedURLException_Ljava_net_MalformedURLException_Ljava_lang_Object_, new JValue (p0), new JValue (p1));
			}

		}

		public partial class CompleteEventArgs : global::System.EventArgs {

			public CompleteEventArgs (string p0, global::Java.Lang.Object p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}

			global::Java.Lang.Object p1;
			public global::Java.Lang.Object P1 {
				get { return p1; }
			}
		}

		public partial class FacebookErrorEventArgs : global::System.EventArgs {

			public FacebookErrorEventArgs (global::Xamarin.FacebookBinding.XAndroid.FacebookError p0, global::Java.Lang.Object p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Xamarin.FacebookBinding.XAndroid.FacebookError p0;
			public global::Xamarin.FacebookBinding.XAndroid.FacebookError P0 {
				get { return p0; }
			}

			global::Java.Lang.Object p1;
			public global::Java.Lang.Object P1 {
				get { return p1; }
			}
		}

		public partial class FileNotFoundExceptionEventArgs : global::System.EventArgs {

			public FileNotFoundExceptionEventArgs (global::Java.IO.FileNotFoundException p0, global::Java.Lang.Object p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Java.IO.FileNotFoundException p0;
			public global::Java.IO.FileNotFoundException P0 {
				get { return p0; }
			}

			global::Java.Lang.Object p1;
			public global::Java.Lang.Object P1 {
				get { return p1; }
			}
		}

		public partial class IOExceptionEventArgs : global::System.EventArgs {

			public IOExceptionEventArgs (global::Java.IO.IOException p0, global::Java.Lang.Object p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Java.IO.IOException p0;
			public global::Java.IO.IOException P0 {
				get { return p0; }
			}

			global::Java.Lang.Object p1;
			public global::Java.Lang.Object P1 {
				get { return p1; }
			}
		}

		public partial class MalformedURLExceptionEventArgs : global::System.EventArgs {

			public MalformedURLExceptionEventArgs (global::Java.Net.MalformedURLException p0, global::Java.Lang.Object p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Java.Net.MalformedURLException p0;
			public global::Java.Net.MalformedURLException P0 {
				get { return p0; }
			}

			global::Java.Lang.Object p1;
			public global::Java.Lang.Object P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/facebook/android/AsyncFacebookRunner_RequestListenerImplementor")]
		internal sealed class IRequestListenerImplementor : global::Java.Lang.Object, IRequestListener {

			object sender;

			public IRequestListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/facebook/android/AsyncFacebookRunner_RequestListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CompleteEventArgs> OnCompleteHandler;
#pragma warning restore 0649

			public void OnComplete (string p0, global::Java.Lang.Object p1)
			{
				var __h = OnCompleteHandler;
				if (__h != null)
					__h (sender, new CompleteEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<FacebookErrorEventArgs> OnFacebookErrorHandler;
#pragma warning restore 0649

			public void OnFacebookError (global::Xamarin.FacebookBinding.XAndroid.FacebookError p0, global::Java.Lang.Object p1)
			{
				var __h = OnFacebookErrorHandler;
				if (__h != null)
					__h (sender, new FacebookErrorEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<FileNotFoundExceptionEventArgs> OnFileNotFoundExceptionHandler;
#pragma warning restore 0649

			public void OnFileNotFoundException (global::Java.IO.FileNotFoundException p0, global::Java.Lang.Object p1)
			{
				var __h = OnFileNotFoundExceptionHandler;
				if (__h != null)
					__h (sender, new FileNotFoundExceptionEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<IOExceptionEventArgs> OnIOExceptionHandler;
#pragma warning restore 0649

			public void OnIOException (global::Java.IO.IOException p0, global::Java.Lang.Object p1)
			{
				var __h = OnIOExceptionHandler;
				if (__h != null)
					__h (sender, new IOExceptionEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<MalformedURLExceptionEventArgs> OnMalformedURLExceptionHandler;
#pragma warning restore 0649

			public void OnMalformedURLException (global::Java.Net.MalformedURLException p0, global::Java.Lang.Object p1)
			{
				var __h = OnMalformedURLExceptionHandler;
				if (__h != null)
					__h (sender, new MalformedURLExceptionEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IRequestListenerImplementor value)
			{
				return value.OnCompleteHandler == null && value.OnFacebookErrorHandler == null && value.OnFileNotFoundExceptionHandler == null && value.OnIOExceptionHandler == null && value.OnMalformedURLExceptionHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/android/AsyncFacebookRunner", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncFacebookRunner); }
		}

		protected AsyncFacebookRunner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_facebook_android_Facebook_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.android']/class[@name='AsyncFacebookRunner']/constructor[@name='AsyncFacebookRunner' and count(parameter)=1 and parameter[1][@type='com.facebook.android.Facebook']]"
		[Register (".ctor", "(Lcom/facebook/android/Facebook;)V", "")]
		public AsyncFacebookRunner (global::Xamarin.FacebookBinding.XAndroid.Facebook p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AsyncFacebookRunner)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/facebook/android/Facebook;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/facebook/android/Facebook;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_facebook_android_Facebook_ == IntPtr.Zero)
				id_ctor_Lcom_facebook_android_Facebook_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/android/Facebook;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_android_Facebook_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_facebook_android_Facebook_, new JValue (p0));
		}

		static Delegate cb_logout_Landroid_content_Context_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_;
#pragma warning disable 0169
		static Delegate GetLogout_Landroid_content_Context_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Handler ()
		{
			if (cb_logout_Landroid_content_Context_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_ == null)
				cb_logout_Landroid_content_Context_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Logout_Landroid_content_Context_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_);
			return cb_logout_Landroid_content_Context_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_;
		}

		static void n_Logout_Landroid_content_Context_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener p1 = (global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Logout (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_logout_Landroid_content_Context_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='AsyncFacebookRunner']/method[@name='logout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.facebook.android.AsyncFacebookRunner.RequestListener']]"
		[Register ("logout", "(Landroid/content/Context;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;)V", "GetLogout_Landroid_content_Context_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Handler")]
		public virtual void Logout (global::Android.Content.Context p0, global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener p1)
		{
			if (id_logout_Landroid_content_Context_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_ == IntPtr.Zero)
				id_logout_Landroid_content_Context_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_ = JNIEnv.GetMethodID (class_ref, "logout", "(Landroid/content/Context;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_logout_Landroid_content_Context_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logout", "(Landroid/content/Context;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_logout_Landroid_content_Context_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetLogout_Landroid_content_Context_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_Handler ()
		{
			if (cb_logout_Landroid_content_Context_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_ == null)
				cb_logout_Landroid_content_Context_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Logout_Landroid_content_Context_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_);
			return cb_logout_Landroid_content_Context_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_;
		}

		static void n_Logout_Landroid_content_Context_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener p1 = (global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Logout (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_logout_Landroid_content_Context_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='AsyncFacebookRunner']/method[@name='logout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.facebook.android.AsyncFacebookRunner.RequestListener'] and parameter[3][@type='java.lang.Object']]"
		[Register ("logout", "(Landroid/content/Context;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;Ljava/lang/Object;)V", "GetLogout_Landroid_content_Context_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_Handler")]
		public virtual void Logout (global::Android.Content.Context p0, global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener p1, global::Java.Lang.Object p2)
		{
			if (id_logout_Landroid_content_Context_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_ == IntPtr.Zero)
				id_logout_Landroid_content_Context_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "logout", "(Landroid/content/Context;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;Ljava/lang/Object;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_logout_Landroid_content_Context_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logout", "(Landroid/content/Context;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;Ljava/lang/Object;)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_request_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_;
#pragma warning disable 0169
		static Delegate GetRequest_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Handler ()
		{
			if (cb_request_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_ == null)
				cb_request_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Request_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_);
			return cb_request_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_;
		}

		static void n_Request_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener p1 = (global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Request (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_request_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='AsyncFacebookRunner']/method[@name='request' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.facebook.android.AsyncFacebookRunner.RequestListener']]"
		[Register ("request", "(Landroid/os/Bundle;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;)V", "GetRequest_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Handler")]
		public virtual void Request (global::Android.OS.Bundle p0, global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener p1)
		{
			if (id_request_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_ == IntPtr.Zero)
				id_request_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_ = JNIEnv.GetMethodID (class_ref, "request", "(Landroid/os/Bundle;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_request_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "request", "(Landroid/os/Bundle;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_request_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRequest_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_Handler ()
		{
			if (cb_request_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_ == null)
				cb_request_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Request_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_);
			return cb_request_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_;
		}

		static void n_Request_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener p1 = (global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Request (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_request_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='AsyncFacebookRunner']/method[@name='request' and count(parameter)=3 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.facebook.android.AsyncFacebookRunner.RequestListener'] and parameter[3][@type='java.lang.Object']]"
		[Register ("request", "(Landroid/os/Bundle;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;Ljava/lang/Object;)V", "GetRequest_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_Handler")]
		public virtual void Request (global::Android.OS.Bundle p0, global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener p1, global::Java.Lang.Object p2)
		{
			if (id_request_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_ == IntPtr.Zero)
				id_request_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "request", "(Landroid/os/Bundle;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;Ljava/lang/Object;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_request_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "request", "(Landroid/os/Bundle;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;Ljava/lang/Object;)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_request_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_;
#pragma warning disable 0169
		static Delegate GetRequest_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Handler ()
		{
			if (cb_request_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_ == null)
				cb_request_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Request_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_);
			return cb_request_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_;
		}

		static void n_Request_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener p2 = (global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Request (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_request_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='AsyncFacebookRunner']/method[@name='request' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.facebook.android.AsyncFacebookRunner.RequestListener']]"
		[Register ("request", "(Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;)V", "GetRequest_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Handler")]
		public virtual void Request (string p0, global::Android.OS.Bundle p1, global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener p2)
		{
			if (id_request_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_ == IntPtr.Zero)
				id_request_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_ = JNIEnv.GetMethodID (class_ref, "request", "(Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_request_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "request", "(Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;)V"), new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_request_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRequest_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_Handler ()
		{
			if (cb_request_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_ == null)
				cb_request_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Request_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_);
			return cb_request_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_;
		}

		static void n_Request_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener p2 = (global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Request (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_request_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='AsyncFacebookRunner']/method[@name='request' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.facebook.android.AsyncFacebookRunner.RequestListener'] and parameter[4][@type='java.lang.Object']]"
		[Register ("request", "(Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;Ljava/lang/Object;)V", "GetRequest_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_Handler")]
		public virtual void Request (string p0, global::Android.OS.Bundle p1, global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener p2, global::Java.Lang.Object p3)
		{
			if (id_request_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_ == IntPtr.Zero)
				id_request_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "request", "(Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_request_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "request", "(Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;Ljava/lang/Object;)V"), new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRequest_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_Handler ()
		{
			if (cb_request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_ == null)
				cb_request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_);
			return cb_request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_;
		}

		static void n_Request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener p3 = (global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Request (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='AsyncFacebookRunner']/method[@name='request' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.facebook.android.AsyncFacebookRunner.RequestListener'] and parameter[5][@type='java.lang.Object']]"
		[Register ("request", "(Ljava/lang/String;Landroid/os/Bundle;Ljava/lang/String;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;Ljava/lang/Object;)V", "GetRequest_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_Handler")]
		public virtual void Request (string p0, global::Android.OS.Bundle p1, string p2, global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener p3, global::Java.Lang.Object p4)
		{
			if (id_request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_ == IntPtr.Zero)
				id_request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "request", "(Ljava/lang/String;Landroid/os/Bundle;Ljava/lang/String;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_request_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (p3), new JValue (p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "request", "(Ljava/lang/String;Landroid/os/Bundle;Ljava/lang/String;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;Ljava/lang/Object;)V"), new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_request_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_;
#pragma warning disable 0169
		static Delegate GetRequest_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Handler ()
		{
			if (cb_request_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_ == null)
				cb_request_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Request_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_);
			return cb_request_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_;
		}

		static void n_Request_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener p1 = (global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Request (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_request_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='AsyncFacebookRunner']/method[@name='request' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.facebook.android.AsyncFacebookRunner.RequestListener']]"
		[Register ("request", "(Ljava/lang/String;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;)V", "GetRequest_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Handler")]
		public virtual void Request (string p0, global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener p1)
		{
			if (id_request_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_ == IntPtr.Zero)
				id_request_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_ = JNIEnv.GetMethodID (class_ref, "request", "(Ljava/lang/String;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_request_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "request", "(Ljava/lang/String;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_request_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRequest_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_Handler ()
		{
			if (cb_request_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_ == null)
				cb_request_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Request_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_);
			return cb_request_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_;
		}

		static void n_Request_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener p1 = (global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Request (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_request_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.android']/class[@name='AsyncFacebookRunner']/method[@name='request' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.facebook.android.AsyncFacebookRunner.RequestListener'] and parameter[3][@type='java.lang.Object']]"
		[Register ("request", "(Ljava/lang/String;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;Ljava/lang/Object;)V", "GetRequest_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_Handler")]
		public virtual void Request (string p0, global::Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner.IRequestListener p1, global::Java.Lang.Object p2)
		{
			if (id_request_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_ == IntPtr.Zero)
				id_request_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "request", "(Ljava/lang/String;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_request_Ljava_lang_String_Lcom_facebook_android_AsyncFacebookRunner_RequestListener_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "request", "(Ljava/lang/String;Lcom/facebook/android/AsyncFacebookRunner$RequestListener;Ljava/lang/Object;)V"), new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
