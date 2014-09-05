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
	public class BusinessBase
	{
		#region Variables

		//----------------------------------------

		static string mReturnVal;
		static int mCounter;

		//----------------------------------------

		#endregion

		#region Properties

		//----------------------------------------

		protected static string ReturnVal
		{
			get { return mReturnVal; }
			set { mReturnVal = value; }
		}

		//----------------------------------------

		protected static int Counter
		{
			get { return mCounter; }
			set { mCounter = value; }
		}

		//----------------------------------------

		#endregion

		#region Methods

		//----------------------------------------
		// Get the users notifications

		public static Notifications GetUserNotifications(int userID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetUserNotifications", "{\"UserID\":" + userID + "}"));
				++Counter;
			}

			return JsonConvert.DeserializeObject<Notifications>(DecodeString(ReturnVal));
		}

		//----------------------------------------
		// Get the user goals

		public static List<Goal> GetUserGoals(int userID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetUserGoals", "{\"UserID\":" + userID + "}"));
				++Counter;
			}

			List<Goal> unfinished = JsonConvert.DeserializeObject<List<Goal>>(DecodeString(ReturnVal));
			List<Goal> goals = new List<Goal>();

			// Loop through goals and add already completed goals
			for (int i = 1; i <= 5; ++i)
			{
				List<Goal> goal = (from g in unfinished
								   where g.UniqGoal == i
								   select g).ToList();

				if (goal.Count == 0)
					goals.Add(new Goal(i, string.Empty, true));
				else
					goals.Add(new Goal(i, goal[0].GoalName, false));
			}

			return goals;
		}

		//----------------------------------------
		// Get the detail questions and answers

		public static List<DetailQuestion> GetDetailQuestions()
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetDetailQuestions", "{\"AccountQuestion\": 1}"));
				++Counter;
			}

			return JsonConvert.DeserializeObject<List<DetailQuestion>>(DecodeString(ReturnVal));
		}

		//----------------------------------------
		// Update user notifications

		public static Notifications UpdateNotifications(int userID, string notificationType)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("UpdateNotifications", "{\"UserID\":" + userID + ", \"NotifType\":\"" + notificationType + "\"}"));
				++Counter;
			}

			return JsonConvert.DeserializeObject<Notifications>(DecodeString(ReturnVal));
		}

		//----------------------------------------
		// TEMP - delete user notifications

		public static void DeleteNotifications(int userID, string notificationType)
		{
			WebService.CallWebservice(EncodeString("DeleteNotifications", "{\"UserID\":" + userID + ", \"NotifType\":\"" + notificationType + "\"}"));
		}

		//----------------------------------------
		// Updates Currency Values and return the ConsecutiveLogins

		public static string Login(ref AppUser appUser)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("Login", "{\"UserID\":" + appUser.UniqUser + "}"));
				++Counter;
			}

			string[] resultArr = ReturnVal.Split(',');
			appUser.FlirtJuice = Convert.ToInt32(resultArr[1]);
			appUser.Android_FlirtGold = Convert.ToInt32(resultArr[2]);

			return resultArr[0];
		}

		#region DDA_Delegate

		//----------------------------------------
		// Start/End a SWRVE Session

		public static void ToggleSWRVESession(string facebookID, string status)
		{
			WebService.CallWebservice(EncodeString("ToggleSWRVESession", "{\"FacebookID\":" + facebookID + ", \"Status\": \"" + status + "\"}"));
		}

		//----------------------------------------
		// Insert PushToken if it's not already saved

		public static void SavePushToken(int userID, string token)
		{
			WebService.CallWebservice(EncodeString("SavePushToken", "{\"UserID\":" + userID + ", \"Token\":\"" + token + "\"}"));
		}

		//----------------------------------------

		#endregion DDA_Delegate

		#region FlirtGold Popup

		//----------------------------------------
		// Insert Transaction

		public static string InsertTransaction(int userID, string appleID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("InsertTransaction", "{\"UserID\": " + userID + ", \"AppleID\": \"" + appleID + "\"}"));
				++Counter;
			}

			return ReturnVal;
		}

		//----------------------------------------
		// Purchase FlirtGold 

		public static string PurchaseFlirtGold(ref AppUser appUser, string appleID, string localCost, string localType)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("PurchaseFlirtGold", "{\"UserID\":" + appUser.UniqUser + ", \"FacebookID\": \"" + appUser.UniqFacebook +
																	"\", \"AppleID\": \"" + appleID + "\"," + "\"LocalCost\": \"" + localCost + "\", \"LocalType\": \"" + localType + "\"}"));
				++Counter;
			}

			if (ReturnVal != "Failed")
				appUser.Android_FlirtGold = Convert.ToInt32(ReturnVal);

			return ReturnVal;
		}

		//----------------------------------------
		// Track Failed FlirtGold Purchase

		public static string FailedTransaction(int userID, string appleID, string status)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("FailedTransaction", "{\"UserID\": " + userID + ", \"AppleID\": \"" + appleID +
																	"\", \"Status\": \"" + status + "\"}"));
				++Counter;
			}

			return ReturnVal;
		}

		//----------------------------------------

		#endregion FlirtGold Popup

		#region FlirtJuice Popup

		//----------------------------------------
		// Get FlirtJuice Packs for FlirtJuice Popup

		public static List<Item> GetItemsForFlirtJuicePopup()
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetItemsForFlirtJuicePopup", "{\"FeatureID\": 1}"));
				++Counter;
			}

			return JsonConvert.DeserializeObject<List<Item>>(DecodeString(ReturnVal));
		}

		//----------------------------------------
		// Purchase FlirtJuice Pack
		// array[0] == FlirtGold
		// If arrayLength = 1, then the purchase failed and simply update the FlirtGold on screen
		// If arrayLength = 2, if array[1] == string.Empty then there's already a FlirtJuice Pack so the uses just need 
		// to be added to the existing one, else add the new FlirtJuice Pack to the item list

		public static string[] PurchaseFlirtJuicePack(ref AppUser appUser, int itemID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("PurchaseFlirtJuicePack", "{\"UserID\":" + appUser.UniqUser + ", \"ItemID\":" + itemID + "}"));
				++Counter;
			}

			string[] returnInfo = ReturnVal.Split(',');
			appUser.Android_FlirtGold = Convert.ToInt32(returnInfo[0]);

			return returnInfo;
		}

		//----------------------------------------

		#endregion FlirtJuice Popup

		#region Protected Methods

		//----------------------------------------
		// String edit before POST

		protected static string EncodeString(string methodName, string serializedObject)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("json={\"MethodName\":\"" + methodName + "\",\"DeviceType\":\"Android\",\"info\":");
			sb.Append(serializedObject);
			sb.Append("}");

			return sb.ToString();
		}

		//----------------------------------------
		// String clean-up before Deserialize on collection

		protected static string DecodeString(string json)
		{
			json = json.Replace("\\\\", "\\");
			json = json.Replace("\\\"", "\"");
			json = json.Replace("[\"{", "[{");
			json = json.Replace("}\"]", "}]");
			json = json.Replace("}\",\"{", "},{");
			json = json.Replace("\"{", "{");
			json = json.Replace("}\"", "}");

			return json;
		}

		//----------------------------------------
		// User-Entered Special Character Encoding

		protected static string EncodeEssay(string field)
		{
			field = field.Replace("\n", "[ent]"); // enter
			field = field.Replace("\'", "[sing]"); // '
			field = field.Replace("\"", "[doub]"); // "
			field = field.Replace("\\", "[slas]"); // \
			field = field.Replace("&", "[amp]"); // &

			return field;
		}

		//----------------------------------------
		// User-Entered Special Character Decoding

		protected static string DecodeEssay(string field)
		{
			field = field.Replace("[ent]", "\n"); // enter
			field = field.Replace("[sing]", "\'"); // '
			field = field.Replace("[doub]", "\""); // "
			field = field.Replace("[slas]", "\\"); // \
			field = field.Replace("[amp]", "&"); // &

			return field;
		}

		//----------------------------------------
		// Reset Values before webservice call

		protected static void NewWebserviceCall()
		{
			mReturnVal = null;
			mCounter = 0;
		}

		//----------------------------------------

		#endregion Protected Methods

		#region SplashVC

		//----------------------------------------
		// Create a new user
		// "Taken" = UserName already in use

		public static string CreateNewUser(ref AppUser appUser, User user, string promoCode)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("CreateNewUserSO", "{\"UniqFacebook\": \"" + user.UniqFacebook + "\", \"City\": \"" + user.City +
																	"\", \"StateProv\": \"" + user.StateProv + "\", \"Country\": \"" + user.Country + "\", \"Latitude\": " +
																	user.Latitude + ", \"Longitude\": " + user.Longitude + ", \"Flags\": " + user.Flags +
																	", \"UserName\": \"" + user.UserName + "\", \"EmailAddress\": \"" + user.EmailAddress +
																	"\", \"BirthDate\": \"" + user.BirthDate.Year + "-" + user.BirthDate.Month + "-" + user.BirthDate.Day +
																	"\", \"PromoCode\": \"" + promoCode + "\"}"));
				++Counter;
			}

			if (ReturnVal != "Taken" && ReturnVal != "PromoInvalid")
				appUser = GetUserWithFacebookID(user.UniqFacebook);

			return ReturnVal;
		}

		//----------------------------------------
		// Get the AppUser after Login

		public static AppUser GetUserWithFacebookID(string facebookID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetUserWithFacebookID", "{\"FacebookID\":" + facebookID + "}"));
				++Counter;
			}

			if (ReturnVal == "New User")
				return new AppUser(facebookID);
			else
				return JsonConvert.DeserializeObject<AppUser>(DecodeString(ReturnVal));
		}

		//----------------------------------------
		// Default Facebook Profile photo as Avatar

		public static string DefaultFBPhoto(ref AppUser appUser, string url)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("UploadPhoto", "{\"UserID\": " + appUser.UniqUser + ", \"IsPublic\": 1, \"PhotoURL\": \"" + url + "\"}"));
				++Counter;
			}

			// Add photo to list
			Photo newPhoto = JsonConvert.DeserializeObject<Photo>(DecodeString(ReturnVal));
			appUser.Avatar = newPhoto.HashedName;

			return "true";
		}

		//----------------------------------------

		#endregion SplashVC

		#region Visitor Popup

		//----------------------------------------
		// Add Visitors to existing visitors list

		public static string GetVisitors(int userID, List<Visitor> visitors)
		{
			int[] grabbedVisitors = visitors.Select(v => v.UniqVisitor).ToArray();

			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetVisitors", "{\"UserID\":" + userID + ", \"GrabbedUsers\":" + JsonConvert.SerializeObject(grabbedVisitors) + "}"));
				++Counter;
			}

			// Order the matches so that featured users are on the top of each page
			List<Visitor> olderVisitors = JsonConvert.DeserializeObject<List<Visitor>>(DecodeString(ReturnVal));
			visitors.AddRange(olderVisitors);

			return "true";
		}

		//added by Tony - for deleting a user with the specified facebook id
		public static string DeleteUserWithFacebookID(string facebookID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("DeleteUserWithFacebookID", "{\"FacebookID\": \"" + facebookID + "\"}"));
				++Counter;
			}

			return ReturnVal;
		}

		//----------------------------------------

		#endregion Visitor Popup

		//----------------------------------------

		#endregion Methods

		//----------------------------------------

	} // End Class: BusinessBase

} // End Namespace: Core.Business

//--------------------------------------------------------------------------------
// EOF




