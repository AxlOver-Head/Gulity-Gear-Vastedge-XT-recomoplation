public class Direction71BI2 : DirectionBase
{
	public Direction71BI2(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		base.start();
		MainGameScene.slotGameMan.set_pdt_data(79, 0);
		if (low == 0 && mode == 0)
		{
			evt.eventDisable(mng, DirectionManager.DIR.REEL_2, 0);
		}
		if (low == 0)
		{
			byte b = mode;
			if (b == 1)
			{
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventDisable(mng, DirectionManager.DIR.REEL_2, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bi2001, false, false, false, false, 0, 0, 199, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1504, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0159, Sound.CH.BGM, true, 1f, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bi2001_loop, DirectionManager.MOVIE.bi2001, false, true, false, false);
			}
		}
		if (low == 0)
		{
			byte b = mode;
			if (b == 1)
			{
				DirectionLedManager.JG_PB_in(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.YK_PB_in(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_win_PB_in(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M));
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
