using UnityEngine;

public class UIMenuHelp : MonoBehaviour
{
	private const int BUTTON_ID_NONE = -1;

	private const int BUTTON_ID_BACK = 0;

	private const int BUTTON_ID_MANUAL = 1;

	private const int BUTTON_ID_INFO = 2;

	private const int BUTTON_ID_WEBTO = 3;

	private const int BUTTON_ID_BROWSE = 4;

	public const int BACK_ID_TOP = 0;

	public const int BACK_ID_AUTOPLAY = 1;

	public const int BACK_ID_SETTING = 2;

	private BoxCollider m_Bx_Back;

	private BoxCollider m_Bx_Kisyu;

	private BoxCollider m_Bx_Motto;

	private BoxCollider m_Bx_Sousa;

	private int m_ClickButtonID;

	private bool m_IsClick;

	private UILabel m_UDID;

	private static int m_BackID;

	private void Start()
	{
		base.gameObject.name = "Menu_Help";
		m_ClickButtonID = -1;
		m_IsClick = false;
		m_Bx_Back = GameObject.Find("Menu_Help/Camera/Anchor2/Panel/Button_Back").GetComponent<BoxCollider>();
		m_Bx_Kisyu = GameObject.Find("Menu_Help/Camera/Anchor1/Panel/Button_Kisyu").GetComponent<BoxCollider>();
		m_Bx_Motto = GameObject.Find("Menu_Help/Camera/Anchor1/Panel/Button_Motto").GetComponent<BoxCollider>();
		m_Bx_Sousa = GameObject.Find("Menu_Help/Camera/Anchor1/Panel/Button_Sousa").GetComponent<BoxCollider>();
		m_UDID = GameObject.Find("Menu_Help/Camera/Anchor3/Panel/UDID").GetComponent<UILabel>();
		m_UDID.text = string.Empty;
		if (PlayUserData.saveData.getUnique() != string.Empty)
		{
			m_UDID.text = "ID:" + PlayUserData.saveData.getUnique();
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
				switch (m_BackID)
				{
				case 0:
					Object.Instantiate(Resources.Load("prefabs/Menu_Top"));
					break;
				case 1:
					Object.Instantiate(Resources.Load("prefabs/Menu_Auto"));
					break;
				case 2:
					Object.Instantiate(Resources.Load("prefabs/Menu_Setting"));
					break;
				}
				Object.Destroy(base.gameObject);
				Resources.UnloadUnusedAssets();
			}
			break;
		case 1:
			if (SGLG.isFadeOutComplete())
			{
				SGLG.endFade();
				Object.Instantiate(Resources.Load("prefabs/Menu_Sousa"));
				Object.Destroy(base.gameObject);
				Resources.UnloadUnusedAssets();
			}
			break;
		case 2:
			if (SGLG.isFadeOutComplete())
			{
				SGLG.endFade();
				Object.Instantiate(Resources.Load("prefabs/Menu_Kisyu"));
				Object.Destroy(base.gameObject);
				Resources.UnloadUnusedAssets();
			}
			break;
		case 3:
			if (SGLG.isFadeOutComplete())
			{
				SGLG.endFade();
				SGLG.launchWebBrowser(SGLG.URL_MENU_DETAIL + PlayUserData.saveData.getUnique());
				m_ClickButtonID = 4;
				MainGameScene.sndStop();
			}
			break;
		case 4:
			if (!SGLG.isBrowsing)
			{
				SGLG.endFade();
				m_ClickButtonID = -1;
				MainGameScene.sndStop();
				MainGameScene.sndPlay(0, 7, true, 1f);
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

	private void OnClickEvent_Manual()
	{
		if (on_click_button(1))
		{
			SGLG.startFade_Fast();
		}
	}

	private void OnClickEvent_Info()
	{
		if (on_click_button(2))
		{
			SGLG.startFade_Fast();
		}
	}

	private void OnClickEvent_Webto()
	{
		if (on_click_button(3))
		{
			SGLG.startFade_Fast();
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

	public static void SetBackID(int id)
	{
		m_BackID = id;
	}

	private void setInput(bool _flag)
	{
		m_Bx_Back.enabled = _flag;
		m_Bx_Kisyu.enabled = _flag;
		m_Bx_Motto.enabled = _flag;
		m_Bx_Sousa.enabled = _flag;
	}
}
