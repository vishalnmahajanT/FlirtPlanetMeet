
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Core.Business;
using Core.Data;
using Xamarin.FacebookBinding.Widget;
using Xamarin.FacebookBinding.Model;
using Xamarin.FacebookBinding;
using Xamarin.FacebookBinding.XAndroid;
using Core.Constants;
using UrlImageViewHelper;

namespace flirtplanet
{
	public class FragmentEntourage : Fragment, Request.IGraphUserListCallback,WebDialog.IOnCompleteListener
	{
		string friendIDs;
		GridView gridViewEntourage;
		public static EntourageAdapter entourageAdapter;

		public override View  OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate (Resource.Layout.fragment_entourage, container, false);

			FragmentConnectionTab.DrawableStateChanged (FragmentConnectionTab.btnentourage);

			// Create your fragment here
			Request.ExecuteMyFriendsRequestAsync (Session.ActiveSession, this);

			gridViewEntourage = view.FindViewById<GridView> (Resource.Id.gv_entourage);

			var inviteButton = view.FindViewById<Button> (Resource.Id.button_invite);
			inviteButton.Click += (sender, e) => 
			{
				Bundle bundle = new Bundle ();
				bundle.PutString ("app_id", kFacebook.AppID);
				bundle.PutString("message", MainUser.AppUser.UserName + " has invited you to join Flirt Planet Meet");

				var dialog = (new Xamarin.FacebookBinding.Widget.WebDialog.RequestsDialogBuilder (this.Activity, Session.ActiveSession, bundle)).Build();
				dialog.OnCompleteListener = this;
				dialog.Show();
			};

			return view;
		}

		void Xamarin.FacebookBinding.Request.IGraphUserListCallback.OnCompleted(IList<IGraphUser> users, Response response)
		{
			List<Entourage> unconnectedExternalFriends = null;
			List<string> ids = new List<string> ();

			if (users == null)
				return;

			for (int i = 0; i < users.Count; i++) 
			{
				ids.Add(users[i].Id);
			}
			friendIDs = string.Join (",", ids.ToArray ());

			if(unconnectedExternalFriends == null)
				do{unconnectedExternalFriends = ConnectionBus.GetUnconnectedExternalFriends(MainUser.AppUser.UniqUser,friendIDs);} while (unconnectedExternalFriends == null);

			entourageAdapter = new EntourageAdapter (this.Activity, unconnectedExternalFriends);
			gridViewEntourage.Adapter = entourageAdapter;

			var entourageLayout = this.Activity.FindViewById<LinearLayout> (Resource.Id.ll_entourageTop);
			if (gridViewEntourage.Adapter.Count > 0) 
			{
				entourageLayout.Visibility = ViewStates.Gone;
			}
		}


		public void OnComplete(Bundle bundle, FacebookException e)
		{
			if (e == null) 
			{
				StringBuilder IDs = new StringBuilder ();
				string result = null;

				foreach (string key in bundle.KeySet()) 
				{
					if (!key.Contains ("error") && !key.Contains ("request")) 
					{
						//IDs = bundle.GetString (key);
						IDs.Append (bundle.GetString (key)).Append (",");
					}
				}

				if (IDs.Length > 0) 
				{
					IDs.Remove (IDs.Length - 1, 1); // Remove trailing comma
					do {result = ConnectionBus.ReferFacebookFriends (ref MainUser.AppUser, IDs.ToString());} while(result == null);
				}

				if (result.Equals ("0")) 
				{
					string header = "No Reward Given";
					string message = "You have already received a Flirt Juice reward(s) for the friend(s) you selected.";
					string button = "OK";
					Popup popup = new Popup ();
					popup.getpopup (this.Activity, header, message, button);
				} 
				else 
				{
					refreshAdapterView ();
					FlirtPlanetActivity.FlyoutNav.AdjustJuice ();
					FlirtPlanetActivity.FlyoutNav.refreshJuiceGold();
				}
			}
		}

		public void refreshAdapterView()
		{
			FragmentEntourage.entourageAdapter.NotifyDataSetChanged ();
			FragmentConnectionTab.DrawableStateChanged (FragmentConnectionTab.btnentourage);
		}

		public void ShowPickerFragment (PickerFragment fragment)
		{
			/*fragment.OnErrorListener = new ErrorListener ((f, e) => {
				String text = GetString (Resource.String.exception, e.Message);
				Toast toast = Toast.MakeText (this, text, ToastLength.Short);
				toast.Show ();
			});*/

			Android.Support.V4.App.FragmentManager fm = FlirtPlanetActivity.FlyoutNav.fragmentManager;
			fm.BeginTransaction ()
				.Replace (Resource.Id.content_frame, fragment)
				.AddToBackStack (null)
				.Commit ();

			//controlsContainer.Visibility = ViewStates.Gone;

			// We want the fragment fully created so we can use it immediately.
			fm.ExecutePendingTransactions ();

			fragment.LoadData (false);
		}


		public class EntourageAdapter : BaseAdapter
		{
			Activity context;
			List<Entourage> _WatcheList;
			TextView watchName;

			public EntourageAdapter(Activity context, List<Entourage> _list)
			{
				this.context = context;
				_WatcheList = _list;
			}

			public override int Count 
			{
				get 
				{
					return _WatcheList.Count;
				}
			}

			public override Java.Lang.Object GetItem (int position)
			{
				return _WatcheList [position].UniqUser;
			}

			public override long GetItemId (int position)
			{
				return position;
			}

			public override View GetView (int position, View convertView, ViewGroup parent)
			{
				var view = convertView ?? context.LayoutInflater.Inflate (Resource.Layout.fragment_entourage_each_item, parent, false);
				var avatarImage = view.FindViewById <ImageView> (Resource.Id.iv_wavatar);
				watchName = view.FindViewById <TextView> (Resource.Id.tv_watchlist_name);
				var watchConnection = view.FindViewById <ImageView> (Resource.Id.iv_connect);
				//var watchDeny = view.FindViewById <ImageView> (Resource.Id.iv_decline);
				var watchDrop = view.FindViewById <TextView> (Resource.Id.tv_drop);

				watchName.Text = _WatcheList [position].UserName;
				watchDrop.Text = _WatcheList [position].ConnectionCost.ToString ();
				//avatarImage.SetImageDrawable (new CircleDrawable (FragmentHome.getProfileImageFromURL(_WatcheList[position].HashedName),Core.Constants.kCircularImageSize.freshFaces));

				avatarImage.SetUrlDrawable((Core.Constants.kBaseURL.Avatar + _WatcheList[position].HashedName) ,Resource.Drawable.DD_DefaultImage_loading,true,Core.Constants.kCircularImageSize.userGalleryImage);

				return view;
			}
		}
	}
}

