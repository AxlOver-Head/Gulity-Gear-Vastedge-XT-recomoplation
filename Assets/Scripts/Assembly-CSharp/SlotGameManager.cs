using UnityEngine;

public class SlotGameManager
{
	public enum DirData
	{
		usSeriesNo = 0,
		usDirGrp1 = 1,
		usDirGrp1Next = 2,
		usDirGrp1_Old = 3,
		usDirGrpDrin1 = 4,
		usDirNo1 = 5,
		usDirNo1Next = 6,
		usDirNo1Org = 7,
		usDirNo1_Chg = 8,
		usDirNo1_Old = 9,
		usDirNo1_BAO = 10,
		usDirNo1Cont = 11,
		usDirNo1_NM = 12,
		usDirNo1_Drin = 13,
		usDirNo1_Bjt = 14,
		usDirKCI = 15,
		usDirHNV = 16,
		usDirHNVNext = 17,
		usDirDNV = 18,
		usDirDNV_BF = 19,
		usDirKFR = 20,
		usDirBKS = 21,
		usDirKWD = 22,
		usDirBGT = 23,
		usDirWINCHR = 24,
		usDirWINCHR_OUT = 25,
		usDirLeverLED = 26,
		usDirIKG = 27,
		usDirBI1 = 28,
		ucBF_DirNo1 = 29,
		ucStageChg = 30,
		usDirYFC = 31,
		usDirYFC_Chain = 32,
		usDirYFC_Bet = 33,
		usDirYTK = 34,
		usDirVFlash = 35,
		usBFDirVFlash = 36,
		usDirGrpFrz = 37,
		usDirGrpFrzMax = 40,
		usDirNo1Frz = 41,
		usDirNo1FrzMax = 44,
		usDirStg = 45,
		usDirStgNext = 46,
		usDirStgOld = 47,
		usDirStgOld2 = 48,
		usDirStgOld3 = 49,
		usDirButton = 50,
		usDirPushStageCnt = 51,
		usDirPushStageMax = 52,
		usDirPushOkTimer = 53,
		usDirSuccessFlag = 54,
		usDirBBKind = 55,
		usDirBetCnt = 56,
		usDirBetCntSt = 57,
		usDirInitStat = 58,
		usDirSinaGame = 59,
		usARTLastGame = 60,
		usARTStockGame = 61,
		usARTBtlTurnGame = 62,
		usARTUpGame = 63,
		usARTSvlWin = 64,
		usRmnGame = 65,
		usSVNotice = 66,
		ucJGyakuFlg = 67,
		ucJGPreMode = 68,
		ucDIStatus = 69,
		ucDIResv = 70,
		ucIKGSp = 71,
		ucIKGSimbDisp = 72,
		ucIKGLotState = 73,
		ucIKGLotKakutei = 74,
		ucIKGEnsStatus = 75,
		ucFrzOn = 76,
		usR2BgmStartFlg = 77,
		ucBJTStatus = 78,
		usBonusSyokakuState = 79,
		usSndOld = 80,
		usSndOldPower = 81,
		usSndInfo = 82,
		usDemoPtn = 83,
		usDemoEcoMode = 84,
		usDemoSnd = 85,
		usWakuLmp = 86,
		usDesPanel = 87,
		usNaviPanel = 88,
		usSlashPanel = 89,
		usCharPanel = 90,
		usLEDLever = 91,
		usBackLmp = 92,
		usGageLmp = 93,
		usPushDir = 94,
		usPushDirMax = 97,
		usBGOutput = 98,
		usCutinFlg = 99,
		usW7Voice = 100,
		usNaviBak = 101,
		usBstWait = 102,
		usKakuage = 103,
		usDragonGage_old = 104,
		MAX = 105
	}

	public enum KaidoData
	{
		ulDedamaLotState = 0,
		ulDedamaLotStateOld = 1,
		ulDedamaLotStateEdge = 2,
		ulBFJACCmd = 3,
		ulTM_Poweroff = 4,
		usWaitSubCmd = 5,
		ucFLMainCmdOk = 6,
		ucFLSubCmdOk = 7,
		ucFLFukkiOk = 8,
		usRandSeed = 9,
		usGameCnt = 10,
		usGameCntBet = 11,
		dummy = 12,
		usGameStat = 13,
		usGameStat2 = 14,
		usErrCode = 15,
		usSettei = 16,
		usSetteiOld = 17,
		usErrCode1 = 18,
		usErrCode2 = 19,
		usErrDoor = 20,
		usErrCodeHF = 21,
		BfusErrCode = 22,
		BfusErrCodeMax = 29,
		NowErrNum = 30,
		BfErrCmd = 31,
		usErrCom = 32,
		usLevComLost = 33,
		usStartWait = 34,
		usDemo = 35,
		usDemoRet = 36,
		usRlKeikoku = 37,
		ucPowerOn = 38,
		ucRank = 39,
		ucRankBak = 40,
		ucCntBet = 41,
		ucCntPay = 42,
		ucSetteiKey = 43,
		usTrg = 44,
		usTrgMax = 47,
		usBfTrg = 48,
		usRealTrg = 49,
		usTrgWait = 50,
		usTrg_DirNo1Chg = 51,
		usGst = 52,
		ucFLTousen1 = 53,
		ucFLTousen2 = 54,
		ucFLLotHitZu = 55,
		ucWinZu0 = 56,
		ucWinZu1 = 57,
		ucWinZu2 = 58,
		ucWinZu3 = 59,
		ucWinZu4 = 60,
		ucWinZu5 = 61,
		ucWinZu6 = 62,
		ucStopZuL = 63,
		ucStopZuLMax = 65,
		ucStopZuC = 66,
		ucStopZuCMax = 68,
		ucStopZuR = 69,
		ucStopZuRMax = 71,
		usCntMedal_In = 72,
		usCntMedal_Out = 73,
		ucFLReplayBet = 74,
		usFL_Tenjo = 75,
		usCntTenjo = 76,
		usMAXTenjo = 77,
		usCntNMGame = 78,
		ucCntMBGame = 79,
		ucCntCycle = 80,
		ucLotCycleMode = 81,
		ucGoState = 82,
		ucFL_1stStopL = 83,
		ucBonusState = 84,
		ucFLLotMode = 85,
		ucRTMode = 86,
		ucRTModeOld = 87,
		ucCntPreHOHGame = 88,
		ucCntPreHOHGameOld = 89,
		ucCntSUV_Win = 90,
		ucCntSUV_WinDisp = 91,
		ucTekiCharMode = 92,
		ucTekiCharNo = 93,
		ucSUVTekiCharNo = 94,
		ucCntBattleGame = 95,
		ucCntMLife = 96,
		ucCntELife = 97,
		ucCntMLifeOld = 98,
		ucCntELifeOld = 99,
		ucAttackPoint = 100,
		ucCntTensionGage = 101,
		ucGetTensG_PntNow = 102,
		ucAtkOffAndDef = 103,
		ucSPAttackPnt = 104,
		uc3OnHitZu = 105,
		ucCntHOHStock = 106,
		ucBufHOHStock = 107,
		ucBufHOHStockMax = 206,
		usCntBRAddOn = 207,
		usADDON_ART = 208,
		usCntART = 209,
		ucArtMode = 210,
		ucARTRound = 211,
		ucARTRound_Disp = 212,
		ucCntVarGame = 213,
		ucRBLotArtTblNUM = 214,
		ucRBLotMode = 215,
		usAddARTGameDI = 216,
		ucRlAct_DI_ENDCHK = 217,
		ucRlAct_DI_INPUT = 218,
		ucTBRlAct_DI_Cont = 219,
		ucCntDraInKeep = 220,
		ucFLDrainKeep = 221,
		ucCntPreJDGGame = 222,
		ucCntPreJDGGameOld = 223,
		ucCntJDGGame = 224,
		ucCntJDGGameOld = 225,
		ucCntPreARTGame = 226,
		ucCntPreARTGameOld = 227,
		ucART_LoopPer = 228,
		ucCntARTStock = 229,
		ucBufARTStock = 230,
		ucBufARTStockMax = 329,
		ucAddARTGame = 330,
		ucBfAddARTGame = 331,
		ucCntPrePBGame = 332,
		ucCntPreBRGame = 333,
		ucCntPreBRGameOld = 334,
		ucBR_KIND = 335,
		ucBR_KIND_Org = 336,
		ucCntBRStock = 337,
		ucBufBRStock = 338,
		ucBufBRStockMax = 437,
		ucCntBRGame = 438,
		ucMaxBRGame = 439,
		ucCNTAddBTL = 440,
		ucCNTAddBTL_Yoin = 441,
		usCNTAddBTL_TOTAL_Disp = 442,
		usCNTAddBTL_TOTAL = 443,
		ucFL_AddBTL_DUP = 444,
		ucFLTousenLot = 445,
		ucCntCharge = 446,
		usADD_DestArt = 447,
		ucFLHitDestStock = 448,
		ucCntDestStock = 449,
		ucCntContBtl = 450,
		ucFL_LoopBtlEndig = 451,
		ucYoinKind = 452,
		usCntPenaG = 453,
		usCntPenaG_Old = 454,
		ucDir_GameST = 455,
		ucParaNextStg = 456,
		ucRlAct_No = 457,
		ucRlAct_PBFRZ = 458,
		ucBfRlAct_PBFRZ = 459,
		ucBfRlAct_START = 460,
		ucRlAct_DIFRZ_ST = 461,
		ucRlAct_Step = 462,
		ucRlAct_Reserve = 463,
		ucFL_1GEKI_FRZ = 464,
		ucFL_HitCharge = 465,
		ucCntChargeAct = 466,
		ucCntChargeNow = 467,
		ucFLChargeWin = 468,
		ucStateGateBreak = 469,
		ucChargeColor = 470,
		ucChargeColorMax = 475,
		ucChargeART = 476,
		ucChargeARTMax = 481,
		usMaxCntBTHPush = 482,
		usCntChargeADDART = 483,
		usCntChargeADDARTDisp = 484,
		usCntBnsFukkiART = 485,
		usCntBnsFukkiART_Disp = 486,
		usCntARTGameLastADD = 487,
		usCntArtingZencyo = 488,
		usCntDispArtReal = 489,
		usCntDispArt = 490,
		usCntDispArtAdd = 491,
		usCntPBGet_ART = 492,
		usCntArtTotalGame = 493,
		ucCntPBARTStock = 494,
		ucCntRomanAct = 495,
		ucRomanStatus = 496,
		ucPBARTStock = 497,
		ucPBARTStockMax = 516,
		ucPBARTStockAct = 517,
		ucPBARTStockActMax = 536,
		ucBulletDel = 537,
		usRomanGetGame = 538,
		usBFRBLotMode = 539,
		usRB_Intro = 540,
		usRB_IntroMax = 549,
		usRB_FLRoundSet = 550,
		ucOBnsState = 551,
		ucCntOPB_PreWinGame = 552,
		ucFLKoukakuFake = 553,
		ucCntPreFakeOnOff = 554,
		ucCntPreFake = 555,
		ucPreActMode = 556,
		ucFLPreFake = 557,
		ucCntKeepDispHi = 558,
		ucCntChanceStGame = 559,
		ucFLChanceStGame = 560,
		ucContActNum = 561,
		ucCntContAct = 562,
		ucCntFCGiji = 563,
		ucMaxFCGiji = 564,
		ucBFMaxFCGiji = 565,
		ucCntFateBattle = 566,
		ucCntGBLastGame = 567,
		ucHitZuLot = 568,
		ucNaviHitZuLot = 569,
		usFLBonusInit = 570,
		usNmlGame = 571,
		usFlgGame = 572,
		usBnsGame = 573,
		usRestBnsMdl = 574,
		ssBnsMdl = 575,
		ssBnsMdlLev = 576,
		ssTotalMdl = 577,
		ssTotalMdlLev = 578,
		ssLeftMdl = 579,
		usBnsGameLeft = 580,
		usBLSTLeftGame = 581,
		usBLSTGame = 582,
		usBLSTTotalGame = 583,
		usTotalGame = 584,
		usDragonGame = 585,
		usDIUpGameCount = 586,
		usDIUpGameCountOld = 587,
		usDIRPArtAddGame = 588,
		ucFL_ARTINBGMCHG = 589,
		ucNUM_ARTBGM = 590,
		ucARTStageNum = 591,
		ucLBTL_4G_TekiAtk = 592,
		ucLBTL_Lot_Voice = 593,
		ucBtn_Edge = 594,
		ucFL_ChainClr = 595,
		usTM_ArtYFC_Cutin = 596,
		usWaitTimer = 597,
		usWaitTimerHOHTens = 598,
		usWaitTimerPush = 599,
		usWaitDebugCounter = 600,
		usWaitMotorCancel = 601,
		ucTotalResetGame = 602,
		ucFLTotalGame = 603,
		ucFLPenaStageSet = 604,
		usErrorNo = 605,
		usErrorNoNow = 606,
		usErrPatn = 607,
		usFL_ErrReceive = 608,
		usFL_MainCmdNG = 609,
		usFL_MainCmdNGOld = 610,
		usTM_MainCmdNG = 611,
		usErrReceive = 612,
		usErrRcvZuChk = 613,
		usFL_ReelStopWarn = 614,
		usTM_ReelStopWarn = 615,
		usFL_PopUpBtnInit = 616,
		usCnt_PopUpBtnErr = 617,
		usFL_PowerOn = 618,
		usCntBnsInterval = 619,
		usFL_BnsJiPBhit = 620,
		usBF_TM_PowerOff = 621,
		usWorstIn = 622,
		usCmdH = 623,
		usCmdHMax = 624,
		usCmdL = 625,
		usCmdLMax = 626,
		usCmdMD = 627,
		usCmdMDMax = 628,
		usCmdHndlerInit = 629,
		usIKGInit = 630,
		usHattenFlg = 631,
		usHOHTenBack = 632,
		usWinPanel = 633,
		usRepDispOn = 634,
		usPUSHbtnStatus = 635,
		usTurnLevel = 636,
		usPushCounter = 637,
		usPushCountFlg = 638,
		usPushTarget = 639,
		ucCntBnsAfter = 640,
		usFL_StageChgRev = 641,
		usTrg_Backup = 642,
		usFL_LotLev = 643,
		usDispReelStop1 = 644,
		usDispReelStop2 = 645,
		usDispReelStop3 = 646,
		usDispStep1 = 647,
		usDispStep2 = 648,
		usDispStep3 = 649,
		usDispPos1 = 650,
		usDispPos2 = 651,
		usDispPos3 = 652,
		usVersionNo = 653,
		ulRandSeed = 654,
		ulGameCount = 655,
		usFL_Syuntei = 656,
		MAX = 657
	}

	public enum ReelData
	{
		stReelStat = 0,
		usSelStop = 1,
		usAnsStop = 2,
		usNaviProc = 3,
		usNowStop = 4,
		arStopLog = 5,
		arStopLogMax = 7,
		usNaviSolColor = 8,
		usNaviNoColor = 9,
		usNaviTiming = 10,
		usNaviSize = 11,
		usNaviChar = 12,
		MAX = 13
	}

	public const long DM_BNS = 1L;

	public const long DM_ARH = 2L;

	public const long DM_BTL = 4L;

	public const long DM_BTY = 8L;

	public const long DM_PBB = 16L;

	public const long DM_NBR = 32L;

	public const long DM_BNR = 64L;

	public const long DM_SVR = 128L;

	public const long DM_JGN = 256L;

	public const long DM_JGH = 512L;

	public const long DM_HOH = 1024L;

	public const long DM_HON = 2048L;

	public const long DM_INT = 4096L;

	public const long DM_SUV = 8192L;

	public const long DM_WIN = 16384L;

	public const long DM_CMB = 32768L;

	public const long DM_ART = 65536L;

	public const long DM_ARR = 131072L;

	public const long DM_WBT = 262144L;

	public const long DM_DIN = 524288L;

	public const long DM_CBT = 1048576L;

	public const long DM_ARY = 2097152L;

	public const long DM_VST = 4194304L;

	public const long DM_VBR = 8388608L;

	public const long DM_VAR = 16777216L;

	public const long DM_3ON = 33554432L;

	public const long DM_BNZ = 67108864L;

	public const long DM_ARZ = 134217728L;

	public const long DM_JGZ = 268435456L;

	public const long DM_HIG = 536870912L;

	public const long DM_HOG = 1073741824L;

	public const long DM_PNA = 2147483648L;

	private const int CREDIT_MAX = 50;

	public const int HISTROY_ITEM_MAX = 20;

	public const int HISTROY_ELECTION_PB = 0;

	public const int HISTROY_ELECTION_RB = 1;

	public const int HISTROY_ELECTION_GB = 2;

	public const int HISTROY_ELECTION_SGB = 3;

	public const int HISTROY_ELECTION_ART = 4;

	public const int DDEMO_OFF = 0;

	public const int DDEMO_TIME_CNT = 1;

