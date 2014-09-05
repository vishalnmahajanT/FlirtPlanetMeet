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

using UrlImageViewHelper;

namespace flirtplanet
{
	public class asynchAdapter : BaseAdapter
	{
		Context context;
		ImageView imageView;

		public asynchAdapter (Context c)
		{
			context = c;
			imagePair = new Dictionary<int, ImageView> ();
		}

		protected override void Dispose (bool disposing)
		{
			base.Dispose (true);
		
			foreach (var obj in imagePair) {
				if (obj.Value != null) {
					obj.Value.Dispose ();
				}
			}
			imagePair.Clear ();
		}
		public override int Count {
			get 
			{
				return FragmentMeetSearchResults.mMatches.Count;
			}
		}

		public override Java.Lang.Object GetItem (int position)
		{
			return  (null != imagePair) ? imagePair [position]:null;
		}

		public override long GetItemId (int position)
		{
			return position;
		}
		Dictionary<int,ImageView> imagePair;

		public override View GetView (int position, View convertView, ViewGroup parent)
		{          
			if (convertView == null) {  // if it's not recycled, initialize some attributes
				imageView = new ImageView (context);
				imageView.SetLayerType (LayerType.Software, null);
				imageView.SetPadding (0, 0, 0, 10);
			} 
			else
			{
				imageView = (ImageView)convertView;
			}

			if (!imagePair.ContainsKey(position))
				imagePair.Add (position, imageView);
				
			string url = Core.Constants.kBaseURL.Avatar + FragmentMeetSearchResults.mMatches [position].Avatar.ToString ();
			if(FragmentMeetSearchResults.mMatches [position].FeaturedUser)
				imageView.SetUrlDrawable (url,Resource.Drawable.DD_DefaultImage_loading,true,Core.Constants.kCircularImageSize.freshFaces,true);
			else
				imageView.SetUrlDrawable (url,Resource.Drawable.DD_DefaultImage_loading,true,Core.Constants.kCircularImageSize.freshFaces);

			return imageView;
		}
	}
}

