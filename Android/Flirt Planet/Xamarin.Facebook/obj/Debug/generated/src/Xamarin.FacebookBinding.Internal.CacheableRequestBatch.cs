using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.internal']/class[@name='CacheableRequestBatch']"
	[global::Android.Runtime.Register ("com/facebook/internal/CacheableRequestBatch", DoNotGenerateAcw=true)]
	public partial class CacheableRequestBatch : global::Xamarin.FacebookBinding.RequestBatch {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/internal/CacheableRequestBatch", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CacheableRequestBatch); }
		}

		protected CacheableRequestBatch (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.internal']/class[@name='CacheableRequestBatch']/constructor[@name='CacheableRequestBatch' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public CacheableRequestBatch () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CacheableRequestBatch)) {
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

		static IntPtr id_ctor_arrayLcom_facebook_Request_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.internal']/class[@name='CacheableRequestBatch']/constructor[@name='CacheableRequestBatch' and count(parameter)=1 and parameter[1][@type='com.facebook.Request...']]"
		[Register (".ctor", "([Lcom/facebook/Request;)V", "")]
		public CacheableRequestBatch (params global:: Xamarin.FacebookBinding.Request[] p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);;
			if (GetType () != typeof (CacheableRequestBatch)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([Lcom/facebook/Request;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([Lcom/facebook/Request;)V", new JValue (native_p0));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return;
			}

			if (id_ctor_arrayLcom_facebook_Request_ == IntPtr.Zero)
				id_ctor_arrayLcom_facebook_Request_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Lcom/facebook/Request;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLcom_facebook_Request_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayLcom_facebook_Request_, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getCacheKeyOverride;
		static IntPtr id_setCacheKeyOverride_Ljava_lang_String_;
		public string CacheKeyOverride {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='CacheableRequestBatch']/method[@name='getCacheKeyOverride' and count(parameter)=0]"
			[Register ("getCacheKeyOverride", "()Ljava/lang/String;", "GetGetCacheKeyOverrideHandler")]
			get {
				if (id_getCacheKeyOverride == IntPtr.Zero)
					id_getCacheKeyOverride = JNIEnv.GetMethodID (class_ref, "getCacheKeyOverride", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCacheKeyOverride), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='CacheableRequestBatch']/method[@name='setCacheKeyOverride' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCacheKeyOverride", "(Ljava/lang/String;)V", "GetSetCacheKeyOverride_Ljava_lang_String_Handler")]
			set {
				if (id_setCacheKeyOverride_Ljava_lang_String_ == IntPtr.Zero)
					id_setCacheKeyOverride_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCacheKeyOverride", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setCacheKeyOverride_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getForceRoundTrip;
		static IntPtr id_setForceRoundTrip_Z;
		public bool ForceRoundTrip {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='CacheableRequestBatch']/method[@name='getForceRoundTrip' and count(parameter)=0]"
			[Register ("getForceRoundTrip", "()Z", "GetGetForceRoundTripHandler")]
			get {
				if (id_getForceRoundTrip == IntPtr.Zero)
					id_getForceRoundTrip = JNIEnv.GetMethodID (class_ref, "getForceRoundTrip", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_getForceRoundTrip);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='CacheableRequestBatch']/method[@name='setForceRoundTrip' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setForceRoundTrip", "(Z)V", "GetSetForceRoundTrip_ZHandler")]
			set {
				if (id_setForceRoundTrip_Z == IntPtr.Zero)
					id_setForceRoundTrip_Z = JNIEnv.GetMethodID (class_ref, "setForceRoundTrip", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setForceRoundTrip_Z, new JValue (value));
			}
		}

	}
}
