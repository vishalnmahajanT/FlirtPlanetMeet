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
using Core.Data;
using Core.Business;
using Android.Graphics;
using System.Net;
using UrlImageViewHelper;

namespace flirtplanet
{
	public class FragmentMail : Fragment
	{

		public static List<Flirtmail> mAllFlirtMail = null;
		public static List<Flirtmail> mAllFlirtMailSorted = null;
		public static int partnerID = 0;
		public static string partnerName = null;

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate(Resource.Layout.fragment_mail, container, false);
			var newMail = view.FindViewById<ImageView> (Resource.Id.im_newMail);
			var newMailLayout = view.FindViewById<LinearLayout> (Resource.Id.ll_newMessage);

			var mailListAdapter = new mailAdapter (this.Activity);       
			var mailListView = view.FindViewById<ListView> (Resource.Id.lv_mailConversations);      
			mailListView.Adapter = mailListAdapter;

			mailListView.ItemClick += (sender, e) => 
			{
				partnerID = mAllFlirtMailSorted[e.Position].PartnerID;
				partnerName = mAllFlirtMailSorted[e.Position].PartnerUserName;

				FlirtmailBus.MarkConversationRead(MainUser.AppUser.UniqUser,partnerID);
				//TODO FlirtPlanetActivity.FlyoutNav.updateNotificationCounters();

				FragmentTransaction ft1 = FragmentManager.BeginTransaction ();
				ft1.Replace(Resource.Id.content_frame, new FragmentMailDetails())
					.AddToBackStack(null)
					.Commit();
			};

			var refresh = view.FindViewById<TextView> (Resource.Id.tv_refresh);
			refresh.Click += (sender, e) => 
			{
				//change the text and disable the button
				refresh.Text = "Refreshing...";
				refresh.Enabled = false;

				Handler animator = new Handler ();
				System.Action NumberAnim = null;
				NumberAnim = ()=> 
				{
					refresh.Text = "Refresh";
					refresh.Enabled = true;
					
					animator.RemoveCallbacks(NumberAnim);
				};

				animator.PostDelayed (NumberAnim, 1500);

				mailListAdapter = new mailAdapter (this.Activity);       
				mailListView.Adapter = mailListAdapter;
			};

			newMailLayout.Click += (sender, e) => 
			{
				Fragment currentFragment = new FragmentCompose ();
				FragmentTransaction ft = FragmentManager.BeginTransaction ();
				ft.Replace (Resource.Id.content_frame, currentFragment)
				.AddToBackStack (null)
				.Commit ();

			};

			//if true - directly go to the mail details screen...as in the iOs version
			if (FragmentCompose.navigateThrough) 
			{
				FragmentCompose.navigateThrough = false;
				FragmentTransaction ft1 = FragmentManager.BeginTransaction ();
				ft1.Replace(Resource.Id.content_frame, new FragmentMailDetails())
					.AddToBackStack(null)
					.Commit();
			}

			return view;
		}
	}


	public class mailAdapter : BaseAdapter
	{
		static List<Flirtmail> 	mConversations = new List<Flirtmail>();
		static List<Bitmap> 	mConversationImages = new List<Bitmap> ();

		//List<Flirtmail> mAllFlirtMail = null;
		string mMostRecentMailCheck = DateTime.UtcNow.ToString("u");

		Activity _activity;
		//ImageView visitorImage;

		public mailAdapter(Activity activity){
			_activity = activity;
			_BuildConversations ();
		}
		public override int Count {
			get {
				return mConversations.Count;
			}
		}

		public override Java.Lang.Object GetItem (int position)
		{
			return mConversations [position].PartnerID;
		}

		public override long GetItemId (int position)
		{
			return 0;
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			var view = convertView ?? _activity.LayoutInflater.Inflate (Resource.Layout.single_row_mail, parent, false);
			var visitorName = view.FindViewById<TextView> (Resource.Id.tv_visitorName);
			var whenVisited = view.FindViewById<TextView> (Resource.Id.tv_timeStamp);
			var visitorImage = view.FindViewById<ImageView> (Resource.Id.im_visitorImage);
			var subjectLine = view.FindViewById<TextView> (Resource.Id.tv_subject);
			var mailAlert = view.FindViewById<ImageView> (Resource.Id.iv_newMailIcon);

			visitorName.Text = mConversations [position].PartnerUserName;
			whenVisited.Text = GRTools.Text.GetScreenFriendlyTime(mConversations [position].Sent);//mConversations [position].Sent.ToString();
			subjectLine.Text = mConversations [position].Message;

			//=="0" means there IS a new mail
			if (mConversations [position].MailRead != "0") 
			{
				mailAlert.Visibility = ViewStates.Gone;
			} 
			else 
			{
				mailAlert.Visibility = ViewStates.Visible;
			}

			visitorImage.SetUrlDrawable((Core.Constants.kBaseURL.Avatar + mConversations[position].PartnerAvatar) ,Resource.Drawable.DD_DefaultImage_loading,true,Core.Constants.kCircularImageSize.userGalleryImage);

			return view;
		}

		void _BuildConversations()
		{
			// Loads all flirtmail, no ordering. Only use this variable for adding messages to 'mConversations'.
			do { mConversations = FlirtmailBus.GetFlirtmail(MainUser.AppUser.UniqUser); } while (mConversations == null);
			mMostRecentMailCheck = DateTime.UtcNow.ToString("u");  // Grab a timestamp.

			FragmentMail.mAllFlirtMail = mConversations;

			// Returns only most recent message for each unique conversation
			mConversations = FlirtmailBus.SortIntoConversations(mConversations);
			FragmentMail.mAllFlirtMailSorted = mConversations;
		}
	}
}

