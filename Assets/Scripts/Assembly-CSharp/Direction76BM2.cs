public class Direction76BM2 : DirectionBase
{
	private bool isStart;

	public Direction76BM2(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
		isStart = false;
	}

	public override void start()
	{
		if (isStart)
		{
			return;
		}
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
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
			}
		}
		isStart = true;
	}

	public override void end()
	{
		base.end();
	}

	public override void control()
	{
		base.control();
	}

	public static void start_0_1(DirectionEvent _evt, DirectionManager _mng)
	{
		if (SGLG.prod.find(2790) < 0 && SGLG.prod.find(2790) < 0)
		{
			_evt.eventPlayMovie(DirectionManager.MOVIE.bm2_1, false, false, false, false, 0, 0, 190, 0);
			_evt.eventAddMovie(DirectionManager.MOVIE.bm2_2, DirectionManager.MOVIE.bm2_1, false, true, false, false);
		}
		restartBGM();
	}

	public static void restartBGM()
	{
		if (SGLG.sound.getBGMID() == 51)
		{
			if (SGLG.sound.getBGMVolume() < 1f)
			{
				SGLG.sound.SetVolume(Sound.CH.BGM, 1f);
			}
		}
		else
		{
			SGLG.sound.PlaySound(51, Sound.CH.BGM, true);
			SGLG.sound.SetVolume(Sound.CH.BGM, 1f);
		}
	}
}
