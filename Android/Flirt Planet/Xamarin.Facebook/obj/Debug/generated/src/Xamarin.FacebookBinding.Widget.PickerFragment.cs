using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']"
	[global::Android.Runtime.Register ("com/facebook/widget/PickerFragment", DoNotGenerateAcw=true)]
	public abstract partial class PickerFragment : global::Android.Support.V4.App.Fragment {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/field[@name='DONE_BUTTON_TEXT_BUNDLE_KEY']"
		[Register ("DONE_BUTTON_TEXT_BUNDLE_KEY")]
		public const string DoneButtonTextBundleKey = (string) "com.facebook.widget.PickerFragment.DoneButtonText";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/field[@name='EXTRA_FIELDS_BUNDLE_KEY']"
		[Register ("EXTRA_FIELDS_BUNDLE_KEY")]
		public const string ExtraFieldsBundleKey = (string) "com.facebook.widget.PickerFragment.ExtraFields";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/field[@name='SHOW_PICTURES_BUNDLE_KEY']"
		[Register ("SHOW_PICTURES_BUNDLE_KEY")]
		public const string ShowPicturesBundleKey = (string) "com.facebook.widget.PickerFragment.ShowPictures";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/field[@name='SHOW_TITLE_BAR_BUNDLE_KEY']"
		[Register ("SHOW_TITLE_BAR_BUNDLE_KEY")]
		public const string ShowTitleBarBundleKey = (string) "com.facebook.widget.PickerFragment.ShowTitleBar";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/field[@name='TITLE_TEXT_BUNDLE_KEY']"
		[Register ("TITLE_TEXT_BUNDLE_KEY")]
		public const string TitleTextBundleKey = (string) "com.facebook.widget.PickerFragment.TitleText";
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.widget']/interface[@name='PickerFragment.GraphObjectFilter']"
		[Register ("com/facebook/widget/PickerFragment$GraphObjectFilter", "", "Xamarin.FacebookBinding.Widget.PickerFragment/IGraphObjectFilterInvoker")]
		public partial interface IGraphObjectFilter : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/interface[@name='PickerFragment.GraphObjectFilter']/method[@name='includeItem' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("includeItem", "(Ljava/lang/Object;)Z", "GetIncludeItem_Ljava_lang_Object_Handler:Xamarin.FacebookBinding.Widget.PickerFragment/IGraphObjectFilterInvoker, Xamarin.Facebook")]
			bool IncludeItem (global::Java.Lang.Object p0);

		}

		[global::Android.Runtime.Register ("com/facebook/widget/PickerFragment$GraphObjectFilter", DoNotGenerateAcw=true)]
		internal class IGraphObjectFilterInvoker : global::Java.Lang.Object, IGraphObjectFilter {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/widget/PickerFragment$GraphObjectFilter");
			IntPtr class_ref;

			public static IGraphObjectFilter GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IGraphObjectFilter> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.widget.PickerFragment.GraphObjectFilter"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IGraphObjectFilterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IGraphObjectFilterInvoker); }
			}

			static Delegate cb_includeItem_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetIncludeItem_Ljava_lang_Object_Handler ()
			{
				if (cb_includeItem_Ljava_lang_Object_ == null)
					cb_includeItem_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IncludeItem_Ljava_lang_Object_);
				return cb_includeItem_Ljava_lang_Object_;
			}

			static bool n_IncludeItem_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Widget.PickerFragment.IGraphObjectFilter __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.IGraphObjectFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.IncludeItem (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_includeItem_Ljava_lang_Object_;
			public bool IncludeItem (global::Java.Lang.Object p0)
			{
				if (id_includeItem_Ljava_lang_Object_ == IntPtr.Zero)
					id_includeItem_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "includeItem", "(Ljava/lang/Object;)Z");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_includeItem_Ljava_lang_Object_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment.LoadingStrategy']"
		[global::Android.Runtime.Register ("com/facebook/widget/PickerFragment$LoadingStrategy", DoNotGenerateAcw=true)]
		public abstract partial class LoadingStrategy : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment.LoadingStrategy']/field[@name='CACHED_RESULT_REFRESH_DELAY']"
			[Register ("CACHED_RESULT_REFRESH_DELAY")]
			protected const int CachedResultRefreshDelay = (int) 2000;

			static IntPtr adapter_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment.LoadingStrategy']/field[@name='adapter']"
			[Register ("adapter")]
			protected global::Android.Widget.BaseAdapter Adapter {
				get {
					if (adapter_jfieldId == IntPtr.Zero)
						adapter_jfieldId = JNIEnv.GetFieldID (class_ref, "adapter", "Landroid/widget/BaseAdapter;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, adapter_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.BaseAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (adapter_jfieldId == IntPtr.Zero)
						adapter_jfieldId = JNIEnv.GetFieldID (class_ref, "adapter", "Landroid/widget/BaseAdapter;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, adapter_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr loader_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment.LoadingStrategy']/field[@name='loader']"
			[Register ("loader")]
			protected global::Android.Support.V4.Content.Loader Loader {
				get {
					if (loader_jfieldId == IntPtr.Zero)
						loader_jfieldId = JNIEnv.GetFieldID (class_ref, "loader", "Landroid/support/v4/content/Loader;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, loader_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Support.V4.Content.Loader> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (loader_jfieldId == IntPtr.Zero)
						loader_jfieldId = JNIEnv.GetFieldID (class_ref, "loader", "Landroid/support/v4/content/Loader;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, loader_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/widget/PickerFragment$LoadingStrategy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LoadingStrategy); }
			}

			protected LoadingStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_isDataPresentOrLoading;
#pragma warning disable 0169
			static Delegate GetIsDataPresentOrLoadingHandler ()
			{
				if (cb_isDataPresentOrLoading == null)
					cb_isDataPresentOrLoading = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDataPresentOrLoading);
				return cb_isDataPresentOrLoading;
			}

			static bool n_IsDataPresentOrLoading (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.Widget.PickerFragment.LoadingStrategy __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.LoadingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsDataPresentOrLoading;
			}
#pragma warning restore 0169

			static IntPtr id_isDataPresentOrLoading;
			public virtual bool IsDataPresentOrLoading {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment.LoadingStrategy']/method[@name='isDataPresentOrLoading' and count(parameter)=0]"
				[Register ("isDataPresentOrLoading", "()Z", "GetIsDataPresentOrLoadingHandler")]
				get {
					if (id_isDataPresentOrLoading == IntPtr.Zero)
						id_isDataPresentOrLoading = JNIEnv.GetMethodID (class_ref, "isDataPresentOrLoading", "()Z");

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isDataPresentOrLoading);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDataPresentOrLoading", "()Z"));
				}
			}

			static Delegate cb_clearResults;
#pragma warning disable 0169
			static Delegate GetClearResultsHandler ()
			{
				if (cb_clearResults == null)
					cb_clearResults = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearResults);
				return cb_clearResults;
			}

			static void n_ClearResults (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.Widget.PickerFragment.LoadingStrategy __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.LoadingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ClearResults ();
			}
#pragma warning restore 0169

			static IntPtr id_clearResults;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment.LoadingStrategy']/method[@name='clearResults' and count(parameter)=0]"
			[Register ("clearResults", "()V", "GetClearResultsHandler")]
			public virtual void ClearResults ()
			{
				if (id_clearResults == IntPtr.Zero)
					id_clearResults = JNIEnv.GetMethodID (class_ref, "clearResults", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearResults);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearResults", "()V"));
			}

			static Delegate cb_detach;
#pragma warning disable 0169
			static Delegate GetDetachHandler ()
			{
				if (cb_detach == null)
					cb_detach = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Detach);
				return cb_detach;
			}

			static void n_Detach (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.Widget.PickerFragment.LoadingStrategy __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.LoadingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Detach ();
			}
#pragma warning restore 0169

			static IntPtr id_detach;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment.LoadingStrategy']/method[@name='detach' and count(parameter)=0]"
			[Register ("detach", "()V", "GetDetachHandler")]
			public virtual void Detach ()
			{
				if (id_detach == IntPtr.Zero)
					id_detach = JNIEnv.GetMethodID (class_ref, "detach", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_detach);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "detach", "()V"));
			}

			static Delegate cb_startLoading_Lcom_facebook_Request_;
#pragma warning disable 0169
			static Delegate GetStartLoading_Lcom_facebook_Request_Handler ()
			{
				if (cb_startLoading_Lcom_facebook_Request_ == null)
					cb_startLoading_Lcom_facebook_Request_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartLoading_Lcom_facebook_Request_);
				return cb_startLoading_Lcom_facebook_Request_;
			}

			static void n_StartLoading_Lcom_facebook_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Widget.PickerFragment.LoadingStrategy __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.LoadingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.Request p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.StartLoading (p0);
			}
#pragma warning restore 0169

			static IntPtr id_startLoading_Lcom_facebook_Request_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment.LoadingStrategy']/method[@name='startLoading' and count(parameter)=1 and parameter[1][@type='com.facebook.Request']]"
			[Register ("startLoading", "(Lcom/facebook/Request;)V", "GetStartLoading_Lcom_facebook_Request_Handler")]
			public virtual void StartLoading (global::Xamarin.FacebookBinding.Request p0)
			{
				if (id_startLoading_Lcom_facebook_Request_ == IntPtr.Zero)
					id_startLoading_Lcom_facebook_Request_ = JNIEnv.GetMethodID (class_ref, "startLoading", "(Lcom/facebook/Request;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startLoading_Lcom_facebook_Request_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startLoading", "(Lcom/facebook/Request;)V"), new JValue (p0));
			}

		}

		[global::Android.Runtime.Register ("com/facebook/widget/PickerFragment$LoadingStrategy", DoNotGenerateAcw=true)]
		internal partial class LoadingStrategyInvoker : LoadingStrategy {

			public LoadingStrategyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (LoadingStrategyInvoker); }
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment.MultiSelectionStrategy']"
		[global::Android.Runtime.Register ("com/facebook/widget/PickerFragment$MultiSelectionStrategy", DoNotGenerateAcw=true)]
		public partial class MultiSelectionStrategy : global::Xamarin.FacebookBinding.Widget.PickerFragment.SelectionStrategy {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/widget/PickerFragment$MultiSelectionStrategy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MultiSelectionStrategy); }
			}

			protected MultiSelectionStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getSelectedIds;
#pragma warning disable 0169
			static Delegate GetGetSelectedIdsHandler ()
			{
				if (cb_getSelectedIds == null)
					cb_getSelectedIds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectedIds);
				return cb_getSelectedIds;
			}

			static IntPtr n_GetSelectedIds (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.Widget.PickerFragment.MultiSelectionStrategy __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.MultiSelectionStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (__this.SelectedIds);
			}
#pragma warning restore 0169

			static IntPtr id_getSelectedIds;
			public virtual global::System.Collections.Generic.ICollection<string> SelectedIds {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment.MultiSelectionStrategy']/method[@name='getSelectedIds' and count(parameter)=0]"
				[Register ("getSelectedIds", "()Ljava/util/Collection;", "GetGetSelectedIdsHandler")]
				get {
					if (id_getSelectedIds == IntPtr.Zero)
						id_getSelectedIds = JNIEnv.GetMethodID (class_ref, "getSelectedIds", "()Ljava/util/Collection;");

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaCollection<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getSelectedIds), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaCollection<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectedIds", "()Ljava/util/Collection;")), JniHandleOwnership.TransferLocalRef);
				}
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
				global::Xamarin.FacebookBinding.Widget.PickerFragment.MultiSelectionStrategy __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.MultiSelectionStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Clear ();
			}
#pragma warning restore 0169

			static IntPtr id_clear;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment.MultiSelectionStrategy']/method[@name='clear' and count(parameter)=0]"
			[Register ("clear", "()V", "GetClearHandler")]
			public virtual void Clear ()
			{
				if (id_clear == IntPtr.Zero)
					id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.widget']/interface[@name='PickerFragment.OnDataChangedListener']"
		[Register ("com/facebook/widget/PickerFragment$OnDataChangedListener", "", "Xamarin.FacebookBinding.Widget.PickerFragment/IOnDataChangedListenerInvoker")]
		public partial interface IOnDataChangedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/interface[@name='PickerFragment.OnDataChangedListener']/method[@name='onDataChanged' and count(parameter)=1 and parameter[1][@type='com.facebook.widget.PickerFragment']]"
			[Register ("onDataChanged", "(Lcom/facebook/widget/PickerFragment;)V", "GetOnDataChanged_Lcom_facebook_widget_PickerFragment_Handler:Xamarin.FacebookBinding.Widget.PickerFragment/IOnDataChangedListenerInvoker, Xamarin.Facebook")]
			void OnDataChanged (global::Xamarin.FacebookBinding.Widget.PickerFragment p0);

		}

		[global::Android.Runtime.Register ("com/facebook/widget/PickerFragment$OnDataChangedListener", DoNotGenerateAcw=true)]
		internal class IOnDataChangedListenerInvoker : global::Java.Lang.Object, IOnDataChangedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/widget/PickerFragment$OnDataChangedListener");
			IntPtr class_ref;

			public static IOnDataChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnDataChangedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.widget.PickerFragment.OnDataChangedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnDataChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnDataChangedListenerInvoker); }
			}

			static Delegate cb_onDataChanged_Lcom_facebook_widget_PickerFragment_;
#pragma warning disable 0169
			static Delegate GetOnDataChanged_Lcom_facebook_widget_PickerFragment_Handler ()
			{
				if (cb_onDataChanged_Lcom_facebook_widget_PickerFragment_ == null)
					cb_onDataChanged_Lcom_facebook_widget_PickerFragment_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDataChanged_Lcom_facebook_widget_PickerFragment_);
				return cb_onDataChanged_Lcom_facebook_widget_PickerFragment_;
			}

			static void n_OnDataChanged_Lcom_facebook_widget_PickerFragment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDataChangedListener __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDataChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.Widget.PickerFragment p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDataChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_onDataChanged_Lcom_facebook_widget_PickerFragment_;
			public void OnDataChanged (global::Xamarin.FacebookBinding.Widget.PickerFragment p0)
			{
				if (id_onDataChanged_Lcom_facebook_widget_PickerFragment_ == IntPtr.Zero)
					id_onDataChanged_Lcom_facebook_widget_PickerFragment_ = JNIEnv.GetMethodID (class_ref, "onDataChanged", "(Lcom/facebook/widget/PickerFragment;)V");
				JNIEnv.CallVoidMethod (Handle, id_onDataChanged_Lcom_facebook_widget_PickerFragment_, new JValue (p0));
			}

		}

		public partial class DataChangedEventArgs : global::System.EventArgs {

			public DataChangedEventArgs (global::Xamarin.FacebookBinding.Widget.PickerFragment p0)
			{
				this.p0 = p0;
			}

			global::Xamarin.FacebookBinding.Widget.PickerFragment p0;
			public global::Xamarin.FacebookBinding.Widget.PickerFragment P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/facebook/widget/PickerFragment_OnDataChangedListenerImplementor")]
		internal sealed class IOnDataChangedListenerImplementor : global::Java.Lang.Object, IOnDataChangedListener {

			object sender;

			public IOnDataChangedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/facebook/widget/PickerFragment_OnDataChangedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DataChangedEventArgs> Handler;
#pragma warning restore 0649

			public void OnDataChanged (global::Xamarin.FacebookBinding.Widget.PickerFragment p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new DataChangedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnDataChangedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.widget']/interface[@name='PickerFragment.OnDoneButtonClickedListener']"
		[Register ("com/facebook/widget/PickerFragment$OnDoneButtonClickedListener", "", "Xamarin.FacebookBinding.Widget.PickerFragment/IOnDoneButtonClickedListenerInvoker")]
		public partial interface IOnDoneButtonClickedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/interface[@name='PickerFragment.OnDoneButtonClickedListener']/method[@name='onDoneButtonClicked' and count(parameter)=1 and parameter[1][@type='com.facebook.widget.PickerFragment']]"
			[Register ("onDoneButtonClicked", "(Lcom/facebook/widget/PickerFragment;)V", "GetOnDoneButtonClicked_Lcom_facebook_widget_PickerFragment_Handler:Xamarin.FacebookBinding.Widget.PickerFragment/IOnDoneButtonClickedListenerInvoker, Xamarin.Facebook")]
			void OnDoneButtonClicked (global::Xamarin.FacebookBinding.Widget.PickerFragment p0);

		}

		[global::Android.Runtime.Register ("com/facebook/widget/PickerFragment$OnDoneButtonClickedListener", DoNotGenerateAcw=true)]
		internal class IOnDoneButtonClickedListenerInvoker : global::Java.Lang.Object, IOnDoneButtonClickedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/widget/PickerFragment$OnDoneButtonClickedListener");
			IntPtr class_ref;

			public static IOnDoneButtonClickedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnDoneButtonClickedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.widget.PickerFragment.OnDoneButtonClickedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnDoneButtonClickedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnDoneButtonClickedListenerInvoker); }
			}

			static Delegate cb_onDoneButtonClicked_Lcom_facebook_widget_PickerFragment_;
#pragma warning disable 0169
			static Delegate GetOnDoneButtonClicked_Lcom_facebook_widget_PickerFragment_Handler ()
			{
				if (cb_onDoneButtonClicked_Lcom_facebook_widget_PickerFragment_ == null)
					cb_onDoneButtonClicked_Lcom_facebook_widget_PickerFragment_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDoneButtonClicked_Lcom_facebook_widget_PickerFragment_);
				return cb_onDoneButtonClicked_Lcom_facebook_widget_PickerFragment_;
			}

			static void n_OnDoneButtonClicked_Lcom_facebook_widget_PickerFragment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDoneButtonClickedListener __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDoneButtonClickedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.Widget.PickerFragment p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDoneButtonClicked (p0);
			}
#pragma warning restore 0169

			IntPtr id_onDoneButtonClicked_Lcom_facebook_widget_PickerFragment_;
			public void OnDoneButtonClicked (global::Xamarin.FacebookBinding.Widget.PickerFragment p0)
			{
				if (id_onDoneButtonClicked_Lcom_facebook_widget_PickerFragment_ == IntPtr.Zero)
					id_onDoneButtonClicked_Lcom_facebook_widget_PickerFragment_ = JNIEnv.GetMethodID (class_ref, "onDoneButtonClicked", "(Lcom/facebook/widget/PickerFragment;)V");
				JNIEnv.CallVoidMethod (Handle, id_onDoneButtonClicked_Lcom_facebook_widget_PickerFragment_, new JValue (p0));
			}

		}

		public partial class DoneButtonClickedEventArgs : global::System.EventArgs {

			public DoneButtonClickedEventArgs (global::Xamarin.FacebookBinding.Widget.PickerFragment p0)
			{
				this.p0 = p0;
			}

			global::Xamarin.FacebookBinding.Widget.PickerFragment p0;
			public global::Xamarin.FacebookBinding.Widget.PickerFragment P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/facebook/widget/PickerFragment_OnDoneButtonClickedListenerImplementor")]
		internal sealed class IOnDoneButtonClickedListenerImplementor : global::Java.Lang.Object, IOnDoneButtonClickedListener {

			object sender;

			public IOnDoneButtonClickedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/facebook/widget/PickerFragment_OnDoneButtonClickedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DoneButtonClickedEventArgs> Handler;
#pragma warning restore 0649

			public void OnDoneButtonClicked (global::Xamarin.FacebookBinding.Widget.PickerFragment p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new DoneButtonClickedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnDoneButtonClickedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.widget']/interface[@name='PickerFragment.OnErrorListener']"
		[Register ("com/facebook/widget/PickerFragment$OnErrorListener", "", "Xamarin.FacebookBinding.Widget.PickerFragment/IOnErrorListenerInvoker")]
		public partial interface IOnErrorListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/interface[@name='PickerFragment.OnErrorListener']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='com.facebook.widget.PickerFragment'] and parameter[2][@type='com.facebook.FacebookException']]"
			[Register ("onError", "(Lcom/facebook/widget/PickerFragment;Lcom/facebook/FacebookException;)V", "GetOnError_Lcom_facebook_widget_PickerFragment_Lcom_facebook_FacebookException_Handler:Xamarin.FacebookBinding.Widget.PickerFragment/IOnErrorListenerInvoker, Xamarin.Facebook")]
			void OnError (global::Xamarin.FacebookBinding.Widget.PickerFragment p0, global::Xamarin.FacebookBinding.FacebookException p1);

		}

		[global::Android.Runtime.Register ("com/facebook/widget/PickerFragment$OnErrorListener", DoNotGenerateAcw=true)]
		internal class IOnErrorListenerInvoker : global::Java.Lang.Object, IOnErrorListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/widget/PickerFragment$OnErrorListener");
			IntPtr class_ref;

			public static IOnErrorListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnErrorListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.widget.PickerFragment.OnErrorListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnErrorListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnErrorListenerInvoker); }
			}

			static Delegate cb_onError_Lcom_facebook_widget_PickerFragment_Lcom_facebook_FacebookException_;
#pragma warning disable 0169
			static Delegate GetOnError_Lcom_facebook_widget_PickerFragment_Lcom_facebook_FacebookException_Handler ()
			{
				if (cb_onError_Lcom_facebook_widget_PickerFragment_Lcom_facebook_FacebookException_ == null)
					cb_onError_Lcom_facebook_widget_PickerFragment_Lcom_facebook_FacebookException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnError_Lcom_facebook_widget_PickerFragment_Lcom_facebook_FacebookException_);
				return cb_onError_Lcom_facebook_widget_PickerFragment_Lcom_facebook_FacebookException_;
			}

			static void n_OnError_Lcom_facebook_widget_PickerFragment_Lcom_facebook_FacebookException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnErrorListener __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnErrorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.Widget.PickerFragment p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.FacebookException p1 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.FacebookException> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onError_Lcom_facebook_widget_PickerFragment_Lcom_facebook_FacebookException_;
			public void OnError (global::Xamarin.FacebookBinding.Widget.PickerFragment p0, global::Xamarin.FacebookBinding.FacebookException p1)
			{
				if (id_onError_Lcom_facebook_widget_PickerFragment_Lcom_facebook_FacebookException_ == IntPtr.Zero)
					id_onError_Lcom_facebook_widget_PickerFragment_Lcom_facebook_FacebookException_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/facebook/widget/PickerFragment;Lcom/facebook/FacebookException;)V");
				JNIEnv.CallVoidMethod (Handle, id_onError_Lcom_facebook_widget_PickerFragment_Lcom_facebook_FacebookException_, new JValue (p0), new JValue (p1));
			}

		}

		public partial class ErrorEventArgs : global::System.EventArgs {

			public ErrorEventArgs (global::Xamarin.FacebookBinding.Widget.PickerFragment p0, global::Xamarin.FacebookBinding.FacebookException p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Xamarin.FacebookBinding.Widget.PickerFragment p0;
			public global::Xamarin.FacebookBinding.Widget.PickerFragment P0 {
				get { return p0; }
			}

			global::Xamarin.FacebookBinding.FacebookException p1;
			public global::Xamarin.FacebookBinding.FacebookException P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/facebook/widget/PickerFragment_OnErrorListenerImplementor")]
		internal sealed class IOnErrorListenerImplementor : global::Java.Lang.Object, IOnErrorListener {

			object sender;

			public IOnErrorListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/facebook/widget/PickerFragment_OnErrorListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ErrorEventArgs> Handler;
#pragma warning restore 0649

			public void OnError (global::Xamarin.FacebookBinding.Widget.PickerFragment p0, global::Xamarin.FacebookBinding.FacebookException p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ErrorEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnErrorListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.widget']/interface[@name='PickerFragment.OnSelectionChangedListener']"
		[Register ("com/facebook/widget/PickerFragment$OnSelectionChangedListener", "", "Xamarin.FacebookBinding.Widget.PickerFragment/IOnSelectionChangedListenerInvoker")]
		public partial interface IOnSelectionChangedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/interface[@name='PickerFragment.OnSelectionChangedListener']/method[@name='onSelectionChanged' and count(parameter)=1 and parameter[1][@type='com.facebook.widget.PickerFragment']]"
			[Register ("onSelectionChanged", "(Lcom/facebook/widget/PickerFragment;)V", "GetOnSelectionChanged_Lcom_facebook_widget_PickerFragment_Handler:Xamarin.FacebookBinding.Widget.PickerFragment/IOnSelectionChangedListenerInvoker, Xamarin.Facebook")]
			void OnSelectionChanged (global::Xamarin.FacebookBinding.Widget.PickerFragment p0);

		}

		[global::Android.Runtime.Register ("com/facebook/widget/PickerFragment$OnSelectionChangedListener", DoNotGenerateAcw=true)]
		internal class IOnSelectionChangedListenerInvoker : global::Java.Lang.Object, IOnSelectionChangedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/widget/PickerFragment$OnSelectionChangedListener");
			IntPtr class_ref;

			public static IOnSelectionChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnSelectionChangedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.widget.PickerFragment.OnSelectionChangedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnSelectionChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnSelectionChangedListenerInvoker); }
			}

			static Delegate cb_onSelectionChanged_Lcom_facebook_widget_PickerFragment_;
