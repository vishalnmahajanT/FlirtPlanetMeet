using System;
using Android.Views;
using Android.Widget;
using Android.Content;
using Android.App;
using Android.Provider;
using System.Collections.Generic;
using Android.Graphics.Drawables;
using UrlImageViewHelper;

namespace flirtplanet
{
	public class ImageAdapter : BaseAdapter
    {
		Context context;
		int[] thumbIds = {
			Resource.Drawable.DD_Con_icn_accept,Resource.Drawable.DD_Con_icn_accept,
			Resource.Drawable.DD_Con_icn_accept,Resource.Drawable.DD_Con_icn_accept,
			Resource.Drawable.DD_Con_icn_accept,Resource.Drawable.DD_Con_icn_accept
		};
        
		public ImageAdapter (Context c)
		{
			context = c;
		}

		public override int Count {
			get {// return thumbIds.Length; 
				return ProfileData.myGalleryPic.Count; 
			}
		}

		public override Java.Lang.Object GetItem (int position)
		{
			return null;
		}

		public override long GetItemId (int position)
		{
			return 0;
		}

        public override View GetView (int position, View convertView, ViewGroup parent)
        {          

			ImageView imageView;

			if (convertView == null) {  // if it's not recycled, initialize some attributes
				imageView = new ImageView (context);
				imageView.LayoutParameters = new GridView.LayoutParams (Core.Constants.kCircularImageSize.userGalleryImage, Core.Constants.kCircularImageSize.userGalleryImage);
				imageView.SetScaleType (ImageView.ScaleType.CenterCrop);
				imageView.SetPadding (8, 8, 8, 8);
			} else {
				imageView = (ImageView)convertView;
			}
	
			//	Drawable res = new CircleDrawable (ProfileData.myGalleryPic [position]);

			//////////imageView.SetImageDrawable (new CircleDrawable (ProfileData.myGalleryPic [position],Core.Constants.kCircularImageSize.userGalleryImage));
			imageView.SetUrlDrawable (Core.Constants.kBaseURL.Photo + ProfileData.myGalleryPic [position].HashedName, Resource.Drawable.DD_DefaultImage_loading,true,Core.Constants.kCircularImageSize.userGalleryImage);

			//imageView.SetImageResource (thumbIds[position]);
			return imageView;

			//return view;
        }
	}
       
}

