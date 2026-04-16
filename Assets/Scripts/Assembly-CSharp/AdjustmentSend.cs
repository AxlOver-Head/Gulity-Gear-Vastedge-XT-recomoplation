using UnityEngine;

public class AdjustmentSend
{
	public enum MODE
	{
		WAIT = 0,
		LOGIN = 1,
		TOBROWSE = 2,
		BROWSE = 3,
		TOLOGIN = 4,
		DIALOG12 = 5,
		DIALOG15 = 6,
		DIALOG16 = 7,
		DIALOG17 = 8,
		CONNECT1 = 9,
		CONNECT2 = 10,
		COMPLETE = 11,
		TOTITLE = 12,
		REVIEW = 13
	}

	private const int MEDAL_KORYAKU = 10000;

	private AdjustmentScene parent;

	private BoxCollider m_Bx_Back;

	private BoxCollider m_Bx_Detail;

	private BoxCollider m_Bx_Send;

	private UISprite[] m_Sp_Medal;

	private UISprite[] m_Sp_DChip;

	private UIDialog_12 m_Dialog_12;

	private UIDialog_14 m_Dialog_14;

	private UIDialog_16 m_Dialog_16;

	private UIDialog_17 m_Dialog_17;

	private UIDialog_18 m_Dialog_18;

	public AdjustmentSend(AdjustmentScene _parent)
	{
		string[] name = new string[6] { "Medal/00_001", "Medal/00_010", "Medal/00_100", "Medal/01_000", "Medal/10_000", "Medal/00X000" };
		string[] name2 = new string[7] { "DChip/000_001", "DChip/000_010", "DChip/000_100", "DChip/001_000", "DChip/010_000", "DChip/100_000", "DChip/000X000" };
		parent = _parent;
		string text = "Seisan_Send/Camera/Anchor_Center/Panel/Panel_Window/";
		string text2 = "Seisan_Send/Camera/Anchor_Top/Panel/";
		m_Bx_Back = GameObject.Find(text2 + "Button_Back").GetComponent<BoxCollider>();
		m_Bx_Detail = GameObject.Find(text2 + "Button_Kuwasiku").GetComponent<BoxCollider>();
		m_Bx_Send = GameObject.Find(text + "Button_Send").GetComponent<BoxCollider>();
		m_Sp_Medal = parent.setUISprite(text, name);
		m_Sp_DChip = parent.setUISprite(text, name2);
	}

	public void initSend()
	{
		m_Dialog_12 = null;
		m_Dialog_14 = null;
		m_Dialog_16 = null;
		m_Dialog_17 = null;
		m_Dialog_18 = null;
		setInput(false);
		int num = UserData.saveData.game.motiMedals;
		if (num < 0)
		{
			num = 0;
		}
		if (num > 99999)
		{
			num = 99999;
		}
		parent.setSendMedalSpriteNum(0, num, m_Sp_Medal[0], false);
		parent.setSendMedalSpriteNum(1, num, m_Sp_Medal[1], true);
		parent.setSendMedalSpriteNum(2, num, m_Sp_Medal[2], true);
		parent.setSendMedalSpriteNum(3, num, m_Sp_Medal[3], true);
		parent.setSendMedalSpriteNum(4, num, m_Sp_Medal[4], true);
		parent.setSpriteComma(num, m_Sp_Medal[5]);
		int num2 = num * 5;
		if (num2 < 0)
		{
			num2 = 0;
		}
		if (num2 > 999999)
		{
			num2 = 999999;
		}
		parent.setSendDChipSpriteNum(0, num2, m_Sp_DChip[0], false);
		parent.setSendDChipSpriteNum(1, num2, m_Sp_DChip[1], true);
		parent.setSendDChipSpriteNum(2, num2, m_Sp_DChip[2], true);
		parent.setSendDChipSpriteNum(3, num2, m_Sp_DChip[3], true);
		parent.setSendDChipSpriteNum(4, num2, m_Sp_DChip[4], true);
		parent.setSendDChipSpriteNum(5, num2, m_Sp_DChip[5], true);
		parent.setSpriteComma(num2, m_Sp_DChip[6]);
	}

