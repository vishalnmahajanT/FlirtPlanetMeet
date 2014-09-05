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
using Android.Content.Res;

namespace flirtplanet
{
	public class CircleImageProgress : Drawable
	{
		Bitmap bmp;
		BitmapShader bmpShader;
	
		Paint paint;
		Paint paintBorder;
		Paint mOuterOvalPaint ;
		Paint mInnerOvalPaint ;

		float circleCenter=0;
		float mValue;
		float mFactor;
		float radius;
		int size;
		float borderWidth;
		float canvasSize;

		RectF mOval ;
		RectF mOvalInner;
		RectF mOvalOuter;

		public CircleImageProgress (Context context,int resId , float value,int size)
		{
			this.bmp = BitmapFactory.DecodeResource (context.Resources, resId);
			this.size = bmp.Width;
			canvasSize = bmp.Width;
			mFactor = context.Resources.DisplayMetrics.Density;
			borderWidth = 10*(int)mFactor;
			mValue = value;
		
			this.bmpShader = new BitmapShader (bmp, Shader.TileMode.Clamp, Shader.TileMode.Clamp);
			paint = new Paint () { AntiAlias = true };
			paint.SetShader (bmpShader);

			mOuterOvalPaint = new Paint(){AntiAlias = true};
			mOuterOvalPaint.Color = new Color(33, 181, 229);
			mOuterOvalPaint.SetStyle(Paint.Style.FillAndStroke); 


			mInnerOvalPaint = new Paint(){AntiAlias = true};
			mInnerOvalPaint.Color = new Color(234,234,234);
			mInnerOvalPaint.SetStyle(Paint.Style.FillAndStroke); 

			this.paintBorder = new Paint(){AntiAlias = true};
			paintBorder.Color = new Color (234,234,234);
			circleCenter = (float)(canvasSize - (borderWidth * 2)) / 2;

			radius = (float)((canvasSize - (borderWidth * 2)) / 2);

			mOval = new RectF(0, 0,canvasSize, canvasSize); 
			mOvalInner = new RectF(20*mFactor, 20*mFactor,radius*2,  radius*2); 
			mOvalOuter = new RectF(0, 0,radius*2+(30*mFactor),  radius*2+(30*mFactor)); 

		}

		public override void Draw (Canvas canvas)
		{

			canvas.DrawOval(mOval, mOuterOvalPaint); 
			canvas.DrawArc(mOvalOuter, 270, (100-mValue)*3.6f, true, paintBorder);
			canvas.DrawOval(mOvalInner, mInnerOvalPaint); 
			canvas.DrawCircle(circleCenter + borderWidth, circleCenter + borderWidth,radius, paint);

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

		protected override void Dispose (bool disposing)
		{
			base.Dispose (true);
			bmp.Dispose ();
			bmpShader.Dispose ();
			paint.Dispose ();
			paintBorder.Dispose ();
			mOuterOvalPaint.Dispose () ;
			mInnerOvalPaint.Dispose () ;
			GC.Collect (0);

		}
	}
}

