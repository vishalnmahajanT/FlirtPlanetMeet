using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding.Model {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphLocation']"
	[Register ("com/facebook/model/GraphLocation", "", "Xamarin.FacebookBinding.Model.IGraphLocationInvoker")]
	public partial interface IGraphLocation : global::Xamarin.FacebookBinding.Model.IGraphObject {

		string City {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphLocation']/method[@name='getCity' and count(parameter)=0]"
			[Register ("getCity", "()Ljava/lang/String;", "GetGetCityHandler:Xamarin.FacebookBinding.Model.IGraphLocationInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphLocation']/method[@name='setCity' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCity", "(Ljava/lang/String;)V", "GetSetCity_Ljava_lang_String_Handler:Xamarin.FacebookBinding.Model.IGraphLocationInvoker, Xamarin.Facebook")] set;
		}

		string Country {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphLocation']/method[@name='getCountry' and count(parameter)=0]"
			[Register ("getCountry", "()Ljava/lang/String;", "GetGetCountryHandler:Xamarin.FacebookBinding.Model.IGraphLocationInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphLocation']/method[@name='setCountry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCountry", "(Ljava/lang/String;)V", "GetSetCountry_Ljava_lang_String_Handler:Xamarin.FacebookBinding.Model.IGraphLocationInvoker, Xamarin.Facebook")] set;
		}

		double Latitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphLocation']/method[@name='getLatitude' and count(parameter)=0]"
			[Register ("getLatitude", "()D", "GetGetLatitudeHandler:Xamarin.FacebookBinding.Model.IGraphLocationInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphLocation']/method[@name='setLatitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLatitude", "(D)V", "GetSetLatitude_DHandler:Xamarin.FacebookBinding.Model.IGraphLocationInvoker, Xamarin.Facebook")] set;
		}

		double Longitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphLocation']/method[@name='getLongitude' and count(parameter)=0]"
			[Register ("getLongitude", "()D", "GetGetLongitudeHandler:Xamarin.FacebookBinding.Model.IGraphLocationInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphLocation']/method[@name='setLongitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLongitude", "(D)V", "GetSetLongitude_DHandler:Xamarin.FacebookBinding.Model.IGraphLocationInvoker, Xamarin.Facebook")] set;
		}

		string State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphLocation']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Ljava/lang/String;", "GetGetStateHandler:Xamarin.FacebookBinding.Model.IGraphLocationInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphLocation']/method[@name='setState' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setState", "(Ljava/lang/String;)V", "GetSetState_Ljava_lang_String_Handler:Xamarin.FacebookBinding.Model.IGraphLocationInvoker, Xamarin.Facebook")] set;
		}

		string Street {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphLocation']/method[@name='getStreet' and count(parameter)=0]"
			[Register ("getStreet", "()Ljava/lang/String;", "GetGetStreetHandler:Xamarin.FacebookBinding.Model.IGraphLocationInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphLocation']/method[@name='setStreet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStreet", "(Ljava/lang/String;)V", "GetSetStreet_Ljava_lang_String_Handler:Xamarin.FacebookBinding.Model.IGraphLocationInvoker, Xamarin.Facebook")] set;
		}

		string Zip {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphLocation']/method[@name='getZip' and count(parameter)=0]"
			[Register ("getZip", "()Ljava/lang/String;", "GetGetZipHandler:Xamarin.FacebookBinding.Model.IGraphLocationInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphLocation']/method[@name='setZip' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setZip", "(Ljava/lang/String;)V", "GetSetZip_Ljava_lang_String_Handler:Xamarin.FacebookBinding.Model.IGraphLocationInvoker, Xamarin.Facebook")] set;
		}

	}

	[global::Android.Runtime.Register ("com/facebook/model/GraphLocation", DoNotGenerateAcw=true)]
	internal class IGraphLocationInvoker : global::Java.Lang.Object, IGraphLocation {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/model/GraphLocation");
		IntPtr class_ref;

		public static IGraphLocation GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGraphLocation> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.model.GraphLocation"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGraphLocationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IGraphLocationInvoker); }
		}

		static Delegate cb_getCity;
#pragma warning disable 0169
		static Delegate GetGetCityHandler ()
		{
			if (cb_getCity == null)
				cb_getCity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCity);
			return cb_getCity;
		}

		static IntPtr n_GetCity (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IGraphLocation __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.City);
		}
#pragma warning restore 0169

		static Delegate cb_setCity_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCity_Ljava_lang_String_Handler ()
		{
			if (cb_setCity_Ljava_lang_String_ == null)
				cb_setCity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCity_Ljava_lang_String_);
			return cb_setCity_Ljava_lang_String_;
		}

		static void n_SetCity_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IGraphLocation __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.City = p0;
		}
#pragma warning restore 0169

		IntPtr id_getCity;
		IntPtr id_setCity_Ljava_lang_String_;
		public string City {
			get {
				if (id_getCity == IntPtr.Zero)
					id_getCity = JNIEnv.GetMethodID (class_ref, "getCity", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getCity), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setCity_Ljava_lang_String_ == IntPtr.Zero)
					id_setCity_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCity", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod (Handle, id_setCity_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getCountry;
#pragma warning disable 0169
		static Delegate GetGetCountryHandler ()
		{
			if (cb_getCountry == null)
				cb_getCountry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCountry);
			return cb_getCountry;
		}

		static IntPtr n_GetCountry (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IGraphLocation __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Country);
		}
#pragma warning restore 0169

		static Delegate cb_setCountry_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCountry_Ljava_lang_String_Handler ()
		{
			if (cb_setCountry_Ljava_lang_String_ == null)
				cb_setCountry_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCountry_Ljava_lang_String_);
			return cb_setCountry_Ljava_lang_String_;
		}

		static void n_SetCountry_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IGraphLocation __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Country = p0;
		}
#pragma warning restore 0169

		IntPtr id_getCountry;
		IntPtr id_setCountry_Ljava_lang_String_;
		public string Country {
			get {
				if (id_getCountry == IntPtr.Zero)
					id_getCountry = JNIEnv.GetMethodID (class_ref, "getCountry", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getCountry), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setCountry_Ljava_lang_String_ == IntPtr.Zero)
					id_setCountry_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCountry", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod (Handle, id_setCountry_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getLatitude;
#pragma warning disable 0169
		static Delegate GetGetLatitudeHandler ()
		{
			if (cb_getLatitude == null)
				cb_getLatitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLatitude);
			return cb_getLatitude;
		}

		static double n_GetLatitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IGraphLocation __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Latitude;
		}
#pragma warning restore 0169

		static Delegate cb_setLatitude_D;
#pragma warning disable 0169
		static Delegate GetSetLatitude_DHandler ()
		{
			if (cb_setLatitude_D == null)
				cb_setLatitude_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetLatitude_D);
			return cb_setLatitude_D;
		}

		static void n_SetLatitude_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Xamarin.FacebookBinding.Model.IGraphLocation __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Latitude = p0;
		}
#pragma warning restore 0169

		IntPtr id_getLatitude;
		IntPtr id_setLatitude_D;
		public double Latitude {
			get {
				if (id_getLatitude == IntPtr.Zero)
					id_getLatitude = JNIEnv.GetMethodID (class_ref, "getLatitude", "()D");
				return JNIEnv.CallDoubleMethod (Handle, id_getLatitude);
			}
			set {
				if (id_setLatitude_D == IntPtr.Zero)
					id_setLatitude_D = JNIEnv.GetMethodID (class_ref, "setLatitude", "(D)V");
				JNIEnv.CallVoidMethod (Handle, id_setLatitude_D, new JValue (value));
			}
		}

		static Delegate cb_getLongitude;
#pragma warning disable 0169
		static Delegate GetGetLongitudeHandler ()
		{
			if (cb_getLongitude == null)
				cb_getLongitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLongitude);
			return cb_getLongitude;
		}

		static double n_GetLongitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IGraphLocation __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Longitude;
		}
#pragma warning restore 0169

		static Delegate cb_setLongitude_D;
#pragma warning disable 0169
		static Delegate GetSetLongitude_DHandler ()
		{
			if (cb_setLongitude_D == null)
				cb_setLongitude_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetLongitude_D);
			return cb_setLongitude_D;
		}

		static void n_SetLongitude_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Xamarin.FacebookBinding.Model.IGraphLocation __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Longitude = p0;
		}
#pragma warning restore 0169

		IntPtr id_getLongitude;
		IntPtr id_setLongitude_D;
		public double Longitude {
			get {
				if (id_getLongitude == IntPtr.Zero)
					id_getLongitude = JNIEnv.GetMethodID (class_ref, "getLongitude", "()D");
				return JNIEnv.CallDoubleMethod (Handle, id_getLongitude);
			}
			set {
				if (id_setLongitude_D == IntPtr.Zero)
					id_setLongitude_D = JNIEnv.GetMethodID (class_ref, "setLongitude", "(D)V");
				JNIEnv.CallVoidMethod (Handle, id_setLongitude_D, new JValue (value));
			}
		}

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetState);
			return cb_getState;
		}

		static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IGraphLocation __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.State);
		}
#pragma warning restore 0169

		static Delegate cb_setState_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetState_Ljava_lang_String_Handler ()
		{
			if (cb_setState_Ljava_lang_String_ == null)
				cb_setState_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetState_Ljava_lang_String_);
			return cb_setState_Ljava_lang_String_;
		}

		static void n_SetState_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IGraphLocation __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.State = p0;
		}
#pragma warning restore 0169

		IntPtr id_getState;
		IntPtr id_setState_Ljava_lang_String_;
		public string State {
			get {
				if (id_getState == IntPtr.Zero)
					id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getState), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setState_Ljava_lang_String_ == IntPtr.Zero)
					id_setState_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setState", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod (Handle, id_setState_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getStreet;
#pragma warning disable 0169
		static Delegate GetGetStreetHandler ()
		{
			if (cb_getStreet == null)
				cb_getStreet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStreet);
			return cb_getStreet;
		}

		static IntPtr n_GetStreet (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IGraphLocation __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Street);
		}
#pragma warning restore 0169

		static Delegate cb_setStreet_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStreet_Ljava_lang_String_Handler ()
		{
			if (cb_setStreet_Ljava_lang_String_ == null)
				cb_setStreet_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStreet_Ljava_lang_String_);
			return cb_setStreet_Ljava_lang_String_;
		}

		static void n_SetStreet_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IGraphLocation __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Street = p0;
		}
#pragma warning restore 0169

		IntPtr id_getStreet;
		IntPtr id_setStreet_Ljava_lang_String_;
		public string Street {
			get {
				if (id_getStreet == IntPtr.Zero)
					id_getStreet = JNIEnv.GetMethodID (class_ref, "getStreet", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getStreet), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setStreet_Ljava_lang_String_ == IntPtr.Zero)
					id_setStreet_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStreet", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod (Handle, id_setStreet_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getZip;
#pragma warning disable 0169
		static Delegate GetGetZipHandler ()
		{
			if (cb_getZip == null)
				cb_getZip = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetZip);
			return cb_getZip;
		}

		static IntPtr n_GetZip (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IGraphLocation __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Zip);
		}
#pragma warning restore 0169

		static Delegate cb_setZip_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetZip_Ljava_lang_String_Handler ()
		{
			if (cb_setZip_Ljava_lang_String_ == null)
				cb_setZip_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetZip_Ljava_lang_String_);
			return cb_setZip_Ljava_lang_String_;
		}

		static void n_SetZip_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IGraphLocation __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Zip = p0;
		}
#pragma warning restore 0169

		IntPtr id_getZip;
		IntPtr id_setZip_Ljava_lang_String_;
		public string Zip {
			get {
				if (id_getZip == IntPtr.Zero)
					id_getZip = JNIEnv.GetMethodID (class_ref, "getZip", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getZip), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setZip_Ljava_lang_String_ == IntPtr.Zero)
					id_setZip_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setZip", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod (Handle, id_setZip_Ljava_lang_String_, new JValue (native_value));
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
			global::Xamarin.FacebookBinding.Model.IGraphLocation __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Xamarin.FacebookBinding.Model.IGraphLocation __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Xamarin.FacebookBinding.Model.IGraphLocation __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Xamarin.FacebookBinding.Model.IGraphLocation __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Xamarin.FacebookBinding.Model.IGraphLocation __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Xamarin.FacebookBinding.Model.IGraphLocation __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