#pragma warning disable 0169
			static Delegate GetOnSelectionChanged_Lcom_facebook_widget_PickerFragment_Handler ()
			{
				if (cb_onSelectionChanged_Lcom_facebook_widget_PickerFragment_ == null)
					cb_onSelectionChanged_Lcom_facebook_widget_PickerFragment_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSelectionChanged_Lcom_facebook_widget_PickerFragment_);
				return cb_onSelectionChanged_Lcom_facebook_widget_PickerFragment_;
			}

			static void n_OnSelectionChanged_Lcom_facebook_widget_PickerFragment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnSelectionChangedListener __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnSelectionChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Xamarin.FacebookBinding.Widget.PickerFragment p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSelectionChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSelectionChanged_Lcom_facebook_widget_PickerFragment_;
			public void OnSelectionChanged (global::Xamarin.FacebookBinding.Widget.PickerFragment p0)
			{
				if (id_onSelectionChanged_Lcom_facebook_widget_PickerFragment_ == IntPtr.Zero)
					id_onSelectionChanged_Lcom_facebook_widget_PickerFragment_ = JNIEnv.GetMethodID (class_ref, "onSelectionChanged", "(Lcom/facebook/widget/PickerFragment;)V");
				JNIEnv.CallVoidMethod (Handle, id_onSelectionChanged_Lcom_facebook_widget_PickerFragment_, new JValue (p0));
			}

		}

		public partial class SelectionChangedEventArgs : global::System.EventArgs {

			public SelectionChangedEventArgs (global::Xamarin.FacebookBinding.Widget.PickerFragment p0)
			{
				this.p0 = p0;
			}

			global::Xamarin.FacebookBinding.Widget.PickerFragment p0;
			public global::Xamarin.FacebookBinding.Widget.PickerFragment P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/facebook/widget/PickerFragment_OnSelectionChangedListenerImplementor")]
		internal sealed class IOnSelectionChangedListenerImplementor : global::Java.Lang.Object, IOnSelectionChangedListener {

			object sender;

			public IOnSelectionChangedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/facebook/widget/PickerFragment_OnSelectionChangedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<SelectionChangedEventArgs> Handler;
#pragma warning restore 0649

			public void OnSelectionChanged (global::Xamarin.FacebookBinding.Widget.PickerFragment p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new SelectionChangedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnSelectionChangedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment.PickerFragmentAdapter']"
		[global::Android.Runtime.Register ("com/facebook/widget/PickerFragment$PickerFragmentAdapter", DoNotGenerateAcw=true)]
		public abstract partial class PickerFragmentAdapter : global::Android.Widget.BaseAdapter {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/widget/PickerFragment$PickerFragmentAdapter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PickerFragmentAdapter); }
			}

			protected PickerFragmentAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_facebook_widget_PickerFragment_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment.PickerFragmentAdapter']/constructor[@name='PickerFragment.PickerFragmentAdapter' and count(parameter)=2 and parameter[1][@type='com.facebook.widget.PickerFragment'] and parameter[2][@type='android.content.Context']]"
			[Register (".ctor", "(Lcom/facebook/widget/PickerFragment;Landroid/content/Context;)V", "")]
			public PickerFragmentAdapter (global::Xamarin.FacebookBinding.Widget.PickerFragment __self, global::Android.Content.Context p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (PickerFragmentAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;)V", new JValue (__self), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;)V", new JValue (__self), new JValue (p1));
					return;
				}

				if (id_ctor_Lcom_facebook_widget_PickerFragment_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Lcom_facebook_widget_PickerFragment_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/widget/PickerFragment;Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_widget_PickerFragment_Landroid_content_Context_, new JValue (__self), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_facebook_widget_PickerFragment_Landroid_content_Context_, new JValue (__self), new JValue (p1));
			}

		}

		[global::Android.Runtime.Register ("com/facebook/widget/PickerFragment$PickerFragmentAdapter", DoNotGenerateAcw=true)]
		internal partial class PickerFragmentAdapterInvoker : PickerFragmentAdapter {

			public PickerFragmentAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (PickerFragmentAdapterInvoker); }
			}

			static IntPtr id_getCount;
			public override global::System.Int32 Count {
				// Metadata.xml XPath method reference: path="/api/package[@name='android.widget']/class[@name='BaseAdapter']/method[@name='getCount' and count(parameter)=0]"
				[Register ("getCount", "()I", "GetGetCountHandler")]
				get {
					if (id_getCount == IntPtr.Zero)
						id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");
					return JNIEnv.CallIntMethod  (Handle, id_getCount);
				}
			}

			static IntPtr id_getItem_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.widget']/class[@name='BaseAdapter']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getItem", "(I)Ljava/lang/Object;", "GetGetItem_IHandler")]
			public override global::Java.Lang.Object GetItem (int position)
			{
				if (id_getItem_I == IntPtr.Zero)
					id_getItem_I = JNIEnv.GetMethodID (class_ref, "getItem", "(I)Ljava/lang/Object;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getItem_I, new JValue (position)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_getItemId_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.widget']/class[@name='BaseAdapter']/method[@name='getItemId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getItemId", "(I)J", "GetGetItemId_IHandler")]
			public override global::System.Int64 GetItemId (int position)
			{
				if (id_getItemId_I == IntPtr.Zero)
					id_getItemId_I = JNIEnv.GetMethodID (class_ref, "getItemId", "(I)J");
				return JNIEnv.CallLongMethod  (Handle, id_getItemId_I, new JValue (position));
			}

			static IntPtr id_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.widget']/class[@name='BaseAdapter']/method[@name='getView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
			[Register ("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler")]
			public override global::Android.Views.View GetView (int position, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent)
			{
				if (id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
					id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
				global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getView_ILandroid_view_View_Landroid_view_ViewGroup_, new JValue (position), new JValue (convertView), new JValue (parent)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment.SelectionStrategy']"
		[global::Android.Runtime.Register ("com/facebook/widget/PickerFragment$SelectionStrategy", DoNotGenerateAcw=true)]
		public abstract partial class SelectionStrategy : global::Java.Lang.Object {

			protected SelectionStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		[global::Android.Runtime.Register ("com/facebook/widget/PickerFragment$SelectionStrategy", DoNotGenerateAcw=true)]
		internal partial class SelectionStrategyInvoker : SelectionStrategy {

			public SelectionStrategyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (SelectionStrategyInvoker); }
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment.SingleSelectionStrategy']"
		[global::Android.Runtime.Register ("com/facebook/widget/PickerFragment$SingleSelectionStrategy", DoNotGenerateAcw=true)]
		public partial class SingleSelectionStrategy : global::Xamarin.FacebookBinding.Widget.PickerFragment.SelectionStrategy {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/widget/PickerFragment$SingleSelectionStrategy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SingleSelectionStrategy); }
			}

			protected SingleSelectionStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getSelectedIds;
#pragma warning disable 0169
			static Delegate GetGetSelectedIdsHandler ()
			{
				if (cb_getSelectedIds == null)
					cb_getSelectedIds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectedIds);
				return cb_getSelectedIds;
			}

			static IntPtr n_GetSelectedIds (IntPtr jnienv, IntPtr native__this)
			{
				global::Xamarin.FacebookBinding.Widget.PickerFragment.SingleSelectionStrategy __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.SingleSelectionStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (__this.SelectedIds);
			}
#pragma warning restore 0169

			static IntPtr id_getSelectedIds;
			public virtual global::System.Collections.Generic.ICollection<string> SelectedIds {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment.SingleSelectionStrategy']/method[@name='getSelectedIds' and count(parameter)=0]"
				[Register ("getSelectedIds", "()Ljava/util/Collection;", "GetGetSelectedIdsHandler")]
				get {
					if (id_getSelectedIds == IntPtr.Zero)
						id_getSelectedIds = JNIEnv.GetMethodID (class_ref, "getSelectedIds", "()Ljava/util/Collection;");

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaCollection<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getSelectedIds), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaCollection<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectedIds", "()Ljava/util/Collection;")), JniHandleOwnership.TransferLocalRef);
				}
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
				global::Xamarin.FacebookBinding.Widget.PickerFragment.SingleSelectionStrategy __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.SingleSelectionStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Clear ();
			}
