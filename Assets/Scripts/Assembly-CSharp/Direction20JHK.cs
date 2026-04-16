public class Direction20JHK : DirectionBase
{
	public Direction20JHK(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk001_a_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk001_a_white_loop, DirectionManager.MOVIE.jhk001_a_white, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0539, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2011, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0540, Sound.CH.SE0, true, 1f, 20);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk002_a_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk002_a_white_loop, DirectionManager.MOVIE.jhk002_a_white, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE0, true, 1f, 40);
				break;
			case 3:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk003, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh006_sly, false, false, false, false, 0, 0, 90, 40);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh006_sly_loop, DirectionManager.MOVIE.ksh006_sly, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S1395, Sound.CH.VC0, true, 1f, 89);
				evt.eventPlaySound(DirectionManager.SOUND.S0511, Sound.CH.SE1, true, 1f, 107);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 127);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC1, true, 1f, 137);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, true, 1f, 236);
				break;
			case 4:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk003, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh003_chp, false, false, false, false, 0, 0, 90, 40);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh003_chp_loop, DirectionManager.MOVIE.ksh003_chp, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0512, Sound.CH.SE1, true, 1f, 89);
				evt.eventPlaySound(DirectionManager.SOUND.S1442, Sound.CH.VC0, true, 1f, 89);
				evt.eventPlaySound(DirectionManager.SOUND.S0513, Sound.CH.SE0, true, 1f, 103);
				evt.eventPlaySound(DirectionManager.SOUND.S0514, Sound.CH.SE1, true, 1f, 135);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 152);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC1, true, 1f, 153);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, true, 1f, 252);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk003, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh005_mil, false, false, false, false, 0, 0, 90, 40);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh005_mil_loop, DirectionManager.MOVIE.ksh005_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0515, Sound.CH.SE1, true, 1f, 104);
				evt.eventPlaySound(DirectionManager.SOUND.S1492, Sound.CH.VC0, true, 1f, 104);
				evt.eventPlaySound(DirectionManager.SOUND.S0516, Sound.CH.SE0, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 156);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC1, true, 1f, 158);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, true, 1f, 228);
				break;
			case 6:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk003, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh002_bri, false, false, false, false, 0, 0, 90, 40);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh002_bri_loop, DirectionManager.MOVIE.ksh002_bri, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S1544, Sound.CH.VC0, true, 1f, 90);
				evt.eventPlaySound(DirectionManager.SOUND.S0517, Sound.CH.SE1, true, 1f, 100);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC1, true, 1f, 158);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, true, 1f, 234);
				break;
			case 7:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk003, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 90, 40);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh007_zap_loop, DirectionManager.MOVIE.ksh007_zap, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 88);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 145);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 192);
				break;
			case 8:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk003, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 90, 40);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh001_ano_loop, DirectionManager.MOVIE.ksh001_ano, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 104);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 151);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 159);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 244);
				break;
			case 9:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk001_a_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk001_a_blue_loop, DirectionManager.MOVIE.jhk001_a_blue, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0539, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2011, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0540, Sound.CH.SE0, true, 1f, 20);
				break;
			case 10:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk002_a_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk002_a_blue_loop, DirectionManager.MOVIE.jhk002_a_blue, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE0, true, 1f, 40);
				break;
			case 11:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk001_a_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk001_a_yellow_loop, DirectionManager.MOVIE.jhk001_a_yellow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0539, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2011, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0540, Sound.CH.SE0, true, 1f, 20);
				break;
			case 12:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk002_a_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk002_a_yellow_loop, DirectionManager.MOVIE.jhk002_a_yellow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE0, true, 1f, 40);
				break;
			case 13:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk001_a_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk001_a_green_loop, DirectionManager.MOVIE.jhk001_a_green, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0539, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2011, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0540, Sound.CH.SE0, true, 1f, 20);
				break;
			case 14:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk002_a_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk002_a_green_loop, DirectionManager.MOVIE.jhk002_a_green, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE0, true, 1f, 40);
				break;
			case 15:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk001_a_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk001_a_red_loop, DirectionManager.MOVIE.jhk001_a_red, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0539, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2011, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0540, Sound.CH.SE0, true, 1f, 20);
				break;
			case 16:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk002_a_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk002_a_red_loop, DirectionManager.MOVIE.jhk002_a_red, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE0, true, 1f, 40);
				break;
			case 17:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk001_a_purple, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk001_a_purple_loop, DirectionManager.MOVIE.jhk001_a_purple, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0539, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2011, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0540, Sound.CH.SE0, true, 1f, 20);
				break;
			case 18:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk002_a_purple, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk002_a_purple_loop, DirectionManager.MOVIE.jhk002_a_purple, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE0, true, 1f, 40);
				break;
			case 19:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk001_a_tento, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk001_a_tento_loop, DirectionManager.MOVIE.jhk001_a_tento, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0539, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2011, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0540, Sound.CH.SE0, true, 1f, 20);
				break;
			case 20:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk002_a_tento, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk002_a_tento_loop, DirectionManager.MOVIE.jhk002_a_tento, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE0, true, 1f, 40);
				break;
			case 21:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk001_a_rainbow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk001_a_rainbow_loop, DirectionManager.MOVIE.jhk001_a_rainbow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0539, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2011, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0540, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0217, Sound.CH.SE1, true, 1f, 0);
				break;
			case 22:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk002_a_rainbow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk002_a_rainbow_loop, DirectionManager.MOVIE.jhk002_a_rainbow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE0, true, 1f, 40);
				break;
			case 23:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk001_b_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk001_b_white_loop, DirectionManager.MOVIE.jhk001_b_white, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0541, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2016, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 25);
				break;
			case 24:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk002_b_white, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk002_b_white_loop, DirectionManager.MOVIE.jhk002_b_white, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 53);
				break;
			case 25:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk001_b_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk001_b_blue_loop, DirectionManager.MOVIE.jhk001_b_blue, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0541, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2016, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 25);
				break;
			case 26:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk002_b_blue, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk002_b_blue_loop, DirectionManager.MOVIE.jhk002_b_blue, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 53);
				break;
			case 27:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk001_b_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk001_b_yellow_loop, DirectionManager.MOVIE.jhk001_b_yellow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0541, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2016, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 25);
				break;
			case 28:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk002_b_yellow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk002_b_yellow_loop, DirectionManager.MOVIE.jhk002_b_yellow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 53);
				break;
			case 29:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk001_b_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk001_b_green_loop, DirectionManager.MOVIE.jhk001_b_green, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0541, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2016, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 25);
				break;
			case 30:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk002_b_green, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk002_b_green_loop, DirectionManager.MOVIE.jhk002_b_green, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 53);
				break;
			case 31:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk001_b_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk001_b_red_loop, DirectionManager.MOVIE.jhk001_b_red, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0541, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2016, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 25);
				break;
			case 32:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk002_b_red, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk002_b_red_loop, DirectionManager.MOVIE.jhk002_b_red, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 53);
				break;
			case 33:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk001_b_purple, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk001_b_purple_loop, DirectionManager.MOVIE.jhk001_b_purple, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0541, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2016, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 25);
				break;
			case 34:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk002_b_purple, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk002_b_purple_loop, DirectionManager.MOVIE.jhk002_b_purple, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 53);
				break;
			case 35:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk001_b_tento, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk001_b_tento_loop, DirectionManager.MOVIE.jhk001_b_tento, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0541, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2016, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 25);
				break;
			case 36:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk002_b_tento, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk002_b_tento_loop, DirectionManager.MOVIE.jhk002_b_tento, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 53);
				break;
			case 37:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk001_b_rainbow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk001_b_rainbow_loop, DirectionManager.MOVIE.jhk001_b_rainbow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0541, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2016, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0542, Sound.CH.SE0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0217, Sound.CH.SE1, true, 1f, 0);
				break;
			case 38:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhk002_b_rainbow, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhk002_b_rainbow_loop, DirectionManager.MOVIE.jhk002_b_rainbow, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0543, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2028, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 53);
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
				DirectionLedManager.SE_common_kokuchi_10(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 22:
				break;
			case 23:
				DirectionLedManager.SE_JST_any_in(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 24:
				break;
			case 25:
				DirectionLedManager.SE_JST_any_in(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 26:
				break;
			case 27:
				DirectionLedManager.SE_JST_any_in(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 28:
				break;
			case 29:
				DirectionLedManager.SE_JST_any_in(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 30:
				break;
			case 31:
				DirectionLedManager.SE_JST_any_in(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 32:
				break;
			case 33:
				DirectionLedManager.SE_JST_any_in(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 34:
				break;
			case 35:
				DirectionLedManager.SE_JST_any_in(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 36:
				break;
			case 37:
				DirectionLedManager.SE_common_kokuchi_10(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
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
