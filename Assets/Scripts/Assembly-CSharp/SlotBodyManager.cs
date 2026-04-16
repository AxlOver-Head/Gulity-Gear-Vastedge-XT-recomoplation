using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotBodyManager
{
	public enum STATE
	{
		STANDBY = 0,
		BET_ON = 1,
		BET_OFF = 2,
		LEVER_WAIT = 3,
		REEL_WAIT = 4,
		REEL_START = 5,
		REEL_MOVE1 = 6,
		REEL_STOP1 = 7,
		REEL_END1 = 8,
		REEL_NEXT1 = 9,
		REEL_MOVE2 = 10,
		REEL_STOP2 = 11,
		REEL_END2 = 12,
		REEL_NEXT2 = 13,
		REEL_MOVE3 = 14,
		REEL_STOP3 = 15,
		REEL_END3 = 16,
		REEL_OFF = 17,
		RESULT = 18,
		RESULT_END = 19,
		DORAGON_IN = 20
	}

	public enum DIRCOMMAND
	{
		NONE = 0,
		ONBET = 1,
		ONBET2 = 2,
		ONLEVERON = 3,
		ONLEVERON2 = 4,
		ONREELSTART = 5,
		ONREELSTART2 = 6,
		ONREEL1STOP = 7,
		ONREEL1STOP2 = 8,
		ONREEL2STOP = 9,
		ONREEL2STOP2 = 10,
		ONREEL3STOP = 11,
		ONREEL3STOP2 = 12,
		ONREEL3STOPOFF = 13,
		ONREEL3STOPOFF2 = 14,
		ONYTK = 15,
		CHANGESTAGEINTERFACE = 16,
		STOPDIRECTION = 17,
		STOPDIRECTIONALL = 18,
		INITDIRECTION = 19,
		SETDIRCOMMAND = 20
	}

	private struct DirManQueue
	{
		public DIRCOMMAND com;

		public int _arg0;

		public int _arg1;

		public int _arg2;

		public int _arg3;

		public int _arg4;

		public int _arg5;

		public int _arg6;

		public int _arg7;

		public int _arg8;

		public int _arg9;
	}

	private const int REEL_WAIT_MAX = 90;

	public STATE m_State;

	public STATE m_OldState;

	public bool m_StateChange;

	private int m_StateCnt;

	private int m_AutoCnt;

	private int m_ReelSelect;

	private int m_ReelWaitCnt;

	private int m_FreezeWaitCnt;

	private int m_ProdWaitCnt;

	private int m_RomanState;

	private List<MainObjPayMedal> m_PayMedalList;

	private GameObject m_UnderMedalSyo;

	private GameObject m_UnderMedalTyu;

	private GameObject m_UnderMedalDai;

	public SlotBodyLED_MaxBet m_LEDMaxBet = new SlotBodyLED_MaxBet();

	private SlotBodyLED_Stop m_LEDStop_L = new SlotBodyLED_Stop();

	private SlotBodyLED_Stop m_LEDStop_C = new SlotBodyLED_Stop();

	private SlotBodyLED_Stop m_LEDStop_R = new SlotBodyLED_Stop();

	public SlotBodySEG_Bet m_SEGBet = new SlotBodySEG_Bet();

	public SlotBodySEG_Pay m_SEGPay = new SlotBodySEG_Pay();

	public SlotBodySEG_Credit m_SEGCredit = new SlotBodySEG_Credit();

	public int dummy_stage;

	public int m_NowProdState;

	public int m_OldProdState;

	public int m_trgWait;

	private GameObject m_Area_Auto_Center;

	private GameObject m_Area_Auto_Bottom;

	private GameObject m_Area_Auto_MaxBet;

	private GameObject m_Area_Auto_MedalIn;

	private GameObject m_Area_Auto_Side_L;

	private GameObject m_Area_Auto_Side_R;

	public static bool notUpdate;

	private Queue dirQueue = new Queue();

	public void init()
	{
		dirQueue.Clear();
		m_LEDMaxBet.init();
		m_LEDStop_L.init(0);
		m_LEDStop_C.init(1);
		m_LEDStop_R.init(2);
		m_PayMedalList = new List<MainObjPayMedal>
		{
			Capacity = 32
		};
		m_PayMedalList.Clear();
		m_SEGBet.init();
		m_SEGPay.init();
		m_SEGCredit.init(MainGameScene.slotGameMan.m_creditMedal);
		m_UnderMedalSyo = GameObject.Find("kyoutai/medal/medal_syou");
		m_UnderMedalTyu = GameObject.Find("kyoutai/medal/medal_tyu");
		m_UnderMedalDai = GameObject.Find("kyoutai/medal/medal_dai");
		m_Area_Auto_Center = GameObject.Find("Area_Auto_Center");
		m_Area_Auto_Bottom = GameObject.Find("Area_Auto_Bottom");
		m_Area_Auto_MaxBet = GameObject.Find("Area_Auto_MaxBet");
		m_Area_Auto_MedalIn = GameObject.Find("Area_Auto_MedalIn");
		m_Area_Auto_Side_L = GameObject.Find("Area_Auto_Side_L");
		m_Area_Auto_Side_R = GameObject.Find("Area_Auto_Side_R");
		m_UnderMedalSyo.SetActive(true);
		m_UnderMedalTyu.SetActive(false);
		m_UnderMedalDai.SetActive(false);
		m_NowProdState = 0;
		m_OldProdState = m_NowProdState;
		m_trgWait = 0;
		m_FreezeWaitCnt = 0;
		m_ProdWaitCnt = 0;
	}

	public void control()
	{
		switch (m_State)
		{
		case STATE.BET_OFF:
			controlBetOff();
			break;
		case STATE.LEVER_WAIT:
			controlLeverWait();
			break;
		case STATE.REEL_WAIT:
			controlReelWait();
			break;
		case STATE.REEL_START:
			controlReelStart();
			break;
		case STATE.REEL_STOP1:
			controlReelStop1();
			break;
		case STATE.REEL_NEXT1:
			controlReelNext1();
			break;
		case STATE.REEL_STOP2:
			controlReelStop2();
			break;
		case STATE.REEL_NEXT2:
			controlReelNext2();
			break;
		case STATE.REEL_STOP3:
			controlReelStop3();
			break;
		case STATE.REEL_OFF:
			controlReelOff();
			break;
		case STATE.RESULT:
			controlResult();
			break;
		case STATE.RESULT_END:
			controlResultEnd();
			break;
		case STATE.DORAGON_IN:
			controlDoragonIn();
			break;
		}
		prodUpdate();
		int num = MainGameScene.slotGameMan.get_pdt_data(1);
		int num2 = MainGameScene.slotGameMan.get_pdt_data(5);
		int num3 = MainGameScene.slotGameMan.get_pdt_data(15);
		int num4 = MainGameScene.slotGameMan.get_pdt_data(45);
		int num5 = MainGameScene.slotGameMan.get_pdt_data(46);
		if (m_State != m_OldState)
		{
			m_OldState = m_State;
			if (m_State == STATE.REEL_START)
			{
				if (MainGameScene.m_PlaySaveData.m_configReelWait == 0 || MainGameScene.restartFlag)
				{
					m_ReelWaitCnt = 90;
				}
				else
				{
					m_ReelWaitCnt = 0;
				}
			}
			if (m_State == STATE.REEL_WAIT)
			{
				if (num == 70 && num2 == 1)
				{
					m_FreezeWaitCnt = 660;
					m_OldProdState = 2;
					dirManchangeStageInterface(11);
				}
				if (num == 31 && num2 == 1)
				{
					m_FreezeWaitCnt = 540;
					m_OldProdState = 2;
					dirManchangeStageInterface(11);
				}
				else if (MainGameScene.slotGameMan.getReelAction() != 0)
				{
					switch (MainGameScene.slotGameMan.getReelAction())
					{
					case 1:
						m_FreezeWaitCnt = 64;
						break;
					case 2:
						m_FreezeWaitCnt = 128;
						break;
					case 3:
						m_FreezeWaitCnt = 205;
						break;
					}
				}
				else if (num3 != 0)
				{
					m_FreezeWaitCnt = 30;
				}
				else if (MainGameScene.slotGameMan.getBnsSyoukaku() != 0 && !MainGameScene.restartFlag)
				{
					switch (MainGameScene.slotGameMan.getBnsSyoukaku())
					{
					case 55:
						m_FreezeWaitCnt = 147;
						break;
					case 59:
						m_FreezeWaitCnt = 500;
						break;
					case 64:
						m_FreezeWaitCnt = 500;
						break;
					}
				}
			}
			if (!MainGameScene.restartFlag)
			{
			}
		}
		else
		{
			m_StateCnt++;
		}
		if (m_ReelWaitCnt < 90)
		{
			m_ReelWaitCnt++;
		}
		if (m_FreezeWaitCnt > 0)
		{
			m_FreezeWaitCnt--;
			m_ReelWaitCnt = 89;
			if (m_FreezeWaitCnt == 0 && m_RomanState == 2)
			{
				m_RomanState = 0;
				MainGameScene.slotGameMan.set_pkd_data(496, 1);
				MainGameScene.slotGameMan.startLot_Prod();
				MainGameScene.lotMan.setCommand(5);
				dirManStopDirection(DirectionManager.DIR.STOP3OFF);
				dirManOnReel3StopOff(MainGameScene.lotMan.getHigh(LotManager.COMMAND.REEL1STOPOFF), MainGameScene.lotMan.getLow(LotManager.COMMAND.REEL1STOPOFF), MainGameScene.lotMan.getMode(LotManager.COMMAND.REEL1STOPOFF));
				dirManOnReel3StopOff2(MainGameScene.lotMan.getHigh(LotManager.COMMAND.REEL1STOPOFF_2), MainGameScene.lotMan.getLow(LotManager.COMMAND.REEL1STOPOFF_2), MainGameScene.lotMan.getMode(LotManager.COMMAND.REEL1STOPOFF_2));
				dirManchangeStageInterface(22);
				DirectionPanelLED.onCheck();
			}
			if (m_FreezeWaitCnt == 0 && (num4 == 4 || num4 == 5 || num4 == 6 || num4 == 26 || num4 == 27 || num4 == 28 || num4 == 29 || num4 == 30) && num5 == 9)
			{
				MainGameScene.lotMan.setCommand(6);
				dirManOnBet2(MainGameScene.lotMan.getHigh(LotManager.COMMAND.NEXTBET_2), MainGameScene.lotMan.getLow(LotManager.COMMAND.NEXTBET_2), MainGameScene.lotMan.getMode(LotManager.COMMAND.NEXTBET_2));
				DirectionPanelLED.onCheck();
				MainGameScene.slotGameMan.testlotlog(200);
			}
			if (m_FreezeWaitCnt == 0 && num == 31 && num2 == 1)
			{
				dirManchangeStageInterface(17);
			}
		}
		for (int num6 = m_PayMedalList.Count - 1; num6 >= 0; num6--)
		{
			m_PayMedalList[num6].control();
			if (!m_PayMedalList[num6].m_Active)
			{
				MainObjPayMedal mainObjPayMedal = m_PayMedalList[num6];
				m_PayMedalList.Remove(m_PayMedalList[num6]);
				Object.Destroy(mainObjPayMedal.gameObject);
			}
		}
	}

	public void setCurrentState(STATE state)
	{
		m_State = state;
		m_StateCnt = 0;
		m_StateChange = false;
	}

	private void controlStandBy()
	{
		if (SGLG.gameMode == SGLG.GAMEMODE.SIMULATION)
		{
			if (MainGameScene.slotGameMan.totalGameCount >= 99999)
			{
				MainGameScene.heiten_simulation();
				return;
			}
		}
		else if (UserData.saveData.hall.gameDayCnt >= 10000)
		{
			MainGameScene.heiten();
			return;
		}
		if (SGLG.isUpdateDirection && m_StateChange)
		{
			MainGameScene.yakuMan.start(YakuManager.KIND.MAXBET, 0);
			MainGameScene.slotGameMan.bet_on();
			MainGameScene.lotMan.startLot_Bet();
			MainGameScene.lotMan.setCommand(6);
			m_NowProdState = 0;
			DirectionPanelLED.onCheck();
			m_LEDMaxBet.setState(SlotBodyLED_MaxBet.STATE.OFF);
			setCurrentState(STATE.BET_ON);
			MainGameScene.yakuMan.returnCube();
			DirectionYakuManager.procBonusGD();
			MainGameScene.pnlMan.onDamage();
		}
	}

	private void controlBetOn()
	{
		if (m_StateChange || SGLGInput.isFree() || SGLGInput.isUp())
		{
			setCurrentState(STATE.BET_OFF);
		}
	}

	private void controlBetOff()
	{
		m_SEGBet.betOn(MainGameScene.slotGameMan.m_betMedal);
		m_SEGCredit.betOn(MainGameScene.slotGameMan.m_creditMedal);
		m_SEGPay.betOn();
		if (m_StateCnt >= 6)
		{
			setCurrentState(STATE.LEVER_WAIT);
		}
	}

	private void controlLeverWait()
	{
		if (!SGLG.isUpdateDirection)
		{
			return;
		}
		int num = MainGameScene.slotGameMan.get_pdt_data(45);
		int num2 = MainGameScene.slotGameMan.get_pdt_data(46);
		if (!m_StateChange)
		{
			return;
		}
		m_SEGBet.leverOn(MainGameScene.slotGameMan.m_betMedal);
		m_SEGCredit.leverOn(MainGameScene.slotGameMan.m_creditMedal);
		if (MainGameScene.slotGameMan.m_replay)
		{
			MainGameScene.yakuMan.returnCube();
			MainGameScene.yakuMan.returnJYD();
			if (!MainGameScene.restartFlag)
			{
				MainGameScene.slotGameMan.startLot_Bet();
				MainGameScene.lotMan.setCommand(6);
				MainGameScene.lotMan.setCommand(0);
				if (!MainGameScene.slotGameMan.isProdStay(100))
				{
					int num3 = MainGameScene.slotGameMan.get_pkd_data(438);
					int num4 = MainGameScene.slotGameMan.get_pkd_data(439);
					int num5 = MainGameScene.slotGameMan.get_pdt_data(45);
					long num6 = MainGameScene.slotGameMan.get_pkd_data_long(0);
					if (num3 == 0 && num4 == 25 && num5 == 19 && (num6 & 0x40) == 0L && (num6 & 0x20000) == 0L)
					{
						MainGameScene.lotMan.setCommand(6, 127, 0, 30);
					}
					dirManStopDirection();
					if (MainGameScene.slotGameMan.m_repArtLev == 0)
					{
						dirManOnBet2(MainGameScene.lotMan.getHigh(LotManager.COMMAND.NEXTBET_2), MainGameScene.lotMan.getLow(LotManager.COMMAND.NEXTBET_2), MainGameScene.lotMan.getMode(LotManager.COMMAND.NEXTBET_2));
						dirManOnBet(MainGameScene.lotMan.getHigh(LotManager.COMMAND.NEXTBET), MainGameScene.lotMan.getLow(LotManager.COMMAND.NEXTBET), MainGameScene.lotMan.getMode(LotManager.COMMAND.NEXTBET));
					}
					dirManInitDirection();
				}
			}
		}
		if (!MainGameScene.restartFlag)
		{
			MainGameScene.lotMan.startLot_LeverOn();
		}
		int num7 = MainGameScene.slotGameMan.get_pkd_data(86);
		if (MainGameScene.slotGameMan.getBnsSyoukaku() == 0)
		{
			int stage = MainGameScene.slotGameMan.m_dirData[45];
			dirManchangeStageInterface(stage);
		}
		if (MainGameScene.slotGameMan.get_pdt_data(45) == 9)
		{
			if (num7 != 5)
			{
				if ((num == 4 || num == 5 || num == 6 || num == 26 || num == 27 || num == 28 || num == 29 || num == 30) && num2 == 9)
				{
					MainGameScene.lotMan.setCommand(0, 127, 0, 2);
					dirManOnLeverOn(MainGameScene.lotMan.getHigh(LotManager.COMMAND.LEVER_ON), MainGameScene.lotMan.getLow(LotManager.COMMAND.LEVER_ON), MainGameScene.lotMan.getMode(LotManager.COMMAND.LEVER_ON));
				}
				else
				{
					MainGameScene.lotMan.setCommand(0, 127, 0, 1);
				}
				m_OldProdState = 3;
				m_NowProdState = 3;
			}
			else
			{
				MainGameScene.lotMan.setCommand(0);
				m_NowProdState = 3;
			}
		}
		else if (MainGameScene.slotGameMan.get_pdt_data(15) != 0 || MainGameScene.slotGameMan.getReelAction() != 0 || MainGameScene.slotGameMan.getBnsSyoukaku() != 0)
		{
			if ((num == 4 || num == 5 || num == 6 || num == 26 || num == 27 || num == 28 || num == 29 || num == 30) && num2 == 9)
			{
				MainGameScene.lotMan.setCommand(0, 127, 0, 2);
				dirManOnLeverOn(MainGameScene.lotMan.getHigh(LotManager.COMMAND.LEVER_ON), MainGameScene.lotMan.getLow(LotManager.COMMAND.LEVER_ON), MainGameScene.lotMan.getMode(LotManager.COMMAND.LEVER_ON));
			}
			else
			{
				MainGameScene.lotMan.setCommand(0, 127, 0, 1);
				dirManOnLeverOn(MainGameScene.lotMan.getHigh(LotManager.COMMAND.LEVER_ON), MainGameScene.lotMan.getLow(LotManager.COMMAND.LEVER_ON), MainGameScene.lotMan.getMode(LotManager.COMMAND.LEVER_ON));
			}
			dirManOnLeverOn2(MainGameScene.lotMan.getHigh(LotManager.COMMAND.LEVER_ON_2), MainGameScene.lotMan.getLow(LotManager.COMMAND.LEVER_ON_2), MainGameScene.lotMan.getMode(LotManager.COMMAND.LEVER_ON_2));
		}
		else
		{
			if (MainGameScene.slotGameMan.m_replay)
			{
				if (MainGameScene.slotGameMan.m_repArtLev != 0)
				{
					MainGameScene.lotMan.setCommand(0, 127, 0, 7);
				}
				else
				{
					m_OldProdState = 3;
					if (MainGameScene.slotGameMan.get_pkd_data(563) > 0)
					{
						dirManOnLeverOn2(MainGameScene.lotMan.getHigh(LotManager.COMMAND.LEVER_ON_2), MainGameScene.lotMan.getLow(LotManager.COMMAND.LEVER_ON_2), MainGameScene.lotMan.getMode(LotManager.COMMAND.LEVER_ON_2));
					}
				}
			}
			else if (MainGameScene.slotGameMan.m_repArtLev == 2)
			{
				MainGameScene.lotMan.setCommand(0, 127, 0, 7);
			}
			else
			{
				MainGameScene.lotMan.setCommand(0);
			}
			m_NowProdState = 3;
		}
		if (!MainGameScene.restartFlag)
		{
			MainGameScene.slotGameMan.lever_on();
		}
		MainGameScene.yakuMan.start(YakuManager.KIND.LEVER, 0);
		if (!MainGameScene.restartFlag)
		{
			MainGameScene.m_SlotSaveData.m_saveFlag = true;
			MainGameScene.m_SlotSaveData.set();
			slotUserSave_hall(0);
			MainGameScene.SlotDataSave();
		}
		if (MainGameScene.slotGameMan.get_pdt_data(45) == 9 && num7 != 5)
		{
			setCurrentState(STATE.DORAGON_IN);
		}
		else
		{
			setCurrentState(STATE.REEL_WAIT);
		}
		DirectionYakuManager.procBonusGD();
		DirectionLedManager.directionLedReset_lever();
		if (MainGameScene.slotGameMan.getBnsSyoukaku() == 0)
		{
			DirectionPanelLED.onCheck();
		}
		else
		{
			DirectionPanelLED.runMac2App(MainGameScene.slotGameMan.getBackLmp(), 0);
		}
	}

	private void controlReelWait()
	{
		if (MainGameScene.reelMan.isFreeze(0) || MainGameScene.reelMan.isFreeze(1) || MainGameScene.reelMan.isFreeze(2) || !SGLG.isUpdateDirection || m_ReelWaitCnt < 90)
		{
			return;
		}
		MainGameScene.lotMan.startLot_ReelStart();
		MainGameScene.lotMan.setCommand(1);
		m_NowProdState = 4;
		DirectionPanelLED.onCheck();
		if (!MainGameScene.restartFlag)
		{
			MainGameScene.m_SlotSaveData.set();
			slotUserSave_hall(0);
			MainGameScene.SlotDataSave();
		}
		setCurrentState(STATE.REEL_START);
		MainGameScene.pnlMan.onDamageLever(MainGameScene.slotGameMan.get_pkd_data(103), MainGameScene.slotGameMan.get_pkd_data(100));
		if (MainGameScene.slotGameMan.getBnsSyoukaku() != 0)
		{
			int num = MainGameScene.slotGameMan.get_pkd_data(86);
			if (num != 5 && num != 6)
			{
				int stage = MainGameScene.slotGameMan.m_dirData[45];
				dirManchangeStageInterface(stage);
			}
		}
	}

	private void controlReelStart()
	{
		MainGameScene.reelMan.OnReelStart(m_StateCnt);
		if (MainGameScene.reelMan.isReady)
		{
			m_LEDStop_L.setState(SlotBodyLED_Stop.STATE.BLUE);
			m_LEDStop_C.setState(SlotBodyLED_Stop.STATE.BLUE);
			m_LEDStop_R.setState(SlotBodyLED_Stop.STATE.BLUE);
			setCurrentState(STATE.REEL_MOVE1);
		}
	}

	private void controlReelMove1()
	{
		if (MainGameScene.reelMan.isFreeze(0) || MainGameScene.reelMan.isFreeze(1) || MainGameScene.reelMan.isFreeze(2) || !m_StateChange)
		{
			return;
		}
		if (MainGameScene.restartFlag)
		{
			int reelStopNum = MainGameScene.m_SlotSaveData.getReelStopNum(m_ReelSelect);
			if (!MainGameScene.reelMan.isSameStep(m_ReelSelect, reelStopNum))
			{
				return;
			}
		}
		MainGameScene.reelMan.OnReelStop(m_ReelSelect);
		m_LEDStop_L.setState(SlotBodyLED_Stop.STATE.RED);
		m_LEDStop_C.setState(SlotBodyLED_Stop.STATE.RED);
		m_LEDStop_R.setState(SlotBodyLED_Stop.STATE.RED);
		MainGameScene.yakuMan.start((YakuManager.KIND)(1 + m_ReelSelect), 0);
		setCurrentState(STATE.REEL_STOP1);
	}

	private void controlReelStop1()
	{
		if (SGLG.isUpdateDirection && !MainGameScene.reelMan.isMove(m_ReelSelect))
		{
			MainGameScene.slotGameMan.startLot_ReelStop(0, m_ReelSelect);
			switch (m_ReelSelect)
			{
			case 0:
				MainGameScene.slotGameMan.startLot_Reel1(0);
				break;
			case 1:
				MainGameScene.slotGameMan.startLot_Reel2(0);
				break;
			case 2:
				MainGameScene.slotGameMan.startLot_Reel3(0);
				break;
			}
			MainGameScene.lotMan.startLot_Reel1();
			MainGameScene.lotMan.setCommand(2);
			if (MainGameScene.slotGameMan.m_repArtLev != 0 && MainGameScene.slotGameMan.m_dirData[1] == 0)
			{
				MainGameScene.lotMan.setCommand(2, 127, 0, 2);
			}
			m_NowProdState = 7;
			DirectionPanelLED.onCheck();
			if (!MainGameScene.restartFlag)
			{
				MainGameScene.m_SlotSaveData.set();
				slotUserSave_hall(0);
				MainGameScene.SlotDataSave();
			}
			setCurrentState(STATE.REEL_END1);
		}
	}

	private void controlReelEnd1()
	{
		if (m_StateChange || SGLGInput.isFree() || SGLGInput.isUp())
		{
			MainGameScene.yakuMan.start((YakuManager.KIND)(1 + m_ReelSelect), 1);
			if (MainGameScene.reelMan.isMove(0))
			{
				m_LEDStop_L.setState(SlotBodyLED_Stop.STATE.BLUE);
			}
			if (MainGameScene.reelMan.isMove(1))
			{
				m_LEDStop_C.setState(SlotBodyLED_Stop.STATE.BLUE);
			}
			if (MainGameScene.reelMan.isMove(2))
			{
				m_LEDStop_R.setState(SlotBodyLED_Stop.STATE.BLUE);
			}
			setCurrentState(STATE.REEL_NEXT1);
		}
	}

	private void controlReelNext1()
	{
		if (m_StateCnt >= 4)
		{
			setCurrentState(STATE.REEL_MOVE2);
		}
	}

	private void controlReelMove2()
	{
		if (MainGameScene.reelMan.isFreeze(0) || MainGameScene.reelMan.isFreeze(1) || MainGameScene.reelMan.isFreeze(2) || !m_StateChange)
		{
			return;
		}
		if (MainGameScene.restartFlag)
		{
			int reelStopNum = MainGameScene.m_SlotSaveData.getReelStopNum(m_ReelSelect);
			if (!MainGameScene.reelMan.isSameStep(m_ReelSelect, reelStopNum))
			{
				return;
			}
		}
		MainGameScene.reelMan.OnReelStop(m_ReelSelect);
		m_LEDStop_L.setState(SlotBodyLED_Stop.STATE.RED);
		m_LEDStop_C.setState(SlotBodyLED_Stop.STATE.RED);
		m_LEDStop_R.setState(SlotBodyLED_Stop.STATE.RED);
		MainGameScene.yakuMan.start((YakuManager.KIND)(1 + m_ReelSelect), 0);
		setCurrentState(STATE.REEL_STOP2);
	}

	private void controlReelStop2()
	{
		if (SGLG.isUpdateDirection && !MainGameScene.reelMan.isMove(m_ReelSelect))
		{
			MainGameScene.slotGameMan.startLot_ReelStop(1, m_ReelSelect);
			switch (m_ReelSelect)
			{
			case 0:
				MainGameScene.slotGameMan.startLot_Reel1(1);
				break;
			case 1:
				MainGameScene.slotGameMan.startLot_Reel2(1);
				break;
			case 2:
				MainGameScene.slotGameMan.startLot_Reel3(1);
				break;
			}
			MainGameScene.lotMan.startLot_Reel2();
			MainGameScene.lotMan.setCommand(3);
			m_NowProdState = 11;
			DirectionPanelLED.onCheck();
			if (!MainGameScene.restartFlag)
			{
				MainGameScene.m_SlotSaveData.set();
				slotUserSave_hall(0);
				MainGameScene.SlotDataSave();
			}
			setCurrentState(STATE.REEL_END2);
		}
	}

	private void controlReelEnd2()
	{
		if (m_StateChange || SGLGInput.isFree() || SGLGInput.isUp())
		{
			MainGameScene.yakuMan.start((YakuManager.KIND)(1 + m_ReelSelect), 1);
			if (MainGameScene.reelMan.isMove(0))
			{
				m_LEDStop_L.setState(SlotBodyLED_Stop.STATE.BLUE);
			}
			if (MainGameScene.reelMan.isMove(1))
			{
				m_LEDStop_C.setState(SlotBodyLED_Stop.STATE.BLUE);
			}
			if (MainGameScene.reelMan.isMove(2))
			{
				m_LEDStop_R.setState(SlotBodyLED_Stop.STATE.BLUE);
			}
			setCurrentState(STATE.REEL_NEXT2);
		}
	}

	private void controlReelNext2()
	{
		if (m_StateCnt >= 4)
		{
			setCurrentState(STATE.REEL_MOVE3);
		}
	}

	private void controlReelMove3()
	{
		if (MainGameScene.reelMan.isFreeze(0) || MainGameScene.reelMan.isFreeze(1) || MainGameScene.reelMan.isFreeze(2) || !m_StateChange)
		{
			return;
		}
		if (MainGameScene.restartFlag)
		{
			int reelStopNum = MainGameScene.m_SlotSaveData.getReelStopNum(m_ReelSelect);
			if (!MainGameScene.reelMan.isSameStep(m_ReelSelect, reelStopNum))
			{
				return;
			}
		}
		MainGameScene.reelMan.OnReelStop(m_ReelSelect);
		m_LEDStop_L.setState(SlotBodyLED_Stop.STATE.RED);
		m_LEDStop_C.setState(SlotBodyLED_Stop.STATE.RED);
		m_LEDStop_R.setState(SlotBodyLED_Stop.STATE.RED);
		MainGameScene.yakuMan.start((YakuManager.KIND)(1 + m_ReelSelect), 0);
		setCurrentState(STATE.REEL_STOP3);
	}

	private void controlReelStop3()
	{
		if (SGLG.isUpdateDirection && !MainGameScene.reelMan.isMove(m_ReelSelect))
		{
			MainGameScene.slotGameMan.startLot_ReelStop(2, m_ReelSelect);
			switch (m_ReelSelect)
			{
			case 0:
				MainGameScene.slotGameMan.startLot_Reel1(2);
				break;
			case 1:
				MainGameScene.slotGameMan.startLot_Reel2(2);
				break;
			case 2:
				MainGameScene.slotGameMan.startLot_Reel3(2);
				break;
			}
			MainGameScene.lotMan.startLot_Reel3();
			MainGameScene.lotMan.setCommand(4);
			m_NowProdState = 15;
			DirectionPanelLED.onCheck();
			setCurrentState(STATE.REEL_END3);
			int num = MainGameScene.slotGameMan.get_pkd_data(86);
			int num2 = MainGameScene.slotGameMan.get_pkd_data(438);
			if (num == 6 && num2 == 0)
			{
				m_RomanState = 1;
			}
			if (MainGameScene.slotGameMan.get_koyaku_prm(2) >= 2 && 4 >= MainGameScene.slotGameMan.get_koyaku_prm(2) && MainGameScene.slotGameMan.get_koyaku_prm(0) == 0)
			{
				MainGameScene.pnlMan.onDamageLever(MainGameScene.slotGameMan.get_pkd_data(103), MainGameScene.slotGameMan.get_pkd_data(100));
			}
		}
	}

	private void controlReelEnd3()
	{
		if (m_StateChange || SGLGInput.isFree() || SGLGInput.isUp())
		{
			MainGameScene.slotGameMan.startLot_Reel3off();
			MainGameScene.lotMan.startLot_Reel3off();
			MainGameScene.lotMan.setCommand(5);
			m_NowProdState = 16;
			DirectionPanelLED.onCheck();
			m_SEGBet.stop3Off();
			MainGameScene.yakuMan.start((YakuManager.KIND)(1 + m_ReelSelect), 1);
			MainGameScene.dirLedMan.setKoyakuLED(MainGameScene.slotGameMan.get_pdt_data(92));
			MainGameScene.slotGameMan.set_pdt_data(92, 0);
			if (!MainGameScene.restartFlag)
			{
				MainGameScene.m_SlotSaveData.set();
				slotUserSave_hall(0);
				MainGameScene.SlotDataSave();
			}
			setCurrentState(STATE.REEL_OFF);
			int num = MainGameScene.slotGameMan.get_pdt_data(45);
			int num2 = MainGameScene.slotGameMan.get_pdt_data(46);
			if ((num == 4 || num == 5 || num == 6 || num == 26 || num == 27 || num == 28 || num == 29 || num == 30) && num2 == 9)
			{
				m_FreezeWaitCnt = 480;
				dirManchangeStageInterface(11);
			}
			if (m_RomanState == 1)
			{
				m_RomanState = 2;
				m_FreezeWaitCnt = 360;
			}
		}
	}

	private void controlReelOff()
	{
		if (m_FreezeWaitCnt <= 0)
		{
			MainGameScene.reelMan.OnAllStop();
			m_LEDStop_L.setState(SlotBodyLED_Stop.STATE.RED);
			m_LEDStop_C.setState(SlotBodyLED_Stop.STATE.RED);
			m_LEDStop_R.setState(SlotBodyLED_Stop.STATE.RED);
			setCurrentState(STATE.RESULT);
		}
	}

	private void controlResult()
	{
		int num = 5;
		if (m_FreezeWaitCnt > 0)
		{
			return;
		}
		m_SEGCredit.result(MainGameScene.slotGameMan.m_creditMedal);
		if (m_SEGPay.result(MainGameScene.slotGameMan.m_payoutMedal))
		{
			payMedal();
			num = 1;
			m_StateCnt = 0;
		}
		if (m_StateCnt >= num)
		{
			setCurrentState(STATE.RESULT_END);
			if (MainGameScene.slotGameMan.m_mochiMedal <= 50)
			{
				m_UnderMedalSyo.SetActive(true);
				m_UnderMedalTyu.SetActive(false);
				m_UnderMedalDai.SetActive(false);
			}
			else if (MainGameScene.slotGameMan.m_mochiMedal <= 499)
			{
				m_UnderMedalSyo.SetActive(true);
				m_UnderMedalTyu.SetActive(true);
				m_UnderMedalDai.SetActive(false);
			}
			else
			{
				m_UnderMedalSyo.SetActive(true);
				m_UnderMedalTyu.SetActive(true);
				m_UnderMedalDai.SetActive(true);
			}
		}
	}

	private void controlResultEnd()
	{
		if (MainGameScene.slotGameMan.m_replay)
		{
			int num = 15;
			int num2 = MainGameScene.slotGameMan.get_koyaku_prm(2);
			int num3 = MainGameScene.slotGameMan.get_pdt_data(45);
			if (29 <= num2 && num2 <= 33 && num3 == 4)
			{
				num = 75;
			}
			int num4 = MainGameScene.slotGameMan.get_pkd_data(335);
			if (9 <= num2 && num2 <= 12 && num4 == 3)
			{
				num = 180;
			}
			if (13 <= num2 && num2 <= 16 && num4 == 2)
			{
				num = 180;
			}
			if (17 <= num2 && num2 <= 20 && num4 == 1)
			{
				num = 180;
			}
			if (m_StateCnt >= num - 3)
			{
				m_SEGBet.result(MainGameScene.slotGameMan.get_koyaku_prm(2));
			}
			if (m_StateCnt >= num)
			{
				if (MainGameScene.slotGameMan.get_pkd_data(563) > 0 && (MainGameScene.slotGameMan.m_dirData[1] != 87 || MainGameScene.slotGameMan.m_dirData[5] != 24))
				{
					dirManOnBet2(MainGameScene.lotMan.getHigh(LotManager.COMMAND.NEXTBET_2), MainGameScene.lotMan.getLow(LotManager.COMMAND.NEXTBET_2), MainGameScene.lotMan.getMode(LotManager.COMMAND.NEXTBET_2));
				}
				setCurrentState(STATE.BET_OFF);
				if (SGLG.gameMode == SGLG.GAMEMODE.HALL)
				{
					MainGameScene.slotGameMan.setHallPrm();
				}
				else
				{
					MainGameScene.slotGameMan.setSimulationPrm();
				}
			}
		}
		else
		{
			setCurrentState(STATE.STANDBY);
			if (SGLG.gameMode == SGLG.GAMEMODE.HALL)
			{
				MainGameScene.slotGameMan.setHallPrm();
			}
			else
			{
				MainGameScene.slotGameMan.setSimulationPrm();
			}
			m_LEDMaxBet.setState(SlotBodyLED_MaxBet.STATE.ON);
		}
	}

	private void controlDoragonIn()
	{
		switch (MainGameScene.slotGameMan.M_DraIn_DRIN_PROD())
		{
		case 2:
			if (MainGameScene.slotGameMan.m_drinFukki)
			{
				MainGameScene.slotGameMan.m_drinFukki = false;
				MainGameScene.slotGameMan.lmpDrInCmd(0);
				if (MainGameScene.restartDest != STATE.LEVER_WAIT)
				{
					setCurrentState(STATE.REEL_WAIT);
					m_StateCnt = 0;
					break;
				}
				m_StateCnt = 241;
				MainGameScene.reelMan.setStep(0, 3);
				MainGameScene.reelMan.setStep(1, 15);
				MainGameScene.reelMan.setStep(2, 6);
			}
			if (m_StateCnt > 420 && 510 > m_StateCnt && m_StateChange)
			{
				if (MainGameScene.reelMan.isFreeze(0) || MainGameScene.reelMan.isFreeze(1) || MainGameScene.reelMan.isFreeze(2) || !SGLG.isUpdateDirection)
				{
					break;
				}
				m_StateCnt = 510;
				m_StateChange = false;
			}
			switch (m_StateCnt)
			{
			case 0:
				MainGameScene.slotGameMan.set_pdt_data(15, 13);
				MainGameScene.lotMan.setFukugoCommand(0);
				dirManOnLeverOn2(MainGameScene.lotMan.getHigh(LotManager.COMMAND.LEVER_ON_2), MainGameScene.lotMan.getLow(LotManager.COMMAND.LEVER_ON_2), MainGameScene.lotMan.getMode(LotManager.COMMAND.LEVER_ON_2));
				DirectionPanelLED.onCheck();
				MainGameScene.slotGameMan.lmpDrInCmd(0);
				MainGameScene.slotGameMan.M_DraIn_DRIN_RP_First();
				if (!MainGameScene.restartFlag)
				{
					m_State = STATE.LEVER_WAIT;
					MainGameScene.m_SlotSaveData.set();
					slotUserSave_hall(0);
					MainGameScene.SlotDataSave();
					m_State = STATE.DORAGON_IN;
				}
				break;
			case 241:
				MainGameScene.lotMan.setCommand(7, 94, 0, 1);
				dirManOnLeverOn2(MainGameScene.lotMan.getHigh(LotManager.COMMAND.LEVER_ON_2), MainGameScene.lotMan.getLow(LotManager.COMMAND.LEVER_ON_2), MainGameScene.lotMan.getMode(LotManager.COMMAND.LEVER_ON_2));
				DirectionPanelLED.onCheck();
				MainGameScene.reelMan.FreezeReelAct8_1();
				DirectionPanelLED.runMac2App(5, 1);
				DirectionPanelLED.runMac2App(73, 0);
				break;
			case 420:
				MainGameScene.slotGameMan.set_pdt_data(15, 14);
				MainGameScene.lotMan.setFukugoCommand(0);
				dirManOnLeverOn2(MainGameScene.lotMan.getHigh(LotManager.COMMAND.LEVER_ON_2), MainGameScene.lotMan.getLow(LotManager.COMMAND.LEVER_ON_2), MainGameScene.lotMan.getMode(LotManager.COMMAND.LEVER_ON_2));
				DirectionPanelLED.onCheck();
				MainGameScene.slotGameMan.M_DraIn_DRIN_RP_Wait();
				m_StateChange = false;
				break;
			case 510:
				if (MainGameScene.slotGameMan.getDI0GLoop() != 0)
				{
					MainGameScene.slotGameMan.M_DraIn_DRIN_RP_First();
					if (!MainGameScene.restartFlag)
					{
						m_State = STATE.LEVER_WAIT;
						MainGameScene.m_SlotSaveData.set();
						slotUserSave_hall(0);
						MainGameScene.SlotDataSave();
						m_State = STATE.DORAGON_IN;
					}
					if (MainGameScene.slotGameMan.getDI0GLoop() == 1)
					{
						m_StateCnt = 240;
					}
					MainGameScene.slotGameMan.testlotlog(200);
				}
				else
				{
					m_State = STATE.REEL_WAIT;
					if (!MainGameScene.restartFlag)
					{
						MainGameScene.m_SlotSaveData.set();
						slotUserSave_hall(0);
						MainGameScene.SlotDataSave();
					}
					m_State = STATE.DORAGON_IN;
				}
				m_StateChange = false;
				break;
			case 511:
				MainGameScene.slotGameMan.set_pdt_data(15, 15);
				MainGameScene.lotMan.setFukugoCommand(0);
				dirManOnLeverOn2(MainGameScene.lotMan.getHigh(LotManager.COMMAND.LEVER_ON_2), MainGameScene.lotMan.getLow(LotManager.COMMAND.LEVER_ON_2), MainGameScene.lotMan.getMode(LotManager.COMMAND.LEVER_ON_2));
				DirectionPanelLED.onCheck();
				DirectionPanelLED.runMac2App(6, 1);
				DirectionPanelLED.runMac2App(0, 8);
				break;
			case 631:
				if (MainGameScene.slotGameMan.getDI0GLoop() == 2)
				{
					m_StateCnt = 240;
					break;
				}
				setCurrentState(STATE.REEL_WAIT);
				m_StateCnt = 0;
				if (!MainGameScene.restartFlag)
				{
					MainGameScene.m_SlotSaveData.set();
					slotUserSave_hall(0);
					MainGameScene.SlotDataSave();
				}
				break;
			}
			break;
		case 1:
			if (MainGameScene.slotGameMan.m_drinFukki)
			{
				MainGameScene.slotGameMan.m_drinFukki = false;
				m_StateCnt = 140;
				MainGameScene.slotGameMan.lmpDrInCmd(0);
			}
			switch (m_StateCnt)
			{
			case 0:
				MainGameScene.lotMan.setCommand(7, 17, 1, 6);
				dirManOnLeverOn2(MainGameScene.lotMan.getHigh(LotManager.COMMAND.LEVER_ON_2), MainGameScene.lotMan.getLow(LotManager.COMMAND.LEVER_ON_2), MainGameScene.lotMan.getMode(LotManager.COMMAND.LEVER_ON_2));
				DirectionPanelLED.onCheck();
				MainGameScene.slotGameMan.lmpDrInCmd(0);
				break;
			case 140:
				setCurrentState(STATE.REEL_WAIT);
				m_StateCnt = 0;
				MainGameScene.dirMan.StopDirection(DirectionManager.DIR.LEVER_2);
				break;
			}
			break;
		default:
			if (MainGameScene.slotGameMan.m_drinFukki)
			{
				MainGameScene.slotGameMan.m_drinFukki = false;
				m_StateCnt = 80;
				MainGameScene.slotGameMan.lmpDrInCmd(0);
			}
			switch (m_StateCnt)
			{
			case 0:
				MainGameScene.lotMan.setCommand(7, 17, 1, 5);
				dirManOnLeverOn2(MainGameScene.lotMan.getHigh(LotManager.COMMAND.LEVER_ON_2), MainGameScene.lotMan.getLow(LotManager.COMMAND.LEVER_ON_2), MainGameScene.lotMan.getMode(LotManager.COMMAND.LEVER_ON_2));
				DirectionPanelLED.onCheck();
				MainGameScene.slotGameMan.lmpDrInCmd(0);
				break;
			case 80:
				setCurrentState(STATE.REEL_WAIT);
				m_StateCnt = 0;
				MainGameScene.dirMan.StopDirection(DirectionManager.DIR.LEVER_2);
				break;
			}
			break;
		}
	}

	public void execReel1()
	{
		if (notUpdate)
		{
			return;
		}
		STATE state = m_State;
		if (state == STATE.REEL_MOVE1 || state == STATE.REEL_MOVE2 || state == STATE.REEL_MOVE3)
		{
			if (MainGameScene.reelMan.isMove(0))
			{
				m_ReelSelect = 0;
				m_StateChange = true;
				notUpdate = true;
			}
		}
		else
		{
			SGLGDebugLot.debugYaku(0);
		}
	}

	public void execReel2()
	{
		if (notUpdate)
		{
			return;
		}
		STATE state = m_State;
		if (state == STATE.REEL_MOVE1 || state == STATE.REEL_MOVE2 || state == STATE.REEL_MOVE3)
		{
			if (MainGameScene.reelMan.isMove(1))
			{
				m_ReelSelect = 1;
				m_StateChange = true;
				notUpdate = true;
			}
		}
		else
		{
			SGLGDebugLot.debugYaku(1);
		}
	}

	public void execReel3()
	{
		if (notUpdate)
		{
			return;
		}
		STATE state = m_State;
		if (state == STATE.REEL_MOVE1 || state == STATE.REEL_MOVE2 || state == STATE.REEL_MOVE3)
		{
			if (MainGameScene.reelMan.isMove(2))
			{
				m_ReelSelect = 2;
				m_StateChange = true;
				notUpdate = true;
			}
		}
		else
		{
			SGLGDebugLot.debugYaku(2);
		}
	}

	public void execAuto()
	{
		if (notUpdate)
		{
			return;
		}
		switch (m_State)
		{
		case STATE.STANDBY:
			m_StateChange = true;
			notUpdate = true;
			break;
		case STATE.BET_ON:
			m_StateChange = true;
			notUpdate = true;
			break;
		case STATE.LEVER_WAIT:
			m_StateChange = true;
			notUpdate = true;
			break;
		case STATE.REEL_MOVE1:
			reelStopControl(0);
			break;
		case STATE.REEL_END1:
			m_StateChange = true;
			notUpdate = true;
			break;
		case STATE.REEL_MOVE2:
			reelStopControl(1);
			break;
		case STATE.REEL_END2:
			m_StateChange = true;
			notUpdate = true;
			break;
		case STATE.REEL_MOVE3:
			reelStopControl(2);
			break;
		case STATE.REEL_END3:
			m_StateChange = true;
			notUpdate = true;
			break;
		case STATE.DORAGON_IN:
			if (m_StateCnt > 420 && 510 > m_StateCnt)
			{
				m_StateChange = true;
				notUpdate = true;
			}
			break;
		}
	}

	public void keyEvent()
	{
		if (MainCameraManager.mode == MainCameraManager.MODE.NONE)
		{
			if (!SGLGInput.isFree())
			{
				float x = (float)SGLG.scrW * SGLGInput.x / (float)SGLGInput.BASE_W;
				float y = (float)SGLG.scrH * SGLGInput.y / (float)SGLGInput.BASE_H;
				Vector2 vector = new Vector2(x, y);
				RaycastHit hitInfo = default(RaycastHit);
				Ray ray = Camera.main.ScreenPointToRay(vector);
				if (Physics.Raycast(ray, out hitInfo, 10f, 256))
				{
					TouchableObj touchableObj = (TouchableObj)hitInfo.transform.gameObject.GetComponent("TouchableObj");
					if (SGLGInput.isPush())
					{
						touchableObj.Pushed(0);
					}
					else if (SGLGInput.isHold())
					{
						if (touchableObj.transform.gameObject == m_Area_Auto_Center || touchableObj.transform.gameObject == m_Area_Auto_Bottom || touchableObj.transform.gameObject == m_Area_Auto_MaxBet || touchableObj.transform.gameObject == m_Area_Auto_MedalIn || touchableObj.transform.gameObject == m_Area_Auto_Side_L || touchableObj.transform.gameObject == m_Area_Auto_Side_R)
						{
							touchableObj.Held(m_AutoCnt);
							m_AutoCnt++;
						}
						else
						{
							touchableObj.Held(0);
							m_AutoCnt = 0;
						}
					}
					else if (SGLGInput.isUp())
					{
						touchableObj.Upped(0);
					}
				}
			}
			else if (MainGameScene.m_PlaySaveData.m_autoSettei == 4)
			{
				m_AutoCnt = 0;
				MainObjAuto.touched = false;
			}
		}
		if (MainObjAuto.isExec())
		{
			MainGameScene.execAuto();
		}
		else if (MainObjPushButton.isExec())
		{
			MainGameScene.execPush();
		}
		else if (MainObjReel1.isExec())
		{
			MainGameScene.execReel1();
		}
		else if (MainObjReel2.isExec())
		{
			MainGameScene.execReel2();
		}
		else if (MainObjReel3.isExec())
		{
			MainGameScene.execReel3();
		}
		switch (m_State)
		{
		case STATE.STANDBY:
			controlStandBy();
			break;
		case STATE.BET_ON:
			controlBetOn();
			break;
		case STATE.REEL_MOVE1:
			controlReelMove1();
			break;
		case STATE.REEL_END1:
			controlReelEnd1();
			break;
		case STATE.REEL_MOVE2:
			controlReelMove2();
			break;
		case STATE.REEL_END2:
			controlReelEnd2();
			break;
		case STATE.REEL_MOVE3:
			controlReelMove3();
			break;
		case STATE.REEL_END3:
			controlReelEnd3();
			break;
		}
	}

	public void payMedal()
	{
		GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("prefabs/paymedal"), new Vector3(1000f, 0.05f, -0.07f), Quaternion.Euler(100f, 0f, -180f));
		MainObjPayMedal mainObjPayMedal = (MainObjPayMedal)gameObject.GetComponent("MainObjPayMedal");
		mainObjPayMedal.init();
		m_PayMedalList.Add(mainObjPayMedal);
	}

	public void reelStopControl(int _num)
	{
		int[][] array = new int[6][]
		{
			new int[3] { 0, 1, 2 },
			new int[3] { 0, 2, 1 },
			new int[3] { 1, 0, 2 },
			new int[3] { 2, 1, 0 },
			new int[3] { 2, 0, 1 },
			new int[3] { 1, 2, 0 }
		};
		int[] array2 = new int[3] { 11, 6, 11 };
		int[] array3 = new int[3] { 6, 5, 10 };
		int[] array4 = new int[3] { 17, 18, 18 };
		int[] array5 = new int[3] { 11, 11, 2 };
		int[] array6 = new int[3] { 2, 14, 5 };
		byte autoLevel = MainGameScene.m_PlaySaveData.m_autoLevel;
		byte b = MainGameScene.m_PlaySaveData.m_autoSettei;
		byte configOshi = MainGameScene.m_PlaySaveData.m_configOshi;
		int num = MainGameScene.slotGameMan.get_pdt_data(16);
		int num2 = MainGameScene.slotGameMan.get_pdt_data(18);
		bool flag = false;
		bool flag2 = true;
		int num3 = MainGameScene.slotGameMan.get_pkd_data(86);
		if (MainObjAuto.isExecAuto())
		{
			b = 0;
		}
		int num4 = array[configOshi][_num];
		if (MainGameScene.restartFlag)
		{
			num4 = MainGameScene.m_SlotSaveData.m_reelPushOrder[_num];
			if (num4 < 0 || 2 < num4)
			{
				num4 = 0;
			}
		}
		if (MainGameScene.reelMan.isStopTiming(num4, array2[num4]))
		{
			flag = true;
		}
		if (num3 == 5 && b != 4 && MainGameScene.slotGameMan.get_koyaku_prm(1) == 1 && MainGameScene.slotGameMan.get_koyaku_prm(2) == 0)
		{
			if (MainGameScene.reelMan.isStopTiming(num4, array3[num4]))
			{
				flag = true;
				flag2 = true;
			}
			else
			{
				flag2 = false;
			}
		}
		int num5 = 0;
		if (MainGameScene.slotGameMan.getNaviProc())
		{
			for (num5 = 0; num5 < 3; num5++)
			{
				if (MainGameScene.reelMan.isMove(num5))
				{
					m_ReelSelect = num5;
					m_StateChange = true;
					break;
				}
			}
		}
		else if (num != 0 || num2 != 0 || MainGameScene.slotGameMan.getDirDestroy())
		{
			int num6 = MainGameScene.lotMan.reelStopNum(_num);
			int num7 = num6;
			if (b != 4)
			{
				if (num3 == 5 && !flag2)
				{
					return;
				}
				if (MainGameScene.slotGameMan.getDirDestroy())
				{
					if (MainGameScene.restartFlag)
					{
						num7 = num4;
					}
					if (!MainGameScene.reelMan.isStopTiming(num7, array6[num7]))
					{
						return;
					}
					num6 = num7;
				}
				switch (num)
				{
				case 286:
				case 287:
					if (MainGameScene.restartFlag)
					{
						num7 = num4;
					}
					if (MainGameScene.reelMan.isStopTiming(num7, array4[num7]))
					{
						num6 = num7;
						break;
					}
					return;
				case 282:
				case 283:
					if (MainGameScene.restartFlag)
					{
						num7 = num4;
					}
					if (MainGameScene.reelMan.isStopTiming(num7, array5[num7]))
					{
						num6 = num7;
						break;
					}
					return;
				}
			}
			m_ReelSelect = num6;
			m_StateChange = true;
			if (MainGameScene.reelMan.isMove(m_ReelSelect))
			{
				return;
			}
			for (num5 = 0; num5 < 3; num5++)
			{
				if (MainGameScene.reelMan.isMove(num5))
				{
					m_ReelSelect = num5;
					break;
				}
			}
		}
		else if ((b == 4 || (b != 4 && autoLevel == 0) || (b != 4 && autoLevel == 1 && flag)) && (b == 4 || num3 != 5 || flag2))
		{
			if (MainGameScene.reelMan.isMove(num4))
			{
				m_ReelSelect = num4;
			}
			else if (MainGameScene.reelMan.isMove(0))
			{
				m_ReelSelect = 0;
			}
			else if (MainGameScene.reelMan.isMove(1))
			{
				m_ReelSelect = 1;
			}
			else if (MainGameScene.reelMan.isMove(2))
			{
				m_ReelSelect = 2;
			}
			m_StateChange = true;
		}
	}

	public void prodUpdate()
	{
		int num = 0;
		byte b = 0;
		byte b2 = 0;
		byte b3 = 0;
		if (m_NowProdState == m_OldProdState)
		{
			return;
		}
		if (m_trgWait == 0 || m_NowProdState == 3)
		{
			m_OldProdState = m_NowProdState;
			if (MainGameScene.slotGameMan.get_pdt_data(34) != 0)
			{
				dirManOnYTK(MainGameScene.lotMan.getHigh(LotManager.COMMAND.YTK_YAKUTAN), MainGameScene.lotMan.getLow(LotManager.COMMAND.YTK_YAKUTAN), MainGameScene.lotMan.getMode(LotManager.COMMAND.YTK_YAKUTAN));
			}
			switch (m_NowProdState)
			{
			case 0:
				if (MainGameScene.slotGameMan.m_dirData[1] != 87 || MainGameScene.slotGameMan.m_dirData[5] != 24)
				{
					dirManOnBet(MainGameScene.lotMan.getHigh(LotManager.COMMAND.NEXTBET), MainGameScene.lotMan.getLow(LotManager.COMMAND.NEXTBET), MainGameScene.lotMan.getMode(LotManager.COMMAND.NEXTBET));
					dirManOnBet2(MainGameScene.lotMan.getHigh(LotManager.COMMAND.NEXTBET_2), MainGameScene.lotMan.getLow(LotManager.COMMAND.NEXTBET_2), MainGameScene.lotMan.getMode(LotManager.COMMAND.NEXTBET_2));
				}
				break;
			case 3:
				Resources.UnloadUnusedAssets();
				dirManOnLeverOn(MainGameScene.lotMan.getHigh(LotManager.COMMAND.LEVER_ON), MainGameScene.lotMan.getLow(LotManager.COMMAND.LEVER_ON), MainGameScene.lotMan.getMode(LotManager.COMMAND.LEVER_ON));
				dirManOnLeverOn2(MainGameScene.lotMan.getHigh(LotManager.COMMAND.LEVER_ON_2), MainGameScene.lotMan.getLow(LotManager.COMMAND.LEVER_ON_2), MainGameScene.lotMan.getMode(LotManager.COMMAND.LEVER_ON_2));
				num = 1;
				b = MainGameScene.lotMan.getHigh(LotManager.COMMAND.REEL_START);
				b2 = MainGameScene.lotMan.getLow(LotManager.COMMAND.REEL_START);
				b3 = MainGameScene.lotMan.getMode(LotManager.COMMAND.REEL_START);
				break;
			case 4:
				dirManOnReelStart(MainGameScene.lotMan.getHigh(LotManager.COMMAND.REEL_START), MainGameScene.lotMan.getLow(LotManager.COMMAND.REEL_START), MainGameScene.lotMan.getMode(LotManager.COMMAND.REEL_START));
				dirManOnReelStart2(MainGameScene.lotMan.getHigh(LotManager.COMMAND.REEL_START_2), MainGameScene.lotMan.getLow(LotManager.COMMAND.REEL_START_2), MainGameScene.lotMan.getMode(LotManager.COMMAND.REEL_START_2));
				num = 2;
				b = MainGameScene.lotMan.getHigh(LotManager.COMMAND.REEL1STOP);
				b2 = MainGameScene.lotMan.getLow(LotManager.COMMAND.REEL1STOP);
				b3 = MainGameScene.lotMan.getMode(LotManager.COMMAND.REEL1STOP);
				break;
			case 7:
				dirManOnReel1Stop(MainGameScene.lotMan.getHigh(LotManager.COMMAND.REEL1STOP), MainGameScene.lotMan.getLow(LotManager.COMMAND.REEL1STOP), MainGameScene.lotMan.getMode(LotManager.COMMAND.REEL1STOP));
				dirManOnReel1Stop2(MainGameScene.lotMan.getHigh(LotManager.COMMAND.REEL1STOP_2), MainGameScene.lotMan.getLow(LotManager.COMMAND.REEL1STOP_2), MainGameScene.lotMan.getMode(LotManager.COMMAND.REEL1STOP_2));
				num = 3;
				b = MainGameScene.lotMan.getHigh(LotManager.COMMAND.REEL2STOP);
				b2 = MainGameScene.lotMan.getLow(LotManager.COMMAND.REEL2STOP);
				b3 = MainGameScene.lotMan.getMode(LotManager.COMMAND.REEL2STOP);
				break;
			case 11:
				dirManOnReel2Stop(MainGameScene.lotMan.getHigh(LotManager.COMMAND.REEL2STOP), MainGameScene.lotMan.getLow(LotManager.COMMAND.REEL2STOP), MainGameScene.lotMan.getMode(LotManager.COMMAND.REEL2STOP));
				dirManOnReel2Stop2(MainGameScene.lotMan.getHigh(LotManager.COMMAND.REEL2STOP_2), MainGameScene.lotMan.getLow(LotManager.COMMAND.REEL2STOP_2), MainGameScene.lotMan.getMode(LotManager.COMMAND.REEL2STOP_2));
				num = 4;
				b = MainGameScene.lotMan.getHigh(LotManager.COMMAND.REEL3STOP);
				b2 = MainGameScene.lotMan.getLow(LotManager.COMMAND.REEL3STOP);
				b3 = MainGameScene.lotMan.getMode(LotManager.COMMAND.REEL3STOP);
				break;
			case 15:
				if (MainGameScene.lotMan.pushCnt == 0)
				{
					dirManOnReel3Stop(MainGameScene.lotMan.getHigh(LotManager.COMMAND.REEL3STOP), MainGameScene.lotMan.getLow(LotManager.COMMAND.REEL3STOP), MainGameScene.lotMan.getMode(LotManager.COMMAND.REEL3STOP));
					dirManOnReel3Stop2(MainGameScene.lotMan.getHigh(LotManager.COMMAND.REEL3STOP_2), MainGameScene.lotMan.getLow(LotManager.COMMAND.REEL3STOP_2), MainGameScene.lotMan.getMode(LotManager.COMMAND.REEL3STOP_2));
					num = 5;
					b = MainGameScene.lotMan.getHigh(LotManager.COMMAND.REEL1STOPOFF);
					b2 = MainGameScene.lotMan.getLow(LotManager.COMMAND.REEL1STOPOFF);
					b3 = MainGameScene.lotMan.getMode(LotManager.COMMAND.REEL1STOPOFF);
					if (b == 127 && b2 == 0 && b3 == 118)
					{
						MainGameScene.slotGameMan.m_kaidoData[50] = 150;
						MainGameScene.slotGameMan.set_pkd_data(50, 150);
					}
				}
				break;
			case 16:
				if (MainGameScene.lotMan.pushCnt != 0)
				{
					break;
				}
				dirManOnReel3StopOff(MainGameScene.lotMan.getHigh(LotManager.COMMAND.REEL1STOPOFF), MainGameScene.lotMan.getLow(LotManager.COMMAND.REEL1STOPOFF), MainGameScene.lotMan.getMode(LotManager.COMMAND.REEL1STOPOFF));
				dirManOnReel3StopOff2(MainGameScene.lotMan.getHigh(LotManager.COMMAND.REEL1STOPOFF_2), MainGameScene.lotMan.getLow(LotManager.COMMAND.REEL1STOPOFF_2), MainGameScene.lotMan.getMode(LotManager.COMMAND.REEL1STOPOFF_2));
				num = 6;
				b = MainGameScene.lotMan.getHigh(LotManager.COMMAND.NEXTBET);
				b2 = MainGameScene.lotMan.getLow(LotManager.COMMAND.NEXTBET);
				b3 = MainGameScene.lotMan.getMode(LotManager.COMMAND.NEXTBET);
				if (MainGameScene.lotMan.getHigh(LotManager.COMMAND.REEL1STOPOFF) == 127 && MainGameScene.lotMan.getMode(LotManager.COMMAND.REEL1STOPOFF) >= 28 && 30 >= MainGameScene.lotMan.getMode(LotManager.COMMAND.REEL1STOPOFF))
				{
					b = MainGameScene.lotMan.getHigh(LotManager.COMMAND.REEL1STOPOFF);
					b2 = MainGameScene.lotMan.getLow(LotManager.COMMAND.REEL1STOPOFF);
					b3 = MainGameScene.lotMan.getMode(LotManager.COMMAND.REEL1STOPOFF);
					switch (b3)
					{
					case 28:
						MainGameScene.lotMan.setCommand(num, b, b2, b3);
						break;
					case 29:
						MainGameScene.lotMan.setCommand(num, b, b2, b3);
						break;
					case 30:
						MainGameScene.lotMan.setCommand(num, b, b2, b3);
						break;
					}
				}
				break;
			}
		}
		int num2 = MainGameScene.slotGameMan.get_pkd_data(50);
		if (num2 > 0 && m_trgWait == 0)
		{
			m_trgWait = num2;
			dirMansetDirCommand(num, b, b2, b3);
		}
		else if (num2 == 0)
		{
			m_trgWait = 0;
		}
		else if (m_trgWait > 0)
		{
			m_trgWait--;
		}
	}

	public void slotUserSave(int _num)
	{
		if (_num == 0)
		{
			MainGameScene.m_SlotSaveData.m_saveFlag = true;
		}
		MainGameScene.m_SlotSaveData.set();
		MainGameScene.SlotDataSave();
	}

	public void slotUserSave_hall(int _num)
	{
		if (SGLG.gameMode == SGLG.GAMEMODE.HALL)
		{
			switch (MainGameScene.slotGameMan.selectMachine)
			{
			case 0:
				SlotUserData_m1.saveData.set();
				break;
			case 1:
				SlotUserData_m2.saveData.set();
				break;
			case 2:
				SlotUserData_m3.saveData.set();
				break;
			case 3:
				SlotUserData_m4.saveData.set();
				break;
			case 4:
				SlotUserData_m5.saveData.set();
				break;
			case 5:
				SlotUserData_m6.saveData.set();
				break;
			case 6:
				SlotUserData_m7.saveData.set();
				break;
			case 7:
				SlotUserData_m8.saveData.set();
				break;
			case 8:
				SlotUserData_m9.saveData.set();
				break;
			case 9:
				SlotUserData_m10.saveData.set();
				break;
			}
		}
	}

	public void dirManOnBet(byte _high, byte _low, byte _mode)
	{
		if (!MainGameScene.slotGameMan.isProdStay(-7))
		{
			DirManQueue dirManQueue = new DirManQueue
			{
				com = DIRCOMMAND.ONBET,
				_arg0 = _high,
				_arg1 = _low,
				_arg2 = _mode
			};
			dirQueue.Enqueue(dirManQueue);
		}
	}

	public void dirManOnBet2(byte _high, byte _low, byte _mode)
	{
		DirManQueue dirManQueue = new DirManQueue
		{
			com = DIRCOMMAND.ONBET2,
			_arg0 = _high,
			_arg1 = _low,
			_arg2 = _mode
		};
		dirQueue.Enqueue(dirManQueue);
	}

	public void dirManOnLeverOn(byte _high, byte _low, byte _mode)
	{
		if (!MainGameScene.slotGameMan.isProdStay(-1))
		{
			DirManQueue dirManQueue = new DirManQueue
			{
				com = DIRCOMMAND.ONLEVERON,
				_arg0 = _high,
				_arg1 = _low,
				_arg2 = _mode
			};
			dirQueue.Enqueue(dirManQueue);
		}
	}

	public void dirManOnLeverOn2(byte _high, byte _low, byte _mode)
	{
		DirManQueue dirManQueue = new DirManQueue
		{
			com = DIRCOMMAND.ONLEVERON2,
			_arg0 = _high,
			_arg1 = _low,
			_arg2 = _mode
		};
		dirQueue.Enqueue(dirManQueue);
	}

	public void dirManOnReelStart(byte _high, byte _low, byte _mode)
	{
		if (!MainGameScene.slotGameMan.isProdStay(-2))
		{
			DirManQueue dirManQueue = new DirManQueue
			{
				com = DIRCOMMAND.ONREELSTART,
				_arg0 = _high,
				_arg1 = _low,
				_arg2 = _mode
			};
			dirQueue.Enqueue(dirManQueue);
		}
	}

	public void dirManOnReelStart2(byte _high, byte _low, byte _mode)
	{
		DirManQueue dirManQueue = new DirManQueue
		{
			com = DIRCOMMAND.ONREELSTART2,
			_arg0 = _high,
			_arg1 = _low,
			_arg2 = _mode
		};
		dirQueue.Enqueue(dirManQueue);
	}

	public void dirManOnReel1Stop(byte _high, byte _low, byte _mode)
	{
		if (!MainGameScene.slotGameMan.isProdStay(-3))
		{
			DirManQueue dirManQueue = new DirManQueue
			{
				com = DIRCOMMAND.ONREEL1STOP,
				_arg0 = _high,
				_arg1 = _low,
				_arg2 = _mode
			};
			dirQueue.Enqueue(dirManQueue);
		}
	}

	public void dirManOnReel1Stop2(byte _high, byte _low, byte _mode)
	{
		DirManQueue dirManQueue = new DirManQueue
		{
			com = DIRCOMMAND.ONREEL1STOP2,
			_arg0 = _high,
			_arg1 = _low,
			_arg2 = _mode
		};
		dirQueue.Enqueue(dirManQueue);
	}

	public void dirManOnReel2Stop(byte _high, byte _low, byte _mode)
	{
		if (!MainGameScene.slotGameMan.isProdStay(-4))
		{
			DirManQueue dirManQueue = new DirManQueue
			{
				com = DIRCOMMAND.ONREEL2STOP,
				_arg0 = _high,
				_arg1 = _low,
				_arg2 = _mode
			};
			dirQueue.Enqueue(dirManQueue);
		}
	}

	public void dirManOnReel2Stop2(byte _high, byte _low, byte _mode)
	{
		DirManQueue dirManQueue = new DirManQueue
		{
			com = DIRCOMMAND.ONREEL2STOP2,
			_arg0 = _high,
			_arg1 = _low,
			_arg2 = _mode
		};
		dirQueue.Enqueue(dirManQueue);
	}

	public void dirManOnReel3Stop(byte _high, byte _low, byte _mode)
	{
		if (!MainGameScene.slotGameMan.isProdStay(-5))
		{
			DirManQueue dirManQueue = new DirManQueue
			{
				com = DIRCOMMAND.ONREEL3STOP,
				_arg0 = _high,
				_arg1 = _low,
				_arg2 = _mode
			};
			dirQueue.Enqueue(dirManQueue);
		}
	}

	public void dirManOnReel3Stop2(byte _high, byte _low, byte _mode)
	{
		DirManQueue dirManQueue = new DirManQueue
		{
			com = DIRCOMMAND.ONREEL3STOP2,
			_arg0 = _high,
			_arg1 = _low,
			_arg2 = _mode
		};
		dirQueue.Enqueue(dirManQueue);
	}

	public void dirManOnReel3StopOff(byte _high, byte _low, byte _mode)
	{
		if (!MainGameScene.slotGameMan.isProdStay(-6))
		{
			DirManQueue dirManQueue = new DirManQueue
			{
				com = DIRCOMMAND.ONREEL3STOPOFF,
				_arg0 = _high,
				_arg1 = _low,
				_arg2 = _mode
			};
			dirQueue.Enqueue(dirManQueue);
		}
	}

	public void dirManOnReel3StopOff2(byte _high, byte _low, byte _mode)
	{
		DirManQueue dirManQueue = new DirManQueue
		{
			com = DIRCOMMAND.ONREEL3STOPOFF2,
			_arg0 = _high,
			_arg1 = _low,
			_arg2 = _mode
		};
		dirQueue.Enqueue(dirManQueue);
	}

	public void dirManOnYTK(byte _high, byte _low, byte _mode)
	{
		if (!MainGameScene.slotGameMan.isProdStay(-97))
		{
			DirManQueue dirManQueue = new DirManQueue
			{
				com = DIRCOMMAND.ONYTK,
				_arg0 = _high,
				_arg1 = _low,
				_arg2 = _mode
			};
			dirQueue.Enqueue(dirManQueue);
		}
	}

	public void dirManchangeStageInterface(int _stage)
	{
		DirManQueue dirManQueue = new DirManQueue
		{
			com = DIRCOMMAND.CHANGESTAGEINTERFACE,
			_arg0 = _stage
		};
		dirQueue.Enqueue(dirManQueue);
	}

	public void dirManStopDirection(DirectionManager.DIR d)
	{
		if (!MainGameScene.slotGameMan.isProdStay(-100))
		{
			DirManQueue dirManQueue = new DirManQueue
			{
				com = DIRCOMMAND.STOPDIRECTION,
				_arg0 = (int)d
			};
			dirQueue.Enqueue(dirManQueue);
		}
	}

	public void dirManStopDirection()
	{
		if (!MainGameScene.slotGameMan.isProdStay(-101))
		{
			DirManQueue dirManQueue = new DirManQueue
			{
				com = DIRCOMMAND.STOPDIRECTIONALL
			};
			dirQueue.Enqueue(dirManQueue);
		}
	}

	public void dirManInitDirection()
	{
		if (!MainGameScene.slotGameMan.isProdStay(-102))
		{
			DirManQueue dirManQueue = new DirManQueue
			{
				com = DIRCOMMAND.INITDIRECTION
			};
			dirQueue.Enqueue(dirManQueue);
		}
	}

	public void dirMansetDirCommand(int dirNum, byte _high, byte _low, byte _mode)
	{
		DirManQueue dirManQueue = new DirManQueue
		{
			com = DIRCOMMAND.SETDIRCOMMAND,
			_arg0 = dirNum,
			_arg1 = _high,
			_arg2 = _low,
			_arg3 = _mode
		};
		dirQueue.Enqueue(dirManQueue);
	}

	public void execQueue()
	{
		foreach (DirManQueue item in dirQueue)
		{
			switch (item.com)
			{
			case DIRCOMMAND.ONBET:
				MainGameScene.dirMan.OnBet((byte)item._arg0, (byte)item._arg1, (byte)item._arg2);
				break;
			case DIRCOMMAND.ONBET2:
				MainGameScene.dirMan.OnBet2((byte)item._arg0, (byte)item._arg1, (byte)item._arg2);
				break;
			case DIRCOMMAND.ONLEVERON:
				MainGameScene.dirMan.OnLeverOn((byte)item._arg0, (byte)item._arg1, (byte)item._arg2);
				break;
			case DIRCOMMAND.ONLEVERON2:
				MainGameScene.dirMan.OnLeverOn2((byte)item._arg0, (byte)item._arg1, (byte)item._arg2);
				break;
			case DIRCOMMAND.ONREELSTART:
				MainGameScene.dirMan.OnReelStart((byte)item._arg0, (byte)item._arg1, (byte)item._arg2);
				break;
			case DIRCOMMAND.ONREELSTART2:
				MainGameScene.dirMan.OnReelStart2((byte)item._arg0, (byte)item._arg1, (byte)item._arg2);
				break;
			case DIRCOMMAND.ONREEL1STOP:
				MainGameScene.dirMan.OnReel1Stop((byte)item._arg0, (byte)item._arg1, (byte)item._arg2);
				break;
			case DIRCOMMAND.ONREEL1STOP2:
				MainGameScene.dirMan.OnReel1Stop2((byte)item._arg0, (byte)item._arg1, (byte)item._arg2);
				break;
			case DIRCOMMAND.ONREEL2STOP:
				MainGameScene.dirMan.OnReel2Stop((byte)item._arg0, (byte)item._arg1, (byte)item._arg2);
				break;
			case DIRCOMMAND.ONREEL2STOP2:
				MainGameScene.dirMan.OnReel2Stop2((byte)item._arg0, (byte)item._arg1, (byte)item._arg2);
				break;
			case DIRCOMMAND.ONREEL3STOP:
				MainGameScene.dirMan.OnReel3Stop((byte)item._arg0, (byte)item._arg1, (byte)item._arg2);
				break;
			case DIRCOMMAND.ONREEL3STOP2:
				MainGameScene.dirMan.OnReel3Stop2((byte)item._arg0, (byte)item._arg1, (byte)item._arg2);
				break;
			case DIRCOMMAND.ONREEL3STOPOFF:
				MainGameScene.dirMan.OnReel3StopOff((byte)item._arg0, (byte)item._arg1, (byte)item._arg2);
				break;
			case DIRCOMMAND.ONREEL3STOPOFF2:
				MainGameScene.dirMan.OnReel3StopOff2((byte)item._arg0, (byte)item._arg1, (byte)item._arg2);
				break;
			case DIRCOMMAND.ONYTK:
				MainGameScene.dirMan.OnYTK((byte)item._arg0, (byte)item._arg1, (byte)item._arg2);
				break;
			case DIRCOMMAND.CHANGESTAGEINTERFACE:
				MainGameScene.dirMan.changeStageIntarface(item._arg0);
				break;
			case DIRCOMMAND.STOPDIRECTION:
				MainGameScene.dirMan.StopDirection((DirectionManager.DIR)item._arg0);
				break;
			case DIRCOMMAND.STOPDIRECTIONALL:
				MainGameScene.dirMan.StopDirection();
				break;
			case DIRCOMMAND.INITDIRECTION:
				MainGameScene.dirMan.InitDirection();
				break;
			case DIRCOMMAND.SETDIRCOMMAND:
				MainGameScene.dirMan.setDirCommand(item._arg0, (byte)item._arg1, (byte)item._arg2, (byte)item._arg3);
				break;
			}
		}
		dirQueue.Clear();
	}
}
