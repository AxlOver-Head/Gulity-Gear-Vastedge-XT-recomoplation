using UnityEngine;

public class panelLIFE_GAUGE
{
	private enum KIND
	{
		_YELLOW11 = 0,
		_ORANGE11 = 1,
		_ORANGE21 = 2,
		_ORANGE31 = 3,
		_BLACK11 = 4,
		_BLACK21 = 5,
		_BLACK31 = 6,
		_WAVE11 = 7,
		_WAVE12 = 8,
		_WAVE13 = 9,
		_WAVE14 = 10,
		_WAVE15 = 11,
		_YELLOW12 = 12,
		_ORANGE12 = 13,
		_ORANGE22 = 14,
		_ORANGE32 = 15,
		_BLACK12 = 16,
		_BLACK22 = 17,
		_BLACK32 = 18,
		_WAVE21 = 19,
		_WAVE22 = 20,
		_WAVE23 = 21,
		_WAVE24 = 22,
		_WAVE25 = 23,
		_PARTS1 = 24,
		_PARTS2 = 25,
		_FRAME = 26,
		_MAX = 27
	}

	private enum STATE
	{
		_INIT = 0,
		_START = 1,
		_DAMAGE = 2,
		_DELAY = 3,
		_WAIT = 4,
		_END = 5,
		_DISA = 6
	}

	public const int WAIT_INIT = 0;

	public const int WAIT_START = 0;

	public const int WAIT_DAMAGE = 0;

	public const int WAIT_DELAY = 10;

	public const int WAIT_WAIT = 0;

	public const int WAIT_END = 0;

	public const int WAIT_DISA = 0;

	public const float DEF_POSX_YELLOW11 = 0f;

	public const float DEF_POSX_ORANGE11 = 0f;

	public const float DEF_POSX_ORANGE21 = 0f;

	public const float DEF_POSX_ORANGE31 = 0f;

	public const float DEF_POSX_BLACK11 = 0f;

	public const float DEF_POSX_BLACK21 = 0f;

	public const float DEF_POSX_BLACK31 = 0f;

	public const float DEF_POSX_WAVE11 = 0f;

	public const float DEF_POSX_WAVE12 = 0f;

	public const float DEF_POSX_WAVE13 = 0f;

	public const float DEF_POSX_WAVE14 = 0f;

	public const float DEF_POSX_WAVE15 = 0f;

	public const float DEF_POSX_YELLOW12 = 0f;

	public const float DEF_POSX_ORANGE12 = 0f;

	public const float DEF_POSX_ORANGE22 = 0f;

	public const float DEF_POSX_ORANGE32 = 0f;

	public const float DEF_POSX_BLACK12 = 0f;

	public const float DEF_POSX_BLACK22 = 0f;

	public const float DEF_POSX_BLACK32 = 0f;

	public const float DEF_POSX_WAVE21 = 0f;

	public const float DEF_POSX_WAVE22 = 0f;

	public const float DEF_POSX_WAVE23 = 0f;

	public const float DEF_POSX_WAVE24 = 0f;

	public const float DEF_POSX_WAVE25 = 0f;

	public const float DEF_POSX_PARTS1 = 221.12f;

	public const float DEF_POSX_PARTS2 = 34.88f;

	public const float DEF_POSX_FRAME = 128.32f;

	public const float DEF_POSY_YELLOW11 = 0f;

	public const float DEF_POSY_ORANGE11 = 0f;

	public const float DEF_POSY_ORANGE21 = 0f;

	public const float DEF_POSY_ORANGE31 = 0f;

	public const float DEF_POSY_BLACK11 = 0f;

	public const float DEF_POSY_BLACK21 = 0f;

	public const float DEF_POSY_BLACK31 = 0f;

	public const float DEF_POSY_WAVE11 = 0f;

	public const float DEF_POSY_WAVE12 = 0f;

	public const float DEF_POSY_WAVE13 = 0f;

	public const float DEF_POSY_WAVE14 = 0f;

	public const float DEF_POSY_WAVE15 = 0f;

	public const float DEF_POSY_YELLOW12 = 0f;

	public const float DEF_POSY_ORANGE12 = 0f;

	public const float DEF_POSY_ORANGE22 = 0f;

	public const float DEF_POSY_ORANGE32 = 0f;

	public const float DEF_POSY_BLACK12 = 0f;

	public const float DEF_POSY_BLACK22 = 0f;

	public const float DEF_POSY_BLACK32 = 0f;

	public const float DEF_POSY_WAVE21 = 0f;

	public const float DEF_POSY_WAVE22 = 0f;

	public const float DEF_POSY_WAVE23 = 0f;

	public const float DEF_POSY_WAVE24 = 0f;

	public const float DEF_POSY_WAVE25 = 0f;

	public const float DEF_POSY_PARTS1 = -17.28f;

	public const float DEF_POSY_PARTS2 = -17.28f;

	public const float DEF_POSY_FRAME = -21.12f;

	public const float DEF_POSZ_YELLOW11 = 0.05f;

	public const float DEF_POSZ_ORANGE11 = 0.04f;

	public const float DEF_POSZ_ORANGE21 = 0.04f;

	public const float DEF_POSZ_ORANGE31 = 0.04f;

	public const float DEF_POSZ_BLACK11 = 0.03f;

	public const float DEF_POSZ_BLACK21 = 0.03f;

	public const float DEF_POSZ_BLACK31 = 0.03f;

	public const float DEF_POSZ_WAVE11 = 0.02f;

	public const float DEF_POSZ_WAVE12 = 0.02f;

	public const float DEF_POSZ_WAVE13 = 0.02f;

	public const float DEF_POSZ_WAVE14 = 0.02f;

	public const float DEF_POSZ_WAVE15 = 0.02f;

	public const float DEF_POSZ_YELLOW12 = 0.05f;

	public const float DEF_POSZ_ORANGE12 = 0.04f;

	public const float DEF_POSZ_ORANGE22 = 0.04f;

	public const float DEF_POSZ_ORANGE32 = 0.04f;

	public const float DEF_POSZ_BLACK12 = 0.03f;

	public const float DEF_POSZ_BLACK22 = 0.03f;

	public const float DEF_POSZ_BLACK32 = 0.03f;

	public const float DEF_POSZ_WAVE21 = 0.02f;

	public const float DEF_POSZ_WAVE22 = 0.02f;

	public const float DEF_POSZ_WAVE23 = 0.02f;

	public const float DEF_POSZ_WAVE24 = 0.02f;

	public const float DEF_POSZ_WAVE25 = 0.02f;

	public const float DEF_POSZ_PARTS1 = 0.01f;

	public const float DEF_POSZ_PARTS2 = 0.01f;

	public const float DEF_POSZ_FRAME = 0.01f;

	public const float DEF_POSX_PANEL_GAUGE = -5f;

	public const float DEF_POSY_PANEL_GAUGE = -5f;

	public const float DEF_POSX_PANEL_FRAME = -5f;

	public const float DEF_POSY_PANEL_FRAME = -5f;

	private GameObject parts_yellow11;

	private GameObject parts_orange11;

	private GameObject parts_orange21;

	private GameObject parts_orange31;

	private GameObject parts_black11;

	private GameObject parts_black21;

	private GameObject parts_black31;

	private GameObject parts_wave11;

	private GameObject parts_wave12;

	private GameObject parts_wave13;

	private GameObject parts_wave14;

	private GameObject parts_wave15;

	private GameObject parts_yellow12;

	private GameObject parts_orange12;

	private GameObject parts_orange22;

	private GameObject parts_orange32;

	private GameObject parts_black12;

	private GameObject parts_black22;

	private GameObject parts_black32;

	private GameObject parts_wave21;

	private GameObject parts_wave22;

	private GameObject parts_wave23;

	private GameObject parts_wave24;

	private GameObject parts_wave25;

	private GameObject parts_parts1;

	private GameObject parts_parts2;

