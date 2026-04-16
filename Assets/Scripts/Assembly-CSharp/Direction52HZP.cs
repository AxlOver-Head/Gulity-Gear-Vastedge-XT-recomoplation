public class Direction52HZP : DirectionBase
{
	private int m_cnt;

	public Direction52HZP(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir)
		: base(_mng, _high, _low, _mode, _dir, DirectionBase.PRIORITY_NORMAL)
	{
	}

	public override void start()
	{
		m_cnt = 0;
		restartBGM();
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_sol1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hzp1001_zap1, DirectionManager.MOVIE.hsl1001_sol1, true, false, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_sol2, false, false, false, true, 70, 72, 101, 111);
				evt.eventPlayMovie(DirectionManager.MOVIE.hzp1001_zap2, false, false, false, false, 0, 0, 102, 111);
				evt.eventPlaySound(DirectionManager.SOUND.S0141, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg2, false, false, false, false, 0, 0, 110, 110);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1001_bg2_loop, DirectionManager.MOVIE.hsl1001_bg2, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg_sdw, false, false, false, false, 0, 0, 90, 116);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg1, false, false, false, false, 0, 0, 80, 110);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1001_bg1_loop, DirectionManager.MOVIE.hsl1001_bg1, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg_add, false, false, true, false, 0, 0, 70, 124);
				break;
			case 2:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_sol1, false, false, false, false, 0, 0, 100, 30);
				evt.eventAddMovie(DirectionManager.MOVIE.hzp1001_zap1, DirectionManager.MOVIE.hsl1001_sol1, true, false, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_sol2, false, false, false, true, 70, 72, 101, 141);
				evt.eventPlayMovie(DirectionManager.MOVIE.hzp1001_zap2, false, false, false, false, 0, 0, 102, 141);
				evt.eventPlaySound(DirectionManager.SOUND.S0141, Sound.CH.BGM, false, 1f, 29);
				evt.eventPlaySound(DirectionManager.SOUND.S0252, Sound.CH.SE0, true, 1f, 1);
				evt.eventPlaySound(DirectionManager.SOUND.S0252, Sound.CH.SE1, true, 1f, 9);
				evt.eventPlaySound(DirectionManager.SOUND.S0235, Sound.CH.SE0, true, 1f, 26);
				evt.eventPlaySound(DirectionManager.SOUND.S0271, Sound.CH.SE1, true, 1f, 223);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg2, false, false, false, false, 0, 0, 110, 140);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1001_bg2_loop, DirectionManager.MOVIE.hsl1001_bg2, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg_sdw, false, false, false, false, 0, 0, 90, 146);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg1, false, false, false, false, 0, 0, 80, 140);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1001_bg1_loop, DirectionManager.MOVIE.hsl1001_bg1, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg_add, false, false, true, false, 0, 0, 70, 164);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_ss, true, false, false, false, 0, 0, 60, 1);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_s, false, false, false, false, 0, 0, 51, 223);
				break;
			case 3:
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2001_hai1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2001_hai1_kyo, DirectionManager.MOVIE.hsl2001_hai1, false, false, false, false);
				evt.eventPlaySound(DirectionManager.SOUND.S0260, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S1023, Sound.CH.VC0, true, 1f, 34);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2001_sol, false, false, false, false, 0, 0, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2001_sol2, DirectionManager.MOVIE.hsl2001_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2001_sol2_loop, DirectionManager.MOVIE.hsl2001_sol2, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hzp2001_zap, true, false, false, true, 206, 114, 80, 0);
				break;
			case 4:
				evt.eventPlayMovie(DirectionManager.MOVIE.hzp2022_zap, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hzp2022_zap_loop, DirectionManager.MOVIE.hzp2022_zap, false, true, false, false);
				evt.eventDisableBefore(mng, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0474, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0908, Sound.CH.VC0, true, 1f, 0);
				break;
			case 5:
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl2023_sol, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hzp2023_zap, DirectionManager.MOVIE.hsl2023_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5010_hai1, DirectionManager.MOVIE.hzp2023_zap, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 144);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 319);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0485, Sound.CH.SE1, true, 1f, 30);
				evt.eventPlaySound(DirectionManager.SOUND.S0887, Sound.CH.VC0, true, 1f, 32);
				evt.eventPlaySound(DirectionManager.SOUND.S1588, Sound.CH.VC1, true, 1f, 90);
				evt.eventPlaySound(DirectionManager.SOUND.S1589, Sound.CH.VC1, true, 1f, 150);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 160);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE0, true, 1f, 208);
				evt.eventPlaySound(DirectionManager.SOUND.S0954, Sound.CH.VC0, true, 1f, 252);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE1, true, 1f, 319);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_sol, false, false, false, true, 60, 84, 90, 142);
				evt.eventPlayMovie(DirectionManager.MOVIE.hzp5010_zap, false, false, false, false, 0, 0, 80, 142);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 70, 207);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 69, 207);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 6:
				evt.eventPlayMovie(DirectionManager.MOVIE.yjd005, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl2023_sol, DirectionManager.MOVIE.yjd005, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hzp2023_zap, DirectionManager.MOVIE.hsl2023_sol, false, false, false, false);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5010_hai1, DirectionManager.MOVIE.hzp2023_zap, false, false, false, false);
				evt.eventFadeSound(Sound.CH.BGM, 1f, 0f, 10, 216);
				evt.eventPlaySound(DirectionManager.SOUND.S0135, Sound.CH.BGM, true, 1f, 391);
				evt.eventPlaySound(DirectionManager.SOUND.S0243, Sound.CH.SE0, true, 1f, 72);
				evt.eventPlaySound(DirectionManager.SOUND.S0485, Sound.CH.SE1, true, 1f, 102);
				evt.eventPlaySound(DirectionManager.SOUND.S0887, Sound.CH.VC0, true, 1f, 104);
				evt.eventPlaySound(DirectionManager.SOUND.S1588, Sound.CH.VC1, true, 1f, 162);
				evt.eventPlaySound(DirectionManager.SOUND.S1589, Sound.CH.VC1, true, 1f, 222);
				evt.eventPlaySound(DirectionManager.SOUND.S0219, Sound.CH.SE0, true, 1f, 232);
				evt.eventPlaySound(DirectionManager.SOUND.S0497, Sound.CH.SE0, true, 1f, 280);
				evt.eventPlaySound(DirectionManager.SOUND.S0954, Sound.CH.VC0, true, 1f, 324);
				evt.eventPlaySound(DirectionManager.SOUND.S0220, Sound.CH.SE1, true, 1f, 391);
				evt.eventPlaySound(DirectionManager.SOUND.S0073, Sound.CH.SE0, true, 1f, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5010_sol, false, false, false, true, 60, 84, 90, 214);
				evt.eventPlayMovie(DirectionManager.MOVIE.hzp5010_zap, false, false, false, false, 0, 0, 80, 214);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_hai1, false, false, false, false, 0, 0, 70, 279);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl5003_sol, false, false, false, false, 0, 0, 69, 279);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl5003_sol_loop, DirectionManager.MOVIE.hsl5003_sol, false, true, false, false);
				break;
			case 7:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_sol1, false, false, false, false, 0, 0, 100, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hzp1001_zap1, DirectionManager.MOVIE.hsl1001_sol1, true, false, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_sol2, false, false, false, true, 70, 72, 101, 111);
				evt.eventPlayMovie(DirectionManager.MOVIE.hzp1001_zap2, false, false, false, false, 0, 0, 102, 111);
				evt.eventPlaySound(DirectionManager.SOUND.S0141, Sound.CH.BGM, true, 1f, 0);
				evt.eventPlaySound(DirectionManager.SOUND.S0271, Sound.CH.SE0, true, 1f, 204);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg2, false, false, false, false, 0, 0, 110, 110);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1001_bg2_loop, DirectionManager.MOVIE.hsl1001_bg2, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg_sdw, false, false, false, false, 0, 0, 90, 116);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg1, false, false, false, false, 0, 0, 80, 110);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1001_bg1_loop, DirectionManager.MOVIE.hsl1001_bg1, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg_add, false, false, true, false, 0, 0, 70, 124);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_s, false, false, false, false, 0, 0, 60, 204);
				break;
			case 8:
				evt.eventDisableBefore(mng, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_sol1, false, false, false, false, 0, 0, 100, 53);
				evt.eventAddMovie(DirectionManager.MOVIE.hzp1001_zap1, DirectionManager.MOVIE.hsl1001_sol1, true, false, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_sol2, false, false, false, true, 70, 72, 101, 162);
				evt.eventPlayMovie(DirectionManager.MOVIE.hzp1001_zap2, false, false, false, false, 0, 0, 102, 162);
				evt.eventPlaySound(DirectionManager.SOUND.S0141, Sound.CH.BGM, false, 1f, 54);
				evt.eventPlaySound(DirectionManager.SOUND.S0252, Sound.CH.SE0, true, 1f, 26);
				evt.eventPlaySound(DirectionManager.SOUND.S0252, Sound.CH.SE1, true, 1f, 35);
				evt.eventPlaySound(DirectionManager.SOUND.S0235, Sound.CH.SE0, true, 1f, 51);
				evt.eventPlaySound(DirectionManager.SOUND.S0271, Sound.CH.SE1, true, 1f, 248);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg2, false, false, false, false, 0, 0, 110, 161);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1001_bg2_loop, DirectionManager.MOVIE.hsl1001_bg2, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg_sdw, false, false, false, false, 0, 0, 90, 164);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg1, false, false, false, false, 0, 0, 80, 161);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1001_bg1_loop, DirectionManager.MOVIE.hsl1001_bg1, false, true, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_bg_add, false, false, true, false, 0, 0, 70, 172);
				evt.eventPlayMovie(DirectionManager.MOVIE.ksy000_1, false, false, false, false, 0, 0, 60, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1001_ss, DirectionManager.MOVIE.ksy000_1, true, false, false, false);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1001_s, false, false, false, false, 0, 0, 51, 248);
				break;
			case 9:
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1002_hai1, false, false, false, false, 0, 0, 100, 0);
				evt.eventPlayMovie(DirectionManager.MOVIE.hzp1002_zap, false, false, false, true, 196, 114, 90, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hzp1002_zap_loop, DirectionManager.MOVIE.hzp1002_zap, false, true, false, true);
				evt.eventPlayMovie(DirectionManager.MOVIE.hsl1002_sol, false, false, false, true, 70, 72, 80, 0);
				evt.eventAddMovie(DirectionManager.MOVIE.hsl1002_sol_loop, DirectionManager.MOVIE.hsl1002_sol, false, true, false, true);
				break;
			}
		}
		if (low == 0)
		{
			switch (mode)
			{
			case 1:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.m_panel_HOH_zp_vs_01(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_5M));
				break;
			case 2:
				DirectionLedManager.JG_HOH_herecomes_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.YK_HOH_herecomes_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_HOH_zp_vs_02(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_5M));
				break;
			case 3:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_psych_cutin(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.LG_HOH_sol_first_high_01(DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO));
				DirectionLedManager.OFF_8(DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE));
				break;
			case 4:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_U(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.OFF_7(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				break;
			case 5:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_TR(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 6:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_HOH_sol_JYD_TR(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				break;
			case 7:
				DirectionLedManager.OFF_2(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.m_panel_HOH_zp_vs_01(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_5M));
				break;
			case 8:
				DirectionLedManager.JG_HOH_herecomes_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1));
				DirectionLedManager.SE_KSY_close_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2));
				DirectionLedManager.GD_KSY_HOH_close(DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD));
				DirectionLedManager.YK_HOH_herecomes_02(DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD));
				DirectionLedManager.m_panel_HOH_zp_vs_03(DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_5M));
				break;
			}
		}
		dirWinChr();
		base.start();
	}

	public override void end()
	{
		base.end();
	}

	public override void control()
	{
		dirWinChr_led();
		base.control();
	}

	private void restartBGM()
	{
		if (low != 0)
		{
			return;
		}
		byte b = mode;
		if (b == 1 || b == 2 || b == 52 || b == 59)
		{
			return;
		}
		if (SGLG.sound.getBGMID() == 45)
		{
			if (SGLG.sound.getBGMVolume() < 1f)
			{
				evt.eventFadeSound(Sound.CH.BGM, 1f, 1f, 1, 0);
			}
		}
		else
		{
			evt.eventPlaySound(DirectionManager.SOUND.S0146, Sound.CH.BGM, false, 1f, 0);
		}
	}

	private void dirWinChr()
	{
		int num = MainGameScene.slotGameMan.get_pdt_data(24);
		int num2 = 0;
		switch (mode)
		{
		default:
			return;
		case 5:
			num2 = 153;
			break;
		case 6:
			num2 = 235;
			break;
		}
		switch (num)
		{
		case 115:
			evt.eventPlayMovie(DirectionManager.MOVIE.hsl600_sla, true, false, false, false, 0, 0, 65, num2);
			evt.eventPlayMovie(DirectionManager.MOVIE.hsl600_sla_add, true, false, true, false, 0, 0, 64, num2);
			evt.eventPlaySound(DirectionManager.SOUND.S0254, Sound.CH.VC0, true, 1f, num2);
			evt.eventPlaySound(DirectionManager.SOUND.S1949, Sound.CH.VC1, true, 1f, num2 + 6);
			break;
		case 116:
			evt.eventPlayMovie(DirectionManager.MOVIE.hsl600_per, true, false, false, false, 0, 0, 65, num2);
			evt.eventPlayMovie(DirectionManager.MOVIE.hsl600_per_add, true, false, true, false, 0, 0, 64, num2);
			evt.eventPlaySound(DirectionManager.SOUND.S0255, Sound.CH.VC0, true, 1f, num2);
			evt.eventPlaySound(DirectionManager.SOUND.S1951, Sound.CH.VC1, true, 1f, num2 + 10);
			break;
		case 117:
			evt.eventPlayMovie(DirectionManager.MOVIE.hsl600_des, true, false, false, false, 0, 0, 65, num2);
			evt.eventPlayMovie(DirectionManager.MOVIE.hsl600_des_add, true, false, true, false, 0, 0, 64, num2);
			evt.eventPlaySound(DirectionManager.SOUND.S0256, Sound.CH.VC0, true, 1f, num2);
			evt.eventPlaySound(DirectionManager.SOUND.S1950, Sound.CH.VC1, true, 1f, num2 + 9);
			break;
		case 118:
			evt.eventPlayMovie(DirectionManager.MOVIE.hsl600_cle, true, false, false, false, 0, 0, 65, num2);
			evt.eventPlayMovie(DirectionManager.MOVIE.hsl600_cle_add, true, false, true, false, 0, 0, 64, num2);
			evt.eventPlaySound(DirectionManager.SOUND.S0257, Sound.CH.VC0, true, 1f, num2);
			evt.eventPlaySound(DirectionManager.SOUND.S1967, Sound.CH.VC1, true, 1f, num2 + 7);
			break;
		}
	}

	private void dirWinChr_led()
	{
		if (!evt.m_Active)
		{
			return;
		}
		int num = 0;
		switch (mode)
		{
		default:
			return;
		case 5:
			num = 153;
			break;
		case 6:
			num = 235;
			break;
		}
		if (m_cnt == num)
		{
			switch (MainGameScene.slotGameMan.get_pdt_data(24))
			{
			case 115:
				DirectionPanelLED.runMac2App(2, 4);
				MainGameScene.slotGameMan.set_pdt_data(89, 2);
				MainGameScene.slotGameMan.m_dirData[89] = 2;
				break;
			case 116:
				DirectionPanelLED.runMac2App(2, 4);
				MainGameScene.slotGameMan.set_pdt_data(89, 2);
				MainGameScene.slotGameMan.m_dirData[89] = 2;
				break;
			case 117:
				DirectionPanelLED.runMac2App(2, 4);
				MainGameScene.slotGameMan.set_pdt_data(89, 2);
				MainGameScene.slotGameMan.m_dirData[89] = 2;
				break;
			case 118:
				DirectionPanelLED.runMac2App(2, 4);
				MainGameScene.slotGameMan.set_pdt_data(89, 2);
				MainGameScene.slotGameMan.m_dirData[89] = 2;
				break;
			}
		}
		m_cnt++;
	}
}
