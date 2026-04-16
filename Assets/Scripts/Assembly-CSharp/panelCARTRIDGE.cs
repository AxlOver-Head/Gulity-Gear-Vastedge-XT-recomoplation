using UnityEngine;

public class panelCARTRIDGE
{
	private enum KIND
	{
		_BASE01 = 0,
		_BASE02 = 1,
		_BASE03 = 2,
		_BASE04 = 3,
		_BASE05 = 4,
		_BASE06 = 5,
		_BASE07 = 6,
		_BASE08 = 7,
		_BASE09 = 8,
		_BASE10 = 9,
		_BASE11 = 10,
		_BASE12 = 11,
		_BASE13 = 12,
		_BASE14 = 13,
		_BASE15 = 14,
		_BASE16 = 15,
		_BASE17 = 16,
		_BASE18 = 17,
		_BASE19 = 18,
		_BASE20 = 19,
		_ADD01 = 20,
		_ADD02 = 21,
		_ADD03 = 22,
		_ADD04 = 23,
		_ADD05 = 24,
		_ADD06 = 25,
		_ADD07 = 26,
		_ADD08 = 27,
		_ADD09 = 28,
		_ADD10 = 29,
		_ADD11 = 30,
		_ADD12 = 31,
		_ADD13 = 32,
		_ADD14 = 33,
		_ADD15 = 34,
		_ADD16 = 35,
		_ADD17 = 36,
		_ADD18 = 37,
		_ADD19 = 38,
		_ADD20 = 39,
		_MAX = 40
	}

	private enum STATE
	{
		_INIT = 0,
		_START = 1,
		_WAIT = 2,
		_FLASH = 3,
		_END = 4,
		_DISA = 5
	}

	public const int WAIT_INIT = 0;

	public const int WAIT_START = 0;

	public const int WAIT_WAIT = 0;

	public const int WAIT_FLASH = 0;

	public const int WAIT_END = 0;

	public const int WAIT_DISA = 0;

	public const float DEF_POSX_BASE01 = 16f;

	public const float DEF_POSX_BASE02 = 26f;

	public const float DEF_POSX_BASE03 = 36f;

	public const float DEF_POSX_BASE04 = 46f;

	public const float DEF_POSX_BASE05 = 56f;

	public const float DEF_POSX_BASE06 = 66f;

	public const float DEF_POSX_BASE07 = 76f;

	public const float DEF_POSX_BASE08 = 86f;

	public const float DEF_POSX_BASE09 = 96f;

	public const float DEF_POSX_BASE10 = 106f;

	public const float DEF_POSX_BASE11 = 16f;

	public const float DEF_POSX_BASE12 = 26f;

	public const float DEF_POSX_BASE13 = 36f;

	public const float DEF_POSX_BASE14 = 46f;

	public const float DEF_POSX_BASE15 = 56f;

	public const float DEF_POSX_BASE16 = 66f;

	public const float DEF_POSX_BASE17 = 76f;

	public const float DEF_POSX_BASE18 = 86f;

	public const float DEF_POSX_BASE19 = 96f;

	public const float DEF_POSX_BASE20 = 106f;

	public const float DEF_POSX_ADD01 = 16f;

	public const float DEF_POSX_ADD02 = 26f;

	public const float DEF_POSX_ADD03 = 36f;

	public const float DEF_POSX_ADD04 = 46f;

	public const float DEF_POSX_ADD05 = 56f;

	public const float DEF_POSX_ADD06 = 66f;

	public const float DEF_POSX_ADD07 = 76f;

	public const float DEF_POSX_ADD08 = 86f;

	public const float DEF_POSX_ADD09 = 96f;

	public const float DEF_POSX_ADD10 = 106f;

	public const float DEF_POSX_ADD11 = 16f;

	public const float DEF_POSX_ADD12 = 26f;

	public const float DEF_POSX_ADD13 = 36f;

	public const float DEF_POSX_ADD14 = 46f;

	public const float DEF_POSX_ADD15 = 56f;

	public const float DEF_POSX_ADD16 = 66f;

	public const float DEF_POSX_ADD17 = 76f;

