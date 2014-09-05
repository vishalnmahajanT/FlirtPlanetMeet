//--------------------------------------------------------------------------------
//
// Core.Data.Notifications.cs - 
//
// Copyright 2013-2014 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;

//--------------------------------------------------------------------------------

namespace Core.Data
{
	public class Notifications
	{
		#region Variables

		//----------------------------------------

		int mTotalVisitors;
		int mNewVisitors;
		int mPendingConnections;
		int mNewConnections;
		int mUnreadFlirtmail;
		int mFlirtJuiceRefunds;

		//----------------------------------------

		#endregion

		#region Properties

		//----------------------------------------

		public int TotalVisitors
		{
			get { return mTotalVisitors; }
			set { mTotalVisitors = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int NewVisitors
		{
			get { return mNewVisitors; }
			set { mNewVisitors = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int PendingConnections
		{
			get { return mPendingConnections; }
			set { mPendingConnections = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int NewConnections
		{
			get { return mNewConnections; }
			set { mNewConnections = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int UnreadFlirtmail
		{
			get { return mUnreadFlirtmail; }
			set { mUnreadFlirtmail = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int FlirtJuiceRefunds
		{
			get { return mFlirtJuiceRefunds; }
			set { mFlirtJuiceRefunds = Convert.ToInt32(value); }
		}

		//----------------------------------------

		#endregion

		#region Accessor Methods

		//----------------------------------------

		public bool NewNotifications()
		{
			return ((mNewVisitors + mPendingConnections + mNewConnections + mUnreadFlirtmail) > 0);
		}

		//----------------------------------------

		#endregion

	} // End Class: Notifications

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF
