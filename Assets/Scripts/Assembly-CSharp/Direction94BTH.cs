public class Direction94BTH : DirectionBase
{
	private int m_cnt;

	public Direction94BTH(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		m_cnt = 0;
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				evt.eventPlayMovie(DirectionManager.MOVIE.bth000_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth001_white, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bth001_white_loop, DirectionManager.MOVIE.bth001_white, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0661, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0540, Sound.CH.SE0, true, 1f, 20);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth002_a_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bt003_b_white, DirectionManager.MOVIE.bth002_a_white, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0603, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1198, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0602, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE0, true, 1f, 54);
				break;
			case 3:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth000_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bt003_a_white, false, false, false, false, 0, 0, 90, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0664, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1670();
				evt.eventPlaySound(DirectionManager.SOUND.S0062, Sound.CH.SE0, true, 1f, 50);
				evt.eventPlaySound(DirectionManager.SOUND.S0091, Sound.CH.SE1, true, 1f, 55);
				evt.eventPlaySound(DirectionManager.SOUND.S0063, Sound.CH.SE0, true, 1f, 95);
				break;
			case 4:
				evt.eventPlayMovie(DirectionManager.MOVIE.bth000_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth001_blue, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bth001_blue_loop, DirectionManager.MOVIE.bth001_blue, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0661, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0540, Sound.CH.SE0, true, 1f, 20);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth002_a_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bt003_b_blue, DirectionManager.MOVIE.bth002_a_blue, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0603, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1198, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0602, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE0, true, 1f, 54);
				break;
			case 6:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth000_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bt003_a_blue, false, false, false, false, 0, 0, 90, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0664, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1670();
				evt.eventPlaySound(DirectionManager.SOUND.S0062, Sound.CH.SE0, true, 1f, 50);
				evt.eventPlaySound(DirectionManager.SOUND.S0091, Sound.CH.SE1, true, 1f, 55);
				evt.eventPlaySound(DirectionManager.SOUND.S0063, Sound.CH.SE0, true, 1f, 95);
				break;
			case 7:
				evt.eventPlayMovie(DirectionManager.MOVIE.bth000_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth001_yellow, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bth001_yellow_loop, DirectionManager.MOVIE.bth001_yellow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0661, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0540, Sound.CH.SE0, true, 1f, 20);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 8:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth002_a_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bt003_b_yellow, DirectionManager.MOVIE.bth002_a_yellow, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0603, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1198, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0602, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE0, true, 1f, 54);
				break;
			case 9:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth000_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bt003_a_yellow, false, false, false, false, 0, 0, 90, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0664, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1670();
				evt.eventPlaySound(DirectionManager.SOUND.S0062, Sound.CH.SE0, true, 1f, 50);
				evt.eventPlaySound(DirectionManager.SOUND.S0091, Sound.CH.SE1, true, 1f, 55);
				evt.eventPlaySound(DirectionManager.SOUND.S0063, Sound.CH.SE0, true, 1f, 95);
				break;
			case 10:
				evt.eventPlayMovie(DirectionManager.MOVIE.bth000_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth001_green, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bth001_green_loop, DirectionManager.MOVIE.bth001_green, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0661, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0540, Sound.CH.SE0, true, 1f, 20);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 11:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth002_a_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bt003_b_green, DirectionManager.MOVIE.bth002_a_green, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0603, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1198, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0602, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE0, true, 1f, 54);
				break;
			case 12:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth000_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bt003_a_green, false, false, false, false, 0, 0, 90, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0664, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1670();
				evt.eventPlaySound(DirectionManager.SOUND.S0062, Sound.CH.SE0, true, 1f, 50);
				evt.eventPlaySound(DirectionManager.SOUND.S0091, Sound.CH.SE1, true, 1f, 55);
				evt.eventPlaySound(DirectionManager.SOUND.S0063, Sound.CH.SE0, true, 1f, 95);
				break;
			case 13:
				evt.eventPlayMovie(DirectionManager.MOVIE.bth000_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth001_red, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bth001_red_loop, DirectionManager.MOVIE.bth001_red, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0661, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0540, Sound.CH.SE0, true, 1f, 20);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 14:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth002_a_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bt003_b_red, DirectionManager.MOVIE.bth002_a_red, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0603, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1198, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0602, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE0, true, 1f, 54);
				break;
			case 15:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth000_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bt003_a_red, false, false, false, false, 0, 0, 90, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0664, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1670();
				evt.eventPlaySound(DirectionManager.SOUND.S0062, Sound.CH.SE0, true, 1f, 50);
				evt.eventPlaySound(DirectionManager.SOUND.S0091, Sound.CH.SE1, true, 1f, 55);
				evt.eventPlaySound(DirectionManager.SOUND.S0063, Sound.CH.SE0, true, 1f, 95);
				break;
			case 16:
				evt.eventPlayMovie(DirectionManager.MOVIE.bth000_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth001_purple, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bth001_purple_loop, DirectionManager.MOVIE.bth001_purple, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0661, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0540, Sound.CH.SE0, true, 1f, 20);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 17:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth002_a_purple, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bt003_b_purple, DirectionManager.MOVIE.bth002_a_purple, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0603, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1198, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0602, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE0, true, 1f, 54);
				break;
			case 18:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth000_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bt003_a_purple, false, false, false, false, 0, 0, 90, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0664, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1670();
				evt.eventPlaySound(DirectionManager.SOUND.S0062, Sound.CH.SE0, true, 1f, 50);
				evt.eventPlaySound(DirectionManager.SOUND.S0091, Sound.CH.SE1, true, 1f, 55);
				evt.eventPlaySound(DirectionManager.SOUND.S0063, Sound.CH.SE0, true, 1f, 95);
				break;
			case 19:
				evt.eventPlayMovie(DirectionManager.MOVIE.bth000_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth001_rainbow, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bth001_rainbow_loop, DirectionManager.MOVIE.bth001_rainbow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0661, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0540, Sound.CH.SE0, true, 1f, 20);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 20:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth002_a_rainbow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bt003_b_rainbow, DirectionManager.MOVIE.bth002_a_rainbow, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0603, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1198, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0602, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE0, true, 1f, 54);
				break;
			case 21:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth000_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bt003_a_rainbow, false, false, false, false, 0, 0, 90, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0664, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1674();
				evt.eventPlaySound(DirectionManager.SOUND.S0062, Sound.CH.SE0, true, 1f, 50);
				evt.eventPlaySound(DirectionManager.SOUND.S0091, Sound.CH.SE1, true, 1f, 55);
				evt.eventPlaySound(DirectionManager.SOUND.S0217, Sound.CH.SE0, false, 1f, 55);
				evt.eventPlaySound(DirectionManager.SOUND.S0063, Sound.CH.SE1, true, 1f, 140);
				break;
			case 22:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth002_b_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bt003_b_white, DirectionManager.MOVIE.bth002_b_white, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0603, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0838, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0602, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE0, true, 1f, 54);
				break;
			case 23:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth002_b_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bt003_b_blue, DirectionManager.MOVIE.bth002_b_blue, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0603, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0838, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0602, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE0, true, 1f, 54);
				break;
			case 24:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth002_b_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bt003_b_yellow, DirectionManager.MOVIE.bth002_b_yellow, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0603, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0838, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0602, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE0, true, 1f, 54);
				break;
			case 25:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth002_b_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bt003_b_green, DirectionManager.MOVIE.bth002_b_green, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0603, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0838, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0602, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE0, true, 1f, 54);
				break;
			case 26:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth002_b_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bt003_b_red, DirectionManager.MOVIE.bth002_b_red, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0603, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0838, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0602, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE0, true, 1f, 54);
				break;
			case 27:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth002_b_purple, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bt003_b_purple, DirectionManager.MOVIE.bth002_b_purple, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0603, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0838, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0602, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE0, true, 1f, 54);
				break;
			case 28:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth002_b_rainbow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bt003_b_rainbow, DirectionManager.MOVIE.bth002_b_rainbow, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0603, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0838, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0602, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE0, true, 1f, 54);
				break;
			case 29:
				evt.eventPlayMovie(DirectionManager.MOVIE.bth004_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bth004_white_loop, DirectionManager.MOVIE.bth004_white, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0663, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 67);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1678();
				break;
			case 30:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sin_1_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0560, Sound.CH.SE0, true, 1f, 0);
				break;
			case 31:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sin_2_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0561, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 71);
				break;
			case 32:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth007_sin_3_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bth008_a_white, DirectionManager.MOVIE.bth007_sin_3_white, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0562, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 55);
				break;
			case 33:
				evt.eventPlayMovie(DirectionManager.MOVIE.bth004_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bth004_blue_loop, DirectionManager.MOVIE.bth004_blue, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0663, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 67);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1678();
				break;
			case 34:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sin_1_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0560, Sound.CH.SE0, true, 1f, 0);
				break;
			case 35:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sin_2_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0561, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 71);
				break;
			case 36:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth007_sin_3_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bth008_a_blue, DirectionManager.MOVIE.bth007_sin_3_blue, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0562, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 55);
				break;
			case 37:
				evt.eventPlayMovie(DirectionManager.MOVIE.bth004_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bth004_yellow_loop, DirectionManager.MOVIE.bth004_yellow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0663, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 67);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1678();
				break;
			case 38:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sin_1_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0560, Sound.CH.SE0, true, 1f, 0);
				break;
			case 39:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sin_2_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0561, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 71);
				break;
			case 40:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth007_sin_3_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bth008_a_yellow, DirectionManager.MOVIE.bth007_sin_3_yellow, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0562, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 55);
				break;
			case 41:
				evt.eventPlayMovie(DirectionManager.MOVIE.bth004_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bth004_green_loop, DirectionManager.MOVIE.bth004_green, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0663, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 67);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1678();
				break;
			case 42:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sin_1_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0560, Sound.CH.SE0, true, 1f, 0);
				break;
			case 43:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sin_2_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0561, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 71);
				break;
			case 44:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth007_sin_3_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bth008_a_green, DirectionManager.MOVIE.bth007_sin_3_green, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0562, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 55);
				break;
			case 45:
				evt.eventPlayMovie(DirectionManager.MOVIE.bth004_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bth004_red_loop, DirectionManager.MOVIE.bth004_red, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0663, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 67);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1678();
				break;
			case 46:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sin_1_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0560, Sound.CH.SE0, true, 1f, 0);
				break;
			case 47:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sin_2_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0561, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 71);
				break;
			case 48:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth007_sin_3_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bth008_a_red, DirectionManager.MOVIE.bth007_sin_3_red, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0562, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 55);
				break;
			case 49:
				evt.eventPlayMovie(DirectionManager.MOVIE.bth004_purple, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bth004_purple_loop, DirectionManager.MOVIE.bth004_purple, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0663, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 67);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1678();
				break;
			case 50:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sin_1_purple, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0560, Sound.CH.SE0, true, 1f, 0);
				break;
			case 51:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sin_2_purple, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0561, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 71);
				break;
			case 52:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth007_sin_3_purple, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bth008_a_purple, DirectionManager.MOVIE.bth007_sin_3_purple, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0562, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 55);
				break;
			case 53:
				evt.eventPlayMovie(DirectionManager.MOVIE.bth004_rainbow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bth004_rainbow_loop, DirectionManager.MOVIE.bth004_rainbow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0663, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 67);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1678();
				break;
			case 54:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sin_1_rainbow, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0560, Sound.CH.SE0, true, 1f, 0);
				break;
			case 55:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sin_2_rainbow, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0561, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 71);
				break;
			case 56:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth007_sin_3_rainbow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bth008_a_rainbow, DirectionManager.MOVIE.bth007_sin_3_rainbow, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0562, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 55);
				break;
			case 57:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sol_1_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0560, Sound.CH.SE0, true, 1f, 0);
				break;
			case 58:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sol_2_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0561, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 71);
				break;
			case 59:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth007_sol_3_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth008_a_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0562, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 55);
				break;
			case 60:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sol_1_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0560, Sound.CH.SE0, true, 1f, 0);
				break;
			case 61:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sol_2_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0561, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 71);
				break;
			case 62:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth007_sol_3_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth008_a_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0562, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 55);
				break;
			case 63:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sol_1_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0560, Sound.CH.SE0, true, 1f, 0);
				break;
			case 64:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sol_2_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0561, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 71);
				break;
			case 65:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth007_sol_3_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth008_a_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0562, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 55);
				break;
			case 66:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sol_1_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0560, Sound.CH.SE0, true, 1f, 0);
				break;
			case 67:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sol_2_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0561, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 71);
				break;
			case 68:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth007_sol_3_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth008_a_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0562, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 55);
				break;
			case 69:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sol_1_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0560, Sound.CH.SE0, true, 1f, 0);
				break;
			case 70:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sol_2_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0561, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 71);
				break;
			case 71:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth007_sol_3_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth008_a_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0562, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 55);
				break;
			case 72:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sol_1_purple, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0560, Sound.CH.SE0, true, 1f, 0);
				break;
			case 73:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sol_2_purple, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0561, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 71);
				break;
			case 74:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth007_sol_3_purple, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth008_a_purple, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0562, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 55);
				break;
			case 75:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sol_1_rainbow, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0560, Sound.CH.SE0, true, 1f, 0);
				break;
			case 76:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sol_2_rainbow, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0561, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 71);
				break;
			case 77:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth007_sol_3_rainbow, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth008_a_rainbow, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0562, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 55);
				break;
			case 78:
				appear(0, 0);
				appear(0, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1682();
				break;
			case 79:
				appear(0, 0);
				appear(1, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 80:
				appear(0, 0);
				appear(2, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 81:
				appear(0, 0);
				appear(3, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 82:
				appear(0, 0);
				appear(4, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 83:
				appear(0, 0);
				appear(5, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 84:
				appear(0, 0);
				appear(6, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 85:
				appear(1, 0);
				appear(1, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 86:
				appear(1, 0);
				appear(3, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 87:
				appear(1, 0);
				appear(4, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 88:
				appear(1, 0);
				appear(5, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 89:
				appear(1, 0);
				appear(6, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 90:
				appear(2, 0);
				appear(2, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 91:
				appear(2, 0);
				appear(3, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 92:
				appear(2, 0);
				appear(4, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 93:
				appear(2, 0);
				appear(5, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 94:
				appear(2, 0);
				appear(6, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 95:
				appear(3, 0);
				appear(3, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 96:
				appear(3, 0);
				appear(4, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 97:
				appear(3, 0);
				appear(5, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 98:
				appear(3, 0);
				appear(6, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 99:
				appear(4, 0);
				appear(3, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 100:
				appear(4, 0);
				appear(4, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 101:
				appear(4, 0);
				appear(5, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 102:
				appear(4, 0);
				appear(6, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 103:
				appear(5, 0);
				appear(3, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 104:
				appear(5, 0);
				appear(5, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 105:
				appear(5, 0);
				appear(4, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 106:
				appear(5, 0);
				appear(6, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 107:
				appear(6, 0);
				appear(6, 1);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1666();
				break;
			case 108:
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, false, 0, 55, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 2);
				evt.eventSetCanPush(true, 0);
				break;
			case 109:
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, false, 0, 55, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 2);
				evt.eventSetCanPush(true, 0);
				break;
			case 110:
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, false, 0, 55, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 2);
				evt.eventSetCanPush(true, 0);
				break;
			case 111:
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_b_loop, DirectionManager.MOVIE.push_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0233, Sound.CH.SE0, true, 1f, 2);
				break;
			case 112:
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_b_loop, DirectionManager.MOVIE.push_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0233, Sound.CH.SE0, true, 1f, 2);
				break;
			case 113:
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_b_loop, DirectionManager.MOVIE.push_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0233, Sound.CH.SE0, true, 1f, 2);
				break;
			case 114:
				if (SGLG.prod.find(3667) < 0)
				{
					evt.eventPlayMovie(DirectionManager.MOVIE.bth007_sol_3_white, false, false, false, false, 0, 0, 100, 0);
				}
				else
				{
					evt.eventPlayAnime(DirectionManager.ANIME.HNV003_b02, 0, true, false, true, true, 128, 72, 80, 0);
				}
				evt.eventPlaySound(DirectionManager.SOUND.S0447, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0561, Sound.CH.SE1, true, 1f, 0);
				evt.eventSetCanPush(true, 0);
				break;
			case 115:
				if (SGLG.prod.find(3668) < 0)
				{
					evt.eventPlayMovie(DirectionManager.MOVIE.bth007_sol_3_blue, false, false, false, false, 0, 0, 100, 0);
				}
				else
				{
					evt.eventPlayAnime(DirectionManager.ANIME.HNV003_b02, 0, true, false, true, true, 128, 72, 80, 0);
				}
				evt.eventPlaySound(DirectionManager.SOUND.S0447, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0561, Sound.CH.SE1, true, 1f, 0);
				evt.eventSetCanPush(true, 0);
				break;
			case 116:
				if (SGLG.prod.find(3669) < 0)
				{
					evt.eventPlayMovie(DirectionManager.MOVIE.bth007_sol_3_yellow, false, false, false, false, 0, 0, 100, 0);
				}
				else
				{
					evt.eventPlayAnime(DirectionManager.ANIME.HNV003_b02, 0, true, false, true, true, 128, 72, 80, 0);
				}
				evt.eventPlaySound(DirectionManager.SOUND.S0447, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0561, Sound.CH.SE1, true, 1f, 0);
				evt.eventSetCanPush(true, 0);
				break;
			case 117:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sol_2_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0561, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 71);
				evt.eventPlayMovie(DirectionManager.MOVIE.anv005, false, false, false, false, 0, 0, 90, 60);
				break;
			case 118:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth007_sol_3_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth008_a_white, false, false, false, false, 0, 0, 100, 23);
				evt.eventPlaySound(DirectionManager.SOUND.S0562, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.VC0, true, 1f, 55);
				evt.eventPlayMovie(DirectionManager.MOVIE.bt003_a_white, false, false, false, false, 0, 0, 90, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0664, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1670();
				evt.eventPlaySound(DirectionManager.SOUND.S0062, Sound.CH.SE0, true, 1f, 50);
				evt.eventPlaySound(DirectionManager.SOUND.S0091, Sound.CH.SE1, true, 1f, 55);
				evt.eventPlaySound(DirectionManager.SOUND.S0063, Sound.CH.SE0, true, 1f, 95);
				break;
			case 119:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sol_2_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0561, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 71);
				evt.eventPlayMovie(DirectionManager.MOVIE.anv005, false, false, false, false, 0, 0, 90, 60);
				break;
			case 120:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth007_sol_3_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth008_a_blue, false, false, false, false, 0, 0, 100, 23);
				evt.eventPlaySound(DirectionManager.SOUND.S0562, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.VC0, true, 1f, 55);
				evt.eventPlayMovie(DirectionManager.MOVIE.bt003_a_blue, false, false, false, false, 0, 0, 90, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0664, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1670();
				evt.eventPlaySound(DirectionManager.SOUND.S0062, Sound.CH.SE0, true, 1f, 50);
				evt.eventPlaySound(DirectionManager.SOUND.S0091, Sound.CH.SE1, true, 1f, 55);
				evt.eventPlaySound(DirectionManager.SOUND.S0063, Sound.CH.SE0, true, 1f, 95);
				break;
			case 121:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sol_2_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0561, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 71);
				evt.eventPlayMovie(DirectionManager.MOVIE.anv005, false, false, false, false, 0, 0, 90, 60);
				break;
			case 122:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth007_sol_3_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth008_a_yellow, false, false, false, false, 0, 0, 100, 23);
				evt.eventPlaySound(DirectionManager.SOUND.S0562, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.VC0, true, 1f, 55);
				evt.eventPlayMovie(DirectionManager.MOVIE.bt003_a_yellow, false, false, false, false, 0, 0, 90, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0664, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1670();
				evt.eventPlaySound(DirectionManager.SOUND.S0062, Sound.CH.SE0, true, 1f, 50);
				evt.eventPlaySound(DirectionManager.SOUND.S0091, Sound.CH.SE1, true, 1f, 55);
				evt.eventPlaySound(DirectionManager.SOUND.S0063, Sound.CH.SE0, true, 1f, 95);
				break;
			case 123:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sol_2_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0561, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 71);
				evt.eventPlayMovie(DirectionManager.MOVIE.anv005, false, false, false, false, 0, 0, 90, 60);
				break;
			case 124:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth007_sol_3_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth008_a_white, false, false, false, false, 0, 0, 100, 23);
				evt.eventPlaySound(DirectionManager.SOUND.S0562, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.VC0, true, 1f, 55);
				evt.eventPlayMovie(DirectionManager.MOVIE.bt003_a_white, false, false, false, false, 0, 0, 90, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0664, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1670();
				evt.eventPlaySound(DirectionManager.SOUND.S0062, Sound.CH.SE0, true, 1f, 50);
				evt.eventPlaySound(DirectionManager.SOUND.S0091, Sound.CH.SE1, true, 1f, 55);
				evt.eventPlaySound(DirectionManager.SOUND.S0063, Sound.CH.SE0, true, 1f, 95);
				break;
			case 125:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sol_2_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0561, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 71);
				evt.eventPlayMovie(DirectionManager.MOVIE.anv005, false, false, false, false, 0, 0, 90, 60);
				break;
			case 126:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth007_sol_3_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth008_a_blue, false, false, false, false, 0, 0, 100, 23);
				evt.eventPlaySound(DirectionManager.SOUND.S0562, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.VC0, true, 1f, 55);
				evt.eventPlayMovie(DirectionManager.MOVIE.bt003_a_blue, false, false, false, false, 0, 0, 90, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0664, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1670();
				evt.eventPlaySound(DirectionManager.SOUND.S0062, Sound.CH.SE0, true, 1f, 50);
				evt.eventPlaySound(DirectionManager.SOUND.S0091, Sound.CH.SE1, true, 1f, 55);
				evt.eventPlaySound(DirectionManager.SOUND.S0063, Sound.CH.SE0, true, 1f, 95);
				break;
			case 127:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth005_sol_2_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0561, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 71);
				evt.eventPlayMovie(DirectionManager.MOVIE.anv005, false, false, false, false, 0, 0, 90, 60);
				break;
			case 128:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth007_sol_3_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bth008_a_yellow, false, false, false, false, 0, 0, 100, 23);
				evt.eventPlaySound(DirectionManager.SOUND.S0562, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.VC0, true, 1f, 55);
				evt.eventPlayMovie(DirectionManager.MOVIE.bt003_a_yellow, false, false, false, false, 0, 0, 90, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0664, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1670();
				evt.eventPlaySound(DirectionManager.SOUND.S0062, Sound.CH.SE0, true, 1f, 50);
				evt.eventPlaySound(DirectionManager.SOUND.S0091, Sound.CH.SE1, true, 1f, 55);
				evt.eventPlaySound(DirectionManager.SOUND.S0063, Sound.CH.SE0, true, 1f, 95);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 3:
				DirectionLedManager.GD_BTH_charge_white(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 4:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 6:
				DirectionLedManager.GD_BTH_charge_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 7:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 9:
				DirectionLedManager.GD_BTH_charge_yellow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 10:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 12:
				DirectionLedManager.GD_BTH_charge_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 13:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 15:
				DirectionLedManager.GD_BTH_charge_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 16:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 18:
				DirectionLedManager.GD_BTH_charge_purple(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 19:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 21:
				DirectionLedManager.GD_BTH_charge_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 29:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 33:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 37:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 41:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 45:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 49:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 53:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 78:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 79:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 80:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 81:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 82:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 83:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 84:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 85:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 86:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 87:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 88:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 89:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 90:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 91:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 92:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 93:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 94:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 95:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 96:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 97:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 98:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 99:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 100:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 101:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 102:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 103:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 104:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 105:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 106:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 107:
				DirectionLedManager.GD_BTH_gear_stop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 118:
				DirectionLedManager.GD_BTH_charge_white_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 120:
				DirectionLedManager.GD_BTH_charge_blue_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 122:
				DirectionLedManager.GD_BTH_charge_yellow_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 124:
				DirectionLedManager.GD_BTH_charge_white_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 126:
				DirectionLedManager.GD_BTH_charge_blue_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 128:
				DirectionLedManager.GD_BTH_charge_yellow_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			}
		}
		base.start();
	}

	private void appear(int color, int place)
	{
		int num = -1;
		int num2 = -1;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int[] array = new int[3] { -50, 50, 192 };
		int[] array2 = new int[3] { 72, 79, 86 };
		int[] array3 = new int[3] { 70, 80, 90 };
		switch (color)
		{
		case 0:
			num = 3569;
			num2 = 3570;
			break;
		case 1:
			num = 3571;
			num2 = 3572;
			break;
		case 2:
			num = 3573;
			num2 = 3574;
			break;
		case 3:
			num = 3575;
			num2 = 3576;
			break;
		case 4:
			num = 3577;
			num2 = 3578;
			break;
		case 5:
			num = 3579;
			num2 = 3580;
			break;
		case 6:
			num = 3581;
			num2 = 3582;
			break;
		}
		num3 = array[place];
		num4 = 0;
		num5 = array3[place];
		if (place == 0)
		{
			evt.eventPlaySound(DirectionManager.SOUND.S0662, Sound.CH.SE0, true, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0540, Sound.CH.SE0, true, 1f, 20);
			evt.eventPlaySound(DirectionManager.SOUND.S0540, Sound.CH.SE0, true, 1f, 24);
			evt.eventPlayMovie(DirectionManager.MOVIE.bth000_a, false, false, false, false, 0, 0, 100, 0);
		}
		if (num >= 0)
		{
			evt.eventPlayMovie((DirectionManager.MOVIE)num, false, false, false, false, num3, num4, num5, 0);
		}
		if (num2 >= 0)
		{
			evt.eventPlayMovie((DirectionManager.MOVIE)num2, false, true, false, false, num3, num4, num5, 40);
		}
	}

	public override void end()
	{
		int num = SGLG.prod.findLayer(100f);
		if (num >= 0)
		{
			SGLG.prod.Kill(num);
		}
		base.end();
	}

	public override void control()
	{
		if (evt.m_Active && low == 0)
		{
			switch (mode)
			{
			case 3:
			case 6:
			case 9:
			case 12:
			case 15:
			case 18:
			case 21:
			case 118:
			case 120:
			case 122:
			case 124:
			case 126:
			case 128:
			{
				int num = MainGameScene.slotGameMan.m_kaidoData[466];
				int num2 = MainGameScene.slotGameMan.m_kaidoData[470 + (num - 1)];
				if (MainGameScene.slotGameMan.m_kaidoData[465] == 0)
				{
					break;
				}
				if (m_cnt == 55)
				{
					if (num == 1)
					{
						if (num2 == 0)
						{
							DirectionLedManager.DG_POW1_white_get(DirectionMainLED.LINE_MAIN_9);
						}
						if (num2 == 1)
						{
							DirectionLedManager.DG_POW1_blue_get(DirectionMainLED.LINE_MAIN_9);
						}
						if (num2 == 2)
						{
							DirectionLedManager.DG_POW1_yellow_get(DirectionMainLED.LINE_MAIN_9);
						}
						if (num2 == 3)
						{
							DirectionLedManager.DG_POW1_green_get(DirectionMainLED.LINE_MAIN_9);
						}
						if (num2 == 4)
						{
							DirectionLedManager.DG_POW1_red_get(DirectionMainLED.LINE_MAIN_9);
						}
						if (num2 == 5)
						{
							DirectionLedManager.DG_POW1_purple_get(DirectionMainLED.LINE_MAIN_9);
						}
						if (num2 == 6)
						{
							DirectionLedManager.DG_POW1_rainbow_get(DirectionMainLED.LINE_MAIN_9);
						}
					}
					if (num == 2)
					{
						if (num2 == 0)
						{
							DirectionLedManager.DG_POW2_white_get(DirectionMainLED.LINE_MAIN_10);
						}
						if (num2 == 1)
						{
							DirectionLedManager.DG_POW2_blue_get(DirectionMainLED.LINE_MAIN_10);
						}
						if (num2 == 2)
						{
							DirectionLedManager.DG_POW2_yellow_get(DirectionMainLED.LINE_MAIN_10);
						}
						if (num2 == 3)
						{
							DirectionLedManager.DG_POW2_green_get(DirectionMainLED.LINE_MAIN_10);
						}
						if (num2 == 4)
						{
							DirectionLedManager.DG_POW2_red_get(DirectionMainLED.LINE_MAIN_10);
						}
						if (num2 == 5)
						{
							DirectionLedManager.DG_POW2_purple_get(DirectionMainLED.LINE_MAIN_10);
						}
						if (num2 == 6)
						{
							DirectionLedManager.DG_POW2_rainbow_get(DirectionMainLED.LINE_MAIN_10);
						}
					}
					if (num == 3)
					{
						if (num2 == 0)
						{
							DirectionLedManager.DG_POW3_white_get(DirectionMainLED.LINE_MAIN_11);
						}
						if (num2 == 1)
						{
							DirectionLedManager.DG_POW3_blue_get(DirectionMainLED.LINE_MAIN_11);
						}
						if (num2 == 2)
						{
							DirectionLedManager.DG_POW3_yellow_get(DirectionMainLED.LINE_MAIN_11);
						}
						if (num2 == 3)
						{
							DirectionLedManager.DG_POW3_green_get(DirectionMainLED.LINE_MAIN_11);
						}
						if (num2 == 4)
						{
							DirectionLedManager.DG_POW3_red_get(DirectionMainLED.LINE_MAIN_11);
						}
						if (num2 == 5)
						{
							DirectionLedManager.DG_POW3_purple_get(DirectionMainLED.LINE_MAIN_11);
						}
						if (num2 == 6)
						{
							DirectionLedManager.DG_POW3_rainbow_get(DirectionMainLED.LINE_MAIN_11);
						}
					}
					if (num == 4)
					{
						if (num2 == 0)
						{
							DirectionLedManager.DG_POW4_white_get(DirectionMainLED.LINE_MAIN_12);
						}
						if (num2 == 1)
						{
							DirectionLedManager.DG_POW4_blue_get(DirectionMainLED.LINE_MAIN_12);
						}
						if (num2 == 2)
						{
							DirectionLedManager.DG_POW4_yellow_get(DirectionMainLED.LINE_MAIN_12);
						}
						if (num2 == 3)
						{
							DirectionLedManager.DG_POW4_green_get(DirectionMainLED.LINE_MAIN_12);
						}
						if (num2 == 4)
						{
							DirectionLedManager.DG_POW4_red_get(DirectionMainLED.LINE_MAIN_12);
						}
						if (num2 == 5)
						{
							DirectionLedManager.DG_POW4_purple_get(DirectionMainLED.LINE_MAIN_12);
						}
						if (num2 == 6)
						{
							DirectionLedManager.DG_POW4_rainbow_get(DirectionMainLED.LINE_MAIN_12);
						}
					}
					if (num == 5)
					{
						if (num2 == 0)
						{
							DirectionLedManager.DG_POW5_white_get(DirectionMainLED.LINE_MAIN_13);
						}
						if (num2 == 1)
						{
							DirectionLedManager.DG_POW5_blue_get(DirectionMainLED.LINE_MAIN_13);
						}
						if (num2 == 2)
						{
							DirectionLedManager.DG_POW5_yellow_get(DirectionMainLED.LINE_MAIN_13);
						}
						if (num2 == 3)
						{
							DirectionLedManager.DG_POW5_green_get(DirectionMainLED.LINE_MAIN_13);
						}
						if (num2 == 4)
						{
							DirectionLedManager.DG_POW5_red_get(DirectionMainLED.LINE_MAIN_13);
						}
						if (num2 == 5)
						{
							DirectionLedManager.DG_POW5_purple_get(DirectionMainLED.LINE_MAIN_13);
						}
						if (num2 == 6)
						{
							DirectionLedManager.DG_POW5_rainbow_get(DirectionMainLED.LINE_MAIN_13);
						}
					}
					if (num == 6)
					{
						if (num2 == 0)
						{
							DirectionLedManager.DG_POW6_rainbow_get(DirectionMainLED.LINE_MAIN_14);
						}
						if (num2 == 1)
						{
							DirectionLedManager.DG_POW6_rainbow_get(DirectionMainLED.LINE_MAIN_14);
						}
						if (num2 == 2)
						{
							DirectionLedManager.DG_POW6_rainbow_get(DirectionMainLED.LINE_MAIN_14);
						}
						if (num2 == 3)
						{
							DirectionLedManager.DG_POW6_rainbow_get(DirectionMainLED.LINE_MAIN_14);
						}
						if (num2 == 4)
						{
							DirectionLedManager.DG_POW6_rainbow_get(DirectionMainLED.LINE_MAIN_14);
						}
						if (num2 == 5)
						{
							DirectionLedManager.DG_POW6_rainbow_get(DirectionMainLED.LINE_MAIN_14);
						}
						if (num2 == 6)
						{
							DirectionLedManager.DG_POW6_rainbow_get(DirectionMainLED.LINE_MAIN_14);
						}
					}
				}
				m_cnt++;
				break;
			}
			}
		}
		base.control();
	}
}
