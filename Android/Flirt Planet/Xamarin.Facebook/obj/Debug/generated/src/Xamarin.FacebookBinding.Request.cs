using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='Request']"
	[global::Android.Runtime.Register ("com/facebook/Request", DoNotGenerateAcw=true)]
	public partial class Request : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='Request']/field[@name='MAXIMUM_BATCH_SIZE']"
		[Register ("MAXIMUM_BATCH_SIZE")]
		public const int MaximumBatchSize = (int) 50;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook']/interface[@name='Request.Callback']"
		[Register ("com/facebook/Request$Callback", "", "Xamarin.FacebookBinding.Request/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/interface[@name='Request.Callback']/method[@name='onCompleted' and count(parameter)=1 and parameter[1][@type='com.facebook.Response']]"
			[Register ("onCompleted", "(Lcom/facebook/Response;)V", "GetOnCompleted_Lcom_facebook_Response_Handler:Xamarin.FacebookBinding.Request/ICallbackInvoker, Xamarin.Facebook")]
			void OnCompleted (global::Xamarin.FacebookBinding.Response p0);

		}

		[global::Android.Runtime.Register ("com/facebook/Request$Callback", DoNotGenerateAcw=true)]
		internal class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/Request$Callback");
			IntPtr class_ref;

			public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.Request.Callback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (ICallbackInvoker); }
			}

			static Delegate cb_onCompleted_Lcom_facebook_Response_;
#pragma warning disable 0169
			static Delegate GetOnCompleted_Lcom_facebook_Response_Handler ()
			{
				if (cb_onCompleted_Lcom_facebook_Response_ == null)
					cb_onCompleted_Lcom_facebook_Response_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCompleted_Lcom_facebook_Response_);
				return cb_onCompleted_Lcom_facebook_Response_;
			}

			static void n_OnCompleted_Lcom_facebook_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Request.ICallback __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.Response p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCompleted (p0);
			}
#pragma warning restore 0169

			IntPtr id_onCompleted_Lcom_facebook_Response_;
			public void OnCompleted (global::Xamarin.FacebookBinding.Response p0)
			{
				if (id_onCompleted_Lcom_facebook_Response_ == IntPtr.Zero)
					id_onCompleted_Lcom_facebook_Response_ = JNIEnv.GetMethodID (class_ref, "onCompleted", "(Lcom/facebook/Response;)V");
				JNIEnv.CallVoidMethod (Handle, id_onCompleted_Lcom_facebook_Response_, new JValue (p0));
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook']/interface[@name='Request.GraphPlaceListCallback']"
		[Register ("com/facebook/Request$GraphPlaceListCallback", "", "Xamarin.FacebookBinding.Request/IGraphPlaceListCallbackInvoker")]
		public partial interface IGraphPlaceListCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/interface[@name='Request.GraphPlaceListCallback']/method[@name='onCompleted' and count(parameter)=2 and parameter[1][@type='java.util.List'] and parameter[2][@type='com.facebook.Response']]"
			[Register ("onCompleted", "(Ljava/util/List;Lcom/facebook/Response;)V", "GetOnCompleted_Ljava_util_List_Lcom_facebook_Response_Handler:Xamarin.FacebookBinding.Request/IGraphPlaceListCallbackInvoker, Xamarin.Facebook")]
			void OnCompleted (global::System.Collections.Generic.IList<global::Xamarin.FacebookBinding.Model.IGraphPlace> p0, global::Xamarin.FacebookBinding.Response p1);

		}

		[global::Android.Runtime.Register ("com/facebook/Request$GraphPlaceListCallback", DoNotGenerateAcw=true)]
		internal class IGraphPlaceListCallbackInvoker : global::Java.Lang.Object, IGraphPlaceListCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/Request$GraphPlaceListCallback");
			IntPtr class_ref;

			public static IGraphPlaceListCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IGraphPlaceListCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.Request.GraphPlaceListCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IGraphPlaceListCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IGraphPlaceListCallbackInvoker); }
			}

			static Delegate cb_onCompleted_Ljava_util_List_Lcom_facebook_Response_;
#pragma warning disable 0169
			static Delegate GetOnCompleted_Ljava_util_List_Lcom_facebook_Response_Handler ()
			{
				if (cb_onCompleted_Ljava_util_List_Lcom_facebook_Response_ == null)
					cb_onCompleted_Ljava_util_List_Lcom_facebook_Response_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCompleted_Ljava_util_List_Lcom_facebook_Response_);
				return cb_onCompleted_Ljava_util_List_Lcom_facebook_Response_;
			}

			static void n_OnCompleted_Ljava_util_List_Lcom_facebook_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Xamarin.FacebookBinding.Request.IGraphPlaceListCallback __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request.IGraphPlaceListCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.Collections.Generic.IList<Xamarin.FacebookBinding.Model.IGraphPlace> p0 = global::Android.Runtime.JavaList<global::Xamarin.FacebookBinding.Model.IGraphPlace>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.Response p1 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnCompleted (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onCompleted_Ljava_util_List_Lcom_facebook_Response_;
			public void OnCompleted (global::System.Collections.Generic.IList<global::Xamarin.FacebookBinding.Model.IGraphPlace> p0, global::Xamarin.FacebookBinding.Response p1)
			{
				if (id_onCompleted_Ljava_util_List_Lcom_facebook_Response_ == IntPtr.Zero)
					id_onCompleted_Ljava_util_List_Lcom_facebook_Response_ = JNIEnv.GetMethodID (class_ref, "onCompleted", "(Ljava/util/List;Lcom/facebook/Response;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Xamarin.FacebookBinding.Model.IGraphPlace>.ToLocalJniHandle (p0);
				JNIEnv.CallVoidMethod (Handle, id_onCompleted_Ljava_util_List_Lcom_facebook_Response_, new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook']/interface[@name='Request.GraphUserCallback']"
		[Register ("com/facebook/Request$GraphUserCallback", "", "Xamarin.FacebookBinding.Request/IGraphUserCallbackInvoker")]
		public partial interface IGraphUserCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/interface[@name='Request.GraphUserCallback']/method[@name='onCompleted' and count(parameter)=2 and parameter[1][@type='com.facebook.model.GraphUser'] and parameter[2][@type='com.facebook.Response']]"
			[Register ("onCompleted", "(Lcom/facebook/model/GraphUser;Lcom/facebook/Response;)V", "GetOnCompleted_Lcom_facebook_model_GraphUser_Lcom_facebook_Response_Handler:Xamarin.FacebookBinding.Request/IGraphUserCallbackInvoker, Xamarin.Facebook")]
			void OnCompleted (global::Xamarin.FacebookBinding.Model.IGraphUser p0, global::Xamarin.FacebookBinding.Response p1);

		}

		[global::Android.Runtime.Register ("com/facebook/Request$GraphUserCallback", DoNotGenerateAcw=true)]
		internal class IGraphUserCallbackInvoker : global::Java.Lang.Object, IGraphUserCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/Request$GraphUserCallback");
			IntPtr class_ref;

			public static IGraphUserCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IGraphUserCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.Request.GraphUserCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IGraphUserCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IGraphUserCallbackInvoker); }
			}

			static Delegate cb_onCompleted_Lcom_facebook_model_GraphUser_Lcom_facebook_Response_;
#pragma warning disable 0169
			static Delegate GetOnCompleted_Lcom_facebook_model_GraphUser_Lcom_facebook_Response_Handler ()
			{
				if (cb_onCompleted_Lcom_facebook_model_GraphUser_Lcom_facebook_Response_ == null)
					cb_onCompleted_Lcom_facebook_model_GraphUser_Lcom_facebook_Response_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCompleted_Lcom_facebook_model_GraphUser_Lcom_facebook_Response_);
				return cb_onCompleted_Lcom_facebook_model_GraphUser_Lcom_facebook_Response_;
			}

			static void n_OnCompleted_Lcom_facebook_model_GraphUser_Lcom_facebook_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Xamarin.FacebookBinding.Request.IGraphUserCallback __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request.IGraphUserCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.Model.IGraphUser p0 = (global::Xamarin.FacebookBinding.Model.IGraphUser)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.Response p1 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnCompleted (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onCompleted_Lcom_facebook_model_GraphUser_Lcom_facebook_Response_;
			public void OnCompleted (global::Xamarin.FacebookBinding.Model.IGraphUser p0, global::Xamarin.FacebookBinding.Response p1)
			{
				if (id_onCompleted_Lcom_facebook_model_GraphUser_Lcom_facebook_Response_ == IntPtr.Zero)
					id_onCompleted_Lcom_facebook_model_GraphUser_Lcom_facebook_Response_ = JNIEnv.GetMethodID (class_ref, "onCompleted", "(Lcom/facebook/model/GraphUser;Lcom/facebook/Response;)V");
				JNIEnv.CallVoidMethod (Handle, id_onCompleted_Lcom_facebook_model_GraphUser_Lcom_facebook_Response_, new JValue (p0), new JValue (p1));
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook']/interface[@name='Request.GraphUserListCallback']"
		[Register ("com/facebook/Request$GraphUserListCallback", "", "Xamarin.FacebookBinding.Request/IGraphUserListCallbackInvoker")]
		public partial interface IGraphUserListCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/interface[@name='Request.GraphUserListCallback']/method[@name='onCompleted' and count(parameter)=2 and parameter[1][@type='java.util.List'] and parameter[2][@type='com.facebook.Response']]"
			[Register ("onCompleted", "(Ljava/util/List;Lcom/facebook/Response;)V", "GetOnCompleted_Ljava_util_List_Lcom_facebook_Response_Handler:Xamarin.FacebookBinding.Request/IGraphUserListCallbackInvoker, Xamarin.Facebook")]
			void OnCompleted (global::System.Collections.Generic.IList<global::Xamarin.FacebookBinding.Model.IGraphUser> p0, global::Xamarin.FacebookBinding.Response p1);

		}

		[global::Android.Runtime.Register ("com/facebook/Request$GraphUserListCallback", DoNotGenerateAcw=true)]
		internal class IGraphUserListCallbackInvoker : global::Java.Lang.Object, IGraphUserListCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/Request$GraphUserListCallback");
			IntPtr class_ref;

			public static IGraphUserListCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IGraphUserListCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.Request.GraphUserListCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IGraphUserListCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IGraphUserListCallbackInvoker); }
			}

			static Delegate cb_onCompleted_Ljava_util_List_Lcom_facebook_Response_;
#pragma warning disable 0169
			static Delegate GetOnCompleted_Ljava_util_List_Lcom_facebook_Response_Handler ()
			{
				if (cb_onCompleted_Ljava_util_List_Lcom_facebook_Response_ == null)
					cb_onCompleted_Ljava_util_List_Lcom_facebook_Response_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCompleted_Ljava_util_List_Lcom_facebook_Response_);
				return cb_onCompleted_Ljava_util_List_Lcom_facebook_Response_;
			}

			static void n_OnCompleted_Ljava_util_List_Lcom_facebook_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Xamarin.FacebookBinding.Request.IGraphUserListCallback __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request.IGraphUserListCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.Collections.Generic.IList<Xamarin.FacebookBinding.Model.IGraphUser> p0 = global::Android.Runtime.JavaList<global::Xamarin.FacebookBinding.Model.IGraphUser>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.Response p1 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnCompleted (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onCompleted_Ljava_util_List_Lcom_facebook_Response_;
			public void OnCompleted (global::System.Collections.Generic.IList<global::Xamarin.FacebookBinding.Model.IGraphUser> p0, global::Xamarin.FacebookBinding.Response p1)
			{
				if (id_onCompleted_Ljava_util_List_Lcom_facebook_Response_ == IntPtr.Zero)
					id_onCompleted_Ljava_util_List_Lcom_facebook_Response_ = JNIEnv.GetMethodID (class_ref, "onCompleted", "(Ljava/util/List;Lcom/facebook/Response;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Xamarin.FacebookBinding.Model.IGraphUser>.ToLocalJniHandle (p0);
				JNIEnv.CallVoidMethod (Handle, id_onCompleted_Ljava_util_List_Lcom_facebook_Response_, new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook']/interface[@name='Request.KeyValueSerializer']"
		[Register ("com/facebook/Request$KeyValueSerializer", "", "Xamarin.FacebookBinding.Request/IKeyValueSerializerInvoker")]
		public partial interface IKeyValueSerializer : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/interface[@name='Request.KeyValueSerializer']/method[@name='writeString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("writeString", "(Ljava/lang/String;Ljava/lang/String;)V", "GetWriteString_Ljava_lang_String_Ljava_lang_String_Handler:Xamarin.FacebookBinding.Request/IKeyValueSerializerInvoker, Xamarin.Facebook")]
			void WriteString (string p0, string p1);

		}

		[global::Android.Runtime.Register ("com/facebook/Request$KeyValueSerializer", DoNotGenerateAcw=true)]
		internal class IKeyValueSerializerInvoker : global::Java.Lang.Object, IKeyValueSerializer {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/Request$KeyValueSerializer");
			IntPtr class_ref;

			public static IKeyValueSerializer GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IKeyValueSerializer> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.Request.KeyValueSerializer"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IKeyValueSerializerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IKeyValueSerializerInvoker); }
			}

			static Delegate cb_writeString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWriteString_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_writeString_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_writeString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteString_Ljava_lang_String_Ljava_lang_String_);
				return cb_writeString_Ljava_lang_String_Ljava_lang_String_;
			}

			static void n_WriteString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Xamarin.FacebookBinding.Request.IKeyValueSerializer __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request.IKeyValueSerializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.WriteString (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_writeString_Ljava_lang_String_Ljava_lang_String_;
			public void WriteString (string p0, string p1)
			{
				if (id_writeString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_writeString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "writeString", "(Ljava/lang/String;Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				JNIEnv.CallVoidMethod (Handle, id_writeString_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='Request.Serializer']"
		[global::Android.Runtime.Register ("com/facebook/Request$Serializer", DoNotGenerateAcw=true)]
		public partial class Serializer : global::Java.Lang.Object, global::Xamarin.FacebookBinding.Request.IKeyValueSerializer {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/Request$Serializer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Serializer); }
			}

			protected Serializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_io_BufferedOutputStream_Lcom_facebook_internal_Logger_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='Request.Serializer']/constructor[@name='Request.Serializer' and count(parameter)=2 and parameter[1][@type='java.io.BufferedOutputStream'] and parameter[2][@type='com.facebook.internal.Logger']]"
			[Register (".ctor", "(Ljava/io/BufferedOutputStream;Lcom/facebook/internal/Logger;)V", "")]
			public Serializer (global::Java.IO.BufferedOutputStream p0, global::Xamarin.FacebookBinding.Internal.Logger p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Serializer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/BufferedOutputStream;Lcom/facebook/internal/Logger;)V", new JValue (p0), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/BufferedOutputStream;Lcom/facebook/internal/Logger;)V", new JValue (p0), new JValue (p1));
					return;
				}

				if (id_ctor_Ljava_io_BufferedOutputStream_Lcom_facebook_internal_Logger_ == IntPtr.Zero)
					id_ctor_Ljava_io_BufferedOutputStream_Lcom_facebook_internal_Logger_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/BufferedOutputStream;Lcom/facebook/internal/Logger;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_BufferedOutputStream_Lcom_facebook_internal_Logger_, new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_BufferedOutputStream_Lcom_facebook_internal_Logger_, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_write_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetWrite_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
			{
				if (cb_write_Ljava_lang_String_arrayLjava_lang_Object_ == null)
					cb_write_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Write_Ljava_lang_String_arrayLjava_lang_Object_);
				return cb_write_Ljava_lang_String_arrayLjava_lang_Object_;
			}

			static void n_Write_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Xamarin.FacebookBinding.Request.Serializer __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request.Serializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object[] p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				__this.Write (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
			}
#pragma warning restore 0169

			static IntPtr id_write_Ljava_lang_String_arrayLjava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request.Serializer']/method[@name='write' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
			[Register ("write", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetWrite_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
			public virtual void Write (string p0, params global:: Java.Lang.Object[] p1)
			{
				if (id_write_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_write_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/lang/String;[Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_Ljava_lang_String_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (native_p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/lang/String;[Ljava/lang/Object;)V"), new JValue (native_p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_writeBitmap_Ljava_lang_String_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetWriteBitmap_Ljava_lang_String_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_writeBitmap_Ljava_lang_String_Landroid_graphics_Bitmap_ == null)
					cb_writeBitmap_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteBitmap_Ljava_lang_String_Landroid_graphics_Bitmap_);
				return cb_writeBitmap_Ljava_lang_String_Landroid_graphics_Bitmap_;
			}

			static void n_WriteBitmap_Ljava_lang_String_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Xamarin.FacebookBinding.Request.Serializer __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request.Serializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.WriteBitmap (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_writeBitmap_Ljava_lang_String_Landroid_graphics_Bitmap_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request.Serializer']/method[@name='writeBitmap' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap']]"
			[Register ("writeBitmap", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V", "GetWriteBitmap_Ljava_lang_String_Landroid_graphics_Bitmap_Handler")]
			public virtual void WriteBitmap (string p0, global::Android.Graphics.Bitmap p1)
			{
				if (id_writeBitmap_Ljava_lang_String_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_writeBitmap_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "writeBitmap", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeBitmap_Ljava_lang_String_Landroid_graphics_Bitmap_, new JValue (native_p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeBitmap", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V"), new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_writeBytes_Ljava_lang_String_arrayB;
#pragma warning disable 0169
			static Delegate GetWriteBytes_Ljava_lang_String_arrayBHandler ()
			{
				if (cb_writeBytes_Ljava_lang_String_arrayB == null)
					cb_writeBytes_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteBytes_Ljava_lang_String_arrayB);
				return cb_writeBytes_Ljava_lang_String_arrayB;
			}

			static void n_WriteBytes_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Xamarin.FacebookBinding.Request.Serializer __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request.Serializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.WriteBytes (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
			}
#pragma warning restore 0169

			static IntPtr id_writeBytes_Ljava_lang_String_arrayB;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request.Serializer']/method[@name='writeBytes' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
			[Register ("writeBytes", "(Ljava/lang/String;[B)V", "GetWriteBytes_Ljava_lang_String_arrayBHandler")]
			public virtual void WriteBytes (string p0, byte[] p1)
			{
				if (id_writeBytes_Ljava_lang_String_arrayB == IntPtr.Zero)
					id_writeBytes_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "writeBytes", "(Ljava/lang/String;[B)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeBytes_Ljava_lang_String_arrayB, new JValue (native_p0), new JValue (native_p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeBytes", "(Ljava/lang/String;[B)V"), new JValue (native_p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_writeContentDisposition_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWriteContentDisposition_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_writeContentDisposition_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_writeContentDisposition_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteContentDisposition_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
				return cb_writeContentDisposition_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
			}

			static void n_WriteContentDisposition_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Xamarin.FacebookBinding.Request.Serializer __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request.Serializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.WriteContentDisposition (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_writeContentDisposition_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request.Serializer']/method[@name='writeContentDisposition' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("writeContentDisposition", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetWriteContentDisposition_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual void WriteContentDisposition (string p0, string p1, string p2)
			{
				if (id_writeContentDisposition_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_writeContentDisposition_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "writeContentDisposition", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeContentDisposition_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeContentDisposition", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}

			static Delegate cb_writeFile_Ljava_lang_String_Landroid_os_ParcelFileDescriptor_;
#pragma warning disable 0169
			static Delegate GetWriteFile_Ljava_lang_String_Landroid_os_ParcelFileDescriptor_Handler ()
			{
				if (cb_writeFile_Ljava_lang_String_Landroid_os_ParcelFileDescriptor_ == null)
					cb_writeFile_Ljava_lang_String_Landroid_os_ParcelFileDescriptor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteFile_Ljava_lang_String_Landroid_os_ParcelFileDescriptor_);
				return cb_writeFile_Ljava_lang_String_Landroid_os_ParcelFileDescriptor_;
			}

			static void n_WriteFile_Ljava_lang_String_Landroid_os_ParcelFileDescriptor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Xamarin.FacebookBinding.Request.Serializer __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request.Serializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.ParcelFileDescriptor p1 = global::Java.Lang.Object.GetObject<global::Android.OS.ParcelFileDescriptor> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.WriteFile (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_writeFile_Ljava_lang_String_Landroid_os_ParcelFileDescriptor_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request.Serializer']/method[@name='writeFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.ParcelFileDescriptor']]"
			[Register ("writeFile", "(Ljava/lang/String;Landroid/os/ParcelFileDescriptor;)V", "GetWriteFile_Ljava_lang_String_Landroid_os_ParcelFileDescriptor_Handler")]
			public virtual void WriteFile (string p0, global::Android.OS.ParcelFileDescriptor p1)
			{
				if (id_writeFile_Ljava_lang_String_Landroid_os_ParcelFileDescriptor_ == IntPtr.Zero)
					id_writeFile_Ljava_lang_String_Landroid_os_ParcelFileDescriptor_ = JNIEnv.GetMethodID (class_ref, "writeFile", "(Ljava/lang/String;Landroid/os/ParcelFileDescriptor;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeFile_Ljava_lang_String_Landroid_os_ParcelFileDescriptor_, new JValue (native_p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeFile", "(Ljava/lang/String;Landroid/os/ParcelFileDescriptor;)V"), new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_writeLine_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetWriteLine_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
			{
				if (cb_writeLine_Ljava_lang_String_arrayLjava_lang_Object_ == null)
					cb_writeLine_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteLine_Ljava_lang_String_arrayLjava_lang_Object_);
				return cb_writeLine_Ljava_lang_String_arrayLjava_lang_Object_;
			}

			static void n_WriteLine_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Xamarin.FacebookBinding.Request.Serializer __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request.Serializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object[] p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				__this.WriteLine (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
			}
#pragma warning restore 0169

			static IntPtr id_writeLine_Ljava_lang_String_arrayLjava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request.Serializer']/method[@name='writeLine' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
			[Register ("writeLine", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetWriteLine_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
			public virtual void WriteLine (string p0, params global:: Java.Lang.Object[] p1)
			{
				if (id_writeLine_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_writeLine_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "writeLine", "(Ljava/lang/String;[Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeLine_Ljava_lang_String_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (native_p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeLine", "(Ljava/lang/String;[Ljava/lang/Object;)V"), new JValue (native_p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_writeObject_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetWriteObject_Ljava_lang_String_Ljava_lang_Object_Handler ()
			{
				if (cb_writeObject_Ljava_lang_String_Ljava_lang_Object_ == null)
					cb_writeObject_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteObject_Ljava_lang_String_Ljava_lang_Object_);
				return cb_writeObject_Ljava_lang_String_Ljava_lang_Object_;
			}

			static void n_WriteObject_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Xamarin.FacebookBinding.Request.Serializer __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request.Serializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.WriteObject (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_writeObject_Ljava_lang_String_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request.Serializer']/method[@name='writeObject' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
			[Register ("writeObject", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetWriteObject_Ljava_lang_String_Ljava_lang_Object_Handler")]
			public virtual void WriteObject (string p0, global::Java.Lang.Object p1)
			{
				if (id_writeObject_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
					id_writeObject_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "writeObject", "(Ljava/lang/String;Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeObject_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeObject", "(Ljava/lang/String;Ljava/lang/Object;)V"), new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_writeRecordBoundary;
#pragma warning disable 0169
			static Delegate GetWriteRecordBoundaryHandler ()
			{
				if (cb_writeRecordBoundary == null)
					cb_writeRecordBoundary = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WriteRecordBoundary);
				return cb_writeRecordBoundary;
			}

			static void n_WriteRecordBoundary (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.Request.Serializer __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request.Serializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.WriteRecordBoundary ();
			}
#pragma warning restore 0169

			static IntPtr id_writeRecordBoundary;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request.Serializer']/method[@name='writeRecordBoundary' and count(parameter)=0]"
			[Register ("writeRecordBoundary", "()V", "GetWriteRecordBoundaryHandler")]
			public virtual void WriteRecordBoundary ()
			{
				if (id_writeRecordBoundary == IntPtr.Zero)
					id_writeRecordBoundary = JNIEnv.GetMethodID (class_ref, "writeRecordBoundary", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeRecordBoundary);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeRecordBoundary", "()V"));
			}

			static Delegate cb_writeString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWriteString_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_writeString_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_writeString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteString_Ljava_lang_String_Ljava_lang_String_);
				return cb_writeString_Ljava_lang_String_Ljava_lang_String_;
			}

			static void n_WriteString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Xamarin.FacebookBinding.Request.Serializer __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request.Serializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.WriteString (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_writeString_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request.Serializer']/method[@name='writeString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("writeString", "(Ljava/lang/String;Ljava/lang/String;)V", "GetWriteString_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual void WriteString (string p0, string p1)
			{
				if (id_writeString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_writeString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "writeString", "(Ljava/lang/String;Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeString_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeString", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/Request", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Request); }
		}

		protected Request (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_facebook_Session_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='Request']/constructor[@name='Request' and count(parameter)=2 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/facebook/Session;Ljava/lang/String;)V", "")]
		public Request (global::Xamarin.FacebookBinding.Session p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (Request)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/facebook/Session;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/facebook/Session;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Lcom_facebook_Session_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Lcom_facebook_Session_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/Session;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_Session_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_facebook_Session_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='Request']/constructor[@name='Request' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Request () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Request)) {
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

		static IntPtr id_ctor_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_HttpMethod_Lcom_facebook_Request_Callback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='Request']/constructor[@name='Request' and count(parameter)=5 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='com.facebook.HttpMethod'] and parameter[5][@type='com.facebook.Request.Callback']]"
		[Register (".ctor", "(Lcom/facebook/Session;Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/HttpMethod;Lcom/facebook/Request$Callback;)V", "")]
		public Request (global::Xamarin.FacebookBinding.Session p0, string p1, global::Android.OS.Bundle p2, global::Xamarin.FacebookBinding.HttpMethod p3, global::Xamarin.FacebookBinding.Request.ICallback p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (Request)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/facebook/Session;Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/HttpMethod;Lcom/facebook/Request$Callback;)V", new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/facebook/Session;Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/HttpMethod;Lcom/facebook/Request$Callback;)V", new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_HttpMethod_Lcom_facebook_Request_Callback_ == IntPtr.Zero)
				id_ctor_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_HttpMethod_Lcom_facebook_Request_Callback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/Session;Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/HttpMethod;Lcom/facebook/Request$Callback;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_HttpMethod_Lcom_facebook_Request_Callback_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_HttpMethod_Lcom_facebook_Request_Callback_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_HttpMethod_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='Request']/constructor[@name='Request' and count(parameter)=4 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='com.facebook.HttpMethod']]"
		[Register (".ctor", "(Lcom/facebook/Session;Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/HttpMethod;)V", "")]
		public Request (global::Xamarin.FacebookBinding.Session p0, string p1, global::Android.OS.Bundle p2, global::Xamarin.FacebookBinding.HttpMethod p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (Request)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/facebook/Session;Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/HttpMethod;)V", new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/facebook/Session;Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/HttpMethod;)V", new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_HttpMethod_ == IntPtr.Zero)
				id_ctor_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_HttpMethod_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/Session;Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/HttpMethod;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_HttpMethod_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_HttpMethod_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_getBatchEntryDependsOn;
		static IntPtr id_setBatchEntryDependsOn_Ljava_lang_String_;
		public string BatchEntryDependsOn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='getBatchEntryDependsOn' and count(parameter)=0]"
			[Register ("getBatchEntryDependsOn", "()Ljava/lang/String;", "GetGetBatchEntryDependsOnHandler")]
			get {
				if (id_getBatchEntryDependsOn == IntPtr.Zero)
					id_getBatchEntryDependsOn = JNIEnv.GetMethodID (class_ref, "getBatchEntryDependsOn", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getBatchEntryDependsOn), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='setBatchEntryDependsOn' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBatchEntryDependsOn", "(Ljava/lang/String;)V", "GetSetBatchEntryDependsOn_Ljava_lang_String_Handler")]
			set {
				if (id_setBatchEntryDependsOn_Ljava_lang_String_ == IntPtr.Zero)
					id_setBatchEntryDependsOn_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBatchEntryDependsOn", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setBatchEntryDependsOn_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getBatchEntryName;
		static IntPtr id_setBatchEntryName_Ljava_lang_String_;
		public string BatchEntryName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='getBatchEntryName' and count(parameter)=0]"
			[Register ("getBatchEntryName", "()Ljava/lang/String;", "GetGetBatchEntryNameHandler")]
			get {
				if (id_getBatchEntryName == IntPtr.Zero)
					id_getBatchEntryName = JNIEnv.GetMethodID (class_ref, "getBatchEntryName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getBatchEntryName), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='setBatchEntryName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBatchEntryName", "(Ljava/lang/String;)V", "GetSetBatchEntryName_Ljava_lang_String_Handler")]
			set {
				if (id_setBatchEntryName_Ljava_lang_String_ == IntPtr.Zero)
					id_setBatchEntryName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBatchEntryName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setBatchEntryName_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getBatchEntryOmitResultOnSuccess;
		static IntPtr id_setBatchEntryOmitResultOnSuccess_Z;
		public bool BatchEntryOmitResultOnSuccess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='getBatchEntryOmitResultOnSuccess' and count(parameter)=0]"
			[Register ("getBatchEntryOmitResultOnSuccess", "()Z", "GetGetBatchEntryOmitResultOnSuccessHandler")]
			get {
				if (id_getBatchEntryOmitResultOnSuccess == IntPtr.Zero)
					id_getBatchEntryOmitResultOnSuccess = JNIEnv.GetMethodID (class_ref, "getBatchEntryOmitResultOnSuccess", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_getBatchEntryOmitResultOnSuccess);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='setBatchEntryOmitResultOnSuccess' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setBatchEntryOmitResultOnSuccess", "(Z)V", "GetSetBatchEntryOmitResultOnSuccess_ZHandler")]
			set {
				if (id_setBatchEntryOmitResultOnSuccess_Z == IntPtr.Zero)
					id_setBatchEntryOmitResultOnSuccess_Z = JNIEnv.GetMethodID (class_ref, "setBatchEntryOmitResultOnSuccess", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setBatchEntryOmitResultOnSuccess_Z, new JValue (value));
			}
		}

		static IntPtr id_getCallback;
		static IntPtr id_setCallback_Lcom_facebook_Request_Callback_;
		public global::Xamarin.FacebookBinding.Request.ICallback Callback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='getCallback' and count(parameter)=0]"
			[Register ("getCallback", "()Lcom/facebook/Request$Callback;", "GetGetCallbackHandler")]
			get {
				if (id_getCallback == IntPtr.Zero)
					id_getCallback = JNIEnv.GetMethodID (class_ref, "getCallback", "()Lcom/facebook/Request$Callback;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request.ICallback> (JNIEnv.CallObjectMethod  (Handle, id_getCallback), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.facebook.Request.Callback']]"
			[Register ("setCallback", "(Lcom/facebook/Request$Callback;)V", "GetSetCallback_Lcom_facebook_Request_Callback_Handler")]
			set {
				if (id_setCallback_Lcom_facebook_Request_Callback_ == IntPtr.Zero)
					id_setCallback_Lcom_facebook_Request_Callback_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lcom/facebook/Request$Callback;)V");
				JNIEnv.CallVoidMethod  (Handle, id_setCallback_Lcom_facebook_Request_Callback_, new JValue (value));
			}
		}

		static IntPtr id_getDefaultBatchApplicationId;
		static IntPtr id_setDefaultBatchApplicationId_Ljava_lang_String_;
		public static string DefaultBatchApplicationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='getDefaultBatchApplicationId' and count(parameter)=0]"
			[Register ("getDefaultBatchApplicationId", "()Ljava/lang/String;", "GetGetDefaultBatchApplicationIdHandler")]
			get {
				if (id_getDefaultBatchApplicationId == IntPtr.Zero)
					id_getDefaultBatchApplicationId = JNIEnv.GetStaticMethodID (class_ref, "getDefaultBatchApplicationId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultBatchApplicationId), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='setDefaultBatchApplicationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDefaultBatchApplicationId", "(Ljava/lang/String;)V", "GetSetDefaultBatchApplicationId_Ljava_lang_String_Handler")]
			set {
				if (id_setDefaultBatchApplicationId_Ljava_lang_String_ == IntPtr.Zero)
					id_setDefaultBatchApplicationId_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setDefaultBatchApplicationId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setDefaultBatchApplicationId_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getGraphObject;
		static IntPtr id_setGraphObject_Lcom_facebook_model_GraphObject_;
		public global::Xamarin.FacebookBinding.Model.IGraphObject GraphObject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='getGraphObject' and count(parameter)=0]"
			[Register ("getGraphObject", "()Lcom/facebook/model/GraphObject;", "GetGetGraphObjectHandler")]
			get {
				if (id_getGraphObject == IntPtr.Zero)
					id_getGraphObject = JNIEnv.GetMethodID (class_ref, "getGraphObject", "()Lcom/facebook/model/GraphObject;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObject> (JNIEnv.CallObjectMethod  (Handle, id_getGraphObject), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='setGraphObject' and count(parameter)=1 and parameter[1][@type='com.facebook.model.GraphObject']]"
			[Register ("setGraphObject", "(Lcom/facebook/model/GraphObject;)V", "GetSetGraphObject_Lcom_facebook_model_GraphObject_Handler")]
			set {
				if (id_setGraphObject_Lcom_facebook_model_GraphObject_ == IntPtr.Zero)
					id_setGraphObject_Lcom_facebook_model_GraphObject_ = JNIEnv.GetMethodID (class_ref, "setGraphObject", "(Lcom/facebook/model/GraphObject;)V");
				JNIEnv.CallVoidMethod  (Handle, id_setGraphObject_Lcom_facebook_model_GraphObject_, new JValue (value));
			}
		}

		static IntPtr id_getGraphPath;
		static IntPtr id_setGraphPath_Ljava_lang_String_;
		public string GraphPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='getGraphPath' and count(parameter)=0]"
			[Register ("getGraphPath", "()Ljava/lang/String;", "GetGetGraphPathHandler")]
			get {
				if (id_getGraphPath == IntPtr.Zero)
					id_getGraphPath = JNIEnv.GetMethodID (class_ref, "getGraphPath", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getGraphPath), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='setGraphPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setGraphPath", "(Ljava/lang/String;)V", "GetSetGraphPath_Ljava_lang_String_Handler")]
			set {
				if (id_setGraphPath_Ljava_lang_String_ == IntPtr.Zero)
					id_setGraphPath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGraphPath", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setGraphPath_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getHttpMethod;
		static IntPtr id_setHttpMethod_Lcom_facebook_HttpMethod_;
		public global::Xamarin.FacebookBinding.HttpMethod HttpMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='getHttpMethod' and count(parameter)=0]"
			[Register ("getHttpMethod", "()Lcom/facebook/HttpMethod;", "GetGetHttpMethodHandler")]
			get {
				if (id_getHttpMethod == IntPtr.Zero)
					id_getHttpMethod = JNIEnv.GetMethodID (class_ref, "getHttpMethod", "()Lcom/facebook/HttpMethod;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.HttpMethod> (JNIEnv.CallObjectMethod  (Handle, id_getHttpMethod), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='setHttpMethod' and count(parameter)=1 and parameter[1][@type='com.facebook.HttpMethod']]"
			[Register ("setHttpMethod", "(Lcom/facebook/HttpMethod;)V", "GetSetHttpMethod_Lcom_facebook_HttpMethod_Handler")]
			set {
				if (id_setHttpMethod_Lcom_facebook_HttpMethod_ == IntPtr.Zero)
					id_setHttpMethod_Lcom_facebook_HttpMethod_ = JNIEnv.GetMethodID (class_ref, "setHttpMethod", "(Lcom/facebook/HttpMethod;)V");
				JNIEnv.CallVoidMethod  (Handle, id_setHttpMethod_Lcom_facebook_HttpMethod_, new JValue (value));
			}
		}

		static IntPtr id_getParameters;
		static IntPtr id_setParameters_Landroid_os_Bundle_;
		public global::Android.OS.Bundle Parameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='getParameters' and count(parameter)=0]"
			[Register ("getParameters", "()Landroid/os/Bundle;", "GetGetParametersHandler")]
			get {
				if (id_getParameters == IntPtr.Zero)
					id_getParameters = JNIEnv.GetMethodID (class_ref, "getParameters", "()Landroid/os/Bundle;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_getParameters), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='setParameters' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("setParameters", "(Landroid/os/Bundle;)V", "GetSetParameters_Landroid_os_Bundle_Handler")]
			set {
				if (id_setParameters_Landroid_os_Bundle_ == IntPtr.Zero)
					id_setParameters_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "setParameters", "(Landroid/os/Bundle;)V");
				JNIEnv.CallVoidMethod  (Handle, id_setParameters_Landroid_os_Bundle_, new JValue (value));
			}
		}

		static IntPtr id_getRestMethod;
		static IntPtr id_setRestMethod_Ljava_lang_String_;
		public string RestMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='getRestMethod' and count(parameter)=0]"
			[Register ("getRestMethod", "()Ljava/lang/String;", "GetGetRestMethodHandler")]
			get {
				if (id_getRestMethod == IntPtr.Zero)
					id_getRestMethod = JNIEnv.GetMethodID (class_ref, "getRestMethod", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRestMethod), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='setRestMethod' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRestMethod", "(Ljava/lang/String;)V", "GetSetRestMethod_Ljava_lang_String_Handler")]
			set {
				if (id_setRestMethod_Ljava_lang_String_ == IntPtr.Zero)
					id_setRestMethod_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRestMethod", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setRestMethod_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getSession;
		static IntPtr id_setSession_Lcom_facebook_Session_;
		public global::Xamarin.FacebookBinding.Session Session {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='getSession' and count(parameter)=0]"
			[Register ("getSession", "()Lcom/facebook/Session;", "GetGetSessionHandler")]
			get {
				if (id_getSession == IntPtr.Zero)
					id_getSession = JNIEnv.GetMethodID (class_ref, "getSession", "()Lcom/facebook/Session;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (JNIEnv.CallObjectMethod  (Handle, id_getSession), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='setSession' and count(parameter)=1 and parameter[1][@type='com.facebook.Session']]"
			[Register ("setSession", "(Lcom/facebook/Session;)V", "GetSetSession_Lcom_facebook_Session_Handler")]
			set {
				if (id_setSession_Lcom_facebook_Session_ == IntPtr.Zero)
					id_setSession_Lcom_facebook_Session_ = JNIEnv.GetMethodID (class_ref, "setSession", "(Lcom/facebook/Session;)V");
				JNIEnv.CallVoidMethod  (Handle, id_setSession_Lcom_facebook_Session_, new JValue (value));
			}
		}

		static IntPtr id_executeAndWait;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='executeAndWait' and count(parameter)=0]"
		[Register ("executeAndWait", "()Lcom/facebook/Response;", "")]
		public global::Xamarin.FacebookBinding.Response ExecuteAndWait ()
		{
			if (id_executeAndWait == IntPtr.Zero)
				id_executeAndWait = JNIEnv.GetMethodID (class_ref, "executeAndWait", "()Lcom/facebook/Response;");
			return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response> (JNIEnv.CallObjectMethod  (Handle, id_executeAndWait), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_executeAndWait_Lcom_facebook_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='executeAndWait' and count(parameter)=1 and parameter[1][@type='com.facebook.Request']]"
		[Register ("executeAndWait", "(Lcom/facebook/Request;)Lcom/facebook/Response;", "")]
		public static global::Xamarin.FacebookBinding.Response ExecuteAndWait (global::Xamarin.FacebookBinding.Request p0)
		{
			if (id_executeAndWait_Lcom_facebook_Request_ == IntPtr.Zero)
				id_executeAndWait_Lcom_facebook_Request_ = JNIEnv.GetStaticMethodID (class_ref, "executeAndWait", "(Lcom/facebook/Request;)Lcom/facebook/Response;");
			global::Xamarin.FacebookBinding.Response __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response> (JNIEnv.CallStaticObjectMethod  (class_ref, id_executeAndWait_Lcom_facebook_Request_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_executeAsync;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='executeAsync' and count(parameter)=0]"
		[Register ("executeAsync", "()Lcom/facebook/RequestAsyncTask;", "")]
		public global::Xamarin.FacebookBinding.RequestAsyncTask ExecuteAsync ()
		{
			if (id_executeAsync == IntPtr.Zero)
				id_executeAsync = JNIEnv.GetMethodID (class_ref, "executeAsync", "()Lcom/facebook/RequestAsyncTask;");
			return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestAsyncTask> (JNIEnv.CallObjectMethod  (Handle, id_executeAsync), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_executeBatchAndWait_Lcom_facebook_RequestBatch_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='executeBatchAndWait' and count(parameter)=1 and parameter[1][@type='com.facebook.RequestBatch']]"
		[Register ("executeBatchAndWait", "(Lcom/facebook/RequestBatch;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Xamarin.FacebookBinding.Response> ExecuteBatchAndWait (global::Xamarin.FacebookBinding.RequestBatch p0)
		{
			if (id_executeBatchAndWait_Lcom_facebook_RequestBatch_ == IntPtr.Zero)
				id_executeBatchAndWait_Lcom_facebook_RequestBatch_ = JNIEnv.GetStaticMethodID (class_ref, "executeBatchAndWait", "(Lcom/facebook/RequestBatch;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Xamarin.FacebookBinding.Response> __ret = global::Android.Runtime.JavaList<global::Xamarin.FacebookBinding.Response>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_executeBatchAndWait_Lcom_facebook_RequestBatch_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_executeBatchAndWait_arrayLcom_facebook_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='executeBatchAndWait' and count(parameter)=1 and parameter[1][@type='com.facebook.Request...']]"
		[Register ("executeBatchAndWait", "([Lcom/facebook/Request;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Xamarin.FacebookBinding.Response> ExecuteBatchAndWait (params global:: Xamarin.FacebookBinding.Request[] p0)
		{
			if (id_executeBatchAndWait_arrayLcom_facebook_Request_ == IntPtr.Zero)
				id_executeBatchAndWait_arrayLcom_facebook_Request_ = JNIEnv.GetStaticMethodID (class_ref, "executeBatchAndWait", "([Lcom/facebook/Request;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::System.Collections.Generic.IList<global::Xamarin.FacebookBinding.Response> __ret = global::Android.Runtime.JavaList<global::Xamarin.FacebookBinding.Response>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_executeBatchAndWait_arrayLcom_facebook_Request_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_executeBatchAndWait_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='executeBatchAndWait' and count(parameter)=1 and parameter[1][@type='java.util.Collection']]"
		[Register ("executeBatchAndWait", "(Ljava/util/Collection;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Xamarin.FacebookBinding.Response> ExecuteBatchAndWait (global::System.Collections.Generic.ICollection<global::Xamarin.FacebookBinding.Request> p0)
		{
			if (id_executeBatchAndWait_Ljava_util_Collection_ == IntPtr.Zero)
				id_executeBatchAndWait_Ljava_util_Collection_ = JNIEnv.GetStaticMethodID (class_ref, "executeBatchAndWait", "(Ljava/util/Collection;)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection<global::Xamarin.FacebookBinding.Request>.ToLocalJniHandle (p0);
			global::System.Collections.Generic.IList<global::Xamarin.FacebookBinding.Response> __ret = global::Android.Runtime.JavaList<global::Xamarin.FacebookBinding.Response>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_executeBatchAndWait_Ljava_util_Collection_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_executeBatchAsync_Lcom_facebook_RequestBatch_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='executeBatchAsync' and count(parameter)=1 and parameter[1][@type='com.facebook.RequestBatch']]"
		[Register ("executeBatchAsync", "(Lcom/facebook/RequestBatch;)Lcom/facebook/RequestAsyncTask;", "")]
		public static global::Xamarin.FacebookBinding.RequestAsyncTask ExecuteBatchAsync (global::Xamarin.FacebookBinding.RequestBatch p0)
		{
			if (id_executeBatchAsync_Lcom_facebook_RequestBatch_ == IntPtr.Zero)
				id_executeBatchAsync_Lcom_facebook_RequestBatch_ = JNIEnv.GetStaticMethodID (class_ref, "executeBatchAsync", "(Lcom/facebook/RequestBatch;)Lcom/facebook/RequestAsyncTask;");
			global::Xamarin.FacebookBinding.RequestAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestAsyncTask> (JNIEnv.CallStaticObjectMethod  (class_ref, id_executeBatchAsync_Lcom_facebook_RequestBatch_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_executeBatchAsync_arrayLcom_facebook_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='executeBatchAsync' and count(parameter)=1 and parameter[1][@type='com.facebook.Request...']]"
		[Register ("executeBatchAsync", "([Lcom/facebook/Request;)Lcom/facebook/RequestAsyncTask;", "")]
		public static global::Xamarin.FacebookBinding.RequestAsyncTask ExecuteBatchAsync (params global:: Xamarin.FacebookBinding.Request[] p0)
		{
			if (id_executeBatchAsync_arrayLcom_facebook_Request_ == IntPtr.Zero)
				id_executeBatchAsync_arrayLcom_facebook_Request_ = JNIEnv.GetStaticMethodID (class_ref, "executeBatchAsync", "([Lcom/facebook/Request;)Lcom/facebook/RequestAsyncTask;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Xamarin.FacebookBinding.RequestAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestAsyncTask> (JNIEnv.CallStaticObjectMethod  (class_ref, id_executeBatchAsync_arrayLcom_facebook_Request_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_executeBatchAsync_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='executeBatchAsync' and count(parameter)=1 and parameter[1][@type='java.util.Collection']]"
		[Register ("executeBatchAsync", "(Ljava/util/Collection;)Lcom/facebook/RequestAsyncTask;", "")]
		public static global::Xamarin.FacebookBinding.RequestAsyncTask ExecuteBatchAsync (global::System.Collections.Generic.ICollection<global::Xamarin.FacebookBinding.Request> p0)
		{
			if (id_executeBatchAsync_Ljava_util_Collection_ == IntPtr.Zero)
				id_executeBatchAsync_Ljava_util_Collection_ = JNIEnv.GetStaticMethodID (class_ref, "executeBatchAsync", "(Ljava/util/Collection;)Lcom/facebook/RequestAsyncTask;");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection<global::Xamarin.FacebookBinding.Request>.ToLocalJniHandle (p0);
			global::Xamarin.FacebookBinding.RequestAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestAsyncTask> (JNIEnv.CallStaticObjectMethod  (class_ref, id_executeBatchAsync_Ljava_util_Collection_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_executeConnectionAndWait_Ljava_net_HttpURLConnection_Lcom_facebook_RequestBatch_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='executeConnectionAndWait' and count(parameter)=2 and parameter[1][@type='java.net.HttpURLConnection'] and parameter[2][@type='com.facebook.RequestBatch']]"
		[Register ("executeConnectionAndWait", "(Ljava/net/HttpURLConnection;Lcom/facebook/RequestBatch;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Xamarin.FacebookBinding.Response> ExecuteConnectionAndWait (global::Java.Net.HttpURLConnection p0, global::Xamarin.FacebookBinding.RequestBatch p1)
		{
			if (id_executeConnectionAndWait_Ljava_net_HttpURLConnection_Lcom_facebook_RequestBatch_ == IntPtr.Zero)
				id_executeConnectionAndWait_Ljava_net_HttpURLConnection_Lcom_facebook_RequestBatch_ = JNIEnv.GetStaticMethodID (class_ref, "executeConnectionAndWait", "(Ljava/net/HttpURLConnection;Lcom/facebook/RequestBatch;)Ljava/util/List;");
			global::System.Collections.Generic.IList<global::Xamarin.FacebookBinding.Response> __ret = global::Android.Runtime.JavaList<global::Xamarin.FacebookBinding.Response>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_executeConnectionAndWait_Ljava_net_HttpURLConnection_Lcom_facebook_RequestBatch_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_executeConnectionAndWait_Ljava_net_HttpURLConnection_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='executeConnectionAndWait' and count(parameter)=2 and parameter[1][@type='java.net.HttpURLConnection'] and parameter[2][@type='java.util.Collection']]"
		[Register ("executeConnectionAndWait", "(Ljava/net/HttpURLConnection;Ljava/util/Collection;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Xamarin.FacebookBinding.Response> ExecuteConnectionAndWait (global::Java.Net.HttpURLConnection p0, global::System.Collections.Generic.ICollection<global::Xamarin.FacebookBinding.Request> p1)
		{
			if (id_executeConnectionAndWait_Ljava_net_HttpURLConnection_Ljava_util_Collection_ == IntPtr.Zero)
				id_executeConnectionAndWait_Ljava_net_HttpURLConnection_Ljava_util_Collection_ = JNIEnv.GetStaticMethodID (class_ref, "executeConnectionAndWait", "(Ljava/net/HttpURLConnection;Ljava/util/Collection;)Ljava/util/List;");
			IntPtr native_p1 = global::Android.Runtime.JavaCollection<global::Xamarin.FacebookBinding.Request>.ToLocalJniHandle (p1);
			global::System.Collections.Generic.IList<global::Xamarin.FacebookBinding.Response> __ret = global::Android.Runtime.JavaList<global::Xamarin.FacebookBinding.Response>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_executeConnectionAndWait_Ljava_net_HttpURLConnection_Ljava_util_Collection_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_executeConnectionAsync_Landroid_os_Handler_Ljava_net_HttpURLConnection_Lcom_facebook_RequestBatch_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='executeConnectionAsync' and count(parameter)=3 and parameter[1][@type='android.os.Handler'] and parameter[2][@type='java.net.HttpURLConnection'] and parameter[3][@type='com.facebook.RequestBatch']]"
		[Register ("executeConnectionAsync", "(Landroid/os/Handler;Ljava/net/HttpURLConnection;Lcom/facebook/RequestBatch;)Lcom/facebook/RequestAsyncTask;", "")]
		public static global::Xamarin.FacebookBinding.RequestAsyncTask ExecuteConnectionAsync (global::Android.OS.Handler p0, global::Java.Net.HttpURLConnection p1, global::Xamarin.FacebookBinding.RequestBatch p2)
		{
			if (id_executeConnectionAsync_Landroid_os_Handler_Ljava_net_HttpURLConnection_Lcom_facebook_RequestBatch_ == IntPtr.Zero)
				id_executeConnectionAsync_Landroid_os_Handler_Ljava_net_HttpURLConnection_Lcom_facebook_RequestBatch_ = JNIEnv.GetStaticMethodID (class_ref, "executeConnectionAsync", "(Landroid/os/Handler;Ljava/net/HttpURLConnection;Lcom/facebook/RequestBatch;)Lcom/facebook/RequestAsyncTask;");
			global::Xamarin.FacebookBinding.RequestAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestAsyncTask> (JNIEnv.CallStaticObjectMethod  (class_ref, id_executeConnectionAsync_Landroid_os_Handler_Ljava_net_HttpURLConnection_Lcom_facebook_RequestBatch_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_executeConnectionAsync_Ljava_net_HttpURLConnection_Lcom_facebook_RequestBatch_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='executeConnectionAsync' and count(parameter)=2 and parameter[1][@type='java.net.HttpURLConnection'] and parameter[2][@type='com.facebook.RequestBatch']]"
		[Register ("executeConnectionAsync", "(Ljava/net/HttpURLConnection;Lcom/facebook/RequestBatch;)Lcom/facebook/RequestAsyncTask;", "")]
		public static global::Xamarin.FacebookBinding.RequestAsyncTask ExecuteConnectionAsync (global::Java.Net.HttpURLConnection p0, global::Xamarin.FacebookBinding.RequestBatch p1)
		{
			if (id_executeConnectionAsync_Ljava_net_HttpURLConnection_Lcom_facebook_RequestBatch_ == IntPtr.Zero)
				id_executeConnectionAsync_Ljava_net_HttpURLConnection_Lcom_facebook_RequestBatch_ = JNIEnv.GetStaticMethodID (class_ref, "executeConnectionAsync", "(Ljava/net/HttpURLConnection;Lcom/facebook/RequestBatch;)Lcom/facebook/RequestAsyncTask;");
			global::Xamarin.FacebookBinding.RequestAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestAsyncTask> (JNIEnv.CallStaticObjectMethod  (class_ref, id_executeConnectionAsync_Ljava_net_HttpURLConnection_Lcom_facebook_RequestBatch_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_executeGraphPathRequestAsync_Lcom_facebook_Session_Ljava_lang_String_Lcom_facebook_Request_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='executeGraphPathRequestAsync' and count(parameter)=3 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.facebook.Request.Callback']]"
		[Register ("executeGraphPathRequestAsync", "(Lcom/facebook/Session;Ljava/lang/String;Lcom/facebook/Request$Callback;)Lcom/facebook/RequestAsyncTask;", "")]
		public static global::Xamarin.FacebookBinding.RequestAsyncTask ExecuteGraphPathRequestAsync (global::Xamarin.FacebookBinding.Session p0, string p1, global::Xamarin.FacebookBinding.Request.ICallback p2)
		{
			if (id_executeGraphPathRequestAsync_Lcom_facebook_Session_Ljava_lang_String_Lcom_facebook_Request_Callback_ == IntPtr.Zero)
				id_executeGraphPathRequestAsync_Lcom_facebook_Session_Ljava_lang_String_Lcom_facebook_Request_Callback_ = JNIEnv.GetStaticMethodID (class_ref, "executeGraphPathRequestAsync", "(Lcom/facebook/Session;Ljava/lang/String;Lcom/facebook/Request$Callback;)Lcom/facebook/RequestAsyncTask;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Xamarin.FacebookBinding.RequestAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestAsyncTask> (JNIEnv.CallStaticObjectMethod  (class_ref, id_executeGraphPathRequestAsync_Lcom_facebook_Session_Ljava_lang_String_Lcom_facebook_Request_Callback_, new JValue (p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_executeMeRequestAsync_Lcom_facebook_Session_Lcom_facebook_Request_GraphUserCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='executeMeRequestAsync' and count(parameter)=2 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='com.facebook.Request.GraphUserCallback']]"
		[Register ("executeMeRequestAsync", "(Lcom/facebook/Session;Lcom/facebook/Request$GraphUserCallback;)Lcom/facebook/RequestAsyncTask;", "")]
		public static global::Xamarin.FacebookBinding.RequestAsyncTask ExecuteMeRequestAsync (global::Xamarin.FacebookBinding.Session p0, global::Xamarin.FacebookBinding.Request.IGraphUserCallback p1)
		{
			if (id_executeMeRequestAsync_Lcom_facebook_Session_Lcom_facebook_Request_GraphUserCallback_ == IntPtr.Zero)
				id_executeMeRequestAsync_Lcom_facebook_Session_Lcom_facebook_Request_GraphUserCallback_ = JNIEnv.GetStaticMethodID (class_ref, "executeMeRequestAsync", "(Lcom/facebook/Session;Lcom/facebook/Request$GraphUserCallback;)Lcom/facebook/RequestAsyncTask;");
			global::Xamarin.FacebookBinding.RequestAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestAsyncTask> (JNIEnv.CallStaticObjectMethod  (class_ref, id_executeMeRequestAsync_Lcom_facebook_Session_Lcom_facebook_Request_GraphUserCallback_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_executeMyFriendsRequestAsync_Lcom_facebook_Session_Lcom_facebook_Request_GraphUserListCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='executeMyFriendsRequestAsync' and count(parameter)=2 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='com.facebook.Request.GraphUserListCallback']]"
		[Register ("executeMyFriendsRequestAsync", "(Lcom/facebook/Session;Lcom/facebook/Request$GraphUserListCallback;)Lcom/facebook/RequestAsyncTask;", "")]
		public static global::Xamarin.FacebookBinding.RequestAsyncTask ExecuteMyFriendsRequestAsync (global::Xamarin.FacebookBinding.Session p0, global::Xamarin.FacebookBinding.Request.IGraphUserListCallback p1)
		{
			if (id_executeMyFriendsRequestAsync_Lcom_facebook_Session_Lcom_facebook_Request_GraphUserListCallback_ == IntPtr.Zero)
				id_executeMyFriendsRequestAsync_Lcom_facebook_Session_Lcom_facebook_Request_GraphUserListCallback_ = JNIEnv.GetStaticMethodID (class_ref, "executeMyFriendsRequestAsync", "(Lcom/facebook/Session;Lcom/facebook/Request$GraphUserListCallback;)Lcom/facebook/RequestAsyncTask;");
			global::Xamarin.FacebookBinding.RequestAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestAsyncTask> (JNIEnv.CallStaticObjectMethod  (class_ref, id_executeMyFriendsRequestAsync_Lcom_facebook_Session_Lcom_facebook_Request_GraphUserListCallback_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_executePlacesSearchRequestAsync_Lcom_facebook_Session_Landroid_location_Location_IILjava_lang_String_Lcom_facebook_Request_GraphPlaceListCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='executePlacesSearchRequestAsync' and count(parameter)=6 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='android.location.Location'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.facebook.Request.GraphPlaceListCallback']]"
		[Register ("executePlacesSearchRequestAsync", "(Lcom/facebook/Session;Landroid/location/Location;IILjava/lang/String;Lcom/facebook/Request$GraphPlaceListCallback;)Lcom/facebook/RequestAsyncTask;", "")]
		public static global::Xamarin.FacebookBinding.RequestAsyncTask ExecutePlacesSearchRequestAsync (global::Xamarin.FacebookBinding.Session p0, global::Android.Locations.Location p1, int p2, int p3, string p4, global::Xamarin.FacebookBinding.Request.IGraphPlaceListCallback p5)
		{
			if (id_executePlacesSearchRequestAsync_Lcom_facebook_Session_Landroid_location_Location_IILjava_lang_String_Lcom_facebook_Request_GraphPlaceListCallback_ == IntPtr.Zero)
				id_executePlacesSearchRequestAsync_Lcom_facebook_Session_Landroid_location_Location_IILjava_lang_String_Lcom_facebook_Request_GraphPlaceListCallback_ = JNIEnv.GetStaticMethodID (class_ref, "executePlacesSearchRequestAsync", "(Lcom/facebook/Session;Landroid/location/Location;IILjava/lang/String;Lcom/facebook/Request$GraphPlaceListCallback;)Lcom/facebook/RequestAsyncTask;");
			IntPtr native_p4 = JNIEnv.NewString (p4);
			global::Xamarin.FacebookBinding.RequestAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestAsyncTask> (JNIEnv.CallStaticObjectMethod  (class_ref, id_executePlacesSearchRequestAsync_Lcom_facebook_Session_Landroid_location_Location_IILjava_lang_String_Lcom_facebook_Request_GraphPlaceListCallback_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (native_p4), new JValue (p5)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p4);
			return __ret;
		}

		static IntPtr id_executePostRequestAsync_Lcom_facebook_Session_Ljava_lang_String_Lcom_facebook_model_GraphObject_Lcom_facebook_Request_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='executePostRequestAsync' and count(parameter)=4 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.facebook.model.GraphObject'] and parameter[4][@type='com.facebook.Request.Callback']]"
		[Register ("executePostRequestAsync", "(Lcom/facebook/Session;Ljava/lang/String;Lcom/facebook/model/GraphObject;Lcom/facebook/Request$Callback;)Lcom/facebook/RequestAsyncTask;", "")]
		public static global::Xamarin.FacebookBinding.RequestAsyncTask ExecutePostRequestAsync (global::Xamarin.FacebookBinding.Session p0, string p1, global::Xamarin.FacebookBinding.Model.IGraphObject p2, global::Xamarin.FacebookBinding.Request.ICallback p3)
		{
			if (id_executePostRequestAsync_Lcom_facebook_Session_Ljava_lang_String_Lcom_facebook_model_GraphObject_Lcom_facebook_Request_Callback_ == IntPtr.Zero)
				id_executePostRequestAsync_Lcom_facebook_Session_Ljava_lang_String_Lcom_facebook_model_GraphObject_Lcom_facebook_Request_Callback_ = JNIEnv.GetStaticMethodID (class_ref, "executePostRequestAsync", "(Lcom/facebook/Session;Ljava/lang/String;Lcom/facebook/model/GraphObject;Lcom/facebook/Request$Callback;)Lcom/facebook/RequestAsyncTask;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Xamarin.FacebookBinding.RequestAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestAsyncTask> (JNIEnv.CallStaticObjectMethod  (class_ref, id_executePostRequestAsync_Lcom_facebook_Session_Ljava_lang_String_Lcom_facebook_model_GraphObject_Lcom_facebook_Request_Callback_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_executeRestRequestAsync_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_HttpMethod_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='executeRestRequestAsync' and count(parameter)=4 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='com.facebook.HttpMethod']]"
		[Register ("executeRestRequestAsync", "(Lcom/facebook/Session;Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/HttpMethod;)Lcom/facebook/RequestAsyncTask;", "")]
		public static global::Xamarin.FacebookBinding.RequestAsyncTask ExecuteRestRequestAsync (global::Xamarin.FacebookBinding.Session p0, string p1, global::Android.OS.Bundle p2, global::Xamarin.FacebookBinding.HttpMethod p3)
		{
			if (id_executeRestRequestAsync_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_HttpMethod_ == IntPtr.Zero)
				id_executeRestRequestAsync_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_HttpMethod_ = JNIEnv.GetStaticMethodID (class_ref, "executeRestRequestAsync", "(Lcom/facebook/Session;Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/HttpMethod;)Lcom/facebook/RequestAsyncTask;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Xamarin.FacebookBinding.RequestAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestAsyncTask> (JNIEnv.CallStaticObjectMethod  (class_ref, id_executeRestRequestAsync_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_HttpMethod_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_executeStatusUpdateRequestAsync_Lcom_facebook_Session_Ljava_lang_String_Lcom_facebook_Request_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='executeStatusUpdateRequestAsync' and count(parameter)=3 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.facebook.Request.Callback']]"
		[Register ("executeStatusUpdateRequestAsync", "(Lcom/facebook/Session;Ljava/lang/String;Lcom/facebook/Request$Callback;)Lcom/facebook/RequestAsyncTask;", "")]
		public static global::Xamarin.FacebookBinding.RequestAsyncTask ExecuteStatusUpdateRequestAsync (global::Xamarin.FacebookBinding.Session p0, string p1, global::Xamarin.FacebookBinding.Request.ICallback p2)
		{
			if (id_executeStatusUpdateRequestAsync_Lcom_facebook_Session_Ljava_lang_String_Lcom_facebook_Request_Callback_ == IntPtr.Zero)
				id_executeStatusUpdateRequestAsync_Lcom_facebook_Session_Ljava_lang_String_Lcom_facebook_Request_Callback_ = JNIEnv.GetStaticMethodID (class_ref, "executeStatusUpdateRequestAsync", "(Lcom/facebook/Session;Ljava/lang/String;Lcom/facebook/Request$Callback;)Lcom/facebook/RequestAsyncTask;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Xamarin.FacebookBinding.RequestAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestAsyncTask> (JNIEnv.CallStaticObjectMethod  (class_ref, id_executeStatusUpdateRequestAsync_Lcom_facebook_Session_Ljava_lang_String_Lcom_facebook_Request_Callback_, new JValue (p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_executeUploadPhotoRequestAsync_Lcom_facebook_Session_Landroid_graphics_Bitmap_Lcom_facebook_Request_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='executeUploadPhotoRequestAsync' and count(parameter)=3 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='com.facebook.Request.Callback']]"
		[Register ("executeUploadPhotoRequestAsync", "(Lcom/facebook/Session;Landroid/graphics/Bitmap;Lcom/facebook/Request$Callback;)Lcom/facebook/RequestAsyncTask;", "")]
		public static global::Xamarin.FacebookBinding.RequestAsyncTask ExecuteUploadPhotoRequestAsync (global::Xamarin.FacebookBinding.Session p0, global::Android.Graphics.Bitmap p1, global::Xamarin.FacebookBinding.Request.ICallback p2)
		{
			if (id_executeUploadPhotoRequestAsync_Lcom_facebook_Session_Landroid_graphics_Bitmap_Lcom_facebook_Request_Callback_ == IntPtr.Zero)
				id_executeUploadPhotoRequestAsync_Lcom_facebook_Session_Landroid_graphics_Bitmap_Lcom_facebook_Request_Callback_ = JNIEnv.GetStaticMethodID (class_ref, "executeUploadPhotoRequestAsync", "(Lcom/facebook/Session;Landroid/graphics/Bitmap;Lcom/facebook/Request$Callback;)Lcom/facebook/RequestAsyncTask;");
			global::Xamarin.FacebookBinding.RequestAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestAsyncTask> (JNIEnv.CallStaticObjectMethod  (class_ref, id_executeUploadPhotoRequestAsync_Lcom_facebook_Session_Landroid_graphics_Bitmap_Lcom_facebook_Request_Callback_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_executeUploadPhotoRequestAsync_Lcom_facebook_Session_Ljava_io_File_Lcom_facebook_Request_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='executeUploadPhotoRequestAsync' and count(parameter)=3 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='java.io.File'] and parameter[3][@type='com.facebook.Request.Callback']]"
		[Register ("executeUploadPhotoRequestAsync", "(Lcom/facebook/Session;Ljava/io/File;Lcom/facebook/Request$Callback;)Lcom/facebook/RequestAsyncTask;", "")]
		public static global::Xamarin.FacebookBinding.RequestAsyncTask ExecuteUploadPhotoRequestAsync (global::Xamarin.FacebookBinding.Session p0, global::Java.IO.File p1, global::Xamarin.FacebookBinding.Request.ICallback p2)
		{
			if (id_executeUploadPhotoRequestAsync_Lcom_facebook_Session_Ljava_io_File_Lcom_facebook_Request_Callback_ == IntPtr.Zero)
				id_executeUploadPhotoRequestAsync_Lcom_facebook_Session_Ljava_io_File_Lcom_facebook_Request_Callback_ = JNIEnv.GetStaticMethodID (class_ref, "executeUploadPhotoRequestAsync", "(Lcom/facebook/Session;Ljava/io/File;Lcom/facebook/Request$Callback;)Lcom/facebook/RequestAsyncTask;");
			global::Xamarin.FacebookBinding.RequestAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestAsyncTask> (JNIEnv.CallStaticObjectMethod  (class_ref, id_executeUploadPhotoRequestAsync_Lcom_facebook_Session_Ljava_io_File_Lcom_facebook_Request_Callback_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_newGraphPathRequest_Lcom_facebook_Session_Ljava_lang_String_Lcom_facebook_Request_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='newGraphPathRequest' and count(parameter)=3 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.facebook.Request.Callback']]"
		[Register ("newGraphPathRequest", "(Lcom/facebook/Session;Ljava/lang/String;Lcom/facebook/Request$Callback;)Lcom/facebook/Request;", "")]
		public static global::Xamarin.FacebookBinding.Request NewGraphPathRequest (global::Xamarin.FacebookBinding.Session p0, string p1, global::Xamarin.FacebookBinding.Request.ICallback p2)
		{
			if (id_newGraphPathRequest_Lcom_facebook_Session_Ljava_lang_String_Lcom_facebook_Request_Callback_ == IntPtr.Zero)
				id_newGraphPathRequest_Lcom_facebook_Session_Ljava_lang_String_Lcom_facebook_Request_Callback_ = JNIEnv.GetStaticMethodID (class_ref, "newGraphPathRequest", "(Lcom/facebook/Session;Ljava/lang/String;Lcom/facebook/Request$Callback;)Lcom/facebook/Request;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Xamarin.FacebookBinding.Request __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newGraphPathRequest_Lcom_facebook_Session_Ljava_lang_String_Lcom_facebook_Request_Callback_, new JValue (p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_newMeRequest_Lcom_facebook_Session_Lcom_facebook_Request_GraphUserCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='newMeRequest' and count(parameter)=2 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='com.facebook.Request.GraphUserCallback']]"
		[Register ("newMeRequest", "(Lcom/facebook/Session;Lcom/facebook/Request$GraphUserCallback;)Lcom/facebook/Request;", "")]
		public static global::Xamarin.FacebookBinding.Request NewMeRequest (global::Xamarin.FacebookBinding.Session p0, global::Xamarin.FacebookBinding.Request.IGraphUserCallback p1)
		{
			if (id_newMeRequest_Lcom_facebook_Session_Lcom_facebook_Request_GraphUserCallback_ == IntPtr.Zero)
				id_newMeRequest_Lcom_facebook_Session_Lcom_facebook_Request_GraphUserCallback_ = JNIEnv.GetStaticMethodID (class_ref, "newMeRequest", "(Lcom/facebook/Session;Lcom/facebook/Request$GraphUserCallback;)Lcom/facebook/Request;");
			global::Xamarin.FacebookBinding.Request __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newMeRequest_Lcom_facebook_Session_Lcom_facebook_Request_GraphUserCallback_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_newMyFriendsRequest_Lcom_facebook_Session_Lcom_facebook_Request_GraphUserListCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='newMyFriendsRequest' and count(parameter)=2 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='com.facebook.Request.GraphUserListCallback']]"
		[Register ("newMyFriendsRequest", "(Lcom/facebook/Session;Lcom/facebook/Request$GraphUserListCallback;)Lcom/facebook/Request;", "")]
		public static global::Xamarin.FacebookBinding.Request NewMyFriendsRequest (global::Xamarin.FacebookBinding.Session p0, global::Xamarin.FacebookBinding.Request.IGraphUserListCallback p1)
		{
			if (id_newMyFriendsRequest_Lcom_facebook_Session_Lcom_facebook_Request_GraphUserListCallback_ == IntPtr.Zero)
				id_newMyFriendsRequest_Lcom_facebook_Session_Lcom_facebook_Request_GraphUserListCallback_ = JNIEnv.GetStaticMethodID (class_ref, "newMyFriendsRequest", "(Lcom/facebook/Session;Lcom/facebook/Request$GraphUserListCallback;)Lcom/facebook/Request;");
			global::Xamarin.FacebookBinding.Request __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newMyFriendsRequest_Lcom_facebook_Session_Lcom_facebook_Request_GraphUserListCallback_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_newPlacesSearchRequest_Lcom_facebook_Session_Landroid_location_Location_IILjava_lang_String_Lcom_facebook_Request_GraphPlaceListCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='newPlacesSearchRequest' and count(parameter)=6 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='android.location.Location'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.facebook.Request.GraphPlaceListCallback']]"
		[Register ("newPlacesSearchRequest", "(Lcom/facebook/Session;Landroid/location/Location;IILjava/lang/String;Lcom/facebook/Request$GraphPlaceListCallback;)Lcom/facebook/Request;", "")]
		public static global::Xamarin.FacebookBinding.Request NewPlacesSearchRequest (global::Xamarin.FacebookBinding.Session p0, global::Android.Locations.Location p1, int p2, int p3, string p4, global::Xamarin.FacebookBinding.Request.IGraphPlaceListCallback p5)
		{
			if (id_newPlacesSearchRequest_Lcom_facebook_Session_Landroid_location_Location_IILjava_lang_String_Lcom_facebook_Request_GraphPlaceListCallback_ == IntPtr.Zero)
				id_newPlacesSearchRequest_Lcom_facebook_Session_Landroid_location_Location_IILjava_lang_String_Lcom_facebook_Request_GraphPlaceListCallback_ = JNIEnv.GetStaticMethodID (class_ref, "newPlacesSearchRequest", "(Lcom/facebook/Session;Landroid/location/Location;IILjava/lang/String;Lcom/facebook/Request$GraphPlaceListCallback;)Lcom/facebook/Request;");
			IntPtr native_p4 = JNIEnv.NewString (p4);
			global::Xamarin.FacebookBinding.Request __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newPlacesSearchRequest_Lcom_facebook_Session_Landroid_location_Location_IILjava_lang_String_Lcom_facebook_Request_GraphPlaceListCallback_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (native_p4), new JValue (p5)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p4);
			return __ret;
		}

		static IntPtr id_newPostRequest_Lcom_facebook_Session_Ljava_lang_String_Lcom_facebook_model_GraphObject_Lcom_facebook_Request_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='newPostRequest' and count(parameter)=4 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.facebook.model.GraphObject'] and parameter[4][@type='com.facebook.Request.Callback']]"
		[Register ("newPostRequest", "(Lcom/facebook/Session;Ljava/lang/String;Lcom/facebook/model/GraphObject;Lcom/facebook/Request$Callback;)Lcom/facebook/Request;", "")]
		public static global::Xamarin.FacebookBinding.Request NewPostRequest (global::Xamarin.FacebookBinding.Session p0, string p1, global::Xamarin.FacebookBinding.Model.IGraphObject p2, global::Xamarin.FacebookBinding.Request.ICallback p3)
		{
			if (id_newPostRequest_Lcom_facebook_Session_Ljava_lang_String_Lcom_facebook_model_GraphObject_Lcom_facebook_Request_Callback_ == IntPtr.Zero)
				id_newPostRequest_Lcom_facebook_Session_Ljava_lang_String_Lcom_facebook_model_GraphObject_Lcom_facebook_Request_Callback_ = JNIEnv.GetStaticMethodID (class_ref, "newPostRequest", "(Lcom/facebook/Session;Ljava/lang/String;Lcom/facebook/model/GraphObject;Lcom/facebook/Request$Callback;)Lcom/facebook/Request;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Xamarin.FacebookBinding.Request __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newPostRequest_Lcom_facebook_Session_Ljava_lang_String_Lcom_facebook_model_GraphObject_Lcom_facebook_Request_Callback_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_newRestRequest_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_HttpMethod_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='newRestRequest' and count(parameter)=4 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='com.facebook.HttpMethod']]"
		[Register ("newRestRequest", "(Lcom/facebook/Session;Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/HttpMethod;)Lcom/facebook/Request;", "")]
		public static global::Xamarin.FacebookBinding.Request NewRestRequest (global::Xamarin.FacebookBinding.Session p0, string p1, global::Android.OS.Bundle p2, global::Xamarin.FacebookBinding.HttpMethod p3)
		{
			if (id_newRestRequest_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_HttpMethod_ == IntPtr.Zero)
				id_newRestRequest_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_HttpMethod_ = JNIEnv.GetStaticMethodID (class_ref, "newRestRequest", "(Lcom/facebook/Session;Ljava/lang/String;Landroid/os/Bundle;Lcom/facebook/HttpMethod;)Lcom/facebook/Request;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Xamarin.FacebookBinding.Request __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newRestRequest_Lcom_facebook_Session_Ljava_lang_String_Landroid_os_Bundle_Lcom_facebook_HttpMethod_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_newStatusUpdateRequest_Lcom_facebook_Session_Ljava_lang_String_Lcom_facebook_Request_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='newStatusUpdateRequest' and count(parameter)=3 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.facebook.Request.Callback']]"
		[Register ("newStatusUpdateRequest", "(Lcom/facebook/Session;Ljava/lang/String;Lcom/facebook/Request$Callback;)Lcom/facebook/Request;", "")]
		public static global::Xamarin.FacebookBinding.Request NewStatusUpdateRequest (global::Xamarin.FacebookBinding.Session p0, string p1, global::Xamarin.FacebookBinding.Request.ICallback p2)
		{
			if (id_newStatusUpdateRequest_Lcom_facebook_Session_Ljava_lang_String_Lcom_facebook_Request_Callback_ == IntPtr.Zero)
				id_newStatusUpdateRequest_Lcom_facebook_Session_Ljava_lang_String_Lcom_facebook_Request_Callback_ = JNIEnv.GetStaticMethodID (class_ref, "newStatusUpdateRequest", "(Lcom/facebook/Session;Ljava/lang/String;Lcom/facebook/Request$Callback;)Lcom/facebook/Request;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Xamarin.FacebookBinding.Request __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newStatusUpdateRequest_Lcom_facebook_Session_Ljava_lang_String_Lcom_facebook_Request_Callback_, new JValue (p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_newUploadPhotoRequest_Lcom_facebook_Session_Landroid_graphics_Bitmap_Lcom_facebook_Request_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='newUploadPhotoRequest' and count(parameter)=3 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='com.facebook.Request.Callback']]"
		[Register ("newUploadPhotoRequest", "(Lcom/facebook/Session;Landroid/graphics/Bitmap;Lcom/facebook/Request$Callback;)Lcom/facebook/Request;", "")]
		public static global::Xamarin.FacebookBinding.Request NewUploadPhotoRequest (global::Xamarin.FacebookBinding.Session p0, global::Android.Graphics.Bitmap p1, global::Xamarin.FacebookBinding.Request.ICallback p2)
		{
			if (id_newUploadPhotoRequest_Lcom_facebook_Session_Landroid_graphics_Bitmap_Lcom_facebook_Request_Callback_ == IntPtr.Zero)
				id_newUploadPhotoRequest_Lcom_facebook_Session_Landroid_graphics_Bitmap_Lcom_facebook_Request_Callback_ = JNIEnv.GetStaticMethodID (class_ref, "newUploadPhotoRequest", "(Lcom/facebook/Session;Landroid/graphics/Bitmap;Lcom/facebook/Request$Callback;)Lcom/facebook/Request;");
			global::Xamarin.FacebookBinding.Request __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newUploadPhotoRequest_Lcom_facebook_Session_Landroid_graphics_Bitmap_Lcom_facebook_Request_Callback_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_newUploadPhotoRequest_Lcom_facebook_Session_Ljava_io_File_Lcom_facebook_Request_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='newUploadPhotoRequest' and count(parameter)=3 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='java.io.File'] and parameter[3][@type='com.facebook.Request.Callback']]"
		[Register ("newUploadPhotoRequest", "(Lcom/facebook/Session;Ljava/io/File;Lcom/facebook/Request$Callback;)Lcom/facebook/Request;", "")]
		public static global::Xamarin.FacebookBinding.Request NewUploadPhotoRequest (global::Xamarin.FacebookBinding.Session p0, global::Java.IO.File p1, global::Xamarin.FacebookBinding.Request.ICallback p2)
		{
			if (id_newUploadPhotoRequest_Lcom_facebook_Session_Ljava_io_File_Lcom_facebook_Request_Callback_ == IntPtr.Zero)
				id_newUploadPhotoRequest_Lcom_facebook_Session_Ljava_io_File_Lcom_facebook_Request_Callback_ = JNIEnv.GetStaticMethodID (class_ref, "newUploadPhotoRequest", "(Lcom/facebook/Session;Ljava/io/File;Lcom/facebook/Request$Callback;)Lcom/facebook/Request;");
			global::Xamarin.FacebookBinding.Request __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newUploadPhotoRequest_Lcom_facebook_Session_Ljava_io_File_Lcom_facebook_Request_Callback_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_newUploadVideoRequest_Lcom_facebook_Session_Ljava_io_File_Lcom_facebook_Request_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='newUploadVideoRequest' and count(parameter)=3 and parameter[1][@type='com.facebook.Session'] and parameter[2][@type='java.io.File'] and parameter[3][@type='com.facebook.Request.Callback']]"
		[Register ("newUploadVideoRequest", "(Lcom/facebook/Session;Ljava/io/File;Lcom/facebook/Request$Callback;)Lcom/facebook/Request;", "")]
		public static global::Xamarin.FacebookBinding.Request NewUploadVideoRequest (global::Xamarin.FacebookBinding.Session p0, global::Java.IO.File p1, global::Xamarin.FacebookBinding.Request.ICallback p2)
		{
			if (id_newUploadVideoRequest_Lcom_facebook_Session_Ljava_io_File_Lcom_facebook_Request_Callback_ == IntPtr.Zero)
				id_newUploadVideoRequest_Lcom_facebook_Session_Ljava_io_File_Lcom_facebook_Request_Callback_ = JNIEnv.GetStaticMethodID (class_ref, "newUploadVideoRequest", "(Lcom/facebook/Session;Ljava/io/File;Lcom/facebook/Request$Callback;)Lcom/facebook/Request;");
			global::Xamarin.FacebookBinding.Request __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newUploadVideoRequest_Lcom_facebook_Session_Ljava_io_File_Lcom_facebook_Request_Callback_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_toHttpConnection_Lcom_facebook_RequestBatch_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='toHttpConnection' and count(parameter)=1 and parameter[1][@type='com.facebook.RequestBatch']]"
		[Register ("toHttpConnection", "(Lcom/facebook/RequestBatch;)Ljava/net/HttpURLConnection;", "")]
		public static global::Java.Net.HttpURLConnection ToHttpConnection (global::Xamarin.FacebookBinding.RequestBatch p0)
		{
			if (id_toHttpConnection_Lcom_facebook_RequestBatch_ == IntPtr.Zero)
				id_toHttpConnection_Lcom_facebook_RequestBatch_ = JNIEnv.GetStaticMethodID (class_ref, "toHttpConnection", "(Lcom/facebook/RequestBatch;)Ljava/net/HttpURLConnection;");
			global::Java.Net.HttpURLConnection __ret = global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toHttpConnection_Lcom_facebook_RequestBatch_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_toHttpConnection_arrayLcom_facebook_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='toHttpConnection' and count(parameter)=1 and parameter[1][@type='com.facebook.Request...']]"
		[Register ("toHttpConnection", "([Lcom/facebook/Request;)Ljava/net/HttpURLConnection;", "")]
		public static global::Java.Net.HttpURLConnection ToHttpConnection (params global:: Xamarin.FacebookBinding.Request[] p0)
		{
			if (id_toHttpConnection_arrayLcom_facebook_Request_ == IntPtr.Zero)
				id_toHttpConnection_arrayLcom_facebook_Request_ = JNIEnv.GetStaticMethodID (class_ref, "toHttpConnection", "([Lcom/facebook/Request;)Ljava/net/HttpURLConnection;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Java.Net.HttpURLConnection __ret = global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toHttpConnection_arrayLcom_facebook_Request_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_toHttpConnection_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Request']/method[@name='toHttpConnection' and count(parameter)=1 and parameter[1][@type='java.util.Collection']]"
		[Register ("toHttpConnection", "(Ljava/util/Collection;)Ljava/net/HttpURLConnection;", "")]
		public static global::Java.Net.HttpURLConnection ToHttpConnection (global::System.Collections.Generic.ICollection<global::Xamarin.FacebookBinding.Request> p0)
		{
			if (id_toHttpConnection_Ljava_util_Collection_ == IntPtr.Zero)
				id_toHttpConnection_Ljava_util_Collection_ = JNIEnv.GetStaticMethodID (class_ref, "toHttpConnection", "(Ljava/util/Collection;)Ljava/net/HttpURLConnection;");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection<global::Xamarin.FacebookBinding.Request>.ToLocalJniHandle (p0);
			global::Java.Net.HttpURLConnection __ret = global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toHttpConnection_Ljava_util_Collection_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
