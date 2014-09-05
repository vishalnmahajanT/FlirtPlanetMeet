using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding.Model {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']"
	[Register ("com/facebook/model/OpenGraphAction", "", "Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker")]
	public partial interface IOpenGraphAction : global::Xamarin.FacebookBinding.Model.IGraphObject {

		global::Xamarin.FacebookBinding.Model.IGraphObject Application {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='getApplication' and count(parameter)=0]"
			[Register ("getApplication", "()Lcom/facebook/model/GraphObject;", "GetGetApplicationHandler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='setApplication' and count(parameter)=1 and parameter[1][@type='com.facebook.model.GraphObject']]"
			[Register ("setApplication", "(Lcom/facebook/model/GraphObject;)V", "GetSetApplication_Lcom_facebook_model_GraphObject_Handler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] set;
		}

		global::Org.Json.JSONObject Comments {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='getComments' and count(parameter)=0]"
			[Register ("getComments", "()Lorg/json/JSONObject;", "GetGetCommentsHandler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='setComments' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("setComments", "(Lorg/json/JSONObject;)V", "GetSetComments_Lorg_json_JSONObject_Handler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] set;
		}

		global::Java.Util.Date CreatedTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='getCreatedTime' and count(parameter)=0]"
			[Register ("getCreatedTime", "()Ljava/util/Date;", "GetGetCreatedTimeHandler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='setCreatedTime' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setCreatedTime", "(Ljava/util/Date;)V", "GetSetCreatedTime_Ljava_util_Date_Handler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] set;
		}

		global::Java.Util.Date EndTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='getEndTime' and count(parameter)=0]"
			[Register ("getEndTime", "()Ljava/util/Date;", "GetGetEndTimeHandler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='setEndTime' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setEndTime", "(Ljava/util/Date;)V", "GetSetEndTime_Ljava_util_Date_Handler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] set;
		}

		global::Java.Util.Date ExpiresTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='getExpiresTime' and count(parameter)=0]"
			[Register ("getExpiresTime", "()Ljava/util/Date;", "GetGetExpiresTimeHandler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='setExpiresTime' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setExpiresTime", "(Ljava/util/Date;)V", "GetSetExpiresTime_Ljava_util_Date_Handler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] set;
		}

		global::Xamarin.FacebookBinding.Model.IGraphUser From {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='getFrom' and count(parameter)=0]"
			[Register ("getFrom", "()Lcom/facebook/model/GraphUser;", "GetGetFromHandler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='setFrom' and count(parameter)=1 and parameter[1][@type='com.facebook.model.GraphUser']]"
			[Register ("setFrom", "(Lcom/facebook/model/GraphUser;)V", "GetSetFrom_Lcom_facebook_model_GraphUser_Handler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] set;
		}

		string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setId", "(Ljava/lang/String;)V", "GetSetId_Ljava_lang_String_Handler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] set;
		}

		global::System.Collections.Generic.IList<global::Org.Json.JSONObject> Image {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='getImage' and count(parameter)=0]"
			[Register ("getImage", "()Ljava/util/List;", "GetGetImageHandler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='setImage' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
			[Register ("setImage", "(Ljava/util/List;)V", "GetSetImage_Ljava_util_List_Handler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] set;
		}

		global::Org.Json.JSONObject Likes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='getLikes' and count(parameter)=0]"
			[Register ("getLikes", "()Lorg/json/JSONObject;", "GetGetLikesHandler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='setLikes' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("setLikes", "(Lorg/json/JSONObject;)V", "GetSetLikes_Lorg_json_JSONObject_Handler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] set;
		}

		string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMessage", "(Ljava/lang/String;)V", "GetSetMessage_Ljava_lang_String_Handler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] set;
		}

		global::Xamarin.FacebookBinding.Model.IGraphPlace Place {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='getPlace' and count(parameter)=0]"
			[Register ("getPlace", "()Lcom/facebook/model/GraphPlace;", "GetGetPlaceHandler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='setPlace' and count(parameter)=1 and parameter[1][@type='com.facebook.model.GraphPlace']]"
			[Register ("setPlace", "(Lcom/facebook/model/GraphPlace;)V", "GetSetPlace_Lcom_facebook_model_GraphPlace_Handler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] set;
		}

		global::Java.Util.Date PublishTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='getPublishTime' and count(parameter)=0]"
			[Register ("getPublishTime", "()Ljava/util/Date;", "GetGetPublishTimeHandler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='setPublishTime' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setPublishTime", "(Ljava/util/Date;)V", "GetSetPublishTime_Ljava_util_Date_Handler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] set;
		}

		string Ref {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='getRef' and count(parameter)=0]"
			[Register ("getRef", "()Ljava/lang/String;", "GetGetRefHandler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='setRef' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRef", "(Ljava/lang/String;)V", "GetSetRef_Ljava_lang_String_Handler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] set;
		}

		global::Java.Util.Date StartTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='getStartTime' and count(parameter)=0]"
			[Register ("getStartTime", "()Ljava/util/Date;", "GetGetStartTimeHandler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='setStartTime' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setStartTime", "(Ljava/util/Date;)V", "GetSetStartTime_Ljava_util_Date_Handler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] set;
		}

		global::System.Collections.Generic.IList<global::Xamarin.FacebookBinding.Model.IGraphObject> Tags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='getTags' and count(parameter)=0]"
			[Register ("getTags", "()Ljava/util/List;", "GetGetTagsHandler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='OpenGraphAction']/method[@name='setTags' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
			[Register ("setTags", "(Ljava/util/List;)V", "GetSetTags_Ljava_util_List_Handler:Xamarin.FacebookBinding.Model.IOpenGraphActionInvoker, Xamarin.Facebook")] set;
		}

	}

	[global::Android.Runtime.Register ("com/facebook/model/OpenGraphAction", DoNotGenerateAcw=true)]
	internal class IOpenGraphActionInvoker : global::Java.Lang.Object, IOpenGraphAction {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/model/OpenGraphAction");
		IntPtr class_ref;

		public static IOpenGraphAction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOpenGraphAction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.model.OpenGraphAction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOpenGraphActionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOpenGraphActionInvoker); }
		}

		static Delegate cb_getApplication;
#pragma warning disable 0169
		static Delegate GetGetApplicationHandler ()
		{
			if (cb_getApplication == null)
				cb_getApplication = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplication);
			return cb_getApplication;
		}

		static IntPtr n_GetApplication (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Application);
		}
#pragma warning restore 0169

		static Delegate cb_setApplication_Lcom_facebook_model_GraphObject_;
#pragma warning disable 0169
		static Delegate GetSetApplication_Lcom_facebook_model_GraphObject_Handler ()
		{
			if (cb_setApplication_Lcom_facebook_model_GraphObject_ == null)
				cb_setApplication_Lcom_facebook_model_GraphObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetApplication_Lcom_facebook_model_GraphObject_);
			return cb_setApplication_Lcom_facebook_model_GraphObject_;
		}

		static void n_SetApplication_Lcom_facebook_model_GraphObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.Model.IGraphObject p0 = (global::Xamarin.FacebookBinding.Model.IGraphObject)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Application = p0;
		}
#pragma warning restore 0169

		IntPtr id_getApplication;
		IntPtr id_setApplication_Lcom_facebook_model_GraphObject_;
		public global::Xamarin.FacebookBinding.Model.IGraphObject Application {
			get {
				if (id_getApplication == IntPtr.Zero)
					id_getApplication = JNIEnv.GetMethodID (class_ref, "getApplication", "()Lcom/facebook/model/GraphObject;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObject> (JNIEnv.CallObjectMethod (Handle, id_getApplication), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setApplication_Lcom_facebook_model_GraphObject_ == IntPtr.Zero)
					id_setApplication_Lcom_facebook_model_GraphObject_ = JNIEnv.GetMethodID (class_ref, "setApplication", "(Lcom/facebook/model/GraphObject;)V");
				JNIEnv.CallVoidMethod (Handle, id_setApplication_Lcom_facebook_model_GraphObject_, new JValue (value));
			}
		}

		static Delegate cb_getComments;
#pragma warning disable 0169
		static Delegate GetGetCommentsHandler ()
		{
			if (cb_getComments == null)
				cb_getComments = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetComments);
			return cb_getComments;
		}

		static IntPtr n_GetComments (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Comments);
		}
#pragma warning restore 0169

		static Delegate cb_setComments_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetSetComments_Lorg_json_JSONObject_Handler ()
		{
			if (cb_setComments_Lorg_json_JSONObject_ == null)
				cb_setComments_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetComments_Lorg_json_JSONObject_);
			return cb_setComments_Lorg_json_JSONObject_;
		}

		static void n_SetComments_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Comments = p0;
		}
