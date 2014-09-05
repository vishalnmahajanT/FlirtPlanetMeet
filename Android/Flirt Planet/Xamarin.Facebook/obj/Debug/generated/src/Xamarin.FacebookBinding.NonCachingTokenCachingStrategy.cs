using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='NonCachingTokenCachingStrategy']"
	[global::Android.Runtime.Register ("com/facebook/NonCachingTokenCachingStrategy", DoNotGenerateAcw=true)]
	public partial class NonCachingTokenCachingStrategy : global::Xamarin.FacebookBinding.TokenCachingStrategy {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/NonCachingTokenCachingStrategy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NonCachingTokenCachingStrategy); }
		}

		protected NonCachingTokenCachingStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='NonCachingTokenCachingStrategy']/constructor[@name='NonCachingTokenCachingStrategy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public NonCachingTokenCachingStrategy () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (NonCachingTokenCachingStrategy)) {
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
			global::Xamarin.FacebookBinding.NonCachingTokenCachingStrategy __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.NonCachingTokenCachingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='NonCachingTokenCachingStrategy']/method[@name='clear' and count(parameter)=0]"
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
			global::Xamarin.FacebookBinding.NonCachingTokenCachingStrategy __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.NonCachingTokenCachingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Load ());
		}
#pragma warning restore 0169

		static IntPtr id_load;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='NonCachingTokenCachingStrategy']/method[@name='load' and count(parameter)=0]"
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
			global::Xamarin.FacebookBinding.NonCachingTokenCachingStrategy __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.NonCachingTokenCachingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Save (p0);
		}
#pragma warning restore 0169

		static IntPtr id_save_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='NonCachingTokenCachingStrategy']/method[@name='save' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
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
}
