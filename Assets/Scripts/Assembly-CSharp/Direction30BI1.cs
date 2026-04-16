public class Direction30BI1 : DirectionBase
{
	private int m_count;

	public Direction30BI1(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		base.start();
		MainGameScene.slotGameMan.set_pdt_data(79, 0);
		switch (low)
		{
		case 0:
			switch (mode)
			{
			case 1:
				evt.eventPlayMovie(DirectionManager.MOVIE.bi1001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bi1001_loop, DirectionManager.MOVIE.bi1001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0148, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0464, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0975, Sound.CH.VC0, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S0906, Sound.CH.VC0, true, 1f, 152);
				break;
			case 2:
				evt.eventPlayMovie(DirectionManager.MOVIE.bi1002, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bi1002_loop, DirectionManager.MOVIE.bi1002, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0148, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0463, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0976, Sound.CH.VC0, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S0906, Sound.CH.VC0, true, 1f, 136);
				break;
			case 3:
				evt.eventPlayMovie(DirectionManager.MOVIE.bi1003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bi1003_loop, DirectionManager.MOVIE.bi1003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0148, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0462, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1210, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1257, Sound.CH.VC0, true, 1f, 84);
				break;
			case 4:
				evt.eventPlayMovie(DirectionManager.MOVIE.bi1005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bi1005_loop, DirectionManager.MOVIE.bi1005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0074, Sound.CH.SE1, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_464();
				break;
			case 5:
				evt.eventPlayMovie(DirectionManager.MOVIE.bi1001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bi1001_loop, DirectionManager.MOVIE.bi1001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0148, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0464, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0975, Sound.CH.VC0, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S0906, Sound.CH.VC0, true, 1f, 152);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_468();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_469();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_471();
				break;
			case 6:
				evt.eventPlayMovie(DirectionManager.MOVIE.bi1002, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bi1002_loop, DirectionManager.MOVIE.bi1002, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0148, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0463, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0976, Sound.CH.VC0, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S0906, Sound.CH.VC0, true, 1f, 136);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_468();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_469();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_471();
				break;
			}
			break;
		case 1:
			switch (mode)
			{
			case 7:
				evt.eventPlayMovie(DirectionManager.MOVIE.bi1003_loop, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bi1004, true, false, true, false, 0, 0, 90, 0);
				break;
			case 8:
				evt.eventPlayMovie(DirectionManager.MOVIE.bi1002_loop, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bi1004, true, false, true, false, 0, 0, 90, 0);
				break;
			case 9:
				evt.eventPlayMovie(DirectionManager.MOVIE.bi1003_loop, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bi1005, false, false, false, false, 0, 0, 100, 80);
				evt.eventAddMovie(DirectionManager.MOVIE.bi1005_loop, DirectionManager.MOVIE.bi1005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0074, Sound.CH.SE1, true, 1f, 80);
				evt.eventPlayMovie(DirectionManager.MOVIE.bi1002, false, false, false, false, 0, 0, 100, 213);
				evt.eventAddMovie(DirectionManager.MOVIE.bi1002_loop, DirectionManager.MOVIE.bi1002, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0148, Sound.CH.BGM, true, 1f, 213);
				evt.eventPlaySound(DirectionManager.SOUND.S0463, Sound.CH.SE0, true, 1f, 213);
				evt.eventPlaySound(DirectionManager.SOUND.S0976, Sound.CH.VC0, true, 1f, 295);
				evt.eventPlaySound(DirectionManager.SOUND.S0906, Sound.CH.VC0, true, 1f, 349);
				evt.eventPlayMovie(DirectionManager.MOVIE.bi1004, true, false, true, false, 0, 0, 90, 0);
				break;
			case 10:
				evt.eventPlayMovie(DirectionManager.MOVIE.bi1003_loop, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bi1005, false, false, false, false, 0, 0, 100, 80);
				evt.eventAddMovie(DirectionManager.MOVIE.bi1005_loop, DirectionManager.MOVIE.bi1005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0074, Sound.CH.SE1, true, 1f, 80);
				evt.eventPlayMovie(DirectionManager.MOVIE.bi1001, false, false, false, false, 0, 0, 100, 213);
				evt.eventAddMovie(DirectionManager.MOVIE.bi1001_loop, DirectionManager.MOVIE.bi1001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0148, Sound.CH.BGM, true, 1f, 213);
				evt.eventPlaySound(DirectionManager.SOUND.S0464, Sound.CH.SE0, true, 1f, 213);
				evt.eventPlaySound(DirectionManager.SOUND.S0975, Sound.CH.VC0, true, 1f, 295);
				evt.eventPlaySound(DirectionManager.SOUND.S0906, Sound.CH.VC0, true, 1f, 365);
				evt.eventPlayMovie(DirectionManager.MOVIE.bi1004, true, false, true, false, 0, 0, 90, 0);
				break;
			case 11:
				evt.eventPlayMovie(DirectionManager.MOVIE.bi1002_loop, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bi1005, false, false, false, false, 0, 0, 100, 80);
				evt.eventAddMovie(DirectionManager.MOVIE.bi1005_loop, DirectionManager.MOVIE.bi1005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0074, Sound.CH.SE1, true, 1f, 80);
				evt.eventPlayMovie(DirectionManager.MOVIE.bi1001, false, false, false, false, 0, 0, 100, 213);
				evt.eventAddMovie(DirectionManager.MOVIE.bi1001_loop, DirectionManager.MOVIE.bi1001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0148, Sound.CH.BGM, true, 1f, 213);
				evt.eventPlaySound(DirectionManager.SOUND.S0464, Sound.CH.SE0, true, 1f, 213);
				evt.eventPlaySound(DirectionManager.SOUND.S0975, Sound.CH.VC0, true, 1f, 295);
				evt.eventPlaySound(DirectionManager.SOUND.S0906, Sound.CH.VC0, true, 1f, 365);
				evt.eventPlayMovie(DirectionManager.MOVIE.bi1004, true, false, true, false, 0, 0, 90, 0);
				break;
			}
			break;
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.JG_SGB_in_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
				DirectionLedManager.YK_SGB_in_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win_SGB_in(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 2:
				DirectionLedManager.JG_GB_in_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
				DirectionLedManager.YK_GB_in_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win_GB_in(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 3:
				DirectionLedManager.JG_RB_in(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
				DirectionLedManager.YK_RB_in(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win_RB_in(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 4:
				DirectionLedManager.JYD_unite_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 5:
				DirectionLedManager.JG_SGB_in_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
				DirectionLedManager.YK_SGB_in_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win_SGB_in(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 6:
				DirectionLedManager.JG_GB_in_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
				DirectionLedManager.YK_GB_in_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win_GB_in(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			}
		}
		byte b = low;
		if (b == 1)
		{
			m_count = 0;
			switch (mode)
			{
			case 7:
				evt.reel.FreezeReelAct10();
				break;
			case 8:
				evt.reel.FreezeReelAct10();
				break;
			case 9:
				evt.reel.FreezeReelAct11();
				break;
			case 10:
				evt.reel.FreezeReelAct12();
				break;
			case 11:
				evt.reel.FreezeReelAct12();
				break;
			}
		}
	}

	public override void end()
	{
		base.end();
	}

	public override void control()
	{
		if (evt.m_Active)
		{
			byte b = low;
			if (b == 1)
			{
				switch (mode)
				{
				case 9:
					if (m_count == 80)
					{
						DirectionYakuManager._MAIN_GIMMICK_PTTERNS_464();
					}
					else if (m_count == 213)
					{
						DirectionLedManager.JG_GB_in_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
						DirectionLedManager.YK_GB_in_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
						DirectionLedManager.m_panel_win_GB_in(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
						DirectionYakuManager._MAIN_GIMMICK_PTTERNS_468();
						DirectionYakuManager._MAIN_GIMMICK_PTTERNS_469();
						DirectionYakuManager._MAIN_GIMMICK_PTTERNS_471();
					}
					break;
				case 10:
					if (m_count == 80)
					{
						DirectionYakuManager._MAIN_GIMMICK_PTTERNS_464();
					}
					else if (m_count == 213)
					{
						DirectionLedManager.JG_SGB_in_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
						DirectionLedManager.YK_SGB_in_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
						DirectionLedManager.m_panel_win_SGB_in(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
						DirectionYakuManager._MAIN_GIMMICK_PTTERNS_468();
						DirectionYakuManager._MAIN_GIMMICK_PTTERNS_469();
						DirectionYakuManager._MAIN_GIMMICK_PTTERNS_471();
					}
					break;
				case 11:
					if (m_count == 80)
					{
						DirectionYakuManager._MAIN_GIMMICK_PTTERNS_464();
					}
					else if (m_count == 213)
					{
						DirectionLedManager.JG_SGB_in_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
						DirectionLedManager.YK_SGB_in_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
						DirectionLedManager.m_panel_win_SGB_in(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
						DirectionYakuManager._MAIN_GIMMICK_PTTERNS_468();
						DirectionYakuManager._MAIN_GIMMICK_PTTERNS_469();
						DirectionYakuManager._MAIN_GIMMICK_PTTERNS_471();
					}
					break;
				}
			}
			m_count++;
		}
		base.control();
	}
}
