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
using Xamarin.FacebookBinding;

namespace flirtplanet
{
	public class FragmentSettings : Fragment
	{
		Core.Data.Settings mSettings;
		CheckBox flirtMail;
		CheckBox flirtJuice;
		Button logOut;

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate(Resource.Layout.fragment_settings, container, false);

			mSettings = SettingsBus.GetUserSettings (MainUser.AppUser.UniqUser);
			flirtMail = view.FindViewById<CheckBox> (Resource.Id.cb_flirtmail);
			flirtJuice = view.FindViewById<CheckBox> (Resource.Id.cb_flirtjuicerefills);
			logOut = view.FindViewById<Button> (Resource.Id.b_logout);

			flirtMail.Checked = mSettings.PushFMAIL;
			flirtJuice.Checked = mSettings.PushRFILL;

			flirtMail.CheckedChange += (sender, e) => 
			{
				mSettings.PushFMAIL = flirtMail.Checked;
				SettingsBus.UpdatePushSettings(mSettings);
			};

			flirtJuice.CheckedChange += (sender, e) => 
			{
				mSettings.PushRFILL = flirtJuice.Checked;
				SettingsBus.UpdatePushSettings(mSettings);
			};

			logOut.Click += (object sender, EventArgs e) => 
			{
				MainUser.logOut();
				//HelloFacebookSampleActivity.tempObject.Finish();
				this.Activity.Finish();
			};

			return view;
		}
	}
}

