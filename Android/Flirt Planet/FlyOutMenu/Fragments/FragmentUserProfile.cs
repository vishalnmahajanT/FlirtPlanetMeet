
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
using Android.Graphics;
using UrlImageViewHelper;

namespace flirtplanet
{
	public class FragmentUserProfile : Fragment//,RatingBar.IOnRatingBarChangeListener
	{
		RatingBar ratingBar;
		ImageView connectUser;
		TextView connectionCostText;
		ImageView icnDrop;
		ImageView watchUser;
		TextView positivePercent;

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate(Resource.Layout.fragment_userProfile, container, false);
			view.SetLayerType (LayerType.Software, null);

			watchUser = view.FindViewById<ImageView> (Resource.Id.im_watch);
			connectUser =  view.FindViewById<ImageView> (Resource.Id.im_connect);
			var review = view.FindViewById <ImageView> (Resource.Id.im_review);
			connectionCostText = view.FindViewById<TextView> (Resource.Id.tv_connectionCost);
			icnDrop = view.FindViewById<ImageView> (Resource.Id.im_icnDrop);

			if (ProfileData.lastOtherUser != null) 
			{
				ProfileData.initializeUserData (MainUser.AppUser.UniqUser, ProfileData.lastOtherUser.UniqUser);
				//ProfileData.lastOtherUser = null;
			}

			if (ProfileData.mUser.ConnectionStatus.Equals ("C"))
			{
				watchUser.SetImageResource (Resource.Drawable.DD_profile_icn_matching_sauce_mobile);
				var matchingPercent = view.FindViewById<TextView> (Resource.Id.tv_matchingPercent);
				matchingPercent.Visibility = ViewStates.Visible;
				matchingPercent.Text = (ProfileData.mUser.OverallCompat.ToString() + "%");

				connectUser.SetImageResource (Resource.Drawable.DD_FlirtMail_icn_send_message);
				connectionCostText.Visibility = ViewStates.Invisible;
				icnDrop.Visibility = ViewStates.Invisible;

				watchUser.Click += (sender, e) => 
				{
					Fragment currentFragment = new FragmentUserSauce ();
					FragmentTransaction ft = FragmentManager.BeginTransaction ();
					ft.Replace (Resource.Id.content_frame, currentFragment)
						.AddToBackStack (null)
						.Commit ();

				};

				connectUser.Click += (sender, e) => 
				{
					FragmentCompose.navigateThrough = true;
					//FragmentMail.partnerID = connectUser.
					Fragment currentFragment = new FragmentMail ();
					FragmentTransaction ft = FragmentManager.BeginTransaction ();
					ft.Replace (Resource.Id.content_frame, currentFragment)
						.AddToBackStack (null)
						.Commit ();
				};
			} 
			else
			{
				connectionCostText.Text = ProfileData.mUser.ConnectionCost.ToString ();
				connectUser.Click += (sender, e) => 
				{
					if (ProfileData.mUser.ConnectionStatus.Equals ("P") || ProfileData.mUser.ConnectionStatus.Equals ("S")) 
					{//connection is Pending  or Sent
						return;
					}
					connectionCostText.Text = ProfileData.mUser.ConnectionCost.ToString ();
					if(MainUser.AppUser.FlirtJuice >= ProfileData.mUser.ConnectionCost)
					{
						getConnectPopup(Resource.Layout.AD_AttemptConnection);
					}
					else
						getConnectPopup(Resource.Layout.AD_LowFlirtJuice);
				};

				if (ProfileData.mUser.ConnectionStatus.Equals ("P") || ProfileData.mUser.ConnectionStatus.Equals ("S")) 
				{//connection is Pending  or Sent
					connectUser.SetImageResource (Resource.Drawable.DD_profile_icn_connect_mobile_disabled);
					connectionCostText.Visibility = ViewStates.Gone;
					icnDrop.Visibility = ViewStates.Gone;
				}
				else 
				{
					connectUser.SetImageResource (Resource.Drawable.DD_profile_icn_connect_mobile);
					connectionCostText.Visibility = ViewStates.Visible;
					icnDrop.Visibility = ViewStates.Visible;
				}

				watchUser.Click += (sender, e) => 
				{
					if (ProfileData.mUser.Watched != "1")
					{
						string result = null;
						do{result = ProfileBus.AddToWatchlist(MainUser.AppUser.UniqUser, ProfileData.mUser);} while(result==null);
						watchUser.SetImageResource (Resource.Drawable.DD_Con_icn_watchlist);

					}
				};

				if (ProfileData.mUser.Watched == "1" || ProfileData.mUser.ConnectionStatus.Equals ("P") || ProfileData.mUser.ConnectionStatus.Equals ("S")) //indicates that user is already watched
					watchUser.SetImageResource (Resource.Drawable.DD_Con_icn_watchlist);
				else 
					watchUser.SetImageResource (Resource.Drawable.DD_Con_icn_add_to_watchlist);
			}

