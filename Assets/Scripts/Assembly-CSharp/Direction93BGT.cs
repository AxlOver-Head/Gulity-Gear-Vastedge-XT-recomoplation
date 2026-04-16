public class Direction93BGT : DirectionBase
{
	public Direction93BGT(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
			switch (mode)
			{
			case 1:
				lamp_0_1();
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
			}
		}
	}

	public static void lamp_0_1()
	{
		DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
		DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
		DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
		DirectionLedManager.init(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_6M));
		MainGameScene.ledPanelMan.stop(LEDPanelManager.LINE.LAYER_6M);
	}

	public static void start_0_1(DirectionEvent _evt, DirectionManager _mng)
	{
		_evt.eventDisableBefore(_mng, 0);
		_evt.eventStopSound(Sound.CH.BGM, 0);
		_evt.eventPlayMovie(DirectionManager.MOVIE.btg001, false, true, false, false, 0, 0, 190, 0);
		_evt.eventPlaySound(DirectionManager.SOUND.S0174, Sound.CH.BGM, false, 1f, 0);
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
