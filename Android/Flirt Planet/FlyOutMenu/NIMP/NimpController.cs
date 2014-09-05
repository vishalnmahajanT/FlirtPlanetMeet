//--------------------------------------------------------------------------------
//
// iOS.NimpController.cs - Handles the flow of showing the N-Imp Quiz
//
// Copyright 2013 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;

///using MonoTouch.Foundation;
///using MonoTouch.UIKit;

using Core.Constants;
using Core.Business;
using Core.Data;

///using iOS.Common;
///using iOS.Foundation;
///using iOS.Popups;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
//--------------------------------------------------------------------------------

namespace flirtplanet
{
	/*
	public struct kInstructions
	{
		public string practiceRound = "This task will consist of several trials in which a word is presented in the middle of the screen.  The word will be either [True or False]  or [False or True]  and will be presented inside an orange square.\nIf the word is [True or False] press the TRUE button and if it is False or True] press the FALSE button.\nIt is important that you respond AS QUICKLY AS YOU CAN. Try to react before the orange square disappears. If you make a mistake you will hear a warning sound.\n\nHold one finger of your left hand over the TRUE button and one finger of your right hand over the FALSE button to get ready. \nLet's begin with some practice trials. Press the CONTINUE when you are ready to begin."
	}*/

	public class NimpController
	{
		//----------------------------------------

		public DelegateEvent RefreshMatchingSauceVC { get; private set; }

		public const int kTimeBeforeShowNextResponse = 1000; // 1000ms + 0-500 ms randomly
		public const int kTimeBeforeShowTrueFalse = 400;

		//	public TextView ErrorMessage { get { return mErrorMessage; } }

		public NimpData.Block CurrentBlock { get { return mCurrentBlock; } }

		public bool IsPracticingFirst { get { return mIsPracticingFirst; } set { mIsPracticingFirst = value; } }

		public string Handed { get { return mHanded; } }

		public bool IsLeftTrue { get { return mPlayScreen.IsLeftTrue; } }

		public int NumCorrect { get { return mNumCorrect; } }

		public int NumWrong { get { return mNumWrong; } }

		public int NumTrials { get { return mTrials.Count; } }

		//----------------------------------------

		#region _Private_Vars_

		List<NimpTrial> mTrials;
		List<NimpTrial> mTrialsLeftToShow;

		NimpTrial mCurrentTrial;
		NimpData.Block mCurrentBlock;

		Activity			mActivity;
		NimpPlayPopup 		mPlayScreen;

		static bool mIsPracticingFirst = true;

		int mNumCorrect = 0;
		int mNumWrong = 0;
		int mTrialIndex = 0;

		string mHanded = "";

		DateTime mTimeDisplayedTrueFalse;

		#endregion _Private_Vars

		//----------------------------------------

		#region _Public_Methods_

		public NimpController(Activity activity)
		{
			RefreshMatchingSauceVC = new DelegateEvent();

			mActivity = activity;

			string[] nimpValues = MatchingSauceBus.GetNIMPValues(MainUser.AppUser.UniqUser);

			if (nimpValues == null)
			{
				Popup.CreateErrorPopup(mActivity,Resource.String.error,Resource.String.connection_error,"OK");
				return;
			}

			if (nimpValues.Length > 1)
			{
				int currentBlock;
				Int32.TryParse(nimpValues[0], out currentBlock);

				mCurrentBlock = (NimpData.Block)currentBlock;

				mHanded = nimpValues[1];

				if (mCurrentBlock == NimpData.Block.Block1)
					_ShowIntroScreen();
				else
					PostIntroScreen();
			}
		}

		//----------------------------------------
		// Return value > 0 is the current block number
		// Return value of -1 means there was an error and it could not be pulled down

		public static int PullCurrentBlock()
		{
			int 		currentBlock = -1;
			string[] 	nimpValues = MatchingSauceBus.GetNIMPValues(MainUser.AppUser.UniqUser);

			if (nimpValues == null) return -1;

			if (nimpValues.Length > 1)
			{
				Int32.TryParse(nimpValues[0], out currentBlock);
			}

			return currentBlock;
		}

		//----------------------------------------

		public void PostIntroScreen()
		{
			if (mHanded.Equals(""))
				NimpDemoPopup();
			else
				PlayRound(mCurrentBlock);
		}

		//----------------------------------------

		public void PlayRound(NimpData.Block block)
		{
			if (block == NimpData.Block.Completed) return;

			mPlayScreen = new NimpPlayPopup(mActivity, this, mTrials);

			mPlayScreen.ResponsesEnabled = false;

			BeginNextRound(block);
		}

