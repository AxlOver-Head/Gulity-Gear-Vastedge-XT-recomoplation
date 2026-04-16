public class Direction17KCI : DirectionBase
{
	private int m_count;

	public Direction17KCI(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		base.start();
		m_count = 0;
		switch (low)
		{
		case 0:
			switch (mode)
			{
			case 1:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kci001, true, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0404, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0834, Sound.CH.VC0, true, 1f, 15);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kci002, true, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0405, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1194, Sound.CH.VC0, true, 1f, 15);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kci003, true, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0406, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0835, Sound.CH.VC0, true, 1f, 15);
				evt.eventPlaySound(DirectionManager.SOUND.S1195, Sound.CH.SE0, true, 1f, 15);
				break;
			case 7:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kci004_b, true, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1405, Sound.CH.SE0, true, 1f, 0);
				break;
			case 8:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kci004_a, true, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0407, Sound.CH.SE0, true, 1f, 0);
				break;
			case 9:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kci004_c, true, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1406, Sound.CH.SE0, true, 1f, 0);
				break;
			case 10:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kci004_e, true, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1407, Sound.CH.SE0, true, 1f, 0);
				break;
			case 11:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kci004_d, true, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1408, Sound.CH.SE0, true, 1f, 0);
				break;
			case 12:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kci004_f, true, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1407, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0215, Sound.CH.VC0, true, 1f, 4);
				break;
			case 13:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kci005_a, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0395, Sound.CH.SE0, true, 1f, 0);
				break;
			case 14:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kci005_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kci005_b_loop, DirectionManager.MOVIE.kci005_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0408, Sound.CH.SE0, true, 1f, 0);
				break;
			case 15:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kci005_c, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kci005_c_loop, DirectionManager.MOVIE.kci005_c, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0563, Sound.CH.SE0, true, 1f, 0);
				break;
			case 16:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kci005_d, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kci005_d_loop, DirectionManager.MOVIE.kci005_d, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0409, Sound.CH.SE0, true, 1f, 0);
				break;
			case 18:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kci005_e, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kci005_e_loop, DirectionManager.MOVIE.kci005_e, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0410, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1047, Sound.CH.VC0, true, 1f, 9);
				break;
			case 19:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kci005_f, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kci005_f_loop, DirectionManager.MOVIE.kci005_f, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0411, Sound.CH.SE0, true, 1f, 0);
				break;
			}
			break;
		case 1:
			switch (mode)
			{
			case 1:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kci001, true, false, false, false, 0, 0, 100, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0404, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0834, Sound.CH.VC0, true, 1f, 15);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kci001, true, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kci002, DirectionManager.MOVIE.kci001, true, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0404, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0834, Sound.CH.VC0, true, 1f, 15);
				evt.eventPlaySound(DirectionManager.SOUND.S0405, Sound.CH.SE0, true, 1f, 63);
				evt.eventPlaySound(DirectionManager.SOUND.S1194, Sound.CH.VC0, true, 1f, 78);
				break;
			case 3:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kci001, true, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kci002, DirectionManager.MOVIE.kci001, true, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kci003, DirectionManager.MOVIE.kci002, true, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0404, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0834, Sound.CH.VC0, true, 1f, 15);
				evt.eventPlaySound(DirectionManager.SOUND.S0405, Sound.CH.SE1, true, 1f, 63);
				evt.eventPlaySound(DirectionManager.SOUND.S1194, Sound.CH.VC0, true, 1f, 78);
				evt.eventPlaySound(DirectionManager.SOUND.S0406, Sound.CH.SE0, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0835, Sound.CH.VC0, true, 1f, 141);
				evt.eventPlaySound(DirectionManager.SOUND.S1195, Sound.CH.SE1, true, 1f, 141);
				break;
			case 4:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kci001, true, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kci002, DirectionManager.MOVIE.kci001, true, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kci003, DirectionManager.MOVIE.kci002, true, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kfr001, DirectionManager.MOVIE.kci003, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kfr001_loop, DirectionManager.MOVIE.kfr001, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0404, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0834, Sound.CH.VC0, true, 1f, 15);
				evt.eventPlaySound(DirectionManager.SOUND.S0405, Sound.CH.SE0, true, 1f, 63);
				evt.eventPlaySound(DirectionManager.SOUND.S1194, Sound.CH.VC0, true, 1f, 78);
				evt.eventPlaySound(DirectionManager.SOUND.S0406, Sound.CH.SE0, true, 1f, 126);
				evt.eventPlaySound(DirectionManager.SOUND.S0835, Sound.CH.VC0, true, 1f, 141);
				evt.eventPlaySound(DirectionManager.SOUND.S1195, Sound.CH.SE0, true, 1f, 141);
				evt.eventPlaySound(DirectionManager.SOUND.S0120, Sound.CH.BGM, false, 1f, 575);
				evt.eventPlaySound(DirectionManager.SOUND.S0336, Sound.CH.SE0, true, 1f, 215);
				evt.eventPlaySound(DirectionManager.SOUND.S1348, Sound.CH.VC0, true, 1f, 287);
				evt.eventPlaySound(DirectionManager.SOUND.S0456, Sound.CH.SE0, true, 1f, 293);
				evt.eventPlaySound(DirectionManager.SOUND.S1349, Sound.CH.VC0, true, 1f, 315);
				evt.eventPlaySound(DirectionManager.SOUND.S1350, Sound.CH.VC0, true, 1f, 338);
				evt.eventPlaySound(DirectionManager.SOUND.S1351, Sound.CH.VC0, true, 1f, 601);
				break;
			case 5:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kci005_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kci005_b_loop, DirectionManager.MOVIE.kci005_b, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0408, Sound.CH.SE0, true, 1f, 0);
				break;
			case 6:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kci005_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kci005_c, DirectionManager.MOVIE.kci005_b, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kci005_c_loop, DirectionManager.MOVIE.kci005_c, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0408, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0563, Sound.CH.SE0, true, 1f, 54);
				break;
			case 7:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.kci005_b, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.kci005_c, DirectionManager.MOVIE.kci005_b, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kci005_d, DirectionManager.MOVIE.kci005_c, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.kci005_d_loop, DirectionManager.MOVIE.kci005_d, false, true, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0408, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0563, Sound.CH.SE0, true, 1f, 54);
				evt.eventPlaySound(DirectionManager.SOUND.S0409, Sound.CH.SE0, true, 1f, 97);
				evt.eventPlaySound(DirectionManager.SOUND.S0410, Sound.CH.SE0, true, 1f, 141);
				break;
			}
			break;
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.JG_KCI_SU_sol(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GH_KCI_SU_sol(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.KCI_SU_sol(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 2:
				DirectionLedManager.JG_KCI_SU_sin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GH_KCI_SU_sin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.KCI_SU_sin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 5:
				DirectionLedManager.JG_KCI_SU_solsin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GH_KCI_SU_solsin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.KCI_SU_solsin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 7:
				DirectionLedManager.GH_KCI_sin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.KCI_sin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 8:
				DirectionLedManager.GH_KCI_sol(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.KCI_sol(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 9:
				DirectionLedManager.GH_KCI_kai(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.KCI_kai(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 10:
				DirectionLedManager.GH_KCI_man(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.KCI_man(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 11:
				DirectionLedManager.GH_KCI_diz(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.KCI_diz(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 12:
				DirectionLedManager.SE_common_kokuchi_11(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GH_KCI_dai(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
				DirectionLedManager.KCI_dai(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 13:
				DirectionLedManager.KCI_DI(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 14:
				DirectionLedManager.KCI_DI(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 15:
				DirectionLedManager.KCI_DI(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 16:
				DirectionLedManager.KCI_DI(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 18:
				DirectionLedManager.KCI_DI(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 19:
				DirectionLedManager.KCI_DI_lose(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			}
		}
		byte b = low;
		if (b == 1)
		{
			m_count = 0;
			switch (mode)
			{
			case 1:
				evt.reel.FreezeReelAct2();
				break;
			case 2:
				evt.reel.FreezeReelAct3();
				break;
			case 3:
				evt.reel.FreezeReelAct4();
				break;
			case 4:
				evt.reel.FreezeReelAct5();
				break;
			case 5:
				evt.reel.FreezeReelAct6();
				break;
			case 6:
				evt.reel.FreezeReelAct7();
				break;
			case 7:
				evt.reel.FreezeReelAct8();
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
		if (evt.m_Active)
		{
			byte b = low;
			if (b == 1)
			{
				switch (mode)
				{
				case 1:
					if (m_count == 0)
					{
						DirectionLedManager.JG_KCI_SU_sol(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
						DirectionLedManager.GH_KCI_SU_sol(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
						DirectionLedManager.KCI_SU_sol(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
						DirectionPanelLED.runMac2App(8, 1);
					}
					break;
				case 2:
					if (m_count == 0)
					{
						DirectionLedManager.JG_KCI_SU_sol(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
						DirectionLedManager.GH_KCI_SU_sol(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
						DirectionLedManager.KCI_SU_sol(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
						DirectionPanelLED.runMac2App(8, 1);
					}
					else if (m_count == 63)
					{
						DirectionLedManager.JG_KCI_SU_sin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
						DirectionLedManager.GH_KCI_SU_sin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
						DirectionLedManager.KCI_SU_sin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
						DirectionPanelLED.runMac2App(9, 1);
					}
					break;
				case 3:
					if (m_count == 0)
					{
						DirectionLedManager.JG_KCI_SU_sol(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
						DirectionLedManager.GH_KCI_SU_sol(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
						DirectionLedManager.KCI_SU_sol(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
						DirectionPanelLED.runMac2App(8, 1);
					}
					else if (m_count == 63)
					{
						DirectionLedManager.JG_KCI_SU_sin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
						DirectionLedManager.GH_KCI_SU_sin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
						DirectionLedManager.KCI_SU_sin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
						DirectionPanelLED.runMac2App(9, 1);
					}
					else if (m_count == 126)
					{
						DirectionLedManager.JG_KCI_SU_solsin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
						DirectionLedManager.GH_KCI_SU_solsin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
						DirectionLedManager.KCI_SU_solsin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
						DirectionPanelLED.runMac2App(10, 1);
					}
					break;
				case 4:
					if (m_count == 0)
					{
						DirectionLedManager.JG_KCI_SU_sol(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
						DirectionLedManager.GH_KCI_SU_sol(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
						DirectionLedManager.KCI_SU_sol(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
						DirectionPanelLED.runMac2App(8, 1);
					}
					else if (m_count == 63)
					{
						DirectionLedManager.JG_KCI_SU_sin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
						DirectionLedManager.GH_KCI_SU_sin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
						DirectionLedManager.KCI_SU_sin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
						DirectionPanelLED.runMac2App(9, 1);
					}
					else if (m_count == 126)
					{
						DirectionLedManager.JG_KCI_SU_solsin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
						DirectionLedManager.GH_KCI_SU_solsin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
						DirectionLedManager.KCI_SU_solsin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
						DirectionPanelLED.runMac2App(10, 1);
					}
					else if (m_count == 215)
					{
						DirectionLedManager.GH_freeze_PB(DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE));
						DirectionLedManager.BG_IKG_diz_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
						DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
						DirectionLedManager.OFF_3(DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL));
						DirectionLedManager.OFF_4(DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG));
						DirectionLedManager.OFF_5(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
						DirectionLedManager.OFF_6(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
						DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
						DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
						DirectionLedManager.OFF_9(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_1));
						DirectionLedManager.OFF_10(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_2));
						DirectionLedManager.OFF_11(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_3));
						DirectionLedManager.OFF_12(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_4));
						DirectionLedManager.OFF_13(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_5));
						DirectionLedManager.OFF_14(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_6));
						DirectionLedManager.OFF_15(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_DI));
						DirectionLedManager.OFF_16(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DEMO));
						DirectionLedManager.OFF_2m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M));
						DirectionLedManager.OFF_4m(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_4M));
					}
					break;
				case 5:
					if (m_count == 0)
					{
						DirectionLedManager.KCI_DI(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
						DirectionPanelLED.runMac2App(1, 1);
					}
					break;
				case 6:
					if (m_count == 0)
					{
						DirectionLedManager.KCI_DI(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
						DirectionPanelLED.runMac2App(1, 1);
					}
					else if (m_count == 54)
					{
						DirectionLedManager.KCI_DI(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
						DirectionPanelLED.runMac2App(2, 1);
					}
					break;
				case 7:
					if (m_count == 0)
					{
						DirectionLedManager.KCI_DI(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
						DirectionPanelLED.runMac2App(1, 1);
					}
					else if (m_count == 54)
					{
						DirectionLedManager.KCI_DI(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
						DirectionPanelLED.runMac2App(2, 1);
					}
					else if (m_count == 97)
					{
						DirectionLedManager.KCI_DI(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
						DirectionPanelLED.runMac2App(3, 1);
					}
					else if (m_count == 141)
					{
						DirectionLedManager.KCI_DI(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
						DirectionPanelLED.runMac2App(4, 1);
					}
					break;
				}
			}
			m_count++;
		}
		base.control();
	}
}
