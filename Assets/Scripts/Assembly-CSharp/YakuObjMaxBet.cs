using UnityEngine;

public class YakuObjMaxBet : YakuObj
{
	public YakuObjMaxBet()
	{
		init();
	}

	public new void init()
	{
		obj = GameObject.Find("kyoutai/sglg_maxbet");
		anm = obj.GetComponent<Animation>();
		base.init();
	}

	public override void start(int _id)
	{
		if (!(anm == null))
		{
			start(_id, "maxbet");
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