		//----------------------------------------

		public void BeginNextRound(NimpData.Block block)
		{
			mCurrentBlock = block;

			if (block == NimpData.Block.Completed) return;

			mTrials = NimpData.GetTrials(block);

			mPlayScreen.ShowMessageBeforeRound();

			mPlayScreen.RandomizeTrueFalseOrder();

			mNumCorrect = 0;
			mNumWrong = 0;

			mTrialIndex = 0;
		}

		//----------------------------------------

		public void BeginCountdown()
		{
			//mCountdownAnim = new NimpCountdownAnim(this, GRTools.Rect.CenterHoriz(new RectangleF(mPlayScreen.Frame.Width / 2f, mPlayScreen.Frame.Height / 2f - 50f, 300f, 200f)), mPlayScreen);
			//mPlayScreen.AddSubview(mCountdownAnim);
			//mCountdownAnim.BeginCountdown();
			CountdownFinished();
		}

		//----------------------------------------

		public void CountdownFinished()
		{
			_BeginShowingResponses();
		}

		//----------------------------------------

		public void DemographicsFinished(string handed)
		{
			mHanded = handed;
			PlayRound(mCurrentBlock);
		}
		Handler nextRepsose = new Handler ();

		//----------------------------------------
		public void EvaluateResponse(bool choseTrue)
		{
			NimpTrial mData = mTrials[mTrialIndex];

			if (mCurrentTrial.DisplayTrue == choseTrue)
			{
				if (!mCurrentTrial.Attempted)
				{
					mData.GotRightFirstTry = true;
					mNumCorrect++;
				}

				NimpPlayPopup.mTrialLabel.Text = (mIsPracticingFirst) ? "+" : "";

				NimpPlayPopup.mErrorMessage.Text = "";
				nextRepsose.PostDelayed (_NextResponse, kTimeBeforeShowNextResponse);
				
				//NSTimer.CreateScheduledTimer(TimeSpan.FromMilliseconds(kTimeBeforeShowNextResponse + GRTools.RNG.Next(0,500)), _NextResponse);

				mPlayScreen.ResponsesEnabled = false;

				var timeUntilCorrectResponse = (DateTime.Now - mTimeDisplayedTrueFalse).TotalMilliseconds;
				mData.MSResponseTime = Math.Round(timeUntilCorrectResponse);

				mTrialIndex++;
			}
			else
			{
				if (!mCurrentTrial.Attempted)
					mNumWrong++;

				mData.GotRightFirstTry = false;
				NimpPlayPopup.mErrorMessage.Text = "TRY AGAIN!";
			}

			mCurrentTrial.Attempted = true;


		}

		#endregion _Public_Methods_

		//----------------------------------------

		#region _Private_Methods_


		//----------------------------------------

		void _ShowIntroScreen()
		{
			//	new NimpIntroPopup(this, mParentVC.View);
			NimpIntroPopup ();
		}

		//----------------------------------------

		public void NimpIntroPopup ()
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (mActivity);
			ad = builder.Create ();

			var customView = mActivity.LayoutInflater.Inflate(Resource.Layout.HT_NimpIntroPopup, null);
			var introText = customView.FindViewById<TextView> (Resource.Id.tv_introText);
			var button = customView.FindViewById<Button> (Resource.Id.btn_letsDo);

			button.Click+= (object sender, EventArgs e) => {
				_ContinueClicked();
				ad.Dismiss();
			};

			var close = customView.FindViewById <ImageView> (Resource.Id.iv_close);
			close.Click += (object sender, EventArgs e) => ad.Cancel();


		//	string messageText = NimpData.PreRoundMessages[NimpData.Block.FirstLoad];
			introText.Text = NimpData.PreRoundMessages[NimpData.Block.FirstLoad];;

			builder.SetView(customView);
			ad = builder.Create ();
			ad.Show ();
		}
		//----------------------------------------
		//----------------------------------------
		string selectedHand=null;
		public void NimpDemoPopup ()
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (mActivity);
			ad = builder.Create ();
			string[] hand = { "","LEFT", "RIGHT" };
			var customView = mActivity.LayoutInflater.Inflate(Resource.Layout.HT_DemoPopup, null);
			var selectHandText = customView.FindViewById<TextView> (Resource.Id.tv_whichHand);
			var selectHand = customView.FindViewById<Spinner> (Resource.Id.sp_SelectHand);

			var close = customView.FindViewById <ImageView> (Resource.Id.iv_close);
			close.Click += (object sender, EventArgs e) => ad.Cancel();

			//selectHand.SetBackgroundResource (Resource.Drawable.mybg);

			selectHandText.Text= "WITH WHICH HAND DO YOU USE COMPUTER MOUSE?";
			selectHand.Adapter = new ArrayAdapter<string> (mActivity, Resource.Layout.custom_spinner_ht, hand);
			var button = customView.FindViewById<Button> (Resource.Id.btn_continue);

			selectHand.ItemSelected += (object sender, AdapterView.ItemSelectedEventArgs e) => {
				if(!selectHand.SelectedItem.ToString().Equals(""))
					button.Text = "CONTINUE";
				else
					button.Text = "SELECT TO CONTINUE";

			};

			button.Click+= (object sender, EventArgs e) => {
				//	selectedHand = selectHand.SelectedItem.ToString();
				if(selectHand.SelectedItem.ToString().Equals(""))
					return;
				if (selectHand.SelectedItem.ToString() == "LEFT")
					DemographicsFinished("L");
				else
					DemographicsFinished("R");

				ad.Dismiss();
			};

			builder.SetView(customView);
			ad = builder.Create ();
			ad.Show ();
		}
		//----------------------------------------

		void _ContinueClicked()
		{
			PostIntroScreen();
			
		}

		//----------------------------------------
		void _BeginShowingResponses()
		{
			//mPlayScreen.Closed.Function = null;

			mTrialsLeftToShow = new List<NimpTrial>(mTrials);


			NimpPlayPopup.mIAmLabel.Text = "I AM";
			//		mPlayScreen.AddSubview(mIAmLabel);

			NimpPlayPopup.mTrialLabel.Text = "";
		
			NimpPlayPopup.mErrorMessage.Text = "";
		
			// Don't want to show this if practicing
			if (mIsPracticingFirst)
				NimpPlayPopup.mIAmLabel.Text = "";

			_NextResponse();
		}

		//----------------------------------------
		Handler showTrueFalse = new Handler();
		public void _NextResponse()
		{
			if ((!mIsPracticingFirst && mTrialsLeftToShow.Count > 0) || (mIsPracticingFirst && mTrialIndex < 11)) // TODO: remove current trial test, that's only to keep it short for testing flow
			{
				mCurrentTrial = mTrialsLeftToShow.First();
				mTrialsLeftToShow.Remove(mCurrentTrial);

				if (!mIsPracticingFirst)
				{
					mPlayScreen.ResponsesEnabled = false;
					NimpPlayPopup.mTrialLabel.Text = mCurrentTrial.Text.ToUpper();
					showTrueFalse.PostDelayed (_ShowTrueFalse, kTimeBeforeShowTrueFalse);
					//	NSTimer.CreateScheduledTimer(TimeSpan.FromMilliseconds(kTimeBeforeShowTrueFalse), _ShowTrueFalse);
				}
				else
					_ShowTrueFalse();
			}
			else
			{
				if (!mIsPracticingFirst)
				{
					string results = NimpData.BuildResult(this, mTrials);
					string[] block = null;
					do { block = MatchingSauceBus.CompleteNIMPBlockGoal(ref MainUser.AppUser, mHanded, results, ref MainUser.Goals); } while (block == null);

					// Updates Matching Sauce VC
					RefreshMatchingSauceVC.Fire();

					// Check to see if we should show the Nimp Reward popup
					if (block[0] == "4")
					{
						// Check to refresh HomeVC
						//			iPad.HomeVC homeVC = mParentVC as iPad.HomeVC;
						///	if (homeVC != null) homeVC.OnReturnFromChildVC();

						//			new NimpRewardPopup(this, mParentVC.View);
						//			mPlayScreen.Close(false);
					}
					else
						_ShowPostScreen();
				}
				else
					_ShowPostScreen();
			}
		}

		//----------------------------------------

		void _ShowTrueFalse()
		{
			NimpPlayPopup.mTrialLabel.Text = mCurrentTrial.DisplayTrue.ToString().ToUpper();

			mPlayScreen.ResponsesEnabled = true;

			mPlayScreen.StartBorderTimer();

			mTimeDisplayedTrueFalse = DateTime.Now;
		}

		//----------------------------------------

		void _ShowPostScreen()
		{
				mPlayScreen.ShowMessageAfterRound(mIsPracticingFirst);
		}

		#endregion _Private_Methods_

		//----------------------------------------

	} // End Class: NimpController

} // End Namespace: iOS

//--------------------------------------------------------------------------------
// EOF

