//--------------------------------------------------------------------------------
//
// iOS.MSZodiacElement.cs - The Zodiac sign and corresponding text.
//
// Copyright 2013 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;
using System.Drawing;

using Core.Data;
using Core.Constants;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Core.Business;
//--------------------------------------------------------------------------------
using Android.Graphics.Drawables;

namespace flirtplanet
{
	public class MSZodiacElement
	{
		public const float kWidth = 180f;
		public const float kHeight = 140f;
		public const float kZodiacSize = 90f;

		//----------------------------------------
		/*
		public MSZodiacElement(PointF location, string zodiacSign, UIColor baseColor)
		{
			UILabel nameLabel = new UILabel(new RectangleF(0f, 0f, kWidth, 32f));
			nameLabel.BackgroundColor = Palette.Clear;
			nameLabel.Font = UIFont.FromName(kFont.RobotoThin, 20f);
			nameLabel.Text = zodiacSign;
			nameLabel.TextColor = baseColor;
			nameLabel.TextAlignment = UITextAlignment.Center;
			AddSubview(nameLabel);

			ImageView zodiacImage = new ImageView ();
			(_GetImageForZodiac(zodiacSign.ToLower()));

			if(zodiacSign!=null)
			{
				GRImageView zodiacImageView = new GRImageView(new RectangleF((kWidth - kZodiacSize) / 2f, nameLabel.Frame.Height + 5f, kZodiacSize, kZodiacSize), zodiacImage);
				if (UIDevice.CurrentDevice.CheckSystemVersion(7, 0))
				{
					zodiacImageView.Image = zodiacImage.ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate);
					zodiacImageView.TintColor = baseColor;
				}
				AddSubview(zodiacImageView);
			}

			BackgroundColor = Palette.Clear;
		}*/

		//----------------------------------------

		public static int _GetImageForZodiac(string zodiac)
		{
			switch(zodiac)
			{
				case "aquarius":	 return Resource.Drawable.DD_MS_icn_zodiac_aquarius;
				case "aries":        return Resource.Drawable.DD_MS_icn_zodiac_aries;
				case "cancer":       return Resource.Drawable.DD_MS_icn_zodiac_cancer;
				case "capricorn":    return Resource.Drawable.DD_MS_icn_zodiac_capricorn;
				case "gemini":       return Resource.Drawable.DD_MS_icn_zodiac_gemini;
				case "leo":          return Resource.Drawable.DD_MS_icn_zodiac_leo;
				case "libra":        return Resource.Drawable.DD_MS_icn_zodiac_libra;
				case "pisces":       return Resource.Drawable.DD_MS_icn_zodiac_pisces;
				case "sagittarius":  return Resource.Drawable.DD_MS_icn_zodiac_sagittarius;
				case "scorpio":      return Resource.Drawable.DD_MS_icn_zodiac_scorpio;
				case "taurus":       return Resource.Drawable.DD_MS_icn_zodiac_taurus;
				case "virgo":        return Resource.Drawable.DD_MS_icn_zodiac_virgo;
			default:
				return -1;
			}
		}

		//----------------------------------------

	} // End Class: MSZodiacElement

} // End Namespace: iOS

//--------------------------------------------------------------------------------
// EOF

