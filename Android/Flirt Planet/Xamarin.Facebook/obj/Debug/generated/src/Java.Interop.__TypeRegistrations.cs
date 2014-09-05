using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/facebook",
						"com/facebook/android",
						"com/facebook/internal",
						"com/facebook/model",
						"com/facebook/widget",
					},
					new Converter<string, Type>[]{
						lookup_com_facebook_package,
						lookup_com_facebook_android_package,
						lookup_com_facebook_internal_package,
						lookup_com_facebook_model_package,
						lookup_com_facebook_widget_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_facebook_mappings;
		static Type lookup_com_facebook_package (string klass)
		{
			if (package_com_facebook_mappings == null) {
				package_com_facebook_mappings = new string[]{
					"com/facebook/AccessToken:Xamarin.FacebookBinding.AccessToken",
					"com/facebook/AccessToken$SerializationProxyV1:Xamarin.FacebookBinding.AccessToken/SerializationProxyV1",
					"com/facebook/AccessTokenSource:Xamarin.FacebookBinding.AccessTokenSource",
					"com/facebook/FacebookAuthorizationException:Xamarin.FacebookBinding.FacebookAuthorizationException",
					"com/facebook/FacebookDialogException:Xamarin.FacebookBinding.FacebookDialogException",
					"com/facebook/FacebookException:Xamarin.FacebookBinding.FacebookException",
					"com/facebook/FacebookGraphObjectException:Xamarin.FacebookBinding.FacebookGraphObjectException",
					"com/facebook/FacebookOperationCanceledException:Xamarin.FacebookBinding.FacebookOperationCanceledException",
					"com/facebook/FacebookRequestError:Xamarin.FacebookBinding.FacebookRequestError",
					"com/facebook/FacebookRequestError$Category:Xamarin.FacebookBinding.FacebookRequestError/Category",
					"com/facebook/FacebookRequestError$Range:Xamarin.FacebookBinding.FacebookRequestError/Range",
					"com/facebook/FacebookServiceException:Xamarin.FacebookBinding.FacebookServiceException",
					"com/facebook/HttpMethod:Xamarin.FacebookBinding.HttpMethod",
					"com/facebook/InsightsLogger:Xamarin.FacebookBinding.InsightsLogger",
					"com/facebook/LegacyHelper:Xamarin.FacebookBinding.LegacyHelper",
					"com/facebook/LoggingBehavior:Xamarin.FacebookBinding.LoggingBehavior",
					"com/facebook/LoginActivity:Xamarin.FacebookBinding.LoginActivity",
					"com/facebook/NonCachingTokenCachingStrategy:Xamarin.FacebookBinding.NonCachingTokenCachingStrategy",
					"com/facebook/Request:Xamarin.FacebookBinding.Request",
					"com/facebook/Request$Serializer:Xamarin.FacebookBinding.Request/Serializer",
					"com/facebook/RequestAsyncTask:Xamarin.FacebookBinding.RequestAsyncTask",
					"com/facebook/RequestBatch:Xamarin.FacebookBinding.RequestBatch",
					"com/facebook/Response:Xamarin.FacebookBinding.Response",
					"com/facebook/Response$PagingDirection:Xamarin.FacebookBinding.Response/PagingDirection",
					"com/facebook/Session:Xamarin.FacebookBinding.Session",
					"com/facebook/Session$AuthorizationRequest:Xamarin.FacebookBinding.Session/AuthorizationRequest",
					"com/facebook/Session$AuthorizationRequest$AuthRequestSerializationProxyV1:Xamarin.FacebookBinding.Session/AuthorizationRequest/AuthRequestSerializationProxyV1",
					"com/facebook/Session$AutoPublishAsyncTask:Xamarin.FacebookBinding.Session/AutoPublishAsyncTask",
					"com/facebook/Session$Builder:Xamarin.FacebookBinding.Session/Builder",
					"com/facebook/Session$NewPermissionsRequest:Xamarin.FacebookBinding.Session/NewPermissionsRequest",
					"com/facebook/Session$OpenRequest:Xamarin.FacebookBinding.Session/OpenRequest",
					"com/facebook/Session$SerializationProxyV1:Xamarin.FacebookBinding.Session/SerializationProxyV1",
					"com/facebook/Session$TokenRefreshRequest:Xamarin.FacebookBinding.Session/TokenRefreshRequest",
					"com/facebook/Session$TokenRefreshRequestHandler:Xamarin.FacebookBinding.Session/TokenRefreshRequestHandler",
					"com/facebook/SessionDefaultAudience:Xamarin.FacebookBinding.SessionDefaultAudience",
					"com/facebook/SessionLoginBehavior:Xamarin.FacebookBinding.SessionLoginBehavior",
					"com/facebook/SessionState:Xamarin.FacebookBinding.SessionState",
					"com/facebook/SessionState$Category:Xamarin.FacebookBinding.SessionState/Category",
					"com/facebook/Settings:Xamarin.FacebookBinding.Settings",
					"com/facebook/SharedPreferencesTokenCachingStrategy:Xamarin.FacebookBinding.SharedPreferencesTokenCachingStrategy",
					"com/facebook/TestSession:Xamarin.FacebookBinding.TestSession",
					"com/facebook/TestSession$Mode:Xamarin.FacebookBinding.TestSession/Mode",
					"com/facebook/TestSession$TestTokenCachingStrategy:Xamarin.FacebookBinding.TestSession/TestTokenCachingStrategy",
					"com/facebook/TokenCachingStrategy:Xamarin.FacebookBinding.TokenCachingStrategy",
					"com/facebook/UiLifecycleHelper:Xamarin.FacebookBinding.UiLifecycleHelper",
					"com/facebook/UiLifecycleHelper$ActiveSessionBroadcastReceiver:Xamarin.FacebookBinding.UiLifecycleHelper/ActiveSessionBroadcastReceiver",
				};
			}

			return Lookup (package_com_facebook_mappings, klass);
		}

		static string[] package_com_facebook_android_mappings;
		static Type lookup_com_facebook_android_package (string klass)
		{
			if (package_com_facebook_android_mappings == null) {
				package_com_facebook_android_mappings = new string[]{
					"com/facebook/android/AsyncFacebookRunner:Xamarin.FacebookBinding.XAndroid.AsyncFacebookRunner",
					"com/facebook/android/DialogError:Xamarin.FacebookBinding.XAndroid.DialogError",
					"com/facebook/android/Facebook:Xamarin.FacebookBinding.XAndroid.Facebook",
					"com/facebook/android/Facebook$SetterTokenCachingStrategy:Xamarin.FacebookBinding.XAndroid.Facebook/SetterTokenCachingStrategy",
					"com/facebook/android/Facebook$TokenRefreshConnectionHandler:Xamarin.FacebookBinding.XAndroid.Facebook/TokenRefreshConnectionHandler",
					"com/facebook/android/Facebook$TokenRefreshServiceConnection:Xamarin.FacebookBinding.XAndroid.Facebook/TokenRefreshServiceConnection",
					"com/facebook/android/FacebookError:Xamarin.FacebookBinding.XAndroid.FacebookError",
					"com/facebook/android/FbDialog:Xamarin.FacebookBinding.XAndroid.FbDialog",
					"com/facebook/android/Util:Xamarin.FacebookBinding.XAndroid.Util",
				};
			}

			return Lookup (package_com_facebook_android_mappings, klass);
		}

		static string[] package_com_facebook_internal_mappings;
		static Type lookup_com_facebook_internal_package (string klass)
		{
			if (package_com_facebook_internal_mappings == null) {
				package_com_facebook_internal_mappings = new string[]{
					"com/facebook/internal/CacheableRequestBatch:Xamarin.FacebookBinding.Internal.CacheableRequestBatch",
					"com/facebook/internal/FileLruCache:Xamarin.FacebookBinding.Internal.FileLruCache",
					"com/facebook/internal/FileLruCache$BufferFile:Xamarin.FacebookBinding.Internal.FileLruCache/BufferFile",
					"com/facebook/internal/FileLruCache$CloseCallbackOutputStream:Xamarin.FacebookBinding.Internal.FileLruCache/CloseCallbackOutputStream",
					"com/facebook/internal/FileLruCache$CopyingInputStream:Xamarin.FacebookBinding.Internal.FileLruCache/CopyingInputStream",
					"com/facebook/internal/FileLruCache$Limits:Xamarin.FacebookBinding.Internal.FileLruCache/Limits",
					"com/facebook/internal/FileLruCache$ModifiedFile:Xamarin.FacebookBinding.Internal.FileLruCache/ModifiedFile",
					"com/facebook/internal/FileLruCache$StreamHeader:Xamarin.FacebookBinding.Internal.FileLruCache/StreamHeader",
					"com/facebook/internal/Logger:Xamarin.FacebookBinding.Internal.Logger",
					"com/facebook/internal/ServerProtocol:Xamarin.FacebookBinding.Internal.ServerProtocol",
					"com/facebook/internal/SessionAuthorizationType:Xamarin.FacebookBinding.Internal.SessionAuthorizationType",
					"com/facebook/internal/SessionTracker:Xamarin.FacebookBinding.Internal.SessionTracker",
					"com/facebook/internal/SessionTracker$ActiveSessionBroadcastReceiver:Xamarin.FacebookBinding.Internal.SessionTracker/ActiveSessionBroadcastReceiver",
					"com/facebook/internal/SessionTracker$CallbackWrapper:Xamarin.FacebookBinding.Internal.SessionTracker/CallbackWrapper",
					"com/facebook/internal/Utility:Xamarin.FacebookBinding.Internal.Utility",
					"com/facebook/internal/Validate:Xamarin.FacebookBinding.Internal.Validate",
				};
			}

			return Lookup (package_com_facebook_internal_mappings, klass);
		}

		static string[] package_com_facebook_model_mappings;
		static Type lookup_com_facebook_model_package (string klass)
		{
			if (package_com_facebook_model_mappings == null) {
				package_com_facebook_model_mappings = new string[]{
					"com/facebook/model/GraphObject$Factory:Xamarin.FacebookBinding.Model.GraphObjectFactory",
					"com/facebook/model/GraphObject$Factory$GraphObjectListImpl:Xamarin.FacebookBinding.Model.GraphObjectFactory/GraphObjectListImpl",
					"com/facebook/model/GraphObject$Factory$GraphObjectProxy:Xamarin.FacebookBinding.Model.GraphObjectFactory/GraphObjectProxy",
					"com/facebook/model/GraphObject$Factory$ProxyBase:Xamarin.FacebookBinding.Model.GraphObjectFactory/ProxyBase",
				};
			}

			return Lookup (package_com_facebook_model_mappings, klass);
		}

		static string[] package_com_facebook_widget_mappings;
		static Type lookup_com_facebook_widget_package (string klass)
		{
			if (package_com_facebook_widget_mappings == null) {
				package_com_facebook_widget_mappings = new string[]{
					"com/facebook/widget/FacebookFragment:Xamarin.FacebookBinding.Widget.FacebookFragment",
					"com/facebook/widget/FacebookFragment$DefaultSessionStatusCallback:Xamarin.FacebookBinding.Widget.FacebookFragment/DefaultSessionStatusCallback",
					"com/facebook/widget/FriendPickerFragment:Xamarin.FacebookBinding.Widget.FriendPickerFragment",
					"com/facebook/widget/FriendPickerFragment$ImmediateLoadingStrategy:Xamarin.FacebookBinding.Widget.FriendPickerFragment/ImmediateLoadingStrategy",
					"com/facebook/widget/LoginButton:Xamarin.FacebookBinding.Widget.LoginButton",
					"com/facebook/widget/LoginButton$LoginButtonCallback:Xamarin.FacebookBinding.Widget.LoginButton/LoginButtonCallback",
					"com/facebook/widget/LoginButton$LoginButtonProperties:Xamarin.FacebookBinding.Widget.LoginButton/LoginButtonProperties",
					"com/facebook/widget/LoginButton$LoginClickListener:Xamarin.FacebookBinding.Widget.LoginButton/LoginClickListener",
					"com/facebook/widget/PickerFragment:Xamarin.FacebookBinding.Widget.PickerFragment",
					"com/facebook/widget/PickerFragment$LoadingStrategy:Xamarin.FacebookBinding.Widget.PickerFragment/LoadingStrategy",
					"com/facebook/widget/PickerFragment$MultiSelectionStrategy:Xamarin.FacebookBinding.Widget.PickerFragment/MultiSelectionStrategy",
					"com/facebook/widget/PickerFragment$PickerFragmentAdapter:Xamarin.FacebookBinding.Widget.PickerFragment/PickerFragmentAdapter",
					"com/facebook/widget/PickerFragment$SelectionStrategy:Xamarin.FacebookBinding.Widget.PickerFragment/SelectionStrategy",
					"com/facebook/widget/PickerFragment$SingleSelectionStrategy:Xamarin.FacebookBinding.Widget.PickerFragment/SingleSelectionStrategy",
					"com/facebook/widget/PlacePickerFragment:Xamarin.FacebookBinding.Widget.PlacePickerFragment",
					"com/facebook/widget/PlacePickerFragment$AsNeededLoadingStrategy:Xamarin.FacebookBinding.Widget.PlacePickerFragment/AsNeededLoadingStrategy",
					"com/facebook/widget/PlacePickerFragment$SearchTextWatcher:Xamarin.FacebookBinding.Widget.PlacePickerFragment/SearchTextWatcher",
					"com/facebook/widget/ProfilePictureView:Xamarin.FacebookBinding.Widget.ProfilePictureView",
					"com/facebook/widget/UserSettingsFragment:Xamarin.FacebookBinding.Widget.UserSettingsFragment",
					"com/facebook/widget/WebDialog:Xamarin.FacebookBinding.Widget.WebDialog",
					"com/facebook/widget/WebDialog$Builder:Xamarin.FacebookBinding.Widget.WebDialog/Builder",
					"com/facebook/widget/WebDialog$BuilderBase:Xamarin.FacebookBinding.Widget.WebDialog/BuilderBase",
					"com/facebook/widget/WebDialog$DialogWebViewClient:Xamarin.FacebookBinding.Widget.WebDialog/DialogWebViewClient",
					"com/facebook/widget/WebDialog$FeedDialogBuilder:Xamarin.FacebookBinding.Widget.WebDialog/FeedDialogBuilder",
					"com/facebook/widget/WebDialog$RequestsDialogBuilder:Xamarin.FacebookBinding.Widget.WebDialog/RequestsDialogBuilder",
				};
			}

			return Lookup (package_com_facebook_widget_mappings, klass);
		}
	}
}
