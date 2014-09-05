//--------------------------------------------------------------------------------
//
// Core.Data.Region.cs - 
//
// Copyright 2013 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;

//--------------------------------------------------------------------------------

namespace Core.Data
{
	[Serializable]
	public class Region
	{
		#region Variables

		//----------------------------------------
		string mRegionCode;
		string mRegionName;
		//----------------------------------------

		#endregion

		#region Constructor

		//----------------------------------------

		public Region(string regionCode, string regionName)
		{
			mRegionCode = regionCode;
			mRegionName = regionName;
		}

		//----------------------------------------

		#endregion Constructor

		#region Properties

		//----------------------------------------

		public string RegionCode
		{
			get { return mRegionCode; }
			set { mRegionCode = value; }
		}

		//----------------------------------------

		public string RegionName
		{
			get { return mRegionName; }
			set { mRegionName = value; }
		}

		//----------------------------------------

		#endregion
	} // End Class: Region

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF
