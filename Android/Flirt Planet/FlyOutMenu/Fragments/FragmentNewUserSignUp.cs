
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
using Xamarin.FacebookBinding.Model;
using Android.Locations;
using Core.Business;
using Core.Data;
using Core.Constants;

namespace flirtplanet
{
	[Activity(Label = "Flirt Planet", Theme = "@android:style/Theme.Holo.Light.DarkActionBar")]
	public class FragmentNewUserSignUp : Activity
	{

		TextView welcome ;//= view.FindViewById <TextView> (Resource.Id.tv_welcome);
		TextView email ;//= view.FindViewById <TextView> (Resource.Id.tv_email);
		TextView gender ;//= view.FindViewById <TextView> (Resource.Id.tv_gender);
		TextView age ;//= view.FindViewById <TextView> (Resource.Id.tv_age);
		EditText promoCode;
		EditText location;
		EditText city;
		EditText screenName;
		TextView screenNameError;
		Button startButton;

		public static Country country;
		List<Country> countries = GeoBus.GetCountryList ();
		List<Core.Data.Location> mCities;
		List<string> verifiedCities;
		Core.Data.Location newLocation;
		bool mValidLocation = false;

		//public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView (Resource.Layout.AD_NewUserSignUp);

			welcome = FindViewById <TextView> (Resource.Id.tv_welcome);
			screenName = FindViewById <EditText> (Resource.Id.et_screenName);
			email = FindViewById <TextView> (Resource.Id.tv_email);
			gender = FindViewById <TextView> (Resource.Id.tv_gender);
			age = FindViewById <TextView> (Resource.Id.tv_age);
			location = FindViewById <EditText> (Resource.Id.et_location);
			promoCode = FindViewById <EditText> (Resource.Id.et_promoCode);
			screenNameError = FindViewById<TextView> (Resource.Id.tv_screenNameError);

			fillData (HelloFacebookSampleActivity.tempObject.iGraphUser);

			startButton = FindViewById <Button>(Resource.Id.btn_start);

			location.Click += (sender, e) => 
			{
				getpopup(Resource.Layout.AD_UpdateLocation);
			};


			startButton.Click += (sender, e) => 
			{
				if(string.IsNullOrEmpty(screenName.Text) || string.IsNullOrEmpty(location.Text))
					return;

				startButton.Clickable = false;

				HelloFacebookSampleActivity.tempObject.newUser.UserName = screenName.Text;
				string result = BusinessBase.CreateNewUser(ref MainUser.AppUser,HelloFacebookSampleActivity.tempObject.newUser,promoCode.Text);
				screenNameError.Visibility = ViewStates.Gone;

				//to handle results
				if(result == "Taken")
				{
					screenNameError.Visibility = ViewStates.Visible;
				}
				else if(result == "PromoInvalid")
				{}
				else // Success	
				{
					System.Threading.ThreadPool.QueueUserWorkItem (delegate {this.Finish();});
					StartActivity(new Intent(this, typeof(FlirtPlanetActivity)));
				}
			};

			var terms = FindViewById<TextView> (Resource.Id.tv_Terms);
			var privacyPolicy = FindViewById<TextView> (Resource.Id.tv_privacyPolicy);
			terms.Click += (sender, e) => 
			{
				Android.Net.Uri uri = Android.Net.Uri.Parse(kBaseURL.TermsOfService);
				StartActivity(new Intent(Intent.ActionView,uri));
			};

			privacyPolicy.Click += (sender, e) => 
			{
				Android.Net.Uri uri = Android.Net.Uri.Parse(kBaseURL.PrivacyPolicy);
				StartActivity(new Intent(Intent.ActionView,uri));
			};
		}

		public override void OnBackPressed ()
		{
			this.Finish ();
		}

		public void fillData(IGraphUser user)
		{
			welcome.Text = "Welcome " + user.GetProperty ("name");
			email.Text = "Email: " + user.GetProperty ("email");
			gender.Text = "Gender: " + user.GetProperty ("gender");
			age.Text = "Age: " + (MainUser.AppUser.GetAge().ToString());
		}

		int spinnerCountrySelectedItem = -1;

		public void getpopup(int resource)
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (this);
			ad = builder.Create ();

