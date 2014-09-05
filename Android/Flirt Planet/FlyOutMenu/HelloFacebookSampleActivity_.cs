/**
 * Copyright 2010-present Facebook.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *    http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
//
// C# Port by Atsushi Eno
// Copyright (C) 2013 Xamarin Inc.
// The same license as above applies.
//
using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Locations;
using Android.OS;
using Android.Runtime;
//using Android.Support.V4.App;
using Android.Text;
using Android.Views;
using Android.Widget;
using Xamarin.FacebookBinding;
using Xamarin.FacebookBinding.Model;
using Xamarin.FacebookBinding.Widget;
using Core.Data;
using Core.Business;
using System.Json;
using Java.Util;
using Xamarin.FacebookBinding.XAndroid;
using Org.Json;
using Newtonsoft.Json;
using Android.Support.V4.App;

[assembly:Permission (Name = Android.Manifest.Permission.Internet)]
[assembly:Permission (Name = Android.Manifest.Permission.WriteExternalStorage)]
[assembly:MetaData ("com.facebook.sdk.ApplicationId", Value ="@string/app_id")]

namespace flirtplanet
{
	[Activity (Label = "@string/app_name", MainLauncher = false, Icon = "@drawable/icon",WindowSoftInputMode = SoftInput.AdjustResize,Theme = "@android:style/Theme.Holo.Light.DarkActionBar")]
	public class HelloFacebookSampleActivity : FragmentActivity, Request.ICallback
	{
		public HelloFacebookSampleActivity ()
		{
			callback = new MyStatusCallback (this);
		}

		private static readonly string[] PERMISSIONS = new String [] { "publish_actions"};//, "email", "user_photos", "user_birthday", "user_relationships", "user_relationship_details" };
		/*private static readonly Location SEATTLE_LOCATION = new Location ("") {
			Latitude = (47.6097),
			Longitude = (-122.3331)
		};*/
		readonly String PENDING_ACTION_BUNDLE_KEY = "com.facebook.samples.hellofacebook:PendingAction";
		private Button postStatusUpdateButton;
		private Button postPhotoButton;
		private Button pickFriendsButton;
		private Button pickPlaceButton;
		private LoginButton loginButton;
		public ProfilePictureView profilePictureView;
		private TextView greeting;
		private PendingAction pendingAction = PendingAction.NONE;
		private ViewGroup controlsContainer;
		public static IGraphUser iGraphUser;
		public static User newUser;
		//public static int appUserId;// = 350;/////////////////////////CHANGE

		enum PendingAction
		{
			NONE,
			POST_PHOTO,
			POST_STATUS_UPDATE
		}

		private UiLifecycleHelper uiHelper;

		class MyStatusCallback : Java.Lang.Object, Session.IStatusCallback
		{
			HelloFacebookSampleActivity owner;

			public MyStatusCallback (HelloFacebookSampleActivity owner)
			{
				this.owner = owner;
			}

			public void Call (Session session, SessionState state, Java.Lang.Exception exception)
			{
				owner.OnSessionStateChange (session, state, exception);
			}
		}

		private Session.IStatusCallback callback;

		class MyUserInfoChangedCallback : Java.Lang.Object, LoginButton.IUserInfoChangedCallback
		{
			HelloFacebookSampleActivity owner;

			public MyUserInfoChangedCallback (HelloFacebookSampleActivity owner)
			{
				this.owner = owner;
			}

			public void OnUserInfoFetched (IGraphUser user)
			{
				HelloFacebookSampleActivity.iGraphUser = user;
				owner.UpdateUI ();
				// It's possible that we were waiting for this.user to be populated in order to post a
				// status update.
				owner.HandlePendingAction ();
			}
		}

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			uiHelper = new UiLifecycleHelper (this, callback);
			uiHelper.OnCreate (savedInstanceState);

			if (savedInstanceState != null) {
				string name = savedInstanceState.GetString (PENDING_ACTION_BUNDLE_KEY);
				pendingAction = (PendingAction)Enum.Parse (typeof(PendingAction), name);
			}

			SetContentView (Resource.Layout.Splash);

			loginButton = (LoginButton)FindViewById (Resource.Id.login_button);

			List<string> permissions = new List<string> ();
			permissions.Add ("email");
			permissions.Add ("user_status");
			permissions.Add ("user_photos");
			permissions.Add ("user_birthday");

			loginButton.SetReadPermissions (permissions);

			z
			loginButton.UserInfoChangedCallback te {
				OnClickPickFriends ();
			};
			//profilePictureView = FindViewById<ProfilePictureView> (Resource.Id.profilePicture);
			//greeting = FindViewById<TextView> (Resource.Id.greeting);

			/*postStatusUpdateButton = FindViewById<Button> (Resource.Id.postStatusUpdateButton);
			postStatusUpdateButton.Click += delegate {
				OnClickPostStatusUpdate ();
			};

			postPhotoButton = (Button)FindViewById (Resource.Id.postPhotoButton);
			postPhotoButton.Click += delegate {
				OnClickPostPhoto ();
			};

			pickFriendsButton = (Button)FindViewById (Resource.Id.pickFriendsButton);
			pickFriendsButton.Click += delegate {
				OnClickPickFriends ();
			};

			pickPlaceButton = (Button)FindViewById (Resource.Id.pickPlaceButton);
			pickPlaceButton.Click += delegate {
				OnClickPickPlace ();
			};
*/
			controlsContainer = (ViewGroup)FindViewById (Resource.Id.main_ui_container);

			//FragmentManager fm = SupportFragmentManager;
			Android.App.Fragment fragment = FragmentManager.FindFragmentById (Resource.Id.fragment_container);
			if (fragment != null) {
				// If we're being re-created and have a fragment, we need to a) hide the main UI controls and
				// b) hook up its listeners again.
				controlsContainer.Visibility = ViewStates.Gone;
				if (fragment is FriendPickerFragment) {
					//	SetFriendPickerListeners ((FriendPickerFragment)fragment);
				} else if (fragment is PlacePickerFragment) {
					//SetPlacePickerListeners ((PlacePickerFragment)fragment);
				}
			}

			FragmentManager.BackStackChanged += delegate {
				if (FragmentManager.BackStackEntryCount == 0) {
					// We need to re-show our UI.
					controlsContainer.Visibility = ViewStates.Visible;
				}
			};
		}

		protected override void OnResume ()
		{
			base.OnResume ();
			uiHelper.OnResume ();

			UpdateUI ();
		}

		protected override void OnSaveInstanceState (Bundle outState)
		{
			base.OnSaveInstanceState (outState);
			uiHelper.OnSaveInstanceState (outState);

			outState.PutString (PENDING_ACTION_BUNDLE_KEY, pendingAction.ToString ());
		}

		protected override void OnActivityResult (int requestCode, Result resultCode, Intent data)
		{
			base.OnActivityResult (requestCode, resultCode, data);
			uiHelper.OnActivityResult (requestCode, (int)resultCode, data);
		}

		protected override void OnPause ()
		{
			base.OnPause ();
			uiHelper.OnPause ();
		}

		protected override void OnDestroy ()
		{
			base.OnDestroy ();
			uiHelper.OnDestroy ();
		}

		private void OnSessionStateChange (Session session, SessionState state, Exception exception)
		{
			if (pendingAction != PendingAction.NONE &&
				(exception is FacebookOperationCanceledException ||
					exception is FacebookAuthorizationException)) {
				new AlertDialog.Builder (this)
					.SetTitle (Resource.String.cancelled)
					.SetMessage (Resource.String.permission_not_granted)
					.SetPositiveButton (Resource.String.ok, (object sender, DialogClickEventArgs e) => {})
					.Show ();
				pendingAction = PendingAction.NONE;
			} else if (state == SessionState.OpenedTokenUpdated) {
				HandlePendingAction ();
			}
			UpdateUI ();
		}

		private void UpdateUI ()
		{
			Session session = Session.ActiveSession;
			bool enableButtons = (session != null && session.IsOpened);

			if (enableButtons && iGraphUser != null) 
			{
				startLoad ();
			}
		}

		protected static string DecodeString(string json)
		{
			json = json.Replace("\\\\", "\\");
			json = json.Replace("\\\"", "\"");
			json = json.Replace("[\"{", "[{");
			json = json.Replace("}\"]", "}]");
			json = json.Replace("}\",\"{", "},{");
			json = json.Replace("\"{", "{");
			json = json.Replace("}\"", "}");

			return json;
		}

		public void OnCompleted(Response response) {
			// TODO Auto-generated method stub
			/*Console.WriteLine("output \\\\\\\\\\" + response.GraphObject.InnerJSONObject);
			List<FBPhotoAlbum> newAlbum = JsonConvert.DeserializeObject<List<FBPhotoAlbum>>(DecodeString(result));
			Console.WriteLine ("");*/
		}

		private void startLoad()
		{
			AppUser appUser = null;
			Intent intent;
			string birthday = iGraphUser.Birthday;

			Request.ExecuteGraphPathRequestAsync (Session.ActiveSession, "/me/albums", this);
			/*response = facebook.request("me/albums");
			json = Util.parseJson(response);
			albums = json.getJSONArray("data");
			for (int i =0; i < albums.length(); i++) {
				JSONObject album = albums.getJSONObject(i);
				String album_name = album.getString("name");
				String album_id = album.getString("id");
			}*/

			do 
			{
				appUser = BusinessBase.GetUserWithFacebookID (iGraphUser.Id);
			} while(appUser == null);

			MainUser.InitializeUser(appUser);
			if (MainUser.AppUser.UniqUser == -1) 
			{
				newUser = new User ();
				newUser.UniqFacebook = iGraphUser.Id;
				if (birthday != null) 
				{
					string[] birthdayArray = iGraphUser.Birthday.Split ('/');
					newUser.BirthDate = new DateTime(Convert.ToInt32(birthdayArray[2]),
													 Convert.ToInt32(birthdayArray[0]),
													 Convert.ToInt32(birthdayArray[1]));
				}

				MainUser.AppUser.BirthDate = newUser.BirthDate;

				newUser.EmailAddress = iGraphUser.GetProperty ("email").ToString();

				string genderData = iGraphUser.GetProperty ("gender").ToString();
				string gender = (genderData != null) ? genderData : string.Empty;

				//default the user to Straight & Single - he can change it from the edit basic user details
				newUser.UpdateFlags (gender, "Straight");
				newUser.RelationshipStatus = "single";

				intent = new Intent(this, typeof(FragmentNewUserSignUp));
			} 
			else 
			{
				intent = new Intent(this, typeof(FlirtPlanetActivity));
			}
			StartActivity(intent);
		}

		private void HandlePendingAction ()
		{
			PendingAction previouslyPendingAction = pendingAction;
			// These actions may re-set pendingAction if they are still pending, but we assume they
			// will succeed.
			pendingAction = PendingAction.NONE;

			switch (previouslyPendingAction) {
			case PendingAction.POST_PHOTO:
				PostPhoto ();
				break;
			case PendingAction.POST_STATUS_UPDATE:
				PostStatusUpdate ();
				break;
			}
		}

		private void ShowPublishResult (String message, IGraphObject result, FacebookRequestError error)
		{
			String title = null;
			String alertMessage = null;
			if (error == null) {
				title = GetString (Resource.String.success);
				var cls = Java.Lang.Class.ForName ("hellofacebooksample.HelloFacebookSampleAcvitity_GraphObjectWithId");
				var obj = (Java.Lang.Object) result.Cast (cls);
				Java.Lang.Reflect.Method m = obj.Class.GetMethod ("getId");
				String id = (String) m.Invoke (obj);
				alertMessage = GetString (Resource.String.successfully_posted_post, message, id);
			} else {
				title = GetString (Resource.String.error);
				alertMessage = error.ErrorMessage;
			}

			new AlertDialog.Builder (this)
				.SetTitle (title)
				.SetMessage (alertMessage)
				.SetPositiveButton (Resource.String.ok, (object sender, DialogClickEventArgs e) => {})
				.Show ();
		}

		private void OnClickPostStatusUpdate ()
		{
			PerformPublish (PendingAction.POST_STATUS_UPDATE);
		}

		class RequestCallback : Java.Lang.Object, Request.ICallback
		{
			Action<Response> action;

			public RequestCallback (Action<Response> action)
			{
				this.action = action;
			}

			public void OnCompleted (Response response)
			{
				action (response);
			}
		}

		private void PostStatusUpdate ()
		{
			if (iGraphUser != null && HasPublishPermission ()) {
				string message = GetString (Resource.String.status_update, iGraphUser.FirstName, (DateTime.Now.ToString ()));
				Request request = Request.NewStatusUpdateRequest (Session.ActiveSession, message, new RequestCallback (response => ShowPublishResult (message, response.GraphObject, response.Error)));
				request.ExecuteAsync ();
			} else {
				pendingAction = PendingAction.POST_STATUS_UPDATE;
			}
		}

		private void OnClickPostPhoto ()
		{
			PerformPublish (PendingAction.POST_PHOTO);
		}

		private void PostPhoto ()
		{
			if (HasPublishPermission ()) {
				Bitmap image = BitmapFactory.DecodeResource (this.Resources, Resource.Drawable.Icon);
				Request request = Request.NewUploadPhotoRequest (Session.ActiveSession, image, new RequestCallback (response => {
					ShowPublishResult (GetString (Resource.String.photo_post), response.GraphObject, response.Error);
				}));
				request.ExecuteAsync ();
			} else {
				pendingAction = PendingAction.POST_PHOTO;
			}
		}

		class ErrorListener : Java.Lang.Object, PickerFragment.IOnErrorListener
		{
			Action<PickerFragment, FacebookException> action;

			public ErrorListener (Action<PickerFragment, FacebookException> action)
			{
				this.action = action;
			}

			public void OnError (PickerFragment p0, FacebookExcepti/*on p1)
			{
				action (p0, p1);
			}
		}

			private			fragment.OnErrorListener = new ErrorListener ((f, e) => {{
			fragment.OnErrorListener = new ErrorListener ((f, e) => {
				String text = GetString (Resource.String.exception, e.Message);
				Toast toast = Toast.MakeText (this, text, ToastLength.Short);
				toast.Show ();
			});

			//		FragmentManager fm = SupportFragmentManager;
			FragmentManager.BeginTransaction ()
				.Replace (Resource.Id.fragment_container, fragment)
				.AddToBackStack (null)
				.Commit ();

			controlsContainer.Visibility = ViewStates.Gone;

			// We want the fragment fully created so we can use it immediately.
			FragmentManager.Execu*/tePendingTransactions ();

			fragment.LoadData (false);
		}

		private void OnClickPickFriends ()
		{
			FriendPickerFragment fragment = new FriendPicke//rFragment ();

			SetFriendPickerListeners (fragment);

			ShowPickerFragment (fragment);
		}

		private void SetFriendPickerListeners (FriendPickerFragment fragment)
		{
			fragment.DoneButtonClicked += delegate {
				OnFriendPickerDone (fragment);
			};
		}

		private vo//id OnFriendPickerDone (FriendPickerFragment fragment)
		{
				FragmentManager fm = SupportFragmentManager;
			FragmentManager.PopBackStack ();

			String results = "";

			var selection = fragment.Selection;
			if (selection != null && selection.Count > 0) {
				List<String> names = new List<String> ();
				foreach (IGraphUser user in selection) {
					names.Add (user.Name);
				}
				results = string.Join (", ", names.ToArray ());
			} else {
				results = GetString (Resource.String.no_friends_selected);
			}

			ShowAlert (GetString (Resource.String.you_picked), results);
		}

		private void OnPlacePickerDone (PlacePickerFragment fragment)
		{
			//FragmentManager fm = SupportFragmentManager;
			FragmentManager.PopBackStack ();

			String result = "";

			IGraphPlace selection = fragment.Selection;
			if (selection != null) {
				result = selection.Name;
			} else {
				result = GetString (Resource.String.no_place_selected);
			}

			ShowAlert (GetString (Resource.String.you_picked), result);
		}

		private void OnClickPickPlace ()
		{
			PlacePickerFragment fragment = new PlacePickerFragment ();
			//fragment.Location = (SEATTLE_LOCATION);
			fragment.TitleText = (GetString (Resource.String.pick_seattle_place));

			SetPlacePickerListeners (fragment);

			//ShowPickerFragment (fragment);
		}

		private void SetPlacePickerListeners (PlacePickerFragment fragment)
		{
			fragment.DoneButtonClicked += delegate {
				OnPlacePickerDone (fragment);
			};
			fragment.SelectionChanged += delegate {
				if (fragment.Selection != null) {
					OnPlacePickerDone (fragment);
				}
			};
		}

		private void ShowAlert (String title, String message)
		{
			new AlertDialog.Builder (this)
				.SetTitle (title)
				.SetMessage (message)
				.SetPositiveButton (Resource.String.ok, (object sender, DialogClickEventArgs e) => {})
				.Show ();
		}

		private bool HasPublishPermission ()
		{
			Session session = Session.ActiveSession;
			return session != null && session.Permissions.Contains ("publish_actions");
		}

		private void PerformPublish (PendingAction action)
		{
			Session session = Session.ActiveSession;
			if (session != null) {
				pendingAction = action;
				if (HasPublishPermission ()) {
					// We can do the action right away.
					HandlePendingAction ();
				} else {
					// We need to get new permissions, then complete the action when we get called back.
					session.RequestNewPublishPermissions (new Session.NewPermissionsRequest (this, PERMISSIONS));
				}
			}
		}
	}
}
