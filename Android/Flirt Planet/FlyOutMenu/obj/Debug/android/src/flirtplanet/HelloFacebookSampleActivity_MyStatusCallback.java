package flirtplanet;


public class HelloFacebookSampleActivity_MyStatusCallback
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.facebook.Session.StatusCallback
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_call:(Lcom/facebook/Session;Lcom/facebook/SessionState;Ljava/lang/Exception;)V:GetCall_Lcom_facebook_Session_Lcom_facebook_SessionState_Ljava_lang_Exception_Handler:Xamarin.FacebookBinding.Session/IStatusCallbackInvoker, Xamarin.Facebook\n" +
			"";
		mono.android.Runtime.register ("flirtplanet.HelloFacebookSampleActivity/MyStatusCallback, FlyOutMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", HelloFacebookSampleActivity_MyStatusCallback.class, __md_methods);
	}


	public HelloFacebookSampleActivity_MyStatusCallback () throws java.lang.Throwable
	{
		super ();
		if (getClass () == HelloFacebookSampleActivity_MyStatusCallback.class)
			mono.android.TypeManager.Activate ("flirtplanet.HelloFacebookSampleActivity/MyStatusCallback, FlyOutMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public HelloFacebookSampleActivity_MyStatusCallback (flirtplanet.HelloFacebookSampleActivity p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == HelloFacebookSampleActivity_MyStatusCallback.class)
			mono.android.TypeManager.Activate ("flirtplanet.HelloFacebookSampleActivity/MyStatusCallback, FlyOutMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "flirtplanet.HelloFacebookSampleActivity, FlyOutMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}


	public void call (com.facebook.Session p0, com.facebook.SessionState p1, java.lang.Exception p2)
	{
		n_call (p0, p1, p2);
	}

	private native void n_call (com.facebook.Session p0, com.facebook.SessionState p1, java.lang.Exception p2);

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
