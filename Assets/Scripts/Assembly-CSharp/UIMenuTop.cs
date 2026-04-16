using UnityEngine;

public class UIMenuTop : MonoBehaviour
{
	private const int BUTTON_ID_NONE = -1;

	private const int BUTTON_ID_BACK = 0;

	private const int BUTTON_ID_HELP = 1;

	private const int BUTTON_ID_AUTOPLAY = 2;

	private const int BUTTON_ID_CONFIG = 3;

	private const int BUTTON_ID_SPACEMOVE = 4;

	private const int BUTTON_ID_PAY = 5;

	private const int GOTO_HALL = 6;

	private const int GOTO_SEISAN = 7;

	private const int GOTO_TITLE = 8;

	private BoxCollider m_Bx_Back;

	private BoxCollider m_Bx_Help;

	private BoxCollider m_Bx_Auto;

	private BoxCollider m_Bx_Conf;

	private BoxCollider m_Bx_Move;

	private BoxCollider m_Bx_Pay;

	private UIDialog_10 m_Dialog_10;

	private UIDialog_08 m_Dialog_08;

	private UIDialog_20 m_Dialog_20;

	private int m_ClickButtonID;

	private bool m_IsClick;

	public bool m_FromAdjustment;

	private void Start()
	{
		base.gameObject.name = "Menu_Top";
		m_Bx_Back = GameObject.Find("Menu_Top/Camera/Anchor2/Panel/Button_Back").GetComponent<BoxCollider>();
		m_Bx_Help = GameObject.Find("Menu_Top/Camera/Anchor2/Panel/Button_Help").GetComponent<BoxCollider>();
		m_Bx_Auto = GameObject.Find("Menu_Top/Camera/Anchor1/Panel/Button_AutoPlay").GetComponent<BoxCollider>();
		m_Bx_Conf = GameObject.Find("Menu_Top/Camera/Anchor1/Panel/Button_Setting").GetComponent<BoxCollider>();
		m_Bx_Move = GameObject.Find("Menu_Top/Camera/Anchor1/Panel/Button_Under_Dai").GetComponent<BoxCollider>();
		m_Bx_Pay = GameObject.Find("Menu_Top/Camera/Anchor1/Panel/Button_Under_Sei").GetComponent<BoxCollider>();
		m_ClickButtonID = -1;
		m_IsClick = false;
		setInput(false);
	}

	private void Update()
	{
		if (m_FromAdjustment)
		{
			m_FromAdjustment = false;
			setInput(false);
			m_IsClick = true;
			m_ClickButtonID = 5;
			if (UserData.saveData.game.motiMedals <= 0)
			{
				m_Dialog_20 = SGLG.createDialog(20).GetComponent<UIDialog_20>();
			}
			else
			{
				m_Dialog_08 = SGLG.createDialog(8).GetComponent<UIDialog_08>();
			}
		}
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
				Object.Instantiate(Resources.Load("prefabs/Menu_Help"));
				Resources.UnloadUnusedAssets();
				Object.Destroy(base.gameObject);
			}
			break;
		case 2:
			if (SGLG.isFadeOutComplete())
			{
				SGLG.endFade();
				Object.Instantiate(Resources.Load("prefabs/Menu_Auto"));
				Resources.UnloadUnusedAssets();
				Object.Destroy(base.gameObject);
			}
			break;
		case 3:
			if (SGLG.isFadeOutComplete())
			{
				SGLG.endFade();
				Object.Instantiate(Resources.Load("prefabs/Menu_Setting"));
				Resources.UnloadUnusedAssets();
				Object.Destroy(base.gameObject);
			}
			break;
		case 4:
			if (m_Dialog_10.isEnd)
			{
				if (m_Dialog_10.m_DecideID == 0)
				{
					SGLG.startLoading();
					MainGameScene.sndStop();
					hallContlloer.firstState = hallContlloer._STATE.INIT;
					m_ClickButtonID = 6;
				}
				else
				{
					m_ClickButtonID = -1;
					setInput(true);
				}
				Object.Destroy(m_Dialog_10.gameObject);
			}
			break;
		case 5:
			if (UserData.saveData.game.motiMedals <= 0)
			{
				if (m_Dialog_20.isEnd)
				{
					if (m_Dialog_20.m_DecideID == 0)
					{
						SGLG.DataSendComplete();
						SGLG.startLoading();
						MainGameScene.sndStop();
						m_ClickButtonID = 8;
					}
					else
					{
						m_ClickButtonID = -1;
						setInput(true);
					}
					Object.Destroy(m_Dialog_20.gameObject);
				}
			}
			else if (m_Dialog_08.isEnd)
			{
				if (m_Dialog_08.m_DecideID == 0)
				{
					AdjustmentScene.seisanMode = AdjustmentScene.SEISAN.SEND;
					AdjustmentScene.seisanFrom = AdjustmentScene.FROM.MAIN_NORMAL;
					SGLG.startLoading();
					MainGameScene.sndStop();
					m_ClickButtonID = 7;
				}
				else if (m_Dialog_08.m_DecideID == 1)
				{
					SGLG.DataSaveComplete();
					AdjustmentScene.seisanMode = AdjustmentScene.SEISAN.SAVE;
					AdjustmentScene.seisanFrom = AdjustmentScene.FROM.MAIN_NORMAL;
					SGLG.startLoading();
					MainGameScene.sndStop();
					m_ClickButtonID = 7;
				}
				else
				{
					m_ClickButtonID = -1;
					setInput(true);
				}
				Object.Destroy(m_Dialog_08.gameObject);
			}
			break;
		case 6:
			if (SGLG.loading.loadStart)
			{
				MainGameScene.sndStop();
				SGLG.prodAllStop();
				SGLG.pause = false;
				SGLG.m_Mode = SGLG.MODE.HALL;
				MainGameScene.release();
				Object.Destroy(base.gameObject);
				Resources.UnloadUnusedAssets();
			}
			break;
		case 7:
			if (SGLG.loading.loadStart)
			{
				MainGameScene.sndStop();
				SGLG.prodAllStop();
				SGLG.pause = false;
				MainGameScene.release();
				SGLG.m_Mode = SGLG.MODE.ADJUSTMENT;
				Object.Destroy(base.gameObject);
				Resources.UnloadUnusedAssets();
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
		m_Bx_Conf.enabled = _flag;
		m_Bx_Move.enabled = _flag;
		m_Bx_Pay.enabled = _flag;
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
			UIMenuHelp.SetBackID(0);
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

	private void OnClickEvent_Config()
	{
		if (on_click_button(3))
		{
			SGLG.startFade_Fast();
		}
	}

	private void OnClickEvent_SpaceMove()
	{
		if (on_click_button(4))
		{
			m_Dialog_10 = SGLG.createDialog(10).GetComponent<UIDialog_10>();
		}
	}

	private void OnClickEvent_Pay()
	{
		if (on_click_button(5))
		{
			if (UserData.saveData.game.motiMedals <= 0)
			{
				m_Dialog_20 = SGLG.createDialog(20).GetComponent<UIDialog_20>();
			}
			else
			{
				m_Dialog_08 = SGLG.createDialog(8).GetComponent<UIDialog_08>();
			}
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
