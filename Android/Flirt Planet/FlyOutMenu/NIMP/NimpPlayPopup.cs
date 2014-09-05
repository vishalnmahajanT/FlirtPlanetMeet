//--------------------------------------------------------------------------------
//
// iOS.Popups.NimpPlayPopup.cs - The popup that shows during the taking of the N-Imp quiz
//
// Copyright 2013 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Collections.Generic;

using Core.Business;
using Core.Constants;
using Core.Data;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
//--------------------------------------------------------------------------------
using Android.Views.Animations;

namespace flirtplanet
{
	public class NimpPlayPopup :Popup
	{
		//----------------------------------------

		const int kStartX = 14; 
		const int kStartY = 60;
		const int kResponseHeight = 60;
		const int kHideBorderDelayMS = 600;
		const int kShowEncourageResponse = 1800;

		public bool ResponsesEnabled
		{
			set
			{
				mLeftResponse.Enabled = value;
				mRightResponse.Enabled = value;
			}
		}

		public bool IsLeftTrue { get { return mIsLeftTrue; } }

		//----------------------------------------

		Button 	mLeftResponse;
		Button 	mRightResponse;
		View	mSeparatorV;

		Button	mBeginRound;
		Button	mNextRound;

		TextView		mFullscreenMessage;

		NimpController mController;

		bool		mIsLeftTrue;

		Handler		mHideBorderTimer = new Handler ();
		Handler		mShowErrorTimer = new Handler ();

		public static TextView				mIAmLabel;
		public static TextView				mTrialLabel;
		public static TextView	  			mErrorMessage;

		public TextView ErrorMessage { get { return mErrorMessage; } }

		Activity mActivity;

		RelativeLayout 			mNimpPlay;
		RelativeLayout			mFullMsg;
		LinearLayout			mCountDown;
		LinearLayout			mNimpBorder;
		//----------------------------------------

		public NimpPlayPopup(Activity attachTo, NimpController controller, List<NimpTrial> trials) : 
			base()
		{
			mController = controller;
			mActivity = attachTo;
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (attachTo);
			ad = builder.Create ();

			var customView = attachTo.LayoutInflater.Inflate(Resource.Layout.HT_NimpController, null);

			mNimpBorder = customView.FindViewById<LinearLayout> (Resource.Id.ll_nimpPlay);
			mNimpPlay = customView.FindViewById<RelativeLayout> (Resource.Id.rl_nimpPlay);
			mFullMsg = customView.FindViewById<RelativeLayout> (Resource.Id.rl_fullScreenMessage);
			mCountDown = customView.FindViewById<LinearLayout> (Resource.Id.ll_countDown);

			mIAmLabel = customView.FindViewById<TextView> (Resource.Id.tv_IAmLabel);
			mTrialLabel = customView.FindViewById<TextView> (Resource.Id.tv_TrialLabel);
			mErrorMessage = customView.FindViewById<TextView> (Resource.Id.tv_ErrorMessage);

			mLeftResponse = customView.FindViewById <Button> (Resource.Id.btn_buttonLeft);
			mRightResponse = customView.FindViewById <Button> (Resource.Id.btn_buttonRight);
			mSeparatorV = customView.FindViewById <View> (Resource.Id.separatorV);

			mBeginRound = customView.FindViewById<Button> (Resource.Id.btn_beginRound);// to-do
			mNextRound = customView.FindViewById<Button> (Resource.Id.btn_nextRound);

			mFullscreenMessage = customView.FindViewById<TextView> (Resource.Id.tv_fullScreenMessage);

			var close = customView.FindViewById <ImageView> (Resource.Id.iv_close);
			close.Click += (object sender, EventArgs e) => ad.Cancel();


			builder.SetView(customView);
			ad = builder.Create ();
			ad.Show ();

			/*	AddSubview(new GRImageView((AppMgr.IsOnIPad) ? new RectangleF(14f, 4f, 289f, 53f) : new RectangleF(14f, 4f, 260f, 53f), kImage.Nimp_Title));

			mOrangeBorder = new GRView(new RectangleF(kStartX, kStartY, Frame.Width - (2 * kStartX), 240));
			mOrangeBorder.Layer.BorderColor = Palette.Orange.CGColor;
			mOrangeBorder.Layer.BorderWidth = 5f;
			AddSubview(mOrangeBorder);*/

			//mLeftResponse = _AddResponseButton("", 0, true);
			//AddSubview(mLeftResponse);
			mLeftResponse.Click += (object sender, EventArgs e) => {
				_AddResponse(true);
				/*if(mIsLeftTrue)
					mController.EvaluateResponse(true);
				else
					mController.EvaluateResponse(false);*/
			};

			mRightResponse.Click += (object sender, EventArgs e) => {
				_AddResponse(false);

				/*if(mIsLeftTrue)
					mController.EvaluateResponse(false);
				else
					mController.EvaluateResponse(true);*/
			};
			//mRightResponse = _AddResponseButton("", Frame.Width / 2f, false);
			//	AddSubview(mRightResponse);

			RandomizeTrueFalseOrder();

			//	AddSubview(new GRView(new RectangleF(0, Frame.Height - kResponseHeight, Frame.Width, 2)));

			//	mSeparatorV = new GRView(new RectangleF(Frame.Width / 2f, Frame.Height - kResponseHeight, 2, kResponseHeight), Palette.DarkGray);
			//AddSubview(mSeparatorV);

			//	AddCloseButton();

			mFullscreenMessage.Text = "";
			//	mFullscreenMessage.TextColor = Palette.White;
			//	mFullscreenMessage.TextAlignment = UITextAlignment.Left;
			//	mFullscreenMessage.Lines = 0;
			//	mFullscreenMessage.LineBreakMode = UILineBreakMode.WordWrap;
			//mBeginRound.Visibility = ViewStates.Visible;

			mBeginRound.Text = "PRACTICE";
			mBeginRound.Gravity = GravityFlags.Center;
			mBeginRound.Click += (object sender, EventArgs e) => {
				mFullMsg.Visibility = ViewStates.Gone;
				mNimpPlay.Visibility = ViewStates.Visible;
				_BeginRoundClicked(sender,e);

			};

			mNextRound.Text = "";
			mNextRound.Click += (object sender, EventArgs e) => {
				_NextRoundClicked(sender,e);
			};
			//mBeginRound = AddSubmitButton(_BeginRoundClicked, "PRACTICE");
			//mNextRound = AddSubmitButton(_NextRoundClicked, "");

		}

		//----------------------------------------

		public void ShowMessageBeforeRound()
		{
			mNimpPlay.Visibility = ViewStates.Gone;
			mFullMsg.Visibility = ViewStates.Visible;

			//mNimpPlay.Visibility = ViewStates.Visible;
			//mFullMsg.Visibility = ViewStates.Gone;


			//mOrangeBorder.Hidden = true;
			mLeftResponse.Visibility = ViewStates.Invisible;
			mRightResponse.Visibility = ViewStates.Invisible;
			mSeparatorV.Visibility = ViewStates.Invisible;
			mNextRound.Visibility = ViewStates.Invisible;
			mFullscreenMessage.Visibility = ViewStates.Visible;

			mBeginRound.Visibility = ViewStates.Visible;

			if (mController.IsPracticingFirst)
			{
				mNextRound.Visibility = ViewStates.Gone;
				//	mBeginRound.Gravity = GravityFlags.Center;
				mBeginRound.Text="PRACTICE";

				mFullscreenMessage.Text = NimpData.PreRoundMessages[NimpData.Block.Practice];
			}
			else
			{
				mNextRound.Visibility = ViewStates.Gone;
				//mBeginRound.Gravity = GravityFlags.Center;
				mBeginRound.Text="CONTINUE";

				mFullscreenMessage.Text = NimpData.PreRoundMessages[mController.CurrentBlock];
			}
		}

		//----------------------------------------

		public void ShowMessageAfterRound(bool isPractice)
		{
			mNimpPlay.Visibility = ViewStates.Gone;
			mFullMsg.Visibility = ViewStates.Visible;

			//mOrangeBorder.Hidden = true;
			mLeftResponse.Visibility = ViewStates.Invisible;
			mRightResponse.Visibility = ViewStates.Invisible;
			mSeparatorV.Visibility = ViewStates.Invisible;

			mBeginRound.Visibility = ViewStates.Visible;
			mFullscreenMessage.Visibility = ViewStates.Visible;

			mNextRound.Visibility = ViewStates.Visible;

			if (mController.IsPracticingFirst)
			{
				mBeginRound.Visibility = ViewStates.Invisible;
				//mNextRound.Gravity = GravityFlags.Center;
				mNextRound.Text="CONTINUE";
				mFullscreenMessage.Text = NimpData.PostRoundMessages[NimpData.Block.Practice];
			}
			else
			{
				mBeginRound.Visibility = ViewStates.Invisible;
				//mNextRound.Gravity = GravityFlags.Center;

				mNextRound.Text="NEXT BLOCK";
				mFullscreenMessage.Text = NimpData.PostRoundMessages[mController.CurrentBlock];
			}
		}

		//----------------------------------------

		public void StartBorderTimer()
		{
			if (mController.IsPracticingFirst)
			{
				//	mOrangeBorder.Visibility = ViewStates.Visible;
				mNimpBorder.SetBackgroundResource (Resource.Drawable.Orange_border);

				mHideBorderTimer.PostDelayed (_HideBorder, kHideBorderDelayMS);
				mShowErrorTimer.PostDelayed (_EncourageResponse, kShowEncourageResponse);
				//mHideBorderTimer = NSTimer.CreateScheduledTimer(TimeSpan.FromMilliseconds(kHideBorderDelayMS), _HideBorder);
				//mShowErrorTimer = NSTimer.CreateScheduledTimer(TimeSpan.FromMilliseconds(kShowEncourageResponse), _EncourageResponse);
			}
		}

		//----------------------------------------

		public void ShowBorder()
		{
			if (mController.IsPracticingFirst)
				mNimpBorder.SetBackgroundResource (Resource.Drawable.Orange_border);

			//	if (mController.IsPracticingFirst)
				//mOrangeBorder.Hidden = false;
		}

		//----------------------------------------

		#region _Private_Methods_
	
		private void _AddResponse(bool isLeft )
		{

				if(mHideBorderTimer != null)
				{

					mHideBorderTimer.RemoveCallbacks(_HideBorder);

				//mHideBorderTimer.Dispose();
				//	mHideBorderTimer = null;
					mNimpBorder.SetBackgroundDrawable (null);
				}

				if(mShowErrorTimer != null)
				{
				mShowErrorTimer.RemoveCallbacks (_EncourageResponse);
				//mShowErrorTimer.Dispose();
				//	mShowErrorTimer = null;
				}

				if(isLeft)
				{
					if(mIsLeftTrue)
						mController.EvaluateResponse(true);
					else
						mController.EvaluateResponse(false);
				}
				else
				{
					if(mIsLeftTrue)
						mController.EvaluateResponse(false);
					else
						mController.EvaluateResponse(true);
				}

		}

		//----------------------------------------

		public void RandomizeTrueFalseOrder()
		{
			if (GRTools.RNG.Next(2) == 0)
			{
				mIsLeftTrue = true;
				mLeftResponse.Text = "TRUE";
				mRightResponse.Text = "FALSE";


			}
			else
			{
				mIsLeftTrue = false;
				mLeftResponse.Text = "FALSE";
				mRightResponse.Text = "TRUE";
			}
		}

		//----------------------------------------

		void _HideBorder()
		{
			mNimpBorder.SetBackgroundDrawable (null);
			//	mOrangeBorder.Hidden = true;
		}

		//----------------------------------------

