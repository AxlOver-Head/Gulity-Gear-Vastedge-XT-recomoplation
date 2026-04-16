public class Direction27AOH : DirectionBase
{
	public Direction27AOH(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventPlayMovie(DirectionManager.MOVIE.aoh001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aoh001_loop, DirectionManager.MOVIE.aoh001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0436, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0970, Sound.CH.VC0, true, 1f, 50);
				evt.eventPlaySound(DirectionManager.SOUND.S0855, Sound.CH.VC0, true, 1f, 150);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aoh002_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aoh002_a_loop, DirectionManager.MOVIE.aoh002_a, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0222, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0856, Sound.CH.VC0, true, 1f, 14);
				break;
			case 3:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aoh005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aoh005_loop, DirectionManager.MOVIE.aoh005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0859, Sound.CH.VC0, true, 1f, 48);
				break;
			case 4:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aoh003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aoh003_loop, DirectionManager.MOVIE.aoh003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0858, Sound.CH.VC0, true, 1f, 62);
				evt.eventPlaySound(DirectionManager.SOUND.S0370, Sound.CH.SE0, true, 1f, 68);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_419();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 99, 50);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 50);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aoh003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aoh003_loop, DirectionManager.MOVIE.aoh003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0858, Sound.CH.VC0, true, 1f, 62);
				evt.eventPlaySound(DirectionManager.SOUND.S0370, Sound.CH.SE0, true, 1f, 68);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_423();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 99, 50);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 50);
				break;
			case 6:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aoh003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aoh003_loop, DirectionManager.MOVIE.aoh003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0858, Sound.CH.VC0, true, 1f, 62);
				evt.eventPlaySound(DirectionManager.SOUND.S0370, Sound.CH.SE0, true, 1f, 68);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_427();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 99, 50);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 50);
				break;
			case 7:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aoh003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aoh003_loop, DirectionManager.MOVIE.aoh003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0858, Sound.CH.VC0, true, 1f, 62);
				evt.eventPlaySound(DirectionManager.SOUND.S0370, Sound.CH.SE0, true, 1f, 68);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_429();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_431();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 99, 50);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 50);
				break;
			case 8:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aoh003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aoh003_loop, DirectionManager.MOVIE.aoh003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0858, Sound.CH.VC0, true, 1f, 62);
				evt.eventPlaySound(DirectionManager.SOUND.S0370, Sound.CH.SE0, true, 1f, 68);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_433();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_435();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 99, 50);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 50);
				break;
			case 9:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aoh003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aoh003_loop, DirectionManager.MOVIE.aoh003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0858, Sound.CH.VC0, true, 1f, 62);
				evt.eventPlaySound(DirectionManager.SOUND.S0370, Sound.CH.SE0, true, 1f, 68);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_437();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_439();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 99, 50);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 50);
				break;
			case 10:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aoh003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aoh003_loop, DirectionManager.MOVIE.aoh003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0858, Sound.CH.VC0, true, 1f, 62);
				evt.eventPlaySound(DirectionManager.SOUND.S0370, Sound.CH.SE0, true, 1f, 68);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_441();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_443();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 99, 50);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 50);
				break;
			case 11:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aoh003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aoh003_loop, DirectionManager.MOVIE.aoh003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0858, Sound.CH.VC0, true, 1f, 62);
				evt.eventPlaySound(DirectionManager.SOUND.S0370, Sound.CH.SE0, true, 1f, 68);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_445();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_447();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 99, 50);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 50);
				break;
			case 12:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aoh003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aoh003_loop, DirectionManager.MOVIE.aoh003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0858, Sound.CH.VC0, true, 1f, 62);
				evt.eventPlaySound(DirectionManager.SOUND.S0370, Sound.CH.SE0, true, 1f, 68);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_451();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_7, false, false, true, false, 0, 0, 99, 50);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_7_loop, DirectionManager.MOVIE.huc008_T_7, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 50);
				break;
			case 13:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aoh004, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aoh004_loop, DirectionManager.MOVIE.aoh004, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0438, Sound.CH.SE0, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh006_sly, false, false, false, false, 0, 0, 99, 80);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh006_sly_loop, DirectionManager.MOVIE.ksh006_sly, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S1395, Sound.CH.VC0, true, 1f, 129);
				evt.eventPlaySound(DirectionManager.SOUND.S0511, Sound.CH.SE1, true, 1f, 147);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 167);
				evt.eventPlaySound(DirectionManager.SOUND.S1381, Sound.CH.VC1, true, 1f, 177);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, true, 1f, 276);
				break;
			case 14:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aoh004, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aoh004_loop, DirectionManager.MOVIE.aoh004, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0438, Sound.CH.SE0, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh003_chp, false, false, false, false, 0, 0, 99, 80);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh003_chp_loop, DirectionManager.MOVIE.ksh003_chp, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0512, Sound.CH.SE1, true, 1f, 129);
				evt.eventPlaySound(DirectionManager.SOUND.S1442, Sound.CH.VC0, true, 1f, 129);
				evt.eventPlaySound(DirectionManager.SOUND.S0513, Sound.CH.SE0, true, 1f, 143);
				evt.eventPlaySound(DirectionManager.SOUND.S0514, Sound.CH.SE1, true, 1f, 175);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 192);
				evt.eventPlaySound(DirectionManager.SOUND.S1431, Sound.CH.VC1, true, 1f, 193);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, true, 1f, 292);
				break;
			case 15:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aoh004, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aoh004_loop, DirectionManager.MOVIE.aoh004, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0438, Sound.CH.SE0, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh005_mil, false, false, false, false, 0, 0, 99, 80);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh005_mil_loop, DirectionManager.MOVIE.ksh005_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0515, Sound.CH.SE1, true, 1f, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S1492, Sound.CH.VC0, true, 1f, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0516, Sound.CH.SE0, true, 1f, 182);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 196);
				evt.eventPlaySound(DirectionManager.SOUND.S1481, Sound.CH.VC1, true, 1f, 198);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, true, 1f, 268);
				break;
			case 16:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aoh004, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aoh004_loop, DirectionManager.MOVIE.aoh004, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0438, Sound.CH.SE0, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh002_bri, false, false, false, false, 0, 0, 99, 80);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh002_bri_loop, DirectionManager.MOVIE.ksh002_bri, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S1544, Sound.CH.VC0, true, 1f, 130);
				evt.eventPlaySound(DirectionManager.SOUND.S0517, Sound.CH.SE1, true, 1f, 140);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE0, true, 1f, 182);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC1, true, 1f, 198);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, true, 1f, 274);
				break;
			case 17:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aoh004, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aoh004_loop, DirectionManager.MOVIE.aoh004, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0438, Sound.CH.SE0, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 99, 80);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh007_zap_loop, DirectionManager.MOVIE.ksh007_zap, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 128);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 173);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 185);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 232);
				break;
			case 18:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aoh004, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aoh004_ano, DirectionManager.MOVIE.aoh004, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0438, Sound.CH.SE0, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh001_ano, false, false, false, false, 0, 0, 99, 80);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh001_ano_loop, DirectionManager.MOVIE.ksh001_ano, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0520, Sound.CH.SE1, true, 1f, 122);
				evt.eventPlaySound(DirectionManager.SOUND.S0521, Sound.CH.SE0, true, 1f, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 191);
				evt.eventPlaySound(DirectionManager.SOUND.S1611, Sound.CH.VC0, true, 1f, 199);
				evt.eventPlaySound(DirectionManager.SOUND.S0190, Sound.CH.BGM, true, 1f, 284);
				break;
			case 19:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.aoh002_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aoh002_b_loop, DirectionManager.MOVIE.aoh002_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0437, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0914, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0857, Sound.CH.VC0, true, 1f, 21);
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