	public const float DEF_POSX_ADD18 = 86f;

	public const float DEF_POSX_ADD19 = 96f;

	public const float DEF_POSX_ADD20 = 106f;

	public const float DEF_POSY_BASE01 = -24f;

	public const float DEF_POSY_BASE02 = -24f;

	public const float DEF_POSY_BASE03 = -24f;

	public const float DEF_POSY_BASE04 = -24f;

	public const float DEF_POSY_BASE05 = -24f;

	public const float DEF_POSY_BASE06 = -24f;

	public const float DEF_POSY_BASE07 = -24f;

	public const float DEF_POSY_BASE08 = -24f;

	public const float DEF_POSY_BASE09 = -24f;

	public const float DEF_POSY_BASE10 = -24f;

	public const float DEF_POSY_BASE11 = -36f;

	public const float DEF_POSY_BASE12 = -36f;

	public const float DEF_POSY_BASE13 = -36f;

	public const float DEF_POSY_BASE14 = -36f;

	public const float DEF_POSY_BASE15 = -36f;

	public const float DEF_POSY_BASE16 = -36f;

	public const float DEF_POSY_BASE17 = -36f;

	public const float DEF_POSY_BASE18 = -36f;

	public const float DEF_POSY_BASE19 = -36f;

	public const float DEF_POSY_BASE20 = -36f;

	public const float DEF_POSY_ADD01 = -24f;

	public const float DEF_POSY_ADD02 = -24f;

	public const float DEF_POSY_ADD03 = -24f;

	public const float DEF_POSY_ADD04 = -24f;

	public const float DEF_POSY_ADD05 = -24f;

	public const float DEF_POSY_ADD06 = -24f;

	public const float DEF_POSY_ADD07 = -24f;

	public const float DEF_POSY_ADD08 = -24f;

	public const float DEF_POSY_ADD09 = -24f;

	public const float DEF_POSY_ADD10 = -24f;

	public const float DEF_POSY_ADD11 = -36f;

	public const float DEF_POSY_ADD12 = -36f;

	public const float DEF_POSY_ADD13 = -36f;

	public const float DEF_POSY_ADD14 = -36f;

	public const float DEF_POSY_ADD15 = -36f;

	public const float DEF_POSY_ADD16 = -36f;

	public const float DEF_POSY_ADD17 = -36f;

	public const float DEF_POSY_ADD18 = -36f;

	public const float DEF_POSY_ADD19 = -36f;

	public const float DEF_POSY_ADD20 = -36f;

	public const float DEF_POSZ_BASE01 = 0.01f;

	public const float DEF_POSZ_BASE02 = 0.01f;

	public const float DEF_POSZ_BASE03 = 0.01f;

	public const float DEF_POSZ_BASE04 = 0.01f;

	public const float DEF_POSZ_BASE05 = 0.01f;

	public const float DEF_POSZ_BASE06 = 0.01f;

	public const float DEF_POSZ_BASE07 = 0.01f;

	public const float DEF_POSZ_BASE08 = 0.01f;

	public const float DEF_POSZ_BASE09 = 0.01f;

	public const float DEF_POSZ_BASE10 = 0.01f;

	public const float DEF_POSZ_BASE11 = 0.01f;

	public const float DEF_POSZ_BASE12 = 0.01f;

	public const float DEF_POSZ_BASE13 = 0.01f;

	public const float DEF_POSZ_BASE14 = 0.01f;

	public const float DEF_POSZ_BASE15 = 0.01f;

	public const float DEF_POSZ_BASE16 = 0.01f;

	public const float DEF_POSZ_BASE17 = 0.01f;

	public const float DEF_POSZ_BASE18 = 0.01f;

	public const float DEF_POSZ_BASE19 = 0.01f;

	public const float DEF_POSZ_BASE20 = 0.01f;

	public const float DEF_POSZ_ADD01 = 0f;

	public const float DEF_POSZ_ADD02 = 0f;

	public const float DEF_POSZ_ADD03 = 0f;

	public const float DEF_POSZ_ADD04 = 0f;

	public const float DEF_POSZ_ADD05 = 0f;

	public const float DEF_POSZ_ADD06 = 0f;

	public const float DEF_POSZ_ADD07 = 0f;

	public const float DEF_POSZ_ADD08 = 0f;

	public const float DEF_POSZ_ADD09 = 0f;

	public const float DEF_POSZ_ADD10 = 0f;

	public const float DEF_POSZ_ADD11 = 0f;

	public const float DEF_POSZ_ADD12 = 0f;

	public const float DEF_POSZ_ADD13 = 0f;

	public const float DEF_POSZ_ADD14 = 0f;

	public const float DEF_POSZ_ADD15 = 0f;

	public const float DEF_POSZ_ADD16 = 0f;

	public const float DEF_POSZ_ADD17 = 0f;

	public const float DEF_POSZ_ADD18 = 0f;

	public const float DEF_POSZ_ADD19 = 0f;

	public const float DEF_POSZ_ADD20 = 0f;

	private GameObject parts_base01;

	private GameObject parts_base02;

	private GameObject parts_base03;

	private GameObject parts_base04;

	private GameObject parts_base05;

	private GameObject parts_base06;

	private GameObject parts_base07;

	private GameObject parts_base08;

	private GameObject parts_base09;

	private GameObject parts_base10;

	private GameObject parts_base11;

	private GameObject parts_base12;

	private GameObject parts_base13;

	private GameObject parts_base14;

	private GameObject parts_base15;

	private GameObject parts_base16;

	private GameObject parts_base17;

	private GameObject parts_base18;

	private GameObject parts_base19;

	private GameObject parts_base20;

	private GameObject parts_add01;

	private GameObject parts_add02;

	private GameObject parts_add03;

	private GameObject parts_add04;

	private GameObject parts_add05;

	private GameObject parts_add06;

	private GameObject parts_add07;

	private GameObject parts_add08;

	private GameObject parts_add09;

	private GameObject parts_add10;

	private GameObject parts_add11;

	private GameObject parts_add12;

	private GameObject parts_add13;

	private GameObject parts_add14;

	private GameObject parts_add15;

	private GameObject parts_add16;

	private GameObject parts_add17;

	private GameObject parts_add18;

	private GameObject parts_add19;

	private GameObject parts_add20;

	private UISprite m_base01;

	private UISprite m_base02;

	private UISprite m_base03;

	private UISprite m_base04;

	private UISprite m_base05;

	private UISprite m_base06;

	private UISprite m_base07;

	private UISprite m_base08;

	private UISprite m_base09;

	private UISprite m_base10;

	private UISprite m_base11;

	private UISprite m_base12;

	private UISprite m_base13;

	private UISprite m_base14;

	private UISprite m_base15;

	private UISprite m_base16;

	private UISprite m_base17;

	private UISprite m_base18;

	private UISprite m_base19;

	private UISprite m_base20;

	private UISprite m_add01;

	private UISprite m_add02;

	private UISprite m_add03;

	private UISprite m_add04;

	private UISprite m_add05;

	private UISprite m_add06;

	private UISprite m_add07;

	private UISprite m_add08;

	private UISprite m_add09;

	private UISprite m_add10;

	private UISprite m_add11;

	private UISprite m_add12;

	private UISprite m_add13;

	private UISprite m_add14;

	private UISprite m_add15;

	private UISprite m_add16;

	private UISprite m_add17;

	private UISprite m_add18;

	private UISprite m_add19;

	private UISprite m_add20;

	private STATE[] m_state = new STATE[40];

	private int[] m_frame = new int[40];

	private bool[] m_active = new bool[40];

	public void release()
	{
		parts_base01 = null;
		parts_base02 = null;
		parts_base03 = null;
		parts_base04 = null;
		parts_base05 = null;
		parts_base06 = null;
		parts_base07 = null;
		parts_base08 = null;
		parts_base09 = null;
		parts_base10 = null;
		parts_base11 = null;
		parts_base12 = null;
		parts_base13 = null;
		parts_base14 = null;
		parts_base15 = null;
		parts_base16 = null;
		parts_base17 = null;
		parts_base18 = null;
		parts_base19 = null;
		parts_base20 = null;
		parts_add01 = null;
		parts_add02 = null;
		parts_add03 = null;
		parts_add04 = null;
		parts_add05 = null;
		parts_add06 = null;
		parts_add07 = null;
		parts_add08 = null;
		parts_add09 = null;
		parts_add10 = null;
		parts_add11 = null;
		parts_add12 = null;
		parts_add13 = null;
		parts_add14 = null;
		parts_add15 = null;
		parts_add16 = null;
		parts_add17 = null;
		parts_add18 = null;
		parts_add19 = null;
		parts_add20 = null;
		m_base01 = null;
		m_base02 = null;
		m_base03 = null;
		m_base04 = null;
		m_base05 = null;
		m_base06 = null;
		m_base07 = null;
		m_base08 = null;
		m_base09 = null;
		m_base10 = null;
		m_base11 = null;
		m_base12 = null;
		m_base13 = null;
		m_base14 = null;
		m_base15 = null;
		m_base16 = null;
		m_base17 = null;
		m_base18 = null;
		m_base19 = null;
		m_base20 = null;
		m_add01 = null;
		m_add02 = null;
		m_add03 = null;
		m_add04 = null;
		m_add05 = null;
		m_add06 = null;
		m_add07 = null;
		m_add08 = null;
		m_add09 = null;
		m_add10 = null;
		m_add11 = null;
		m_add12 = null;
		m_add13 = null;
		m_add14 = null;
		m_add15 = null;
		m_add16 = null;
		m_add17 = null;
		m_add18 = null;
		m_add19 = null;
		m_add20 = null;
	}

	public void init()
	{
		int num = 0;
		parts_base01 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/001");
		parts_base02 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/002");
		parts_base03 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/003");
		parts_base04 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/004");
		parts_base05 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/005");
		parts_base06 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/006");
		parts_base07 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/007");
		parts_base08 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/008");
		parts_base09 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/009");
		parts_base10 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/010");
		parts_base11 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/011");
		parts_base12 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/012");
		parts_base13 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/013");
		parts_base14 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/014");
		parts_base15 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/015");
		parts_base16 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/016");
		parts_base17 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/017");
		parts_base18 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/018");
		parts_base19 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/019");
		parts_base20 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/020");
		parts_add01 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/021");
		parts_add02 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/022");
		parts_add03 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/023");
		parts_add04 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/024");
		parts_add05 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/025");
		parts_add06 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/026");
		parts_add07 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/027");
		parts_add08 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/028");
		parts_add09 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/029");
		parts_add10 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/030");
		parts_add11 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/031");
		parts_add12 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/032");
		parts_add13 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/033");
		parts_add14 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/034");
		parts_add15 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/035");
		parts_add16 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/036");
		parts_add17 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/037");
		parts_add18 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/038");
		parts_add19 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/039");
		parts_add20 = GameObject.Find("GUIDirection/Camera/Anchor/Panel_CARTRIDGE/040");
		m_base01 = parts_base01.GetComponent<UISprite>();
		m_base02 = parts_base02.GetComponent<UISprite>();
		m_base03 = parts_base03.GetComponent<UISprite>();
		m_base04 = parts_base04.GetComponent<UISprite>();
		m_base05 = parts_base05.GetComponent<UISprite>();
		m_base06 = parts_base06.GetComponent<UISprite>();
		m_base07 = parts_base07.GetComponent<UISprite>();
		m_base08 = parts_base08.GetComponent<UISprite>();
		m_base09 = parts_base09.GetComponent<UISprite>();
		m_base10 = parts_base10.GetComponent<UISprite>();
		m_base11 = parts_base11.GetComponent<UISprite>();
		m_base12 = parts_base12.GetComponent<UISprite>();
		m_base13 = parts_base13.GetComponent<UISprite>();
		m_base14 = parts_base14.GetComponent<UISprite>();
		m_base15 = parts_base15.GetComponent<UISprite>();
		m_base16 = parts_base16.GetComponent<UISprite>();
		m_base17 = parts_base17.GetComponent<UISprite>();
		m_base18 = parts_base18.GetComponent<UISprite>();
		m_base19 = parts_base19.GetComponent<UISprite>();
		m_base20 = parts_base20.GetComponent<UISprite>();
		m_add01 = parts_add01.GetComponent<UISprite>();
		m_add02 = parts_add02.GetComponent<UISprite>();
		m_add03 = parts_add03.GetComponent<UISprite>();
		m_add04 = parts_add04.GetComponent<UISprite>();
		m_add05 = parts_add05.GetComponent<UISprite>();
		m_add06 = parts_add06.GetComponent<UISprite>();
		m_add07 = parts_add07.GetComponent<UISprite>();
		m_add08 = parts_add08.GetComponent<UISprite>();
		m_add09 = parts_add09.GetComponent<UISprite>();
		m_add10 = parts_add10.GetComponent<UISprite>();
		m_add11 = parts_add11.GetComponent<UISprite>();
		m_add12 = parts_add12.GetComponent<UISprite>();
		m_add13 = parts_add13.GetComponent<UISprite>();
		m_add14 = parts_add14.GetComponent<UISprite>();
		m_add15 = parts_add15.GetComponent<UISprite>();
		m_add16 = parts_add16.GetComponent<UISprite>();
		m_add17 = parts_add17.GetComponent<UISprite>();
		m_add18 = parts_add18.GetComponent<UISprite>();
		m_add19 = parts_add19.GetComponent<UISprite>();
		m_add20 = parts_add20.GetComponent<UISprite>();
		setPositionZ(0, 0.01f);
		setPositionZ(1, 0.01f);
		setPositionZ(2, 0.01f);
		setPositionZ(3, 0.01f);
		setPositionZ(4, 0.01f);
		setPositionZ(5, 0.01f);
		setPositionZ(6, 0.01f);
		setPositionZ(7, 0.01f);
		setPositionZ(8, 0.01f);
		setPositionZ(9, 0.01f);
		setPositionZ(10, 0.01f);
		setPositionZ(11, 0.01f);
		setPositionZ(12, 0.01f);
		setPositionZ(13, 0.01f);
		setPositionZ(14, 0.01f);
		setPositionZ(15, 0.01f);
		setPositionZ(16, 0.01f);
		setPositionZ(17, 0.01f);
		setPositionZ(18, 0.01f);
		setPositionZ(19, 0.01f);
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
		setPositionZ(39, 0f);
		for (num = 0; num < 40; num++)
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
		for (num = 0; num < 40; num++)
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
			case STATE._FLASH:
				m_frame[num]++;
				m_frame[num] = ((m_frame[num] <= 65535) ? m_frame[num] : 0);
				if (m_frame[num] % 30 < 15)
				{
					getsprite(num).alpha = (float)(m_frame[num] % 15) / 15f;
				}
				else
				{
					getsprite(num).alpha = (float)(15 - m_frame[num] % 15) / 15f;
				}
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
		for (num = 0; num > 40; num++)
		{
			setVisible(num, true);
		}
	}

	public void allDisable()
	{
		int num = 0;
		for (num = 0; num < 40; num++)
		{
			setVisible(num, false);
		}
	}

	public void onDispCartridge(int _idx, int _col)
	{
		setVisible(_idx, true);
		string[] array = new string[3] { "07A00_o_u_a00_c1", "07A00_o_u_a00_c2", "07A00_o_u_a00_c3" };
		getsprite(_idx).spriteName = array[_col];
	}

	public void offDispCartridge(int _idx)
	{
		int num = 0;
		for (num = 0; num < 20; num++)
		{
			if (_idx <= num)
			{
				setVisible(num, false);
			}
		}
		for (num = 20; num < 40; num++)
		{
			if (_idx + 20 <= num)
			{
				setVisible(num, false);
			}
		}
	}

	public void setFlash(int _idx)
	{
		int num = _idx + 20;
		getobj(num).SetActiveRecursively(true);
		getobj(num).transform.localPosition = new Vector3(getDefPosX(num), getDefPosY(num), getobj(num).transform.localPosition.z);
		m_active[num] = true;
		m_state[num] = STATE._FLASH;
	}

