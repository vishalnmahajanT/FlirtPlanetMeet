//--------------------------------------------------------------------------------
//
// iOS.NimpCountdownAnim.cs - Displays the Get Ready / 5,4,3,2,1 animation
//
// Copyright 2013 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;
using System.Drawing;


using Core.Constants;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Core.Business;
//--------------------------------------------------------------------------------

namespace flirtplanet
{
	public class NimpCountdownAnim : Fragment
	{
		//----------------------------------------

		//bool 	mIsActive = false;
		int 	mCountdownNumber = 6;

		TextView mGetReady;
		TextView mCountdown;

		//NSTimer mFadeOutTimer;
		//NSTimer mNextCountdown;

		NimpController mController;

		//----------------------------------------

		public NimpCountdownAnim(NimpController controller, RectangleF frame) 
		{
			mController = controller;
			//mPopup = popup;

			_BuildUI();

			//mPopup.Closed.Function = _CancelCountdowns;
		}

		//----------------------------------------

		public void BeginCountdown()
		{
			mGetReady.Visibility = ViewStates.Invisible;
			mCountdown.Visibility = ViewStates.Invisible;

			//	GRTools.Anim.FadeIn(mGetReady, GRTools.Anim.kAnimPresets.NimpCountdownIn);
			//GRTools.Anim.Scale(mGetReady, GRTools.Anim.kAnimPresets.NimpCountdownIn);

			_NextCounterAnim();
		}

		//----------------------------------------

		#region _Private_Methods_

		void _NextCounterAnim()
		{
			if (mController == null)
				return;

			//	if (mNextCountdown != null)
			//	mNextCountdown.Invalidate();

			mCountdownNumber--;

			if (mCountdownNumber > 0)
			{
				mCountdown.Text = mCountdownNumber.ToString();

				//		GRTools.Anim.FadeIn(mCountdown, GRTools.Anim.kAnimPresets.NimpCountdownIn);
				//	GRTools.Anim.Scale(mCountdown, GRTools.Anim.kAnimPresets.NimpCountdownIn);
				//mFadeOutTimer = NSTimer.CreateScheduledTimer(TimeSpan.FromSeconds(0.75f), _FadeOutCounter);
			}
			else
			{
				mController.CountdownFinished();
				//	RemoveFromSuperview();
				//InvokeOnMainThread(Dispose);
			}
		}

		//----------------------------------------

		void _FadeOutCounter()
		{
			if (mController == null)
				return;

			/*		if (mFadeOutTimer != null)
				mFadeOutTimer.Invalidate();

			GRTools.Anim.FadeOut(mCountdown, GRTools.Anim.kAnimPresets.NimpCountdownOut);
			GRTools.Anim.Scale(mCountdown, GRTools.Anim.kAnimPresets.NimpCountdownOut);
			mNextCountdown = NSTimer.CreateScheduledTimer(TimeSpan.FromSeconds(0.65f), _NextCounterAnim);
		*/
		}

		//----------------------------------------

		void _BuildUI()
		{
			/*	mGetReady = new UILabel(GRTools.Rect.CenterHoriz(new RectangleF(Frame.Width / 2f, 3f, 200f, 32f)))
			{
				BackgroundColor = Palette.Clear,
				Font = UIFont.FromName(kFont.RobotoRegular, 32f),
				Text = "GET READY",
				TextAlignment = UITextAlignment.Center,
				TextColor = Palette.White
			};
			AddSubview(mGetReady);

			mCountdown = new UILabel(GRTools.Rect.CenterHoriz(new RectangleF(Frame.Width / 2f, 40f, 50f, 32f)))
			{
				BackgroundColor = Palette.Clear,
				Font = UIFont.FromName(kFont.RobotoRegular, 32f),
				Text = mCountdownNumber.ToString(),
				TextAlignment = UITextAlignment.Center,
				TextColor = Palette.White
			};
			AddSubview(mCountdown);

			mGetReady.Hidden = true;
			mCountdown.Hidden = true;
		*/
		}

		#endregion _Private_Methods_

		//----------------------------------------

		void _CancelCountdowns(object sender, EventArgs e)
		{
			/*	if (mFadeOutTimer != null)
			{
				mFadeOutTimer.Invalidate();
				mFadeOutTimer = null;
			}

			if (mNextCountdown != null)
			{
				mNextCountdown.Invalidate();
				mNextCountdown = null;
			}

			mController = null;

			mPopup.Closed.Function = null;
		*/
		}

		//----------------------------------------

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}
		//----------------------------------------

	} // End Class: NimpCountdownAnim

} // End Namespace: iOS

//--------------------------------------------------------------------------------
// EOF

