using UnityEngine;

public class UIMenuKisyu : MonoBehaviour
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

	private UISprite m_Title1;

	private UISprite m_Title2;

	private UISprite m_Title3;

	private UISprite m_Title4;

	private UISprite m_Sp_Page1;

	private UISprite m_Sp_Page2;

	private UISprite m_Sp_Page3;

	private UISprite m_Sp_Page4;

	private GameObject m_Panel1;

	private GameObject m_Panel2;

	private GameObject m_Panel3;

	private GameObject m_Panel4;

	private float m_Move;

	private float m_Drag;

	private float m_Flick;

	private bool m_IsDrag;

	private bool m_IsFlick;

	private int m_CurrentPage;

	private int m_ClickButtonID;

	private bool m_IsClick;

	private bool m_IsSetInput;

	private void Start()
	{
		base.gameObject.name = "Menu_Kisyu";
		m_Move = 0f;
		m_CurrentPage = 0;
		m_ClickButtonID = -1;
		m_IsClick = false;
		m_Drag = 0f;
		m_Flick = 0f;
		m_IsDrag = false;
		m_IsFlick = false;
		m_Bx_Back = GameObject.Find("Menu_Kisyu/Camera/Anchor2/Panel/Button_Back").GetComponent<BoxCollider>();
		m_Bx_ArrL = GameObject.Find("Menu_Kisyu/Camera/Anchor3/Panel/Arrow_L").GetComponent<BoxCollider>();
		m_Bx_ArrR = GameObject.Find("Menu_Kisyu/Camera/Anchor3/Panel/Arrow_R").GetComponent<BoxCollider>();
		m_Title1 = GameObject.Find("Menu_Kisyu/Camera/Anchor2/Panel/Title1").GetComponent<UISprite>();
		m_Title2 = GameObject.Find("Menu_Kisyu/Camera/Anchor2/Panel/Title2").GetComponent<UISprite>();
		m_Title3 = GameObject.Find("Menu_Kisyu/Camera/Anchor2/Panel/Title3").GetComponent<UISprite>();
		m_Title4 = GameObject.Find("Menu_Kisyu/Camera/Anchor2/Panel/Title4").GetComponent<UISprite>();
		m_Sp_Page1 = GameObject.Find("Menu_Kisyu/Camera/Anchor3/Panel/Page_1").GetComponent<UISprite>();
		m_Sp_Page2 = GameObject.Find("Menu_Kisyu/Camera/Anchor3/Panel/Page_2").GetComponent<UISprite>();
		m_Sp_Page3 = GameObject.Find("Menu_Kisyu/Camera/Anchor3/Panel/Page_3").GetComponent<UISprite>();
		m_Sp_Page4 = GameObject.Find("Menu_Kisyu/Camera/Anchor3/Panel/Page_4").GetComponent<UISprite>();
		m_Panel1 = GameObject.Find("Menu_Kisyu/Camera/Anchor1/Panel/Panel_Kisyu");
		m_Panel2 = GameObject.Find("Menu_Kisyu/Camera/Anchor1/Panel/Panel_Haitou");
		m_Panel3 = GameObject.Find("Menu_Kisyu/Camera/Anchor1/Panel/Panel_Chance");
		m_Panel4 = GameObject.Find("Menu_Kisyu/Camera/Anchor1/Panel/Panel_Kitaido");
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
				Object.Instantiate(Resources.Load("prefabs/Menu_Help"));
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
		while (_page >= 4)
		{
			_page -= 4;
		}
		while (_page < 0)
		{
			_page += 4;
		}
		m_CurrentPage = _page;
		m_Move = 0f;
		updatePosition(WIDTH);
		switch (m_CurrentPage)
		{
		case 0:
			m_Title1.color = new Color(1f, 1f, 1f, 1f);
			m_Title2.color = new Color(1f, 1f, 1f, 0f);
			m_Title3.color = new Color(1f, 1f, 1f, 0f);
			m_Title4.color = new Color(1f, 1f, 1f, 0f);
			m_Sp_Page1.spriteName = "data_cursor_on";
			m_Sp_Page2.spriteName = "data_cursor_off";
			m_Sp_Page3.spriteName = "data_cursor_off";
			m_Sp_Page4.spriteName = "data_cursor_off";
			break;
		case 1:
			m_Title1.color = new Color(1f, 1f, 1f, 0f);
			m_Title2.color = new Color(1f, 1f, 1f, 1f);
			m_Title3.color = new Color(1f, 1f, 1f, 0f);
			m_Title4.color = new Color(1f, 1f, 1f, 0f);
			m_Sp_Page1.spriteName = "data_cursor_off";
			m_Sp_Page2.spriteName = "data_cursor_on";
			m_Sp_Page3.spriteName = "data_cursor_off";
			m_Sp_Page4.spriteName = "data_cursor_off";
			break;
		case 2:
			m_Title1.color = new Color(1f, 1f, 1f, 0f);
			m_Title2.color = new Color(1f, 1f, 1f, 0f);
			m_Title3.color = new Color(1f, 1f, 1f, 1f);
			m_Title4.color = new Color(1f, 1f, 1f, 0f);
			m_Sp_Page1.spriteName = "data_cursor_off";
			m_Sp_Page2.spriteName = "data_cursor_off";
			m_Sp_Page3.spriteName = "data_cursor_on";
			m_Sp_Page4.spriteName = "data_cursor_off";
			break;
		case 3:
			m_Title1.color = new Color(1f, 1f, 1f, 0f);
			m_Title2.color = new Color(1f, 1f, 1f, 0f);
			m_Title3.color = new Color(1f, 1f, 1f, 0f);
			m_Title4.color = new Color(1f, 1f, 1f, 1f);
			m_Sp_Page1.spriteName = "data_cursor_off";
			m_Sp_Page2.spriteName = "data_cursor_off";
			m_Sp_Page3.spriteName = "data_cursor_off";
			m_Sp_Page4.spriteName = "data_cursor_on";
			break;
		}
	}

	private void updatePosition(float nextOffset)
	{
		GameObject gameObject;
		GameObject gameObject2;
		GameObject gameObject3;
		GameObject gameObject4;
		if (nextOffset >= 0f)
		{
			switch (m_CurrentPage)
			{
			default:
				gameObject = m_Panel1;
				gameObject2 = m_Panel2;
				gameObject3 = m_Panel3;
				gameObject4 = m_Panel4;
				break;
			case 1:
				gameObject = m_Panel2;
				gameObject2 = m_Panel3;
				gameObject3 = m_Panel4;
				gameObject4 = m_Panel1;
				break;
			case 2:
				gameObject = m_Panel3;
				gameObject2 = m_Panel4;
				gameObject3 = m_Panel1;
				gameObject4 = m_Panel2;
				break;
			case 3:
				gameObject = m_Panel4;
				gameObject2 = m_Panel1;
				gameObject3 = m_Panel2;
				gameObject4 = m_Panel3;
				break;
			}
		}
		else
		{
			switch (m_CurrentPage)
			{
			default:
				gameObject = m_Panel1;
				gameObject2 = m_Panel4;
				gameObject3 = m_Panel3;
				gameObject4 = m_Panel2;
				break;
			case 1:
				gameObject = m_Panel2;
				gameObject2 = m_Panel1;
				gameObject3 = m_Panel4;
				gameObject4 = m_Panel3;
				break;
			case 2:
				gameObject = m_Panel3;
				gameObject2 = m_Panel2;
				gameObject3 = m_Panel1;
				gameObject4 = m_Panel4;
				break;
			case 3:
				gameObject = m_Panel4;
				gameObject2 = m_Panel3;
				gameObject3 = m_Panel2;
				gameObject4 = m_Panel1;
				break;
			}
		}
		gameObject.transform.localPosition = new Vector3(m_Move, 0f, -1f);
		gameObject2.transform.localPosition = new Vector3(m_Move + nextOffset, 0f, -1f);
		gameObject3.transform.localPosition = new Vector3(m_Move + nextOffset * 2f, 0f, -1f);
		gameObject4.transform.localPosition = new Vector3(m_Move - nextOffset, 0f, -1f);
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
