using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='RequestAsyncTask']"
	[global::Android.Runtime.Register ("com/facebook/RequestAsyncTask", DoNotGenerateAcw=true)]
	public partial class RequestAsyncTask : global::Android.OS.AsyncTask {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/RequestAsyncTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestAsyncTask); }
		}

		protected RequestAsyncTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_Collection_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='RequestAsyncTask']/constructor[@name='RequestAsyncTask' and count(parameter)=1 and parameter[1][@type='java.util.Collection']]"
		[Register (".ctor", "(Ljava/util/Collection;)V", "")]
		public RequestAsyncTask (global::System.Collections.Generic.ICollection<global::Xamarin.FacebookBinding.Request> p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaCollection<global::Xamarin.FacebookBinding.Request>.ToLocalJniHandle (p0);;
			if (GetType () != typeof (RequestAsyncTask)) {
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

		static IntPtr id_ctor_Ljava_net_HttpURLConnection_arrayLcom_facebook_Request_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='RequestAsyncTask']/constructor[@name='RequestAsyncTask' and count(parameter)=2 and parameter[1][@type='java.net.HttpURLConnection'] and parameter[2][@type='com.facebook.Request...']]"
		[Register (".ctor", "(Ljava/net/HttpURLConnection;[Lcom/facebook/Request;)V", "")]
		public RequestAsyncTask (global::Java.Net.HttpURLConnection p0, params global:: Xamarin.FacebookBinding.Request[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (RequestAsyncTask)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/net/HttpURLConnection;[Lcom/facebook/Request;)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/net/HttpURLConnection;[Lcom/facebook/Request;)V", new JValue (p0), new JValue (native_p1));
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return;
			}

			if (id_ctor_Ljava_net_HttpURLConnection_arrayLcom_facebook_Request_ == IntPtr.Zero)
				id_ctor_Ljava_net_HttpURLConnection_arrayLcom_facebook_Request_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/HttpURLConnection;[Lcom/facebook/Request;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_HttpURLConnection_arrayLcom_facebook_Request_, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_net_HttpURLConnection_arrayLcom_facebook_Request_, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Lcom_facebook_RequestBatch_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='RequestAsyncTask']/constructor[@name='RequestAsyncTask' and count(parameter)=1 and parameter[1][@type='com.facebook.RequestBatch']]"
		[Register (".ctor", "(Lcom/facebook/RequestBatch;)V", "")]
		public RequestAsyncTask (global::Xamarin.FacebookBinding.RequestBatch p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RequestAsyncTask)) {
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

		static IntPtr id_ctor_Ljava_net_HttpURLConnection_Ljava_util_Collection_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='RequestAsyncTask']/constructor[@name='RequestAsyncTask' and count(parameter)=2 and parameter[1][@type='java.net.HttpURLConnection'] and parameter[2][@type='java.util.Collection']]"
		[Register (".ctor", "(Ljava/net/HttpURLConnection;Ljava/util/Collection;)V", "")]
		public RequestAsyncTask (global::Java.Net.HttpURLConnection p0, global::System.Collections.Generic.ICollection<global::Xamarin.FacebookBinding.Request> p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaCollection<global::Xamarin.FacebookBinding.Request>.ToLocalJniHandle (p1);;
			if (GetType () != typeof (RequestAsyncTask)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/net/HttpURLConnection;Ljava/util/Collection;)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/net/HttpURLConnection;Ljava/util/Collection;)V", new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Ljava_net_HttpURLConnection_Ljava_util_Collection_ == IntPtr.Zero)
				id_ctor_Ljava_net_HttpURLConnection_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/HttpURLConnection;Ljava/util/Collection;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_HttpURLConnection_Ljava_util_Collection_, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_net_HttpURLConnection_Ljava_util_Collection_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_Ljava_net_HttpURLConnection_Lcom_facebook_RequestBatch_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='RequestAsyncTask']/constructor[@name='RequestAsyncTask' and count(parameter)=2 and parameter[1][@type='java.net.HttpURLConnection'] and parameter[2][@type='com.facebook.RequestBatch']]"
		[Register (".ctor", "(Ljava/net/HttpURLConnection;Lcom/facebook/RequestBatch;)V", "")]
		public RequestAsyncTask (global::Java.Net.HttpURLConnection p0, global::Xamarin.FacebookBinding.RequestBatch p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RequestAsyncTask)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/net/HttpURLConnection;Lcom/facebook/RequestBatch;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/net/HttpURLConnection;Lcom/facebook/RequestBatch;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Ljava_net_HttpURLConnection_Lcom_facebook_RequestBatch_ == IntPtr.Zero)
				id_ctor_Ljava_net_HttpURLConnection_Lcom_facebook_RequestBatch_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/HttpURLConnection;Lcom/facebook/RequestBatch;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_HttpURLConnection_Lcom_facebook_RequestBatch_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_net_HttpURLConnection_Lcom_facebook_RequestBatch_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_arrayLcom_facebook_Request_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='RequestAsyncTask']/constructor[@name='RequestAsyncTask' and count(parameter)=1 and parameter[1][@type='com.facebook.Request...']]"
		[Register (".ctor", "([Lcom/facebook/Request;)V", "")]
		public RequestAsyncTask (params global:: Xamarin.FacebookBinding.Request[] p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);;
			if (GetType () != typeof (RequestAsyncTask)) {
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

		static IntPtr id_getException;
		protected global::Java.Lang.Exception Exception {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='RequestAsyncTask']/method[@name='getException' and count(parameter)=0]"
			[Register ("getException", "()Ljava/lang/Exception;", "GetGetExceptionHandler")]
			get {
				if (id_getException == IntPtr.Zero)
					id_getException = JNIEnv.GetMethodID (class_ref, "getException", "()Ljava/lang/Exception;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (JNIEnv.CallObjectMethod  (Handle, id_getException), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getRequests;
		protected global::Xamarin.FacebookBinding.RequestBatch Requests {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='RequestAsyncTask']/method[@name='getRequests' and count(parameter)=0]"
			[Register ("getRequests", "()Lcom/facebook/RequestBatch;", "GetGetRequestsHandler")]
			get {
				if (id_getRequests == IntPtr.Zero)
					id_getRequests = JNIEnv.GetMethodID (class_ref, "getRequests", "()Lcom/facebook/RequestBatch;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestBatch> (JNIEnv.CallObjectMethod  (Handle, id_getRequests), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_doInBackground_arrayLjava_lang_Void_;
#pragma warning disable 0169
		static Delegate GetDoInBackground_arrayLjava_lang_Void_Handler ()
		{
			if (cb_doInBackground_arrayLjava_lang_Void_ == null)
				cb_doInBackground_arrayLjava_lang_Void_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_Void_);
			return cb_doInBackground_arrayLjava_lang_Void_;
		}

		static IntPtr n_DoInBackground_arrayLjava_lang_Void_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.RequestAsyncTask __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestAsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Void[] p0 = (global::Java.Lang.Void[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Void));
			IntPtr __ret = global::Android.Runtime.JavaList<global::Xamarin.FacebookBinding.Response>.ToLocalJniHandle (__this.DoInBackground (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_doInBackground_arrayLjava_lang_Void_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='RequestAsyncTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Void...']]"
		[Register ("doInBackground", "([Ljava/lang/Void;)Ljava/util/List;", "GetDoInBackground_arrayLjava_lang_Void_Handler")]
		protected virtual global::System.Collections.Generic.IList<global::Xamarin.FacebookBinding.Response> DoInBackground (params global:: Java.Lang.Void[] p0)
		{
			if (id_doInBackground_arrayLjava_lang_Void_ == IntPtr.Zero)
				id_doInBackground_arrayLjava_lang_Void_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/Void;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			global::System.Collections.Generic.IList<global::Xamarin.FacebookBinding.Response> __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaList<global::Xamarin.FacebookBinding.Response>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_doInBackground_arrayLjava_lang_Void_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaList<global::Xamarin.FacebookBinding.Response>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doInBackground", "([Ljava/lang/Void;)Ljava/util/List;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_onPostExecute_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnPostExecute_Ljava_util_List_Handler ()
		{
			if (cb_onPostExecute_Ljava_util_List_ == null)
				cb_onPostExecute_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPostExecute_Ljava_util_List_);
			return cb_onPostExecute_Ljava_util_List_;
		}

		static void n_OnPostExecute_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.RequestAsyncTask __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.RequestAsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Xamarin.FacebookBinding.Response> p0 = global::Android.Runtime.JavaList<global::Xamarin.FacebookBinding.Response>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPostExecute (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPostExecute_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='RequestAsyncTask']/method[@name='onPostExecute' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("onPostExecute", "(Ljava/util/List;)V", "GetOnPostExecute_Ljava_util_List_Handler")]
		protected virtual void OnPostExecute (global::System.Collections.Generic.IList<global::Xamarin.FacebookBinding.Response> p0)
		{
			if (id_onPostExecute_Ljava_util_List_ == IntPtr.Zero)
				id_onPostExecute_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onPostExecute", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Xamarin.FacebookBinding.Response>.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onPostExecute_Ljava_util_List_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPostExecute", "(Ljava/util/List;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
