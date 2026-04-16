public class Direction19JHS : DirectionBase
{
	public Direction19JHS(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhs001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhs001_loop, DirectionManager.MOVIE.jhs001, false, true, false, false);
				evt.eventStopSound(Sound.CH.SE0, 0);
				evt.eventStopSound(Sound.CH.SE1, 0);
				evt.eventStopSound(Sound.CH.VC0, 0);
				evt.eventStopSound(Sound.CH.VC1, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0600, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1196, Sound.CH.VC0, true, 1f, 33);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhs002, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhs002_loop, DirectionManager.MOVIE.jhs002, false, true, false, false);
				evt.eventStopSound(Sound.CH.SE0, 0);
				evt.eventStopSound(Sound.CH.SE1, 0);
				evt.eventStopSound(Sound.CH.VC0, 0);
				evt.eventStopSound(Sound.CH.VC1, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0602, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1197, Sound.CH.VC0, true, 1f, 0);
				break;
			case 3:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhs003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhs003_loop, DirectionManager.MOVIE.jhs003, false, true, false, false);
				evt.eventStopSound(Sound.CH.SE0, 0);
				evt.eventStopSound(Sound.CH.SE1, 0);
				evt.eventStopSound(Sound.CH.VC0, 0);
				evt.eventStopSound(Sound.CH.VC1, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0603, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1198, Sound.CH.VC0, true, 1f, 0);
				break;
			case 4:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhs004, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhs004_loop, DirectionManager.MOVIE.jhs004, false, true, false, false);
				evt.eventStopSound(Sound.CH.SE0, 0);
				evt.eventStopSound(Sound.CH.SE1, 0);
				evt.eventStopSound(Sound.CH.VC0, 0);
				evt.eventStopSound(Sound.CH.VC1, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0604, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1200, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2026, Sound.CH.VC1, true, 1f, 64);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhs005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhs005_loop, DirectionManager.MOVIE.jhs005, false, true, false, false);
				evt.eventStopSound(Sound.CH.SE0, 0);
				evt.eventStopSound(Sound.CH.SE1, 0);
				evt.eventStopSound(Sound.CH.VC0, 0);
				evt.eventStopSound(Sound.CH.VC1, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0600, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0836, Sound.CH.VC0, true, 1f, 33);
				break;
			case 6:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhs006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhs006_loop, DirectionManager.MOVIE.jhs006, false, true, false, false);
				evt.eventStopSound(Sound.CH.SE0, 0);
				evt.eventStopSound(Sound.CH.SE1, 0);
				evt.eventStopSound(Sound.CH.VC0, 0);
				evt.eventStopSound(Sound.CH.VC1, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0602, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0837, Sound.CH.VC0, true, 1f, 0);
				break;
			case 7:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhs007, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhs007_loop, DirectionManager.MOVIE.jhs007, false, true, false, false);
				evt.eventStopSound(Sound.CH.SE0, 0);
				evt.eventStopSound(Sound.CH.SE1, 0);
				evt.eventStopSound(Sound.CH.VC0, 0);
				evt.eventStopSound(Sound.CH.VC1, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0603, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0838, Sound.CH.VC0, true, 1f, 0);
				break;
			case 8:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhs008, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhs008_loop, DirectionManager.MOVIE.jhs008, false, true, false, false);
				evt.eventStopSound(Sound.CH.SE0, 0);
				evt.eventStopSound(Sound.CH.SE1, 0);
				evt.eventStopSound(Sound.CH.VC0, 0);
				evt.eventStopSound(Sound.CH.VC1, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0605, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0839, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2026, Sound.CH.VC1, true, 1f, 65);
				break;
			case 9:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhs009, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhs009_loop, DirectionManager.MOVIE.jhs009, false, true, false, false);
				evt.eventStopSound(Sound.CH.SE0, 0);
				evt.eventStopSound(Sound.CH.SE1, 0);
				evt.eventStopSound(Sound.CH.VC0, 0);
				evt.eventStopSound(Sound.CH.VC1, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0601, Sound.CH.SE0, true, 1f, 0);
				break;
			case 10:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhs010, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhs010_loop, DirectionManager.MOVIE.jhs010, false, true, false, false);
				evt.eventStopSound(Sound.CH.SE0, 0);
				evt.eventStopSound(Sound.CH.SE1, 0);
				evt.eventStopSound(Sound.CH.VC0, 0);
				evt.eventStopSound(Sound.CH.VC1, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0606, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0840, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1201, Sound.CH.VC1, true, 1f, 0);
				break;
			case 11:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhs011, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhs011_loop, DirectionManager.MOVIE.jhs011, false, true, false, false);
				evt.eventStopSound(Sound.CH.SE0, 0);
				evt.eventStopSound(Sound.CH.SE1, 0);
				evt.eventStopSound(Sound.CH.VC0, 0);
				evt.eventStopSound(Sound.CH.VC1, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0607, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0841, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1202, Sound.CH.VC1, true, 1f, 0);
				break;
			case 12:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhs012, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhs012_loop, DirectionManager.MOVIE.jhs012, false, true, false, false);
				evt.eventStopSound(Sound.CH.SE0, 0);
				evt.eventStopSound(Sound.CH.SE1, 0);
				evt.eventStopSound(Sound.CH.VC0, 0);
				evt.eventStopSound(Sound.CH.VC1, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0608, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0842, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1203, Sound.CH.VC1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2026, Sound.CH.VC0, true, 1f, 44);
				break;
			case 13:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.jhs013, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.jhs013_loop, DirectionManager.MOVIE.jhs013, false, true, false, false);
				evt.eventStopSound(Sound.CH.SE0, 0);
				evt.eventStopSound(Sound.CH.SE1, 0);
				evt.eventStopSound(Sound.CH.VC0, 0);
				evt.eventStopSound(Sound.CH.VC1, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0213, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0586, Sound.CH.SE1, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1204, Sound.CH.VC0, true, 1f, 40);
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
			case 5:
				DirectionLedManager.SE_JST_any_in(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 9:
				DirectionLedManager.SE_JST_any_in(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			}
		}
		base.start();
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
