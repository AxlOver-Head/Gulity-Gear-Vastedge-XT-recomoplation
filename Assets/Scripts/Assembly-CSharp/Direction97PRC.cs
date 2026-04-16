public class Direction97PRC : DirectionBase
{
	public Direction97PRC(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventPlayMovie(DirectionManager.MOVIE.prc001_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc001_white_loop, DirectionManager.MOVIE.prc001_white, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0161, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0609, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0991, Sound.CH.VC0, true, 1f, 39);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE0, true, 1f, 102);
				evt.eventPlaySound(DirectionManager.SOUND.S1012, Sound.CH.VC0, true, 1f, 103);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, true, false, true, 128, 119, 99, 103);
				evt.eventSetCanPush(true, 103);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, true, 128, 72, 98, 103);
				break;
			case 2:
				evt.eventPlayMovie(DirectionManager.MOVIE.huc012, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc012_loop, DirectionManager.MOVIE.huc012, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0162, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0238, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0573, Sound.CH.SE1, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				break;
			case 3:
				evt.eventPlayMovie(DirectionManager.MOVIE.prc001_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc001_blue_loop, DirectionManager.MOVIE.prc001_blue, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0161, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0609, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0991, Sound.CH.VC0, true, 1f, 39);
				evt.eventPlaySound(DirectionManager.SOUND.S0449, Sound.CH.SE0, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE0, true, 1f, 102);
				evt.eventPlaySound(DirectionManager.SOUND.S1012, Sound.CH.VC0, true, 1f, 103);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, true, false, true, 128, 119, 99, 103);
				evt.eventSetCanPush(true, 103);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, true, 128, 72, 98, 103);
				break;
			case 4:
				evt.eventPlayMovie(DirectionManager.MOVIE.prc001_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc001_yellow_loop, DirectionManager.MOVIE.prc001_yellow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0161, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0609, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0991, Sound.CH.VC0, true, 1f, 39);
				evt.eventPlaySound(DirectionManager.SOUND.S0450, Sound.CH.SE0, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE0, true, 1f, 102);
				evt.eventPlaySound(DirectionManager.SOUND.S1012, Sound.CH.VC0, true, 1f, 103);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, true, false, true, 128, 119, 99, 103);
				evt.eventSetCanPush(true, 103);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, true, 128, 72, 98, 103);
				break;
			case 5:
				evt.eventPlayMovie(DirectionManager.MOVIE.prc001_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc001_green_loop, DirectionManager.MOVIE.prc001_green, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0161, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0609, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0991, Sound.CH.VC0, true, 1f, 39);
				evt.eventPlaySound(DirectionManager.SOUND.S0451, Sound.CH.SE0, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE0, true, 1f, 102);
				evt.eventPlaySound(DirectionManager.SOUND.S1012, Sound.CH.VC0, true, 1f, 103);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, true, false, true, 128, 119, 99, 103);
				evt.eventSetCanPush(true, 103);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, true, 128, 72, 98, 103);
				break;
			case 6:
				evt.eventPlayMovie(DirectionManager.MOVIE.prc001_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc001_red_loop, DirectionManager.MOVIE.prc001_red, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0161, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0609, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0991, Sound.CH.VC0, true, 1f, 39);
				evt.eventPlaySound(DirectionManager.SOUND.S0452, Sound.CH.SE0, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE0, true, 1f, 102);
				evt.eventPlaySound(DirectionManager.SOUND.S1012, Sound.CH.VC0, true, 1f, 103);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, true, false, true, 128, 119, 99, 103);
				evt.eventSetCanPush(true, 103);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, true, 128, 72, 98, 103);
				break;
			case 7:
				evt.eventPlayMovie(DirectionManager.MOVIE.prc001_purple, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc001_purple_loop, DirectionManager.MOVIE.prc001_purple, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0161, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0609, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0991, Sound.CH.VC0, true, 1f, 39);
				evt.eventPlaySound(DirectionManager.SOUND.S0453, Sound.CH.SE0, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE0, true, 1f, 102);
				evt.eventPlaySound(DirectionManager.SOUND.S1012, Sound.CH.VC0, true, 1f, 103);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, true, false, true, 128, 119, 99, 103);
				evt.eventSetCanPush(true, 103);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, true, 128, 72, 98, 103);
				break;
			case 8:
				evt.eventPlayMovie(DirectionManager.MOVIE.prc001_rainbow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc001_rainbow_loop, DirectionManager.MOVIE.prc001_rainbow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0161, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0609, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0991, Sound.CH.VC0, true, 1f, 39);
				evt.eventPlaySound(DirectionManager.SOUND.S0454, Sound.CH.SE0, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE0, true, 1f, 102);
				evt.eventPlaySound(DirectionManager.SOUND.S1012, Sound.CH.VC0, true, 1f, 103);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, true, false, true, 128, 119, 99, 103);
				evt.eventSetCanPush(true, 103);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, true, 128, 72, 98, 103);
				break;
			case 9:
				evt.eventPlayMovie(DirectionManager.MOVIE.prc002_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc001_white_loop, DirectionManager.MOVIE.prc002_white, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0599, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 6);
				evt.eventPlaySound(DirectionManager.SOUND.S1012, Sound.CH.VC0, true, 1f, 15);
				evt.eventPlaySound(DirectionManager.SOUND.S0441, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 30);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, true, false, true, 128, 119, 99, 15);
				evt.eventSetCanPush(true, 15);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, true, 128, 72, 98, 15);
				break;
			case 10:
				evt.eventPlayMovie(DirectionManager.MOVIE.prc002_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc001_blue_loop, DirectionManager.MOVIE.prc002_blue, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0599, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 6);
				evt.eventPlaySound(DirectionManager.SOUND.S1012, Sound.CH.VC0, true, 1f, 15);
				evt.eventPlaySound(DirectionManager.SOUND.S0449, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 30);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, true, false, true, 128, 119, 99, 15);
				evt.eventSetCanPush(true, 15);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, true, 128, 72, 98, 15);
				break;
			case 11:
				evt.eventPlayMovie(DirectionManager.MOVIE.prc002_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc001_yellow_loop, DirectionManager.MOVIE.prc002_yellow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0599, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 6);
				evt.eventPlaySound(DirectionManager.SOUND.S1012, Sound.CH.VC0, true, 1f, 15);
				evt.eventPlaySound(DirectionManager.SOUND.S0450, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 30);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, true, false, true, 128, 119, 99, 15);
				evt.eventSetCanPush(true, 15);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, true, 128, 72, 98, 15);
				break;
			case 12:
				evt.eventPlayMovie(DirectionManager.MOVIE.prc002_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc001_green_loop, DirectionManager.MOVIE.prc002_green, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0599, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 6);
				evt.eventPlaySound(DirectionManager.SOUND.S1012, Sound.CH.VC0, true, 1f, 15);
				evt.eventPlaySound(DirectionManager.SOUND.S0451, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 30);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, true, false, true, 128, 119, 99, 15);
				evt.eventSetCanPush(true, 15);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, true, 128, 72, 98, 15);
				break;
			case 13:
				evt.eventPlayMovie(DirectionManager.MOVIE.prc002_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc001_red_loop, DirectionManager.MOVIE.prc002_red, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0599, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 6);
				evt.eventPlaySound(DirectionManager.SOUND.S1012, Sound.CH.VC0, true, 1f, 15);
				evt.eventPlaySound(DirectionManager.SOUND.S0452, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 30);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, true, false, true, 128, 119, 99, 15);
				evt.eventSetCanPush(true, 15);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, true, 128, 72, 98, 15);
				break;
			case 14:
				evt.eventPlayMovie(DirectionManager.MOVIE.prc002_purple, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc001_purple_loop, DirectionManager.MOVIE.prc002_purple, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0599, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 6);
				evt.eventPlaySound(DirectionManager.SOUND.S1012, Sound.CH.VC0, true, 1f, 15);
				evt.eventPlaySound(DirectionManager.SOUND.S0453, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 30);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, true, false, true, 128, 119, 99, 15);
				evt.eventSetCanPush(true, 15);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, true, 128, 72, 98, 15);
				break;
			case 15:
				evt.eventPlayMovie(DirectionManager.MOVIE.prc002_rainbow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc001_rainbow_loop, DirectionManager.MOVIE.prc002_rainbow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0599, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE1, true, 1f, 6);
				evt.eventPlaySound(DirectionManager.SOUND.S1012, Sound.CH.VC0, true, 1f, 15);
				evt.eventPlaySound(DirectionManager.SOUND.S0454, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 30);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, true, false, true, 128, 119, 99, 15);
				evt.eventSetCanPush(true, 15);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, true, 128, 72, 98, 15);
				break;
			case 16:
				evt.eventPlayMovie(DirectionManager.MOVIE.prc003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc003_loop, DirectionManager.MOVIE.prc003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 6);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1741();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.prc003_add, true, false, true, false, 0, 0, 98, 11);
				evt.eventSetCanPush(false, 0);
				setNextLoop(90);
				break;
			case 17:
				evt.eventPlayMovie(DirectionManager.MOVIE.prc003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc003_loop, DirectionManager.MOVIE.prc003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 6);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1741();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.prc003_add, true, false, true, false, 0, 0, 98, 11);
				evt.eventSetCanPush(false, 0);
				setNextLoop(90);
				break;
			case 18:
				evt.eventPlayMovie(DirectionManager.MOVIE.prc003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc003_loop, DirectionManager.MOVIE.prc003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 6);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1741();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.prc003_add, true, false, true, false, 0, 0, 98, 11);
				evt.eventSetCanPush(false, 0);
				setNextLoop(90);
				break;
			case 19:
				evt.eventPlayMovie(DirectionManager.MOVIE.prc003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc003_loop, DirectionManager.MOVIE.prc003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 6);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1745();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1747();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.prc003_add, true, false, true, false, 0, 0, 98, 11);
				evt.eventSetCanPush(false, 0);
				setNextLoop(90);
				break;
			case 20:
				evt.eventPlayMovie(DirectionManager.MOVIE.prc003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc003_loop, DirectionManager.MOVIE.prc003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 6);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1745();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1747();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.prc003_add, true, false, true, false, 0, 0, 98, 11);
				evt.eventSetCanPush(false, 0);
				setNextLoop(90);
				break;
			case 21:
				evt.eventPlayMovie(DirectionManager.MOVIE.prc003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc003_loop, DirectionManager.MOVIE.prc003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 6);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1745();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1747();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.prc003_add, true, false, true, false, 0, 0, 98, 11);
				evt.eventSetCanPush(false, 0);
				setNextLoop(90);
				break;
			case 22:
				evt.eventPlayMovie(DirectionManager.MOVIE.prc003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc003_loop, DirectionManager.MOVIE.prc003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 6);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1751();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1753();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.prc003_add, true, false, true, false, 0, 0, 98, 11);
				evt.eventSetCanPush(false, 0);
				setNextLoop(90);
				break;
			case 23:
				evt.eventPlayMovie(DirectionManager.MOVIE.prc003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc003_loop, DirectionManager.MOVIE.prc003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0448, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 6);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1751();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1753();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.prc003_add, true, false, true, false, 0, 0, 98, 11);
				evt.eventSetCanPush(false, 0);
				setNextLoop(90);
				break;
			case 24:
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc003, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.prc003_loop, DirectionManager.MOVIE.prc003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 71);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 81);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1756();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1757();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1759();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 99, 71);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.prc003_add, true, false, true, false, 0, 0, 98, 11);
				evt.eventSetCanPush(false, 0);
				setNextLoop(161);
				break;
			case 25:
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc003, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.prc003_loop, DirectionManager.MOVIE.prc003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 71);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 81);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1756();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1757();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1759();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 99, 71);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.prc003_add, true, false, true, false, 0, 0, 98, 11);
				evt.eventSetCanPush(false, 0);
				setNextLoop(161);
				break;
			case 26:
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc003, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.prc003_loop, DirectionManager.MOVIE.prc003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 71);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 81);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1756();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1757();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1759();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 99, 71);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.prc003_add, true, false, true, false, 0, 0, 98, 11);
				evt.eventSetCanPush(false, 0);
				setNextLoop(161);
				break;
			case 27:
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc003, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.prc003_loop, DirectionManager.MOVIE.prc003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 71);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 81);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1762();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1763();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1765();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 99, 71);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.prc003_add, true, false, true, false, 0, 0, 98, 11);
				evt.eventSetCanPush(false, 0);
				setNextLoop(161);
				break;
			case 28:
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.prc003, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.prc003_loop, DirectionManager.MOVIE.prc003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 71);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 81);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1762();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1763();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1765();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 99, 71);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.prc003_add, true, false, true, false, 0, 0, 98, 11);
				evt.eventSetCanPush(false, 0);
				setNextLoop(161);
				break;
			}
		}
		if (low != 0)
		{
			return;
		}
		switch (mode)
		{
		case 1:
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
			MainGameScene.pnlMan.flashCartridge(MainGameScene.slotGameMan.getRomanBulletNum() - 1);
			break;
		case 2:
		{
			int num = MainGameScene.slotGameMan.get_pdt_data(65);
			int num2 = num % 10;
			int num3 = num / 10 % 10;
			int num4 = num / 100 % 10;
			int num5 = num / 1000;
			DirectionManager.MOVIE[] array = new DirectionManager.MOVIE[10]
			{
				DirectionManager.MOVIE.dgs004_0_1,
				DirectionManager.MOVIE.dgs004_1_1,
				DirectionManager.MOVIE.dgs004_2_1,
				DirectionManager.MOVIE.dgs004_3_1,
				DirectionManager.MOVIE.dgs004_4_1,
				DirectionManager.MOVIE.dgs004_5_1,
				DirectionManager.MOVIE.dgs004_6_1,
				DirectionManager.MOVIE.dgs004_7_1,
				DirectionManager.MOVIE.dgs004_8_1,
				DirectionManager.MOVIE.dgs004_9_1
			};
			DirectionManager.MOVIE[] array2 = new DirectionManager.MOVIE[10]
			{
				DirectionManager.MOVIE.dgs004_0_2,
				DirectionManager.MOVIE.dgs004_1_2,
				DirectionManager.MOVIE.dgs004_2_2,
				DirectionManager.MOVIE.dgs004_3_2,
				DirectionManager.MOVIE.dgs004_4_2,
				DirectionManager.MOVIE.dgs004_5_2,
				DirectionManager.MOVIE.dgs004_6_2,
				DirectionManager.MOVIE.dgs004_7_2,
				DirectionManager.MOVIE.dgs004_8_2,
				DirectionManager.MOVIE.dgs004_9_2
			};
			DirectionManager.MOVIE[] array3 = new DirectionManager.MOVIE[10]
			{
				DirectionManager.MOVIE.dgs004_0_3,
				DirectionManager.MOVIE.dgs004_1_3,
				DirectionManager.MOVIE.dgs004_2_3,
				DirectionManager.MOVIE.dgs004_3_3,
				DirectionManager.MOVIE.dgs004_4_3,
				DirectionManager.MOVIE.dgs004_5_3,
				DirectionManager.MOVIE.dgs004_6_3,
				DirectionManager.MOVIE.dgs004_7_3,
				DirectionManager.MOVIE.dgs004_8_3,
				DirectionManager.MOVIE.dgs004_9_3
			};
			DirectionManager.MOVIE[] array4 = new DirectionManager.MOVIE[10]
			{
				DirectionManager.MOVIE.dgs004_0_4,
				DirectionManager.MOVIE.dgs004_1_4,
				DirectionManager.MOVIE.dgs004_2_4,
				DirectionManager.MOVIE.dgs004_3_4,
				DirectionManager.MOVIE.dgs004_4_4,
				DirectionManager.MOVIE.dgs004_5_4,
				DirectionManager.MOVIE.dgs004_6_4,
				DirectionManager.MOVIE.dgs004_7_4,
				DirectionManager.MOVIE.dgs004_8_4,
				DirectionManager.MOVIE.dgs004_9_4
			};
			DirectionManager.MOVIE[] array5 = new DirectionManager.MOVIE[10]
			{
				DirectionManager.MOVIE.dgs004_0_2_nml,
				DirectionManager.MOVIE.dgs004_1_2_nml,
				DirectionManager.MOVIE.dgs004_2_2_nml,
				DirectionManager.MOVIE.dgs004_3_2_nml,
				DirectionManager.MOVIE.dgs004_4_2_nml,
				DirectionManager.MOVIE.dgs004_5_2_nml,
				DirectionManager.MOVIE.dgs004_6_2_nml,
				DirectionManager.MOVIE.dgs004_7_2_nml,
				DirectionManager.MOVIE.dgs004_8_2_nml,
				DirectionManager.MOVIE.dgs004_9_2_nml
			};
			DirectionManager.MOVIE[] array6 = new DirectionManager.MOVIE[10]
			{
				DirectionManager.MOVIE.dgs004_0_1_loop,
				DirectionManager.MOVIE.dgs004_1_1_loop,
				DirectionManager.MOVIE.dgs004_2_1_loop,
				DirectionManager.MOVIE.dgs004_3_1_loop,
				DirectionManager.MOVIE.dgs004_4_1_loop,
				DirectionManager.MOVIE.dgs004_5_1_loop,
				DirectionManager.MOVIE.dgs004_6_1_loop,
				DirectionManager.MOVIE.dgs004_7_1_loop,
				DirectionManager.MOVIE.dgs004_8_1_loop,
				DirectionManager.MOVIE.dgs004_9_1_loop
			};
			if (num5 == 0 && num4 == 0 && num3 == 0)
			{
				evt.eventPlayMovie(array[num2], false, false, false, true, 128, 72, 80, 27);
				evt.eventAddMovie(array6[num2], array[num2], false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs004_10, false, false, false, true, 11, 81, 76, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs004_10_loop, false, true, false, true, 86, 81, 76, 58);
				evt.eventMovieSlide(76f, 11f, 81f, 86f, 81f, 2, 45);
			}
			else if (num5 == 0 && num4 == 0)
			{
				evt.eventPlayMovie(array2[num2], false, false, false, true, 308, 72, 80, 27);
				evt.eventPlayMovie(array5[num2], false, false, false, true, 164, 72, 80, 49);
				evt.eventPlayMovie(array6[num2], false, true, false, true, 164, 72, 80, 60);
				evt.eventPlayMovie(array2[num3], false, false, false, true, -28, 72, 79, 27);
				evt.eventPlayMovie(array5[num3], false, false, false, true, 116, 72, 79, 48);
				evt.eventPlayMovie(array6[num3], false, true, false, true, 116, 72, 79, 60);
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs004_10, false, false, false, true, 0, 81, 76, 48);
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs004_10_loop, false, true, false, true, 70, 81, 76, 60);
				evt.eventMovieSlide(80f, 308f, 72f, 164f, 72f, 5, 27);
				evt.eventMovieSlide(79f, -28f, 72f, 116f, 72f, 5, 27);
				evt.eventMovieSlide(76f, 0f, 81f, 70f, 81f, 3, 48);
			}
			else if (num5 == 0)
			{
				evt.eventPlayMovie(array2[num2], false, false, false, true, 330, 72, 80, 27);
				evt.eventPlayMovie(array5[num2], false, false, false, true, 186, 72, 80, 54);
				evt.eventPlayMovie(array6[num2], false, true, false, true, 186, 72, 80, 65);
				evt.eventPlayMovie(array3[num3], false, false, false, true, 138, 72, 79, 29);
				evt.eventPlayMovie(array5[num3], false, false, false, true, 138, 72, 79, 53);
				evt.eventPlayMovie(array6[num3], false, true, false, true, 138, 72, 79, 65);
				evt.eventPlayMovie(array2[num4], false, false, false, true, -59, 72, 78, 27);
				evt.eventPlayMovie(array5[num4], false, false, false, true, 89, 72, 78, 52);
				evt.eventPlayMovie(array6[num4], false, true, false, true, 89, 72, 78, 65);
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs004_10, false, false, false, true, -10, 81, 76, 48);
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs004_10_loop, false, true, false, true, 47, 81, 76, 65);
				evt.eventMovieSlide(80f, 330f, 72f, 186f, 72f, 7, 27);
				evt.eventMovieSlide(78f, -59f, 72f, 89f, 72f, 7, 27);
				evt.eventMovieSlide(76f, -10f, 81f, 47f, 81f, 5, 48);
			}
			else
			{
				evt.eventPlayMovie(array2[num2], false, false, false, true, 314, 72, 80, 31);
				evt.eventPlayMovie(array5[num2], false, false, false, true, 210, 72, 80, 57);
				evt.eventPlayMovie(array6[num2], false, true, false, true, 210, 72, 80, 76);
				evt.eventPlayMovie(array4[num3], false, false, false, true, 308, 72, 79, 26);
				evt.eventPlayMovie(array5[num3], false, false, false, true, 164, 72, 79, 56);
				evt.eventPlayMovie(array6[num3], false, true, false, true, 164, 72, 79, 76);
				evt.eventPlayMovie(array4[num4], false, false, false, true, -14, 72, 78, 26);
				evt.eventPlayMovie(array5[num4], false, false, false, true, 116, 72, 78, 55);
				evt.eventPlayMovie(array6[num4], false, true, false, true, 116, 72, 78, 76);
				evt.eventPlayMovie(array2[num5], false, false, false, true, -43, 72, 77, 31);
				evt.eventPlayMovie(array5[num5], false, false, false, true, 70, 72, 77, 54);
				evt.eventPlayMovie(array6[num5], false, true, false, true, 70, 72, 77, 76);
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs004_10, false, false, false, true, 14, 81, 76, 53);
				evt.eventPlayMovie(DirectionManager.MOVIE.dgs004_10_loop, false, true, false, true, 28, 81, 76, 76);
				evt.eventMovieSlide(80f, 314f, 72f, 210f, 72f, 5, 31);
				evt.eventMovieSlide(79f, 308f, 72f, 163f, 72f, 5, 26);
				evt.eventMovieSlide(78f, -14f, 72f, 117f, 72f, 5, 26);
				evt.eventMovieSlide(77f, -43f, 72f, 70f, 72f, 5, 31);
				evt.eventMovieSlide(76f, -14f, 81f, 28f, 81f, 3, 53);
			}
			break;
		}
		}
	}

	private void setNextLoop(int exe)
	{
		if (MainGameScene.slotGameMan.getRomanBulletNum() > 0)
		{
			byte b = 93;
			byte b2 = 0;
			byte b3 = 0;
			switch (MainGameScene.slotGameMan.get_pdt_data(5))
			{
			case 92:
			case 93:
			case 94:
			case 95:
			case 96:
			case 97:
			case 98:
			case 99:
			case 100:
			case 101:
			case 102:
			case 103:
			case 104:
				b3 = 9;
				break;
			case 105:
			case 106:
			case 107:
			case 108:
			case 109:
			case 110:
			case 111:
			case 112:
			case 113:
			case 114:
			case 115:
			case 116:
			case 117:
				b3 = 10;
				break;
			case 118:
			case 119:
			case 120:
			case 121:
			case 122:
			case 123:
			case 124:
			case 125:
			case 126:
			case 127:
			case 128:
			case 129:
			case 130:
				b3 = 11;
				break;
			case 131:
			case 132:
			case 133:
			case 134:
			case 135:
			case 136:
			case 137:
			case 138:
			case 139:
			case 140:
			case 141:
			case 142:
			case 143:
				b3 = 12;
				break;
			case 144:
			case 145:
			case 146:
			case 147:
			case 148:
			case 149:
			case 150:
			case 151:
			case 152:
			case 153:
			case 154:
			case 155:
			case 156:
				b3 = 13;
				break;
			case 157:
			case 158:
			case 159:
			case 160:
			case 161:
			case 162:
			case 163:
			case 164:
			case 165:
			case 166:
			case 167:
			case 168:
			case 169:
				b3 = 14;
				break;
			case 170:
			case 171:
			case 172:
			case 173:
			case 174:
			case 175:
			case 176:
			case 177:
			case 178:
			case 179:
			case 180:
			case 181:
			case 182:
				b3 = 15;
				break;
			default:
				b3 = 9;
				break;
			}
			evt.eventMakeDirection(m_Dir, b, b2, b3, exe);
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
