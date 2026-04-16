using UnityEngine;

public class UISimMenuSetteiChangeFromTitle : MonoBehaviour
{
	private const int BUTTON_ID_NONE = -1;

	private const int BUTTON_ID_BACK = 0;

	private const int BUTTON_ID_HELP = 1;

	private const int BUTTON_ID_ICON = 2;

	private const int BUTTON_ID_PLAYGAME = 4;

	private const int BUTTON_ID_TO_RESETGAME = 5;

	public const int MODE_STAY = 0;

	public const int MODE_TO_HELP = 1;

	public const int MODE_HELP = 2;

	private const float SE_VOL = 0.5f;

	public int mode;

	private int m_ClickButtonID;

	private bool m_IsClick;

	public int m_Settei = -1;

	private GameObject[] m_ObjOnButton = new GameObject[7];

	private BoxCollider[] m_Bx_Settei;

	private BoxCollider m_Bx_Back;

	private BoxCollider m_Bx_Help;

	private BoxCollider m_Bx_Start;

	private UIDialog_30 m_Dialog_30;

	private void Start()
	{
		m_ObjOnButton[0] = GameObject.Find(base.gameObject.name + "/Camera/Anchor2/Panel2/Button_1b");
		m_ObjOnButton[1] = GameObject.Find(base.gameObject.name + "/Camera/Anchor2/Panel2/Button_2b");
		m_ObjOnButton[2] = GameObject.Find(base.gameObject.name + "/Camera/Anchor2/Panel2/Button_3b");
		m_ObjOnButton[3] = GameObject.Find(base.gameObject.name + "/Camera/Anchor2/Panel2/Button_4b");
		m_ObjOnButton[4] = GameObject.Find(base.gameObject.name + "/Camera/Anchor2/Panel2/Button_5b");
		m_ObjOnButton[5] = GameObject.Find(base.gameObject.name + "/Camera/Anchor2/Panel2/Button_6b");
		m_ObjOnButton[6] = GameObject.Find(base.gameObject.name + "/Camera/Anchor2/Panel2/Button_7b");
		m_Bx_Settei = new BoxCollider[m_ObjOnButton.Length];
		for (int i = 0; i < m_Bx_Settei.Length; i++)
		{
			m_Bx_Settei[i] = GameObject.Find(base.gameObject.name + "/Camera/Anchor2/Panel2/Button_" + (i + 1) + "a").GetComponent<BoxCollider>();
		}
		m_Bx_Back = GameObject.Find(base.gameObject.name + "/Camera/Anchor2/Panel/Button_Back").GetComponent<BoxCollider>();
		m_Bx_Help = GameObject.Find(base.gameObject.name + "/Camera/Anchor2/Panel/Button_Help").GetComponent<BoxCollider>();
		m_Bx_Start = GameObject.Find(base.gameObject.name + "/Camera/Anchor2/Panel2/Button_Start").GetComponent<BoxCollider>();
		on_click_event_settei(-9999);
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
				SGLGSimConfig.IsSetteiChangeBack = true;
				Object.Destroy(base.gameObject);
				Resources.UnloadUnusedAssets();
			}
			break;
		case 1:
			if (SGLG.isFadeOutComplete())
			{
				SGLG.endFade();
				UISimMenuHelp.SetBackID(9);
				Object.Instantiate(Resources.Load("prefabs/SimMenu_Help"), new Vector3(0f, 0f, -20f), Quaternion.identity);
				Object.Destroy(base.gameObject);
				Resources.UnloadUnusedAssets();
			}
			break;
		case 4:
			if (SGLG.loading != null)
			{
				if (SGLG.loading.loadStart)
				{
					SGLGSimConfig.SimSetting = m_Settei;
					SGLGSimConfig.IsSetteiChangeGameStart = true;
					Object.Destroy(base.gameObject);
					Resources.UnloadUnusedAssets();
				}
			}
			else if (m_Dialog_30 != null && m_Dialog_30.isEnd)
			{
				Object.Destroy(m_Dialog_30.gameObject);
				m_Dialog_30 = null;
				m_IsClick = false;
				m_ClickButtonID = -1;
				setInput(true);
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
			TitleScene.sndPlay(1, 2, false, 0.5f);
			if (m_Settei < 0)
			{
				m_Dialog_30 = SGLG.createDialog(30).GetComponent<UIDialog_30>();
				return;
			}
			SGLG.startLoading();
			TitleScene.stopBGM();
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
