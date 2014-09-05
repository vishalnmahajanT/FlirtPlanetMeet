
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
using Core.Constants;
using Org.W3c.Dom;
using Android.Graphics;

namespace flirtplanet
{
	public class FragmentMeetSearchResults : Fragment, AbsListView.IOnScrollListener
	{
		static MeetFetcher mCurrentFetcher;
		public static List<Match> mMatches = new List<Match>();
		static bool mIsSearching;
		static bool mFoundAllMatches;
		static int mPages;
		static int mAddMoreMatchesFromIndex = 0;
		static GridView gridViewMeetResults;
		asynchAdapter adapter;

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate(Resource.Layout.fragment_meetSearchResults, container, false);

			gridViewMeetResults = view.FindViewById <GridView> (Resource.Id.gv_meetSearchResults);
		//	gridViewMeetResults.Adapter = new MeetPageImageAdapter (this.Activity);
			adapter = new asynchAdapter(this.Activity);
			gridViewMeetResults.Adapter = adapter;//new asynchAdapter(this.Activity);

			gridViewMeetResults.ItemClick += (sender, e) => 
			{
				int userId = mMatches[e.Position].UniqUser;
				Java.Lang.Object obj= gridViewMeetResults.GetItemAtPosition(e.Position);

				ImageView iv = (ImageView)obj;
				iv.SetColorFilter(Color.Gray);

				FragmentTransaction ft1 = FragmentManager.BeginTransaction ();
				ft1.Replace(Resource.Id.content_frame, new FragmentUserProfile(userId))
					.AddToBackStack(null)
					.Commit();
			};

			//_BuildPages ();
			gridViewMeetResults.SetOnScrollListener (this);

			return view;
		}

		public override void OnDestroyView ()
		{
			base.OnDestroyView ();
			adapter.Dispose ();
			gridViewMeetResults.Dispose ();

			mCurrentFetcher = null;
			GC.Collect (0);
		}

		protected override void JavaFinalize ()
		{
			base.OnDestroyView ();
			adapter.Dispose ();
			gridViewMeetResults.Dispose ();

		}

		public static void LoadResults(MeetFetcher fetcher, bool wantsCoC)
		{
			mIsSearching = true;
			mFoundAllMatches = false;

			mMatches = new List<Match>();
			mCurrentFetcher = fetcher;

			string matchesGrabbed = null;			
			if (wantsCoC) 
			{
				do {matchesGrabbed = MeetBus.GetMatchingCoCUsers (mMatches, mCurrentFetcher, false);} while (matchesGrabbed == null);
				System.Threading.ThreadPool.QueueUserWorkItem (delegate {BoostBus.UseDurationItem (MainUser.AppUser.UniqUser, kFeature.CreamOfTheCrop);});
			} 
			else 
			{
				do {matchesGrabbed = MeetBus.GetMatchingUsers (mMatches, mCurrentFetcher, false);} while (matchesGrabbed == null);
			}
		}

		static void _BuildMatchPages(int startFromIndex)
		{
			mPages = (int) Math.Ceiling(mMatches.Count / 6f);

			// Only show the swipe label if you have more than 1 page
			//mSwipeLabel.Hidden = (mPages == 1);

			//mNoMatchesLabel.Hidden = (mMatches.Count > 0);

			// Handles corner-case of running out of matches with an even 
			// 24 matches found in the final pull
			if (startFromIndex >= mMatches.Count - 1)
			{
				mFoundAllMatches = true;
				mIsSearching = false;
				return;
			}

			/*for (int idx = startFromIndex; idx < mMatches.Count; idx++)
			{
				Match match = mMatches[idx];

				int page = (int) Math.Floor(idx / 6f);
				int column = idx % 2;
				int row = ((int) Math.Floor(idx / 2f) % 3);

				//if (match.FeaturedUser)
				//	profile.SetHighlightColor(Palette.GoldenFeatured);

			}*/

			mAddMoreMatchesFromIndex = mMatches.Count;

			mIsSearching = false; 

			// Marks all matches as found if there's less than 24 matches
			if ((mMatches.Count - startFromIndex) < 24)
				mFoundAllMatches = true;
		}

		static void _BuildPages()
		{
			if (!mIsSearching && !mFoundAllMatches /*&& mCurrentPage == (mPages - 1)*/)
				_GetMoreMatches();
		}

		static void _GetMoreMatches()
		{
			mIsSearching = true;
			string matchesGrabbed = null;
			do { matchesGrabbed = MeetBus.GetMatchingUsers(mMatches, mCurrentFetcher, false); } while (matchesGrabbed == null);
		}

		int TotalItemCount=0;

		public void OnScroll(AbsListView view, int firstVisibleItem, int visibleItemCount, int totalItemCount)
		{
			bool loadMore = firstVisibleItem + visibleItemCount >= TotalItemCount+totalItemCount;	

			if (loadMore) 
			{	
				int firstItem = gridViewMeetResults.FirstVisiblePosition;
				TotalItemCount += 24;
				_GetMoreMatches ();
				gridViewMeetResults.SetSelection (firstItem);
				gridViewMeetResults.DeferNotifyDataSetChanged ();// 5-7
			}
		}

		public void OnScrollStateChanged(AbsListView view, Android.Widget.ScrollState scrollState) 
		{
		}
	}
}

