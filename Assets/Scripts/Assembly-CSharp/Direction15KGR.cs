public class Direction15KGR : DirectionBase
{
	public Direction15KGR(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventPlayMovie(DirectionManager.MOVIE.kgr001, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0115, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0383, Sound.CH.SE0, true, 1f, 21);
				evt.eventAddMovie(DirectionManager.MOVIE.kgr001_loop, DirectionManager.MOVIE.kgr001, false, true, false, false);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kgr002_1, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0384, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0385, Sound.CH.SE1, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S2009, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S2010, Sound.CH.VC1, true, 1f, 55);
				evt.eventAddMovie(DirectionManager.MOVIE.kgr002_1_loop, DirectionManager.MOVIE.kgr002_1, false, true, false, false);
				break;
			case 3:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kgr003, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0387, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1930, Sound.CH.VC0, true, 1f, 29);
				evt.eventAddMovie(DirectionManager.MOVIE.kgr003_loop, DirectionManager.MOVIE.kgr003, false, true, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 100);
				break;
			case 4:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kgr004, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kgr004_loop, DirectionManager.MOVIE.kgr004, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0213, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0388, Sound.CH.SE1, true, 1f, 28);
				evt.eventPlaySound(DirectionManager.SOUND.S1931, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0389, Sound.CH.SE0, true, 1f, 53);
				evt.eventPlaySound(DirectionManager.SOUND.S0117, Sound.CH.BGM, true, 1f, 80);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kgr005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kgr004_loop, DirectionManager.MOVIE.kgr005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0213, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0388, Sound.CH.SE1, true, 1f, 28);
				evt.eventPlaySound(DirectionManager.SOUND.S1932, Sound.CH.VC0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0389, Sound.CH.SE0, true, 1f, 97);
				evt.eventPlaySound(DirectionManager.SOUND.S0118, Sound.CH.BGM, true, 1f, 118);
				break;
			case 6:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kgr006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kgr006_loop, DirectionManager.MOVIE.kgr006, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0213, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0390, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0391, Sound.CH.SE0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0833, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0392, Sound.CH.SE0, true, 1f, 108);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 177);
				break;
			case 7:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kgr006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kgr006_loop, DirectionManager.MOVIE.kgr006, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0213, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0390, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0391, Sound.CH.SE0, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0833, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0392, Sound.CH.SE0, true, 1f, 108);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 10);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, false, 0, 0, 80, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 10);
				break;
			case 8:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kgr002_2, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kgr002_2_loop, DirectionManager.MOVIE.kgr002_2, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0384, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0386, Sound.CH.SE1, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S2014, Sound.CH.VC0, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S2015, Sound.CH.VC1, true, 1f, 61);
				evt.eventAddMovie(DirectionManager.MOVIE.kgr002_2_loop, DirectionManager.MOVIE.kgr002_2, false, true, false, false);
				break;
			case 9:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kgr002_3, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kgr002_3_loop, DirectionManager.MOVIE.kgr002_3, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0384, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0385, Sound.CH.SE1, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0215, Sound.CH.SE0, true, 1f, 15);
				evt.eventAddMovie(DirectionManager.MOVIE.kgr002_3_loop, DirectionManager.MOVIE.kgr002_3, false, true, false, false);
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
