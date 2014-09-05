using System;
using System.Collections.Generic;

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
	public class BoostItem 
	{
		public static List<Item> mUserPermanentItems = new List<Item>();
		public static List<Item> mUserActiveItems = new List<Item>();
		public static List<Item> mUserInActiveItems = new List<Item>();

		TextView tv_title, tv_price;
		List<Item> _list;
	
		public static  IDictionary<string, int> mIcon = new Dictionary<string, int>()
		{
			{"Bronze Shooting Star", Resource.Drawable.DD_Boosts_icn_shooting_star_bronze},
			{"Silver Shooting Star", Resource.Drawable.DD_Boosts_icn_shooting_star_silver},
			{ "Gold Shooting Star", Resource.Drawable.DD_Boosts_icn_shooting_star_gold},
			{"Bronze Quality Scanner", Resource.Drawable.DD_Boosts_icn_quality_scanner_bronze},
			{"Silver Quality Scanner", Resource.Drawable.DD_Boosts_icn_quality_scanner_silver},
			{ "Gold Quality Scanner", Resource.Drawable.DD_Boosts_icn_quality_scanner_gold},
			{"Cloaking Device", Resource.Drawable.DD_Boosts_icn_cloaking_device},
			{"Hide Connections", Resource.Drawable.DD_Boosts_icn_hide_connections},
			{"Hide Facebook Friends", Resource.Drawable.DD_Boosts_icn_facebook},
		};

		public BoostItem (Activity ctx, ref View v, Item _itemInfo,ref List<Item> _list)
		{
			this._list = _list;
			DrawItems (ctx, ref v, _itemInfo);
		}
		public static Button Prevbuy=null; 
		Button buy;
		public void DrawItems(Activity ctx, ref View view, Item _itemInfo)
		{
			//getting id's from layout file
			var iv_shooting = view.FindViewById <ImageView> (Resource.Id.iv_shotingstar);
			 tv_title = view.FindViewById <TextView> (Resource.Id.tv_title);
			var tv_viewers = view.FindViewById <TextView> (Resource.Id.tv_viewers);
			var tv_featureName = view.FindViewById <TextView> (Resource.Id.tv_utype);
			var tv_description = view.FindViewById <TextView> (Resource.Id.tv_visibility);
			var btn_coinsimg = view.FindViewById <Button> (Resource.Id.btn_coins);
			tv_price = view.FindViewById <TextView> (Resource.Id.tv_price);
			buy = view.FindViewById <Button> (Resource.Id.btn_buy);

			iv_shooting.SetImageResource (GetIconFromItemName (_itemInfo.ItemName));
			tv_title.Text = _itemInfo.ItemName;
			if (_itemInfo.ItemType == "Duration")
			{
				tv_viewers.Visibility = ViewStates.Visible;
				tv_viewers.Text = _itemInfo.Uses + " Views";
			} 
			else
			{
				tv_viewers.Visibility = ViewStates.Gone;
			}
			tv_featureName.Text = _itemInfo.FeatureName;
			tv_description.Text = _itemInfo.ItemDescription;
			tv_price.Text = _itemInfo.Cost.ToString();

			buy.Click += (sender, e) => 
			{
				if(BoostItem.Prevbuy != buy)
				{
					GetBuyBoostPopup(ctx, Resource.Layout.AD_ConformBuyBoost, _itemInfo);
					BoostItem.Prevbuy = buy;
				}
			};

		}


		public static int GetIconFromItemName(string itemName)
		{
			if (mIcon.ContainsKey(itemName))
				return mIcon [itemName];
			else
				return Resource.Drawable.DD_Boosts_boost_placeholder;
		
		}


		public  void GetBuyBoostPopup(Activity context, int resource , Item _itemInfo)
		{

			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (context);
			ad = builder.Create ();
			var customView =context.LayoutInflater.Inflate(resource, null);
			bool flag = true;
			if (resource == Resource.Layout.AD_ConformBuyBoost) 
			{
				var bMessage = customView.FindViewById <TextView> (Resource.Id.tv_message);
				var Buy = customView.FindViewById <Button> (Resource.Id.btn_buy);
				var close = customView.FindViewById <Button> (Resource.Id.btn_close);


				bMessage.Text = tv_title.Text + " will cost " + tv_price.Text + " Flirt Gold. You have "
					+ MainUser.AppUser.Android_FlirtGold.ToString() +" Flirt Gold. Continue with the purchase?";

				Buy.Click += (sender, e) => 
				{
					BoostItem.Prevbuy = null;

					if(_itemInfo.ItemType == "Duration")
					{
						string[] result = null;
						do
						{result = BoostBus.PurchaseDurationItem(ref MainUser.AppUser , _itemInfo.UniqItem);}while(result == null);

						if(result.Length > 1)
						{
							string isActive = result[1];

							if(isActive.Equals("0"))
								mUserInActiveItems.Add(_itemInfo);
							else
								mUserActiveItems.Add(_itemInfo);
						}
					}
					else
					{
						//_list.Remove(_itemInfo);
						mUserPermanentItems.Add(_itemInfo);
						string result = null;
						do{result = BoostBus.PurchasePermanentItem(ref MainUser.AppUser, _itemInfo.UniqItem);} while(result == null);
					}

					FlirtPlanetActivity.FlyoutNav.AdjustGold();
					FlirtPlanetActivity.FlyoutNav.refreshJuiceGold();

					ad.Cancel();
				};
				close.Click += (sender, e) => 
				{
					ad.Cancel();
					BoostItem.Prevbuy = null;
				};
			}
			builder.SetView(customView);
			ad = builder.Create ();
			ad.Show ();
		}

	}
}

