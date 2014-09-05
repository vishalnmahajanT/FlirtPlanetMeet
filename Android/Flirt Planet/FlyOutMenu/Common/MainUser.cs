
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Core.Data;
using Core.Business;
using UrlImageViewHelper;

namespace flirtplanet
{
	public static class MainUser
	{
		public static AppUser		  AppUser       = null;
		public static Notifications   Notifications = null;
		public static MatchingSauce   MatchingSauce = null;
		public static string   		  AvatarImage   = null;
		public static List<Goal>      Goals         = null;

		public static bool ShouldLogout = false;

		public static void InitializeUser(AppUser _appUser)
		{
			AppUser = _appUser;
			//	AppUser.UniqUser = 364;//to be deleted
		}

		public static void RefreshAvatar()
		{
			FlirtPlanetActivity.FlyoutNav.displayPic.SetUrlDrawable(Core.Constants.kBaseURL.Avatar + ProfileData.myDisplayPic ,Resource.Drawable.DD_DefaultImage_loading,true,Core.Constants.kCircularImageSize.myFlyOutPic);
		}
		public static void logOut()
		{
			if (AppUser != null)
				BusinessBase.ToggleSWRVESession (MainUser.AppUser.UniqFacebook, "End");

			AppUser = null;
			Notifications = null;
			MatchingSauce = null;
			AvatarImage   = null;
			Goals         = null;
			//HelloFacebookSampleActivity.tempObject.iGraphUser = null;
		}
	}
}