			positivePercent = view.FindViewById<TextView> (Resource.Id.tv_positivePercent);
			int percent = 0;
			percent = (ProfileData.mUser.PositiveReviewPercent <= 0 ? 0 : ProfileData.mUser.PositiveReviewPercent);
			positivePercent.Text = (percent.ToString() + "%");
			review.Click += (sender, e) => {
				switch (ProfileData.mUser.CanReview) {
				case 0:	getReviewPopup (Resource.Layout.fragment_review, 0);break;
				case 1: getReviewPopup (Resource.Layout.AD_Review, 0);break;
				case 2: getReviewPopup(Resource.Layout.fragment_review, 1);
						break;
				}
			};

			var connectionCount = view.FindViewById<TextView> (Resource.Id.tv_connectionCount);
			connectionCount.Text = ProfileData.mUser.NumberOfConnections.ToString ();
		
			fillProfileDataFields (view);
			var gridview = view.FindViewById<flirtplanet.DetailsGridNoScroll> (Resource.Id.gv_details);
			//Console.WriteLine ("=======Status ====== " + ProfileData.mUser.ConnectionStatus);
			var contactsAdapter = new DetailsAdapter (this,inflater,false);    
			gridview.Adapter = contactsAdapter;
			gridview.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args) {
				if(args.Position ==0)
					getHeigthPopup(args.Position);
				else
				DialogView.OnCreateView(this.Activity,args.Position,false);
			};

			var flagUser = view.FindViewById<ImageView> (Resource.Id.iv_flagUser);
			flagUser.Click += (sender, e) => 
			{
				string header = "REPORT PROFILE";
				string message = "Are you sure you want to report this profile?";
				string buttonText = "report_profile";
				Popup popup = new Popup();
				popup.getpopup(this.Activity,header,message,buttonText);
			};
			
