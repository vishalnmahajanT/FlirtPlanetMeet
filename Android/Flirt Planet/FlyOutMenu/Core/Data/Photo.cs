//--------------------------------------------------------------------------------
//
// Core.Data.Photo.cs - 
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
	public class Photo
	{
		#region Variables

		//----------------------------------------

		int mUniqPhoto;
		int mUniqUser;
		int mUniqGallery;
		string mCaption;
		string mHashedName;
		int mOrderNumber;

		//----------------------------------------

		#endregion Variables

		#region Properties

		//----------------------------------------

		public int UniqPhoto
		{
			get { return mUniqPhoto; }
			set { mUniqPhoto = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int UniqUser
		{
			get { return mUniqUser; }
			set { mUniqUser = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int UniqGallery
		{
			get { return mUniqGallery; }
			set { mUniqGallery = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public string Caption
		{
			get { return mCaption; }
			set { mCaption = value; }
		}

		//----------------------------------------

		public string HashedName
		{
			get { return mHashedName; }
			set { mHashedName = value; }
		}

		//----------------------------------------

		public int OrderNumber
		{
			get { return mOrderNumber; }
			set { mOrderNumber = Convert.ToInt32(value); }
		}

		//----------------------------------------

		#endregion Properties

	} // End Class: Photo

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF





