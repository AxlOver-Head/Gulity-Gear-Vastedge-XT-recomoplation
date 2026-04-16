public class DirectionMainLED
{
	public static int DCMD_LED_DEMOMAX = 10;

	public static int DCMD_LED_GEKIHENMAX = 19;

	public static int LINE_MAIN_0 = DirectionLedManager.changeLineNum(LEDMainManager.LINE.STATE);

	public static int LINE_MAIN_1 = DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_1);

	public static int LINE_MAIN_2 = DirectionLedManager.changeLineNum(LEDMainManager.LINE.BGM_2);

	public static int LINE_MAIN_3 = DirectionLedManager.changeLineNum(LEDMainManager.LINE.UNDERPANEL);

	public static int LINE_MAIN_4 = DirectionLedManager.changeLineNum(LEDMainManager.LINE.CG);

	public static int LINE_MAIN_5 = DirectionLedManager.changeLineNum(LEDMainManager.LINE.GD);

	public static int LINE_MAIN_6 = DirectionLedManager.changeLineNum(LEDMainManager.LINE.LOGO);

	public static int LINE_MAIN_7 = DirectionLedManager.changeLineNum(LEDMainManager.LINE.JYD);

	public static int LINE_MAIN_8 = DirectionLedManager.changeLineNum(LEDMainManager.LINE.DRIVE);

	public static int LINE_MAIN_9 = DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_1);

	public static int LINE_MAIN_10 = DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_2);

	public static int LINE_MAIN_11 = DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_3);

	public static int LINE_MAIN_12 = DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_4);

	public static int LINE_MAIN_13 = DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_5);

	public static int LINE_MAIN_14 = DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_6);

	public static int LINE_MAIN_15 = DirectionLedManager.changeLineNum(LEDMainManager.LINE.LGAUGE_DI);

	public static int LINE_MAIN_16 = DirectionLedManager.changeLineNum(LEDMainManager.LINE.DEMO);

	public static void _start(short high, short low, short mode)
	{
		int num = 0;
		if (high == 228)
		{
			if (low == 0 && mode == 255)
			{
				DirectionLedManager.OFF_0(LINE_MAIN_0);
				DirectionLedManager.OFF_1(LINE_MAIN_1);
				DirectionLedManager.OFF_2(LINE_MAIN_2);
				DirectionLedManager.OFF_3(LINE_MAIN_3);
				DirectionLedManager.OFF_4(LINE_MAIN_4);
				DirectionLedManager.OFF_5(LINE_MAIN_5);
				DirectionLedManager.OFF_6(LINE_MAIN_6);
				DirectionLedManager.OFF_7(LINE_MAIN_7);
				DirectionLedManager.OFF_8(LINE_MAIN_8);
				DirectionLedManager.OFF_9(LINE_MAIN_9);
				DirectionLedManager.OFF_10(LINE_MAIN_10);
				DirectionLedManager.OFF_11(LINE_MAIN_11);
				DirectionLedManager.OFF_12(LINE_MAIN_12);
				DirectionLedManager.OFF_13(LINE_MAIN_13);
				DirectionLedManager.OFF_14(LINE_MAIN_14);
				DirectionLedManager.OFF_15(LINE_MAIN_15);
				return;
			}
			if (low == 0 && mode == 0)
			{
				DirectionLedManager.OFF_2(LINE_MAIN_2);
				DirectionLedManager.OFF_4(LINE_MAIN_4);
				DirectionLedManager.OFF_5(LINE_MAIN_5);
				DirectionLedManager.OFF_6(LINE_MAIN_6);
				DirectionLedManager.OFF_7(LINE_MAIN_7);
			}
			if (low == 0 && 1 <= mode && mode <= 17)
			{
				if (mode == 10)
				{
					DirectionLedManager.OFF_9(LINE_MAIN_9);
					DirectionLedManager.OFF_10(LINE_MAIN_10);
					DirectionLedManager.OFF_11(LINE_MAIN_11);
					DirectionLedManager.OFF_12(LINE_MAIN_12);
					DirectionLedManager.OFF_13(LINE_MAIN_13);
					DirectionLedManager.OFF_14(LINE_MAIN_14);
				}
				else
				{
					if (mode == 1)
					{
						DirectionLedManager.OFF_0(LINE_MAIN_0);
					}
					if (mode == 2)
					{
						DirectionLedManager.OFF_1(LINE_MAIN_1);
					}
					if (mode == 3)
					{
						DirectionLedManager.OFF_2(LINE_MAIN_2);
					}
					if (mode == 4)
					{
						DirectionLedManager.OFF_3(LINE_MAIN_3);
					}
					if (mode == 5)
					{
						DirectionLedManager.OFF_4(LINE_MAIN_4);
					}
					if (mode == 6)
					{
						DirectionLedManager.OFF_5(LINE_MAIN_5);
					}
					if (mode == 7)
					{
						DirectionLedManager.OFF_6(LINE_MAIN_6);
					}
					if (mode == 8)
					{
						DirectionLedManager.OFF_7(LINE_MAIN_7);
					}
					if (mode == 9)
					{
						DirectionLedManager.OFF_8(LINE_MAIN_8);
					}
					if (mode == 10)
					{
						DirectionLedManager.OFF_9(LINE_MAIN_9);
					}
					if (mode == 11)
					{
						DirectionLedManager.OFF_10(LINE_MAIN_10);
					}
					if (mode == 12)
					{
						DirectionLedManager.OFF_11(LINE_MAIN_11);
					}
					if (mode == 13)
					{
						DirectionLedManager.OFF_12(LINE_MAIN_12);
					}
					if (mode == 14)
					{
						DirectionLedManager.OFF_13(LINE_MAIN_13);
					}
					if (mode == 15)
					{
						DirectionLedManager.OFF_14(LINE_MAIN_14);
					}
				}
			}
			if (low == 1)
			{
				if (0 <= mode && mode < DCMD_LED_GEKIHENMAX)
				{
					if (mode == 0)
					{
						DirectionLedManager.OFF_0(LINE_MAIN_0);
					}
					if (mode == 1)
					{
						DirectionLedManager.GH_NML_01(LINE_MAIN_0);
					}
					if (mode == 2)
					{
						DirectionLedManager.GH_NML_02(LINE_MAIN_0);
					}
					if (mode == 3)
					{
						DirectionLedManager.GH_CST(LINE_MAIN_0);
					}
					if (mode == 4)
					{
						DirectionLedManager.GH_JST(LINE_MAIN_0);
					}
					if (mode == 5)
					{
						DirectionLedManager.GH_HOH(LINE_MAIN_0);
					}
					if (mode == 6)
					{
						DirectionLedManager.GH_BONUS_ready(LINE_MAIN_0);
					}
					if (mode == 7)
					{
						DirectionLedManager.GH_BONUS_GB_01(LINE_MAIN_0);
					}
					if (mode == 8)
					{
						DirectionLedManager.GH_BONUS_GB_02(LINE_MAIN_0);
					}
					if (mode == 9)
					{
						DirectionLedManager.GH_BONUS_RB(LINE_MAIN_0);
					}
					if (mode == 10)
					{
						DirectionLedManager.GH_BONUS_PB(LINE_MAIN_0);
					}
					if (mode == 11)
					{
						DirectionLedManager.GH_BD_ready(LINE_MAIN_0);
					}
					if (mode == 12)
					{
						DirectionLedManager.GH_BD(LINE_MAIN_0);
					}
					if (mode == 13)
					{
						DirectionLedManager.GH_RED(LINE_MAIN_0);
					}
					if (mode == 14)
					{
						DirectionLedManager.GH_CHAOS(LINE_MAIN_0);
					}
					if (mode == 15)
					{
						DirectionLedManager.GH_BZT_01(LINE_MAIN_0);
					}
					if (mode == 16)
					{
						DirectionLedManager.GH_theMAN(LINE_MAIN_0);
					}
					if (mode == 17)
					{
						DirectionLedManager.GH_DI(LINE_MAIN_0);
					}
					if (mode != 18)
					{
					}
				}
				else if (32 <= mode && mode <= 33)
				{
					if (mode == 32)
					{
						DirectionLedManager.GH_V(LINE_MAIN_3);
					}
					if (mode == 33)
					{
						DirectionLedManager.GH_V_loop(LINE_MAIN_3);
					}
				}
			}
		}
		if (high != 226)
		{
			return;
		}
		switch (low)
		{
		case 4:
			if (1 <= mode && mode <= 15)
			{
				if (mode == 1)
				{
					DirectionLedManager.DG_TEN_0to1(LINE_MAIN_8);
				}
				if (mode == 2)
				{
					DirectionLedManager.DG_TEN_0to2(LINE_MAIN_8);
				}
				if (mode == 3)
				{
					DirectionLedManager.DG_TEN_0to3(LINE_MAIN_8);
				}
				if (mode == 4)
				{
					DirectionLedManager.DG_TEN_0to4(LINE_MAIN_8);
				}
				if (mode == 5)
				{
					DirectionLedManager.DG_TEN_0to5(LINE_MAIN_8);
				}
				if (mode == 6)
				{
					DirectionLedManager.DG_TEN_1to2(LINE_MAIN_8);
				}
				if (mode == 7)
				{
					DirectionLedManager.DG_TEN_1to3(LINE_MAIN_8);
				}
				if (mode == 8)
				{
					DirectionLedManager.DG_TEN_1to4(LINE_MAIN_8);
				}
				if (mode == 9)
				{
					DirectionLedManager.DG_TEN_1to5(LINE_MAIN_8);
				}
				if (mode == 10)
				{
					DirectionLedManager.DG_TEN_2to3(LINE_MAIN_8);
				}
				if (mode == 11)
				{
					DirectionLedManager.DG_TEN_2to4(LINE_MAIN_8);
				}
				if (mode == 12)
				{
					DirectionLedManager.DG_TEN_2to5(LINE_MAIN_8);
				}
				if (mode == 13)
				{
					DirectionLedManager.DG_TEN_3to4(LINE_MAIN_8);
				}
				if (mode == 14)
				{
					DirectionLedManager.DG_TEN_3to5(LINE_MAIN_8);
				}
				if (mode == 15)
				{
					DirectionLedManager.DG_TEN_4to5(LINE_MAIN_8);
				}
				if (mode == 16)
				{
					DirectionLedManager.DG_TEN_5to0(LINE_MAIN_8);
				}
			}
			else if (17 <= mode && mode <= 21)
			{
				if (mode == 17)
				{
					DirectionLedManager.DG_TEN_1_loop(LINE_MAIN_8);
				}
				if (mode == 18)
				{
					DirectionLedManager.DG_TEN_2_loop(LINE_MAIN_8);
				}
				if (mode == 19)
				{
					DirectionLedManager.DG_TEN_3_loop(LINE_MAIN_8);
				}
				if (mode == 20)
				{
					DirectionLedManager.DG_TEN_4_loop(LINE_MAIN_8);
				}
				if (mode == 21)
				{
					DirectionLedManager.DG_TEN_5_loop(LINE_MAIN_8);
				}
			}
			break;
		case 6:
			if (0 <= mode && mode <= 10)
			{
				if (mode == 0)
				{
					DirectionLedManager.DG_DI_last0(LINE_MAIN_15);
				}
				if (mode == 1)
				{
					DirectionLedManager.DG_DI_last1(LINE_MAIN_15);
				}
				if (mode == 2)
				{
					DirectionLedManager.DG_DI_last2(LINE_MAIN_15);
				}
				if (mode == 3)
				{
					DirectionLedManager.DG_DI_last3(LINE_MAIN_15);
				}
				if (mode == 4)
				{
					DirectionLedManager.DG_DI_last4(LINE_MAIN_15);
				}
				if (mode == 5)
				{
					DirectionLedManager.DG_DI_last5(LINE_MAIN_15);
				}
				if (mode == 6)
				{
					DirectionLedManager.DG_DI_last6(LINE_MAIN_15);
				}
				if (mode == 7)
				{
					DirectionLedManager.DG_DI_last7(LINE_MAIN_15);
				}
				if (mode == 8)
				{
					DirectionLedManager.DG_DI_last8(LINE_MAIN_15);
				}
				if (mode == 9)
				{
					DirectionLedManager.DG_DI_last9(LINE_MAIN_15);
				}
			}
			break;
		case 5:
			if (0 <= mode && mode <= 6)
			{
				if (mode == 0)
				{
					DirectionLedManager.DG_POW1_white_get(LINE_MAIN_9);
				}
				if (mode == 1)
				{
					DirectionLedManager.DG_POW1_blue_get(LINE_MAIN_9);
				}
				if (mode == 2)
				{
					DirectionLedManager.DG_POW1_yellow_get(LINE_MAIN_9);
				}
				if (mode == 3)
				{
					DirectionLedManager.DG_POW1_green_get(LINE_MAIN_9);
				}
				if (mode == 4)
				{
					DirectionLedManager.DG_POW1_red_get(LINE_MAIN_9);
				}
				if (mode == 5)
				{
					DirectionLedManager.DG_POW1_purple_get(LINE_MAIN_9);
				}
				if (mode == 6)
				{
					DirectionLedManager.DG_POW1_rainbow_get(LINE_MAIN_9);
				}
			}
			else if (7 <= mode && mode <= 13)
			{
				if (mode == 7)
				{
					DirectionLedManager.DG_POW2_white_get(LINE_MAIN_10);
				}
				if (mode == 8)
				{
					DirectionLedManager.DG_POW2_blue_get(LINE_MAIN_10);
				}
				if (mode == 9)
				{
					DirectionLedManager.DG_POW2_yellow_get(LINE_MAIN_10);
				}
				if (mode == 10)
				{
					DirectionLedManager.DG_POW2_green_get(LINE_MAIN_10);
				}
				if (mode == 11)
				{
					DirectionLedManager.DG_POW2_red_get(LINE_MAIN_10);
				}
				if (mode == 12)
				{
					DirectionLedManager.DG_POW2_purple_get(LINE_MAIN_10);
				}
				if (mode == 13)
				{
					DirectionLedManager.DG_POW2_rainbow_get(LINE_MAIN_10);
				}
			}
			else if (14 <= mode && mode <= 20)
			{
				if (mode == 14)
				{
					DirectionLedManager.DG_POW3_white_get(LINE_MAIN_11);
				}
				if (mode == 15)
				{
					DirectionLedManager.DG_POW3_blue_get(LINE_MAIN_11);
				}
				if (mode == 16)
				{
					DirectionLedManager.DG_POW3_yellow_get(LINE_MAIN_11);
				}
				if (mode == 17)
				{
					DirectionLedManager.DG_POW3_green_get(LINE_MAIN_11);
				}
				if (mode == 18)
				{
					DirectionLedManager.DG_POW3_red_get(LINE_MAIN_11);
				}
				if (mode == 19)
				{
					DirectionLedManager.DG_POW3_purple_get(LINE_MAIN_11);
				}
				if (mode == 20)
				{
					DirectionLedManager.DG_POW3_rainbow_get(LINE_MAIN_11);
				}
			}
			else if (21 <= mode && mode <= 27)
			{
				if (mode == 21)
				{
					DirectionLedManager.DG_POW4_white_get(LINE_MAIN_12);
				}
				if (mode == 22)
				{
					DirectionLedManager.DG_POW4_blue_get(LINE_MAIN_12);
				}
				if (mode == 23)
				{
					DirectionLedManager.DG_POW4_yellow_get(LINE_MAIN_12);
				}
				if (mode == 24)
				{
					DirectionLedManager.DG_POW4_green_get(LINE_MAIN_12);
				}
				if (mode == 25)
				{
					DirectionLedManager.DG_POW4_red_get(LINE_MAIN_12);
				}
				if (mode == 26)
				{
					DirectionLedManager.DG_POW4_purple_get(LINE_MAIN_12);
				}
				if (mode == 27)
				{
					DirectionLedManager.DG_POW4_rainbow_get(LINE_MAIN_12);
				}
			}
			else if (28 <= mode && mode <= 34)
			{
				if (mode == 28)
				{
					DirectionLedManager.DG_POW5_white_get(LINE_MAIN_13);
				}
				if (mode == 29)
				{
					DirectionLedManager.DG_POW5_blue_get(LINE_MAIN_13);
				}
				if (mode == 30)
				{
					DirectionLedManager.DG_POW5_yellow_get(LINE_MAIN_13);
				}
				if (mode == 31)
				{
					DirectionLedManager.DG_POW5_green_get(LINE_MAIN_13);
				}
				if (mode == 32)
				{
					DirectionLedManager.DG_POW5_red_get(LINE_MAIN_13);
				}
				if (mode == 33)
				{
					DirectionLedManager.DG_POW5_purple_get(LINE_MAIN_13);
				}
				if (mode == 34)
				{
					DirectionLedManager.DG_POW5_rainbow_get(LINE_MAIN_13);
				}
			}
			else if (35 <= mode && mode <= 41)
			{
				if (mode == 35)
				{
					DirectionLedManager.DG_POW6_rainbow_get(LINE_MAIN_14);
				}
				if (mode == 36)
				{
					DirectionLedManager.DG_POW6_rainbow_get(LINE_MAIN_14);
				}
				if (mode == 37)
				{
					DirectionLedManager.DG_POW6_rainbow_get(LINE_MAIN_14);
				}
				if (mode == 38)
				{
					DirectionLedManager.DG_POW6_rainbow_get(LINE_MAIN_14);
				}
				if (mode == 39)
				{
					DirectionLedManager.DG_POW6_rainbow_get(LINE_MAIN_14);
				}
				if (mode == 40)
				{
					DirectionLedManager.DG_POW6_rainbow_get(LINE_MAIN_14);
				}
				if (mode == 41)
				{
					DirectionLedManager.DG_POW6_rainbow_get(LINE_MAIN_14);
				}
			}
			break;
		case 7:
			if (0 <= mode && mode <= 6)
			{
				if (mode == 0)
				{
					DirectionLedManager.DG_POW1_white_blink(LINE_MAIN_9);
				}
				if (mode == 1)
				{
					DirectionLedManager.DG_POW1_blue_blink(LINE_MAIN_9);
				}
				if (mode == 2)
				{
					DirectionLedManager.DG_POW1_yellow_blink(LINE_MAIN_9);
				}
				if (mode == 3)
				{
					DirectionLedManager.DG_POW1_green_blink(LINE_MAIN_9);
				}
				if (mode == 4)
				{
					DirectionLedManager.DG_POW1_red_blink(LINE_MAIN_9);
				}
				if (mode == 5)
				{
					DirectionLedManager.DG_POW1_purple_blink(LINE_MAIN_9);
				}
				if (mode == 6)
				{
					DirectionLedManager.DG_POW1_rainbow_blink(LINE_MAIN_9);
				}
			}
			else if (7 <= mode && mode <= 13)
			{
				if (mode == 7)
				{
					DirectionLedManager.DG_POW2_white_blink(LINE_MAIN_10);
				}
				if (mode == 8)
				{
					DirectionLedManager.DG_POW2_blue_blink(LINE_MAIN_10);
				}
				if (mode == 9)
				{
					DirectionLedManager.DG_POW2_yellow_blink(LINE_MAIN_10);
				}
				if (mode == 10)
				{
					DirectionLedManager.DG_POW2_green_blink(LINE_MAIN_10);
				}
				if (mode == 11)
				{
					DirectionLedManager.DG_POW2_red_blink(LINE_MAIN_10);
				}
				if (mode == 12)
				{
					DirectionLedManager.DG_POW2_purple_blink(LINE_MAIN_10);
				}
				if (mode == 13)
				{
					DirectionLedManager.DG_POW2_rainbow_blink(LINE_MAIN_10);
				}
			}
			else if (14 <= mode && mode <= 20)
			{
				if (mode == 14)
				{
					DirectionLedManager.DG_POW3_white_blink(LINE_MAIN_11);
				}
				if (mode == 15)
				{
					DirectionLedManager.DG_POW3_blue_blink(LINE_MAIN_11);
				}
				if (mode == 16)
				{
					DirectionLedManager.DG_POW3_yellow_blink(LINE_MAIN_11);
				}
				if (mode == 17)
				{
					DirectionLedManager.DG_POW3_green_blink(LINE_MAIN_11);
				}
				if (mode == 18)
				{
					DirectionLedManager.DG_POW3_red_blink(LINE_MAIN_11);
				}
				if (mode == 19)
				{
					DirectionLedManager.DG_POW3_purple_blink(LINE_MAIN_11);
				}
				if (mode == 20)
				{
					DirectionLedManager.DG_POW3_rainbow_blink(LINE_MAIN_11);
				}
			}
			else if (21 <= mode && mode <= 27)
			{
				if (mode == 21)
				{
					DirectionLedManager.DG_POW4_white_blink(LINE_MAIN_12);
				}
				if (mode == 22)
				{
					DirectionLedManager.DG_POW4_blue_blink(LINE_MAIN_12);
				}
				if (mode == 23)
				{
					DirectionLedManager.DG_POW4_yellow_blink(LINE_MAIN_12);
				}
				if (mode == 24)
				{
					DirectionLedManager.DG_POW4_green_blink(LINE_MAIN_12);
				}
				if (mode == 25)
				{
					DirectionLedManager.DG_POW4_red_blink(LINE_MAIN_12);
				}
				if (mode == 26)
				{
					DirectionLedManager.DG_POW4_purple_blink(LINE_MAIN_12);
				}
				if (mode == 27)
				{
					DirectionLedManager.DG_POW4_rainbow_blink(LINE_MAIN_12);
				}
			}
			else if (28 <= mode && mode <= 34)
			{
				if (mode == 28)
				{
					DirectionLedManager.DG_POW5_white_blink(LINE_MAIN_13);
				}
				if (mode == 29)
				{
					DirectionLedManager.DG_POW5_blue_blink(LINE_MAIN_13);
				}
				if (mode == 30)
				{
					DirectionLedManager.DG_POW5_yellow_blink(LINE_MAIN_13);
				}
				if (mode == 31)
				{
					DirectionLedManager.DG_POW5_green_blink(LINE_MAIN_13);
				}
				if (mode == 32)
				{
					DirectionLedManager.DG_POW5_red_blink(LINE_MAIN_13);
				}
				if (mode == 33)
				{
					DirectionLedManager.DG_POW5_purple_blink(LINE_MAIN_13);
				}
				if (mode == 34)
				{
					DirectionLedManager.DG_POW5_rainbow_blink(LINE_MAIN_13);
				}
			}
			else if (35 <= mode && mode <= 41)
			{
				if (mode == 35)
				{
					DirectionLedManager.DG_POW6_rainbow_blink(LINE_MAIN_14);
				}
				if (mode == 36)
				{
					DirectionLedManager.DG_POW6_rainbow_blink(LINE_MAIN_14);
				}
				if (mode == 37)
				{
					DirectionLedManager.DG_POW6_rainbow_blink(LINE_MAIN_14);
				}
				if (mode == 38)
				{
					DirectionLedManager.DG_POW6_rainbow_blink(LINE_MAIN_14);
				}
				if (mode == 39)
				{
					DirectionLedManager.DG_POW6_rainbow_blink(LINE_MAIN_14);
				}
				if (mode == 40)
				{
					DirectionLedManager.DG_POW6_rainbow_blink(LINE_MAIN_14);
				}
				if (mode == 41)
				{
					DirectionLedManager.DG_POW6_rainbow_blink(LINE_MAIN_14);
				}
			}
			break;
		case 8:
			if (0 <= mode && mode <= 6)
			{
				if (mode == 0)
				{
					DirectionLedManager.DG_POW1_white_off(LINE_MAIN_9);
				}
				if (mode == 1)
				{
					DirectionLedManager.DG_POW1_blue_off(LINE_MAIN_9);
				}
				if (mode == 2)
				{
					DirectionLedManager.DG_POW1_yellow_off(LINE_MAIN_9);
				}
				if (mode == 3)
				{
					DirectionLedManager.DG_POW1_green_off(LINE_MAIN_9);
				}
				if (mode == 4)
				{
					DirectionLedManager.DG_POW1_red_off(LINE_MAIN_9);
				}
				if (mode == 5)
				{
					DirectionLedManager.DG_POW1_purple_off(LINE_MAIN_9);
				}
				if (mode == 6)
				{
					DirectionLedManager.DG_POW1_rainbow_off(LINE_MAIN_9);
				}
			}
			else if (7 <= mode && mode <= 13)
			{
				if (mode == 7)
				{
					DirectionLedManager.DG_POW2_white_off(LINE_MAIN_10);
				}
				if (mode == 8)
				{
					DirectionLedManager.DG_POW2_blue_off(LINE_MAIN_10);
				}
				if (mode == 9)
				{
					DirectionLedManager.DG_POW2_yellow_off(LINE_MAIN_10);
				}
				if (mode == 10)
				{
					DirectionLedManager.DG_POW2_green_off(LINE_MAIN_10);
				}
				if (mode == 11)
				{
					DirectionLedManager.DG_POW2_red_off(LINE_MAIN_10);
				}
				if (mode == 12)
				{
					DirectionLedManager.DG_POW2_purple_off(LINE_MAIN_10);
				}
				if (mode == 13)
				{
					DirectionLedManager.DG_POW2_rainbow_off(LINE_MAIN_10);
				}
			}
			else if (14 <= mode && mode <= 20)
			{
				if (mode == 14)
				{
					DirectionLedManager.DG_POW3_white_off(LINE_MAIN_11);
				}
				if (mode == 15)
				{
					DirectionLedManager.DG_POW3_blue_off(LINE_MAIN_11);
				}
				if (mode == 16)
				{
					DirectionLedManager.DG_POW3_yellow_off(LINE_MAIN_11);
				}
				if (mode == 17)
				{
					DirectionLedManager.DG_POW3_green_off(LINE_MAIN_11);
				}
				if (mode == 18)
				{
					DirectionLedManager.DG_POW3_red_off(LINE_MAIN_11);
				}
				if (mode == 19)
				{
					DirectionLedManager.DG_POW3_purple_off(LINE_MAIN_11);
				}
				if (mode == 20)
				{
					DirectionLedManager.DG_POW3_rainbow_off(LINE_MAIN_11);
				}
			}
			else if (21 <= mode && mode <= 27)
			{
				if (mode == 21)
				{
					DirectionLedManager.DG_POW4_white_off(LINE_MAIN_12);
				}
				if (mode == 22)
				{
					DirectionLedManager.DG_POW4_blue_off(LINE_MAIN_12);
				}
				if (mode == 23)
				{
					DirectionLedManager.DG_POW4_yellow_off(LINE_MAIN_12);
				}
				if (mode == 24)
				{
					DirectionLedManager.DG_POW4_green_off(LINE_MAIN_12);
				}
				if (mode == 25)
				{
					DirectionLedManager.DG_POW4_red_off(LINE_MAIN_12);
				}
				if (mode == 26)
				{
					DirectionLedManager.DG_POW4_purple_off(LINE_MAIN_12);
				}
				if (mode == 27)
				{
					DirectionLedManager.DG_POW4_rainbow_off(LINE_MAIN_12);
				}
			}
			else if (28 <= mode && mode <= 34)
			{
				if (mode == 28)
				{
					DirectionLedManager.DG_POW5_white_off(LINE_MAIN_13);
				}
				if (mode == 29)
				{
					DirectionLedManager.DG_POW5_blue_off(LINE_MAIN_13);
				}
				if (mode == 30)
				{
					DirectionLedManager.DG_POW5_yellow_off(LINE_MAIN_13);
				}
				if (mode == 31)
				{
					DirectionLedManager.DG_POW5_green_off(LINE_MAIN_13);
				}
				if (mode == 32)
				{
					DirectionLedManager.DG_POW5_red_off(LINE_MAIN_13);
				}
				if (mode == 33)
				{
					DirectionLedManager.DG_POW5_purple_off(LINE_MAIN_13);
				}
				if (mode == 34)
				{
					DirectionLedManager.DG_POW5_rainbow_off(LINE_MAIN_13);
				}
			}
			else if (35 <= mode && mode <= 41)
			{
				if (mode == 35)
				{
					DirectionLedManager.DG_POW6_rainbow_off(LINE_MAIN_14);
				}
				if (mode == 36)
				{
					DirectionLedManager.DG_POW6_rainbow_off(LINE_MAIN_14);
				}
				if (mode == 37)
				{
					DirectionLedManager.DG_POW6_rainbow_off(LINE_MAIN_14);
				}
				if (mode == 38)
				{
					DirectionLedManager.DG_POW6_rainbow_off(LINE_MAIN_14);
				}
				if (mode == 39)
				{
					DirectionLedManager.DG_POW6_rainbow_off(LINE_MAIN_14);
				}
				if (mode == 40)
				{
					DirectionLedManager.DG_POW6_rainbow_off(LINE_MAIN_14);
				}
				if (mode == 41)
				{
					DirectionLedManager.DG_POW6_rainbow_off(LINE_MAIN_14);
				}
			}
			break;
		case 9:
			if (0 <= mode && mode <= 6)
			{
				if (mode == 0)
				{
					DirectionLedManager.DG_POW1_white_loop(LINE_MAIN_9);
				}
				if (mode == 1)
				{
					DirectionLedManager.DG_POW1_blue_loop(LINE_MAIN_9);
				}
				if (mode == 2)
				{
					DirectionLedManager.DG_POW1_yellow_loop(LINE_MAIN_9);
				}
				if (mode == 3)
				{
					DirectionLedManager.DG_POW1_green_loop(LINE_MAIN_9);
				}
				if (mode == 4)
				{
					DirectionLedManager.DG_POW1_red_loop(LINE_MAIN_9);
				}
				if (mode == 5)
				{
					DirectionLedManager.DG_POW1_purple_loop(LINE_MAIN_9);
				}
				if (mode == 6)
				{
					DirectionLedManager.DG_POW1_rainbow_loop(LINE_MAIN_9);
				}
			}
			else if (7 <= mode && mode <= 13)
			{
				if (mode == 7)
				{
					DirectionLedManager.DG_POW2_white_loop(LINE_MAIN_10);
				}
				if (mode == 8)
				{
					DirectionLedManager.DG_POW2_blue_loop(LINE_MAIN_10);
				}
				if (mode == 9)
				{
					DirectionLedManager.DG_POW2_yellow_loop(LINE_MAIN_10);
				}
				if (mode == 10)
				{
					DirectionLedManager.DG_POW2_green_loop(LINE_MAIN_10);
				}
				if (mode == 11)
				{
					DirectionLedManager.DG_POW2_red_loop(LINE_MAIN_10);
				}
				if (mode == 12)
				{
					DirectionLedManager.DG_POW2_purple_loop(LINE_MAIN_10);
				}
				if (mode == 13)
				{
					DirectionLedManager.DG_POW2_rainbow_loop(LINE_MAIN_10);
				}
			}
			else if (14 <= mode && mode <= 20)
			{
				if (mode == 14)
				{
					DirectionLedManager.DG_POW3_white_loop(LINE_MAIN_11);
				}
				if (mode == 15)
				{
					DirectionLedManager.DG_POW3_blue_loop(LINE_MAIN_11);
				}
				if (mode == 16)
				{
					DirectionLedManager.DG_POW3_yellow_loop(LINE_MAIN_11);
				}
				if (mode == 17)
				{
					DirectionLedManager.DG_POW3_green_loop(LINE_MAIN_11);
				}
				if (mode == 18)
				{
					DirectionLedManager.DG_POW3_red_loop(LINE_MAIN_11);
				}
				if (mode == 19)
				{
					DirectionLedManager.DG_POW3_purple_loop(LINE_MAIN_11);
				}
				if (mode == 20)
				{
					DirectionLedManager.DG_POW3_rainbow_loop(LINE_MAIN_11);
				}
			}
			else if (21 <= mode && mode <= 27)
			{
				if (mode == 21)
				{
					DirectionLedManager.DG_POW4_white_loop(LINE_MAIN_12);
				}
				if (mode == 22)
				{
					DirectionLedManager.DG_POW4_blue_loop(LINE_MAIN_12);
				}
				if (mode == 23)
				{
					DirectionLedManager.DG_POW4_yellow_loop(LINE_MAIN_12);
				}
				if (mode == 24)
				{
					DirectionLedManager.DG_POW4_green_loop(LINE_MAIN_12);
				}
				if (mode == 25)
				{
					DirectionLedManager.DG_POW4_red_loop(LINE_MAIN_12);
				}
				if (mode == 26)
				{
					DirectionLedManager.DG_POW4_purple_loop(LINE_MAIN_12);
				}
				if (mode == 27)
				{
					DirectionLedManager.DG_POW4_rainbow_loop(LINE_MAIN_12);
				}
			}
			else if (28 <= mode && mode <= 34)
			{
				if (mode == 28)
				{
					DirectionLedManager.DG_POW5_white_loop(LINE_MAIN_13);
				}
				if (mode == 29)
				{
					DirectionLedManager.DG_POW5_blue_loop(LINE_MAIN_13);
				}
				if (mode == 30)
				{
					DirectionLedManager.DG_POW5_yellow_loop(LINE_MAIN_13);
				}
				if (mode == 31)
				{
					DirectionLedManager.DG_POW5_green_loop(LINE_MAIN_13);
				}
				if (mode == 32)
				{
					DirectionLedManager.DG_POW5_red_loop(LINE_MAIN_13);
				}
				if (mode == 33)
				{
					DirectionLedManager.DG_POW5_purple_loop(LINE_MAIN_13);
				}
				if (mode == 34)
				{
					DirectionLedManager.DG_POW5_rainbow_loop(LINE_MAIN_13);
				}
			}
			else if (35 <= mode && mode <= 41)
			{
				if (mode == 35)
				{
					DirectionLedManager.DG_POW6_rainbow_loop(LINE_MAIN_14);
				}
				if (mode == 36)
				{
					DirectionLedManager.DG_POW6_rainbow_loop(LINE_MAIN_14);
				}
				if (mode == 37)
				{
					DirectionLedManager.DG_POW6_rainbow_loop(LINE_MAIN_14);
				}
				if (mode == 38)
				{
					DirectionLedManager.DG_POW6_rainbow_loop(LINE_MAIN_14);
				}
				if (mode == 39)
				{
					DirectionLedManager.DG_POW6_rainbow_loop(LINE_MAIN_14);
				}
				if (mode == 40)
				{
					DirectionLedManager.DG_POW6_rainbow_loop(LINE_MAIN_14);
				}
				if (mode == 41)
				{
					DirectionLedManager.DG_POW6_rainbow_loop(LINE_MAIN_14);
				}
			}
			break;
		}
	}

	public void _end()
	{
	}

	public void _control()
	{
	}
}
