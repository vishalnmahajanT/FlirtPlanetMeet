using System;
using Android.Views;
using Android.Widget;
using Android.Content;
using Android.App;
using Android.Provider;
using System.Collections.Generic;
using Android.Graphics.Drawables;
using Core.Data;

namespace flirtplanet
{
	public class ImageAdapter : BaseAdapter
    {
		List<Match> mFreshFacesList;
		Context context;
    	bool isEnabled = false;
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
				return ProfileData.myGalleryPic.Length; 
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
				imageView.LayoutParameters = new GridView.LayoutParams (85, 85);
				imageView.SetScaleType (ImageView.ScaleType.CenterCrop);
				imageView.SetPadding (8, 8, 8, 8);
			} else {
				imageView = (ImageView)convertView;
			}
	
			//	Drawable res = new CircleDrawable (ProfileData.myGalleryPic [position]);

			imageView.SetImageBitmap (getRoundedShape (image));
			//imageView.SetImageDrawable (new CircleDrawable (ProfileData.myGalleryPic [position]));
			//imageView.SetImageResource (thumbIds[position]);

				var data = await GetImageBytes (Core.Constants.kBaseURL.Avatar + mFreshFacesList [idx].Avatar);
				var image = await BitmapFactory.DecodeByteArrayAsync (data, 0, data.Length);

				//var image = (getProfileImageFromURL (mFreshFacesList [idx].Avatar));
				/////freshFacesArray [idx].SetImageDrawable (new CircleDrawable (image));
				freshFacesArray [idx].SetImageBitmap (getRoundedShape(image));
			}

	
			return imageView;

			//return view;
        }
	public static async Task<byte[]> GetImageBytes (string url)
	{
		var client = new WebClient ();
		return await client.DownloadDataTaskAsync (url);
	}

		public static Bitmap getRoundedShape(Bitmap scaleBitmapImage) 
		{
			int targetWidth = 200;
			int targetHeight = 200;
			Bitmap targetBitmap = Bitmap.CreateBitmap(targetWidth, 
				targetHeight,Bitmap.Config.Argb8888);

			Canvas canvas = new Canvas(targetBitmap);
			Android.Graphics.Path path = new Android.Graphics.Path();
			path.AddCircle(((float) targetWidth - 1) / 2,
				((float) targetHeight - 1) / 2,
				(Math.Min(((float) targetWidth), 
					((float) targetHeight)) / 2),
				Android.Graphics.Path.Direction.Ccw);

			canvas.ClipPath(path);
			Bitmap sourceBitmap = scaleBitmapImage;
			canvas.DrawBitmap(sourceBitmap, 
				new Rect(0, 0, sourceBitmap.Width,
					sourceBitmap.Height), 
				new Rect(0, 0, targetWidth, targetHeight), null);
			return targetBitmap;
		}
	}
       
}

