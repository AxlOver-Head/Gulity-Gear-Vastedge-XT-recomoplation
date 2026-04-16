using UnityEngine;

public class panelACZ010
{
	private enum KIND
	{
		_BASE = 0,
		_GEAR_R = 1,
		_GEAR_L = 2,
		_ADD1 = 3,
		_ADD2 = 4,
		_NUM1 = 5,
		_NUM2 = 6,
		_MAX = 7
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

	public const float DEF_POSX_GEAR_L = 5.12f;

	public const float DEF_POSX_GEAR_R = 251.2f;

	public const float DEF_POSX_BASE = 128f;

	public const float DEF_POSX_ADD1 = 128f;

	public const float DEF_POSX_ADD2 = 128f;

	public const float DEF_POSX_NUM1 = 245f;

	public const float DEF_POSX_NUM2 = 239.44f;

	public const float DEF_POSY_GEAR_L = -126.72f;

	public const float DEF_POSY_GEAR_R = -126.08f;

	public const float DEF_POSY_BASE = -132.48f;

	public const float DEF_POSY_ADD1 = -132.48f;

	public const float DEF_POSY_ADD2 = -132.48f;

	public const float DEF_POSY_NUM1 = -129.92f;

	public const float DEF_POSY_NUM2 = -129.92f;

	public const float DEF_POSZ_GEAR_L = 0f;

	public const float DEF_POSZ_GEAR_R = 0f;

	public const float DEF_POSZ_BASE = 0f;

	public const float DEF_POSZ_ADD1 = 0f;

	public const float DEF_POSZ_ADD2 = 0f;

	public const float DEF_POSZ_NUM1 = 0f;

	public const float DEF_POSZ_NUM2 = 0f;

	public const float MOV_POSX_GEAR_L = 0f;

	public const float MOV_POSX_GEAR_R = 0f;

	public const float MOV_POSX_BASE = 0f;

	public const float MOV_POSX_ADD1 = 0f;

	public const float MOV_POSX_ADD2 = 0f;

	public const float MOV_POSX_NUM1 = 0f;

	public const float MOV_POSX_NUM2 = 0f;

	public const float MOV_POSY_GEAR_L = 3f;

	public const float MOV_POSY_GEAR_R = 3f;

	public const float MOV_POSY_BASE = 3f;

	public const float MOV_POSY_ADD1 = 3f;

	public const float MOV_POSY_ADD2 = 3f;

	public const float MOV_POSY_NUM1 = 3f;

	public const float MOV_POSY_NUM2 = 3f;

	private GameObject parts_gear_r;

	private GameObject parts_gear_l;

	private GameObject parts_base;

	private GameObject parts_add1;

	private GameObject parts_add2;

	private GameObject parts_num1;

	private GameObject parts_num2;

	private UISprite m_add1;

	private UISprite m_add2;

	private UISprite m_num1;

	private UISprite m_num2;

	private STATE[] m_state = new STATE[7];

	private int[] m_frame = new int[7];

	private bool[] m_active = new bool[7];

	private int m_track;

	public void release()
	{
		parts_gear_r = null;
		parts_gear_l = null;
		parts_base = null;
		parts_add1 = null;
		parts_add2 = null;
		parts_num1 = null;
		parts_num2 = null;
		m_add1 = null;
		m_add2 = null;
		m_num1 = null;
		m_num2 = null;
	}

	public void init()
	{
		int num = 0;
		parts_gear_l = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ010/003");
		parts_gear_r = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ010/004");
		parts_base = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ010/006");
		parts_add1 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ010/010");
		parts_add2 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ010/011");
		parts_num1 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ010/018");
		parts_num2 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ010/019");
		setPositionZ(0, 0f);
		setPositionZ(1, 0f);
		setPositionZ(2, 0f);
		setPositionZ(3, 0f);
		setPositionZ(4, 0f);
		setPositionZ(5, 0f);
		setPositionZ(6, 0f);
		m_add1 = parts_add1.GetComponent<UISprite>();
		m_add2 = parts_add2.GetComponent<UISprite>();
		m_num1 = parts_num1.GetComponent<UISprite>();
		m_num2 = parts_num2.GetComponent<UISprite>();
		parts_base.SetActiveRecursively(false);
		parts_gear_r.SetActiveRecursively(false);
		parts_gear_l.SetActiveRecursively(false);
		parts_add1.SetActiveRecursively(false);
		parts_add2.SetActiveRecursively(false);
		parts_num1.SetActiveRecursively(false);
		parts_num2.SetActiveRecursively(false);
		for (num = 0; num < 7; num++)
		{
			m_state[num] = STATE._DISA;
			m_frame[num] = 0;
			m_active[num] = false;
		}
	}

	public void Update()
	{
		int num = 0;
		for (num = 0; num < 7; num++)
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
				if (m_frame[num] % 160 < 80)
				{
					m_add1.alpha = (float)(m_frame[num] % 80) / 80f;
					m_add2.alpha = (float)(m_frame[num] % 80) / 80f;
				}
				else
				{
					m_add1.alpha = (float)(80 - m_frame[num] % 80) / 80f;
					m_add2.alpha = (float)(80 - m_frame[num] % 80) / 80f;
				}
				break;
			case STATE._END:
				setPositionY(0, getDefPosY(0) - (float)m_frame[num] * 3f);
				setPositionY(1, getDefPosY(1) - (float)m_frame[num] * 3f);
				setPositionY(2, getDefPosY(2) - (float)m_frame[num] * 3f);
				setPositionY(3, getDefPosY(3) - (float)m_frame[num] * 3f);
				setPositionY(4, getDefPosY(4) - (float)m_frame[num] * 3f);
				setPositionY(5, getDefPosY(5) - (float)m_frame[num] * 3f);
				setPositionY(6, getDefPosY(6) - (float)m_frame[num] * 3f);
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
		setVisible(1, true);
		setVisible(2, true);
		setVisible(3, true);
		setVisible(4, true);
		setVisible(5, true);
		setVisible(6, true);
	}

	public void allDisable()
	{
		setVisible(0, false);
		setVisible(1, false);
		setVisible(2, false);
		setVisible(3, false);
		setVisible(4, false);
		setVisible(5, false);
		setVisible(6, false);
	}

	public void baseEnable()
	{
		setVisible(0, true);
		setVisible(1, true);
		setVisible(2, true);
		setVisible(3, true);
		setVisible(4, true);
		setVisible(5, true);
		setVisible(6, true);
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

	public void setTrack(int _track)
	{
		string[] array = new string[10] { "9602_o_u_a_11", "9602_o_u_a_12", "9602_o_u_a_13", "9602_o_u_a_14", "9602_o_u_a_15", "9602_o_u_a_16", "9602_o_u_a_17", "9602_o_u_a_18", "9602_o_u_a_19", "9602_o_u_a_20" };
		m_track = _track;
		int num = m_track % 10;
		int num2 = m_track / 10;
		m_num1.spriteName = array[num];
		m_num2.spriteName = array[num2];
		if (num2 == 0)
		{
			endObject(6);
		}
		else
		{
			startObject(6);
		}
	}

	public GameObject getobj(int _kind)
	{
		switch (_kind)
		{
		case 0:
			return parts_base;
		case 1:
			return parts_gear_r;
		case 2:
			return parts_gear_l;
		case 3:
			return parts_add1;
		case 4:
			return parts_add2;
		case 5:
			return parts_num1;
		case 6:
			return parts_num2;
		default:
			return null;
		}
	}

	public float getDefPosX(int _kind)
	{
		float[] array = new float[7] { 128f, 251.2f, 5.12f, 128f, 128f, 245f, 239.44f };
		return array[_kind];
	}

	public float getDefPosY(int _kind)
	{
		float[] array = new float[7] { -132.48f, -126.08f, -126.72f, -132.48f, -132.48f, -129.92f, -129.92f };
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
