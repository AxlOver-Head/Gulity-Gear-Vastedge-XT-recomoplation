public class DirectionYuugiSnd : DirectionBase
{
	public DirectionYuugiSnd(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
			case 0:
				evt.eventPlaySound(DirectionManager.SOUND.S1049, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 1:
				evt.eventPlaySound(DirectionManager.SOUND.S1801, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0341, Sound.CH.SE0, true, 1f, 0);
				break;
			case 2:
				evt.eventPlaySound(DirectionManager.SOUND.S0342, Sound.CH.SE0, true, 1f, 0);
				break;
			case 3:
				evt.eventPlaySound(DirectionManager.SOUND.S1800, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0344, Sound.CH.SE0, true, 1f, 0);
				break;
			}
			break;
		case 1:
			switch (mode)
			{
			case 0:
				evt.eventPlaySound(DirectionManager.SOUND.S0298, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 1:
				evt.eventPlaySound(DirectionManager.SOUND.S0301, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 2:
				evt.eventPlaySound(DirectionManager.SOUND.S0303, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 3:
				evt.eventPlaySound(DirectionManager.SOUND.S0304, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 4:
				evt.eventPlaySound(DirectionManager.SOUND.S0313, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 5:
				evt.eventPlaySound(DirectionManager.SOUND.S0314, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 6:
				evt.eventPlaySound(DirectionManager.SOUND.S0315, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 7:
				evt.eventPlaySound(DirectionManager.SOUND.S0316, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 8:
				evt.eventPlaySound(DirectionManager.SOUND.S0317, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 9:
				evt.eventPlaySound(DirectionManager.SOUND.S0318, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 10:
				evt.eventPlaySound(DirectionManager.SOUND.S0319, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 11:
				evt.eventPlaySound(DirectionManager.SOUND.S0320, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 12:
				evt.eventPlaySound(DirectionManager.SOUND.S0325, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 13:
				evt.eventPlaySound(DirectionManager.SOUND.S0328, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 14:
				evt.eventPlaySound(DirectionManager.SOUND.S0333, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 15:
				evt.eventPlaySound(DirectionManager.SOUND.S0334, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 16:
				evt.eventPlaySound(DirectionManager.SOUND.S0337, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 17:
				evt.eventPlaySound(DirectionManager.SOUND.S0338, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 18:
				evt.eventPlaySound(DirectionManager.SOUND.S0340, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 19:
				evt.eventPlaySound(DirectionManager.SOUND.S0346, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 20:
				evt.eventPlaySound(DirectionManager.SOUND.S1795, Sound.CH.OTHER, true, 1f, 0);
				break;
			}
			break;
		case 2:
			if (mode == 0)
			{
				evt.eventPlaySound(DirectionManager.SOUND.S0302, Sound.CH.OTHER, true, 1f, 0);
			}
			break;
		case 3:
			switch (mode)
			{
			case 0:
				evt.eventPlaySound(DirectionManager.SOUND.S0294, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 1:
				evt.eventPlaySound(DirectionManager.SOUND.S0299, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 2:
				evt.eventPlaySound(DirectionManager.SOUND.S0305, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 3:
				evt.eventPlaySound(DirectionManager.SOUND.S0326, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 4:
				evt.eventPlaySound(DirectionManager.SOUND.S0329, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 5:
				evt.eventPlaySound(DirectionManager.SOUND.S0330, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 6:
				evt.eventPlaySound(DirectionManager.SOUND.S0331, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 7:
				evt.eventPlaySound(DirectionManager.SOUND.S0332, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 8:
				evt.eventPlaySound(DirectionManager.SOUND.S0335, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 9:
				evt.eventPlaySound(DirectionManager.SOUND.S0339, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 10:
				evt.eventPlaySound(DirectionManager.SOUND.S0341, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 11:
				evt.eventPlaySound(DirectionManager.SOUND.S0342, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 12:
				evt.eventPlaySound(DirectionManager.SOUND.S0343, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 13:
				evt.eventPlaySound(DirectionManager.SOUND.S0344, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 14:
				evt.eventPlaySound(DirectionManager.SOUND.S0345, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 15:
				evt.eventPlaySound(DirectionManager.SOUND.S0347, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 16:
				evt.eventPlaySound(DirectionManager.SOUND.S0348, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 17:
				evt.eventPlaySound(DirectionManager.SOUND.S0349, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 18:
				evt.eventPlaySound(DirectionManager.SOUND.S1801, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 19:
				evt.eventPlaySound(DirectionManager.SOUND.S1800, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 20:
				evt.eventPlaySound(DirectionManager.SOUND.S1409, Sound.CH.OTHER, true, 1f, 0);
				break;
			}
			break;
		case 4:
			switch (mode)
			{
			case 1:
				evt.eventPlaySound(DirectionManager.SOUND.S0307, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 2:
				evt.eventPlaySound(DirectionManager.SOUND.S0308, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 3:
				evt.eventPlaySound(DirectionManager.SOUND.S0309, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 4:
				evt.eventPlaySound(DirectionManager.SOUND.S0310, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 5:
				evt.eventPlaySound(DirectionManager.SOUND.S0311, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 6:
				evt.eventPlaySound(DirectionManager.SOUND.S0312, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 7:
				evt.eventPlaySound(DirectionManager.SOUND.S0322, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 8:
				evt.eventPlaySound(DirectionManager.SOUND.S0323, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 9:
				evt.eventPlaySound(DirectionManager.SOUND.S0324, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 10:
				evt.eventPlaySound(DirectionManager.SOUND.S0327, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 11:
				evt.eventPlaySound(DirectionManager.SOUND.S0295, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 12:
				evt.eventPlaySound(DirectionManager.SOUND.S0296, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 13:
				evt.eventPlaySound(DirectionManager.SOUND.S0297, Sound.CH.OTHER, true, 1f, 0);
				break;
			case 14:
				evt.eventPlaySound(DirectionManager.SOUND.S0306, Sound.CH.OTHER, true, 1f, 0);
				break;
			}
			break;
		case 5:
			switch (mode)
			{
			case 1:
				evt.eventPlaySound(DirectionManager.SOUND.S0078, Sound.CH.SE0, false, 1f, 0);
				break;
			case 2:
				evt.eventPlaySound(DirectionManager.SOUND.S0079, Sound.CH.SE0, false, 1f, 0);
				break;
			case 3:
				evt.eventPlaySound(DirectionManager.SOUND.S0081, Sound.CH.SE0, false, 1f, 0);
				break;
			case 4:
				evt.eventPlaySound(DirectionManager.SOUND.S0082, Sound.CH.SE0, false, 1f, 0);
				break;
			case 5:
				evt.eventPlaySound(DirectionManager.SOUND.S0083, Sound.CH.SE0, false, 1f, 0);
				break;
			case 6:
				evt.eventPlaySound(DirectionManager.SOUND.S0078, Sound.CH.SE0, false, 1f, 0);
				break;
			case 7:
				evt.eventPlaySound(DirectionManager.SOUND.S0079, Sound.CH.SE0, false, 1f, 0);
				break;
			case 8:
				evt.eventPlaySound(DirectionManager.SOUND.S0081, Sound.CH.SE0, false, 1f, 0);
				break;
			case 9:
				evt.eventPlaySound(DirectionManager.SOUND.S0084, Sound.CH.SE0, false, 1f, 0);
				break;
			case 10:
				evt.eventPlaySound(DirectionManager.SOUND.S0079, Sound.CH.SE0, false, 1f, 0);
				break;
			case 11:
				evt.eventPlaySound(DirectionManager.SOUND.S0081, Sound.CH.SE0, false, 1f, 0);
				break;
			case 12:
				evt.eventPlaySound(DirectionManager.SOUND.S0085, Sound.CH.SE0, false, 1f, 0);
				break;
			case 13:
				evt.eventPlaySound(DirectionManager.SOUND.S0081, Sound.CH.SE0, false, 1f, 0);
				break;
			case 14:
				evt.eventPlaySound(DirectionManager.SOUND.S0086, Sound.CH.SE0, false, 1f, 0);
				break;
			case 15:
				evt.eventPlaySound(DirectionManager.SOUND.S0087, Sound.CH.SE0, false, 1f, 0);
				break;
			}
			break;
		case 6:
			switch (mode)
			{
			case 1:
				evt.eventPlaySound(DirectionManager.SOUND.S0077, Sound.CH.OTHER, false, 1f, 0);
				break;
			case 2:
				evt.eventPlaySound(DirectionManager.SOUND.S0093, Sound.CH.OTHER, false, 1f, 0);
				break;
			}
			break;
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