	public void baseEnable()
	{
		int num = 0;
		for (num = 0; num > 40; num++)
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
			return parts_base01;
		case 1:
			return parts_base02;
		case 2:
			return parts_base03;
		case 3:
			return parts_base04;
		case 4:
			return parts_base05;
		case 5:
			return parts_base06;
		case 6:
			return parts_base07;
		case 7:
			return parts_base08;
		case 8:
			return parts_base09;
		case 9:
			return parts_base10;
		case 10:
			return parts_base11;
		case 11:
			return parts_base12;
		case 12:
			return parts_base13;
		case 13:
			return parts_base14;
		case 14:
			return parts_base15;
		case 15:
			return parts_base16;
		case 16:
			return parts_base17;
		case 17:
			return parts_base18;
		case 18:
			return parts_base19;
		case 19:
			return parts_base20;
		case 20:
			return parts_add01;
		case 21:
			return parts_add02;
		case 22:
			return parts_add03;
		case 23:
			return parts_add04;
		case 24:
			return parts_add05;
		case 25:
			return parts_add06;
		case 26:
			return parts_add07;
		case 27:
			return parts_add08;
		case 28:
			return parts_add09;
		case 29:
			return parts_add10;
		case 30:
			return parts_add11;
		case 31:
			return parts_add12;
		case 32:
			return parts_add13;
		case 33:
			return parts_add14;
		case 34:
			return parts_add15;
		case 35:
			return parts_add16;
		case 36:
			return parts_add17;
		case 37:
			return parts_add18;
		case 38:
			return parts_add19;
		case 39:
			return parts_add20;
		default:
			return null;
		}
	}

	public UISprite getsprite(int _kind)
	{
		switch (_kind)
		{
		case 0:
			return m_base01;
		case 1:
			return m_base02;
		case 2:
			return m_base03;
		case 3:
			return m_base04;
		case 4:
			return m_base05;
		case 5:
			return m_base06;
		case 6:
			return m_base07;
		case 7:
			return m_base08;
		case 8:
			return m_base09;
		case 9:
			return m_base10;
		case 10:
			return m_base11;
		case 11:
			return m_base12;
		case 12:
			return m_base13;
		case 13:
			return m_base14;
		case 14:
			return m_base15;
		case 15:
			return m_base16;
		case 16:
			return m_base17;
		case 17:
			return m_base18;
		case 18:
			return m_base19;
		case 19:
			return m_base20;
		case 20:
			return m_add01;
		case 21:
			return m_add02;
		case 22:
			return m_add03;
		case 23:
			return m_add04;
		case 24:
			return m_add05;
		case 25:
			return m_add06;
		case 26:
			return m_add07;
		case 27:
			return m_add08;
		case 28:
			return m_add09;
		case 29:
			return m_add10;
		case 30:
			return m_add11;
		case 31:
			return m_add12;
		case 32:
			return m_add13;
		case 33:
			return m_add14;
		case 34:
			return m_add15;
		case 35:
			return m_add16;
		case 36:
			return m_add17;
		case 37:
			return m_add18;
		case 38:
			return m_add19;
		case 39:
			return m_add20;
		default:
			return null;
		}
	}

	public float getDefPosX(int _kind)
	{
		float[] array = new float[40]
		{
			16f, 26f, 36f, 46f, 56f, 66f, 76f, 86f, 96f, 106f,
			16f, 26f, 36f, 46f, 56f, 66f, 76f, 86f, 96f, 106f,
			16f, 26f, 36f, 46f, 56f, 66f, 76f, 86f, 96f, 106f,
			16f, 26f, 36f, 46f, 56f, 66f, 76f, 86f, 96f, 106f
		};
		return array[_kind];
	}

	public float getDefPosY(int _kind)
	{
		float[] array = new float[40]
		{
			-24f, -24f, -24f, -24f, -24f, -24f, -24f, -24f, -24f, -24f,
			-36f, -36f, -36f, -36f, -36f, -36f, -36f, -36f, -36f, -36f,
			-24f, -24f, -24f, -24f, -24f, -24f, -24f, -24f, -24f, -24f,
			-36f, -36f, -36f, -36f, -36f, -36f, -36f, -36f, -36f, -36f
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