		void _EncourageResponse()
		{
			ErrorMessage.Text = "PRESS THE TRUE OR FALSE BUTTON!";
		}

		//----------------------------------------

		void _NextRoundClicked(object sender, EventArgs e)
		{
			mNextRound.Visibility = ViewStates.Invisible; //jagga

			NimpData.Block nextRound = (mController.IsPracticingFirst) ? mController.CurrentBlock : (NimpData.Block)((int)mController.CurrentBlock + 1);

			mController.IsPracticingFirst = false;

			mController.BeginNextRound(nextRound);
		}

		//----------------------------------------

		void _BeginRoundClicked(object sender, EventArgs e)
		{
			mBeginRound.Visibility = ViewStates.Invisible;
			mSeparatorV.Visibility = ViewStates.Visible;
			mLeftResponse.Visibility = ViewStates.Visible;
			mRightResponse.Visibility = ViewStates.Visible;

			mFullscreenMessage.Visibility = ViewStates.Invisible;
			mFullMsg.Visibility = ViewStates.Invisible;
			mNimpPlay.Visibility = ViewStates.Visible;
			//mController.BeginCountdown();
			BeginCountdown();
		}



		Handler animator = new Handler ();
		System.Action NumberAnim;
		Animation fadin;
		Animation shrink;
		Animation shrinkFade;

		int InitialFlirtJuice = 20;

		public void BeginCountdown()
		{
			//mLeftResponse.Visibility = ViewStates.Gone;
			//mRightResponse.Visibility = ViewStates.Gone;
			//mSeparatorV.Visibility = ViewStates.Gone;
			mErrorMessage.Visibility = ViewStates.Gone;

		//	AlertDialog ad;
		//	Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (mActivity);
		//	ad = builder.Create ();

			//var customView = mActivity.LayoutInflater.Inflate(Resource.Layout.HT_NimpController, null);

		//	mCounter = customView.FindViewById<TextView> (Resource.Id.tv_count);
		//	button = customView.FindViewById<Button> (Resource.Id.btn_testOk);
		//	mReady = customView.FindViewById<TextView> (Resource.Id.tv_ready);

			fadin = AnimationUtils.LoadAnimation (mActivity, Resource.Animation.fade_in);
			shrink = AnimationUtils.LoadAnimation (mActivity, Resource.Animation.shrink);
			shrinkFade = AnimationUtils.LoadAnimation (mActivity, Resource.Animation.shrink_fade);

		//	button.Click += delegate {
			//	button.Text = string.Format ("  clicks!");
			mIAmLabel.Text = "GET READY";

			mIAmLabel.StartAnimation (shrink);
			AnimateNumber();
		//};

			/*var button = customView.FindViewById<Button> (Resource.Id.btn_testOk);

			button.Click+= (object sender, EventArgs e) => {
				ad.Dismiss();
			};*/

			//builder.SetView(customView);
		//	ad = builder.Create ();
		//	ad.Show ();

		}

		public  void AnimateNumber ()
		{
			InitialFlirtJuice = 6;
			NumberAnim = ()=> {
				if(InitialFlirtJuice > 0)
				{
					InitialFlirtJuice--;
					mTrialLabel.Text = ""+InitialFlirtJuice;
					mTrialLabel.StartAnimation(shrinkFade);
					animator.PostDelayed(NumberAnim, 950);

				}
				else 
				{
					animator.RemoveCallbacks(NumberAnim);
					//animator.Dispose();
					mLeftResponse.Visibility = ViewStates.Visible;
					mRightResponse.Visibility = ViewStates.Visible;
					mSeparatorV.Visibility = ViewStates.Visible;
					mErrorMessage.Visibility = ViewStates.Visible;

					mController.CountdownFinished();
				}


			};

			animator.PostDelayed (NumberAnim, 20);
		}
		#endregion _Private_Methods_

		//----------------------------------------

	} // End Class: NimpPlayPopup

} // End Namespace: iOS.Popups

//--------------------------------------------------------------------------------
// EOF

