public class Direction87YFC : DirectionBase
{
	public Direction87YFC(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		base.start();
		if (low == 0)
		{
			byte b = mode;
			if (b == 100)
			{
				int num = MainGameScene.slotGameMan.get_pkd_data(563);
				if (num >= 1)
				{
					evt.eventPlayAnime(DirectionManager.ANIME.YFC002, 1, false, false, false, true, 128, 72, -11, 0);
				}
				if (num >= 2)
				{
					evt.eventPlayAnime(DirectionManager.ANIME.YFC003, 1, false, false, false, true, 128, 72, -10, 0);
				}
				if (num >= 3)
				{
					evt.eventPlayAnime(DirectionManager.ANIME.YFC004, 1, false, false, false, true, 128, 72, -12, 0);
				}
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				evt.eventPlayMovie(DirectionManager.MOVIE.yfc001_white, false, false, true, false, 0, 0, 50, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0412, Sound.CH.SE0, true, 1f, 0);
				break;
			case 2:
				evt.eventPlayMovie(DirectionManager.MOVIE.yfc001_blue, false, false, true, false, 0, 0, 50, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0412, Sound.CH.SE0, true, 1f, 0);
				break;
			case 3:
				evt.eventPlayMovie(DirectionManager.MOVIE.yfc001_yellow, false, false, true, false, 0, 0, 50, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0413, Sound.CH.SE0, true, 1f, 0);
				break;
			case 4:
				evt.eventPlayMovie(DirectionManager.MOVIE.yfc001_green, false, false, true, false, 0, 0, 50, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0414, Sound.CH.SE0, true, 1f, 0);
				break;
			case 5:
				evt.eventPlayMovie(DirectionManager.MOVIE.yfc001_red, false, false, true, false, 0, 0, 50, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0415, Sound.CH.SE0, true, 1f, 0);
				break;
			case 6:
				evt.eventPlayMovie(DirectionManager.MOVIE.yfc001_rainbow, false, false, true, false, 0, 0, 50, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0415, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0217, Sound.CH.SE1, true, 1f, 0);
				break;
			case 13:
				evt.eventPlayAnime(DirectionManager.ANIME.YFC002, 0, false, false, false, true, 128, 72, -11, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0088, Sound.CH.SE1, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1536();
				evt.eventPlaySound(DirectionManager.SOUND.S0062, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0063, Sound.CH.SE0, true, 1f, 60);
				break;
			case 14:
				evt.eventPlayAnime(DirectionManager.ANIME.YFC003, 0, false, false, false, true, 128, 72, -10, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0088, Sound.CH.SE1, true, 1f, 0);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1536();
				evt.eventPlaySound(DirectionManager.SOUND.S0062, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0063, Sound.CH.SE0, true, 1f, 60);
				break;
			case 15:
				evt.eventPlayAnime(DirectionManager.ANIME.YFC004, 0, false, false, false, true, 128, 72, -12, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0088, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0088, Sound.CH.SE1, true, 1f, 19);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1536();
				evt.eventPlaySound(DirectionManager.SOUND.S0062, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0063, Sound.CH.SE0, true, 1f, 60);
				break;
			case 16:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yfc006_cutin, false, false, false, false, 0, 0, 50, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yfc006_cutin_loop, DirectionManager.MOVIE.yfc006_cutin, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0495, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1049, Sound.CH.VC0, true, 1f, 13);
				MainGameScene.dirMan.StopDirection(DirectionManager.DIR.LEVER_2);
				MainGameScene.dirMan.StopDirection(DirectionManager.DIR.REEL_2);
				MainGameScene.dirMan.StopDirection(DirectionManager.DIR.STOP1_2);
				MainGameScene.dirMan.StopDirection(DirectionManager.DIR.STOP2_2);
				MainGameScene.dirMan.StopDirection(DirectionManager.DIR.STOP3_2);
				MainGameScene.dirMan.StopDirection(DirectionManager.DIR.STOP3OFF_2);
				MainGameScene.dirMan.StopDirection(DirectionManager.DIR.BET_2);
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
				DirectionLedManager.GD_YFC_blue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 3:
				break;
			case 4:
				DirectionLedManager.GD_YFC_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 5:
				DirectionLedManager.GD_YFC_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 6:
				DirectionLedManager.GD_YFC_rainbow(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
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
				DirectionLedManager.GD_YFC_chain_04(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 13:
				DirectionLedManager.GD_YFC_chain_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 14:
				DirectionLedManager.GD_YFC_chain_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 15:
				DirectionLedManager.GD_YFC_chain_03(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 16:
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
