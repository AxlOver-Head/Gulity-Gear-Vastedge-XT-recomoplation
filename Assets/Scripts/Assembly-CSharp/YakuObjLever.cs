using UnityEngine;

public class YakuObjLever : YakuObj
{
	public YakuObjLever()
	{
		init();
	}

	public new void init()
	{
		obj = GameObject.Find("kyoutai/sglg_lever");
		anm = obj.GetComponent<Animation>();
		base.init();
	}

	public override void start(int _id)
	{
		if (!(anm == null))
		{
			start(_id, "Take 001");
		}
	}

	public override void control()
	{
		if (m_Active)
		{
			base.control();
		}
	}
}
