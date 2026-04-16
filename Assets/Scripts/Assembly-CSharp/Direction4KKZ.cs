public class Direction4KKZ : DirectionBase
{
	public Direction4KKZ(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventPlayMovie(DirectionManager.MOVIE.kkz001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kkz001_loop, DirectionManager.MOVIE.kkz001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0114, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0396, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1184, Sound.CH.VC0, true, 1f, 46);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kkz002_n, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kkz002_n_loop, DirectionManager.MOVIE.kkz002_n, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0397, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1750, Sound.CH.VC0, true, 1f, 17);
				break;
			case 3:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kkz003_2_hen, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kkz003_2_hen_loop, DirectionManager.MOVIE.kkz003_2_hen, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0398, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1751, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE0, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE1, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S1752, Sound.CH.VC1, true, 1f, 43);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 119);
				break;
			case 4:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kkz003_2_cha, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kkz003_2_cha_loop, DirectionManager.MOVIE.kkz003_2_cha, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0398, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1751, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE0, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0211, Sound.CH.SE1, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S1754, Sound.CH.VC1, true, 1f, 43);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 73);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kkz003_2_cau, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kkz003_2_cau_loop, DirectionManager.MOVIE.kkz003_2_cau, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0398, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1751, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE0, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0212, Sound.CH.SE1, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S1755, Sound.CH.VC1, true, 1f, 43);
				evt.eventStopSound(Sound.CH.BGM, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0116, Sound.CH.BGM, false, 1f, 107);
				break;
			case 6:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kkz003_2_sla, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kkz003_2_sla_loop, DirectionManager.MOVIE.kkz003_2_sla, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0398, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1751, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE0, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0399, Sound.CH.SE1, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S1757, Sound.CH.VC1, true, 1f, 43);
				evt.eventStopSound(Sound.CH.BGM, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0184, Sound.CH.BGM, false, 1f, 107);
				break;
			case 7:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kkz003_2_chi, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kkz003_2_chi_loop, DirectionManager.MOVIE.kkz003_2_chi, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0398, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1751, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE0, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0399, Sound.CH.SE1, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S1758, Sound.CH.VC1, true, 1f, 43);
				evt.eventStopSound(Sound.CH.BGM, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0185, Sound.CH.BGM, false, 1f, 107);
				break;
			case 8:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kkz003_2_mil, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kkz003_2_mil_loop, DirectionManager.MOVIE.kkz003_2_mil, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0398, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1751, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE0, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0399, Sound.CH.SE1, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S1759, Sound.CH.VC1, true, 1f, 43);
				evt.eventStopSound(Sound.CH.BGM, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0186, Sound.CH.BGM, false, 1f, 107);
				break;
			case 9:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kkz003_2_brd, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kkz003_2_brd_loop, DirectionManager.MOVIE.kkz003_2_brd, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0398, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1751, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE0, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0399, Sound.CH.SE1, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S1760, Sound.CH.VC1, true, 1f, 43);
				evt.eventStopSound(Sound.CH.BGM, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0187, Sound.CH.BGM, false, 1f, 107);
				break;
			case 10:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kkz003_2_zap, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kkz003_2_zap_loop, DirectionManager.MOVIE.kkz003_2_zap, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0398, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1751, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE0, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0399, Sound.CH.SE1, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S1761, Sound.CH.VC1, true, 1f, 43);
				evt.eventStopSound(Sound.CH.BGM, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0188, Sound.CH.BGM, false, 1f, 107);
				break;
			case 11:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kkz003_2_hoh, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kkz003_2_hoh_loop, DirectionManager.MOVIE.kkz003_2_hoh, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0398, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1751, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE0, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0399, Sound.CH.SE1, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S1762, Sound.CH.VC1, true, 1f, 43);
				evt.eventStopSound(Sound.CH.BGM, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0117, Sound.CH.BGM, false, 1f, 107);
				break;
			case 12:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kkz003_2_sin, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kkz003_2_sin_loop, DirectionManager.MOVIE.kkz003_2_sin, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0398, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1751, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE0, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0400, Sound.CH.SE1, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S1764, Sound.CH.VC1, true, 1f, 43);
				evt.eventStopSound(Sound.CH.BGM, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0118, Sound.CH.BGM, false, 1f, 107);
				break;
			case 13:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kkz003_2_bns, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kkz003_2_bns_loop, DirectionManager.MOVIE.kkz003_2_bns, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0398, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1751, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE0, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0401, Sound.CH.SE1, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S1766, Sound.CH.VC1, true, 1f, 43);
				evt.eventStopSound(Sound.CH.BGM, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, false, 1f, 107);
				break;
			case 14:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kkz003_2_bd, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kkz003_2_bd_loop, DirectionManager.MOVIE.kkz003_2_bd, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0398, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1751, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE0, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0402, Sound.CH.SE1, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S1765, Sound.CH.VC1, true, 1f, 43);
				evt.eventStopSound(Sound.CH.BGM, 17);
				break;
			case 15:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kkz003_2_man, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kkz003_2_man_loop, DirectionManager.MOVIE.kkz003_2_man, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0398, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1751, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE0, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0215, Sound.CH.SE1, true, 1f, 17);
				evt.eventStopSound(Sound.CH.BGM, 17);
				break;
			case 16:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kkz002_j, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kkz002_j_loop, DirectionManager.MOVIE.kkz002_j, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0196, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0397, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1750, Sound.CH.VC0, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0403, Sound.CH.SE1, true, 1f, 17);
				break;
			case 17:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kkz003_2_hen, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kkz003_2_hen_loop, DirectionManager.MOVIE.kkz003_2_hen, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0398, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1751, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0352, Sound.CH.SE0, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0210, Sound.CH.SE1, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S1752, Sound.CH.VC1, true, 1f, 43);
				evt.eventStopSound(Sound.CH.BGM, 17);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
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
