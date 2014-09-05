using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.widget']/class[@name='PlacePickerFragment']"
	[global::Android.Runtime.Register ("com/facebook/widget/PlacePickerFragment", DoNotGenerateAcw=true)]
	public partial class PlacePickerFragment : global::Xamarin.FacebookBinding.Widget.PickerFragment {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.widget']/class[@name='PlacePickerFragment']/field[@name='DEFAULT_RADIUS_IN_METERS']"
		[Register ("DEFAULT_RADIUS_IN_METERS")]
		public const int DefaultRadiusInMeters = (int) 1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.widget']/class[@name='PlacePickerFragment']/field[@name='DEFAULT_RESULTS_LIMIT']"
		[Register ("DEFAULT_RESULTS_LIMIT")]
		public const int DefaultResultsLimit = (int) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.widget']/class[@name='PlacePickerFragment']/field[@name='LOCATION_BUNDLE_KEY']"
		[Register ("LOCATION_BUNDLE_KEY")]
		public const string LocationBundleKey = (string) "com.facebook.widget.PlacePickerFragment.Location";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.widget']/class[@name='PlacePickerFragment']/field[@name='RADIUS_IN_METERS_BUNDLE_KEY']"
		[Register ("RADIUS_IN_METERS_BUNDLE_KEY")]
		public const string RadiusInMetersBundleKey = (string) "com.facebook.widget.PlacePickerFragment.RadiusInMeters";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.widget']/class[@name='PlacePickerFragment']/field[@name='RESULTS_LIMIT_BUNDLE_KEY']"
		[Register ("RESULTS_LIMIT_BUNDLE_KEY")]
		public const string ResultsLimitBundleKey = (string) "com.facebook.widget.PlacePickerFragment.ResultsLimit";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.widget']/class[@name='PlacePickerFragment']/field[@name='SEARCH_TEXT_BUNDLE_KEY']"
		[Register ("SEARCH_TEXT_BUNDLE_KEY")]
		public const string SearchTextBundleKey = (string) "com.facebook.widget.PlacePickerFragment.SearchText";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.widget']/class[@name='PlacePickerFragment']/field[@name='SHOW_SEARCH_BOX_BUNDLE_KEY']"
		[Register ("SHOW_SEARCH_BOX_BUNDLE_KEY")]
		public const string ShowSearchBoxBundleKey = (string) "com.facebook.widget.PlacePickerFragment.ShowSearchBox";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.widget']/class[@name='PlacePickerFragment.AsNeededLoadingStrategy']"
		[global::Android.Runtime.Register ("com/facebook/widget/PlacePickerFragment$AsNeededLoadingStrategy", DoNotGenerateAcw=true)]
		public partial class AsNeededLoadingStrategy : global::Xamarin.FacebookBinding.Widget.PickerFragment.LoadingStrategy {

			protected AsNeededLoadingStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.widget']/class[@name='PlacePickerFragment.SearchTextWatcher']"
		[global::Android.Runtime.Register ("com/facebook/widget/PlacePickerFragment$SearchTextWatcher", DoNotGenerateAcw=true)]
		public partial class SearchTextWatcher : global::Java.Lang.Object, global::Android.Text.ITextWatcher {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/widget/PlacePickerFragment$SearchTextWatcher", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SearchTextWatcher); }
			}

			protected SearchTextWatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_afterTextChanged_Landroid_text_Editable_;
#pragma warning disable 0169
			static Delegate GetAfterTextChanged_Landroid_text_Editable_Handler ()
			{
				if (cb_afterTextChanged_Landroid_text_Editable_ == null)
					cb_afterTextChanged_Landroid_text_Editable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AfterTextChanged_Landroid_text_Editable_);
				return cb_afterTextChanged_Landroid_text_Editable_;
			}

			static void n_AfterTextChanged_Landroid_text_Editable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Xamarin.FacebookBinding.Widget.PlacePickerFragment.SearchTextWatcher __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PlacePickerFragment.SearchTextWatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Text.IEditable p0 = (global::Android.Text.IEditable)global::Java.Lang.Object.GetObject<global::Android.Text.IEditable> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.AfterTextChanged (p0);
			}
