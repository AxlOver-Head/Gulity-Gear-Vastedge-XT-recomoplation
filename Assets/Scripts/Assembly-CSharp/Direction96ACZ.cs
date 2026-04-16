public class Direction96ACZ : DirectionBase
{
	public Direction96ACZ(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventPlayMovie(DirectionManager.MOVIE.acz011_nml1, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.acz011_add1, true, false, true, false, 0, 0, 99, 36);
				evt.eventPlayMovie(DirectionManager.MOVIE.acz011_nml2, true, false, false, false, 0, 0, 98, 26);
				evt.eventPlayMovie(DirectionManager.MOVIE.acz011_add2, true, false, true, false, 0, 0, 97, 32);
				break;
			case 2:
				evt.eventPlayMovie(DirectionManager.MOVIE.acz011_loop, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.acz011_loop_add, false, false, true, false, 0, 0, 99, 0);
				break;
			case 3:
				evt.eventPlayMovie(DirectionManager.MOVIE.acz012, true, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.acz012_add, true, false, true, false, 0, 0, 99, 0);
				break;
			case 4:
				evt.eventPlayMovie(DirectionManager.MOVIE.acz014_add, false, true, true, false, 0, 0, 100, 0);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				break;
			case 2:
				break;
			case 3:
				break;
			case 4:
				break;
			case 5:
				break;
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
