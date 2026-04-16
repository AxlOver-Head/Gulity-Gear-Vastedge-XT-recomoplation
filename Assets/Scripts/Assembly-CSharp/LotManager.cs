using UnityEngine;

public class LotManager
{
	public enum COMMAND
	{
		LEVER_ON = 0,
		REEL_START = 1,
		REEL1STOP = 2,
		REEL2STOP = 3,
		REEL3STOP = 4,
		REEL1STOPOFF = 5,
		NEXTBET = 6,
		LEVER_ON_2 = 7,
		REEL_START_2 = 8,
		REEL1STOP_2 = 9,
		REEL2STOP_2 = 10,
		REEL3STOP_2 = 11,
		REEL1STOPOFF_2 = 12,
		NEXTBET_2 = 13,
		YTK_YAKUTAN = 14,
		MAX = 15
	}

	public LotCommand[] command;

	public int pushCnt;

	public bool pushFlag;

	public int m_gijiCnt;

	private int lotcnt;

	public LotManager()
	{
		int num = 15;
		command = new LotCommand[num];
		for (int i = 0; i < num; i++)
		{
			command[i] = new LotCommand();
		}
		init();
		lotcnt = 0;
		m_gijiCnt = 0;
	}

	public void startLot_LeverOn()
	{
		lotcnt++;
		int num = 7;
		pushCnt = 0;
		MainGameScene.slotGameMan.startLot_LeverOn();
		for (int i = 0; i < num; i++)
		{
			command[i].high = (byte)MainGameScene.slotGameMan.get_dir_cmd(i, 0);
			command[i].low = (byte)MainGameScene.slotGameMan.get_dir_cmd(i, 1);
			command[i].mode = (byte)MainGameScene.slotGameMan.get_dir_cmd(i, 2);
		}
		if ((byte)MainGameScene.slotGameMan.get_cmd(0, 0, 0) != 0 && MainGameScene.slotGameMan.getBnsSyoukaku() == 0)
		{
			int num2 = MainGameScene.slotGameMan.get_pkd_data(86);
			if (num2 != 5 && num2 != 6)
			{
				if (MainGameScene.slotGameMan.get_cmd(0, 0, 0) == 'Y' || MainGameScene.slotGameMan.get_cmd(0, 0, 0) == 'H')
				{
					int num3 = MainGameScene.slotGameMan.get_pkd_data(438);
					int num4 = MainGameScene.slotGameMan.get_pkd_data(439);
					if (num4 - num3 == 0 || num4 - num3 == 1)
					{
						MainGameScene.dirMan.EventStageChanged((byte)MainGameScene.slotGameMan.get_cmd(0, 0, 0), (byte)MainGameScene.slotGameMan.get_cmd(1, 0, 0), (byte)MainGameScene.slotGameMan.get_cmd(2, 0, 0));
					}
				}
				else
				{
					command[0].high = (byte)MainGameScene.slotGameMan.get_cmd(0, 0, 0);
					command[0].low = (byte)MainGameScene.slotGameMan.get_cmd(1, 0, 0);
					command[0].mode = (byte)MainGameScene.slotGameMan.get_cmd(2, 0, 0);
				}
			}
		}
		setFukugoCommand(0);
		switch (MainGameScene.slotGameMan.getReelAction())
		{
		case 1:
			command[7].high = 17;
			command[7].low = 1;
			command[7].mode = 1;
			MainGameScene.slotGameMan.set_pdt_data(15, 1);
			MainGameScene.slotGameMan.m_dirData[15] = 1;
			m_gijiCnt = 2;
			break;
		case 2:
			command[7].high = 17;
			command[7].low = 1;
			command[7].mode = 2;
			MainGameScene.slotGameMan.set_pdt_data(15, 2);
			MainGameScene.slotGameMan.m_dirData[15] = 2;
			m_gijiCnt = 2;
			break;
		case 3:
			command[7].high = 17;
			command[7].low = 1;
			command[7].mode = 3;
			MainGameScene.slotGameMan.set_pdt_data(15, 3);
			MainGameScene.slotGameMan.m_dirData[15] = 3;
			m_gijiCnt = 2;
			break;
		}
		switch (MainGameScene.slotGameMan.getBnsSyoukaku())
		{
		case 55:
			command[7].high = 29;
			command[7].low = 1;
			if (MainGameScene.slotGameMan.m_oldBnsKind == 1)
			{
				command[7].mode = 7;
			}
			else
			{
				command[7].mode = 8;
			}
			break;
		case 59:
			command[7].high = 29;
			command[7].low = 1;
			command[7].mode = 9;
			break;
		case 64:
			command[7].high = 29;
			command[7].low = 1;
			if (MainGameScene.slotGameMan.m_oldBnsKind == 1)
			{
				command[7].mode = 10;
			}
			else
			{
				command[7].mode = 11;
			}
			break;
		}
	}

	public void startLot_ReelStart()
	{
		if (MainGameScene.slotGameMan.getBnsSyoukaku() != 0)
		{
			int num = MainGameScene.slotGameMan.get_pkd_data(86);
			if (num != 5 && num != 6)
			{
				int num2 = MainGameScene.slotGameMan.get_pkd_data(438);
				int num3 = MainGameScene.slotGameMan.get_pkd_data(439);
				int num4 = MainGameScene.slotGameMan.get_pdt_data(45);
				if (num3 - num2 == 0 || num3 - num2 == 1)
				{
					MainGameScene.dirMan.StopDirection(DirectionManager.DIR.LEVER_2);
					switch (num4)
					{
					case 13:
					case 14:
						MainGameScene.dirMan.EventStageChanged(89, 0, 1);
						break;
					case 15:
					case 16:
						MainGameScene.dirMan.EventStageChanged(72, 0, 1);
						break;
					}
				}
			}
		}
		MainGameScene.slotGameMan.startLot_ReelStart();
		setFukugoCommand(1);
		int num5 = MainGameScene.slotGameMan.get_pkd_data(6);
		int num6 = MainGameScene.slotGameMan.get_pkd_data(7);
		int num7 = MainGameScene.slotGameMan.get_pkd_data(8);
		int num8 = MainGameScene.slotGameMan.get_pkd_data(9);
		int num9 = MainGameScene.slotGameMan.get_pdt_data(5);
		int num10 = MainGameScene.slotGameMan.get_pkd_data(51);
		int num11 = MainGameScene.slotGameMan.get_pkd_data(638);
		int num12 = MainGameScene.slotGameMan.get_pkd_data(635);
	}

	public void startLot_Reel1()
	{
		setFukugoCommand(2);
		int num = MainGameScene.slotGameMan.get_pkd_data(6);
		int num2 = MainGameScene.slotGameMan.get_pkd_data(7);
		int num3 = MainGameScene.slotGameMan.get_pkd_data(8);
		int num4 = MainGameScene.slotGameMan.get_pkd_data(9);
		int num5 = MainGameScene.slotGameMan.get_pdt_data(5);
		int num6 = MainGameScene.slotGameMan.get_pkd_data(51);
		int num7 = MainGameScene.slotGameMan.get_pkd_data(638);
		int num8 = MainGameScene.slotGameMan.get_pkd_data(635);
	}

	public void startLot_Reel2()
	{
		setFukugoCommand(3);
		int num = MainGameScene.slotGameMan.get_pkd_data(6);
		int num2 = MainGameScene.slotGameMan.get_pkd_data(7);
		int num3 = MainGameScene.slotGameMan.get_pkd_data(8);
		int num4 = MainGameScene.slotGameMan.get_pkd_data(9);
		int num5 = MainGameScene.slotGameMan.get_pdt_data(5);
		int num6 = MainGameScene.slotGameMan.get_pkd_data(51);
		int num7 = MainGameScene.slotGameMan.get_pkd_data(638);
		int num8 = MainGameScene.slotGameMan.get_pkd_data(635);
	}

	public void startLot_Reel3off()
	{
		setFukugoCommand(4);
		int num = MainGameScene.slotGameMan.get_pkd_data(6);
		int num2 = MainGameScene.slotGameMan.get_pkd_data(7);
		int num3 = MainGameScene.slotGameMan.get_pkd_data(8);
		int num4 = MainGameScene.slotGameMan.get_pkd_data(9);
		int num5 = MainGameScene.slotGameMan.get_pdt_data(5);
		int num6 = MainGameScene.slotGameMan.get_pkd_data(51);
		int num7 = MainGameScene.slotGameMan.get_pkd_data(638);
		int num8 = MainGameScene.slotGameMan.get_pkd_data(635);
	}

	public void startLot_Reel3()
	{
		setFukugoCommand(5);
		int num = MainGameScene.slotGameMan.get_pkd_data(6);
		int num2 = MainGameScene.slotGameMan.get_pkd_data(7);
		int num3 = MainGameScene.slotGameMan.get_pkd_data(8);
		int num4 = MainGameScene.slotGameMan.get_pkd_data(9);
		int num5 = MainGameScene.slotGameMan.get_pdt_data(5);
		int num6 = MainGameScene.slotGameMan.get_pkd_data(51);
		int num7 = MainGameScene.slotGameMan.get_pkd_data(638);
		int num8 = MainGameScene.slotGameMan.get_pkd_data(635);
		int num9 = 7;
		int num10 = 14;
		for (int i = 0; i < num9; i++)
		{
			if ((byte)MainGameScene.slotGameMan.get_dir_cmd(i, 0) != 127 || (byte)MainGameScene.slotGameMan.get_dir_cmd(i, 1) != 0 || (byte)MainGameScene.slotGameMan.get_dir_cmd(i, 2) != 1)
			{
				command[i].high = (byte)MainGameScene.slotGameMan.get_dir_cmd(i, 0);
				command[i].low = (byte)MainGameScene.slotGameMan.get_dir_cmd(i, 1);
				command[i].mode = (byte)MainGameScene.slotGameMan.get_dir_cmd(i, 2);
			}
		}
		if ((byte)MainGameScene.slotGameMan.get_cmd(0, 0, 0) != 0)
		{
			command[4].high = (byte)MainGameScene.slotGameMan.get_cmd(0, 0, 0);
			command[4].low = (byte)MainGameScene.slotGameMan.get_cmd(1, 0, 0);
			command[4].mode = (byte)MainGameScene.slotGameMan.get_cmd(2, 0, 0);
			int num11 = MainGameScene.slotGameMan.get_pdt_data(27);
			if (num11 != 0)
			{
				command[4].high = (byte)MainGameScene.slotGameMan.get_dir_cmd2(4, 0, 38, num11);
				command[4].low = (byte)MainGameScene.slotGameMan.get_dir_cmd2(4, 1, 38, num11);
				command[4].mode = (byte)MainGameScene.slotGameMan.get_dir_cmd2(4, 2, 38, num11);
				if (command[4].mode == 19)
				{
					command[4].mode = 9;
				}
				if ((num11 == 5 || num11 == 14) && command[4].mode > 17)
				{
					command[4].mode = 5;
				}
			}
		}
		int num12 = MainGameScene.slotGameMan.get_pdt_data(45);
		int num13 = MainGameScene.slotGameMan.get_pdt_data(46);
		int num14 = MainGameScene.slotGameMan.get_pdt_data(47);
		int num15 = MainGameScene.slotGameMan.get_pdt_data(48);
		int num16 = MainGameScene.slotGameMan.get_pdt_data(49);
	}

	public void startLot_Bet()
	{
		pushFlag = false;
		MainGameScene.slotGameMan.startLot_Bet();
		setFukugoCommand(6);
		if ((byte)MainGameScene.slotGameMan.get_cmd(0, 0, 0) != 0)
		{
			command[6].high = (byte)MainGameScene.slotGameMan.get_cmd(0, 0, 0);
			command[6].low = (byte)MainGameScene.slotGameMan.get_cmd(1, 0, 0);
			command[6].mode = (byte)MainGameScene.slotGameMan.get_cmd(2, 0, 0);
		}
		int num = MainGameScene.slotGameMan.get_pdt_data(45);
		int num2 = MainGameScene.slotGameMan.get_pdt_data(46);
		int num3 = MainGameScene.slotGameMan.get_pdt_data(47);
		int num4 = MainGameScene.slotGameMan.get_pdt_data(48);
		int num5 = MainGameScene.slotGameMan.get_pdt_data(49);
		if (num2 == 20 && num5 != 20)
		{
			command[6].high = 71;
			command[6].low = 0;
			command[6].mode = 1;
		}
		MainGameScene.slotGameMan.set_pdt_data(65, MainGameScene.slotGameMan.get_pkd_data(538));
	}

	public void startLot_Push()
	{
		bool flag = true;
		int num = MainGameScene.slotGameMan.get_pkd_data(6);
		int ucFLMainCmdOk = MainGameScene.slotGameMan.m_ucFLMainCmdOk;
		int num2 = MainGameScene.slotGameMan.get_pdt_data(1);
		int num3 = MainGameScene.slotGameMan.get_pdt_data(5);
		int num4 = MainGameScene.slotGameMan.get_pkd_data(48);
		int num5 = MainGameScene.slotGameMan.get_pkd_data(51);
		if (num != ucFLMainCmdOk && ucFLMainCmdOk != 0 && num2 != 95 && num2 != 77 && num2 != 95)
		{
			num = ucFLMainCmdOk;
		}
		if (num == 0 && num2 != 84)
		{
			return;
		}
		if (num4 >= 2)
		{
			num4 -= 2;
		}
		if (num2 == 84)
		{
			if (num3 >= 127 && 473 >= num3)
			{
				pushCnt = MainGameScene.slotGameMan.m_kaidoData[637];
				if (pushCnt < 4)
				{
					num = MainGameScene.slotGameMan.get_pdt_data(94 + pushCnt);
					MainGameScene.slotGameMan.set_pdt_data(5, num);
					MainGameScene.slotGameMan.m_kaidoData[637]++;
					MainGameScene.slotGameMan.set_pkd_data(637, MainGameScene.slotGameMan.m_kaidoData[637]);
					flag = true;
				}
			}
			else if (num3 >= 103 && 118 >= num3)
			{
				flag = true;
				MainGameScene.slotGameMan.set_pdt_data(5, num);
			}
		}
		else
		{
			MainGameScene.slotGameMan.set_pdt_data(8, num);
			if (num2 == 95 || num2 == 86 || num2 == 13 || num2 == 15)
			{
				MainGameScene.slotGameMan.set_pdt_data(5, num);
				if (num2 == 95 && num4 == 1)
				{
					num4 = 6;
				}
			}
			if (num2 == 43 && num3 >= 862 && 1731 >= num3)
			{
				MainGameScene.slotGameMan.startLot_Prod();
				MainGameScene.slotGameMan.set_pdt_data(15, 0);
				setFukugoCommand(0);
				switch (num4)
				{
				case 0:
					MainGameScene.dirMan.OnLeverOn2(MainGameScene.lotMan.getHigh(COMMAND.LEVER_ON_2), MainGameScene.lotMan.getLow(COMMAND.LEVER_ON_2), MainGameScene.lotMan.getMode(COMMAND.LEVER_ON_2));
					break;
				case 1:
					MainGameScene.dirMan.OnReelStart2(MainGameScene.lotMan.getHigh(COMMAND.REEL_START_2), MainGameScene.lotMan.getLow(COMMAND.REEL_START_2), MainGameScene.lotMan.getMode(COMMAND.REEL_START_2));
					break;
				case 2:
					MainGameScene.dirMan.OnReel1Stop2(MainGameScene.lotMan.getHigh(COMMAND.REEL1STOP_2), MainGameScene.lotMan.getLow(COMMAND.REEL1STOP_2), MainGameScene.lotMan.getMode(COMMAND.REEL1STOP_2));
					break;
				case 3:
					MainGameScene.dirMan.OnReel2Stop2(MainGameScene.lotMan.getHigh(COMMAND.REEL2STOP_2), MainGameScene.lotMan.getLow(COMMAND.REEL2STOP_2), MainGameScene.lotMan.getMode(COMMAND.REEL2STOP_2));
					break;
				case 4:
					MainGameScene.dirMan.OnReel3Stop2(MainGameScene.lotMan.getHigh(COMMAND.REEL3STOP_2), MainGameScene.lotMan.getLow(COMMAND.REEL3STOP_2), MainGameScene.lotMan.getMode(COMMAND.REEL3STOP_2));
					break;
				case 5:
					MainGameScene.dirMan.OnReel3StopOff2(MainGameScene.lotMan.getHigh(COMMAND.REEL1STOPOFF_2), MainGameScene.lotMan.getLow(COMMAND.REEL1STOPOFF_2), MainGameScene.lotMan.getMode(COMMAND.REEL1STOPOFF_2));
					break;
				case 6:
					MainGameScene.dirMan.OnBet2(MainGameScene.lotMan.getHigh(COMMAND.NEXTBET_2), MainGameScene.lotMan.getLow(COMMAND.NEXTBET_2), MainGameScene.lotMan.getMode(COMMAND.NEXTBET_2));
					break;
				}
			}
			if (num2 == 16)
			{
				switch (num)
				{
				case 6:
					MainGameScene.slotGameMan.m_dirData[90] = 2;
					break;
				case 7:
				case 16:
					MainGameScene.slotGameMan.m_dirData[90] = 3;
					break;
				case 8:
				case 17:
				case 24:
					MainGameScene.slotGameMan.m_dirData[90] = 4;
					break;
				case 9:
				case 18:
				case 25:
				case 30:
					MainGameScene.slotGameMan.m_dirData[90] = 5;
					break;
				case 19:
				case 31:
				case 35:
					MainGameScene.slotGameMan.m_dirData[90] = 6;
					break;
				}
				MainGameScene.slotGameMan.set_pdt_data(90, MainGameScene.slotGameMan.m_dirData[90]);
				DirectionPanelLED.runMac2App(MainGameScene.slotGameMan.getCharPanel(), 5);
			}
			if (num2 == 77)
			{
				int num6 = (num - 126) % 15;
				int num7 = 0;
				if (num6 >= 0)
				{
					num7 = ((num6 != 0 && num6 != 1) ? (97 + (num6 - 2)) : (num6 + 1));
					command[num4].high = 73;
					command[num4].low = 2;
					command[num4].mode = (byte)num7;
					command[13].high = 127;
					command[13].low = 0;
					command[13].mode = 1;
					MainGameScene.dirMan.OnPush(num4, command[num4].high, command[num4].low, command[num4].mode, flag);
					return;
				}
			}
		}
		int trg = num5 - 1;
		switch (num2)
		{
		case 2:
		case 12:
		case 13:
		case 15:
		case 48:
		case 62:
			trg = num5 - 2;
			break;
		}
		Resources.UnloadUnusedAssets();
		command[num4].high = (byte)MainGameScene.slotGameMan.get_dir_cmd2(trg, 0, num2, num);
		command[num4].low = (byte)MainGameScene.slotGameMan.get_dir_cmd2(trg, 1, num2, num);
		command[num4].mode = (byte)MainGameScene.slotGameMan.get_dir_cmd2(trg, 2, num2, num);
		MainGameScene.dirMan.OnPush(num4, command[num4].high, command[num4].low, command[num4].mode, flag);
		for (int i = 0; i < 7; i++)
		{
			byte b = (byte)MainGameScene.slotGameMan.get_dir_cmd2(i, 0, num2, num);
			byte b2 = (byte)MainGameScene.slotGameMan.get_dir_cmd2(i, 1, num2, num);
			byte b3 = (byte)MainGameScene.slotGameMan.get_dir_cmd2(i, 2, num2, num);
		}
		pushFlag = true;
	}

	public void startLot_PushRoman()
	{
		int num = 183;
		int usGrp = 97;
		int num2 = MainGameScene.slotGameMan.get_pkd_data(48);
		int num3 = 6;
		int num4 = MainGameScene.slotGameMan.get_pdt_data(5);
		if (num + (num4 - 92) % 13 != 0)
		{
			if (num2 >= 2)
			{
				num2 -= 2;
			}
			num = MainGameScene.slotGameMan.getRomanUwanoseProd();
			command[num2].high = (byte)MainGameScene.slotGameMan.get_dir_cmd2(num3 - 1, 0, usGrp, num);
			command[num2].low = (byte)MainGameScene.slotGameMan.get_dir_cmd2(num3 - 1, 1, usGrp, num);
			command[num2].mode = (byte)MainGameScene.slotGameMan.get_dir_cmd2(num3 - 1, 2, usGrp, num);
			MainGameScene.dirMan.OnPush(num2, command[num2].high, command[num2].low, command[num2].mode, false);
			for (int i = 0; i < 7; i++)
			{
				byte b = (byte)MainGameScene.slotGameMan.get_dir_cmd2(i, 0, usGrp, num);
				byte b2 = (byte)MainGameScene.slotGameMan.get_dir_cmd2(i, 1, usGrp, num);
				byte b3 = (byte)MainGameScene.slotGameMan.get_dir_cmd2(i, 2, usGrp, num);
			}
		}
	}

	public void startLot_PushBTH()
	{
		bool flag = true;
		int usDir = MainGameScene.slotGameMan.get_pkd_data(6);
		int usGrp = MainGameScene.slotGameMan.get_pdt_data(1);
		int num = MainGameScene.slotGameMan.get_pdt_data(5);
		int num2 = MainGameScene.slotGameMan.get_pkd_data(48);
		int num3 = MainGameScene.slotGameMan.get_pkd_data(51);
		if (num < 269 || 280 < num)
		{
			return;
		}
		if (num2 >= 2)
		{
			num2 -= 2;
		}
		if (num >= 269 && 274 >= num)
		{
			int num4 = MainGameScene.slotGameMan.m_kaidoData[637];
			int num5 = MainGameScene.slotGameMan.get_pkd_data(482) - 1;
			if (num4 >= num5)
			{
				usDir = num + 15;
			}
			else
			{
				switch (num)
				{
				case 269:
				case 270:
					usDir = 281;
					break;
				case 271:
				case 272:
					usDir = 282;
					break;
				case 273:
				case 274:
					usDir = 283;
					break;
				}
			}
		}
		int trg = num3 - 1;
		flag = false;
		if (num2 != 5)
		{
			num2 = 6;
		}
		command[num2].high = (byte)MainGameScene.slotGameMan.get_dir_cmd2(trg, 0, usGrp, usDir);
		command[num2].low = (byte)MainGameScene.slotGameMan.get_dir_cmd2(trg, 1, usGrp, usDir);
		command[num2].mode = (byte)MainGameScene.slotGameMan.get_dir_cmd2(trg, 2, usGrp, usDir);
		MainGameScene.dirMan.OnPush(num2, command[num2].high, command[num2].low, command[num2].mode, flag);
		for (int i = 0; i < 7; i++)
		{
			byte b = (byte)MainGameScene.slotGameMan.get_dir_cmd2(i, 0, usGrp, usDir);
			byte b2 = (byte)MainGameScene.slotGameMan.get_dir_cmd2(i, 1, usGrp, usDir);
			byte b3 = (byte)MainGameScene.slotGameMan.get_dir_cmd2(i, 2, usGrp, usDir);
		}
		pushFlag = true;
	}

