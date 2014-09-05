using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='SessionState']"
	[global::Android.Runtime.Register ("com/facebook/SessionState", DoNotGenerateAcw=true)]
	public sealed partial class SessionState : global::Java.Lang.Enum {


		static IntPtr CLOSED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='SessionState']/field[@name='CLOSED']"
		[Register ("CLOSED")]
		public static global::Xamarin.FacebookBinding.SessionState Closed {
			get {
				if (CLOSED_jfieldId == IntPtr.Zero)
					CLOSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLOSED", "Lcom/facebook/SessionState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLOSED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CLOSED_jfieldId == IntPtr.Zero)
					CLOSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLOSED", "Lcom/facebook/SessionState;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CLOSED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr CLOSED_LOGIN_FAILED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='SessionState']/field[@name='CLOSED_LOGIN_FAILED']"
		[Register ("CLOSED_LOGIN_FAILED")]
		public static global::Xamarin.FacebookBinding.SessionState ClosedLoginFailed {
			get {
				if (CLOSED_LOGIN_FAILED_jfieldId == IntPtr.Zero)
					CLOSED_LOGIN_FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLOSED_LOGIN_FAILED", "Lcom/facebook/SessionState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLOSED_LOGIN_FAILED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CLOSED_LOGIN_FAILED_jfieldId == IntPtr.Zero)
					CLOSED_LOGIN_FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLOSED_LOGIN_FAILED", "Lcom/facebook/SessionState;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CLOSED_LOGIN_FAILED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr CREATED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='SessionState']/field[@name='CREATED']"
		[Register ("CREATED")]
		public static global::Xamarin.FacebookBinding.SessionState Created {
			get {
				if (CREATED_jfieldId == IntPtr.Zero)
					CREATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATED", "Lcom/facebook/SessionState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CREATED_jfieldId == IntPtr.Zero)
					CREATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATED", "Lcom/facebook/SessionState;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CREATED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr CREATED_TOKEN_LOADED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='SessionState']/field[@name='CREATED_TOKEN_LOADED']"
		[Register ("CREATED_TOKEN_LOADED")]
		public static global::Xamarin.FacebookBinding.SessionState CreatedTokenLoaded {
			get {
				if (CREATED_TOKEN_LOADED_jfieldId == IntPtr.Zero)
					CREATED_TOKEN_LOADED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATED_TOKEN_LOADED", "Lcom/facebook/SessionState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATED_TOKEN_LOADED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CREATED_TOKEN_LOADED_jfieldId == IntPtr.Zero)
					CREATED_TOKEN_LOADED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATED_TOKEN_LOADED", "Lcom/facebook/SessionState;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CREATED_TOKEN_LOADED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr OPENED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='SessionState']/field[@name='OPENED']"
		[Register ("OPENED")]
		public static global::Xamarin.FacebookBinding.SessionState Opened {
			get {
				if (OPENED_jfieldId == IntPtr.Zero)
					OPENED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPENED", "Lcom/facebook/SessionState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OPENED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (OPENED_jfieldId == IntPtr.Zero)
					OPENED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPENED", "Lcom/facebook/SessionState;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, OPENED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr OPENED_TOKEN_UPDATED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='SessionState']/field[@name='OPENED_TOKEN_UPDATED']"
		[Register ("OPENED_TOKEN_UPDATED")]
		public static global::Xamarin.FacebookBinding.SessionState OpenedTokenUpdated {
			get {
				if (OPENED_TOKEN_UPDATED_jfieldId == IntPtr.Zero)
					OPENED_TOKEN_UPDATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPENED_TOKEN_UPDATED", "Lcom/facebook/SessionState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OPENED_TOKEN_UPDATED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (OPENED_TOKEN_UPDATED_jfieldId == IntPtr.Zero)
					OPENED_TOKEN_UPDATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPENED_TOKEN_UPDATED", "Lcom/facebook/SessionState;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, OPENED_TOKEN_UPDATED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr OPENING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='SessionState']/field[@name='OPENING']"
		[Register ("OPENING")]
		public static global::Xamarin.FacebookBinding.SessionState Opening {
			get {
				if (OPENING_jfieldId == IntPtr.Zero)
					OPENING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPENING", "Lcom/facebook/SessionState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OPENING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (OPENING_jfieldId == IntPtr.Zero)
					OPENING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPENING", "Lcom/facebook/SessionState;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, OPENING_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook']/class[@name='SessionState.Category']"
		[global::Android.Runtime.Register ("com/facebook/SessionState$Category", DoNotGenerateAcw=true)]
		public sealed partial class Category : global::Java.Lang.Enum {


			static IntPtr CLOSED_CATEGORY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='SessionState.Category']/field[@name='CLOSED_CATEGORY']"
			[Register ("CLOSED_CATEGORY")]
			public static global::Xamarin.FacebookBinding.SessionState.Category ClosedCategory {
				get {
					if (CLOSED_CATEGORY_jfieldId == IntPtr.Zero)
						CLOSED_CATEGORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLOSED_CATEGORY", "Lcom/facebook/SessionState$Category;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLOSED_CATEGORY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionState.Category> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CLOSED_CATEGORY_jfieldId == IntPtr.Zero)
						CLOSED_CATEGORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLOSED_CATEGORY", "Lcom/facebook/SessionState$Category;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CLOSED_CATEGORY_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr CREATED_CATEGORY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='SessionState.Category']/field[@name='CREATED_CATEGORY']"
			[Register ("CREATED_CATEGORY")]
			public static global::Xamarin.FacebookBinding.SessionState.Category CreatedCategory {
				get {
					if (CREATED_CATEGORY_jfieldId == IntPtr.Zero)
						CREATED_CATEGORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATED_CATEGORY", "Lcom/facebook/SessionState$Category;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATED_CATEGORY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionState.Category> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CREATED_CATEGORY_jfieldId == IntPtr.Zero)
						CREATED_CATEGORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATED_CATEGORY", "Lcom/facebook/SessionState$Category;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CREATED_CATEGORY_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr OPENED_CATEGORY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook']/class[@name='SessionState.Category']/field[@name='OPENED_CATEGORY']"
			[Register ("OPENED_CATEGORY")]
			public static global::Xamarin.FacebookBinding.SessionState.Category OpenedCategory {
				get {
					if (OPENED_CATEGORY_jfieldId == IntPtr.Zero)
						OPENED_CATEGORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPENED_CATEGORY", "Lcom/facebook/SessionState$Category;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OPENED_CATEGORY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionState.Category> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (OPENED_CATEGORY_jfieldId == IntPtr.Zero)
						OPENED_CATEGORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPENED_CATEGORY", "Lcom/facebook/SessionState$Category;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, OPENED_CATEGORY_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/SessionState$Category", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Category); }
			}

			internal Category (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/SessionState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SessionState); }
		}

		internal SessionState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isClosed;
		public bool IsClosed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='SessionState']/method[@name='isClosed' and count(parameter)=0]"
			[Register ("isClosed", "()Z", "GetIsClosedHandler")]
			get {
				if (id_isClosed == IntPtr.Zero)
					id_isClosed = JNIEnv.GetMethodID (class_ref, "isClosed", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isClosed);
			}
		}

		static IntPtr id_isOpened;
		public bool IsOpened {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='SessionState']/method[@name='isOpened' and count(parameter)=0]"
			[Register ("isOpened", "()Z", "GetIsOpenedHandler")]
			get {
				if (id_isOpened == IntPtr.Zero)
					id_isOpened = JNIEnv.GetMethodID (class_ref, "isOpened", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isOpened);
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='SessionState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/facebook/SessionState;", "")]
		public static global::Xamarin.FacebookBinding.SessionState ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/facebook/SessionState;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Xamarin.FacebookBinding.SessionState __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.SessionState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook']/class[@name='SessionState']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/facebook/SessionState;", "")]
		public static global::Xamarin.FacebookBinding.SessionState[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/facebook/SessionState;");
			return (global::Xamarin.FacebookBinding.SessionState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Xamarin.FacebookBinding.SessionState));
		}

	}
}
