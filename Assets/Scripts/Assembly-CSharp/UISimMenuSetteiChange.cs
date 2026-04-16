using UnityEngine;

public class UISimMenuSetteiChange : MonoBehaviour
{
	private const int BUTTON_ID_NONE = -1;

	private const int BUTTON_ID_BACK = 0;

	private const int BUTTON_ID_HELP = 1;

	private const int BUTTON_ID_ICON = 2;

	private const int BUTTON_ID_PLAYGAME = 4;

	private const int BUTTON_ID_TO_RESETGAME = 5;

	private int m_ClickButtonID;

	private bool m_IsClick;

	public int m_Settei = -1;

	private GameObject[] m_ObjOnButton = new GameObject[7];

	private BoxCollider[] m_Bx_Settei;

	private BoxCollider m_Bx_Back;

	private BoxCollider m_Bx_Help;

	private BoxCollider m_Bx_Start;

	private UIDialog_28 m_Dialog_28;

	private void Start()
	{
		m_ObjOnButton[0] = GameObject.Find(base.gameObject.name + "/Camera/Anchor1/Panel2/Button_1b");
		m_ObjOnButton[1] = GameObject.Find(base.gameObject.name + "/Camera/Anchor1/Panel2/Button_2b");
		m_ObjOnButton[2] = GameObject.Find(base.gameObject.name + "/Camera/Anchor1/Panel2/Button_3b");
		m_ObjOnButton[3] = GameObject.Find(base.gameObject.name + "/Camera/Anchor1/Panel2/Button_4b");
		m_ObjOnButton[4] = GameObject.Find(base.gameObject.name + "/Camera/Anchor1/Panel2/Button_5b");
		m_ObjOnButton[5] = GameObject.Find(base.gameObject.name + "/Camera/Anchor1/Panel2/Button_6b");
		m_ObjOnButton[6] = GameObject.Find(base.gameObject.name + "/Camera/Anchor1/Panel2/Button_7b");
		m_Bx_Settei = new BoxCollider[m_ObjOnButton.Length];
		for (int i = 0; i < m_Bx_Settei.Length; i++)
		{
			m_Bx_Settei[i] = GameObject.Find(base.gameObject.name + "/Camera/Anchor1/Panel2/Button_" + (i + 1) + "a").GetComponent<BoxCollider>();
		}
		m_Bx_Back = GameObject.Find(base.gameObject.name + "/Camera/Anchor2/Panel/Button_Back").GetComponent<BoxCollider>();
		m_Bx_Help = GameObject.Find(base.gameObject.name + "/Camera/Anchor2/Panel/Button_Help").GetComponent<BoxCollider>();
		m_Bx_Start = GameObject.Find(base.gameObject.name + "/Camera/Anchor1/Panel2/Button_Start").GetComponent<BoxCollider>();
		on_click_event_settei(SGLGSimConfig.SimSetting);
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
				Object.Instantiate(Resources.Load("prefabs/SimMenu_Top"));
				Object.Destroy(base.gameObject);
				Resources.UnloadUnusedAssets();
			}
			break;
		case 1:
			if (SGLG.isFadeOutComplete())
			{
				SGLG.endFade();
				UISimMenuHelp.SetBackID(8);
				Object.Instantiate(Resources.Load("prefabs/SimMenu_Help"));
				Object.Destroy(base.gameObject);
				Resources.UnloadUnusedAssets();
			}
			break;
		case 4:
			if (m_Dialog_28.isEnd)
			{
				switch (m_Dialog_28.m_DecideID)
				{
				case 0:
					m_IsClick = false;
					m_ClickButtonID = -1;
					break;
				case 1:
					SGLG.startLoading();
					MainGameScene.sndStop();
					m_ClickButtonID = 5;
					break;
				}
				Object.Destroy(m_Dialog_28.gameObject);
				m_Dialog_28 = null;
			}
			break;
		case 5:
			if (SGLG.loading.loadStart)
			{
				SGLGSimConfig.SimSetting = m_Settei;
				Object.Destroy(base.gameObject);
				Resources.UnloadUnusedAssets();
				SGLG.m_Mode = SGLG.MODE.SIM_RESTART;
			}
			break;
		default:
			m_IsClick = false;
			m_ClickButtonID = -1;
			break;
		}
	}

	private void setInput(bool _flag)
	{
		m_Bx_Back.enabled = _flag;
		m_Bx_Help.enabled = _flag;
		m_Bx_Start.enabled = _flag;
		for (int i = 0; i < m_Bx_Settei.Length; i++)
		{
			m_Bx_Settei[i].enabled = _flag;
		}
	}

	public void OnClickEvent_Settei1()
	{
		on_click_event_settei(0);
	}

	public void OnClickEvent_Settei2()
	{
		on_click_event_settei(1);
	}

	public void OnClickEvent_Settei3()
	{
		on_click_event_settei(2);
	}

	public void OnClickEvent_Settei4()
	{
		on_click_event_settei(3);
	}

	public void OnClickEvent_Settei5()
	{
		on_click_event_settei(4);
	}

	public void OnClickEvent_Settei6()
	{
		on_click_event_settei(5);
	}

	public void OnClickEvent_Settei7()
	{
		on_click_event_settei(6);
	}

	private void on_click_event_settei(int settei)
	{
		if (settei == m_Settei)
		{
			return;
		}
		for (int i = 0; i < 7; i++)
		{
			if (i == settei)
			{
				m_ObjOnButton[i].SetActive(true);
			}
			else
			{
				m_ObjOnButton[i].SetActive(false);
			}
		}
		m_Settei = settei;
	}

	private void OnClickEvent_Back()
	{
		if (on_click_button(0))
		{
			SGLG.startFade_Fast();
		}
	}

	private void OnClickEvent_Help()
	{
		if (on_click_button(1))
		{
			SGLG.startFade_Fast();
		}
	}

	private void OnClickEvent_GameStart()
	{
		if (on_click_button(4))
		{
			m_Dialog_28 = SGLG.createDialog(28).GetComponent<UIDialog_28>();
		}
	}

	private bool on_click_button(int button_id)
	{
		if (m_IsClick || SGLG.isFading)
		{
			return false;
		}
		setInput(false);
		m_IsClick = true;
		m_ClickButtonID = button_id;
		return true;
	}
}
