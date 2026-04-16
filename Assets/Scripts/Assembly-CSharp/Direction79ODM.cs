public class Direction79ODM : DirectionBase
{
	public Direction79ODM(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventPlayMovie(DirectionManager.MOVIE.odm_movie, false, true, false, false, 0, 0, -100, 0);
			}
		}
		if (low == 0)
		{
			byte b = mode;
			if (b == 1)
			{
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
