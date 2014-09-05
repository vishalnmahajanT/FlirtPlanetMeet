
using Core.Data;
using Core.Business;

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
	class ConnectionsAdapter1 : BaseAdapter
	{
		List<Connection> _ConnectionList = new List<Connection> ();
		Activity context;
		View v;
		int userId;

		public ConnectionsAdapter1(Activity context, View v, int id)
		{
			this.context = context;
			this.v = v;
			userId = id;
		}

		public override int Count {
			get {
				return _ConnectionList.Count;
			}
		}

		public override long GetItemId (int position)
		{
			return 0;
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			var view = convertView ?? context.LayoutInflater.Inflate (Resource.Layout.fragment_connections_each_item);
			var avatarimg = view.FindViewById <ImageView> (Resource.Id.iv_avatar);
			var connetionname = view.FindViewById <TextView> (Resource.Id.tv_conn_name);
			var compatibility = view.FindViewById <TextView> (Resource.Id.tv_compatibility);

			_ConnectionList = ConnectionBus.GetUserConnections (userId);
			connetionname = _ConnectionList [position].UserName;
			compatibility = _ConnectionList [position].OverallCompat;
			avatarimg.

			return view;
		}
	}

	/*class ConnectionsHolder
		{
			public int ConnectionUId { get; set; }
			public string Avatar { get; set; }
			public string ConnectionName { get; set; }
			public int CompactPercent { get; set; }

		}*/
}

