public class Direction61RST : DirectionBase
{
	public Direction61RST(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				start_0_1(evt, mng);
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
		DirectionLedManager.OFF_1(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
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
		DirectionLedManager.init(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_6M));
		MainGameScene.ledPanelMan.stop(LEDPanelManager.LINE.LAYER_3M);
		MainGameScene.ledPanelMan.stop(LEDPanelManager.LINE.LAYER_6M);
	}

	public static void start_0_1(DirectionEvent _evt, DirectionManager _mng)
	{
		_evt.eventDisableBefore(_mng, 0);
		if (DirectionEvent.prod.find(2514) < 0)
		{
			_evt.eventPlayMovie(DirectionManager.MOVIE.rst001_a, false, true, false, false, 0, 0, 200, 0);
		}
		_evt.eventPlayMovie(DirectionManager.MOVIE.rst001_d, false, true, false, false, 0, 0, 198, 0);
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
