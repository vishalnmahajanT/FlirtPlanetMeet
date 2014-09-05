//--------------------------------------------------------------------------------
//
// Core.Business.MatchingSauceBus.cs - 
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
	public class MatchingSauceBus : BusinessBase
	{
		//----------------------------------------
		// Get user Matching Sauce percentages

		public static MatchingSauce GetMatchingSauce(int userID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetMatchingSauce", "{\"UserID\":" + userID + "}"));
				++Counter;
			}

			return JsonConvert.DeserializeObject<MatchingSauce>(DecodeString(ReturnVal));
		}

		//----------------------------------------
		// Get user Matching Sauce percentages

		public static string UpdateMatchingSauce(MatchingSauce matchingSauce)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("UpdateMatchingSauce", JsonConvert.SerializeObject(matchingSauce)));
				++Counter;
			}

			System.Threading.ThreadPool.QueueUserWorkItem(delegate
			{ WebService.CallWebservice(EncodeString("UpdateConnectionCompats", "{\"UserID\":" + matchingSauce.UniqUser + "}")); });

			return ReturnVal;
		}

		//----------------------------------------
		// Get what NIMP block the user has completed
		// Returns: array[0] == previously completed block, array[1] == users dominate hand (if set)

		public static string[] GetNIMPValues(int userID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetNIMPValues", "{\"UserID\": " + userID + "}"));
				++Counter;
			}

			return ReturnVal.Split(',');
		}

		//----------------------------------------
		// Complete NIMP Block

		public static string[] CompleteNIMPBlockGoal(ref AppUser appUser, string handed, string results, ref List<Goal> goals)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("CompleteNIMPBlockGoal", "{\"Results\": \"" + results + "\", \"FacebookID\": \"" + appUser.UniqFacebook +
																	"\", \"Handed\": \"" + handed + "\", \"Gender\": \"" + appUser.GetGender().Substring(0, 1) +
																	"\", \"Age\": " + appUser.GetAge() + ", \"Goal\": \"" + goals[4].Completed + "\"}"));
				++Counter;
			}

			string[] resultArr = ReturnVal.Split(',');

			if (resultArr.Length > 1)
			{
				appUser.FlirtJuice = Convert.ToInt32(resultArr[1]);

				if (resultArr[2] == "true")
					goals[4].ClearGoal();
			}

			return resultArr;
		}

		//----------------------------------------
		// Update NIMP Preference values

		public static string[] UpdateNIMPPreferencesGoal(ref AppUser appUser, string extraversion, string agreeable, string conscience, string neurotic,
													   string openness, string traditional, string physical, string sincere, string playful, string polite, ref List<Goal> goals)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("UpdateNIMPPreferencesGoal", "{\"UserID\": " + appUser.UniqUser + ",\"FacebookID\": \"" + appUser.UniqFacebook + "\"" +
																	",\"Extraversion\": \"" + extraversion + "\",\"Agreeable\": \"" + agreeable + "\"" +
																	",\"Conscience\": \"" + conscience + "\",\"Neurotic\": \"" + neurotic + "\"" +
																	",\"Openness\": \"" + openness + "\",\"Traditional\": \"" + traditional + "\"" +
																	",\"Physical\": \"" + physical + "\",\"Sincere\": \"" + sincere + "\"" +
																	",\"Playful\": \"" + playful + "\",\"Polite\": \"" + polite + "\", \"Goal\": \"" + goals[4].Completed + "\"}"));
				++Counter;
			}

			string[] resultArr = ReturnVal.Split(',');

			if (resultArr.Length > 1)
			{
				appUser.FlirtJuice = Convert.ToInt32(resultArr[1]);

				if (resultArr[2] == "true")
					goals[4].ClearGoal();
			}

			return resultArr;
		}

		//----------------------------------------

	} // End Class: MatchingSauceBus

} // End Namespace: Core.Business

//--------------------------------------------------------------------------------
// EOF
