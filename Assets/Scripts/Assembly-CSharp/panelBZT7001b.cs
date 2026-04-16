using UnityEngine;

public class panelBZT7001b
{
	private enum KIND
	{
		_TOTAL_NUM4 = 0,
		_TOTAL_NUM3 = 1,
		_TOTAL_NUM2 = 2,
		_TOTAL_NUM1 = 3,
		_GET_NUM4 = 4,
		_GET_NUM3 = 5,
		_GET_NUM2 = 6,
		_GET_NUM1 = 7,
		_MAX = 8
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

	public const float DEF_POSX_TOTAL_NUM4 = 128f;

	public const float DEF_POSX_TOTAL_NUM3 = 147.2f;

	public const float DEF_POSX_TOTAL_NUM2 = 166.4f;

	public const float DEF_POSX_TOTAL_NUM1 = 185.6f;

	public const float DEF_POSX_GET_NUM4 = 128f;

	public const float DEF_POSX_GET_NUM3 = 147.2f;

	public const float DEF_POSX_GET_NUM2 = 166.4f;

	public const float DEF_POSX_GET_NUM1 = 185.6f;

	public const float DEF_POSY_TOTAL_NUM4 = -95.04f;

	public const float DEF_POSY_TOTAL_NUM3 = -95.04f;

	public const float DEF_POSY_TOTAL_NUM2 = -95.04f;

	public const float DEF_POSY_TOTAL_NUM1 = -95.04f;

	public const float DEF_POSY_GET_NUM4 = -117.44f;

	public const float DEF_POSY_GET_NUM3 = -117.44f;

	public const float DEF_POSY_GET_NUM2 = -117.44f;

	public const float DEF_POSY_GET_NUM1 = -117.44f;

	public const float DEF_POSZ_TOTAL_NUM4 = 0f;

	public const float DEF_POSZ_TOTAL_NUM3 = 0f;

	public const float DEF_POSZ_TOTAL_NUM2 = 0f;

	public const float DEF_POSZ_TOTAL_NUM1 = 0f;

	public const float DEF_POSZ_GET_NUM4 = 0f;

	public const float DEF_POSZ_GET_NUM3 = 0f;

	public const float DEF_POSZ_GET_NUM2 = 0f;

	public const float DEF_POSZ_GET_NUM1 = 0f;

	private GameObject parts_total_num4;

	private GameObject parts_total_num3;

	private GameObject parts_total_num2;

	private GameObject parts_total_num1;

	private GameObject parts_get_num4;

	private GameObject parts_get_num3;

	private GameObject parts_get_num2;

	private GameObject parts_get_num1;

	private UISprite m_total_num4;

	private UISprite m_total_num3;

	private UISprite m_total_num2;

	private UISprite m_total_num1;

	private UISprite m_get_num4;

	private UISprite m_get_num3;

	private UISprite m_get_num2;

	private UISprite m_get_num1;

	private STATE[] m_state = new STATE[8];

	private int[] m_frame = new int[8];

	private bool[] m_active = new bool[8];

	private int m_total;

	private int m_get;

	public void release()
	{
		parts_total_num4 = null;
		parts_total_num3 = null;
		parts_total_num2 = null;
		parts_total_num1 = null;
		parts_get_num4 = null;
		parts_get_num3 = null;
		parts_get_num2 = null;
		parts_get_num1 = null;
		m_total_num4 = null;
		m_total_num3 = null;
		m_total_num2 = null;
		m_total_num1 = null;
		m_get_num4 = null;
		m_get_num3 = null;
		m_get_num2 = null;
		m_get_num1 = null;
	}

	public void init()
	{
		int num = 0;
		parts_total_num4 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_BZT7001B/012");
		parts_total_num3 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_BZT7001B/013");
		parts_total_num2 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_BZT7001B/014");
		parts_total_num1 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_BZT7001B/015");
		parts_get_num4 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_BZT7001B/018");
		parts_get_num3 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_BZT7001B/019");
		parts_get_num2 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_BZT7001B/020");
		parts_get_num1 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_BZT7001B/021");
		m_total_num4 = parts_total_num4.GetComponent<UISprite>();
		m_total_num3 = parts_total_num3.GetComponent<UISprite>();
		m_total_num2 = parts_total_num2.GetComponent<UISprite>();
		m_total_num1 = parts_total_num1.GetComponent<UISprite>();
		m_get_num4 = parts_get_num4.GetComponent<UISprite>();
		m_get_num3 = parts_get_num3.GetComponent<UISprite>();
		m_get_num2 = parts_get_num2.GetComponent<UISprite>();
		m_get_num1 = parts_get_num1.GetComponent<UISprite>();
		setPositionZ(0, 0f);
		setPositionZ(1, 0f);
		setPositionZ(2, 0f);
		setPositionZ(3, 0f);
		setPositionZ(4, 0f);
		setPositionZ(5, 0f);
		setPositionZ(6, 0f);
		setPositionZ(7, 0f);
		for (num = 0; num < 8; num++)
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
		for (num = 0; num < 8; num++)
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
		for (num = 0; num < 8; num++)
		{
			setVisible(num, true);
		}
	}

	public void allDisable()
	{
		int num = 0;
		for (num = 0; num < 8; num++)
		{
			setVisible(num, false);
		}
	}

	public void baseEnable()
	{
		int num = 0;
		for (num = 0; num < 8; num++)
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

	public void dispTotal()
	{
		setVisible(0, true);
		setVisible(1, true);
		setVisible(2, true);
		setVisible(3, true);
	}

	public void dispGet()
	{
		setVisible(4, true);
		setVisible(5, true);
		setVisible(6, true);
		setVisible(7, true);
	}

	public void setTotal(int _num)
	{
		string[] array = new string[10] { "74F10_u_l_b00", "74F10_u_l_b01", "74F10_u_l_b02", "74F10_u_l_b03", "74F10_u_l_b04", "74F10_u_l_b05", "74F10_u_l_b06", "74F10_u_l_b07", "74F10_u_l_b08", "74F10_u_l_b09" };
		m_total = _num;
		int num = m_total % 10;
		int num2 = m_total / 10 % 10;
		int num3 = m_total / 100 % 10;
		int num4 = m_total / 1000;
		m_total_num1.spriteName = array[num];
		m_total_num2.spriteName = array[num2];
		m_total_num3.spriteName = array[num3];
		m_total_num4.spriteName = array[num4];
		if (num2 == 0 && num3 == 0 && num4 == 0)
		{
			endObject(2);
		}
		if (num3 == 0 && num4 == 0)
		{
			endObject(1);
		}
		if (num4 == 0)
		{
			endObject(0);
		}
	}

	public void setGet(int _num)
	{
		string[] array = new string[10] { "74F10_u_l_b00", "74F10_u_l_b01", "74F10_u_l_b02", "74F10_u_l_b03", "74F10_u_l_b04", "74F10_u_l_b05", "74F10_u_l_b06", "74F10_u_l_b07", "74F10_u_l_b08", "74F10_u_l_b09" };
		m_get = _num;
		int num = m_get % 10;
		int num2 = m_get / 10 % 10;
		int num3 = m_get / 100 % 10;
		int num4 = m_get / 1000;
		m_get_num1.spriteName = array[num];
		m_get_num2.spriteName = array[num2];
		m_get_num3.spriteName = array[num3];
		m_get_num4.spriteName = array[num4];
		if (num2 == 0 && num3 == 0 && num4 == 0)
		{
			endObject(6);
		}
		if (num3 == 0 && num4 == 0)
		{
			endObject(5);
		}
		if (num4 == 0)
		{
			endObject(4);
		}
	}

	public GameObject getobj(int _kind)
	{
		switch (_kind)
		{
		case 0:
			return parts_total_num4;
		case 1:
			return parts_total_num3;
		case 2:
			return parts_total_num2;
		case 3:
			return parts_total_num1;
		case 4:
			return parts_get_num4;
		case 5:
			return parts_get_num3;
		case 6:
			return parts_get_num2;
		case 7:
			return parts_get_num1;
		default:
			return null;
		}
	}

	public float getDefPosX(int _kind)
	{
		float[] array = new float[8] { 128f, 147.2f, 166.4f, 185.6f, 128f, 147.2f, 166.4f, 185.6f };
		return array[_kind];
	}

	public float getDefPosY(int _kind)
	{
		float[] array = new float[8] { -95.04f, -95.04f, -95.04f, -95.04f, -117.44f, -117.44f, -117.44f, -117.44f };
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