	public void startLot_PushBZT()
	{
		int[][][] array = new int[5][][]
		{
			new int[7][]
			{
				new int[3] { 5, 12, 15 },
				new int[3] { 5, 13, 15 },
				new int[3] { 5, 14, 15 },
				new int[3] { 5, 19, 15 },
				new int[3],
				new int[3],
				new int[3]
			},
			new int[7][]
			{
				new int[3] { 5, 12, 15 },
				new int[3] { 5, 13, 15 },
				new int[3] { 5, 14, 16 },
				new int[3] { 7, 24, 17 },
				new int[3] { 0, 255, 31 },
				new int[3],
				new int[3]
			},
			new int[7][]
			{
				new int[3] { 5, 12, 15 },
				new int[3] { 5, 13, 15 },
				new int[3] { 7, 12, 16 },
				new int[3] { 1, 15, 15 },
				new int[3] { 1, 16, 18 },
				new int[3] { 1, 26, 19 },
				new int[3] { 0, 255, 31 }
			},
			new int[7][]
			{
				new int[3] { 5, 12, 15 },
				new int[3] { 5, 15, 15 },
				new int[3] { 5, 16, 18 },
				new int[3] { 7, 17, 19 },
				new int[3],
				new int[3],
				new int[3]
			},
			new int[7][]
			{
				new int[3] { 5, 12, 15 },
				new int[3] { 5, 15, 15 },
				new int[3] { 5, 16, 18 },
				new int[3] { 7, 26, 19 },
				new int[3] { 0, 255, 31 },
				new int[3],
				new int[3]
			}
		};
		int[][][][] array2 = new int[2][][][]
		{
			new int[7][][]
			{
				new int[5][]
				{
					new int[3] { 5, 53, 1 },
					new int[3] { 5, 54, 1 },
					new int[3] { 5, 55, 1 },
					new int[3] { 10, 56, 1 },
					new int[3]
				},
				new int[5][]
				{
					new int[3] { 5, 53, 1 },
					new int[3] { 5, 54, 1 },
					new int[3] { 5, 55, 1 },
					new int[3] { 7, 56, 1 },
					new int[3]
				},
				new int[5][]
				{
					new int[3] { 5, 53, 1 },
					new int[3] { 5, 54, 1 },
					new int[3] { 7, 55, 1 },
					new int[3] { 1, 56, 1 },
					new int[3]
				},
				new int[5][]
				{
					new int[3] { 5, 53, 1 },
					new int[3] { 5, 54, 1 },
					new int[3] { 5, 55, 1 },
					new int[3] { 7, 56, 1 },
					new int[3]
				},
				new int[5][]
				{
					new int[3] { 5, 53, 1 },
					new int[3] { 5, 54, 1 },
					new int[3] { 5, 55, 1 },
					new int[3] { 7, 56, 1 },
					new int[3]
				},
				new int[5][]
				{
					new int[3] { 5, 53, 1 },
					new int[3] { 5, 54, 1 },
					new int[3] { 5, 55, 1 },
					new int[3] { 7, 56, 1 },
					new int[3]
				},
				new int[5][]
				{
					new int[3] { 5, 53, 1 },
					new int[3] { 5, 54, 1 },
					new int[3] { 5, 55, 1 },
					new int[3] { 7, 56, 1 },
					new int[3]
				}
			},
			new int[7][][]
			{
				new int[5][]
				{
					new int[3] { 5, 53, 1 },
					new int[3] { 5, 54, 1 },
					new int[3] { 5, 55, 1 },
					new int[3] { 10, 57, 1 },
					new int[3] { 0, 0, 33 }
				},
				new int[5][]
				{
					new int[3] { 5, 53, 1 },
					new int[3] { 5, 54, 1 },
					new int[3] { 5, 55, 1 },
					new int[3] { 7, 57, 1 },
					new int[3] { 0, 0, 33 }
				},
				new int[5][]
				{
					new int[3] { 5, 53, 1 },
					new int[3] { 5, 54, 1 },
					new int[3] { 7, 55, 1 },
					new int[3] { 1, 57, 1 },
					new int[3] { 0, 0, 33 }
				},
				new int[5][]
				{
					new int[3] { 5, 53, 1 },
					new int[3] { 5, 54, 1 },
					new int[3] { 5, 55, 1 },
					new int[3] { 7, 57, 1 },
					new int[3] { 0, 0, 33 }
				},
				new int[5][]
				{
					new int[3] { 5, 53, 1 },
					new int[3] { 5, 54, 1 },
					new int[3] { 5, 55, 1 },
					new int[3] { 7, 57, 1 },
					new int[3] { 0, 0, 33 }
				},
				new int[5][]
				{
					new int[3] { 5, 53, 1 },
					new int[3] { 5, 54, 1 },
					new int[3] { 5, 55, 1 },
					new int[3] { 7, 57, 1 },
					new int[3] { 0, 0, 33 }
				},
				new int[5][]
				{
					new int[3] { 5, 53, 1 },
					new int[3] { 5, 54, 1 },
					new int[3] { 5, 55, 1 },
					new int[3] { 7, 57, 1 },
					new int[3] { 0, 0, 33 }
				}
			}
		};
		bool flag = true;
		int num = MainGameScene.slotGameMan.get_pkd_data(6);
		int usGrp = MainGameScene.slotGameMan.get_pdt_data(1);
		int num2 = MainGameScene.slotGameMan.get_pdt_data(29);
		int num3 = MainGameScene.slotGameMan.get_pkd_data(48);
		int num4 = MainGameScene.slotGameMan.get_pkd_data(51);
		int num5 = 0;
		if ((num2 < 7 || 26 < num2) && (num2 < 51 || 52 < num2))
		{
			return;
		}
		if (num3 >= 2)
		{
			num3 -= 2;
		}
		int num6 = MainGameScene.slotGameMan.m_kaidoData[637];
		int num7 = MainGameScene.slotGameMan.m_kaidoData[636];
		int num8 = 0;
		if (num2 >= 7 && 26 >= num2)
		{
			if (num7 > 6)
			{
				return;
			}
			num8 = array[num2 - 7][num7][0];
			num5 = array[num2 - 7][num7][2];
			if (array[num2 - 7][num7 + 1][0] == 0 && array[num2 - 7][num7 + 1][2] != 0)
			{
				num5 = array[num2 - 7][num7 + 1][2];
			}
		}
		else
		{
			if (num7 > 4)
			{
				return;
			}
			num8 = array2[num2 - 51][0][num7][0];
			num5 = array2[num2 - 51][0][num7][2];
			if (array2[num2 - 51][0][num7][1] == 57)
			{
				num5 = array2[num2 - 51][0][num7 + 1][2];
			}
		}
		if (num8 == 0)
		{
			if (num5 != 0)
			{
				MainGameScene.slotGameMan.m_kaidoData[635] = num5;
				MainGameScene.slotGameMan.set_pkd_data(635, num5);
			}
		}
		else if (num6 >= num8)
		{
			num = ((num2 < 7 || 26 < num2) ? array2[num2 - 51][0][num7][1] : array[num2 - 7][num7][1]);
			MainGameScene.slotGameMan.set_pdt_data(5, num);
			MainGameScene.slotGameMan.m_dirData[5] = num;
			MainGameScene.slotGameMan.m_kaidoData[636]++;
			MainGameScene.slotGameMan.set_pkd_data(636, MainGameScene.slotGameMan.m_kaidoData[636]);
			MainGameScene.slotGameMan.m_kaidoData[637] = 0;
			MainGameScene.slotGameMan.set_pkd_data(637, MainGameScene.slotGameMan.m_kaidoData[637]);
			MainGameScene.slotGameMan.m_kaidoData[635] = num5;
			MainGameScene.slotGameMan.set_pkd_data(635, num5);
			int trg = num4 - 1;
			flag = true;
			command[num3].high = (byte)MainGameScene.slotGameMan.get_dir_cmd2(trg, 0, usGrp, num);
			command[num3].low = (byte)MainGameScene.slotGameMan.get_dir_cmd2(trg, 1, usGrp, num);
			command[num3].mode = (byte)MainGameScene.slotGameMan.get_dir_cmd2(trg, 2, usGrp, num);
			MainGameScene.dirMan.OnPush(num3, command[num3].high, command[num3].low, command[num3].mode, flag);
			for (int i = 0; i < 7; i++)
			{
				byte b = (byte)MainGameScene.slotGameMan.get_dir_cmd2(i, 0, usGrp, num);
				byte b2 = (byte)MainGameScene.slotGameMan.get_dir_cmd2(i, 1, usGrp, num);
				byte b3 = (byte)MainGameScene.slotGameMan.get_dir_cmd2(i, 2, usGrp, num);
			}
			pushFlag = true;
		}
	}

