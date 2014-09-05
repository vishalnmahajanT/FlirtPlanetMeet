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

namespace flirtplanet
{
	public class FragmentBoost : Fragment
	{
		public static ImageButton btnsideboosts, btnsideinventory, btnsidejuicepack;
		TextView tvmaintitle;
		Android.App.Fragment currentFragment;
		Android.App.FragmentTransaction ft1;

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate (Resource.Layout.fragment_Boost, container, false);
			FlirtPlanetActivity.FlyoutNav.ab_boost.SetColorFilter (null);

			tvmaintitle = view.FindViewById<TextView> (Resource.Id.tv_main_title);
			btnsideboosts = view.FindViewById<ImageButton> (Resource.Id.btn_side_boosts);
			btnsideinventory = view.FindViewById<ImageButton> (Resource.Id.btn_side_inventory);
			btnsidejuicepack = view.FindViewById<ImageButton> (Resource.Id.btn_side_juicepack);


			setSelectedFragment (0);

			btnsideboosts.Click += (sender, e) => 
			{
				setSelectedFragment (0);
			};

			btnsideinventory.Click += (sender, e) => 
			{
				setSelectedFragment (1);
			};

			btnsidejuicepack.Click += (sender, e) => 
			{
				setSelectedFragment (2);

			};

			return view;
		}

		void setSelectedFragment (int tabId)
		{

			switch (tabId)
			{
			case  1:
				DrawableStateChanged(btnsideinventory);
				tvmaintitle.Text = "Inventory";
				currentFragment = new FragmentSideInventory();  
				break;
			case  2:  
				DrawableStateChanged(btnsidejuicepack);
				tvmaintitle.Text = "Juice Pack";
				currentFragment = new FragmentSideJuicePack(); 
				break;
			default:  
				DrawableStateChanged(btnsideboosts);
				tvmaintitle.Text = "Boosts";
				currentFragment = new FragmentSideBoost();   

				break;
			}

			 ft1 = FragmentManager.BeginTransaction ();
			ft1.Replace(Resource.Id.ll_boost_container, currentFragment)
				.AddToBackStack(null)
				.Commit();

		}

		public override void OnDestroyView ()
		{
			base.OnDestroyView ();
		}
		public static void DrawableStateChanged(ImageButton ibtn)
		{

			if (btnsideboosts == ibtn) {

				btnsideboosts.SetBackgroundResource(Resource.Drawable.DD_Global_HorizTabBar);
				btnsideboosts.SetImageResource(Resource.Drawable.DD_Boosts_icn_side_boosts_hit_resized);
				btnsideinventory.SetImageResource (Resource.Drawable.DD_Boosts_icn_side_inventory_resized);
				btnsideinventory.SetBackgroundResource (Resource.Color.transparent);
				btnsidejuicepack.SetImageResource (Resource.Drawable.DD_Boosts_icn_side_juicepack_resized);
				btnsidejuicepack.SetBackgroundResource (Resource.Color.transparent);

			} 
			else if (ibtn == btnsideinventory) 
			{
				btnsideboosts.SetImageResource (Resource.Drawable.DD_Boosts_icn_side_boosts_resized);
				btnsideboosts.SetBackgroundResource (Resource.Color.transparent);
				btnsideinventory.SetBackgroundResource(Resource.Drawable.DD_Global_HorizTabBar);
				btnsideinventory.SetImageResource(Resource.Drawable.DD_Boosts_icn_side_inventory_hit_resized);
				btnsidejuicepack.SetImageResource (Resource.Drawable.DD_Boosts_icn_side_juicepack_resized);
				btnsidejuicepack.SetBackgroundResource (Resource.Color.transparent);
			} 
			else 
			{
				btnsideboosts.SetImageResource (Resource.Drawable.DD_Boosts_icn_side_boosts_resized);
				btnsideboosts.SetBackgroundResource (Resource.Color.transparent);
				btnsideinventory.SetImageResource (Resource.Drawable.DD_Boosts_icn_side_inventory_resized);
				btnsideinventory.SetBackgroundResource (Resource.Color.transparent);			
				btnsidejuicepack.SetBackgroundResource(Resource.Drawable.DD_Global_HorizTabBar);
				btnsidejuicepack.SetImageResource(Resource.Drawable.DD_Boosts_icn_side_juicepack_hit_resized);
			}

		}


	}
}

