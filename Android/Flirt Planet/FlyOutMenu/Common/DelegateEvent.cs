//--------------------------------------------------------------------------------
//
// iOS.Common.DelegateEvent.cs - 
//
// Copyright 2013 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;
using System.Threading;

//using MonoTouch.UIKit;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Widget;
using Android.OS;
using Core;

//--------------------------------------------------------------------------------

namespace flirtplanet
{
	public class DelegateEvent
	{
		//----------------------------------------

		//		UIView 	mView;

		//----------------------------------------

		/// <summary>
		/// The delay in milliseconds.
		/// </summary>
		public int DelayMS { get; set; }

		//----------------------------------------

		public EventHandler Function { get; set; }

		//----------------------------------------

		public bool Asynchronous { get; set; }

		//----------------------------------------

		public object Sender { get; set; }

		//----------------------------------------

		/// <summary>
		/// Register a UIButton's touch event to be the trigger for the delegate event.
		/// </summary>
		/// <value>The UIButton.</value>
		public Button Trigger
		{
			set
			{
				Button button = value as Button;

				button.Click += (object sender, EventArgs e) =>
				{

					object fireSender = this.Sender ?? sender;

					if (this.Asynchronous)
					{
						this.FireAsync(fireSender);
					}
					else
					{
						this.Fire(fireSender);
					}
				};
			}
		}

		//----------------------------------------

		public DelegateEvent()
		{
			Init(null);
		}

		//----------------------------------------

		public DelegateEvent(Activity activity)
		{
			Init(activity);
		}

		//----------------------------------------
		Activity mactivity;
		public void Init(Activity activity)
		{
			mactivity = activity;

			this.Sender = null;
			this.Function = null;
			this.DelayMS = 250;
		}

		//----------------------------------------

		public void FireAsync()
		{
			this.FireAsync(this.Sender, this.DelayMS);
		}

		//----------------------------------------

		public void FireAsync(object sender)
		{
			this.FireAsync(sender, this.DelayMS);
		}

		//----------------------------------------

		public void FireAsync(object sender, int delayMS)
		{
			if (this.Function == null)
			{
				Logger.DebugLog("DelegateEvent::FireAsync - Delegate fired before function was set.");
				return;
			}

			System.Threading.Tasks.Task.Factory.StartNew(() =>
			{
				Thread.Sleep(delayMS);
					mactivity.RunOnUiThread(() =>
				{
					this.Function.Invoke(sender, null);
				});
			});
		}

		//----------------------------------------

		public void Fire()
		{
			this.Fire(this.Sender);
		}

		//----------------------------------------

		public void Fire(object sender)
		{
			if (this.Function == null)
			{
				//Logger.DebugLog("DelegateEvent::Fire - Delegate fired before function was set.");
				return;
			}

			this.Function.Invoke(sender, null);
		}

		//----------------------------------------

	} // End Class: DelegateEvent

} // End Namespace: iOS.Common

//--------------------------------------------------------------------------------
// EOF




