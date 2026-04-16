public class Direction46KBU : DirectionBase
{
	public Direction46KBU(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventPlayMovie(DirectionManager.MOVIE.kbu001_sly, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0556, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
			}
		}
		if (low == 0)
		{
			byte b = mode;
			if (b == 1)
			{
				DirectionLedManager.JG_KBU_SL(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.YK_KBU_SL(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
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
