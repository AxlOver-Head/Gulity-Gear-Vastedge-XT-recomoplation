public class Direction35DHI : DirectionBase
{
	public Direction35DHI(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.dhi001_loop, DirectionManager.MOVIE.dhi001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S2027, Sound.CH.SE0, true, 1f, 0);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi002, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.dhi002_loop, DirectionManager.MOVIE.dhi002, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0469, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2024, Sound.CH.SE0, false, 1f, 6);
				break;
			case 3:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.dhi003_loop, DirectionManager.MOVIE.dhi003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0470, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2025, Sound.CH.SE0, false, 1f, 6);
				break;
			case 4:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi004, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.dhi005_haikei, DirectionManager.MOVIE.dhi004, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0466, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0861, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2026, Sound.CH.SE0, false, 1f, 27);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_haikei, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0471, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE0, true, 1f, 15);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_10, false, false, false, false, 0, 0, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_10_add, false, false, true, false, 0, 0, 98, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.dhi005_10_add_loop, DirectionManager.MOVIE.dhi005_10_add, false, true, true, false);
				break;
			case 6:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_haikei, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0471, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE0, true, 1f, 25);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_20, false, false, false, false, 0, 0, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_20_add, false, false, true, false, 0, 0, 98, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.dhi005_20_add_loop, DirectionManager.MOVIE.dhi005_20_add, false, true, true, false);
				break;
			case 7:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_haikei, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0471, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE0, true, 1f, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_30, false, false, false, false, 0, 0, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_30_add, false, false, true, false, 0, 0, 98, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.dhi005_30_add_loop, DirectionManager.MOVIE.dhi005_30_add, false, true, true, false);
				break;
			case 8:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_haikei, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0471, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE0, true, 1f, 57);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_50, false, false, false, false, 0, 0, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_50_add, false, false, true, false, 0, 0, 98, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.dhi005_50_addloop, DirectionManager.MOVIE.dhi005_50_add, false, true, true, false);
				break;
			case 9:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_haikei, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0471, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE0, true, 1f, 85);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_100, false, false, false, false, 0, 0, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_100_add, false, false, true, false, 0, 0, 98, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.dhi005_100_add_loop, DirectionManager.MOVIE.dhi005_100_add, false, true, true, false);
				break;
			case 10:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_haikei, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0471, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE0, true, 1f, 114);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_150, false, false, false, false, 0, 0, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_150_add, false, false, true, false, 0, 0, 98, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.dhi005_150_add_loop, DirectionManager.MOVIE.dhi005_150_add, false, true, true, false);
				break;
			case 11:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_haikei, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0471, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE0, true, 1f, 141);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_200, false, false, false, false, 0, 0, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_200_add, false, false, true, false, 0, 0, 98, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.dhi005_200_add_loop, DirectionManager.MOVIE.dhi005_200_add, false, true, true, false);
				break;
			case 12:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_haikei, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0471, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE0, true, 1f, 164);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_300, false, false, false, false, 0, 0, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_300_add, false, false, true, false, 0, 0, 98, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.dhi005_300_add_loop, DirectionManager.MOVIE.dhi005_300_add, false, true, true, false);
				break;
			case 13:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_haikei, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0366, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.btd003, false, false, false, true, 128, 72, 99, 11);
				evt.eventAddMovie(DirectionManager.MOVIE.btd003_loop, DirectionManager.MOVIE.btd003, false, true, false, true);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_723();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_725();
				break;
			case 14:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_haikei, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0471, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0232, Sound.CH.SE0, true, 1f, 11);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_7, false, false, false, false, 0, 0, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi005_7_add, false, false, true, false, 0, 0, 98, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.dhi005_7_add_loop, DirectionManager.MOVIE.dhi005_7_add, false, true, true, false);
				break;
			case 15:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.dhi001_loop, DirectionManager.MOVIE.dhi001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S2027, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_731();
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi011, false, false, false, true, 128, 105, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi011_loop, false, false, false, true, 128, 105, 99, 76);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi011_add, false, false, false, true, 128, 72, 98, 10);
				break;
			case 16:
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi002, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.dhi002_loop, DirectionManager.MOVIE.dhi002, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0469, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2024, Sound.CH.SE0, true, 1f, 6);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_731();
				break;
			case 17:
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.dhi003_loop, DirectionManager.MOVIE.dhi003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0470, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2025, Sound.CH.SE0, true, 1f, 6);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_731();
				break;
			case 18:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi004, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0466, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0861, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2026, Sound.CH.SE0, true, 1f, 27);
				evt.eventPlayMovie(DirectionManager.MOVIE.dhi012, false, false, false, false, 0, 0, 99, 0);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 2:
				DirectionLedManager.GD_DHI_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 3:
				DirectionLedManager.GD_DHI_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 4:
				DirectionLedManager.GD_DHI_03(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 5:
				break;
			case 6:
				break;
			case 7:
				break;
			case 8:
				break;
			case 9:
				break;
			case 10:
				break;
			case 11:
				break;
			case 12:
				break;
			case 13:
				break;
			case 14:
				break;
			case 15:
				DirectionLedManager.YK_DHI_dest(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_dest_02(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_6M));
				break;
			case 16:
				DirectionLedManager.YK_DHI_dest_1st(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 17:
				DirectionLedManager.YK_DHI_dest_2nd(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 18:
				DirectionLedManager.YK_DHI_dest_3rd(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.OFF_5m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_6M));
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
		base.control();
	}
}
