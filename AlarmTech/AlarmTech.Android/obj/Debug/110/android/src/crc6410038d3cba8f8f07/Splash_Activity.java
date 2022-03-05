package crc6410038d3cba8f8f07;


public class Splash_Activity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("AlarmTech.Droid.Splash_Activity, AlarmTech.Android", Splash_Activity.class, __md_methods);
	}


	public Splash_Activity ()
	{
		super ();
		if (getClass () == Splash_Activity.class)
			mono.android.TypeManager.Activate ("AlarmTech.Droid.Splash_Activity, AlarmTech.Android", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
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
