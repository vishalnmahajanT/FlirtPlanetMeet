using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError']"
	[global::Android.Runtime.Register ("com/facebook/FacebookRequestError", DoNotGenerateAcw=true)]
	public sealed partial class FacebookRequestError : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError']/field[@name='INVALID_ERROR_CODE']"
		[Register ("INVALID_ERROR_CODE")]
		public const int InvalidErrorCode = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError']/field[@name='INVALID_HTTP_STATUS_CODE']"
		[Register ("INVALID_HTTP_STATUS_CODE")]
		public const int InvalidHttpStatusCode = (int) -1;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError.Category']"
		[global::Android.Runtime.Register ("com/facebook/FacebookRequestError$Category", DoNotGenerateAcw=true)]
		public sealed partial class Category : global::Java.Lang.Enum {


			static IntPtr AUTHENTICATION_REOPEN_SESSION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError.Category']/field[@name='AUTHENTICATION_REOPEN_SESSION']"
			[Register ("AUTHENTICATION_REOPEN_SESSION")]
			public static global::Xamarin.FacebookBinding.FacebookRequestError.Category AuthenticationReopenSession {
				get {
					if (AUTHENTICATION_REOPEN_SESSION_jfieldId == IntPtr.Zero)
						AUTHENTICATION_REOPEN_SESSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHENTICATION_REOPEN_SESSION", "Lcom/facebook/FacebookRequestError$Category;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTHENTICATION_REOPEN_SESSION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.FacebookRequestError.Category> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (AUTHENTICATION_REOPEN_SESSION_jfieldId == IntPtr.Zero)
						AUTHENTICATION_REOPEN_SESSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHENTICATION_REOPEN_SESSION", "Lcom/facebook/FacebookRequestError$Category;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, AUTHENTICATION_REOPEN_SESSION_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr AUTHENTICATION_RETRY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError.Category']/field[@name='AUTHENTICATION_RETRY']"
			[Register ("AUTHENTICATION_RETRY")]
			public static global::Xamarin.FacebookBinding.FacebookRequestError.Category AuthenticationRetry {
				get {
					if (AUTHENTICATION_RETRY_jfieldId == IntPtr.Zero)
						AUTHENTICATION_RETRY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHENTICATION_RETRY", "Lcom/facebook/FacebookRequestError$Category;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTHENTICATION_RETRY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.FacebookRequestError.Category> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (AUTHENTICATION_RETRY_jfieldId == IntPtr.Zero)
						AUTHENTICATION_RETRY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHENTICATION_RETRY", "Lcom/facebook/FacebookRequestError$Category;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, AUTHENTICATION_RETRY_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr BAD_REQUEST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError.Category']/field[@name='BAD_REQUEST']"
			[Register ("BAD_REQUEST")]
			public static global::Xamarin.FacebookBinding.FacebookRequestError.Category BadRequest {
				get {
					if (BAD_REQUEST_jfieldId == IntPtr.Zero)
						BAD_REQUEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BAD_REQUEST", "Lcom/facebook/FacebookRequestError$Category;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BAD_REQUEST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.FacebookRequestError.Category> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BAD_REQUEST_jfieldId == IntPtr.Zero)
						BAD_REQUEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BAD_REQUEST", "Lcom/facebook/FacebookRequestError$Category;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BAD_REQUEST_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr CLIENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError.Category']/field[@name='CLIENT']"
			[Register ("CLIENT")]
			public static global::Xamarin.FacebookBinding.FacebookRequestError.Category Client {
				get {
					if (CLIENT_jfieldId == IntPtr.Zero)
						CLIENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIENT", "Lcom/facebook/FacebookRequestError$Category;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLIENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.FacebookRequestError.Category> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CLIENT_jfieldId == IntPtr.Zero)
						CLIENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIENT", "Lcom/facebook/FacebookRequestError$Category;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CLIENT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr OTHER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError.Category']/field[@name='OTHER']"
			[Register ("OTHER")]
			public static global::Xamarin.FacebookBinding.FacebookRequestError.Category Other {
				get {
					if (OTHER_jfieldId == IntPtr.Zero)
						OTHER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OTHER", "Lcom/facebook/FacebookRequestError$Category;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OTHER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.FacebookRequestError.Category> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (OTHER_jfieldId == IntPtr.Zero)
						OTHER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OTHER", "Lcom/facebook/FacebookRequestError$Category;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, OTHER_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PERMISSION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError.Category']/field[@name='PERMISSION']"
			[Register ("PERMISSION")]
			public static global::Xamarin.FacebookBinding.FacebookRequestError.Category Permission {
				get {
					if (PERMISSION_jfieldId == IntPtr.Zero)
						PERMISSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERMISSION", "Lcom/facebook/FacebookRequestError$Category;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PERMISSION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.FacebookRequestError.Category> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PERMISSION_jfieldId == IntPtr.Zero)
						PERMISSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERMISSION", "Lcom/facebook/FacebookRequestError$Category;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PERMISSION_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SERVER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError.Category']/field[@name='SERVER']"
			[Register ("SERVER")]
			public static global::Xamarin.FacebookBinding.FacebookRequestError.Category Server {
				get {
					if (SERVER_jfieldId == IntPtr.Zero)
						SERVER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVER", "Lcom/facebook/FacebookRequestError$Category;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SERVER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.FacebookRequestError.Category> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SERVER_jfieldId == IntPtr.Zero)
						SERVER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVER", "Lcom/facebook/FacebookRequestError$Category;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SERVER_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr THROTTLING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError.Category']/field[@name='THROTTLING']"
			[Register ("THROTTLING")]
			public static global::Xamarin.FacebookBinding.FacebookRequestError.Category Throttling {
				get {
					if (THROTTLING_jfieldId == IntPtr.Zero)
						THROTTLING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THROTTLING", "Lcom/facebook/FacebookRequestError$Category;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THROTTLING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.FacebookRequestError.Category> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (THROTTLING_jfieldId == IntPtr.Zero)
						THROTTLING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THROTTLING", "Lcom/facebook/FacebookRequestError$Category;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, THROTTLING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/FacebookRequestError$Category", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Category); }
			}

			internal Category (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError.Category']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/facebook/FacebookRequestError$Category;", "")]
			public static global::Xamarin.FacebookBinding.FacebookRequestError.Category ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/facebook/FacebookRequestError$Category;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Xamarin.FacebookBinding.FacebookRequestError.Category __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.FacebookRequestError.Category> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError.Category']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/facebook/FacebookRequestError$Category;", "")]
			public static global::Xamarin.FacebookBinding.FacebookRequestError.Category[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/facebook/FacebookRequestError$Category;");
				return (global::Xamarin.FacebookBinding.FacebookRequestError.Category[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Xamarin.FacebookBinding.FacebookRequestError.Category));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError.Range']"
		[global::Android.Runtime.Register ("com/facebook/FacebookRequestError$Range", DoNotGenerateAcw=true)]
		public partial class Range : global::Java.Lang.Object {

			protected Range (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/FacebookRequestError", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FacebookRequestError); }
		}

		internal FacebookRequestError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError']/constructor[@name='FacebookRequestError' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;Ljava/lang/String;)V", "")]
		public FacebookRequestError (int p0, string p1, string p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (FacebookRequestError)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILjava/lang/String;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILjava/lang/String;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2));
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILjava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_getBatchRequestResult;
		public global::Java.Lang.Object BatchRequestResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError']/method[@name='getBatchRequestResult' and count(parameter)=0]"
			[Register ("getBatchRequestResult", "()Ljava/lang/Object;", "GetGetBatchRequestResultHandler")]
			get {
				if (id_getBatchRequestResult == IntPtr.Zero)
					id_getBatchRequestResult = JNIEnv.GetMethodID (class_ref, "getBatchRequestResult", "()Ljava/lang/Object;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getBatchRequestResult), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getConnection;
		public global::Java.Net.HttpURLConnection Connection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError']/method[@name='getConnection' and count(parameter)=0]"
			[Register ("getConnection", "()Ljava/net/HttpURLConnection;", "GetGetConnectionHandler")]
			get {
				if (id_getConnection == IntPtr.Zero)
					id_getConnection = JNIEnv.GetMethodID (class_ref, "getConnection", "()Ljava/net/HttpURLConnection;");
				return global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (JNIEnv.CallObjectMethod  (Handle, id_getConnection), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getErrorCode;
		public int ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()I", "GetGetErrorCodeHandler")]
			get {
				if (id_getErrorCode == IntPtr.Zero)
					id_getErrorCode = JNIEnv.GetMethodID (class_ref, "getErrorCode", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getErrorCode);
			}
		}

		static IntPtr id_getErrorMessage;
		public string ErrorMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError']/method[@name='getErrorMessage' and count(parameter)=0]"
			[Register ("getErrorMessage", "()Ljava/lang/String;", "GetGetErrorMessageHandler")]
			get {
				if (id_getErrorMessage == IntPtr.Zero)
					id_getErrorMessage = JNIEnv.GetMethodID (class_ref, "getErrorMessage", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getErrorMessage), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getErrorType;
		public string ErrorType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError']/method[@name='getErrorType' and count(parameter)=0]"
			[Register ("getErrorType", "()Ljava/lang/String;", "GetGetErrorTypeHandler")]
			get {
				if (id_getErrorType == IntPtr.Zero)
					id_getErrorType = JNIEnv.GetMethodID (class_ref, "getErrorType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getErrorType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getException;
		public global::Xamarin.FacebookBinding.FacebookException Exception {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError']/method[@name='getException' and count(parameter)=0]"
			[Register ("getException", "()Lcom/facebook/FacebookException;", "GetGetExceptionHandler")]
			get {
				if (id_getException == IntPtr.Zero)
					id_getException = JNIEnv.GetMethodID (class_ref, "getException", "()Lcom/facebook/FacebookException;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.FacebookException> (JNIEnv.CallObjectMethod  (Handle, id_getException), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getRequestResult;
		public global::Org.Json.JSONObject RequestResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError']/method[@name='getRequestResult' and count(parameter)=0]"
			[Register ("getRequestResult", "()Lorg/json/JSONObject;", "GetGetRequestResultHandler")]
			get {
				if (id_getRequestResult == IntPtr.Zero)
					id_getRequestResult = JNIEnv.GetMethodID (class_ref, "getRequestResult", "()Lorg/json/JSONObject;");
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getRequestResult), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getRequestResultBody;
		public global::Org.Json.JSONObject RequestResultBody {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError']/method[@name='getRequestResultBody' and count(parameter)=0]"
			[Register ("getRequestResultBody", "()Lorg/json/JSONObject;", "GetGetRequestResultBodyHandler")]
			get {
				if (id_getRequestResultBody == IntPtr.Zero)
					id_getRequestResultBody = JNIEnv.GetMethodID (class_ref, "getRequestResultBody", "()Lorg/json/JSONObject;");
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getRequestResultBody), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getRequestStatusCode;
		public int RequestStatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError']/method[@name='getRequestStatusCode' and count(parameter)=0]"
			[Register ("getRequestStatusCode", "()I", "GetGetRequestStatusCodeHandler")]
			get {
				if (id_getRequestStatusCode == IntPtr.Zero)
					id_getRequestStatusCode = JNIEnv.GetMethodID (class_ref, "getRequestStatusCode", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getRequestStatusCode);
			}
		}

		static IntPtr id_getSubErrorCode;
		public int SubErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError']/method[@name='getSubErrorCode' and count(parameter)=0]"
			[Register ("getSubErrorCode", "()I", "GetGetSubErrorCodeHandler")]
			get {
				if (id_getSubErrorCode == IntPtr.Zero)
					id_getSubErrorCode = JNIEnv.GetMethodID (class_ref, "getSubErrorCode", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getSubErrorCode);
			}
		}

		static IntPtr id_getUserActionMessageId;
		public int UserActionMessageId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError']/method[@name='getUserActionMessageId' and count(parameter)=0]"
			[Register ("getUserActionMessageId", "()I", "GetGetUserActionMessageIdHandler")]
			get {
				if (id_getUserActionMessageId == IntPtr.Zero)
					id_getUserActionMessageId = JNIEnv.GetMethodID (class_ref, "getUserActionMessageId", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getUserActionMessageId);
			}
		}

		static IntPtr id_getCategory;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError']/method[@name='getCategory' and count(parameter)=0]"
		[Register ("getCategory", "()Lcom/facebook/FacebookRequestError$Category;", "")]
		public global::Xamarin.FacebookBinding.FacebookRequestError.Category GetCategory ()
		{
			if (id_getCategory == IntPtr.Zero)
				id_getCategory = JNIEnv.GetMethodID (class_ref, "getCategory", "()Lcom/facebook/FacebookRequestError$Category;");
			return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.FacebookRequestError.Category> (JNIEnv.CallObjectMethod  (Handle, id_getCategory), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_shouldNotifyUser;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='FacebookRequestError']/method[@name='shouldNotifyUser' and count(parameter)=0]"
		[Register ("shouldNotifyUser", "()Z", "")]
		public bool ShouldNotifyUser ()
		{
			if (id_shouldNotifyUser == IntPtr.Zero)
				id_shouldNotifyUser = JNIEnv.GetMethodID (class_ref, "shouldNotifyUser", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_shouldNotifyUser);
		}

	}
}
