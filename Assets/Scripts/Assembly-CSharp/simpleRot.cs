using UnityEngine;

public class simpleRot : MonoBehaviour
{
	private const int MODE_RT0 = 0;

	private const int MODE_RT1 = 1;

	private const int MODE_RT2 = 2;

	private const int MODE_RT3 = 3;

	private const int MODE_RT4 = 4;

	private const int MODE_RT5 = 5;

	private const int MODE_RT6 = 6;

	private const int MODE_SUB_NORMAL = 0;

	private const int MODE_SUB_SINPAN = 1;

	private const int MODE_SUB_HOH = 2;

	private const int MODE_SUB_PB = 3;

	private const int MODE_SUB_RB = 4;

	private const int MODE_SUB_GB = 5;

	private const int MODE_SUB_SGB = 6;

	private const int MODE_SUB_ART = 7;

	private const int MODE_SUB_ART_HOH = 8;

	private const int MODE_SUB_ART_PB = 9;

	private const int MODE_SUB_ART_RB = 10;

	private const int MODE_SUB_ART_GB = 11;

	private const int MODE_SUB_ART_SGB = 12;

	private const int MODE_SUB_BNS_PB = 13;

	private const int MODE_SUB_ART_BNS_PB = 14;

	private const float REEL_STEP_RAND = 100f;

	private const int MAX_GAME_RB = 25;

	private const int MAX_GAME_GB = 50;

	private const int MAX_GAME_SGB = 100;

	private const int MAX_GAME_PB = 25;

	private const int MAX_GAME_JG = 10;

	private const int MAX_GAME_ART = 40;

	private const int MAX_GAME_ART_BLT = 7;

	private const int MAX_GAME_HOT = 20;

	private const int MAX_TENSION_GAJE = 5;

	private const short MAX_HOH_LIFE = 10;

	private const short MAX_CHARGE = 6;

	private const int MAX_TENJO = 1000;

	private int modeMain;

	private int modeSub;

	private short mode;

	private short modeArt;

	private int settei;

	private int gameCnt;

	private int cycleGame;

	private short cycleMode;

	private int yaku;

	private int FLTousen1;

	private int reelStep;

	private int bonusGame;

	private int artGame;

	private int artCntContBtl;

	private int artStockCnt;

	private bool artBtlWin;

	private int jgGame;

	private int hohGame;

	private int artCntVarGame;

	private short hohChar;

	private short hohTension;

	private short hohRivalCharDamage;

	private short hohSolCharDamage;

	private short gbChargeCnt;

	private short rbMap;

	private int[] reel = new int[3];

	private MachineData data;

	private string[] strMain = new string[7] { "MODE_RT0", "MODE_RT1", "MODE_RT2", "MODE_RT3", "MODE_RT4", "MODE_RT5", "MODE_RT6" };

	private string[] str = new string[13]
	{
		"MODE_SUB_NORMAL\t", "MODE_SUB_SINPAN\t", "MODE_SUB_HOH\t\t", "MODE_SUB_PB\t\t", "MODE_SUB_RB\t\t", "MODE_SUB_GB\t\t", "MODE_SUB_SGB\t\t", "MODE_SUB_ART\t\t", "MODE_SUB_ART_HOH\t", "MODE_SUB_ART_PB\t",
		"MODE_SUB_ART_RB\t", "MODE_SUB_ART_GB\t", "MODE_SUB_ART_SGB\t"
	};

	private string[] strYaku = new string[20]
	{
		"CMB_NON  ", "CMB_RPA  ", "CMB_RPB  ", "CMB_RPC  ", "CMB_RPD  ", "CMB_RPE  ", "CMB_PRF  ", "CMB_BEL1 ", "CMB_BEL2 ", "CMB_BEL3 ",
		"CMB_WML  ", "CMB_CHE1 ", "CMB_CHE2 ", "CMB_CHE3 ", "CMB_CHA1 ", "CMB_CHA2 ", "CMB_DIRP ", "CMB_REACH", "CMB_MB   ", "CMB_MBBEL"
	};

	public static int[] yakuDebug = new int[20];

	public static int[] reelDebug = new int[4];

	public static int[] hitDebug = new int[7];

	private void Awake()
	{
	}

	private void Start()
	{
		modeMain = 0;
		gameCnt = 0;
	}

	private void Update()
	{
	}

	private void GameStart()
	{
		yaku = 0;
		for (int i = 0; i < reel.Length; i++)
		{
			reel[i] = Random.Range(0, 21);
		}
		if (modeMain != 6)
		{
			FLTousen1 = RotsDef.GetYaku(settei, modeMain);
			if (FLTousen1 < RotsDef.D_HitZu_LotFlagChg.Length)
			{
				yaku = RotsDef.D_HitZu_LotFlagChg[FLTousen1];
				reelStep = RotsDef.getReelStep(yaku);
			}
			else
			{
				FLTousen1 = 53;
			}
		}
		else
		{
			if (RotsDef.GetPbYaku() == 0)
			{
				FLTousen1 = 51;
			}
			else
			{
				FLTousen1 = 52;
			}
			yaku = 19;
			reelStep = 0;
		}
	}

	private int getRand(float[] tbl, float max)
	{
		float num = Random.Range(0f, max);
		float num2 = 0f;
		for (int i = 0; i < tbl.Length; i++)
		{
			num2 += tbl[i];
			if (num2 > num)
			{
				return i;
			}
		}
		return -1;
	}

	private int getRand(int[] tbl, int max)
	{
		float num = Random.Range(0f, max);
		float num2 = 0f;
		for (int i = 0; i < tbl.Length; i++)
		{
			num2 += (float)tbl[i];
			if (num2 > num)
			{
				return i;
			}
		}
		return -1;
	}

	private void GameSqence()
	{
		switch (modeSub)
		{
		case 0:
			gameCnt++;
			if (FLTousen1 == 53)
			{
				modeSub = 3;
				int artLoopB3 = RotsDef.getArtLoopB();
				artBtlWin = RotsDef.getArtBtlWin(artLoopB3);
				bonusGame = 25;
				modeMain = 6;
				data.hisData.setLog(gameCnt, 0);
				break;
			}
			if (cycleGame != 0)
			{
				cycleGame--;
			}
			if (RotsDef.isBonus(reelStep, settei, yaku, RotsDef._BNS_MODE._NORMAL))
			{
				bonusGame = RotsDef.getBonus(reelStep, settei, yaku, RotsDef._BNS_MODE._NORMAL);
				modeSub = 4 + bonusGame;
				switch (bonusGame)
				{
				case 0:
					bonusGame = 25;
					break;
				case 1:
					bonusGame = 50;
					break;
				case 2:
					bonusGame = 100;
					break;
				}
				yakuDebug[yaku]++;
				data.hisData.setLog(yaku);
				cycleMode = RotsDef.getCycle(settei, cycleMode);
				cycleGame = RotsDef.getCycleGame(cycleMode);
				hitDebug[0]++;
				break;
			}
			if (RotsDef.getNormalART(settei, yaku) || gameCnt >= 1000)
			{
				gameCnt = 0;
				mode = RotsDef.getArtModeFirst(settei);
				modeSub = 7;
				artGame = 40;
				data.hisData.setLog(yaku);
				cycleMode = RotsDef.getCycle(settei, cycleMode);
				cycleGame = RotsDef.getCycleGame(cycleMode);
				hitDebug[1]++;
				break;
			}
			if (RotsDef.getNormalHOH(settei, mode, yaku))
			{
				modeSub = 2;
				hohChar = RotsDef.getHoHChar(RotsDef._HOH_CHAR_MODE._NORMAL);
				cycleMode = RotsDef.getCycle(settei, cycleMode);
				cycleGame = RotsDef.getCycleGame(cycleMode);
				break;
			}
			if (RotsDef.getJgCut(settei, yaku))
			{
				int jgCutG = RotsDef.getJgCutG(yaku);
				if (jgCutG > cycleGame)
				{
					cycleGame = 0;
				}
				else
				{
					cycleGame -= jgCutG;
				}
			}
			mode = RotsDef.getNormalMode(settei, yaku, mode);
			if (cycleGame == 0)
			{
				modeSub = 1;
			}
			break;
		case 1:
			gameCnt++;
			if (FLTousen1 == 53)
			{
				modeSub = 3;
				int artLoopB7 = RotsDef.getArtLoopB();
				artBtlWin = RotsDef.getArtBtlWin(artLoopB7);
				bonusGame = 25;
				modeMain = 6;
				data.hisData.setLog(gameCnt, 0);
			}
			else if (RotsDef.isBonus(reelStep, settei, yaku, RotsDef._BNS_MODE._JUGE))
			{
				bonusGame = RotsDef.getBonus(reelStep, settei, yaku, RotsDef._BNS_MODE._NORMAL);
				modeSub = 4 + bonusGame;
				switch (bonusGame)
				{
				case 0:
					bonusGame = 25;
					break;
				case 1:
					bonusGame = 50;
					break;
				case 2:
					bonusGame = 100;
					break;
				}
				cycleMode = RotsDef.getCycle(settei, cycleMode);
				cycleGame = RotsDef.getCycleGame(cycleMode);
				yakuDebug[yaku]++;
				data.hisData.setLog(yaku);
				jgGame = 0;
				hitDebug[3]++;
			}
			else if (RotsDef.getNormalART(settei, yaku) || gameCnt >= 1000)
			{
				gameCnt = 0;
				jgGame = 0;
				artGame = 40;
				modeSub = 7;
				mode = RotsDef.getArtModeFirst(settei);
				cycleMode = RotsDef.getCycle(settei, cycleMode);
				cycleGame = RotsDef.getCycleGame(cycleMode);
				data.hisData.setLog(yaku);
				hitDebug[4]++;
			}
			else if (RotsDef.getJgHOH(settei, yaku))
			{
				modeSub = 2;
				hohChar = RotsDef.getHoHChar(RotsDef._HOH_CHAR_MODE._JG);
				cycleMode = RotsDef.getCycle(settei, cycleMode);
				cycleGame = RotsDef.getCycleGame(cycleMode);
			}
			else if (jgGame == 10)
			{
				if (yaku == 0 && RotsDef.getJgEnd())
				{
					jgGame = 0;
					modeSub = 0;
					cycleMode = RotsDef.getCycle(settei, cycleMode);
					cycleGame = RotsDef.getCycleGame(cycleMode);
				}
			}
			else
			{
				jgGame++;
			}
			break;
		case 2:
			gameCnt++;
			if (FLTousen1 == 53)
			{
				modeSub = 3;
				int artLoopB4 = RotsDef.getArtLoopB();
				artBtlWin = RotsDef.getArtBtlWin(artLoopB4);
				bonusGame = 25;
				modeMain = 6;
				data.hisData.setLog(gameCnt, 0);
				break;
			}
			if (hohGame == 0)
			{
				hohTension = RotsDef.getHotDonyuTension(yaku, reelStep, hohChar);
				hohRivalCharDamage = 0;
				hohSolCharDamage = 0;
				hohGame++;
				break;
			}
			hohGame++;
			if (hohGame == 20 || hohTension == 5)
			{
				bonusGame = RotsDef.getBonus(reelStep, settei, yaku, RotsDef._BNS_MODE._NORMAL);
				modeSub = 4 + bonusGame;
				switch (bonusGame)
				{
				case 0:
					bonusGame = 25;
					break;
				case 1:
					bonusGame = 50;
					break;
				case 2:
					bonusGame = 100;
					break;
				}
				cycleMode = RotsDef.getCycle(settei, cycleMode);
				cycleGame = RotsDef.getCycleGame(cycleMode);
				hohGame = 0;
				hohTension = 0;
				yakuDebug[yaku]++;
				data.hisData.setLog(yaku);
				hitDebug[5]++;
				break;
			}
			switch ((int)RotsDef.getHotHit(0, yaku))
			{
			case 0:
			{
				short hohAttack = RotsDef.getHohAttack(hohChar, 0, yaku);
				hohRivalCharDamage += hohAttack;
				if (reelStep > 0)
				{
					hohRivalCharDamage += RotsDef.getHotAttack(reelStep);
				}
				if (hohRivalCharDamage >= 10)
				{
					bonusGame = RotsDef.getBonus(reelStep, settei, yaku, RotsDef._BNS_MODE._NORMAL);
					modeSub = 4 + bonusGame;
					switch (bonusGame)
					{
					case 0:
						bonusGame = 25;
						break;
					case 1:
						bonusGame = 50;
						break;
					case 2:
						bonusGame = 100;
						break;
					}
					cycleMode = RotsDef.getCycle(settei, cycleMode);
					cycleGame = RotsDef.getCycleGame(cycleMode);
					hohGame = 0;
					hohTension = 0;
					yakuDebug[yaku]++;
					data.hisData.setLog(yaku);
					hitDebug[6]++;
				}
				break;
			}
			case 1:
				hohSolCharDamage += RotsDef.getHohDamage(hohChar, 0, yaku);
				if (hohSolCharDamage >= 10)
				{
					if (jgGame != 10 && jgGame != 0)
					{
						modeSub = 1;
						hohGame = 0;
						hohTension = 0;
					}
					else
					{
						modeSub = 0;
						hohGame = 0;
						hohTension = 0;
					}
				}
				break;
			case 2:
				hohTension += RotsDef.getHotTension(yaku);
				break;
			}
			break;
		case 4:
			if (FLTousen1 == 53)
			{
				modeSub = 13;
				int artLoopB = RotsDef.getArtLoopB();
				artBtlWin = RotsDef.getArtBtlWin(artLoopB);
				bonusGame = 25;
				modeMain = 6;
				data.hisData.setLog(gameCnt, 0);
			}
			else if (modeMain != 3)
			{
				gameCnt++;
			}
			else if (bonusGame > 0)
			{
				int num = RotsDef.usRB_HLTBL[rbMap][25 - bonusGame];
				bonusGame--;
				num--;
				if (artStockCnt == 0)
				{
					if (RotsDef.getRbArtLot(num, yaku))
					{
						artStockCnt++;
					}
				}
				else if (RotsDef.getRbAddArtGameLot(num, yaku))
				{
					int rbAddArtGame = RotsDef.getRbAddArtGame(yaku);
					artGame += RotsDef.addTbl[rbAddArtGame];
				}
			}
			else
			{
				if (artStockCnt == 0)
				{
					modeSub = 0;
				}
				else
				{
					artStockCnt--;
					artGame += 40;
					modeSub = 7;
					modeArt = RotsDef.getArtModeFirst(settei);
				}
				gameCnt = 0;
			}
			break;
		case 5:
		case 6:
			if (FLTousen1 == 53)
			{
				modeSub = 13;
				int artLoopB8 = RotsDef.getArtLoopB();
				artBtlWin = RotsDef.getArtBtlWin(artLoopB8);
				bonusGame = 25;
				modeMain = 6;
				data.hisData.setLog(gameCnt, 0);
			}
			else if (modeMain != 3)
			{
				gameCnt++;
			}
			else if (bonusGame > 0)
			{
				bonusGame--;
				if (!RotsDef.getGBChargeLot((modeSub != 5) ? 1 : 0, yaku))
				{
					break;
				}
				if (artStockCnt != 0)
				{
					int gbArtAddGame = RotsDef.getGbArtAddGame(yaku);
					artGame += RotsDef.addTbl[gbArtAddGame];
					break;
				}
				if (gbChargeCnt < 6)
				{
					gbChargeCnt++;
				}
				if (gbChargeCnt >= 6)
				{
				}
				if (RotsDef.getGBArtLot((modeSub != 5) ? 1 : 0, yaku))
				{
					artStockCnt++;
				}
			}
			else
			{
				if (artStockCnt == 0)
				{
					modeSub = 0;
				}
				else
				{
					artStockCnt--;
					artGame += 40;
					modeSub = 7;
					modeArt = RotsDef.getArtModeFirst(settei);
				}
				gameCnt = 0;
			}
			break;
		case 7:
			gameCnt++;
			if (FLTousen1 == 53)
			{
				modeSub = 9;
				int artLoopB5 = RotsDef.getArtLoopB();
				artBtlWin = RotsDef.getArtBtlWin(artLoopB5);
				bonusGame = 25;
				modeMain = 6;
				data.hisData.setLog(gameCnt, 0);
			}
			else if (modeMain != 4)
			{
				if (RotsDef.getArtPreparationBonus(reelStep, settei, yaku))
				{
					bonusGame = RotsDef.getBonus(reelStep, settei, yaku, RotsDef._BNS_MODE._ART);
					modeSub = 10 + bonusGame;
					switch (bonusGame)
					{
					case 0:
						bonusGame = 25;
						break;
					case 1:
						bonusGame = 50;
						break;
					case 2:
						bonusGame = 100;
						break;
					}
					yakuDebug[yaku]++;
					data.hisData.setLog(yaku);
				}
				else if (RotsDef.getArtPreparationAddLot(yaku))
				{
					int artPreparationAddGame = RotsDef.getArtPreparationAddGame(yaku);
					artGame += RotsDef.addTbl[artPreparationAddGame];
				}
			}
			else if (artCntContBtl > 0)
			{
				artCntContBtl--;
				if (artBtlWin)
				{
					if (RotsDef.getArtBtlAddLot(yaku))
					{
						artGame += RotsDef.getArtBtlAddGame(yaku);
					}
				}
				else
				{
					artBtlWin = RotsDef.getArtBtlRewriting(reelStep, yaku);
				}
			}
			else if (artGame > 0)
			{
				artGame--;
				if (artCntVarGame < 0)
				{
					artCntVarGame--;
				}
				if (artGame == 0)
				{
					artCntContBtl = 7;
				}
				if (RotsDef.isBonus(reelStep, settei, yaku, RotsDef._BNS_MODE._ART))
				{
					bonusGame = RotsDef.getBonus(reelStep, settei, yaku, RotsDef._BNS_MODE._ART);
					modeSub = 10 + bonusGame;
					switch (bonusGame)
					{
					case 0:
						bonusGame = 25;
						break;
					case 1:
						bonusGame = 50;
						break;
					case 2:
						bonusGame = 100;
						break;
					}
					yakuDebug[yaku]++;
					data.hisData.setLog(yaku);
				}
				else if (RotsDef.getArtPlayingArtAddLot(yaku))
				{
					int artPlayingArtAddGame = RotsDef.getArtPlayingArtAddGame(yaku);
					artGame += RotsDef.addTbl[artPlayingArtAddGame];
				}
				else if (RotsDef.getArtHohLot(modeArt, yaku) || artCntVarGame == 1)
				{
					if (artCntVarGame == 1)
					{
					}
					hohChar = RotsDef.getHoHChar(RotsDef._HOH_CHAR_MODE._ART_NORMAL);
					modeSub = 8;
					hohGame = 0;
					artCntVarGame = 0;
					modeArt = RotsDef.getArtMode(settei, yaku, modeArt);
				}
			}
			else if (artGame == 0)
			{
				modeSub = 0;
				artCntVarGame = 0;
				hohGame = 0;
				artCntContBtl = 0;
				artBtlWin = false;
			}
			break;
		case 8:
			if (FLTousen1 == 53)
			{
				modeSub = 9;
				int artLoopB2 = RotsDef.getArtLoopB();
				artBtlWin = RotsDef.getArtBtlWin(artLoopB2);
				bonusGame = 25;
				modeMain = 6;
				data.hisData.setLog(gameCnt, 0);
				break;
			}
			if (hohGame == 0)
			{
				hohTension = RotsDef.getHotDonyuTension(yaku, reelStep, hohChar);
				hohRivalCharDamage = 0;
				hohSolCharDamage = 0;
				hohGame++;
				break;
			}
			hohGame++;
			if (hohGame == 20 || hohTension == 5)
			{
				bonusGame = RotsDef.getBonus(reelStep, settei, yaku, RotsDef._BNS_MODE._ART);
				modeSub = 10 + bonusGame;
				switch (bonusGame)
				{
				case 0:
					bonusGame = 25;
					break;
				case 1:
					bonusGame = 50;
					break;
				case 2:
					bonusGame = 100;
					break;
				}
				hohGame = 0;
				hohTension = 0;
				yakuDebug[yaku]++;
				data.hisData.setLog(yaku);
				break;
			}
			switch ((int)RotsDef.getHotHit(1, yaku))
			{
			case 0:
				hohRivalCharDamage += RotsDef.getHohAttack(hohChar, 1, yaku);
				if (reelStep > 0)
				{
					hohRivalCharDamage += RotsDef.getHotAttack(reelStep);
				}
				if (hohRivalCharDamage >= 10)
				{
					bonusGame = RotsDef.getBonus(reelStep, settei, yaku, RotsDef._BNS_MODE._ART);
					modeSub = 10 + bonusGame;
					switch (bonusGame)
					{
					case 0:
						bonusGame = 25;
						break;
					case 1:
						bonusGame = 50;
						break;
					case 2:
						bonusGame = 100;
						break;
					}
					hohGame = 0;
					hohTension = 0;
					yakuDebug[yaku]++;
					data.hisData.setLog(yaku);
				}
				break;
			case 1:
				hohSolCharDamage += RotsDef.getHohDamage(hohChar, 1, yaku);
				if (hohSolCharDamage >= 10)
				{
					modeSub = 7;
					hohGame = 0;
					hohTension = 0;
				}
				break;
			case 2:
				hohTension += RotsDef.getHotTension(yaku);
				break;
			}
			break;
		case 10:
			if (FLTousen1 == 53)
			{
				modeSub = 14;
				int artLoopB9 = RotsDef.getArtLoopB();
				artBtlWin = RotsDef.getArtBtlWin(artLoopB9);
				bonusGame = 25;
				modeMain = 6;
				data.hisData.setLog(gameCnt, 0);
			}
			else if (modeMain != 3)
			{
				gameCnt++;
			}
			else if (bonusGame > 0)
			{
				bonusGame--;
			}
			else
			{
				modeSub = 7;
				gameCnt = 0;
			}
			break;
		case 11:
		case 12:
			if (FLTousen1 == 53)
			{
				modeSub = 14;
				int artLoopB6 = RotsDef.getArtLoopB();
				artBtlWin = RotsDef.getArtBtlWin(artLoopB6);
				bonusGame = 25;
				modeMain = 6;
				data.hisData.setLog(gameCnt, 0);
			}
			else if (modeMain != 3)
			{
				gameCnt++;
			}
			else if (bonusGame > 0)
			{
				bonusGame--;
				if (RotsDef.getBbArtAddLot((modeSub != 5) ? 1 : 0, 0, yaku))
				{
					int num2 = RotsDef.getbbArtAddGame(0);
					artGame += RotsDef.addTbl[num2];
				}
			}
			else
			{
				modeSub = 7;
				gameCnt = 0;
			}
			break;
		case 3:
			if (bonusGame > 0)
			{
				bonusGame--;
			}
			if ((FLTousen1 == 51 && RotsDef.getPbArtLot()) || FLTousen1 == 52)
			{
				artGame += RotsDef.getPbArtGame();
			}
			if (bonusGame == 0)
			{
				artGame += 40;
				modeSub = 7;
				modeMain = 1;
				gameCnt = 0;
			}
			break;
		case 9:
			if (bonusGame > 0)
			{
				bonusGame--;
			}
			if ((FLTousen1 == 51 && RotsDef.getPbArtLot()) || FLTousen1 == 52)
			{
				artGame += RotsDef.getPbArtGame();
			}
			if (bonusGame == 0)
			{
				artGame += 40;
				modeSub = 7;
				modeMain = 1;
				gameCnt = 0;
			}
			break;
		case 13:
			if (bonusGame > 0)
			{
				bonusGame--;
			}
			if ((FLTousen1 == 51 && RotsDef.getPbArtLot()) || FLTousen1 == 52)
			{
				artGame += RotsDef.getPbArtGame();
			}
			if (bonusGame == 0)
			{
				artGame += 40;
				modeSub = 6;
				modeMain = 1;
				gameCnt = 0;
			}
			break;
		case 14:
			if (bonusGame > 0)
			{
				bonusGame--;
			}
			if ((FLTousen1 == 51 && RotsDef.getPbArtLot()) || FLTousen1 == 52)
			{
				artGame += RotsDef.getPbArtGame();
			}
			if (bonusGame == 0)
			{
				artGame += 40;
				modeSub = 12;
				modeMain = 1;
				gameCnt = 0;
			}
			break;
		}
		switch (modeMain)
		{
		case 0:
			if (yaku == 7)
			{
				modeMain = 1;
			}
			break;
		case 1:
		{
			bool flag = modeSub == 7 || modeSub == 4 || modeSub == 5 || modeSub == 6;
			if (getMainModeMoveYakuFromRT1toRT2() && flag)
			{
				modeMain = 2;
			}
			break;
		}
		case 2:
			if (yaku == 7 && modeSub == 0)
			{
				modeMain = 1;
			}
			if (yaku == 2 && modeSub == 7)
			{
				data.hisData.setLog(gameCnt, 4);
				data.hisData.artCnt++;
				modeMain = 4;
				int artLoopA = RotsDef.getArtLoopA(settei);
				artBtlWin = RotsDef.getArtBtlWin(artLoopA);
				artCntVarGame = 0;
				if (RotsDef.getVastejiLot())
				{
					artCntVarGame = RotsDef.vastejiGameTbl[RotsDef.getArtVastejiStartGame()];
				}
			}
			else if ((modeSub == 4 || modeSub == 10) && getMainModeMoveYakuFromRT2toRT3RB())
			{
				data.hisData.setLog(gameCnt, 1);
				data.hisData.bnsRBCnt++;
				modeMain = 3;
				rbMap = RotsDef.getRbMap((artGame != 0) ? 1 : 0);
			}
			else if ((modeSub == 5 || modeSub == 11) && getMainModeMoveYakuFromRT2toRT3GB())
			{
				data.hisData.setLog(gameCnt, 2);
				data.hisData.bnsGBCnt++;
				modeMain = 3;
			}
			else if ((modeSub == 6 || modeSub == 12) && getMainModeMoveYakuFromRT2toRT3SGB())
			{
				data.hisData.setLog(gameCnt, 3);
				data.hisData.bnsSGBCnt++;
				modeMain = 3;
			}
			break;
		case 3:
			if (modeSub != 4 && modeSub != 5 && modeSub != 6 && modeSub != 10 && modeSub != 11 && modeSub != 12 && yaku == 2)
			{
				modeMain = 2;
			}
			break;
		case 4:
			if (modeSub != 7 && yaku == 2)
			{
				modeMain = 2;
			}
			break;
		case 5:
			break;
		case 6:
			break;
		}
	}

	private void GameEnd()
	{
		data.gameCount = gameCnt;
		data.modeMain = modeMain;
		data.modeSub = modeSub;
		data.mode = mode;
		data.modeArt = modeArt;
		data.cycleGame = cycleGame;
		data.cycleMode = cycleMode;
		data.yaku = yaku;
		data.FLTousen1 = FLTousen1;
		data.reelStep = reelStep;
		data.bonusGame = bonusGame;
		data.artGame = artGame;
		data.artCntContBtl = artCntContBtl;
		data.artStockCnt = artStockCnt;
		data.artBtlWin = artBtlWin;
		data.jgGame = jgGame;
		data.hohGame = hohGame;
		data.artCntVarGame = artCntVarGame;
		data.hohChar = hohChar;
		data.hohTension = hohTension;
		data.hohRivalCharDamage = hohRivalCharDamage;
		data.hohSolCharDamage = hohSolCharDamage;
		data.gbChargeCnt = gbChargeCnt;
		data.rbMap = rbMap;
	}

	public void Game()
	{
		GameStart();
		GameSqence();
		GameEnd();
	}

	public int getMode()
	{
		switch (modeMain)
		{
		case 0:
			return 2;
		case 1:
			return 2;
		case 2:
			return 2;
		case 3:
			return (modeSub != 4 && modeSub != 5 && modeSub != 6 && modeSub != 10 && modeSub != 11 && modeSub != 12) ? 2 : 3;
		case 4:
			return (modeSub != 8 && modeSub != 7) ? 2 : 4;
		case 5:
			return 3;
		case 6:
			return 3;
		default:
			return 2;
		}
	}

	public int getPay()
	{
		switch (yaku)
		{
		case 2:
		{
			bool flag3 = modeSub == 4 || modeSub == 5 || modeSub == 6;
			bool flag4 = ((artGame != 0) ? true : false);
			if (!flag3 && !flag4)
			{
				float num = Random.Range(0f, 6f);
				return (num != 0f) ? (-3) : 3;
			}
			return 3;
		}
		case 7:
		{
			bool flag = modeSub == 4 || modeSub == 5 || modeSub == 6;
			bool flag2 = ((artGame != 0) ? true : false);
			if (!flag && !flag2)
			{
				return 1;
			}
			return 9;
		}
		case 1:
		case 3:
		case 4:
		case 5:
		case 6:
		case 16:
			return 3;
		case 11:
		case 12:
		case 13:
			return 1;
		case 8:
		case 19:
			return 14;
		case 9:
			return 9;
		case 10:
			return 5;
		default:
			return -3;
		}
	}

	public bool getMainModeMoveYakuFromRT1toRT2()
	{
		if (FLTousen1 >= 21 && FLTousen1 <= 26)
		{
			return true;
		}
		return false;
	}

	public bool getMainModeMoveYakuFromRT2toRT3GB()
	{
		if (FLTousen1 >= 13 && FLTousen1 <= 16)
		{
			return true;
		}
		return false;
	}

	public bool getMainModeMoveYakuFromRT2toRT3SGB()
	{
		if (FLTousen1 >= 9 && FLTousen1 <= 12)
		{
			return true;
		}
		return false;
	}

	public bool getMainModeMoveYakuFromRT2toRT3RB()
	{
		if (FLTousen1 >= 17 && FLTousen1 <= 20)
		{
			return true;
		}
		return false;
	}

	public void setSettei(int value, bool recv)
	{
		settei = value;
		if (!recv)
		{
			cycleMode = RotsDef.getCycle(settei, RotsDef.CYCLE_MODE_RESET);
			cycleGame = RotsDef.getCycleGame(cycleMode);
			mode = RotsDef.getResetMode();
			return;
		}
		gameCnt = data.gameCount;
		modeMain = data.modeMain;
		modeSub = data.modeSub;
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
	}

	public void setMachineData(MachineData backUp)
	{
		data = backUp;
	}
}
