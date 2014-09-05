using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='InsightsLogger']"
	[global::Android.Runtime.Register ("com/facebook/InsightsLogger", DoNotGenerateAcw=true)]
	public partial class InsightsLogger : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/InsightsLogger", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InsightsLogger); }
		}

		protected InsightsLogger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_logConversionPixel_Ljava_lang_String_D;
#pragma warning disable 0169
		static Delegate GetLogConversionPixel_Ljava_lang_String_DHandler ()
		{
			if (cb_logConversionPixel_Ljava_lang_String_D == null)
				cb_logConversionPixel_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, double>) n_LogConversionPixel_Ljava_lang_String_D);
			return cb_logConversionPixel_Ljava_lang_String_D;
		}

		static void n_LogConversionPixel_Ljava_lang_String_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
		{
			global::Xamarin.FacebookBinding.InsightsLogger __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.InsightsLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LogConversionPixel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_logConversionPixel_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='InsightsLogger']/method[@name='logConversionPixel' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
		[Register ("logConversionPixel", "(Ljava/lang/String;D)V", "GetLogConversionPixel_Ljava_lang_String_DHandler")]
		public virtual void LogConversionPixel (string p0, double p1)
		{
			if (id_logConversionPixel_Ljava_lang_String_D == IntPtr.Zero)
				id_logConversionPixel_Ljava_lang_String_D = JNIEnv.GetMethodID (class_ref, "logConversionPixel", "(Ljava/lang/String;D)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_logConversionPixel_Ljava_lang_String_D, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logConversionPixel", "(Ljava/lang/String;D)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_logPurchase_Ljava_math_BigDecimal_Ljava_util_Currency_;
#pragma warning disable 0169
		static Delegate GetLogPurchase_Ljava_math_BigDecimal_Ljava_util_Currency_Handler ()
		{
			if (cb_logPurchase_Ljava_math_BigDecimal_Ljava_util_Currency_ == null)
				cb_logPurchase_Ljava_math_BigDecimal_Ljava_util_Currency_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_LogPurchase_Ljava_math_BigDecimal_Ljava_util_Currency_);
			return cb_logPurchase_Ljava_math_BigDecimal_Ljava_util_Currency_;
		}

		static void n_LogPurchase_Ljava_math_BigDecimal_Ljava_util_Currency_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Xamarin.FacebookBinding.InsightsLogger __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.InsightsLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Math.BigDecimal p0 = global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Currency p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Currency> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.LogPurchase (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_logPurchase_Ljava_math_BigDecimal_Ljava_util_Currency_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='InsightsLogger']/method[@name='logPurchase' and count(parameter)=2 and parameter[1][@type='java.math.BigDecimal'] and parameter[2][@type='java.util.Currency']]"
		[Register ("logPurchase", "(Ljava/math/BigDecimal;Ljava/util/Currency;)V", "GetLogPurchase_Ljava_math_BigDecimal_Ljava_util_Currency_Handler")]
		public virtual void LogPurchase (global::Java.Math.BigDecimal p0, global::Java.Util.Currency p1)
		{
			if (id_logPurchase_Ljava_math_BigDecimal_Ljava_util_Currency_ == IntPtr.Zero)
				id_logPurchase_Ljava_math_BigDecimal_Ljava_util_Currency_ = JNIEnv.GetMethodID (class_ref, "logPurchase", "(Ljava/math/BigDecimal;Ljava/util/Currency;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_logPurchase_Ljava_math_BigDecimal_Ljava_util_Currency_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logPurchase", "(Ljava/math/BigDecimal;Ljava/util/Currency;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_logPurchase_Ljava_math_BigDecimal_Ljava_util_Currency_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetLogPurchase_Ljava_math_BigDecimal_Ljava_util_Currency_Landroid_os_Bundle_Handler ()
		{
			if (cb_logPurchase_Ljava_math_BigDecimal_Ljava_util_Currency_Landroid_os_Bundle_ == null)
				cb_logPurchase_Ljava_math_BigDecimal_Ljava_util_Currency_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LogPurchase_Ljava_math_BigDecimal_Ljava_util_Currency_Landroid_os_Bundle_);
			return cb_logPurchase_Ljava_math_BigDecimal_Ljava_util_Currency_Landroid_os_Bundle_;
		}

		static void n_LogPurchase_Ljava_math_BigDecimal_Ljava_util_Currency_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Xamarin.FacebookBinding.InsightsLogger __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.InsightsLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Math.BigDecimal p0 = global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Currency p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Currency> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.LogPurchase (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_logPurchase_Ljava_math_BigDecimal_Ljava_util_Currency_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='InsightsLogger']/method[@name='logPurchase' and count(parameter)=3 and parameter[1][@type='java.math.BigDecimal'] and parameter[2][@type='java.util.Currency'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("logPurchase", "(Ljava/math/BigDecimal;Ljava/util/Currency;Landroid/os/Bundle;)V", "GetLogPurchase_Ljava_math_BigDecimal_Ljava_util_Currency_Landroid_os_Bundle_Handler")]
		public virtual void LogPurchase (global::Java.Math.BigDecimal p0, global::Java.Util.Currency p1, global::Android.OS.Bundle p2)
		{
			if (id_logPurchase_Ljava_math_BigDecimal_Ljava_util_Currency_Landroid_os_Bundle_ == IntPtr.Zero)
				id_logPurchase_Ljava_math_BigDecimal_Ljava_util_Currency_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "logPurchase", "(Ljava/math/BigDecimal;Ljava/util/Currency;Landroid/os/Bundle;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_logPurchase_Ljava_math_BigDecimal_Ljava_util_Currency_Landroid_os_Bundle_, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logPurchase", "(Ljava/math/BigDecimal;Ljava/util/Currency;Landroid/os/Bundle;)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_newLogger_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='InsightsLogger']/method[@name='newLogger' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("newLogger", "(Landroid/content/Context;Ljava/lang/String;)Lcom/facebook/InsightsLogger;", "")]
		public static global::Xamarin.FacebookBinding.InsightsLogger NewLogger (global::Android.Content.Context p0, string p1)
		{
			if (id_newLogger_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_newLogger_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "newLogger", "(Landroid/content/Context;Ljava/lang/String;)Lcom/facebook/InsightsLogger;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Xamarin.FacebookBinding.InsightsLogger __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.InsightsLogger> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newLogger_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_newLogger_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='InsightsLogger']/method[@name='newLogger' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("newLogger", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Lcom/facebook/InsightsLogger;", "")]
		public static global::Xamarin.FacebookBinding.InsightsLogger NewLogger (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_newLogger_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_newLogger_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "newLogger", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Lcom/facebook/InsightsLogger;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			global::Xamarin.FacebookBinding.InsightsLogger __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.InsightsLogger> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newLogger_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static IntPtr id_newLogger_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_facebook_Session_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='InsightsLogger']/method[@name='newLogger' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.facebook.Session']]"
		[Register ("newLogger", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/facebook/Session;)Lcom/facebook/InsightsLogger;", "")]
		public static global::Xamarin.FacebookBinding.InsightsLogger NewLogger (global::Android.Content.Context p0, string p1, string p2, global::Xamarin.FacebookBinding.Session p3)
		{
			if (id_newLogger_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_facebook_Session_ == IntPtr.Zero)
				id_newLogger_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_facebook_Session_ = JNIEnv.GetStaticMethodID (class_ref, "newLogger", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/facebook/Session;)Lcom/facebook/InsightsLogger;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			global::Xamarin.FacebookBinding.InsightsLogger __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.InsightsLogger> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newLogger_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_facebook_Session_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

	}
}
