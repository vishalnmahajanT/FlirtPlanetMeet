
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Threading.Tasks;
using System.Net;
using Android.Graphics;
using Android.Content.Res;

namespace flirtplanet
{
	class ImageTask: FlirtPlanetActivity
	{
		Bitmap dummyBitmap;
		public Bitmap getProfileImageFromURL(string avatarUrl)
		{
			dummyBitmap = BitmapFactory.DecodeResource (Resources, Resource.Drawable.DD_DefaultImage);
			Bitmap imageBitmap = null;
			String finalUrl = (Core.Constants.kBaseURL.Avatar + avatarUrl);

			using (var webClient = new WebClient())
			{
				webClient.DownloadDataAsync (new Uri (finalUrl));

				webClient.DownloadDataCompleted += (object sender, DownloadDataCompletedEventArgs e) => 
				{
					var imageBytes = webClient.DownloadData(finalUrl);
					if (imageBytes != null && imageBytes.Length > 0)
					{
						imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
					}
				};
			}
			return (imageBitmap == null ? dummyBitmap : imageBitmap);
		}
	}
}

