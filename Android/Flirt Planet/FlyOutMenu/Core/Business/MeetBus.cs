//--------------------------------------------------------------------------------
//
// Core.Business.MeetBus.cs - 
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
using Core.Constants;

//--------------------------------------------------------------------------------

namespace Core.Business
{
	public class MeetBus : BusinessBase
	{
		//----------------------------------------
		// Add Matches to existing matches list

		public static string GetMatchingUsers(List<Match> matches, MeetFetcher fetcher, bool onTablet)
		{
			fetcher.GrabbedUsers = matches.Select(m => m.UniqUser).ToArray();

			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetMatchingUsers", JsonConvert.SerializeObject(fetcher)));
				++Counter;
			}

			List<Match> newMatches = JsonConvert.DeserializeObject<List<Match>>(DecodeString(ReturnVal));
			int paged = (onTablet) ? 12 : 6;

			// Order the matches so that users with no avatars are on the bottom of each page
			List<Match> noAvatars = new List<Match>();
			noAvatars.AddRange(newMatches.Take(paged).OrderBy(m => m.Avatar == kImage.Avatar_Hashed).ToList());
			noAvatars.AddRange(newMatches.Skip(paged).OrderBy(m => m.Avatar == kImage.Avatar_Hashed).ToList());

			// Order the matches so that featured users are on the top of each page
			matches.AddRange(noAvatars.Take(paged).OrderByDescending(m => m.FeaturedUser).ToList());
			matches.AddRange(noAvatars.Skip(paged).OrderByDescending(m => m.FeaturedUser).ToList());

			// View FeaturedUsers (decrement shooting star items)
			int[] featuredUsers = (from f in newMatches
								   where f.FeaturedUser
								   select f.UniqUser).ToArray();

			System.Threading.ThreadPool.QueueUserWorkItem(delegate { BoostBus.ViewFeaturedUsers(featuredUsers); });

			return "true";
		}

		//----------------------------------------
		// Add CoCMatches to existing matches list
		// Returns Premature if no CoC Items are owned

		public static string GetMatchingCoCUsers(List<Match> matches, MeetFetcher fetcher, bool onTablet)
		{
			fetcher.GrabbedUsers = matches.Select(m => m.UniqUser).ToArray();

			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetMatchingCoCUsers", JsonConvert.SerializeObject(fetcher)));
				++Counter;
			}

			List<Match> newMatches = JsonConvert.DeserializeObject<List<Match>>(DecodeString(ReturnVal));
			int paged = (onTablet) ? 12 : 6;

			// Order the matches so that users with no avatars are on the bottom of each page
			List<Match> noAvatars = new List<Match>();
			noAvatars.AddRange(newMatches.Take(paged).OrderBy(m => m.Avatar == kImage.Avatar_Hashed).ToList());
			noAvatars.AddRange(newMatches.Skip(paged).OrderBy(m => m.Avatar == kImage.Avatar_Hashed).ToList());

			// Order the matches so that featured users are on the top of each page
			matches.AddRange(noAvatars.Take(paged).OrderByDescending(m => m.FeaturedUser).ToList());
			matches.AddRange(noAvatars.Skip(paged).OrderByDescending(m => m.FeaturedUser).ToList());

			// View FeaturedUsers (decrement shooting star items)
			int[] featuredUsers = (from f in newMatches
								   where f.FeaturedUser
								   select f.UniqUser).ToArray();

			System.Threading.ThreadPool.QueueUserWorkItem(delegate { BoostBus.ViewFeaturedUsers(featuredUsers); });

			return "true";
		}

		//----------------------------------------
		// Determine if the user can get Cream of the Crop users

		public static string CanGetCoC(int userID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("CanGetCoC", "{\"UserID\":" + userID + "}"));
				++Counter;
			}

			return ReturnVal;
		}

	} // End Class: MeetBus

} // End Namespace: Core.Business

//--------------------------------------------------------------------------------
// EOF
