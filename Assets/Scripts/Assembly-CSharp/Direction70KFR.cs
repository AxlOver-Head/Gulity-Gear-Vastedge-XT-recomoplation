public class Direction70KFR : DirectionBase
{
	public Direction70KFR(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kfr001, false, false, false, false, 0, 0, 199, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kfr001_loop, DirectionManager.MOVIE.kfr001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0120, Sound.CH.BGM, false, 1f, 219);
				evt.eventPlaySound(DirectionManager.SOUND.S0336, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1348, Sound.CH.VC0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0456, Sound.CH.SE0, true, 1f, 78);
				evt.eventPlaySound(DirectionManager.SOUND.S1349, Sound.CH.VC0, true, 1f, 100);
				evt.eventPlaySound(DirectionManager.SOUND.S1350, Sound.CH.VC0, true, 1f, 123);
				evt.eventPlaySound(DirectionManager.SOUND.S1351, Sound.CH.VC0, true, 1f, 386);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kfr002, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kfr002_loop, DirectionManager.MOVIE.kfr002, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0121, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0457, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0883, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0884, Sound.CH.VC0, true, 1f, 60);
				evt.eventPlaySound(DirectionManager.SOUND.S0885, Sound.CH.VC0, true, 1f, 189);
				break;
			case 3:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kfr003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd005, DirectionManager.MOVIE.kfr003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kfr002, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kfr002_loop, DirectionManager.MOVIE.kfr002, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0336, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 71);
				evt.eventPlaySound(DirectionManager.SOUND.S0066, Sound.CH.SE1, true, 1f, 71);
				evt.eventPlaySound(DirectionManager.SOUND.S0121, Sound.CH.BGM, true, 1f, 132);
				evt.eventPlaySound(DirectionManager.SOUND.S0457, Sound.CH.SE0, true, 1f, 132);
				evt.eventPlaySound(DirectionManager.SOUND.S0883, Sound.CH.VC0, true, 1f, 137);
				evt.eventPlaySound(DirectionManager.SOUND.S0884, Sound.CH.VC0, true, 1f, 192);
				evt.eventPlaySound(DirectionManager.SOUND.S0885, Sound.CH.VC0, true, 1f, 321);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.GH_freeze_PB(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				DirectionLedManager.BG_IKG_diz_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.OFF_3(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.OFF_4(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_6(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
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
				DirectionLedManager.OFF_4m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_5M));
				break;
			case 2:
				DirectionLedManager.m_panel_DI_f_01(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_6M));
				break;
			case 3:
				DirectionLedManager.BG_KFR_DI_00(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GH_blackout(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.OFF_4(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
				DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_6(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.YK_KFR_DI_00(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
				DirectionLedManager.OFF_9(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_1));
				DirectionLedManager.OFF_10(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_2));
				DirectionLedManager.OFF_11(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_3));
				DirectionLedManager.OFF_12(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_4));
				DirectionLedManager.OFF_13(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_5));
				DirectionLedManager.OFF_14(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_6));
				DirectionLedManager.OFF_15(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_DI));
				DirectionLedManager.OFF_16(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DEMO));
				DirectionLedManager.m_panel_DI_f_02(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_6M));
				break;
			}
		}
		if (low == 0)
		{
			byte b = mode;
			if (b == 1)
			{
				evt.reel.FreezeReelAct1();
			}
		}
		byte b2 = low;
		if (b2 == 1)
		{
			byte b = mode;
			if (b == 1)
			{
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kfr001_loop, false, true, false, false, 0, 0, 199, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0120, Sound.CH.BGM, false, 1f, 219);
			}
		}
		if (MainGameScene.slotGameMan.get_pdt_data(45) == 4 || MainGameScene.slotGameMan.get_pdt_data(46) == 4)
		{
			evt.eventKillAnime(DirectionManager.ANIME.standby, 49);
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
