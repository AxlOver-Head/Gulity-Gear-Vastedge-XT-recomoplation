public class Direction45KHO : DirectionBase
{
	public Direction45KHO(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventPlayMovie(DirectionManager.MOVIE.kho001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002a_white, DirectionManager.MOVIE.kho001, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002a_white_loop, DirectionManager.MOVIE.kho002a_white, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0866, Sound.CH.VC0, true, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0535, Sound.CH.SE0, true, 1f, 27);
				break;
			case 2:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004a, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004a_loop, DirectionManager.MOVIE.kho004a, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0118, Sound.CH.SE0, false, 1f, 53);
				break;
			case 3:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004j, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004j_loop, DirectionManager.MOVIE.kho004j, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 53);
				break;
			case 4:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004k, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004k_loop, DirectionManager.MOVIE.kho004k, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 53);
				break;
			case 5:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004l, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004l_loop, DirectionManager.MOVIE.kho004l, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 53);
				break;
			case 6:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004m, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004m_loop, DirectionManager.MOVIE.kho004m, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 53);
				break;
			case 7:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh006_sly, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh006_sly_loop, DirectionManager.MOVIE.ksh006_sly, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S1395, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0511, Sound.CH.SE1, true, 1f, 113);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC1, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, true, 1f, 242);
				break;
			case 8:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh003_chp, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh003_chp_loop, DirectionManager.MOVIE.ksh003_chp, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0512, Sound.CH.SE1, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S1442, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0513, Sound.CH.SE0, true, 1f, 109);
				evt.eventPlaySound(DirectionManager.SOUND.S0514, Sound.CH.SE1, true, 1f, 141);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 158);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC1, true, 1f, 159);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, true, 1f, 258);
				break;
			case 9:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh005_mil, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh005_mil_loop, DirectionManager.MOVIE.ksh005_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0515, Sound.CH.SE1, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S1492, Sound.CH.VC0, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S0516, Sound.CH.SE0, true, 1f, 148);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 162);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC1, true, 1f, 164);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, true, 1f, 234);
				break;
			case 10:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh002_bri, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh002_bri_loop, DirectionManager.MOVIE.ksh002_bri, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S1544, Sound.CH.VC0, true, 1f, 96);
				evt.eventPlaySound(DirectionManager.SOUND.S0517, Sound.CH.SE1, true, 1f, 106);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 148);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC1, true, 1f, 164);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, true, 1f, 240);
				break;
			case 11:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh007_zap_loop, DirectionManager.MOVIE.ksh007_zap, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 94);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 139);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 151);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 198);
				break;
			case 12:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh001_ano_loop, DirectionManager.MOVIE.ksh001_ano, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 88);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 157);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 165);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 250);
				break;
			case 13:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004g, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004g_loop, DirectionManager.MOVIE.kho004g, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0117, Sound.CH.SE0, false, 1f, 53);
				break;
			case 14:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004d, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004d_loop, DirectionManager.MOVIE.kho004d, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0215, Sound.CH.SE0, true, 1f, 29);
				break;
			case 15:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002a_blue, DirectionManager.MOVIE.kho001, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002a_blue_loop, DirectionManager.MOVIE.kho002a_blue, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0866, Sound.CH.VC0, true, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0535, Sound.CH.SE0, true, 1f, 27);
				break;
			case 16:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004a, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004a_loop, DirectionManager.MOVIE.kho004a, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0118, Sound.CH.SE0, false, 1f, 53);
				break;
			case 17:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004j, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004j_loop, DirectionManager.MOVIE.kho004j, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 53);
				break;
			case 18:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004k, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004k_loop, DirectionManager.MOVIE.kho004k, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 53);
				break;
			case 19:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004l, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004l_loop, DirectionManager.MOVIE.kho004l, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 53);
				break;
			case 20:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004m, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004m_loop, DirectionManager.MOVIE.kho004m, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 53);
				break;
			case 21:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh006_sly, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh006_sly_loop, DirectionManager.MOVIE.ksh006_sly, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S1395, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0511, Sound.CH.SE1, true, 1f, 113);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC1, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, true, 1f, 242);
				break;
			case 22:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh003_chp, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh003_chp_loop, DirectionManager.MOVIE.ksh003_chp, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0512, Sound.CH.SE1, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S1442, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0513, Sound.CH.SE0, true, 1f, 109);
				evt.eventPlaySound(DirectionManager.SOUND.S0514, Sound.CH.SE1, true, 1f, 141);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 158);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC1, true, 1f, 159);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, true, 1f, 258);
				break;
			case 23:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh005_mil, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh005_mil_loop, DirectionManager.MOVIE.ksh005_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0515, Sound.CH.SE1, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S1492, Sound.CH.VC0, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S0516, Sound.CH.SE0, true, 1f, 148);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 162);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC1, true, 1f, 164);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, true, 1f, 234);
				break;
			case 24:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh002_bri, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh002_bri_loop, DirectionManager.MOVIE.ksh002_bri, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S1544, Sound.CH.VC0, true, 1f, 96);
				evt.eventPlaySound(DirectionManager.SOUND.S0517, Sound.CH.SE1, true, 1f, 106);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 148);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC1, true, 1f, 164);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, true, 1f, 240);
				break;
			case 25:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh007_zap_loop, DirectionManager.MOVIE.ksh007_zap, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 94);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 139);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 151);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 198);
				break;
			case 26:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh001_ano_loop, DirectionManager.MOVIE.ksh001_ano, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 88);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 157);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 165);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 250);
				break;
			case 27:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004g, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004g_loop, DirectionManager.MOVIE.kho004g, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0117, Sound.CH.SE0, false, 1f, 53);
				break;
			case 28:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004d, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004d_loop, DirectionManager.MOVIE.kho004d, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0215, Sound.CH.SE0, true, 1f, 29);
				break;
			case 29:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002a_yellow, DirectionManager.MOVIE.kho001, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002a_yellow_loop, DirectionManager.MOVIE.kho002a_yellow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0866, Sound.CH.VC0, true, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0535, Sound.CH.SE0, true, 1f, 27);
				break;
			case 30:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004a, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004a_loop, DirectionManager.MOVIE.kho004a, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0118, Sound.CH.SE0, false, 1f, 53);
				break;
			case 31:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004j, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004j_loop, DirectionManager.MOVIE.kho004j, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 53);
				break;
			case 32:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004k, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004k_loop, DirectionManager.MOVIE.kho004k, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 53);
				break;
			case 33:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004l, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004l_loop, DirectionManager.MOVIE.kho004l, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 53);
				break;
			case 34:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004m, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004m_loop, DirectionManager.MOVIE.kho004m, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 53);
				break;
			case 35:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh006_sly, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh006_sly_loop, DirectionManager.MOVIE.ksh006_sly, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S1395, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0511, Sound.CH.SE1, true, 1f, 113);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC1, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, true, 1f, 242);
				break;
			case 36:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh003_chp, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh003_chp_loop, DirectionManager.MOVIE.ksh003_chp, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0512, Sound.CH.SE1, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S1442, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0513, Sound.CH.SE0, true, 1f, 109);
				evt.eventPlaySound(DirectionManager.SOUND.S0514, Sound.CH.SE1, true, 1f, 141);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 158);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC1, true, 1f, 159);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, true, 1f, 258);
				break;
			case 37:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh005_mil, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh005_mil_loop, DirectionManager.MOVIE.ksh005_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0515, Sound.CH.SE1, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S1492, Sound.CH.VC0, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S0516, Sound.CH.SE0, true, 1f, 148);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 162);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC1, true, 1f, 164);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, true, 1f, 234);
				break;
			case 38:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh002_bri, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh002_bri_loop, DirectionManager.MOVIE.ksh002_bri, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S1544, Sound.CH.VC0, true, 1f, 96);
				evt.eventPlaySound(DirectionManager.SOUND.S0517, Sound.CH.SE1, true, 1f, 106);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 148);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC1, true, 1f, 164);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, true, 1f, 240);
				break;
			case 39:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh007_zap_loop, DirectionManager.MOVIE.ksh007_zap, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 94);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 139);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 151);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 198);
				break;
			case 40:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh001_ano_loop, DirectionManager.MOVIE.ksh001_ano, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 88);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 157);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 165);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 250);
				break;
			case 41:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004g, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004g_loop, DirectionManager.MOVIE.kho004g, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0117, Sound.CH.SE0, false, 1f, 53);
				break;
			case 42:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004d, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004d_loop, DirectionManager.MOVIE.kho004d, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0215, Sound.CH.SE0, true, 1f, 29);
				break;
			case 43:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002a_green, DirectionManager.MOVIE.kho001, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002a_green_loop, DirectionManager.MOVIE.kho002a_green, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0866, Sound.CH.VC0, true, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0535, Sound.CH.SE0, true, 1f, 27);
				break;
			case 44:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004a, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004a_loop, DirectionManager.MOVIE.kho004a, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0118, Sound.CH.SE0, false, 1f, 53);
				break;
			case 45:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004j, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004j_loop, DirectionManager.MOVIE.kho004j, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 53);
				break;
			case 46:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004k, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004k_loop, DirectionManager.MOVIE.kho004k, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 53);
				break;
			case 47:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004l, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004l_loop, DirectionManager.MOVIE.kho004l, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 53);
				break;
			case 48:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004m, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004m_loop, DirectionManager.MOVIE.kho004m, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 53);
				break;
			case 49:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh006_sly, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh006_sly_loop, DirectionManager.MOVIE.ksh006_sly, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S1395, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0511, Sound.CH.SE1, true, 1f, 113);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC1, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, true, 1f, 242);
				break;
			case 50:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh003_chp, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh003_chp_loop, DirectionManager.MOVIE.ksh003_chp, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0512, Sound.CH.SE1, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S1442, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0513, Sound.CH.SE0, true, 1f, 109);
				evt.eventPlaySound(DirectionManager.SOUND.S0514, Sound.CH.SE1, true, 1f, 141);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 158);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC1, true, 1f, 159);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, true, 1f, 258);
				break;
			case 51:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh005_mil, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh005_mil_loop, DirectionManager.MOVIE.ksh005_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0515, Sound.CH.SE1, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S1492, Sound.CH.VC0, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S0516, Sound.CH.SE0, true, 1f, 148);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 162);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC1, true, 1f, 164);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, true, 1f, 234);
				break;
			case 52:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh002_bri, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh002_bri_loop, DirectionManager.MOVIE.ksh002_bri, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S1544, Sound.CH.VC0, true, 1f, 96);
				evt.eventPlaySound(DirectionManager.SOUND.S0517, Sound.CH.SE1, true, 1f, 106);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 148);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC1, true, 1f, 164);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, true, 1f, 240);
				break;
			case 53:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh007_zap_loop, DirectionManager.MOVIE.ksh007_zap, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 94);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 139);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 151);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 198);
				break;
			case 54:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh001_ano_loop, DirectionManager.MOVIE.ksh001_ano, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 88);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 157);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 165);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 250);
				break;
			case 55:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004g, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004g_loop, DirectionManager.MOVIE.kho004g, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0117, Sound.CH.SE0, false, 1f, 53);
				break;
			case 56:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004d, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004d_loop, DirectionManager.MOVIE.kho004d, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0215, Sound.CH.SE0, true, 1f, 29);
				break;
			case 57:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002a_red, DirectionManager.MOVIE.kho001, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002a_red_loop, DirectionManager.MOVIE.kho002a_red, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0866, Sound.CH.VC0, true, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0535, Sound.CH.SE0, true, 1f, 27);
				break;
			case 58:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004a, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004a_loop, DirectionManager.MOVIE.kho004a, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0118, Sound.CH.SE0, false, 1f, 53);
				break;
			case 59:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004j, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004j_loop, DirectionManager.MOVIE.kho004j, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 53);
				break;
			case 60:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004k, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004k_loop, DirectionManager.MOVIE.kho004k, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 53);
				break;
			case 61:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004l, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004l_loop, DirectionManager.MOVIE.kho004l, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 53);
				break;
			case 62:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004m, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004m_loop, DirectionManager.MOVIE.kho004m, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 53);
				break;
			case 63:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh006_sly, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh006_sly_loop, DirectionManager.MOVIE.ksh006_sly, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S1395, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0511, Sound.CH.SE1, true, 1f, 113);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC1, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, true, 1f, 242);
				break;
			case 64:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh003_chp, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh003_chp_loop, DirectionManager.MOVIE.ksh003_chp, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0512, Sound.CH.SE1, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S1442, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0513, Sound.CH.SE0, true, 1f, 109);
				evt.eventPlaySound(DirectionManager.SOUND.S0514, Sound.CH.SE1, true, 1f, 141);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 158);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC1, true, 1f, 159);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, true, 1f, 258);
				break;
			case 65:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh005_mil, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh005_mil_loop, DirectionManager.MOVIE.ksh005_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0515, Sound.CH.SE1, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S1492, Sound.CH.VC0, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S0516, Sound.CH.SE0, true, 1f, 148);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 162);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC1, true, 1f, 164);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, true, 1f, 234);
				break;
			case 66:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh002_bri, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh002_bri_loop, DirectionManager.MOVIE.ksh002_bri, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S1544, Sound.CH.VC0, true, 1f, 96);
				evt.eventPlaySound(DirectionManager.SOUND.S0517, Sound.CH.SE1, true, 1f, 106);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 148);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC1, true, 1f, 164);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, true, 1f, 240);
				break;
			case 67:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh007_zap_loop, DirectionManager.MOVIE.ksh007_zap, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 94);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 139);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 151);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 198);
				break;
			case 68:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh001_ano_loop, DirectionManager.MOVIE.ksh001_ano, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 88);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 157);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 165);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 250);
				break;
			case 69:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004g, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004g_loop, DirectionManager.MOVIE.kho004g, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0117, Sound.CH.SE0, false, 1f, 53);
				break;
			case 70:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004d, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004d_loop, DirectionManager.MOVIE.kho004d, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0215, Sound.CH.SE0, true, 1f, 29);
				break;
			case 71:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002a_purple, DirectionManager.MOVIE.kho001, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002a_purple_loop, DirectionManager.MOVIE.kho002a_purple, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0866, Sound.CH.VC0, true, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0535, Sound.CH.SE0, true, 1f, 27);
				break;
			case 72:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004a, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004a_loop, DirectionManager.MOVIE.kho004a, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0118, Sound.CH.SE0, false, 1f, 53);
				break;
			case 73:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004j, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004j_loop, DirectionManager.MOVIE.kho004j, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 53);
				break;
			case 74:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004k, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004k_loop, DirectionManager.MOVIE.kho004k, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 53);
				break;
			case 75:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004l, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004l_loop, DirectionManager.MOVIE.kho004l, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 53);
				break;
			case 76:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004m, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004m_loop, DirectionManager.MOVIE.kho004m, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.SE0, false, 1f, 53);
				break;
			case 77:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh006_sly, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh006_sly_loop, DirectionManager.MOVIE.ksh006_sly, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S1395, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0511, Sound.CH.SE1, true, 1f, 113);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC1, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, true, 1f, 242);
				break;
			case 78:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh003_chp, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh003_chp_loop, DirectionManager.MOVIE.ksh003_chp, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0512, Sound.CH.SE1, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S1442, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0513, Sound.CH.SE0, true, 1f, 109);
				evt.eventPlaySound(DirectionManager.SOUND.S0514, Sound.CH.SE1, true, 1f, 141);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 158);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC1, true, 1f, 159);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, true, 1f, 258);
				break;
			case 79:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh005_mil, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh005_mil_loop, DirectionManager.MOVIE.ksh005_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0515, Sound.CH.SE1, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S1492, Sound.CH.VC0, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S0516, Sound.CH.SE0, true, 1f, 148);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 162);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC1, true, 1f, 164);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, true, 1f, 234);
				break;
			case 80:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh002_bri, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh002_bri_loop, DirectionManager.MOVIE.ksh002_bri, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S1544, Sound.CH.VC0, true, 1f, 96);
				evt.eventPlaySound(DirectionManager.SOUND.S0517, Sound.CH.SE1, true, 1f, 106);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 148);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC1, true, 1f, 164);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, true, 1f, 240);
				break;
			case 81:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh007_zap_loop, DirectionManager.MOVIE.ksh007_zap, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 94);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 139);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 151);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 198);
				break;
			case 82:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh001_ano_loop, DirectionManager.MOVIE.ksh001_ano, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 88);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 157);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 165);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 250);
				break;
			case 83:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004g, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004g_loop, DirectionManager.MOVIE.kho004g, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0117, Sound.CH.SE0, false, 1f, 53);
				break;
			case 84:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004d, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004d_loop, DirectionManager.MOVIE.kho004d, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0215, Sound.CH.SE0, true, 1f, 29);
				break;
			case 85:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002a_rainbow, DirectionManager.MOVIE.kho001, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002a_rainbow_loop, DirectionManager.MOVIE.kho002a_rainbow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0866, Sound.CH.VC0, true, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0535, Sound.CH.SE0, true, 1f, 27);
				evt.eventPlaySound(DirectionManager.SOUND.S0217, Sound.CH.SE1, true, 1f, 27);
				break;
			case 86:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh001_ano_loop, DirectionManager.MOVIE.ksh001_ano, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 88);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 157);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 165);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 250);
				break;
			case 87:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004d, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004d_loop, DirectionManager.MOVIE.kho004d, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0215, Sound.CH.SE0, true, 1f, 29);
				break;
			case 88:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002b_white, DirectionManager.MOVIE.kho001, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002b_white_loop, DirectionManager.MOVIE.kho002b_white, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0866, Sound.CH.VC0, true, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0536, Sound.CH.SE0, true, 1f, 27);
				break;
			case 89:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002b_blue, DirectionManager.MOVIE.kho001, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002b_blue_loop, DirectionManager.MOVIE.kho002b_blue, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0866, Sound.CH.VC0, true, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0536, Sound.CH.SE0, true, 1f, 27);
				break;
			case 90:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002b_yellow, DirectionManager.MOVIE.kho001, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002b_yellow_loop, DirectionManager.MOVIE.kho002b_yellow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0866, Sound.CH.VC0, true, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0536, Sound.CH.SE0, true, 1f, 27);
				break;
			case 91:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002b_green, DirectionManager.MOVIE.kho001, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002b_green_loop, DirectionManager.MOVIE.kho002b_green, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0866, Sound.CH.VC0, true, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0536, Sound.CH.SE0, true, 1f, 27);
				break;
			case 92:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002b_red, DirectionManager.MOVIE.kho001, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002b_red_loop, DirectionManager.MOVIE.kho002b_red, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0866, Sound.CH.VC0, true, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0536, Sound.CH.SE0, true, 1f, 27);
				break;
			case 93:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002b_purple, DirectionManager.MOVIE.kho001, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002b_purple_loop, DirectionManager.MOVIE.kho002b_purple, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0866, Sound.CH.VC0, true, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0536, Sound.CH.SE0, true, 1f, 27);
				break;
			case 94:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002b_rainbow, DirectionManager.MOVIE.kho001, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002b_rainbow_loop, DirectionManager.MOVIE.kho002b_rainbow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0866, Sound.CH.VC0, true, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0536, Sound.CH.SE0, true, 1f, 27);
				evt.eventPlaySound(DirectionManager.SOUND.S0217, Sound.CH.SE1, true, 1f, 27);
				break;
			case 95:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho001_loop, DirectionManager.MOVIE.kho001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0866, Sound.CH.VC0, true, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0534, Sound.CH.SE0, true, 1f, 4);
				break;
			case 96:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho002a_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002a_white_loop, DirectionManager.MOVIE.kho002a_white, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0535, Sound.CH.SE0, true, 1f, 0);
				break;
			case 97:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho002a_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002a_blue_loop, DirectionManager.MOVIE.kho002a_blue, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0535, Sound.CH.SE0, true, 1f, 0);
				break;
			case 98:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho002a_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002a_yellow_loop, DirectionManager.MOVIE.kho002a_yellow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0535, Sound.CH.SE0, true, 1f, 0);
				break;
			case 99:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho002a_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002a_green_loop, DirectionManager.MOVIE.kho002a_green, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0535, Sound.CH.SE0, true, 1f, 0);
				break;
			case 100:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho002a_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002a_red_loop, DirectionManager.MOVIE.kho002a_red, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0535, Sound.CH.SE0, true, 1f, 0);
				break;
			case 101:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho002a_purple, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002a_purple_loop, DirectionManager.MOVIE.kho002a_purple, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0535, Sound.CH.SE0, true, 1f, 0);
				break;
			case 102:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho002a_rainbow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002a_rainbow_loop, DirectionManager.MOVIE.kho002a_rainbow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0535, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0217, Sound.CH.SE1, true, 1f, 0);
				break;
			case 103:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho002b_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002b_white_loop, DirectionManager.MOVIE.kho002b_white, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0536, Sound.CH.SE0, true, 1f, 0);
				break;
			case 104:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho002b_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002b_blue_loop, DirectionManager.MOVIE.kho002b_blue, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0536, Sound.CH.SE0, true, 1f, 0);
				break;
			case 105:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho002b_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002b_yellow_loop, DirectionManager.MOVIE.kho002b_yellow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0536, Sound.CH.SE0, true, 1f, 0);
				break;
			case 106:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho002b_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002b_green_loop, DirectionManager.MOVIE.kho002b_green, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0536, Sound.CH.SE0, true, 1f, 0);
				break;
			case 107:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho002b_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002b_red_loop, DirectionManager.MOVIE.kho002b_red, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0536, Sound.CH.SE0, true, 1f, 0);
				break;
			case 108:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho002b_purple, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002b_purple_loop, DirectionManager.MOVIE.kho002b_purple, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0536, Sound.CH.SE0, true, 1f, 0);
				break;
			case 109:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho002b_rainbow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho002b_rainbow_loop, DirectionManager.MOVIE.kho002b_rainbow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0536, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0217, Sound.CH.SE1, true, 1f, 0);
				break;
			case 110:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004a, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004a_loop, DirectionManager.MOVIE.kho004a, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				break;
			case 111:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004j, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004j_loop, DirectionManager.MOVIE.kho004j, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				break;
			case 112:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004k, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004k_loop, DirectionManager.MOVIE.kho004k, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				break;
			case 113:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004l, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004l_loop, DirectionManager.MOVIE.kho004l, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				break;
			case 114:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004m, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004m_loop, DirectionManager.MOVIE.kho004m, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				break;
			case 115:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh006_sly, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh006_sly_loop, DirectionManager.MOVIE.ksh006_sly, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S1395, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0511, Sound.CH.SE1, true, 1f, 113);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC1, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, true, 1f, 242);
				break;
			case 116:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh003_chp, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh003_chp_loop, DirectionManager.MOVIE.ksh003_chp, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0512, Sound.CH.SE1, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S1442, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0513, Sound.CH.SE0, true, 1f, 109);
				evt.eventPlaySound(DirectionManager.SOUND.S0514, Sound.CH.SE1, true, 1f, 141);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 158);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC1, true, 1f, 159);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, true, 1f, 258);
				break;
			case 117:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh005_mil, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh005_mil_loop, DirectionManager.MOVIE.ksh005_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0515, Sound.CH.SE1, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S1492, Sound.CH.VC0, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S0516, Sound.CH.SE0, true, 1f, 148);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 162);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC1, true, 1f, 164);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, true, 1f, 234);
				break;
			case 118:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh002_bri, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh002_bri_loop, DirectionManager.MOVIE.ksh002_bri, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S1544, Sound.CH.VC0, true, 1f, 96);
				evt.eventPlaySound(DirectionManager.SOUND.S0517, Sound.CH.SE1, true, 1f, 106);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 148);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC1, true, 1f, 164);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, true, 1f, 240);
				break;
			case 119:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh007_zap_loop, DirectionManager.MOVIE.ksh007_zap, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 94);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 139);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 151);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 198);
				break;
			case 120:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004f, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 46);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh001_ano_loop, DirectionManager.MOVIE.ksh001_ano, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 88);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 157);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 165);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 250);
				break;
			case 121:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004g, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004g_loop, DirectionManager.MOVIE.kho004g, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0117, Sound.CH.SE0, false, 1f, 53);
				break;
			case 122:
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004d, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004d_loop, DirectionManager.MOVIE.kho004d, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0215, Sound.CH.SE0, true, 1f, 29);
				break;
			case 123:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE0, false, 1f, 20);
				break;
			case 124:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE0, false, 1f, 20);
				break;
			case 125:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE0, false, 1f, 20);
				break;
			case 126:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_761();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_763();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE0, false, 1f, 20);
				break;
			case 127:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_761();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_763();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE0, false, 1f, 20);
				break;
			case 128:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_761();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_763();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE0, false, 1f, 20);
				break;
			case 129:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_767();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_769();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE0, false, 1f, 20);
				break;
			case 130:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_767();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_769();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE0, false, 1f, 20);
				break;
			case 131:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_7, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_7_loop, DirectionManager.MOVIE.huc008_T_7, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0232, Sound.CH.SE0, false, 1f, 20);
				break;
			case 132:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE0, false, 1f, 20);
				break;
			case 133:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE0, false, 1f, 20);
				break;
			case 134:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE0, false, 1f, 20);
				break;
			case 135:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_761();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_763();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE0, false, 1f, 20);
				break;
			case 136:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_761();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_763();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE0, false, 1f, 20);
				break;
			case 137:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_761();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_763();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE0, false, 1f, 20);
				break;
			case 138:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_767();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_769();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE0, false, 1f, 20);
				break;
			case 139:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_767();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_769();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE0, false, 1f, 20);
				break;
			case 140:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_7, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_7_loop, DirectionManager.MOVIE.huc008_T_7, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0232, Sound.CH.SE0, false, 1f, 20);
				break;
			case 141:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE0, false, 1f, 20);
				break;
			case 142:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE0, false, 1f, 20);
				break;
			case 143:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE0, false, 1f, 20);
				break;
			case 144:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_761();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_763();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE0, false, 1f, 20);
				break;
			case 145:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_761();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_763();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE0, false, 1f, 20);
				break;
			case 146:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_761();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_763();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE0, false, 1f, 20);
				break;
			case 147:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_767();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_769();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE0, false, 1f, 20);
				break;
			case 148:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_767();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_769();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE0, false, 1f, 20);
				break;
			case 149:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_7, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_7_loop, DirectionManager.MOVIE.huc008_T_7, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0232, Sound.CH.SE0, false, 1f, 20);
				break;
			case 150:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE0, false, 1f, 20);
				break;
			case 151:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE0, false, 1f, 20);
				break;
			case 152:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE0, false, 1f, 20);
				break;
			case 153:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_761();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_763();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE0, false, 1f, 20);
				break;
			case 154:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_761();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_763();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE0, false, 1f, 20);
				break;
			case 155:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_761();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_763();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE0, false, 1f, 20);
				break;
			case 156:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_767();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_769();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE0, false, 1f, 20);
				break;
			case 157:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_767();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_769();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE0, false, 1f, 20);
				break;
			case 158:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_7, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_7_loop, DirectionManager.MOVIE.huc008_T_7, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0232, Sound.CH.SE0, false, 1f, 20);
				break;
			case 159:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE0, false, 1f, 20);
				break;
			case 160:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE0, false, 1f, 20);
				break;
			case 161:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE0, false, 1f, 20);
				break;
			case 162:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_761();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_763();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE0, false, 1f, 20);
				break;
			case 163:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_761();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_763();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE0, false, 1f, 20);
				break;
			case 164:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_761();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_763();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE0, false, 1f, 20);
				break;
			case 165:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_767();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_769();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE0, false, 1f, 20);
				break;
			case 166:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_767();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_769();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE0, false, 1f, 20);
				break;
			case 167:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_7, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_7_loop, DirectionManager.MOVIE.huc008_T_7, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0232, Sound.CH.SE0, false, 1f, 20);
				break;
			case 168:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE0, false, 1f, 20);
				break;
			case 169:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE0, false, 1f, 20);
				break;
			case 170:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE0, false, 1f, 20);
				break;
			case 171:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_761();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_763();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE0, false, 1f, 20);
				break;
			case 172:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_761();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_763();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE0, false, 1f, 20);
				break;
			case 173:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_761();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_763();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE0, false, 1f, 20);
				break;
			case 174:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_767();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_769();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE0, false, 1f, 20);
				break;
			case 175:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_767();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_769();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE0, false, 1f, 20);
				break;
			case 176:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_7, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_7_loop, DirectionManager.MOVIE.huc008_T_7, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0232, Sound.CH.SE0, false, 1f, 20);
				break;
			case 177:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE0, false, 1f, 20);
				break;
			case 178:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE0, false, 1f, 20);
				break;
			case 179:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE0, false, 1f, 20);
				break;
			case 180:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_761();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_763();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE0, false, 1f, 20);
				break;
			case 181:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_761();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_763();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE0, false, 1f, 20);
				break;
			case 182:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_761();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_763();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE0, false, 1f, 20);
				break;
			case 183:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_767();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_769();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE0, false, 1f, 20);
				break;
			case 184:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_767();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_769();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE0, false, 1f, 20);
				break;
			case 185:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_7, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_7_loop, DirectionManager.MOVIE.huc008_T_7, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0232, Sound.CH.SE0, false, 1f, 20);
				break;
			case 186:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE0, false, 1f, 20);
				break;
			case 187:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE0, false, 1f, 20);
				break;
			case 188:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE0, false, 1f, 20);
				break;
			case 189:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_761();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_763();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE0, false, 1f, 20);
				break;
			case 190:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_761();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_763();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE0, false, 1f, 20);
				break;
			case 191:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_761();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_763();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE0, false, 1f, 20);
				break;
			case 192:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_767();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_769();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE0, false, 1f, 20);
				break;
			case 193:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_767();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_769();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE0, false, 1f, 20);
				break;
			case 194:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_757();
				evt.eventPlayMovie(DirectionManager.MOVIE.kho003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kho004_game, DirectionManager.MOVIE.kho003, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0867, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0537, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_7, false, false, true, false, 0, 0, 99, 20);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_7_loop, DirectionManager.MOVIE.huc008_T_7, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0232, Sound.CH.SE0, false, 1f, 20);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.JG_KHO_start_white_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 2:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 3:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 4:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 5:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 6:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 7:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 8:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 9:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 10:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 11:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 12:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 13:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 14:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 15:
				DirectionLedManager.JG_KHO_start_blue_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 16:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 17:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 18:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 19:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 20:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 21:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 22:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 23:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 24:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 25:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 26:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 27:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 28:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 29:
				DirectionLedManager.JG_KHO_start_yellow_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 30:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 31:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 32:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 33:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 34:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 35:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 36:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 37:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 38:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 39:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 40:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 41:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 42:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 43:
				DirectionLedManager.JG_KHO_start_green_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 44:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 45:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 46:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 47:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 48:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 49:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 50:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 51:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 52:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 53:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 54:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 55:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 56:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 57:
				DirectionLedManager.JG_KHO_start_red_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 58:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 59:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 60:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 61:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 62:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 63:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 64:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 65:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 66:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 67:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 68:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 69:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 70:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 71:
				DirectionLedManager.JG_KHO_start_purple_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 72:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 73:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 74:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 75:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 76:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 77:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 78:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 79:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 80:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 81:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 82:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 83:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 84:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 85:
				DirectionLedManager.JG_KHO_start_rainbow_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 86:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 87:
				DirectionLedManager.LG_KHO_crash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 88:
				DirectionLedManager.JG_KHO_start_white_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 89:
				DirectionLedManager.JG_KHO_start_blue_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 90:
				DirectionLedManager.JG_KHO_start_yellow_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 91:
				DirectionLedManager.JG_KHO_start_green_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 92:
				DirectionLedManager.JG_KHO_start_red_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 93:
				DirectionLedManager.JG_KHO_start_purple_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 94:
				DirectionLedManager.JG_KHO_start_rainbow_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 95:
				DirectionLedManager.JG_KHO_start(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 96:
				DirectionLedManager.JG_KHO_white_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 97:
				DirectionLedManager.JG_KHO_blue_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 98:
				DirectionLedManager.JG_KHO_yellow_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 99:
				DirectionLedManager.JG_KHO_green_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 100:
				DirectionLedManager.JG_KHO_red_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 101:
				DirectionLedManager.JG_KHO_purple_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 102:
				DirectionLedManager.JG_KHO_rainbow_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 103:
				DirectionLedManager.JG_KHO_white_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 104:
				DirectionLedManager.JG_KHO_blue_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 105:
				DirectionLedManager.JG_KHO_yellow_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 106:
				DirectionLedManager.JG_KHO_green_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 107:
				DirectionLedManager.JG_KHO_red_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 108:
				DirectionLedManager.JG_KHO_purple_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 109:
				DirectionLedManager.JG_KHO_rainbow_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 110:
				break;
			case 111:
				break;
			case 112:
				break;
			case 113:
				break;
			case 114:
				break;
			case 115:
				break;
			case 116:
				break;
			case 117:
				break;
			case 118:
				break;
			case 119:
				break;
			case 120:
				break;
			case 121:
				break;
			case 122:
				break;
			case 123:
				break;
			case 124:
				break;
			case 125:
				break;
			case 126:
				break;
			case 127:
				break;
			case 128:
				break;
			case 129:
				break;
			case 130:
				break;
			case 131:
				break;
			case 132:
				break;
			case 133:
				break;
			case 134:
				break;
			case 135:
				break;
			case 136:
				break;
			case 137:
				break;
			case 138:
				break;
			case 139:
				break;
			case 140:
				break;
			case 141:
				break;
			case 142:
				break;
			case 143:
				break;
			case 144:
				break;
			case 145:
				break;
			case 146:
				break;
			case 147:
				break;
			case 148:
				break;
			case 149:
				break;
			case 150:
				break;
			case 151:
				break;
			case 152:
				break;
			case 153:
				break;
			case 154:
				break;
			case 155:
				break;
			case 156:
				break;
			case 157:
				break;
			case 158:
				break;
			case 159:
				break;
			case 160:
				break;
			case 161:
				break;
			case 162:
				break;
			case 163:
				break;
			case 164:
				break;
			case 165:
				break;
			case 166:
				break;
			case 167:
				break;
			case 168:
				break;
			case 169:
				break;
			case 170:
				break;
			case 171:
				break;
			case 172:
				break;
			case 173:
				break;
			case 174:
				break;
			case 175:
				break;
			case 176:
				break;
			case 177:
				break;
			case 178:
				break;
			case 179:
				break;
			case 180:
				break;
			case 181:
				break;
			case 182:
				break;
			case 183:
				break;
			case 184:
				break;
			case 185:
				break;
			case 186:
				break;
			case 187:
				break;
			case 188:
				break;
			case 189:
				break;
			case 190:
				break;
			case 191:
				break;
			case 192:
				break;
			case 193:
				break;
			case 194:
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
