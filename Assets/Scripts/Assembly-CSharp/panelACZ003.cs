using UnityEngine;

public class panelACZ003
{
	private enum KIND
	{
		_BASE = 0,
		_4TH = 1,
		_3RD = 2,
		_2ND = 3,
		_ADD11 = 4,
		_ADD21 = 5,
		_ADD12 = 6,
		_ADD22 = 7,
		_NUM3 = 8,
		_NUM2 = 9,
		_NUM1 = 10,
		_MAX = 11
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

	public const float DEF_POSX_BASE = 128f;

	public const float DEF_POSX_4TH = 37.12f;

	public const float DEF_POSX_3RD = 37.12f;

	public const float DEF_POSX_2ND = 37.12f;

	public const float DEF_POSX_ADD11 = 37.12f;

	public const float DEF_POSX_ADD12 = 128f;

	public const float DEF_POSX_ADD21 = 37.12f;

	public const float DEF_POSX_ADD22 = 128f;

	public const float DEF_POSX_NUM3 = 235.2f;

	public const float DEF_POSX_NUM2 = 241.28f;

	public const float DEF_POSX_NUM1 = 247.36f;

	public const float DEF_POSY_BASE = -132.48f;

	public const float DEF_POSY_4TH = -132.48f;

	public const float DEF_POSY_3RD = -132.48f;

	public const float DEF_POSY_2ND = -132.48f;

	public const float DEF_POSY_ADD11 = -132.48f;

	public const float DEF_POSY_ADD12 = -132.48f;

	public const float DEF_POSY_ADD21 = -132.48f;

	public const float DEF_POSY_ADD22 = -132.48f;

	public const float DEF_POSY_NUM3 = -129.92f;

	public const float DEF_POSY_NUM2 = -129.92f;

	public const float DEF_POSY_NUM1 = -129.92f;

	public const float DEF_POSZ_BASE = 0.03f;

	public const float DEF_POSZ_4TH = 0.03f;

	public const float DEF_POSZ_3RD = 0.03f;

	public const float DEF_POSZ_2ND = 0.03f;

	public const float DEF_POSZ_ADD11 = 0.03f;

	public const float DEF_POSZ_ADD12 = 0.03f;

	public const float DEF_POSZ_ADD21 = 0.03f;

	public const float DEF_POSZ_ADD22 = 0.03f;

	public const float DEF_POSZ_NUM3 = 0.03f;

	public const float DEF_POSZ_NUM2 = 0.03f;

	public const float DEF_POSZ_NUM1 = 0.03f;

	public const float MOV_POSX_BASE = 0f;

	public const float MOV_POSX_4TH = 0f;

	public const float MOV_POSX_3RD = 0f;

	public const float MOV_POSX_2ND = 0f;

	public const float MOV_POSX_ADD11 = 0f;

	public const float MOV_POSX_ADD12 = 0f;

	public const float MOV_POSX_ADD21 = 0f;

	public const float MOV_POSX_ADD22 = 0f;

	public const float MOV_POSX_NUM3 = 0f;

	public const float MOV_POSX_NUM2 = 0f;

	public const float MOV_POSX_NUM1 = 0f;

	public const float MOV_POSY_BASE = 3f;

	public const float MOV_POSY_4TH = 3f;

	public const float MOV_POSY_3RD = 3f;

	public const float MOV_POSY_2ND = 3f;

	public const float MOV_POSY_ADD11 = 3f;

	public const float MOV_POSY_ADD12 = 3f;

	public const float MOV_POSY_ADD21 = 3f;

	public const float MOV_POSY_ADD22 = 3f;

	public const float MOV_POSY_NUM3 = 3f;

	public const float MOV_POSY_NUM2 = 3f;

	public const float MOV_POSY_NUM1 = 3f;

	private GameObject parts_base;

	private GameObject parts_4th;

	private GameObject parts_3rd;

	private GameObject parts_2nd;

	private GameObject parts_add11;

	private GameObject parts_add12;

	private GameObject parts_add21;

	private GameObject parts_add22;

	private GameObject parts_num3;

	private GameObject parts_num2;

	private GameObject parts_num1;

	private UISprite m_add11;

	private UISprite m_add12;

	private UISprite m_add21;

	private UISprite m_add22;

	private UISprite m_num1;

	private UISprite m_num2;

	private UISprite m_num3;

	private STATE[] m_state = new STATE[11];

	private int[] m_frame = new int[11];

	private bool[] m_active = new bool[11];

	private int m_game;

	public void release()
	{
		parts_base = null;
		parts_4th = null;
		parts_3rd = null;
		parts_2nd = null;
		parts_add11 = null;
		parts_add12 = null;
		parts_add21 = null;
		parts_add22 = null;
		parts_num3 = null;
		parts_num2 = null;
		parts_num1 = null;
		m_add11 = null;
		m_add12 = null;
		m_add21 = null;
		m_add22 = null;
		m_num1 = null;
		m_num2 = null;
		m_num3 = null;
	}

	public void init()
	{
		int num = 0;
		parts_base = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ003/002");
		parts_4th = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ003/005");
		parts_3rd = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ003/006");
		parts_2nd = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ003/007");
		parts_add11 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ003/012");
		parts_add12 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ003/013");
		parts_add21 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ003/014");
		parts_add22 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ003/015");
		parts_num3 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ003/018");
		parts_num2 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ003/019");
		parts_num1 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_ACZ003/020");
		m_add11 = parts_add11.GetComponent<UISprite>();
		m_add12 = parts_add12.GetComponent<UISprite>();
		m_add21 = parts_add21.GetComponent<UISprite>();
		m_add22 = parts_add22.GetComponent<UISprite>();
		m_num1 = parts_num1.GetComponent<UISprite>();
		m_num2 = parts_num2.GetComponent<UISprite>();
		m_num3 = parts_num3.GetComponent<UISprite>();
		setPositionZ(0, 0.03f);
		setPositionZ(1, 0.03f);
		setPositionZ(2, 0.03f);
		setPositionZ(3, 0.03f);
		setPositionZ(4, 0.03f);
		setPositionZ(5, 0.03f);
		setPositionZ(6, 0.03f);
		setPositionZ(7, 0.03f);
		setPositionZ(8, 0.03f);
		setPositionZ(9, 0.03f);
		setPositionZ(10, 0.03f);
		parts_base.SetActiveRecursively(false);
		parts_4th.SetActiveRecursively(false);
		parts_3rd.SetActiveRecursively(false);
		parts_2nd.SetActiveRecursively(false);
		parts_add11.SetActiveRecursively(false);
		parts_add12.SetActiveRecursively(false);
		parts_add21.SetActiveRecursively(false);
		parts_add22.SetActiveRecursively(false);
		parts_num3.SetActiveRecursively(false);
		parts_num2.SetActiveRecursively(false);
		parts_num1.SetActiveRecursively(false);
		for (num = 0; num < 11; num++)
		{
			m_state[num] = STATE._DISA;
			m_frame[num] = 0;
			m_active[num] = false;
		}
	}

	public void Update()
	{
		int num = 0;
		for (num = 0; num < 11; num++)
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
					m_add11.alpha = (float)(m_frame[num] % 80) / 80f;
					m_add12.alpha = (float)(m_frame[num] % 80) / 80f;
				}
				else
				{
					m_add11.alpha = (float)(80 - m_frame[num] % 80) / 80f;
					m_add12.alpha = (float)(80 - m_frame[num] % 80) / 80f;
				}
				break;
			case STATE._END:
				setPositionY(0, getDefPosY(0) - (float)m_frame[num] * 3f);
				setPositionY(2, getDefPosY(2) - (float)m_frame[num] * 3f);
				setPositionY(4, getDefPosY(4) - (float)m_frame[num] * 3f);
				setPositionY(6, getDefPosY(6) - (float)m_frame[num] * 3f);
				setPositionY(8, getDefPosY(8) - (float)m_frame[num] * 3f);
				setPositionY(9, getDefPosY(9) - (float)m_frame[num] * 3f);
				setPositionY(10, getDefPosY(10) - (float)m_frame[num] * 3f);
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
		setVisible(7, true);
		setVisible(8, true);
		setVisible(9, true);
		setVisible(10, true);
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
		setVisible(7, false);
		setVisible(8, false);
		setVisible(9, false);
		setVisible(10, false);
	}

	public void baseEnable()
	{
		setVisible(0, true);
		setVisible(2, true);
		setVisible(1, true);
		setVisible(4, true);
		setVisible(6, true);
		setVisible(8, true);
		setVisible(9, true);
		setVisible(10, true);
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

	public void setGame(int _game)
	{
		string[] array = new string[10] { "07A02_o_u_h_10a", "07A02_o_u_h_01a", "07A02_o_u_h_02a", "07A02_o_u_h_03a", "07A02_o_u_h_04a", "07A02_o_u_h_05a", "07A02_o_u_h_06a", "07A02_o_u_h_07a", "07A02_o_u_h_08a", "07A02_o_u_h_09a" };
		m_game = _game;
		int num = m_game % 10;
		int num2 = m_game / 10 % 10;
		int num3 = m_game / 100;
		m_num1.spriteName = array[num];
		m_num2.spriteName = array[num2];
		m_num3.spriteName = array[num3];
		if (num2 == 0 && num3 == 0)
		{
			endObject(9);
		}
		else
		{
			startObject(9);
		}
		if (num3 == 0)
		{
			endObject(8);
		}
		else
		{
			startObject(8);
		}
	}

	public GameObject getobj(int _kind)
	{
		switch (_kind)
		{
		case 0:
			return parts_base;
		case 1:
			return parts_4th;
		case 2:
			return parts_3rd;
		case 3:
			return parts_2nd;
		case 4:
			return parts_add11;
		case 5:
			return parts_add21;
		case 6:
			return parts_add12;
		case 7:
			return parts_add22;
		case 8:
			return parts_num3;
		case 9:
			return parts_num2;
		case 10:
			return parts_num1;
		default:
			return null;
		}
	}

	public float getDefPosX(int _kind)
	{
		float[] array = new float[11]
		{
			128f, 37.12f, 37.12f, 37.12f, 37.12f, 37.12f, 128f, 128f, 235.2f, 241.28f,
			247.36f
		};
		return array[_kind];
	}

	public float getDefPosY(int _kind)
	{
		float[] array = new float[11]
		{
			-132.48f, -132.48f, -132.48f, -132.48f, -132.48f, -132.48f, -132.48f, -132.48f, -129.92f, -129.92f,
			-129.92f
		};
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
