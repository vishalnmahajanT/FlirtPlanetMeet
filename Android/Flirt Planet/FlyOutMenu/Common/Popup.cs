
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Core.Business;
using Android.Graphics;
using System.Runtime.InteropServices;
using Android.Net;

namespace flirtplanet
{
	public class Popup : Fragment
	{
		public void getpopup(Activity activity, String headerText, String messageText, String buttonText)
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (activity);
			ad = builder.Create ();

			var customView = activity.LayoutInflater.Inflate(Resource.Layout.AD_GenericPopup, null);

			var header = customView.FindViewById <TextView> (Resource.Id.tv_header);
			var messageBody = customView.FindViewById <TextView> (Resource.Id.tv_messageBody);

			var buttonOK = customView.FindViewById <Button> (Resource.Id.button_OK);
			var close = customView.FindViewById <ImageView> (Resource.Id.iv_close);
			//////////var buttonCancel = customView.FindViewById <Button> (Resource.Id.button_cancel);

			header.Text = headerText;
			messageBody.Text = messageText;
			buttonOK.Text = buttonText;

			buttonOK.Click += (sender, e) => 
			{
				if(buttonText == "report_photo")
				{
					string result = null;
					do { result = ProfileBus.FlagPhoto(ProfileData.mUser.UniqUser, ProfileData.mUser.Photos[FragmentUserGallery.selectedPhoto].UniqPhoto); }
					while (result == null);

					string head = "Photo was flagged!";
					string message = "Thank you for bringing this photo to our attention. This photo is now queued for review.";
					string button = "OK";

					getpopup(activity,head,message,button);
				}
				else if(buttonText == "report_user" || buttonText == "report_profile")
				{
					string result = null;
					do { result = ProfileBus.FlagProfile(MainUser.AppUser.UniqUser, ProfileData.mUser.UniqUser); }
					while (result == null);

					string head = "Profile was flagged!";
					string message = "Thank you for bringing this profile to our attention. This profile is now queued for review.";
					string button = "OK";

					getpopup(activity,head,message,button);
				}
				else if(buttonText == "boosts_store")
				{
					Fragment currentFragment = new FragmentBoost ();
					FragmentTransaction ft = activity.FragmentManager.BeginTransaction ();
					ft.Replace (Resource.Id.content_frame, currentFragment)
						.AddToBackStack (null)
						.Commit ();
				}

				ad.Cancel();
			};

			close.Click += (sender, e) => 
			{
				ad.Cancel();
			};

			buttonOK.Text = "OK";

			builder.SetView(customView);

			ad = builder.Create ();
			ad.Show ();

		}

		public void getpopup(Activity activity, int headerText, int messageText, String buttonText)
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (activity);
			ad = builder.Create ();

			var customView = activity.LayoutInflater.Inflate(Resource.Layout.AD_GenericPopup, null);

			var header = customView.FindViewById <TextView> (Resource.Id.tv_header);
			var messageBody = customView.FindViewById <TextView> (Resource.Id.tv_messageBody);

			var buttonOK = customView.FindViewById <Button> (Resource.Id.button_OK);

			header.Text = activity.GetString(headerText);
			messageBody.Text = activity.GetString(messageText);

			header.SetTextColor (Color.Black);
			messageBody.SetTextColor (Color.Black);

			buttonOK.Text = buttonText;

			builder.SetView(customView);
			ad = builder.Create ();
			ad.Show ();

