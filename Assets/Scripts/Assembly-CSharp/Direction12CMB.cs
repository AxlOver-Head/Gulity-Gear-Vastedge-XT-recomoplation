public class Direction12CMB : DirectionBase
{
	public Direction12CMB(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0132, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmb001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmb001_loop, DirectionManager.MOVIE.cmb001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0588, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0589, Sound.CH.SE0, true, 1f, 21);
				evt.eventPlaySound(DirectionManager.SOUND.S2032, Sound.CH.VC0, true, 1f, 21);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmb002, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmb002_loop, DirectionManager.MOVIE.cmb002, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0590, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1188, Sound.CH.VC0, true, 1f, 30);
				break;
			case 3:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmb003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmb003_loop, DirectionManager.MOVIE.cmb003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0593, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2033, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1307, Sound.CH.VC1, true, 1f, 0);
				break;
			case 4:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmb008, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0594, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2030, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0595, Sound.CH.SE0, true, 1f, 16);
				evt.eventPlaySound(DirectionManager.SOUND.S1191, Sound.CH.VC0, true, 1f, 16);
				evt.eventPlaySound(DirectionManager.SOUND.S1308, Sound.CH.VC0, true, 1f, 33);
				evt.eventPlaySound(DirectionManager.SOUND.S0137, Sound.CH.BGM, false, 1f, 68);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0074, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmb011, false, false, false, false, 0, 0, 100, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.cmb011_loop, DirectionManager.MOVIE.cmb011, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0598, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0831, Sound.CH.VC0, true, 1f, 80);
				evt.eventPlaySound(DirectionManager.SOUND.S0368, Sound.CH.SE0, true, 1f, 103);
				evt.eventPlaySound(DirectionManager.SOUND.S0191, Sound.CH.BGM, false, 1f, 145);
				break;
			case 6:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmb009, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0596, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1236, Sound.CH.VC0, true, 1f, 8);
				evt.eventPlaySound(DirectionManager.SOUND.S1237, Sound.CH.VC0, true, 1f, 26);
				evt.eventPlaySound(DirectionManager.SOUND.S0218, Sound.CH.SE0, true, 1f, 35);
				evt.eventPlaySound(DirectionManager.SOUND.S2034, Sound.CH.VC0, true, 1f, 55);
				break;
			case 7:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmb010, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmb010_loop, DirectionManager.MOVIE.cmb010, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0597, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2031, Sound.CH.VC0, true, 1f, 28);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 51);
				evt.eventPlaySound(DirectionManager.SOUND.S1193, Sound.CH.VC0, true, 1f, 93);
				evt.eventPlaySound(DirectionManager.SOUND.S0221, Sound.CH.SE0, true, 1f, 151);
				evt.eventPlaySound(DirectionManager.SOUND.S0136, Sound.CH.BGM, false, 1f, 151);
				break;
			case 8:
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 4);
				evt.eventSetCanPush(true, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, false, 0, 0, 80, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 4);
				break;
			case 9:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmb004, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmb004_loop, DirectionManager.MOVIE.cmb004, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0591, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1189, Sound.CH.VC0, true, 1f, 30);
				break;
			case 10:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmb005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmb005_loop, DirectionManager.MOVIE.cmb005, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0593, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2033, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1307, Sound.CH.VC1, true, 1f, 0);
				break;
			case 11:
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 4);
				evt.eventSetCanPush(true, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, false, 0, 0, 80, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 4);
				break;
			case 12:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmb006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmb006_loop, DirectionManager.MOVIE.cmb006, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0592, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1190, Sound.CH.VC0, true, 1f, 30);
				break;
			case 13:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmb007, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmb007_loop, DirectionManager.MOVIE.cmb007, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0593, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2033, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1307, Sound.CH.VC1, true, 1f, 0);
				break;
			case 14:
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 90, 4);
				evt.eventSetCanPush(true, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.push_loop, DirectionManager.MOVIE.push, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, false, 0, 0, 80, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE0, true, 1f, 4);
				break;
			case 15:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0132, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmb001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmb001_loop, DirectionManager.MOVIE.cmb001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0588, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0589, Sound.CH.SE0, true, 1f, 21);
				evt.eventPlaySound(DirectionManager.SOUND.S2032, Sound.CH.VC0, true, 1f, 21);
				break;
			case 16:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmb012, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmb012_loop, DirectionManager.MOVIE.cmb012, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S2034, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0222, Sound.CH.SE0, true, 1f, 56);
				evt.eventPlaySound(DirectionManager.SOUND.S0864, Sound.CH.VC0, true, 1f, 70);
				break;
			case 17:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmb013, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmb013_loop, DirectionManager.MOVIE.cmb013, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0369, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0818, Sound.CH.VC0, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S0370, Sound.CH.SE0, true, 1f, 31);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE0, true, 1f, 51);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, false, 1f, 51);
				break;
			case 18:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmb008, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0594, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S2030, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0595, Sound.CH.SE0, true, 1f, 16);
				evt.eventPlaySound(DirectionManager.SOUND.S1191, Sound.CH.VC0, true, 1f, 16);
				evt.eventPlaySound(DirectionManager.SOUND.S1308, Sound.CH.VC0, true, 1f, 33);
				evt.eventPlaySound(DirectionManager.SOUND.S0137, Sound.CH.BGM, false, 1f, 68);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 80, 0);
				break;
			case 19:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0074, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmb010, false, false, false, false, 0, 0, 100, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.cmb010_loop, DirectionManager.MOVIE.cmb010, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0597, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S2031, Sound.CH.VC0, true, 1f, 100);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 123);
				evt.eventPlaySound(DirectionManager.SOUND.S1193, Sound.CH.VC0, true, 1f, 165);
				evt.eventPlaySound(DirectionManager.SOUND.S0221, Sound.CH.SE0, true, 1f, 223);
				evt.eventPlaySound(DirectionManager.SOUND.S0136, Sound.CH.BGM, false, 1f, 223);
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_351();
				DirectionYakuManager._MAIN_GIMMICK_PTTERNS_353();
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, false, false, false, true, 128, 119, 90, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, false, false, true, false, 0, 0, 80, 0);
				break;
			case 20:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0132, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.cmb001_st, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.cmb001_loop, DirectionManager.MOVIE.cmb001_st, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0245, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0588, Sound.CH.SE0, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0589, Sound.CH.SE0, true, 1f, 51);
				evt.eventPlaySound(DirectionManager.SOUND.S2032, Sound.CH.VC0, true, 1f, 51);
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
				DirectionLedManager.m_panel_slash_CMB_01(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_4M));
				break;
			case 8:
				break;
			case 9:
				DirectionLedManager.GD_CMB_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 10:
				break;
			case 11:
				break;
			case 12:
				DirectionLedManager.GD_CMB_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
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
				DirectionLedManager.m_panel_slash_CMB_03(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_4M));
				break;
			case 18:
				break;
			case 19:
				DirectionLedManager.GD_hatten_JYD_HIT(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.LG_hatten_JYD_HIT(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.m_panel_slash_CMB_02(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_4M));
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
