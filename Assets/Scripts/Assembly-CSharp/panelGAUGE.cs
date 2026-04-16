using UnityEngine;

public class panelGAUGE
{
	private enum KIND
	{
		_DORAGON = 0,
		_TENSION = 1,
		_POWER = 2,
		_MAX = 3
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

	public const int WAIT_END = 0;

	public const int WAIT_DISA = 0;

	public const float DEF_POSX_DORAGON = 237.12f;

	public const float DEF_POSX_TENSION = 237.12f;

	public const float DEF_POSX_POWER = 237.12f;

	public const float DEF_POSY_DORAGON = 0.96f;

	public const float DEF_POSY_TENSION = 0.96f;

	public const float DEF_POSY_POWER = 0.96f;

	public const float DEF_POSZ_DORAGON = 0f;

	public const float DEF_POSZ_TENSION = 0f;

	public const float DEF_POSZ_POWER = 0f;

	private GameObject parts_doragon;

	private GameObject parts_tension;

	private GameObject parts_power;

	private STATE[] m_state = new STATE[3];

	private int[] m_frame = new int[3];

	private bool[] m_active = new bool[3];

	public void release()
	{
		parts_doragon = null;
		parts_tension = null;
		parts_power = null;
	}

	public void init()
	{
		int num = 0;
		parts_doragon = GameObject.Find("GUIDirection/Camera/Anchor/Panel_SYSTEM_GAUGE/001");
		parts_tension = GameObject.Find("GUIDirection/Camera/Anchor/Panel_SYSTEM_GAUGE/002");
		parts_power = GameObject.Find("GUIDirection/Camera/Anchor/Panel_SYSTEM_GAUGE/003");
		setPositionZ(0, 0f);
		setPositionZ(1, 0f);
		setPositionZ(2, 0f);
		for (num = 0; num < 3; num++)
		{
			getobj(num).SetActiveRecursively(false);
			m_state[num] = STATE._DISA;
			m_frame[num] = 0;
			m_active[num] = false;
		}
	}

	public void Update()
	{
		int num = 0;
		for (num = 0; num < 3; num++)
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
				if (m_frame[num] >= 0)
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
		int num = 0;
		for (num = 0; num < 3; num++)
		{
			setVisible(num, true);
		}
	}

	public void allDisable()
	{
		int num = 0;
		for (num = 0; num < 3; num++)
		{
			setVisible(num, false);
		}
	}

	public void setDispGauge(int _idx)
	{
		switch (_idx)
		{
		case 0:
			setVisible(0, true);
			setVisible(1, false);
			setVisible(2, false);
			break;
		case 1:
			setVisible(0, false);
			setVisible(1, true);
			setVisible(2, false);
			break;
		case 2:
			setVisible(0, false);
			setVisible(1, false);
			setVisible(2, true);
			break;
		}
	}

	public void baseEnable()
	{
		int num = 0;
		for (num = 0; num < 3; num++)
		{
			setVisible(num, false);
		}
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
		switch (_kind)
		{
		case 0:
			return parts_doragon;
		case 1:
			return parts_tension;
		case 2:
			return parts_power;
		default:
			return null;
		}
	}

	public float getDefPosX(int _kind)
	{
		float[] array = new float[3] { 237.12f, 237.12f, 237.12f };
		return array[_kind];
	}

	public float getDefPosY(int _kind)
	{
		float[] array = new float[3] { 0.96f, 0.96f, 0.96f };
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
