package flirtplanet;


public class visitorAdapter_PopupHolder
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("flirtplanet.visitorAdapter/PopupHolder, FlyOutMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", visitorAdapter_PopupHolder.class, __md_methods);
	}


	public visitorAdapter_PopupHolder () throws java.lang.Throwable
	{
		super ();
		if (getClass () == visitorAdapter_PopupHolder.class)
			mono.android.TypeManager.Activate ("flirtplanet.visitorAdapter/PopupHolder, FlyOutMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
