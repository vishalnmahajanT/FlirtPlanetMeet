using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='LegacyHelper']"
	[global::Android.Runtime.Register ("com/facebook/LegacyHelper", DoNotGenerateAcw=true)]
	public partial class LegacyHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/LegacyHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LegacyHelper); }
		}

		protected LegacyHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='LegacyHelper']/constructor[@name='LegacyHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public LegacyHelper () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LegacyHelper)) {
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

		static IntPtr id_extendTokenCompleted_Lcom_facebook_Session_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='LegacyHelper']/method[@name='extendTokenCompleted' and count(parameter)=2 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("extendTokenCompleted", "(Lcom/facebook/Session;Landroid/os/Bundle;)V", "")]
		public static void ExtendTokenCompleted (global::Xamarin.FacebookBinding.Session p0, global::Android.OS.Bundle p1)
		{
			if (id_extendTokenCompleted_Lcom_facebook_Session_Landroid_os_Bundle_ == IntPtr.Zero)
				id_extendTokenCompleted_Lcom_facebook_Session_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "extendTokenCompleted", "(Lcom/facebook/Session;Landroid/os/Bundle;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_extendTokenCompleted_Lcom_facebook_Session_Landroid_os_Bundle_, new JValue (p0), new JValue (p1));
		}

	}
}