#pragma warning restore 0169

		IntPtr id_getComments;
		IntPtr id_setComments_Lorg_json_JSONObject_;
		public global::Org.Json.JSONObject Comments {
			get {
				if (id_getComments == IntPtr.Zero)
					id_getComments = JNIEnv.GetMethodID (class_ref, "getComments", "()Lorg/json/JSONObject;");
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (Handle, id_getComments), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setComments_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_setComments_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "setComments", "(Lorg/json/JSONObject;)V");
				JNIEnv.CallVoidMethod (Handle, id_setComments_Lorg_json_JSONObject_, new JValue (value));
			}
		}

		static Delegate cb_getCreatedTime;
#pragma warning disable 0169
		static Delegate GetGetCreatedTimeHandler ()
		{
			if (cb_getCreatedTime == null)
				cb_getCreatedTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreatedTime);
			return cb_getCreatedTime;
		}

		static IntPtr n_GetCreatedTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreatedTime);
		}
#pragma warning restore 0169

		static Delegate cb_setCreatedTime_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetCreatedTime_Ljava_util_Date_Handler ()
		{
			if (cb_setCreatedTime_Ljava_util_Date_ == null)
				cb_setCreatedTime_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCreatedTime_Ljava_util_Date_);
			return cb_setCreatedTime_Ljava_util_Date_;
		}

		static void n_SetCreatedTime_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreatedTime = p0;
		}
#pragma warning restore 0169

		IntPtr id_getCreatedTime;
		IntPtr id_setCreatedTime_Ljava_util_Date_;
		public global::Java.Util.Date CreatedTime {
			get {
				if (id_getCreatedTime == IntPtr.Zero)
					id_getCreatedTime = JNIEnv.GetMethodID (class_ref, "getCreatedTime", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (Handle, id_getCreatedTime), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setCreatedTime_Ljava_util_Date_ == IntPtr.Zero)
					id_setCreatedTime_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setCreatedTime", "(Ljava/util/Date;)V");
				JNIEnv.CallVoidMethod (Handle, id_setCreatedTime_Ljava_util_Date_, new JValue (value));
			}
		}

		static Delegate cb_getEndTime;
#pragma warning disable 0169
		static Delegate GetGetEndTimeHandler ()
		{
			if (cb_getEndTime == null)
				cb_getEndTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndTime);
			return cb_getEndTime;
		}

		static IntPtr n_GetEndTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EndTime);
		}
#pragma warning restore 0169

		static Delegate cb_setEndTime_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetEndTime_Ljava_util_Date_Handler ()
		{
			if (cb_setEndTime_Ljava_util_Date_ == null)
				cb_setEndTime_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEndTime_Ljava_util_Date_);
			return cb_setEndTime_Ljava_util_Date_;
		}

		static void n_SetEndTime_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EndTime = p0;
		}
#pragma warning restore 0169

		IntPtr id_getEndTime;
		IntPtr id_setEndTime_Ljava_util_Date_;
		public global::Java.Util.Date EndTime {
			get {
				if (id_getEndTime == IntPtr.Zero)
					id_getEndTime = JNIEnv.GetMethodID (class_ref, "getEndTime", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (Handle, id_getEndTime), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setEndTime_Ljava_util_Date_ == IntPtr.Zero)
					id_setEndTime_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setEndTime", "(Ljava/util/Date;)V");
				JNIEnv.CallVoidMethod (Handle, id_setEndTime_Ljava_util_Date_, new JValue (value));
			}
		}

		static Delegate cb_getExpiresTime;
#pragma warning disable 0169
		static Delegate GetGetExpiresTimeHandler ()
		{
			if (cb_getExpiresTime == null)
				cb_getExpiresTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExpiresTime);
			return cb_getExpiresTime;
		}

		static IntPtr n_GetExpiresTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExpiresTime);
		}
#pragma warning restore 0169

		static Delegate cb_setExpiresTime_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetExpiresTime_Ljava_util_Date_Handler ()
		{
			if (cb_setExpiresTime_Ljava_util_Date_ == null)
				cb_setExpiresTime_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExpiresTime_Ljava_util_Date_);
			return cb_setExpiresTime_Ljava_util_Date_;
		}

		static void n_SetExpiresTime_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExpiresTime = p0;
		}
