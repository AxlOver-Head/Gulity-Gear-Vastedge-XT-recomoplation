public class Direction91SND : DirectionBase
{
	public Direction91SND(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		base.start();
		switch (low)
		{
		case 0:
			switch (mode)
			{
			case 1:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0999, Sound.CH.VC0, true, 1f, 10);
				break;
			case 2:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1005, Sound.CH.VC0, true, 1f, 10);
				break;
			case 3:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1007, Sound.CH.VC0, true, 1f, 10);
				break;
			case 4:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1314, Sound.CH.VC0, true, 1f, 10);
				break;
			case 5:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1288, Sound.CH.VC0, true, 1f, 10);
				break;
			case 6:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1290, Sound.CH.VC0, true, 1f, 10);
				break;
			case 7:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1319, Sound.CH.VC0, true, 1f, 10);
				break;
			case 8:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1358, Sound.CH.VC0, true, 1f, 10);
				break;
			case 9:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1359, Sound.CH.VC0, true, 1f, 10);
				break;
			case 10:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1399, Sound.CH.VC0, true, 1f, 10);
				break;
			case 11:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1447, Sound.CH.VC0, true, 1f, 10);
				break;
			case 12:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1496, Sound.CH.VC0, true, 1f, 10);
				break;
			case 13:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1549, Sound.CH.VC0, true, 1f, 10);
				break;
			case 14:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1591, Sound.CH.VC0, true, 1f, 10);
				break;
			case 15:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1728, Sound.CH.VC0, true, 1f, 10);
				break;
			case 16:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1729, Sound.CH.VC0, true, 1f, 10);
				break;
			case 17:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1753, Sound.CH.VC0, true, 1f, 10);
				break;
			case 18:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1756, Sound.CH.VC0, true, 1f, 10);
				break;
			case 19:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1808, Sound.CH.VC0, true, 1f, 10);
				break;
			case 20:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1807, Sound.CH.VC0, true, 1f, 10);
				break;
			case 21:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1635, Sound.CH.VC0, true, 1f, 10);
				break;
			case 22:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1636, Sound.CH.VC0, true, 1f, 10);
				break;
			case 23:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0998, Sound.CH.VC0, true, 1f, 10);
				break;
			case 24:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1008, Sound.CH.VC0, true, 1f, 10);
				break;
			case 25:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1306, Sound.CH.VC0, true, 1f, 10);
				break;
			case 26:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1292, Sound.CH.VC0, true, 1f, 10);
				break;
			case 27:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1333, Sound.CH.VC0, true, 1f, 10);
				break;
			case 28:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1335, Sound.CH.VC0, true, 1f, 10);
				break;
			case 29:
				evt.eventPlaySound(DirectionManager.SOUND.S0287, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1340, Sound.CH.VC0, true, 1f, 10);
				break;
			case 30:
				evt.eventPlaySound(DirectionManager.SOUND.S0302, Sound.CH.SE0, true, 1f, 6);
				break;
			case 31:
				evt.eventPlaySound(DirectionManager.SOUND.S0302, Sound.CH.SE0, true, 1f, 12);
				break;
			case 32:
				evt.eventPlaySound(DirectionManager.SOUND.S0305, Sound.CH.SE0, true, 1f, 4);
				break;
			case 33:
				evt.eventPlaySound(DirectionManager.SOUND.S0288, Sound.CH.SE0, true, 1f, 0);
				break;
			}
			break;
		case 1:
			switch (mode)
			{
			case 1:
				evt.eventPlaySound(DirectionManager.SOUND.S0300, Sound.CH.OTHER, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0300, Sound.CH.OTHER, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0300, Sound.CH.OTHER, true, 1f, 10);
				break;
			case 2:
				evt.eventPlaySound(DirectionManager.SOUND.S0301, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 3:
				evt.eventPlaySound(DirectionManager.SOUND.S0302, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 4:
				evt.eventPlaySound(DirectionManager.SOUND.S0305, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 5:
				evt.eventPlaySound(DirectionManager.SOUND.S0306, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 6:
				evt.eventPlaySound(DirectionManager.SOUND.S0307, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 7:
				evt.eventPlaySound(DirectionManager.SOUND.S0308, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 8:
				evt.eventPlaySound(DirectionManager.SOUND.S0309, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 9:
				evt.eventPlaySound(DirectionManager.SOUND.S0310, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 10:
				evt.eventPlaySound(DirectionManager.SOUND.S0311, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 11:
				evt.eventPlaySound(DirectionManager.SOUND.S0312, Sound.CH.OTHER, true, 1f, 0);
				break;
			}
			break;
		case 4:
			switch (mode)
			{
			case 1:
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE0, false, 1f, 0);
				break;
			case 2:
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE0, false, 1f, 0);
				break;
			case 3:
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE0, false, 1f, 0);
				break;
			case 4:
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE0, false, 1f, 0);
				break;
			case 5:
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE0, false, 1f, 0);
				break;
			case 6:
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE0, false, 1f, 0);
				break;
			case 7:
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE0, false, 1f, 0);
				break;
			case 8:
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE0, false, 1f, 0);
				break;
			case 9:
				evt.eventPlaySound(DirectionManager.SOUND.S0224, Sound.CH.SE0, false, 1f, 0);
				break;
			case 10:
				evt.eventPlaySound(DirectionManager.SOUND.S0225, Sound.CH.SE0, false, 1f, 0);
				break;
			case 11:
				evt.eventPlaySound(DirectionManager.SOUND.S0226, Sound.CH.SE0, false, 1f, 0);
				break;
			case 12:
				evt.eventPlaySound(DirectionManager.SOUND.S0227, Sound.CH.SE0, false, 1f, 0);
				break;
			case 13:
				evt.eventPlaySound(DirectionManager.SOUND.S0228, Sound.CH.SE0, false, 1f, 0);
				break;
			case 14:
				evt.eventPlaySound(DirectionManager.SOUND.S0229, Sound.CH.SE0, false, 1f, 0);
				break;
			case 15:
				evt.eventPlaySound(DirectionManager.SOUND.S0230, Sound.CH.SE0, false, 1f, 0);
				break;
			case 16:
				evt.eventPlaySound(DirectionManager.SOUND.S0231, Sound.CH.SE0, false, 1f, 0);
				break;
			case 17:
				evt.eventPlaySound(DirectionManager.SOUND.S0165, Sound.CH.SE0, false, 1f, 0);
				break;
			case 18:
				evt.eventPlaySound(DirectionManager.SOUND.S0099, Sound.CH.SE0, false, 1f, 0);
				break;
			case 19:
				evt.eventPlaySound(DirectionManager.SOUND.S0100, Sound.CH.SE0, false, 1f, 0);
				break;
			case 20:
				evt.eventPlaySound(DirectionManager.SOUND.S0098, Sound.CH.SE0, false, 1f, 0);
				break;
			case 21:
				evt.eventPlaySound(DirectionManager.SOUND.S0587, Sound.CH.SE0, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0091, Sound.CH.SE1, false, 1f, 3);
				break;
			case 22:
				evt.eventPlaySound(DirectionManager.SOUND.S0587, Sound.CH.SE0, false, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0091, Sound.CH.SE1, false, 1f, 3);
				evt.eventPlaySound(DirectionManager.SOUND.S0217, Sound.CH.SE0, false, 1f, 3);
				break;
			case 23:
				evt.eventPlaySound(DirectionManager.SOUND.S0472, Sound.CH.SE0, false, 1f, 0);
				break;
			case 24:
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, false, 1f, 0);
				break;
			case 25:
				evt.eventPlaySound(DirectionManager.SOUND.S0233, Sound.CH.SE0, false, 1f, 0);
				break;
			case 26:
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, false, 1f, 0);
				break;
			case 27:
				evt.eventPlaySound(DirectionManager.SOUND.S0233, Sound.CH.SE0, false, 1f, 0);
				break;
			case 28:
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, false, 1f, 0);
				break;
			case 29:
				evt.eventPlaySound(DirectionManager.SOUND.S0233, Sound.CH.SE0, false, 1f, 0);
				break;
			case 30:
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, false, 1f, 0);
				break;
			case 31:
				evt.eventPlaySound(DirectionManager.SOUND.S0233, Sound.CH.SE0, false, 1f, 0);
				break;
			case 32:
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, false, 1f, 0);
				break;
			case 33:
				evt.eventPlaySound(DirectionManager.SOUND.S0233, Sound.CH.SE0, false, 1f, 0);
				break;
			case 34:
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE0, false, 1f, 0);
				break;
			case 35:
				evt.eventPlaySound(DirectionManager.SOUND.S0240, Sound.CH.SE0, false, 1f, 0);
				break;
			case 36:
				evt.eventPlaySound(DirectionManager.SOUND.S1448, Sound.CH.SE0, false, 1f, 0);
				break;
			case 37:
				evt.eventPlaySound(DirectionManager.SOUND.S1449, Sound.CH.SE0, false, 1f, 0);
				break;
			case 38:
				evt.eventPlaySound(DirectionManager.SOUND.S0233, Sound.CH.SE0, false, 1f, 0);
				break;
			case 39:
				evt.eventPlaySound(DirectionManager.SOUND.S0240, Sound.CH.SE0, false, 1f, 0);
				break;
			case 40:
				evt.eventPlaySound(DirectionManager.SOUND.S0233, Sound.CH.SE0, false, 1f, 0);
				break;
			case 41:
				evt.eventPlaySound(DirectionManager.SOUND.S0240, Sound.CH.SE0, false, 1f, 0);
				break;
			case 42:
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, false, 1f, 0);
				break;
			case 43:
				evt.eventPlaySound(DirectionManager.SOUND.S0233, Sound.CH.SE0, false, 1f, 0);
				break;
			case 44:
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE0, false, 1f, 0);
				break;
			case 45:
				evt.eventPlaySound(DirectionManager.SOUND.S0240, Sound.CH.SE0, false, 1f, 0);
				break;
			case 46:
				evt.eventPlaySound(DirectionManager.SOUND.S0234, Sound.CH.SE0, false, 1f, 0);
				break;
			case 47:
				evt.eventPlaySound(DirectionManager.SOUND.S0240, Sound.CH.SE0, false, 1f, 0);
				break;
			}
			break;
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
			case 16:
				break;
			case 17:
				break;
			case 18:
				break;
			case 19:
				break;
			case 20:
				break;
			case 21:
				break;
			case 22:
				break;
			case 23:
				break;
			case 24:
				break;
			case 25:
				break;
			case 26:
				break;
			case 27:
				break;
			case 28:
				break;
			case 29:
				break;
			case 30:
				break;
			case 31:
				break;
			case 32:
				break;
			case 33:
				break;
			case 34:
				break;
			case 35:
				break;
			case 36:
				break;
			case 37:
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
