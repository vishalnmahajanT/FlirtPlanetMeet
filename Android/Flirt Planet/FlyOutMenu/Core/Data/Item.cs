//--------------------------------------------------------------------------------
//
// Core.Data.Item.cs - 
//
// Copyright 2013-2014 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;

//--------------------------------------------------------------------------------

namespace Core.Data
{
	[Serializable]
	public class Item
	{

		#region _Variables_

		//----------------------------------------

		int mUniqItem;
		string mItemName;
		string mItemDescription;
		int mUniqFeature;
		string mFeatureName;
		string mFeatureDescription;
		int mUses;
		int mCost;
		string mItemType;
		int mUsesLeft;
		string mActive;

		//----------------------------------------

		#endregion _Variables_

		#region _Properties_

		//----------------------------------------

		public int UniqItem
		{
			get { return mUniqItem; }
			set { mUniqItem = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public string ItemName
		{
			get { return mItemName; }
			set { mItemName = value; }
		}

		//----------------------------------------

		public string ItemDescription
		{
			get { return mItemDescription; }
			set { mItemDescription = value; }
		}

		//----------------------------------------

		public int UniqFeature
		{
			get { return mUniqFeature; }
			set { mUniqFeature = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public string FeatureName
		{
			get { return mFeatureName; }
			set { mFeatureName = value; }
		}

		//----------------------------------------

		public string FeatureDescription
		{
			get { return mFeatureDescription; }
			set { mFeatureDescription = value; }
		}

		//----------------------------------------

		public int Uses
		{
			get { return mUses; }
			set { mUses = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int Cost
		{
			get { return mCost; }
			set { mCost = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public string ItemType
		{
			get { return mItemType; }
			set { mItemType = value; }
		}

		//----------------------------------------

		public int UsesLeft
		{
			get { return mUsesLeft; }
			set { mUsesLeft = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public string Active
		{
			get { return mActive; }
			set { mActive = value; }
		}

		//----------------------------------------

		#endregion _Properties_

	} // End Class: Item

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF
