using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Data;
using Core.Business;
using UrlImageViewHelper;
using Core.Constants;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Graphics;


namespace flirtplanet
{
	public class FragmentWatchList : Fragment
	{
		public static WatchlistAdapter watchlistAdapter;

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate (Resource.Layout.fragment_watchlist, container, false);

			var noWatchList = view.FindViewById <TextView> (Resource.Id.tv_watchlist);
			var watchlistGridView = view.FindViewById <flirtplanet.GridViewNoScroll> (Resource.Id.gv_watchlist);

			FragmentConnectionTab.DrawableStateChanged (FragmentConnectionTab.btnwatchlist);

			if (FragmentConnectionTab.mWatched.Count == 0) 
			{
				noWatchList.Visibility = ViewStates.Visible;
				noWatchList.Text = kMessage.Connect_NoWatched;
				watchlistGridView.Visibility = ViewStates.Gone;
			} 
			else 
			{
				noWatchList.Visibility = ViewStates.Gone;
				watchlistGridView.Visibility = ViewStates.Visible;
				watchlistAdapter = new WatchlistAdapter (this.Activity, view, FragmentConnectionTab.mWatched, FragmentConnectionTab.mConnections);
				watchlistGridView.Adapter = watchlistAdapter;
			}

			watchlistGridView.ItemClick += delegate(object sender, AdapterView.ItemClickEventArgs e) {

				var currentFragment = new FragmentUserProfile (FragmentConnectionTab.mWatched[e.Position].UniqUserWatched);  
				FragmentTransaction ft = FragmentManager.BeginTransaction ();
				ft.Replace (Resource.Id.content_frame, currentFragment)
					.AddToBackStack (null)
					.Commit ();

			};

