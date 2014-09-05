//--------------------------------------------------------------------------------
//
// Core.Business.ProfileBus.cs - 
//
// Copyright 2013-2014 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;
using Core.Data;
using Core.Constants;

//--------------------------------------------------------------------------------

namespace Core.Business
{
	public class ProfileBus : BusinessBase
	{
		//----------------------------------------
		// Get a different users profile

		public static User GetOthersProfile(int userID, int targetID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetOthersProfile", "{\"UserID\":" + userID + ", \"TargetID\":" + targetID + "}"));
				++Counter;
			}

			User user = JsonConvert.DeserializeObject<User>(DecodeString(ReturnVal));
			user.AboutMe = user.AboutMe.Replace("\\n", "\n");
			user.GoalsInLife = user.GoalsInLife.Replace("\\n", "\n");
			user.Talents = user.Talents.Replace("\\n", "\n");
			user.MattersToMe = user.MattersToMe.Replace("\\n", "\n");
			user.LookingFor = user.LookingFor.Replace("\\n", "\n");
			user.Interests = user.Interests.Replace("\\n", "\n");
			user.ConnectToMe = user.ConnectToMe.Replace("\\n", "\n");

			return user;
		}

		//----------------------------------------
		// Get a users profile

		public static User GetOwnProfile(int userID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetOwnProfile", "{\"UserID\":" + userID + "}"));
				++Counter;
			}

			User user = JsonConvert.DeserializeObject<User>(DecodeString(ReturnVal));
			user.AboutMe = DecodeEssay(user.AboutMe);
			user.GoalsInLife = DecodeEssay(user.GoalsInLife);
			user.Talents = DecodeEssay(user.Talents);
			user.MattersToMe = DecodeEssay(user.MattersToMe);
			user.LookingFor = DecodeEssay(user.LookingFor);
			user.Interests = DecodeEssay(user.Interests);
			user.ConnectToMe = DecodeEssay(user.ConnectToMe);

			return user;
		}

		//----------------------------------------
		// Insert a rating

		public static string InsertRating(int userID, User targetUser, int rating)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("InsertRating", "{\"UserID\":" + userID + ", \"TargetID\":" + targetUser.UniqUser +
																		", \"Rating\":" + rating + "}"));
				++Counter;
			}

			targetUser.Rating = Convert.ToInt32(ReturnVal);

			return ReturnVal;
		}

		//----------------------------------------
		// Update rating

		public static string UpdateRating(int userID, User targetUser, int rating)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("UpdateRating", "{\"UserID\":" + userID + ", \"TargetID\":" + targetUser.UniqUser +
																		", \"Rating\":" + rating + "}"));
				++Counter;
			}

			targetUser.Rating = Convert.ToInt32(ReturnVal);

			return "true";
		}

		//----------------------------------------
		// Upload a single photo to the server

		public static string[] UploadPhotoGoal(ref AppUser appUser, User user, int isPublic, string url, ref List<Goal> goals)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("UploadPhotoGoal", "{\"UserID\": " + user.UniqUser + ", \"IsPublic\": " + isPublic +
																		", \"PhotoURL\": \"" + url + "\", \"Goal\": \"" + goals[1].Completed + "\"}"));
				++Counter;
			}

			if (ReturnVal == "Full" || ReturnVal == "Failed") return new string[] { "false" }; ;

			// Add photo to list
			string[] resultArr = ReturnVal.Split(',');

			Photo newPhoto = new Photo();
			newPhoto.UniqPhoto = Convert.ToInt32(resultArr[0]);
			newPhoto.UniqUser = user.UniqUser;
			newPhoto.UniqGallery = Convert.ToInt32(resultArr[1]);
			newPhoto.Caption = string.Empty;
			newPhoto.HashedName = resultArr[2];
			newPhoto.OrderNumber = Convert.ToInt32(resultArr[3]);

			user.Photos.Add(newPhoto);

			if (resultArr.Length == 5)
			{
				goals[1].ClearGoal();
				appUser.FlirtJuice = Convert.ToInt32(resultArr[4]);
			}

			// Decrement gallery capacities
			if (isPublic == 1)
				user.PublicPhotoCapacity -= 1;
			else
				user.PrivatePhotoCapacity -= 1;

			// Make avatar if there isn't an avatar
			if (appUser.Avatar == kImage.Avatar_Hashed)
			{
				user.Avatar = newPhoto.HashedName;
				appUser.Avatar = newPhoto.HashedName;
			}

			return resultArr;
		}

		//----------------------------------------
		// Delete a single photo from the server

		public static string DeletePhoto(ref AppUser appUser, User user, int isPublic, string hashedName)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("DeletePhoto", "{\"UserID\": " + user.UniqUser + ", \"HashedName\": \"" + hashedName + "\"}"));
				++Counter;
			}

			// Increment gallery capacities
			if (isPublic == 1)
				user.PublicPhotoCapacity += 1;
			else
				user.PrivatePhotoCapacity += 1;

			// Remove photos from list
			user.Photos.RemoveAll(x => x.HashedName == hashedName);

			// Update avatar values if the avatar was deleted
			if (ReturnVal != "NotAvatar")
			{
				appUser.Avatar = ReturnVal;
				user.Avatar = ReturnVal;
			}

			return ReturnVal;
		}

		//----------------------------------------
		// Set photo as avatar

		public static string[] MakePhotoAvatarGoal(ref AppUser appUser, User user, string hashedName, ref List<Goal> goals)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("MakePhotoAvatarGoal", "{\"UserID\": " + appUser.UniqUser + ", \"CurrentAvatar\": \"" + appUser.Avatar +
																		"\", \"NewAvatar\": \"" + hashedName + "\", \"Goal\": \"" + goals[0].Completed + "\"}"));
				++Counter;
			}

			string[] resultArr = ReturnVal.Split(',');

			if (Convert.ToBoolean(resultArr[0]))
			{
				appUser.Avatar = hashedName;
				user.Avatar = hashedName;
			}

			if (resultArr.Length > 1)
			{
				goals[0].ClearGoal();
				appUser.FlirtJuice = Convert.ToInt32(resultArr[1]);
			}

			return resultArr;
		}

		//----------------------------------------
		// Change cover photo

		public static string ChangeCoverPhoto(User user, string url)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("ChangeCoverPhoto", "{\"UserID\": " + user.UniqUser + ", \"CurrentCover\": \"" + user.CoverPhoto +
																		"\", \"PhotoURL\": \"" + url + "\"}"));
				++Counter;
			}

			if (ReturnVal != "false")
				user.CoverPhoto = ReturnVal;

			return "true";
		}

		//----------------------------------------
		// Update essay field

		public static string[] UpdateUserEssayQuestionGoal(ref AppUser appUser, string question, string answer, ref List<Goal> goals)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("UpdateUserEssayQuestionGoal", "{\"UserID\":" + appUser.UniqUser + ", \"Question\": \"" + question +
																	   "\", \"Answer\": \"" + EncodeEssay(answer) + "\", \"Goal\": \"" + goals[3].Completed + "\"}"));
				++Counter;
			}

			string[] resultArr = ReturnVal.Split(',');

			if (resultArr.Length == 2)
			{
				goals[3].ClearGoal();
				appUser.FlirtJuice = Convert.ToInt32(resultArr[1]);
			}

			return resultArr;
		}

		//----------------------------------------
		// Update user personal details

		public static string UpdateUserDetails(ref AppUser appUser, User user)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("UpdateUserDetails", "{\"UniqUser\": " + user.UniqUser + ", \"City\": \"" + user.City +
																	"\", \"StateProv\": \"" + user.StateProv + "\", \"Country\": \"" + user.Country + "\", \"Latitude\": " +
																	user.Latitude + ", \"Longitude\": " + user.Longitude + ", \"Flags\": " + user.Flags +
																	", \"BirthDate\": \"" + user.BirthDate.Year + "-" + user.BirthDate.Month + "-" + user.BirthDate.Day + "\"}"));
				++Counter;
			}

			// If the user changed their birthdate update MoonIt Compatibility Scores
			if (appUser.BirthDate != user.BirthDate)
			{
				System.Threading.ThreadPool.QueueUserWorkItem(delegate
				{ WebService.CallWebservice(EncodeString("UpdateMoonItCompats", "{\"UserID\":" + user.UniqUser + "}")); });
			}

			appUser.UpdateFromUser(user);

			return ReturnVal;
		}

		//----------------------------------------
		// Update user detail questions

		public static string[] UpdateUserDetailQuestionsGoal(ref AppUser appUser, int questionAnswerID, int answerID, ref List<Goal> goals)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("UpdateUserDetailQuestionsGoal", "{\"UserID\":" + appUser.UniqUser + ", \"QuestionAnswerID\":" + questionAnswerID +
																		", \"AnswerID\":" + answerID + ", \"Goal\": \"" + goals[2].Completed + "\"}"));
				++Counter;
			}

			string[] resultArr = ReturnVal.Split(',');

			if (resultArr.Length == 2)
			{
				goals[2].ClearGoal();
				appUser.FlirtJuice = Convert.ToInt32(resultArr[1]);
			}

			return resultArr;
		}

		//----------------------------------------
		// Update user height

		public static string[] UpdateUserHeightGoal(ref AppUser appUser, double height, ref List<Goal> goals)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("UpdateUserHeightGoal", "{\"UserID\":" + appUser.UniqUser + ", \"Height\":" + height +
																		", \"Goal\": \"" + goals[2].Completed + "\"}"));
				++Counter;
			}

			string[] resultArr = ReturnVal.Split(',');

			if (resultArr.Length == 2)
			{
				goals[2].ClearGoal();
				appUser.FlirtJuice = Convert.ToInt32(resultArr[1]);
			}

			return resultArr;
		}

		//----------------------------------------
		// Add user to watchlist

		public static string AddToWatchlist(int userID, User targetUser)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("AddToWatchlist", "{\"UserID\":" + userID + ", \"TargetID\":" + targetUser.UniqUser + "}"));
				++Counter;
			}

			targetUser.Watched = "1";

			return ReturnVal;
		}

		//----------------------------------------
		// Insert a user review

		public static string ReviewUser(int userID, User targetUser, string reviewText, int positive)
		{
			NewWebserviceCall();
			reviewText = EncodeEssay(reviewText);

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("ReviewUser", "{\"UserID\":" + userID + ", \"TargetID\":" + targetUser.UniqUser +
																		", \"ReviewText\": \"" + reviewText + "\", \"Positive\": " + positive + "}"));
				++Counter;
			}

			targetUser.CanReview = 2;

			return ReturnVal;
		}

		public static string ReviewUser(int userID, int targetID, string reviewText, int positive)
		{
			NewWebserviceCall();
			reviewText = EncodeEssay(reviewText);

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("ReviewUser", "{\"UserID\":" + userID + ", \"TargetID\":" + targetID +
																		", \"ReviewText\": \"" + reviewText + "\", \"Positive\": " + positive + "}"));
				++Counter;
			}

			return ReturnVal;
		}

		//----------------------------------------
		// Grab users own reviews for viewing

		public static List<Review> GetOwnReviews(int userID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetOwnReviews", "{\"UserID\":" + userID + "}"));
				++Counter;
			}

			List<Review> reviews = JsonConvert.DeserializeObject<List<Review>>(DecodeString(ReturnVal));

			for (int i = 0; i < reviews.Count; ++i)
				reviews[i].ReviewText = DecodeEssay(reviews[i].ReviewText);

			return reviews;
		}

		//----------------------------------------
		// Grab other users most recent positive reviews

		public static List<Review> GetOthersReviews(int userID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("GetOthersReviews", "{\"UserID\":" + userID + "}"));
				++Counter;
			}

			List<Review> reviews = JsonConvert.DeserializeObject<List<Review>>(DecodeString(ReturnVal));

			for (int i = 0; i < reviews.Count; ++i)
				reviews[i].ReviewText = DecodeEssay(reviews[i].ReviewText);

			return reviews;
		}

		//----------------------------------------
		// Get Option id for question

		public static  DetailAnswer GrabOptionID(List<DetailQuestion> userAnswers, int questionID,string answer)
		{

			//List<DetailQuestion> ans = new List<DetailQuestion>();
			//	DetailQuestion id = null;
			List<DetailQuestion> ans = new List<DetailQuestion> ();
			DetailAnswer answer1=null;
			ans = (from a in userAnswers
			       where a.UniqUserQuestion == questionID
			       select a).ToList ();
			/*
			//id = ans.Find(i => i.QuestionText.StartsWith(answer));
			id = ans.Find(i => i.AnswerList.ans
			return ans ;
			*/
				//		List<DetailAnswer> userAnswer = ProfileBus.GrabUserAnswers(ProfileData.mUser.DetailAnswers, question.UniqUserQuestion);

				int userSelectedAnswerId = 0;


				for (int id = 0; id < ans[0].AnswerList.Count; id++)
				{
					 answer1 = ans[0].AnswerList[id];

					if (answer1.AnswerText == answer)
					{
						userSelectedAnswerId = answer1.UniqUserAnswer;
						/*if (returnText.Equals("---"))
						{
							returnText = userAnswer[0].AnswerText;
						}*/
						//return userSelectedAnswerId;
					return answer1;
					}
				}
				return answer1;
		}


		//----------------------------------------
		// Get DetailAnswers for question

		public static List<DetailAnswer> GrabUserAnswers(List<DetailAnswer> userAnswers, int questionID)
		{
			return (from a in userAnswers
					where a.UniqUserQuestion == questionID
					select a).ToList();
		}

		//----------------------------------------
		// Flags profile as inappropriate
		// 1 = success, 0 = failure, -1 = already flagged

		public static string FlagProfile(int userID, int targetID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("FlagProfile", "{\"FlaggingUserID\":" + userID + ", \"FlaggedUserID\":" + targetID + "}"));
				++Counter;
			}

			return ReturnVal;
		}

		//----------------------------------------
		// Flags photo as inappropriate
		// 1 = success, 0 = failure, -1 = already flagged

		public static string FlagPhoto(int userID, int photoID)
		{
			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("FlagPhoto", "{\"FlaggingUserID\":" + userID + ", \"FlaggedPhoto\":" + photoID + "}"));
				++Counter;
			}

			return ReturnVal;
		}

		//----------------------------------------

	} // End Class: ProfileBus

} // End Namespace: Core.Business

//--------------------------------------------------------------------------------
// EOF