#pragma warning restore 0169

			static IntPtr id_afterTextChanged_Landroid_text_Editable_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PlacePickerFragment.SearchTextWatcher']/method[@name='afterTextChanged' and count(parameter)=1 and parameter[1][@type='android.text.Editable']]"
			[Register ("afterTextChanged", "(Landroid/text/Editable;)V", "GetAfterTextChanged_Landroid_text_Editable_Handler")]
			public virtual void AfterTextChanged (global::Android.Text.IEditable p0)
			{
				if (id_afterTextChanged_Landroid_text_Editable_ == IntPtr.Zero)
					id_afterTextChanged_Landroid_text_Editable_ = JNIEnv.GetMethodID (class_ref, "afterTextChanged", "(Landroid/text/Editable;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_afterTextChanged_Landroid_text_Editable_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "afterTextChanged", "(Landroid/text/Editable;)V"), new JValue (p0));
			}

			static Delegate cb_beforeTextChanged_Ljava_lang_CharSequence_III;
#pragma warning disable 0169
			static Delegate GetBeforeTextChanged_Ljava_lang_CharSequence_IIIHandler ()
			{
				if (cb_beforeTextChanged_Ljava_lang_CharSequence_III == null)
					cb_beforeTextChanged_Ljava_lang_CharSequence_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_BeforeTextChanged_Ljava_lang_CharSequence_III);
				return cb_beforeTextChanged_Ljava_lang_CharSequence_III;
			}

			static void n_BeforeTextChanged_Ljava_lang_CharSequence_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
			{
				global::Xamarin.FacebookBinding.Widget.PlacePickerFragment.SearchTextWatcher __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PlacePickerFragment.SearchTextWatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.BeforeTextChanged (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_beforeTextChanged_Ljava_lang_CharSequence_III;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PlacePickerFragment.SearchTextWatcher']/method[@name='beforeTextChanged' and count(parameter)=4 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("beforeTextChanged", "(Ljava/lang/CharSequence;III)V", "GetBeforeTextChanged_Ljava_lang_CharSequence_IIIHandler")]
			public virtual void BeforeTextChanged (global::Java.Lang.ICharSequence p0, int p1, int p2, int p3)
			{
				if (id_beforeTextChanged_Ljava_lang_CharSequence_III == IntPtr.Zero)
					id_beforeTextChanged_Ljava_lang_CharSequence_III = JNIEnv.GetMethodID (class_ref, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V");
				IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_beforeTextChanged_Ljava_lang_CharSequence_III, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V"), new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			public void BeforeTextChanged (string p0, int p1, int p2, int p3)
			{
				global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
				BeforeTextChanged (jls_p0, p1, p2, p3);
				if (jls_p0 != null) jls_p0.Dispose ();
			}

			static Delegate cb_onTextChanged_Ljava_lang_CharSequence_III;
#pragma warning disable 0169
			static Delegate GetOnTextChanged_Ljava_lang_CharSequence_IIIHandler ()
			{
				if (cb_onTextChanged_Ljava_lang_CharSequence_III == null)
					cb_onTextChanged_Ljava_lang_CharSequence_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_OnTextChanged_Ljava_lang_CharSequence_III);
				return cb_onTextChanged_Ljava_lang_CharSequence_III;
			}

			static void n_OnTextChanged_Ljava_lang_CharSequence_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
			{
				global::Xamarin.FacebookBinding.Widget.PlacePickerFragment.SearchTextWatcher __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PlacePickerFragment.SearchTextWatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnTextChanged (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_onTextChanged_Ljava_lang_CharSequence_III;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PlacePickerFragment.SearchTextWatcher']/method[@name='onTextChanged' and count(parameter)=4 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("onTextChanged", "(Ljava/lang/CharSequence;III)V", "GetOnTextChanged_Ljava_lang_CharSequence_IIIHandler")]
			public virtual void OnTextChanged (global::Java.Lang.ICharSequence p0, int p1, int p2, int p3)
			{
				if (id_onTextChanged_Ljava_lang_CharSequence_III == IntPtr.Zero)
					id_onTextChanged_Ljava_lang_CharSequence_III = JNIEnv.GetMethodID (class_ref, "onTextChanged", "(Ljava/lang/CharSequence;III)V");
				IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onTextChanged_Ljava_lang_CharSequence_III, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V"), new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			public void OnTextChanged (string p0, int p1, int p2, int p3)
			{
				global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
				OnTextChanged (jls_p0, p1, p2, p3);
				if (jls_p0 != null) jls_p0.Dispose ();
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/widget/PlacePickerFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlacePickerFragment); }
		}

		protected PlacePickerFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.widget']/class[@name='PlacePickerFragment']/constructor[@name='PlacePickerFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public PlacePickerFragment () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PlacePickerFragment)) {
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

		static IntPtr id_ctor_Landroid_os_Bundle_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.widget']/class[@name='PlacePickerFragment']/constructor[@name='PlacePickerFragment' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register (".ctor", "(Landroid/os/Bundle;)V", "")]
		public PlacePickerFragment (global::Android.OS.Bundle p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PlacePickerFragment)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Bundle;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Bundle;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_os_Bundle_ == IntPtr.Zero)
				id_ctor_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Bundle;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Bundle_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Bundle_, new JValue (p0));
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
			global::Xamarin.FacebookBinding.Widget.PlacePickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PlacePickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Location);
		}
#pragma warning restore 0169

		static Delegate cb_setLocation_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetSetLocation_Landroid_location_Location_Handler ()
		{
			if (cb_setLocation_Landroid_location_Location_ == null)
				cb_setLocation_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocation_Landroid_location_Location_);
			return cb_setLocation_Landroid_location_Location_;
		}

		static void n_SetLocation_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Widget.PlacePickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PlacePickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location p0 = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Location = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLocation;
		static IntPtr id_setLocation_Landroid_location_Location_;
		public virtual global::Android.Locations.Location Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PlacePickerFragment']/method[@name='getLocation' and count(parameter)=0]"
			[Register ("getLocation", "()Landroid/location/Location;", "GetGetLocationHandler")]
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Landroid/location/Location;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallObjectMethod  (Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocation", "()Landroid/location/Location;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PlacePickerFragment']/method[@name='setLocation' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
			[Register ("setLocation", "(Landroid/location/Location;)V", "GetSetLocation_Landroid_location_Location_Handler")]
			set {
				if (id_setLocation_Landroid_location_Location_ == IntPtr.Zero)
					id_setLocation_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "setLocation", "(Landroid/location/Location;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLocation_Landroid_location_Location_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocation", "(Landroid/location/Location;)V"), new JValue (value));
			}
		}

		static Delegate cb_getRadiusInMeters;
#pragma warning disable 0169
		static Delegate GetGetRadiusInMetersHandler ()
		{
			if (cb_getRadiusInMeters == null)
				cb_getRadiusInMeters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRadiusInMeters);
			return cb_getRadiusInMeters;
		}

		static int n_GetRadiusInMeters (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Widget.PlacePickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PlacePickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RadiusInMeters;
		}
#pragma warning restore 0169

		static Delegate cb_setRadiusInMeters_I;
#pragma warning disable 0169
		static Delegate GetSetRadiusInMeters_IHandler ()
		{
			if (cb_setRadiusInMeters_I == null)
				cb_setRadiusInMeters_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRadiusInMeters_I);
			return cb_setRadiusInMeters_I;
		}

		static void n_SetRadiusInMeters_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Xamarin.FacebookBinding.Widget.PlacePickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PlacePickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RadiusInMeters = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRadiusInMeters;
		static IntPtr id_setRadiusInMeters_I;
		public virtual int RadiusInMeters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PlacePickerFragment']/method[@name='getRadiusInMeters' and count(parameter)=0]"
			[Register ("getRadiusInMeters", "()I", "GetGetRadiusInMetersHandler")]
			get {
				if (id_getRadiusInMeters == IntPtr.Zero)
					id_getRadiusInMeters = JNIEnv.GetMethodID (class_ref, "getRadiusInMeters", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getRadiusInMeters);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRadiusInMeters", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PlacePickerFragment']/method[@name='setRadiusInMeters' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRadiusInMeters", "(I)V", "GetSetRadiusInMeters_IHandler")]
			set {
				if (id_setRadiusInMeters_I == IntPtr.Zero)
					id_setRadiusInMeters_I = JNIEnv.GetMethodID (class_ref, "setRadiusInMeters", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRadiusInMeters_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRadiusInMeters", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getResultsLimit;
#pragma warning disable 0169
		static Delegate GetGetResultsLimitHandler ()
		{
			if (cb_getResultsLimit == null)
				cb_getResultsLimit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetResultsLimit);
			return cb_getResultsLimit;
		}

		static int n_GetResultsLimit (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Widget.PlacePickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PlacePickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResultsLimit;
		}
#pragma warning restore 0169

		static Delegate cb_setResultsLimit_I;
#pragma warning disable 0169
		static Delegate GetSetResultsLimit_IHandler ()
		{
			if (cb_setResultsLimit_I == null)
				cb_setResultsLimit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetResultsLimit_I);
			return cb_setResultsLimit_I;
		}

		static void n_SetResultsLimit_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Xamarin.FacebookBinding.Widget.PlacePickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PlacePickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResultsLimit = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResultsLimit;
		static IntPtr id_setResultsLimit_I;
		public virtual int ResultsLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PlacePickerFragment']/method[@name='getResultsLimit' and count(parameter)=0]"
			[Register ("getResultsLimit", "()I", "GetGetResultsLimitHandler")]
			get {
				if (id_getResultsLimit == IntPtr.Zero)
					id_getResultsLimit = JNIEnv.GetMethodID (class_ref, "getResultsLimit", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getResultsLimit);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResultsLimit", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PlacePickerFragment']/method[@name='setResultsLimit' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setResultsLimit", "(I)V", "GetSetResultsLimit_IHandler")]
			set {
				if (id_setResultsLimit_I == IntPtr.Zero)
					id_setResultsLimit_I = JNIEnv.GetMethodID (class_ref, "setResultsLimit", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setResultsLimit_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResultsLimit", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getSearchText;
#pragma warning disable 0169
		static Delegate GetGetSearchTextHandler ()
		{
			if (cb_getSearchText == null)
				cb_getSearchText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSearchText);
			return cb_getSearchText;
		}

		static IntPtr n_GetSearchText (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Widget.PlacePickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PlacePickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SearchText);
		}
