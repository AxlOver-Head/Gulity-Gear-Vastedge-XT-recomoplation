public class Direction43KWS : DirectionBase
{
	public Direction43KWS(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		base.start();
		if (mode >= 3 && 15 >= mode)
		{
			MainGameScene.dirMan.StopDirection(DirectionManager.DIR.LEVER_2);
			MainGameScene.dirMan.StopDirection(DirectionManager.DIR.REEL_2);
			MainGameScene.dirMan.StopDirection(DirectionManager.DIR.STOP1_2);
			MainGameScene.dirMan.StopDirection(DirectionManager.DIR.STOP2_2);
			MainGameScene.dirMan.StopDirection(DirectionManager.DIR.STOP3_2);
			MainGameScene.dirMan.StopDirection(DirectionManager.DIR.STOP3OFF_2);
			MainGameScene.dirMan.StopDirection(DirectionManager.DIR.BET_2);
		}
		if (!isResponse())
		{
			evt.eventDisableBefore(mng, 0);
		}
		int num = -1;
		int num2 = 0;
		bool flag = false;
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				num = 1;
				evt.eventPlaySound(DirectionManager.SOUND.S0373, Sound.CH.SE1, true, 1f, 0);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				break;
			case 3:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kws004_sol1, false, false, false, true, 128, 72, 100, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0377, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0730, Sound.CH.VC0, true, 1f, 15);
				break;
			case 4:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kws004_sol1_b, false, false, false, true, 128, 72, 100, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0377, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0731, Sound.CH.VC0, true, 1f, 15);
				evt.eventPlaySound(DirectionManager.SOUND.S0217, Sound.CH.SE0, true, 1f, 6);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kws004_sin1, false, false, false, true, 128, 72, 100, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0377, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1090, Sound.CH.VC0, true, 1f, 15);
				break;
			case 6:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kws004_sin1_b, false, false, false, true, 128, 72, 100, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0377, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1091, Sound.CH.VC0, true, 1f, 15);
				evt.eventPlaySound(DirectionManager.SOUND.S0217, Sound.CH.SE0, true, 1f, 6);
				break;
			case 7:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kws004_kyk1, false, false, false, true, 128, 72, 100, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0377, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1340, Sound.CH.VC0, true, 1f, 15);
				break;
			case 8:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kws004_kyk1_b, false, false, false, true, 128, 72, 100, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0377, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1341, Sound.CH.VC0, true, 1f, 15);
				evt.eventPlaySound(DirectionManager.SOUND.S0217, Sound.CH.SE0, true, 1f, 6);
				break;
			case 9:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kws004_man1, false, false, false, true, 128, 72, 100, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0377, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1610, Sound.CH.VC0, true, 1f, 15);
				break;
			case 10:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kws004_bar1, false, false, false, true, 128, 72, 100, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0377, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1660, Sound.CH.VC0, true, 1f, 15);
				break;
			case 11:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kws004_sla1, false, false, false, true, 128, 72, 100, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0377, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1380, Sound.CH.VC0, true, 1f, 15);
				break;
			case 12:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kws004_chi1, false, false, false, true, 128, 72, 100, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0377, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1430, Sound.CH.VC0, true, 1f, 15);
				break;
			case 13:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kws004_mil1, false, false, false, true, 128, 72, 100, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0377, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1480, Sound.CH.VC0, true, 1f, 15);
				break;
			case 14:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kws004_bri1, false, false, false, true, 128, 72, 100, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0377, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1530, Sound.CH.VC0, true, 1f, 15);
				break;
			case 15:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kws004_zap1, false, false, false, true, 128, 72, 100, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0377, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1580, Sound.CH.VC0, true, 1f, 15);
				break;
			case 16:
				num = 1;
				evt.eventPlaySound(DirectionManager.SOUND.S0374, Sound.CH.SE1, true, 1f, 0);
				break;
			case 17:
				num = 1;
				evt.eventPlaySound(DirectionManager.SOUND.S0375, Sound.CH.SE1, true, 1f, 0);
				break;
			case 18:
				num = 1;
				num2 = 1;
				evt.eventPlaySound(DirectionManager.SOUND.S0376, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0097, Sound.CH.SE1, true, 1f, 6);
				break;
			case 19:
				num = 2;
				evt.eventPlaySound(DirectionManager.SOUND.S0373, Sound.CH.SE1, true, 1f, 0);
				break;
			case 20:
				num = 2;
				evt.eventPlaySound(DirectionManager.SOUND.S0374, Sound.CH.SE1, true, 1f, 0);
				break;
			case 21:
				num = 2;
				evt.eventPlaySound(DirectionManager.SOUND.S0375, Sound.CH.SE1, true, 1f, 0);
				break;
			case 22:
				num = 2;
				num2 = 1;
				evt.eventPlaySound(DirectionManager.SOUND.S0376, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0097, Sound.CH.SE1, true, 1f, 6);
				break;
			case 23:
				num = 3;
				evt.eventPlaySound(DirectionManager.SOUND.S0373, Sound.CH.SE1, true, 1f, 0);
				break;
			case 24:
				num = 3;
				evt.eventPlaySound(DirectionManager.SOUND.S0374, Sound.CH.SE1, true, 1f, 0);
				break;
			case 25:
				num = 3;
				evt.eventPlaySound(DirectionManager.SOUND.S0375, Sound.CH.SE1, true, 1f, 0);
				break;
			case 26:
				num = 3;
				num2 = 1;
				evt.eventPlaySound(DirectionManager.SOUND.S0376, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0097, Sound.CH.SE1, true, 1f, 6);
				break;
			case 27:
				num = 4;
				evt.eventPlaySound(DirectionManager.SOUND.S0373, Sound.CH.SE1, true, 1f, 0);
				break;
			case 28:
				num = 4;
				evt.eventPlaySound(DirectionManager.SOUND.S0374, Sound.CH.SE1, true, 1f, 0);
				break;
			case 29:
				num = 4;
				evt.eventPlaySound(DirectionManager.SOUND.S0375, Sound.CH.SE1, true, 1f, 0);
				break;
			case 30:
				num = 4;
				num2 = 1;
				evt.eventPlaySound(DirectionManager.SOUND.S0376, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0097, Sound.CH.SE1, true, 1f, 6);
				break;
			case 31:
				num = 5;
				evt.eventPlaySound(DirectionManager.SOUND.S0373, Sound.CH.SE1, true, 1f, 0);
				break;
			case 32:
				num = 5;
				evt.eventPlaySound(DirectionManager.SOUND.S0374, Sound.CH.SE1, true, 1f, 0);
				break;
			case 33:
				num = 5;
				evt.eventPlaySound(DirectionManager.SOUND.S0375, Sound.CH.SE1, true, 1f, 0);
				break;
			case 34:
				num = 5;
				num2 = 1;
				evt.eventPlaySound(DirectionManager.SOUND.S0376, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0097, Sound.CH.SE1, true, 1f, 6);
				break;
			case 35:
				num = 6;
				evt.eventPlaySound(DirectionManager.SOUND.S0373, Sound.CH.SE1, true, 1f, 0);
				break;
			case 36:
				num = 6;
				evt.eventPlaySound(DirectionManager.SOUND.S0374, Sound.CH.SE1, true, 1f, 0);
				break;
			case 37:
				num = 6;
				evt.eventPlaySound(DirectionManager.SOUND.S0375, Sound.CH.SE1, true, 1f, 0);
				break;
			case 38:
				num = 6;
				num2 = 1;
				evt.eventPlaySound(DirectionManager.SOUND.S0376, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0097, Sound.CH.SE1, true, 1f, 6);
				break;
			case 39:
				num = 7;
				evt.eventPlaySound(DirectionManager.SOUND.S0373, Sound.CH.SE1, true, 1f, 0);
				break;
			case 40:
				num = 7;
				evt.eventPlaySound(DirectionManager.SOUND.S0374, Sound.CH.SE1, true, 1f, 0);
				break;
			case 41:
				num = 7;
				evt.eventPlaySound(DirectionManager.SOUND.S0375, Sound.CH.SE1, true, 1f, 0);
				break;
			case 42:
				num = 7;
				num2 = 1;
				evt.eventPlaySound(DirectionManager.SOUND.S0376, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0097, Sound.CH.SE1, true, 1f, 6);
				break;
			case 43:
				num = 8;
				evt.eventPlaySound(DirectionManager.SOUND.S0373, Sound.CH.SE1, true, 1f, 0);
				break;
			case 44:
				num = 8;
				evt.eventPlaySound(DirectionManager.SOUND.S0374, Sound.CH.SE1, true, 1f, 0);
				break;
			case 45:
				num = 8;
				evt.eventPlaySound(DirectionManager.SOUND.S0375, Sound.CH.SE1, true, 1f, 0);
				break;
			case 46:
				num = 8;
				num2 = 1;
				evt.eventPlaySound(DirectionManager.SOUND.S0376, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0097, Sound.CH.SE1, true, 1f, 6);
				break;
			case 47:
				num = 9;
				evt.eventPlaySound(DirectionManager.SOUND.S0375, Sound.CH.SE1, true, 1f, 0);
				break;
			case 48:
				num = 9;
				num2 = 1;
				evt.eventPlaySound(DirectionManager.SOUND.S0376, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0097, Sound.CH.SE1, true, 1f, 6);
				break;
			case 49:
				num = 10;
				evt.eventPlaySound(DirectionManager.SOUND.S0375, Sound.CH.SE1, true, 1f, 0);
				break;
			case 50:
				num = 10;
				num2 = 1;
				evt.eventPlaySound(DirectionManager.SOUND.S0376, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0097, Sound.CH.SE1, true, 1f, 6);
				break;
			case 51:
				num = 11;
				evt.eventPlaySound(DirectionManager.SOUND.S0373, Sound.CH.SE1, true, 1f, 0);
				break;
			case 52:
				num = 11;
				evt.eventPlaySound(DirectionManager.SOUND.S0374, Sound.CH.SE1, true, 1f, 0);
				break;
			case 53:
				num = 11;
				evt.eventPlaySound(DirectionManager.SOUND.S0375, Sound.CH.SE1, true, 1f, 0);
				break;
			case 54:
				num = 11;
				num2 = 1;
				evt.eventPlaySound(DirectionManager.SOUND.S0376, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0097, Sound.CH.SE1, true, 1f, 6);
				break;
			case 55:
				num = 12;
				evt.eventPlaySound(DirectionManager.SOUND.S0373, Sound.CH.SE1, true, 1f, 0);
				break;
			case 56:
				num = 12;
				evt.eventPlaySound(DirectionManager.SOUND.S0374, Sound.CH.SE1, true, 1f, 0);
				break;
			case 57:
				num = 12;
				evt.eventPlaySound(DirectionManager.SOUND.S0375, Sound.CH.SE1, true, 1f, 0);
				break;
			case 58:
				num = 12;
				num2 = 1;
				evt.eventPlaySound(DirectionManager.SOUND.S0376, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0097, Sound.CH.SE1, true, 1f, 6);
				break;
			case 59:
				num = 13;
				evt.eventPlaySound(DirectionManager.SOUND.S0373, Sound.CH.SE1, true, 1f, 0);
				break;
			case 60:
				num = 13;
				evt.eventPlaySound(DirectionManager.SOUND.S0374, Sound.CH.SE1, true, 1f, 0);
				break;
			case 61:
				num = 13;
				evt.eventPlaySound(DirectionManager.SOUND.S0375, Sound.CH.SE1, true, 1f, 0);
				break;
			case 62:
				num = 13;
				num2 = 1;
				evt.eventPlaySound(DirectionManager.SOUND.S0376, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0097, Sound.CH.SE1, true, 1f, 6);
				break;
			case 63:
				num = 14;
				evt.eventPlaySound(DirectionManager.SOUND.S0373, Sound.CH.SE1, true, 1f, 0);
				break;
			case 64:
				num = 14;
				evt.eventPlaySound(DirectionManager.SOUND.S0374, Sound.CH.SE1, true, 1f, 0);
				break;
			case 65:
				num = 14;
				evt.eventPlaySound(DirectionManager.SOUND.S0375, Sound.CH.SE1, true, 1f, 0);
				break;
			case 66:
				num = 14;
				num2 = 1;
				evt.eventPlaySound(DirectionManager.SOUND.S0376, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0097, Sound.CH.SE1, true, 1f, 6);
				break;
			case 67:
				num = 15;
				evt.eventPlaySound(DirectionManager.SOUND.S0373, Sound.CH.SE1, true, 1f, 0);
				break;
			case 68:
				num = 15;
				evt.eventPlaySound(DirectionManager.SOUND.S0374, Sound.CH.SE1, true, 1f, 0);
				break;
			case 69:
				num = 15;
				evt.eventPlaySound(DirectionManager.SOUND.S0375, Sound.CH.SE1, true, 1f, 0);
				break;
			case 70:
				num = 15;
				num2 = 1;
				evt.eventPlaySound(DirectionManager.SOUND.S0376, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0097, Sound.CH.SE1, true, 1f, 6);
				break;
			case 71:
				num = 16;
				evt.eventPlaySound(DirectionManager.SOUND.S0375, Sound.CH.SE1, true, 1f, 0);
				break;
			case 72:
				num = 16;
				num2 = 1;
				evt.eventPlaySound(DirectionManager.SOUND.S0376, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0097, Sound.CH.SE1, true, 1f, 6);
				break;
			case 73:
				num = 17;
				num2 = 1;
				evt.eventPlaySound(DirectionManager.SOUND.S0376, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0097, Sound.CH.SE1, true, 1f, 6);
				break;
			case 75:
				num = 0;
				evt.eventPlaySound(DirectionManager.SOUND.S0373, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 152, 104, -15, 9);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				break;
			case 76:
				evt.eventDisableBefore(mng, 0);
				break;
			case 77:
				num = 1;
				evt.eventPlaySound(DirectionManager.SOUND.S0380, Sound.CH.SE1, true, 1f, 0);
				break;
			case 78:
				num = 2;
				flag = true;
				evt.eventPlaySound(DirectionManager.SOUND.S0381, Sound.CH.SE0, true, 1f, 0);
				break;
			case 79:
				num = 2;
				flag = true;
				evt.eventPlaySound(DirectionManager.SOUND.S0382, Sound.CH.SE0, true, 1f, 0);
				break;
			case 80:
				num = 2;
				evt.eventPlaySound(DirectionManager.SOUND.S0380, Sound.CH.SE1, true, 1f, 0);
				break;
			case 81:
				num = 1;
				flag = true;
				evt.eventPlaySound(DirectionManager.SOUND.S0381, Sound.CH.SE0, true, 1f, 0);
				break;
			case 82:
				num = 1;
				flag = true;
				evt.eventPlaySound(DirectionManager.SOUND.S0382, Sound.CH.SE0, true, 1f, 0);
				break;
			case 83:
				num = 10;
				evt.eventPlaySound(DirectionManager.SOUND.S0373, Sound.CH.SE1, true, 1f, 0);
				break;
			case 84:
				num = 10;
				evt.eventPlaySound(DirectionManager.SOUND.S0374, Sound.CH.SE1, true, 1f, 0);
				break;
			}
		}
		if (num >= 0)
		{
			if (!flag)
			{
				evt.eventPlayAnime(DirectionManager.ANIME.KWS001W, num2 * 100 + num, false, false, false, true, 128, 72, 100, 0);
			}
			else
			{
				evt.eventPlayAnime(DirectionManager.ANIME.KWS005W, num2 * 100 + num, false, false, false, true, 128, 72, 99, 0);
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
			case 38:
				break;
			case 39:
				break;
			case 40:
				break;
			case 41:
				break;
			case 42:
				break;
			case 43:
				break;
			case 44:
				break;
			case 45:
				break;
			case 46:
				break;
			case 47:
				break;
			case 48:
				break;
			case 49:
				break;
			case 50:
				break;
			case 51:
				break;
			case 52:
				break;
			case 53:
				break;
			case 54:
				break;
			case 55:
				break;
			case 56:
				break;
			case 57:
				break;
			case 58:
				break;
			case 59:
				break;
			case 60:
				break;
			case 61:
				break;
			case 62:
				break;
			case 63:
				break;
			case 64:
				break;
			case 65:
				break;
			case 66:
				break;
			case 67:
				break;
			case 68:
				break;
			case 69:
				break;
			case 70:
				break;
			case 71:
				break;
			case 72:
				break;
			case 73:
				break;
			case 75:
				break;
			case 76:
				break;
			case 77:
				break;
			case 78:
				break;
			case 79:
				break;
			case 80:
				break;
			case 81:
				break;
			case 82:
				break;
			case 83:
				break;
			case 84:
				break;
			case 74:
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

	private bool isResponse()
	{
		bool result = false;
		switch (mode)
		{
		case 78:
		case 79:
		case 81:
		case 82:
			result = true;
			break;
		}
		return result;
	}
}
