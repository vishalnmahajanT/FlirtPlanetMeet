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

	public class MeetActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			//var root = inflater.Inflate (Resource.Layout.FragmentDashboard, container);

				var view = inflater.Inflate(Resource.Layout.fragment_meet, null);
				return view;

		}
	}
}

