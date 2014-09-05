//--------------------------------------------------------------------------------
//
// Core.Data.UserDetailQuestion.cs - 
//
// Copyright 2013 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

//--------------------------------------------------------------------------------

namespace Core.Data
{
	[Serializable]
	public class DetailQuestion
	{
		#region Variables

		//----------------------------------------

		int mUniqUserQuestion;
		string mQuestionText;

		DetailAnswer[] mDetailAnswerArr;
		List<DetailAnswer> mAnswerList = new List<DetailAnswer>();
		//----------------------------------------

		#endregion

		#region Properties

		//----------------------------------------

		public int UniqUserQuestion
		{
			get { return mUniqUserQuestion; }
			set { mUniqUserQuestion = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public string QuestionText
		{
			get { return mQuestionText; }
			set { mQuestionText = value; }
		}

		//----------------------------------------

		public DetailAnswer[] DetailAnswerArr
		{
			set 
			{ 
				mDetailAnswerArr = value; 

				for (int i = 0; i < mDetailAnswerArr.Length; ++i)
					mAnswerList.Add(mDetailAnswerArr[i]);

				mDetailAnswerArr = null;
			}
		}

		//----------------------------------------

		public List<DetailAnswer> AnswerList
		{
			get { return mAnswerList; }
			set { mAnswerList = value; }
		}

		//----------------------------------------

		#endregion

	} // End Class: UserDetailQuestion

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF
