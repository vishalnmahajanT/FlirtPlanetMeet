
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Data;
using Core.Business;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace flirtplanet
{
	public class FragmentReview : DialogFragment
	{
		List<Review> _list;
		TextView reviewTitle,reviewSubtitle;


		public override View  OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate (Resource.Layout.fragment_review, container, false);

			_list = ProfileBus.GetOthersReviews (ProfileData.mUser.UniqUser);

			reviewTitle = view.FindViewById <TextView> (Resource.Id.tv_title);
			var close = view.FindViewById <TextView> (Resource.Id.btn_close);
			reviewSubtitle = view.FindViewById <TextView> (Resource.Id.tv_subtitle);
			var reviewListView = view.FindViewById <ListView> (Resource.Id.lv_review);

			reviewTitle.Text = ProfileData.mUser.UserName +  " Reviews";
			reviewSubtitle.Text = ProfileData.mUser.UserName + " has to message you more before you can leave a review.";

			if (_list.Count == 0) 
			{
				reviewListView.Visibility = ViewStates.Gone;
			} 
			else 
			{
				reviewListView.Visibility = ViewStates.Visible;

				var reviewAdapter = new ReviewAdapter (this.Activity, _list);
				reviewListView.Adapter = reviewAdapter;
			}

			return view;
		}
	}



}

