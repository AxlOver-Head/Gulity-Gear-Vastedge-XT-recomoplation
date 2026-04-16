public class Direction75BM1 : DirectionBase
{
	public Direction75BM1(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventPlayMovie(DirectionManager.MOVIE.bm1001, false, true, false, false, 0, 0, 199, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1505, Sound.CH.SE0, true, 1f, 0);
				restartBGM();
				break;
			case 2:
				evt.eventPlaySound(DirectionManager.SOUND.S1506, Sound.CH.SE0, true, 1f, 0);
				break;
			case 3:
				evt.eventPlaySound(DirectionManager.SOUND.S1507, Sound.CH.SE0, true, 1f, 0);
				break;
			case 4:
				evt.eventPlaySound(DirectionManager.SOUND.S1508, Sound.CH.SE0, true, 1f, 0);
				break;
			case 5:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1352();
				evt.eventPlaySound(DirectionManager.SOUND.S1509, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bm1002_1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bm1002_1_loop, DirectionManager.MOVIE.bm1002_1, false, true, false, false);
				break;
			case 6:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1356();
				evt.eventPlaySound(DirectionManager.SOUND.S1557, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bm1002_2, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bm1002_2_loop, DirectionManager.MOVIE.bm1002_2, false, true, false, false);
				break;
			case 7:
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1360();
				evt.eventPlaySound(DirectionManager.SOUND.S1558, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bm1002_3, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bm1002_3_loop, DirectionManager.MOVIE.bm1002_3, false, true, false, false);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
				break;
			case 5:
				DirectionLedManager.GD_BM1_GET_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 6:
				DirectionLedManager.GD_BM1_GET_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 7:
				DirectionLedManager.GD_BM1_GET_03(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			}
		}
		if (low == 0)
		{
			int idx = MainGameScene.slotGameMan.get_pkd_data(494) - 1;
			switch (mode)
			{
			case 5:
				MainGameScene.pnlMan.onCartridge(idx, 0);
				break;
			case 6:
				MainGameScene.pnlMan.onCartridge(idx, 1);
				break;
			case 7:
				MainGameScene.pnlMan.onCartridge(idx, 2);
				break;
			}
		}
	}

	public static void restartBGM()
	{
		if (SGLG.sound.getBGMID() == 55)
		{
			if (SGLG.sound.getBGMVolume() < 1f)
			{
				SGLG.sound.SetVolume(Sound.CH.BGM, 1f);
			}
		}
		else
		{
			SGLG.sound.PlaySound(55, Sound.CH.BGM, true);
			SGLG.sound.SetVolume(Sound.CH.BGM, 1f);
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
