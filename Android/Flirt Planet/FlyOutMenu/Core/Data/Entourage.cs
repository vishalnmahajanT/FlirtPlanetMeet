//--------------------------------------------------------------------------------
//
// Core.Data.Entourage.cs - 
//
// Copyright 2014 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;

//--------------------------------------------------------------------------------

namespace Core.Data
{
	[Serializable]
	public class Entourage
	{
		#region _Variables_

		//----------------------------------------

		int mUniqUser;
		string mUserName;
		string mHashedName;
		int mConnectionCost;

		//----------------------------------------

		#endregion _Variables_

		#region _Properties_

		//----------------------------------------

		public int UniqUser
		{
			get { return mUniqUser; }
			set { mUniqUser = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public string UserName
		{
			get { return mUserName; }
			set { mUserName = value; }
		}

		//----------------------------------------

		public string HashedName
		{
			get { return mHashedName; }
			set { mHashedName = value; }
		}

		//----------------------------------------

		public int ConnectionCost
		{
			get { return mConnectionCost; }
			set { mConnectionCost = Convert.ToInt32(value); }
		}

		//----------------------------------------

		#endregion _Properties_

	} // End Class: Entourage

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF
