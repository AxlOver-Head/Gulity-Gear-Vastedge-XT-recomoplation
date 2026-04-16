using System;

public class LEDPanelManager
{
	public enum LINE
	{
		LAYER_1M = 0,
		LAYER_2M = 1,
		LAYER_3M = 2,
		LAYER_4M = 3,
		LAYER_5M = 4,
		LAYER_6M = 5,
		LAYER_7M = 6,
		LAYER_8M = 7,
		LAYER_9M = 8,
		MAX = 9
	}

	public enum KIND
	{
		lever_ball_on_loop = 0,
		lever_ball_v = 1,
		lever_ball_v_loop = 2,
		lever_ball_white_loop = 3,
		lever_ball_blue_loop = 4,
		lever_ball_yellow_loop = 5,
		lever_ball_green_loop = 6,
		lever_ball_red_loop = 7,
		lever_ball_purple_loop = 8,
		lever_ball_rainbow_loop = 9,
		m_panel_error_loop = 10,
		m_panel_RAMCLEAR_01 = 11,
		m_panel_RAMCLEAR_02 = 12,
		m_panel_dest_01 = 13,
		m_panel_dest_01_loop = 14,
		m_panel_dest_02 = 15,
		m_panel_dest_02_loop = 16,
		m_panel_dest_03 = 17,
		m_panel_dest_03_loop = 18,
		m_panel_dest_04 = 19,
		m_panel_dest_04_loop = 20,
		m_panel_DI_f = 21,
		m_panel_DI_f_loop = 22,
		m_panel_DI_01_loop = 23,
		m_panel_DI_02_loop = 24,
		m_panel_DI_in = 25,
		m_panel_DI_in_loop = 26,
		m_panel_HOH_loop = 27,
		m_panel_KBS_01_loop = 28,
		m_panel_KBS_02_loop = 29,
		m_panel_KBS_03_loop = 30,
		m_panel_KBS_04_loop = 31,
		m_panel_KBS_05_loop = 32,
		m_panel_KBS_sl = 33,
		m_panel_KBS_sl_loop = 34,
		m_panel_KBS_cp = 35,
		m_panel_KBS_cp_loop = 36,
		m_panel_KBS_ml = 37,
		m_panel_KBS_ml_loop = 38,
		m_panel_KBS_bj = 39,
		m_panel_KBS_bj_loop = 40,
		m_panel_KBS_zp = 41,
		m_panel_KBS_zp_loop = 42,
		m_panel_HOH_sl_vs_01 = 43,
		m_panel_HOH_sl_vs_01_loop = 44,
		m_panel_HOH_sl_vs_02 = 45,
		m_panel_HOH_sl_vs_02_loop = 46,
		m_panel_HOH_sl_vs_03 = 47,
		m_panel_HOH_sl_vs_03_loop = 48,
		m_panel_HOH_sl_01_loop = 49,
		m_panel_HOH_sl_02_loop = 50,
		m_panel_HOH_cp_vs_01 = 51,
		m_panel_HOH_cp_vs_01_loop = 52,
		m_panel_HOH_cp_vs_02 = 53,
		m_panel_HOH_cp_vs_02_loop = 54,
		m_panel_HOH_cp_vs_03 = 55,
		m_panel_HOH_cp_vs_03_loop = 56,
		m_panel_HOH_cp_01_loop = 57,
		m_panel_HOH_cp_02_loop = 58,
		m_panel_HOH_ml_vs_01 = 59,
		m_panel_HOH_ml_vs_01_loop = 60,
		m_panel_HOH_ml_vs_02 = 61,
		m_panel_HOH_ml_vs_02_loop = 62,
		m_panel_HOH_ml_vs_03 = 63,
		m_panel_HOH_ml_vs_03_loop = 64,
		m_panel_HOH_ml_01_loop = 65,
		m_panel_HOH_ml_02_loop = 66,
		m_panel_HOH_bj_vs_01 = 67,
		m_panel_HOH_bj_vs_01_loop = 68,
		m_panel_HOH_bj_vs_02 = 69,
		m_panel_HOH_bj_vs_02_loop = 70,
		m_panel_HOH_bj_vs_03 = 71,
		m_panel_HOH_bj_vs_03_loop = 72,
		m_panel_HOH_bj_01_loop = 73,
		m_panel_HOH_bj_02_loop = 74,
		m_panel_HOH_zp_vs_01 = 75,
		m_panel_HOH_zp_vs_01_loop = 76,
		m_panel_HOH_zp_vs_02 = 77,
		m_panel_HOH_zp_vs_02_loop = 78,
		m_panel_HOH_zp_vs_03 = 79,
		m_panel_HOH_zp_vs_03_loop = 80,
		m_panel_HOH_zp_01_loop = 81,
		m_panel_slash = 82,
		m_panel_slash_loop = 83,
		m_panel_odds_loop = 84,
		m_panel_win_heat_01 = 85,
		m_panel_win_heat_01_loop = 86,
		m_panel_win_heat_02 = 87,
		m_panel_win_heat_02_loop = 88,
		m_panel_win_heat_03 = 89,
		m_panel_win_heat_03_loop = 90,
		m_panel_win = 91,
		m_panel_win_PB_in = 92,
		m_panel_win_PB_in_loop = 93,
		m_panel_win_SGB_in = 94,
		m_panel_win_SGB_in_loop = 95,
		m_panel_win_GB_in = 96,
		m_panel_win_GB_in_loop = 97,
		m_panel_win_RB_in = 98,
		m_panel_win_RB_in_loop = 99,
		m_panel_win_PB_end = 100,
		m_panel_win_SGB_end = 101,
		m_panel_win_GB_end = 102,
		m_panel_win_RB_end = 103,
		m_panel_NV_y_L_loop = 104,
		m_panel_NV_y_C_loop = 105,
		m_panel_NV_y_R_loop = 106,
		m_panel_NV_y_get = 107,
		m_panel_NV_b_L_loop = 108,
		m_panel_NV_b_C_loop = 109,
		m_panel_NV_b_R_loop = 110,
		m_panel_NV_b_get = 111,
		m_panel_NV_w_L_loop = 112,
		m_panel_NV_w_C_loop = 113,
		m_panel_NV_w_R_loop = 114,
		m_panel_NV_w_get = 115,
		m_panel_NV_p_L_loop = 116,
		m_panel_NV_p_C_loop = 117,
		m_panel_NV_p_R_loop = 118,
		m_panel_NV_p_get = 119,
		m_panel_NV_r_L_loop = 120,
		m_panel_NV_r_C_loop = 121,
		m_panel_NV_r_R_loop = 122,
		m_panel_NV_r_get = 123,
		m_panel_NV_Q_ooo_loop = 124,
		m_panel_NV_Q_xoo_loop = 125,
		m_panel_NV_Q_oxo_loop = 126,
		m_panel_NV_Q_oox_loop = 127,
		m_panel_NV_Q_oxx_loop = 128,
		m_panel_NV_Q_xox_loop = 129,
		m_panel_NV_Q_xxo_loop = 130,
		m_panel_waku_01_loop = 131,
		m_panel_waku_02_loop = 132,
		m_panel_waku_03_loop = 133,
		m_panel_waku_04 = 134,
		m_panel_waku_04_loop = 135,
		m_panel_waku_05_loop = 136,
		m_panel_waku_06_loop = 137,
		m_panel_DI_step_01 = 138,
		m_panel_DI_step_02 = 139,
		m_panel_DI_step_03 = 140,
		m_panel_DI_step_04 = 141,
		m_panel_DI_step_04_loop = 142,
		m_panel_wi_dest = 143,
		m_panel_wi_dest_loop = 144,
		m_panel_wi_dest_lose = 145,
		m_panel_wi_reverse = 146,
		m_panel_KCI_step_01 = 147,
		m_panel_KCI_step_02 = 148,
		m_panel_KCI_step_03 = 149,
		push_white_loop = 150,
		push_blue_loop = 151,
		push_yellow_loop = 152,
		push_green_loop = 153,
		push_red_loop = 154,
		push_purple_loop = 155,
		push_rainbow_loop = 156,
		push_on_rainbow = 157,
		push_on_rainbow_loop = 158,
		push_flash_white = 159,
		push_flash_blue = 160,
		push_flash_yellow = 161,
		push_flash_green = 162,
		push_flash_red = 163,
		push_flash_purple = 164,
		push_flash_rainbow = 165,
		push_blink_white_loop = 166,
		push_blink_blue_01_loop = 167,
		push_blink_blue_02_loop = 168,
		push_blink_red_01_loop = 169,
		push_blink_red_02_loop = 170,
		push_on_rainbow_BZT = 171,
		push_around_white_loop = 172,
		push_around_blue_loop = 173,
		push_around_yellow_loop = 174,
		push_around_green_loop = 175,
		push_around_red_loop = 176,
		push_around_purple_loop = 177,
		push_around_rainbow_loop = 178,
		push_around_on_rainbow = 179,
		push_around_on_rainbow_loop = 180,
		push_around_flash_white = 181,
		push_around_flash_blue = 182,
		push_around_flash_yellow = 183,
		push_around_flash_green = 184,
		push_around_flash_red = 185,
		push_around_flash_purple = 186,
		push_around_flash_rainbow = 187,
		push_around_blink_white_loop = 188,
		push_around_blink_blue_01_loop = 189,
		push_around_blink_blue_02_loop = 190,
		push_around_blink_red_01_loop = 191,
		push_around_blink_red_02_loop = 192,
		push_around_on_rainbow_BZT = 193,
		reel_00_loop = 194,
		reel_PB = 195,
		reel_PB_loop = 196,
		reel_MB = 197,
		reel_7_w1 = 198,
		reel_7_w1_loop = 199,
		reel_7_w2 = 200,
		reel_7_w2_loop = 201,
		reel_7_c = 202,
		reel_7_c_loop = 203,
		reel_7_cu = 204,
		reel_7_cu_loop = 205,
		reel_7_cd = 206,
		reel_7_cd_loop = 207,
		reel_bar = 208,
		reel_bar_loop = 209,
		reel_bonus_in = 210,
		reel_bonus_in_loop = 211,
		reel_dest_start = 212,
		reel_dest_start_loop = 213,
		reel_dest_1stop = 214,
		reel_dest_01_loop = 215,
		reel_dest_2stop = 216,
		reel_dest_02_loop = 217,
		reel_dest_3stop = 218,
		reel_dest_03_loop = 219,
		reel_dest_in = 220,
		reel_dest_miss = 221,
		reel_dest_miss_loop = 222,
		reel_dest_0G = 223,
		reel_dest_0G_loop = 224,
		reel_replay_01 = 225,
		reel_replay_02 = 226,
		reel_replay_03 = 227,
		reel_replay_04 = 228,
		reel_replay_04_loop = 229,
		reel_replay_05 = 230,
		reel_replay_05_loop = 231,
		reel_replay_06 = 232,
		reel_replay_06_loop = 233,
		reel_replay_07_loop = 234,
		reel_replay_08 = 235,
		reel_replay_08_loop = 236,
		reel_replay_09_loop = 237,
		reel_replay_10 = 238,
		reel_replay_10_loop = 239,
		reel_replay_11 = 240,
		reel_replay_11_loop = 241,
		reel_replay_12_loop = 242,
		reel_replay_13 = 243,
		reel_replay_13_loop = 244,
		reel_bell_01_loop = 245,
		reel_bell_02 = 246,
		reel_bell_02_loop = 247,
		reel_bell_03_loop = 248,
		reel_bell_04 = 249,
		reel_bell_04_loop = 250,
		reel_bell_05_loop = 251,
		reel_bell_06 = 252,
		reel_bell_06_loop = 253,
		reel_bell_07_loop = 254,
		reel_bell_08 = 255,
		reel_bell_08_loop = 256,
		reel_bell_09_loop = 257,
		reel_bell_10 = 258,
		reel_bell_10_loop = 259,
		reel_bell_11_loop = 260,
		reel_bell_12 = 261,
		reel_bell_12_loop = 262,
		reel_bell_13_loop = 263,
		reel_bell_14 = 264,
		reel_bell_14_loop = 265,
		reel_bell_15_loop = 266,
		reel_bell_16 = 267,
		reel_bell_16_loop = 268,
		reel_bell_17_loop = 269,
		reel_bell_18 = 270,
		reel_bell_18_loop = 271,
		reel_bell_19_loop = 272,
		reel_bell_20 = 273,
		reel_bell_20_loop = 274,
		reel_bell_21_loop = 275,
		reel_bell_22 = 276,
		reel_bell_22_loop = 277,
		reel_bell_23 = 278,
		reel_bell_24_loop = 279,
		reel_bell_25 = 280,
		reel_bell_25_loop = 281,
		reel_bell_26_loop = 282,
		reel_bell_27_loop = 283,
		reel_bell_28_loop = 284,
		reel_bell_29_loop = 285,
		reel_bell_30_loop = 286,
		reel_bell_31_loop = 287,
		reel_bell_32_loop = 288,
		reel_bell_33_loop = 289,
		reel_bell_34_loop = 290,
		reel_bell_35_loop = 291,
		reel_bell_36_loop = 292,
		reel_bell_37_loop = 293,
		reel_bell_38_loop = 294,
		reel_bell_39_loop = 295,
		reel_bell_40_loop = 296,
		reel_bell_41_loop = 297,
		reel_bell_13pay = 298,
		reel_bell_13pay_ch = 299,
		reel_bell_14pay = 300,
		reel_bell_14pay_ch = 301,
		reel_suika_01_loop = 302,
		reel_suika_02 = 303,
		reel_suika_02_loop = 304,
		reel_suika_03_loop = 305,
		reel_suika_04 = 306,
		reel_suika_04_loop = 307,
		reel_suika_05_loop = 308,
		reel_suika_06 = 309,
		reel_suika_06_loop = 310,
		reel_suika_07_loop = 311,
		reel_suika_08 = 312,
		reel_suika_08_loop = 313,
		reel_cherry_01_loop = 314,
		reel_cherry_02 = 315,
		reel_cherry_02_loop = 316,
		reel_cherry_03 = 317,
		reel_cherry_03_loop = 318,
		reel_cherry_04 = 319,
		reel_cherry_04_loop = 320,
		reel_cherry_c_loop = 321,
		reel_cherry_05 = 322,
		reel_cherry_05_loop = 323,
		reel_chance_01 = 324,
		reel_chance_01_loop = 325,
		reel_chance_02 = 326,
		reel_chance_02_loop = 327,
		reel_chance_03 = 328,
		reel_chance_03_loop = 329,
		reel_chance_04 = 330,
		reel_chance_04_loop = 331,
		reel_v = 332,
		reel_demo_loop = 333,
		reel_RAMCLEAR_01 = 334,
		reel_RAMCLEAR_02 = 335,
		MAX = 336
	}

	public LEDPanelLine[] ledLines;

	public byte[] blendData = new byte[178];

	private LEDPanelObj_Reel m_Reel;

	private LEDPanelObj_AroundPush m_APush;

	private LEDPanelObj_Panel m_Panel;

	private LEDPanelObj_Push m_Push;

	private LEDPanelObj_Lever m_Lever;

	public static readonly string[] filename = new string[336]
	{
		"lever_ball_on_loop", "lever_ball_v", "lever_ball_v_loop", "lever_ball_white_loop", "lever_ball_blue_loop", "lever_ball_yellow_loop", "lever_ball_green_loop", "lever_ball_red_loop", "lever_ball_purple_loop", "lever_ball_rainbow_loop",
		"m_panel_error_loop", "m_panel_RAMCLEAR_01", "m_panel_RAMCLEAR_02", "m_panel_dest_01", "m_panel_dest_01_loop", "m_panel_dest_02", "m_panel_dest_02_loop", "m_panel_dest_03", "m_panel_dest_03_loop", "m_panel_dest_04",
		"m_panel_dest_04_loop", "m_panel_DI_f", "m_panel_DI_f_loop", "m_panel_DI_01_loop", "m_panel_DI_02_loop", "m_panel_DI_in", "m_panel_DI_in_loop", "m_panel_HOH_loop", "m_panel_KBS_01_loop", "m_panel_KBS_02_loop",
		"m_panel_KBS_03_loop", "m_panel_KBS_04_loop", "m_panel_KBS_05_loop", "m_panel_KBS_sl", "m_panel_KBS_sl_loop", "m_panel_KBS_cp", "m_panel_KBS_cp_loop", "m_panel_KBS_ml", "m_panel_KBS_ml_loop", "m_panel_KBS_bj",
		"m_panel_KBS_bj_loop", "m_panel_KBS_zp", "m_panel_KBS_zp_loop", "m_panel_HOH_sl_vs_01", "m_panel_HOH_sl_vs_01_loop", "m_panel_HOH_sl_vs_02", "m_panel_HOH_sl_vs_02_loop", "m_panel_HOH_sl_vs_03", "m_panel_HOH_sl_vs_03_loop", "m_panel_HOH_sl_01_loop",
		"m_panel_HOH_sl_02_loop", "m_panel_HOH_cp_vs_01", "m_panel_HOH_cp_vs_01_loop", "m_panel_HOH_cp_vs_02", "m_panel_HOH_cp_vs_02_loop", "m_panel_HOH_cp_vs_03", "m_panel_HOH_cp_vs_03_loop", "m_panel_HOH_cp_01_loop", "m_panel_HOH_cp_02_loop", "m_panel_HOH_ml_vs_01",
		"m_panel_HOH_ml_vs_01_loop", "m_panel_HOH_ml_vs_02", "m_panel_HOH_ml_vs_02_loop", "m_panel_HOH_ml_vs_03", "m_panel_HOH_ml_vs_03_loop", "m_panel_HOH_ml_01_loop", "m_panel_HOH_ml_02_loop", "m_panel_HOH_bj_vs_01", "m_panel_HOH_bj_vs_01_loop", "m_panel_HOH_bj_vs_02",
		"m_panel_HOH_bj_vs_02_loop", "m_panel_HOH_bj_vs_03", "m_panel_HOH_bj_vs_03_loop", "m_panel_HOH_bj_01_loop", "m_panel_HOH_bj_02_loop", "m_panel_HOH_zp_vs_01", "m_panel_HOH_zp_vs_01_loop", "m_panel_HOH_zp_vs_02", "m_panel_HOH_zp_vs_02_loop", "m_panel_HOH_zp_vs_03",
		"m_panel_HOH_zp_vs_03_loop", "m_panel_HOH_zp_01_loop", "m_panel_slash", "m_panel_slash_loop", "m_panel_odds_loop", "m_panel_win_heat_01", "m_panel_win_heat_01_loop", "m_panel_win_heat_02", "m_panel_win_heat_02_loop", "m_panel_win_heat_03",
		"m_panel_win_heat_03_loop", "m_panel_win", "m_panel_win_PB_in", "m_panel_win_PB_in_loop", "m_panel_win_SGB_in", "m_panel_win_SGB_in_loop", "m_panel_win_GB_in", "m_panel_win_GB_in_loop", "m_panel_win_RB_in", "m_panel_win_RB_in_loop",
		"m_panel_win_PB_end", "m_panel_win_SGB_end", "m_panel_win_GB_end", "m_panel_win_RB_end", "m_panel_NV_y_L_loop", "m_panel_NV_y_C_loop", "m_panel_NV_y_R_loop", "m_panel_NV_y_get", "m_panel_NV_b_L_loop", "m_panel_NV_b_C_loop",
		"m_panel_NV_b_R_loop", "m_panel_NV_b_get", "m_panel_NV_w_L_loop", "m_panel_NV_w_C_loop", "m_panel_NV_w_R_loop", "m_panel_NV_w_get", "m_panel_NV_p_L_loop", "m_panel_NV_p_C_loop", "m_panel_NV_p_R_loop", "m_panel_NV_p_get",
		"m_panel_NV_r_L_loop", "m_panel_NV_r_C_loop", "m_panel_NV_r_R_loop", "m_panel_NV_r_get", "m_panel_NV_Q_ooo_loop", "m_panel_NV_Q_xoo_loop", "m_panel_NV_Q_oxo_loop", "m_panel_NV_Q_oox_loop", "m_panel_NV_Q_oxx_loop", "m_panel_NV_Q_xox_loop",
		"m_panel_NV_Q_xxo_loop", "m_panel_waku_01_loop", "m_panel_waku_02_loop", "m_panel_waku_03_loop", "m_panel_waku_04", "m_panel_waku_04_loop", "m_panel_waku_05_loop", "m_panel_waku_06_loop", "m_panel_DI_step_01", "m_panel_DI_step_02",
		"m_panel_DI_step_03", "m_panel_DI_step_04", "m_panel_DI_step_04_loop", "m_panel_wi_dest", "m_panel_wi_dest_loop", "m_panel_wi_dest_lose", "m_panel_wi_reverse", "m_panel_KCI_step_01", "m_panel_KCI_step_02", "m_panel_KCI_step_03",
		"push_white_loop", "push_blue_loop", "push_yellow_loop", "push_green_loop", "push_red_loop", "push_purple_loop", "push_rainbow_loop", "push_on_rainbow", "push_on_rainbow_loop", "push_flash_white",
		"push_flash_blue", "push_flash_yellow", "push_flash_green", "push_flash_red", "push_flash_purple", "push_flash_rainbow", "push_blink_white_loop", "push_blink_blue_01_loop", "push_blink_blue_02_loop", "push_blink_red_01_loop",
		"push_blink_red_02_loop", "push_on_rainbow_BZT", "push_around_white_loop", "push_around_blue_loop", "push_around_yellow_loop", "push_around_green_loop", "push_around_red_loop", "push_around_purple_loop", "push_around_rainbow_loop", "push_around_on_rainbow",
		"push_around_on_rainbow_loop", "push_around_flash_white", "push_around_flash_blue", "push_around_flash_yellow", "push_around_flash_green", "push_around_flash_red", "push_around_flash_purple", "push_around_flash_rainbow", "push_around_blink_white_loop", "push_around_blink_blue_01_loop",
		"push_around_blink_blue_02_loop", "push_around_blink_red_01_loop", "push_around_blink_red_02_loop", "push_around_on_rainbow_BZT", "reel_00_loop", "reel_PB", "reel_PB_loop", "reel_MB", "reel_7_w1", "reel_7_w1_loop",
		"reel_7_w2", "reel_7_w2_loop", "reel_7_c", "reel_7_c_loop", "reel_7_cu", "reel_7_cu_loop", "reel_7_cd", "reel_7_cd_loop", "reel_bar", "reel_bar_loop",
		"reel_bonus_in", "reel_bonus_in_loop", "reel_dest_start", "reel_dest_start_loop", "reel_dest_1stop", "reel_dest_01_loop", "reel_dest_2stop", "reel_dest_02_loop", "reel_dest_3stop", "reel_dest_03_loop",
		"reel_dest_in", "reel_dest_miss", "reel_dest_miss_loop", "reel_dest_0G", "reel_dest_0G_loop", "reel_replay_01", "reel_replay_02", "reel_replay_03", "reel_replay_04", "reel_replay_04_loop",
		"reel_replay_05", "reel_replay_05_loop", "reel_replay_06", "reel_replay_06_loop", "reel_replay_07_loop", "reel_replay_08", "reel_replay_08_loop", "reel_replay_09_loop", "reel_replay_10", "reel_replay_10_loop",
		"reel_replay_11", "reel_replay_11_loop", "reel_replay_12_loop", "reel_replay_13", "reel_replay_13_loop", "reel_bell_01_loop", "reel_bell_02", "reel_bell_02_loop", "reel_bell_03_loop", "reel_bell_04",
		"reel_bell_04_loop", "reel_bell_05_loop", "reel_bell_06", "reel_bell_06_loop", "reel_bell_07_loop", "reel_bell_08", "reel_bell_08_loop", "reel_bell_09_loop", "reel_bell_10", "reel_bell_10_loop",
		"reel_bell_11_loop", "reel_bell_12", "reel_bell_12_loop", "reel_bell_13_loop", "reel_bell_14", "reel_bell_14_loop", "reel_bell_15_loop", "reel_bell_16", "reel_bell_16_loop", "reel_bell_17_loop",
		"reel_bell_18", "reel_bell_18_loop", "reel_bell_19_loop", "reel_bell_20", "reel_bell_20_loop", "reel_bell_21_loop", "reel_bell_22", "reel_bell_22_loop", "reel_bell_23", "reel_bell_24_loop",
		"reel_bell_25", "reel_bell_25_loop", "reel_bell_26_loop", "reel_bell_27_loop", "reel_bell_28_loop", "reel_bell_29_loop", "reel_bell_30_loop", "reel_bell_31_loop", "reel_bell_32_loop", "reel_bell_33_loop",
		"reel_bell_34_loop", "reel_bell_35_loop", "reel_bell_36_loop", "reel_bell_37_loop", "reel_bell_38_loop", "reel_bell_39_loop", "reel_bell_40_loop", "reel_bell_41_loop", "reel_bell_13pay", "reel_bell_13pay_ch",
		"reel_bell_14pay", "reel_bell_14pay_ch", "reel_suika_01_loop", "reel_suika_02", "reel_suika_02_loop", "reel_suika_03_loop", "reel_suika_04", "reel_suika_04_loop", "reel_suika_05_loop", "reel_suika_06",
		"reel_suika_06_loop", "reel_suika_07_loop", "reel_suika_08", "reel_suika_08_loop", "reel_cherry_01_loop", "reel_cherry_02", "reel_cherry_02_loop", "reel_cherry_03", "reel_cherry_03_loop", "reel_cherry_04",
		"reel_cherry_04_loop", "reel_cherry_c_loop", "reel_cherry_05", "reel_cherry_05_loop", "reel_chance_01", "reel_chance_01_loop", "reel_chance_02", "reel_chance_02_loop", "reel_chance_03", "reel_chance_03_loop",
		"reel_chance_04", "reel_chance_04_loop", "reel_v", "reel_demo_loop", "reel_RAMCLEAR_01", "reel_RAMCLEAR_02"
	};

	public static readonly short[] frameList = new short[336]
	{
		2, 39, 38, 2, 2, 2, 2, 2, 2, 39,
		2, 66, 800, 9, 33, 9, 15, 66, 2, 66,
		2, 347, 2, 2, 51, 83, 2, 2, 8, 8,
		8, 8, 2, 52, 2, 52, 2, 52, 2, 52,
		2, 52, 2, 193, 2, 193, 2, 193, 2, 2,
		2, 193, 2, 193, 2, 193, 2, 2, 2, 193,
		2, 193, 2, 193, 2, 2, 2, 193, 2, 193,
		2, 193, 2, 2, 2, 193, 2, 193, 2, 193,
		2, 2, 50, 2, 2, 33, 33, 33, 33, 33,
		36, 2, 68, 67, 52, 33, 52, 34, 52, 34,
		95, 95, 95, 95, 16, 16, 16, 44, 16, 16,
		16, 30, 16, 16, 16, 40, 16, 16, 16, 44,
		16, 16, 16, 44, 16, 16, 16, 16, 16, 16,
		16, 2, 2, 2, 13, 2, 34, 12, 41, 41,
		33, 23, 23, 50, 19, 19, 107, 69, 70, 73,
		2, 2, 2, 2, 2, 2, 39, 40, 39, 4,
		4, 4, 4, 4, 4, 4, 2, 2, 2, 2,
		2, 134, 2, 2, 2, 2, 2, 2, 39, 40,
		52, 4, 4, 4, 4, 4, 4, 4, 2, 2,
		2, 2, 2, 134, 2, 69, 33, 36, 92, 6,
		92, 6, 92, 6, 92, 6, 92, 6, 105, 6,
		77, 6, 16, 2, 9, 16, 9, 16, 9, 16,
		86, 20, 2, 56, 2, 19, 19, 19, 19, 17,
		19, 17, 35, 6, 17, 17, 17, 17, 17, 17,
		84, 2, 17, 17, 17, 17, 17, 17, 17, 17,
		17, 17, 17, 17, 17, 17, 17, 17, 17, 17,
		17, 17, 17, 17, 17, 17, 17, 17, 17, 17,
		17, 17, 17, 17, 17, 17, 17, 17, 17, 17,
		26, 6, 17, 17, 17, 17, 17, 17, 17, 17,
		17, 17, 17, 17, 17, 17, 17, 17, 20, 20,
		20, 20, 17, 17, 17, 17, 17, 17, 17, 17,
		17, 17, 17, 17, 17, 17, 17, 14, 6, 14,
		6, 17, 17, 6, 29, 2, 29, 2, 40, 2,
		40, 2, 45, 124, 66, 800
	};

	public LEDPanelManager()
	{
		ledLines = new LEDPanelLine[9];
		for (int i = 0; i < 9; i++)
		{
			ledLines[i] = null;
		}
		m_Reel = new LEDPanelObj_Reel(this);
		m_APush = new LEDPanelObj_AroundPush(this);
		m_Panel = new LEDPanelObj_Panel(this);
		m_Push = new LEDPanelObj_Push(this);
		m_Lever = new LEDPanelObj_Lever(this);
		Array.Clear(blendData, 0, 178);
		init();
	}

	public void init()
	{
		m_Reel.init();
		m_APush.init();
		m_Panel.init();
		m_Push.init();
		m_Lever.init();
	}

	private LEDPanelLine createLine(int _id)
	{
		LEDPanelLine result = null;
		switch (_id)
		{
		case 0:
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
		case 9:
			result = new LEDPanelLine_Lever();
			break;
		case 10:
		case 11:
		case 12:
			result = new LEDPanelLine_Panel();
			break;
		case 13:
		case 14:
		case 15:
		case 16:
		case 17:
		case 18:
		case 19:
		case 20:
		case 21:
		case 22:
		case 23:
		case 24:
		case 25:
		case 26:
			result = new LEDPanelLine_PanelBottom();
			break;
		case 27:
		case 28:
		case 29:
		case 30:
		case 31:
		case 32:
		case 33:
		case 34:
		case 35:
		case 36:
		case 37:
		case 38:
		case 39:
		case 40:
		case 41:
		case 42:
		case 43:
		case 44:
		case 45:
		case 46:
		case 47:
		case 48:
		case 49:
		case 50:
		case 51:
		case 52:
		case 53:
		case 54:
		case 55:
		case 56:
		case 57:
		case 58:
		case 59:
		case 60:
		case 61:
		case 62:
		case 63:
		case 64:
		case 65:
		case 66:
		case 67:
		case 68:
		case 69:
		case 70:
		case 71:
		case 72:
		case 73:
		case 74:
		case 75:
		case 76:
		case 77:
		case 78:
		case 79:
		case 80:
		case 81:
			result = new LEDPanelLine_PanelRight();
			break;
		case 82:
		case 83:
		case 84:
			result = new LEDPanelLine_PanelTop();
			break;
		case 85:
		case 86:
		case 87:
		case 88:
		case 89:
		case 90:
		case 91:
		case 92:
		case 93:
		case 94:
		case 95:
		case 96:
		case 97:
		case 98:
		case 99:
		case 100:
		case 101:
		case 102:
		case 103:
			result = new LEDPanelLine_PanelWin();
			break;
		case 104:
		case 105:
		case 106:
		case 107:
		case 108:
		case 109:
		case 110:
		case 111:
		case 112:
		case 113:
		case 114:
		case 115:
		case 116:
		case 117:
		case 118:
		case 119:
		case 120:
		case 121:
		case 122:
		case 123:
		case 124:
		case 125:
		case 126:
		case 127:
		case 128:
		case 129:
		case 130:
		case 131:
		case 132:
		case 133:
		case 134:
		case 135:
		case 136:
		case 137:
		case 138:
		case 139:
		case 140:
		case 141:
		case 142:
		case 143:
		case 144:
		case 145:
		case 146:
		case 147:
		case 148:
		case 149:
			result = new LEDPanelLine_PanelWindow();
			break;
		case 150:
		case 151:
		case 152:
		case 153:
		case 154:
		case 155:
		case 156:
		case 157:
		case 158:
		case 159:
		case 160:
		case 161:
		case 162:
		case 163:
		case 164:
		case 165:
		case 166:
		case 167:
		case 168:
		case 169:
		case 170:
		case 171:
			result = new LEDPanelLine_Push();
			break;
		case 172:
		case 173:
		case 174:
		case 175:
		case 176:
		case 177:
		case 178:
		case 179:
		case 180:
		case 181:
		case 182:
		case 183:
		case 184:
		case 185:
		case 186:
		case 187:
		case 188:
		case 189:
		case 190:
		case 191:
		case 192:
		case 193:
			result = new LEDPanelLine_PushAround();
			break;
		case 194:
		case 195:
		case 196:
		case 197:
		case 198:
		case 199:
		case 200:
		case 201:
		case 202:
		case 203:
		case 204:
		case 205:
		case 206:
		case 207:
		case 208:
		case 209:
		case 210:
		case 211:
		case 212:
		case 213:
		case 214:
		case 215:
		case 216:
		case 217:
		case 218:
		case 219:
		case 220:
		case 221:
		case 222:
		case 223:
		case 224:
		case 225:
		case 226:
		case 227:
		case 228:
		case 229:
		case 230:
		case 231:
		case 232:
		case 233:
		case 234:
		case 235:
		case 236:
		case 237:
		case 238:
		case 239:
		case 240:
		case 241:
		case 242:
		case 243:
		case 244:
		case 245:
		case 246:
		case 247:
		case 248:
		case 249:
		case 250:
		case 251:
		case 252:
		case 253:
		case 254:
		case 255:
		case 256:
		case 257:
		case 258:
		case 259:
		case 260:
		case 261:
		case 262:
		case 263:
		case 264:
		case 265:
		case 266:
		case 267:
		case 268:
		case 269:
		case 270:
		case 271:
		case 272:
		case 273:
		case 274:
		case 275:
		case 276:
		case 277:
		case 278:
		case 279:
		case 280:
		case 281:
		case 282:
		case 283:
		case 284:
		case 285:
		case 286:
		case 287:
		case 288:
		case 289:
		case 290:
		case 291:
		case 292:
		case 293:
		case 294:
		case 295:
		case 296:
		case 297:
		case 298:
		case 299:
		case 300:
		case 301:
		case 302:
		case 303:
		case 304:
		case 305:
		case 306:
		case 307:
		case 308:
		case 309:
		case 310:
		case 311:
		case 312:
		case 313:
		case 314:
		case 315:
		case 316:
		case 317:
		case 318:
		case 319:
		case 320:
		case 321:
		case 322:
		case 323:
		case 324:
		case 325:
		case 326:
		case 327:
		case 328:
		case 329:
		case 330:
		case 331:
		case 332:
		case 333:
		case 334:
		case 335:
			result = new LEDPanelLine_Reel();
			break;
		}
		return result;
	}

	public void start(LINE _line, int _id, bool _loop)
	{
		if (_line < LINE.MAX && _id >= 0 && _id < 336)
		{
			ledLines[(int)_line] = createLine(_id);
			if (ledLines[(int)_line] != null)
			{
				ledLines[(int)_line].start(_id, filename[_id], _loop);
			}
		}
	}

	public void kstart(LINE _line, int _id, bool _loop)
	{
		if (_line < LINE.MAX && _id >= 0 && _id < 336)
		{
			ledLines[(int)_line] = createLine(_id);
			if (ledLines[(int)_line] != null)
			{
				ledLines[(int)_line].kstart(_id, filename[_id], _loop);
			}
		}
	}

	public void stop(LINE _line)
	{
		if (_line >= LINE.LAYER_1M && _line < LINE.MAX && ledLines[(int)_line] != null)
		{
			ledLines[(int)_line].stop();
			ledLines[(int)_line] = null;
		}
	}

	public void stop()
	{
		for (int i = 0; i < 9; i++)
		{
			stop((LINE)i);
		}
	}

	private void blendLines()
	{
		Array.Clear(blendData, 0, 178);
		for (int i = 0; i < 9; i++)
		{
			if (ledLines[i] != null)
			{
				ledLines[i].blendRewrite(blendData);
			}
		}
	}

	public void control()
	{
		for (int i = 0; i < 9; i++)
		{
			if (ledLines[i] != null)
			{
				ledLines[i].control();
			}
		}
		blendLines();
		m_Reel.control();
		m_APush.control();
		m_Panel.control();
		m_Push.control();
		m_Lever.control();
	}
}
