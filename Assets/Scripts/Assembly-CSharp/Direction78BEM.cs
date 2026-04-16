public class Direction78BEM : DirectionBase
{
	private int m_cnt;

	public Direction78BEM(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		m_cnt = 0;
		base.start();
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				evt.eventPlayMovie(DirectionManager.MOVIE.bem001, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0207, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1696, Sound.CH.SE0, true, 1f, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S0886, Sound.CH.VC0, true, 1f, 56);
				evt.eventDisableBefore(mng, 0);
				break;
			case 2:
				evt.eventPlayMovie(DirectionManager.MOVIE.bem002, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1697, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0885, Sound.CH.VC0, true, 1f, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bem002_loop, DirectionManager.MOVIE.bem002, false, true, false, false);
				break;
			case 3:
				evt.eventPlayMovie(DirectionManager.MOVIE.bem003, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0533, Sound.CH.SE0, true, 1f, 15);
				evt.eventPlaySound(DirectionManager.SOUND.S0479, Sound.CH.VC0, true, 1f, 38);
				evt.eventAddMovie(DirectionManager.MOVIE.bem003_loop, DirectionManager.MOVIE.bem003, false, true, false, false);
				break;
			case 4:
				evt.eventPlayMovie(DirectionManager.MOVIE.bem004, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0484, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1691, Sound.CH.VC0, true, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0670, Sound.CH.VC0, true, 1f, 24);
				evt.eventPlaySound(DirectionManager.SOUND.S0915, Sound.CH.VC1, true, 1f, 30);
				evt.eventAddMovie(DirectionManager.MOVIE.bem004_loop, DirectionManager.MOVIE.bem004, false, true, false, false);
				break;
			case 5:
				evt.eventPlayMovie(DirectionManager.MOVIE.bem005, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0608, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0888, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, true, 1f, 55);
				evt.eventPlaySound(DirectionManager.SOUND.S1691, Sound.CH.VC1, true, 1f, 55);
				evt.eventAddMovie(DirectionManager.MOVIE.bem005_loop, DirectionManager.MOVIE.bem005, false, true, false, false);
				break;
			case 6:
				evt.eventPlayMovie(DirectionManager.MOVIE.bem006, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0889, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0467, Sound.CH.SE0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1665, Sound.CH.VC1, true, 1f, 45);
				evt.eventAddMovie(DirectionManager.MOVIE.bem006_loop, DirectionManager.MOVIE.bem006, false, true, false, false);
				break;
			case 7:
				evt.eventPlayMovie(DirectionManager.MOVIE.bem007, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1698, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1666, Sound.CH.VC0, true, 1f, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bem007_loop, DirectionManager.MOVIE.bem007, false, true, false, false);
				break;
			case 8:
				evt.eventPlayMovie(DirectionManager.MOVIE.bem008, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1699, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1667, Sound.CH.VC0, true, 1f, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bem008_loop, DirectionManager.MOVIE.bem008, false, true, false, false);
				break;
			case 9:
				evt.eventPlayMovie(DirectionManager.MOVIE.bem009, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0207, Sound.CH.BGM, false, 1f, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bem009_loop, DirectionManager.MOVIE.bem009, false, true, false, false);
				break;
			case 10:
				evt.eventPlayMovie(DirectionManager.MOVIE.bem010, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1648, Sound.CH.SE0, true, 1f, 65);
				evt.eventPlaySound(DirectionManager.SOUND.S1245, Sound.CH.VC0, true, 1f, 90);
				evt.eventAddMovie(DirectionManager.MOVIE.bem010_loop, DirectionManager.MOVIE.bem010, false, true, false, false);
				break;
			case 11:
				evt.eventPlayMovie(DirectionManager.MOVIE.bem011, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1352, Sound.CH.VC0, true, 1f, 52);
				evt.eventPlaySound(DirectionManager.SOUND.S1459, Sound.CH.SE0, true, 1f, 132);
				evt.eventAddMovie(DirectionManager.MOVIE.bem011_loop, DirectionManager.MOVIE.bem011, false, true, false, false);
				break;
			case 12:
				evt.eventPlayMovie(DirectionManager.MOVIE.bem012, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.bem012_loop, DirectionManager.MOVIE.bem012, false, true, false, false);
				break;
			case 13:
				evt.eventPlayMovie(DirectionManager.MOVIE.bem013, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0738, Sound.CH.VC0, true, 1f, 43);
				evt.eventAddMovie(DirectionManager.MOVIE.bem013_loop, DirectionManager.MOVIE.bem013, false, true, false, false);
				break;
			case 14:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.bem014, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1649, Sound.CH.SE0, true, 1f, 0);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.YK_BEM_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 2:
				DirectionLedManager.YK_BEM_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 3:
				DirectionLedManager.YK_BEM_03(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 4:
				DirectionLedManager.YK_BEM_04(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 5:
				DirectionLedManager.YK_BEM_05(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 6:
				DirectionLedManager.YK_BEM_06(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 7:
				DirectionLedManager.YK_BEM_07(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 8:
				DirectionLedManager.YK_BEM_08(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 9:
				DirectionLedManager.YK_BEM_09(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 10:
				DirectionLedManager.YK_BEM_10(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 11:
				DirectionLedManager.YK_BEM_11(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 12:
				DirectionLedManager.YK_BEM_12(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 13:
				DirectionLedManager.YK_BEM_13(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 14:
				DirectionLedManager.YK_BEM_14(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
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
		if (evt.m_Active && low == 0)
		{
			if (mode == 14)
			{
				if (m_cnt == 10)
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
}
