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
using Android.Graphics;
using Core.Data;

namespace flirtplanet
{
	class ProfileData
	{
		public static string displayPic;
		public static string coverPhoto;
		public static String userName;
		public static int age;
		public static String sex, orientation, city, country;
		public static int rating;

		public static String aboutMe;
		public static String goalsInLife;
		public static String talents;
		public static String mattersToMe;
		public static String lookingFor;
		public static String interests;
		public static String connectToMe;

		public static List<DetailAnswer> detailsAnswers;

		//main user data
		public static string myDisplayPic;
		public static List<Photo> myGalleryPic = new List<Photo>();
		public static User mUser;
		public static String myUserName;
		public static int myAge;
		public static String mySex, myOrientation, myCity, myCountry;

		public static User lastOtherUser;

		//public static string genderFromFB = null;

		public static void initializeUserData(int userId, int targetUser)
		{
			User user = null;
			do {user = Core.Business.ProfileBus.GetOthersProfile (userId, targetUser);} while(user == null);

			mUser = user;
			lastOtherUser = user;
			detailsAnswers = user.DetailAnswers;//answers to be filled in the details popups

			displayPic = user.Avatar;//FragmentHome.getProfileImageFromURL (user.Avatar);
			coverPhoto = user.CoverPhoto;//FragmentHome.getCoverImageFromURL (user.CoverPhoto);

			userName = user.UserName;
			age = user.GetAge();
			sex = user.GetGender ();
			orientation = user.GetOrientation ();
			city = user.City;
			country = user.Country;
			rating = user.Rating;

			aboutMe = user.AboutMe;
			goalsInLife = user.GoalsInLife;
			talents = user.Talents;
			mattersToMe = user.MattersToMe;
			lookingFor = user.LookingFor;
			interests = user.Interests;
			connectToMe = user.ConnectToMe;
		}

		public static void _BuildPhotos(User user){
			myGalleryPic = user.Photos;
		}
		public static void initializeMainUserData(int userId)
		{
			User user = null;
			do {user = Core.Business.ProfileBus.GetOwnProfile (MainUser.AppUser.UniqUser);} while (user == null);
			//if(genderFromFB != null)
				//user.UpdateFlags (genderFromFB, "Straight");

			mUser = user;
			MainUser.AppUser.Avatar = mUser.Avatar;

			detailsAnswers = user.DetailAnswers;//answers to be filled in the details popups

			//displayPic = user.Avatar;
			myDisplayPic = user.Avatar;//FragmentHome.getProfileImageFromURL (MainUser.AppUser.Avatar);
			coverPhoto = user.CoverPhoto;//FragmentHome.getCoverImageFromURL (user.CoverPhoto);

			myUserName = user.UserName;
			myAge = user.GetAge();
			mySex = user.GetGender ();
			myOrientation = user.GetOrientation ();
			myCity = user.City;
			myCountry = user.Country;
			//rating = user.Rating;

			aboutMe = user.AboutMe;
			goalsInLife = user.GoalsInLife;
			talents = user.Talents;
			mattersToMe = user.MattersToMe;
			lookingFor = user.LookingFor;
			interests = user.Interests;
			connectToMe = user.ConnectToMe;
		}
	}
}

