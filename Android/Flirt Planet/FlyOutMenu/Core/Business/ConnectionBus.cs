//--------------------------------------------------------------------------------
//
// Core.Business.ConnectionBus.cs - 
//
// Copyright 2013-2014 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json;
using Core.Constants;
using Core.Data;

//--------------------------------------------------------------------------------

namespace Core.Business
{
	public class ConnectionBus : BusinessBase
	{
		//----------------------------------------
		// Get all of the connections a user has

		public static List<Connection> GetUserConnections(int userID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetUserConnections", "{\"UserID\":" + userID + "}"));
				++Counter;
			}

			return JsonConvert.DeserializeObject<List<Connection>>(DecodeString(ReturnVal));
		}

		//----------------------------------------
		// Get all pending connections the user has received

		public static List<PendingConnection> GetUserPendingConnections(int userID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetUserPendingConnections", "{\"UserID\":" + userID + "}"));
				++Counter;
			}

			List<PendingConnection> pendingConnections = JsonConvert.DeserializeObject<List<PendingConnection>>(DecodeString(ReturnVal));
			pendingConnections.ForEach(p => p.MessageText = p.MessageText.Replace("\\n", "\n"));

			return pendingConnections;
		}

		//----------------------------------------
		// Get all pending connections the user has sent out

		public static List<SentConnection> GetUserSentConnections(int userID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetUserSentConnections", "{\"UserID\":" + userID + "}"));
				++Counter;
			}

			return JsonConvert.DeserializeObject<List<SentConnection>>(DecodeString(ReturnVal));
		}

		//----------------------------------------
		// Get all watched users the user has

		public static List<Watched> GetUserWatchList(int userID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetUserWatchList", "{\"UserID\":" + userID + "}"));
				++Counter;
			}

			return JsonConvert.DeserializeObject<List<Watched>>(DecodeString(ReturnVal));
		}

		//----------------------------------------
		// Accept a single connection request

		public static string AcceptConnectionRequest(List<Connection> connections, List<PendingConnection> pendingConnections, PendingConnection request)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("AcceptConnectionRequest", JsonConvert.SerializeObject(request)));
				++Counter;
			}

			Connection newConnect = JsonConvert.DeserializeObject<Connection>(DecodeString(ReturnVal));

			if (connections != null)
				connections.Add(newConnect);

			pendingConnections.Remove(request);

			return "true";
		}

		//----------------------------------------
		// Accept a list of connection requests

		public static string AcceptConnectionRequests(List<Connection> connections, List<PendingConnection> pendingConnections)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("AcceptConnectionRequests", JsonConvert.SerializeObject(pendingConnections)));
				++Counter;
			}

			List<Connection> newConnects = JsonConvert.DeserializeObject<List<Connection>>(DecodeString(ReturnVal));

			foreach (Connection connect in newConnects)
				connections.Add(connect);

			pendingConnections.Clear();

			return "true";
		}

		//----------------------------------------
		// Deny a single connection request

		public static string DenyConnectionRequest(List<PendingConnection> pendingConnections, PendingConnection request)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("DenyConnectionRequest", JsonConvert.SerializeObject(request)));
				++Counter;
			}

			if (Convert.ToBoolean(ReturnVal))
				pendingConnections.Remove(request);

			return ReturnVal;
		}

		//----------------------------------------
		// Deny a list of connection requests

		public static string DenyConnectionRequests(List<PendingConnection> pendingConnections)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("DenyConnectionRequests", JsonConvert.SerializeObject(pendingConnections)));
				++Counter;
			}

			if (Convert.ToBoolean(ReturnVal))
				pendingConnections.Clear();

			return ReturnVal;
		}

		//----------------------------------------
		// Block a Connection

		public static string BlockUser(List<Connection> connections, int userID, int targetID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("BlockUser", "{\"UserID\":" + userID + ", \"TargetID\":" + targetID + "}"));
				++Counter;
			}

			if (Convert.ToBoolean(ReturnVal))
				connections.RemoveAll(x => x.UniqUser == targetID);

			return ReturnVal;
		}

		//----------------------------------------
		// Block a Connection Request

		public static string BlockUser(List<PendingConnection> pendingConnections, int userID, int targetID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("BlockUser", "{\"UserID\":" + userID + ", \"TargetID\":" + targetID + "}"));
				++Counter;
			}

			if (Convert.ToBoolean(ReturnVal))
				pendingConnections.RemoveAll(x => x.UniqUser == targetID);

			return ReturnVal;
		}

		//----------------------------------------
		// Block a Sent Request

		public static string BlockUser(List<SentConnection> sentConnections, int userID, int targetID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("BlockUser", "{\"UserID\":" + userID + ", \"TargetID\":" + targetID + "}"));
				++Counter;
			}

			if (Convert.ToBoolean(ReturnVal))
				sentConnections.RemoveAll(x => x.UniqUser == targetID);

			return ReturnVal;
		}

		//----------------------------------------
		// Insert Connection Request
		// 1 = success, 0 = failure, -1 = low flirtjuice

		public static string InsertPendingConnection(User user, ref AppUser appUser, int priorityRequest, string message)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("InsertPendingConnection", "{\"UserID\": " + appUser.UniqUser + ", \"TargetID\":" + user.UniqUser +
																	  ", \"ConnectionCost\": " + user.ConnectionCost + ", \"PriorityRequest\": " + priorityRequest +
																	  ", \"Message\": \"" + message + "\"}"));
				++Counter;
			}

			string[] result = ReturnVal.Split(',');

			if (result.Length == 2)
			{
				user.ConnectionStatus = "P";
				appUser.FlirtJuice = Convert.ToInt32(result[1]);
			}

			return result[0];
		}

		public static string InsertPendingConnection(ref AppUser appUser, int targetID, int connectionCost, int priorityRequest, string message)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("InsertPendingConnection", "{\"UserID\": " + appUser.UniqUser + ", \"TargetID\":" + targetID +
																	  ", \"ConnectionCost\": " + connectionCost + ", \"PriorityRequest\": " + priorityRequest +
																	  ", \"Message\": \"" + message + "\"}"));
				++Counter;
			}

			string[] result = ReturnVal.Split(',');

			if (result.Length == 2)
				appUser.FlirtJuice = Convert.ToInt32(result[1]);

			return result[0];
		}

		//----------------------------------------
		// Request Second Opinion (returns url link)

		public static string RequestSecondOpinion(int userID, int targetID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("RequestSecondOpinion", "{\"UserID\":" + userID + ", \"TargetID\":" + targetID + "}"));
				++Counter;
			}

			return kBaseURL.SecondOpinion + ReturnVal;
		}

		//----------------------------------------
		// Get Second Opinion information

		public static SecondOpinion GetSecondOpinion(int userID, int targetID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetSecondOpinion", "{\"UserID\":" + userID + ", \"TargetID\":" + targetID + "}"));
				++Counter;
			}

			if (ReturnVal == "New")
				return new SecondOpinion(userID, targetID);
			else
				return JsonConvert.DeserializeObject<SecondOpinion>(DecodeString(ReturnVal));
		}

		//----------------------------------------
		// Remove user from watchlist

		public static string RemoveFromWatchlist(int userID, int watchedID, ref List<Watched> watchList)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("RemoveFromWatchlist", "{\"UserID\":" + userID + ", \"TargetID\":" + watchedID + "}"));
				++Counter;
			}

			if (Convert.ToBoolean(ReturnVal))
			{
				List<Watched> watch = (from w in watchList
									   where w.UniqUserWatched == watchedID
									   select w).ToList();

				watchList.Remove(watch[0]);
			}

			return ReturnVal;
		}

		#region _Entourage_

		//----------------------------------------
		// Grab unconnected External Friends (Facebook/Entourage)

		public static List<Entourage> GetUnconnectedExternalFriends(int userID, string friendIDs)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetUnconnectedExternalFriends", "{\"UserID\": " + userID + ", \"FriendIDs\": \"" + friendIDs + "\"}"));
				++Counter;
			}

			return JsonConvert.DeserializeObject<List<Entourage>>(DecodeString(ReturnVal));
		}

		//----------------------------------------
		// Refer Facebook Friends, returns the FlirtJuice Bonus given

		public static string ReferFacebookFriends(ref AppUser appUser, string friendIDs)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("ReferFacebookFriends", "{\"UserID\": " + appUser.UniqUser + ", \"FriendIDs\": \"" + friendIDs + "\"}"));
				++Counter;
			}

			string[] resultArr = ReturnVal.Split(',');

			if (resultArr.Length == 2)
				appUser.FlirtJuice = Convert.ToInt32(resultArr[1]);

			return resultArr[0];
		}

		//----------------------------------------
		// Get Flirt Planet Play Entourage Members

		public static string GetEntourageMembers(string facebookID, ref List<ExternalFriend> entourage)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetEntourageMembers", "{\"FacebookID\": \"" + facebookID + "\"}"));
				++Counter;
			}

			if (ReturnVal == "NoPlay") return "false";

			entourage = JsonConvert.DeserializeObject<List<ExternalFriend>>(DecodeString(ReturnVal));

			for (int i = 0; i < entourage.Count; ++i)
				entourage[i].AvatarUrl = kBaseURL.EntourageIMG + entourage[i].FlirtPlanetID + ".png";

			return "true";
		}

		//----------------------------------------
		// Removes Facebook Friends that are already in Meet

		public static string GetReferrableEntourageMembers(string facebookID, ref List<ExternalFriend> referrableFriends, string friendIDs)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetReferrableEntourageMembers", "{\"FacebookID\": \"" + facebookID + "\", \"FriendIDs\": \"" + friendIDs + "\"}"));
				++Counter;
			}

			List<ExternalFriend> existingUsers = JsonConvert.DeserializeObject<List<ExternalFriend>>(DecodeString(ReturnVal));

			for (int i = 0; i < existingUsers.Count; ++i)
				referrableFriends.RemoveAll(f => f.FacebookID == existingUsers[i].FacebookID);

			return "Success";
		}

		//----------------------------------------
		// Insert Meet Invites

		public static string ReferEntourageMembers(ref AppUser appUser, string friendIDs)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("ReferEntourageMembers", "{\"UserID\": " + appUser.UniqUser + ", \"FacebookID\": \"" + appUser.UniqFacebook +
																	"\", \"FriendIDs\": \"" + friendIDs + "\"}"));
				++Counter;
			}

			string[] resultArr = ReturnVal.Split(',');

			if (resultArr.Length == 2)
				appUser.FlirtJuice = Convert.ToInt32(resultArr[1]);

			return resultArr[0];
		}

		//----------------------------------------

		#endregion _Entourage_

		//----------------------------------------

	} // End Class: ConnectionBus

} // End Namespace: Core.Business

//--------------------------------------------------------------------------------
// EOF
