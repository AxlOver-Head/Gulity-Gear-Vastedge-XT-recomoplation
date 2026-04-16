using UnityEngine;

public class panelACZ014
{
	private enum KIND
	{
		_ADD = 0,
		_MAX = 1
	}

	private enum STATE
	{
		_INIT = 0,
		_START = 1,
		_WAIT = 2,
		_END = 3,
		_DISA = 4
	}

	public const int WAIT_INIT = 0;

	public const int WAIT_START = 0;

	public const int WAIT_WAIT = 0;

	public const int WAIT_END = 5;

	public const int WAIT_DISA = 0;

	public const float DEF_POSX_ADD = 128f;

	public const float DEF_POSY_ADD = -72.96f;

	public const float DEF_POSZ_ADD = 0f;

	public const float MOV_POSX_ADD = 0f;

	public const float MOV_POSY_ADD = 0f;

	private GameObject parts_add;

	private STATE[] m_state = new STATE[1];

	private int[] m_frame = new int[1];

	private bool[] m_active = new bool[1];

	public void release()
	{
		parts_add = null;
	}

	public void init()
	{
		int num = 0;
		parts_add = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ014/001");
		setPositionZ(0, 0f);
		parts_add.SetActiveRecursively(false);
		for (num = 0; num < 1; num++)
		{
			m_state[num] = STATE._DISA;
			m_frame[num] = 0;
			m_active[num] = false;
		}
	}

	public void Update()
	{
		int num = 0;
		for (num = 0; num < 1; num++)
		{
			if (!m_active[num])
			{
				continue;
			}
			switch (m_state[num])
			{
			case STATE._INIT:
				startObject(num);
				m_state[num] = STATE._START;
				m_frame[num] = 0;
				break;
			case STATE._START:
				m_frame[num]++;
				m_frame[num] = ((m_frame[num] <= 65535) ? m_frame[num] : 0);
				if (m_frame[num] >= 0)
				{
					m_state[num] = STATE._WAIT;
					m_frame[num] = 0;
				}
				break;
			case STATE._WAIT:
				m_frame[num]++;
				m_frame[num] = ((m_frame[num] <= 65535) ? m_frame[num] : 0);
				break;
			case STATE._END:
				m_frame[num]++;
				m_frame[num] = ((m_frame[num] <= 65535) ? m_frame[num] : 0);
				if (m_frame[num] >= 5)
				{
					m_state[num] = STATE._DISA;
					m_frame[num] = 0;
				}
				break;
			case STATE._DISA:
				endObject(num);
				break;
			}
		}
	}

	public void end()
	{
	}

	public void allEnable()
	{
		setVisible(0, true);
	}

	public void allDisable()
	{
		setVisible(0, false);
	}

	public void baseEnable()
	{
		setVisible(0, true);
	}

	public void setVisible(int _kind, bool _flag)
	{
		if (_flag)
		{
			m_state[_kind] = STATE._INIT;
			m_frame[_kind] = 0;
			m_active[_kind] = true;
		}
		else
		{
			m_state[_kind] = STATE._END;
			m_frame[_kind] = 0;
		}
	}

	public GameObject getobj(int _kind)
	{
		if (_kind == 0)
		{
			return parts_add;
		}
		return null;
	}

	public float getDefPosX(int _kind)
	{
		float[] array = new float[1] { 128f };
		return array[_kind];
	}

	public float getDefPosY(int _kind)
	{
		float[] array = new float[1] { -72.96f };
		return array[_kind];
	}

	public void startObject(int _kind)
	{
		getobj(_kind).SetActiveRecursively(true);
		getobj(_kind).transform.localPosition = new Vector3(getDefPosX(_kind), getDefPosY(_kind), getobj(_kind).transform.localPosition.z);
		m_active[_kind] = true;
	}

	public void endObject(int _kind)
	{
		getobj(_kind).SetActiveRecursively(false);
		m_active[_kind] = false;
	}

	public void setPosition(int _kind, float _x, float _y, float _z)
	{
		getobj(_kind).transform.localPosition = new Vector3(_x, _y, _z);
	}

	public void setPositionX(int _kind, float _x)
	{
		setPosition(_kind, _x, getobj(_kind).transform.localPosition.y, getobj(_kind).transform.localPosition.z);
	}

	public void setPositionY(int _kind, float _y)
	{
		setPosition(_kind, getobj(_kind).transform.localPosition.x, _y, getobj(_kind).transform.localPosition.z);
	}

	public void setPositionZ(int _kind, float _z)
	{
		setPosition(_kind, getobj(_kind).transform.localPosition.x, getobj(_kind).transform.localPosition.y, _z);
	}
}
