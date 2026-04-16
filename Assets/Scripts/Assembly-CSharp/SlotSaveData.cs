public class SlotSaveData
{
	public uint SerVerTime;

	public uint AppTimer;

	public int[] m_dirData = new int[105];

	public int[] m_kaidoData = new int[657];

	public int[] m_reelData = new int[13];

	public double ulDedamaLotState;

	public double ulDedamaLotStateOld;

	public int m_mochiMedal;

	public int m_creditMedal;

	public int m_betMedal;

	public int m_payoutMedal;

	public int m_inMedal;

	public int m_outMedal;

	public bool m_replay;

	public int tousenYaku;

	public int gameCountArt;

	public int artGameMax;

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

	public int m_State;

	public int m_OldState;

	public bool m_StateChange;

	public int[] m_reelStopNum = new int[3];

	public int[] m_reelPushOrder = new int[3];

	public int m_Current;

	public int[] m_Slump_game = new int[SlumpData.GAME_MAX / SlumpData.SAVE_GAME];

	public int[] m_Slump_medal = new int[SlumpData.GAME_MAX / SlumpData.SAVE_GAME];

	public int old_totalGameCount;

	public int old_mochiMedal;

	public bool m_saveFlag;

	public void set()
	{
		for (int i = 0; i < 105; i++)
		{
			m_dirData[i] = MainGameScene.slotGameMan.m_dirData[i];
		}
		for (int i = 0; i < 657; i++)
		{
			m_kaidoData[i] = MainGameScene.slotGameMan.m_kaidoData[i];
		}
		for (int i = 0; i < 13; i++)
		{
			m_reelData[i] = MainGameScene.slotGameMan.m_reelData[i];
		}
		ulDedamaLotState = MainGameScene.slotGameMan.ulDedamaLotState;
		ulDedamaLotStateOld = MainGameScene.slotGameMan.ulDedamaLotStateOld;
		m_mochiMedal = MainGameScene.slotGameMan.m_mochiMedal;
		m_creditMedal = MainGameScene.slotGameMan.m_creditMedal;
		m_betMedal = MainGameScene.slotGameMan.m_betMedal;
		m_payoutMedal = MainGameScene.slotGameMan.m_payoutMedal;
		m_inMedal = MainGameScene.slotGameMan.m_inMedal;
		m_outMedal = MainGameScene.slotGameMan.m_outMedal;
		m_replay = MainGameScene.slotGameMan.m_replay;
		tousenYaku = MainGameScene.slotGameMan.tousenYaku;
		gameCountArt = MainGameScene.slotGameMan.gameCountArt;
		artGameMax = MainGameScene.slotGameMan.artGameMax;
		gameCount = MainGameScene.slotGameMan.gameCount;
		modeMain = MainGameScene.slotGameMan.modeMain;
		modeSub = MainGameScene.slotGameMan.modeSub;
		totalGameCount = MainGameScene.slotGameMan.totalGameCount;
		artCount = MainGameScene.slotGameMan.artCount;
		bnsCount = MainGameScene.slotGameMan.bnsCount;
		mode = MainGameScene.slotGameMan.mode;
		modeArt = MainGameScene.slotGameMan.modeArt;
		cycleGame = MainGameScene.slotGameMan.cycleGame;
		cycleMode = MainGameScene.slotGameMan.cycleMode;
		yaku = MainGameScene.slotGameMan.yaku;
		FLTousen1 = MainGameScene.slotGameMan.FLTousen1;
		reelStep = MainGameScene.slotGameMan.reelStep;
		bonusGame = MainGameScene.slotGameMan.bonusGame;
		artGame = MainGameScene.slotGameMan.artGame;
		artCntContBtl = MainGameScene.slotGameMan.artCntContBtl;
		artStockCnt = MainGameScene.slotGameMan.artStockCnt;
		artBtlWin = MainGameScene.slotGameMan.artBtlWin;
		jgGame = MainGameScene.slotGameMan.jgGame;
		hohGame = MainGameScene.slotGameMan.hohGame;
		artCntVarGame = MainGameScene.slotGameMan.artCntVarGame;
		hohChar = MainGameScene.slotGameMan.hohChar;
		hohTension = MainGameScene.slotGameMan.hohTension;
		hohRivalCharDamage = MainGameScene.slotGameMan.hohRivalCharDamage;
		hohSolCharDamage = MainGameScene.slotGameMan.hohSolCharDamage;
		gbChargeCnt = MainGameScene.slotGameMan.gbChargeCnt;
		rbMap = MainGameScene.slotGameMan.rbMap;
		selectMachine = MainGameScene.slotGameMan.selectMachine;
		m_State = (int)MainGameScene.slotMan.m_State;
		m_OldState = (int)MainGameScene.slotMan.m_OldState;
		m_StateChange = MainGameScene.slotMan.m_StateChange;
		for (int i = 0; i < 3; i++)
		{
			m_reelStopNum[i] = MainGameScene.reelMan.getReelPushStep(i);
			m_reelPushOrder[i] = MainGameScene.reelMan.pushOrder[i];
		}
		if (MainGameScene.slotGameMan.m_SlumpData != null)
		{
			m_Current = MainGameScene.slotGameMan.m_SlumpData.m_Current;
			for (int i = 0; i < m_Current; i++)
			{
				m_Slump_game[i] = MainGameScene.slotGameMan.m_SlumpData.m_Slump[i].game;
				m_Slump_medal[i] = MainGameScene.slotGameMan.m_SlumpData.m_Slump[i].medal;
			}
		}
		old_totalGameCount = MainGameScene.slotGameMan.old_totalGameCount;
		old_mochiMedal = MainGameScene.slotGameMan.old_mochiMedal;
	}

	public void setState()
	{
		m_State = (int)MainGameScene.slotMan.m_State;
		m_OldState = (int)MainGameScene.slotMan.m_OldState;
		m_StateChange = MainGameScene.slotMan.m_StateChange;
	}

	public void get()
	{
		for (int i = 0; i < 105; i++)
		{
			MainGameScene.slotGameMan.m_dirData[i] = m_dirData[i];
		}
		for (int i = 0; i < 657; i++)
		{
			MainGameScene.slotGameMan.m_kaidoData[i] = m_kaidoData[i];
		}
		for (int i = 0; i < 13; i++)
		{
			MainGameScene.slotGameMan.m_reelData[i] = m_reelData[i];
		}
		MainGameScene.slotGameMan.ulDedamaLotState = (long)ulDedamaLotState;
		MainGameScene.slotGameMan.ulDedamaLotStateOld = (long)ulDedamaLotStateOld;
		MainGameScene.slotGameMan.m_mochiMedal = m_mochiMedal;
		MainGameScene.slotGameMan.m_creditMedal = m_creditMedal;
		MainGameScene.slotGameMan.m_betMedal = m_betMedal;
		MainGameScene.slotGameMan.m_payoutMedal = m_payoutMedal;
		MainGameScene.slotGameMan.m_inMedal = m_inMedal;
		MainGameScene.slotGameMan.m_outMedal = m_outMedal;
		MainGameScene.slotGameMan.m_replay = m_replay;
		MainGameScene.slotGameMan.tousenYaku = tousenYaku;
		MainGameScene.slotGameMan.gameCountArt = gameCountArt;
		MainGameScene.slotGameMan.artGameMax = artGameMax;
		MainGameScene.slotGameMan.gameCount = gameCount;
		MainGameScene.slotGameMan.modeMain = modeMain;
		MainGameScene.slotGameMan.modeSub = modeSub;
		MainGameScene.slotGameMan.totalGameCount = totalGameCount;
		MainGameScene.slotGameMan.artCount = artCount;
		MainGameScene.slotGameMan.bnsCount = bnsCount;
		MainGameScene.slotGameMan.mode = mode;
		MainGameScene.slotGameMan.modeArt = modeArt;
		MainGameScene.slotGameMan.cycleGame = cycleGame;
		MainGameScene.slotGameMan.cycleMode = cycleMode;
		MainGameScene.slotGameMan.yaku = yaku;
		MainGameScene.slotGameMan.FLTousen1 = FLTousen1;
		MainGameScene.slotGameMan.reelStep = reelStep;
		MainGameScene.slotGameMan.bonusGame = bonusGame;
		MainGameScene.slotGameMan.artGame = artGame;
		MainGameScene.slotGameMan.artCntContBtl = artCntContBtl;
		MainGameScene.slotGameMan.artStockCnt = artStockCnt;
		MainGameScene.slotGameMan.artBtlWin = artBtlWin;
		MainGameScene.slotGameMan.jgGame = jgGame;
		MainGameScene.slotGameMan.hohGame = hohGame;
		MainGameScene.slotGameMan.artCntVarGame = artCntVarGame;
		MainGameScene.slotGameMan.hohChar = hohChar;
		MainGameScene.slotGameMan.hohTension = hohTension;
		MainGameScene.slotGameMan.hohRivalCharDamage = hohRivalCharDamage;
		MainGameScene.slotGameMan.hohSolCharDamage = hohSolCharDamage;
		MainGameScene.slotGameMan.gbChargeCnt = gbChargeCnt;
		MainGameScene.slotGameMan.rbMap = rbMap;
		MainGameScene.slotGameMan.selectMachine = selectMachine;
		MainGameScene.slotMan.m_State = getBodyState(m_State);
		MainGameScene.slotMan.m_OldState = getBodyState(m_OldState);
		MainGameScene.slotMan.m_StateChange = m_StateChange;
		if (MainGameScene.slotGameMan.m_SlumpData != null)
		{
			for (int i = 0; i < m_Current; i++)
			{
				MainGameScene.slotGameMan.m_SlumpData.addData(m_Slump_game[i], m_Slump_medal[i]);
			}
		}
		MainGameScene.slotGameMan.old_totalGameCount = old_totalGameCount;
		MainGameScene.slotGameMan.old_mochiMedal = old_mochiMedal;
	}

	private SlotBodyManager.STATE getBodyState(int _num)
	{
		SlotBodyManager.STATE result = SlotBodyManager.STATE.STANDBY;
		switch (_num)
		{
		case 3:
			result = SlotBodyManager.STATE.LEVER_WAIT;
			break;
		case 4:
			result = SlotBodyManager.STATE.REEL_WAIT;
			break;
		case 7:
			result = SlotBodyManager.STATE.REEL_STOP1;
			break;
		case 11:
			result = SlotBodyManager.STATE.REEL_STOP2;
			break;
		case 16:
			result = SlotBodyManager.STATE.REEL_END3;
			break;
		}
		return result;
	}

	public int getReelStopNum(int _num)
	{
		if (_num >= 0 && 3 > _num)
		{
			return m_reelStopNum[_num];
		}
		return 0;
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

	public void clear()
	{
		for (int i = 0; i < 105; i++)
		{
			m_dirData[i] = 0;
		}
		for (int i = 0; i < 657; i++)
		{
			m_kaidoData[i] = 0;
		}
		for (int i = 0; i < 13; i++)
		{
			m_reelData[i] = 0;
		}
		ulDedamaLotState = 0.0;
		ulDedamaLotStateOld = 0.0;
		m_mochiMedal = 0;
		m_creditMedal = 0;
		m_betMedal = 0;
		m_payoutMedal = 0;
		m_inMedal = 0;
		m_outMedal = 0;
		m_replay = false;
		tousenYaku = 0;
		gameCountArt = 0;
		artGameMax = 0;
		gameCount = 0;
		modeMain = 0;
		modeSub = 0;
		totalGameCount = 0;
		artCount = 0;
		bnsCount = 0;
		mode = 0;
		modeArt = 0;
		cycleGame = 0;
		cycleMode = 0;
		yaku = 0;
		FLTousen1 = 0;
		reelStep = 0;
		bonusGame = 0;
		artGame = 0;
		artCntContBtl = 0;
		artStockCnt = 0;
		artBtlWin = false;
		jgGame = 0;
		hohGame = 0;
		artCntVarGame = 0;
		hohChar = 0;
		hohTension = 0;
		hohRivalCharDamage = 0;
		hohSolCharDamage = 0;
		gbChargeCnt = 0;
		rbMap = 0;
		selectMachine = 0;
		m_State = 0;
		m_OldState = 0;
		m_StateChange = false;
		SerVerTime = 0u;
		AppTimer = 0u;
		m_Current = 0;
		m_Slump_game = new int[SlumpData.GAME_MAX / SlumpData.SAVE_GAME];
		m_Slump_medal = new int[SlumpData.GAME_MAX / SlumpData.SAVE_GAME];
		old_totalGameCount = 0;
		old_mochiMedal = 0;
		m_saveFlag = false;
	}

	public int getTotalGameCount()
	{
		int num = totalGameCount;
		if (m_State != 16 && ((long)ulDedamaLotState & 1) == 0L)
		{
			num--;
		}
		return num;
	}
}
