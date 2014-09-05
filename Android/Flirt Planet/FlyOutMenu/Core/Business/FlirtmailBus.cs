//--------------------------------------------------------------------------------
//
// Core.Business.FlirtmailBus.cs - 
//
// Copyright 2013-2014 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;
using Core.Data;

//--------------------------------------------------------------------------------

namespace Core.Business
{
	public class FlirtmailBus : BusinessBase
	{
		//----------------------------------------
		// Get all of the users Flirtmail (or only new flirtmail if sent is set)

		public static List<Flirtmail> GetFlirtmail(int userID, string sent = "All")
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetFlirtmail", "{\"UniqUser\":" + userID + ", \"Sent\":\"" + sent + "\"}"));
				++Counter;
			}

			List<Flirtmail> flirtmailList = JsonConvert.DeserializeObject<List<Flirtmail>>(DecodeString(ReturnVal));
			flirtmailList.ForEach(f => f.Message = DecodeEssay(f.Message));

			return flirtmailList;
		}

		//----------------------------------------
		// Insert Flirtmail and return newly created message.

		public static string[] InsertFlirtmailRVW(AppUser appUser, ref Flirtmail flirtmail)
		{
			NewWebserviceCall();
			flirtmail.Message = EncodeEssay(flirtmail.Message);

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("InsertFlirtmailRVW", JsonConvert.SerializeObject(flirtmail)));
				++Counter;
			}

			string[] returnInfo = ReturnVal.Split(',');

			flirtmail.UniqFlirtmail = Convert.ToInt32(returnInfo[0]);
			flirtmail.Message = DecodeEssay(flirtmail.Message);
			flirtmail.Sent = Convert.ToDateTime(returnInfo[1]);
			flirtmail.MailRead = "1";
			flirtmail.PartnerUserName = returnInfo[2];
			flirtmail.PartnerAvatar = returnInfo[3];
			flirtmail.UserName = appUser.UserName;
			flirtmail.Avatar = appUser.Avatar;

			return new string[] { returnInfo[4], returnInfo[5] };
		}

		//----------------------------------------
		// Delete Flirtmail list

		public static string DeleteFlirtmail(List<Flirtmail> flirtmailList, int[] flirtmailIDs)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("DeleteFlirtmail", "{\"FlirtmailIDs\":" + JsonConvert.SerializeObject(flirtmailIDs) + "}"));
				++Counter;
			}

			if (Convert.ToInt32(ReturnVal) > 0)
				flirtmailList.RemoveAll(x => flirtmailIDs.Contains(x.UniqFlirtmail));

			return ReturnVal;
		}

		//----------------------------------------
		// Delete Flirtmail Conversation

		public static string ClearConversation(List<Flirtmail> flirtmailList, int userID, int partnerID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("ClearConversation", "{\"UserID\":" + userID + ", \"PartnerID\":" + partnerID + "}"));
				++Counter;
			}

			if (Convert.ToInt32(ReturnVal) > 0)
				flirtmailList.RemoveAll(x => x.PartnerID == partnerID);

			return ReturnVal;
		}

		//----------------------------------------
		// Report Flirtmail list

		public static string ReportFlirtmail(List<Flirtmail> flirtmailList, int[] flirtmailIDs)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("ReportFlirtmail", "{\"FlirtmailIDs\":" + JsonConvert.SerializeObject(flirtmailIDs) + "}"));
				++Counter;
			}

			return ReturnVal;
		}

		//----------------------------------------
		// Sort Flirtmail into conversations.

		public static List<Flirtmail> SortIntoConversations(List<Flirtmail> flirtmailList)
		{
			// Long code is because LINQ's groupby is incredibly stupid
			var query = (from f in flirtmailList
						 orderby f.Sent descending
						 group f by f.PartnerID).ToList();

			List<Flirtmail> conversationList = new List<Flirtmail>();

			// Loop through stupid group by structure to get useful information
			foreach (var mailGroup in query)
			{
				foreach (Flirtmail mail in mailGroup)
				{
					conversationList.Add(mail);
					break;
				}
			}

			return conversationList;
		}

		//----------------------------------------
		// Grab individual conversation.

		public static List<Flirtmail> GrabConversation(List<Flirtmail> flirtmailList, int userID, int partnerID)
		{
			List<Flirtmail> conversation = (from f in flirtmailList
											where f.UniqSender == partnerID || f.UniqRecipient == partnerID
											orderby f.Sent
											select f).ToList();

			conversation.ForEach(f => f.MailRead = "1");
			return conversation;
		}

		//----------------------------------------
		// Mark all messages in a conversation as read

		public static void MarkConversationRead(int userID, int partnerID)
		{
			System.Threading.ThreadPool.QueueUserWorkItem(delegate
				{ WebService.CallWebservice(EncodeString("ReadFlirtmail", "{\"UserID\":" + userID + ", \"PartnerID\":" + partnerID + "}")); });
		}

		//----------------------------------------
		// Mark Second Opinion as displayed

		public static void SecondOpinionDisplayed(int userID, int partnerID)
		{
			System.Threading.ThreadPool.QueueUserWorkItem(delegate
				{ WebService.CallWebservice(EncodeString("SecondOpinionDisplayed", "{\"UserID\":" + userID + ", \"PartnerID\":" + partnerID + "}")); });
		}

		//----------------------------------------

	} // End Class: FlirtmailBus

} // End Namespace: Core.Business

//--------------------------------------------------------------------------------
// EOF




