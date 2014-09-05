//--------------------------------------------------------------------------------
//
// Core.Data.Goal.cs - 
//
// Copyright 2014 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;
using Core.Constants;

//--------------------------------------------------------------------------------

namespace Core.Data
{
	[Serializable]
	public class Goal
	{

		#region _Variables_

		//----------------------------------------

		int mUniqGoal;
		string mGoalName;
		bool mCompleted;
		kScreen mScreen;

		//----------------------------------------

		#endregion _Variables_

		#region Constructor

		//----------------------------------------

		public Goal(int goalID, string goalName, bool complete)
		{
			mUniqGoal = goalID;
			mGoalName = goalName;
			mCompleted = complete;

			if (!complete)
			{
				switch (goalID)
				{
					case 1:
					case 2:
						mScreen = kScreen.Gallery;
						break;
					case 3:
					case 4:
						mScreen = kScreen.Profile;
						break;
					case 5:
						mScreen = kScreen.MatchingSauce;
						break;
				}
			}
			else
				mScreen = kScreen.None;
		}

		//----------------------------------------

		#endregion Constructor

		#region _Properties_

		//----------------------------------------

		public int UniqGoal
		{
			get { return mUniqGoal; }
			set { mUniqGoal = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public string GoalName
		{
			get { return mGoalName; }
			set { mGoalName = value; }
		}

		//----------------------------------------

		public bool Completed
		{
			get { return mCompleted; }
			set { mCompleted = value; }
		}

		//----------------------------------------

		public kScreen Screen
		{
			get { return mScreen; }
			set { mScreen = value; }
		}

		//----------------------------------------

		#endregion _Properties_

		#region _Methods_

		//----------------------------------------

		public void ClearGoal()
		{
			mGoalName = string.Empty;
			mCompleted = true;
			mScreen = kScreen.None;
		}

		//----------------------------------------

		#endregion _Methods_

	} // End Class: Goal

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF
