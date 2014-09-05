using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.widget']/class[@name='ProfilePictureView']"
	[global::Android.Runtime.Register ("com/facebook/widget/ProfilePictureView", DoNotGenerateAcw=true)]
	public partial class ProfilePictureView : global::Android.Widget.FrameLayout {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.widget']/class[@name='ProfilePictureView']/field[@name='CUSTOM']"
		[Register ("CUSTOM")]
		public const int Custom = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.widget']/class[@name='ProfilePictureView']/field[@name='LARGE']"
		[Register ("LARGE")]
		public const int Large = (int) -4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.widget']/class[@name='ProfilePictureView']/field[@name='NORMAL']"
		[Register ("NORMAL")]
		public const int Normal = (int) -3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.widget']/class[@name='ProfilePictureView']/field[@name='SMALL']"
		[Register ("SMALL")]
		public const int Small = (int) -2;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.widget']/interface[@name='ProfilePictureView.OnErrorListener']"
		[Register ("com/facebook/widget/ProfilePictureView$OnErrorListener", "", "Xamarin.FacebookBinding.Widget.ProfilePictureView/IOnErrorListenerInvoker")]
		public partial interface IOnErrorListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/interface[@name='ProfilePictureView.OnErrorListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.facebook.FacebookException']]"
			[Register ("onError", "(Lcom/facebook/FacebookException;)V", "GetOnError_Lcom_facebook_FacebookException_Handler:Xamarin.FacebookBinding.Widget.ProfilePictureView/IOnErrorListenerInvoker, Xamarin.Facebook")]
			void OnError (global::Xamarin.FacebookBinding.FacebookException p0);

		}

		[global::Android.Runtime.Register ("com/facebook/widget/ProfilePictureView$OnErrorListener", DoNotGenerateAcw=true)]
		internal class IOnErrorListenerInvoker : global::Java.Lang.Object, IOnErrorListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/widget/ProfilePictureView$OnErrorListener");
			IntPtr class_ref;

			public static IOnErrorListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnErrorListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.widget.ProfilePictureView.OnErrorListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnErrorListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnErrorListenerInvoker); }
			}

			static Delegate cb_onError_Lcom_facebook_FacebookException_;
#pragma warning disable 0169
			static Delegate GetOnError_Lcom_facebook_FacebookException_Handler ()
			{
				if (cb_onError_Lcom_facebook_FacebookException_ == null)
					cb_onError_Lcom_facebook_FacebookException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Lcom_facebook_FacebookException_);
				return cb_onError_Lcom_facebook_FacebookException_;
			}

			static void n_OnError_Lcom_facebook_FacebookException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Widget.ProfilePictureView.IOnErrorListener __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.ProfilePictureView.IOnErrorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.FacebookException p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.FacebookException> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onError_Lcom_facebook_FacebookException_;
			public void OnError (global::Xamarin.FacebookBinding.FacebookException p0)
			{
				if (id_onError_Lcom_facebook_FacebookException_ == IntPtr.Zero)
					id_onError_Lcom_facebook_FacebookException_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/facebook/FacebookException;)V");
				JNIEnv.CallVoidMethod (Handle, id_onError_Lcom_facebook_FacebookException_, new JValue (p0));
			}

		}

		public partial class ErrorEventArgs : global::System.EventArgs {

			public ErrorEventArgs (global::Xamarin.FacebookBinding.FacebookException p0)
			{
				this.p0 = p0;
			}

			global::Xamarin.FacebookBinding.FacebookException p0;
			public global::Xamarin.FacebookBinding.FacebookException P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/facebook/widget/ProfilePictureView_OnErrorListenerImplementor")]
		internal sealed class IOnErrorListenerImplementor : global::Java.Lang.Object, IOnErrorListener {

			object sender;

			public IOnErrorListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/facebook/widget/ProfilePictureView_OnErrorListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ErrorEventArgs> Handler;
#pragma warning restore 0649

			public void OnError (global::Xamarin.FacebookBinding.FacebookException p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ErrorEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnErrorListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/widget/ProfilePictureView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProfilePictureView); }
		}

		protected ProfilePictureView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.widget']/class[@name='ProfilePictureView']/constructor[@name='ProfilePictureView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public ProfilePictureView (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ProfilePictureView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.widget']/class[@name='ProfilePictureView']/constructor[@name='ProfilePictureView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public ProfilePictureView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ProfilePictureView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.widget']/class[@name='ProfilePictureView']/constructor[@name='ProfilePictureView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public ProfilePictureView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ProfilePictureView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_isCropped;
		static IntPtr id_setCropped_Z;
		public bool Cropped {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='ProfilePictureView']/method[@name='isCropped' and count(parameter)=0]"
			[Register ("isCropped", "()Z", "GetIsCroppedHandler")]
			get {
				if (id_isCropped == IntPtr.Zero)
					id_isCropped = JNIEnv.GetMethodID (class_ref, "isCropped", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isCropped);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='ProfilePictureView']/method[@name='setCropped' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCropped", "(Z)V", "GetSetCropped_ZHandler")]
			set {
				if (id_setCropped_Z == IntPtr.Zero)
					id_setCropped_Z = JNIEnv.GetMethodID (class_ref, "setCropped", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setCropped_Z, new JValue (value));
			}
		}

		static IntPtr id_getOnErrorListener;
		static IntPtr id_setOnErrorListener_Lcom_facebook_widget_ProfilePictureView_OnErrorListener_;
		public global::Xamarin.FacebookBinding.Widget.ProfilePictureView.IOnErrorListener OnErrorListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='ProfilePictureView']/method[@name='getOnErrorListener' and count(parameter)=0]"
			[Register ("getOnErrorListener", "()Lcom/facebook/widget/ProfilePictureView$OnErrorListener;", "GetGetOnErrorListenerHandler")]
			get {
				if (id_getOnErrorListener == IntPtr.Zero)
					id_getOnErrorListener = JNIEnv.GetMethodID (class_ref, "getOnErrorListener", "()Lcom/facebook/widget/ProfilePictureView$OnErrorListener;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.ProfilePictureView.IOnErrorListener> (JNIEnv.CallObjectMethod  (Handle, id_getOnErrorListener), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='ProfilePictureView']/method[@name='setOnErrorListener' and count(parameter)=1 and parameter[1][@type='com.facebook.widget.ProfilePictureView.OnErrorListener']]"
			[Register ("setOnErrorListener", "(Lcom/facebook/widget/ProfilePictureView$OnErrorListener;)V", "GetSetOnErrorListener_Lcom_facebook_widget_ProfilePictureView_OnErrorListener_Handler")]
			set {
				if (id_setOnErrorListener_Lcom_facebook_widget_ProfilePictureView_OnErrorListener_ == IntPtr.Zero)
					id_setOnErrorListener_Lcom_facebook_widget_ProfilePictureView_OnErrorListener_ = JNIEnv.GetMethodID (class_ref, "setOnErrorListener", "(Lcom/facebook/widget/ProfilePictureView$OnErrorListener;)V");
				JNIEnv.CallVoidMethod  (Handle, id_setOnErrorListener_Lcom_facebook_widget_ProfilePictureView_OnErrorListener_, new JValue (value));
			}
		}

		static IntPtr id_getPresetSize;
		static IntPtr id_setPresetSize_I;
		public int PresetSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='ProfilePictureView']/method[@name='getPresetSize' and count(parameter)=0]"
			[Register ("getPresetSize", "()I", "GetGetPresetSizeHandler")]
			get {
				if (id_getPresetSize == IntPtr.Zero)
					id_getPresetSize = JNIEnv.GetMethodID (class_ref, "getPresetSize", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getPresetSize);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='ProfilePictureView']/method[@name='setPresetSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPresetSize", "(I)V", "GetSetPresetSize_IHandler")]
			set {
				if (id_setPresetSize_I == IntPtr.Zero)
					id_setPresetSize_I = JNIEnv.GetMethodID (class_ref, "setPresetSize", "(I)V");
				JNIEnv.CallVoidMethod  (Handle, id_setPresetSize_I, new JValue (value));
			}
		}

		static IntPtr id_getProfileId;
		static IntPtr id_setProfileId_Ljava_lang_String_;
		public string ProfileId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='ProfilePictureView']/method[@name='getProfileId' and count(parameter)=0]"
			[Register ("getProfileId", "()Ljava/lang/String;", "GetGetProfileIdHandler")]
			get {
				if (id_getProfileId == IntPtr.Zero)
					id_getProfileId = JNIEnv.GetMethodID (class_ref, "getProfileId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getProfileId), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='ProfilePictureView']/method[@name='setProfileId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setProfileId", "(Ljava/lang/String;)V", "GetSetProfileId_Ljava_lang_String_Handler")]
			set {
				if (id_setProfileId_Ljava_lang_String_ == IntPtr.Zero)
					id_setProfileId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setProfileId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setProfileId_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

#region "Event implementation for Xamarin.FacebookBinding.Widget.ProfilePictureView.IOnErrorListener"
		public event EventHandler<global::Xamarin.FacebookBinding.Widget.ProfilePictureView.ErrorEventArgs> Error {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Xamarin.FacebookBinding.Widget.ProfilePictureView.IOnErrorListener, global::Xamarin.FacebookBinding.Widget.ProfilePictureView.IOnErrorListenerImplementor>(
						ref weak_implementor___SetOnErrorListener,
						__CreateIOnErrorListenerImplementor,
						__v => OnErrorListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Xamarin.FacebookBinding.Widget.ProfilePictureView.IOnErrorListener, global::Xamarin.FacebookBinding.Widget.ProfilePictureView.IOnErrorListenerImplementor>(
						ref weak_implementor___SetOnErrorListener,
						global::Xamarin.FacebookBinding.Widget.ProfilePictureView.IOnErrorListenerImplementor.__IsEmpty,
						__v => OnErrorListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOnErrorListener;

		global::Xamarin.FacebookBinding.Widget.ProfilePictureView.IOnErrorListenerImplementor __CreateIOnErrorListenerImplementor ()
		{
			return new global::Xamarin.FacebookBinding.Widget.ProfilePictureView.IOnErrorListenerImplementor (this);
		}
#endregion
	}
}
