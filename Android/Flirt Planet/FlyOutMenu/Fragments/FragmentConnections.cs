using System;

using Core.Data;
using Core.Business;

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
using UrlImageViewHelper;
using Core.Constants;
using Xamarin.FacebookBinding;
using Xamarin.FacebookBinding.Widget;

namespace flirtplanet
{

	public class FragmentConnections : Fragment
	{
	//	List<Connection> _list;


		public override View  OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate (Resource.Layout.fragment_connections, container, false);

			FragmentConnectionTab.DrawableStateChanged (FragmentConnectionTab.btnconn);

			var noConnection = view.FindViewById <TextView> (Resource.Id.tv_conn);
			var connectionGridView = view.FindViewById <flirtplanet.GridViewNoScroll> (Resource.Id.gv_connections);


			if (FragmentConnectionTab.mConnections.Count == 0) 
			{
				noConnection.Visibility = ViewStates.Visible;
				connectionGridView.Visibility = ViewStates.Gone;
			}
			else
			{
				noConnection.Visibility = ViewStates.Gone;
				connectionGridView.Visibility = ViewStates.Visible;
				var connectionAdapter = new ConnectionsAdapter (this.Activity, FragmentConnectionTab.mConnections);
				connectionGridView.Adapter = connectionAdapter;
			}

			connectionGridView.ItemClick += delegate(object sender, AdapterView.ItemClickEventArgs e) {

				var currentFragment = new FragmentUserProfile (FragmentConnectionTab.mConnections[e.Position].UniqUser);  
				FragmentTransaction ft = FragmentManager.BeginTransaction ();
				ft.Replace (Resource.Id.content_frame, currentFragment)
					.AddToBackStack (null)
					.Commit ();

			};

			return view;
		}

