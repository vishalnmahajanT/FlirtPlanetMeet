using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.internal']/class[@name='Validate']"
	[global::Android.Runtime.Register ("com/facebook/internal/Validate", DoNotGenerateAcw=true)]
	public sealed partial class Validate : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/internal/Validate", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Validate); }
		}

		internal Validate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.internal']/class[@name='Validate']/constructor[@name='Validate' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Validate () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Validate)) {
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

		static IntPtr id_containsNoNulls_Ljava_util_Collection_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Validate']/method[@name='containsNoNulls' and count(parameter)=2 and parameter[1][@type='java.util.Collection'] and parameter[2][@type='java.lang.String']]"
		[Register ("containsNoNulls", "(Ljava/util/Collection;Ljava/lang/String;)V", "")]
		public static void ContainsNoNulls (global::System.Collections.ICollection p0, string p1)
		{
			if (id_containsNoNulls_Ljava_util_Collection_Ljava_lang_String_ == IntPtr.Zero)
				id_containsNoNulls_Ljava_util_Collection_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "containsNoNulls", "(Ljava/util/Collection;Ljava/lang/String;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_containsNoNulls_Ljava_util_Collection_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_notEmpty_Ljava_util_Collection_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Validate']/method[@name='notEmpty' and count(parameter)=2 and parameter[1][@type='java.util.Collection'] and parameter[2][@type='java.lang.String']]"
		[Register ("notEmpty", "(Ljava/util/Collection;Ljava/lang/String;)V", "")]
		public static void NotEmpty (global::System.Collections.ICollection p0, string p1)
		{
			if (id_notEmpty_Ljava_util_Collection_Ljava_lang_String_ == IntPtr.Zero)
				id_notEmpty_Ljava_util_Collection_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "notEmpty", "(Ljava/util/Collection;Ljava/lang/String;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_notEmpty_Ljava_util_Collection_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_notEmptyAndContainsNoNulls_Ljava_util_Collection_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Validate']/method[@name='notEmptyAndContainsNoNulls' and count(parameter)=2 and parameter[1][@type='java.util.Collection'] and parameter[2][@type='java.lang.String']]"
		[Register ("notEmptyAndContainsNoNulls", "(Ljava/util/Collection;Ljava/lang/String;)V", "")]
		public static void NotEmptyAndContainsNoNulls (global::System.Collections.ICollection p0, string p1)
		{
			if (id_notEmptyAndContainsNoNulls_Ljava_util_Collection_Ljava_lang_String_ == IntPtr.Zero)
				id_notEmptyAndContainsNoNulls_Ljava_util_Collection_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "notEmptyAndContainsNoNulls", "(Ljava/util/Collection;Ljava/lang/String;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_notEmptyAndContainsNoNulls_Ljava_util_Collection_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_notNull_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Validate']/method[@name='notNull' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("notNull", "(Ljava/lang/Object;Ljava/lang/String;)V", "")]
		public static void NotNull (global::Java.Lang.Object p0, string p1)
		{
			if (id_notNull_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_notNull_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "notNull", "(Ljava/lang/Object;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_notNull_Ljava_lang_Object_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_notNullOrEmpty_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Validate']/method[@name='notNullOrEmpty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("notNullOrEmpty", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void NotNullOrEmpty (string p0, string p1)
		{
			if (id_notNullOrEmpty_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_notNullOrEmpty_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "notNullOrEmpty", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_notNullOrEmpty_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_oneOf_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.internal']/class[@name='Validate']/method[@name='oneOf' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("oneOf", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static void OneOf (global::Java.Lang.Object p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_oneOf_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_oneOf_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "oneOf", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_oneOf_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
