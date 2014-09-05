//--------------------------------------------------------------------------------
//
// Core.Data.Location.cs - 
//
// Copyright 2013 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;

//--------------------------------------------------------------------------------

namespace Core.Data
{
	[Serializable]
	public class Location
	{
		#region Variables

		//----------------------------------------
		string mCity;
		string mRegion;
		string mCountry;
		double mLatitude;
		double mLongitude;
		//----------------------------------------

		#endregion

		#region Constructor

		//----------------------------------------

		public Location(string city, string region, string country, double latitude, double longitude)
		{
			mCity = city;
			mRegion = region;
			mCountry = country;
			mLatitude = latitude;
			mLongitude = longitude;
		}

		//----------------------------------------

		#endregion

		#region Properties

		//----------------------------------------

		public string City
		{
			get { return mCity; }
			set { mCity = value; }
		}

		//----------------------------------------

		public string Region
		{
			get { return mRegion; }
			set { mRegion = value; }
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

		#endregion
	} // End Class: Location

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF
