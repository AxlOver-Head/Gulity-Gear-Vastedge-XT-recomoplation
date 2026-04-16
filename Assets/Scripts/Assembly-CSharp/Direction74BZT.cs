public class Direction74BZT : DirectionBase
{
	private int m_cnt;

	public Direction74BZT(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		m_cnt = 0;
		if (low == 0 && (mode == 1 || mode == 3))
		{
			evt.eventStopSound(Sound.CH.BGM, 0);
		}
		restartBGM();
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt1001a, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0965, Sound.CH.VC0, true, 1f, 8);
				evt.eventPlaySound(DirectionManager.SOUND.S1669, Sound.CH.VC1, true, 1f, 67);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt1001b, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0966, Sound.CH.VC0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S1670, Sound.CH.VC1, true, 1f, 121);
				break;
			case 3:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt1002, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt1002_loop, DirectionManager.MOVIE.bzt1002, false, true, false, false);
				break;
			case 4:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt2001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt2001_loop, DirectionManager.MOVIE.bzt2001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1671, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0640, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0666, Sound.CH.SE1, true, 1f, 103);
				evt.eventPlaySound(DirectionManager.SOUND.S0967, Sound.CH.VC1, true, 1f, 103);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt3001, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0681, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0683, Sound.CH.SE1, true, 1f, 61);
				evt.eventPlaySound(DirectionManager.SOUND.S1677, Sound.CH.VC0, true, 1f, 90);
				evt.eventPlaySound(DirectionManager.SOUND.S1676, Sound.CH.VC1, true, 1f, 123);
				break;
			case 6:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt3003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd005, DirectionManager.MOVIE.bzt3003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3005, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3005_loop, DirectionManager.MOVIE.bzt3005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0681, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0682, Sound.CH.SE1, true, 1f, 60);
				evt.eventPlaySound(DirectionManager.SOUND.S0667, Sound.CH.SE0, true, 1f, 169);
				evt.eventPlaySound(DirectionManager.SOUND.S1049, Sound.CH.VC0, true, 1f, 192);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 96);
				break;
			case 7:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt3004, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd005, DirectionManager.MOVIE.bzt3004, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3005, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3005_loop, DirectionManager.MOVIE.bzt3005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0681, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0684, Sound.CH.SE1, true, 1f, 63);
				evt.eventPlaySound(DirectionManager.SOUND.S0667, Sound.CH.SE0, true, 1f, 191);
				evt.eventPlaySound(DirectionManager.SOUND.S1049, Sound.CH.VC0, true, 1f, 214);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 118);
				break;
			case 8:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt3002, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3002_loop, DirectionManager.MOVIE.bzt3002, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0262, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE1, true, 1f, 3);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, false, 0, 55, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 2);
				evt.eventSetCanPush(true, 0);
				break;
			case 9:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt3040, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3100, DirectionManager.MOVIE.bzt3040, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0685, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0686, Sound.CH.SE1, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0683, Sound.CH.SE0, true, 1f, 38);
				evt.eventPlaySound(DirectionManager.SOUND.S1677, Sound.CH.VC0, true, 1f, 69);
				evt.eventPlaySound(DirectionManager.SOUND.S1676, Sound.CH.VC1, true, 1f, 102);
				break;
			case 10:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt3030, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3030_loop, DirectionManager.MOVIE.bzt3030, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0262, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, false, 0, 55, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 2);
				evt.eventSetCanPush(true, 0);
				break;
			case 11:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt3031, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3031_loop, DirectionManager.MOVIE.bzt3031, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0262, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, false, 0, 55, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 2);
				evt.eventSetCanPush(true, 0);
				break;
			case 12:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt3041, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3100, DirectionManager.MOVIE.bzt3041, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0685, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0686, Sound.CH.SE1, true, 1f, 9);
				evt.eventPlaySound(DirectionManager.SOUND.S0683, Sound.CH.SE0, true, 1f, 35);
				evt.eventPlaySound(DirectionManager.SOUND.S1677, Sound.CH.VC0, true, 1f, 66);
				evt.eventPlaySound(DirectionManager.SOUND.S1676, Sound.CH.VC1, true, 1f, 99);
				break;
			case 13:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt3032, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3032_loop, DirectionManager.MOVIE.bzt3032, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0262, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, false, 0, 55, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 2);
				evt.eventSetCanPush(true, 0);
				break;
			case 14:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt3042, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3100, DirectionManager.MOVIE.bzt3042, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0685, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0686, Sound.CH.SE1, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0683, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S1677, Sound.CH.VC0, true, 1f, 61);
				evt.eventPlaySound(DirectionManager.SOUND.S1676, Sound.CH.VC1, true, 1f, 94);
				break;
			case 15:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt3033, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3033_loop, DirectionManager.MOVIE.bzt3033, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0262, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0581, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, false, 0, 55, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 2);
				evt.eventSetCanPush(true, 0);
				break;
			case 16:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt3043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3100, DirectionManager.MOVIE.bzt3043, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0685, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0686, Sound.CH.SE1, true, 1f, 9);
				evt.eventPlaySound(DirectionManager.SOUND.S0683, Sound.CH.SE0, true, 1f, 35);
				evt.eventPlaySound(DirectionManager.SOUND.S1677, Sound.CH.VC0, true, 1f, 66);
				evt.eventPlaySound(DirectionManager.SOUND.S1676, Sound.CH.VC1, true, 1f, 99);
				break;
			case 17:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt3034, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3034_loop, DirectionManager.MOVIE.bzt3034, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0262, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0581, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, false, 0, 55, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 2);
				evt.eventSetCanPush(true, 0);
				break;
			case 18:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt3044, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3100, DirectionManager.MOVIE.bzt3044, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0685, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0686, Sound.CH.SE1, true, 1f, 9);
				evt.eventPlaySound(DirectionManager.SOUND.S0683, Sound.CH.SE0, true, 1f, 35);
				evt.eventPlaySound(DirectionManager.SOUND.S1677, Sound.CH.VC0, true, 1f, 66);
				evt.eventPlaySound(DirectionManager.SOUND.S1676, Sound.CH.VC1, true, 1f, 99);
				break;
			case 19:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt3040, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3100, DirectionManager.MOVIE.bzt3040, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0685, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0686, Sound.CH.SE1, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0683, Sound.CH.SE0, true, 1f, 38);
				evt.eventPlaySound(DirectionManager.SOUND.S1677, Sound.CH.VC0, true, 1f, 69);
				evt.eventPlaySound(DirectionManager.SOUND.S1676, Sound.CH.VC1, true, 1f, 102);
				break;
			case 20:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt3041, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3100, DirectionManager.MOVIE.bzt3041, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0685, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0686, Sound.CH.SE1, true, 1f, 9);
				evt.eventPlaySound(DirectionManager.SOUND.S0683, Sound.CH.SE0, true, 1f, 35);
				evt.eventPlaySound(DirectionManager.SOUND.S1677, Sound.CH.VC0, true, 1f, 66);
				evt.eventPlaySound(DirectionManager.SOUND.S1676, Sound.CH.VC1, true, 1f, 99);
				break;
			case 21:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt3042, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3100, DirectionManager.MOVIE.bzt3042, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0685, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0686, Sound.CH.SE1, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0683, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S1677, Sound.CH.VC0, true, 1f, 61);
				evt.eventPlaySound(DirectionManager.SOUND.S1676, Sound.CH.VC1, true, 1f, 94);
				break;
			case 22:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt3043, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3100, DirectionManager.MOVIE.bzt3043, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0685, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0686, Sound.CH.SE1, true, 1f, 9);
				evt.eventPlaySound(DirectionManager.SOUND.S0683, Sound.CH.SE0, true, 1f, 35);
				evt.eventPlaySound(DirectionManager.SOUND.S1677, Sound.CH.VC0, true, 1f, 66);
				evt.eventPlaySound(DirectionManager.SOUND.S1676, Sound.CH.VC1, true, 1f, 99);
				break;
			case 23:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt3044, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3100, DirectionManager.MOVIE.bzt3044, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0685, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0686, Sound.CH.SE1, true, 1f, 9);
				evt.eventPlaySound(DirectionManager.SOUND.S0683, Sound.CH.SE0, true, 1f, 35);
				evt.eventPlaySound(DirectionManager.SOUND.S1677, Sound.CH.VC0, true, 1f, 66);
				evt.eventPlaySound(DirectionManager.SOUND.S1676, Sound.CH.VC1, true, 1f, 99);
				break;
			case 24:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt3201, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd005, DirectionManager.MOVIE.bzt3201, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3005, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3005_loop, DirectionManager.MOVIE.bzt3005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0685, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0687, Sound.CH.SE1, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0667, Sound.CH.SE0, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S1049, Sound.CH.VC0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 37);
				break;
			case 25:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt3202, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd005, DirectionManager.MOVIE.bzt3202, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3005, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3005_loop, DirectionManager.MOVIE.bzt3005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0685, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0687, Sound.CH.SE1, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0667, Sound.CH.SE0, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S1049, Sound.CH.VC0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 37);
				break;
			case 26:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt3203, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd005, DirectionManager.MOVIE.bzt3203, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3005, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3005_loop, DirectionManager.MOVIE.bzt3005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0685, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0687, Sound.CH.SE1, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0667, Sound.CH.SE0, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S1049, Sound.CH.VC0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 37);
				break;
			case 27:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt3204, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd005, DirectionManager.MOVIE.bzt3204, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3005, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3005_loop, DirectionManager.MOVIE.bzt3005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0685, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0687, Sound.CH.SE1, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0667, Sound.CH.SE0, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S1049, Sound.CH.VC0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 37);
				break;
			case 28:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt3205, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.yjd005, DirectionManager.MOVIE.bzt3205, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3005, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3005_loop, DirectionManager.MOVIE.bzt3005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0685, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0687, Sound.CH.SE1, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0667, Sound.CH.SE0, true, 1f, 110);
				evt.eventPlaySound(DirectionManager.SOUND.S1049, Sound.CH.VC0, true, 1f, 133);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 37);
				break;
			case 29:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3005, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt3005_loop, DirectionManager.MOVIE.bzt3005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0667, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S1049, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				break;
			case 30:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt4001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt4001_loop, DirectionManager.MOVIE.bzt4001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0426, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0539, Sound.CH.SE1, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S1678, Sound.CH.VC0, true, 1f, 12);
				break;
			case 31:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt4010, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt4010_loop, DirectionManager.MOVIE.bzt4010, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0632, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1674, Sound.CH.VC0, true, 1f, 17);
				evt.eventPlaySound(DirectionManager.SOUND.S0641, Sound.CH.SE1, true, 1f, 18);
				break;
			case 32:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt4011, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt4011_loop, DirectionManager.MOVIE.bzt4011, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0638, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0621, Sound.CH.SE1, true, 1f, 19);
				evt.eventPlaySound(DirectionManager.SOUND.S1675, Sound.CH.VC0, true, 1f, 26);
				break;
			case 33:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt4012, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt4012_loop, DirectionManager.MOVIE.bzt4012, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0673, Sound.CH.SE1, true, 1f, 60);
				evt.eventPlaySound(DirectionManager.SOUND.S1689, Sound.CH.VC0, true, 1f, 85);
				evt.eventPlaySound(DirectionManager.SOUND.S0643, Sound.CH.SE0, true, 1f, 97);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt4012_add, false, false, true, false, 0, 0, 98, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt4012_add_loop, DirectionManager.MOVIE.bzt4012_add, false, true, true, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt4012_nml, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt4012_nml_loop, DirectionManager.MOVIE.bzt4012_nml, false, true, false, false);
				break;
			case 34:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt4002, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt4002_loop, DirectionManager.MOVIE.bzt4002, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0426, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0541, Sound.CH.SE1, true, 1f, 14);
				evt.eventPlaySound(DirectionManager.SOUND.S1680, Sound.CH.VC0, true, 1f, 20);
				break;
			case 35:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt4020, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt4020_loop, DirectionManager.MOVIE.bzt4020, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0688, Sound.CH.SE1, true, 1f, 60);
				evt.eventPlaySound(DirectionManager.SOUND.S1681, Sound.CH.VC0, true, 1f, 60);
				break;
			case 36:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt4021, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt4021_loop, DirectionManager.MOVIE.bzt4021, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0689, Sound.CH.SE1, true, 1f, 60);
				evt.eventPlaySound(DirectionManager.SOUND.S1683, Sound.CH.VC0, true, 1f, 60);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt4021_nml, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt4021_nml_loop, DirectionManager.MOVIE.bzt4021_nml, false, true, false, false);
				break;
			case 37:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt4022, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt4022_loop, DirectionManager.MOVIE.bzt4022, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0639, Sound.CH.SE1, true, 1f, 60);
				evt.eventPlaySound(DirectionManager.SOUND.S1679, Sound.CH.VC0, true, 1f, 70);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt4022_nml, false, false, false, false, 0, 0, 99, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt4022_nml_loop, DirectionManager.MOVIE.bzt4022_nml, false, true, false, false);
				break;
			case 38:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt4032, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0485, Sound.CH.SE1, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0887, Sound.CH.VC0, true, 1f, 32);
				break;
			case 40:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt5002, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0493, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0942, Sound.CH.VC0, true, 1f, 83);
				evt.eventPlaySound(DirectionManager.SOUND.S0484, Sound.CH.SE1, true, 1f, 104);
				evt.eventPlaySound(DirectionManager.SOUND.S0914, Sound.CH.VC1, true, 1f, 114);
				evt.eventPlaySound(DirectionManager.SOUND.S0603, Sound.CH.SE0, true, 1f, 140);
				evt.eventPlaySound(DirectionManager.SOUND.S1672, Sound.CH.VC0, true, 1f, 184);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				break;
			case 41:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt5003, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0631, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1684, Sound.CH.VC0, true, 1f, 80);
				break;
			case 42:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt5004, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0647, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1690, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S1672, Sound.CH.VC1, true, 1f, 43);
				break;
			case 43:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt5005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt5005_loop, DirectionManager.MOVIE.bzt5005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0429, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1691, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1685, Sound.CH.VC1, true, 1f, 35);
				break;
			case 44:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt6001, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1692, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0922, Sound.CH.VC0, true, 1f, 0);
				break;
			case 45:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt6011, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0268, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0939, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0941, Sound.CH.VC1, true, 1f, 40);
				break;
			case 46:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt7010_a, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt7010_a_loop, DirectionManager.MOVIE.bzt7010_a, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0667, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S1049, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				break;
			case 47:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt6003_1, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1656, Sound.CH.VC0, true, 1f, 8);
				break;
			case 48:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt6003_2, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0968, Sound.CH.VC0, true, 1f, 0);
				break;
			case 49:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt6004_1, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1687, Sound.CH.VC0, true, 1f, 0);
				break;
			case 50:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt6004_2, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0968, Sound.CH.VC0, true, 1f, 0);
				break;
			case 51:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt7001_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1686, Sound.CH.SE0, true, 1f, 0);
				break;
			case 52:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt7001_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0285, Sound.CH.SE0, true, 1f, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 0, 150);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt7001_b_a, false, false, false, true, 128, 43, 90, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt7001_b_b, false, false, false, true, 83, 107, 89, 0);
				break;
			case 54:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt7002, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt7002_loop, DirectionManager.MOVIE.bzt7002, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 74);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt7010_a, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt7010_a_loop, DirectionManager.MOVIE.bzt7010_a, false, true, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0433, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1315, Sound.CH.VC0, true, 1f, 9);
				evt.eventPlaySound(DirectionManager.SOUND.S0495, Sound.CH.SE1, true, 1f, 145);
				evt.eventPlaySound(DirectionManager.SOUND.S0821, Sound.CH.VC1, true, 1f, 145);
				evt.eventPlaySound(DirectionManager.SOUND.S0257, Sound.CH.SE0, true, 1f, 178);
				evt.eventPlaySound(DirectionManager.SOUND.S1977, Sound.CH.SE1, true, 1f, 190);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 74);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 0, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt7010_b, false, false, false, false, 0, 0, 95, 190);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt7010_b_add, false, false, true, false, 0, 0, 90, 190);
				break;
			case 55:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt7003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt7003_loop, DirectionManager.MOVIE.bzt7003, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 74);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt7010_a, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt7010_a_loop, DirectionManager.MOVIE.bzt7010_a, false, true, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0433, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1318, Sound.CH.VC0, true, 1f, 9);
				evt.eventPlaySound(DirectionManager.SOUND.S0495, Sound.CH.SE1, true, 1f, 145);
				evt.eventPlaySound(DirectionManager.SOUND.S0821, Sound.CH.VC1, true, 1f, 145);
				evt.eventPlaySound(DirectionManager.SOUND.S0257, Sound.CH.SE0, true, 1f, 178);
				evt.eventPlaySound(DirectionManager.SOUND.S1977, Sound.CH.SE1, true, 1f, 190);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 74);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 0, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt7010_b, false, false, false, false, 0, 0, 95, 190);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt7010_b_add, false, false, true, false, 0, 0, 90, 190);
				break;
			case 56:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt7004_1, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1656, Sound.CH.VC0, true, 1f, 8);
				break;
			case 57:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt7004_2, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1676, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0257, Sound.CH.SE0, true, 1f, 42);
				evt.eventPlaySound(DirectionManager.SOUND.S1977, Sound.CH.SE1, true, 1f, 54);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt7010_b, false, false, false, false, 0, 0, 95, 54);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt7010_b_add, false, false, true, false, 0, 0, 90, 54);
				break;
			case 58:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt7005_1, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1688, Sound.CH.VC0, true, 1f, 8);
				break;
			case 59:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt7005_2, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1676, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0257, Sound.CH.SE0, true, 1f, 44);
				evt.eventPlaySound(DirectionManager.SOUND.S1977, Sound.CH.SE1, true, 1f, 56);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt7010_b, false, false, false, false, 0, 0, 95, 56);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt7010_b_add, false, false, true, false, 0, 0, 90, 56);
				break;
			case 60:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt5001_1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt5001, DirectionManager.MOVIE.bzt5001_1, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0671, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0940, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0594, Sound.CH.SE1, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S0939, Sound.CH.VC1, true, 1f, 59);
				break;
			case 61:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt5001_2, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt5001, DirectionManager.MOVIE.bzt5001_2, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0671, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0940, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0594, Sound.CH.SE1, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S0939, Sound.CH.VC1, true, 1f, 59);
				break;
			case 62:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt5001_3, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt5001, DirectionManager.MOVIE.bzt5001_3, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0671, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0940, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0594, Sound.CH.SE1, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S0939, Sound.CH.VC1, true, 1f, 59);
				break;
			case 63:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt5001_4, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt5001, DirectionManager.MOVIE.bzt5001_4, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0671, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0940, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0594, Sound.CH.SE1, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S0939, Sound.CH.VC1, true, 1f, 59);
				break;
			case 64:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt5001_5, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt5001, DirectionManager.MOVIE.bzt5001_5, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0671, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0940, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0594, Sound.CH.SE1, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S0939, Sound.CH.VC1, true, 1f, 59);
				break;
			case 65:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bzt5001_6, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bzt5001, DirectionManager.MOVIE.bzt5001_6, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0671, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0940, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0594, Sound.CH.SE1, true, 1f, 40);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 59);
				evt.eventPlaySound(DirectionManager.SOUND.S0939, Sound.CH.VC1, true, 1f, 59);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 2:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 3:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_BZT_title(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 4:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 5:
				DirectionLedManager.GH_BZT_06(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				DirectionLedManager.YK_BZT_bal(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 6:
				DirectionLedManager.GH_BZT_04(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				DirectionLedManager.YK_BZT_sol_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 7:
				DirectionLedManager.GH_BZT_05(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				DirectionLedManager.YK_BZT_sol_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 8:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 9:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 10:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 11:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 12:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 13:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 14:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 15:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 16:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 17:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 18:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 19:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 20:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 21:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 22:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 23:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 24:
				DirectionLedManager.GH_BZT_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				DirectionLedManager.YK_BZT_sol_03(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 25:
				DirectionLedManager.GH_BZT_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				DirectionLedManager.YK_BZT_sol_03(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 26:
				DirectionLedManager.GH_BZT_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				DirectionLedManager.YK_BZT_sol_03(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 27:
				DirectionLedManager.GH_BZT_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				DirectionLedManager.YK_BZT_sol_03(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 28:
				DirectionLedManager.GH_BZT_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				DirectionLedManager.YK_BZT_sol_03(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 29:
				DirectionLedManager.GH_BZT_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 30:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 31:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 32:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 33:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 34:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 35:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 36:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 37:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 38:
				DirectionLedManager.GH_BZT_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 40:
				DirectionLedManager.GH_BZT_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 41:
				DirectionLedManager.GH_BZT_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 42:
				DirectionLedManager.GH_BZT_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 43:
				DirectionLedManager.GH_BZT_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 44:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 45:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 46:
				DirectionLedManager.GH_BZT_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 47:
				DirectionLedManager.GH_BZT_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 48:
				DirectionLedManager.GH_BZT_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 49:
				DirectionLedManager.GH_BZT_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 50:
				DirectionLedManager.GH_BZT_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 51:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 52:
				DirectionLedManager.GH_BZT_end(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				DirectionLedManager.BG_BZT_end(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
				break;
			case 54:
				DirectionLedManager.GH_BZT_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				DirectionLedManager.YK_BZT_revival(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 55:
				DirectionLedManager.GH_BZT_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				DirectionLedManager.YK_BZT_revival(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 56:
				DirectionLedManager.GH_BZT_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 57:
				DirectionLedManager.GH_BZT_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 58:
				DirectionLedManager.GH_BZT_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 59:
				DirectionLedManager.GH_BZT_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 60:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 61:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 62:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 63:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 64:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			case 65:
				DirectionLedManager.GH_BZT_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
				break;
			}
		}
		titleCall();
		base.start();
	}

	public void titleCall()
	{
		int num = MainGameScene.slotGameMan.get_pkd_data(593);
		DirectionManager.SOUND[] array = new DirectionManager.SOUND[8]
		{
			DirectionManager.SOUND.S1046,
			DirectionManager.SOUND.S1046,
			DirectionManager.SOUND.S1311,
			DirectionManager.SOUND.S1357,
			DirectionManager.SOUND.S1727,
			DirectionManager.SOUND.S1763,
			DirectionManager.SOUND.S1634,
			DirectionManager.SOUND.S1804
		};
		int num2 = 8;
		if (num > 0 && num2 > num && low == 0)
		{
			byte b = mode;
			if (b == 3)
			{
				evt.eventPlaySound(array[num], Sound.CH.VC0, false, 1f, 20);
			}
		}
	}

	public override void end()
	{
		base.end();
	}

	public override void control()
	{
		if (evt.m_Active && low == 0)
		{
			byte b = mode;
			if (b == 52)
			{
				if (m_cnt == 0)
				{
					MainGameScene.pnlMan.onBzt7001_total();
				}
				if (m_cnt == 20)
				{
					MainGameScene.pnlMan.onBzt7001_get();
				}
			}
			m_cnt++;
		}
		base.control();
	}

	private void restartBGM()
	{
		if (low != 0)
		{
			return;
		}
		switch (mode)
		{
		case 3:
		case 44:
		case 45:
		case 46:
		case 53:
		case 54:
		case 55:
			return;
		case 56:
		case 57:
		case 58:
		case 59:
			if (SGLG.sound.getBGMID() == 76)
			{
				if (SGLG.sound.getBGMVolume() < 1f)
				{
					evt.eventFadeSound(Sound.CH.BGM, 1f, 1f, 1, 0);
				}
			}
			else
			{
				evt.eventPlaySound(DirectionManager.SOUND.S0181, Sound.CH.BGM, false, 1f, 0);
			}
			return;
		}
		if (SGLG.sound.getBGMID() == 75)
		{
			if (SGLG.sound.getBGMVolume() < 1f)
			{
				evt.eventFadeSound(Sound.CH.BGM, 1f, 1f, 1, 0);
			}
		}
		else
		{
			evt.eventPlaySound(DirectionManager.SOUND.S0180, Sound.CH.BGM, false, 1f, 0);
		}
	}
}
