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
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Animation;
using Android.Util;

namespace flirtplanet
{
	public class CircleProgress : Drawable
	{
		static float mValue = 0;
		public float Value { get { return mValue; } set { mValue = value; } }
		int size = 0;

		public CircleProgress(float value,int size) 
		{ 
			this.Value = value;
			this.size = size;
		} 


		public override void Draw (Canvas canvas)
		{
			Paint mOuterOvalPaint = new Paint(){AntiAlias = true};
			mOuterOvalPaint.Color = new Color(199,199,199);;//Color.Gray;
			mOuterOvalPaint.SetStyle(Paint.Style.FillAndStroke); 

			Paint mOvalPaint = new Paint(){AntiAlias = true};
			mOvalPaint.Color = new Color(199,199,199);//text_grey - from colors.xml
			mOvalPaint.SetStyle(Paint.Style.FillAndStroke); 

			Paint mArcPaint = new Paint(){AntiAlias = true};
			mArcPaint.Color = new Color (14, 194, 250);//aqua_blue - from colors.xml
			mArcPaint.SetStyle(Paint.Style.Fill); 

			RectF mOval = new RectF(20, 20, size-10, size-10); //This is the area you want to draw on
			RectF mOuterOval = new RectF(15, 15, (size-5), (size-5)); //This is the area you want to draw on

			float sweepAngle = 72*Value; //Calculate how much of an angle you want to sweep out here
			canvas.DrawOval(mOuterOval, mOuterOvalPaint); 

			canvas.DrawOval(mOval, mOvalPaint); 
			canvas.DrawArc(mOval, 270, sweepAngle, true, mArcPaint); //270 is vertical. I found that starting the arc from just slightly less than vertical makes it look better when the circle is almost complete.

		}

		protected override void OnBoundsChange (Rect bounds)
		{
			base.OnBoundsChange (bounds);
			//oval.Set (0, 0, bounds.Width (), bounds.Height ());
		}

		public override int IntrinsicWidth {
			get {
				return size;//bmp.Width;
			}
		}

		public override int IntrinsicHeight {
			get {
				return size;//bmp.Height;
			}
		}

		public override void SetAlpha (int alpha)
		{

		}

		public override int Opacity {
			get {
				return (int)Format.Opaque;
			}
		}

		public override void SetColorFilter (ColorFilter cf)
		{

		}
	}
}

