//--------------------------------------------------------------------------------
//
// Core.Data.UserDetailAnswer.cs - 
//
// Copyright 2013 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;

//--------------------------------------------------------------------------------

namespace Core.Data
{
	[Serializable]
	public class DetailAnswer
	{
		#region Variables

		//----------------------------------------

		int mUniqUserAnswer;
		int mUniqUserQuestion;
		int mUniqUserQuestionAnswer;
		string mAnswerText;

		//----------------------------------------

		#endregion

		#region Properties

		//----------------------------------------

		public int UniqUserAnswer
		{
			get { return mUniqUserAnswer; }
			set { mUniqUserAnswer = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int UniqUserQuestion
		{
			get { return mUniqUserQuestion; }
			set { mUniqUserQuestion = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int UniqUserQuestionAnswer
		{
			get { return mUniqUserQuestionAnswer; }
			set { mUniqUserQuestionAnswer = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public string AnswerText
		{
			get { return mAnswerText; }
			set { mAnswerText = value; }
		}

		//----------------------------------------

		#endregion

	} // End Class: UserDetailAnswer

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF
