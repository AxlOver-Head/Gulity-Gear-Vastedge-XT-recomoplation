public class Direction84PUS : DirectionBase
{
	public Direction84PUS(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		base.start();
		if (14 <= mode && mode <= 27)
		{
			evt.eventDisableBefore(mng, 0);
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 100, 9);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S1448, Sound.CH.SE0, true, 1f, 0);
				break;
			case 2:
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy000_1, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0236, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1400();
				break;
			case 3:
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b, false, false, false, false, 0, 0, 100, 9);
				evt.eventAddMovie(DirectionManager.MOVIE.push_b_loop, DirectionManager.MOVIE.push_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1449, Sound.CH.SE0, true, 1f, 0);
				break;
			case 5:
				evt.eventPlayMovie(DirectionManager.MOVIE.psu005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.psu005_loop, DirectionManager.MOVIE.psu005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0538, Sound.CH.SE0, true, 1f, 0);
				break;
			case 6:
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 100, 0);
				break;
			case 7:
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b_hit, true, false, false, false, 0, 0, 100, 0);
				break;
			case 9:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbu001_sly, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0126, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 0);
				break;
			case 10:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbu001_chp, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0126, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 0);
				break;
			case 11:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbu001_mil, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0126, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 0);
				break;
			case 12:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbu001_bri, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0126, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 0);
				break;
			case 13:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kbu001_zap, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0126, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 0);
				break;
			case 14:
				evt.eventPlayMovie(DirectionManager.MOVIE.psu010, false, true, false, true, 128, 67, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1450, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 8);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 9);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S1448, Sound.CH.SE0, true, 1f, 0);
				break;
			case 15:
				evt.eventPlayMovie(DirectionManager.MOVIE.psu010_play, false, false, false, true, 128, 67, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1458, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1459, Sound.CH.VC0, true, 1f, 135);
				break;
			case 16:
				evt.eventPlayMovie(DirectionManager.MOVIE.psu011, false, false, false, true, 128, 67, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1451, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 14);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S1448, Sound.CH.SE0, true, 1f, 14);
				break;
			case 17:
				evt.eventPlayMovie(DirectionManager.MOVIE.psu011_play, false, false, false, true, 128, 67, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1458, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1459, Sound.CH.VC0, true, 1f, 80);
				break;
			case 18:
				evt.eventPlayMovie(DirectionManager.MOVIE.psu012, false, false, false, true, 128, 67, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1452, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 14);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S1448, Sound.CH.SE0, true, 1f, 14);
				break;
			case 19:
				evt.eventPlayMovie(DirectionManager.MOVIE.psu012_play, false, false, false, true, 128, 67, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1458, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1459, Sound.CH.VC0, true, 1f, 135);
				break;
			case 20:
				evt.eventPlayMovie(DirectionManager.MOVIE.psu013_play, false, false, false, true, 128, 65, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1453, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1459, Sound.CH.VC0, true, 1f, 143);
				break;
			case 21:
				evt.eventPlayMovie(DirectionManager.MOVIE.psu020, false, true, false, true, 128, 67, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1454, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 14);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S1448, Sound.CH.SE0, true, 1f, 14);
				break;
			case 22:
				evt.eventPlayMovie(DirectionManager.MOVIE.psu020_play, false, false, false, true, 128, 67, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1458, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1459, Sound.CH.VC0, true, 1f, 122);
				break;
			case 23:
				evt.eventPlayMovie(DirectionManager.MOVIE.psu021, false, false, false, true, 128, 67, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1455, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 14);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S1448, Sound.CH.SE0, true, 1f, 14);
				break;
			case 24:
				evt.eventPlayMovie(DirectionManager.MOVIE.psu021_play, false, false, false, true, 128, 67, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1458, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1459, Sound.CH.VC0, true, 1f, 154);
				break;
			case 25:
				evt.eventPlayMovie(DirectionManager.MOVIE.psu022, false, false, false, true, 128, 67, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1456, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 14);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlaySound(DirectionManager.SOUND.S1448, Sound.CH.SE0, true, 1f, 14);
				break;
			case 26:
				evt.eventPlayMovie(DirectionManager.MOVIE.psu022_play, false, false, false, true, 128, 67, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1458, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1459, Sound.CH.VC0, true, 1f, 135);
				break;
			case 27:
				evt.eventPlayMovie(DirectionManager.MOVIE.psu023_play, false, false, false, true, 128, 65, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1457, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1459, Sound.CH.VC0, true, 1f, 165);
				break;
			case 28:
				evt.eventPlayMovie(DirectionManager.MOVIE.psu005_dai, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.psu005_dai_loop, DirectionManager.MOVIE.psu005_dai, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0538, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0215, Sound.CH.VC0, true, 1f, 19);
				break;
			case 29:
				evt.eventPlayMovie(DirectionManager.MOVIE.psu005, false, false, false, false, 0, 0, 100, 0);
				break;
			case 30:
				evt.eventPlayMovie(DirectionManager.MOVIE.kbu001_sly, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0126, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				break;
			case 31:
				evt.eventPlayMovie(DirectionManager.MOVIE.kbu001_chp, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0126, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				break;
			case 32:
				evt.eventPlayMovie(DirectionManager.MOVIE.kbu001_mil, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0126, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				break;
			case 33:
				evt.eventPlayMovie(DirectionManager.MOVIE.kbu001_bri, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0126, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				break;
			case 34:
				evt.eventPlayMovie(DirectionManager.MOVIE.kbu001_zap, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0126, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				break;
			case 35:
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 3, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd002, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd002_loop, DirectionManager.MOVIE.yjd002, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0066, Sound.CH.SE1, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 107);
				evt.eventPlaySound(DirectionManager.SOUND.S0119, Sound.CH.BGM, true, 1f, 157);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 2, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 1, 0);
				break;
			case 36:
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 3, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd001, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd001_loop, DirectionManager.MOVIE.yjd001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0066, Sound.CH.SE1, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 107);
				evt.eventPlaySound(DirectionManager.SOUND.S0117, Sound.CH.BGM, true, 1f, 157);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 2, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 1, 0);
				break;
			case 37:
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 3, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd006, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd006_loop, DirectionManager.MOVIE.yjd006, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0074, Sound.CH.SE1, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0358, Sound.CH.SE1, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 150);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 2, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 1, 0);
				break;
			case 38:
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 3, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd003, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd003_loop, DirectionManager.MOVIE.yjd003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0066, Sound.CH.SE1, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 107);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE1, true, 1f, 127);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 2, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 1, 0);
				break;
			case 39:
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 3, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd007, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd007_loop, DirectionManager.MOVIE.yjd007, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0074, Sound.CH.SE1, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0358, Sound.CH.SE0, true, 1f, 77);
				evt.eventPlaySound(DirectionManager.SOUND.S0215, Sound.CH.SE1, true, 1f, 77);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 150);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 2, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 1, 0);
				break;
			case 40:
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 3, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd008, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd008_loop, DirectionManager.MOVIE.yjd008, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0066, Sound.CH.SE1, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0205, Sound.CH.BGM, false, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0358, Sound.CH.SE1, true, 1f, 110);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 2, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 1, 0);
				break;
			case 41:
				evt.eventPlayMovie(DirectionManager.MOVIE.psu010, false, true, false, true, 128, 67, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1450, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 8);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b, false, false, false, false, 0, 0, 90, 14);
				evt.eventAddMovie(DirectionManager.MOVIE.push_b_loop, DirectionManager.MOVIE.push_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1449, Sound.CH.SE0, true, 1f, 14);
				break;
			case 42:
				evt.eventPlayMovie(DirectionManager.MOVIE.psu020_play, false, false, false, true, 128, 67, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1454, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_b, false, false, false, false, 0, 0, 90, 14);
				evt.eventAddMovie(DirectionManager.MOVIE.push_b_loop, DirectionManager.MOVIE.push_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1449, Sound.CH.SE0, true, 1f, 14);
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
				DirectionLedManager.GD_KSY_close(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 3:
				break;
			case 5:
				break;
			case 6:
				break;
			case 7:
				break;
			case 9:
				DirectionLedManager.JG_KBU_SL(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.YK_KBU_SL(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 10:
				DirectionLedManager.JG_KBU_CP(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.YK_KBU_CP(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 11:
				DirectionLedManager.JG_KBU_ML(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.YK_KBU_ML(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 12:
				DirectionLedManager.JG_KBU_BJ(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.YK_KBU_BJ(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 13:
				DirectionLedManager.JG_KBU_ZP(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.YK_KBU_ZP(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
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
				DirectionLedManager.JG_KBU_SL(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.YK_KBU_SL(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 31:
				DirectionLedManager.JG_KBU_CP(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.YK_KBU_CP(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 32:
				DirectionLedManager.JG_KBU_ML(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.YK_KBU_ML(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 33:
				DirectionLedManager.JG_KBU_BJ(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.YK_KBU_BJ(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 34:
				DirectionLedManager.JG_KBU_ZP(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.YK_KBU_ZP(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 35:
				break;
			case 36:
				break;
			case 37:
				break;
			case 38:
				break;
			case 39:
				break;
			case 40:
				break;
			case 41:
				break;
			case 42:
				break;
			case 4:
			case 8:
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
