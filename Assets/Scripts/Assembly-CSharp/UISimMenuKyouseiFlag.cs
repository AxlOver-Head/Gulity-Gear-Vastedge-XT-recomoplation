using UnityEngine;

public class UISimMenuKyouseiFlag : MonoBehaviour
{
	private const int BUTTON_ID_NONE = -1;

	private const int BUTTON_ID_BACK = 0;

	private const int BUTTON_ID_HELP = 1;

	private const int BUTTON_ID_PLAYGAME = 4;

	private int m_ClickButtonID;

	private bool m_IsClick;

	private GameObject[,] m_ObjButton = new GameObject[16, 3];

	private BoxCollider m_Bx_Back;

	private BoxCollider m_Bx_Help;

	private BoxCollider m_Bx_Start;

	private BoxCollider[] m_Bx_Button = new BoxCollider[16];

	private int m_NowIcon;

	private int m_ClickIconNo = -1;

	private bool[] m_IsIconSelect = new bool[16];

	private void Start()
	{
		base.gameObject.name = "SimMenu_KyouseiFlag";
		for (int i = 0; i < 16; i++)
		{
			m_ObjButton[i, 0] = GameObject.Find("SimMenu_KyouseiFlag/Camera/Anchor1/Panel2/Button_" + i.ToString("00") + "/Button_a");
			m_ObjButton[i, 1] = GameObject.Find("SimMenu_KyouseiFlag/Camera/Anchor1/Panel2/Button_" + i.ToString("00") + "/Button_b");
			m_ObjButton[i, 2] = GameObject.Find("SimMenu_KyouseiFlag/Camera/Anchor1/Panel2/Button_" + i.ToString("00") + "/Button_c");
		}
		m_Bx_Back = GameObject.Find("SimMenu_KyouseiFlag/Camera/Anchor2/Panel/Button_Back").GetComponent<BoxCollider>();
		m_Bx_Help = GameObject.Find("SimMenu_KyouseiFlag/Camera/Anchor2/Panel/Button_Help").GetComponent<BoxCollider>();
		m_Bx_Start = GameObject.Find("SimMenu_KyouseiFlag/Camera/Anchor1/Panel2/Button_Start").GetComponent<BoxCollider>();
		for (int j = 0; j < 16; j++)
		{
			m_Bx_Button[j] = m_ObjButton[j, 0].GetComponent<BoxCollider>();
		}
		for (int k = 0; k < 16; k++)
		{
			m_IsIconSelect[k] = KoyakuFlag.isKoyakuActive(k);
		}
		m_ClickButtonID = -1;
		m_IsClick = false;
		m_NowIcon = -1;
		updateIcon(0);
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
				UISimMenuHelp.SetBackID(7);
				Object.Instantiate(Resources.Load("prefabs/SimMenu_Help"));
				Object.Destroy(base.gameObject);
				Resources.UnloadUnusedAssets();
			}
			break;
		case 4:
			if (SGLG.isFadeOutComplete())
			{
				SGLGSimConfig.SelectForceFlagNo = m_NowIcon;
				UISimMenuAuto.saveConfig();
				UISimMenuSetting.saveConfig();
				SGLG.endFade();
				Object.Destroy(base.gameObject);
				Resources.UnloadUnusedAssets();
				MainGameScene.backFromMenuScene();
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
		for (int i = 0; i < 16; i++)
		{
			m_Bx_Button[i].enabled = _flag;
		}
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
			SGLG.startFade_Fast();
		}
	}

	private void OnClickEvent_Settei0()
	{
		on_click_settei(0);
	}

	private void OnClickEvent_Settei1()
	{
		on_click_settei(1);
	}

	private void OnClickEvent_Settei2()
	{
		on_click_settei(2);
	}

	private void OnClickEvent_Settei3()
	{
		on_click_settei(3);
	}

	private void OnClickEvent_Settei4()
	{
		on_click_settei(4);
	}

	private void OnClickEvent_Settei5()
	{
		on_click_settei(5);
	}

	private void OnClickEvent_Settei6()
	{
		on_click_settei(6);
	}

	private void OnClickEvent_Settei7()
	{
		on_click_settei(7);
	}

	private void OnClickEvent_Settei8()
	{
		on_click_settei(8);
	}

	private void OnClickEvent_Settei9()
	{
		on_click_settei(9);
	}

	private void OnClickEvent_Settei10()
	{
		on_click_settei(10);
	}

	private void OnClickEvent_Settei11()
	{
		on_click_settei(11);
	}

	private void OnClickEvent_Settei12()
	{
		on_click_settei(12);
	}

	private void OnClickEvent_Settei13()
	{
		on_click_settei(13);
	}

	private void OnClickEvent_Settei14()
	{
		on_click_settei(14);
	}

	private void OnClickEvent_Settei15()
	{
		on_click_settei(15);
	}

	private void on_click_settei(int button)
	{
		m_ClickIconNo = button;
		updateIcon(m_ClickIconNo);
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

	private void updateIcon(int icon)
	{
		for (int i = 0; i < 16; i++)
		{
			if (!m_IsIconSelect[i])
			{
				set_icon(i, 2);
			}
			else if (i == icon)
			{
				set_icon(i, 1);
				m_NowIcon = icon;
			}
			else
			{
				set_icon(i, 0);
			}
		}
	}

	private void set_icon(int icon, int state)
	{
		for (int i = 0; i < 3; i++)
		{
			m_ObjButton[icon, i].SetActive(state == i);
		}
	}
}
