package flirtplanet;


public class FragmentFacebookAlbumPhotos
	extends android.app.Fragment
	implements
		mono.android.IGCUserPeer,
		com.facebook.Request.Callback
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateView:(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroid/view/View;:GetOnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_Handler\n" +
			"n_onCompleted:(Lcom/facebook/Response;)V:GetOnCompleted_Lcom_facebook_Response_Handler:Xamarin.FacebookBinding.Request/ICallbackInvoker, Xamarin.Facebook\n" +
			"";
		mono.android.Runtime.register ("flirtplanet.FragmentFacebookAlbumPhotos, FlyOutMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", FragmentFacebookAlbumPhotos.class, __md_methods);
	}


	public FragmentFacebookAlbumPhotos () throws java.lang.Throwable
	{
		super ();
		if (getClass () == FragmentFacebookAlbumPhotos.class)
			mono.android.TypeManager.Activate ("flirtplanet.FragmentFacebookAlbumPhotos, FlyOutMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public FragmentFacebookAlbumPhotos (java.lang.String p0, java.lang.String p1) throws java.lang.Throwable
	{
		super ();
		if (getClass () == FragmentFacebookAlbumPhotos.class)
			mono.android.TypeManager.Activate ("flirtplanet.FragmentFacebookAlbumPhotos, FlyOutMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1 });
	}


	public android.view.View onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2)
	{
		return n_onCreateView (p0, p1, p2);
	}

	private native android.view.View n_onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2);


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