#pragma warning restore 0169

			static IntPtr id_clear;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment.SingleSelectionStrategy']/method[@name='clear' and count(parameter)=0]"
			[Register ("clear", "()V", "GetClearHandler")]
			public virtual void Clear ()
			{
				if (id_clear == IntPtr.Zero)
					id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/widget/PickerFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PickerFragment); }
		}

		protected PickerFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getDoneButtonText;
#pragma warning disable 0169
		static Delegate GetGetDoneButtonTextHandler ()
		{
			if (cb_getDoneButtonText == null)
				cb_getDoneButtonText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDoneButtonText);
			return cb_getDoneButtonText;
		}

		static IntPtr n_GetDoneButtonText (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Widget.PickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DoneButtonText);
		}
#pragma warning restore 0169

		static Delegate cb_setDoneButtonText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDoneButtonText_Ljava_lang_String_Handler ()
		{
			if (cb_setDoneButtonText_Ljava_lang_String_ == null)
				cb_setDoneButtonText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDoneButtonText_Ljava_lang_String_);
			return cb_setDoneButtonText_Ljava_lang_String_;
		}

		static void n_SetDoneButtonText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Widget.PickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DoneButtonText = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDoneButtonText;
		static IntPtr id_setDoneButtonText_Ljava_lang_String_;
		public virtual string DoneButtonText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/method[@name='getDoneButtonText' and count(parameter)=0]"
			[Register ("getDoneButtonText", "()Ljava/lang/String;", "GetGetDoneButtonTextHandler")]
			get {
				if (id_getDoneButtonText == IntPtr.Zero)
					id_getDoneButtonText = JNIEnv.GetMethodID (class_ref, "getDoneButtonText", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDoneButtonText), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDoneButtonText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/method[@name='setDoneButtonText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDoneButtonText", "(Ljava/lang/String;)V", "GetSetDoneButtonText_Ljava_lang_String_Handler")]
			set {
				if (id_setDoneButtonText_Ljava_lang_String_ == IntPtr.Zero)
					id_setDoneButtonText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDoneButtonText", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDoneButtonText_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDoneButtonText", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getExtraFields;
#pragma warning disable 0169
		static Delegate GetGetExtraFieldsHandler ()
		{
			if (cb_getExtraFields == null)
				cb_getExtraFields = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtraFields);
			return cb_getExtraFields;
		}

		static IntPtr n_GetExtraFields (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Widget.PickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.ExtraFields);
		}
#pragma warning restore 0169

		static Delegate cb_setExtraFields_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetSetExtraFields_Ljava_util_Collection_Handler ()
		{
			if (cb_setExtraFields_Ljava_util_Collection_ == null)
				cb_setExtraFields_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExtraFields_Ljava_util_Collection_);
			return cb_setExtraFields_Ljava_util_Collection_;
		}

		static void n_SetExtraFields_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Widget.PickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.ICollection<string> p0 = global::Android.Runtime.JavaCollection<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExtraFields = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExtraFields;
		static IntPtr id_setExtraFields_Ljava_util_Collection_;
		public virtual global::System.Collections.Generic.ICollection<string> ExtraFields {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/method[@name='getExtraFields' and count(parameter)=0]"
			[Register ("getExtraFields", "()Ljava/util/Set;", "GetGetExtraFieldsHandler")]
			get {
				if (id_getExtraFields == IntPtr.Zero)
					id_getExtraFields = JNIEnv.GetMethodID (class_ref, "getExtraFields", "()Ljava/util/Set;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getExtraFields), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExtraFields", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/method[@name='setExtraFields' and count(parameter)=1 and parameter[1][@type='java.util.Collection']]"
			[Register ("setExtraFields", "(Ljava/util/Collection;)V", "GetSetExtraFields_Ljava_util_Collection_Handler")]
			set {
				if (id_setExtraFields_Ljava_util_Collection_ == IntPtr.Zero)
					id_setExtraFields_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "setExtraFields", "(Ljava/util/Collection;)V");
				IntPtr native_value = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setExtraFields_Ljava_util_Collection_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExtraFields", "(Ljava/util/Collection;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getFilter;
#pragma warning disable 0169
		static Delegate GetGetFilterHandler ()
		{
			if (cb_getFilter == null)
				cb_getFilter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFilter);
			return cb_getFilter;
		}

		static IntPtr n_GetFilter (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Widget.PickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Filter);
		}
#pragma warning restore 0169

		static Delegate cb_setFilter_Lcom_facebook_widget_PickerFragment_GraphObjectFilter_;
#pragma warning disable 0169
		static Delegate GetSetFilter_Lcom_facebook_widget_PickerFragment_GraphObjectFilter_Handler ()
		{
			if (cb_setFilter_Lcom_facebook_widget_PickerFragment_GraphObjectFilter_ == null)
				cb_setFilter_Lcom_facebook_widget_PickerFragment_GraphObjectFilter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFilter_Lcom_facebook_widget_PickerFragment_GraphObjectFilter_);
			return cb_setFilter_Lcom_facebook_widget_PickerFragment_GraphObjectFilter_;
		}

		static void n_SetFilter_Lcom_facebook_widget_PickerFragment_GraphObjectFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Widget.PickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.Widget.PickerFragment.IGraphObjectFilter p0 = (global::Xamarin.FacebookBinding.Widget.PickerFragment.IGraphObjectFilter)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.IGraphObjectFilter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Filter = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFilter;
		static IntPtr id_setFilter_Lcom_facebook_widget_PickerFragment_GraphObjectFilter_;
		public virtual global::Xamarin.FacebookBinding.Widget.PickerFragment.IGraphObjectFilter Filter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/method[@name='getFilter' and count(parameter)=0]"
			[Register ("getFilter", "()Lcom/facebook/widget/PickerFragment$GraphObjectFilter;", "GetGetFilterHandler")]
			get {
				if (id_getFilter == IntPtr.Zero)
					id_getFilter = JNIEnv.GetMethodID (class_ref, "getFilter", "()Lcom/facebook/widget/PickerFragment$GraphObjectFilter;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.IGraphObjectFilter> (JNIEnv.CallObjectMethod  (Handle, id_getFilter), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.IGraphObjectFilter> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFilter", "()Lcom/facebook/widget/PickerFragment$GraphObjectFilter;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/method[@name='setFilter' and count(parameter)=1 and parameter[1][@type='com.facebook.widget.PickerFragment.GraphObjectFilter']]"
			[Register ("setFilter", "(Lcom/facebook/widget/PickerFragment$GraphObjectFilter;)V", "GetSetFilter_Lcom_facebook_widget_PickerFragment_GraphObjectFilter_Handler")]
			set {
				if (id_setFilter_Lcom_facebook_widget_PickerFragment_GraphObjectFilter_ == IntPtr.Zero)
					id_setFilter_Lcom_facebook_widget_PickerFragment_GraphObjectFilter_ = JNIEnv.GetMethodID (class_ref, "setFilter", "(Lcom/facebook/widget/PickerFragment$GraphObjectFilter;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setFilter_Lcom_facebook_widget_PickerFragment_GraphObjectFilter_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFilter", "(Lcom/facebook/widget/PickerFragment$GraphObjectFilter;)V"), new JValue (value));
			}
		}

		static Delegate cb_getOnDataChangedListener;
#pragma warning disable 0169
		static Delegate GetGetOnDataChangedListenerHandler ()
		{
			if (cb_getOnDataChangedListener == null)
				cb_getOnDataChangedListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnDataChangedListener);
			return cb_getOnDataChangedListener;
		}

		static IntPtr n_GetOnDataChangedListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Widget.PickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnDataChangedListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnDataChangedListener_Lcom_facebook_widget_PickerFragment_OnDataChangedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnDataChangedListener_Lcom_facebook_widget_PickerFragment_OnDataChangedListener_Handler ()
		{
			if (cb_setOnDataChangedListener_Lcom_facebook_widget_PickerFragment_OnDataChangedListener_ == null)
				cb_setOnDataChangedListener_Lcom_facebook_widget_PickerFragment_OnDataChangedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnDataChangedListener_Lcom_facebook_widget_PickerFragment_OnDataChangedListener_);
			return cb_setOnDataChangedListener_Lcom_facebook_widget_PickerFragment_OnDataChangedListener_;
		}

		static void n_SetOnDataChangedListener_Lcom_facebook_widget_PickerFragment_OnDataChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Widget.PickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDataChangedListener p0 = (global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDataChangedListener)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDataChangedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDataChangedListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOnDataChangedListener;
		static IntPtr id_setOnDataChangedListener_Lcom_facebook_widget_PickerFragment_OnDataChangedListener_;
		public virtual global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDataChangedListener OnDataChangedListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/method[@name='getOnDataChangedListener' and count(parameter)=0]"
			[Register ("getOnDataChangedListener", "()Lcom/facebook/widget/PickerFragment$OnDataChangedListener;", "GetGetOnDataChangedListenerHandler")]
			get {
				if (id_getOnDataChangedListener == IntPtr.Zero)
					id_getOnDataChangedListener = JNIEnv.GetMethodID (class_ref, "getOnDataChangedListener", "()Lcom/facebook/widget/PickerFragment$OnDataChangedListener;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDataChangedListener> (JNIEnv.CallObjectMethod  (Handle, id_getOnDataChangedListener), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDataChangedListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnDataChangedListener", "()Lcom/facebook/widget/PickerFragment$OnDataChangedListener;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/method[@name='setOnDataChangedListener' and count(parameter)=1 and parameter[1][@type='com.facebook.widget.PickerFragment.OnDataChangedListener']]"
			[Register ("setOnDataChangedListener", "(Lcom/facebook/widget/PickerFragment$OnDataChangedListener;)V", "GetSetOnDataChangedListener_Lcom_facebook_widget_PickerFragment_OnDataChangedListener_Handler")]
			set {
				if (id_setOnDataChangedListener_Lcom_facebook_widget_PickerFragment_OnDataChangedListener_ == IntPtr.Zero)
					id_setOnDataChangedListener_Lcom_facebook_widget_PickerFragment_OnDataChangedListener_ = JNIEnv.GetMethodID (class_ref, "setOnDataChangedListener", "(Lcom/facebook/widget/PickerFragment$OnDataChangedListener;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnDataChangedListener_Lcom_facebook_widget_PickerFragment_OnDataChangedListener_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnDataChangedListener", "(Lcom/facebook/widget/PickerFragment$OnDataChangedListener;)V"), new JValue (value));
			}
		}

		static Delegate cb_getOnDoneButtonClickedListener;
#pragma warning disable 0169
		static Delegate GetGetOnDoneButtonClickedListenerHandler ()
		{
			if (cb_getOnDoneButtonClickedListener == null)
				cb_getOnDoneButtonClickedListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnDoneButtonClickedListener);
			return cb_getOnDoneButtonClickedListener;
		}

		static IntPtr n_GetOnDoneButtonClickedListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Widget.PickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnDoneButtonClickedListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnDoneButtonClickedListener_Lcom_facebook_widget_PickerFragment_OnDoneButtonClickedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnDoneButtonClickedListener_Lcom_facebook_widget_PickerFragment_OnDoneButtonClickedListener_Handler ()
		{
			if (cb_setOnDoneButtonClickedListener_Lcom_facebook_widget_PickerFragment_OnDoneButtonClickedListener_ == null)
				cb_setOnDoneButtonClickedListener_Lcom_facebook_widget_PickerFragment_OnDoneButtonClickedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnDoneButtonClickedListener_Lcom_facebook_widget_PickerFragment_OnDoneButtonClickedListener_);
			return cb_setOnDoneButtonClickedListener_Lcom_facebook_widget_PickerFragment_OnDoneButtonClickedListener_;
		}

		static void n_SetOnDoneButtonClickedListener_Lcom_facebook_widget_PickerFragment_OnDoneButtonClickedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Widget.PickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDoneButtonClickedListener p0 = (global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDoneButtonClickedListener)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDoneButtonClickedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDoneButtonClickedListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOnDoneButtonClickedListener;
		static IntPtr id_setOnDoneButtonClickedListener_Lcom_facebook_widget_PickerFragment_OnDoneButtonClickedListener_;
		public virtual global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDoneButtonClickedListener OnDoneButtonClickedListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/method[@name='getOnDoneButtonClickedListener' and count(parameter)=0]"
			[Register ("getOnDoneButtonClickedListener", "()Lcom/facebook/widget/PickerFragment$OnDoneButtonClickedListener;", "GetGetOnDoneButtonClickedListenerHandler")]
			get {
				if (id_getOnDoneButtonClickedListener == IntPtr.Zero)
					id_getOnDoneButtonClickedListener = JNIEnv.GetMethodID (class_ref, "getOnDoneButtonClickedListener", "()Lcom/facebook/widget/PickerFragment$OnDoneButtonClickedListener;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDoneButtonClickedListener> (JNIEnv.CallObjectMethod  (Handle, id_getOnDoneButtonClickedListener), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDoneButtonClickedListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnDoneButtonClickedListener", "()Lcom/facebook/widget/PickerFragment$OnDoneButtonClickedListener;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/method[@name='setOnDoneButtonClickedListener' and count(parameter)=1 and parameter[1][@type='com.facebook.widget.PickerFragment.OnDoneButtonClickedListener']]"
			[Register ("setOnDoneButtonClickedListener", "(Lcom/facebook/widget/PickerFragment$OnDoneButtonClickedListener;)V", "GetSetOnDoneButtonClickedListener_Lcom_facebook_widget_PickerFragment_OnDoneButtonClickedListener_Handler")]
			set {
				if (id_setOnDoneButtonClickedListener_Lcom_facebook_widget_PickerFragment_OnDoneButtonClickedListener_ == IntPtr.Zero)
					id_setOnDoneButtonClickedListener_Lcom_facebook_widget_PickerFragment_OnDoneButtonClickedListener_ = JNIEnv.GetMethodID (class_ref, "setOnDoneButtonClickedListener", "(Lcom/facebook/widget/PickerFragment$OnDoneButtonClickedListener;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnDoneButtonClickedListener_Lcom_facebook_widget_PickerFragment_OnDoneButtonClickedListener_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnDoneButtonClickedListener", "(Lcom/facebook/widget/PickerFragment$OnDoneButtonClickedListener;)V"), new JValue (value));
			}
		}

		static Delegate cb_getOnErrorListener;
#pragma warning disable 0169
		static Delegate GetGetOnErrorListenerHandler ()
		{
			if (cb_getOnErrorListener == null)
				cb_getOnErrorListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnErrorListener);
			return cb_getOnErrorListener;
		}

		static IntPtr n_GetOnErrorListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Widget.PickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnErrorListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnErrorListener_Lcom_facebook_widget_PickerFragment_OnErrorListener_;
#pragma warning disable 0169
		static Delegate GetSetOnErrorListener_Lcom_facebook_widget_PickerFragment_OnErrorListener_Handler ()
		{
			if (cb_setOnErrorListener_Lcom_facebook_widget_PickerFragment_OnErrorListener_ == null)
				cb_setOnErrorListener_Lcom_facebook_widget_PickerFragment_OnErrorListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnErrorListener_Lcom_facebook_widget_PickerFragment_OnErrorListener_);
			return cb_setOnErrorListener_Lcom_facebook_widget_PickerFragment_OnErrorListener_;
		}

		static void n_SetOnErrorListener_Lcom_facebook_widget_PickerFragment_OnErrorListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Widget.PickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnErrorListener p0 = (global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnErrorListener)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnErrorListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnErrorListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOnErrorListener;
		static IntPtr id_setOnErrorListener_Lcom_facebook_widget_PickerFragment_OnErrorListener_;
		public virtual global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnErrorListener OnErrorListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/method[@name='getOnErrorListener' and count(parameter)=0]"
			[Register ("getOnErrorListener", "()Lcom/facebook/widget/PickerFragment$OnErrorListener;", "GetGetOnErrorListenerHandler")]
			get {
				if (id_getOnErrorListener == IntPtr.Zero)
					id_getOnErrorListener = JNIEnv.GetMethodID (class_ref, "getOnErrorListener", "()Lcom/facebook/widget/PickerFragment$OnErrorListener;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnErrorListener> (JNIEnv.CallObjectMethod  (Handle, id_getOnErrorListener), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnErrorListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnErrorListener", "()Lcom/facebook/widget/PickerFragment$OnErrorListener;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/method[@name='setOnErrorListener' and count(parameter)=1 and parameter[1][@type='com.facebook.widget.PickerFragment.OnErrorListener']]"
			[Register ("setOnErrorListener", "(Lcom/facebook/widget/PickerFragment$OnErrorListener;)V", "GetSetOnErrorListener_Lcom_facebook_widget_PickerFragment_OnErrorListener_Handler")]
			set {
				if (id_setOnErrorListener_Lcom_facebook_widget_PickerFragment_OnErrorListener_ == IntPtr.Zero)
					id_setOnErrorListener_Lcom_facebook_widget_PickerFragment_OnErrorListener_ = JNIEnv.GetMethodID (class_ref, "setOnErrorListener", "(Lcom/facebook/widget/PickerFragment$OnErrorListener;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnErrorListener_Lcom_facebook_widget_PickerFragment_OnErrorListener_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnErrorListener", "(Lcom/facebook/widget/PickerFragment$OnErrorListener;)V"), new JValue (value));
			}
		}

		static Delegate cb_getOnSelectionChangedListener;
