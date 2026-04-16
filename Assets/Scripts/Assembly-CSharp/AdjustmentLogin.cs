using UnityEngine;

public class AdjustmentLogin
{
	public enum MODE
	{
		WAIT = 0,
		CONNECT = 1,
		TOBROWSE = 2,
		BROWSE = 3,
		DIALOG12 = 4,
		DIALOG15 = 5,
		DIALOG15_RE = 6,
		TOSEND = 7,
		SENDTOLOGIN = 8,
		BACK = 9
	}

	private AdjustmentScene parent;

	private UIInput m_Ip_ID;

	private UIInput m_Ip_Pass;

	private GameObject m_CheckOn;

	private GameObject m_CheckOff;

	private BoxCollider m_Bx_CheckOn;

	private BoxCollider m_Bx_CheckOff;

	private BoxCollider m_Bx_Back;

	private BoxCollider m_Bx_Detail;

	private BoxCollider m_Bx_Login;

	private BoxCollider m_Bx_Sign;

	private bool m_Checked;

	private UIDialog_12 m_Dialog_12;

	private UIDialog_15_re m_Dialog_15_re;

	public AdjustmentLogin(AdjustmentScene _parent)
	{
		parent = _parent;
		string text = "Seisan_Login/Camera/Anchor_Center/Panel/Panel_Window/";
		string text2 = "Seisan_Login/Camera/Anchor_Center/PanelBG/";
		string text3 = "Seisan_Login/Camera/Anchor_Top/Panel/";
		m_Ip_ID = GameObject.Find(text + "Box_ID").GetComponent<UIInput>();
		m_Ip_Pass = GameObject.Find(text + "Box_Pass").GetComponent<UIInput>();
		m_CheckOn = GameObject.Find(text + "Check_ON");
		m_CheckOff = GameObject.Find(text + "Check_OFF");
		m_Bx_CheckOn = GameObject.Find(text + "Check_ON").GetComponent<BoxCollider>();
		m_Bx_CheckOff = GameObject.Find(text + "Check_OFF").GetComponent<BoxCollider>();
		m_Bx_Back = GameObject.Find(text3 + "Button_Back").GetComponent<BoxCollider>();
		m_Bx_Detail = GameObject.Find(text3 + "Button_Kuwasiku").GetComponent<BoxCollider>();
		m_Bx_Login = GameObject.Find(text + "Button_Login").GetComponent<BoxCollider>();
		m_Bx_Sign = GameObject.Find(text2 + "Button_Touroku").GetComponent<BoxCollider>();
	}

	public void initLogin()
	{
		setInput(false);
		string add = PlayUserData.saveData.getAdd();
		string pass = PlayUserData.saveData.getPass();
		m_Ip_ID.text = add;
		m_Ip_Pass.text = pass;
		m_Dialog_12 = null;
		m_Dialog_15_re = null;
		if (PlayUserData.saveData.m_loginFlag == 1)
		{
			m_CheckOn.SetActive(true);
			m_CheckOff.SetActive(false);
			m_Checked = true;
			if (!parent.isSendThrough)
			{
				parent.changeMode(AdjustmentScene.MODE.SEND);
				parent.setCurrent(1);
			}
		}
		else
		{
			m_CheckOn.SetActive(false);
			m_CheckOff.SetActive(true);
			m_Checked = false;
		}
	}

	public void controlLogin(int current, int currentCnt)
	{
		switch (current)
		{
		case 0:
			m_Ip_ID.GetComponent<Collider>().enabled = true;
			m_Ip_Pass.GetComponent<Collider>().enabled = true;
			setInput(true);
			if (Input.GetKey(KeyCode.Escape))
			{
				btnBack();
			}
			break;
		case 1:
			m_Ip_ID.GetComponent<Collider>().enabled = false;
			m_Ip_Pass.GetComponent<Collider>().enabled = false;
			if (parent.isLoginTimeout())
			{
				GameObject gameObject2 = SGLG.createDialog(12);
				m_Dialog_12 = gameObject2.GetComponent<UIDialog_12>();
				parent.setCurrent(4);
				parent.isConnect = false;
				m_Ip_ID.GetComponent<Collider>().enabled = false;
				m_Ip_Pass.GetComponent<Collider>().enabled = false;
			}
			else if (parent.isLoginError())
			{
				setInput(false);
				GameObject gameObject3 = (GameObject)Object.Instantiate(Resources.Load("Dialog_15_re"), new Vector3(50000f, 50000f, 0f), Quaternion.identity);
				m_Dialog_15_re = gameObject3.GetComponent<UIDialog_15_re>();
				parent.setCurrent(6);
				parent.isConnect = false;
				m_Ip_Pass.text = string.Empty;
				m_Ip_ID.GetComponent<Collider>().enabled = false;
				m_Ip_Pass.GetComponent<Collider>().enabled = false;
			}
			else if (parent.isLoginSuccess())
			{
				setInput(false);
				if (m_Checked)
				{
					PlayUserData.saveData.m_loginFlag = 1;
					PlayUserData.save();
				}
				SGLG.startFade();
				parent.setCurrent(7);
				parent.isConnect = false;
			}
			break;
		case 2:
			m_Ip_ID.GetComponent<Collider>().enabled = false;
			m_Ip_Pass.GetComponent<Collider>().enabled = false;
			if (SGLG.isFadeOutComplete())
			{
				SGLG.launchWebBrowser(SGLG.URL_ADJUSTMENT_DETAIL + PlayUserData.saveData.getUnique());
				SGLG.endFade();
				parent.setCurrent(3);
			}
			break;
		case 3:
			if (!SGLG.isBrowsing)
			{
				setInput(true);
				parent.setCurrent(0);
				m_Ip_ID.GetComponent<Collider>().enabled = true;
				m_Ip_Pass.GetComponent<Collider>().enabled = true;
			}
			break;
		case 4:
			if (m_Dialog_12.isEnd)
			{
				Object.Destroy(m_Dialog_12.gameObject);
				m_Dialog_12 = null;
				setInput(true);
				parent.setCurrent(0);
				m_Ip_ID.GetComponent<Collider>().enabled = true;
				m_Ip_Pass.GetComponent<Collider>().enabled = true;
			}
			break;
		case 6:
			if (m_Dialog_15_re.isEnd)
			{
				int decideID = m_Dialog_15_re.m_DecideID;
				Object.Destroy(m_Dialog_15_re.gameObject);
				m_Dialog_15_re = null;
				setInput(true);
				parent.setCurrent(0);
				if (decideID == 1)
				{
					Application.OpenURL("http://d777.jp/Portal.php");
				}
				m_Ip_ID.GetComponent<Collider>().enabled = true;
				m_Ip_Pass.GetComponent<Collider>().enabled = true;
			}
			break;
		case 7:
			if (SGLG.isFadeOutComplete())
			{
				parent.changeMode(AdjustmentScene.MODE.SEND);
			}
			break;
		case 8:
		{
			GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("Dialog_15_re"), new Vector3(50000f, 50000f, 0f), Quaternion.identity);
			m_Dialog_15_re = gameObject.GetComponent<UIDialog_15_re>();
			parent.setCurrent(6);
			parent.isConnect = false;
			m_Ip_Pass.text = string.Empty;
			m_Ip_ID.GetComponent<Collider>().enabled = false;
			m_Ip_Pass.GetComponent<Collider>().enabled = false;
			break;
		}
		case 9:
			if (SGLG.loading.loadStart)
			{
				switch (AdjustmentScene.seisanFrom)
				{
				case AdjustmentScene.FROM.MAIN_NORMAL:
					MainGameScene.backFrom = MainGameScene.FROM.ADJ_NORMAL;
					SGLG.m_Mode = SGLG.MODE.MAIN;
					break;
				case AdjustmentScene.FROM.MAIN_FORCE:
					MainGameScene.backFrom = MainGameScene.FROM.ADJ_FORCE;
					SGLG.m_Mode = SGLG.MODE.MAIN;
					break;
				case AdjustmentScene.FROM.HALL_NORMAL:
					hallContlloer.firstState = hallContlloer._STATE.GAME_END_ADJIS;
					SGLG.m_Mode = SGLG.MODE.HALL;
					SGLG.endLoading();
					break;
				case AdjustmentScene.FROM.HALL_FORCE:
					hallContlloer.firstState = hallContlloer._STATE.GAME_END_FORCE;
					SGLG.m_Mode = SGLG.MODE.HALL;
					SGLG.endLoading();
					break;
				}
			}
			break;
		case 5:
			break;
		}
	}

	public void setInput(bool _flag)
	{
		m_Bx_CheckOn.enabled = _flag;
		m_Bx_CheckOff.enabled = _flag;
		m_Bx_Back.enabled = _flag;
		m_Bx_Detail.enabled = _flag;
		m_Bx_Login.enabled = _flag;
		m_Bx_Sign.enabled = _flag;
	}

	public void btnCheckOff()
	{
		m_Checked = false;
		m_CheckOn.SetActive(true);
		m_CheckOff.SetActive(false);
	}

	public void btnCheckOn()
	{
		if (PlayUserData.saveData.m_loginFlag != 1)
		{
			m_Checked = true;
			m_CheckOn.SetActive(false);
			m_CheckOff.SetActive(true);
		}
	}

	public void btnLogin()
	{
		setInput(false);
		if (m_Ip_ID.label.text == string.Empty || m_Ip_Pass.label.text == string.Empty)
		{
			GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("Dialog_15_re"), new Vector3(50000f, 50000f, 0f), Quaternion.identity);
			m_Dialog_15_re = gameObject.GetComponent<UIDialog_15_re>();
			parent.setCurrent(6);
			m_Ip_ID.GetComponent<Collider>().enabled = false;
			m_Ip_Pass.GetComponent<Collider>().enabled = false;
		}
		else
		{
			PlayUserData.saveData.setAdd(m_Ip_ID.label.text);
			PlayUserData.saveData.setPass(m_Ip_Pass.label.text);
			PlayUserData.save();
			parent.setCurrent(1);
			parent.startConnectLogin();
			parent.isConnect = true;
		}
	}

	public void btnTouroku()
	{
		Application.OpenURL(SGLG.URL_ADJUSTMENT_TOUROKU);
	}

	public void btnBack()
	{
		setInput(false);
		switch (AdjustmentScene.seisanFrom)
		{
		case AdjustmentScene.FROM.NONE:
			setInput(true);
			break;
		case AdjustmentScene.FROM.MAIN_NORMAL:
			SGLG.startLoading();
			parent.setCurrent(9);
			break;
		case AdjustmentScene.FROM.MAIN_FORCE:
			SGLG.startLoading();
			parent.setCurrent(9);
			break;
		case AdjustmentScene.FROM.HALL_NORMAL:
			SGLG.startLoading();
			parent.setCurrent(9);
			break;
		case AdjustmentScene.FROM.HALL_FORCE:
			SGLG.startLoading();
			parent.setCurrent(9);
			break;
		}
	}

	public void btnDetail()
	{
		setInput(false);
		parent.setCurrent(2);
		SGLG.startFade();
	}
}
