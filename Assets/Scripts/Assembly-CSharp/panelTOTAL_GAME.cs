using UnityEngine;

public class panelTOTAL_GAME
{
	private enum KIND
	{
		_TOTAL = 0,
		_TOTAL_NUM4 = 1,
		_TOTAL_NUM3 = 2,
		_TOTAL_NUM2 = 3,
		_TOTAL_NUM1 = 4,
		_GET = 5,
		_GAME = 6,
		_PLUS1 = 7,
		_G1 = 8,
		_GET_NUM4 = 9,
		_GET_NUM3 = 10,
		_GET_NUM2 = 11,
		_GET_NUM1 = 12,
		_LAST = 13,
		_DIVISION1 = 14,
		_DIVISION2 = 15,
		_BATTLE = 16,
		_G2 = 17,
		_LAST_NUM4 = 18,
		_LAST_NUM3 = 19,
		_LAST_NUM2 = 20,
		_LAST_NUM1 = 21,
		_BB_NUM12 = 22,
		_BB_NUM11 = 23,
		_BB_NUM23 = 24,
		_BB_NUM22 = 25,
		_BB_NUM21 = 26,
		_PLUS2 = 27,
		_G3 = 28,
		_PLUS_NUM4 = 29,
		_PLUS_NUM3 = 30,
		_PLUS_NUM2 = 31,
		_PLUS_NUM1 = 32,
		_SLASH = 33,
		_X = 34,
		_SLASH_NUM2 = 35,
		_SLASH_NUM1 = 36,
		_JAC1 = 37,
		_JAC2 = 38,
		_MAX = 39
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

	public const float DEF_POSX_TOTAL = 28.8f;

	public const float DEF_POSX_TOTAL_NUM4 = 56.64f;

	public const float DEF_POSX_TOTAL_NUM3 = 64f;

	public const float DEF_POSX_TOTAL_NUM2 = 71.36f;

	public const float DEF_POSX_TOTAL_NUM1 = 78.72f;

	public const float DEF_POSX_GET = 153.28f;

	public const float DEF_POSX_GAME = 149.76f;

	public const float DEF_POSX_PLUS1 = 160f;

	public const float DEF_POSX_G1 = 208f;

	public const float DEF_POSX_GET_NUM4 = 177.28f;

	public const float DEF_POSX_GET_NUM3 = 184.64f;

	public const float DEF_POSX_GET_NUM2 = 192f;

	public const float DEF_POSX_GET_NUM1 = 199.36f;

	public const float DEF_POSX_LAST = 149.76f;

	public const float DEF_POSX_DIVISION1 = 184.64f;

	public const float DEF_POSX_DIVISION2 = 177.28f;

	public const float DEF_POSX_BATTLE = 143.68f;

	public const float DEF_POSX_G2 = 208f;

	public const float DEF_POSX_LAST_NUM4 = 177.28f;

	public const float DEF_POSX_LAST_NUM3 = 184.64f;

	public const float DEF_POSX_LAST_NUM2 = 192f;

	public const float DEF_POSX_LAST_NUM1 = 199.36f;

	public const float DEF_POSX_BB_NUM12 = 169.92f;

	public const float DEF_POSX_BB_NUM11 = 177.28f;

	public const float DEF_POSX_BB_NUM23 = 155.2f;

	public const float DEF_POSX_BB_NUM22 = 162.56f;

	public const float DEF_POSX_BB_NUM21 = 169.92f;

	public const float DEF_POSX_PLUS2 = 160f;

	public const float DEF_POSX_G3 = 208f;

	public const float DEF_POSX_PLUS_NUM4 = 177.28f;

	public const float DEF_POSX_PLUS_NUM3 = 184.64f;

	public const float DEF_POSX_PLUS_NUM2 = 192f;

	public const float DEF_POSX_PLUS_NUM1 = 199.36f;

	public const float DEF_POSX_SLASH = 38.08f;

	public const float DEF_POSX_X = 60.8f;

	public const float DEF_POSX_SLASH_NUM2 = 71.36f;

	public const float DEF_POSX_SLASH_NUM1 = 78.72f;

	public const float DEF_POSX_JAC1 = 189.76f;

	public const float DEF_POSX_JAC2 = 189.76f;

	public const float DEF_POSY_TOTAL = -8.96f;

	public const float DEF_POSY_TOTAL_NUM4 = -7.68f;

	public const float DEF_POSY_TOTAL_NUM3 = -7.68f;

	public const float DEF_POSY_TOTAL_NUM2 = -7.68f;

	public const float DEF_POSY_TOTAL_NUM1 = -7.68f;

	public const float DEF_POSY_GET = -8.96f;

	public const float DEF_POSY_GAME = -8.96f;

	public const float DEF_POSY_PLUS1 = -8.96f;

	public const float DEF_POSY_G1 = -8.96f;

	public const float DEF_POSY_GET_NUM4 = -7.68f;

	public const float DEF_POSY_GET_NUM3 = -7.68f;

	public const float DEF_POSY_GET_NUM2 = -7.68f;

	public const float DEF_POSY_GET_NUM1 = -7.68f;

	public const float DEF_POSY_LAST = -20.48f;

	public const float DEF_POSY_DIVISION1 = -19.52f;

	public const float DEF_POSY_DIVISION2 = -19.52f;

	public const float DEF_POSY_BATTLE = -20.48f;

	public const float DEF_POSY_G2 = -20.48f;

	public const float DEF_POSY_LAST_NUM4 = -19.2f;

	public const float DEF_POSY_LAST_NUM3 = -19.2f;

	public const float DEF_POSY_LAST_NUM2 = -19.2f;

	public const float DEF_POSY_LAST_NUM1 = -19.2f;

	public const float DEF_POSY_BB_NUM12 = -19.2f;

	public const float DEF_POSY_BB_NUM11 = -19.2f;

	public const float DEF_POSY_BB_NUM23 = -19.2f;

	public const float DEF_POSY_BB_NUM22 = -19.2f;

	public const float DEF_POSY_BB_NUM21 = -19.2f;

	public const float DEF_POSY_PLUS2 = -32f;

	public const float DEF_POSY_G3 = -32f;

	public const float DEF_POSY_PLUS_NUM4 = -30.72f;

	public const float DEF_POSY_PLUS_NUM3 = -30.72f;

	public const float DEF_POSY_PLUS_NUM2 = -30.72f;

	public const float DEF_POSY_PLUS_NUM1 = -30.72f;

	public const float DEF_POSY_SLASH = -32f;

	public const float DEF_POSY_X = -32f;

	public const float DEF_POSY_SLASH_NUM2 = -30.72f;

	public const float DEF_POSY_SLASH_NUM1 = -30.72f;

	public const float DEF_POSY_JAC1 = -17.92f;

	public const float DEF_POSY_JAC2 = -13.44f;

	public const float DEF_POSZ_TOTAL = 0f;

	public const float DEF_POSZ_TOTAL_NUM4 = 0f;

	public const float DEF_POSZ_TOTAL_NUM3 = 0f;

	public const float DEF_POSZ_TOTAL_NUM2 = 0f;

	public const float DEF_POSZ_TOTAL_NUM1 = 0f;

	public const float DEF_POSZ_GET = 0f;

	public const float DEF_POSZ_GAME = 0f;

	public const float DEF_POSZ_PLUS1 = 0f;

	public const float DEF_POSZ_G1 = 0f;

	public const float DEF_POSZ_GET_NUM4 = 0f;

	public const float DEF_POSZ_GET_NUM3 = 0f;

	public const float DEF_POSZ_GET_NUM2 = 0f;

	public const float DEF_POSZ_GET_NUM1 = 0f;

	public const float DEF_POSZ_LAST = 0f;

	public const float DEF_POSZ_DIVISION1 = 0f;

	public const float DEF_POSZ_DIVISION2 = 0f;

	public const float DEF_POSZ_BATTLE = 0f;

	public const float DEF_POSZ_G2 = 0f;

	public const float DEF_POSZ_LAST_NUM4 = 0f;

	public const float DEF_POSZ_LAST_NUM3 = 0f;

	public const float DEF_POSZ_LAST_NUM2 = 0f;

	public const float DEF_POSZ_LAST_NUM1 = 0f;

	public const float DEF_POSZ_BB_NUM12 = 0f;

	public const float DEF_POSZ_BB_NUM11 = 0f;

	public const float DEF_POSZ_BB_NUM23 = 0f;

	public const float DEF_POSZ_BB_NUM22 = 0f;

	public const float DEF_POSZ_BB_NUM21 = 0f;

	public const float DEF_POSZ_PLUS2 = 0f;

	public const float DEF_POSZ_G3 = 0f;

	public const float DEF_POSZ_PLUS_NUM4 = 0f;

	public const float DEF_POSZ_PLUS_NUM3 = 0f;

	public const float DEF_POSZ_PLUS_NUM2 = 0f;

	public const float DEF_POSZ_PLUS_NUM1 = 0f;

	public const float DEF_POSZ_SLASH = 0f;

	public const float DEF_POSZ_X = 0f;

	public const float DEF_POSZ_SLASH_NUM2 = 0f;

	public const float DEF_POSZ_SLASH_NUM1 = 0f;

	public const float DEF_POSZ_JAC1 = 0f;

	public const float DEF_POSZ_JAC2 = 0f;

	private string[] nameTbl = new string[10] { "07A02_o_u_h_10a", "07A02_o_u_h_01a", "07A02_o_u_h_02a", "07A02_o_u_h_03a", "07A02_o_u_h_04a", "07A02_o_u_h_05a", "07A02_o_u_h_06a", "07A02_o_u_h_07a", "07A02_o_u_h_08a", "07A02_o_u_h_09a" };

	private GameObject parts_total;

	private GameObject parts_total_num4;

	private GameObject parts_total_num3;

	private GameObject parts_total_num2;

	private GameObject parts_total_num1;

	private GameObject parts_get;

	private GameObject parts_game;

	private GameObject parts_plus1;

	private GameObject parts_g1;

	private GameObject parts_get_num4;

	private GameObject parts_get_num3;

	private GameObject parts_get_num2;

	private GameObject parts_get_num1;

	private GameObject parts_last;

	private GameObject parts_division1;

	private GameObject parts_division2;

	private GameObject parts_battle;

	private GameObject parts_g2;

	private GameObject parts_last_num4;

	private GameObject parts_last_num3;

	private GameObject parts_last_num2;

	private GameObject parts_last_num1;

	private GameObject parts_bb_num12;

	private GameObject parts_bb_num11;

	private GameObject parts_bb_num23;

	private GameObject parts_bb_num22;

	private GameObject parts_bb_num21;

	private GameObject parts_plus2;

	private GameObject parts_g3;

	private GameObject parts_plus_num4;

	private GameObject parts_plus_num3;

	private GameObject parts_plus_num2;

	private GameObject parts_plus_num1;

	private GameObject parts_slash;

	private GameObject parts_x;

	private GameObject parts_slash_num2;

	private GameObject parts_slash_num1;

	private GameObject parts_jac1;

	private GameObject parts_jac2;

	private UISprite m_total_num4;

	private UISprite m_total_num3;

	private UISprite m_total_num2;

	private UISprite m_total_num1;

	private UISprite m_get_num4;

	private UISprite m_get_num3;

	private UISprite m_get_num2;

	private UISprite m_get_num1;

	private UISprite m_last_num4;

	private UISprite m_last_num3;

	private UISprite m_last_num2;

	private UISprite m_last_num1;

	private UISprite m_bb_num12;

	private UISprite m_bb_num11;

	private UISprite m_bb_num23;

	private UISprite m_bb_num22;

	private UISprite m_bb_num21;

	private UISprite m_plus_num4;

	private UISprite m_plus_num3;

	private UISprite m_plus_num2;

	private UISprite m_plus_num1;

	private UISprite m_slash_num2;

	private UISprite m_slash_num1;

	private STATE[] m_state = new STATE[39];

	private int[] m_frame = new int[39];

	private bool[] m_active = new bool[39];