	public const int DDEMO_TIME_START = 2;

	public const int DDEMO_ON = 3;

	public const int DDEMO_WAIT_FRM = 900;

	public int[] m_dirData = new int[105];

	public int[] m_kaidoData = new int[657];

	public int[] m_reelData = new int[13];

	public long ulDedamaLotState;

	public long ulDedamaLotStateOld;

	public int m_mochiMedal;

	public int m_creditMedal;

	public int m_betMedal;

	public int m_payoutMedal;

	public int m_inMedal;

	public int m_outMedal;

	public int m_kasouToushi;

	public bool m_replay;

	public int m_koyakuState;

	public int tousenYaku;

	public int gameCountArt;

	public int artGameCnt;

	public int artGameMax;

	public int bnsAutoState;

	public int artAutoState;

	public int bnsGetMedal;

	public int artGetMedal;

	public int pbLastMedal;

	public int artDispCnt;

	public int artDispCntDI;

	public int settei;

	public int m_bonusTouroku;

	public int m_CntARTGameLastADD;

	public int m_lev_to_3off_rtmode;

	public int m_ucFLMainCmdOk;

	public int m_oldBnsKind;

	public int m_pushRendaFrame;

	public bool m_drinFukki;

	public int m_repArtLev;

	public int m_usCNTAddBTL_TOTAL_Disp;

	public MachineData data;

	public int gameCount;

	public int modeMain;

	public int modeSub;

	public int totalGameCount;

	public int artCount;

	public int bnsCount;

	public short mode;

	public short modeArt;

	public int cycleGame;

	public short cycleMode;

	public int yaku;

	public int FLTousen1;

	public int reelStep;

	public int bonusGame;

	public int artGame;

	public int artCntContBtl;

	public int artStockCnt;

	public bool artBtlWin;

	public int jgGame;

	public int hohGame;

	public int artCntVarGame;

	public short hohChar;

	public short hohTension;

	public short hohRivalCharDamage;

	public short hohSolCharDamage;

	public short gbChargeCnt;

	public short rbMap;

	public int selectMachine;

	public int selectMachineOld;

	public SlumpData m_SlumpData;

	public SlumpDataSim m_SlumpDataSim;

	public int m_demoFlag;

	public int m_demoCounter;

	public int old_totalGameCount;

	public int old_mochiMedal;

	public int m_di0gFlag;

	public int m_destroyCnt;

	public int m_oldGijiNum;

	public void init()
	{
		if (SGLG.gameMode == SGLG.GAMEMODE.HALL)
		{
			m_SlumpData = new SlumpData();
			m_SlumpData.init();
		}
		else
		{
			m_SlumpDataSim = new SlumpDataSim();
			m_SlumpDataSim.init();
		}
		MainGameScene.SlotDataLoad();
		selectMachine = MainGameScene.m_SlotSaveData.selectMachine;
		selectMachineOld = MainGameScene.m_SlotSaveData.selectMachine;
		SGLG_PlugIn.init();
		for (int i = 0; i < 105; i++)
		{
			m_dirData[i] = 0;
			SGLG_PlugIn.set_pdt_data(i, 0);
		}
		for (int i = 0; i < 657; i++)
		{
			m_kaidoData[i] = 0;
			SGLG_PlugIn.set_pkd_data(i, 0);
		}
		for (int i = 0; i < 13; i++)
		{
			m_reelData[i] = 0;
			SGLG_PlugIn.set_pri_data(i, 0);
		}
		SGLG_PlugIn.all_clr();
		int num = (int)Random.Range(0f, 100f);
		for (int i = 0; i < num; i++)
		{
			SGLG_PlugIn.all_clr();
		}
		getPluginPrm();
		m_mochiMedal = 0;
		m_creditMedal = 0;
		m_betMedal = 0;
		m_payoutMedal = 0;
		m_inMedal = 0;
		m_outMedal = 0;
		m_replay = false;
		m_koyakuState = 0;
		data = new MachineData();
		data.hisData.clear();
		getHallPrm();
		getSimulationPrm();
		old_totalGameCount = 0;
		old_mochiMedal = 0;
		m_demoFlag = 3;
		m_demoCounter = 0;
		m_pushRendaFrame = 0;
		m_usCNTAddBTL_TOTAL_Disp = 0;
	}

	public void control()
	{
		if ((ulDedamaLotState & 1) != 0L)
		{
			m_kaidoData[575] = bnsGetMedal;
			m_kaidoData[577] = artGetMedal;
			MainGameScene.slotGameMan.set_pkd_data(575, bnsGetMedal);
			MainGameScene.slotGameMan.set_pkd_data(577, artGetMedal);
		}
		else if ((ulDedamaLotState & 0x10000) != 0L)
		{
			m_kaidoData[577] = artGetMedal;
			MainGameScene.slotGameMan.set_pkd_data(577, artGetMedal);
		}
		m_kaidoData[574] = pbLastMedal;
		set_pkd_data(574, pbLastMedal);
		if (m_demoCounter != 0)
		{
			m_demoCounter--;
		}
		if (m_demoFlag == 1)
		{
			m_demoFlag = 2;
			m_demoCounter = 900;
		}
		else if (m_demoFlag == 2)
		{
			if (get_pdt_data(45) >= 0 && 2 >= get_pdt_data(45))
			{
				if (get_pkd_data(86) == 5 || get_pkd_data(86) == 6)
				{
					m_demoCounter = 900;
				}
			}
			else
			{
				m_demoCounter = 900;
			}
		}
		if (m_demoCounter == 1)
		{
			m_demoCounter = 0;
			m_demoFlag = 3;
			MainGameScene.dirMan.demoStart();
		}
		if (m_demoFlag != 2)
		{
			m_demoCounter = 0;
		}
		if (m_pushRendaFrame > 0)
		{
			m_pushRendaFrame--;
			if (m_pushRendaFrame == 0)
			{
				DirectionPanelLED.runMac2App(MainGameScene.slotGameMan.getPUSHbtnStatus(), 7);
				DirectionPanelLED.runMac2App(MainGameScene.slotGameMan.getPUSHbtnStatus(), 9);
			}
		}
	}

	private void restartPB()
	{
		int num = get_pdt_data(45);
		int num2 = get_pdt_data(49);
		if (get_pkd_data(86) == 5)
		{
			MainGameScene.dirMan.EventStageChanged(67, 1, 1);
			set_pdt_data(1, 0);
			set_pdt_data(5, 0);
			set_pdt_data(45, 11);
			set_pdt_data(46, 11);
		}
		else
		{
			if (num != 20)
			{
				return;
			}
			MainGameScene.dirMan.EventStageChanged(71, 0, 1);
			int num3 = get_pkd_data(494);
			for (int i = 0; i < num3; i++)
			{
				int num4 = get_pkd_data(517 + i) - 1;
				if (num4 < 0)
				{
					num4 = 0;
				}
				if (num4 > 2)
				{
					num4 = 2;
				}
				MainGameScene.pnlMan.onCartridge(i, num4);
			}
		}
	}

	private void restartStage()
	{
		switch (get_pdt_data(45))
		{
		case 0:
			MainGameScene.dirMan.nowHaikei = 3;
			MainGameScene.dirMan.EventStageChanged(3, 0, 1);
			MainGameScene.dir3MST_Sub.initPosition();
			break;
		case 1:
			MainGameScene.dirMan.nowHaikei = 59;
			MainGameScene.dirMan.EventStageChanged(59, 0, 1);
			break;
		case 2:
			MainGameScene.dirMan.nowHaikei = 5;
			MainGameScene.dirMan.EventStageChanged(5, 0, 1);
			break;
		case 3:
			MainGameScene.dirMan.nowHaikei = 18;
			MainGameScene.dirMan.EventStageChanged(18, 0, 1);
			break;
		case 4:
		case 5:
		case 6:
		case 30:
			MainGameScene.dirMan.nowHaikei = 23;
			if (get_pdt_data(45) == 4 && get_pdt_data(46) == 5)
			{
				MainGameScene.dirMan.EventStageChanged(23, 0, 1);
				set_pdt_data(49, 5);
			}
			else
			{
				MainGameScene.dirMan.EventStageChanged(23, 0, 1);
			}
			if (get_pdt_data(49) >= 20 && 23 >= get_pdt_data(49))
			{
				set_pdt_data(49, 4);
			}
			artAutoState = 1;
			break;
		case 9:
			MainGameScene.dirMan.nowHaikei = 32;
			MainGameScene.dirMan.EventStageChanged(32, 0, 1);
			Direction33DST.restartBGM();
			break;
		case 11:
		{
			byte b = (byte)get_pdt_data(79);
			if (b > 0)
			{
				Direction38IKG.restartBGM();
				MainGameScene.dirMan.makeDirection(DirectionManager.DIR.STAGE, 37, 0, b);
			}
			else
			{
				Direction38IKG.restartBGM();
				MainGameScene.dirMan.makeDirection(DirectionManager.DIR.STAGE, 37, 0, 1);
			}
			if ((ulDedamaLotState & 1) != 0L && m_kaidoData[438] == m_kaidoData[439])
			{
				m_bonusTouroku = 1;
			}
			break;
		}
		case 13:
		case 14:
			MainGameScene.dirMan.EventStageChanged(89, 0, 1);
			m_bonusTouroku = 2;
			if (get_pkd_data(438) > 0)
			{
				for (int i = 0; i < get_pkd_data(466); i++)
				{
					int num3 = get_pkd_data(470 + i) + i * 7;
					DirectionMainLED._start(226, 9, (short)num3);
				}
			}
			break;
		case 15:
		case 16:
		case 17:
		case 18:
			MainGameScene.dirMan.EventStageChanged(72, 0, 1);
			m_bonusTouroku = 2;
			if (m_dirData[45] == 17 || m_dirData[45] == 18)
			{
				m_usCNTAddBTL_TOTAL_Disp = m_kaidoData[442];
			}
			break;
		case 19:
			m_bonusTouroku = 2;
			break;
		case 20:
		case 21:
		case 22:
			MainGameScene.dirMan.EventStageChanged(71, 1, 1);
			m_bonusTouroku = 2;
			break;
		case 25:
		case 27:
		case 28:
		case 29:
		{
			int num = 10 - get_pkd_data(97);
			int num2 = 10 - get_pkd_data(96);
			if (get_pkd_data(103) == 1)
			{
				num -= get_pkd_data(100);
			}
			else if (get_pkd_data(103) == 2)
			{
				num2 -= get_pkd_data(100);
			}
			MainGameScene.pnlMan.onDamageLever(1, num);
			MainGameScene.pnlMan.onDamageLever(2, num2);
			break;
		}
		case 7:
		case 8:
		case 10:
		case 12:
		case 23:
		case 24:
		case 26:
			break;
		}
	}

	private void restartSlot()
	{
		bnsGetMedal = get_pkd_data(575);
		artGetMedal = get_pkd_data(577);
		pbLastMedal = get_pkd_data(574);
		artDispCnt = get_pkd_data(490) - get_pkd_data(488);
		if ((ulDedamaLotState & 0x80000) != 0L)
		{
			int num = get_pkd_data(586);
			int num2 = get_pkd_data(584);
			if (MainGameScene.slotMan.m_State != SlotBodyManager.STATE.REEL_END3)
			{
				switch (get_pkd_data(330))
				{
				case 1:
					num += 10;
					break;
				case 2:
					num += 20;
					break;
				case 3:
					num += 30;
					break;
				case 4:
					num += 50;
					break;
				case 5:
					num += 100;
					break;
				case 6:
					num += 150;
					break;
				case 7:
					num += 200;
					break;
				case 8:
					num += 300;
					break;
				}
			}
			artDispCntDI = artDispCnt - num;
			artDispCnt = artDispCntDI;
			if (get_pkd_data(220) != 10)
			{
				m_drinFukki = true;
			}
		}
		m_CntARTGameLastADD = get_pkd_data(487);
		if (get_pkd_data(84) == 2 && get_koyaku_prm(1) != 2)
		{
			m_koyakuState = 1;
		}
		if (get_pkd_data(563) > 0 && get_pkd_data(564) != 0)
		{
			MainGameScene.dirMan.makeDirection(DirectionManager.DIR.YFC_CHAIN_1, 83, 0, 100);
			MainGameScene.dirMan.dir[19].start();
		}
		short stageLmp = getStageLmp();
		DirectionMainLED._start(228, 1, stageLmp);
		MainGameScene.slotMan.m_SEGCredit.restart(m_creditMedal);
		MainGameScene.slotMan.m_SEGBet.restart();
		MainGameScene.slotMan.m_LEDMaxBet.setState(SlotBodyLED_MaxBet.STATE.OFF);
		m_ucFLMainCmdOk = get_pkd_data(6);
		MainGameScene.yakuMan.returnCubeRestart();
		m_oldGijiNum = get_pkd_data(563);
		testlotlog(-100);
	}

	private void gameStart_ContinueHall()
	{
		m_demoFlag = 0;
		switch (selectMachine)
		{
		case 0:
			SlotUserData_m1.saveData.get();
			break;
		case 1:
			SlotUserData_m2.saveData.get();
			break;
		case 2:
			SlotUserData_m3.saveData.get();
			break;
		case 3:
			SlotUserData_m4.saveData.get();
			break;
		case 4:
			SlotUserData_m5.saveData.get();
			break;
		case 5:
			SlotUserData_m6.saveData.get();
			break;
		case 6:
			SlotUserData_m7.saveData.get();
			break;
		case 7:
			SlotUserData_m8.saveData.get();
			break;
		case 8:
			SlotUserData_m9.saveData.get();
			break;
		case 9:
			SlotUserData_m10.saveData.get();
			break;
		}
		setPluginPrm();
		if (SGLG.gameMode == SGLG.GAMEMODE.HALL)
		{
			data = UserData.saveData.game.getMachineData(selectMachine);
		}
		else
		{
			data = Sim_MachineData.saveData.machine;
		}
		MainGameScene.dirMan.changeStageIntarface(MainGameScene.slotGameMan.m_dirData[45]);
		if (get_pkd_data(86) == 5 || get_pkd_data(86) == 6)
		{
			restartPB();
		}
		else
		{
			restartStage();
		}
		restartSlot();
		SlotUserData.saveData.set();
		for (int i = 0; i < 3; i++)
		{
			switch (selectMachine)
			{
			case 0:
				SlotUserData.saveData.m_reelPushOrder[i] = SlotUserData_m1.saveData.m_reelPushOrder[i];
				SlotUserData.saveData.m_reelStopNum[i] = SlotUserData_m1.saveData.m_reelStopNum[i];
				break;
			case 1:
				SlotUserData.saveData.m_reelPushOrder[i] = SlotUserData_m2.saveData.m_reelPushOrder[i];
				SlotUserData.saveData.m_reelStopNum[i] = SlotUserData_m2.saveData.m_reelStopNum[i];
				break;
			case 2:
				SlotUserData.saveData.m_reelPushOrder[i] = SlotUserData_m3.saveData.m_reelPushOrder[i];
				SlotUserData.saveData.m_reelStopNum[i] = SlotUserData_m3.saveData.m_reelStopNum[i];
				break;
			case 3:
				SlotUserData.saveData.m_reelPushOrder[i] = SlotUserData_m4.saveData.m_reelPushOrder[i];
				SlotUserData.saveData.m_reelStopNum[i] = SlotUserData_m4.saveData.m_reelStopNum[i];
				break;
			case 4:
				SlotUserData.saveData.m_reelPushOrder[i] = SlotUserData_m5.saveData.m_reelPushOrder[i];
				SlotUserData.saveData.m_reelStopNum[i] = SlotUserData_m5.saveData.m_reelStopNum[i];
				break;
			case 5:
				SlotUserData.saveData.m_reelPushOrder[i] = SlotUserData_m6.saveData.m_reelPushOrder[i];
				SlotUserData.saveData.m_reelStopNum[i] = SlotUserData_m6.saveData.m_reelStopNum[i];
				break;
			case 6:
				SlotUserData.saveData.m_reelPushOrder[i] = SlotUserData_m7.saveData.m_reelPushOrder[i];
				SlotUserData.saveData.m_reelStopNum[i] = SlotUserData_m7.saveData.m_reelStopNum[i];
				break;
			case 7:
				SlotUserData.saveData.m_reelPushOrder[i] = SlotUserData_m8.saveData.m_reelPushOrder[i];
				SlotUserData.saveData.m_reelStopNum[i] = SlotUserData_m8.saveData.m_reelStopNum[i];
				break;
			case 8:
				SlotUserData.saveData.m_reelPushOrder[i] = SlotUserData_m9.saveData.m_reelPushOrder[i];
				SlotUserData.saveData.m_reelStopNum[i] = SlotUserData_m9.saveData.m_reelStopNum[i];
				break;
			case 9:
				SlotUserData.saveData.m_reelPushOrder[i] = SlotUserData_m10.saveData.m_reelPushOrder[i];
				SlotUserData.saveData.m_reelStopNum[i] = SlotUserData_m10.saveData.m_reelStopNum[i];
				break;
			}
		}
		SlotUserData.save();
	}

	private void gameStart_Continue()
	{
		m_demoFlag = 0;
		MainGameScene.m_SlotSaveData.get();
		setPluginPrm();
		if (SGLG.gameMode == SGLG.GAMEMODE.HALL)
		{
			data = UserData.saveData.game.getMachineData(selectMachine);
		}
		else
		{
			data = Sim_MachineData.saveData.machine;
		}
		MainGameScene.dirMan.changeStageIntarface(MainGameScene.slotGameMan.m_dirData[45]);
		if (get_pkd_data(86) == 5 || get_pkd_data(86) == 6)
		{
			restartPB();
		}
		else
		{
			restartStage();
		}
		restartSlot();
	}

	private void gameStart_NewGame()
	{
		if (totalGameCount != 0)
		{
			int num = 0;
			switch (selectMachine)
			{
			case 0:
				num = SlotUserData_m1.saveData.getTotalGameCount();
				break;
			case 1:
				num = SlotUserData_m2.saveData.getTotalGameCount();
				break;
			case 2:
				num = SlotUserData_m3.saveData.getTotalGameCount();
				break;
			case 3:
				num = SlotUserData_m4.saveData.getTotalGameCount();
				break;
			case 4:
				num = SlotUserData_m5.saveData.getTotalGameCount();
				break;
			case 5:
				num = SlotUserData_m6.saveData.getTotalGameCount();
				break;
			case 6:
				num = SlotUserData_m7.saveData.getTotalGameCount();
				break;
			case 7:
				num = SlotUserData_m8.saveData.getTotalGameCount();
				break;
			case 8:
				num = SlotUserData_m9.saveData.getTotalGameCount();
				break;
			case 9:
				num = SlotUserData_m10.saveData.getTotalGameCount();
				break;
			}
			if (totalGameCount == num)
			{
				gameStart_ContinueHall();
				return;
			}
			if (get_pkd_data(86) == 5 || get_pkd_data(86) == 6)
			{
				restartPB();
			}
			else
			{
				restartStage();
			}
		}
		else
		{
			MainGameScene.dir3MST_Sub.initPosition();
			MainGameScene.dirMan.EventStageChanged(3, 0, 1);
			MainGameScene.dirMan.demoStart();
		}
		MainGameScene.dirMan.changeStageIntarface(MainGameScene.slotGameMan.m_dirData[45]);
		short stageLmp = getStageLmp();
		DirectionMainLED._start(228, 1, stageLmp);
		MainGameScene.m_PlaySaveData.setAuto(4);
		MainGameScene.m_PlaySaveData.m_autoLevel = 0;
		old_totalGameCount = totalGameCount;
		old_mochiMedal = m_mochiMedal;
		if (old_totalGameCount < 0)
		{
			old_totalGameCount = 0;
		}
		if (old_mochiMedal < 0)
		{
			old_mochiMedal = 0;
		}
	}

	public void reStart()
	{
		bool flag = false;
		if ((SGLG.gameMode != SGLG.GAMEMODE.HALL) ? ((byte)MainGameScene.m_SlotSaveData.totalGameCount != 0) : (MainGameScene.m_SlotSaveData.m_saveFlag && (selectMachineOld == -1 || selectMachineOld == selectMachine)))
		{
			gameStart_Continue();
		}
		else
		{
			gameStart_NewGame();
		}
		m_kaidoData[16] = 1;
		set_pkd_data(16, 1);
		SGLGDebugData.updateVariable();
	}

	public void bet_on()
	{
		m_mochiMedal -= 3;
		m_creditMedal -= 3;
		m_inMedal += 3;
		if (m_mochiMedal * -1 > m_kaidoData[622])
		{
			m_kaidoData[622] = m_mochiMedal * -1;
			set_pkd_data(622, m_kaidoData[622]);
		}
		if (m_creditMedal < 0)
		{
			m_creditMedal = 0;
		}
		m_betMedal += 3;
		if (m_demoFlag == 3)
		{
			MainGameScene.dirMan.demoClear();
		}
		m_demoFlag = 0;
		if ((ulDedamaLotState & 1) != 0L)
		{
			int num = MainGameScene.slotGameMan.get_pkd_data(575);
			num -= 3;
			if (num < 0)
			{
				num = 0;
			}
			m_kaidoData[575] = num;
			MainGameScene.slotGameMan.set_pkd_data(575, num);
			bnsGetMedal -= 3;
			if (bnsGetMedal < 0)
			{
				bnsGetMedal = 0;
			}
			m_kaidoData[575] = bnsGetMedal;
			MainGameScene.slotGameMan.set_pkd_data(575, bnsGetMedal);
		}
		else
		{
			bnsGetMedal = 0;
		}
		if ((ulDedamaLotState & 0x10000) != 0L || (ulDedamaLotState & 0x20000) != 0L || (ulDedamaLotState & 1) != 0L)
		{
			int num2 = MainGameScene.slotGameMan.get_pkd_data(577);
			num2 -= 3;
			if (num2 < 0)
			{
				num2 = 0;
			}
			m_kaidoData[577] = num2;
			MainGameScene.slotGameMan.set_pkd_data(577, num2);
			artGetMedal -= 3;
			if (artGetMedal < 0)
			{
				artGetMedal = 0;
			}
		}
		SGLGDebugData.updateVariable();
	}

	public void lever_on()
	{
		if (!m_replay)
		{
			m_betMedal -= 3;
		}
		m_replay = false;
		if ((ulDedamaLotState & 1) == 0L && (get_pdt_data(45) < 13 || 23 < get_pdt_data(45)) && (ulDedamaLotState & 0x200000) == 0L)
		{
			addSlump();
			gameCount++;
			totalGameCount++;
		}
		if ((ulDedamaLotState & 0x10000) == 0L)
		{
			gameCountArt++;
		}
		if (SGLG.gameMode == SGLG.GAMEMODE.HALL)
		{
			UserData.saveData.hall.gameDayCnt++;
		}
		SGLGDebugData.updateVariable();
	}

	private void addSlump()
	{
		int num = totalGameCount - old_totalGameCount;
		int medal = m_mochiMedal - old_mochiMedal;
		if (SGLG.gameMode == SGLG.GAMEMODE.HALL)
		{
			if (num % SlumpData.SAVE_GAME == 0)
			{
				m_SlumpData.addData(num, medal);
			}
		}
		else if (num % SlumpDataSim.SAVE_GAME == 0)
		{
			m_SlumpDataSim.addData(num, medal);
		}
	}

	public void payout()
	{
		int num = get_koyaku_prm(2);
		m_payoutMedal = 0;
		switch (m_kaidoData[56])
		{
		case 1:
		case 2:
		case 4:
		case 8:
		case 16:
		case 32:
		case 64:
		case 128:
			m_payoutMedal++;
			break;
		}
		switch (m_kaidoData[57])
		{
		case 1:
		case 2:
		case 4:
		case 8:
		case 16:
		case 32:
			m_payoutMedal++;
			break;
		case 64:
		case 128:
			m_payoutMedal += 5;
			break;
		}
		switch (m_kaidoData[58])
		{
		case 1:
			m_payoutMedal += 9;
			break;
		case 2:
		case 4:
		case 8:
		case 16:
			m_payoutMedal += 13;
			break;
		case 32:
		case 64:
			m_payoutMedal += 14;
			break;
		}
		switch (m_kaidoData[59])
		{
		case 1:
		case 2:
		case 4:
		case 8:
		case 16:
		case 32:
		case 64:
		case 128:
			m_replay = true;
			break;
		}
		switch (m_kaidoData[60])
		{
		case 1:
		case 2:
		case 4:
		case 8:
		case 16:
		case 32:
		case 64:
		case 128:
			m_replay = true;
			break;
		}
		switch (m_kaidoData[61])
		{
		case 1:
		case 2:
		case 4:
		case 8:
		case 16:
		case 32:
		case 64:
		case 128:
			m_replay = true;
			break;
		}
		switch (m_kaidoData[62])
		{
		}
		m_mochiMedal += m_payoutMedal;
		m_creditMedal += m_payoutMedal;
		m_outMedal += m_payoutMedal;
		if (m_creditMedal > 50)
		{
			m_creditMedal = 50;
		}
		if (m_payoutMedal == 13)
		{
			if (m_kaidoData[58] == 2)
			{
			}
		}
		else if (m_payoutMedal == 14)
		{
			if (get_koyaku_prm(0) == 1)
			{
				set_koyaku_prm(0, 0);
				m_koyakuState = 0;
			}
			if (pbLastMedal > 0)
			{
				pbLastMedal -= 14;
				if (pbLastMedal < 0)
				{
					pbLastMedal = 0;
				}
				m_kaidoData[574] = pbLastMedal;
				set_pkd_data(574, pbLastMedal);
			}
		}
		if ((ulDedamaLotState & 1) != 0L || get_pkd_data(86) == 6)
		{
			int num2 = get_pkd_data(575);
			bnsGetMedal += m_payoutMedal;
			m_kaidoData[575] = bnsGetMedal;
			set_pkd_data(575, bnsGetMedal);
		}
		if ((ulDedamaLotState & 0x10000) != 0L || (ulDedamaLotState & 0x20000) != 0L || (ulDedamaLotState & 1) != 0L)
		{
			int num3 = get_pkd_data(577);
			artGetMedal += m_payoutMedal;
			m_kaidoData[577] = artGetMedal;
			set_pkd_data(577, artGetMedal);
		}
		if (!m_replay)
		{
			m_demoFlag = 1;
		}
		SGLGDebugData.updateVariable();
	}

	public void getPluginPrm()
	{
		for (int i = 0; i < 105; i++)
		{
			m_dirData[i] = get_pdt_data(i);
		}
		for (int i = 0; i < 657; i++)
		{
			m_kaidoData[i] = get_pkd_data(i);
		}
		for (int i = 0; i < 13; i++)
		{
			m_reelData[i] = get_pri_data(i);
		}
		ulDedamaLotState = get_pkd_data(0);
		ulDedamaLotStateOld = get_pkd_data(1);
	}

	public void setPluginPrm()
	{
		for (int i = 0; i < 105; i++)
		{
			set_pdt_data(i, m_dirData[i]);
		}
		for (int i = 0; i < 657; i++)
		{
			set_pkd_data(i, m_kaidoData[i]);
		}
		for (int i = 0; i < 13; i++)
		{
			set_pri_data(i, m_reelData[i]);
		}
		set_pkd_data(0, (int)ulDedamaLotState);
		set_pkd_data(1, (int)ulDedamaLotStateOld);
	}

	public int getDiffMedalNum()
	{
		int num = m_outMedal - m_inMedal;
		if (num < 0)
		{
			num = 0;
		}
		return num;
	}

	public void getSimulationPrm()
	{
		if (SGLG.gameMode == SGLG.GAMEMODE.SIMULATION)
		{
			data = Sim_MachineData.saveData.machine;
			settei = (m_kaidoData[39] = Sim_MachineData.saveData.settei);
		}
	}

	public void setSimulationPrm()
	{
		if (SGLG.gameMode == SGLG.GAMEMODE.SIMULATION)
		{
			Sim_MachineData.saveData.set();
			Sim_MachineData.save();
		}
	}

	public void getHallPrm()
	{
		if (SGLG.gameMode != SGLG.GAMEMODE.HALL)
		{
			return;
		}
		selectMachine = UserData.saveData.game.selectMachine;
		m_mochiMedal = UserData.saveData.game.motiMedals;
		if (selectMachine <= -1)
		{
			return;
		}
		data = UserData.saveData.game.getMachineData(selectMachine);
		settei = UserData.saveData.hall.settei[selectMachine];
		gameCount = data.gameCount;
		modeMain = data.modeMain;
		modeSub = data.modeSub;
		totalGameCount = data.totalGameCount;
		artCount = data.artCount;
		bnsCount = data.bnsCount;
		mode = data.mode;
		modeArt = data.modeArt;
		cycleGame = data.cycleGame;
		cycleMode = data.cycleMode;
		yaku = data.yaku;
		FLTousen1 = data.FLTousen1;
		reelStep = data.reelStep;
		bonusGame = data.bonusGame;
		artGame = data.artGame;
		artCntContBtl = data.artCntContBtl;
		artStockCnt = data.artStockCnt;
		artBtlWin = data.artBtlWin;
		jgGame = data.jgGame;
		hohGame = data.hohGame;
		artCntVarGame = data.artCntVarGame;
		hohChar = data.hohChar;
		hohTension = data.hohTension;
		hohRivalCharDamage = data.hohRivalCharDamage;
		hohSolCharDamage = data.hohSolCharDamage;
		gbChargeCnt = data.gbChargeCnt;
		rbMap = data.rbMap;
		if (totalGameCount == 0)
		{
			return;
		}
		m_kaidoData[39] = settei;
		m_kaidoData[78] = 0;
		m_kaidoData[86] = modeMain;
		m_kaidoData[87] = modeMain;
		m_kaidoData[85] = mode;
		m_kaidoData[210] = modeArt;
		m_kaidoData[80] = cycleGame;
		m_kaidoData[81] = cycleMode;
		m_kaidoData[54] = yaku;
		m_kaidoData[53] = FLTousen1;
		m_kaidoData[462] = reelStep;
		m_kaidoData[573] = bonusGame;
		m_kaidoData[209] = artGame;
		m_kaidoData[450] = artCntContBtl;
		m_kaidoData[229] = artStockCnt;
		if (artBtlWin)
		{
			ulDedamaLotState = (ulDedamaLotState |= 262144L);
		}
		m_kaidoData[224] = 10 - jgGame;
		m_kaidoData[95] = hohGame;
		m_kaidoData[213] = artCntVarGame;
		m_kaidoData[93] = hohChar;
		m_kaidoData[101] = hohTension;
		m_kaidoData[97] = hohRivalCharDamage;
		m_kaidoData[96] = hohSolCharDamage;
		m_kaidoData[466] = gbChargeCnt;
		m_kaidoData[214] = rbMap;
		ulDedamaLotState = 0L;
		switch (modeSub)
		{
		case 0:
			m_dirData[45] = 0;
			m_kaidoData[86] = 0;
			m_kaidoData[87] = 0;
			break;
		case 1:
			m_dirData[45] = 3;
			ulDedamaLotState |= 256L;
			m_kaidoData[86] = 0;
			m_kaidoData[87] = 0;
			break;
		default:
			if (modeMain == 2)
			{
				m_dirData[45] = 11;
				m_kaidoData[86] = 2;
				m_kaidoData[87] = 2;
				switch (modeSub)
				{
				case 4:
					m_kaidoData[338] = 1;
					ulDedamaLotState |= 32L;
					break;
				case 5:
					m_kaidoData[338] = 2;
					ulDedamaLotState |= 32L;
					break;
				case 6:
					m_kaidoData[338] = 3;
					ulDedamaLotState |= 32L;
					break;
				case 11:
					m_kaidoData[338] = 1;
					m_kaidoData[493] = cycleGame;
					artGame -= 40;
					m_kaidoData[490] = artGame;
					artDispCnt = artGame;
					m_kaidoData[489] = artGame;
					ulDedamaLotState |= 131072L;
					break;
				case 12:
					m_kaidoData[338] = 2;
					m_kaidoData[493] = cycleGame;
					artGame -= 40;
					m_kaidoData[490] = artGame;
					artDispCnt = artGame;
					m_kaidoData[489] = artGame;
					ulDedamaLotState |= 131072L;
					break;
				case 13:
					m_kaidoData[338] = 3;
					m_kaidoData[493] = cycleGame;
					artGame -= 40;
					m_kaidoData[490] = artGame;
					artDispCnt = artGame;
					m_kaidoData[489] = artGame;
					ulDedamaLotState |= 131072L;
					break;
				}
				m_kaidoData[337] = 1;
				ulDedamaLotState |= 64L;
			}
			else if (modeMain == 5)
			{
				m_dirData[45] = 11;
				m_kaidoData[86] = 5;
				m_kaidoData[87] = 5;
				switch (modeSub)
				{
				case 13:
					m_kaidoData[338] = 3;
					ulDedamaLotState |= 32L;
					break;
				case 14:
					m_kaidoData[338] = 3;
					m_kaidoData[493] = cycleGame;
					artGame -= 40;
					m_kaidoData[490] = artGame;
					artDispCnt = artGame;
					m_kaidoData[489] = artGame;
					ulDedamaLotState |= 131072L;
					break;
				}
				m_kaidoData[337] = 1;
				ulDedamaLotState |= 64L;
				ulDedamaLotState |= 16L;
			}
			else
			{
				m_dirData[45] = 0;
				SGLG_PlugIn.all_clr();
				int num = (int)Random.Range(0f, 100f);
				for (int i = 0; i < num; i++)
				{
					SGLG_PlugIn.all_clr();
				}
				getPluginPrm();
			}
			break;
		}
		if (data.hisData.bnsPBCnt == 0 && data.hisData.bnsGBCnt == 0 && data.hisData.bnsSGBCnt == 0 && data.hisData.bnsRBCnt == 0 && data.hisData.artCnt == 0)
		{
			m_kaidoData[76] = 444;
			m_kaidoData[76] += gameCount;
		}
		else
		{
			m_kaidoData[76] = 0;
			m_kaidoData[76] += gameCount;
		}
		setPluginPrm();
	}

	public void setHallPrm()
	{
		if (SGLG.gameMode != SGLG.GAMEMODE.HALL)
		{
			return;
		}
		getPluginPrm();
		modeMain = m_kaidoData[86];
		if (modeMain == 5)
		{
			if ((ulDedamaLotState & 0x20000) != 0L || (ulDedamaLotState & 0x10000) != 0L)
			{
				modeSub = 9;
			}
			else if ((ulDedamaLotState & 0x40) != 0L)
			{
				switch (m_kaidoData[338])
				{
				case 1:
					if ((ulDedamaLotState & 0x20) != 0L)
					{
						modeSub = 12;
					}
					else
					{
						modeSub = 13;
					}
					break;
				case 2:
					if ((ulDedamaLotState & 0x20) != 0L)
					{
						modeSub = 12;
					}
					else
					{
						modeSub = 13;
					}
					break;
				case 3:
					if ((ulDedamaLotState & 0x20) != 0L)
					{
						modeSub = 12;
					}
					else
					{
						modeSub = 13;
					}
					break;
				}
			}
			else
			{
				modeSub = 3;
			}
		}
		else
		{
			switch (m_dirData[45])
			{
			case 0:
			case 1:
			case 2:
				modeSub = 0;
				break;
			case 3:
				modeSub = 1;
				break;
			case 4:
			case 5:
				modeSub = 7;
				break;
			case 11:
				modeMain = 2;
				switch (m_kaidoData[338])
				{
				case 1:
					if ((ulDedamaLotState & 0x20) != 0L)
					{
						modeSub = 4;
					}
					else
					{
						modeSub = 10;
					}
					break;
				case 2:
					if ((ulDedamaLotState & 0x20) != 0L)
					{
						modeSub = 5;
					}
					else
					{
						modeSub = 11;
					}
					break;
				case 3:
					if ((ulDedamaLotState & 0x20) != 0L)
					{
						modeSub = 6;
					}
					else
					{
						modeSub = 12;
					}
					break;
				}
				break;
			case 13:
				modeSub = 5;
				break;
			case 14:
				modeSub = 6;
				break;
			case 19:
				modeSub = 4;
				break;
			case 20:
				modeSub = 3;
				break;
			case 25:
				modeSub = 2;
				break;
			case 27:
				modeSub = 8;
				break;
			}
		}
		mode = (short)m_kaidoData[85];
		modeArt = (short)m_kaidoData[210];
		cycleGame = m_kaidoData[80];
		cycleMode = (short)m_kaidoData[81];
		yaku = m_kaidoData[54];
		FLTousen1 = m_kaidoData[53];
		reelStep = m_kaidoData[462];
		bonusGame = m_kaidoData[573];
		artGame = m_kaidoData[209];
		artCntContBtl = m_kaidoData[450];
		artStockCnt = m_kaidoData[229];
		artBtlWin = false;
		if ((ulDedamaLotState & 0x40000) != 0L)
		{
			artBtlWin = true;
		}
		jgGame = 10 - m_kaidoData[224];
		hohGame = m_kaidoData[95];
		artCntVarGame = m_kaidoData[213];
		hohChar = (short)m_kaidoData[93];
		hohTension = (short)m_kaidoData[101];
		hohRivalCharDamage = (short)m_kaidoData[97];
		hohSolCharDamage = (short)m_kaidoData[96];
		gbChargeCnt = (short)m_kaidoData[466];
		rbMap = (short)m_kaidoData[214];
		if ((ulDedamaLotState & 0x10000) != 0L)
		{
			cycleGame = m_kaidoData[493];
		}
		if (selectMachine > -1)
		{
			UserData.saveData.game.getMachineData(selectMachine).gameCount = gameCount;
			UserData.saveData.game.getMachineData(selectMachine).modeMain = modeMain;
			UserData.saveData.game.getMachineData(selectMachine).modeSub = modeSub;
			UserData.saveData.game.getMachineData(selectMachine).totalGameCount = totalGameCount;
			UserData.saveData.game.getMachineData(selectMachine).artCount = artCount;
			UserData.saveData.game.getMachineData(selectMachine).bnsCount = bnsCount;
			UserData.saveData.game.getMachineData(selectMachine).mode = mode;
			UserData.saveData.game.getMachineData(selectMachine).modeArt = modeArt;
			UserData.saveData.game.getMachineData(selectMachine).cycleGame = cycleGame;
			UserData.saveData.game.getMachineData(selectMachine).cycleMode = cycleMode;
			UserData.saveData.game.getMachineData(selectMachine).yaku = yaku;
			UserData.saveData.game.getMachineData(selectMachine).FLTousen1 = FLTousen1;
			UserData.saveData.game.getMachineData(selectMachine).reelStep = reelStep;
			UserData.saveData.game.getMachineData(selectMachine).bonusGame = bonusGame;
			UserData.saveData.game.getMachineData(selectMachine).artGame = artGame;
			UserData.saveData.game.getMachineData(selectMachine).artCntContBtl = artCntContBtl;
			UserData.saveData.game.getMachineData(selectMachine).artStockCnt = artStockCnt;
			UserData.saveData.game.getMachineData(selectMachine).artBtlWin = artBtlWin;
			UserData.saveData.game.getMachineData(selectMachine).jgGame = jgGame;
			UserData.saveData.game.getMachineData(selectMachine).hohGame = hohGame;
			UserData.saveData.game.getMachineData(selectMachine).artCntVarGame = artCntVarGame;
			UserData.saveData.game.getMachineData(selectMachine).hohChar = hohChar;
			UserData.saveData.game.getMachineData(selectMachine).hohTension = hohTension;
			UserData.saveData.game.getMachineData(selectMachine).hohRivalCharDamage = hohRivalCharDamage;
			UserData.saveData.game.getMachineData(selectMachine).hohSolCharDamage = hohSolCharDamage;
			UserData.saveData.game.getMachineData(selectMachine).gbChargeCnt = gbChargeCnt;
			UserData.saveData.game.getMachineData(selectMachine).rbMap = rbMap;
			UserData.saveData.game.getMachineData(selectMachine).hisData.bnsPBCnt = data.hisData.bnsPBCnt;
			UserData.saveData.game.getMachineData(selectMachine).hisData.bnsGBCnt = data.hisData.bnsGBCnt;
			UserData.saveData.game.getMachineData(selectMachine).hisData.bnsSGBCnt = data.hisData.bnsSGBCnt;
			UserData.saveData.game.getMachineData(selectMachine).hisData.bnsRBCnt = data.hisData.bnsRBCnt;
			UserData.saveData.game.getMachineData(selectMachine).hisData.artCnt = data.hisData.artCnt;
			UserData.saveData.game.getMachineData(selectMachine).hisData.bnsBBCntYesterDay = data.hisData.bnsBBCntYesterDay;
			UserData.saveData.game.getMachineData(selectMachine).hisData.bnsRBCntYesterDay = data.hisData.bnsRBCntYesterDay;
			UserData.saveData.game.getMachineData(selectMachine).hisData.artCntYesterDay = data.hisData.artCntYesterDay;
			for (int i = 0; i < 20; i++)
			{
				UserData.saveData.game.getMachineData(selectMachine).hisData.LogTousenYaku[i] = data.hisData.LogTousenYaku[i];
				UserData.saveData.game.getMachineData(selectMachine).hisData.LogGameCount[i] = data.hisData.LogGameCount[i];
				UserData.saveData.game.getMachineData(selectMachine).hisData.LogDouziYaku[i] = data.hisData.LogDouziYaku[i];
			}
			UserData.saveData.game.motiMedals = m_mochiMedal;
			UserData.save();
		}
	}

	public void setHistory(int game, int tousen)
	{
		data.hisData.setLog(game, tousen);
		switch (tousen)
		{
		case 0:
			data.hisData.bnsPBCnt++;
			break;
		case 1:
			data.hisData.bnsRBCnt++;
			break;
		case 2:
			data.hisData.bnsGBCnt++;
			break;
		case 3:
			data.hisData.bnsSGBCnt++;
			break;
		case 4:
			data.hisData.artCnt++;
			break;
		}
		SGLGDebugData.updateVariable();
	}

	public void setHistory(int _douzi)
	{
		int num = _douzi;
		if (num >= 0 && 33 >= num)
		{
			num = 9;
		}
		else if (num == 34)
		{
			num = 9;
		}
		else if (num >= 39 && 45 >= num)
		{
			num = 4;
		}
		else if (num == 38)
		{
			num = 3;
		}
		else if (num == 46)
		{
			num = 5;
		}
		else if (num == 36)
		{
			num = 1;
		}
		else if (num == 37)
		{
			num = 2;
		}
		else if (num == 35)
		{
			num = 0;
		}
		else if (num >= 47 && 48 >= num)
		{
			num = 6;
		}
		else if (num == 49)
		{
			num = 8;
		}
		data.hisData.setLog(num);
	}

	public bool isSelectMachine()
	{
		bool result = false;
		if (selectMachine != -1)
		{
			result = true;
		}
		return result;
	}

	public void initDeme()
	{
		m_kaidoData[56] = 0;
		m_kaidoData[57] = 0;
		m_kaidoData[58] = 0;
		m_kaidoData[59] = 0;
		m_kaidoData[60] = 0;
		m_kaidoData[61] = 0;
		m_kaidoData[62] = 0;
	}

	public void setDeme(int _num)
	{
		switch (_num)
		{
		case 0:
			m_kaidoData[56] = ZugaraManager.getWinZu0(MainGameScene.reelMan.getReelStop(0), MainGameScene.reelMan.getReelStop(1), MainGameScene.reelMan.getReelStop(2));
			break;
		case 1:
			m_kaidoData[57] = ZugaraManager.getWinZu1(MainGameScene.reelMan.getReelStop(0), MainGameScene.reelMan.getReelStop(1), MainGameScene.reelMan.getReelStop(2));
			break;
		case 2:
			m_kaidoData[58] = ZugaraManager.getWinZu2(MainGameScene.reelMan.getReelStop(0), MainGameScene.reelMan.getReelStop(1), MainGameScene.reelMan.getReelStop(2));
			break;
		case 3:
			m_kaidoData[59] = ZugaraManager.getWinZu3(MainGameScene.reelMan.getReelStop(0), MainGameScene.reelMan.getReelStop(1), MainGameScene.reelMan.getReelStop(2));
			break;
		case 4:
			m_kaidoData[60] = ZugaraManager.getWinZu4(MainGameScene.reelMan.getReelStop(0), MainGameScene.reelMan.getReelStop(1), MainGameScene.reelMan.getReelStop(2));
			break;
		case 5:
			m_kaidoData[61] = ZugaraManager.getWinZu5(MainGameScene.reelMan.getReelStop(0), MainGameScene.reelMan.getReelStop(1), MainGameScene.reelMan.getReelStop(2));
			break;
		case 6:
			m_kaidoData[62] = ZugaraManager.getWinZu6(MainGameScene.reelMan.getReelStop(0), MainGameScene.reelMan.getReelStop(1), MainGameScene.reelMan.getReelStop(2));
			break;
		}
	}

	public void setDemeReel()
	{
		int[] array = new int[3] { 1, 0, -1 };
		for (int i = 0; i < 3; i++)
		{
			m_kaidoData[63 + i] = MainGameScene.reelMan.getReelStop(0) + array[i];
			m_kaidoData[66 + i] = MainGameScene.reelMan.getReelStop(1) + array[i];
			m_kaidoData[69 + i] = MainGameScene.reelMan.getReelStop(2) + array[i];
			set_pkd_data(63 + i, m_kaidoData[63 + i]);
			set_pkd_data(66 + i, m_kaidoData[66 + i]);
			set_pkd_data(69 + i, m_kaidoData[69 + i]);
		}
		if (m_kaidoData[62] == 128 && get_pkd_data(86) != 5)
		{
			m_kaidoData[62] = 0;
			set_pkd_data(62, 0);
			for (int j = 0; j < 3; j++)
			{
				m_kaidoData[63 + j] = 0;
				m_kaidoData[66 + j] = 0;
				m_kaidoData[69 + j] = 0;
				set_pkd_data(63 + j, 0);
				set_pkd_data(66 + j, 0);
				set_pkd_data(69 + j, 0);
			}
		}
		if (get_koyaku_prm(2) >= 2 && 4 >= get_koyaku_prm(2) && MainGameScene.slotMan.m_State == SlotBodyManager.STATE.REEL_STOP3 && m_kaidoData[70] != 0 && m_kaidoData[70] != 4 && m_kaidoData[70] != 8 && m_kaidoData[70] != 12 && m_kaidoData[70] != 16 && m_kaidoData[70] != 18)
		{
			m_kaidoData[64] = 0;
			m_kaidoData[67] = 0;
			m_kaidoData[70] = 0;
			set_pkd_data(64, 0);
			set_pkd_data(67, 0);
			set_pkd_data(70, 0);
		}
	}

	public int getDeme()
	{
		int result = 0;
		switch (m_kaidoData[56])
		{
		case 1:
		case 2:
			result = 1;
			break;
		case 4:
			result = 2;
			break;
		case 8:
		case 16:
		case 32:
		case 64:
		case 128:
			result = 3;
			break;
		}
		switch (m_kaidoData[57])
		{
		case 1:
		case 2:
		case 4:
		case 8:
		case 16:
		case 32:
			result = 3;
			break;
		case 64:
		case 128:
			result = 4;
			break;
		}
		switch (m_kaidoData[58])
		{
		case 1:
			result = 5;
			break;
		case 2:
			result = 6;
			break;
		case 4:
		case 8:
		case 16:
			result = 7;
			break;
		case 32:
		case 64:
			result = 8;
			break;
		}
		switch (m_kaidoData[59])
		{
		case 1:
		case 2:
		case 4:
		case 8:
			result = 9;
			break;
		case 128:
			result = 10;
			break;
		}
		switch (m_kaidoData[60])
		{
		case 1:
		case 2:
		case 4:
		case 8:
		case 16:
		case 32:
			result = 10;
			break;
		}
		switch (m_kaidoData[61])
		{
		case 16:
		case 32:
		case 64:
		case 128:
			result = 10;
			break;
		}
		switch (m_kaidoData[62])
		{
		case 64:
			result = 11;
			break;
		}
		return result;
	}

	public int getBonusState()
	{
		int result = -1;
		if ((ulDedamaLotState & 1) != 0L)
		{
			if (m_bonusTouroku == 2)
			{
				if ((ulDedamaLotState & 0x10) != 0L)
				{
					result = 0;
				}
				else
				{
					switch (m_kaidoData[439])
					{
					case 25:
						result = 1;
						break;
					case 50:
						result = 2;
						break;
					case 100:
						result = 3;
						break;
					}
				}
			}
		}
		else if (m_bonusTouroku == 2)
		{
			m_bonusTouroku = 0;
		}
		return result;
	}

	public int getRomanBulletNum()
	{
		int num = get_pkd_data(495);
		int num2 = get_pkd_data(494);
		int num3 = 0;
		if (get_pdt_data(45) == 22 && num2 > 0)
		{
			num3 = num2 - num + 1;
			if (num3 < 0)
			{
				num3 = 0;
			}
		}
		return num3;
	}

	public int getRomanUwanoseProd()
	{
		int result = 0;
		int romanBulletNum = getRomanBulletNum();
		switch (get_pkd_data(497 + romanBulletNum))
		{
		case 0:
		case 1:
			result = 183;
			break;
		case 2:
			result = 184;
			break;
		case 3:
			result = 185;
			break;
		case 4:
			result = 186;
			break;
		case 5:
			result = 187;
			break;
		case 6:
			result = 188;
			break;
		case 7:
			result = 189;
			break;
		case 8:
			result = 190;
			break;
		}
		return result;
	}

	public int getBJTChargeNum()
	{
		int num = get_pkd_data(466);
		int num2 = get_pdt_data(45);
		int num3 = 0;
		if ((ulDedamaLotState & 1) != 0L)
		{
			if (num > 0)
			{
				num3 = num;
				if (num3 < 0)
				{
					num3 = 0;
				}
			}
			if (num2 >= 15 && 20 >= num2)
			{
				num3 = 0;
			}
		}
		return num3;
	}

	public int getWakuLmp()
	{
		return get_pdt_data(86);
	}

	public int getDesPanel()
	{
		return get_pdt_data(87);
	}

	public int getNaviPanel()
	{
		return get_pdt_data(88);
	}

