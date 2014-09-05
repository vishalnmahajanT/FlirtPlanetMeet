using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='Response']"
	[global::Android.Runtime.Register ("com/facebook/Response", DoNotGenerateAcw=true)]
	public partial class Response : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='Response']/field[@name='NON_JSON_RESPONSE_PROPERTY']"
		[Register ("NON_JSON_RESPONSE_PROPERTY")]
		public const string NonJsonResponseProperty = (string) "FACEBOOK_NON_JSON_RESULT";
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook']/interface[@name='Response.PagedResults']"
		[Register ("com/facebook/Response$PagedResults", "", "Xamarin.FacebookBinding.Response/IPagedResultsInvoker")]
		public partial interface IPagedResults : global::Xamarin.FacebookBinding.Model.IGraphObject {

			global::Xamarin.FacebookBinding.Model.IGraphObjectList Data {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/interface[@name='Response.PagedResults']/method[@name='getData' and count(parameter)=0]"
				[Register ("getData", "()Lcom/facebook/model/GraphObjectList;", "GetGetDataHandler:Xamarin.FacebookBinding.Response/IPagedResultsInvoker, Xamarin.Facebook")] get;
			}

		}

		[global::Android.Runtime.Register ("com/facebook/Response$PagedResults", DoNotGenerateAcw=true)]
		internal class IPagedResultsInvoker : global::Java.Lang.Object, IPagedResults {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/Response$PagedResults");
			IntPtr class_ref;

			public static IPagedResults GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPagedResults> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.Response.PagedResults"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPagedResultsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IPagedResultsInvoker); }
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
				global::Xamarin.FacebookBinding.Response.IPagedResults __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response.IPagedResults> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.Response.IPagedResults __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response.IPagedResults> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.Response.IPagedResults __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response.IPagedResults> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.Response.IPagedResults __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response.IPagedResults> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.Response.IPagedResults __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response.IPagedResults> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.Response.IPagedResults __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response.IPagedResults> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.Response.IPagedResults __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response.IPagedResults> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='Response.PagingDirection']"
		[global::Android.Runtime.Register ("com/facebook/Response$PagingDirection", DoNotGenerateAcw=true)]
		public sealed partial class PagingDirection : global::Java.Lang.Enum {


			static IntPtr NEXT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='Response.PagingDirection']/field[@name='NEXT']"
			[Register ("NEXT")]
			public static global::Xamarin.FacebookBinding.Response.PagingDirection Next {
				get {
					if (NEXT_jfieldId == IntPtr.Zero)
						NEXT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEXT", "Lcom/facebook/Response$PagingDirection;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NEXT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response.PagingDirection> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (NEXT_jfieldId == IntPtr.Zero)
						NEXT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEXT", "Lcom/facebook/Response$PagingDirection;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, NEXT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PREVIOUS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='Response.PagingDirection']/field[@name='PREVIOUS']"
			[Register ("PREVIOUS")]
			public static global::Xamarin.FacebookBinding.Response.PagingDirection Previous {
				get {
					if (PREVIOUS_jfieldId == IntPtr.Zero)
						PREVIOUS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREVIOUS", "Lcom/facebook/Response$PagingDirection;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PREVIOUS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response.PagingDirection> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PREVIOUS_jfieldId == IntPtr.Zero)
						PREVIOUS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREVIOUS", "Lcom/facebook/Response$PagingDirection;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PREVIOUS_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/Response$PagingDirection", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PagingDirection); }
			}

			internal PagingDirection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Response.PagingDirection']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/facebook/Response$PagingDirection;", "")]
			public static global::Xamarin.FacebookBinding.Response.PagingDirection ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/facebook/Response$PagingDirection;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Xamarin.FacebookBinding.Response.PagingDirection __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response.PagingDirection> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Response.PagingDirection']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/facebook/Response$PagingDirection;", "")]
			public static global::Xamarin.FacebookBinding.Response.PagingDirection[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/facebook/Response$PagingDirection;");
				return (global::Xamarin.FacebookBinding.Response.PagingDirection[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Xamarin.FacebookBinding.Response.PagingDirection));
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook']/interface[@name='Response.PagingInfo']"
		[Register ("com/facebook/Response$PagingInfo", "", "Xamarin.FacebookBinding.Response/IPagingInfoInvoker")]
		public partial interface IPagingInfo : global::Xamarin.FacebookBinding.Model.IGraphObject {

			string Next {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/interface[@name='Response.PagingInfo']/method[@name='getNext' and count(parameter)=0]"
				[Register ("getNext", "()Ljava/lang/String;", "GetGetNextHandler:Xamarin.FacebookBinding.Response/IPagingInfoInvoker, Xamarin.Facebook")] get;
			}

			string Previous {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/interface[@name='Response.PagingInfo']/method[@name='getPrevious' and count(parameter)=0]"
				[Register ("getPrevious", "()Ljava/lang/String;", "GetGetPreviousHandler:Xamarin.FacebookBinding.Response/IPagingInfoInvoker, Xamarin.Facebook")] get;
			}

		}

		[global::Android.Runtime.Register ("com/facebook/Response$PagingInfo", DoNotGenerateAcw=true)]
		internal class IPagingInfoInvoker : global::Java.Lang.Object, IPagingInfo {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/Response$PagingInfo");
			IntPtr class_ref;

			public static IPagingInfo GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPagingInfo> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.Response.PagingInfo"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPagingInfoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IPagingInfoInvoker); }
			}

			static Delegate cb_getNext;
#pragma warning disable 0169
			static Delegate GetGetNextHandler ()
			{
				if (cb_getNext == null)
					cb_getNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNext);
				return cb_getNext;
			}

			static IntPtr n_GetNext (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.Response.IPagingInfo __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response.IPagingInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Next);
			}
#pragma warning restore 0169

			IntPtr id_getNext;
			public string Next {
				get {
					if (id_getNext == IntPtr.Zero)
						id_getNext = JNIEnv.GetMethodID (class_ref, "getNext", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getNext), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getPrevious;
#pragma warning disable 0169
			static Delegate GetGetPreviousHandler ()
			{
				if (cb_getPrevious == null)
					cb_getPrevious = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrevious);
				return cb_getPrevious;
			}

			static IntPtr n_GetPrevious (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.Response.IPagingInfo __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response.IPagingInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Previous);
			}
#pragma warning restore 0169

			IntPtr id_getPrevious;
			public string Previous {
				get {
					if (id_getPrevious == IntPtr.Zero)
						id_getPrevious = JNIEnv.GetMethodID (class_ref, "getPrevious", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getPrevious), JniHandleOwnership.TransferLocalRef);
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
				global::Xamarin.FacebookBinding.Response.IPagingInfo __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response.IPagingInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.Response.IPagingInfo __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response.IPagingInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.Response.IPagingInfo __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response.IPagingInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.Response.IPagingInfo __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response.IPagingInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.Response.IPagingInfo __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response.IPagingInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Xamarin.FacebookBinding.Response.IPagingInfo __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response.IPagingInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/Response", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Response); }
		}

		protected Response (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getConnection;
		public global::Java.Net.HttpURLConnection Connection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Response']/method[@name='getConnection' and count(parameter)=0]"
			[Register ("getConnection", "()Ljava/net/HttpURLConnection;", "GetGetConnectionHandler")]
			get {
				if (id_getConnection == IntPtr.Zero)
					id_getConnection = JNIEnv.GetMethodID (class_ref, "getConnection", "()Ljava/net/HttpURLConnection;");
				return global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (JNIEnv.CallObjectMethod  (Handle, id_getConnection), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getError;
		public global::Xamarin.FacebookBinding.FacebookRequestError Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Response']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()Lcom/facebook/FacebookRequestError;", "GetGetErrorHandler")]
			get {
				if (id_getError == IntPtr.Zero)
					id_getError = JNIEnv.GetMethodID (class_ref, "getError", "()Lcom/facebook/FacebookRequestError;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.FacebookRequestError> (JNIEnv.CallObjectMethod  (Handle, id_getError), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getGraphObject;
		public global::Xamarin.FacebookBinding.Model.IGraphObject GraphObject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Response']/method[@name='getGraphObject' and count(parameter)=0]"
			[Register ("getGraphObject", "()Lcom/facebook/model/GraphObject;", "GetGetGraphObjectHandler")]
			get {
				if (id_getGraphObject == IntPtr.Zero)
					id_getGraphObject = JNIEnv.GetMethodID (class_ref, "getGraphObject", "()Lcom/facebook/model/GraphObject;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObject> (JNIEnv.CallObjectMethod  (Handle, id_getGraphObject), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getGraphObjectList;
		public global::Xamarin.FacebookBinding.Model.IGraphObjectList GraphObjectList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Response']/method[@name='getGraphObjectList' and count(parameter)=0]"
			[Register ("getGraphObjectList", "()Lcom/facebook/model/GraphObjectList;", "GetGetGraphObjectListHandler")]
			get {
				if (id_getGraphObjectList == IntPtr.Zero)
					id_getGraphObjectList = JNIEnv.GetMethodID (class_ref, "getGraphObjectList", "()Lcom/facebook/model/GraphObjectList;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObjectList> (JNIEnv.CallObjectMethod  (Handle, id_getGraphObjectList), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getIsFromCache;
		public bool IsFromCache {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Response']/method[@name='getIsFromCache' and count(parameter)=0]"
			[Register ("getIsFromCache", "()Z", "GetGetIsFromCacheHandler")]
			get {
				if (id_getIsFromCache == IntPtr.Zero)
					id_getIsFromCache = JNIEnv.GetMethodID (class_ref, "getIsFromCache", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_getIsFromCache);
			}
		}

		static Delegate cb_getRequest;
#pragma warning disable 0169
		static Delegate GetGetRequestHandler ()
		{
			if (cb_getRequest == null)
				cb_getRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequest);
			return cb_getRequest;
		}

		static IntPtr n_GetRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Response __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Request);
		}
#pragma warning restore 0169

		static IntPtr id_getRequest;
		public virtual global::Xamarin.FacebookBinding.Request Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Response']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lcom/facebook/Request;", "GetGetRequestHandler")]
			get {
				if (id_getRequest == IntPtr.Zero)
					id_getRequest = JNIEnv.GetMethodID (class_ref, "getRequest", "()Lcom/facebook/Request;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request> (JNIEnv.CallObjectMethod  (Handle, id_getRequest), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequest", "()Lcom/facebook/Request;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getGraphObjectAs_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Response']/method[@name='getGraphObjectAs' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("getGraphObjectAs", "(Ljava/lang/Class;)Lcom/facebook/model/GraphObject;", "")]
		public global::Java.Lang.Object GetGraphObjectAs (global::Java.Lang.Class p0)
		{
			if (id_getGraphObjectAs_Ljava_lang_Class_ == IntPtr.Zero)
				id_getGraphObjectAs_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "getGraphObjectAs", "(Ljava/lang/Class;)Lcom/facebook/model/GraphObject;");
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getGraphObjectAs_Ljava_lang_Class_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getGraphObjectListAs_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Response']/method[@name='getGraphObjectListAs' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("getGraphObjectListAs", "(Ljava/lang/Class;)Lcom/facebook/model/GraphObjectList;", "")]
		public global::Xamarin.FacebookBinding.Model.IGraphObjectList GetGraphObjectListAs (global::Java.Lang.Class p0)
		{
			if (id_getGraphObjectListAs_Ljava_lang_Class_ == IntPtr.Zero)
				id_getGraphObjectListAs_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "getGraphObjectListAs", "(Ljava/lang/Class;)Lcom/facebook/model/GraphObjectList;");
			global::Xamarin.FacebookBinding.Model.IGraphObjectList __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObjectList> (JNIEnv.CallObjectMethod  (Handle, id_getGraphObjectListAs_Ljava_lang_Class_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getRequestForPagedResults_Lcom_facebook_Response_PagingDirection_;
#pragma warning disable 0169
		static Delegate GetGetRequestForPagedResults_Lcom_facebook_Response_PagingDirection_Handler ()
		{
			if (cb_getRequestForPagedResults_Lcom_facebook_Response_PagingDirection_ == null)
				cb_getRequestForPagedResults_Lcom_facebook_Response_PagingDirection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRequestForPagedResults_Lcom_facebook_Response_PagingDirection_);
			return cb_getRequestForPagedResults_Lcom_facebook_Response_PagingDirection_;
		}

		static IntPtr n_GetRequestForPagedResults_Lcom_facebook_Response_PagingDirection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Response __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.Response.PagingDirection p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Response.PagingDirection> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRequestForPagedResults (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRequestForPagedResults_Lcom_facebook_Response_PagingDirection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='Response']/method[@name='getRequestForPagedResults' and count(parameter)=1 and parameter[1][@type='com.facebook.Response.PagingDirection']]"
		[Register ("getRequestForPagedResults", "(Lcom/facebook/Response$PagingDirection;)Lcom/facebook/Request;", "GetGetRequestForPagedResults_Lcom_facebook_Response_PagingDirection_Handler")]
		public virtual global::Xamarin.FacebookBinding.Request GetRequestForPagedResults (global::Xamarin.FacebookBinding.Response.PagingDirection p0)
		{
			if (id_getRequestForPagedResults_Lcom_facebook_Response_PagingDirection_ == IntPtr.Zero)
				id_getRequestForPagedResults_Lcom_facebook_Response_PagingDirection_ = JNIEnv.GetMethodID (class_ref, "getRequestForPagedResults", "(Lcom/facebook/Response$PagingDirection;)Lcom/facebook/Request;");

			global::Xamarin.FacebookBinding.Request __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request> (JNIEnv.CallObjectMethod  (Handle, id_getRequestForPagedResults_Lcom_facebook_Response_PagingDirection_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestForPagedResults", "(Lcom/facebook/Response$PagingDirection;)Lcom/facebook/Request;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
