
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
using Android.Graphics;
using System.Net;
using Android.Opengl;
using Xamarin.FacebookBinding.XAndroid;
using UrlImageViewHelper;

namespace flirtplanet
{
	public class FragmentFacebookAlbums : Fragment, Request.ICallback
	{
		List<FBPhotoAlbum> photoAlbum;
		ListView listViewAlbums;
		public static bool mPullCoverPhotos = false;
		public static bool showLoading = true;
		public static TextView loading;

		public FragmentFacebookAlbums(bool coverPhoto)
		{
			mPullCoverPhotos = coverPhoto;
		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) 
		{
			var view = inflater.Inflate(Resource.Layout.facebook_albums, container, false);

			loading = view.FindViewById<TextView> (Resource.Id.tv_loading);

			if (!showLoading)
				loading.Visibility = ViewStates.Gone;

			listViewAlbums = view.FindViewById<ListView> (Resource.Id.lv_albums);

			listViewAlbums.ItemClick += (sender, e) => 
			{
				FragmentTransaction ft1 = FragmentManager.BeginTransaction ();
				ft1.Replace(Resource.Id.content_frame, new FragmentFacebookAlbumPhotos(photoAlbum[e.Position].ID,photoAlbum[e.Position].Name))
					.AddToBackStack(null)
					.Commit();
			};

			// Create your fragment here
			if (listViewAlbums.Adapter == null) 
			{
				photoAlbum = new List<FBPhotoAlbum> ();
				Request.NewGraphPathRequest (Session.ActiveSession, "me/albums", this).ExecuteAsync ();
			}

			return view;
		}

		public void OnCompleted(Response response) 
		{
			// TODO Auto-generated method stub
			IGraphObject iobject = response.GraphObject;
			Org.Json.JSONObject json = iobject.InnerJSONObject;

			Org.Json.JSONArray albums = json.GetJSONArray ("data");

			for (int i =0; i < albums.Length(); i++) 
			{
				JSONObject album = albums.GetJSONObject(i);
				string cover = null;
				string count = null;

				string id = album.GetString("id");
				string name = album.GetString("name");

				if(album.Has("cover_photo"))
					cover = album.GetString("cover_photo");

				if(album.Has("count"))
					count = album.GetString("count");

				if (id != null && name != null && cover != null && count != null) 
				{
					if (mPullCoverPhotos) 
					{
						if (name == "Cover Photos") 
						{
							photoAlbum.Add (new FBPhotoAlbum (id, name, cover, Convert.ToInt16 (count)));
							i = albums.Length(); // no need to continue the execution
						}
					} 
					else 
					{
						if (name != "Cover Photos") 
						{
							photoAlbum.Add (new FBPhotoAlbum (id, name, cover, Convert.ToInt16 (count)));
						}
					}
				}
			}

			listViewAlbums.Adapter = new albumsAdapter (this.Activity, photoAlbum);

			if (photoAlbum.Count <= 0) 
			{
				loading.Text = "No Facebook photos found.";
			} 
			else 
			{
				loading.Text = "Loading...";
			}
		}

		public override void OnDestroyView ()
		{
			base.OnDestroyView ();
			listViewAlbums.Adapter = null;
			listViewAlbums = null;
			photoAlbum = null;
			showLoading = true;
			GC.Collect ();
		}

		public class albumsAdapter : BaseAdapter, Request.ICallback
		{
			Activity context;
			List<FBPhotoAlbum> album = null;

			public albumsAdapter (Activity c, List<FBPhotoAlbum> album)
			{
				context = c;
				this.album = album;
			}

			public override int Count 
			{
				get{return album.Count;}
			}

			public override Java.Lang.Object GetItem (int position)
			{
				return album[position].CoverID;
			}

			public override long GetItemId (int position)
			{
				return position;
			}

			public override View GetView (int position, View convertView, ViewGroup parent)
			{
				var view = convertView ?? context.LayoutInflater.Inflate (Resource.Layout.facebook_albums_each_item, parent, false);

				var coverPhoto = view.FindViewById<ImageView> (Resource.Id.iv_coverPhoto);
				var albumName = view.FindViewById<TextView> (Resource.Id.tv_albumName);
				var count = view.FindViewById<TextView> (Resource.Id.tv_count);

				albumName.Text = album [position].Name;
				count.Text = (album [position].Size)+ ((album [position].Size) > 1 ? " photos" : " photo");

				//Request.NewGraphPathRequest (Session.ActiveSession, album [position].CoverID, this).ExecuteAsync ();

				//TODO very bad code - need to check if this can be removed
				StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder ().PermitAll ().Build();
				StrictMode.SetThreadPolicy (policy);

				Response response = Request.NewGraphPathRequest (Session.ActiveSession, album [position].CoverID, this).ExecuteAndWait();
				IGraphObject iobject = response.GraphObject;
				Org.Json.JSONObject json = iobject.InnerJSONObject;
				string picture = json.GetString ("picture");

				//handle the loading text
				showLoading = false;
				loading.Visibility = ViewStates.Gone;

				coverPhoto.SetUrlDrawable (picture, Resource.Drawable.DD_DefaultImage_loading,false,Core.Constants.kCircularImageSize.mailDetailImage);

				return view;
			}

			public void OnCompleted(Response response)
			{
			}
		}
	}
}