			buttonOK.Click += (object sender, EventArgs e) => {
				ad.Dismiss();
			};
		}

		public void getReviewPopup( Activity activity)
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (activity);
			ad = builder.Create ();
			var customView = activity.LayoutInflater.Inflate (Resource.Layout.AD_Review, null);


				TextView reviewTitle;
				int select = 1;

				reviewTitle = customView.FindViewById <TextView> (Resource.Id.tv_title);
				var close = customView.FindViewById <TextView> (Resource.Id.btn_close);
				var CanReview = customView.FindViewById <LinearLayout> (Resource.Id.ll_canReview);
			var canReviewMessage = customView.FindViewById<TextView> (Resource.Id.tv_canReview);
				var WriteReview = customView.FindViewById <LinearLayout> (Resource.Id.ll_writeReview);
				var review = customView.FindViewById <Button> (Resource.Id.btn_review);
				var submit = customView.FindViewById <Button> (Resource.Id.btn_submit);
				var reviewMessage = customView.FindViewById <TextView> (Resource.Id.ed_writeReview);
				var iv_WriteReview = customView.FindViewById <ImageView> (Resource.Id.iv_writeReview);
				

			reviewTitle.Text =   "Review User now unlocked!";
			canReviewMessage.Text =  "Review " + FragmentMail.partnerName;

				CanReview.Visibility = ViewStates.Visible;
				WriteReview.Visibility = ViewStates.Gone;




				review.Click += (sender, e) => 
				{
					CanReview.Visibility = ViewStates.Gone;
					WriteReview.Visibility = ViewStates.Visible;
					reviewTitle.Text =    "Review " + FragmentMail.partnerName;
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

					string result =null;
					do { result = ProfileBus.ReviewUser(MainUser.AppUser.UniqUser, FragmentMail.partnerID, reviewMessage.Text, select); } while (result == null);
				};

				close.Click += (sender, e) => {
					ad.Cancel ();
				};




			builder.SetView(customView);
			ad = builder.Create ();
			ad.Show ();
		}


		public static void CreateErrorPopup (Activity activity, int headerText, int messageText, String buttonText,[OptionalAttribute]bool finishActivity)
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (activity);
			ad = builder.Create ();

			var customView = activity.LayoutInflater.Inflate(Resource.Layout.AD_GenericPopup, null);

			var header = customView.FindViewById <TextView> (Resource.Id.tv_header);
			var messageBody = customView.FindViewById <TextView> (Resource.Id.tv_messageBody);

			var buttonOK = customView.FindViewById <Button> (Resource.Id.button_OK);

			header.Text = activity.GetString(headerText);
			messageBody.Text = activity.GetString(messageText);
			buttonOK.Text = buttonText;

			builder.SetView(customView);
			ad = builder.Create ();
			ad.Show ();

			buttonOK.Click += (object sender, EventArgs e) => 
			{
				ad.Dismiss();

				if(finishActivity)
					activity.Finish();
			};
		}

		public static void getpopup(Activity activity, int layout)
		{
			/*AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (activity);
			ad = builder.Create ();

			var customView = activity.LayoutInflater.Inflate(Resource.Layout.HT_DemoPopup, null);

		
			builder.SetView(customView);
			ad = builder.Create ();
			ad.Show ();
		
		*/
		}	

		public static void getScrollPopup(Activity activity, string text)
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (activity);
			ad = builder.Create ();

			var customView = activity.LayoutInflater.Inflate(Resource.Layout.HT_PersonalityResult, null);
			var testResult = customView.FindViewById<TextView> (Resource.Id.tv_personalityResult);
			var button = customView.FindViewById<Button> (Resource.Id.btn_testOk);

			button.Click+= (object sender, EventArgs e) => {
				ad.Dismiss();
			};

			testResult.Text = text;

			builder.SetView(customView);
			ad = builder.Create ();
			ad.Show ();

		}

		public static bool isConnectingToInternet(Context _context)
		{
			ConnectivityManager connectivity = (ConnectivityManager) _context.GetSystemService(Context.ConnectivityService);
			if (connectivity != null)
			{
				NetworkInfo[] info = connectivity.GetAllNetworkInfo();
				if (info != null)
					for (int i = 0; i < info.Length; i++) 
					{
						if (info [i].GetState () == NetworkInfo.State.Connected) 
						{
							return true;
						}
					}
			}
			return false;
		}

	}
}

