using UnityEngine;

public class UISimMenuSousa : MonoBehaviour
{
	private const int BUTTON_ID_NONE = -1;

	private const int BUTTON_ID_BACK = 0;

	private const int BUTTON_ID_MOVE_L = 1;

	private const int BUTTON_ID_MOVE_R = 2;

	private const int BUTTON_ID_SWIPE = 3;

	private const int BUTTON_ID_RETURN = 4;

	public static readonly float MOVE_SPEED = 32f;

	public static readonly float WIDTH = 960f;

	public static readonly float LIMIT_L = 0f - WIDTH;

	public static readonly float LIMIT_R = WIDTH;

	public static readonly float FLICK_MOVE = 180f;

	public static readonly float FLICK_START = 64f;

	private BoxCollider m_Bx_Back;

	private BoxCollider m_Bx_ArrL;

	private BoxCollider m_Bx_ArrR;

	private UISprite[] m_Sp_Page = new UISprite[5];

	private GameObject[] m_Panels = new GameObject[5];

	private float m_Move;

	private float m_Drag;

	private float m_Flick;

	private bool m_IsDrag;

	private bool m_IsFlick;

	private int m_CurrentPage;

	private int m_ClickButtonID;

	private bool m_IsClick;

	private bool m_IsSetInput;

	private UISprite[] m_Title = new UISprite[5];

	private GameObject panel1;

	private GameObject panel2;

	private GameObject panel3;

	private GameObject panel4;

	private GameObject panel5;

	private void Start()
	{
		base.gameObject.name = "SimMenu_Sousa";
		m_ClickButtonID = -1;
		m_IsClick = false;
		m_Bx_Back = GameObject.Find("SimMenu_Sousa/Camera/Anchor2/Panel/Button_Back").GetComponent<BoxCollider>();
		m_Bx_ArrL = GameObject.Find("SimMenu_Sousa/Camera/Anchor3/Panel/Arrow_L").GetComponent<BoxCollider>();
		m_Bx_ArrR = GameObject.Find("SimMenu_Sousa/Camera/Anchor3/Panel/Arrow_R").GetComponent<BoxCollider>();
		for (int i = 0; i < m_Sp_Page.Length; i++)
		{
			int num = i + 1;
			m_Sp_Page[i] = GameObject.Find("SimMenu_Sousa/Camera/Anchor3/Panel/Page_" + num).GetComponent<UISprite>();
			m_Panels[i] = GameObject.Find("SimMenu_Sousa/Camera/Anchor1/Panel/Panel_Sousa" + num);
			m_Title[i] = GameObject.Find("SimMenu_Sousa/Camera/Anchor2/Panel/Title" + num).GetComponent<UISprite>();
		}
		setPage(0);
		setInput(false);
	}

	private void Update()
	{
		if (!m_IsClick && Input.GetKey(KeyCode.Escape))
		{
			OnClickEvent_Back();
		}
		if (!m_IsClick)
		{
			if (!SGLG.isFading)
			{
				setInput(true);
			}
			return;
		}
		switch (m_ClickButtonID)
		{
		case 0:
			if (SGLG.isFadeOutComplete())
			{
				SGLG.endFade();
				Object.Instantiate(Resources.Load("prefabs/SimMenu_Help"), new Vector3(0f, 0f, -20f), Quaternion.identity);
				Object.Destroy(base.gameObject);
				Resources.UnloadUnusedAssets();
			}
			break;
		case 1:
			m_Move -= MOVE_SPEED * 60f * SGLG.deltaTime;
			if (m_Move <= LIMIT_L)
			{
				m_Move = 0f - LIMIT_L;
				int page2 = m_CurrentPage + 1;
				setPage(page2);
				m_ClickButtonID = -1;
				setInput(true);
			}
			updatePosition(WIDTH);
			break;
		case 2:
			m_Move += MOVE_SPEED * 60f * SGLG.deltaTime;
			if (m_Move >= LIMIT_R)
			{
				m_Move = LIMIT_R;
				int page = m_CurrentPage - 1;
				setPage(page);
				m_ClickButtonID = -1;
				setInput(true);
			}
			updatePosition(0f - WIDTH);
			break;
		case 3:
			if (m_IsFlick)
			{
				m_Move = SGLGInput.x - m_Flick;
				updatePosition((!(m_Move < 0f)) ? (0f - WIDTH) : WIDTH);
			}
			else if (m_IsDrag)
			{
				float num = SGLGInput.x - m_Drag;
				if (num >= FLICK_START)
				{
					m_Flick = m_Drag + FLICK_START;
					m_IsFlick = true;
				}
				else if (num <= 0f - FLICK_START)
				{
					m_Flick = m_Drag - FLICK_START;
					m_IsFlick = true;
				}
			}
			else if (m_Move != 0f)
			{
				if (m_Move >= FLICK_MOVE)
				{
					m_ClickButtonID = 2;
				}
				else if (m_Move <= 0f - FLICK_MOVE)
				{
					m_ClickButtonID = 1;
				}
				else
				{
					m_ClickButtonID = 4;
				}
			}
			else
			{
				m_ClickButtonID = -1;
			}
			break;
		case 4:
		{
			bool flag = false;
			if (m_Move < 0f)
			{
				m_Move += MOVE_SPEED * 60f * SGLG.deltaTime;
				if (m_Move >= 0f)
				{
					m_Move = 0f;
					flag = true;
				}
			}
			else
			{
				m_Move -= MOVE_SPEED * 60f * SGLG.deltaTime;
				if (m_Move <= 0f)
				{
					m_Move = 0f;
					flag = true;
				}
			}
			updatePosition((!(m_Move < 0f)) ? (0f - WIDTH) : WIDTH);
			if (flag)
			{
				m_ClickButtonID = -1;
				setInput(true);
			}
			break;
		}
		default:
			m_IsClick = false;
			m_ClickButtonID = -1;
			break;
		}
	}

	private void OnClickEvent_Back()
	{
		if (on_click_button(0))
		{
			SGLG.startFade_Fast();
		}
	}

	private void OnClickEvent_ArrowL()
	{
		if (on_click_button(2))
		{
			m_Move = 0f;
		}
	}

	private void OnClickEvent_ArrowR()
	{
		if (on_click_button(1))
		{
			m_Move = 0f;
		}
	}

	private void OnEventPress()
	{
		if (m_IsSetInput && !m_IsDrag && !m_IsFlick && (m_ClickButtonID == -1 || m_ClickButtonID == 4))
		{
			setInput(false);
			m_Drag = SGLGInput.x;
			m_IsClick = true;
			m_IsDrag = true;
			m_ClickButtonID = 3;
		}
	}

	private void OnEventRelease()
	{
		if (m_IsDrag && m_ClickButtonID == 3)
		{
			m_Drag = 0f;
			m_Flick = 0f;
			m_IsDrag = false;
			m_IsFlick = false;
		}
	}

	private void setInput(bool _flag)
	{
		m_IsSetInput = _flag;
		m_Bx_Back.enabled = _flag;
		m_Bx_ArrL.enabled = _flag;
		m_Bx_ArrR.enabled = _flag;
	}

	private void setPage(int _page)
	{
		while (_page >= m_Sp_Page.Length)
		{
			_page = 0;
		}
		while (_page < 0)
		{
			_page = m_Sp_Page.Length - 1;
		}
		m_CurrentPage = _page;
		m_Move = 0f;
		updatePosition(WIDTH);
		for (int i = 0; i < m_Sp_Page.Length; i++)
		{
			if (m_CurrentPage == i)
			{
				m_Sp_Page[i].spriteName = "data_cursor_on";
				m_Title[i].color = new Color(1f, 1f, 1f, 1f);
			}
			else
			{
				m_Sp_Page[i].spriteName = "data_cursor_off";
				m_Title[i].color = new Color(1f, 1f, 1f, 0f);
			}
		}
	}

	private void updatePosition(float nextOffset)
	{
		switch (m_CurrentPage)
		{
		case 0:
			panel1 = m_Panels[3];
			panel2 = m_Panels[4];
			panel3 = m_Panels[0];
			panel4 = m_Panels[1];
			panel5 = m_Panels[2];
			break;
		case 1:
			panel1 = m_Panels[4];
			panel2 = m_Panels[0];
			panel3 = m_Panels[1];
			panel4 = m_Panels[2];
			panel5 = m_Panels[3];
			break;
		case 2:
			panel1 = m_Panels[0];
			panel2 = m_Panels[1];
			panel3 = m_Panels[2];
			panel4 = m_Panels[3];
			panel5 = m_Panels[4];
			break;
		case 3:
			panel1 = m_Panels[1];
			panel2 = m_Panels[2];
			panel3 = m_Panels[3];
			panel4 = m_Panels[4];
			panel5 = m_Panels[0];
			break;
		case 4:
			panel1 = m_Panels[2];
			panel2 = m_Panels[3];
			panel3 = m_Panels[4];
			panel4 = m_Panels[0];
			panel5 = m_Panels[1];
			break;
		}
		if (m_Move < 0f)
		{
			panel1.transform.localPosition = new Vector3(m_Move + nextOffset * -2f, -32f, -1f);
			panel2.transform.localPosition = new Vector3(m_Move + nextOffset * -1f, -32f, -1f);
			panel3.transform.localPosition = new Vector3(m_Move + nextOffset * 0f, -32f, -1f);
			panel4.transform.localPosition = new Vector3(m_Move + nextOffset * 1f, -32f, -1f);
			panel5.transform.localPosition = new Vector3(m_Move + nextOffset * 2f, -32f, -1f);
		}
		else
		{
			panel5.transform.localPosition = new Vector3(m_Move + nextOffset * -2f, -32f, -1f);
			panel4.transform.localPosition = new Vector3(m_Move + nextOffset * -1f, -32f, -1f);
			panel3.transform.localPosition = new Vector3(m_Move + nextOffset * 0f, -32f, -1f);
			panel2.transform.localPosition = new Vector3(m_Move + nextOffset * 1f, -32f, -1f);
			panel1.transform.localPosition = new Vector3(m_Move + nextOffset * 2f, -32f, -1f);
		}
	}

	private bool on_click_button(int button_id)
	{
		if (m_IsClick)
		{
			return false;
		}
		if (SGLG.isFading)
		{
			return false;
		}
		setInput(false);
		m_IsClick = true;
		m_ClickButtonID = button_id;
		return true;
	}
}
