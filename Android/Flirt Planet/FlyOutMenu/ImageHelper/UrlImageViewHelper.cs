
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;
using flirtplanet;
using System.Threading.Tasks;
using System.Net;
using Android.Content.Res;
using System.Runtime.InteropServices;
using System.Drawing;
using Android.Media;
using Javax.Crypto.Spec;

namespace UrlImageViewHelper
{
	public class UrlImageViewHelper
	{
		public const string LOGTAG = "UrlImageViewHelper";
		public const int CACHE_DURATION_INFINITE = int.MaxValue;
    	public const int CACHE_DURATION_ONE_DAY = 1000 * 60 * 60 * 24;
    	public const int CACHE_DURATION_TWO_DAYS = CACHE_DURATION_ONE_DAY * 2;
    	public const int CACHE_DURATION_THREE_DAYS = CACHE_DURATION_ONE_DAY * 3;
    	public const int CACHE_DURATION_FOUR_DAYS = CACHE_DURATION_ONE_DAY * 4;
    	public const int CACHE_DURATION_FIVE_DAYS = CACHE_DURATION_ONE_DAY * 5;
    	public const int CACHE_DURATION_SIX_DAYS = CACHE_DURATION_ONE_DAY * 6;
    	public const int CACHE_DURATION_ONE_WEEK = CACHE_DURATION_ONE_DAY * 7;
		public const int DEFAULT_IMAGE_SIZE = 100;


		public static void SetUrlDrawable(ImageView imageView, string url, int defaultResource)
		{
			SetUrlDrawable(imageView.Context, imageView, url, defaultResource, CACHE_DURATION_THREE_DAYS);
		}

		public static void SetUrlDrawable(ImageView imageView, string url)
		{
			SetUrlDrawable(imageView.Context, imageView, url, null,false, DEFAULT_IMAGE_SIZE,CACHE_DURATION_THREE_DAYS, null);
		}

		public static void LoadDrawable(Context context, string url)
		{
			 SetUrlDrawable(context, null, url, null, true, DEFAULT_IMAGE_SIZE,CACHE_DURATION_THREE_DAYS, null);
		}

		/*public static async Task<byte[]> GetImageBytes (string url)
		{
			var client = new WebClient ();
			return await client.DownloadDataTaskAsync (url);
		}*/

		public static void SetUrlDrawable(ImageView imageView, string url, Drawable defaultDrawable ,bool circle, int size )
		{
			/*BitmapFactory.Options options = new BitmapFactory.Options {
				InJustDecodeBounds = true,
				InScaled = true,
				InPreferQualityOverSpeed = false,
				InPurgeable = true,
				InInputShareable = true,
			};

			//imageView.SetImageResource (Resource.Drawable.DD_DefaultImage_loading);
			imageView.SetImageDrawable (defaultDrawable);

			//var testBmp = BitmapFactory.DecodeResource (Resource.Drawable, Resource.Drawable.DD_DefaultImage_loading, options);
			//imageView.SetImageDrawable (new CircleDrawable (bmp,Core.Constants.kCircularImageSize.freshFaces));
			var data = await GetImageBytes (url);
			var image = await BitmapFactory.DecodeByteArrayAsync (data, 0, data.Length,options);

			if (circle)
				imageView.SetImageDrawable (new CircleDrawable (image, size));
			else
				imageView.SetImageBitmap (image);*/

			SetUrlDrawable(imageView.Context, imageView, url, defaultDrawable, true, size,  CACHE_DURATION_THREE_DAYS, null);
		}

		public static void SetUrlDrawable(ImageView imageView, string url, int defaultResource, long cacheDurationMs)
		{
			SetUrlDrawable(imageView.Context, imageView, url, defaultResource, cacheDurationMs);
		}

		public static void LoadUrlDrawable(Context context, string url, long cacheDurationMs)
		{
			SetUrlDrawable(context, null, url, null,true, DEFAULT_IMAGE_SIZE, cacheDurationMs, null);
		}

		public static void SetUrlDrawable(ImageView imageView, string url, Drawable defaultDrawable, long cacheDurationMs)
		{
			SetUrlDrawable(imageView.Context, imageView, url, defaultDrawable, true, DEFAULT_IMAGE_SIZE,cacheDurationMs, null);
		}

		private static void SetUrlDrawable(Context context, ImageView imageView, string url, int defaultResource, long cacheDurationMs)
		{
			Drawable d = null;
			if (defaultResource != 0)
				d = imageView.Resources.GetDrawable(defaultResource);
			SetUrlDrawable(context, imageView, url,   d, true, DEFAULT_IMAGE_SIZE,cacheDurationMs, null);
		}

		public static void SetUrlDrawable(ImageView imageView, string url, IUrlImageViewCallback callback) 
		{
			SetUrlDrawable(imageView.Context, imageView, url,  null,  true, DEFAULT_IMAGE_SIZE,CACHE_DURATION_THREE_DAYS, callback);
	    }

	    public static void LoadUrlDrawable(Context context, string url, IUrlImageViewCallback callback) 
		{
			SetUrlDrawable(context, null, url, null, true, DEFAULT_IMAGE_SIZE,  CACHE_DURATION_THREE_DAYS, callback);
	    }

	    public static void SetUrlDrawable(ImageView imageView, string url, Drawable defaultDrawable, IUrlImageViewCallback callback) 
		{
			SetUrlDrawable(imageView.Context, imageView, url, defaultDrawable, true, DEFAULT_IMAGE_SIZE, CACHE_DURATION_THREE_DAYS, callback);
	    }

		//
		public static void SetUrlDrawable(ImageView imageView, string url, int defaultResource, bool circle, int size,[OptionalAttribute]bool featuredUser) 
		{
			SetUrlDrawable(imageView.Context, imageView, url, defaultResource, circle, size,CACHE_DURATION_THREE_DAYS, null,featuredUser);
		}

		public static void SetUrlDrawable(ImageView imageView, string url, int defaultResource, bool circle, int size,long cacheDurationMs, IUrlImageViewCallback callback) 
		{
			SetUrlDrawable(imageView.Context, imageView, url, defaultResource,circle,size, cacheDurationMs, callback);
	    }

		public static void LoadUrlDrawable(Context context, string url, bool circle, int size,long cacheDurationMs, IUrlImageViewCallback callback) 
		{
	        SetUrlDrawable(context, null, url, null, circle, size,cacheDurationMs, callback);
	    }

	    public static void SetUrlDrawable(ImageView imageView, string url, Drawable defaultDrawable, long cacheDurationMs, IUrlImageViewCallback callback) 
		{
			SetUrlDrawable(imageView.Context, imageView, url, defaultDrawable,  true, DEFAULT_IMAGE_SIZE, cacheDurationMs, callback);
	    }

		private static void SetUrlDrawable(Context context, ImageView imageView, string url, int defaultResource,  bool circle, int size,long cacheDurationMs, IUrlImageViewCallback callback,[OptionalAttribute]bool featuredUser) 
		{
	        Drawable d = null;
	        if (defaultResource != 0)
				d = imageView.Resources.GetDrawable(defaultResource);
			SetUrlDrawable(context, imageView, url, d, circle, size,  cacheDurationMs, callback,featuredUser);
	    }

		protected static HashTable<ImageView, string> pendingViews = new HashTable<ImageView, string>();
		protected static HashTable<string, List<ImageView>> pendingDownloads = new HashTable<string, List<ImageView>>();
		static bool hasCleaned = false;

		static Android.Content.Res.Resources mResources;
    	static Android.Util.DisplayMetrics mMetrics;
	    
		private static void PrepareResources(Context context) 
		{
	        if (mMetrics != null)
	            return;
			mMetrics = new Android.Util.DisplayMetrics();
	        Activity act = (Activity)context;
			act.WindowManager.DefaultDisplay.GetMetrics(mMetrics);
			var mgr = context.Assets;
	        mResources = new Android.Content.Res.Resources(mgr, mMetrics, context.Resources.Configuration);
	    }

		public static BitmapDrawable LoadDrawableFromFile(Context context, string filename, int size, bool circle) 
		{
	        PrepareResources(context);

			var coverOptions = new BitmapFactory.Options {
				InPreferQualityOverSpeed = false,
				InPurgeable = true,
				InInputShareable = true,
				InTempStorage = new byte[16*size],
			};

			var options = new BitmapFactory.Options {
				InPreferQualityOverSpeed = false,
				InPreferredConfig = Bitmap.Config.Rgb565,
				InPurgeable = true,
				InInputShareable = true,
				InTempStorage = new byte[16*size],
				InDensity = 100,
			};

			if (!circle)
			{
				using (var bitmap = Android.Graphics.BitmapFactory.DecodeFile (filename,coverOptions)) {
					return new BitmapDrawable (mResources, bitmap);
				}
			}
			else
			{
				using (var testBitmap = ThumbnailUtils.ExtractThumbnail (BitmapFactory.DecodeFile (filename, options), size, size)) {
					return new BitmapDrawable (mResources, testBitmap);
				}
			}
			//return new BitmapDrawable(mResources, bitmap);
	    }

		private static void Cleanup(Context context)
		{
			if (hasCleaned)
				return;

			hasCleaned = true;

			try
			{
				var baseDir = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

				var files = System.IO.Directory.GetFiles(baseDir);

				if (files == null || files.Length <= 0)
					return;

				foreach (var file in files)
				{
					if (!file.EndsWith(".urlimage"))
						continue;
						
					var f = new System.IO.FileInfo(file);
					if (DateTime.UtcNow > f.LastWriteTimeUtc)
						f.Delete();
				}
			}
			catch { }
		}

		private static string GetFilenameForUrl(string url)
		{
			var hashCode = url.GetHashCode().ToString().Replace("-", "N");
			return hashCode + ".urlimage";
		}

		private static void SetUrlDrawable(Context context, ImageView imageView, string url, Drawable defaultDrawable, bool circle,int size,long cacheDurationMs, IUrlImageViewCallback callback,[OptionalAttribute]bool featuredUser)
		{
			Cleanup(context);

			CircleDrawable circleDrawable;

			size = FlirtPlanetActivity.FlyoutNav.ConvertPixelsToDp (size);
		//	circle = true;

			if (imageView != null)
				pendingViews.Remove(imageView);

			if (string.IsNullOrEmpty(url))
			{
				if (imageView != null)
				{
					if (circle) 
					{
						if(featuredUser)
							imageView.SetImageDrawable (circleDrawable = new CircleDrawable (((BitmapDrawable)defaultDrawable).Bitmap, size,true));
						else
							imageView.SetImageDrawable (circleDrawable = new CircleDrawable (((BitmapDrawable)defaultDrawable).Bitmap, size));
					}
					else
						imageView.SetImageDrawable(defaultDrawable);
				}
				return;
			}

			var cache = UrlImageCache.Instance;
			var drawable = cache.Get(url);


			if (drawable != null)
			{
				//Bitmap bitDrawable = ((BitmapDrawable)drawable).Bitmap;
				//var dra1 = new CircleDrawable (bitDrawable, size);

				if (imageView != null)
				{
					if (circle) 
					{
						if(featuredUser)
							imageView.SetImageDrawable (circleDrawable = new CircleDrawable (((BitmapDrawable)drawable).Bitmap, size,true));
						else
							imageView.SetImageDrawable (circleDrawable = new CircleDrawable (((BitmapDrawable)drawable).Bitmap, size));
					}
					else
						imageView.SetImageDrawable(drawable);
				}

				if (callback != null)
					callback.OnLoaded(imageView, drawable, url, true);
				return;
			}

			var baseDir = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			var filename = System.IO.Path.Combine(baseDir, GetFilenameForUrl(url));
					
			var file = new System.IO.FileInfo(filename);

			if (file.Exists)
			{
				try
				{
					if (cacheDurationMs == CACHE_DURATION_INFINITE || DateTime.UtcNow < file.LastWriteTimeUtc.AddMilliseconds(cacheDurationMs))
					{
						drawable = LoadDrawableFromFile(context, filename,size,circle);

						if (imageView != null)
						{
							if (circle)
							{
								if(featuredUser)
									imageView.SetImageDrawable(circleDrawable = new CircleDrawable(((BitmapDrawable)drawable).Bitmap,size,true));
								else
									imageView.SetImageDrawable(circleDrawable = new CircleDrawable(((BitmapDrawable)drawable).Bitmap,size));
							}
							else
								imageView.SetImageDrawable(drawable);
						}



						//////////cache.Put(url, drawable);

						if (callback != null)
							callback.OnLoaded(imageView, drawable, url, true);

						return;
					}
					else
					{
						//TODO: File cache expired, refreshing
						Android.Util.Log.Debug(LOGTAG, "File Cache Expired: " + file.Name);
					}
				}
				catch (Exception ex)
				{
					Android.Util.Log.Debug(LOGTAG, "File Cache Exception " + ex.ToString());
				}
			}

			if (imageView != null)
			{
				if (circle) 
				{
					if (featuredUser) 
					{
						using (var testBitmap = ThumbnailUtils.ExtractThumbnail (((BitmapDrawable)defaultDrawable).Bitmap, size, size)) {
						
							imageView.SetImageDrawable (circleDrawable = new CircleDrawable (testBitmap, size, true));
						}
					} 
					else 
					{
						using (var testBitmap = ThumbnailUtils.ExtractThumbnail (((BitmapDrawable)defaultDrawable).Bitmap, size, size)) {
							imageView.SetImageDrawable (circleDrawable = new CircleDrawable (testBitmap, size));
						}
					}
				}
				else
					imageView.SetImageDrawable(defaultDrawable);
			}

	//			imageView.SetImageDrawable(defaultDrawable);

			if (imageView != null)
				pendingViews.Put(imageView, url);

			//Check to see if another view is already waiting for this url so we don't download it again
			var currentDownload = pendingDownloads.Get(url);
			if (currentDownload != null)
			{
				if (imageView != null)
					currentDownload.Add(imageView);

				return;
			}

			var downloads = new List<ImageView>();
			if (imageView != null)
				downloads.Add(imageView);

			pendingDownloads.Put(url, downloads);

			var downloaderTask = new AnonymousAsyncTask<string, string, BitmapDrawable>((p) => 
			{
				try
				{
						using(var client = new System.Net.WebClient()){
					var data = client.DownloadData(url);
		
					System.IO.File.WriteAllBytes(filename, data);
							data =null;
							return LoadDrawableFromFile(context, filename,size,circle);
						}
				}
				catch (Exception ex) 
				{
					if (!Popup.isConnectingToInternet (FlirtPlanetActivity.FlyoutNav)) 
					{
						Popup.CreateErrorPopup (FlirtPlanetActivity.FlyoutNav, Resource.String.error, Resource.String.internetError, "OK",true);
					}
					Android.Util.Log.Debug(LOGTAG, "Download Error: " + ex.ToString());
					return null; 
				}


			}, (bd) => 
			{
				try
				{
					var usableResult = bd;
					if (usableResult == null)
						usableResult = (BitmapDrawable)defaultDrawable;

					pendingDownloads.Remove(url);

					cache.Put(url, usableResult);

					foreach (var iv in downloads)
					{
						var pendingUrl = pendingViews.Get (iv);
						if (!url.Equals(pendingUrl))
							continue;
						pendingViews.Remove(iv);

						if (usableResult != null)
						{
							var fnewImage = usableResult;
							var fimageView = iv;
							{
								if (circle)
								{
									if(featuredUser)
											fimageView.SetImageDrawable(circleDrawable = new CircleDrawable(((BitmapDrawable)fnewImage).Bitmap,size,true));
									else
											fimageView.SetImageDrawable(circleDrawable = new CircleDrawable(((BitmapDrawable)fnewImage).Bitmap,size));
								}
								else
									fimageView.SetImageDrawable(fnewImage);
							}


							if (callback != null)
								callback.OnLoaded(fimageView, bd, url, false);
						}
					}
				}
				catch (Exception ex)
				{
					Android.Util.Log.Debug(LOGTAG, "PostExecute Error: " + ex.ToString()); 
				}

			});

			//drawable.Dispose ();
			circleDrawable = null;
			downloaderTask.Execute(new Java.Lang.Object[]{});
			GC.Collect (0);
		}
	}
}