						/*if (ProfileData.mUser.ConnectionStatus.Equals ("P") || ProfileData.mUser.ConnectionStatus.Equals ("S")) 
						{//connection is Pending  or Sent
							connectUser.SetImageResource (Resource.Drawable.DD_profile_icn_connect_mobile_disabled);
							connectionCostText.Visibility = ViewStates.Gone;
							icnDrop.Visibility = ViewStates.Gone;
						} 
						else //show the connection cost
						{
							connectionCostText.Text = ProfileData.mUser.ConnectionCost.ToString ();
						}*/

		
			return view;
		}

		public void getConnectPopup(int resource)
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (this.Activity);
			ad = builder.Create ();

			var customView = this.Activity.LayoutInflater.Inflate(resource, null);

			if (resource == Resource.Layout.AD_AttemptConnection)
			{
				var aMessage = customView.FindViewById<TextView> (Resource.Id.tv_message);
				var bContinue = customView.FindViewById<Button> (Resource.Id.btn_continue);
				var bClose = customView.FindViewById <Button> (Resource.Id.btn_close);
				aMessage.Text = "Attempting a connection to " + ProfileData.mUser.UserName
					+ " will cost " + ProfileData.mUser.ConnectionCost + " Flirt Juice. You have "
					+ MainUser.AppUser.FlirtJuice + " Flirt Juice. Continue?";

				bContinue.Click += (sender, e) => 
				{
					string result = null;
					do {result = ConnectionBus.InsertPendingConnection(ProfileData.mUser, ref MainUser.AppUser, 0, string.Empty );} while (result == null);

					if(result == "1")
					{
						FlirtPlanetActivity.FlyoutNav.AdjustJuice();
						FlirtPlanetActivity.FlyoutNav.refreshJuiceGold();
					}

					watchUser.SetImageResource (Resource.Drawable.DD_Con_icn_watchlist);
					connectUser.SetImageResource (Resource.Drawable.DD_profile_icn_connect_mobile_disabled);
					connectionCostText.Visibility = ViewStates.Gone;
					icnDrop.Visibility = ViewStates.Gone;

					ad.Cancel ();		
				};

				bClose.Click += (sender, e) => {
					ad.Cancel ();
				};
		
			} else if (resource == Resource.Layout.AD_LowFlirtJuice) {
				var lmessage = customView.FindViewById <TextView> (Resource.Id.tv_lowJuice);
				var bRefill = customView.FindViewById <Button> (Resource.Id.btn_Refill);
				var bWatchList = customView.FindViewById <Button> (Resource.Id.btn_AddWatchlist);
				var close = customView.FindViewById <Button> (Resource.Id.btn_close);

				lmessage.Text = "Your Flirt Juice balance is too low to connect to" +
					ProfileData.mUser.UserName + ". Come back tomorrow to see your free balance refilled," +
				" or buy a refull pack now.";

				if (ProfileData.mUser.Watched == "1")
					bWatchList.SetTextColor (Color.ParseColor ("#ff474444"));
				else
					bWatchList.SetTextColor (Color.ParseColor ("#ffffffff"));

				bRefill.SetTextColor (Color.ParseColor ("#ffffffff"));

				bRefill.Click += (sender, e) => {
					FlirtPlanetActivity.FlyoutNav.getBuyPopup (Resource.Id.ll_flirtjuice, 0);
				};

				bWatchList.Click += (sender, e) => {
					if (ProfileData.mUser.Watched == "1") {
						bWatchList.SetTextColor (Color.ParseColor ("#ff474444"));
					} else {

						string result = null;
						do{result = ProfileBus.AddToWatchlist (MainUser.AppUser.UniqUser, ProfileData.mUser);} while(result == null);
						bWatchList.SetTextColor (Color.ParseColor ("#ff474444"));
					}
				};
					
				close.Click += (sender, e) => {
					ad.Cancel ();
				};
			}

			builder.SetView(customView);
			ad = builder.Create ();
			ad.Show ();

		}

		public void getReviewPopup(int resource, int flag)
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (this.Activity);
			ad = builder.Create ();
			var customView = this.Activity.LayoutInflater.Inflate (resource, null);

			if (resource == Resource.Layout.fragment_review) {
				List<Review> _list = null;
				TextView reviewTitle, reviewSubtitle;

				do {_list = ProfileBus.GetOthersReviews (ProfileData.mUser.UniqUser);} while(_list == null);

				reviewTitle = customView.FindViewById <TextView> (Resource.Id.tv_title);
				var close = customView.FindViewById <TextView> (Resource.Id.btn_close);
				reviewSubtitle = customView.FindViewById <TextView> (Resource.Id.tv_subtitle);
				var reviewListView = customView.FindViewById <ListView> (Resource.Id.lv_review);
				var line = customView.FindViewById <View> (Resource.Id.view2);

				reviewTitle.Text = ProfileData.mUser.UserName + " Reviews";

				if(flag == 1)
					reviewSubtitle.Text = "You have already reviewed " + ProfileData.mUser.UserName;
				else
					reviewSubtitle.Text = ProfileData.mUser.UserName + " has to message you more before you can leave a review.";

				if (_list.Count == 0) {
					reviewListView.Visibility = ViewStates.Gone;
					line.Visibility = ViewStates.Gone;
				} else {
					reviewListView.Visibility = ViewStates.Visible;
					line.Visibility = ViewStates.Visible;
					var reviewAdapter = new ReviewAdapter (this.Activity, _list);
					reviewListView.Adapter = reviewAdapter;
				}

				close.Click += (sender, e) => {
					ad.Cancel ();
				};
			} 
			else if (resource == Resource.Layout.AD_Review) 
			{

				TextView reviewTitle;
				int select = 1;

				reviewTitle = customView.FindViewById <TextView> (Resource.Id.tv_title);
				var close = customView.FindViewById <TextView> (Resource.Id.btn_close);
				var CanReview = customView.FindViewById <LinearLayout> (Resource.Id.ll_canReview);
				var WriteReview = customView.FindViewById <LinearLayout> (Resource.Id.ll_writeReview);
				var review = customView.FindViewById <Button> (Resource.Id.btn_review);
				var submit = customView.FindViewById <Button> (Resource.Id.btn_submit);
				var reviewMessage = customView.FindViewById <TextView> (Resource.Id.ed_writeReview);
				var iv_WriteReview = customView.FindViewById <ImageView> (Resource.Id.iv_writeReview);
				reviewTitle.Text = "Review " + ProfileData.mUser.UserName;

				var canReviewMessage = customView.FindViewById<TextView> (Resource.Id.tv_canReview);
				canReviewMessage.Text =  "Review " + ProfileData.mUser.UserName + "?";

				CanReview.Visibility = ViewStates.Visible;
				WriteReview.Visibility = ViewStates.Gone;




				review.Click += (sender, e) => 
				{
					CanReview.Visibility = ViewStates.Gone;
					WriteReview.Visibility = ViewStates.Visible;
				};

				iv_WriteReview.Click += (sender, e) => 
				{
					if(select ==1)
					{
						iv_WriteReview.SetImageResource(Resource.Drawable.DD_Header_icn_tickbox_empty);
						select = 0;
					}
					else
					{
						iv_WriteReview.SetImageResource(Resource.Drawable.DD_Header_icn_tickbox);
						select = 1;
					}
				};

				submit.Click += (sender, e) => 
				{
					ad.Cancel();

					string result = null;
					do{result = ProfileBus.ReviewUser(MainUser.AppUser.UniqUser, ProfileData.mUser.UniqUser, reviewMessage.Text, select);} while (result == null);

					//updating the % as soon as submit is done
					ProfileData.initializeUserData (MainUser.AppUser.UniqUser,ProfileData.mUser.UniqUser);
					int percent = 0;
					percent = (ProfileData.mUser.PositiveReviewPercent <= 0 ? 0 : ProfileData.mUser.PositiveReviewPercent);
					positivePercent.Text = (percent.ToString() + "%");
				};

				close.Click += (sender, e) => {
					ad.Cancel ();
				};
			}

			builder.SetView(customView);
			ad = builder.Create ();
			ad.Show ();
		}

		public void getHeigthPopup(int resource)
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (this.Activity);

			ad = builder.Create ();

			//tring returnText;
			int[] height = ProfileData.mUser.GetImperialHeight();

			int inches = height[0] * 12 + height[1];

			var customView = this.Activity.LayoutInflater.Inflate(Resource.Layout.getHeightPopup, null);
			var QueText =  customView.FindViewById<TextView> (Resource.Id.tv_Height);
			var Anstext = customView.FindViewById<TextView> (Resource.Id.tv_getHeight);

			Anstext.Text = height[0].ToString() + "' " + height[1].ToString() + "\"";
			if(Anstext.Text == "0' 0\"")
				Anstext.Text="---";
			var btn = customView.FindViewById<Button> (Resource.Id.btn_update);
			builder.SetView(customView);

			btn.Click += (object sender, EventArgs e) => {
				ad.Dismiss();
			};

			ad = builder.Create ();
			ad.Show ();
		}

		public FragmentUserProfile(int id)
		{
			ProfileData.initializeUserData (MainUser.AppUser.UniqUser,id);
			ProfileData._BuildPhotos (ProfileData.mUser/*ProfileBus.GetOthersProfile(MainUser.AppUser.UniqUser,id)*/);

			if (ProfileData.mUser.ConnectionStatus.Equals ("C")) 
			{
				FragmentMail.partnerID = id;
			}
		}

		List<ImageView> gv_Gallery;

		private void fillProfileDataFields(View view)
		{
			var name = view.FindViewById <TextView> (Resource.Id.tv_name);
			var asl = view.FindViewById <TextView> (Resource.Id.tv_asl);
			var aboutMe = view.FindViewById<TextView> (Resource.Id.tv_aboutme);
			var talents = view.FindViewById<TextView> (Resource.Id.tv_talent);
			var lookingFor = view.FindViewById<TextView> (Resource.Id.tv_lookingfor);
			var connectToMe = view.FindViewById<TextView> (Resource.Id.tv_connectme);
			var goals = view.FindViewById<TextView> (Resource.Id.tv_goals);
			var mattersToMe = view.FindViewById<TextView> (Resource.Id.tv_mattersme);
			var interests = view.FindViewById<TextView> (Resource.Id.tv_interests);
			var displayPic = view.FindViewById<ImageView> (Resource.Id.iv_profilePic);
			var coverPhoto = view.FindViewById<ImageView> (Resource.Id.iv_coverPhoto);
			ratingBar = view.FindViewById<RatingBar> (Resource.Id.rb_rating);

			name.Text = ProfileData.userName;
			asl.Text = (ProfileData.age.ToString () +"."+ProfileData.sex+"."+ProfileData.orientation+"."+ProfileData.city+","+ ProfileData.country);
			aboutMe.Text = ProfileData.aboutMe;
			talents.Text = ProfileData.talents;
			lookingFor.Text = ProfileData.lookingFor;
			connectToMe.Text = ProfileData.connectToMe;
			goals.Text = ProfileData.goalsInLife;
			mattersToMe.Text = ProfileData.mattersToMe;
			interests.Text = ProfileData.interests;
			displayPic.SetUrlDrawable(Core.Constants.kBaseURL.Avatar + ProfileData.displayPic ,Resource.Drawable.DD_DefaultImage_loading,true,Core.Constants.kCircularImageSize.userGalleryImage);
			coverPhoto.SetUrlDrawable(Core.Constants.kBaseURL.CoverPhoto + ProfileData.coverPhoto ,Resource.Drawable.default_cover,false,Core.Constants.kCircularImageSize.freshFaces);
			ratingBar.Rating = ProfileData.rating;

			gv_Gallery = new List<ImageView> ();

			gv_Gallery.Add(view.FindViewById<ImageView> (Resource.Id.im_glImage1));
			gv_Gallery.Add(view.FindViewById<ImageView> (Resource.Id.im_glImage2));
			gv_Gallery.Add(view.FindViewById<ImageView> (Resource.Id.im_glImage3));
			gv_Gallery.Add(view.FindViewById<ImageView> (Resource.Id.im_glImage4));
			gv_Gallery.Add(view.FindViewById<ImageView> (Resource.Id.im_glImage5));


			List<Photo> Photos = ProfileData.mUser.Photos;//ProfileBus.GetOthersProfile (MainUser.AppUser.UniqUser,ProfileData.mUser.UniqUser).Photos;
			for (int i = 0; i < Photos.Count; i++) 
			{
				gv_Gallery [i].SetUrlDrawable (Core.Constants.kBaseURL.Photo + Photos[i].HashedName, Resource.Drawable.DD_DefaultImage_loading,true,Core.Constants.kCircularImageSize.userGalleryImage);
				gv_Gallery[i].Click += (object sender, EventArgs e) => {

					Fragment currentFragment = new FragmentUserGallery ();
					FragmentUserGallery.ownGallery = false;
					FragmentTransaction ft = FragmentManager.BeginTransaction ();
					ft.Replace (Resource.Id.content_frame, currentFragment)
						.AddToBackStack (null)
						.Commit ();

				};
			}
			coverPhoto.SetUrlDrawable(Core.Constants.kBaseURL.CoverPhoto + ProfileData.coverPhoto ,Resource.Drawable.default_cover,false,Core.Constants.kCircularImageSize.freshFaces);

			ratingBar.RatingBarChange += (sender, e) => 
			{
				string rated = null;

				if(ProfileData.mUser.Rating == 0)
				{
					do{rated = ProfileBus.InsertRating(MainUser.AppUser.UniqUser,ProfileData.mUser,ProfileData.mUser.Rating);} while(ratingBar == null);
				}
				else
				{
					do{rated = ProfileBus.UpdateRating(MainUser.AppUser.UniqUser,ProfileData.mUser,ProfileData.mUser.Rating);} while(ratingBar == null);
				}

				ProfileData.rating = (int)ratingBar.Rating;
				ProfileData.mUser.Rating = ProfileData.rating;
			};
		}
			
		public void OnRatingChanged(RatingBar r, float f, bool b)
		{
			r.Rating = f;
		}
	}


	class ReviewAdapter : BaseAdapter
	{
		List<Review> _ReviewList = null;
		Activity context;

		public ReviewAdapter(Activity context, List<Review> _list)
		{
			_ReviewList = new List<Review> ();
			this.context = context;
			_ReviewList = _list;
		}

		public override int Count {
			get {
				return _ReviewList.Count;
			}
		}

		public override Java.Lang.Object GetItem (int position)
		{
			return _ReviewList [position].UniqUser;
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			var view = convertView ?? context.LayoutInflater.Inflate (Resource.Layout.fragment_review_each_item, parent, false);
			var avtarImage = view.FindViewById<ImageView> (Resource.Id.iv_ravatar);
			var name = view.FindViewById <TextView> (Resource.Id.tv_name);
			var date = view.FindViewById <TextView> (Resource.Id.tv_date);
			var review = view.FindViewById <TextView> (Resource.Id.tv_review);

			name.Text = _ReviewList [position].UserName;
			date.Text = GRTools.Text.GetScreenFriendlyTime (_ReviewList [position].WhenReviewed);
			review.Text = _ReviewList [position].ReviewText;

			avtarImage.SetUrlDrawable (Core.Constants.kBaseURL.Photo + _ReviewList[position].HashedName, Resource.Drawable.DD_DefaultImage_loading,true,Core.Constants.kCircularImageSize.userGalleryImage);

			return view;
		}
	}
}

