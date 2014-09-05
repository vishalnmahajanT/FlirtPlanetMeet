package flirtplanet;


public class FragmentFacebookAlbums_albumsAdapter
	extends android.widget.BaseAdapter
	implements
		mono.android.IGCUserPeer,
		com.facebook.Request.Callback
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_getCount:()I:GetGetCountHandler\n" +
			"n_getItem:(I)Ljava/lang/Object;:GetGetItem_IHandler\n" +
			"n_getItemId:(I)J:GetGetItemId_IHandler\n" +
			"n_getView:(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;:GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler\n" +
			"n_onCompleted:(Lcom/facebook/Response;)V:GetOnCompleted_Lcom_facebook_Response_Handler:Xamarin.FacebookBinding.Request/ICallbackInvoker, Xamarin.Facebook\n" +
			"";
		mono.android.Runtime.register ("flirtplanet.FragmentFacebookAlbums/albumsAdapter, FlyOutMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", FragmentFacebookAlbums_albumsAdapter.class, __md_methods);
	}


	public FragmentFacebookAlbums_albumsAdapter () throws java.lang.Throwable
	{
		super ();
		if (getClass () == FragmentFacebookAlbums_albumsAdapter.class)
			mono.android.TypeManager.Activate ("flirtplanet.FragmentFacebookAlbums/albumsAdapter, FlyOutMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public int getCount ()
	{
		return n_getCount ();
	}

	private native int n_getCount ();


	public java.lang.Object getItem (int p0)
	{
		return n_getItem (p0);
	}

	private native java.lang.Object n_getItem (int p0);


	public long getItemId (int p0)
	{
		return n_getItemId (p0);
	}

	private native long n_getItemId (int p0);


	public android.view.View getView (int p0, android.view.View p1, android.view.ViewGroup p2)
	{
		return n_getView (p0, p1, p2);
	}

	private native android.view.View n_getView (int p0, android.view.View p1, android.view.ViewGroup p2);


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
