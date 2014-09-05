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
using Android.Graphics.Drawables;
using Android.Graphics;

namespace flirtplanet
{
	public class FragmentSideJuicePack : Fragment
	{
		public FlirtJuice mFlirtJuice;
		const int kNumNonExtremeBottleFrames = 4;
		TextView flirtJuiceText;
		ImageView juiceBottle;
		Button buyJuicePack;
		public static FragmentSideJuicePack juicePackObject;

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate (Resource.Layout.fragment_juice_pack, container, false);

			FragmentBoost.DrawableStateChanged(FragmentBoost.btnsidejuicepack);

			juicePackObject = this;

			flirtJuiceText = view.FindViewById<TextView> (Resource.Id.tv_flirtJuiceText);
			juiceBottle = view.FindViewById<ImageView> (Resource.Id.iv_juice);

			do {mFlirtJuice = BoostBus.GetFlirtJuiceObject (MainUser.AppUser.UniqUser);} while (mFlirtJuice == null);

			SetContents(mFlirtJuice);
			BusinessBase.DeleteNotifications (MainUser.AppUser.UniqUser, "RFUND");
			//TODO FlirtPlanetActivity.FlyoutNav.updateNotificationCounters();

			buyJuicePack = view.FindViewById<Button> (Resource.Id.btn_buy);
			updateJuicePackButton (mFlirtJuice.FlirtJuicePacks);

			juiceBottle.Click += (sender, e) => 
			{
				string result = null;
				do{result = BoostBus.FlirtJuiceFusion(ref MainUser.AppUser, ref mFlirtJuice);} while (result == null);

				if(!result.Equals("NoJuice"))
				{
					SetContents(mFlirtJuice);
					FlirtPlanetActivity.FlyoutNav.AdjustJuice();
					FlirtPlanetActivity.FlyoutNav.refreshJuiceGold();
				}
			};

			return view;
		}

		public int FlirtJuicePacksLeft
		{
			get { return mFlirtJuice.FlirtJuicePacks;}
			set
			{
				if (mFlirtJuice != null) 
				{
					mFlirtJuice.FlirtJuicePacks = value;
					//updateJuicePackButton (value);
					updateJuicePackButtonText (value);
				}
			}
		}

		void updateJuicePackButtonText(int packs)
		{
			if (packs == 0) 
			{
				buyJuicePack.Text = "Buy Flirt Juice Pack";
			} 
			else 
			{
				buyJuicePack.Text = "Use 1 of " + mFlirtJuice.FlirtJuicePacks.ToString () + " Packs";
			}
		}

		void updateJuicePackButton(int packs)
		{
			if (packs == 0) 
			{
				buyJuicePack.Text = "Buy Flirt Juice Pack";
				buyJuicePack.Click += loadFlirtJuicePopup;
				buyJuicePack.Click -= usePackConfirmation;
			} 
			else 
			{
				buyJuicePack.Text = "Use 1 of " + mFlirtJuice.FlirtJuicePacks.ToString() + " Packs";
				buyJuicePack.Click += usePackConfirmation;
				buyJuicePack.Click -= loadFlirtJuicePopup;
			}
		}

		void usePackConfirmation (object sender, EventArgs e)
		{
			if (mFlirtJuice.FlirtJuicePacks > 0) 
			{
				string header = "Flirt Juice Packs";
				string message = "You have " + mFlirtJuice.FlirtJuicePacks.ToString () + " Flirt Juice packs. Use 1 pack and gain 100 Flirt Juice?";
				string button = "USE PACK";

				getpopup (this.Activity, header, message, button);
			} 
			else 
			{
				string header = "NO PACKS";
				string message = "No flirt juice packs available to use.";
				string button = "OK";
				getpopup (this.Activity, header, message, button);
			}
		}

		void loadFlirtJuicePopup (object sender, EventArgs e)
		{
			FlirtPlanetActivity.FlyoutNav.getBuyPopup (Resource.Id.ll_flirtjuice, 0);
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
			var close = customView.FindViewById <ImageView> (Resource.Id.iv_close);

			header.Text = headerText;
			messageBody.Text = messageText;
			buttonOK.Text = buttonText;

			if (buttonText == "USE PACK") 
			{
				buttonOK.Click += usePack;
			} 
			else 
			{
				buttonOK.Text = "OK";
			}

			close.Click += (sender, e) => 
			{
				ad.Cancel();
			};

			buttonOK.Click += (sender, e) => 
			{
				ad.Dismiss ();
			};
				
			builder.SetView(customView);

			ad = builder.Create ();
			ad.Show ();

		}

		void usePack (object sender, EventArgs e)
		{
			string flirtJuice = null;

			do{flirtJuice = BoostBus.UseFlirtJuicePack(ref MainUser.AppUser); } while (flirtJuice == null);

			if (flirtJuice != null) 
			{
				if (flirtJuice.Equals ("0"))
					CreateErrorPopup (this.Activity, Resource.String.error, Resource.String.maxFJPacksUsed, "OK");
				else if (flirtJuice.Equals ("-1"))
					CreateErrorPopup (this.Activity, Resource.String.error, Resource.String.noFJPacks, "OK");
				else if (flirtJuice.Equals ("1")) 
				{
					--FlirtJuicePacksLeft;
					FlirtPlanetActivity.FlyoutNav.AdjustJuice();
					FlirtPlanetActivity.FlyoutNav.refreshJuiceGold();
				}
			}
		}

		public void CreateErrorPopup (Activity activity, int headerText, int messageText, String buttonText)
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

			buttonOK.Click += (object sender, EventArgs e) => {
				ad.Dismiss();
			};
		}

		public void SetContents(FlirtJuice juice)
		{
			float percent = (float)juice.RefundFlirtJuice / (float)juice.RefundFlirtJuiceCap;

			int bottleIcon = -1;

			int bottleFrame = (int)Math.Ceiling(percent * kNumNonExtremeBottleFrames);

			flirtJuiceText.Text = (juice.RefundFlirtJuice.ToString() + " Flirt Juice");

			// Show the overflowing frame only if at 100% (maybe eventually allow this to be higher than 100% and then only use this then?)
			if (percent == 1.0f) bottleFrame = 5;

			switch (bottleFrame)
			{
				case 0:  bottleIcon = Resource.Drawable.DD_Boosts_icn_bottle0; break;
				case 1:  bottleIcon = Resource.Drawable.DD_Boosts_icn_bottle1; break;
				case 2:  bottleIcon = Resource.Drawable.DD_Boosts_icn_bottle2; break;
				case 3:  bottleIcon = Resource.Drawable.DD_Boosts_icn_bottle3; break;
				case 4:  bottleIcon = Resource.Drawable.DD_Boosts_icn_bottle4; break;
				case 5:  bottleIcon = Resource.Drawable.DD_Boosts_icn_bottle5; break;
				default: bottleIcon = Resource.Drawable.DD_Boosts_icn_bottle0; break;
			}

			juiceBottle.SetImageResource (bottleIcon);

		}
	}
}

