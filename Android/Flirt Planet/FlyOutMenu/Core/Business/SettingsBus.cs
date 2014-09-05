//--------------------------------------------------------------------------------
//
// Core.Business.SettingsBus.cs - 
//
// Copyright 2014 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;

using Newtonsoft.Json;
using Core.Data;

//--------------------------------------------------------------------------------

namespace Core.Business
{
	public class SettingsBus : BusinessBase
	{
		//----------------------------------------
		// Grab a users settings

		public static Settings GetUserSettings(int userID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetUserSettings", "{\"UserID\":" + userID + "}"));
				++Counter;
			}

			return JsonConvert.DeserializeObject<Settings>(DecodeString(ReturnVal));
		}

		//----------------------------------------
		// Update Push Notification values

		public static string UpdatePushSettings(Settings settings)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("UpdatePushSettings", JsonConvert.SerializeObject(settings)));
				++Counter;
			}

			return ReturnVal;
		}

	} // End Class: SettingsBus

} // End Namespace: Core.Business

//--------------------------------------------------------------------------------
// EOF
