public class Direction48KOG : DirectionBase
{
	public Direction48KOG(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
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
				evt.eventPlaySound(DirectionManager.SOUND.S0134, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kog001, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kog001_loop, DirectionManager.MOVIE.kog001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S1212, Sound.CH.VC0, true, 1f, 44);
				evt.eventPlaySound(DirectionManager.SOUND.S0418, Sound.CH.SE0, true, 1f, 107);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kog002_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kog002_a_loop, DirectionManager.MOVIE.kog002_a, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0419, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0868, Sound.CH.VC0, true, 1f, 15);
				break;
			case 3:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kog003, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kog003_loop, DirectionManager.MOVIE.kog003, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0422, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1213, Sound.CH.VC0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0423, Sound.CH.SE1, true, 1f, 42);
				evt.eventPlaySound(DirectionManager.SOUND.S1214, Sound.CH.VC1, true, 1f, 45);
				evt.eventPlaySound(DirectionManager.SOUND.S0218, Sound.CH.SE0, true, 1f, 45);
				break;
			case 4:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kog002_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kog002_b_loop, DirectionManager.MOVIE.kog002_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0419, Sound.CH.SE0, true, 1f, 4);
				evt.eventPlaySound(DirectionManager.SOUND.S0421, Sound.CH.SE1, true, 1f, 16);
				evt.eventPlaySound(DirectionManager.SOUND.S0869, Sound.CH.VC0, true, 1f, 30);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0134, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kog004, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kog004_loop, DirectionManager.MOVIE.kog004, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0424, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0223, Sound.CH.SE1, true, 1f, 13);
				evt.eventPlaySound(DirectionManager.SOUND.S0870, Sound.CH.VC0, true, 1f, 20);
				evt.eventPlaySound(DirectionManager.SOUND.S1215, Sound.CH.VC1, true, 1f, 40);
				evt.eventPlayMovie(DirectionManager.MOVIE.push, false, false, false, true, 128, 119, 99, 13);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_add, true, false, true, false, 0, 0, 98, 13);
				break;
			case 6:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kog017, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kog017_loop, DirectionManager.MOVIE.kog017, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0425, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0426, Sound.CH.SE1, true, 1f, 22);
				evt.eventPlaySound(DirectionManager.SOUND.S0427, Sound.CH.SE0, true, 1f, 57);
				break;
			case 7:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kog006, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kog006_loop, DirectionManager.MOVIE.kog006, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0428, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0871, Sound.CH.VC0, true, 1f, 12);
				evt.eventPlaySound(DirectionManager.SOUND.S1219, Sound.CH.VC1, true, 1f, 12);
				break;
			case 8:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kog007, false, false, false, false, 0, 0, 100, 0);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0137, Sound.CH.BGM, true, 1f, 115);
				evt.eventPlaySound(DirectionManager.SOUND.S0434, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1220, Sound.CH.VC0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE1, true, 1f, 25);
				evt.eventPlaySound(DirectionManager.SOUND.S1312, Sound.CH.VC1, true, 1f, 81);
				evt.eventPlaySound(DirectionManager.SOUND.S0242, Sound.CH.SE0, true, 1f, 98);
				break;
			case 9:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kog009, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kog009_loop, DirectionManager.MOVIE.kog009, false, true, false, false);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0435, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1223, Sound.CH.VC0, true, 1f, 15);
				evt.eventPlaySound(DirectionManager.SOUND.S1224, Sound.CH.VC1, true, 1f, 63);
				break;
			case 10:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kog008, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kog008_loop, DirectionManager.MOVIE.kog008, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0136, Sound.CH.BGM, true, 1f, 129);
				evt.eventPlaySound(DirectionManager.SOUND.S0429, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0430, Sound.CH.SE1, true, 1f, 18);
				evt.eventPlaySound(DirectionManager.SOUND.S0873, Sound.CH.VC0, true, 1f, 46);
				evt.eventPlaySound(DirectionManager.SOUND.S1222, Sound.CH.VC1, true, 1f, 94);
				evt.eventPlaySound(DirectionManager.SOUND.S0221, Sound.CH.SE0, true, 1f, 129);
				break;
			case 11:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kog005_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kog005_a_loop, DirectionManager.MOVIE.kog005_a, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0431, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1216, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 99, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 98, 0);
				break;
			case 12:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kog005_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kog005_b_loop, DirectionManager.MOVIE.kog005_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0432, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1217, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 99, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 98, 0);
				break;
			case 13:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kog005_c, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kog005_c_loop, DirectionManager.MOVIE.kog005_c, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0433, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1218, Sound.CH.VC0, true, 1f, 10);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 99, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 98, 0);
				break;
			case 14:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0074, Sound.CH.SE1, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kog008, false, false, false, false, 0, 0, 100, 72);
				evt.eventAddMovie(DirectionManager.MOVIE.kog008_loop, DirectionManager.MOVIE.kog008, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0136, Sound.CH.BGM, true, 1f, 201);
				evt.eventPlaySound(DirectionManager.SOUND.S0429, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0430, Sound.CH.SE1, true, 1f, 90);
				evt.eventPlaySound(DirectionManager.SOUND.S0873, Sound.CH.VC0, true, 1f, 118);
				evt.eventPlaySound(DirectionManager.SOUND.S1222, Sound.CH.VC1, true, 1f, 166);
				evt.eventPlaySound(DirectionManager.SOUND.S0221, Sound.CH.SE0, true, 1f, 201);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit, true, false, false, true, 128, 119, 99, 0);
				evt.eventSetCanPush(false, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.push_hit_add, true, false, true, false, 0, 0, 98, 0);
				break;
			case 15:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kog010, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kog010_loop, DirectionManager.MOVIE.kog010, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 5);
				evt.eventPlaySound(DirectionManager.SOUND.S0272, Sound.CH.SE1, true, 1f, 60);
				evt.eventPlaySound(DirectionManager.SOUND.S1218, Sound.CH.VC0, true, 1f, 60);
				break;
			case 16:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kog011, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kog012, DirectionManager.MOVIE.kog011, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0273, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1200, Sound.CH.VC0, true, 1f, 0);
				break;
			case 17:
				evt.eventDisableBefore(mng, 0);
				evt.eventStopSound(Sound.CH.BGM, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0134, Sound.CH.BGM, false, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kog001_st, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kog001_loop, DirectionManager.MOVIE.kog001_st, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0506, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1212, Sound.CH.VC1, true, 1f, 74);
				evt.eventPlaySound(DirectionManager.SOUND.S0418, Sound.CH.SE1, true, 1f, 137);
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
				DirectionLedManager.GD_KOG_sol_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
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
				DirectionLedManager.JG_KOG_sin_revival(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.YK_KOG_sin_revival(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 10:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_hatten_HIT(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.LG_hatten_HIT(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_slash_KOG_01(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_4M));
				break;
			case 11:
				break;
			case 12:
				DirectionLedManager.GD_KOG_green(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 13:
				DirectionLedManager.GD_KOG_red(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 14:
				DirectionLedManager.GD_hatten_JYD_HIT(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.LG_hatten_JYD_HIT(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.m_panel_slash_KOG_02(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_4M));
				break;
			case 15:
				break;
			case 16:
				break;
			case 17:
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
