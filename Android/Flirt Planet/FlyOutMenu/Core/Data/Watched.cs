//--------------------------------------------------------------------------------
//
// Core.Data.Watched.cs - 
//
// Copyright 2014 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;

//--------------------------------------------------------------------------------

namespace Core.Data
{
	[Serializable]
	public class Watched
	{
		#region Variables

		//----------------------------------------

		int mUniqWatchList;
		int mUniqUser;
		int mUniqUserWatched;
		string mUserName;
		string mHashedName;
		int mConnectionCost;

		//----------------------------------------

		#endregion

		#region Properties

		//----------------------------------------

		public int UniqWatchList
		{
			get { return mUniqWatchList; }
			set { mUniqWatchList = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int UniqUser
		{
			get { return mUniqUser; }
			set { mUniqUser = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int UniqUserWatched
		{
			get { return mUniqUserWatched; }
			set { mUniqUserWatched = Convert.ToInt32(value); }
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

		#endregion

	} // End Class: Watched

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF
