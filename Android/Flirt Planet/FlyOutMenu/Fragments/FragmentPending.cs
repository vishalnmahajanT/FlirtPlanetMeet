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
using Core.Constants;
using UrlImageViewHelper;

namespace flirtplanet
{
	public class FragmentPending : Fragment
	{
	//	List<PendingConnection> _list ;
		//List<Connection> _clist;
		public static PendingAdapter pendingAdapter;

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate (Resource.Layout.fragment_pending, container, false);

			var noPending = view.FindViewById <TextView> (Resource.Id.tv_pending);
			var pendingGridView = view.FindViewById <flirtplanet.GridViewNoScroll> (Resource.Id.gv_pending);

			FragmentConnectionTab.DrawableStateChanged (FragmentConnectionTab.btnreceived);

			if (FragmentConnectionTab.mPendingRequests.Count == 0) 
			{
				noPending.Visibility = ViewStates.Visible;
				noPending.Text = kMessage.Connect_NoPendingRequests;
				pendingGridView.Visibility = ViewStates.Gone;
			} 
			else 
			{
				noPending.Visibility = ViewStates.Gone;
				pendingGridView.Visibility = ViewStates.Visible;
				pendingAdapter = new PendingAdapter (this.Activity, view, FragmentConnectionTab.mPendingRequests, FragmentConnectionTab.mConnections);
				pendingGridView.Adapter = pendingAdapter;
			}

			pendingGridView.ItemClick += delegate(object sender, AdapterView.ItemClickEventArgs e) {

				var currentFragment = new FragmentUserProfile (FragmentConnectionTab.mPendingRequests[e.Position].UniqUser);  
				FragmentTransaction ft = FragmentManager.BeginTransaction ();
				ft.Replace (Resource.Id.content_frame, currentFragment)
					.AddToBackStack (null)
					.Commit ();

			};

			return view;
		}
	}

	public class PendingAdapter : BaseAdapter
	{
		Activity context;
		List<PendingConnection> _PendingList;
		List<Connection> _ConnectionList;
		View v;
		public PendingAdapter(Activity context,View v,  List<PendingConnection> _list, List<Connection> _clist)
		{
			this.context = context;
			this.v = v;
			_PendingList = _list;
			_ConnectionList = _clist;
		}

		public override int Count {
			get {
				return _PendingList.Count;
			}
		}

		public override Java.Lang.Object GetItem (int position)
		{
			return _PendingList [position].UniqUser;
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		class ViewHolder : Java.Lang.Object
		{
			public ImageView avatarImage{ get; set; }
			public TextView pendingName{ get; set; }
			public TextView noPending{ get; set; }
			public ImageView pendingDeny{ get; set; }
			public ImageView pendingAccept{ get; set; }

			//public ImageView watchConnect;

			public flirtplanet.GridViewNoScroll pendingGridView;
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			View view = convertView;

			if (view == null) 
			{
				view = convertView ?? context.LayoutInflater.Inflate (Resource.Layout.fragment_pending_each_item, parent, false);
				ViewHolder viewHolder = new ViewHolder ();

				viewHolder.avatarImage = view.FindViewById <ImageView> (Resource.Id.iv_pavatar);
				viewHolder.pendingName = view.FindViewById <TextView> (Resource.Id.tv_pending_name);
				viewHolder.pendingAccept = view.FindViewById <ImageView> (Resource.Id.iv_accept);
				viewHolder.pendingDeny = view.FindViewById <ImageView> (Resource.Id.iv_decline);

				viewHolder.noPending = v.FindViewById <TextView> (Resource.Id.tv_pending);
				viewHolder.pendingGridView = v.FindViewById <flirtplanet.GridViewNoScroll> (Resource.Id.gv_pending);

				viewHolder.pendingAccept.Click += (sender, e) => 
				{
					GetPopup(Resource.Layout.AD_Accept,position,viewHolder.pendingName.Text);

					if(_PendingList.Count == 0)
					{
						viewHolder.noPending.Visibility = ViewStates.Visible;
						viewHolder.pendingGridView.Visibility = ViewStates.Gone;
					}
					else
					{
						viewHolder.noPending.Visibility = ViewStates.Gone;
						viewHolder.pendingGridView.Visibility = ViewStates.Visible;
					}
				};

				viewHolder.pendingDeny.Click += (sender, e) => 
				{
					GetPopup(Resource.Layout.AD_Deny,position,viewHolder.pendingName.Text);

					if(_PendingList.Count == 0)
					{
						viewHolder.noPending.Visibility = ViewStates.Visible;
						viewHolder.pendingGridView.Visibility = ViewStates.Gone;
					}
					else
					{
						viewHolder.noPending.Visibility = ViewStates.Gone;
						viewHolder.pendingGridView.Visibility = ViewStates.Visible;
					}
				};

				view.Tag = viewHolder;
			}

			ViewHolder holder =  (ViewHolder)view.Tag;
			holder.pendingName.Text = _PendingList [position].UserName;
			holder.avatarImage.SetUrlDrawable((Core.Constants.kBaseURL.Avatar + _PendingList[position].Avatar) ,Resource.Drawable.DD_DefaultImage_loading,true,Core.Constants.kCircularImageSize.freshFaces);

			return view;
		}


		public void GetPopup(int resource, int position, string pendingName)
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (context);
			ad = builder.Create ();

			var customView = context.LayoutInflater.Inflate(resource, null);

			if (resource == Resource.Layout.AD_Accept) {
				var aMessage = customView.FindViewById<TextView> (Resource.Id.tv_accpet);
				var bAccept = customView.FindViewById<Button> (Resource.Id.btn_accept);
				var bClose = customView.FindViewById <Button> (Resource.Id.btn_close);
					//var dMessage = customView.FindViewById<TextView> (Resource.Id.tv_deny);
				aMessage.Text = "Accept the connection request from " + pendingName + "? You will then be able to send flirt mail to each other!";

				bAccept.Click += (sender, e) => 
				{
					string result = null;
					do{result=ConnectionBus.AcceptConnectionRequest(_ConnectionList, _PendingList, _PendingList[position] );} while (result == null);

					ad.Cancel ();

					if(result == "true")
						GetAcceptedPopup(pendingName);

				};

				bClose.Click += (sender, e) => 
				{
					ad.Cancel();
				};
			} 
			else 
			{
				var denyMessage = customView.FindViewById<TextView> (Resource.Id.tv_deny);
				var bDeny = customView.FindViewById<Button> (Resource.Id.btn_deny);
				var bClose = customView.FindViewById <Button> (Resource.Id.btn_close);
				denyMessage.Text = "Deny the connection request from " + pendingName + "?";

				bDeny.Click += (sender, e) => 
				{
					string result = null;
					do{result = ConnectionBus.DenyConnectionRequest( _PendingList, _PendingList[position] );} while(result == null);

					//TODO if(result == "true")
					//TODO FlirtPlanetActivity.FlyoutNav.updateNotificationCounters();

					refreshAdapterView ();

					ad.Cancel();
				};

				bClose.Click += (sender, e) => 
				{
					ad.Cancel();
				};
			}

			builder.SetView(customView);
			ad = builder.Create ();
			ad.Show ();
		
		}

		public void GetAcceptedPopup(string pendingName)
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (context);
			ad = builder.Create ();

			var customView = context.LayoutInflater.Inflate(Resource.Layout.AD_Accepted, null);

			var acceptedMessage = customView.FindViewById<TextView> (Resource.Id.tv_accepted);
			var bAccepted = customView.FindViewById<Button> (Resource.Id.btn_accepted);
			var bClose = customView.FindViewById <Button> (Resource.Id.btn_close);

			acceptedMessage.Text = "You are now connected with " + pendingName + ". Try sending them a flirt mail!";
			bAccepted.Click += (sender, e) => 
			{
				//TODO FlirtPlanetActivity.FlyoutNav.updateNotificationCounters();
				ad.Cancel ();
			};

			bClose.Click += (sender, e) => 
			{
				ad.Cancel();
			};

			refreshAdapterView ();

			builder.SetView(customView);
			ad = builder.Create ();
			ad.Show ();

		}

		public void refreshAdapterView()
		{
			FragmentPending.pendingAdapter.NotifyDataSetChanged();
			FragmentConnectionTab.DrawableStateChanged (FragmentConnectionTab.btnreceived);
		}
	}
}

