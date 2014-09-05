
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
using UrlImageViewHelper;

namespace flirtplanet
{
	public class FragmentMainUserProfile : Fragment
	{
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate(Resource.Layout.fragment_userProfile, container, false);
			fillProfileDataFields (view);

			return view;
		}

		public void fillProfileDataFields(View view)
		{
			var name = view.FindViewById <TextView> (Resource.Id.tv_myDisplayName);
			var asl = view.FindViewById <TextView> (Resource.Id.tv_myasl);
			//var aboutMe = view.FindViewById<TextView> (Resource.Id.tv_aboutme);
			//var talents = view.FindViewById<TextView> (Resource.Id.tv_talent);
			//var lookingFor = view.FindViewById<TextView> (Resource.Id.tv_lookingfor);
			//var connectToMe = view.FindViewById<TextView> (Resource.Id.tv_connectme);
			//var goals = view.FindViewById<TextView> (Resource.Id.tv_goals);
			//var mattersToMe = view.FindViewById<TextView> (Resource.Id.tv_mattersme);
			//var interests = view.FindViewById<TextView> (Resource.Id.tv_interests);
			var displayPic = view.FindViewById<ImageView> (Resource.Id.iv_myProfilePic);
			//var coverPhoto = view.FindViewById<ImageView> (Resource.Id.iv_coverPhoto);
			//var rating = view.FindViewById<RatingBar> (Resource.Id.rb_rating);

			name.Text = ProfileData.myUserName;
			asl.Text = (ProfileData.myAge.ToString () +"."+ProfileData.mySex+"."+ProfileData.myCity+","+ ProfileData.myCountry);
			//aboutMe.Text = ProfileData.aboutMe;
			//talents.Text = ProfileData.talents;
			//lookingFor.Text = ProfileData.lookingFor;
			//connectToMe.Text = ProfileData.connectToMe;
			//goals.Text = ProfileData.goalsInLife;
			//mattersToMe.Text = ProfileData.mattersToMe;
			//interests.Text = ProfileData.interests;
			//////////displayPic.SetImageDrawable(new CircleDrawable (ProfileData.myDisplayPic,Core.Constants.kCircularImageSize.userGalleryImage));
			displayPic.SetUrlDrawable(Core.Constants.kBaseURL.Avatar + ProfileData.myDisplayPic ,Resource.Drawable.DD_DefaultImage_loading,true,Core.Constants.kCircularImageSize.userGalleryImage);
			//coverPhoto.SetImageBitmap (ProfileData.coverPhoto);
			//rating.Rating = ProfileData.rating;
		}
	}
}

