//--------------------------------------------------------------------------------
//
// Core.Data.Country.cs - 
//
// Copyright 2013 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

//--------------------------------------------------------------------------------

namespace Core.Data
{
	[Serializable]
	public class Country
	{
		#region Variables

		//----------------------------------------
		string mCountryCode;
		string mCountryName;
		List<Region> mRegions;
		//----------------------------------------

		#endregion

		#region Constructor

		//----------------------------------------

		public Country(string countryName, string countryCode)
		{
			mCountryCode = countryCode;
			mCountryName = countryName;
			mRegions = new List<Region>();
		}

		//----------------------------------------

		#endregion Constructor

		#region Properties

		//----------------------------------------

		public string CountryCode
		{
			get { return mCountryCode; }
			set { mCountryCode = value; }
		}

		//----------------------------------------

		public string CountryName
		{
			get { return mCountryName; }
			set { mCountryName = value; }
		}

		//----------------------------------------

		public List<Region> Regions
		{
			get { return mRegions; }
			set { mRegions = value; }
		}

		//----------------------------------------

		#endregion
	} // End Class: Country

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF
