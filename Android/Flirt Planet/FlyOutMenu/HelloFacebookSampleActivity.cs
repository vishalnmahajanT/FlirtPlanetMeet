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
using Android.Content.PM;

//57308094
using Android.Net;

[assembly:Permission (Name = Android.Manifest.Permission.Internet)]
[assembly:Permission (Name = Android.Manifest.Permission.WriteExternalStorage)]
[assembly:MetaData ("com.facebook.sdk.ApplicationId", Value ="@string/app_id")]

namespace flirtplanet
{
	[Activity (Label = "@string/app_name", MainLauncher = false, Icon = "@drawable/icon",WindowSoftInputMode = SoftInput.AdjustResize,Theme = "@android:style/Theme.Holo.Light.DarkActionBar", ScreenOrientation = ScreenOrientation.Portrait)]
	public class HelloFacebookSampleActivity : FragmentActivity, Request.ICallback
	{
		public HelloFacebookSampleActivity ()
		{
			callback = new MyStatusCallback (this);
		}

		private readonly string[] PERMISSIONS = new String [] { "publish_actions,user_friends,public_profile"};//, "email", "user_photos", "user_birthday", "user_relationships", "user_relationship_details" };

		private LoginButton loginButton;
		public ProfilePictureView profilePictureView;
		public IGraphUser iGraphUser;
		public User newUser;
		private TextView loading;

		public static HelloFacebookSampleActivity tempObject{set{mFlirtActivity = value;} get { return mFlirtActivity;}}
		public static HelloFacebookSampleActivity mFlirtActivity;

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
				HelloFacebookSampleActivity.mFlirtActivity.loginButton.Visibility = ViewStates.Gone;
				HelloFacebookSampleActivity.mFlirtActivity.loading.Visibility = ViewStates.Visible;
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
				if (!Popup.isConnectingToInternet (HelloFacebookSampleActivity.tempObject)) 
				{
					Popup.CreateErrorPopup (HelloFacebookSampleActivity.tempObject, Resource.String.error, Resource.String.internetError, "OK",true);
				}
				HelloFacebookSampleActivity.tempObject.iGraphUser = user;
				owner.UpdateUI ();
				// It's possible that we were waiting for this.user to be populated in order to post a
				// status update.
			}
		}

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			uiHelper = new UiLifecycleHelper (this, callback);
			uiHelper.OnCreate (savedInstanceState);

			tempObject = this;

			SetContentView (Resource.Layout.Splash);

			loginButton = (LoginButton)FindViewById (Resource.Id.login_button);
			loading = (TextView)FindViewById (Resource.Id.tv_loading);

			List<string> permissions = new List<string> ();
			permissions.Add ("email");
			permissions.Add ("user_status");
			permissions.Add ("user_photos");
			permissions.Add ("user_birthday");

			loginButton.SetReadPermissions (permissions);

			if (!Popup.isConnectingToInternet (this)) 
			{
				Popup.CreateErrorPopup (this, Resource.String.error, Resource.String.internetError, "OK",true);
			}

			loginButton.UserInfoChangedCallback = new MyUserInfoChangedCallback (this);

		}

		protected override void OnResume ()
		{
			base.OnResume ();
			uiHelper.OnResume ();

			UpdateUI ();
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

		private void UpdateUI ()
		{
			if (!Popup.isConnectingToInternet (this)) 
			{
				Popup.CreateErrorPopup (this, Resource.String.error, Resource.String.internetError, "OK",true);
			}

			Session session = Session.ActiveSession;
			bool enableButtons = (session != null && session.IsOpened);
			if(session.IsClosed)
			{
				this.Finish ();
			}
			else if (enableButtons && iGraphUser != null) 
			{
				HelloFacebookSampleActivity.mFlirtActivity.loginButton.Visibility = ViewStates.Gone;
				HelloFacebookSampleActivity.mFlirtActivity.loading.Visibility = ViewStates.Visible;
				startLoad ();
			}
		}

		public void OnCompleted(Response response) {
			IGraphObject iobject = response.GraphObject;
			Org.Json.JSONObject json = iobject.InnerJSONObject;

			Org.Json.JSONArray albums = json.GetJSONArray ("data");
			for (int i =0; i < albums.Length(); i++) 
			{
				JSONObject album = albums.GetJSONObject(i);
				String album_name = album.GetString("name");
				String album_id = album.GetString("id");
			}

			Console.WriteLine ("");
		}

		private void startLoad()
		{
			AppUser appUser = null;
			Intent intent;
			string birthday = iGraphUser.Birthday;

			Request.NewGraphPathRequest(Session.ActiveSession, "me/albums", this).ExecuteAsync();

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

				//ProfileData.genderFromFB = gender;
				//default the user to Straight & Single - he can change it from the edit basic user details
				newUser.UpdateFlags (gender, "Straight");
				newUser.RelationshipStatus = "single";

				intent = new Intent(this, typeof(FragmentNewUserSignUp));
			} 
			else 
			{
				intent = new Intent(this, typeof(FlirtPlanetActivity));
			}

			System.Threading.ThreadPool.QueueUserWorkItem (delegate {
				this.Finish();
			});
			GC.Collect ();
			StartActivity(intent);
		}

		public override void OnBackPressed ()
		{
			this.Finish ();
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

		class ErrorListener : Java.Lang.Object, PickerFragment.IOnErrorListener
		{
			Action<PickerFragment, FacebookException> action;

			public ErrorListener (Action<PickerFragment, FacebookException> action)
			{
				this.action = action;
			}

			public void OnError (PickerFragment p0, FacebookException p1)
			{
				action (p0, p1);
			}
		}
	}
}
