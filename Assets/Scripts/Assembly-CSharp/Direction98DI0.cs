public class Direction98DI0 : DirectionBase
{
	public Direction98DI0(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_10, false, false, true, false, 0, 0, 99, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_10_loop, DirectionManager.MOVIE.huc008_T_10, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE0, true, 1f, 82);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1768();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1771();
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_20, false, false, true, false, 0, 0, 99, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_20_loop, DirectionManager.MOVIE.huc008_T_20, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE0, true, 1f, 82);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1768();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1771();
				break;
			case 3:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmn043, false, false, false, false, 0, 0, 100, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.cmn043_loop, DirectionManager.MOVIE.cmn043, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0065, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.huc008_T_30, false, false, true, false, 0, 0, 99, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.huc008_T_30_loop, DirectionManager.MOVIE.huc008_T_30, false, true, true, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE0, true, 1f, 82);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1773();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1774();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_1776();
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
