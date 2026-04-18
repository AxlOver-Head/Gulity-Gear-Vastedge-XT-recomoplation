using System.IO;
using UnityEngine;

public class SGLG : MonoBehaviour
{
	public enum MODE
	{
		NONE = 0,
		INIT = 1,
		LOGO = 2,
		DOWNLOAD = 3,
		GAMESTART = 4,
		TITLE = 5,
		HALL = 6,
		MAIN = 7,
		ADJUSTMENT = 8,
		SIM_RESTART = 9,
		MAX = 10
	}

	public enum VIEWMODE
	{
		NONE = 0,
		IPHONE4 = 1,
		IPHONE5 = 2,
		IPAD = 3,
		ANDROID = 4
	}

	public enum GAMEMODE
	{
		NONE = 0,
		HALL = 1,
		SIMULATION = 2
	}

	public const float FPS = 60f;

	public const float FRAMERATE = 16.666666f;

	private const int MEDAL_KORYAKU = 10000;

	public static readonly int OBB_VERSION = 4;

	private static float nowtime;

	private static float nexttime;

	public static float deltaTime;

	private static bool updateFlag = true;

	private static bool first;

	private static bool initialize;

	public static MODE m_OldMode;

	public static MODE m_Mode;

	public static SceneUpdater m_Scene;

	public static Production prod;

	public static ProductionImg prodImg;

	public static ProductionAnime prodAnime;

	public static Sound sound;

	public static int scrW;

	public static int scrH;

	public static float aspect;

	private int skipnum;

	private float keikaTime;

	public static VIEWMODE viewMode;

	public static bool isUpdateDirection;

	public static bool isLoading;

	public static UILoading loading;

	public static bool isFading;

	public static UIFader fader;

	public static WebBrowser browser;

	public static bool isBrowsing;

	public static bool pause;

	public static string URL_TITLE_ENJOYMORE = "http://d777.jp/Static.php?name=sglg_playmore&i=";

	public static string URL_ADJUSTMENT_DETAIL = "http://d777.jp/Static.php?name=sglg_playmore&i=";

	public static string URL_ADJUSTMENT_TOUROKU = "http://afte.mopo.jp/click?m=31554&a=190735";

	public static string URL_MENU_DETAIL = "http://d777.jp/Static.php?name=sglg_playmore&i=";

	public static string URL_REVIEW = "https://play.google.com/store/apps/details?id=com.dtechno.slotguilty";

	public static string URL_PHP = "https://d777.jp/api/sglg.php";

	public static GrfNetwork network;

	public static GameObject m_GameObj;

	private static AsyncOperation m_AO;

	public static bool isCompleteResource;

	public static bool isSceneChange;

	public static GAMEMODE gameMode;

	public static bool isSpecificDevice;

	private void Awake()
	{
		m_GameObj = base.gameObject;
		Application.targetFrameRate = 60;
		nexttime = Time.realtimeSinceStartup;
		deltaTime = Time.realtimeSinceStartup;
		m_OldMode = MODE.INIT;
		m_Mode = MODE.INIT;
		scrW = Screen.width;
		scrH = Screen.height;
		viewMode = VIEWMODE.ANDROID;
		Screen.sleepTimeout = -1;
		network = base.gameObject.AddComponent<GrfNetwork>() as GrfNetwork;
		isCompleteResource = checkAndroidResourceOK();
		isSpecificDevice = isDeviceModel();
		Screen.fullScreen = false;
	}

	private void Start()
	{
		Object.DontDestroyOnLoad(base.gameObject);
		Screen.fullScreen = false;
	}

	public static bool isReady()
	{
		if (prod == null)
		{
			return false;
		}
		if (prodImg == null)
		{
			return false;
		}
		if (prodAnime == null)
		{
		}
		if (sound == null)
		{
			return false;
		}
		if (!prod.isBindOK())
		{
			return false;
		}
		if (!sound.isBindOK())
		{
			return false;
		}
		return true;
	}

	private void init()
	{
		Screen.fullScreen = false;
	}

	private void OnDestroy()
	{
		if (prod != null)
		{
			prod.Dispose(false);
		}
		if (prodImg != null)
		{
			prodImg.Dispose(false);
		}
		if (prodAnime != null)
		{
			prodAnime.Dispose(false);
		}
		if (sound != null)
		{
			sound.Dispose(false);
		}
	}

	private static void change()
	{
		m_Scene = null;
		switch (m_Mode)
		{
		case MODE.LOGO:
			m_AO = Application.LoadLevelAsync("LogoScene");
			m_AO.priority = 1000;
			break;
		case MODE.DOWNLOAD:
			m_AO = Application.LoadLevelAsync("DownloadScene");
			m_AO.priority = 1000;
			break;
		case MODE.GAMESTART:
			m_AO = Application.LoadLevelAsync("GameStartScene");
			m_AO.priority = 1000;
			break;
		case MODE.TITLE:
			m_AO = Application.LoadLevelAsync("TitleScene");
			m_AO.priority = 1000;
			break;
		case MODE.HALL:
			m_AO = Application.LoadLevelAsync("hall");
			m_AO.priority = 1000;
			break;
		case MODE.MAIN:
			m_AO = Application.LoadLevelAsync("MainGameScene");
			m_AO.priority = 1000;
			break;
		case MODE.ADJUSTMENT:
			m_AO = Application.LoadLevelAsync("AdjastmentScene");
			m_AO.priority = 1000;
			break;
		case MODE.SIM_RESTART:
			m_AO = Application.LoadLevelAsync("SimRestartScene");
			m_AO.priority = 1000;
			break;
		}
		isSceneChange = true;
		m_OldMode = m_Mode;
	}

	public void control()
	{
		Screen.fullScreen = false;
		if (!first)
		{
			init();
			first = true;
		}
		if (m_Mode != m_OldMode)
		{
			change();
			initialize = false;
		}
		else if (!(m_Scene == null))
		{
			if (!initialize)
			{
				Resources.UnloadUnusedAssets();
				m_Scene.init();
				initialize = true;
			}
			m_Scene.control();
		}
	}

	public void controlFrame()
	{
		if (!first)
		{
			init();
			first = true;
		}
		if (!(m_Scene == null) && m_Scene.isOK())
		{
			SlotBodyManager.notUpdate = false;
			m_Scene.controlFrame();
		}
	}

	public void controlReel()
	{
		if (!first)
		{
			init();
			first = true;
		}
		if ((m_Mode == MODE.MAIN || m_Mode == MODE.HALL) && !(m_Scene == null) && m_Scene.isOK())
		{
			m_Scene.controlReel();
		}
	}

	public void keyEvent()
	{
		if (!(m_Scene == null))
		{
			m_Scene.keyEvent();
		}
	}

	private void Update()
	{
		deltaTime = Time.realtimeSinceStartup - nowtime;
		nowtime = Time.realtimeSinceStartup;
		SGLGInput.update();
		keyEvent();
		if (!(nowtime >= nexttime))
		{
			return;
		}
		keikaTime = nowtime - nexttime;
		float num = 16.666666f;
		skipnum = (int)(keikaTime * 1000f / num) + 1;
		syncEkisyo();
		controlFrame();
		for (int i = 0; i < skipnum; i++)
		{
			if (m_AO != null)
			{
				if (!m_AO.isDone)
				{
					break;
				}
				isSceneChange = false;
				m_AO = null;
			}
			if (updateFlag)
			{
				control();
				controlReel();
				updateFlag = false;
			}
			else
			{
				controlReel();
				updateFlag = true;
			}
		}
		syncEkisyo();
		nexttime += num * (float)skipnum / 1000f;
	}

	private void syncEkisyo()
	{
		if (!isReady())
		{
			return;
		}
		isUpdateDirection = true;
		if (prod.checkPreparing() || prodAnime.checkPreparing())
		{
			isUpdateDirection = false;
			MainGameScene.forceSetVisibleOff();
			if (prod.isHold())
			{
				prod.DisableHeldMovie();
			}
		}
		else if (prod.check_87YFC())
		{
			isUpdateDirection = false;
			MainGameScene.forceSetVisibleOff();
			if (prod.isHold())
			{
				prod.DisableHeldMovie();
			}
		}
		else if (prod.isReadyStaying())
		{
			isUpdateDirection = false;
			MainGameScene.forceSetVisibleOff();
			prod.playReadyStay();
		}
		else
		{
			MainGameScene.forceSetVisibleOn();
		}
	}

	private void OnApplicationPause(bool pauseStatus)
	{
		if (pauseStatus)
		{
			suspend();
		}
		else
		{
			resume();
		}
	}

	private void suspend()
	{
		UserData.close();
		PlayUserData.close();
		SlotUserData.close();
		if (isReady())
		{
			suspendAndroid();
		}
	}

	private void resume()
	{
		nexttime = Time.realtimeSinceStartup + 0.016666666f;
		if (isReady())
		{
			resumeAndroid();
		}
	}

	private void gotoResumeScene(MODE next)
	{
		if (isBrowsing)
		{
			isBrowsing = false;
			if (browser != null)
			{
				// Removed IWebView.release() - no longer needed with Application.OpenURL()
				Object.Destroy(browser.gameObject);
				browser = null;
			}
		}
		if (isFading)
		{
			isFading = false;
			if (fader != null)
			{
				Object.Destroy(fader.gameObject);
				fader = null;
			}
		}
		prod.Kill();
		prodImg.Kill();
		prodAnime.Kill();
		sound.Stop();
		ResumeScene.nextMode = next;
		Application.LoadLevel("ResumeScene");
	}

	private void suspendAndroid()
	{
		if (!(loading != null))
		{
			prod.Kill();
			prodImg.Kill();
			prodAnime.Kill();
			sound.Stop();
		}
	}

	private void resumeAndroid()
	{
		if (loading != null)
		{
			return;
		}
		switch (m_Mode)
		{
		case MODE.INIT:
			break;
		case MODE.LOGO:
			break;
		case MODE.DOWNLOAD:
			break;
		case MODE.GAMESTART:
			break;
		case MODE.TITLE:
			gotoResumeScene(MODE.TITLE);
			break;
		case MODE.HALL:
			gotoResumeScene(MODE.HALL);
			break;
		case MODE.MAIN:
			gotoResumeScene(MODE.MAIN);
			break;
		case MODE.ADJUSTMENT:
			switch (AdjustmentScene.getMode())
			{
			case AdjustmentScene.MODE.CARD:
				gotoResumeScene(MODE.TITLE);
				break;
			case AdjustmentScene.MODE.RECEIPT:
			case AdjustmentScene.MODE.LOGIN:
				gotoResumeScene(MODE.ADJUSTMENT);
				break;
			case AdjustmentScene.MODE.SEND:
				if (UserData.saveData.game.motiMedals <= 0)
				{
					gotoResumeScene(MODE.TITLE);
				}
				else
				{
					gotoResumeScene(MODE.ADJUSTMENT);
				}
				break;
			}
			break;
		}
	}

	public static void restartScene()
	{
		m_Mode = ResumeScene.nextMode;
		change();
		initialize = false;
	}

	public static void deleteOldObb()
	{
		string empty = string.Empty;
		FileInfo fileInfo = null;
		for (int i = 0; i < OBB_VERSION; i++)
		{
			empty = getStreamingPath() + "/" + GooglePlayDownloader.GetMainOBBPath(i);
			fileInfo = new FileInfo(empty);
			if (fileInfo.Exists)
			{
				if ((fileInfo.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
				{
					fileInfo.Attributes = FileAttributes.Normal;
				}
				fileInfo.Delete();
			}
		}
		for (int j = 0; j < OBB_VERSION; j++)
		{
			empty = getStreamingPath() + "/" + GooglePlayDownloader.GetPatchOBBPath(j);
			fileInfo = new FileInfo(empty);
			if (fileInfo.Exists)
			{
				if ((fileInfo.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
				{
					fileInfo.Attributes = FileAttributes.Normal;
				}
				fileInfo.Delete();
			}
		}
	}

	private void OnApplicationQuit()
	{
		release();
	}

	private void release()
	{
	}

	public static void startLoading()
	{
		if (!isLoading && !(loading != null))
		{
			isLoading = true;
			GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("prefabs/Loading"), new Vector3(99999f, 99999f, 0f), Quaternion.identity);
			loading = gameObject.GetComponent<UILoading>();
			loading.init();
		}
	}

	public static void endLoading()
	{
		if (!(loading == null) && !loading.isEnding)
		{
			loading.end();
		}
	}

	public static void startFade()
	{
		startFade(UIFader.ALPHA_ADD_FADE);
	}

	public static void startFade_Fast()
	{
		startFade(UIFader.ALPHA_ADD_FAST);
	}

	public static void startFade(float spd)
	{
		if (!isFading && !(fader != null))
		{
			UIFader.fadeSpeed = spd;
			isFading = true;
			GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("prefabs/Fader"), new Vector3(-99999f, -99999f, 0f), Quaternion.identity);
			fader = gameObject.GetComponent<UIFader>();
			fader.init();
		}
	}

	public static void startFadeWhite()
	{
		startFadeWhite(UIFader.ALPHA_ADD_FADE);
	}

	public static void startFadeWhite_Fast()
	{
		startFadeWhite(UIFader.ALPHA_ADD_FAST);
	}

	public static void startFadeWhite(float spd)
	{
		if (!isFading && !(fader != null))
		{
			UIFader.fadeSpeed = spd;
			isFading = true;
			GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("prefabs/Fader"), new Vector3(-99999f, -99999f, 0f), Quaternion.identity);
			fader = gameObject.GetComponent<UIFader>();
			fader.init();
			fader.WI_Fade.color = new Color(1f, 1f, 1f, 0f);
		}
	}

	public static void endFade()
	{
		if (!(fader == null) && !fader.isEnding)
		{
			fader.end();
		}
	}

	public static bool isFadeOutComplete()
	{
		if (fader == null)
		{
			return false;
		}
		return fader.isFadeOutComplete();
	}

	public static void launchWebBrowser(string url)
	{
		if (!isBrowsing)
		{
			isBrowsing = true;
			GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("prefabs/WebBrowser"), new Vector3(99999f, 99999f, 0f), Quaternion.identity);
			browser = gameObject.GetComponent<WebBrowser>();
			browser.target = m_Scene.gameObject;
			browser.functionName = "OnBrowseEvent_Close";
			browser.OpenURL(url);
		}
	}

	public static GameObject createDialog(int _id)
	{
		return (GameObject)Object.Instantiate(Resources.Load("prefabs/Dialog_" + string.Format("{0:00}", _id)), new Vector3(50000f, 50000f, 0f), Quaternion.identity);
	}

	public static void DataSendComplete()
	{
		int seisanRuiMai = PlayUserData.saveData.m_seisanRuiMai;
		if (seisanRuiMai >= 10000)
		{
			PlayUserData.saveData.m_kouryakuFlag = 1;
		}
		PlayUserData.save();
		for (int i = 0; i < 10; i++)
		{
			HistoryData hisData = UserData.saveData.game.getMachineData(i).hisData;
			int bnsBBCntYesterDay = hisData.bnsPBCnt + hisData.bnsGBCnt + hisData.bnsSGBCnt;
			UserData.saveData.game.getMachineData(i).hisData.bnsBBCntYesterDay = bnsBBCntYesterDay;
			UserData.saveData.game.getMachineData(i).hisData.bnsRBCntYesterDay = hisData.bnsRBCnt;
			UserData.saveData.game.getMachineData(i).hisData.artCntYesterDay = hisData.artCnt;
			UserData.saveData.game.getMachineData(i).clear();
			UserData.saveData.hall.npcGameCnt[i] = 0;
		}
		UserData.saveData.hall.gameStart = false;
		UserData.saveData.hall.gameDayCnt = 0;
		UserData.saveData.game.motiMedals = 0;
		UserData.saveData.game.selectMachine = -1;
		UserData.save();
		SlotUserData.clear();
		SlotUserData.save();
		SlotUserData_m1.clear();
		SlotUserData_m2.clear();
		SlotUserData_m3.clear();
		SlotUserData_m4.clear();
		SlotUserData_m5.clear();
		SlotUserData_m6.clear();
		SlotUserData_m7.clear();
		SlotUserData_m8.clear();
		SlotUserData_m9.clear();
		SlotUserData_m10.clear();
		SlotUserData_m1.save();
		SlotUserData_m2.save();
		SlotUserData_m3.save();
		SlotUserData_m4.save();
		SlotUserData_m5.save();
		SlotUserData_m6.save();
		SlotUserData_m7.save();
		SlotUserData_m8.save();
		SlotUserData_m9.save();
		SlotUserData_m10.save();
	}

	public static void DataSaveComplete()
	{
		int num = PlayUserData.saveData.m_seisanRuiMai + UserData.saveData.game.motiMedals;
		if (num >= 10000)
		{
			PlayUserData.saveData.m_kouryakuFlag = 1;
		}
		PlayUserData.save();
		for (int i = 0; i < 10; i++)
		{
			HistoryData hisData = UserData.saveData.game.getMachineData(i).hisData;
			int bnsBBCntYesterDay = hisData.bnsPBCnt + hisData.bnsGBCnt + hisData.bnsSGBCnt;
			UserData.saveData.game.getMachineData(i).hisData.bnsBBCntYesterDay = bnsBBCntYesterDay;
			UserData.saveData.game.getMachineData(i).hisData.bnsRBCntYesterDay = hisData.bnsRBCnt;
			UserData.saveData.game.getMachineData(i).hisData.artCntYesterDay = hisData.artCnt;
			UserData.saveData.game.getMachineData(i).clear();
			UserData.saveData.hall.npcGameCnt[i] = 0;
		}
		UserData.saveData.hall.gameStart = false;
		UserData.saveData.hall.gameDayCnt = 0;
		UserData.saveData.game.selectMachine = -1;
		UserData.save();
		SlotUserData.clear();
		SlotUserData.save();
		SlotUserData_m1.clear();
		SlotUserData_m2.clear();
		SlotUserData_m3.clear();
		SlotUserData_m4.clear();
		SlotUserData_m5.clear();
		SlotUserData_m6.clear();
		SlotUserData_m7.clear();
		SlotUserData_m8.clear();
		SlotUserData_m9.clear();
		SlotUserData_m10.clear();
		SlotUserData_m1.save();
		SlotUserData_m2.save();
		SlotUserData_m3.save();
		SlotUserData_m4.save();
		SlotUserData_m5.save();
		SlotUserData_m6.save();
		SlotUserData_m7.save();
		SlotUserData_m8.save();
		SlotUserData_m9.save();
		SlotUserData_m10.save();
	}

	public static void DataSaveEndSimulation()
	{
		Sim_MachineData.clear();
		Sim_MachineData.save();
		Sim_SlotUserData.clear();
		Sim_SlotUserData.save();
	}

	public static void prodAllStop()
	{
		prod.Kill();
		prodImg.Kill();
		prodAnime.Kill();
		sound.Stop();
	}

	public static string getCpkFilePath()
	{
		string empty = string.Empty;
		return GooglePlayDownloader.GetMainOBBPath();
	}

	public static string getSubFilePath()
	{
		string empty = string.Empty;
		return GooglePlayDownloader.GetPatchOBBPath();
	}

	public static string getStreamingPath()
	{
		string empty = string.Empty;
		return GooglePlayDownloader.GetExpansionFilePath();
	}

	public static byte[] readBinary(string fileName)
	{
		string path = getStreamingPath() + "/" + getSubFilePath();
		int head = SubResource.getHead(fileName);
		int size = SubResource.getSize(fileName);
		FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
		BinaryReader binaryReader = new BinaryReader(fileStream);
		fileStream.Seek(head, SeekOrigin.Begin);
		byte[] array = binaryReader.ReadBytes(size);
		binaryReader.Close();
		for (int i = 0; i < array.Length && i < 32; i++)
		{
			array[i] ^= byte.MaxValue;
		}
		return array;
	}

	private bool checkAndroidResourceOK()
	{
		if (ObbDownloader.RunningOnAndroid() && ObbDownloader.IsRequiredDownload())
		{
			return false;
		}
		return true;
	}

	public bool isDeviceModel()
	{
		bool result = false;
		string deviceModel = SystemInfo.deviceModel;
		if (deviceModel.Contains("SO-01E"))
		{
			result = true;
		}
		else if (deviceModel.Contains("SO-03E"))
		{
			result = true;
		}
		else if (deviceModel.Contains("SO-04E"))
		{
			result = true;
		}
		else if (deviceModel.Contains("SOL22"))
		{
			result = true;
		}
		return result;
	}
}