using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='TestSession']"
	[global::Android.Runtime.Register ("com/facebook/TestSession", DoNotGenerateAcw=true)]
	public partial class TestSession : global::Xamarin.FacebookBinding.Session {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook']/interface[@name='TestSession.FqlResponse']"
		[Register ("com/facebook/TestSession$FqlResponse", "", "Xamarin.FacebookBinding.TestSession/IFqlResponseInvoker")]
		public partial interface IFqlResponse : global::Xamarin.FacebookBinding.Model.IGraphObject {

			global::Xamarin.FacebookBinding.Model.IGraphObjectList Data {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/interface[@name='TestSession.FqlResponse']/method[@name='getData' and count(parameter)=0]"
				[Register ("getData", "()Lcom/facebook/model/GraphObjectList;", "GetGetDataHandler:Xamarin.FacebookBinding.TestSession/IFqlResponseInvoker, Xamarin.Facebook")] get;
			}

		}

		[global::Android.Runtime.Register ("com/facebook/TestSession$FqlResponse", DoNotGenerateAcw=true)]
		internal class IFqlResponseInvoker : global::Java.Lang.Object, IFqlResponse {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/TestSession$FqlResponse");
			IntPtr class_ref;

			public static IFqlResponse GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFqlResponse> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.TestSession.FqlResponse"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFqlResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IFqlResponseInvoker); }
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
				global::Xamarin.FacebookBinding.TestSession.IFqlResponse __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.IFqlResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.TestSession.IFqlResponse __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.IFqlResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.TestSession.IFqlResponse __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.IFqlResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.TestSession.IFqlResponse __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.IFqlResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.TestSession.IFqlResponse __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.IFqlResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.TestSession.IFqlResponse __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.IFqlResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.TestSession.IFqlResponse __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.IFqlResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook']/interface[@name='TestSession.FqlResult']"
		[Register ("com/facebook/TestSession$FqlResult", "", "Xamarin.FacebookBinding.TestSession/IFqlResultInvoker")]
		public partial interface IFqlResult : global::Xamarin.FacebookBinding.Model.IGraphObject {

			global::Xamarin.FacebookBinding.Model.IGraphObjectList FqlResultSet {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/interface[@name='TestSession.FqlResult']/method[@name='getFqlResultSet' and count(parameter)=0]"
				[Register ("getFqlResultSet", "()Lcom/facebook/model/GraphObjectList;", "GetGetFqlResultSetHandler:Xamarin.FacebookBinding.TestSession/IFqlResultInvoker, Xamarin.Facebook")] get;
			}

		}

		[global::Android.Runtime.Register ("com/facebook/TestSession$FqlResult", DoNotGenerateAcw=true)]
		internal class IFqlResultInvoker : global::Java.Lang.Object, IFqlResult {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/TestSession$FqlResult");
			IntPtr class_ref;

			public static IFqlResult GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFqlResult> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.TestSession.FqlResult"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFqlResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IFqlResultInvoker); }
			}

			static Delegate cb_getFqlResultSet;
#pragma warning disable 0169
			static Delegate GetGetFqlResultSetHandler ()
			{
				if (cb_getFqlResultSet == null)
					cb_getFqlResultSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFqlResultSet);
				return cb_getFqlResultSet;
			}

			static IntPtr n_GetFqlResultSet (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.TestSession.IFqlResult __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.IFqlResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.FqlResultSet);
			}
#pragma warning restore 0169

			IntPtr id_getFqlResultSet;
			public global::Xamarin.FacebookBinding.Model.IGraphObjectList FqlResultSet {
				get {
					if (id_getFqlResultSet == IntPtr.Zero)
						id_getFqlResultSet = JNIEnv.GetMethodID (class_ref, "getFqlResultSet", "()Lcom/facebook/model/GraphObjectList;");
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObjectList> (JNIEnv.CallObjectMethod (Handle, id_getFqlResultSet), JniHandleOwnership.TransferLocalRef);
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
				global::Xamarin.FacebookBinding.TestSession.IFqlResult __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.IFqlResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.TestSession.IFqlResult __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.IFqlResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.TestSession.IFqlResult __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.IFqlResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.TestSession.IFqlResult __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.IFqlResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.TestSession.IFqlResult __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.IFqlResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.TestSession.IFqlResult __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.IFqlResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='TestSession.Mode']"
		[global::Android.Runtime.Register ("com/facebook/TestSession$Mode", DoNotGenerateAcw=true)]
		public sealed partial class Mode : global::Java.Lang.Enum {


			static IntPtr PRIVATE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='TestSession.Mode']/field[@name='PRIVATE']"
			[Register ("PRIVATE")]
			public static global::Xamarin.FacebookBinding.TestSession.Mode Private {
				get {
					if (PRIVATE_jfieldId == IntPtr.Zero)
						PRIVATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PRIVATE", "Lcom/facebook/TestSession$Mode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PRIVATE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PRIVATE_jfieldId == IntPtr.Zero)
						PRIVATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PRIVATE", "Lcom/facebook/TestSession$Mode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PRIVATE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SHARED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='TestSession.Mode']/field[@name='SHARED']"
			[Register ("SHARED")]
			public static global::Xamarin.FacebookBinding.TestSession.Mode Shared {
				get {
					if (SHARED_jfieldId == IntPtr.Zero)
						SHARED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHARED", "Lcom/facebook/TestSession$Mode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SHARED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SHARED_jfieldId == IntPtr.Zero)
						SHARED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHARED", "Lcom/facebook/TestSession$Mode;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SHARED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/TestSession$Mode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Mode); }
			}

			internal Mode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook']/interface[@name='TestSession.TestAccount']"
		[Register ("com/facebook/TestSession$TestAccount", "", "Xamarin.FacebookBinding.TestSession/ITestAccountInvoker")]
		public partial interface ITestAccount : global::Xamarin.FacebookBinding.Model.IGraphObject {

			string AccessToken {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/interface[@name='TestSession.TestAccount']/method[@name='getAccessToken' and count(parameter)=0]"
				[Register ("getAccessToken", "()Ljava/lang/String;", "GetGetAccessTokenHandler:Xamarin.FacebookBinding.TestSession/ITestAccountInvoker, Xamarin.Facebook")] get;
			}

			string Id {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/interface[@name='TestSession.TestAccount']/method[@name='getId' and count(parameter)=0]"
				[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler:Xamarin.FacebookBinding.TestSession/ITestAccountInvoker, Xamarin.Facebook")] get;
			}

			string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/interface[@name='TestSession.TestAccount']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Xamarin.FacebookBinding.TestSession/ITestAccountInvoker, Xamarin.Facebook")] get;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/interface[@name='TestSession.TestAccount']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler:Xamarin.FacebookBinding.TestSession/ITestAccountInvoker, Xamarin.Facebook")] set;
			}

		}

		[global::Android.Runtime.Register ("com/facebook/TestSession$TestAccount", DoNotGenerateAcw=true)]
		internal class ITestAccountInvoker : global::Java.Lang.Object, ITestAccount {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/TestSession$TestAccount");
			IntPtr class_ref;

			public static ITestAccount GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ITestAccount> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.TestSession.TestAccount"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITestAccountInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (ITestAccountInvoker); }
			}

			static Delegate cb_getAccessToken;
#pragma warning disable 0169
			static Delegate GetGetAccessTokenHandler ()
			{
				if (cb_getAccessToken == null)
					cb_getAccessToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccessToken);
				return cb_getAccessToken;
			}

			static IntPtr n_GetAccessToken (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.TestSession.ITestAccount __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.ITestAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.AccessToken);
			}
#pragma warning restore 0169

			IntPtr id_getAccessToken;
			public string AccessToken {
				get {
					if (id_getAccessToken == IntPtr.Zero)
						id_getAccessToken = JNIEnv.GetMethodID (class_ref, "getAccessToken", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getAccessToken), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getId;
#pragma warning disable 0169
			static Delegate GetGetIdHandler ()
			{
				if (cb_getId == null)
					cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
				return cb_getId;
			}

			static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.TestSession.ITestAccount __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.ITestAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Id);
			}
#pragma warning restore 0169

			IntPtr id_getId;
			public string Id {
				get {
					if (id_getId == IntPtr.Zero)
						id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getName;
#pragma warning disable 0169
			static Delegate GetGetNameHandler ()
			{
				if (cb_getName == null)
					cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
				return cb_getName;
			}

			static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.TestSession.ITestAccount __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.ITestAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Name);
			}
#pragma warning restore 0169

			static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetName_Ljava_lang_String_Handler ()
			{
				if (cb_setName_Ljava_lang_String_ == null)
					cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
				return cb_setName_Ljava_lang_String_;
			}

			static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.TestSession.ITestAccount __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.ITestAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Name = p0;
			}
#pragma warning restore 0169

			IntPtr id_getName;
			IntPtr id_setName_Ljava_lang_String_;
			public string Name {
				get {
					if (id_getName == IntPtr.Zero)
						id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
						id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					JNIEnv.CallVoidMethod (Handle, id_setName_Ljava_lang_String_, new JValue (native_value));
					JNIEnv.DeleteLocalRef (native_value);
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
				global::Xamarin.FacebookBinding.TestSession.ITestAccount __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.ITestAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.TestSession.ITestAccount __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.ITestAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.TestSession.ITestAccount __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.ITestAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.TestSession.ITestAccount __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.ITestAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.TestSession.ITestAccount __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.ITestAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.TestSession.ITestAccount __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.ITestAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='TestSession.TestTokenCachingStrategy']"
		[global::Android.Runtime.Register ("com/facebook/TestSession$TestTokenCachingStrategy", DoNotGenerateAcw=true)]
		public sealed partial class TestTokenCachingStrategy : global::Xamarin.FacebookBinding.TokenCachingStrategy {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/TestSession$TestTokenCachingStrategy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TestTokenCachingStrategy); }
			}

			internal TestTokenCachingStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_clear;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TestSession.TestTokenCachingStrategy']/method[@name='clear' and count(parameter)=0]"
			[Register ("clear", "()V", "")]
			public override void Clear ()
			{
				if (id_clear == IntPtr.Zero)
					id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
				JNIEnv.CallVoidMethod  (Handle, id_clear);
			}

			static IntPtr id_load;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TestSession.TestTokenCachingStrategy']/method[@name='load' and count(parameter)=0]"
			[Register ("load", "()Landroid/os/Bundle;", "")]
			public override global::Android.OS.Bundle Load ()
			{
				if (id_load == IntPtr.Zero)
					id_load = JNIEnv.GetMethodID (class_ref, "load", "()Landroid/os/Bundle;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_load), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_save_Landroid_os_Bundle_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TestSession.TestTokenCachingStrategy']/method[@name='save' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("save", "(Landroid/os/Bundle;)V", "")]
			public override void Save (global::Android.OS.Bundle p0)
			{
				if (id_save_Landroid_os_Bundle_ == IntPtr.Zero)
					id_save_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "save", "(Landroid/os/Bundle;)V");
				JNIEnv.CallVoidMethod  (Handle, id_save_Landroid_os_Bundle_, new JValue (p0));
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook']/interface[@name='TestSession.UserAccount']"
		[Register ("com/facebook/TestSession$UserAccount", "", "Xamarin.FacebookBinding.TestSession/IUserAccountInvoker")]
		public partial interface IUserAccount : global::Xamarin.FacebookBinding.Model.IGraphObject {

			string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/interface[@name='TestSession.UserAccount']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Xamarin.FacebookBinding.TestSession/IUserAccountInvoker, Xamarin.Facebook")] get;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/interface[@name='TestSession.UserAccount']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler:Xamarin.FacebookBinding.TestSession/IUserAccountInvoker, Xamarin.Facebook")] set;
			}

			string Uid {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/interface[@name='TestSession.UserAccount']/method[@name='getUid' and count(parameter)=0]"
				[Register ("getUid", "()Ljava/lang/String;", "GetGetUidHandler:Xamarin.FacebookBinding.TestSession/IUserAccountInvoker, Xamarin.Facebook")] get;
			}

		}

		[global::Android.Runtime.Register ("com/facebook/TestSession$UserAccount", DoNotGenerateAcw=true)]
		internal class IUserAccountInvoker : global::Java.Lang.Object, IUserAccount {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/TestSession$UserAccount");
			IntPtr class_ref;

			public static IUserAccount GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IUserAccount> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.TestSession.UserAccount"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IUserAccountInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IUserAccountInvoker); }
			}

			static Delegate cb_getName;
#pragma warning disable 0169
			static Delegate GetGetNameHandler ()
			{
				if (cb_getName == null)
					cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
				return cb_getName;
			}

			static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.TestSession.IUserAccount __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.IUserAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Name);
			}
#pragma warning restore 0169

			static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetName_Ljava_lang_String_Handler ()
			{
				if (cb_setName_Ljava_lang_String_ == null)
					cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
				return cb_setName_Ljava_lang_String_;
			}

			static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.TestSession.IUserAccount __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.IUserAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Name = p0;
			}
#pragma warning restore 0169

			IntPtr id_getName;
			IntPtr id_setName_Ljava_lang_String_;
			public string Name {
				get {
					if (id_getName == IntPtr.Zero)
						id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
						id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					JNIEnv.CallVoidMethod (Handle, id_setName_Ljava_lang_String_, new JValue (native_value));
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static Delegate cb_getUid;
#pragma warning disable 0169
			static Delegate GetGetUidHandler ()
			{
				if (cb_getUid == null)
					cb_getUid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUid);
				return cb_getUid;
			}

			static IntPtr n_GetUid (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.TestSession.IUserAccount __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.IUserAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Uid);
			}
#pragma warning restore 0169

			IntPtr id_getUid;
			public string Uid {
				get {
					if (id_getUid == IntPtr.Zero)
						id_getUid = JNIEnv.GetMethodID (class_ref, "getUid", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getUid), JniHandleOwnership.TransferLocalRef);
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
				global::Xamarin.FacebookBinding.TestSession.IUserAccount __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.IUserAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.TestSession.IUserAccount __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.IUserAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.TestSession.IUserAccount __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.IUserAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.TestSession.IUserAccount __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.IUserAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.TestSession.IUserAccount __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.IUserAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.TestSession.IUserAccount __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession.IUserAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/TestSession", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TestSession); }
		}

		protected TestSession (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getTestApplicationId;
		static IntPtr id_setTestApplicationId_Ljava_lang_String_;
		public static string TestApplicationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TestSession']/method[@name='getTestApplicationId' and count(parameter)=0]"
			[Register ("getTestApplicationId", "()Ljava/lang/String;", "GetGetTestApplicationIdHandler")]
			get {
				if (id_getTestApplicationId == IntPtr.Zero)
					id_getTestApplicationId = JNIEnv.GetStaticMethodID (class_ref, "getTestApplicationId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTestApplicationId), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TestSession']/method[@name='setTestApplicationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTestApplicationId", "(Ljava/lang/String;)V", "GetSetTestApplicationId_Ljava_lang_String_Handler")]
			set {
				if (id_setTestApplicationId_Ljava_lang_String_ == IntPtr.Zero)
					id_setTestApplicationId_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setTestApplicationId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setTestApplicationId_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getTestApplicationSecret;
		static IntPtr id_setTestApplicationSecret_Ljava_lang_String_;
		public static string TestApplicationSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TestSession']/method[@name='getTestApplicationSecret' and count(parameter)=0]"
			[Register ("getTestApplicationSecret", "()Ljava/lang/String;", "GetGetTestApplicationSecretHandler")]
			get {
				if (id_getTestApplicationSecret == IntPtr.Zero)
					id_getTestApplicationSecret = JNIEnv.GetStaticMethodID (class_ref, "getTestApplicationSecret", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTestApplicationSecret), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TestSession']/method[@name='setTestApplicationSecret' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTestApplicationSecret", "(Ljava/lang/String;)V", "GetSetTestApplicationSecret_Ljava_lang_String_Handler")]
			set {
				if (id_setTestApplicationSecret_Ljava_lang_String_ == IntPtr.Zero)
					id_setTestApplicationSecret_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setTestApplicationSecret", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setTestApplicationSecret_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getTestUserId;
		public string TestUserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TestSession']/method[@name='getTestUserId' and count(parameter)=0]"
			[Register ("getTestUserId", "()Ljava/lang/String;", "GetGetTestUserIdHandler")]
			get {
				if (id_getTestUserId == IntPtr.Zero)
					id_getTestUserId = JNIEnv.GetMethodID (class_ref, "getTestUserId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTestUserId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_createSessionWithPrivateUser_Landroid_app_Activity_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TestSession']/method[@name='createSessionWithPrivateUser' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.util.List']]"
		[Register ("createSessionWithPrivateUser", "(Landroid/app/Activity;Ljava/util/List;)Lcom/facebook/TestSession;", "")]
		public static global::Xamarin.FacebookBinding.TestSession CreateSessionWithPrivateUser (global::Android.App.Activity p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_createSessionWithPrivateUser_Landroid_app_Activity_Ljava_util_List_ == IntPtr.Zero)
				id_createSessionWithPrivateUser_Landroid_app_Activity_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "createSessionWithPrivateUser", "(Landroid/app/Activity;Ljava/util/List;)Lcom/facebook/TestSession;");
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			global::Xamarin.FacebookBinding.TestSession __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createSessionWithPrivateUser_Landroid_app_Activity_Ljava_util_List_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_createSessionWithSharedUser_Landroid_app_Activity_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TestSession']/method[@name='createSessionWithSharedUser' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.util.List']]"
		[Register ("createSessionWithSharedUser", "(Landroid/app/Activity;Ljava/util/List;)Lcom/facebook/TestSession;", "")]
		public static global::Xamarin.FacebookBinding.TestSession CreateSessionWithSharedUser (global::Android.App.Activity p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_createSessionWithSharedUser_Landroid_app_Activity_Ljava_util_List_ == IntPtr.Zero)
				id_createSessionWithSharedUser_Landroid_app_Activity_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "createSessionWithSharedUser", "(Landroid/app/Activity;Ljava/util/List;)Lcom/facebook/TestSession;");
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			global::Xamarin.FacebookBinding.TestSession __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createSessionWithSharedUser_Landroid_app_Activity_Ljava_util_List_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_createSessionWithSharedUser_Landroid_app_Activity_Ljava_util_List_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TestSession']/method[@name='createSessionWithSharedUser' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.util.List'] and parameter[3][@type='java.lang.String']]"
		[Register ("createSessionWithSharedUser", "(Landroid/app/Activity;Ljava/util/List;Ljava/lang/String;)Lcom/facebook/TestSession;", "")]
		public static global::Xamarin.FacebookBinding.TestSession CreateSessionWithSharedUser (global::Android.App.Activity p0, global::System.Collections.Generic.IList<string> p1, string p2)
		{
			if (id_createSessionWithSharedUser_Landroid_app_Activity_Ljava_util_List_Ljava_lang_String_ == IntPtr.Zero)
				id_createSessionWithSharedUser_Landroid_app_Activity_Ljava_util_List_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createSessionWithSharedUser", "(Landroid/app/Activity;Ljava/util/List;Ljava/lang/String;)Lcom/facebook/TestSession;");
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			global::Xamarin.FacebookBinding.TestSession __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.TestSession> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createSessionWithSharedUser_Landroid_app_Activity_Ljava_util_List_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='TestSession']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}
}
