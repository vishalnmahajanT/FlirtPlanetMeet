using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Java.Lang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;

using Android.Widget;

namespace DrawerSample
{

	public class ListViewNoScroll : GridView 
	{
		public ListViewNoScroll(Context context, IAttributeSet attrs) 
			: base(context, attrs)
		{ 
		} 

		public override bool OnTouchEvent(MotionEvent e) 
		{ 
			if(e.Action == MotionEventActions.Move) 
			{ 
				return true; 
			} 
			return base.OnTouchEvent(e); 
		} 

		protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) 
		{ 
			// Calculate entire height by providing a very large height hint. 
			// But do not use the highest 2 bits of this integer; those are
			// reserved for the MeasureSpec mode.
			int expandSpec = MeasureSpec.MakeMeasureSpec(int.MaxValue >> 2, MeasureSpecMode.AtMost);
			base.OnMeasure(widthMeasureSpec, expandSpec); 
		}
	} 
}

