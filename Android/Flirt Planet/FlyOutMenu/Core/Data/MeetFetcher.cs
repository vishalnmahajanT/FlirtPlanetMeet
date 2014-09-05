//--------------------------------------------------------------------------------
//
// Core.Data.MeetFetcher.cs - 
//
// Copyright 2013-2014 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;

//--------------------------------------------------------------------------------

namespace Core.Data
{
	public class MeetFetcher
	{
		#region Variables

		//----------------------------------------

		int mUserID;
		int mMinAge;
		int mMaxAge;
		double mMinHeight;
		double mMaxHeight;
		string mCity;
		string mStateProv;
		string mCountry;
		double mLatitude;
		double mLongitude;
		int mDistance;
		string mRelationshipStatus;
		int mLastActive;
		int mFlags;
		int[] mGrabbedUsers;

		//----------------------------------------

		#endregion

		#region Constructor

		//----------------------------------------

		public MeetFetcher(AppUser appUser)
		{
			mUserID = appUser.UniqUser;

			if (((appUser.Flags & 12) != 12))
				mFlags += ((appUser.Flags & 4) == 4) ? 1 : 2;

			mFlags += ((appUser.Flags & 1) == 1) ? 4 : 8;

			mMinAge = 18;
			mMaxAge = 99;
			mMinHeight = 0;
			mMaxHeight = 244;
			mRelationshipStatus = "Any";
			mLastActive = -1;
			mLatitude = appUser.Latitude;
			mLongitude = appUser.Longitude;
			mDistance = -1;
		}

		//----------------------------------------

		#endregion Constructor

		#region Properties

		//----------------------------------------
		// Searching users ID

		public int UserID
		{
			get { return mUserID; }
			set { mUserID = value; }
		}

		//----------------------------------------

		public int MinAge
		{
			get { return mMinAge; }
			set { mMinAge = value; }
		}

		//----------------------------------------

		public int MaxAge
		{
			get { return mMaxAge; }
			set { mMaxAge = value; }
		}

		//----------------------------------------
		// Min Height in cm

		public double MinHeight
		{
			get { return mMinHeight; }
			set { mMinHeight = value; }
		}

		//----------------------------------------
		// Max Height in cm

		public double MaxHeight
		{
			get { return mMaxHeight; }
			set { mMaxHeight = value; }
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

		public double Latitude
		{
			get { return mLatitude; }
			set { mLatitude = value; }
		}

		//----------------------------------------

		public double Longitude
		{
			get { return mLongitude; }
			set { mLongitude = value; }
		}

		//----------------------------------------
		// Distance in miles

		public int Distance
		{
			get { return mDistance; }
			set { mDistance = value; }
		}

		//----------------------------------------

		public string RelationshipStatus
		{
			get { return mRelationshipStatus; }
			set { mRelationshipStatus = value; }
		}

		//----------------------------------------
		// Days

		public int LastActive
		{
			get { return mLastActive; }
			set { mLastActive = value; }
		}

		//----------------------------------------

		public int Flags
		{
			get { return mFlags; }
			set { mFlags = value; }
		}

		//----------------------------------------

		public int[] GrabbedUsers
		{
			get { return mGrabbedUsers; }
			set { mGrabbedUsers = value; }
		}

		//----------------------------------------

		#endregion

		#region Accessor Methods

		//----------------------------------------

		public void SetFlags(string searchValue)
		{
			switch (searchValue)
			{
				case "Males looking for Males":
					mFlags = 5;
					break;
				case "Males looking for Females":
					mFlags = 9;
					break;
				case "Females looking for Males":
					mFlags = 6;
					break;
				case "Females looking for Females":
					mFlags = 10;
					break;
				case "Anyone looking for Males":
					mFlags = 4;
					break;
				case "Anyone looking for Females":
					mFlags = 8;
					break;
			}

		}

		//----------------------------------------

		public string GetDefaultLookingFor()
		{
			string lookingFor = string.Empty;

			switch (mFlags)
			{
				case 4:
					lookingFor = "Anyone looking for Males";
					break;
				case 5:
					lookingFor = "Males looking for Males";
					break;
				case 6:
					lookingFor = "Females looking for Males";
					break;
				case 8:
					lookingFor = "Anyone looking for Females";
					break;
				case 9:
					lookingFor = "Males looking for Females";
					break;
				case 10:
					lookingFor = "Females looking for Females";
					break;
			}

			return lookingFor;
		}

		//----------------------------------------

		public void SetLocation(Location location)
		{
			mCity = location.City;
			mStateProv = location.Region;
			mCountry = location.Country;
			mLatitude = location.Latitude;
			mLongitude = location.Longitude;
		}

		//----------------------------------------

		#endregion

	} // End Class: MeetFetcher

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF





