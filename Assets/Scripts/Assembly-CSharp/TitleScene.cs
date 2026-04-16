using UnityEngine;

public class TitleScene : SceneUpdater
{
	public enum MODE
	{
		FADEIN = 0,
		STAY = 1,
		UNIQUE = 2,
		UNIQUERETRY = 3,
		TOHALL = 4,
		HALL = 5,
		TOBROWSE = 6,
		BROWSESTART = 7,
		BROWSE = 8,
		DIALOG03 = 9,
		DIALOG22 = 10,
		DIALOG16 = 11,
		COMMIT = 12,
		COMPLETE = 13,
		APP_END = 14,
		GAMEDATA = 15,
		DIALOG16_GAMEDATA = 16,
		DIALOG24 = 17,
		DIALOG25 = 18,
		TO_SIM_SETTEI = 19,
		SIM_SETTEI = 20,
		TO_TITLE = 21,
		DIALOGSTART = 22,
		DIALOGSTART2 = 23,
		DIALOGSTART3 = 24,
		DIALOGSTART4 = 25
	}

	private enum RESULT
	{
		NONE = 0,
		OK = 1,
		NG = 2,
		ERROR = 3
	}

	private const float SE_VOL = 0.5f;

	private bool m_IsGameStart;

	private bool m_IsEnjoyMore;

	private bool m_IsSimulationMode;

	private MODE m_Current;

	private int m_CurrentCnt;

	private static GGLSound snd;

	private GameObject m_Title;

	private BoxCollider m_ButtonCol_1;

	private BoxCollider m_ButtonCol_2;

	private BoxCollider m_ButtonCol_3;

	private UIDialog_03 m_Dialog_03;

	private UIDialog_22 m_Dialog_22;

	private UIDialog_16 m_Dialog_16;

	private UIDialog_start m_Dialog_start;

	private UIDialog_start2 m_Dialog_start2;

	private UIDialog_start3 m_Dialog_start3;

	private UIDialog_start4 m_Dialog_start4;

	private GameObject m_Connect;

	private GameObject m_ConnectWindow;

	private UISprite m_ConnectMes;

	private int m_ConnectCnt;

	private float m_ConnectSize;

	public bool isConnect;

	private RESULT m_UniqueResult;

	private RESULT m_CommitResult;

	private RESULT m_GameDataResult;

	private string m_RedirectUnique = string.Empty;

	private string m_RedirectCommit = string.Empty;

	private string m_RedirectGameData = string.Empty;

	private UIDialog_04 m_Dialog_04;

	private UIDialog_24 m_Dialog_24;

	private UIDialog_25 m_Dialog_25;

	private int m_InitGameStart = 1;

	private string INITGAMESTART_PREF_KEY = "initgamestart";

	private void Start()
	{
		SGLG.m_Scene = (TitleScene)base.gameObject.GetComponent("TitleScene");
		m_ButtonCol_1 = GameObject.Find("Title/Camera/Anchor/Panel/GameStart").GetComponent<BoxCollider>();
		m_ButtonCol_2 = GameObject.Find("Title/Camera/Anchor/Panel/EnjoyMore").GetComponent<BoxCollider>();
		m_ButtonCol_3 = GameObject.Find("Title/Camera/Anchor/Panel/SimulationMode").GetComponent<BoxCollider>();
		m_Connect = GameObject.Find("Connecting");
		m_ConnectWindow = GameObject.Find("Connecting/Camera/Anchor/Panel");
		m_ConnectMes = GameObject.Find("Connecting/Camera/Anchor/Panel/message").GetComponent<UISprite>();
		m_ConnectCnt = 0;
		m_ConnectSize = m_ConnectWindow.transform.localScale.x;
		isConnect = false;
		SGLGSimConfig.IsFromTitle = true;
	}

	public override void init()
	{
		m_IsGameStart = false;
		m_IsEnjoyMore = false;
		m_IsSimulationMode = false;
		m_CurrentCnt = 0;
		m_Dialog_03 = null;
		m_Dialog_22 = null;
		m_Dialog_16 = null;
		m_Dialog_start = null;
		m_Dialog_start2 = null;
		m_Dialog_start3 = null;
		m_Dialog_start4 = null;
		snd = GetComponent<GGLSound>();
		snd.loadSoundFiles();
		snd.stopAll();
		sndPlay(0, 1, true, 1f);
		m_Title = GameObject.Find("Title");
		m_UniqueResult = RESULT.NONE;
		m_UniqueResult = RESULT.NONE;
		m_RedirectUnique = string.Empty;
		m_RedirectCommit = string.Empty;
		m_InitGameStart = 1;
		m_InitGameStart = 0;
		PlayerPrefs.SetInt(INITGAMESTART_PREF_KEY, m_InitGameStart);
		SGLG.endLoading();
		SGLG.endFade();
		m_IsOK = true;
	}

	public static void sndPlay(int ch, int playID, bool loop, float volume)
	{
		snd.setData(ch, playID);
		snd.play(ch);
		snd.setLoop(ch, loop);
		snd.setVolume(ch, volume);
	}

	public static void stopBGM()
	{
		snd.stop(0);
	}

	public static void playBGM()
	{
		snd.setData(0, 1);
		snd.play(0);
		snd.setLoop(0, true);
		snd.setVolume(0, 1f);
	}

	private void setCurrent(MODE current)
	{
		m_Current = current;
		m_CurrentCnt = 0;
	}

	public override void control()
	{
		switch (m_Current)
		{
		case MODE.FADEIN:
			if (!PlayerPrefs.HasKey(INITGAMESTART_PREF_KEY))
			{
				setInput(false);
				GameObject gameObject8 = (GameObject)Object.Instantiate(Resources.Load("Dialog_start"), new Vector3(50000f, 50000f, 0f), Quaternion.identity);
				m_Dialog_start = gameObject8.GetComponent<UIDialog_start>();
				setCurrent(MODE.DIALOGSTART);
			}
			else
			{
				setCurrent(MODE.STAY);
			}
			break;
		case MODE.DIALOGSTART:
			if (m_Dialog_start.isEnd)
			{
				int decideID3 = m_Dialog_start.m_DecideID;
				m_InitGameStart = 0;
				Object.Destroy(m_Dialog_start.gameObject);
				m_Dialog_start = null;
				if (decideID3 == 0)
				{
					GameObject gameObject6 = (GameObject)Object.Instantiate(Resources.Load("Dialog_start2"), new Vector3(50000f, 50000f, 0f), Quaternion.identity);
					m_Dialog_start2 = gameObject6.GetComponent<UIDialog_start2>();
					setCurrent(MODE.DIALOGSTART2);
				}
			}
			break;
		case MODE.DIALOGSTART2:
			if (m_Dialog_start2.isEnd)
			{
				int decideID = m_Dialog_start2.m_DecideID;
				Object.Destroy(m_Dialog_start2.gameObject);
				m_Dialog_start2 = null;
				if (decideID == 0)
				{
					GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("Dialog_start3"), new Vector3(50000f, 50000f, 0f), Quaternion.identity);
					m_Dialog_start3 = gameObject.GetComponent<UIDialog_start3>();
					setCurrent(MODE.DIALOGSTART3);
				}
			}
			break;
		case MODE.DIALOGSTART3:
			if (m_Dialog_start3.isEnd)
			{
				int decideID4 = m_Dialog_start3.m_DecideID;
				Object.Destroy(m_Dialog_start3.gameObject);
				m_Dialog_start3 = null;
				if (decideID4 == 0)
				{
					GameObject gameObject7 = (GameObject)Object.Instantiate(Resources.Load("Dialog_start4"), new Vector3(50000f, 50000f, 0f), Quaternion.identity);
					m_Dialog_start4 = gameObject7.GetComponent<UIDialog_start4>();
					setCurrent(MODE.DIALOGSTART4);
				}
			}
			break;
		case MODE.DIALOGSTART4:
			if (m_Dialog_start4.isEnd)
			{
				int decideID2 = m_Dialog_start4.m_DecideID;
				Object.Destroy(m_Dialog_start4.gameObject);
				m_Dialog_start4 = null;
				if (decideID2 == 1)
				{
					Application.OpenURL("http://d777.jp/Portal.php");
					m_IsGameStart = false;
					setCurrent(MODE.STAY);
					setInput(true);
				}
				else
				{
					PlayerPrefs.SetInt(INITGAMESTART_PREF_KEY, m_InitGameStart);
					m_IsGameStart = false;
					setCurrent(MODE.STAY);
					setInput(true);
				}
			}
			break;
		case MODE.STAY:
			if (m_IsEnjoyMore)
			{
				setInput(false);
				if (PlayUserData.saveData.getUnique() != string.Empty)
				{
					setCurrent(MODE.GAMEDATA);
					startSetGameData_EnjoyMore();
					isConnect = true;
				}
				else
				{
					SGLG.startFade();
					setCurrent(MODE.TOBROWSE);
				}
			}
			else if (m_IsGameStart)
			{
				SGLG.gameMode = SGLG.GAMEMODE.HALL;
				MainGameScene.backFrom = MainGameScene.FROM.NONE;
				setInput(false);
				if (PlayUserData.saveData.m_seisanComitFlag == 1)
				{
					GameObject gameObject2 = SGLG.createDialog(22);
					m_Dialog_22 = gameObject2.GetComponent<UIDialog_22>();
					setCurrent(MODE.DIALOG22);
				}
				else if (UserData.saveData.hall.gameStart)
				{
					GameObject gameObject3 = SGLG.createDialog(3);
					m_Dialog_03 = gameObject3.GetComponent<UIDialog_03>();
					setCurrent(MODE.DIALOG03);
				}
				else if (PlayUserData.saveData.getUnique() == string.Empty)
				{
					setCurrent(MODE.UNIQUE);
					startConnectUnique();
					isConnect = true;
				}
				else
				{
					SGLG.startLoading();
					stopBGM();
					setCurrent(MODE.TOHALL);
					isConnect = false;
				}
			}
			else if (m_IsSimulationMode)
			{
				SGLG.gameMode = SGLG.GAMEMODE.SIMULATION;
				MainGameScene.backFrom = MainGameScene.FROM.NONE;
				setInput(false);
				if (Sim_SlotUserData.saveData.m_saveFlag)
				{
					GameObject gameObject4 = SGLG.createDialog(24);
					m_Dialog_24 = gameObject4.GetComponent<UIDialog_24>();
					setCurrent(MODE.DIALOG24);
				}
				else if (PlayUserData.saveData.getUnique() == string.Empty)
				{
					setCurrent(MODE.UNIQUE);
					startConnectUnique();
					isConnect = true;
				}
				else
				{
					setCurrent(MODE.TO_SIM_SETTEI);
					SGLG.startFade_Fast();
					SGLGSimConfig.IsContinue = false;
				}
			}
			else if (Input.GetKey(KeyCode.Escape))
			{
				m_Dialog_04 = SGLG.createDialog(4).GetComponent<UIDialog_04>();
				setCurrent(MODE.APP_END);
			}
			break;
		case MODE.UNIQUE:
			if (isUniqueError())
			{
				m_Dialog_16 = SGLG.createDialog(16).GetComponent<UIDialog_16>();
				setCurrent(MODE.UNIQUERETRY);
				isConnect = false;
			}
			else if (isUniqueSuccess())
			{
				if (SGLG.gameMode == SGLG.GAMEMODE.SIMULATION)
				{
					setCurrent(MODE.TO_SIM_SETTEI);
					SGLG.startFade_Fast();
					SGLGSimConfig.IsContinue = false;
					isConnect = false;
				}
				else
				{
					SGLG.startLoading();
					stopBGM();
					setCurrent(MODE.TOHALL);
					isConnect = false;
				}
			}
			break;
		case MODE.UNIQUERETRY:
			if (m_Dialog_16.isEnd)
			{
				switch (m_Dialog_16.m_DecideID)
				{
				case 0:
					setCurrent(MODE.UNIQUE);
					startConnectUnique();
					isConnect = true;
					break;
				case 1:
					m_IsGameStart = false;
					m_IsSimulationMode = false;
					setInput(true);
					setCurrent(MODE.STAY);
					break;
				}
				Object.Destroy(m_Dialog_16.gameObject);
				m_Dialog_16 = null;
			}
			break;
		case MODE.TOHALL:
			if (SGLG.loading.loadStart)
			{
				startSetGameData_GameStart();
				setCurrent(MODE.HALL);
			}
			break;
		case MODE.HALL:
			if (SGLG.gameMode == SGLG.GAMEMODE.HALL)
			{
				if (isSlotGameResume())
				{
					SGLG.m_Mode = SGLG.MODE.MAIN;
					break;
				}
				hallContlloer.firstState = hallContlloer._STATE.INIT;
				SGLG.m_Mode = SGLG.MODE.HALL;
			}
			else
			{
				if (!SGLGSimConfig.IsContinue)
				{
					SGLG.DataSaveEndSimulation();
				}
				SGLG.m_Mode = SGLG.MODE.MAIN;
			}
			break;
		case MODE.TOBROWSE:
			if (SGLG.isFadeOutComplete())
			{
				setCurrent(MODE.BROWSESTART);
			}
			break;
		case MODE.BROWSESTART:
			SGLG.endFade();
			m_IsEnjoyMore = false;
			setCurrent(MODE.BROWSE);
			SGLG.launchWebBrowser(SGLG.URL_TITLE_ENJOYMORE + PlayUserData.saveData.getUnique());
			break;
		case MODE.BROWSE:
			if (!SGLG.isBrowsing)
			{
				SGLG.endFade();
				setCurrent(MODE.STAY);
			}
			break;
		case MODE.DIALOG03:
		{
			if (!m_Dialog_03.isEnd)
			{
				break;
			}
			int decideID6 = m_Dialog_03.m_DecideID;
			Object.Destroy(m_Dialog_03.gameObject);
			m_Dialog_03 = null;
			if (decideID6 == 0)
			{
				if (PlayUserData.saveData.getUnique() == string.Empty)
				{
					setCurrent(MODE.UNIQUE);
					startConnectUnique();
					isConnect = true;
				}
				else
				{
					SGLG.startLoading();
					stopBGM();
					setCurrent(MODE.TOHALL);
					isConnect = false;
				}
			}
			else
			{
				m_IsGameStart = false;
				setCurrent(MODE.STAY);
				setInput(true);
			}
			break;
		}
		case MODE.DIALOG22:
			if (m_Dialog_22.isEnd)
			{
				int decideID5 = m_Dialog_22.m_DecideID;
				Object.Destroy(m_Dialog_22.gameObject);
				m_Dialog_22 = null;
				if (decideID5 == 0)
				{
					setCurrent(MODE.COMMIT);
					startCommit();
					isConnect = true;
				}
				else
				{
					m_IsGameStart = false;
					setCurrent(MODE.STAY);
					setInput(true);
				}
			}
			break;
		case MODE.DIALOG16:
			if (m_Dialog_16.isEnd)
			{
				switch (m_Dialog_16.m_DecideID)
				{
				case 0:
					setCurrent(MODE.COMMIT);
					startCommit();
					isConnect = true;
					break;
				case 1:
					m_IsGameStart = false;
					setInput(true);
					setCurrent(MODE.STAY);
					break;
				}
				Object.Destroy(m_Dialog_16.gameObject);
				m_Dialog_16 = null;
			}
			break;
		case MODE.COMMIT:
			if (isSendCommitFailed())
			{
				m_Dialog_16 = SGLG.createDialog(16).GetComponent<UIDialog_16>();
				setCurrent(MODE.DIALOG16);
				isConnect = false;
			}
			else if (isSendCommitSuccess())
			{
				PlayUserData.saveData.m_seisanRuiMai += UserData.saveData.game.motiMedals;
				PlayUserData.saveData.m_seisanComitFlag = 0;
				PlayUserData.save();
				if (UserData.saveData.hall.sendMedalsFist == 0)
				{
					UserData.saveData.hall.sendMedalsFist = 1;
				}
				SGLG.DataSendComplete();
				setCurrent(MODE.COMPLETE);
				isConnect = false;
			}
			break;
		case MODE.COMPLETE:
			if (PlayUserData.saveData.getUnique() == string.Empty)
			{
				setCurrent(MODE.UNIQUE);
				startConnectUnique();
				isConnect = true;
			}
			else
			{
				SGLG.startLoading();
				stopBGM();
				setCurrent(MODE.TOHALL);
				isConnect = false;
			}
			break;
		case MODE.APP_END:
			if (m_Dialog_04.isEnd)
			{
				setCurrent(MODE.STAY);
				if (m_Dialog_04.m_DecideID == 0)
				{
					Application.Quit();
				}
				else if (m_Dialog_04.m_DecideID != 1)
				{
				}
				Object.Destroy(m_Dialog_04.gameObject);
			}
			break;
		case MODE.GAMEDATA:
			if (isSendGameDataFailed())
			{
				m_Dialog_16 = SGLG.createDialog(16).GetComponent<UIDialog_16>();
				setCurrent(MODE.DIALOG16_GAMEDATA);
				isConnect = false;
			}
			else if (isSendGameDataSuccess())
			{
				if (PlayUserData.saveData.m_kyouseiFlag == 1)
				{
					setCurrent(MODE.GAMEDATA);
					startSetGameData_EnjoyMore();
				}
				else
				{
					SGLG.startFade();
					setCurrent(MODE.TOBROWSE);
					isConnect = false;
				}
			}
			break;
		case MODE.DIALOG16_GAMEDATA:
			if (m_Dialog_16.isEnd)
			{
				switch (m_Dialog_16.m_DecideID)
				{
				case 0:
					setCurrent(MODE.GAMEDATA);
					startSetGameData_EnjoyMore();
					isConnect = true;
					break;
				case 1:
					m_IsEnjoyMore = false;
					setInput(true);
					setCurrent(MODE.STAY);
					break;
				}
				Object.Destroy(m_Dialog_16.gameObject);
				m_Dialog_16 = null;
			}
			break;
		case MODE.DIALOG24:
			if (m_Dialog_24.isEnd)
			{
				switch (m_Dialog_24.m_DecideID)
				{
				case 0:
					SGLG.startLoading();
					stopBGM();
					setCurrent(MODE.TOHALL);
					isConnect = false;
					SGLGSimConfig.IsSimLoad = true;
					SGLGSimConfig.IsContinue = true;
					break;
				case 1:
				{
					GameObject gameObject5 = SGLG.createDialog(25);
					m_Dialog_25 = gameObject5.GetComponent<UIDialog_25>();
					setCurrent(MODE.DIALOG25);
					break;
				}
				case 2:
					m_IsSimulationMode = false;
					setInput(true);
					setCurrent(MODE.STAY);
					break;
				}
				Object.Destroy(m_Dialog_24.gameObject);
				m_Dialog_24 = null;
			}
			break;
		case MODE.DIALOG25:
			if (m_Dialog_25.isEnd)
			{
				switch (m_Dialog_25.m_DecideID)
				{
				case 0:
					setCurrent(MODE.TO_SIM_SETTEI);
					SGLG.startFade_Fast();
					SGLGSimConfig.IsContinue = false;
					break;
				case 1:
					m_IsSimulationMode = false;
					setInput(true);
					setCurrent(MODE.STAY);
					break;
				}
				Object.Destroy(m_Dialog_25.gameObject);
				m_Dialog_25 = null;
			}
			break;
		case MODE.TO_SIM_SETTEI:
			if (SGLG.isFadeOutComplete())
			{
				SGLGSimConfig.SimSetting = 6;
				SGLGSimConfig.IsSetteiChangeBack = false;
				SGLGSimConfig.IsSetteiChangeGameStart = false;
				Object.Instantiate(Resources.Load("prefabs/SimMenu_SetteiChangeFromTitle"), new Vector3(0f, 0f, -10f), Quaternion.identity);
				setCurrent(MODE.SIM_SETTEI);
				SGLG.endFade();
			}
			break;
		case MODE.SIM_SETTEI:
			if (SGLGSimConfig.IsSetteiChangeBack)
			{
				SGLGSimConfig.IsSetteiChangeBack = false;
				setCurrent(MODE.TO_TITLE);
				SGLGSimConfig.SimSetting = 6;
			}
			else if (SGLGSimConfig.IsSetteiChangeGameStart)
			{
				SGLGSimConfig.IsSetteiChangeGameStart = false;
				setCurrent(MODE.TOHALL);
				isConnect = false;
				SGLGSimConfig.IsSimLoad = false;
			}
			break;
		case MODE.TO_TITLE:
			if (SGLG.isFadeOutComplete())
			{
				m_IsSimulationMode = false;
				setInput(true);
				setCurrent(MODE.STAY);
				SGLG.endFade();
			}
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

	private void setInput(bool _flag)
	{
		m_ButtonCol_1.enabled = _flag;
		m_ButtonCol_2.enabled = _flag;
		m_ButtonCol_3.enabled = _flag;
	}

	public override void keyEvent()
	{
		base.keyEvent();
	}

	private void OnClickEvent_GameStart()
	{
		if (!m_IsEnjoyMore && !m_IsGameStart && !m_IsSimulationMode)
		{
			sndPlay(1, 2, false, 0.5f);
			m_IsGameStart = true;
			setInput(false);
		}
	}

	private void OnClickEvent_EnjoyMore()
	{
		if (!m_IsEnjoyMore && !m_IsGameStart && !m_IsSimulationMode)
		{
			sndPlay(1, 2, false, 0.5f);
			m_IsEnjoyMore = true;
			setInput(false);
		}
	}

	public void OnClickEvent_Simulation()
	{
		if (!m_IsEnjoyMore && !m_IsGameStart && !m_IsSimulationMode)
		{
			sndPlay(1, 2, false, 0.5f);
			m_IsSimulationMode = true;
			setInput(false);
		}
	}

	public override void OnBrowseEvent_Start()
	{
		snd.stopAll();
		m_Title.SetActive(false);
	}

	public override void OnBrowseEvent_Close()
	{
		sndPlay(0, 1, true, 1f);
		m_Title.SetActive(true);
		setInput(true);
	}

	private bool isSlotGameResume()
	{
		if (SGLG.gameMode == SGLG.GAMEMODE.HALL)
		{
			return UserData.saveData.hall.gameStart && UserData.saveData.game.selectMachine >= 0;
		}
		return Sim_SlotUserData.saveData.m_saveFlag;
	}

	public void startConnectUnique()
	{
		string url = SGLG.URL_PHP;
		if (m_RedirectUnique.Length != 0)
		{
			url = m_RedirectUnique;
		}
		m_UniqueResult = RESULT.NONE;
		NetUtility.sendGetUniqueID(url, base.gameObject, "endConnectUnique");
	}

	public void endConnectUnique()
	{
		GrfNetwork network = SGLG.network;
		bool flag = false;
		if (network.getStatus() == 1)
		{
			string text = NetUtility.redirectURL(network.textUTF8());
			if (text.Length != 0)
			{
				m_RedirectUnique = text;
				m_UniqueResult = RESULT.ERROR;
				return;
			}
			m_RedirectUnique = string.Empty;
			if (NetUtility.parseGetUniqueID(network.getRecvBuffer()))
			{
				m_UniqueResult = RESULT.OK;
			}
			else
			{
				m_UniqueResult = RESULT.ERROR;
			}
		}
		else
		{
			m_UniqueResult = RESULT.NG;
		}
	}

	public bool isUniqueError()
	{
		return m_UniqueResult != RESULT.OK && m_UniqueResult != RESULT.NONE;
	}

	public bool isUniqueSuccess()
	{
		return m_UniqueResult == RESULT.OK;
	}

	public void startCommit()
	{
		string url = SGLG.URL_PHP;
		if (m_RedirectCommit.Length != 0)
		{
			url = m_RedirectCommit;
		}
		m_CommitResult = RESULT.NONE;
		NetUtility.sendCommitPoint(url, base.gameObject, "endConnectCommit");
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

	public void startSetGameData_GameStart()
	{
		string uRL_PHP = SGLG.URL_PHP;
		NetUtility.sendSetGameData(uRL_PHP, null, string.Empty, 0);
	}

	public void startSetGameData_EnjoyMore()
	{
		string url = SGLG.URL_PHP;
		if (m_RedirectGameData.Length != 0)
		{
			url = m_RedirectGameData;
		}
		m_GameDataResult = RESULT.NONE;
		NetUtility.sendSetGameData(url, base.gameObject, "endConnectSetGameData", PlayUserData.saveData.m_kyouseiFlag);
	}

	public void endConnectSetGameData()
	{
		GrfNetwork network = SGLG.network;
		bool flag = false;
		if (network.getStatus() == 1)
		{
			string text = NetUtility.redirectURL(network.textUTF8());
			if (text.Length != 0)
			{
				m_RedirectGameData = text;
				m_GameDataResult = RESULT.ERROR;
				return;
			}
			m_RedirectGameData = string.Empty;
			if (NetUtility.parseSetGameData(network.getRecvBuffer(), PlayUserData.saveData.m_kyouseiFlag == 1))
			{
				m_GameDataResult = RESULT.OK;
			}
			else
			{
				m_GameDataResult = RESULT.ERROR;
			}
		}
		else
		{
			m_GameDataResult = RESULT.NG;
		}
	}

	public bool isSendGameDataSuccess()
	{
		return m_GameDataResult == RESULT.OK;
	}

	public bool isSendGameDataFailed()
	{
		return m_GameDataResult != RESULT.OK && m_GameDataResult != RESULT.NONE;
	}
}
