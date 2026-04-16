public class Direction25ATH : DirectionBase
{
	public Direction25ATH(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001a_white_nml, false, false, false, false, 0, 0, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0539, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2012, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0540, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001a_white_loop_nml, false, true, false, false, 0, 0, 99, 25);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath002a_white_nml, false, false, false, false, 0, 0, 99, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE1, true, 1f, 46);
				break;
			case 3:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.anv027_char, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh006_sly, false, false, false, false, 0, 0, 99, 26);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh006_sly_loop, DirectionManager.MOVIE.ksh006_sly, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 26);
				evt.eventPlaySound(DirectionManager.SOUND.S1395, Sound.CH.VC0, true, 1f, 75);
				evt.eventPlaySound(DirectionManager.SOUND.S0511, Sound.CH.SE1, true, 1f, 93);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 113);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC1, true, 1f, 123);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, true, 1f, 222);
				break;
			case 4:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.anv027_char, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh003_chp, false, false, false, false, 0, 0, 99, 26);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh003_chp_loop, DirectionManager.MOVIE.ksh003_chp, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 26);
				evt.eventPlaySound(DirectionManager.SOUND.S0512, Sound.CH.SE1, true, 1f, 75);
				evt.eventPlaySound(DirectionManager.SOUND.S1442, Sound.CH.VC0, true, 1f, 75);
				evt.eventPlaySound(DirectionManager.SOUND.S0513, Sound.CH.SE0, true, 1f, 89);
				evt.eventPlaySound(DirectionManager.SOUND.S0514, Sound.CH.SE1, true, 1f, 121);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 138);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC1, true, 1f, 139);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, true, 1f, 238);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.anv027_char, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh005_mil, false, false, false, false, 0, 0, 99, 26);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh005_mil_loop, DirectionManager.MOVIE.ksh005_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 26);
				evt.eventPlaySound(DirectionManager.SOUND.S0515, Sound.CH.SE1, true, 1f, 90);
				evt.eventPlaySound(DirectionManager.SOUND.S1492, Sound.CH.VC0, true, 1f, 90);
				evt.eventPlaySound(DirectionManager.SOUND.S0516, Sound.CH.SE0, true, 1f, 129);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 142);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC1, true, 1f, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, true, 1f, 214);
				break;
			case 6:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.anv027_char, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh002_bri, false, false, false, false, 0, 0, 99, 26);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh002_bri_loop, DirectionManager.MOVIE.ksh002_bri, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 26);
				evt.eventPlaySound(DirectionManager.SOUND.S1544, Sound.CH.VC0, true, 1f, 76);
				evt.eventPlaySound(DirectionManager.SOUND.S0517, Sound.CH.SE1, true, 1f, 86);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 129);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC1, true, 1f, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, true, 1f, 220);
				break;
			case 7:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.anv027_char, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 99, 26);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh007_zap_loop, DirectionManager.MOVIE.ksh007_zap, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 26);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 74);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 119);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 131);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 178);
				break;
			case 8:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.anv027_ano, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 26);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh001_ano_loop, DirectionManager.MOVIE.ksh001_ano, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 26);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 68);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 90);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 137);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 145);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 230);
				break;
			case 9:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001a_blue, false, false, false, false, 0, 0, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0539, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2012, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0540, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001a_blue_loop, false, true, false, false, 0, 0, 99, 25);
				break;
			case 10:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath002a_blue, false, false, false, false, 0, 0, 99, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE1, true, 1f, 46);
				break;
			case 11:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001a_yellow, false, false, false, false, 0, 0, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0539, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2012, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0540, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001a_yellow_loop, false, true, false, false, 0, 0, 99, 25);
				break;
			case 12:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath002a_yellow, false, false, false, false, 0, 0, 99, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE1, true, 1f, 46);
				break;
			case 13:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001a_green, false, false, false, false, 0, 0, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0539, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2012, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0540, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001a_green_loop, false, true, false, false, 0, 0, 99, 25);
				break;
			case 14:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath002a_green, false, false, false, false, 0, 0, 99, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE1, true, 1f, 46);
				break;
			case 15:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001a_red, false, false, false, false, 0, 0, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0539, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2012, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0540, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001a_red_loop, false, true, false, false, 0, 0, 99, 25);
				break;
			case 16:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath002a_red, false, false, false, false, 0, 0, 99, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE1, true, 1f, 46);
				break;
			case 17:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001a_purple, false, false, false, false, 0, 0, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0539, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2012, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0540, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001a_purple_loop, false, true, false, false, 0, 0, 99, 25);
				break;
			case 18:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath002a_purple, false, false, false, false, 0, 0, 99, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE1, true, 1f, 46);
				break;
			case 19:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001a_tento, false, false, false, false, 0, 0, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0539, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2012, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0540, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001a_tento_loop, false, true, false, false, 0, 0, 99, 25);
				break;
			case 20:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath002a_tento, false, false, false, false, 0, 0, 99, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE1, true, 1f, 46);
				break;
			case 21:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001a_rainbow, false, false, false, false, 0, 0, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0539, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0217, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2012, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0540, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001a_rainbow_loop, false, true, false, false, 0, 0, 99, 25);
				break;
			case 22:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath002a_rainbow, false, false, false, false, 0, 0, 99, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE1, true, 1f, 46);
				break;
			case 23:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001b_white_nml, false, false, false, false, 0, 0, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0541, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2017, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE1, true, 1f, 25);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001b_white_loop_nml, false, true, false, false, 0, 0, 99, 46);
				break;
			case 24:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath002b_white_nml, false, false, false, false, 0, 0, 99, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, true, 1f, 53);
				break;
			case 25:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001b_blue, false, false, false, false, 0, 0, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0541, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2017, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE1, true, 1f, 25);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001b_blue_loop, false, true, false, false, 0, 0, 99, 46);
				break;
			case 26:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath002b_blue, false, false, false, false, 0, 0, 99, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, true, 1f, 53);
				break;
			case 27:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001b_yellow, false, false, false, false, 0, 0, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0541, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2017, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE1, true, 1f, 25);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001b_yellow_loop, false, true, false, false, 0, 0, 99, 46);
				break;
			case 28:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath002b_yellow, false, false, false, false, 0, 0, 99, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, true, 1f, 53);
				break;
			case 29:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001b_green, false, false, false, false, 0, 0, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0541, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2017, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE1, true, 1f, 25);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001b_green_loop, false, true, false, false, 0, 0, 99, 46);
				break;
			case 30:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath002b_green, false, false, false, false, 0, 0, 99, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, true, 1f, 53);
				break;
			case 31:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001b_red, false, false, false, false, 0, 0, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0541, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2017, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE1, true, 1f, 25);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001b_red_loop, false, true, false, false, 0, 0, 99, 46);
				break;
			case 32:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath002b_red, false, false, false, false, 0, 0, 99, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, true, 1f, 53);
				break;
			case 33:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001b_purple, false, false, false, false, 0, 0, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0541, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2017, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE1, true, 1f, 25);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001b_purple_loop, false, true, false, false, 0, 0, 99, 46);
				break;
			case 34:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath002b_purple, false, false, false, false, 0, 0, 99, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, true, 1f, 53);
				break;
			case 35:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001b_tento, false, false, false, false, 0, 0, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0541, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2017, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE1, true, 1f, 25);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001b_tento_loop, false, true, false, false, 0, 0, 99, 46);
				break;
			case 36:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath002b_tento, false, false, false, false, 0, 0, 99, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, true, 1f, 53);
				break;
			case 37:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001b_rainbow, false, false, false, false, 0, 0, 99, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0541, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2017, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE1, true, 1f, 25);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath001b_rainbow_loop, false, true, false, false, 0, 0, 99, 46);
				break;
			case 38:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ath002b_rainbow, false, false, false, false, 0, 0, 99, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2029, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, true, 1f, 53);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				break;
			case 2:
				break;
			case 3:
				break;
			case 4:
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
				break;
			case 16:
				break;
			case 17:
				break;
			case 18:
				break;
			case 19:
				break;
			case 20:
				break;
			case 21:
				break;
			case 22:
				break;
			case 23:
				break;
			case 24:
				break;
			case 25:
				break;
			case 26:
				break;
			case 27:
				break;
			case 28:
				break;
			case 29:
				break;
			case 30:
				break;
			case 31:
				break;
			case 32:
				break;
			case 33:
				break;
			case 34:
				break;
			case 35:
				break;
			case 36:
				break;
			case 37:
				break;
			case 38:
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
