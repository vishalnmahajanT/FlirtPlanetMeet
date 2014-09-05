//--------------------------------------------------------------------------------
//
// Core.Data.MatchingSauce.cs - 
//
// Copyright 2013 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;

//--------------------------------------------------------------------------------

namespace Core.Data
{
	[Serializable]
	public class MatchingSauce
	{
		#region Variables

		//----------------------------------------

		int mUniqUser;
		int mNIMPPersonality;
		int mNIMPFlirt;
		int mMyersBriggs;
		int mZodiac;
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
		string mZodiacSign;

		//----------------------------------------

		#endregion Variables

		#region Properties

		//----------------------------------------

		public int UniqUser
		{
			get { return mUniqUser; }
			set { mUniqUser = Convert.ToInt32(value); }
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

		public int MyersBriggs
		{
			get { return mMyersBriggs; }
			set { mMyersBriggs = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int Zodiac
		{
			get { return mZodiac; }
			set { mZodiac = Convert.ToInt32(value); }
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

		public string ZodiacSign
		{
			get { return mZodiacSign; }
			set { mZodiacSign = value; }
		}

		//----------------------------------------

		#endregion

	} // End Class: MatchingSauce

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF

