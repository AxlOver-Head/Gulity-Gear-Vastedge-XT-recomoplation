using UnityEngine;

public class YakuObj
{
	protected bool m_Active;

	protected int m_ID = -1;

	protected int m_Cnt;

	protected GameObject obj;

	protected Animation anm;

	public YakuObj()
	{
		init();
	}

	public void init()
	{
		m_Active = false;
		m_ID = -1;
		m_Cnt = 0;
	}

	public virtual void start(int _id)
	{
	}

	protected virtual void start(int _id, string str)
	{
		if (!(anm == null))
		{
			m_Active = true;
			m_ID = _id;
			m_Cnt = 0;
			anm.Play(str);
		}
	}

	public virtual void control()
	{
		m_Cnt++;
	}

	public int getID()
	{
		return m_ID;
	}
}