			var customView = this.LayoutInflater.Inflate(resource/*Resource.Layout.AD_UpdateLocation*/, null);

			if (resource == Resource.Layout.AD_UpdateLocation) 
			{
				var spinner_country = customView.FindViewById<Spinner> (Resource.Id.spinner_country);
				var spinner_region = customView.FindViewById<Spinner> (Resource.Id.spinner_region);
				var updateButton = customView.FindViewById<Button> (Resource.Id.btn_update);
				city = customView.FindViewById<EditText> (Resource.Id.et_city);
				var close = customView.FindViewById<ImageView> (Resource.Id.iv_close);

				var adapter_country = new ArrayAdapter<string> (this, Resource.Layout.custom_spinner_meet, getCountryList ());
				//var adapter_region = new ArrayAdapter<Region>(this, Android.Resource.Layout.SimpleSpinnerItem, country.Regions.);

				var adapter_region = new ArrayAdapter<string> (this, Resource.Layout.custom_spinner_meet, getRegionsOnCountryChanged ());

				spinner_country.Adapter = adapter_country;

				close.Click += (sender, e) => 
				{
					ad.Dismiss();
				};

				spinner_country.ItemSelected += (sender, e) => 
				{
					spinnerCountrySelectedItem = Convert.ToInt16 (spinner_country.SelectedItemId);
					adapter_region = new ArrayAdapter<string> (this, Resource.Layout.custom_spinner_meet, getRegionsOnCountryChanged ());
					spinner_region.Adapter = adapter_region;
				};

				updateButton.Click += (sender, e) => 
				{
					verifiedCities = verifyLocation(spinner_country.SelectedItem.ToString(),spinner_region.SelectedItem.ToString(),city.Text);
					HelloFacebookSampleActivity.tempObject.newUser.Country = spinner_country.SelectedItem.ToString();
					ad.Cancel();
					getpopup(Resource.Layout.AD_VerifyLocation);
				};
			} 
			else if (resource == Resource.Layout.AD_VerifyLocation) 
			{
				var spinner_city = customView.FindViewById<Spinner> (Resource.Id.spinner_city);
				var adapter_city = new ArrayAdapter<string> (this, Resource.Layout.custom_spinner_meet, verifiedCities);
				var veriFyButton = customView.FindViewById<Button> (Resource.Id.btn_verify);
				var close = customView.FindViewById<ImageView> (Resource.Id.iv_close);

				spinner_city.Adapter = adapter_city;

				close.Click += (sender, e) => 
				{
					ad.Dismiss();
				};

				veriFyButton.Click += (sender, e) => 
				{
					location.Text = spinner_city.SelectedItem.ToString();
					HelloFacebookSampleActivity.tempObject.newUser.City = location.Text;

					newLocation = mCities[Convert.ToInt16(spinner_city.SelectedItemId)];
					refreshLocation();

					ad.Cancel();
				};
			}

			builder.SetView(customView);

			ad = builder.Create ();
			ad.Show ();
		}

		void refreshLocation()
		{
			HelloFacebookSampleActivity.tempObject.newUser.StateProv = newLocation.Region;
			HelloFacebookSampleActivity.tempObject.newUser.Latitude = newLocation.Latitude;
			HelloFacebookSampleActivity.tempObject.newUser.Longitude = newLocation.Longitude;
			mValidLocation = true;
			updateStartButton ();
		}

		public List<string> verifyLocation(String country, String region, String cityText)
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

		public List<string> getCountryList()
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

		public List<string> getRegionsOnCountryChanged()
		{
			int countryId = spinnerCountrySelectedItem;//Convert.ToInt16(spinner_country.SelectedItemId);
			List<string> options = new List<string> ();
			List<int> optionIds = new List<int> ();

			if (countryId > -1) 
			{
				Country selectedCountry = countries [countryId];

				for (int idx = 0; idx < selectedCountry.Regions.Count; idx++) 
				{
					Region region = selectedCountry.Regions [idx];

					options.Add (region.RegionName);
					optionIds.Add (idx);
				}
			}
			return options;
		}

		void updateStartButton()
		{
			startButton.Enabled = (screenName.Text != string.Empty && mValidLocation);
		}
	}
}

