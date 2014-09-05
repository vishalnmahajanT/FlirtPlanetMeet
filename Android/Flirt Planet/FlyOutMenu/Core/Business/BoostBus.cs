//--------------------------------------------------------------------------------
//
// Core.Business.BusinessBase.cs - 
//
// Copyright 2013-2014 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;
using Newtonsoft.Json;
using Core.Data;

//--------------------------------------------------------------------------------

namespace Core.Business
{
	public class BoostBus : BusinessBase
	{

		//----------------------------------------
		// Load all items for Boosts store

		public static string GetItemsForStorePermanent(int userID, ref List<Item> durationItems, ref List<Item> permanentItems)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetItemsForStorePermanent", "{\"UserID\": " + userID + "}"));
				++Counter;
			}

			List<Item> allItems = JsonConvert.DeserializeObject<List<Item>>(DecodeString(ReturnVal));

			durationItems = (from i in allItems
							 where i.ItemType == "Duration"
							 select i).ToList();

			permanentItems = (from i in allItems
							  where i.ItemType == "Permanent"
							  select i).ToList();

			return "Success";
		}

		//----------------------------------------
		// Purchase duration item from Boosts store
		// array[0] == FlirtGold
		// If arrayLength = 1, then the purchase failed and simply update the FlirtGold on screen
		// If arrayLength = 2, then check array[1] to see if the item is active and add it to the proper Inventory List

		public static string[] PurchaseDurationItem(ref AppUser appUser, int itemID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("PurchaseDurationItem", "{\"UserID\":" + appUser.UniqUser + ", \"ItemID\":" + itemID + "}"));
				++Counter;
			}

			string[] returnInfo = ReturnVal.Split(',');
			appUser.Android_FlirtGold = Convert.ToInt32(returnInfo[0]);

			return returnInfo;
		}

		//----------------------------------------
		// Purchase permanent item from Boosts store

		public static string PurchasePermanentItem(ref AppUser appUser, int itemID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("PurchasePermanentItem", "{\"UserID\":" + appUser.UniqUser + ", \"ItemID\":" + itemID + "}"));
				++Counter;
			}

			appUser.Android_FlirtGold = Convert.ToInt32(ReturnVal);

			return "Success";
		}

		//----------------------------------------
		// User uses a flirtjuice pack
		// 1 = success, 0 = daily packs used already, -1 = no flirtjuice packs

		public static string UseFlirtJuicePack(ref AppUser appUser)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("UseFlirtJuicePack", "{\"UserID\":" + appUser.UniqUser + "}"));
				++Counter;
			}

			string[] returnInfo = ReturnVal.Split(',');

			if (returnInfo.Length == 2)
				appUser.FlirtJuice = Convert.ToInt32(returnInfo[1]);

			return returnInfo[0];
		}

		//----------------------------------------
		// Get all inactive items a user has

		public static string GetUserItemsPermanent(int userID, ref List<Item> activeItems, ref List<Item> inActiveItems, ref List<Item> permanentItems)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetUserItemsPermanent", "{\"UserID\":" + userID + "}"));
				++Counter;
			}

			List<Item> allItems = JsonConvert.DeserializeObject<List<Item>>(DecodeString(ReturnVal));

			activeItems = (from i in allItems
						   where i.ItemType == "Duration" && i.Active == "1"
						   select i).ToList();

			inActiveItems = (from i in allItems
							 where i.ItemType == "Duration" && i.Active == "0"
							 select i).ToList();

			permanentItems = (from i in allItems
							  where i.ItemType == "Permanent"
							  select i).ToList();

			return "Success";
		}

		//----------------------------------------
		// Get all expired items a user has

		public static List<Item> GetExpiredItems(int userID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetExpiredItems", "{\"UserID\":" + userID + "}"));
				++Counter;
			}

			return JsonConvert.DeserializeObject<List<Item>>(DecodeString(ReturnVal));
		}

		//----------------------------------------
		// Get all expired items a user has

		public static FlirtJuice GetFlirtJuiceObject(int userID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetFlirtJuiceObject", "{\"UserID\":" + userID + "}"));
				++Counter;
			}

			return JsonConvert.DeserializeObject<FlirtJuice>(DecodeString(ReturnVal));
		}

		//----------------------------------------
		// Fuses FlirtJuice from RefundFlirtJuiceContainer to users main FlirtJuice value

		public static string FlirtJuiceFusion(ref AppUser appUser, ref FlirtJuice flirtJuice)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("FlirtJuiceFusion", "{\"UserID\":" + appUser.UniqUser + "}"));
				++Counter;
			}

			string[] returnInfo = ReturnVal.Split(',');
			appUser.FlirtJuice = Convert.ToInt32(returnInfo[0]);
			flirtJuice.RefundFlirtJuice = 0;

			return (returnInfo.Length == 2) ? "NoJuice" : "Added";
		}

		#region _Feature Functions_

		//----------------------------------------
		// Decrement Featured User Items

		public static void ViewFeaturedUsers(int[] ids)
		{
			WebService.CallWebservice(EncodeString("ViewFeaturedUsers", "{\"FeaturedUsers\":" + JsonConvert.SerializeObject(ids) + "}"));
		}

		//----------------------------------------
		// Decrement Cream of the Crop Items

		public static void UseDurationItem(int userID, int featureID)
		{
			WebService.CallWebservice(EncodeString("UseDurationItem", "{\"UserID\":" + userID + ", \"FeatureID\":" + featureID + "}"));
		}

		//----------------------------------------
		// Toggle an item active/inactive

		public static string ToggleItemActive(int userID, int itemID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("ToggleItemActive", "{\"UserID\":" + userID + ", \"ItemID\": " + itemID + "}"));
				++Counter;
			}

			return ReturnVal;
		}

		//----------------------------------------
		// Get if the feature is active

		public static string IsFeatureActive(int userID, int featureID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("IsFeatureActive", "{\"UserID\":" + userID + ", \"FeatureID\": " + featureID + "}"));
				++Counter;
			}

			return ReturnVal;
		}

		#endregion _Feature Functions_

	} // End Class: BusinessBase

} // End Namespace: Core.Business

//--------------------------------------------------------------------------------
// EOF
