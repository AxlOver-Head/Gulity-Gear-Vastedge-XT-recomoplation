public class Direction90YTK : DirectionBase
{
	public Direction90YTK(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk001_A_white, true, false, true, true, 128, 60, 59, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1600();
				break;
			case 2:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk001_A_blue, true, false, true, true, 128, 60, 59, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1600();
				break;
			case 3:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk001_A_yellow, true, false, true, true, 128, 60, 59, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1600();
				break;
			case 4:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk001_A_green, true, false, true, true, 128, 60, 59, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1600();
				break;
			case 5:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk001_A_red, true, false, true, true, 128, 60, 59, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1600();
				break;
			case 6:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk001_A_purple, true, false, true, true, 128, 60, 59, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1600();
				break;
			case 7:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk001_A_normal, true, false, true, true, 128, 60, 59, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1600();
				break;
			case 8:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk001_B_white, true, false, true, false, 0, 0, 59, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1604();
				break;
			case 9:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk001_B_blue, true, false, true, false, 0, 0, 59, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1604();
				break;
			case 10:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk001_B_yellow, true, false, true, false, 0, 0, 59, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1604();
				break;
			case 11:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk001_B_green, true, false, true, false, 0, 0, 59, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1604();
				break;
			case 12:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk001_B_red, true, false, true, false, 0, 0, 59, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1604();
				break;
			case 13:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk001_B_purple, true, false, true, false, 0, 0, 59, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1604();
				break;
			case 14:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk001_B_normal, true, false, true, false, 0, 0, 59, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1604();
				break;
			case 15:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk004_D_white, false, true, true, true, 25, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0069, Sound.CH.SE0, true, 1f, 0);
				break;
			case 16:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk004_D_blue, false, true, true, true, 25, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0069, Sound.CH.SE0, true, 1f, 0);
				break;
			case 17:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk004_D_yellow, false, true, true, true, 25, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0069, Sound.CH.SE0, true, 1f, 0);
				break;
			case 18:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk004_D_green, false, true, true, true, 25, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0069, Sound.CH.SE0, true, 1f, 0);
				break;
			case 19:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk004_D_red, false, true, true, true, 25, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0069, Sound.CH.SE0, true, 1f, 0);
				break;
			case 20:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk004_D_purple, false, true, true, true, 25, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0069, Sound.CH.SE0, true, 1f, 0);
				break;
			case 21:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk004_D_normal, false, true, true, true, 25, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0069, Sound.CH.SE0, true, 1f, 0);
				break;
			case 22:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk004_E_white, false, true, true, true, 100, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0069, Sound.CH.SE0, true, 1f, 0);
				break;
			case 23:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk004_E_blue, false, true, true, true, 100, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0069, Sound.CH.SE0, true, 1f, 0);
				break;
			case 24:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk004_E_yellow, false, true, true, true, 100, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0069, Sound.CH.SE0, true, 1f, 0);
				break;
			case 25:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk004_E_green, false, true, true, true, 100, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0069, Sound.CH.SE0, true, 1f, 0);
				break;
			case 26:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk004_E_red, false, true, true, true, 100, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0069, Sound.CH.SE0, true, 1f, 0);
				break;
			case 27:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk004_E_purple, false, true, true, true, 100, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0069, Sound.CH.SE0, true, 1f, 0);
				break;
			case 28:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk004_E_normal, false, true, true, true, 100, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0069, Sound.CH.SE0, true, 1f, 0);
				break;
			case 31:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk003_B, false, false, true, true, 196, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0064, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1622();
				break;
			case 32:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk003_C, false, false, true, true, 196, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0064, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0064, Sound.CH.SE0, true, 1f, 12);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1626();
				break;
			case 33:
				evt.eventPlaySound(DirectionManager.SOUND.S0095, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1629();
				break;
			case 34:
				evt.eventPlaySound(DirectionManager.SOUND.S0094, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1633();
				break;
			case 39:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1654();
				break;
			case 40:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1656();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1658();
				break;
			case 41:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1660();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1662();
				break;
			case 54:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk003_A_blue, false, false, true, true, 171, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0064, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1622();
				break;
			case 55:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk003_A_yellow, false, false, true, true, 171, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0064, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1622();
				break;
			case 56:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk003_A_green, false, false, true, true, 171, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0064, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1622();
				break;
			case 57:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk003_A_red, false, false, true, true, 171, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0064, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1622();
				break;
			case 58:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk003_A_purple, false, false, true, true, 171, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0064, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1622();
				break;
			case 59:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk003_A_normal, false, false, true, true, 171, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0064, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1622();
				break;
			case 60:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk003_A_blue, false, false, true, true, 171, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0064, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0064, Sound.CH.SE0, true, 1f, 12);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1626();
				break;
			case 61:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk003_A_yellow, false, false, true, true, 171, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0064, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0064, Sound.CH.SE0, true, 1f, 12);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1626();
				break;
			case 62:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk003_A_green, false, false, true, true, 171, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0064, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0064, Sound.CH.SE0, true, 1f, 12);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1626();
				break;
			case 63:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk003_A_red, false, false, true, true, 171, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0064, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0064, Sound.CH.SE0, true, 1f, 12);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1626();
				break;
			case 64:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk003_A_purple, false, false, true, true, 171, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0064, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0064, Sound.CH.SE0, true, 1f, 12);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1626();
				break;
			case 65:
				evt.eventPlayMovie(DirectionManager.MOVIE.ytk003_A_normal, false, false, true, true, 171, 72, 59, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0064, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0064, Sound.CH.SE0, true, 1f, 12);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1626();
				break;
			case 66:
				evt.eventPlaySound(DirectionManager.SOUND.S0095, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1629();
				break;
			case 67:
				evt.eventPlaySound(DirectionManager.SOUND.S0095, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1629();
				break;
			case 68:
				evt.eventPlaySound(DirectionManager.SOUND.S0095, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1629();
				break;
			case 69:
				evt.eventPlaySound(DirectionManager.SOUND.S0095, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1629();
				break;
			case 70:
				evt.eventPlaySound(DirectionManager.SOUND.S0095, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1629();
				break;
			case 71:
				evt.eventPlaySound(DirectionManager.SOUND.S0095, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1629();
				break;
			case 72:
				evt.eventPlaySound(DirectionManager.SOUND.S0094, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1633();
				break;
			case 73:
				evt.eventPlaySound(DirectionManager.SOUND.S0094, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1633();
				break;
			case 74:
				evt.eventPlaySound(DirectionManager.SOUND.S0094, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1633();
				break;
			case 75:
				evt.eventPlaySound(DirectionManager.SOUND.S0094, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1633();
				break;
			case 76:
				evt.eventPlaySound(DirectionManager.SOUND.S0094, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1633();
				break;
			case 77:
				evt.eventPlaySound(DirectionManager.SOUND.S0094, Sound.CH.SE0, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1633();
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.LG_YTK_white_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 2:
				DirectionLedManager.LG_YTK_blue_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 3:
				DirectionLedManager.LG_YTK_yellow_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 4:
				DirectionLedManager.LG_YTK_green_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 5:
				DirectionLedManager.LG_YTK_red_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 6:
				DirectionLedManager.LG_YTK_purple_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 7:
				DirectionLedManager.LG_YTK_rainbow_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 8:
				DirectionLedManager.LG_YTK_white_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 9:
				DirectionLedManager.LG_YTK_blue_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 10:
				DirectionLedManager.LG_YTK_yellow_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 11:
				DirectionLedManager.LG_YTK_green_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 12:
				DirectionLedManager.LG_YTK_red_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 13:
				DirectionLedManager.LG_YTK_purple_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 14:
				DirectionLedManager.LG_YTK_rainbow_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				break;
			case 15:
				DirectionLedManager.CG_YTK_white_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 16:
				DirectionLedManager.CG_YTK_blue_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 17:
				DirectionLedManager.CG_YTK_yellow_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 18:
				DirectionLedManager.CG_YTK_green_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 19:
				DirectionLedManager.CG_YTK_red_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 20:
				DirectionLedManager.CG_YTK_purple_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 21:
				DirectionLedManager.CG_YTK_rainbow_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 22:
				DirectionLedManager.CG_YTK_white_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 23:
				DirectionLedManager.CG_YTK_blue_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 24:
				DirectionLedManager.CG_YTK_yellow_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 25:
				DirectionLedManager.CG_YTK_green_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 26:
				DirectionLedManager.CG_YTK_red_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 27:
				DirectionLedManager.CG_YTK_purple_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 28:
				DirectionLedManager.CG_YTK_rainbow_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				break;
			case 31:
				DirectionLedManager.GD_YTK_swing_white_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 32:
				DirectionLedManager.GD_YTK_swing_white_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 54:
				DirectionLedManager.GD_YTK_swing_blue_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 55:
				DirectionLedManager.GD_YTK_swing_yellow_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 56:
				DirectionLedManager.GD_YTK_swing_green_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 57:
				DirectionLedManager.GD_YTK_swing_red_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 58:
				DirectionLedManager.GD_YTK_swing_purple_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 59:
				DirectionLedManager.GD_YTK_swing_rainbow_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 60:
				DirectionLedManager.GD_YTK_swing_blue_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 61:
				DirectionLedManager.GD_YTK_swing_yellow_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 62:
				DirectionLedManager.GD_YTK_swing_green_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 63:
				DirectionLedManager.GD_YTK_swing_red_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 64:
				DirectionLedManager.GD_YTK_swing_purple_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 65:
				DirectionLedManager.GD_YTK_swing_rainbow_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
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
