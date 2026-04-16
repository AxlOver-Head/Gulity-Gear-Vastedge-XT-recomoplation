using UnityEngine;

public class YakuObjLogo : YakuObj
{
	public enum KIND
	{
		LOGO1 = 0,
		LOGO2 = 1,
		LOGO3 = 2,
		LOGO4 = 3,
		LOGO5 = 4,
		LOGO6 = 5,
		LOGO7 = 6,
		LOGO8 = 7,
		LOGO9 = 8,
		LOGO10 = 9,
		LOGO11 = 10,
		LOGO12 = 11,
		LOGO13 = 12,
		LOGO14 = 13,
		LOGO15 = 14,
		LOGO16 = 15,
		LOGO17 = 16,
		LOGO18 = 17,
		LOGO19 = 18,
		LOGO20 = 19,
		LOGO21 = 20,
		LOGO22 = 21,
		LOGO23 = 22,
		LOGO24 = 23,
		LOGO25 = 24,
		LOGO26 = 25,
		LOGO27 = 26,
		LOGO28 = 27,
		LOGO29 = 28,
		LOGO30 = 29,
		LOGO31 = 30,
		LOGO32 = 31,
		LOGO33 = 32,
		LOGO34 = 33,
		LOGO35 = 34,
		LOGO36 = 35,
		LOGO37 = 36,
		LOGO38 = 37,
		LOGO39 = 38,
		LOGO40 = 39,
		LOGO41 = 40,
		LOGO42 = 41,
		LOGO43 = 42,
		LOGO44 = 43,
		LOGO45 = 44,
		LOGO46 = 45,
		LOGO47 = 46,
		LOGO48 = 47,
		LOGO49 = 48,
		LOGO50 = 49,
		LOGO51 = 50,
		MAX = 51
	}

	private float[] posTable = new float[4] { 0.712f, 0.708f, 0.712f, 0.716f };

	public YakuObjLogo()
	{
		init();
	}

	public new void init()
	{
		obj = GameObject.Find("kyoutai/sglg_logo");
		anm = obj.GetComponent<Animation>();
		base.init();
	}

	public override void start(int _id)
	{
		if (!(anm == null) && _id >= 0 && _id < 51)
		{
			switch (_id)
			{
			case 1:
				MainGameScene.dirMan.logoYakuSound(2);
				break;
			case 3:
			case 7:
				MainGameScene.dirMan.logoYakuSound(1);
				break;
			}
			_start(_id);
		}
	}

	private void _start(int _id)
	{
		m_Active = true;
		m_ID = _id;
		m_Cnt = 0;
	}

	public override void control()
	{
		if (m_Active)
		{
			if (m_Cnt >= (m_ID + 1) * posTable.Length)
			{
				m_Active = false;
				m_Cnt = 0;
				m_ID = -1;
			}
			else
			{
				obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, posTable[m_Cnt % posTable.Length], obj.transform.localPosition.z);
				base.control();
			}
		}
	}
}
