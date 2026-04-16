using System;
using UnityEngine;

public class hallContlloer : SceneUpdater
{
	public enum _STATE
	{
		INIT = 0,
		MAKE = 1,
		HALL_INIT = 2,
		HALL_START = 3,
		IDLE = 4,
		MOVE = 5,
		GAME_START = 6,
		GAME_END = 7,
		GAME_END_ADJIS = 8,
		GAME_END_FORCE = 9,
		ADJUSTMENT = 10,
		WAIT = 11
	}

	private enum _MACHINE_STATE
	{
		OPEN = 0,
		DEMO = 1,
		NORMAL = 2,
		BONUS = 3,
		ART = 4,
		MAX = 5
	}

	private enum _BILL
	{
		HIGHT = 0,
		LOW = 1,
		ODD = 2,
		EVENT = 3,
		EXPECTED = 4,
		CHANCE = 5,
		HEVEN_OR_HELL = 6
	}

	private enum _HALL_EVENT
	{
		_NORMAL = 0,
		_ODD_VS_EVEN = 1,
		_HEVEN_OR_HELL = 2,
		_HEVEN_OR_HELL_AND_NYANKO = 3,
		_HIGH = 4,
		_HIGH_AND_NYANKO = 5,
		_HIGHEST = 6
	}

	private enum _BTN
	{
		ALLOW_RIGHT = 0,
		ALLOW_LEFT = 1,
		DATA_PANEL = 2,
		FAST_GAME = 3,
		ADJISTMENT = 4,
		NON_GAME_ADJIS_OK = 5,
		NON_GAME_ADJIS_NO = 6,
		SELECT_MACHINE = 7,
		DLOG_BTN_ON = 8,
		DLOG_BTN_NONE = 9,
		BTN_MAX = 10
	}

	private const string popAnimName = "pop_up_ani";

	public const short SELECT_MAX = 10;

	private const int SETTEI_MAX = 6;

	private const int DOLLBOX_MAX = 10;

	private const int DAY_ONCE_SCENE = 600;

	private const int BILL_TYPE_MAX = 7;

	private const int PERSON_TYPE_MAX = 3;

	private const int PERSON_MAX = 5;

	private const int PERSON_EVENT_MAX = 6;

	public const int ONE_DAY_GAME_MAX = 10000;

	public const int ONE_DAY_GAME_MAX_SIM = 99999;

	private const float ONE_GAME_TIME = 4.1f;

	private const float RAND_VALUE_100 = 100f;

	private const short MONEY_MAX = 4;

	private const short PANEL_MODE_MAX = 3;

	private const int TOUCH_PANEL_OBJ_MAX = 6;

	private const int HIS_TUBU_GAME_MAX = 5;

	private const int HIS_TUBU_CNT_MAX = 10;

	private const int INFO_PANEL_ANIM_MAX = 3;

	private const int INFO_PANEL_NUM = 5;

	private const int DOLLBOX_BILL_MAX = 3;

	private const float SE_VOL = 0.5f;

	private const float HALLIN_FADE_UPDATETIME = 15f;

	private const float DIALG_FADE_UPDATETIME = 10f;

	private const float DIALOG_BACK_ALPHA = 0.75f;

	private const string eskCameaAnim = "eska_camera_ani";

	private const int FLICK_RANGE = 40;

	private const float CUTIN_MOVE_TIME = 0.016f;

	private const float OPTION_SIDE_IN_VALUE = 20f;

	private const float OPTION_OPEN_ANGLE = 30f;

	private static string[] BtnObjName = new string[10]
	{
		"btn_move_right",
		"btn_move_left",
		"header_col",
		"btn_game_fast",
		"btn_pay",
		string.Empty,
		string.Empty,
		"btn_gameStart",
		"btn_ok",
		"btn_cancel"
	};

	private Vector3[] machinePos = new Vector3[10]
	{
		new Vector3(-1.571975f, -2.445003f, -0.5371806f),
		new Vector3(-2.774693f, -2.445003f, 0.6644099f),
		new Vector3(-3.214311f, -2.445003f, 2.304544f),
		new Vector3(-2.774235f, -2.445003f, 3.945101f),
		new Vector3(-1.572684f, -2.445003f, 5.14889f),
		new Vector3(1.705372f, -2.445003f, 5.145744f),
		new Vector3(2.905842f, -2.445003f, 3.946027f),
		new Vector3(3.346098f, -2.445003f, 2.306248f),
		new Vector3(2.908772f, -2.445003f, 0.6668341f),
		new Vector3(1.706755f, -2.445003f, -0.5338603f)
	};

	private Vector3[] machineAngles = new Vector3[10]
	{
		new Vector3(0f, 210f, 0f),
		new Vector3(0f, 240f, 0f),
		new Vector3(0f, 270f, 0f),
		new Vector3(0f, 300f, 0f),
		new Vector3(0f, 330f, 0f),
		new Vector3(0f, 30f, 0f),
		new Vector3(0f, 60f, 0f),
		new Vector3(0f, 90f, 0f),
		new Vector3(0f, 120f, 0f),
		new Vector3(0f, 150f, 0f)
	};

	private Vector3[] personManPos = new Vector3[10]
	{
		new Vector3(-1.310684f, -2.210535f, -0.0284146f),
		new Vector3(-2.298305f, -2.210535f, 0.9802938f),
		new Vector3(-2.642123f, -2.210535f, 2.341105f),
		new Vector3(-2.265601f, -2.210535f, 3.680351f),
		new Vector3(-1.267476f, -2.210535f, 4.658324f),
		new Vector3(1.444566f, -2.210535f, 4.637302f),
		new Vector3(2.427845f, -2.210535f, 3.635588f),
		new Vector3(2.776316f, -2.210535f, 2.273741f),
		new Vector3(2.392291f, -2.210535f, 0.9166909f),
		new Vector3(1.387148f, -2.210535f, -0.05676402f)
	};

	private Vector3[] personWomanPos = new Vector3[10]
	{
		new Vector3(-1.295771f, -2.210535f, -0.03702474f),
		new Vector3(-2.285436f, -2.210535f, 0.9602614f),
		new Vector3(-2.638978f, -2.210535f, 2.310192f),
		new Vector3(-2.269059f, -2.210535f, 3.671266f),
		new Vector3(-1.26974f, -2.210535f, 4.657333f),
		new Vector3(1.416389f, -2.210535f, 4.655499f),
		new Vector3(2.415678f, -2.210535f, 3.65388f),
		new Vector3(2.774794f, -2.210535f, 2.292048f),
		new Vector3(2.408438f, -2.210535f, 0.9431182f),
		new Vector3(1.416574f, -2.210535f, -0.05011072f)
	};

	private Vector3[] personOssanPos = new Vector3[10]
	{
		new Vector3(-1.290517f, -2.210535f, -0.04005815f),
		new Vector3(-2.277298f, -2.210535f, 0.9476446f),
		new Vector3(-2.63881f, -2.210535f, 2.313442f),
		new Vector3(-2.276263f, -2.210535f, 3.652423f),
		new Vector3(-1.289846f, -2.210535f, 4.64304f),
		new Vector3(1.407952f, -2.210535f, 4.655448f),
		new Vector3(2.402487f, -2.210535f, 3.669642f),
		new Vector3(2.772895f, -2.210535f, 2.302887f),
		new Vector3(2.404136f, -2.210535f, 0.9466953f),
		new Vector3(1.418716f, -2.210535f, -0.03605628f)
	};

	private int[][] hallMode = new int[4][]
	{
		new int[7] { 80, 5, 5, 1, 5, 1, 3 },
		new int[7] { 60, 10, 10, 2, 10, 2, 6 },
		new int[7] { 0, 0, 0, 0, 45, 10, 45 },
		new int[7] { 0, 0, 25, 5, 40, 10, 20 }
	};

	private int[][] billRots = new int[6][]
	{
		new int[7] { 0, 20, 30, 0, 0, 30, 20 },
		new int[7] { 0, 0, 0, 50, 0, 50, 0 },
		new int[7] { 0, 0, 50, 0, 0, 50, 0 },
		new int[7] { 0, 0, 0, 50, 50, 0, 0 },
		new int[7] { 0, 0, 50, 0, 50, 0, 0 },
		new int[7] { 20, 0, 0, 30, 25, 0, 25 }
	};

	private int[] isSitRotCnt = new int[17]
	{
		5, 10, 10, 20, 20, 30, 30, 50, 50, 30,
		20, 10, 5, 10, 20, 50, 100
	};

