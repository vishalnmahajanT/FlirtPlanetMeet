//--------------------------------------------------------------------------------
//
// Core.Data.ExternalFriend.cs - 
//
// Copyright 2014 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;

//--------------------------------------------------------------------------------

namespace Core.Data
{
	[Serializable]
	public class ExternalFriend
	{
		#region _Variables_

		//----------------------------------------

		string mFacebookID;
		int mFlirtPlanetID;
		string mName;
		string mAvatarUrl;

		//----------------------------------------

		#endregion _Variables_

		#region _Constructor_

		//----------------------------------------

		public ExternalFriend(string facebookID, string name, string avatar)
		{
			mFacebookID = facebookID;
			mName = name;
			mAvatarUrl = avatar;
		}

		//----------------------------------------

		#endregion _Constructor_

		#region _Properties_

		//----------------------------------------

		public string FacebookID
		{
			get { return mFacebookID; }
			set { mFacebookID = value; }
		}

		//----------------------------------------

		public int FlirtPlanetID
		{
			get { return mFlirtPlanetID; }
			set { mFlirtPlanetID = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public string Name
		{
			get { return mName; }
			set { mName = value; }
		}

		//----------------------------------------

		public string AvatarUrl
		{
			get { return mAvatarUrl; }
			set { mAvatarUrl = value; }
		}

		//----------------------------------------

		#endregion _Properties_

	} // End Class: ExternalFriend

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF
