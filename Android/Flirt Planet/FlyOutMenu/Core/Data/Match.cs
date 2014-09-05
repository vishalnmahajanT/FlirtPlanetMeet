//--------------------------------------------------------------------------------
//
// Core.Data.Match.cs - 
//
// Copyright 2013 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;

//--------------------------------------------------------------------------------

namespace Core.Data
{
	[Serializable]
	public class Match
	{
		#region Variables

		//----------------------------------------

		int mUniqUser;
		string mUserName;
		DateTime mBirthDate;
		DateTime mLastActive;
		string mRelationshipStatus;
		string mCity;
		string mStateProv;
		string mCountry;
		int mFlags;
		string mAvatar;
		int mConnectionCost;
		bool mFeaturedUser;

		//----------------------------------------

		#endregion Variables

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

		public DateTime BirthDate
		{
			get { return mBirthDate; }
			set { mBirthDate = Convert.ToDateTime(value); }
		}

		//----------------------------------------

		public DateTime LastActive
		{
			get { return mLastActive; }
			set { mLastActive = Convert.ToDateTime(value); }
		}

		//----------------------------------------

		public string RelationshipStatus
		{
			get { return mRelationshipStatus; }
			set { mRelationshipStatus = value; }
		}

		//----------------------------------------

		public string City
		{
			get { return mCity; }
			set { mCity = value; }
		}

		//----------------------------------------

		public string StateProv
		{
			get { return mStateProv; }
			set { mStateProv = value; }
		}

		//----------------------------------------

		public string Country
		{
			get { return mCountry; }
			set { mCountry = value; }
		}

		//----------------------------------------
		// Bitflag for gender/orientation
		// 1 - Male
		// 2 - Female
		// 4 - Interested in Males
		// 8 - Interested in Females

		public int Flags
		{
			get { return mFlags; }
			set { mFlags = Convert.ToInt32(value); }
		}

		//----------------------------------------
		// Hashed Avatar Filename

		public string Avatar
		{
			get { return mAvatar; }
			set { mAvatar = value; }
		}

		//----------------------------------------

		public int ConnectionCost
		{
			get { return mConnectionCost; }
			set { mConnectionCost = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public bool FeaturedUser
		{
			get { return mFeaturedUser; }
			set { mFeaturedUser = Convert.ToBoolean(value); }
		}

		//----------------------------------------

		#endregion

	} // End Class: Match

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF





