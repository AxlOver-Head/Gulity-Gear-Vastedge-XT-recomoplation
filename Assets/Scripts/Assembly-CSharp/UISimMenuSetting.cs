using UnityEngine;

public class UISimMenuSetting : MonoBehaviour
{
	private const int BUTTON_ID_NONE = -1;

	private const int BUTTON_ID_BACK = 0;

	private const int BUTTON_ID_HELP = 1;

	private const int BUTTON_ID_PUSHORDER = 2;

	private const int BUTTON_ID_REELSPEED = 3;

	private const int BUTTON_ID_REELWAIT = 4;

	private const int BUTTON_ID_REELBLUR = 5;

	private const int BUTTON_ID_DATACOMPACT = 6;

	private const int BUTTON_ID_GAMESTART = 7;

	private int m_ClickButtonID;

	private bool m_IsClick;

	private static int m_PushOrder;

	private static int m_ReelSpeed;

	private static bool m_isReelWait;

	private static bool m_isReelBlur;

	private static bool m_isDataCompact;

	private GameObject[] m_ObjPushOrder = new GameObject[2];

	private GameObject[] m_ObjReelSpeed = new GameObject[3];

	private GameObject[] m_ObjReelWait = new GameObject[2];

	private GameObject[] m_ObjReelBlur = new GameObject[2];

	private GameObject[] m_ObjDataCompact = new GameObject[2];

	private BoxCollider m_Bx_Back;

	private BoxCollider m_Bx_Help;

	private BoxCollider m_Bx_Start;

	private BoxCollider[] m_Bx_PushOrder;

	private BoxCollider[] m_Bx_ReelSpeed;

	private BoxCollider[] m_Bx_ReelWait;

	private BoxCollider[] m_Bx_ReelBlur;

	private BoxCollider[] m_Bx_DataCompact;

	public static void setFirstData()
	{
		m_PushOrder = Sim_PlayUserData.saveData.m_configOshi;
		m_ReelSpeed = Sim_PlayUserData.saveData.m_configReelSpeed;
		m_isReelWait = Sim_PlayUserData.saveData.m_configReelWait == 1;
		m_isReelBlur = Sim_PlayUserData.saveData.m_configReelBlur == 1;
		m_isDataCompact = Sim_PlayUserData.saveData.m_configDataSize == 1;
	}

	private void Start()
	{
		base.gameObject.name = "SimMenu_Setting";
		m_ClickButtonID = -1;
		m_IsClick = false;
		for (int i = 0; i < 2; i++)
		{
			m_ObjPushOrder[i] = GameObject.Find("SimMenu_Setting/Camera/Anchor1/Panel2/Panel_OshiJun/Button_" + (i + 1));
		}
		for (int j = 0; j < 3; j++)
		{
			m_ObjReelSpeed[j] = GameObject.Find("SimMenu_Setting/Camera/Anchor1/Panel2/Panel_ReelSpeed/Button_" + (j + 1));
		}
		for (int k = 0; k < 2; k++)
		{
			m_ObjReelWait[k] = GameObject.Find("SimMenu_Setting/Camera/Anchor1/Panel2/Panel_ReelWait/Button_" + (k + 1));
			m_ObjReelBlur[k] = GameObject.Find("SimMenu_Setting/Camera/Anchor1/Panel2/Panel_ReelBlur/Button_" + (k + 1));
			m_ObjDataCompact[k] = GameObject.Find("SimMenu_Setting/Camera/Anchor1/Panel2/Panel_DataCompact/Button_" + (k + 1));
		}
		m_Bx_Back = GameObject.Find("SimMenu_Setting/Camera/Anchor2/Panel/Button_Back").GetComponent<BoxCollider>();
		m_Bx_Help = GameObject.Find("SimMenu_Setting/Camera/Anchor2/Panel/Button_Help").GetComponent<BoxCollider>();
		m_Bx_Start = GameObject.Find("SimMenu_Setting/Camera/Anchor1/Panel2/Button_Start").GetComponent<BoxCollider>();
		m_Bx_PushOrder = new BoxCollider[m_ObjPushOrder.Length];
		m_Bx_ReelSpeed = new BoxCollider[m_ObjReelSpeed.Length];
		m_Bx_ReelWait = new BoxCollider[m_ObjReelWait.Length];
		m_Bx_ReelBlur = new BoxCollider[m_ObjReelBlur.Length];
		m_Bx_DataCompact = new BoxCollider[m_ObjDataCompact.Length];
		for (int l = 0; l < m_Bx_PushOrder.Length; l++)
		{
			m_Bx_PushOrder[l] = m_ObjPushOrder[l].GetComponent<BoxCollider>();
		}
		for (int m = 0; m < m_Bx_ReelSpeed.Length; m++)
		{
			m_Bx_ReelSpeed[m] = m_ObjReelSpeed[m].GetComponent<BoxCollider>();
		}
		for (int n = 0; n < m_Bx_ReelWait.Length; n++)
		{
			m_Bx_ReelWait[n] = m_ObjReelWait[n].GetComponent<BoxCollider>();
		}
		for (int num = 0; num < m_Bx_ReelBlur.Length; num++)
		{
			m_Bx_ReelBlur[num] = m_ObjReelBlur[num].GetComponent<BoxCollider>();
		}
		for (int num2 = 0; num2 < m_Bx_DataCompact.Length; num2++)
		{
			m_Bx_DataCompact[num2] = m_ObjDataCompact[num2].GetComponent<BoxCollider>();
		}
		setPushOrder(m_PushOrder);
		setReelSpeed(m_ReelSpeed);
		setReelWait(m_isReelWait);
		setReelBlur(m_isReelBlur);
		setDataCompact(m_isDataCompact);
		setInput(false);
	}

