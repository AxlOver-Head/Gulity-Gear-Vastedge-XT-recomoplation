public class Direction88HUC : DirectionBase
{
	public Direction88HUC(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventPlayMovie(DirectionManager.MOVIE.huc006, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0235, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0446, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0990, Sound.CH.VC0, true, 1f, 7);
				evt.eventPlaySound(DirectionManager.SOUND.S0075, Sound.CH.SE0, true, 1f, 100);
				evt.eventAddMovie(DirectionManager.MOVIE.huc006_loop, DirectionManager.MOVIE.huc006, false, true, false, false);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_W, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0902, Sound.CH.VC0, true, 1f, 10);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_W_loop, DirectionManager.MOVIE.huc008_W, false, true, false, false);
				break;
			case 3:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_W, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_W_loop, DirectionManager.MOVIE.huc008_W, false, true, false, false);
				break;
			case 4:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_B, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0449, Sound.CH.SE1, true, 1f, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_B_loop, DirectionManager.MOVIE.huc008_B, false, true, false, false);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_Y, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0450, Sound.CH.SE1, true, 1f, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_Y_loop, DirectionManager.MOVIE.huc008_Y, false, true, false, false);
				break;
			case 6:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_G, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0451, Sound.CH.SE1, true, 1f, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_G_loop, DirectionManager.MOVIE.huc008_G, false, true, false, false);
				break;
			case 7:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_R, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0452, Sound.CH.SE1, true, 1f, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_R_loop, DirectionManager.MOVIE.huc008_R, false, true, false, false);
				break;
			case 8:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_P, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_P_loop, DirectionManager.MOVIE.huc008_P, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE0, true, 1f, 0);
				break;
			case 9:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_N, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0454, Sound.CH.SE1, true, 1f, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_N_loop, DirectionManager.MOVIE.huc008_N, false, true, false, false);
				break;
			case 10:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0162, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0455, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 16);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1557();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1560();
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 101, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				break;
			case 11:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0162, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0455, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 16);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1561();
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 101, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				break;
			case 12:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0162, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0455, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 16);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1565();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1568();
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 101, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				break;
			case 13:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0162, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0455, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 16);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1569();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1570();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1572();
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 101, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				break;
			case 14:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0162, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0455, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 16);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1573();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1574();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1576();
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 101, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				break;
			case 15:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0162, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0455, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 16);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1577();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1578();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1580();
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 101, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				break;
			case 16:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0162, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0455, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 16);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1581();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1582();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1584();
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 101, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				break;
			case 17:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0162, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0455, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 16);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1585();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1586();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1588();
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 101, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.HUC_lever(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 2:
				DirectionLedManager.HUC_white(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 3:
				DirectionLedManager.HUC_white(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 4:
				DirectionLedManager.HUC_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 5:
				DirectionLedManager.HUC_yellow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 6:
				DirectionLedManager.HUC_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 7:
				DirectionLedManager.HUC_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 8:
				DirectionLedManager.HUC_purple(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 9:
				DirectionLedManager.HUC_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			}
		}
		if (low == 0 && mode == 2)
		{
			DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1541();
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
