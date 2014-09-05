using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding.Model {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphMultiResult']"
	[Register ("com/facebook/model/GraphMultiResult", "", "Xamarin.FacebookBinding.Model.IGraphMultiResultInvoker")]
	public partial interface IGraphMultiResult : global::Xamarin.FacebookBinding.Model.IGraphObject {

		global::Xamarin.FacebookBinding.Model.IGraphObjectList Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphMultiResult']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Lcom/facebook/model/GraphObjectList;", "GetGetDataHandler:Xamarin.FacebookBinding.Model.IGraphMultiResultInvoker, Xamarin.Facebook")] get;
		}

	}

	[global::Android.Runtime.Register ("com/facebook/model/GraphMultiResult", DoNotGenerateAcw=true)]
	internal class IGraphMultiResultInvoker : global::Java.Lang.Object, IGraphMultiResult {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/model/GraphMultiResult");
		IntPtr class_ref;

		public static IGraphMultiResult GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGraphMultiResult> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.model.GraphMultiResult"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGraphMultiResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IGraphMultiResultInvoker); }
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IGraphMultiResult __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphMultiResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		IntPtr id_getData;
		public global::Xamarin.FacebookBinding.Model.IGraphObjectList Data {
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Lcom/facebook/model/GraphObjectList;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObjectList> (JNIEnv.CallObjectMethod (Handle, id_getData), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getInnerJSONObject;
#pragma warning disable 0169
		static Delegate GetGetInnerJSONObjectHandler ()
		{
			if (cb_getInnerJSONObject == null)
				cb_getInnerJSONObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInnerJSONObject);
			return cb_getInnerJSONObject;
		}

		static IntPtr n_GetInnerJSONObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IGraphMultiResult __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphMultiResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InnerJSONObject);
		}
#pragma warning restore 0169

		IntPtr id_getInnerJSONObject;
		public global::Org.Json.JSONObject InnerJSONObject {
			get {
				if (id_getInnerJSONObject == IntPtr.Zero)
					id_getInnerJSONObject = JNIEnv.GetMethodID (class_ref, "getInnerJSONObject", "()Lorg/json/JSONObject;");
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (Handle, id_getInnerJSONObject), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_asMap;
#pragma warning disable 0169
		static Delegate GetAsMapHandler ()
		{
			if (cb_asMap == null)
				cb_asMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsMap);
			return cb_asMap;
		}

		static IntPtr n_AsMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IGraphMultiResult __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphMultiResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.AsMap ());
		}
#pragma warning restore 0169

		IntPtr id_asMap;
		public global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> AsMap ()
		{
			if (id_asMap == IntPtr.Zero)
				id_asMap = JNIEnv.GetMethodID (class_ref, "asMap", "()Ljava/util/Map;");
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_asMap), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_cast_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetCast_Ljava_lang_Class_Handler ()
		{
			if (cb_cast_Ljava_lang_Class_ == null)
				cb_cast_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Cast_Ljava_lang_Class_);
			return cb_cast_Ljava_lang_Class_;
		}

		static IntPtr n_Cast_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IGraphMultiResult __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphMultiResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Cast (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_cast_Ljava_lang_Class_;
		public global::Java.Lang.Object Cast (global::Java.Lang.Class p0)
		{
			if (id_cast_Ljava_lang_Class_ == IntPtr.Zero)
				id_cast_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "cast", "(Ljava/lang/Class;)Lcom/facebook/model/GraphObject;");
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_cast_Ljava_lang_Class_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getProperty_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetProperty_Ljava_lang_String_Handler ()
		{
			if (cb_getProperty_Ljava_lang_String_ == null)
				cb_getProperty_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetProperty_Ljava_lang_String_);
			return cb_getProperty_Ljava_lang_String_;
		}

		static IntPtr n_GetProperty_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IGraphMultiResult __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphMultiResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetProperty (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getProperty_Ljava_lang_String_;
		public global::Java.Lang.Object GetProperty (string p0)
		{
			if (id_getProperty_Ljava_lang_String_ == IntPtr.Zero)
				id_getProperty_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_getProperty_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_removeProperty_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveProperty_Ljava_lang_String_Handler ()
		{
			if (cb_removeProperty_Ljava_lang_String_ == null)
				cb_removeProperty_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveProperty_Ljava_lang_String_);
			return cb_removeProperty_Ljava_lang_String_;
		}

		static void n_RemoveProperty_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IGraphMultiResult __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphMultiResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveProperty (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeProperty_Ljava_lang_String_;
		public void RemoveProperty (string p0)
		{
			if (id_removeProperty_Ljava_lang_String_ == IntPtr.Zero)
				id_removeProperty_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeProperty", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_removeProperty_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setProperty_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetProperty_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_setProperty_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_setProperty_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetProperty_Ljava_lang_String_Ljava_lang_Object_);
			return cb_setProperty_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_SetProperty_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Xamarin.FacebookBinding.Model.IGraphMultiResult __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphMultiResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetProperty (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setProperty_Ljava_lang_String_Ljava_lang_Object_;
		public void SetProperty (string p0, global::Java.Lang.Object p1)
		{
			if (id_setProperty_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_setProperty_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_setProperty_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
