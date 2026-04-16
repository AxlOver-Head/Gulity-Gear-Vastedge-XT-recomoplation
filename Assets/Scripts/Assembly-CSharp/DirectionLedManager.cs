public class DirectionLedManager
{
	private enum LMP_KOYAKU
	{
		E_LMP_DUMMY = 0,
		E_LMP_NML_ON = 1,
		E_LMP_PB = 2,
		E_LMP_MB = 3,
		E_LMP_7W1 = 4,
		E_LMP_7W2 = 5,
		E_LMP_7SC = 6,
		E_LMP_7SCU = 7,
		E_LMP_7SCD = 8,
		E_LMP_BAR = 9,
		E_LMP_BNS = 10,
		E_LMP_DES = 11,
		E_LMP_NO_DES = 12,
		E_LMP_DN_REP = 13,
		E_LMP_RT2_REP = 14,
		E_LMP_RT4_REP = 15,
		E_LMP_NML_SPREP = 16,
		E_LMP_CHN_SPREP = 17,
		E_LMP_HOH_SPREP = 18,
		E_LMP_NML_CREP = 19,
		E_LMP_CHN_CREP = 20,
		E_LMP_NML_TREP = 21,
		E_LMP_CHN_TREP = 22,
		E_LMP_REACH_REP = 23,
		E_LMP_NML_BREP = 24,
		E_LMP_CHN_BREP = 25,
		E_LMP_NML_DBELL = 26,
		E_LMP_CHN_DBELL = 27,
		E_LMP_NML_SVBELL = 28,
		E_LMP_CHN_SVBELL = 29,
		E_LMP_NML_CUBELL = 30,
		E_LMP_CHN_CUBELL = 31,
		E_LMP_NML_CCHE_CUBELL = 32,
		E_LMP_CHN_CCHE_CUBELL = 33,
		E_LMP_NML_UCHE_CUBELL = 34,
		E_LMP_CHN_UCHE_CUBELL = 35,
		E_LMP_NML_SYBELL = 36,
		E_LMP_CHN_SYBELL = 37,
		E_LMP_NML_CCHE_SYBELL = 38,
		E_LMP_CHN_CCHE_SYBELL = 39,
		E_LMP_NML_UCHE_SYBELL = 40,
		E_LMP_CHN_UCHE_SYBELL = 41,
		E_LMP_NML_UBELL = 42,
		E_LMP_CHN_UBELL = 43,
		E_LMP_NML_CBELL = 44,
		E_LMP_CHN_CBELL = 45,
		E_LMP_NML_CHE_CBELL = 46,
		E_LMP_CHN_CHE_CBELL = 47,
		E_LMP_ART_KOBOSI = 48,
		E_LMP_HOH_KOBOSI = 49,
		E_LMP_NML_CHE_CSUIKA = 50,
		E_LMP_CHN_CHE_CSUIKA = 51,
		E_LMP_NML_CSUIKA = 52,
		E_LMP_CHN_CSUIKA = 53,
		E_LMP_NML_DSUIKA = 54,
		E_LMP_CHN_DSUIKA = 55,
		E_LMP_NML_CHE_DSUIKA = 56,
		E_LMP_CHN_CHE_DSUIKA = 57,
		E_LMP_NML_LOCHE = 58,
		E_LMP_CHN_LOCHE = 59,
		E_LMP_NML_HICHE = 60,
		E_LMP_CHN_HiCHE = 61,
		E_LMP_NML_CCHE = 62,
		E_LMP_NML_CHNA = 63,
		E_LMP_CHN_CHNA = 64,
		E_LMP_NML_CHNBC = 65,
		E_LMP_CHN_CHNBC = 66,
		E_LMP_KAKUTEI = 67,
		E_LMP_DES_R = 68,
		E_LMP_DES_CL = 69,
		E_LMP_DES_CLR = 70,
		E_LMP_DES_LEV = 71,
		E_LMP_DEMO = 72,
		E_LMP_0G_DES = 73,
		E_LMP_BELL_KYO = 74,
		E_LMP_NML_DBELL_ART = 75,
		E_LMP_CHN_DBELL_ART = 76,
		E_LMP_NML_SVBELL_ART = 77,
		E_LMP_CHN_SVBELL_ART = 78,
		E_LMP_NML_CUBELL_ART = 79,
		E_LMP_CHN_CUBELL_ART = 80,
		E_LMP_NML_CCHE_CUBELL_ART = 81,
		E_LMP_CHN_CCHE_CUBELL_ART = 82,
		E_LMP_NML_UCHE_CUBELL_ART = 83,
		E_LMP_CHN_UCHE_CUBELL_ART = 84,
		E_LMP_NML_SYBELL_ART = 85,
		E_LMP_CHN_SYBELL_ART = 86,
		E_LMP_NML_CCHE_SYBELL_ART = 87,
		E_LMP_CHN_CCHE_SYBELL_ART = 88,
		E_LMP_NML_UCHE_SYBELL_ART = 89,
		E_LMP_CHN_UCHE_SYBELL_ART = 90,
		E_LMP_LFT_CHE_C = 91,
		E_LMP_BACK_MAX = 92
	}

	public static string[] lName = new string[26]
	{
		"STATE", "BGM_1", "BGM_2", "UNDERPANEL", "CG", "GD", "LOGO", "JYD", "DRIVE", "LGAUGE_1",
		"LGAUGE_2", "LGAUGE_3", "LGAUGE_4", "LGAUGE_5", "LGAUGE_6", "LGAUGE_DI", "DEMO", "LAYER_1M", "LAYER_2M", "LAYER_3M",
		"LAYER_4M", "LAYER_5M", "LAYER_6M", "LAYER_7M", "LAYER_8M", "LAYER_9M"
	};

	public static int LINE_MAX = 26;

	public static DirectionLedData[] data = new DirectionLedData[LINE_MAX];

	public static LEDMainManager lmm;

	public static LEDPanelManager lpm;

	public static int[] procedDate = new int[LINE_MAX];

	public DirectionLedManager(LEDMainManager _lmm, LEDPanelManager _lpm)
	{
		LEDMainManager.LINE[] array = new LEDMainManager.LINE[17]
		{
			LEDMainManager.LINE.STATE,
			LEDMainManager.LINE.BGM_1,
			LEDMainManager.LINE.BGM_2,
			LEDMainManager.LINE.UNDERPANEL,
			LEDMainManager.LINE.CG,
			LEDMainManager.LINE.GD,
			LEDMainManager.LINE.LOGO,
			LEDMainManager.LINE.JYD,
			LEDMainManager.LINE.DRIVE,
			LEDMainManager.LINE.LGAUGE_1,
			LEDMainManager.LINE.LGAUGE_2,
			LEDMainManager.LINE.LGAUGE_3,
			LEDMainManager.LINE.LGAUGE_4,
			LEDMainManager.LINE.LGAUGE_5,
			LEDMainManager.LINE.LGAUGE_6,
			LEDMainManager.LINE.LGAUGE_DI,
			LEDMainManager.LINE.DEMO
		};
		LEDPanelManager.LINE[] array2 = new LEDPanelManager.LINE[9]
		{
			LEDPanelManager.LINE.LAYER_1M,
			LEDPanelManager.LINE.LAYER_2M,
			LEDPanelManager.LINE.LAYER_3M,
			LEDPanelManager.LINE.LAYER_4M,
			LEDPanelManager.LINE.LAYER_5M,
			LEDPanelManager.LINE.LAYER_6M,
			LEDPanelManager.LINE.LAYER_7M,
			LEDPanelManager.LINE.LAYER_8M,
			LEDPanelManager.LINE.LAYER_9M
		};
		int num = 0;
		for (num = 0; num < LINE_MAX; num++)
		{
			if (num < 17)
			{
				data[num] = new DirectionLedData(num, array[num]);
			}
			else
			{
				data[num] = new DirectionLedData(num, array2[num - 17]);
			}
		}
		lmm = _lmm;
		lpm = _lpm;
		int num2 = 0;
		for (num2 = 0; num2 < LINE_MAX; num2++)
		{
			procedDate[num2] = 0;
		}
	}

	public static void init(int _line)
	{
		data[_line].init();
	}

	public static void setData(int _line, int _frame, int _event, int _param)
	{
		data[_line].setEvent(_frame, _event, _param);
	}

	public void control()
	{
		int num = 0;
		for (num = 0; num < LINE_MAX; num++)
		{
			data[num].control(lmm, lpm);
		}
	}

	public static int changeLineNum(LEDMainManager.LINE _line)
	{
		return (int)_line;
	}

	public static int changeLineNum(LEDPanelManager.LINE _line)
	{
		return (int)(_line + 17);
	}

	public void setSndLed(DirectionManager.SOUND _id)
	{
		int line = changeLineNum(LEDMainManager.LINE.JYD);
		int line2 = changeLineNum(LEDMainManager.LINE.BGM_1);
		int line3 = changeLineNum(LEDMainManager.LINE.BGM_2);
		int num = changeLineNum(LEDMainManager.LINE.DEMO);
		switch (_id)
		{
		case DirectionManager.SOUND.S0065:
			JYD_unite(line);
			break;
		case DirectionManager.SOUND.S0066:
			JYD_unite(line);
			break;
		case DirectionManager.SOUND.S0073:
			JYD_unite(line);
			break;
		case DirectionManager.SOUND.S0074:
			JYD_unite(line);
			break;
		case DirectionManager.SOUND.S0076:
			JYD_unite_YTG(line);
			break;
		case DirectionManager.SOUND.S0101:
			BG_MTH(line3);
			break;
		case DirectionManager.SOUND.S0102:
			BG_MJM(line3);
			break;
		case DirectionManager.SOUND.S0103:
			JG_M_hattenn(line3);
			break;
		case DirectionManager.SOUND.S0104:
			BG_RIS(line3);
			break;
		case DirectionManager.SOUND.S0105:
			BG_RIZ(line3);
			break;
		case DirectionManager.SOUND.S0106:
			JG_R_hattenn(line3);
			break;
		case DirectionManager.SOUND.S0107:
			BG_CST(line2);
			break;
		case DirectionManager.SOUND.S0108:
			BG_CSH(line3);
			break;
		case DirectionManager.SOUND.S0109:
			JG_C_hattenn(line3);
			break;
		case DirectionManager.SOUND.S0110:
			JG_stage_change(line3);
			break;
		case DirectionManager.SOUND.S0111:
			BG_MAP(line3);
			break;
		case DirectionManager.SOUND.S0112:
			BG_KPR(line3);
			break;
		case DirectionManager.SOUND.S0114:
			BG_KKZ(line3);
			break;
		case DirectionManager.SOUND.S0115:
			BG_KGR(line3);
			break;
		case DirectionManager.SOUND.S0116:
			JG_hattenn_hanyou1(line3);
			break;
		case DirectionManager.SOUND.S0117:
			JG_hattenn_hanyou2(line3);
			break;
		case DirectionManager.SOUND.S0118:
			JG_hattenn_hanyou3(line3);
			break;
		case DirectionManager.SOUND.S0119:
			JG_YJD(line3);
			break;
		case DirectionManager.SOUND.S0121:
			BG_KFR_DI(line2);
			YK_KFR_DI(line);
			break;
		case DirectionManager.SOUND.S0122:
			JG_KBS_in(line2);
			break;
		case DirectionManager.SOUND.S0123:
			BG_KBS(line2);
			break;
		case DirectionManager.SOUND.S0124:
			JG_KBS_decide(line2);
			break;
		case DirectionManager.SOUND.S0125:
			BG_KBU(line3);
			break;
		case DirectionManager.SOUND.S0126:
			JG_KBU_decide(line3);
			break;
		case DirectionManager.SOUND.S0127:
			JG_IGO(line3);
			break;
		case DirectionManager.SOUND.S0128:
			BG_MGO(line2);
			break;
		case DirectionManager.SOUND.S0129:
			JG_ISH(line3);
			break;
		case DirectionManager.SOUND.S0130:
			BG_RSH(line2);
			break;
		case DirectionManager.SOUND.S0131:
			JG_IMB(line3);
			break;
		case DirectionManager.SOUND.S0132:
			BG_CMB(line2);
			break;
		case DirectionManager.SOUND.S0133:
			JG_IOG(line3);
			break;
		case DirectionManager.SOUND.S0134:
			BG_KOG(line2);
			break;
		case DirectionManager.SOUND.S0135:
			JG_win_sol(line3);
			YK_win_sol(line);
			break;
		case DirectionManager.SOUND.S0136:
			JG_win_sin(line3);
			YK_win_sin(line);
			break;
		case DirectionManager.SOUND.S0137:
			JG_lose(line3);
			break;
		case DirectionManager.SOUND.S0138:
			JG_IJS(line2);
			break;
		case DirectionManager.SOUND.S0139:
			BG_JST(line2);
			break;
		case DirectionManager.SOUND.S0140:
			JG_IHH(line2);
			break;
		case DirectionManager.SOUND.S0141:
			JG_VS(line2);
			YK_VS(line);
			break;
		case DirectionManager.SOUND.S0142:
			BG_HSL(line2);
			break;
		case DirectionManager.SOUND.S0143:
			BG_HCP(line2);
			break;
		case DirectionManager.SOUND.S0144:
			BG_HML(line2);
			break;
		case DirectionManager.SOUND.S0145:
			BG_HBJ(line2);
			break;
		case DirectionManager.SOUND.S0146:
			BG_HZP(line2);
			break;
		case DirectionManager.SOUND.S0149:
			BG_BGT(line2);
			break;
		case DirectionManager.SOUND.S0150:
			BG_BJT_01(line2);
			break;
		case DirectionManager.SOUND.S0152:
			BG_BJT_02(line2);
			break;
		case DirectionManager.SOUND.S0153:
			BG_BM2_intro(line2);
			break;
		case DirectionManager.SOUND.S0154:
			BG_BM2_loop(line2);
			break;
		case DirectionManager.SOUND.S0155:
			BG_BM2_end(line2);
			break;
		case DirectionManager.SOUND.S0157:
			BG_BAO(line2);
			break;
		case DirectionManager.SOUND.S0159:
			BG_BM1(line2);
			break;
		case DirectionManager.SOUND.S0160:
			BG_BM1_end(line2);
			break;
		case DirectionManager.SOUND.S0161:
			BG_PRC(line3);
			break;
		case DirectionManager.SOUND.S0162:
			JG_PRC_end(line3);
			break;
		case DirectionManager.SOUND.S0163:
			BG_BKS(line2);
			break;
		case DirectionManager.SOUND.S0164:
			BG_BKS_end(line2);
			break;
		case DirectionManager.SOUND.S0165:
			JG_ISS(line3);
			YK_ISS(line);
			break;
		case DirectionManager.SOUND.S0166:
			BG_ART_01(line2);
			break;
		case DirectionManager.SOUND.S0167:
			BG_ART_02(line2);
			break;
		case DirectionManager.SOUND.S0168:
			BG_ART_03(line2);
			break;
		case DirectionManager.SOUND.S0169:
			BG_ART_04(line2);
			break;
		case DirectionManager.SOUND.S0170:
			BG_ART_05(line2);
			break;
		case DirectionManager.SOUND.S0171:
			BG_ART_06(line2);
			break;
		case DirectionManager.SOUND.S0172:
			BG_ART_07(line2);
			break;
		case DirectionManager.SOUND.S0173:
			BG_ART_08(line2);
			break;
		case DirectionManager.SOUND.S0174:
			BG_sisetsu1(line2);
			break;
		case DirectionManager.SOUND.S0175:
			BG_sisetsu2(line2);
			break;
		case DirectionManager.SOUND.S0176:
			BG_ACZ(line2);
			break;
		case DirectionManager.SOUND.S0178:
			BG_DST(line2);
			break;
		case DirectionManager.SOUND.S0180:
			BG_BZT(line2);
			break;
		case DirectionManager.SOUND.S0181:
			BG_BZT_ED(line2);
			break;
		case DirectionManager.SOUND.S0182:
			BG_SOL_rev(line3);
			break;
		case DirectionManager.SOUND.S0183:
			BG_SIN_rev(line3);
			break;
		case DirectionManager.SOUND.S0184:
			JG_SL_in(line3);
			break;
		case DirectionManager.SOUND.S0185:
			JG_CP_in(line3);
			break;
		case DirectionManager.SOUND.S0186:
			JG_ML_in(line3);
			break;
		case DirectionManager.SOUND.S0187:
			JG_BJ_in(line3);
			break;
		case DirectionManager.SOUND.S0188:
			JG_ZP_in(line3);
			break;
		case DirectionManager.SOUND.S0189:
			JG_KY_in(line3);
			break;
		case DirectionManager.SOUND.S0190:
			JG_AO_in(line3);
			YK_AO_in(line);
			break;
		case DirectionManager.SOUND.S0191:
			JG_SO_in(line3);
			break;
		case DirectionManager.SOUND.S0192:
			BG_MTH_CU(line3);
			break;
		case DirectionManager.SOUND.S0193:
			BG_RIZ_CU(line3);
			break;
		case DirectionManager.SOUND.S0194:
			BG_CSH_CU(line3);
			break;
		case DirectionManager.SOUND.S0195:
			BG_KPR_CU(line3);
			break;
		case DirectionManager.SOUND.S0196:
			BG_KKZ_CU(line3);
			break;
		case DirectionManager.SOUND.S0197:
			BG_KGR_CU(line3);
			break;
		case DirectionManager.SOUND.S0198:
			BG_RIS_CU(line3);
			break;
		case DirectionManager.SOUND.S0200:
			JG_lose_02(line3);
			break;
		case DirectionManager.SOUND.S0201:
			JG_ZT_in(line3);
			break;
		case DirectionManager.SOUND.S0202:
			BG_IKG_sin(line2);
			break;
		case DirectionManager.SOUND.S0203:
			BG_IKG_sol(line2);
			break;
		case DirectionManager.SOUND.S0204:
			BG_IKG_sinsol(line2);
			break;
		case DirectionManager.SOUND.S0205:
			BG_IKG_diz(line2);
			break;
		case DirectionManager.SOUND.S0207:
			BG_BZT_ED_02(line2);
			break;
		case DirectionManager.SOUND.S0208:
			BG_BZT_ED_end(line2);
			break;
		case DirectionManager.SOUND.S0210:
			SE_common_kokuchi_01(line3);
			break;
		case DirectionManager.SOUND.S0211:
			SE_common_kokuchi_02(line3);
			break;
		case DirectionManager.SOUND.S0212:
			SE_common_kokuchi_03(line3);
			break;
		case DirectionManager.SOUND.S0213:
			SE_CMN_03(line3);
			break;
		case DirectionManager.SOUND.S0215:
			SE_common_kokuchi_05(line3);
			break;
		case DirectionManager.SOUND.S0217:
			SE_common_kokuchi_04(line3);
			break;
		case DirectionManager.SOUND.S0224:
			YK_add_10(line);
			break;
		case DirectionManager.SOUND.S0225:
			YK_add_20(line);
			break;
		case DirectionManager.SOUND.S0226:
			YK_add_30(line);
			break;
		case DirectionManager.SOUND.S0227:
			YK_add_50(line);
			break;
		case DirectionManager.SOUND.S0228:
			YK_add_100(line);
			break;
		case DirectionManager.SOUND.S0229:
			YK_add_150(line);
			break;
		case DirectionManager.SOUND.S0230:
			YK_add_200(line);
			break;
		case DirectionManager.SOUND.S0231:
			YK_add_300(line);
			break;
		case DirectionManager.SOUND.S0232:
			YK_add_7(line);
			break;
		case DirectionManager.SOUND.S0275:
			JG_add_BD(line3);
			YK_add_BD(line);
			break;
		case DirectionManager.SOUND.S0399:
			SE_common_kokuchi_06(line3);
			break;
		case DirectionManager.SOUND.S0400:
			SE_common_kokuchi_07(line3);
			break;
		case DirectionManager.SOUND.S0401:
			SE_common_kokuchi_09(line3);
			break;
		case DirectionManager.SOUND.S0402:
			SE_common_kokuchi_08(line3);
			break;
		case DirectionManager.SOUND.S0508:
			SE_CMN_01(line3);
			break;
		case DirectionManager.SOUND.S0510:
			SE_CMN_04(line3);
			break;
		case DirectionManager.SOUND.S0519:
			SE_CMN_02(line3);
			break;
		case DirectionManager.SOUND.S0660:
			SE_CMN_03(line3);
			break;
		}
	}

	public void setKoyakuLED(int _id)
	{
	}

	public static void demoLedStart()
	{
		reel_demo(changeLineNum(LEDPanelManager.LINE.LAYER_1M));
		DM_07(changeLineNum(LEDMainManager.LINE.DEMO));
	}

	public static void demoLedEnd()
	{
		OFF_16(changeLineNum(LEDMainManager.LINE.DEMO));
	}

	public static void directionLedReset_lever()
	{
		procedDate[changeLineNum(LEDPanelManager.LINE.LAYER_7M)] = 0;
		procedDate[changeLineNum(LEDPanelManager.LINE.LAYER_9M)] = 0;
	}

	public static void OFF_0(int _line)
	{
		if (procedDate[_line] != 1)
		{
			procedDate[_line] = 1;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void test_CGspot_01(int _line)
	{
		if (procedDate[_line] != 2)
		{
			procedDate[_line] = 2;
			init(_line);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void test_gekihen_cyan(int _line)
	{
		if (procedDate[_line] != 3)
		{
			procedDate[_line] = 3;
			init(_line);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void test_gekihen_green(int _line)
	{
		if (procedDate[_line] != 4)
		{
			procedDate[_line] = 4;
			init(_line);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void test_gekihen_orange(int _line)
	{
		if (procedDate[_line] != 5)
		{
			procedDate[_line] = 5;
			init(_line);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void test_gekihen_purple(int _line)
	{
		if (procedDate[_line] != 6)
		{
			procedDate[_line] = 6;
			init(_line);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void test_gekihen_red(int _line)
	{
		if (procedDate[_line] != 7)
		{
			procedDate[_line] = 7;
			init(_line);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void test_gekihen_backlight(int _line)
	{
		if (procedDate[_line] != 8)
		{
			procedDate[_line] = 8;
			init(_line);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void test_gekihen_backlight_100(int _line)
	{
		if (procedDate[_line] != 9)
		{
			procedDate[_line] = 9;
			init(_line);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void test_gekihen_cyan_3(int _line)
	{
		if (procedDate[_line] != 10)
		{
			procedDate[_line] = 10;
			init(_line);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void test_gekihen_red_3(int _line)
	{
		if (procedDate[_line] != 11)
		{
			procedDate[_line] = 11;
			init(_line);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void test_gekihen_backlight_100_3(int _line)
	{
		if (procedDate[_line] != 12)
		{
			procedDate[_line] = 12;
			init(_line);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void test_gekihen_backlight_3(int _line)
	{
		if (procedDate[_line] != 13)
		{
			procedDate[_line] = 13;
			init(_line);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void test_gekihen_fire_01(int _line)
	{
		if (procedDate[_line] != 14)
		{
			procedDate[_line] = 14;
			init(_line);
			setData(_line, 60, 2, 0);
			setData(_line, 60, 5, 0);
		}
	}

	public static void test_gekihen_fire_02(int _line)
	{
		if (procedDate[_line] != 15)
		{
			procedDate[_line] = 15;
			init(_line);
			setData(_line, 60, 2, 0);
			setData(_line, 60, 5, 0);
		}
	}

	public static void test_gekihen_fire_03(int _line)
	{
		if (procedDate[_line] != 16)
		{
			procedDate[_line] = 16;
			init(_line);
			setData(_line, 60, 2, 0);
			setData(_line, 60, 5, 0);
		}
	}

	public static void test_gekihen_fire_04(int _line)
	{
		if (procedDate[_line] != 17)
		{
			procedDate[_line] = 17;
			init(_line);
			setData(_line, 60, 2, 0);
			setData(_line, 60, 5, 0);
		}
	}

	public static void OFF_1(int _line)
	{
		if (procedDate[_line] != 18)
		{
			procedDate[_line] = 18;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void OFF_2(int _line)
	{
		if (procedDate[_line] != 19)
		{
			procedDate[_line] = 19;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void OFF_3(int _line)
	{
		if (procedDate[_line] != 20)
		{
			procedDate[_line] = 20;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void OFF_4(int _line)
	{
		if (procedDate[_line] != 21)
		{
			procedDate[_line] = 21;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void OFF_5(int _line)
	{
		if (procedDate[_line] != 22)
		{
			procedDate[_line] = 22;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void OFF_6(int _line)
	{
		if (procedDate[_line] != 23)
		{
			procedDate[_line] = 23;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void OFF_7(int _line)
	{
		if (procedDate[_line] != 24)
		{
			procedDate[_line] = 24;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void OFF_8(int _line)
	{
		if (procedDate[_line] != 25)
		{
			procedDate[_line] = 25;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void OFF_9(int _line)
	{
		if (procedDate[_line] != 26)
		{
			procedDate[_line] = 26;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void OFF_10(int _line)
	{
		if (procedDate[_line] != 27)
		{
			procedDate[_line] = 27;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void OFF_11(int _line)
	{
		if (procedDate[_line] != 28)
		{
			procedDate[_line] = 28;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void OFF_12(int _line)
	{
		if (procedDate[_line] != 29)
		{
			procedDate[_line] = 29;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void OFF_13(int _line)
	{
		if (procedDate[_line] != 30)
		{
			procedDate[_line] = 30;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void OFF_14(int _line)
	{
		if (procedDate[_line] != 31)
		{
			procedDate[_line] = 31;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void OFF_15(int _line)
	{
		if (procedDate[_line] != 32)
		{
			procedDate[_line] = 32;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void OFF_16(int _line)
	{
		if (procedDate[_line] != 33)
		{
			procedDate[_line] = 33;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DM_eco_01(int _line)
	{
		if (procedDate[_line] != 34)
		{
			procedDate[_line] = 34;
			init(_line);
			setData(_line, 0, 0, 31);
			setData(_line, 60, 2, 0);
			setData(_line, 60, 5, 0);
		}
	}

	public static void DM_eco_02(int _line)
	{
		if (procedDate[_line] != 35)
		{
			procedDate[_line] = 35;
			init(_line);
			setData(_line, 0, 0, 32);
			setData(_line, 363, 0, 33);
			setData(_line, 1046, 0, 34);
			setData(_line, 1562, 0, 35);
			setData(_line, 2190, 2, 0);
			setData(_line, 2190, 5, 0);
		}
	}

	public static void DM_01(int _line)
	{
		if (procedDate[_line] != 36)
		{
			procedDate[_line] = 36;
			init(_line);
			setData(_line, 0, 0, 18);
			setData(_line, 60, 2, 0);
			setData(_line, 60, 5, 0);
		}
	}

	public static void DM_02(int _line)
	{
		if (procedDate[_line] != 37)
		{
			procedDate[_line] = 37;
			init(_line);
			setData(_line, 0, 0, 19);
			setData(_line, 60, 2, 0);
			setData(_line, 60, 5, 0);
		}
	}

	public static void DM_03(int _line)
	{
		if (procedDate[_line] != 38)
		{
			procedDate[_line] = 38;
			init(_line);
			setData(_line, 0, 0, 20);
			setData(_line, 60, 2, 0);
			setData(_line, 60, 5, 0);
		}
	}

	public static void DM_04(int _line)
	{
		if (procedDate[_line] != 39)
		{
			procedDate[_line] = 39;
			init(_line);
			setData(_line, 0, 0, 21);
			setData(_line, 60, 2, 0);
			setData(_line, 60, 5, 0);
		}
	}

	public static void DM_05(int _line)
	{
		if (procedDate[_line] != 40)
		{
			procedDate[_line] = 40;
			init(_line);
			setData(_line, 0, 0, 22);
			setData(_line, 60, 2, 0);
			setData(_line, 60, 5, 0);
		}
	}

	public static void DM_06(int _line)
	{
		if (procedDate[_line] != 41)
		{
			procedDate[_line] = 41;
			init(_line);
			setData(_line, 0, 0, 23);
			setData(_line, 363, 0, 24);
			setData(_line, 1046, 0, 25);
			setData(_line, 1562, 0, 26);
			setData(_line, 2190, 2, 0);
			setData(_line, 2190, 5, 0);
		}
	}

	public static void DM_07(int _line)
	{
		if (procedDate[_line] != 42)
		{
			procedDate[_line] = 42;
			init(_line);
			setData(_line, 0, 0, 27);
			setData(_line, 363, 0, 28);
			setData(_line, 1046, 0, 29);
			setData(_line, 1562, 0, 30);
			setData(_line, 2190, 2, 0);
			setData(_line, 2190, 5, 0);
		}
	}

	public static void BG_NML(int _line)
	{
		if (procedDate[_line] != 43)
		{
			procedDate[_line] = 43;
			init(_line);
			setData(_line, 0, 0, 51);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void BG_CST(int _line)
	{
		if (procedDate[_line] != 44)
		{
			procedDate[_line] = 44;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void BG_JST(int _line)
	{
		if (procedDate[_line] != 45)
		{
			procedDate[_line] = 45;
			init(_line);
			setData(_line, 0, 0, 56);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void BG_KBS(int _line)
	{
		if (procedDate[_line] != 46)
		{
			procedDate[_line] = 46;
			init(_line);
			setData(_line, 0, 0, 59);
			setData(_line, 92, 2, 0);
			setData(_line, 92, 5, 0);
		}
	}

	public static void BG_DST(int _line)
	{
		if (procedDate[_line] != 47)
		{
			procedDate[_line] = 47;
			init(_line);
			setData(_line, 0, 0, 64);
			setData(_line, 93, 2, 0);
			setData(_line, 93, 5, 0);
		}
	}

	public static void BG_ACZ(int _line)
	{
		if (procedDate[_line] != 48)
		{
			procedDate[_line] = 48;
			init(_line);
			setData(_line, 0, 0, 74);
			setData(_line, 1652, 2, 0);
			setData(_line, 1652, 5, 0);
		}
	}

	public static void BG_ART_01(int _line)
	{
		if (procedDate[_line] != 49)
		{
			procedDate[_line] = 49;
			init(_line);
			setData(_line, 0, 3, 255);
			setData(_line, 0, 0, 75);
			setData(_line, 116, 0, 75);
			setData(_line, 232, 0, 76);
			setData(_line, 348, 0, 77);
			setData(_line, 464, 0, 77);
			setData(_line, 580, 0, 77);
			setData(_line, 696, 0, 77);
			setData(_line, 812, 0, 77);
			setData(_line, 928, 0, 77);
			setData(_line, 1044, 0, 78);
			setData(_line, 1160, 0, 77);
			setData(_line, 1276, 0, 78);
			setData(_line, 1392, 0, 77);
			setData(_line, 1508, 0, 77);
			setData(_line, 1624, 0, 77);
			setData(_line, 1740, 0, 77);
			setData(_line, 1856, 0, 77);
			setData(_line, 1972, 0, 77);
			setData(_line, 2030, 0, 79);
			setData(_line, 2146, 0, 79);
			setData(_line, 2262, 0, 77);
			setData(_line, 2378, 0, 77);
			setData(_line, 2494, 0, 77);
			setData(_line, 2610, 0, 77);
			setData(_line, 2726, 0, 78);
			setData(_line, 2842, 0, 77);
			setData(_line, 2958, 0, 78);
			setData(_line, 3074, 0, 77);
			setData(_line, 3190, 0, 77);
			setData(_line, 3306, 0, 77);
			setData(_line, 3422, 0, 77);
			setData(_line, 3538, 0, 77);
			setData(_line, 3654, 0, 77);
			setData(_line, 3712, 0, 79);
			setData(_line, 3828, 0, 79);
			setData(_line, 3944, 0, 79);
			setData(_line, 4060, 0, 79);
			setData(_line, 4176, 0, 79);
			setData(_line, 4292, 0, 77);
			setData(_line, 4408, 0, 77);
			setData(_line, 4524, 0, 77);
			setData(_line, 4640, 0, 77);
			setData(_line, 4756, 0, 77);
			setData(_line, 4843, 2, 0);
			setData(_line, 4843, 5, 0);
		}
	}

	public static void BG_ART_02(int _line)
	{
		if (procedDate[_line] != 50)
		{
			procedDate[_line] = 50;
			init(_line);
			setData(_line, 0, 3, 255);
			setData(_line, 0, 0, 80);
			setData(_line, 146, 0, 80);
			setData(_line, 292, 0, 81);
			setData(_line, 438, 0, 81);
			setData(_line, 584, 0, 81);
			setData(_line, 730, 0, 81);
			setData(_line, 876, 0, 193);
			setData(_line, 1022, 0, 193);
			setData(_line, 1168, 0, 193);
			setData(_line, 1314, 0, 193);
			setData(_line, 1460, 0, 193);
			setData(_line, 1606, 0, 193);
			setData(_line, 1752, 0, 194);
			setData(_line, 1898, 0, 194);
			setData(_line, 2044, 0, 194);
			setData(_line, 2190, 0, 194);
			setData(_line, 2336, 0, 194);
			setData(_line, 2409, 0, 80);
			setData(_line, 2555, 0, 80);
			setData(_line, 2701, 0, 80);
			setData(_line, 2847, 0, 80);
			setData(_line, 2993, 0, 193);
			setData(_line, 3139, 0, 193);
			setData(_line, 3285, 0, 193);
			setData(_line, 3431, 0, 193);
			setData(_line, 3577, 0, 193);
			setData(_line, 3723, 0, 193);
			setData(_line, 3869, 0, 194);
			setData(_line, 3942, 0, 81);
			setData(_line, 4088, 0, 81);
			setData(_line, 4234, 0, 81);
			setData(_line, 4380, 0, 81);
			setData(_line, 4526, 0, 80);
			setData(_line, 4672, 0, 80);
			setData(_line, 4818, 0, 80);
			setData(_line, 4964, 0, 80);
			setData(_line, 5110, 0, 195);
			setData(_line, 5116, 2, 0);
			setData(_line, 5116, 5, 0);
		}
	}

	public static void BG_ART_03(int _line)
	{
		if (procedDate[_line] != 51)
		{
			procedDate[_line] = 51;
			init(_line);
			setData(_line, 0, 3, 255);
			setData(_line, 0, 0, 120);
			setData(_line, 120, 0, 120);
			setData(_line, 240, 0, 120);
			setData(_line, 360, 0, 120);
			setData(_line, 480, 0, 120);
			setData(_line, 600, 0, 120);
			setData(_line, 720, 0, 121);
			setData(_line, 840, 0, 121);
			setData(_line, 960, 0, 121);
			setData(_line, 1080, 0, 121);
			setData(_line, 1200, 0, 121);
			setData(_line, 1320, 0, 121);
			setData(_line, 1440, 0, 121);
			setData(_line, 1560, 0, 122);
			setData(_line, 1680, 0, 121);
			setData(_line, 1800, 0, 121);
			setData(_line, 1920, 0, 121);
			setData(_line, 2040, 0, 122);
			setData(_line, 2160, 0, 120);
			setData(_line, 2280, 0, 120);
			setData(_line, 2400, 0, 120);
			setData(_line, 2520, 0, 120);
			setData(_line, 2640, 0, 121);
			setData(_line, 2760, 0, 121);
			setData(_line, 2880, 0, 121);
			setData(_line, 3000, 0, 121);
			setData(_line, 3120, 0, 121);
			setData(_line, 3240, 0, 121);
			setData(_line, 3360, 0, 121);
			setData(_line, 3480, 0, 122);
			setData(_line, 3600, 0, 121);
			setData(_line, 3720, 0, 121);
			setData(_line, 3840, 0, 121);
			setData(_line, 3960, 0, 122);
			setData(_line, 4080, 0, 123);
			setData(_line, 4200, 0, 121);
			setData(_line, 4320, 0, 121);
			setData(_line, 4440, 0, 121);
			setData(_line, 4560, 0, 121);
			setData(_line, 4680, 0, 120);
			setData(_line, 4800, 0, 120);
			setData(_line, 4920, 0, 120);
			setData(_line, 5040, 0, 120);
			setData(_line, 5160, 2, 0);
			setData(_line, 5160, 5, 0);
		}
	}

	public static void BG_ART_04(int _line)
	{
		if (procedDate[_line] != 52)
		{
			procedDate[_line] = 52;
			init(_line);
			setData(_line, 0, 3, 255);
			setData(_line, 0, 0, 124);
			setData(_line, 109, 0, 124);
			setData(_line, 218, 0, 124);
			setData(_line, 327, 0, 125);
			setData(_line, 436, 0, 126);
			setData(_line, 545, 0, 126);
			setData(_line, 654, 0, 127);
			setData(_line, 764, 0, 127);
			setData(_line, 874, 0, 127);
			setData(_line, 984, 0, 127);
			setData(_line, 1094, 0, 179);
			setData(_line, 1204, 0, 179);
			setData(_line, 1314, 0, 179);
			setData(_line, 1424, 0, 179);
			setData(_line, 1534, 0, 127);
			setData(_line, 1644, 0, 127);
			setData(_line, 1754, 0, 127);
			setData(_line, 1864, 0, 127);
			setData(_line, 1974, 0, 179);
			setData(_line, 2084, 0, 179);
			setData(_line, 2194, 0, 179);
			setData(_line, 2304, 0, 179);
			setData(_line, 2414, 0, 180);
			setData(_line, 2524, 0, 180);
			setData(_line, 2634, 0, 180);
			setData(_line, 2744, 0, 180);
			setData(_line, 2854, 0, 180);
			setData(_line, 2964, 0, 180);
			setData(_line, 3074, 0, 180);
			setData(_line, 3184, 0, 180);
			setData(_line, 3294, 0, 180);
			setData(_line, 3369, 0, 127);
			setData(_line, 3479, 0, 127);
			setData(_line, 3589, 0, 127);
			setData(_line, 3699, 0, 127);
			setData(_line, 3809, 0, 127);
			setData(_line, 3919, 0, 179);
			setData(_line, 4029, 0, 179);
			setData(_line, 4139, 0, 179);
			setData(_line, 4249, 0, 179);
			setData(_line, 4359, 0, 179);
			setData(_line, 4469, 0, 179);
			setData(_line, 4579, 0, 179);
			setData(_line, 4689, 0, 179);
			setData(_line, 4799, 0, 127);
			setData(_line, 4909, 0, 127);
			setData(_line, 5019, 0, 127);
			setData(_line, 5129, 0, 127);
			setData(_line, 5239, 0, 125);
			setData(_line, 5261, 2, 0);
			setData(_line, 5261, 5, 0);
		}
	}

	public static void BG_ART_05(int _line)
	{
		if (procedDate[_line] != 53)
		{
			procedDate[_line] = 53;
			init(_line);
			setData(_line, 0, 3, 255);
			setData(_line, 0, 0, 128);
			setData(_line, 114, 0, 128);
			setData(_line, 228, 0, 128);
			setData(_line, 342, 0, 128);
			setData(_line, 456, 0, 129);
			setData(_line, 570, 0, 129);
			setData(_line, 684, 0, 197);
			setData(_line, 736, 0, 181);
			setData(_line, 856, 0, 181);
			setData(_line, 976, 0, 181);
			setData(_line, 1096, 0, 181);
			setData(_line, 1216, 0, 181);
			setData(_line, 1336, 0, 181);
			setData(_line, 1456, 0, 181);
			setData(_line, 1576, 0, 181);
			setData(_line, 1661, 0, 197);
			setData(_line, 1713, 0, 212);
			setData(_line, 1827, 0, 212);
			setData(_line, 1941, 0, 212);
			setData(_line, 2055, 0, 213);
			setData(_line, 2169, 0, 182);
			setData(_line, 2283, 0, 182);
			setData(_line, 2397, 0, 182);
			setData(_line, 2511, 0, 182);
			setData(_line, 2625, 0, 183);
			setData(_line, 2739, 0, 183);
			setData(_line, 2853, 0, 183);
			setData(_line, 2967, 0, 183);
			setData(_line, 3081, 0, 212);
			setData(_line, 3195, 0, 212);
			setData(_line, 3309, 0, 212);
			setData(_line, 3423, 0, 212);
			setData(_line, 3537, 0, 197);
			setData(_line, 3589, 0, 181);
			setData(_line, 3709, 0, 181);
			setData(_line, 3829, 0, 181);
			setData(_line, 3949, 0, 181);
			setData(_line, 4059, 0, 197);
			setData(_line, 4111, 0, 182);
			setData(_line, 4225, 0, 182);
			setData(_line, 4339, 0, 182);
			setData(_line, 4453, 0, 182);
			setData(_line, 4567, 0, 128);
			setData(_line, 4681, 0, 128);
			setData(_line, 4795, 0, 128);
			setData(_line, 4909, 0, 128);
			setData(_line, 5023, 0, 214);
			setData(_line, 5028, 2, 0);
			setData(_line, 5028, 5, 0);
		}
	}

	public static void BG_ART_06(int _line)
	{
		if (procedDate[_line] != 54)
		{
			procedDate[_line] = 54;
			init(_line);
			setData(_line, 0, 3, 255);
			setData(_line, 0, 0, 130);
			setData(_line, 125, 0, 130);
			setData(_line, 250, 0, 130);
			setData(_line, 375, 0, 130);
			setData(_line, 500, 0, 130);
			setData(_line, 625, 0, 130);
			setData(_line, 750, 0, 131);
			setData(_line, 805, 0, 132);
			setData(_line, 930, 0, 132);
			setData(_line, 1055, 0, 132);
			setData(_line, 1180, 0, 132);
			setData(_line, 1305, 0, 210);
			setData(_line, 1430, 0, 210);
			setData(_line, 1555, 0, 210);
			setData(_line, 1680, 0, 210);
			setData(_line, 1805, 0, 132);
			setData(_line, 1930, 0, 132);
			setData(_line, 2055, 0, 132);
			setData(_line, 2180, 0, 132);
			setData(_line, 2305, 0, 130);
			setData(_line, 2430, 0, 130);
			setData(_line, 2555, 0, 130);
			setData(_line, 2680, 0, 130);
			setData(_line, 2791, 0, 131);
			setData(_line, 2846, 0, 132);
			setData(_line, 2971, 0, 132);
			setData(_line, 3096, 0, 132);
			setData(_line, 3221, 0, 132);
			setData(_line, 3346, 0, 210);
			setData(_line, 3471, 0, 210);
			setData(_line, 3596, 0, 210);
			setData(_line, 3721, 0, 210);
			setData(_line, 3846, 0, 132);
			setData(_line, 3971, 0, 132);
			setData(_line, 4096, 0, 132);
			setData(_line, 4221, 0, 132);
			setData(_line, 4346, 0, 211);
			setData(_line, 4471, 0, 211);
			setData(_line, 4596, 0, 130);
			setData(_line, 4721, 0, 130);
			setData(_line, 4846, 0, 130);
			setData(_line, 4971, 0, 130);
			setData(_line, 5096, 0, 130);
			setData(_line, 5221, 0, 130);
			setData(_line, 5346, 0, 133);
			setData(_line, 5469, 0, 133);
			setData(_line, 5592, 0, 133);
			setData(_line, 5715, 0, 133);
			setData(_line, 5838, 0, 130);
			setData(_line, 5963, 0, 130);
			setData(_line, 6088, 0, 130);
			setData(_line, 6213, 0, 130);
			setData(_line, 6338, 0, 131);
			setData(_line, 6393, 0, 130);
			setData(_line, 6518, 0, 130);
			setData(_line, 6643, 0, 130);
			setData(_line, 6768, 0, 130);
			setData(_line, 6893, 0, 133);
			setData(_line, 7016, 0, 133);
			setData(_line, 7139, 0, 133);
			setData(_line, 7262, 0, 133);
			setData(_line, 7385, 0, 132);
			setData(_line, 7510, 0, 132);
			setData(_line, 7635, 0, 132);
			setData(_line, 7760, 0, 134);
			setData(_line, 7882, 2, 0);
			setData(_line, 7882, 5, 0);
		}
	}

	public static void BG_ART_07(int _line)
	{
		if (procedDate[_line] != 55)
		{
			procedDate[_line] = 55;
			init(_line);
			setData(_line, 0, 3, 255);
			setData(_line, 0, 0, 152);
			setData(_line, 117, 0, 152);
			setData(_line, 234, 0, 152);
			setData(_line, 351, 0, 152);
			setData(_line, 468, 0, 153);
			setData(_line, 585, 0, 153);
			setData(_line, 702, 0, 153);
			setData(_line, 819, 0, 153);
			setData(_line, 936, 0, 154);
			setData(_line, 1053, 0, 154);
			setData(_line, 1170, 0, 154);
			setData(_line, 1287, 0, 154);
			setData(_line, 1404, 0, 154);
			setData(_line, 1521, 0, 154);
			setData(_line, 1638, 0, 154);
			setData(_line, 1755, 0, 154);
			setData(_line, 1872, 0, 184);
			setData(_line, 1989, 0, 184);
			setData(_line, 2106, 0, 184);
			setData(_line, 2223, 0, 184);
			setData(_line, 2340, 0, 185);
			setData(_line, 2457, 0, 185);
			setData(_line, 2574, 0, 185);
			setData(_line, 2691, 0, 185);
			setData(_line, 2808, 0, 153);
			setData(_line, 2925, 0, 153);
			setData(_line, 3042, 0, 154);
			setData(_line, 3159, 0, 154);
			setData(_line, 3276, 0, 154);
			setData(_line, 3393, 0, 154);
			setData(_line, 3510, 0, 154);
			setData(_line, 3627, 0, 154);
			setData(_line, 3744, 0, 154);
			setData(_line, 3861, 0, 154);
			setData(_line, 3978, 0, 184);
			setData(_line, 4095, 0, 184);
			setData(_line, 4212, 0, 184);
			setData(_line, 4329, 0, 184);
			setData(_line, 4446, 0, 185);
			setData(_line, 4563, 0, 185);
			setData(_line, 4680, 0, 185);
			setData(_line, 4797, 0, 185);
			setData(_line, 4914, 0, 152);
			setData(_line, 5031, 0, 152);
			setData(_line, 5148, 0, 152);
			setData(_line, 5265, 0, 152);
			setData(_line, 5382, 0, 154);
			setData(_line, 5499, 0, 154);
			setData(_line, 5616, 0, 154);
			setData(_line, 5733, 0, 154);
			setData(_line, 5850, 0, 154);
			setData(_line, 5967, 0, 184);
			setData(_line, 6084, 0, 184);
			setData(_line, 6201, 0, 184);
			setData(_line, 6318, 0, 153);
			setData(_line, 6435, 0, 184);
			setData(_line, 6552, 0, 184);
			setData(_line, 6669, 0, 184);
			setData(_line, 6786, 0, 184);
			setData(_line, 6903, 0, 153);
			setData(_line, 7020, 0, 153);
			setData(_line, 7137, 0, 153);
			setData(_line, 7254, 0, 153);
			setData(_line, 7371, 0, 185);
			setData(_line, 7488, 0, 152);
			setData(_line, 7549, 0, 154);
			setData(_line, 7666, 2, 0);
			setData(_line, 7666, 5, 0);
		}
	}

	public static void BG_ART_08(int _line)
	{
		if (procedDate[_line] != 56)
		{
			procedDate[_line] = 56;
			init(_line);
			setData(_line, 0, 3, 255);
			setData(_line, 0, 0, 155);
			setData(_line, 117, 0, 155);
			setData(_line, 234, 0, 155);
			setData(_line, 351, 0, 155);
			setData(_line, 468, 0, 155);
			setData(_line, 585, 0, 155);
			setData(_line, 702, 0, 155);
			setData(_line, 819, 0, 155);
			setData(_line, 932, 0, 156);
			setData(_line, 986, 0, 157);
			setData(_line, 1102, 0, 157);
			setData(_line, 1218, 0, 158);
			setData(_line, 1264, 0, 187);
			setData(_line, 1381, 0, 187);
			setData(_line, 1498, 0, 187);
			setData(_line, 1615, 0, 187);
			setData(_line, 1732, 0, 187);
			setData(_line, 1849, 0, 187);
			setData(_line, 1966, 0, 187);
			setData(_line, 2083, 0, 187);
			setData(_line, 2200, 0, 187);
			setData(_line, 2317, 0, 187);
			setData(_line, 2434, 0, 187);
			setData(_line, 2551, 0, 187);
			setData(_line, 2668, 0, 188);
			setData(_line, 2785, 0, 188);
			setData(_line, 2902, 0, 188);
			setData(_line, 3019, 0, 188);
			setData(_line, 3136, 0, 188);
			setData(_line, 3253, 0, 188);
			setData(_line, 3370, 0, 188);
			setData(_line, 3487, 0, 188);
			setData(_line, 3604, 0, 186);
			setData(_line, 3721, 0, 186);
			setData(_line, 3838, 0, 186);
			setData(_line, 3955, 0, 186);
			setData(_line, 4072, 0, 155);
			setData(_line, 4189, 0, 155);
			setData(_line, 4306, 0, 155);
			setData(_line, 4423, 0, 155);
			setData(_line, 4530, 0, 159);
			setData(_line, 4737, 0, 155);
			setData(_line, 4854, 0, 155);
			setData(_line, 4971, 0, 186);
			setData(_line, 5088, 0, 186);
			setData(_line, 5205, 0, 186);
			setData(_line, 5322, 0, 186);
			setData(_line, 5439, 0, 186);
			setData(_line, 5556, 0, 186);
			setData(_line, 5673, 0, 155);
			setData(_line, 5790, 0, 155);
			setData(_line, 5907, 0, 155);
			setData(_line, 6024, 0, 155);
			setData(_line, 6141, 0, 155);
			setData(_line, 6258, 0, 155);
			setData(_line, 6375, 0, 155);
			setData(_line, 6492, 0, 187);
			setData(_line, 6609, 0, 187);
			setData(_line, 6726, 0, 187);
			setData(_line, 6843, 0, 187);
			setData(_line, 6960, 0, 188);
			setData(_line, 7077, 0, 188);
			setData(_line, 7194, 0, 188);
			setData(_line, 7311, 0, 188);
			setData(_line, 7428, 0, 160);
			setData(_line, 7459, 2, 0);
			setData(_line, 7459, 5, 0);
		}
	}

	public static void BG_BZT(int _line)
	{
		if (procedDate[_line] != 57)
		{
			procedDate[_line] = 57;
			init(_line);
			setData(_line, 0, 3, 255);
			setData(_line, 0, 0, 198);
			setData(_line, 180, 0, 198);
			setData(_line, 360, 0, 199);
			setData(_line, 540, 0, 199);
			setData(_line, 720, 0, 199);
			setData(_line, 900, 0, 199);
			setData(_line, 1080, 0, 200);
			setData(_line, 1260, 0, 200);
			setData(_line, 1440, 0, 198);
			setData(_line, 1620, 0, 198);
			setData(_line, 1800, 0, 200);
			setData(_line, 1980, 0, 200);
			setData(_line, 2160, 0, 199);
			setData(_line, 2340, 0, 199);
			setData(_line, 2520, 2, 0);
			setData(_line, 2520, 5, 0);
		}
	}

	public static void BG_BZT_ED(int _line)
	{
		if (procedDate[_line] != 58)
		{
			procedDate[_line] = 58;
			init(_line);
			setData(_line, 0, 3, 255);
			setData(_line, 0, 0, 202);
			setData(_line, 180, 0, 202);
			setData(_line, 360, 0, 203);
			setData(_line, 540, 0, 203);
			setData(_line, 720, 0, 203);
			setData(_line, 900, 0, 203);
			setData(_line, 1080, 0, 204);
			setData(_line, 1260, 0, 204);
			setData(_line, 1440, 0, 204);
			setData(_line, 1620, 0, 204);
			setData(_line, 1800, 0, 204);
			setData(_line, 1980, 0, 204);
			setData(_line, 2160, 0, 203);
			setData(_line, 2340, 0, 203);
			setData(_line, 2520, 2, 0);
			setData(_line, 2520, 5, 0);
		}
	}

	public static void BG_BAO(int _line)
	{
		if (procedDate[_line] != 59)
		{
			procedDate[_line] = 59;
			init(_line);
			setData(_line, 0, 3, 255);
			setData(_line, 0, 0, 82);
			setData(_line, 935, 0, 83);
			setData(_line, 1185, 0, 84);
			setData(_line, 1311, 0, 85);
			setData(_line, 1437, 0, 86);
			setData(_line, 1687, 0, 86);
			setData(_line, 1937, 0, 86);
			setData(_line, 2187, 0, 86);
			setData(_line, 2438, 0, 86);
			setData(_line, 2688, 0, 86);
			setData(_line, 2938, 0, 86);
			setData(_line, 3188, 0, 86);
			setData(_line, 3439, 0, 86);
			setData(_line, 3689, 0, 86);
			setData(_line, 3939, 0, 86);
			setData(_line, 4189, 0, 86);
			setData(_line, 4440, 0, 86);
			setData(_line, 4690, 0, 86);
			setData(_line, 4940, 0, 86);
			setData(_line, 5190, 0, 86);
			setData(_line, 5441, 0, 86);
			setData(_line, 5691, 0, 86);
			setData(_line, 5941, 0, 86);
			setData(_line, 6191, 0, 86);
			setData(_line, 6442, 0, 86);
			setData(_line, 6692, 0, 86);
			setData(_line, 6942, 0, 86);
			setData(_line, 7192, 0, 86);
			setData(_line, 7318, 2, 0);
			setData(_line, 7318, 5, 0);
		}
	}

	public static void BG_BKS(int _line)
	{
		if (procedDate[_line] != 60)
		{
			procedDate[_line] = 60;
			init(_line);
			setData(_line, 0, 0, 88);
			setData(_line, 82, 0, 89);
			setData(_line, 242, 0, 90);
			setData(_line, 402, 0, 89);
			setData(_line, 562, 0, 90);
			setData(_line, 722, 0, 89);
			setData(_line, 882, 0, 90);
			setData(_line, 1042, 0, 89);
			setData(_line, 1202, 0, 90);
			setData(_line, 1362, 0, 89);
			setData(_line, 1522, 0, 90);
			setData(_line, 1682, 0, 89);
			setData(_line, 1842, 0, 90);
			setData(_line, 2002, 2, 0);
			setData(_line, 2002, 5, 0);
		}
	}

	public static void BG_BKS_end(int _line)
	{
		if (procedDate[_line] != 61)
		{
			procedDate[_line] = 61;
			init(_line);
			setData(_line, 0, 0, 91);
			setData(_line, 287, 3, 255);
			setData(_line, 287, 0, 92);
			setData(_line, 574, 2, 0);
			setData(_line, 574, 5, 0);
		}
	}

	public static void BG_BJT_01(int _line)
	{
		if (procedDate[_line] != 62)
		{
			procedDate[_line] = 62;
			init(_line);
			setData(_line, 0, 3, 255);
			setData(_line, 0, 0, 135);
			setData(_line, 164, 0, 136);
			setData(_line, 295, 0, 135);
			setData(_line, 459, 0, 135);
			setData(_line, 623, 0, 135);
			setData(_line, 720, 2, 0);
			setData(_line, 720, 5, 0);
		}
	}

	public static void BG_BJT_02(int _line)
	{
		if (procedDate[_line] != 63)
		{
			procedDate[_line] = 63;
			init(_line);
			setData(_line, 0, 3, 255);
			setData(_line, 0, 0, 137);
			setData(_line, 179, 0, 137);
			setData(_line, 358, 0, 137);
			setData(_line, 537, 0, 137);
			setData(_line, 547, 0, 138);
			setData(_line, 611, 0, 139);
			setData(_line, 799, 0, 139);
			setData(_line, 987, 0, 140);
			setData(_line, 1167, 0, 140);
			setData(_line, 1347, 0, 140);
			setData(_line, 1527, 0, 140);
			setData(_line, 1707, 0, 140);
			setData(_line, 1800, 2, 0);
			setData(_line, 1800, 5, 0);
		}
	}

	public static void BG_BM2_intro(int _line)
	{
		if (procedDate[_line] != 64)
		{
			procedDate[_line] = 64;
			init(_line);
			setData(_line, 0, 3, 255);
			setData(_line, 0, 0, 163);
			setData(_line, 148, 0, 163);
			setData(_line, 296, 0, 164);
			setData(_line, 443, 0, 164);
			setData(_line, 590, 0, 164);
			setData(_line, 737, 2, 0);
			setData(_line, 737, 5, 0);
		}
	}

	public static void BG_BM2_loop(int _line)
	{
		if (procedDate[_line] != 65)
		{
			procedDate[_line] = 65;
			init(_line);
			setData(_line, 0, 3, 255);
			setData(_line, 0, 0, 166);
			setData(_line, 147, 0, 166);
			setData(_line, 294, 0, 165);
			setData(_line, 441, 0, 165);
			setData(_line, 588, 0, 165);
			setData(_line, 735, 0, 166);
			setData(_line, 882, 0, 167);
			setData(_line, 1029, 0, 167);
			setData(_line, 1176, 0, 165);
			setData(_line, 1323, 0, 166);
			setData(_line, 1470, 0, 166);
			setData(_line, 1617, 0, 166);
			setData(_line, 1764, 2, 0);
			setData(_line, 1764, 5, 0);
		}
	}

	public static void BG_BM2_end(int _line)
	{
		if (procedDate[_line] != 66)
		{
			procedDate[_line] = 66;
			init(_line);
			setData(_line, 0, 0, 161);
			setData(_line, 287, 3, 255);
			setData(_line, 287, 0, 162);
			setData(_line, 348, 2, 0);
			setData(_line, 348, 5, 0);
		}
	}

	public static void BG_sisetsu1(int _line)
	{
		if (procedDate[_line] != 67)
		{
			procedDate[_line] = 67;
			init(_line);
			setData(_line, 0, 3, 255);
			setData(_line, 0, 0, 205);
			setData(_line, 133, 0, 205);
			setData(_line, 266, 0, 205);
			setData(_line, 399, 0, 205);
			setData(_line, 532, 0, 206);
			setData(_line, 599, 0, 207);
			setData(_line, 732, 0, 215);
			setData(_line, 865, 0, 208);
			setData(_line, 998, 0, 208);
			setData(_line, 1131, 0, 209);
			setData(_line, 1264, 0, 216);
			setData(_line, 1397, 0, 217);
			setData(_line, 1464, 0, 218);
			setData(_line, 1598, 0, 219);
			setData(_line, 1732, 0, 218);
			setData(_line, 1865, 0, 219);
			setData(_line, 1999, 0, 220);
			setData(_line, 2133, 0, 207);
			setData(_line, 2266, 0, 215);
			setData(_line, 2399, 0, 208);
			setData(_line, 2532, 0, 208);
			setData(_line, 2665, 0, 209);
			setData(_line, 2798, 0, 216);
			setData(_line, 2931, 0, 217);
			setData(_line, 2998, 0, 218);
			setData(_line, 3131, 0, 219);
			setData(_line, 3265, 0, 218);
			setData(_line, 3398, 0, 219);
			setData(_line, 3532, 0, 221);
			setData(_line, 3666, 0, 222);
			setData(_line, 3799, 0, 222);
			setData(_line, 3932, 0, 222);
			setData(_line, 4065, 0, 223);
			setData(_line, 4198, 0, 224);
			setData(_line, 4331, 0, 224);
			setData(_line, 4464, 0, 224);
			setData(_line, 4597, 0, 225);
			setData(_line, 4730, 0, 217);
			setData(_line, 4797, 0, 218);
			setData(_line, 4931, 0, 219);
			setData(_line, 5065, 0, 218);
			setData(_line, 5198, 0, 219);
			setData(_line, 5332, 0, 220);
			setData(_line, 5465, 2, 0);
			setData(_line, 5465, 5, 0);
		}
	}

	public static void BG_sisetsu2(int _line)
	{
		if (procedDate[_line] != 68)
		{
			procedDate[_line] = 68;
			init(_line);
			setData(_line, 0, 3, 255);
			setData(_line, 0, 0, 141);
			setData(_line, 236, 0, 142);
			setData(_line, 493, 0, 143);
			setData(_line, 550, 0, 144);
			setData(_line, 674, 0, 144);
			setData(_line, 798, 0, 144);
			setData(_line, 922, 0, 144);
			setData(_line, 1046, 0, 144);
			setData(_line, 1170, 0, 144);
			setData(_line, 1294, 0, 144);
			setData(_line, 1418, 0, 144);
			setData(_line, 1542, 0, 144);
			setData(_line, 1666, 0, 144);
			setData(_line, 1790, 0, 144);
			setData(_line, 1914, 0, 144);
			setData(_line, 2038, 0, 144);
			setData(_line, 2162, 0, 144);
			setData(_line, 2286, 0, 142);
			setData(_line, 2318, 0, 143);
			setData(_line, 2375, 0, 144);
			setData(_line, 2499, 0, 144);
			setData(_line, 2623, 0, 144);
			setData(_line, 2747, 0, 144);
			setData(_line, 2871, 0, 144);
			setData(_line, 2995, 0, 144);
			setData(_line, 3119, 0, 144);
			setData(_line, 3243, 0, 144);
			setData(_line, 3367, 0, 144);
			setData(_line, 3491, 0, 144);
			setData(_line, 3615, 0, 144);
			setData(_line, 3739, 0, 144);
			setData(_line, 3863, 0, 144);
			setData(_line, 3987, 0, 144);
			setData(_line, 4111, 0, 144);
			setData(_line, 4235, 0, 144);
			setData(_line, 4359, 0, 144);
			setData(_line, 4483, 0, 144);
			setData(_line, 4607, 0, 144);
			setData(_line, 4731, 0, 144);
			setData(_line, 4855, 0, 144);
			setData(_line, 4979, 0, 144);
			setData(_line, 5103, 0, 144);
			setData(_line, 5227, 0, 144);
			setData(_line, 5351, 0, 144);
			setData(_line, 5475, 0, 144);
			setData(_line, 5599, 0, 144);
			setData(_line, 5723, 0, 144);
			setData(_line, 5847, 0, 144);
			setData(_line, 5971, 0, 144);
			setData(_line, 6095, 0, 144);
			setData(_line, 6219, 0, 144);
			setData(_line, 6343, 0, 144);
			setData(_line, 6467, 0, 144);
			setData(_line, 6529, 2, 0);
			setData(_line, 6529, 5, 0);
		}
	}

	public static void BG_BGT(int _line)
	{
		if (procedDate[_line] != 69)
		{
			procedDate[_line] = 69;
			init(_line);
			setData(_line, 0, 0, 95);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void BG_BM1(int _line)
	{
		if (procedDate[_line] != 70)
		{
			procedDate[_line] = 70;
			init(_line);
			setData(_line, 0, 3, 255);
			setData(_line, 0, 0, 172);
			setData(_line, 158, 0, 172);
			setData(_line, 316, 0, 173);
			setData(_line, 419, 0, 174);
			setData(_line, 727, 0, 174);
			setData(_line, 1035, 0, 174);
			setData(_line, 1343, 0, 175);
			setData(_line, 1362, 0, 176);
			setData(_line, 1524, 0, 176);
			setData(_line, 1686, 0, 177);
			setData(_line, 1874, 0, 178);
			setData(_line, 2384, 0, 174);
			setData(_line, 2692, 0, 174);
			setData(_line, 3000, 0, 174);
			setData(_line, 3308, 0, 175);
			setData(_line, 3327, 0, 176);
			setData(_line, 3489, 0, 176);
			setData(_line, 3651, 0, 177);
			setData(_line, 3839, 0, 178);
			setData(_line, 4349, 0, 174);
			setData(_line, 4657, 0, 174);
			setData(_line, 4965, 0, 175);
			setData(_line, 4984, 0, 176);
			setData(_line, 5146, 0, 176);
			setData(_line, 5308, 0, 177);
			setData(_line, 5496, 0, 172);
			setData(_line, 5654, 0, 172);
			setData(_line, 5812, 0, 172);
			setData(_line, 5970, 2, 0);
			setData(_line, 5970, 5, 0);
		}
	}

	public static void BG_BM1_end(int _line)
	{
		if (procedDate[_line] != 71)
		{
			procedDate[_line] = 71;
			init(_line);
			setData(_line, 0, 0, 169);
			setData(_line, 167, 0, 170);
			setData(_line, 462, 3, 255);
			setData(_line, 462, 0, 171);
			setData(_line, 582, 2, 0);
			setData(_line, 582, 5, 0);
		}
	}

	public static void BG_KFR_DI_00(int _line)
	{
		if (procedDate[_line] != 72)
		{
			procedDate[_line] = 72;
			init(_line);
			setData(_line, 0, 0, 201);
			setData(_line, 60, 2, 0);
			setData(_line, 60, 5, 0);
		}
	}

	public static void BG_KFR_DI(int _line)
	{
		if (procedDate[_line] != 73)
		{
			procedDate[_line] = 73;
			init(_line);
			setData(_line, 0, 0, 196);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void BG_IKG_diz(int _line)
	{
		if (procedDate[_line] != 74)
		{
			procedDate[_line] = 74;
			init(_line);
			setData(_line, 0, 0, 189);
			setData(_line, 121, 2, 0);
			setData(_line, 121, 5, 0);
		}
	}

	public static void BG_IKG_diz_02(int _line)
	{
		if (procedDate[_line] != 75)
		{
			procedDate[_line] = 75;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 210, 0, 189);
			setData(_line, 331, 2, 0);
			setData(_line, 331, 5, 0);
		}
	}

	public static void BG_IKG_sin(int _line)
	{
		if (procedDate[_line] != 76)
		{
			procedDate[_line] = 76;
			init(_line);
			setData(_line, 0, 0, 190);
			setData(_line, 121, 2, 0);
			setData(_line, 121, 5, 0);
		}
	}

	public static void BG_IKG_sinsol(int _line)
	{
		if (procedDate[_line] != 77)
		{
			procedDate[_line] = 77;
			init(_line);
			setData(_line, 0, 0, 191);
			setData(_line, 121, 2, 0);
			setData(_line, 121, 5, 0);
		}
	}

	public static void BG_IKG_sol(int _line)
	{
		if (procedDate[_line] != 78)
		{
			procedDate[_line] = 78;
			init(_line);
			setData(_line, 0, 0, 192);
			setData(_line, 121, 2, 0);
			setData(_line, 121, 5, 0);
		}
	}

	public static void BG_MGO(int _line)
	{
		if (procedDate[_line] != 79)
		{
			procedDate[_line] = 79;
			init(_line);
			setData(_line, 0, 0, 60);
			setData(_line, 80, 2, 0);
			setData(_line, 80, 5, 0);
		}
	}

	public static void BG_RSH(int _line)
	{
		if (procedDate[_line] != 80)
		{
			procedDate[_line] = 80;
			init(_line);
			setData(_line, 0, 0, 61);
			setData(_line, 116, 2, 0);
			setData(_line, 116, 5, 0);
		}
	}

	public static void BG_CMB(int _line)
	{
		if (procedDate[_line] != 81)
		{
			procedDate[_line] = 81;
			init(_line);
			setData(_line, 0, 0, 62);
			setData(_line, 181, 2, 0);
			setData(_line, 181, 5, 0);
		}
	}

	public static void BG_KOG(int _line)
	{
		if (procedDate[_line] != 82)
		{
			procedDate[_line] = 82;
			init(_line);
			setData(_line, 0, 0, 63);
			setData(_line, 104, 2, 0);
			setData(_line, 104, 5, 0);
		}
	}

	public static void BG_HSL(int _line)
	{
		if (procedDate[_line] != 83)
		{
			procedDate[_line] = 83;
			init(_line);
			setData(_line, 0, 3, 255);
			setData(_line, 0, 0, 110);
			setData(_line, 120, 0, 110);
			setData(_line, 240, 0, 111);
			setData(_line, 360, 0, 110);
			setData(_line, 480, 0, 111);
			setData(_line, 600, 0, 110);
			setData(_line, 720, 0, 112);
			setData(_line, 840, 0, 112);
			setData(_line, 960, 0, 112);
			setData(_line, 1080, 0, 112);
			setData(_line, 1140, 0, 113);
			setData(_line, 1200, 0, 114);
			setData(_line, 1320, 0, 114);
			setData(_line, 1440, 0, 114);
			setData(_line, 1560, 0, 114);
			setData(_line, 1680, 0, 115);
			setData(_line, 1800, 0, 110);
			setData(_line, 1920, 0, 110);
			setData(_line, 2040, 0, 110);
			setData(_line, 2160, 0, 110);
			setData(_line, 2280, 2, 0);
			setData(_line, 2280, 5, 0);
		}
	}

	public static void BG_HCP(int _line)
	{
		if (procedDate[_line] != 84)
		{
			procedDate[_line] = 84;
			init(_line);
			setData(_line, 0, 3, 255);
			setData(_line, 0, 0, 100);
			setData(_line, 212, 0, 101);
			setData(_line, 481, 0, 102);
			setData(_line, 695, 0, 102);
			setData(_line, 909, 0, 102);
			setData(_line, 1123, 0, 102);
			setData(_line, 1337, 0, 103);
			setData(_line, 1549, 0, 103);
			setData(_line, 1761, 0, 103);
			setData(_line, 1973, 0, 103);
			setData(_line, 2185, 0, 104);
			setData(_line, 2397, 0, 104);
			setData(_line, 2609, 2, 0);
			setData(_line, 2609, 5, 0);
		}
	}

	public static void BG_HML(int _line)
	{
		if (procedDate[_line] != 85)
		{
			procedDate[_line] = 85;
			init(_line);
			setData(_line, 0, 3, 255);
			setData(_line, 0, 0, 105);
			setData(_line, 220, 0, 106);
			setData(_line, 440, 0, 107);
			setData(_line, 551, 0, 108);
			setData(_line, 662, 0, 108);
			setData(_line, 773, 0, 108);
			setData(_line, 884, 0, 109);
			setData(_line, 996, 0, 108);
			setData(_line, 1107, 0, 108);
			setData(_line, 1218, 0, 108);
			setData(_line, 1329, 0, 108);
			setData(_line, 1440, 0, 106);
			setData(_line, 1660, 0, 108);
			setData(_line, 1771, 0, 108);
			setData(_line, 1882, 0, 108);
			setData(_line, 1993, 0, 108);
			setData(_line, 2104, 0, 108);
			setData(_line, 2215, 0, 108);
			setData(_line, 2326, 0, 108);
			setData(_line, 2437, 0, 108);
			setData(_line, 2548, 0, 108);
			setData(_line, 2659, 0, 108);
			setData(_line, 2770, 2, 0);
			setData(_line, 2770, 5, 0);
		}
	}

	public static void BG_HBJ(int _line)
	{
		if (procedDate[_line] != 86)
		{
			procedDate[_line] = 86;
			init(_line);
			setData(_line, 0, 3, 255);
			setData(_line, 0, 0, 96);
			setData(_line, 356, 0, 97);
			setData(_line, 534, 0, 97);
			setData(_line, 712, 0, 98);
			setData(_line, 890, 0, 98);
			setData(_line, 1068, 0, 99);
			setData(_line, 1246, 0, 99);
			setData(_line, 1424, 0, 99);
			setData(_line, 1602, 0, 99);
			setData(_line, 1780, 0, 96);
			setData(_line, 2136, 2, 0);
			setData(_line, 2136, 5, 0);
		}
	}

	public static void BG_HZP(int _line)
	{
		if (procedDate[_line] != 87)
		{
			procedDate[_line] = 87;
			init(_line);
			setData(_line, 0, 3, 255);
			setData(_line, 0, 0, 116);
			setData(_line, 198, 0, 116);
			setData(_line, 396, 0, 116);
			setData(_line, 594, 0, 116);
			setData(_line, 792, 0, 117);
			setData(_line, 990, 0, 117);
			setData(_line, 1188, 0, 118);
			setData(_line, 1386, 0, 118);
			setData(_line, 1584, 0, 118);
			setData(_line, 1634, 0, 119);
			setData(_line, 1832, 0, 119);
			setData(_line, 2030, 2, 0);
			setData(_line, 2030, 5, 0);
		}
	}

	public static void BG_BZT_end(int _line)
	{
		if (procedDate[_line] != 88)
		{
			procedDate[_line] = 88;
			init(_line);
			setData(_line, 0, 0, 226);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 227);
			setData(_line, 60, 2, 0);
			setData(_line, 60, 5, 0);
		}
	}

	public static void BG_BZT_ED_02(int _line)
	{
		if (procedDate[_line] != 89)
		{
			procedDate[_line] = 89;
			init(_line);
			setData(_line, 0, 0, 230);
			setData(_line, 170, 2, 0);
			setData(_line, 170, 5, 0);
		}
	}

	public static void BG_BZT_ED_end(int _line)
	{
		if (procedDate[_line] != 90)
		{
			procedDate[_line] = 90;
			init(_line);
			setData(_line, 0, 0, 228);
			setData(_line, 144, 3, 255);
			setData(_line, 144, 0, 229);
			setData(_line, 264, 2, 0);
			setData(_line, 264, 5, 0);
		}
	}

	public static void BG_GB_end(int _line)
	{
		if (procedDate[_line] != 91)
		{
			procedDate[_line] = 91;
			init(_line);
			setData(_line, 0, 0, 231);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 232);
			setData(_line, 60, 2, 0);
			setData(_line, 60, 5, 0);
		}
	}

	public static void BG_MJM(int _line)
	{
		if (procedDate[_line] != 92)
		{
			procedDate[_line] = 92;
			init(_line);
			setData(_line, 0, 0, 46);
			setData(_line, 115, 2, 0);
			setData(_line, 115, 5, 0);
		}
	}

	public static void BG_MTH(int _line)
	{
		if (procedDate[_line] != 93)
		{
			procedDate[_line] = 93;
			init(_line);
			setData(_line, 0, 0, 47);
			setData(_line, 100, 2, 0);
			setData(_line, 100, 5, 0);
		}
	}

	public static void BG_RIZ(int _line)
	{
		if (procedDate[_line] != 94)
		{
			procedDate[_line] = 94;
			init(_line);
			setData(_line, 0, 0, 48);
			setData(_line, 116, 2, 0);
			setData(_line, 116, 5, 0);
		}
	}

	public static void BG_RIS(int _line)
	{
		if (procedDate[_line] != 95)
		{
			procedDate[_line] = 95;
			init(_line);
			setData(_line, 0, 0, 49);
			setData(_line, 240, 2, 0);
			setData(_line, 240, 5, 0);
		}
	}

	public static void BG_CSH(int _line)
	{
		if (procedDate[_line] != 96)
		{
			procedDate[_line] = 96;
			init(_line);
			setData(_line, 0, 0, 50);
			setData(_line, 109, 2, 0);
			setData(_line, 109, 5, 0);
		}
	}

	public static void BG_MAP(int _line)
	{
		if (procedDate[_line] != 97)
		{
			procedDate[_line] = 97;
			init(_line);
			setData(_line, 0, 0, 53);
			setData(_line, 142, 2, 0);
			setData(_line, 142, 5, 0);
		}
	}

	public static void BG_KPR(int _line)
	{
		if (procedDate[_line] != 98)
		{
			procedDate[_line] = 98;
			init(_line);
			setData(_line, 0, 0, 54);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void BG_KKZ(int _line)
	{
		if (procedDate[_line] != 99)
		{
			procedDate[_line] = 99;
			init(_line);
			setData(_line, 0, 0, 55);
			setData(_line, 102, 2, 0);
			setData(_line, 102, 5, 0);
		}
	}

	public static void BG_KGR(int _line)
	{
		if (procedDate[_line] != 100)
		{
			procedDate[_line] = 100;
			init(_line);
			setData(_line, 0, 0, 57);
			setData(_line, 158, 3, 255);
			setData(_line, 158, 0, 58);
			setData(_line, 310, 2, 0);
			setData(_line, 310, 5, 0);
		}
	}

	public static void BG_KBU(int _line)
	{
		if (procedDate[_line] != 101)
		{
			procedDate[_line] = 101;
			init(_line);
			setData(_line, 0, 0, 87);
			setData(_line, 110, 2, 0);
			setData(_line, 110, 5, 0);
		}
	}

	public static void BG_PRC(int _line)
	{
		if (procedDate[_line] != 102)
		{
			procedDate[_line] = 102;
			init(_line);
			setData(_line, 0, 3, 255);
			setData(_line, 0, 0, 145);
			setData(_line, 196, 0, 145);
			setData(_line, 392, 0, 146);
			setData(_line, 440, 0, 147);
			setData(_line, 710, 0, 148);
			setData(_line, 828, 2, 0);
			setData(_line, 828, 5, 0);
		}
	}

	public static void BG_PRC_end(int _line)
	{
		if (procedDate[_line] != 103)
		{
			procedDate[_line] = 103;
			init(_line);
			setData(_line, 0, 0, 150);
			setData(_line, 158, 3, 255);
			setData(_line, 158, 0, 151);
			setData(_line, 316, 2, 0);
			setData(_line, 316, 5, 0);
		}
	}

	public static void BG_SIN_rev(int _line)
	{
		if (procedDate[_line] != 104)
		{
			procedDate[_line] = 104;
			init(_line);
			setData(_line, 0, 0, 93);
			setData(_line, 668, 2, 0);
			setData(_line, 668, 5, 0);
		}
	}

	public static void BG_SOL_rev(int _line)
	{
		if (procedDate[_line] != 105)
		{
			procedDate[_line] = 105;
			init(_line);
			setData(_line, 0, 0, 94);
			setData(_line, 707, 2, 0);
			setData(_line, 707, 5, 0);
		}
	}

	public static void BG_MTH_CU(int _line)
	{
		if (procedDate[_line] != 106)
		{
			procedDate[_line] = 106;
			init(_line);
			setData(_line, 0, 0, 69);
			setData(_line, 100, 2, 0);
			setData(_line, 100, 5, 0);
		}
	}

	public static void BG_RIZ_CU(int _line)
	{
		if (procedDate[_line] != 107)
		{
			procedDate[_line] = 107;
			init(_line);
			setData(_line, 0, 0, 71);
			setData(_line, 116, 2, 0);
			setData(_line, 116, 5, 0);
		}
	}

	public static void BG_RIS_CU(int _line)
	{
		if (procedDate[_line] != 108)
		{
			procedDate[_line] = 108;
			init(_line);
			setData(_line, 0, 0, 70);
			setData(_line, 240, 2, 0);
			setData(_line, 240, 5, 0);
		}
	}

	public static void BG_CSH_CU(int _line)
	{
		if (procedDate[_line] != 109)
		{
			procedDate[_line] = 109;
			init(_line);
			setData(_line, 0, 0, 65);
			setData(_line, 109, 2, 0);
			setData(_line, 109, 5, 0);
		}
	}

	public static void BG_KPR_CU(int _line)
	{
		if (procedDate[_line] != 110)
		{
			procedDate[_line] = 110;
			init(_line);
			setData(_line, 0, 0, 68);
			setData(_line, 122, 2, 0);
			setData(_line, 122, 5, 0);
		}
	}

	public static void BG_KKZ_CU(int _line)
	{
		if (procedDate[_line] != 111)
		{
			procedDate[_line] = 111;
			init(_line);
			setData(_line, 0, 0, 67);
			setData(_line, 136, 2, 0);
			setData(_line, 136, 5, 0);
		}
	}

	public static void BG_KGR_CU(int _line)
	{
		if (procedDate[_line] != 112)
		{
			procedDate[_line] = 112;
			init(_line);
			setData(_line, 0, 0, 66);
			setData(_line, 152, 2, 0);
			setData(_line, 152, 5, 0);
		}
	}

	public static void JG_ISS_02(int _line)
	{
		if (procedDate[_line] != 113)
		{
			procedDate[_line] = 113;
			init(_line);
			setData(_line, 0, 0, 546);
			setData(_line, 110, 3, 255);
			setData(_line, 110, 0, 547);
			setData(_line, 128, 2, 0);
			setData(_line, 128, 5, 0);
		}
	}

	public static void JG_KBS_in(int _line)
	{
		if (procedDate[_line] != 114)
		{
			procedDate[_line] = 114;
			init(_line);
			setData(_line, 0, 0, 548);
			setData(_line, 120, 3, 255);
			setData(_line, 120, 0, 549);
			setData(_line, 240, 2, 0);
			setData(_line, 240, 5, 0);
		}
	}

	public static void JG_KBS_decide(int _line)
	{
		if (procedDate[_line] != 115)
		{
			procedDate[_line] = 115;
			init(_line);
			setData(_line, 0, 0, 550);
			setData(_line, 56, 3, 255);
			setData(_line, 56, 0, 551);
			setData(_line, 57, 2, 0);
			setData(_line, 57, 5, 0);
		}
	}

	public static void JG_IDI(int _line)
	{
		if (procedDate[_line] != 116)
		{
			procedDate[_line] = 116;
			init(_line);
			setData(_line, 0, 0, 556);
			setData(_line, 223, 3, 255);
			setData(_line, 223, 0, 557);
			setData(_line, 224, 2, 0);
			setData(_line, 224, 5, 0);
		}
	}

	public static void JG_IHH(int _line)
	{
		if (procedDate[_line] != 117)
		{
			procedDate[_line] = 117;
			init(_line);
			setData(_line, 0, 0, 558);
			setData(_line, 54, 3, 255);
			setData(_line, 54, 0, 559);
			setData(_line, 55, 2, 0);
			setData(_line, 55, 5, 0);
		}
	}

	public static void JG_VS(int _line)
	{
		if (procedDate[_line] != 118)
		{
			procedDate[_line] = 118;
			init(_line);
			setData(_line, 0, 0, 578);
			setData(_line, 180, 3, 255);
			setData(_line, 180, 0, 579);
			setData(_line, 300, 2, 0);
			setData(_line, 300, 5, 0);
		}
	}

	public static void JG_IJS(int _line)
	{
		if (procedDate[_line] != 119)
		{
			procedDate[_line] = 119;
			init(_line);
			setData(_line, 0, 0, 544);
			setData(_line, 165, 3, 255);
			setData(_line, 165, 0, 545);
			setData(_line, 166, 2, 0);
			setData(_line, 166, 5, 0);
		}
	}

	public static void JG_HOH_herecomes_01(int _line)
	{
		if (procedDate[_line] != 120)
		{
			procedDate[_line] = 120;
			init(_line);
			setData(_line, 0, 0, 731);
			setData(_line, 21, 3, 255);
			setData(_line, 21, 0, 732);
			setData(_line, 22, 2, 0);
			setData(_line, 22, 5, 0);
		}
	}

	public static void JG_HOH_herecomes_02(int _line)
	{
		if (procedDate[_line] != 121)
		{
			procedDate[_line] = 121;
			init(_line);
			setData(_line, 25, 0, 731);
			setData(_line, 46, 3, 255);
			setData(_line, 46, 0, 732);
			setData(_line, 47, 2, 0);
			setData(_line, 47, 5, 0);
		}
	}

	public static void JG_HOH_herecomes_03(int _line)
	{
		if (procedDate[_line] != 122)
		{
			procedDate[_line] = 122;
			init(_line);
			setData(_line, 10, 0, 731);
			setData(_line, 31, 3, 255);
			setData(_line, 31, 0, 732);
			setData(_line, 32, 2, 0);
			setData(_line, 32, 5, 0);
		}
	}

	public static void JG_SGB_in_01(int _line)
	{
		if (procedDate[_line] != 123)
		{
			procedDate[_line] = 123;
			init(_line);
			setData(_line, 0, 0, 659);
			setData(_line, 86, 3, 255);
			setData(_line, 86, 0, 660);
			setData(_line, 206, 2, 0);
			setData(_line, 206, 5, 0);
		}
	}

	public static void JG_SGB_in_02(int _line)
	{
		if (procedDate[_line] != 124)
		{
			procedDate[_line] = 124;
			init(_line);
			setData(_line, 5, 0, 659);
			setData(_line, 91, 3, 255);
			setData(_line, 91, 0, 660);
			setData(_line, 211, 2, 0);
			setData(_line, 211, 5, 0);
		}
	}

	public static void JG_GB_in_01(int _line)
	{
		if (procedDate[_line] != 125)
		{
			procedDate[_line] = 125;
			init(_line);
			setData(_line, 0, 0, 659);
			setData(_line, 86, 3, 255);
			setData(_line, 86, 0, 660);
			setData(_line, 206, 2, 0);
			setData(_line, 206, 5, 0);
		}
	}

	public static void JG_GB_in_02(int _line)
	{
		if (procedDate[_line] != 126)
		{
			procedDate[_line] = 126;
			init(_line);
			setData(_line, 5, 0, 659);
			setData(_line, 91, 3, 255);
			setData(_line, 91, 0, 660);
			setData(_line, 211, 2, 0);
			setData(_line, 211, 5, 0);
		}
	}

	public static void JG_RB_in(int _line)
	{
		if (procedDate[_line] != 127)
		{
			procedDate[_line] = 127;
			init(_line);
			setData(_line, 0, 0, 661);
			setData(_line, 74, 3, 255);
			setData(_line, 74, 0, 662);
			setData(_line, 194, 2, 0);
			setData(_line, 194, 5, 0);
		}
	}

	public static void JG_win_sin(int _line)
	{
		if (procedDate[_line] != 128)
		{
			procedDate[_line] = 128;
			init(_line);
			setData(_line, 0, 0, 521);
			setData(_line, 130, 3, 255);
			setData(_line, 130, 0, 522);
			setData(_line, 160, 2, 0);
			setData(_line, 160, 5, 0);
		}
	}

	public static void JG_win_sol(int _line)
	{
		if (procedDate[_line] != 129)
		{
			procedDate[_line] = 129;
			init(_line);
			setData(_line, 0, 0, 523);
			setData(_line, 120, 3, 255);
			setData(_line, 120, 0, 524);
			setData(_line, 150, 2, 0);
			setData(_line, 150, 5, 0);
		}
	}

	public static void JG_lose(int _line)
	{
		if (procedDate[_line] != 130)
		{
			procedDate[_line] = 130;
			init(_line);
			setData(_line, 0, 0, 528);
			setData(_line, 120, 3, 255);
			setData(_line, 120, 0, 530);
			setData(_line, 121, 2, 0);
			setData(_line, 121, 5, 0);
		}
	}

	public static void JG_lose_02(int _line)
	{
		if (procedDate[_line] != 131)
		{
			procedDate[_line] = 131;
			init(_line);
			setData(_line, 0, 0, 671);
			setData(_line, 120, 3, 255);
			setData(_line, 120, 0, 672);
			setData(_line, 121, 2, 0);
			setData(_line, 121, 5, 0);
		}
	}

	public static void JG_stage_change(int _line)
	{
		if (procedDate[_line] != 132)
		{
			procedDate[_line] = 132;
			init(_line);
			setData(_line, 0, 0, 537);
			setData(_line, 90, 4, 0);
			setData(_line, 90, 5, 0);
		}
	}

	public static void JG_KBU_decide(int _line)
	{
		if (procedDate[_line] != 133)
		{
			procedDate[_line] = 133;
			init(_line);
			setData(_line, 0, 0, 552);
			setData(_line, 63, 3, 255);
			setData(_line, 63, 0, 553);
			setData(_line, 64, 2, 0);
			setData(_line, 64, 5, 0);
		}
	}

	public static void JG_hattenn_hanyou1(int _line)
	{
		if (procedDate[_line] != 134)
		{
			procedDate[_line] = 134;
			init(_line);
			setData(_line, 0, 0, 525);
			setData(_line, 86, 3, 255);
			setData(_line, 86, 0, 529);
			setData(_line, 87, 2, 0);
			setData(_line, 87, 5, 0);
		}
	}

	public static void JG_hattenn_hanyou2(int _line)
	{
		if (procedDate[_line] != 135)
		{
			procedDate[_line] = 135;
			init(_line);
			setData(_line, 0, 0, 526);
			setData(_line, 134, 3, 255);
			setData(_line, 134, 0, 708);
			setData(_line, 135, 2, 0);
			setData(_line, 135, 5, 0);
		}
	}

	public static void JG_hattenn_hanyou3(int _line)
	{
		if (procedDate[_line] != 136)
		{
			procedDate[_line] = 136;
			init(_line);
			setData(_line, 0, 0, 527);
			setData(_line, 53, 3, 255);
			setData(_line, 53, 0, 529);
			setData(_line, 54, 2, 0);
			setData(_line, 54, 5, 0);
		}
	}

	public static void JG_YJD(int _line)
	{
		if (procedDate[_line] != 137)
		{
			procedDate[_line] = 137;
			init(_line);
			setData(_line, 0, 0, 560);
			setData(_line, 84, 3, 255);
			setData(_line, 84, 0, 561);
			setData(_line, 85, 2, 0);
			setData(_line, 85, 5, 0);
		}
	}

	public static void JG_PRC_end(int _line)
	{
		if (procedDate[_line] != 138)
		{
			procedDate[_line] = 138;
			init(_line);
			setData(_line, 0, 0, 570);
			setData(_line, 112, 3, 255);
			setData(_line, 112, 0, 571);
			setData(_line, 232, 2, 0);
			setData(_line, 232, 5, 0);
		}
	}

	public static void JG_SL_in(int _line)
	{
		if (procedDate[_line] != 139)
		{
			procedDate[_line] = 139;
			init(_line);
			setData(_line, 0, 0, 574);
			setData(_line, 55, 3, 255);
			setData(_line, 55, 0, 575);
			setData(_line, 56, 2, 0);
			setData(_line, 56, 5, 0);
		}
	}

	public static void JG_CP_in(int _line)
	{
		if (procedDate[_line] != 140)
		{
			procedDate[_line] = 140;
			init(_line);
			setData(_line, 0, 0, 554);
			setData(_line, 56, 3, 255);
			setData(_line, 56, 0, 555);
			setData(_line, 57, 2, 0);
			setData(_line, 57, 5, 0);
		}
	}

	public static void JG_ML_in(int _line)
	{
		if (procedDate[_line] != 141)
		{
			procedDate[_line] = 141;
			init(_line);
			setData(_line, 0, 0, 572);
			setData(_line, 53, 3, 255);
			setData(_line, 53, 0, 573);
			setData(_line, 54, 2, 0);
			setData(_line, 54, 5, 0);
		}
	}

	public static void JG_BJ_in(int _line)
	{
		if (procedDate[_line] != 142)
		{
			procedDate[_line] = 142;
			init(_line);
			setData(_line, 0, 0, 540);
			setData(_line, 55, 3, 255);
			setData(_line, 55, 0, 541);
			setData(_line, 56, 2, 0);
			setData(_line, 56, 5, 0);
		}
	}

	public static void JG_ZP_in(int _line)
	{
		if (procedDate[_line] != 143)
		{
			procedDate[_line] = 143;
			init(_line);
			setData(_line, 0, 0, 580);
			setData(_line, 53, 3, 255);
			setData(_line, 53, 0, 581);
			setData(_line, 54, 2, 0);
			setData(_line, 54, 5, 0);
		}
	}

	public static void JG_AO_in(int _line)
	{
		if (procedDate[_line] != 144)
		{
			procedDate[_line] = 144;
			init(_line);
			setData(_line, 0, 0, 538);
			setData(_line, 103, 3, 255);
			setData(_line, 103, 0, 539);
			setData(_line, 223, 2, 0);
			setData(_line, 223, 5, 0);
		}
	}

	public static void JG_KY_in(int _line)
	{
		if (procedDate[_line] != 145)
		{
			procedDate[_line] = 145;
			init(_line);
			setData(_line, 0, 0, 542);
			setData(_line, 118, 3, 255);
			setData(_line, 118, 0, 543);
			setData(_line, 238, 2, 0);
			setData(_line, 238, 5, 0);
		}
	}

	public static void JG_SO_in(int _line)
	{
		if (procedDate[_line] != 146)
		{
			procedDate[_line] = 146;
			init(_line);
			setData(_line, 0, 0, 576);
			setData(_line, 120, 3, 255);
			setData(_line, 120, 0, 577);
			setData(_line, 121, 2, 0);
			setData(_line, 121, 5, 0);
		}
	}

	public static void JG_ZT_in(int _line)
	{
		if (procedDate[_line] != 147)
		{
			procedDate[_line] = 147;
			init(_line);
			setData(_line, 0, 0, 761);
			setData(_line, 106, 3, 255);
			setData(_line, 106, 0, 762);
			setData(_line, 107, 2, 0);
			setData(_line, 107, 5, 0);
		}
	}

	public static void JG_R_hattenn(int _line)
	{
		if (procedDate[_line] != 148)
		{
			procedDate[_line] = 148;
			init(_line);
			setData(_line, 0, 0, 535);
			setData(_line, 65, 3, 255);
			setData(_line, 65, 0, 536);
			setData(_line, 66, 2, 0);
			setData(_line, 66, 5, 0);
		}
	}

	public static void JG_M_hattenn(int _line)
	{
		if (procedDate[_line] != 149)
		{
			procedDate[_line] = 149;
			init(_line);
			setData(_line, 0, 0, 531);
			setData(_line, 50, 3, 255);
			setData(_line, 50, 0, 532);
			setData(_line, 51, 2, 0);
			setData(_line, 51, 5, 0);
		}
	}

	public static void JG_C_hattenn(int _line)
	{
		if (procedDate[_line] != 150)
		{
			procedDate[_line] = 150;
			init(_line);
			setData(_line, 0, 0, 533);
			setData(_line, 60, 3, 255);
			setData(_line, 60, 0, 534);
			setData(_line, 61, 2, 0);
			setData(_line, 61, 5, 0);
		}
	}

	public static void SE_CMN_01(int _line)
	{
		if (procedDate[_line] != 151)
		{
			procedDate[_line] = 151;
			init(_line);
			setData(_line, 0, 0, 633);
			setData(_line, 90, 3, 255);
			setData(_line, 90, 0, 636);
			setData(_line, 91, 2, 0);
			setData(_line, 91, 5, 0);
		}
	}

	public static void SE_CMN_02(int _line)
	{
		if (procedDate[_line] != 152)
		{
			procedDate[_line] = 152;
			init(_line);
			setData(_line, 0, 0, 634);
			setData(_line, 47, 3, 255);
			setData(_line, 47, 0, 637);
			setData(_line, 48, 2, 0);
			setData(_line, 48, 5, 0);
		}
	}

	public static void SE_CMN_03(int _line)
	{
		if (procedDate[_line] != 153)
		{
			procedDate[_line] = 153;
			init(_line);
			setData(_line, 0, 0, 635);
			setData(_line, 22, 3, 255);
			setData(_line, 22, 0, 638);
			setData(_line, 23, 2, 0);
			setData(_line, 23, 5, 0);
		}
	}

	public static void SE_CMN_04(int _line)
	{
		if (procedDate[_line] != 154)
		{
			procedDate[_line] = 154;
			init(_line);
			setData(_line, 0, 0, 694);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 695);
			setData(_line, 31, 2, 0);
			setData(_line, 31, 5, 0);
		}
	}

	public static void JG_IKG_start(int _line)
	{
		if (procedDate[_line] != 155)
		{
			procedDate[_line] = 155;
			init(_line);
			setData(_line, 0, 0, 639);
			setData(_line, 105, 4, 0);
			setData(_line, 105, 5, 0);
		}
	}

	public static void JG_KCI_SU_sol(int _line)
	{
		if (procedDate[_line] != 156)
		{
			procedDate[_line] = 156;
			init(_line);
			setData(_line, 0, 0, 594);
			setData(_line, 62, 4, 0);
			setData(_line, 62, 5, 0);
		}
	}

	public static void JG_KCI_SU_sin(int _line)
	{
		if (procedDate[_line] != 157)
		{
			procedDate[_line] = 157;
			init(_line);
			setData(_line, 0, 0, 593);
			setData(_line, 62, 4, 0);
			setData(_line, 62, 5, 0);
		}
	}

	public static void JG_KCI_SU_solsin(int _line)
	{
		if (procedDate[_line] != 158)
		{
			procedDate[_line] = 158;
			init(_line);
			setData(_line, 0, 0, 595);
			setData(_line, 75, 4, 0);
			setData(_line, 75, 5, 0);
		}
	}

	public static void JG_KOG_sin_revival(int _line)
	{
		if (procedDate[_line] != 159)
		{
			procedDate[_line] = 159;
			init(_line);
			setData(_line, 0, 0, 669);
			setData(_line, 90, 3, 255);
			setData(_line, 90, 0, 670);
			setData(_line, 210, 2, 0);
			setData(_line, 210, 5, 0);
		}
	}

	public static void JG_BAO_start(int _line)
	{
		if (procedDate[_line] != 160)
		{
			procedDate[_line] = 160;
			init(_line);
			setData(_line, 0, 0, 674);
			setData(_line, 450, 3, 255);
			setData(_line, 450, 0, 675);
			setData(_line, 570, 2, 0);
			setData(_line, 570, 5, 0);
		}
	}

	public static void JG_BAO_finalbattle(int _line)
	{
		if (procedDate[_line] != 161)
		{
			procedDate[_line] = 161;
			init(_line);
			setData(_line, 0, 0, 676);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 675);
			setData(_line, 150, 2, 0);
			setData(_line, 150, 5, 0);
		}
	}

	public static void SE_common_kokuchi_01(int _line)
	{
		if (procedDate[_line] != 162)
		{
			procedDate[_line] = 162;
			init(_line);
			setData(_line, 0, 0, 679);
			setData(_line, 46, 3, 255);
			setData(_line, 46, 0, 715);
			setData(_line, 47, 2, 0);
			setData(_line, 47, 5, 0);
		}
	}

	public static void SE_common_kokuchi_02(int _line)
	{
		if (procedDate[_line] != 163)
		{
			procedDate[_line] = 163;
			init(_line);
			setData(_line, 0, 0, 680);
			setData(_line, 46, 3, 255);
			setData(_line, 46, 0, 716);
			setData(_line, 47, 2, 0);
			setData(_line, 47, 5, 0);
		}
	}

	public static void SE_common_kokuchi_03(int _line)
	{
		if (procedDate[_line] != 164)
		{
			procedDate[_line] = 164;
			init(_line);
			setData(_line, 0, 0, 681);
			setData(_line, 46, 3, 255);
			setData(_line, 46, 0, 717);
			setData(_line, 47, 2, 0);
			setData(_line, 47, 5, 0);
		}
	}

	public static void SE_common_kokuchi_04(int _line)
	{
		if (procedDate[_line] != 165)
		{
			procedDate[_line] = 165;
			init(_line);
			setData(_line, 0, 0, 682);
			setData(_line, 46, 3, 255);
			setData(_line, 46, 0, 718);
			setData(_line, 47, 2, 0);
			setData(_line, 47, 5, 0);
		}
	}

	public static void SE_common_kokuchi_05(int _line)
	{
		if (procedDate[_line] != 166)
		{
			procedDate[_line] = 166;
			init(_line);
			setData(_line, 0, 0, 683);
			setData(_line, 50, 3, 255);
			setData(_line, 50, 0, 719);
			setData(_line, 51, 2, 0);
			setData(_line, 51, 5, 0);
		}
	}

	public static void SE_common_kokuchi_06(int _line)
	{
		if (procedDate[_line] != 167)
		{
			procedDate[_line] = 167;
			init(_line);
			setData(_line, 0, 0, 709);
			setData(_line, 46, 3, 255);
			setData(_line, 46, 0, 720);
			setData(_line, 47, 2, 0);
			setData(_line, 47, 5, 0);
		}
	}

	public static void SE_common_kokuchi_07(int _line)
	{
		if (procedDate[_line] != 168)
		{
			procedDate[_line] = 168;
			init(_line);
			setData(_line, 0, 0, 710);
			setData(_line, 46, 3, 255);
			setData(_line, 46, 0, 721);
			setData(_line, 47, 2, 0);
			setData(_line, 47, 5, 0);
		}
	}

	public static void SE_common_kokuchi_08(int _line)
	{
		if (procedDate[_line] != 169)
		{
			procedDate[_line] = 169;
			init(_line);
			setData(_line, 0, 0, 711);
			setData(_line, 46, 3, 255);
			setData(_line, 46, 0, 722);
			setData(_line, 47, 2, 0);
			setData(_line, 47, 5, 0);
		}
	}

	public static void SE_common_kokuchi_09(int _line)
	{
		if (procedDate[_line] != 170)
		{
			procedDate[_line] = 170;
			init(_line);
			setData(_line, 0, 0, 712);
			setData(_line, 46, 3, 255);
			setData(_line, 46, 0, 723);
			setData(_line, 47, 2, 0);
			setData(_line, 47, 5, 0);
		}
	}

	public static void SE_common_kokuchi_10(int _line)
	{
		if (procedDate[_line] != 171)
		{
			procedDate[_line] = 171;
			init(_line);
			setData(_line, 0, 0, 682);
			setData(_line, 46, 4, 0);
			setData(_line, 46, 5, 0);
		}
	}

	public static void SE_common_kokuchi_11(int _line)
	{
		if (procedDate[_line] != 172)
		{
			procedDate[_line] = 172;
			init(_line);
			setData(_line, 0, 0, 683);
			setData(_line, 50, 4, 0);
			setData(_line, 50, 5, 0);
		}
	}

	public static void JG_PRC_start(int _line)
	{
		if (procedDate[_line] != 173)
		{
			procedDate[_line] = 173;
			init(_line);
			setData(_line, 0, 0, 689);
			setData(_line, 85, 4, 0);
			setData(_line, 85, 5, 0);
		}
	}

	public static void JG_PB_in(int _line)
	{
		if (procedDate[_line] != 174)
		{
			procedDate[_line] = 174;
			init(_line);
			setData(_line, 0, 0, 690);
			setData(_line, 120, 3, 255);
			setData(_line, 120, 0, 691);
			setData(_line, 240, 2, 0);
			setData(_line, 240, 5, 0);
		}
	}

	public static void JG_KBU_SL(int _line)
	{
		if (procedDate[_line] != 175)
		{
			procedDate[_line] = 175;
			init(_line);
			setData(_line, 0, 0, 702);
			setData(_line, 36, 3, 255);
			setData(_line, 36, 0, 703);
			setData(_line, 37, 2, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void JG_KBU_CP(int _line)
	{
		if (procedDate[_line] != 176)
		{
			procedDate[_line] = 176;
			init(_line);
			setData(_line, 0, 0, 698);
			setData(_line, 36, 3, 255);
			setData(_line, 36, 0, 699);
			setData(_line, 37, 2, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void JG_KBU_ML(int _line)
	{
		if (procedDate[_line] != 177)
		{
			procedDate[_line] = 177;
			init(_line);
			setData(_line, 0, 0, 700);
			setData(_line, 36, 3, 255);
			setData(_line, 36, 0, 701);
			setData(_line, 37, 2, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void JG_KBU_BJ(int _line)
	{
		if (procedDate[_line] != 178)
		{
			procedDate[_line] = 178;
			init(_line);
			setData(_line, 0, 0, 696);
			setData(_line, 36, 3, 255);
			setData(_line, 36, 0, 697);
			setData(_line, 37, 2, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void JG_KBU_ZP(int _line)
	{
		if (procedDate[_line] != 179)
		{
			procedDate[_line] = 179;
			init(_line);
			setData(_line, 0, 0, 704);
			setData(_line, 36, 3, 255);
			setData(_line, 36, 0, 705);
			setData(_line, 37, 2, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void JG_add_BD(int _line)
	{
		if (procedDate[_line] != 180)
		{
			procedDate[_line] = 180;
			init(_line);
			setData(_line, 0, 0, 706);
			setData(_line, 65, 3, 255);
			setData(_line, 65, 0, 707);
			setData(_line, 125, 2, 0);
			setData(_line, 125, 5, 0);
		}
	}

	public static void SE_KSY_close_01(int _line)
	{
		if (procedDate[_line] != 181)
		{
			procedDate[_line] = 181;
			init(_line);
			setData(_line, 0, 0, 763);
			setData(_line, 45, 3, 255);
			setData(_line, 45, 0, 764);
			setData(_line, 46, 2, 0);
			setData(_line, 46, 5, 0);
		}
	}

	public static void SE_KSY_close_02(int _line)
	{
		if (procedDate[_line] != 182)
		{
			procedDate[_line] = 182;
			init(_line);
			setData(_line, 0, 0, 763);
			setData(_line, 45, 4, 0);
			setData(_line, 45, 5, 0);
		}
	}

	public static void JG_JKB_end(int _line)
	{
		if (procedDate[_line] != 183)
		{
			procedDate[_line] = 183;
			init(_line);
			setData(_line, 45, 0, 765);
			setData(_line, 90, 3, 255);
			setData(_line, 90, 0, 766);
			setData(_line, 91, 2, 0);
			setData(_line, 91, 5, 0);
		}
	}

	public static void SE_JST_any_in(int _line)
	{
		if (procedDate[_line] != 184)
		{
			procedDate[_line] = 184;
			init(_line);
			setData(_line, 0, 0, 767);
			setData(_line, 33, 4, 0);
			setData(_line, 33, 5, 0);
		}
	}

	public static void JG_KKT_start(int _line)
	{
		if (procedDate[_line] != 185)
		{
			procedDate[_line] = 185;
			init(_line);
			setData(_line, 0, 0, 768);
			setData(_line, 13, 4, 0);
			setData(_line, 13, 5, 0);
		}
	}

	public static void JG_KHO_start(int _line)
	{
		if (procedDate[_line] != 186)
		{
			procedDate[_line] = 186;
			init(_line);
			setData(_line, 0, 0, 789);
			setData(_line, 13, 3, 255);
			setData(_line, 13, 0, 790);
			setData(_line, 43, 2, 0);
			setData(_line, 43, 5, 0);
		}
	}

	public static void JG_KHO_start_white_01(int _line)
	{
		if (procedDate[_line] != 187)
		{
			procedDate[_line] = 187;
			init(_line);
			setData(_line, 0, 0, 789);
			setData(_line, 13, 0, 790);
			setData(_line, 30, 0, 791);
			setData(_line, 40, 3, 255);
			setData(_line, 40, 0, 793);
			setData(_line, 41, 2, 0);
			setData(_line, 41, 5, 0);
		}
	}

	public static void JG_KHO_start_white_02(int _line)
	{
		if (procedDate[_line] != 188)
		{
			procedDate[_line] = 188;
			init(_line);
			setData(_line, 0, 0, 789);
			setData(_line, 13, 0, 790);
			setData(_line, 30, 0, 792);
			setData(_line, 40, 3, 255);
			setData(_line, 40, 0, 794);
			setData(_line, 41, 2, 0);
			setData(_line, 41, 5, 0);
		}
	}

	public static void JG_KHO_start_blue_01(int _line)
	{
		if (procedDate[_line] != 189)
		{
			procedDate[_line] = 189;
			init(_line);
			setData(_line, 0, 0, 789);
			setData(_line, 13, 0, 790);
			setData(_line, 30, 0, 769);
			setData(_line, 40, 3, 255);
			setData(_line, 40, 0, 771);
			setData(_line, 41, 2, 0);
			setData(_line, 41, 5, 0);
		}
	}

	public static void JG_KHO_start_blue_02(int _line)
	{
		if (procedDate[_line] != 190)
		{
			procedDate[_line] = 190;
			init(_line);
			setData(_line, 0, 0, 789);
			setData(_line, 13, 0, 790);
			setData(_line, 30, 0, 770);
			setData(_line, 40, 3, 255);
			setData(_line, 40, 0, 772);
			setData(_line, 41, 2, 0);
			setData(_line, 41, 5, 0);
		}
	}

	public static void JG_KHO_start_yellow_01(int _line)
	{
		if (procedDate[_line] != 191)
		{
			procedDate[_line] = 191;
			init(_line);
			setData(_line, 0, 0, 789);
			setData(_line, 13, 0, 790);
			setData(_line, 30, 0, 795);
			setData(_line, 40, 3, 255);
			setData(_line, 40, 0, 797);
			setData(_line, 41, 2, 0);
			setData(_line, 41, 5, 0);
		}
	}

	public static void JG_KHO_start_yellow_02(int _line)
	{
		if (procedDate[_line] != 192)
		{
			procedDate[_line] = 192;
			init(_line);
			setData(_line, 0, 0, 789);
			setData(_line, 13, 0, 790);
			setData(_line, 30, 0, 796);
			setData(_line, 40, 3, 255);
			setData(_line, 40, 0, 798);
			setData(_line, 41, 2, 0);
			setData(_line, 41, 5, 0);
		}
	}

	public static void JG_KHO_start_green_01(int _line)
	{
		if (procedDate[_line] != 193)
		{
			procedDate[_line] = 193;
			init(_line);
			setData(_line, 0, 0, 789);
			setData(_line, 13, 0, 790);
			setData(_line, 30, 0, 773);
			setData(_line, 40, 3, 255);
			setData(_line, 40, 0, 775);
			setData(_line, 41, 2, 0);
			setData(_line, 41, 5, 0);
		}
	}

	public static void JG_KHO_start_green_02(int _line)
	{
		if (procedDate[_line] != 194)
		{
			procedDate[_line] = 194;
			init(_line);
			setData(_line, 0, 0, 789);
			setData(_line, 13, 0, 790);
			setData(_line, 30, 0, 774);
			setData(_line, 40, 3, 255);
			setData(_line, 40, 0, 776);
			setData(_line, 41, 2, 0);
			setData(_line, 41, 5, 0);
		}
	}

	public static void JG_KHO_start_red_01(int _line)
	{
		if (procedDate[_line] != 195)
		{
			procedDate[_line] = 195;
			init(_line);
			setData(_line, 0, 0, 789);
			setData(_line, 13, 0, 790);
			setData(_line, 30, 0, 785);
			setData(_line, 40, 3, 255);
			setData(_line, 40, 0, 787);
			setData(_line, 41, 2, 0);
			setData(_line, 41, 5, 0);
		}
	}

	public static void JG_KHO_start_red_02(int _line)
	{
		if (procedDate[_line] != 196)
		{
			procedDate[_line] = 196;
			init(_line);
			setData(_line, 0, 0, 789);
			setData(_line, 13, 0, 790);
			setData(_line, 30, 0, 786);
			setData(_line, 40, 3, 255);
			setData(_line, 40, 0, 788);
			setData(_line, 41, 2, 0);
			setData(_line, 41, 5, 0);
		}
	}

	public static void JG_KHO_start_purple_01(int _line)
	{
		if (procedDate[_line] != 197)
		{
			procedDate[_line] = 197;
			init(_line);
			setData(_line, 0, 0, 789);
			setData(_line, 13, 0, 790);
			setData(_line, 30, 0, 777);
			setData(_line, 40, 3, 255);
			setData(_line, 40, 0, 779);
			setData(_line, 41, 2, 0);
			setData(_line, 41, 5, 0);
		}
	}

	public static void JG_KHO_start_purple_02(int _line)
	{
		if (procedDate[_line] != 198)
		{
			procedDate[_line] = 198;
			init(_line);
			setData(_line, 0, 0, 789);
			setData(_line, 13, 0, 790);
			setData(_line, 30, 0, 778);
			setData(_line, 40, 3, 255);
			setData(_line, 40, 0, 780);
			setData(_line, 41, 2, 0);
			setData(_line, 41, 5, 0);
		}
	}

	public static void JG_KHO_start_rainbow_01(int _line)
	{
		if (procedDate[_line] != 199)
		{
			procedDate[_line] = 199;
			init(_line);
			setData(_line, 0, 0, 789);
			setData(_line, 13, 0, 790);
			setData(_line, 30, 0, 781);
			setData(_line, 40, 3, 255);
			setData(_line, 40, 0, 783);
			setData(_line, 41, 2, 0);
			setData(_line, 41, 5, 0);
		}
	}

	public static void JG_KHO_start_rainbow_02(int _line)
	{
		if (procedDate[_line] != 200)
		{
			procedDate[_line] = 200;
			init(_line);
			setData(_line, 0, 0, 789);
			setData(_line, 13, 0, 790);
			setData(_line, 30, 0, 782);
			setData(_line, 40, 3, 255);
			setData(_line, 40, 0, 784);
			setData(_line, 41, 2, 0);
			setData(_line, 41, 5, 0);
		}
	}

	public static void JG_KHO_white_01(int _line)
	{
		if (procedDate[_line] != 201)
		{
			procedDate[_line] = 201;
			init(_line);
			setData(_line, 0, 0, 791);
			setData(_line, 10, 3, 255);
			setData(_line, 10, 0, 793);
			setData(_line, 11, 2, 0);
			setData(_line, 11, 5, 0);
		}
	}

	public static void JG_KHO_white_02(int _line)
	{
		if (procedDate[_line] != 202)
		{
			procedDate[_line] = 202;
			init(_line);
			setData(_line, 0, 0, 792);
			setData(_line, 10, 3, 255);
			setData(_line, 10, 0, 794);
			setData(_line, 11, 2, 0);
			setData(_line, 11, 5, 0);
		}
	}

	public static void JG_KHO_blue_01(int _line)
	{
		if (procedDate[_line] != 203)
		{
			procedDate[_line] = 203;
			init(_line);
			setData(_line, 0, 0, 769);
			setData(_line, 10, 3, 255);
			setData(_line, 10, 0, 771);
			setData(_line, 11, 2, 0);
			setData(_line, 11, 5, 0);
		}
	}

	public static void JG_KHO_blue_02(int _line)
	{
		if (procedDate[_line] != 204)
		{
			procedDate[_line] = 204;
			init(_line);
			setData(_line, 0, 0, 770);
			setData(_line, 10, 3, 255);
			setData(_line, 10, 0, 772);
			setData(_line, 11, 2, 0);
			setData(_line, 11, 5, 0);
		}
	}

	public static void JG_KHO_yellow_01(int _line)
	{
		if (procedDate[_line] != 205)
		{
			procedDate[_line] = 205;
			init(_line);
			setData(_line, 0, 0, 795);
			setData(_line, 10, 3, 255);
			setData(_line, 10, 0, 797);
			setData(_line, 11, 2, 0);
			setData(_line, 11, 5, 0);
		}
	}

	public static void JG_KHO_yellow_02(int _line)
	{
		if (procedDate[_line] != 206)
		{
			procedDate[_line] = 206;
			init(_line);
			setData(_line, 0, 0, 796);
			setData(_line, 10, 3, 255);
			setData(_line, 10, 0, 798);
			setData(_line, 11, 2, 0);
			setData(_line, 11, 5, 0);
		}
	}

	public static void JG_KHO_green_01(int _line)
	{
		if (procedDate[_line] != 207)
		{
			procedDate[_line] = 207;
			init(_line);
			setData(_line, 0, 0, 773);
			setData(_line, 10, 3, 255);
			setData(_line, 10, 0, 775);
			setData(_line, 11, 2, 0);
			setData(_line, 11, 5, 0);
		}
	}

	public static void JG_KHO_green_02(int _line)
	{
		if (procedDate[_line] != 208)
		{
			procedDate[_line] = 208;
			init(_line);
			setData(_line, 0, 0, 774);
			setData(_line, 10, 3, 255);
			setData(_line, 10, 0, 776);
			setData(_line, 11, 2, 0);
			setData(_line, 11, 5, 0);
		}
	}

	public static void JG_KHO_red_01(int _line)
	{
		if (procedDate[_line] != 209)
		{
			procedDate[_line] = 209;
			init(_line);
			setData(_line, 0, 0, 785);
			setData(_line, 10, 3, 255);
			setData(_line, 10, 0, 787);
			setData(_line, 11, 2, 0);
			setData(_line, 11, 5, 0);
		}
	}

	public static void JG_KHO_red_02(int _line)
	{
		if (procedDate[_line] != 210)
		{
			procedDate[_line] = 210;
			init(_line);
			setData(_line, 0, 0, 786);
			setData(_line, 10, 3, 255);
			setData(_line, 10, 0, 788);
			setData(_line, 11, 2, 0);
			setData(_line, 11, 5, 0);
		}
	}

	public static void JG_KHO_purple_01(int _line)
	{
		if (procedDate[_line] != 211)
		{
			procedDate[_line] = 211;
			init(_line);
			setData(_line, 0, 0, 777);
			setData(_line, 10, 3, 255);
			setData(_line, 10, 0, 779);
			setData(_line, 11, 2, 0);
			setData(_line, 11, 5, 0);
		}
	}

	public static void JG_KHO_purple_02(int _line)
	{
		if (procedDate[_line] != 212)
		{
			procedDate[_line] = 212;
			init(_line);
			setData(_line, 0, 0, 778);
			setData(_line, 10, 3, 255);
			setData(_line, 10, 0, 780);
			setData(_line, 11, 2, 0);
			setData(_line, 11, 5, 0);
		}
	}

	public static void JG_KHO_rainbow_01(int _line)
	{
		if (procedDate[_line] != 213)
		{
			procedDate[_line] = 213;
			init(_line);
			setData(_line, 0, 0, 781);
			setData(_line, 10, 3, 255);
			setData(_line, 10, 0, 783);
			setData(_line, 130, 2, 0);
			setData(_line, 130, 5, 0);
		}
	}

	public static void JG_KHO_rainbow_02(int _line)
	{
		if (procedDate[_line] != 214)
		{
			procedDate[_line] = 214;
			init(_line);
			setData(_line, 0, 0, 782);
			setData(_line, 10, 3, 255);
			setData(_line, 10, 0, 784);
			setData(_line, 130, 2, 0);
			setData(_line, 130, 5, 0);
		}
	}

	public static void JG_ISS(int _line)
	{
		if (procedDate[_line] != 215)
		{
			procedDate[_line] = 215;
			init(_line);
			setData(_line, 0, 0, 546);
			setData(_line, 110, 3, 255);
			setData(_line, 110, 0, 547);
			setData(_line, 128, 2, 0);
			setData(_line, 128, 5, 0);
		}
	}

	public static void JG_IGO(int _line)
	{
		if (procedDate[_line] != 216)
		{
			procedDate[_line] = 216;
			init(_line);
			setData(_line, 0, 0, 564);
			setData(_line, 128, 3, 255);
			setData(_line, 128, 0, 565);
			setData(_line, 129, 2, 0);
			setData(_line, 129, 5, 0);
		}
	}

	public static void JG_ISH(int _line)
	{
		if (procedDate[_line] != 217)
		{
			procedDate[_line] = 217;
			init(_line);
			setData(_line, 0, 0, 566);
			setData(_line, 117, 3, 255);
			setData(_line, 117, 0, 567);
			setData(_line, 118, 2, 0);
			setData(_line, 118, 5, 0);
		}
	}

	public static void JG_IMB(int _line)
	{
		if (procedDate[_line] != 218)
		{
			procedDate[_line] = 218;
			init(_line);
			setData(_line, 0, 0, 568);
			setData(_line, 90, 3, 255);
			setData(_line, 90, 0, 569);
			setData(_line, 91, 2, 0);
			setData(_line, 91, 5, 0);
		}
	}

	public static void JG_IOG(int _line)
	{
		if (procedDate[_line] != 219)
		{
			procedDate[_line] = 219;
			init(_line);
			setData(_line, 0, 0, 562);
			setData(_line, 68, 3, 255);
			setData(_line, 68, 0, 563);
			setData(_line, 128, 2, 0);
			setData(_line, 128, 5, 0);
		}
	}

	public static void JYD_unite(int _line)
	{
		if (procedDate[_line] != 220)
		{
			procedDate[_line] = 220;
			init(_line);
			setData(_line, 0, 0, 582);
			setData(_line, 77, 4, 0);
			setData(_line, 77, 5, 0);
		}
	}

	public static void JYD_unite_02(int _line)
	{
		if (procedDate[_line] != 221)
		{
			procedDate[_line] = 221;
			init(_line);
			setData(_line, 0, 0, 582);
			setData(_line, 72, 3, 255);
			setData(_line, 72, 0, 713);
			setData(_line, 92, 2, 0);
			setData(_line, 92, 5, 0);
		}
	}

	public static void JYD_unite_YTG(int _line)
	{
		if (procedDate[_line] != 222)
		{
			procedDate[_line] = 222;
			init(_line);
			setData(_line, 0, 0, 760);
			setData(_line, 110, 4, 0);
			setData(_line, 110, 5, 0);
		}
	}

	public static void KCI_SU_sol(int _line)
	{
		if (procedDate[_line] != 223)
		{
			procedDate[_line] = 223;
			init(_line);
			setData(_line, 0, 0, 594);
			setData(_line, 62, 4, 0);
			setData(_line, 62, 5, 0);
		}
	}

	public static void KCI_SU_sin(int _line)
	{
		if (procedDate[_line] != 224)
		{
			procedDate[_line] = 224;
			init(_line);
			setData(_line, 0, 0, 593);
			setData(_line, 62, 4, 0);
			setData(_line, 62, 5, 0);
		}
	}

	public static void KCI_SU_solsin(int _line)
	{
		if (procedDate[_line] != 225)
		{
			procedDate[_line] = 225;
			init(_line);
			setData(_line, 0, 0, 595);
			setData(_line, 75, 4, 0);
			setData(_line, 75, 5, 0);
		}
	}

	public static void KCI_sol(int _line)
	{
		if (procedDate[_line] != 226)
		{
			procedDate[_line] = 226;
			init(_line);
			setData(_line, 0, 0, 584);
			setData(_line, 45, 4, 0);
			setData(_line, 45, 5, 0);
		}
	}

	public static void KCI_sin(int _line)
	{
		if (procedDate[_line] != 227)
		{
			procedDate[_line] = 227;
			init(_line);
			setData(_line, 0, 0, 583);
			setData(_line, 45, 4, 0);
			setData(_line, 45, 5, 0);
		}
	}

	public static void KCI_kai(int _line)
	{
		if (procedDate[_line] != 228)
		{
			procedDate[_line] = 228;
			init(_line);
			setData(_line, 0, 0, 591);
			setData(_line, 45, 4, 0);
			setData(_line, 45, 5, 0);
		}
	}

	public static void KCI_man(int _line)
	{
		if (procedDate[_line] != 229)
		{
			procedDate[_line] = 229;
			init(_line);
			setData(_line, 0, 0, 592);
			setData(_line, 45, 4, 0);
			setData(_line, 45, 5, 0);
		}
	}

	public static void KCI_diz(int _line)
	{
		if (procedDate[_line] != 230)
		{
			procedDate[_line] = 230;
			init(_line);
			setData(_line, 0, 0, 590);
			setData(_line, 45, 4, 0);
			setData(_line, 45, 5, 0);
		}
	}

	public static void KCI_dai(int _line)
	{
		if (procedDate[_line] != 231)
		{
			procedDate[_line] = 231;
			init(_line);
			setData(_line, 0, 0, 585);
			setData(_line, 45, 4, 0);
			setData(_line, 45, 5, 0);
		}
	}

	public static void KCI_DI(int _line)
	{
		if (procedDate[_line] != 232)
		{
			procedDate[_line] = 232;
			init(_line);
			setData(_line, 0, 0, 586);
			setData(_line, 45, 3, 255);
			setData(_line, 45, 0, 587);
			setData(_line, 135, 2, 0);
			setData(_line, 135, 5, 0);
		}
	}

	public static void KCI_DI_lose(int _line)
	{
		if (procedDate[_line] != 233)
		{
			procedDate[_line] = 233;
			init(_line);
			setData(_line, 0, 0, 588);
			setData(_line, 45, 3, 255);
			setData(_line, 45, 0, 589);
			setData(_line, 46, 2, 0);
			setData(_line, 46, 5, 0);
		}
	}

	public static void YK_win_sin(int _line)
	{
		if (procedDate[_line] != 234)
		{
			procedDate[_line] = 234;
			init(_line);
			setData(_line, 0, 0, 521);
			setData(_line, 130, 3, 255);
			setData(_line, 130, 0, 522);
			setData(_line, 160, 2, 0);
			setData(_line, 160, 5, 0);
		}
	}

	public static void YK_win_sol(int _line)
	{
		if (procedDate[_line] != 235)
		{
			procedDate[_line] = 235;
			init(_line);
			setData(_line, 0, 0, 523);
			setData(_line, 120, 3, 255);
			setData(_line, 120, 0, 524);
			setData(_line, 150, 2, 0);
			setData(_line, 150, 5, 0);
		}
	}

	public static void JRR_01(int _line)
	{
		if (procedDate[_line] != 236)
		{
			procedDate[_line] = 236;
			init(_line);
			setData(_line, 0, 0, 596);
			setData(_line, 8, 4, 0);
			setData(_line, 8, 5, 0);
		}
	}

	public static void JRR_02(int _line)
	{
		if (procedDate[_line] != 237)
		{
			procedDate[_line] = 237;
			init(_line);
			setData(_line, 0, 0, 597);
			setData(_line, 12, 4, 0);
			setData(_line, 12, 5, 0);
		}
	}

	public static void JRR_03(int _line)
	{
		if (procedDate[_line] != 238)
		{
			procedDate[_line] = 238;
			init(_line);
			setData(_line, 0, 0, 598);
			setData(_line, 16, 4, 0);
			setData(_line, 16, 5, 0);
		}
	}

	public static void HUC_lever(int _line)
	{
		if (procedDate[_line] != 239)
		{
			procedDate[_line] = 239;
			init(_line);
			setData(_line, 0, 0, 603);
			setData(_line, 112, 3, 255);
			setData(_line, 112, 0, 604);
			setData(_line, 172, 2, 0);
			setData(_line, 172, 5, 0);
		}
	}

	public static void HUC_white(int _line)
	{
		if (procedDate[_line] != 240)
		{
			procedDate[_line] = 240;
			init(_line);
			setData(_line, 0, 0, 604);
			setData(_line, 60, 2, 0);
			setData(_line, 60, 5, 0);
		}
	}

	public static void HUC_blue(int _line)
	{
		if (procedDate[_line] != 241)
		{
			procedDate[_line] = 241;
			init(_line);
			setData(_line, 0, 0, 599);
			setData(_line, 60, 3, 255);
			setData(_line, 60, 0, 600);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void HUC_yellow(int _line)
	{
		if (procedDate[_line] != 242)
		{
			procedDate[_line] = 242;
			init(_line);
			setData(_line, 0, 0, 611);
			setData(_line, 60, 3, 255);
			setData(_line, 60, 0, 612);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void HUC_green(int _line)
	{
		if (procedDate[_line] != 243)
		{
			procedDate[_line] = 243;
			init(_line);
			setData(_line, 0, 0, 601);
			setData(_line, 60, 3, 255);
			setData(_line, 60, 0, 602);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void HUC_red(int _line)
	{
		if (procedDate[_line] != 244)
		{
			procedDate[_line] = 244;
			init(_line);
			setData(_line, 0, 0, 609);
			setData(_line, 60, 3, 255);
			setData(_line, 60, 0, 610);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void HUC_purple(int _line)
	{
		if (procedDate[_line] != 245)
		{
			procedDate[_line] = 245;
			init(_line);
			setData(_line, 0, 0, 605);
			setData(_line, 60, 3, 255);
			setData(_line, 60, 0, 606);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void HUC_rainbow(int _line)
	{
		if (procedDate[_line] != 246)
		{
			procedDate[_line] = 246;
			init(_line);
			setData(_line, 0, 0, 607);
			setData(_line, 120, 3, 255);
			setData(_line, 120, 0, 608);
			setData(_line, 240, 2, 0);
			setData(_line, 240, 5, 0);
		}
	}

	public static void YK_HOH_psych(int _line)
	{
		if (procedDate[_line] != 247)
		{
			procedDate[_line] = 247;
			init(_line);
			setData(_line, 0, 0, 613);
			setData(_line, 41, 3, 255);
			setData(_line, 41, 0, 616);
			setData(_line, 57, 2, 0);
			setData(_line, 57, 5, 0);
		}
	}

	public static void YK_HOH_psych_cutin(int _line)
	{
		if (procedDate[_line] != 248)
		{
			procedDate[_line] = 248;
			init(_line);
			setData(_line, 0, 0, 614);
			setData(_line, 20, 3, 255);
			setData(_line, 20, 0, 615);
			setData(_line, 40, 2, 0);
			setData(_line, 40, 5, 0);
		}
	}

	public static void YK_add_7(int _line)
	{
		if (procedDate[_line] != 249)
		{
			procedDate[_line] = 249;
			init(_line);
			setData(_line, 0, 0, 617);
			setData(_line, 50, 3, 255);
			setData(_line, 50, 0, 624);
			setData(_line, 81, 2, 0);
			setData(_line, 81, 5, 0);
		}
	}

	public static void YK_add_10(int _line)
	{
		if (procedDate[_line] != 250)
		{
			procedDate[_line] = 250;
			init(_line);
			setData(_line, 0, 0, 617);
			setData(_line, 50, 3, 255);
			setData(_line, 50, 0, 624);
			setData(_line, 81, 2, 0);
			setData(_line, 81, 5, 0);
		}
	}

	public static void YK_add_20(int _line)
	{
		if (procedDate[_line] != 251)
		{
			procedDate[_line] = 251;
			init(_line);
			setData(_line, 0, 0, 618);
			setData(_line, 50, 3, 255);
			setData(_line, 50, 0, 627);
			setData(_line, 81, 2, 0);
			setData(_line, 81, 5, 0);
		}
	}

	public static void YK_add_30(int _line)
	{
		if (procedDate[_line] != 252)
		{
			procedDate[_line] = 252;
			init(_line);
			setData(_line, 0, 0, 619);
			setData(_line, 50, 3, 255);
			setData(_line, 50, 0, 629);
			setData(_line, 81, 2, 0);
			setData(_line, 81, 5, 0);
		}
	}

	public static void YK_add_50(int _line)
	{
		if (procedDate[_line] != 253)
		{
			procedDate[_line] = 253;
			init(_line);
			setData(_line, 0, 0, 620);
			setData(_line, 50, 3, 255);
			setData(_line, 50, 0, 631);
			setData(_line, 81, 2, 0);
			setData(_line, 81, 5, 0);
		}
	}

	public static void YK_add_100(int _line)
	{
		if (procedDate[_line] != 254)
		{
			procedDate[_line] = 254;
			init(_line);
			setData(_line, 0, 0, 632);
			setData(_line, 50, 3, 255);
			setData(_line, 50, 0, 625);
			setData(_line, 81, 2, 0);
			setData(_line, 81, 5, 0);
		}
	}

	public static void YK_add_150(int _line)
	{
		if (procedDate[_line] != 255)
		{
			procedDate[_line] = 255;
			init(_line);
			setData(_line, 0, 0, 621);
			setData(_line, 50, 3, 255);
			setData(_line, 50, 0, 626);
			setData(_line, 81, 2, 0);
			setData(_line, 81, 5, 0);
		}
	}

	public static void YK_add_200(int _line)
	{
		if (procedDate[_line] != 256)
		{
			procedDate[_line] = 256;
			init(_line);
			setData(_line, 0, 0, 622);
			setData(_line, 70, 3, 255);
			setData(_line, 70, 0, 628);
			setData(_line, 101, 2, 0);
			setData(_line, 101, 5, 0);
		}
	}

	public static void YK_add_300(int _line)
	{
		if (procedDate[_line] != 257)
		{
			procedDate[_line] = 257;
			init(_line);
			setData(_line, 0, 0, 623);
			setData(_line, 70, 3, 255);
			setData(_line, 70, 0, 630);
			setData(_line, 101, 2, 0);
			setData(_line, 101, 5, 0);
		}
	}

	public static void YK_add_BD(int _line)
	{
		if (procedDate[_line] != 258)
		{
			procedDate[_line] = 258;
			init(_line);
			setData(_line, 0, 0, 706);
			setData(_line, 65, 3, 255);
			setData(_line, 65, 0, 707);
			setData(_line, 125, 2, 0);
			setData(_line, 125, 5, 0);
		}
	}

	public static void YK_add_GB(int _line)
	{
		if (procedDate[_line] != 259)
		{
			procedDate[_line] = 259;
			init(_line);
			setData(_line, 0, 0, 765);
			setData(_line, 70, 3, 255);
			setData(_line, 70, 0, 766);
			setData(_line, 190, 2, 0);
			setData(_line, 190, 5, 0);
		}
	}

	public static void YK_DGS_add_BONUS(int _line)
	{
		if (procedDate[_line] != 260)
		{
			procedDate[_line] = 260;
			init(_line);
			setData(_line, 34, 0, 623);
			setData(_line, 104, 3, 255);
			setData(_line, 104, 0, 630);
			setData(_line, 135, 2, 0);
			setData(_line, 135, 5, 0);
		}
	}

	public static void YK_YTG_add_BONUS(int _line)
	{
		if (procedDate[_line] != 261)
		{
			procedDate[_line] = 261;
			init(_line);
			setData(_line, 80, 0, 623);
			setData(_line, 150, 3, 255);
			setData(_line, 150, 0, 630);
			setData(_line, 181, 2, 0);
			setData(_line, 181, 5, 0);
		}
	}

	public static void YK_IKG_start(int _line)
	{
		if (procedDate[_line] != 262)
		{
			procedDate[_line] = 262;
			init(_line);
			setData(_line, 0, 0, 639);
			setData(_line, 105, 4, 0);
			setData(_line, 105, 5, 0);
		}
	}

	public static void YK_AIG_01(int _line)
	{
		if (procedDate[_line] != 263)
		{
			procedDate[_line] = 263;
			init(_line);
			setData(_line, 0, 0, 640);
			setData(_line, 28, 3, 255);
			setData(_line, 28, 0, 642);
			setData(_line, 50, 2, 0);
			setData(_line, 50, 5, 0);
		}
	}

	public static void YK_AIG_02(int _line)
	{
		if (procedDate[_line] != 264)
		{
			procedDate[_line] = 264;
			init(_line);
			setData(_line, 0, 0, 641);
			setData(_line, 28, 3, 255);
			setData(_line, 28, 0, 645);
			setData(_line, 50, 2, 0);
			setData(_line, 50, 5, 0);
		}
	}

	public static void YK_AIG_01_miss(int _line)
	{
		if (procedDate[_line] != 265)
		{
			procedDate[_line] = 265;
			init(_line);
			setData(_line, 0, 0, 643);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 644);
			setData(_line, 31, 2, 0);
			setData(_line, 31, 5, 0);
		}
	}

	public static void YK_AIG_02_miss(int _line)
	{
		if (procedDate[_line] != 266)
		{
			procedDate[_line] = 266;
			init(_line);
			setData(_line, 0, 0, 646);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 647);
			setData(_line, 31, 2, 0);
			setData(_line, 31, 5, 0);
		}
	}

	public static void YK_AIG_attack_01(int _line)
	{
		if (procedDate[_line] != 267)
		{
			procedDate[_line] = 267;
			init(_line);
			setData(_line, 0, 0, 648);
			setData(_line, 16, 3, 255);
			setData(_line, 16, 0, 650);
			setData(_line, 24, 2, 0);
			setData(_line, 24, 5, 0);
		}
	}

	public static void YK_AIG_attack_02(int _line)
	{
		if (procedDate[_line] != 268)
		{
			procedDate[_line] = 268;
			init(_line);
			setData(_line, 0, 0, 649);
			setData(_line, 16, 3, 255);
			setData(_line, 16, 0, 651);
			setData(_line, 24, 2, 0);
			setData(_line, 24, 5, 0);
		}
	}

	public static void YK_AIG_attack_01_rainbow(int _line)
	{
		if (procedDate[_line] != 269)
		{
			procedDate[_line] = 269;
			init(_line);
			setData(_line, 0, 0, 665);
			setData(_line, 122, 3, 255);
			setData(_line, 122, 0, 666);
			setData(_line, 174, 2, 0);
			setData(_line, 174, 5, 0);
		}
	}

	public static void YK_AIG_attack_02_rainbow(int _line)
	{
		if (procedDate[_line] != 270)
		{
			procedDate[_line] = 270;
			init(_line);
			setData(_line, 0, 0, 667);
			setData(_line, 122, 3, 255);
			setData(_line, 122, 0, 668);
			setData(_line, 174, 2, 0);
			setData(_line, 174, 5, 0);
		}
	}

	public static void YK_BZT_bal(int _line)
	{
		if (procedDate[_line] != 271)
		{
			procedDate[_line] = 271;
			init(_line);
			setData(_line, 0, 0, 652);
			setData(_line, 100, 3, 255);
			setData(_line, 200, 0, 673);
			setData(_line, 201, 2, 0);
			setData(_line, 201, 5, 0);
		}
	}

	public static void YK_BZT_revival(int _line)
	{
		if (procedDate[_line] != 272)
		{
			procedDate[_line] = 272;
			init(_line);
			setData(_line, 0, 0, 653);
			setData(_line, 73, 4, 0);
			setData(_line, 73, 5, 0);
		}
	}

	public static void YK_BZT_sol_01(int _line)
	{
		if (procedDate[_line] != 273)
		{
			procedDate[_line] = 273;
			init(_line);
			setData(_line, 0, 0, 654);
			setData(_line, 97, 4, 0);
			setData(_line, 97, 5, 0);
		}
	}

	public static void YK_BZT_sol_02(int _line)
	{
		if (procedDate[_line] != 274)
		{
			procedDate[_line] = 274;
			init(_line);
			setData(_line, 0, 0, 655);
			setData(_line, 119, 4, 0);
			setData(_line, 119, 5, 0);
		}
	}

	public static void YK_BZT_sol_03(int _line)
	{
		if (procedDate[_line] != 275)
		{
			procedDate[_line] = 275;
			init(_line);
			setData(_line, 0, 0, 656);
			setData(_line, 38, 4, 0);
			setData(_line, 38, 5, 0);
		}
	}

	public static void YK_SGB_in_01(int _line)
	{
		if (procedDate[_line] != 276)
		{
			procedDate[_line] = 276;
			init(_line);
			setData(_line, 0, 0, 659);
			setData(_line, 86, 3, 255);
			setData(_line, 86, 0, 660);
			setData(_line, 206, 2, 0);
			setData(_line, 206, 5, 0);
		}
	}

	public static void YK_SGB_in_02(int _line)
	{
		if (procedDate[_line] != 277)
		{
			procedDate[_line] = 277;
			init(_line);
			setData(_line, 5, 0, 659);
			setData(_line, 91, 3, 255);
			setData(_line, 91, 0, 660);
			setData(_line, 211, 2, 0);
			setData(_line, 211, 5, 0);
		}
	}

	public static void YK_GB_in_01(int _line)
	{
		if (procedDate[_line] != 278)
		{
			procedDate[_line] = 278;
			init(_line);
			setData(_line, 0, 0, 659);
			setData(_line, 86, 3, 255);
			setData(_line, 86, 0, 660);
			setData(_line, 206, 2, 0);
			setData(_line, 206, 5, 0);
		}
	}

	public static void YK_GB_in_02(int _line)
	{
		if (procedDate[_line] != 279)
		{
			procedDate[_line] = 279;
			init(_line);
			setData(_line, 5, 0, 659);
			setData(_line, 91, 3, 255);
			setData(_line, 91, 0, 660);
			setData(_line, 211, 2, 0);
			setData(_line, 211, 5, 0);
		}
	}

	public static void YK_RB_in(int _line)
	{
		if (procedDate[_line] != 280)
		{
			procedDate[_line] = 280;
			init(_line);
			setData(_line, 0, 0, 661);
			setData(_line, 74, 3, 255);
			setData(_line, 74, 0, 662);
			setData(_line, 194, 2, 0);
			setData(_line, 194, 5, 0);
		}
	}

	public static void YK_BJT_HIT_01(int _line)
	{
		if (procedDate[_line] != 281)
		{
			procedDate[_line] = 281;
			init(_line);
			setData(_line, 78, 0, 663);
			setData(_line, 108, 3, 255);
			setData(_line, 108, 0, 664);
			setData(_line, 109, 2, 0);
			setData(_line, 109, 5, 0);
		}
	}

	public static void YK_BJT_HIT_02(int _line)
	{
		if (procedDate[_line] != 282)
		{
			procedDate[_line] = 282;
			init(_line);
			setData(_line, 0, 0, 582);
			setData(_line, 72, 4, 0);
			setData(_line, 124, 0, 663);
			setData(_line, 154, 3, 255);
			setData(_line, 154, 0, 664);
			setData(_line, 155, 2, 0);
			setData(_line, 155, 5, 0);
		}
	}

	public static void YK_BJT_HIT_03(int _line)
	{
		if (procedDate[_line] != 283)
		{
			procedDate[_line] = 283;
			init(_line);
			setData(_line, 1, 0, 663);
			setData(_line, 31, 3, 255);
			setData(_line, 31, 0, 664);
			setData(_line, 32, 2, 0);
			setData(_line, 32, 5, 0);
		}
	}

	public static void YK_DI_total(int _line)
	{
		if (procedDate[_line] != 284)
		{
			procedDate[_line] = 284;
			init(_line);
			setData(_line, 33, 0, 623);
			setData(_line, 103, 3, 255);
			setData(_line, 103, 0, 630);
			setData(_line, 134, 2, 0);
			setData(_line, 134, 5, 0);
		}
	}

	public static void YK_KOG_sin_revival(int _line)
	{
		if (procedDate[_line] != 285)
		{
			procedDate[_line] = 285;
			init(_line);
			setData(_line, 0, 0, 669);
			setData(_line, 90, 3, 255);
			setData(_line, 90, 0, 670);
			setData(_line, 210, 2, 0);
			setData(_line, 210, 5, 0);
		}
	}

	public static void YK_BAO_start(int _line)
	{
		if (procedDate[_line] != 286)
		{
			procedDate[_line] = 286;
			init(_line);
			setData(_line, 0, 0, 674);
			setData(_line, 450, 3, 255);
			setData(_line, 450, 0, 675);
			setData(_line, 570, 2, 0);
			setData(_line, 570, 5, 0);
		}
	}

	public static void YK_BAO_finalbattle(int _line)
	{
		if (procedDate[_line] != 287)
		{
			procedDate[_line] = 287;
			init(_line);
			setData(_line, 0, 0, 676);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 675);
			setData(_line, 150, 2, 0);
			setData(_line, 150, 5, 0);
		}
	}

	public static void YK_KFR_DI_00(int _line)
	{
		if (procedDate[_line] != 288)
		{
			procedDate[_line] = 288;
			init(_line);
			setData(_line, 0, 0, 729);
			setData(_line, 60, 2, 0);
			setData(_line, 60, 5, 0);
		}
	}

	public static void YK_KFR_DI(int _line)
	{
		if (procedDate[_line] != 289)
		{
			procedDate[_line] = 289;
			init(_line);
			setData(_line, 0, 0, 677);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void YK_ISS(int _line)
	{
		if (procedDate[_line] != 290)
		{
			procedDate[_line] = 290;
			init(_line);
			setData(_line, 0, 0, 546);
			setData(_line, 110, 3, 255);
			setData(_line, 110, 0, 547);
			setData(_line, 128, 2, 0);
			setData(_line, 128, 5, 0);
		}
	}

	public static void YK_letsrock(int _line)
	{
		if (procedDate[_line] != 291)
		{
			procedDate[_line] = 291;
			init(_line);
			setData(_line, 0, 0, 678);
			setData(_line, 38, 4, 0);
			setData(_line, 38, 5, 0);
		}
	}

	public static void YK_JKB_start(int _line)
	{
		if (procedDate[_line] != 292)
		{
			procedDate[_line] = 292;
			init(_line);
			setData(_line, 0, 0, 688);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void YK_JKB_end(int _line)
	{
		if (procedDate[_line] != 293)
		{
			procedDate[_line] = 293;
			init(_line);
			setData(_line, 30, 0, 686);
			setData(_line, 60, 3, 255);
			setData(_line, 60, 0, 687);
			setData(_line, 90, 2, 0);
			setData(_line, 90, 5, 0);
		}
	}

	public static void YK_JKB_continue(int _line)
	{
		if (procedDate[_line] != 294)
		{
			procedDate[_line] = 294;
			init(_line);
			setData(_line, 0, 0, 684);
			setData(_line, 90, 4, 0);
			setData(_line, 90, 5, 0);
		}
	}

	public static void YK_JKB_cutin(int _line)
	{
		if (procedDate[_line] != 295)
		{
			procedDate[_line] = 295;
			init(_line);
			setData(_line, 0, 0, 685);
			setData(_line, 61, 4, 0);
			setData(_line, 61, 5, 0);
		}
	}

	public static void YK_PRC_start(int _line)
	{
		if (procedDate[_line] != 296)
		{
			procedDate[_line] = 296;
			init(_line);
			setData(_line, 0, 0, 689);
			setData(_line, 85, 4, 0);
			setData(_line, 85, 5, 0);
		}
	}

	public static void YK_PB_in(int _line)
	{
		if (procedDate[_line] != 297)
		{
			procedDate[_line] = 297;
			init(_line);
			setData(_line, 0, 0, 690);
			setData(_line, 120, 3, 255);
			setData(_line, 120, 0, 691);
			setData(_line, 240, 2, 0);
			setData(_line, 240, 5, 0);
		}
	}

	public static void YK_ND_ready(int _line)
	{
		if (procedDate[_line] != 298)
		{
			procedDate[_line] = 298;
			init(_line);
			setData(_line, 0, 0, 692);
			setData(_line, 28, 3, 255);
			setData(_line, 28, 0, 693);
			setData(_line, 50, 2, 0);
			setData(_line, 50, 5, 0);
		}
	}

	public static void YK_cutin_ND_ready(int _line)
	{
		if (procedDate[_line] != 299)
		{
			procedDate[_line] = 299;
			init(_line);
			setData(_line, 50, 0, 692);
			setData(_line, 78, 3, 255);
			setData(_line, 78, 0, 693);
			setData(_line, 100, 2, 0);
			setData(_line, 100, 5, 0);
		}
	}

	public static void YK_KBU_SL(int _line)
	{
		if (procedDate[_line] != 300)
		{
			procedDate[_line] = 300;
			init(_line);
			setData(_line, 0, 0, 702);
			setData(_line, 36, 3, 255);
			setData(_line, 36, 0, 703);
			setData(_line, 37, 2, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void YK_KBU_CP(int _line)
	{
		if (procedDate[_line] != 301)
		{
			procedDate[_line] = 301;
			init(_line);
			setData(_line, 0, 0, 698);
			setData(_line, 36, 3, 255);
			setData(_line, 36, 0, 699);
			setData(_line, 37, 2, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void YK_KBU_ML(int _line)
	{
		if (procedDate[_line] != 302)
		{
			procedDate[_line] = 302;
			init(_line);
			setData(_line, 0, 0, 700);
			setData(_line, 36, 3, 255);
			setData(_line, 36, 0, 701);
			setData(_line, 37, 2, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void YK_KBU_BJ(int _line)
	{
		if (procedDate[_line] != 303)
		{
			procedDate[_line] = 303;
			init(_line);
			setData(_line, 0, 0, 696);
			setData(_line, 36, 3, 255);
			setData(_line, 36, 0, 697);
			setData(_line, 37, 2, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void YK_KBU_ZP(int _line)
	{
		if (procedDate[_line] != 304)
		{
			procedDate[_line] = 304;
			init(_line);
			setData(_line, 0, 0, 704);
			setData(_line, 36, 3, 255);
			setData(_line, 36, 0, 705);
			setData(_line, 37, 2, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void YK_BAO_hit_HS(int _line)
	{
		if (procedDate[_line] != 305)
		{
			procedDate[_line] = 305;
			init(_line);
			setData(_line, 25, 0, 714);
			setData(_line, 40, 4, 0);
			setData(_line, 40, 5, 0);
		}
	}

	public static void YK_BAO_hit_GF(int _line)
	{
		if (procedDate[_line] != 306)
		{
			procedDate[_line] = 306;
			init(_line);
			setData(_line, 35, 0, 714);
			setData(_line, 50, 4, 0);
			setData(_line, 50, 5, 0);
		}
	}

	public static void YK_BAO_hit_counter(int _line)
	{
		if (procedDate[_line] != 307)
		{
			procedDate[_line] = 307;
			init(_line);
			setData(_line, 77, 0, 714);
			setData(_line, 92, 4, 0);
			setData(_line, 92, 5, 0);
		}
	}

	public static void YK_BAO_hit_struggle(int _line)
	{
		if (procedDate[_line] != 308)
		{
			procedDate[_line] = 308;
			init(_line);
			setData(_line, 59, 0, 714);
			setData(_line, 74, 4, 0);
			setData(_line, 74, 5, 0);
		}
	}

	public static void YK_DHI_dest(int _line)
	{
		if (procedDate[_line] != 309)
		{
			procedDate[_line] = 309;
			init(_line);
			setData(_line, 0, 0, 724);
			setData(_line, 28, 3, 255);
			setData(_line, 28, 0, 728);
			setData(_line, 50, 2, 0);
			setData(_line, 50, 5, 0);
		}
	}

	public static void YK_DHI_dest_1st(int _line)
	{
		if (procedDate[_line] != 310)
		{
			procedDate[_line] = 310;
			init(_line);
			setData(_line, 0, 0, 725);
			setData(_line, 22, 3, 255);
			setData(_line, 22, 0, 728);
			setData(_line, 44, 2, 0);
			setData(_line, 44, 5, 0);
		}
	}

	public static void YK_DHI_dest_2nd(int _line)
	{
		if (procedDate[_line] != 311)
		{
			procedDate[_line] = 311;
			init(_line);
			setData(_line, 0, 0, 726);
			setData(_line, 22, 3, 255);
			setData(_line, 22, 0, 728);
			setData(_line, 44, 2, 0);
			setData(_line, 44, 5, 0);
		}
	}

	public static void YK_DHI_dest_3rd(int _line)
	{
		if (procedDate[_line] != 312)
		{
			procedDate[_line] = 312;
			init(_line);
			setData(_line, 0, 0, 727);
			setData(_line, 66, 3, 255);
			setData(_line, 66, 0, 728);
			setData(_line, 88, 2, 0);
			setData(_line, 88, 5, 0);
		}
	}

	public static void YK_AO_in(int _line)
	{
		if (procedDate[_line] != 313)
		{
			procedDate[_line] = 313;
			init(_line);
			setData(_line, 0, 0, 538);
			setData(_line, 103, 3, 255);
			setData(_line, 103, 0, 539);
			setData(_line, 223, 2, 0);
			setData(_line, 223, 5, 0);
		}
	}

	public static void YK_VS(int _line)
	{
		if (procedDate[_line] != 314)
		{
			procedDate[_line] = 314;
			init(_line);
			setData(_line, 0, 0, 578);
			setData(_line, 180, 3, 255);
			setData(_line, 180, 0, 579);
			setData(_line, 300, 2, 0);
			setData(_line, 300, 5, 0);
		}
	}

	public static void YK_HOH_slash(int _line)
	{
		if (procedDate[_line] != 315)
		{
			procedDate[_line] = 315;
			init(_line);
			setData(_line, 0, 0, 730);
			setData(_line, 16, 4, 0);
			setData(_line, 16, 5, 0);
		}
	}

	public static void YK_HOH_herecomes_01(int _line)
	{
		if (procedDate[_line] != 316)
		{
			procedDate[_line] = 316;
			init(_line);
			setData(_line, 0, 0, 731);
			setData(_line, 21, 3, 255);
			setData(_line, 21, 0, 732);
			setData(_line, 22, 2, 0);
			setData(_line, 22, 5, 0);
		}
	}

	public static void YK_HOH_herecomes_02(int _line)
	{
		if (procedDate[_line] != 317)
		{
			procedDate[_line] = 317;
			init(_line);
			setData(_line, 25, 0, 731);
			setData(_line, 46, 3, 255);
			setData(_line, 46, 0, 732);
			setData(_line, 47, 2, 0);
			setData(_line, 47, 5, 0);
		}
	}

	public static void YK_HOH_herecomes_03(int _line)
	{
		if (procedDate[_line] != 318)
		{
			procedDate[_line] = 318;
			init(_line);
			setData(_line, 10, 0, 731);
			setData(_line, 31, 3, 255);
			setData(_line, 31, 0, 732);
			setData(_line, 32, 2, 0);
			setData(_line, 32, 5, 0);
		}
	}

	public static void YK_BAO_buchikama(int _line)
	{
		if (procedDate[_line] != 319)
		{
			procedDate[_line] = 319;
			init(_line);
			setData(_line, 0, 0, 733);
			setData(_line, 15, 3, 255);
			setData(_line, 15, 0, 734);
			setData(_line, 75, 2, 0);
			setData(_line, 75, 5, 0);
		}
	}

	public static void YK_BEM_01(int _line)
	{
		if (procedDate[_line] != 320)
		{
			procedDate[_line] = 320;
			init(_line);
			setData(_line, 0, 0, 735);
			setData(_line, 180, 3, 255);
			setData(_line, 180, 0, 749);
			setData(_line, 300, 2, 0);
			setData(_line, 300, 5, 0);
		}
	}

	public static void YK_BEM_02(int _line)
	{
		if (procedDate[_line] != 321)
		{
			procedDate[_line] = 321;
			init(_line);
			setData(_line, 0, 0, 736);
			setData(_line, 186, 3, 255);
			setData(_line, 186, 0, 751);
			setData(_line, 306, 2, 0);
			setData(_line, 306, 5, 0);
		}
	}

	public static void YK_BEM_03(int _line)
	{
		if (procedDate[_line] != 322)
		{
			procedDate[_line] = 322;
			init(_line);
			setData(_line, 0, 0, 737);
			setData(_line, 102, 3, 255);
			setData(_line, 102, 0, 751);
			setData(_line, 222, 2, 0);
			setData(_line, 222, 5, 0);
		}
	}

	public static void YK_BEM_04(int _line)
	{
		if (procedDate[_line] != 323)
		{
			procedDate[_line] = 323;
			init(_line);
			setData(_line, 0, 0, 738);
			setData(_line, 45, 3, 255);
			setData(_line, 45, 0, 751);
			setData(_line, 165, 2, 0);
			setData(_line, 165, 5, 0);
		}
	}

	public static void YK_BEM_05(int _line)
	{
		if (procedDate[_line] != 324)
		{
			procedDate[_line] = 324;
			init(_line);
			setData(_line, 0, 0, 739);
			setData(_line, 152, 3, 255);
			setData(_line, 152, 0, 749);
			setData(_line, 272, 2, 0);
			setData(_line, 272, 5, 0);
		}
	}

	public static void YK_BEM_06(int _line)
	{
		if (procedDate[_line] != 325)
		{
			procedDate[_line] = 325;
			init(_line);
			setData(_line, 0, 0, 740);
			setData(_line, 103, 3, 255);
			setData(_line, 103, 0, 751);
			setData(_line, 223, 2, 0);
			setData(_line, 223, 5, 0);
		}
	}

	public static void YK_BEM_07(int _line)
	{
		if (procedDate[_line] != 326)
		{
			procedDate[_line] = 326;
			init(_line);
			setData(_line, 0, 3, 255);
			setData(_line, 0, 0, 741);
			setData(_line, 92, 2, 0);
			setData(_line, 92, 5, 0);
		}
	}

	public static void YK_BEM_08(int _line)
	{
		if (procedDate[_line] != 327)
		{
			procedDate[_line] = 327;
			init(_line);
			setData(_line, 0, 0, 742);
			setData(_line, 84, 3, 255);
			setData(_line, 84, 0, 750);
			setData(_line, 204, 2, 0);
			setData(_line, 204, 5, 0);
		}
	}

	public static void YK_BEM_09(int _line)
	{
		if (procedDate[_line] != 328)
		{
			procedDate[_line] = 328;
			init(_line);
			setData(_line, 0, 0, 743);
			setData(_line, 141, 3, 255);
			setData(_line, 141, 0, 749);
			setData(_line, 261, 2, 0);
			setData(_line, 261, 5, 0);
		}
	}

	public static void YK_BEM_10(int _line)
	{
		if (procedDate[_line] != 329)
		{
			procedDate[_line] = 329;
			init(_line);
			setData(_line, 0, 0, 744);
			setData(_line, 150, 3, 255);
			setData(_line, 150, 0, 749);
			setData(_line, 270, 2, 0);
			setData(_line, 270, 5, 0);
		}
	}

	public static void YK_BEM_11(int _line)
	{
		if (procedDate[_line] != 330)
		{
			procedDate[_line] = 330;
			init(_line);
			setData(_line, 0, 0, 745);
			setData(_line, 210, 3, 255);
			setData(_line, 210, 0, 749);
			setData(_line, 330, 2, 0);
			setData(_line, 330, 5, 0);
		}
	}

	public static void YK_BEM_12(int _line)
	{
		if (procedDate[_line] != 331)
		{
			procedDate[_line] = 331;
			init(_line);
			setData(_line, 0, 0, 746);
			setData(_line, 150, 3, 255);
			setData(_line, 150, 0, 749);
			setData(_line, 270, 2, 0);
			setData(_line, 270, 5, 0);
		}
	}

	public static void YK_BEM_13(int _line)
	{
		if (procedDate[_line] != 332)
		{
			procedDate[_line] = 332;
			init(_line);
			setData(_line, 0, 0, 747);
			setData(_line, 133, 3, 255);
			setData(_line, 133, 0, 749);
			setData(_line, 253, 2, 0);
			setData(_line, 253, 5, 0);
		}
	}

	public static void YK_BEM_14(int _line)
	{
		if (procedDate[_line] != 333)
		{
			procedDate[_line] = 333;
			init(_line);
			setData(_line, 0, 0, 748);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 749);
			setData(_line, 150, 2, 0);
			setData(_line, 150, 5, 0);
		}
	}

	public static void YK_KBS_blue(int _line)
	{
		if (procedDate[_line] != 334)
		{
			procedDate[_line] = 334;
			init(_line);
			setData(_line, 0, 0, 752);
			setData(_line, 60, 3, 255);
			setData(_line, 60, 0, 753);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void YK_KBS_green(int _line)
	{
		if (procedDate[_line] != 335)
		{
			procedDate[_line] = 335;
			init(_line);
			setData(_line, 0, 0, 756);
			setData(_line, 60, 3, 255);
			setData(_line, 60, 0, 757);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void YK_KBS_red(int _line)
	{
		if (procedDate[_line] != 336)
		{
			procedDate[_line] = 336;
			init(_line);
			setData(_line, 0, 0, 758);
			setData(_line, 60, 3, 255);
			setData(_line, 60, 0, 759);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void YK_KBS_gold(int _line)
	{
		if (procedDate[_line] != 337)
		{
			procedDate[_line] = 337;
			init(_line);
			setData(_line, 0, 0, 754);
			setData(_line, 60, 3, 255);
			setData(_line, 60, 0, 755);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void YK_HOH(int _line)
	{
		if (procedDate[_line] != 338)
		{
			procedDate[_line] = 338;
			init(_line);
			setData(_line, 0, 0, 767);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void LG_YTK_white_01(int _line)
	{
		if (procedDate[_line] != 339)
		{
			procedDate[_line] = 339;
			init(_line);
			setData(_line, 0, 0, 809);
			setData(_line, 25, 4, 0);
			setData(_line, 25, 5, 0);
		}
	}

	public static void LG_YTK_white_02(int _line)
	{
		if (procedDate[_line] != 340)
		{
			procedDate[_line] = 340;
			init(_line);
			setData(_line, 0, 0, 810);
			setData(_line, 55, 4, 0);
			setData(_line, 55, 5, 0);
		}
	}

	public static void LG_YTK_blue_00(int _line)
	{
		if (procedDate[_line] != 341)
		{
			procedDate[_line] = 341;
			init(_line);
			setData(_line, 0, 0, 814);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void LG_YTK_blue_01(int _line)
	{
		if (procedDate[_line] != 342)
		{
			procedDate[_line] = 342;
			init(_line);
			setData(_line, 0, 0, 799);
			setData(_line, 25, 4, 0);
			setData(_line, 25, 5, 0);
		}
	}

	public static void LG_YTK_blue_02(int _line)
	{
		if (procedDate[_line] != 343)
		{
			procedDate[_line] = 343;
			init(_line);
			setData(_line, 0, 0, 800);
			setData(_line, 55, 4, 0);
			setData(_line, 55, 5, 0);
		}
	}

	public static void LG_YTK_yellow_01(int _line)
	{
		if (procedDate[_line] != 344)
		{
			procedDate[_line] = 344;
			init(_line);
			setData(_line, 0, 0, 811);
			setData(_line, 25, 4, 0);
			setData(_line, 25, 5, 0);
		}
	}

	public static void LG_YTK_yellow_02(int _line)
	{
		if (procedDate[_line] != 345)
		{
			procedDate[_line] = 345;
			init(_line);
			setData(_line, 0, 0, 812);
			setData(_line, 55, 4, 0);
			setData(_line, 55, 5, 0);
		}
	}

	public static void LG_YTK_green_01(int _line)
	{
		if (procedDate[_line] != 346)
		{
			procedDate[_line] = 346;
			init(_line);
			setData(_line, 0, 0, 801);
			setData(_line, 25, 4, 0);
			setData(_line, 25, 5, 0);
		}
	}

	public static void LG_YTK_green_02(int _line)
	{
		if (procedDate[_line] != 347)
		{
			procedDate[_line] = 347;
			init(_line);
			setData(_line, 0, 0, 802);
			setData(_line, 55, 4, 0);
			setData(_line, 55, 5, 0);
		}
	}

	public static void LG_YTK_red_00(int _line)
	{
		if (procedDate[_line] != 348)
		{
			procedDate[_line] = 348;
			init(_line);
			setData(_line, 0, 0, 815);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void LG_YTK_red_01(int _line)
	{
		if (procedDate[_line] != 349)
		{
			procedDate[_line] = 349;
			init(_line);
			setData(_line, 0, 0, 807);
			setData(_line, 25, 4, 0);
			setData(_line, 25, 5, 0);
		}
	}

	public static void LG_YTK_red_02(int _line)
	{
		if (procedDate[_line] != 350)
		{
			procedDate[_line] = 350;
			init(_line);
			setData(_line, 0, 0, 808);
			setData(_line, 55, 4, 0);
			setData(_line, 55, 5, 0);
		}
	}

	public static void LG_YTK_purple_01(int _line)
	{
		if (procedDate[_line] != 351)
		{
			procedDate[_line] = 351;
			init(_line);
			setData(_line, 0, 0, 803);
			setData(_line, 25, 4, 0);
			setData(_line, 25, 5, 0);
		}
	}

	public static void LG_YTK_purple_02(int _line)
	{
		if (procedDate[_line] != 352)
		{
			procedDate[_line] = 352;
			init(_line);
			setData(_line, 0, 0, 804);
			setData(_line, 55, 4, 0);
			setData(_line, 55, 5, 0);
		}
	}

	public static void LG_YTK_rainbow_01(int _line)
	{
		if (procedDate[_line] != 353)
		{
			procedDate[_line] = 353;
			init(_line);
			setData(_line, 0, 0, 805);
			setData(_line, 25, 4, 0);
			setData(_line, 25, 5, 0);
		}
	}

	public static void LG_YTK_rainbow_02(int _line)
	{
		if (procedDate[_line] != 354)
		{
			procedDate[_line] = 354;
			init(_line);
			setData(_line, 0, 0, 806);
			setData(_line, 55, 4, 0);
			setData(_line, 55, 5, 0);
		}
	}

	public static void LG_HOH_sol_first_low_01(int _line)
	{
		if (procedDate[_line] != 355)
		{
			procedDate[_line] = 355;
			init(_line);
			setData(_line, 25, 0, 813);
			setData(_line, 55, 4, 0);
			setData(_line, 55, 5, 0);
		}
	}

	public static void LG_HOH_sol_first_low_02(int _line)
	{
		if (procedDate[_line] != 356)
		{
			procedDate[_line] = 356;
			init(_line);
			setData(_line, 79, 0, 813);
			setData(_line, 109, 4, 0);
			setData(_line, 109, 5, 0);
		}
	}

	public static void LG_HOH_sol_first_high_01(int _line)
	{
		if (procedDate[_line] != 357)
		{
			procedDate[_line] = 357;
			init(_line);
			setData(_line, 34, 0, 813);
			setData(_line, 64, 0, 813);
			setData(_line, 84, 4, 0);
			setData(_line, 84, 5, 0);
		}
	}

	public static void LG_HOH_sol_first_high_02(int _line)
	{
		if (procedDate[_line] != 358)
		{
			procedDate[_line] = 358;
			init(_line);
			setData(_line, 88, 0, 813);
			setData(_line, 118, 0, 813);
			setData(_line, 138, 4, 0);
			setData(_line, 138, 5, 0);
		}
	}

	public static void LG_HOH_sol_first_push(int _line)
	{
		if (procedDate[_line] != 359)
		{
			procedDate[_line] = 359;
			init(_line);
			setData(_line, 20, 0, 813);
			setData(_line, 50, 0, 813);
			setData(_line, 70, 4, 0);
			setData(_line, 70, 5, 0);
		}
	}

	public static void LG_HOH_sol_counter(int _line)
	{
		if (procedDate[_line] != 360)
		{
			procedDate[_line] = 360;
			init(_line);
			setData(_line, 0, 0, 813);
			setData(_line, 30, 4, 0);
			setData(_line, 30, 5, 0);
		}
	}

	public static void LG_hatten_HIT(int _line)
	{
		if (procedDate[_line] != 361)
		{
			procedDate[_line] = 361;
			init(_line);
			setData(_line, 0, 0, 816);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 817);
			setData(_line, 31, 2, 0);
			setData(_line, 31, 5, 0);
		}
	}

	public static void LG_hatten_JYD_HIT(int _line)
	{
		if (procedDate[_line] != 362)
		{
			procedDate[_line] = 362;
			init(_line);
			setData(_line, 72, 0, 816);
			setData(_line, 102, 3, 255);
			setData(_line, 102, 0, 817);
			setData(_line, 103, 2, 0);
			setData(_line, 103, 5, 0);
		}
	}

	public static void LG_BAO_sol_standup(int _line)
	{
		if (procedDate[_line] != 363)
		{
			procedDate[_line] = 363;
			init(_line);
			setData(_line, 0, 0, 813);
			setData(_line, 30, 2, 0);
			setData(_line, 50, 5, 0);
		}
	}

	public static void LG_BAO_sol_first_01(int _line)
	{
		if (procedDate[_line] != 364)
		{
			procedDate[_line] = 364;
			init(_line);
			setData(_line, 19, 0, 813);
			setData(_line, 49, 2, 0);
			setData(_line, 49, 5, 0);
		}
	}

	public static void LG_BAO_sol_first_02(int _line)
	{
		if (procedDate[_line] != 365)
		{
			procedDate[_line] = 365;
			init(_line);
			setData(_line, 15, 0, 813);
			setData(_line, 45, 2, 0);
			setData(_line, 45, 5, 0);
		}
	}

	public static void LG_KHO_crash(int _line)
	{
		if (procedDate[_line] != 366)
		{
			procedDate[_line] = 366;
			init(_line);
			setData(_line, 7, 0, 818);
			setData(_line, 23, 4, 0);
			setData(_line, 23, 5, 0);
		}
	}

	public static void CG_YTK_white_01(int _line)
	{
		if (procedDate[_line] != 367)
		{
			procedDate[_line] = 367;
			init(_line);
			setData(_line, 0, 0, 248);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 250);
			setData(_line, 31, 2, 0);
			setData(_line, 31, 5, 0);
		}
	}

	public static void CG_YTK_white_02(int _line)
	{
		if (procedDate[_line] != 368)
		{
			procedDate[_line] = 368;
			init(_line);
			setData(_line, 0, 0, 249);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 250);
			setData(_line, 31, 2, 0);
			setData(_line, 31, 5, 0);
		}
	}

	public static void CG_YTK_blue_01(int _line)
	{
		if (procedDate[_line] != 369)
		{
			procedDate[_line] = 369;
			init(_line);
			setData(_line, 0, 0, 233);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 235);
			setData(_line, 31, 2, 0);
			setData(_line, 31, 5, 0);
		}
	}

	public static void CG_YTK_blue_02(int _line)
	{
		if (procedDate[_line] != 370)
		{
			procedDate[_line] = 370;
			init(_line);
			setData(_line, 0, 0, 234);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 235);
			setData(_line, 31, 2, 0);
			setData(_line, 31, 5, 0);
		}
	}

	public static void CG_YTK_yellow_01(int _line)
	{
		if (procedDate[_line] != 371)
		{
			procedDate[_line] = 371;
			init(_line);
			setData(_line, 0, 0, 251);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 253);
			setData(_line, 31, 2, 0);
			setData(_line, 31, 5, 0);
		}
	}

	public static void CG_YTK_yellow_02(int _line)
	{
		if (procedDate[_line] != 372)
		{
			procedDate[_line] = 372;
			init(_line);
			setData(_line, 0, 0, 252);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 253);
			setData(_line, 31, 2, 0);
			setData(_line, 31, 5, 0);
		}
	}

	public static void CG_YTK_green_01(int _line)
	{
		if (procedDate[_line] != 373)
		{
			procedDate[_line] = 373;
			init(_line);
			setData(_line, 0, 0, 236);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 238);
			setData(_line, 31, 2, 0);
			setData(_line, 31, 5, 0);
		}
	}

	public static void CG_YTK_green_02(int _line)
	{
		if (procedDate[_line] != 374)
		{
			procedDate[_line] = 374;
			init(_line);
			setData(_line, 0, 0, 237);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 238);
			setData(_line, 31, 2, 0);
			setData(_line, 31, 5, 0);
		}
	}

	public static void CG_YTK_red_01(int _line)
	{
		if (procedDate[_line] != 375)
		{
			procedDate[_line] = 375;
			init(_line);
			setData(_line, 0, 0, 245);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 247);
			setData(_line, 31, 2, 0);
			setData(_line, 31, 5, 0);
		}
	}

	public static void CG_YTK_red_02(int _line)
	{
		if (procedDate[_line] != 376)
		{
			procedDate[_line] = 376;
			init(_line);
			setData(_line, 0, 0, 246);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 247);
			setData(_line, 31, 2, 0);
			setData(_line, 31, 5, 0);
		}
	}

	public static void CG_YTK_purple_01(int _line)
	{
		if (procedDate[_line] != 377)
		{
			procedDate[_line] = 377;
			init(_line);
			setData(_line, 0, 0, 239);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 241);
			setData(_line, 31, 2, 0);
			setData(_line, 31, 5, 0);
		}
	}

	public static void CG_YTK_purple_02(int _line)
	{
		if (procedDate[_line] != 378)
		{
			procedDate[_line] = 378;
			init(_line);
			setData(_line, 0, 0, 240);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 241);
			setData(_line, 31, 2, 0);
			setData(_line, 31, 5, 0);
		}
	}

	public static void CG_YTK_rainbow_01(int _line)
	{
		if (procedDate[_line] != 379)
		{
			procedDate[_line] = 379;
			init(_line);
			setData(_line, 0, 0, 242);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 244);
			setData(_line, 60, 2, 0);
			setData(_line, 60, 5, 0);
		}
	}

	public static void CG_YTK_rainbow_02(int _line)
	{
		if (procedDate[_line] != 380)
		{
			procedDate[_line] = 380;
			init(_line);
			setData(_line, 0, 0, 243);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 244);
			setData(_line, 60, 2, 0);
			setData(_line, 60, 5, 0);
		}
	}

	public static void CG_YTG_lever(int _line)
	{
		if (procedDate[_line] != 381)
		{
			procedDate[_line] = 381;
			init(_line);
			setData(_line, 0, 0, 264);
			setData(_line, 30, 2, 0);
			setData(_line, 30, 5, 0);
		}
	}

	public static void CG_YTG_charge_01(int _line)
	{
		if (procedDate[_line] != 382)
		{
			procedDate[_line] = 382;
			init(_line);
			setData(_line, 0, 0, 258);
			setData(_line, 30, 2, 0);
			setData(_line, 30, 5, 0);
		}
	}

	public static void CG_YTG_charge_02(int _line)
	{
		if (procedDate[_line] != 383)
		{
			procedDate[_line] = 383;
			init(_line);
			setData(_line, 0, 0, 259);
			setData(_line, 30, 2, 0);
			setData(_line, 30, 5, 0);
		}
	}

	public static void CG_YTG_next(int _line)
	{
		if (procedDate[_line] != 384)
		{
			procedDate[_line] = 384;
			init(_line);
			setData(_line, 0, 0, 267);
			setData(_line, 20, 2, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void CG_YTG_lose(int _line)
	{
		if (procedDate[_line] != 385)
		{
			procedDate[_line] = 385;
			init(_line);
			setData(_line, 0, 0, 270);
			setData(_line, 50, 0, 265);
			setData(_line, 80, 3, 255);
			setData(_line, 80, 0, 266);
			setData(_line, 81, 2, 0);
			setData(_line, 81, 5, 0);
		}
	}

	public static void CG_YTG_BD(int _line)
	{
		if (procedDate[_line] != 386)
		{
			procedDate[_line] = 386;
			init(_line);
			setData(_line, 0, 0, 270);
			setData(_line, 50, 0, 254);
			setData(_line, 65, 3, 255);
			setData(_line, 65, 0, 255);
			setData(_line, 66, 2, 0);
			setData(_line, 66, 5, 0);
		}
	}

	public static void CG_YTG_HOH(int _line)
	{
		if (procedDate[_line] != 387)
		{
			procedDate[_line] = 387;
			init(_line);
			setData(_line, 0, 0, 270);
			setData(_line, 45, 0, 260);
			setData(_line, 60, 3, 255);
			setData(_line, 60, 0, 261);
			setData(_line, 61, 2, 0);
			setData(_line, 61, 5, 0);
		}
	}

	public static void CG_YTG_JST(int _line)
	{
		if (procedDate[_line] != 388)
		{
			procedDate[_line] = 388;
			init(_line);
			setData(_line, 0, 0, 270);
			setData(_line, 40, 0, 262);
			setData(_line, 55, 3, 255);
			setData(_line, 55, 0, 263);
			setData(_line, 56, 2, 0);
			setData(_line, 56, 5, 0);
		}
	}

	public static void CG_YTG_rainbow(int _line)
	{
		if (procedDate[_line] != 389)
		{
			procedDate[_line] = 389;
			init(_line);
			setData(_line, 0, 0, 270);
			setData(_line, 60, 0, 268);
			setData(_line, 120, 3, 255);
			setData(_line, 120, 0, 269);
			setData(_line, 180, 2, 0);
			setData(_line, 180, 5, 0);
		}
	}

	public static void CG_YTG_JYD_BD(int _line)
	{
		if (procedDate[_line] != 390)
		{
			procedDate[_line] = 390;
			init(_line);
			setData(_line, 0, 0, 270);
			setData(_line, 95, 0, 254);
			setData(_line, 110, 3, 255);
			setData(_line, 110, 0, 255);
			setData(_line, 111, 2, 0);
			setData(_line, 111, 5, 0);
		}
	}

	public static void CG_YTG_JYD_rainbow(int _line)
	{
		if (procedDate[_line] != 391)
		{
			procedDate[_line] = 391;
			init(_line);
			setData(_line, 0, 0, 270);
			setData(_line, 105, 0, 268);
			setData(_line, 165, 3, 255);
			setData(_line, 165, 0, 269);
			setData(_line, 225, 2, 0);
			setData(_line, 225, 5, 0);
		}
	}

	public static void CG_YTG_BONUS(int _line)
	{
		if (procedDate[_line] != 392)
		{
			procedDate[_line] = 392;
			init(_line);
			setData(_line, 0, 0, 270);
			setData(_line, 60, 0, 256);
			setData(_line, 120, 3, 255);
			setData(_line, 120, 0, 257);
			setData(_line, 180, 2, 0);
			setData(_line, 180, 5, 0);
		}
	}

	public static void CG_BZT_end(int _line)
	{
		if (procedDate[_line] != 393)
		{
			procedDate[_line] = 393;
			init(_line);
			setData(_line, 0, 0, 271);
			setData(_line, 15, 3, 255);
			setData(_line, 15, 0, 272);
			setData(_line, 16, 2, 0);
			setData(_line, 16, 5, 0);
		}
	}

	public static void CG_JKB_end(int _line)
	{
		if (procedDate[_line] != 394)
		{
			procedDate[_line] = 394;
			init(_line);
			setData(_line, 30, 0, 273);
			setData(_line, 45, 3, 255);
			setData(_line, 45, 0, 274);
			setData(_line, 46, 2, 0);
			setData(_line, 46, 5, 0);
		}
	}

	public static void DG_TEN_0_loop(int _line)
	{
		if (procedDate[_line] != 395)
		{
			procedDate[_line] = 395;
			init(_line);
			setData(_line, 0, 0, 297);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_TEN_0to1(int _line)
	{
		if (procedDate[_line] != 396)
		{
			procedDate[_line] = 396;
			init(_line);
			setData(_line, 0, 0, 298);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 303);
			setData(_line, 31, 2, 0);
			setData(_line, 31, 5, 0);
		}
	}

	public static void DG_TEN_0to2(int _line)
	{
		if (procedDate[_line] != 397)
		{
			procedDate[_line] = 397;
			init(_line);
			setData(_line, 0, 0, 299);
			setData(_line, 42, 3, 255);
			setData(_line, 42, 0, 308);
			setData(_line, 43, 2, 0);
			setData(_line, 43, 5, 0);
		}
	}

	public static void DG_TEN_0to3(int _line)
	{
		if (procedDate[_line] != 398)
		{
			procedDate[_line] = 398;
			init(_line);
			setData(_line, 0, 0, 300);
			setData(_line, 54, 3, 255);
			setData(_line, 54, 0, 312);
			setData(_line, 55, 2, 0);
			setData(_line, 55, 5, 0);
		}
	}

	public static void DG_TEN_0to4(int _line)
	{
		if (procedDate[_line] != 399)
		{
			procedDate[_line] = 399;
			init(_line);
			setData(_line, 0, 0, 301);
			setData(_line, 66, 3, 255);
			setData(_line, 66, 0, 315);
			setData(_line, 67, 2, 0);
			setData(_line, 67, 5, 0);
		}
	}

	public static void DG_TEN_0to5(int _line)
	{
		if (procedDate[_line] != 400)
		{
			procedDate[_line] = 400;
			init(_line);
			setData(_line, 0, 0, 302);
			setData(_line, 78, 3, 255);
			setData(_line, 78, 0, 317);
			setData(_line, 80, 2, 0);
			setData(_line, 80, 5, 0);
		}
	}

	public static void DG_TEN_1_loop(int _line)
	{
		if (procedDate[_line] != 401)
		{
			procedDate[_line] = 401;
			init(_line);
			setData(_line, 0, 0, 303);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_TEN_1to2(int _line)
	{
		if (procedDate[_line] != 402)
		{
			procedDate[_line] = 402;
			init(_line);
			setData(_line, 0, 0, 304);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 308);
			setData(_line, 31, 2, 0);
			setData(_line, 31, 5, 0);
		}
	}

	public static void DG_TEN_1to3(int _line)
	{
		if (procedDate[_line] != 403)
		{
			procedDate[_line] = 403;
			init(_line);
			setData(_line, 0, 0, 305);
			setData(_line, 42, 3, 255);
			setData(_line, 42, 0, 312);
			setData(_line, 43, 2, 0);
			setData(_line, 43, 5, 0);
		}
	}

	public static void DG_TEN_1to4(int _line)
	{
		if (procedDate[_line] != 404)
		{
			procedDate[_line] = 404;
			init(_line);
			setData(_line, 0, 0, 306);
			setData(_line, 54, 3, 255);
			setData(_line, 54, 0, 315);
			setData(_line, 55, 2, 0);
			setData(_line, 55, 5, 0);
		}
	}

	public static void DG_TEN_1to5(int _line)
	{
		if (procedDate[_line] != 405)
		{
			procedDate[_line] = 405;
			init(_line);
			setData(_line, 0, 0, 307);
			setData(_line, 66, 3, 255);
			setData(_line, 66, 0, 317);
			setData(_line, 68, 2, 0);
			setData(_line, 68, 5, 0);
		}
	}

	public static void DG_TEN_2_loop(int _line)
	{
		if (procedDate[_line] != 406)
		{
			procedDate[_line] = 406;
			init(_line);
			setData(_line, 0, 0, 308);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_TEN_2to3(int _line)
	{
		if (procedDate[_line] != 407)
		{
			procedDate[_line] = 407;
			init(_line);
			setData(_line, 0, 0, 309);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 312);
			setData(_line, 31, 2, 0);
			setData(_line, 31, 5, 0);
		}
	}

	public static void DG_TEN_2to4(int _line)
	{
		if (procedDate[_line] != 408)
		{
			procedDate[_line] = 408;
			init(_line);
			setData(_line, 0, 0, 310);
			setData(_line, 42, 3, 255);
			setData(_line, 42, 0, 315);
			setData(_line, 43, 2, 0);
			setData(_line, 43, 5, 0);
		}
	}

	public static void DG_TEN_2to5(int _line)
	{
		if (procedDate[_line] != 409)
		{
			procedDate[_line] = 409;
			init(_line);
			setData(_line, 0, 0, 311);
			setData(_line, 54, 3, 255);
			setData(_line, 54, 0, 317);
			setData(_line, 56, 2, 0);
			setData(_line, 56, 5, 0);
		}
	}

	public static void DG_TEN_3_loop(int _line)
	{
		if (procedDate[_line] != 410)
		{
			procedDate[_line] = 410;
			init(_line);
			setData(_line, 0, 0, 312);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_TEN_3to4(int _line)
	{
		if (procedDate[_line] != 411)
		{
			procedDate[_line] = 411;
			init(_line);
			setData(_line, 0, 0, 313);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 315);
			setData(_line, 31, 2, 0);
			setData(_line, 31, 5, 0);
		}
	}

	public static void DG_TEN_3to5(int _line)
	{
		if (procedDate[_line] != 412)
		{
			procedDate[_line] = 412;
			init(_line);
			setData(_line, 0, 0, 314);
			setData(_line, 42, 3, 255);
			setData(_line, 42, 0, 317);
			setData(_line, 44, 2, 0);
			setData(_line, 44, 5, 0);
		}
	}

	public static void DG_TEN_4_loop(int _line)
	{
		if (procedDate[_line] != 413)
		{
			procedDate[_line] = 413;
			init(_line);
			setData(_line, 0, 0, 315);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_TEN_4to5(int _line)
	{
		if (procedDate[_line] != 414)
		{
			procedDate[_line] = 414;
			init(_line);
			setData(_line, 0, 0, 316);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 317);
			setData(_line, 32, 2, 0);
			setData(_line, 32, 5, 0);
		}
	}

	public static void DG_TEN_5_loop(int _line)
	{
		if (procedDate[_line] != 415)
		{
			procedDate[_line] = 415;
			init(_line);
			setData(_line, 0, 0, 317);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void DG_TEN_5to0(int _line)
	{
		if (procedDate[_line] != 416)
		{
			procedDate[_line] = 416;
			init(_line);
			setData(_line, 0, 0, 318);
			setData(_line, 15, 3, 255);
			setData(_line, 15, 0, 297);
			setData(_line, 16, 2, 0);
			setData(_line, 16, 5, 0);
		}
	}

	public static void DG_POW1_white_get(int _line)
	{
		if (procedDate[_line] != 417)
		{
			procedDate[_line] = 417;
			init(_line);
			setData(_line, 0, 0, 340);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 341);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW1_white_loop(int _line)
	{
		if (procedDate[_line] != 418)
		{
			procedDate[_line] = 418;
			init(_line);
			setData(_line, 0, 0, 341);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW1_white_blink(int _line)
	{
		if (procedDate[_line] != 419)
		{
			procedDate[_line] = 419;
			init(_line);
			setData(_line, 0, 0, 339);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW1_white_off(int _line)
	{
		if (procedDate[_line] != 420)
		{
			procedDate[_line] = 420;
			init(_line);
			setData(_line, 0, 0, 342);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW1_blue_get(int _line)
	{
		if (procedDate[_line] != 421)
		{
			procedDate[_line] = 421;
			init(_line);
			setData(_line, 0, 0, 320);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 321);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW1_blue_loop(int _line)
	{
		if (procedDate[_line] != 422)
		{
			procedDate[_line] = 422;
			init(_line);
			setData(_line, 0, 0, 321);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW1_blue_blink(int _line)
	{
		if (procedDate[_line] != 423)
		{
			procedDate[_line] = 423;
			init(_line);
			setData(_line, 0, 0, 319);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW1_blue_off(int _line)
	{
		if (procedDate[_line] != 424)
		{
			procedDate[_line] = 424;
			init(_line);
			setData(_line, 0, 0, 322);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW1_yellow_get(int _line)
	{
		if (procedDate[_line] != 425)
		{
			procedDate[_line] = 425;
			init(_line);
			setData(_line, 0, 0, 344);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 345);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW1_yellow_loop(int _line)
	{
		if (procedDate[_line] != 426)
		{
			procedDate[_line] = 426;
			init(_line);
			setData(_line, 0, 0, 345);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW1_yellow_blink(int _line)
	{
		if (procedDate[_line] != 427)
		{
			procedDate[_line] = 427;
			init(_line);
			setData(_line, 0, 0, 343);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW1_yellow_off(int _line)
	{
		if (procedDate[_line] != 428)
		{
			procedDate[_line] = 428;
			init(_line);
			setData(_line, 0, 0, 346);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW1_green_get(int _line)
	{
		if (procedDate[_line] != 429)
		{
			procedDate[_line] = 429;
			init(_line);
			setData(_line, 0, 0, 324);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 325);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW1_green_loop(int _line)
	{
		if (procedDate[_line] != 430)
		{
			procedDate[_line] = 430;
			init(_line);
			setData(_line, 0, 0, 325);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW1_green_blink(int _line)
	{
		if (procedDate[_line] != 431)
		{
			procedDate[_line] = 431;
			init(_line);
			setData(_line, 0, 0, 323);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW1_green_off(int _line)
	{
		if (procedDate[_line] != 432)
		{
			procedDate[_line] = 432;
			init(_line);
			setData(_line, 0, 0, 326);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW1_red_get(int _line)
	{
		if (procedDate[_line] != 433)
		{
			procedDate[_line] = 433;
			init(_line);
			setData(_line, 0, 0, 336);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 337);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW1_red_loop(int _line)
	{
		if (procedDate[_line] != 434)
		{
			procedDate[_line] = 434;
			init(_line);
			setData(_line, 0, 0, 337);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW1_red_blink(int _line)
	{
		if (procedDate[_line] != 435)
		{
			procedDate[_line] = 435;
			init(_line);
			setData(_line, 0, 0, 335);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW1_red_off(int _line)
	{
		if (procedDate[_line] != 436)
		{
			procedDate[_line] = 436;
			init(_line);
			setData(_line, 0, 0, 338);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW1_purple_get(int _line)
	{
		if (procedDate[_line] != 437)
		{
			procedDate[_line] = 437;
			init(_line);
			setData(_line, 0, 0, 328);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 329);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW1_purple_loop(int _line)
	{
		if (procedDate[_line] != 438)
		{
			procedDate[_line] = 438;
			init(_line);
			setData(_line, 0, 0, 329);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW1_purple_blink(int _line)
	{
		if (procedDate[_line] != 439)
		{
			procedDate[_line] = 439;
			init(_line);
			setData(_line, 0, 0, 327);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW1_purple_off(int _line)
	{
		if (procedDate[_line] != 440)
		{
			procedDate[_line] = 440;
			init(_line);
			setData(_line, 0, 0, 330);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW1_rainbow_get(int _line)
	{
		if (procedDate[_line] != 441)
		{
			procedDate[_line] = 441;
			init(_line);
			setData(_line, 0, 0, 332);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 333);
			setData(_line, 63, 2, 0);
			setData(_line, 63, 5, 0);
		}
	}

	public static void DG_POW1_rainbow_loop(int _line)
	{
		if (procedDate[_line] != 442)
		{
			procedDate[_line] = 442;
			init(_line);
			setData(_line, 0, 0, 333);
			setData(_line, 30, 2, 0);
			setData(_line, 30, 5, 0);
		}
	}

	public static void DG_POW1_rainbow_blink(int _line)
	{
		if (procedDate[_line] != 443)
		{
			procedDate[_line] = 443;
			init(_line);
			setData(_line, 0, 0, 331);
			setData(_line, 30, 2, 0);
			setData(_line, 30, 5, 0);
		}
	}

	public static void DG_POW1_rainbow_off(int _line)
	{
		if (procedDate[_line] != 444)
		{
			procedDate[_line] = 444;
			init(_line);
			setData(_line, 0, 0, 334);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW2_white_get(int _line)
	{
		if (procedDate[_line] != 445)
		{
			procedDate[_line] = 445;
			init(_line);
			setData(_line, 0, 0, 340);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 341);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW2_white_loop(int _line)
	{
		if (procedDate[_line] != 446)
		{
			procedDate[_line] = 446;
			init(_line);
			setData(_line, 0, 0, 341);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW2_white_blink(int _line)
	{
		if (procedDate[_line] != 447)
		{
			procedDate[_line] = 447;
			init(_line);
			setData(_line, 0, 0, 339);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW2_white_off(int _line)
	{
		if (procedDate[_line] != 448)
		{
			procedDate[_line] = 448;
			init(_line);
			setData(_line, 0, 0, 342);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW2_blue_get(int _line)
	{
		if (procedDate[_line] != 449)
		{
			procedDate[_line] = 449;
			init(_line);
			setData(_line, 0, 0, 320);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 321);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW2_blue_loop(int _line)
	{
		if (procedDate[_line] != 450)
		{
			procedDate[_line] = 450;
			init(_line);
			setData(_line, 0, 0, 321);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW2_blue_blink(int _line)
	{
		if (procedDate[_line] != 451)
		{
			procedDate[_line] = 451;
			init(_line);
			setData(_line, 0, 0, 319);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW2_blue_off(int _line)
	{
		if (procedDate[_line] != 452)
		{
			procedDate[_line] = 452;
			init(_line);
			setData(_line, 0, 0, 322);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW2_yellow_get(int _line)
	{
		if (procedDate[_line] != 453)
		{
			procedDate[_line] = 453;
			init(_line);
			setData(_line, 0, 0, 344);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 345);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW2_yellow_loop(int _line)
	{
		if (procedDate[_line] != 454)
		{
			procedDate[_line] = 454;
			init(_line);
			setData(_line, 0, 0, 345);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW2_yellow_blink(int _line)
	{
		if (procedDate[_line] != 455)
		{
			procedDate[_line] = 455;
			init(_line);
			setData(_line, 0, 0, 343);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW2_yellow_off(int _line)
	{
		if (procedDate[_line] != 456)
		{
			procedDate[_line] = 456;
			init(_line);
			setData(_line, 0, 0, 346);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW2_green_get(int _line)
	{
		if (procedDate[_line] != 457)
		{
			procedDate[_line] = 457;
			init(_line);
			setData(_line, 0, 0, 324);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 325);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW2_green_loop(int _line)
	{
		if (procedDate[_line] != 458)
		{
			procedDate[_line] = 458;
			init(_line);
			setData(_line, 0, 0, 325);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW2_green_blink(int _line)
	{
		if (procedDate[_line] != 459)
		{
			procedDate[_line] = 459;
			init(_line);
			setData(_line, 0, 0, 323);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW2_green_off(int _line)
	{
		if (procedDate[_line] != 460)
		{
			procedDate[_line] = 460;
			init(_line);
			setData(_line, 0, 0, 326);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW2_red_get(int _line)
	{
		if (procedDate[_line] != 461)
		{
			procedDate[_line] = 461;
			init(_line);
			setData(_line, 0, 0, 336);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 337);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW2_red_loop(int _line)
	{
		if (procedDate[_line] != 462)
		{
			procedDate[_line] = 462;
			init(_line);
			setData(_line, 0, 0, 337);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW2_red_blink(int _line)
	{
		if (procedDate[_line] != 463)
		{
			procedDate[_line] = 463;
			init(_line);
			setData(_line, 0, 0, 335);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW2_red_off(int _line)
	{
		if (procedDate[_line] != 464)
		{
			procedDate[_line] = 464;
			init(_line);
			setData(_line, 0, 0, 338);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW2_purple_get(int _line)
	{
		if (procedDate[_line] != 465)
		{
			procedDate[_line] = 465;
			init(_line);
			setData(_line, 0, 0, 328);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 329);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW2_purple_loop(int _line)
	{
		if (procedDate[_line] != 466)
		{
			procedDate[_line] = 466;
			init(_line);
			setData(_line, 0, 0, 329);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW2_purple_blink(int _line)
	{
		if (procedDate[_line] != 467)
		{
			procedDate[_line] = 467;
			init(_line);
			setData(_line, 0, 0, 327);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW2_purple_off(int _line)
	{
		if (procedDate[_line] != 468)
		{
			procedDate[_line] = 468;
			init(_line);
			setData(_line, 0, 0, 330);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW2_rainbow_get(int _line)
	{
		if (procedDate[_line] != 469)
		{
			procedDate[_line] = 469;
			init(_line);
			setData(_line, 0, 0, 332);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 333);
			setData(_line, 63, 2, 0);
			setData(_line, 63, 5, 0);
		}
	}

	public static void DG_POW2_rainbow_loop(int _line)
	{
		if (procedDate[_line] != 470)
		{
			procedDate[_line] = 470;
			init(_line);
			setData(_line, 0, 0, 333);
			setData(_line, 30, 2, 0);
			setData(_line, 30, 5, 0);
		}
	}

	public static void DG_POW2_rainbow_blink(int _line)
	{
		if (procedDate[_line] != 471)
		{
			procedDate[_line] = 471;
			init(_line);
			setData(_line, 0, 0, 331);
			setData(_line, 30, 2, 0);
			setData(_line, 30, 5, 0);
		}
	}

	public static void DG_POW2_rainbow_off(int _line)
	{
		if (procedDate[_line] != 472)
		{
			procedDate[_line] = 472;
			init(_line);
			setData(_line, 0, 0, 334);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW3_white_get(int _line)
	{
		if (procedDate[_line] != 473)
		{
			procedDate[_line] = 473;
			init(_line);
			setData(_line, 0, 0, 340);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 341);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW3_white_loop(int _line)
	{
		if (procedDate[_line] != 474)
		{
			procedDate[_line] = 474;
			init(_line);
			setData(_line, 0, 0, 341);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW3_white_blink(int _line)
	{
		if (procedDate[_line] != 475)
		{
			procedDate[_line] = 475;
			init(_line);
			setData(_line, 0, 0, 339);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW3_white_off(int _line)
	{
		if (procedDate[_line] != 476)
		{
			procedDate[_line] = 476;
			init(_line);
			setData(_line, 0, 0, 342);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW3_blue_get(int _line)
	{
		if (procedDate[_line] != 477)
		{
			procedDate[_line] = 477;
			init(_line);
			setData(_line, 0, 0, 320);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 321);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW3_blue_loop(int _line)
	{
		if (procedDate[_line] != 478)
		{
			procedDate[_line] = 478;
			init(_line);
			setData(_line, 0, 0, 321);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW3_blue_blink(int _line)
	{
		if (procedDate[_line] != 479)
		{
			procedDate[_line] = 479;
			init(_line);
			setData(_line, 0, 0, 319);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW3_blue_off(int _line)
	{
		if (procedDate[_line] != 480)
		{
			procedDate[_line] = 480;
			init(_line);
			setData(_line, 0, 0, 322);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW3_yellow_get(int _line)
	{
		if (procedDate[_line] != 481)
		{
			procedDate[_line] = 481;
			init(_line);
			setData(_line, 0, 0, 344);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 345);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW3_yellow_loop(int _line)
	{
		if (procedDate[_line] != 482)
		{
			procedDate[_line] = 482;
			init(_line);
			setData(_line, 0, 0, 345);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW3_yellow_blink(int _line)
	{
		if (procedDate[_line] != 483)
		{
			procedDate[_line] = 483;
			init(_line);
			setData(_line, 0, 0, 343);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW3_yellow_off(int _line)
	{
		if (procedDate[_line] != 484)
		{
			procedDate[_line] = 484;
			init(_line);
			setData(_line, 0, 0, 346);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW3_green_get(int _line)
	{
		if (procedDate[_line] != 485)
		{
			procedDate[_line] = 485;
			init(_line);
			setData(_line, 0, 0, 324);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 325);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW3_green_loop(int _line)
	{
		if (procedDate[_line] != 486)
		{
			procedDate[_line] = 486;
			init(_line);
			setData(_line, 0, 0, 325);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW3_green_blink(int _line)
	{
		if (procedDate[_line] != 487)
		{
			procedDate[_line] = 487;
			init(_line);
			setData(_line, 0, 0, 323);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW3_green_off(int _line)
	{
		if (procedDate[_line] != 488)
		{
			procedDate[_line] = 488;
			init(_line);
			setData(_line, 0, 0, 326);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW3_red_get(int _line)
	{
		if (procedDate[_line] != 489)
		{
			procedDate[_line] = 489;
			init(_line);
			setData(_line, 0, 0, 336);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 337);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW3_red_loop(int _line)
	{
		if (procedDate[_line] != 490)
		{
			procedDate[_line] = 490;
			init(_line);
			setData(_line, 0, 0, 337);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW3_red_blink(int _line)
	{
		if (procedDate[_line] != 491)
		{
			procedDate[_line] = 491;
			init(_line);
			setData(_line, 0, 0, 335);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW3_red_off(int _line)
	{
		if (procedDate[_line] != 492)
		{
			procedDate[_line] = 492;
			init(_line);
			setData(_line, 0, 0, 338);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW3_purple_get(int _line)
	{
		if (procedDate[_line] != 493)
		{
			procedDate[_line] = 493;
			init(_line);
			setData(_line, 0, 0, 328);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 329);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW3_purple_loop(int _line)
	{
		if (procedDate[_line] != 494)
		{
			procedDate[_line] = 494;
			init(_line);
			setData(_line, 0, 0, 329);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW3_purple_blink(int _line)
	{
		if (procedDate[_line] != 495)
		{
			procedDate[_line] = 495;
			init(_line);
			setData(_line, 0, 0, 327);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW3_purple_off(int _line)
	{
		if (procedDate[_line] != 496)
		{
			procedDate[_line] = 496;
			init(_line);
			setData(_line, 0, 0, 330);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW3_rainbow_get(int _line)
	{
		if (procedDate[_line] != 497)
		{
			procedDate[_line] = 497;
			init(_line);
			setData(_line, 0, 0, 332);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 333);
			setData(_line, 63, 2, 0);
			setData(_line, 63, 5, 0);
		}
	}

	public static void DG_POW3_rainbow_loop(int _line)
	{
		if (procedDate[_line] != 498)
		{
			procedDate[_line] = 498;
			init(_line);
			setData(_line, 0, 0, 333);
			setData(_line, 30, 2, 0);
			setData(_line, 30, 5, 0);
		}
	}

	public static void DG_POW3_rainbow_blink(int _line)
	{
		if (procedDate[_line] != 499)
		{
			procedDate[_line] = 499;
			init(_line);
			setData(_line, 0, 0, 331);
			setData(_line, 30, 2, 0);
			setData(_line, 30, 5, 0);
		}
	}

	public static void DG_POW3_rainbow_off(int _line)
	{
		if (procedDate[_line] != 500)
		{
			procedDate[_line] = 500;
			init(_line);
			setData(_line, 0, 0, 334);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW4_white_get(int _line)
	{
		if (procedDate[_line] != 501)
		{
			procedDate[_line] = 501;
			init(_line);
			setData(_line, 0, 0, 340);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 341);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW4_white_loop(int _line)
	{
		if (procedDate[_line] != 502)
		{
			procedDate[_line] = 502;
			init(_line);
			setData(_line, 0, 0, 341);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW4_white_blink(int _line)
	{
		if (procedDate[_line] != 503)
		{
			procedDate[_line] = 503;
			init(_line);
			setData(_line, 0, 0, 339);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW4_white_off(int _line)
	{
		if (procedDate[_line] != 504)
		{
			procedDate[_line] = 504;
			init(_line);
			setData(_line, 0, 0, 342);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW4_blue_get(int _line)
	{
		if (procedDate[_line] != 505)
		{
			procedDate[_line] = 505;
			init(_line);
			setData(_line, 0, 0, 320);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 321);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW4_blue_loop(int _line)
	{
		if (procedDate[_line] != 506)
		{
			procedDate[_line] = 506;
			init(_line);
			setData(_line, 0, 0, 321);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW4_blue_blink(int _line)
	{
		if (procedDate[_line] != 507)
		{
			procedDate[_line] = 507;
			init(_line);
			setData(_line, 0, 0, 319);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW4_blue_off(int _line)
	{
		if (procedDate[_line] != 508)
		{
			procedDate[_line] = 508;
			init(_line);
			setData(_line, 0, 0, 322);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW4_yellow_get(int _line)
	{
		if (procedDate[_line] != 509)
		{
			procedDate[_line] = 509;
			init(_line);
			setData(_line, 0, 0, 344);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 345);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW4_yellow_loop(int _line)
	{
		if (procedDate[_line] != 510)
		{
			procedDate[_line] = 510;
			init(_line);
			setData(_line, 0, 0, 345);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW4_yellow_blink(int _line)
	{
		if (procedDate[_line] != 511)
		{
			procedDate[_line] = 511;
			init(_line);
			setData(_line, 0, 0, 343);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW4_yellow_off(int _line)
	{
		if (procedDate[_line] != 512)
		{
			procedDate[_line] = 512;
			init(_line);
			setData(_line, 0, 0, 346);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW4_green_get(int _line)
	{
		if (procedDate[_line] != 513)
		{
			procedDate[_line] = 513;
			init(_line);
			setData(_line, 0, 0, 324);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 325);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW4_green_loop(int _line)
	{
		if (procedDate[_line] != 514)
		{
			procedDate[_line] = 514;
			init(_line);
			setData(_line, 0, 0, 325);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW4_green_blink(int _line)
	{
		if (procedDate[_line] != 515)
		{
			procedDate[_line] = 515;
			init(_line);
			setData(_line, 0, 0, 323);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW4_green_off(int _line)
	{
		if (procedDate[_line] != 516)
		{
			procedDate[_line] = 516;
			init(_line);
			setData(_line, 0, 0, 326);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW4_red_get(int _line)
	{
		if (procedDate[_line] != 517)
		{
			procedDate[_line] = 517;
			init(_line);
			setData(_line, 0, 0, 336);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 337);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW4_red_loop(int _line)
	{
		if (procedDate[_line] != 518)
		{
			procedDate[_line] = 518;
			init(_line);
			setData(_line, 0, 0, 337);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW4_red_blink(int _line)
	{
		if (procedDate[_line] != 519)
		{
			procedDate[_line] = 519;
			init(_line);
			setData(_line, 0, 0, 335);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW4_red_off(int _line)
	{
		if (procedDate[_line] != 520)
		{
			procedDate[_line] = 520;
			init(_line);
			setData(_line, 0, 0, 338);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW4_purple_get(int _line)
	{
		if (procedDate[_line] != 521)
		{
			procedDate[_line] = 521;
			init(_line);
			setData(_line, 0, 0, 328);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 329);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW4_purple_loop(int _line)
	{
		if (procedDate[_line] != 522)
		{
			procedDate[_line] = 522;
			init(_line);
			setData(_line, 0, 0, 329);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW4_purple_blink(int _line)
	{
		if (procedDate[_line] != 523)
		{
			procedDate[_line] = 523;
			init(_line);
			setData(_line, 0, 0, 327);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW4_purple_off(int _line)
	{
		if (procedDate[_line] != 524)
		{
			procedDate[_line] = 524;
			init(_line);
			setData(_line, 0, 0, 330);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW4_rainbow_get(int _line)
	{
		if (procedDate[_line] != 525)
		{
			procedDate[_line] = 525;
			init(_line);
			setData(_line, 0, 0, 332);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 333);
			setData(_line, 63, 2, 0);
			setData(_line, 63, 5, 0);
		}
	}

	public static void DG_POW4_rainbow_loop(int _line)
	{
		if (procedDate[_line] != 526)
		{
			procedDate[_line] = 526;
			init(_line);
			setData(_line, 0, 0, 333);
			setData(_line, 30, 2, 0);
			setData(_line, 30, 5, 0);
		}
	}

	public static void DG_POW4_rainbow_blink(int _line)
	{
		if (procedDate[_line] != 527)
		{
			procedDate[_line] = 527;
			init(_line);
			setData(_line, 0, 0, 331);
			setData(_line, 30, 2, 0);
			setData(_line, 30, 5, 0);
		}
	}

	public static void DG_POW4_rainbow_off(int _line)
	{
		if (procedDate[_line] != 528)
		{
			procedDate[_line] = 528;
			init(_line);
			setData(_line, 0, 0, 334);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW5_white_get(int _line)
	{
		if (procedDate[_line] != 529)
		{
			procedDate[_line] = 529;
			init(_line);
			setData(_line, 0, 0, 340);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 341);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW5_white_loop(int _line)
	{
		if (procedDate[_line] != 530)
		{
			procedDate[_line] = 530;
			init(_line);
			setData(_line, 0, 0, 341);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW5_white_blink(int _line)
	{
		if (procedDate[_line] != 531)
		{
			procedDate[_line] = 531;
			init(_line);
			setData(_line, 0, 0, 339);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW5_white_off(int _line)
	{
		if (procedDate[_line] != 532)
		{
			procedDate[_line] = 532;
			init(_line);
			setData(_line, 0, 0, 342);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW5_blue_get(int _line)
	{
		if (procedDate[_line] != 533)
		{
			procedDate[_line] = 533;
			init(_line);
			setData(_line, 0, 0, 320);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 321);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW5_blue_loop(int _line)
	{
		if (procedDate[_line] != 534)
		{
			procedDate[_line] = 534;
			init(_line);
			setData(_line, 0, 0, 321);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW5_blue_blink(int _line)
	{
		if (procedDate[_line] != 535)
		{
			procedDate[_line] = 535;
			init(_line);
			setData(_line, 0, 0, 319);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW5_blue_off(int _line)
	{
		if (procedDate[_line] != 536)
		{
			procedDate[_line] = 536;
			init(_line);
			setData(_line, 0, 0, 322);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW5_yellow_get(int _line)
	{
		if (procedDate[_line] != 537)
		{
			procedDate[_line] = 537;
			init(_line);
			setData(_line, 0, 0, 344);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 345);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW5_yellow_loop(int _line)
	{
		if (procedDate[_line] != 538)
		{
			procedDate[_line] = 538;
			init(_line);
			setData(_line, 0, 0, 345);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW5_yellow_blink(int _line)
	{
		if (procedDate[_line] != 539)
		{
			procedDate[_line] = 539;
			init(_line);
			setData(_line, 0, 0, 343);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW5_yellow_off(int _line)
	{
		if (procedDate[_line] != 540)
		{
			procedDate[_line] = 540;
			init(_line);
			setData(_line, 0, 0, 346);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW5_green_get(int _line)
	{
		if (procedDate[_line] != 541)
		{
			procedDate[_line] = 541;
			init(_line);
			setData(_line, 0, 0, 324);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 325);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW5_green_loop(int _line)
	{
		if (procedDate[_line] != 542)
		{
			procedDate[_line] = 542;
			init(_line);
			setData(_line, 0, 0, 325);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW5_green_blink(int _line)
	{
		if (procedDate[_line] != 543)
		{
			procedDate[_line] = 543;
			init(_line);
			setData(_line, 0, 0, 323);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW5_green_off(int _line)
	{
		if (procedDate[_line] != 544)
		{
			procedDate[_line] = 544;
			init(_line);
			setData(_line, 0, 0, 326);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW5_red_get(int _line)
	{
		if (procedDate[_line] != 545)
		{
			procedDate[_line] = 545;
			init(_line);
			setData(_line, 0, 0, 336);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 337);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW5_red_loop(int _line)
	{
		if (procedDate[_line] != 546)
		{
			procedDate[_line] = 546;
			init(_line);
			setData(_line, 0, 0, 337);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW5_red_blink(int _line)
	{
		if (procedDate[_line] != 547)
		{
			procedDate[_line] = 547;
			init(_line);
			setData(_line, 0, 0, 335);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW5_red_off(int _line)
	{
		if (procedDate[_line] != 548)
		{
			procedDate[_line] = 548;
			init(_line);
			setData(_line, 0, 0, 338);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW5_purple_get(int _line)
	{
		if (procedDate[_line] != 549)
		{
			procedDate[_line] = 549;
			init(_line);
			setData(_line, 0, 0, 328);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 329);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void DG_POW5_purple_loop(int _line)
	{
		if (procedDate[_line] != 550)
		{
			procedDate[_line] = 550;
			init(_line);
			setData(_line, 0, 0, 329);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void DG_POW5_purple_blink(int _line)
	{
		if (procedDate[_line] != 551)
		{
			procedDate[_line] = 551;
			init(_line);
			setData(_line, 0, 0, 327);
			setData(_line, 7, 2, 0);
			setData(_line, 7, 5, 0);
		}
	}

	public static void DG_POW5_purple_off(int _line)
	{
		if (procedDate[_line] != 552)
		{
			procedDate[_line] = 552;
			init(_line);
			setData(_line, 0, 0, 330);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW5_rainbow_get(int _line)
	{
		if (procedDate[_line] != 553)
		{
			procedDate[_line] = 553;
			init(_line);
			setData(_line, 0, 0, 332);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 333);
			setData(_line, 63, 2, 0);
			setData(_line, 63, 5, 0);
		}
	}

	public static void DG_POW5_rainbow_loop(int _line)
	{
		if (procedDate[_line] != 554)
		{
			procedDate[_line] = 554;
			init(_line);
			setData(_line, 0, 0, 333);
			setData(_line, 30, 2, 0);
			setData(_line, 30, 5, 0);
		}
	}

	public static void DG_POW5_rainbow_blink(int _line)
	{
		if (procedDate[_line] != 555)
		{
			procedDate[_line] = 555;
			init(_line);
			setData(_line, 0, 0, 331);
			setData(_line, 30, 2, 0);
			setData(_line, 30, 5, 0);
		}
	}

	public static void DG_POW5_rainbow_off(int _line)
	{
		if (procedDate[_line] != 556)
		{
			procedDate[_line] = 556;
			init(_line);
			setData(_line, 0, 0, 334);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_POW6_rainbow_get(int _line)
	{
		if (procedDate[_line] != 557)
		{
			procedDate[_line] = 557;
			init(_line);
			setData(_line, 0, 0, 348);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 349);
			setData(_line, 63, 2, 0);
			setData(_line, 63, 5, 0);
		}
	}

	public static void DG_POW6_rainbow_loop(int _line)
	{
		if (procedDate[_line] != 558)
		{
			procedDate[_line] = 558;
			init(_line);
			setData(_line, 0, 0, 349);
			setData(_line, 30, 2, 0);
			setData(_line, 30, 5, 0);
		}
	}

	public static void DG_POW6_rainbow_blink(int _line)
	{
		if (procedDate[_line] != 559)
		{
			procedDate[_line] = 559;
			init(_line);
			setData(_line, 0, 0, 347);
			setData(_line, 30, 2, 0);
			setData(_line, 30, 5, 0);
		}
	}

	public static void DG_POW6_rainbow_off(int _line)
	{
		if (procedDate[_line] != 560)
		{
			procedDate[_line] = 560;
			init(_line);
			setData(_line, 0, 0, 350);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void DG_DI_start(int _line)
	{
		if (procedDate[_line] != 561)
		{
			procedDate[_line] = 561;
			init(_line);
			setData(_line, 0, 0, 295);
			setData(_line, 61, 3, 255);
			setData(_line, 61, 0, 296);
			setData(_line, 63, 2, 0);
			setData(_line, 63, 5, 0);
		}
	}

	public static void DG_DI_start_loop(int _line)
	{
		if (procedDate[_line] != 562)
		{
			procedDate[_line] = 562;
			init(_line);
			setData(_line, 0, 0, 296);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void DG_DI_last9(int _line)
	{
		if (procedDate[_line] != 563)
		{
			procedDate[_line] = 563;
			init(_line);
			setData(_line, 0, 0, 284);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 294);
			setData(_line, 32, 2, 0);
			setData(_line, 32, 5, 0);
		}
	}

	public static void DG_DI_last9_loop(int _line)
	{
		if (procedDate[_line] != 564)
		{
			procedDate[_line] = 564;
			init(_line);
			setData(_line, 0, 0, 294);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void DG_DI_last8(int _line)
	{
		if (procedDate[_line] != 565)
		{
			procedDate[_line] = 565;
			init(_line);
			setData(_line, 0, 0, 283);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 293);
			setData(_line, 32, 2, 0);
			setData(_line, 32, 5, 0);
		}
	}

	public static void DG_DI_last8_loop(int _line)
	{
		if (procedDate[_line] != 566)
		{
			procedDate[_line] = 566;
			init(_line);
			setData(_line, 0, 0, 293);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void DG_DI_last7(int _line)
	{
		if (procedDate[_line] != 567)
		{
			procedDate[_line] = 567;
			init(_line);
			setData(_line, 0, 0, 282);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 292);
			setData(_line, 32, 2, 0);
			setData(_line, 32, 5, 0);
		}
	}

	public static void DG_DI_last7_loop(int _line)
	{
		if (procedDate[_line] != 568)
		{
			procedDate[_line] = 568;
			init(_line);
			setData(_line, 0, 0, 292);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void DG_DI_last6(int _line)
	{
		if (procedDate[_line] != 569)
		{
			procedDate[_line] = 569;
			init(_line);
			setData(_line, 0, 0, 281);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 291);
			setData(_line, 32, 2, 0);
			setData(_line, 32, 5, 0);
		}
	}

	public static void DG_DI_last6_loop(int _line)
	{
		if (procedDate[_line] != 570)
		{
			procedDate[_line] = 570;
			init(_line);
			setData(_line, 0, 0, 291);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void DG_DI_last5(int _line)
	{
		if (procedDate[_line] != 571)
		{
			procedDate[_line] = 571;
			init(_line);
			setData(_line, 0, 0, 280);
			setData(_line, 45, 3, 255);
			setData(_line, 45, 0, 290);
			setData(_line, 47, 2, 0);
			setData(_line, 47, 5, 0);
		}
	}

	public static void DG_DI_last5_loop(int _line)
	{
		if (procedDate[_line] != 572)
		{
			procedDate[_line] = 572;
			init(_line);
			setData(_line, 0, 0, 290);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void DG_DI_last4(int _line)
	{
		if (procedDate[_line] != 573)
		{
			procedDate[_line] = 573;
			init(_line);
			setData(_line, 0, 0, 279);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 289);
			setData(_line, 32, 2, 0);
			setData(_line, 32, 5, 0);
		}
	}

	public static void DG_DI_last4_loop(int _line)
	{
		if (procedDate[_line] != 574)
		{
			procedDate[_line] = 574;
			init(_line);
			setData(_line, 0, 0, 289);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void DG_DI_last3(int _line)
	{
		if (procedDate[_line] != 575)
		{
			procedDate[_line] = 575;
			init(_line);
			setData(_line, 0, 0, 278);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 288);
			setData(_line, 32, 2, 0);
			setData(_line, 32, 5, 0);
		}
	}

	public static void DG_DI_last3_loop(int _line)
	{
		if (procedDate[_line] != 576)
		{
			procedDate[_line] = 576;
			init(_line);
			setData(_line, 0, 0, 288);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void DG_DI_last2(int _line)
	{
		if (procedDate[_line] != 577)
		{
			procedDate[_line] = 577;
			init(_line);
			setData(_line, 0, 0, 277);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 287);
			setData(_line, 32, 2, 0);
			setData(_line, 32, 5, 0);
		}
	}

	public static void DG_DI_last2_loop(int _line)
	{
		if (procedDate[_line] != 578)
		{
			procedDate[_line] = 578;
			init(_line);
			setData(_line, 0, 0, 287);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void DG_DI_last1(int _line)
	{
		if (procedDate[_line] != 579)
		{
			procedDate[_line] = 579;
			init(_line);
			setData(_line, 0, 0, 276);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 286);
			setData(_line, 32, 2, 0);
			setData(_line, 32, 5, 0);
		}
	}

	public static void DG_DI_last1_loop(int _line)
	{
		if (procedDate[_line] != 580)
		{
			procedDate[_line] = 580;
			init(_line);
			setData(_line, 0, 0, 286);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void DG_DI_last0(int _line)
	{
		if (procedDate[_line] != 581)
		{
			procedDate[_line] = 581;
			init(_line);
			setData(_line, 0, 0, 275);
			setData(_line, 45, 3, 255);
			setData(_line, 45, 0, 285);
			setData(_line, 47, 2, 0);
			setData(_line, 47, 5, 0);
		}
	}

	public static void DG_DI_last0_loop(int _line)
	{
		if (procedDate[_line] != 582)
		{
			procedDate[_line] = 582;
			init(_line);
			setData(_line, 0, 0, 285);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void GD_YFC_blue(int _line)
	{
		if (procedDate[_line] != 583)
		{
			procedDate[_line] = 583;
			init(_line);
			setData(_line, 0, 0, 351);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 352);
			setData(_line, 60, 2, 0);
			setData(_line, 60, 5, 0);
		}
	}

	public static void GD_YFC_chain_01(int _line)
	{
		if (procedDate[_line] != 584)
		{
			procedDate[_line] = 584;
			init(_line);
			setData(_line, 0, 0, 353);
			setData(_line, 45, 3, 255);
			setData(_line, 45, 0, 352);
			setData(_line, 75, 2, 0);
			setData(_line, 75, 5, 0);
		}
	}

	public static void GD_YFC_green(int _line)
	{
		if (procedDate[_line] != 585)
		{
			procedDate[_line] = 585;
			init(_line);
			setData(_line, 0, 0, 356);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 357);
			setData(_line, 60, 2, 0);
			setData(_line, 60, 5, 0);
		}
	}

	public static void GD_YFC_chain_02(int _line)
	{
		if (procedDate[_line] != 586)
		{
			procedDate[_line] = 586;
			init(_line);
			setData(_line, 0, 0, 354);
			setData(_line, 45, 3, 255);
			setData(_line, 45, 0, 357);
			setData(_line, 75, 2, 0);
			setData(_line, 75, 5, 0);
		}
	}

	public static void GD_YFC_red(int _line)
	{
		if (procedDate[_line] != 587)
		{
			procedDate[_line] = 587;
			init(_line);
			setData(_line, 0, 0, 360);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 361);
			setData(_line, 60, 2, 0);
			setData(_line, 60, 5, 0);
		}
	}

	public static void GD_YFC_chain_03(int _line)
	{
		if (procedDate[_line] != 588)
		{
			procedDate[_line] = 588;
			init(_line);
			setData(_line, 0, 0, 355);
			setData(_line, 45, 3, 255);
			setData(_line, 45, 0, 361);
			setData(_line, 75, 2, 0);
			setData(_line, 75, 5, 0);
		}
	}

	public static void GD_YFC_rainbow(int _line)
	{
		if (procedDate[_line] != 589)
		{
			procedDate[_line] = 589;
			init(_line);
			setData(_line, 0, 0, 358);
			setData(_line, 120, 3, 255);
			setData(_line, 120, 0, 359);
			setData(_line, 240, 2, 0);
			setData(_line, 240, 5, 0);
		}
	}

	public static void GD_YFC_chain_04(int _line)
	{
		if (procedDate[_line] != 590)
		{
			procedDate[_line] = 590;
			init(_line);
			setData(_line, 0, 0, 476);
			setData(_line, 120, 3, 255);
			setData(_line, 120, 0, 359);
			setData(_line, 240, 2, 0);
			setData(_line, 240, 5, 0);
		}
	}

	public static void GD_YTK_swing_white_01(int _line)
	{
		if (procedDate[_line] != 591)
		{
			procedDate[_line] = 591;
			init(_line);
			setData(_line, 0, 0, 372);
			setData(_line, 36, 4, 0);
			setData(_line, 36, 5, 0);
		}
	}

	public static void GD_YTK_swing_white_02(int _line)
	{
		if (procedDate[_line] != 592)
		{
			procedDate[_line] = 592;
			init(_line);
			setData(_line, 0, 0, 373);
			setData(_line, 52, 4, 0);
			setData(_line, 52, 5, 0);
		}
	}

	public static void GD_YTK_swing_blue_01(int _line)
	{
		if (procedDate[_line] != 593)
		{
			procedDate[_line] = 593;
			init(_line);
			setData(_line, 0, 0, 362);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 404);
			setData(_line, 60, 2, 0);
			setData(_line, 60, 5, 0);
		}
	}

	public static void GD_YTK_swing_blue_02(int _line)
	{
		if (procedDate[_line] != 594)
		{
			procedDate[_line] = 594;
			init(_line);
			setData(_line, 0, 0, 363);
			setData(_line, 52, 3, 255);
			setData(_line, 52, 0, 405);
			setData(_line, 82, 2, 0);
			setData(_line, 82, 5, 0);
		}
	}

	public static void GD_YTK_swing_yellow_01(int _line)
	{
		if (procedDate[_line] != 595)
		{
			procedDate[_line] = 595;
			init(_line);
			setData(_line, 0, 0, 374);
			setData(_line, 36, 4, 0);
			setData(_line, 36, 5, 0);
		}
	}

	public static void GD_YTK_swing_yellow_02(int _line)
	{
		if (procedDate[_line] != 596)
		{
			procedDate[_line] = 596;
			init(_line);
			setData(_line, 0, 0, 375);
			setData(_line, 52, 4, 0);
			setData(_line, 52, 5, 0);
		}
	}

	public static void GD_YTK_swing_green_01(int _line)
	{
		if (procedDate[_line] != 597)
		{
			procedDate[_line] = 597;
			init(_line);
			setData(_line, 0, 0, 364);
			setData(_line, 36, 4, 0);
			setData(_line, 36, 5, 0);
		}
	}

	public static void GD_YTK_swing_green_02(int _line)
	{
		if (procedDate[_line] != 598)
		{
			procedDate[_line] = 598;
			init(_line);
			setData(_line, 0, 0, 365);
			setData(_line, 52, 4, 0);
			setData(_line, 52, 5, 0);
		}
	}

	public static void GD_YTK_swing_red_01(int _line)
	{
		if (procedDate[_line] != 599)
		{
			procedDate[_line] = 599;
			init(_line);
			setData(_line, 0, 0, 370);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 406);
			setData(_line, 60, 2, 0);
			setData(_line, 60, 5, 0);
		}
	}

	public static void GD_YTK_swing_red_02(int _line)
	{
		if (procedDate[_line] != 600)
		{
			procedDate[_line] = 600;
			init(_line);
			setData(_line, 0, 0, 371);
			setData(_line, 52, 3, 255);
			setData(_line, 52, 0, 407);
			setData(_line, 82, 2, 0);
			setData(_line, 82, 5, 0);
		}
	}

	public static void GD_YTK_swing_purple_01(int _line)
	{
		if (procedDate[_line] != 601)
		{
			procedDate[_line] = 601;
			init(_line);
			setData(_line, 0, 0, 366);
			setData(_line, 36, 4, 0);
			setData(_line, 36, 5, 0);
		}
	}

	public static void GD_YTK_swing_purple_02(int _line)
	{
		if (procedDate[_line] != 602)
		{
			procedDate[_line] = 602;
			init(_line);
			setData(_line, 0, 0, 367);
			setData(_line, 52, 4, 0);
			setData(_line, 52, 5, 0);
		}
	}

	public static void GD_YTK_swing_rainbow_01(int _line)
	{
		if (procedDate[_line] != 603)
		{
			procedDate[_line] = 603;
			init(_line);
			setData(_line, 0, 0, 368);
			setData(_line, 36, 4, 0);
			setData(_line, 36, 5, 0);
		}
	}

	public static void GD_YTK_swing_rainbow_02(int _line)
	{
		if (procedDate[_line] != 604)
		{
			procedDate[_line] = 604;
			init(_line);
			setData(_line, 0, 0, 369);
			setData(_line, 52, 4, 0);
			setData(_line, 52, 5, 0);
		}
	}

	public static void GD_YTG_lever(int _line)
	{
		if (procedDate[_line] != 605)
		{
			procedDate[_line] = 605;
			init(_line);
			setData(_line, 0, 0, 381);
			setData(_line, 20, 3, 255);
			setData(_line, 20, 0, 382);
			setData(_line, 40, 2, 0);
			setData(_line, 40, 5, 0);
		}
	}

	public static void GD_YTG_charge_1(int _line)
	{
		if (procedDate[_line] != 606)
		{
			procedDate[_line] = 606;
			init(_line);
			setData(_line, 0, 0, 376);
			setData(_line, 25, 3, 255);
			setData(_line, 25, 0, 378);
			setData(_line, 45, 2, 0);
			setData(_line, 45, 5, 0);
		}
	}

	public static void GD_YTG_charge_2(int _line)
	{
		if (procedDate[_line] != 607)
		{
			procedDate[_line] = 607;
			init(_line);
			setData(_line, 0, 0, 377);
			setData(_line, 25, 3, 255);
			setData(_line, 25, 0, 379);
			setData(_line, 45, 2, 0);
			setData(_line, 45, 5, 0);
		}
	}

	public static void GD_YTG_fire(int _line)
	{
		if (procedDate[_line] != 608)
		{
			procedDate[_line] = 608;
			init(_line);
			setData(_line, 0, 0, 380);
			setData(_line, 20, 3, 255);
			setData(_line, 20, 0, 383);
			setData(_line, 21, 2, 0);
			setData(_line, 21, 5, 0);
		}
	}

	public static void GD_HOH_sol_P(int _line)
	{
		if (procedDate[_line] != 609)
		{
			procedDate[_line] = 609;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 2, 0, 387);
			setData(_line, 12, 4, 0);
			setData(_line, 12, 5, 0);
		}
	}

	public static void GD_HOH_sol_K(int _line)
	{
		if (procedDate[_line] != 610)
		{
			procedDate[_line] = 610;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 2, 0, 387);
			setData(_line, 12, 4, 0);
			setData(_line, 12, 5, 0);
		}
	}

	public static void GD_HOH_sol_HS(int _line)
	{
		if (procedDate[_line] != 611)
		{
			procedDate[_line] = 611;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 42, 0, 387);
			setData(_line, 52, 4, 0);
			setData(_line, 52, 5, 0);
		}
	}

	public static void GD_HOH_sol_counter_HS(int _line)
	{
		if (procedDate[_line] != 612)
		{
			procedDate[_line] = 612;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 82, 0, 387);
			setData(_line, 92, 4, 0);
			setData(_line, 92, 5, 0);
		}
	}

	public static void GD_HOH_sol_GF(int _line)
	{
		if (procedDate[_line] != 613)
		{
			procedDate[_line] = 613;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 148, 0, 388);
			setData(_line, 168, 4, 0);
			setData(_line, 168, 5, 0);
		}
	}

	public static void GD_HOH_sol_counter_GF(int _line)
	{
		if (procedDate[_line] != 614)
		{
			procedDate[_line] = 614;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 188, 0, 388);
			setData(_line, 208, 4, 0);
			setData(_line, 208, 5, 0);
		}
	}

	public static void GD_HOH_sol_VV(int _line)
	{
		if (procedDate[_line] != 615)
		{
			procedDate[_line] = 615;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 88, 0, 388);
			setData(_line, 108, 4, 0);
			setData(_line, 108, 5, 0);
		}
	}

	public static void GD_HOH_sol_counter_VV(int _line)
	{
		if (procedDate[_line] != 616)
		{
			procedDate[_line] = 616;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 128, 0, 388);
			setData(_line, 148, 4, 0);
			setData(_line, 148, 5, 0);
		}
	}

	public static void GD_HOH_sol_VV_K(int _line)
	{
		if (procedDate[_line] != 617)
		{
			procedDate[_line] = 617;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 75, 0, 388);
			setData(_line, 95, 4, 0);
			setData(_line, 150, 0, 388);
			setData(_line, 170, 4, 0);
			setData(_line, 170, 5, 0);
		}
	}

	public static void GD_HOH_sol_JYD_VV(int _line)
	{
		if (procedDate[_line] != 618)
		{
			procedDate[_line] = 618;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 160, 0, 388);
			setData(_line, 180, 4, 0);
			setData(_line, 180, 5, 0);
		}
	}

	public static void GD_HOH_sol_JYD_VV_K(int _line)
	{
		if (procedDate[_line] != 619)
		{
			procedDate[_line] = 619;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 147, 0, 388);
			setData(_line, 167, 4, 0);
			setData(_line, 222, 0, 388);
			setData(_line, 242, 4, 0);
			setData(_line, 242, 5, 0);
		}
	}

	public static void GD_HOH_sol_U(int _line)
	{
		if (procedDate[_line] != 620)
		{
			procedDate[_line] = 620;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 2, 0, 387);
			setData(_line, 12, 4, 0);
			setData(_line, 12, 5, 0);
		}
	}

	public static void GD_HOH_sol_counter_U(int _line)
	{
		if (procedDate[_line] != 621)
		{
			procedDate[_line] = 621;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 42, 0, 387);
			setData(_line, 52, 4, 0);
			setData(_line, 52, 5, 0);
		}
	}

	public static void GD_HOH_sol_TR(int _line)
	{
		if (procedDate[_line] != 622)
		{
			procedDate[_line] = 622;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 144, 0, 388);
			setData(_line, 164, 0, 388);
			setData(_line, 184, 4, 0);
			setData(_line, 184, 5, 0);
		}
	}

	public static void GD_HOH_sol_JYD_TR(int _line)
	{
		if (procedDate[_line] != 623)
		{
			procedDate[_line] = 623;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 220, 0, 388);
			setData(_line, 240, 0, 388);
			setData(_line, 260, 4, 0);
			setData(_line, 260, 5, 0);
		}
	}

	public static void GD_HOH_sol_ND(int _line)
	{
		if (procedDate[_line] != 624)
		{
			procedDate[_line] = 624;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 122, 0, 388);
			setData(_line, 142, 0, 388);
			setData(_line, 162, 4, 0);
			setData(_line, 162, 5, 0);
		}
	}

	public static void GD_HOH_sol_JYD_ND(int _line)
	{
		if (procedDate[_line] != 625)
		{
			procedDate[_line] = 625;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 190, 0, 388);
			setData(_line, 210, 0, 388);
			setData(_line, 230, 4, 0);
			setData(_line, 230, 5, 0);
		}
	}

	public static void GD_HOH_sol_H(int _line)
	{
		if (procedDate[_line] != 626)
		{
			procedDate[_line] = 626;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 15, 0, 387);
			setData(_line, 25, 4, 0);
			setData(_line, 25, 5, 0);
		}
	}

	public static void GD_HOH_sol_counter_H(int _line)
	{
		if (procedDate[_line] != 627)
		{
			procedDate[_line] = 627;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 55, 0, 387);
			setData(_line, 65, 4, 0);
			setData(_line, 65, 5, 0);
		}
	}

	public static void GD_HOH_sol_DA_3(int _line)
	{
		if (procedDate[_line] != 628)
		{
			procedDate[_line] = 628;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 3, 0, 387);
			setData(_line, 13, 4, 0);
			setData(_line, 16, 0, 387);
			setData(_line, 26, 4, 0);
			setData(_line, 50, 0, 388);
			setData(_line, 70, 4, 0);
			setData(_line, 70, 5, 0);
		}
	}

	public static void GD_HOH_sol_DA_6(int _line)
	{
		if (procedDate[_line] != 629)
		{
			procedDate[_line] = 629;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 3, 0, 387);
			setData(_line, 13, 4, 0);
			setData(_line, 16, 0, 387);
			setData(_line, 26, 4, 0);
			setData(_line, 29, 0, 387);
			setData(_line, 39, 4, 0);
			setData(_line, 42, 0, 387);
			setData(_line, 52, 4, 0);
			setData(_line, 55, 0, 387);
			setData(_line, 65, 4, 0);
			setData(_line, 91, 0, 388);
			setData(_line, 111, 4, 0);
			setData(_line, 111, 5, 0);
		}
	}

	public static void GD_HOH_sol_JYD_DA_6(int _line)
	{
		if (procedDate[_line] != 630)
		{
			procedDate[_line] = 630;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 75, 0, 387);
			setData(_line, 85, 4, 0);
			setData(_line, 88, 0, 387);
			setData(_line, 98, 4, 0);
			setData(_line, 101, 0, 387);
			setData(_line, 111, 4, 0);
			setData(_line, 114, 0, 387);
			setData(_line, 124, 4, 0);
			setData(_line, 127, 0, 387);
			setData(_line, 137, 4, 0);
			setData(_line, 163, 0, 388);
			setData(_line, 183, 4, 0);
			setData(_line, 183, 5, 0);
		}
	}

	public static void GD_HOH_sol_guard_01(int _line)
	{
		if (procedDate[_line] != 631)
		{
			procedDate[_line] = 631;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 24, 0, 452);
			setData(_line, 44, 4, 0);
			setData(_line, 44, 5, 0);
		}
	}

	public static void GD_HOH_sol_guard_02(int _line)
	{
		if (procedDate[_line] != 632)
		{
			procedDate[_line] = 632;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 32, 0, 452);
			setData(_line, 52, 4, 0);
			setData(_line, 52, 5, 0);
		}
	}

	public static void GD_HSL_enm_P(int _line)
	{
		if (procedDate[_line] != 633)
		{
			procedDate[_line] = 633;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 3, 0, 384);
			setData(_line, 13, 4, 0);
			setData(_line, 13, 5, 0);
		}
	}

	public static void GD_HSL_enm_K(int _line)
	{
		if (procedDate[_line] != 634)
		{
			procedDate[_line] = 634;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 3, 0, 384);
			setData(_line, 13, 4, 0);
			setData(_line, 13, 5, 0);
		}
	}

	public static void GD_HSL_enm_HS(int _line)
	{
		if (procedDate[_line] != 635)
		{
			procedDate[_line] = 635;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 24, 0, 384);
			setData(_line, 34, 4, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void GD_HSL_enm_MP(int _line)
	{
		if (procedDate[_line] != 636)
		{
			procedDate[_line] = 636;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 92, 0, 385);
			setData(_line, 112, 4, 0);
			setData(_line, 112, 5, 0);
		}
	}

	public static void GD_HSL_enm_DT(int _line)
	{
		if (procedDate[_line] != 637)
		{
			procedDate[_line] = 637;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 62, 0, 386);
			setData(_line, 92, 4, 0);
			setData(_line, 92, 5, 0);
		}
	}

	public static void GD_HCP_enm_P(int _line)
	{
		if (procedDate[_line] != 638)
		{
			procedDate[_line] = 638;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 3, 0, 384);
			setData(_line, 13, 4, 0);
			setData(_line, 13, 5, 0);
		}
	}

	public static void GD_HCP_enm_K(int _line)
	{
		if (procedDate[_line] != 639)
		{
			procedDate[_line] = 639;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 3, 0, 384);
			setData(_line, 13, 4, 0);
			setData(_line, 13, 5, 0);
		}
	}

	public static void GD_HCP_enm_HS(int _line)
	{
		if (procedDate[_line] != 640)
		{
			procedDate[_line] = 640;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 24, 0, 384);
			setData(_line, 34, 4, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void GD_HCP_enm_AB(int _line)
	{
		if (procedDate[_line] != 641)
		{
			procedDate[_line] = 641;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 100, 0, 385);
			setData(_line, 120, 4, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void GD_HCP_enm_ZR(int _line)
	{
		if (procedDate[_line] != 642)
		{
			procedDate[_line] = 642;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 153, 0, 386);
			setData(_line, 183, 4, 0);
			setData(_line, 183, 5, 0);
		}
	}

	public static void GD_HML_enm_P(int _line)
	{
		if (procedDate[_line] != 643)
		{
			procedDate[_line] = 643;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 3, 0, 384);
			setData(_line, 13, 4, 0);
			setData(_line, 13, 5, 0);
		}
	}

	public static void GD_HML_enm_K(int _line)
	{
		if (procedDate[_line] != 644)
		{
			procedDate[_line] = 644;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 3, 0, 384);
			setData(_line, 13, 4, 0);
			setData(_line, 13, 5, 0);
		}
	}

	public static void GD_HML_enm_HS(int _line)
	{
		if (procedDate[_line] != 645)
		{
			procedDate[_line] = 645;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 27, 0, 384);
			setData(_line, 37, 4, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void GD_HML_enm_BM(int _line)
	{
		if (procedDate[_line] != 646)
		{
			procedDate[_line] = 646;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 126, 0, 385);
			setData(_line, 146, 4, 0);
			setData(_line, 146, 5, 0);
		}
	}

	public static void GD_HML_enm_WG(int _line)
	{
		if (procedDate[_line] != 647)
		{
			procedDate[_line] = 647;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 42, 0, 386);
			setData(_line, 72, 4, 0);
			setData(_line, 72, 5, 0);
		}
	}

	public static void GD_HBJ_enm_P(int _line)
	{
		if (procedDate[_line] != 648)
		{
			procedDate[_line] = 648;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 3, 0, 384);
			setData(_line, 13, 4, 0);
			setData(_line, 13, 5, 0);
		}
	}

	public static void GD_HBJ_enm_K(int _line)
	{
		if (procedDate[_line] != 649)
		{
			procedDate[_line] = 649;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 3, 0, 384);
			setData(_line, 13, 4, 0);
			setData(_line, 13, 5, 0);
		}
	}

	public static void GD_HBJ_enm_HS(int _line)
	{
		if (procedDate[_line] != 650)
		{
			procedDate[_line] = 650;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 26, 0, 384);
			setData(_line, 36, 4, 0);
			setData(_line, 36, 5, 0);
		}
	}

	public static void GD_HBJ_enm_RR(int _line)
	{
		if (procedDate[_line] != 651)
		{
			procedDate[_line] = 651;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 100, 0, 385);
			setData(_line, 120, 4, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void GD_HBJ_enm_LL(int _line)
	{
		if (procedDate[_line] != 652)
		{
			procedDate[_line] = 652;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 115, 0, 386);
			setData(_line, 145, 4, 0);
			setData(_line, 145, 5, 0);
		}
	}

	public static void GD_BTH_charge_white(int _line)
	{
		if (procedDate[_line] != 653)
		{
			procedDate[_line] = 653;
			init(_line);
			setData(_line, 55, 0, 400);
			setData(_line, 105, 3, 255);
			setData(_line, 105, 0, 401);
			setData(_line, 106, 2, 0);
			setData(_line, 106, 5, 0);
		}
	}

	public static void GD_BTH_charge_blue(int _line)
	{
		if (procedDate[_line] != 654)
		{
			procedDate[_line] = 654;
			init(_line);
			setData(_line, 55, 0, 390);
			setData(_line, 105, 3, 255);
			setData(_line, 105, 0, 391);
			setData(_line, 106, 2, 0);
			setData(_line, 106, 5, 0);
		}
	}

	public static void GD_BTH_charge_yellow(int _line)
	{
		if (procedDate[_line] != 655)
		{
			procedDate[_line] = 655;
			init(_line);
			setData(_line, 55, 0, 402);
			setData(_line, 105, 3, 255);
			setData(_line, 105, 0, 403);
			setData(_line, 106, 2, 0);
			setData(_line, 106, 5, 0);
		}
	}

	public static void GD_BTH_charge_green(int _line)
	{
		if (procedDate[_line] != 656)
		{
			procedDate[_line] = 656;
			init(_line);
			setData(_line, 55, 0, 392);
			setData(_line, 105, 3, 255);
			setData(_line, 105, 0, 393);
			setData(_line, 106, 2, 0);
			setData(_line, 106, 5, 0);
		}
	}

	public static void GD_BTH_charge_red(int _line)
	{
		if (procedDate[_line] != 657)
		{
			procedDate[_line] = 657;
			init(_line);
			setData(_line, 55, 0, 398);
			setData(_line, 105, 3, 255);
			setData(_line, 105, 0, 399);
			setData(_line, 106, 2, 0);
			setData(_line, 106, 5, 0);
		}
	}

	public static void GD_BTH_charge_purple(int _line)
	{
		if (procedDate[_line] != 658)
		{
			procedDate[_line] = 658;
			init(_line);
			setData(_line, 55, 0, 394);
			setData(_line, 105, 3, 255);
			setData(_line, 105, 0, 395);
			setData(_line, 106, 2, 0);
			setData(_line, 106, 5, 0);
		}
	}

	public static void GD_BTH_charge_rainbow(int _line)
	{
		if (procedDate[_line] != 659)
		{
			procedDate[_line] = 659;
			init(_line);
			setData(_line, 55, 0, 396);
			setData(_line, 135, 3, 255);
			setData(_line, 135, 0, 397);
			setData(_line, 187, 2, 0);
			setData(_line, 187, 5, 0);
		}
	}

	public static void GD_AIG_charge_rainbow(int _line)
	{
		if (procedDate[_line] != 660)
		{
			procedDate[_line] = 660;
			init(_line);
			setData(_line, 71, 0, 396);
			setData(_line, 123, 3, 255);
			setData(_line, 123, 0, 397);
			setData(_line, 175, 2, 0);
			setData(_line, 175, 5, 0);
		}
	}

	public static void GD_BTH_charge_white_02(int _line)
	{
		if (procedDate[_line] != 661)
		{
			procedDate[_line] = 661;
			init(_line);
			setData(_line, 88, 0, 400);
			setData(_line, 138, 3, 255);
			setData(_line, 138, 0, 401);
			setData(_line, 139, 2, 0);
			setData(_line, 139, 5, 0);
		}
	}

	public static void GD_BTH_charge_blue_02(int _line)
	{
		if (procedDate[_line] != 662)
		{
			procedDate[_line] = 662;
			init(_line);
			setData(_line, 88, 0, 390);
			setData(_line, 138, 3, 255);
			setData(_line, 138, 0, 391);
			setData(_line, 139, 2, 0);
			setData(_line, 139, 5, 0);
		}
	}

	public static void GD_BTH_charge_yellow_02(int _line)
	{
		if (procedDate[_line] != 663)
		{
			procedDate[_line] = 663;
			init(_line);
			setData(_line, 88, 0, 402);
			setData(_line, 138, 3, 255);
			setData(_line, 138, 0, 403);
			setData(_line, 139, 2, 0);
			setData(_line, 139, 5, 0);
		}
	}

	public static void GD_KSY_close(int _line)
	{
		if (procedDate[_line] != 664)
		{
			procedDate[_line] = 664;
			init(_line);
			setData(_line, 0, 0, 408);
			setData(_line, 20, 3, 255);
			setData(_line, 20, 0, 409);
			setData(_line, 50, 2, 0);
			setData(_line, 50, 5, 0);
		}
	}

	public static void GD_KSY_HOH_close(int _line)
	{
		if (procedDate[_line] != 665)
		{
			procedDate[_line] = 665;
			init(_line);
			setData(_line, 0, 0, 408);
			setData(_line, 20, 4, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void GD_KSY_half(int _line)
	{
		if (procedDate[_line] != 666)
		{
			procedDate[_line] = 666;
			init(_line);
			setData(_line, 0, 0, 410);
			setData(_line, 10, 3, 255);
			setData(_line, 10, 0, 411);
			setData(_line, 40, 2, 0);
			setData(_line, 40, 5, 0);
		}
	}

	public static void GD_MGO_green(int _line)
	{
		if (procedDate[_line] != 667)
		{
			procedDate[_line] = 667;
			init(_line);
			setData(_line, 15, 0, 412);
			setData(_line, 40, 3, 255);
			setData(_line, 40, 0, 413);
			setData(_line, 70, 2, 0);
			setData(_line, 70, 5, 0);
		}
	}

	public static void GD_MGO_red(int _line)
	{
		if (procedDate[_line] != 668)
		{
			procedDate[_line] = 668;
			init(_line);
			setData(_line, 15, 0, 414);
			setData(_line, 67, 3, 255);
			setData(_line, 67, 0, 417);
			setData(_line, 97, 2, 0);
			setData(_line, 97, 5, 0);
		}
	}

	public static void GD_RSH_green(int _line)
	{
		if (procedDate[_line] != 669)
		{
			procedDate[_line] = 669;
			init(_line);
			setData(_line, 0, 0, 412);
			setData(_line, 25, 3, 255);
			setData(_line, 25, 0, 413);
			setData(_line, 55, 2, 0);
			setData(_line, 55, 5, 0);
		}
	}

	public static void GD_RSH_red(int _line)
	{
		if (procedDate[_line] != 670)
		{
			procedDate[_line] = 670;
			init(_line);
			setData(_line, 0, 0, 414);
			setData(_line, 52, 3, 255);
			setData(_line, 52, 0, 417);
			setData(_line, 82, 2, 0);
			setData(_line, 82, 5, 0);
		}
	}

	public static void GD_CMB_green(int _line)
	{
		if (procedDate[_line] != 671)
		{
			procedDate[_line] = 671;
			init(_line);
			setData(_line, 30, 0, 412);
			setData(_line, 55, 3, 255);
			setData(_line, 55, 0, 413);
			setData(_line, 85, 2, 0);
			setData(_line, 85, 5, 0);
		}
	}

	public static void GD_CMB_red(int _line)
	{
		if (procedDate[_line] != 672)
		{
			procedDate[_line] = 672;
			init(_line);
			setData(_line, 30, 0, 414);
			setData(_line, 82, 3, 255);
			setData(_line, 82, 0, 417);
			setData(_line, 112, 2, 0);
			setData(_line, 112, 5, 0);
		}
	}

	public static void GD_KOG_green(int _line)
	{
		if (procedDate[_line] != 673)
		{
			procedDate[_line] = 673;
			init(_line);
			setData(_line, 0, 0, 412);
			setData(_line, 25, 3, 255);
			setData(_line, 25, 0, 413);
			setData(_line, 55, 2, 0);
			setData(_line, 55, 5, 0);
		}
	}

	public static void GD_KOG_red(int _line)
	{
		if (procedDate[_line] != 674)
		{
			procedDate[_line] = 674;
			init(_line);
			setData(_line, 0, 0, 414);
			setData(_line, 52, 3, 255);
			setData(_line, 52, 0, 417);
			setData(_line, 82, 2, 0);
			setData(_line, 82, 5, 0);
		}
	}

	public static void GD_KOG_sol_red(int _line)
	{
		if (procedDate[_line] != 675)
		{
			procedDate[_line] = 675;
			init(_line);
			setData(_line, 0, 0, 414);
			setData(_line, 25, 3, 255);
			setData(_line, 25, 0, 417);
			setData(_line, 55, 2, 0);
			setData(_line, 55, 5, 0);
		}
	}

	public static void GD_hatten_HIT(int _line)
	{
		if (procedDate[_line] != 676)
		{
			procedDate[_line] = 676;
			init(_line);
			setData(_line, 0, 0, 415);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 416);
			setData(_line, 31, 2, 0);
			setData(_line, 31, 5, 0);
		}
	}

	public static void GD_hatten_JYD_HIT(int _line)
	{
		if (procedDate[_line] != 677)
		{
			procedDate[_line] = 677;
			init(_line);
			setData(_line, 72, 0, 415);
			setData(_line, 102, 3, 255);
			setData(_line, 102, 0, 416);
			setData(_line, 103, 2, 0);
			setData(_line, 103, 5, 0);
		}
	}

	public static void GD_BM1_GET_01(int _line)
	{
		if (procedDate[_line] != 678)
		{
			procedDate[_line] = 678;
			init(_line);
			setData(_line, 0, 0, 418);
			setData(_line, 40, 3, 255);
			setData(_line, 40, 0, 421);
			setData(_line, 70, 2, 0);
			setData(_line, 70, 5, 0);
		}
	}

	public static void GD_BM1_GET_02(int _line)
	{
		if (procedDate[_line] != 679)
		{
			procedDate[_line] = 679;
			init(_line);
			setData(_line, 0, 0, 419);
			setData(_line, 60, 3, 255);
			setData(_line, 60, 0, 422);
			setData(_line, 90, 2, 0);
			setData(_line, 90, 5, 0);
		}
	}

	public static void GD_BM1_GET_03(int _line)
	{
		if (procedDate[_line] != 680)
		{
			procedDate[_line] = 680;
			init(_line);
			setData(_line, 0, 0, 420);
			setData(_line, 80, 3, 255);
			setData(_line, 80, 0, 423);
			setData(_line, 110, 2, 0);
			setData(_line, 110, 5, 0);
		}
	}

	public static void GD_BZT_title(int _line)
	{
		if (procedDate[_line] != 681)
		{
			procedDate[_line] = 681;
			init(_line);
			setData(_line, 0, 0, 424);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 425);
			setData(_line, 60, 2, 0);
			setData(_line, 60, 5, 0);
		}
	}

	public static void GD_BJT_charge_white_01(int _line)
	{
		if (procedDate[_line] != 682)
		{
			procedDate[_line] = 682;
			init(_line);
			setData(_line, 0, 0, 436);
			setData(_line, 16, 3, 255);
			setData(_line, 16, 0, 437);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void GD_BJT_charge_white_02(int _line)
	{
		if (procedDate[_line] != 683)
		{
			procedDate[_line] = 683;
			init(_line);
			setData(_line, 35, 0, 436);
			setData(_line, 51, 3, 255);
			setData(_line, 51, 0, 437);
			setData(_line, 52, 2, 0);
			setData(_line, 52, 5, 0);
		}
	}

	public static void GD_BJT_charge_blue_01(int _line)
	{
		if (procedDate[_line] != 684)
		{
			procedDate[_line] = 684;
			init(_line);
			setData(_line, 0, 0, 426);
			setData(_line, 16, 3, 255);
			setData(_line, 16, 0, 427);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void GD_BJT_charge_blue_02(int _line)
	{
		if (procedDate[_line] != 685)
		{
			procedDate[_line] = 685;
			init(_line);
			setData(_line, 35, 0, 426);
			setData(_line, 51, 3, 255);
			setData(_line, 51, 0, 427);
			setData(_line, 52, 2, 0);
			setData(_line, 52, 5, 0);
		}
	}

	public static void GD_BJT_charge_yellow_01(int _line)
	{
		if (procedDate[_line] != 686)
		{
			procedDate[_line] = 686;
			init(_line);
			setData(_line, 0, 0, 438);
			setData(_line, 16, 3, 255);
			setData(_line, 16, 0, 439);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void GD_BJT_charge_yellow_02(int _line)
	{
		if (procedDate[_line] != 687)
		{
			procedDate[_line] = 687;
			init(_line);
			setData(_line, 35, 0, 438);
			setData(_line, 51, 3, 255);
			setData(_line, 51, 0, 439);
			setData(_line, 52, 2, 0);
			setData(_line, 52, 5, 0);
		}
	}

	public static void GD_BJT_charge_green_01(int _line)
	{
		if (procedDate[_line] != 688)
		{
			procedDate[_line] = 688;
			init(_line);
			setData(_line, 0, 0, 428);
			setData(_line, 16, 3, 255);
			setData(_line, 16, 0, 429);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void GD_BJT_charge_green_02(int _line)
	{
		if (procedDate[_line] != 689)
		{
			procedDate[_line] = 689;
			init(_line);
			setData(_line, 35, 0, 428);
			setData(_line, 51, 3, 255);
			setData(_line, 51, 0, 429);
			setData(_line, 52, 2, 0);
			setData(_line, 52, 5, 0);
		}
	}

	public static void GD_BJT_charge_red_01(int _line)
	{
		if (procedDate[_line] != 690)
		{
			procedDate[_line] = 690;
			init(_line);
			setData(_line, 0, 0, 434);
			setData(_line, 16, 3, 255);
			setData(_line, 16, 0, 435);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void GD_BJT_charge_red_02(int _line)
	{
		if (procedDate[_line] != 691)
		{
			procedDate[_line] = 691;
			init(_line);
			setData(_line, 35, 0, 434);
			setData(_line, 51, 3, 255);
			setData(_line, 51, 0, 435);
			setData(_line, 52, 2, 0);
			setData(_line, 52, 5, 0);
		}
	}

	public static void GD_BJT_charge_purple_01(int _line)
	{
		if (procedDate[_line] != 692)
		{
			procedDate[_line] = 692;
			init(_line);
			setData(_line, 0, 0, 430);
			setData(_line, 16, 3, 255);
			setData(_line, 16, 0, 431);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void GD_BJT_charge_purple_02(int _line)
	{
		if (procedDate[_line] != 693)
		{
			procedDate[_line] = 693;
			init(_line);
			setData(_line, 35, 0, 430);
			setData(_line, 51, 3, 255);
			setData(_line, 51, 0, 431);
			setData(_line, 52, 2, 0);
			setData(_line, 52, 5, 0);
		}
	}

	public static void GD_BJT_charge_rainbow_01(int _line)
	{
		if (procedDate[_line] != 694)
		{
			procedDate[_line] = 694;
			init(_line);
			setData(_line, 0, 0, 432);
			setData(_line, 16, 3, 255);
			setData(_line, 16, 0, 433);
			setData(_line, 136, 2, 0);
			setData(_line, 136, 5, 0);
		}
	}

	public static void GD_BJT_charge_rainbow_02(int _line)
	{
		if (procedDate[_line] != 695)
		{
			procedDate[_line] = 695;
			init(_line);
			setData(_line, 35, 0, 432);
			setData(_line, 51, 3, 255);
			setData(_line, 51, 0, 433);
			setData(_line, 171, 2, 0);
			setData(_line, 171, 5, 0);
		}
	}

	public static void GD_BJT_shoot_white(int _line)
	{
		if (procedDate[_line] != 696)
		{
			procedDate[_line] = 696;
			init(_line);
			setData(_line, 0, 0, 445);
			setData(_line, 30, 4, 0);
			setData(_line, 30, 5, 0);
		}
	}

	public static void GD_BJT_shoot_blue(int _line)
	{
		if (procedDate[_line] != 697)
		{
			procedDate[_line] = 697;
			init(_line);
			setData(_line, 0, 0, 440);
			setData(_line, 30, 4, 0);
			setData(_line, 30, 5, 0);
		}
	}

	public static void GD_BJT_shoot_yellow(int _line)
	{
		if (procedDate[_line] != 698)
		{
			procedDate[_line] = 698;
			init(_line);
			setData(_line, 0, 0, 446);
			setData(_line, 30, 4, 0);
			setData(_line, 30, 5, 0);
		}
	}

	public static void GD_BJT_shoot_green(int _line)
	{
		if (procedDate[_line] != 699)
		{
			procedDate[_line] = 699;
			init(_line);
			setData(_line, 0, 0, 441);
			setData(_line, 30, 4, 0);
			setData(_line, 30, 5, 0);
		}
	}

	public static void GD_BJT_shoot_red(int _line)
	{
		if (procedDate[_line] != 700)
		{
			procedDate[_line] = 700;
			init(_line);
			setData(_line, 0, 0, 444);
			setData(_line, 30, 4, 0);
			setData(_line, 30, 5, 0);
		}
	}

	public static void GD_BJT_shoot_purple(int _line)
	{
		if (procedDate[_line] != 701)
		{
			procedDate[_line] = 701;
			init(_line);
			setData(_line, 0, 0, 442);
			setData(_line, 30, 4, 0);
			setData(_line, 30, 5, 0);
		}
	}

	public static void GD_BJT_shoot_rainbow(int _line)
	{
		if (procedDate[_line] != 702)
		{
			procedDate[_line] = 702;
			init(_line);
			setData(_line, 0, 0, 443);
			setData(_line, 30, 4, 0);
			setData(_line, 30, 5, 0);
		}
	}

	public static void GD_DHI_01(int _line)
	{
		if (procedDate[_line] != 703)
		{
			procedDate[_line] = 703;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 0, 387);
			setData(_line, 9, 4, 0);
			setData(_line, 9, 5, 0);
		}
	}

	public static void GD_DHI_02(int _line)
	{
		if (procedDate[_line] != 704)
		{
			procedDate[_line] = 704;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 0, 387);
			setData(_line, 9, 4, 0);
			setData(_line, 9, 5, 0);
		}
	}

	public static void GD_DHI_03(int _line)
	{
		if (procedDate[_line] != 705)
		{
			procedDate[_line] = 705;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 26, 0, 388);
			setData(_line, 40, 4, 0);
			setData(_line, 40, 5, 0);
		}
	}

	public static void GD_BAO_struggle(int _line)
	{
		if (procedDate[_line] != 706)
		{
			procedDate[_line] = 706;
			init(_line);
			setData(_line, 0, 0, 447);
			setData(_line, 10, 2, 0);
			setData(_line, 10, 5, 0);
		}
	}

	public static void GD_BAO_struggle_win(int _line)
	{
		if (procedDate[_line] != 707)
		{
			procedDate[_line] = 707;
			init(_line);
			setData(_line, 0, 0, 450);
			setData(_line, 16, 3, 255);
			setData(_line, 16, 0, 451);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void GD_BAO_struggle_lose(int _line)
	{
		if (procedDate[_line] != 708)
		{
			procedDate[_line] = 708;
			init(_line);
			setData(_line, 0, 0, 448);
			setData(_line, 16, 3, 255);
			setData(_line, 16, 0, 449);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void GD_PRC_charge_white_01(int _line)
	{
		if (procedDate[_line] != 709)
		{
			procedDate[_line] = 709;
			init(_line);
			setData(_line, 85, 0, 465);
			setData(_line, 101, 3, 255);
			setData(_line, 101, 0, 466);
			setData(_line, 102, 2, 0);
			setData(_line, 102, 5, 0);
		}
	}

	public static void GD_PRC_charge_white_02(int _line)
	{
		if (procedDate[_line] != 710)
		{
			procedDate[_line] = 710;
			init(_line);
			setData(_line, 27, 0, 465);
			setData(_line, 43, 3, 255);
			setData(_line, 43, 0, 466);
			setData(_line, 44, 2, 0);
			setData(_line, 44, 5, 0);
		}
	}

	public static void GD_PRC_charge_blue_01(int _line)
	{
		if (procedDate[_line] != 711)
		{
			procedDate[_line] = 711;
			init(_line);
			setData(_line, 85, 0, 455);
			setData(_line, 101, 3, 255);
			setData(_line, 101, 0, 456);
			setData(_line, 102, 2, 0);
			setData(_line, 102, 5, 0);
		}
	}

	public static void GD_PRC_charge_blue_02(int _line)
	{
		if (procedDate[_line] != 712)
		{
			procedDate[_line] = 712;
			init(_line);
			setData(_line, 27, 0, 455);
			setData(_line, 43, 3, 255);
			setData(_line, 43, 0, 456);
			setData(_line, 44, 2, 0);
			setData(_line, 44, 5, 0);
		}
	}

	public static void GD_PRC_charge_yellow_01(int _line)
	{
		if (procedDate[_line] != 713)
		{
			procedDate[_line] = 713;
			init(_line);
			setData(_line, 85, 0, 467);
			setData(_line, 101, 3, 255);
			setData(_line, 101, 0, 468);
			setData(_line, 102, 2, 0);
			setData(_line, 102, 5, 0);
		}
	}

	public static void GD_PRC_charge_yellow_02(int _line)
	{
		if (procedDate[_line] != 714)
		{
			procedDate[_line] = 714;
			init(_line);
			setData(_line, 27, 0, 467);
			setData(_line, 43, 3, 255);
			setData(_line, 43, 0, 468);
			setData(_line, 44, 2, 0);
			setData(_line, 44, 5, 0);
		}
	}

	public static void GD_PRC_charge_green_01(int _line)
	{
		if (procedDate[_line] != 715)
		{
			procedDate[_line] = 715;
			init(_line);
			setData(_line, 85, 0, 457);
			setData(_line, 101, 3, 255);
			setData(_line, 101, 0, 458);
			setData(_line, 102, 2, 0);
			setData(_line, 102, 5, 0);
		}
	}

	public static void GD_PRC_charge_green_02(int _line)
	{
		if (procedDate[_line] != 716)
		{
			procedDate[_line] = 716;
			init(_line);
			setData(_line, 27, 0, 457);
			setData(_line, 43, 3, 255);
			setData(_line, 43, 0, 458);
			setData(_line, 44, 2, 0);
			setData(_line, 44, 5, 0);
		}
	}

	public static void GD_PRC_charge_red_01(int _line)
	{
		if (procedDate[_line] != 717)
		{
			procedDate[_line] = 717;
			init(_line);
			setData(_line, 85, 0, 463);
			setData(_line, 101, 3, 255);
			setData(_line, 101, 0, 464);
			setData(_line, 102, 2, 0);
			setData(_line, 102, 5, 0);
		}
	}

	public static void GD_PRC_charge_red_02(int _line)
	{
		if (procedDate[_line] != 718)
		{
			procedDate[_line] = 718;
			init(_line);
			setData(_line, 27, 0, 463);
			setData(_line, 43, 3, 255);
			setData(_line, 43, 0, 464);
			setData(_line, 44, 2, 0);
			setData(_line, 44, 5, 0);
		}
	}

	public static void GD_PRC_charge_purple_01(int _line)
	{
		if (procedDate[_line] != 719)
		{
			procedDate[_line] = 719;
			init(_line);
			setData(_line, 85, 0, 459);
			setData(_line, 101, 3, 255);
			setData(_line, 101, 0, 460);
			setData(_line, 102, 2, 0);
			setData(_line, 102, 5, 0);
		}
	}

	public static void GD_PRC_charge_purple_02(int _line)
	{
		if (procedDate[_line] != 720)
		{
			procedDate[_line] = 720;
			init(_line);
			setData(_line, 27, 0, 459);
			setData(_line, 43, 3, 255);
			setData(_line, 43, 0, 460);
			setData(_line, 44, 2, 0);
			setData(_line, 44, 5, 0);
		}
	}

	public static void GD_PRC_charge_rainbow_01(int _line)
	{
		if (procedDate[_line] != 721)
		{
			procedDate[_line] = 721;
			init(_line);
			setData(_line, 85, 0, 461);
			setData(_line, 101, 3, 255);
			setData(_line, 101, 0, 462);
			setData(_line, 221, 2, 0);
			setData(_line, 221, 5, 0);
		}
	}

	public static void GD_PRC_charge_rainbow_02(int _line)
	{
		if (procedDate[_line] != 722)
		{
			procedDate[_line] = 722;
			init(_line);
			setData(_line, 27, 0, 461);
			setData(_line, 43, 3, 255);
			setData(_line, 43, 0, 462);
			setData(_line, 163, 2, 0);
			setData(_line, 163, 5, 0);
		}
	}

	public static void GD_BTH_gear_stop(int _line)
	{
		if (procedDate[_line] != 723)
		{
			procedDate[_line] = 723;
			init(_line);
			setData(_line, 0, 0, 453);
			setData(_line, 10, 3, 255);
			setData(_line, 10, 0, 454);
			setData(_line, 11, 2, 0);
			setData(_line, 11, 5, 0);
		}
	}

	public static void GD_BJT_gear_stop(int _line)
	{
		if (procedDate[_line] != 724)
		{
			procedDate[_line] = 724;
			init(_line);
			setData(_line, 0, 0, 454);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void GD_HOH_psych_cutin(int _line)
	{
		if (procedDate[_line] != 725)
		{
			procedDate[_line] = 725;
			init(_line);
			setData(_line, 20, 3, 255);
			setData(_line, 140, 2, 0);
			setData(_line, 140, 5, 0);
		}
	}

	public static void GD_black(int _line)
	{
		if (procedDate[_line] != 726)
		{
			procedDate[_line] = 726;
			init(_line);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void GH_NML_01(int _line)
	{
		if (procedDate[_line] != 727)
		{
			procedDate[_line] = 727;
			init(_line);
			setData(_line, 0, 0, 484);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void GH_NML_02(int _line)
	{
		if (procedDate[_line] != 728)
		{
			procedDate[_line] = 728;
			init(_line);
			setData(_line, 0, 0, 485);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void GH_CST(int _line)
	{
		if (procedDate[_line] != 729)
		{
			procedDate[_line] = 729;
			init(_line);
			setData(_line, 0, 0, 480);
			setData(_line, 360, 2, 0);
			setData(_line, 360, 5, 0);
		}
	}

	public static void GH_JST(int _line)
	{
		if (procedDate[_line] != 730)
		{
			procedDate[_line] = 730;
			init(_line);
			setData(_line, 0, 0, 483);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void GH_HOH(int _line)
	{
		if (procedDate[_line] != 731)
		{
			procedDate[_line] = 731;
			init(_line);
			setData(_line, 0, 0, 482);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void GH_BONUS_GB_01(int _line)
	{
		if (procedDate[_line] != 732)
		{
			procedDate[_line] = 732;
			init(_line);
			setData(_line, 0, 0, 500);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void GH_BONUS_GB_02(int _line)
	{
		if (procedDate[_line] != 733)
		{
			procedDate[_line] = 733;
			init(_line);
			setData(_line, 0, 0, 501);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void GH_BONUS_RB(int _line)
	{
		if (procedDate[_line] != 734)
		{
			procedDate[_line] = 734;
			init(_line);
			setData(_line, 0, 0, 503);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void GH_BONUS_PB(int _line)
	{
		if (procedDate[_line] != 735)
		{
			procedDate[_line] = 735;
			init(_line);
			setData(_line, 0, 0, 502);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void GH_BD_ready(int _line)
	{
		if (procedDate[_line] != 736)
		{
			procedDate[_line] = 736;
			init(_line);
			setData(_line, 0, 0, 478);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void GH_BD(int _line)
	{
		if (procedDate[_line] != 737)
		{
			procedDate[_line] = 737;
			init(_line);
			setData(_line, 0, 0, 477);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void GH_RED(int _line)
	{
		if (procedDate[_line] != 738)
		{
			procedDate[_line] = 738;
			init(_line);
			setData(_line, 0, 0, 504);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void GH_CHAOS(int _line)
	{
		if (procedDate[_line] != 739)
		{
			procedDate[_line] = 739;
			init(_line);
			setData(_line, 0, 0, 479);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void GH_DI(int _line)
	{
		if (procedDate[_line] != 740)
		{
			procedDate[_line] = 740;
			init(_line);
			setData(_line, 0, 0, 481);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void GH_BONUS_ready(int _line)
	{
		if (procedDate[_line] != 741)
		{
			procedDate[_line] = 741;
			init(_line);
			setData(_line, 0, 0, 492);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void GH_BZT_01(int _line)
	{
		if (procedDate[_line] != 742)
		{
			procedDate[_line] = 742;
			init(_line);
			setData(_line, 0, 0, 493);
			setData(_line, 30, 2, 0);
			setData(_line, 30, 5, 0);
		}
	}

	public static void GH_BZT_02(int _line)
	{
		if (procedDate[_line] != 743)
		{
			procedDate[_line] = 743;
			init(_line);
			setData(_line, 0, 0, 494);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void GH_BZT_04(int _line)
	{
		if (procedDate[_line] != 744)
		{
			procedDate[_line] = 744;
			init(_line);
			setData(_line, 0, 0, 512);
			setData(_line, 120, 3, 255);
			setData(_line, 120, 0, 494);
			setData(_line, 240, 2, 0);
			setData(_line, 240, 5, 0);
		}
	}

	public static void GH_BZT_05(int _line)
	{
		if (procedDate[_line] != 745)
		{
			procedDate[_line] = 745;
			init(_line);
			setData(_line, 0, 0, 513);
			setData(_line, 120, 3, 255);
			setData(_line, 120, 0, 494);
			setData(_line, 240, 2, 0);
			setData(_line, 240, 5, 0);
		}
	}

	public static void GH_BZT_06(int _line)
	{
		if (procedDate[_line] != 746)
		{
			procedDate[_line] = 746;
			init(_line);
			setData(_line, 0, 0, 514);
			setData(_line, 90, 3, 255);
			setData(_line, 90, 0, 493);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void GH_BZT_end(int _line)
	{
		if (procedDate[_line] != 747)
		{
			procedDate[_line] = 747;
			init(_line);
			setData(_line, 0, 0, 507);
			setData(_line, 30, 3, 255);
			setData(_line, 30, 0, 508);
			setData(_line, 60, 2, 0);
			setData(_line, 60, 5, 0);
		}
	}

	public static void GH_PB(int _line)
	{
		if (procedDate[_line] != 748)
		{
			procedDate[_line] = 748;
			init(_line);
			setData(_line, 0, 0, 499);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void GH_freeze_PB(int _line)
	{
		if (procedDate[_line] != 749)
		{
			procedDate[_line] = 749;
			init(_line);
			setData(_line, 0, 0, 496);
			setData(_line, 70, 0, 497);
			setData(_line, 451, 3, 255);
			setData(_line, 451, 0, 498);
			setData(_line, 571, 2, 0);
			setData(_line, 571, 5, 0);
		}
	}

	public static void GH_theMAN(int _line)
	{
		if (procedDate[_line] != 750)
		{
			procedDate[_line] = 750;
			init(_line);
			setData(_line, 0, 0, 505);
			setData(_line, 114, 2, 0);
			setData(_line, 114, 5, 0);
		}
	}

	public static void GH_BZT_bal_entry(int _line)
	{
		if (procedDate[_line] != 751)
		{
			procedDate[_line] = 751;
			init(_line);
			setData(_line, 10, 0, 509);
			setData(_line, 160, 3, 255);
			setData(_line, 160, 0, 510);
			setData(_line, 167, 2, 0);
			setData(_line, 167, 5, 0);
		}
	}

	public static void GH_V(int _line)
	{
		if (procedDate[_line] != 752)
		{
			procedDate[_line] = 752;
			init(_line);
			setData(_line, 0, 0, 486);
			setData(_line, 120, 3, 255);
			setData(_line, 120, 0, 487);
			setData(_line, 240, 2, 0);
			setData(_line, 240, 5, 0);
		}
	}

	public static void GH_V_loop(int _line)
	{
		if (procedDate[_line] != 753)
		{
			procedDate[_line] = 753;
			init(_line);
			setData(_line, 0, 0, 487);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void GH_KCI_SU_sol(int _line)
	{
		if (procedDate[_line] != 754)
		{
			procedDate[_line] = 754;
			init(_line);
			setData(_line, 0, 0, 489);
			setData(_line, 62, 4, 0);
			setData(_line, 62, 5, 0);
		}
	}

	public static void GH_KCI_SU_sin(int _line)
	{
		if (procedDate[_line] != 755)
		{
			procedDate[_line] = 755;
			init(_line);
			setData(_line, 0, 0, 488);
			setData(_line, 62, 4, 0);
			setData(_line, 62, 5, 0);
		}
	}

	public static void GH_KCI_SU_solsin(int _line)
	{
		if (procedDate[_line] != 756)
		{
			procedDate[_line] = 756;
			init(_line);
			setData(_line, 0, 0, 490);
			setData(_line, 75, 4, 0);
			setData(_line, 75, 5, 0);
		}
	}

	public static void GH_KCI_other(int _line)
	{
		if (procedDate[_line] != 757)
		{
			procedDate[_line] = 757;
			init(_line);
			setData(_line, 0, 0, 491);
			setData(_line, 45, 4, 0);
			setData(_line, 45, 5, 0);
		}
	}

	public static void GH_blackout(int _line)
	{
		if (procedDate[_line] != 758)
		{
			procedDate[_line] = 758;
			init(_line);
			setData(_line, 0, 3, 60);
			setData(_line, 0, 0, 511);
			setData(_line, 1, 2, 0);
			setData(_line, 1, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void GH_KCI_sol(int _line)
	{
		if (procedDate[_line] != 759)
		{
			procedDate[_line] = 759;
			init(_line);
			setData(_line, 0, 0, 520);
			setData(_line, 45, 4, 0);
			setData(_line, 45, 5, 0);
		}
	}

	public static void GH_KCI_sin(int _line)
	{
		if (procedDate[_line] != 760)
		{
			procedDate[_line] = 760;
			init(_line);
			setData(_line, 0, 0, 519);
			setData(_line, 45, 4, 0);
			setData(_line, 45, 5, 0);
		}
	}

	public static void GH_KCI_kai(int _line)
	{
		if (procedDate[_line] != 761)
		{
			procedDate[_line] = 761;
			init(_line);
			setData(_line, 0, 0, 517);
			setData(_line, 45, 4, 0);
			setData(_line, 45, 5, 0);
		}
	}

	public static void GH_KCI_diz(int _line)
	{
		if (procedDate[_line] != 762)
		{
			procedDate[_line] = 762;
			init(_line);
			setData(_line, 0, 0, 516);
			setData(_line, 45, 4, 0);
			setData(_line, 45, 5, 0);
		}
	}

	public static void GH_KCI_man(int _line)
	{
		if (procedDate[_line] != 763)
		{
			procedDate[_line] = 763;
			init(_line);
			setData(_line, 0, 0, 518);
			setData(_line, 45, 4, 0);
			setData(_line, 45, 5, 0);
		}
	}

	public static void GH_KCI_dai(int _line)
	{
		if (procedDate[_line] != 764)
		{
			procedDate[_line] = 764;
			init(_line);
			setData(_line, 0, 0, 515);
			setData(_line, 45, 4, 0);
			setData(_line, 45, 5, 0);
		}
	}

	public static void GH_HOH_02(int _line)
	{
		if (procedDate[_line] != 765)
		{
			procedDate[_line] = 765;
			init(_line);
			setData(_line, 0, 0, 482);
			setData(_line, 120, 2, 0);
			setData(_line, 120, 5, 0);
		}
	}

	public static void OFF_0m(int _line)
	{
		if (procedDate[_line] != 766)
		{
			procedDate[_line] = 766;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void reel_00(int _line)
	{
		if (procedDate[_line] != 767)
		{
			procedDate[_line] = 767;
			init(_line);
			setData(_line, 0, 0, 194);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void reel_PB(int _line)
	{
		if (procedDate[_line] != 768)
		{
			procedDate[_line] = 768;
			init(_line);
			setData(_line, 0, 0, 195);
			setData(_line, 69, 3, 255);
			setData(_line, 69, 0, 196);
			setData(_line, 102, 2, 0);
			setData(_line, 102, 5, 0);
		}
	}

	public static void reel_MB(int _line)
	{
		if (procedDate[_line] != 769)
		{
			procedDate[_line] = 769;
			init(_line);
			setData(_line, 0, 0, 197);
			setData(_line, 36, 3, 255);
			setData(_line, 36, 0, 194);
			setData(_line, 38, 2, 0);
			setData(_line, 38, 5, 0);
		}
	}

	public static void reel_7_w1(int _line)
	{
		if (procedDate[_line] != 770)
		{
			procedDate[_line] = 770;
			init(_line);
			setData(_line, 0, 0, 198);
			setData(_line, 92, 3, 255);
			setData(_line, 92, 0, 199);
			setData(_line, 98, 2, 0);
			setData(_line, 98, 5, 0);
		}
	}

	public static void reel_7_w2(int _line)
	{
		if (procedDate[_line] != 771)
		{
			procedDate[_line] = 771;
			init(_line);
			setData(_line, 0, 0, 200);
			setData(_line, 92, 3, 255);
			setData(_line, 92, 0, 201);
			setData(_line, 98, 2, 0);
			setData(_line, 98, 5, 0);
		}
	}

	public static void reel_7_c(int _line)
	{
		if (procedDate[_line] != 772)
		{
			procedDate[_line] = 772;
			init(_line);
			setData(_line, 0, 0, 202);
			setData(_line, 92, 3, 255);
			setData(_line, 92, 0, 203);
			setData(_line, 98, 2, 0);
			setData(_line, 98, 5, 0);
		}
	}

	public static void reel_7_cu(int _line)
	{
		if (procedDate[_line] != 773)
		{
			procedDate[_line] = 773;
			init(_line);
			setData(_line, 0, 0, 204);
			setData(_line, 92, 3, 255);
			setData(_line, 92, 0, 205);
			setData(_line, 98, 2, 0);
			setData(_line, 98, 5, 0);
		}
	}

	public static void reel_7_cd(int _line)
	{
		if (procedDate[_line] != 774)
		{
			procedDate[_line] = 774;
			init(_line);
			setData(_line, 0, 0, 206);
			setData(_line, 92, 3, 255);
			setData(_line, 92, 0, 207);
			setData(_line, 98, 2, 0);
			setData(_line, 98, 5, 0);
		}
	}

	public static void reel_bar(int _line)
	{
		if (procedDate[_line] != 775)
		{
			procedDate[_line] = 775;
			init(_line);
			setData(_line, 0, 0, 208);
			setData(_line, 105, 3, 255);
			setData(_line, 105, 0, 209);
			setData(_line, 111, 2, 0);
			setData(_line, 111, 5, 0);
		}
	}

	public static void reel_bonus_in(int _line)
	{
		if (procedDate[_line] != 776)
		{
			procedDate[_line] = 776;
			init(_line);
			setData(_line, 0, 0, 210);
			setData(_line, 77, 3, 255);
			setData(_line, 77, 0, 211);
			setData(_line, 83, 2, 0);
			setData(_line, 83, 5, 0);
		}
	}

	public static void reel_dest_start(int _line)
	{
		if (procedDate[_line] != 777)
		{
			procedDate[_line] = 777;
			init(_line);
			setData(_line, 0, 0, 212);
			setData(_line, 16, 3, 255);
			setData(_line, 16, 0, 213);
			setData(_line, 18, 2, 0);
			setData(_line, 18, 5, 0);
		}
	}

	public static void reel_dest_01(int _line)
	{
		if (procedDate[_line] != 778)
		{
			procedDate[_line] = 778;
			init(_line);
			setData(_line, 0, 0, 214);
			setData(_line, 9, 3, 255);
			setData(_line, 9, 0, 215);
			setData(_line, 25, 2, 0);
			setData(_line, 25, 5, 0);
		}
	}

	public static void reel_dest_02(int _line)
	{
		if (procedDate[_line] != 779)
		{
			procedDate[_line] = 779;
			init(_line);
			setData(_line, 0, 0, 216);
			setData(_line, 9, 3, 255);
			setData(_line, 9, 0, 217);
			setData(_line, 25, 2, 0);
			setData(_line, 25, 5, 0);
		}
	}

	public static void reel_dest_03(int _line)
	{
		if (procedDate[_line] != 780)
		{
			procedDate[_line] = 780;
			init(_line);
			setData(_line, 0, 0, 218);
			setData(_line, 9, 3, 255);
			setData(_line, 9, 0, 219);
			setData(_line, 25, 2, 0);
			setData(_line, 25, 5, 0);
		}
	}

	public static void reel_dest_in(int _line)
	{
		if (procedDate[_line] != 781)
		{
			procedDate[_line] = 781;
			init(_line);
			setData(_line, 0, 0, 220);
			setData(_line, 86, 3, 255);
			setData(_line, 86, 0, 194);
			setData(_line, 88, 2, 0);
			setData(_line, 88, 5, 0);
		}
	}

	public static void reel_dest_miss(int _line)
	{
		if (procedDate[_line] != 782)
		{
			procedDate[_line] = 782;
			init(_line);
			setData(_line, 0, 0, 221);
			setData(_line, 20, 3, 255);
			setData(_line, 20, 0, 222);
			setData(_line, 22, 2, 0);
			setData(_line, 22, 5, 0);
		}
	}

	public static void reel_dest_0G(int _line)
	{
		if (procedDate[_line] != 783)
		{
			procedDate[_line] = 783;
			init(_line);
			setData(_line, 0, 0, 223);
			setData(_line, 56, 3, 255);
			setData(_line, 56, 0, 224);
			setData(_line, 58, 2, 0);
			setData(_line, 58, 5, 0);
		}
	}

	public static void reel_replay_01(int _line)
	{
		if (procedDate[_line] != 784)
		{
			procedDate[_line] = 784;
			init(_line);
			setData(_line, 0, 0, 225);
			setData(_line, 19, 3, 255);
			setData(_line, 19, 0, 194);
			setData(_line, 21, 2, 0);
			setData(_line, 21, 5, 0);
		}
	}

	public static void reel_replay_02(int _line)
	{
		if (procedDate[_line] != 785)
		{
			procedDate[_line] = 785;
			init(_line);
			setData(_line, 0, 0, 226);
			setData(_line, 19, 3, 255);
			setData(_line, 19, 0, 194);
			setData(_line, 21, 2, 0);
			setData(_line, 21, 5, 0);
		}
	}

	public static void reel_replay_03(int _line)
	{
		if (procedDate[_line] != 786)
		{
			procedDate[_line] = 786;
			init(_line);
			setData(_line, 0, 0, 227);
			setData(_line, 19, 3, 255);
			setData(_line, 19, 0, 194);
			setData(_line, 21, 2, 0);
			setData(_line, 21, 5, 0);
		}
	}

	public static void reel_replay_04(int _line)
	{
		if (procedDate[_line] != 787)
		{
			procedDate[_line] = 787;
			init(_line);
			setData(_line, 0, 0, 228);
			setData(_line, 19, 3, 255);
			setData(_line, 19, 0, 229);
			setData(_line, 36, 2, 0);
			setData(_line, 36, 5, 0);
		}
	}

	public static void reel_replay_05(int _line)
	{
		if (procedDate[_line] != 788)
		{
			procedDate[_line] = 788;
			init(_line);
			setData(_line, 0, 0, 230);
			setData(_line, 19, 3, 255);
			setData(_line, 19, 0, 231);
			setData(_line, 36, 2, 0);
			setData(_line, 36, 5, 0);
		}
	}

	public static void reel_replay_06(int _line)
	{
		if (procedDate[_line] != 789)
		{
			procedDate[_line] = 789;
			init(_line);
			setData(_line, 0, 0, 232);
			setData(_line, 35, 3, 255);
			setData(_line, 35, 0, 233);
			setData(_line, 41, 2, 0);
			setData(_line, 41, 5, 0);
		}
	}

	public static void reel_replay_07(int _line)
	{
		if (procedDate[_line] != 790)
		{
			procedDate[_line] = 790;
			init(_line);
			setData(_line, 0, 0, 234);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void reel_replay_08(int _line)
	{
		if (procedDate[_line] != 791)
		{
			procedDate[_line] = 791;
			init(_line);
			setData(_line, 0, 0, 235);
			setData(_line, 17, 3, 255);
			setData(_line, 17, 0, 236);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void reel_replay_09(int _line)
	{
		if (procedDate[_line] != 792)
		{
			procedDate[_line] = 792;
			init(_line);
			setData(_line, 0, 0, 237);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void reel_replay_10(int _line)
	{
		if (procedDate[_line] != 793)
		{
			procedDate[_line] = 793;
			init(_line);
			setData(_line, 0, 0, 238);
			setData(_line, 17, 3, 255);
			setData(_line, 17, 0, 239);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void reel_replay_11(int _line)
	{
		if (procedDate[_line] != 794)
		{
			procedDate[_line] = 794;
			init(_line);
			setData(_line, 0, 0, 240);
			setData(_line, 84, 3, 255);
			setData(_line, 84, 0, 241);
			setData(_line, 86, 2, 0);
			setData(_line, 86, 5, 0);
		}
	}

	public static void reel_replay_12(int _line)
	{
		if (procedDate[_line] != 795)
		{
			procedDate[_line] = 795;
			init(_line);
			setData(_line, 0, 0, 242);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void reel_replay_13(int _line)
	{
		if (procedDate[_line] != 796)
		{
			procedDate[_line] = 796;
			init(_line);
			setData(_line, 0, 0, 243);
			setData(_line, 17, 3, 255);
			setData(_line, 17, 0, 244);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void reel_bell_01(int _line)
	{
		if (procedDate[_line] != 797)
		{
			procedDate[_line] = 797;
			init(_line);
			setData(_line, 0, 0, 245);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void reel_bell_02(int _line)
	{
		if (procedDate[_line] != 798)
		{
			procedDate[_line] = 798;
			init(_line);
			setData(_line, 0, 0, 246);
			setData(_line, 17, 3, 255);
			setData(_line, 17, 0, 247);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void reel_bell_03(int _line)
	{
		if (procedDate[_line] != 799)
		{
			procedDate[_line] = 799;
			init(_line);
			setData(_line, 0, 0, 248);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void reel_bell_04(int _line)
	{
		if (procedDate[_line] != 800)
		{
			procedDate[_line] = 800;
			init(_line);
			setData(_line, 0, 0, 249);
			setData(_line, 17, 3, 255);
			setData(_line, 17, 0, 250);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void reel_bell_05(int _line)
	{
		if (procedDate[_line] != 801)
		{
			procedDate[_line] = 801;
			init(_line);
			setData(_line, 0, 0, 251);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void reel_bell_06(int _line)
	{
		if (procedDate[_line] != 802)
		{
			procedDate[_line] = 802;
			init(_line);
			setData(_line, 0, 0, 252);
			setData(_line, 17, 3, 255);
			setData(_line, 17, 0, 253);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void reel_bell_07(int _line)
	{
		if (procedDate[_line] != 803)
		{
			procedDate[_line] = 803;
			init(_line);
			setData(_line, 0, 0, 254);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void reel_bell_08(int _line)
	{
		if (procedDate[_line] != 804)
		{
			procedDate[_line] = 804;
			init(_line);
			setData(_line, 0, 0, 255);
			setData(_line, 17, 3, 255);
			setData(_line, 17, 0, 256);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void reel_bell_09(int _line)
	{
		if (procedDate[_line] != 805)
		{
			procedDate[_line] = 805;
			init(_line);
			setData(_line, 0, 0, 257);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void reel_bell_10(int _line)
	{
		if (procedDate[_line] != 806)
		{
			procedDate[_line] = 806;
			init(_line);
			setData(_line, 0, 0, 258);
			setData(_line, 17, 3, 255);
			setData(_line, 17, 0, 259);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void reel_bell_11(int _line)
	{
		if (procedDate[_line] != 807)
		{
			procedDate[_line] = 807;
			init(_line);
			setData(_line, 0, 0, 260);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void reel_bell_12(int _line)
	{
		if (procedDate[_line] != 808)
		{
			procedDate[_line] = 808;
			init(_line);
			setData(_line, 0, 0, 261);
			setData(_line, 17, 3, 255);
			setData(_line, 17, 0, 262);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void reel_bell_13(int _line)
	{
		if (procedDate[_line] != 809)
		{
			procedDate[_line] = 809;
			init(_line);
			setData(_line, 0, 0, 263);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void reel_bell_14(int _line)
	{
		if (procedDate[_line] != 810)
		{
			procedDate[_line] = 810;
			init(_line);
			setData(_line, 0, 0, 264);
			setData(_line, 17, 3, 255);
			setData(_line, 17, 0, 265);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void reel_bell_15(int _line)
	{
		if (procedDate[_line] != 811)
		{
			procedDate[_line] = 811;
			init(_line);
			setData(_line, 0, 0, 266);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void reel_bell_16(int _line)
	{
		if (procedDate[_line] != 812)
		{
			procedDate[_line] = 812;
			init(_line);
			setData(_line, 0, 0, 267);
			setData(_line, 17, 3, 255);
			setData(_line, 17, 0, 268);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void reel_bell_17(int _line)
	{
		if (procedDate[_line] != 813)
		{
			procedDate[_line] = 813;
			init(_line);
			setData(_line, 0, 0, 269);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void reel_bell_18(int _line)
	{
		if (procedDate[_line] != 814)
		{
			procedDate[_line] = 814;
			init(_line);
			setData(_line, 0, 0, 270);
			setData(_line, 17, 3, 255);
			setData(_line, 17, 0, 271);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void reel_bell_19(int _line)
	{
		if (procedDate[_line] != 815)
		{
			procedDate[_line] = 815;
			init(_line);
			setData(_line, 0, 0, 272);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void reel_bell_20(int _line)
	{
		if (procedDate[_line] != 816)
		{
			procedDate[_line] = 816;
			init(_line);
			setData(_line, 0, 0, 273);
			setData(_line, 17, 3, 255);
			setData(_line, 17, 0, 274);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void reel_bell_21(int _line)
	{
		if (procedDate[_line] != 817)
		{
			procedDate[_line] = 817;
			init(_line);
			setData(_line, 0, 0, 275);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void reel_bell_22(int _line)
	{
		if (procedDate[_line] != 818)
		{
			procedDate[_line] = 818;
			init(_line);
			setData(_line, 0, 0, 276);
			setData(_line, 17, 3, 255);
			setData(_line, 17, 0, 277);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void reel_bell_23(int _line)
	{
		if (procedDate[_line] != 819)
		{
			procedDate[_line] = 819;
			init(_line);
			setData(_line, 0, 0, 278);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void reel_bell_24(int _line)
	{
		if (procedDate[_line] != 820)
		{
			procedDate[_line] = 820;
			init(_line);
			setData(_line, 0, 0, 279);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void reel_bell_25(int _line)
	{
		if (procedDate[_line] != 821)
		{
			procedDate[_line] = 821;
			init(_line);
			setData(_line, 0, 0, 280);
			setData(_line, 26, 3, 255);
			setData(_line, 26, 0, 281);
			setData(_line, 32, 2, 0);
			setData(_line, 32, 5, 0);
		}
	}

	public static void reel_bell_26(int _line)
	{
		if (procedDate[_line] != 822)
		{
			procedDate[_line] = 822;
			init(_line);
			setData(_line, 0, 0, 300);
			setData(_line, 20, 3, 255);
			setData(_line, 20, 0, 282);
			setData(_line, 37, 2, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void reel_bell_27(int _line)
	{
		if (procedDate[_line] != 823)
		{
			procedDate[_line] = 823;
			init(_line);
			setData(_line, 0, 0, 301);
			setData(_line, 20, 3, 255);
			setData(_line, 20, 0, 283);
			setData(_line, 37, 2, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void reel_bell_28(int _line)
	{
		if (procedDate[_line] != 824)
		{
			procedDate[_line] = 824;
			init(_line);
			setData(_line, 0, 0, 300);
			setData(_line, 20, 3, 255);
			setData(_line, 20, 0, 284);
			setData(_line, 37, 2, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void reel_bell_29(int _line)
	{
		if (procedDate[_line] != 825)
		{
			procedDate[_line] = 825;
			init(_line);
			setData(_line, 0, 0, 301);
			setData(_line, 20, 3, 255);
			setData(_line, 20, 0, 285);
			setData(_line, 37, 2, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void reel_bell_30(int _line)
	{
		if (procedDate[_line] != 826)
		{
			procedDate[_line] = 826;
			init(_line);
			setData(_line, 0, 0, 298);
			setData(_line, 20, 3, 255);
			setData(_line, 20, 0, 286);
			setData(_line, 37, 2, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void reel_bell_31(int _line)
	{
		if (procedDate[_line] != 827)
		{
			procedDate[_line] = 827;
			init(_line);
			setData(_line, 0, 0, 299);
			setData(_line, 20, 3, 255);
			setData(_line, 20, 0, 287);
			setData(_line, 37, 2, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void reel_bell_32(int _line)
	{
		if (procedDate[_line] != 828)
		{
			procedDate[_line] = 828;
			init(_line);
			setData(_line, 0, 0, 298);
			setData(_line, 20, 3, 255);
			setData(_line, 20, 0, 288);
			setData(_line, 37, 2, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void reel_bell_33(int _line)
	{
		if (procedDate[_line] != 829)
		{
			procedDate[_line] = 829;
			init(_line);
			setData(_line, 0, 0, 299);
			setData(_line, 20, 3, 255);
			setData(_line, 20, 0, 289);
			setData(_line, 37, 2, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void reel_bell_34(int _line)
	{
		if (procedDate[_line] != 830)
		{
			procedDate[_line] = 830;
			init(_line);
			setData(_line, 0, 0, 298);
			setData(_line, 20, 3, 255);
			setData(_line, 20, 0, 290);
			setData(_line, 37, 2, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void reel_bell_35(int _line)
	{
		if (procedDate[_line] != 831)
		{
			procedDate[_line] = 831;
			init(_line);
			setData(_line, 0, 0, 299);
			setData(_line, 20, 3, 255);
			setData(_line, 20, 0, 291);
			setData(_line, 37, 2, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void reel_bell_36(int _line)
	{
		if (procedDate[_line] != 832)
		{
			procedDate[_line] = 832;
			init(_line);
			setData(_line, 0, 0, 298);
			setData(_line, 20, 3, 255);
			setData(_line, 20, 0, 292);
			setData(_line, 37, 2, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void reel_bell_37(int _line)
	{
		if (procedDate[_line] != 833)
		{
			procedDate[_line] = 833;
			init(_line);
			setData(_line, 0, 0, 299);
			setData(_line, 20, 3, 255);
			setData(_line, 20, 0, 293);
			setData(_line, 37, 2, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void reel_bell_38(int _line)
	{
		if (procedDate[_line] != 834)
		{
			procedDate[_line] = 834;
			init(_line);
			setData(_line, 0, 0, 298);
			setData(_line, 20, 3, 255);
			setData(_line, 20, 0, 294);
			setData(_line, 37, 2, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void reel_bell_39(int _line)
	{
		if (procedDate[_line] != 835)
		{
			procedDate[_line] = 835;
			init(_line);
			setData(_line, 0, 0, 299);
			setData(_line, 20, 3, 255);
			setData(_line, 20, 0, 295);
			setData(_line, 37, 2, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void reel_bell_40(int _line)
	{
		if (procedDate[_line] != 836)
		{
			procedDate[_line] = 836;
			init(_line);
			setData(_line, 0, 0, 298);
			setData(_line, 20, 3, 255);
			setData(_line, 20, 0, 296);
			setData(_line, 37, 2, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void reel_bell_41(int _line)
	{
		if (procedDate[_line] != 837)
		{
			procedDate[_line] = 837;
			init(_line);
			setData(_line, 0, 0, 299);
			setData(_line, 20, 3, 255);
			setData(_line, 20, 0, 297);
			setData(_line, 37, 2, 0);
			setData(_line, 37, 5, 0);
		}
	}

	public static void reel_suika_01(int _line)
	{
		if (procedDate[_line] != 838)
		{
			procedDate[_line] = 838;
			init(_line);
			setData(_line, 0, 0, 302);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void reel_suika_02(int _line)
	{
		if (procedDate[_line] != 839)
		{
			procedDate[_line] = 839;
			init(_line);
			setData(_line, 0, 0, 303);
			setData(_line, 17, 3, 255);
			setData(_line, 17, 0, 304);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void reel_suika_03(int _line)
	{
		if (procedDate[_line] != 840)
		{
			procedDate[_line] = 840;
			init(_line);
			setData(_line, 0, 0, 305);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void reel_suika_04(int _line)
	{
		if (procedDate[_line] != 841)
		{
			procedDate[_line] = 841;
			init(_line);
			setData(_line, 0, 0, 306);
			setData(_line, 17, 3, 255);
			setData(_line, 17, 0, 307);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void reel_suika_05(int _line)
	{
		if (procedDate[_line] != 842)
		{
			procedDate[_line] = 842;
			init(_line);
			setData(_line, 0, 0, 308);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void reel_suika_06(int _line)
	{
		if (procedDate[_line] != 843)
		{
			procedDate[_line] = 843;
			init(_line);
			setData(_line, 0, 0, 309);
			setData(_line, 17, 3, 255);
			setData(_line, 17, 0, 310);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void reel_suika_07(int _line)
	{
		if (procedDate[_line] != 844)
		{
			procedDate[_line] = 844;
			init(_line);
			setData(_line, 0, 0, 311);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void reel_suika_08(int _line)
	{
		if (procedDate[_line] != 845)
		{
			procedDate[_line] = 845;
			init(_line);
			setData(_line, 0, 0, 312);
			setData(_line, 17, 3, 255);
			setData(_line, 17, 0, 313);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void reel_cherry_01(int _line)
	{
		if (procedDate[_line] != 846)
		{
			procedDate[_line] = 846;
			init(_line);
			setData(_line, 0, 0, 314);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void reel_cherry_02(int _line)
	{
		if (procedDate[_line] != 847)
		{
			procedDate[_line] = 847;
			init(_line);
			setData(_line, 0, 0, 315);
			setData(_line, 17, 3, 255);
			setData(_line, 17, 0, 316);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void reel_cherry_03(int _line)
	{
		if (procedDate[_line] != 848)
		{
			procedDate[_line] = 848;
			init(_line);
			setData(_line, 0, 0, 317);
			setData(_line, 14, 3, 255);
			setData(_line, 14, 0, 318);
			setData(_line, 20, 2, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void reel_cherry_04(int _line)
	{
		if (procedDate[_line] != 849)
		{
			procedDate[_line] = 849;
			init(_line);
			setData(_line, 0, 0, 319);
			setData(_line, 14, 3, 255);
			setData(_line, 14, 0, 320);
			setData(_line, 20, 2, 0);
			setData(_line, 20, 5, 0);
		}
	}

	public static void reel_cherry_05(int _line)
	{
		if (procedDate[_line] != 850)
		{
			procedDate[_line] = 850;
			init(_line);
			setData(_line, 0, 0, 322);
			setData(_line, 17, 3, 255);
			setData(_line, 17, 0, 323);
			setData(_line, 23, 2, 0);
			setData(_line, 23, 5, 0);
		}
	}

	public static void reel_cherry_c(int _line)
	{
		if (procedDate[_line] != 851)
		{
			procedDate[_line] = 851;
			init(_line);
			setData(_line, 0, 0, 321);
			setData(_line, 17, 2, 0);
			setData(_line, 17, 5, 0);
		}
	}

	public static void reel_chance_01(int _line)
	{
		if (procedDate[_line] != 852)
		{
			procedDate[_line] = 852;
			init(_line);
			setData(_line, 0, 0, 324);
			setData(_line, 29, 3, 255);
			setData(_line, 29, 0, 325);
			setData(_line, 31, 2, 0);
			setData(_line, 31, 5, 0);
		}
	}

	public static void reel_chance_02(int _line)
	{
		if (procedDate[_line] != 853)
		{
			procedDate[_line] = 853;
			init(_line);
			setData(_line, 0, 0, 326);
			setData(_line, 29, 3, 255);
			setData(_line, 29, 0, 327);
			setData(_line, 31, 2, 0);
			setData(_line, 31, 5, 0);
		}
	}

	public static void reel_chance_03(int _line)
	{
		if (procedDate[_line] != 854)
		{
			procedDate[_line] = 854;
			init(_line);
			setData(_line, 0, 0, 328);
			setData(_line, 40, 3, 255);
			setData(_line, 40, 0, 329);
			setData(_line, 42, 2, 0);
			setData(_line, 42, 5, 0);
		}
	}

	public static void reel_chance_04(int _line)
	{
		if (procedDate[_line] != 855)
		{
			procedDate[_line] = 855;
			init(_line);
			setData(_line, 0, 0, 330);
			setData(_line, 40, 3, 255);
			setData(_line, 40, 0, 331);
			setData(_line, 42, 2, 0);
			setData(_line, 42, 5, 0);
		}
	}

	public static void reel_v(int _line)
	{
		if (procedDate[_line] != 856)
		{
			procedDate[_line] = 856;
			init(_line);
			setData(_line, 0, 0, 332);
			setData(_line, 45, 3, 255);
			setData(_line, 45, 0, 194);
			setData(_line, 47, 2, 0);
			setData(_line, 47, 5, 0);
		}
	}

	public static void reel_demo(int _line)
	{
		if (procedDate[_line] != 857)
		{
			procedDate[_line] = 857;
			init(_line);
			setData(_line, 0, 0, 333);
			setData(_line, 124, 2, 0);
			setData(_line, 124, 5, 0);
		}
	}

	public static void OFF_1m(int _line)
	{
		if (procedDate[_line] != 858)
		{
			procedDate[_line] = 858;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void m_panel_NV_y_L(int _line)
	{
		if (procedDate[_line] != 859)
		{
			procedDate[_line] = 859;
			init(_line);
			setData(_line, 0, 0, 104);
			setData(_line, 16, 2, 0);
			setData(_line, 16, 5, 0);
		}
	}

	public static void m_panel_NV_y_C(int _line)
	{
		if (procedDate[_line] != 860)
		{
			procedDate[_line] = 860;
			init(_line);
			setData(_line, 0, 0, 105);
			setData(_line, 16, 2, 0);
			setData(_line, 16, 5, 0);
		}
	}

	public static void m_panel_NV_y_R(int _line)
	{
		if (procedDate[_line] != 861)
		{
			procedDate[_line] = 861;
			init(_line);
			setData(_line, 0, 0, 106);
			setData(_line, 16, 2, 0);
			setData(_line, 16, 5, 0);
		}
	}

	public static void m_panel_NV_y_get(int _line)
	{
		if (procedDate[_line] != 862)
		{
			procedDate[_line] = 862;
			init(_line);
			setData(_line, 0, 0, 107);
			setData(_line, 44, 4, 0);
			setData(_line, 44, 5, 0);
		}
	}

	public static void m_panel_NV_b_L(int _line)
	{
		if (procedDate[_line] != 863)
		{
			procedDate[_line] = 863;
			init(_line);
			setData(_line, 0, 0, 108);
			setData(_line, 16, 2, 0);
			setData(_line, 16, 5, 0);
		}
	}

	public static void m_panel_NV_b_C(int _line)
	{
		if (procedDate[_line] != 864)
		{
			procedDate[_line] = 864;
			init(_line);
			setData(_line, 0, 0, 109);
			setData(_line, 16, 2, 0);
			setData(_line, 16, 5, 0);
		}
	}

	public static void m_panel_NV_b_R(int _line)
	{
		if (procedDate[_line] != 865)
		{
			procedDate[_line] = 865;
			init(_line);
			setData(_line, 0, 0, 110);
			setData(_line, 16, 2, 0);
			setData(_line, 16, 5, 0);
		}
	}

	public static void m_panel_NV_b_get(int _line)
	{
		if (procedDate[_line] != 866)
		{
			procedDate[_line] = 866;
			init(_line);
			setData(_line, 0, 0, 111);
			setData(_line, 30, 4, 0);
			setData(_line, 30, 5, 0);
		}
	}

	public static void m_panel_NV_w_L(int _line)
	{
		if (procedDate[_line] != 867)
		{
			procedDate[_line] = 867;
			init(_line);
			setData(_line, 0, 0, 112);
			setData(_line, 16, 2, 0);
			setData(_line, 16, 5, 0);
		}
	}

	public static void m_panel_NV_w_C(int _line)
	{
		if (procedDate[_line] != 868)
		{
			procedDate[_line] = 868;
			init(_line);
			setData(_line, 0, 0, 113);
			setData(_line, 16, 2, 0);
			setData(_line, 16, 5, 0);
		}
	}

	public static void m_panel_NV_w_R(int _line)
	{
		if (procedDate[_line] != 869)
		{
			procedDate[_line] = 869;
			init(_line);
			setData(_line, 0, 0, 114);
			setData(_line, 16, 2, 0);
			setData(_line, 16, 5, 0);
		}
	}

	public static void m_panel_NV_w_get(int _line)
	{
		if (procedDate[_line] != 870)
		{
			procedDate[_line] = 870;
			init(_line);
			setData(_line, 0, 0, 115);
			setData(_line, 40, 4, 0);
			setData(_line, 40, 5, 0);
		}
	}

	public static void m_panel_NV_p_L(int _line)
	{
		if (procedDate[_line] != 871)
		{
			procedDate[_line] = 871;
			init(_line);
			setData(_line, 0, 0, 116);
			setData(_line, 16, 2, 0);
			setData(_line, 16, 5, 0);
		}
	}

	public static void m_panel_NV_p_C(int _line)
	{
		if (procedDate[_line] != 872)
		{
			procedDate[_line] = 872;
			init(_line);
			setData(_line, 0, 0, 117);
			setData(_line, 16, 2, 0);
			setData(_line, 16, 5, 0);
		}
	}

	public static void m_panel_NV_p_R(int _line)
	{
		if (procedDate[_line] != 873)
		{
			procedDate[_line] = 873;
			init(_line);
			setData(_line, 0, 0, 118);
			setData(_line, 16, 2, 0);
			setData(_line, 16, 5, 0);
		}
	}

	public static void m_panel_NV_p_get(int _line)
	{
		if (procedDate[_line] != 874)
		{
			procedDate[_line] = 874;
			init(_line);
			setData(_line, 0, 0, 119);
			setData(_line, 44, 4, 0);
			setData(_line, 44, 5, 0);
		}
	}

	public static void m_panel_NV_r_L(int _line)
	{
		if (procedDate[_line] != 875)
		{
			procedDate[_line] = 875;
			init(_line);
			setData(_line, 0, 0, 120);
			setData(_line, 16, 2, 0);
			setData(_line, 16, 5, 0);
		}
	}

	public static void m_panel_NV_r_C(int _line)
	{
		if (procedDate[_line] != 876)
		{
			procedDate[_line] = 876;
			init(_line);
			setData(_line, 0, 0, 121);
			setData(_line, 16, 2, 0);
			setData(_line, 16, 5, 0);
		}
	}

	public static void m_panel_NV_r_R(int _line)
	{
		if (procedDate[_line] != 877)
		{
			procedDate[_line] = 877;
			init(_line);
			setData(_line, 0, 0, 122);
			setData(_line, 16, 2, 0);
			setData(_line, 16, 5, 0);
		}
	}

	public static void m_panel_NV_r_get(int _line)
	{
		if (procedDate[_line] != 878)
		{
			procedDate[_line] = 878;
			init(_line);
			setData(_line, 0, 0, 123);
			setData(_line, 44, 4, 0);
			setData(_line, 44, 5, 0);
		}
	}

	public static void m_panel_NV_Q_ooo(int _line)
	{
		if (procedDate[_line] != 879)
		{
			procedDate[_line] = 879;
			init(_line);
			setData(_line, 0, 0, 124);
			setData(_line, 16, 2, 0);
			setData(_line, 16, 5, 0);
		}
	}

	public static void m_panel_NV_Q_xoo(int _line)
	{
		if (procedDate[_line] != 880)
		{
			procedDate[_line] = 880;
			init(_line);
			setData(_line, 0, 0, 125);
			setData(_line, 16, 2, 0);
			setData(_line, 16, 5, 0);
		}
	}

	public static void m_panel_NV_Q_oxo(int _line)
	{
		if (procedDate[_line] != 881)
		{
			procedDate[_line] = 881;
			init(_line);
			setData(_line, 0, 0, 126);
			setData(_line, 16, 2, 0);
			setData(_line, 16, 5, 0);
		}
	}

	public static void m_panel_NV_Q_oox(int _line)
	{
		if (procedDate[_line] != 882)
		{
			procedDate[_line] = 882;
			init(_line);
			setData(_line, 0, 0, 127);
			setData(_line, 16, 2, 0);
			setData(_line, 16, 5, 0);
		}
	}

	public static void m_panel_NV_Q_oxx(int _line)
	{
		if (procedDate[_line] != 883)
		{
			procedDate[_line] = 883;
			init(_line);
			setData(_line, 0, 0, 128);
			setData(_line, 16, 2, 0);
			setData(_line, 16, 5, 0);
		}
	}

	public static void m_panel_NV_Q_xox(int _line)
	{
		if (procedDate[_line] != 884)
		{
			procedDate[_line] = 884;
			init(_line);
			setData(_line, 0, 0, 129);
			setData(_line, 16, 2, 0);
			setData(_line, 16, 5, 0);
		}
	}

	public static void m_panel_NV_Q_xxo(int _line)
	{
		if (procedDate[_line] != 885)
		{
			procedDate[_line] = 885;
			init(_line);
			setData(_line, 0, 0, 130);
			setData(_line, 16, 2, 0);
			setData(_line, 16, 5, 0);
		}
	}

	public static void m_panel_waku_01(int _line)
	{
		if (procedDate[_line] != 886)
		{
			procedDate[_line] = 886;
			init(_line);
			setData(_line, 0, 0, 131);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void m_panel_waku_02(int _line)
	{
		if (procedDate[_line] != 887)
		{
			procedDate[_line] = 887;
			init(_line);
			setData(_line, 0, 0, 132);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void m_panel_waku_03(int _line)
	{
		if (procedDate[_line] != 888)
		{
			procedDate[_line] = 888;
			init(_line);
			setData(_line, 0, 0, 133);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void m_panel_waku_04(int _line)
	{
		if (procedDate[_line] != 889)
		{
			procedDate[_line] = 889;
			init(_line);
			setData(_line, 0, 0, 134);
			setData(_line, 13, 3, 255);
			setData(_line, 13, 0, 135);
			setData(_line, 15, 2, 0);
			setData(_line, 15, 5, 0);
		}
	}

	public static void m_panel_waku_05(int _line)
	{
		if (procedDate[_line] != 890)
		{
			procedDate[_line] = 890;
			init(_line);
			setData(_line, 0, 0, 136);
			setData(_line, 34, 2, 0);
			setData(_line, 34, 5, 0);
		}
	}

	public static void m_panel_waku_06(int _line)
	{
		if (procedDate[_line] != 891)
		{
			procedDate[_line] = 891;
			init(_line);
			setData(_line, 0, 0, 137);
			setData(_line, 12, 2, 0);
			setData(_line, 12, 5, 0);
		}
	}

	public static void m_panel_DI_step_01(int _line)
	{
		if (procedDate[_line] != 892)
		{
			procedDate[_line] = 892;
			init(_line);
			setData(_line, 0, 0, 138);
			setData(_line, 41, 4, 0);
			setData(_line, 41, 5, 0);
		}
	}

	public static void m_panel_DI_step_02(int _line)
	{
		if (procedDate[_line] != 893)
		{
			procedDate[_line] = 893;
			init(_line);
			setData(_line, 0, 0, 139);
			setData(_line, 41, 4, 0);
			setData(_line, 41, 5, 0);
		}
	}

	public static void m_panel_DI_step_03(int _line)
	{
		if (procedDate[_line] != 894)
		{
			procedDate[_line] = 894;
			init(_line);
			setData(_line, 0, 0, 140);
			setData(_line, 33, 4, 0);
			setData(_line, 33, 5, 0);
		}
	}

	public static void m_panel_DI_step_04(int _line)
	{
		if (procedDate[_line] != 895)
		{
			procedDate[_line] = 895;
			init(_line);
			setData(_line, 0, 0, 141);
			setData(_line, 23, 3, 255);
			setData(_line, 23, 0, 142);
			setData(_line, 46, 2, 0);
			setData(_line, 46, 5, 0);
		}
	}

	public static void m_panel_wi_dest(int _line)
	{
		if (procedDate[_line] != 896)
		{
			procedDate[_line] = 896;
			init(_line);
			setData(_line, 0, 0, 143);
			setData(_line, 50, 3, 255);
			setData(_line, 50, 0, 144);
			setData(_line, 69, 2, 0);
			setData(_line, 69, 5, 0);
		}
	}

	public static void m_panel_wi_dest_lose(int _line)
	{
		if (procedDate[_line] != 897)
		{
			procedDate[_line] = 897;
			init(_line);
			setData(_line, 0, 0, 145);
			setData(_line, 19, 4, 0);
			setData(_line, 19, 5, 0);
		}
	}

	public static void m_panel_wi_reverse(int _line)
	{
		if (procedDate[_line] != 898)
		{
			procedDate[_line] = 898;
			init(_line);
			setData(_line, 0, 0, 146);
			setData(_line, 107, 4, 0);
			setData(_line, 107, 5, 0);
		}
	}

	public static void m_panel_KCI_step_01(int _line)
	{
		if (procedDate[_line] != 899)
		{
			procedDate[_line] = 899;
			init(_line);
			setData(_line, 0, 0, 147);
			setData(_line, 69, 4, 0);
			setData(_line, 69, 5, 0);
		}
	}

	public static void m_panel_KCI_step_02(int _line)
	{
		if (procedDate[_line] != 900)
		{
			procedDate[_line] = 900;
			init(_line);
			setData(_line, 0, 0, 148);
			setData(_line, 70, 4, 0);
			setData(_line, 70, 5, 0);
		}
	}

	public static void m_panel_KCI_step_03(int _line)
	{
		if (procedDate[_line] != 901)
		{
			procedDate[_line] = 901;
			init(_line);
			setData(_line, 0, 0, 149);
			setData(_line, 73, 4, 0);
			setData(_line, 73, 5, 0);
		}
	}

	public static void OFF_2m(int _line)
	{
		if (procedDate[_line] != 902)
		{
			procedDate[_line] = 902;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void m_panel_win_heat_01(int _line)
	{
		if (procedDate[_line] != 903)
		{
			procedDate[_line] = 903;
			init(_line);
			setData(_line, 0, 0, 85);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 86);
			setData(_line, 66, 2, 0);
			setData(_line, 66, 5, 0);
		}
	}

	public static void m_panel_win_heat_02(int _line)
	{
		if (procedDate[_line] != 904)
		{
			procedDate[_line] = 904;
			init(_line);
			setData(_line, 0, 0, 87);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 88);
			setData(_line, 66, 2, 0);
			setData(_line, 66, 5, 0);
		}
	}

	public static void m_panel_win_heat_03(int _line)
	{
		if (procedDate[_line] != 905)
		{
			procedDate[_line] = 905;
			init(_line);
			setData(_line, 0, 0, 89);
			setData(_line, 33, 3, 255);
			setData(_line, 33, 0, 90);
			setData(_line, 69, 2, 0);
			setData(_line, 69, 5, 0);
		}
	}

	public static void m_panel_win(int _line)
	{
		if (procedDate[_line] != 906)
		{
			procedDate[_line] = 906;
			init(_line);
			setData(_line, 0, 0, 91);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void m_panel_win_PB_in(int _line)
	{
		if (procedDate[_line] != 907)
		{
			procedDate[_line] = 907;
			init(_line);
			setData(_line, 0, 0, 92);
			setData(_line, 68, 3, 255);
			setData(_line, 68, 0, 93);
			setData(_line, 135, 2, 0);
			setData(_line, 135, 5, 0);
		}
	}

	public static void m_panel_win_SGB_in(int _line)
	{
		if (procedDate[_line] != 908)
		{
			procedDate[_line] = 908;
			init(_line);
			setData(_line, 0, 0, 94);
			setData(_line, 52, 3, 255);
			setData(_line, 52, 0, 95);
			setData(_line, 85, 2, 0);
			setData(_line, 85, 5, 0);
		}
	}

	public static void m_panel_win_GB_in(int _line)
	{
		if (procedDate[_line] != 909)
		{
			procedDate[_line] = 909;
			init(_line);
			setData(_line, 0, 0, 96);
			setData(_line, 52, 3, 255);
			setData(_line, 52, 0, 97);
			setData(_line, 86, 2, 0);
			setData(_line, 86, 5, 0);
		}
	}

	public static void m_panel_win_RB_in(int _line)
	{
		if (procedDate[_line] != 910)
		{
			procedDate[_line] = 910;
			init(_line);
			setData(_line, 0, 0, 98);
			setData(_line, 52, 3, 255);
			setData(_line, 52, 0, 99);
			setData(_line, 86, 2, 0);
			setData(_line, 86, 5, 0);
		}
	}

	public static void m_panel_win_PB_end(int _line)
	{
		if (procedDate[_line] != 911)
		{
			procedDate[_line] = 911;
			init(_line);
			setData(_line, 0, 0, 100);
			setData(_line, 95, 4, 0);
			setData(_line, 95, 5, 0);
		}
	}

	public static void m_panel_win_SGB_end(int _line)
	{
		if (procedDate[_line] != 912)
		{
			procedDate[_line] = 912;
			init(_line);
			setData(_line, 0, 0, 101);
			setData(_line, 95, 4, 0);
			setData(_line, 95, 5, 0);
		}
	}

	public static void m_panel_win_GB_end(int _line)
	{
		if (procedDate[_line] != 913)
		{
			procedDate[_line] = 913;
			init(_line);
			setData(_line, 0, 0, 102);
			setData(_line, 95, 4, 0);
			setData(_line, 95, 5, 0);
		}
	}

	public static void m_panel_win_RB_end(int _line)
	{
		if (procedDate[_line] != 914)
		{
			procedDate[_line] = 914;
			init(_line);
			setData(_line, 0, 0, 103);
			setData(_line, 95, 4, 0);
			setData(_line, 95, 5, 0);
		}
	}

	public static void OFF_3m(int _line)
	{
		if (procedDate[_line] != 915)
		{
			procedDate[_line] = 915;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void m_panel_odds(int _line)
	{
		if (procedDate[_line] != 916)
		{
			procedDate[_line] = 916;
			init(_line);
			setData(_line, 0, 0, 84);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void m_panel_slash(int _line)
	{
		if (procedDate[_line] != 917)
		{
			procedDate[_line] = 917;
			init(_line);
			setData(_line, 0, 0, 82);
			setData(_line, 50, 3, 255);
			setData(_line, 50, 0, 83);
			setData(_line, 52, 2, 0);
			setData(_line, 52, 5, 0);
		}
	}

	public static void m_panel_slash_MGO_01(int _line)
	{
		if (procedDate[_line] != 918)
		{
			procedDate[_line] = 918;
			init(_line);
			setData(_line, 0, 0, 82);
			setData(_line, 50, 3, 255);
			setData(_line, 50, 0, 83);
			setData(_line, 52, 2, 0);
			setData(_line, 52, 5, 0);
		}
	}

	public static void m_panel_slash_MGO_02(int _line)
	{
		if (procedDate[_line] != 919)
		{
			procedDate[_line] = 919;
			init(_line);
			setData(_line, 0, 0, 82);
			setData(_line, 50, 3, 255);
			setData(_line, 50, 0, 83);
			setData(_line, 52, 2, 0);
			setData(_line, 52, 5, 0);
		}
	}

	public static void m_panel_slash_MGO_03(int _line)
	{
		if (procedDate[_line] != 920)
		{
			procedDate[_line] = 920;
			init(_line);
			setData(_line, 0, 0, 82);
			setData(_line, 50, 3, 255);
			setData(_line, 50, 0, 83);
			setData(_line, 52, 2, 0);
			setData(_line, 52, 5, 0);
		}
	}

	public static void m_panel_slash_RSH_01(int _line)
	{
		if (procedDate[_line] != 921)
		{
			procedDate[_line] = 921;
			init(_line);
			setData(_line, 0, 0, 82);
			setData(_line, 50, 3, 255);
			setData(_line, 50, 0, 83);
			setData(_line, 52, 2, 0);
			setData(_line, 52, 5, 0);
		}
	}

	public static void m_panel_slash_RSH_02(int _line)
	{
		if (procedDate[_line] != 922)
		{
			procedDate[_line] = 922;
			init(_line);
			setData(_line, 0, 0, 82);
			setData(_line, 50, 3, 255);
			setData(_line, 50, 0, 83);
			setData(_line, 52, 2, 0);
			setData(_line, 52, 5, 0);
		}
	}

	public static void m_panel_slash_RSH_03(int _line)
	{
		if (procedDate[_line] != 923)
		{
			procedDate[_line] = 923;
			init(_line);
			setData(_line, 0, 0, 82);
			setData(_line, 50, 3, 255);
			setData(_line, 50, 0, 83);
			setData(_line, 52, 2, 0);
			setData(_line, 52, 5, 0);
		}
	}

	public static void m_panel_slash_CMB_01(int _line)
	{
		if (procedDate[_line] != 924)
		{
			procedDate[_line] = 924;
			init(_line);
			setData(_line, 0, 0, 82);
			setData(_line, 50, 3, 255);
			setData(_line, 50, 0, 83);
			setData(_line, 52, 2, 0);
			setData(_line, 52, 5, 0);
		}
	}

	public static void m_panel_slash_CMB_02(int _line)
	{
		if (procedDate[_line] != 925)
		{
			procedDate[_line] = 925;
			init(_line);
			setData(_line, 0, 0, 82);
			setData(_line, 50, 3, 255);
			setData(_line, 50, 0, 83);
			setData(_line, 52, 2, 0);
			setData(_line, 52, 5, 0);
		}
	}

	public static void m_panel_slash_CMB_03(int _line)
	{
		if (procedDate[_line] != 926)
		{
			procedDate[_line] = 926;
			init(_line);
			setData(_line, 0, 0, 82);
			setData(_line, 50, 3, 255);
			setData(_line, 50, 0, 83);
			setData(_line, 52, 2, 0);
			setData(_line, 52, 5, 0);
		}
	}

	public static void m_panel_slash_KOG_01(int _line)
	{
		if (procedDate[_line] != 927)
		{
			procedDate[_line] = 927;
			init(_line);
			setData(_line, 0, 0, 82);
			setData(_line, 50, 3, 255);
			setData(_line, 50, 0, 83);
			setData(_line, 52, 2, 0);
			setData(_line, 52, 5, 0);
		}
	}

	public static void m_panel_slash_KOG_02(int _line)
	{
		if (procedDate[_line] != 928)
		{
			procedDate[_line] = 928;
			init(_line);
			setData(_line, 0, 0, 82);
			setData(_line, 50, 3, 255);
			setData(_line, 50, 0, 83);
			setData(_line, 52, 2, 0);
			setData(_line, 52, 5, 0);
		}
	}

	public static void OFF_4m(int _line)
	{
		if (procedDate[_line] != 929)
		{
			procedDate[_line] = 929;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void m_panel_HOH(int _line)
	{
		if (procedDate[_line] != 930)
		{
			procedDate[_line] = 930;
			init(_line);
			setData(_line, 0, 0, 27);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void m_panel_KBS_01(int _line)
	{
		if (procedDate[_line] != 931)
		{
			procedDate[_line] = 931;
			init(_line);
			setData(_line, 0, 0, 28);
			setData(_line, 8, 2, 0);
			setData(_line, 8, 5, 0);
		}
	}

	public static void m_panel_KBS_02(int _line)
	{
		if (procedDate[_line] != 932)
		{
			procedDate[_line] = 932;
			init(_line);
			setData(_line, 0, 0, 29);
			setData(_line, 8, 2, 0);
			setData(_line, 8, 5, 0);
		}
	}

	public static void m_panel_KBS_03(int _line)
	{
		if (procedDate[_line] != 933)
		{
			procedDate[_line] = 933;
			init(_line);
			setData(_line, 0, 0, 30);
			setData(_line, 8, 2, 0);
			setData(_line, 8, 5, 0);
		}
	}

	public static void m_panel_KBS_04(int _line)
	{
		if (procedDate[_line] != 934)
		{
			procedDate[_line] = 934;
			init(_line);
			setData(_line, 0, 0, 31);
			setData(_line, 8, 2, 0);
			setData(_line, 8, 5, 0);
		}
	}

	public static void m_panel_KBS_05(int _line)
	{
		if (procedDate[_line] != 935)
		{
			procedDate[_line] = 935;
			init(_line);
			setData(_line, 0, 0, 32);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void m_panel_KBS_sl(int _line)
	{
		if (procedDate[_line] != 936)
		{
			procedDate[_line] = 936;
			init(_line);
			setData(_line, 0, 0, 33);
			setData(_line, 52, 3, 255);
			setData(_line, 52, 0, 34);
			setData(_line, 54, 2, 0);
			setData(_line, 54, 5, 0);
		}
	}

	public static void m_panel_KBS_cp(int _line)
	{
		if (procedDate[_line] != 937)
		{
			procedDate[_line] = 937;
			init(_line);
			setData(_line, 0, 0, 35);
			setData(_line, 52, 3, 255);
			setData(_line, 52, 0, 36);
			setData(_line, 54, 2, 0);
			setData(_line, 54, 5, 0);
		}
	}

	public static void m_panel_KBS_ml(int _line)
	{
		if (procedDate[_line] != 938)
		{
			procedDate[_line] = 938;
			init(_line);
			setData(_line, 0, 0, 37);
			setData(_line, 52, 3, 255);
			setData(_line, 52, 0, 38);
			setData(_line, 54, 2, 0);
			setData(_line, 54, 5, 0);
		}
	}

	public static void m_panel_KBS_bj(int _line)
	{
		if (procedDate[_line] != 939)
		{
			procedDate[_line] = 939;
			init(_line);
			setData(_line, 0, 0, 39);
			setData(_line, 52, 3, 255);
			setData(_line, 52, 0, 40);
			setData(_line, 54, 2, 0);
			setData(_line, 54, 5, 0);
		}
	}

	public static void m_panel_KBS_zp(int _line)
	{
		if (procedDate[_line] != 940)
		{
			procedDate[_line] = 940;
			init(_line);
			setData(_line, 0, 0, 41);
			setData(_line, 52, 3, 255);
			setData(_line, 52, 0, 42);
			setData(_line, 54, 2, 0);
			setData(_line, 54, 5, 0);
		}
	}

	public static void m_panel_HOH_sl_vs_01(int _line)
	{
		if (procedDate[_line] != 941)
		{
			procedDate[_line] = 941;
			init(_line);
			setData(_line, 0, 0, 43);
			setData(_line, 193, 3, 255);
			setData(_line, 193, 0, 44);
			setData(_line, 195, 2, 0);
			setData(_line, 195, 5, 0);
		}
	}

	public static void m_panel_HOH_sl_vs_02(int _line)
	{
		if (procedDate[_line] != 942)
		{
			procedDate[_line] = 942;
			init(_line);
			setData(_line, 0, 0, 45);
			setData(_line, 193, 3, 255);
			setData(_line, 193, 0, 46);
			setData(_line, 195, 2, 0);
			setData(_line, 195, 5, 0);
		}
	}

	public static void m_panel_HOH_sl_vs_03(int _line)
	{
		if (procedDate[_line] != 943)
		{
			procedDate[_line] = 943;
			init(_line);
			setData(_line, 0, 0, 47);
			setData(_line, 193, 3, 255);
			setData(_line, 193, 0, 48);
			setData(_line, 195, 2, 0);
			setData(_line, 195, 5, 0);
		}
	}

	public static void m_panel_HOH_sl_01(int _line)
	{
		if (procedDate[_line] != 944)
		{
			procedDate[_line] = 944;
			init(_line);
			setData(_line, 0, 0, 49);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void m_panel_HOH_sl_02(int _line)
	{
		if (procedDate[_line] != 945)
		{
			procedDate[_line] = 945;
			init(_line);
			setData(_line, 0, 0, 50);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void m_panel_HOH_cp_vs_01(int _line)
	{
		if (procedDate[_line] != 946)
		{
			procedDate[_line] = 946;
			init(_line);
			setData(_line, 0, 0, 51);
			setData(_line, 193, 3, 255);
			setData(_line, 193, 0, 52);
			setData(_line, 195, 2, 0);
			setData(_line, 195, 5, 0);
		}
	}

	public static void m_panel_HOH_cp_vs_02(int _line)
	{
		if (procedDate[_line] != 947)
		{
			procedDate[_line] = 947;
			init(_line);
			setData(_line, 0, 0, 53);
			setData(_line, 193, 3, 255);
			setData(_line, 193, 0, 54);
			setData(_line, 195, 2, 0);
			setData(_line, 195, 5, 0);
		}
	}

	public static void m_panel_HOH_cp_vs_03(int _line)
	{
		if (procedDate[_line] != 948)
		{
			procedDate[_line] = 948;
			init(_line);
			setData(_line, 0, 0, 55);
			setData(_line, 193, 3, 255);
			setData(_line, 193, 0, 56);
			setData(_line, 195, 2, 0);
			setData(_line, 195, 5, 0);
		}
	}

	public static void m_panel_HOH_cp_01(int _line)
	{
		if (procedDate[_line] != 949)
		{
			procedDate[_line] = 949;
			init(_line);
			setData(_line, 0, 0, 57);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void m_panel_HOH_cp_02(int _line)
	{
		if (procedDate[_line] != 950)
		{
			procedDate[_line] = 950;
			init(_line);
			setData(_line, 0, 0, 58);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void m_panel_HOH_ml_vs_01(int _line)
	{
		if (procedDate[_line] != 951)
		{
			procedDate[_line] = 951;
			init(_line);
			setData(_line, 0, 0, 59);
			setData(_line, 193, 3, 255);
			setData(_line, 193, 0, 60);
			setData(_line, 195, 2, 0);
			setData(_line, 195, 5, 0);
		}
	}

	public static void m_panel_HOH_ml_vs_02(int _line)
	{
		if (procedDate[_line] != 952)
		{
			procedDate[_line] = 952;
			init(_line);
			setData(_line, 0, 0, 61);
			setData(_line, 193, 3, 255);
			setData(_line, 193, 0, 62);
			setData(_line, 195, 2, 0);
			setData(_line, 195, 5, 0);
		}
	}

	public static void m_panel_HOH_ml_vs_03(int _line)
	{
		if (procedDate[_line] != 953)
		{
			procedDate[_line] = 953;
			init(_line);
			setData(_line, 0, 0, 63);
			setData(_line, 193, 3, 255);
			setData(_line, 193, 0, 64);
			setData(_line, 195, 2, 0);
			setData(_line, 195, 5, 0);
		}
	}

	public static void m_panel_HOH_ml_01(int _line)
	{
		if (procedDate[_line] != 954)
		{
			procedDate[_line] = 954;
			init(_line);
			setData(_line, 0, 0, 65);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void m_panel_HOH_ml_02(int _line)
	{
		if (procedDate[_line] != 955)
		{
			procedDate[_line] = 955;
			init(_line);
			setData(_line, 0, 0, 66);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void m_panel_HOH_bj_vs_01(int _line)
	{
		if (procedDate[_line] != 956)
		{
			procedDate[_line] = 956;
			init(_line);
			setData(_line, 0, 0, 67);
			setData(_line, 193, 3, 255);
			setData(_line, 193, 0, 68);
			setData(_line, 195, 2, 0);
			setData(_line, 195, 5, 0);
		}
	}

	public static void m_panel_HOH_bj_vs_02(int _line)
	{
		if (procedDate[_line] != 957)
		{
			procedDate[_line] = 957;
			init(_line);
			setData(_line, 0, 0, 69);
			setData(_line, 193, 3, 255);
			setData(_line, 193, 0, 70);
			setData(_line, 195, 2, 0);
			setData(_line, 195, 5, 0);
		}
	}

	public static void m_panel_HOH_bj_vs_03(int _line)
	{
		if (procedDate[_line] != 958)
		{
			procedDate[_line] = 958;
			init(_line);
			setData(_line, 0, 0, 71);
			setData(_line, 193, 3, 255);
			setData(_line, 193, 0, 72);
			setData(_line, 195, 2, 0);
			setData(_line, 195, 5, 0);
		}
	}

	public static void m_panel_HOH_bj_01(int _line)
	{
		if (procedDate[_line] != 959)
		{
			procedDate[_line] = 959;
			init(_line);
			setData(_line, 0, 0, 73);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void m_panel_HOH_bj_02(int _line)
	{
		if (procedDate[_line] != 960)
		{
			procedDate[_line] = 960;
			init(_line);
			setData(_line, 0, 0, 74);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void m_panel_HOH_zp_vs_01(int _line)
	{
		if (procedDate[_line] != 961)
		{
			procedDate[_line] = 961;
			init(_line);
			setData(_line, 0, 0, 75);
			setData(_line, 193, 3, 255);
			setData(_line, 193, 0, 76);
			setData(_line, 195, 2, 0);
			setData(_line, 195, 5, 0);
		}
	}

	public static void m_panel_HOH_zp_vs_02(int _line)
	{
		if (procedDate[_line] != 962)
		{
			procedDate[_line] = 962;
			init(_line);
			setData(_line, 0, 0, 77);
			setData(_line, 193, 3, 255);
			setData(_line, 193, 0, 78);
			setData(_line, 195, 2, 0);
			setData(_line, 195, 5, 0);
		}
	}

	public static void m_panel_HOH_zp_vs_03(int _line)
	{
		if (procedDate[_line] != 963)
		{
			procedDate[_line] = 963;
			init(_line);
			setData(_line, 0, 0, 79);
			setData(_line, 193, 3, 255);
			setData(_line, 193, 0, 80);
			setData(_line, 195, 2, 0);
			setData(_line, 195, 5, 0);
		}
	}

	public static void m_panel_HOH_zp_01(int _line)
	{
		if (procedDate[_line] != 964)
		{
			procedDate[_line] = 964;
			init(_line);
			setData(_line, 0, 0, 81);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void OFF_5m(int _line)
	{
		if (procedDate[_line] != 965)
		{
			procedDate[_line] = 965;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void m_panel_dest_01(int _line)
	{
		if (procedDate[_line] != 966)
		{
			procedDate[_line] = 966;
			init(_line);
			setData(_line, 0, 0, 13);
			setData(_line, 9, 3, 255);
			setData(_line, 9, 0, 14);
			setData(_line, 42, 2, 0);
			setData(_line, 42, 5, 0);
		}
	}

	public static void m_panel_dest_02(int _line)
	{
		if (procedDate[_line] != 967)
		{
			procedDate[_line] = 967;
			init(_line);
			setData(_line, 0, 0, 15);
			setData(_line, 9, 3, 255);
			setData(_line, 9, 0, 16);
			setData(_line, 24, 2, 0);
			setData(_line, 24, 5, 0);
		}
	}

	public static void m_panel_dest_03(int _line)
	{
		if (procedDate[_line] != 968)
		{
			procedDate[_line] = 968;
			init(_line);
			setData(_line, 0, 0, 17);
			setData(_line, 66, 3, 255);
			setData(_line, 66, 0, 18);
			setData(_line, 68, 2, 0);
			setData(_line, 68, 5, 0);
		}
	}

	public static void m_panel_dest_04(int _line)
	{
		if (procedDate[_line] != 969)
		{
			procedDate[_line] = 969;
			init(_line);
			setData(_line, 0, 0, 19);
			setData(_line, 66, 3, 255);
			setData(_line, 66, 0, 20);
			setData(_line, 68, 2, 0);
			setData(_line, 68, 5, 0);
		}
	}

	public static void m_panel_DI_f_01(int _line)
	{
		if (procedDate[_line] != 970)
		{
			procedDate[_line] = 970;
			init(_line);
			setData(_line, 64, 0, 21);
			setData(_line, 411, 3, 255);
			setData(_line, 411, 0, 22);
			setData(_line, 413, 2, 0);
			setData(_line, 413, 5, 0);
		}
	}

	public static void m_panel_DI_f_02(int _line)
	{
		if (procedDate[_line] != 971)
		{
			procedDate[_line] = 971;
			init(_line);
			setData(_line, 132, 0, 21);
			setData(_line, 479, 3, 255);
			setData(_line, 479, 0, 22);
			setData(_line, 481, 2, 0);
			setData(_line, 481, 5, 0);
		}
	}

	public static void m_panel_DI_in(int _line)
	{
		if (procedDate[_line] != 972)
		{
			procedDate[_line] = 972;
			init(_line);
			setData(_line, 0, 0, 25);
			setData(_line, 83, 3, 255);
			setData(_line, 83, 0, 26);
			setData(_line, 85, 2, 0);
			setData(_line, 85, 5, 0);
		}
	}

	public static void m_panel_DI_01(int _line)
	{
		if (procedDate[_line] != 973)
		{
			procedDate[_line] = 973;
			init(_line);
			setData(_line, 0, 0, 23);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void m_panel_DI_02(int _line)
	{
		if (procedDate[_line] != 974)
		{
			procedDate[_line] = 974;
			init(_line);
			setData(_line, 0, 0, 24);
			setData(_line, 51, 2, 0);
			setData(_line, 51, 5, 0);
		}
	}

	public static void OFF_6m(int _line)
	{
		if (procedDate[_line] != 975)
		{
			procedDate[_line] = 975;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void push_white(int _line)
	{
		if (procedDate[_line] != 976)
		{
			procedDate[_line] = 976;
			init(_line);
			setData(_line, 0, 0, 150);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void push_blue(int _line)
	{
		if (procedDate[_line] != 977)
		{
			procedDate[_line] = 977;
			init(_line);
			setData(_line, 0, 0, 151);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void push_yellow(int _line)
	{
		if (procedDate[_line] != 978)
		{
			procedDate[_line] = 978;
			init(_line);
			setData(_line, 0, 0, 152);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void push_green(int _line)
	{
		if (procedDate[_line] != 979)
		{
			procedDate[_line] = 979;
			init(_line);
			setData(_line, 0, 0, 153);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void push_red(int _line)
	{
		if (procedDate[_line] != 980)
		{
			procedDate[_line] = 980;
			init(_line);
			setData(_line, 0, 0, 154);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void push_purple(int _line)
	{
		if (procedDate[_line] != 981)
		{
			procedDate[_line] = 981;
			init(_line);
			setData(_line, 0, 0, 155);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void push_rainbow(int _line)
	{
		if (procedDate[_line] != 982)
		{
			procedDate[_line] = 982;
			init(_line);
			setData(_line, 0, 0, 156);
			setData(_line, 39, 2, 0);
			setData(_line, 39, 5, 0);
		}
	}

	public static void push_on_rainbow(int _line)
	{
		if (procedDate[_line] != 983)
		{
			procedDate[_line] = 983;
			init(_line);
			setData(_line, 0, 0, 157);
			setData(_line, 40, 3, 255);
			setData(_line, 40, 0, 158);
			setData(_line, 79, 2, 0);
			setData(_line, 79, 5, 0);
		}
	}

	public static void push_flash_white(int _line)
	{
		if (procedDate[_line] != 984)
		{
			procedDate[_line] = 984;
			init(_line);
			setData(_line, 0, 0, 159);
			setData(_line, 4, 4, 0);
			setData(_line, 4, 5, 0);
		}
	}

	public static void push_flash_blue(int _line)
	{
		if (procedDate[_line] != 985)
		{
			procedDate[_line] = 985;
			init(_line);
			setData(_line, 0, 0, 160);
			setData(_line, 4, 4, 0);
			setData(_line, 4, 5, 0);
		}
	}

	public static void push_flash_yellow(int _line)
	{
		if (procedDate[_line] != 986)
		{
			procedDate[_line] = 986;
			init(_line);
			setData(_line, 0, 0, 161);
			setData(_line, 4, 4, 0);
			setData(_line, 4, 5, 0);
		}
	}

	public static void push_flash_green(int _line)
	{
		if (procedDate[_line] != 987)
		{
			procedDate[_line] = 987;
			init(_line);
			setData(_line, 0, 0, 162);
			setData(_line, 4, 4, 0);
			setData(_line, 4, 5, 0);
		}
	}

	public static void push_flash_red(int _line)
	{
		if (procedDate[_line] != 988)
		{
			procedDate[_line] = 988;
			init(_line);
			setData(_line, 0, 0, 163);
			setData(_line, 4, 4, 0);
			setData(_line, 4, 5, 0);
		}
	}

	public static void push_flash_purple(int _line)
	{
		if (procedDate[_line] != 989)
		{
			procedDate[_line] = 989;
			init(_line);
			setData(_line, 0, 0, 164);
			setData(_line, 4, 4, 0);
			setData(_line, 4, 5, 0);
		}
	}

	public static void push_flash_rainbow(int _line)
	{
		if (procedDate[_line] != 990)
		{
			procedDate[_line] = 990;
			init(_line);
			setData(_line, 0, 0, 165);
			setData(_line, 4, 4, 0);
			setData(_line, 4, 5, 0);
		}
	}

	public static void push_blink_white(int _line)
	{
		if (procedDate[_line] != 991)
		{
			procedDate[_line] = 991;
			init(_line);
			setData(_line, 0, 0, 166);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void push_blink_blue_01(int _line)
	{
		if (procedDate[_line] != 992)
		{
			procedDate[_line] = 992;
			init(_line);
			setData(_line, 0, 0, 167);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void push_blink_blue_02(int _line)
	{
		if (procedDate[_line] != 993)
		{
			procedDate[_line] = 993;
			init(_line);
			setData(_line, 0, 0, 168);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void push_blink_red_01(int _line)
	{
		if (procedDate[_line] != 994)
		{
			procedDate[_line] = 994;
			init(_line);
			setData(_line, 0, 0, 169);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void push_blink_red_02(int _line)
	{
		if (procedDate[_line] != 995)
		{
			procedDate[_line] = 995;
			init(_line);
			setData(_line, 0, 0, 170);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void push_on_rainbow_BZT(int _line)
	{
		if (procedDate[_line] != 996)
		{
			procedDate[_line] = 996;
			init(_line);
			setData(_line, 0, 0, 171);
			setData(_line, 134, 4, 0);
			setData(_line, 134, 5, 0);
		}
	}

	public static void OFF_7m(int _line)
	{
		if (procedDate[_line] != 997)
		{
			procedDate[_line] = 997;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void lever_ball_on(int _line)
	{
		if (procedDate[_line] != 998)
		{
			procedDate[_line] = 998;
			init(_line);
			setData(_line, 0, 0, 0);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void lever_ball_v(int _line)
	{
		if (procedDate[_line] != 999)
		{
			procedDate[_line] = 999;
			init(_line);
			setData(_line, 0, 0, 1);
			setData(_line, 39, 3, 255);
			setData(_line, 39, 0, 2);
			setData(_line, 77, 2, 0);
			setData(_line, 77, 5, 0);
		}
	}

	public static void lever_ball_white(int _line)
	{
		if (procedDate[_line] != 1000)
		{
			procedDate[_line] = 1000;
			init(_line);
			setData(_line, 0, 0, 3);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void lever_ball_blue(int _line)
	{
		if (procedDate[_line] != 1001)
		{
			procedDate[_line] = 1001;
			init(_line);
			setData(_line, 0, 0, 4);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void lever_ball_yellow(int _line)
	{
		if (procedDate[_line] != 1002)
		{
			procedDate[_line] = 1002;
			init(_line);
			setData(_line, 0, 0, 5);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void lever_ball_green(int _line)
	{
		if (procedDate[_line] != 1003)
		{
			procedDate[_line] = 1003;
			init(_line);
			setData(_line, 0, 0, 6);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void lever_ball_red(int _line)
	{
		if (procedDate[_line] != 1004)
		{
			procedDate[_line] = 1004;
			init(_line);
			setData(_line, 0, 0, 7);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void lever_ball_purple(int _line)
	{
		if (procedDate[_line] != 1005)
		{
			procedDate[_line] = 1005;
			init(_line);
			setData(_line, 0, 0, 8);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void lever_ball_rainbow(int _line)
	{
		if (procedDate[_line] != 1006)
		{
			procedDate[_line] = 1006;
			init(_line);
			setData(_line, 0, 0, 9);
			setData(_line, 39, 2, 0);
			setData(_line, 39, 5, 0);
		}
	}

	public static void OFF_8m(int _line)
	{
		if (procedDate[_line] != 1007)
		{
			procedDate[_line] = 1007;
			init(_line);
			setData(_line, 0, 4, 0);
			setData(_line, 1, 5, 0);
		}
	}

	public static void push_around_white(int _line)
	{
		if (procedDate[_line] != 1008)
		{
			procedDate[_line] = 1008;
			init(_line);
			setData(_line, 0, 0, 172);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void push_around_blue(int _line)
	{
		if (procedDate[_line] != 1009)
		{
			procedDate[_line] = 1009;
			init(_line);
			setData(_line, 0, 0, 173);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void push_around_yellow(int _line)
	{
		if (procedDate[_line] != 1010)
		{
			procedDate[_line] = 1010;
			init(_line);
			setData(_line, 0, 0, 174);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void push_around_green(int _line)
	{
		if (procedDate[_line] != 1011)
		{
			procedDate[_line] = 1011;
			init(_line);
			setData(_line, 0, 0, 175);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void push_around_red(int _line)
	{
		if (procedDate[_line] != 1012)
		{
			procedDate[_line] = 1012;
			init(_line);
			setData(_line, 0, 0, 176);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void push_around_purple(int _line)
	{
		if (procedDate[_line] != 1013)
		{
			procedDate[_line] = 1013;
			init(_line);
			setData(_line, 0, 0, 177);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void push_around_rainbow(int _line)
	{
		if (procedDate[_line] != 1014)
		{
			procedDate[_line] = 1014;
			init(_line);
			setData(_line, 0, 0, 178);
			setData(_line, 39, 2, 0);
			setData(_line, 39, 5, 0);
		}
	}

	public static void push_around_on_rainbow(int _line)
	{
		if (procedDate[_line] != 1015)
		{
			procedDate[_line] = 1015;
			init(_line);
			setData(_line, 0, 0, 179);
			setData(_line, 40, 3, 255);
			setData(_line, 40, 0, 180);
			setData(_line, 92, 2, 0);
			setData(_line, 92, 5, 0);
		}
	}

	public static void push_around_flash_white(int _line)
	{
		if (procedDate[_line] != 1016)
		{
			procedDate[_line] = 1016;
			init(_line);
			setData(_line, 0, 0, 181);
			setData(_line, 4, 4, 0);
			setData(_line, 4, 5, 0);
		}
	}

	public static void push_around_flash_blue(int _line)
	{
		if (procedDate[_line] != 1017)
		{
			procedDate[_line] = 1017;
			init(_line);
			setData(_line, 0, 0, 182);
			setData(_line, 4, 4, 0);
			setData(_line, 4, 5, 0);
		}
	}

	public static void push_around_flash_yellow(int _line)
	{
		if (procedDate[_line] != 1018)
		{
			procedDate[_line] = 1018;
			init(_line);
			setData(_line, 0, 0, 183);
			setData(_line, 4, 4, 0);
			setData(_line, 4, 5, 0);
		}
	}

	public static void push_around_flash_green(int _line)
	{
		if (procedDate[_line] != 1019)
		{
			procedDate[_line] = 1019;
			init(_line);
			setData(_line, 0, 0, 184);
			setData(_line, 4, 4, 0);
			setData(_line, 4, 5, 0);
		}
	}

	public static void push_around_flash_red(int _line)
	{
		if (procedDate[_line] != 1020)
		{
			procedDate[_line] = 1020;
			init(_line);
			setData(_line, 0, 0, 185);
			setData(_line, 4, 4, 0);
			setData(_line, 4, 5, 0);
		}
	}

	public static void push_around_flash_purple(int _line)
	{
		if (procedDate[_line] != 1021)
		{
			procedDate[_line] = 1021;
			init(_line);
			setData(_line, 0, 0, 186);
			setData(_line, 4, 4, 0);
			setData(_line, 4, 5, 0);
		}
	}

	public static void push_around_flash_rainbow(int _line)
	{
		if (procedDate[_line] != 1022)
		{
			procedDate[_line] = 1022;
			init(_line);
			setData(_line, 0, 0, 187);
			setData(_line, 4, 4, 0);
			setData(_line, 4, 5, 0);
		}
	}

	public static void push_around_blink_white(int _line)
	{
		if (procedDate[_line] != 1023)
		{
			procedDate[_line] = 1023;
			init(_line);
			setData(_line, 0, 0, 188);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void push_around_blink_blue_01(int _line)
	{
		if (procedDate[_line] != 1024)
		{
			procedDate[_line] = 1024;
			init(_line);
			setData(_line, 0, 0, 189);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void push_around_blink_blue_02(int _line)
	{
		if (procedDate[_line] != 1025)
		{
			procedDate[_line] = 1025;
			init(_line);
			setData(_line, 0, 0, 190);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void push_around_blink_red_01(int _line)
	{
		if (procedDate[_line] != 1026)
		{
			procedDate[_line] = 1026;
			init(_line);
			setData(_line, 0, 0, 191);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void push_around_blink_red_02(int _line)
	{
		if (procedDate[_line] != 1027)
		{
			procedDate[_line] = 1027;
			init(_line);
			setData(_line, 0, 0, 192);
			setData(_line, 2, 2, 0);
			setData(_line, 2, 5, 0);
		}
	}

	public static void push_around_on_rainbow_BZT(int _line)
	{
		if (procedDate[_line] != 1028)
		{
			procedDate[_line] = 1028;
			init(_line);
			setData(_line, 0, 0, 193);
			setData(_line, 134, 4, 0);
			setData(_line, 134, 5, 0);
		}
	}
}