#pragma warning restore 0169

		IntPtr id_getExpiresTime;
		IntPtr id_setExpiresTime_Ljava_util_Date_;
		public global::Java.Util.Date ExpiresTime {
			get {
				if (id_getExpiresTime == IntPtr.Zero)
					id_getExpiresTime = JNIEnv.GetMethodID (class_ref, "getExpiresTime", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (Handle, id_getExpiresTime), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setExpiresTime_Ljava_util_Date_ == IntPtr.Zero)
					id_setExpiresTime_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setExpiresTime", "(Ljava/util/Date;)V");
				JNIEnv.CallVoidMethod (Handle, id_setExpiresTime_Ljava_util_Date_, new JValue (value));
			}
		}

		static Delegate cb_getFrom;
#pragma warning disable 0169
		static Delegate GetGetFromHandler ()
		{
			if (cb_getFrom == null)
				cb_getFrom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFrom);
			return cb_getFrom;
		}

		static IntPtr n_GetFrom (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.From);
		}
#pragma warning restore 0169

		static Delegate cb_setFrom_Lcom_facebook_model_GraphUser_;
#pragma warning disable 0169
		static Delegate GetSetFrom_Lcom_facebook_model_GraphUser_Handler ()
		{
			if (cb_setFrom_Lcom_facebook_model_GraphUser_ == null)
				cb_setFrom_Lcom_facebook_model_GraphUser_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFrom_Lcom_facebook_model_GraphUser_);
			return cb_setFrom_Lcom_facebook_model_GraphUser_;
		}

		static void n_SetFrom_Lcom_facebook_model_GraphUser_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.Model.IGraphUser p0 = (global::Xamarin.FacebookBinding.Model.IGraphUser)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.From = p0;
		}
#pragma warning restore 0169

		IntPtr id_getFrom;
		IntPtr id_setFrom_Lcom_facebook_model_GraphUser_;
		public global::Xamarin.FacebookBinding.Model.IGraphUser From {
			get {
				if (id_getFrom == IntPtr.Zero)
					id_getFrom = JNIEnv.GetMethodID (class_ref, "getFrom", "()Lcom/facebook/model/GraphUser;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphUser> (JNIEnv.CallObjectMethod (Handle, id_getFrom), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setFrom_Lcom_facebook_model_GraphUser_ == IntPtr.Zero)
					id_setFrom_Lcom_facebook_model_GraphUser_ = JNIEnv.GetMethodID (class_ref, "setFrom", "(Lcom/facebook/model/GraphUser;)V");
				JNIEnv.CallVoidMethod (Handle, id_setFrom_Lcom_facebook_model_GraphUser_, new JValue (value));
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
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getImage;
#pragma warning disable 0169
		static Delegate GetGetImageHandler ()
		{
			if (cb_getImage == null)
				cb_getImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImage);
			return cb_getImage;
		}

		static IntPtr n_GetImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Json.JSONObject>.ToLocalJniHandle (__this.Image);
		}
#pragma warning restore 0169

		static Delegate cb_setImage_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetImage_Ljava_util_List_Handler ()
		{
			if (cb_setImage_Ljava_util_List_ == null)
				cb_setImage_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImage_Ljava_util_List_);
			return cb_setImage_Ljava_util_List_;
		}

		static void n_SetImage_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Org.Json.JSONObject> p0 = global::Android.Runtime.JavaList<global::Org.Json.JSONObject>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Image = p0;
		}
#pragma warning restore 0169

		IntPtr id_getImage;
		IntPtr id_setImage_Ljava_util_List_;
		public global::System.Collections.Generic.IList<global::Org.Json.JSONObject> Image {
			get {
				if (id_getImage == IntPtr.Zero)
					id_getImage = JNIEnv.GetMethodID (class_ref, "getImage", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Org.Json.JSONObject>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getImage), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setImage_Ljava_util_List_ == IntPtr.Zero)
					id_setImage_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setImage", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Org.Json.JSONObject>.ToLocalJniHandle (value);
				JNIEnv.CallVoidMethod (Handle, id_setImage_Ljava_util_List_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getLikes;
#pragma warning disable 0169
		static Delegate GetGetLikesHandler ()
		{
			if (cb_getLikes == null)
				cb_getLikes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLikes);
			return cb_getLikes;
		}

		static IntPtr n_GetLikes (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Likes);
		}
#pragma warning restore 0169

		static Delegate cb_setLikes_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetSetLikes_Lorg_json_JSONObject_Handler ()
		{
			if (cb_setLikes_Lorg_json_JSONObject_ == null)
				cb_setLikes_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLikes_Lorg_json_JSONObject_);
			return cb_setLikes_Lorg_json_JSONObject_;
		}

		static void n_SetLikes_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Likes = p0;
		}