	public void startLot_PushHUC()
	{
		int[] array = new int[9] { 0, 64, 65, 66, 67, 68, 69, 70, 71 };
		bool flag = true;
		int num = MainGameScene.slotGameMan.get_pkd_data(6);
		int usGrp = MainGameScene.slotGameMan.get_pdt_data(1);
		int num2 = MainGameScene.slotGameMan.get_pdt_data(29);
		int num3 = MainGameScene.slotGameMan.get_pkd_data(48);
		int num4 = MainGameScene.slotGameMan.get_pkd_data(51);
		int num5 = 0;
		if (num3 >= 2)
		{
			num3 -= 2;
		}
		int num6 = MainGameScene.slotGameMan.m_kaidoData[637];
		bool flag2 = false;
		num5 = 1 + num6 / 5;
		switch (num6)
		{
		case 5:
			num = ((num2 < 1 || 8 < num2) ? 58 : array[num2]);
			break;
		case 10:
			num = ((num2 < 9 || 16 < num2) ? 59 : array[num2 - 8]);
			break;
		case 15:
			num = ((num2 < 17 || 24 < num2) ? 60 : array[num2 - 16]);
			break;
		case 20:
			num = ((num2 < 25 || 32 < num2) ? 61 : array[num2 - 24]);
			break;
		case 25:
			num = ((num2 < 33 || 40 < num2) ? 62 : array[num2 - 32]);
			break;
		case 30:
			num = ((num2 < 41 || 48 < num2) ? 63 : array[num2 - 40]);
			break;
		case 35:
			num = ((num2 < 49 || 56 < num2) ? 58 : array[num2 - 48]);
			break;
		default:
			return;
		}
		MainGameScene.slotGameMan.set_pdt_data(5, num);
		MainGameScene.slotGameMan.m_dirData[5] = num;
		MainGameScene.slotGameMan.m_kaidoData[635] = num5;
		MainGameScene.slotGameMan.set_pkd_data(635, num5);
		int trg = num4 - 1;
		flag = true;
		command[num3].high = (byte)MainGameScene.slotGameMan.get_dir_cmd2(trg, 0, usGrp, num);
		command[num3].low = (byte)MainGameScene.slotGameMan.get_dir_cmd2(trg, 1, usGrp, num);
		command[num3].mode = (byte)MainGameScene.slotGameMan.get_dir_cmd2(trg, 2, usGrp, num);
		MainGameScene.dirMan.OnPush(num3, command[num3].high, command[num3].low, command[num3].mode, flag);
		pushFlag = true;
	}