	private int[][] sitRot = new int[3][]
	{
		new int[17]
		{
			10, 20, 20, 40, 40, 60, 60, 100, 100, 60,
			40, 20, 10, 20, 40, 100, 200
		},
		new int[17]
		{
			25, 50, 50, 100, 100, 150, 150, 250, 250, 150,
			100, 50, 25, 50, 100, 250, 500
		},
		new int[17]
		{
			50, 100, 100, 200, 200, 300, 300, 500, 500, 300,
			200, 100, 50, 100, 200, 500, 1000
		}
	};

	private int[][] personType = new int[3][]
	{
		new int[17]
		{
			60, 60, 50, 40, 30, 20, 20, 15, 10, 15,
			20, 34, 34, 34, 34, 34, 34
		},
		new int[17]
		{
			10, 10, 20, 20, 20, 30, 20, 15, 10, 15,
			20, 33, 33, 33, 33, 33, 33
		},
		new int[17]
		{
			30, 30, 30, 40, 50, 50, 60, 70, 80, 70,
			60, 33, 33, 33, 33, 33, 33
		}
	};

	private int[][] sitCheckBill = new int[3][]
	{
		new int[7] { 100, 0, 0, 0, 0, 75, 75 },
		new int[7] { 100, 0, 0, 0, 0, 100, 100 },
		new int[7] { 100, 0, 0, 0, 0, 50, 50 }
	};

	private _STATE state;

	private short select;

	private bool buttonDown;

	private bool buttonUp;

	private bool gCutInMoveFlag;

	private int[] persons = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

	private short personCnt;

	private int gameDayCnt;

	private float gameTime;

	private float gameUpdateTime;

	private int panelInfoIdx;

	private int sumilationOn;

	private float bgmVol;

	public static _STATE firstState = _STATE.INIT;

	private GameObject mainCamera;

	private GameObject machineRoot;

	private GameObject personRoot;

	private GameObject neko;

	private GameObject kaidan_oya;

	private GameObject start_Camera;

	private GameObject hallUIObj;

	private GameObject escalatorUIObj;

	private GameObject Panel_info;

	private GameObject panelBullboadObj;

	private GameObject panelHeader;

	private GameObject Panel_com_bg;

	private GameObject popup_chakuseki;

	private GameObject popup_seisan_no;

	private GameObject btn_game_fast_yajirusi;

	private GameObject[] infoPanelPatternAnim = new GameObject[3];

	private GameObject[] machineObj = new GameObject[10];

	private GameObject[] btnObj = new GameObject[BtnObjName.Length];

	private GameObject[] personObj = new GameObject[10];

	private GameObject[] billObj = new GameObject[10];

	private GameObject[][] dollObj = new GameObject[10][];

	private GameObject[] touchDataPalen = new GameObject[6];

	private GameObject[][] tubu_rirekiObj = new GameObject[5][];

	private UISpriteAnimation[][] tubu_rirekiAnim = new UISpriteAnimation[5][];

	private Camera UICamera;

	private _MACHINE_STATE[] machineState = new _MACHINE_STATE[10];

	private Machine[] machine = new Machine[10];

	private int[] settei = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

	private int[] bill = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

	private int[] npcCoin = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

	private int[] npcMoney = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

	private int[] npcGameCnt = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

	private int[] npcdollIdx = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

	private int dayEvent;

	private short panelMode;

	private NumberFont game_count;

	private NumberFont game_num;

	private NumberFont art_count;

	private NumberFont bb_count;

	private NumberFont rb_count;

	private NumberFont art_count_denominator;

	private NumberFont art_count_numerator;

	private NumberFont bb_count_denominator;

	private NumberFont bb_count_numerator;

	private NumberFont rb_count_denominator;

	private NumberFont rb_count_numerator;

	private NumberFont coin_num;

	private NumberFont popup_chakuseki_num;

	private UISpriteAnimation btn_game_fast;

	private UISpriteAnimation panelBullboad;

	private NumberFont dai_no;

	private UISprite black_screen;

	private UISpriteFade fade;

	private GGLSound snd;

	private float eskTimer;

	public float eskTime = 0.35f;

	private GameObject[] esk = new GameObject[100];

	private int eskCnt;

	public static bool hallAjist = false;

	private string fps_info = string.Empty;

	private int count;

	private float t;

	private UIDialog_08 m_Dialog_08;

	private UIDialog_09 m_Dialog_09;

	private UIDialog_21 m_Dialog_21;

	public float whiteOutTime = 5f;

	public float whiteInTime = 5f;

	private Vector2 inputPos;

	private Vector2 outputPos;

	private float[] moveAngle = new float[11]
	{
		210f, 240f, 270f, 300f, 330f, 0f, 30f, 60f, 90f, 120f,
		150f
	};

	private int[][] WherewithalTbl = new int[3][]
	{
		new int[4] { 20, 30, 40, 10 },
		new int[4] { 70, 20, 10, 0 },
		new int[4] { 0, 20, 30, 50 }
	};

	private int[] MoneyTbl = new int[4] { 10000, 20000, 30000, 50000 };

	private void Awake()
	{
	}

	private void Start()
	{
		SGLG.m_Scene = (hallContlloer)base.gameObject.GetComponent("hallContlloer");
	}

	public override void init()
	{
		state = _STATE.INIT;
		int num = 0;
		for (num = 0; num < BtnObjName.Length; num++)
		{
			btnObj[num] = GameObject.Find(BtnObjName[num]);
		}
		mainCamera = GameObject.Find("Main Camera");
		hallUIObj = GameObject.Find("UI Root/Camera/Anchor/Panel").gameObject;
		escalatorUIObj = GameObject.Find("Anchor/Panel_tap_to_start").gameObject;
		UICamera = GameObject.Find("UI Root/Camera").GetComponent<Camera>();
		start_Camera = GameObject.Find("start_Camera").gameObject;
		black_screen = GameObject.Find("black_screen").GetComponent<UISprite>();
		popup_chakuseki = GameObject.Find("popup_chakuseki").gameObject;
		popup_seisan_no = GameObject.Find("popup_seisan_no").gameObject;
		btn_game_fast_yajirusi = GameObject.Find("btn_game_fast_yajirusi").gameObject;
		btn_game_fast_yajirusi.GetComponent<BoxCollider>().enabled = false;
		fade = base.gameObject.AddComponent<UISpriteFade>();
		fade.setSpriteFadeIn(black_screen, Color.black);
		fade.setTime(15f);
		GameObject original = (GameObject)Resources.Load("Prefab/kyotai");
		machineRoot = new GameObject();
		machineRoot.name = "machineRoot";
		machineRoot.transform.localPosition = new Vector3(0f, 0f, 0f);
		personRoot = new GameObject();
		personRoot.name = "personRoot";
		personRoot.transform.localPosition = new Vector3(0f, 0f, 0f);
		for (num = 0; num < 10; num++)
		{
			machineObj[num] = (GameObject)UnityEngine.Object.Instantiate(original);
			machineObj[num].name = "kyotai" + num;
			machineObj[num].transform.parent = machineRoot.transform;
			machineObj[num].transform.localPosition = new Vector3(machinePos[num].x, machinePos[num].y, machinePos[num].z);
			machineObj[num].transform.localEulerAngles = new Vector3(machineAngles[num].x, machineAngles[num].y, machineAngles[num].z);
			machine[num] = machineObj[num].AddComponent<Machine>();
			machine[num].init(machineObj[num]);
		}
		game_count = GameObject.Find("panel_data/count").GetComponent<NumberFont>();
		game_num = GameObject.Find("game_num").GetComponent<NumberFont>();
		dai_no = GameObject.Find("dai_no").GetComponent<NumberFont>();
		art_count = GameObject.Find("art_count").GetComponent<NumberFont>();
		bb_count = GameObject.Find("bb_count").GetComponent<NumberFont>();
		rb_count = GameObject.Find("rb_count").GetComponent<NumberFont>();
		art_count_denominator = GameObject.Find("art_count_denominator").GetComponent<NumberFont>();
		art_count_numerator = GameObject.Find("art_count_numerator").GetComponent<NumberFont>();
		bb_count_denominator = GameObject.Find("bb_count_denominator").GetComponent<NumberFont>();
		bb_count_numerator = GameObject.Find("bb_count_numerator").GetComponent<NumberFont>();
		rb_count_denominator = GameObject.Find("rb_count_denominator").GetComponent<NumberFont>();
		rb_count_numerator = GameObject.Find("rb_count_numerator").GetComponent<NumberFont>();
		coin_num = GameObject.Find("coin_num").GetComponent<NumberFont>();
		popup_chakuseki_num = GameObject.Find("popup_chakuseki/num").GetComponent<NumberFont>();
		kaidan_oya = GameObject.Find("tap_start/kaidan_oya").gameObject;
		touchDataPalen[0] = GameObject.Find("panel_data").gameObject;
		touchDataPalen[1] = GameObject.Find("panel_data/patarn1").gameObject;
		touchDataPalen[2] = GameObject.Find("panel_data/patarn1/sub_patarn1").gameObject;
		touchDataPalen[3] = GameObject.Find("panel_data/patarn1/sub_patarn2").gameObject;
		touchDataPalen[4] = GameObject.Find("panel_data/patarn2").gameObject;
		panelHeader = GameObject.Find("Panel/head_oya/header").gameObject;
		Panel_com_bg = GameObject.Find("Panel_com_bg").gameObject;
		panelBullboadObj = GameObject.Find("Panel/head_oya/fuda").gameObject;
		panelBullboad = panelBullboadObj.GetComponent<UISpriteAnimation>();
		Panel_info = GameObject.Find("Panel_info").gameObject;
		btn_game_fast = GameObject.Find("btn_game_fast").GetComponent<UISpriteAnimation>();
		sumilationOn = 1;
		updateCamera();
		for (num = 0; num < 3; num++)
		{
			infoPanelPatternAnim[num] = GameObject.Find("Panel_info/pettern" + num + "/header_info_moji" + num).gameObject;
			infoPanelPatternAnim[num].SetActive(false);
		}
		for (num = 0; num < 5; num++)
		{
			tubu_rirekiObj[num] = new GameObject[11];
			tubu_rirekiAnim[num] = new UISpriteAnimation[11];
			tubu_rirekiObj[num][10] = GameObject.Find("tubu_rireki" + (num + 1) + "/tubu_big_b").gameObject;
			tubu_rirekiAnim[num][10] = tubu_rirekiObj[num][10].GetComponent<UISpriteAnimation>();
			tubu_rirekiObj[num][10].SetActive(false);
			for (int i = 0; i < 10; i++)
			{
				tubu_rirekiObj[num][i] = GameObject.Find("tubu_rireki" + (num + 1) + "/tubu" + i).gameObject;
				tubu_rirekiAnim[num][i] = tubu_rirekiObj[num][i].GetComponent<UISpriteAnimation>();
				tubu_rirekiObj[num][i].SetActive(false);
			}
		}
		panelMode = 0;
		setPanelType(panelMode);
		if (UserData.saveData.hall.gameStart)
		{
			hallUIObj.SetActive(true);
			mainCamera.SetActive(true);
			start_Camera.SetActive(false);
			if (UserData.saveData.game.selectMachine >= 0)
			{
				int num2 = UserData.saveData.game.selectMachine;
				if (num2 >= 5)
				{
					num2++;
				}
				select = (short)num2;
			}
		}
		else
		{
			hallUIObj.SetActive(false);
			mainCamera.SetActive(false);
		}
		popup_chakuseki.SetActive(false);
		popup_seisan_no.SetActive(false);
		Panel_info.SetActive(false);
		Panel_com_bg.SetActive(false);
		snd = GetComponent<GGLSound>();
		snd.loadSoundFiles();
		snd.stopAll();
		m_Dialog_08 = null;
		m_Dialog_09 = null;
		m_Dialog_21 = null;
		SGLG.endLoading();
		SGLG.endFade();
		m_IsOK = true;
	}

	private void updateCamera()
	{
		GGLAspect.Adjust(UICamera);
		GGLAspect.Adjust(Camera.main);
		GGLAspect.Adjust(start_Camera.GetComponent<Camera>());
	}

	public override void control()
	{
	}

	public override void controlReel()
	{
	}

	private void Update()
	{
		fps();
		buttonDown = Input.GetButtonDown("Fire1");
		buttonUp = Input.GetButtonUp("Fire1");
		switch (state)
		{
		case _STATE.INIT:
			initialize();
			break;
		case _STATE.MAKE:
			make();
			break;
		case _STATE.HALL_INIT:
			hallInit();
			break;
		case _STATE.HALL_START:
			hallStart();
			break;
		case _STATE.IDLE:
			idle();
			break;
		case _STATE.MOVE:
			move();
			break;
		case _STATE.GAME_START:
			gameStart();
			break;
		case _STATE.GAME_END:
			gameEnd();
			break;
		case _STATE.GAME_END_ADJIS:
			gameEndAdjis();
			break;
		case _STATE.GAME_END_FORCE:
			gameEndForce();
			break;
		case _STATE.ADJUSTMENT:
			gameAdjustment();
			break;
		case _STATE.WAIT:
			wait();
			break;
		}
		if (infoPanelPatternAnim[panelInfoIdx].activeSelf && !infoPanelPatternAnim[panelInfoIdx].GetComponent<Animation>().isPlaying)
		{
			infoPanelPatternAnim[panelInfoIdx].SetActive(false);
			panelInfoIdx++;
			panelInfoIdx %= 3;
			infoPanelPatternAnim[panelInfoIdx].SetActive(true);
			SetAnimPlay(infoPanelPatternAnim[panelInfoIdx], "panel_info_moji" + panelInfoIdx);
		}
	}

	private void fps()
	{
		t += GGLRealTimeClock.deltaTime;
		count++;
		if (t >= 1f)
		{
			fps_info = count + "[frm]";
			t = 0f;
			count = 0;
		}
	}

	private void initialize()
	{
		snd.setData(0, 0);
		snd.play(0);
		snd.setLoop(0, true);
		snd.setVolume(0, 0.1f);
		bgmVol = 0.1f;
		if (UserData.saveData.hall.gameStart)
		{
			state = _STATE.HALL_START;
			settei = UserData.saveData.hall.settei;
			bill = UserData.saveData.hall.bill;
			dayEvent = UserData.saveData.hall.dayEvent;
			persons = UserData.saveData.hall.persons;
			npcCoin = UserData.saveData.hall.npcCoin;
			npcMoney = UserData.saveData.hall.npcMoney;
			gameDayCnt = UserData.saveData.hall.gameCntPre;
			for (int i = 0; i < 10; i++)
			{
				npcGameCnt[i] = UserData.saveData.hall.npcGameCnt[i];
			}
			return;
		}
		state = _STATE.MAKE;
		GameObject original = (GameObject)Resources.Load("Prefab/eska_dan_move");
		esk[0] = (GameObject)UnityEngine.Object.Instantiate(original);
		esk[0].transform.parent = kaidan_oya.transform;
		int num = (int)(esk[0].GetComponent<Animation>()["eska_kaidan_ani"].length / eskTime);
		UnityEngine.Object.Destroy(esk[0]);
		esk[0] = null;
		for (int j = 0; j < num; j++)
		{
			esk[eskCnt] = (GameObject)UnityEngine.Object.Instantiate(original);
			esk[eskCnt].transform.parent = kaidan_oya.transform;
			esk[eskCnt].GetComponent<Animation>()["eska_kaidan_ani"].time = eskTime * (float)j;
			eskCnt++;
		}
	}

	private void make()
	{
		state = _STATE.HALL_INIT;
		int num = 0;
		for (num = 0; num < 10; num++)
		{
			machine[num].setMachineState(0);
			machineState[num] = _MACHINE_STATE.OPEN;
			CreateDollBox(num, 0);
		}
		int num2 = 0;
		int num3 = (int)UnityEngine.Random.Range(0f, 100f);
		num = 0;
		num2 = (UserData.saveData.hall.reviewTap ? 1 : 0);
		string text = DateTime.Today.ToString("d");
		char[] anyOf = new char[1] { '1' };
		int num4 = text.IndexOfAny(anyOf, 4, 4);
		if (num4 > 0)
		{
			num2 = 2;
		}
		else if (UserData.saveData.hall.sendMedalsFist == 1)
		{
			if (UnityEngine.Random.Range(0, 2) == 0)
			{
				num2 = 3;
			}
			UserData.saveData.hall.sendMedalsFist = 2;
		}
		for (int i = hallMode[num2][num]; i < num3; i += hallMode[num2][num])
		{
			num++;
		}
		dayEvent = num;
		switch ((_HALL_EVENT)num)
		{
		case _HALL_EVENT._NORMAL:
			num = 0;
			while (num < 6)
			{
				num3 = (int)UnityEngine.Random.Range(0f, 10f);
				if (settei[num3] == -1)
				{
					settei[num3] = num;
					num++;
				}
			}
			for (num = 0; num < 10; num++)
			{
				if (settei[num] == -1)
				{
					settei[num] = (int)UnityEngine.Random.Range(0f, 6f);
				}
			}
			break;
		case _HALL_EVENT._ODD_VS_EVEN:
			num = 0;
			while (num < 10)
			{
				num3 = (int)UnityEngine.Random.Range(0f, 6f);
				int num5 = 0;
				for (int j = 0; j < 10; j++)
				{
					if (settei[j] == num3)
					{
						num5++;
					}
				}
				if (num3 == 0 || num3 == 1)
				{
					if (num5 != 0)
					{
						continue;
					}
					for (int k = 0; k < 5; k++)
					{
						int num6 = ((num3 != 0) ? (k + 5) : k);
						if (settei[num6] == -1)
						{
							settei[num6] = num3;
							num++;
							break;
						}
					}
				}
				else
				{
					if (num5 >= 2)
					{
						continue;
					}
					for (int l = 0; l < 5; l++)
					{
						int num7 = l;
						if (num3 == 3 || num3 == 5)
						{
							num7 = l + 5;
						}
						if (settei[num7] == -1)
						{
							settei[num7] = num3;
							num++;
							break;
						}
					}
				}
			}
			break;
		case _HALL_EVENT._HEVEN_OR_HELL:
			num = 0;
			while (num < 5)
			{
				num3 = (int)UnityEngine.Random.Range(0f, 10f);
				if (settei[num3] == -1)
				{
					settei[num3] = 0;
					num++;
				}
			}
			for (num = 0; num < 10; num++)
			{
				if (settei[num] == -1)
				{
					settei[num] = 5;
				}
			}
			break;
		case _HALL_EVENT._HIGH:
			num = 0;
			while (num < 4)
			{
				num3 = (int)UnityEngine.Random.Range(0f, 10f);
				if (settei[num3] == -1)
				{
					settei[num3] = 3;
					num++;
				}
			}
			num = 0;
			while (num < 4)
			{
				num3 = (int)UnityEngine.Random.Range(0f, 10f);
				if (settei[num3] == -1)
				{
					settei[num3] = 4;
					num++;
				}
			}
			num = 0;
			while (num < 2)
			{
				num3 = (int)UnityEngine.Random.Range(0f, 10f);
				if (settei[num3] == -1)
				{
					settei[num3] = 5;
					num++;
				}
			}
			break;
		case _HALL_EVENT._HEVEN_OR_HELL_AND_NYANKO:
		case _HALL_EVENT._HIGH_AND_NYANKO:
		case _HALL_EVENT._HIGHEST:
			for (num = 0; num < 10; num++)
			{
				settei[num] = 5;
			}
			break;
		}
		int num8 = (int)UnityEngine.Random.Range(0f, 4f);
		if (dayEvent == 0)
		{
			num8 = 0;
		}
		for (num = 0; num < 10; num++)
		{
			if (num8 != 1)
			{
				int num9 = (int)UnityEngine.Random.Range(0f, 4f);
				if (num9 == 1)
				{
					num3 = (int)UnityEngine.Random.Range(0f, 100f);
					int num10 = 0;
					for (int m = billRots[settei[num]][num10]; m < num3; m += billRots[settei[num]][num10])
					{
						num10++;
					}
					bill[num] = num10;
				}
				continue;
			}
			int num11 = -1;
			switch ((_HALL_EVENT)dayEvent)
			{
			case _HALL_EVENT._ODD_VS_EVEN:
				num11 = 2;
				break;
			case _HALL_EVENT._HEVEN_OR_HELL:
			case _HALL_EVENT._HEVEN_OR_HELL_AND_NYANKO:
				num11 = 6;
				break;
			case _HALL_EVENT._HIGH:
			case _HALL_EVENT._HIGH_AND_NYANKO:
				num11 = 4;
				break;
			case _HALL_EVENT._HIGHEST:
				num11 = 0;
				break;
			}
			bill[num] = num11;
		}
		UserData.saveData.hall.settei = settei;
		UserData.saveData.hall.bill = bill;
		UserData.saveData.hall.dayEvent = dayEvent;
		UserData.saveData.game.selectMachine = -1;
		UserData.save();
	}

	private void hallInit()
	{
		eskTimer += GGLRealTimeClock.deltaTime;
		if (eskTimer > eskTime)
		{
			GameObject original = (GameObject)Resources.Load("Prefab/eska_dan_move");
			esk[eskCnt] = (GameObject)UnityEngine.Object.Instantiate(original);
			esk[eskCnt].transform.parent = kaidan_oya.transform;
			eskCnt++;
			if (eskCnt >= esk.Length)
			{
				eskCnt = 0;
			}
			eskTimer = 0f;
		}
		for (int i = 0; i < esk.Length; i++)
		{
			if (esk[i] != null && !esk[i].GetComponent<Animation>().isPlaying)
			{
				UnityEngine.Object.Destroy(esk[i]);
				esk[i] = null;
			}
		}
		if (fade.isSprEnd())
		{
			if (!start_Camera.GetComponent<Animation>().isPlaying && buttonUp)
			{
				fade.setPanelFadeIn(GameObject.Find("Panel_tap_to_start").GetComponent<UIPanel>());
				fade.setTime(15f);
				start_Camera.GetComponent<Animation>().Play("eska_camera_ani");
			}
			AnimationState animationState = start_Camera.GetComponent<Animation>()["eska_camera_ani"];
			if (animationState.length - 2f <= animationState.time)
			{
				fade.setSpriteFadeOut(black_screen, Color.white);
				fade.setTime(whiteOutTime);
				state = _STATE.HALL_START;
			}
		}
	}

	private void hallStart()
	{
		bool flag = UserData.saveData.hall.gameStart;
		bool flag2 = false;
		if (flag)
		{
			flag2 = true;
			btn_game_fast.SetIndex(sumilationOn);
			btn_game_fast_yajirusi.SetActive(sumilationOn == 0);
		}
		else
		{
			if (fade.isSprEnd())
			{
				hallUIObj.SetActive(true);
				mainCamera.SetActive(true);
				btn_game_fast.SetIndex(sumilationOn);
				btn_game_fast_yajirusi.SetActive(sumilationOn == 0);
			}
			if (start_Camera.GetComponent<Animation>()["eska_camera_ani"].length - 1f <= start_Camera.GetComponent<Animation>()["eska_camera_ani"].time)
			{
				flag2 = true;
				fade.setSpriteFadeIn(black_screen, Color.white);
				fade.setTime(whiteInTime);
			}
		}
		if (flag2)
		{
			escalatorUIObj.SetActive(false);
			start_Camera.SetActive(false);
			GameObject.Find("tap_start").SetActive(false);
			updatePanel();
			for (int i = 0; i < esk.Length; i++)
			{
				if (esk[i] != null)
				{
					UnityEngine.Object.Destroy(esk[i]);
					esk[i] = null;
				}
			}
			state = _STATE.IDLE;
			gameUpdateTime = 4.1f;
			for (int j = 0; j < bill.Length; j++)
			{
				if (bill[j] != -1)
				{
					createBillboad(j, bill[j]);
				}
			}
			for (int k = 0; k < 10; k++)
			{
				machine[k].setMachineData(UserData.saveData.game.getMachineData(k));
				machine[k].setSettei(settei[k], flag);
				if (persons[k] != -1)
				{
					personCnt++;
					createPerson(k, persons[k]);
					machineState[k] = _MACHINE_STATE.NORMAL;
					machine[k].setMachineState((int)machineState[k]);
				}
			}
			if (flag)
			{
				Vector3 localEulerAngles = new Vector3(mainCamera.transform.localEulerAngles.x, moveAngle[select], mainCamera.transform.localEulerAngles.z);
				mainCamera.transform.localEulerAngles = localEulerAngles;
				int num = UserData.saveData.hall.gameDayCnt - UserData.saveData.hall.gameCntPre;
				for (int l = 0; l < num; l++)
				{
					npcUpdate();
					gameDayCnt++;
					if (gameDayCnt > 10000)
					{
						gameDayCnt = 10000;
					}
				}
				for (int m = 0; m < 10; m++)
				{
					if (UserData.saveData.game.selectMachine == m)
					{
						int num2 = SlotUserData.saveData.getDiffMedalNum() / 1000;
						if (num2 > 10)
						{
							num2 = 10;
						}
						CreateDollBox(m, num2);
					}
					else
					{
						int num3 = npcCoin[m] / 1000;
						if (num3 > 10)
						{
							num3 = 10;
						}
						CreateDollBox(m, num3);
					}
				}
			}
			switch ((_HALL_EVENT)dayEvent)
			{
			case _HALL_EVENT._HEVEN_OR_HELL_AND_NYANKO:
			case _HALL_EVENT._HIGH_AND_NYANKO:
			case _HALL_EVENT._HIGHEST:
			{
				GameObject original = (GameObject)Resources.Load("Prefab/neko");
				neko = (GameObject)UnityEngine.Object.Instantiate(original);
				break;
			}
			}
			coin_num.SetValue(UserData.saveData.game.motiMedals);
			if (UserData.saveData.game.motiMedals < 0)
			{
				coin_num.SetColor(Color.red);
			}
			int num4 = 10000 - gameDayCnt;
			if (num4 < 0)
			{
				num4 = 0;
			}
			game_num.SetValue(num4);
			UserData.saveData.hall.gameStart = true;
			UserData.save();
			InvokeRepeating("hallBgmFadeIn", 0f, 0.016f);
		}
		switch (firstState)
		{
		case _STATE.GAME_END_ADJIS:
		{
			btnObj[7].SetActive(false);
			state = _STATE.GAME_END_ADJIS;
			GameObject gameObject3 = SGLG.createDialog(8);
			m_Dialog_08 = gameObject3.GetComponent<UIDialog_08>();
			break;
		}
		case _STATE.GAME_END_FORCE:
			btnObj[7].SetActive(false);
			state = _STATE.GAME_END_FORCE;
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
			break;
		}
	}

	private void hallBgmFadeIn()
	{
		bgmVol += 0.01f;
		if (bgmVol > 1f)
		{
			bgmVol = 1f;
			CancelInvoke("hallBgmFadeIn");
		}
		snd.setVolume(0, bgmVol);
	}

	private void hallBgmFadeOut()
	{
		bgmVol -= 0.01f;
		if (bgmVol < 0f)
		{
			CancelInvoke("hallBgmFadeOut");
		}
		snd.setVolume(0, bgmVol);
	}

	private void idle()
	{
		simulation();
		switch (getUserAction())
		{
		case _BTN.ALLOW_RIGHT:
			state = _STATE.MOVE;
			select++;
			select %= 11;
			CancelInvoke("swipe");
			InvokeRepeating("swipe", 0f, 0.016f);
			Invoke("updatePanel", 0.136f);
			snd.setData(1, 5);
			snd.play(1);
			snd.setVolume(1, 0.5f);
			break;
		case _BTN.ALLOW_LEFT:
			state = _STATE.MOVE;
			select--;
			if (select < 0)
			{
				select = 10;
			}
			CancelInvoke("swipe");
			InvokeRepeating("swipe", 0f, 0.016f);
			Invoke("updatePanel", 0.136f);
			snd.setData(1, 5);
			snd.play(1);
			snd.setVolume(1, 0.5f);
			break;
		case _BTN.DATA_PANEL:
			if (select != 5)
			{
				panelMode++;
				panelMode %= 3;
				setPanelType(panelMode);
				updatePanel();
			}
			break;
		case _BTN.FAST_GAME:
			sumilationOn++;
			sumilationOn %= 2;
			btn_game_fast.SetIndex(sumilationOn);
			btn_game_fast_yajirusi.SetActive(sumilationOn == 0);
			break;
		case _BTN.ADJISTMENT:
			if (UserData.saveData.game.motiMedals <= 0)
			{
				btnObj[7].SetActive(false);
				popup_seisan_no.SetActive(true);
				SetAnimPlay(popup_seisan_no, "pop_up_ani");
				fade.setSpriteFadeOut(black_screen, Color.black, 0.75f);
				fade.setTime(10f);
				state = _STATE.GAME_END;
			}
			else
			{
				btnObj[7].SetActive(false);
				state = _STATE.GAME_END_ADJIS;
				GameObject gameObject2 = SGLG.createDialog(8);
				m_Dialog_08 = gameObject2.GetComponent<UIDialog_08>();
			}
			break;
		case _BTN.SELECT_MACHINE:
		{
			if (select == 5)
			{
				if (UserData.saveData.game.motiMedals <= 0)
				{
					btnObj[7].SetActive(false);
					popup_seisan_no.SetActive(true);
					SetAnimPlay(popup_seisan_no, "pop_up_ani");
					fade.setSpriteFadeOut(black_screen, Color.black, 0.75f);
					fade.setTime(10f);
					state = _STATE.GAME_END;
				}
				else
				{
					btnObj[7].SetActive(false);
					state = _STATE.GAME_END_ADJIS;
					GameObject gameObject = SGLG.createDialog(8);
					m_Dialog_08 = gameObject.GetComponent<UIDialog_08>();
				}
				break;
			}
			int num = select;
			if (num > 5)
			{
				num--;
			}
			if (persons[num] == -1)
			{
				state = _STATE.GAME_START;
				sumilationOn = 1;
				btn_game_fast.SetIndex(sumilationOn);
				btn_game_fast_yajirusi.SetActive(sumilationOn == 0);
				popup_chakuseki.SetActive(true);
				SetAnimPlay(popup_chakuseki, "pop_up_ani");
				popup_chakuseki_num.SetValue(num + 1);
				btnObj[7].SetActive(false);
				fade.setSpriteFadeOut(black_screen, Color.black, 0.75f);
				fade.setTime(10f);
			}
			break;
		}
		case _BTN.NON_GAME_ADJIS_OK:
		case _BTN.NON_GAME_ADJIS_NO:
			break;
		}
	}

	private void move()
	{
		state = _STATE.IDLE;
	}

	private void gameStart()
	{
		switch (getUserAction())
		{
		case _BTN.DLOG_BTN_ON:
		{
			int num = select;
			if (num > 5)
			{
				num--;
			}
			UserData.saveData.hall.gameCntPre = UserData.saveData.hall.gameDayCnt;
			UserData.saveData.game.selectMachine = num;
			UserData.save();
			fade.setSpriteFadeOut(black_screen, Color.black);
			fade.setTime(10f);
			state = _STATE.WAIT;
			SGLG.startLoading();
			InvokeRepeating("InvokeGameStart", 0f, 0.016f);
			SetAnimPlayBack(popup_chakuseki, "pop_up_ani");
			snd.setData(1, 6);
			snd.play(1);
			snd.setVolume(1, 0.5f);
			InvokeRepeating("hallBgmFadeOut", 0f, 0.016f);
			UserData.saveData.hall.gameStart = true;
			UserData.save();
			break;
		}
		case _BTN.DLOG_BTN_NONE:
			UserData.saveData.game.selectMachine = -1;
			SetAnimPlayBack(popup_chakuseki, "pop_up_ani");
			InvokeRepeating("InvokePlayCancel", 0f, 0.016f);
			fade.setSpriteFadeIn(black_screen, new Color(0f, 0f, 0f, 0.5f));
			fade.setTime(10f);
			break;
		}
	}

	private void gameEnd()
	{
		gameUpdateTime = 4.1f;
		gameTime += GGLRealTimeClock.deltaTime;
		if (gameTime > gameUpdateTime)
		{
			UserData.saveData.hall.gameCntPre++;
			gameTime = 0f;
		}
		switch (getUserAction())
		{
		case _BTN.DLOG_BTN_ON:
			SGLG.DataSendComplete();
			state = _STATE.WAIT;
			fade.setSpriteFadeOut(black_screen, Color.black);
			fade.setTime(10f);
			SGLG.startLoading();
			InvokeRepeating("InvokeHallEnd", 0f, 0.016f);
			SetAnimPlayBack(popup_seisan_no, "pop_up_ani");
			break;
		case _BTN.DLOG_BTN_NONE:
		{
			gameTime = 0f;
			for (int i = 0; i < UserData.saveData.hall.gameCntPre; i++)
			{
				npcUpdate();
			}
			SetAnimPlayBack(popup_seisan_no, "pop_up_ani");
			UserData.save();
			updatePanel();
			UserData.saveData.hall.gameCntPre = 0;
			InvokeRepeating("InvokeAjastCancel", 0f, 0.016f);
			fade.setSpriteFadeIn(black_screen, new Color(0f, 0f, 0f, 0.5f));
			fade.setTime(10f);
			break;
		}
		}
	}

	private void gameEndAdjis()
	{
		if (m_Dialog_08.isEnd)
		{
			int decideID = m_Dialog_08.m_DecideID;
			UnityEngine.Object.Destroy(m_Dialog_08.gameObject);
			m_Dialog_08 = null;
			switch (decideID)
			{
			case 0:
				AdjustmentScene.seisanMode = AdjustmentScene.SEISAN.SEND;
				AdjustmentScene.seisanFrom = AdjustmentScene.FROM.HALL_NORMAL;
				btnObj[7].SetActive(true);
				state = _STATE.ADJUSTMENT;
				SGLG.startLoading();
				break;
			case 1:
				SGLG.DataSaveComplete();
				AdjustmentScene.seisanMode = AdjustmentScene.SEISAN.SAVE;
				AdjustmentScene.seisanFrom = AdjustmentScene.FROM.HALL_NORMAL;
				btnObj[7].SetActive(true);
				state = _STATE.ADJUSTMENT;
				SGLG.startLoading();
				break;
			case 2:
				btnObj[7].SetActive(true);
				state = _STATE.IDLE;
				break;
			}
		}
	}

	private void gameEndForce()
	{
		if (UserData.saveData.game.motiMedals <= 0)
		{
			if (m_Dialog_21.isEnd)
			{
				SGLG.DataSendComplete();
				state = _STATE.WAIT;
				fade.setSpriteFadeOut(black_screen, Color.black);
				fade.setTime(10f);
				SGLG.startLoading();
				InvokeRepeating("InvokeHallEnd", 0f, 0.016f);
				SetAnimPlayBack(popup_seisan_no, "pop_up_ani");
			}
		}
		else if (m_Dialog_09.isEnd)
		{
			int decideID = m_Dialog_09.m_DecideID;
			UnityEngine.Object.Destroy(m_Dialog_09.gameObject);
			m_Dialog_09 = null;
			switch (decideID)
			{
			case 0:
				AdjustmentScene.seisanMode = AdjustmentScene.SEISAN.SEND;
				AdjustmentScene.seisanFrom = AdjustmentScene.FROM.HALL_FORCE;
				btnObj[7].SetActive(true);
				state = _STATE.ADJUSTMENT;
				SGLG.startLoading();
				break;
			case 1:
				SGLG.DataSaveComplete();
				AdjustmentScene.seisanMode = AdjustmentScene.SEISAN.SAVE;
				AdjustmentScene.seisanFrom = AdjustmentScene.FROM.HALL_FORCE;
				btnObj[7].SetActive(true);
				state = _STATE.ADJUSTMENT;
				SGLG.startLoading();
				break;
			}
		}
	}

	private void gameAdjustment()
	{
		if (SGLG.loading.loadStart)
		{
			SGLG.endLoading();
			UserData.save();
			SGLG.m_Mode = SGLG.MODE.ADJUSTMENT;
		}
	}

	private void InvokeAjastCancel()
	{
		if (!popup_seisan_no.GetComponent<Animation>().isPlaying)
		{
			state = _STATE.IDLE;
			popup_seisan_no.SetActive(false);
			btnObj[7].SetActive(true);
			CancelInvoke("InvokeAjastCancel");
		}
	}

	private void InvokePlayCancel()
	{
		if (!popup_chakuseki.GetComponent<Animation>().isPlaying)
		{
			state = _STATE.IDLE;
			popup_chakuseki.SetActive(false);
			btnObj[7].SetActive(true);
			CancelInvoke("InvokePlayCancel");
		}
	}

	private void InvokeHallEnd()
	{
		if (SGLG.loading.loadStart)
		{
			SGLG.endLoading();
			SGLG.m_Mode = SGLG.MODE.TITLE;
			CancelInvoke("InvokeHallEnd");
		}
	}

	private void InvokeGameStart()
	{
		if (SGLG.loading.loadStart)
		{
			SGLG.m_Mode = SGLG.MODE.MAIN;
			CancelInvoke("InvokeGameStart");
		}
	}

	private void wait()
	{
		if (!popup_seisan_no.GetComponent<Animation>().isPlaying)
		{
			popup_seisan_no.SetActive(false);
		}
		if (!popup_chakuseki.GetComponent<Animation>().isPlaying)
		{
			popup_chakuseki.SetActive(false);
		}
	}

	private _BTN wakeFlick()
	{
		if (buttonDown)
		{
			inputPos = Input.mousePosition;
		}
		else if (buttonUp)
		{
			bool flag = false;
			outputPos = Input.mousePosition;
			float num = inputPos.x - outputPos.x;
			float num2 = inputPos.y - outputPos.y;
			float num3 = ((!(num < 0f)) ? num : (num * -1f));
			float num4 = ((!(num2 < 0f)) ? num2 : (num2 * -1f));
			if (num3 <= num4)
			{
				num = num2;
				flag = true;
			}
			flag = false;
			if (num > 40f || num < -40f)
			{
				if (num >= 0f && !flag)
				{
					return _BTN.ALLOW_RIGHT;
				}
				return _BTN.ALLOW_LEFT;
			}
		}
		return _BTN.BTN_MAX;
	}

	private _BTN getUserAction()
	{
		_BTN bTN = wakeFlick();
		if (bTN != _BTN.BTN_MAX)
		{
			return bTN;
		}
		for (int i = 0; i < btnObj.Length; i++)
		{
			if (btnObj[i] != null && GetUpRay(btnObj[i].name))
			{
				return (_BTN)i;
			}
		}
		if (Input.GetKey(KeyCode.Escape))
		{
			return _BTN.ADJISTMENT;
		}
		return bTN;
	}

	private void swipe()
	{
		gCutInMoveFlag = true;
		float x = mainCamera.transform.localEulerAngles.x;
		float z = mainCamera.transform.localEulerAngles.z;
		Vector3 localEulerAngles = mainCamera.transform.localEulerAngles;
		Vector3 vector = new Vector3(x, moveAngle[select], z);
		if (vector.y == moveAngle[4])
		{
			if (localEulerAngles.y <= moveAngle[6])
			{
				vector.y = -30f;
			}
		}
		else if (vector.y == moveAngle[5])
		{
			if (localEulerAngles.y >= moveAngle[3])
			{
				vector.y = 360f;
			}
		}
		else if (vector.y == moveAngle[6] && localEulerAngles.y >= moveAngle[4])
		{
			vector.y = 390f;
		}
		mainCamera.transform.localEulerAngles = Vector3.Lerp(localEulerAngles, vector, 0.056f);
		float num = localEulerAngles.y - vector.y;
		num = ((!(num < 0f)) ? num : (num * -1f));
		if (num < 0.05f)
		{
			mainCamera.transform.localEulerAngles = vector;
			CancelInvoke("swipe");
			gCutInMoveFlag = false;
		}
	}

	private void createPerson(int sel, int pattern)
	{
		GameObject original = (GameObject)Resources.Load("Prefab/hito" + (pattern + 1));
		DeletePerson(sel);
		personObj[sel] = (GameObject)UnityEngine.Object.Instantiate(original);
		Vector3 vector = Vector3.zero;
		switch (pattern)
		{
		case 0:
			vector = personManPos[sel];
			break;
		case 1:
			vector = personWomanPos[sel];
			break;
		case 2:
			vector = personOssanPos[sel];
			break;
		}
		personObj[sel].transform.localPosition = new Vector3(vector.x, vector.y, vector.z);
		personObj[sel].transform.localEulerAngles = new Vector3(machineAngles[sel].x, machineAngles[sel].y, machineAngles[sel].z);
		personObj[sel].transform.parent = personRoot.transform;
	}

	private void DeletePerson(int sel)
	{
		if (personObj[sel] != null)
		{
			UnityEngine.Object.Destroy(personObj[sel]);
			personObj[sel] = null;
		}
	}

	private void CreateDollBox(int sel, int num)
	{
		string empty = string.Empty;
		if (npcdollIdx[sel] == num)
		{
			return;
		}
		npcdollIdx[sel] = num;
		if (dollObj[sel] == null)
		{
			dollObj[sel] = new GameObject[10];
		}
		for (int i = 0; i < dollObj[sel].Length; i++)
		{
			if (dollObj[sel][i] != null)
			{
				UnityEngine.Object.Destroy(dollObj[sel][i]);
				dollObj[sel][i] = null;
			}
		}
		switch (num)
		{
		case 0:
			return;
		case 10:
			empty = "Prefab/doru_box" + (num - 1);
			arrangesDollBox(sel, num - 1, empty);
			return;
		}
		for (int j = 0; j < num; j++)
		{
			empty = "Prefab/doru_box" + j;
			arrangesDollBox(sel, j, empty);
		}
		if (num <= 3)
		{
			return;
		}
		int num2 = num - 3;
		for (int k = 0; k < num2; k++)
		{
			Transform[] componentsInChildren = dollObj[sel][k].GetComponentsInChildren<Transform>();
			Transform[] array = componentsInChildren;
			foreach (Transform transform in array)
			{
				if (transform.gameObject.name == "dorubako_fuda" + k)
				{
					transform.gameObject.SetActive(false);
				}
			}
		}
	}

	private void arrangesDollBox(int sel, int idx, string prefabName)
	{
		GameObject gameObject = (GameObject)Resources.Load(prefabName);
		dollObj[sel][idx] = (GameObject)UnityEngine.Object.Instantiate(gameObject);
		Vector3 localPosition = gameObject.transform.localPosition;
		Vector3 localEulerAngles = gameObject.transform.localEulerAngles;
		Vector3 localScale = gameObject.transform.localScale;
		dollObj[sel][idx].transform.parent = GameObject.Find("dorubox" + sel + "_oya").gameObject.transform;
		dollObj[sel][idx].transform.localPosition = new Vector3(localPosition.x, localPosition.y, localPosition.z);
		dollObj[sel][idx].transform.localEulerAngles = new Vector3(localEulerAngles.x, localEulerAngles.y, localEulerAngles.z);
		dollObj[sel][idx].transform.localScale = new Vector3(localScale.x, localScale.y, localScale.z);
	}

	private void createBillboad(int sel, int pattern)
	{
		GameObject gameObject = (GameObject)Resources.Load("Prefab/fuda" + pattern);
		billObj[sel] = (GameObject)UnityEngine.Object.Instantiate(gameObject);
		Vector3 localPosition = gameObject.transform.localPosition;
		Vector3 localEulerAngles = gameObject.transform.localEulerAngles;
		Vector3 localScale = gameObject.transform.localScale;
		billObj[sel].transform.parent = GameObject.Find("fuda" + sel + "_oya").gameObject.transform;
		billObj[sel].transform.localPosition = new Vector3(localPosition.x, localPosition.y, localPosition.z);
		billObj[sel].transform.localEulerAngles = new Vector3(localEulerAngles.x, localEulerAngles.y, localEulerAngles.z);
		billObj[sel].transform.localScale = new Vector3(localScale.x, localScale.y, localScale.z);
	}

	private void simulation()
	{
		gameUpdateTime = ((sumilationOn != 1) ? 0.02f : 4.1f);
		gameTime += GGLRealTimeClock.deltaTime;
		if (gameTime > gameUpdateTime)
		{
			gameTime = 0f;
			gameDayCnt++;
			if (gameDayCnt > 10000)
			{
				gameDayCnt = 10000;
			}
			UserData.saveData.hall.gameCntPre++;
			npcUpdate();
			UserData.save();
			updatePanel();
		}
	}

	private void updatePanel()
	{
		int num = select;
		if (num > 5)
		{
			num--;
		}
		dai_no.SetValue(num + 1);
		game_num.SetValue(10000 - gameDayCnt);
		if (select == 5)
		{
			if (!infoPanelPatternAnim[panelInfoIdx].activeSelf)
			{
				infoPanelPatternAnim[panelInfoIdx].SetActive(true);
			}
			Panel_com_bg.SetActive(true);
			Panel_info.SetActive(true);
			panelBullboadObj.SetActive(false);
			touchDataPalen[0].SetActive(false);
			panelHeader.SetActive(false);
			for (int i = 0; i < tubu_rirekiObj.Length; i++)
			{
				for (int j = 0; j < tubu_rirekiObj[i].Length; j++)
				{
					tubu_rirekiObj[i][j].SetActive(false);
				}
			}
			return;
		}
		if (!panelBullboadObj.activeSelf)
		{
			panelHeader.SetActive(true);
			touchDataPalen[0].SetActive(true);
			panelBullboadObj.SetActive(true);
		}
		switch (panelMode)
		{
		case 0:
		{
			game_count.SetValue(UserData.saveData.game.getMachineData(num).gameCount);
			int value4 = UserData.saveData.game.getMachineData(num).hisData.bnsGBCnt + UserData.saveData.game.getMachineData(num).hisData.bnsSGBCnt + UserData.saveData.game.getMachineData(num).hisData.bnsPBCnt;
			bb_count.SetValue(value4);
			art_count.SetValue(UserData.saveData.game.getMachineData(num).hisData.artCnt);
			rb_count.SetValue(UserData.saveData.game.getMachineData(num).hisData.bnsRBCnt);
			break;
		}
		case 1:
			bb_count.SetValue(UserData.saveData.game.getMachineData(num).hisData.bnsBBCntYesterDay);
			art_count.SetValue(UserData.saveData.game.getMachineData(num).hisData.artCntYesterDay);
			rb_count.SetValue(UserData.saveData.game.getMachineData(num).hisData.bnsRBCntYesterDay);
			game_count.SetValue(UserData.saveData.game.getMachineData(num).totalGameCount);
			break;
		case 2:
		{
			int totalGameCount = UserData.saveData.game.getMachineData(num).totalGameCount;
			int num2 = UserData.saveData.game.getMachineData(num).hisData.bnsGBCnt + UserData.saveData.game.getMachineData(num).hisData.bnsSGBCnt + UserData.saveData.game.getMachineData(num).hisData.bnsPBCnt;
			if (UserData.saveData.game.getMachineData(num).hisData.artCnt != 0)
			{
				int value = totalGameCount / UserData.saveData.game.getMachineData(num).hisData.artCnt;
				art_count_denominator.SetValue(value);
				art_count_numerator.SetValue(1);
			}
			else
			{
				art_count_denominator.SetValue(0);
				art_count_numerator.SetValue(0);
			}
			if (UserData.saveData.game.getMachineData(num).hisData.bnsRBCnt != 0)
			{
				int value2 = totalGameCount / UserData.saveData.game.getMachineData(num).hisData.bnsRBCnt;
				rb_count_denominator.SetValue(value2);
				rb_count_numerator.SetValue(1);
			}
			else
			{
				rb_count_denominator.SetValue(0);
				rb_count_numerator.SetValue(0);
			}
			if (num2 != 0)
			{
				int value3 = totalGameCount / num2;
				bb_count_denominator.SetValue(value3);
				bb_count_numerator.SetValue(1);
			}
			else
			{
				bb_count_denominator.SetValue(0);
				bb_count_numerator.SetValue(0);
			}
			game_count.SetValue(totalGameCount);
			break;
		}
		}
		for (int k = 0; k < 5; k++)
		{
			if (UserData.saveData.game.getMachineData(num).hisData.LogTousenYaku[k] != -1)
			{
				int num3 = UserData.saveData.game.getMachineData(num).hisData.LogGameCount[k] / 100;
				int num4 = 0;
				int num5 = 0;
				switch (UserData.saveData.game.getMachineData(num).hisData.LogTousenYaku[k])
				{
				case 0:
				case 2:
				case 3:
					num4 = k + 5;
					num5 = 1;
					break;
				case 1:
					num4 = k + 10;
					num5 = 2;
					break;
				case 4:
					num5 = 3;
					num4 = k;
					break;
				}
				for (int l = 0; l < tubu_rirekiObj[k].Length - 1; l++)
				{
					if (num3 + 1 > l)
					{
						tubu_rirekiObj[k][l].SetActive(true);
						tubu_rirekiAnim[k][l].SetIndex(0);
					}
					else
					{
						tubu_rirekiObj[k][l].SetActive(false);
					}
				}
				if (!tubu_rirekiObj[k][10].activeSelf)
				{
					tubu_rirekiObj[k][10].SetActive(true);
				}
				if (tubu_rirekiAnim[k][10].index != num4)
				{
					tubu_rirekiAnim[k][10].SetIndex(num4);
				}
				continue;
			}
			for (int m = 0; m < tubu_rirekiObj[k].Length; m++)
			{
				if (tubu_rirekiObj[k][m].activeSelf)
				{
					tubu_rirekiObj[k][m].SetActive(false);
				}
			}
		}
		int num6 = bill[num];
		if (num6 == -1)
		{
			num6 = 7;
		}
		panelBullboad.SetIndex(num6);
	}

	private void npcUpdate()
	{
		for (int i = 0; i < machine.Length; i++)
		{
			if (persons[i] == -1)
			{
				continue;
			}
			machine[i].updateRot();
			machineState[i] = (_MACHINE_STATE)machine[i].getStatus();
			npcGameCnt[i]++;
			UserData.saveData.hall.npcGameCnt[i] = npcGameCnt[i];
			switch (machineState[i])
			{
			case _MACHINE_STATE.NORMAL:
			case _MACHINE_STATE.ART:
				UserData.saveData.game.getMachineData(i).totalGameCount++;
				break;
			}
			if (machineState[i] != _MACHINE_STATE.DEMO && machineState[i] != _MACHINE_STATE.OPEN)
			{
				npcCoin[i] += machine[i].getPay();
				int num = npcCoin[i] / 1000;
				if (num > 10)
				{
					num = 10;
				}
				CreateDollBox(i, num);
			}
		}
		if (gameDayCnt >= 10000)
		{
			sumilationOn = 1;
			btnObj[7].SetActive(false);
			state = _STATE.GAME_END_FORCE;
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
		else
		{
			makeSits();
		}
		UserData.saveData.hall.persons = persons;
		UserData.saveData.hall.npcCoin = npcCoin;
		UserData.saveData.hall.npcMoney = npcMoney;
		UserData.saveData.hall.gameDayCnt = gameDayCnt;
	}

	private void makeSits()
	{
		int num = gameDayCnt / 600;
		if (gameDayCnt % isSitRotCnt[num] == 0)
		{
			for (int i = 0; i < 10 - personCnt; i++)
			{
				if (personCnt >= ((dayEvent != 0) ? 6 : 5))
				{
					break;
				}
				int num2 = 0;
				if (personCnt > 4)
				{
					num2 = 2;
				}
				else if (personCnt > 2)
				{
					num2 = 1;
				}
				int num3 = (int)UnityEngine.Random.Range(0f, sitRot[num2][num]);
				short num4 = 0;
				if (num3 != 5)
				{
					continue;
				}
				num3 = (int)UnityEngine.Random.Range(0f, 100f);
				for (int j = personType[num4][num]; j < num3; j += personType[num4][num])
				{
					num4++;
				}
				bool flag = false;
				int[] array = new int[bill.Length];
				for (int k = 0; k < bill.Length; k++)
				{
					array[k] = -1;
				}
				int num5 = 0;
				while (num5 != array.Length)
				{
					int num6 = UnityEngine.Random.Range(0, array.Length);
					bool flag2 = false;
					for (int l = 0; l < array.Length; l++)
					{
						if (array[l] == num6)
						{
							flag2 = true;
						}
					}
					if (!flag2)
					{
						array[num5] = num6;
						num5++;
					}
				}
				num3 = (int)UnityEngine.Random.Range(0f, 100f);
				for (int m = 0; m < sitCheckBill[0].Length; m++)
				{
					for (int n = 0; n < bill.Length; n++)
					{
						int num7 = array[n];
						if (bill[num7] == m && persons[num7] == -1 && UserData.saveData.game.selectMachine != num7 && num3 < sitCheckBill[num4][m])
						{
							setPerson(num7, num4);
							flag = true;
							break;
						}
					}
					if (flag)
					{
						break;
					}
				}
				if (flag)
				{
					continue;
				}
				for (int num8 = 0; num8 < bill.Length; num8++)
				{
					int num9 = array[num8];
					if (bill[num9] != -1 && persons[num9] == -1 && UserData.saveData.game.selectMachine != num9)
					{
						setPerson(num9, num4);
						flag = true;
						break;
					}
				}
				if (flag)
				{
					continue;
				}
				int num10 = 0;
				for (int num11 = 0; num11 < bill.Length; num11++)
				{
					if (bill[num11] == -1 && persons[num11] == -1)
					{
						num10++;
					}
				}
				num3 = (int)UnityEngine.Random.Range(0f, num10);
				int num12 = 0;
				for (int num13 = 0; num13 < bill.Length; num13++)
				{
					if (bill[num13] == -1 && persons[num13] == -1 && UserData.saveData.game.selectMachine != num13)
					{
						if (num3 == num12)
						{
							setPerson(num13, num4);
							flag = true;
							break;
						}
						num12++;
					}
				}
			}
		}
		for (int num14 = 0; num14 < persons.Length; num14++)
		{
			if (persons[num14] == -1 || machineState[num14] != _MACHINE_STATE.NORMAL)
			{
				continue;
			}
			if (npcCoin[num14] > 5000)
			{
				if (UserData.saveData.game.getMachineData(num14).gameCount > 150)
				{
					reset(num14);
				}
			}
			else if (npcCoin[num14] > 4000)
			{
				if (UserData.saveData.game.getMachineData(num14).gameCount > 100)
				{
					int num15 = (int)UnityEngine.Random.Range(0f, 1f);
					if ((float)num15 <= 0.1f)
					{
						reset(num14);
					}
				}
			}
			else if (npcCoin[num14] > 1500)
			{
				if (UserData.saveData.game.getMachineData(num14).gameCount > 100)
				{
					int num16 = (int)UnityEngine.Random.Range(0f, 1f);
					if ((float)num16 <= 0.1f)
					{
						reset(num14);
					}
				}
			}
			else
			{
				if (npcCoin[num14] >= 3)
				{
					continue;
				}
				if (npcMoney[num14] != 0)
				{
					npcMoney[num14] -= 50;
					npcCoin[num14] += 50;
					continue;
				}
				ushort num17 = 1000;
				int num18 = (int)UnityEngine.Random.Range(0f, 1000f);
				if (npcGameCnt[num14] < 50)
				{
					num17 = 700;
				}
				else if (npcGameCnt[num14] < 100)
				{
					num17 = 600;
				}
				else if (npcGameCnt[num14] < 200)
				{
					num17 = 500;
				}
				else if (npcGameCnt[num14] < 400)
				{
					num17 = 200;
				}
				else if (npcGameCnt[num14] < 600)
				{
					num17 = 100;
				}
				else if (npcGameCnt[num14] > 601)
				{
					num17 = 700;
				}
				if (num18 - num17 < 0)
				{
					npcCoin[num14] += 50;
				}
				else
				{
					reset(num14);
				}
			}
		}
	}

	private void setPerson(int pos, int type)
	{
		short num = 0;
		int num2 = 0;
		int num3 = (int)UnityEngine.Random.Range(0f, 100f);
		int num4 = WherewithalTbl[type][num2];
		while (num4 < num3)
		{
			num2++;
			num4 += WherewithalTbl[type][num2];
			num = (short)num2;
		}
		npcMoney[pos] = MoneyTbl[num] / 20;
		npcCoin[pos] = 50;
		npcMoney[pos] -= 50;
		persons[pos] = type;
		createPerson(pos, type);
		machineState[pos] = _MACHINE_STATE.NORMAL;
		machine[pos].setMachineState((int)machineState[pos]);
		personCnt++;
	}

	private void allReset()
	{
		for (int i = 0; i < 10; i++)
		{
			reset(i);
			HistoryData hisData = UserData.saveData.game.getMachineData(i).hisData;
			int bnsBBCntYesterDay = hisData.bnsPBCnt + hisData.bnsGBCnt + hisData.bnsSGBCnt;
			UserData.saveData.game.getMachineData(i).hisData.bnsBBCntYesterDay = bnsBBCntYesterDay;
			UserData.saveData.game.getMachineData(i).hisData.bnsRBCntYesterDay = hisData.bnsRBCnt;
			UserData.saveData.game.getMachineData(i).hisData.artCntYesterDay = hisData.artCnt;
			UserData.saveData.game.getMachineData(i).clear();
		}
		UserData.saveData.hall.gameDayCnt = 0;
		UserData.saveData.game.selectMachine = -1;
		gameDayCnt = 0;
		if (neko != null)
		{
			neko = null;
		}
		SlotUserData.clear();
		SlotUserData.save();
	}

	private void reset(int i)
	{
		npcMoney[i] = -1;
		npcCoin[i] = -1;
		persons[i] = -1;
		if (personCnt > 0)
		{
			personCnt--;
		}
		DeletePerson(i);
		machineState[i] = _MACHINE_STATE.DEMO;
		machine[i].setMachineState((int)machineState[i]);
		UserData.saveData.hall.npcGameCnt[i] = 0;
		CreateDollBox(i, 0);
	}

	private void setPanelType(short mode)
	{
		touchDataPalen[0].SetActive(true);
		switch (mode)
		{
		case 0:
			touchDataPalen[1].SetActive(true);
			touchDataPalen[2].SetActive(true);
			touchDataPalen[3].SetActive(false);
			touchDataPalen[4].SetActive(false);
			break;
		case 1:
			touchDataPalen[1].SetActive(true);
			touchDataPalen[2].SetActive(false);
			touchDataPalen[3].SetActive(true);
			touchDataPalen[4].SetActive(false);
			break;
		case 2:
			touchDataPalen[1].SetActive(false);
			touchDataPalen[2].SetActive(false);
			touchDataPalen[3].SetActive(false);
			touchDataPalen[4].SetActive(true);
			break;
		}
		panelMode = mode;
	}

	private bool GetUpRay(string target)
	{
		if (buttonUp)
		{
			return GetRay(target);
		}
		return false;
	}

	private bool GetDownRay(string target)
	{
		if (buttonDown)
		{
			return GetRay(target);
		}
		return false;
	}

	private bool GetRay(string target)
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast(ray, out hitInfo, 100000f))
		{
			GameObject gameObject = hitInfo.transform.gameObject;
			if (gameObject.name == target)
			{
				return true;
			}
		}
		ray = UICamera.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray, out hitInfo, 100000f))
		{
			GameObject gameObject2 = hitInfo.transform.gameObject;
			if (gameObject2.name == target)
			{
				return true;
			}
		}
		return false;
	}

	private void SetAnimPlay(GameObject obj, string name)
	{
		if (!(obj == null) && obj.activeSelf)
		{
			AnimationState animationState = obj.GetComponent<Animation>()[name];
			animationState.speed = 1f;
			animationState.time = 0f;
			obj.GetComponent<Animation>().Play(name);
		}
	}

	private void SetAnimPlayBack(GameObject obj, string name)
	{
		if (!(obj == null) && obj.active)
		{
			AnimationState animationState = obj.GetComponent<Animation>()[name];
			animationState.speed = -2f;
			animationState.time = animationState.length;
			obj.GetComponent<Animation>().Play(name);
		}
	}
}
