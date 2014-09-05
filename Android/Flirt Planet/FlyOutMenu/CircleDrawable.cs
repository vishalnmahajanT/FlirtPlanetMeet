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
using System.Runtime.InteropServices;

namespace flirtplanet
{
	public class CircleDrawable : Drawable
	{
		Bitmap bmp;
		BitmapShader bmpShader;
	//	int size;

		private int borderWidth;
		private int canvasSize;
		private Paint paint;
		private Paint paintBorder;
		Canvas canvas;
		int circleCenter=0;

		PorterDuffColorFilter grayFilter;
		public CircleDrawable (Bitmap bmp, int size,[OptionalAttribute]bool featuredUser)
		{
			canvasSize = size;
			//canvasSize = FlirtPlanetActivity.FlyoutNav.ConvertPixelsToDp (size);
			borderWidth = 10;
			this.bmp = bmp;
			/*bmp = getRoundedShape();

			this.bmp = Bitmap.CreateScaledBitmap(bmp, canvasSize, canvasSize, false);
			float originalWidth = bmp.Width, originalHeight = bmp.Height;
			canvas = new Canvas(this.bmp);
			float scale = canvasSize/originalWidth;
			float xTranslation = 0.0f, yTranslation = (canvasSize - originalHeight * scale)/2.0f;
			Matrix transformation = new Matrix();
			transformation.PostTranslate(xTranslation, yTranslation);

			transformation.PreScale(scale, scale);
			paint = new Paint () { AntiAlias = true };
			paint.FilterBitmap = true;*/
		//	canvas.DrawBitmap(this.bmp, transformation, paint);


			this.bmpShader = new BitmapShader (this.bmp, Shader.TileMode.Clamp, Shader.TileMode.Clamp);
			paint = new Paint () { AntiAlias = true };
			paint.SetShader (bmpShader);

			this.paintBorder = new Paint(){AntiAlias = true};

			if(featuredUser)
				paintBorder.Color = new Color (255, 223, 0);
			else
			{
				paintBorder.Color = new Color (255, 255, 255);
			}
			paintBorder.SetShadowLayer (4.0f, 0.0f, 2.0f, Color.Black);

			circleCenter = (canvasSize - (borderWidth * 2)) / 2;
			grayFilter = new PorterDuffColorFilter(Color.ParseColor("#88000000"), PorterDuff.Mode.SrcAtop);
		}

		protected override void Dispose (bool disposing)
		{
			base.Dispose (true);
			//canvas.Dispose ();
			//bmpShader.Dispose ();
			//bmp.Dispose ();
			//grayFilter.Dispose ();
			//paint.Dispose ();
		}

		private Bitmap getRoundedShape() 
		{
			bmp = Bitmap.CreateScaledBitmap(bmp, canvasSize, canvasSize, false);
			float originalWidth = bmp.Width, originalHeight = bmp.Height;
			Canvas canvas = new Canvas(bmp);
			float scale = canvasSize/originalWidth;
			float xTranslation = 0.0f, yTranslation = (canvasSize - originalHeight * scale)/2.0f;
			Matrix transformation = new Matrix();
			transformation.PostTranslate(xTranslation, yTranslation);

			transformation.PreScale(scale, scale);
			Paint paint = new Paint();
			paint.FilterBitmap = true;
			canvas.DrawBitmap(bmp, transformation, paint);
			return bmp;
		}

		public override void Draw (Canvas canvas)
		{
			///canvas.DrawOval (oval, paint);
			canvas.DrawCircle(circleCenter + borderWidth, circleCenter + borderWidth, ((canvasSize - (borderWidth * 2)) / 2) + borderWidth - 4.0f, paintBorder);
			canvas.DrawCircle(circleCenter + borderWidth, circleCenter + borderWidth, ((canvasSize - (borderWidth * 2)) / 2) - 1.0f, paint);
		}

		protected override void OnBoundsChange (Rect bounds)
		{
			base.OnBoundsChange (bounds);
			//oval.Set (0, 0, bounds.Width (), bounds.Height ());
		}

		public override int IntrinsicWidth {
			get {
				return canvasSize;//bmp.Width;
			}
		}

		public override int IntrinsicHeight {
			get {
				return canvasSize;//bmp.Height;
			}
		}

		public override void SetAlpha (int alpha)
		{
			paint.Alpha = alpha;
		}

		public override int Opacity {
			get {
				return (int)Format.Opaque;
			}
		}

		protected override bool OnStateChange (int[] state)
		{
			return base.OnStateChange (state);
		}

		public override void SetColorFilter (ColorFilter cf)
		{
			paint.SetColorFilter (grayFilter);
		}
	}
}

