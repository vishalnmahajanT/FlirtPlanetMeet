
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Graphics;
using Core.Business;
using System.Runtime.InteropServices;
using System.Threading;

namespace flirtplanet
{
	public class FragmentUserSauce : Fragment
	{
		// other USER's matching sauce page
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate(Resource.Layout.fragment_UserSauce, container, false);
			// Create your fragment here

			var zodiac = view.FindViewById<ImageView> (Resource.Id.im_zodiac);
			var zodiacText = view.FindViewById<TextView> (Resource.Id.tv_zodiac);
			var personalityText = view.FindViewById<TextView> (Resource.Id.tv_personalityText);
			var more = view.FindViewById<TextView> (Resource.Id.tv_moreText);
			var flirtStyle = view.FindViewById<TextView> (Resource.Id.tv_flirtStyle);

			var preferencesLable = view.FindViewById<TextView> (Resource.Id.tv_preferences);
			var editPreferences = view.FindViewById<ImageView> (Resource.Id.im_EditPreference);
			preferencesLable.Visibility = ViewStates.Gone;
			editPreferences.Visibility = ViewStates.Gone;

			var personalityTestButton = view.FindViewById<ImageButton> (Resource.Id.ib_personalityTest);
			personalityTestButton.Visibility = ViewStates.Gone;

			while (MainUser.MatchingSauce == null) { MainUser.MatchingSauce = MatchingSauceBus.GetMatchingSauce(MainUser.AppUser.UniqUser); }

			zodiac.SetColorFilter (Color.Gray);
			zodiac.SetImageResource (MSZodiacElement._GetImageForZodiac (MainUser.MatchingSauce.ZodiacSign.ToLower()));
			zodiacText.Text = MainUser.MatchingSauce.ZodiacSign;

			var matchingCount = view.FindViewById<Button> (Resource.Id.button_matchingCount);

			var matchingTexts = NimpData.GetMatchingPersonality (MainUser.MatchingSauce, ProfileData.mUser);

			if (matchingTexts.Count > 0) 
			{
				string personalityTexts = "";

				matchingCount.Visibility = ViewStates.Visible;
				matchingCount.Text = "+" + matchingTexts.Count;

				foreach (string match in matchingTexts) {
					personalityTexts += "   \"" + match + "\"\n";
				}

				personalityText.Text = personalityTexts;

				more.Click += (object sender, EventArgs e) => {
					Popup.getScrollPopup (this.Activity, personalityTexts);
				};
			} 
			else 
			{
				more.Visibility = ViewStates.Gone;
				personalityText.Text = "No matching personality traits.";
			}

			var styles = NimpData.GetDominantFlirtStyles (ProfileData.mUser);

			if (styles.Count > 0) 
			{
				foreach (string style in styles) 
				{
					string display = "." + style;
					flirtStyle.Text += display;
				}
			} 
			else 
			{
				flirtStyle.Text = "None.";
			}

			return view;
		}
	}
}

