public class Direction59CSH : DirectionBase
{
	public Direction59CSH(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0108, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh001, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0877, Sound.CH.VC0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S1225, Sound.CH.VC0, true, 1f, 87);
				evt.eventPlaySound(DirectionManager.SOUND.S0632, Sound.CH.SE0, true, 1f, 154);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh002_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.csh002_a_loop, DirectionManager.MOVIE.csh002_a, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0633, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0634, Sound.CH.SE0, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S1309, Sound.CH.VC0, true, 1f, 44);
				break;
			case 3:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 80);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh003_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.csh003_white_loop, DirectionManager.MOVIE.csh003_white, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0636, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1227, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, false, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0878, Sound.CH.VC0, true, 1f, 51);
				break;
			case 4:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 80);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh003_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.csh003_blue_loop, DirectionManager.MOVIE.csh003_blue, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0636, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1227, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, false, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0878, Sound.CH.VC0, true, 1f, 51);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 80);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh003_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.csh003_yellow_loop, DirectionManager.MOVIE.csh003_yellow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0636, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1227, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, false, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0878, Sound.CH.VC0, true, 1f, 51);
				break;
			case 6:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 80);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh003_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.csh003_green_loop, DirectionManager.MOVIE.csh003_green, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0636, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1227, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, false, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0878, Sound.CH.VC0, true, 1f, 51);
				break;
			case 7:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 80);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh003_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.csh003_red_loop, DirectionManager.MOVIE.csh003_red, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0636, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1227, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, false, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0878, Sound.CH.VC0, true, 1f, 51);
				break;
			case 8:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 80);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh003_purple, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.csh003_purple_loop, DirectionManager.MOVIE.csh003_purple, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0636, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1227, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, false, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0878, Sound.CH.VC0, true, 1f, 51);
				break;
			case 9:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 80);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh003_rainbow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.csh003_rainbow_loop, DirectionManager.MOVIE.csh003_rainbow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0636, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1227, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, false, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0217, Sound.CH.SE0, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0878, Sound.CH.VC0, true, 1f, 51);
				break;
			case 10:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 109);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh003_maneki, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.csh003_maneki_loop, DirectionManager.MOVIE.csh003_maneki, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0636, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1227, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, false, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0215, Sound.CH.SE0, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0878, Sound.CH.VC0, true, 1f, 80);
				break;
			case 11:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 73);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh003_white_l, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.csh003_white_l_loop, DirectionManager.MOVIE.csh003_white_l, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0636, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1227, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, false, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0211, Sound.CH.SE0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0879, Sound.CH.VC0, true, 1f, 51);
				break;
			case 12:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 73);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh003_blue_l, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.csh003_blue_l_loop, DirectionManager.MOVIE.csh003_blue_l, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0636, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1227, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, false, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0211, Sound.CH.SE0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0879, Sound.CH.VC0, true, 1f, 51);
				break;
			case 13:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 73);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh003_yellow_l, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.csh003_yellow_l_loop, DirectionManager.MOVIE.csh003_yellow_l, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0636, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1227, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, false, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0211, Sound.CH.SE0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0879, Sound.CH.VC0, true, 1f, 51);
				break;
			case 14:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 73);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh003_green_l, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.csh003_green_l_loop, DirectionManager.MOVIE.csh003_green_l, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0636, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1227, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, false, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0211, Sound.CH.SE0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0879, Sound.CH.VC0, true, 1f, 51);
				break;
			case 15:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 73);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh003_red_l, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.csh003_red_l_loop, DirectionManager.MOVIE.csh003_red_l, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0636, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1227, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, false, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0211, Sound.CH.SE0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0879, Sound.CH.VC0, true, 1f, 51);
				break;
			case 16:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 73);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh003_purple_l, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.csh003_purple_l_loop, DirectionManager.MOVIE.csh003_purple_l, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0636, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1227, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, false, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0211, Sound.CH.SE0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0879, Sound.CH.VC0, true, 1f, 51);
				break;
			case 17:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 73);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh003_rainbow_l, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.csh003_rainbow_l_loop, DirectionManager.MOVIE.csh003_rainbow_l, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0636, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1227, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, false, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0217, Sound.CH.SE0, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0879, Sound.CH.VC0, true, 1f, 51);
				break;
			case 18:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 102);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh003_maneki_l, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.csh003_maneki_l_loop, DirectionManager.MOVIE.csh003_maneki_l, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0636, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1227, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, false, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0215, Sound.CH.SE0, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0879, Sound.CH.VC0, true, 1f, 80);
				break;
			case 19:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 84);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh004, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.csh004_loop, DirectionManager.MOVIE.csh004, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0109, Sound.CH.BGM, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0637, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0213, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1228, Sound.CH.VC0, true, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0638, Sound.CH.SE0, true, 1f, 33);
				evt.eventPlaySound(DirectionManager.SOUND.S2035, Sound.CH.VC0, true, 1f, 56);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 67);
				break;
			case 20:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.imb001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.imb001_loop, DirectionManager.MOVIE.imb001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0131, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0505, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0898, Sound.CH.VC0, true, 1f, 19);
				break;
			case 21:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 248);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.csh005_loop, DirectionManager.MOVIE.csh005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0637, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0213, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1228, Sound.CH.VC0, true, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0270, Sound.CH.SE0, true, 1f, 37);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh006_sly, false, false, false, false, 0, 0, 90, 53);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh006_sly_loop, DirectionManager.MOVIE.ksh006_sly, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, false, 1f, 249);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 53);
				evt.eventPlaySound(DirectionManager.SOUND.S1395, Sound.CH.VC0, true, 1f, 102);
				evt.eventPlaySound(DirectionManager.SOUND.S0511, Sound.CH.SE0, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 140);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC0, true, 1f, 150);
				break;
			case 22:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 264);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.csh005_loop, DirectionManager.MOVIE.csh005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0637, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0213, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1228, Sound.CH.VC0, true, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0270, Sound.CH.SE0, true, 1f, 37);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh003_chp, false, false, false, false, 0, 0, 90, 53);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh003_chp_loop, DirectionManager.MOVIE.ksh003_chp, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, true, 1f, 265);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 53);
				evt.eventPlaySound(DirectionManager.SOUND.S0512, Sound.CH.SE1, true, 1f, 102);
				evt.eventPlaySound(DirectionManager.SOUND.S1442, Sound.CH.VC0, true, 1f, 102);
				evt.eventPlaySound(DirectionManager.SOUND.S0513, Sound.CH.SE0, true, 1f, 116);
				evt.eventPlaySound(DirectionManager.SOUND.S0514, Sound.CH.SE1, true, 1f, 148);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 165);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC1, true, 1f, 166);
				break;
			case 23:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 240);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.csh005_loop, DirectionManager.MOVIE.csh005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0637, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0213, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1228, Sound.CH.VC0, true, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0270, Sound.CH.SE0, true, 1f, 37);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh005_mil, false, false, false, false, 0, 0, 90, 53);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh005_mil_loop, DirectionManager.MOVIE.ksh005_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, true, 1f, 241);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 53);
				evt.eventPlaySound(DirectionManager.SOUND.S0515, Sound.CH.SE1, true, 1f, 117);
				evt.eventPlaySound(DirectionManager.SOUND.S1492, Sound.CH.VC0, true, 1f, 117);
				evt.eventPlaySound(DirectionManager.SOUND.S0516, Sound.CH.SE0, true, 1f, 155);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 169);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC1, true, 1f, 171);
				break;
			case 24:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 246);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.csh005_loop, DirectionManager.MOVIE.csh005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0637, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0213, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1228, Sound.CH.VC0, true, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0270, Sound.CH.SE0, true, 1f, 37);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh002_bri, false, false, false, false, 0, 0, 90, 53);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh002_bri_loop, DirectionManager.MOVIE.ksh002_bri, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, true, 1f, 247);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 53);
				evt.eventPlaySound(DirectionManager.SOUND.S1544, Sound.CH.VC0, true, 1f, 103);
				evt.eventPlaySound(DirectionManager.SOUND.S0517, Sound.CH.SE1, true, 1f, 113);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 155);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC1, true, 1f, 171);
				break;
			case 25:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 204);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.csh005_loop, DirectionManager.MOVIE.csh005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0637, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0213, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1228, Sound.CH.VC0, true, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0270, Sound.CH.SE0, true, 1f, 37);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 90, 53);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh007_zap_loop, DirectionManager.MOVIE.ksh007_zap, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 205);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 53);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 146);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 158);
				break;
			case 26:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 144);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.csh005_loop, DirectionManager.MOVIE.csh005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0637, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0213, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1228, Sound.CH.VC0, true, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0270, Sound.CH.SE0, true, 1f, 37);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh004_kai, false, false, false, false, 0, 0, 90, 53);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh004_kai_loop, DirectionManager.MOVIE.ksh004_kai, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0189, Sound.CH.BGM, true, 1f, 145);
				evt.eventPlaySound(DirectionManager.SOUND.S0519, Sound.CH.SE0, true, 1f, 53);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1342, Sound.CH.VC0, true, 1f, 104);
				break;
			case 27:
				evt.eventDisableBefore(mng, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 256);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.csh005_ano, DirectionManager.MOVIE.csh005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0637, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0213, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1228, Sound.CH.VC0, true, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0270, Sound.CH.SE0, true, 1f, 37);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 90, 53);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh001_ano_loop, DirectionManager.MOVIE.ksh001_ano, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 257);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 53);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 117);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 164);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 172);
				break;
			case 28:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.csh002_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0633, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0635, Sound.CH.SE0, true, 1f, 36);
				evt.eventPlaySound(DirectionManager.SOUND.S1309, Sound.CH.VC0, true, 1f, 44);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
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
}
