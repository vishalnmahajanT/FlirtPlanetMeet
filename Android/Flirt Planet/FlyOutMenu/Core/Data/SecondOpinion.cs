//--------------------------------------------------------------------------------
//
// Core.Data.SecondOpinion.cs - 
//
// Copyright 2014 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;

//--------------------------------------------------------------------------------

namespace Core.Data
{
	public class SecondOpinion
	{
		#region Variables

		//----------------------------------------

		int mUniqAsker;
		int mUniqUserDisplayed;
		string mLink;
		string mStatus;
		int mThumbsUp;
		int mThumbsLevel;
		int mThumbsDown;

		//----------------------------------------

		#endregion Variables

		#region Constructor

		//----------------------------------------

		public SecondOpinion(int userID, int targetID)
		{
			mUniqAsker = userID;
			mUniqUserDisplayed = targetID;
			mLink = string.Empty;
			mStatus = "Prompt";
			mThumbsUp = 0;
			mThumbsLevel = 0;
			mThumbsDown = 0;
		}

		//----------------------------------------

		#endregion Constructor

		#region Properties

		//----------------------------------------

		public int UniqAsker
		{
			get { return mUniqAsker; }
			set { mUniqAsker = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int UniqUserDisplayed
		{
			get { return mUniqUserDisplayed; }
			set { mUniqUserDisplayed = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public string Link
		{
			get { return mLink; }
			set { mLink = value; }
		}

		//----------------------------------------

		public string Status
		{
			get { return mStatus; }
			set { mStatus = value; }
		}

		//----------------------------------------

		public int ThumbsUp
		{
			get { return mThumbsUp; }
			set { mThumbsUp = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int ThumbsLevel
		{
			get { return mThumbsLevel; }
			set { mThumbsLevel = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int ThumbsDown
		{
			get { return mThumbsDown; }
			set { mThumbsDown = Convert.ToInt32(value); }
		}

		//----------------------------------------

		#endregion Properties

	} // End Class: SecondOpinion

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF





