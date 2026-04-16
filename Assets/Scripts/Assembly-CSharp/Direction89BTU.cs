public class Direction89BTU : DirectionBase
{
	public Direction89BTU(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE1, true, 1f, 6);
				evt.eventPlayMovie(DirectionManager.MOVIE.btd001, false, false, false, true, 128, 72, 99, 11);
				evt.eventAddMovie(DirectionManager.MOVIE.btd001_loop, DirectionManager.MOVIE.btd001, false, true, false, true);
				break;
			case 2:
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0275, Sound.CH.SE1, true, 1f, 78);
				evt.eventPlayMovie(DirectionManager.MOVIE.btd001, false, false, false, true, 128, 72, 99, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.btd001_loop, DirectionManager.MOVIE.btd001, false, true, false, true);
				break;
			case 3:
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0358, Sound.CH.SE1, true, 1f, 16);
				evt.eventPlayMovie(DirectionManager.MOVIE.btd003, false, false, false, true, 128, 72, 99, 11);
				evt.eventAddMovie(DirectionManager.MOVIE.btd003_loop, DirectionManager.MOVIE.btd003, false, true, false, true);
				break;
			case 4:
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventDisableBefore(mng, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0253, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0358, Sound.CH.SE1, true, 1f, 88);
				evt.eventPlayMovie(DirectionManager.MOVIE.btd003, false, false, false, true, 128, 72, 99, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.btd003_loop, DirectionManager.MOVIE.btd003, false, true, false, true);
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