#pragma warning restore 0169

		IntPtr id_getLikes;
		IntPtr id_setLikes_Lorg_json_JSONObject_;
		public global::Org.Json.JSONObject Likes {
			get {
				if (id_getLikes == IntPtr.Zero)
					id_getLikes = JNIEnv.GetMethodID (class_ref, "getLikes", "()Lorg/json/JSONObject;");
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (Handle, id_getLikes), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setLikes_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_setLikes_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "setLikes", "(Lorg/json/JSONObject;)V");
				JNIEnv.CallVoidMethod (Handle, id_setLikes_Lorg_json_JSONObject_, new JValue (value));
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		static Delegate cb_setMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setMessage_Ljava_lang_String_ == null)
				cb_setMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessage_Ljava_lang_String_);
			return cb_setMessage_Ljava_lang_String_;
		}

		static void n_SetMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Message = p0;
		}
#pragma warning restore 0169

		IntPtr id_getMessage;
		IntPtr id_setMessage_Ljava_lang_String_;
		public string Message {
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod (Handle, id_setMessage_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getPlace;
#pragma warning disable 0169
		static Delegate GetGetPlaceHandler ()
		{
			if (cb_getPlace == null)
				cb_getPlace = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlace);
			return cb_getPlace;
		}

		static IntPtr n_GetPlace (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Place);
		}
#pragma warning restore 0169

		static Delegate cb_setPlace_Lcom_facebook_model_GraphPlace_;
#pragma warning disable 0169
		static Delegate GetSetPlace_Lcom_facebook_model_GraphPlace_Handler ()
		{
			if (cb_setPlace_Lcom_facebook_model_GraphPlace_ == null)
				cb_setPlace_Lcom_facebook_model_GraphPlace_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPlace_Lcom_facebook_model_GraphPlace_);
			return cb_setPlace_Lcom_facebook_model_GraphPlace_;
		}

		static void n_SetPlace_Lcom_facebook_model_GraphPlace_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.Model.IGraphPlace p0 = (global::Xamarin.FacebookBinding.Model.IGraphPlace)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphPlace> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Place = p0;
		}
#pragma warning restore 0169

		IntPtr id_getPlace;
		IntPtr id_setPlace_Lcom_facebook_model_GraphPlace_;
		public global::Xamarin.FacebookBinding.Model.IGraphPlace Place {
			get {
				if (id_getPlace == IntPtr.Zero)
					id_getPlace = JNIEnv.GetMethodID (class_ref, "getPlace", "()Lcom/facebook/model/GraphPlace;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphPlace> (JNIEnv.CallObjectMethod (Handle, id_getPlace), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setPlace_Lcom_facebook_model_GraphPlace_ == IntPtr.Zero)
					id_setPlace_Lcom_facebook_model_GraphPlace_ = JNIEnv.GetMethodID (class_ref, "setPlace", "(Lcom/facebook/model/GraphPlace;)V");
				JNIEnv.CallVoidMethod (Handle, id_setPlace_Lcom_facebook_model_GraphPlace_, new JValue (value));
			}
		}

		static Delegate cb_getPublishTime;
#pragma warning disable 0169
		static Delegate GetGetPublishTimeHandler ()
		{
			if (cb_getPublishTime == null)
				cb_getPublishTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPublishTime);
			return cb_getPublishTime;
		}

		static IntPtr n_GetPublishTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PublishTime);
		}
#pragma warning restore 0169

		static Delegate cb_setPublishTime_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetPublishTime_Ljava_util_Date_Handler ()
		{
			if (cb_setPublishTime_Ljava_util_Date_ == null)
				cb_setPublishTime_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPublishTime_Ljava_util_Date_);
			return cb_setPublishTime_Ljava_util_Date_;
		}

		static void n_SetPublishTime_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PublishTime = p0;
		}
#pragma warning restore 0169

		IntPtr id_getPublishTime;
		IntPtr id_setPublishTime_Ljava_util_Date_;
		public global::Java.Util.Date PublishTime {
			get {
				if (id_getPublishTime == IntPtr.Zero)
					id_getPublishTime = JNIEnv.GetMethodID (class_ref, "getPublishTime", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (Handle, id_getPublishTime), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setPublishTime_Ljava_util_Date_ == IntPtr.Zero)
					id_setPublishTime_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setPublishTime", "(Ljava/util/Date;)V");
				JNIEnv.CallVoidMethod (Handle, id_setPublishTime_Ljava_util_Date_, new JValue (value));
			}
		}

		static Delegate cb_getRef;
