public class Direction38IKG : DirectionBase
{
	public Direction38IKG(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		base.start();
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ikg005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ikg001_a, DirectionManager.MOVIE.ikg005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ikg001_a_loop, DirectionManager.MOVIE.ikg001_a, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0206, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0202, Sound.CH.BGM, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0458, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0459, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1958, Sound.CH.VC0, true, 1f, 132);
				break;
			case 2:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_742();
				break;
			case 3:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_742();
				break;
			case 4:
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0074, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ikg001_a_b, false, false, false, false, 0, 0, 100, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.ikg001_a_b_loop, DirectionManager.MOVIE.ikg001_a_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0459, Sound.CH.SE0, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0460, Sound.CH.SE0, true, 1f, 77);
				evt.eventPlaySound(DirectionManager.SOUND.S1958, Sound.CH.VC0, true, 1f, 108);
				evt.eventPlaySound(DirectionManager.SOUND.S0203, Sound.CH.BGM, true, 1f, 149);
				break;
			case 5:
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0074, Sound.CH.SE1, true, 1f, 0);
				switch ((byte)MainGameScene.slotGameMan.get_pdt_data(79))
				{
				case 4:
				case 8:
				case 10:
				case 11:
				case 15:
					evt.eventPlayMovie(DirectionManager.MOVIE.ikg001_b_c, false, false, false, false, 0, 0, 100, 72);
					evt.eventAddMovie(DirectionManager.MOVIE.ikg001_b_c_loop, DirectionManager.MOVIE.ikg001_b_c, false, true, false, false);
					break;
				default:
					evt.eventPlayMovie(DirectionManager.MOVIE.ikg001_a_c, false, false, false, false, 0, 0, 100, 72);
					evt.eventAddMovie(DirectionManager.MOVIE.ikg001_a_c_loop, DirectionManager.MOVIE.ikg001_a_c, false, true, false, false);
					break;
				}
				evt.eventPlaySound(DirectionManager.SOUND.S0459, Sound.CH.SE0, true, 1f, 52);
				evt.eventPlaySound(DirectionManager.SOUND.S0460, Sound.CH.SE0, true, 1f, 81);
				evt.eventPlaySound(DirectionManager.SOUND.S0461, Sound.CH.SE0, true, 1f, 113);
				evt.eventPlaySound(DirectionManager.SOUND.S1958, Sound.CH.VC0, true, 1f, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0204, Sound.CH.BGM, true, 1f, 184);
				break;
			case 7:
				evt.eventPlayMovie(DirectionManager.MOVIE.ikg002_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ikg002_a_loop, DirectionManager.MOVIE.ikg002_a, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0423, Sound.CH.SE0, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0280, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1260, Sound.CH.VC0, false, 1f, 10);
				break;
			case 8:
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ikg002_a_b, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ikg002_a_b_loop, DirectionManager.MOVIE.ikg002_a_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0074, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0459, Sound.CH.SE0, false, 1f, 52);
				evt.eventPlaySound(DirectionManager.SOUND.S0460, Sound.CH.SE0, false, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0252, Sound.CH.SE0, false, 1f, 102);
				evt.eventPlaySound(DirectionManager.SOUND.S0977, Sound.CH.VC0, false, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S0203, Sound.CH.BGM, true, 1f, 149);
				break;
			case 9:
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				switch ((byte)MainGameScene.slotGameMan.get_pdt_data(79))
				{
				case 4:
				case 8:
				case 10:
				case 11:
				case 15:
					evt.eventPlayMovie(DirectionManager.MOVIE.ikg002_b_c, false, false, false, false, 0, 0, 100, 72);
					evt.eventAddMovie(DirectionManager.MOVIE.ikg002_b_c_loop, DirectionManager.MOVIE.ikg002_b_c, false, true, false, false);
					break;
				default:
					evt.eventPlayMovie(DirectionManager.MOVIE.ikg002_a_c, false, false, false, false, 0, 0, 100, 72);
					evt.eventAddMovie(DirectionManager.MOVIE.ikg002_a_c_loop, DirectionManager.MOVIE.ikg002_a_c, false, true, false, false);
					break;
				}
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0074, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0459, Sound.CH.SE0, false, 1f, 52);
				evt.eventPlaySound(DirectionManager.SOUND.S0460, Sound.CH.SE0, false, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0439, Sound.CH.SE0, false, 1f, 130);
				evt.eventPlaySound(DirectionManager.SOUND.S1313, Sound.CH.VC0, false, 1f, 173);
				evt.eventPlaySound(DirectionManager.SOUND.S0204, Sound.CH.BGM, true, 1f, 184);
				break;
			case 10:
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ikg005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ikg001_b, DirectionManager.MOVIE.ikg005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ikg001_b_loop, DirectionManager.MOVIE.ikg001_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0206, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0203, Sound.CH.BGM, true, 1f, 149);
				evt.eventPlaySound(DirectionManager.SOUND.S0458, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0459, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S0460, Sound.CH.SE0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S1958, Sound.CH.VC0, true, 1f, 155);
				break;
			case 11:
				evt.eventPlayMovie(DirectionManager.MOVIE.ikg002_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ikg002_b_loop, DirectionManager.MOVIE.ikg002_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0423, Sound.CH.SE0, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0280, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0977, Sound.CH.VC0, false, 1f, 10);
				break;
			case 12:
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ikg005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ikg001_c, DirectionManager.MOVIE.ikg005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ikg001_c_loop, DirectionManager.MOVIE.ikg001_c, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0206, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0204, Sound.CH.BGM, true, 1f, 184);
				evt.eventPlaySound(DirectionManager.SOUND.S0458, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0459, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S0460, Sound.CH.SE0, true, 1f, 127);
				evt.eventPlaySound(DirectionManager.SOUND.S0461, Sound.CH.SE0, true, 1f, 159);
				evt.eventPlaySound(DirectionManager.SOUND.S1958, Sound.CH.VC0, true, 1f, 190);
				break;
			case 13:
				evt.eventPlayMovie(DirectionManager.MOVIE.ikg002_c, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ikg002_c_loop, DirectionManager.MOVIE.ikg002_c, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0423, Sound.CH.SE0, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0280, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1313, Sound.CH.VC0, false, 1f, 10);
				break;
			case 17:
				evt.eventPlayMovie(DirectionManager.MOVIE.ikg004, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ikg004_loop, DirectionManager.MOVIE.ikg004, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0257, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1806, Sound.CH.VC0, true, 1f, 20);
				break;
			}
		}
		if (MainGameScene.slotGameMan.get_pdt_data(45) == 4 || MainGameScene.slotGameMan.get_pdt_data(46) == 4 || (MainGameScene.slotGameMan.ulDedamaLotState & 0x20000) != 0L)
		{
			evt.eventKillAnime(DirectionManager.ANIME.standby, 0);
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.OFF_1(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
				DirectionLedManager.JG_IKG_start(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.OFF_3(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_IKG_start(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
				DirectionLedManager.OFF_9(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_1));
				DirectionLedManager.OFF_10(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_2));
				DirectionLedManager.OFF_11(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_3));
				DirectionLedManager.OFF_12(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_4));
				DirectionLedManager.OFF_13(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_5));
				DirectionLedManager.OFF_14(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_6));
				DirectionLedManager.OFF_15(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_DI));
				DirectionLedManager.OFF_16(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DEMO));
				DirectionLedManager.m_panel_win_heat_01(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 2:
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.LG_YTK_red_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
				DirectionLedManager.OFF_9(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_1));
				DirectionLedManager.OFF_10(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_2));
				DirectionLedManager.OFF_11(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_3));
				DirectionLedManager.OFF_12(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_4));
				DirectionLedManager.OFF_13(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_5));
				DirectionLedManager.OFF_14(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_6));
				DirectionLedManager.OFF_15(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_DI));
				DirectionLedManager.OFF_16(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DEMO));
				break;
			case 3:
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.LG_YTK_red_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
				DirectionLedManager.OFF_9(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_1));
				DirectionLedManager.OFF_10(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_2));
				DirectionLedManager.OFF_11(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_3));
				DirectionLedManager.OFF_12(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_4));
				DirectionLedManager.OFF_13(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_5));
				DirectionLedManager.OFF_14(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_6));
				DirectionLedManager.OFF_15(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_DI));
				DirectionLedManager.OFF_16(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DEMO));
				break;
			case 4:
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
				DirectionLedManager.OFF_9(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_1));
				DirectionLedManager.OFF_10(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_2));
				DirectionLedManager.OFF_11(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_3));
				DirectionLedManager.OFF_12(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_4));
				DirectionLedManager.OFF_13(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_5));
				DirectionLedManager.OFF_14(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_6));
				DirectionLedManager.OFF_15(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_DI));
				DirectionLedManager.OFF_16(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DEMO));
				DirectionLedManager.m_panel_win_heat_02(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 5:
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
				DirectionLedManager.OFF_9(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_1));
				DirectionLedManager.OFF_10(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_2));
				DirectionLedManager.OFF_11(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_3));
				DirectionLedManager.OFF_12(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_4));
				DirectionLedManager.OFF_13(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_5));
				DirectionLedManager.OFF_14(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_6));
				DirectionLedManager.OFF_15(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_DI));
				DirectionLedManager.OFF_16(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DEMO));
				DirectionLedManager.m_panel_win_heat_03(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 7:
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
				DirectionLedManager.OFF_9(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_1));
				DirectionLedManager.OFF_10(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_2));
				DirectionLedManager.OFF_11(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_3));
				DirectionLedManager.OFF_12(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_4));
				DirectionLedManager.OFF_13(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_5));
				DirectionLedManager.OFF_14(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_6));
				DirectionLedManager.OFF_15(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_DI));
				DirectionLedManager.OFF_16(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DEMO));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 8:
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
				DirectionLedManager.OFF_9(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_1));
				DirectionLedManager.OFF_10(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_2));
				DirectionLedManager.OFF_11(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_3));
				DirectionLedManager.OFF_12(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_4));
				DirectionLedManager.OFF_13(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_5));
				DirectionLedManager.OFF_14(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_6));
				DirectionLedManager.OFF_15(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_DI));
				DirectionLedManager.OFF_16(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DEMO));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 9:
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
				DirectionLedManager.OFF_9(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_1));
				DirectionLedManager.OFF_10(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_2));
				DirectionLedManager.OFF_11(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_3));
				DirectionLedManager.OFF_12(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_4));
				DirectionLedManager.OFF_13(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_5));
				DirectionLedManager.OFF_14(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_6));
				DirectionLedManager.OFF_15(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_DI));
				DirectionLedManager.OFF_16(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DEMO));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 10:
				DirectionLedManager.OFF_1(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
				DirectionLedManager.JG_IKG_start(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.OFF_3(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_IKG_start(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
				DirectionLedManager.OFF_9(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_1));
				DirectionLedManager.OFF_10(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_2));
				DirectionLedManager.OFF_11(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_3));
				DirectionLedManager.OFF_12(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_4));
				DirectionLedManager.OFF_13(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_5));
				DirectionLedManager.OFF_14(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_6));
				DirectionLedManager.OFF_15(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_DI));
				DirectionLedManager.OFF_16(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DEMO));
				DirectionLedManager.m_panel_win_heat_02(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 11:
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
				DirectionLedManager.OFF_9(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_1));
				DirectionLedManager.OFF_10(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_2));
				DirectionLedManager.OFF_11(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_3));
				DirectionLedManager.OFF_12(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_4));
				DirectionLedManager.OFF_13(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_5));
				DirectionLedManager.OFF_14(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_6));
				DirectionLedManager.OFF_15(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_DI));
				DirectionLedManager.OFF_16(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DEMO));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 12:
				DirectionLedManager.OFF_1(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
				DirectionLedManager.JG_IKG_start(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.OFF_3(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_IKG_start(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
				DirectionLedManager.OFF_9(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_1));
				DirectionLedManager.OFF_10(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_2));
				DirectionLedManager.OFF_11(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_3));
				DirectionLedManager.OFF_12(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_4));
				DirectionLedManager.OFF_13(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_5));
				DirectionLedManager.OFF_14(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_6));
				DirectionLedManager.OFF_15(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_DI));
				DirectionLedManager.OFF_16(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DEMO));
				DirectionLedManager.m_panel_win_heat_03(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 13:
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
				DirectionLedManager.OFF_9(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_1));
				DirectionLedManager.OFF_10(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_2));
				DirectionLedManager.OFF_11(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_3));
				DirectionLedManager.OFF_12(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_4));
				DirectionLedManager.OFF_13(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_5));
				DirectionLedManager.OFF_14(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_6));
				DirectionLedManager.OFF_15(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_DI));
				DirectionLedManager.OFF_16(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DEMO));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 14:
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
				DirectionLedManager.OFF_9(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_1));
				DirectionLedManager.OFF_10(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_2));
				DirectionLedManager.OFF_11(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_3));
				DirectionLedManager.OFF_12(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_4));
				DirectionLedManager.OFF_13(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_5));
				DirectionLedManager.OFF_14(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_6));
				DirectionLedManager.OFF_15(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_DI));
				DirectionLedManager.OFF_16(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DEMO));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 15:
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
				DirectionLedManager.OFF_9(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_1));
				DirectionLedManager.OFF_10(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_2));
				DirectionLedManager.OFF_11(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_3));
				DirectionLedManager.OFF_12(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_4));
				DirectionLedManager.OFF_13(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_5));
				DirectionLedManager.OFF_14(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_6));
				DirectionLedManager.OFF_15(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_DI));
				DirectionLedManager.OFF_16(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DEMO));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 16:
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
				DirectionLedManager.OFF_9(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_1));
				DirectionLedManager.OFF_10(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_2));
				DirectionLedManager.OFF_11(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_3));
				DirectionLedManager.OFF_12(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_4));
				DirectionLedManager.OFF_13(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_5));
				DirectionLedManager.OFF_14(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_6));
				DirectionLedManager.OFF_15(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_DI));
				DirectionLedManager.OFF_16(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DEMO));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 17:
				DirectionLedManager.OFF_3(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
				DirectionLedManager.OFF_9(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_1));
				DirectionLedManager.OFF_10(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_2));
				DirectionLedManager.OFF_11(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_3));
				DirectionLedManager.OFF_12(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_4));
				DirectionLedManager.OFF_13(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_5));
				DirectionLedManager.OFF_14(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_6));
				DirectionLedManager.OFF_15(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_DI));
				DirectionLedManager.OFF_16(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DEMO));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 18:
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
				DirectionLedManager.OFF_9(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_1));
				DirectionLedManager.OFF_10(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_2));
				DirectionLedManager.OFF_11(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_3));
				DirectionLedManager.OFF_12(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_4));
				DirectionLedManager.OFF_13(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_5));
				DirectionLedManager.OFF_14(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_6));
				DirectionLedManager.OFF_15(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_DI));
				DirectionLedManager.OFF_16(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DEMO));
				break;
			case 19:
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
				DirectionLedManager.OFF_9(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_1));
				DirectionLedManager.OFF_10(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_2));
				DirectionLedManager.OFF_11(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_3));
				DirectionLedManager.OFF_12(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_4));
				DirectionLedManager.OFF_13(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_5));
				DirectionLedManager.OFF_14(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_6));
				DirectionLedManager.OFF_15(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_DI));
				DirectionLedManager.OFF_16(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DEMO));
				break;
			}
		}
		setBonusSyokakuState();
	}

	public override void end()
	{
		int num = SGLG.prod.findLayer(190f);
		if (num >= 0)
		{
			SGLG.prod.Kill(num);
		}
		base.end();
	}

	public override void control()
	{
		base.control();
	}

	private void setBonusSyokakuState()
	{
		int num = 0;
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				num = mode;
				break;
			case 4:
				num = mode;
				break;
			case 5:
				num = mode;
				break;
			case 7:
				num = mode;
				break;
			case 8:
				num = mode;
				break;
			case 9:
				num = mode;
				break;
			case 10:
				num = mode;
				break;
			case 11:
				num = mode;
				break;
			case 12:
				num = mode;
				break;
			case 13:
				num = mode;
				break;
			}
		}
		if (num > 0)
		{
			MainGameScene.slotGameMan.set_pdt_data(79, num);
		}
	}

	public static void restartBGM()
	{
		switch (MainGameScene.slotGameMan.get_pdt_data(79))
		{
		case 7:
		case 14:
			if (SGLG.sound.getBGMID() == 97)
			{
				if (SGLG.sound.getBGMVolume() < 1f)
				{
					SGLG.sound.SetVolume(Sound.CH.BGM, 1f);
				}
			}
			else
			{
				SGLG.sound.PlaySound(97, Sound.CH.BGM, true);
				SGLG.sound.SetVolume(Sound.CH.BGM, 1f);
			}
			break;
		case 11:
		case 15:
			if (SGLG.sound.getBGMID() == 98)
			{
				if (SGLG.sound.getBGMVolume() < 1f)
				{
					SGLG.sound.SetVolume(Sound.CH.BGM, 1f);
				}
			}
			else
			{
				SGLG.sound.PlaySound(98, Sound.CH.BGM, true);
				SGLG.sound.SetVolume(Sound.CH.BGM, 1f);
			}
			break;
		case 13:
		case 16:
			if (SGLG.sound.getBGMID() == 99)
			{
				if (SGLG.sound.getBGMVolume() < 1f)
				{
					SGLG.sound.SetVolume(Sound.CH.BGM, 1f);
				}
			}
			else
			{
				SGLG.sound.PlaySound(99, Sound.CH.BGM, true);
				SGLG.sound.SetVolume(Sound.CH.BGM, 1f);
			}
			break;
		case 6:
		case 17:
			if (SGLG.sound.getBGMID() == 100)
			{
				if (SGLG.sound.getBGMVolume() < 1f)
				{
					SGLG.sound.SetVolume(Sound.CH.BGM, 1f);
				}
			}
			else
			{
				SGLG.sound.PlaySound(100, Sound.CH.BGM, true);
				SGLG.sound.SetVolume(Sound.CH.BGM, 1f);
			}
			break;
		case 8:
		case 9:
		case 10:
		case 12:
			break;
		}
	}
}
