public class Direction21JKA : DirectionBase
{
	public Direction21JKA(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jka001, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0581, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0582, Sound.CH.SE0, true, 1f, 35);
				evt.eventPlaySound(DirectionManager.SOUND.S1343, Sound.CH.VC0, true, 1f, 35);
				evt.eventPlaySound(DirectionManager.SOUND.S1344, Sound.CH.VC1, true, 1f, 68);
				evt.eventAddMovie(DirectionManager.MOVIE.jka001_loop, DirectionManager.MOVIE.jka001, false, true, false, false);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jka002_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0583, Sound.CH.SE0, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S1345, Sound.CH.VC0, true, 1f, 78);
				evt.eventAddMovie(DirectionManager.MOVIE.jka002_a_loop, DirectionManager.MOVIE.jka002_a, false, true, false, false);
				break;
			case 3:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jka003, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0585, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2026, Sound.CH.VC0, true, 1f, 13);
				evt.eventAddMovie(DirectionManager.MOVIE.jka003_loop, DirectionManager.MOVIE.jka003, false, true, false, false);
				break;
			case 4:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jka002_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0584, Sound.CH.SE0, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S1346, Sound.CH.VC0, false, 1f, 85);
				evt.eventAddMovie(DirectionManager.MOVIE.jka002_b_loop, DirectionManager.MOVIE.jka002_b, false, true, false, false);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhs013, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhs013_loop, DirectionManager.MOVIE.jhs013, false, true, false, false);
				evt.eventStopSound(Sound.CH.SE0, 0);
				evt.eventStopSound(Sound.CH.SE1, 0);
				evt.eventStopSound(Sound.CH.VC0, 0);
				evt.eventStopSound(Sound.CH.VC1, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0213, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0586, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1347, Sound.CH.VC0, true, 1f, 40);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.SE_JST_any_in(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
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
