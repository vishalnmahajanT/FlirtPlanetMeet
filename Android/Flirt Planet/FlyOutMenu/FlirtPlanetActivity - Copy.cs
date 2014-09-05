using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Widget;
using Android.OS;
//using Xamarin.FacebookBinding;
//using Xamarin.FacebookBinding.Model;
//using Xamarin.FacebookBinding.Widget;

using Core;
using Core.Data;
using Core.Business;
using Android.Support.V4.App;
using System.Collections.Generic;
using Java.Lang;
using Java.IO;
using System;
using System.Net;
using UrlImageViewHelper;
using Android.Content.PM;
using Android.Preferences;
using Xamarin.FacebookBinding;
using Xamarin.InAppBilling;
using Xamarin.InAppBilling.Utilities;
using System.Threading.Tasks;

namespace flirtplanet
{
	[Activity(Label = "Flirt Planet",MainLauncher = false ,Theme = "@style/FlirtTheme", ScreenOrientation = ScreenOrientation.Portrait)]
	public class FlirtPlanetActivity : FragmentActivity
	{
		private DrawerLayout _drawer;
		private MyActionBarDrawerToggle _drawerToggle;
		private ScrollView _drawerList;

		private string _drawerTitle;
		private string _title;
		//AppUser appUser;//to be deleted
		public ImageView displayPic;
		public Button newMails;
		public Button newConnections;
		public Button newBoosts;
		TextView mFlirtJuice, mFlirtGold ;
		public Android.Support.V4.App.FragmentManager fragmentManager;
		public List<Item> flirtJuicelist;

		public static FlirtPlanetActivity FlyoutNav{set{mFlirtActivity = value;} get { return mFlirtActivity;}}
		public static FlirtPlanetActivity mFlirtActivity;

		#region Private Variables
		private Button _buyButton;
		private Product _selectedProduct;
		public IList<Product> _products;
		public InAppBillingServiceConnection _serviceConnection;
		private ListView _lvPurchsedItems;
		#endregion

		protected override void OnCreate(Bundle savedInstanceState)
		{
			// Attempt to attach to the Google Play Service
			StartSetup ();
			_products = new List<Product> ();

			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Flyout);

			//context = this;
			FlyoutNav = this;

			do {flirtJuicelist = BusinessBase.GetItemsForFlirtJuicePopup ();} while(flirtJuicelist == null);

			//appUser = BusinessBase.GetUserWithFacebookID ("100008315088518");//to be deleted - 8518 - behera.jaga
			//appUser = BusinessBase.GetUserWithFacebookID ("100004663608949");//to be deleted - Vi
			//appUser = BusinessBase.GetUserWithFacebookID ("100006965958394");//to be deleted - Sonya
			//////////appUser = BusinessBase.GetUserWithFacebookID ("100005539308103");//to be deleted - vishalisin

		//	MainUser.InitializeUser(appUser);//to be deleted

			//deleting a user from flirt planet database
			//////////BusinessBase.DeleteUserWithFacebookID ("100006965958394");

			fragmentManager = SupportFragmentManager;

			do { MainUser.Notifications = BusinessBase.UpdateNotifications(MainUser.AppUser.UniqUser, string.Empty); }
					while (MainUser.Notifications == null); 

			if(MainUser.AppUser != null)
				BusinessBase.ToggleSWRVESession (MainUser.AppUser.UniqFacebook, "Start");

			_title = _drawerTitle = Title;
			_drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
			_drawerList = FindViewById<ScrollView>(Resource.Id.left_drawer);

			///////////////
			var name = FindViewById <TextView> (Resource.Id.tv_myDisplayName);
			var asl = FindViewById <TextView> (Resource.Id.tv_myasl);
			mFlirtJuice = FindViewById<TextView> (Resource.Id.tv_mFlirtJuice);
			mFlirtGold = FindViewById<TextView> (Resource.Id.tv_gold);
			displayPic = FindViewById<ImageView> (Resource.Id.iv_myProfilePic);
			ProfileData.initializeMainUserData (MainUser.AppUser.UniqUser);
			name.Text = ProfileData.myUserName;
			asl.Text = (ProfileData.myAge.ToString () +"."+ProfileData.mySex+"."+ProfileData.myCity+"."+ ProfileData.myCountry);
			refreshJuiceGold ();
			//mFlirtJuice.Text = (MainUser.AppUser.FlirtJuice.ToString());
			//mFlirtGold.Text = (MainUser.AppUser.Android_FlirtGold.ToString());
			//////////displayPic.SetImageDrawable(new CircleDrawable (ProfileData.myDisplayPic,Core.Constants.kCircularImageSize.myFlyOutPic));
			displayPic.SetUrlDrawable(Core.Constants.kBaseURL.Avatar + ProfileData.myDisplayPic ,Resource.Drawable.DD_DefaultImage_loading,true,Core.Constants.kCircularImageSize.myFlyOutPic);
			///////////////
			/// 
			displayPic.Click += (object sender, EventArgs e) => {
				getFragment(Resource.Id.menu_profile);
			};
			InitialFlirtJuice = MainUser.AppUser.FlirtJuice;
			InitialFlirtGold = MainUser.AppUser.Android_FlirtGold;
			_drawer.SetDrawerShadow(Resource.Drawable.drawer_shadow_dark, (int)GravityFlags.Start);