	public void release()
	{
		parts_total = null;
		parts_total_num4 = null;
		parts_total_num3 = null;
		parts_total_num2 = null;
		parts_total_num1 = null;
		parts_get = null;
		parts_game = null;
		parts_plus1 = null;
		parts_g1 = null;
		parts_get_num4 = null;
		parts_get_num3 = null;
		parts_get_num2 = null;
		parts_get_num1 = null;
		parts_last = null;
		parts_division1 = null;
		parts_division2 = null;
		parts_battle = null;
		parts_g2 = null;
		parts_last_num4 = null;
		parts_last_num3 = null;
		parts_last_num2 = null;
		parts_last_num1 = null;
		parts_bb_num12 = null;
		parts_bb_num11 = null;
		parts_bb_num23 = null;
		parts_bb_num22 = null;
		parts_bb_num21 = null;
		parts_plus2 = null;
		parts_g3 = null;
		parts_plus_num4 = null;
		parts_plus_num3 = null;
		parts_plus_num2 = null;
		parts_plus_num1 = null;
		parts_slash = null;
		parts_x = null;
		parts_slash_num2 = null;
		parts_slash_num1 = null;
		parts_jac1 = null;
		parts_jac2 = null;
		m_total_num4 = null;
		m_total_num3 = null;
		m_total_num2 = null;
		m_total_num1 = null;
		m_get_num4 = null;
		m_get_num3 = null;
		m_get_num2 = null;
		m_get_num1 = null;
		m_last_num4 = null;
		m_last_num3 = null;
		m_last_num2 = null;
		m_last_num1 = null;
		m_bb_num12 = null;
		m_bb_num11 = null;
		m_bb_num23 = null;
		m_bb_num22 = null;
		m_bb_num21 = null;
		m_plus_num4 = null;
		m_plus_num3 = null;
		m_plus_num2 = null;
		m_plus_num1 = null;
		m_slash_num2 = null;
		m_slash_num1 = null;
	}

	public void init()
	{
		int num = 0;
		parts_total = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/001");
		parts_total_num4 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/003");
		parts_total_num3 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/004");
		parts_total_num2 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/005");
		parts_total_num1 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/006");
		parts_get = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/009");
		parts_game = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/010");
		parts_plus1 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/011");
		parts_g1 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/012");
		parts_get_num4 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/014");
		parts_get_num3 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/015");
		parts_get_num2 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/016");
		parts_get_num1 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/017");
		parts_last = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/020");
		parts_division1 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/021");
		parts_division2 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/022");
		parts_battle = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/023");
		parts_g2 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/024");
		parts_last_num4 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/026");
		parts_last_num3 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/027");
		parts_last_num2 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/028");
		parts_last_num1 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/029");
		parts_bb_num12 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/031");
		parts_bb_num11 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/032");
		parts_bb_num23 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/034");
		parts_bb_num22 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/035");
		parts_bb_num21 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/036");
		parts_plus2 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/039");
		parts_g3 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/040");
		parts_plus_num4 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/042");
		parts_plus_num3 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/043");
		parts_plus_num2 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/044");
		parts_plus_num1 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/045");
		parts_slash = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/048");
		parts_x = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/049");
		parts_slash_num2 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/050");
		parts_slash_num1 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/051");
		parts_jac1 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/055");
		parts_jac2 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_TOTAL_GAME/056");
		m_total_num4 = parts_total_num4.GetComponent<UISprite>();
		m_total_num3 = parts_total_num3.GetComponent<UISprite>();
		m_total_num2 = parts_total_num2.GetComponent<UISprite>();
		m_total_num1 = parts_total_num1.GetComponent<UISprite>();
		m_get_num4 = parts_get_num4.GetComponent<UISprite>();
		m_get_num3 = parts_get_num3.GetComponent<UISprite>();
		m_get_num2 = parts_get_num2.GetComponent<UISprite>();
		m_get_num1 = parts_get_num1.GetComponent<UISprite>();
		m_last_num4 = parts_last_num4.GetComponent<UISprite>();
		m_last_num3 = parts_last_num3.GetComponent<UISprite>();
		m_last_num2 = parts_last_num2.GetComponent<UISprite>();
		m_last_num1 = parts_last_num1.GetComponent<UISprite>();
		m_bb_num12 = parts_bb_num12.GetComponent<UISprite>();
		m_bb_num11 = parts_bb_num11.GetComponent<UISprite>();
		m_bb_num23 = parts_bb_num23.GetComponent<UISprite>();
		m_bb_num22 = parts_bb_num22.GetComponent<UISprite>();
		m_bb_num21 = parts_bb_num21.GetComponent<UISprite>();
		m_plus_num4 = parts_plus_num4.GetComponent<UISprite>();
		m_plus_num3 = parts_plus_num3.GetComponent<UISprite>();
		m_plus_num2 = parts_plus_num2.GetComponent<UISprite>();
		m_plus_num1 = parts_plus_num1.GetComponent<UISprite>();
		m_slash_num2 = parts_slash_num2.GetComponent<UISprite>();
		m_slash_num1 = parts_slash_num1.GetComponent<UISprite>();
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
		setPositionZ(10, 0f);
		setPositionZ(11, 0f);
		setPositionZ(12, 0f);
		setPositionZ(13, 0f);
		setPositionZ(14, 0f);
		setPositionZ(15, 0f);
		setPositionZ(16, 0f);
		setPositionZ(17, 0f);
		setPositionZ(18, 0f);
		setPositionZ(19, 0f);
		setPositionZ(20, 0f);
		setPositionZ(21, 0f);
		setPositionZ(22, 0f);
		setPositionZ(23, 0f);
		setPositionZ(24, 0f);
		setPositionZ(25, 0f);
		setPositionZ(26, 0f);
		setPositionZ(27, 0f);
		setPositionZ(28, 0f);
		setPositionZ(29, 0f);
		setPositionZ(30, 0f);
		setPositionZ(31, 0f);
		setPositionZ(32, 0f);
		setPositionZ(33, 0f);
		setPositionZ(34, 0f);
		setPositionZ(35, 0f);
		setPositionZ(36, 0f);
		setPositionZ(37, 0f);
		setPositionZ(38, 0f);
		for (num = 0; num < 39; num++)
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
		for (num = 0; num < 39; num++)
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
		for (num = 0; num < 39; num++)
		{
			setVisible(num, true);
		}
	}

	public void allDisable()
	{
		int num = 0;
		for (num = 0; num < 39; num++)
		{
			setVisible(num, false);
		}
	}

	public void baseEnable()
	{
		int num = 0;
		for (num = 0; num < 39; num++)
		{
			setVisible(num, false);
		}
	}

	public void dispTotal()
	{
		setVisible(0, true);
		setVisible(1, true);
		setVisible(2, true);
		setVisible(3, true);
		setVisible(4, true);
	}

	public void dispGet()
	{
		setVisible(5, true);
		setVisible(9, true);
		setVisible(10, true);
		setVisible(11, true);
		setVisible(12, true);
	}

	public void dispGame()
	{
		setVisible(6, true);
		setVisible(8, true);
		setVisible(9, true);
		setVisible(10, true);
		setVisible(11, true);
		setVisible(12, true);
	}

	public void dispPlus1()
	{
		setVisible(7, true);
		setVisible(8, true);
		setVisible(9, true);
		setVisible(10, true);
		setVisible(11, true);
		setVisible(12, true);
	}

	public void dispLast()
	{
		setVisible(13, true);
		setVisible(17, true);
		setVisible(18, true);
		setVisible(19, true);
		setVisible(20, true);
		setVisible(21, true);
	}

	public void dispLastMedal()
	{
		setVisible(13, true);
		setVisible(18, true);
		setVisible(19, true);
		setVisible(20, true);
		setVisible(21, true);
	}

	public void dispGB()
	{
		setVisible(14, true);
		setVisible(17, true);
		setVisible(20, true);
		setVisible(21, true);
		setVisible(22, true);
		setVisible(23, true);
	}

	public void dispSGB()
	{
		setVisible(15, true);
		setVisible(17, true);
		setVisible(19, true);
		setVisible(20, true);
		setVisible(21, true);
		setVisible(24, true);
		setVisible(25, true);
		setVisible(26, true);
	}

	public void dispBattle()
	{
		setVisible(15, true);
		setVisible(16, true);
		setVisible(18, true);
		setVisible(19, true);
		setVisible(20, true);
		setVisible(21, true);
	}

	public void dispPlus2()
	{
		setVisible(27, true);
		setVisible(28, true);
		setVisible(29, true);
		setVisible(30, true);
		setVisible(31, true);
		setVisible(32, true);
	}

	public void dispSlash()
	{
		setVisible(33, true);
		setVisible(34, true);
		setVisible(35, true);
		setVisible(36, true);
	}

	public void dispJac1()
	{
		setVisible(37, true);
	}

	public void dispJac2()
	{
		setVisible(38, true);
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

	public void setBonusGet(int _num)
	{
		int num = _num;
		if (num < 0)
		{
			num = 0;
		}
		if (num > 9999)
		{
			num = 9999;
		}
		int num2 = num % 10;
		int num3 = num / 10 % 10;
		int num4 = num / 100 % 10;
		int num5 = num / 1000;
		m_get_num1.spriteName = nameTbl[num2];
		m_get_num2.spriteName = nameTbl[num3];
		m_get_num3.spriteName = nameTbl[num4];
		m_get_num4.spriteName = nameTbl[num5];
		if (num3 == 0 && num4 == 0 && num5 == 0)
		{
			endObject(11);
		}
		else
		{
			startObject(11);
		}
		if (num4 == 0 && num5 == 0)
		{
			endObject(10);
		}
		else
		{
			startObject(10);
		}
		if (num5 == 0)
		{
			endObject(9);
		}
		else
		{
			startObject(9);
		}
	}

	public void setBonusGameGB(int _num)
	{
		int num = _num;
		if (num < 0)
		{
			num = 0;
		}
		if (num > 99)
		{
			num = 99;
		}
		int num2 = num % 10;
		int num3 = num / 10;
		m_bb_num11.spriteName = nameTbl[num2];
		m_bb_num12.spriteName = nameTbl[num3];
		if (num3 == 0)
		{
			endObject(22);
		}
		else
		{
			startObject(22);
		}
	}

	public void setBonusGameSGB(int _num)
	{
		int num = _num;
		if (num < 0)
		{
			num = 0;
		}
		if (num > 999)
		{
			num = 999;
		}
		int num2 = num % 10;
		int num3 = num / 10 % 10;
		int num4 = num / 100;
		m_bb_num21.spriteName = nameTbl[num2];
		m_bb_num22.spriteName = nameTbl[num3];
		m_bb_num23.spriteName = nameTbl[num4];
		if (num4 == 0)
		{
			endObject(24);
		}
		else
		{
			startObject(24);
		}
		if (num3 == 0 && num4 == 0)
		{
			endObject(25);
		}
		else
		{
			startObject(25);
		}
	}

	public void setBonusMaxGame(int _num)
	{
		int num = _num;
		if (num < 0)
		{
			num = 0;
		}
		if (num > 999)
		{
			num = 999;
		}
		int num2 = num % 10;
		int num3 = num / 10 % 10;
		int num4 = num / 100;
		m_last_num1.spriteName = nameTbl[num2];
		m_last_num2.spriteName = nameTbl[num3];
		m_last_num3.spriteName = nameTbl[num4];
		if (num4 == 0)
		{
			endObject(19);
		}
		else
		{
			startObject(19);
		}
		if (num3 == 0 && num4 == 0)
		{
			endObject(20);
		}
		else
		{
			startObject(20);
		}
		setPositionX(15, 177f);
		setPositionX(18, 177f);
		setPositionX(19, 184f);
		setPositionX(20, 192f);
		setPositionX(21, 199f);
	}

	public void setBonusGetRemaining(int _num)
	{
		int num = _num;
		if (num < 0)
		{
			num = 0;
		}
		if (num > 9999)
		{
			num = 9999;
		}
		int num2 = num % 10;
		int num3 = num / 10 % 10;
		int num4 = num / 100 % 10;
		int num5 = num / 1000;
		m_last_num1.spriteName = nameTbl[num2];
		m_last_num2.spriteName = nameTbl[num3];
		m_last_num3.spriteName = nameTbl[num4];
		m_last_num4.spriteName = nameTbl[num5];
		if (num3 == 0 && num4 == 0 && num5 == 0)
		{
			endObject(20);
		}
		else
		{
			startObject(20);
		}
		if (num4 == 0 && num5 == 0)
		{
			endObject(19);
		}
		else
		{
			startObject(19);
		}
		if (num5 == 0)
		{
			endObject(18);
		}
		else
		{
			startObject(18);
		}
		setPositionX(15, 177f);
		setPositionX(18, 177f);
		setPositionX(19, 184f);
		setPositionX(20, 192f);
		setPositionX(21, 199f);
	}

	public void setTotalGet(int _num)
	{
		int num = _num;
		if (num < 0)
		{
			num = 0;
		}
		if (num > 9999)
		{
			num = 9999;
		}
		int num2 = num % 10;
		int num3 = num / 10 % 10;
		int num4 = num / 100 % 10;
		int num5 = num / 1000;
		m_total_num1.spriteName = nameTbl[num2];
		m_total_num2.spriteName = nameTbl[num3];
		m_total_num3.spriteName = nameTbl[num4];
		m_total_num4.spriteName = nameTbl[num5];
		if (num3 == 0 && num4 == 0 && num5 == 0)
		{
			endObject(3);
		}
		else
		{
			startObject(3);
		}
		if (num4 == 0 && num5 == 0)
		{
			endObject(2);
		}
		else
		{
			startObject(2);
		}
		if (num5 == 0)
		{
			endObject(1);
		}
		else
		{
			startObject(1);
		}
	}

	public void setRemainingGame(int _num)
	{
		int num = _num;
		if (num < 0)
		{
			num = 0;
		}
		if (num > 9999)
		{
			num = 9999;
		}
		int num2 = num % 10;
		int num3 = num / 10 % 10;
		int num4 = num / 100 % 10;
		int num5 = num / 1000;
		m_last_num1.spriteName = nameTbl[num2];
		m_last_num2.spriteName = nameTbl[num3];
		m_last_num3.spriteName = nameTbl[num4];
		m_last_num4.spriteName = nameTbl[num5];
		if (num3 == 0 && num4 == 0 && num5 == 0)
		{
			endObject(20);
		}
		else
		{
			startObject(20);
		}
		if (num4 == 0 && num5 == 0)
		{
			endObject(19);
		}
		else
		{
			startObject(19);
		}
		if (num5 == 0)
		{
			endObject(18);
		}
		else
		{
			startObject(18);
		}
	}

	public void setTotalGame(int _num)
	{
		int num = _num;
		if (num < 0)
		{
			num = 0;
		}
		if (num > 9999)
		{
			num = 9999;
		}
		int num2 = num % 10;
		int num3 = num / 10 % 10;
		int num4 = num / 100 % 10;
		int num5 = num / 1000;
		m_get_num1.spriteName = nameTbl[num2];
		m_get_num2.spriteName = nameTbl[num3];
		m_get_num3.spriteName = nameTbl[num4];
		m_get_num4.spriteName = nameTbl[num5];
		if (num3 == 0 && num4 == 0 && num5 == 0)
		{
			endObject(11);
		}
		else
		{
			startObject(11);
		}
		if (num4 == 0 && num5 == 0)
		{
			endObject(10);
		}
		else
		{
			startObject(10);
		}
		if (num5 == 0)
		{
			endObject(9);
		}
		else
		{
			startObject(9);
		}
	}

	public void setPlusGame(int _num)
	{
		int num = _num;
		if (num < 0)
		{
			num = 0;
		}
		if (num > 9999)
		{
			num = 9999;
		}
		int num2 = num % 10;
		int num3 = num / 10 % 10;
		int num4 = num / 100 % 10;
		int num5 = num / 1000;
		m_plus_num1.spriteName = nameTbl[num2];
		m_plus_num2.spriteName = nameTbl[num3];
		m_plus_num3.spriteName = nameTbl[num4];
		m_plus_num4.spriteName = nameTbl[num5];
		if (num3 == 0 && num4 == 0 && num5 == 0)
		{
			endObject(31);
		}
		else
		{
			startObject(31);
		}
		if (num4 == 0 && num5 == 0)
		{
			endObject(30);
		}
		else
		{
			startObject(30);
		}
		if (num5 == 0)
		{
			endObject(29);
		}
		else
		{
			startObject(29);
		}
	}

	public void setBAOTurn(int _num)
	{
		int num = _num;
		if (num < 0)
		{
			num = 0;
		}
		if (num > 9999)
		{
			num = 9999;
		}
		int num2 = 0;
		int num3 = 1;
		int num4 = num % 10;
		int num5 = num / 10 % 10;
		m_last_num1.spriteName = nameTbl[num2];
		m_last_num2.spriteName = nameTbl[num3];
		m_last_num3.spriteName = nameTbl[num4];
		m_last_num4.spriteName = nameTbl[num5];
		if (num5 == 0)
		{
			endObject(18);
		}
		else
		{
			startObject(18);
		}
		setPositionX(15, 192f);
		setPositionX(18, 177f);
		setPositionX(19, 184f);
		setPositionX(20, 199f);
		setPositionX(21, 206f);
	}

	public void setSlash(int _num)
	{
		int num = _num;
		if (num < 0)
		{
			num = 0;
		}
		if (num > 99)
		{
			num = 99;
		}
		int num2 = num % 10;
		int num3 = num / 10;
		m_slash_num1.spriteName = nameTbl[num2];
		m_slash_num2.spriteName = nameTbl[num3];
		if (num3 == 0)
		{
			endObject(35);
		}
		else
		{
			startObject(20);
		}
	}

	public void setJacIn1(bool flag)
	{
		int kind = 37;
		if (flag)
		{
			getobj(kind).SetActiveRecursively(true);
			getobj(kind).transform.localPosition = new Vector3(getDefPosX(kind), getDefPosY(kind), getobj(kind).transform.localPosition.z);
		}
		else
		{
			getobj(kind).SetActiveRecursively(false);
		}
	}

	public void setJacIn2(bool flag)
	{
		int kind = 38;
		if (flag)
		{
			getobj(kind).SetActiveRecursively(true);
			getobj(kind).transform.localPosition = new Vector3(getDefPosX(kind), getDefPosY(kind), getobj(kind).transform.localPosition.z);
		}
		else
		{
			getobj(kind).SetActiveRecursively(false);
		}
	}

	public GameObject getobj(int _kind)
	{
		switch (_kind)
		{
		case 0:
			return parts_total;
		case 1:
			return parts_total_num4;
		case 2:
			return parts_total_num3;
		case 3:
			return parts_total_num2;
		case 4:
			return parts_total_num1;
		case 5:
			return parts_get;
		case 6:
			return parts_game;
		case 7:
			return parts_plus1;
		case 8:
			return parts_g1;
		case 9:
			return parts_get_num4;
		case 10:
			return parts_get_num3;
		case 11:
			return parts_get_num2;
		case 12:
			return parts_get_num1;
		case 13:
			return parts_last;
		case 14:
			return parts_division1;
		case 15:
			return parts_division2;
		case 16:
			return parts_battle;
		case 17:
			return parts_g2;
		case 18:
			return parts_last_num4;
		case 19:
			return parts_last_num3;
		case 20:
			return parts_last_num2;
		case 21:
			return parts_last_num1;
		case 22:
			return parts_bb_num12;
		case 23:
			return parts_bb_num11;
		case 24:
			return parts_bb_num23;
		case 25:
			return parts_bb_num22;
		case 26:
			return parts_bb_num21;
		case 27:
			return parts_plus2;
		case 28:
			return parts_g3;
		case 29:
			return parts_plus_num4;
		case 30:
			return parts_plus_num3;
		case 31:
			return parts_plus_num2;
		case 32:
			return parts_plus_num1;
		case 33:
			return parts_slash;
		case 34:
			return parts_x;
		case 35:
			return parts_slash_num2;
		case 36:
			return parts_slash_num1;
		case 37:
			return parts_jac1;
		case 38:
			return parts_jac2;
		default:
			return null;
		}
	}

	public float getDefPosX(int _kind)
	{
		float[] array = new float[39]
		{
			28.8f, 56.64f, 64f, 71.36f, 78.72f, 153.28f, 149.76f, 160f, 208f, 177.28f,
			184.64f, 192f, 199.36f, 149.76f, 184.64f, 177.28f, 143.68f, 208f, 177.28f, 184.64f,
			192f, 199.36f, 169.92f, 177.28f, 155.2f, 162.56f, 169.92f, 160f, 208f, 177.28f,
			184.64f, 192f, 199.36f, 38.08f, 60.8f, 71.36f, 78.72f, 189.76f, 189.76f
		};
		return array[_kind];
	}

	public float getDefPosY(int _kind)
	{
		float[] array = new float[39]
		{
			-8.96f, -7.68f, -7.68f, -7.68f, -7.68f, -8.96f, -8.96f, -8.96f, -8.96f, -7.68f,
			-7.68f, -7.68f, -7.68f, -20.48f, -19.52f, -19.52f, -20.48f, -20.48f, -19.2f, -19.2f,
			-19.2f, -19.2f, -19.2f, -19.2f, -19.2f, -19.2f, -19.2f, -32f, -32f, -30.72f,
			-30.72f, -30.72f, -30.72f, -32f, -32f, -30.72f, -30.72f, -17.92f, -13.44f
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
