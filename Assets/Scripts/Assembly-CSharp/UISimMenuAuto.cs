using UnityEngine;

public class UISimMenuAuto : MonoBehaviour
{
	private const int BUTTON_ID_NONE = -1;

	private const int BUTTON_ID_BACK = 0;

	private const int BUTTON_ID_HELP = 1;

	private const int BUTTON_ID_EYESTOP = 2;

	private const int BUTTON_ID_AUTOPLAY = 3;

	private const int BUTTON_ID_PLAYGAME = 4;

	private const int BUTTON_ID_KORYAKU = 5;

	private int m_ClickButtonID;

	private bool m_IsClick;

	private GameObject[] m_ObjEyeStop = new GameObject[2];

	private GameObject[] m_ObjAutoPlay = new GameObject[6];

	private BoxCollider m_Bx_Back;

	private BoxCollider m_Bx_Help;

	private BoxCollider m_Bx_Start;

	private BoxCollider[] m_Bx_Auto;

	private BoxCollider[] m_Bx_Meoshi;

	private static int m_SelAutoPlay;

	private static int m_SelEyeStop;

	private UIDialog_11 m_Dialog_11;

	public static void setFirstData()
	{
		m_SelAutoPlay = Sim_PlayUserData.saveData.m_autoSettei;
		m_SelEyeStop = Sim_PlayUserData.saveData.m_autoLevel;
	}

	private void Start()
	{
		base.gameObject.name = "SimMenu_Auto";
		m_ClickButtonID = -1;
		m_IsClick = false;
		m_ObjEyeStop[0] = GameObject.Find("SimMenu_Auto/Camera/Anchor1/Panel2/Panel_Auto/Button_1");
		m_ObjEyeStop[1] = GameObject.Find("SimMenu_Auto/Camera/Anchor1/Panel2/Panel_Auto/Button_2");
		m_ObjAutoPlay[0] = GameObject.Find("SimMenu_Auto/Camera/Anchor1/Panel2/Panel_Meoshi/Button_1");
		m_ObjAutoPlay[1] = GameObject.Find("SimMenu_Auto/Camera/Anchor1/Panel2/Panel_Meoshi/Button_2");
		m_ObjAutoPlay[2] = GameObject.Find("SimMenu_Auto/Camera/Anchor1/Panel2/Panel_Meoshi/Button_3");
		m_ObjAutoPlay[3] = GameObject.Find("SimMenu_Auto/Camera/Anchor1/Panel2/Panel_Meoshi/Button_4");
		m_ObjAutoPlay[4] = GameObject.Find("SimMenu_Auto/Camera/Anchor1/Panel2/Panel_Meoshi/Button_5");
		m_ObjAutoPlay[5] = GameObject.Find("SimMenu_Auto/Camera/Anchor1/Panel2/Panel_Meoshi/Button_6");
		m_Bx_Back = GameObject.Find("SimMenu_Auto/Camera/Anchor2/Panel/Button_Back").GetComponent<BoxCollider>();
		m_Bx_Help = GameObject.Find("SimMenu_Auto/Camera/Anchor2/Panel/Button_Help").GetComponent<BoxCollider>();
		m_Bx_Start = GameObject.Find("SimMenu_Auto/Camera/Anchor1/Panel2/Button_Start").GetComponent<BoxCollider>();
		m_Bx_Auto = new BoxCollider[m_ObjAutoPlay.Length];
		m_Bx_Meoshi = new BoxCollider[m_ObjEyeStop.Length];
		for (int i = 0; i < m_Bx_Auto.Length; i++)
		{
			m_Bx_Auto[i] = m_ObjAutoPlay[i].GetComponent<BoxCollider>();
		}
		for (int j = 0; j < m_ObjEyeStop.Length; j++)
		{
			m_Bx_Meoshi[j] = m_ObjEyeStop[j].GetComponent<BoxCollider>();
		}
		m_Dialog_11 = null;
		for (int k = 0; k < m_ObjEyeStop.Length; k++)
		{
			m_ObjEyeStop[k].SetActive(m_SelEyeStop == k);
		}
		for (int l = 0; l < m_ObjAutoPlay.Length; l++)
		{
			m_ObjAutoPlay[l].SetActive(m_SelAutoPlay == l);
		}
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
				UISimMenuHelp.SetBackID(4);
				Object.Instantiate(Resources.Load("prefabs/SimMenu_Help"));
				Object.Destroy(base.gameObject);
				Resources.UnloadUnusedAssets();
			}
			break;
		case 2:
			m_ObjEyeStop[m_SelEyeStop].SetActive(false);
			m_SelEyeStop = (m_SelEyeStop + 1) % 2;
			m_ObjEyeStop[m_SelEyeStop].SetActive(true);
			m_IsClick = false;
			m_ClickButtonID = -1;
			break;
		case 3:
			m_ObjAutoPlay[m_SelAutoPlay].SetActive(false);
			m_SelAutoPlay = (m_SelAutoPlay + 1) % 6;
			m_ObjAutoPlay[m_SelAutoPlay].SetActive(true);
			m_IsClick = false;
			m_ClickButtonID = -1;
			break;
		case 4:
			if (SGLG.isFadeOutComplete())
			{
				saveConfig();
				UISimMenuSetting.saveConfig();
				SGLG.endFade();
				Object.Destroy(base.gameObject);
				Resources.UnloadUnusedAssets();
				MainGameScene.backFromMenuScene();
			}
			break;
		case 5:
			if (m_Dialog_11.isEnd)
			{
				Object.Destroy(m_Dialog_11.gameObject);
				m_Dialog_11 = null;
				m_ClickButtonID = -1;
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
		for (int i = 0; i < m_Bx_Auto.Length; i++)
		{
			m_Bx_Auto[i].enabled = _flag;
		}
		for (int j = 0; j < m_ObjEyeStop.Length; j++)
		{
			m_Bx_Meoshi[j].enabled = _flag;
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

	private void OnClickEvent_EyeStop()
	{
		on_click_button(2);
	}

	private void OnClickEvent_AutoPlay()
	{
		on_click_button(3);
	}

	private void OnClickEvent_PlayGame()
	{
		if (on_click_button(4))
		{
			SGLG.startFade_Fast();
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

	public static void saveConfig()
	{
		Sim_PlayUserData.saveData.m_autoLevel = (byte)m_SelEyeStop;
		Sim_PlayUserData.saveData.setAuto((byte)m_SelAutoPlay);
		Sim_PlayUserData.save();
	}
}
