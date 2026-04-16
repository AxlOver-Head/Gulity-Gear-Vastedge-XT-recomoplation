public class Direction1MJM : DirectionBase
{
	public Direction1MJM(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_white_l_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_white_l_white_loop, DirectionManager.MOVIE.mjm001_r_white_l_white, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 2:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm003_l_white_fix, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm003_l_white_fix_loop, DirectionManager.MOVIE.mjm003_l_white_fix, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0351, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE1, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE0, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S1722, Sound.CH.VC0, true, 1f, 14);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 55, 10);
				evt.eventDisableBefore(mng, 0);
				break;
			case 3:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm004, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm004_loop, DirectionManager.MOVIE.mjm004, false, true, false, false);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0103, Sound.CH.BGM, true, 1f, 87);
				evt.eventPlaySound(DirectionManager.SOUND.S0213, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0354, Sound.CH.SE1, true, 1f, 16);
				evt.eventPlaySound(DirectionManager.SOUND.S1176, Sound.CH.VC0, true, 1f, 16);
				evt.eventPlaySound(DirectionManager.SOUND.S1177, Sound.CH.VC1, true, 1f, 35);
				evt.eventPlaySound(DirectionManager.SOUND.S0355, Sound.CH.SE0, true, 1f, 52);
				evt.eventPlaySound(DirectionManager.SOUND.S0356, Sound.CH.SE1, true, 1f, 60);
				evt.eventPlaySound(DirectionManager.SOUND.S1178, Sound.CH.VC0, true, 1f, 65);
				evt.eventDisableBefore(mng, 0);
				break;
			case 4:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh006_sly, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, true, 1f, 227);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S1395, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0511, Sound.CH.SE1, true, 1f, 98);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 118);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC1, true, 1f, 128);
				break;
			case 5:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh003_chp, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, true, 1f, 243);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0512, Sound.CH.SE1, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S1442, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0513, Sound.CH.SE0, true, 1f, 94);
				evt.eventPlaySound(DirectionManager.SOUND.S0514, Sound.CH.SE1, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC1, true, 1f, 144);
				break;
			case 6:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh005_mil, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, true, 1f, 219);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0515, Sound.CH.SE1, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S1492, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0516, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 147);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC1, true, 1f, 149);
				break;
			case 7:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh002_bri, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, true, 1f, 225);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S1544, Sound.CH.VC0, true, 1f, 81);
				evt.eventPlaySound(DirectionManager.SOUND.S0517, Sound.CH.SE1, true, 1f, 91);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC1, true, 1f, 149);
				break;
			case 8:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 183);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 79);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 136);
				break;
			case 9:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh004_kai, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0189, Sound.CH.BGM, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S1342, Sound.CH.VC0, true, 1f, 85);
				break;
			case 10:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 235);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 73);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 142);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 150);
				break;
			case 11:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm004_r_white_fix, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm003_r_white_fix_loop, DirectionManager.MOVIE.mjm004_r_white_fix, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0351, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1721, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE0, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0211, Sound.CH.SE1, true, 1f, 13);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 44, 10);
				evt.eventDisableBefore(mng, 0);
				break;
			case 12:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh006_sly, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, true, 1f, 227);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S1395, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0511, Sound.CH.SE1, true, 1f, 98);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 118);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC1, true, 1f, 128);
				break;
			case 13:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh003_chp, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, true, 1f, 243);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0512, Sound.CH.SE1, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S1442, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0513, Sound.CH.SE0, true, 1f, 94);
				evt.eventPlaySound(DirectionManager.SOUND.S0514, Sound.CH.SE1, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC1, true, 1f, 144);
				break;
			case 14:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh005_mil, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, true, 1f, 219);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0515, Sound.CH.SE1, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S1492, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0516, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 147);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC1, true, 1f, 149);
				break;
			case 15:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh002_bri, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, true, 1f, 225);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S1544, Sound.CH.VC0, true, 1f, 81);
				evt.eventPlaySound(DirectionManager.SOUND.S0517, Sound.CH.SE1, true, 1f, 91);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC1, true, 1f, 149);
				break;
			case 16:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 183);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 79);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 136);
				break;
			case 17:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh004_kai, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0189, Sound.CH.BGM, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S1342, Sound.CH.VC0, true, 1f, 85);
				break;
			case 18:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 235);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 73);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 142);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 150);
				break;
			case 19:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001b, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh006_sly, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, true, 1f, 227);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S1395, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0511, Sound.CH.SE1, true, 1f, 98);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 118);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC1, true, 1f, 128);
				break;
			case 20:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001b, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh003_chp, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, true, 1f, 243);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0512, Sound.CH.SE1, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S1442, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0513, Sound.CH.SE0, true, 1f, 94);
				evt.eventPlaySound(DirectionManager.SOUND.S0514, Sound.CH.SE1, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC1, true, 1f, 144);
				break;
			case 21:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001b, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh005_mil, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, true, 1f, 219);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0515, Sound.CH.SE1, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S1492, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0516, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 147);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC1, true, 1f, 149);
				break;
			case 22:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001b, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh002_bri, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, true, 1f, 225);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S1544, Sound.CH.VC0, true, 1f, 81);
				evt.eventPlaySound(DirectionManager.SOUND.S0517, Sound.CH.SE1, true, 1f, 91);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC1, true, 1f, 149);
				break;
			case 23:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001b, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 183);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 79);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 136);
				break;
			case 24:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001b, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh004_kai, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0189, Sound.CH.BGM, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S1342, Sound.CH.VC0, true, 1f, 85);
				break;
			case 25:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001b, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 235);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 73);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 142);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 150);
				break;
			case 26:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_white_l_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_white_l_blue_loop, DirectionManager.MOVIE.mjm001_r_white_l_blue, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 27:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm003_l_blue_fix, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm003_l_blue_fix_loop, DirectionManager.MOVIE.mjm003_l_blue_fix, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0351, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE1, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE0, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S1722, Sound.CH.VC0, true, 1f, 14);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 55, 10);
				evt.eventDisableBefore(mng, 0);
				break;
			case 28:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh006_sly, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, true, 1f, 227);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S1395, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0511, Sound.CH.SE1, true, 1f, 98);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 118);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC1, true, 1f, 128);
				break;
			case 29:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh003_chp, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, true, 1f, 243);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0512, Sound.CH.SE1, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S1442, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0513, Sound.CH.SE0, true, 1f, 94);
				evt.eventPlaySound(DirectionManager.SOUND.S0514, Sound.CH.SE1, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC1, true, 1f, 144);
				break;
			case 30:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh005_mil, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, true, 1f, 219);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0515, Sound.CH.SE1, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S1492, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0516, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 147);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC1, true, 1f, 149);
				break;
			case 31:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh002_bri, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, true, 1f, 225);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S1544, Sound.CH.VC0, true, 1f, 81);
				evt.eventPlaySound(DirectionManager.SOUND.S0517, Sound.CH.SE1, true, 1f, 91);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC1, true, 1f, 149);
				break;
			case 32:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 183);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 79);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 136);
				break;
			case 33:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh004_kai, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0189, Sound.CH.BGM, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S1342, Sound.CH.VC0, true, 1f, 85);
				break;
			case 34:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 235);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 73);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 142);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 150);
				break;
			case 35:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_white_l_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_white_l_yellow_loop, DirectionManager.MOVIE.mjm001_r_white_l_yellow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 36:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm003_l_yellow_fix, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm003_l_yellow_fix_loop, DirectionManager.MOVIE.mjm003_l_yellow_fix, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0351, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE1, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE0, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S1722, Sound.CH.VC0, true, 1f, 14);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 55, 10);
				evt.eventDisableBefore(mng, 0);
				break;
			case 37:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh006_sly, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, true, 1f, 227);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S1395, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0511, Sound.CH.SE1, true, 1f, 98);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 118);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC1, true, 1f, 128);
				break;
			case 38:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh003_chp, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, true, 1f, 243);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0512, Sound.CH.SE1, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S1442, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0513, Sound.CH.SE0, true, 1f, 94);
				evt.eventPlaySound(DirectionManager.SOUND.S0514, Sound.CH.SE1, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC1, true, 1f, 144);
				break;
			case 39:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh005_mil, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, true, 1f, 219);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0515, Sound.CH.SE1, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S1492, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0516, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 147);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC1, true, 1f, 149);
				break;
			case 40:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh002_bri, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, true, 1f, 225);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S1544, Sound.CH.VC0, true, 1f, 81);
				evt.eventPlaySound(DirectionManager.SOUND.S0517, Sound.CH.SE1, true, 1f, 91);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC1, true, 1f, 149);
				break;
			case 41:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 183);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 79);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 136);
				break;
			case 42:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh004_kai, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0189, Sound.CH.BGM, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S1342, Sound.CH.VC0, true, 1f, 85);
				break;
			case 43:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 235);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 73);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 142);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 150);
				break;
			case 44:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_white_l_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_white_l_green_loop, DirectionManager.MOVIE.mjm001_r_white_l_green, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 45:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm003_l_green_fix, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm003_l_green_fix_loop, DirectionManager.MOVIE.mjm003_l_green_fix, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0351, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE1, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE0, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S1722, Sound.CH.VC0, true, 1f, 14);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 55, 10);
				evt.eventDisableBefore(mng, 0);
				break;
			case 46:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh006_sly, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, true, 1f, 227);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S1395, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0511, Sound.CH.SE1, true, 1f, 98);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 118);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC1, true, 1f, 128);
				break;
			case 47:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh003_chp, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, true, 1f, 243);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0512, Sound.CH.SE1, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S1442, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0513, Sound.CH.SE0, true, 1f, 94);
				evt.eventPlaySound(DirectionManager.SOUND.S0514, Sound.CH.SE1, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC1, true, 1f, 144);
				break;
			case 48:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh005_mil, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, true, 1f, 219);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0515, Sound.CH.SE1, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S1492, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0516, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 147);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC1, true, 1f, 149);
				break;
			case 49:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh002_bri, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, true, 1f, 225);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S1544, Sound.CH.VC0, true, 1f, 81);
				evt.eventPlaySound(DirectionManager.SOUND.S0517, Sound.CH.SE1, true, 1f, 91);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC1, true, 1f, 149);
				break;
			case 50:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 183);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 79);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 136);
				break;
			case 51:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh004_kai, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0189, Sound.CH.BGM, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S1342, Sound.CH.VC0, true, 1f, 85);
				break;
			case 52:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 235);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 73);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 142);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 150);
				break;
			case 53:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_white_l_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_white_l_red_loop, DirectionManager.MOVIE.mjm001_r_white_l_red, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 54:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm003_l_red_fix, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm003_l_red_fix_loop, DirectionManager.MOVIE.mjm003_l_red_fix, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0351, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE1, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE0, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S1722, Sound.CH.VC0, true, 1f, 14);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 55, 10);
				evt.eventDisableBefore(mng, 0);
				break;
			case 55:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh006_sly, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, true, 1f, 227);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S1395, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0511, Sound.CH.SE1, true, 1f, 98);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 118);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC1, true, 1f, 128);
				break;
			case 56:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh003_chp, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, true, 1f, 243);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0512, Sound.CH.SE1, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S1442, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0513, Sound.CH.SE0, true, 1f, 94);
				evt.eventPlaySound(DirectionManager.SOUND.S0514, Sound.CH.SE1, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC1, true, 1f, 144);
				break;
			case 57:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh005_mil, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, true, 1f, 219);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0515, Sound.CH.SE1, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S1492, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0516, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 147);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC1, true, 1f, 149);
				break;
			case 58:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh002_bri, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, true, 1f, 225);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S1544, Sound.CH.VC0, true, 1f, 81);
				evt.eventPlaySound(DirectionManager.SOUND.S0517, Sound.CH.SE1, true, 1f, 91);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC1, true, 1f, 149);
				break;
			case 59:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 183);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 79);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 136);
				break;
			case 60:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh004_kai, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0189, Sound.CH.BGM, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S1342, Sound.CH.VC0, true, 1f, 85);
				break;
			case 61:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 235);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 73);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 142);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 150);
				break;
			case 62:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_white_l_purple, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_white_l_purple_loop, DirectionManager.MOVIE.mjm001_r_white_l_purple, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 63:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm003_l_purple_fix, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm003_l_purple_fix_loop, DirectionManager.MOVIE.mjm003_l_purple_fix, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0351, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE1, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE0, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S1722, Sound.CH.VC0, true, 1f, 14);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 55, 10);
				evt.eventDisableBefore(mng, 0);
				break;
			case 64:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh006_sly, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, true, 1f, 227);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S1395, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0511, Sound.CH.SE1, true, 1f, 98);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 118);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC1, true, 1f, 128);
				break;
			case 65:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh003_chp, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, true, 1f, 243);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0512, Sound.CH.SE1, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S1442, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0513, Sound.CH.SE0, true, 1f, 94);
				evt.eventPlaySound(DirectionManager.SOUND.S0514, Sound.CH.SE1, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC1, true, 1f, 144);
				break;
			case 66:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh005_mil, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, true, 1f, 219);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0515, Sound.CH.SE1, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S1492, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0516, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 147);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC1, true, 1f, 149);
				break;
			case 67:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh002_bri, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, true, 1f, 225);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S1544, Sound.CH.VC0, true, 1f, 81);
				evt.eventPlaySound(DirectionManager.SOUND.S0517, Sound.CH.SE1, true, 1f, 91);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC1, true, 1f, 149);
				break;
			case 68:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 183);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 79);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 136);
				break;
			case 69:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh004_kai, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0189, Sound.CH.BGM, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S1342, Sound.CH.VC0, true, 1f, 85);
				break;
			case 70:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 235);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 73);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 142);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 150);
				break;
			case 71:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_white_l_rainbow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_white_l_rainbow_loop, DirectionManager.MOVIE.mjm001_r_white_l_rainbow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 72:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm003_l_rainbow_fix, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm003_l_rainbow_fix_loop, DirectionManager.MOVIE.mjm003_l_rainbow_fix, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0351, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE1, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0217, Sound.CH.SE0, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S1722, Sound.CH.VC0, true, 1f, 14);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 55, 10);
				evt.eventDisableBefore(mng, 0);
				break;
			case 73:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm007, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 235);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 73);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 142);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 150);
				break;
			case 74:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_blue_l_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_blue_l_white_loop, DirectionManager.MOVIE.mjm001_r_blue_l_white, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 75:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm003_r_blue_fix, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm003_r_blue_fix_loop, DirectionManager.MOVIE.mjm003_r_blue_fix, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0351, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1721, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE0, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0211, Sound.CH.SE1, true, 1f, 13);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 44, 10);
				evt.eventDisableBefore(mng, 0);
				break;
			case 76:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh006_sly, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, true, 1f, 227);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S1395, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0511, Sound.CH.SE1, true, 1f, 98);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 118);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC1, true, 1f, 128);
				break;
			case 77:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh003_chp, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, true, 1f, 243);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0512, Sound.CH.SE1, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S1442, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0513, Sound.CH.SE0, true, 1f, 94);
				evt.eventPlaySound(DirectionManager.SOUND.S0514, Sound.CH.SE1, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC1, true, 1f, 144);
				break;
			case 78:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh005_mil, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, true, 1f, 219);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0515, Sound.CH.SE1, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S1492, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0516, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 147);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC1, true, 1f, 149);
				break;
			case 79:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh002_bri, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, true, 1f, 225);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S1544, Sound.CH.VC0, true, 1f, 81);
				evt.eventPlaySound(DirectionManager.SOUND.S0517, Sound.CH.SE1, true, 1f, 91);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC1, true, 1f, 149);
				break;
			case 80:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 183);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 79);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 136);
				break;
			case 81:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh004_kai, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0189, Sound.CH.BGM, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S1342, Sound.CH.VC0, true, 1f, 85);
				break;
			case 82:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 235);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 73);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 142);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 150);
				break;
			case 83:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_blue_l_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_blue_l_blue_loop, DirectionManager.MOVIE.mjm001_r_blue_l_blue, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 84:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_blue_l_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_blue_l_yellow_loop, DirectionManager.MOVIE.mjm001_r_blue_l_yellow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 85:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_blue_l_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_blue_l_green_loop, DirectionManager.MOVIE.mjm001_r_blue_l_green, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 86:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_blue_l_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_blue_l_red_loop, DirectionManager.MOVIE.mjm001_r_blue_l_red, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 87:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_blue_l_purple, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_blue_l_purple_loop, DirectionManager.MOVIE.mjm001_r_blue_l_purple, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 88:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_blue_l_rainbow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_blue_l_rainbow_loop, DirectionManager.MOVIE.mjm001_r_blue_l_rainbow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 89:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_yellow_l_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_yellow_l_white_loop, DirectionManager.MOVIE.mjm001_r_yellow_l_white, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 90:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm003_r_yellow_fix, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm003_r_yellow_fix_loop, DirectionManager.MOVIE.mjm003_r_yellow_fix, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0351, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1721, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE0, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0211, Sound.CH.SE1, true, 1f, 13);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 44, 10);
				evt.eventDisableBefore(mng, 0);
				break;
			case 91:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh006_sly, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, true, 1f, 227);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S1395, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0511, Sound.CH.SE1, true, 1f, 98);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 118);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC1, true, 1f, 128);
				break;
			case 92:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh003_chp, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, true, 1f, 243);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0512, Sound.CH.SE1, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S1442, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0513, Sound.CH.SE0, true, 1f, 94);
				evt.eventPlaySound(DirectionManager.SOUND.S0514, Sound.CH.SE1, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC1, true, 1f, 144);
				break;
			case 93:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh005_mil, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, true, 1f, 219);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0515, Sound.CH.SE1, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S1492, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0516, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 147);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC1, true, 1f, 149);
				break;
			case 94:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh002_bri, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, true, 1f, 225);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S1544, Sound.CH.VC0, true, 1f, 81);
				evt.eventPlaySound(DirectionManager.SOUND.S0517, Sound.CH.SE1, true, 1f, 91);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC1, true, 1f, 149);
				break;
			case 95:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 183);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 79);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 136);
				break;
			case 96:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh004_kai, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0189, Sound.CH.BGM, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S1342, Sound.CH.VC0, true, 1f, 85);
				break;
			case 97:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 235);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 73);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 142);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 150);
				break;
			case 98:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_yellow_l_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_yellow_l_blue_loop, DirectionManager.MOVIE.mjm001_r_yellow_l_blue, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 99:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_yellow_l_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_yellow_l_yellow_loop, DirectionManager.MOVIE.mjm001_r_yellow_l_yellow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 100:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_yellow_l_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_yellow_l_green_loop, DirectionManager.MOVIE.mjm001_r_yellow_l_green, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 101:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_yellow_l_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_yellow_l_red_loop, DirectionManager.MOVIE.mjm001_r_yellow_l_red, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 102:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_yellow_l_purple, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_yellow_l_purple_loop, DirectionManager.MOVIE.mjm001_r_yellow_l_purple, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 103:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_yellow_l_rainbow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_yellow_l_rainbow_loop, DirectionManager.MOVIE.mjm001_r_yellow_l_rainbow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 104:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_green_l_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_green_l_white_loop, DirectionManager.MOVIE.mjm001_r_green_l_white, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 105:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm003_r_green_fix, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm003_r_green_fix_loop, DirectionManager.MOVIE.mjm003_r_green_fix, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0351, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1721, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE0, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0211, Sound.CH.SE1, true, 1f, 13);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 44, 10);
				evt.eventDisableBefore(mng, 0);
				break;
			case 106:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh006_sly, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, true, 1f, 227);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S1395, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0511, Sound.CH.SE1, true, 1f, 98);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 118);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC1, true, 1f, 128);
				break;
			case 107:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh003_chp, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, true, 1f, 243);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0512, Sound.CH.SE1, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S1442, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0513, Sound.CH.SE0, true, 1f, 94);
				evt.eventPlaySound(DirectionManager.SOUND.S0514, Sound.CH.SE1, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC1, true, 1f, 144);
				break;
			case 108:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh005_mil, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, true, 1f, 219);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0515, Sound.CH.SE1, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S1492, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0516, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 147);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC1, true, 1f, 149);
				break;
			case 109:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh002_bri, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, true, 1f, 225);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S1544, Sound.CH.VC0, true, 1f, 81);
				evt.eventPlaySound(DirectionManager.SOUND.S0517, Sound.CH.SE1, true, 1f, 91);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC1, true, 1f, 149);
				break;
			case 110:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 183);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 79);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 136);
				break;
			case 111:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh004_kai, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0189, Sound.CH.BGM, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S1342, Sound.CH.VC0, true, 1f, 85);
				break;
			case 112:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 235);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 73);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 142);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 150);
				break;
			case 113:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_green_l_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_green_l_blue_loop, DirectionManager.MOVIE.mjm001_r_green_l_blue, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 114:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_green_l_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_green_l_yellow_loop, DirectionManager.MOVIE.mjm001_r_green_l_yellow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 115:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_green_l_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_green_l_green_loop, DirectionManager.MOVIE.mjm001_r_green_l_green, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 116:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_green_l_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_green_l_red_loop, DirectionManager.MOVIE.mjm001_r_green_l_red, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 117:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_green_l_purple, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_green_l_purple_loop, DirectionManager.MOVIE.mjm001_r_green_l_purple, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 118:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_green_l_rainbow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_green_l_rainbow_loop, DirectionManager.MOVIE.mjm001_r_green_l_rainbow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 119:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_red_l_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_red_l_white_loop, DirectionManager.MOVIE.mjm001_r_red_l_white, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 120:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm003_r_red_fix, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm003_r_red_fix_loop, DirectionManager.MOVIE.mjm003_r_red_fix, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0351, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1721, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE0, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0211, Sound.CH.SE1, true, 1f, 13);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 44, 10);
				evt.eventDisableBefore(mng, 0);
				break;
			case 121:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh006_sly, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, true, 1f, 227);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S1395, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0511, Sound.CH.SE1, true, 1f, 98);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 118);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC1, true, 1f, 128);
				break;
			case 122:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh003_chp, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, true, 1f, 243);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0512, Sound.CH.SE1, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S1442, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0513, Sound.CH.SE0, true, 1f, 94);
				evt.eventPlaySound(DirectionManager.SOUND.S0514, Sound.CH.SE1, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC1, true, 1f, 144);
				break;
			case 123:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh005_mil, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, true, 1f, 219);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0515, Sound.CH.SE1, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S1492, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0516, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 147);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC1, true, 1f, 149);
				break;
			case 124:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh002_bri, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, true, 1f, 225);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S1544, Sound.CH.VC0, true, 1f, 81);
				evt.eventPlaySound(DirectionManager.SOUND.S0517, Sound.CH.SE1, true, 1f, 91);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC1, true, 1f, 149);
				break;
			case 125:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 183);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 79);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 136);
				break;
			case 126:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh004_kai, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0189, Sound.CH.BGM, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S1342, Sound.CH.VC0, true, 1f, 85);
				break;
			case 127:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 235);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 73);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 142);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 150);
				break;
			case 128:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_red_l_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_red_l_blue_loop, DirectionManager.MOVIE.mjm001_r_red_l_blue, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 129:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_red_l_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_red_l_yellow_loop, DirectionManager.MOVIE.mjm001_r_red_l_yellow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 130:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_red_l_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_red_l_green_loop, DirectionManager.MOVIE.mjm001_r_red_l_green, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 131:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_red_l_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_red_l_red_loop, DirectionManager.MOVIE.mjm001_r_red_l_red, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 132:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_red_l_purple, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_red_l_purple_loop, DirectionManager.MOVIE.mjm001_r_red_l_purple, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 133:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_red_l_rainbow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_red_l_rainbow_loop, DirectionManager.MOVIE.mjm001_r_red_l_rainbow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 134:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_purple_l_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_purple_l_white_loop, DirectionManager.MOVIE.mjm001_r_purple_l_white, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 135:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm003_r_purple_fix, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm003_r_purple_fix_loop, DirectionManager.MOVIE.mjm003_r_purple_fix, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0351, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1721, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE0, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0211, Sound.CH.SE1, true, 1f, 13);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 44, 10);
				evt.eventDisableBefore(mng, 0);
				break;
			case 136:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh006_sly, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, true, 1f, 227);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S1395, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0511, Sound.CH.SE1, true, 1f, 98);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 118);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC1, true, 1f, 128);
				break;
			case 137:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh003_chp, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, true, 1f, 243);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0512, Sound.CH.SE1, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S1442, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0513, Sound.CH.SE0, true, 1f, 94);
				evt.eventPlaySound(DirectionManager.SOUND.S0514, Sound.CH.SE1, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC1, true, 1f, 144);
				break;
			case 138:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh005_mil, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, true, 1f, 219);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0515, Sound.CH.SE1, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S1492, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0516, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 147);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC1, true, 1f, 149);
				break;
			case 139:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh002_bri, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, true, 1f, 225);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S1544, Sound.CH.VC0, true, 1f, 81);
				evt.eventPlaySound(DirectionManager.SOUND.S0517, Sound.CH.SE1, true, 1f, 91);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC1, true, 1f, 149);
				break;
			case 140:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 183);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 79);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 136);
				break;
			case 141:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh004_kai, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0189, Sound.CH.BGM, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S1342, Sound.CH.VC0, true, 1f, 85);
				break;
			case 142:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 235);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 73);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 142);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 150);
				break;
			case 143:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_purple_l_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_purple_l_blue_loop, DirectionManager.MOVIE.mjm001_r_purple_l_blue, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 144:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_purple_l_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_purple_l_yellow_loop, DirectionManager.MOVIE.mjm001_r_purple_l_yellow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 145:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_purple_l_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_purple_l_green_loop, DirectionManager.MOVIE.mjm001_r_purple_l_green, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 146:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_purple_l_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_purple_l_red_loop, DirectionManager.MOVIE.mjm001_r_purple_l_red, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 147:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_purple_l_purple, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_purple_l_purple_loop, DirectionManager.MOVIE.mjm001_r_purple_l_purple, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 148:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_purple_l_rainbow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_purple_l_rainbow_loop, DirectionManager.MOVIE.mjm001_r_purple_l_rainbow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 149:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm001_r_rainbow_l_rainbow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm001_r_rainbow_l_rainbow_loop, DirectionManager.MOVIE.mjm001_r_rainbow_l_rainbow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0102, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0350, Sound.CH.SE0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1720, Sound.CH.VC0, true, 1f, 55);
				break;
			case 150:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm003_r_rainbow_fix, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm003_r_rainbow_fix_loop, DirectionManager.MOVIE.mjm003_r_rainbow_fix, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0351, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1721, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0353, Sound.CH.SE0, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0217, Sound.CH.SE1, true, 1f, 13);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 44, 10);
				evt.eventDisableBefore(mng, 0);
				break;
			case 151:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm006, false, false, false, false, 0, 0, 100, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 235);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 73);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 142);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 150);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			}
		}
		if (low != 0)
		{
			return;
		}
		byte b = mode;
		if (b == 152)
		{
			switch ((int)MainGameScene.dirMan.m_Mode[0])
			{
			case 1:
			case 74:
			case 89:
			case 104:
			case 119:
			case 134:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm003_l_white_neko, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm003_l_white_neko_loop, DirectionManager.MOVIE.mjm003_l_white_neko, false, true, false, false);
				break;
			case 26:
			case 83:
			case 98:
			case 113:
			case 128:
			case 143:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm003_l_blue_neko, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm003_l_blue_neko_loop, DirectionManager.MOVIE.mjm003_l_blue_neko, false, true, false, false);
				break;
			case 35:
			case 84:
			case 99:
			case 114:
			case 129:
			case 144:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm003_l_yellow_neko, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm003_l_yellow_neko_loop, DirectionManager.MOVIE.mjm003_l_yellow_neko, false, true, false, false);
				break;
			case 44:
			case 85:
			case 100:
			case 115:
			case 130:
			case 145:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm003_l_green_neko, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm003_l_green_neko_loop, DirectionManager.MOVIE.mjm003_l_green_neko, false, true, false, false);
				break;
			case 53:
			case 86:
			case 101:
			case 116:
			case 131:
			case 146:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm003_l_red_neko, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm003_l_red_neko_loop, DirectionManager.MOVIE.mjm003_l_red_neko, false, true, false, false);
				break;
			case 62:
			case 87:
			case 102:
			case 117:
			case 132:
			case 147:
				evt.eventPlayMovie(DirectionManager.MOVIE.mjm003_l_purple_neko, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.mjm003_l_purple_neko_loop, DirectionManager.MOVIE.mjm003_l_purple_neko, false, true, false, false);
				break;
			}
			evt.eventPlaySound(DirectionManager.SOUND.S0351, Sound.CH.SE0, true, 1f, 0);
			evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE1, true, 1f, 13);
			evt.eventPlaySound(DirectionManager.SOUND.S0215, Sound.CH.SE0, true, 1f, 13);
			evt.eventPlaySound(DirectionManager.SOUND.S1722, Sound.CH.VC0, true, 1f, 14);
			evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 55, 10);
			evt.eventDisableBefore(mng, 0);
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