#pragma warning disable 0169
		static Delegate GetGetOnSelectionChangedListenerHandler ()
		{
			if (cb_getOnSelectionChangedListener == null)
				cb_getOnSelectionChangedListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnSelectionChangedListener);
			return cb_getOnSelectionChangedListener;
		}

		static IntPtr n_GetOnSelectionChangedListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Widget.PickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnSelectionChangedListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnSelectionChangedListener_Lcom_facebook_widget_PickerFragment_OnSelectionChangedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnSelectionChangedListener_Lcom_facebook_widget_PickerFragment_OnSelectionChangedListener_Handler ()
		{
			if (cb_setOnSelectionChangedListener_Lcom_facebook_widget_PickerFragment_OnSelectionChangedListener_ == null)
				cb_setOnSelectionChangedListener_Lcom_facebook_widget_PickerFragment_OnSelectionChangedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnSelectionChangedListener_Lcom_facebook_widget_PickerFragment_OnSelectionChangedListener_);
			return cb_setOnSelectionChangedListener_Lcom_facebook_widget_PickerFragment_OnSelectionChangedListener_;
		}

		static void n_SetOnSelectionChangedListener_Lcom_facebook_widget_PickerFragment_OnSelectionChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Widget.PickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnSelectionChangedListener p0 = (global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnSelectionChangedListener)global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnSelectionChangedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSelectionChangedListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOnSelectionChangedListener;
		static IntPtr id_setOnSelectionChangedListener_Lcom_facebook_widget_PickerFragment_OnSelectionChangedListener_;
		public virtual global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnSelectionChangedListener OnSelectionChangedListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/method[@name='getOnSelectionChangedListener' and count(parameter)=0]"
			[Register ("getOnSelectionChangedListener", "()Lcom/facebook/widget/PickerFragment$OnSelectionChangedListener;", "GetGetOnSelectionChangedListenerHandler")]
			get {
				if (id_getOnSelectionChangedListener == IntPtr.Zero)
					id_getOnSelectionChangedListener = JNIEnv.GetMethodID (class_ref, "getOnSelectionChangedListener", "()Lcom/facebook/widget/PickerFragment$OnSelectionChangedListener;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnSelectionChangedListener> (JNIEnv.CallObjectMethod  (Handle, id_getOnSelectionChangedListener), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnSelectionChangedListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnSelectionChangedListener", "()Lcom/facebook/widget/PickerFragment$OnSelectionChangedListener;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/method[@name='setOnSelectionChangedListener' and count(parameter)=1 and parameter[1][@type='com.facebook.widget.PickerFragment.OnSelectionChangedListener']]"
			[Register ("setOnSelectionChangedListener", "(Lcom/facebook/widget/PickerFragment$OnSelectionChangedListener;)V", "GetSetOnSelectionChangedListener_Lcom_facebook_widget_PickerFragment_OnSelectionChangedListener_Handler")]
			set {
				if (id_setOnSelectionChangedListener_Lcom_facebook_widget_PickerFragment_OnSelectionChangedListener_ == IntPtr.Zero)
					id_setOnSelectionChangedListener_Lcom_facebook_widget_PickerFragment_OnSelectionChangedListener_ = JNIEnv.GetMethodID (class_ref, "setOnSelectionChangedListener", "(Lcom/facebook/widget/PickerFragment$OnSelectionChangedListener;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnSelectionChangedListener_Lcom_facebook_widget_PickerFragment_OnSelectionChangedListener_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnSelectionChangedListener", "(Lcom/facebook/widget/PickerFragment$OnSelectionChangedListener;)V"), new JValue (value));
			}
		}

		static Delegate cb_getSession;
#pragma warning disable 0169
		static Delegate GetGetSessionHandler ()
		{
			if (cb_getSession == null)
				cb_getSession = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSession);
			return cb_getSession;
		}

		static IntPtr n_GetSession (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Widget.PickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Session);
		}
#pragma warning restore 0169

		static Delegate cb_setSession_Lcom_facebook_Session_;
#pragma warning disable 0169
		static Delegate GetSetSession_Lcom_facebook_Session_Handler ()
		{
			if (cb_setSession_Lcom_facebook_Session_ == null)
				cb_setSession_Lcom_facebook_Session_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSession_Lcom_facebook_Session_);
			return cb_setSession_Lcom_facebook_Session_;
		}

		static void n_SetSession_Lcom_facebook_Session_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Widget.PickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Xamarin.FacebookBinding.Session p0 = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Session = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSession;
		static IntPtr id_setSession_Lcom_facebook_Session_;
		public virtual global::Xamarin.FacebookBinding.Session Session {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/method[@name='getSession' and count(parameter)=0]"
			[Register ("getSession", "()Lcom/facebook/Session;", "GetGetSessionHandler")]
			get {
				if (id_getSession == IntPtr.Zero)
					id_getSession = JNIEnv.GetMethodID (class_ref, "getSession", "()Lcom/facebook/Session;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (JNIEnv.CallObjectMethod  (Handle, id_getSession), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Session> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSession", "()Lcom/facebook/Session;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/method[@name='setSession' and count(parameter)=1 and parameter[1][@type='com.facebook.Session']]"
			[Register ("setSession", "(Lcom/facebook/Session;)V", "GetSetSession_Lcom_facebook_Session_Handler")]
			set {
				if (id_setSession_Lcom_facebook_Session_ == IntPtr.Zero)
					id_setSession_Lcom_facebook_Session_ = JNIEnv.GetMethodID (class_ref, "setSession", "(Lcom/facebook/Session;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSession_Lcom_facebook_Session_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSession", "(Lcom/facebook/Session;)V"), new JValue (value));
			}
		}

		static Delegate cb_getShowPictures;
#pragma warning disable 0169
		static Delegate GetGetShowPicturesHandler ()
		{
			if (cb_getShowPictures == null)
				cb_getShowPictures = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetShowPictures);
			return cb_getShowPictures;
		}

		static bool n_GetShowPictures (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Widget.PickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowPictures;
		}
#pragma warning restore 0169

		static Delegate cb_setShowPictures_Z;
