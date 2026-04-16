public class Direction100CMN : DirectionBase
{
	public Direction100CMN(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		switch (low)
		{
		case 0:
			switch (mode)
			{
			case 2:
				evt.eventDisableBefore(mng, 0);
				MainGameScene.dirMan.restartBGM();
				break;
			case 3:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.igo001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.igo001_loop, DirectionManager.MOVIE.igo001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0127, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0505, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0897, Sound.CH.VC0, true, 1f, 16);
				break;
			case 4:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ihh001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ihh001_loop, DirectionManager.MOVIE.ihh001, false, true, false, false);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0473, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1947, Sound.CH.VC0, true, 1f, 30);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ijs001, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0138, Sound.CH.BGM, true, 1f, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S0504, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1941, Sound.CH.VC0, true, 1f, 90);
				break;
			case 6:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ikg005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ikg001_a, DirectionManager.MOVIE.ikg005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.ikg001_a_loop, DirectionManager.MOVIE.ikg001_a, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0206, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0202, Sound.CH.BGM, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0458, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0459, Sound.CH.SE0, true, 1f, 101);
				evt.eventPlaySound(DirectionManager.SOUND.S1958, Sound.CH.VC0, true, 1f, 132);
				break;
			case 7:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.iss001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.iss001_loop, DirectionManager.MOVIE.iss001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0472, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0502, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1940, Sound.CH.VC0, true, 1f, 44);
				break;
			case 8:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd002, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd002_loop, DirectionManager.MOVIE.yjd002, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0066, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 107);
				evt.eventPlaySound(DirectionManager.SOUND.S0119, Sound.CH.BGM, true, 1f, 157);
				break;
			case 9:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.iog001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.iog001_loop, DirectionManager.MOVIE.iog001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0133, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0506, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0900, Sound.CH.VC0, true, 1f, 17);
				break;
			case 10:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd001, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd001_loop, DirectionManager.MOVIE.yjd001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0066, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 107);
				evt.eventPlaySound(DirectionManager.SOUND.S0117, Sound.CH.BGM, true, 1f, 157);
				break;
			case 11:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ibs001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ibs001_loop, DirectionManager.MOVIE.ibs001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0122, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0507, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1944, Sound.CH.VC0, true, 1f, 32);
				break;
			case 12:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd006, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd006_loop, DirectionManager.MOVIE.yjd006, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0074, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0358, Sound.CH.SE1, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 150);
				break;
			case 13:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd007, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd007_loop, DirectionManager.MOVIE.yjd007, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0074, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0358, Sound.CH.SE0, true, 1f, 77);
				evt.eventPlaySound(DirectionManager.SOUND.S0215, Sound.CH.SE1, true, 1f, 77);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 150);
				break;
			case 14:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ish001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.ish001_loop, DirectionManager.MOVIE.ish001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0129, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0505, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0899, Sound.CH.VC0, true, 1f, 17);
				break;
			case 15:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.imb001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.imb001_loop, DirectionManager.MOVIE.imb001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0131, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0505, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0898, Sound.CH.VC0, true, 1f, 19);
				break;
			case 16:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1002_hai1, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1002_sly, false, false, false, true, 196, 94, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1002_sly_loop, DirectionManager.MOVIE.hsl1002_sly, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1002_sol, false, false, false, true, 70, 72, 80, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1002_sol_loop, DirectionManager.MOVIE.hsl1002_sol, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1002_logo, false, false, false, false, 0, 0, 70, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0258, Sound.CH.SE0, true, 1f, 9);
				evt.eventPlaySound(DirectionManager.SOUND.S1948, Sound.CH.VC0, true, 1f, 14);
				evt.eventPlaySound(DirectionManager.SOUND.S0142, Sound.CH.BGM, true, 1f, 0);
				break;
			case 17:
				evt.eventStopDirectionBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy000_1, false, false, false, false, 0, 0, 60, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0236, Sound.CH.SE0, true, 1f, 0);
				break;
			case 18:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2011_sol2, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2011_sol2_loop, DirectionManager.MOVIE.hsl2011_sol2, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0478, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1042, Sound.CH.VC0, true, 1f, 0);
				break;
			case 19:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2001_hai1_a, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2001_sol1, false, false, false, false, 0, 0, 90, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2001_sol1_loop, DirectionManager.MOVIE.hsl2001_sol1, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1041, Sound.CH.VC0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				break;
			case 20:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2025_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2025_sol_loop, DirectionManager.MOVIE.hsl2025_sol, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0486, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1045, Sound.CH.VC0, true, 1f, 0);
				break;
			case 21:
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2001_hai1_kyo, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0260, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S1023, Sound.CH.VC0, true, 1f, 106);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2001_sol2, false, false, false, false, 0, 0, 90, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2001_sol2_loop, DirectionManager.MOVIE.hsl2001_sol2, false, true, false, false);
				break;
			case 22:
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl4005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl4005_loop, DirectionManager.MOVIE.hsl4005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0495, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0944, Sound.CH.VC1, true, 1f, 10);
				break;
			case 23:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2025_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2025_sol_loop, DirectionManager.MOVIE.hsl2025_sol, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0486, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1045, Sound.CH.VC0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_097();
				evt.eventPlayMovie(DirectionManager.MOVIE.aig001_d, false, false, false, true, 128, 99, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.aig001_d_loop, DirectionManager.MOVIE.aig001_d, false, true, false, true);
				break;
			case 24:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2028, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0268, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0872, Sound.CH.VC0, true, 1f, 24);
				evt.eventPlayMovie(DirectionManager.MOVIE.aig003_d, true, false, false, true, 128, 99, 99, 0);
				break;
			case 27:
				evt.eventPlaySound(DirectionManager.SOUND.S0315, Sound.CH.SE0, true, 1f, 0);
				break;
			case 28:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.isc001_b, true, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0239, Sound.CH.SE0, true, 1f, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.isc001_add, true, false, true, false, 0, 0, 99, 0);
				break;
			case 29:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.isc001_c, true, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0239, Sound.CH.SE0, true, 1f, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.isc001_add, true, false, true, false, 0, 0, 99, 0);
				break;
			case 30:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.isc001_a, true, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0239, Sound.CH.SE0, true, 1f, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.isc001_add, true, false, true, false, 0, 0, 99, 0);
				break;
			case 31:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1002_hai1, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hcp1002_chp, false, false, false, true, 192, 94, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hcp1002_chp_loop, DirectionManager.MOVIE.hcp1002_chp, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1002_sol, false, false, false, true, 70, 72, 97, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1002_sol_loop, DirectionManager.MOVIE.hsl1002_sol, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1002_logo, true, false, false, false, 0, 0, 90, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0258, Sound.CH.SE0, true, 1f, 9);
				evt.eventPlaySound(DirectionManager.SOUND.S1948, Sound.CH.VC0, true, 1f, 14);
				evt.eventPlaySound(DirectionManager.SOUND.S0143, Sound.CH.BGM, true, 1f, 0);
				break;
			case 32:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1002_hai1, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hml1002_mil, false, false, false, true, 195, 111, 99, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1002_sol, false, false, false, true, 70, 72, 97, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1002_sol_loop, DirectionManager.MOVIE.hsl1002_sol, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1002_logo, true, false, false, false, 0, 0, 90, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0258, Sound.CH.SE0, true, 1f, 9);
				evt.eventPlaySound(DirectionManager.SOUND.S1948, Sound.CH.VC0, true, 1f, 14);
				evt.eventPlaySound(DirectionManager.SOUND.S0144, Sound.CH.BGM, true, 1f, 0);
				break;
			case 33:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1002_hai1, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hbj1002_brg, false, false, false, true, 182, 99, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hbj1002_brg_loop, DirectionManager.MOVIE.hbj1002_brg, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1002_sol, false, false, false, true, 70, 72, 97, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1002_sol_loop, DirectionManager.MOVIE.hsl1002_sol, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1002_logo, true, false, false, false, 0, 0, 90, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0258, Sound.CH.SE0, true, 1f, 9);
				evt.eventPlaySound(DirectionManager.SOUND.S1948, Sound.CH.VC0, true, 1f, 14);
				evt.eventPlaySound(DirectionManager.SOUND.S0145, Sound.CH.BGM, true, 1f, 0);
				break;
			case 34:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1002_hai1, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hzp1002_zap, false, false, false, true, 196, 114, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hzp1002_zap_loop, DirectionManager.MOVIE.hzp1002_zap, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1002_sol, false, false, false, true, 70, 72, 97, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1002_sol_loop, DirectionManager.MOVIE.hsl1002_sol, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1002_logo, true, false, false, false, 0, 0, 94, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0258, Sound.CH.SE0, true, 1f, 9);
				evt.eventPlaySound(DirectionManager.SOUND.S1948, Sound.CH.VC0, true, 1f, 14);
				evt.eventPlaySound(DirectionManager.SOUND.S0146, Sound.CH.BGM, true, 1f, 0);
				break;
			case 35:
				evt.eventDisableBefore(mng, 0);
				break;
			case 37:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhs014_1, false, false, false, false, 0, 0, 100, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 25);
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
			case 38:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhs014_1, false, false, false, false, 0, 0, 100, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 25);
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
			case 39:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhs014_1, false, false, false, false, 0, 0, 100, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 25);
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
			case 40:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhs014_1, false, false, false, false, 0, 0, 100, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 25);
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
			case 41:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhs014_1, false, false, false, false, 0, 0, 100, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0214, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksh007_zap, false, false, false, false, 0, 0, 99, 26);
				evt.eventAddMovie(DirectionManager.MOVIE.ksh007_zap_loop, DirectionManager.MOVIE.ksh007_zap, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0508, Sound.CH.SE0, true, 1f, 26);
				evt.eventPlaySound(DirectionManager.SOUND.S0518, Sound.CH.SE1, true, 1f, 74);
				evt.eventPlaySound(DirectionManager.SOUND.S1581, Sound.CH.VC0, true, 1f, 119);
				evt.eventPlaySound(DirectionManager.SOUND.S0510, Sound.CH.SE1, true, 1f, 131);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, true, 1f, 178);
				break;
			case 42:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhs014_1_ano, false, false, false, false, 0, 0, 100, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 25);
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
			case 43:
				evt.eventDisableBefore(mng, 0);
				break;
			case 44:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 16);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_105();
				break;
			case 45:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 16);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_105();
				break;
			case 46:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 16);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_105();
				break;
			case 47:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 16);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_109();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_111();
				break;
			case 48:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 16);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_109();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_111();
				break;
			case 49:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 16);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_109();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_111();
				break;
			case 50:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 16);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_115();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_117();
				break;
			case 51:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 16);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_115();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_117();
				break;
			case 52:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 99, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE0, true, 1f, 82);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_119();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_120();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_122();
				break;
			case 53:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 99, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE0, true, 1f, 82);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_119();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_120();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_122();
				break;
			case 54:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 99, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE0, true, 1f, 82);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_119();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_120();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_122();
				break;
			case 55:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 99, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE0, true, 1f, 82);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_125();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_126();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_128();
				break;
			case 56:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 99, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE0, true, 1f, 82);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_125();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_126();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_128();
				break;
			case 57:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao5001_w, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0535, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0676, Sound.CH.SE1, true, 1f, 8);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 27);
				evt.eventPlaySound(DirectionManager.SOUND.S1016, Sound.CH.VC0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0677, Sound.CH.SE1, true, 1f, 32);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 9);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventSetCanPush(true, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, false, 0, 0, 80, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 23);
				break;
			case 58:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao5002_1_non, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao5004, DirectionManager.MOVIE.bao5002_1_non, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bao5004_loop, DirectionManager.MOVIE.bao5004, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0679, Sound.CH.SE0, true, 1f, 60);
				evt.eventPlaySound(DirectionManager.SOUND.S0929, Sound.CH.VC0, true, 1f, 76);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_ng, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				break;
			case 59:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao5001_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao5001_b_loop, DirectionManager.MOVIE.bao5001_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0535, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0676, Sound.CH.SE1, true, 1f, 8);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 27);
				evt.eventPlaySound(DirectionManager.SOUND.S1016, Sound.CH.VC0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0677, Sound.CH.SE1, true, 1f, 32);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 9);
				evt.eventSetCanPush(true, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, false, 0, 0, 80, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 23);
				break;
			case 60:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao5001_y, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao5001_y_loop, DirectionManager.MOVIE.bao5001_y, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0535, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0676, Sound.CH.SE1, true, 1f, 8);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 27);
				evt.eventPlaySound(DirectionManager.SOUND.S1016, Sound.CH.VC0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0677, Sound.CH.SE1, true, 1f, 32);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 9);
				evt.eventSetCanPush(true, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 61:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao5001_g, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao5001_g_loop, DirectionManager.MOVIE.bao5001_g, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0535, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0676, Sound.CH.SE1, true, 1f, 8);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 27);
				evt.eventPlaySound(DirectionManager.SOUND.S1016, Sound.CH.VC0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0677, Sound.CH.SE1, true, 1f, 32);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 9);
				evt.eventSetCanPush(true, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, false, 0, 0, 80, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 23);
				break;
			case 62:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao5001_r, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao5001_r_loop, DirectionManager.MOVIE.bao5001_r, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0535, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0676, Sound.CH.SE1, true, 1f, 8);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 27);
				evt.eventPlaySound(DirectionManager.SOUND.S1016, Sound.CH.VC0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0677, Sound.CH.SE1, true, 1f, 32);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 9);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventSetCanPush(true, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 63:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao5002_1_w, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao5002_1_w_loop, DirectionManager.MOVIE.bao5002_1_w, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0678, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0926, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE1, true, 1f, 19);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 64:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bao5004, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao5004_loop, DirectionManager.MOVIE.bao5004, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0679, Sound.CH.SE0, true, 1f, 60);
				evt.eventPlaySound(DirectionManager.SOUND.S0929, Sound.CH.VC0, true, 1f, 76);
				break;
			case 65:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao5002_1_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao5002_1_b_loop, DirectionManager.MOVIE.bao5002_1_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0678, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0926, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE1, true, 1f, 19);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, false, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, false, false, true, false, 0, 0, 80, 0);
				break;
			case 66:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao5002_1_y, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao5002_1_y_loop, DirectionManager.MOVIE.bao5002_1_y, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0678, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0926, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE1, true, 1f, 19);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 67:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao5002_1_g, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao5002_1_g_loop, DirectionManager.MOVIE.bao5002_1_g, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0678, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0926, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE1, true, 1f, 19);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 68:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao5002_1_r, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao5002_1_r_loop, DirectionManager.MOVIE.bao5002_1_r, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0678, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0926, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE1, true, 1f, 19);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 69:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao5002_2_w, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao5002_2_w_loop, DirectionManager.MOVIE.bao5002_2_w, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0678, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0926, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE1, true, 1f, 19);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 70:
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2008_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2008_sol_loop, DirectionManager.MOVIE.hsl2008_sol, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0222, Sound.CH.SE1, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S0864, Sound.CH.VC0, true, 1f, 45);
				break;
			case 71:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao5002_2_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao5002_2_b_loop, DirectionManager.MOVIE.bao5002_2_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0678, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0926, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE1, true, 1f, 19);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 72:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao5002_2_y, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao5002_2_y_loop, DirectionManager.MOVIE.bao5002_2_y, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0678, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0926, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE1, true, 1f, 19);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 73:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao5002_2_g, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao5002_2_g_loop, DirectionManager.MOVIE.bao5002_2_g, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0678, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0926, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE1, true, 1f, 19);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 74:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao5002_2_r, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao5002_2_r_loop, DirectionManager.MOVIE.bao5002_2_r, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0678, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0926, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE1, true, 1f, 19);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 75:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao5002_3_w, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao5002_3_w_loop, DirectionManager.MOVIE.bao5002_3_w, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0678, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0926, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE1, true, 1f, 19);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 76:
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2011_sol3, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2011_sol4, DirectionManager.MOVIE.hsl2011_sol3, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2011_sol4_loop, DirectionManager.MOVIE.hsl2011_sol4, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0477, Sound.CH.SE1, true, 1f, 44);
				evt.eventPlaySound(DirectionManager.SOUND.S0916, Sound.CH.VC0, true, 1f, 76);
				break;
			case 77:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao5002_3_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao5002_3_b_loop, DirectionManager.MOVIE.bao5002_3_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0678, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0926, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE1, true, 1f, 19);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 78:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao5002_3_y, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao5002_3_y_loop, DirectionManager.MOVIE.bao5002_3_y, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0678, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0926, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE1, true, 1f, 19);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 79:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao5002_3_g, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao5002_3_g_loop, DirectionManager.MOVIE.bao5002_3_g, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0678, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0926, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE1, true, 1f, 19);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 80:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao5002_3_r, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao5002_3_r_loop, DirectionManager.MOVIE.bao5002_3_r, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0678, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0926, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0566, Sound.CH.SE1, true, 1f, 19);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 81:
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2025_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2025_sol_loop, DirectionManager.MOVIE.hsl2025_sol, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0486, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1045, Sound.CH.VC0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_131();
				break;
			case 82:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao5005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao5005_loop, DirectionManager.MOVIE.bao5005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0244, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0487, Sound.CH.SE1, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S0934, Sound.CH.VC0, true, 1f, 45);
				break;
			case 83:
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2025_sol, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2025_sol_loop, DirectionManager.MOVIE.hsl2025_sol, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0486, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S1045, Sound.CH.VC0, true, 1f, 72);
				break;
			case 85:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao7002_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao7002_a_loop, DirectionManager.MOVIE.bao7002_a, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1692, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0922, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE1, true, 1f, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 9);
				evt.eventSetCanPush(true, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, false, 0, 0, 80, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 23);
				break;
			case 86:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao7002_a_1, false, false, false, false, 0, 0, 100, 37);
				evt.eventAddMovie(DirectionManager.MOVIE.bao7002_a_1_loop, DirectionManager.MOVIE.bao7002_a_1, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1693, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 9);
				evt.eventSetCanPush(true, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, false, 0, 0, 80, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 23);
				break;
			case 87:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao7002_a_2, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao7002_a_2_loop, DirectionManager.MOVIE.bao7002_a_2, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1694, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 9);
				evt.eventSetCanPush(true, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, false, 0, 0, 80, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 23);
				break;
			case 88:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao7002_a_3, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bao7002_a_3_loop, DirectionManager.MOVIE.bao7002_a_3, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1695, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 9);
				evt.eventSetCanPush(true, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, false, 0, 0, 80, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 23);
				break;
			case 89:
				evt.eventPlayMovie(DirectionManager.MOVIE.bao7002_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0268, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0939, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0941, Sound.CH.VC1, true, 1f, 40);
				break;
			case 90:
				evt.eventDisableBefore(mng, 0);
				break;
			case 91:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.idi001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.idi001_loop, DirectionManager.MOVIE.idi001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0177, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0503, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1942, Sound.CH.VC0, true, 1f, 90);
				break;
			case 92:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbu001_chp, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0126, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 0);
				break;
			case 93:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbu001_mil, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0126, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 0);
				break;
			case 94:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbu001_bri, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0126, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 0);
				break;
			case 95:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbu001_zap, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0126, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 0);
				break;
			case 96:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0358, Sound.CH.SE1, true, 1f, 16);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_137();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_139();
				evt.eventPlayMovie(DirectionManager.MOVIE.btd003, false, false, false, true, 128, 72, 99, 11);
				evt.eventAddMovie(DirectionManager.MOVIE.btd003_loop, DirectionManager.MOVIE.btd003, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 98, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 97, 0);
				break;
			case 97:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 95, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE1, true, 1f, 16);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_143();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 98:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 95, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE1, true, 1f, 16);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_143();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 99:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 95, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE1, true, 1f, 16);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_143();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 100:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 95, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 16);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_147();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_149();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 101:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 95, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 16);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_147();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_149();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 102:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 95, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 16);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_147();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_149();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 103:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 95, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 16);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_153();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_155();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 104:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 95, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 16);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_153();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_155();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 105:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_158();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_160();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_50, false, false, true, false, 0, 0, 95, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_50_loop, DirectionManager.MOVIE.huc008_T_50, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE1, true, 1f, 88);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_147();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_149();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 106:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_158();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_160();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_100, false, false, true, false, 0, 0, 95, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_100_loop, DirectionManager.MOVIE.huc008_T_100, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE1, true, 1f, 88);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_147();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_149();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 107:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_158();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_160();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_150, false, false, true, false, 0, 0, 95, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_150_loop, DirectionManager.MOVIE.huc008_T_150, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE1, true, 1f, 88);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_147();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_149();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 108:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_164();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_166();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_200, false, false, true, false, 0, 0, 95, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_200_loop, DirectionManager.MOVIE.huc008_T_200, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE1, true, 1f, 88);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_153();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_155();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 109:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_164();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_166();
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_300, false, false, true, false, 0, 0, 95, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_300_loop, DirectionManager.MOVIE.huc008_T_300, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE1, true, 1f, 88);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_153();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_155();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 94, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 93, 0);
				break;
			case 110:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd002, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd002_loop, DirectionManager.MOVIE.yjd002, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0066, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 107);
				evt.eventPlaySound(DirectionManager.SOUND.S0119, Sound.CH.BGM, true, 1f, 157);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 99, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 98, 0);
				break;
			case 111:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd001, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd001_loop, DirectionManager.MOVIE.yjd001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0066, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 107);
				evt.eventPlaySound(DirectionManager.SOUND.S0117, Sound.CH.BGM, true, 1f, 157);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 99, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 98, 0);
				break;
			case 112:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd006, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd006_loop, DirectionManager.MOVIE.yjd006, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0074, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0358, Sound.CH.SE1, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 150);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 99, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 98, 0);
				break;
			case 113:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd003, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd003_loop, DirectionManager.MOVIE.yjd003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0066, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 107);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE1, true, 1f, 127);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 99, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 98, 0);
				break;
			case 114:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd007, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd007_loop, DirectionManager.MOVIE.yjd007, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0074, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0358, Sound.CH.SE0, true, 1f, 77);
				evt.eventPlaySound(DirectionManager.SOUND.S0215, Sound.CH.SE1, true, 1f, 77);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 150);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 99, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 98, 0);
				break;
			case 115:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd003, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd003_loop, DirectionManager.MOVIE.yjd003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0066, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 107);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE1, true, 1f, 127);
				break;
			case 116:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd008, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd008_loop, DirectionManager.MOVIE.yjd008, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0066, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0205, Sound.CH.BGM, false, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0358, Sound.CH.SE1, true, 1f, 110);
				break;
			case 117:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd008, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd008_loop, DirectionManager.MOVIE.yjd008, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0066, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0205, Sound.CH.BGM, false, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0358, Sound.CH.SE1, true, 1f, 110);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 99, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 98, 0);
				break;
			case 118:
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn_sv_end, false, false, false, false, 0, 0, 60, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn_sv_end_loop, DirectionManager.MOVIE.cmn_sv_end, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0580, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn_sv_end_add, false, false, true, false, 0, 0, 59, 0);
				break;
			case 119:
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl600_sla, true, false, false, false, 0, 0, 100, 8);
				evt.eventPlaySound(DirectionManager.SOUND.S0254, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1949, Sound.CH.VC0, true, 1f, 6);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl600_sla_add, true, false, true, false, 0, 0, 99, 0);
				break;
			case 120:
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl600_per, true, false, false, false, 0, 0, 100, 8);
				evt.eventPlaySound(DirectionManager.SOUND.S0255, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1951, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl600_per_add, true, false, true, false, 0, 0, 99, 0);
				break;
			case 121:
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl600_des, true, false, false, false, 0, 0, 100, 8);
				evt.eventPlaySound(DirectionManager.SOUND.S0256, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1950, Sound.CH.VC0, true, 1f, 9);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl600_des, true, false, false, false, 0, 0, 99, 8);
				break;
			case 122:
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl600_cle, true, false, false, false, 0, 0, 100, 8);
				evt.eventPlaySound(DirectionManager.SOUND.S0257, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1967, Sound.CH.VC0, true, 1f, 7);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl600_cle_add, true, false, true, false, 0, 0, 99, 0);
				break;
			}
			break;
		case 1:
			switch (mode)
			{
			case 3:
				Direction3MST.lamp_0_1();
				Direction3MST.start_0_1(evt, mng);
				break;
			case 5:
				Direction5CST.lamp_0_1();
				Direction5CST.start_0_1(evt, mng);
				break;
			case 18:
				Direction18JST.lamp_0_1();
				Direction18JST.start_0_1(evt, mng);
				break;
			case 23:
				Direction23AST.lamp_0_1();
				Direction23AST.start_0_1(evt, mng, m_Dir);
				break;
			case 24:
				Direction23AST.lamp_X_X();
				Direction23AST.start_X_X(evt, mng, m_Dir);
				break;
			case 32:
				Direction33DST.lamp_0_1();
				Direction33DST.start_0_1(evt, mng);
				break;
			case 59:
				Direction61RST.start_0_1(evt, mng);
				break;
			case 89:
				Direction93BGT.lamp_0_1();
				Direction93BGT.start_0_1(evt, mng);
				break;
			}
			break;
		case 2:
			switch (mode)
			{
			case 59:
				evt.eventPlayMovie(DirectionManager.MOVIE.rst001_d, false, true, false, false, 0, 0, 198, 0);
				evt.eventResumeMovie(DirectionManager.MOVIE.rst001_a, 0);
				break;
			case 1:
				evt.eventPlayMovie(DirectionManager.MOVIE.mst001_sin_a, false, true, false, true, MainGameScene.dir3MST_Sub.getPosSin(), (int)Direction3MST_Sub.POS_SIN_Y, Direction3MST_Sub.LAYER_SIN, 0);
				break;
			case 2:
				evt.eventPlayMovie(DirectionManager.MOVIE.mst001_sol_a, false, true, false, true, MainGameScene.dir3MST_Sub.getPosSol(), (int)Direction3MST_Sub.POS_SOL_Y, Direction3MST_Sub.LAYER_SOL, 0);
				break;
			case 3:
				evt.eventPlayMovie(DirectionManager.MOVIE.mst001_sol_a, false, true, false, true, MainGameScene.dir3MST_Sub.getPosSol(), (int)Direction3MST_Sub.POS_SOL_Y, Direction3MST_Sub.LAYER_SOL, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mst001_sol_a_nml2, false, false, false, true, MainGameScene.dir3MST_Sub.getPosJYD(), (int)Direction3MST_Sub.POS_JYD_Y, Direction3MST_Sub.LAYER_JYD, 0);
				break;
			case 4:
				evt.eventPlayMovie(DirectionManager.MOVIE.mst001_sin_a, false, true, false, true, MainGameScene.dir3MST_Sub.getPosSin(), (int)Direction3MST_Sub.POS_SIN_Y, Direction3MST_Sub.LAYER_SIN, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mst001_sol_a, false, true, false, true, MainGameScene.dir3MST_Sub.getPosSol(), (int)Direction3MST_Sub.POS_SOL_Y, Direction3MST_Sub.LAYER_SOL, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.mst001_sol_a_nml2, false, false, false, true, MainGameScene.dir3MST_Sub.getPosJYD(), (int)Direction3MST_Sub.POS_JYD_Y, Direction3MST_Sub.LAYER_JYD, 0);
				break;
			case 5:
				evt.eventPlayMovie(DirectionManager.MOVIE.chk001_1, false, false, false, false, 0, 0, 199, 0);
				break;
			}
			break;
		case 3:
			switch (mode)
			{
			case 5:
				evt.eventPlaySound(DirectionManager.SOUND.S0107, Sound.CH.BGM, true, 1f, 0);
				break;
			}
			break;
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 2:
				switch (MainGameScene.slotGameMan.m_dirData[45])
				{
				case 0:
				case 1:
				case 2:
					DirectionLedManager.OFF_1(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
					DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
					DirectionLedManager.OFF_3(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
					DirectionLedManager.OFF_4(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
					DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
					DirectionLedManager.OFF_6(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
					DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
					DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
					DirectionLedManager.OFF_2m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
					DirectionLedManager.init(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
					DirectionLedManager.init(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_5M));
					MainGameScene.ledPanelMan.stop(LEDPanelManager.LINE.LAYER_3M);
					MainGameScene.ledPanelMan.stop(LEDPanelManager.LINE.LAYER_5M);
					break;
				default:
					DirectionLedManager.init(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
					DirectionLedManager.init(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_5M));
					MainGameScene.ledPanelMan.stop(LEDPanelManager.LINE.LAYER_3M);
					MainGameScene.ledPanelMan.stop(LEDPanelManager.LINE.LAYER_5M);
					break;
				case 15:
				case 16:
				case 17:
				case 18:
					break;
				}
				break;
			case 4:
				DirectionLedManager.GH_HOH(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				DirectionLedManager.GH_HOH_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.GD_black(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_HOH(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_HOH(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_5M));
				break;
			case 5:
				DirectionLedManager.GH_JST(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 7:
				DirectionLedManager.GH_BD_ready(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				DirectionLedManager.OFF_3(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.OFF_4(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_6(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
				DirectionLedManager.OFF_9(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_1));
				DirectionLedManager.OFF_10(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_2));
				DirectionLedManager.OFF_11(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_3));
				DirectionLedManager.OFF_12(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_4));
				DirectionLedManager.OFF_13(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_5));
				DirectionLedManager.OFF_14(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_6));
				DirectionLedManager.OFF_15(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_DI));
				DirectionLedManager.OFF_16(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DEMO));
				DirectionLedManager.OFF_2m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 11:
				DirectionLedManager.GH_HOH(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				DirectionLedManager.GH_HOH_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.GD_black(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_HOH(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_HOH(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_5M));
				break;
			case 17:
				DirectionLedManager.SE_KSY_close_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_KSY_close(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 19:
				DirectionLedManager.LG_HOH_sol_first_low_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 20:
				DirectionLedManager.YK_ND_ready(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 21:
				DirectionLedManager.LG_HOH_sol_first_high_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 22:
				DirectionLedManager.GD_HOH_psych_cutin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_HOH_psych_cutin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
				DirectionLedManager.OFF_9(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_1));
				DirectionLedManager.OFF_10(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_2));
				DirectionLedManager.OFF_11(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_3));
				DirectionLedManager.OFF_12(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_4));
				DirectionLedManager.OFF_13(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_5));
				DirectionLedManager.OFF_14(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_6));
				DirectionLedManager.OFF_15(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_DI));
				DirectionLedManager.OFF_16(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DEMO));
				break;
			case 23:
				DirectionLedManager.YK_AIG_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 24:
				DirectionLedManager.YK_AIG_02_miss(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.OFF_5m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_6M));
				break;
			case 28:
				DirectionLedManager.OFF_1(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
				DirectionLedManager.OFF_2m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 29:
				DirectionLedManager.OFF_1(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
				DirectionLedManager.OFF_2m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 30:
				DirectionLedManager.OFF_1(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
				DirectionLedManager.OFF_2m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 35:
				DirectionLedManager.OFF_2m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				DirectionLedManager.init(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				DirectionLedManager.init(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_5M));
				MainGameScene.ledPanelMan.stop(LEDPanelManager.LINE.LAYER_3M);
				MainGameScene.ledPanelMan.stop(LEDPanelManager.LINE.LAYER_5M);
				break;
			case 43:
				DirectionLedManager.OFF_2m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				DirectionLedManager.init(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				DirectionLedManager.init(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_5M));
				MainGameScene.ledPanelMan.stop(LEDPanelManager.LINE.LAYER_3M);
				MainGameScene.ledPanelMan.stop(LEDPanelManager.LINE.LAYER_5M);
				break;
			case 81:
				DirectionLedManager.YK_AIG_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 82:
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_dest_04(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_6M));
				break;
			case 91:
				DirectionLedManager.m_panel_DI_in(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_6M));
				break;
			case 92:
				DirectionLedManager.JG_KBU_CP(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.YK_KBU_CP(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 93:
				DirectionLedManager.JG_KBU_ML(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.YK_KBU_ML(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 94:
				DirectionLedManager.JG_KBU_BJ(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.YK_KBU_BJ(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 95:
				DirectionLedManager.JG_KBU_ZP(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.YK_KBU_ZP(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 116:
				DirectionLedManager.OFF_4m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_5M));
				break;
			case 117:
				DirectionLedManager.OFF_4m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_5M));
				break;
			case 119:
				DirectionLedManager.YK_HOH_slash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 120:
				DirectionLedManager.YK_HOH_slash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 121:
				DirectionLedManager.YK_HOH_slash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 122:
				DirectionLedManager.YK_HOH_slash(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			}
		}
		if (low == 0 && mode == 118)
		{
			survivalEnd();
		}
		base.start();
	}

	public void survivalEnd()
	{
		int num = MainGameScene.slotGameMan.get_pkd_data(91);
		DirectionManager.MOVIE[] array = new DirectionManager.MOVIE[10]
		{
			DirectionManager.MOVIE.cmn_sv_End_0a,
			DirectionManager.MOVIE.cmn_sv_end_1a,
			DirectionManager.MOVIE.cmn_sv_end_2a,
			DirectionManager.MOVIE.cmn_sv_end_3a,
			DirectionManager.MOVIE.cmn_sv_end_4a,
			DirectionManager.MOVIE.cmn_sv_end_5a,
			DirectionManager.MOVIE.cmn_sv_end_6a,
			DirectionManager.MOVIE.cmn_sv_end_7a,
			DirectionManager.MOVIE.cmn_sv_end_8a,
			DirectionManager.MOVIE.cmn_sv_end_9a
		};
		if (num >= 0)
		{
			if (num > 99)
			{
				num = 99;
			}
			int num2 = num % 10;
			int num3 = num / 10;
			if (num3 == 0)
			{
				evt.eventPlayMovie(array[num2], false, false, false, true, 151, 99, 58, 0);
			}
			else
			{
				evt.eventPlayMovie(array[num3], false, false, false, true, 151, 99, 58, 0);
				evt.eventPlayMovie(array[num2], false, false, false, true, 181, 99, 57, 0);
			}
			MainGameScene.dirMan.changeStageIntarface(11);
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
