//--------------------------------------------------------------------------------
//
// Core.Business.HomeBus.cs - 
//
// Copyright 2013 Game Refuge Inc
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
	public class HomeBus : BusinessBase
	{
		//----------------------------------------
		// Webservice call to get featured users.

		public static List<Match> LoadFreshFaces(int userID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetFreshFaces", "{\"UniqUser\":" + userID + "}"));
				++Counter;
			}

			return JsonConvert.DeserializeObject<List<Match>>(DecodeString(ReturnVal));
		}

		//----------------------------------------

	} // End Class: HomeBus

} // End Namespace: Core.Business

//--------------------------------------------------------------------------------
// EOF