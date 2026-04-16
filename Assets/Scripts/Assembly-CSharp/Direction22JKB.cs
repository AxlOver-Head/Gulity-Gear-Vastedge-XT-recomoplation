public class Direction22JKB : DirectionBase
{
	public Direction22JKB(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventPlayMovie(DirectionManager.MOVIE.jkb001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jkb001_loop, DirectionManager.MOVIE.jkb001, false, true, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 1, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0545, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0283, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1205, Sound.CH.VC0, true, 1f, 22);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jkb002, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jkb002_loop, DirectionManager.MOVIE.jkb002, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0546, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0844, Sound.CH.VC0, true, 1f, 6);
				evt.eventPlaySound(DirectionManager.SOUND.S0548, Sound.CH.SE0, true, 1f, 25);
				break;
			case 3:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jkb003, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0547, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0845, Sound.CH.VC0, true, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0846, Sound.CH.VC0, true, 1f, 62);
				break;
			case 4:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jkb004, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jkb004_loop, DirectionManager.MOVIE.jkb004, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0547, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0550, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0847, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1206, Sound.CH.VC0, true, 1f, 70);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jkb005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jkb005_loop, DirectionManager.MOVIE.jkb005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0549, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0848, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlaySound(DirectionManager.SOUND.S2026, Sound.CH.VC0, true, 1f, 66);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.YK_JKB_start(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 2:
				break;
			case 3:
				DirectionLedManager.JG_JKB_end(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.YK_JKB_end(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 4:
				DirectionLedManager.YK_JKB_continue(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 5:
				DirectionLedManager.YK_JKB_cutin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
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
