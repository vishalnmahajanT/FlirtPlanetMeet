//--------------------------------------------------------------------------------
//
// Core.Data.SentConnection.cs - 
//
// Copyright 2013 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;

//--------------------------------------------------------------------------------

namespace Core.Data
{
	[Serializable]
	public class SentConnection
	{
		#region Variables

		//----------------------------------------

		int mUniqUser;
		int mUserID;
		string mUserName;
		string mAvatar;
		DateTime mRequestSent;

		//----------------------------------------

		#endregion

		#region Properties

		//----------------------------------------

		public int UniqUser
		{
			get { return mUniqUser; }
			set { mUniqUser = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int UserID
		{
			get { return mUserID; }
			set { mUserID = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public string UserName
		{
			get { return mUserName; }
			set { mUserName = value; }
		}

		//----------------------------------------

		public string Avatar
		{
			get { return mAvatar; }
			set { mAvatar = value; }
		}

		//----------------------------------------

		public DateTime RequestSent
		{
			get { return mRequestSent; }
			set { mRequestSent = Convert.ToDateTime(value); }
		}

		//----------------------------------------

		#endregion

	} // End Class: SentConnection

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF