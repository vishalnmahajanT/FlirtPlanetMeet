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
using Core.Data;
using Core.Business;

namespace flirtplanet
{
	public class FragmentConnectionTab : Fragment
	{
		public static ImageButton btnconn,btnentourage, btnsent, btnreceived, btnwatchlist;
		private static TextView mainHeader;
		public static List<Connection>        mConnections     	= null;  // Startup logic expects these to be null
		public static List<Entourage>			mFBEntourage		= null;  // Startup logic expects these to be null
		public static List<Entourage>			mPlayEntourage		= null;  // Startup logic expects these to be null
		public static List<SentConnection>    mSentRequests    	= null;  // Startup logic expects these to be null
		public static List<PendingConnection> mPendingRequests 	= null;  // Startup logic expects these to be null
		public static List<Watched>			mWatched		 	= null;  // Startup logic expects these to be null
		public int mSelected;
		public static int selectedTab = 0;

		public FragmentConnectionTab(int selectTab=0){
			mSelected = selectTab;
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate (Resource.Layout.fragment_connectiontab, container, false);

			mainHeader = view.FindViewById<TextView> (Resource.Id.tv_conn);
			btnconn = view.FindViewById<ImageButton> (Resource.Id.btn_conn);
			btnsent = view.FindViewById<ImageButton> (Resource.Id.btn_sent);
			btnreceived = view.FindViewById<ImageButton> (Resource.Id.btn_received);
			btnwatchlist = view.FindViewById<ImageButton> (Resource.Id.btn_wathchlist);
			btnentourage = view.FindViewById<ImageButton> (Resource.Id.btn_entourage);
		
			if (mConnections == null)
				do { mConnections = ConnectionBus.GetUserConnections(MainUser.AppUser.UniqUser); } while (mConnections == null);

			BusinessBase.DeleteNotifications (MainUser.AppUser.UniqUser, "CONCT");
			//TODO FlirtPlanetActivity.FlyoutNav.updateNotificationCounters();

			//DrawableStateChanged(btnconn);
			BuildTabs(selectedTab);
			if (btnconn != null)
				btnconn.Click += (sender, e) => {BuildTabs(0);};  
			if (btnentourage != null)
				btnentourage.Click += (sender, e) => {BuildTabs(1);};
			if (btnsent != null)
				btnsent.Click += (sender, e) => {BuildTabs(2);};
			if (btnreceived != null)
				btnreceived.Click += (sender, e) => {BuildTabs(3);};
			if (btnwatchlist != null) 
				btnwatchlist.Click += (sender, e) => {BuildTabs(4);};

			return view;
		}

		public override void OnDestroyView ()
		{
			base.OnDestroyView ();
			GC.Collect ();
		}

		public void BuildTabs(int selected){
			Fragment currentFragment=null;
			switch (selected) {
				case 1:			
					DrawableStateChanged(btnentourage);
					
					currentFragment = new FragmentEntourage ();
				break;
			case 2:
					mSentRequests = null;
					if (mSentRequests == null)
						do { mSentRequests = ConnectionBus.GetUserSentConnections(MainUser.AppUser.UniqUser); } while (mSentRequests == null);
					
					DrawableStateChanged(btnsent);
					currentFragment = new FragmentSent ();	
				break;
			case 3:
					mPendingRequests = null;
					if (mPendingRequests == null)
						do { mPendingRequests = ConnectionBus.GetUserPendingConnections(MainUser.AppUser.UniqUser); } while (mPendingRequests == null);
					
					DrawableStateChanged(btnreceived);
					currentFragment = new FragmentPending ();
						
				break;
			case 4:
					mWatched = null;
					if (mWatched == null)
						do { mWatched = ConnectionBus.GetUserWatchList(MainUser.AppUser.UniqUser); } while (mWatched == null);
					
					DrawableStateChanged(btnwatchlist);
					currentFragment = new FragmentWatchList ();
				break;
			default:
				mConnections = null;
				if (mConnections == null)
					do {mConnections = ConnectionBus.GetUserConnections (MainUser.AppUser.UniqUser);} while (mConnections == null);

				//to display red image on startup
				do { mPendingRequests = ConnectionBus.GetUserPendingConnections(MainUser.AppUser.UniqUser); } while (mPendingRequests == null);
				DrawableStateChanged (btnconn);

				currentFragment = new FragmentConnections ();
				break;
			}

			selectedTab = selected;

			FragmentTransaction ft = FragmentManager.BeginTransaction ();
			ft.Replace (Resource.Id.ll_conn_container, currentFragment)
				.AddToBackStack (null)
				.Commit ();
		}

