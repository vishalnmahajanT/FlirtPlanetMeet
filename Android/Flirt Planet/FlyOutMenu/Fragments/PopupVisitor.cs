
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
using Android.Graphics;
using UrlImageViewHelper;

namespace flirtplanet
{
	public class PopupVisitor : Fragment
	{

		//public override Dialog OnCreateDialog(Bundle savedInstanceState)
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (this.Activity);

			ad = builder.Create ();
			var customView = this.Activity.LayoutInflater.Inflate(Resource.Layout.Popup_visitor, null);


			// Create your fragment here  var contactsAdapter = new ContactsAdapter (this);  
			var visitorAdapter = new visitorAdapter (this.Activity);       
			var visitorListView = customView.FindViewById<ListView> (Resource.Id.lv_visitorListView);      
			visitorListView.Adapter = visitorAdapter;

			BusinessBase.DeleteNotifications (MainUser.AppUser.UniqUser, "VISIT");
			//TODO FlirtPlanetActivity.FlyoutNav.updateNotificationCounters();

			builder.SetView(customView);

			//ad = builder.Create ();
			ad.Show ();

			//return ad;
			return customView;
		}
	}
	public class visitorAdapter : BaseAdapter
	{
		static List<Visitor> 	mVisitors = new List<Visitor>();
		static List<Bitmap> mvisitorImages = new List<Bitmap> ();     
		/*void FillVisitor ()
		{
			BusinessBase.GetVisitors(MainUser.AppUser.UniqUser, mVisitors);

			if (mVisitors.Count > 0)
			{
				//	new VisitorsListPopup(parentVC, mVisitors);
			}
			else
			{
				Popup noVisitors = new Popup(parentVC.View, iPad.kPopupSize.Message, "No Visitors");
				noVisitors.Message = "You have not had any visitors yet.";
				noVisitors.AddCloseButton();
				noVisitors.AddSubmitButton(null, "OK");
			}

		}*/

		Activity _activity;

		public visitorAdapter(Activity activity){
			_activity = activity;

			FillVisitor ();
		}
		public override int Count {
			get {
				return mVisitors.Count;
			}
		}

		public override Java.Lang.Object GetItem (int position)
		{
			return mVisitors [position].UniqUserVisitor;
		}

		public override long GetItemId (int position)
		{
			return 0;
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			View view = convertView;

			if (view == null) {
				view = _activity.LayoutInflater.Inflate (Resource.Layout.single_row_visitor, parent, false);
				PopupHolder popupHolder = new PopupHolder ();
				popupHolder.visitorName = view.FindViewById<TextView> (Resource.Id.tv_visitorName);
				popupHolder.whenVisited = view.FindViewById<TextView> (Resource.Id.tv_timeStamp);
				popupHolder.visitorImage = view.FindViewById<ImageView> (Resource.Id.im_visitorImage);
				view.Tag = popupHolder;
			}

			PopupHolder holder =  (PopupHolder)view.Tag;
			holder.visitorName.Text = mVisitors [position].UserName;
			holder.whenVisited.Text =  GRTools.Text.GetSentRequestTimestamp (mVisitors [position].WhenVisited);
			holder.visitorImage.SetUrlDrawable((Core.Constants.kBaseURL.Avatar + mVisitors[position].HashedName) ,Resource.Drawable.DD_DefaultImage_loading,true,Core.Constants.kCircularImageSize.freshFaces);

			return view;
		}

		async void FillVisitor()
		{
			BusinessBase.GetVisitors(MainUser.AppUser.UniqUser, mVisitors);
			foreach(Visitor vs in mVisitors)
			{
				var data = await FragmentHome.GetImageBytes (Core.Constants.kBaseURL.Avatar + vs.HashedName);
				//image = await BitmapFactory.DecodeByteArrayAsync (data, 0, data.Length);
				mvisitorImages.Add (await BitmapFactory.DecodeByteArrayAsync (data, 0, data.Length));
			}
		}

		class PopupHolder : Java.Lang.Object
		{
			public TextView visitorName{ get; set; }
			public TextView whenVisited{ get; set; }
			public ImageView visitorImage{ get; set; }
		}
	}
}

