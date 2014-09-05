//--------------------------------------------------------------------------------
//
// Core.Data.AppUser.cs - 
//
// Copyright 2013 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;
using Core.Constants;

//--------------------------------------------------------------------------------

namespace Core.Data
{
	public class AppUser
	{
		#region Variables

		//----------------------------------------

		int mUniqUser;
		string mUniqFacebook;
		string mUserName;
		DateTime mBirthDate;
		string mEmailAddress;
		string mCity;
		string mStateProv;
		string mCountry;
		double mLatitude;
		double mLongitude;
		int mAndroidFlirtGold;
		int mFlirtJuice;
		int mFlags;
		int mPriv;
		string mUnavailable;
		string mZodiacSign;
		string mAvatar = kImage.Avatar_Hashed;

		//----------------------------------------

		#endregion

		#region Constructor

		//----------------------------------------

		public AppUser(string facebookID)
		{
			mUniqUser = -1;
			mUniqFacebook = facebookID;
		}

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

		public string UniqFacebook
		{
			get { return mUniqFacebook; }
			set { mUniqFacebook = value; }
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

		public string EmailAddress
		{
			get { return mEmailAddress; }
			set { mEmailAddress = value; }
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
			set { mLatitude = Convert.ToDouble(value); }
		}

		//----------------------------------------

		public double Longitude
		{
			get { return mLongitude; }
			set { mLongitude = Convert.ToDouble(value); }
		}

		//----------------------------------------

		public int Android_FlirtGold
		{
			get { return mAndroidFlirtGold; }
			set { mAndroidFlirtGold = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int FlirtJuice
		{
			get { return mFlirtJuice; }
			set { mFlirtJuice = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int Flags
		{
			get { return mFlags; }
			set { mFlags = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int Priv
		{
			get { return mPriv; }
			set { mPriv = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public string Unavailable
		{
			get { return mUnavailable; }
			set { mUnavailable = value; }
		}

		//----------------------------------------

		public string ZodiacSign
		{
			get { return mZodiacSign; }
			set { mZodiacSign = value; }
		}

		//----------------------------------------

		public string Avatar
		{
			get { return mAvatar; }
			set { mAvatar = value; }
		}

		//----------------------------------------

		#endregion

		#region Accessor Methods

		//----------------------------------------

		public int GetAge()
		{
			DateTime today = DateTime.Today;
			int age = today.Year - mBirthDate.Year;

			if (today.Month < mBirthDate.Month)
				age--;
			else if (today.Month == mBirthDate.Month && today.Day < mBirthDate.Day)
				age--;

			return age;
		}

		//----------------------------------------

		public string GetGender()
		{
			return (mFlags & 1) == 1 ? "Male" : "Female";
		}

		//----------------------------------------

		public void UpdateFromUser(User user)
		{
			mBirthDate = user.BirthDate;
			mCity = user.City;
			mStateProv = user.StateProv;
			mCountry = user.Country;
			mLatitude = user.Latitude;
			mLongitude = user.Longitude;
			mAndroidFlirtGold = user.Android_FlirtGold;
			//mFlirtJuice = user.FlirtJuice;
			mFlags = user.Flags;
		}

		//----------------------------------------

		#endregion

	} // End Class: AppUser

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF





