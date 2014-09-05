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
using UrlImageViewHelper;

namespace flirtplanet
{
	public class FragmentSent : Fragment
	{
		//List<SentConnection> _list;

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate (Resource.Layout.fragment_sent, container, false);

			var noSentReq = view.FindViewById <TextView> (Resource.Id.tv_sent);
			var sentGridView = view.FindViewById <flirtplanet.GridViewNoScroll> (Resource.Id.gv_sent);

			FragmentConnectionTab.DrawableStateChanged (FragmentConnectionTab.btnsent);
		
			if (FragmentConnectionTab.mSentRequests.Count == 0) {

				noSentReq.Visibility = ViewStates.Visible;
				sentGridView.Visibility = ViewStates.Gone;
			}
			else
			{
				noSentReq.Visibility = ViewStates.Gone;
				sentGridView.Visibility = ViewStates.Visible;
				var sentAdapter = new SentAdapter (this.Activity, FragmentConnectionTab.mSentRequests);
				sentGridView.Adapter = sentAdapter;
			}

			sentGridView.ItemClick += delegate(object sender, AdapterView.ItemClickEventArgs e) {

				var currentFragment = new FragmentUserProfile (FragmentConnectionTab.mSentRequests[e.Position].UniqUser);  
				FragmentTransaction ft = FragmentManager.BeginTransaction ();
				ft.Replace (Resource.Id.content_frame, currentFragment)
					.AddToBackStack (null)
					.Commit ();

			};

			return view;
		}
	}

	class SentAdapter : BaseAdapter
	{
		Activity context;
		List<SentConnection> _SentList;

		public SentAdapter(Activity context, List<SentConnection> _list)
		{
			this.context = context;
			_SentList = _list;
		}

		public override int Count {
			get {
				return _SentList.Count;
			}
		}

		public override Java.Lang.Object GetItem (int position)
		{
			return _SentList [position].UniqUser;
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			var view = convertView ?? context.LayoutInflater.Inflate (Resource.Layout.fragment_sent_each_item, parent, false);

			var sentdate = view.FindViewById <TextView> (Resource.Id.tv_sent_Date);
			var avatarImage = view.FindViewById <ImageView> (Resource.Id.iv_savatar);
			var sentName = view.FindViewById <TextView> (Resource.Id.tv_sent_name);
			sentdate.Text = GRTools.Text.GetSentRequestTimestamp (_SentList [position].RequestSent);
			sentName.Text = _SentList [position].UserName;
			//////////avatarImage.SetImageDrawable (new CircleDrawable (FragmentHome.getProfileImageFromURL(_SentList[position].Avatar),Core.Constants.kCircularImageSize.freshFaces));

			avatarImage.SetUrlDrawable((Core.Constants.kBaseURL.Avatar + _SentList[position].Avatar) ,Resource.Drawable.DD_DefaultImage_loading,true,Core.Constants.kCircularImageSize.userGalleryImage);
			return view;
		}

	}
}

