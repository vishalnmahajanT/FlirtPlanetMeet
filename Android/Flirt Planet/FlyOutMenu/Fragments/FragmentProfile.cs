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
using Android.Graphics;
using Core.Business;
using Core.Data;
using Android.Views.InputMethods;
using Xamarin.FacebookBinding;
using Core.Constants;
using Xamarin.FacebookBinding.Model;
using Org.Json;
using UrlImageViewHelper;

namespace flirtplanet
{


	public class FragmentProfile : Fragment,  DatePickerDialog.IOnDateSetListener
	{
		bool editBox;
		View customView;
		TextView location = null;
		EditText city = null;
		DateTime date;

		//static List<DetailQuestion> mDetailQuestions = null;
		List<Country> countries;//= GeoBus.GetCountryList ();
		List<Core.Data.Location> mCities = null;
		List<string> verifiedCities = null;

		Core.Data.Location newLocation;
		public Country country;
		public DetailsAdapter contactsAdapter;
		public static flirtplanet.DetailsGridNoScroll gridview;
		int spinnerCountrySelectedItem = -1;
		private static LayoutInflater mInflater;
		private static FragmentProfile obj;

		public static void updateGrid ()
		{
			gridview.Adapter = new DetailsAdapter (obj,mInflater);    
		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			//Core.Data.User appuser;
			 editBox=false;
			mInflater = inflater;
			var view = inflater.Inflate(Resource.Layout.fragment_profile, container, false);
			view.SetLayerType (LayerType.Software, null);

			countries = GeoBus.GetCountryList ();

			ProfileData._BuildPhotos (ProfileData.mUser);//ProfileBus.GetOwnProfile(MainUser.AppUser.UniqUser /*350*/));
			fillProfileDataFields (view);
			EditProfileDataFields (view);
			//appuser.DetailAnswers = 23;
			List<Core.Data.DetailAnswer> userAnswer = ProfileBus.GrabUserAnswers(ProfileData.mUser.DetailAnswers, 13);

			var changeCover = view.FindViewById<TextView> (Resource.Id.tv_changeCover);
			changeCover.Click += (sender, e) => 
			{
				FragmentTransaction ft1 = FragmentManager.BeginTransaction ();
				ft1.Replace(Resource.Id.content_frame, new FragmentFacebookAlbums(true))
					.AddToBackStack(null)
					.Commit();
			};

			var review = view.FindViewById <ImageView> (Resource.Id.im_review);
			review.Click += (sender, e) => 
			{
				List<Review> reviews = null;
				do { reviews = ProfileBus.GetOwnReviews(MainUser.AppUser.UniqUser); } while (reviews == null);

				if(reviews.Count == 0)
				{
					string header = "No Reviews";
					string message = "No one has reviewed you yet :(";
					string buttonText = "OK";

					Popup popup = new Popup();
					popup.getpopup(this.Activity,header,message,buttonText);
				}
				else
				{
					getReviewPopup();
				}
			};

			var addPhotos = view.FindViewById<ImageView> (Resource.Id.im_addPhotos);

			addPhotos.Click += (object sender, EventArgs e) => 
			{
				User user = ProfileData.mUser;

				if(user.Photos.Count >= /*user.PublicPhotoCapacity*/ 5)
				{
					string header = "ERROR";
					string message = "You have reached the maximum number of photos. Delete a photo before adding a new one.";
					string buttonText = "OK";
					Popup popup = new Popup();
					popup.getpopup (this.Activity, header, message, buttonText);
				}
				else // show FB album page
				{
					FragmentTransaction ft1 = FragmentManager.BeginTransaction ();
					ft1.Replace(Resource.Id.content_frame, new FragmentFacebookAlbums(false))
						.AddToBackStack(null)
						.Commit();
				}
			};

			var reviewPercent = view.FindViewById<TextView> (Resource.Id.tv_reviewPercent);
			reviewPercent.Text = (ProfileData.mUser.PositiveReviewPercent.ToString () + "%");
			int percent = 0;
			percent = (ProfileData.mUser.PositiveReviewPercent <= 0 ? 0 : ProfileData.mUser.PositiveReviewPercent);
			reviewPercent.Text = (percent.ToString() + "%");

			var numberOfConnections = view.FindViewById<TextView> (Resource.Id.tv_numberOfConnections);
			numberOfConnections.Text = (ProfileData.mUser.NumberOfConnections).ToString();

			var privacy = view.FindViewById<LinearLayout> (Resource.Id.ll_privacy);
			var tickBox = view.FindViewById<ImageView> (Resource.Id.im_privacy);

			bool isChecked = ProfileData.mUser.HideConnectionsActive.Equals ("0") || ProfileData.mUser.HideConnectionsActive.Equals ("-1");
			if(isChecked)
				tickBox.SetImageResource(Resource.Drawable.DD_Header_icn_tickbox);
			else
				tickBox.SetImageResource(Resource.Drawable.DD_Header_icn_tickbox_empty);

			privacy.Click += (sender, e) => 
			{
				if(ProfileData.mUser.HideConnectionsActive.Equals("1") || ProfileData.mUser.HideConnectionsActive.Equals("0"))
				{
					bool isActive = ProfileData.mUser.HideConnectionsActive.Equals("1");

					string result = null;
					do { result = BoostBus.ToggleItemActive(MainUser.AppUser.UniqUser, 21); } while (result == null);

					if (result == "true")
					{
						isActive = !isActive;

						ProfileData.mUser.HideConnectionsActive = (isActive) ? "1" : "0";

						if(!isActive)
							tickBox.SetImageResource(Resource.Drawable.DD_Header_icn_tickbox);
						else
							tickBox.SetImageResource(Resource.Drawable.DD_Header_icn_tickbox_empty);
					}
				}
				else
				{
					Popup popup = new Popup();
					string header = "Hide Connections?";
					string message = "Would you like to hide how many connections you have from others? Go to the store and pick up the boost!";
					popup.getpopup(this.Activity,header,message,"boosts_store");
				}
			};

			var matchingSauce = view.FindViewById<ImageView> (Resource.Id.im_matchingSause);
			matchingSauce.Click += (sender, e) => 
			{
				FragmentTransaction ft1 = FragmentManager.BeginTransaction ();
				ft1.Replace(Resource.Id.content_frame, new FragmentSauce())
					.AddToBackStack(null)
					.Commit();
			};

			gridview = view.FindViewById<flirtplanet.DetailsGridNoScroll> (Resource.Id.gv_details);
			obj = this;
			updateGrid ();
			gridview.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args) {
				if(args.Position ==0)
					setHeigthPopup(args.Position);
				else
					DialogView.OnCreateView(this.Activity,args.Position,true);
			};

			var tv_noOwnPhotos = view.FindViewById<TextView> (Resource.Id.tv_noOwnPhotos);
			gv_Gallery = new List<ImageView> ();

			gv_Gallery.Add(view.FindViewById<ImageView> (Resource.Id.im_glImage1));
			gv_Gallery.Add(view.FindViewById<ImageView> (Resource.Id.im_glImage2));
			gv_Gallery.Add(view.FindViewById<ImageView> (Resource.Id.im_glImage3));
			gv_Gallery.Add(view.FindViewById<ImageView> (Resource.Id.im_glImage4));
			gv_Gallery.Add(view.FindViewById<ImageView> (Resource.Id.im_glImage5));
			//////////List<Photo> Photos = ProfileBus.GetOwnProfile (MainUser.AppUser.UniqUser).Photos;
			List<Photo> Photos = ProfileData.mUser.Photos;

			for (int i = 0; i < Photos.Count; i++) {
				gv_Gallery [i].SetUrlDrawable (Core.Constants.kBaseURL.Photo + Photos[i].HashedName, Resource.Drawable.DD_DefaultImage_loading,true,Core.Constants.kCircularImageSize.userGalleryImage);
				gv_Gallery[i].Click += (object sender, EventArgs e) => {

					Fragment currentFragment = new FragmentUserGallery ();
					FragmentUserGallery.ownGallery = true;
					FragmentTransaction ft = FragmentManager.BeginTransaction ();
					ft.Replace (Resource.Id.content_frame, currentFragment)
						.AddToBackStack (null)
						.Commit ();
				};
			}

			if (Photos.Count > 0) 
			{
				tv_noOwnPhotos.Visibility = ViewStates.Gone;
			} 
			else 
			{
				tv_noOwnPhotos.Visibility = ViewStates.Visible;
				tv_noOwnPhotos.Text = kMessage.Profile_OwnNoPhotos;
			}
			var edit_icon = view.FindViewById<ImageButton> (Resource.Id.im_aboutme);
			var edit_box = view.FindViewById<EditText> (Resource.Id.tv_aboutme);

			edit_icon.Click += delegate {
				edit_box.RequestFocus();
			}; 

			var edit_profile = view.FindViewById<ImageButton> (Resource.Id.im_editAsl);
			edit_profile.Click += (sender, e) => {

				getpopup(Resource.Layout.AD_Update_profile);
			
			};

			return view;
		}

		public void getReviewPopup()
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (this.Activity);
			ad = builder.Create ();
			var customView = this.Activity.LayoutInflater.Inflate (Resource.Layout.fragment_review, null);

			List<Review> _list = null;
			TextView reviewTitle, reviewSubtitle;

			do {_list = ProfileBus.GetOwnReviews (MainUser.AppUser.UniqUser);} while (_list == null);

			reviewTitle = customView.FindViewById <TextView> (Resource.Id.tv_title);
			var close = customView.FindViewById <TextView> (Resource.Id.btn_close);
			reviewSubtitle = customView.FindViewById <TextView> (Resource.Id.tv_subtitle);
			var reviewListView = customView.FindViewById <ListView> (Resource.Id.lv_review);
			var line = customView.FindViewById <View> (Resource.Id.view2);
			
			reviewSubtitle.Visibility = ViewStates.Gone;
			reviewTitle.Text = "Your Reviews";
			line.Visibility = ViewStates.Gone;

			var reviewAdapter = new ReviewAdapter (this.Activity, _list);
			reviewListView.Adapter = reviewAdapter;

			close.Click += (sender, e) => 
			{
				ad.Cancel ();
			};

			builder.SetView(customView);
			ad = builder.Create ();
			ad.Show ();
		}

		public override void OnDestroyView ()
		{
			base.OnDestroyView ();
			countries = null;
			edit_block = null;
			GC.Collect ();
		}

		List<ImageView> gv_Gallery;
		public FragmentProfile(){
			ProfileData.initializeMainUserData (MainUser.AppUser.UniqUser);
			ProfileData._BuildPhotos (ProfileData.mUser/*ProfileBus.GetOwnProfile(MainUser.AppUser.UniqUser)*/);

		}

		void editFlag (ImageButton btn,bool sender)
		{
			foreach(var pair in edit_block)
				pair.Key.SetImageResource(Resource.Drawable.DD_icn_edit);

			var imgObj = edit_block.FirstOrDefault(x => x.Key == btn).Value;

			if (sender) {
				if (!editBox) {
					editBox = true;
					btn.SetImageResource (Resource.Drawable.DD_Con_icn_accept);
				} else {
					btn.SetImageResource (Resource.Drawable.DD_icn_edit);

					imm.HideSoftInputFromWindow (imgObj.WindowToken, 0);

					editBox = false;
				}
			}
			else
				btn.SetImageResource(Resource.Drawable.DD_Con_icn_accept);
				
		}
		Dictionary<ImageButton,EditText> edit_block;

		void EditBox (object sender, EventArgs e)
		{
			ImageButton iobj = (ImageButton)sender;
			editFlag (iobj,true);
			edit_block [iobj].RequestFocus ();
		

		}
		InputMethodManager imm;
		void FocusChange (object sender, EventArgs e)
		{
			if (edit_block == null)
				return;
			EditText iobj = (EditText)sender;
			string text=null;

			switch (iobj.Id) {
			case Resource.Id.tv_aboutme:text = "aboutme"; break;
			case Resource.Id.tv_talent:text = "Talents"; break;
			case Resource.Id.tv_lookingfor:text = "LookingFor"; break;
			case Resource.Id.tv_connectme:text = "ConnectToMe"; break;
			case Resource.Id.tv_goals:text = "GoalsInLife"; break;
			case Resource.Id.tv_mattersme:text = "MattersToMe"; break;
			case Resource.Id.tv_interests:text = "Interests"; break;
			}
			var imgObj = edit_block.FirstOrDefault(x => x.Value == iobj).Key;
			editFlag (imgObj,false);

			imm = (InputMethodManager) this.Activity.GetSystemService(Context.InputMethodService);
			imm.ShowSoftInput(iobj, ShowFlags.Implicit);
		
			if (!iobj.HasFocus) 
			{
				imm.HideSoftInputFromWindow (iobj.WindowToken, 0);

				string []result = null;
				do {result = ProfileBus.UpdateUserEssayQuestionGoal (ref MainUser.AppUser, text, iobj.Text, ref MainUser.Goals);} while(result == null);

				if (result.Length == 2)
					FlirtPlanetActivity.FlyoutNav.refreshJuiceGold ();
			}
		}

		void EditProfileDataFields (View view)
		{
			edit_block = new Dictionary<ImageButton, EditText> () {
				{ view.FindViewById<ImageButton> (Resource.Id.im_aboutme), view.FindViewById<EditText> (Resource.Id.tv_aboutme) },
				{ view.FindViewById<ImageButton> (Resource.Id.im_talent), view.FindViewById<EditText> (Resource.Id.tv_talent) },
				{ view.FindViewById<ImageButton> (Resource.Id.im_lookingFor), view.FindViewById<EditText> (Resource.Id.tv_lookingfor) },
				{ view.FindViewById<ImageButton> (Resource.Id.im_connectme), view.FindViewById<EditText> (Resource.Id.tv_connectme) },
				{ view.FindViewById<ImageButton> (Resource.Id.im_goals), view.FindViewById<EditText> (Resource.Id.tv_goals) },
				{ view.FindViewById<ImageButton> (Resource.Id.im_mattersme), view.FindViewById<EditText> (Resource.Id.tv_mattersme) },
				{ view.FindViewById<ImageButton> (Resource.Id.im_interests), view.FindViewById<EditText> (Resource.Id.tv_interests) }
			};
			foreach(var pair in edit_block){
				pair.Key.Click += EditBox;
				pair.Value.FocusChange += FocusChange;
			}
		}

		public void fillProfileDataFields(View view)
		{
			var name = view.FindViewById <TextView> (Resource.Id.tv_name);
			var asl = view.FindViewById <TextView> (Resource.Id.tv_asl);
			var aboutMe = view.FindViewById<TextView> (Resource.Id.tv_aboutme);
			var talents = view.FindViewById<TextView> (Resource.Id.tv_talent);
			var lookingFor = view.FindViewById<TextView> (Resource.Id.tv_lookingfor);
			var connectToMe = view.FindViewById<TextView> (Resource.Id.tv_connectme);
			var goals = view.FindViewById<TextView> (Resource.Id.tv_goals);
			var mattersToMe = view.FindViewById<TextView> (Resource.Id.tv_mattersme);
			var interests = view.FindViewById<TextView> (Resource.Id.tv_interests);
			var displayPic = view.FindViewById<ImageView> (Resource.Id.iv_profilePic);
			var coverPhoto = view.FindViewById<ImageView> (Resource.Id.iv_coverPhoto);
			//var rating = view.FindViewById<RatingBar> (Resource.Id.rb_rating);

			name.Text = ProfileData.myUserName;
			asl.Text = (ProfileData.myAge.ToString () +"."+ProfileData.mySex+"."+ProfileData.myOrientation+"."+ProfileData.myCity+"."+ ProfileData.myCountry);
			aboutMe.Text = ProfileData.aboutMe;
			talents.Text = ProfileData.talents;
			lookingFor.Text = ProfileData.lookingFor;
			connectToMe.Text = ProfileData.connectToMe;
			goals.Text = ProfileData.goalsInLife;
			mattersToMe.Text = ProfileData.mattersToMe;
			interests.Text = ProfileData.interests;
			displayPic.SetUrlDrawable(Core.Constants.kBaseURL.Avatar + MainUser.AppUser.Avatar ,Resource.Drawable.DD_DefaultImage_loading,true,Core.Constants.kCircularImageSize.userGalleryImage);
			//displayPic.SetImageDrawable(new CircleDrawable (ProfileData.myDisplayPic,Core.Constants.kCircularImageSize.userGalleryImage));5-7
			//////////coverPhoto.SetImageBitmap (ProfileData.coverPhoto);
			coverPhoto.SetUrlDrawable(Core.Constants.kBaseURL.CoverPhoto + ProfileData.coverPhoto ,Resource.Drawable.default_cover,false,Core.Constants.kCircularImageSize.freshFaces);
		}


		public void setHeigthPopup(int resource)
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (this.Activity);

			ad = builder.Create ();

			var customView = this.Activity.LayoutInflater.Inflate(Resource.Layout.setHeightPopup, null);
			int[] height = ProfileData.mUser.GetImperialHeight();

			int AnsInches = height[0] * 12 + height[1];


			var items = new List<string>() { 
				"3'0\"","3'1\"","3'2\"","3'3\"","3'4\"","3'5\"","3'6\"","3'7\"","3'8\"","3'9\"","3'10\"","3'11\"",
				"4'0\"","4'1\"","4'2\"","4'3\"","4'4\"","4'5\"","4'6\"","4'7\"","4'8\"","4'9\"","4'10\"","4'11\"",
				"5'0\"","5'1\"","5'2\"","5'3\"","5'4\"","5'5\"","5'6\"","5'7\"","5'8\"","5'9\"","5'10\"","5'11\"",
				"6'0\"","6'1\"","6'2\"","6'3\"","6'4\"","6'5\"","6'6\"","6'7\"","6'8\"","6'9\"","6'10\"","6'11\"",
				"7'0\"","7'1\"","7'2\"","7'3\"","7'4\"","7'5\"","7'6\"","7'7\"","7'8\"","7'9\"","7'10\"","7'11\""};

			var adapter = new ArrayAdapter<string>(this.Activity, Resource.Layout.custom_spinner_meet, items);
			var spinner = customView.FindViewById<Spinner>(Resource.Id.sp_Height);
			spinner.Adapter = adapter;
			spinner.SetSelection (AnsInches - 36>0?AnsInches - 36:0);
			builder.SetView(customView);
			var btn = customView.FindViewById<Button> (Resource.Id.btn_update);
			btn.Click += (object sender, EventArgs e) => {
			
				int totalInches = (int)spinner.SelectedItemId +36;
				//string answerText = mHeightBox.GetSelectedOptionText();

				//newDescription = answerText;

				int feet = (int)Math.Floor(totalInches / 12f);
				int inches = totalInches % 12;

				//MainUser.mus.SetImperialHeight(feet, inches);
				ProfileData.mUser.SetImperialHeight(feet, inches);

				string[] heightChanged = null;
				do { heightChanged = ProfileBus.UpdateUserHeightGoal(ref MainUser.AppUser, ProfileData.mUser.Height, ref MainUser.Goals); } while (heightChanged == null);

				FragmentProfile.updateGrid();
				//if (heightChanged.Length == 2)
					//FlyoutNav.UpdateJuice(MainUser.AppUser.FlirtJuice);

				ad.Dismiss();
			};


			ad = builder.Create ();
			ad.Show ();
		}

		public void OnDateSet(DatePicker view, int year, int monthOfYear, int dayOfMonth)
		{
			date = new DateTime(year, monthOfYear + 1, dayOfMonth);
			OnDateSelected (date.ToString("dd/MM/yyyy"));
		}

		public void getpopup(int resource)
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (this.Activity);
			ad = builder.Create ();
			customView = this.Activity.LayoutInflater.Inflate(resource, null);

			if (resource == Resource.Layout.AD_Update_profile) 
			{
				var age = customView.FindViewById<TextView> (Resource.Id.tv_date);
				var gender = customView.FindViewById <TextView> (Resource.Id.spinner_gender);
				var orientation = customView.FindViewById<Spinner> (Resource.Id.spinner_orientation);
				location = customView.FindViewById<TextView> (Resource.Id.et_location);
				var update = customView.FindViewById<Button> (Resource.Id.btn_update);
				var close = customView.FindViewById <Button> (Resource.Id.btn_close);

				//For Age Update
				DateTime _date = ProfileData.mUser.BirthDate;
				String dt = _date.ToString ("dd/MM/yyyy");
				Console.WriteLine (dt);
				age.Text = dt;

				//for gender Updation
				/*var gAdapter = ArrayAdapter.CreateFromResource (this.Activity, Resource.Array.gender_array,
					Resource.Layout.custom_spinner_meet);
				gAdapter.SetDropDownViewResource (
					Resource.Layout.custom_spinner_meet);
				gender.Adapter = gAdapter;
				//set previously selected gender to gender spinner
				String gen = ProfileData.mUser.GetGender ();
				gender.SetSelection(gAdapter.GetPosition(gen));
				//getting user birthdate
				int initialSpinnerPos = gender.SelectedItemPosition;
				gender.ItemSelected += (sender, e) => 
				{
					if(e.Position != initialSpinnerPos)
					{
						gender.SetSelection(gAdapter.GetPosition(e.Position));
					}
				};*/
				gender.Text = ProfileData.mUser.GetGender ();


				//for orientation Updation
				var oAdapter = ArrayAdapter.CreateFromResource (this.Activity, Resource.Array.orientation_array,
					Resource.Layout.custom_spinner_meet);
				oAdapter.SetDropDownViewResource (
					Resource.Layout.custom_spinner_meet);
				orientation.Adapter = oAdapter;
				//set previously selected orientation to orientation spinner
				String ori = ProfileData.mUser.GetOrientation ();
				orientation.SetSelection(oAdapter.GetPosition(ori));				//getting user birthdate
				int initialSpinnerPos = orientation.SelectedItemPosition;
				orientation.ItemSelected += (sender, e) => 
				{
					if(e.Position != initialSpinnerPos)
					{
						orientation.SetSelection(oAdapter.GetPosition(e.Position));
					}
				};

				//for location Updation
				location.Text = ProfileData.mUser.City;
				location.Click += (sender, e) => 
				{
					getlocationpopup(Resource.Layout.AD_UpdateLocation);
				};

				update.Click += (sender, e) => 
				{
					string[] birthdayArray = age.Text.Split ('/');
					date = new DateTime(Convert.ToInt32(birthdayArray[2]),
						Convert.ToInt32(birthdayArray[1]),
						Convert.ToInt32(birthdayArray[0]));
					ProfileData.mUser.BirthDate = date;
					ProfileData.mUser.UpdateFlags(gender.Text, (string)orientation.SelectedItem);
					ProfileBus.UpdateUserDetails(ref MainUser.AppUser, ProfileData.mUser);
					var currentFragment = new FragmentProfile();  
					FragmentTransaction ft1 = FragmentManager.BeginTransaction ();
					ft1.Replace(Resource.Id.content_frame, currentFragment)
						.AddToBackStack(null)
						.Commit();
					ad.Cancel();
				};

				close.Click += (sender, e) => 
				{
					ad.Cancel();
				};
			}

			builder.SetView(customView);
			ad = builder.Create ();
			ad.Show ();
		}

		public void getlocationpopup(int resource)
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (this.Activity);
			ad = builder.Create ();

			var locCustomView = this.Activity.LayoutInflater.Inflate(resource/*Resource.Layout.AD_UpdateLocation*/, null);

			if (resource == Resource.Layout.AD_UpdateLocation) 
			{
				var spinner_country = locCustomView.FindViewById<Spinner> (Resource.Id.spinner_country);
				var spinner_region = locCustomView.FindViewById<Spinner> (Resource.Id.spinner_region);
				var updateButton = locCustomView.FindViewById<Button> (Resource.Id.btn_update);
				city = locCustomView.FindViewById<EditText> (Resource.Id.et_city);

				var close = locCustomView.FindViewById<ImageView> (Resource.Id.iv_close);

				var adapter_country = new ArrayAdapter<string> (this.Activity, Resource.Layout.custom_spinner_meet, getCountryList ());
				//var adapter_region = new ArrayAdapter<Region>(this, Android.Resource.Layout.SimpleSpinnerItem, country.Regions.);

				var adapter_region = new ArrayAdapter<string> (this.Activity, Resource.Layout.custom_spinner_meet, getRegionsOnCountryChanged ());

				spinner_country.Adapter = adapter_country;

				close.Click += (sender, e) => 
				{
					ad.Cancel();
				};

				spinner_country.ItemSelected += (sender, e) => 
				{
					spinnerCountrySelectedItem = Convert.ToInt16 (spinner_country.SelectedItemId);
					adapter_region = new ArrayAdapter<string> (this.Activity, Resource.Layout.custom_spinner_meet, getRegionsOnCountryChanged ());
					spinner_region.Adapter = adapter_region;
				};

				updateButton.Click += (sender, e) => 
				{
					verifiedCities = verifyLocation(spinner_country.SelectedItem.ToString(),spinner_region.SelectedItem.ToString(),city.Text);
					ProfileData.mUser.Country = spinner_country.SelectedItem.ToString();
					getlocationpopup(Resource.Layout.AD_VerifyLocation);
					ad.Cancel();
				};
			} 
			else if (resource == Resource.Layout.AD_VerifyLocation) 
			{
				var spinner_city = locCustomView.FindViewById<Spinner> (Resource.Id.spinner_city);
				var adapter_city = new ArrayAdapter<string> (this.Activity, Resource.Layout.custom_spinner_meet, verifiedCities);
				var veriFyButton = locCustomView.FindViewById<Button> (Resource.Id.btn_verify);
				var close = locCustomView.FindViewById<ImageView> (Resource.Id.iv_close);

				spinner_city.Adapter = adapter_city;

				close.Click += (sender, e) => 
				{
					ad.Cancel();
				};

				veriFyButton.Click += (sender, e) => 
				{
					location.Text = spinner_city.SelectedItem.ToString();
					city.Text = location.Text;
					ProfileData.mUser.City = location.Text;

					newLocation = mCities[Convert.ToInt16(spinner_city.SelectedItemId)];
					refreshLocation();

					ad.Cancel();
				};
			}



			builder.SetView(locCustomView);
			ad = builder.Create ();
			ad.Show ();
		}


		void  OnDateSelected(string dateCapture)
		{
			customView.FindViewById<TextView> (Resource.Id.tv_date).Text = dateCapture;

		}

		private List<string> getCountryList()
		{
			List<string> options = new List<string>();
			List<int> optionIds = new List<int> ();

			for (int id = 0; id < countries.Count; id++) 
			{
				country = countries [id];
				options.Add (country.CountryName);

				optionIds.Add (id);
			}
			return options;
		}

		private List<string> getRegionsOnCountryChanged()
		{
			int countryId = spinnerCountrySelectedItem;//Convert.ToInt16(spinner_country.SelectedItemId);
			List<string> options = new List<string> ();
			List<int> optionIds = new List<int> ();

			if (countryId > -1) 
			{
				Country selectedCountry = countries [countryId];

				for (int idx = 0; idx < selectedCountry.Regions.Count; idx++) 
				{
					Core.Data.Region region = selectedCountry.Regions [idx];

					options.Add (region.RegionName);
					optionIds.Add (idx);
				}
			}
			return options;
		}

		private  List<string> verifyLocation(String country, String region, String cityText)
		{
			if(city.Text != string.Empty)
			{
				mCities = null;
				do 
				{
					mCities = GeoBus.FindMatchingCities (countries, country, region, cityText);
				} while(mCities == null);

				List<string> options = new List<string> ();
				List<int> optionIds = new List<int> ();

				for (int id = 0; id < mCities.Count; id++) 
				{
					options.Add (mCities [id].City);
					optionIds.Add (id);
				}
				return options;
			}
			return null;
		}

		void refreshLocation()
		{
			ProfileData.mUser.StateProv = newLocation.Region;
			ProfileData.mUser.Latitude = newLocation.Latitude;
			ProfileData.mUser.Longitude = newLocation.Longitude;
		}
	}
}