	public int getSlashPanel()
	{
		int num = get_pdt_data(1);
		int num2 = get_pdt_data(5);
		int num3 = get_pdt_data(89);
		int num4 = 0;
		int num5 = num3;
		if (num3 == 2)
		{
			switch (num)
			{
			case 2:
				if ((4 <= num2 && num2 <= 5) || (36 <= num2 && num2 <= 37) || (67 <= num2 && num2 <= 68) || (12 <= num2 && num2 <= 13) || (20 <= num2 && num2 <= 21) || (44 <= num2 && num2 <= 45) || (52 <= num2 && num2 <= 53) || (74 <= num2 && num2 <= 75) || (81 <= num2 && num2 <= 82))
				{
					num5 = 3;
				}
				else if (99 <= num2 && num2 <= 104)
				{
					num5 = 4;
				}
				else if (94 <= num2 && num2 <= 95)
				{
					num5 = 5;
				}
				break;
			case 12:
				if ((4 <= num2 && num2 <= 5) || (12 <= num2 && num2 <= 13) || (20 <= num2 && num2 <= 21) || (36 <= num2 && num2 <= 37) || (44 <= num2 && num2 <= 45) || (52 <= num2 && num2 <= 53) || (67 <= num2 && num2 <= 68) || (74 <= num2 && num2 <= 75) || (81 <= num2 && num2 <= 82))
				{
					num5 = 6;
				}
				else if (94 <= num2 && num2 <= 95)
				{
					num5 = 8;
				}
				else if (97 <= num2 && num2 <= 98)
				{
					num5 = 7;
				}
				break;
			case 62:
				if ((4 <= num2 && num2 <= 5) || (12 <= num2 && num2 <= 13) || (20 <= num2 && num2 <= 21) || (36 <= num2 && num2 <= 37) || (44 <= num2 && num2 <= 45) || (52 <= num2 && num2 <= 53) || (67 <= num2 && num2 <= 68) || (74 <= num2 && num2 <= 75) || (81 <= num2 && num2 <= 82))
				{
					num5 = 9;
				}
				else if (94 <= num2 && num2 <= 95)
				{
					num5 = 11;
				}
				else if (97 <= num2 && num2 <= 98)
				{
					num5 = 10;
				}
				break;
			case 48:
				if (num4 == 99)
				{
					if (45 <= num2 && num2 <= 46)
					{
						num5 = 13;
					}
				}
				else if ((21 <= num2 && num2 <= 22) || (25 <= num2 && num2 <= 26) || (29 <= num2 && num2 <= 32) || (35 <= num2 && num2 <= 36) || (39 <= num2 && num2 <= 40) || (43 <= num2 && num2 <= 44) || (47 <= num2 && num2 <= 48))
				{
					num5 = 12;
				}
				break;
			}
		}
		if (num5 == 0)
		{
			num5 = 1;
		}
		return num5;
	}

	public int getCharPanel()
	{
		return get_pdt_data(90);
	}

	public int getLEDLever()
	{
		return get_pdt_data(91);
	}

	public int getBackLmp()
	{
		return get_pdt_data(92);
	}

	public int getGageLmp()
	{
		return get_pdt_data(93);
	}

	public int getPUSHbtnStatus()
	{
		int num = get_pkd_data(635);
		if (!MainGameScene.pushMan.getCanPush())
		{
			if (num != 31 && num != 33)
			{
				num = 0;
			}
		}
		else if (num == 0)
		{
			num = 1;
		}
		return num;
	}

	public int getWinPanel()
	{
		return get_pkd_data(633);
	}

	public bool getStateJAC()
	{
		bool result = false;
		if (get_koyaku_prm(0) == 1)
		{
			result = true;
		}
		return result;
	}

	public int getHOHStage()
	{
		return get_pdt_data(48);
	}

	public void lmpMainCmd()
	{
		int num = 0;
		short high = 0;
		short low = 0;
		short num2 = 0;
		short num3 = 0;
		if (get_pdt_data(45) == 19)
		{
			return;
		}
		for (int i = 0; i < 1024; i++)
		{
			switch (num)
			{
			case 0:
				if (i % 4 == 0 && (get_SubCmdBuf(i) == 228 || get_SubCmdBuf(i) == 226))
				{
					num = 1;
					high = get_SubCmdBuf(i);
				}
				break;
			case 1:
				switch (i % 4)
				{
				case 1:
					low = get_SubCmdBuf(i);
					break;
				case 2:
					num2 = get_SubCmdBuf(i);
					break;
				case 3:
					num3 = get_SubCmdBuf(i);
					DirectionMainLED._start(high, low, num2);
					num = 0;
					high = 0;
					low = 0;
					num2 = 0;
					num3 = 0;
					break;
				}
				break;
			}
		}
		int num4 = get_pkd_data(465);
		int num5 = get_pkd_data(466);
		int num6 = get_pkd_data(467);
		int num7 = get_pkd_data(468);
		int num8 = get_pkd_data(567);
		int num9 = get_pdt_data(1);
		int num10 = get_pdt_data(5);
	}

	public void lmpBJTCmd(int _state)
	{
		int num = get_pkd_data(466);
		int num2 = get_pkd_data(467);
		int num3 = get_pkd_data(470 + num2 - 1);
		int num4 = 0;
		num4 = (num2 - 1) * 7 + num3;
		switch (_state)
		{
		case 0:
			DirectionMainLED._start(226, 8, (short)num4);
			break;
		case 1:
			if (num - num2 > 0)
			{
				num3 = get_pkd_data(470 + num2);
				num4 = num2 * 7 + num3;
				DirectionMainLED._start(226, 7, (short)num4);
			}
			break;
		}
	}

	public void lmpHOHtensionLmp()
	{
		int num = get_pkd_data(102);
		int num2 = get_pkd_data(101);
		int num3 = num2 - num;
		int num4 = 0;
		if (num != 0)
		{
			switch (num3)
			{
			case 0:
				num4 = num;
				break;
			case 1:
				num4 = num + 5;
				break;
			case 2:
				num4 = num + 9;
				break;
			case 3:
				num4 = num + 12;
				break;
			case 4:
				num4 = num + 14;
				break;
			}
			if (num4 != 0)
			{
				DirectionMainLED._start(226, 4, (short)num4);
			}
		}
	}

	public void lmpDrInCmd(int _state)
	{
		int num = get_pkd_data(220);
		DirectionMainLED._start(226, 6, (short)num);
		if (num >= 0)
		{
			DirectionPanelLED.runMac2App(5, 6);
		}
		else
		{
			DirectionPanelLED.runMac2App(6, 6);
		}
	}

	public bool getNaviProc()
	{
		bool result = false;
		if (get_pri_data(3) != 0)
		{
			result = true;
		}
		return result;
	}

	public bool getDirDestroy()
	{
		bool result = false;
		int num = get_pdt_data(1);
		int num2 = get_pdt_data(5);
		switch (num)
		{
		case 7:
		case 49:
		case 50:
		case 51:
			if (num2 >= 226 && 229 >= num2)
			{
				result = true;
			}
			break;
		case 35:
			if (num2 >= 33 && 40 >= num2)
			{
				result = true;
			}
			break;
		case 55:
			result = true;
			break;
		}
		return result;
	}

	public short getStageLmp()
	{
		int num = get_pdt_data(45);
		short result = 0;
		switch (num)
		{
		case 0:
		case 1:
			result = 1;
			if ((ulDedamaLotState & 0x200000) != 0L)
			{
				result = 2;
			}
			break;
		case 2:
			result = 3;
			break;
		case 3:
			result = 4;
			break;
		case 24:
		case 25:
		case 26:
		case 27:
		case 28:
		case 29:
			result = 5;
			break;
		case 11:
			result = 6;
			break;
		case 13:
		case 14:
			result = 7;
			break;
		case 15:
		case 16:
			result = 8;
			break;
		case 19:
			result = 9;
			break;
		case 20:
			result = 10;
			break;
		case 4:
			result = 11;
			break;
		case 5:
			result = 12;
			break;
		case 30:
			result = 13;
			break;
		case 6:
			result = 14;
			break;
		case 7:
		case 8:
			result = 15;
			break;
		case 17:
		case 18:
			result = 16;
			break;
		case 9:
		case 10:
			result = 17;
			break;
		}
		return result;
	}

	public int getArtBgm()
	{
		int num = 62;
		int num2 = get_pkd_data(590);
		int num3 = get_pdt_data(45);
		int num4 = get_pkd_data(211);
		num = ((num4 <= 3) ? 62 : ((num4 <= 5) ? 63 : ((num4 <= 7) ? 64 : ((num4 <= 9) ? 65 : ((num4 <= 11) ? 66 : ((num4 <= 13) ? 67 : ((num4 > 15) ? 69 : 68)))))));
		switch (num2)
		{
		case 1:
			num = 70;
			break;
		case 2:
			num = 71;
			break;
		}
		if (num3 == 6)
		{
			num = 72;
		}
		return num;
	}

	public bool isJacIn()
	{
		bool result = false;
		switch (m_kaidoData[58])
		{
		case 4:
		case 8:
		case 16:
			result = true;
			break;
		case 32:
		case 64:
			result = true;
			break;
		}
		return result;
	}

	public void checkRThukki(int num, int oshi)
	{
		int[] array = new int[52];
		array[9] = 3;
		array[10] = 3;
		array[13] = 3;
		array[14] = 3;
		array[17] = 3;
		array[18] = 3;
		array[29] = 4;
		int[] array2 = array;
		int[] array3 = new int[52];
		array3[21] = 2;
		array3[22] = 2;
		array3[25] = 2;
		array3[26] = 2;
		array3[30] = 4;
		array3[31] = 4;
		int[] array4 = array3;
		int[] array5 = new int[52]
		{
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 3, 3, 0, 0, 3, 3, 0, 0, 3,
			3, 0, 0, 2, 2, 0, 0, 2, 2, 0,
			0, 0, 4, 4, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0
		};
		int num2 = get_koyaku_prm(2);
		int num3 = get_pkd_data(86);
		int num4 = 0;
		if (num2 < 0 || 52 <= num2 || num3 < 1 || 4 < num3 || num != 0)
		{
			return;
		}
		switch (oshi)
		{
		case 0:
			num4 = array2[num2];
			break;
		case 1:
			num4 = array4[num2];
			break;
		case 2:
			num4 = array5[num2];
			break;
		}
		switch (num4)
		{
		default:
			return;
		case 2:
			if (num3 != 1)
			{
				return;
			}
			break;
		case 3:
			if (num3 != 2)
			{
				return;
			}
			break;
		case 4:
			if (num3 != 2 && num3 != 3)
			{
				return;
			}
			break;
		}
		m_kaidoData[86] = num4;
		set_pkd_data(86, num4);
	}

	public void checkRTtenraku(int num, int oshi)
	{
		int[] array = new int[52];
		array[7] = 1;
		array[12] = 1;
		array[16] = 1;
		array[20] = 1;
		array[25] = 1;
		array[26] = 1;
		array[27] = 1;
		array[28] = 1;
		array[30] = 1;
		array[32] = 1;
		int[] array2 = array;
		int[] array3 = new int[52];
		array3[6] = 1;
		array3[10] = 1;
		array3[14] = 1;
		array3[18] = 1;
		array3[27] = 1;
		array3[28] = 1;
		array3[33] = 1;
		int[] array4 = array3;
		int[] array5 = new int[52];
		array5[9] = 1;
		array5[13] = 1;
		array5[17] = 1;
		array5[25] = 1;
		array5[26] = 1;
		array5[29] = 1;
		array5[31] = 1;
		int[] array6 = array5;
		int num2 = get_koyaku_prm(2);
		int num3 = get_pkd_data(86);
		int num4 = 0;
		if (num2 >= 0 && 52 > num2 && num3 >= 2 && 4 >= num3 && num == 0)
		{
			switch (oshi)
			{
			case 0:
				num4 = array2[num2];
				break;
			case 1:
				num4 = array4[num2];
				break;
			case 2:
				num4 = array6[num2];
				break;
			}
			if (num4 != 0)
			{
				m_kaidoData[86] = 1;
				set_pkd_data(86, 1);
			}
		}
	}

	public int getReelAction()
	{
		int num = get_pkd_data(462);
		int num2 = get_pdt_data(45);
		int num3 = get_pdt_data(15);
		int num4 = get_koyaku_prm(0);
		switch (num)
		{
		default:
			if (num3 >= 4 && 9 >= num3)
			{
				num = 0;
			}
			if ((num2 < 0 || 3 < num2) && num2 != 5 && num2 != 6 && num2 != 30)
			{
				num = 0;
			}
			if (num4 == 1)
			{
				num = 0;
			}
			return num;
		}
	}

	public int getBnsSyoukaku()
	{
		int result = 0;
		if (get_pkd_data(570) == 1)
		{
			result = get_pkd_data(458);
		}
		return result;
	}

	public int M_DraIn_DRIN_PROD()
	{
		int num = 0;
		switch (get_koyaku_prm(2))
		{
		case 21:
		case 22:
		case 23:
		case 24:
		case 34:
		case 35:
		case 37:
		case 38:
		case 39:
		case 40:
		case 46:
		case 47:
		case 48:
		case 49:
			return 1;
		case 6:
		case 7:
			return 2;
		default:
			return 0;
		}
	}

	public void M_DraIn_DRIN_RP_First()
	{
		m_kaidoData[586] = M_AddChk(m_kaidoData[586], 10);
		m_kaidoData[587] = m_kaidoData[586];
		m_kaidoData[490] = M_AddChk(m_kaidoData[490], 10);
		m_kaidoData[209] = M_AddChk(m_kaidoData[209], 10);
		set_pkd_data(586, m_kaidoData[586]);
		set_pkd_data(587, m_kaidoData[587]);
		set_pkd_data(490, m_kaidoData[490]);
		set_pkd_data(209, m_kaidoData[209]);
	}

	public void M_DraIn_DRIN_RP_Wait()
	{
		int[][] array = new int[2][]
		{
			new int[7] { 22937, 8192, 819, 819, 1, 0, 0 },
			new int[7] { 4915, 6553, 1638, 1638, 16384, 820, 820 }
		};
		int num = 0;
		int num2 = get_pkd_data(219);
		int num3 = (int)Random.Range(0f, 32768f);
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		if (num2 == 0)
		{
			if ((float)num3 < 16384f)
			{
				num = 1;
			}
		}
		else if ((float)num3 < 24576f)
		{
			num = 1;
		}
		if (num == 1 && (int)Random.Range(0f, 5f) == 1)
		{
			num = 2;
		}
		m_di0gFlag = num;
		m_kaidoData[584] = get_pkd_data(586);
		set_pkd_data(584, get_pkd_data(586));
		DirectionPanelLED.runMac2App(1, 0);
		num3 = (int)Random.Range(0f, 32768f);
		if (m_di0gFlag != 0)
		{
			num4 = 1;
		}
		for (num5 = 0; num5 < 7; num5++)
		{
			num7 += array[num4][num5];
			if (num3 < num7)
			{
				num6 = num5;
				break;
			}
		}
		DirectionPanelLED.runMac2App(num6 + 1, 8);
	}

	private void M_LotAct_OPB_3ON()
	{
		long num = ulDedamaLotStateOld;
		long num2 = ulDedamaLotState;
		if (get_pdt_data(46) == 20)
		{
			return;
		}
		if ((num & 0xC) != 0L)
		{
			if (get_pkd_data(54) == 1)
			{
				set_pkd_data(455, 5);
				set_pdt_data(46, 11);
				return;
			}
			if (1 <= get_pkd_data(566) && get_pkd_data(566) <= 11)
			{
				set_pkd_data(442, get_pkd_data(443));
			}
			if ((num2 & 0xC) == 0L)
			{
				if (get_pkd_data(335) == 3)
				{
					set_pdt_data(46, 16);
				}
				else
				{
					set_pdt_data(46, 15);
				}
				set_pkd_data(455, 3);
				if (get_pkd_data(449) > 0)
				{
					set_pkd_data(551, 5);
					set_pkd_data(552, 3);
				}
				else
				{
					set_pkd_data(551, 0);
				}
			}
			return;
		}
		if (get_pkd_data(54) == 1)
		{
			set_pkd_data(455, 5);
			set_pdt_data(46, 11);
		}
		else if ((num2 & 1) == 0L)
		{
			if ((ulDedamaLotState & 0x40) != 0L)
			{
				set_pkd_data(455, 5);
				set_pdt_data(46, 11);
			}
			else
			{
				set_pkd_data(455, 6);
				set_pkd_data(558, 0);
				set_pkd_data(591, 0);
				set_pdt_data(46, 4);
				set_pdt_data(30, 7);
			}
		}
		else if ((num2 & num & 0x80000000u) == 0L)
		{
			if (5 <= get_pkd_data(551) && get_pkd_data(551) <= 7)
			{
				if (get_pkd_data(53) == 6 || get_pkd_data(53) == 7 || get_pkd_data(53) == 21 || get_pkd_data(53) == 22)
				{
					if ((get_pkd_data(59) & 0x40) != 0)
					{
						int prm = get_pkd_data(490) + get_pkd_data(208);
						set_pkd_data(490, prm);
						if (get_pkd_data(490) > 32767)
						{
							set_pkd_data(490, 32767);
						}
						set_pkd_data(208, 0);
					}
					else
					{
						int prm2 = get_pkd_data(485) + get_pkd_data(208);
						set_pkd_data(485, prm2);
						if (get_pkd_data(485) > 32767)
						{
							set_pkd_data(485, 32767);
						}
						set_pkd_data(208, 0);
					}
					set_pkd_data(552, 0);
					if (get_pkd_data(449) > 0)
					{
						set_pkd_data(551, 5);
						set_pkd_data(552, 3);
					}
					else
					{
						set_pkd_data(551, 0);
					}
				}
				else if (get_pkd_data(551) != 7)
				{
					if (get_pkd_data(53) == 1 && get_pkd_data(551) == 5)
					{
						set_pkd_data(552, 0);
					}
					if (get_pkd_data(552) == 0)
					{
						set_pkd_data(551, 7);
					}
				}
			}
			else if (2 <= get_pkd_data(551) && get_pkd_data(551) <= 4)
			{
				if (get_pkd_data(53) == 1 && get_pkd_data(551) == 2)
				{
					set_pkd_data(552, 0);
				}
				if (get_pkd_data(552) == 0)
				{
					set_pkd_data(551, 0);
				}
			}
		}
		if ((num2 & 0x80000000u) == 0L && (num2 & 4) != 0L)
		{
			set_pkd_data(552, 0);
			set_pkd_data(551, 0);
			set_pkd_data(566, 0);
			set_pkd_data(455, 4);
		}
	}

	private int M_AddChk(int data1, int data2)
	{
		int num = data1 + data2;
		if (num > 32767)
		{
			num = 32767;
		}
		return num;
	}

	public int getDI0GLoop()
	{
		return m_di0gFlag;
	}

	public void all_clr()
	{
		SGLG_PlugIn.all_clr();
	}

	public void startLot_LeverOn()
	{
		init_cmd();
		if ((ulDedamaLotState & 0x10000) != 0L)
		{
			artGameCnt = get_pkd_data(493);
			if (artGameMax < artGameCnt)
			{
				artGameMax = artGameCnt;
			}
		}
		else
		{
			artGameCnt = 0;
		}
		m_lev_to_3off_rtmode = get_pkd_data(87);
		int num = get_pkd_data(84);
		SGLG_PlugIn.startLot_LeverOn_yaku();
		if (num != get_pkd_data(84))
		{
			set_pkd_data(84, num);
		}
		koyakuSetCmd();
		debugSetCmd();
		if (get_koyaku_prm(0) == 1 && get_koyaku_prm(2) >= 35)
		{
			set_koyaku_prm(1, 0);
			set_koyaku_prm(2, 0);
			set_main_cmd(6, 0);
		}
		startLot_reelStep();
		startLot_bnsSyoukaku();
		switch (get_main_cmd(6))
		{
		case 8:
			set_pkd_data(462, 0);
			m_kaidoData[462] = 0;
			break;
		case 31:
			set_main_cmd(6, 30);
			set_koyaku_prm(2, 30);
			break;
		case 32:
			set_main_cmd(6, 33);
			set_koyaku_prm(2, 33);
			break;
		}
		anoBtlSet();
		destroyKyousei(0);
		pbLotZugara();
		if (checkGijiren())
		{
			m_kaidoData[564]--;
			set_pkd_data(564, m_kaidoData[564]);
		}
		if (isGijiren())
		{
			m_oldGijiNum++;
		}
		else
		{
			m_oldGijiNum = 0;
		}
		SGLG_PlugIn.startLot_LeverOn_prod();
		destroyKyousei(1);
		startLot_destroy();
		if (get_koyaku_prm(1) == 2)
		{
			set_pkd_data(84, 2);
		}
		m_ucFLMainCmdOk = get_pkd_data(6);
		if (get_main_cmd(7) == 1 && get_pkd_data(458) == 1)
		{
			int num2 = get_pdt_data(1);
			if (num2 != 70)
			{
				set_pdt_data(1, 70);
				set_pdt_data(5, 1);
			}
			set_pdt_data(15, 0);
		}
		int num3 = get_pdt_data(1);
		int num4 = get_pdt_data(5);
		if ((ulDedamaLotState & 0x400) != 0L)
		{
			if (get_pkd_data(103) == 1 && get_pkd_data(99) / 10 < get_pkd_data(100))
			{
				set_pkd_data(100, get_pkd_data(99) / 10);
			}
			if ((num3 == 7 || num3 == 49 || num3 == 50 || num3 == 51 || num3 == 52) && get_pkd_data(91) == 0 && num4 == 2)
			{
				set_pdt_data(5, 1);
				m_dirData[5] = 1;
			}
		}
		if (num3 == 47 && (num4 == 49 || num4 == 53 || num4 == 57) && m_CntARTGameLastADD == 0)
		{
			set_pdt_data(1, 0);
			set_pdt_data(5, 0);
		}
		int num5 = 0;
		if (m_CntARTGameLastADD != 0 && get_pkd_data(487) == 0)
		{
			num5 = m_CntARTGameLastADD;
		}
		artDispCnt = get_pkd_data(490) - get_pkd_data(488) - num5;
		if ((ulDedamaLotState & 0x80000) != 0L)
		{
			artDispCnt = artDispCntDI;
		}
		int num6 = m_kaidoData[86];
		int num7 = m_dirData[45];
		getPluginPrm();
		int num8 = m_kaidoData[86];
		int num9 = m_dirData[45];
		int num10 = m_kaidoData[438];
		int num11 = m_kaidoData[439];
		long num12 = ulDedamaLotState;
		long num13 = ulDedamaLotStateOld;
		int num14 = m_kaidoData[54];
		int num15 = m_kaidoData[333];
		int num16 = m_kaidoData[334];
		if ((num12 & 1) != 0L && num10 == num11)
		{
			m_bonusTouroku = 1;
			m_kaidoData[86] = 3;
			m_kaidoData[87] = 3;
		}
		if (num9 == 11 && num8 == 3 && get_koyaku_prm(2) >= 21 && 28 >= get_koyaku_prm(2))
		{
			m_kaidoData[86] = 2;
			m_kaidoData[87] = 2;
		}
		if (((num12 & 1) != 0L || (num9 >= 13 && 16 >= num9) || num9 == 19 || num9 == 11) && m_kaidoData[86] == 4)
		{
			if (num9 == 11)
			{
				m_kaidoData[86] = num6;
				m_kaidoData[87] = num6;
			}
			else
			{
				m_kaidoData[86] = 3;
				m_kaidoData[87] = 3;
			}
		}
		if ((get_koyaku_prm(1) == 2 || m_koyakuState == 1) && num8 != num6)
		{
			m_kaidoData[86] = num6;
			m_kaidoData[87] = num6;
		}
		if (num9 != 11 && num9 != 4 && (num12 & 1) == 0L && (num12 & 0x10000) == 0L && num8 == 2)
		{
			if (num6 == 2)
			{
				m_kaidoData[86] = 1;
				m_kaidoData[87] = 1;
			}
			else
			{
				m_kaidoData[86] = num6;
				m_kaidoData[87] = num6;
			}
		}
		if ((ulDedamaLotState & 1) == 0L && (ulDedamaLotState & 0x40) == 0L)
		{
			bnsAutoState = 0;
		}
		if ((ulDedamaLotState & 0x10000) == 0L && (ulDedamaLotState & 0x20000) == 0L && (ulDedamaLotState & 0x200000) == 0L)
		{
			artAutoState = 0;
		}
		int num17 = get_pdt_data(45);
		int num18 = get_pdt_data(49);
		if (num17 == 11 && (num18 == 23 || num18 == 20))
		{
			m_dirData[1] = 38;
			m_dirData[5] = 1;
		}
		switch (num9)
		{
		case 4:
		case 5:
		case 6:
		case 30:
			Direction23AST.restartBGM();
			break;
		case 0:
		case 1:
		case 2:
			if (num3 == 56)
			{
				m_dirData[1] = 4;
				m_dirData[5] = 1;
				switch (num4)
				{
				case 1:
				case 2:
					m_dirData[5] = 1;
					break;
				case 3:
				case 10:
					m_dirData[5] = 7;
					break;
				case 4:
				case 11:
					m_dirData[5] = 8;
					break;
				case 5:
				case 12:
					m_dirData[5] = 9;
					break;
				case 6:
				case 13:
					m_dirData[5] = 10;
					break;
				case 7:
				case 14:
					m_dirData[5] = 11;
					break;
				case 8:
				case 15:
					m_dirData[5] = 15;
					break;
				case 9:
				case 16:
					m_dirData[5] = 16;
					break;
				}
			}
			break;
		}
		yuugiSound(0);
		setPluginPrm();
		if (num15 != 0 && num16 == 0)
		{
			tousenYaku = get_koyaku_prm(2);
		}
		if (num17 == 20 && m_kaidoData[86] < 5)
		{
			if ((ulDedamaLotState & 0x80000000u) != 0L)
			{
				ulDedamaLotState &= -2147483649L;
			}
			if ((ulDedamaLotState & 0x4000000) != 0L)
			{
				ulDedamaLotState &= -67108865L;
			}
			m_kaidoData[86] = 6;
			setPluginPrm();
		}
		if ((m_lev_to_3off_rtmode == 3 || m_lev_to_3off_rtmode == 4) && get_pkd_data(87) == 1)
		{
			m_kaidoData[87] = m_lev_to_3off_rtmode;
			set_pkd_data(87, m_lev_to_3off_rtmode);
		}
		if ((m_dirData[45] == 15 || m_dirData[45] == 16) && m_dirData[49] == 18)
		{
			MainGameScene.dirMan.EventStageChanged(72, 0, 1);
			MainGameScene.slotMan.dirManStopDirection();
		}
		if (getBnsSyoukaku() == 0)
		{
			lmpMainCmd();
		}
		testlotlog(-1);
	}

	public void startLot_ReelStart()
	{
		if (getBnsSyoukaku() != 0)
		{
			lmpMainCmd();
		}
		init_cmd();
		SGLG_PlugIn.startLot_ReelStart();
		getPluginPrm();
		yuugiSound(1);
		setPluginPrm();
		if (get_pkd_data(570) != 0 && m_bonusTouroku != 2)
		{
			int num = gameCount;
			int tousen = 0;
			if (num != 0)
			{
				switch (m_kaidoData[335])
				{
				case 0:
					tousen = 0;
					break;
				case 1:
					tousen = 1;
					break;
				case 2:
					tousen = 2;
					break;
				case 3:
					tousen = 3;
					break;
				case 4:
					tousen = 0;
					break;
				}
				setHistory(tousenYaku);
				setHistory(num, tousen);
				tousenYaku = 0;
			}
			m_oldBnsKind = 0;
			m_bonusTouroku = 2;
		}
		lmpMainCmd();
		testlotlog(-2);
	}

	public void startLot_Reel1(int _num)
	{
		if (!MainGameScene.restartFlag)
		{
			setDemeReel();
		}
		int num = 0;
		if ((m_kaidoData[53] == 6 || m_kaidoData[53] == 7) && m_dirData[1] == 55 && MainGameScene.slotMan.m_State == SlotBodyManager.STATE.REEL_STOP3 && m_kaidoData[64] == 3 && m_kaidoData[67] == 15 && m_kaidoData[70] == 6)
		{
			num = m_kaidoData[53];
			m_kaidoData[53] = 0;
			set_pkd_data(53, m_kaidoData[53]);
		}
		int num2 = 0;
		if (m_kaidoData[53] == 35 && (m_kaidoData[64] == 2 || m_kaidoData[64] == 11))
		{
			num2 = 1;
		}
		init_cmd();
		SGLG_PlugIn.startLot_Reel1();
		getPluginPrm();
		if (num != 0)
		{
			m_kaidoData[53] = num;
			set_pkd_data(53, num);
		}
		if (num2 != 0)
		{
			MainGameScene.dirMan.chuChe1stStop();
			m_dirData[92] = 91;
			set_pdt_data(92, 91);
		}
		if (get_pdt_data(45) >= 15 && 18 >= get_pdt_data(45) && get_pdt_data(1) != 0 && get_pdt_data(5) == 0)
		{
			set_pdt_data(1, 0);
			init_cmd();
			getPluginPrm();
		}
		tokuNaviProd(0, _num);
		setPluginPrm();
		lmpMainCmd();
		testlotlog(-3);
	}

	public void startLot_Reel2(int _num)
	{
		if (!MainGameScene.restartFlag)
		{
			setDemeReel();
		}
		init_cmd();
		SGLG_PlugIn.startLot_Reel2();
		getPluginPrm();
		if (get_pdt_data(45) >= 15 && 18 >= get_pdt_data(45) && get_pdt_data(1) != 0 && get_pdt_data(5) == 0)
		{
			set_pdt_data(1, 0);
			init_cmd();
			getPluginPrm();
		}
		tokuNaviProd(1, _num);
		setPluginPrm();
		lmpMainCmd();
		testlotlog(-4);
	}

	public void startLot_Reel3(int _num)
	{
		if (!MainGameScene.restartFlag)
		{
			setDemeReel();
		}
		init_cmd();
		SGLG_PlugIn.startLot_Reel3();
		getPluginPrm();
		if (get_pdt_data(45) >= 15 && 18 >= get_pdt_data(45) && get_pdt_data(1) != 0 && get_pdt_data(5) == 0)
		{
			set_pdt_data(1, 0);
			init_cmd();
			getPluginPrm();
		}
		tokuNaviProd(2, _num);
		setPluginPrm();
		lmpMainCmd();
		testlotlog(-5);
	}

	public void startLot_Reel3off()
	{
		bool flag = false;
		getPluginPrm();
		if (!MainGameScene.restartFlag)
		{
			initDeme();
			for (int i = 0; i < 7; i++)
			{
				setDeme(i);
			}
			setDemeReel();
		}
		if (m_kaidoData[86] == 5 && m_kaidoData[62] == 128)
		{
			m_kaidoData[86] = 6;
			m_kaidoData[87] = 6;
			if (pbLastMedal == 0)
			{
				setHistory(tousenYaku);
				setHistory(gameCount, 0);
				tousenYaku = 0;
				pbLastMedal = 337;
				m_kaidoData[574] = pbLastMedal;
				m_bonusTouroku = 2;
			}
			MainGameScene.slotMan.dirManStopDirection(DirectionManager.DIR.REEL_2);
			flag = true;
		}
		if (!MainGameScene.restartFlag)
		{
			payout();
		}
		if (get_koyaku_prm(1) == 2)
		{
			m_kaidoData[84] = 2;
			m_koyakuState = 1;
		}
		yuugiSound(5);
		setPluginPrm();
		init_cmd();
		SGLG_PlugIn.startLot_Reel3off();
		if (MainGameScene.restartFlag)
		{
			if (m_payoutMedal == 14)
			{
				m_kaidoData[84] = 0;
				set_pkd_data(84, 0);
				m_koyakuState = 0;
			}
			if (get_pdt_data(1) == 72)
			{
				int num = get_pdt_data(5);
				int num2 = m_dirData[5];
				if (num != num2)
				{
					set_pdt_data(5, num2);
				}
			}
			if (get_pdt_data(45) == 9)
			{
				int num3 = get_pkd_data(586);
				int num4 = get_pkd_data(587);
				int num5 = m_kaidoData[586];
				int num6 = m_kaidoData[587];
				if (num3 != num5)
				{
					set_pkd_data(586, num5);
				}
				if (num4 != num6)
				{
					set_pkd_data(587, num6);
				}
			}
		}
		getPluginPrm();
		int num7 = MainGameScene.slotGameMan.get_pdt_data(45);
		int num8 = MainGameScene.slotGameMan.get_pdt_data(46);
		int num9 = MainGameScene.slotGameMan.get_pdt_data(47);
		int num10 = MainGameScene.slotGameMan.get_pdt_data(48);
		int num11 = MainGameScene.slotGameMan.get_pdt_data(49);
		if ((ulDedamaLotState & 0x80000000u) != 0L)
		{
			if (get_pkd_data(50) > 0)
			{
				m_kaidoData[50] = 0;
				set_pkd_data(50, 0);
				ulDedamaLotState &= -2147483649L;
				set_pkd_data(0, (int)ulDedamaLotState);
			}
			if ((num7 == 28 || num7 == 29) && num8 == 11)
			{
				ulDedamaLotState &= -2147483649L;
				set_pkd_data(0, (int)ulDedamaLotState);
			}
		}
		if (get_pdt_data(45) >= 15 && 18 >= get_pdt_data(45))
		{
			M_LotAct_OPB_3ON();
			startLot_Prod();
			if (get_pdt_data(1) != 0 && get_pdt_data(5) == 0)
			{
				set_pdt_data(1, 0);
				init_cmd();
			}
			getPluginPrm();
		}
		if (num7 == 4 && num8 == 5)
		{
			setHistory(0);
			setHistory(gameCount, 4);
			tousenYaku = 0;
			gameCount = 0;
		}
		if (m_bonusTouroku == 1)
		{
			m_oldBnsKind = m_kaidoData[335];
		}
		switch (MainGameScene.m_PlaySaveData.m_autoSettei)
		{
		case 0:
			if ((ulDedamaLotState & 0x40) != 0L || flag)
			{
				if (bnsAutoState == 0)
				{
					MainGameScene.m_PlaySaveData.setAuto(4);
				}
				bnsAutoState = 1;
			}
			break;
		case 1:
			if ((ulDedamaLotState & 0x20000) != 0L && (ulDedamaLotState & 1) == 0L)
			{
				if (artAutoState == 0)
				{
					MainGameScene.m_PlaySaveData.setAuto(4);
				}
				artAutoState = 1;
			}
			break;
		case 2:
			if ((get_pdt_data(45) == 7 || get_pdt_data(45) == 8) && get_pdt_data(46) >= 0 && 2 >= get_pdt_data(46))
			{
				MainGameScene.m_PlaySaveData.setAuto(4);
			}
			break;
		case 3:
			if ((ulDedamaLotState & 0x40) != 0L || flag)
			{
				if (bnsAutoState == 0)
				{
					MainGameScene.m_PlaySaveData.setAuto(4);
				}
				bnsAutoState = 1;
			}
			if ((ulDedamaLotState & 0x20000) != 0L && (ulDedamaLotState & 1) == 0L)
			{
				if (artAutoState == 0)
				{
					MainGameScene.m_PlaySaveData.setAuto(4);
				}
				artAutoState = 1;
			}
			break;
		}
		if ((get_pdt_data(45) == 7 || get_pdt_data(45) == 8) && get_pdt_data(46) >= 0 && 2 >= get_pdt_data(46))
		{
			gameCountArt = 0;
		}
		if ((get_pkd_data(87) == 3 || get_pkd_data(87) == 4) && get_pkd_data(86) == 1)
		{
			gameCount = 0;
			m_kaidoData[87] = 1;
		}
		if ((ulDedamaLotState & 0x10000) != 0L && m_kaidoData[564] > 1 && m_kaidoData[564] == m_oldGijiNum + 1)
		{
			m_dirData[1] = 87;
			m_dirData[5] = 24;
			m_oldGijiNum = 0;
		}
		setPluginPrm();
		lmpMainCmd();
		lmpHOHtensionLmp();
		testlotlog(-6);
	}

	public void startLot_ReelStop(int _stopNum, int _kind)
	{
		SGLG_PlugIn.startLot_ReelStop(_stopNum, _kind);
		yuugiSound(_stopNum + 2);
		checkRTtenraku(_stopNum, _kind);
		checkRThukki(_stopNum, _kind);
	}

	public void startLot_Bet()
	{
		if ((ulDedamaLotState & 0x10) == 0L && m_kaidoData[86] == 6)
		{
			m_kaidoData[86] = 0;
			m_kaidoData[87] = 0;
			set_pkd_data(86, 0);
			set_pkd_data(87, 0);
			set_koyaku_prm(0, 0);
			gameCount = 0;
		}
		if (m_payoutMedal == 14)
		{
			m_kaidoData[84] = 0;
			set_pkd_data(84, 0);
		}
		init_cmd();
		SGLG_PlugIn.startLot_Bet();
		lmpMainCmd();
		artDispCnt = get_pkd_data(490) - get_pkd_data(488);
		if ((ulDedamaLotState & 0x80000) != 0L)
		{
			m_kaidoData[584] = get_pkd_data(586);
			set_pkd_data(584, get_pkd_data(586));
			artDispCntDI = artDispCnt - get_pkd_data(584);
			artDispCnt = artDispCntDI;
		}
		int num = MainGameScene.slotGameMan.get_pdt_data(45);
		int num2 = MainGameScene.slotGameMan.get_pdt_data(46);
		int num3 = MainGameScene.slotGameMan.get_pdt_data(47);
		int num4 = MainGameScene.slotGameMan.get_pdt_data(48);
		int num5 = MainGameScene.slotGameMan.get_pdt_data(49);
		if ((num != 11 && num != 18) || (num == 11 && (num5 == 25 || num5 == 27 || num5 == 28 || num5 == 29)))
		{
			MainGameScene.slotMan.dirManchangeStageInterface(num2);
			if (num == 11 && (num5 == 25 || num5 == 27 || num5 == 28 || num5 == 29))
			{
				set_pdt_data(89, 1);
				m_dirData[89] = 1;
				set_pdt_data(90, 0);
				m_dirData[90] = 0;
			}
		}
		if (num2 == 11 && (num == 13 || num == 14 || num == 15 || num == 16 || num == 19 || num == 21))
		{
			m_dirData[1] = 38;
			m_dirData[5] = 1;
			set_pdt_data(1, 38);
			set_pdt_data(5, 1);
			set_pkd_data(86, 2);
			set_pkd_data(87, 2);
			gameCount = 0;
		}
		if (num2 == 4 && (num == 13 || num == 14 || num == 15 || num == 16 || num == 19 || num == 21))
		{
			gameCount = 0;
		}
		m_repArtLev = 0;
		if (num2 == 4 && num != 4)
		{
			if (m_dirData[1] != 41 && m_dirData[5] != 1)
			{
				m_repArtLev = 1;
			}
			if (num == 23)
			{
				m_repArtLev = 2;
			}
		}
		m_CntARTGameLastADD = get_pkd_data(487);
		if ((ulDedamaLotState & 1) == 0L && (ulDedamaLotState & 0x40) == 0L && (ulDedamaLotState & 0x10000) == 0L && (ulDedamaLotState & 0x20000) == 0L)
		{
			artGetMedal = 0;
			m_kaidoData[577] = artGetMedal;
		}
		MainGameScene.pushMan.canselPopUp();
		if (get_pdt_data(1) == 88)
		{
			MainGameScene.yakuMan.returnJYD();
		}
		if (m_dirData[1] != 87 && m_dirData[5] != 24)
		{
			m_oldGijiNum = get_pkd_data(563);
		}
		if ((m_dirData[45] == 17 || m_dirData[45] == 18) && (m_kaidoData[444] == 0 || m_usCNTAddBTL_TOTAL_Disp != m_kaidoData[442] * 2))
		{
			m_usCNTAddBTL_TOTAL_Disp = m_kaidoData[442];
		}
		testlotlog(-7);
	}

	public void startLot_Prod()
	{
		SGLG_PlugIn.startLot_Prod();
	}

	public void startLot_Push()
	{
		if (getRomanBulletNum() > 0)
		{
			MainGameScene.slotGameMan.set_pkd_data(496, 1);
			MainGameScene.slotGameMan.startLot_Prod();
			MainGameScene.lotMan.startLot_PushRoman();
			MainGameScene.pnlMan.offCartridge(getRomanBulletNum());
			if (getRomanBulletNum() > 0)
			{
				MainGameScene.pnlMan.flashCartridge(getRomanBulletNum() - 1);
			}
			testlotlog(-97);
		}
		else if (get_pdt_data(1) == 74)
		{
			MainGameScene.lotMan.startLot_PushBZT();
			if ((get_pdt_data(5) >= 7 && 16 >= get_pdt_data(1)) || (get_pdt_data(5) >= 51 && 55 >= get_pdt_data(1)))
			{
				MainGameScene.pushMan.setCanPush(true);
			}
			m_kaidoData[637]++;
		}
		else if (get_pdt_data(1) == 88)
		{
			MainGameScene.lotMan.startLot_PushHUC();
			if (get_pdt_data(5) >= 57 && 63 >= get_pdt_data(1))
			{
				MainGameScene.pushMan.setCanPush(true);
			}
			m_kaidoData[637]++;
			m_pushRendaFrame = 5;
		}
		else if (get_pdt_data(1) == 94)
		{
			MainGameScene.lotMan.startLot_PushBTH();
			if (get_pdt_data(5) >= 269 && 274 >= get_pdt_data(5) && m_kaidoData[637] < get_pkd_data(482))
			{
				MainGameScene.pushMan.setCanPush(true);
			}
			m_kaidoData[637]++;
		}
		else if (getBJTChargeNum() > 0)
		{
			MainGameScene.lotMan.startLot_Push();
			set_pkd_data(469, 1);
			startLot_Prod();
			set_pkd_data(597, 0);
			set_pkd_data(469, 2);
			startLot_Prod();
			int num = get_pkd_data(465);
			int num2 = get_pkd_data(466);
			int num3 = get_pkd_data(467);
			int num4 = get_pkd_data(468);
			int num5 = get_pkd_data(567);
			int num6 = get_pdt_data(1);
			int num7 = get_pdt_data(5);
			lmpBJTCmd(0);
			getPluginPrm();
		}
		else
		{
			MainGameScene.lotMan.startLot_Push();
		}
		testlotlog(-10);
	}

	public int get_koyaku_prm(int prm)
	{
		int num = 0;
		switch (prm)
		{
		case 0:
			num = m_koyakuState;
			if (get_pkd_data(86) == 6 && get_pdt_data(45) == 20)
			{
				num = 2;
			}
			else if (num == 2 || (get_pkd_data(86) == 6 && get_pdt_data(45) == 20))
			{
				num = 1;
			}
			break;
		case 1:
			num = get_pkd_data(54);
			break;
		case 2:
			num = get_pkd_data(53);
			break;
		}
		return num;
	}

	public void set_koyaku_prm(int id, int prm)
	{
		SGLG_PlugIn.set_koyaku_prm(id, prm);
	}

	public void set_main_cmd(int id, int prm)
	{
		SGLG_PlugIn.set_main_cmd(id, prm);
	}

	public int get_main_cmd(int id)
	{
		return SGLG_PlugIn.get_main_cmd(id);
	}

	public char get_dir_cmd(int trg, int ptn)
	{
		return SGLG_PlugIn.get_dir_cmd(trg, ptn);
	}

	public char get_dir_cmd2(int trg, int ptn, int _usGrp, int _usDir)
	{
		return SGLG_PlugIn.get_dir_cmd2(trg, ptn, _usGrp, _usDir);
	}

	public int get_dir_data(int prm)
	{
		return SGLG_PlugIn.get_dir_data(prm);
	}

	public int get_pdt_data(int prm)
	{
		return SGLG_PlugIn.get_pdt_data(prm);
	}

	public int set_pdt_data(int id, int prm)
	{
		return SGLG_PlugIn.set_pdt_data(id, prm);
	}

	public int get_pkd_data(int prm)
	{
		return SGLG_PlugIn.get_pkd_data(prm);
	}

	public int set_pkd_data(int id, int prm)
	{
		return SGLG_PlugIn.set_pkd_data(id, prm);
	}

	public long get_pkd_data_long(int prm)
	{
		return SGLG_PlugIn.get_pkd_data_long(prm);
	}

	public int set_pkd_data_long(int id, long prm)
	{
		return SGLG_PlugIn.set_pkd_data_long(id, prm);
	}

	public void init_cmd()
	{
		for (int i = 0; i < 1024; i++)
		{
			set_SubCmdBuf(i, 0);
		}
		SGLG_PlugIn.init_cmd();
	}

	public char get_cmd(int _ptn, int _lay, int _num)
	{
		return SGLG_PlugIn.get_cmd(_ptn, _lay, _num);
	}

	public int get_pri_data(int prm)
	{
		return SGLG_PlugIn.get_pri_data(prm);
	}

	public int set_pri_data(int id, int prm)
	{
		return SGLG_PlugIn.set_pri_data(id, prm);
	}

	public short get_pgm_data(int _id)
	{
		return SGLG_PlugIn.get_pgm_data(_id);
	}

	public short set_pgm_data(int _id, int _prm)
	{
		return SGLG_PlugIn.set_pgm_data(_id, _prm);
	}

	public short get_SubCmdBuf(int _num)
	{
		return SGLG_PlugIn.get_SubCmdBuf(_num);
	}

	public short set_SubCmdBuf(int _num, int _prm)
	{
		return SGLG_PlugIn.set_SubCmdBuf(_num, _prm);
	}

	public void startLot_reelStep()
	{
		SGLG_PlugIn.test();
	}

	public void startLot_destroy()
	{
		int num = get_pdt_data(45);
		int num2 = get_koyaku_prm(2);
		int num3 = get_pkd_data(330);
		int num4 = 0;
		if ((num == 15 || num == 16) && (num2 == 6 || num2 == 7) && num3 != 0)
		{
			num4 = (int)Random.Range(0f, 65536f);
			if ((float)num4 < 2048f)
			{
				set_pkd_data(606, 1);
				m_kaidoData[606] = 1;
			}
		}
	}

	public void startLot_bnsSyoukaku()
	{
		int num = SGLG_PlugIn.lotKoyaku(-1);
		int num2 = 0;
		switch (num)
		{
		case 0:
			num2 = 0;
			break;
		case 3:
			num2 = 55;
			break;
		case 5:
			num2 = 59;
			break;
		case 8:
			num2 = 64;
			break;
		}
		if (m_kaidoData[335] == 2 && num2 == 59)
		{
			num2 = 0;
		}
		if ((ulDedamaLotState & 1) != 0L && get_main_cmd(7) != 1)
		{
			SGLG_PlugIn.lotKoyaku(num2);
		}
	}

	public void yuugiSound(int kind)
	{
		if (MainGameScene.restartFlag)
		{
			return;
		}
		int num = get_koyaku_prm(2);
		int num2 = get_pdt_data(45);
		int num3 = 0;
		switch (kind)
		{
		case 0:
			if (get_pkd_data(86) != 5 && get_pdt_data(45) >= 0 && 2 >= get_pdt_data(45))
			{
				num3 = 16;
				MainGameScene.sndPlay(0, num3, false, 1f);
			}
			break;
		case 1:
			MainGameScene.sndStop(0);
			num3 = 17;
			MainGameScene.sndPlay(0, num3, false, 1f);
			break;
		case 2:
		case 3:
		case 4:
			num3 = 20;
			if (kind == 2 && get_pkd_data(83) == 0 && (get_pkd_data(86) == 0 || get_pkd_data(86) == 1) && get_pdt_data(45) >= 0 && 3 >= get_pdt_data(45))
			{
				num3 = 9;
			}
			MainGameScene.sndPlay(0, num3, false, 1f);
			break;
		case 5:
		{
			int deme = MainGameScene.slotGameMan.getDeme();
			num3 = -1;
			switch (deme)
			{
			case 10:
				num3 = 21;
				break;
			case 3:
				num3 = 64;
				break;
			case 5:
				num3 = 22;
				break;
			case 4:
				num3 = 24;
				break;
			case 2:
				num3 = 25;
				break;
			case 1:
				num3 = 26;
				break;
			case 6:
				num3 = 27;
				break;
			case 7:
				num3 = 37;
				break;
			case 8:
				num3 = 37;
				break;
			case 11:
				num3 = 42;
				break;
			case 9:
				num3 = 10;
				break;
			}
			if (num >= 47 && 49 >= num)
			{
				num3 = ((num != 47) ? 12 : 11);
			}
			if (num3 == 42)
			{
				switch (num2)
				{
				default:
					num3 = -1;
					break;
				case 5:
				case 6:
				case 9:
				case 13:
				case 14:
				case 15:
				case 16:
				case 19:
				case 30:
					break;
				}
			}
			switch (num3)
			{
			case 22:
				switch (num2)
				{
				case 5:
				case 6:
				case 9:
				case 26:
				case 27:
				case 28:
				case 29:
				case 30:
					num3 = 39;
					break;
				case 4:
				case 13:
				case 14:
				case 15:
				case 16:
				case 19:
				case 20:
					num3 = 38;
					break;
				default:
					num3 = 22;
					break;
				}
				if (num == 38)
				{
					num3 = 23;
				}
				break;
			case 37:
				switch (num2)
				{
				case 26:
				case 27:
				case 28:
				case 29:
					num3 = 39;
					break;
				case 20:
					num3 = 38;
					break;
				default:
					num3 = 22;
					break;
				case 5:
				case 6:
				case 9:
				case 13:
				case 14:
				case 15:
				case 16:
				case 19:
				case 30:
					break;
				}
				break;
			}
			if (num3 != -1)
			{
				MainGameScene.sndPlay(0, num3, false, 1f);
			}
			break;
		}
		case 6:
			if (MainGameScene.slotGameMan.get_koyaku_prm(0) != 1)
			{
			}
			break;
		}
	}

	public void koyakuSetCmd()
	{
		int[] array = new int[53]
		{
			0, 35, 36, 37, 38, 39, 40, 41, 42, 43,
			44, 45, 46, 47, 48, 49, 0, 0, 0, 1,
			2, 3, 4, 5, 6, 7, 8, 9, 10, 11,
			12, 13, 14, 15, 16, 17, 18, 19, 20, 21,
			22, 23, 24, 25, 26, 27, 28, 29, 30, 31,
			32, 33, 34
		};
		int[] array2 = new int[16]
		{
			0, 19, 23, 18, 5, 4, 12, 2, 3, 1,
			13, 15, 24, 53, 54, 16
		};
		if (SGLG.gameMode != SGLG.GAMEMODE.SIMULATION)
		{
			return;
		}
		int num = get_pdt_data(45);
		int num2 = MainGameScene.slotGameMan.get_koyaku_prm(0);
		int num3 = (m_destroyCnt = SGLGSimConfig.SelectForceFlagNo);
		SGLGSimConfig.SelectForceFlagNo = 0;
		if (num3 < 0 || 16 <= num3 || num2 == 1)
		{
			return;
		}
		int num4 = array2[num3];
		if ((num == 5 || num == 6 || num == 30) && (num4 == 24 || num4 == 25))
		{
			num4 = 26;
		}
		if (num4 != 0)
		{
			if (num4 >= 16 && 18 >= num4)
			{
				switch (num4)
				{
				case 16:
					set_main_cmd(6, 0);
					set_main_cmd(7, 1);
					set_koyaku_prm(0, 0);
					set_koyaku_prm(1, 1);
					set_koyaku_prm(2, 0);
					break;
				case 17:
					set_main_cmd(6, 0);
					set_main_cmd(7, 1);
					set_koyaku_prm(0, 0);
					set_koyaku_prm(1, 1);
					set_koyaku_prm(2, 35);
					break;
				case 18:
					set_main_cmd(6, 0);
					set_main_cmd(7, 2);
					set_koyaku_prm(0, 0);
					set_koyaku_prm(1, 2);
					set_koyaku_prm(2, 0);
					break;
				}
			}
			else if (num4 <= 55 && 53 <= num4)
			{
				ulDedamaLotState |= 67108864L;
				ulDedamaLotState |= 32L;
				if (num == 4 || num == 5 || num == 6 || num == 30)
				{
					ulDedamaLotState &= -33L;
				}
				m_kaidoData[333] = 1;
				switch (num4)
				{
				case 53:
					m_kaidoData[338] = 1;
					m_kaidoData[337] = 1;
					break;
				case 54:
					m_kaidoData[338] = 2;
					m_kaidoData[337] = 1;
					break;
				case 55:
					m_kaidoData[338] = 3;
					m_kaidoData[337] = 1;
					break;
				}
				set_pkd_data(333, m_kaidoData[333]);
				set_pkd_data(338, m_kaidoData[338]);
				set_pkd_data(337, m_kaidoData[337]);
				set_pkd_data(0, (int)ulDedamaLotState);
			}
			else if (num4 == 56)
			{
				m_kaidoData[76] = 998;
				setPluginPrm();
			}
			else if (num4 == 57)
			{
				m_kaidoData[107] = 1;
				m_kaidoData[106]++;
				ulDedamaLotState |= 1024L;
				m_kaidoData[88] = 6;
				if (m_kaidoData[88] > get_pkd_data(209))
				{
					m_kaidoData[88] = get_pkd_data(209);
				}
				setPluginPrm();
			}
			else if (num4 == 58)
			{
				m_kaidoData[80] = 2;
				setPluginPrm();
			}
			else if (num4 < 52 && 0 <= num4)
			{
				set_main_cmd(7, 0);
				set_koyaku_prm(1, 0);
				set_main_cmd(6, array[num4]);
				set_koyaku_prm(2, array[num4]);
			}
		}
		SGLGSimConfig.SelectForceFlagNo = 0;
	}

	public void destroyKyousei(int _step)
	{
		int num = 0;
		int destroyCnt = m_destroyCnt;
		int[] array = new int[16]
		{
			0, 19, 23, 18, 5, 4, 12, 2, 3, 1,
			13, 15, 24, 53, 54, 16
		};
		if (destroyCnt < 0 || 15 <= destroyCnt)
		{
			return;
		}
		num = array[destroyCnt];
		int num2 = get_pdt_data(45);
		if (num != 24 && num != 25)
		{
			return;
		}
		if (num2 == 15 || num2 == 16)
		{
			int num3 = get_pkd_data(551);
			if (5 <= num3 && 7 <= num3)
			{
				return;
			}
		}
		switch (_step)
		{
		case 0:
			switch (num2)
			{
			case 15:
			case 16:
				set_pkd_data(551, 6);
				m_kaidoData[551] = 6;
				break;
			}
			break;
		case 1:
			switch (num2)
			{
			case 15:
			case 16:
			{
				int num9 = destroyLotUwanose();
				int num10 = destroyProdUwanose(num9);
				switch (num9)
				{
				case 30:
					set_pkd_data(330, 3);
					m_kaidoData[330] = 3;
					break;
				case 50:
					set_pkd_data(330, 4);
					m_kaidoData[330] = 4;
					break;
				case 100:
					set_pkd_data(330, 5);
					m_kaidoData[330] = 5;
					break;
				case 200:
					set_pkd_data(330, 7);
					m_kaidoData[330] = 7;
					break;
				case 300:
					set_pkd_data(330, 8);
					m_kaidoData[330] = 8;
					break;
				}
				set_pkd_data(208, num9);
				m_kaidoData[208] = num9;
				int num11 = get_pkd_data(209);
				num11 += num9;
				if (num11 > 32767)
				{
					num11 = 32767;
				}
				m_kaidoData[209] = num11;
				set_pkd_data(209, m_kaidoData[209]);
				set_pdt_data(5, num10);
				m_dirData[5] = num10;
				break;
			}
			case 13:
			case 14:
			{
				if (get_pkd_data(465) != 0)
				{
					break;
				}
				int num12 = get_pkd_data(567);
				int num13 = get_pkd_data(466);
				int num14 = 6;
				bool flag = false;
				if (num12 > 4)
				{
					set_pdt_data(1, 55);
					m_dirData[1] = 55;
					set_pdt_data(5, 34);
					m_dirData[5] = 34;
					set_pdt_data(16, 0);
					m_dirData[16] = 0;
					set_pdt_data(88, 0);
					m_dirData[88] = 0;
					set_pri_data(2, 0);
				}
				else
				{
					num14 = 1;
					if (num12 <= 2)
					{
						flag = true;
					}
				}
				if (num13 < 6 && !flag)
				{
					set_pkd_data(466, num13 + 1);
					m_kaidoData[466] = num13 + 1;
					set_pkd_data(470 + num13, num14);
					m_kaidoData[470] = num14;
				}
				set_pkd_data(465, 1);
				m_kaidoData[465] = 1;
				if ((ulDedamaLotState & 2) == 0L)
				{
					if (!flag)
					{
						set_pkd_data(476 + num13, 1);
						m_kaidoData[476] = 1;
					}
					if (num12 == 1)
					{
						ulDedamaLotState |= 131072L;
						ulDedamaLotStateOld |= 131072L;
						ulDedamaLotState &= -2L;
						ulDedamaLotStateOld &= -2L;
						set_pdt_data(5, 312);
						m_dirData[5] = 312;
					}
					else
					{
						ulDedamaLotState |= 2L;
						ulDedamaLotStateOld |= 2L;
					}
					set_pkd_data(0, (int)ulDedamaLotState);
					set_pkd_data(1, (int)ulDedamaLotStateOld);
					int num15 = get_pkd_data(229);
					set_pkd_data(230 + num15, 1);
					m_kaidoData[230 + num15] = 1;
					num15++;
					set_pkd_data(229, num15);
					m_kaidoData[229] = num15;
					break;
				}
				int num16 = destroyLotUwanose();
				switch (num16)
				{
				case 30:
					set_pkd_data(330, 3);
					m_kaidoData[330] = 3;
					break;
				case 50:
					set_pkd_data(330, 4);
					m_kaidoData[330] = 4;
					break;
				case 100:
					set_pkd_data(330, 5);
					m_kaidoData[330] = 5;
					break;
				case 200:
					set_pkd_data(330, 7);
					m_kaidoData[330] = 7;
					break;
				case 300:
					set_pkd_data(330, 8);
					m_kaidoData[330] = 8;
					break;
				}
				if (num13 == 6 || flag)
				{
					int num17 = get_pkd_data(487);
					num17 += num16;
					if (num17 > 32767)
					{
						num17 = 32767;
					}
					set_pkd_data(487, num17);
					m_kaidoData[487] = num17;
				}
				else
				{
					set_pkd_data(476 + num13, 4);
					m_kaidoData[476] = 4;
					set_pkd_data(208, 4);
					m_kaidoData[208] = 4;
					int num18 = get_pkd_data(483);
					num18 += num16;
					if (num18 > 32767)
					{
						num18 = 32767;
					}
					set_pkd_data(483, num18);
					m_kaidoData[483] = num18;
				}
				int num19 = get_pkd_data(209);
				num19 += num16;
				if (num19 > 32767)
				{
					num19 = 32767;
				}
				set_pkd_data(209, num19);
				m_kaidoData[209] = num19;
				break;
			}
			case 25:
			case 27:
			case 28:
			{
				if (num2 == 28)
				{
					set_pdt_data(5, 229);
					m_dirData[5] = 229;
				}
				else
				{
					set_pdt_data(5, 227);
					m_dirData[5] = 227;
				}
				set_pkd_data(103, 1);
				m_kaidoData[103] = 1;
				int num4 = get_pkd_data(99);
				int num5 = num4 / 10;
				set_pkd_data(100, num5);
				m_kaidoData[100] = num5;
				set_pkd_data(97, 0);
				m_kaidoData[97] = 0;
				int num6 = get_pkd_data(337);
				set_pkd_data(338 + num6, 2);
				num6++;
				set_pkd_data(337, num6);
				if (num2 != 28)
				{
					if (num2 == 25)
					{
						ulDedamaLotState |= 32L;
					}
					ulDedamaLotState |= 64L;
					ulDedamaLotState &= -2049L;
					ulDedamaLotState &= -1025L;
					ulDedamaLotState &= -1073741825L;
					set_pdt_data(46, 11);
					m_dirData[46] = 11;
				}
				else
				{
					ulDedamaLotState |= 16384L;
					ulDedamaLotState |= 4096L;
					ulDedamaLotState &= -2049L;
					ulDedamaLotState &= -129L;
					int num7 = get_pkd_data(90);
					num7++;
					set_pkd_data(90, num7);
					m_kaidoData[90] = num7;
					int num8 = (int)Random.Range(0f, 4f);
					num8++;
					set_pkd_data(94, num8);
					m_kaidoData[94] = num8;
				}
				set_pkd_data(0, (int)ulDedamaLotState);
				set_pkd_data(1, (int)ulDedamaLotStateOld);
				if (get_pdt_data(16) != 0)
				{
					set_pdt_data(16, 0);
					m_dirData[16] = 0;
					set_pdt_data(88, 0);
					m_dirData[88] = 0;
					set_pri_data(2, 0);
				}
				break;
			}
			}
			break;
		}
	}

	public void pbLotZugara()
	{
		int num = 50;
		if (m_kaidoData[86] == 6)
		{
			int num2 = (int)Random.Range(0f, 65536f);
			num = ((num2 >= 49152) ? 51 : 50);
			set_main_cmd(6, num);
			set_koyaku_prm(2, num);
		}
	}

	public void anoBtlSet()
	{
		if (get_pkd_data(606) != 0)
		{
			ulDedamaLotState |= 4L;
			ulDedamaLotStateOld |= 4L;
			m_kaidoData[440] = 10;
			m_kaidoData[443] = 0;
			set_pkd_data(0, (int)ulDedamaLotState);
			set_pkd_data(1, (int)ulDedamaLotStateOld);
			set_pkd_data(440, 10);
			set_pkd_data(443, 0);
			set_pkd_data(552, 0);
			m_kaidoData[552] = 0;
			set_pkd_data(551, 0);
			m_kaidoData[551] = 0;
			set_pkd_data(566, 0);
			m_kaidoData[566] = 0;
			set_pkd_data(455, 4);
			m_kaidoData[455] = 4;
			set_pkd_data(606, 0);
			m_kaidoData[606] = 0;
			m_usCNTAddBTL_TOTAL_Disp = 0;
		}
	}

	public int getTotalUwanoseDUP()
	{
		int num = 0;
		int num2 = 1;
		if (m_kaidoData[444] != 0)
		{
			num2 = 2;
		}
		num = m_kaidoData[443] * num2;
		m_usCNTAddBTL_TOTAL_Disp = m_kaidoData[442] * num2;
		return num;
	}

	public int getTotalUwanose()
	{
		int num = 0;
		if (m_dirData[45] == 17 || m_dirData[45] == 18)
		{
			return m_usCNTAddBTL_TOTAL_Disp;
		}
		return m_kaidoData[584];
	}

	public bool isProdStay(int _num)
	{
		bool result = false;
		if (m_dirData[1] == 31)
		{
			if ((m_dirData[5] == 106 || m_dirData[5] == 107 || m_dirData[5] == 108) && (m_dirData[9] == 106 || m_dirData[9] == 107 || m_dirData[9] == 108) && m_dirData[49] == 18)
			{
				result = true;
			}
			if ((m_dirData[5] == 106 || m_dirData[5] == 107 || m_dirData[5] == 108) && m_dirData[49] == 18 && _num == 100)
			{
				result = true;
			}
		}
		if (m_dirData[1] == 95 && (m_dirData[5] == 307 || m_dirData[5] == 309 || m_dirData[5] == 311) && (m_dirData[9] == 307 || m_dirData[9] == 309 || m_dirData[9] == 311))
		{
			result = true;
		}
		return result;
	}

	public int destroyLotUwanose()
	{
		int[] array = new int[5] { 57345, 4096, 2051, 1022, 1022 };
		int[] array2 = new int[5] { 30, 50, 100, 200, 300 };
		int result = 30;
		int num = (int)Random.Range(0f, 65536f);
		int num2 = 0;
		for (int i = 0; i < 5; i++)
		{
			num2 += array[i];
			if (num < num2)
			{
				result = array2[i];
				break;
			}
		}
		return result;
	}

	public int destroyProdUwanose(int uwanose)
	{
		int[][] array = new int[4][]
		{
			new int[5] { 4, 5, 6, 8, 9 },
			new int[5] { 13, 14, 15, 17, 18 },
			new int[5] { 4, 19, 20, 22, 23 },
			new int[5] { 13, 24, 25, 27, 28 }
		};
		int num = (int)Random.Range(0f, 4f);
		int result = 4;
		int num2 = 0;
		switch (uwanose)
		{
		case 30:
			num2 = 0;
			break;
		case 50:
			num2 = 1;
			break;
		case 100:
			num2 = 2;
			break;
		case 200:
			num2 = 3;
			break;
		case 300:
			num2 = 4;
			break;
		}
		if (num >= 0 && 4 >= num)
		{
			result = array[num][num2];
		}
		return result;
	}

	public bool checkGijiren()
	{
		bool result = false;
		int num = get_pkd_data(564);
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		if (num >= 4)
		{
			num2 = get_pkd_data(88);
			num3 = get_pkd_data(333);
			num4 = get_pkd_data(226);
			if (num2 == 0 && num3 == 0 && num4 == 0)
			{
				result = true;
			}
		}
		if (m_kaidoData[86] == 5 || m_kaidoData[86] == 6)
		{
			result = true;
		}
		return result;
	}

	public bool isGijiren()
	{
		bool result = false;
		int num = get_pkd_data(564);
		int num2 = get_pdt_data(45);
		int num3 = 0;
		if ((ulDedamaLotState & 0x10000) != 0L)
		{
			num3 = 1;
		}
		if (num > num3 || m_oldGijiNum > num3)
		{
			result = true;
		}
		if (checkGijiren())
		{
			result = false;
		}
		return result;
	}

	public bool isChainClr()
	{
		bool result = false;
		int num = get_pkd_data(595);
		if ((get_pkd_data(563) == 0 && num == 1) || (m_dirData[1] == 87 && m_dirData[5] == 24))
		{
			result = true;
		}
		return result;
	}

	public void tokuNaviProd(int _reelNum, int _teishiNum)
	{
		int[][] array = new int[3][]
		{
			new int[3] { 73, 75, 77 },
			new int[3] { 75, 73, 74 },
			new int[3] { 76, 74, 73 }
		};
		int num = m_dirData[16];
		int num2 = 0;
		if ((73 <= num && num <= 78) || (157 <= num && num <= 162))
		{
			num2 = 0;
		}
		else
		{
			if ((79 > num || num > 84) && (163 > num || num > 168))
			{
				return;
			}
			num2 = 1;
		}
		if (_teishiNum >= 0 && 2 >= _teishiNum && _reelNum >= 0 && 2 >= _reelNum)
		{
			m_dirData[16] = array[_teishiNum][_reelNum] + num2 * 6;
		}
	}

	public void debugSetCmd()
	{
	}

	public void testlmplog(int _num)
	{
	}

	public void testlotlog(int lotcnt)
	{
	}
}
