public class Direction65RHK : DirectionBase
{
	public Direction65RHK(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventPlayMovie(DirectionManager.MOVIE.rhk001sol00, false, false, false, true, 151, 71, 198, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.rst001_d, false, true, false, false, 0, 0, 198, 100);
				evt.eventPauseMovie(DirectionManager.MOVIE.rst001_a, 0);
				evt.eventResumeMovie(DirectionManager.MOVIE.rst001_a, 100);
				break;
			case 2:
				evt.eventPlayMovie(DirectionManager.MOVIE.rhk001sol01, false, false, false, true, 151, 71, 198, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.rst001_d, false, true, false, false, 0, 0, 198, 142);
				evt.eventPauseMovie(DirectionManager.MOVIE.rst001_a, 0);
				evt.eventResumeMovie(DirectionManager.MOVIE.rst001_a, 142);
				break;
			case 3:
				evt.eventPlayMovie(DirectionManager.MOVIE.rhk002_sin00, false, false, false, true, 151, 71, 198, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.rst001_d, false, true, false, false, 0, 0, 198, 96);
				evt.eventPauseMovie(DirectionManager.MOVIE.rst001_a, 0);
				evt.eventResumeMovie(DirectionManager.MOVIE.rst001_a, 96);
				break;
			case 4:
				evt.eventPlayMovie(DirectionManager.MOVIE.rhk002_sin01, false, false, false, true, 151, 71, 198, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.rst001_d, false, true, false, false, 0, 0, 198, 107);
				evt.eventPauseMovie(DirectionManager.MOVIE.rst001_a, 0);
				evt.eventResumeMovie(DirectionManager.MOVIE.rst001_a, 107);
				break;
			case 5:
				evt.eventPlayMovie(DirectionManager.MOVIE.rhk002_sin02, false, false, false, true, 151, 71, 198, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.rst001_d, false, true, false, false, 0, 0, 198, 121);
				evt.eventPauseMovie(DirectionManager.MOVIE.rst001_a, 0);
				evt.eventResumeMovie(DirectionManager.MOVIE.rst001_a, 121);
				break;
			case 6:
				evt.eventPlayMovie(DirectionManager.MOVIE.rhk003_kikyu, true, false, false, true, 70, 25, 100, 0);
				break;
			case 7:
				evt.eventPlayMovie(DirectionManager.MOVIE.rhk003_mayship, true, false, false, true, 70, 25, 100, 0);
				break;
			case 8:
				evt.eventPlayMovie(DirectionManager.MOVIE.rhk004_nabi_white, true, false, false, true, 128, 89, 199, 0);
				break;
			case 9:
				evt.eventPlayMovie(DirectionManager.MOVIE.rhk004_nabi_blue, true, false, false, true, 128, 89, 199, 0);
				break;
			case 10:
				evt.eventPlayMovie(DirectionManager.MOVIE.rhk004_nabi_yellow, true, false, false, true, 128, 89, 199, 0);
				break;
			case 11:
				evt.eventPlayMovie(DirectionManager.MOVIE.rhk004_nabi_green, true, false, false, true, 128, 89, 199, 0);
				break;
			case 12:
				evt.eventPlayMovie(DirectionManager.MOVIE.rhk004_nabi_red, true, false, false, true, 128, 89, 199, 0);
				break;
			case 13:
				evt.eventPlayMovie(DirectionManager.MOVIE.rhk004_nabi_purple, true, false, false, true, 128, 89, 199, 0);
				break;
			case 14:
				evt.eventPlayMovie(DirectionManager.MOVIE.rhk004_nabi_rainbow, true, false, false, true, 128, 89, 199, 0);
				break;
			case 15:
				evt.eventPlayMovie(DirectionManager.MOVIE.rhk003_neko, true, false, false, true, 70, 25, 100, 0);
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
