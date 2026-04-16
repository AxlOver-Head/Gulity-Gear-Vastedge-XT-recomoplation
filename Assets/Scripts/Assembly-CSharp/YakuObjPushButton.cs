using UnityEngine;

public class YakuObjPushButton : YakuObj
{
	public enum KIND
	{
		UP = 0,
		DOWN = 1,
		PUSH_B = 2,
		PUSH = 3
	}

	private float[][] posTable = new float[4][]
	{
		new float[4]
		{
			0.36625f,
			0.3675f,
			59f / 160f,
			0.37f
		},
		new float[4]
		{
			59f / 160f,
			0.3675f,
			0.36625f,
			0.365f
		},
		new float[7] { 0.36925f, 0.3685f, 0.36775f, 0.367f, 0.368f, 0.369f, 0.37f },
		new float[7] { 0.36425f, 0.3635f, 0.36275f, 0.362f, 0.363f, 0.364f, 0.365f }
	};

	private string[] anmList = new string[4] { "buildup", "builddown", "buildpush", "pushdown" };

	public YakuObjPushButton()
	{
		init();
	}

	public new void init()
	{
		obj = GameObject.Find("kyoutai/sglg_push/sglg_push");
		anm = obj.GetComponent<Animation>();
		base.init();
	}

	public override void start(int _id)
	{
		if (!(anm == null) && _id >= 0 && _id < anmList.Length)
		{
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
			if (m_Cnt >= posTable[m_ID].Length)
			{
				m_Active = false;
				m_Cnt = 0;
				m_ID = -1;
			}
			else
			{
				obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, posTable[m_ID][m_Cnt], obj.transform.localPosition.z);
				base.control();
			}
		}
	}
}
