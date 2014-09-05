package flirtplanet;


public class NimpPlayPopup
	extends flirtplanet.Popup
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("flirtplanet.NimpPlayPopup, FlyOutMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", NimpPlayPopup.class, __md_methods);
	}


	public NimpPlayPopup () throws java.lang.Throwable
	{
		super ();
		if (getClass () == NimpPlayPopup.class)
			mono.android.TypeManager.Activate ("flirtplanet.NimpPlayPopup, FlyOutMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
