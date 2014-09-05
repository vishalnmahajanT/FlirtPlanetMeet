using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding.XAndroid {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.android']/class[@name='FbDialog']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/facebook/android/FbDialog", DoNotGenerateAcw=true)]
	public partial class FbDialog : global::Xamarin.FacebookBinding.Widget.WebDialog {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/android/FbDialog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FbDialog); }
		}

		protected FbDialog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_android_Facebook_DialogListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.android']/class[@name='FbDialog']/constructor[@name='FbDialog' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.facebook.android.Facebook.DialogListener']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Lcom/facebook/android/Facebook$DialogListener;)V", "")]
		public FbDialog (global::Android.Content.Context p0, string p1, global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (FbDialog)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Lcom/facebook/android/Facebook$DialogListener;)V", new JValue (p0), new JValue (native_p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;Lcom/facebook/android/Facebook$DialogListener;)V", new JValue (p0), new JValue (native_p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_android_Facebook_DialogListener_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_android_Facebook_DialogListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Lcom/facebook/android/Facebook$DialogListener;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_android_Facebook_DialogListener_, new JValue (p0), new JValue (native_p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_android_Facebook_DialogListener_, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_android_Facebook_DialogListener_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.android']/class[@name='FbDialog']/constructor[@name='FbDialog' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.facebook.android.Facebook.DialogListener'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Lcom/facebook/android/Facebook$DialogListener;I)V", "")]
		public FbDialog (global::Android.Content.Context p0, string p1, global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener p2, int p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (FbDialog)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Lcom/facebook/android/Facebook$DialogListener;I)V", new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;Lcom/facebook/android/Facebook$DialogListener;I)V", new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_android_Facebook_DialogListener_I == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_android_Facebook_DialogListener_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Lcom/facebook/android/Facebook$DialogListener;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_android_Facebook_DialogListener_I, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_android_Facebook_DialogListener_I, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_Facebook_DialogListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.android']/class[@name='FbDialog']/constructor[@name='FbDialog' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='com.facebook.android.Facebook.DialogListener']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/android/Facebook$DialogListener;)V", "")]
		public FbDialog (global::Android.Content.Context p0, string p1, global::Android.OS.Bundle p2, global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (FbDialog)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/android/Facebook$DialogListener;)V", new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/android/Facebook$DialogListener;)V", new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_Facebook_DialogListener_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_Facebook_DialogListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/android/Facebook$DialogListener;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_Facebook_DialogListener_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_Facebook_DialogListener_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_Facebook_DialogListener_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.android']/class[@name='FbDialog']/constructor[@name='FbDialog' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='com.facebook.android.Facebook.DialogListener'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/android/Facebook$DialogListener;I)V", "")]
		public FbDialog (global::Android.Content.Context p0, string p1, global::Android.OS.Bundle p2, global::Xamarin.FacebookBinding.XAndroid.Facebook.IDialogListener p3, int p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (FbDialog)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/android/Facebook$DialogListener;I)V", new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/android/Facebook$DialogListener;I)V", new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_Facebook_DialogListener_I == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_Facebook_DialogListener_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/android/Facebook$DialogListener;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_Facebook_DialogListener_I, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_android_Facebook_DialogListener_I, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
