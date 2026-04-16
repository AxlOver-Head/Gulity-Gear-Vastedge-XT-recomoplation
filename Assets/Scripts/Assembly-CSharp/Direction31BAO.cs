public class Direction31BAO : DirectionBase
{
	public Direction31BAO(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		restartBGM();
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao1000, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao1000_loop, DirectionManager.MOVIE.bao1000, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0157, Sound.CH.BGM, true, 1f, 70);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE1, true, 1f, 23);
				evt.eventPlaySound(DirectionManager.SOUND.S1612, Sound.CH.VC0, true, 1f, 58);
				evt.eventPlaySound(DirectionManager.SOUND.S0555, Sound.CH.SE0, true, 1f, 70);
				evt.eventPlaySound(DirectionManager.SOUND.S1613, Sound.CH.VC1, true, 1f, 139);
				evt.eventPlaySound(DirectionManager.SOUND.S0957, Sound.CH.VC0, true, 1f, 211);
				evt.eventPlaySound(DirectionManager.SOUND.S0665, Sound.CH.SE1, true, 1f, 254);
				evt.eventPlaySound(DirectionManager.SOUND.S1614, Sound.CH.VC1, true, 1f, 257);
				evt.eventPlaySound(DirectionManager.SOUND.S0967, Sound.CH.VC0, true, 1f, 318);
				evt.eventPlaySound(DirectionManager.SOUND.S0666, Sound.CH.SE0, true, 1f, 354);
				break;
			case 2:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2100, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2100_loop, DirectionManager.MOVIE.bao2100, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0667, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0907, Sound.CH.VC0, true, 1f, 23);
				break;
			case 3:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2110, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2110_loop, DirectionManager.MOVIE.bao2110, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0476, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0910, Sound.CH.VC0, true, 1f, 20);
				break;
			case 4:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2111, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2111, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0647, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE1, true, 1f, 23);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC0, true, 1f, 31);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_482();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 90, 50);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 50);
				break;
			case 5:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2111, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2111, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0647, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE1, true, 1f, 23);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC0, true, 1f, 31);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_482();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 90, 50);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 50);
				break;
			case 6:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2111, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2111, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0647, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE1, true, 1f, 23);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC0, true, 1f, 31);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_482();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 90, 50);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 50);
				break;
			case 7:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2111, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2111, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0647, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE1, true, 1f, 23);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC0, true, 1f, 31);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_486();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_488();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 90, 50);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 50);
				break;
			case 8:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2111, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2111, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0647, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE1, true, 1f, 23);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC0, true, 1f, 31);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_486();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_488();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 90, 50);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 50);
				break;
			case 9:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2111, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2111, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0647, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE1, true, 1f, 23);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC0, true, 1f, 31);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_486();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_488();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 90, 50);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 50);
				break;
			case 10:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2111, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2111, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0647, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE1, true, 1f, 23);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC0, true, 1f, 31);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_492();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_494();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 90, 50);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 50);
				break;
			case 11:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2111, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2111, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0647, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE1, true, 1f, 23);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC0, true, 1f, 31);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_492();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_494();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 90, 50);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 50);
				break;
			case 12:
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2008_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2008_sol_loop, DirectionManager.MOVIE.hsl2008_sol, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0669, Sound.CH.SE1, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S0864, Sound.CH.VC0, true, 1f, 45);
				break;
			case 13:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2121, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2121, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0670, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE1, true, 1f, 35);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC0, true, 1f, 41);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_501();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 90, 60);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 60);
				break;
			case 14:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2121, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2121, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0670, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE1, true, 1f, 35);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC0, true, 1f, 41);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_501();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 90, 60);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 60);
				break;
			case 15:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2121, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2121, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0670, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE1, true, 1f, 35);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC0, true, 1f, 41);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_501();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 90, 60);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 60);
				break;
			case 16:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2121, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2121, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0670, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE1, true, 1f, 35);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC0, true, 1f, 41);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_505();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_507();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 90, 60);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 60);
				break;
			case 17:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2121, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2121, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0670, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE1, true, 1f, 35);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC0, true, 1f, 41);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_505();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_507();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 90, 60);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 60);
				break;
			case 18:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2121, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2121, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0670, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE1, true, 1f, 35);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC0, true, 1f, 41);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_505();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_507();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 90, 60);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 60);
				break;
			case 19:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2121, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2121, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0670, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE1, true, 1f, 35);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC0, true, 1f, 41);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_511();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_513();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 90, 60);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 60);
				break;
			case 20:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2121, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2121, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0670, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE1, true, 1f, 35);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC0, true, 1f, 41);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_511();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_513();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 90, 60);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 60);
				break;
			case 21:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2200, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2200_loop, DirectionManager.MOVIE.bao2200, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0668, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1625, Sound.CH.VC0, true, 1f, 15);
				break;
			case 22:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2210, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2210_loop, DirectionManager.MOVIE.bao2210, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0632, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1616, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0641, Sound.CH.SE1, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S1617, Sound.CH.VC1, true, 1f, 30);
				break;
			case 24:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2211, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2212, DirectionManager.MOVIE.bao2211, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0671, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0939, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0266, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0492, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0935, Sound.CH.VC1, true, 1f, 85);
				break;
			case 25:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2241, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2240, DirectionManager.MOVIE.bao2241, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2240, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0549, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0921, Sound.CH.VC1, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 77);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_520();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_522();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 90, 105);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 105);
				break;
			case 26:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2241, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2240, DirectionManager.MOVIE.bao2241, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2240, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0549, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0921, Sound.CH.VC1, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 77);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_520();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_522();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 90, 105);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 105);
				break;
			case 27:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2241, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2240, DirectionManager.MOVIE.bao2241, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2240, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0549, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0921, Sound.CH.VC1, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 77);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_520();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_522();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 90, 105);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 105);
				break;
			case 28:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2241, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2240, DirectionManager.MOVIE.bao2241, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2240, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0549, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0921, Sound.CH.VC1, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 77);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_526();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_528();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 90, 105);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 105);
				break;
			case 29:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2241, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2240, DirectionManager.MOVIE.bao2241, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2240, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0549, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0921, Sound.CH.VC1, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 77);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_526();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_528();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 90, 105);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 105);
				break;
			case 30:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2241, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2240, DirectionManager.MOVIE.bao2241, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2240, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0549, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0921, Sound.CH.VC1, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 77);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_526();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_528();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 90, 105);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 105);
				break;
			case 31:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2241, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2240, DirectionManager.MOVIE.bao2241, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2240, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0549, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0921, Sound.CH.VC1, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 77);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_532();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_534();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 90, 105);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 105);
				break;
			case 32:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2241, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2240, DirectionManager.MOVIE.bao2241, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2240, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0549, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0921, Sound.CH.VC1, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 77);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_532();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_534();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 90, 105);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 105);
				break;
			case 33:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2220, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2220_loop, DirectionManager.MOVIE.bao2220, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0672, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1618, Sound.CH.VC0, true, 1f, 18);
				break;
			case 35:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2221, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2212, DirectionManager.MOVIE.bao2221, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0671, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0939, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0266, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0492, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0935, Sound.CH.VC1, true, 1f, 85);
				break;
			case 36:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2242, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2240, DirectionManager.MOVIE.bao2242, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2240, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0549, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0921, Sound.CH.VC1, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 77);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_540();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_542();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 90, 105);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 105);
				break;
			case 37:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2242, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2240, DirectionManager.MOVIE.bao2242, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2240, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0549, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0921, Sound.CH.VC1, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 77);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_540();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_542();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 90, 105);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 105);
				break;
			case 38:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2242, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2240, DirectionManager.MOVIE.bao2242, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2240, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0549, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0921, Sound.CH.VC1, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 77);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_540();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_542();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 90, 105);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 105);
				break;
			case 39:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2242, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2240, DirectionManager.MOVIE.bao2242, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2240, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0549, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0921, Sound.CH.VC1, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 77);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_546();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_548();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 90, 105);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 105);
				break;
			case 40:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2242, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2240, DirectionManager.MOVIE.bao2242, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2240, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0549, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0921, Sound.CH.VC1, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 77);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_546();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_548();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 90, 105);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 105);
				break;
			case 41:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2242, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2240, DirectionManager.MOVIE.bao2242, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2240, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0549, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0921, Sound.CH.VC1, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 77);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_546();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_548();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 90, 105);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 105);
				break;
			case 42:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2242, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2240, DirectionManager.MOVIE.bao2242, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2240, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0549, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0921, Sound.CH.VC1, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 77);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_552();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_554();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 90, 105);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 105);
				break;
			case 43:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2242, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2240, DirectionManager.MOVIE.bao2242, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2240, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0549, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0921, Sound.CH.VC1, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 77);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_552();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_554();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 90, 105);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 105);
				break;
			case 44:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2230, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2230_loop, DirectionManager.MOVIE.bao2230, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0673, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1624, Sound.CH.VC0, true, 1f, 29);
				break;
			case 45:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2243, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2240, DirectionManager.MOVIE.bao2243, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2240, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0549, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0921, Sound.CH.VC1, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 77);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_560();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_562();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 90, 105);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 105);
				break;
			case 46:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2243, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2240, DirectionManager.MOVIE.bao2243, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2240, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0549, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0921, Sound.CH.VC1, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 77);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_560();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_562();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 90, 105);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 105);
				break;
			case 47:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2243, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2240, DirectionManager.MOVIE.bao2243, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2240, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0549, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0921, Sound.CH.VC1, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 77);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_560();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_562();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 90, 105);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 105);
				break;
			case 48:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2243, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2240, DirectionManager.MOVIE.bao2243, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2240, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0549, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0921, Sound.CH.VC1, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 77);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_566();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_568();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 90, 105);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 105);
				break;
			case 49:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2243, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2240, DirectionManager.MOVIE.bao2243, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2240, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0549, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0921, Sound.CH.VC1, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 77);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_566();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_568();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 90, 105);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 105);
				break;
			case 50:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2243, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2240, DirectionManager.MOVIE.bao2243, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2240, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0549, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0921, Sound.CH.VC1, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 77);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_566();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_568();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 90, 105);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 105);
				break;
			case 51:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2243, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2240, DirectionManager.MOVIE.bao2243, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2240, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0549, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0921, Sound.CH.VC1, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 77);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_572();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_574();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 90, 105);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 105);
				break;
			case 52:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2243, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2240, DirectionManager.MOVIE.bao2243, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2240, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0549, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0921, Sound.CH.VC1, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 77);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_572();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_574();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 90, 105);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 105);
				break;
			case 53:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2300, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0262, Sound.CH.SE0, true, 1f, 0);
				break;
			case 54:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2320, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0262, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0581, Sound.CH.SE1, true, 1f, 0);
				break;
			case 55:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2312, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2111, DirectionManager.MOVIE.bao2312, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2111, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0263, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0924, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0647, Sound.CH.SE1, true, 1f, 34);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC1, true, 1f, 65);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_580();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_582();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 90, 83);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 83);
				break;
			case 56:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2312, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2111, DirectionManager.MOVIE.bao2312, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2111, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0263, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0924, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0647, Sound.CH.SE1, true, 1f, 34);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC1, true, 1f, 65);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_580();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_582();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 90, 83);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 83);
				break;
			case 57:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2312, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2111, DirectionManager.MOVIE.bao2312, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2111, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0263, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0924, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0647, Sound.CH.SE1, true, 1f, 34);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC1, true, 1f, 65);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_580();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_582();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 90, 83);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 83);
				break;
			case 58:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2312, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2111, DirectionManager.MOVIE.bao2312, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2111, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0263, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0924, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0647, Sound.CH.SE1, true, 1f, 34);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC1, true, 1f, 65);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_586();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_588();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 90, 83);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 83);
				break;
			case 59:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2312, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2111, DirectionManager.MOVIE.bao2312, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2111, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0263, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0924, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0647, Sound.CH.SE1, true, 1f, 34);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC1, true, 1f, 65);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_586();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_588();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 90, 83);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 83);
				break;
			case 60:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2312, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2111, DirectionManager.MOVIE.bao2312, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2111, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0263, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0924, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0647, Sound.CH.SE1, true, 1f, 34);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC1, true, 1f, 65);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_586();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_588();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 90, 83);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 83);
				break;
			case 61:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2312, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2111, DirectionManager.MOVIE.bao2312, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2111, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0263, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0924, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0647, Sound.CH.SE1, true, 1f, 34);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC1, true, 1f, 65);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_592();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_594();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 90, 83);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 83);
				break;
			case 62:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2312, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2111, DirectionManager.MOVIE.bao2312, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2111, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0263, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0924, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0647, Sound.CH.SE1, true, 1f, 34);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC1, true, 1f, 65);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_592();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_594();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 90, 83);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 83);
				break;
			case 63:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2321, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2212_hit, DirectionManager.MOVIE.bao2321, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2212, DirectionManager.MOVIE.bao2212_hit, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0264, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1622, Sound.CH.VC0, true, 1f, 11);
				evt.eventPlaySound(DirectionManager.SOUND.S0674, Sound.CH.SE1, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0671, Sound.CH.SE0, true, 1f, 103);
				evt.eventPlaySound(DirectionManager.SOUND.S0939, Sound.CH.VC1, true, 1f, 103);
				evt.eventPlaySound(DirectionManager.SOUND.S0266, Sound.CH.SE1, true, 1f, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0492, Sound.CH.SE0, true, 1f, 175);
				evt.eventPlaySound(DirectionManager.SOUND.S0935, Sound.CH.VC0, true, 1f, 188);
				break;
			case 64:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2310, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0262, Sound.CH.SE0, true, 1f, 0);
				break;
			case 65:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2322, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2111, DirectionManager.MOVIE.bao2322, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2111, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0263, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0924, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0647, Sound.CH.SE1, true, 1f, 34);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC1, true, 1f, 65);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_580();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_582();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 90, 83);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 83);
				break;
			case 66:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2322, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2111, DirectionManager.MOVIE.bao2322, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2111, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0263, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0924, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0647, Sound.CH.SE1, true, 1f, 34);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC1, true, 1f, 65);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_580();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_582();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 90, 83);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 83);
				break;
			case 67:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2322, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2111, DirectionManager.MOVIE.bao2322, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2111, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0263, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0924, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0647, Sound.CH.SE1, true, 1f, 34);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC1, true, 1f, 65);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_580();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_582();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 90, 83);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 83);
				break;
			case 68:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2322, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2111, DirectionManager.MOVIE.bao2322, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2111, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0263, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0924, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0647, Sound.CH.SE1, true, 1f, 34);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC1, true, 1f, 65);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_586();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_588();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 90, 83);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 83);
				break;
			case 69:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2322, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2111, DirectionManager.MOVIE.bao2322, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2111, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0263, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0924, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0647, Sound.CH.SE1, true, 1f, 34);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC1, true, 1f, 65);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_586();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_588();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 90, 83);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 83);
				break;
			case 70:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2322, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2111, DirectionManager.MOVIE.bao2322, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2111, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0263, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0924, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0647, Sound.CH.SE1, true, 1f, 34);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC1, true, 1f, 65);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_586();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_588();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 90, 83);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 83);
				break;
			case 71:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2322, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2111, DirectionManager.MOVIE.bao2322, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2111, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0263, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0924, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0647, Sound.CH.SE1, true, 1f, 34);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC1, true, 1f, 65);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_592();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_594();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 90, 83);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 83);
				break;
			case 72:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2322, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2111, DirectionManager.MOVIE.bao2322, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112, DirectionManager.MOVIE.bao2111, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2112_loop, DirectionManager.MOVIE.bao2112, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0263, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0924, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0647, Sound.CH.SE1, true, 1f, 34);
				evt.eventPlaySound(DirectionManager.SOUND.S0465, Sound.CH.SE0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S1619, Sound.CH.VC1, true, 1f, 65);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_592();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_594();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 90, 83);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 83);
				break;
			case 73:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2311, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2212_hit, DirectionManager.MOVIE.bao2311, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2212, DirectionManager.MOVIE.bao2212_hit, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0264, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1622, Sound.CH.VC0, true, 1f, 11);
				evt.eventPlaySound(DirectionManager.SOUND.S0674, Sound.CH.SE1, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0671, Sound.CH.SE0, true, 1f, 103);
				evt.eventPlaySound(DirectionManager.SOUND.S0939, Sound.CH.VC1, true, 1f, 103);
				evt.eventPlaySound(DirectionManager.SOUND.S0266, Sound.CH.SE1, true, 1f, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0492, Sound.CH.SE0, true, 1f, 175);
				evt.eventPlaySound(DirectionManager.SOUND.S0935, Sound.CH.VC0, true, 1f, 188);
				break;
			case 74:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao3100, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0280, Sound.CH.SE0, true, 1f, 8);
				evt.eventPlaySound(DirectionManager.SOUND.S0484, Sound.CH.SE1, true, 1f, 11);
				evt.eventPlaySound(DirectionManager.SOUND.S1637, Sound.CH.VC0, true, 1f, 50);
				break;
			case 75:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao3110, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao3110_loop, DirectionManager.MOVIE.bao3110, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0675, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1626, Sound.CH.VC0, true, 1f, 20);
				break;
			case 76:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao3211, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao3211_loop, DirectionManager.MOVIE.bao3211, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0424, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0634, Sound.CH.SE1, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_619();
				break;
			case 77:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao3212_add2, false, false, true, false, 0, 0, 52, 12);
				evt.eventAddMovie(DirectionManager.MOVIE.bao3212_loop_add, DirectionManager.MOVIE.bao3212_add2, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0494, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1047, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bao3212, false, false, false, false, 0, 0, 51, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao3212_loop, DirectionManager.MOVIE.bao3212, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bao3212_add, true, false, true, false, 0, 0, 50, 0);
				break;
			case 78:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao3241, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao3241_loop, DirectionManager.MOVIE.bao3241, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0424, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0634, Sound.CH.SE1, true, 1f, 0);
				break;
			case 79:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao3212_add2, false, false, true, false, 0, 0, 52, 12);
				evt.eventAddMovie(DirectionManager.MOVIE.bao3212_loop_add, DirectionManager.MOVIE.bao3212_add2, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0494, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1047, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bao3212, false, false, false, false, 0, 0, 51, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao3212_loop, DirectionManager.MOVIE.bao3212, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bao3212_add, true, false, true, false, 0, 0, 50, 0);
				break;
			case 80:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao3251, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao3251_loop, DirectionManager.MOVIE.bao3251, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0424, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0634, Sound.CH.SE1, true, 1f, 0);
				break;
			case 81:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao3212_add2, false, false, true, false, 0, 0, 52, 12);
				evt.eventAddMovie(DirectionManager.MOVIE.bao3212_loop_add, DirectionManager.MOVIE.bao3212_add2, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0494, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1047, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bao3212, false, false, false, false, 0, 0, 51, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao3212_loop, DirectionManager.MOVIE.bao3212, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bao3212_add, true, false, true, false, 0, 0, 50, 0);
				break;
			case 82:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao3400_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao3400, DirectionManager.MOVIE.bao3400_a, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 281);
				evt.eventPlaySound(DirectionManager.SOUND.S0281, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0274, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S1627, Sound.CH.VC0, true, 1f, 104);
				evt.eventPlaySound(DirectionManager.SOUND.S0257, Sound.CH.SE0, true, 1f, 134);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE1, true, 1f, 197);
				evt.eventPlaySound(DirectionManager.SOUND.S0931, Sound.CH.VC1, true, 1f, 240);
				break;
			case 83:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao3400_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao3400, DirectionManager.MOVIE.bao3400_b, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 281);
				evt.eventPlaySound(DirectionManager.SOUND.S0281, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0274, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S1627, Sound.CH.VC0, true, 1f, 104);
				evt.eventPlaySound(DirectionManager.SOUND.S0257, Sound.CH.SE0, true, 1f, 134);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE1, true, 1f, 197);
				evt.eventPlaySound(DirectionManager.SOUND.S0931, Sound.CH.VC1, true, 1f, 240);
				break;
			case 84:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao3400_c, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao3400, DirectionManager.MOVIE.bao3400_c, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 281);
				evt.eventPlaySound(DirectionManager.SOUND.S0281, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0274, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S1627, Sound.CH.VC0, true, 1f, 104);
				evt.eventPlaySound(DirectionManager.SOUND.S0257, Sound.CH.SE0, true, 1f, 134);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE1, true, 1f, 197);
				evt.eventPlaySound(DirectionManager.SOUND.S0931, Sound.CH.VC1, true, 1f, 240);
				break;
			case 85:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao3500_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao3500, DirectionManager.MOVIE.bao3500_a, false, false, false, false);
				evt.eventStopSound(Sound.CH.BGM, 182);
				evt.eventPlaySound(DirectionManager.SOUND.S0445, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1623, Sound.CH.VC0, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0680, Sound.CH.SE1, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0671, Sound.CH.SE0, true, 1f, 136);
				evt.eventPlaySound(DirectionManager.SOUND.S1040, Sound.CH.VC1, true, 1f, 136);
				evt.eventPlaySound(DirectionManager.SOUND.S0940, Sound.CH.VC0, true, 1f, 176);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, true, 1f, 182);
				break;
			case 86:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao3500_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao3500, DirectionManager.MOVIE.bao3500_b, false, false, false, false);
				evt.eventStopSound(Sound.CH.BGM, 182);
				evt.eventPlaySound(DirectionManager.SOUND.S0445, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1623, Sound.CH.VC0, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0680, Sound.CH.SE1, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0671, Sound.CH.SE0, true, 1f, 136);
				evt.eventPlaySound(DirectionManager.SOUND.S1040, Sound.CH.VC1, true, 1f, 136);
				evt.eventPlaySound(DirectionManager.SOUND.S0940, Sound.CH.VC0, true, 1f, 176);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, true, 1f, 182);
				break;
			case 87:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao3500_c, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao3500, DirectionManager.MOVIE.bao3500_c, false, false, false, false);
				evt.eventStopSound(Sound.CH.BGM, 182);
				evt.eventPlaySound(DirectionManager.SOUND.S0445, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1623, Sound.CH.VC0, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0680, Sound.CH.SE1, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0671, Sound.CH.SE0, true, 1f, 136);
				evt.eventPlaySound(DirectionManager.SOUND.S1040, Sound.CH.VC1, true, 1f, 136);
				evt.eventPlaySound(DirectionManager.SOUND.S0940, Sound.CH.VC0, true, 1f, 176);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, true, 1f, 182);
				break;
			case 88:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao3400, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 266);
				evt.eventPlaySound(DirectionManager.SOUND.S0281, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0274, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1627, Sound.CH.VC0, true, 1f, 89);
				evt.eventPlaySound(DirectionManager.SOUND.S0257, Sound.CH.SE0, true, 1f, 119);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE1, true, 1f, 182);
				evt.eventPlaySound(DirectionManager.SOUND.S0931, Sound.CH.VC1, true, 1f, 225);
				break;
			case 89:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao4300, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao4300_loop, DirectionManager.MOVIE.bao4300, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0182, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0495, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0821, Sound.CH.VC0, true, 1f, 0);
				break;
			case 90:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao4310, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao3400, DirectionManager.MOVIE.bao4310, false, false, false, false);
				evt.eventStopSound(Sound.CH.BGM, 164);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 430);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0485, Sound.CH.SE1, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0887, Sound.CH.VC0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S0281, Sound.CH.SE0, true, 1f, 164);
				evt.eventPlaySound(DirectionManager.SOUND.S0274, Sound.CH.SE1, true, 1f, 184);
				evt.eventPlaySound(DirectionManager.SOUND.S1627, Sound.CH.VC1, true, 1f, 253);
				evt.eventPlaySound(DirectionManager.SOUND.S0257, Sound.CH.SE1, true, 1f, 283);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE0, true, 1f, 346);
				evt.eventPlaySound(DirectionManager.SOUND.S0931, Sound.CH.VC0, true, 1f, 389);
				break;
			case 91:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao4100, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0958, Sound.CH.VC0, true, 1f, 15);
				break;
			case 92:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao4110, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1629, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0426, Sound.CH.SE0, true, 1f, 67);
				evt.eventPlaySound(DirectionManager.SOUND.S0959, Sound.CH.VC1, true, 1f, 73);
				break;
			case 93:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao4200, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1628, Sound.CH.VC0, true, 1f, 13);
				break;
			case 94:
				evt.eventPlaySound(DirectionManager.SOUND.S0257, Sound.CH.SE0, true, 1f, 0);
				break;
			case 95:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao2231, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao2212, DirectionManager.MOVIE.bao2231, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0671, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0939, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0266, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S0492, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0935, Sound.CH.VC1, true, 1f, 85);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.JG_BAO_start(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.OFF_3(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.OFF_4(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_6(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_start(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
				break;
			case 2:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.LG_BAO_sol_first_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 4:
				DirectionLedManager.YK_BAO_hit_HS(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 5:
				DirectionLedManager.YK_BAO_hit_HS(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 6:
				DirectionLedManager.YK_BAO_hit_HS(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 7:
				DirectionLedManager.YK_BAO_hit_HS(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 8:
				DirectionLedManager.YK_BAO_hit_HS(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 9:
				DirectionLedManager.YK_BAO_hit_HS(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 10:
				DirectionLedManager.YK_BAO_hit_HS(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 11:
				DirectionLedManager.YK_BAO_hit_HS(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 13:
				DirectionLedManager.YK_BAO_hit_GF(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 14:
				DirectionLedManager.YK_BAO_hit_GF(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 15:
				DirectionLedManager.YK_BAO_hit_GF(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 16:
				DirectionLedManager.YK_BAO_hit_GF(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 17:
				DirectionLedManager.YK_BAO_hit_GF(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 18:
				DirectionLedManager.YK_BAO_hit_GF(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 19:
				DirectionLedManager.YK_BAO_hit_GF(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 20:
				DirectionLedManager.YK_BAO_hit_GF(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 21:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 25:
				DirectionLedManager.LG_BAO_sol_first_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 26:
				DirectionLedManager.LG_BAO_sol_first_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 27:
				DirectionLedManager.LG_BAO_sol_first_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 28:
				DirectionLedManager.LG_BAO_sol_first_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 29:
				DirectionLedManager.LG_BAO_sol_first_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 30:
				DirectionLedManager.LG_BAO_sol_first_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 31:
				DirectionLedManager.LG_BAO_sol_first_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 32:
				DirectionLedManager.LG_BAO_sol_first_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 36:
				DirectionLedManager.LG_BAO_sol_first_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 37:
				DirectionLedManager.LG_BAO_sol_first_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 38:
				DirectionLedManager.LG_BAO_sol_first_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 39:
				DirectionLedManager.LG_BAO_sol_first_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 40:
				DirectionLedManager.LG_BAO_sol_first_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 41:
				DirectionLedManager.LG_BAO_sol_first_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 42:
				DirectionLedManager.LG_BAO_sol_first_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 43:
				DirectionLedManager.LG_BAO_sol_first_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 45:
				DirectionLedManager.LG_BAO_sol_first_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 46:
				DirectionLedManager.LG_BAO_sol_first_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 47:
				DirectionLedManager.LG_BAO_sol_first_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 48:
				DirectionLedManager.LG_BAO_sol_first_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 49:
				DirectionLedManager.LG_BAO_sol_first_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 50:
				DirectionLedManager.LG_BAO_sol_first_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 51:
				DirectionLedManager.LG_BAO_sol_first_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 52:
				DirectionLedManager.LG_BAO_sol_first_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 53:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 55:
				DirectionLedManager.LG_BAO_sol_first_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_struggle(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 56:
				DirectionLedManager.LG_BAO_sol_first_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_struggle(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 57:
				DirectionLedManager.LG_BAO_sol_first_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_struggle(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 58:
				DirectionLedManager.LG_BAO_sol_first_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_struggle(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 59:
				DirectionLedManager.LG_BAO_sol_first_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_struggle(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 60:
				DirectionLedManager.LG_BAO_sol_first_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_struggle(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 61:
				DirectionLedManager.LG_BAO_sol_first_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_struggle(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 62:
				DirectionLedManager.LG_BAO_sol_first_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_struggle(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 65:
				DirectionLedManager.LG_BAO_sol_first_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_struggle(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 66:
				DirectionLedManager.LG_BAO_sol_first_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_struggle(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 67:
				DirectionLedManager.LG_BAO_sol_first_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_struggle(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 68:
				DirectionLedManager.LG_BAO_sol_first_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_struggle(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 69:
				DirectionLedManager.LG_BAO_sol_first_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_struggle(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 70:
				DirectionLedManager.LG_BAO_sol_first_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_struggle(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 71:
				DirectionLedManager.LG_BAO_sol_first_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_struggle(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 72:
				DirectionLedManager.LG_BAO_sol_first_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_BAO_hit_struggle(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 74:
				DirectionLedManager.JG_BAO_finalbattle(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.YK_BAO_finalbattle(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 75:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 76:
				DirectionLedManager.GD_BAO_struggle(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 77:
				DirectionLedManager.GD_BAO_struggle(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_BAO_buchikama(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 78:
				DirectionLedManager.GD_BAO_struggle(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 79:
				DirectionLedManager.GD_BAO_struggle(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_BAO_buchikama(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 80:
				DirectionLedManager.GD_BAO_struggle(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 81:
				DirectionLedManager.GD_BAO_struggle(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_BAO_buchikama(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 82:
				DirectionLedManager.GD_BAO_struggle_win(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 83:
				DirectionLedManager.GD_BAO_struggle_win(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 84:
				DirectionLedManager.GD_BAO_struggle_win(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 85:
				DirectionLedManager.GD_BAO_struggle_lose(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 86:
				DirectionLedManager.GD_BAO_struggle_lose(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 87:
				DirectionLedManager.GD_BAO_struggle_lose(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 88:
				DirectionLedManager.m_panel_dest_04(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_6M));
				break;
			case 89:
				DirectionLedManager.LG_BAO_sol_standup(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				evt.reel.FreezeReelAct9();
				break;
			case 82:
			case 83:
			case 84:
			case 88:
			case 90:
			case 94:
			{
				int num = 145;
				switch (mode)
				{
				case 82:
				case 83:
				case 84:
					num = 145;
					break;
				case 88:
					num = 119;
					break;
				case 90:
					num = 283;
					break;
				case 94:
					num = 0;
					break;
				}
				int num2 = MainGameScene.slotGameMan.getTotalUwanoseDUP();
				if (num2 > 9999)
				{
					num2 = 9999;
				}
				int num3 = num2 % 10;
				int num4 = num2 / 10 % 10;
				int num5 = num2 / 100 % 10;
				int num6 = num2 / 1000;
				DirectionManager.IMAGE[] array = new DirectionManager.IMAGE[10]
				{
					DirectionManager.IMAGE.bao4210_num_0,
					DirectionManager.IMAGE.bao4210_num_1,
					DirectionManager.IMAGE.bao4210_num_2,
					DirectionManager.IMAGE.bao4210_num_3_00007,
					DirectionManager.IMAGE.bao4210_num_4_00007,
					DirectionManager.IMAGE.bao4210_num_5_00007,
					DirectionManager.IMAGE.bao4210_num_6_00007,
					DirectionManager.IMAGE.bao4210_num_7_00007,
					DirectionManager.IMAGE.bao4210_num_8_00007,
					DirectionManager.IMAGE.bao4210_num_9_00007
				};
				DirectionManager.MOVIE[] array2 = new DirectionManager.MOVIE[10]
				{
					DirectionManager.MOVIE.bao4210_num_0_add,
					DirectionManager.MOVIE.bao4210_num_1_add,
					DirectionManager.MOVIE.bao4210_num_2_add,
					DirectionManager.MOVIE.bao4210_num_3_add,
					DirectionManager.MOVIE.bao4210_num_4_add,
					DirectionManager.MOVIE.bao4210_num_5_add,
					DirectionManager.MOVIE.bao4210_num_6_add,
					DirectionManager.MOVIE.bao4210_num_7_add,
					DirectionManager.MOVIE.bao4210_num_8_add,
					DirectionManager.MOVIE.bao4210_num_9_add
				};
				if (num6 == 0 && num5 == 0 && num4 == 0)
				{
					evt.eventPlayMovie(DirectionManager.MOVIE.bao4210_1_dummy, true, false, false, true, 128, 88, 80, 0 + num);
					evt.eventPlayImage(array[num3], false, true, 121, 88, 79, 10 + num);
					evt.eventPlayMovie(array2[num3], false, true, true, true, 121, 88, 75, 14 + num);
					evt.eventPlayMovie(DirectionManager.MOVIE.bao4210_total_1, false, false, false, true, 128, 72, 71, 10 + num);
					evt.eventAddMovie(DirectionManager.MOVIE.bao4210_total_1_loop, DirectionManager.MOVIE.bao4210_total_1, false, true, false, true);
				}
				else if (num6 == 0 && num5 == 0)
				{
					evt.eventPlayMovie(DirectionManager.MOVIE.bao4210_2_dummy, true, false, false, true, 128, 88, 80, 0 + num);
					evt.eventPlayImage(array[num3], false, true, 155, 88, 79, 10 + num);
					evt.eventPlayImage(array[num4], false, true, 99, 88, 78, 12 + num);
					evt.eventPlayMovie(array2[num3], false, true, true, true, 155, 88, 75, 12 + num);
					evt.eventPlayMovie(array2[num4], false, true, true, true, 99, 88, 74, 17 + num);
					evt.eventPlayMovie(DirectionManager.MOVIE.bao4210_total_2, false, false, false, true, 128, 72, 71, 10 + num);
					evt.eventAddMovie(DirectionManager.MOVIE.bao4210_total_2_loop, DirectionManager.MOVIE.bao4210_total_2, false, true, false, true);
				}
				else if (num6 == 0)
				{
					evt.eventPlayMovie(DirectionManager.MOVIE.bao4210_3_dummy, true, false, false, true, 128, 88, 80, 0 + num);
					evt.eventPlayImage(array[num3], false, true, 181, 88, 79, 10 + num);
					evt.eventPlayImage(array[num4], false, true, 132, 88, 78, 12 + num);
					evt.eventPlayImage(array[num5], false, true, 84, 88, 77, 14 + num);
					evt.eventPlayMovie(array2[num3], false, true, true, true, 181, 88, 75, 14 + num);
					evt.eventPlayMovie(array2[num4], false, true, true, true, 132, 88, 74, 19 + num);
					evt.eventPlayMovie(array2[num5], false, true, true, true, 84, 88, 73, 24 + num);
					evt.eventPlayMovie(DirectionManager.MOVIE.bao4210_total_3, false, false, false, true, 128, 72, 71, 10 + num);
					evt.eventAddMovie(DirectionManager.MOVIE.bao4210_total_3_loop, DirectionManager.MOVIE.bao4210_total_3, false, true, false, true);
				}
				else
				{
					evt.eventPlayMovie(DirectionManager.MOVIE.bao4210_4_dummy, true, false, false, true, 128, 88, 80, 0 + num);
					evt.eventPlayImage(array[num3], false, true, 217, 88, 79, 11 + num);
					evt.eventPlayImage(array[num4], false, true, 168, 88, 78, 12 + num);
					evt.eventPlayImage(array[num5], false, true, 119, 88, 77, 14 + num);
					evt.eventPlayImage(array[num6], false, true, 70, 88, 76, 15 + num);
					evt.eventPlayMovie(array2[num3], false, true, true, true, 217, 88, 75, 12 + num);
					evt.eventPlayMovie(array2[num4], false, true, true, true, 168, 88, 74, 17 + num);
					evt.eventPlayMovie(array2[num5], false, true, true, true, 119, 88, 73, 22 + num);
					evt.eventPlayMovie(array2[num6], false, true, true, true, 70, 88, 72, 27 + num);
					evt.eventPlayMovie(DirectionManager.MOVIE.bao4210_total_4, false, false, false, true, 128, 72, 71, 10 + num);
					evt.eventAddMovie(DirectionManager.MOVIE.bao4210_total_4_loop, DirectionManager.MOVIE.bao4210_total_4, false, true, false, true);
				}
				break;
			}
			}
		}
		base.start();
	}

	public override void end()
	{
		base.end();
	}

	public override void control()
	{
		base.control();
	}

	private void restartBGM()
	{
		if (low != 0)
		{
			return;
		}
		switch (mode)
		{
		case 1:
		case 89:
		case 90:
		case 91:
		case 92:
			return;
		}
		if (SGLG.sound.getBGMID() == 54)
		{
			if (SGLG.sound.getBGMVolume() < 1f)
			{
				evt.eventFadeSound(Sound.CH.BGM, 1f, 1f, 1, 0);
			}
		}
		else
		{
			evt.eventPlaySound(DirectionManager.SOUND.S0157, Sound.CH.BGM, false, 1f, 0);
		}
	}
}
