//--------------------------------------------------------------------------------
//
// iOS.NimpController.cs - Handles the flow of showing the N-Imp Quiz
//
// Copyright 2013 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;

using Core.Constants;
using Core.Business;
using Core.Data;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

//--------------------------------------------------------------------------------

namespace flirtplanet
{

	public class NimpDemoPopup: Fragment
	{
		Activity mActivity;

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate (Resource.Layout.fragment_home, container, false);

			return view;
		}
		public NimpDemoPopup(Activity activity){
			mActivity = activity;
		}
	}


}
 
//--------------------------------------------------------------------------------
// EOF

