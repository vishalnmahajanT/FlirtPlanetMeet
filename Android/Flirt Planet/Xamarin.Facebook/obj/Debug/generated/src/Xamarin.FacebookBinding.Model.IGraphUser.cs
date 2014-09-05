using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding.Model {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphUser']"
	[Register ("com/facebook/model/GraphUser", "", "Xamarin.FacebookBinding.Model.IGraphUserInvoker")]
	public partial interface IGraphUser : global::Xamarin.FacebookBinding.Model.IGraphObject {

		string Birthday {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphUser']/method[@name='getBirthday' and count(parameter)=0]"
			[Register ("getBirthday", "()Ljava/lang/String;", "GetGetBirthdayHandler:Xamarin.FacebookBinding.Model.IGraphUserInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphUser']/method[@name='setBirthday' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBirthday", "(Ljava/lang/String;)V", "GetSetBirthday_Ljava_lang_String_Handler:Xamarin.FacebookBinding.Model.IGraphUserInvoker, Xamarin.Facebook")] set;
		}

		string FirstName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphUser']/method[@name='getFirstName' and count(parameter)=0]"
			[Register ("getFirstName", "()Ljava/lang/String;", "GetGetFirstNameHandler:Xamarin.FacebookBinding.Model.IGraphUserInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphUser']/method[@name='setFirstName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFirstName", "(Ljava/lang/String;)V", "GetSetFirstName_Ljava_lang_String_Handler:Xamarin.FacebookBinding.Model.IGraphUserInvoker, Xamarin.Facebook")] set;
		}

		string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphUser']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler:Xamarin.FacebookBinding.Model.IGraphUserInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphUser']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setId", "(Ljava/lang/String;)V", "GetSetId_Ljava_lang_String_Handler:Xamarin.FacebookBinding.Model.IGraphUserInvoker, Xamarin.Facebook")] set;
		}

		string LastName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphUser']/method[@name='getLastName' and count(parameter)=0]"
			[Register ("getLastName", "()Ljava/lang/String;", "GetGetLastNameHandler:Xamarin.FacebookBinding.Model.IGraphUserInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphUser']/method[@name='setLastName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLastName", "(Ljava/lang/String;)V", "GetSetLastName_Ljava_lang_String_Handler:Xamarin.FacebookBinding.Model.IGraphUserInvoker, Xamarin.Facebook")] set;
		}

		string Link {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphUser']/method[@name='getLink' and count(parameter)=0]"
			[Register ("getLink", "()Ljava/lang/String;", "GetGetLinkHandler:Xamarin.FacebookBinding.Model.IGraphUserInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphUser']/method[@name='setLink' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLink", "(Ljava/lang/String;)V", "GetSetLink_Ljava_lang_String_Handler:Xamarin.FacebookBinding.Model.IGraphUserInvoker, Xamarin.Facebook")] set;
		}

		global::Xamarin.FacebookBinding.Model.IGraphLocation Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphUser']/method[@name='getLocation' and count(parameter)=0]"
			[Register ("getLocation", "()Lcom/facebook/model/GraphLocation;", "GetGetLocationHandler:Xamarin.FacebookBinding.Model.IGraphUserInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphUser']/method[@name='setLocation' and count(parameter)=1 and parameter[1][@type='com.facebook.model.GraphLocation']]"
			[Register ("setLocation", "(Lcom/facebook/model/GraphLocation;)V", "GetSetLocation_Lcom_facebook_model_GraphLocation_Handler:Xamarin.FacebookBinding.Model.IGraphUserInvoker, Xamarin.Facebook")] set;
		}

		string MiddleName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphUser']/method[@name='getMiddleName' and count(parameter)=0]"
			[Register ("getMiddleName", "()Ljava/lang/String;", "GetGetMiddleNameHandler:Xamarin.FacebookBinding.Model.IGraphUserInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphUser']/method[@name='setMiddleName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMiddleName", "(Ljava/lang/String;)V", "GetSetMiddleName_Ljava_lang_String_Handler:Xamarin.FacebookBinding.Model.IGraphUserInvoker, Xamarin.Facebook")] set;
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphUser']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Xamarin.FacebookBinding.Model.IGraphUserInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphUser']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler:Xamarin.FacebookBinding.Model.IGraphUserInvoker, Xamarin.Facebook")] set;
		}

		string Username {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphUser']/method[@name='getUsername' and count(parameter)=0]"
			[Register ("getUsername", "()Ljava/lang/String;", "GetGetUsernameHandler:Xamarin.FacebookBinding.Model.IGraphUserInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphUser']/method[@name='setUsername' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUsername", "(Ljava/lang/String;)V", "GetSetUsername_Ljava_lang_String_Handler:Xamarin.FacebookBinding.Model.IGraphUserInvoker, Xamarin.Facebook")] set;
		}

	}

	[global::Android.Runtime.Register ("com/facebook/model/GraphUser", DoNotGenerateAcw=true)]
	internal class IGraphUserInvoker : global::Java.Lang.Object, IGraphUser {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/model/GraphUser");
		IntPtr class_ref;

		public static IGraphUser GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGraphUser> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.model.GraphUser"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGraphUserInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IGraphUserInvoker); }
		}

		static Delegate cb_getBirthday;
