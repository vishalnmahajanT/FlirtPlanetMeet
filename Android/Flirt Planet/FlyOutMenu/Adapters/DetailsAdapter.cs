using System;
using Android.Views;
using Android.Widget;
using Android.Content;
using Android.App;
using Android.Provider;
using System.Collections.Generic;
using Core.Data;

namespace flirtplanet
{
	public class DetailsAdapter : BaseAdapter
	{
		List<Details> _DetailsList;
		Fragment _fragment;
		LayoutInflater _inflater;
		bool _canEdit = false;
		public DetailsAdapter (Fragment fragment,LayoutInflater inflater,bool edit = true)
		{
			_fragment = fragment;
			_inflater = inflater;
			_canEdit = edit;
			FillDetails ();
		}

		public override int Count {
			get { return _DetailsList.Count; }
		}

		public override Java.Lang.Object GetItem (int position)
		{
			return null; // could wrap a Contact in a Java.Lang.Object to return it here if needed
		}

		public override long GetItemId (int position)
		{
			return _DetailsList [position].Id;
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{          
			var view = convertView ?? _inflater.Inflate (Resource.Layout.GridItem, parent, false);
			var DetailsName = view.FindViewById<TextView> (Resource.Id.tv_detailsName);
			var DetailsImage = view.FindViewById<ImageView> (Resource.Id.im_detail);

			DetailsName.Text = _DetailsList [position].DisplayText;

			var DetailsUri = _DetailsList [position].Id;
			var DetailsPhotoUri = _DetailsList [position].PhotoId;

			DetailsImage.SetImageResource (DetailsPhotoUri);

			return view;
		}

		void FillDetails ()
		{           
			int[] height = ProfileData.mUser.GetImperialHeight();

			int AnsInches = height[0] * 12 + height[1];

			string ansheight = height[0].ToString() + "' " + height[1].ToString() + "\"";
//			List<DetailAnswer> userAnswer = new List<DetailAnswer> ();
//				userAnswer=Core.Business.ProfileBus.GrabUserAnswers(ProfileData.mUser.DetailAnswers,1);
			if(ansheight == "0' 0\"")
				ansheight="---";
			_DetailsList = new List<Details> ();   
			string[] name = { 
				ansheight, "Education", "Speaks" ,
				"Children|Want Children", "Ethnicity" ,
				"Religion", "Drinking|Smoking|Drugs", "Pets" ,
				"Body Type", "Diet","Income|Job", "Body Art"
			}; 

			int[] photo = {
				Resource.Drawable.detail_height_blue, Resource.Drawable.detail_education_blue,
				Resource.Drawable.detail_speaks_blue, Resource.Drawable.detail_kids_blue,
				Resource.Drawable.detail_ethnicity_blue, Resource.Drawable.detail_religion_blue,
				Resource.Drawable.detail_habits_blue, Resource.Drawable.detail_pets_blue,
				Resource.Drawable.detail_bodytype_blue, Resource.Drawable.detail_diet_blue,
				Resource.Drawable.detail_income_blue, Resource.Drawable.detail_bodyart_blue,

			};

			int[] Greyphoto = {

				Resource.Drawable.detail_height_grey, Resource.Drawable.detail_education_grey,
				Resource.Drawable.detail_speaks_grey, Resource.Drawable.detail_kids_grey,
				Resource.Drawable.detail_ethnicity_grey, Resource.Drawable.detail_religion_grey,
				Resource.Drawable.detail_habits_grey, Resource.Drawable.detail_pets_grey,
				Resource.Drawable.detail_bodytype_grey, Resource.Drawable.detail_diet_grey,
				Resource.Drawable.detail_income_grey, Resource.Drawable.detail_bodyart_grey,
			};

			_DetailsList.Add (new Details{
				DisplayText = ansheight,
				PhotoId = (_canEdit) ? photo [0] : Greyphoto [0]
			});

			for(int i=1;i<11;i++){
				_DetailsList.Add (new Details{
					DisplayText = DialogView.GetDescription (i),
					PhotoId = (_canEdit) ? photo [i] : Greyphoto [i]
				});
			}

		}

		class Details
		{
			public long Id { get; set; }

			public string DisplayText{ get; set; }

			public int PhotoId { get; set; }
		}
	}
}