			return view;
		}

	}

	public class WatchlistAdapter : BaseAdapter
	{
		Activity context;
		List<Watched> _WatcheList;
		List<Connection> _ConnectionList;
		View parentView;

		public WatchlistAdapter(Activity context, View v, List<Watched> _list,
			List<Connection> _clist)
		{
			this.context = context;
			parentView = v;
			_WatcheList = _list;
			_ConnectionList = _clist;

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
			View view = convertView;
			if (view == null) {
				view = context.LayoutInflater.Inflate (Resource.Layout.fragment_watchlist_each_item, parent, false);

				ViewHolder viewHolder = new ViewHolder ();
				viewHolder.avatarImage = view.FindViewById <ImageView> (Resource.Id.iv_wavatar);
				viewHolder.watchName = view.FindViewById <TextView> (Resource.Id.tv_watchlist_name);
				viewHolder.watchConnect = view.FindViewById <ImageView> (Resource.Id.iv_connect);
				viewHolder.watchDeny = view.FindViewById <ImageView> (Resource.Id.iv_decline);
				viewHolder.watchDrop = view.FindViewById <TextView> (Resource.Id.tv_drop);

				viewHolder.noWatchList = parentView.FindViewById <TextView> (Resource.Id.tv_watchlist);
				viewHolder.watchlistGridView = parentView.FindViewById <flirtplanet.GridViewNoScroll> (Resource.Id.gv_watchlist);

				viewHolder.watchConnect.Click += (sender, e) => {
					if (_WatcheList.Count == 0) {
						viewHolder.noWatchList.Visibility = ViewStates.Visible;
						viewHolder.watchlistGridView.Visibility = ViewStates.Gone;
					} else
						GetPopup (Resource.Layout.AD_AttemptConnection, position);
				};
			
				viewHolder.watchDeny.Click += (sender, e) => {
					if (_WatcheList.Count == 0) {
						viewHolder.noWatchList.Visibility = ViewStates.Visible;
						viewHolder.watchlistGridView.Visibility = ViewStates.Gone;
					} else
						ConnectionBus.RemoveFromWatchlist (MainUser.AppUser.UniqUser, _WatcheList [position].UniqUserWatched, ref _WatcheList);

				};
				view.Tag = viewHolder;
			}

			ViewHolder holder =  (ViewHolder)view.Tag;
			holder.watchName.Text = _WatcheList [position].UserName;
			holder.watchDrop.Text = _WatcheList [position].ConnectionCost.ToString ();
			holder.avatarImage.SetUrlDrawable(Core.Constants.kBaseURL.Avatar+_WatcheList[position].HashedName,Resource.Drawable.DD_DefaultImage_loading,true,Core.Constants.kCircularImageSize.userGalleryImage);
			return view;
		}

		public void GetPopup (int resource, int position)
		{

			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (context);
			ad = builder.Create ();
		    View customView ;

			if (MainUser.AppUser.FlirtJuice >= _WatcheList [position].ConnectionCost) {

				customView = context.LayoutInflater.Inflate (resource, null);
			
				var aMessage = customView.FindViewById<TextView> (Resource.Id.tv_message);
				var bContinue = customView.FindViewById<Button> (Resource.Id.btn_continue);
				var bClose = customView.FindViewById <Button> (Resource.Id.btn_close);
				aMessage.Text = "Attempting a connection to " + FragmentConnectionTab.mWatched[position].UserName
					+ " will cost " + FragmentConnectionTab.mWatched[position].ConnectionCost.ToString() + " Flirt Juice. You have "
				+ MainUser.AppUser.FlirtJuice + " Flirt Juice. Continue?";

				bContinue.Click += (sender, e) => 
				{
					string result = null;
					do
					{
						User mWatchedUser = ProfileBus.GetOthersProfile (MainUser.AppUser.UniqUser, _WatcheList [position].UniqUserWatched);
						result = ConnectionBus.InsertPendingConnection (mWatchedUser, ref MainUser.AppUser, 0, null);
					} 
					while(result== null);

					if (result == "1") 
					{
						FlirtPlanetActivity.FlyoutNav.AdjustJuice();
						FlirtPlanetActivity.FlyoutNav.refreshJuiceGold();
						refreshAdapterView();
					}
					ad.Cancel ();
				};

				bClose.Click += (sender, e) => 
				{
					ad.Cancel ();
				};
			
			} 
			else {

				customView = context.LayoutInflater.Inflate(Resource.Layout.AD_LowFlirtJuice, null);

				var lmessage = customView.FindViewById <TextView> (Resource.Id.tv_lowJuice);
				var bRefill = customView.FindViewById <Button> (Resource.Id.btn_Refill);
				var bWatchList = customView.FindViewById <Button> (Resource.Id.btn_AddWatchlist);
				var close = customView.FindViewById <Button> (Resource.Id.btn_close);

				lmessage.Text = "Your Flirt Juice balance is too low to connect to" +
					FragmentConnectionTab.mWatched[position].UserName + ". Come back tomorrow to see your free balance refilled," +
					" or buy a refull pack now.";

				if(FragmentConnectionTab.mWatched.Contains(FragmentConnectionTab.mWatched[position]))
					bWatchList.SetTextColor(Color.ParseColor("#ff474444"));
				else
					bWatchList.SetTextColor(Color.ParseColor("#ffffffff"));

				bRefill.SetTextColor(Color.ParseColor("#ffffffff"));

				bRefill.Click += (sender, e) => 
				{
					FlirtPlanetActivity.FlyoutNav.getBuyPopup(Resource.Id.ll_flirtjuice, 0);
				};

				bWatchList.Click += (sender, e) => 
				{
					if(FragmentConnectionTab.mWatched.Contains(FragmentConnectionTab.mWatched[position]))
					{
						bWatchList.SetTextColor(Color.ParseColor("#ff474444"));
					}
					else{

						User user = ProfileBus.GetOthersProfile (MainUser.AppUser.UniqUser,FragmentConnectionTab.mWatched[position].UniqUserWatched);
						string result = ProfileBus.AddToWatchlist(MainUser.AppUser.UniqUser, user);
						bWatchList.SetTextColor(Color.ParseColor("#ff474444"));
					}
				};


				close.Click += (sender, e) => 
				{
					ad.Cancel();
				};


			}


			builder.SetView(customView);
			ad = builder.Create ();
			ad.Show ();

		
		}

		public void refreshAdapterView()
		{
			FragmentWatchList.watchlistAdapter.NotifyDataSetChanged();
			FragmentConnectionTab.DrawableStateChanged (FragmentConnectionTab.btnwatchlist);
		}


	}

   class ViewHolder : Java.Lang.Object
	{
		public ImageView avatarImage{ get; set; }
		public TextView watchName{ get; set; }
		public TextView noWatchList{ get; set; }
		public ImageView watchDeny{ get; set; }
		public TextView watchDrop{ get; set; }

		public ImageView watchConnect;

		public flirtplanet.GridViewNoScroll watchlistGridView;
	}

}

