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

namespace flirtplanet
{

	public class DetailsGridNoScroll : GridView 
	{
		public DetailsGridNoScroll(Context context, IAttributeSet attrs) 
			: base(context, attrs)
		{ 
			cont = context;
		} 
		Context cont;
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

			int height = this.MeasuredHeight;
			expandSpec = MeasureSpec.MakeMeasureSpec(MeasuredHeight, MeasureSpecMode.Exactly);

			base.OnMeasure(widthMeasureSpec, expandSpec+ (int)(Resources.DisplayMetrics.Density * 30)); 

			LayoutParameters.Height = MeasuredHeight;

		}
	} 
}

