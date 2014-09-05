
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
using UrlImageViewHelper;

namespace flirtplanet
{
	public class FragmentMailDetails : Fragment
	{
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate(Resource.Layout.fragment_mailDetails, container, false);

			var partnerName = view.FindViewById<TextView> (Resource.Id.tv_partnerName);
			if(partnerName != null)
				partnerName.Text = FragmentMail.partnerName;

			var mailDetailList = view.FindViewById<ListView> (Resource.Id.lv_mailDetailsList);
			mailDetailList.Adapter = new mailDetailsAdapter (this.Activity);

			var writeMail = view.FindViewById<EditText> (Resource.Id.et_composeMail);
			var sendButton = view.FindViewById<ImageView> (Resource.Id.iv_sendMail);
			sendButton.Click += (sender, e) => 
			{
				if(writeMail.Text == string.Empty || writeMail.Text == null)
					return;

				string[] result = null;

				Flirtmail newFlirtMail = new Flirtmail(MainUser.AppUser.UniqUser, FragmentMail.partnerID,writeMail.Text);
				do{result = FlirtmailBus.InsertFlirtmailRVW(MainUser.AppUser, ref newFlirtMail);} while(newFlirtMail == null);

				//add this mail to our unsorted master list
				FragmentMail.mAllFlirtMail.Add(newFlirtMail);

				mailDetailList.Adapter = new mailDetailsAdapter (this.Activity);

				writeMail.Text = string.Empty;
			
				if (result[1] == "1")
					new Popup().getReviewPopup(this.Activity);

			};

			return view;
		}
	}

	public class mailDetailsAdapter : BaseAdapter
	{
		static List<Flirtmail> 	mDetailConversations 		= new List<Flirtmail>();
		static List<Bitmap> 	mConversationImages = new List<Bitmap> ();

		//List<Flirtmail> mAllFlirtMail = null;
		string mMostRecentMailCheck = DateTime.UtcNow.ToString("u");

		Activity _activity;

		public mailDetailsAdapter(Activity activity)
		{
			_activity = activity;
			_BuildConversations ();
		}
		public override int Count {
			get {
				return mDetailConversations.Count;
			}
		}

		public override Java.Lang.Object GetItem (int position)
		{
			return mDetailConversations [position].PartnerID;
		}

		public override long GetItemId (int position)
		{
			return 0;
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			var view = convertView ?? _activity.LayoutInflater.Inflate (Resource.Layout.single_row_mail_detail, parent, false);
			var timeStamp = view.FindViewById<TextView> (Resource.Id.tv_timeStamp);
			var displayImage = view.FindViewById<ImageView> (Resource.Id.im_displayImage);
			var subjectLine = view.FindViewById<TextView> (Resource.Id.tv_subject);

			timeStamp.Text = GRTools.Text.GetScreenFriendlyTime (mDetailConversations [position].Sent);//.ToString();
			subjectLine.Text = mDetailConversations [position].Message;

			if (mDetailConversations [position] == null) 
			{
				//no visitors
			} 
			else 
			{
				bool senderIUser = MainUser.AppUser.UniqUser == mDetailConversations [position].UniqSender ? true : false;
				string url = null;

				if (senderIUser)
					url = MainUser.AppUser.Avatar;
				else
					url = mDetailConversations[position].PartnerAvatar;

				displayImage.SetUrlDrawable((Core.Constants.kBaseURL.Avatar + url) ,Resource.Drawable.DD_DefaultImage_loading,true,Core.Constants.kCircularImageSize.userGalleryImage);
			}
			return view;
		}

		void _BuildConversations()
		{
			mDetailConversations = FlirtmailBus.GrabConversation (FragmentMail.mAllFlirtMail, MainUser.AppUser.UniqUser, FragmentMail.partnerID);
			FlirtmailBus.MarkConversationRead (MainUser.AppUser.UniqUser, FragmentMail.partnerID);
		}
	}
}