			dailyLoginCheck ();

			ActionBar.SetDisplayHomeAsUpEnabled(true);
			ActionBar.SetHomeButtonEnabled(true);
			ActionBar.SetDisplayShowTitleEnabled (false);
			ActionBar.SetDisplayShowCustomEnabled (true);
			//ActionBar.SetDisplayShowHomeEnabled (false);
			LayoutInflater inflator = (LayoutInflater) this.GetSystemService(Context.LayoutInflaterService);
			View v = inflator.Inflate(Resource.Layout.action_bar_linear, null);

			var ab_heart = v.FindViewById (Resource.Id.im_heart);
			var ab_boost = v.FindViewById (Resource.Id.im_boost);

			ab_heart.Click += (object sender, System.EventArgs e) => {
				getFragment(Resource.Id.ll_meet);

			};

			ab_boost.Click += (object sender, EventArgs e) => {
				getFragment(Resource.Id.ll_boost);
			};
			var param = new ActionBar.LayoutParams(ActionBar.LayoutParams.MatchParent, ActionBar.LayoutParams.WrapContent);

			ActionBar.SetCustomView (v, param);

			//DrawerToggle is the animation that happens with the indicator next to the
			//ActionBar icon. You can choose not to use this.
			_drawerToggle = new MyActionBarDrawerToggle(this, _drawer,
				Resource.Drawable.ic_drawer,
				Resource.String.DrawerOpen,
				Resource.String.DrawerClose);

			//You can alternatively use _drawer.DrawerClosed here
			_drawerToggle.DrawerClosed += delegate
			{
				// ActionBar.Title = _title;
				InvalidateOptionsMenu();
			};

			//You can alternatively use _drawer.DrawerOpened here
			_drawerToggle.DrawerOpened += delegate
			{
				updateNotificationCounters();
				// ActionBar.Title = _drawerTitle;
				InvalidateOptionsMenu();
			};


			_drawer.SetDrawerListener(_drawerToggle);

			if (null == savedInstanceState)
				getFragment(0);

			/*FragmentTransaction ft = FragmentManager.BeginTransaction();
			if (savedInstanceState == null) {
				FragmentHome homeFragment = new FragmentHome ();
				ft.Add (Resource.Id.content_frame, homeFragment);
				ft.Commit ();
			}*/

			var menu = FindViewById<FlyOutContainer> (Resource.Id.FlyOutContainer);

			var getMoreFlirtJuice = FindViewById<LinearLayout> (Resource.Id.ll_flirtjuice);
			getMoreFlirtJuice.Click += (sender, e) => 
			{
				getBuyPopup(Resource.Id.ll_flirtjuice, 0);
			};

			var getMoreGold = FindViewById<LinearLayout> (Resource.Id.ll_gold);
			getMoreGold.Click += (sender, e) => 
			{
				getBuyPopup(Resource.Id.ll_gold, 0);
			};

			//var menuButton = FindViewById (Resource.Id.MenuButton);
			var meet = FindViewById<LinearLayout> (Resource.Id.ll_meet);
			var conn = FindViewById<RelativeLayout> (Resource.Id.ll_conn);
			var settings = FindViewById<LinearLayout> (Resource.Id.ll_settings);
			var home = FindViewById<LinearLayout> (Resource.Id.ll_home);
			var mail = FindViewById<RelativeLayout> (Resource.Id.ll_mail);
			var boost = FindViewById<RelativeLayout> (Resource.Id.ll_boost);
			//var profile = FindViewById<LinearLayout> (Resource.Id.ll_profile);


			meet.Click += (sender, e) => 
			{
				getFragment(Resource.Id.ll_meet);
			};

			conn.Click += (sender, e) => 
			{
				getFragment(Resource.Id.ll_conn);
			};

			settings.Click += (sender, e) => 
			{
				getFragment(Resource.Id.ll_settings);
			};

			home.Click += (sender, e) => 
			{
				getFragment(Resource.Id.ll_home);
			};

			mail.Click += (sender, e) => 
			{
				getFragment(Resource.Id.ll_mail);
			};
			boost.Click += (sender, e) => 
			{
				getFragment(Resource.Id.ll_boost);
			};

			newMails = FindViewById<Button> (Resource.Id.button_newMail);
			newConnections = FindViewById<Button> (Resource.Id.button_connections);
			newBoosts = FindViewById<Button> (Resource.Id.button_newBoost);
			//TODO updateNotificationCounters ();

			//===============================================================================
			//Register to GCM 

			ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences (this);
			ISharedPreferencesEditor editor = prefs.Edit ();

			string restoredId = prefs.GetString ("regId", null);

			if (string.IsNullOrEmpty (restoredId)) 
			{

				Intent registrationIntent = new Intent ("com.google.android.c2dm.intent.REGISTER");
				registrationIntent.PutExtra ("app", PendingIntent.GetBroadcast (this, 0, new Intent (), 0));
				registrationIntent.PutExtra ("sender", "199710053551");
				this.StartService (registrationIntent);
				System.Console.WriteLine ("Registering to GCM +++++++++++++++++++++++++++++++ ");
			}
			//==================================================================================
			//unregister
			/*
			Intent unregIntent = new Intent("com.google.android.c2dm.intent.UNREGISTER");
			unregIntent.PutExtra("app", PendingIntent.GetBroadcast(this, 0, new Intent(), 0));
			this.StartService(unregIntent);
*/

			//=================================================================================

		}

		public override void OnLowMemory ()
		{
			base.OnLowMemory ();
			GC.Collect (GC.MaxGeneration);
		}

		private void SelectItem(int position)
		{

			var currentFragment = new FragmentMeet();

			Android.App.FragmentTransaction ft1 = FragmentManager.BeginTransaction ();
			ft1.Replace(Resource.Id.content_frame, currentFragment)
				.AddToBackStack(null)
				.Commit();
			_drawer.CloseDrawer(_drawerList);
		}

		public override void OnBackPressed ()
		{
			this.FragmentManager.PopBackStack ();
		}

		protected override void OnPostCreate(Bundle savedInstanceState)
		{
			base.OnPostCreate(savedInstanceState);
			_drawerToggle.SyncState();
		}

		public override bool OnPrepareOptionsMenu(IMenu menu)
		{
			//var hasNoti = MainUser.Notifications.NewNotifications();
			//menu.FindItem (Resource.Id.action_pending).SetIcon ( MainUser.Notifications.NewNotifications()?Resource.Drawable.DD_Header_icn_new_notifications:Resource.Drawable.DD_Header_icn_notification);
			return base.OnPrepareOptionsMenu(menu);
		}

		public override void OnConfigurationChanged(Configuration newConfig)
		{
			base.OnConfigurationChanged(newConfig);
			_drawerToggle.OnConfigurationChanged(newConfig);
		}

		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			MenuInflater.Inflate(Resource.Menu.main, menu);
			return base.OnCreateOptionsMenu(menu);
		}

		public void getFragment(int resource)
		{
			Android.App.Fragment currentFragment;

			switch (resource)
			{
			case  Resource.Id.ll_meet:
				currentFragment = new FragmentMeet();  
				break;

			case  Resource.Id.ll_conn:  
				currentFragment = new FragmentConnectionTab(); 
				break;

			case  Resource.Id.ll_settings:  
				currentFragment = new FragmentSettings();          
				break;

			case  Resource.Id.ll_mail: 
				currentFragment = new FragmentMail(); 
				break;

			case  Resource.Id.menu_profile:  
				currentFragment = new FragmentProfile();           
				break;

			case Resource.Id.menu_matching:  
				currentFragment = new FragmentSauce();        
				break;

			case  Resource.Layout.fragment_onMenu:  
				currentFragment = new FragmentOnMenu(); 
				break;

			case Resource.Id.ll_boost:
			case Resource.Id.menu_inventory:

				currentFragment = new FragmentBoost ();
				break;
			default:  currentFragment = new FragmentHome();     
				break;
			}

			Android.App.FragmentTransaction ft1 = FragmentManager.BeginTransaction ();
			ft1.Replace(Resource.Id.content_frame, currentFragment)
				.AddToBackStack(null)
				.Commit();

			_drawer.CloseDrawer(_drawerList);
		}

		int daysLoggedIn = -1;
		void dailyLoginCheck()
		{
			string days = BusinessBase.Login (ref MainUser.AppUser);

			daysLoggedIn = Convert.ToInt16 (days);

			if (daysLoggedIn > 0) 
			{
				getDailyLoginBonusPopup ();
			}
		}

		public void getDailyLoginBonusPopup()
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (this);
			ad = builder.Create ();

			var customView = this.LayoutInflater.Inflate(Resource.Layout.AD_DailyBonus, null);

			var imageDay1 = customView.FindViewById<ImageView> (Resource.Id.iv_day1);
			var textDay1 = customView.FindViewById<TextView> (Resource.Id.tv_day1);

			var imageDay2 = customView.FindViewById<ImageView> (Resource.Id.iv_day2);
			var textDay2 = customView.FindViewById<TextView> (Resource.Id.tv_day2);

			var imageDay3 = customView.FindViewById<ImageView> (Resource.Id.iv_day3);
			var textDay3 = customView.FindViewById<TextView> (Resource.Id.tv_day3);

			var imageDay4 = customView.FindViewById<ImageView> (Resource.Id.iv_day4);
			var textDay4 = customView.FindViewById<TextView> (Resource.Id.tv_day4);

			var imageDay5 = customView.FindViewById<ImageView> (Resource.Id.iv_day5);
			var textDay5 = customView.FindViewById<TextView> (Resource.Id.tv_day5);

			switch (daysLoggedIn) 
			{
			case 1:
				textDay2.Visibility = textDay3.Visibility = textDay4.Visibility = textDay5.Visibility = ViewStates.Invisible;
				imageDay2.SetImageResource (Resource.Drawable.DD_icn_question);
				imageDay3.SetImageResource (Resource.Drawable.DD_icn_question);
				imageDay4.SetImageResource (Resource.Drawable.DD_icn_question);
				imageDay5.SetImageResource (Resource.Drawable.DD_icn_question);
				break;
			case 2:
				textDay3.Visibility = textDay4.Visibility = textDay5.Visibility = ViewStates.Invisible;
				imageDay3.SetImageResource (Resource.Drawable.DD_icn_question);
				imageDay4.SetImageResource (Resource.Drawable.DD_icn_question);
				imageDay5.SetImageResource (Resource.Drawable.DD_icn_question);
				break;
			case 3:
				textDay4.Visibility = textDay5.Visibility = ViewStates.Invisible;
				imageDay4.SetImageResource (Resource.Drawable.DD_icn_question);
				imageDay5.SetImageResource (Resource.Drawable.DD_icn_question);
				break;
			case 4:
				textDay5.Visibility = ViewStates.Invisible;
				imageDay5.SetImageResource (Resource.Drawable.DD_icn_question);
				break;
			}

			var continueButton = customView.FindViewById<Button>(Resource.Id.b_continue);
			continueButton.Click += (sender, e) => 
			{
				ad.Dismiss();
				FlirtPlanetActivity.FlyoutNav.AdjustJuice();
				FlirtPlanetActivity.FlyoutNav.refreshJuiceGold();
			};

			builder.SetView(customView);
			ad = builder.Create ();
			ad.Show ();
		}

		public AlertDialog adJuice;

		public void getBuyPopup(int resource, int position)
		{
			//AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (FlyoutNav);
			LayoutInflater inflater = FlyoutNav.LayoutInflater;
			adJuice = builder.Create ();

			if (resource == Resource.Id.ll_flirtjuice) 
			{
				//				builder.SetView(inflater.Inflate(Resource.Layout.AD_GetMoreFlirtJuice, null));
				//				ad.SetTitle ("Buy More Flirt Juice");
				var view = inflater.Inflate (Resource.Layout.AD_BuyFlirtJuice, null);
				var flirtJuiceListView = view.FindViewById<ListView> (Resource.Id.lv_juice);
				var close = view.FindViewById <Button> (Resource.Id.btn_close);
				flirtJuiceListView.Adapter = new FlirtJuiceAdapter (FlyoutNav, ref FlirtPlanetActivity.FlyoutNav.flirtJuicelist);

				close.Click += (sender, e) => {
					adJuice.Cancel ();
				};

				builder.SetView (view);

			} 
			else if (resource == Resource.Id.ll_gold) 
			{
				//				builder.SetView(inflater.Inflate(Resource.Layout.AD_BuyFlirtGold, null));
				//				ad.SetTitle ("Get More Flirt Gold");

				var view = inflater.Inflate (Resource.Layout.AD_BuyFlirtGold, null);
				var close = view.FindViewById <Button> (Resource.Id.btn_close);
				var flirtGoldListView = view.FindViewById <ListView> (Resource.Id.lv_gold);
				flirtGoldListView.Adapter = new FlirtGoldAdapter (FlyoutNav);

				close.Click += (sender, e) => {
					adJuice.Cancel ();
				};

				builder.SetView (view);
			} /*else if (resource == Resource.Layout.AD_Confirm_Purchase) {
			
				var view = inflater.Inflate (Resource.Layout.AD_Confirm_Purchase, null);
				var close = view.FindViewById <Button> (Resource.Id.btn_close);

				var cMessage = view.FindViewById <TextView> (Resource.Id.tv_confirm);
				var cBuy = view.FindViewById <Button> (Resource.Id.btn_buy);

				cMessage.Text = "Are you sure to purchase this one full Flirt Juice" +
					" container (100 FJ) for " + FlirtPlanetActivity.FlyoutNav.flirtJuicelist [position].Cost + " Flirt Gold?";

				close.Click += (sender, e) => {
					ad.Cancel ();
				};

				cBuy.Click += (sender, e) => {

				ad.Cancel ();
				
				string [] result = null;
				do{result = BusinessBase.PurchaseFlirtJuicePack(ref MainUser.AppUser, FlirtPlanetActivity.FlyoutNav.flirtJuicelist[position].UniqItem);} while (result == null);

				if (result.Length == 1)
				{
					FlyoutNav.AdjustGold();
				}
				else if(result.Length == 2)
				{
					//FlyoutNav.AdjustJuice();
					FlyoutNav.AdjustGold();
					FlirtPlanetActivity.FlyoutNav.refreshJuiceGold();
				}
			};

				builder.SetView (view);
			}*/
			adJuice = builder.Create ();
			adJuice.SetCancelable(true);
			adJuice.Show ();
		}

		public void getConfirmBuyJuicePopup(int position, int uses)
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (FlyoutNav);
			LayoutInflater inflater = FlyoutNav.LayoutInflater;
			ad = builder.Create ();

			var view = inflater.Inflate (Resource.Layout.AD_Confirm_Purchase, null);
			var close = view.FindViewById <Button> (Resource.Id.btn_close);

			var cMessage = view.FindViewById <TextView> (Resource.Id.tv_confirm);
			var cBuy = view.FindViewById <Button> (Resource.Id.btn_buy);

			if (uses == 1) {
				cMessage.Text = "Are you sure to purchase this one full Flirt Juice" +
				" container (100 FJ) for " + FlirtPlanetActivity.FlyoutNav.flirtJuicelist [position].Cost + " Flirt Gold?";
			} else {
			
				cMessage.Text = "Are you sure to purchase these "+ uses + " packs of full Flirt Juice" +
					" containers (100 FJ each) for " + FlirtPlanetActivity.FlyoutNav.flirtJuicelist [position].Cost + " Flirt Gold?";
			}
			close.Click += (sender, e) => {
				ad.Cancel ();
			};

			cBuy.Click += (sender, e) => {

				ad.Cancel ();

				string [] result = null;
				do{result = BusinessBase.PurchaseFlirtJuicePack(ref MainUser.AppUser, FlirtPlanetActivity.FlyoutNav.flirtJuicelist[position].UniqItem);} while (result == null);

				if (result.Length == 1)
				{
					FlyoutNav.AdjustGold();
				}
				else if(result.Length == 2)
				{
					//FlyoutNav.AdjustJuice();
					FlyoutNav.AdjustGold();
					FlirtPlanetActivity.FlyoutNav.refreshJuiceGold();

					if(FragmentSideJuicePack.juicePackObject != null)
						FragmentSideJuicePack.juicePackObject.FlirtJuicePacksLeft += uses;
				}
			};

			builder.SetView (view);
			ad = builder.Create ();
			ad.SetCancelable(true);
			ad.Show ();
		}

		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			if (_drawerToggle.OnOptionsItemSelected(item))
				return true;

			switch (item.ItemId)
			{
			case Resource.Id.action_profile:
				{
					_drawer.CloseDrawer(_drawerList);

					View popItem = FindViewById (Resource.Id.action_profile);
					PopupMenu menu1 = new PopupMenu (this, popItem);
					menu1.Inflate (Resource.Menu.profile_menu);

					menu1.MenuItemClick += (s1, arg1) => {


						var items = arg1.Item;
						if (items.ItemId == Resource.Id.menu_profile) {
							getFragment(Resource.Id.menu_profile);
						} 
						else if (items.ItemId == Resource.Id.menu_inventory) {
							getFragment(Resource.Id.menu_inventory);
						} else {
							getFragment(Resource.Id.menu_matching);
						}
						arg1.Handled = true;

					};

					// Android 4 now has the DismissEvent
					menu1.DismissEvent += (s2, arg2) => {
						//Console.WriteLine ("menu dismissed"); 
					};

					menu1.Show ();

					return true;
				}

			default:
				return base.OnOptionsItemSelected(item);
			}
		}

		//Android.Views.Accessibility.Action NumberAnim;
		int InitialFlirtJuice;
		int InitialFlirtGold;
		public  void AdjustJuice ()
		{
			System.Action NumberAnim=null;

			Handler animator = new Handler ();
			var factor = System.Math.Abs (MainUser.AppUser.FlirtJuice - InitialFlirtJuice);
			_drawer.OpenDrawer (_drawerList);
			NumberAnim = ()=> {
				if(InitialFlirtJuice < MainUser.AppUser.FlirtJuice)
				{
					InitialFlirtJuice+=1;
					mFlirtJuice.Text = ""+InitialFlirtJuice;
				}
				else if (InitialFlirtJuice > MainUser.AppUser.FlirtJuice)
				{
					InitialFlirtJuice-=1;
					mFlirtJuice.Text = ""+InitialFlirtJuice;
				}
				else 
				{
					animator.RemoveCallbacks(NumberAnim);
					animator.Dispose();
					animator =null;
					_drawer.CloseDrawer(_drawerList);
				}
				if(animator != null)
					animator.PostDelayed(NumberAnim, (2000/ factor));
			};
			int value = MainUser.AppUser.FlirtJuice;
			animator.PostDelayed (NumberAnim,  0);

		}

		public  void AdjustGold ()
		{
			Handler animator = new Handler ();
			System.Action NumberAnim=null;

			_drawer.OpenDrawer (_drawerList);
			var factor = System.Math.Abs (MainUser.AppUser.Android_FlirtGold - InitialFlirtGold);

			NumberAnim = ()=> {

				if(InitialFlirtGold < MainUser.AppUser.Android_FlirtGold)
				{
					InitialFlirtGold+=1;
					mFlirtGold.Text = ""+InitialFlirtGold;
				}
				else if (InitialFlirtGold > MainUser.AppUser.Android_FlirtGold)
				{
					InitialFlirtGold-=1;
					mFlirtGold.Text = ""+InitialFlirtGold;
				}
				else 
				{
					animator.RemoveCallbacks(NumberAnim);
					animator.Dispose();
					animator =null;
					_drawer.CloseDrawer(_drawerList);
				}

				if(animator != null)
					animator.PostDelayed(NumberAnim, (2000/factor));
					
			};

			animator.PostDelayed (NumberAnim, 0);

		}

		public void refreshJuiceGold()
		{
			mFlirtJuice.Text = (MainUser.AppUser.FlirtJuice.ToString());
			mFlirtGold.Text = (MainUser.AppUser.Android_FlirtGold.ToString());
		}

		public void updateNotificationCounters()
		{
			do {MainUser.Notifications = BusinessBase.UpdateNotifications (MainUser.AppUser.UniqUser, string.Empty);} while (MainUser.Notifications == null);

			if (MainUser.Notifications.UnreadFlirtmail > 0) 
			{
				newMails.Visibility = ViewStates.Visible;
				newMails.Text = ("+" + MainUser.Notifications.UnreadFlirtmail.ToString ());
			} 
			else 
			{
				newMails.Visibility = ViewStates.Gone;
			}

			if (MainUser.Notifications.PendingConnections + MainUser.Notifications.NewConnections > 0) 
			{
				newConnections.Visibility = ViewStates.Visible;
				newConnections.Text = ("+" + (MainUser.Notifications.PendingConnections + MainUser.Notifications.NewConnections));
			} 
			else 
			{
				newConnections.Visibility = ViewStates.Gone;
			}

			if (MainUser.Notifications.FlirtJuiceRefunds > 0) 
			{
				newBoosts.Visibility = ViewStates.Visible;
				newBoosts.Text = ("+" + MainUser.Notifications.FlirtJuiceRefunds.ToString());
			}
			else
			{
				newBoosts.Visibility = ViewStates.Gone;
			}
		}


		#region Public Methods
		/// <summary>
		/// Starts the setup of this Android application by connection to the Google Play Service
		/// to handle In-App purchases.
		/// </summary>
		public void StartSetup ()
		{
			// A Licensing and In-App Billing public key is required before an app can communicate with
			// Google Play, however you DON'T want to store the key in plain text with the application.
			// The Unify command provides a simply way to obfuscate the key by breaking it into two or
			// or more parts, specifying the order to reassemlbe those parts and optionally providing
			// a set of key/value pairs to replace in the final string. 
		/*	string value = Security.Unify (
				new string[] { "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAtpopeFYhDOOsufNhYe2PY97azBQBJoqGSP/XxsgzQgj3M0MQQ0WE0WDwPKoxlo/MIuoadVR5q2ZRs3rTl", 
					"UsH9vYUPr/z0/O8kn5anQHshQkHkeHsA8wbyJGGmwcXqvZr1fnzFOFyHL46s47vOJBLc5x30oieJ02dNxdBcy0oFEJtJS5Ng5sm6YUv9ifgxYOqMr/K61HNw6tP0j", 
					"vi6vLv2ro/KXO0ADVxcDxEg+Pk16xVNKgnei8M09PJCgA9bWNyeSsD+85Jj9+OZGsS/DN7O7nrGuKx8oAg/lE6a2eCQHh9lXxSPlAFAMH2FB8aNxUeJxkByW+6l/S", 
					"yqvVlOeYxAwIDAQAB" }, 
				new int[] { 0,1,2,3 });*/

			string public_key = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAktCz7OBdrhypu2r9NL+eafN0S4awvzGn5zxLrQahMtopFBOTCX6XX8nOFIBy+FaOtvFu5uhJZde797QlQhJ1BUd/m+MiK2QrsbdY/05t9G/HgbXpHCy8dBASjOmz1flwroMnMC6PsALC2fwbvV5j/lhQSY4jDgNj/Tf28s3qdPPeqcEbG2/gtjJGQzZkJuPgBhXalMoDrPXNZWBVq/Y7txvo9ULEZuDN1dkX8zzyHoYLX/fg12Ce0+vHVwFdWj/TQXO5GYYckWCsjfg/P9fRte0+R2s8vB3g/DWnrHztxZWanlEdvsoTKahJOllrlGmxyrtUGpKwoePC3kMcqTzmRwIDAQAB";
			// Create a new connection to the Google Play Service
			_serviceConnection = new InAppBillingServiceConnection (this, public_key);
			_serviceConnection.OnConnected += () => {
				// Attach to the various error handlers to report issues
				_serviceConnection.BillingHandler.OnGetProductsError += (int responseCode, Bundle ownedItems) => {
					System.Console.WriteLine("Error getting products");
				};

				_serviceConnection.BillingHandler.OnInvalidOwnedItemsBundleReturned += (Bundle ownedItems) => {
					System.Console.WriteLine("Invalid owned items bundle returned");
				};

				_serviceConnection.BillingHandler.OnProductPurchasedError += (int responseCode, string sku) => {
					System.Console.WriteLine("Error purchasing item {0}",sku);
				};

				_serviceConnection.BillingHandler.OnPurchaseConsumedError += (int responseCode, string token) => {
					System.Console.WriteLine("Error consuming previous purchase");
				};

				_serviceConnection.BillingHandler.InAppBillingProcesingError += (message) => {
					System.Console.WriteLine("In app billing processing error {0}",message);
				};
				System.Console.WriteLine("++++++++++++++++++ OnConnection Fail ++++++++++++++++++++++");
				// Load inventory or available products
				GetInventory();

				// Load any items already purchased
				LoadPurchasedItems();
			};

			// Attempt to connect to the service
			_serviceConnection.Connect ();

		}
		#endregion

		#region Private Methods
		/// <summary>
		/// Loads the purchased items.
		/// </summary>
		private void LoadPurchasedItems ()
		{
			// Ask the open connection's billing handler to get any purchases
			var purchases = _serviceConnection.BillingHandler.GetPurchases (ItemType.Product);

			// Display any existing purchases
			//_purchasesAdapter = new PurchaseAdapter (this, purchases);
			//_lvPurchsedItems.Adapter = _purchasesAdapter;
		}

		/// <summary>
		/// Updates the purchased items.
		/// </summary>
		private void UpdatePurchasedItems ()
		{
			// Ask the open connection's billing handler to get any purchases
			var purchases = _serviceConnection.BillingHandler.GetPurchases (ItemType.Product);

			// Is there a data adapter for purchases?
	/*		if (_purchasesAdapter != null) {
				// Yes, add new items to adapter
				foreach (var item in purchases) {
					_purchasesAdapter.Items.Add (item);
				}

				// Ask the adapter to display the new items
				_purchasesAdapter.NotifyDataSetChanged ();
			}
	*/
		}

		/// <summary>
		/// Connects to the Google Play Service and gets a list of products that are available
		/// for purchase.
		/// </summary>
		/// <returns>The inventory.</returns>
		private async Task GetInventory ()
		{
			// Ask the open connection's billing handler to return a list of avilable products for the 
			// given list of items.
			// NOTE: We are asking for the Reserved Test Product IDs that allow you to test In-App
			// Billing without actually making a purchase.
			_products = await _serviceConnection.BillingHandler.QueryInventoryAsync (new List<string> {
				"1000",
				"2000",
				"3000",
				"4000",
				"5000",
				"6000"
				}, ItemType.Product);

			// Were any products returned?
			if (_products == null) {
				// No, abort
				return;
			}
			System.Console.WriteLine ("+++++++++ product count {0}+++++++++++++", _products.Count);
	/*		// Enable the list of products
			_produtctSpinner.Enabled = (_products.Count > 0);

			// Populate list of available products
			var items = _products.Select (p => p.Title).ToList ();
			_produtctSpinner.Adapter = 
				new ArrayAdapter<string> (this, 
					Android.Resource.Layout.SimpleSpinnerItem,
					items);*/
		}
		#endregion
	}		
	/// <summary>
	///  Adapter for flirtjuice
	/// </summary>
	class FlirtJuiceAdapter : BaseAdapter
	{
		Activity context;
		List<Item> _list;

		public FlirtJuiceAdapter(Activity context, ref List<Item> _list)
		{
			this.context = context; 
			this._list = _list;
		}

		int[] discount = new int [] {Resource.Drawable.DD_FJ_icn_10_discount, 
			Resource.Drawable.DD_FJ_icn_25_discount,Resource.Drawable.DD_FJ_icn_40_discount };

		bool[] isVisible = new bool[] {false, true, true};

		int[] juice = new int[] {Resource.Drawable.DD_FJ_icn_flirt_juice_1pack, 
			Resource.Drawable.DD_FJ_icn_flirt_juice_5packs, Resource.Drawable.DD_FJ_icn_flirt_juice_20packs};
		/*	string[] packs = new string[] {"1 PACK", "10 PACKS", "20 PACKS"};

		string[] gold = new string[] {"10 GOLD", "75 GOLD", "120 GOLD"};*/

		public override int Count 
		{
			get 
			{
				return _list.Count;
			}
		}

		public override Java.Lang.Object GetItem (int position)
		{
			return position;
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{

			var view = convertView;

			if (convertView == null) 
			{
				view = context.LayoutInflater.Inflate (Resource.Layout.AD_BuyFlirtJuice_each_item, parent, false);

				BuyJuiceViewHolder buyViewHolder = new BuyJuiceViewHolder ();

				buyViewHolder.discountImg = view.FindViewById <ImageView> (Resource.Id.iv_discount);
				buyViewHolder.juicePackImg = view.FindViewById <ImageView> (Resource.Id.iv_bottle);
				buyViewHolder.juiceCount = view.FindViewById <TextView> (Resource.Id.tv_juiceAmount);
				buyViewHolder.price = view.FindViewById <Button> (Resource.Id.btn_price);


				// only show discount to items it is available so check the bool array is true
				if (isVisible [position]) 
				{
					buyViewHolder.discountImg.Visibility = ViewStates.Visible;
					buyViewHolder.discountImg.SetImageResource (discount [position]);
				} 
				else 
				{
					buyViewHolder.discountImg.Visibility = ViewStates.Gone;
				}
				buyViewHolder.juicePackImg.SetImageResource (juice [position]);
				buyViewHolder.juiceCount.Text = _list [position].Uses + " PACKS";
				buyViewHolder.price.Text = _list [position].Cost.ToString () + " GOLD"; 

				buyViewHolder.price.Click += (sender, e) => 
				{
					FlirtPlanetActivity.FlyoutNav.getConfirmBuyJuicePopup (position, _list[position].Uses);
					FlirtPlanetActivity.FlyoutNav.adJuice.Dismiss();
				};
			}
			return view;
		}
	}



	/// <summary>
	///  Adapter for flirtjuice
	/// </summary>
	class FlirtGoldAdapter : BaseAdapter
	{
		Activity context;

		public FlirtGoldAdapter(Activity context)
		{
			this.context = context; 
		}

		int[] bonus = new int [] {Resource.Drawable.DD_FG_icn_75_bonus, Resource.Drawable.DD_FG_icn_50_bonus,
			Resource.Drawable.DD_FG_icn_15_bonus, Resource.Drawable.DD_FG_icn_10_bonus,
			Resource.Drawable.DD_FG_icn_10_bonus, Resource.Drawable.DD_FG_icn_10_bonus  };

		bool[] isVisible = new bool[] {true, true, true, true, false, false};

		int[] gold = new int[] {Resource.Drawable.DD_FG_icn_2800_flirt_gold, 
			Resource.Drawable.DD_FG_icn_1190_flirt_gold,
			Resource.Drawable.DD_FG_icn_335_flirt_gold,
			Resource.Drawable.DD_FG_icn_110_flirt_gold,
			Resource.Drawable.DD_FG_icn_90_flirt_gold,
			Resource.Drawable.DD_FG_icn_20_flirt_gold };
		string[] names = new string[] {"?? Flirt Gold", "?? Flirt Gold", "?? Flirt Gold",
			"?? Flirt Gold", "?? Flirt Gold","?? Flirt Gold" };

		string[] price = new string[] {"$0.00", "$0.00", "$0.00",
			"$0.00", "$0.00", "$0.00"};

		public override int Count {
			get {
				return names.Length;
			}
		}

		public override Java.Lang.Object GetItem (int position)
		{
			return position;
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{

			var view = convertView;
			if (convertView == null) 
			{
				view = context.LayoutInflater.Inflate (Resource.Layout.Ad_BuyFlirtGold_each_item, parent, false);
			}

			var bunosImg = view.FindViewById <ImageView> (Resource.Id.iv_bonus);
			var bonusGoldImg = view.FindViewById <ImageView> (Resource.Id.iv_coins);
			var bonusName = view.FindViewById <TextView> (Resource.Id.tv_goldName);
			var priceBtn = view.FindViewById <Button> (Resource.Id.btn_price);

			// Configure buy button
			priceBtn.Click += (sender, e) => {
				// Ask the open connection's billing handler to purchase the selected product
				//if (_selectedProduct!=null)
					FlirtPlanetActivity.FlyoutNav._serviceConnection.BillingHandler.BuyProduct( FlirtPlanetActivity.FlyoutNav._products [position]);
				//	_serviceConnection.BillingHandler.BuyProduct(_products[0]);
			}; 
			// only show discount to items it is available so check the bool array is true
			if(isVisible[position])
			{
				bunosImg.Visibility = ViewStates.Visible;
				bunosImg.SetImageResource (bonus [position]);
			}
			else
			{
				bunosImg.Visibility = ViewStates.Gone;
			}
			bonusGoldImg.SetImageResource (gold [position]);
			bonusName.Text = FlirtPlanetActivity.FlyoutNav._products [position].Title;
			priceBtn.Text = FlirtPlanetActivity.FlyoutNav._products [position].Price; 

			return view;
		}

	}

	class BuyJuiceViewHolder : Java.Lang.Object
	{
		public TextView juiceCount { get; set; }
		public Button price { get; set;}
		public ImageView juicePackImg { get; set;}
		public ImageView discountImg { get; set;}
	}
}

