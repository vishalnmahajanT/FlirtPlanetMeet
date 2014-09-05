package flirtplanet;


public class NimpCountdownAnim
	extends android.app.Fragment
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("flirtplanet.NimpCountdownAnim, FlyOutMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", NimpCountdownAnim.class, __md_methods);
	}


	public NimpCountdownAnim () throws java.lang.Throwable
	{
		super ();
		if (getClass () == NimpCountdownAnim.class)
			mono.android.TypeManager.Activate ("flirtplanet.NimpCountdownAnim, FlyOutMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