	public void init()
	{
		int num = 15;
		for (int i = 0; i < num; i++)
		{
			command[i].high = 0;
			command[i].low = 0;
			command[i].mode = 0;
		}
	}

	public byte getHigh(COMMAND cmd)
	{
		if (cmd < COMMAND.LEVER_ON || cmd >= COMMAND.MAX)
		{
			return 0;
		}
		return command[(int)cmd].high;
	}

	public byte getLow(COMMAND cmd)
	{
		if (cmd < COMMAND.LEVER_ON || cmd >= COMMAND.MAX)
		{
			return 0;
		}
		return command[(int)cmd].low;
	}

	public byte getMode(COMMAND cmd)
	{
		if (cmd < COMMAND.LEVER_ON || cmd >= COMMAND.MAX)
		{
			return 0;
		}
		return command[(int)cmd].mode;
	}

	public void setCommand(int _trg)
	{
		if ((byte)MainGameScene.slotGameMan.get_dir_cmd(_trg, 0) != 0 && ((byte)MainGameScene.slotGameMan.get_dir_cmd(_trg, 0) != 127 || (byte)MainGameScene.slotGameMan.get_dir_cmd(_trg, 2) != 1))
		{
			command[_trg].high = (byte)MainGameScene.slotGameMan.get_dir_cmd(_trg, 0);
			command[_trg].low = (byte)MainGameScene.slotGameMan.get_dir_cmd(_trg, 1);
			command[_trg].mode = (byte)MainGameScene.slotGameMan.get_dir_cmd(_trg, 2);
		}
	}

	public void setCommand(int _trg, int _trg2)
	{
		if ((byte)MainGameScene.slotGameMan.get_dir_cmd(_trg, 0) != 0 && ((byte)MainGameScene.slotGameMan.get_dir_cmd(_trg2, 0) != 127 || (byte)MainGameScene.slotGameMan.get_dir_cmd(_trg2, 2) != 1))
		{
			command[_trg].high = (byte)MainGameScene.slotGameMan.get_dir_cmd(_trg2, 0);
			command[_trg].low = (byte)MainGameScene.slotGameMan.get_dir_cmd(_trg2, 1);
			command[_trg].mode = (byte)MainGameScene.slotGameMan.get_dir_cmd(_trg2, 2);
		}
	}

	public void setCommand(int _trg, byte _high, byte _low, byte _mode)
	{
		command[_trg].high = _high;
		command[_trg].low = _low;
		command[_trg].mode = _mode;
	}

	public void setFukugoCommand(int _cmd)
	{
		int[][] array = new int[5][]
		{
			new int[3] { 0, 0, 2 },
			new int[3] { 8, 21, 4 },
			new int[3] { 10, 22, 5 },
			new int[3] { 11, 23, 6 },
			new int[3] { 12, 0, 0 }
		};
		int num = 7;
		int num2 = 14;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		bool flag = false;
		if (MainGameScene.slotGameMan.get_pdt_data(15) != 0 && _cmd == 0)
		{
			num3 = 17;
			num4 = 15;
		}
		else if (MainGameScene.slotGameMan.get_pdt_data(16) != 0)
		{
			num3 = 29;
			num4 = 16;
			if ((MainGameScene.slotGameMan.get_koyaku_prm(0) != 0 || MainGameScene.slotGameMan.get_koyaku_prm(1) != 1 || MainGameScene.slotGameMan.get_koyaku_prm(2) != 0) && MainGameScene.slotGameMan.get_pdt_data(16) == 288)
			{
				MainGameScene.slotGameMan.m_dirData[16] = 0;
				MainGameScene.slotGameMan.set_pdt_data(16, 0);
			}
		}
		else if (MainGameScene.slotGameMan.get_pdt_data(18) != 0)
		{
			num3 = 36;
			num4 = 18;
		}
		else if (MainGameScene.slotGameMan.get_pdt_data(20) != 0)
		{
			num3 = 70;
			num4 = 20;
		}
		else if (MainGameScene.slotGameMan.get_pdt_data(22) != 0)
		{
			num3 = 92;
			num4 = 22;
		}
		else if (MainGameScene.slotGameMan.get_pdt_data(23) != 0)
		{
			num3 = 93;
			num4 = 23;
		}
		else if (MainGameScene.slotGameMan.get_pdt_data(27) != 0)
		{
			num3 = 38;
			num4 = 27;
			MainGameScene.slotGameMan.set_pdt_data(27, 0);
		}
		else if (MainGameScene.slotGameMan.get_pdt_data(28) != 0)
		{
			num3 = 30;
			num4 = 28;
		}
		if (MainGameScene.slotGameMan.get_pdt_data(21) != 0)
		{
			if (MainGameScene.slotMan.m_State == SlotBodyManager.STATE.REEL_END3)
			{
				num3 = 77;
				num4 = 21;
				command[12].high = 73;
				command[12].low = 2;
				command[12].mode = 0;
				if (MainGameScene.slotGameMan.get_pdt_data(21) == 97 || MainGameScene.slotGameMan.get_pdt_data(21) == 112)
				{
					command[13].high = 73;
					command[13].low = 2;
					command[13].mode = 10;
				}
				return;
			}
			if (MainGameScene.slotMan.m_State == SlotBodyManager.STATE.STANDBY)
			{
				return;
			}
		}
		if (!flag)
		{
			if (MainGameScene.slotGameMan.get_pdt_data(num4) != 0)
			{
				for (int i = num; i < num2; i++)
				{
					command[i].high = (byte)MainGameScene.slotGameMan.get_dir_cmd2(i - num, 0, num3, MainGameScene.slotGameMan.get_pdt_data(num4));
					command[i].low = (byte)MainGameScene.slotGameMan.get_dir_cmd2(i - num, 1, num3, MainGameScene.slotGameMan.get_pdt_data(num4));
					command[i].mode = (byte)MainGameScene.slotGameMan.get_dir_cmd2(i - num, 2, num3, MainGameScene.slotGameMan.get_pdt_data(num4));
				}
				if (num3 == 92)
				{
					command[13].high = 127;
					command[13].low = 0;
					command[13].mode = 2;
				}
			}
			else
			{
				for (int j = num; j < 15; j++)
				{
					command[j].high = 0;
					command[j].low = 0;
					command[j].mode = 0;
				}
			}
			if (MainGameScene.slotGameMan.get_pdt_data(34) != 0 && MainGameScene.slotGameMan.get_pdt_data(1) != 90)
			{
				int num6 = num3;
				int num7 = num4;
				num3 = 90;
				num4 = 34;
				command[14].high = (byte)MainGameScene.slotGameMan.get_dir_cmd2(_cmd, 0, num3, MainGameScene.slotGameMan.get_pdt_data(num4));
				command[14].low = (byte)MainGameScene.slotGameMan.get_dir_cmd2(_cmd, 1, num3, MainGameScene.slotGameMan.get_pdt_data(num4));
				command[14].mode = (byte)MainGameScene.slotGameMan.get_dir_cmd2(_cmd, 2, num3, MainGameScene.slotGameMan.get_pdt_data(num4));
				num3 = num6;
				num4 = num7;
			}
		}
		if (MainGameScene.slotGameMan.isGijiren())
		{
			num5 = MainGameScene.slotGameMan.m_oldGijiNum;
			if (num5 > 4)
			{
				num5 = 4;
			}
			command[7].high = (byte)MainGameScene.slotGameMan.get_dir_cmd2(0, 0, 87, array[num5][1]);
			command[7].low = (byte)MainGameScene.slotGameMan.get_dir_cmd2(0, 1, 87, array[num5][1]);
			command[7].mode = (byte)MainGameScene.slotGameMan.get_dir_cmd2(0, 2, 87, array[num5][1]);
			command[13].high = (byte)MainGameScene.slotGameMan.get_dir_cmd2(6, 0, 87, array[num5][2]);
			command[13].low = (byte)MainGameScene.slotGameMan.get_dir_cmd2(6, 1, 87, array[num5][2]);
			command[13].mode = (byte)MainGameScene.slotGameMan.get_dir_cmd2(6, 2, 87, array[num5][2]);
			flag = true;
		}
		if (MainGameScene.slotGameMan.get_pkd_data(86) != 5 || MainGameScene.slotGameMan.get_koyaku_prm(0) != 0 || MainGameScene.slotGameMan.get_koyaku_prm(1) != 1 || MainGameScene.slotGameMan.get_koyaku_prm(2) != 0)
		{
			return;
		}
		if (MainGameScene.slotMan.m_State == SlotBodyManager.STATE.REEL_WAIT)
		{
			setCommand(8, 28, 1, 51);
		}
		else if (MainGameScene.slotMan.m_State == SlotBodyManager.STATE.REEL_STOP1)
		{
			if (MainGameScene.reelMan.getReelStop(0) == 7 || MainGameScene.reelMan.getReelStop(1) == 6 || MainGameScene.reelMan.getReelStop(2) == 11)
			{
				MainGameScene.dirMan.pbZugaraStop(0);
			}
		}
		else if (MainGameScene.slotMan.m_State == SlotBodyManager.STATE.REEL_STOP2)
		{
			if ((MainGameScene.reelMan.getReelStop(0) == 7 && (MainGameScene.reelMan.getReelStop(1) == 6 || MainGameScene.reelMan.getReelStop(2) == 11)) || (MainGameScene.reelMan.getReelStop(1) == 6 && MainGameScene.reelMan.getReelStop(2) == 11))
			{
				MainGameScene.dirMan.pbZugaraStop(1);
			}
		}
		else if (MainGameScene.slotMan.m_State == SlotBodyManager.STATE.REEL_STOP3 && MainGameScene.reelMan.getReelStop(0) == 7 && MainGameScene.reelMan.getReelStop(1) == 6 && MainGameScene.reelMan.getReelStop(2) == 11)
		{
			MainGameScene.dirMan.pbZugaraStop(2);
		}
	}

	public int getKoyaku()
	{
		return MainGameScene.slotGameMan.get_koyaku_prm(2);
	}

	public int reelStopNum(int _num)
	{
		int result = _num;
		int[][] array = new int[10][]
		{
			new int[3] { 0, 1, 2 },
			new int[3] { 0, 1, 2 },
			new int[3] { 0, 2, 1 },
			new int[3] { 1, 0, 2 },
			new int[3] { 1, 2, 0 },
			new int[3] { 2, 0, 1 },
			new int[3] { 2, 1, 0 },
			new int[3] { 0, 1, 2 },
			new int[3] { 1, 0, 2 },
			new int[3] { 2, 1, 0 }
		};
		int num = MainGameScene.slotGameMan.get_pri_data(2);
		if (MainGameScene.slotGameMan.getDirDestroy())
		{
			num = 6;
		}
		if (num >= 0 && 10 > num)
		{
			result = array[num][_num];
		}
		return result;
	}
}
