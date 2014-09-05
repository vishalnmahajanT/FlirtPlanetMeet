//--------------------------------------------------------------------------------
//
// Core.Data.Review.cs - 
//
// Copyright 2014 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;

//--------------------------------------------------------------------------------

namespace Core.Data
{
	[Serializable]
	public class Review
	{
		#region Variables

		//----------------------------------------
		int mUniqUserReview;
		string mReviewText;
		int mPositive;
		DateTime mWhenReviewed;
		int mUniqUser;
		string mUserName;
		string mHashedName;
		//----------------------------------------

		#endregion

		#region Constructor

		//----------------------------------------

		public Review()
		{

		}

		//----------------------------------------

		#endregion Constructor

		#region Properties

		//----------------------------------------

		public int UniqUserReview
		{
			get { return mUniqUserReview; }
			set { mUniqUserReview = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public string ReviewText
		{
			get { return mReviewText; }
			set { mReviewText = value; }
		}

		//----------------------------------------

		public int Positive
		{
			get { return mPositive; }
			set { mPositive = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public DateTime WhenReviewed
		{
			get { return mWhenReviewed; }
			set { mWhenReviewed = Convert.ToDateTime(value); }
		}

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

		public string HashedName
		{
			get { return mHashedName; }
			set { mHashedName = value; }
		}

		//----------------------------------------

		#endregion
	} // End Class: Review

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF
