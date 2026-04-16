public class Direction62RSH : DirectionBase
{
	public Direction62RSH(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventPlayMovie(DirectionManager.MOVIE.rsh001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.rsh001_loop, DirectionManager.MOVIE.rsh001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1229, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0130, Sound.CH.BGM, true, 1f, 0);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.rsh002, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.rsh002_loop, DirectionManager.MOVIE.rsh002, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0640, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1230, Sound.CH.VC0, true, 1f, 0);
				break;
			case 3:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.rsh003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.rsh003_loop, DirectionManager.MOVIE.rsh003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0641, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1231, Sound.CH.VC0, true, 1f, 5);
				break;
			case 4:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.rsh008, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0646, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1234, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S1235, Sound.CH.VC0, true, 1f, 62);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 102, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0137, Sound.CH.BGM, true, 1f, 114);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.rsh012, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0191, Sound.CH.BGM, true, 1f, 168);
				evt.eventPlaySound(DirectionManager.SOUND.S0649, Sound.CH.SE1, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0368, Sound.CH.SE1, false, 1f, 141);
				evt.eventPlaySound(DirectionManager.SOUND.S0832, Sound.CH.VC0, true, 1f, 149);
				evt.eventStopSound(Sound.CH.BGM, 0);
				break;
			case 6:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.rsh009, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.rsh009_loop, DirectionManager.MOVIE.rsh009, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0647, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1236, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S1237, Sound.CH.VC0, true, 1f, 54);
				evt.eventPlaySound(DirectionManager.SOUND.S1223, Sound.CH.VC0, true, 1f, 97);
				evt.eventPlaySound(DirectionManager.SOUND.S0218, Sound.CH.SE0, true, 1f, 98);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 0, 98);
				break;
			case 7:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.rsh010, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.rsh010_loop, DirectionManager.MOVIE.rsh010, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0648, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1239, Sound.CH.VC0, true, 1f, 97);
				evt.eventPlaySound(DirectionManager.SOUND.S0221, Sound.CH.SE0, true, 1f, 117);
				evt.eventPlaySound(DirectionManager.SOUND.S0136, Sound.CH.BGM, true, 1f, 117);
				break;
			case 8:
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 23);
				evt.eventSetCanPush(true, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, false, 0, 0, 80, 23);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 23);
				break;
			case 9:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.rsh004, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.rsh004_loop, DirectionManager.MOVIE.rsh004, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0642, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1232, Sound.CH.VC0, true, 1f, 21);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 55);
				break;
			case 10:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.rsh005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.rsh005_loop, DirectionManager.MOVIE.rsh005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0643, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1233, Sound.CH.VC0, true, 1f, 0);
				break;
			case 11:
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 23);
				evt.eventSetCanPush(true, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, false, 0, 0, 80, 23);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 23);
				break;
			case 12:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.rsh006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.rsh006_loop, DirectionManager.MOVIE.rsh006, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0644, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1199, Sound.CH.VC0, true, 1f, 7);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 60);
				break;
			case 13:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.rsh007, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.rsh007_loop, DirectionManager.MOVIE.rsh007, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0645, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1310, Sound.CH.VC0, true, 1f, 0);
				break;
			case 14:
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 23);
				evt.eventSetCanPush(true, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, false, 0, 0, 80, 23);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 23);
				break;
			case 15:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.rsh001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.rsh001_loop, DirectionManager.MOVIE.rsh001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1229, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0130, Sound.CH.BGM, true, 1f, 0);
				break;
			case 16:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.rsh013_1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.rsh013_1_loop, DirectionManager.MOVIE.rsh013_1, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0222, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0817, Sound.CH.VC0, true, 1f, 14);
				break;
			case 17:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.rsh013_2, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.rsh013_2_loop, DirectionManager.MOVIE.rsh013_2, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0136, Sound.CH.BGM, true, 1f, 120);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0880, Sound.CH.VC0, true, 1f, 95);
				evt.eventPlaySound(DirectionManager.SOUND.S0370, Sound.CH.SE0, true, 1f, 96);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE1, true, 1f, 120);
				break;
			case 18:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.rsh008, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0646, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1234, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S1235, Sound.CH.VC0, true, 1f, 62);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 102, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S0137, Sound.CH.BGM, true, 1f, 114);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 19:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.rsh010, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.rsh010_loop, DirectionManager.MOVIE.rsh010, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0648, Sound.CH.SE1, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S1239, Sound.CH.VC0, true, 1f, 169);
				evt.eventPlaySound(DirectionManager.SOUND.S0221, Sound.CH.SE1, false, 1f, 189);
				evt.eventPlaySound(DirectionManager.SOUND.S0136, Sound.CH.BGM, true, 1f, 189);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 20:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.ish001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.rsh001, DirectionManager.MOVIE.ish001, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.rsh001_loop, DirectionManager.MOVIE.rsh001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1229, Sound.CH.VC0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0130, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0245, Sound.CH.SE0, true, 1f, 0);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
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
				DirectionLedManager.GD_hatten_HIT(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.LG_hatten_HIT(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.m_panel_slash_RSH_01(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_4M));
				break;
			case 8:
				break;
			case 9:
				DirectionLedManager.GD_RSH_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 10:
				break;
			case 11:
				break;
			case 12:
				DirectionLedManager.GD_RSH_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 13:
				break;
			case 14:
				break;
			case 15:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				break;
			case 16:
				break;
			case 17:
				DirectionLedManager.GD_hatten_HIT(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.LG_hatten_HIT(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.m_panel_slash_RSH_03(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_4M));
				break;
			case 18:
				break;
			case 19:
				DirectionLedManager.GD_hatten_JYD_HIT(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.LG_hatten_JYD_HIT(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.m_panel_slash_RSH_02(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_4M));
				break;
			case 20:
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
