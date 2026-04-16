using UnityEngine;

public class MainGameScene : SceneUpdater
{
	private enum MODE
	{
		FADEIN = 0,
		NORMAL = 1,
		GOTODATA = 2,
		GOTODATA_SIM = 3,
		DATA = 4,
		DATA_SIM = 5,
		GOTOMENU = 6,
		MENU = 7,
		HEITEN = 8,
		HEITEN_SIM = 9,
		TOADJUSTMENT = 10,
		TOTITLE = 11,
		GAME_END = 12,
		RESTART = 13,
		AUTOPLAY_END = 14
	}

	public enum FROM
	{
		NONE = 0,
		ADJ_NORMAL = 1,
		ADJ_FORCE = 2
	}

	public static MainCameraManager cameraMan;

	public static SlotGameManager slotGameMan;

	public static SlotBodyManager slotMan;

	public static LotManager lotMan;

	public static DirectionManager dirMan;

	public static ReelManager reelMan;

	public static LEDMainManager ledMainMan;

	public static LEDPanelManager ledPanelMan;

	public static YakuManager yakuMan;

	public static PushButtonManager pushMan;

	public static DirectionLedManager dirLedMan;

	public static DirectionYakuManager dirYakuMan;

	public static panelManager pnlMan;

	public static Direction3MST_Sub dir3MST_Sub;

	public static GGLSound snd;

	public static bool restartFlag;

	public static SlotBodyManager.STATE restartDest;

	private static MODE m_Mode = MODE.NORMAL;

	public static FROM backFrom;

	public static GameObject m_EkisyoCamera;

	public static GameObject m_EkisyoCamera_Front;

	public static GameObject m_Kyoutai;

	public static GameObject m_MainCamera;

	public static GameObject m_SceneUpdater;

	public static GameObject m_TouchArea;

	public static GameObject m_GuiDirection;

	public static UIDataPanel m_DataPanel;

	public static GameObject m_DataPanelObj;

	private static UIDialog_09 m_Dialog_09;

	private static UIDialog_21 m_Dialog_21;

	private static UIDialog_23 m_Dialog_GameEnd;

	private static UIDialog_29 m_Dialog_AutoEnd;

	private static UIDialog_26 m_Dialog_26;

	public static PlaySaveData m_PlaySaveData;

	public static SlotSaveData m_SlotSaveData;

	private static void setMode(MODE _mode)
	{
		m_Mode = _mode;
		MODE mode = m_Mode;
		if (mode == MODE.NORMAL)
		{
			m_DataPanel.setCollisionActive(true);
		}
		else
		{
			m_DataPanel.setCollisionActive(false);
		}
	}

	private void Start()
	{
		SGLG.m_Scene = (MainGameScene)base.gameObject.GetComponent("MainGameScene");
		m_EkisyoCamera = GameObject.Find("EkisyoCamera");
		m_EkisyoCamera_Front = GameObject.Find("EkisyoCamera_Front");
		m_Kyoutai = GameObject.Find("kyoutai");
		m_MainCamera = GameObject.Find("MainCamera");
		m_SceneUpdater = GameObject.Find("SceneUpdater_Main");
		m_TouchArea = GameObject.Find("TouchArea");
		m_GuiDirection = GameObject.Find("GUIDirection");
		SGLGSimConfig.IsFromTitle = false;
	}

	private void Awake()
	{
		if (SGLG.gameMode == SGLG.GAMEMODE.HALL)
		{
			m_PlaySaveData = PlayUserData.saveData;
			m_SlotSaveData = SlotUserData.saveData;
		}
		else
		{
			m_PlaySaveData = Sim_PlayUserData.saveData;
			m_SlotSaveData = Sim_SlotUserData.saveData;
		}
	}

	private void initSimulation()
	{
		if (SGLG.gameMode == SGLG.GAMEMODE.SIMULATION && !m_SlotSaveData.m_saveFlag)
		{
			m_SlotSaveData.m_saveFlag = true;
			switch (SGLGSimConfig.SimSetting)
			{
			case 0:
			case 1:
			case 2:
			case 3:
			case 4:
			case 5:
				Sim_MachineData.saveData.settei = SGLGSimConfig.SimSetting;
				Sim_MachineData.saveData.dispSettei = SGLGSimConfig.SimSetting;
				break;
			case 6:
			{
				int num = 0;
				num = (int)Random.Range(0f, 6f);
				Sim_MachineData.saveData.settei = num;
				Sim_MachineData.saveData.dispSettei = 6;
				break;
			}
			default:
				Sim_MachineData.saveData.settei = 0;
				Sim_MachineData.saveData.dispSettei = 6;
				break;
			}
			SlotDataSave();
			Sim_MachineData.save();
		}
	}

	public override void init()
	{
		initSimulation();
		loadTextures();
		EkisyoAnime.initMainGameScene();
		MainObjAuto.init();
		cameraMan = new MainCameraManager();
		cameraMan.init();
		slotGameMan = new SlotGameManager();
		slotGameMan.init();
		slotMan = new SlotBodyManager();
		slotMan.init();
		lotMan = new LotManager();
		dirMan = new DirectionManager(SceneUpdater.prod, SceneUpdater.sound);
		reelMan = new ReelManager();
		reelMan.setReelSpeed(m_PlaySaveData.m_configReelSpeed);
		reelMan.setReelBulr(m_PlaySaveData.m_configReelBlur == 1);
		ledMainMan = new LEDMainManager();
		ledPanelMan = new LEDPanelManager();
		yakuMan = new YakuManager();
		yakuMan.init();
		pushMan = new PushButtonManager();
		dirLedMan = new DirectionLedManager(ledMainMan, ledPanelMan);
		pnlMan = new panelManager();
		pnlMan.init();
		dirYakuMan = new DirectionYakuManager(yakuMan, pnlMan, slotGameMan);
		dir3MST_Sub = new Direction3MST_Sub();
		resume();
		snd = GetComponent<GGLSound>();
		snd.loadSoundFiles();
		snd.stopAll();
		int line = DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_4M);
		int line2 = DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_7M);
		DirectionLedManager.m_panel_odds(line);
		DirectionLedManager.lever_ball_on(line2);
		SGLG.prodAllStop();
		slotGameMan.reStart();
		m_Dialog_09 = null;
		m_Dialog_21 = null;
		SGLG.sound.SetMasterVolume(0f);
		if (slotMan.m_State == SlotBodyManager.STATE.STANDBY)
		{
			SGLG.endLoading();
			setMode(MODE.FADEIN);
			setModeBackFrom();
		}
		else
		{
			restartFlag = true;
			restartDest = slotMan.m_State;
			slotMan.m_State = SlotBodyManager.STATE.LEVER_WAIT;
			setMode(MODE.RESTART);
		}
		m_IsOK = true;
	}

	public static void sndPlay(int ch, int playID, bool loop, float volume)
	{
		snd.setData(ch, playID);
		snd.play(ch);
		snd.setLoop(ch, loop);
		snd.setVolume(ch, volume);
	}

	public static void sndStop(int ch)
	{
		snd.stop(ch);
	}

	public static void sndStop()
	{
		snd.stopAll();
	}

	public static void forceSetVisibleOff()
	{
		if (SGLG.prod != null)
		{
			SGLG.prod.forceSetVisibleOff();
		}
		if (SGLG.prodImg != null)
		{
			SGLG.prodImg.forceSetVisibleOff();
		}
		if (SGLG.prodAnime != null)
		{
			SGLG.prodAnime.forceSetVisibleOff();
		}
		if (pnlMan != null)
		{
			pnlMan.forceSetVisibleOff();
		}
	}

	public static void forceSetVisibleOn()
	{
		if (SGLG.prod != null)
		{
			SGLG.prod.forceSetVisibleOn();
		}
		if (SGLG.prodImg != null)
		{
			SGLG.prodImg.forceSetVisibleOn();
		}
		if (SGLG.prodAnime != null)
		{
			SGLG.prodAnime.forceSetVisibleOn();
		}
		if (pnlMan != null)
		{
			pnlMan.forceSetVisibleOn();
		}
	}

	public static void gotoDataScene()
	{
		setMode(MODE.GOTODATA);
		SGLG.startFade_Fast();
	}

	public static void backFromDataScene()
	{
		resume();
		setMode(MODE.FADEIN);
		SGLG.endFade();
	}

	public static void gotoMenuScene()
	{
		setMode(MODE.GOTOMENU);
		SGLG.startFade_Fast();
	}

	public static void backFromMenuScene()
	{
		resume();
		snd.stopAll();
		setVisibleMain(true);
		setMode(MODE.FADEIN);
	}

	public static void setVisibleMain(bool _flag)
	{
		m_DataPanelObj.SetActive(_flag);
		m_EkisyoCamera.SetActive(_flag);
		m_EkisyoCamera_Front.SetActive(_flag);
		m_Kyoutai.SetActive(_flag);
		m_MainCamera.SetActive(_flag);
		m_SceneUpdater.SetActive(_flag);
		m_TouchArea.SetActive(_flag);
	}

	public override void control()
	{
		if (!m_IsOK || cameraMan == null || slotGameMan == null || slotMan == null || lotMan == null || dirMan == null || reelMan == null || ledMainMan == null || ledPanelMan == null || yakuMan == null || pushMan == null || dirLedMan == null || dirYakuMan == null || pnlMan == null || dir3MST_Sub == null)
		{
			return;
		}
		switch (m_Mode)
		{
		case MODE.FADEIN:
			if (SGLG.loading == null)
			{
				SGLG.sound.SetMasterVolume(1f);
				setMode(MODE.NORMAL);
			}
			break;
		case MODE.NORMAL:
			if (Input.GetKey(KeyCode.Escape))
			{
				m_Dialog_GameEnd = SGLG.createDialog(23).GetComponent<UIDialog_23>();
				setMode(MODE.GAME_END);
				pause();
			}
			break;
		case MODE.GAME_END:
			if (m_Dialog_GameEnd.isEnd)
			{
				if (m_Dialog_GameEnd.m_DecideID == 0)
				{
					SGLG.startLoading();
					sndStop();
					SGLG.sound.Stop();
					setMode(MODE.TOTITLE);
				}
				else if (m_Dialog_GameEnd.m_DecideID == 1)
				{
					setMode(MODE.NORMAL);
					resume();
				}
				Object.Destroy(m_Dialog_GameEnd.gameObject);
			}
			break;
		case MODE.AUTOPLAY_END:
			if (m_Dialog_AutoEnd == null)
			{
				setMode(MODE.NORMAL);
				resume();
			}
			else if (m_Dialog_AutoEnd.isEnd)
			{
				if (m_Dialog_AutoEnd.m_DecideID != 0 && m_Dialog_AutoEnd.m_DecideID == 1)
				{
					m_PlaySaveData.setAuto(4);
					PlayDataSave();
					MainObjAuto.touched = false;
				}
				setMode(MODE.NORMAL);
				resume();
				Object.Destroy(m_Dialog_AutoEnd.gameObject);
				m_Dialog_AutoEnd = null;
			}
			break;
		case MODE.GOTODATA:
			if (SGLG.isFadeOutComplete())
			{
				GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load((SGLG.gameMode == SGLG.GAMEMODE.SIMULATION) ? "prefabs/SimData" : "prefabs/Data"), new Vector3(0f, 0f, -1f), Quaternion.identity);
				pause();
				setMode(MODE.DATA);
			}
			break;
		case MODE.GOTODATA_SIM:
			if (SGLG.isFadeOutComplete())
			{
				GameObject gameObject2 = (GameObject)Object.Instantiate(Resources.Load("prefabs/SimDataEnd"), new Vector3(0f, 0f, -1f), Quaternion.identity);
				setMode(MODE.DATA_SIM);
			}
			break;
		case MODE.GOTOMENU:
			if (SGLG.isFadeOutComplete())
			{
				if (SGLG.gameMode == SGLG.GAMEMODE.HALL)
				{
					UIMenuAuto.setFirstData();
					UIMenuSetting.setFirstData();
				}
				else
				{
					UISimMenuAuto.setFirstData();
					UISimMenuSetting.setFirstData();
				}
				createMenu();
				SGLG.endFade();
			}
			break;
		case MODE.HEITEN:
			m_DataPanel.setCollisionActive(false);
			if (UserData.saveData.game.motiMedals <= 0)
			{
				if (m_Dialog_21.isEnd)
				{
					SGLG.DataSendComplete();
					SGLG.startLoading();
					sndStop();
					SGLG.sound.Stop();
					m_Mode = MODE.TOTITLE;
				}
			}
			else if (m_Dialog_09.isEnd)
			{
				int decideID2 = m_Dialog_09.m_DecideID;
				Object.Destroy(m_Dialog_09.gameObject);
				m_Dialog_09 = null;
				switch (decideID2)
				{
				case 0:
					AdjustmentScene.seisanMode = AdjustmentScene.SEISAN.SEND;
					AdjustmentScene.seisanFrom = AdjustmentScene.FROM.MAIN_FORCE;
					m_Mode = MODE.TOADJUSTMENT;
					SGLG.startLoading();
					sndStop();
					SGLG.sound.Stop();
					break;
				case 1:
					SGLG.DataSaveComplete();
					AdjustmentScene.seisanMode = AdjustmentScene.SEISAN.SAVE;
					AdjustmentScene.seisanFrom = AdjustmentScene.FROM.MAIN_FORCE;
					m_Mode = MODE.TOADJUSTMENT;
					SGLG.startLoading();
					sndStop();
					SGLG.sound.Stop();
					break;
				}
			}
			return;
		case MODE.HEITEN_SIM:
			m_DataPanel.setCollisionActive(false);
			if (m_Dialog_26.isEnd)
			{
				int decideID = m_Dialog_26.m_DecideID;
				Object.Destroy(m_Dialog_26.gameObject);
				m_Dialog_26 = null;
				switch (decideID)
				{
				case 0:
					setMode(MODE.GOTODATA_SIM);
					SGLG.startFade_Fast();
					break;
				case 1:
					SGLG.DataSaveEndSimulation();
					SGLG.startLoading();
					sndStop();
					SGLG.sound.Stop();
					m_Mode = MODE.TOTITLE;
					break;
				}
			}
			return;
		case MODE.TOADJUSTMENT:
			if (SGLG.loading.loadStart)
			{
				SGLG.endLoading();
				UserData.save();
				release();
				SGLG.m_Mode = SGLG.MODE.ADJUSTMENT;
			}
			return;
		case MODE.TOTITLE:
			if (SGLG.loading.loadStart)
			{
				SGLG.endLoading();
				UserData.save();
				release();
				SGLG.m_Mode = SGLG.MODE.TITLE;
			}
			return;
		}
		if (!SGLG.pause)
		{
			slotMan.control();
			cameraMan.control();
			if (SGLG.isUpdateDirection)
			{
				slotGameMan.control();
				slotMan.execQueue();
				dirMan.control();
				pushMan.control();
				ledMainMan.control();
				ledPanelMan.control();
				yakuMan.control();
				dirLedMan.control();
				dirYakuMan.control();
				pnlMan.setParam(panelManager.TYPE.NORMAL_GAME, slotGameMan.get_pkd_data(78));
				pnlMan.setParam(panelManager.TYPE.ART_TRACK, slotGameMan.get_pkd_data(211));
				pnlMan.setParam(panelManager.TYPE.BONUS_GET, slotGameMan.get_pkd_data(575));
				pnlMan.setParam(panelManager.TYPE.BONUS_GAME, slotGameMan.get_pkd_data(438));
				pnlMan.setParam(panelManager.TYPE.BONUS_MAX_GAME, slotGameMan.get_pkd_data(439));
				pnlMan.setParam(panelManager.TYPE.BONUS_GET_REMAINING, slotGameMan.pbLastMedal);
				pnlMan.setParam(panelManager.TYPE.BONUS_End_GET, slotGameMan.get_pkd_data(575));
				pnlMan.setParam(panelManager.TYPE.TOTAL_GET, slotGameMan.get_pkd_data(577));
				pnlMan.setParam(panelManager.TYPE.TOTAL_GET_BIG, slotGameMan.get_pkd_data(577));
				pnlMan.setParam(panelManager.TYPE.REMAINING_GAME, slotGameMan.artDispCnt);
				pnlMan.setParam(panelManager.TYPE.TOTAL_GAME, slotGameMan.get_pkd_data(493));
				pnlMan.setParam(panelManager.TYPE.END_TOTAL_GAME, slotGameMan.get_pkd_data(493));
				pnlMan.setParam(panelManager.TYPE.PLUS_GAME, slotGameMan.getTotalUwanose());
				pnlMan.setParam(panelManager.TYPE.PLUS_GAME_BIG, slotGameMan.getTotalUwanose());
				pnlMan.setParam(panelManager.TYPE.BAO_TURN, slotGameMan.get_pkd_data(440));
				pnlMan.setParam(panelManager.TYPE.SLASH, slotGameMan.get_pkd_data(91));
				pnlMan.setParam(panelManager.TYPE.ROMAN, slotGameMan.get_pdt_data(65));
				pnlMan.setParam(panelManager.TYPE.SLASH_BIG, slotGameMan.get_pkd_data(91));
				pnlMan.setParam(panelManager.TYPE.HP_1P, slotGameMan.get_pkd_data(96));
				pnlMan.setParam(panelManager.TYPE.HP_2P, slotGameMan.get_pkd_data(97));
				pnlMan.setParam(panelManager.TYPE.HP_1P_OLD, slotGameMan.get_pkd_data(98));
				pnlMan.setParam(panelManager.TYPE.HP_2P_OLD, slotGameMan.get_pkd_data(99));
				pnlMan.setParam(panelManager.TYPE.DAMAGE, slotGameMan.get_pkd_data(100));
				pnlMan.setParam(panelManager.TYPE.ATACK_SIDE, slotGameMan.get_pkd_data(103));
				pnlMan.setParam(panelManager.TYPE.CARTRIDGE, slotGameMan.get_pkd_data(494));
				pnlMan.setParam(panelManager.TYPE.CARTRIDGE_REMAINING, slotGameMan.getRomanBulletNum());
				pnlMan.setParam(panelManager.TYPE.JACIN, slotGameMan.getStateJAC());
				pnlMan.control(slotGameMan.m_dirData[45]);
			}
			SGLG.prodAnime.control();
			dir3MST_Sub.control();
			base.control();
		}
	}

	private void controlRestart()
	{
		if (slotMan.m_State >= restartDest && !slotGameMan.m_drinFukki && (restartDest != SlotBodyManager.STATE.REEL_WAIT || slotMan.m_State >= SlotBodyManager.STATE.REEL_START))
		{
			restartFlag = false;
			SGLG.endLoading();
			setMode(MODE.FADEIN);
			setModeBackFrom();
		}
	}

	public override void controlReel()
	{
		if (!SGLG.pause && reelMan != null)
		{
			reelMan.control();
		}
	}

	public override void controlFrame()
	{
		MainObjAuto.touchedInOneFrame = false;
	}

	private GameObject createMenu()
	{
		GameObject result = ((SGLG.gameMode != SGLG.GAMEMODE.SIMULATION) ? ((GameObject)Object.Instantiate(Resources.Load("prefabs/Menu_Top"), new Vector3(0f, 0f, -1f), Quaternion.identity)) : ((GameObject)Object.Instantiate(Resources.Load("prefabs/SimMenu_Top"), new Vector3(0f, 0f, -1f), Quaternion.identity)));
		pause();
		snd.stopAll();
		sndPlay(0, 7, true, 1f);
		setVisibleMain(false);
		setMode(MODE.MENU);
		return result;
	}

	public static void heiten()
	{
		m_Mode = MODE.HEITEN;
		pause();
		if (UserData.saveData.game.motiMedals <= 0)
		{
			GameObject gameObject = SGLG.createDialog(21);
			m_Dialog_21 = gameObject.GetComponent<UIDialog_21>();
		}
		else
		{
			GameObject gameObject2 = SGLG.createDialog(9);
			m_Dialog_09 = gameObject2.GetComponent<UIDialog_09>();
		}
	}

	public static void heiten_simulation()
	{
		m_Mode = MODE.HEITEN_SIM;
		pause();
		GameObject gameObject = SGLG.createDialog(26);
		m_Dialog_26 = gameObject.GetComponent<UIDialog_26>();
	}

	public override void keyEvent()
	{
		if (m_IsOK && !SGLG.pause)
		{
			MODE mode = m_Mode;
			if (mode == MODE.NORMAL || mode == MODE.RESTART)
			{
				cameraMan.keyEvent();
				slotMan.keyEvent();
				SGLGDebugYaku.keyEvent();
				SGLGDebugLED.keyEvent();
			}
			if (m_Mode == MODE.RESTART)
			{
				controlRestart();
			}
			base.keyEvent();
		}
	}

	public static void execEkisyo()
	{
		cameraMan.ekisyoTouch();
	}

	public static void execPush()
	{
		pushMan.setPush(true);
	}

	public static void execReel1()
	{
		slotMan.execReel1();
	}

	public static void execReel2()
	{
		slotMan.execReel2();
	}

	public static void execReel3()
	{
		slotMan.execReel3();
	}

	public static void execAuto()
	{
		if (!MainObjAuto.touchedInOneFrame)
		{
			slotMan.execAuto();
			MainObjAuto.touchedInOneFrame = true;
		}
	}

	private void Update()
	{
	}

	private void setModeBackFrom()
	{
		switch (backFrom)
		{
		case FROM.ADJ_NORMAL:
		{
			GameObject gameObject = createMenu();
			UIMenuTop component = gameObject.GetComponent<UIMenuTop>();
			component.m_FromAdjustment = true;
			break;
		}
		}
	}

	public static void loadTextures()
	{
	}

	public static void release()
	{
		SGLG.prod.Kill();
		SGLG.prodImg.Kill();
		SGLG.prodAnime.Kill();
		SGLG.sound.Stop();
		cameraMan = null;
		slotGameMan = null;
		slotMan = null;
		lotMan = null;
		dirMan = null;
		reelMan = null;
		ledMainMan = null;
		ledPanelMan = null;
		yakuMan = null;
		pushMan = null;
		dirLedMan = null;
		dirYakuMan = null;
		pnlMan.release();
		pnlMan = null;
		dir3MST_Sub = null;
		snd = null;
		m_EkisyoCamera = null;
		m_EkisyoCamera_Front = null;
		m_Kyoutai = null;
		m_MainCamera = null;
		m_SceneUpdater = null;
		m_TouchArea = null;
		m_GuiDirection = null;
		m_DataPanel = null;
		Object.Destroy(m_DataPanelObj);
		m_DataPanelObj = null;
		m_Dialog_09 = null;
		m_Dialog_21 = null;
		m_Dialog_GameEnd = null;
		m_Dialog_26 = null;
		Time.timeScale = 1f;
	}

	public static void PlayDataSave()
	{
		if (SGLG.gameMode == SGLG.GAMEMODE.HALL)
		{
			PlayUserData.save();
		}
		else
		{
			Sim_PlayUserData.save();
		}
	}

	public static void SlotDataSave()
	{
		if (SGLG.gameMode == SGLG.GAMEMODE.HALL)
		{
			SlotUserData.save();
			switch (slotGameMan.selectMachine)
			{
			case 0:
				SlotUserData_m1.save();
				break;
			case 1:
				SlotUserData_m2.save();
				break;
			case 2:
				SlotUserData_m3.save();
				break;
			case 3:
				SlotUserData_m4.save();
				break;
			case 4:
				SlotUserData_m5.save();
				break;
			case 5:
				SlotUserData_m6.save();
				break;
			case 6:
				SlotUserData_m7.save();
				break;
			case 7:
				SlotUserData_m8.save();
				break;
			case 8:
				SlotUserData_m9.save();
				break;
			case 9:
				SlotUserData_m10.save();
				break;
			}
		}
		else
		{
			Sim_SlotUserData.save();
		}
	}

	public static void SlotDataLoad()
	{
		if (SGLG.gameMode == SGLG.GAMEMODE.HALL)
		{
			SlotUserData.load();
			SlotUserData_m1.load();
			SlotUserData_m2.load();
			SlotUserData_m3.load();
			SlotUserData_m4.load();
			SlotUserData_m5.load();
			SlotUserData_m6.load();
			SlotUserData_m7.load();
			SlotUserData_m8.load();
			SlotUserData_m9.load();
			SlotUserData_m10.load();
		}
		else
		{
			Sim_SlotUserData.load();
			Sim_MachineData.load();
			Sim_MachineData.saveData.get();
			SGLGSimConfig.SimSetting = Sim_MachineData.saveData.dispSettei;
		}
	}

	public static void EndAutoPlay()
	{
		if (m_Mode == MODE.NORMAL && !(m_Dialog_AutoEnd != null))
		{
			m_Dialog_AutoEnd = SGLG.createDialog(29).GetComponent<UIDialog_29>();
			setMode(MODE.AUTOPLAY_END);
			pause();
		}
	}

	public static void pause()
	{
		SceneUpdater.prod.Pause();
		SceneUpdater.prodAnime.Pause();
		SceneUpdater.sound.Pause();
		SGLG.pause = true;
		Time.timeScale = 0f;
	}

	public static void resume()
	{
		SceneUpdater.prod.Resume();
		SceneUpdater.prodAnime.Resume();
		SceneUpdater.sound.Resume();
		SGLG.pause = false;
		Time.timeScale = 1f;
	}
}
