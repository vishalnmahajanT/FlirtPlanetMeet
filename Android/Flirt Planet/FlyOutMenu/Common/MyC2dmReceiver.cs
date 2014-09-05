
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
using Android.Support.V4.App;
using Core.Business;
using Android.Preferences;
using Android.Media;

namespace flirtplanet
{
	[BroadcastReceiver]
	public class MyC2dmReceiver : BroadcastReceiver
	{
		//CharSequence tickerText;
		private Context context;
		public static  int NOTIFICATION_ID = 1;
		public override void OnReceive (Context context, Intent intent)
		{
			this.context = context;

			if (intent.Action.Equals("com.google.android.c2dm.intent.REGISTRATION")) 
			{
				handleRegistration(context, intent);
			} 
			else if (intent.Action.Equals("com.google.android.c2dm.intent.RECEIVE")) 
			{
				handleMessage(context, intent);
			}
				
		}


		private void handleMessage(Context context2, Intent intent) 
		{
			String a = intent.Action;
			String Message = null;
			Bundle bundle = intent.Extras;

			foreach (string key in bundle.KeySet()) 
			{
				//IDs = bundle.GetString (key);
				//IDs.Append (bundle.GetString (key)).Append (",");
				Message +=  bundle.GetString (key);
			}
				
			if (a.Equals("com.google.android.c2dm.intent.RECEIVE"))
			{
				String payload = intent.GetStringExtra("payload");
				//Toast.MakeText(context2, payload,Android.Widget.ToastLength.Long).Show();
				sendNotification(bundle);
			}
		}

		//NotificationManager mNotificationManager;
		private void sendNotification(Bundle bundle) 
		{

			Intent resultIntent = new Intent(context, typeof(FlirtPlanetActivity));
			//resultIntent.PutExtras(valuesForActivity); // Pass some values to SecondActivity.

			TaskStackBuilder stackBuilder = TaskStackBuilder.Create(context);
			stackBuilder.AddParentStack(Java.Lang.Class.FromType(typeof(FlirtPlanetActivity)));
			stackBuilder.AddNextIntent(resultIntent);

			PendingIntent resultPendingIntent = stackBuilder.GetPendingIntent(0, (int)PendingIntentFlags.UpdateCurrent);

			NotificationCompat.Builder builder = new NotificationCompat.Builder (this.context)
				.SetContentTitle (bundle.GetString ("title"))
				.SetAutoCancel (true) // dismiss the notification from the notification area when the user clicks on it
				.SetContentIntent (resultPendingIntent)
				.SetSmallIcon (Resource.Drawable.Icon)
				.SetSubText (bundle.GetString ("subtitle"))
				.SetTicker (bundle.GetString ("tickerText"))
				.SetContentText (bundle.GetString ("message"));
				
			if (bundle.GetInt ("vibrate") == 1) 
			{
				long[] vibrate = {0,100,200,300};
				builder.SetVibrate (vibrate);
			}

			if (bundle.GetInt ("sound") == 1) 
			{
				Android.Net.Uri notificationsound = RingtoneManager.GetDefaultUri (RingtoneType.Notification);
				builder.SetSound (notificationsound);
			}

			// Obtain a reference to the NotificationManager
			NotificationManager notificationManager = (NotificationManager)context.GetSystemService(Context.NotificationService);
			notificationManager.Notify(NOTIFICATION_ID, builder.Build());




			/*
			mNotificationManager = (NotificationManager)this.s(Context.NOTIFICATION_SERVICE);

			PendingIntent contentIntent = PendingIntent.GetActivity(this, 0,new Intent(this, FlirtPlanetActivity.class), 0);

			NotificationCompat.Builder mBuilder =
								new NotificationCompat.Builder(this)
					.SetSmallIcon(Resource.Drawable.DD_Home_logo_flirt_planet)
								.SetContentTitle("GCM Notification")
								.SetStyle(new NotificationCompat.BigTextStyle()
								.BigText(msg))
								.SetContentText(msg);

			mBuilder.SetContentIntent(contentIntent);
			mNotificationManager.Notify(NOTIFICATION_ID, mBuilder.build());
			*/
		}


		private void handleRegistration(Context context, Intent intent) 
		{

			String registration = intent.GetStringExtra("registration_id");
			ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences (context);
			ISharedPreferencesEditor editor = prefs.Edit ();

			if (intent.GetStringExtra("error") != null) 
			{

				Console.WriteLine("c2dm", "registration failed");
				String error = intent.GetStringExtra("error");

				if(error == "SERVICE_NOT_AVAILABLE"){
					Console.WriteLine("c2dm", "SERVICE_NOT_AVAILABLE");
				}else if(error == "ACCOUNT_MISSING"){
					Console.WriteLine("c2dm", "ACCOUNT_MISSING");
				}else if(error == "AUTHENTICATION_FAILED"){
					Console.WriteLine("c2dm", "AUTHENTICATION_FAILED");
				}else if(error == "TOO_MANY_REGISTRATIONS"){
					Console.WriteLine("c2dm", "TOO_MANY_REGISTRATIONS");
				}else if(error == "INVALID_SENDER"){
					Console.WriteLine("c2dm", "INVALID_SENDER");
				}else if(error == "PHONE_REGISTRATION_ERROR"){
					Console.WriteLine("c2dm", "PHONE_REGISTRATION_ERROR");
				}

			} 
			else if (intent.GetStringExtra("unregistered") != null) 
			{
				editor.Remove ("regId");
				editor.Commit ();
			} 
			else if (registration != null) 
			{
				System.Threading.ThreadPool.QueueUserWorkItem (delegate {BusinessBase.SavePushToken (MainUser.AppUser.UniqUser, registration);});

				editor.PutString ("regId", registration);
				editor.Commit ();
			}
		}







	}
}

