public class Direction50HML : DirectionBase
{
	private int m_cnt;

	public Direction50HML(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		m_cnt = 0;
		restartBGM();
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_sol1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml1001_mil1, DirectionManager.MOVIE.hsl1001_sol1, true, false, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_sol2, false, false, false, true, 70, 72, 101, 111);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml1001_mil2, false, false, false, true, 192, 72, 102, 111);
				evt.eventPlaySound(DirectionManager.SOUND.S0141, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg2, false, false, false, false, 0, 0, 110, 110);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1001_bg2_loop, DirectionManager.MOVIE.hsl1001_bg2, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg_sdw, false, false, false, false, 0, 0, 90, 116);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg1, false, false, false, false, 0, 0, 80, 110);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1001_bg1_loop, DirectionManager.MOVIE.hsl1001_bg1, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg_add, false, false, true, false, 0, 0, 70, 124);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_sol1, false, false, false, false, 0, 0, 100, 30);
				evt.eventAddMovie(DirectionManager.MOVIE.hml1001_mil1, DirectionManager.MOVIE.hsl1001_sol1, true, false, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_sol2, false, false, false, true, 70, 72, 101, 141);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml1001_mil2, false, false, false, true, 192, 72, 102, 141);
				evt.eventPlaySound(DirectionManager.SOUND.S0141, Sound.CH.BGM, false, 1f, 29);
				evt.eventPlaySound(DirectionManager.SOUND.S0252, Sound.CH.SE0, true, 1f, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S0252, Sound.CH.SE1, true, 1f, 9);
				evt.eventPlaySound(DirectionManager.SOUND.S0235, Sound.CH.SE0, true, 1f, 26);
				evt.eventPlaySound(DirectionManager.SOUND.S0271, Sound.CH.SE1, true, 1f, 223);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg2, false, false, false, false, 0, 0, 110, 140);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1001_bg2_loop, DirectionManager.MOVIE.hsl1001_bg2, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg_sdw, false, false, false, false, 0, 0, 90, 146);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg1, false, false, false, false, 0, 0, 80, 140);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1001_bg1_loop, DirectionManager.MOVIE.hsl1001_bg1, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg_add, false, false, true, false, 0, 0, 70, 164);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_ss, true, false, false, false, 0, 0, 60, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_s, false, false, false, false, 0, 0, 51, 223);
				break;
			case 3:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2001_hai1, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0259, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1041, Sound.CH.VC0, true, 1f, 29);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2001_sol, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2001_sol1, DirectionManager.MOVIE.hsl2001_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2001_sol1_loop, DirectionManager.MOVIE.hsl2001_sol1, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml2001_mil, true, false, false, true, 206, 101, 80, 0);
				break;
			case 4:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml2004_mil, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2004_mil_loop, DirectionManager.MOVIE.hml2004_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0474, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0908, Sound.CH.VC0, true, 1f, 0);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml2005_mil, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2005_mil_loop, DirectionManager.MOVIE.hml2005_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0475, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0909, Sound.CH.VC0, true, 1f, 0);
				break;
			case 6:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2007_sol_hai1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml5007_mil1, DirectionManager.MOVIE.hsl2007_sol_hai1, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0476, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0910, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0265, Sound.CH.SE1, true, 1f, 42);
				evt.eventPlaySound(DirectionManager.SOUND.S1495, Sound.CH.VC1, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0610, Sound.CH.SE0, true, 1f, 56);
				evt.eventPlaySound(DirectionManager.SOUND.S0625, Sound.CH.SE1, true, 1f, 88);
				evt.eventPlaySound(DirectionManager.SOUND.S0626, Sound.CH.SE0, true, 1f, 118);
				evt.eventPlaySound(DirectionManager.SOUND.S1482, Sound.CH.VC0, true, 1f, 118);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_993();
				break;
			case 7:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1002_hai1, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml1002_mil, false, false, false, true, 195, 111, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1002_sol, false, false, false, true, 70, 72, 80, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1002_sol_loop, DirectionManager.MOVIE.hsl1002_sol, false, true, false, true);
				break;
			case 8:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2007_sol_hai1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2007_mil, DirectionManager.MOVIE.hsl2007_sol_hai1, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5010_hai1, DirectionManager.MOVIE.hml2007_mil, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 253);
				evt.eventPlaySound(DirectionManager.SOUND.S0476, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0910, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE1, true, 1f, 42);
				evt.eventPlaySound(DirectionManager.SOUND.S1483, Sound.CH.VC1, true, 1f, 48);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 77);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE1, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S0950, Sound.CH.VC0, true, 1f, 187);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE0, true, 1f, 248);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_sol, false, false, false, true, 60, 84, 90, 60);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add, false, false, true, false, 0, 0, 85, 60);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml5010_mil, false, false, false, false, 0, 0, 80, 60);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add2, false, false, true, false, 0, 0, 75, 60);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 70, 145);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 69, 145);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 9:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2008_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2008_mil, DirectionManager.MOVIE.hsl2008_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hml5007_mil1, DirectionManager.MOVIE.hml2008_mil, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0222, Sound.CH.SE1, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S0864, Sound.CH.VC0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S1494, Sound.CH.VC1, true, 1f, 145);
				evt.eventPlaySound(DirectionManager.SOUND.S0265, Sound.CH.SE1, true, 1f, 148);
				evt.eventPlaySound(DirectionManager.SOUND.S0610, Sound.CH.SE0, true, 1f, 162);
				evt.eventPlaySound(DirectionManager.SOUND.S0625, Sound.CH.SE1, true, 1f, 194);
				evt.eventPlaySound(DirectionManager.SOUND.S0626, Sound.CH.SE0, true, 1f, 224);
				evt.eventPlaySound(DirectionManager.SOUND.S1482, Sound.CH.VC0, true, 1f, 224);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1001();
				break;
			case 10:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2008_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2008_mil, DirectionManager.MOVIE.hsl2008_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5010_hai1, DirectionManager.MOVIE.hml2008_mil, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 359);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0222, Sound.CH.SE1, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S0864, Sound.CH.VC0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE1, true, 1f, 150);
				evt.eventPlaySound(DirectionManager.SOUND.S1483, Sound.CH.VC1, true, 1f, 156);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 183);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE1, true, 1f, 249);
				evt.eventPlaySound(DirectionManager.SOUND.S0950, Sound.CH.VC0, true, 1f, 293);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE0, true, 1f, 354);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_sol, false, false, false, true, 60, 84, 90, 146);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add, false, false, true, false, 0, 0, 85, 146);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml5010_mil, false, false, false, false, 0, 0, 80, 146);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add2, false, false, true, false, 0, 0, 75, 146);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 70, 231);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 69, 231);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 11:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2011_sol1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml5007_mil1, DirectionManager.MOVIE.hsl2011_sol1, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0916, Sound.CH.VC0, true, 1f, 24);
				evt.eventPlaySound(DirectionManager.SOUND.S0479, Sound.CH.SE1, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S1494, Sound.CH.VC1, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0265, Sound.CH.SE1, true, 1f, 88);
				evt.eventPlaySound(DirectionManager.SOUND.S0610, Sound.CH.SE0, true, 1f, 102);
				evt.eventPlaySound(DirectionManager.SOUND.S0625, Sound.CH.SE1, true, 1f, 134);
				evt.eventPlaySound(DirectionManager.SOUND.S0626, Sound.CH.SE0, true, 1f, 164);
				evt.eventPlaySound(DirectionManager.SOUND.S1482, Sound.CH.VC0, true, 1f, 164);
				break;
			case 12:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2011_sol1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2011_mil, DirectionManager.MOVIE.hsl2011_sol1, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5010_hai1, DirectionManager.MOVIE.hml2011_mil, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 324);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0916, Sound.CH.VC0, true, 1f, 24);
				evt.eventPlaySound(DirectionManager.SOUND.S0479, Sound.CH.SE1, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE1, true, 1f, 111);
				evt.eventPlaySound(DirectionManager.SOUND.S1483, Sound.CH.VC1, true, 1f, 117);
				evt.eventPlaySound(DirectionManager.SOUND.S0491, Sound.CH.SE0, true, 1f, 135);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, false, 1f, 148);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE0, true, 1f, 214);
				evt.eventPlaySound(DirectionManager.SOUND.S0950, Sound.CH.VC0, true, 1f, 258);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE1, true, 1f, 319);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_sol, false, false, false, true, 60, 84, 90, 109);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add, false, false, true, false, 0, 0, 85, 109);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml5010_mil, false, false, false, false, 0, 0, 80, 109);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add2, false, false, true, false, 0, 0, 75, 109);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 70, 193);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 69, 193);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 13:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2011_sol1, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2011_mil, DirectionManager.MOVIE.hsl2011_sol1, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5010_hai1, DirectionManager.MOVIE.hml2011_mil, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 396);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0916, Sound.CH.VC0, true, 1f, 96);
				evt.eventPlaySound(DirectionManager.SOUND.S0479, Sound.CH.SE1, true, 1f, 117);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE1, true, 1f, 183);
				evt.eventPlaySound(DirectionManager.SOUND.S1483, Sound.CH.VC1, true, 1f, 189);
				evt.eventPlaySound(DirectionManager.SOUND.S0491, Sound.CH.SE0, true, 1f, 207);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, false, 1f, 220);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE0, true, 1f, 286);
				evt.eventPlaySound(DirectionManager.SOUND.S0950, Sound.CH.VC0, true, 1f, 330);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE1, true, 1f, 391);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_sol, false, false, false, true, 60, 84, 90, 179);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add, false, false, true, false, 0, 0, 85, 179);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml5010_mil, false, false, false, false, 0, 0, 80, 179);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add2, false, false, true, false, 0, 0, 75, 179);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 70, 264);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 69, 264);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 14:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml2012_mil, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2012_mil_loop, DirectionManager.MOVIE.hml2012_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0480, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0911, Sound.CH.VC0, true, 1f, 0);
				break;
			case 15:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml2013_mil, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml5009_mil1, DirectionManager.MOVIE.hml2013_mil, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0481, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0912, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0913, Sound.CH.VC1, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0914, Sound.CH.VC0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0613, Sound.CH.SE1, true, 1f, 109);
				evt.eventPlaySound(DirectionManager.SOUND.S0626, Sound.CH.SE0, true, 1f, 139);
				evt.eventPlaySound(DirectionManager.SOUND.S1482, Sound.CH.VC1, true, 1f, 139);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5009_sol, true, false, false, true, 100, 72, 79, 71);
				break;
			case 16:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml2013_mil, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5013_hai1, DirectionManager.MOVIE.hml2013_mil, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 279);
				evt.eventPlaySound(DirectionManager.SOUND.S0481, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0912, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0913, Sound.CH.VC1, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0914, Sound.CH.VC0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE1, true, 1f, 104);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE0, true, 1f, 170);
				evt.eventPlaySound(DirectionManager.SOUND.S0950, Sound.CH.VC1, true, 1f, 213);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE1, true, 1f, 274);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5013_sol, false, false, false, true, 100, 72, 89, 61);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml5013_mil, false, false, false, false, 0, 0, 90, 61);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 80, 146);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 75, 146);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 17:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml2015_mil, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml5009_mil1, DirectionManager.MOVIE.hml2015_mil, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0482, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0912, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0913, Sound.CH.VC1, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0908, Sound.CH.VC0, true, 1f, 26);
				evt.eventPlaySound(DirectionManager.SOUND.S1027, Sound.CH.VC1, true, 1f, 39);
				evt.eventPlaySound(DirectionManager.SOUND.S0866, Sound.CH.VC0, true, 1f, 52);
				evt.eventPlaySound(DirectionManager.SOUND.S0914, Sound.CH.VC1, true, 1f, 69);
				evt.eventPlaySound(DirectionManager.SOUND.S0613, Sound.CH.SE1, true, 1f, 148);
				evt.eventPlaySound(DirectionManager.SOUND.S0626, Sound.CH.SE0, true, 1f, 178);
				evt.eventPlaySound(DirectionManager.SOUND.S1482, Sound.CH.VC0, true, 1f, 178);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5009_sol, true, false, false, true, 100, 72, 79, 110);
				break;
			case 18:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml2015_mil, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5013_hai1, DirectionManager.MOVIE.hml2015_mil, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 318);
				evt.eventPlaySound(DirectionManager.SOUND.S0482, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0912, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0913, Sound.CH.VC1, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0908, Sound.CH.VC0, true, 1f, 26);
				evt.eventPlaySound(DirectionManager.SOUND.S1027, Sound.CH.VC1, true, 1f, 39);
				evt.eventPlaySound(DirectionManager.SOUND.S0866, Sound.CH.VC0, true, 1f, 52);
				evt.eventPlaySound(DirectionManager.SOUND.S0914, Sound.CH.VC1, true, 1f, 69);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE1, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE0, true, 1f, 209);
				evt.eventPlaySound(DirectionManager.SOUND.S0950, Sound.CH.VC0, true, 1f, 252);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE1, true, 1f, 313);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5013_sol, false, false, false, true, 100, 72, 89, 100);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml5013_mil, false, false, false, false, 0, 0, 90, 100);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 80, 185);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 75, 185);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 19:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2015_mil, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5013_hai1, DirectionManager.MOVIE.hml2015_mil, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 390);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0482, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0912, Sound.CH.VC0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0913, Sound.CH.VC1, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0908, Sound.CH.VC0, true, 1f, 98);
				evt.eventPlaySound(DirectionManager.SOUND.S1027, Sound.CH.VC1, true, 1f, 111);
				evt.eventPlaySound(DirectionManager.SOUND.S0866, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0914, Sound.CH.VC1, true, 1f, 141);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE1, true, 1f, 215);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE0, true, 1f, 281);
				evt.eventPlaySound(DirectionManager.SOUND.S0950, Sound.CH.VC0, true, 1f, 324);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE1, true, 1f, 385);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5013_sol, false, false, false, true, 100, 72, 89, 171);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml5013_mil, false, false, false, false, 0, 0, 90, 171);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 80, 256);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 75, 256);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 20:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2011_sol1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml5007_mil1, DirectionManager.MOVIE.hsl2011_sol1, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0479, Sound.CH.SE1, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S1043, Sound.CH.VC0, true, 1f, 56);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S1494, Sound.CH.VC1, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0265, Sound.CH.SE1, true, 1f, 88);
				evt.eventPlaySound(DirectionManager.SOUND.S0610, Sound.CH.SE0, true, 1f, 102);
				evt.eventPlaySound(DirectionManager.SOUND.S0625, Sound.CH.SE1, true, 1f, 134);
				evt.eventPlaySound(DirectionManager.SOUND.S0626, Sound.CH.SE0, true, 1f, 164);
				evt.eventPlaySound(DirectionManager.SOUND.S1482, Sound.CH.VC0, true, 1f, 164);
				break;
			case 21:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2011_sol1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2011_mil, DirectionManager.MOVIE.hsl2011_sol1, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5010_hai1, DirectionManager.MOVIE.hml2011_mil, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 336);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0479, Sound.CH.SE1, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S1043, Sound.CH.VC0, true, 1f, 56);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE1, true, 1f, 111);
				evt.eventPlaySound(DirectionManager.SOUND.S1483, Sound.CH.VC1, true, 1f, 117);
				evt.eventPlaySound(DirectionManager.SOUND.S0491, Sound.CH.SE0, true, 1f, 139);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, false, 1f, 152);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE0, true, 1f, 218);
				evt.eventPlaySound(DirectionManager.SOUND.S0950, Sound.CH.VC0, true, 1f, 262);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE1, true, 1f, 323);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_sol, false, false, false, true, 60, 84, 90, 109);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add, false, false, true, false, 0, 0, 85, 109);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml5010_mil, false, false, false, false, 0, 0, 80, 109);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add2, false, false, true, false, 0, 0, 75, 109);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 70, 198);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 69, 198);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 22:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2011_sol3, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2020_sol, DirectionManager.MOVIE.hsl2011_sol3, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2020_mil, DirectionManager.MOVIE.hsl2020_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hml5009_mil1, DirectionManager.MOVIE.hml2020_mil, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0479, Sound.CH.SE1, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S1043, Sound.CH.VC0, true, 1f, 56);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0483, Sound.CH.SE1, true, 1f, 92);
				evt.eventPlaySound(DirectionManager.SOUND.S0907, Sound.CH.VC1, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S0914, Sound.CH.VC0, true, 1f, 136);
				evt.eventPlaySound(DirectionManager.SOUND.S0613, Sound.CH.SE0, true, 1f, 210);
				evt.eventPlaySound(DirectionManager.SOUND.S0626, Sound.CH.SE1, true, 1f, 240);
				evt.eventPlaySound(DirectionManager.SOUND.S1482, Sound.CH.VC1, true, 1f, 240);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5009_sol, true, false, false, true, 100, 72, 79, 176);
				break;
			case 23:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2011_sol3, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2020_sol, DirectionManager.MOVIE.hsl2011_sol3, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2020_mil, DirectionManager.MOVIE.hsl2020_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5013_hai1, DirectionManager.MOVIE.hml2020_mil, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 382);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0479, Sound.CH.SE1, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S1043, Sound.CH.VC0, true, 1f, 56);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0483, Sound.CH.SE1, true, 1f, 92);
				evt.eventPlaySound(DirectionManager.SOUND.S0907, Sound.CH.VC1, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S0914, Sound.CH.VC0, true, 1f, 136);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE0, true, 1f, 206);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE1, true, 1f, 272);
				evt.eventPlaySound(DirectionManager.SOUND.S0950, Sound.CH.VC1, true, 1f, 316);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE0, true, 1f, 377);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5013_sol, false, false, false, true, 100, 72, 89, 166);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml5013_mil, false, false, false, false, 0, 0, 90, 166);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 80, 251);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 75, 251);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 24:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2011_sol3, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2020_sol, DirectionManager.MOVIE.hsl2011_sol3, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2020_mil, DirectionManager.MOVIE.hsl2020_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5013_hai1, DirectionManager.MOVIE.hml2020_mil, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 454);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0479, Sound.CH.SE1, true, 1f, 117);
				evt.eventPlaySound(DirectionManager.SOUND.S1043, Sound.CH.VC0, true, 1f, 128);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0483, Sound.CH.SE1, true, 1f, 164);
				evt.eventPlaySound(DirectionManager.SOUND.S0907, Sound.CH.VC1, true, 1f, 182);
				evt.eventPlaySound(DirectionManager.SOUND.S0914, Sound.CH.VC0, true, 1f, 208);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE0, true, 1f, 278);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE1, true, 1f, 344);
				evt.eventPlaySound(DirectionManager.SOUND.S0950, Sound.CH.VC1, true, 1f, 388);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE0, true, 1f, 449);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5013_sol, false, false, false, true, 100, 72, 89, 238);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml5013_mil, false, false, false, false, 0, 0, 90, 238);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 80, 322);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 75, 322);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 25:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml2022_mil, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2022_mil_loop, DirectionManager.MOVIE.hml2022_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0484, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1031, Sound.CH.VC0, true, 1f, 0);
				break;
			case 26:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2023_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2023_mil, DirectionManager.MOVIE.hsl2023_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hml5007_mil1, DirectionManager.MOVIE.hml2023_mil, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0485, Sound.CH.SE1, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0887, Sound.CH.VC0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1494, Sound.CH.VC1, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S0265, Sound.CH.SE0, true, 1f, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0610, Sound.CH.SE1, true, 1f, 158);
				evt.eventPlaySound(DirectionManager.SOUND.S0625, Sound.CH.SE0, true, 1f, 190);
				evt.eventPlaySound(DirectionManager.SOUND.S0626, Sound.CH.SE1, true, 1f, 220);
				evt.eventPlaySound(DirectionManager.SOUND.S1482, Sound.CH.VC0, true, 1f, 220);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1045();
				break;
			case 27:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2023_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2023_mil, DirectionManager.MOVIE.hsl2023_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5010_hai1, DirectionManager.MOVIE.hml2023_mil, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 355);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0485, Sound.CH.SE1, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0887, Sound.CH.VC0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE0, true, 1f, 146);
				evt.eventPlaySound(DirectionManager.SOUND.S1483, Sound.CH.VC1, true, 1f, 152);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, false, 1f, 179);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE0, true, 1f, 245);
				evt.eventPlaySound(DirectionManager.SOUND.S0950, Sound.CH.VC0, true, 1f, 289);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE1, true, 1f, 350);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_sol, false, false, false, true, 60, 84, 90, 144);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add, false, false, true, false, 0, 0, 85, 144);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml5010_mil, false, false, false, false, 0, 0, 80, 144);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add2, false, false, true, false, 0, 0, 75, 144);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 70, 225);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 69, 225);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 28:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2023_sol, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2023_mil, DirectionManager.MOVIE.hsl2023_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5010_hai1, DirectionManager.MOVIE.hml2023_mil, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 427);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0485, Sound.CH.SE1, true, 1f, 102);
				evt.eventPlaySound(DirectionManager.SOUND.S0887, Sound.CH.VC0, true, 1f, 104);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE0, true, 1f, 218);
				evt.eventPlaySound(DirectionManager.SOUND.S1483, Sound.CH.VC1, true, 1f, 224);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, true, 1f, 251);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE0, true, 1f, 317);
				evt.eventPlaySound(DirectionManager.SOUND.S0950, Sound.CH.VC0, true, 1f, 361);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE1, true, 1f, 422);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_sol, false, false, false, true, 60, 84, 90, 215);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add, false, false, true, false, 0, 0, 85, 215);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml5010_mil, false, false, false, false, 0, 0, 80, 215);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add2, false, false, true, false, 0, 0, 75, 215);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 70, 298);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 69, 298);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 29:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2026_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2026_mil, DirectionManager.MOVIE.hsl2026_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5010_hai1, DirectionManager.MOVIE.hml2026_mil, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 332);
				evt.eventPlaySound(DirectionManager.SOUND.S0244, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0487, Sound.CH.SE1, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S0934, Sound.CH.VC0, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE0, true, 1f, 119);
				evt.eventPlaySound(DirectionManager.SOUND.S1483, Sound.CH.VC1, true, 1f, 125);
				evt.eventPlaySound(DirectionManager.SOUND.S0491, Sound.CH.SE1, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, false, 1f, 156);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE1, true, 1f, 227);
				evt.eventPlaySound(DirectionManager.SOUND.S0951, Sound.CH.VC0, true, 1f, 271);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE0, true, 1f, 332);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5011_sol, false, false, false, true, 60, 72, 90, 135);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add, false, false, true, false, 0, 0, 85, 135);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml5010_mil, false, false, false, false, 0, 0, 80, 135);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add2, false, false, true, false, 0, 0, 75, 135);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 70, 220);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 69, 220);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 30:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2026_sol, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2026_mil, DirectionManager.MOVIE.hsl2026_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5010_hai1, DirectionManager.MOVIE.hml2026_mil, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 404);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0244, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0487, Sound.CH.SE1, true, 1f, 117);
				evt.eventPlaySound(DirectionManager.SOUND.S0934, Sound.CH.VC0, true, 1f, 117);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE0, true, 1f, 191);
				evt.eventPlaySound(DirectionManager.SOUND.S1483, Sound.CH.VC1, true, 1f, 197);
				evt.eventPlaySound(DirectionManager.SOUND.S0491, Sound.CH.SE1, true, 1f, 215);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, false, 1f, 228);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE1, true, 1f, 299);
				evt.eventPlaySound(DirectionManager.SOUND.S0951, Sound.CH.VC0, true, 1f, 343);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE0, true, 1f, 404);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5011_sol, false, false, false, true, 60, 72, 90, 206);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add, false, false, true, false, 0, 0, 85, 206);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml5010_mil, false, false, false, false, 0, 0, 80, 206);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add2, false, false, true, false, 0, 0, 75, 206);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 70, 291);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 69, 291);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 31:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2001_hai1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2001_hai1_kyo, DirectionManager.MOVIE.hsl2001_hai1, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0260, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1023, Sound.CH.VC0, true, 1f, 34);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2001_sol, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2001_sol2, DirectionManager.MOVIE.hsl2001_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2001_sol2_loop, DirectionManager.MOVIE.hsl2001_sol2, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml2001_mil, true, false, false, true, 206, 101, 80, 0);
				break;
			case 32:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml2002_mil1, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, true, false, true, 128, 119, 90, 9);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 33:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml2002_mil2, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2002_sol2, DirectionManager.MOVIE.hml2002_mil2, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2002_sol2_loop, DirectionManager.MOVIE.hsl2002_sol2, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0263, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0874, Sound.CH.SE1, true, 1f, 22);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 34:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl3001_hai1, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0261, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1485, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl3001_sol, true, false, false, true, 70, 72, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml3001_mil, false, false, false, true, 128, 72, 80, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl3001_add, false, false, true, false, 0, 0, 70, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl3001_add_loop, DirectionManager.MOVIE.hsl3001_add, false, true, true, false);
				break;
			case 35:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml3004_mil, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml3004_mil_loop, DirectionManager.MOVIE.hml3004_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0488, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1486, Sound.CH.VC0, true, 1f, 0);
				break;
			case 36:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml3005_mil, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml3005_mil_loop, DirectionManager.MOVIE.hml3005_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0489, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1487, Sound.CH.VC0, true, 1f, 0);
				break;
			case 37:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml3006_mil, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5002_hai1, DirectionManager.MOVIE.hml3006_mil, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0621, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1488, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0266, Sound.CH.SE1, true, 1f, 67);
				evt.eventPlaySound(DirectionManager.SOUND.S0491, Sound.CH.SE0, true, 1f, 75);
				evt.eventPlaySound(DirectionManager.SOUND.S0492, Sound.CH.SE1, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S0935, Sound.CH.VC0, true, 1f, 114);
				break;
			case 38:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml3006_mil, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5004_hai1, DirectionManager.MOVIE.hml3006_mil, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0200, Sound.CH.BGM, true, 1f, 164);
				evt.eventPlaySound(DirectionManager.SOUND.S0621, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1488, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0940, Sound.CH.VC1, true, 1f, 67);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, true, 1f, 73);
				evt.eventPlaySound(DirectionManager.SOUND.S0941, Sound.CH.VC0, true, 1f, 111);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5004_sol, false, false, false, false, 0, 0, 85, 66);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml5004_mil, false, false, false, false, 0, 0, 90, 66);
				break;
			case 39:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml3018_mil1, false, false, false, false, 0, 0, 90, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0621, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1488, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0490, Sound.CH.SE1, true, 1f, 50);
				evt.eventPlaySound(DirectionManager.SOUND.S0931, Sound.CH.VC1, true, 1f, 84);
				break;
			case 40:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml3008_mil, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml3008_sol, DirectionManager.MOVIE.hml3008_mil, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5002_hai1, DirectionManager.MOVIE.hml3008_sol, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0622, Sound.CH.SE1, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S1489, Sound.CH.VC1, true, 1f, 57);
				evt.eventPlaySound(DirectionManager.SOUND.S0939, Sound.CH.VC1, true, 1f, 129);
				evt.eventPlaySound(DirectionManager.SOUND.S0266, Sound.CH.SE0, true, 1f, 156);
				evt.eventPlaySound(DirectionManager.SOUND.S0492, Sound.CH.SE1, true, 1f, 187);
				evt.eventPlaySound(DirectionManager.SOUND.S1038, Sound.CH.VC0, true, 1f, 200);
				break;
			case 41:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml3008_mil, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml3008_sol, DirectionManager.MOVIE.hml3008_mil, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5004_hai1, DirectionManager.MOVIE.hml3008_sol, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 125);
				evt.eventPlaySound(DirectionManager.SOUND.S0200, Sound.CH.BGM, true, 1f, 253);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0622, Sound.CH.SE1, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S1489, Sound.CH.VC0, true, 1f, 57);
				evt.eventPlaySound(DirectionManager.SOUND.S0939, Sound.CH.VC1, true, 1f, 129);
				evt.eventPlaySound(DirectionManager.SOUND.S0940, Sound.CH.VC0, true, 1f, 156);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 162);
				evt.eventPlaySound(DirectionManager.SOUND.S0941, Sound.CH.VC1, true, 1f, 200);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5004_sol, false, false, false, false, 0, 0, 85, 154);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml5004_mil, false, false, false, false, 0, 0, 90, 154);
				break;
			case 42:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml3014_mil, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl3014_sly_loop, DirectionManager.MOVIE.hml3014_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0494, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1044, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0080, Sound.CH.SE0, false, 1f, 0);
				break;
			case 43:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml3011_mil1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml3011_mil1_loop, DirectionManager.MOVIE.hml3011_mil1, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0623, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1493, Sound.CH.VC0, true, 1f, 20);
				break;
			case 44:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml3011_mil2, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml3011_sol, DirectionManager.MOVIE.hml3011_mil2, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5002_hai1, DirectionManager.MOVIE.hml3011_sol, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0624, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1490, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0939, Sound.CH.VC1, true, 1f, 60);
				evt.eventPlaySound(DirectionManager.SOUND.S0266, Sound.CH.SE1, true, 1f, 90);
				evt.eventPlaySound(DirectionManager.SOUND.S0491, Sound.CH.SE0, true, 1f, 98);
				evt.eventPlaySound(DirectionManager.SOUND.S0492, Sound.CH.SE1, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S1037, Sound.CH.VC0, true, 1f, 124);
				break;
			case 45:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml3011_mil2, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml3011_sol, DirectionManager.MOVIE.hml3011_mil2, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5004_hai1, DirectionManager.MOVIE.hml3011_sol, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 90);
				evt.eventPlaySound(DirectionManager.SOUND.S0200, Sound.CH.BGM, true, 1f, 187);
				evt.eventPlaySound(DirectionManager.SOUND.S0624, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1490, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0939, Sound.CH.VC1, true, 1f, 60);
				evt.eventPlaySound(DirectionManager.SOUND.S0940, Sound.CH.VC0, true, 1f, 90);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, true, 1f, 96);
				evt.eventPlaySound(DirectionManager.SOUND.S0941, Sound.CH.VC0, true, 1f, 134);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5004_sol, false, false, false, false, 0, 0, 85, 88);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml5004_mil, false, false, false, false, 0, 0, 90, 88);
				break;
			case 46:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml3003_mil, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml3003_mil_loop, DirectionManager.MOVIE.hml3003_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0264, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1484, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 47:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl4001_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2012_mil, DirectionManager.MOVIE.hsl4001_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2012_mil_loop, DirectionManager.MOVIE.hml2012_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0480, Sound.CH.SE1, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0911, Sound.CH.VC1, true, 1f, 40);
				break;
			case 48:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl4001_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2022_mil, DirectionManager.MOVIE.hsl4001_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2022_mil_loop, DirectionManager.MOVIE.hml2022_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0484, Sound.CH.SE1, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S1031, Sound.CH.VC1, true, 1f, 40);
				break;
			case 49:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl4001_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2011_sol2, DirectionManager.MOVIE.hsl4001_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2011_sol2_loop, DirectionManager.MOVIE.hsl2011_sol2, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0478, Sound.CH.SE1, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S1042, Sound.CH.VC1, true, 1f, 40);
				break;
			case 50:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl4001_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2025_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2025_sol_loop, DirectionManager.MOVIE.hsl2025_sol, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0486, Sound.CH.SE1, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S1045, Sound.CH.VC1, true, 1f, 0);
				break;
			case 51:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl3001_hai1, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0261, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1491, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl3001_sol, true, false, false, true, 70, 72, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml3001_mil, false, false, false, true, 128, 72, 80, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl3001_add, false, false, true, false, 0, 0, 70, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl3001_add_loop, DirectionManager.MOVIE.hsl3001_add, false, true, true, false);
				break;
			case 52:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_sol1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hml1001_mil1, DirectionManager.MOVIE.hsl1001_sol1, true, false, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_sol2, false, false, false, true, 70, 72, 101, 111);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml1001_mil2, false, false, false, true, 192, 72, 102, 111);
				evt.eventPlaySound(DirectionManager.SOUND.S0141, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0271, Sound.CH.SE0, true, 1f, 204);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg2, false, false, false, false, 0, 0, 110, 110);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1001_bg2_loop, DirectionManager.MOVIE.hsl1001_bg2, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg_sdw, false, false, false, false, 0, 0, 90, 116);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg1, false, false, false, false, 0, 0, 80, 110);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1001_bg1_loop, DirectionManager.MOVIE.hsl1001_bg1, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg_add, false, false, true, false, 0, 0, 70, 124);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_s, false, false, false, false, 0, 0, 60, 204);
				break;
			case 53:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl4001_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2007_sol_hai1, DirectionManager.MOVIE.hsl4001_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hml5007_mil1, DirectionManager.MOVIE.hsl2007_sol_hai1, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0476, Sound.CH.SE0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0910, Sound.CH.VC1, true, 1f, 60);
				evt.eventPlaySound(DirectionManager.SOUND.S0265, Sound.CH.SE1, true, 1f, 63);
				evt.eventPlaySound(DirectionManager.SOUND.S1495, Sound.CH.VC0, true, 1f, 68);
				evt.eventPlaySound(DirectionManager.SOUND.S0610, Sound.CH.SE0, true, 1f, 77);
				evt.eventPlaySound(DirectionManager.SOUND.S0625, Sound.CH.SE1, true, 1f, 109);
				evt.eventPlaySound(DirectionManager.SOUND.S0626, Sound.CH.SE0, true, 1f, 139);
				evt.eventPlaySound(DirectionManager.SOUND.S1482, Sound.CH.VC1, true, 1f, 139);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_993();
				break;
			case 54:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl4001_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2007_sol_hai1, DirectionManager.MOVIE.hsl4001_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2007_mil, DirectionManager.MOVIE.hsl2007_sol_hai1, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5010_hai1, DirectionManager.MOVIE.hml2007_mil, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 293);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0476, Sound.CH.SE1, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0910, Sound.CH.VC1, true, 1f, 60);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE0, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S1483, Sound.CH.VC0, true, 1f, 88);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, true, 1f, 117);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE0, true, 1f, 183);
				evt.eventPlaySound(DirectionManager.SOUND.S0950, Sound.CH.VC1, true, 1f, 227);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE1, true, 1f, 288);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_sol, false, false, false, true, 60, 84, 90, 91);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add, false, false, true, false, 0, 0, 85, 91);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml5010_mil, false, false, false, false, 0, 0, 80, 91);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add2, false, false, true, false, 0, 0, 75, 91);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 70, 176);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 69, 176);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 55:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl4001_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2008_sol, DirectionManager.MOVIE.hsl4001_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2008_mil, DirectionManager.MOVIE.hsl2008_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hml5007_mil1, DirectionManager.MOVIE.hml2008_mil, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE1, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0222, Sound.CH.SE0, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0864, Sound.CH.VC1, true, 1f, 99);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE1, true, 1f, 173);
				evt.eventPlaySound(DirectionManager.SOUND.S1494, Sound.CH.VC0, true, 1f, 185);
				evt.eventPlaySound(DirectionManager.SOUND.S0265, Sound.CH.SE0, true, 1f, 188);
				evt.eventPlaySound(DirectionManager.SOUND.S0610, Sound.CH.SE1, true, 1f, 202);
				evt.eventPlaySound(DirectionManager.SOUND.S0625, Sound.CH.SE0, true, 1f, 234);
				evt.eventPlaySound(DirectionManager.SOUND.S0626, Sound.CH.SE1, true, 1f, 264);
				evt.eventPlaySound(DirectionManager.SOUND.S1482, Sound.CH.VC1, true, 1f, 264);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1001();
				break;
			case 56:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl4001_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2008_sol, DirectionManager.MOVIE.hsl4001_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2008_mil, DirectionManager.MOVIE.hsl2008_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5010_hai1, DirectionManager.MOVIE.hml2008_mil, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 399);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE1, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0222, Sound.CH.SE0, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0864, Sound.CH.VC1, true, 1f, 99);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE1, true, 1f, 173);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE0, true, 1f, 190);
				evt.eventPlaySound(DirectionManager.SOUND.S1483, Sound.CH.VC0, true, 1f, 196);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, true, 1f, 223);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE0, true, 1f, 289);
				evt.eventPlaySound(DirectionManager.SOUND.S0950, Sound.CH.VC1, true, 1f, 333);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE1, true, 1f, 394);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_sol, false, false, false, true, 60, 84, 90, 177);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add, false, false, true, false, 0, 0, 85, 177);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml5010_mil, false, false, false, false, 0, 0, 80, 177);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add2, false, false, true, false, 0, 0, 75, 177);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 70, 262);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 69, 262);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 57:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl4001_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2011_sol1, DirectionManager.MOVIE.hsl4001_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2011_mil, DirectionManager.MOVIE.hsl2011_sol1, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hml5007_mil1, DirectionManager.MOVIE.hml2011_mil, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE1, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0916, Sound.CH.VC1, true, 1f, 64);
				evt.eventPlaySound(DirectionManager.SOUND.S0479, Sound.CH.SE0, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE1, true, 1f, 112);
				evt.eventPlaySound(DirectionManager.SOUND.S1494, Sound.CH.VC0, true, 1f, 125);
				evt.eventPlaySound(DirectionManager.SOUND.S0265, Sound.CH.SE0, true, 1f, 128);
				evt.eventPlaySound(DirectionManager.SOUND.S0610, Sound.CH.SE1, true, 1f, 142);
				evt.eventPlaySound(DirectionManager.SOUND.S0625, Sound.CH.SE0, true, 1f, 174);
				evt.eventPlaySound(DirectionManager.SOUND.S0626, Sound.CH.SE1, true, 1f, 204);
				evt.eventPlaySound(DirectionManager.SOUND.S1482, Sound.CH.VC1, true, 1f, 204);
				break;
			case 58:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl4001_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2011_sol1, DirectionManager.MOVIE.hsl4001_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hml2011_mil, DirectionManager.MOVIE.hsl2011_sol1, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5010_hai1, DirectionManager.MOVIE.hml2011_mil, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 343);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE1, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0916, Sound.CH.VC1, true, 1f, 64);
				evt.eventPlaySound(DirectionManager.SOUND.S0479, Sound.CH.SE0, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE1, true, 1f, 112);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE0, true, 1f, 130);
				evt.eventPlaySound(DirectionManager.SOUND.S1483, Sound.CH.VC0, true, 1f, 136);
				evt.eventPlaySound(DirectionManager.SOUND.S0491, Sound.CH.SE1, true, 1f, 154);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, false, 1f, 167);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE1, true, 1f, 233);
				evt.eventPlaySound(DirectionManager.SOUND.S0950, Sound.CH.VC1, true, 1f, 277);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE0, true, 1f, 338);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_sol, false, false, false, true, 60, 84, 90, 137);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add, false, false, true, false, 0, 0, 85, 137);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml5010_mil, false, false, false, false, 0, 0, 80, 137);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add2, false, false, true, false, 0, 0, 75, 137);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 70, 222);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 69, 222);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 59:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_sol1, false, false, false, false, 0, 0, 100, 53);
				evt.eventAddMovie(DirectionManager.MOVIE.hml1001_mil1, DirectionManager.MOVIE.hsl1001_sol1, true, false, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_sol2, false, false, false, true, 70, 72, 101, 162);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml1001_mil2, false, false, false, true, 192, 72, 102, 162);
				evt.eventPlaySound(DirectionManager.SOUND.S0141, Sound.CH.BGM, false, 1f, 54);
				evt.eventPlaySound(DirectionManager.SOUND.S0252, Sound.CH.SE0, true, 1f, 26);
				evt.eventPlaySound(DirectionManager.SOUND.S0252, Sound.CH.SE1, true, 1f, 35);
				evt.eventPlaySound(DirectionManager.SOUND.S0235, Sound.CH.SE0, true, 1f, 51);
				evt.eventPlaySound(DirectionManager.SOUND.S0271, Sound.CH.SE1, true, 1f, 248);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg2, false, false, false, false, 0, 0, 110, 161);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1001_bg2_loop, DirectionManager.MOVIE.hsl1001_bg2, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg_sdw, false, false, false, false, 0, 0, 90, 164);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg1, false, false, false, false, 0, 0, 80, 161);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1001_bg1_loop, DirectionManager.MOVIE.hsl1001_bg1, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg_add, false, false, true, false, 0, 0, 70, 172);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy000_1, false, false, false, false, 0, 0, 60, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1001_ss, DirectionManager.MOVIE.ksy000_1, true, false, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_s, false, false, false, false, 0, 0, 51, 248);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.m_panel_HOH_ml_vs_01(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_5M));
				break;
			case 2:
				DirectionLedManager.JG_HOH_herecomes_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.YK_HOH_herecomes_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_HOH_ml_vs_02(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_5M));
				break;
			case 3:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.LG_HOH_sol_first_low_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 4:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_P(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 5:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_K(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 6:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_HS(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 7:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 8:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_HS(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 9:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_GF(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 10:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_GF(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 11:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_VV(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 12:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_VV(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 13:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_JYD_VV(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 14:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_H(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 15:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_DA_3(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 16:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_DA_3(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 17:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_DA_6(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 18:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_DA_6(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 19:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_JYD_DA_6(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 20:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_VV(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 21:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_VV(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 22:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_VV_K(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 23:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_VV_K(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 24:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_JYD_VV_K(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 25:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_U(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 26:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_TR(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 27:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_TR(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 28:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_JYD_TR(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 29:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_ND(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 30:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_JYD_ND(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 31:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.LG_HOH_sol_first_high_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 32:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 33:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.LG_HOH_sol_first_push(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 34:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 35:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HML_enm_P(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 36:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HML_enm_K(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 37:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HML_enm_HS(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 38:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.OFF_3(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.GD_HML_enm_HS(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 39:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_guard_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 40:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HML_enm_BM(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 41:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.OFF_3(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.GD_HML_enm_BM(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 42:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.YK_HOH_psych(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.DG_TEN_5_loop(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
				break;
			case 43:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 44:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HML_enm_WG(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 45:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.OFF_3(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.GD_HML_enm_WG(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 46:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 47:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_counter_H(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.LG_HOH_sol_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 48:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_counter_U(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.LG_HOH_sol_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 49:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.LG_HOH_sol_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 50:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.LG_HOH_sol_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_cutin_ND_ready(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 51:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 52:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.m_panel_HOH_ml_vs_01(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_5M));
				break;
			case 53:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_counter_HS(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.LG_HOH_sol_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 54:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_counter_HS(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.LG_HOH_sol_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 55:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_counter_GF(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.LG_HOH_sol_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 56:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_counter_GF(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.LG_HOH_sol_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 57:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_counter_VV(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.LG_HOH_sol_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 58:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_counter_VV(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.LG_HOH_sol_counter(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 59:
				DirectionLedManager.JG_HOH_herecomes_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
				DirectionLedManager.SE_KSY_close_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_KSY_HOH_close(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_HOH_herecomes_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_HOH_ml_vs_03(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_5M));
				break;
			}
		}
		dirWinChr();
		base.start();
	}

	public override void end()
	{
		base.end();
	}

	public override void control()
	{
		dirWinChr_led();
		base.control();
	}

	private void restartBGM()
	{
		if (low != 0)
		{
			return;
		}
		byte b = mode;
		if (b == 1 || b == 2 || b == 52 || b == 59)
		{
			return;
		}
		if (SGLG.sound.getBGMID() == 43)
		{
			if (SGLG.sound.getBGMVolume() < 1f)
			{
				evt.eventFadeSound(Sound.CH.BGM, 1f, 1f, 1, 0);
			}
		}
		else
		{
			evt.eventPlaySound(DirectionManager.SOUND.S0144, Sound.CH.BGM, false, 1f, 0);
		}
	}

	private void dirWinChr()
	{
		int num = MainGameScene.slotGameMan.get_pdt_data(24);
		int num2 = 0;
		switch (mode)
		{
		case 8:
			num2 = 100;
			break;
		case 10:
			num2 = 185;
			break;
		case 12:
			num2 = 128;
			break;
		case 13:
			num2 = 200;
			break;
		case 16:
			num2 = 100;
			break;
		case 18:
			num2 = 140;
			break;
		case 19:
			num2 = 210;
			break;
		case 21:
			num2 = 130;
			break;
		case 23:
			num2 = 200;
			break;
		case 24:
			num2 = 270;
			break;
		case 27:
			num2 = 180;
			break;
		case 28:
			num2 = 240;
			break;
		case 29:
			num2 = 175;
			break;
		case 30:
			num2 = 235;
			break;
		case 54:
			num2 = 130;
			break;
		case 56:
			num2 = 215;
			break;
		case 58:
			num2 = 175;
			break;
		default:
			return;
		}
		switch (num)
		{
		case 115:
			evt.eventPlayMovie(DirectionManager.MOVIE.hsl600_sla, true, false, false, false, 0, 0, 65, num2);
			evt.eventPlayMovie(DirectionManager.MOVIE.hsl600_sla_add, true, false, true, false, 0, 0, 64, num2);
			evt.eventPlaySound(DirectionManager.SOUND.S0254, Sound.CH.VC0, true, 1f, num2);
			evt.eventPlaySound(DirectionManager.SOUND.S1949, Sound.CH.VC1, true, 1f, num2 + 6);
			break;
		case 116:
			evt.eventPlayMovie(DirectionManager.MOVIE.hsl600_per, true, false, false, false, 0, 0, 65, num2);
			evt.eventPlayMovie(DirectionManager.MOVIE.hsl600_per_add, true, false, true, false, 0, 0, 64, num2);
			evt.eventPlaySound(DirectionManager.SOUND.S0255, Sound.CH.VC0, true, 1f, num2);
			evt.eventPlaySound(DirectionManager.SOUND.S1951, Sound.CH.VC1, true, 1f, num2 + 10);
			break;
		case 117:
			evt.eventPlayMovie(DirectionManager.MOVIE.hsl600_des, true, false, false, false, 0, 0, 65, num2);
			evt.eventPlayMovie(DirectionManager.MOVIE.hsl600_des_add, true, false, true, false, 0, 0, 64, num2);
			evt.eventPlaySound(DirectionManager.SOUND.S0256, Sound.CH.VC0, true, 1f, num2);
			evt.eventPlaySound(DirectionManager.SOUND.S1950, Sound.CH.VC1, true, 1f, num2 + 9);
			break;
		case 118:
			evt.eventPlayMovie(DirectionManager.MOVIE.hsl600_cle, true, false, false, false, 0, 0, 65, num2);
			evt.eventPlayMovie(DirectionManager.MOVIE.hsl600_cle_add, true, false, true, false, 0, 0, 64, num2);
			evt.eventPlaySound(DirectionManager.SOUND.S0257, Sound.CH.VC0, true, 1f, num2);
			evt.eventPlaySound(DirectionManager.SOUND.S1967, Sound.CH.VC1, true, 1f, num2 + 7);
			break;
		}
	}

	private void dirWinChr_led()
	{
		if (!evt.m_Active)
		{
			return;
		}
		int num = 0;
		switch (mode)
		{
		case 8:
			num = 100;
			break;
		case 10:
			num = 185;
			break;
		case 12:
			num = 128;
			break;
		case 13:
			num = 200;
			break;
		case 16:
			num = 100;
			break;
		case 18:
			num = 140;
			break;
		case 19:
			num = 210;
			break;
		case 21:
			num = 130;
			break;
		case 23:
			num = 200;
			break;
		case 24:
			num = 270;
			break;
		case 27:
			num = 180;
			break;
		case 28:
			num = 240;
			break;
		case 29:
			num = 175;
			break;
		case 30:
			num = 235;
			break;
		case 54:
			num = 130;
			break;
		case 56:
			num = 215;
			break;
		case 58:
			num = 175;
			break;
		default:
			return;
		}
		if (m_cnt == num)
		{
			switch (MainGameScene.slotGameMan.get_pdt_data(24))
			{
			case 115:
				DirectionPanelLED.runMac2App(2, 4);
				MainGameScene.slotGameMan.set_pdt_data(89, 2);
				MainGameScene.slotGameMan.m_dirData[89] = 2;
				break;
			case 116:
				DirectionPanelLED.runMac2App(2, 4);
				MainGameScene.slotGameMan.set_pdt_data(89, 2);
				MainGameScene.slotGameMan.m_dirData[89] = 2;
				break;
			case 117:
				DirectionPanelLED.runMac2App(2, 4);
				MainGameScene.slotGameMan.set_pdt_data(89, 2);
				MainGameScene.slotGameMan.m_dirData[89] = 2;
				break;
			case 118:
				DirectionPanelLED.runMac2App(2, 4);
				MainGameScene.slotGameMan.set_pdt_data(89, 2);
				MainGameScene.slotGameMan.m_dirData[89] = 2;
				break;
			}
		}
		m_cnt++;
	}
}
