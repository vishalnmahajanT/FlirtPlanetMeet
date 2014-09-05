
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

	public class FragmentDatePickerDialog : DialogFragment
	{
		private readonly Context _context;
		private  DateTime _date;
		private readonly Android.App.DatePickerDialog.IOnDateSetListener _listener;
		private View _view;
		public FragmentDatePickerDialog(Context context, DateTime date, Android.App.DatePickerDialog.IOnDateSetListener listener, View v )
		{
			_context = context;
			_date = date;
			_listener = listener;
			_view = v;
		}

		public override Dialog OnCreateDialog(Bundle savedState)
		{
			var dialog = new Android.App.DatePickerDialog(_context, _listener, _date.Year, _date.Month - 1, _date.Day);
			return dialog;
		}


	}

}





