using UnityEngine;

public class DownloadScene : SceneUpdater
{
	private enum STATE
	{
		START = 0,
		CONFIRM_DL = 1,
		ALREADY_DL = 2,
		DOWNLOADING = 3,
		COMPLETED = 4,
		ERROR_RUNNING = 5,
		ERROR_STORAGE_NOT_AVAIL = 6,
		CONFIRM_RETRY = 7,
		CONFIRM_SD = 8,
		CONFIRM_QUIT = 9,
		QUIT = 10,
		MAX = 11
	}

	private const int TIMEOUT_CNT = 300;

	private const int REDRAW_CNT = 30;

	private STATE m_Current;

	private int m_CurrentCnt;

	private string expPath;

	private string mainPath;

	private string patchPath;

	private long mOverallTotal;

	private long mOverallProgress;

	private GameObject panelBar;

	private GameObject panelDownloading;

	private GameObject panelPersent1;

	private GameObject panelPersent2;

	private GameObject panelPersent3;

	private GameObject panelProgress;

	private UISlider slider;

	private UISprite keta1_001;

	private UISprite keta2_001;

	private UISprite keta2_010;

	private UISprite keta3_001;

	private UISprite keta3_010;

	private UISprite keta3_100;

	private UISprite[] progress = new UISprite[19];

	private UISprite sprTen;

	private UIDialog_01 m_Dialog_01;

	private UIDialog_02 m_Dialog_02;

	private UIDialog_12 m_Dialog_12;

	private UIDialog_13 m_Dialog_13;

	private int timeCnt;

	private bool isTimeOutCheck;

	private void Start()
	{
		SGLG.m_Scene = (DownloadScene)base.gameObject.GetComponent("DownloadScene");
		panelBar = GameObject.Find("Download/Camera/Anchor_1/Panel_Bar");
		panelDownloading = GameObject.Find("Download/Camera/Anchor_1/Panel_Downloading");
		panelPersent1 = GameObject.Find("Download/Camera/Anchor_1/Panel_Persent_keta_1");
		panelPersent2 = GameObject.Find("Download/Camera/Anchor_1/Panel_Persent_keta_2");
		panelPersent3 = GameObject.Find("Download/Camera/Anchor_1/Panel_Persent_keta_3");
		panelProgress = GameObject.Find("Download/Camera/Anchor_1/Panel_Progress");
		slider = GameObject.Find("Download/Camera/Anchor_1/Panel_Bar/Progress Bar").GetComponent<UISlider>();
		keta1_001 = GameObject.Find("Download/Camera/Anchor_1/Panel_Persent_keta_1/num_001").GetComponent<UISprite>();
		keta2_001 = GameObject.Find("Download/Camera/Anchor_1/Panel_Persent_keta_2/num_001").GetComponent<UISprite>();
		keta2_010 = GameObject.Find("Download/Camera/Anchor_1/Panel_Persent_keta_2/num_010").GetComponent<UISprite>();
		keta3_001 = GameObject.Find("Download/Camera/Anchor_1/Panel_Persent_keta_3/num_001").GetComponent<UISprite>();
		keta3_010 = GameObject.Find("Download/Camera/Anchor_1/Panel_Persent_keta_3/num_010").GetComponent<UISprite>();
		keta3_100 = GameObject.Find("Download/Camera/Anchor_1/Panel_Persent_keta_3/num_100").GetComponent<UISprite>();
		progress[0] = GameObject.Find("Panel_Progress/0_000_000_0_000_001").GetComponent<UISprite>();
		progress[1] = GameObject.Find("Panel_Progress/0_000_000_0_000_010").GetComponent<UISprite>();
		progress[2] = GameObject.Find("Panel_Progress/0_000_000_0_000_100").GetComponent<UISprite>();
		progress[3] = GameObject.Find("Panel_Progress/0_000_000_0_000X000").GetComponent<UISprite>();
		progress[4] = GameObject.Find("Panel_Progress/0_000_000_0_001_000").GetComponent<UISprite>();
		progress[5] = GameObject.Find("Panel_Progress/0_000_000_0_010_000").GetComponent<UISprite>();
		progress[6] = GameObject.Find("Panel_Progress/0_000_000_0_100_000").GetComponent<UISprite>();
		progress[7] = GameObject.Find("Panel_Progress/0_000_000_0X000_000").GetComponent<UISprite>();
		progress[8] = GameObject.Find("Panel_Progress/0_000_000_1_000_000").GetComponent<UISprite>();
		progress[9] = GameObject.Find("Panel_Progress/0_000_000X0_000_000").GetComponent<UISprite>();
		progress[10] = GameObject.Find("Panel_Progress/0_000_001_0_000_000").GetComponent<UISprite>();
		progress[11] = GameObject.Find("Panel_Progress/0_000_010_0_000_000").GetComponent<UISprite>();
		progress[12] = GameObject.Find("Panel_Progress/0_000_100_0_000_000").GetComponent<UISprite>();
		progress[13] = GameObject.Find("Panel_Progress/0_000X000_0_000_000").GetComponent<UISprite>();
		progress[14] = GameObject.Find("Panel_Progress/0_001_000_0_000_000").GetComponent<UISprite>();
		progress[15] = GameObject.Find("Panel_Progress/0_010_000_0_000_100").GetComponent<UISprite>();
		progress[16] = GameObject.Find("Panel_Progress/0_100_000_0_000_000").GetComponent<UISprite>();
		progress[17] = GameObject.Find("Panel_Progress/0X000_000_0_000_000").GetComponent<UISprite>();
		progress[18] = GameObject.Find("Panel_Progress/1_000_000_0_000_000").GetComponent<UISprite>();
		sprTen = GameObject.Find("Panel_Downloading/NowDownloading_2").GetComponent<UISprite>();
		panelBar.SetActive(false);
		panelDownloading.SetActive(false);
		panelPersent1.SetActive(false);
		panelPersent2.SetActive(false);
		panelPersent3.SetActive(false);
		panelProgress.SetActive(false);
	}

	private void confirm_quit()
	{
		setCurrent(STATE.CONFIRM_QUIT);
		m_Dialog_12 = SGLG.createDialog(12).GetComponent<UIDialog_12>();
	}

	private void confirm_sd()
	{
		setCurrent(STATE.CONFIRM_SD);
		m_Dialog_13 = SGLG.createDialog(13).GetComponent<UIDialog_13>();
	}

	private void confirm_retry()
	{
		setCurrent(STATE.CONFIRM_RETRY);
		m_Dialog_02 = SGLG.createDialog(2).GetComponent<UIDialog_02>();
	}

	private void setCurrent(STATE _cur)
	{
		m_Current = _cur;
		m_CurrentCnt = 0;
	}

	public override void init()
	{
		SGLG.deleteOldObb();
		m_Current = STATE.START;
		SGLG.endFade();
		m_IsOK = true;
		m_Dialog_01 = null;
		m_Dialog_02 = null;
		m_Dialog_13 = null;
		mOverallTotal = 0L;
		mOverallProgress = 0L;
	}

	public override void control()
	{
		if (!m_IsOK)
		{
			return;
		}
		switch (m_Current)
		{
		case STATE.START:
			if (SGLG.isFading)
			{
				break;
			}
			if (!ObbDownloader.RunningOnAndroid())
			{
				setCurrent(STATE.ERROR_RUNNING);
				break;
			}
			expPath = ObbDownloader.GetExpansionFilePath();
			if (expPath == null)
			{
				confirm_sd();
				break;
			}
			mainPath = ObbDownloader.GetMainOBBPath(expPath);
			patchPath = ObbDownloader.GetPatchOBBPath(expPath);
			if (mainPath == null || patchPath == null)
			{
				m_Dialog_01 = SGLG.createDialog(1).GetComponent<UIDialog_01>();
				setCurrent(STATE.CONFIRM_DL);
			}
			else
			{
				setCurrent(STATE.ALREADY_DL);
			}
			break;
		case STATE.CONFIRM_DL:
			if (m_Dialog_01.isEnd)
			{
				if (m_Dialog_01.m_DecideID == 0)
				{
					setCurrent(STATE.DOWNLOADING);
					ObbDownloader.FetchOBB();
					mOverallTotal = 0L;
					mOverallProgress = 0L;
					setPersent(-1);
					slider.sliderValue = 0f;
					panelBar.SetActive(true);
					panelDownloading.SetActive(true);
					panelProgress.SetActive(true);
					setProgress(0, 0);
					endTimeOutCheck();
				}
				Object.Destroy(m_Dialog_01.gameObject);
			}
			break;
		case STATE.ALREADY_DL:
			setCurrent(STATE.COMPLETED);
			SGLG.startFade();
			break;
		case STATE.DOWNLOADING:
			switch (ObbDownloader.getState())
			{
			case 1:
			case 2:
			case 3:
			case 4:
				if (isTimeOutCheck)
				{
					endTimeOutCheck();
				}
				if (m_CurrentCnt % 30 == 0)
				{
					mOverallTotal = ObbDownloader.getOverallTotal();
					mOverallProgress = ObbDownloader.getOverallProgress();
					if (mOverallTotal > 0)
					{
						slider.sliderValue = (float)mOverallProgress / (float)mOverallTotal;
						setPersent((int)(mOverallProgress * 100 / mOverallTotal));
						setProgress((int)(mOverallProgress / 1024), (int)(mOverallTotal / 1024));
					}
				}
				sprTen.enabled = m_CurrentCnt / 4 % 4 != 0;
				if (sprTen.enabled)
				{
					sprTen.spriteName = "download_ten" + m_CurrentCnt / 4 % 4;
				}
				break;
			case 5:
				setPersent(100);
				slider.sliderValue = 1f;
				setCurrent(STATE.COMPLETED);
				SGLG.startFade();
				break;
			case 6:
				if (isTimeOutCheck)
				{
					controlTimeOutCheck();
				}
				else
				{
					startTimeOutCheck();
				}
				break;
			case 8:
			case 9:
			case 10:
			case 11:
			case 12:
			case 13:
			case 14:
				confirm_retry();
				break;
			case 17:
				confirm_sd();
				break;
			case 15:
			case 16:
			case 18:
			case 19:
				confirm_quit();
				break;
			}
			break;
		case STATE.COMPLETED:
			if (SGLG.isFadeOutComplete())
			{
				SGLG.m_Mode = SGLG.MODE.GAMESTART;
			}
			break;
		case STATE.CONFIRM_RETRY:
			if (m_Dialog_02.isEnd && m_Dialog_02.m_DecideID == 0)
			{
				setCurrent(STATE.DOWNLOADING);
				ObbDownloader.OnResume();
				Object.Destroy(m_Dialog_02.gameObject);
			}
			break;
		case STATE.ERROR_STORAGE_NOT_AVAIL:
		case STATE.CONFIRM_SD:
			if (m_Dialog_13.isEnd && m_Dialog_13.m_DecideID == 0)
			{
				Application.Quit();
				Object.Destroy(m_Dialog_13.gameObject);
				setCurrent(STATE.QUIT);
			}
			break;
		case STATE.CONFIRM_QUIT:
			if (m_Dialog_12.isEnd && m_Dialog_12.m_DecideID == 0)
			{
				Application.Quit();
				Object.Destroy(m_Dialog_12.gameObject);
				setCurrent(STATE.QUIT);
			}
			break;
		}
		m_CurrentCnt++;
		base.control();
	}

