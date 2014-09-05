using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Graphics;
using Core.Data;
using System.Threading.Tasks;
using System.Drawing;
using Core.Business;
using RadialProgress;
using Android.Mtp;
using Android.Text.Style;
using Gcm.Client;
using Android.Views.Animations;
using UrlImageViewHelper;
using System.Threading;

namespace flirtplanet
{
	public class FragmentHome : Fragment
	{
		static ImageView goalProgress;
		//RadialProgressView goalProgress;
		static List<TextView> goalsText;
		List<Match> mFreshFacesList;
		static TextView goalCompleted;
		ImageView[] freshFacesArray = new ImageView[6]; // only 6 fresh faces to be shown on the home page

		//AppUser appUser;// = new AppUser (fbUserId);
		//public static int appUserId;

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate(Resource.Layout.fragment_home, container, false);
			view.SetLayerType (LayerType.Software, null);
			//appUser = new AppUser (HelloFacebookSampleActivity.iGraphUser.Id);
			//appUserId = appUser.UniqUser;
			var confirmAvatar =  view.FindViewById <TextView> (Resource.Id.tv_confirmAvatarPhoto);
			var completeProfileDetails = view.FindViewById<TextView> (Resource.Id.tv_completeProfileDetail);
			var completeProfileInfo = view.FindViewById<TextView> (Resource.Id.tv_completeProfileInfo);
			var welcomeBack = view.FindViewById<TextView> (Resource.Id.tv_welcomeback);
			var layoutVisitor = view.FindViewById<LinearLayout> (Resource.Id.ll_visitors);
			var visitorCount = view.FindViewById<TextView> (Resource.Id.tv_visitorCount);
			var haveVisited = view.FindViewById<TextView> (Resource.Id.tv_visited);

			goalProgress = view.FindViewById<ImageView> (Resource.Id.rp_goal);
			//////////goalProgress = view.FindViewById<RadialProgressView> (Resource.Id.rp_goal);
			goalCompleted = view.FindViewById<TextView> (Resource.Id.tv_goalComplete);

			int[] goalIds = { Resource.Id.tv_confirmAvatarPhoto,
				Resource.Id.tv_haveFivePhotos,
				Resource.Id.tv_completeProfileDetail,
				Resource.Id.tv_completeProfileInfo,
				Resource.Id.tv_confirmPersonalQuiz
			};
			goalsText =new List<TextView>();
			for(int i =0;i<5;i++){
				goalsText.Add(view.FindViewById<TextView> (goalIds [i]));
				}

			welcomeBack.Text = ("Welcome back " + ProfileData.myUserName + " !");

			confirmAvatar.Click += (sender, e) => 
			{
				getFragment(Resource.Id.tv_confirmAvatarPhoto,0);
			};

			completeProfileDetails.Click += (sender, e) => 
			{
				getFragment(Resource.Id.tv_completeProfileDetail,0);
			};

			completeProfileInfo.Click += (sender, e) => 
			{
				getFragment(Resource.Id.tv_completeProfileInfo,0);
			};

			freshFacesArray[0] = view.FindViewById <ImageView> (Resource.Id.iv_freshFace0);
			freshFacesArray[1] = view.FindViewById <ImageView> (Resource.Id.iv_freshFace1);
			freshFacesArray[2] = view.FindViewById <ImageView> (Resource.Id.iv_freshFace2);
			freshFacesArray[3] = view.FindViewById <ImageView> (Resource.Id.iv_freshFace3);
			freshFacesArray[4] = view.FindViewById <ImageView> (Resource.Id.iv_freshFace4);
			freshFacesArray[5] = view.FindViewById <ImageView> (Resource.Id.iv_freshFace5);


			visitorCount.Text =  MainUser.Notifications.TotalVisitors + ((MainUser.Notifications.TotalVisitors == 1) ? " person" : " people");
			haveVisited.Text = ((MainUser.Notifications.TotalVisitors == 1) ? "Has" : "Have") + " visited your profile";

			_BuildFreshFaces ();
			_BuildGoalList ();
			_DecrementFeaturedUsers ();

			// if all the goals are complete, do not show the info
			var goalsInfo = view.FindViewById<TextView> (Resource.Id.tv_goalsInfo);
			if (goalsComplete >= 5) // all goals complete
			{
				goalsInfo.Visibility = ViewStates.Gone;
			}

			// BAD CODE - to be replaced
			freshFacesArray[0].Click += (sender, e) => 
			{
				//ProfileData.initializeUserData(MainUser.AppUser.UniqUser, mFreshFacesList [0].UniqUser); // 350 should be changed to OUR fb user id
				freshFacesArray[0].SetColorFilter(Android.Graphics.Color.Gray);
				getFragment(Resource.Id.iv_freshFace0, mFreshFacesList [0].UniqUser);
			};

			freshFacesArray[1].Click += (sender, e) => 
			{
				//ProfileData.initializeUserData(MainUser.AppUser.UniqUser, mFreshFacesList [1].UniqUser); // 350 should be changed to OUR fb user id
				freshFacesArray[1].SetColorFilter(Android.Graphics.Color.Gray);
				getFragment(Resource.Id.iv_freshFace1,mFreshFacesList [1].UniqUser);
			};

			freshFacesArray[2].Click += (sender, e) => 
			{
				//ProfileData.initializeUserData(MainUser.AppUser.UniqUser, mFreshFacesList [2].UniqUser); // 350 should be changed to OUR fb user id
				freshFacesArray[2].SetColorFilter(Android.Graphics.Color.Gray);
				getFragment(Resource.Id.iv_freshFace2,mFreshFacesList [2].UniqUser);
			};

