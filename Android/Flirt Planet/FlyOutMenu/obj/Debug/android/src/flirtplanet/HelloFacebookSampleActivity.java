package flirtplanet;


public class HelloFacebookSampleActivity
	extends android.support.v4.app.FragmentActivity
	implements
		mono.android.IGCUserPeer,
		com.facebook.Request.Callback
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onResume:()V:GetOnResumeHandler\n" +
			"n_onActivityResult:(IILandroid/content/Intent;)V:GetOnActivityResult_IILandroid_content_Intent_Handler\n" +
			"n_onPause:()V:GetOnPauseHandler\n" +
			"n_onDestroy:()V:GetOnDestroyHandler\n" +
			"n_onBackPressed:()V:GetOnBackPressedHandler\n" +
			"n_onCompleted:(Lcom/facebook/Response;)V:GetOnCompleted_Lcom_facebook_Response_Handler:Xamarin.FacebookBinding.Request/ICallbackInvoker, Xamarin.Facebook\n" +
			"";
		mono.android.Runtime.register ("flirtplanet.HelloFacebookSampleActivity, FlyOutMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", HelloFacebookSampleActivity.class, __md_methods);
	}


	public HelloFacebookSampleActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == HelloFacebookSampleActivity.class)
			mono.android.TypeManager.Activate ("flirtplanet.HelloFacebookSampleActivity, FlyOutMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onResume ()
	{
		n_onResume ();
	}

	private native void n_onResume ();


	public void onActivityResult (int p0, int p1, android.content.Intent p2)
	{
		n_onActivityResult (p0, p1, p2);
	}

	private native void n_onActivityResult (int p0, int p1, android.content.Intent p2);


	public void onPause ()
	{
		n_onPause ();
	}

	private native void n_onPause ();


	public void onDestroy ()
	{
		n_onDestroy ();
	}

	private native void n_onDestroy ();


	public void onBackPressed ()
	{
		n_onBackPressed ();
	}

	private native void n_onBackPressed ();


	public void onCompleted (com.facebook.Response p0)
	{
		n_onCompleted (p0);
	}

	private native void n_onCompleted (com.facebook.Response p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