#pragma warning restore 0169

		static Delegate cb_setSearchText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSearchText_Ljava_lang_String_Handler ()
		{
			if (cb_setSearchText_Ljava_lang_String_ == null)
				cb_setSearchText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSearchText_Ljava_lang_String_);
			return cb_setSearchText_Ljava_lang_String_;
		}

		static void n_SetSearchText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Widget.PlacePickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PlacePickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SearchText = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSearchText;
		static IntPtr id_setSearchText_Ljava_lang_String_;
		public virtual string SearchText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PlacePickerFragment']/method[@name='getSearchText' and count(parameter)=0]"
			[Register ("getSearchText", "()Ljava/lang/String;", "GetGetSearchTextHandler")]
			get {
				if (id_getSearchText == IntPtr.Zero)
					id_getSearchText = JNIEnv.GetMethodID (class_ref, "getSearchText", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSearchText), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSearchText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PlacePickerFragment']/method[@name='setSearchText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSearchText", "(Ljava/lang/String;)V", "GetSetSearchText_Ljava_lang_String_Handler")]
			set {
				if (id_setSearchText_Ljava_lang_String_ == IntPtr.Zero)
					id_setSearchText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSearchText", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSearchText_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSearchText", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getSelection;
#pragma warning disable 0169
		static Delegate GetGetSelectionHandler ()
		{
			if (cb_getSelection == null)
				cb_getSelection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelection);
			return cb_getSelection;
		}

		static IntPtr n_GetSelection (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Widget.PlacePickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PlacePickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Selection);
		}
#pragma warning restore 0169

		static IntPtr id_getSelection;
		public virtual global::Xamarin.FacebookBinding.Model.IGraphPlace Selection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PlacePickerFragment']/method[@name='getSelection' and count(parameter)=0]"
			[Register ("getSelection", "()Lcom/facebook/model/GraphPlace;", "GetGetSelectionHandler")]
			get {
				if (id_getSelection == IntPtr.Zero)
					id_getSelection = JNIEnv.GetMethodID (class_ref, "getSelection", "()Lcom/facebook/model/GraphPlace;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphPlace> (JNIEnv.CallObjectMethod  (Handle, id_getSelection), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Model.IGraphPlace> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelection", "()Lcom/facebook/model/GraphPlace;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_onSearchBoxTextChanged_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetOnSearchBoxTextChanged_Ljava_lang_String_ZHandler ()
		{
			if (cb_onSearchBoxTextChanged_Ljava_lang_String_Z == null)
				cb_onSearchBoxTextChanged_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnSearchBoxTextChanged_Ljava_lang_String_Z);
			return cb_onSearchBoxTextChanged_Ljava_lang_String_Z;
		}

		static void n_OnSearchBoxTextChanged_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Xamarin.FacebookBinding.Widget.PlacePickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.PlacePickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSearchBoxTextChanged (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onSearchBoxTextChanged_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='PlacePickerFragment']/method[@name='onSearchBoxTextChanged' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("onSearchBoxTextChanged", "(Ljava/lang/String;Z)V", "GetOnSearchBoxTextChanged_Ljava_lang_String_ZHandler")]
		public virtual void OnSearchBoxTextChanged (string p0, bool p1)
		{
			if (id_onSearchBoxTextChanged_Ljava_lang_String_Z == IntPtr.Zero)
				id_onSearchBoxTextChanged_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "onSearchBoxTextChanged", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onSearchBoxTextChanged_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSearchBoxTextChanged", "(Ljava/lang/String;Z)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
