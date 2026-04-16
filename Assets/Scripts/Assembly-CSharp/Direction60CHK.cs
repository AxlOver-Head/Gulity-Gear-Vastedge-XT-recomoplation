public class Direction60CHK : DirectionBase
{
	public Direction60CHK(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventPlayMovie(DirectionManager.MOVIE.chk001_2, false, false, false, false, 0, 0, 199, 0);
				break;
			case 2:
				evt.eventPlayMovie(DirectionManager.MOVIE.chk001_1, false, false, false, false, 0, 0, 199, 0);
				break;
			case 3:
				evt.eventPlayMovie(DirectionManager.MOVIE.chk002_3, false, false, false, false, 0, 0, 199, 0);
				break;
			case 4:
				evt.eventPlayMovie(DirectionManager.MOVIE.chk002_2, false, false, false, false, 0, 0, 199, 0);
				break;
			case 5:
				evt.eventPlayMovie(DirectionManager.MOVIE.chk002_1, false, false, false, false, 0, 0, 199, 0);
				break;
			case 6:
				evt.eventPlayMovie(DirectionManager.MOVIE.chk003_sakana, false, false, false, true, 162, 94, 198, 0);
				break;
			case 7:
				evt.eventPlayMovie(DirectionManager.MOVIE.chk003_niku, false, false, false, true, 141, 104, 198, 0);
				break;
			case 8:
				evt.eventPlayMovie(DirectionManager.MOVIE.chk004_white, false, false, false, true, 213, 22, 100, 0);
				break;
			case 9:
				evt.eventPlayMovie(DirectionManager.MOVIE.chk004_blue, false, false, false, true, 213, 22, 100, 0);
				break;
			case 10:
				evt.eventPlayMovie(DirectionManager.MOVIE.chk004_yellow, false, false, false, true, 213, 22, 100, 0);
				break;
			case 11:
				evt.eventPlayMovie(DirectionManager.MOVIE.chk004_green, false, false, false, true, 213, 22, 100, 0);
				break;
			case 12:
				evt.eventPlayMovie(DirectionManager.MOVIE.chk004_red, false, false, false, true, 213, 22, 100, 0);
				break;
			case 13:
				evt.eventPlayMovie(DirectionManager.MOVIE.chk004_purple, false, false, false, true, 213, 22, 100, 0);
				break;
			case 14:
				evt.eventPlayMovie(DirectionManager.MOVIE.chk004_rainbow, false, false, false, true, 213, 22, 100, 0);
				break;
			case 15:
				evt.eventPlayMovie(DirectionManager.MOVIE.chk003_maneki, false, false, false, true, 133, 25, 100, 0);
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
			case 6:
				break;
			case 7:
				break;
			case 8:
				break;
			case 9:
				break;
			case 10:
				break;
			case 11:
				break;
			case 12:
				break;
			case 13:
				break;
			case 14:
				break;
			case 15:
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
