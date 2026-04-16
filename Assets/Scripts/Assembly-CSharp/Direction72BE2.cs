public class Direction72BE2 : DirectionBase
{
	private int m_cnt;

	public Direction72BE2(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		m_cnt = 0;
		base.start();
		if (low == 0)
		{
			switch (mode)
			{
			case 2:
				evt.eventPlayMovie(DirectionManager.MOVIE.bm2_3, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0160, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 237);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 99, 207);
				break;
			case 3:
				evt.eventPlayMovie(DirectionManager.MOVIE.bm2_3, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 237);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 99, 207);
				break;
			case 6:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_01, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 7:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_02, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 8:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_03, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 9:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_04, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 10:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_05, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 11:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_06, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 12:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_07, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 13:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_08, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 14:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_09, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 15:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_10, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 16:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_11, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 17:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_12, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 18:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_13, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 19:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_14, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 20:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_15, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 21:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_16, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 22:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_17, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 23:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_18, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 24:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_19, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 25:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_20, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 26:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_21, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 27:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_22, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 28:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_23, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 29:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_24, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 30:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_25, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 31:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_26, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 32:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_27, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			case 33:
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_28, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0155, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 51);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001a_2_x, false, false, true, false, 0, 0, 99, 51);
				evt.eventPlayMovie(DirectionManager.MOVIE.be2001b, false, false, false, false, 0, -4, 98, 21);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 2:
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.m_panel_win_PB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 3:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 6:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 7:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 8:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 9:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 10:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 11:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 12:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 13:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 14:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 15:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 16:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 17:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 18:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 19:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 20:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 21:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 22:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 23:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 24:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 25:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 26:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 27:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 28:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 29:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 30:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 31:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 32:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 33:
				DirectionLedManager.m_panel_win_SGB_end(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 34:
				break;
			case 35:
				break;
			case 36:
				break;
			case 37:
				break;
			case 4:
			case 5:
				break;
			}
		}
	}

	public override void end()
	{
		be2_killMovie(99f);
		be2_killMovie(98f);
		base.end();
	}

	public void be2_killMovie(float layer)
	{
		int num = SGLG.prod.findLayer(layer);
		if (num >= 0)
		{
			SGLG.prod.Kill(num);
		}
	}

	public override void control()
	{
		if (evt.m_Active && low == 0)
		{
			if (mode == 2 || mode == 3)
			{
				if (m_cnt == 237)
				{
					MainGameScene.pnlMan.onBe2001_get();
				}
				if (m_cnt == 257)
				{
					MainGameScene.pnlMan.onBe2001_total();
				}
			}
			else
			{
				if (m_cnt == 0)
				{
					MainGameScene.dirMan.changeStageIntarface(21);
				}
				if (m_cnt == 51)
				{
					MainGameScene.pnlMan.onBe2001_get();
				}
				if (m_cnt == 71)
				{
					MainGameScene.pnlMan.onBe2001_total();
				}
			}
			m_cnt++;
		}
		base.control();
	}
}
