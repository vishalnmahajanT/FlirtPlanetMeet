//--------------------------------------------------------------------------------
//
// Core.Data.User.cs - 
//
// Copyright 2013-2014 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

using Core.Constants;

//--------------------------------------------------------------------------------

namespace Core.Data
{
	[Serializable]
	public class User
	{
		#region Variables

		//----------------------------------------

		int mUniqUser;
		string mUniqFacebook;
		string mUserName;
		DateTime mBirthDate;
		string mEmailAddress;
		DateTime mLastActive;
		string mAboutMe;
		string mGoalsInLife;
		string mTalents;
		string mMattersToMe;
		string mLookingFor;
		string mInterests;
		string mConnectToMe;
		string mRelationshipStatus;
		double mHeight;
		string mCity;
		string mStateProv;
		string mCountry;
		double mLatitude;
		double mLongitude;
		int mAndroidFlirtGold;
		int mFlirtJuice;
		int mFlirtJuicePacksUsed;
		int mRefundFlirtJuice;
		int mRefundFlirtJuiceCap;
		int mEntourageSize;
		string mMyersBriggsType;
		string mZodiacSign;
		double mStanding;
		int mFlags;
		int mPriv;
		string mUnavailable;
		int mConnectionCost;
		string mAvatar = kImage.Avatar_Hashed;
		string mCoverPhoto;
		int mRating;
		string mReRated;
		int mPublicPhotoCapacity;
		int mPrivatePhotoCapacity;
		string mWatched;
		int mNumberOfConnections;
		string mHideConnectionsActive;
		int mPositiveReviewPercent;

		Photo[] mPhotoArr;
		List<Photo> mPhotos = new List<Photo>();

		DetailAnswer[] mDetailAnswerArr;
		List<DetailAnswer> mDetailAnswers = new List<DetailAnswer>();

		#region ConnectedVariables

		//----------------------------------------

		string mViewPrivateGallery;
		int mMyersBriggs;
		int mNIMPPersonality;
		int mNIMPFlirt;
		int mMoonIt;
		string mMoonItTitle;
		string mMoonItText;
		int mOverallCompat;
		int mCanReview;
		string mConnectionStatus;
		string mExtraversion;
		string mAgreeable;
		string mConscience;
		string mNeurotic;
		string mOpenness;
		string mTraditional;
		string mPhysical;
		string mSincere;
		string mPlayful;
		string mPolite;

		//----------------------------------------

		#endregion

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

		public DateTime LastActive
		{
			get { return mLastActive; }
			set { mLastActive = Convert.ToDateTime(value); }
		}

		//----------------------------------------

		public string AboutMe
		{
			get { return mAboutMe; }
			set { mAboutMe = value; }
		}

		//----------------------------------------

		public string GoalsInLife
		{
			get { return mGoalsInLife; }
			set { mGoalsInLife = value; }
		}

		//----------------------------------------

		public string Talents
		{
			get { return mTalents; }
			set { mTalents = value; }
		}

		//----------------------------------------

		public string MattersToMe
		{
			get { return mMattersToMe; }
			set { mMattersToMe = value; }
		}

		//----------------------------------------

		public string LookingFor
		{
			get { return mLookingFor; }
			set { mLookingFor = value; }
		}

		//----------------------------------------

		public string Interests
		{
			get { return mInterests; }
			set { mInterests = value; }
		}

		//----------------------------------------

		public string ConnectToMe
		{
			get { return mConnectToMe; }
			set { mConnectToMe = value; }
		}

		//----------------------------------------

		public string RelationshipStatus
		{
			get { return mRelationshipStatus; }
			set { mRelationshipStatus = value; }
		}

		//----------------------------------------

