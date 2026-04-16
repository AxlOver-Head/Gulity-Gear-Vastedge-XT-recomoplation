public class Direction64RIS : DirectionBase
{
	public Direction64RIS(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventPlayMovie(DirectionManager.MOVIE.ris001_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ris001_a_loop, DirectionManager.MOVIE.ris001_a, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0104, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1242, Sound.CH.SE0, true, 1f, 10);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ris002_a_1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ris002_a_1_loop, DirectionManager.MOVIE.ris002_a_1, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE1, true, 1f, 7);
				break;
			case 3:
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 47, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0881, Sound.CH.VC0, true, 1f, 3);
				break;
			case 4:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.riz003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.riz003_loop, DirectionManager.MOVIE.riz003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0106, Sound.CH.BGM, true, 1f, 121);
				evt.eventPlaySound(DirectionManager.SOUND.S0213, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0359, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1244, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1234, Sound.CH.VC1, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S1241, Sound.CH.VC0, true, 1f, 86);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ris005_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0213, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1244, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE1, true, 1f, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh006_sly, false, false, false, false, 0, 0, 99, 47);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh006_sly_loop, DirectionManager.MOVIE.ksh006_sly, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, true, 1f, 247);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 51);
				evt.eventPlaySound(DirectionManager.SOUND.S1395, Sound.CH.VC0, true, 1f, 100);
				evt.eventPlaySound(DirectionManager.SOUND.S0511, Sound.CH.SE1, true, 1f, 118);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 138);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC1, true, 1f, 148);
				break;
			case 6:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ris005_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0213, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1244, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE1, true, 1f, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh003_chp, false, false, false, false, 0, 0, 99, 47);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh003_chp_loop, DirectionManager.MOVIE.ksh003_chp, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, true, 1f, 263);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 51);
				evt.eventPlaySound(DirectionManager.SOUND.S0512, Sound.CH.SE1, true, 1f, 100);
				evt.eventPlaySound(DirectionManager.SOUND.S1442, Sound.CH.VC0, true, 1f, 100);
				evt.eventPlaySound(DirectionManager.SOUND.S0513, Sound.CH.SE0, true, 1f, 114);
				evt.eventPlaySound(DirectionManager.SOUND.S0514, Sound.CH.SE1, true, 1f, 146);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 163);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC1, true, 1f, 164);
				break;
			case 7:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ris005_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0213, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1244, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE1, true, 1f, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh005_mil, false, false, false, false, 0, 0, 99, 47);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh005_mil_loop, DirectionManager.MOVIE.ksh005_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, true, 1f, 239);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 51);
				evt.eventPlaySound(DirectionManager.SOUND.S0515, Sound.CH.SE1, true, 1f, 115);
				evt.eventPlaySound(DirectionManager.SOUND.S1492, Sound.CH.VC0, true, 1f, 115);
				evt.eventPlaySound(DirectionManager.SOUND.S0516, Sound.CH.SE0, true, 1f, 153);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 167);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC1, true, 1f, 169);
				break;
			case 8:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ris005_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0213, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1244, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE1, true, 1f, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh002_bri, false, false, false, false, 0, 0, 99, 47);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh002_bri_loop, DirectionManager.MOVIE.ksh002_bri, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, true, 1f, 245);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 51);
				evt.eventPlaySound(DirectionManager.SOUND.S1544, Sound.CH.VC0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S0517, Sound.CH.SE1, true, 1f, 111);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 153);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC1, true, 1f, 169);
				break;
			case 9:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ris005_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0213, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1244, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE1, true, 1f, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 99, 47);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh007_zap_loop, DirectionManager.MOVIE.ksh007_zap, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 203);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 51);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 99);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 156);
				break;
			case 10:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ris005_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0213, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1244, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE1, true, 1f, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh004_kai, false, false, false, false, 0, 0, 99, 47);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh004_kai_loop, DirectionManager.MOVIE.ksh004_kai, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0189, Sound.CH.BGM, true, 1f, 146);
				evt.eventPlaySound(DirectionManager.SOUND.S0519, Sound.CH.SE0, true, 1f, 54);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 102);
				evt.eventPlaySound(DirectionManager.SOUND.S1342, Sound.CH.VC0, true, 1f, 105);
				break;
			case 11:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ris005_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.riz004_b_2, DirectionManager.MOVIE.ris005_a, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0213, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1244, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE1, true, 1f, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 49);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh001_ano_loop, DirectionManager.MOVIE.ksh001_ano, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 255);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 255);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 51);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 93);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 115);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 162);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 170);
				break;
			case 12:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ris002_a_2, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ris002_a_2_loop, DirectionManager.MOVIE.ris002_a_2, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE1, true, 1f, 7);
				break;
			case 13:
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 47, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0881, Sound.CH.VC0, true, 1f, 3);
				break;
			case 14:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ris002_a_3, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ris002_a_3_loop, DirectionManager.MOVIE.ris002_a_3, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE1, true, 1f, 7);
				break;
			case 15:
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 47, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0881, Sound.CH.VC0, true, 1f, 3);
				break;
			case 16:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ris002_a_4, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ris002_a_4_loop, DirectionManager.MOVIE.ris002_a_4, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE1, true, 1f, 7);
				break;
			case 17:
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 47, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0881, Sound.CH.VC0, true, 1f, 3);
				break;
			case 18:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ris002_a_5, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ris002_a_5_loop, DirectionManager.MOVIE.ris002_a_5, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE1, true, 1f, 7);
				break;
			case 19:
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 47, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0881, Sound.CH.VC0, true, 1f, 3);
				break;
			case 20:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ris002_a_6, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ris002_a_6_loop, DirectionManager.MOVIE.ris002_a_6, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE1, true, 1f, 7);
				break;
			case 21:
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 47, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0881, Sound.CH.VC0, true, 1f, 3);
				break;
			case 22:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ris002_a_7, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ris002_a_7_loop, DirectionManager.MOVIE.ris002_a_7, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0217, Sound.CH.SE1, true, 1f, 9);
				break;
			case 23:
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 47, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0881, Sound.CH.VC0, true, 1f, 3);
				break;
			case 24:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ris002_a_8, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ris002_a_8_loop, DirectionManager.MOVIE.ris002_a_8, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0215, Sound.CH.SE1, true, 1f, 9);
				break;
			case 25:
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 47, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0881, Sound.CH.VC0, true, 1f, 3);
				break;
			case 26:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ris002_b_1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ris002_b_1_loop, DirectionManager.MOVIE.ris002_b_1, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0211, Sound.CH.SE1, true, 1f, 7);
				break;
			case 27:
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 73, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0882, Sound.CH.VC0, true, 1f, 3);
				break;
			case 28:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ris002_b_2, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ris002_b_2_loop, DirectionManager.MOVIE.ris002_b_2, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0211, Sound.CH.SE1, true, 1f, 7);
				break;
			case 29:
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 73, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0882, Sound.CH.VC0, true, 1f, 3);
				break;
			case 30:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ris002_b_3, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ris002_b_3_loop, DirectionManager.MOVIE.ris002_b_3, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0211, Sound.CH.SE1, true, 1f, 7);
				break;
			case 31:
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 73, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0882, Sound.CH.VC0, true, 1f, 3);
				break;
			case 32:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ris002_b_4, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ris002_b_4_loop, DirectionManager.MOVIE.ris002_b_4, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0211, Sound.CH.SE1, true, 1f, 7);
				break;
			case 33:
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 73, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0882, Sound.CH.VC0, true, 1f, 3);
				break;
			case 34:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ris002_b_5, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ris002_b_5_loop, DirectionManager.MOVIE.ris002_b_5, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0211, Sound.CH.SE1, true, 1f, 7);
				break;
			case 35:
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 73, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0882, Sound.CH.VC0, true, 1f, 3);
				break;
			case 36:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ris002_b_6, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ris002_b_6_loop, DirectionManager.MOVIE.ris002_b_6, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0211, Sound.CH.SE1, true, 1f, 7);
				break;
			case 37:
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 73, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0882, Sound.CH.VC0, true, 1f, 3);
				break;
			case 38:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ris002_b_7, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ris002_b_7_loop, DirectionManager.MOVIE.ris002_b_7, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0217, Sound.CH.SE1, true, 1f, 9);
				break;
			case 39:
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 73, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0882, Sound.CH.VC0, true, 1f, 3);
				break;
			case 40:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ris002_b_8, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ris002_b_8_loop, DirectionManager.MOVIE.ris002_b_8, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0394, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0215, Sound.CH.SE1, true, 1f, 9);
				break;
			case 41:
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 73, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S0882, Sound.CH.VC0, true, 1f, 3);
				break;
			case 42:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ris001_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ris001_b_loop, DirectionManager.MOVIE.ris001_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0198, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1243, Sound.CH.SE0, true, 1f, 14);
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