#pragma warning disable 0169
		static Delegate GetSetShowPictures_ZHandler ()
		{
			if (cb_setShowPictures_Z == null)
				cb_setShowPictures_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShowPictures_Z);
			return cb_setShowPictures_Z;
		}

		static void n_SetShowPictures_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Xamarin.FacebookBinding.Widget.PickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowPictures = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getShowPictures;
		static IntPtr id_setShowPictures_Z;
		public virtual bool ShowPictures {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/method[@name='getShowPictures' and count(parameter)=0]"
			[Register ("getShowPictures", "()Z", "GetGetShowPicturesHandler")]
			get {
				if (id_getShowPictures == IntPtr.Zero)
					id_getShowPictures = JNIEnv.GetMethodID (class_ref, "getShowPictures", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getShowPictures);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShowPictures", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/method[@name='setShowPictures' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShowPictures", "(Z)V", "GetSetShowPictures_ZHandler")]
			set {
				if (id_setShowPictures_Z == IntPtr.Zero)
					id_setShowPictures_Z = JNIEnv.GetMethodID (class_ref, "setShowPictures", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setShowPictures_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShowPictures", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_getShowTitleBar;
#pragma warning disable 0169
		static Delegate GetGetShowTitleBarHandler ()
		{
			if (cb_getShowTitleBar == null)
				cb_getShowTitleBar = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetShowTitleBar);
			return cb_getShowTitleBar;
		}

		static bool n_GetShowTitleBar (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Widget.PickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowTitleBar;
		}
#pragma warning restore 0169

		static Delegate cb_setShowTitleBar_Z;
#pragma warning disable 0169
		static Delegate GetSetShowTitleBar_ZHandler ()
		{
			if (cb_setShowTitleBar_Z == null)
				cb_setShowTitleBar_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShowTitleBar_Z);
			return cb_setShowTitleBar_Z;
		}

		static void n_SetShowTitleBar_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Xamarin.FacebookBinding.Widget.PickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowTitleBar = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getShowTitleBar;
		static IntPtr id_setShowTitleBar_Z;
		public virtual bool ShowTitleBar {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/method[@name='getShowTitleBar' and count(parameter)=0]"
			[Register ("getShowTitleBar", "()Z", "GetGetShowTitleBarHandler")]
			get {
				if (id_getShowTitleBar == IntPtr.Zero)
					id_getShowTitleBar = JNIEnv.GetMethodID (class_ref, "getShowTitleBar", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getShowTitleBar);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShowTitleBar", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/method[@name='setShowTitleBar' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShowTitleBar", "(Z)V", "GetSetShowTitleBar_ZHandler")]
			set {
				if (id_setShowTitleBar_Z == IntPtr.Zero)
					id_setShowTitleBar_Z = JNIEnv.GetMethodID (class_ref, "setShowTitleBar", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setShowTitleBar_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShowTitleBar", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_getTitleText;
#pragma warning disable 0169
		static Delegate GetGetTitleTextHandler ()
		{
			if (cb_getTitleText == null)
				cb_getTitleText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitleText);
			return cb_getTitleText;
		}

		static IntPtr n_GetTitleText (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Widget.PickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TitleText);
		}
#pragma warning restore 0169

		static Delegate cb_setTitleText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitleText_Ljava_lang_String_Handler ()
		{
			if (cb_setTitleText_Ljava_lang_String_ == null)
				cb_setTitleText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitleText_Ljava_lang_String_);
			return cb_setTitleText_Ljava_lang_String_;
		}

		static void n_SetTitleText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Widget.PickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TitleText = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTitleText;
		static IntPtr id_setTitleText_Ljava_lang_String_;
		public virtual string TitleText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/method[@name='getTitleText' and count(parameter)=0]"
			[Register ("getTitleText", "()Ljava/lang/String;", "GetGetTitleTextHandler")]
			get {
				if (id_getTitleText == IntPtr.Zero)
					id_getTitleText = JNIEnv.GetMethodID (class_ref, "getTitleText", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitleText), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitleText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/method[@name='setTitleText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitleText", "(Ljava/lang/String;)V", "GetSetTitleText_Ljava_lang_String_Handler")]
			set {
				if (id_setTitleText_Ljava_lang_String_ == IntPtr.Zero)
					id_setTitleText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitleText", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTitleText_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitleText", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_loadData_Z;
#pragma warning disable 0169
		static Delegate GetLoadData_ZHandler ()
		{
			if (cb_loadData_Z == null)
				cb_loadData_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_LoadData_Z);
			return cb_loadData_Z;
		}

		static void n_LoadData_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Xamarin.FacebookBinding.Widget.PickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoadData (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadData_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/method[@name='loadData' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("loadData", "(Z)V", "GetLoadData_ZHandler")]
		public virtual void LoadData (bool p0)
		{
			if (id_loadData_Z == IntPtr.Zero)
				id_loadData_Z = JNIEnv.GetMethodID (class_ref, "loadData", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadData_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadData", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setSettingsFromBundle_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSetSettingsFromBundle_Landroid_os_Bundle_Handler ()
		{
			if (cb_setSettingsFromBundle_Landroid_os_Bundle_ == null)
				cb_setSettingsFromBundle_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSettingsFromBundle_Landroid_os_Bundle_);
			return cb_setSettingsFromBundle_Landroid_os_Bundle_;
		}

		static void n_SetSettingsFromBundle_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Widget.PickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSettingsFromBundle (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSettingsFromBundle_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PickerFragment']/method[@name='setSettingsFromBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("setSettingsFromBundle", "(Landroid/os/Bundle;)V", "GetSetSettingsFromBundle_Landroid_os_Bundle_Handler")]
		public virtual void SetSettingsFromBundle (global::Android.OS.Bundle p0)
		{
			if (id_setSettingsFromBundle_Landroid_os_Bundle_ == IntPtr.Zero)
				id_setSettingsFromBundle_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "setSettingsFromBundle", "(Landroid/os/Bundle;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setSettingsFromBundle_Landroid_os_Bundle_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSettingsFromBundle", "(Landroid/os/Bundle;)V"), new JValue (p0));
		}

#region "Event implementation for Xamarin.FacebookBinding.Widget.PickerFragment.IOnDataChangedListener"
		public event EventHandler<global::Xamarin.FacebookBinding.Widget.PickerFragment.DataChangedEventArgs> DataChanged {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDataChangedListener, global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDataChangedListenerImplementor>(
						ref weak_implementor___SetOnDataChangedListener,
						__CreateIOnDataChangedListenerImplementor,
						__v => OnDataChangedListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDataChangedListener, global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDataChangedListenerImplementor>(
						ref weak_implementor___SetOnDataChangedListener,
						global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDataChangedListenerImplementor.__IsEmpty,
						__v => OnDataChangedListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOnDataChangedListener;

		global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDataChangedListenerImplementor __CreateIOnDataChangedListenerImplementor ()
		{
			return new global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDataChangedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Xamarin.FacebookBinding.Widget.PickerFragment.IOnDoneButtonClickedListener"
		public event EventHandler<global::Xamarin.FacebookBinding.Widget.PickerFragment.DoneButtonClickedEventArgs> DoneButtonClicked {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDoneButtonClickedListener, global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDoneButtonClickedListenerImplementor>(
						ref weak_implementor___SetOnDoneButtonClickedListener,
						__CreateIOnDoneButtonClickedListenerImplementor,
						__v => OnDoneButtonClickedListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDoneButtonClickedListener, global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDoneButtonClickedListenerImplementor>(
						ref weak_implementor___SetOnDoneButtonClickedListener,
						global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDoneButtonClickedListenerImplementor.__IsEmpty,
						__v => OnDoneButtonClickedListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOnDoneButtonClickedListener;

		global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDoneButtonClickedListenerImplementor __CreateIOnDoneButtonClickedListenerImplementor ()
		{
			return new global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnDoneButtonClickedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Xamarin.FacebookBinding.Widget.PickerFragment.IOnErrorListener"
		public event EventHandler<global::Xamarin.FacebookBinding.Widget.PickerFragment.ErrorEventArgs> Error {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnErrorListener, global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnErrorListenerImplementor>(
						ref weak_implementor___SetOnErrorListener,
						__CreateIOnErrorListenerImplementor,
						__v => OnErrorListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnErrorListener, global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnErrorListenerImplementor>(
						ref weak_implementor___SetOnErrorListener,
						global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnErrorListenerImplementor.__IsEmpty,
						__v => OnErrorListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOnErrorListener;

		global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnErrorListenerImplementor __CreateIOnErrorListenerImplementor ()
		{
			return new global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnErrorListenerImplementor (this);
		}
#endregion
#region "Event implementation for Xamarin.FacebookBinding.Widget.PickerFragment.IOnSelectionChangedListener"
		public event EventHandler<global::Xamarin.FacebookBinding.Widget.PickerFragment.SelectionChangedEventArgs> SelectionChanged {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnSelectionChangedListener, global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnSelectionChangedListenerImplementor>(
						ref weak_implementor___SetOnSelectionChangedListener,
						__CreateIOnSelectionChangedListenerImplementor,
						__v => OnSelectionChangedListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnSelectionChangedListener, global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnSelectionChangedListenerImplementor>(
						ref weak_implementor___SetOnSelectionChangedListener,
						global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnSelectionChangedListenerImplementor.__IsEmpty,
						__v => OnSelectionChangedListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOnSelectionChangedListener;

		global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnSelectionChangedListenerImplementor __CreateIOnSelectionChangedListenerImplementor ()
		{
			return new global::Xamarin.FacebookBinding.Widget.PickerFragment.IOnSelectionChangedListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("com/facebook/widget/PickerFragment", DoNotGenerateAcw=true)]
	internal partial class PickerFragmentInvoker : PickerFragment {

		public PickerFragmentInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (PickerFragmentInvoker); }
		}

	}

}
