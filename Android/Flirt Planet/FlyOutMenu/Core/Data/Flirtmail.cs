//--------------------------------------------------------------------------------
//
// Core.Data.Flirtmail.cs - 
//
// Copyright 2013 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//--------------------------------------------------------------------------------

namespace Core.Data
{
	[Serializable]
	public class Flirtmail
	{
		#region Variables

		//----------------------------------------

		int mUniqFlirtmail;
		int mUniqSender;
		int mUniqRecipient;
		int mUniqOwner;
		string mMessage;
		DateTime mSent;
		string mMailRead;
		string mReported;
		int mPartnerID;
		string mPartnerUserName;
		string mPartnerAvatar;
		string mUserName;
		string mAvatar;

		//----------------------------------------

		#endregion Variables

		#region Constructor

		//----------------------------------------

		public Flirtmail(int senderID, int recipientID, string message)
		{
			mUniqSender = senderID;
			mUniqRecipient = recipientID;
			mUniqOwner = senderID;
			mPartnerID = recipientID;
			mMessage = message;
			mMailRead = "0";
			mReported = "0";
		}

		//----------------------------------------

		#endregion Constructor

		#region Properties

		//----------------------------------------

		public int UniqFlirtmail
		{
			get { return mUniqFlirtmail; }
			set { mUniqFlirtmail = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int UniqSender
		{
			get { return mUniqSender; }
			set { mUniqSender = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int UniqRecipient
		{
			get { return mUniqRecipient; }
			set { mUniqRecipient = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int UniqOwner
		{
			get { return mUniqOwner; }
			set { mUniqOwner = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public string Message
		{
			get { return mMessage; }
			set { mMessage = value; }
		}

		//----------------------------------------

		public DateTime Sent
		{
			get { return mSent; }
			set { mSent = Convert.ToDateTime(value); }
		}

		//----------------------------------------

		public string MailRead
		{
			get { return mMailRead; }
			set { mMailRead = value; }
		}

		//----------------------------------------

		public string Reported
		{
			get { return mReported; }
			set { mReported = value; }
		}

		//----------------------------------------

		public int PartnerID
		{
			get { return mPartnerID; }
			set { mPartnerID = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public string PartnerUserName
		{
			get { return mPartnerUserName; }
			set { mPartnerUserName = value; }
		}

		//----------------------------------------

		public string PartnerAvatar
		{
			get { return mPartnerAvatar; }
			set { mPartnerAvatar = value; }
		}

		//----------------------------------------
		// Senders UserName

		public string UserName
		{
			get { return mUserName; }
			set { mUserName = value; }
		}

		//----------------------------------------
		// Senders Hashed Avatar Filename

		public string Avatar
		{
			get { return mAvatar; }
			set { mAvatar = value; }
		}

		//----------------------------------------

		#endregion Properties

	} // End Class: Flirtmail

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF




