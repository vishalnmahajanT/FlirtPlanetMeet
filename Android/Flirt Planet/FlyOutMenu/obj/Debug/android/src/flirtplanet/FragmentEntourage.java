package flirtplanet;


public class FragmentEntourage
	extends android.app.Fragment
	implements
		mono.android.IGCUserPeer,
		com.facebook.Request.GraphUserListCallback,
		com.facebook.widget.WebDialog.OnCompleteListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateView:(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroid/view/View;:GetOnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_Handler\n" +
			"n_onCompleted:(Ljava/util/List;Lcom/facebook/Response;)V:GetOnCompleted_Ljava_util_List_Lcom_facebook_Response_Handler:Xamarin.FacebookBinding.Request/IGraphUserListCallbackInvoker, Xamarin.Facebook\n" +
			"n_onComplete:(Landroid/os/Bundle;Lcom/facebook/FacebookException;)V:GetOnComplete_Landroid_os_Bundle_Lcom_facebook_FacebookException_Handler:Xamarin.FacebookBinding.Widget.WebDialog/IOnCompleteListenerInvoker, Xamarin.Facebook\n" +
			"";
		mono.android.Runtime.register ("flirtplanet.FragmentEntourage, FlyOutMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", FragmentEntourage.class, __md_methods);
	}


	public FragmentEntourage () throws java.lang.Throwable
	{
		super ();
		if (getClass () == FragmentEntourage.class)
			mono.android.TypeManager.Activate ("flirtplanet.FragmentEntourage, FlyOutMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public android.view.View onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2)
	{
		return n_onCreateView (p0, p1, p2);
	}

	private native android.view.View n_onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2);


	public void onCompleted (java.util.List p0, com.facebook.Response p1)
	{
		n_onCompleted (p0, p1);
	}

	private native void n_onCompleted (java.util.List p0, com.facebook.Response p1);


	public void onComplete (android.os.Bundle p0, com.facebook.FacebookException p1)
	{
		n_onComplete (p0, p1);
	}

	private native void n_onComplete (android.os.Bundle p0, com.facebook.FacebookException p1);

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