	public override void controlReel()
	{
	}

	public override void controlFrame()
	{
	}

	public override void keyEvent()
	{
		base.keyEvent();
	}

	private void Update()
	{
	}

	private void OnApplicationFocus(bool focusStatus)
	{
		if (!focusStatus)
		{
		}
	}

	private void OnApplicationPause(bool pauseStatus)
	{
		if (pauseStatus)
		{
			ObbDownloader.OnPause();
			ObbDownloader.OnStop();
		}
		else
		{
			ObbDownloader.OnStart();
			ObbDownloader.OnResume();
		}
	}

	private void OnDestroy()
	{
		ObbDownloader.OnDestroy();
	}

	private void setPersent(int per)
	{
		if (per < 0)
		{
			panelPersent1.SetActive(false);
			panelPersent2.SetActive(false);
			panelPersent3.SetActive(false);
		}
		else if (per < 10)
		{
			panelPersent1.SetActive(true);
			panelPersent2.SetActive(false);
			panelPersent3.SetActive(false);
			keta1_001.spriteName = "download_pa_" + per;
		}
		else if (per < 100)
		{
			panelPersent1.SetActive(false);
			panelPersent2.SetActive(true);
			panelPersent3.SetActive(false);
			keta2_010.spriteName = "download_pa_" + per % 10;
			keta2_001.spriteName = "download_pa_" + per / 10 % 10;
		}
		else
		{
			panelPersent1.SetActive(false);
			panelPersent2.SetActive(false);
			panelPersent3.SetActive(true);
			keta3_100.spriteName = "download_pa_" + per % 10;
			keta3_010.spriteName = "download_pa_" + per / 10 % 10;
			keta3_001.spriteName = "download_pa_" + per / 100 % 10;
		}
	}

	private void setProgress(int now, int total)
	{
		int[] array = new int[10];
		int[] array2 = new int[10];
		int num = 1;
		for (int i = 0; i < 10; i++)
		{
			array[i] = now / num % 10;
			array2[i] = total / num % 10;
			num *= 10;
		}
		progress[0].enabled = true;
		progress[1].enabled = total >= 10;
		progress[2].enabled = total >= 100;
		progress[3].enabled = total >= 1000;
		progress[4].enabled = total >= 1000;
		progress[5].enabled = total >= 10000;
		progress[6].enabled = total >= 100000;
		progress[7].enabled = total >= 1000000;
		progress[8].enabled = total >= 1000000;
		progress[10].enabled = true;
		progress[11].enabled = now >= 10;
		progress[12].enabled = now >= 100;
		progress[13].enabled = now >= 1000;
		progress[14].enabled = now >= 1000;
		progress[15].enabled = now >= 10000;
		progress[16].enabled = now >= 100000;
		progress[17].enabled = now >= 1000000;
		progress[18].enabled = now >= 1000000;
		progress[0].spriteName = "download_yo_" + array2[0];
		progress[1].spriteName = "download_yo_" + array2[1];
		progress[2].spriteName = "download_yo_" + array2[2];
		progress[3].spriteName = "download_yo_c";
		progress[4].spriteName = "download_yo_" + array2[3];
		progress[5].spriteName = "download_yo_" + array2[4];
		progress[6].spriteName = "download_yo_" + array2[5];
		progress[7].spriteName = "download_yo_c";
		progress[8].spriteName = "download_yo_" + array2[6];
		progress[9].spriteName = "download_yo_s";
		progress[10].spriteName = "download_yo_" + array[0];
		progress[11].spriteName = "download_yo_" + array[1];
		progress[12].spriteName = "download_yo_" + array[2];
		progress[13].spriteName = "download_yo_c";
		progress[14].spriteName = "download_yo_" + array[3];
		progress[15].spriteName = "download_yo_" + array[4];
		progress[16].spriteName = "download_yo_" + array[5];
		progress[17].spriteName = "download_yo_c";
		progress[18].spriteName = "download_yo_" + array[6];
	}

	private void startTimeOutCheck()
	{
		timeCnt = 0;
		isTimeOutCheck = true;
	}

	private void endTimeOutCheck()
	{
		timeCnt = 0;
		isTimeOutCheck = false;
	}

	private void resetTimeOutCheck()
	{
		timeCnt = 0;
	}

	private void controlTimeOutCheck()
	{
		if (isTimeOutCheck)
		{
			timeCnt++;
			if (timeCnt >= 300)
			{
				ObbDownloader.OnPause();
				confirm_retry();
				endTimeOutCheck();
			}
		}
	}
}
