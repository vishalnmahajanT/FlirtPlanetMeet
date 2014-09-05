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
	public class InventoryItem
	{
		public InventoryItem (Activity context, ref View v, Item _itemInfo, ref 
			List<Item> _list)
		{
			DrawItems (context, ref v, _itemInfo, ref _list);
		}

		public void DrawItems(Activity ctx, ref View view, Item _itemInfo,ref List<Item> _list)
		{
			//getting id's from layout file
			var iv_shooting = view.FindViewById <ImageView> (Resource.Id.iv_shotingstar);
			var tv_title = view.FindViewById <TextView> (Resource.Id.tv_title);
			Console.WriteLine ("======="+_itemInfo.ItemName);
			iv_shooting.SetImageResource (BoostItem.GetIconFromItemName (_itemInfo.ItemName));
			tv_title.Text = _itemInfo.ItemName;
	
		}

	}
}