		public static void DrawableStateChanged(ImageButton ibtn)
		{
			if (ibtn == btnconn) 
			{
				mainHeader.Text = "Your Connections (" + mConnections.Count + ")";
				btnconn.SetBackgroundResource(Resource.Drawable.DD_Global_HorizTabBar);
				btnconn.SetImageResource(Resource.Drawable.DD_Con_icn_connections_hit_resized);
				btnsent.SetImageResource (Resource.Drawable.DD_Con_icn_sent_resized);
				btnsent.SetBackgroundResource (Resource.Color.transparent);

				btnreceived.SetImageResource (Resource.Drawable.DD_Con_icn_received_resized);
				if(mPendingRequests.Count > 0)
					btnreceived.SetColorFilter (Android.Graphics.Color.Red);
				btnreceived.SetBackgroundResource (Resource.Color.transparent);

				btnwatchlist.SetImageResource (Resource.Drawable.DD_Con_icn_watchlist_resized);
				btnwatchlist.SetBackgroundResource (Resource.Color.transparent);
				btnentourage.SetBackgroundResource(Resource.Color.transparent);
				btnentourage.SetImageResource(Resource.Drawable.DD_Con_icn_entourage_resized);
			} 
			else if (ibtn == btnentourage) 
			{
				mainHeader.Text = "Entourage";
				btnconn.SetBackgroundResource(Resource.Color.transparent);
				btnconn.SetImageResource(Resource.Drawable.DD_Con_icn_connections_resized);
				btnentourage.SetBackgroundResource(Resource.Drawable.DD_Global_HorizTabBar);
				btnentourage.SetImageResource(Resource.Drawable.DD_Con_icn_entourage_hit_resized);
				btnsent.SetImageResource (Resource.Drawable.DD_Con_icn_sent_resized);
				btnsent.SetBackgroundResource (Resource.Color.transparent);

				btnreceived.SetImageResource (Resource.Drawable.DD_Con_icn_received_resized);
				if(mPendingRequests.Count > 0)
					btnreceived.SetColorFilter (Android.Graphics.Color.Red);
				btnreceived.SetBackgroundResource (Resource.Color.transparent);

				btnwatchlist.SetImageResource (Resource.Drawable.DD_Con_icn_watchlist_resized);
				btnwatchlist.SetBackgroundResource (Resource.Color.transparent);
			} 
			else if (ibtn == btnsent) 
			{
				mainHeader.Text = "Your Sent Requests (" +mSentRequests.Count+")"; 
				btnconn.SetImageResource (Resource.Drawable.DD_Con_icn_connections_resized);
				btnconn.SetBackgroundResource (Resource.Color.transparent);
				btnsent.SetBackgroundResource(Resource.Drawable.DD_Global_HorizTabBar);
				btnsent.SetImageResource(Resource.Drawable.DD_Con_icn_sent_hit_resized);

				btnreceived.SetImageResource (Resource.Drawable.DD_Con_icn_received_resized);
				if(mPendingRequests.Count > 0)
					btnreceived.SetColorFilter (Android.Graphics.Color.Red);
				btnreceived.SetBackgroundResource (Resource.Color.transparent);

				btnwatchlist.SetImageResource (Resource.Drawable.DD_Con_icn_watchlist_resized);
				btnwatchlist.SetBackgroundResource (Resource.Color.transparent);
				btnentourage.SetBackgroundResource(Resource.Color.transparent);
				btnentourage.SetImageResource(Resource.Drawable.DD_Con_icn_entourage_resized);
			} 
			else if (ibtn == btnreceived) 
			{
				mainHeader.Text = "Pending (" + mPendingRequests.Count.ToString() + ")";
				btnconn.SetImageResource (Resource.Drawable.DD_Con_icn_connections_resized);
				btnconn.SetBackgroundResource (Resource.Color.transparent);
				btnsent.SetImageResource (Resource.Drawable.DD_Con_icn_sent_resized);
				btnsent.SetBackgroundResource (Resource.Color.transparent);

				btnreceived.SetBackgroundResource(Resource.Drawable.DD_Global_HorizTabBar);
				if (mPendingRequests.Count > 0)
					btnreceived.ClearColorFilter ();
				btnreceived.SetImageResource(Resource.Drawable.DD_Con_icn_received_hit_resized);

				btnwatchlist.SetImageResource (Resource.Drawable.DD_Con_icn_watchlist_resized);
				btnwatchlist.SetBackgroundResource (Resource.Color.transparent);
				btnentourage.SetBackgroundResource(Resource.Color.transparent);
				btnentourage.SetImageResource(Resource.Drawable.DD_Con_icn_entourage_resized);
							
			}
			else 
			{
				mainHeader.Text = "Your Watch List (" + mWatched.Count.ToString() + ")";
				btnconn.SetImageResource (Resource.Drawable.DD_Con_icn_connections_resized);
				btnconn.SetBackgroundResource (Resource.Color.transparent);
				btnsent.SetImageResource (Resource.Drawable.DD_Con_icn_sent_resized);
				btnsent.SetBackgroundResource (Resource.Color.transparent);

				btnreceived.SetImageResource (Resource.Drawable.DD_Con_icn_received_resized);
				if(mPendingRequests.Count > 0)
					btnreceived.SetColorFilter (Android.Graphics.Color.Red);
				btnreceived.SetBackgroundResource (Resource.Color.transparent);			

				btnwatchlist.SetBackgroundResource(Resource.Drawable.DD_Global_HorizTabBar);
				btnwatchlist.SetImageResource(Resource.Drawable.DD_Con_icn_watchlist_hit_resized);
				btnentourage.SetBackgroundResource(Resource.Color.transparent);
				btnentourage.SetImageResource(Resource.Drawable.DD_Con_icn_entourage_resized);
			}

		}

	}
}

