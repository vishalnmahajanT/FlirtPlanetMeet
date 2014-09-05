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
using Core.Data;
using Core.Business;
using Core.Constants;

namespace flirtplanet
{
	public class FragmentMeet : Fragment
	{
		Spinner spinner_findMe;
		Spinner spinner_minAge;
		Spinner spinner_maxAge;
		Spinner spinner_distance;
		Button button_search;
		TextView location;

		EditText city = null;
		List<Country> countries = GeoBus.GetCountryList ();
		List<Core.Data.Location> mCities = null;
		List<string> verifiedCities = null;
		Core.Data.Location newLocation;
		public static Country country;
		int spinnerCountrySelectedItem = -1;

		MeetFetcher currentFetcher;

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) 
		{
			var view = inflater.Inflate(Resource.Layout.fragment_meet, container, false);
			//initialize the current fetcher
			currentFetcher = new MeetFetcher (MainUser.AppUser);
			FlirtPlanetActivity.FlyoutNav.ab_heart.SetColorFilter (null);
			spinner_findMe = view.FindViewById<Spinner> (Resource.Id.spinner_findMe);
			var findMe = new ArrayAdapter<string> (this.Activity, Resource.Layout.custom_spinner_meet, buildFindMeBox());
			spinner_findMe.Adapter = findMe;
			spinner_findMe.SetSelection (setDefaultLookingFor ());//get the default from profile

			spinner_minAge = view.FindViewById<Spinner> (Resource.Id.spinner_minAge);
			var minAge = new ArrayAdapter<string> (this.Activity, Resource.Layout.custom_spinner_meet, buildAgeBox ());
			spinner_minAge.Adapter = minAge;
			spinner_minAge.SetSelection (0);//always default to 18

			spinner_maxAge = view.FindViewById<Spinner> (Resource.Id.spinner_maxAge);
			var maxAge = new ArrayAdapter<string> (this.Activity, Resource.Layout.custom_spinner_meet, buildAgeBox ());
			spinner_maxAge.Adapter = maxAge;
			spinner_maxAge.SetSelection (spinner_maxAge.Adapter.Count-1);//always default to 99

			spinner_distance = view.FindViewById<Spinner> (Resource.Id.spinner_distance);
			var distance = new ArrayAdapter<string> (this.Activity, Resource.Layout.custom_spinner_meet, buildDistanceBox ());
			spinner_distance.Adapter = distance;
			spinner_distance.SetSelection (spinner_distance.Count-1);//always default to "Anywhere"

			location = view.FindViewById<TextView> (Resource.Id.tv_location);
			location.Text = MainUser.AppUser.City;
			location.Click += (sender, e) => 
			{
				getlocationpopup(Resource.Layout.AD_UpdateLocation);
			};

			button_search = view.FindViewById<Button> (Resource.Id.btn_search);


			button_search.Click += (sender, e) => 
			{

				setUpFetcherForNewSearch();
				FragmentMeetSearchResults.LoadResults(currentFetcher,false);

				Fragment currentFragment = new FragmentMeetSearchResults ();
				FragmentTransaction ft = FragmentManager.BeginTransaction ();
				ft.Replace (Resource.Id.content_frame, currentFragment)
					.AddToBackStack (null)
					.Commit ();
			};

			var buttonCoC = view.FindViewById<Button> (Resource.Id.button_CoC);
			buttonCoC.Click += (sender, e) => 
			{
				string result;
				do{result = BoostBus.IsFeatureActive(MainUser.AppUser.UniqUser,kFeature.CreamOfTheCrop); }while(result == null);

				if(!result.Equals("true"))
				{
					string header = "Cream of the Crop";
					string message = "Want to find attractive and friendly users instantly? " + 
									 "Head over to the Boosts store and pick up the Quality Scanner!";
					string buttonText = "BOOSTS STORE";

					new Popup().getpopup(this.Activity,header,message,buttonText);
				}
				else
				{
					currentFetcher = new MeetFetcher (MainUser.AppUser);
					FragmentMeetSearchResults.LoadResults(currentFetcher,true);

					Fragment currentFragment = new FragmentMeetSearchResults ();
					FragmentTransaction ft = FragmentManager.BeginTransaction ();
					ft.Replace (Resource.Id.content_frame, currentFragment)
						.AddToBackStack (null)
						.Commit ();
				}
			};

			return view;
		}

		public override void OnDestroyView ()
		{
			base.OnDestroyView ();
			countries = null;
			mCities = null;
			verifiedCities = null;
			newLocation = null;
			country = null;
			GC.Collect (0);
		}

		void setUpFetcherForNewSearch()
		{
			string lookingFor = spinner_findMe.SelectedItem.ToString ();
			currentFetcher.SetFlags (lookingFor);

			string minAge = buildAgeBox () [(int)spinner_minAge.SelectedItemId];
			currentFetcher.MinAge = Convert.ToInt16(minAge);

			string maxAge = buildAgeBox () [(int)spinner_maxAge.SelectedItemId];
			currentFetcher.MaxAge = Convert.ToInt16(maxAge);

			int distance = getDistanceBySelection((int)spinner_distance.SelectedItemId);
			currentFetcher.Distance = distance;
		}

		static List<string> buildFindMeBox()
		{
			List<string> findMeOptions = new List<string>();

			findMeOptions.Add("Males looking for Males");
			findMeOptions.Add("Males looking for Females");
			findMeOptions.Add("Females looking for Males");
			findMeOptions.Add("Females looking for Females");
			findMeOptions.Add("Anyone looking for Males");
			findMeOptions.Add("Anyone looking for Females");

			List<int> optionIds = new List<int>();
			optionIds.Add(1);
			optionIds.Add(2);
			optionIds.Add(3);
			optionIds.Add(4);
			optionIds.Add(5);
			optionIds.Add(6);

			return findMeOptions;
		}

		private int setDefaultLookingFor()
		{
			string lookingFor = currentFetcher.GetDefaultLookingFor ();
			int selectedItem = -1;

			switch (lookingFor) 
			{
				case "Males looking for Males":
					selectedItem = 0;
				break;
				case "Males looking for Females":
					selectedItem = 1;
				break;
				case "Females looking for Males":
					selectedItem = 2;
				break;
				case "Females looking for Females":
					selectedItem = 3;
				break;
				case "Anyone looking for Males":
					selectedItem = 4;
				break;
				case "Anyone looking for Females":
					selectedItem = 5;
				break;
			}
			return (selectedItem == -1 ? 0 : selectedItem);
		}

		static List<string> buildAgeBox()
		{
			List<string> ageOptions = new List<string>();
			List<int> ageIds = new List<int>();

			for (int age = 18; age <= 99; age++)
			{
				ageOptions.Add(age.ToString());
				ageIds.Add(age);
			}

			return ageOptions;
		}

		static List<string> buildDistanceBox()
		{
			List<string> distanceOptions = new List<string>();

			distanceOptions.Add("5 miles");
			distanceOptions.Add("10 miles");
			distanceOptions.Add("25 miles");
			distanceOptions.Add("50 miles");
			distanceOptions.Add("100 miles");
			distanceOptions.Add("500 miles");
			distanceOptions.Add("Anywhere");

			List<int> optionIds = new List<int>();
			optionIds.Add(5);
			optionIds.Add(10);
			optionIds.Add(25);
			optionIds.Add(50);
			optionIds.Add(100);
			optionIds.Add(500);
			optionIds.Add(-1);

			return distanceOptions;
		}

		int getDistanceBySelection(int selectedItemId)
		{
			int distance = -1;
			switch (selectedItemId) 
			{
				case 0:		distance = 5;break;

				case 1:		distance = 10;break;

				case 2:		distance = 25;break;

				case 3:		distance = 50;break;

				case 4:		distance = 100;break;

				case 5:		distance = 500;break;

				case 6:		distance = -1;break;
			}

			return distance;
		}

		/*private void getpopup(Activity activity, String headerText, String messageText, String buttonText)
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (activity);
			ad = builder.Create ();

			var customView = activity.LayoutInflater.Inflate(Resource.Layout.AD_GenericPopup, null);

			var header = customView.FindViewById <TextView> (Resource.Id.tv_header);
			var messageBody = customView.FindViewById <TextView> (Resource.Id.tv_messageBody);

			var buttonOK = customView.FindViewById <Button> (Resource.Id.button_OK);

			header.Text = headerText;
			messageBody.Text = messageText;
			buttonOK.Text = buttonText;

			buttonOK.Click += (sender, e) => 
			{
				Fragment currentFragment = new FragmentBoost ();
				FragmentTransaction ft = FragmentManager.BeginTransaction ();
				ft.Replace (Resource.Id.content_frame, currentFragment)
					.AddToBackStack (null)
					.Commit ();

				ad.Cancel();
			};

			builder.SetView(customView);

			ad = builder.Create ();
			ad.Show ();

		}*/


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

				var adapter_country = new ArrayAdapter<string> (this.Activity, Resource.Layout.custom_spinner_meet, getCountryList ());
				//var adapter_region = new ArrayAdapter<Region>(this, Android.Resource.Layout.SimpleSpinnerItem, country.Regions.);

				var adapter_region = new ArrayAdapter<string> (this.Activity, Resource.Layout.custom_spinner_meet, getRegionsOnCountryChanged ());

				spinner_country.Adapter = adapter_country;

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

				spinner_city.Adapter = adapter_city;

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