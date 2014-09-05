using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace flirtplanet
{
	class PermanentBoostCustomeAdapter : BaseAdapter <PerBoostHolder>
	{
		List <PerBoostHolder> _perBoost ;
		Activity context;

		public PermanentBoostCustomeAdapter(Activity context)
		{
			this.context = context;
			FillPerBoosts ();
		}

		public override PerBoostHolder this[int position]
		{
			get { return _perBoost [position];}
		}

		public override int Count
		{
			get{ return _perBoost.Count; }
		}

		public override long GetItemId (int position)
		{
			return position;//.Id;
		}


		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			var view = convertView ?? context.LayoutInflater.Inflate (Resource.Layout.fragment_side_boosts_permanent, parent, false);

			//getting id's from layout file
			var iv_boosts_img = view.FindViewById <ImageView> (Resource.Id.iv_shotingstar);
			var tv_title = view.FindViewById <TextView> (Resource.Id.tv_title);
			var tv_subtitle1 = view.FindViewById <TextView> (Resource.Id.tv_subtitle1);
			var tv_subtitle2 = view.FindViewById <TextView> (Resource.Id.tv_subtitle2);
			var btn_coinsimg = view.FindViewById <Button> (Resource.Id.btn_coins);
			var tv_price = view.FindViewById <TextView> (Resource.Id.tv_price);
			var tv_buy = view.FindViewById <TextView> (Resource.Id.tv_buy);

			//assingning values
			iv_boosts_img.SetImageResource (_perBoost [position].Boost_img);
			tv_title.Text = _perBoost [position].Title;
			tv_subtitle1.Text = _perBoost [position].Subtitle1;
			tv_subtitle2.Text = _perBoost [position].Subtitle2;
			btn_coinsimg.SetBackgroundResource (_perBoost [position].Coin_img);
			tv_price.Text = _perBoost [position].Price;
			tv_buy.Text = _perBoost [position].Buy;


			return view;
		}

		//filling data in adapter
		void FillPerBoosts()
		{
			_perBoost = new List<PerBoostHolder> ();

			int[] shootingstarimg = {
				Resource.Drawable.DD_Boosts_icn_hide_connections,
				Resource.Drawable.DD_Boosts_icn_cloaking_device,

			};
			string[] title = { "Hide Connections", "Cloaking Device" };
			string[] subtitle1 = { "Hide Connections", "Browse Anonymously" };
			string[] subtitle2 = { "Hide connections from others.", "View profiles undetected" };
			int[] coinimg = {
				Resource.Drawable.DD_Boosts_icn_gold,
				Resource.Drawable.DD_Boosts_icn_gold,
	
			};
			string[] price = { "25", "300" };
			string[] buy = { "Buy Now!", "Buy Now!" };

			for (int i = 0; i < 2; i++) 
			{
				_perBoost.Add (new PerBoostHolder {
					Boost_img = shootingstarimg [i],
					Title = title [i],
					Subtitle1 = subtitle1 [i],
					Subtitle2 = subtitle2 [i],
					Coin_img = coinimg [i],
					Price = price [i],
					Buy = buy [i]
				});
			}


		}



	}



	class PerBoostHolder
	{
		public int Boost_img { get; set; }
		public string Title { get; set; }
		public string Subtitle1 { get; set; }
		public string Subtitle2 { get; set; }
		public int Coin_img { get; set; }
		public string Price { get; set; }
		public string Buy { get; set; }
	}
}

