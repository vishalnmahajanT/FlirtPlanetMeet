package mono.com.facebook.widget;


public class ProfilePictureView_OnErrorListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.facebook.widget.ProfilePictureView.OnErrorListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onError:(Lcom/facebook/FacebookException;)V:GetOnError_Lcom_facebook_FacebookException_Handler:Xamarin.FacebookBinding.Widget.ProfilePictureView/IOnErrorListenerInvoker, Xamarin.Facebook\n" +
			"";
		mono.android.Runtime.register ("Xamarin.FacebookBinding.Widget.ProfilePictureView/IOnErrorListenerImplementor, Xamarin.Facebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ProfilePictureView_OnErrorListenerImplementor.class, __md_methods);
	}


	public ProfilePictureView_OnErrorListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ProfilePictureView_OnErrorListenerImplementor.class)
			mono.android.TypeManager.Activate ("Xamarin.FacebookBinding.Widget.ProfilePictureView/IOnErrorListenerImplementor, Xamarin.Facebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onError (com.facebook.FacebookException p0)
	{
		n_onError (p0);
	}

	private native void n_onError (com.facebook.FacebookException p0);

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