		void fillData()
		{

		}

	}

	class ConnectionsAdapter : BaseAdapter
	{
		List<Connection> _ConnectionList = null;
		Activity context;
		//	FragmentManager fm = new FragmentManager();

		public ConnectionsAdapter(Activity context, List<Connection> _list)
		{
			_ConnectionList = new List<Connection> ();
			this.context = context;
			_ConnectionList = _list;
		}

		public override int Count {
			get {
				return _ConnectionList.Count;
			}
		}

		public override Java.Lang.Object GetItem (int position)
		{
			return _ConnectionList [position].UniqUser;
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		public class ViewHolder : Java.Lang.Object
		{
			public ImageView avatarImage{ get; set; }
			public TextView connetionName{ get; set; }
			public TextView compatibility{ get; set; }
			public ImageView secondOpinion{ get; set; }

			public int userID{ get; set;}
			public string userName{ get; set; }
			public string avatar{ get; set; }
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			View view = convertView;
			ViewHolder holder = null;//=  (ViewHolder)view.Tag;

			if (view == null) 
			{
				view = context.LayoutInflater.Inflate (Resource.Layout.fragment_connections_each_item, parent, false);
				ViewHolder viewHolder = new ViewHolder ();
				viewHolder.avatarImage = view.FindViewById <ImageView> (Resource.Id.iv_avatar);
				viewHolder.connetionName = view.FindViewById <TextView> (Resource.Id.tv_conn_name);
				viewHolder.compatibility = view.FindViewById <TextView> (Resource.Id.tv_compatibility);
				viewHolder.secondOpinion = view.FindViewById<ImageView> (Resource.Id.iv_secondOpinion);

				viewHolder.secondOpinion.Click += (sender, e) => 
				{
					SecondOpinion secondopinion;
					do{secondopinion = ConnectionBus.GetSecondOpinion(MainUser.AppUser.UniqUser,holder.userID);} while(secondopinion == null);

					switch(secondopinion.Status)
					{
						case "Prompt":
							getConfirmationPopup(context,holder.userID,holder.userName,holder.avatar);
						break;

						case "Display":
							getResultPopup(context,holder.userID,holder.userName,holder.avatar);
						break;

						case "Results":
							getFinalResultPopup(context,secondopinion,holder.userName,holder.avatar);
						break;
					}
				};
				view.Tag = viewHolder;
			}

			holder =  (ViewHolder)view.Tag;
			holder.connetionName.Text = _ConnectionList [position].UserName;
			holder.compatibility.Text = _ConnectionList [position].OverallCompat.ToString() + "%";
			holder.userID = _ConnectionList [position].UniqUser;
			holder.userName = _ConnectionList [position].UserName;
			holder.avatar = _ConnectionList [position].Avatar;

			if (_ConnectionList [position].SODisplayed != "1") 
			{
				holder.secondOpinion.Visibility = ViewStates.Gone;
			} 
			else 
			{
				holder.secondOpinion.Visibility = ViewStates.Visible;
			}

			holder.avatarImage.SetUrlDrawable((Core.Constants.kBaseURL.Avatar + _ConnectionList[position].Avatar) ,Resource.Drawable.DD_DefaultImage_loading,true,Core.Constants.kCircularImageSize.userGalleryImage);

			return view;
		}

		void getConfirmationPopup(Activity activity,int userID, string userName, string avatar)
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (context);
			ad = builder.Create ();

			var customView = activity.LayoutInflater.Inflate(Resource.Layout.AD_SecondOpinion, null);

			var closeButton = customView.FindViewById<Button> (Resource.Id.btn_close);

			var messageBody = customView.FindViewById <TextView> (Resource.Id.tv_secondOpinionConfirmation);

			var buttonOK = customView.FindViewById <Button> (Resource.Id.btn_askFriends);

			messageBody.Text = kMessage.SecondOpinion_ConfirmText;

			buttonOK.Click += (sender, e) => 
			{
				//ViewHolder holder =  (ViewHolder)customView.Tag;
				getResultPopup(context,userID,userName,avatar);
				ad.Cancel();
			};

			closeButton.Click += (sender, e) => 
			{
				ad.Cancel();
			};

			builder.SetView(customView);

			ad = builder.Create ();
			ad.Show ();
			ad.Window.SetFlags (WindowManagerFlags.BlurBehind, WindowManagerFlags.BlurBehind);

		}

		void getResultPopup(Activity activity, int userID, string userName, string avatar)
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (activity);
			ad = builder.Create ();

			var customView = activity.LayoutInflater.Inflate(Resource.Layout.AD_SecondOpinionResult, null);

			var closeButton = customView.FindViewById<Button> (Resource.Id.btn_close);

			var messageBody = customView.FindViewById <TextView> (Resource.Id.tv_secondOpinionShare);
			messageBody.Text = "Share the link below to get a second opinion \nfrom your friends on " + userName + ".";

			var link = customView.FindViewById<TextView> (Resource.Id.tv_secondOpinionLink);
			string result = ConnectionBus.RequestSecondOpinion (MainUser.AppUser.UniqUser, userID);
			link.Text = result;

			var share = customView.FindViewById <Button> (Resource.Id.btn_share);
			share.Click += (sender, e) => 
			{
				Bundle bundle = new Bundle();
				bundle.PutString("link", result);
				bundle.PutString("picture",(kBaseURL.Avatar + avatar));
				bundle.PutString("name","Help! I Need Your Opinion!");
				bundle.PutString("caption","Lifeline Request");
				bundle.PutString("description","Vote to help me decide whether I should date " + 
					userName + ", or not. Thanks! :)");
				bundle.PutString("actions","{\"name\":\"View App Details\"," + // JSON encoded action
					"\"link\":\"https://itunes.apple.com/app/id737899023\"}");
					
				var dialog = new WebDialog.FeedDialogBuilder(context, Session.ActiveSession, bundle).Build();
				dialog.Window.SetFlags(WindowManagerFlags.Fullscreen, WindowManagerFlags.Fullscreen);

				dialog.Show();
			};

			var copyURL = customView.FindViewById <Button> (Resource.Id.btn_copyURL);
			copyURL.Click += (sender, e) => 
			{
				ClipboardManager clipBoard = (ClipboardManager)context.GetSystemService(Context.ClipboardService);
				clipBoard.Text = result;
			};

			closeButton.Click += (sender, e) => 
			{
				ad.Cancel();
			};

			builder.SetView(customView);

			ad = builder.Create ();
			ad.Show ();
		}

		void getFinalResultPopup(Activity activity, SecondOpinion secondOpinion, string userName, string avatar)
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (activity);
			ad = builder.Create ();

			var customView = activity.LayoutInflater.Inflate(Resource.Layout.AD_SecondOpinionFinalResult, null);

			var closeButton = customView.FindViewById<ImageView> (Resource.Id.iv_close);
			var avatarImage = customView.FindViewById<ImageView> (Resource.Id.iv_avatar);
			avatarImage.SetUrlDrawable((Core.Constants.kBaseURL.Avatar + avatar) ,Resource.Drawable.DD_DefaultImage_loading,true,Core.Constants.kCircularImageSize.freshFaces);

			var name = customView.FindViewById<TextView> (Resource.Id.tv_userName);
			name.Text = userName;

			int totalVotes = secondOpinion.ThumbsUp + secondOpinion.ThumbsLevel + secondOpinion.ThumbsDown;

			var thumbsUp = customView.FindViewById<TextView> (Resource.Id.tv_thumbsUp);
			thumbsUp.Text = calculatePercent(secondOpinion.ThumbsUp,totalVotes).ToString() + "%";

			var neutral = customView.FindViewById<TextView> (Resource.Id.tv_neutral);
			neutral.Text = calculatePercent(secondOpinion.ThumbsLevel,totalVotes).ToString() + "%";

			var thumbsDown = customView.FindViewById<TextView> (Resource.Id.tv_thumbsDown);
			thumbsDown.Text = calculatePercent(secondOpinion.ThumbsDown,totalVotes).ToString() + "%";

			var imageNeutral = customView.FindViewById<ImageView> (Resource.Id.iv_neutral);
			imageNeutral.Rotation = 270f;

			var imageThumbsDown = customView.FindViewById<ImageView> (Resource.Id.iv_thumbsDown);
			imageThumbsDown.Rotation = -180f;

			closeButton.Click += (sender, e) => 
			{
				ad.Cancel();
			};

			builder.SetView(customView);

			ad = builder.Create ();
			ad.Show ();
		}

		float calculatePercent(int part, int whole)
		{
			float result = 0f;

			if (whole > 0) 
				result = (float)Math.Round (((float)part / (float)whole) * 100f);

			return result;
		}
	}
}

