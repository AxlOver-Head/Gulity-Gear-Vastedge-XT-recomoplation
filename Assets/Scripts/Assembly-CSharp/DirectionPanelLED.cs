public class DirectionPanelLED
{
	public enum CNV
	{
		BACK = 0,
		WAKU = 1,
		NAVI = 2,
		WIN = 3,
		SLASH = 4,
		CHAR = 5,
		DES = 6,
		PUSH = 7,
		LEVER = 8,
		PUSH_A = 9,
		MAX = 10
	}

	public static int LINE_PANEL_0 = DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_1M);

	public static int LINE_PANEL_1 = DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_2M);

	public static int LINE_PANEL_2 = DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_3M);

	public static int LINE_PANEL_3 = DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_4M);

	public static int LINE_PANEL_4 = DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_5M);

	public static int LINE_PANEL_5 = DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_6M);

	public static int LINE_PANEL_6 = DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_7M);

	public static int LINE_PANEL_7 = DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_8M);

	public static int LINE_PANEL_8 = DirectionLedManager.changeLineNum(LEDPanelManager.LINE.LAYER_9M);

	public static int[] m_procData = new int[10];

	public static void onCheck()
	{
		int num = runMac2App(MainGameScene.slotGameMan.getBackLmp(), 0);
		int num2 = runMac2App(MainGameScene.slotGameMan.getWakuLmp(), 1);
		int num3 = runMac2App(MainGameScene.slotGameMan.getNaviPanel(), 2);
		int num4 = runMac2App(MainGameScene.slotGameMan.getWinPanel(), 3);
		int num5 = runMac2App(MainGameScene.slotGameMan.getSlashPanel(), 4);
		int num6 = runMac2App(MainGameScene.slotGameMan.getCharPanel(), 5);
		int num7 = runMac2App(MainGameScene.slotGameMan.getDesPanel(), 6);
		int num8 = runMac2App(MainGameScene.slotGameMan.getPUSHbtnStatus(), 7);
		int num9 = runMac2App(MainGameScene.slotGameMan.getLEDLever(), 8);
		int num10 = runMac2App(MainGameScene.slotGameMan.getPUSHbtnStatus(), 9);
	}

	public static int runMac2App(int _id, int _type)
	{
		int result = 0;
		m_procData[_type] = _id;
		switch ((CNV)_type)
		{
		case CNV.BACK:
			switch (_id)
			{
			case 0:
				DirectionLedManager.OFF_0m(LINE_PANEL_0);
				break;
			case 1:
				DirectionLedManager.reel_00(LINE_PANEL_0);
				break;
			case 2:
				DirectionLedManager.reel_PB(LINE_PANEL_0);
				break;
			case 3:
				DirectionLedManager.reel_MB(LINE_PANEL_0);
				break;
			case 4:
				DirectionLedManager.reel_7_w1(LINE_PANEL_0);
				break;
			case 5:
				DirectionLedManager.reel_7_w2(LINE_PANEL_0);
				break;
			case 6:
				DirectionLedManager.reel_7_c(LINE_PANEL_0);
				break;
			case 7:
				DirectionLedManager.reel_7_cu(LINE_PANEL_0);
				break;
			case 8:
				DirectionLedManager.reel_7_cd(LINE_PANEL_0);
				break;
			case 9:
				DirectionLedManager.reel_bar(LINE_PANEL_0);
				break;
			case 10:
				DirectionLedManager.reel_bonus_in(LINE_PANEL_0);
				break;
			case 11:
				DirectionLedManager.reel_dest_in(LINE_PANEL_0);
				break;
			case 12:
				DirectionLedManager.reel_dest_miss(LINE_PANEL_0);
				break;
			case 13:
				DirectionLedManager.reel_replay_01(LINE_PANEL_0);
				break;
			case 14:
				DirectionLedManager.reel_replay_02(LINE_PANEL_0);
				break;
			case 15:
				DirectionLedManager.reel_replay_03(LINE_PANEL_0);
				break;
			case 16:
				DirectionLedManager.reel_replay_04(LINE_PANEL_0);
				break;
			case 17:
				DirectionLedManager.reel_replay_05(LINE_PANEL_0);
				break;
			case 18:
				DirectionLedManager.reel_replay_06(LINE_PANEL_0);
				break;
			case 19:
				DirectionLedManager.reel_replay_07(LINE_PANEL_0);
				break;
			case 20:
				DirectionLedManager.reel_replay_08(LINE_PANEL_0);
				break;
			case 21:
				DirectionLedManager.reel_replay_09(LINE_PANEL_0);
				break;
			case 22:
				DirectionLedManager.reel_replay_10(LINE_PANEL_0);
				break;
			case 23:
				DirectionLedManager.reel_replay_11(LINE_PANEL_0);
				break;
			case 24:
				DirectionLedManager.reel_replay_12(LINE_PANEL_0);
				break;
			case 25:
				DirectionLedManager.reel_replay_13(LINE_PANEL_0);
				break;
			case 26:
				DirectionLedManager.reel_bell_01(LINE_PANEL_0);
				break;
			case 27:
				DirectionLedManager.reel_bell_02(LINE_PANEL_0);
				break;
			case 28:
				DirectionLedManager.reel_bell_03(LINE_PANEL_0);
				break;
			case 29:
				DirectionLedManager.reel_bell_04(LINE_PANEL_0);
				break;
			case 30:
				DirectionLedManager.reel_bell_05(LINE_PANEL_0);
				break;
			case 31:
				DirectionLedManager.reel_bell_06(LINE_PANEL_0);
				break;
			case 32:
				DirectionLedManager.reel_bell_07(LINE_PANEL_0);
				break;
			case 33:
				DirectionLedManager.reel_bell_08(LINE_PANEL_0);
				break;
			case 34:
				DirectionLedManager.reel_bell_09(LINE_PANEL_0);
				break;
			case 35:
				DirectionLedManager.reel_bell_10(LINE_PANEL_0);
				break;
			case 36:
				DirectionLedManager.reel_bell_11(LINE_PANEL_0);
				break;
			case 37:
				DirectionLedManager.reel_bell_12(LINE_PANEL_0);
				break;
			case 38:
				DirectionLedManager.reel_bell_13(LINE_PANEL_0);
				break;
			case 39:
				DirectionLedManager.reel_bell_14(LINE_PANEL_0);
				break;
			case 40:
				DirectionLedManager.reel_bell_15(LINE_PANEL_0);
				break;
			case 41:
				DirectionLedManager.reel_bell_16(LINE_PANEL_0);
				break;
			case 42:
				DirectionLedManager.reel_bell_17(LINE_PANEL_0);
				break;
			case 43:
				DirectionLedManager.reel_bell_18(LINE_PANEL_0);
				break;
			case 44:
				DirectionLedManager.reel_bell_19(LINE_PANEL_0);
				break;
			case 45:
				DirectionLedManager.reel_bell_20(LINE_PANEL_0);
				break;
			case 46:
				DirectionLedManager.reel_bell_21(LINE_PANEL_0);
				break;
			case 47:
				DirectionLedManager.reel_bell_22(LINE_PANEL_0);
				break;
			case 48:
				DirectionLedManager.reel_bell_23(LINE_PANEL_0);
				break;
			case 49:
				DirectionLedManager.reel_bell_24(LINE_PANEL_0);
				break;
			case 50:
				DirectionLedManager.reel_suika_01(LINE_PANEL_0);
				break;
			case 51:
				DirectionLedManager.reel_suika_02(LINE_PANEL_0);
				break;
			case 52:
				DirectionLedManager.reel_suika_03(LINE_PANEL_0);
				break;
			case 53:
				DirectionLedManager.reel_suika_04(LINE_PANEL_0);
				break;
			case 54:
				DirectionLedManager.reel_suika_05(LINE_PANEL_0);
				break;
			case 55:
				DirectionLedManager.reel_suika_06(LINE_PANEL_0);
				break;
			case 56:
				DirectionLedManager.reel_suika_07(LINE_PANEL_0);
				break;
			case 57:
				DirectionLedManager.reel_suika_08(LINE_PANEL_0);
				break;
			case 58:
				DirectionLedManager.reel_cherry_01(LINE_PANEL_0);
				break;
			case 59:
				DirectionLedManager.reel_cherry_02(LINE_PANEL_0);
				break;
			case 60:
				DirectionLedManager.reel_cherry_03(LINE_PANEL_0);
				break;
			case 61:
				DirectionLedManager.reel_cherry_04(LINE_PANEL_0);
				break;
			case 62:
				DirectionLedManager.reel_cherry_05(LINE_PANEL_0);
				break;
			case 63:
				DirectionLedManager.reel_chance_01(LINE_PANEL_0);
				break;
			case 64:
				DirectionLedManager.reel_chance_02(LINE_PANEL_0);
				break;
			case 65:
				DirectionLedManager.reel_chance_03(LINE_PANEL_0);
				break;
			case 66:
				DirectionLedManager.reel_chance_04(LINE_PANEL_0);
				break;
			case 67:
				DirectionLedManager.reel_v(LINE_PANEL_0);
				break;
			case 68:
				DirectionLedManager.reel_dest_01(LINE_PANEL_0);
				break;
			case 69:
				DirectionLedManager.reel_dest_02(LINE_PANEL_0);
				break;
			case 70:
				DirectionLedManager.reel_dest_03(LINE_PANEL_0);
				break;
			case 71:
				DirectionLedManager.reel_dest_start(LINE_PANEL_0);
				break;
			case 72:
				DirectionLedManager.reel_demo(LINE_PANEL_0);
				break;
			case 73:
				DirectionLedManager.reel_dest_0G(LINE_PANEL_0);
				break;
			case 74:
				DirectionLedManager.reel_bell_25(LINE_PANEL_0);
				break;
			case 75:
				DirectionLedManager.reel_bell_26(LINE_PANEL_0);
				break;
			case 76:
				DirectionLedManager.reel_bell_27(LINE_PANEL_0);
				break;
			case 77:
				DirectionLedManager.reel_bell_28(LINE_PANEL_0);
				break;
			case 78:
				DirectionLedManager.reel_bell_29(LINE_PANEL_0);
				break;
			case 79:
				DirectionLedManager.reel_bell_30(LINE_PANEL_0);
				break;
			case 80:
				DirectionLedManager.reel_bell_31(LINE_PANEL_0);
				break;
			case 81:
				DirectionLedManager.reel_bell_32(LINE_PANEL_0);
				break;
			case 82:
				DirectionLedManager.reel_bell_33(LINE_PANEL_0);
				break;
			case 83:
				DirectionLedManager.reel_bell_34(LINE_PANEL_0);
				break;
			case 84:
				DirectionLedManager.reel_bell_35(LINE_PANEL_0);
				break;
			case 85:
				DirectionLedManager.reel_bell_36(LINE_PANEL_0);
				break;
			case 86:
				DirectionLedManager.reel_bell_37(LINE_PANEL_0);
				break;
			case 87:
				DirectionLedManager.reel_bell_38(LINE_PANEL_0);
				break;
			case 88:
				DirectionLedManager.reel_bell_39(LINE_PANEL_0);
				break;
			case 89:
				DirectionLedManager.reel_bell_40(LINE_PANEL_0);
				break;
			case 90:
				DirectionLedManager.reel_bell_41(LINE_PANEL_0);
				break;
			case 91:
				DirectionLedManager.reel_cherry_c(LINE_PANEL_0);
				break;
			}
			break;
		case CNV.WAKU:
			switch (_id)
			{
			case 1:
				DirectionLedManager.m_panel_DI_step_01(LINE_PANEL_1);
				break;
			case 2:
				DirectionLedManager.m_panel_DI_step_02(LINE_PANEL_1);
				break;
			case 3:
				DirectionLedManager.m_panel_DI_step_03(LINE_PANEL_1);
				break;
			case 4:
				DirectionLedManager.m_panel_DI_step_04(LINE_PANEL_1);
				break;
			case 5:
				DirectionLedManager.m_panel_wi_dest(LINE_PANEL_1);
				break;
			case 6:
				DirectionLedManager.m_panel_wi_dest_lose(LINE_PANEL_1);
				break;
			case 7:
				DirectionLedManager.m_panel_wi_reverse(LINE_PANEL_1);
				break;
			case 8:
				DirectionLedManager.m_panel_KCI_step_01(LINE_PANEL_1);
				break;
			case 9:
				DirectionLedManager.m_panel_KCI_step_02(LINE_PANEL_1);
				break;
			case 10:
				DirectionLedManager.m_panel_KCI_step_03(LINE_PANEL_1);
				break;
			}
			break;
		case CNV.NAVI:
			switch (_id)
			{
			case 0:
			case 1:
				DirectionLedManager.OFF_1m(LINE_PANEL_1);
				break;
			case 2:
				DirectionLedManager.m_panel_NV_y_L(LINE_PANEL_1);
				break;
			case 3:
				DirectionLedManager.m_panel_NV_y_C(LINE_PANEL_1);
				break;
			case 4:
				DirectionLedManager.m_panel_NV_y_R(LINE_PANEL_1);
				break;
			case 5:
				DirectionLedManager.m_panel_NV_y_get(LINE_PANEL_1);
				break;
			case 6:
				DirectionLedManager.m_panel_NV_b_L(LINE_PANEL_1);
				break;
			case 7:
				DirectionLedManager.m_panel_NV_b_C(LINE_PANEL_1);
				break;
			case 8:
				DirectionLedManager.m_panel_NV_b_R(LINE_PANEL_1);
				break;
			case 9:
				DirectionLedManager.m_panel_NV_b_get(LINE_PANEL_1);
				break;
			case 10:
				DirectionLedManager.m_panel_NV_w_L(LINE_PANEL_1);
				break;
			case 11:
				DirectionLedManager.m_panel_NV_w_C(LINE_PANEL_1);
				break;
			case 12:
				DirectionLedManager.m_panel_NV_w_R(LINE_PANEL_1);
				break;
			case 13:
				DirectionLedManager.m_panel_NV_w_get(LINE_PANEL_1);
				break;
			case 14:
				DirectionLedManager.m_panel_NV_p_L(LINE_PANEL_1);
				break;
			case 15:
				DirectionLedManager.m_panel_NV_p_C(LINE_PANEL_1);
				break;
			case 16:
				DirectionLedManager.m_panel_NV_p_R(LINE_PANEL_1);
				break;
			case 17:
				DirectionLedManager.m_panel_NV_p_get(LINE_PANEL_1);
				break;
			case 18:
				DirectionLedManager.m_panel_NV_Q_ooo(LINE_PANEL_1);
				break;
			case 19:
				DirectionLedManager.m_panel_NV_Q_xoo(LINE_PANEL_1);
				break;
			case 20:
				DirectionLedManager.m_panel_NV_Q_xxo(LINE_PANEL_1);
				break;
			case 21:
				DirectionLedManager.m_panel_NV_Q_xox(LINE_PANEL_1);
				break;
			case 22:
				DirectionLedManager.m_panel_NV_Q_oxo(LINE_PANEL_1);
				break;
			case 23:
				DirectionLedManager.m_panel_NV_Q_oxx(LINE_PANEL_1);
				break;
			case 24:
				DirectionLedManager.m_panel_NV_Q_oox(LINE_PANEL_1);
				break;
			case 25:
				DirectionLedManager.m_panel_NV_r_L(LINE_PANEL_1);
				break;
			case 26:
				DirectionLedManager.m_panel_NV_r_C(LINE_PANEL_1);
				break;
			case 27:
				DirectionLedManager.m_panel_NV_r_R(LINE_PANEL_1);
				break;
			case 28:
				DirectionLedManager.m_panel_NV_r_get(LINE_PANEL_1);
				break;
			}
			break;
		case CNV.WIN:
			switch (_id)
			{
			case 0:
				DirectionLedManager.OFF_2m(LINE_PANEL_2);
				break;
			case 1:
				DirectionLedManager.m_panel_win_heat_01(LINE_PANEL_2);
				break;
			case 2:
				DirectionLedManager.m_panel_win_heat_02(LINE_PANEL_2);
				break;
			case 3:
				DirectionLedManager.m_panel_win_heat_03(LINE_PANEL_2);
				break;
			case 4:
				DirectionLedManager.m_panel_win(LINE_PANEL_2);
				break;
			case 5:
				DirectionLedManager.m_panel_win_SGB_in(LINE_PANEL_2);
				break;
			case 6:
				DirectionLedManager.m_panel_win_GB_in(LINE_PANEL_2);
				break;
			case 7:
				DirectionLedManager.m_panel_win_RB_in(LINE_PANEL_2);
				break;
			case 8:
				DirectionLedManager.m_panel_win_PB_in(LINE_PANEL_2);
				break;
			case 9:
				DirectionLedManager.m_panel_win_RB_end(LINE_PANEL_2);
				break;
			case 10:
				DirectionLedManager.m_panel_win_GB_end(LINE_PANEL_2);
				break;
			case 11:
				DirectionLedManager.m_panel_win_SGB_end(LINE_PANEL_2);
				break;
			case 12:
				DirectionLedManager.m_panel_win_PB_end(LINE_PANEL_2);
				break;
			}
			break;
		case CNV.SLASH:
			switch (_id)
			{
			case 0:
				DirectionLedManager.m_panel_odds(LINE_PANEL_3);
				break;
			case 1:
				DirectionLedManager.m_panel_odds(LINE_PANEL_3);
				break;
			case 2:
				DirectionLedManager.m_panel_slash(LINE_PANEL_3);
				break;
			case 3:
				DirectionLedManager.m_panel_slash_MGO_01(LINE_PANEL_3);
				break;
			case 4:
				DirectionLedManager.m_panel_slash_MGO_02(LINE_PANEL_3);
				break;
			case 5:
				DirectionLedManager.m_panel_slash_MGO_03(LINE_PANEL_3);
				break;
			case 6:
				DirectionLedManager.m_panel_slash_RSH_01(LINE_PANEL_3);
				break;
			case 7:
				DirectionLedManager.m_panel_slash_RSH_02(LINE_PANEL_3);
				break;
			case 8:
				DirectionLedManager.m_panel_slash_RSH_03(LINE_PANEL_3);
				break;
			case 9:
				DirectionLedManager.m_panel_slash_CMB_01(LINE_PANEL_3);
				break;
			case 10:
				DirectionLedManager.m_panel_slash_CMB_02(LINE_PANEL_3);
				break;
			case 11:
				DirectionLedManager.m_panel_slash_CMB_03(LINE_PANEL_3);
				break;
			case 12:
				DirectionLedManager.m_panel_slash_KOG_01(LINE_PANEL_3);
				break;
			case 13:
				DirectionLedManager.m_panel_slash_KOG_02(LINE_PANEL_3);
				break;
			}
			break;
		case CNV.CHAR:
			switch (_id)
			{
			case 0:
				DirectionLedManager.OFF_4m(LINE_PANEL_4);
				break;
			case 1:
				DirectionLedManager.m_panel_HOH(LINE_PANEL_4);
				break;
			case 2:
				DirectionLedManager.m_panel_KBS_sl(LINE_PANEL_4);
				break;
			case 3:
				DirectionLedManager.m_panel_KBS_cp(LINE_PANEL_4);
				break;
			case 4:
				DirectionLedManager.m_panel_KBS_ml(LINE_PANEL_4);
				break;
			case 5:
				DirectionLedManager.m_panel_KBS_bj(LINE_PANEL_4);
				break;
			case 6:
				DirectionLedManager.m_panel_KBS_zp(LINE_PANEL_4);
				break;
			case 7:
				DirectionLedManager.m_panel_KBS_01(LINE_PANEL_4);
				break;
			case 8:
				DirectionLedManager.m_panel_KBS_02(LINE_PANEL_4);
				break;
			case 9:
				DirectionLedManager.m_panel_KBS_03(LINE_PANEL_4);
				break;
			case 10:
				DirectionLedManager.m_panel_KBS_04(LINE_PANEL_4);
				break;
			case 11:
				DirectionLedManager.m_panel_KBS_05(LINE_PANEL_4);
				break;
			case 12:
				DirectionLedManager.m_panel_HOH_sl_vs_01(LINE_PANEL_4);
				break;
			case 13:
				DirectionLedManager.m_panel_HOH_sl_vs_02(LINE_PANEL_4);
				break;
			case 14:
				DirectionLedManager.m_panel_HOH_sl_vs_03(LINE_PANEL_4);
				break;
			case 15:
				DirectionLedManager.m_panel_HOH_sl_01(LINE_PANEL_4);
				break;
			case 16:
				DirectionLedManager.m_panel_HOH_sl_02(LINE_PANEL_4);
				break;
			case 17:
				DirectionLedManager.m_panel_HOH_cp_vs_01(LINE_PANEL_4);
				break;
			case 18:
				DirectionLedManager.m_panel_HOH_cp_vs_02(LINE_PANEL_4);
				break;
			case 19:
				DirectionLedManager.m_panel_HOH_cp_vs_03(LINE_PANEL_4);
				break;
			case 20:
				DirectionLedManager.m_panel_HOH_cp_01(LINE_PANEL_4);
				break;
			case 21:
				DirectionLedManager.m_panel_HOH_cp_02(LINE_PANEL_4);
				break;
			case 22:
				DirectionLedManager.m_panel_HOH_ml_vs_01(LINE_PANEL_4);
				break;
			case 23:
				DirectionLedManager.m_panel_HOH_ml_vs_02(LINE_PANEL_4);
				break;
			case 24:
				DirectionLedManager.m_panel_HOH_ml_vs_03(LINE_PANEL_4);
				break;
			case 25:
				DirectionLedManager.m_panel_HOH_ml_01(LINE_PANEL_4);
				break;
			case 26:
				DirectionLedManager.m_panel_HOH_ml_02(LINE_PANEL_4);
				break;
			case 27:
				DirectionLedManager.m_panel_HOH_bj_vs_01(LINE_PANEL_4);
				break;
			case 28:
				DirectionLedManager.m_panel_HOH_bj_vs_02(LINE_PANEL_4);
				break;
			case 29:
				DirectionLedManager.m_panel_HOH_bj_vs_03(LINE_PANEL_4);
				break;
			case 30:
				DirectionLedManager.m_panel_HOH_bj_01(LINE_PANEL_4);
				break;
			case 31:
				DirectionLedManager.m_panel_HOH_bj_02(LINE_PANEL_4);
				break;
			case 32:
				DirectionLedManager.m_panel_HOH_zp_vs_01(LINE_PANEL_4);
				break;
			case 33:
				DirectionLedManager.m_panel_HOH_zp_vs_02(LINE_PANEL_4);
				break;
			case 34:
				DirectionLedManager.m_panel_HOH_zp_vs_03(LINE_PANEL_4);
				break;
			case 35:
				DirectionLedManager.m_panel_HOH_zp_01(LINE_PANEL_4);
				break;
			}
			break;
		case CNV.DES:
			switch (_id)
			{
			case 0:
				DirectionLedManager.OFF_5m(LINE_PANEL_5);
				break;
			case 1:
				DirectionLedManager.m_panel_dest_01(LINE_PANEL_5);
				break;
			case 2:
				DirectionLedManager.m_panel_dest_02(LINE_PANEL_5);
				break;
			case 3:
				DirectionLedManager.m_panel_dest_03(LINE_PANEL_5);
				break;
			case 4:
				DirectionLedManager.m_panel_dest_04(LINE_PANEL_5);
				break;
			case 5:
				DirectionLedManager.m_panel_DI_f_01(LINE_PANEL_5);
				break;
			case 6:
				DirectionLedManager.m_panel_DI_f_02(LINE_PANEL_5);
				break;
			case 7:
				DirectionLedManager.m_panel_DI_in(LINE_PANEL_5);
				break;
			case 8:
				DirectionLedManager.m_panel_DI_01(LINE_PANEL_5);
				break;
			case 9:
				DirectionLedManager.m_panel_DI_02(LINE_PANEL_5);
				break;
			}
			break;
		case CNV.PUSH:
			switch (_id)
			{
			case 0:
				DirectionLedManager.OFF_6m(LINE_PANEL_6);
				break;
			case 1:
				DirectionLedManager.push_white(LINE_PANEL_6);
				break;
			case 2:
				DirectionLedManager.push_blue(LINE_PANEL_6);
				break;
			case 3:
				DirectionLedManager.push_yellow(LINE_PANEL_6);
				break;
			case 4:
				DirectionLedManager.push_green(LINE_PANEL_6);
				break;
			case 5:
				DirectionLedManager.push_red(LINE_PANEL_6);
				break;
			case 6:
				DirectionLedManager.push_purple(LINE_PANEL_6);
				break;
			case 7:
				DirectionLedManager.push_rainbow(LINE_PANEL_6);
				break;
			case 8:
				DirectionLedManager.push_flash_white(LINE_PANEL_6);
				break;
			case 9:
				DirectionLedManager.push_flash_blue(LINE_PANEL_6);
				break;
			case 10:
				DirectionLedManager.push_flash_yellow(LINE_PANEL_6);
				break;
			case 11:
				DirectionLedManager.push_flash_green(LINE_PANEL_6);
				break;
			case 12:
				DirectionLedManager.push_flash_red(LINE_PANEL_6);
				break;
			case 13:
				DirectionLedManager.push_flash_purple(LINE_PANEL_6);
				break;
			case 14:
				DirectionLedManager.push_flash_rainbow(LINE_PANEL_6);
				break;
			case 15:
				DirectionLedManager.push_blink_white(LINE_PANEL_6);
				break;
			case 16:
				DirectionLedManager.push_blink_blue_01(LINE_PANEL_6);
				break;
			case 17:
				DirectionLedManager.push_blink_blue_02(LINE_PANEL_6);
				break;
			case 18:
				DirectionLedManager.push_blink_red_01(LINE_PANEL_6);
				break;
			case 19:
				DirectionLedManager.push_blink_red_02(LINE_PANEL_6);
				break;
			case 20:
				DirectionLedManager.push_on_rainbow(LINE_PANEL_6);
				break;
			case 21:
				DirectionLedManager.push_flash_white(LINE_PANEL_6);
				break;
			case 22:
				DirectionLedManager.push_flash_blue(LINE_PANEL_6);
				break;
			case 23:
				DirectionLedManager.push_flash_yellow(LINE_PANEL_6);
				break;
			case 24:
				DirectionLedManager.push_flash_green(LINE_PANEL_6);
				break;
			case 25:
				DirectionLedManager.push_flash_red(LINE_PANEL_6);
				break;
			case 26:
				DirectionLedManager.push_flash_purple(LINE_PANEL_6);
				break;
			case 27:
				DirectionLedManager.push_flash_rainbow(LINE_PANEL_6);
				break;
			case 28:
				DirectionLedManager.push_blink_white(LINE_PANEL_6);
				break;
			case 29:
				DirectionLedManager.push_blink_blue_01(LINE_PANEL_6);
				break;
			case 30:
				DirectionLedManager.push_blink_red_01(LINE_PANEL_6);
				break;
			case 31:
				DirectionLedManager.push_on_rainbow_BZT(LINE_PANEL_6);
				break;
			case 32:
				DirectionLedManager.push_flash_white(LINE_PANEL_6);
				break;
			case 33:
				DirectionLedManager.push_flash_rainbow(LINE_PANEL_6);
				break;
			}
			break;
		case CNV.LEVER:
			switch (_id)
			{
			case 0:
				DirectionLedManager.lever_ball_on(LINE_PANEL_7);
				break;
			case 1:
				DirectionLedManager.lever_ball_white(LINE_PANEL_7);
				break;
			case 2:
				DirectionLedManager.lever_ball_blue(LINE_PANEL_7);
				break;
			case 3:
				DirectionLedManager.lever_ball_yellow(LINE_PANEL_7);
				break;
			case 4:
				DirectionLedManager.lever_ball_green(LINE_PANEL_7);
				break;
			case 5:
				DirectionLedManager.lever_ball_red(LINE_PANEL_7);
				break;
			case 6:
				DirectionLedManager.lever_ball_purple(LINE_PANEL_7);
				break;
			case 7:
				DirectionLedManager.lever_ball_rainbow(LINE_PANEL_7);
				break;
			}
			break;
		case CNV.PUSH_A:
			switch (_id)
			{
			case 0:
				DirectionLedManager.OFF_8m(LINE_PANEL_8);
				break;
			case 1:
				DirectionLedManager.push_around_white(LINE_PANEL_8);
				break;
			case 2:
				DirectionLedManager.push_around_blue(LINE_PANEL_8);
				break;
			case 3:
				DirectionLedManager.push_around_yellow(LINE_PANEL_8);
				break;
			case 4:
				DirectionLedManager.push_around_green(LINE_PANEL_8);
				break;
			case 5:
				DirectionLedManager.push_around_red(LINE_PANEL_8);
				break;
			case 6:
				DirectionLedManager.push_around_purple(LINE_PANEL_8);
				break;
			case 7:
				DirectionLedManager.push_around_rainbow(LINE_PANEL_8);
				break;
			case 8:
				DirectionLedManager.push_around_flash_white(LINE_PANEL_8);
				break;
			case 9:
				DirectionLedManager.push_around_flash_blue(LINE_PANEL_8);
				break;
			case 10:
				DirectionLedManager.push_around_flash_yellow(LINE_PANEL_8);
				break;
			case 11:
				DirectionLedManager.push_around_flash_green(LINE_PANEL_8);
				break;
			case 12:
				DirectionLedManager.push_around_flash_red(LINE_PANEL_8);
				break;
			case 13:
				DirectionLedManager.push_around_flash_purple(LINE_PANEL_8);
				break;
			case 14:
				DirectionLedManager.push_around_flash_rainbow(LINE_PANEL_8);
				break;
			case 15:
				DirectionLedManager.push_around_blink_white(LINE_PANEL_8);
				break;
			case 16:
				DirectionLedManager.push_around_blink_blue_01(LINE_PANEL_8);
				break;
			case 17:
				DirectionLedManager.push_around_blink_blue_02(LINE_PANEL_8);
				break;
			case 18:
				DirectionLedManager.push_around_blink_red_01(LINE_PANEL_8);
				break;
			case 19:
				DirectionLedManager.push_around_blink_red_02(LINE_PANEL_8);
				break;
			case 20:
				DirectionLedManager.push_around_on_rainbow(LINE_PANEL_8);
				break;
			case 21:
				DirectionLedManager.push_around_flash_white(LINE_PANEL_8);
				break;
			case 22:
				DirectionLedManager.push_around_flash_blue(LINE_PANEL_8);
				break;
			case 23:
				DirectionLedManager.push_around_flash_yellow(LINE_PANEL_8);
				break;
			case 24:
				DirectionLedManager.push_around_flash_green(LINE_PANEL_8);
				break;
			case 25:
				DirectionLedManager.push_around_flash_red(LINE_PANEL_8);
				break;
			case 26:
				DirectionLedManager.push_around_flash_purple(LINE_PANEL_8);
				break;
			case 27:
				DirectionLedManager.push_around_flash_rainbow(LINE_PANEL_8);
				break;
			case 28:
				DirectionLedManager.push_around_flash_white(LINE_PANEL_8);
				break;
			case 29:
				DirectionLedManager.push_around_flash_blue(LINE_PANEL_8);
				break;
			case 30:
				DirectionLedManager.push_around_flash_red(LINE_PANEL_8);
				break;
			case 31:
				DirectionLedManager.push_around_on_rainbow_BZT(LINE_PANEL_8);
				break;
			case 32:
				DirectionLedManager.push_around_flash_white(LINE_PANEL_8);
				break;
			case 33:
				DirectionLedManager.push_around_on_rainbow(LINE_PANEL_8);
				break;
			}
			break;
		}
		return result;
	}
}
