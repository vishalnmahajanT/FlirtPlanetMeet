using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='RequestBatch']"
	[global::Android.Runtime.Register ("com/facebook/RequestBatch", DoNotGenerateAcw=true)]
	public partial class RequestBatch : global::Java.Util.AbstractList {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook']/interface[@name='RequestBatch.Callback']"
		[Register ("com/facebook/RequestBatch$Callback", "", "Xamarin.FacebookBinding.RequestBatch/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/interface[@name='RequestBatch.Callback']/method[@name='onBatchCompleted' and count(parameter)=1 and parameter[1][@type='com.facebook.RequestBatch']]"
			[Register ("onBatchCompleted", "(Lcom/facebook/RequestBatch;)V", "GetOnBatchCompleted_Lcom_facebook_RequestBatch_Handler:Xamarin.FacebookBinding.RequestBatch/ICallbackInvoker, Xamarin.Facebook")]
			void OnBatchCompleted (global::Xamarin.FacebookBinding.RequestBatch p0);

		}

		[global::Android.Runtime.Register ("com/facebook/RequestBatch$Callback", DoNotGenerateAcw=true)]
		internal class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/RequestBatch$Callback");
			IntPtr class_ref;

			public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.RequestBatch.Callback"));
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

			static Delegate cb_onBatchCompleted_Lcom_facebook_RequestBatch_;
#pragma warning disable 0169
			static Delegate GetOnBatchCompleted_Lcom_facebook_RequestBatch_Handler ()
			{
				if (cb_onBatchCompleted_Lcom_facebook_RequestBatch_ == null)
					cb_onBatchCompleted_Lcom_facebook_RequestBatch_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBatchCompleted_Lcom_facebook_RequestBatch_);
				return cb_onBatchCompleted_Lcom_facebook_RequestBatch_;
			}

			static void n_OnBatchCompleted_Lcom_facebook_RequestBatch_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.RequestBatch.ICallback __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestBatch.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.RequestBatch p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestBatch> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnBatchCompleted (p0);
			}
#pragma warning restore 0169

			IntPtr id_onBatchCompleted_Lcom_facebook_RequestBatch_;
			public void OnBatchCompleted (global::Xamarin.FacebookBinding.RequestBatch p0)
			{
				if (id_onBatchCompleted_Lcom_facebook_RequestBatch_ == IntPtr.Zero)
					id_onBatchCompleted_Lcom_facebook_RequestBatch_ = JNIEnv.GetMethodID (class_ref, "onBatchCompleted", "(Lcom/facebook/RequestBatch;)V");
				JNIEnv.CallVoidMethod (Handle, id_onBatchCompleted_Lcom_facebook_RequestBatch_, new JValue (p0));
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/RequestBatch", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestBatch); }
		}

		protected RequestBatch (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_Collection_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='RequestBatch']/constructor[@name='RequestBatch' and count(parameter)=1 and parameter[1][@type='java.util.Collection']]"
		[Register (".ctor", "(Ljava/util/Collection;)V", "")]
		public RequestBatch (global::System.Collections.Generic.ICollection<global::Xamarin.FacebookBinding.Request> p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaCollection<global::Xamarin.FacebookBinding.Request>.ToLocalJniHandle (p0);;
			if (GetType () != typeof (RequestBatch)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/Collection;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/Collection;)V", new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_util_Collection_ == IntPtr.Zero)
				id_ctor_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Collection;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Collection_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_Collection_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_ctor_arrayLcom_facebook_Request_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='RequestBatch']/constructor[@name='RequestBatch' and count(parameter)=1 and parameter[1][@type='com.facebook.Request...']]"
		[Register (".ctor", "([Lcom/facebook/Request;)V", "")]
		public RequestBatch (params global:: Xamarin.FacebookBinding.Request[] p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);;
			if (GetType () != typeof (RequestBatch)) {
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

		static IntPtr id_ctor_Lcom_facebook_RequestBatch_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='RequestBatch']/constructor[@name='RequestBatch' and count(parameter)=1 and parameter[1][@type='com.facebook.RequestBatch']]"
		[Register (".ctor", "(Lcom/facebook/RequestBatch;)V", "")]
		public RequestBatch (global::Xamarin.FacebookBinding.RequestBatch p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RequestBatch)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/facebook/RequestBatch;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/facebook/RequestBatch;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_facebook_RequestBatch_ == IntPtr.Zero)
				id_ctor_Lcom_facebook_RequestBatch_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/RequestBatch;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_RequestBatch_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_facebook_RequestBatch_, new JValue (p0));
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='RequestBatch']/constructor[@name='RequestBatch' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public RequestBatch () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RequestBatch)) {
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

		static Delegate cb_getTimeout;
#pragma warning disable 0169
		static Delegate GetGetTimeoutHandler ()
		{
			if (cb_getTimeout == null)
				cb_getTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTimeout);
			return cb_getTimeout;
		}

		static int n_GetTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.RequestBatch __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestBatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timeout;
		}
#pragma warning restore 0169

		static Delegate cb_setTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetTimeout_IHandler ()
		{
			if (cb_setTimeout_I == null)
				cb_setTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTimeout_I);
			return cb_setTimeout_I;
		}

		static void n_SetTimeout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Xamarin.FacebookBinding.RequestBatch __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestBatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Timeout = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeout;
		static IntPtr id_setTimeout_I;
		public virtual int Timeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='RequestBatch']/method[@name='getTimeout' and count(parameter)=0]"
			[Register ("getTimeout", "()I", "GetGetTimeoutHandler")]
			get {
				if (id_getTimeout == IntPtr.Zero)
					id_getTimeout = JNIEnv.GetMethodID (class_ref, "getTimeout", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getTimeout);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeout", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='RequestBatch']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTimeout", "(I)V", "GetSetTimeout_IHandler")]
			set {
				if (id_setTimeout_I == IntPtr.Zero)
					id_setTimeout_I = JNIEnv.GetMethodID (class_ref, "setTimeout", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTimeout_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeout", "(I)V"), new JValue (value));
			}
		}

		static IntPtr id_add_Lcom_facebook_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='RequestBatch']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.facebook.Request']]"
		[Register ("add", "(Lcom/facebook/Request;)Z", "")]
		public bool Add (global::Xamarin.FacebookBinding.Request p0)
		{
			if (id_add_Lcom_facebook_Request_ == IntPtr.Zero)
				id_add_Lcom_facebook_Request_ = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/facebook/Request;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_add_Lcom_facebook_Request_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_add_ILcom_facebook_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='RequestBatch']/method[@name='add' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.facebook.Request']]"
		[Register ("add", "(ILcom/facebook/Request;)V", "")]
		public void Add (int p0, global::Xamarin.FacebookBinding.Request p1)
		{
			if (id_add_ILcom_facebook_Request_ == IntPtr.Zero)
				id_add_ILcom_facebook_Request_ = JNIEnv.GetMethodID (class_ref, "add", "(ILcom/facebook/Request;)V");
			JNIEnv.CallVoidMethod  (Handle, id_add_ILcom_facebook_Request_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_addCallback_Lcom_facebook_RequestBatch_Callback_;
#pragma warning disable 0169
		static Delegate GetAddCallback_Lcom_facebook_RequestBatch_Callback_Handler ()
		{
			if (cb_addCallback_Lcom_facebook_RequestBatch_Callback_ == null)
				cb_addCallback_Lcom_facebook_RequestBatch_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddCallback_Lcom_facebook_RequestBatch_Callback_);
			return cb_addCallback_Lcom_facebook_RequestBatch_Callback_;
		}

		static void n_AddCallback_Lcom_facebook_RequestBatch_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.RequestBatch __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestBatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.RequestBatch.ICallback p0 = (global::Xamarin.FacebookBinding.RequestBatch.ICallback)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestBatch.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addCallback_Lcom_facebook_RequestBatch_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='RequestBatch']/method[@name='addCallback' and count(parameter)=1 and parameter[1][@type='com.facebook.RequestBatch.Callback']]"
		[Register ("addCallback", "(Lcom/facebook/RequestBatch$Callback;)V", "GetAddCallback_Lcom_facebook_RequestBatch_Callback_Handler")]
		public virtual void AddCallback (global::Xamarin.FacebookBinding.RequestBatch.ICallback p0)
		{
			if (id_addCallback_Lcom_facebook_RequestBatch_Callback_ == IntPtr.Zero)
				id_addCallback_Lcom_facebook_RequestBatch_Callback_ = JNIEnv.GetMethodID (class_ref, "addCallback", "(Lcom/facebook/RequestBatch$Callback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addCallback_Lcom_facebook_RequestBatch_Callback_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addCallback", "(Lcom/facebook/RequestBatch$Callback;)V"), new JValue (p0));
		}

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='RequestBatch']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public override sealed void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_clear);
		}

		static IntPtr id_executeAndWait;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='RequestBatch']/method[@name='executeAndWait' and count(parameter)=0]"
		[Register ("executeAndWait", "()Ljava/util/List;", "")]
		public global::System.Collections.Generic.IList<global::Xamarin.FacebookBinding.Response> ExecuteAndWait ()
		{
			if (id_executeAndWait == IntPtr.Zero)
				id_executeAndWait = JNIEnv.GetMethodID (class_ref, "executeAndWait", "()Ljava/util/List;");
			return global::Android.Runtime.JavaList<global::Xamarin.FacebookBinding.Response>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_executeAndWait), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_executeAsync;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='RequestBatch']/method[@name='executeAsync' and count(parameter)=0]"
		[Register ("executeAsync", "()Lcom/facebook/RequestAsyncTask;", "")]
		public global::Xamarin.FacebookBinding.RequestAsyncTask ExecuteAsync ()
		{
			if (id_executeAsync == IntPtr.Zero)
				id_executeAsync = JNIEnv.GetMethodID (class_ref, "executeAsync", "()Lcom/facebook/RequestAsyncTask;");
			return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestAsyncTask> (JNIEnv.CallObjectMethod  (Handle, id_executeAsync), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='RequestBatch']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Ljava/lang/Object;", "")]
		public override sealed global::Java.Lang.Object Get (int p0)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Ljava/lang/Object;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_remove_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='RequestBatch']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("remove", "(I)Ljava/lang/Object;", "")]
		public override sealed global::Java.Lang.Object Remove (int p0)
		{
			if (id_remove_I == IntPtr.Zero)
				id_remove_I = JNIEnv.GetMethodID (class_ref, "remove", "(I)Ljava/lang/Object;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_remove_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_removeCallback_Lcom_facebook_RequestBatch_Callback_;
#pragma warning disable 0169
		static Delegate GetRemoveCallback_Lcom_facebook_RequestBatch_Callback_Handler ()
		{
			if (cb_removeCallback_Lcom_facebook_RequestBatch_Callback_ == null)
				cb_removeCallback_Lcom_facebook_RequestBatch_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveCallback_Lcom_facebook_RequestBatch_Callback_);
			return cb_removeCallback_Lcom_facebook_RequestBatch_Callback_;
		}

		static void n_RemoveCallback_Lcom_facebook_RequestBatch_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.RequestBatch __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestBatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.RequestBatch.ICallback p0 = (global::Xamarin.FacebookBinding.RequestBatch.ICallback)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestBatch.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeCallback_Lcom_facebook_RequestBatch_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='RequestBatch']/method[@name='removeCallback' and count(parameter)=1 and parameter[1][@type='com.facebook.RequestBatch.Callback']]"
		[Register ("removeCallback", "(Lcom/facebook/RequestBatch$Callback;)V", "GetRemoveCallback_Lcom_facebook_RequestBatch_Callback_Handler")]
		public virtual void RemoveCallback (global::Xamarin.FacebookBinding.RequestBatch.ICallback p0)
		{
			if (id_removeCallback_Lcom_facebook_RequestBatch_Callback_ == IntPtr.Zero)
				id_removeCallback_Lcom_facebook_RequestBatch_Callback_ = JNIEnv.GetMethodID (class_ref, "removeCallback", "(Lcom/facebook/RequestBatch$Callback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeCallback_Lcom_facebook_RequestBatch_Callback_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeCallback", "(Lcom/facebook/RequestBatch$Callback;)V"), new JValue (p0));
		}

		static IntPtr id_set_ILcom_facebook_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='RequestBatch']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.facebook.Request']]"
		[Register ("set", "(ILcom/facebook/Request;)Lcom/facebook/Request;", "")]
		public global::Xamarin.FacebookBinding.Request Set (int p0, global::Xamarin.FacebookBinding.Request p1)
		{
			if (id_set_ILcom_facebook_Request_ == IntPtr.Zero)
				id_set_ILcom_facebook_Request_ = JNIEnv.GetMethodID (class_ref, "set", "(ILcom/facebook/Request;)Lcom/facebook/Request;");
			global::Xamarin.FacebookBinding.Request __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request> (JNIEnv.CallObjectMethod  (Handle, id_set_ILcom_facebook_Request_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='RequestBatch']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "")]
		public override sealed int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_size);
		}

	}
}
