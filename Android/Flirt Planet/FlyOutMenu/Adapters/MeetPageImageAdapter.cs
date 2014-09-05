using System;
using Android.Views;
using Android.Widget;
using Android.Content;
using Android.App;
using Android.Provider;
using System.Collections.Generic;
using Android.Graphics.Drawables;
using System.Threading.Tasks;
using Android.Graphics;
using Android.Content.Res;

namespace flirtplanet
{
	public class MeetPageImageAdapter : BaseAdapter
    {
		Context context;
		int[] thumbIds = {
			Resource.Drawable.DD_Con_icn_accept,Resource.Drawable.DD_Con_icn_accept,
			Resource.Drawable.DD_Con_icn_accept,Resource.Drawable.DD_Con_icn_accept,
			Resource.Drawable.DD_Con_icn_accept,Resource.Drawable.DD_Con_icn_accept
		};
        
		public MeetPageImageAdapter (Context c)
		{
			context = c;
		}

		public override int Count {
			get 
			{
				return FragmentMeetSearchResults.mMatches.Count;
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
				imageView.LayoutParameters = new GridView.LayoutParams (Core.Constants.kCircularImageSize.freshFaces, Core.Constants.kCircularImageSize.freshFaces);
				imageView.SetScaleType (ImageView.ScaleType.CenterCrop);
				imageView.SetPadding (8, 8, 8, 8);
			} else {
				imageView = (ImageView)convertView;
			}

			imageView.SetImageDrawable (new CircleDrawable(FragmentHome.getProfileImageFromURL(FragmentMeetSearchResults.mMatches[position].Avatar),Core.Constants.kCircularImageSize.freshFaces));
			//imageView.SetImageResource (Resource.Drawable.DD_DefaultImage_loading);
			return imageView;

			//return view;
        }
	}
       
}

