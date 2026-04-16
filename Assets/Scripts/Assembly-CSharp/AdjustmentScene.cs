using UnityEngine;

public class AdjustmentScene : SceneUpdater
{
	public enum SEISAN
	{
		NONE = 0,
		SEND = 1,
		SAVE = 2
	}

	public enum MODE
	{
		CARD = 0,
		RECEIPT = 1,
		LOGIN = 2,
		SEND = 3
	}

	public enum FROM
	{
		NONE = 0,
		MAIN_NORMAL = 1,
		MAIN_FORCE = 2,
		HALL_NORMAL = 3,
		HALL_FORCE = 4
	}

	private enum RESULT
	{
		NONE = 0,
		OK = 1,
		NG = 2,
		ERROR = 3
	}

	public static SEISAN seisanMode;

	public static FROM seisanFrom;

	private static MODE m_Mode;

	private int m_Current;

	private int m_CurrentCnt;

	private GameObject UIRoot_Card;

	private GameObject UIRoot_Receipt;

	private GameObject UIRoot_Login;

	private GameObject UIRoot_Send;

	private AdjustmentCard m_AdjCard;

	private AdjustmentReceipt m_AdjReceipt;

	private AdjustmentLogin m_AdjLogin;

	private AdjustmentSend m_AdjSend;

	private GameObject m_Connect;

	private GameObject m_ConnectWindow;

	private UISprite m_ConnectMes;

	private int m_ConnectCnt;

	private float m_ConnectSize;

	public bool isConnect;

	public bool isSendThrough;

	private RESULT m_LoginResult;

	private RESULT m_SendResult;

	private RESULT m_CommitResult;

	private string m_RedirectLogin = string.Empty;

	private string m_RedirectSend = string.Empty;

	private string m_RedirectCommit = string.Empty;

	public static MODE getMode()
	{
		return m_Mode;
	}

	private void Start()
	{
		SGLG.m_Scene = (AdjustmentScene)base.gameObject.GetComponent("AdjustmentScene");
		UIRoot_Card = GameObject.Find("Seisan_Card");
		UIRoot_Receipt = GameObject.Find("Seisan_Receipt");
		UIRoot_Login = GameObject.Find("Seisan_Login");
		UIRoot_Send = GameObject.Find("Seisan_Send");
		m_Connect = GameObject.Find("Connecting");
		m_ConnectWindow = GameObject.Find("Connecting/Camera/Anchor/Panel");
		m_ConnectMes = GameObject.Find("Connecting/Camera/Anchor/Panel/message").GetComponent<UISprite>();
		m_ConnectCnt = 0;
		m_ConnectSize = m_ConnectWindow.transform.localScale.x;
		isConnect = false;
		isSendThrough = false;
		m_LoginResult = RESULT.NONE;
		m_SendResult = RESULT.NONE;
		m_CommitResult = RESULT.NONE;
		m_RedirectLogin = string.Empty;
		m_RedirectSend = string.Empty;
		m_RedirectCommit = string.Empty;
	}

	public UISprite[] setUISprite(string _base, string[] _name)
	{
		UISprite[] array = new UISprite[_name.Length];
		for (int i = 0; i < _name.Length; i++)
		{
			array[i] = GameObject.Find(_base + _name[i]).GetComponent<UISprite>();
		}
		return array;
	}

	private void setSpriteNum(int keta, int data, UISprite spr, bool erase_zero, string _str)
	{
		int num = 1;
		for (int i = 0; i < keta; i++)
		{
			num *= 10;
		}
		if (erase_zero && Mathf.Abs(data) < num)
		{
			spr.color = new Color(1f, 1f, 1f, 0f);
			return;
		}
		int num2 = data / num % 10;
		if (num2 < 0)
		{
			num2 = -num2;
		}
		spr.spriteName = _str + num2;
	}

	public void setCardSpriteNum(int keta, int data, UISprite spr, bool erase_zero)
	{
		setSpriteNum(keta, data, spr, erase_zero, "screen_num_w_");
	}

	public void setSpriteComma(int data, UISprite spr)
	{
		if (data < 1000)
		{
			spr.color = new Color(1f, 1f, 1f, 0f);
		}
	}

	public void setReceiptSpriteNum(int keta, int data, UISprite spr, bool erase_zero)
	{
		setSpriteNum(keta, data, spr, erase_zero, "receipt_num_b_");
	}

	public void setSendMedalSpriteNum(int keta, int data, UISprite spr, bool erase_zero)
	{
		setSpriteNum(keta, data, spr, erase_zero, "send_num_w_");
	}

	public void setSendDChipSpriteNum(int keta, int data, UISprite spr, bool erase_zero)
	{
		setSpriteNum(keta, data, spr, erase_zero, "send_num_o_");
	}

	public override void init()
	{
		m_AdjCard = new AdjustmentCard(this);
		m_AdjReceipt = new AdjustmentReceipt(this);
		m_AdjLogin = new AdjustmentLogin(this);
		m_AdjSend = new AdjustmentSend(this);
		switch (seisanMode)
		{
		case SEISAN.SEND:
			changeMode(MODE.RECEIPT);
			break;
		case SEISAN.SAVE:
			changeMode(MODE.CARD);
			break;
		}
		SGLG.endLoading();
		m_IsOK = true;
	}

	public void forwardCurrent()
	{
		m_Current++;
		m_CurrentCnt = 0;
	}

	public void setCurrent(int current)
	{
		m_Current = current;
		m_CurrentCnt = 0;
	}

	public void changeMode(MODE mode)
	{
		m_Mode = mode;
		setCurrent(0);
		switch (m_Mode)
		{
		case MODE.CARD:
			UIRoot_Receipt.SetActive(false);
			UIRoot_Card.SetActive(true);
			UIRoot_Login.SetActive(false);
			UIRoot_Send.SetActive(false);
			m_AdjCard.initCard();
			break;
		case MODE.RECEIPT:
			UIRoot_Receipt.SetActive(true);
			UIRoot_Card.SetActive(false);
			UIRoot_Login.SetActive(false);
			UIRoot_Send.SetActive(false);
			m_AdjReceipt.initReceipt();
			break;
		case MODE.LOGIN:
			UIRoot_Receipt.SetActive(false);
			UIRoot_Card.SetActive(false);
			UIRoot_Login.SetActive(true);
			UIRoot_Send.SetActive(false);
			m_AdjLogin.initLogin();
			break;
		case MODE.SEND:
			UIRoot_Receipt.SetActive(false);
			UIRoot_Card.SetActive(false);
			UIRoot_Login.SetActive(false);
			UIRoot_Send.SetActive(true);
			m_AdjSend.initSend();
			break;
		}
		Resources.UnloadUnusedAssets();
		SGLG.endFade();
	}

	public override void control()
	{
		switch (m_Mode)
		{
		case MODE.CARD:
			m_AdjCard.controlCard(m_Current, m_CurrentCnt);
			break;
		case MODE.RECEIPT:
			m_AdjReceipt.controlReceipt(m_Current, m_CurrentCnt);
			break;
		case MODE.LOGIN:
			m_AdjLogin.controlLogin(m_Current, m_CurrentCnt);
			break;
		case MODE.SEND:
			m_AdjSend.controlSend(m_Current, m_CurrentCnt);
			break;
		}
		controlConnect();
		m_CurrentCnt++;
		base.control();
	}

	public override void controlReel()
	{
	}

	public override void controlFrame()
	{
	}

	private void controlConnect()
	{
		float num = 0.2f;
		if (isConnect)
		{
			if (!m_Connect.activeSelf)
			{
				m_Connect.SetActive(true);
			}
			if (m_ConnectSize < 1f)
			{
				m_ConnectCnt = 0;
				m_ConnectSize += num;
				if (m_ConnectSize > 1f)
				{
					m_ConnectSize = 1f;
				}
				m_ConnectWindow.transform.localScale = new Vector3(m_ConnectSize, m_ConnectSize, 1f);
			}
			switch (m_ConnectCnt / 4 % 3)
			{
			case 0:
				m_ConnectMes.spriteName = "dialog_mes_14_1";
				break;
			case 1:
				m_ConnectMes.spriteName = "dialog_mes_14_2";
				break;
			case 2:
				m_ConnectMes.spriteName = "dialog_mes_14_3";
				break;
			}
			m_ConnectCnt++;
		}
		else if (m_ConnectSize > 0.01f)
		{
			m_ConnectCnt = 0;
			m_ConnectSize -= num;
			if (m_ConnectSize < 0.01f)
			{
				m_ConnectSize = 0.01f;
			}
			m_ConnectWindow.transform.localScale = new Vector3(m_ConnectSize, m_ConnectSize, 1f);
		}
		else if (m_Connect.activeSelf)
		{
			m_Connect.SetActive(false);
		}
	}

	public override void keyEvent()
	{
		base.keyEvent();
	}

	private void OnLoginButtonCheckOff()
	{
		if (!SGLG.isFading)
		{
			m_AdjLogin.btnCheckOff();
		}
	}

	private void OnLoginButtonCheckOn()
	{
		if (!SGLG.isFading)
		{
			m_AdjLogin.btnCheckOn();
		}
	}

	private void OnLoginButtonLogin()
	{
		if (!SGLG.isFading)
		{
			m_AdjLogin.btnLogin();
		}
	}

	private void OnLoginButtonTouroku()
	{
		if (!SGLG.isFading)
		{
			m_AdjLogin.btnTouroku();
		}
	}

	private void OnLoginButtonBack()
	{
		if (!SGLG.isFading)
		{
			m_AdjLogin.btnBack();
		}
	}

	private void OnLoginButtonDetail()
	{
		if (!SGLG.isFading)
		{
			m_AdjLogin.btnDetail();
		}
	}

	private void OnSendButtonBack()
	{
		if (!SGLG.isFading)
		{
			m_AdjSend.btnBack();
		}
	}

	private void OnSendButtonDetail()
	{
		if (!SGLG.isFading)
		{
			m_AdjSend.btnDetail();
		}
	}

	private void OnSendButtonSend()
	{
		if (!SGLG.isFading)
		{
			m_AdjSend.btnSend();
		}
	}

	public void startConnectLogin()
	{
		Utility.mailEncryptID(PlayUserData.saveData.getAdd(), 64, 80);
		Utility.mailEncryptPass(PlayUserData.saveData.getPass(), 64, 80);
		string url = SGLG.URL_PHP;
		if (m_RedirectLogin.Length != 0)
		{
			url = m_RedirectLogin;
		}
		m_LoginResult = RESULT.NONE;
		NetUtility.sendLogin(url, base.gameObject, "endConnectLogin");
	}

	public void endConnectLogin()
	{
		GrfNetwork network = SGLG.network;
		bool flag = false;
		if (network.getStatus() == 1)
		{
			string text = NetUtility.redirectURL(network.textUTF8());
			if (text.Length != 0)
			{
				m_RedirectLogin = text;
				m_LoginResult = RESULT.ERROR;
				return;
			}
			m_RedirectLogin = string.Empty;
			if (NetUtility.parseLogin(network.getRecvBuffer()))
			{
				m_LoginResult = RESULT.OK;
			}
			else
			{
				m_LoginResult = RESULT.ERROR;
			}
		}
		else
		{
			m_LoginResult = RESULT.NG;
		}
	}

	public bool isLoginTimeout()
	{
		return m_LoginResult == RESULT.NG;
	}

	public bool isLoginError()
	{
		return m_LoginResult == RESULT.ERROR;
	}

	public bool isLoginSuccess()
	{
		return m_LoginResult == RESULT.OK;
	}

	public void startSend()
	{
		string url = SGLG.URL_PHP;
		if (m_RedirectSend.Length != 0)
		{
			url = m_RedirectSend;
		}
		m_SendResult = RESULT.NONE;
		NetUtility.sendSendPoint(url, base.gameObject, "endConnectSend");
	}

	public void endConnectSend()
	{
		GrfNetwork network = SGLG.network;
		bool flag = false;
		if (network.getStatus() == 1)
		{
			string text = NetUtility.redirectURL(network.textUTF8());
			if (text.Length != 0)
			{
				m_RedirectSend = text;
				m_SendResult = RESULT.ERROR;
				return;
			}
			m_RedirectSend = string.Empty;
			if (NetUtility.parsePoint(network.getRecvBuffer()))
			{
				m_SendResult = RESULT.OK;
			}
			else
			{
				m_SendResult = RESULT.ERROR;
			}
		}
		else
		{
			m_SendResult = RESULT.NG;
		}
	}

	public bool isSendSendSuccess()
	{
		return m_SendResult == RESULT.OK;
	}

	public bool isSendSendFailed()
	{
		return m_SendResult != RESULT.OK && m_SendResult != RESULT.NONE;
	}

	public void startCommit()
	{
		string uRL_PHP = SGLG.URL_PHP;
		if (m_RedirectCommit.Length != 0)
		{
			uRL_PHP = m_RedirectCommit;
		}
		m_CommitResult = RESULT.NONE;
		NetUtility.sendCommitPoint(SGLG.URL_PHP, base.gameObject, "endConnectCommit");
	}

	public void endConnectCommit()
	{
		GrfNetwork network = SGLG.network;
		bool flag = false;
		if (network.getStatus() == 1)
		{
			string text = NetUtility.redirectURL(network.textUTF8());
			if (text.Length != 0)
			{
				m_RedirectCommit = text;
				m_CommitResult = RESULT.ERROR;
				return;
			}
			m_RedirectCommit = string.Empty;
			if (NetUtility.parseCommit(network.getRecvBuffer()))
			{
				m_CommitResult = RESULT.OK;
			}
			else
			{
				m_CommitResult = RESULT.ERROR;
			}
		}
		else
		{
			m_CommitResult = RESULT.NG;
		}
	}

	public bool isSendCommitSuccess()
	{
		return m_CommitResult == RESULT.OK;
	}

	public bool isSendCommitFailed()
	{
		return m_CommitResult != RESULT.OK && m_CommitResult != RESULT.NONE;
	}

	public void startSetGameData()
	{
		string uRL_PHP = SGLG.URL_PHP;
		NetUtility.sendSetGameData(uRL_PHP, null, string.Empty, 0);
	}

	private void OnPushCard()
	{
		m_AdjCard.m_Pushed = true;
	}

	private void OnPushReceipt()
	{
		m_AdjReceipt.m_Pushed = true;
	}
}
