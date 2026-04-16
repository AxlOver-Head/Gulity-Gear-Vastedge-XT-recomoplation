using UnityEngine;

public class YakuObjJYD : YakuObj
{
	public enum KIND
	{
		UNION = 0,
		SHAKE_1 = 1,
		SHAKE_2 = 2,
		SHAKE_3 = 3,
		SHAKE_4 = 4,
		RETURN = 5,
		MAX = 6
	}

	private string[] anmList = new string[3] { "union", "gabu", "putaway" };

	public YakuObjJYD()
	{
		init();
	}

	public new void init()
	{
		obj = GameObject.Find("kyoutai/sglg_JYD");
		anm = obj.GetComponent<Animation>();
		base.init();
	}

	public override void start(int _id)
	{
		if (anm == null || _id < 0)
		{
			return;
		}
		switch (_id)
		{
		case 0:
			if (!m_Active || (m_ID == 5 && m_Cnt >= 10))
			{
				start(_id, anmList[0]);
			}
			break;
		case 1:
		case 2:
		case 3:
		case 4:
			if (!m_Active || (m_ID == 0 && m_Cnt >= 10))
			{
				start(_id, anmList[1]);
				int num = _id - 1;
				for (int i = 0; i < num; i++)
				{
					anm.PlayQueued(anmList[1]);
				}
			}
			break;
		case 5:
			if (!m_Active || (m_ID == 0 && m_Cnt >= 10))
			{
				start(_id, anmList[2]);
			}
			break;
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