	public void controlSend(int current, int currentCnt)
	{
		switch (current)
		{
		case 0:
			parent.isSendThrough = true;
			setInput(true);
			if (Input.GetKey(KeyCode.Escape))
			{
				btnBack();
			}
			break;
		case 1:
			parent.isSendThrough = true;
			if (!SGLG.isFading)
			{
				if (!parent.isConnect)
				{
					parent.startConnectLogin();
					parent.isConnect = true;
				}
				if (parent.isLoginTimeout())
				{
					GameObject gameObject = SGLG.createDialog(12);
					m_Dialog_12 = gameObject.GetComponent<UIDialog_12>();
					parent.setCurrent(5);
					parent.isConnect = false;
				}
				else if (parent.isLoginError())
				{
					parent.setCurrent(6);
					parent.isConnect = false;
					SGLG.startFade();
				}
				else if (parent.isLoginSuccess())
				{
					parent.isConnect = false;
					parent.setCurrent(0);
				}
			}
			break;
		case 2:
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
			}
			break;
		case 4:
			if (SGLG.isFadeOutComplete())
			{
				parent.changeMode(AdjustmentScene.MODE.LOGIN);
			}
			break;
		case 5:
			if (m_Dialog_12.isEnd)
			{
				Object.Destroy(m_Dialog_12.gameObject);
				m_Dialog_12 = null;
				btnBack();
			}
			break;
		case 6:
			if (SGLG.isFadeOutComplete())
			{
				parent.changeMode(AdjustmentScene.MODE.LOGIN);
				parent.setCurrent(8);
			}
			break;
		case 7:
			if (m_Dialog_16.isEnd)
			{
				switch (m_Dialog_16.m_DecideID)
				{
				case 0:
					parent.setCurrent(9);
					parent.startSend();
					parent.isConnect = true;
					break;
				case 1:
					setInput(true);
					parent.setCurrent(0);
					break;
				}
				Object.Destroy(m_Dialog_16.gameObject);
				m_Dialog_16 = null;
			}
			break;
		case 8:
			if (m_Dialog_17.isEnd)
			{
				parent.setCurrent(10);
				parent.startCommit();
				parent.isConnect = true;
				Object.Destroy(m_Dialog_17.gameObject);
				m_Dialog_17 = null;
			}
			break;
		case 9:
			if (parent.isSendSendFailed())
			{
				m_Dialog_16 = SGLG.createDialog(16).GetComponent<UIDialog_16>();
				parent.setCurrent(7);
				parent.isConnect = false;
			}
			else if (parent.isSendSendSuccess())
			{
				PlayUserData.saveData.m_seisanComitFlag = 1;
				PlayUserData.save();
				parent.setCurrent(10);
				parent.startCommit();
			}
			break;
		case 10:
			if (parent.isSendCommitFailed())
			{
				m_Dialog_17 = SGLG.createDialog(17).GetComponent<UIDialog_17>();
				parent.setCurrent(8);
				parent.isConnect = false;
			}
			else if (parent.isSendCommitSuccess())
			{
				PlayUserData.saveData.m_seisanRuiMai += UserData.saveData.game.motiMedals;
				PlayUserData.saveData.m_seisanComitFlag = 0;
				if (PlayUserData.saveData.m_seisanRuiMai >= 10000)
				{
					PlayUserData.saveData.m_kouryakuFlag = 1;
				}
				PlayUserData.save();
				if (UserData.saveData.hall.sendMedalsFist == 0)
				{
					UserData.saveData.hall.sendMedalsFist = 1;
				}
				SGLG.DataSendComplete();
				parent.setCurrent(11);
				parent.isConnect = false;
				parent.startSetGameData();
				m_Dialog_14 = SGLG.createDialog(14).GetComponent<UIDialog_14>();
			}
			break;
		case 11:
			if (m_Dialog_14.isEnd)
			{
				Object.Destroy(m_Dialog_14.gameObject);
				m_Dialog_14 = null;
				if (PlayUserData.saveData.m_reviewFlag == 0)
				{
					m_Dialog_18 = SGLG.createDialog(18).GetComponent<UIDialog_18>();
					parent.setCurrent(13);
				}
				else
				{
					parent.setCurrent(12);
					SGLG.startLoading();
				}
			}
			break;
		case 12:
			if (SGLG.loading.loadStart)
			{
				SGLG.m_Mode = SGLG.MODE.TITLE;
			}
			break;
		case 13:
			if (m_Dialog_18.isEnd)
			{
				switch (m_Dialog_18.m_DecideID)
				{
				case 0:
					PlayUserData.saveData.m_reviewFlag = 1;
					PlayUserData.save();
					UserData.saveData.hall.reviewTap = true;
					UserData.save();
					Application.OpenURL(SGLG.URL_REVIEW);
					break;
				case 2:
					PlayUserData.saveData.m_reviewFlag = 2;
					PlayUserData.save();
					UserData.saveData.hall.reviewTap = true;
					UserData.save();
					Application.OpenURL(SGLG.URL_REVIEW);
					break;
				case 3:
					PlayUserData.saveData.m_reviewFlag = 2;
					PlayUserData.save();
					break;
				}
				Object.Destroy(m_Dialog_18.gameObject);
				m_Dialog_18 = null;
				parent.setCurrent(12);
				SGLG.startLoading();
			}
			break;
		}
	}

	public void setInput(bool _flag)
	{
		m_Bx_Back.enabled = _flag;
		m_Bx_Detail.enabled = _flag;
		m_Bx_Send.enabled = _flag;
	}

	public void btnBack()
	{
		parent.setCurrent(4);
		setInput(false);
		SGLG.startFade();
	}

	public void btnDetail()
	{
		parent.setCurrent(2);
		setInput(false);
		SGLG.startFade();
	}

	public void btnSend()
	{
		PlayUserData.saveData.transactionID++;
		if (PlayUserData.saveData.transactionID > 999999999)
		{
			PlayUserData.saveData.transactionID = 0;
		}
		PlayUserData.save();
		if (PlayUserData.saveData.m_seisanComitFlag == 1)
		{
			parent.setCurrent(10);
			parent.startCommit();
		}
		else
		{
			parent.setCurrent(9);
			parent.startSend();
		}
		setInput(false);
		parent.isConnect = true;
	}
}
