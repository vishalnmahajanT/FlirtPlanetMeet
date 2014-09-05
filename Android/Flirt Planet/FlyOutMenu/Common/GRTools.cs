//--------------------------------------------------------------------------------
//
// iOS.Common.GRTools.cs -
//
// Copyright 2013 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;
using System.Drawing;
using Core.Constants;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Core.Business;

//--------------------------------------------------------------------------------

namespace flirtplanet
{
	public static class GRTools
	{
		//--------------------------------------------------------------------------------
		//--------------------------------------------------------------------------------

		public static class RNG
		{
			//----------------------------------------

			static Random sRNG = new Random();

			//----------------------------------------

			static Random _RNG
			{
				get { return sRNG; }
			}

			//----------------------------------------

			public static float Value
			{
				get { return (float) _RNG.NextDouble(); }
			}

			//----------------------------------------

			public static int Next(int min, int max)
			{
				return _RNG.Next(min, max);
			}

			//----------------------------------------

			public static int Next(int max)
			{
				return _RNG.Next(max);
			}

			//----------------------------------------

			public static int Next()
			{
				return _RNG.Next();
			}

			//----------------------------------------

		} // End Class: RNG
		public static class Text
		{
			//----------------------------------------
	
			public static string GetScreenFriendlyTime(DateTime _sentTime)
			{
				// Grab timestamp and specify that the parameter is in UTC time
				DateTime utcClone = DateTime.SpecifyKind(_sentTime, DateTimeKind.Utc);
	
				// If today, show as "HH:MM".
				// If within a week, show "NAMEOFDAY"
				// Otherwise, show "MM/DD/YY"
				
				if (DateTime.UtcNow.Date.Equals(utcClone.Date))
					return utcClone.ToLocalTime().ToString("hh:mm tt").ToUpper();
				else
				{
					TimeSpan howLongAgo = DateTime.UtcNow.Date - utcClone.Date;
					int daysAgo = System.Math.Max(0, (int) howLongAgo.TotalDays);
	
					if (daysAgo < 7)
						return utcClone.ToLocalTime().DayOfWeek.ToString().ToUpper();
					else
						return utcClone.ToString("MM/dd/yy");
				}
			}

			//----------------------------------------

			public static string GetSentRequestTimestamp(DateTime _sentTime)
			{
				// Specify that the parameter is in UTC time
				_sentTime = DateTime.SpecifyKind(_sentTime, DateTimeKind.Utc);
				DateTime now = DateTime.UtcNow;
				TimeSpan howLongAgo = now.Date - _sentTime.Date;
				int daysAgo = System.Math.Max(0, (int) howLongAgo.TotalDays); // Insure it's at least 0 days ago

				if (now.Date.Equals(_sentTime.Date)) // If today's time, show "TODAY " + the local military time
					return "TODAY " + _sentTime.ToLocalTime().ToString("HH:mm");
				else if (daysAgo < 7) // If within a few days, show "X DAYS AGO"
					return daysAgo.ToString() + " DAYS AGO";
				else // If longer, show MM-DD-YY
					return "ON "+_sentTime.ToString("MM-dd-yy");
			}
			
			//----------------------------------------

			public static string GetVisitorTime(DateTime _sentTime)
			{
				// Specify that the parameter is in UTC time
				string returnString = "";

				_sentTime = DateTime.SpecifyKind(_sentTime, DateTimeKind.Utc);
				DateTime now = DateTime.UtcNow;
				TimeSpan howLongAgo = now.Date - _sentTime.Date;
				int daysAgo = System.Math.Max(0, (int)howLongAgo.TotalDays); // Insure it's at least 0 days ago

				if (now.Date.Equals(_sentTime.Date)) // If today's time, show "TODAY " + the local military time
				{
					returnString = "TODAY";
				}
				else if (daysAgo < 7) // If within a few days, show "X DAYS AGO"
				{
					returnString =  _sentTime.DayOfWeek.ToString().ToUpper();
				}
				else // If longer, show MM-DD-YY
				{
					returnString =  _sentTime.ToString("MM-dd-yy");
				}

				return returnString + " at " + _sentTime.ToLocalTime().ToString("hh:mm tt");
			}

			//----------------------------------------

		} // End Class: Text

		/*	public static class Anim
		{
			//----------------------------------------
	
			public struct AnimSettings
			{
				public float Duration;
				public float AlphaDuration;
				public float Delay;
				public float ScaleFrom;
				public float ScaleTo;
				public bool HasBounce;
			}
	
			//----------------------------------------
	
			public struct kAnimPresets
			{
				public static AnimSettings NimpCountdownIn =  new AnimSettings() { Duration = 0.5f, Delay = 0.1f, ScaleFrom = 0.4f, ScaleTo = 1.0f, AlphaDuration =  0.4f, HasBounce = true  };
				public static AnimSettings NimpCountdownOut = new AnimSettings() { Duration = 0.5f, Delay = 0.1f, ScaleFrom = 1.0f, ScaleTo = 0.5f, AlphaDuration = 0.25f, HasBounce = false };
			}
	
			//----------------------------------------
	
			public static void FadeIn(UIView view, AnimSettings settings)
			{
				//	view.Alpha = 0.0f;
				//UIView.Animate(settings.AlphaDuration, settings.Delay, UIViewAnimationOptions.CurveLinear, () => { view.Alpha = 1.0f; }, () => { });
			}
			
			//----------------------------------------
	
			public static void FadeOut(UIView view, AnimSettings settings)
			{	
				//	UIView.Animate(settings.AlphaDuration, settings.Delay, UIViewAnimationOptions.CurveLinear, () => { view.Alpha = 0.0f; }, () => { });
			}
	
			//----------------------------------------
	
			public static void Scale(UIView view, AnimSettings settings)
			{
				// Timer that allows for bouncing
					CAMediaTimingFunction timingFunction = (settings.HasBounce) ?
					CAMediaTimingFunction.FromControlPoints(0.25f, 1.8f, 1.0f, 1.0f) :
					CAMediaTimingFunction.FromControlPoints(0.0f, 0.0f, 1.0f, 1.0f);
	
				CABasicAnimation scaleAnim = CABasicAnimation.FromKeyPath("transform");
				scaleAnim.Duration = settings.Duration;
				scaleAnim.From = NSValue.FromCATransform3D(CATransform3D.MakeScale(settings.ScaleFrom, settings.ScaleFrom, 1.0f));
				scaleAnim.To = NSValue.FromCATransform3D(CATransform3D.MakeScale(settings.ScaleTo, settings.ScaleTo, 1.0f));
				scaleAnim.RemovedOnCompletion = false;
				scaleAnim.TimingFunction = timingFunction;
				scaleAnim.BeginTime = view.Layer.ConvertTimeFromLayer(CAAnimation.CurrentMediaTime() + settings.Delay, view.Layer);
				view.Layer.AddAnimation(scaleAnim, "transform");
			}
		
			//----------------------------------------
			
		} // End Class: Anim
		
		//--------------------------------------------------------------------------------
	
		public static class Image
		{
			//----------------------------------------

			public static UIImage GetImageFromUrl(string uri)
			{
				using (NSUrl nsURL = new NSUrl(uri))
				{
					using (NSData nsData = NSData.FromUrl(nsURL))
						return (nsData != null) ? UIImage.LoadFromData(nsData) : null;
				}
			}
	
			//----------------------------------------
	
			public static UIImage GetImageFromHashedName(string hashedName)
			{
				return GetImageFromUrl(kBaseURL.Photo + hashedName);
			}

			//----------------------------------------

			public static UIImage Tint(UIImage image, UIColor color, float intensity = 1f)
			{
				// Create Graphics context
				SizeF size = image.Size;
				UIGraphics.BeginImageContextWithOptions(size, false, 2);
				CGContext context = UIGraphics.GetCurrentContext();

				// Draw image into it
				image.Draw(PointF.Empty, CGBlendMode.Normal, 1);

				// Overlay context with color
				context.SetFillColor(color.CGColor);
				context.SetBlendMode(CGBlendMode.SourceIn);
				context.SetAlpha(intensity);
				context.FillRect(new RectangleF(0, 0, size.Width, size.Height));

				// Get the tintedImage from the context
				UIImage tintedImage = UIGraphics.GetImageFromCurrentImageContext();
				UIGraphics.EndImageContext();

				return tintedImage;
			}

			//----------------------------------------
			
		} // End Class: Image
		
		//--------------------------------------------------------------------------------
		
		public static class GUI
		{
			//----------------------------------------
	
			public static UIButton BuildBackButton(GRVC attachTo, PointF position, EventHandler touchEvent = null)
			{
				UIButton backButton = null;

				if (AppMgr.IsOnIPad)
				{
					backButton = new UIButton(new RectangleF(position, iPad.kUIElementSize.BackButton));
					backButton.BackgroundColor = Palette.Clear;
					backButton.Font = UIFont.FromName(kFont.RobotoRegular, 21f);
					backButton.TitleEdgeInsets = new UIEdgeInsets(0, 15, 0, 0);
					backButton.ImageEdgeInsets = new UIEdgeInsets(9, 20, 9, 78);
					backButton.HorizontalAlignment = UIControlContentHorizontalAlignment.Left;
					backButton.SetTitle("Back", UIControlState.Normal);
					backButton.SetTitleColor(Palette.AquaBlue, UIControlState.Normal);
					backButton.SetTitleColor(Palette.DarkGray, UIControlState.Highlighted);
					backButton.SetImage(UIImage.FromBundle(kImage.Common_BackChevron), UIControlState.Normal);

					backButton.BackgroundColor = UIColor.FromRGBA(228, 228, 228, 155);
					backButton.Layer.CornerRadius = 4.0f;
				}
				else
				{
					backButton = new UIButton(new RectangleF(position, new SizeF(35f, 35f)));
					backButton.BackgroundColor = Palette.Clear;
					backButton.ImageEdgeInsets = new UIEdgeInsets(8f, 13f, 8f, 13f);

					backButton.SetImage(UIImage.FromBundle(kImage.Common_BackChevron),       UIControlState.Normal);
					backButton.SetImage(UIImage.FromBundle(kImage.Common_BackChevron_White), UIControlState.Highlighted);
					backButton.SetImage(UIImage.FromBundle(kImage.Common_BackChevron_White), UIControlState.Selected);

					backButton.TouchDown   += (object sender, System.EventArgs e) => { backButton.BackgroundColor = Palette.AquaBlue; };
					backButton.TouchCancel += (object sender, System.EventArgs e) => { backButton.BackgroundColor = Palette.Clear;    };
					}

				backButton.TouchUpInside += (object sender, System.EventArgs e) =>
				{
					if(touchEvent!=null) touchEvent.Invoke(backButton, EventArgs.Empty);

					attachTo.View.Alpha = 1.0f;

					UIView.Animate(0.25f, 0.01f, UIViewAnimationOptions.CurveEaseIn, () => { attachTo.View.Alpha = 0.0f;}, () =>
					{
						attachTo.View.RemoveFromSuperview();
						
						if (attachTo.ParentViewController != null)
						{
							FlyoutNav.CurrentController = attachTo.ParentViewController as GRVC;
							FlyoutNav.CurrentController.View.AddSubview(TopNavigationBar.Self.View);
						}
						
						attachTo.RemoveFromParentViewController();
					});
				};
	
				attachTo.View.AddSubview(backButton);
	
				return backButton;
			}
			
			//----------------------------------------
			
			public static bool ScreenIsFourInches
			{
				get { return (!AppMgr.IsOnIPad) && ((UIScreen.MainScreen.Bounds.Size.Height * UIScreen.MainScreen.Scale) >= 1136); }
			}
	
			//----------------------------------------
			// Adds an iPhone sized scrollview starting at position Y

			public static GRScrollView BuildIphoneScrollView(UIView parentView, float startY, bool hasFooter)
			{
				RectangleF scrollerFrame = (ScreenIsFourInches) ?
					new RectangleF(0, startY, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height - startY - (hasFooter ? Footer.Height : 0f)) :
				    new RectangleF(0, startY, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height - startY - (hasFooter ? Footer.Height : 0f));
				    
				GRScrollView scrollView = new GRScrollView(scrollerFrame);
				parentView.AddSubview(scrollView);
				
				return scrollView;
			}

			//----------------------------------------

			public static void BuildChiselHoriz(UIView parentView, float startY)
			{
				parentView.AddSubview(new GRImageView(new RectangleF(0, startY, UIScreen.MainScreen.Bounds.Width, 2), kImage.Common_Chisel_Horz));
			}

			//----------------------------------------

			public static UIToolbar KeyboardDoneBTN(UITextField textField)
			{
				return KeyboardDoneBTN(textField, delegate { textField.ResignFirstResponder(); });
			}
			
			//----------------------------------------
						
			public static UIToolbar KeyboardDoneBTN(UITextField _textField, EventHandler _clicked)
			{
				float kDoneBarHeight = (AppMgr.IsOnIPad) ? 45f : 35f;

				UIToolbar doneBar = new UIToolbar(new RectangleF(0, 0, UIScreen.MainScreen.Bounds.Width, kDoneBarHeight));
				doneBar.BarStyle = UIBarStyle.Default;
				doneBar.Translucent = true;

				UIBarButtonItem doneButton = new UIBarButtonItem(UIBarButtonSystemItem.Done);
				doneButton.Clicked += _clicked;

				doneBar.SetItems(new UIBarButtonItem[] { new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace), doneButton }, false);

				return doneBar;
			}
			
			//----------------------------------------
			
			public static UIToolbar KeyboardDoneBTN(UITextView textView)
			{
				return KeyboardDoneBTN(textView, delegate { textView.ResignFirstResponder(); });
			}
			
			//----------------------------------------
			
			public static UIToolbar KeyboardDoneBTN(UITextView _textView, EventHandler _clicked)
			{
				float kDoneBarHeight = (AppMgr.IsOnIPad) ? 45f : 35f;

				UIToolbar doneBar = new UIToolbar(new RectangleF(0, 0, UIScreen.MainScreen.Bounds.Width, kDoneBarHeight));
				doneBar.BarStyle = UIBarStyle.Default;
				doneBar.Translucent = true;

				UIBarButtonItem doneButton = new UIBarButtonItem(UIBarButtonSystemItem.Done);
				doneButton.Clicked += _clicked;

				doneBar.SetItems(new UIBarButtonItem[] { new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace), doneButton }, false);

				return doneBar;	
			}

    		//----------------------------------------
    		
    	} // End Class: GUI
    	
    	//--------------------------------------------------------------------------------
		
		public static class Math
		{
			//----------------------------------------
	
			public static PointF GetPointAlongArc(float centerX, float centerY, float radius, float angle)
			{
				return new PointF(centerX + (float)System.Math.Cos(angle) * radius, centerY + (float)System.Math.Sin(angle) * radius);
			}
	
			//----------------------------------------
	
			public static float DegreesToRadians(float degrees)
			{
				return (degrees * (float)System.Math.PI) / 180.0f;
			}
	
			//----------------------------------------

		} // End Class: Math

		//--------------------------------------------------------------------------------
		
		public static class Rect
		{
			//----------------------------------------
		
			public static RectangleF Add(RectangleF rect1, RectangleF rect2)
			{
				return new RectangleF(rect1.X + rect2.X, rect1.Y + rect2.Y, rect1.Width + rect2.Width, rect1.Height + rect2.Height);
			}
	
			//----------------------------------------
	
			public static RectangleF CenterHoriz(RectangleF rect)
			{
				return new RectangleF(rect.X - (rect.Width / 2f), rect.Y, rect.Width, rect.Height);
			}
			
			//----------------------------------------
	
		} // End Class: Rect
		

		//--------------------------------------------------------------------------------

		public static class Text
		{
			//----------------------------------------
	
			public static string GetScreenFriendlyTime(DateTime _sentTime)
			{
				// Grab timestamp and specify that the parameter is in UTC time
				DateTime utcClone = DateTime.SpecifyKind(_sentTime, DateTimeKind.Utc);
	
				// If today, show as "HH:MM".
				// If within a week, show "NAMEOFDAY"
				// Otherwise, show "MM/DD/YY"
				
				if (DateTime.UtcNow.Date.Equals(utcClone.Date))
					return utcClone.ToLocalTime().ToString("hh:mm tt").ToUpper();
				else
				{
					TimeSpan howLongAgo = DateTime.UtcNow.Date - utcClone.Date;
					int daysAgo = System.Math.Max(0, (int) howLongAgo.TotalDays);
	
					if (daysAgo < 7)
						return utcClone.ToLocalTime().DayOfWeek.ToString().ToUpper();
					else
						return utcClone.ToString("MM/dd/yy");
				}
			}

			//----------------------------------------

			public static string GetSentRequestTimestamp(DateTime _sentTime)
			{
				// Specify that the parameter is in UTC time
				_sentTime = DateTime.SpecifyKind(_sentTime, DateTimeKind.Utc);
				DateTime now = DateTime.UtcNow;
				TimeSpan howLongAgo = now.Date - _sentTime.Date;
				int daysAgo = System.Math.Max(0, (int) howLongAgo.TotalDays); // Insure it's at least 0 days ago

				if (now.Date.Equals(_sentTime.Date)) // If today's time, show "TODAY " + the local military time
					return "TODAY " + _sentTime.ToLocalTime().ToString("HH:mm");
				else if (daysAgo < 7) // If within a few days, show "X DAYS AGO"
					return daysAgo.ToString() + " DAYS AGO";
				else // If longer, show MM-DD-YY
					return _sentTime.ToString("MM-dd-yy");
			}
			
			//----------------------------------------

			public static string GetVisitorTime(DateTime _sentTime)
			{
				// Specify that the parameter is in UTC time
				string returnString = "";

				_sentTime = DateTime.SpecifyKind(_sentTime, DateTimeKind.Utc);
				DateTime now = DateTime.UtcNow;
				TimeSpan howLongAgo = now.Date - _sentTime.Date;
				int daysAgo = System.Math.Max(0, (int)howLongAgo.TotalDays); // Insure it's at least 0 days ago

				if (now.Date.Equals(_sentTime.Date)) // If today's time, show "TODAY " + the local military time
				{
					returnString = "TODAY";
				}
				else if (daysAgo < 7) // If within a few days, show "X DAYS AGO"
				{
					returnString =  _sentTime.DayOfWeek.ToString().ToUpper();
				}
				else // If longer, show MM-DD-YY
				{
					returnString =  _sentTime.ToString("MM-dd-yy");
				}

				return returnString + " at " + _sentTime.ToLocalTime().ToString("hh:mm tt");
			}

			//----------------------------------------

		} // End Class: Text
*/
		//--------------------------------------------------------------------------------

	} // End Class: GRTools

} // End Namespace: iOS.Common

//--------------------------------------------------------------------------------
// EOF




