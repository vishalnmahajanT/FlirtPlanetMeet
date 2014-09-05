//--------------------------------------------------------------------------------
//
// Core.Data.PendingConnection.cs - 
//
// Copyright 2013 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;

//--------------------------------------------------------------------------------

namespace Core.Data
{
	[Serializable]
	public class PendingConnection
	{
		#region Variables

		//----------------------------------------

		int mUniqUser;
		int mUserID;
		string mUserName;
		string mAvatar;
		string mPriorityRequest;
		string mMessageText;

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

		public string PriorityRequest
		{
			get { return mPriorityRequest; }
			set { mPriorityRequest = value; }
		}

		//----------------------------------------

		public string MessageText
		{
			get { return mMessageText; }
			set { mMessageText = value; }
		}

		//----------------------------------------

		#endregion

	} // End Class: PendingConnection

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF