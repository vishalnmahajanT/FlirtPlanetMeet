using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.internal']/class[@name='FileLruCache']"
	[global::Android.Runtime.Register ("com/facebook/internal/FileLruCache", DoNotGenerateAcw=true)]
	public sealed partial class FileLruCache : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.internal']/class[@name='FileLruCache.BufferFile']"
		[global::Android.Runtime.Register ("com/facebook/internal/FileLruCache$BufferFile", DoNotGenerateAcw=true)]
		public partial class BufferFile : global::Java.Lang.Object {

			protected BufferFile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.internal']/class[@name='FileLruCache.CloseCallbackOutputStream']"
		[global::Android.Runtime.Register ("com/facebook/internal/FileLruCache$CloseCallbackOutputStream", DoNotGenerateAcw=true)]
		public partial class CloseCallbackOutputStream : global::Java.IO.OutputStream {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/internal/FileLruCache$CloseCallbackOutputStream", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CloseCallbackOutputStream); }
			}

			protected CloseCallbackOutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_write_I;
#pragma warning disable 0169
			static Delegate GetWrite_IHandler ()
			{
				if (cb_write_I == null)
					cb_write_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Write_I);
				return cb_write_I;
			}

			static void n_Write_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Xamarin.FacebookBinding.Internal.FileLruCache.CloseCallbackOutputStream __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Internal.FileLruCache.CloseCallbackOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Write (p0);
			}
#pragma warning restore 0169

			static IntPtr id_write_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='FileLruCache.CloseCallbackOutputStream']/method[@name='write' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("write", "(I)V", "GetWrite_IHandler")]
			public override void Write (int p0)
			{
				if (id_write_I == IntPtr.Zero)
					id_write_I = JNIEnv.GetMethodID (class_ref, "write", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_I, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(I)V"), new JValue (p0));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.internal']/class[@name='FileLruCache.CopyingInputStream']"
		[global::Android.Runtime.Register ("com/facebook/internal/FileLruCache$CopyingInputStream", DoNotGenerateAcw=true)]
		public sealed partial class CopyingInputStream : global::Java.IO.InputStream {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/internal/FileLruCache$CopyingInputStream", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CopyingInputStream); }
			}

			internal CopyingInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_read;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='FileLruCache.CopyingInputStream']/method[@name='read' and count(parameter)=0]"
			[Register ("read", "()I", "")]
			public override int Read ()
			{
				if (id_read == IntPtr.Zero)
					id_read = JNIEnv.GetMethodID (class_ref, "read", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_read);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.internal']/class[@name='FileLruCache.Limits']"
		[global::Android.Runtime.Register ("com/facebook/internal/FileLruCache$Limits", DoNotGenerateAcw=true)]
		public sealed partial class Limits : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/internal/FileLruCache$Limits", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Limits); }
			}

			internal Limits (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.internal']/class[@name='FileLruCache.Limits']/constructor[@name='FileLruCache.Limits' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public Limits () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Limits)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.internal']/class[@name='FileLruCache.ModifiedFile']"
		[global::Android.Runtime.Register ("com/facebook/internal/FileLruCache$ModifiedFile", DoNotGenerateAcw=true)]
		public sealed partial class ModifiedFile : global::Java.Lang.Object, global::Java.Lang.IComparable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/internal/FileLruCache$ModifiedFile", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ModifiedFile); }
			}

			internal ModifiedFile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_compareTo_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='FileLruCache.ModifiedFile']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("compareTo", "(Ljava/lang/Object;)I", "")]
			public int CompareTo (global::Java.Lang.Object p0)
			{
				if (id_compareTo_Ljava_lang_Object_ == IntPtr.Zero)
					id_compareTo_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Ljava/lang/Object;)I");
				int __ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Ljava_lang_Object_, new JValue (p0));
				return __ret;
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.internal']/interface[@name='FileLruCache.StreamCloseCallback']"
		[Register ("com/facebook/internal/FileLruCache$StreamCloseCallback", "", "Xamarin.FacebookBinding.Internal.FileLruCache/IStreamCloseCallbackInvoker")]
		public partial interface IStreamCloseCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/interface[@name='FileLruCache.StreamCloseCallback']/method[@name='onClose' and count(parameter)=0]"
			[Register ("onClose", "()V", "GetOnCloseHandler:Xamarin.FacebookBinding.Internal.FileLruCache/IStreamCloseCallbackInvoker, Xamarin.Facebook")]
			void OnClose ();

		}

		[global::Android.Runtime.Register ("com/facebook/internal/FileLruCache$StreamCloseCallback", DoNotGenerateAcw=true)]
		internal class IStreamCloseCallbackInvoker : global::Java.Lang.Object, IStreamCloseCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/internal/FileLruCache$StreamCloseCallback");
			IntPtr class_ref;

			public static IStreamCloseCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IStreamCloseCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.internal.FileLruCache.StreamCloseCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IStreamCloseCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IStreamCloseCallbackInvoker); }
			}

			static Delegate cb_onClose;
#pragma warning disable 0169
			static Delegate GetOnCloseHandler ()
			{
				if (cb_onClose == null)
					cb_onClose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnClose);
				return cb_onClose;
			}

			static void n_OnClose (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.Internal.FileLruCache.IStreamCloseCallback __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Internal.FileLruCache.IStreamCloseCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnClose ();
			}
#pragma warning restore 0169

			IntPtr id_onClose;
			public void OnClose ()
			{
				if (id_onClose == IntPtr.Zero)
					id_onClose = JNIEnv.GetMethodID (class_ref, "onClose", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onClose);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.internal']/class[@name='FileLruCache.StreamHeader']"
		[global::Android.Runtime.Register ("com/facebook/internal/FileLruCache$StreamHeader", DoNotGenerateAcw=true)]
		public sealed partial class StreamHeader : global::Java.Lang.Object {

			internal StreamHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/internal/FileLruCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileLruCache); }
		}

		internal FileLruCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_internal_FileLruCache_Limits_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.internal']/class[@name='FileLruCache']/constructor[@name='FileLruCache' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.facebook.internal.FileLruCache.Limits']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Lcom/facebook/internal/FileLruCache$Limits;)V", "")]
		public FileLruCache (global::Android.Content.Context p0, string p1, global::Xamarin.FacebookBinding.Internal.FileLruCache.Limits p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (FileLruCache)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Lcom/facebook/internal/FileLruCache$Limits;)V", new JValue (p0), new JValue (native_p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;Lcom/facebook/internal/FileLruCache$Limits;)V", new JValue (p0), new JValue (native_p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_internal_FileLruCache_Limits_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_internal_FileLruCache_Limits_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Lcom/facebook/internal/FileLruCache$Limits;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_internal_FileLruCache_Limits_, new JValue (p0), new JValue (native_p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Lcom_facebook_internal_FileLruCache_Limits_, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_clearForTest;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='FileLruCache']/method[@name='clearForTest' and count(parameter)=0]"
		[Register ("clearForTest", "()V", "")]
		public void ClearForTest ()
		{
			if (id_clearForTest == IntPtr.Zero)
				id_clearForTest = JNIEnv.GetMethodID (class_ref, "clearForTest", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_clearForTest);
		}

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='FileLruCache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Ljava/io/InputStream;", "")]
		public global::System.IO.Stream Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::System.IO.Stream __ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_get_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='FileLruCache']/method[@name='get' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;Ljava/lang/String;)Ljava/io/InputStream;", "")]
		public global::System.IO.Stream Get (string p0, string p1)
		{
			if (id_get_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;Ljava/lang/String;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::System.IO.Stream __ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_interceptAndPut_Ljava_lang_String_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='FileLruCache']/method[@name='interceptAndPut' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.InputStream']]"
		[Register ("interceptAndPut", "(Ljava/lang/String;Ljava/io/InputStream;)Ljava/io/InputStream;", "")]
		public global::System.IO.Stream InterceptAndPut (string p0, global::System.IO.Stream p1)
		{
			if (id_interceptAndPut_Ljava_lang_String_Ljava_io_InputStream_ == IntPtr.Zero)
				id_interceptAndPut_Ljava_lang_String_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "interceptAndPut", "(Ljava/lang/String;Ljava/io/InputStream;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p1);
			global::System.IO.Stream __ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_interceptAndPut_Ljava_lang_String_Ljava_io_InputStream_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_openPutStream_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='FileLruCache']/method[@name='openPutStream' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("openPutStream", "(Ljava/lang/String;Ljava/lang/String;)Ljava/io/OutputStream;", "")]
		public global::System.IO.Stream OpenPutStream (string p0, string p1)
		{
			if (id_openPutStream_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_openPutStream_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "openPutStream", "(Ljava/lang/String;Ljava/lang/String;)Ljava/io/OutputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::System.IO.Stream __ret = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_openPutStream_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