#pragma warning disable 0169
		static Delegate GetGetRefHandler ()
		{
			if (cb_getRef == null)
				cb_getRef = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRef);
			return cb_getRef;
		}

		static IntPtr n_GetRef (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Ref);
		}
#pragma warning restore 0169

		static Delegate cb_setRef_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRef_Ljava_lang_String_Handler ()
		{
			if (cb_setRef_Ljava_lang_String_ == null)
				cb_setRef_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRef_Ljava_lang_String_);
			return cb_setRef_Ljava_lang_String_;
		}

		static void n_SetRef_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Ref = p0;
		}
#pragma warning restore 0169

		IntPtr id_getRef;
		IntPtr id_setRef_Ljava_lang_String_;
		public string Ref {
			get {
				if (id_getRef == IntPtr.Zero)
					id_getRef = JNIEnv.GetMethodID (class_ref, "getRef", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getRef), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setRef_Ljava_lang_String_ == IntPtr.Zero)
					id_setRef_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRef", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod (Handle, id_setRef_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getStartTime;
#pragma warning disable 0169
		static Delegate GetGetStartTimeHandler ()
		{
			if (cb_getStartTime == null)
				cb_getStartTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStartTime);
			return cb_getStartTime;
		}

		static IntPtr n_GetStartTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StartTime);
		}
#pragma warning restore 0169

		static Delegate cb_setStartTime_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetStartTime_Ljava_util_Date_Handler ()
		{
			if (cb_setStartTime_Ljava_util_Date_ == null)
				cb_setStartTime_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStartTime_Ljava_util_Date_);
			return cb_setStartTime_Ljava_util_Date_;
		}

		static void n_SetStartTime_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartTime = p0;
		}
#pragma warning restore 0169

		IntPtr id_getStartTime;
		IntPtr id_setStartTime_Ljava_util_Date_;
		public global::Java.Util.Date StartTime {
			get {
				if (id_getStartTime == IntPtr.Zero)
					id_getStartTime = JNIEnv.GetMethodID (class_ref, "getStartTime", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (Handle, id_getStartTime), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setStartTime_Ljava_util_Date_ == IntPtr.Zero)
					id_setStartTime_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setStartTime", "(Ljava/util/Date;)V");
				JNIEnv.CallVoidMethod (Handle, id_setStartTime_Ljava_util_Date_, new JValue (value));
			}
		}

		static Delegate cb_getTags;
#pragma warning disable 0169
		static Delegate GetGetTagsHandler ()
		{
			if (cb_getTags == null)
				cb_getTags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTags);
			return cb_getTags;
		}

		static IntPtr n_GetTags (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Xamarin.FacebookBinding.Model.IGraphObject>.ToLocalJniHandle (__this.Tags);
		}
#pragma warning restore 0169

		static Delegate cb_setTags_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetTags_Ljava_util_List_Handler ()
		{
			if (cb_setTags_Ljava_util_List_ == null)
				cb_setTags_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTags_Ljava_util_List_);
			return cb_setTags_Ljava_util_List_;
		}

		static void n_SetTags_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Xamarin.FacebookBinding.Model.IGraphObject> p0 = global::Android.Runtime.JavaList<global::Xamarin.FacebookBinding.Model.IGraphObject>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Tags = p0;
		}
#pragma warning restore 0169

		IntPtr id_getTags;
		IntPtr id_setTags_Ljava_util_List_;
		public global::System.Collections.Generic.IList<global::Xamarin.FacebookBinding.Model.IGraphObject> Tags {
			get {
				if (id_getTags == IntPtr.Zero)
					id_getTags = JNIEnv.GetMethodID (class_ref, "getTags", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Xamarin.FacebookBinding.Model.IGraphObject>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getTags), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setTags_Ljava_util_List_ == IntPtr.Zero)
					id_setTags_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setTags", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Xamarin.FacebookBinding.Model.IGraphObject>.ToLocalJniHandle (value);
				JNIEnv.CallVoidMethod (Handle, id_setTags_Ljava_util_List_, new JValue (native_value));
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
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Xamarin.FacebookBinding.Model.IOpenGraphAction __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IOpenGraphAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
