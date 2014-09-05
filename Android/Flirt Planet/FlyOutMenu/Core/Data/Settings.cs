//--------------------------------------------------------------------------------
//
// Core.Data.Settings.cs - 
//
// Copyright 2014 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;

//--------------------------------------------------------------------------------

namespace Core.Data
{
	[Serializable]
	public class Settings
	{
		#region Variables

		//----------------------------------------

		int mUserID;
		bool mPushFMAIL;
		bool mPushRFILL;

		//----------------------------------------

		#endregion Variables

		#region Properties

		//----------------------------------------

		public int UserID
		{
			get { return mUserID; }
			set { mUserID = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public bool PushFMAIL
		{
			get { return mPushFMAIL; }
			set { mPushFMAIL = Convert.ToBoolean(value); }
		}

		//----------------------------------------

		public bool PushRFILL
		{
			get { return mPushRFILL; }
			set { mPushRFILL = Convert.ToBoolean(value); }
		}

		//----------------------------------------

		#endregion Properties

	} // End Class: Settings

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF

