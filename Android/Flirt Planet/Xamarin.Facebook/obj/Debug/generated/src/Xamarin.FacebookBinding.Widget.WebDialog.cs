using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog']"
	[global::Android.Runtime.Register ("com/facebook/widget/WebDialog", DoNotGenerateAcw=true)]
	public partial class WebDialog : global::Android.App.Dialog {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog']/field[@name='DEFAULT_THEME']"
		[Register ("DEFAULT_THEME")]
		public const int DefaultTheme = (int) 16973840;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.Builder']"
		[global::Android.Runtime.Register ("com/facebook/widget/WebDialog$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Xamarin.FacebookBinding.Widget.WebDialog.BuilderBase {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/widget/WebDialog$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.Builder']/constructor[@name='WebDialog.Builder' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.facebook.Session'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle']]"
			[Register (".ctor", "(Landroid/content/Context;Lcom/facebook/Session;Ljava/lang/String;Landroid/os/Bundle;)V", "")]
			public Builder (global::Android.Content.Context p0, global::Xamarin.FacebookBinding.Session p1, string p2, global::Android.OS.Bundle p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p2 = JNIEnv.NewString (p2);;
				if (GetType () != typeof (Builder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/facebook/Session;Ljava/lang/String;Landroid/os/Bundle;)V", new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/facebook/Session;Ljava/lang/String;Landroid/os/Bundle;)V", new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
					JNIEnv.DeleteLocalRef (native_p2);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/facebook/Session;Ljava/lang/String;Landroid/os/Bundle;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p2);
			}

			static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.Builder']/constructor[@name='WebDialog.Builder' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle']]"
			[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)V", "")]
			public Builder (global::Android.Content.Context p0, string p1, string p2, global::Android.OS.Bundle p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);;
				IntPtr native_p2 = JNIEnv.NewString (p2);;
				if (GetType () != typeof (Builder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3));
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.Widget.WebDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/facebook/widget/WebDialog;", "GetBuildHandler")]
			public override global::Xamarin.FacebookBinding.Widget.WebDialog Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/facebook/widget/WebDialog;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/facebook/widget/WebDialog;")), JniHandleOwnership.TransferLocalRef);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.BuilderBase']"
		[global::Android.Runtime.Register ("com/facebook/widget/WebDialog$BuilderBase", DoNotGenerateAcw=true)]
		public partial class BuilderBase : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/widget/WebDialog$BuilderBase", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BuilderBase); }
			}

			protected BuilderBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.BuilderBase']/constructor[@name='WebDialog.BuilderBase' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle']]"
			[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)V", "")]
			protected BuilderBase (global::Android.Content.Context p0, string p1, string p2, global::Android.OS.Bundle p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);;
				IntPtr native_p2 = JNIEnv.NewString (p2);;
				if (GetType () != typeof (BuilderBase)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3));
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}

			static IntPtr id_ctor_Landroid_content_Context_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.BuilderBase']/constructor[@name='WebDialog.BuilderBase' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.facebook.Session'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle']]"
			[Register (".ctor", "(Landroid/content/Context;Lcom/facebook/Session;Ljava/lang/String;Landroid/os/Bundle;)V", "")]
			protected BuilderBase (global::Android.Content.Context p0, global::Xamarin.FacebookBinding.Session p1, string p2, global::Android.OS.Bundle p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p2 = JNIEnv.NewString (p2);;
				if (GetType () != typeof (BuilderBase)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/facebook/Session;Ljava/lang/String;Landroid/os/Bundle;)V", new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/facebook/Session;Ljava/lang/String;Landroid/os/Bundle;)V", new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
					JNIEnv.DeleteLocalRef (native_p2);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/facebook/Session;Ljava/lang/String;Landroid/os/Bundle;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p2);
			}

			static Delegate cb_getApplicationId;
#pragma warning disable 0169
			static Delegate GetGetApplicationIdHandler ()
			{
				if (cb_getApplicationId == null)
					cb_getApplicationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationId);
				return cb_getApplicationId;
			}

			static IntPtr n_GetApplicationId (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.Widget.WebDialog.BuilderBase __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.BuilderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ApplicationId);
			}
#pragma warning restore 0169

			static IntPtr id_getApplicationId;
			protected virtual string ApplicationId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.BuilderBase']/method[@name='getApplicationId' and count(parameter)=0]"
				[Register ("getApplicationId", "()Ljava/lang/String;", "GetGetApplicationIdHandler")]
				get {
					if (id_getApplicationId == IntPtr.Zero)
						id_getApplicationId = JNIEnv.GetMethodID (class_ref, "getApplicationId", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getApplicationId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApplicationId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getContext;
#pragma warning disable 0169
			static Delegate GetGetContextHandler ()
			{
				if (cb_getContext == null)
					cb_getContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContext);
				return cb_getContext;
			}

			static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.Widget.WebDialog.BuilderBase __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.BuilderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Context);
			}
#pragma warning restore 0169

			static IntPtr id_getContext;
			protected virtual global::Android.Content.Context Context {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.BuilderBase']/method[@name='getContext' and count(parameter)=0]"
				[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
				get {
					if (id_getContext == IntPtr.Zero)
						id_getContext = JNIEnv.GetMethodID (class_ref, "getContext", "()Landroid/content/Context;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod  (Handle, id_getContext), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContext", "()Landroid/content/Context;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getListener;
#pragma warning disable 0169
			static Delegate GetGetListenerHandler ()
			{
				if (cb_getListener == null)
					cb_getListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetListener);
				return cb_getListener;
			}

			static IntPtr n_GetListener (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.Widget.WebDialog.BuilderBase __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.BuilderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Listener);
			}
#pragma warning restore 0169

			static IntPtr id_getListener;
			protected virtual global::Xamarin.FacebookBinding.Widget.WebDialog.IOnCompleteListener Listener {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.BuilderBase']/method[@name='getListener' and count(parameter)=0]"
				[Register ("getListener", "()Lcom/facebook/widget/WebDialog$OnCompleteListener;", "GetGetListenerHandler")]
				get {
					if (id_getListener == IntPtr.Zero)
						id_getListener = JNIEnv.GetMethodID (class_ref, "getListener", "()Lcom/facebook/widget/WebDialog$OnCompleteListener;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.IOnCompleteListener> (JNIEnv.CallObjectMethod  (Handle, id_getListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.IOnCompleteListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getListener", "()Lcom/facebook/widget/WebDialog$OnCompleteListener;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getParameters;
#pragma warning disable 0169
			static Delegate GetGetParametersHandler ()
			{
				if (cb_getParameters == null)
					cb_getParameters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParameters);
				return cb_getParameters;
			}

			static IntPtr n_GetParameters (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.Widget.WebDialog.BuilderBase __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.BuilderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Parameters);
			}
#pragma warning restore 0169

			static IntPtr id_getParameters;
			protected virtual global::Android.OS.Bundle Parameters {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.BuilderBase']/method[@name='getParameters' and count(parameter)=0]"
				[Register ("getParameters", "()Landroid/os/Bundle;", "GetGetParametersHandler")]
				get {
					if (id_getParameters == IntPtr.Zero)
						id_getParameters = JNIEnv.GetMethodID (class_ref, "getParameters", "()Landroid/os/Bundle;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_getParameters), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParameters", "()Landroid/os/Bundle;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getTheme;
#pragma warning disable 0169
			static Delegate GetGetThemeHandler ()
			{
				if (cb_getTheme == null)
					cb_getTheme = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTheme);
				return cb_getTheme;
			}

			static int n_GetTheme (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.Widget.WebDialog.BuilderBase __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.BuilderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Theme;
			}
#pragma warning restore 0169

			static IntPtr id_getTheme;
			protected virtual int Theme {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.BuilderBase']/method[@name='getTheme' and count(parameter)=0]"
				[Register ("getTheme", "()I", "GetGetThemeHandler")]
				get {
					if (id_getTheme == IntPtr.Zero)
						id_getTheme = JNIEnv.GetMethodID (class_ref, "getTheme", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getTheme);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTheme", "()I"));
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.Widget.WebDialog.BuilderBase __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.BuilderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.BuilderBase']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/facebook/widget/WebDialog;", "GetBuildHandler")]
			public virtual global::Xamarin.FacebookBinding.Widget.WebDialog Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/facebook/widget/WebDialog;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/facebook/widget/WebDialog;")), JniHandleOwnership.TransferLocalRef);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.DialogWebViewClient']"
		[global::Android.Runtime.Register ("com/facebook/widget/WebDialog$DialogWebViewClient", DoNotGenerateAcw=true)]
		public partial class DialogWebViewClient : global::Android.Webkit.WebViewClient {

			protected DialogWebViewClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.FeedDialogBuilder']"
		[global::Android.Runtime.Register ("com/facebook/widget/WebDialog$FeedDialogBuilder", DoNotGenerateAcw=true)]
		public partial class FeedDialogBuilder : global::Xamarin.FacebookBinding.Widget.WebDialog.BuilderBase {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/widget/WebDialog$FeedDialogBuilder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FeedDialogBuilder); }
			}

			protected FeedDialogBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_Lcom_facebook_Session_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.FeedDialogBuilder']/constructor[@name='WebDialog.FeedDialogBuilder' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.facebook.Session']]"
			[Register (".ctor", "(Landroid/content/Context;Lcom/facebook/Session;)V", "")]
			public FeedDialogBuilder (global::Android.Content.Context p0, global::Xamarin.FacebookBinding.Session p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (FeedDialogBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/facebook/Session;)V", new JValue (p0), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/facebook/Session;)V", new JValue (p0), new JValue (p1));
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_facebook_Session_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_facebook_Session_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/facebook/Session;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_facebook_Session_, new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_facebook_Session_, new JValue (p0), new JValue (p1));
			}

			static IntPtr id_ctor_Landroid_content_Context_Lcom_facebook_Session_Landroid_os_Bundle_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.FeedDialogBuilder']/constructor[@name='WebDialog.FeedDialogBuilder' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.facebook.Session'] and parameter[3][@type='android.os.Bundle']]"
			[Register (".ctor", "(Landroid/content/Context;Lcom/facebook/Session;Landroid/os/Bundle;)V", "")]
			public FeedDialogBuilder (global::Android.Content.Context p0, global::Xamarin.FacebookBinding.Session p1, global::Android.OS.Bundle p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (FeedDialogBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/facebook/Session;Landroid/os/Bundle;)V", new JValue (p0), new JValue (p1), new JValue (p2)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/facebook/Session;Landroid/os/Bundle;)V", new JValue (p0), new JValue (p1), new JValue (p2));
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_facebook_Session_Landroid_os_Bundle_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_facebook_Session_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/facebook/Session;Landroid/os/Bundle;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_facebook_Session_Landroid_os_Bundle_, new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_facebook_Session_Landroid_os_Bundle_, new JValue (p0), new JValue (p1), new JValue (p2));
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.FeedDialogBuilder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/facebook/widget/WebDialog;", "GetBuildHandler")]
			public override global::Xamarin.FacebookBinding.Widget.WebDialog Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/facebook/widget/WebDialog;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/facebook/widget/WebDialog;")), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_setCaption_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetCaption_Ljava_lang_String_Handler ()
			{
				if (cb_setCaption_Ljava_lang_String_ == null)
					cb_setCaption_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCaption_Ljava_lang_String_);
				return cb_setCaption_Ljava_lang_String_;
			}

			static IntPtr n_SetCaption_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCaption (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setCaption_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.FeedDialogBuilder']/method[@name='setCaption' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCaption", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$FeedDialogBuilder;", "GetSetCaption_Ljava_lang_String_Handler")]
			public virtual global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder SetCaption (string p0)
			{
				if (id_setCaption_Ljava_lang_String_ == IntPtr.Zero)
					id_setCaption_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCaption", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$FeedDialogBuilder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setCaption_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCaption", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$FeedDialogBuilder;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_setDescription_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetDescription_Ljava_lang_String_Handler ()
			{
				if (cb_setDescription_Ljava_lang_String_ == null)
					cb_setDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDescription_Ljava_lang_String_);
				return cb_setDescription_Ljava_lang_String_;
			}

			static IntPtr n_SetDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDescription (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setDescription_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.FeedDialogBuilder']/method[@name='setDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDescription", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$FeedDialogBuilder;", "GetSetDescription_Ljava_lang_String_Handler")]
			public virtual global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder SetDescription (string p0)
			{
				if (id_setDescription_Ljava_lang_String_ == IntPtr.Zero)
					id_setDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDescription", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$FeedDialogBuilder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setDescription_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDescription", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$FeedDialogBuilder;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_setFrom_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetFrom_Ljava_lang_String_Handler ()
			{
				if (cb_setFrom_Ljava_lang_String_ == null)
					cb_setFrom_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFrom_Ljava_lang_String_);
				return cb_setFrom_Ljava_lang_String_;
			}

			static IntPtr n_SetFrom_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFrom (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setFrom_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.FeedDialogBuilder']/method[@name='setFrom' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFrom", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$FeedDialogBuilder;", "GetSetFrom_Ljava_lang_String_Handler")]
			public virtual global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder SetFrom (string p0)
			{
				if (id_setFrom_Ljava_lang_String_ == IntPtr.Zero)
					id_setFrom_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFrom", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$FeedDialogBuilder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setFrom_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFrom", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$FeedDialogBuilder;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_setLink_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetLink_Ljava_lang_String_Handler ()
			{
				if (cb_setLink_Ljava_lang_String_ == null)
					cb_setLink_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLink_Ljava_lang_String_);
				return cb_setLink_Ljava_lang_String_;
			}

			static IntPtr n_SetLink_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetLink (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setLink_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.FeedDialogBuilder']/method[@name='setLink' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLink", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$FeedDialogBuilder;", "GetSetLink_Ljava_lang_String_Handler")]
			public virtual global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder SetLink (string p0)
			{
				if (id_setLink_Ljava_lang_String_ == IntPtr.Zero)
					id_setLink_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLink", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$FeedDialogBuilder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setLink_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLink", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$FeedDialogBuilder;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetName_Ljava_lang_String_Handler ()
			{
				if (cb_setName_Ljava_lang_String_ == null)
					cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
				return cb_setName_Ljava_lang_String_;
			}

			static IntPtr n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetName (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.FeedDialogBuilder']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$FeedDialogBuilder;", "GetSetName_Ljava_lang_String_Handler")]
			public virtual global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder SetName (string p0)
			{
				if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
					id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$FeedDialogBuilder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setName", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$FeedDialogBuilder;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_setPicture_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetPicture_Ljava_lang_String_Handler ()
			{
				if (cb_setPicture_Ljava_lang_String_ == null)
					cb_setPicture_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPicture_Ljava_lang_String_);
				return cb_setPicture_Ljava_lang_String_;
			}

			static IntPtr n_SetPicture_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPicture (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setPicture_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.FeedDialogBuilder']/method[@name='setPicture' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPicture", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$FeedDialogBuilder;", "GetSetPicture_Ljava_lang_String_Handler")]
			public virtual global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder SetPicture (string p0)
			{
				if (id_setPicture_Ljava_lang_String_ == IntPtr.Zero)
					id_setPicture_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPicture", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$FeedDialogBuilder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setPicture_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPicture", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$FeedDialogBuilder;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_setSource_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetSource_Ljava_lang_String_Handler ()
			{
				if (cb_setSource_Ljava_lang_String_ == null)
					cb_setSource_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetSource_Ljava_lang_String_);
				return cb_setSource_Ljava_lang_String_;
			}

			static IntPtr n_SetSource_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSource (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setSource_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.FeedDialogBuilder']/method[@name='setSource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSource", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$FeedDialogBuilder;", "GetSetSource_Ljava_lang_String_Handler")]
			public virtual global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder SetSource (string p0)
			{
				if (id_setSource_Ljava_lang_String_ == IntPtr.Zero)
					id_setSource_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSource", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$FeedDialogBuilder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setSource_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSource", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$FeedDialogBuilder;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_setTo_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTo_Ljava_lang_String_Handler ()
			{
				if (cb_setTo_Ljava_lang_String_ == null)
					cb_setTo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTo_Ljava_lang_String_);
				return cb_setTo_Ljava_lang_String_;
			}

			static IntPtr n_SetTo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTo (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setTo_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.FeedDialogBuilder']/method[@name='setTo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTo", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$FeedDialogBuilder;", "GetSetTo_Ljava_lang_String_Handler")]
			public virtual global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder SetTo (string p0)
			{
				if (id_setTo_Ljava_lang_String_ == IntPtr.Zero)
					id_setTo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTo", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$FeedDialogBuilder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setTo_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.FeedDialogBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTo", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$FeedDialogBuilder;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.widget']/interface[@name='WebDialog.OnCompleteListener']"
		[Register ("com/facebook/widget/WebDialog$OnCompleteListener", "", "Xamarin.FacebookBinding.Widget.WebDialog/IOnCompleteListenerInvoker")]
		public partial interface IOnCompleteListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/interface[@name='WebDialog.OnCompleteListener']/method[@name='onComplete' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.facebook.FacebookException']]"
			[Register ("onComplete", "(Landroid/os/Bundle;Lcom/facebook/FacebookException;)V", "GetOnComplete_Landroid_os_Bundle_Lcom_facebook_FacebookException_Handler:Xamarin.FacebookBinding.Widget.WebDialog/IOnCompleteListenerInvoker, Xamarin.Facebook")]
			void OnComplete (global::Android.OS.Bundle p0, global::Xamarin.FacebookBinding.FacebookException p1);

		}

		[global::Android.Runtime.Register ("com/facebook/widget/WebDialog$OnCompleteListener", DoNotGenerateAcw=true)]
		internal class IOnCompleteListenerInvoker : global::Java.Lang.Object, IOnCompleteListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/widget/WebDialog$OnCompleteListener");
			IntPtr class_ref;

			public static IOnCompleteListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCompleteListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.widget.WebDialog.OnCompleteListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCompleteListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnCompleteListenerInvoker); }
			}

			static Delegate cb_onComplete_Landroid_os_Bundle_Lcom_facebook_FacebookException_;
#pragma warning disable 0169
			static Delegate GetOnComplete_Landroid_os_Bundle_Lcom_facebook_FacebookException_Handler ()
			{
				if (cb_onComplete_Landroid_os_Bundle_Lcom_facebook_FacebookException_ == null)
					cb_onComplete_Landroid_os_Bundle_Lcom_facebook_FacebookException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnComplete_Landroid_os_Bundle_Lcom_facebook_FacebookException_);
				return cb_onComplete_Landroid_os_Bundle_Lcom_facebook_FacebookException_;
			}

			static void n_OnComplete_Landroid_os_Bundle_Lcom_facebook_FacebookException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Xamarin.FacebookBinding.Widget.WebDialog.IOnCompleteListener __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.IOnCompleteListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.FacebookException p1 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.FacebookException> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnComplete (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onComplete_Landroid_os_Bundle_Lcom_facebook_FacebookException_;
			public void OnComplete (global::Android.OS.Bundle p0, global::Xamarin.FacebookBinding.FacebookException p1)
			{
				if (id_onComplete_Landroid_os_Bundle_Lcom_facebook_FacebookException_ == IntPtr.Zero)
					id_onComplete_Landroid_os_Bundle_Lcom_facebook_FacebookException_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Landroid/os/Bundle;Lcom/facebook/FacebookException;)V");
				JNIEnv.CallVoidMethod (Handle, id_onComplete_Landroid_os_Bundle_Lcom_facebook_FacebookException_, new JValue (p0), new JValue (p1));
			}

		}

		public partial class CompleteEventArgs : global::System.EventArgs {

			public CompleteEventArgs (global::Android.OS.Bundle p0, global::Xamarin.FacebookBinding.FacebookException p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Android.OS.Bundle p0;
			public global::Android.OS.Bundle P0 {
				get { return p0; }
			}

			global::Xamarin.FacebookBinding.FacebookException p1;
			public global::Xamarin.FacebookBinding.FacebookException P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/facebook/widget/WebDialog_OnCompleteListenerImplementor")]
		internal sealed class IOnCompleteListenerImplementor : global::Java.Lang.Object, IOnCompleteListener {

			object sender;

			public IOnCompleteListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/facebook/widget/WebDialog_OnCompleteListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CompleteEventArgs> Handler;
#pragma warning restore 0649

			public void OnComplete (global::Android.OS.Bundle p0, global::Xamarin.FacebookBinding.FacebookException p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new CompleteEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnCompleteListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.RequestsDialogBuilder']"
		[global::Android.Runtime.Register ("com/facebook/widget/WebDialog$RequestsDialogBuilder", DoNotGenerateAcw=true)]
		public partial class RequestsDialogBuilder : global::Xamarin.FacebookBinding.Widget.WebDialog.BuilderBase {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/widget/WebDialog$RequestsDialogBuilder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RequestsDialogBuilder); }
			}

			protected RequestsDialogBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_Lcom_facebook_Session_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.RequestsDialogBuilder']/constructor[@name='WebDialog.RequestsDialogBuilder' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.facebook.Session']]"
			[Register (".ctor", "(Landroid/content/Context;Lcom/facebook/Session;)V", "")]
			public RequestsDialogBuilder (global::Android.Content.Context p0, global::Xamarin.FacebookBinding.Session p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (RequestsDialogBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/facebook/Session;)V", new JValue (p0), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/facebook/Session;)V", new JValue (p0), new JValue (p1));
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_facebook_Session_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_facebook_Session_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/facebook/Session;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_facebook_Session_, new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_facebook_Session_, new JValue (p0), new JValue (p1));
			}

			static IntPtr id_ctor_Landroid_content_Context_Lcom_facebook_Session_Landroid_os_Bundle_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.RequestsDialogBuilder']/constructor[@name='WebDialog.RequestsDialogBuilder' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.facebook.Session'] and parameter[3][@type='android.os.Bundle']]"
			[Register (".ctor", "(Landroid/content/Context;Lcom/facebook/Session;Landroid/os/Bundle;)V", "")]
			public RequestsDialogBuilder (global::Android.Content.Context p0, global::Xamarin.FacebookBinding.Session p1, global::Android.OS.Bundle p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (RequestsDialogBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/facebook/Session;Landroid/os/Bundle;)V", new JValue (p0), new JValue (p1), new JValue (p2)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/facebook/Session;Landroid/os/Bundle;)V", new JValue (p0), new JValue (p1), new JValue (p2));
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_facebook_Session_Landroid_os_Bundle_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_facebook_Session_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/facebook/Session;Landroid/os/Bundle;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_facebook_Session_Landroid_os_Bundle_, new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_facebook_Session_Landroid_os_Bundle_, new JValue (p0), new JValue (p1), new JValue (p2));
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.RequestsDialogBuilder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/facebook/widget/WebDialog;", "GetBuildHandler")]
			public override global::Xamarin.FacebookBinding.Widget.WebDialog Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/facebook/widget/WebDialog;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/facebook/widget/WebDialog;")), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_setData_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetData_Ljava_lang_String_Handler ()
			{
				if (cb_setData_Ljava_lang_String_ == null)
					cb_setData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetData_Ljava_lang_String_);
				return cb_setData_Ljava_lang_String_;
			}

			static IntPtr n_SetData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetData (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setData_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.RequestsDialogBuilder']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setData", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$RequestsDialogBuilder;", "GetSetData_Ljava_lang_String_Handler")]
			public virtual global::Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder SetData (string p0)
			{
				if (id_setData_Ljava_lang_String_ == IntPtr.Zero)
					id_setData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setData", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$RequestsDialogBuilder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setData_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setData", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$RequestsDialogBuilder;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_setMessage_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetMessage_Ljava_lang_String_Handler ()
			{
				if (cb_setMessage_Ljava_lang_String_ == null)
					cb_setMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMessage_Ljava_lang_String_);
				return cb_setMessage_Ljava_lang_String_;
			}

			static IntPtr n_SetMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMessage (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setMessage_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.RequestsDialogBuilder']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMessage", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$RequestsDialogBuilder;", "GetSetMessage_Ljava_lang_String_Handler")]
			public virtual global::Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder SetMessage (string p0)
			{
				if (id_setMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessage", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$RequestsDialogBuilder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setMessage_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessage", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$RequestsDialogBuilder;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTitle_Ljava_lang_String_Handler ()
			{
				if (cb_setTitle_Ljava_lang_String_ == null)
					cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
				return cb_setTitle_Ljava_lang_String_;
			}

			static IntPtr n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTitle (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setTitle_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.RequestsDialogBuilder']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitle", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$RequestsDialogBuilder;", "GetSetTitle_Ljava_lang_String_Handler")]
			public virtual global::Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder SetTitle (string p0)
			{
				if (id_setTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$RequestsDialogBuilder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setTitle_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitle", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$RequestsDialogBuilder;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_setTo_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTo_Ljava_lang_String_Handler ()
			{
				if (cb_setTo_Ljava_lang_String_ == null)
					cb_setTo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTo_Ljava_lang_String_);
				return cb_setTo_Ljava_lang_String_;
			}

			static IntPtr n_SetTo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTo (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setTo_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog.RequestsDialogBuilder']/method[@name='setTo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTo", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$RequestsDialogBuilder;", "GetSetTo_Ljava_lang_String_Handler")]
			public virtual global::Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder SetTo (string p0)
			{
				if (id_setTo_Ljava_lang_String_ == IntPtr.Zero)
					id_setTo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTo", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$RequestsDialogBuilder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setTo_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTo", "(Ljava/lang/String;)Lcom/facebook/widget/WebDialog$RequestsDialogBuilder;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/widget/WebDialog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WebDialog); }
		}

		protected WebDialog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog']/constructor[@name='WebDialog' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public WebDialog (global::Android.Content.Context p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (WebDialog)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog']/constructor[@name='WebDialog' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;I)V", "")]
		public WebDialog (global::Android.Content.Context p0, string p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (WebDialog)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;I)V", new JValue (p0), new JValue (native_p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;I)V", new JValue (p0), new JValue (native_p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Landroid_content_Context_Ljava_lang_String_I == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_I, new JValue (p0), new JValue (native_p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_I, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ILcom_facebook_widget_WebDialog_OnCompleteListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog']/constructor[@name='WebDialog' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='int'] and parameter[5][@type='com.facebook.widget.WebDialog.OnCompleteListener']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;ILcom/facebook/widget/WebDialog$OnCompleteListener;)V", "")]
		public WebDialog (global::Android.Content.Context p0, string p1, global::Android.OS.Bundle p2, int p3, global::Xamarin.FacebookBinding.Widget.WebDialog.IOnCompleteListener p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (WebDialog)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;ILcom/facebook/widget/WebDialog$OnCompleteListener;)V", new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;ILcom/facebook/widget/WebDialog$OnCompleteListener;)V", new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ILcom_facebook_widget_WebDialog_OnCompleteListener_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ILcom_facebook_widget_WebDialog_OnCompleteListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;ILcom/facebook/widget/WebDialog$OnCompleteListener;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ILcom_facebook_widget_WebDialog_OnCompleteListener_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ILcom_facebook_widget_WebDialog_OnCompleteListener_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getOnCompleteListener;
#pragma warning disable 0169
		static Delegate GetGetOnCompleteListenerHandler ()
		{
			if (cb_getOnCompleteListener == null)
				cb_getOnCompleteListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnCompleteListener);
			return cb_getOnCompleteListener;
		}

		static IntPtr n_GetOnCompleteListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Widget.WebDialog __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnCompleteListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnCompleteListener_Lcom_facebook_widget_WebDialog_OnCompleteListener_;
#pragma warning disable 0169
		static Delegate GetSetOnCompleteListener_Lcom_facebook_widget_WebDialog_OnCompleteListener_Handler ()
		{
			if (cb_setOnCompleteListener_Lcom_facebook_widget_WebDialog_OnCompleteListener_ == null)
				cb_setOnCompleteListener_Lcom_facebook_widget_WebDialog_OnCompleteListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnCompleteListener_Lcom_facebook_widget_WebDialog_OnCompleteListener_);
			return cb_setOnCompleteListener_Lcom_facebook_widget_WebDialog_OnCompleteListener_;
		}

		static void n_SetOnCompleteListener_Lcom_facebook_widget_WebDialog_OnCompleteListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Widget.WebDialog __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.Widget.WebDialog.IOnCompleteListener p0 = (global::Xamarin.FacebookBinding.Widget.WebDialog.IOnCompleteListener)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.IOnCompleteListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCompleteListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOnCompleteListener;
		static IntPtr id_setOnCompleteListener_Lcom_facebook_widget_WebDialog_OnCompleteListener_;
		public virtual global::Xamarin.FacebookBinding.Widget.WebDialog.IOnCompleteListener OnCompleteListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog']/method[@name='getOnCompleteListener' and count(parameter)=0]"
			[Register ("getOnCompleteListener", "()Lcom/facebook/widget/WebDialog$OnCompleteListener;", "GetGetOnCompleteListenerHandler")]
			get {
				if (id_getOnCompleteListener == IntPtr.Zero)
					id_getOnCompleteListener = JNIEnv.GetMethodID (class_ref, "getOnCompleteListener", "()Lcom/facebook/widget/WebDialog$OnCompleteListener;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.IOnCompleteListener> (JNIEnv.CallObjectMethod  (Handle, id_getOnCompleteListener), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.WebDialog.IOnCompleteListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnCompleteListener", "()Lcom/facebook/widget/WebDialog$OnCompleteListener;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='WebDialog']/method[@name='setOnCompleteListener' and count(parameter)=1 and parameter[1][@type='com.facebook.widget.WebDialog.OnCompleteListener']]"
			[Register ("setOnCompleteListener", "(Lcom/facebook/widget/WebDialog$OnCompleteListener;)V", "GetSetOnCompleteListener_Lcom_facebook_widget_WebDialog_OnCompleteListener_Handler")]
			set {
				if (id_setOnCompleteListener_Lcom_facebook_widget_WebDialog_OnCompleteListener_ == IntPtr.Zero)
					id_setOnCompleteListener_Lcom_facebook_widget_WebDialog_OnCompleteListener_ = JNIEnv.GetMethodID (class_ref, "setOnCompleteListener", "(Lcom/facebook/widget/WebDialog$OnCompleteListener;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnCompleteListener_Lcom_facebook_widget_WebDialog_OnCompleteListener_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnCompleteListener", "(Lcom/facebook/widget/WebDialog$OnCompleteListener;)V"), new JValue (value));
			}
		}

#region "Event implementation for Xamarin.FacebookBinding.Widget.WebDialog.IOnCompleteListener"
		public event EventHandler<global::Xamarin.FacebookBinding.Widget.WebDialog.CompleteEventArgs> Complete {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Xamarin.FacebookBinding.Widget.WebDialog.IOnCompleteListener, global::Xamarin.FacebookBinding.Widget.WebDialog.IOnCompleteListenerImplementor>(
						ref weak_implementor___SetOnCompleteListener,
						__CreateIOnCompleteListenerImplementor,
						__v => OnCompleteListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Xamarin.FacebookBinding.Widget.WebDialog.IOnCompleteListener, global::Xamarin.FacebookBinding.Widget.WebDialog.IOnCompleteListenerImplementor>(
						ref weak_implementor___SetOnCompleteListener,
						global::Xamarin.FacebookBinding.Widget.WebDialog.IOnCompleteListenerImplementor.__IsEmpty,
						__v => OnCompleteListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOnCompleteListener;

		global::Xamarin.FacebookBinding.Widget.WebDialog.IOnCompleteListenerImplementor __CreateIOnCompleteListenerImplementor ()
		{
			return new global::Xamarin.FacebookBinding.Widget.WebDialog.IOnCompleteListenerImplementor (this);
		}
#endregion
	}
}
