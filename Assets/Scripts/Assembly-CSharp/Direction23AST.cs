public class Direction23AST : DirectionBase
{
	public Direction23AST(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		base.start();
		if (low == 0)
		{
			byte b = mode;
			if (b == 1)
			{
				start_0_1(evt, mng, m_Dir);
			}
		}
		if (low == 0)
		{
			byte b = mode;
			if (b == 1)
			{
				lamp_0_1();
			}
		}
	}

	public static void lamp_0_1()
	{
		DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
		DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
		DirectionLedManager.OFF_9(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_1));
		DirectionLedManager.OFF_10(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_2));
		DirectionLedManager.OFF_11(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_3));
		DirectionLedManager.OFF_12(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_4));
		DirectionLedManager.OFF_13(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_5));
		DirectionLedManager.OFF_14(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_6));
		DirectionLedManager.OFF_15(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_DI));
		DirectionLedManager.OFF_16(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DEMO));
		DirectionLedManager.init(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
		DirectionLedManager.init(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_6M));
		MainGameScene.ledPanelMan.stop(LEDPanelManager.LINE.LAYER_3M);
		MainGameScene.ledPanelMan.stop(LEDPanelManager.LINE.LAYER_6M);
	}

	public static void lamp_X_X()
	{
		DirectionLedManager.init(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
		DirectionLedManager.init(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_6M));
		MainGameScene.ledPanelMan.stop(LEDPanelManager.LINE.LAYER_3M);
		MainGameScene.ledPanelMan.stop(LEDPanelManager.LINE.LAYER_6M);
	}

	public static void start_0_1(DirectionEvent _evt, DirectionManager _mng, DirectionManager.DIR _dir)
	{
		_evt.eventDisableBefore(_mng, 0);
		_evt.eventPlayMovie(DirectionManager.MOVIE.ast001, false, true, false, false, 0, 0, 190, 0);
		int num = MainGameScene.slotGameMan.get_pdt_data(45);
		int num2 = MainGameScene.slotGameMan.get_pdt_data(46);
		int num3 = MainGameScene.slotGameMan.get_pdt_data(47);
		int num4 = MainGameScene.slotGameMan.get_pdt_data(48);
		int num5 = MainGameScene.slotGameMan.get_pdt_data(49);
		if (num == 4 || num2 == 4)
		{
			_evt.eventPlayAnime(DirectionManager.ANIME.standby, 0, false, true, false, false, 128, 72, 2, 0);
		}
		else
		{
			_evt.eventKillAnime(DirectionManager.ANIME.standby, 0);
		}
		restartBGM();
	}

	public static void start_X_X(DirectionEvent _evt, DirectionManager _mng, DirectionManager.DIR _dir)
	{
		_evt.eventDisableBefore(_mng, 0);
		_evt.eventPlayMovie(DirectionManager.MOVIE.ast001, false, true, false, false, 0, 0, 190, 0);
		int num = MainGameScene.slotGameMan.get_pdt_data(45);
		int num2 = MainGameScene.slotGameMan.get_pdt_data(46);
		int num3 = MainGameScene.slotGameMan.get_pdt_data(47);
		int num4 = MainGameScene.slotGameMan.get_pdt_data(48);
		int num5 = MainGameScene.slotGameMan.get_pdt_data(49);
		if (num == 4 || num2 == 4)
		{
			_evt.eventPlayAnime(DirectionManager.ANIME.standby, 0, false, true, false, false, 128, 72, 2, 0);
		}
		else
		{
			_evt.eventKillAnime(DirectionManager.ANIME.standby, 0);
		}
		restartBGM();
	}

	public static void restartBGM()
	{
		int artBgm = MainGameScene.slotGameMan.getArtBgm();
		if (SGLG.sound.getBGMID() == artBgm)
		{
			if (SGLG.sound.getBGMVolume() < 1f)
			{
				SGLG.sound.SetVolume(Sound.CH.BGM, 1f);
			}
		}
		else
		{
			SGLG.sound.PlaySound(artBgm, Sound.CH.BGM, true);
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