	private void setPushOrder(int order)
	{
		for (int i = 0; i < 2; i++)
		{
			m_ObjPushOrder[i].SetActive(i == order);
		}
		m_PushOrder = order;
	}

	private void setReelSpeed(int speed)
	{
		for (int i = 0; i < 3; i++)
		{
			m_ObjReelSpeed[i].SetActive(i == speed);
		}
		m_ReelSpeed = speed;
	}

	private void setReelWait(bool flag)
	{
		for (int i = 0; i < 2; i++)
		{
			m_ObjReelWait[i].SetActive((i != 0) ? flag : (!flag));
		}
		m_isReelWait = flag;
	}

	private void setReelBlur(bool flag)
	{
		for (int i = 0; i < 2; i++)
		{
			m_ObjReelBlur[i].SetActive((i != 0) ? flag : (!flag));
		}
		m_isReelBlur = flag;
	}

	private void setDataCompact(bool flag)
	{
		for (int i = 0; i < 2; i++)
		{
			m_ObjDataCompact[i].SetActive((i != 0) ? flag : (!flag));
		}
		m_isDataCompact = flag;
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
				UISimMenuHelp.SetBackID(6);
				Object.Instantiate(Resources.Load("prefabs/SimMenu_Help"));
				Object.Destroy(base.gameObject);
				Resources.UnloadUnusedAssets();
			}
			break;
		case 2:
			setPushOrder((m_PushOrder + 1) % 2);
			m_IsClick = false;
			m_ClickButtonID = -1;
			break;
		case 3:
			setReelSpeed((m_ReelSpeed + 1) % 3);
			m_IsClick = false;
			m_ClickButtonID = -1;
			break;
		case 4:
			setReelWait(!m_isReelWait);
			m_IsClick = false;
			m_ClickButtonID = -1;
			break;
		case 5:
			setReelBlur(!m_isReelBlur);
			m_IsClick = false;
			m_ClickButtonID = -1;
			break;
		case 6:
			setDataCompact(!m_isDataCompact);
			m_IsClick = false;
			m_ClickButtonID = -1;
			break;
		case 7:
			if (SGLG.isFadeOutComplete())
			{
				UISimMenuAuto.saveConfig();
				saveConfig();
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

	private void OnClickEvent_PushOrder()
	{
		on_click_button(2);
	}

	private void OnClickEvent_ReelSpeed()
	{
		on_click_button(3);
	}

	private void OnClickEvent_ReelWait()
	{
		on_click_button(4);
	}

	private void OnClickEvent_ReelBlur()
	{
		on_click_button(5);
	}

	private void OnClickEvent_DataCompact()
	{
		on_click_button(6);
	}

	private void OnClickEvent_GameStart()
	{
		if (on_click_button(7))
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

	private void setInput(bool _flag)
	{
		m_Bx_Back.enabled = _flag;
		m_Bx_Help.enabled = _flag;
		m_Bx_Start.enabled = _flag;
		for (int i = 0; i < m_Bx_PushOrder.Length; i++)
		{
			m_Bx_PushOrder[i].enabled = _flag;
		}
		for (int j = 0; j < m_Bx_ReelSpeed.Length; j++)
		{
			m_Bx_ReelSpeed[j].enabled = _flag;
		}
		for (int k = 0; k < m_Bx_ReelWait.Length; k++)
		{
			m_Bx_ReelWait[k].enabled = _flag;
		}
		for (int l = 0; l < m_Bx_ReelBlur.Length; l++)
		{
			m_Bx_ReelBlur[l].enabled = _flag;
		}
		for (int m = 0; m < m_Bx_DataCompact.Length; m++)
		{
			m_Bx_DataCompact[m].enabled = _flag;
		}
	}

	public static void saveConfig()
	{
		Sim_PlayUserData.saveData.m_configOshi = (byte)m_PushOrder;
		Sim_PlayUserData.saveData.m_configReelSpeed = (byte)m_ReelSpeed;
		Sim_PlayUserData.saveData.m_configReelWait = (byte)(m_isReelWait ? 1u : 0u);
		Sim_PlayUserData.saveData.m_configReelBlur = (byte)(m_isReelBlur ? 1u : 0u);
		Sim_PlayUserData.saveData.m_configDataSize = (byte)(m_isDataCompact ? 1u : 0u);
		MainGameScene.m_DataPanel.SetDataPanelCompactMode(m_isDataCompact);
		MainGameScene.reelMan.setReelSpeed(m_ReelSpeed);
		MainGameScene.reelMan.setReelBulr(m_isReelBlur);
		Sim_PlayUserData.save();
	}
}
