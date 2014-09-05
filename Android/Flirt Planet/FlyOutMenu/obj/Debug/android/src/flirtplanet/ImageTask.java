package flirtplanet;


public class ImageTask
	extends flirtplanet.FlirtPlanetActivity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("flirtplanet.ImageTask, FlyOutMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ImageTask.class, __md_methods);
	}


	public ImageTask () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ImageTask.class)
			mono.android.TypeManager.Activate ("flirtplanet.ImageTask, FlyOutMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
