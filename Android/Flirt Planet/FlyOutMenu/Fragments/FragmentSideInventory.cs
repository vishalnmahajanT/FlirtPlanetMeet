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
using System.Collections;


namespace flirtplanet
{
	public class FragmentSideInventory : Fragment
	{
		List<Item> _userPermanentBoosts = BoostItem.mUserPermanentItems;
		List<Item> _userDurationActiveBoosts = BoostItem.mUserActiveItems;
		List<Item> _userDurationInActiveBoosts = BoostItem.mUserInActiveItems;
		List<ImageView> addBoost;
		List<TextView> usedBoost;
		List<CircleImageProgress> _items;
		CircleImageProgress draw;

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate (Resource.Layout.fragment_side_inventory, container, false);

			FragmentBoost.DrawableStateChanged(FragmentBoost.btnsideinventory);
			_items = new List<CircleImageProgress> ();
			addBoost = new List<ImageView> ();
			usedBoost = new List<TextView> ();
			//var equippedGridView = view.FindViewById <flirtplanet.GridViewNoScroll> (Resource.Id.gv_equipped);
			addBoost.Add (view.FindViewById <ImageView> (Resource.Id.iv_add_boost1));
			addBoost.Add (view.FindViewById <ImageView> (Resource.Id.iv_add_boost2));
			addBoost.Add (view.FindViewById <ImageView> (Resource.Id.iv_add_boost3));
			addBoost.Add (view.FindViewById <ImageView> (Resource.Id.iv_add_boost4));
		
			usedBoost.Add (view.FindViewById <TextView> (Resource.Id.tv_add_boost1));
			usedBoost.Add (view.FindViewById <TextView> (Resource.Id.tv_add_boost2));
			usedBoost.Add (view.FindViewById <TextView> (Resource.Id.tv_add_boost3));
			usedBoost.Add (view.FindViewById <TextView> (Resource.Id.tv_add_boost4));

			var permanentMessage = view.FindViewById <TextView> (Resource.Id.tv_permanent);
			var permanentGridView = view.FindViewById <flirtplanet.GridViewNoScroll> (Resource.Id.gv_permanent);
			var inventoryMessage = view.FindViewById <TextView> (Resource.Id.tv_inventory);
			var inventoryGridView = view.FindViewById <flirtplanet.GridViewNoScroll> (Resource.Id.gv_inventory);
		
			string result = null;
			do{result = BoostBus.GetUserItemsPermanent (MainUser.AppUser.UniqUser, ref _userDurationActiveBoosts, ref _userDurationInActiveBoosts, ref _userPermanentBoosts);} while(result == null);


			equippedImages (_userDurationActiveBoosts);

			//equippedGridView.Adapter = new Eq

			if (_userPermanentBoosts.Count == 0) 
			{
				permanentMessage.Visibility = ViewStates.Visible;
				permanentGridView.Visibility = ViewStates.Gone;
			}
			else 
			{
				permanentMessage.Visibility = ViewStates.Gone;
				permanentGridView.Visibility = ViewStates.Visible;

				permanentGridView.Adapter = new UserPermanentBoostsAdapter (this.Activity,
					_userPermanentBoosts);

			}

			if (_userDurationInActiveBoosts.Count == 0) 
			{
				Console.WriteLine ("==== Inactive boost count =0 ====" + _userDurationInActiveBoosts.Count);

				inventoryMessage.Visibility = ViewStates.Visible;
				inventoryGridView.Visibility = ViewStates.Gone;
			}
			else 
			{
				Console.WriteLine ("==== Inactive boost count !0 ====" + _userDurationInActiveBoosts.Count);
				inventoryMessage.Visibility = ViewStates.Gone;

				inventoryGridView.Visibility = ViewStates.Visible;

				inventoryGridView.Adapter = new UserDurationBoostsAdapter (this.Activity,
						_userDurationInActiveBoosts);
			}

			return view;
		}
		//----------------------------------------

		public float SetUsed(Item itemName,TextView usedText)
		{
			float percentLeft = ((itemName.Uses > 0) ? itemName.UsesLeft / (float)itemName.Uses : 0.0f) * 100;

			//mLabel.Frame = GRTools.Rect.CenterHoriz((AppMgr.IsOnIPad) ? iPad.kFrames.Inventory_ItemText : iPhone.kFrames.Inventory_ItemText);
			usedText.Text = itemName.UsesLeft.ToString() + " " + GetCountTextFromItemName(itemName.ItemName) + " Left";
			return percentLeft;
			//mLabel.SizeToFit();
		}

		//----------------------------------------
		static Dictionary<string, string> mCountInfo = new Dictionary<string, string>()
		{
			{ "Bronze Shooting Star", "Views" },
			{ "Silver Shooting Star", "Views" },
			{ "Gold Shooting Star", "Views" },
			{ "Bronze Quality Scanner", "Searches" },
			{ "Silver Quality Scanner", "Searches" },
			{ "Gold Quality Scanner", "Searches" }
		};
		//----------------------------------------

		public static string GetCountTextFromItemName(string itemName)
		{
			if (mCountInfo.ContainsKey(itemName))
				return mCountInfo[itemName] + " ";
			else
				return string.Empty;
		}

		private void EmptyCollection (ICollection collection)
		{   // throws all elements in the list, if needed disposes them
			foreach (object o in collection)
			{
				System.IDisposable disposableObject = o as System.IDisposable;
				//o = null;
				if (disposableObject != null)
				{
					disposableObject.Dispose();
				}
			}
		}

		//----------------------------------------
		public override void OnDestroyView ()
		{
			base.OnDestroyView ();

			EmptyCollection (_items);
			EmptyCollection (addBoost);
			EmptyCollection (usedBoost);
			if (draw != null)
			{
				draw.Dispose();
				draw = null;
			}
			/*	foreach (var dis in _items)
			{
				if (dis != null)
				{
					dis.Dispose();
				}
			}*/

			GC.Collect (0);
		}

		public void equippedImages(List<Item> _userActiveBoosts)
		{
			for (int i = 0; i < _userActiveBoosts.Count; i++) {
				//_items.Add(new CircleImageProgress (this.Activity, BoostItem.GetIconFromItemName (_userActiveBoosts [i].ItemName),
				//	SetUsed (_userActiveBoosts [i],  usedBoost[i]), 1500));
				draw = new CircleImageProgress (this.Activity, BoostItem.GetIconFromItemName (_userActiveBoosts [i].ItemName),
						SetUsed (_userActiveBoosts [i],  usedBoost[i]), 1500);
				addBoost[i].SetImageDrawable (draw);

			}

		}
	}

	class UserPermanentBoostsAdapter : BaseAdapter
	{
		List <Item> _UserboostList;
		Activity context;
	
		//constructor
		public UserPermanentBoostsAdapter(Activity context, List <Item> _inventoryBoostsList)
		{
			this.context = context;
			_UserboostList = _inventoryBoostsList;
		}


		public override int Count
		{
			get{ return _UserboostList.Count; }
		}

		public override Java.Lang.Object GetItem (int position)
		{
			return _UserboostList [position].UniqItem;
		}

		public override long GetItemId (int position)
		{
			return position;//.Id;
		}


		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			var custview = convertView ?? context.LayoutInflater.Inflate (Resource.Layout.fragment_side_inventory_each_item, parent, false);
	
			var iv_shooting = custview.FindViewById <ImageView> (Resource.Id.iv_shotingstar);
			var tv_title = custview.FindViewById <TextView> (Resource.Id.tv_title);
			var isActive = custview.FindViewById <TextView> (Resource.Id.tv_active);
			var isActiveIcon = custview.FindViewById <ImageView> (Resource.Id.iv_active);

			if (_UserboostList [position].Active == "1") 
			{
				isActiveIcon.SetImageResource (Resource.Drawable.DD_Header_icn_tickbox);
				isActive.SetTextColor (Color.ParseColor ("#ff00c1f8"));
			} 
			else
			{
				isActiveIcon.SetImageResource (Resource.Drawable.DD_Header_icn_tickbox_empty);
				isActive.SetTextColor (Color.ParseColor ("#ff474444"));
			}


			isActiveIcon.Click += (sender, e) => 
			{	
				if (_UserboostList[position].Active == "1") 
				{
					isActiveIcon.SetImageResource(Resource.Drawable.DD_Header_icn_tickbox_empty);
					isActive.SetTextColor(Color.ParseColor("#ff474444"));
					_UserboostList[position].Active = "0";
				
				}
				else
				{
					isActiveIcon.SetImageResource(Resource.Drawable.DD_Header_icn_tickbox);
					isActive.SetTextColor(Color.ParseColor("#ff00c1f8"));
					_UserboostList[position].Active = "1";
				}

				string result = null;
				do
				{ result = BoostBus.ToggleItemActive(MainUser.AppUser.UniqUser, _UserboostList[position].UniqItem);}while(result == null);

			};

			iv_shooting.SetImageResource (BoostItem.GetIconFromItemName (_UserboostList[position].ItemName));
			tv_title.Text = _UserboostList[position].ItemName;

			return custview;
		}

	}

	class UserDurationBoostsAdapter : BaseAdapter
	{
		List <Item> _UserboostList;
		Activity context;
	
		//constructor
		public UserDurationBoostsAdapter(Activity context, List <Item> _inventoryBoostsList)
		{
			this.context = context;
			_UserboostList = _inventoryBoostsList;
		}


		public override int Count
		{
			get{ return _UserboostList.Count; }
		}

		public override Java.Lang.Object GetItem (int position)
		{
			return _UserboostList [position].UniqItem;
		}

		public override long GetItemId (int position)
		{
			return position;//.Id;
		}


		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			var custview = convertView ?? context.LayoutInflater.Inflate (Resource.Layout.fragment_side_inventory_each_item, parent, false);

			var iv_shooting = custview.FindViewById <ImageView> (Resource.Id.iv_shotingstar);
			var tv_title = custview.FindViewById <TextView> (Resource.Id.tv_title);
			var isActive = custview.FindViewById <TextView> (Resource.Id.tv_active);
			var isActiveIcon = custview.FindViewById <ImageView> (Resource.Id.iv_active);

			iv_shooting.SetImageResource (BoostItem.GetIconFromItemName (_UserboostList[position].ItemName));
			tv_title.Text = _UserboostList[position].ItemName;
			isActive.Visibility = ViewStates.Gone;
			isActiveIcon.Visibility = ViewStates.Gone;

			return custview;
		}

	}


}