#pragma warning disable 0169
		static Delegate GetGetBirthdayHandler ()
		{
			if (cb_getBirthday == null)
				cb_getBirthday = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBirthday);
			return cb_getBirthday;
		}

		static IntPtr n_GetBirthday (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IGraphUser __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Birthday);
		}
#pragma warning restore 0169

		static Delegate cb_setBirthday_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBirthday_Ljava_lang_String_Handler ()
		{
			if (cb_setBirthday_Ljava_lang_String_ == null)
				cb_setBirthday_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBirthday_Ljava_lang_String_);
			return cb_setBirthday_Ljava_lang_String_;
		}

		static void n_SetBirthday_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IGraphUser __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Birthday = p0;
		}
#pragma warning restore 0169

		IntPtr id_getBirthday;
		IntPtr id_setBirthday_Ljava_lang_String_;
		public string Birthday {
			get {
				if (id_getBirthday == IntPtr.Zero)
					id_getBirthday = JNIEnv.GetMethodID (class_ref, "getBirthday", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getBirthday), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setBirthday_Ljava_lang_String_ == IntPtr.Zero)
					id_setBirthday_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBirthday", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod (Handle, id_setBirthday_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getFirstName;
#pragma warning disable 0169
		static Delegate GetGetFirstNameHandler ()
		{
			if (cb_getFirstName == null)
				cb_getFirstName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFirstName);
			return cb_getFirstName;
		}

		static IntPtr n_GetFirstName (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IGraphUser __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FirstName);
		}
#pragma warning restore 0169

		static Delegate cb_setFirstName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFirstName_Ljava_lang_String_Handler ()
		{
			if (cb_setFirstName_Ljava_lang_String_ == null)
				cb_setFirstName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFirstName_Ljava_lang_String_);
			return cb_setFirstName_Ljava_lang_String_;
		}

		static void n_SetFirstName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IGraphUser __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FirstName = p0;
		}
#pragma warning restore 0169

		IntPtr id_getFirstName;
		IntPtr id_setFirstName_Ljava_lang_String_;
		public string FirstName {
			get {
				if (id_getFirstName == IntPtr.Zero)
					id_getFirstName = JNIEnv.GetMethodID (class_ref, "getFirstName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getFirstName), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setFirstName_Ljava_lang_String_ == IntPtr.Zero)
					id_setFirstName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFirstName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod (Handle, id_setFirstName_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Xamarin.FacebookBinding.Model.IGraphUser __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static Delegate cb_setId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetId_Ljava_lang_String_Handler ()
		{
			if (cb_setId_Ljava_lang_String_ == null)
				cb_setId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetId_Ljava_lang_String_);
			return cb_setId_Ljava_lang_String_;
		}

		static void n_SetId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IGraphUser __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		IntPtr id_getId;
		IntPtr id_setId_Ljava_lang_String_;
		public string Id {
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setId_Ljava_lang_String_ == IntPtr.Zero)
					id_setId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod (Handle, id_setId_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getLastName;
#pragma warning disable 0169
		static Delegate GetGetLastNameHandler ()
		{
			if (cb_getLastName == null)
				cb_getLastName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastName);
			return cb_getLastName;
		}

		static IntPtr n_GetLastName (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IGraphUser __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LastName);
		}
#pragma warning restore 0169

		static Delegate cb_setLastName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLastName_Ljava_lang_String_Handler ()
		{
			if (cb_setLastName_Ljava_lang_String_ == null)
				cb_setLastName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLastName_Ljava_lang_String_);
			return cb_setLastName_Ljava_lang_String_;
		}

		static void n_SetLastName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IGraphUser __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LastName = p0;
		}
#pragma warning restore 0169

		IntPtr id_getLastName;
		IntPtr id_setLastName_Ljava_lang_String_;
		public string LastName {
			get {
				if (id_getLastName == IntPtr.Zero)
					id_getLastName = JNIEnv.GetMethodID (class_ref, "getLastName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getLastName), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setLastName_Ljava_lang_String_ == IntPtr.Zero)
					id_setLastName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLastName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod (Handle, id_setLastName_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getLink;
#pragma warning disable 0169
		static Delegate GetGetLinkHandler ()
		{
			if (cb_getLink == null)
				cb_getLink = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLink);
			return cb_getLink;
		}

		static IntPtr n_GetLink (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IGraphUser __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Link);
		}
#pragma warning restore 0169

		static Delegate cb_setLink_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLink_Ljava_lang_String_Handler ()
		{
			if (cb_setLink_Ljava_lang_String_ == null)
				cb_setLink_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLink_Ljava_lang_String_);
			return cb_setLink_Ljava_lang_String_;
		}

		static void n_SetLink_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IGraphUser __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Link = p0;
		}
#pragma warning restore 0169

		IntPtr id_getLink;
		IntPtr id_setLink_Ljava_lang_String_;
		public string Link {
			get {
				if (id_getLink == IntPtr.Zero)
					id_getLink = JNIEnv.GetMethodID (class_ref, "getLink", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getLink), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setLink_Ljava_lang_String_ == IntPtr.Zero)
					id_setLink_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLink", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod (Handle, id_setLink_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getLocation;
#pragma warning disable 0169
		static Delegate GetGetLocationHandler ()
		{
			if (cb_getLocation == null)
				cb_getLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocation);
			return cb_getLocation;
		}

		static IntPtr n_GetLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IGraphUser __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Location);
		}
#pragma warning restore 0169

		static Delegate cb_setLocation_Lcom_facebook_model_GraphLocation_;
#pragma warning disable 0169
		static Delegate GetSetLocation_Lcom_facebook_model_GraphLocation_Handler ()
		{
			if (cb_setLocation_Lcom_facebook_model_GraphLocation_ == null)
				cb_setLocation_Lcom_facebook_model_GraphLocation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocation_Lcom_facebook_model_GraphLocation_);
			return cb_setLocation_Lcom_facebook_model_GraphLocation_;
		}

		static void n_SetLocation_Lcom_facebook_model_GraphLocation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IGraphUser __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.Model.IGraphLocation p0 = (global::Xamarin.FacebookBinding.Model.IGraphLocation)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphLocation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Location = p0;
		}
#pragma warning restore 0169

		IntPtr id_getLocation;
		IntPtr id_setLocation_Lcom_facebook_model_GraphLocation_;
		public global::Xamarin.FacebookBinding.Model.IGraphLocation Location {
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Lcom/facebook/model/GraphLocation;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphLocation> (JNIEnv.CallObjectMethod (Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setLocation_Lcom_facebook_model_GraphLocation_ == IntPtr.Zero)
					id_setLocation_Lcom_facebook_model_GraphLocation_ = JNIEnv.GetMethodID (class_ref, "setLocation", "(Lcom/facebook/model/GraphLocation;)V");
				JNIEnv.CallVoidMethod (Handle, id_setLocation_Lcom_facebook_model_GraphLocation_, new JValue (value));
			}
		}

		static Delegate cb_getMiddleName;
#pragma warning disable 0169
		static Delegate GetGetMiddleNameHandler ()
		{
			if (cb_getMiddleName == null)
				cb_getMiddleName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMiddleName);
			return cb_getMiddleName;
		}

		static IntPtr n_GetMiddleName (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IGraphUser __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MiddleName);
		}
#pragma warning restore 0169

		static Delegate cb_setMiddleName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMiddleName_Ljava_lang_String_Handler ()
		{
			if (cb_setMiddleName_Ljava_lang_String_ == null)
				cb_setMiddleName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMiddleName_Ljava_lang_String_);
			return cb_setMiddleName_Ljava_lang_String_;
		}

		static void n_SetMiddleName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IGraphUser __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MiddleName = p0;
		}
#pragma warning restore 0169

		IntPtr id_getMiddleName;
		IntPtr id_setMiddleName_Ljava_lang_String_;
		public string MiddleName {
			get {
				if (id_getMiddleName == IntPtr.Zero)
					id_getMiddleName = JNIEnv.GetMethodID (class_ref, "getMiddleName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getMiddleName), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setMiddleName_Ljava_lang_String_ == IntPtr.Zero)
					id_setMiddleName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMiddleName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod (Handle, id_setMiddleName_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Xamarin.FacebookBinding.Model.IGraphUser __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Xamarin.FacebookBinding.Model.IGraphUser __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getUsername;
#pragma warning disable 0169
		static Delegate GetGetUsernameHandler ()
		{
			if (cb_getUsername == null)
				cb_getUsername = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUsername);
			return cb_getUsername;
		}

		static IntPtr n_GetUsername (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IGraphUser __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Username);
		}
#pragma warning restore 0169

		static Delegate cb_setUsername_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUsername_Ljava_lang_String_Handler ()
		{
			if (cb_setUsername_Ljava_lang_String_ == null)
				cb_setUsername_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUsername_Ljava_lang_String_);
			return cb_setUsername_Ljava_lang_String_;
		}

		static void n_SetUsername_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IGraphUser __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Username = p0;
		}
#pragma warning restore 0169

		IntPtr id_getUsername;
		IntPtr id_setUsername_Ljava_lang_String_;
		public string Username {
			get {
				if (id_getUsername == IntPtr.Zero)
					id_getUsername = JNIEnv.GetMethodID (class_ref, "getUsername", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getUsername), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setUsername_Ljava_lang_String_ == IntPtr.Zero)
					id_setUsername_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUsername", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod (Handle, id_setUsername_Ljava_lang_String_, new JValue (native_value));
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
			global::Xamarin.FacebookBinding.Model.IGraphUser __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Xamarin.FacebookBinding.Model.IGraphUser __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Xamarin.FacebookBinding.Model.IGraphUser __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Xamarin.FacebookBinding.Model.IGraphUser __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Xamarin.FacebookBinding.Model.IGraphUser __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Xamarin.FacebookBinding.Model.IGraphUser __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
