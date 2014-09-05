using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Xamarin.FacebookBinding.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.widget']/class[@name='FriendPickerFragment']"
	[global::Android.Runtime.Register ("com/facebook/widget/FriendPickerFragment", DoNotGenerateAcw=true)]
	public partial class FriendPickerFragment : global::Xamarin.FacebookBinding.Widget.PickerFragment {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.widget']/class[@name='FriendPickerFragment']/field[@name='MULTI_SELECT_BUNDLE_KEY']"
		[Register ("MULTI_SELECT_BUNDLE_KEY")]
		public const string MultiSelectBundleKey = (string) "com.facebook.widget.FriendPickerFragment.MultiSelect";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.widget']/class[@name='FriendPickerFragment']/field[@name='USER_ID_BUNDLE_KEY']"
		[Register ("USER_ID_BUNDLE_KEY")]
		public const string UserIdBundleKey = (string) "com.facebook.widget.FriendPickerFragment.UserId";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.widget']/class[@name='FriendPickerFragment.ImmediateLoadingStrategy']"
		[global::Android.Runtime.Register ("com/facebook/widget/FriendPickerFragment$ImmediateLoadingStrategy", DoNotGenerateAcw=true)]
		public partial class ImmediateLoadingStrategy : global::Xamarin.FacebookBinding.Widget.PickerFragment.LoadingStrategy {

			protected ImmediateLoadingStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/widget/FriendPickerFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FriendPickerFragment); }
		}

		protected FriendPickerFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Bundle_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.widget']/class[@name='FriendPickerFragment']/constructor[@name='FriendPickerFragment' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register (".ctor", "(Landroid/os/Bundle;)V", "")]
		public FriendPickerFragment (global::Android.OS.Bundle p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (FriendPickerFragment)) {
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

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.widget']/class[@name='FriendPickerFragment']/constructor[@name='FriendPickerFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public FriendPickerFragment () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (FriendPickerFragment)) {
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

		static Delegate cb_getMultiSelect;
#pragma warning disable 0169
		static Delegate GetGetMultiSelectHandler ()
		{
			if (cb_getMultiSelect == null)
				cb_getMultiSelect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetMultiSelect);
			return cb_getMultiSelect;
		}

		static bool n_GetMultiSelect (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Widget.FriendPickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.FriendPickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MultiSelect;
		}
#pragma warning restore 0169

		static Delegate cb_setMultiSelect_Z;
#pragma warning disable 0169
		static Delegate GetSetMultiSelect_ZHandler ()
		{
			if (cb_setMultiSelect_Z == null)
				cb_setMultiSelect_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMultiSelect_Z);
			return cb_setMultiSelect_Z;
		}

		static void n_SetMultiSelect_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Xamarin.FacebookBinding.Widget.FriendPickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.FriendPickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MultiSelect = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMultiSelect;
		static IntPtr id_setMultiSelect_Z;
		public virtual bool MultiSelect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='FriendPickerFragment']/method[@name='getMultiSelect' and count(parameter)=0]"
			[Register ("getMultiSelect", "()Z", "GetGetMultiSelectHandler")]
			get {
				if (id_getMultiSelect == IntPtr.Zero)
					id_getMultiSelect = JNIEnv.GetMethodID (class_ref, "getMultiSelect", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getMultiSelect);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMultiSelect", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='FriendPickerFragment']/method[@name='setMultiSelect' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMultiSelect", "(Z)V", "GetSetMultiSelect_ZHandler")]
			set {
				if (id_setMultiSelect_Z == IntPtr.Zero)
					id_setMultiSelect_Z = JNIEnv.GetMethodID (class_ref, "setMultiSelect", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMultiSelect_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMultiSelect", "(Z)V"), new JValue (value));
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
			global::Xamarin.FacebookBinding.Widget.FriendPickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.FriendPickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Xamarin.FacebookBinding.Model.IGraphUser>.ToLocalJniHandle (__this.Selection);
		}
#pragma warning restore 0169

		static IntPtr id_getSelection;
		public virtual global::System.Collections.Generic.IList<global::Xamarin.FacebookBinding.Model.IGraphUser> Selection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='FriendPickerFragment']/method[@name='getSelection' and count(parameter)=0]"
			[Register ("getSelection", "()Ljava/util/List;", "GetGetSelectionHandler")]
			get {
				if (id_getSelection == IntPtr.Zero)
					id_getSelection = JNIEnv.GetMethodID (class_ref, "getSelection", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Xamarin.FacebookBinding.Model.IGraphUser>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getSelection), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Xamarin.FacebookBinding.Model.IGraphUser>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelection", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUserId;
#pragma warning disable 0169
		static Delegate GetGetUserIdHandler ()
		{
			if (cb_getUserId == null)
				cb_getUserId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserId);
			return cb_getUserId;
		}

		static IntPtr n_GetUserId (IntPtr jnienv, IntPtr native__this)
		{
			global::Xamarin.FacebookBinding.Widget.FriendPickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.FriendPickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserId);
		}
#pragma warning restore 0169

		static Delegate cb_setUserId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserId_Ljava_lang_String_Handler ()
		{
			if (cb_setUserId_Ljava_lang_String_ == null)
				cb_setUserId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserId_Ljava_lang_String_);
			return cb_setUserId_Ljava_lang_String_;
		}

		static void n_SetUserId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Xamarin.FacebookBinding.Widget.FriendPickerFragment __this = global::Java.Lang.Object.GetObject<global::Xamarin.FacebookBinding.Widget.FriendPickerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserId;
		static IntPtr id_setUserId_Ljava_lang_String_;
		public virtual string UserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='FriendPickerFragment']/method[@name='getUserId' and count(parameter)=0]"
			[Register ("getUserId", "()Ljava/lang/String;", "GetGetUserIdHandler")]
			get {
				if (id_getUserId == IntPtr.Zero)
					id_getUserId = JNIEnv.GetMethodID (class_ref, "getUserId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUserId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.widget']/class[@name='FriendPickerFragment']/method[@name='setUserId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUserId", "(Ljava/lang/String;)V", "GetSetUserId_Ljava_lang_String_Handler")]
			set {
				if (id_setUserId_Ljava_lang_String_ == IntPtr.Zero)
					id_setUserId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUserId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setUserId_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserId", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
