public class Direction18JST : DirectionBase
{
	public Direction18JST(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
		DirectionLedManager.init(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
		DirectionLedManager.init(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_6M));
		MainGameScene.ledPanelMan.stop(LEDPanelManager.LINE.LAYER_3M);
		MainGameScene.ledPanelMan.stop(LEDPanelManager.LINE.LAYER_6M);
	}

	public static void start_0_1(DirectionEvent _evt, DirectionManager _mng)
	{
		_evt.eventDisableBefore(_mng, 0);
		_evt.eventPlayMovie(DirectionManager.MOVIE.jst001, false, true, false, false, 0, 0, 200, 0);
		restartBGM();
	}

	public static void restartBGM()
	{
		if (SGLG.sound.getBGMID() == 38)
		{
			if (SGLG.sound.getBGMVolume() < 1f)
			{
				SGLG.sound.SetVolume(Sound.CH.BGM, 1f);
			}
		}
		else
		{
			SGLG.sound.PlaySound(38, Sound.CH.BGM, true);
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
