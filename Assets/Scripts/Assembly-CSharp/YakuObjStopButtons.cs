using UnityEngine;

public class YakuObjStopButtons : YakuObj
{
	public enum KIND
	{
		PUSH = 0,
		PULL = 1
	}

	private string m_Kind = string.Empty;

	private float[][] posTable = new float[2][]
	{
		new float[3] { 0.126666f, 0.123333f, 0.12f },
		new float[3] { 0.123333f, 0.126666f, 0.13f }
	};

	private string[] anmList = new string[2] { "_push", "_modori" };

	public YakuObjStopButtons(string kind)
	{
		init(kind);
	}

	public void init(string kind)
	{
		m_Kind = kind;
		obj = GameObject.Find("kyoutai/sglg_button_" + m_Kind + "/sglg_button_" + m_Kind);
		anm = obj.GetComponent<Animation>();
		init();
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
				obj.transform.localPosition = new Vector3(obj.transform.localPosition.x, obj.transform.localPosition.y, posTable[m_ID][m_Cnt]);
				base.control();
			}
		}
	}
}
