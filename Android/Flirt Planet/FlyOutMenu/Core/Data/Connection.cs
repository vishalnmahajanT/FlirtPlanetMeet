//--------------------------------------------------------------------------------
//
// Core.Data.Connection.cs - 
//
// Copyright 2013-2014 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;

//--------------------------------------------------------------------------------

namespace Core.Data
{
	[Serializable]
	public class Connection
	{
		#region Variables

		//----------------------------------------

		int mUniqUser;
		string mUserName;
		string mAvatar;
		int mOverallCompat;
		string mSODisplayed;

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

		public int OverallCompat
		{
			get { return mOverallCompat; }
			set { mOverallCompat = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public string SODisplayed
		{
			get { return mSODisplayed; }
			set { mSODisplayed = value; }
		}

		//----------------------------------------

		#endregion

	} // End Class: Connection

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF
