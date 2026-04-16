using UnityEngine;

public class panelACZ012
{
	private enum KIND
	{
		_SIDE_R = 0,
		_SIDE_L = 1,
		_BASE = 2,
		_ADD = 3,
		_ADD10 = 4,
		_ADD11 = 5,
		_ADD12 = 6,
		_ADD13 = 7,
		_NUM1 = 8,
		_NUM2 = 9,
		_MAX = 10
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

	public const int WAIT_START = 6;

	public const int WAIT_WAIT = 0;

	public const int WAIT_END = 5;

	public const int WAIT_DISA = 0;

	public const float DEF_POSX_SIDE_R = 247.04f;

	public const float DEF_POSX_SIDE_L = 8.96f;

	public const float DEF_POSX_BASE = 128f;

	public const float DEF_POSX_ADD = 128f;

	public const float DEF_POSX_ADD10 = 128f;

	public const float DEF_POSX_ADD11 = 128f;

	public const float DEF_POSX_ADD12 = 128f;

	public const float DEF_POSX_ADD13 = 128f;

	public const float DEF_POSX_NUM1 = 245f;

	public const float DEF_POSX_NUM2 = 239.44f;

	public const float DEF_POSY_SIDE_R = -69.76f;

	public const float DEF_POSY_SIDE_L = -69.76f;

	public const float DEF_POSY_BASE = -132.48f;

	public const float DEF_POSY_ADD = -72.96f;

	public const float DEF_POSY_ADD10 = -69f;

	public const float DEF_POSY_ADD11 = -132.5f;

	public const float DEF_POSY_ADD12 = -70f;

	public const float DEF_POSY_ADD13 = -45.5f;

	public const float DEF_POSY_NUM1 = -130f;

	public const float DEF_POSY_NUM2 = -129.92f;

	public const float DEF_POSZ_SIDE_R = 0f;

	public const float DEF_POSZ_SIDE_L = 0f;

	public const float DEF_POSZ_BASE = 0f;

	public const float DEF_POSZ_ADD = 0f;

	public const float DEF_POSZ_ADD10 = 0f;

	public const float DEF_POSZ_ADD11 = 0f;

	public const float DEF_POSZ_ADD12 = 0f;

	public const float DEF_POSZ_ADD13 = 0f;

	public const float DEF_POSZ_NUM1 = 0f;

	public const float DEF_POSZ_NUM2 = 0f;

	public const float MOV_POSX_SIDE_R = 1f;

	public const float MOV_POSX_SIDE_L = 1f;

	public const float MOV_POSX_BASE = 0f;

	public const float MOV_POSX_ADD = 0f;

	public const float MOV_POSX_ADD10 = 0f;

	public const float MOV_POSX_ADD11 = 0f;

	public const float MOV_POSX_ADD12 = 0f;

	public const float MOV_POSX_ADD13 = 0f;

	public const float MOV_POSX_NUM1 = 0f;

	public const float MOV_POSX_NUM2 = 0f;

	public const float MOV_POSY_SIDE_R = 0f;

	public const float MOV_POSY_SIDE_L = 0f;

	public const float MOV_POSY_BASE = 3f;

	public const float MOV_POSY_ADD = 0f;

	public const float MOV_POSY_ADD10 = 0f;

	public const float MOV_POSY_ADD11 = 0f;

	public const float MOV_POSY_ADD12 = 0f;

	public const float MOV_POSY_ADD13 = 0f;

	public const float MOV_POSY_NUM1 = 3f;

	public const float MOV_POSY_NUM2 = 3f;

	private GameObject parts_side_r;

	private GameObject parts_side_l;

	private GameObject parts_base;

	private GameObject parts_add;

	private GameObject parts_add10;

	private GameObject parts_add11;

	private GameObject parts_add12;

	private GameObject parts_add13;

	private GameObject parts_num1;

	private GameObject parts_num2;

	private UISprite m_add10;

	private UISprite m_add11;

	private UISprite m_add12;

	private UISprite m_add13;

	private UISprite m_num1;

	private UISprite m_num2;

	private STATE[] m_state = new STATE[10];

	private int[] m_frame = new int[10];

	private bool[] m_active = new bool[10];

	private int m_track;

	public void release()
	{
		parts_side_r = null;
		parts_side_l = null;
		parts_base = null;
		parts_add = null;
		parts_add10 = null;
		parts_add11 = null;
		parts_add12 = null;
		parts_add13 = null;
		parts_num1 = null;
		parts_num2 = null;
		m_add10 = null;
		m_add11 = null;
		m_add12 = null;
		m_add13 = null;
		m_num1 = null;
		m_num2 = null;
	}

	public void init()
	{
		int num = 0;
		parts_side_r = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ012/006");
		parts_side_l = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ012/007");
		parts_base = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ012/008");
		parts_add = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ012/015");
		parts_add10 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ012/010");
		parts_add11 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ012/011");
		parts_add12 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ012/012");
		parts_add13 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ012/013");
		parts_num1 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ012/018");
		parts_num2 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ012/019");
		m_add10 = parts_add10.GetComponent<UISprite>();
		m_add11 = parts_add11.GetComponent<UISprite>();
		m_add12 = parts_add12.GetComponent<UISprite>();
		m_add13 = parts_add13.GetComponent<UISprite>();
		m_num1 = parts_num1.GetComponent<UISprite>();
		m_num2 = parts_num2.GetComponent<UISprite>();
		setPositionZ(0, 0f);
		setPositionZ(1, 0f);
		setPositionZ(2, 0f);
		setPositionZ(3, 0f);
		setPositionZ(4, 0f);
		setPositionZ(5, 0f);
		setPositionZ(6, 0f);
		setPositionZ(7, 0f);
		setPositionZ(8, 0f);
		setPositionZ(9, 0f);
		parts_base.SetActiveRecursively(false);
		parts_side_r.SetActiveRecursively(false);
		parts_side_l.SetActiveRecursively(false);
		parts_add.SetActiveRecursively(false);
		parts_add10.SetActiveRecursively(false);
		parts_add11.SetActiveRecursively(false);
		parts_add12.SetActiveRecursively(false);
		parts_add13.SetActiveRecursively(false);
		parts_num1.SetActiveRecursively(false);
		parts_num2.SetActiveRecursively(false);
		for (num = 0; num < 10; num++)
		{
			m_state[num] = STATE._DISA;
			m_frame[num] = 0;
			m_active[num] = false;
		}
	}

	public void Update()
	{
		int num = 0;
		for (num = 0; num < 10; num++)
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
				if (m_frame[num] >= 6)
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
					m_add10.alpha = (float)(m_frame[num] % 80) / 80f;
					m_add11.alpha = (float)(m_frame[num] % 80) / 80f;
					m_add12.alpha = (float)(m_frame[num] % 80) / 80f;
					m_add13.alpha = (float)(m_frame[num] % 80) / 80f;
				}
				else
				{
					m_add10.alpha = (float)(80 - m_frame[num] % 80) / 80f;
					m_add11.alpha = (float)(80 - m_frame[num] % 80) / 80f;
					m_add12.alpha = (float)(80 - m_frame[num] % 80) / 80f;
					m_add13.alpha = (float)(80 - m_frame[num] % 80) / 80f;
				}
				break;
			case STATE._END:
				setPositionY(2, getDefPosY(2) - (float)m_frame[num] * 3f);
				setPositionX(0, getDefPosY(0) + (float)m_frame[num] * 1f);
				setPositionX(1, getDefPosY(1) - (float)m_frame[num] * 1f);
				setPositionY(8, getDefPosY(8) - (float)m_frame[num] * 3f);
				setPositionY(9, getDefPosY(9) - (float)m_frame[num] * 3f);
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
		setVisible(2, true);
		setVisible(0, true);
		setVisible(1, true);
		setVisible(3, true);
		setVisible(4, true);
		setVisible(5, true);
		setVisible(6, true);
		setVisible(7, true);
		setVisible(8, true);
		setVisible(9, true);
	}

	public void allDisable()
	{
		setVisible(2, false);
		setVisible(0, false);
		setVisible(1, false);
		setVisible(3, false);
		setVisible(4, false);
		setVisible(5, false);
		setVisible(6, false);
		setVisible(7, false);
		setVisible(8, false);
		setVisible(9, false);
	}

	public void baseEnable()
	{
		setVisible(2, true);
		setVisible(0, true);
		setVisible(1, true);
		setVisible(3, true);
		setVisible(4, true);
		setVisible(5, true);
		setVisible(6, true);
		setVisible(8, true);
		setVisible(9, true);
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
		string[] array = new string[10] { "9602_o_u_a_31", "9602_o_u_a_32", "9602_o_u_a_33", "9602_o_u_a_34", "9602_o_u_a_05", "9602_o_u_a_36", "9602_o_u_a_37", "9602_o_u_a_38", "9602_o_u_a_39", "9602_o_u_a_40" };
		m_track = _track;
		int num = m_track % 10;
		int num2 = m_track / 10;
		m_num1.spriteName = array[num];
		m_num2.spriteName = array[num2];
		if (num2 == 0)
		{
			endObject(9);
		}
		else
		{
			startObject(9);
		}
	}

	public GameObject getobj(int _kind)
	{
		switch (_kind)
		{
		case 0:
			return parts_side_r;
		case 1:
			return parts_side_l;
		case 2:
			return parts_base;
		case 3:
			return parts_add;
		case 4:
			return parts_add10;
		case 5:
			return parts_add11;
		case 6:
			return parts_add12;
		case 7:
			return parts_add13;
		case 8:
			return parts_num1;
		case 9:
			return parts_num2;
		default:
			return null;
		}
	}

	public float getDefPosX(int _kind)
	{
		float[] array = new float[10] { 247.04f, 8.96f, 128f, 128f, 128f, 128f, 128f, 128f, 245f, 239.44f };
		return array[_kind];
	}

	public float getDefPosY(int _kind)
	{
		float[] array = new float[10] { -69.76f, -69.76f, -132.48f, -72.96f, -69f, -132.5f, -70f, -45.5f, -130f, -129.92f };
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
