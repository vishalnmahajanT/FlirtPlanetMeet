//--------------------------------------------------------------------------------
//
// Core.Data.Visitor.cs - 
//
// Copyright 2014 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;

//--------------------------------------------------------------------------------

namespace Core.Data
{
	[Serializable]
	public class Visitor
	{
		#region Variables

		//----------------------------------------

		int mUniqVisitor;
		int mUniqUserVisitor;
		DateTime mWhenVisited;
		string mUserName;
		string mHashedName;

		//----------------------------------------

		#endregion

		#region Properties

		//----------------------------------------

		public int UniqVisitor
		{
			get { return mUniqVisitor; }
			set { mUniqVisitor = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int UniqUserVisitor
		{
			get { return mUniqUserVisitor; }
			set { mUniqUserVisitor = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public DateTime WhenVisited
		{
			get { return mWhenVisited; }
			set { mWhenVisited = Convert.ToDateTime(value); }
		}

		//----------------------------------------

		public string UserName
		{
			get { return mUserName; }
			set { mUserName = value; }
		}

		//----------------------------------------

		public string HashedName
		{
			get { return mHashedName; }
			set { mHashedName = value; }
		}

		//----------------------------------------

		#endregion

	} // End Class: Visitor

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF
