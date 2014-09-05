using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.internal']/class[@name='Logger']"
	[global::Android.Runtime.Register ("com/facebook/internal/Logger", DoNotGenerateAcw=true)]
	public partial class Logger : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.internal']/class[@name='Logger']/field[@name='LOG_TAG_BASE']"
		[Register ("LOG_TAG_BASE")]
		public const string LogTagBase = (string) "FacebookSDK.";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/internal/Logger", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Logger); }
		}

		protected Logger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_facebook_LoggingBehavior_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.internal']/class[@name='Logger']/constructor[@name='Logger' and count(parameter)=2 and parameter[1][@type='com.facebook.LoggingBehavior'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/facebook/LoggingBehavior;Ljava/lang/String;)V", "")]
		public Logger (global::Xamarin.FacebookBinding.LoggingBehavior p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (Logger)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/facebook/LoggingBehavior;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/facebook/LoggingBehavior;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Lcom_facebook_LoggingBehavior_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Lcom_facebook_LoggingBehavior_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/LoggingBehavior;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_LoggingBehavior_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_facebook_LoggingBehavior_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getContents;
#pragma warning disable 0169
		static Delegate GetGetContentsHandler ()
		{
			if (cb_getContents == null)
				cb_getContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContents);
			return cb_getContents;
		}

		static IntPtr n_GetContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Internal.Logger __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Internal.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Contents);
		}
#pragma warning restore 0169

		static IntPtr id_getContents;
		public virtual string Contents {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Logger']/method[@name='getContents' and count(parameter)=0]"
			[Register ("getContents", "()Ljava/lang/String;", "GetGetContentsHandler")]
			get {
				if (id_getContents == IntPtr.Zero)
					id_getContents = JNIEnv.GetMethodID (class_ref, "getContents", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getContents), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContents", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPriority;
#pragma warning disable 0169
		static Delegate GetGetPriorityHandler ()
		{
			if (cb_getPriority == null)
				cb_getPriority = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPriority);
			return cb_getPriority;
		}

		static int n_GetPriority (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Internal.Logger __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Internal.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Priority;
		}
#pragma warning restore 0169

		static Delegate cb_setPriority_I;
#pragma warning disable 0169
		static Delegate GetSetPriority_IHandler ()
		{
			if (cb_setPriority_I == null)
				cb_setPriority_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPriority_I);
			return cb_setPriority_I;
		}

		static void n_SetPriority_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Xamarin.FacebookBinding.Internal.Logger __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Internal.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Priority = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPriority;
		static IntPtr id_setPriority_I;
		public virtual int Priority {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Logger']/method[@name='getPriority' and count(parameter)=0]"
			[Register ("getPriority", "()I", "GetGetPriorityHandler")]
			get {
				if (id_getPriority == IntPtr.Zero)
					id_getPriority = JNIEnv.GetMethodID (class_ref, "getPriority", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getPriority);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPriority", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Logger']/method[@name='setPriority' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPriority", "(I)V", "GetSetPriority_IHandler")]
			set {
				if (id_setPriority_I == IntPtr.Zero)
					id_setPriority_I = JNIEnv.GetMethodID (class_ref, "setPriority", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPriority_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPriority", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_append_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_Handler ()
		{
			if (cb_append_Ljava_lang_String_ == null)
				cb_append_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Append_Ljava_lang_String_);
			return cb_append_Ljava_lang_String_;
		}

		static void n_Append_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Internal.Logger __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Internal.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Append (p0);
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Logger']/method[@name='append' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("append", "(Ljava/lang/String;)V", "GetAppend_Ljava_lang_String_Handler")]
		public virtual void Append (string p0)
		{
			if (id_append_Ljava_lang_String_ == IntPtr.Zero)
				id_append_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_append_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_append_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_append_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_append_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Append_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_append_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Append_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Xamarin.FacebookBinding.Internal.Logger __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Internal.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Append (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Logger']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("append", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetAppend_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual void Append (string p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_append_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_append_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_append_Ljava_lang_String_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;[Ljava/lang/Object;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_append_Ljava_lang_StringBuilder_;
#pragma warning disable 0169
		static Delegate GetAppend_Ljava_lang_StringBuilder_Handler ()
		{
			if (cb_append_Ljava_lang_StringBuilder_ == null)
				cb_append_Ljava_lang_StringBuilder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Append_Ljava_lang_StringBuilder_);
			return cb_append_Ljava_lang_StringBuilder_;
		}

		static void n_Append_Ljava_lang_StringBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Internal.Logger __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Internal.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.StringBuilder p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Append (p0);
		}
#pragma warning restore 0169

		static IntPtr id_append_Ljava_lang_StringBuilder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Logger']/method[@name='append' and count(parameter)=1 and parameter[1][@type='java.lang.StringBuilder']]"
		[Register ("append", "(Ljava/lang/StringBuilder;)V", "GetAppend_Ljava_lang_StringBuilder_Handler")]
		public virtual void Append (global::Java.Lang.StringBuilder p0)
		{
			if (id_append_Ljava_lang_StringBuilder_ == IntPtr.Zero)
				id_append_Ljava_lang_StringBuilder_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/StringBuilder;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_append_Ljava_lang_StringBuilder_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/StringBuilder;)V"), new JValue (p0));
		}

		static Delegate cb_appendKeyValue_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAppendKeyValue_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_appendKeyValue_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_appendKeyValue_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AppendKeyValue_Ljava_lang_String_Ljava_lang_Object_);
			return cb_appendKeyValue_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_AppendKeyValue_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Xamarin.FacebookBinding.Internal.Logger __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Internal.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AppendKeyValue (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_appendKeyValue_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Logger']/method[@name='appendKeyValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("appendKeyValue", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetAppendKeyValue_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual void AppendKeyValue (string p0, global::Java.Lang.Object p1)
		{
			if (id_appendKeyValue_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_appendKeyValue_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "appendKeyValue", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_appendKeyValue_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendKeyValue", "(Ljava/lang/String;Ljava/lang/Object;)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_log;
#pragma warning disable 0169
		static Delegate GetLogHandler ()
		{
			if (cb_log == null)
				cb_log = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Log);
			return cb_log;
		}

		static void n_Log (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Internal.Logger __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Internal.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Log ();
		}
#pragma warning restore 0169

		static IntPtr id_log;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Logger']/method[@name='log' and count(parameter)=0]"
		[Register ("log", "()V", "GetLogHandler")]
		public virtual void Log ()
		{
			if (id_log == IntPtr.Zero)
				id_log = JNIEnv.GetMethodID (class_ref, "log", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_log);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "log", "()V"));
		}

		static IntPtr id_log_Lcom_facebook_LoggingBehavior_ILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Logger']/method[@name='log' and count(parameter)=4 and parameter[1][@type='com.facebook.LoggingBehavior'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("log", "(Lcom/facebook/LoggingBehavior;ILjava/lang/String;Ljava/lang/String;)V", "")]
		public static void Log (global::Xamarin.FacebookBinding.LoggingBehavior p0, int p1, string p2, string p3)
		{
			if (id_log_Lcom_facebook_LoggingBehavior_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_log_Lcom_facebook_LoggingBehavior_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "log", "(Lcom/facebook/LoggingBehavior;ILjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_log_Lcom_facebook_LoggingBehavior_ILjava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static IntPtr id_log_Lcom_facebook_LoggingBehavior_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Logger']/method[@name='log' and count(parameter)=3 and parameter[1][@type='com.facebook.LoggingBehavior'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("log", "(Lcom/facebook/LoggingBehavior;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void Log (global::Xamarin.FacebookBinding.LoggingBehavior p0, string p1, string p2)
		{
			if (id_log_Lcom_facebook_LoggingBehavior_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_log_Lcom_facebook_LoggingBehavior_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "log", "(Lcom/facebook/LoggingBehavior;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_log_Lcom_facebook_LoggingBehavior_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_log_Lcom_facebook_LoggingBehavior_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Logger']/method[@name='log' and count(parameter)=4 and parameter[1][@type='com.facebook.LoggingBehavior'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("log", "(Lcom/facebook/LoggingBehavior;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static void Log (global::Xamarin.FacebookBinding.LoggingBehavior p0, string p1, string p2, params global:: Java.Lang.Object[] p3)
		{
			if (id_log_Lcom_facebook_LoggingBehavior_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_log_Lcom_facebook_LoggingBehavior_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "log", "(Lcom/facebook/LoggingBehavior;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_log_Lcom_facebook_LoggingBehavior_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_logString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLogString_Ljava_lang_String_Handler ()
		{
			if (cb_logString_Ljava_lang_String_ == null)
				cb_logString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LogString_Ljava_lang_String_);
			return cb_logString_Ljava_lang_String_;
		}

		static void n_LogString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Internal.Logger __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Internal.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LogString (p0);
		}
#pragma warning restore 0169

		static IntPtr id_logString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Logger']/method[@name='logString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("logString", "(Ljava/lang/String;)V", "GetLogString_Ljava_lang_String_Handler")]
		public virtual void LogString (string p0)
		{
			if (id_logString_Ljava_lang_String_ == IntPtr.Zero)
				id_logString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "logString", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_logString_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logString", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_registerAccessToken_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Logger']/method[@name='registerAccessToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("registerAccessToken", "(Ljava/lang/String;)V", "")]
		public static void RegisterAccessToken (string p0)
		{
			if (id_registerAccessToken_Ljava_lang_String_ == IntPtr.Zero)
				id_registerAccessToken_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "registerAccessToken", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_registerAccessToken_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_registerStringToReplace_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Logger']/method[@name='registerStringToReplace' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("registerStringToReplace", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void RegisterStringToReplace (string p0, string p1)
		{
			if (id_registerStringToReplace_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_registerStringToReplace_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "registerStringToReplace", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_registerStringToReplace_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
