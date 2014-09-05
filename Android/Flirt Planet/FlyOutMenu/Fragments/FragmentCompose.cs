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
using System.Reflection.Emit;
using Core.Data;
using Core.Business;

namespace flirtplanet
{
	public class FragmentCompose : Fragment
	{
		List<Connection> userConnections = null;
		int partnerID = -1;
		public static bool navigateThrough = false;

		//var adapter_region = new ArrayAdapter<string> (this, Android.Resource.Layout.SimpleSpinnerItem, getRegionsOnCountryChanged ());
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate(Resource.Layout.fragment_composeMail, container, false);

			var spinnerConnections = view.FindViewById <Spinner> (Resource.Id.spinner_to);
			var adapterConnections = new ArrayAdapter<string> (this.Activity, Resource.Layout.custom_spinner_meet, buildConnections());

			if (adapterConnections.Count > 0) 
				spinnerConnections.Adapter = adapterConnections;

			var sendMail = view.FindViewById<ImageView> (Resource.Id.iv_sendMail);
			var composeMail = view.FindViewById<EditText> (Resource.Id.et_composeMail);

			spinnerConnections.ItemSelected += (object sender, AdapterView.ItemSelectedEventArgs e) => 
			{
				partnerID = userConnections[e.Position].UniqUser;
				FragmentMail.partnerID = userConnections[e.Position].UniqUser;
				FragmentMail.partnerName = userConnections[e.Position].UserName;
			};

			sendMail.Click += (sender, e) => 
			{
				if(composeMail.Text == string.Empty || partnerID == -1)
					return;

				Flirtmail newFlirtMail = new Flirtmail(MainUser.AppUser.UniqUser, partnerID, composeMail.Text);

				string[] result = null;
				do{result = FlirtmailBus.InsertFlirtmailRVW(MainUser.AppUser, ref newFlirtMail);} while(result == null);

				//add this mail to our unsorted master list
				FragmentMail.mAllFlirtMail.Add(newFlirtMail);

				navigateThrough = true;

				FragmentTransaction ft1 = FragmentManager.BeginTransaction ();
				ft1.Replace(Resource.Id.content_frame, new FragmentMail())
					.AddToBackStack(null)
					.Commit();
			};

			return view;
		}

		private List<string> buildConnections()
		{
			List<int> connectIds = new List<int> ();
			List<string> connectNames = new List<string> ();

			do {userConnections = ConnectionBus.GetUserConnections (MainUser.AppUser.UniqUser);} while(userConnections == null);

			for (int idx = 0; idx < userConnections.Count; idx++) 
			{
				connectIds.Add (userConnections [idx].UniqUser);
				connectNames.Add (userConnections [idx].UserName);
			}

			return connectNames;
		}

	}
}

