//--------------------------------------------------------------------------------
//
// Core.Data.FBPhotoAlbum.cs - 
//
// Copyright 2013 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System.Collections.Generic;

//--------------------------------------------------------------------------------

namespace Core.Data
{
	public class FBPhotoAlbum
	{
		#region _Variables_

		//----------------------------------------

		string mAlbumID   = string.Empty;
		string mAlbumName = string.Empty;
		string mCoverID   = string.Empty;
		int    mSize      = 0;

		List<FBPhoto> mPhotos = new List<FBPhoto>();
		
		//----------------------------------------

		#endregion _Variables_

		#region _Constructor_

		//----------------------------------------

		public FBPhotoAlbum(string _albumID, string _albumName, string _coverID, int _size)
		{
			mAlbumID   = _albumID;
			mAlbumName = _albumName;
			mCoverID   = _coverID;
			mSize      = _size;
		}

		//----------------------------------------

		#endregion _Constructor_

		#region _Properties_

		//----------------------------------------

		public string ID      { get { return mAlbumID;   } }
		public string CoverID { get { return mCoverID;   } }
		public string Name    { get { return mAlbumName; } }
		public int    Size    { get { return mSize;      } }

		//----------------------------------------

		public List<FBPhoto> Photos
		{
			get { return mPhotos;  }
			set { mPhotos = value; }
		}

		//----------------------------------------

		#endregion _Properties

	} // End Class: FBPhotoAlbum

} // End Namepace: Core.Data

//--------------------------------------------------------------------------------
// EOF




