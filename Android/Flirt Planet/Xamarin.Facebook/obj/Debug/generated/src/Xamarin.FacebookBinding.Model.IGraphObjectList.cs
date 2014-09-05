using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding.Model {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphObjectList']"
	[Register ("com/facebook/model/GraphObjectList", "", "Xamarin.FacebookBinding.Model.IGraphObjectListInvoker")]
	public partial interface IGraphObjectList : global::Java.Util.ICollection {

		global::Org.Json.JSONArray InnerJSONArray {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphObjectList']/method[@name='getInnerJSONArray' and count(parameter)=0]"
			[Register ("getInnerJSONArray", "()Lorg/json/JSONArray;", "GetGetInnerJSONArrayHandler:Xamarin.FacebookBinding.Model.IGraphObjectListInvoker, Xamarin.Facebook")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.model']/interface[@name='GraphObjectList']/method[@name='castToListOf' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("castToListOf", "(Ljava/lang/Class;)Lcom/facebook/model/GraphObjectList;", "GetCastToListOf_Ljava_lang_Class_Handler:Xamarin.FacebookBinding.Model.IGraphObjectListInvoker, Xamarin.Facebook")]
		global::Xamarin.FacebookBinding.Model.IGraphObjectList CastToListOf (global::Java.Lang.Class p0);

	}

	[global::Android.Runtime.Register ("com/facebook/model/GraphObjectList", DoNotGenerateAcw=true)]
	internal class IGraphObjectListInvoker : global::Java.Lang.Object, IGraphObjectList {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/model/GraphObjectList");
		IntPtr class_ref;

		public static IGraphObjectList GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGraphObjectList> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.model.GraphObjectList"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGraphObjectListInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IGraphObjectListInvoker); }
		}

		static Delegate cb_getInnerJSONArray;
#pragma warning disable 0169
		static Delegate GetGetInnerJSONArrayHandler ()
		{
			if (cb_getInnerJSONArray == null)
				cb_getInnerJSONArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInnerJSONArray);
			return cb_getInnerJSONArray;
		}

		static IntPtr n_GetInnerJSONArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IGraphObjectList __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObjectList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InnerJSONArray);
		}
#pragma warning restore 0169

		IntPtr id_getInnerJSONArray;
		public global::Org.Json.JSONArray InnerJSONArray {
			get {
				if (id_getInnerJSONArray == IntPtr.Zero)
					id_getInnerJSONArray = JNIEnv.GetMethodID (class_ref, "getInnerJSONArray", "()Lorg/json/JSONArray;");
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (JNIEnv.CallObjectMethod (Handle, id_getInnerJSONArray), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_castToListOf_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetCastToListOf_Ljava_lang_Class_Handler ()
		{
			if (cb_castToListOf_Ljava_lang_Class_ == null)
				cb_castToListOf_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CastToListOf_Ljava_lang_Class_);
			return cb_castToListOf_Ljava_lang_Class_;
		}

		static IntPtr n_CastToListOf_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Model.IGraphObjectList __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObjectList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CastToListOf (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_castToListOf_Ljava_lang_Class_;
		public global::Xamarin.FacebookBinding.Model.IGraphObjectList CastToListOf (global::Java.Lang.Class p0)
		{
			if (id_castToListOf_Ljava_lang_Class_ == IntPtr.Zero)
				id_castToListOf_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "castToListOf", "(Ljava/lang/Class;)Lcom/facebook/model/GraphObjectList;");
			global::Xamarin.FacebookBinding.Model.IGraphObjectList __ret = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObjectList> (JNIEnv.CallObjectMethod (Handle, id_castToListOf_Ljava_lang_Class_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetGetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetIsEmpty);
			return cb_isEmpty;
		}

		static bool n_GetIsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IGraphObjectList __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObjectList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		IntPtr id_isEmpty;
		public global::System.Boolean IsEmpty {
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isEmpty);
			}
		}

		static Delegate cb_add_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_Object_Handler ()
		{
			if (cb_add_Ljava_lang_Object_ == null)
				cb_add_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Add_Ljava_lang_Object_);
			return cb_add_Ljava_lang_Object_;
		}

		static bool n_Add_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native__object)
		{
			global::Xamarin.FacebookBinding.Model.IGraphObjectList __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObjectList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object @object = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native__object, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Add (@object);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_add_Ljava_lang_Object_;
		public global::System.Boolean Add (global::Java.Lang.Object @object)
		{
			if (id_add_Ljava_lang_Object_ == IntPtr.Zero)
				id_add_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/Object;)Z");
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod (Handle, id_add_Ljava_lang_Object_, new JValue (@object));
			return __ret;
		}

		static Delegate cb_addAll_LSystem_Collections_ICollection_;
#pragma warning disable 0169
		static Delegate GetAddAll_LSystem_Collections_ICollection_Handler ()
		{
			if (cb_addAll_LSystem_Collections_ICollection_ == null)
				cb_addAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddAll_LSystem_Collections_ICollection_);
			return cb_addAll_LSystem_Collections_ICollection_;
		}

		static bool n_AddAll_LSystem_Collections_ICollection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_collection)
		{
			global::Xamarin.FacebookBinding.Model.IGraphObjectList __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObjectList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection collection = global::Android.Runtime.JavaCollection.FromJniHandle (native_collection, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddAll (collection);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addAll_LSystem_Collections_ICollection_;
		public global::System.Boolean AddAll (global::System.Collections.ICollection collection)
		{
			if (id_addAll_LSystem_Collections_ICollection_ == IntPtr.Zero)
				id_addAll_LSystem_Collections_ICollection_ = JNIEnv.GetMethodID (class_ref, "addAll", "(LSystem/Collections/ICollection;)Z");
			IntPtr native_collection = global::Android.Runtime.JavaCollection.ToLocalJniHandle (collection);
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod (Handle, id_addAll_LSystem_Collections_ICollection_, new JValue (native_collection));
			JNIEnv.DeleteLocalRef (native_collection);
			return __ret;
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IGraphObjectList __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObjectList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (Handle, id_clear);
		}

		static Delegate cb_contains_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetContains_Ljava_lang_Object_Handler ()
		{
			if (cb_contains_Ljava_lang_Object_ == null)
				cb_contains_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Contains_Ljava_lang_Object_);
			return cb_contains_Ljava_lang_Object_;
		}

		static bool n_Contains_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native__object)
		{
			global::Xamarin.FacebookBinding.Model.IGraphObjectList __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObjectList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object @object = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native__object, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (@object);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_contains_Ljava_lang_Object_;
		public global::System.Boolean Contains (global::Java.Lang.Object @object)
		{
			if (id_contains_Ljava_lang_Object_ == IntPtr.Zero)
				id_contains_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "contains", "(Ljava/lang/Object;)Z");
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod (Handle, id_contains_Ljava_lang_Object_, new JValue (@object));
			return __ret;
		}

		static Delegate cb_containsAll_LSystem_Collections_ICollection_;
#pragma warning disable 0169
		static Delegate GetContainsAll_LSystem_Collections_ICollection_Handler ()
		{
			if (cb_containsAll_LSystem_Collections_ICollection_ == null)
				cb_containsAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ContainsAll_LSystem_Collections_ICollection_);
			return cb_containsAll_LSystem_Collections_ICollection_;
		}

		static bool n_ContainsAll_LSystem_Collections_ICollection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_collection)
		{
			global::Xamarin.FacebookBinding.Model.IGraphObjectList __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObjectList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection collection = global::Android.Runtime.JavaCollection.FromJniHandle (native_collection, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsAll (collection);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_containsAll_LSystem_Collections_ICollection_;
		public global::System.Boolean ContainsAll (global::System.Collections.ICollection collection)
		{
			if (id_containsAll_LSystem_Collections_ICollection_ == IntPtr.Zero)
				id_containsAll_LSystem_Collections_ICollection_ = JNIEnv.GetMethodID (class_ref, "containsAll", "(LSystem/Collections/ICollection;)Z");
			IntPtr native_collection = global::Android.Runtime.JavaCollection.ToLocalJniHandle (collection);
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod (Handle, id_containsAll_LSystem_Collections_ICollection_, new JValue (native_collection));
			JNIEnv.DeleteLocalRef (native_collection);
			return __ret;
		}

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native__object)
		{
			global::Xamarin.FacebookBinding.Model.IGraphObjectList __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObjectList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object @object = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native__object, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (@object);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equals_Ljava_lang_Object_;
		public global::System.Boolean Equals (global::Java.Lang.Object @object)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod (Handle, id_equals_Ljava_lang_Object_, new JValue (@object));
			return __ret;
		}

		static Delegate cb_hashCode;
#pragma warning disable 0169
		static Delegate GetGetHashCodeHandler ()
		{
			if (cb_hashCode == null)
				cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
			return cb_hashCode;
		}

		static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IGraphObjectList __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObjectList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		IntPtr id_hashCode;
		public global::System.Int32 GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod (Handle, id_hashCode);
		}

		static Delegate cb_iterator;
#pragma warning disable 0169
		static Delegate GetIteratorHandler ()
		{
			if (cb_iterator == null)
				cb_iterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Iterator);
			return cb_iterator;
		}

		static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IGraphObjectList __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObjectList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		IntPtr id_iterator;
		public global::Java.Util.IIterator Iterator ()
		{
			if (id_iterator == IntPtr.Zero)
				id_iterator = JNIEnv.GetMethodID (class_ref, "iterator", "()Ljava/util/Iterator;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod (Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_remove_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_Object_Handler ()
		{
			if (cb_remove_Ljava_lang_Object_ == null)
				cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Remove_Ljava_lang_Object_);
			return cb_remove_Ljava_lang_Object_;
		}

		static bool n_Remove_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native__object)
		{
			global::Xamarin.FacebookBinding.Model.IGraphObjectList __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObjectList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object @object = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native__object, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Remove (@object);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_remove_Ljava_lang_Object_;
		public global::System.Boolean Remove (global::Java.Lang.Object @object)
		{
			if (id_remove_Ljava_lang_Object_ == IntPtr.Zero)
				id_remove_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/Object;)Z");
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod (Handle, id_remove_Ljava_lang_Object_, new JValue (@object));
			return __ret;
		}

		static Delegate cb_removeAll_LSystem_Collections_ICollection_;
#pragma warning disable 0169
		static Delegate GetRemoveAll_LSystem_Collections_ICollection_Handler ()
		{
			if (cb_removeAll_LSystem_Collections_ICollection_ == null)
				cb_removeAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveAll_LSystem_Collections_ICollection_);
			return cb_removeAll_LSystem_Collections_ICollection_;
		}

		static bool n_RemoveAll_LSystem_Collections_ICollection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_collection)
		{
			global::Xamarin.FacebookBinding.Model.IGraphObjectList __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObjectList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection collection = global::Android.Runtime.JavaCollection.FromJniHandle (native_collection, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveAll (collection);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_removeAll_LSystem_Collections_ICollection_;
		public global::System.Boolean RemoveAll (global::System.Collections.ICollection collection)
		{
			if (id_removeAll_LSystem_Collections_ICollection_ == IntPtr.Zero)
				id_removeAll_LSystem_Collections_ICollection_ = JNIEnv.GetMethodID (class_ref, "removeAll", "(LSystem/Collections/ICollection;)Z");
			IntPtr native_collection = global::Android.Runtime.JavaCollection.ToLocalJniHandle (collection);
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod (Handle, id_removeAll_LSystem_Collections_ICollection_, new JValue (native_collection));
			JNIEnv.DeleteLocalRef (native_collection);
			return __ret;
		}

		static Delegate cb_retainAll_LSystem_Collections_ICollection_;
#pragma warning disable 0169
		static Delegate GetRetainAll_LSystem_Collections_ICollection_Handler ()
		{
			if (cb_retainAll_LSystem_Collections_ICollection_ == null)
				cb_retainAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RetainAll_LSystem_Collections_ICollection_);
			return cb_retainAll_LSystem_Collections_ICollection_;
		}

		static bool n_RetainAll_LSystem_Collections_ICollection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_collection)
		{
			global::Xamarin.FacebookBinding.Model.IGraphObjectList __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObjectList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection collection = global::Android.Runtime.JavaCollection.FromJniHandle (native_collection, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RetainAll (collection);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_retainAll_LSystem_Collections_ICollection_;
		public global::System.Boolean RetainAll (global::System.Collections.ICollection collection)
		{
			if (id_retainAll_LSystem_Collections_ICollection_ == IntPtr.Zero)
				id_retainAll_LSystem_Collections_ICollection_ = JNIEnv.GetMethodID (class_ref, "retainAll", "(LSystem/Collections/ICollection;)Z");
			IntPtr native_collection = global::Android.Runtime.JavaCollection.ToLocalJniHandle (collection);
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod (Handle, id_retainAll_LSystem_Collections_ICollection_, new JValue (native_collection));
			JNIEnv.DeleteLocalRef (native_collection);
			return __ret;
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IGraphObjectList __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObjectList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		IntPtr id_size;
		public global::System.Int32 Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			return JNIEnv.CallIntMethod (Handle, id_size);
		}

		static Delegate cb_toArray;
#pragma warning disable 0169
		static Delegate GetToArrayHandler ()
		{
			if (cb_toArray == null)
				cb_toArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToArray);
			return cb_toArray;
		}

		static IntPtr n_ToArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Model.IGraphObjectList __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObjectList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToArray ());
		}
#pragma warning restore 0169

		IntPtr id_toArray;
		public global::Java.Lang.Object[] ToArray ()
		{
			if (id_toArray == IntPtr.Zero)
				id_toArray = JNIEnv.GetMethodID (class_ref, "toArray", "()[Ljava/lang/Object;");
			return (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_toArray), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
		}

		static Delegate cb_toArray_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetToArray_arrayLjava_lang_Object_Handler ()
		{
			if (cb_toArray_arrayLjava_lang_Object_ == null)
				cb_toArray_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToArray_arrayLjava_lang_Object_);
			return cb_toArray_arrayLjava_lang_Object_;
		}

		static IntPtr n_ToArray_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_array)
		{
			global::Xamarin.FacebookBinding.Model.IGraphObjectList __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphObjectList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] array = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.NewArray (__this.ToArray (array));
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_toArray_arrayLjava_lang_Object_;
		public global::Java.Lang.Object[] ToArray (global::Java.Lang.Object[] array)
		{
			if (id_toArray_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_toArray_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			IntPtr native_array = JNIEnv.NewArray (array);
			global::Java.Lang.Object[] __ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_toArray_arrayLjava_lang_Object_, new JValue (native_array)), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			if (array != null) {
				JNIEnv.CopyArray (native_array, array);
				JNIEnv.DeleteLocalRef (native_array);
			}
			return __ret;
		}

	}

}
