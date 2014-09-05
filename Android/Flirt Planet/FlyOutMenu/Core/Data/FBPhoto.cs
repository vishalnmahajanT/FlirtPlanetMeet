//--------------------------------------------------------------------------------
//
// Core.Data.FBPhoto.cs - 
//
// Copyright 2013 Game Refuge Inc
//
//--------------------------------------------------------------------------------

namespace Core.Data
{
	public class FBPhoto
	{
		#region _Variables_

		//----------------------------------------

		string mPhotoID  = string.Empty;
		string mImageURL = string.Empty;

		//----------------------------------------

		#endregion _Variables_

		#region _Constructor_

		//----------------------------------------

		public FBPhoto(string _photoID, string _imageURL)
		{
			mPhotoID  = _photoID;
			mImageURL = _imageURL;
		}

		//----------------------------------------

		#endregion _Constructor_

		#region _Properties_

		//----------------------------------------

		public string ID
		{
			get { return mPhotoID; }
		}

		//----------------------------------------

		public string URL
		{
			get { return mImageURL; }
		}

		//----------------------------------------

		#endregion _Properties_

	} // End Class: FBPhoto

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF




