//--------------------------------------------------------------------------------
//
// iOS.Popups.NimpRewardPopup.cs - The popup that shows before taking the quiz the first time.
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

//--------------------------------------------------------------------------------

namespace flirtplanet
{
	public class NimpRewardPopup : Popup
	{
		/*	public NimpRewardPopup(NimpController nimpController, UIView attachTo) : 
			base(attachTo, (AppMgr.IsOnIPad) ? iPad.kPopupSize.NimpRewardPopup : iPhone.kPopupSize.NimpPopup, "", WindowStyle.BlackTranslucent)
		{	
			AddSubview(new GRImageView((AppMgr.IsOnIPad) ? new RectangleF(14f, 4f, 289f, 53f) : new RectangleF(14f, 4f, 260f, 53f), kImage.Nimp_Title));

			UILabel message = new UILabel(new RectangleF(16, 60, Frame.Width - 48, Frame.Height - 128f));
			message.BackgroundColor = Palette.Clear;
			message.Text = NimpData.PostRoundMessages[NimpData.Block.Block4];
			message.TextColor = Palette.White;
			message.Font = UIFont.FromName(kFont.RobotoRegular, 16f);
			message.Lines = 0;
			message.LineBreakMode = UILineBreakMode.WordWrap;
			message.SizeToFit();
			AddSubview(message);

			AddSubview(new GRImageView(GRTools.Rect.CenterHoriz(new RectangleF(Frame.Width / 2 - 75f, Frame.Height - 90f, 35f, 35f)), kImage.NavMenu_FlirtJuice));

			UILabel flirtJuiceReward = new UILabel(GRTools.Rect.CenterHoriz(new RectangleF(Frame.Width / 2 + 15f, Frame.Height - 90f, 150f, 35f)));
			flirtJuiceReward.BackgroundColor = Palette.Clear;
			flirtJuiceReward.Font = UIFont.FromName(kFont.RobotoRegular, 18f);
			flirtJuiceReward.Text = "+100 Flirt Juice";
			flirtJuiceReward.TextColor = Palette.White;
			flirtJuiceReward.TextAlignment = UITextAlignment.Left;
			AddSubview(flirtJuiceReward);

			AddCloseButton();
			AddSubmitButton(_ContinueClicked, "CLAIM REWARD");
		}

		//----------------------------------------

		void _ContinueClicked(object sender, EventArgs e)
		{
			NSTimer.CreateScheduledTimer(TimeSpan.FromMilliseconds(250), delegate
			{
				FlyoutNav.AdjustJuice();
				new NimpResultPopup(mParentView);
			});

			this.Close();
		}

		//----------------------------------------*/

	} // End Class: NimpRewardPopup

} // End Namespace: iOS.Popups

//--------------------------------------------------------------------------------
// EOF