	private GameObject parts_frame;

	private GameObject panel_gauge;

	private GameObject panel_frame;

	private STATE[] m_state = new STATE[27];

	private int[] m_frame = new int[27];

	private bool[] m_active = new bool[27];

	private float m_total_damage_1p;

	private float m_total_damage_2p;

	private float m_now_damage_1p;

	private float m_now_damage_2p;

	private float m_tmp_damage_1p;

	private float m_tmp_damage_2p;

	public void release()
	{
		parts_yellow11 = null;
		parts_orange11 = null;
		parts_orange21 = null;
		parts_orange31 = null;
		parts_black11 = null;
		parts_black21 = null;
		parts_black31 = null;
		parts_wave11 = null;
		parts_wave12 = null;
		parts_wave13 = null;
		parts_wave14 = null;
		parts_wave15 = null;
		parts_yellow12 = null;
		parts_orange12 = null;
		parts_orange22 = null;
		parts_orange32 = null;
		parts_black12 = null;
		parts_black22 = null;
		parts_black32 = null;
		parts_wave21 = null;
		parts_wave22 = null;
		parts_wave23 = null;
		parts_wave24 = null;
		parts_wave25 = null;
		parts_parts1 = null;
		parts_parts2 = null;
		parts_frame = null;
		panel_gauge = null;
		panel_frame = null;
	}

	public void init()
	{
		int num = 0;
		parts_yellow11 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE/1P/001");
		parts_orange11 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE/1P/002");
		parts_orange21 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE/1P/003");
		parts_orange31 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE/1P/004");
		parts_wave11 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE/1P/wave_01");
		parts_wave12 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE/1P/wave_02");
		parts_wave13 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE/1P/wave_03");
		parts_wave14 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE/1P/wave_04");
		parts_wave15 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE/1P/wave_05");
		parts_black11 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE/1P_Black/01");
		parts_black21 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE/1P_Black/02");
		parts_black31 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE/1P_Black/03");
		parts_yellow12 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE/2P/001");
		parts_orange12 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE/2P/002");
		parts_orange22 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE/2P/003");
		parts_orange32 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE/2P/004");
		parts_wave21 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE/2P/wave_01");
		parts_wave22 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE/2P/wave_02");
		parts_wave23 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE/2P/wave_03");
		parts_wave24 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE/2P/wave_04");
		parts_wave25 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE/2P/wave_05");
		parts_black12 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE/2P_Black/01");
		parts_black22 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE/2P_Black/02");
		parts_black32 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE/2P_Black/03");
		parts_parts1 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE_FRAME/001");
		parts_parts2 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE_FRAME/002");
		parts_frame = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE_FRAME/006");
		panel_gauge = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE");
		panel_frame = GameObject.Find("GUIDirection/Camera/Anchor/Panel_LIFE_GAUGE_FRAME");
		panel_gauge.transform.localPosition = new Vector3(-5f, -5f, panel_gauge.transform.localPosition.z);
		panel_frame.transform.localPosition = new Vector3(-5f, -5f, panel_frame.transform.localPosition.z);
		setPositionZ(0, 0.05f);
		setPositionZ(1, 0.04f);
		setPositionZ(2, 0.04f);
		setPositionZ(3, 0.04f);
		setPositionZ(4, 0.03f);
		setPositionZ(5, 0.03f);
		setPositionZ(6, 0.03f);
		setPositionZ(7, 0.02f);
		setPositionZ(8, 0.02f);
		setPositionZ(9, 0.02f);
		setPositionZ(10, 0.02f);
		setPositionZ(11, 0.02f);
		setPositionZ(12, 0.05f);
		setPositionZ(13, 0.04f);
		setPositionZ(14, 0.04f);
		setPositionZ(15, 0.04f);
		setPositionZ(16, 0.03f);
		setPositionZ(17, 0.03f);
		setPositionZ(18, 0.03f);
		setPositionZ(19, 0.02f);
		setPositionZ(20, 0.02f);
		setPositionZ(21, 0.02f);
		setPositionZ(22, 0.02f);
		setPositionZ(23, 0.02f);
		setPositionZ(24, 0.01f);
		setPositionZ(25, 0.01f);
		setPositionZ(26, 0.01f);
		for (num = 0; num < 27; num++)
		{
			getobj(num).SetActiveRecursively(false);
			m_state[num] = STATE._DISA;
			m_frame[num] = 0;
			m_active[num] = false;
		}
		m_total_damage_1p = 0f;
		m_total_damage_2p = 0f;
		m_now_damage_1p = 0f;
		m_now_damage_2p = 0f;
		m_tmp_damage_1p = 0f;
		m_tmp_damage_2p = 0f;
	}

	public void Update()
	{
		int num = 0;
		for (num = 0; num < 27; num++)
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
				settingOrange1P();
				settingOrange2P();
				settingBlack1P();
				settingBlack2P();
				break;
			case STATE._START:
				m_frame[num]++;
				m_frame[num] = ((m_frame[num] <= 65535) ? m_frame[num] : 0);
				if (m_frame[num] >= 0)
				{
					m_state[num] = STATE._DAMAGE;
					m_frame[num] = 0;
				}
				break;
			case STATE._DAMAGE:
				m_frame[num]++;
				m_frame[num] = ((m_frame[num] <= 65535) ? m_frame[num] : 0);
				if (m_frame[num] >= 0)
				{
					settingOrange1P();
					settingOrange2P();
					m_state[num] = STATE._DELAY;
					m_frame[num] = 0;
				}
				break;
			case STATE._DELAY:
				m_frame[num]++;
				m_frame[num] = ((m_frame[num] <= 65535) ? m_frame[num] : 0);
				if (m_frame[num] >= 10)
				{
					m_total_damage_1p += m_now_damage_1p;
					m_total_damage_2p += m_now_damage_2p;
					settingBlack1P();
					settingBlack2P();
					m_now_damage_1p = 0f;
					m_now_damage_2p = 0f;
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
		for (num = 0; num < 27; num++)
		{
			setVisible(num, true);
		}
		parts_black11.transform.localScale = new Vector3(72f, parts_black11.transform.localScale.y, parts_black11.transform.localScale.z);
		parts_black12.transform.localScale = new Vector3(72f, parts_black12.transform.localScale.y, parts_black12.transform.localScale.z);
		parts_orange11.transform.localScale = new Vector3(72f, parts_orange11.transform.localScale.y, parts_orange11.transform.localScale.z);
		parts_orange12.transform.localScale = new Vector3(72f, parts_orange12.transform.localScale.y, parts_orange12.transform.localScale.z);
		m_total_damage_1p = 0f;
		m_total_damage_2p = 0f;
		m_now_damage_1p = 0f;
		m_now_damage_2p = 0f;
		setVisible(7, false);
		setVisible(8, false);
		setVisible(9, false);
		setVisible(10, false);
		setVisible(11, false);
		setVisible(19, false);
		setVisible(20, false);
		setVisible(21, false);
		setVisible(22, false);
		setVisible(23, false);
	}

	public void allDisable()
	{
		int num = 0;
		for (num = 0; num < 27; num++)
		{
			setVisible(num, false);
		}
		m_total_damage_1p = 0f;
		m_total_damage_2p = 0f;
		m_now_damage_1p = 0f;
		m_now_damage_2p = 0f;
		m_tmp_damage_1p = 0f;
		m_tmp_damage_2p = 0f;
	}

	public void baseEnable()
	{
		int num = 0;
		for (num = 0; num < 27; num++)
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

	public void settingBlack1P()
	{
		if (m_total_damage_1p >= 1f)
		{
			parts_black31.SetActiveRecursively(true);
			parts_black31.transform.localPosition = new Vector3(-36f, parts_black31.transform.localPosition.y, parts_black31.transform.localPosition.z);
			parts_black11.SetActiveRecursively(true);
			parts_black11.transform.localScale = new Vector3(m_total_damage_1p * 7.2f, parts_black11.transform.localScale.y, parts_black11.transform.localScale.z);
			parts_black11.transform.localPosition = new Vector3(-36f + m_total_damage_1p * 7.2f / 2f + 2f, parts_black11.transform.localPosition.y, parts_black11.transform.localPosition.z);
			parts_black21.SetActiveRecursively(true);
			parts_black21.transform.localPosition = new Vector3(-36f + m_total_damage_1p * 7.2f + 2f + 2f, parts_black21.transform.localPosition.y, parts_black21.transform.localPosition.z);
		}
		else
		{
			parts_black31.SetActiveRecursively(false);
			parts_black11.SetActiveRecursively(false);
			parts_black21.SetActiveRecursively(false);
		}
	}

	public void settingBlack2P()
	{
		if (m_total_damage_2p >= 1f)
		{
			parts_black32.SetActiveRecursively(true);
			parts_black32.transform.localPosition = new Vector3(36f, parts_black32.transform.localPosition.y, parts_black32.transform.localPosition.z);
			parts_black12.SetActiveRecursively(true);
			parts_black12.transform.localScale = new Vector3(m_total_damage_2p * 7.2f, parts_black12.transform.localScale.y, parts_black12.transform.localScale.z);
			parts_black12.transform.localPosition = new Vector3(36f - m_total_damage_2p * 7.2f / 2f - 2f, parts_black12.transform.localPosition.y, parts_black12.transform.localPosition.z);
			parts_black22.SetActiveRecursively(true);
			parts_black22.transform.localPosition = new Vector3(36f - m_total_damage_2p * 7.2f - 2f - 2f, parts_black22.transform.localPosition.y, parts_black22.transform.localPosition.z);
		}
		else
		{
			parts_black22.SetActiveRecursively(false);
			parts_black12.SetActiveRecursively(false);
			parts_black32.SetActiveRecursively(false);
		}
	}

	public void settingOrange1P()
	{
		if (m_now_damage_1p >= 1f)
		{
			float num = m_now_damage_1p + m_total_damage_1p;
			parts_orange31.SetActiveRecursively(true);
			parts_orange31.transform.localPosition = new Vector3(-36f, parts_orange31.transform.localPosition.y, parts_orange31.transform.localPosition.z);
			parts_orange11.SetActiveRecursively(true);
			parts_orange11.transform.localScale = new Vector3(num * 7.2f, parts_orange11.transform.localScale.y, parts_orange11.transform.localScale.z);
			parts_orange11.transform.localPosition = new Vector3(-36f + num * 7.2f / 2f + 2f, parts_orange11.transform.localPosition.y, parts_orange11.transform.localPosition.z);
			parts_orange21.SetActiveRecursively(true);
			parts_orange21.transform.localPosition = new Vector3(-36f + num * 7.2f + 2f + 2f, parts_orange21.transform.localPosition.y, parts_orange21.transform.localPosition.z);
		}
		else
		{
			parts_orange31.SetActiveRecursively(false);
			parts_orange11.SetActiveRecursively(false);
			parts_orange21.SetActiveRecursively(false);
		}
	}

	public void settingOrange2P()
	{
		if (m_now_damage_2p >= 1f)
		{
			float num = m_now_damage_2p + m_total_damage_2p;
			parts_orange32.SetActiveRecursively(true);
			parts_orange32.transform.localPosition = new Vector3(36f, parts_orange32.transform.localPosition.y, parts_orange32.transform.localPosition.z);
			parts_orange12.SetActiveRecursively(true);
			parts_orange12.transform.localScale = new Vector3(num * 7.2f, parts_orange12.transform.localScale.y, parts_orange12.transform.localScale.z);
			parts_orange12.transform.localPosition = new Vector3(36f - num * 7.2f / 2f - 2f, parts_orange12.transform.localPosition.y, parts_orange12.transform.localPosition.z);
			parts_orange22.SetActiveRecursively(true);
			parts_orange22.transform.localPosition = new Vector3(36f - num * 7.2f - 2f - 2f, parts_orange22.transform.localPosition.y, parts_orange22.transform.localPosition.z);
		}
		else
		{
			parts_orange32.SetActiveRecursively(false);
			parts_orange12.SetActiveRecursively(false);
			parts_orange22.SetActiveRecursively(false);
		}
	}

	public void setDamage()
	{
		if (m_state[26] == STATE._DAMAGE || m_state[26] == STATE._DELAY)
		{
			if (m_now_damage_1p != 0f)
			{
				m_total_damage_1p += m_now_damage_1p;
				m_now_damage_1p = 0f;
			}
			if (m_now_damage_2p != 0f)
			{
				m_total_damage_2p += m_now_damage_2p;
				m_now_damage_2p = 0f;
			}
			settingBlack1P();
			settingBlack2P();
			m_state[26] = STATE._WAIT;
		}
		else if (m_state[26] == STATE._WAIT)
		{
			m_now_damage_1p = m_tmp_damage_1p;
			m_now_damage_2p = m_tmp_damage_2p;
			m_tmp_damage_1p = 0f;
			m_tmp_damage_2p = 0f;
			if (m_now_damage_1p != 0f || m_now_damage_2p != 0f)
			{
				m_state[26] = STATE._DAMAGE;
				m_frame[26] = 0;
			}
		}
	}

	public void setNowDamage(int _atk, int _dam)
	{
		switch (_atk)
		{
		case 1:
			m_tmp_damage_2p = ((!((float)_dam + m_total_damage_2p >= 10f)) ? ((float)_dam) : (10f - m_total_damage_2p));
			break;
		case 2:
			m_tmp_damage_1p = ((!((float)_dam + m_total_damage_1p > 10f)) ? ((float)_dam) : (10f - m_total_damage_1p));
			break;
		case 3:
			m_tmp_damage_1p = ((!((float)_dam + m_total_damage_1p > 10f)) ? ((float)_dam) : (10f - m_total_damage_1p));
			break;
		}
	}

	public float getNowDamage(int _atk)
	{
		float result = 0f;
		switch (_atk)
		{
		case 1:
			result = m_tmp_damage_2p;
			break;
		case 2:
			result = m_tmp_damage_1p;
			break;
		case 3:
			result = m_tmp_damage_1p;
			break;
		}
		return result;
	}

	public GameObject getobj(int _kind)
	{
		switch (_kind)
		{
		case 0:
			return parts_yellow11;
		case 1:
			return parts_orange11;
		case 2:
			return parts_orange21;
		case 3:
			return parts_orange31;
		case 4:
			return parts_black11;
		case 5:
			return parts_black21;
		case 6:
			return parts_black31;
		case 7:
			return parts_wave11;
		case 8:
			return parts_wave12;
		case 9:
			return parts_wave13;
		case 10:
			return parts_wave14;
		case 11:
			return parts_wave15;
		case 12:
			return parts_yellow12;
		case 13:
			return parts_orange12;
		case 14:
			return parts_orange22;
		case 15:
			return parts_orange32;
		case 16:
			return parts_black12;
		case 17:
			return parts_black22;
		case 18:
			return parts_black32;
		case 19:
			return parts_wave21;
		case 20:
			return parts_wave22;
		case 21:
			return parts_wave23;
		case 22:
			return parts_wave24;
		case 23:
			return parts_wave25;
		case 24:
			return parts_parts1;
		case 25:
			return parts_parts2;
		case 26:
			return parts_frame;
		default:
			return null;
		}
	}

	public float getDefPosX(int _kind)
	{
		float[] array = new float[27];
		array[24] = 221.12f;
		array[25] = 34.88f;
		array[26] = 128.32f;
		float[] array2 = array;
		return array2[_kind];
	}

	public float getDefPosY(int _kind)
	{
		float[] array = new float[27];
		array[24] = -17.28f;
		array[25] = -17.28f;
		array[26] = -21.12f;
		float[] array2 = array;
		return array2[_kind];
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