		public double Height
		{
			get { return mHeight; }
			set { mHeight = Convert.ToDouble(value); }
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

		public int FlirtJuicePacksUsed
		{
			get { return mFlirtJuicePacksUsed; }
			set { mFlirtJuicePacksUsed = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int RefundFlirtJuice
		{
			get { return mRefundFlirtJuice; }
			set { mRefundFlirtJuice = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int RefundFlirtJuiceCap
		{
			get { return mRefundFlirtJuiceCap; }
			set { mRefundFlirtJuiceCap = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int EntourageSize
		{
			get { return mEntourageSize; }
			set { mEntourageSize = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public string MyersBriggsType
		{
			get { return mMyersBriggsType; }
			set { mMyersBriggsType = value; }
		}

		//----------------------------------------

		public string ZodiacSign
		{
			get { return mZodiacSign; }
			set { mZodiacSign = value; }
		}

		//----------------------------------------

		public double Standing
		{
			get { return mStanding; }
			set { mStanding = Convert.ToDouble(value); }
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

		public int ConnectionCost
		{
			get { return mConnectionCost; }
			set { mConnectionCost = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public string Avatar
		{
			get { return mAvatar; }
			set { mAvatar = value; }
		}

		//----------------------------------------

		public string CoverPhoto
		{
			get { return mCoverPhoto; }
			set { mCoverPhoto = value; }
		}

		//----------------------------------------

		public int Rating
		{
			get { return mRating; }
			set { mRating = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public string ReRated
		{
			get { return mReRated; }
			set { mReRated = value; }
		}

		//----------------------------------------

		public int PublicPhotoCapacity
		{
			get { return mPublicPhotoCapacity; }
			set { mPublicPhotoCapacity = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int PrivatePhotoCapacity
		{
			get { return mPrivatePhotoCapacity; }
			set { mPrivatePhotoCapacity = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public string Watched
		{
			get { return mWatched; }
			set { mWatched = value; }
		}

		//----------------------------------------

		public int NumberOfConnections
		{
			get { return mNumberOfConnections; }
			set { mNumberOfConnections = Convert.ToInt32(value); }
		}

		//----------------------------------------
		// -1 = Not Owned, 0 = InActive, 1 = Active

		public string HideConnectionsActive
		{
			get { return mHideConnectionsActive; }
			set { mHideConnectionsActive = value; }
		}

		//----------------------------------------

		public int PositiveReviewPercent
		{
			get { return mPositiveReviewPercent; }
			set { mPositiveReviewPercent = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public Photo[] PhotoArr
		{
			set
			{
				mPhotoArr = value;

				for (int i = 0; i < mPhotoArr.Length; ++i)
					mPhotos.Add(mPhotoArr[i]);

				mPhotoArr = null;
			}
		}

		//----------------------------------------

		public List<Photo> Photos
		{
			get { return mPhotos; }
			set { mPhotos = value; }
		}

		//----------------------------------------

		public DetailAnswer[] DetailAnswerArr
		{
			set
			{
				mDetailAnswerArr = value;

				for (int i = 0; i < mDetailAnswerArr.Length; ++i)
					mDetailAnswers.Add(mDetailAnswerArr[i]);

				mDetailAnswerArr = null;
			}
		}

		//----------------------------------------

		public List<DetailAnswer> DetailAnswers
		{
			get { return mDetailAnswers; }
			set { mDetailAnswers = value; }
		}

		//----------------------------------------

		#region ConnectedProperties

		//----------------------------------------

		public string ViewPrivateGallery
		{
			get { return mViewPrivateGallery; }
			set { mViewPrivateGallery = value; }
		}

		//----------------------------------------

		public int MyersBriggs
		{
			get { return mMyersBriggs; }
			set { mMyersBriggs = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int NIMPPersonality
		{
			get { return mNIMPPersonality; }
			set { mNIMPPersonality = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int NIMPFlirt
		{
			get { return mNIMPFlirt; }
			set { mNIMPFlirt = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int MoonIt
		{
			get { return mMoonIt; }
			set { mMoonIt = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public string MoonItTitle
		{
			get { return mMoonItTitle; }
			set { mMoonItTitle = value; }
		}

		//----------------------------------------

		public string MoonItText
		{
			get { return mMoonItText; }
			set { mMoonItText = value; }
		}

		//----------------------------------------

		public int OverallCompat
		{
			get { return mOverallCompat; }
			set { mOverallCompat = Convert.ToInt32(value); }
		}

		//----------------------------------------
		// 0 = Can't Review: Not enough flirtmail sent from other user
		// 1 = Can give a Review
		// 2 = Already gave a Review

		public int CanReview
		{
			get { return mCanReview; }
			set { mCanReview = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public string ConnectionStatus
		{
			get { return mConnectionStatus; }
			set { mConnectionStatus = value; }
		}

		//----------------------------------------

		public string Extraversion
		{
			get { return mExtraversion; }
			set { mExtraversion = value; }
		}

		//----------------------------------------

		public string Agreeable
		{
			get { return mAgreeable; }
			set { mAgreeable = value; }
		}

		//----------------------------------------

		public string Conscience
		{
			get { return mConscience; }
			set { mConscience = value; }
		}

		//----------------------------------------

		public string Neurotic
		{
			get { return mNeurotic; }
			set { mNeurotic = value; }
		}

		//----------------------------------------

		public string Openness
		{
			get { return mOpenness; }
			set { mOpenness = value; }
		}

		//----------------------------------------

		public string Traditional
		{
			get { return mTraditional; }
			set { mTraditional = value; }
		}

		//----------------------------------------

		public string Physical
		{
			get { return mPhysical; }
			set { mPhysical = value; }
		}

		//----------------------------------------

		public string Sincere
		{
			get { return mSincere; }
			set { mSincere = value; }
		}

		//----------------------------------------

		public string Playful
		{
			get { return mPlayful; }
			set { mPlayful = value; }
		}

		//----------------------------------------

		public string Polite
		{
			get { return mPolite; }
			set { mPolite = value; }
		}

		//----------------------------------------

		#endregion

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

		public string GetOrientation()
		{
			string orientation;

			if ((mFlags & 12) == 12)
				orientation = "Bisexual";
			else if (((mFlags & 5) == 5))
				orientation = "Gay";
			else if (((mFlags & 10) == 10))
				orientation = "Lesbian";
			else
				orientation = "Straight";

			return orientation;
		}

		//----------------------------------------

		public void UpdateFlags(string gender, string orientation)
		{
			int flags = 0;

			flags += (gender == "Male" || gender == "male") ? 1 : 2;

			if (orientation == "Bisexual" || orientation == "bisexual")
				flags += 12;
			else if (orientation == "Straight" || orientation == "straight")
				flags += (gender == "Male" || gender == "male") ? 8 : 4;
			else
				flags += (gender == "Male" || gender == "male") ? 4 : 8;

			mFlags = flags;
		}

		//----------------------------------------

		public void UpdateFlags(string gender, string[] orientation)
		{
			int flags = 0;

			flags += (gender == "male") ? 1 : 2;

			if (orientation.Length == 0)
				flags += (gender == "male") ? 8 : 4;
			else
				for (int i = 0; i < orientation.Length; ++i)
					flags += (orientation[i] == "male") ? 4 : 8;

			mFlags = flags;
		}

		//----------------------------------------
		// height[0] = feet, height[1] = inches

		public int[] GetImperialHeight()
		{
			int[] height = new int[2];

			double totalInches = mHeight * .3937008;
			height[0] = (int)totalInches / 12;
			height[1] = (int)Math.Round(totalInches % 12);

			if (height[1] == 12)
			{
				height[0] += 1;
				height[1] = 0;
			}

			return height;
		}

		//----------------------------------------

		public void SetImperialHeight(int feet, int inches)
		{
			mHeight = ((feet * 12) + inches) * 2.54;
		}

		//----------------------------------------

		public void UpdateUserAnswer(int questionAnswerID, int answerID, string answerText)
		{
			for (int i = 0; i < mDetailAnswers.Count; ++i)
			{
				if (mDetailAnswers[i].UniqUserQuestionAnswer == questionAnswerID)
				{
					mDetailAnswers[i].UniqUserAnswer = answerID;
					mDetailAnswers[i].AnswerText = answerText;
				}
			}
		}

		//----------------------------------------

		#endregion

	} // End Class: User

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF




