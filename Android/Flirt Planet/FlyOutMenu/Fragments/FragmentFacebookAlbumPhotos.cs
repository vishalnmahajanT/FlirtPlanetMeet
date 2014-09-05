
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Xamarin.FacebookBinding;
using Xamarin.FacebookBinding.Model;
using Org.Json;
using Core.Data;
using Core.Business;
using UrlImageViewHelper;

namespace flirtplanet
{
	public class FragmentFacebookAlbumPhotos : Fragment, Request.ICallback
	{
		string albumID = null;
		string albumName = null;
		List<FBPhoto> photos = new List<FBPhoto>();
		GridView gridViewPhotos;

		public FragmentFacebookAlbumPhotos(string albumID, string albumName)
		{
			this.albumID = albumID;
			this.albumName = albumName;
		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) 
		{
			var view = inflater.Inflate(Resource.Layout.facebook_albums_photos, container, false);

			var albumNameView = view.FindViewById<TextView> (Resource.Id.tv_albumName);
			albumNameView.Text = albumName;

			gridViewPhotos = view.FindViewById<GridView> (Resource.Id.gv_photos);

			string graphPath = (albumID + "/photos");
			Request.NewGraphPathRequest (Session.ActiveSession, graphPath, this).ExecuteAsync ();

			string selectedPhoto = null;
			var uploadPhoto = view.FindViewById<Button> (Resource.Id.button_uploadPhoto);
			uploadPhoto.Click += (sender, e) => 
			{
				if(selectedPhoto == null || selectedPhoto == string.Empty)
					return;


				if(FragmentFacebookAlbums.mPullCoverPhotos)
				{
					string result;
					do{result = ProfileBus.ChangeCoverPhoto(ProfileData.mUser,selectedPhoto);} while (result == null);
				}
				else
				{
					string [] result = null;
					do{result = ProfileBus.UploadPhotoGoal(ref MainUser.AppUser,ProfileData.mUser,1,selectedPhoto, ref MainUser.Goals);} while (result == null);

					if(result.Length == 5)
					{
						FlirtPlanetActivity.FlyoutNav.AdjustJuice();
						FlirtPlanetActivity.FlyoutNav.refreshJuiceGold();
					}
				}


				Android.App.FragmentTransaction ft1 = FragmentManager.BeginTransaction ();
				ft1.Replace(Resource.Id.content_frame, new FragmentProfile())
					.AddToBackStack(null)
					.Commit();
			};

			gridViewPhotos.SetSelector (Resource.Color.aqua_blue);

			gridViewPhotos.ItemClick += (sender, e) => 
			{
				selectedPhoto = photos[e.Position].URL;
			};

			return view;
		}

		public void OnCompleted(Response response) 
		{
			IGraphObject iobject = response.GraphObject;
			Org.Json.JSONObject json = iobject.InnerJSONObject;

			Org.Json.JSONArray albums = json.GetJSONArray ("data");

			for (int i = 0; i < albums.Length (); i++) 
			{
				JSONObject album = albums.GetJSONObject(i);

				string id = album.GetString ("id");
				string url = album.GetString ("picture");

				photos.Add (new FBPhoto (id, url));
			}

			gridViewPhotos.Adapter = new albumPhotosAdapter (this.Activity, photos);
		}
			
		public class albumPhotosAdapter : BaseAdapter
		{
			Activity context;
			List<FBPhoto> photos = null;

			public albumPhotosAdapter (Activity c, List<FBPhoto> photos)
			{
				context = c;
				this.photos = photos;
			}

			public override int Count 
			{
				get{return photos.Count;}
			}

			public override Java.Lang.Object GetItem (int position)
			{
				return photos[position].ID;
			}

			public override long GetItemId (int position)
			{
				return position;
			}

			public override View GetView (int position, View convertView, ViewGroup parent)
			{
				ImageView imageView;

				if (convertView == null) 
				{  // if it's not recycled, initialize some attributes
					imageView = new ImageView (context);
					imageView.LayoutParameters = new GridView.LayoutParams (Core.Constants.kCircularImageSize.freshFaces, Core.Constants.kCircularImageSize.freshFaces);
					//imageView.SetMinimumWidth (Core.Constants.kCircularImageSize.myFlyOutPic);
					//imageView.SetMinimumHeight (Core.Constants.kCircularImageSize.myFlyOutPic);
					imageView.SetScaleType (ImageView.ScaleType.FitXy);
					imageView.SetPadding (8, 8, 8, 8);
				} 
				else 
				{
					imageView = (ImageView)convertView;
				}

				imageView.SetUrlDrawable (photos [position].URL,Resource.Drawable.DD_DefaultImage_loading,false,Core.Constants.kCircularImageSize.freshFaces);

				return imageView;

			}
		}
	}
}

