public class Direction49HCP : DirectionBase
{
	private int m_cnt;

	public Direction49HCP(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventAddMovie(DirectionManager.MOVIE.hcp1001_chp1, DirectionManager.MOVIE.hsl1001_sol1, true, false, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_sol2, false, false, false, true, 70, 72, 101, 111);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp1001_chp2, false, false, false, true, 192, 72, 102, 111);
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
				evt.eventAddMovie(DirectionManager.MOVIE.hcp1001_chp1, DirectionManager.MOVIE.hsl1001_sol1, true, false, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_sol2, false, false, false, true, 70, 72, 101, 141);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp1001_chp2, false, false, false, true, 192, 72, 102, 141);
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
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp2001_chp, true, false, false, true, 192, 94, 80, 0);
				break;
			case 4:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp2004_chp, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2004_chp_loop, DirectionManager.MOVIE.hcp2004_chp, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0474, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0908, Sound.CH.VC0, true, 1f, 0);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp2005_chp, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2005_chp_loop, DirectionManager.MOVIE.hcp2005_chp, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0475, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0909, Sound.CH.VC0, true, 1f, 0);
				break;
			case 6:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2007_sol_hai1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp5007_chp1, DirectionManager.MOVIE.hsl2007_sol_hai1, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0476, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0910, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0265, Sound.CH.SE1, true, 1f, 41);
				evt.eventPlaySound(DirectionManager.SOUND.S1445, Sound.CH.VC0, true, 1f, 47);
				evt.eventPlaySound(DirectionManager.SOUND.S0610, Sound.CH.SE0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S0618, Sound.CH.SE1, true, 1f, 83);
				evt.eventPlaySound(DirectionManager.SOUND.S0619, Sound.CH.SE0, true, 1f, 105);
				evt.eventPlaySound(DirectionManager.SOUND.S0620, Sound.CH.SE1, true, 1f, 132);
				evt.eventPlaySound(DirectionManager.SOUND.S1432, Sound.CH.VC1, true, 1f, 138);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_870();
				break;
			case 7:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1002_hai1, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp1002_chp, false, false, false, true, 192, 94, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp1002_chp_loop, DirectionManager.MOVIE.hcp1002_chp, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1002_sol, false, false, false, true, 70, 72, 80, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1002_sol_loop, DirectionManager.MOVIE.hsl1002_sol, false, true, false, true);
				break;
			case 8:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2007_sol_hai1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2007_chp, DirectionManager.MOVIE.hsl2007_sol_hai1, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5010_hai1, DirectionManager.MOVIE.hcp2007_chp, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 241);
				evt.eventPlaySound(DirectionManager.SOUND.S0476, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0910, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE1, true, 1f, 42);
				evt.eventPlaySound(DirectionManager.SOUND.S1433, Sound.CH.VC1, true, 1f, 42);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 77);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE1, true, 1f, 148);
				evt.eventPlaySound(DirectionManager.SOUND.S0948, Sound.CH.VC0, true, 1f, 192);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE0, true, 1f, 241);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_sol, false, false, false, true, 60, 84, 90, 60);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add, false, false, true, false, 0, 0, 85, 60);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp5010_chp, false, false, false, false, 0, 0, 80, 60);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add2, false, false, true, false, 0, 0, 75, 60);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 70, 145);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 69, 145);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 9:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2008_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2008_chp, DirectionManager.MOVIE.hsl2008_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp5007_chp1, DirectionManager.MOVIE.hcp2008_chp, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0222, Sound.CH.SE1, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S0864, Sound.CH.VC0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S1446, Sound.CH.VC1, true, 1f, 145);
				evt.eventPlaySound(DirectionManager.SOUND.S0265, Sound.CH.SE1, true, 1f, 148);
				evt.eventPlaySound(DirectionManager.SOUND.S0610, Sound.CH.SE0, true, 1f, 165);
				evt.eventPlaySound(DirectionManager.SOUND.S0618, Sound.CH.SE1, true, 1f, 189);
				evt.eventPlaySound(DirectionManager.SOUND.S0619, Sound.CH.SE0, true, 1f, 211);
				evt.eventPlaySound(DirectionManager.SOUND.S0620, Sound.CH.SE1, true, 1f, 238);
				evt.eventPlaySound(DirectionManager.SOUND.S1432, Sound.CH.VC0, true, 1f, 244);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_878();
				break;
			case 10:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2008_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2008_chp, DirectionManager.MOVIE.hsl2008_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5010_hai1, DirectionManager.MOVIE.hcp2008_chp, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 347);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0222, Sound.CH.SE1, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S0864, Sound.CH.VC0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE1, true, 1f, 149);
				evt.eventPlaySound(DirectionManager.SOUND.S1433, Sound.CH.VC1, true, 1f, 149);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 183);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE1, true, 1f, 254);
				evt.eventPlaySound(DirectionManager.SOUND.S0948, Sound.CH.VC0, true, 1f, 298);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE0, true, 1f, 347);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_sol, false, false, false, true, 60, 84, 90, 146);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add, false, false, true, false, 0, 0, 85, 146);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp5010_chp, false, false, false, false, 0, 0, 80, 146);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add2, false, false, true, false, 0, 0, 75, 146);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 70, 231);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 69, 231);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 11:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2011_sol1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp5007_chp1, DirectionManager.MOVIE.hsl2011_sol1, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0916, Sound.CH.VC0, true, 1f, 24);
				evt.eventPlaySound(DirectionManager.SOUND.S0479, Sound.CH.SE1, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S1446, Sound.CH.VC1, true, 1f, 84);
				evt.eventPlaySound(DirectionManager.SOUND.S0265, Sound.CH.SE1, true, 1f, 88);
				evt.eventPlaySound(DirectionManager.SOUND.S0610, Sound.CH.SE0, true, 1f, 105);
				evt.eventPlaySound(DirectionManager.SOUND.S0618, Sound.CH.SE1, true, 1f, 129);
				evt.eventPlaySound(DirectionManager.SOUND.S0619, Sound.CH.SE0, true, 1f, 151);
				evt.eventPlaySound(DirectionManager.SOUND.S0620, Sound.CH.SE1, true, 1f, 178);
				evt.eventPlaySound(DirectionManager.SOUND.S1432, Sound.CH.VC0, true, 1f, 184);
				break;
			case 12:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2011_sol1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2011_chp, DirectionManager.MOVIE.hsl2011_sol1, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5010_hai1, DirectionManager.MOVIE.hcp2011_chp, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 312);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0916, Sound.CH.VC0, true, 1f, 24);
				evt.eventPlaySound(DirectionManager.SOUND.S0479, Sound.CH.SE1, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE1, true, 1f, 109);
				evt.eventPlaySound(DirectionManager.SOUND.S1433, Sound.CH.VC1, true, 1f, 109);
				evt.eventPlaySound(DirectionManager.SOUND.S0491, Sound.CH.SE0, true, 1f, 135);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, false, 1f, 148);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE0, true, 1f, 219);
				evt.eventPlaySound(DirectionManager.SOUND.S0948, Sound.CH.VC0, true, 1f, 263);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE1, true, 1f, 312);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_sol, false, false, false, true, 60, 84, 90, 109);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add, false, false, true, false, 0, 0, 85, 109);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp5010_chp, false, false, false, false, 0, 0, 80, 109);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add2, false, false, true, false, 0, 0, 75, 109);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 70, 193);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 69, 193);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 13:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2011_sol1, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2011_chp, DirectionManager.MOVIE.hsl2011_sol1, true, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5010_hai1, DirectionManager.MOVIE.hcp2011_chp, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 384);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0916, Sound.CH.VC0, true, 1f, 96);
				evt.eventPlaySound(DirectionManager.SOUND.S0479, Sound.CH.SE1, true, 1f, 117);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 114);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE1, true, 1f, 181);
				evt.eventPlaySound(DirectionManager.SOUND.S1433, Sound.CH.VC1, true, 1f, 181);
				evt.eventPlaySound(DirectionManager.SOUND.S0491, Sound.CH.SE0, true, 1f, 207);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, false, 1f, 220);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE0, true, 1f, 291);
				evt.eventPlaySound(DirectionManager.SOUND.S0948, Sound.CH.VC0, true, 1f, 335);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE1, true, 1f, 384);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_sol, false, false, false, true, 60, 84, 90, 179);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add, false, false, true, false, 0, 0, 85, 179);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp5010_chp, false, false, false, false, 0, 0, 80, 179);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add2, false, false, true, false, 0, 0, 75, 179);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 70, 264);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 69, 264);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 14:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp2012_chp, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2012_chp_loop, DirectionManager.MOVIE.hcp2012_chp, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0480, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0911, Sound.CH.VC0, true, 1f, 0);
				break;
			case 15:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp2013_chp, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp5009_chp1, DirectionManager.MOVIE.hcp2013_chp, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0481, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0912, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0913, Sound.CH.VC1, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0914, Sound.CH.VC0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0613, Sound.CH.SE1, true, 1f, 109);
				evt.eventPlaySound(DirectionManager.SOUND.S0620, Sound.CH.SE0, true, 1f, 149);
				evt.eventPlaySound(DirectionManager.SOUND.S1432, Sound.CH.VC1, true, 1f, 155);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5009_sol, true, false, false, true, 100, 72, 79, 71);
				break;
			case 16:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp2013_chp, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5013_hai1, DirectionManager.MOVIE.hcp2013_chp, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 267);
				evt.eventPlaySound(DirectionManager.SOUND.S0481, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0912, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0913, Sound.CH.VC1, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0914, Sound.CH.VC0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE1, true, 1f, 104);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE0, true, 1f, 175);
				evt.eventPlaySound(DirectionManager.SOUND.S0948, Sound.CH.VC1, true, 1f, 218);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE1, true, 1f, 267);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5013_sol, false, false, false, true, 100, 72, 89, 61);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp5013_chp, false, false, false, true, 148, 72, 90, 61);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 80, 146);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 75, 146);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 17:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp2015_chp, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp5009_chp1, DirectionManager.MOVIE.hcp2015_chp, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0482, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0912, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0913, Sound.CH.VC1, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0908, Sound.CH.VC0, true, 1f, 26);
				evt.eventPlaySound(DirectionManager.SOUND.S1027, Sound.CH.VC1, true, 1f, 39);
				evt.eventPlaySound(DirectionManager.SOUND.S0866, Sound.CH.VC0, true, 1f, 52);
				evt.eventPlaySound(DirectionManager.SOUND.S0914, Sound.CH.VC1, true, 1f, 69);
				evt.eventPlaySound(DirectionManager.SOUND.S0613, Sound.CH.SE1, true, 1f, 148);
				evt.eventPlaySound(DirectionManager.SOUND.S0620, Sound.CH.SE0, true, 1f, 188);
				evt.eventPlaySound(DirectionManager.SOUND.S1432, Sound.CH.VC0, true, 1f, 194);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5009_sol, true, false, false, true, 100, 72, 79, 110);
				break;
			case 18:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp2015_chp, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5013_hai1, DirectionManager.MOVIE.hcp2015_chp, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 306);
				evt.eventPlaySound(DirectionManager.SOUND.S0482, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0912, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0913, Sound.CH.VC1, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0908, Sound.CH.VC0, true, 1f, 26);
				evt.eventPlaySound(DirectionManager.SOUND.S1027, Sound.CH.VC1, true, 1f, 39);
				evt.eventPlaySound(DirectionManager.SOUND.S0866, Sound.CH.VC0, true, 1f, 52);
				evt.eventPlaySound(DirectionManager.SOUND.S0914, Sound.CH.VC1, true, 1f, 69);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE1, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE0, true, 1f, 214);
				evt.eventPlaySound(DirectionManager.SOUND.S0948, Sound.CH.VC0, true, 1f, 257);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE1, true, 1f, 306);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5013_sol, false, false, false, true, 100, 72, 89, 100);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp5013_chp, false, false, false, true, 148, 72, 90, 100);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 80, 185);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 75, 185);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 19:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2015_chp, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5013_hai1, DirectionManager.MOVIE.hcp2015_chp, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 378);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0482, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0912, Sound.CH.VC0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0913, Sound.CH.VC1, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0908, Sound.CH.VC0, true, 1f, 98);
				evt.eventPlaySound(DirectionManager.SOUND.S1027, Sound.CH.VC1, true, 1f, 111);
				evt.eventPlaySound(DirectionManager.SOUND.S0866, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0914, Sound.CH.VC1, true, 1f, 141);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE1, true, 1f, 215);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE0, true, 1f, 286);
				evt.eventPlaySound(DirectionManager.SOUND.S0948, Sound.CH.VC0, true, 1f, 329);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE1, true, 1f, 378);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5013_sol, false, false, false, true, 100, 72, 89, 171);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp5013_chp, false, false, false, true, 148, 72, 90, 171);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 80, 256);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 75, 256);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 20:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2011_sol1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp5007_chp1, DirectionManager.MOVIE.hsl2011_sol1, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0479, Sound.CH.SE1, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S1043, Sound.CH.VC0, true, 1f, 56);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S1446, Sound.CH.VC1, true, 1f, 84);
				evt.eventPlaySound(DirectionManager.SOUND.S0265, Sound.CH.SE1, true, 1f, 88);
				evt.eventPlaySound(DirectionManager.SOUND.S0610, Sound.CH.SE0, true, 1f, 105);
				evt.eventPlaySound(DirectionManager.SOUND.S0618, Sound.CH.SE1, true, 1f, 129);
				evt.eventPlaySound(DirectionManager.SOUND.S0619, Sound.CH.SE0, true, 1f, 151);
				evt.eventPlaySound(DirectionManager.SOUND.S0620, Sound.CH.SE1, true, 1f, 178);
				evt.eventPlaySound(DirectionManager.SOUND.S1432, Sound.CH.VC0, true, 1f, 184);
				break;
			case 21:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2011_sol1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2011_chp, DirectionManager.MOVIE.hsl2011_sol1, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5010_hai1, DirectionManager.MOVIE.hcp2011_chp, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 324);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0479, Sound.CH.SE1, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S1043, Sound.CH.VC0, true, 1f, 56);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE1, true, 1f, 109);
				evt.eventPlaySound(DirectionManager.SOUND.S1433, Sound.CH.VC1, true, 1f, 109);
				evt.eventPlaySound(DirectionManager.SOUND.S0491, Sound.CH.SE0, true, 1f, 147);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, false, 1f, 160);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE0, true, 1f, 231);
				evt.eventPlaySound(DirectionManager.SOUND.S0948, Sound.CH.VC0, true, 1f, 275);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE0, true, 1f, 324);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_sol, false, false, false, true, 60, 84, 90, 109);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add, false, false, true, false, 0, 0, 85, 109);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp5010_chp, false, false, false, false, 0, 0, 80, 109);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add2, false, false, true, false, 0, 0, 75, 109);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 70, 198);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 69, 198);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 22:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2011_sol3, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2020_sol, DirectionManager.MOVIE.hsl2011_sol3, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2020_chp, DirectionManager.MOVIE.hsl2020_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp5009_chp1, DirectionManager.MOVIE.hcp2020_chp, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0479, Sound.CH.SE1, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S1043, Sound.CH.SE0, true, 1f, 56);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0483, Sound.CH.SE1, true, 1f, 92);
				evt.eventPlaySound(DirectionManager.SOUND.S0907, Sound.CH.VC1, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S0914, Sound.CH.VC0, true, 1f, 136);
				evt.eventPlaySound(DirectionManager.SOUND.S0613, Sound.CH.SE0, true, 1f, 210);
				evt.eventPlaySound(DirectionManager.SOUND.S0620, Sound.CH.SE1, true, 1f, 252);
				evt.eventPlaySound(DirectionManager.SOUND.S1432, Sound.CH.VC1, true, 1f, 258);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5009_sol, true, false, false, true, 100, 72, 79, 176);
				break;
			case 23:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2011_sol3, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2020_sol, DirectionManager.MOVIE.hsl2011_sol3, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2020_chp, DirectionManager.MOVIE.hsl2020_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5013_hai1, DirectionManager.MOVIE.hcp2020_chp, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 370);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0479, Sound.CH.SE1, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S1043, Sound.CH.VC0, true, 1f, 56);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0483, Sound.CH.SE1, true, 1f, 92);
				evt.eventPlaySound(DirectionManager.SOUND.S0907, Sound.CH.VC1, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S0914, Sound.CH.VC0, true, 1f, 136);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE0, true, 1f, 206);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE1, true, 1f, 278);
				evt.eventPlaySound(DirectionManager.SOUND.S0948, Sound.CH.VC1, true, 1f, 321);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE0, true, 1f, 370);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5013_sol, false, false, false, true, 100, 72, 89, 166);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp5013_chp, false, false, false, true, 148, 72, 90, 166);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 80, 251);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 75, 251);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 24:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2011_sol3, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2020_sol, DirectionManager.MOVIE.hsl2011_sol3, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2020_chp, DirectionManager.MOVIE.hsl2020_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5013_hai1, DirectionManager.MOVIE.hcp2020_chp, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 442);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0479, Sound.CH.SE1, true, 1f, 117);
				evt.eventPlaySound(DirectionManager.SOUND.S1043, Sound.CH.VC0, true, 1f, 128);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0483, Sound.CH.SE0, true, 1f, 164);
				evt.eventPlaySound(DirectionManager.SOUND.S0907, Sound.CH.VC1, true, 1f, 182);
				evt.eventPlaySound(DirectionManager.SOUND.S0914, Sound.CH.VC0, true, 1f, 208);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE0, true, 1f, 278);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE1, true, 1f, 350);
				evt.eventPlaySound(DirectionManager.SOUND.S0948, Sound.CH.VC1, true, 1f, 393);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE0, true, 1f, 442);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5013_sol, false, false, false, true, 100, 72, 89, 238);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp5013_chp, false, false, false, true, 148, 72, 90, 238);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 80, 322);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 75, 322);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 25:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp2022_chp, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2022_chp_loop, DirectionManager.MOVIE.hcp2022_chp, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0484, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1031, Sound.CH.VC0, true, 1f, 0);
				break;
			case 26:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2023_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2023_chp, DirectionManager.MOVIE.hsl2023_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp5007_chp1, DirectionManager.MOVIE.hcp2023_chp, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0485, Sound.CH.SE1, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0887, Sound.CH.VC0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1446, Sound.CH.VC1, true, 1f, 141);
				evt.eventPlaySound(DirectionManager.SOUND.S0265, Sound.CH.SE0, true, 1f, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0610, Sound.CH.SE1, true, 1f, 161);
				evt.eventPlaySound(DirectionManager.SOUND.S0618, Sound.CH.SE0, true, 1f, 185);
				evt.eventPlaySound(DirectionManager.SOUND.S0619, Sound.CH.SE1, true, 1f, 207);
				evt.eventPlaySound(DirectionManager.SOUND.S0620, Sound.CH.SE0, true, 1f, 234);
				evt.eventPlaySound(DirectionManager.SOUND.S1432, Sound.CH.VC0, true, 1f, 240);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_925();
				break;
			case 27:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2023_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2023_chp, DirectionManager.MOVIE.hsl2023_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5010_hai1, DirectionManager.MOVIE.hcp2023_chp, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 364);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0485, Sound.CH.SE1, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0887, Sound.CH.VC0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE0, true, 1f, 166);
				evt.eventPlaySound(DirectionManager.SOUND.S1433, Sound.CH.VC1, true, 1f, 166);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, true, 1f, 200);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE0, true, 1f, 271);
				evt.eventPlaySound(DirectionManager.SOUND.S0948, Sound.CH.VC0, true, 1f, 315);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE1, true, 1f, 364);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_sol, false, false, false, true, 60, 84, 90, 163);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add, false, false, true, false, 0, 0, 85, 163);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp5010_chp, false, false, false, false, 0, 0, 80, 163);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add2, false, false, true, false, 0, 0, 75, 163);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 70, 246);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 69, 246);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 28:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2023_sol, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2023_chp, DirectionManager.MOVIE.hsl2023_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5010_hai1, DirectionManager.MOVIE.hcp2023_chp, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 436);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0485, Sound.CH.SE1, true, 1f, 102);
				evt.eventPlaySound(DirectionManager.SOUND.S0887, Sound.CH.VC0, true, 1f, 104);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE0, true, 1f, 238);
				evt.eventPlaySound(DirectionManager.SOUND.S1433, Sound.CH.VC1, true, 1f, 238);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, true, 1f, 272);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE0, true, 1f, 343);
				evt.eventPlaySound(DirectionManager.SOUND.S0948, Sound.CH.VC0, true, 1f, 387);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE1, true, 1f, 436);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_sol, false, false, false, true, 60, 84, 90, 234);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add, false, false, true, false, 0, 0, 85, 234);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp5010_chp, false, false, false, false, 0, 0, 80, 234);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add2, false, false, true, false, 0, 0, 75, 234);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 70, 319);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 69, 319);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 29:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2026_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2026_chp, DirectionManager.MOVIE.hsl2026_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5010_hai1, DirectionManager.MOVIE.hcp2026_chp, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 320);
				evt.eventPlaySound(DirectionManager.SOUND.S0244, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0487, Sound.CH.SE1, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S0934, Sound.CH.VC0, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE0, true, 1f, 117);
				evt.eventPlaySound(DirectionManager.SOUND.S1433, Sound.CH.VC1, true, 1f, 117);
				evt.eventPlaySound(DirectionManager.SOUND.S0491, Sound.CH.SE1, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, false, 1f, 156);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE1, true, 1f, 227);
				evt.eventPlaySound(DirectionManager.SOUND.S0949, Sound.CH.VC0, true, 1f, 271);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE0, true, 1f, 320);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5011_sol, false, false, false, true, 60, 72, 90, 135);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add, false, false, true, false, 0, 0, 85, 135);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp5010_chp, false, false, false, false, 0, 0, 80, 135);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add2, false, false, true, false, 0, 0, 75, 135);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 70, 220);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 69, 220);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 30:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2026_sol, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2026_chp, DirectionManager.MOVIE.hsl2026_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5010_hai1, DirectionManager.MOVIE.hcp2026_chp, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 392);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0244, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0487, Sound.CH.SE1, true, 1f, 117);
				evt.eventPlaySound(DirectionManager.SOUND.S0934, Sound.CH.VC0, true, 1f, 117);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE0, true, 1f, 189);
				evt.eventPlaySound(DirectionManager.SOUND.S1433, Sound.CH.VC1, true, 1f, 189);
				evt.eventPlaySound(DirectionManager.SOUND.S0491, Sound.CH.SE1, true, 1f, 215);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, false, 1f, 228);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE1, true, 1f, 299);
				evt.eventPlaySound(DirectionManager.SOUND.S0949, Sound.CH.VC0, true, 1f, 343);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE0, true, 1f, 392);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5011_sol, false, false, false, true, 60, 72, 90, 206);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add, false, false, true, false, 0, 0, 85, 206);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp5010_chp, false, false, false, false, 0, 0, 80, 206);
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
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp2001_chp, true, false, false, true, 192, 94, 80, 0);
				break;
			case 32:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp2002_chp1, false, true, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, true, false, true, 128, 119, 90, 9);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 33:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp2002_chp2, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2002_sol2, DirectionManager.MOVIE.hcp2002_chp2, false, false, false, false);
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
				evt.eventPlaySound(DirectionManager.SOUND.S1434, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl3001_sol, true, false, false, true, 70, 72, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp3001_chp, false, false, false, false, 0, 0, 80, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl3001_add, false, false, true, false, 0, 0, 70, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl3001_add_loop, DirectionManager.MOVIE.hsl3001_add, false, true, true, false);
				break;
			case 35:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp3004_chp, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp3004_chp_loop, DirectionManager.MOVIE.hcp3004_chp, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0488, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1436, Sound.CH.VC0, true, 1f, 0);
				break;
			case 36:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp3005_chp, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp3005_chp_loop, DirectionManager.MOVIE.hcp3005_chp, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0489, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1437, Sound.CH.VC0, true, 1f, 0);
				break;
			case 37:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp3006_chp, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5002_hai1, DirectionManager.MOVIE.hcp3006_chp, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0614, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1438, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0266, Sound.CH.SE1, true, 1f, 61);
				evt.eventPlaySound(DirectionManager.SOUND.S0491, Sound.CH.SE0, true, 1f, 69);
				evt.eventPlaySound(DirectionManager.SOUND.S0492, Sound.CH.SE1, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0935, Sound.CH.VC1, true, 1f, 108);
				break;
			case 38:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp3006_chp, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5004_hai1, DirectionManager.MOVIE.hcp3006_chp, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S0200, Sound.CH.BGM, true, 1f, 158);
				evt.eventPlaySound(DirectionManager.SOUND.S0614, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1438, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0940, Sound.CH.VC1, true, 1f, 61);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, true, 1f, 67);
				evt.eventPlaySound(DirectionManager.SOUND.S0941, Sound.CH.VC0, true, 1f, 105);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5004_sol, false, false, false, false, 0, 0, 85, 45);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp5004_chp, false, false, false, true, 216, 104, 90, 45);
				break;
			case 39:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp3018_chp1, false, false, false, false, 0, 0, 90, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0614, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1438, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0490, Sound.CH.SE1, true, 1f, 48);
				evt.eventPlaySound(DirectionManager.SOUND.S0931, Sound.CH.VC1, true, 1f, 82);
				break;
			case 40:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp3008_chp, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp3008_sol, false, false, false, false, 0, 0, 100, 91);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5002_hai1, DirectionManager.MOVIE.hcp3008_sol, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0615, Sound.CH.SE1, true, 1f, 51);
				evt.eventPlaySound(DirectionManager.SOUND.S1439, Sound.CH.VC0, true, 1f, 57);
				evt.eventPlaySound(DirectionManager.SOUND.S0266, Sound.CH.SE0, true, 1f, 125);
				evt.eventPlaySound(DirectionManager.SOUND.S0491, Sound.CH.SE1, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S0492, Sound.CH.SE0, true, 1f, 159);
				evt.eventPlaySound(DirectionManager.SOUND.S1038, Sound.CH.VC1, true, 1f, 172);
				break;
			case 41:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp3008_chp, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp3008_sol, false, false, false, false, 0, 0, 100, 91);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5004_hai1, DirectionManager.MOVIE.hcp3008_sol, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 125);
				evt.eventPlaySound(DirectionManager.SOUND.S0200, Sound.CH.BGM, true, 1f, 222);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0615, Sound.CH.SE1, true, 1f, 51);
				evt.eventPlaySound(DirectionManager.SOUND.S1439, Sound.CH.VC0, true, 1f, 57);
				evt.eventPlaySound(DirectionManager.SOUND.S0940, Sound.CH.VC1, true, 1f, 125);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 131);
				evt.eventPlaySound(DirectionManager.SOUND.S0941, Sound.CH.VC0, true, 1f, 169);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5004_sol, false, false, false, false, 0, 0, 85, 124);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp5004_chp, false, false, false, true, 216, 104, 90, 124);
				break;
			case 42:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp3014_chp, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl3014_sly_loop, DirectionManager.MOVIE.hcp3014_chp, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0494, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1044, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0080, Sound.CH.SE0, false, 1f, 0);
				break;
			case 43:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp3011_chp1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp3011_chp1_loop, DirectionManager.MOVIE.hcp3011_chp1, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0616, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0269, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1441, Sound.CH.VC0, true, 1f, 11);
				break;
			case 44:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp3011_chp2, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp3011_sol, DirectionManager.MOVIE.hcp3011_chp2, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5002_hai1, DirectionManager.MOVIE.hcp3011_sol, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0617, Sound.CH.SE0, true, 1f, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5002_hai1, DirectionManager.MOVIE.hsl1001_sol1, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0617, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1443, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1444, Sound.CH.VC1, true, 1f, 135);
				evt.eventPlaySound(DirectionManager.SOUND.S0266, Sound.CH.SE1, true, 1f, 156);
				evt.eventPlaySound(DirectionManager.SOUND.S0491, Sound.CH.SE0, true, 1f, 164);
				evt.eventPlaySound(DirectionManager.SOUND.S0492, Sound.CH.SE1, true, 1f, 190);
				evt.eventPlaySound(DirectionManager.SOUND.S1037, Sound.CH.VC0, true, 1f, 190);
				break;
			case 45:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp3011_chp2, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp3011_sol, DirectionManager.MOVIE.hcp3011_chp2, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5004_hai1, DirectionManager.MOVIE.hcp3011_sol, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 90);
				evt.eventPlaySound(DirectionManager.SOUND.S0200, Sound.CH.BGM, true, 1f, 253);
				evt.eventPlaySound(DirectionManager.SOUND.S0617, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1443, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1444, Sound.CH.VC1, true, 1f, 135);
				evt.eventPlaySound(DirectionManager.SOUND.S0940, Sound.CH.VC0, true, 1f, 156);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, true, 1f, 162);
				evt.eventPlaySound(DirectionManager.SOUND.S0941, Sound.CH.VC1, true, 1f, 200);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5004_sol, false, false, false, false, 0, 0, 85, 155);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp5004_chp, false, false, false, true, 216, 104, 90, 155);
				break;
			case 46:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp3003_chp, false, false, false, false, 0, 0, 100, 1);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp3003_chp2_loop, DirectionManager.MOVIE.hcp3003_chp, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0264, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1435, Sound.CH.VC0, true, 1f, 22);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 47:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl4001_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2012_chp, DirectionManager.MOVIE.hsl4001_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2012_chp_loop, DirectionManager.MOVIE.hcp2012_chp, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0480, Sound.CH.SE1, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0911, Sound.CH.VC1, true, 1f, 40);
				break;
			case 48:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl4001_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2022_chp, DirectionManager.MOVIE.hsl4001_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2022_chp_loop, DirectionManager.MOVIE.hcp2022_chp, false, true, false, false);
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
				evt.eventPlaySound(DirectionManager.SOUND.S1434, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl3001_sol, true, false, false, true, 70, 72, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp3001_chp, false, false, false, false, 0, 0, 80, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl3001_add, false, false, true, false, 0, 0, 70, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl3001_add_loop, DirectionManager.MOVIE.hsl3001_add, false, true, true, false);
				break;
			case 52:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_sol1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp1001_chp1, DirectionManager.MOVIE.hsl1001_sol1, true, false, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_sol2, false, false, false, true, 70, 72, 101, 111);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp1001_chp2, false, false, false, true, 192, 72, 102, 111);
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
				evt.eventAddMovie(DirectionManager.MOVIE.hcp5007_chp1, DirectionManager.MOVIE.hsl2007_sol_hai1, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0476, Sound.CH.SE1, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0910, Sound.CH.VC1, true, 1f, 60);
				evt.eventPlaySound(DirectionManager.SOUND.S0265, Sound.CH.SE0, true, 1f, 63);
				evt.eventPlaySound(DirectionManager.SOUND.S1445, Sound.CH.VC0, true, 1f, 68);
				evt.eventPlaySound(DirectionManager.SOUND.S0610, Sound.CH.SE1, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0618, Sound.CH.SE0, true, 1f, 104);
				evt.eventPlaySound(DirectionManager.SOUND.S0619, Sound.CH.SE1, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0620, Sound.CH.SE0, true, 1f, 153);
				evt.eventPlaySound(DirectionManager.SOUND.S1432, Sound.CH.VC1, true, 1f, 159);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_870();
				break;
			case 54:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl4001_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2007_sol_hai1, DirectionManager.MOVIE.hsl4001_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2007_chp, DirectionManager.MOVIE.hsl2007_sol_hai1, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5010_hai1, DirectionManager.MOVIE.hcp2007_chp, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 281);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0476, Sound.CH.SE1, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0910, Sound.CH.VC1, true, 1f, 60);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE0, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S1433, Sound.CH.VC0, true, 1f, 82);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, true, 1f, 117);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE0, true, 1f, 188);
				evt.eventPlaySound(DirectionManager.SOUND.S0948, Sound.CH.VC1, true, 1f, 232);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE1, true, 1f, 281);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_sol, false, false, false, true, 60, 84, 90, 91);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add, false, false, true, false, 0, 0, 85, 91);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp5010_chp, false, false, false, false, 0, 0, 80, 91);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add2, false, false, true, false, 0, 0, 75, 91);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 70, 176);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 69, 176);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 55:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl4001_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2008_sol, DirectionManager.MOVIE.hsl4001_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2008_chp, DirectionManager.MOVIE.hsl2008_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp5007_chp1, DirectionManager.MOVIE.hcp2008_chp, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE1, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0222, Sound.CH.SE0, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0864, Sound.CH.VC1, true, 1f, 99);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE1, true, 1f, 173);
				evt.eventPlaySound(DirectionManager.SOUND.S1446, Sound.CH.VC0, true, 1f, 185);
				evt.eventPlaySound(DirectionManager.SOUND.S0265, Sound.CH.SE0, true, 1f, 188);
				evt.eventPlaySound(DirectionManager.SOUND.S0610, Sound.CH.SE1, true, 1f, 205);
				evt.eventPlaySound(DirectionManager.SOUND.S0618, Sound.CH.SE0, true, 1f, 229);
				evt.eventPlaySound(DirectionManager.SOUND.S0619, Sound.CH.SE1, true, 1f, 251);
				evt.eventPlaySound(DirectionManager.SOUND.S0620, Sound.CH.SE0, true, 1f, 278);
				evt.eventPlaySound(DirectionManager.SOUND.S1432, Sound.CH.VC1, true, 1f, 284);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_878();
				break;
			case 56:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl4001_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2008_sol, DirectionManager.MOVIE.hsl4001_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2008_chp, DirectionManager.MOVIE.hsl2008_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5010_hai1, DirectionManager.MOVIE.hcp2008_chp, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 387);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE1, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0222, Sound.CH.SE0, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0864, Sound.CH.VC1, true, 1f, 99);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE0, true, 1f, 189);
				evt.eventPlaySound(DirectionManager.SOUND.S1433, Sound.CH.VC0, true, 1f, 189);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, true, 1f, 223);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE0, true, 1f, 294);
				evt.eventPlaySound(DirectionManager.SOUND.S0948, Sound.CH.VC1, true, 1f, 338);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE1, true, 1f, 387);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_sol, false, false, false, true, 60, 84, 90, 177);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add, false, false, true, false, 0, 0, 85, 177);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp5010_chp, false, false, false, false, 0, 0, 80, 177);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add2, false, false, true, false, 0, 0, 75, 177);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 70, 262);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 69, 262);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 57:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl4001_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2011_sol1, DirectionManager.MOVIE.hsl4001_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2011_chp, DirectionManager.MOVIE.hsl2011_sol1, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp5007_chp1, DirectionManager.MOVIE.hcp2011_chp, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE1, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0916, Sound.CH.VC1, true, 1f, 64);
				evt.eventPlaySound(DirectionManager.SOUND.S0479, Sound.CH.SE0, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE1, true, 1f, 112);
				evt.eventPlaySound(DirectionManager.SOUND.S1446, Sound.CH.VC0, true, 1f, 124);
				evt.eventPlaySound(DirectionManager.SOUND.S0265, Sound.CH.SE0, true, 1f, 128);
				evt.eventPlaySound(DirectionManager.SOUND.S0610, Sound.CH.SE1, true, 1f, 145);
				evt.eventPlaySound(DirectionManager.SOUND.S0618, Sound.CH.SE0, true, 1f, 169);
				evt.eventPlaySound(DirectionManager.SOUND.S0619, Sound.CH.SE1, true, 1f, 191);
				evt.eventPlaySound(DirectionManager.SOUND.S0620, Sound.CH.SE0, true, 1f, 218);
				evt.eventPlaySound(DirectionManager.SOUND.S1432, Sound.CH.VC1, true, 1f, 224);
				break;
			case 58:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl4001_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2011_sol1, DirectionManager.MOVIE.hsl4001_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp2011_chp, DirectionManager.MOVIE.hsl2011_sol1, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5010_hai1, DirectionManager.MOVIE.hcp2011_chp, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 331);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE1, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0916, Sound.CH.VC1, true, 1f, 64);
				evt.eventPlaySound(DirectionManager.SOUND.S0479, Sound.CH.SE0, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE1, true, 1f, 112);
				evt.eventPlaySound(DirectionManager.SOUND.S0496, Sound.CH.SE0, true, 1f, 128);
				evt.eventPlaySound(DirectionManager.SOUND.S1433, Sound.CH.VC0, true, 1f, 128);
				evt.eventPlaySound(DirectionManager.SOUND.S0491, Sound.CH.SE1, true, 1f, 154);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, false, 1f, 167);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE1, true, 1f, 238);
				evt.eventPlaySound(DirectionManager.SOUND.S0948, Sound.CH.VC1, true, 1f, 282);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE0, true, 1f, 331);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_sol, false, false, false, true, 60, 84, 90, 137);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add, false, false, true, false, 0, 0, 85, 137);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp5010_chp, false, false, false, false, 0, 0, 80, 137);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_add2, false, false, true, false, 0, 0, 75, 137);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 70, 222);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 69, 222);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 59:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_sol1, false, false, false, false, 0, 0, 100, 53);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp1001_chp1, DirectionManager.MOVIE.hsl1001_sol1, true, false, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_sol2, false, false, false, true, 70, 72, 101, 162);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp1001_chp2, false, false, false, true, 192, 72, 102, 162);
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
				DirectionLedManager.m_panel_HOH_cp_vs_01(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_5M));
				break;
			case 2:
				DirectionLedManager.JG_HOH_herecomes_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.YK_HOH_herecomes_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_HOH_cp_vs_02(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_5M));
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
				DirectionLedManager.GD_HCP_enm_P(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 36:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HCP_enm_K(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 37:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HCP_enm_HS(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 38:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.OFF_3(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.GD_HCP_enm_HS(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 39:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_guard_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 40:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HCP_enm_AB(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 41:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.OFF_3(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.GD_HCP_enm_AB(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
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
				DirectionLedManager.GD_HCP_enm_ZR(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 45:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.OFF_3(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.GD_HCP_enm_ZR(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
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
				DirectionLedManager.m_panel_HOH_cp_vs_01(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_5M));
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
				DirectionLedManager.m_panel_HOH_cp_vs_03(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_5M));
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
		if (SGLG.sound.getBGMID() == 42)
		{
			if (SGLG.sound.getBGMVolume() < 1f)
			{
				evt.eventFadeSound(Sound.CH.BGM, 1f, 1f, 1, 0);
			}
		}
		else
		{
			evt.eventPlaySound(DirectionManager.SOUND.S0143, Sound.CH.BGM, false, 1f, 0);
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
