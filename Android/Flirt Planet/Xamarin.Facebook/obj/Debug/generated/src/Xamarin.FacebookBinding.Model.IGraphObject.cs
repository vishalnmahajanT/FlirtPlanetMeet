using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.model']/class[@name='GraphObject.Factory']"
	[global::Android.Runtime.Register ("com/facebook/model/GraphObject$Factory", DoNotGenerateAcw=true)]
	public sealed partial class GraphObjectFactory : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.model']/class[@name='GraphObject.Factory.GraphObjectListImpl']"
		[global::Android.Runtime.Register ("com/facebook/model/GraphObject$Factory$GraphObjectListImpl", DoNotGenerateAcw=true)]
		public sealed partial class GraphObjectListImpl : global::Java.Util.AbstractList, global::Xamarin.FacebookBinding.Model.IGraphObjectList {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/model/GraphObject$Factory$GraphObjectListImpl", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GraphObjectListImpl); }
			}

			internal GraphObjectListImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_json_JSONArray_Ljava_lang_Class_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.model']/class[@name='GraphObject.Factory.GraphObjectListImpl']/constructor[@name='GraphObject.Factory.GraphObjectListImpl' and count(parameter)=2 and parameter[1][@type='org.json.JSONArray'] and parameter[2][@type='java.lang.Class']]"
			[Register (".ctor", "(Lorg/json/JSONArray;Ljava/lang/Class;)V", "")]
			public GraphObjectListImpl (global::Org.Json.JSONArray p0, global::Java.Lang.Class p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (GraphObjectListImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/json/JSONArray;Ljava/lang/Class;)V", new JValue (p0), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/json/JSONArray;Ljava/lang/Class;)V", new JValue (p0), new JValue (p1));
					return;
				}

				if (id_ctor_Lorg_json_JSONArray_Ljava_lang_Class_ == IntPtr.Zero)
					id_ctor_Lorg_json_JSONArray_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/json/JSONArray;Ljava/lang/Class;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_json_JSONArray_Ljava_lang_Class_, new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_json_JSONArray_Ljava_lang_Class_, new JValue (p0), new JValue (p1));
			}

			static IntPtr id_getInnerJSONArray;
			public global::Org.Json.JSONArray InnerJSONArray {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/class[@name='GraphObject.Factory.GraphObjectListImpl']/method[@name='getInnerJSONArray' and count(parameter)=0]"
				[Register ("getInnerJSONArray", "()Lorg/json/JSONArray;", "GetGetInnerJSONArrayHandler")]
				get {
					if (id_getInnerJSONArray == IntPtr.Zero)
						id_getInnerJSONArray = JNIEnv.GetMethodID (class_ref, "getInnerJSONArray", "()Lorg/json/JSONArray;");
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (JNIEnv.CallObjectMethod  (Handle, id_getInnerJSONArray), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_castToListOf_Ljava_lang_Class_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/class[@name='GraphObject.Factory.GraphObjectListImpl']/method[@name='castToListOf' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
			[Register ("castToListOf", "(Ljava/lang/Class;)Lcom/facebook/model/GraphObjectList;", "")]
			public global::Xamarin.FacebookBinding.Model.IGraphObjectList CastToListOf (global::Java.Lang.Class p0)
			{
				if (id_castToListOf_Ljava_lang_Class_ == IntPtr.Zero)
					id_castToListOf_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "castToListOf", "(Ljava/lang/Class;)Lcom/facebook/model/GraphObjectList;");
				global::Xamarin.FacebookBinding.Model.IGraphObjectList __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObjectList> (JNIEnv.CallObjectMethod  (Handle, id_castToListOf_Ljava_lang_Class_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_get_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/class[@name='GraphObject.Factory.GraphObjectListImpl']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("get", "(I)Ljava/lang/Object;", "")]
			public override global::Java.Lang.Object Get (int p0)
			{
				if (id_get_I == IntPtr.Zero)
					id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Ljava/lang/Object;");
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_size;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/class[@name='GraphObject.Factory.GraphObjectListImpl']/method[@name='size' and count(parameter)=0]"
			[Register ("size", "()I", "")]
			public override int Size ()
			{
				if (id_size == IntPtr.Zero)
					id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_size);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.model']/class[@name='GraphObject.Factory.GraphObjectProxy']"
		[global::Android.Runtime.Register ("com/facebook/model/GraphObject$Factory$GraphObjectProxy", DoNotGenerateAcw=true)]
		public sealed partial class GraphObjectProxy : global::Xamarin.FacebookBinding.Model.GraphObjectFactory.ProxyBase {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/model/GraphObject$Factory$GraphObjectProxy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GraphObjectProxy); }
			}

			internal GraphObjectProxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_json_JSONObject_Ljava_lang_Class_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.model']/class[@name='GraphObject.Factory.GraphObjectProxy']/constructor[@name='GraphObject.Factory.GraphObjectProxy' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='java.lang.Class']]"
			[Register (".ctor", "(Lorg/json/JSONObject;Ljava/lang/Class;)V", "")]
			public GraphObjectProxy (global::Org.Json.JSONObject p0, global::Java.Lang.Class p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (GraphObjectProxy)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/json/JSONObject;Ljava/lang/Class;)V", new JValue (p0), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/json/JSONObject;Ljava/lang/Class;)V", new JValue (p0), new JValue (p1));
					return;
				}

				if (id_ctor_Lorg_json_JSONObject_Ljava_lang_Class_ == IntPtr.Zero)
					id_ctor_Lorg_json_JSONObject_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/json/JSONObject;Ljava/lang/Class;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_json_JSONObject_Ljava_lang_Class_, new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_json_JSONObject_Ljava_lang_Class_, new JValue (p0), new JValue (p1));
			}

			static IntPtr id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/class[@name='GraphObject.Factory.GraphObjectProxy']/method[@name='invoke' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Method'] and parameter[3][@type='java.lang.Object[]']]"
			[Register ("invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
			public override sealed global::Java.Lang.Object Invoke (global::Java.Lang.Object p0, global::Java.Lang.Reflect.Method p1, global::Java.Lang.Object[] p2)
			{
				if (id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;");
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				return __ret;
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.model']/class[@name='GraphObject.Factory.ProxyBase']"
		[global::Android.Runtime.Register ("com/facebook/model/GraphObject$Factory$ProxyBase", DoNotGenerateAcw=true)]
		public abstract partial class ProxyBase : global::Java.Lang.Object, global::Java.Lang.Reflect.IInvocationHandler {


			static IntPtr state_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.model']/class[@name='GraphObject.Factory.ProxyBase']/field[@name='state']"
			[Register ("state")]
			protected global::Java.Lang.Object State {
				get {
					if (state_jfieldId == IntPtr.Zero)
						state_jfieldId = JNIEnv.GetFieldID (class_ref, "state", "Ljava/lang/Object;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, state_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (state_jfieldId == IntPtr.Zero)
						state_jfieldId = JNIEnv.GetFieldID (class_ref, "state", "Ljava/lang/Object;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, state_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/model/GraphObject$Factory$ProxyBase", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ProxyBase); }
			}

			protected ProxyBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_Object_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.model']/class[@name='GraphObject.Factory.ProxyBase']/constructor[@name='GraphObject.Factory.ProxyBase' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register (".ctor", "(Ljava/lang/Object;)V", "")]
			protected ProxyBase (global::Java.Lang.Object p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);;
				if (GetType () != typeof (ProxyBase)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Object;)V", new JValue (native_p0)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Object;)V", new JValue (native_p0));
					JNIEnv.DeleteLocalRef (native_p0);
					return;
				}

				if (id_ctor_Ljava_lang_Object_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_, new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Object_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static IntPtr id_proxyObjectMethods_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/class[@name='GraphObject.Factory.ProxyBase']/method[@name='proxyObjectMethods' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Method'] and parameter[3][@type='java.lang.Object[]']]"
			[Register ("proxyObjectMethods", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
			protected global::Java.Lang.Object ProxyObjectMethods (global::Java.Lang.Object p0, global::Java.Lang.Reflect.Method p1, global::Java.Lang.Object[] p2)
			{
				if (id_proxyObjectMethods_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_proxyObjectMethods_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "proxyObjectMethods", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;");
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_proxyObjectMethods_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				return __ret;
			}

			static IntPtr id_throwUnexpectedMethodSignature_Ljava_lang_reflect_Method_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/class[@name='GraphObject.Factory.ProxyBase']/method[@name='throwUnexpectedMethodSignature' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Method']]"
			[Register ("throwUnexpectedMethodSignature", "(Ljava/lang/reflect/Method;)Ljava/lang/Object;", "")]
			protected global::Java.Lang.Object ThrowUnexpectedMethodSignature (global::Java.Lang.Reflect.Method p0)
			{
				if (id_throwUnexpectedMethodSignature_Ljava_lang_reflect_Method_ == IntPtr.Zero)
					id_throwUnexpectedMethodSignature_Ljava_lang_reflect_Method_ = JNIEnv.GetMethodID (class_ref, "throwUnexpectedMethodSignature", "(Ljava/lang/reflect/Method;)Ljava/lang/Object;");
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_throwUnexpectedMethodSignature_Ljava_lang_reflect_Method_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetInvoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_Handler ()
			{
				if (cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ == null)
					cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_);
				return cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
			}

			static IntPtr n_Invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_proxy, IntPtr native_method, IntPtr native_args)
			{
				global::Xamarin.FacebookBinding.Model.GraphObjectFactory.ProxyBase __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.GraphObjectFactory.ProxyBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object proxy = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_proxy, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Reflect.Method method = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (native_method, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object[] args = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_args, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Invoke (proxy, method, args));
				if (args != null)
					JNIEnv.CopyArray (args, native_args);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/class[@name='GraphObject.Factory.ProxyBase']/method[@name='invoke' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Method'] and parameter[3][@type='java.lang.Object[]']]"
			[Register ("invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;", "GetInvoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_Handler")]
			public abstract global::Java.Lang.Object Invoke (global::Java.Lang.Object proxy, global::Java.Lang.Reflect.Method method, global::Java.Lang.Object[] args);

		}

		[global::Android.Runtime.Register ("com/facebook/model/GraphObject$Factory$ProxyBase", DoNotGenerateAcw=true)]
		internal partial class ProxyBaseInvoker : ProxyBase {

			public ProxyBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (ProxyBaseInvoker); }
			}

			static IntPtr id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/class[@name='GraphObject.Factory.ProxyBase']/method[@name='invoke' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Method'] and parameter[3][@type='java.lang.Object[]']]"
			[Register ("invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;", "GetInvoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_Handler")]
			public override global::Java.Lang.Object Invoke (global::Java.Lang.Object proxy, global::Java.Lang.Reflect.Method method, global::Java.Lang.Object[] args)
			{
				if (id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;");
				IntPtr native_args = JNIEnv.NewArray (args);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_, new JValue (proxy), new JValue (method), new JValue (native_args)), JniHandleOwnership.TransferLocalRef);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				return __ret;
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/model/GraphObject$Factory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GraphObjectFactory); }
		}

		internal GraphObjectFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/class[@name='GraphObject.Factory']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lcom/facebook/model/GraphObject;", "")]
		public static global::Xamarin.FacebookBinding.Model.IGraphObject Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()Lcom/facebook/model/GraphObject;");
			return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_create_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/class[@name='GraphObject.Factory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("create", "(Ljava/lang/Class;)Lcom/facebook/model/GraphObject;", "")]
		public static global::Java.Lang.Object Create (global::Java.Lang.Class p0)
		{
			if (id_create_Ljava_lang_Class_ == IntPtr.Zero)
				id_create_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/Class;)Lcom/facebook/model/GraphObject;");
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_Class_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_create_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/class[@name='GraphObject.Factory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("create", "(Lorg/json/JSONObject;)Lcom/facebook/model/GraphObject;", "")]
		public static global::Xamarin.FacebookBinding.Model.IGraphObject Create (global::Org.Json.JSONObject p0)
		{
			if (id_create_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_create_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lorg/json/JSONObject;)Lcom/facebook/model/GraphObject;");
			global::Xamarin.FacebookBinding.Model.IGraphObject __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lorg_json_JSONObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_create_Lorg_json_JSONObject_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/class[@name='GraphObject.Factory']/method[@name='create' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='java.lang.Class']]"
		[Register ("create", "(Lorg/json/JSONObject;Ljava/lang/Class;)Lcom/facebook/model/GraphObject;", "")]
		public static global::Java.Lang.Object Create (global::Org.Json.JSONObject p0, global::Java.Lang.Class p1)
		{
			if (id_create_Lorg_json_JSONObject_Ljava_lang_Class_ == IntPtr.Zero)
				id_create_Lorg_json_JSONObject_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lorg/json/JSONObject;Ljava/lang/Class;)Lcom/facebook/model/GraphObject;");
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lorg_json_JSONObject_Ljava_lang_Class_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_createList_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/class[@name='GraphObject.Factory']/method[@name='createList' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("createList", "(Ljava/lang/Class;)Lcom/facebook/model/GraphObjectList;", "")]
		public static global::Xamarin.FacebookBinding.Model.IGraphObjectList CreateList (global::Java.Lang.Class p0)
		{
			if (id_createList_Ljava_lang_Class_ == IntPtr.Zero)
				id_createList_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "createList", "(Ljava/lang/Class;)Lcom/facebook/model/GraphObjectList;");
			global::Xamarin.FacebookBinding.Model.IGraphObjectList __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObjectList> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createList_Ljava_lang_Class_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_createList_Lorg_json_JSONArray_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/class[@name='GraphObject.Factory']/method[@name='createList' and count(parameter)=2 and parameter[1][@type='org.json.JSONArray'] and parameter[2][@type='java.lang.Class']]"
		[Register ("createList", "(Lorg/json/JSONArray;Ljava/lang/Class;)Lcom/facebook/model/GraphObjectList;", "")]
		public static global::Xamarin.FacebookBinding.Model.IGraphObjectList CreateList (global::Org.Json.JSONArray p0, global::Java.Lang.Class p1)
		{
			if (id_createList_Lorg_json_JSONArray_Ljava_lang_Class_ == IntPtr.Zero)
				id_createList_Lorg_json_JSONArray_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "createList", "(Lorg/json/JSONArray;Ljava/lang/Class;)Lcom/facebook/model/GraphObjectList;");
			global::Xamarin.FacebookBinding.Model.IGraphObjectList __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObjectList> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createList_Lorg_json_JSONArray_Ljava_lang_Class_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_hasSameId_Lcom_facebook_model_GraphObject_Lcom_facebook_model_GraphObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/class[@name='GraphObject.Factory']/method[@name='hasSameId' and count(parameter)=2 and parameter[1][@type='com.facebook.model.GraphObject'] and parameter[2][@type='com.facebook.model.GraphObject']]"
		[Register ("hasSameId", "(Lcom/facebook/model/GraphObject;Lcom/facebook/model/GraphObject;)Z", "")]
		public static bool HasSameId (global::Xamarin.FacebookBinding.Model.IGraphObject p0, global::Xamarin.FacebookBinding.Model.IGraphObject p1)
		{
			if (id_hasSameId_Lcom_facebook_model_GraphObject_Lcom_facebook_model_GraphObject_ == IntPtr.Zero)
				id_hasSameId_Lcom_facebook_model_GraphObject_Lcom_facebook_model_GraphObject_ = JNIEnv.GetStaticMethodID (class_ref, "hasSameId", "(Lcom/facebook/model/GraphObject;Lcom/facebook/model/GraphObject;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasSameId_Lcom_facebook_model_GraphObject_Lcom_facebook_model_GraphObject_, new JValue (p0), new JValue (p1));
			return __ret;
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphObject']"
	[Register ("com/facebook/model/GraphObject", "", "Xamarin.FacebookBinding.Model.IGraphObjectInvoker")]
	public partial interface IGraphObject : IJavaObject {

		global::Org.Json.JSONObject InnerJSONObject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphObject']/method[@name='getInnerJSONObject' and count(parameter)=0]"
			[Register ("getInnerJSONObject", "()Lorg/json/JSONObject;", "GetGetInnerJSONObjectHandler:Xamarin.FacebookBinding.Model.IGraphObjectInvoker, Xamarin.Facebook")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphObject']/method[@name='asMap' and count(parameter)=0]"
		[Register ("asMap", "()Ljava/util/Map;", "GetAsMapHandler:Xamarin.FacebookBinding.Model.IGraphObjectInvoker, Xamarin.Facebook")]
		global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> AsMap ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphObject']/method[@name='cast' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("cast", "(Ljava/lang/Class;)Lcom/facebook/model/GraphObject;", "GetCast_Ljava_lang_Class_Handler:Xamarin.FacebookBinding.Model.IGraphObjectInvoker, Xamarin.Facebook")]
		global::Java.Lang.Object Cast (global::Java.Lang.Class p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphObject']/method[@name='getProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetProperty_Ljava_lang_String_Handler:Xamarin.FacebookBinding.Model.IGraphObjectInvoker, Xamarin.Facebook")]
		global::Java.Lang.Object GetProperty (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphObject']/method[@name='removeProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeProperty", "(Ljava/lang/String;)V", "GetRemoveProperty_Ljava_lang_String_Handler:Xamarin.FacebookBinding.Model.IGraphObjectInvoker, Xamarin.Facebook")]
		void RemoveProperty (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphObject']/method[@name='setProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSetProperty_Ljava_lang_String_Ljava_lang_Object_Handler:Xamarin.FacebookBinding.Model.IGraphObjectInvoker, Xamarin.Facebook")]
		void SetProperty (string p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/facebook/model/GraphObject", DoNotGenerateAcw=true)]
	internal class IGraphObjectInvoker : global::Java.Lang.Object, IGraphObject {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/model/GraphObject");
		IntPtr class_ref;

		public static IGraphObject GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGraphObject> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.model.GraphObject"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGraphObjectInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IGraphObjectInvoker); }
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
			global::Xamarin.FacebookBinding.Model.IGraphObject __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Xamarin.FacebookBinding.Model.IGraphObject __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Xamarin.FacebookBinding.Model.IGraphObject __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Xamarin.FacebookBinding.Model.IGraphObject __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Xamarin.FacebookBinding.Model.IGraphObject __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Xamarin.FacebookBinding.Model.IGraphObject __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
