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
using UrlImageViewHelper;

namespace flirtplanet
{
	public class FragmentUserGallery : Fragment
	{
		public static int selectedPhoto = 0;
		public static bool ownGallery = false;
		public static Photo mSelectedPhoto = null;
		public static ImageView imageview;
		public static GridViewNoScroll gridview;
		User user;
		public static bool confirmDelete = false;

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) 
		{
			var view = inflater.Inflate(Resource.Layout.userGallery, container, false);
			view.SetLayerType (LayerType.Software, null);

			imageview = view.FindViewById<ImageView> (Resource.Id.im_userGallery);
			gridview = view.FindViewById<flirtplanet.GridViewNoScroll> (Resource.Id.gv_userGalleryImage);
			user = ProfileData.mUser;

			gridview.Adapter = new ImageAdapter (this.Activity);
			//imageview.SetImageBitmap(ProfileData.myGalleryPic[0]);
			imageview.SetUrlDrawable (Core.Constants.kBaseURL.Photo + ProfileData.myGalleryPic[0].HashedName, Resource.Drawable.DD_DefaultImage_loading,false,Core.Constants.kCircularImageSize.freshFaces);

			gridview.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args) 
			{
				selectedPhoto = 0;
				//imageview.SetImageBitmap(ProfileData.myGalleryPic[args.Position]);
				imageview.SetUrlDrawable (Core.Constants.kBaseURL.Photo + ProfileData.myGalleryPic[args.Position].HashedName, Resource.Drawable.DD_DefaultImage_loading,false,Core.Constants.kCircularImageSize.freshFaces);
				selectedPhoto = args.Position;
				mSelectedPhoto = user.Photos [selectedPhoto];
			};

			var flag = view.FindViewById<ImageView> (Resource.Id.iv_flagPhoto);
			var removePhoto = view.FindViewById<ImageView> (Resource.Id.iv_removePhoto);
			var setAvatar = view.FindViewById<TextView> (Resource.Id.tv_setAvatar);

			if (FragmentUserGallery.ownGallery) 
			{
				mSelectedPhoto = user.Photos [selectedPhoto];

				setAvatar.Click += (sender, e) => 
				{
					if(mSelectedPhoto == null)
					{
						string header = "ERROR";
						string message = "No valid image selected. Please add a photo or select the photo first.";
						string buttonText = "OK";
						Popup popup = new Popup();
						popup.getpopup (this.Activity, header, message, buttonText);
					}
					else
					{
						string[] avatarChanged = null;
						do { avatarChanged = ProfileBus.MakePhotoAvatarGoal(ref MainUser.AppUser, user, mSelectedPhoto.HashedName, ref MainUser.Goals); } while ( avatarChanged == null);

						MainUser.RefreshAvatar();

						if(avatarChanged.Length == 2)
						{
							FlirtPlanetActivity.FlyoutNav.AdjustJuice();
							FlirtPlanetActivity.FlyoutNav.refreshJuiceGold();
						}

						string header = "Avatar Changed";
						string message = "Avatar set to the currently selected picture.";
						string buttonText = "OK";
						Popup popup = new Popup();
						popup.getpopup (this.Activity, header, message, buttonText);

					}
				};

				removePhoto.Click += (sender, e) => 
				{
					string header = "Delete Photo";
					string message = "Are you sure you want to delete this photo? This action cannot be undone.";
					string buttonText = "delete_photo";
					getpopup (this.Activity, header, message, buttonText);
				};

				flag.SetImageResource (Resource.Drawable.DD_FlirtMail_icn_new_message);
				flag.Click += (sender, e) => 
				{
					if(user.Photos.Count >= /*user.PublicPhotoCapacity*/ 5)
					{
						string header = "ERROR";
						string message = "You have reached the maximum number of photos. Delete a photo before adding a new one.";
						string buttonText = "OK";
						Popup popup = new Popup();
						popup.getpopup (this.Activity, header, message, buttonText);
					}
					else // show FB album page
					{
						FragmentTransaction ft1 = FragmentManager.BeginTransaction ();
						ft1.Replace(Resource.Id.content_frame, new FragmentFacebookAlbums(false))
							.AddToBackStack(null)
							.Commit();
					}
				};
			} 
			else 
			{
				removePhoto.Visibility = ViewStates.Gone;
				setAvatar.Visibility = ViewStates.Gone;

				flag.SetImageResource (Resource.Drawable.DD_profile_flag_unconnect);
				flag.Click += (sender, e) => {
					string header = "REPORT PROFILE";
					string message = "Are you sure you want to report this photo?";
					string buttonText = "report_photo";
					Popup popup = new Popup();
					popup.getpopup (this.Activity, header, message, buttonText);
				};
			}
			return view;
		}

		public void deletePhoto()
		{
			//adding the delete code here as FragmentManager was throwing an exception in Popup.cs because of lack of Fragment class as its base
			string result = ProfileBus.DeletePhoto (ref MainUser.AppUser, ProfileData.mUser, 1, FragmentUserGallery.mSelectedPhoto.HashedName);
			while (result == null) {result = ProfileBus.DeletePhoto (ref MainUser.AppUser, ProfileData.mUser, 1, FragmentUserGallery.mSelectedPhoto.HashedName);}

			Fragment currentFragment = new FragmentProfile ();
			FragmentTransaction ft = FragmentManager.BeginTransaction ();
			ft.Replace (Resource.Id.content_frame, currentFragment)
				.AddToBackStack (null)
				.Commit ();

			selectedPhoto = 0;
			confirmDelete = false;
		}


		public void getpopup(Activity activity, String headerText, String messageText, String buttonText)
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (activity);
			ad = builder.Create ();

			var customView = activity.LayoutInflater.Inflate(Resource.Layout.AD_GenericPopup, null);

			var header = customView.FindViewById <TextView> (Resource.Id.tv_header);
			var messageBody = customView.FindViewById <TextView> (Resource.Id.tv_messageBody);

			var buttonOK = customView.FindViewById <Button> (Resource.Id.button_OK);

			header.Text = headerText;
			messageBody.Text = messageText;
			buttonOK.Text = buttonText;

			buttonOK.Click += (sender, e) => 
			{
				if (buttonText == "delete_photo") 
				{
					this.deletePhoto ();
					ad.Dismiss();
				}
			};

			buttonOK.Text = "OK";

			builder.SetView(customView);

			ad = builder.Create ();
			ad.Show ();

		}
	}
}

