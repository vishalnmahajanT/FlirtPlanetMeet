package flirtplanet;


public class NimpRewardPopup
	extends flirtplanet.Popup
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("flirtplanet.NimpRewardPopup, FlyOutMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", NimpRewardPopup.class, __md_methods);
	}


	public NimpRewardPopup () throws java.lang.Throwable
	{
		super ();
		if (getClass () == NimpRewardPopup.class)
			mono.android.TypeManager.Activate ("flirtplanet.NimpRewardPopup, FlyOutMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
