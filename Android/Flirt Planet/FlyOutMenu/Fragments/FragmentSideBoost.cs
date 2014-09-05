using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Data;
using Core.Business;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace flirtplanet
{
	public class FragmentSideBoost : Fragment
	{
		List<Item> _cBoostsList = null;
		List<Item> _pBoostsList = null;

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{

			var view = inflater.Inflate (Resource.Layout.fragment_side_boost, container, false);
			var boostGridView = view.FindViewById<flirtplanet.GridViewNoScroll> (Resource.Id.boostgridView);
			var perboostGridView = view.FindViewById<flirtplanet.GridViewNoScroll> (Resource.Id.permanant_boost_gridview);

			FragmentBoost.DrawableStateChanged(FragmentBoost.btnsideboosts);

			string result = null;
			do { result = BoostBus.GetItemsForStorePermanent (MainUser.AppUser.UniqUser, ref _cBoostsList, ref _pBoostsList);} while(result == null);

			var boostsAdapter = new ConsumableBoostsAdapter (this.Activity, _cBoostsList);
			var perboostsAdapter = new PermanentBoostAdapter (this.Activity,_pBoostsList, ref view);

			boostGridView.Adapter = boostsAdapter;
			perboostGridView.Adapter = perboostsAdapter;

			return view;
		}
	}


	class ConsumableBoostsAdapter : BaseAdapter
	{
		List <Item> _ConsumableboostList;
		Activity context;
		BoostItem boostitem = null;


		//constructor
		public ConsumableBoostsAdapter(Activity context, List <Item> _cBoostsList)
		{
			this.context = context;
			_ConsumableboostList = _cBoostsList;
		
		}

	
		public override int Count
		{
			get{ return _ConsumableboostList.Count; }
		}

		public override Java.Lang.Object GetItem (int position)
		{
			return _ConsumableboostList [position].UniqItem;
		}

		public override long GetItemId (int position)
		{
			return position;//.Id;
		}


		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			var view = convertView ?? context.LayoutInflater.Inflate (Resource.Layout.fragment_side_boost_each_item, parent, false);

			boostitem = new BoostItem (context ,ref view, _ConsumableboostList [position], ref _ConsumableboostList);
		
			return view;
		}

	}

 //Permanent Boost Adapter
	class PermanentBoostAdapter : BaseAdapter
	{
		List <Item> _PermanentboostList ;
		Activity context;
		BoostItem boostitem = null;
		View v;

		public PermanentBoostAdapter(Activity context, List<Item> _pBoostsList, ref View v)
		{
			this.context = context;
			_PermanentboostList = _pBoostsList;
			this.v = v;
		}

	

		public override int Count
		{
			get{ return _PermanentboostList.Count; }
		}

		public override Java.Lang.Object GetItem (int position)
		{
			return _PermanentboostList [position].UniqItem;
		}


		public override long GetItemId (int position)
		{
			return position;//.Id;
		}


		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			var view = convertView ?? context.LayoutInflater.Inflate (Resource.Layout.fragment_side_boost_each_item, parent, false);
			var perboostGridView = v.FindViewById<flirtplanet.GridViewNoScroll> (Resource.Id.permanant_boost_gridview);

			boostitem = new BoostItem (context, ref view, _PermanentboostList [position],ref  _PermanentboostList);
			if (_PermanentboostList.Count == 0)
				perboostGridView.Visibility = ViewStates.Gone;


			return view;
		}

	}

}