			freshFacesArray[3].Click += (sender, e) => 
			{
				//ProfileData.initializeUserData(MainUser.AppUser.UniqUser, mFreshFacesList [3].UniqUser); // 350 should be changed to OUR fb user id
				freshFacesArray[3].SetColorFilter(Android.Graphics.Color.Gray);
				getFragment(Resource.Id.iv_freshFace3,mFreshFacesList [3].UniqUser);
			};

			freshFacesArray[4].Click += (sender, e) => 
			{
				//ProfileData.initializeUserData(MainUser.AppUser.UniqUser, mFreshFacesList [4].UniqUser); // 350 should be changed to OUR fb user id
				freshFacesArray[4].SetColorFilter(Android.Graphics.Color.Gray);
				getFragment(Resource.Id.iv_freshFace4,mFreshFacesList [4].UniqUser);
			};

			freshFacesArray[5].Click += (sender, e) => 
			{
				//ProfileData.initializeUserData(MainUser.AppUser.UniqUser, mFreshFacesList [5].UniqUser); // 350 should be changed to OUR fb user id
				freshFacesArray[5].SetColorFilter(Android.Graphics.Color.Gray);
				getFragment(Resource.Id.iv_freshFace5,mFreshFacesList [5].UniqUser);
			};

			// BAD CODE ENDS

			layoutVisitor.Click += (object sender, EventArgs e) => 
			{
				if(MainUser.Notifications.TotalVisitors > 0)
				getpopup();
			};
			return view;
		}
		//9372351235

		public override void OnDestroyView ()
		{
			base.OnDestroyView ();
			mFreshFacesList = null;
			GC.Collect (0);

		}

		public void getpopup()
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (this.Activity);
			//	LayoutInflater inflater = this.LayoutInflater;
			ad = builder.Create ();

			var customView = this.Activity.LayoutInflater.Inflate(Resource.Layout.Popup_visitor, null);

			// Create your fragment here  var contactsAdapter = new ContactsAdapter (this);  
			var visitorAdapter = new visitorAdapter (this.Activity);

			var close = customView.FindViewById<ImageView> (Resource.Id.iv_close);
			close.Click += (sender, e) => 
			{
				ad.Cancel();
			};

			var visitorListView = customView.FindViewById<ListView> (Resource.Id.lv_visitorListView);      
			visitorListView.Adapter = visitorAdapter;

			visitorListView.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) => {
				getFragment(0,Convert.ToInt32(visitorAdapter.GetItem(e.Position)));
				ad.Dismiss();
			};

			var btn = customView.FindViewById<Button> (Resource.Id.btn_ok);
			btn.Click += (object sender, EventArgs e) => {
				ad.Dismiss();
			};

			builder.SetView(customView);
			ad = builder.Create ();
			ad.SetCancelable(true);

			ad.Show ();
		}

		public void getFragment(int resource, int id =0)
		{
			Fragment currentFragment;
			if (resource == Resource.Id.tv_confirmAvatarPhoto) 
			{
				currentFragment = new FragmentAvatar ();
			} 
			else if (resource == Resource.Id.tv_completeProfileDetail || resource == Resource.Id.tv_completeProfileInfo) 
			{
				currentFragment = new FragmentProfile ();
			} 
			else //if(resource == Resource.Id.freshFacesArray[0])
			{
				currentFragment = new FragmentUserProfile (id);
			}

			FragmentTransaction ft1 = FragmentManager.BeginTransaction ();
			ft1.Replace(Resource.Id.content_frame, currentFragment)
				.AddToBackStack(null)
				.Commit();
		}

		public void _BuildFreshFaces()
		{
			do 
			{
				mFreshFacesList = Core.Business.HomeBus.LoadFreshFaces(MainUser.AppUser.UniqUser); 
			} 
			while (mFreshFacesList == null);

			for (int idx = 0; idx < mFreshFacesList.Count && idx < 6; ++idx)
			{
				freshFacesArray [idx].SetPadding (0, 0, 0, 10);
				freshFacesArray [idx].SetUrlDrawable((Core.Constants.kBaseURL.Avatar + mFreshFacesList [idx].Avatar) ,Resource.Drawable.DD_DefaultImage_loading,true,Core.Constants.kCircularImageSize.freshFaces);
			}
		}

		void _DecrementFeaturedUsers()
		{
			int[] featuredUsers = (from f in mFreshFacesList
			                        where f.FeaturedUser
			                        select f.UniqUser).ToArray ();
			ThreadPool.QueueUserWorkItem (delegate { BoostBus.ViewFeaturedUsers (featuredUsers); });
		}

		public static async Task<byte[]> GetImageBytes (string url)
		{
			var client = new WebClient ();
			return await client.DownloadDataTaskAsync (url);
		}

		public static float goalsComplete = 0;

		public static void _BuildGoalList()
		{
			do { MainUser.Goals = BusinessBase.GetUserGoals(MainUser.AppUser.UniqUser); } while (MainUser.Goals == null);

			int   goalsDrawn = 5;
			for (int idx = 0; idx < MainUser.Goals.Count; ++idx)
			{
				if (MainUser.Goals[idx].Completed)
				{
					goalsText [idx].Visibility = ViewStates.Gone;
					--goalsDrawn;
				}
			}	

			//goalsComplete = ((float) (MainUser.Goals.Count - goalsDrawn)) / ((float) MainUser.Goals.Count)*100f;
			goalsComplete = (MainUser.Goals.Count - goalsDrawn);
			goalProgress.SetImageDrawable (new CircleProgress (goalsComplete,goalProgress.LayoutParameters.Width));
			
			//goalProgress.Value = ((float) (MainUser.Goals.Count - goalsDrawn)) / ((float) MainUser.Goals.Count)*100f;
			goalCompleted.Text = (((goalsComplete / MainUser.Goals.Count) * 100).ToString() + "% Complete");
		}
	}
}

