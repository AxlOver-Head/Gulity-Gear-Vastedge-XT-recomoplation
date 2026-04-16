using UnityEngine;

public class UISimMenuTop : MonoBehaviour
{
	private const int BUTTON_ID_NONE = -1;

	private const int BUTTON_ID_BACK = 0;

	private const int BUTTON_ID_HELP = 1;

	private const int BUTTON_ID_AUTOPLAY = 2;

	private const int BUTTON_ID_FORCEFLAG = 3;

	private const int BUTTON_ID_SETTEICHANGE = 4;

	private const int BUTTON_ID_CONFIG = 5;

	private const int BUTTON_ID_ENDGAME = 6;

	private const int GOTO_TITLE = 8;

	private BoxCollider m_Bx_Back;

	private BoxCollider m_Bx_Help;

	private BoxCollider m_Bx_Auto;

	private BoxCollider m_Bx_ForceFlag;

	private BoxCollider m_Bx_Settei;

	private BoxCollider m_Bx_Conf;

	private BoxCollider m_Bx_EndGame;

	private int m_ClickButtonID;

	private bool m_IsClick;

	private UIDialog_27 m_Dialog_27;

	private void Start()
	{
		base.gameObject.name = "SimMenu_Top";
		m_Bx_Back = GameObject.Find("SimMenu_Top/Camera/Anchor2/Panel/Button_Back").GetComponent<BoxCollider>();
		m_Bx_Help = GameObject.Find("SimMenu_Top/Camera/Anchor2/Panel/Button_Help").GetComponent<BoxCollider>();
		m_Bx_Auto = GameObject.Find("SimMenu_Top/Camera/Anchor1/Panel/Button_1_AutoPlay").GetComponent<BoxCollider>();
		m_Bx_ForceFlag = GameObject.Find("SimMenu_Top/Camera/Anchor1/Panel/Button_2_Kyousei").GetComponent<BoxCollider>();
		m_Bx_Settei = GameObject.Find("SimMenu_Top/Camera/Anchor1/Panel/Button_3_SetteiChange").GetComponent<BoxCollider>();
		m_Bx_Conf = GameObject.Find("SimMenu_Top/Camera/Anchor1/Panel/Button_4_Setting").GetComponent<BoxCollider>();
		m_Bx_EndGame = GameObject.Find("SimMenu_Top/Camera/Anchor1/Panel/Button_5_EndGame").GetComponent<BoxCollider>();
		m_ClickButtonID = -1;
		m_IsClick = false;
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
				Object.Destroy(base.gameObject);
				Resources.UnloadUnusedAssets();
				MainGameScene.backFromMenuScene();
			}
			break;
		case 1:
			if (SGLG.isFadeOutComplete())
			{
				SGLG.endFade();
				UISimMenuHelp.SetBackID(3);
				Object.Instantiate(Resources.Load("prefabs/SimMenu_Help"));
				Object.Destroy(base.gameObject);
				Resources.UnloadUnusedAssets();
			}
			break;
		case 2:
			if (SGLG.isFadeOutComplete())
			{
				SGLG.endFade();
				Object.Instantiate(Resources.Load("prefabs/SimMenu_Auto"));
				Object.Destroy(base.gameObject);
				Resources.UnloadUnusedAssets();
			}
			break;
		case 3:
			if (SGLG.isFadeOutComplete())
			{
				SGLG.endFade();
				Object.Instantiate(Resources.Load("prefabs/SimMenu_KyouseiFlag"));
				Object.Destroy(base.gameObject);
				Resources.UnloadUnusedAssets();
			}
			break;
		case 4:
			if (SGLG.isFadeOutComplete())
			{
				SGLG.endFade();
				Object.Instantiate(Resources.Load("prefabs/SimMenu_SetteiChange"));
				Object.Destroy(base.gameObject);
				Resources.UnloadUnusedAssets();
			}
			break;
		case 5:
			if (SGLG.isFadeOutComplete())
			{
				SGLG.endFade();
				Object.Instantiate(Resources.Load("prefabs/SimMenu_Setting"));
				Object.Destroy(base.gameObject);
				Resources.UnloadUnusedAssets();
			}
			break;
		case 6:
			if (m_Dialog_27.isEnd)
			{
				switch (m_Dialog_27.m_DecideID)
				{
				case 0:
					m_IsClick = false;
					m_ClickButtonID = -1;
					break;
				case 1:
					SGLG.startLoading();
					MainGameScene.sndStop();
					m_ClickButtonID = 8;
					break;
				}
				Object.Destroy(m_Dialog_27.gameObject);
				m_Dialog_27 = null;
			}
			break;
		case 8:
			if (SGLG.loading.loadStart)
			{
				MainGameScene.sndStop();
				SGLG.prodAllStop();
				SGLG.pause = false;
				MainGameScene.release();
				SGLG.m_Mode = SGLG.MODE.TITLE;
				Object.Destroy(base.gameObject);
				Resources.UnloadUnusedAssets();
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
		m_Bx_Auto.enabled = _flag;
		m_Bx_ForceFlag.enabled = _flag;
		m_Bx_Settei.enabled = _flag;
		m_Bx_Conf.enabled = _flag;
		m_Bx_EndGame.enabled = _flag;
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

	private void OnClickEvent_AutoPlay()
	{
		if (on_click_button(2))
		{
			SGLG.startFade_Fast();
		}
	}

	private void OnClickEvent_Kyousei()
	{
		if (on_click_button(3))
		{
			SGLG.startFade_Fast();
		}
	}

	private void OnClickEvent_SetteiChange()
	{
		if (on_click_button(4))
		{
			SGLG.startFade_Fast();
		}
	}

	private void OnClickEvent_Config()
	{
		if (on_click_button(5))
		{
			SGLG.startFade_Fast();
		}
	}

	private void OnClickEvent_EndGame()
	{
		if (on_click_button(6))
		{
			m_Dialog_27 = SGLG.createDialog(27).GetComponent<UIDialog_27>();
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
