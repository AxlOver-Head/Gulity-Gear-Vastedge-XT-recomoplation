public class DirectionManager
{
	public enum DIR
	{
		LEVER = 0,
		REEL = 1,
		STOP1 = 2,
		STOP2 = 3,
		STOP3 = 4,
		STOP3OFF = 5,
		BET = 6,
		LEVER_2 = 7,
		REEL_2 = 8,
		STOP1_2 = 9,
		STOP2_2 = 10,
		STOP3_2 = 11,
		STOP3OFF_2 = 12,
		BET_2 = 13,
		STAGE = 14,
		PUSH = 15,
		HAIKEIPROD = 16,
		STAGEPROD = 17,
		YUUGISND = 18,
		YFC_CHAIN_1 = 19,
		YFC_CHAIN_2 = 20,
		YFC_CHAIN_3 = 21,
		YTK_YAKUTAN = 22,
		LED_MAIN = 23,
		DEMO = 24,
		MAX = 25
	}

	public enum IMAGE
	{
		dummy = 0,
		kmp_worldmap = 1,
		kmp_mok_s_aki = 2,
		kmp_mok_s_sin = 3,
		kmp_mok_s_mon = 4,
		kmp_mok_s_kis = 5,
		kmp_mok_s_gur = 6,
		kmp_mok_s_bd = 7,
		kmp_mok_s_bns = 8,
		kmp_mok_s_hoh = 9,
		kmp_mok_s_cau = 10,
		kmp_mok_l_aki = 11,
		kmp_mok_l_sin = 12,
		kmp_mok_l_mon = 13,
		kmp_mok_l_kis = 14,
		kmp_mok_l_gur = 15,
		kmp_mok_l_bd = 16,
		kmp_mok_l_bns = 17,
		kmp_mok_l_hoh = 18,
		kmp_mok_l_cau = 19,
		kmp_bg_n = 20,
		kmp_bg_r = 21,
		mst001_far = 22,
		mst001_sol_a_nml = 23,
		kpr001_a01 = 24,
		kpr001_a01_batu_lp = 25,
		kpr001_a01_bd_lp = 26,
		kpr001_a01_bikk_lp = 27,
		kpr001_a01_bonus_lp = 28,
		kpr001_a01_cation_lp = 29,
		kpr001_a01_cat_lp = 30,
		kpr001_a01_chance_lp = 31,
		kpr001_a01_hoh_lp = 32,
		kpr001_a01_jg_lp = 33,
		kpr001_a01_push_lp = 34,
		kpr003_light = 35,
		bao4210_num_0 = 36,
		bao4210_num_1 = 37,
		bao4210_num_2 = 38,
		bao4210_num_3_00007 = 39,
		bao4210_num_4_00007 = 40,
		bao4210_num_5_00007 = 41,
		bao4210_num_6_00007 = 42,
		bao4210_num_7_00007 = 43,
		bao4210_num_8_00007 = 44,
		bao4210_num_9_00007 = 45,
		anv000_bg = 46,
		cst6001_b_c_a01 = 47
	}

	public enum MOVIE
	{
		ksh001_ano = 0,
		ksh001_ano_loop = 1,
		ksh002_bri = 2,
		ksh002_bri_loop = 3,
		ksh003_chp = 4,
		ksh003_chp_loop = 5,
		ksh004_kai = 6,
		ksh004_kai_loop = 7,
		ksh005_mil = 8,
		ksh005_mil_loop = 9,
		ksh006_sly = 10,
		ksh006_sly_loop = 11,
		ksh007_zap = 12,
		ksh007_zap_loop = 13,
		ksh008_z13 = 14,
		ksh008_z13_loop = 15,
		mjm004 = 16,
		mjm004_loop = 17,
		mjm001b = 18,
		mjm006 = 19,
		mjm007 = 20,
		mjm001_r_blue_l_blue = 21,
		mjm001_r_blue_l_blue_loop = 22,
		mjm001_r_blue_l_green = 23,
		mjm001_r_blue_l_green_loop = 24,
		mjm001_r_blue_l_purple = 25,
		mjm001_r_blue_l_purple_loop = 26,
		mjm001_r_blue_l_rainbow = 27,
		mjm001_r_blue_l_rainbow_loop = 28,
		mjm001_r_blue_l_red = 29,
		mjm001_r_blue_l_red_loop = 30,
		mjm001_r_blue_l_white = 31,
		mjm001_r_blue_l_white_loop = 32,
		mjm001_r_blue_l_yellow = 33,
		mjm001_r_blue_l_yellow_loop = 34,
		mjm001_r_green_l_blue = 35,
		mjm001_r_green_l_blue_loop = 36,
		mjm001_r_green_l_green = 37,
		mjm001_r_green_l_green_loop = 38,
		mjm001_r_green_l_purple = 39,
		mjm001_r_green_l_purple_loop = 40,
		mjm001_r_green_l_rainbow = 41,
		mjm001_r_green_l_rainbow_loop = 42,
		mjm001_r_green_l_red = 43,
		mjm001_r_green_l_red_loop = 44,
		mjm001_r_green_l_white = 45,
		mjm001_r_green_l_white_loop = 46,
		mjm001_r_green_l_yellow = 47,
		mjm001_r_green_l_yellow_loop = 48,
		mjm001_r_purple_l_blue = 49,
		mjm001_r_purple_l_blue_loop = 50,
		mjm001_r_purple_l_green = 51,
		mjm001_r_purple_l_green_loop = 52,
		mjm001_r_purple_l_purple = 53,
		mjm001_r_purple_l_purple_loop = 54,
		mjm001_r_purple_l_rainbow = 55,
		mjm001_r_purple_l_rainbow_loop = 56,
		mjm001_r_purple_l_red = 57,
		mjm001_r_purple_l_red_loop = 58,
		mjm001_r_purple_l_white = 59,
		mjm001_r_purple_l_white_loop = 60,
		mjm001_r_purple_l_yellow = 61,
		mjm001_r_purple_l_yellow_loop = 62,
		mjm001_r_rainbow_l_blue = 63,
		mjm001_r_rainbow_l_blue_loop = 64,
		mjm001_r_rainbow_l_green = 65,
		mjm001_r_rainbow_l_green_loop = 66,
		mjm001_r_rainbow_l_purple = 67,
		mjm001_r_rainbow_l_purple_loop = 68,
		mjm001_r_rainbow_l_rainbow = 69,
		mjm001_r_rainbow_l_rainbow_loop = 70,
		mjm001_r_rainbow_l_red = 71,
		mjm001_r_rainbow_l_red_loop = 72,
		mjm001_r_rainbow_l_white = 73,
		mjm001_r_rainbow_l_white_loop = 74,
		mjm001_r_rainbow_l_yellow = 75,
		mjm001_r_rainbow_l_yellow_loop = 76,
		mjm001_r_red_l_blue = 77,
		mjm001_r_red_l_blue_loop = 78,
		mjm001_r_red_l_green = 79,
		mjm001_r_red_l_green_loop = 80,
		mjm001_r_red_l_purple = 81,
		mjm001_r_red_l_purple_loop = 82,
		mjm001_r_red_l_rainbow = 83,
		mjm001_r_red_l_rainbow_loop = 84,
		mjm001_r_red_l_red = 85,
		mjm001_r_red_l_red_loop = 86,
		mjm001_r_red_l_white = 87,
		mjm001_r_red_l_white_loop = 88,
		mjm001_r_red_l_yellow = 89,
		mjm001_r_red_l_yellow_loop = 90,
		mjm001_r_white_l_blue = 91,
		mjm001_r_white_l_blue_loop = 92,
		mjm001_r_white_l_green = 93,
		mjm001_r_white_l_green_loop = 94,
		mjm001_r_white_l_purple = 95,
		mjm001_r_white_l_purple_loop = 96,
		mjm001_r_white_l_rainbow = 97,
		mjm001_r_white_l_rainbow_loop = 98,
		mjm001_r_white_l_red = 99,
		mjm001_r_white_l_red_loop = 100,
		mjm001_r_white_l_white = 101,
		mjm001_r_white_l_white_loop = 102,
		mjm001_r_white_l_yellow = 103,
		mjm001_r_white_l_yellow_loop = 104,
		mjm001_r_yellow_l_blue = 105,
		mjm001_r_yellow_l_blue_loop = 106,
		mjm001_r_yellow_l_green = 107,
		mjm001_r_yellow_l_green_loop = 108,
		mjm001_r_yellow_l_purple = 109,
		mjm001_r_yellow_l_purple_loop = 110,
		mjm001_r_yellow_l_rainbow = 111,
		mjm001_r_yellow_l_rainbow_loop = 112,
		mjm001_r_yellow_l_red = 113,
		mjm001_r_yellow_l_red_loop = 114,
		mjm001_r_yellow_l_white = 115,
		mjm001_r_yellow_l_white_loop = 116,
		mjm001_r_yellow_l_yellow = 117,
		mjm001_r_yellow_l_yellow_loop = 118,
		mjm003_l_blue_fix = 119,
		mjm003_l_blue_fix_loop = 120,
		mjm003_l_blue_neko = 121,
		mjm003_l_blue_neko_loop = 122,
		mjm003_l_green_fix = 123,
		mjm003_l_green_fix_loop = 124,
		mjm003_l_green_neko = 125,
		mjm003_l_green_neko_loop = 126,
		mjm003_l_purple_fix = 127,
		mjm003_l_purple_fix_loop = 128,
		mjm003_l_purple_neko = 129,
		mjm003_l_purple_neko_loop = 130,
		mjm003_l_rainbow_fix = 131,
		mjm003_l_rainbow_fix_loop = 132,
		mjm003_l_rainbow_neko = 133,
		mjm003_l_rainbow_neko_loop = 134,
		mjm003_l_red_fix = 135,
		mjm003_l_red_fix_loop = 136,
		mjm003_l_red_neko = 137,
		mjm003_l_red_neko_loop = 138,
		mjm003_l_white_fix = 139,
		mjm003_l_white_fix_loop = 140,
		mjm003_l_white_neko = 141,
		mjm003_l_white_neko_loop = 142,
		mjm003_l_yellow_fix = 143,
		mjm003_l_yellow_fix_loop = 144,
		mjm003_l_yellow_neko = 145,
		mjm003_l_yellow_neko_loop = 146,
		mjm003_r_blue_fix = 147,
		mjm003_r_blue_fix_loop = 148,
		mjm003_r_green_fix = 149,
		mjm003_r_green_fix_loop = 150,
		mjm003_r_purple_fix = 151,
		mjm003_r_purple_fix_loop = 152,
		mjm003_r_rainbow_fix = 153,
		mjm003_r_rainbow_fix_loop = 154,
		mjm003_r_red_fix = 155,
		mjm003_r_red_fix_loop = 156,
		mjm004_r_white_fix = 157,
		mjm003_r_white_fix_loop = 158,
		mjm003_r_yellow_fix = 159,
		mjm003_r_yellow_fix_loop = 160,
		mgo001 = 161,
		mgo001_st = 162,
		mgo002_blue = 163,
		mgo002_blue_loop = 164,
		mgo002_green = 165,
		mgo002_green_loop = 166,
		mgo002_red = 167,
		mgo002_red_loop = 168,
		mgo003 = 169,
		mgo003_blue = 170,
		mgo003_blue_loop = 171,
		mgo003_green = 172,
		mgo003_green_loop = 173,
		mgo003_red = 174,
		mgo003_red_loop = 175,
		mgo004 = 176,
		mgo005 = 177,
		mgo005_add = 178,
		mgo006 = 179,
		mgo006_add = 180,
		mgo006_loop = 181,
		mgo004_blue = 182,
		mgo004_green = 183,
		mgo004_red = 184,
		mgo004_add = 185,
		mgo008 = 186,
		mgo008_loop = 187,
		mgo009 = 188,
		mgo009_loop = 189,
		mgo0010 = 190,
		mgo0010_loop = 191,
		mst001_far = 192,
		mst001_sin_a = 193,
		mst001_mkira = 194,
		mst001_sol_a = 195,
		mst001_sol_a_nml = 196,
		mst001_sol_a_nml2 = 197,
		kkz001 = 198,
		kkz001_loop = 199,
		kkz002_n = 200,
		kkz002_n_loop = 201,
		kkz002_j = 202,
		kkz002_j_loop = 203,
		kkz003_1 = 204,
		kkz003_2_bd = 205,
		kkz003_2_bd_loop = 206,
		kkz003_2_bns = 207,
		kkz003_2_bns_loop = 208,
		kkz003_2_brd = 209,
		kkz003_2_brd_loop = 210,
		kkz003_2_cau = 211,
		kkz003_2_cau_loop = 212,
		kkz003_2_cha = 213,
		kkz003_2_cha_loop = 214,
		kkz003_2_chi = 215,
		kkz003_2_chi_loop = 216,
		kkz003_2_man = 217,
		kkz003_2_man_loop = 218,
		kkz003_2_hoh = 219,
		kkz003_2_hoh_loop = 220,
		kkz003_2_mil = 221,
		kkz003_2_mil_loop = 222,
		kkz003_2_sin = 223,
		kkz003_2_sin_loop = 224,
		kkz003_2_hen = 225,
		kkz003_2_hen_loop = 226,
		kkz003_2_sla = 227,
		kkz003_2_sla_loop = 228,
		kkz003_2_zap = 229,
		kkz003_2_zap_loop = 230,
		cst001_defe = 231,
		ckh001_g = 232,
		ckh001_g_loop = 233,
		ckh001_r = 234,
		ckh002_a_nml = 235,
		ckh002_a_nml2 = 236,
		ckh002_a_loop_nml2 = 237,
		ckh002_b = 238,
		ckh002_b_loop = 239,
		ckh002_c = 240,
		ckh002_c_loop = 241,
		ckh002_d = 242,
		ckh002_d_loop = 243,
		ckh002_e = 244,
		ckh002_e_loop = 245,
		chk003_1 = 246,
		chk003_1_a = 247,
		chk003_1_b = 248,
		chk003_1_c = 249,
		chk003_1_d = 250,
		chk003_2 = 251,
		ckh003_1_loop = 252,
		chk004_1 = 253,
		chk004_2 = 254,
		chk004_ano_2 = 255,
		chk004_ano_1_a = 256,
		chk004_kai_2 = 257,
		chk004_1ano_1_a = 258,
		chk004_1ano_1_b = 259,
		chk004_1ano_1_c = 260,
		chk004_1ano_1_d = 261,
		chk004_1ano_1_e = 262,
		hsl1001_sol1 = 263,
		hsl1001_sly1 = 264,
		hsl1001_sol2 = 265,
		hsl1001_sly2 = 266,
		hsl1001_s = 267,
		hsl1001_ss = 268,
		hsl1001_bg1 = 269,
		hsl1001_bg1_loop = 270,
		hsl1001_bg2 = 271,
		hsl1001_bg2_loop = 272,
		hsl1001_bg_sdw = 273,
		hsl1001_bg_add = 274,
		hsl1002_add = 275,
		hsl1002_kemuri = 276,
		hsl1002_sdw = 277,
		hsl1002_hai1 = 278,
		hsl1002_hai1_loop = 279,
		hsl1002_hai2 = 280,
		hsl1002_hai2_loop = 281,
		hsl1002_hai3 = 282,
		hsl1002_hai3_loop = 283,
		hsl1002_hai4 = 284,
		hsl1002_hai4_loop = 285,
		hsl1002_hai5 = 286,
		hsl1002_hai5_loop = 287,
		hsl1002_sol = 288,
		hsl1002_sol3 = 289,
		hsl1002_sol4 = 290,
		hsl1002_sol_loop = 291,
		hsl1002_sol3_loop = 292,
		hsl1002_sol4_loop = 293,
		hsl1002_sly = 294,
		hsl1002_sly3 = 295,
		hsl1002_sly4 = 296,
		hsl1002_sly_loop = 297,
		hsl1002_sly3_loop = 298,
		hsl1002_sly4_loop = 299,
		hsl1002_logo = 300,
		hsl1002_logo_add = 301,
		hsl2001_hai1 = 302,
		hsl2001_hai1_a = 303,
		hsl2001_hai1_a_loop = 304,
		hsl2001_hai1_kyo = 305,
		hsl2001_hai2 = 306,
		hsl2001_hai2_a = 307,
		hsl2001_hai2_a_loop = 308,
		hsl2001_hai2_kyo = 309,
		hsl2001_hai3 = 310,
		hsl2001_hai3_a = 311,
		hsl2001_hai3_a_loop = 312,
		hsl2001_hai3_kyo = 313,
		hsl2001_hai4 = 314,
		hsl2001_hai4_a = 315,
		hsl2001_hai4_a_loop = 316,
		hsl2001_hai4_kyo = 317,
		hsl2001_hai5 = 318,
		hsl2001_hai5_a = 319,
		hsl2001_hai5_a_loop = 320,
		hsl2001_hai5_kyo = 321,
		hsl2001_add = 322,
		hsl2001_syutyu = 323,
		hsl2001_sol = 324,
		hsl2001_sol_ya = 325,
		hsl2001_sol_sise = 326,
		hsl2001_sol1 = 327,
		hsl2001_sol1_loop = 328,
		hsl2001_sol1_ya = 329,
		hsl2001_sol1_ya_loop = 330,
		hsl2001_sol1_sise = 331,
		hsl2001_sol1_sise_loop = 332,
		hsl2001_sly = 333,
		hsl2001_sly3 = 334,
		hsl2001_sly4 = 335,
		hsl2001_sol2 = 336,
		hsl2001_sol2_ya = 337,
		hsl2001_sol2_sise = 338,
		hsl2001_sol2_loop = 339,
		hsl2002_sol1 = 340,
		hsl2002_sly1 = 341,
		hsl2002_sly2 = 342,
		hsl2002_sol2 = 343,
		hsl2002_sol2_loop = 344,
		hsl2004_sol = 345,
		hsl2004_sly = 346,
		hsl2004_sly_loop = 347,
		hsl2005_sol = 348,
		hsl2005_sly = 349,
		hsl2005_sly_loop = 350,
		hsl2007_sol_hai1 = 351,
		hsl2007_sol_hai2 = 352,
		hsl2007_sol_hai3 = 353,
		hsl2007_sol_hai4 = 354,
		hsl2007_sol_hai5 = 355,
		hsl2007_sol = 356,
		hsl2007_sly = 357,
		hsl2008_sol = 358,
		hsl2008_sol_loop = 359,
		hsl2008_sly = 360,
		hsl2009_sly = 361,
		hsl2011_sol1 = 362,
		hsl2011_sol2 = 363,
		hsl2011_sol2_loop = 364,
		hsl2011_sol3 = 365,
		hsl2011_sol4 = 366,
		hsl2011_sol4_loop = 367,
		hsl2011_sly = 368,
		hsl2012_sol = 369,
		hsl2012_sly = 370,
		hsl2012_sly_loop = 371,
		hsl2013_sol = 372,
		hsl2013_sly = 373,
		hsl2015_sol = 374,
		hsl2015_sly = 375,
		hsl2020_sol = 376,
		hsl2020_sly = 377,
		hsl2022_sol = 378,
		hsl2022_sly = 379,
		hsl2022_sly_loop = 380,
		hsl2023_sol = 381,
		hsl2023_sly = 382,
		hsl2026_sol1 = 383,
		hsl2026_sol = 384,
		hsl2026_sly = 385,
		hsl2028 = 386,
		hsl3001_hai1 = 387,
		hsl3001_hai1_loop = 388,
		hsl3001_hai2 = 389,
		hsl3001_hai2_loop = 390,
		hsl3001_hai3 = 391,
		hsl3001_hai3_loop = 392,
		hsl3001_hai4 = 393,
		hsl3001_hai4_loop = 394,
		hsl3001_hai5 = 395,
		hsl3001_hai5_loop = 396,
		hsl3001_add = 397,
		hsl3001_add_loop = 398,
		hsl3001_sly = 399,
		hsl3001_sly3 = 400,
		hsl3001_sly4 = 401,
		hsl3001_sly_loop = 402,
		hsl3001_sly3_loop = 403,
		hsl3001_sly4_loop = 404,
		hsl3001_sol = 405,
		hsl3001_sol3 = 406,
		hsl3001_sol4 = 407,
		hsl3003_sly = 408,
		hsl3003_sly_loop = 409,
		hsl3003_sol = 410,
		hsl3004_sly = 411,
		hsl3004_sly_loop = 412,
		hsl3004_sol = 413,
		hsl3005_sly = 414,
		hsl3005_sly_loop = 415,
		hsl3005_sol = 416,
		hsl3006_sly = 417,
		hsl3006_sol = 418,
		hsl3008_sly = 419,
		hsl3008_sol = 420,
		hsl3011_sly1 = 421,
		hsl3011_sly1_loop = 422,
		hsl3011_sly2 = 423,
		hsl3011_sol = 424,
		hsl3014_sol = 425,
		hsl3014_sly = 426,
		hsl3014_sly_loop = 427,
		hsl3018_sly1 = 428,
		hsl3018_sly2 = 429,
		hsl3018_sly3 = 430,
		hsl3018_sly4 = 431,
		hsl3018_sly5 = 432,
		hsl4001_sol = 433,
		hsl4001_sol_loop = 434,
		hsl4005 = 435,
		hsl4005_loop = 436,
		hsl5001_hai1 = 437,
		hsl5001_hai2 = 438,
		hsl5001_hai3 = 439,
		hsl5001_hai4 = 440,
		hsl5001_hai5 = 441,
		hsl5001_sol = 442,
		hsl5001_sol3 = 443,
		hsl5001_sol4 = 444,
		hsl5002_hai1 = 445,
		hsl5002_hai2 = 446,
		hsl5002_hai3 = 447,
		hsl5002_hai4 = 448,
		hsl5002_hai5 = 449,
		hsl5002_sol = 450,
		hsl5002_sol3 = 451,
		hsl5002_sol4 = 452,
		hsl5003_hai1 = 453,
		hsl5003_hai1_loop = 454,
		hsl5003_hai2 = 455,
		hsl5003_hai2_loop = 456,
		hsl5003_hai3 = 457,
		hsl5003_hai3_loop = 458,
		hsl5003_hai4 = 459,
		hsl5003_hai4_loop = 460,
		hsl5003_hai5 = 461,
		hsl5003_hai5_loop = 462,
		hsl5003_sol = 463,
		hsl5003_sol_loop = 464,
		hsl5003_sol3 = 465,
		hsl5003_sol3_loop = 466,
		hsl5003_sol4 = 467,
		hsl5003_sol4_loop = 468,
		hsl5004_hai1 = 469,
		hsl5004_hai2 = 470,
		hsl5004_hai3 = 471,
		hsl5004_hai4 = 472,
		hsl5004_hai5 = 473,
		hsl5005_hai1 = 474,
		hsl5005_hai2 = 475,
		hsl5005_hai3 = 476,
		hsl5005_hai4 = 477,
		hsl5005_hai5 = 478,
		hsl5006_hai1 = 479,
		hsl5006_hai2 = 480,
		hsl5006_hai3 = 481,
		hsl5006_hai4 = 482,
		hsl5006_hai5 = 483,
		hsl5004_sol = 484,
		hsl5004_sol3 = 485,
		hsl5004_sol4 = 486,
		hsl5004_sly = 487,
		hsl5004_sly3 = 488,
		hsl5004_sly4 = 489,
		hsl5007_add = 490,
		hsl5007_sly1 = 491,
		hsl5007_sly2 = 492,
		hsl5007_sly3 = 493,
		hsl5007_sly4 = 494,
		hsl5007_sly5 = 495,
		hsl5008_add = 496,
		hsl5009_add = 497,
		hsl5009_sly1 = 498,
		hsl5009_sly2 = 499,
		hsl5009_sly3 = 500,
		hsl5009_sly4 = 501,
		hsl5009_sly5 = 502,
		hsl5009_sol = 503,
		hsl5009_sol3 = 504,
		hsl5009_sol4 = 505,
		hsl5010_add = 506,
		hsl5010_add2 = 507,
		hsl5010_hai1 = 508,
		hsl5010_hai2 = 509,
		hsl5010_hai3 = 510,
		hsl5010_hai4 = 511,
		hsl5010_hai5 = 512,
		hsl5010_sol = 513,
		hsl5010_sol3 = 514,
		hsl5010_sol4 = 515,
		hsl5011_sol = 516,
		hsl5011_sol3 = 517,
		hsl5011_sol4 = 518,
		hsl5010_sly = 519,
		hsl5010_sly3 = 520,
		hsl5010_sly4 = 521,
		hsl5013_hai1 = 522,
		hsl5013_hai2 = 523,
		hsl5013_hai3 = 524,
		hsl5013_hai4 = 525,
		hsl5013_hai5 = 526,
		hsl5013_sol = 527,
		hsl5013_sol3 = 528,
		hsl5013_sol4 = 529,
		hsl5013_sly = 530,
		hsl5013_sly3 = 531,
		hsl5013_sly4 = 532,
		hsl600_cle = 533,
		hsl600_cle_add = 534,
		hsl600_des = 535,
		hsl600_des_add = 536,
		hsl600_per = 537,
		hsl600_per_add = 538,
		hsl600_sla = 539,
		hsl600_sla_add = 540,
		hsl5005_sly = 541,
		hsl5005_sly3 = 542,
		hsl5005_sly4 = 543,
		hsl5006_sly = 544,
		hsl5006_sly3 = 545,
		hsl5006_sly4 = 546,
		hsl2025_sol = 547,
		hsl2025_sol_loop = 548,
		igo001 = 549,
		igo001_loop = 550,
		ihh001 = 551,
		ihh001_loop = 552,
		mhk001_mob_white = 553,
		mhk001_mob_blue = 554,
		mhk001_mob_yellow = 555,
		mhk001_mob_green = 556,
		mhk001_mob_red = 557,
		mhk001_mob_purple = 558,
		mhk001_mob_rainbow = 559,
		mhk001_sol_c = 560,
		mhk001_sol_d = 561,
		mhk001_sin_e = 562,
		mhk001_sin_d = 563,
		mhk001_sin_c = 564,
		mhk001_sol_e = 565,
		mhk001_sol_e_gun = 566,
		mhk001_sol_f = 567,
		mhk001_sol_f_gun = 568,
		mhk001_dai = 569,
		mth_001_a = 570,
		mth_001_b = 571,
		mth_002_a_white = 572,
		mth_002_a_blue = 573,
		mth_002_a_yellow = 574,
		mth_002_a_green = 575,
		mth_002_a_red = 576,
		mth_002_a_purple = 577,
		mth_002_a_rainbow = 578,
		mth_002_a_cat = 579,
		mth_002_b_white = 580,
		mth_002_b_blue = 581,
		mth_002_b_yellow = 582,
		mth_002_b_green = 583,
		mth_002_b_red = 584,
		mth_002_b_purple = 585,
		mth_002_b_rainbow = 586,
		mth_003 = 587,
		mth_003_loop = 588,
		mth_004_a = 589,
		mth_004_b = 590,
		mth_004_a_white = 591,
		mth_004_a_blue = 592,
		mth_004_a_yellow = 593,
		mth_004_a_green = 594,
		mth_004_a_red = 595,
		mth_004_a_purple = 596,
		mth_004_a_rainbow = 597,
		mth_004_a_cat = 598,
		mth_004_b_white = 599,
		mth_004_b_blue = 600,
		mth_004_b_yellow = 601,
		mth_004_b_green = 602,
		mth_004_b_red = 603,
		mth_004_b_purple = 604,
		mth_004_b_rainbow = 605,
		cmb001 = 606,
		cmb001_loop = 607,
		cmb001_st = 608,
		cmb002 = 609,
		cmb002_loop = 610,
		cmb003 = 611,
		cmb003_loop = 612,
		cmb004 = 613,
		cmb004_loop = 614,
		cmb005 = 615,
		cmb005_loop = 616,
		cmb006 = 617,
		cmb006_loop = 618,
		cmb007 = 619,
		cmb007_loop = 620,
		cmb008 = 621,
		cmb009 = 622,
		cmb010 = 623,
		cmb010_loop = 624,
		cmb011 = 625,
		cmb011_loop = 626,
		cmb012 = 627,
		cmb012_loop = 628,
		cmb013 = 629,
		cmb013_loop = 630,
		kpr004_a = 631,
		kpr004_a_loop = 632,
		kpr004_b = 633,
		kpr004_b_loop = 634,
		kpr004_chance = 635,
		kpr004_chance_loop = 636,
		kpr004_cation = 637,
		kpr004_cation_loop = 638,
		kpr004_hoh = 639,
		kpr004_hoh_loop = 640,
		kpr004_cat = 641,
		kpr004_cat_loop = 642,
		kpr004_push = 643,
		kpr004_push_loop = 644,
		kpr004_bd = 645,
		kpr004_bd_loop = 646,
		kpr004_bonus = 647,
		kpr004_bonus_loop = 648,
		kpr004_a_bony = 649,
		kpr004_a_bony_loop = 650,
		kpr004_b_bony = 651,
		kpr004_b_bony_loop = 652,
		kpr004_chance_bony = 653,
		kpr004_chance_bony_loop = 654,
		kpr004_cation_bony = 655,
		kpr004_cation_bony_loop = 656,
		kpr004_hoh_bony = 657,
		kpr004_hoh_bony_loop = 658,
		kpr004_cat_bony = 659,
		kpr004_cat_bony_loop = 660,
		kpr004_push_bony = 661,
		kpr004_push_bony_loop = 662,
		kpr004_bd_bony = 663,
		kpr004_bd_bony_loop = 664,
		kpr004_bonus_bony = 665,
		kpr004_bonus_bony_loop = 666,
		kpr001_a01_bon = 667,
		kpr001_a01_batu_add4 = 668,
		kpr002_batu = 669,
		kpr002_bikk = 670,
		kpr002_chance = 671,
		kpr002_cation = 672,
		kpr002_hoh = 673,
		kpr002_cat = 674,
		kpr002_push = 675,
		kpr002_bd = 676,
		kpr002_bonus = 677,
		kpr002_light = 678,
		kpr002_light_para = 679,
		kpr003_crystal = 680,
		kpr004_light = 681,
		kpr001_a01_backlight = 682,
		kpr001_a01_par_lp = 683,
		kpr001_a01_par_lp_add = 684,
		kpr001_a01_batu_lp_add = 685,
		kpr001_a01_batu_lp = 686,
		kpr001_a01_bikk_lp = 687,
		kpr001_a01_chance_lp = 688,
		kpr001_a01_cation_lp = 689,
		kpr001_a01_hoh_lp = 690,
		kpr001_a01_cat_lp = 691,
		kpr001_a01_push_lp = 692,
		kpr001_a01_bd_lp = 693,
		kpr001_a01_bonus_lp = 694,
		kpr001_a01_jg_lp = 695,
		kpr001_a01 = 696,
		kpr002_jg = 697,
		kpr004_jg = 698,
		kpr004_jg_loop = 699,
		kpr004_jg_bony = 700,
		kpr004_jg_bony_loop = 701,
		kpr003_light = 702,
		kmp_sol_start = 703,
		kmp_sol_l = 704,
		kmp_sol_l_f = 705,
		kmp_sol_l_s = 706,
		kmp_sol_r = 707,
		kmp_sol_r_f = 708,
		kmp_sol_r_s = 709,
		kmp_cat_start = 710,
		kmp_cat_stop = 711,
		kmp_cat_f = 712,
		kmp_start_n = 713,
		kmp_start_r = 714,
		kmp_worldmap = 715,
		kmp_mok_s_aki = 716,
		kmp_mok_s_sin = 717,
		kmp_mok_s_mon = 718,
		kmp_mok_s_kis = 719,
		kmp_mok_s_gur = 720,
		kmp_mok_s_bd = 721,
		kmp_mok_s_bns = 722,
		kmp_mok_s_hoh = 723,
		kmp_mok_s_cau = 724,
		kmp_mok_l_aki = 725,
		kmp_mok_l_sin = 726,
		kmp_mok_l_mon = 727,
		kmp_mok_l_kis = 728,
		kmp_mok_l_gur = 729,
		kmp_mok_l_bd = 730,
		kmp_mok_l_bns = 731,
		kmp_mok_l_hoh = 732,
		kmp_mok_l_cau = 733,
		kmp_bg_n = 734,
		kmp_bg_r = 735,
		kmp_deside_sin = 736,
		kmp_deside_mon = 737,
		kmp_deside_kis = 738,
		kmp_deside_gur = 739,
		kmp_deside_bd = 740,
		kmp_deside_bns = 741,
		kmp_deside_hoh = 742,
		kmp_deside_cau = 743,
		kmp_deside_2 = 744,
		kgr001 = 745,
		kgr001_loop = 746,
		kgr002_1 = 747,
		kgr002_1_loop = 748,
		kgr002_2 = 749,
		kgr002_2_loop = 750,
		kgr002_3 = 751,
		kgr002_3_loop = 752,
		kgr003 = 753,
		kgr003_loop = 754,
		kgr004 = 755,
		kgr004_loop = 756,
		kgr005 = 757,
		kgr006 = 758,
		kgr006_loop = 759,
		kbs001_1 = 760,
		kbs001_1_loop = 761,
		kbs001_2 = 762,
		kbs001_2_loop = 763,
		kbs002_1 = 764,
		kbs002_2 = 765,
		kbs002_3 = 766,
		kbs002_4 = 767,
		kbs003_sly = 768,
		kbs003_sly_loop = 769,
		kbs003_chi = 770,
		kbs003_chi_loop = 771,
		kbs003_mil = 772,
		kbs003_mil_loop = 773,
		kbs003_bri = 774,
		kbs003_bri_loop = 775,
		kbs003_zap = 776,
		kbs003_zap_loop = 777,
		kbs004_1 = 778,
		kbs004_2 = 779,
		kbs004_3 = 780,
		kbs004_4 = 781,
		kbs005_haikei = 782,
		kbs005_haikei_loop = 783,
		kbs001_3 = 784,
		kbs001_3_loop = 785,
		kbs006_2 = 786,
		kbs006_4 = 787,
		kbs001_4 = 788,
		kbs001_4_loop = 789,
		kbs007_2 = 790,
		kbs007_4 = 791,
		kbs001_5 = 792,
		kbs001_5_loop = 793,
		kbs008_4 = 794,
		kci001 = 795,
		kci002 = 796,
		kci003 = 797,
		kci004_a = 798,
		kci004_b = 799,
		kci004_c = 800,
		kci004_d = 801,
		kci004_e = 802,
		kci004_f = 803,
		kci005_a = 804,
		kci005_b = 805,
		kci005_b_loop = 806,
		kci005_c = 807,
		kci005_c_loop = 808,
		kci005_d = 809,
		kci005_d_loop = 810,
		kci005_e = 811,
		kci005_e_loop = 812,
		kci005_f = 813,
		kci005_f_loop = 814,
		jst001 = 815,
		jhs001 = 816,
		jhs001_loop = 817,
		jhs002 = 818,
		jhs002_loop = 819,
		jhs003 = 820,
		jhs003_loop = 821,
		jhs004 = 822,
		jhs004_loop = 823,
		jhs005 = 824,
		jhs005_loop = 825,
		jhs006 = 826,
		jhs006_loop = 827,
		jhs007 = 828,
		jhs007_loop = 829,
		jhs008 = 830,
		jhs008_loop = 831,
		jhs009 = 832,
		jhs009_loop = 833,
		jhs010 = 834,
		jhs010_loop = 835,
		jhs011 = 836,
		jhs011_loop = 837,
		jhs012 = 838,
		jhs012_loop = 839,
		jhs013 = 840,
		jhs013_loop = 841,
		jhs014_1 = 842,
		jhs014_1_loop = 843,
		jhs014_1_ano = 844,
		jhk001_a_white = 845,
		jhk001_a_white_loop = 846,
		jhk001_a_blue = 847,
		jhk001_a_blue_loop = 848,
		jhk001_a_yellow = 849,
		jhk001_a_yellow_loop = 850,
		jhk001_a_green = 851,
		jhk001_a_green_loop = 852,
		jhk001_a_red = 853,
		jhk001_a_red_loop = 854,
		jhk001_a_purple = 855,
		jhk001_a_purple_loop = 856,
		jhk001_a_tento = 857,
		jhk001_a_tento_loop = 858,
		jhk001_a_rainbow = 859,
		jhk001_a_rainbow_loop = 860,
		jhk001_b_white = 861,
		jhk001_b_white_loop = 862,
		jhk001_b_blue = 863,
		jhk001_b_blue_loop = 864,
		jhk001_b_yellow = 865,
		jhk001_b_yellow_loop = 866,
		jhk001_b_green = 867,
		jhk001_b_green_loop = 868,
		jhk001_b_red = 869,
		jhk001_b_red_loop = 870,
		jhk001_b_purple = 871,
		jhk001_b_purple_loop = 872,
		jhk001_b_tento = 873,
		jhk001_b_tento_loop = 874,
		jhk001_b_rainbow = 875,
		jhk001_b_rainbow_loop = 876,
		jhk002_a_white = 877,
		jhk002_a_white_loop = 878,
		jhk002_a_blue = 879,
		jhk002_a_blue_loop = 880,
		jhk002_a_yellow = 881,
		jhk002_a_yellow_loop = 882,
		jhk002_a_green = 883,
		jhk002_a_green_loop = 884,
		jhk002_a_red = 885,
		jhk002_a_red_loop = 886,
		jhk002_a_purple = 887,
		jhk002_a_purple_loop = 888,
		jhk002_a_tento = 889,
		jhk002_a_tento_loop = 890,
		jhk002_a_rainbow = 891,
		jhk002_a_rainbow_loop = 892,
		jhk002_b_white = 893,
		jhk002_b_white_loop = 894,
		jhk002_b_blue = 895,
		jhk002_b_blue_loop = 896,
		jhk002_b_yellow = 897,
		jhk002_b_yellow_loop = 898,
		jhk002_b_green = 899,
		jhk002_b_green_loop = 900,
		jhk002_b_red = 901,
		jhk002_b_red_loop = 902,
		jhk002_b_purple = 903,
		jhk002_b_purple_loop = 904,
		jhk002_b_tento = 905,
		jhk002_b_tento_loop = 906,
		jhk002_b_rainbow = 907,
		jhk002_b_rainbow_loop = 908,
		jhk003 = 909,
		jka001 = 910,
		jka001_loop = 911,
		jka002_a = 912,
		jka002_a_loop = 913,
		jka002_b = 914,
		jka002_b_loop = 915,
		jka003 = 916,
		jka003_loop = 917,
		jkb001 = 918,
		jkb001_loop = 919,
		jkb002 = 920,
		jkb002_loop = 921,
		jkb003 = 922,
		jkb004 = 923,
		jkb004_loop = 924,
		jkb005 = 925,
		jkb005_loop = 926,
		ast001 = 927,
		anv001_a01_c3_yellow = 928,
		anv001_a01_c3_yellow_loop = 929,
		anv001_a01_c3_yellow_add = 930,
		anv001_a01_c3_blue = 931,
		anv001_a01_c3_blue_loop = 932,
		anv001_a01_c3_white = 933,
		anv001_a01_c3_white_loop = 934,
		anv001_b02_c3_yellow = 935,
		anv001_b02_c3_yellow_loop = 936,
		anv001_b02_c3_yellow_add = 937,
		anv001_b02_c3_blue = 938,
		anv001_b02_c3_blue_loop = 939,
		anv001_b02_c3_white = 940,
		anv001_b02_c3_white_loop = 941,
		anv001_c03_c3_yellow = 942,
		anv001_c03_c3_yellow_add = 943,
		anv001_c03_c3_blue = 944,
		anv001_c03_c3_white = 945,
		anv002_a01_c3_yellow_nml = 946,
		anv002_a01_c3_yellow_add1 = 947,
		anv002_a01_c3_yellow_add2 = 948,
		anv002_a01_c3_yellow_nml2 = 949,
		anv002_a01_c3_blue = 950,
		anv002_a01_c3_white = 951,
		anv003_b02_c3_yellow_nml = 952,
		anv003_b02_c3_yellow_add = 953,
		anv003_b02_c3_yellow_nml2 = 954,
		anv003_b02_c3_blue = 955,
		anv003_b02_c3_white = 956,
		anv004_c03_c3_yellow_nml = 957,
		anv004_c03_c3_yellow_add = 958,
		anv004_c03_c3_yellow_nml2 = 959,
		anv004_c03_c3_blue = 960,
		anv004_c03_c3_white = 961,
		anv000_bg = 962,
		anv005 = 963,
		anv0010 = 964,
		anv0011 = 965,
		anv022 = 966,
		anv022_loop = 967,
		anv023 = 968,
		anv023_add = 969,
		anv024 = 970,
		anv024_add = 971,
		anv025 = 972,
		anv026 = 973,
		anv026_add = 974,
		anv027_char = 975,
		anv027_ano = 976,
		anv000_bgf = 977,
		ath001a_white_nml = 978,
		ath001a_white_loop_nml = 979,
		ath001a_white_nml2 = 980,
		ath001a_white_nml3 = 981,
		ath001a_white_add = 982,
		ath001a_blue = 983,
		ath001a_blue_loop = 984,
		ath001a_yellow = 985,
		ath001a_yellow_loop = 986,
		ath001a_green = 987,
		ath001a_green_loop = 988,
		ath001a_red = 989,
		ath001a_red_loop = 990,
		ath001a_purple = 991,
		ath001a_purple_loop = 992,
		ath001a_tento = 993,
		ath001a_tento_loop = 994,
		ath001a_rainbow = 995,
		ath001a_rainbow_loop = 996,
		ath001b_white_nml = 997,
		ath001b_white_loop_nml = 998,
		ath001b_white_nml2 = 999,
		ath001b_white_nml3 = 1000,
		ath001b_blue = 1001,
		ath001b_blue_loop = 1002,
		ath001b_yellow = 1003,
		ath001b_yellow_loop = 1004,
		ath001b_green = 1005,
		ath001b_green_loop = 1006,
		ath001b_red = 1007,
		ath001b_red_loop = 1008,
		ath001b_purple = 1009,
		ath001b_purple_loop = 1010,
		ath001b_tento = 1011,
		ath001b_tento_loop = 1012,
		ath001b_rainbow = 1013,
		ath001b_rainbow_loop = 1014,
		ath002a_white_nml = 1015,
		ath002a_white_nml2 = 1016,
		ath002a_white_add = 1017,
		ath002a_blue = 1018,
		ath002a_yellow = 1019,
		ath002a_green = 1020,
		ath002a_red = 1021,
		ath002a_purple = 1022,
		ath002a_tento = 1023,
		ath002a_rainbow = 1024,
		ath002b_white_nml = 1025,
		ath002b_white_nml2 = 1026,
		ath002b_blue = 1027,
		ath002b_yellow = 1028,
		ath002b_green = 1029,
		ath002b_red = 1030,
		ath002b_purple = 1031,
		ath002b_tento = 1032,
		ath002b_rainbow = 1033,
		ath003 = 1034,
		ath003_ano = 1035,
		adr001_a = 1036,
		adr001_a_loop = 1037,
		adr001_b = 1038,
		adr001_b_loop = 1039,
		adr002_a = 1040,
		adr002_a_loop = 1041,
		adr002_b = 1042,
		adr002_b_loop = 1043,
		adr003 = 1044,
		adr003_loop = 1045,
		adr004_a = 1046,
		adr004_a_loop = 1047,
		adr004_b = 1048,
		adr004_b_loop = 1049,
		adr004_c = 1050,
		adr004_c_loop = 1051,
		adr004_add_loop = 1052,
		adr005 = 1053,
		adr006 = 1054,
		aoh001 = 1055,
		aoh001_loop = 1056,
		aoh002_a = 1057,
		aoh002_a_loop = 1058,
		aoh002_b = 1059,
		aoh002_b_loop = 1060,
		aoh003 = 1061,
		aoh003_loop = 1062,
		aoh005 = 1063,
		aoh005_loop = 1064,
		aoh004 = 1065,
		aoh004_loop = 1066,
		aoh004_ano = 1067,
		hnv001_a_1_yellow_nml = 1068,
		hnv001_a_1_yellow_add = 1069,
		hnv001_a_1_blue_nml = 1070,
		hnv001_a_1_blue_add = 1071,
		hnv001_a_1_white_nml = 1072,
		hnv001_a_1_white_add = 1073,
		hnv001_a_q_white_nml = 1074,
		hnv001_a_w_purple_nml = 1075,
		hnv001_a_w_purple_add = 1076,
		hnv001_b_1_yellow_nml = 1077,
		hnv001_b_1_yellow_add = 1078,
		hnv001_b_1_blue_nml = 1079,
		hnv001_b_1_blue_add = 1080,
		hnv001_b_1_white_nml = 1081,
		hnv001_b_1_white_add = 1082,
		hnv001_b_q_white_nml = 1083,
		hnv001_b_w_purple_nml = 1084,
		hnv001_b_w_purple_add = 1085,
		hnv001_c_1_yellow_add3 = 1086,
		hnv001_c_1_yellow_add2 = 1087,
		hnv001_c_1_yellow_nml = 1088,
		hnv001_c_1_yellow_add1 = 1089,
		hnv001_c_1_blue_add2 = 1090,
		hnv001_c_1_blue_nml = 1091,
		hnv001_c_1_blue_add1 = 1092,
		hnv001_c_1_white_add2 = 1093,
		hnv001_c_1_white_nml = 1094,
		hnv001_c_1_white_add1 = 1095,
		hnv001_c_q_white_nml = 1096,
		hnv001_c_w_purple_add2 = 1097,
		hnv001_c_w_purple_nml = 1098,
		hnv001_c_w_purple_add1 = 1099,
		hnv001_d_1_miss_yellow_nml = 1100,
		hnv001_d_1_miss_yellow_add = 1101,
		hnv001_d_1_miss_blue_nml = 1102,
		hnv001_d_1_miss_blue_add = 1103,
		hnv001_d_1_miss_white_nml = 1104,
		hnv001_d_1_miss_white_add = 1105,
		hnv001_b_2_yellow_nml = 1106,
		hnv001_b_2_blue_nml = 1107,
		hnv001_b_2_white_nml = 1108,
		hnv001_c_2_yellow_add3 = 1109,
		hnv001_c_2_yellow_nml = 1110,
		hnv001_c_2_blue_nml = 1111,
		hnv001_c_2_white_nml = 1112,
		hnv001_d_2_yellow_nml = 1113,
		hnv001_d_2_blue_nml = 1114,
		hnv001_d_2_white_nml = 1115,
		hnv002_a_2_yellow = 1116,
		hnv002_a_2_blue = 1117,
		hnv002_a_2_white = 1118,
		hnv002_d_2_yellow = 1119,
		hnv002_d_2_blue = 1120,
		hnv002_d_2_white = 1121,
		hnv001_b_3_yellow_nml = 1122,
		hnv001_b_3_blue_nml = 1123,
		hnv001_b_3_white_nml = 1124,
		hnv001_c_3_yellow_add3 = 1125,
		hnv001_c_3_yellow_nml = 1126,
		hnv001_c_3_blue_nml = 1127,
		hnv001_c_3_white_nml = 1128,
		hnv001_d_3_yellow_nml = 1129,
		hnv001_d_3_blue_nml = 1130,
		hnv001_d_3_whitenml = 1131,
		hnv002_a_3_yellow = 1132,
		hnv002_a_3_blue = 1133,
		hnv002_a_3_white = 1134,
		hnv002_d_3_yellow = 1135,
		hnv002_d_3_blue = 1136,
		hnv002_d_3_white = 1137,
		hnv003_a_1_nml = 1138,
		hnv003_a_1_add = 1139,
		hnv003_a_2_nml = 1140,
		hnv003_a_2_add = 1141,
		hnv003_a_3_nml = 1142,
		hnv003_a_3_add = 1143,
		hnv003_b_1 = 1144,
		hnv003_b_2 = 1145,
		hnv003_b_3 = 1146,
		hnv003_c_1 = 1147,
		hnv003_c_2 = 1148,
		hnv003_c_3 = 1149,
		hnv004_b_1 = 1150,
		hnv004_b_2 = 1151,
		hnv004_b_3 = 1152,
		hnv005_a_mini_1_yellow_nml = 1153,
		hnv005_a_mini_1_yellow_add = 1154,
		hnv005_a_mini_1_blue_nml = 1155,
		hnv005_a_mini_1_blue_add = 1156,
		hnv005_a_mini_1_white_nml = 1157,
		hnv005_a_mini_1_white_add = 1158,
		hnv005_b_mini_1_yellow_nml = 1159,
		hnv005_b_mini_1_yellow_add = 1160,
		hnv005_b_mini_1_blue_nml = 1161,
		hnv005_b_mini_1_blue_add = 1162,
		hnv005_b_mini_1_white_nml = 1163,
		hnv005_b_mini_1_white_add = 1164,
		hnv005_c_mini_1_yellow_add3 = 1165,
		hnv005_c_mini_1_yellow_add2 = 1166,
		hnv005_c_mini_1_yellow_nml = 1167,
		hnv005_c_mini_1_yellow_add1 = 1168,
		hnv005_c_mini_1_blue_add2 = 1169,
		hnv005_c_mini_1_blue_nml = 1170,
		hnv005_c_mini_1_blue_add1 = 1171,
		hnv005_c_mini_1_white_add2 = 1172,
		hnv005_c_mini_1_white_nml = 1173,
		hnv005_c_mini_1_white_add1 = 1174,
		hnv005_d_mini_1_yellow_nml = 1175,
		hnv005_d_mini_1_yellow_add = 1176,
		hnv005_d_mini_1_blue_nml = 1177,
		hnv005_d_mini_1_blue_add = 1178,
		hnv005_d_mini_1_white_nml = 1179,
		hnv005_d_mini_1_white_add = 1180,
		hnv005_b_mini_2_yellow_nml = 1181,
		hnv005_b_mini_2_blue_nml = 1182,
		hnv005_b_mini_2_white_nml = 1183,
		hnv005_c_mini_2_yellow_add3 = 1184,
		hnv005_c_mini_2_yellow_nml = 1185,
		hnv005_c_mini_2_blue_nml = 1186,
		hnv005_c_mini_2_white_nml = 1187,
		hnv005_d_mini_2_yellow_nml = 1188,
		hnv005_d_mini_2_blue_nml = 1189,
		hnv005_d_mini_2_white_nml = 1190,
		hnv006_a_mini_2_yellow = 1191,
		hnv006_a_mini_2_blue = 1192,
		hnv006_a_mini_2_white = 1193,
		hnv006_d_mini_2_yellow = 1194,
		hnv006_d_mini_2_blue = 1195,
		hnv006_d_mini_2_white = 1196,
		hnv005_b_mini_3_yellow_nml = 1197,
		hnv005_b_mini_3_blue_nml = 1198,
		hnv005_b_mini_3_white_nml = 1199,
		hnv005_c_mini_3_yellow_add3 = 1200,
		hnv005_c_mini_3_yellow_nml = 1201,
		hnv005_c_mini_3_blue_nml = 1202,
		hnv005_c_mini_3_white_nml = 1203,
		hnv005_d_mini_3_yellow_nml = 1204,
		hnv005_d_mini_3_blue_nml = 1205,
		hnv005_d_mini_3_white_nml = 1206,
		hnv006_a_mini_3_yellow = 1207,
		hnv006_a_mini_3_blue = 1208,
		hnv006_a_mini_3_white = 1209,
		hnv006_d_mini_3_yellow = 1210,
		hnv006_d_mini_3_blue = 1211,
		hnv006_d_mini_3_white = 1212,
		hnv002_b_2_yellow_nml = 1213,
		hnv002_b_2_yellow_add = 1214,
		hnv002_b_2_blue_nml = 1215,
		hnv002_b_2_blue_add = 1216,
		hnv002_b_2_white_nml = 1217,
		hnv002_b_2_white_add = 1218,
		hnv002_b_3_yellow_nml = 1219,
		hnv002_b_3_blue_nml = 1220,
		hnv002_b_3_white_nml = 1221,
		hnv004_a_2 = 1222,
		hnv004_a_3 = 1223,
		hnv006_b_mini_2_yellow_nml = 1224,
		hnv006_b_mini_2_yellow_add = 1225,
		hnv006_b_mini_2_blue_nml = 1226,
		hnv006_b_mini_2_blue_add = 1227,
		hnv006_b_mini_2_white_nml = 1228,
		hnv006_b_mini_2_white_add = 1229,
		hnv006_b_mini_3_yellow_nml = 1230,
		hnv006_b_mini_3_blue_nml = 1231,
		hnv006_b_mini_3_white_nml = 1232,
		hnv007_b_mini_2_yellow_nml = 1233,
		hnv007_b_mini_2_blue_nml = 1234,
		hnv007_b_mini_2_white_nml = 1235,
		hnv007_b_mini_3_yellow_nml = 1236,
		hnv007_b_mini_3_blue_nml = 1237,
		hnv007_b_mini_3_white_nml = 1238,
		hnv010_cherry = 1239,
		hnv011_cherry = 1240,
		hnv010_suika = 1241,
		hnv011_suika = 1242,
		hnv010_bel = 1243,
		hnv011_bel = 1244,
		hnv010_replay = 1245,
		hnv011_replay = 1246,
		hnv010_blank = 1247,
		hnv011_blank = 1248,
		hnv010_chance = 1249,
		hnv011_chance = 1250,
		hnv012_red7_left = 1251,
		hnv012_red7_left_loop = 1252,
		hnv012_red7_left_add = 1253,
		hnv012_bar_left = 1254,
		hnv012_bar_left_loop = 1255,
		hnv012_bar_left_add = 1256,
		hnv012_red7_right = 1257,
		hnv012_red7_right_loop = 1258,
		hnv012_red7_right_add = 1259,
		hnv012_bar_right = 1260,
		hnv012_bar_right_loop = 1261,
		hnv012_bar_right_add = 1262,
		hnv013 = 1263,
		hnv013_add = 1264,
		hnv014 = 1265,
		bi1001 = 1266,
		bi1001_loop = 1267,
		bi1002 = 1268,
		bi1002_loop = 1269,
		bi1003 = 1270,
		bi1003_loop = 1271,
		bi1004 = 1272,
		bi1004_loop = 1273,
		bi1005 = 1274,
		bi1005_loop = 1275,
		bao1000 = 1276,
		bao1000_loop = 1277,
		bao2100 = 1278,
		bao2100_loop = 1279,
		bao2110 = 1280,
		bao2110_loop = 1281,
		bao2111 = 1282,
		bao2112 = 1283,
		bao2112_loop = 1284,
		bao2121 = 1285,
		bao2200 = 1286,
		bao2200_loop = 1287,
		bao2210 = 1288,
		bao2210_loop = 1289,
		bao2211 = 1290,
		bao2211_loop = 1291,
		bao2212 = 1292,
		bao2212_hit = 1293,
		bao2212_hit_loop = 1294,
		bao2220 = 1295,
		bao2220_loop = 1296,
		bao2221 = 1297,
		bao2221_loop = 1298,
		bao2230 = 1299,
		bao2230_loop = 1300,
		bao2231 = 1301,
		bao2231_loop = 1302,
		bao2240 = 1303,
		bao2241 = 1304,
		bao2242 = 1305,
		bao2243 = 1306,
		bao2300 = 1307,
		bao2310 = 1308,
		bao2311 = 1309,
		bao2312 = 1310,
		bao2320 = 1311,
		bao2321 = 1312,
		bao2322 = 1313,
		bao3100 = 1314,
		bao3110 = 1315,
		bao3110_loop = 1316,
		bao3211 = 1317,
		bao3211_loop = 1318,
		bao3212 = 1319,
		bao3212_loop = 1320,
		bao3212_add = 1321,
		bao3212_add2 = 1322,
		bao3212_loop_add = 1323,
		bao3241 = 1324,
		bao3241_loop = 1325,
		bao3251 = 1326,
		bao3251_loop = 1327,
		bao3400 = 1328,
		bao3400_a = 1329,
		bao3400_b = 1330,
		bao3400_c = 1331,
		bao3500 = 1332,
		bao3500_a = 1333,
		bao3500_b = 1334,
		bao3500_c = 1335,
		bao4100 = 1336,
		bao4110 = 1337,
		bao4200 = 1338,
		bao4300 = 1339,
		bao4300_loop = 1340,
		bao4310 = 1341,
		bao5001_w = 1342,
		bao5001_w_loop = 1343,
		bao5001_b = 1344,
		bao5001_b_loop = 1345,
		bao5001_y = 1346,
		bao5001_y_loop = 1347,
		bao5001_g = 1348,
		bao5001_g_loop = 1349,
		bao5001_r = 1350,
		bao5001_r_loop = 1351,
		bao5002_1_w = 1352,
		bao5002_1_w_loop = 1353,
		bao5002_1_b = 1354,
		bao5002_1_b_loop = 1355,
		bao5002_1_y = 1356,
		bao5002_1_y_loop = 1357,
		bao5002_1_g = 1358,
		bao5002_1_g_loop = 1359,
		bao5002_1_r = 1360,
		bao5002_1_r_loop = 1361,
		bao5002_2_w = 1362,
		bao5002_2_w_loop = 1363,
		bao5002_2_b = 1364,
		bao5002_2_b_loop = 1365,
		bao5002_2_y = 1366,
		bao5002_2_y_loop = 1367,
		bao5002_2_g = 1368,
		bao5002_2_g_loop = 1369,
		bao5002_2_r = 1370,
		bao5002_2_r_loop = 1371,
		bao5002_3_w = 1372,
		bao5002_3_w_loop = 1373,
		bao5002_3_b = 1374,
		bao5002_3_b_loop = 1375,
		bao5002_3_y = 1376,
		bao5002_3_y_loop = 1377,
		bao5002_3_g = 1378,
		bao5002_3_g_loop = 1379,
		bao5002_3_r = 1380,
		bao5002_3_r_loop = 1381,
		bao5004 = 1382,
		bao5004_loop = 1383,
		bao7002_a = 1384,
		bao7002_a_loop = 1385,
		bao7002_a_1 = 1386,
		bao7002_a_1_loop = 1387,
		bao7002_a_2 = 1388,
		bao7002_a_2_loop = 1389,
		bao7002_a_3 = 1390,
		bao7002_a_3_loop = 1391,
		bao7002_b = 1392,
		bao5002_1_non = 1393,
		bao5005 = 1394,
		bao5005_loop = 1395,
		bao4210_total_1 = 1396,
		bao4210_total_1_loop = 1397,
		bao4210_total_2 = 1398,
		bao4210_total_2_loop = 1399,
		bao4210_total_3 = 1400,
		bao4210_total_3_loop = 1401,
		bao4210_total_4 = 1402,
		bao4210_total_4_loop = 1403,
		bao4210_1_dummy = 1404,
		bao4210_2_dummy = 1405,
		bao4210_3_dummy = 1406,
		bao4210_4_dummy = 1407,
		bao4210_num_3 = 1408,
		bao4210_num_4 = 1409,
		bao4210_num_5 = 1410,
		bao4210_num_6 = 1411,
		bao4210_num_7 = 1412,
		bao4210_num_8 = 1413,
		bao4210_num_9 = 1414,
		bao4210_num_0_add = 1415,
		bao4210_num_1_add = 1416,
		bao4210_num_2_add = 1417,
		bao4210_num_3_add = 1418,
		bao4210_num_4_add = 1419,
		bao4210_num_5_add = 1420,
		bao4210_num_6_add = 1421,
		bao4210_num_7_add = 1422,
		bao4210_num_8_add = 1423,
		bao4210_num_9_add = 1424,
		dst001 = 1425,
		dgs001 = 1426,
		dgs001_add = 1427,
		dgs001_loop = 1428,
		dgs003 = 1429,
		dgs004 = 1430,
		dgs004_add = 1431,
		dgs004_loop = 1432,
		dgs004_0_1 = 1433,
		dgs004_0_1_loop = 1434,
		dgs004_1_1 = 1435,
		dgs004_1_1_loop = 1436,
		dgs004_2_1 = 1437,
		dgs004_2_1_loop = 1438,
		dgs004_3_1 = 1439,
		dgs004_3_1_loop = 1440,
		dgs004_4_1 = 1441,
		dgs004_4_1_loop = 1442,
		dgs004_5_1 = 1443,
		dgs004_5_1_loop = 1444,
		dgs004_6_1 = 1445,
		dgs004_6_1_loop = 1446,
		dgs004_7_1 = 1447,
		dgs004_7_1_loop = 1448,
		dgs004_8_1 = 1449,
		dgs004_8_1_loop = 1450,
		dgs004_9_1 = 1451,
		dgs004_9_1_loop = 1452,
		dgs004_0_2 = 1453,
		dgs004_0_2_nml = 1454,
		dgs004_1_2 = 1455,
		dgs004_1_2_nml = 1456,
		dgs004_2_2 = 1457,
		dgs004_2_2_nml = 1458,
		dgs004_3_2 = 1459,
		dgs004_3_2_nml = 1460,
		dgs004_4_2 = 1461,
		dgs004_4_2_nml = 1462,
		dgs004_5_2 = 1463,
		dgs004_5_2_nml = 1464,
		dgs004_6_2 = 1465,
		dgs004_6_2_nml = 1466,
		dgs004_7_2 = 1467,
		dgs004_7_2_nml = 1468,
		dgs004_8_2 = 1469,
		dgs004_8_2_nml = 1470,
		dgs004_9_2 = 1471,
		dgs004_9_2_nml = 1472,
		dgs004_0_3 = 1473,
		dgs004_1_3 = 1474,
		dgs004_2_3 = 1475,
		dgs004_3_3 = 1476,
		dgs004_4_3 = 1477,
		dgs004_5_3 = 1478,
		dgs004_6_3 = 1479,
		dgs004_7_3 = 1480,
		dgs004_8_3 = 1481,
		dgs004_9_3 = 1482,
		dgs004_0_4 = 1483,
		dgs004_1_4 = 1484,
		dgs004_2_4 = 1485,
		dgs004_3_4 = 1486,
		dgs004_4_4 = 1487,
		dgs004_5_4 = 1488,
		dgs004_6_4 = 1489,
		dgs004_7_4 = 1490,
		dgs004_8_4 = 1491,
		dgs004_9_4 = 1492,
		dgs004_10 = 1493,
		dgs004_10_loop = 1494,
		dhi001 = 1495,
		dhi001_loop = 1496,
		dhi002 = 1497,
		dhi002_loop = 1498,
		dhi003 = 1499,
		dhi003_loop = 1500,
		dhi004 = 1501,
		dhi005_haikei = 1502,
		dhi005_7 = 1503,
		dhi005_7_add = 1504,
		dhi005_7_add_loop = 1505,
		dhi005_10 = 1506,
		dhi005_10_add = 1507,
		dhi005_10_add_loop = 1508,
		dhi005_20 = 1509,
		dhi005_20_add = 1510,
		dhi005_20_add_loop = 1511,
		dhi005_30 = 1512,
		dhi005_30_add = 1513,
		dhi005_30_add_loop = 1514,
		dhi005_50 = 1515,
		dhi005_50_add = 1516,
		dhi005_50_addloop = 1517,
		dhi005_100 = 1518,
		dhi005_100_add = 1519,
		dhi005_100_add_loop = 1520,
		dhi005_200 = 1521,
		dhi005_200_add = 1522,
		dhi005_200_add_loop = 1523,
		dhi005_300 = 1524,
		dhi005_300_add = 1525,
		dhi005_300_add_loop = 1526,
		dhi011 = 1527,
		dhi011_loop = 1528,
		dhi011_add = 1529,
		dhi012 = 1530,
		dhi005_150 = 1531,
		dhi005_150_add = 1532,
		dhi005_150_add_loop = 1533,
		dnv001_a_1_yellow = 1534,
		dnv001_a_1_blue = 1535,
		dnv001_a_1_white = 1536,
		dnv001_a_1_black = 1537,
		dnv001_b_1_yellow = 1538,
		dnv001_b_1_blue = 1539,
		dnv001_b_1_white = 1540,
		dnv001_b_1_black = 1541,
		dnv001_c_1_yellow = 1542,
		dnv001_c_1_blue = 1543,
		dnv001_c_1_white = 1544,
		dnv001_c_1_black = 1545,
		dnv001_d_1_yellow = 1546,
		dnv001_d_1_blue = 1547,
		dnv001_d_1_white = 1548,
		dnv001_d_1_black = 1549,
		dnv001_b_2_yellow_mini = 1550,
		dnv001_b_2_blue_mini = 1551,
		dnv001_b_2_white_mini = 1552,
		dnv001_b_2_black_mini = 1553,
		dnv001_c_2_yellow = 1554,
		dnv001_c_2_blue = 1555,
		dnv001_c_2_white = 1556,
		dnv001_c_2_black = 1557,
		dnv001_d_2_yellow = 1558,
		dnv001_d_2_blue = 1559,
		dnv001_d_2_white = 1560,
		dnv001_d_2_black = 1561,
		dnv002_a_2_yellow = 1562,
		dnv002_a_2_blue = 1563,
		dnv002_a_2_white = 1564,
		dnv002_a_2_black = 1565,
		dnv002_b_2_yellow = 1566,
		dnv002_b_2_blue = 1567,
		dnv002_b_2_white = 1568,
		dnv002_b_2_black = 1569,
		dnv002_d_2_yellow = 1570,
		dnv002_d_2_blue = 1571,
		dnv002_d_2_white = 1572,
		dnv002_d_2_black = 1573,
		dnv001_b_3_yellow_mini = 1574,
		dnv001_b_3_blue_mini = 1575,
		dnv001_b_3_white_mini = 1576,
		dnv001_b_3_black_mini = 1577,
		dnv001_c_3_yellow = 1578,
		dnv001_c_3_blue = 1579,
		dnv001_c_3_white = 1580,
		dnv001_c_3_black = 1581,
		dnv001_d_3_yellow = 1582,
		dnv001_d_3_blue = 1583,
		dnv001_d_3_white = 1584,
		dnv001_d_3_black = 1585,
		dnv002_a_3_yellow = 1586,
		dnv002_a_3_blue = 1587,
		dnv002_a_3_white = 1588,
		dnv002_a_3_black = 1589,
		dnv002_b_3_yellow = 1590,
		dnv002_b_3_blue = 1591,
		dnv002_b_3_white = 1592,
		dnv002_b_3_black = 1593,
		dnv002_d_3_yellow = 1594,
		dnv002_d_3_blue = 1595,
		dnv002_d_3_white = 1596,
		dnv002_d_3_black = 1597,
		dnv001_b_2_yellow = 1598,
		dnv001_b_2_blue = 1599,
		dnv001_b_2_white = 1600,
		dnv001_b_2_black = 1601,
		dnv001_b_3_yellow = 1602,
		dnv001_b_3_blue = 1603,
		dnv001_b_3_white = 1604,
		dnv001_b_3_black = 1605,
		dnv001_c_1_ef = 1606,
		dnv001_c_2_ef = 1607,
		dnv001_c_3_ef = 1608,
		imb001 = 1609,
		imb001_loop = 1610,
		ikg001_a = 1611,
		ikg001_a_loop = 1612,
		ikg001_b = 1613,
		ikg001_b_loop = 1614,
		ikg001_c = 1615,
		ikg001_c_loop = 1616,
		ikg001_a_b = 1617,
		ikg001_a_b_loop = 1618,
		ikg001_a_c = 1619,
		ikg001_a_c_loop = 1620,
		ikg001_b_c = 1621,
		ikg001_b_c_loop = 1622,
		ikg002_a = 1623,
		ikg002_a_loop = 1624,
		ikg002_b = 1625,
		ikg002_b_loop = 1626,
		ikg002_c = 1627,
		ikg002_c_loop = 1628,
		ikg002_a_b = 1629,
		ikg002_a_b_loop = 1630,
		ikg002_a_c = 1631,
		ikg002_a_c_loop = 1632,
		ikg002_b_c = 1633,
		ikg002_b_c_loop = 1634,
		ikg004 = 1635,
		ikg004_loop = 1636,
		ikg005 = 1637,
		ibs001 = 1638,
		ibs001_loop = 1639,
		ijs001 = 1640,
		iss001 = 1641,
		iss001_loop = 1642,
		iss002 = 1643,
		iss003 = 1644,
		idi001 = 1645,
		idi001_loop = 1646,
		kws001 = 1647,
		kws002_1 = 1648,
		kws002_2 = 1649,
		kws002_bar = 1650,
		kws002_bri = 1651,
		kws002_chi = 1652,
		kws002_diz = 1653,
		kws002_dyn = 1654,
		kws002_izu = 1655,
		kws002_jam = 1656,
		kws002_kyk = 1657,
		kws002_man = 1658,
		kws002_may = 1659,
		kws002_mil = 1660,
		kws002_par = 1661,
		kws002_sen = 1662,
		kws002_sin = 1663,
		kws002_sla = 1664,
		kws002_sol = 1665,
		kws002_zap = 1666,
		kws003_1 = 1667,
		kws003_2 = 1668,
		kws004_bar1 = 1669,
		kws004_bar3 = 1670,
		kws004_bri1 = 1671,
		kws004_bri1_b = 1672,
		kws004_chi1 = 1673,
		kws004_chi1_b = 1674,
		kws004_kyk1 = 1675,
		kws004_kyk1_b = 1676,
		kws004_man1 = 1677,
		kws004_man1_b = 1678,
		kws004_mil1 = 1679,
		kws004_mil1_b = 1680,
		kws004_sin1 = 1681,
		kws004_sin1_b = 1682,
		kws004_sla1 = 1683,
		kws004_sla1_b = 1684,
		kws004_sol1 = 1685,
		kws004_sol1_b = 1686,
		kws004_zap1 = 1687,
		kws004_zap3 = 1688,
		kws005_1 = 1689,
		kws005_2 = 1690,
		kws005_bar = 1691,
		kws005_bri = 1692,
		kws005_chi = 1693,
		kws005_diz = 1694,
		kws005_izu = 1695,
		kws005_jam = 1696,
		kws005_kyk = 1697,
		kws005_man = 1698,
		kws005_may = 1699,
		kws005_mil = 1700,
		kws005_par = 1701,
		kws005_sen = 1702,
		kws005_sin = 1703,
		kws005_sla = 1704,
		kws005_sol = 1705,
		kws005_zap = 1706,
		kkt001 = 1707,
		kkt001_add = 1708,
		kkt002a_white = 1709,
		kkt002a_white_loop = 1710,
		kkt002a_blue = 1711,
		kkt002a_blue_loop = 1712,
		kkt002a_yellow = 1713,
		kkt002a_yellow_loop = 1714,
		kkt002a_green = 1715,
		kkt002a_green_loop = 1716,
		kkt002a_red = 1717,
		kkt002a_red_loop = 1718,
		kkt002a_purple = 1719,
		kkt002a_purple_loop = 1720,
		kkt002a_tento = 1721,
		kkt002a_tento_loop = 1722,
		kkt002a_rainbow = 1723,
		kkt002a_rainbow_loop = 1724,
		kkt002b_white = 1725,
		kkt002b_white_loop = 1726,
		kkt002b_blue = 1727,
		kkt002b_blue_loop = 1728,
		kkt002b_yellow = 1729,
		kkt002b_yellow_loop = 1730,
		kkt002b_green = 1731,
		kkt002b_green_loop = 1732,
		kkt002b_red = 1733,
		kkt002b_red_loop = 1734,
		kkt002b_purple = 1735,
		kkt002b_purple_loop = 1736,
		kkt002b_tento = 1737,
		kkt002b_tento_loop = 1738,
		kkt002b_rainbow = 1739,
		kkt002b_rainbow_loop = 1740,
		kkt003_sol = 1741,
		kkt003_add = 1742,
		kkt003a_a_white = 1743,
		kkt003a_a_white_down = 1744,
		kkt003a_a_white_down_loop = 1745,
		kkt003a_a_blue = 1746,
		kkt003a_a_blue_down = 1747,
		kkt003a_a_blue_down_loop = 1748,
		kkt003a_a_yellow = 1749,
		kkt003a_a_yellow_down = 1750,
		kkt003a_a_yellow_down_loop = 1751,
		kkt003a_a_green = 1752,
		kkt003a_a_green_down = 1753,
		kkt003a_a_green_down_loop = 1754,
		kkt003a_a_red = 1755,
		kkt003a_a_red_down = 1756,
		kkt003a_a_red_down_loop = 1757,
		kkt003a_a_purple = 1758,
		kkt003a_a_purple_down = 1759,
		kkt003a_a_purple_down_loop = 1760,
		kkt003a_a_tento = 1761,
		kkt003a_a_tento_down = 1762,
		kkt003a_a_tento_down_loop = 1763,
		kkt003a_a_rainbow = 1764,
		kkt003a_a_rainbow_down = 1765,
		kkt003a_a_rainbow_down_loop = 1766,
		kkt003b_a_white = 1767,
		kkt003b_a_white_down = 1768,
		kkt003b_a_white_down_loop = 1769,
		kkt003b_a_blue = 1770,
		kkt003b_a_blue_down = 1771,
		kkt003b_a_blue_down_loop = 1772,
		kkt003b_a_yellow = 1773,
		kkt003b_a_yellow_down = 1774,
		kkt003b_a_yellow_down_loop = 1775,
		kkt003b_a_green = 1776,
		kkt003b_a_green_down = 1777,
		kkt003b_a_green_down_loop = 1778,
		kkt003b_a_red = 1779,
		kkt003b_a_red_down = 1780,
		kkt003b_a_red_down_loop = 1781,
		kkt003b_a_purple = 1782,
		kkt003b_a_purple_down = 1783,
		kkt003b_a_purple_down_loop = 1784,
		kkt003b_a_tento = 1785,
		kkt003b_a_tento_down = 1786,
		kkt003b_a_tento_down_loop = 1787,
		kkt003b_a_rainbow = 1788,
		kkt003b_a_rainbow_down = 1789,
		kkt003b_a_rainbow_down_loop = 1790,
		kkt003a_b_white = 1791,
		kkt003a_b_blue = 1792,
		kkt003a_b_yellow = 1793,
		kkt003a_b_green = 1794,
		kkt003a_b_red = 1795,
		kkt003a_b_purple = 1796,
		kkt003a_b_tento = 1797,
		kkt003a_b_rainbow = 1798,
		kkt003b_b_white = 1799,
		kkt003b_b_blue = 1800,
		kkt003b_b_yellow = 1801,
		kkt003b_b_green = 1802,
		kkt003b_b_red = 1803,
		kkt003b_b_purple = 1804,
		kkt003b_b_tento = 1805,
		kkt003b_b_rainbow = 1806,
		kkt004_add = 1807,
		kkt004_syutyusen = 1808,
		kkt004_sin = 1809,
		kkt004a_white = 1810,
		kkt004a_blue = 1811,
		kkt004a_yellow = 1812,
		kkt004a_green = 1813,
		kkt004a_red = 1814,
		kkt004a_purple = 1815,
		kkt004a_tento = 1816,
		kkt004b_white = 1817,
		kkt004b_blue = 1818,
		kkt004b_yellow = 1819,
		kkt004b_green = 1820,
		kkt004b_red = 1821,
		kkt004b_purple = 1822,
		kkt004b_tento = 1823,
		kkt005_hitokage = 1824,
		kkt005_a_white = 1825,
		kkt005_a_blue = 1826,
		kkt005_a_yellow = 1827,
		kkt005_a_green = 1828,
		kkt005_a_red = 1829,
		kkt005_a_purple = 1830,
		kkt005_a_tento = 1831,
		kkt005_b_white = 1832,
		kkt005_b_blue = 1833,
		kkt005_b_yellow = 1834,
		kkt005_b_green = 1835,
		kkt005_b_red = 1836,
		kkt005_b_purple = 1837,
		kkt005_b_tento = 1838,
		kkt005_bri = 1839,
		kkt005_chp = 1840,
		kkt005_mil = 1841,
		kkt005_sly = 1842,
		kkt005_zap = 1843,
		kkt006 = 1844,
		kkt006_loop = 1845,
		kkt007 = 1846,
		kkt007_loop = 1847,
		kkt008 = 1848,
		kkt009a = 1849,
		kkt009a_loop = 1850,
		kkt010a_sin = 1851,
		kkt010a_sin_loop = 1852,
		kkt011a_kai = 1853,
		kkt012a_hai = 1854,
		kkt012a_bri = 1855,
		kkt012a_chp = 1856,
		kkt012a_mil = 1857,
		kkt012a_sly = 1858,
		kkt012a_zap = 1859,
		kkt014a_ano = 1860,
		kkt001_hai_mati = 1861,
		kkt002_hai_mati = 1862,
		kkt003_hai_mati = 1863,
		kkt003_hai_mati2 = 1864,
		kkt004_hai_mati = 1865,
		kkt005_hai_mati = 1866,
		kkt010_hai_mati = 1867,
		kkt001_hai_kai = 1868,
		kkt002_hai_kai = 1869,
		kkt003_hai_kai = 1870,
		kkt003_hai_kai2 = 1871,
		kkt004_hai_kai = 1872,
		kkt005_hai_kai = 1873,
		kkt010_hai_kai = 1874,
		kkt001_hai_ya = 1875,
		kkt002_hai_ya = 1876,
		kkt003_hai_ya = 1877,
		kkt003_hai_ya2 = 1878,
		kkt004_hai_ya = 1879,
		kkt005_hai_ya = 1880,
		kkt010_hai_ya = 1881,
		kkt001_ya = 1882,
		kkt002a_white_ya = 1883,
		kkt002a_white_ya_loop = 1884,
		kkt002a_blue_ya = 1885,
		kkt002a_blue_ya_loop = 1886,
		kkt002a_yellow_ya = 1887,
		kkt002a_yellow_ya_loop = 1888,
		kkt002a_green_ya = 1889,
		kkt002a_green_ya_loop = 1890,
		kkt002a_red_ya = 1891,
		kkt002a_red_ya_loop = 1892,
		kkt002a_purple_ya = 1893,
		kkt002a_purple_ya_loop = 1894,
		kkt002a_tento_ya = 1895,
		kkt002a_tento_ya_loop = 1896,
		kkt002a_rainbow_ya = 1897,
		kkt002a_rainbow_ya_loop = 1898,
		kkt002b_white_ya = 1899,
		kkt002b_white_ya_loop = 1900,
		kkt002b_blue_ya = 1901,
		kkt002b_blue_ya_loop = 1902,
		kkt002b_yellow_ya = 1903,
		kkt002b_yellow_ya_loop = 1904,
		kkt002b_green_ya = 1905,
		kkt002b_green_ya_loop = 1906,
		kkt002b_red_ya = 1907,
		kkt002b_red_ya_loopv = 1908,
		kkt002b_purple_ya = 1909,
		kkt002b_purple_ya_loop = 1910,
		kkt002b_tento_ya = 1911,
		kkt002b_tento_ya_loop = 1912,
		kkt002b_rainbow_ya = 1913,
		kkt002b_rainbow_ya_loop = 1914,
		kkt003_sol_ya = 1915,
		kkt003a_a_white_ya = 1916,
		kkt003a_a_white_ya_down = 1917,
		kkt003a_a_white_ya_down_loop = 1918,
		kkt003a_a_blue_ya = 1919,
		kkt003a_a_blue_ya_down = 1920,
		kkt003a_a_blue_ya_down_loop = 1921,
		kkt003a_a_yellow_ya = 1922,
		kkt003a_a_yellow_ya_down = 1923,
		kkt003a_a_yellow_ya_down_loop = 1924,
		kkt003a_a_green_ya = 1925,
		kkt003a_a_green_ya_down = 1926,
		kkt003a_a_green_ya_down_loop = 1927,
		kkt003a_a_red_ya = 1928,
		kkt003a_a_red_ya_down = 1929,
		kkt003a_a_red_ya_down_loop = 1930,
		kkt003a_a_purple_ya = 1931,
		kkt003a_a_purple_ya_down = 1932,
		kkt003a_a_purple_ya_down_loop = 1933,
		kkt003a_a_tento_ya = 1934,
		kkt003a_a_tento_ya_down = 1935,
		kkt003a_a_tento_ya_down_loop = 1936,
		kkt003a_a_rainbow_ya = 1937,
		kkt003a_a_rainbow_ya_down = 1938,
		kkt003a_a_rainbow_ya_down_loop = 1939,
		kkt003b_a_white_ya = 1940,
		kkt003b_a_white_ya_down = 1941,
		kkt003b_a_white_ya_down_loop = 1942,
		kkt003b_a_blue_ya = 1943,
		kkt003b_a_blue_ya_down = 1944,
		kkt003b_a_blue_ya_down_loop = 1945,
		kkt003b_a_yellow_ya = 1946,
		kkt003b_a_yellow_ya_down = 1947,
		kkt003b_a_yellow_ya_down_loop = 1948,
		kkt003b_a_green_ya = 1949,
		kkt003b_a_green_ya_down = 1950,
		kkt003b_a_green_ya_down_loop = 1951,
		kkt003b_a_red_ya = 1952,
		kkt003b_a_red_ya_down = 1953,
		kkt003b_a_red_ya_down_loop = 1954,
		kkt003b_a_purple_ya = 1955,
		kkt003b_a_purple_ya_down = 1956,
		kkt003b_a_purple_ya_down_loop = 1957,
		kkt003b_a_tento_ya = 1958,
		kkt003b_a_tento_ya_down = 1959,
		kkt003b_a_tento_ya_down_loop = 1960,
		kkt003b_a_rainbow_ya = 1961,
		kkt003b_a_rainbow_ya_down = 1962,
		kkt003b_a_rainbow_ya_down_loop = 1963,
		kkt003a_b_white_ya = 1964,
		kkt003a_b_blue_ya = 1965,
		kkt003a_b_yellow_ya = 1966,
		kkt003a_b_green_ya = 1967,
		kkt003a_b_red_ya = 1968,
		kkt003a_b_purple_ya = 1969,
		kkt003a_b_tento_ya = 1970,
		kkt003a_b_rainbow_ya = 1971,
		kkt003b_b_white_ya = 1972,
		kkt003b_b_blue_ya = 1973,
		kkt003b_b_yellow_ya = 1974,
		kkt003b_b_green_ya = 1975,
		kkt003b_b_red_ya = 1976,
		kkt003b_b_purple_ya = 1977,
		kkt003b_b_tento_ya = 1978,
		kkt003b_b_rainbow_ya = 1979,
		kkt004_sin_ya = 1980,
		kkt004a_white_ya = 1981,
		kkt004a_blue_ya = 1982,
		kkt004a_yellow_ya = 1983,
		kkt004a_green_ya = 1984,
		kkt004a_red_ya = 1985,
		kkt004a_purple_ya = 1986,
		kkt004a_tento_ya = 1987,
		kkt004b_white_ya = 1988,
		kkt004b_blue_ya = 1989,
		kkt004b_yellow_ya = 1990,
		kkt004b_green_ya = 1991,
		kkt004b_red_ya = 1992,
		kkt004b_purple_ya = 1993,
		kkt004b_tento_ya = 1994,
		kkt005_a_white_ya = 1995,
		kkt005_a_blue_ya = 1996,
		kkt005_a_yellow_ya = 1997,
		kkt005_a_green_ya = 1998,
		kkt005_a_red_ya = 1999,
		kkt005_a_purple_ya = 2000,
		kkt005_a_tento_ya = 2001,
		kkt005_b_white_ya = 2002,
		kkt005_b_blue_ya = 2003,
		kkt005_b_yellow_ya = 2004,
		kkt005_b_green_ya = 2005,
		kkt005_b_red_ya = 2006,
		kkt005_b_purple_ya = 2007,
		kkt005_b_tento_ya = 2008,
		kho001 = 2009,
		kho001_loop = 2010,
		kho002a_white = 2011,
		kho002a_white_loop = 2012,
		kho002a_blue = 2013,
		kho002a_blue_loop = 2014,
		kho002a_yellow = 2015,
		kho002a_yellow_loop = 2016,
		kho002a_green = 2017,
		kho002a_green_loop = 2018,
		kho002a_red = 2019,
		kho002a_red_loop = 2020,
		kho002a_purple = 2021,
		kho002a_purple_loop = 2022,
		kho002a_rainbow = 2023,
		kho002a_rainbow_loop = 2024,
		kho002b_white = 2025,
		kho002b_white_loop = 2026,
		kho002b_blue = 2027,
		kho002b_blue_loop = 2028,
		kho002b_yellow = 2029,
		kho002b_yellow_loop = 2030,
		kho002b_green = 2031,
		kho002b_green_loop = 2032,
		kho002b_red = 2033,
		kho002b_red_loop = 2034,
		kho002b_purple = 2035,
		kho002b_purple_loop = 2036,
		kho002b_rainbow = 2037,
		kho002b_rainbow_loop = 2038,
		kho003 = 2039,
		kho004a = 2040,
		kho004a_loop = 2041,
		kho004d = 2042,
		kho004d_loop = 2043,
		kho004f = 2044,
		kho004g = 2045,
		kho004g_loop = 2046,
		kho004_game = 2047,
		kho004j = 2048,
		kho004j_loop = 2049,
		kho004k = 2050,
		kho004k_loop = 2051,
		kho004l = 2052,
		kho004l_loop = 2053,
		kho004m = 2054,
		kho004m_loop = 2055,
		kbu001_sly = 2056,
		kbu001_chp = 2057,
		kbu001_mil = 2058,
		kbu001_bri = 2059,
		kbu001_zap = 2060,
		ksy000_1 = 2061,
		ksy000_2 = 2062,
		ksy000_3 = 2063,
		ksy001_1 = 2064,
		ksy001_2 = 2065,
		ksy001_3 = 2066,
		ksy002_1 = 2067,
		ksy002_2 = 2068,
		ksy002_3 = 2069,
		ksy003_1 = 2070,
		ksy003_2 = 2071,
		ksy003_3 = 2072,
		ksy004_1 = 2073,
		ksy004_2 = 2074,
		ksy004_3 = 2075,
		ksy005_1 = 2076,
		ksy005_2 = 2077,
		ksy005_3 = 2078,
		ksy006_1 = 2079,
		ksy006_2 = 2080,
		ksy006_3 = 2081,
		ksy007_1 = 2082,
		ksy007_2 = 2083,
		ksy007_3 = 2084,
		ksy008_1 = 2085,
		ksy008_2 = 2086,
		ksy008_3 = 2087,
		ksy009_1 = 2088,
		ksy009_2 = 2089,
		ksy009_3 = 2090,
		ksy010_1 = 2091,
		ksy010_2 = 2092,
		ksy010_3 = 2093,
		ksy011_1 = 2094,
		ksy011_2 = 2095,
		ksy011_3 = 2096,
		ksy012_1 = 2097,
		ksy012_2 = 2098,
		ksy012_3 = 2099,
		ksy013_a_1 = 2100,
		ksy013_a_2 = 2101,
		ksy013_a_3 = 2102,
		ksy013_b = 2103,
		ksy013_b_loop = 2104,
		ksy014_1 = 2105,
		ksy014_2 = 2106,
		ksy014_3 = 2107,
		kog001 = 2108,
		kog001_loop = 2109,
		kog001_st = 2110,
		kog002_a = 2111,
		kog002_a_loop = 2112,
		kog002_b = 2113,
		kog002_b_loop = 2114,
		kog003 = 2115,
		kog003_loop = 2116,
		kog004 = 2117,
		kog004_loop = 2118,
		kog005_a = 2119,
		kog005_a_loop = 2120,
		kog005_b = 2121,
		kog005_b_loop = 2122,
		kog005_c = 2123,
		kog005_c_loop = 2124,
		kog017 = 2125,
		kog017_loop = 2126,
		kog006 = 2127,
		kog006_loop = 2128,
		kog007 = 2129,
		kog008 = 2130,
		kog008_loop = 2131,
		kog009 = 2132,
		kog009_loop = 2133,
		kog010 = 2134,
		kog010_loop = 2135,
		kog011 = 2136,
		kog012 = 2137,
		hcp1001_chp1 = 2138,
		hcp1001_chp2 = 2139,
		hcp1002_chp = 2140,
		hcp1002_chp_loop = 2141,
		hcp1002_chp_3 = 2142,
		hcp1002_chp_3_loop = 2143,
		hcp1002_chp_4 = 2144,
		hcp1002_chp_4_loop = 2145,
		hcp2001_chp = 2146,
		hcp2001_chp_3 = 2147,
		hcp2001_chp_4 = 2148,
		hcp2002_chp1 = 2149,
		hcp2002_chp2 = 2150,
		hcp2004_chp = 2151,
		hcp2004_chp_loop = 2152,
		hcp2005_chp = 2153,
		hcp2005_chp_loop = 2154,
		hcp2007_chp = 2155,
		hcp2008_chp = 2156,
		hcp2009_chp = 2157,
		hcp2011_chp = 2158,
		hcp2012_chp = 2159,
		hcp2012_chp_loop = 2160,
		hcp2013_chp = 2161,
		hcp2015_chp = 2162,
		hcp2020_chp = 2163,
		hcp2022_chp = 2164,
		hcp2022_chp_loop = 2165,
		hcp2023_chp = 2166,
		hcp2026_chp = 2167,
		hcp3001_chp = 2168,
		hcp3001_chp2_loop = 2169,
		hcp3003_chp = 2170,
		hcp3003_chp2_loop = 2171,
		hcp3004_chp = 2172,
		hcp3004_chp_loop = 2173,
		hcp3005_chp = 2174,
		hcp3005_chp_loop = 2175,
		hcp3006_chp = 2176,
		hcp3008_chp = 2177,
		hcp3008_sol = 2178,
		hcp3011_chp1 = 2179,
		hcp3011_chp1_loop = 2180,
		hcp3011_chp2 = 2181,
		hcp3011_sol = 2182,
		hcp3014_chp = 2183,
		hcp3018_chp1 = 2184,
		hcp3018_chp1_loop = 2185,
		hcp3018_chp2 = 2186,
		hcp3018_chp2_loop = 2187,
		hcp3018_chp3 = 2188,
		hcp3018_chp3_loop = 2189,
		hcp3018_chp4 = 2190,
		hcp3018_chp4_loop = 2191,
		hcp3018_chp5 = 2192,
		hcp3018_chp5_loop = 2193,
		hcp5001_chp1 = 2194,
		hcp5001_chp2 = 2195,
		hcp5001_chp3 = 2196,
		hcp5001_chp4 = 2197,
		hcp5001_chp5 = 2198,
		hcp5002_chp1 = 2199,
		hcp5002_chp2 = 2200,
		hcp5002_chp3 = 2201,
		hcp5002_chp4 = 2202,
		hcp5002_chp5 = 2203,
		hcp5004_chp = 2204,
		hcp5004_chp_3 = 2205,
		hcp5004_chp_4 = 2206,
		hcp5007_chp1 = 2207,
		hcp5007_chp2 = 2208,
		hcp5007_chp3 = 2209,
		hcp5007_chp4 = 2210,
		hcp5007_chp5 = 2211,
		hcp5009_chp1 = 2212,
		hcp5009_chp2 = 2213,
		hcp5009_chp3 = 2214,
		hcp5009_chp4 = 2215,
		hcp5009_chp5 = 2216,
		hcp5010_chp = 2217,
		hcp5010_chp_3 = 2218,
		hcp5010_chp_4 = 2219,
		hcp5013_chp = 2220,
		hcp5013_chp_3 = 2221,
		hcp5013_chp_4 = 2222,
		hml1001_mil1 = 2223,
		hml1001_mil2 = 2224,
		hml1002_mil = 2225,
		hml1002_mil_loop = 2226,
		hml1002_mil_3 = 2227,
		hml1002_mil_3_loop = 2228,
		hml1002_mil_4 = 2229,
		hml1002_mil_4_loop = 2230,
		hml2001_mil = 2231,
		hml2001_mil_3 = 2232,
		hml2001_mil_4 = 2233,
		hml2002_mil1 = 2234,
		hml2002_mil2 = 2235,
		hml2004_mil = 2236,
		hml2004_mil_loop = 2237,
		hml2005_mil = 2238,
		hml2005_mil_loop = 2239,
		hml2007_mil = 2240,
		hml2008_mil = 2241,
		hml2009_mil = 2242,
		hml2011_mil = 2243,
		hml2012_mil = 2244,
		hml2012_mil_loop = 2245,
		hml2013_mil = 2246,
		hml2015_mil = 2247,
		hml2020_mil = 2248,
		hml2022_mil = 2249,
		hml2022_mil_loop = 2250,
		hml2023_mil = 2251,
		hml2026_mil = 2252,
		hml3001_mil = 2253,
		hml3001_mil_3 = 2254,
		hml3001_mil_4 = 2255,
		hml3003_mil = 2256,
		hml3003_mil_loop = 2257,
		hml3004_mil = 2258,
		hml3004_mil_loop = 2259,
		hml3005_mil = 2260,
		hml3005_mil_loop = 2261,
		hml3006_mil = 2262,
		hml3008_mil = 2263,
		hml3008_sol = 2264,
		hml3011_mil1 = 2265,
		hml3011_mil1_loop = 2266,
		hml3011_mil2 = 2267,
		hml3011_sol = 2268,
		hml3014_mil = 2269,
		hml3018_mil1 = 2270,
		hml3018_mil1_loop = 2271,
		hml3018_mil2 = 2272,
		hml3018_mil2_loop = 2273,
		hml3018_mil3 = 2274,
		hml3018_mil3_loop = 2275,
		hml3018_mil4 = 2276,
		hml3018_mil4_loop = 2277,
		hml3018_mil5 = 2278,
		hml3018_mil5_loop = 2279,
		hml5001_mil1 = 2280,
		hml5001_mil2 = 2281,
		hml5001_mil3 = 2282,
		hml5001_mil4 = 2283,
		hml5001_mil5 = 2284,
		hml5002_mil1 = 2285,
		hml5002_mil2 = 2286,
		hml5002_mil3 = 2287,
		hml5002_mil4 = 2288,
		hml5002_mil5 = 2289,
		hml5004_mil = 2290,
		hml5004_mil_3 = 2291,
		hml5004_mil_4 = 2292,
		hml5007_mil1 = 2293,
		hml5007_mil2 = 2294,
		hml5007_mil3 = 2295,
		hml5007_mil4 = 2296,
		hml5007_mil5 = 2297,
		hml5009_mil1 = 2298,
		hml5009_mil2 = 2299,
		hml5009_mil3 = 2300,
		hml5009_mil4 = 2301,
		hml5009_mil5 = 2302,
		hml5010_mil = 2303,
		hml5010_mil_3 = 2304,
		hml5010_mil_4 = 2305,
		hml5013_mil = 2306,
		hml5013_mil_3 = 2307,
		hml5013_mil_4 = 2308,
		hbj1001_brg1 = 2309,
		hbj1001_brg2 = 2310,
		hbj1002_brg = 2311,
		hbj1002_brg_loop = 2312,
		hbj1002_brg_3 = 2313,
		hbj1002_brg_3_loop = 2314,
		hbj1002_brg_4 = 2315,
		hbj1002_brg_4_loop = 2316,
		hbj2001_brg = 2317,
		hbj2001_brg_3 = 2318,
		hbj2001_brg_4 = 2319,
		hbj2002_brg1 = 2320,
		hbj2002_brg1_loop = 2321,
		hbj2002_brg2 = 2322,
		hbj2004_brg = 2323,
		hbj2004_brg_loop = 2324,
		hbj2005_brg = 2325,
		hbj2005_brg_loop = 2326,
		hbj2007_brg = 2327,
		hbj2008_brg = 2328,
		hbj2009_brg = 2329,
		hbj2011_brg = 2330,
		hbj2012_brg = 2331,
		hbj2012_brg_loop = 2332,
		hbj2013_brg = 2333,
		hbj2015_brg = 2334,
		hbj2020_brg = 2335,
		hbj2022_brg = 2336,
		hbj2022_brg_loop = 2337,
		hbj2024_brg = 2338,
		hbj2026_brg = 2339,
		hbj3001_brg = 2340,
		hbj3001_brg_3 = 2341,
		hbj3001_brg_4 = 2342,
		hbj3003_brg = 2343,
		hbj3003_brg_loop = 2344,
		hbj3004_brg = 2345,
		hbj3004_brg_loop = 2346,
		hbj3005_brg = 2347,
		hbj3005_brg_loop = 2348,
		hbj3006_brg = 2349,
		hbj3008_brg = 2350,
		hbj3008_sol = 2351,
		hbj3011_brg1 = 2352,
		hbj3011_brg1_loop = 2353,
		hbj3011_brg2 = 2354,
		hbj3011_sol = 2355,
		hbj3014_brg = 2356,
		hbj3018_brg1 = 2357,
		hbj3018_brg1_loop = 2358,
		hbj3018_brg2 = 2359,
		hbj3018_brg2_loop = 2360,
		hbj3018_brg3 = 2361,
		hbj3018_brg3_loop = 2362,
		hbj3018_brg4 = 2363,
		hbj3018_brg4_loop = 2364,
		hbj3018_brg5 = 2365,
		hbj3018_brg5_loop = 2366,
		hbj5001_brg1 = 2367,
		hbj5001_brg2 = 2368,
		hbj5001_brg3 = 2369,
		hbj5001_brg4 = 2370,
		hbj5001_brg5 = 2371,
		hbj5002_brg1 = 2372,
		hbj5002_brg2 = 2373,
		hbj5002_brg3 = 2374,
		hbj5002_brg4 = 2375,
		hbj5002_brg5 = 2376,
		hbj5004_brg = 2377,
		hbj5004_brg_loop = 2378,
		hbj5004_brg_3 = 2379,
		hbj5004_brg_3_loop = 2380,
		hbj5004_brg_4 = 2381,
		hbj5004_brg_4_loop = 2382,
		hbj5007_brg1 = 2383,
		hbj5007_brg1_loop = 2384,
		hbj5007_brg2 = 2385,
		hbj5007_brg2_loop = 2386,
		hbj5007_brg3 = 2387,
		hbj5007_brg3_loop = 2388,
		hbj5007_brg4 = 2389,
		hbj5007_brg4_loop = 2390,
		hbj5007_brg5 = 2391,
		hbj5007_brg5_loop = 2392,
		hbj5009_brg1 = 2393,
		hbj5009_brg2 = 2394,
		hbj5009_brg3 = 2395,
		hbj5009_brg4 = 2396,
		hbj5009_brg5 = 2397,
		hbj5010_sol = 2398,
		hbj5011_sol = 2399,
		hbj5010_brg = 2400,
		hbj5010_brg_3 = 2401,
		hbj5010_brg_4 = 2402,
		hbj5013_brg = 2403,
		hbj5013_brg_3 = 2404,
		hbj5013_brg_4 = 2405,
		hzp1001_zap1 = 2406,
		hzp1001_zap2 = 2407,
		hzp1002_zap = 2408,
		hzp1002_zap_loop = 2409,
		hzp1002_zap_3 = 2410,
		hzp1002_zap_3_loop = 2411,
		hzp1002_zap_4 = 2412,
		hzp1002_zap_4_loop = 2413,
		hzp2001_zap = 2414,
		hzp2001_zap_3 = 2415,
		hzp2001_zap_4 = 2416,
		hzp2022_zap = 2417,
		hzp2022_zap_loop = 2418,
		hzp2023_zap = 2419,
		hzp5010_zap = 2420,
		hzp5010_zap_3 = 2421,
		hzp5010_zap_4 = 2422,
		agh001_add = 2423,
		agh002_add = 2424,
		agh003_add = 2425,
		agh003_nml = 2426,
		agh003_ano_nml = 2427,
		aig001_b = 2428,
		aig001_b_loop = 2429,
		aig001_r = 2430,
		aig001_r_loop = 2431,
		aig001_d = 2432,
		aig001_d_loop = 2433,
		aig002_b = 2434,
		aig002_r = 2435,
		aig002_bd_nml = 2436,
		aig002_bd_loop_nml = 2437,
		aig002_bd_add = 2438,
		aig002_bd_loop_add = 2439,
		aig002_d = 2440,
		aig003_b = 2441,
		aig003_b_loop = 2442,
		aig003_r = 2443,
		aig003_r_loop = 2444,
		aig003_d = 2445,
		aig004_b = 2446,
		aig004_b_loop = 2447,
		aig004_r = 2448,
		aig004_r_loop = 2449,
		aig005_gbget = 2450,
		jrr001 = 2451,
		jrr002 = 2452,
		jrr004 = 2453,
		jrr005_ano = 2454,
		csh001 = 2455,
		csh002_a = 2456,
		csh002_a_loop = 2457,
		csh002_b = 2458,
		csh002_b_loop = 2459,
		csh003_white = 2460,
		csh003_white_loop = 2461,
		csh003_blue = 2462,
		csh003_blue_loop = 2463,
		csh003_yellow = 2464,
		csh003_yellow_loop = 2465,
		csh003_green = 2466,
		csh003_green_loop = 2467,
		csh003_red = 2468,
		csh003_red_loop = 2469,
		csh003_purple = 2470,
		csh003_purple_loop = 2471,
		csh003_rainbow = 2472,
		csh003_rainbow_loop = 2473,
		csh003_maneki = 2474,
		csh003_maneki_loop = 2475,
		csh003_white_l = 2476,
		csh003_white_l_loop = 2477,
		csh003_blue_l = 2478,
		csh003_blue_l_loop = 2479,
		csh003_yellow_l = 2480,
		csh003_yellow_l_loop = 2481,
		csh003_green_l = 2482,
		csh003_green_l_loop = 2483,
		csh003_red_l = 2484,
		csh003_red_l_loop = 2485,
		csh003_purple_l = 2486,
		csh003_purple_l_loop = 2487,
		csh003_rainbow_l = 2488,
		csh003_rainbow_l_loop = 2489,
		csh003_maneki_l = 2490,
		csh003_maneki_l_loop = 2491,
		csh004 = 2492,
		csh004_loop = 2493,
		csh005 = 2494,
		csh005_loop = 2495,
		csh005_ano = 2496,
		chk001_1 = 2497,
		chk001_1_nml = 2498,
		chk001_1_add = 2499,
		chk001_2 = 2500,
		chk002_1 = 2501,
		chk002_2 = 2502,
		chk002_3 = 2503,
		chk003_sakana = 2504,
		chk003_niku = 2505,
		chk003_maneki = 2506,
		chk004_white = 2507,
		chk004_blue = 2508,
		chk004_yellow = 2509,
		chk004_green = 2510,
		chk004_red = 2511,
		chk004_purple = 2512,
		chk004_rainbow = 2513,
		rst001_a = 2514,
		rst001_d = 2515,
		rst001_e = 2516,
		rsh001 = 2517,
		rsh001_loop = 2518,
		rsh002 = 2519,
		rsh002_loop = 2520,
		rsh003 = 2521,
		rsh003_loop = 2522,
		rsh004 = 2523,
		rsh004_loop = 2524,
		rsh005 = 2525,
		rsh005_loop = 2526,
		rsh006 = 2527,
		rsh006_loop = 2528,
		rsh007 = 2529,
		rsh007_loop = 2530,
		rsh008 = 2531,
		rsh009 = 2532,
		rsh009_loop = 2533,
		rsh010 = 2534,
		rsh010_loop = 2535,
		rsh012 = 2536,
		rsh013_1 = 2537,
		rsh013_1_loop = 2538,
		rsh013_2 = 2539,
		rsh013_2_loop = 2540,
		rsh001_st = 2541,
		riz001_a = 2542,
		riz001_a_loop = 2543,
		riz001_b = 2544,
		riz001_b_loop = 2545,
		riz002_a_1 = 2546,
		riz002_a_1_loop = 2547,
		riz002_a_2 = 2548,
		riz002_a_2_loop = 2549,
		riz002_a_3 = 2550,
		riz002_a_3_loop = 2551,
		riz002_a_4 = 2552,
		riz002_a_4_loop = 2553,
		riz002_b_1 = 2554,
		riz002_b_1_loop = 2555,
		riz002_b_2 = 2556,
		riz002_b_2_loop = 2557,
		riz002_c = 2558,
		riz002_c_loop = 2559,
		riz002_d = 2560,
		riz002_d_loop = 2561,
		riz003 = 2562,
		riz003_loop = 2563,
		riz004_a_a_1 = 2564,
		riz004_a_a_2 = 2565,
		riz004_a_a_3 = 2566,
		riz004_a_a_4 = 2567,
		riz004_a_b_1 = 2568,
		riz004_a_b_2 = 2569,
		riz004_b_1 = 2570,
		riz004_b_2 = 2571,
		ris001_a = 2572,
		ris001_a_loop = 2573,
		ris001_b = 2574,
		ris001_b_loop = 2575,
		ris002_a_1 = 2576,
		ris002_a_1_loop = 2577,
		ris002_a_2 = 2578,
		ris002_a_2_loop = 2579,
		ris002_a_3 = 2580,
		ris002_a_3_loop = 2581,
		ris002_a_4 = 2582,
		ris002_a_4_loop = 2583,
		ris002_a_5 = 2584,
		ris002_a_5_loop = 2585,
		ris002_a_6 = 2586,
		ris002_a_6_loop = 2587,
		ris002_a_7 = 2588,
		ris002_a_7_loop = 2589,
		ris002_a_8 = 2590,
		ris002_a_8_loop = 2591,
		ris002_b_1 = 2592,
		ris002_b_1_loop = 2593,
		ris002_b_2 = 2594,
		ris002_b_2_loop = 2595,
		ris002_b_3 = 2596,
		ris002_b_3_loop = 2597,
		ris002_b_4 = 2598,
		ris002_b_4_loop = 2599,
		ris002_b_5 = 2600,
		ris002_b_5_loop = 2601,
		ris002_b_6 = 2602,
		ris002_b_6_loop = 2603,
		ris002_b_7 = 2604,
		ris002_b_7_loop = 2605,
		ris002_b_8 = 2606,
		ris002_b_8_loop = 2607,
		ris005_a = 2608,
		rhk001sol00 = 2609,
		rhk001sol01 = 2610,
		rhk002_sin00 = 2611,
		rhk002_sin01 = 2612,
		rhk002_sin02 = 2613,
		rhk003_kikyu = 2614,
		rhk003_mayship = 2615,
		rhk004_nabi_white = 2616,
		rhk004_nabi_blue = 2617,
		rhk004_nabi_yellow = 2618,
		rhk004_nabi_green = 2619,
		rhk004_nabi_red = 2620,
		rhk004_nabi_purple = 2621,
		rhk004_nabi_rainbow = 2622,
		rhk003_neko = 2623,
		ish001 = 2624,
		ish001_loop = 2625,
		iog001 = 2626,
		iog001_loop = 2627,
		isc001_a = 2628,
		isc001_b = 2629,
		isc001_c = 2630,
		isc001_add = 2631,
		kfr001 = 2632,
		kfr001_loop = 2633,
		kfr002 = 2634,
		kfr002_loop = 2635,
		kfr003 = 2636,
		bi2001 = 2637,
		bi2001_loop = 2638,
		be2001a_2_01 = 2639,
		be2001a_2_02 = 2640,
		be2001a_2_03 = 2641,
		be2001a_2_04 = 2642,
		be2001a_2_05 = 2643,
		be2001a_2_06 = 2644,
		be2001a_2_07 = 2645,
		be2001a_2_08 = 2646,
		be2001a_2_09 = 2647,
		be2001a_2_10 = 2648,
		be2001a_2_11 = 2649,
		be2001a_2_12 = 2650,
		be2001a_2_13 = 2651,
		be2001a_2_14 = 2652,
		be2001a_2_15 = 2653,
		be2001a_2_16 = 2654,
		be2001a_2_17 = 2655,
		be2001a_2_18 = 2656,
		be2001a_2_19 = 2657,
		be2001a_2_20 = 2658,
		be2001a_2_21 = 2659,
		be2001a_2_22 = 2660,
		be2001a_2_23 = 2661,
		be2001a_2_24 = 2662,
		be2001a_2_25 = 2663,
		be2001a_2_26 = 2664,
		be2001a_2_27 = 2665,
		be2001a_2_28 = 2666,
		be2001a_3_1 = 2667,
		be2001a_3_2 = 2668,
		be2001a_3_3 = 2669,
		be2001a_3_4 = 2670,
		be2001c_1 = 2671,
		be2001c_2 = 2672,
		be2001c_3 = 2673,
		be2001a_2_x = 2674,
		be2001a_3_x = 2675,
		be2001b = 2676,
		bzt1001a = 2677,
		bzt1001b = 2678,
		bzt1002 = 2679,
		bzt1002_loop = 2680,
		bzt2001 = 2681,
		bzt2001_loop = 2682,
		bzt3001 = 2683,
		bzt3002 = 2684,
		bzt3002_loop = 2685,
		bzt3003 = 2686,
		bzt3004 = 2687,
		bzt3005 = 2688,
		bzt3005_loop = 2689,
		bzt3030 = 2690,
		bzt3030_loop = 2691,
		bzt3031 = 2692,
		bzt3031_loop = 2693,
		bzt3032 = 2694,
		bzt3032_loop = 2695,
		bzt3033 = 2696,
		bzt3033_loop = 2697,
		bzt3034 = 2698,
		bzt3034_loop = 2699,
		bzt3040 = 2700,
		bzt3041 = 2701,
		bzt3042 = 2702,
		bzt3043 = 2703,
		bzt3044 = 2704,
		bzt3100 = 2705,
		bzt3201 = 2706,
		bzt3202 = 2707,
		bzt3203 = 2708,
		bzt3204 = 2709,
		bzt3205 = 2710,
		bzt4001 = 2711,
		bzt4001_loop = 2712,
		bzt4002 = 2713,
		bzt4002_loop = 2714,
		bzt4010 = 2715,
		bzt4010_loop = 2716,
		bzt4011 = 2717,
		bzt4011_loop = 2718,
		bzt4012 = 2719,
		bzt4012_loop = 2720,
		bzt4012_add = 2721,
		bzt4012_add_loop = 2722,
		bzt4012_nml = 2723,
		bzt4012_nml_loop = 2724,
		bzt4020 = 2725,
		bzt4020_loop = 2726,
		bzt4021 = 2727,
		bzt4021_loop = 2728,
		bzt4021_nml = 2729,
		bzt4021_nml_loop = 2730,
		bzt4022 = 2731,
		bzt4022_loop = 2732,
		bzt4022_nml = 2733,
		bzt4022_nml_loop = 2734,
		bzt4032 = 2735,
		bzt4032_loop = 2736,
		bzt5001 = 2737,
		bzt5001_1 = 2738,
		bzt5001_2 = 2739,
		bzt5001_3 = 2740,
		bzt5001_4 = 2741,
		bzt5001_5 = 2742,
		bzt5001_6 = 2743,
		bzt5002 = 2744,
		bzt5003 = 2745,
		bzt5004 = 2746,
		bzt5005 = 2747,
		bzt5005_loop = 2748,
		bzt6001 = 2749,
		bzt6001_loop = 2750,
		bzt6003_1 = 2751,
		bzt6003_2 = 2752,
		bzt6004_1 = 2753,
		bzt6004_2 = 2754,
		bzt6011 = 2755,
		bzt7001_a = 2756,
		bzt7001_b_a = 2757,
		bzt7001_b_b = 2758,
		bzt7001_b_c_0 = 2759,
		bzt7001_b_c_1 = 2760,
		bzt7001_b_c_2 = 2761,
		bzt7001_b_c_3 = 2762,
		bzt7001_b_c_4 = 2763,
		bzt7001_b_c_5 = 2764,
		bzt7001_b_c_6 = 2765,
		bzt7001_b_c_7 = 2766,
		bzt7001_b_c_8 = 2767,
		bzt7001_b_c_9 = 2768,
		bzt7002 = 2769,
		bzt7002_loop = 2770,
		bzt7003 = 2771,
		bzt7003_loop = 2772,
		bzt7004_1 = 2773,
		bzt7004_2 = 2774,
		bzt7005_1 = 2775,
		bzt7005_2 = 2776,
		bzt7010_a = 2777,
		bzt7010_a_loop = 2778,
		bzt7010_b = 2779,
		bzt7010_b_add = 2780,
		bzt_push = 2781,
		bzt_push_loop = 2782,
		bm1001 = 2783,
		bm1002_1 = 2784,
		bm1002_1_loop = 2785,
		bm1002_2 = 2786,
		bm1002_2_loop = 2787,
		bm1002_3 = 2788,
		bm1002_3_loop = 2789,
		bm2_1 = 2790,
		bm2_2 = 2791,
		bm2_3 = 2792,
		bks001_sol = 2793,
		bks001_sol_loop = 2794,
		bks001_sin = 2795,
		bks001_sin_loop = 2796,
		bks001_ky = 2797,
		bks001_ky_loop = 2798,
		bks001_ano = 2799,
		bks001_ano_loop = 2800,
		bks001_gen = 2801,
		bks001_gen_loop = 2802,
		bks001_bar = 2803,
		bks001_bar_loop = 2804,
		bks001_sly = 2805,
		bks001_sly_loop = 2806,
		bks001_chp = 2807,
		bks001_chp_loop = 2808,
		bks001_mil = 2809,
		bks001_mil_loop = 2810,
		bks001_brg = 2811,
		bks001_brg_loop = 2812,
		bks001_zap = 2813,
		bks001_zap_loop = 2814,
		bks001_jam = 2815,
		bks001_jam_loop = 2816,
		bks001_may = 2817,
		bks001_may_loop = 2818,
		bks001_jon = 2819,
		bks001_jon_loop = 2820,
		bks001_par = 2821,
		bks001_par_loop = 2822,
		bks001_izu = 2823,
		bks001_izu_loop = 2824,
		bks001_syo = 2825,
		bks001_syo_loop = 2826,
		bks001_kok = 2827,
		bks001_kok_loop = 2828,
		bks001_ti = 2829,
		bks001_ti_loop = 2830,
		bks001_dyz = 2831,
		bks001_dyz_loop = 2832,
		bks001_rsol = 2833,
		bks001_rsol_loop = 2834,
		bks001_rsin = 2835,
		bks001_rsin_loop = 2836,
		bks001_rky = 2837,
		bks001_rky_loop = 2838,
		bks003_dou = 2839,
		bks003_gin = 2840,
		bks003_kin = 2841,
		bks002_dou = 2842,
		bks002_gin = 2843,
		bks002_kin = 2844,
		bem001 = 2845,
		bem002 = 2846,
		bem002_loop = 2847,
		bem003 = 2848,
		bem003_loop = 2849,
		bem004 = 2850,
		bem004_loop = 2851,
		bem005 = 2852,
		bem005_loop = 2853,
		bem006 = 2854,
		bem006_loop = 2855,
		bem007 = 2856,
		bem007_loop = 2857,
		bem008 = 2858,
		bem008_loop = 2859,
		bem009 = 2860,
		bem009_loop = 2861,
		bem010 = 2862,
		bem010_loop = 2863,
		bem011 = 2864,
		bem011_loop = 2865,
		bem012 = 2866,
		bem012_loop = 2867,
		bem013 = 2868,
		bem013_loop = 2869,
		bem014 = 2870,
		odm_movie = 2871,
		psu005 = 2872,
		psu005_loop = 2873,
		psu005_dai = 2874,
		psu005_dai_loop = 2875,
		psu010 = 2876,
		psu011 = 2877,
		psu011_add = 2878,
		psu012 = 2879,
		psu012_add = 2880,
		psu013 = 2881,
		psu013_add = 2882,
		psu010_play = 2883,
		psu010_play_add = 2884,
		psu011_play = 2885,
		psu011_play_add = 2886,
		psu012_play = 2887,
		psu012_play_add = 2888,
		psu013_play = 2889,
		psu013_play_add = 2890,
		psu020 = 2891,
		psu021 = 2892,
		psu021_add = 2893,
		psu022 = 2894,
		psu022_add = 2895,
		psu023 = 2896,
		psu023_add = 2897,
		psu020_play = 2898,
		psu020_play_add = 2899,
		psu021_play = 2900,
		psu021_play_add = 2901,
		psu022_play = 2902,
		psu022_play_add = 2903,
		psu023_play = 2904,
		psu023_play_add = 2905,
		yjd001 = 2906,
		yjd001_loop = 2907,
		yjd002 = 2908,
		yjd002_loop = 2909,
		yjd003 = 2910,
		yjd003_loop = 2911,
		yjd005 = 2912,
		yjd006 = 2913,
		yjd006_loop = 2914,
		yjd007 = 2915,
		yjd007_loop = 2916,
		yjd008 = 2917,
		yjd008_loop = 2918,
		ytg001_a = 2919,
		ytg001_a2 = 2920,
		ytg001_b = 2921,
		ytg001_b_loop = 2922,
		ytg001_c = 2923,
		ytg001_c_loop = 2924,
		ytg002 = 2925,
		ytg003 = 2926,
		ytg003_loop = 2927,
		ytg005 = 2928,
		ytg006 = 2929,
		yfc001_white = 2930,
		yfc001_blue = 2931,
		yfc001_yellow = 2932,
		yfc001_green = 2933,
		yfc001_red = 2934,
		yfc001_rainbow = 2935,
		yfc002 = 2936,
		yfc002_loop = 2937,
		yfc003 = 2938,
		yfc003_loop = 2939,
		yfc004_nml1 = 2940,
		yfc004_nml1_loop = 2941,
		yfc004_nml2 = 2942,
		yfc004_nml2_loop = 2943,
		yfc006_cutin = 2944,
		yfc006_cutin_loop = 2945,
		huc006 = 2946,
		huc006_loop = 2947,
		huc008_W = 2948,
		huc008_W_loop = 2949,
		huc008_B = 2950,
		huc008_B_loop = 2951,
		huc008_Y = 2952,
		huc008_Y_loop = 2953,
		huc008_G = 2954,
		huc008_G_loop = 2955,
		huc008_R = 2956,
		huc008_R_loop = 2957,
		huc008_P = 2958,
		huc008_P_loop = 2959,
		huc008_N = 2960,
		huc008_N_loop = 2961,
		huc008_T_10 = 2962,
		huc008_T_10_loop = 2963,
		huc008_T_20 = 2964,
		huc008_T_20_loop = 2965,
		huc008_T_30 = 2966,
		huc008_T_30_loop = 2967,
		huc008_T_50 = 2968,
		huc008_T_50_loop = 2969,
		huc008_T_100 = 2970,
		huc008_T_100_loop = 2971,
		huc008_T_150 = 2972,
		huc008_T_150_loop = 2973,
		huc008_T_200 = 2974,
		huc008_T_200_loop = 2975,
		huc008_T_300 = 2976,
		huc008_T_300_loop = 2977,
		huc008_T_7 = 2978,
		huc008_T_7_loop = 2979,
		huc012 = 2980,
		huc012_loop = 2981,
		btd001 = 2982,
		btd001_loop = 2983,
		btd003 = 2984,
		btd003_loop = 2985,
		ytk001_A_white = 2986,
		ytk001_A_blue = 2987,
		ytk001_A_yellow = 2988,
		ytk001_A_green = 2989,
		ytk001_A_red = 2990,
		ytk001_A_purple = 2991,
		ytk001_A_normal = 2992,
		ytk001_B_white = 2993,
		ytk001_B_blue = 2994,
		ytk001_B_yellow = 2995,
		ytk001_B_green = 2996,
		ytk001_B_red = 2997,
		ytk001_B_purple = 2998,
		ytk001_B_normal = 2999,
		ytk002_white_nml1 = 3000,
		ytk002_white_nml2 = 3001,
		ytk002_blue_nml1 = 3002,
		ytk002_blue_nml2 = 3003,
		ytk002_yellow_nml1 = 3004,
		ytk002_yellow_nml2 = 3005,
		ytk002_green_nml1 = 3006,
		ytk002_green_nml2 = 3007,
		ytk002_red_nml1 = 3008,
		ytk002_red_nml2 = 3009,
		ytk002_purple_nml1 = 3010,
		ytk002_purple_nml2 = 3011,
		ytk002_normal_nml1 = 3012,
		ytk002_normal_nml2 = 3013,
		ytk003_A_white = 3014,
		ytk003_A_blue = 3015,
		ytk003_A_yellow = 3016,
		ytk003_A_green = 3017,
		ytk003_A_red = 3018,
		ytk003_A_purple = 3019,
		ytk003_A_normal = 3020,
		ytk003_B = 3021,
		ytk003_C = 3022,
		ytk004_A = 3023,
		ytk004_B = 3024,
		ytk004_C = 3025,
		ytk004_D_white = 3026,
		ytk004_D_blue = 3027,
		ytk004_D_yellow = 3028,
		ytk004_D_green = 3029,
		ytk004_D_red = 3030,
		ytk004_D_purple = 3031,
		ytk004_D_normal = 3032,
		ytk004_E_white = 3033,
		ytk004_E_blue = 3034,
		ytk004_E_yellow = 3035,
		ytk004_E_green = 3036,
		ytk004_E_red = 3037,
		ytk004_E_purple = 3038,
		ytk004_E_normal = 3039,
		ytk004_F = 3040,
		ytk000_tensionUP = 3041,
		kwd376 = 3042,
		kwd377 = 3043,
		kwd378 = 3044,
		kwd379 = 3045,
		kwd380 = 3046,
		kwd381 = 3047,
		kwd382 = 3048,
		kwd383 = 3049,
		kwd384 = 3050,
		kwd385 = 3051,
		kwd386 = 3052,
		kwd387 = 3053,
		kwd388 = 3054,
		kwd389 = 3055,
		kwd390 = 3056,
		kwd391 = 3057,
		kwd392 = 3058,
		kwd393 = 3059,
		kwd394 = 3060,
		kwd395 = 3061,
		kwd396 = 3062,
		kwd397 = 3063,
		kwd398 = 3064,
		kwd399 = 3065,
		kwd400 = 3066,
		kwd401 = 3067,
		kwd402 = 3068,
		kwd403 = 3069,
		kwd404 = 3070,
		kwd405 = 3071,
		kwd492 = 3072,
		kwd493 = 3073,
		kwd494 = 3074,
		kwd495 = 3075,
		kwd496 = 3076,
		kwd497 = 3077,
		kwd498 = 3078,
		kwd499 = 3079,
		kwd500 = 3080,
		kwd501 = 3081,
		kwd231 = 3082,
		kwd232 = 3083,
		kwd233 = 3084,
		kwd234 = 3085,
		kwd235 = 3086,
		kwd236 = 3087,
		kwd237 = 3088,
		kwd238 = 3089,
		kwd239 = 3090,
		kwd240 = 3091,
		kwd241 = 3092,
		kwd242 = 3093,
		kwd243 = 3094,
		kwd244 = 3095,
		kwd245 = 3096,
		kwd246 = 3097,
		kwd247 = 3098,
		kwd248 = 3099,
		kwd249 = 3100,
		kwd250 = 3101,
		kwd251 = 3102,
		kwd252 = 3103,
		kwd253 = 3104,
		kwd254 = 3105,
		kwd255 = 3106,
		kwd256 = 3107,
		kwd257 = 3108,
		kwd258 = 3109,
		kwd259 = 3110,
		kwd260 = 3111,
		kwd346 = 3112,
		kwd347 = 3113,
		kwd348 = 3114,
		kwd349 = 3115,
		kwd350 = 3116,
		kwd351 = 3117,
		kwd352 = 3118,
		kwd353 = 3119,
		kwd354 = 3120,
		kwd355 = 3121,
		kwd161 = 3122,
		kwd162 = 3123,
		kwd163 = 3124,
		kwd164 = 3125,
		kwd165 = 3126,
		kwd166 = 3127,
		kwd167 = 3128,
		kwd168 = 3129,
		kwd169 = 3130,
		kwd170 = 3131,
		kwd171 = 3132,
		kwd172 = 3133,
		kwd173 = 3134,
		kwd174 = 3135,
		kwd175 = 3136,
		kwd176 = 3137,
		kwd177 = 3138,
		kwd178 = 3139,
		kwd179 = 3140,
		kwd180 = 3141,
		kwd111 = 3142,
		kwd112 = 3143,
		kwd113 = 3144,
		kwd114 = 3145,
		kwd115 = 3146,
		kwd116 = 3147,
		kwd117 = 3148,
		kwd118 = 3149,
		kwd119 = 3150,
		kwd120 = 3151,
		kwd121 = 3152,
		kwd122 = 3153,
		kwd123 = 3154,
		kwd124 = 3155,
		kwd125 = 3156,
		kwd126 = 3157,
		kwd127 = 3158,
		kwd128 = 3159,
		kwd129 = 3160,
		kwd130 = 3161,
		kwd131 = 3162,
		kwd132 = 3163,
		kwd133 = 3164,
		kwd134 = 3165,
		kwd135 = 3166,
		kwd136 = 3167,
		kwd137 = 3168,
		kwd138 = 3169,
		kwd139 = 3170,
		kwd140 = 3171,
		kwd80 = 3172,
		kwd81 = 3173,
		kwd82 = 3174,
		kwd83 = 3175,
		kwd84 = 3176,
		kwd85 = 3177,
		kwd86 = 3178,
		kwd87 = 3179,
		kwd88 = 3180,
		kwd89 = 3181,
		kwd90 = 3182,
		kwd91 = 3183,
		kwd92 = 3184,
		kwd93 = 3185,
		kwd94 = 3186,
		kwd95 = 3187,
		kwd96 = 3188,
		kwd97 = 3189,
		kwd98 = 3190,
		kwd99 = 3191,
		kwd100 = 3192,
		kwd101 = 3193,
		kwd102 = 3194,
		kwd103 = 3195,
		kwd104 = 3196,
		kwd105 = 3197,
		kwd106 = 3198,
		kwd107 = 3199,
		kwd108 = 3200,
		kwd109 = 3201,
		kwd191 = 3202,
		kwd192 = 3203,
		kwd193 = 3204,
		kwd194 = 3205,
		kwd195 = 3206,
		kwd196 = 3207,
		kwd197 = 3208,
		kwd198 = 3209,
		kwd199 = 3210,
		kwd200 = 3211,
		kwd201 = 3212,
		kwd202 = 3213,
		kwd203 = 3214,
		kwd204 = 3215,
		kwd205 = 3216,
		kwd206 = 3217,
		kwd207 = 3218,
		kwd208 = 3219,
		kwd209 = 3220,
		kwd210 = 3221,
		kwd141 = 3222,
		kwd142 = 3223,
		kwd143 = 3224,
		kwd144 = 3225,
		kwd145 = 3226,
		kwd146 = 3227,
		kwd147 = 3228,
		kwd148 = 3229,
		kwd149 = 3230,
		kwd150 = 3231,
		kwd151 = 3232,
		kwd152 = 3233,
		kwd153 = 3234,
		kwd154 = 3235,
		kwd155 = 3236,
		kwd156 = 3237,
		kwd157 = 3238,
		kwd158 = 3239,
		kwd159 = 3240,
		kwd160 = 3241,
		kwd50 = 3242,
		kwd51 = 3243,
		kwd52 = 3244,
		kwd53 = 3245,
		kwd54 = 3246,
		kwd55 = 3247,
		kwd56 = 3248,
		kwd57 = 3249,
		kwd58 = 3250,
		kwd59 = 3251,
		kwd60 = 3252,
		kwd61 = 3253,
		kwd62 = 3254,
		kwd63 = 3255,
		kwd64 = 3256,
		kwd65 = 3257,
		kwd66 = 3258,
		kwd67 = 3259,
		kwd68 = 3260,
		kwd69 = 3261,
		kwd0 = 3262,
		kwd1 = 3263,
		kwd2 = 3264,
		kwd3 = 3265,
		kwd4 = 3266,
		kwd5 = 3267,
		kwd6 = 3268,
		kwd7 = 3269,
		kwd8 = 3270,
		kwd9 = 3271,
		kwd181 = 3272,
		kwd182 = 3273,
		kwd183 = 3274,
		kwd184 = 3275,
		kwd185 = 3276,
		kwd186 = 3277,
		kwd187 = 3278,
		kwd188 = 3279,
		kwd189 = 3280,
		kwd190 = 3281,
		kwd356 = 3282,
		kwd357 = 3283,
		kwd358 = 3284,
		kwd359 = 3285,
		kwd360 = 3286,
		kwd361 = 3287,
		kwd362 = 3288,
		kwd363 = 3289,
		kwd364 = 3290,
		kwd365 = 3291,
		kwd366 = 3292,
		kwd367 = 3293,
		kwd368 = 3294,
		kwd369 = 3295,
		kwd370 = 3296,
		kwd371 = 3297,
		kwd372 = 3298,
		kwd373 = 3299,
		kwd374 = 3300,
		kwd375 = 3301,
		kwd30 = 3302,
		kwd31 = 3303,
		kwd32 = 3304,
		kwd33 = 3305,
		kwd34 = 3306,
		kwd35 = 3307,
		kwd36 = 3308,
		kwd37 = 3309,
		kwd38 = 3310,
		kwd39 = 3311,
		kwd40 = 3312,
		kwd41 = 3313,
		kwd42 = 3314,
		kwd43 = 3315,
		kwd44 = 3316,
		kwd45 = 3317,
		kwd46 = 3318,
		kwd47 = 3319,
		kwd48 = 3320,
		kwd49 = 3321,
		kwd211 = 3322,
		kwd212 = 3323,
		kwd213 = 3324,
		kwd214 = 3325,
		kwd215 = 3326,
		kwd216 = 3327,
		kwd217 = 3328,
		kwd218 = 3329,
		kwd219 = 3330,
		kwd220 = 3331,
		kwd221 = 3332,
		kwd222 = 3333,
		kwd223 = 3334,
		kwd224 = 3335,
		kwd225 = 3336,
		kwd226 = 3337,
		kwd227 = 3338,
		kwd228 = 3339,
		kwd229 = 3340,
		kwd230 = 3341,
		kwd10 = 3342,
		kwd11 = 3343,
		kwd12 = 3344,
		kwd13 = 3345,
		kwd14 = 3346,
		kwd15 = 3347,
		kwd16 = 3348,
		kwd17 = 3349,
		kwd18 = 3350,
		kwd19 = 3351,
		kwd20 = 3352,
		kwd21 = 3353,
		kwd22 = 3354,
		kwd23 = 3355,
		kwd24 = 3356,
		kwd25 = 3357,
		kwd26 = 3358,
		kwd27 = 3359,
		kwd28 = 3360,
		kwd29 = 3361,
		kwd502 = 3362,
		kwd503 = 3363,
		kwd504 = 3364,
		kwd505 = 3365,
		kwd506 = 3366,
		kwd507 = 3367,
		kwd508 = 3368,
		kwd509 = 3369,
		kwd510 = 3370,
		kwd511 = 3371,
		kwd512 = 3372,
		kwd513 = 3373,
		kwd514 = 3374,
		kwd515 = 3375,
		kwd516 = 3376,
		kwd517 = 3377,
		kwd518 = 3378,
		kwd519 = 3379,
		kwd520 = 3380,
		kwd521 = 3381,
		kwd70 = 3382,
		kwd71 = 3383,
		kwd72 = 3384,
		kwd73 = 3385,
		kwd74 = 3386,
		kwd75 = 3387,
		kwd76 = 3388,
		kwd77 = 3389,
		kwd78 = 3390,
		kwd79 = 3391,
		kwd416 = 3392,
		kwd417 = 3393,
		kwd418 = 3394,
		kwd419 = 3395,
		kwd428 = 3396,
		kwd429 = 3397,
		kwd430 = 3398,
		kwd431 = 3399,
		kwd440 = 3400,
		kwd441 = 3401,
		kwd442 = 3402,
		kwd443 = 3403,
		kwd452 = 3404,
		kwd453 = 3405,
		kwd454 = 3406,
		kwd455 = 3407,
		kwd464 = 3408,
		kwd465 = 3409,
		kwd466 = 3410,
		kwd467 = 3411,
		kwd484 = 3412,
		kwd485 = 3413,
		kwd486 = 3414,
		kwd487 = 3415,
		kwd488 = 3416,
		kwd489 = 3417,
		kwd490 = 3418,
		kwd491 = 3419,
		kwd265 = 3420,
		kwd266 = 3421,
		kwd267 = 3422,
		kwd268 = 3423,
		kwd269 = 3424,
		kwd270 = 3425,
		kwd271 = 3426,
		kwd272 = 3427,
		kwd277 = 3428,
		kwd278 = 3429,
		kwd279 = 3430,
		kwd280 = 3431,
		kwd281 = 3432,
		kwd282 = 3433,
		kwd283 = 3434,
		kwd284 = 3435,
		kwd289 = 3436,
		kwd290 = 3437,
		kwd291 = 3438,
		kwd292 = 3439,
		kwd293 = 3440,
		kwd294 = 3441,
		kwd295 = 3442,
		kwd296 = 3443,
		kwd301 = 3444,
		kwd302 = 3445,
		kwd303 = 3446,
		kwd304 = 3447,
		kwd305 = 3448,
		kwd306 = 3449,
		kwd307 = 3450,
		kwd308 = 3451,
		kwd314 = 3452,
		kwd315 = 3453,
		kwd316 = 3454,
		kwd317 = 3455,
		kwd318 = 3456,
		kwd319 = 3457,
		kwd320 = 3458,
		kwd321 = 3459,
		kwd330 = 3460,
		kwd331 = 3461,
		kwd332 = 3462,
		kwd333 = 3463,
		kwd334 = 3464,
		kwd335 = 3465,
		kwd336 = 3466,
		kwd337 = 3467,
		kwd338 = 3468,
		kwd339 = 3469,
		kwd340 = 3470,
		kwd341 = 3471,
		kwd342 = 3472,
		kwd343 = 3473,
		kwd344 = 3474,
		kwd345 = 3475,
		kwd261 = 3476,
		kwd262 = 3477,
		kwd263 = 3478,
		kwd264 = 3479,
		kwd273 = 3480,
		kwd274 = 3481,
		kwd275 = 3482,
		kwd276 = 3483,
		kwd285 = 3484,
		kwd286 = 3485,
		kwd287 = 3486,
		kwd288 = 3487,
		kwd297 = 3488,
		kwd298 = 3489,
		kwd299 = 3490,
		kwd300 = 3491,
		kwd309 = 3492,
		kwd310 = 3493,
		kwd311 = 3494,
		kwd312 = 3495,
		kwd322 = 3496,
		kwd323 = 3497,
		kwd324 = 3498,
		kwd325 = 3499,
		kwd326 = 3500,
		kwd327 = 3501,
		kwd328 = 3502,
		kwd329 = 3503,
		kwd408 = 3504,
		kwd409 = 3505,
		kwd410 = 3506,
		kwd411 = 3507,
		kwd412 = 3508,
		kwd413 = 3509,
		kwd414 = 3510,
		kwd415 = 3511,
		kwd420 = 3512,
		kwd421 = 3513,
		kwd422 = 3514,
		kwd423 = 3515,
		kwd424 = 3516,
		kwd425 = 3517,
		kwd426 = 3518,
		kwd427 = 3519,
		kwd432 = 3520,
		kwd433 = 3521,
		kwd434 = 3522,
		kwd435 = 3523,
		kwd436 = 3524,
		kwd437 = 3525,
		kwd438 = 3526,
		kwd439 = 3527,
		kwd444 = 3528,
		kwd445 = 3529,
		kwd446 = 3530,
		kwd447 = 3531,
		kwd448 = 3532,
		kwd449 = 3533,
		kwd450 = 3534,
		kwd451 = 3535,
		kwd456 = 3536,
		kwd457 = 3537,
		kwd458 = 3538,
		kwd459 = 3539,
		kwd460 = 3540,
		kwd461 = 3541,
		kwd462 = 3542,
		kwd463 = 3543,
		kwd468 = 3544,
		kwd469 = 3545,
		kwd470 = 3546,
		kwd471 = 3547,
		kwd472 = 3548,
		kwd473 = 3549,
		kwd474 = 3550,
		kwd475 = 3551,
		kwd476 = 3552,
		kwd477 = 3553,
		kwd478 = 3554,
		kwd479 = 3555,
		kwd480 = 3556,
		kwd481 = 3557,
		kwd482 = 3558,
		kwd483 = 3559,
		btg001 = 3560,
		btg_zandan001 = 3561,
		btg_zandan002 = 3562,
		btg_zandan003 = 3563,
		btg_zandan004 = 3564,
		btg_zandan005 = 3565,
		btg_zandan006 = 3566,
		bth000_a = 3567,
		bth000_b = 3568,
		bth001_white = 3569,
		bth001_white_loop = 3570,
		bth001_blue = 3571,
		bth001_blue_loop = 3572,
		bth001_yellow = 3573,
		bth001_yellow_loop = 3574,
		bth001_green = 3575,
		bth001_green_loop = 3576,
		bth001_red = 3577,
		bth001_red_loop = 3578,
		bth001_purple = 3579,
		bth001_purple_loop = 3580,
		bth001_rainbow = 3581,
		bth001_rainbow_loop = 3582,
		bth002_a_white = 3583,
		bth002_a_white_loop = 3584,
		bth002_a_blue = 3585,
		bth002_a_blue_loop = 3586,
		bth002_a_yellow = 3587,
		bth002_a_yellow_loop = 3588,
		bth002_a_green = 3589,
		bth002_a_green_loop = 3590,
		bth002_a_red = 3591,
		bth002_a_red_loop = 3592,
		bth002_a_purple = 3593,
		bth002_a_purple_loop = 3594,
		bth002_a_rainbow = 3595,
		bth002_a_rainbow_loop = 3596,
		bth002_b_white = 3597,
		bth002_b_white_loop = 3598,
		bth002_b_blue = 3599,
		bth002_b_blue_loop = 3600,
		bth002_b_yellow = 3601,
		bth002_b_yellow_loop = 3602,
		bth002_b_green = 3603,
		bth002_b_green_loop = 3604,
		bth002_b_red = 3605,
		bth002_b_red_loop = 3606,
		bth002_b_purple = 3607,
		bth002_b_purple_loop = 3608,
		bth002_b_rainbow = 3609,
		bth002_b_rainbow_loop = 3610,
		bt003_b_white = 3611,
		bt003_b_blue = 3612,
		bt003_b_yellow = 3613,
		bt003_b_green = 3614,
		bt003_b_red = 3615,
		bt003_b_purple = 3616,
		bt003_b_rainbow = 3617,
		bth004_white = 3618,
		bth004_white_loop = 3619,
		bth004_blue = 3620,
		bth004_blue_loop = 3621,
		bth004_yellow = 3622,
		bth004_yellow_loop = 3623,
		bth004_green = 3624,
		bth004_green_loop = 3625,
		bth004_red = 3626,
		bth004_red_loop = 3627,
		bth004_purple = 3628,
		bth004_purple_loop = 3629,
		bth004_rainbow = 3630,
		bth004_rainbow_loop = 3631,
		bth005_sin_1_white = 3632,
		bth005_sin_1_blue = 3633,
		bth005_sin_1_yellow = 3634,
		bth005_sin_1_green = 3635,
		bth005_sin_1_red = 3636,
		bth005_sin_1_purple = 3637,
		bth005_sin_1_rainbow = 3638,
		bth005_sin_2_white = 3639,
		bth005_sin_2_blue = 3640,
		bth005_sin_2_yellow = 3641,
		bth005_sin_2_green = 3642,
		bth005_sin_2_red = 3643,
		bth005_sin_2_purple = 3644,
		bth005_sin_2_rainbow = 3645,
		bth005_sol_1_white = 3646,
		bth005_sol_1_blue = 3647,
		bth005_sol_1_yellow = 3648,
		bth005_sol_1_green = 3649,
		bth005_sol_1_red = 3650,
		bth005_sol_1_purple = 3651,
		bth005_sol_1_rainbow = 3652,
		bth005_sol_2_white = 3653,
		bth005_sol_2_blue = 3654,
		bth005_sol_2_yellow = 3655,
		bth005_sol_2_green = 3656,
		bth005_sol_2_red = 3657,
		bth005_sol_2_purple = 3658,
		bth005_sol_2_rainbow = 3659,
		bth007_sin_3_white = 3660,
		bth007_sin_3_blue = 3661,
		bth007_sin_3_yellow = 3662,
		bth007_sin_3_green = 3663,
		bth007_sin_3_red = 3664,
		bth007_sin_3_purple = 3665,
		bth007_sin_3_rainbow = 3666,
		bth007_sol_3_white = 3667,
		bth007_sol_3_blue = 3668,
		bth007_sol_3_yellow = 3669,
		bth007_sol_3_green = 3670,
		bth007_sol_3_red = 3671,
		bth007_sol_3_purple = 3672,
		bth007_sol_3_rainbow = 3673,
		bt003_a_white = 3674,
		bt003_a_blue = 3675,
		bt003_a_yellow = 3676,
		bt003_a_green = 3677,
		bt003_a_red = 3678,
		bt003_a_purple = 3679,
		bt003_a_rainbow = 3680,
		bth008_a_white = 3681,
		bth008_a_blue = 3682,
		bth008_a_yellow = 3683,
		bth008_a_green = 3684,
		bth008_a_red = 3685,
		bth008_a_purple = 3686,
		bth008_a_rainbow = 3687,
		bjt001_nml = 3688,
		bjt001_loop = 3689,
		bjt001_nml2 = 3690,
		bjt001_loop2 = 3691,
		bjt003 = 3692,
		bjt003_loop = 3693,
		bjt004 = 3694,
		bjt004_loop = 3695,
		bjt005 = 3696,
		bjt005_loop = 3697,
		bjt006 = 3698,
		bjt007 = 3699,
		bjt007_loop = 3700,
		bjt008_1 = 3701,
		bjt008_1_loop = 3702,
		bjt008_white = 3703,
		bjt008_white_loop = 3704,
		bjt008_blue = 3705,
		bjt008_blue_loop = 3706,
		bjt008_yellow = 3707,
		bjt008_yellow_loop = 3708,
		bjt008_green = 3709,
		bjt008_green_loop = 3710,
		bjt008_red = 3711,
		bjt008_red_loop = 3712,
		bjt008_purple = 3713,
		bjt008_purple_loop = 3714,
		bjt008_rainbow = 3715,
		bjt008_rainbow_loop = 3716,
		bjt009_add = 3717,
		bjt009_nml = 3718,
		bjt009_add2 = 3719,
		bjt010_white = 3720,
		bjt010_blue = 3721,
		bjt010_yellow = 3722,
		bjt010_green = 3723,
		bjt010_red = 3724,
		bjt010_purple = 3725,
		bjt010_rainbow = 3726,
		bjt011_white = 3727,
		bjt011_blue = 3728,
		bjt011_yellow = 3729,
		bjt011_green = 3730,
		bjt011_red = 3731,
		bjt011_purple = 3732,
		bjt011_rainbow = 3733,
		bjt011_loop = 3734,
		bjt012_white = 3735,
		bjt012_blue = 3736,
		bjt012_yellow = 3737,
		bjt012_green = 3738,
		bjt012_red = 3739,
		bjt012_purple = 3740,
		bjt012_rainbow = 3741,
		bjt012_2_kyotu = 3742,
		bjt012_2_kyotu_loop = 3743,
		bjt013 = 3744,
		bjt013_loop = 3745,
		bjt014 = 3746,
		bjt015 = 3747,
		bjt015_loop = 3748,
		bjt016 = 3749,
		bjt016_2_nml = 3750,
		bjt016_2_nml_loop = 3751,
		bjt016_2_nml2 = 3752,
		bjt016_2_nml2_loop = 3753,
		bjt016_2_add = 3754,
		bjt017 = 3755,
		bjt017_loop = 3756,
		bjt018 = 3757,
		bjt018_loop = 3758,
		bjt019_nml = 3759,
		bjt019_nml_loop = 3760,
		bjt019_nml2 = 3761,
		bjt019_nml2_loop = 3762,
		bjt019_add = 3763,
		acz011_nml1 = 3764,
		acz011_add1 = 3765,
		acz011_nml2 = 3766,
		acz011_add2 = 3767,
		acz001_suuji_0_pink = 3768,
		acz001_suuji_1_pink = 3769,
		acz001_suuji_2_pink = 3770,
		acz001_suuji_3_pink = 3771,
		acz001_suuji_4_pink = 3772,
		acz001_suuji_5_pink = 3773,
		acz001_suuji_6_pink = 3774,
		acz001_suuji_7_pink = 3775,
		acz001_suuji_8_pink = 3776,
		acz001_suuji_9_pink = 3777,
		acz011_loop = 3778,
		acz011_loop_add = 3779,
		acz012 = 3780,
		acz012_add = 3781,
		acz001_loop = 3782,
		acz001_suuji_0 = 3783,
		acz001_suuji_1 = 3784,
		acz001_suuji_2 = 3785,
		acz001_suuji_3 = 3786,
		acz001_suuji_4 = 3787,
		acz001_suuji_5 = 3788,
		acz001_suuji_6 = 3789,
		acz001_suuji_7 = 3790,
		acz001_suuji_8 = 3791,
		acz001_suuji_9 = 3792,
		acz002 = 3793,
		acz002_loop = 3794,
		acz003 = 3795,
		acz003_loop = 3796,
		acz004 = 3797,
		acz004_loop = 3798,
		acz010_loop = 3799,
		acz001_suuji_0_blue = 3800,
		acz001_suuji_1_blue = 3801,
		acz001_suuji_2_blue = 3802,
		acz001_suuji_3_blue = 3803,
		acz001_suuji_4_blue = 3804,
		acz001_suuji_5_blue = 3805,
		acz001_suuji_6_blue = 3806,
		acz001_suuji_7_blue = 3807,
		acz001_suuji_8_blue = 3808,
		acz001_suuji_9_blue = 3809,
		acz014_add = 3810,
		prc001_white = 3811,
		prc001_white_loop = 3812,
		prc001_blue = 3813,
		prc001_blue_loop = 3814,
		prc001_yellow = 3815,
		prc001_yellow_loop = 3816,
		prc001_green = 3817,
		prc001_green_loop = 3818,
		prc001_purple = 3819,
		prc001_purple_loop = 3820,
		prc001_rainbow = 3821,
		prc001_rainbow_loop = 3822,
		prc002_white = 3823,
		prc002_blue = 3824,
		prc002_yellow = 3825,
		prc002_green = 3826,
		prc002_purple = 3827,
		prc002_rainbow = 3828,
		prc003 = 3829,
		prc003_loop = 3830,
		prc003_add = 3831,
		prc001_red = 3832,
		prc001_red_loop = 3833,
		prc002_red = 3834,
		cmn043 = 3835,
		cmn043_loop = 3836,
		push = 3837,
		push_loop = 3838,
		push_add = 3839,
		push_hit = 3840,
		push_hit_add = 3841,
		push_ng = 3842,
		push_b = 3843,
		push_b_loop = 3844,
		push_b_add = 3845,
		push_b_hit = 3846,
		push_b_hit_add = 3847,
		push_b_ng = 3848,
		push_c = 3849,
		push_c_loop = 3850,
		push_c_add = 3851,
		push_c_hit = 3852,
		push_c_hit_add = 3853,
		push_c_ng = 3854,
		push_w = 3855,
		push_w_loop = 3856,
		push_w_add = 3857,
		push_w_hit = 3858,
		push_w_hit_add = 3859,
		push_w_ng = 3860,
		push_p_hit = 3861,
		push_p_hit_add = 3862,
		cmn_sv_end = 3863,
		cmn_sv_end_loop = 3864,
		cmn_sv_End_0a = 3865,
		cmn_sv_end_1a = 3866,
		cmn_sv_end_2a = 3867,
		cmn_sv_end_3a = 3868,
		cmn_sv_end_4a = 3869,
		cmn_sv_end_5a = 3870,
		cmn_sv_end_6a = 3871,
		cmn_sv_end_7a = 3872,
		cmn_sv_end_8a = 3873,
		cmn_sv_end_9a = 3874,
		cmn_sv_end_0b = 3875,
		cmn_sv_end_1b = 3876,
		cmn_sv_end_2b = 3877,
		cmn_sv_end_3b = 3878,
		cmn_sv_end_4b = 3879,
		cmn_sv_end_5b = 3880,
		cmn_sv_end_6b = 3881,
		cmn_sv_end_7b = 3882,
		cmn_sv_end_8b = 3883,
		cmn_sv_end_9b = 3884,
		cmn_sv_end_add = 3885,
		standby = 3886
	}

	public enum SOUND
	{
		S0101 = 0,
		S0102 = 1,
		S0103 = 2,
		S0104 = 3,
		S0105 = 4,
		S0106 = 5,
		S0107 = 6,
		S0108 = 7,
		S0109 = 8,
		S0110 = 9,
		S0111 = 10,
		S0112 = 11,
		S0113 = 12,
		S0114 = 13,
		S0115 = 14,
		S0116 = 15,
		S0117 = 16,
		S0118 = 17,
		S0119 = 18,
		S0120 = 19,
		S0121 = 20,
		S0122 = 21,
		S0123 = 22,
		S0124 = 23,
		S0125 = 24,
		S0126 = 25,
		S0127 = 26,
		S0128 = 27,
		S0129 = 28,
		S0130 = 29,
		S0131 = 30,
		S0132 = 31,
		S0133 = 32,
		S0134 = 33,
		S0135 = 34,
		S0136 = 35,
		S0137 = 36,
		S0138 = 37,
		S0139 = 38,
		S0140 = 39,
		S0141 = 40,
		S0142 = 41,
		S0143 = 42,
		S0144 = 43,
		S0145 = 44,
		S0146 = 45,
		S0147 = 46,
		S0148 = 47,
		S0149 = 48,
		S0150 = 49,
		S0152 = 50,
		S0153 = 51,
		S0154 = 52,
		S0155 = 53,
		S0157 = 54,
		S0159 = 55,
		S0160 = 56,
		S0161 = 57,
		S0162 = 58,
		S0163 = 59,
		S0164 = 60,
		S0165 = 61,
		S0166 = 62,
		S0167 = 63,
		S0168 = 64,
		S0169 = 65,
		S0170 = 66,
		S0171 = 67,
		S0172 = 68,
		S0173 = 69,
		S0174 = 70,
		S0175 = 71,
		S0176 = 72,
		S0177 = 73,
		S0178 = 74,
		S0180 = 75,
		S0181 = 76,
		S0182 = 77,
		S0183 = 78,
		S0184 = 79,
		S0185 = 80,
		S0186 = 81,
		S0187 = 82,
		S0188 = 83,
		S0189 = 84,
		S0190 = 85,
		S0191 = 86,
		S0192 = 87,
		S0193 = 88,
		S0194 = 89,
		S0195 = 90,
		S0196 = 91,
		S0197 = 92,
		S0198 = 93,
		S0199 = 94,
		S0200 = 95,
		S0201 = 96,
		S0202 = 97,
		S0203 = 98,
		S0204 = 99,
		S0205 = 100,
		S0206 = 101,
		S0207 = 102,
		S0208 = 103,
		S3003 = 104,
		S0060 = 105,
		S0061 = 106,
		S0062 = 107,
		S0063 = 108,
		S0064 = 109,
		S0065 = 110,
		S0066 = 111,
		S0067 = 112,
		S0068 = 113,
		S0069 = 114,
		S0070 = 115,
		S0071 = 116,
		S0072 = 117,
		S0073 = 118,
		S0074 = 119,
		S0075 = 120,
		S0076 = 121,
		S0077 = 122,
		S0078 = 123,
		S0079 = 124,
		S0080 = 125,
		S0081 = 126,
		S0082 = 127,
		S0083 = 128,
		S0084 = 129,
		S0085 = 130,
		S0086 = 131,
		S0087 = 132,
		S0088 = 133,
		S0089 = 134,
		S0090 = 135,
		S0091 = 136,
		S0092 = 137,
		S0093 = 138,
		S0094 = 139,
		S0095 = 140,
		S0096 = 141,
		S0097 = 142,
		S0098 = 143,
		S0099 = 144,
		S0100 = 145,
		S0209 = 146,
		S0210 = 147,
		S0211 = 148,
		S0212 = 149,
		S0213 = 150,
		S0214 = 151,
		S0215 = 152,
		S0216 = 153,
		S0217 = 154,
		S0218 = 155,
		S0219 = 156,
		S0220 = 157,
		S0221 = 158,
		S0222 = 159,
		S0223 = 160,
		S0224 = 161,
		S0225 = 162,
		S0226 = 163,
		S0227 = 164,
		S0228 = 165,
		S0229 = 166,
		S0230 = 167,
		S0231 = 168,
		S0232 = 169,
		S0233 = 170,
		S0234 = 171,
		S0235 = 172,
		S0236 = 173,
		S0237 = 174,
		S0238 = 175,
		S0239 = 176,
		S0240 = 177,
		S0241 = 178,
		S0242 = 179,
		S0243 = 180,
		S0244 = 181,
		S0245 = 182,
		S0246 = 183,
		S0247 = 184,
		S0248 = 185,
		S0249 = 186,
		S0250 = 187,
		S0251 = 188,
		S0252 = 189,
		S0253 = 190,
		S0254 = 191,
		S0255 = 192,
		S0256 = 193,
		S0257 = 194,
		S0258 = 195,
		S0259 = 196,
		S0260 = 197,
		S0261 = 198,
		S0262 = 199,
		S0263 = 200,
		S0264 = 201,
		S0265 = 202,
		S0266 = 203,
		S0267 = 204,
		S0268 = 205,
		S0269 = 206,
		S0270 = 207,
		S0271 = 208,
		S0272 = 209,
		S0273 = 210,
		S0274 = 211,
		S0275 = 212,
		S0276 = 213,
		S0277 = 214,
		S0278 = 215,
		S0279 = 216,
		S0280 = 217,
		S0281 = 218,
		S0282 = 219,
		S0283 = 220,
		S0284 = 221,
		S0285 = 222,
		S0286 = 223,
		S0287 = 224,
		S0288 = 225,
		S0289 = 226,
		S0290 = 227,
		S0291 = 228,
		S0292 = 229,
		S0293 = 230,
		S0294 = 231,
		S0295 = 232,
		S0296 = 233,
		S0297 = 234,
		S0298 = 235,
		S0299 = 236,
		S0300 = 237,
		S0301 = 238,
		S0302 = 239,
		S0303 = 240,
		S0304 = 241,
		S0305 = 242,
		S0306 = 243,
		S0307 = 244,
		S0308 = 245,
		S0309 = 246,
		S0310 = 247,
		S0311 = 248,
		S0312 = 249,
		S0313 = 250,
		S0314 = 251,
		S0315 = 252,
		S0316 = 253,
		S0317 = 254,
		S0318 = 255,
		S0319 = 256,
		S0320 = 257,
		S0321 = 258,
		S0322 = 259,
		S0323 = 260,
		S0324 = 261,
		S0325 = 262,
		S0326 = 263,
		S0327 = 264,
		S0328 = 265,
		S0329 = 266,
		S0330 = 267,
		S0331 = 268,
		S0332 = 269,
		S0333 = 270,
		S0334 = 271,
		S0335 = 272,
		S0336 = 273,
		S0337 = 274,
		S0338 = 275,
		S0339 = 276,
		S0340 = 277,
		S0341 = 278,
		S0342 = 279,
		S0343 = 280,
		S0344 = 281,
		S0345 = 282,
		S0346 = 283,
		S0347 = 284,
		S0348 = 285,
		S0349 = 286,
		S0350 = 287,
		S0351 = 288,
		S0352 = 289,
		S0353 = 290,
		S0354 = 291,
		S0355 = 292,
		S0356 = 293,
		S0357 = 294,
		S0358 = 295,
		S0359 = 296,
		S0360 = 297,
		S0361 = 298,
		S0362 = 299,
		S0363 = 300,
		S0364 = 301,
		S0365 = 302,
		S0366 = 303,
		S0367 = 304,
		S0368 = 305,
		S0369 = 306,
		S0370 = 307,
		S0371 = 308,
		S0372 = 309,
		S0373 = 310,
		S0374 = 311,
		S0375 = 312,
		S0376 = 313,
		S0377 = 314,
		S0378 = 315,
		S0379 = 316,
		S0380 = 317,
		S0381 = 318,
		S0382 = 319,
		S0383 = 320,
		S0384 = 321,
		S0385 = 322,
		S0386 = 323,
		S0387 = 324,
		S0388 = 325,
		S0389 = 326,
		S0390 = 327,
		S0391 = 328,
		S0392 = 329,
		S0393 = 330,
		S0394 = 331,
		S0395 = 332,
		S0396 = 333,
		S0397 = 334,
		S0398 = 335,
		S0399 = 336,
		S0400 = 337,
		S0401 = 338,
		S0402 = 339,
		S0403 = 340,
		S0404 = 341,
		S0405 = 342,
		S0406 = 343,
		S0407 = 344,
		S0408 = 345,
		S0409 = 346,
		S0410 = 347,
		S0411 = 348,
		S0412 = 349,
		S0413 = 350,
		S0414 = 351,
		S0415 = 352,
		S0416 = 353,
		S0417 = 354,
		S0418 = 355,
		S0419 = 356,
		S0420 = 357,
		S0421 = 358,
		S0422 = 359,
		S0423 = 360,
		S0424 = 361,
		S0425 = 362,
		S0426 = 363,
		S0427 = 364,
		S0428 = 365,
		S0429 = 366,
		S0430 = 367,
		S0431 = 368,
		S0432 = 369,
		S0433 = 370,
		S0434 = 371,
		S0435 = 372,
		S0436 = 373,
		S0437 = 374,
		S0438 = 375,
		S0439 = 376,
		S0440 = 377,
		S0441 = 378,
		S0442 = 379,
		S0443 = 380,
		S0444 = 381,
		S0445 = 382,
		S0446 = 383,
		S0447 = 384,
		S0448 = 385,
		S0449 = 386,
		S0450 = 387,
		S0451 = 388,
		S0452 = 389,
		S0453 = 390,
		S0454 = 391,
		S0455 = 392,
		S0456 = 393,
		S0457 = 394,
		S0458 = 395,
		S0459 = 396,
		S0460 = 397,
		S0461 = 398,
		S0462 = 399,
		S0463 = 400,
		S0464 = 401,
		S0465 = 402,
		S0466 = 403,
		S0467 = 404,
		S0468 = 405,
		S0469 = 406,
		S0470 = 407,
		S0471 = 408,
		S0472 = 409,
		S0473 = 410,
		S0474 = 411,
		S0475 = 412,
		S0476 = 413,
		S0477 = 414,
		S0478 = 415,
		S0479 = 416,
		S0480 = 417,
		S0481 = 418,
		S0482 = 419,
		S0483 = 420,
		S0484 = 421,
		S0485 = 422,
		S0486 = 423,
		S0487 = 424,
		S0488 = 425,
		S0489 = 426,
		S0490 = 427,
		S0491 = 428,
		S0492 = 429,
		S0493 = 430,
		S0494 = 431,
		S0495 = 432,
		S0496 = 433,
		S0497 = 434,
		S0498 = 435,
		S0499 = 436,
		S0500 = 437,
		S0501 = 438,
		S0502 = 439,
		S0503 = 440,
		S0504 = 441,
		S0505 = 442,
		S0506 = 443,
		S0507 = 444,
		S0508 = 445,
		S0509 = 446,
		S0510 = 447,
		S0511 = 448,
		S0512 = 449,
		S0513 = 450,
		S0514 = 451,
		S0515 = 452,
		S0516 = 453,
		S0517 = 454,
		S0518 = 455,
		S0519 = 456,
		S0520 = 457,
		S0521 = 458,
		S0522 = 459,
		S0523 = 460,
		S0524 = 461,
		S0525 = 462,
		S0526 = 463,
		S0527 = 464,
		S0528 = 465,
		S0529 = 466,
		S0530 = 467,
		S0531 = 468,
		S0532 = 469,
		S0533 = 470,
		S0534 = 471,
		S0535 = 472,
		S0536 = 473,
		S0537 = 474,
		S0538 = 475,
		S0539 = 476,
		S0540 = 477,
		S0541 = 478,
		S0542 = 479,
		S0543 = 480,
		S0544 = 481,
		S0545 = 482,
		S0546 = 483,
		S0547 = 484,
		S0548 = 485,
		S0549 = 486,
		S0550 = 487,
		S0551 = 488,
		S0552 = 489,
		S0553 = 490,
		S0554 = 491,
		S0555 = 492,
		S0556 = 493,
		S0557 = 494,
		S0558 = 495,
		S0559 = 496,
		S0560 = 497,
		S0561 = 498,
		S0562 = 499,
		S0563 = 500,
		S0564 = 501,
		S0565 = 502,
		S0566 = 503,
		S0567 = 504,
		S0569 = 505,
		S0570 = 506,
		S0571 = 507,
		S0572 = 508,
		S0573 = 509,
		S0574 = 510,
		S0575 = 511,
		S0576 = 512,
		S0577 = 513,
		S0578 = 514,
		S0579 = 515,
		S0580 = 516,
		S0581 = 517,
		S0582 = 518,
		S0583 = 519,
		S0584 = 520,
		S0585 = 521,
		S0586 = 522,
		S0587 = 523,
		S0588 = 524,
		S0589 = 525,
		S0590 = 526,
		S0591 = 527,
		S0592 = 528,
		S0593 = 529,
		S0594 = 530,
		S0595 = 531,
		S0596 = 532,
		S0597 = 533,
		S0598 = 534,
		S0599 = 535,
		S0600 = 536,
		S0601 = 537,
		S0602 = 538,
		S0603 = 539,
		S0604 = 540,
		S0605 = 541,
		S0606 = 542,
		S0607 = 543,
		S0608 = 544,
		S0609 = 545,
		S0610 = 546,
		S0611 = 547,
		S0612 = 548,
		S0613 = 549,
		S0614 = 550,
		S0615 = 551,
		S0616 = 552,
		S0617 = 553,
		S0618 = 554,
		S0619 = 555,
		S0620 = 556,
		S0621 = 557,
		S0622 = 558,
		S0623 = 559,
		S0624 = 560,
		S0625 = 561,
		S0626 = 562,
		S0627 = 563,
		S0628 = 564,
		S0629 = 565,
		S0630 = 566,
		S0631 = 567,
		S0632 = 568,
		S0633 = 569,
		S0634 = 570,
		S0635 = 571,
		S0636 = 572,
		S0637 = 573,
		S0638 = 574,
		S0639 = 575,
		S0640 = 576,
		S0641 = 577,
		S0642 = 578,
		S0643 = 579,
		S0644 = 580,
		S0645 = 581,
		S0646 = 582,
		S0647 = 583,
		S0648 = 584,
		S0649 = 585,
		S0650 = 586,
		S0651 = 587,
		S0652 = 588,
		S0653 = 589,
		S0654 = 590,
		S0655 = 591,
		S0656 = 592,
		S0657 = 593,
		S0658 = 594,
		S0659 = 595,
		S0660 = 596,
		S0661 = 597,
		S0662 = 598,
		S0663 = 599,
		S0664 = 600,
		S0665 = 601,
		S0666 = 602,
		S0667 = 603,
		S0668 = 604,
		S0669 = 605,
		S0670 = 606,
		S0671 = 607,
		S0672 = 608,
		S0673 = 609,
		S0674 = 610,
		S0675 = 611,
		S0676 = 612,
		S0677 = 613,
		S0678 = 614,
		S0679 = 615,
		S0680 = 616,
		S0681 = 617,
		S0682 = 618,
		S0683 = 619,
		S0684 = 620,
		S0685 = 621,
		S0686 = 622,
		S0687 = 623,
		S0688 = 624,
		S0689 = 625,
		S1400 = 626,
		S1401 = 627,
		S1402 = 628,
		S1403 = 629,
		S1404 = 630,
		S1405 = 631,
		S1406 = 632,
		S1407 = 633,
		S1408 = 634,
		S1409 = 635,
		S1448 = 636,
		S1449 = 637,
		S1450 = 638,
		S1451 = 639,
		S1452 = 640,
		S1453 = 641,
		S1454 = 642,
		S1455 = 643,
		S1456 = 644,
		S1457 = 645,
		S1458 = 646,
		S1459 = 647,
		S1504 = 648,
		S1505 = 649,
		S1506 = 650,
		S1507 = 651,
		S1508 = 652,
		S1509 = 653,
		S1553 = 654,
		S1554 = 655,
		S1555 = 656,
		S1556 = 657,
		S1557 = 658,
		S1558 = 659,
		S1648 = 660,
		S1649 = 661,
		S1692 = 662,
		S1693 = 663,
		S1694 = 664,
		S1695 = 665,
		S1696 = 666,
		S1697 = 667,
		S1698 = 668,
		S1699 = 669,
		S2047 = 670,
		S0690 = 671,
		S0691 = 672,
		S0692 = 673,
		S0693 = 674,
		S0694 = 675,
		S0695 = 676,
		S0696 = 677,
		S0697 = 678,
		S0698 = 679,
		S0699 = 680,
		S0700 = 681,
		S0701 = 682,
		S0702 = 683,
		S0703 = 684,
		S0704 = 685,
		S0705 = 686,
		S0706 = 687,
		S0707 = 688,
		S0708 = 689,
		S0709 = 690,
		S0710 = 691,
		S0711 = 692,
		S0712 = 693,
		S0713 = 694,
		S0714 = 695,
		S0715 = 696,
		S0716 = 697,
		S0717 = 698,
		S0718 = 699,
		S0719 = 700,
		S0720 = 701,
		S0721 = 702,
		S0722 = 703,
		S0723 = 704,
		S0724 = 705,
		S0725 = 706,
		S0726 = 707,
		S0727 = 708,
		S0728 = 709,
		S0729 = 710,
		S0730 = 711,
		S0731 = 712,
		S0732 = 713,
		S0733 = 714,
		S0734 = 715,
		S0735 = 716,
		S0736 = 717,
		S0737 = 718,
		S0738 = 719,
		S0739 = 720,
		S0740 = 721,
		S0741 = 722,
		S0742 = 723,
		S0743 = 724,
		S0744 = 725,
		S0745 = 726,
		S0746 = 727,
		S0747 = 728,
		S0748 = 729,
		S0749 = 730,
		S0750 = 731,
		S0751 = 732,
		S0752 = 733,
		S0753 = 734,
		S0754 = 735,
		S0755 = 736,
		S0756 = 737,
		S0757 = 738,
		S0758 = 739,
		S0759 = 740,
		S0760 = 741,
		S0761 = 742,
		S0762 = 743,
		S0763 = 744,
		S0764 = 745,
		S0765 = 746,
		S0766 = 747,
		S0767 = 748,
		S0768 = 749,
		S0769 = 750,
		S0770 = 751,
		S0771 = 752,
		S0772 = 753,
		S0773 = 754,
		S0774 = 755,
		S0775 = 756,
		S0776 = 757,
		S0777 = 758,
		S0778 = 759,
		S0779 = 760,
		S0780 = 761,
		S0781 = 762,
		S0782 = 763,
		S0783 = 764,
		S0784 = 765,
		S0785 = 766,
		S0786 = 767,
		S0787 = 768,
		S0788 = 769,
		S0789 = 770,
		S0790 = 771,
		S0791 = 772,
		S0792 = 773,
		S0793 = 774,
		S0794 = 775,
		S0795 = 776,
		S0796 = 777,
		S0797 = 778,
		S0798 = 779,
		S0799 = 780,
		S0800 = 781,
		S0801 = 782,
		S0802 = 783,
		S0803 = 784,
		S0804 = 785,
		S0805 = 786,
		S0806 = 787,
		S0807 = 788,
		S0808 = 789,
		S0809 = 790,
		S0810 = 791,
		S0811 = 792,
		S0812 = 793,
		S0813 = 794,
		S0814 = 795,
		S0815 = 796,
		S0816 = 797,
		S0817 = 798,
		S0818 = 799,
		S0819 = 800,
		S0820 = 801,
		S0821 = 802,
		S0822 = 803,
		S0823 = 804,
		S0824 = 805,
		S0825 = 806,
		S0826 = 807,
		S0827 = 808,
		S0828 = 809,
		S0829 = 810,
		S0830 = 811,
		S0831 = 812,
		S0832 = 813,
		S0833 = 814,
		S0834 = 815,
		S0835 = 816,
		S0836 = 817,
		S0837 = 818,
		S0838 = 819,
		S0839 = 820,
		S0840 = 821,
		S0841 = 822,
		S0842 = 823,
		S0843 = 824,
		S0844 = 825,
		S0845 = 826,
		S0846 = 827,
		S0847 = 828,
		S0848 = 829,
		S0849 = 830,
		S0850 = 831,
		S0851 = 832,
		S0852 = 833,
		S0853 = 834,
		S0854 = 835,
		S0855 = 836,
		S0856 = 837,
		S0857 = 838,
		S0858 = 839,
		S0859 = 840,
		S0860 = 841,
		S0861 = 842,
		S0862 = 843,
		S0863 = 844,
		S0864 = 845,
		S0865 = 846,
		S0866 = 847,
		S0867 = 848,
		S0868 = 849,
		S0869 = 850,
		S0870 = 851,
		S0871 = 852,
		S0872 = 853,
		S0873 = 854,
		S0874 = 855,
		S0875 = 856,
		S0876 = 857,
		S0877 = 858,
		S0878 = 859,
		S0879 = 860,
		S0880 = 861,
		S0881 = 862,
		S0882 = 863,
		S0883 = 864,
		S0884 = 865,
		S0885 = 866,
		S0886 = 867,
		S0887 = 868,
		S0888 = 869,
		S0889 = 870,
		S0890 = 871,
		S0891 = 872,
		S0892 = 873,
		S0893 = 874,
		S0894 = 875,
		S0895 = 876,
		S0896 = 877,
		S0897 = 878,
		S0898 = 879,
		S0899 = 880,
		S0900 = 881,
		S0901 = 882,
		S0902 = 883,
		S0903 = 884,
		S0904 = 885,
		S0905 = 886,
		S0906 = 887,
		S0907 = 888,
		S0908 = 889,
		S0909 = 890,
		S0910 = 891,
		S0911 = 892,
		S0912 = 893,
		S0913 = 894,
		S0914 = 895,
		S0915 = 896,
		S0916 = 897,
		S0917 = 898,
		S0918 = 899,
		S0919 = 900,
		S0920 = 901,
		S0921 = 902,
		S0922 = 903,
		S0923 = 904,
		S0924 = 905,
		S0925 = 906,
		S0926 = 907,
		S0927 = 908,
		S0928 = 909,
		S0929 = 910,
		S0930 = 911,
		S0931 = 912,
		S0932 = 913,
		S0933 = 914,
		S0934 = 915,
		S0935 = 916,
		S0936 = 917,
		S0937 = 918,
		S0938 = 919,
		S0939 = 920,
		S0940 = 921,
		S0941 = 922,
		S0942 = 923,
		S0943 = 924,
		S0944 = 925,
		S0945 = 926,
		S0946 = 927,
		S0947 = 928,
		S0948 = 929,
		S0949 = 930,
		S0950 = 931,
		S0951 = 932,
		S0952 = 933,
		S0953 = 934,
		S0954 = 935,
		S0955 = 936,
		S0956 = 937,
		S0957 = 938,
		S0958 = 939,
		S0959 = 940,
		S0960 = 941,
		S0961 = 942,
		S0962 = 943,
		S0963 = 944,
		S0964 = 945,
		S0965 = 946,
		S0966 = 947,
		S0967 = 948,
		S0968 = 949,
		S0969 = 950,
		S0970 = 951,
		S0971 = 952,
		S0972 = 953,
		S0973 = 954,
		S0974 = 955,
		S0975 = 956,
		S0976 = 957,
		S0977 = 958,
		S0978 = 959,
		S0979 = 960,
		S0980 = 961,
		S0981 = 962,
		S0982 = 963,
		S0983 = 964,
		S0984 = 965,
		S0985 = 966,
		S0986 = 967,
		S0987 = 968,
		S0988 = 969,
		S0989 = 970,
		S0990 = 971,
		S0991 = 972,
		S0992 = 973,
		S0993 = 974,
		S0994 = 975,
		S0995 = 976,
		S0996 = 977,
		S0997 = 978,
		S0998 = 979,
		S0999 = 980,
		S1000 = 981,
		S1001 = 982,
		S1002 = 983,
		S1003 = 984,
		S1004 = 985,
		S1005 = 986,
		S1006 = 987,
		S1007 = 988,
		S1008 = 989,
		S1009 = 990,
		S1010 = 991,
		S1011 = 992,
		S1012 = 993,
		S1013 = 994,
		S1014 = 995,
		S1015 = 996,
		S1016 = 997,
		S1017 = 998,
		S1018 = 999,
		S1019 = 1000,
		S1020 = 1001,
		S1021 = 1002,
		S1022 = 1003,
		S1023 = 1004,
		S1024 = 1005,
		S1025 = 1006,
		S1026 = 1007,
		S1027 = 1008,
		S1028 = 1009,
		S1029 = 1010,
		S1030 = 1011,
		S1031 = 1012,
		S1032 = 1013,
		S1033 = 1014,
		S1034 = 1015,
		S1035 = 1016,
		S1036 = 1017,
		S1037 = 1018,
		S1038 = 1019,
		S1039 = 1020,
		S1040 = 1021,
		S1041 = 1022,
		S1042 = 1023,
		S1043 = 1024,
		S1044 = 1025,
		S1045 = 1026,
		S1046 = 1027,
		S1047 = 1028,
		S1048 = 1029,
		S1049 = 1030,
		S1050 = 1031,
		S1051 = 1032,
		S1052 = 1033,
		S1053 = 1034,
		S1054 = 1035,
		S1055 = 1036,
		S1056 = 1037,
		S1057 = 1038,
		S1058 = 1039,
		S1059 = 1040,
		S1060 = 1041,
		S1061 = 1042,
		S1062 = 1043,
		S1063 = 1044,
		S1064 = 1045,
		S1065 = 1046,
		S1066 = 1047,
		S1067 = 1048,
		S1068 = 1049,
		S1069 = 1050,
		S1070 = 1051,
		S1071 = 1052,
		S1072 = 1053,
		S1073 = 1054,
		S1074 = 1055,
		S1075 = 1056,
		S1076 = 1057,
		S1077 = 1058,
		S1078 = 1059,
		S1079 = 1060,
		S1080 = 1061,
		S1081 = 1062,
		S1082 = 1063,
		S1083 = 1064,
		S1084 = 1065,
		S1085 = 1066,
		S1086 = 1067,
		S1087 = 1068,
		S1088 = 1069,
		S1089 = 1070,
		S1090 = 1071,
		S1091 = 1072,
		S1092 = 1073,
		S1093 = 1074,
		S1094 = 1075,
		S1095 = 1076,
		S1096 = 1077,
		S1097 = 1078,
		S1098 = 1079,
		S1099 = 1080,
		S1100 = 1081,
		S1101 = 1082,
		S1102 = 1083,
		S1103 = 1084,
		S1104 = 1085,
		S1105 = 1086,
		S1106 = 1087,
		S1107 = 1088,
		S1108 = 1089,
		S1109 = 1090,
		S1110 = 1091,
		S1111 = 1092,
		S1112 = 1093,
		S1113 = 1094,
		S1114 = 1095,
		S1115 = 1096,
		S1116 = 1097,
		S1117 = 1098,
		S1118 = 1099,
		S1119 = 1100,
		S1120 = 1101,
		S1121 = 1102,
		S1122 = 1103,
		S1123 = 1104,
		S1124 = 1105,
		S1125 = 1106,
		S1126 = 1107,
		S1127 = 1108,
		S1128 = 1109,
		S1129 = 1110,
		S1130 = 1111,
		S1131 = 1112,
		S1132 = 1113,
		S1133 = 1114,
		S1134 = 1115,
		S1135 = 1116,
		S1136 = 1117,
		S1137 = 1118,
		S1138 = 1119,
		S1139 = 1120,
		S1140 = 1121,
		S1141 = 1122,
		S1142 = 1123,
		S1143 = 1124,
		S1144 = 1125,
		S1145 = 1126,
		S1146 = 1127,
		S1147 = 1128,
		S1148 = 1129,
		S1149 = 1130,
		S1150 = 1131,
		S1151 = 1132,
		S1152 = 1133,
		S1153 = 1134,
		S1154 = 1135,
		S1155 = 1136,
		S1156 = 1137,
		S1157 = 1138,
		S1158 = 1139,
		S1159 = 1140,
		S1160 = 1141,
		S1161 = 1142,
		S1162 = 1143,
		S1163 = 1144,
		S1164 = 1145,
		S1165 = 1146,
		S1166 = 1147,
		S1167 = 1148,
		S1168 = 1149,
		S1169 = 1150,
		S1170 = 1151,
		S1171 = 1152,
		S1172 = 1153,
		S1173 = 1154,
		S1174 = 1155,
		S1175 = 1156,
		S1176 = 1157,
		S1177 = 1158,
		S1178 = 1159,
		S1179 = 1160,
		S1180 = 1161,
		S1181 = 1162,
		S1182 = 1163,
		S1183 = 1164,
		S1184 = 1165,
		S1185 = 1166,
		S1186 = 1167,
		S1187 = 1168,
		S1188 = 1169,
		S1189 = 1170,
		S1190 = 1171,
		S1191 = 1172,
		S1192 = 1173,
		S1193 = 1174,
		S1194 = 1175,
		S1195 = 1176,
		S1196 = 1177,
		S1197 = 1178,
		S1198 = 1179,
		S1199 = 1180,
		S1200 = 1181,
		S1201 = 1182,
		S1202 = 1183,
		S1203 = 1184,
		S1204 = 1185,
		S1205 = 1186,
		S1206 = 1187,
		S1207 = 1188,
		S1208 = 1189,
		S1209 = 1190,
		S1210 = 1191,
		S1211 = 1192,
		S1212 = 1193,
		S1213 = 1194,
		S1214 = 1195,
		S1215 = 1196,
		S1216 = 1197,
		S1217 = 1198,
		S1218 = 1199,
		S1219 = 1200,
		S1220 = 1201,
		S1221 = 1202,
		S1222 = 1203,
		S1223 = 1204,
		S1224 = 1205,
		S1225 = 1206,
		S1226 = 1207,
		S1227 = 1208,
		S1228 = 1209,
		S1229 = 1210,
		S1230 = 1211,
		S1231 = 1212,
		S1232 = 1213,
		S1233 = 1214,
		S1234 = 1215,
		S1235 = 1216,
		S1236 = 1217,
		S1237 = 1218,
		S1238 = 1219,
		S1239 = 1220,
		S1240 = 1221,
		S1241 = 1222,
		S1242 = 1223,
		S1243 = 1224,
		S1244 = 1225,
		S1245 = 1226,
		S1246 = 1227,
		S1247 = 1228,
		S1248 = 1229,
		S1249 = 1230,
		S1250 = 1231,
		S1251 = 1232,
		S1252 = 1233,
		S1253 = 1234,
		S1254 = 1235,
		S1255 = 1236,
		S1256 = 1237,
		S1257 = 1238,
		S1258 = 1239,
		S1259 = 1240,
		S1260 = 1241,
		S1261 = 1242,
		S1262 = 1243,
		S1263 = 1244,
		S1264 = 1245,
		S1265 = 1246,
		S1266 = 1247,
		S1267 = 1248,
		S1268 = 1249,
		S1269 = 1250,
		S1270 = 1251,
		S1271 = 1252,
		S1272 = 1253,
		S1273 = 1254,
		S1274 = 1255,
		S1275 = 1256,
		S1276 = 1257,
		S1277 = 1258,
		S1278 = 1259,
		S1279 = 1260,
		S1280 = 1261,
		S1281 = 1262,
		S1282 = 1263,
		S1283 = 1264,
		S1284 = 1265,
		S1285 = 1266,
		S1286 = 1267,
		S1287 = 1268,
		S1288 = 1269,
		S1289 = 1270,
		S1290 = 1271,
		S1291 = 1272,
		S1292 = 1273,
		S1293 = 1274,
		S1294 = 1275,
		S1295 = 1276,
		S1296 = 1277,
		S1297 = 1278,
		S1298 = 1279,
		S1299 = 1280,
		S1300 = 1281,
		S1301 = 1282,
		S1302 = 1283,
		S1303 = 1284,
		S1304 = 1285,
		S1305 = 1286,
		S1306 = 1287,
		S1307 = 1288,
		S1308 = 1289,
		S1309 = 1290,
		S1310 = 1291,
		S1311 = 1292,
		S1312 = 1293,
		S1313 = 1294,
		S1314 = 1295,
		S1315 = 1296,
		S1316 = 1297,
		S1318 = 1298,
		S1319 = 1299,
		S1320 = 1300,
		S1321 = 1301,
		S1322 = 1302,
		S1323 = 1303,
		S1324 = 1304,
		S1325 = 1305,
		S1326 = 1306,
		S1327 = 1307,
		S1328 = 1308,
		S1329 = 1309,
		S1330 = 1310,
		S1331 = 1311,
		S1332 = 1312,
		S1333 = 1313,
		S1334 = 1314,
		S1335 = 1315,
		S1336 = 1316,
		S1337 = 1317,
		S1338 = 1318,
		S1339 = 1319,
		S1340 = 1320,
		S1341 = 1321,
		S1342 = 1322,
		S1343 = 1323,
		S1344 = 1324,
		S1345 = 1325,
		S1346 = 1326,
		S1347 = 1327,
		S1348 = 1328,
		S1349 = 1329,
		S1350 = 1330,
		S1351 = 1331,
		S1352 = 1332,
		S1353 = 1333,
		S1354 = 1334,
		S1355 = 1335,
		S1356 = 1336,
		S1357 = 1337,
		S1358 = 1338,
		S1359 = 1339,
		S1360 = 1340,
		S1361 = 1341,
		S1362 = 1342,
		S1363 = 1343,
		S1364 = 1344,
		S1365 = 1345,
		S1366 = 1346,
		S1367 = 1347,
		S1368 = 1348,
		S1369 = 1349,
		S1370 = 1350,
		S1371 = 1351,
		S1372 = 1352,
		S1373 = 1353,
		S1374 = 1354,
		S1375 = 1355,
		S1376 = 1356,
		S1377 = 1357,
		S1378 = 1358,
		S1379 = 1359,
		S1380 = 1360,
		S1381 = 1361,
		S1382 = 1362,
		S1383 = 1363,
		S1384 = 1364,
		S1385 = 1365,
		S1386 = 1366,
		S1387 = 1367,
		S1388 = 1368,
		S1389 = 1369,
		S1390 = 1370,
		S1391 = 1371,
		S1392 = 1372,
		S1393 = 1373,
		S1394 = 1374,
		S1395 = 1375,
		S1396 = 1376,
		S1397 = 1377,
		S1398 = 1378,
		S1399 = 1379,
		S1410 = 1380,
		S1411 = 1381,
		S1412 = 1382,
		S1413 = 1383,
		S1414 = 1384,
		S1415 = 1385,
		S1416 = 1386,
		S1417 = 1387,
		S1418 = 1388,
		S1419 = 1389,
		S1420 = 1390,
		S1421 = 1391,
		S1422 = 1392,
		S1423 = 1393,
		S1424 = 1394,
		S1425 = 1395,
		S1426 = 1396,
		S1427 = 1397,
		S1428 = 1398,
		S1429 = 1399,
		S1430 = 1400,
		S1431 = 1401,
		S1432 = 1402,
		S1433 = 1403,
		S1434 = 1404,
		S1435 = 1405,
		S1436 = 1406,
		S1437 = 1407,
		S1438 = 1408,
		S1439 = 1409,
		S1440 = 1410,
		S1441 = 1411,
		S1442 = 1412,
		S1443 = 1413,
		S1444 = 1414,
		S1445 = 1415,
		S1446 = 1416,
		S1447 = 1417,
		S1460 = 1418,
		S1461 = 1419,
		S1462 = 1420,
		S1463 = 1421,
		S1464 = 1422,
		S1465 = 1423,
		S1466 = 1424,
		S1467 = 1425,
		S1468 = 1426,
		S1469 = 1427,
		S1470 = 1428,
		S1471 = 1429,
		S1472 = 1430,
		S1473 = 1431,
		S1474 = 1432,
		S1475 = 1433,
		S1476 = 1434,
		S1477 = 1435,
		S1478 = 1436,
		S1479 = 1437,
		S1480 = 1438,
		S1481 = 1439,
		S1482 = 1440,
		S1483 = 1441,
		S1484 = 1442,
		S1485 = 1443,
		S1486 = 1444,
		S1487 = 1445,
		S1488 = 1446,
		S1489 = 1447,
		S1490 = 1448,
		S1491 = 1449,
		S1492 = 1450,
		S1493 = 1451,
		S1494 = 1452,
		S1495 = 1453,
		S1496 = 1454,
		S1497 = 1455,
		S1498 = 1456,
		S1499 = 1457,
		S1500 = 1458,
		S1501 = 1459,
		S1502 = 1460,
		S1503 = 1461,
		S1510 = 1462,
		S1511 = 1463,
		S1512 = 1464,
		S1513 = 1465,
		S1514 = 1466,
		S1515 = 1467,
		S1516 = 1468,
		S1517 = 1469,
		S1518 = 1470,
		S1519 = 1471,
		S1520 = 1472,
		S1521 = 1473,
		S1522 = 1474,
		S1523 = 1475,
		S1524 = 1476,
		S1525 = 1477,
		S1526 = 1478,
		S1527 = 1479,
		S1528 = 1480,
		S1529 = 1481,
		S1530 = 1482,
		S1531 = 1483,
		S1532 = 1484,
		S1533 = 1485,
		S1534 = 1486,
		S1535 = 1487,
		S1536 = 1488,
		S1537 = 1489,
		S1538 = 1490,
		S1539 = 1491,
		S1540 = 1492,
		S1541 = 1493,
		S1542 = 1494,
		S1543 = 1495,
		S1544 = 1496,
		S1545 = 1497,
		S1546 = 1498,
		S1547 = 1499,
		S1548 = 1500,
		S1549 = 1501,
		S1550 = 1502,
		S1551 = 1503,
		S1552 = 1504,
		S1560 = 1505,
		S1561 = 1506,
		S1562 = 1507,
		S1563 = 1508,
		S1564 = 1509,
		S1565 = 1510,
		S1566 = 1511,
		S1567 = 1512,
		S1568 = 1513,
		S1569 = 1514,
		S1570 = 1515,
		S1571 = 1516,
		S1572 = 1517,
		S1573 = 1518,
		S1574 = 1519,
		S1575 = 1520,
		S1576 = 1521,
		S1577 = 1522,
		S1578 = 1523,
		S1579 = 1524,
		S1580 = 1525,
		S1581 = 1526,
		S1582 = 1527,
		S1583 = 1528,
		S1584 = 1529,
		S1585 = 1530,
		S1586 = 1531,
		S1587 = 1532,
		S1588 = 1533,
		S1589 = 1534,
		S1590 = 1535,
		S1591 = 1536,
		S1600 = 1537,
		S1601 = 1538,
		S1602 = 1539,
		S1603 = 1540,
		S1604 = 1541,
		S1605 = 1542,
		S1606 = 1543,
		S1607 = 1544,
		S1608 = 1545,
		S1609 = 1546,
		S1610 = 1547,
		S1611 = 1548,
		S1612 = 1549,
		S1613 = 1550,
		S1614 = 1551,
		S1615 = 1552,
		S1616 = 1553,
		S1617 = 1554,
		S1618 = 1555,
		S1619 = 1556,
		S1620 = 1557,
		S1621 = 1558,
		S1622 = 1559,
		S1623 = 1560,
		S1624 = 1561,
		S1625 = 1562,
		S1626 = 1563,
		S1627 = 1564,
		S1628 = 1565,
		S1629 = 1566,
		S1630 = 1567,
		S1631 = 1568,
		S1632 = 1569,
		S1633 = 1570,
		S1634 = 1571,
		S1635 = 1572,
		S1636 = 1573,
		S1637 = 1574,
		S1650 = 1575,
		S1651 = 1576,
		S1652 = 1577,
		S1653 = 1578,
		S1654 = 1579,
		S1655 = 1580,
		S1656 = 1581,
		S1657 = 1582,
		S1658 = 1583,
		S1659 = 1584,
		S1660 = 1585,
		S1661 = 1586,
		S1662 = 1587,
		S1663 = 1588,
		S1664 = 1589,
		S1665 = 1590,
		S1666 = 1591,
		S1667 = 1592,
		S1668 = 1593,
		S1669 = 1594,
		S1670 = 1595,
		S1671 = 1596,
		S1672 = 1597,
		S1673 = 1598,
		S1674 = 1599,
		S1675 = 1600,
		S1676 = 1601,
		S1677 = 1602,
		S1678 = 1603,
		S1679 = 1604,
		S1680 = 1605,
		S1681 = 1606,
		S1682 = 1607,
		S1683 = 1608,
		S1684 = 1609,
		S1685 = 1610,
		S1686 = 1611,
		S1687 = 1612,
		S1688 = 1613,
		S1689 = 1614,
		S1690 = 1615,
		S1691 = 1616,
		S1700 = 1617,
		S1701 = 1618,
		S1702 = 1619,
		S1703 = 1620,
		S1704 = 1621,
		S1705 = 1622,
		S1706 = 1623,
		S1707 = 1624,
		S1708 = 1625,
		S1709 = 1626,
		S1710 = 1627,
		S1711 = 1628,
		S1712 = 1629,
		S1713 = 1630,
		S1714 = 1631,
		S1715 = 1632,
		S1716 = 1633,
		S1717 = 1634,
		S1718 = 1635,
		S1719 = 1636,
		S1720 = 1637,
		S1721 = 1638,
		S1722 = 1639,
		S1723 = 1640,
		S1724 = 1641,
		S1725 = 1642,
		S1726 = 1643,
		S1727 = 1644,
		S1728 = 1645,
		S1729 = 1646,
		S1730 = 1647,
		S1731 = 1648,
		S1732 = 1649,
		S1733 = 1650,
		S1734 = 1651,
		S1735 = 1652,
		S1736 = 1653,
		S1737 = 1654,
		S1738 = 1655,
		S1739 = 1656,
		S1740 = 1657,
		S1741 = 1658,
		S1742 = 1659,
		S1743 = 1660,
		S1744 = 1661,
		S1745 = 1662,
		S1746 = 1663,
		S1747 = 1664,
		S1748 = 1665,
		S1749 = 1666,
		S1750 = 1667,
		S1751 = 1668,
		S1752 = 1669,
		S1753 = 1670,
		S1754 = 1671,
		S1755 = 1672,
		S1756 = 1673,
		S1757 = 1674,
		S1758 = 1675,
		S1759 = 1676,
		S1760 = 1677,
		S1761 = 1678,
		S1762 = 1679,
		S1763 = 1680,
		S1764 = 1681,
		S1765 = 1682,
		S1766 = 1683,
		S1767 = 1684,
		S1768 = 1685,
		S1769 = 1686,
		S1770 = 1687,
		S1771 = 1688,
		S1772 = 1689,
		S1773 = 1690,
		S1774 = 1691,
		S1775 = 1692,
		S1776 = 1693,
		S1777 = 1694,
		S1778 = 1695,
		S1779 = 1696,
		S1780 = 1697,
		S1781 = 1698,
		S1782 = 1699,
		S1783 = 1700,
		S1784 = 1701,
		S1785 = 1702,
		S1786 = 1703,
		S1787 = 1704,
		S1788 = 1705,
		S1789 = 1706,
		S1790 = 1707,
		S1791 = 1708,
		S1792 = 1709,
		S1793 = 1710,
		S1794 = 1711,
		S1795 = 1712,
		S1796 = 1713,
		S1797 = 1714,
		S1798 = 1715,
		S1799 = 1716,
		S1800 = 1717,
		S1801 = 1718,
		S1802 = 1719,
		S1803 = 1720,
		S1804 = 1721,
		S1805 = 1722,
		S1806 = 1723,
		S1807 = 1724,
		S1808 = 1725,
		S1810 = 1726,
		S1811 = 1727,
		S1812 = 1728,
		S1813 = 1729,
		S1814 = 1730,
		S1815 = 1731,
		S1816 = 1732,
		S1817 = 1733,
		S1818 = 1734,
		S1819 = 1735,
		S1820 = 1736,
		S1821 = 1737,
		S1822 = 1738,
		S1823 = 1739,
		S1824 = 1740,
		S1825 = 1741,
		S1826 = 1742,
		S1827 = 1743,
		S1828 = 1744,
		S1829 = 1745,
		S1830 = 1746,
		S1831 = 1747,
		S1832 = 1748,
		S1833 = 1749,
		S1834 = 1750,
		S1835 = 1751,
		S1836 = 1752,
		S1837 = 1753,
		S1838 = 1754,
		S1839 = 1755,
		S1840 = 1756,
		S1841 = 1757,
		S1842 = 1758,
		S1843 = 1759,
		S1844 = 1760,
		S1845 = 1761,
		S1846 = 1762,
		S1847 = 1763,
		S1848 = 1764,
		S1849 = 1765,
		S1850 = 1766,
		S1851 = 1767,
		S1852 = 1768,
		S1853 = 1769,
		S1854 = 1770,
		S1855 = 1771,
		S1856 = 1772,
		S1857 = 1773,
		S1858 = 1774,
		S1859 = 1775,
		S1860 = 1776,
		S1861 = 1777,
		S1862 = 1778,
		S1870 = 1779,
		S1871 = 1780,
		S1872 = 1781,
		S1873 = 1782,
		S1874 = 1783,
		S1875 = 1784,
		S1876 = 1785,
		S1877 = 1786,
		S1878 = 1787,
		S1879 = 1788,
		S1880 = 1789,
		S1881 = 1790,
		S1882 = 1791,
		S1883 = 1792,
		S1884 = 1793,
		S1885 = 1794,
		S1886 = 1795,
		S1887 = 1796,
		S1888 = 1797,
		S1889 = 1798,
		S1890 = 1799,
		S1891 = 1800,
		S1892 = 1801,
		S1893 = 1802,
		S1894 = 1803,
		S1895 = 1804,
		S1896 = 1805,
		S1897 = 1806,
		S1898 = 1807,
		S1899 = 1808,
		S1900 = 1809,
		S1901 = 1810,
		S1902 = 1811,
		S1903 = 1812,
		S1904 = 1813,
		S1905 = 1814,
		S1910 = 1815,
		S1911 = 1816,
		S1912 = 1817,
		S1913 = 1818,
		S1914 = 1819,
		S1915 = 1820,
		S1916 = 1821,
		S1917 = 1822,
		S1918 = 1823,
		S1919 = 1824,
		S1920 = 1825,
		S1921 = 1826,
		S1922 = 1827,
		S1923 = 1828,
		S1924 = 1829,
		S1925 = 1830,
		S1926 = 1831,
		S1927 = 1832,
		S1928 = 1833,
		S1929 = 1834,
		S1930 = 1835,
		S1931 = 1836,
		S1932 = 1837,
		S1940 = 1838,
		S1941 = 1839,
		S1942 = 1840,
		S1943 = 1841,
		S1944 = 1842,
		S1945 = 1843,
		S1946 = 1844,
		S1947 = 1845,
		S1948 = 1846,
		S1949 = 1847,
		S1950 = 1848,
		S1951 = 1849,
		S1952 = 1850,
		S1953 = 1851,
		S1954 = 1852,
		S1955 = 1853,
		S1956 = 1854,
		S1957 = 1855,
		S1958 = 1856,
		S1959 = 1857,
		S1960 = 1858,
		S1961 = 1859,
		S1962 = 1860,
		S1963 = 1861,
		S1964 = 1862,
		S1965 = 1863,
		S1966 = 1864,
		S1967 = 1865,
		S1968 = 1866,
		S1969 = 1867,
		S1970 = 1868,
		S1971 = 1869,
		S1972 = 1870,
		S1973 = 1871,
		S1974 = 1872,
		S1975 = 1873,
		S1976 = 1874,
		S1977 = 1875,
		S1978 = 1876,
		S1979 = 1877,
		S1980 = 1878,
		S1981 = 1879,
		S1982 = 1880,
		S1983 = 1881,
		S1984 = 1882,
		S1985 = 1883,
		S1986 = 1884,
		S1987 = 1885,
		S1988 = 1886,
		S1989 = 1887,
		S1990 = 1888,
		S1991 = 1889,
		S1992 = 1890,
		S1993 = 1891,
		S2000 = 1892,
		S2001 = 1893,
		S2002 = 1894,
		S2003 = 1895,
		S2004 = 1896,
		S2005 = 1897,
		S2006 = 1898,
		S2007 = 1899,
		S2008 = 1900,
		S2009 = 1901,
		S2010 = 1902,
		S2011 = 1903,
		S2012 = 1904,
		S2013 = 1905,
		S2014 = 1906,
		S2015 = 1907,
		S2016 = 1908,
		S2017 = 1909,
		S2018 = 1910,
		S2019 = 1911,
		S2020 = 1912,
		S2021 = 1913,
		S2022 = 1914,
		S2023 = 1915,
		S2024 = 1916,
		S2025 = 1917,
		S2026 = 1918,
		S2027 = 1919,
		S2028 = 1920,
		S2029 = 1921,
		S2030 = 1922,
		S2031 = 1923,
		S2032 = 1924,
		S2033 = 1925,
		S2034 = 1926,
		S2035 = 1927,
		S2036 = 1928,
		S2037 = 1929,
		S2038 = 1930,
		S2039 = 1931,
		S2040 = 1932,
		S2041 = 1933,
		S2042 = 1934
	}

	public enum ANIME
	{
		HNV001_a = 0,
		HNV001_b = 1,
		HNV001_c = 2,
		HNV001_d = 3,
		HNV002_a = 4,
		HNV002_b = 5,
		HNV002_c = 6,
		HNV002_d = 7,
		HNV003_a = 8,
		HNV003_b = 9,
		HNV003_c = 10,
		HNV004_a = 11,
		HNV004_b = 12,
		HNV005_a = 13,
		HNV005_b = 14,
		HNV005_c = 15,
		HNV005_d = 16,
		HNV006_a = 17,
		HNV006_b = 18,
		HNV006_c = 19,
		HNV006_d = 20,
		standby = 21,
		HNV002_a01 = 22,
		HNV003_b02 = 23,
		HNV004_c03 = 24,
		YFC002 = 25,
		YFC003 = 26,
		YFC004 = 27,
		DNV001_a = 28,
		DNV001_b = 29,
		DNV001_c = 30,
		DNV001_d = 31,
		DNV002_a = 32,
		DNV002_b = 33,
		DNV002_c = 34,
		DNV002_d = 35,
		KWS002a = 36,
		KWS002b = 37,
		KWS004 = 38,
		KWS005 = 39,
		ANV001_a01 = 40,
		ANV001_a01_loop = 41,
		ANV001_b02 = 42,
		ANV001_b02_loop = 43,
		ANV001_c03 = 44,
		ANV002_a01 = 45,
		ANV003_b02 = 46,
		ANV004_c03 = 47,
		ANV005 = 48,
		KWS001W = 49,
		KWS005W = 50,
		MAX = 51
	}

	public byte[] m_High;

	public byte[] m_Low;

	public byte[] m_Mode;

	public DirectionBase[] dir = new DirectionBase[25];

	public DIR nowDir = DIR.BET;

	public int nowDirNum = 6;

	public byte nowHaikei = 3;

	public byte betHaikeiReset;

	public int bks_cnt;

	public byte bks_mode;

	public byte m_stageHigh = byte.MaxValue;

	public byte m_stageLow = byte.MaxValue;

	public byte m_stageMode = byte.MaxValue;

	public byte m_ytkHigh = byte.MaxValue;

	public byte m_ytkLow = byte.MaxValue;

	public byte m_ytkMode = byte.MaxValue;

	public DirectionManager(Production _prod, Sound _sound)
	{
		for (int i = 0; i < 25; i++)
		{
			dir[i] = null;
		}
		m_High = new byte[25];
		m_Low = new byte[25];
		m_Mode = new byte[25];
		for (int j = 0; j < 25; j++)
		{
			m_High[j] = 0;
			m_Low[j] = 0;
			m_Mode[j] = 0;
		}
		bks_cnt = 0;
		bks_mode = 0;
	}

	public void InitDirection()
	{
		for (int i = 0; i < 25; i++)
		{
			if (i != 14 && i != 17 && i != 19 && i != 20 && i != 21)
			{
				dir[i] = null;
			}
		}
		for (int j = 0; j < 25; j++)
		{
			if (j != 14 && j != 17 && j != 19 && j != 20 && j != 21)
			{
				m_High[j] = 0;
				m_Low[j] = 0;
				m_Mode[j] = 0;
			}
		}
	}

	private void DebugLeverOn()
	{
	}

	private void DebugRewrite(int id)
	{
		if (id <= 6)
		{
		}
	}

	public void makeDirection(DIR kind, byte high, byte low, byte mode)
	{
		if (kind >= DIR.MAX || kind < DIR.LEVER)
		{
			return;
		}
		if (high == 3 || high == 5 || high == 18 || high == 23 || high == 32 || high == 59 || high == 89)
		{
			nowHaikei = high;
			StopDirectionStage(kind, high, low, mode);
		}
		if ((MainGameScene.slotGameMan.get_pkd_data(86) == 5 || MainGameScene.slotGameMan.get_pkd_data(86) == 6) && (high == 37 || high == 3))
		{
			return;
		}
		bool flag = false;
		switch (high)
		{
		case 1:
			dir[(int)kind] = new Direction1MJM(this, high, low, mode, kind);
			flag = false;
			break;
		case 2:
			stopYFC();
			stopStage();
			dir[(int)kind] = new Direction2MGO(this, high, low, mode, kind);
			flag = false;
			break;
		case 3:
			dir[14] = new Direction3MST(this, high, low, mode, kind);
			flag = true;
			break;
		case 4:
			dir[(int)kind] = new Direction4KKZ(this, high, low, mode, kind);
			flag = false;
			break;
		case 5:
			dir[14] = new Direction5CST(this, high, low, mode, kind);
			flag = true;
			break;
		case 6:
			dir[(int)kind] = new Direction6CKH(this, high, low, mode, kind);
			flag = false;
			break;
		case 7:
			stopYFC();
			stopStage();
			forceKillStageMovies();
			dir[(int)kind] = new Direction7HSL(this, high, low, mode, kind);
			flag = false;
			break;
		case 10:
			if (nowHaikei == 3)
			{
				if (mode >= 1 && mode <= 7)
				{
					betHaikeiReset = 4;
				}
				dir[16] = new Direction10MHK(this, high, low, mode, kind);
				dir[16].start();
				flag = true;
			}
			break;
		case 11:
			dir[(int)kind] = new Direction11MTH(this, high, low, mode, kind);
			flag = false;
			break;
		case 12:
			stopYFC();
			stopStage();
			dir[(int)kind] = new Direction12CMB(this, high, low, mode, kind);
			flag = false;
			break;
		case 13:
			stopStage();
			dir[(int)kind] = new Direction13KPR(this, high, low, mode, kind);
			flag = false;
			break;
		case 14:
			dir[(int)kind] = new Direction14MAP(this, high, low, mode, kind);
			flag = false;
			break;
		case 15:
			stopStage();
			dir[(int)kind] = new Direction15KGR(this, high, low, mode, kind);
			flag = false;
			break;
		case 16:
			stopYFC();
			stopStage();
			forceKillStageMovies();
			dir[(int)kind] = new Direction16KBS(this, high, low, mode, kind);
			flag = false;
			break;
		case 17:
			if (mode == 16)
			{
				dir[(int)kind] = new Direction17KCI(this, high, 1, 7, kind);
			}
			else
			{
				dir[(int)kind] = new Direction17KCI(this, high, low, mode, kind);
			}
			flag = false;
			break;
		case 18:
			dir[14] = new Direction18JST(this, high, low, mode, kind);
			flag = true;
			break;
		case 19:
			dir[(int)kind] = new Direction19JHS(this, high, low, mode, kind);
			flag = false;
			break;
		case 20:
			dir[(int)kind] = new Direction20JHK(this, high, low, mode, kind);
			flag = false;
			break;
		case 21:
			dir[(int)kind] = new Direction21JKA(this, high, low, mode, kind);
			flag = false;
			break;
		case 22:
			stopStage();
			dir[(int)kind] = new Direction22JKB(this, high, low, mode, kind);
			if (mode == 3)
			{
				nowHaikei = 3;
			}
			flag = false;
			break;
		case 23:
			dir[14] = new Direction23AST(this, high, low, mode, DIR.STAGE);
			flag = true;
			break;
		case 24:
			dir[(int)kind] = new Direction24ANV(this, high, low, mode, kind);
			flag = false;
			break;
		case 25:
			dir[(int)kind] = new Direction25ATH(this, high, low, mode, kind);
			flag = false;
			break;
		case 26:
			stopYFC();
			dir[(int)kind] = new Direction26ADR(this, high, low, mode, kind);
			flag = false;
			break;
		case 27:
			stopYFC();
			dir[(int)kind] = new Direction27AOH(this, high, low, mode, kind);
			flag = false;
			break;
		case 28:
			dir[(int)kind] = new Direction29HNV(this, high, low, mode, kind);
			flag = true;
			break;
		case 29:
			stopYFC();
			stopStage();
			dir[(int)kind] = new Direction30BI1(this, high, low, mode, kind);
			flag = false;
			break;
		case 30:
			stopYFC();
			stopStage();
			dir[(int)kind] = new Direction31BAO(this, high, low, mode, kind);
			flag = false;
			break;
		case 32:
			dir[14] = new Direction33DST(this, high, low, mode, DIR.STAGE);
			flag = true;
			break;
		case 33:
			dir[(int)kind] = new Direction34DGS(this, high, low, mode, kind);
			flag = true;
			break;
		case 34:
			dir[(int)kind] = new Direction35DHI(this, high, low, mode, kind);
			flag = false;
			break;
		case 35:
			dir[(int)kind] = new Direction36DNV(this, high, low, mode, kind);
			flag = true;
			break;
		case 37:
			switch (mode)
			{
			case 2:
			case 3:
				dir[(int)kind] = new Direction38IKG(this, high, low, mode, kind);
				break;
			case 7:
			case 11:
			case 13:
			case 14:
			case 15:
			case 16:
			case 17:
				dir[17] = new Direction38IKG(this, high, low, mode, DIR.STAGEPROD);
				dir[17].start();
				break;
			default:
				stopYFC();
				stopStage();
				forceKillStageMovies();
				StopDirectionStage(kind, high, low, mode);
				dir[14] = new Direction38IKG(this, high, low, mode, DIR.STAGE);
				dir[14].start();
				break;
			}
			flag = true;
			break;
		case 40:
			dir[(int)kind] = new Direction41ISS(this, high, low, mode, kind);
			flag = true;
			break;
		case 42:
			dir[(int)kind] = new Direction43KWS(this, high, low, mode, kind);
			flag = true;
			break;
		case 43:
			dir[(int)kind] = new Direction44KKT(this, high, low, mode, kind);
			flag = false;
			break;
		case 44:
			dir[(int)kind] = new Direction45KHO(this, high, low, mode, kind);
			flag = false;
			break;
		case 45:
			dir[(int)kind] = new Direction46KBU(this, high, low, mode, kind);
			flag = false;
			break;
		case 46:
			stopYFC();
			dir[(int)kind] = new Direction47KSY(this, high, low, mode, kind);
			flag = true;
			if (mode == 12 || mode == 18 || mode == 24)
			{
				stopStage();
				forceKillStageMovies();
				flag = false;
			}
			break;
		case 47:
			stopYFC();
			stopStage();
			dir[(int)kind] = new Direction48KOG(this, high, low, mode, kind);
			flag = false;
			break;
		case 48:
			stopYFC();
			stopStage();
			forceKillStageMovies();
			dir[(int)kind] = new Direction49HCP(this, high, low, mode, kind);
			flag = false;
			break;
		case 49:
			stopYFC();
			stopStage();
			forceKillStageMovies();
			dir[(int)kind] = new Direction50HML(this, high, low, mode, kind);
			flag = false;
			break;
		case 50:
			stopYFC();
			stopStage();
			forceKillStageMovies();
			dir[(int)kind] = new Direction51HBJ(this, high, low, mode, kind);
			flag = false;
			break;
		case 51:
			stopYFC();
			stopStage();
			forceKillStageMovies();
			dir[(int)kind] = new Direction52HZP(this, high, low, mode, kind);
			flag = false;
			break;
		case 52:
			dir[(int)kind] = new Direction53AGH(this, high, low, mode, kind);
			flag = true;
			break;
		case 54:
			dir[(int)kind] = new Direction55AIG(this, high, low, mode, kind);
			flag = false;
			break;
		case 55:
			dir[(int)kind] = new Direction56JRR(this, high, low, mode, kind);
			flag = true;
			break;
		case 57:
			dir[(int)kind] = new Direction59CSH(this, high, low, mode, kind);
			flag = false;
			break;
		case 58:
			if (nowHaikei == 5)
			{
				if (mode >= 1 && mode <= 5)
				{
					betHaikeiReset = 5;
				}
				dir[16] = new Direction60CHK(this, high, low, mode, kind);
				dir[16].start();
				flag = true;
			}
			break;
		case 59:
			dir[14] = new Direction61RST(this, high, low, mode, DIR.STAGE);
			flag = true;
			break;
		case 60:
			stopYFC();
			stopStage();
			dir[(int)kind] = new Direction62RSH(this, high, low, mode, kind);
			flag = false;
			break;
		case 61:
			dir[(int)kind] = new Direction63RIZ(this, high, low, mode, kind);
			flag = false;
			break;
		case 62:
			dir[(int)kind] = new Direction64RIS(this, high, low, mode, kind);
			flag = false;
			break;
		case 63:
			if (nowHaikei == 59)
			{
				if (mode >= 1 && mode <= 5)
				{
					betHaikeiReset = 59;
				}
				dir[16] = new Direction65RHK(this, high, low, mode, kind);
				dir[16].start();
				flag = true;
			}
			break;
		case 67:
			stopYFC();
			stopStage();
			forceKillStageMovies();
			StopDirectionStage(kind, high, low, mode);
			dir[14] = new Direction70KFR(this, high, low, mode, DIR.STAGE);
			dir[14].start();
			flag = true;
			bks_mode = 0;
			break;
		case 68:
			dir[(int)kind] = new Direction71BI2(this, high, low, mode, kind);
			flag = false;
			break;
		case 69:
			dir[(int)kind] = new Direction72BE2(this, high, low, mode, kind);
			flag = false;
			break;
		case 70:
			stopYFC();
			stopStage();
			forceKillStageMovies();
			dir[(int)kind] = new Direction74BZT(this, high, low, mode, kind);
			flag = false;
			if (mode == 53)
			{
				MainGameScene.dir3MST_Sub.initPosition();
				nowHaikei = 3;
				StopDirectionStage(kind, high, low, mode);
				dir[14] = new Direction100CMN(this, 127, 1, nowHaikei, kind);
				dir[14].start();
				flag = true;
			}
			break;
		case 71:
			if (mode == 1)
			{
				StopDirectionStage(kind, high, low, mode);
				dir[14] = new Direction75BM1(this, high, low, mode, DIR.STAGE);
			}
			else
			{
				dir[(int)kind] = new Direction75BM1(this, high, low, mode, kind);
			}
			flag = true;
			break;
		case 72:
			StopDirectionStage(kind, high, low, mode);
			dir[14] = new Direction76BM2(this, high, low, mode, DIR.STAGE);
			flag = false;
			break;
		case 73:
			if (low == 2)
			{
				dir[(int)kind] = new Direction77BKS(this, high, low, mode, kind);
			}
			else if (mode >= 162 && 164 >= mode)
			{
				dir[(int)kind] = new Direction77BKS(this, high, low, mode, kind);
			}
			else if (bks_mode != mode)
			{
				StopDirection(DIR.STAGE);
				dir[14] = new Direction77BKS(this, high, low, mode, DIR.STAGE);
				dir[14].start();
				bks_mode = mode;
				if (bks_cnt == 0)
				{
					StopDirection(DIR.STAGEPROD);
					dir[17] = new Direction77BKS(this, high, 1, 0, DIR.STAGEPROD);
					dir[17].start();
				}
				bks_cnt++;
			}
			flag = true;
			break;
		case 74:
			dir[(int)kind] = new Direction78BEM(this, high, low, mode, kind);
			flag = false;
			break;
		case 75:
			dir[(int)kind] = new Direction79ODM(this, high, low, mode, kind);
			flag = false;
			break;
		case 79:
			dir[(int)kind] = new Direction83LED(this, high, low, mode, kind);
			flag = true;
			break;
		case 80:
			dir[(int)kind] = new Direction84PUS(this, high, low, mode, kind);
			flag = true;
			break;
		case 82:
			stopYFC();
			dir[(int)kind] = new Direction86YTG(this, high, low, mode, kind);
			flag = false;
			break;
		case 83:
			if (low == 0 && mode == 13)
			{
				kind = DIR.YFC_CHAIN_1;
				dir[(int)kind] = new Direction87YFC(this, high, low, mode, kind);
				dir[(int)kind].start();
			}
			else if (low == 0 && mode == 14)
			{
				kind = DIR.YFC_CHAIN_2;
				dir[(int)kind] = new Direction87YFC(this, high, low, mode, kind);
				dir[(int)kind].start();
			}
			else if (low == 0 && mode == 15)
			{
				kind = DIR.YFC_CHAIN_3;
				dir[(int)kind] = new Direction87YFC(this, high, low, mode, kind);
				dir[(int)kind].start();
			}
			else
			{
				if (low == 0 && mode == 16)
				{
					stopYFC();
				}
				dir[(int)kind] = new Direction87YFC(this, high, low, mode, kind);
			}
			flag = true;
			break;
		case 84:
			stopYFC();
			dir[(int)kind] = new Direction88HUC(this, high, low, mode, kind);
			flag = false;
			break;
		case 85:
			dir[(int)kind] = new Direction89BTU(this, high, low, mode, kind);
			flag = false;
			break;
		case 86:
			dir[(int)kind] = new Direction90YTK(this, high, low, mode, kind);
			flag = true;
			break;
		case 87:
			dir[(int)kind] = new Direction91SND(this, high, low, mode, kind);
			flag = true;
			break;
		case 88:
			dir[(int)kind] = new Direction92KWD(this, high, low, mode, kind);
			flag = true;
			break;
		case 89:
			dir[14] = new Direction93BGT(this, high, low, mode, kind);
			flag = true;
			break;
		case 90:
			dir[(int)kind] = new Direction94BTH(this, high, low, mode, kind);
			flag = false;
			break;
		case 91:
			stopStage();
			forceKillStageMovies();
			dir[(int)kind] = new Direction95BJT(this, high, low, mode, kind);
			flag = false;
			break;
		case 92:
			dir[(int)kind] = new Direction96ACZ(this, high, low, mode, kind);
			flag = true;
			break;
		case 93:
			stopStage();
			dir[(int)kind] = new Direction97PRC(this, high, low, mode, kind);
			flag = false;
			break;
		case 94:
			dir[(int)kind] = new Direction98DI0(this, high, low, mode, kind);
			flag = false;
			break;
		case 127:
			if (mode == 27)
			{
				flag = true;
			}
			if (mode == 3 || mode == 4 || mode == 5 || mode == 6 || mode == 7 || mode == 9 || mode == 11 || mode == 14 || mode == 15)
			{
				StopDirection(DIR.YFC_CHAIN_1);
				StopDirection(DIR.YFC_CHAIN_2);
				StopDirection(DIR.YFC_CHAIN_3);
			}
			switch (mode)
			{
			case 2:
			case 35:
			case 43:
			{
				StopDirection();
				dir[(int)kind] = new Direction100CMN(this, high, low, mode, kind);
				if (m_stageHigh == byte.MaxValue || ((nowHaikei == 23 || nowHaikei == 24) && (MainGameScene.slotGameMan.m_dirData[45] == 5 || MainGameScene.slotGameMan.m_dirData[46] == 5)))
				{
					int num = MainGameScene.slotGameMan.m_dirData[45];
					int num2 = MainGameScene.slotGameMan.get_pkd_data(86);
					switch (mode)
					{
					case 35:
						nowHaikei = 18;
						break;
					case 43:
						if (num == 4)
						{
							nowHaikei = 24;
						}
						else
						{
							nowHaikei = 23;
						}
						break;
					}
					switch (num)
					{
					case 0:
						nowHaikei = 3;
						break;
					case 1:
						nowHaikei = 59;
						break;
					case 2:
						nowHaikei = 5;
						break;
					case 4:
					case 5:
					case 6:
					case 30:
						nowHaikei = 23;
						break;
					case 9:
						nowHaikei = 32;
						break;
					}
					if (num2 == 4 && (num == 4 || num == 5 || num == 6 || num == 30))
					{
						nowHaikei = 23;
					}
					dir[14] = new Direction100CMN(this, 127, 1, nowHaikei, DIR.STAGE);
				}
				if (mode != 2)
				{
					break;
				}
				int num3 = MainGameScene.slotGameMan.m_dirData[45];
				int num4 = MainGameScene.slotGameMan.m_dirData[46];
				int num5 = MainGameScene.slotGameMan.m_dirData[49];
				if (num3 == 9)
				{
					num3 = num5;
				}
				if (num3 != num4)
				{
					switch (num4)
					{
					case 0:
						nowHaikei = 3;
						dir[14] = new Direction100CMN(this, 127, 1, nowHaikei, DIR.STAGE);
						break;
					case 1:
						nowHaikei = 59;
						dir[14] = new Direction100CMN(this, 127, 1, nowHaikei, DIR.STAGE);
						break;
					case 2:
						nowHaikei = 5;
						dir[14] = new Direction100CMN(this, 127, 1, nowHaikei, DIR.STAGE);
						break;
					case 4:
					case 5:
					case 6:
					case 30:
						nowHaikei = 23;
						dir[14] = new Direction100CMN(this, 127, 1, nowHaikei, DIR.STAGE);
						break;
					case 9:
						nowHaikei = 32;
						dir[14] = new Direction100CMN(this, 127, 1, nowHaikei, DIR.STAGE);
						break;
					}
				}
				break;
			}
			case 6:
				StopDirectionStage(kind, high, low, mode);
				dir[14] = new Direction100CMN(this, 127, low, mode, DIR.STAGE);
				break;
			case 114:
				StopDirectionStage(kind, high, low, mode);
				dir[14] = new Direction100CMN(this, 127, low, mode, DIR.STAGE);
				dir[14].start();
				break;
			default:
				dir[(int)kind] = new Direction100CMN(this, high, low, mode, kind);
				if (mode == 28 || mode == 29 || mode == 30 || mode == 5 || mode == 7)
				{
					switch (mode)
					{
					case 28:
						nowHaikei = 59;
						break;
					case 29:
						nowHaikei = 5;
						break;
					case 30:
						MainGameScene.dir3MST_Sub.initPosition();
						nowHaikei = 3;
						break;
					case 5:
						nowHaikei = 18;
						break;
					case 7:
						nowHaikei = 24;
						break;
					}
					stopStage();
					stopYFC();
					StopDirectionStage(kind, high, low, mode);
					dir[14] = new Direction100CMN(this, 127, 1, nowHaikei, DIR.STAGE);
				}
				break;
			}
			if (low == 0 && mode == 2)
			{
				flag = true;
			}
			else if (mode == 2 || mode == 35 || mode == 43 || mode == 28 || mode == 29 || mode == 30 || mode == 5 || mode == 7 || mode == 6 || mode == 17 || mode == 90)
			{
				flag = true;
			}
			else if (low == 1 || low == 2)
			{
				flag = true;
			}
			break;
		}
		if (high == 0 && low == 0 && mode == 0)
		{
			flag = true;
		}
		if (high == 127 && low == 0 && mode == 1)
		{
			flag = true;
		}
		if (flag)
		{
			setBGVisible(kind, true);
		}
		else
		{
			setBGVisible(kind, false);
		}
	}

	public void OnLeverOn(byte _high, byte _low, byte _mode)
	{
		nowDir = DIR.LEVER;
		StopDirection();
		InitDirection();
		m_High[0] = _high;
		m_Low[0] = _low;
		m_Mode[0] = _mode;
		DebugLeverOn();
		DebugRewrite(0);
		byte b = m_High[0];
		byte low = m_Low[0];
		byte b2 = m_Mode[0];
		if (bks_mode != 0 && b != 73 && b != 67)
		{
			if (b2 != 7)
			{
				nowHaikei = 3;
				m_High[0] = 127;
				m_Low[0] = 0;
				m_Mode[0] = 2;
				b = m_High[0];
				low = m_Low[0];
				b2 = m_Mode[0];
			}
			bks_mode = 0;
			bks_cnt = 0;
		}
		yuugiSound(DIR.LEVER);
		StageProdReset();
		if (MainGameScene.slotGameMan.m_dirData[45] == 2)
		{
			Direction5CST.restartBGM();
		}
		makeDirection(DIR.LEVER, b, low, b2);
		if (dir[0] != null)
		{
			dir[0].start();
		}
		switch (b)
		{
		case 127:
			if (b2 != 2 && b2 != 28 && b2 != 29 && b2 != 30 && b2 != 5 && b2 != 7 && b2 != 6 && b2 != 35 && b2 != 43)
			{
				break;
			}
			goto case 3;
		case 3:
		case 5:
		case 18:
		case 23:
		case 32:
		case 59:
		case 89:
			OnStage(b, low, b2);
			break;
		}
	}

	public void OnReelStart(byte _high, byte _low, byte _mode)
	{
		nowDir = DIR.REEL;
		m_High[1] = _high;
		m_Low[1] = _low;
		m_Mode[1] = _mode;
		DebugRewrite(1);
		byte b = m_High[1];
		byte b2 = m_Low[1];
		byte b3 = m_Mode[1];
		yuugiSound(DIR.REEL);
		if ((b != m_High[0] || b2 != m_Low[0] || b3 != m_Mode[0] || (b == 87 && (b3 == 32 || b3 == 33))) && (b != 67 || b3 != 1))
		{
			makeDirection(DIR.REEL, b, b2, b3);
			if (dir[1] != null)
			{
				dir[1].start();
			}
		}
	}

	public void OnReel1Stop(byte _high, byte _low, byte _mode)
	{
		nowDir = DIR.STOP1;
		m_High[2] = _high;
		m_Low[2] = _low;
		m_Mode[2] = _mode;
		DebugRewrite(2);
		byte b = m_High[2];
		byte b2 = m_Low[2];
		byte b3 = m_Mode[2];
		yuugiSound(DIR.STOP1);
		if (b != m_High[1] || b2 != m_Low[1] || b3 != m_Mode[1] || (b == 87 && (b3 == 32 || b3 == 33)))
		{
			makeDirection(DIR.STOP1, b, b2, b3);
			if (dir[2] != null)
			{
				dir[2].start();
			}
		}
	}

	public void OnReel2Stop(byte _high, byte _low, byte _mode)
	{
		nowDir = DIR.STOP2;
		m_High[3] = _high;
		m_Low[3] = _low;
		m_Mode[3] = _mode;
		DebugRewrite(3);
		byte b = m_High[3];
		byte b2 = m_Low[3];
		byte b3 = m_Mode[3];
		yuugiSound(DIR.STOP2);
		if (b != m_High[2] || b2 != m_Low[2] || b3 != m_Mode[2] || (b == 87 && (b3 == 32 || b3 == 33)))
		{
			makeDirection(DIR.STOP2, b, b2, b3);
			if (dir[3] != null)
			{
				dir[3].start();
			}
		}
	}

	public void OnReel3Stop(byte _high, byte _low, byte _mode)
	{
		nowDir = DIR.STOP3;
		m_High[4] = _high;
		m_Low[4] = _low;
		m_Mode[4] = _mode;
		DebugRewrite(4);
		byte b = m_High[4];
		byte b2 = m_Low[4];
		byte b3 = m_Mode[4];
		yuugiSound(DIR.STOP3);
		if (b != m_High[3] || b2 != m_Low[3] || b3 != m_Mode[3] || (b == 87 && (b3 == 32 || b3 == 33)))
		{
			makeDirection(DIR.STOP3, b, b2, b3);
			if (dir[4] != null)
			{
				dir[4].start();
			}
		}
	}

	public void OnReel3StopOff(byte _high, byte _low, byte _mode)
	{
		nowDir = DIR.STOP3OFF;
		m_High[5] = _high;
		m_Low[5] = _low;
		m_Mode[5] = _mode;
		DebugRewrite(5);
		byte b = m_High[5];
		byte b2 = m_Low[5];
		byte b3 = m_Mode[5];
		yuugiSound(DIR.STOP3OFF);
		if (b != m_High[4] || b2 != m_Low[4] || b3 != m_Mode[4] || (b == 87 && (b3 == 32 || b3 == 33)))
		{
			makeDirection(DIR.STOP3OFF, b, b2, b3);
			if (dir[5] != null)
			{
				dir[5].start();
			}
			if (b == 127 && (b3 == 28 || b3 == 29 || b3 == 30))
			{
				StopDirection(DIR.PUSH);
				StopDirection(DIR.LEVER_2);
				StopDirection(DIR.REEL_2);
				StopDirection(DIR.STOP1_2);
				StopDirection(DIR.STOP2_2);
				StopDirection(DIR.STOP3_2);
				StopDirection(DIR.STOP3OFF_2);
				StopDirection(DIR.BET_2);
				StopDirection(DIR.YTK_YAKUTAN);
				m_ytkHigh = byte.MaxValue;
				m_ytkLow = byte.MaxValue;
				m_ytkMode = byte.MaxValue;
				OnStage(b, b2, b3);
			}
		}
	}

	public void OnBet(byte _high, byte _low, byte _mode)
	{
		nowDir = DIR.BET;
		if (_high != 90 && _high != 91)
		{
			MainGameScene.pushMan.setCanPush(false);
		}
		m_High[6] = _high;
		m_Low[6] = _low;
		m_Mode[6] = _mode;
		DebugRewrite(6);
		HaikeiChange();
		byte b = m_High[6];
		byte b2 = m_Low[6];
		byte b3 = m_Mode[6];
		yuugiSound(DIR.BET);
		StageProdReset();
		if (b == m_High[5] && b2 == m_Low[5] && b3 == m_Mode[5] && (b != 87 || (b3 != 32 && b3 != 33)))
		{
			if (b == 86)
			{
				StopDirection();
			}
		}
		else
		{
			if (b == 67 && b3 == 1)
			{
				return;
			}
			makeDirection(DIR.BET, b, b2, b3);
			if (dir[6] != null)
			{
				dir[6].start();
			}
			switch (b)
			{
			case 127:
				if (b3 != 2 && b3 != 28 && b3 != 29 && b3 != 30 && b3 != 5 && b3 != 6 && b3 != 7 && b3 != 35 && b3 != 43)
				{
					break;
				}
				goto case 3;
			case 3:
			case 5:
			case 18:
			case 23:
			case 32:
			case 59:
			case 71:
			case 89:
				OnStage(b, b2, b3);
				break;
			}
		}
	}

	public void EventStageChanged(byte _high, byte _low, byte _mode)
	{
		m_High[14] = _high;
		m_Low[14] = _low;
		m_Mode[14] = _mode;
		byte b = m_High[14];
		byte low = m_Low[14];
		byte mode = m_Mode[14];
		makeDirection(DIR.STAGE, b, low, mode);
		if (b != 37 && b != 67)
		{
			OnStage(b, low, mode);
		}
	}

	public void OnStage(byte _high, byte _low, byte _mode)
	{
		if (_high != m_stageHigh || _low != m_stageLow || _mode != m_stageMode || (_high == 87 && (_mode == 32 || _mode == 33)))
		{
			m_stageHigh = _high;
			m_stageLow = _low;
			m_stageMode = _mode;
			if (dir[14] != null)
			{
				dir[14].start();
			}
		}
	}

	public void OnPush(int _dirNum, byte _high, byte _low, byte _mode, bool _flag)
	{
		byte high = _high;
		byte low = _low;
		byte mode = _mode;
		MainGameScene.pushMan.setCanPush(false);
		DIR dIR = DIR.LEVER;
		switch (_dirNum)
		{
		default:
			return;
		case 0:
			dIR = DIR.LEVER;
			break;
		case 1:
			dIR = DIR.REEL;
			break;
		case 2:
			dIR = DIR.STOP1;
			break;
		case 3:
			dIR = DIR.STOP2;
			break;
		case 4:
			dIR = DIR.STOP3;
			break;
		case 5:
			dIR = DIR.STOP3OFF;
			break;
		case 6:
			dIR = DIR.BET;
			break;
		}
		int num = (int)dIR;
		bool flag = true;
		if (_high == 90 && _low == 0 && (_mode == 114 || _mode == 115 || _mode == 116))
		{
			flag = false;
		}
		if (flag)
		{
			StopDirection(dIR);
		}
		if (_flag)
		{
			m_High[num] = _high;
			m_Low[num] = _low;
			m_Mode[num] = _mode;
			high = m_High[num];
			low = m_Low[num];
			mode = m_Mode[num];
		}
		makeDirection(dIR, high, low, mode);
		if (dir[num] != null)
		{
			dir[num].start();
		}
	}

	public void OnLeverOn2(byte _high, byte _low, byte _mode)
	{
		m_High[7] = _high;
		m_Low[7] = _low;
		m_Mode[7] = _mode;
		byte high = m_High[7];
		byte low = m_Low[7];
		byte mode = m_Mode[7];
		StopDirection(DIR.LEVER_2);
		makeDirection(DIR.LEVER_2, high, low, mode);
		if (dir[7] != null)
		{
			dir[7].start();
		}
	}

	public void OnReelStart2(byte _high, byte _low, byte _mode)
	{
		DIR kind = DIR.REEL_2;
		nowDirNum = 8;
		m_High[nowDirNum] = _high;
		m_Low[nowDirNum] = _low;
		m_Mode[nowDirNum] = _mode;
		byte b = m_High[nowDirNum];
		byte b2 = m_Low[nowDirNum];
		byte b3 = m_Mode[nowDirNum];
		if (b != m_High[nowDirNum - 1] || b2 != m_Low[nowDirNum - 1] || b3 != m_Mode[nowDirNum - 1] || (b == 87 && (b3 == 32 || b3 == 33)))
		{
			makeDirection(kind, b, b2, b3);
			if (dir[nowDirNum] != null)
			{
				dir[nowDirNum].start();
			}
		}
	}

	public void OnReel1Stop2(byte _high, byte _low, byte _mode)
	{
		DIR kind = DIR.STOP1_2;
		nowDirNum = 9;
		m_High[nowDirNum] = _high;
		m_Low[nowDirNum] = _low;
		m_Mode[nowDirNum] = _mode;
		byte b = m_High[nowDirNum];
		byte b2 = m_Low[nowDirNum];
		byte b3 = m_Mode[nowDirNum];
		if (b != m_High[nowDirNum - 1] || b2 != m_Low[nowDirNum - 1] || b3 != m_Mode[nowDirNum - 1] || (b == 87 && (b3 == 32 || b3 == 33)))
		{
			makeDirection(kind, b, b2, b3);
			if (dir[nowDirNum] != null)
			{
				dir[nowDirNum].start();
			}
		}
	}

	public void OnReel2Stop2(byte _high, byte _low, byte _mode)
	{
		DIR kind = DIR.STOP2_2;
		nowDirNum = 10;
		m_High[nowDirNum] = _high;
		m_Low[nowDirNum] = _low;
		m_Mode[nowDirNum] = _mode;
		byte b = m_High[nowDirNum];
		byte b2 = m_Low[nowDirNum];
		byte b3 = m_Mode[nowDirNum];
		if (b != m_High[nowDirNum - 1] || b2 != m_Low[nowDirNum - 1] || b3 != m_Mode[nowDirNum - 1] || (b == 87 && (b3 == 32 || b3 == 33)))
		{
			makeDirection(kind, b, b2, b3);
			if (dir[nowDirNum] != null)
			{
				dir[nowDirNum].start();
			}
		}
	}

	public void OnReel3Stop2(byte _high, byte _low, byte _mode)
	{
		DIR kind = DIR.STOP3_2;
		nowDirNum = 11;
		m_High[nowDirNum] = _high;
		m_Low[nowDirNum] = _low;
		m_Mode[nowDirNum] = _mode;
		byte b = m_High[nowDirNum];
		byte b2 = m_Low[nowDirNum];
		byte b3 = m_Mode[nowDirNum];
		if (b != m_High[nowDirNum - 1] || b2 != m_Low[nowDirNum - 1] || b3 != m_Mode[nowDirNum - 1] || (b == 87 && (b3 == 32 || b3 == 33)))
		{
			makeDirection(kind, b, b2, b3);
			if (dir[nowDirNum] != null)
			{
				dir[nowDirNum].start();
			}
		}
	}

	public void OnReel3StopOff2(byte _high, byte _low, byte _mode)
	{
		DIR kind = DIR.STOP3OFF_2;
		nowDirNum = 12;
		m_High[nowDirNum] = _high;
		m_Low[nowDirNum] = _low;
		m_Mode[nowDirNum] = _mode;
		byte b = m_High[nowDirNum];
		byte b2 = m_Low[nowDirNum];
		byte b3 = m_Mode[nowDirNum];
		if (b != m_High[nowDirNum - 1] || b2 != m_Low[nowDirNum - 1] || b3 != m_Mode[nowDirNum - 1] || (b == 87 && (b3 == 32 || b3 == 33)))
		{
			makeDirection(kind, b, b2, b3);
			if (dir[nowDirNum] != null)
			{
				dir[nowDirNum].start();
			}
		}
	}

	public void OnBet2(byte _high, byte _low, byte _mode)
	{
		DIR kind = DIR.BET_2;
		nowDirNum = 13;
		StopDirection(DIR.LEVER_2);
		StopDirection(DIR.REEL_2);
		StopDirection(DIR.STOP1_2);
		StopDirection(DIR.STOP2_2);
		StopDirection(DIR.STOP3_2);
		StopDirection(DIR.STOP3OFF_2);
		StopDirection(DIR.BET_2);
		StopDirection(DIR.YTK_YAKUTAN);
		m_ytkHigh = byte.MaxValue;
		m_ytkLow = byte.MaxValue;
		m_ytkMode = byte.MaxValue;
		m_High[nowDirNum] = _high;
		m_Low[nowDirNum] = _low;
		m_Mode[nowDirNum] = _mode;
		byte b = m_High[nowDirNum];
		byte b2 = m_Low[nowDirNum];
		byte b3 = m_Mode[nowDirNum];
		if (b != m_High[nowDirNum - 1] || b2 != m_Low[nowDirNum - 1] || b3 != m_Mode[nowDirNum - 1] || (b == 87 && (b3 == 32 || b3 == 33)))
		{
			makeDirection(kind, b, b2, b3);
			if (dir[nowDirNum] != null)
			{
				dir[nowDirNum].start();
			}
		}
	}

	public void OnYTK(byte _high, byte _low, byte _mode)
	{
		DIR kind = DIR.YTK_YAKUTAN;
		nowDirNum = 22;
		byte b = _high;
		byte b2 = _low;
		byte b3 = _mode;
		if (b != m_ytkHigh || b2 != m_ytkLow || b3 != m_ytkMode)
		{
			m_ytkHigh = _high;
			m_ytkLow = _low;
			m_ytkMode = _mode;
			makeDirection(kind, b, b2, b3);
			if (dir[nowDirNum] != null)
			{
				dir[nowDirNum].start();
			}
		}
	}

	public void HaikeiChange()
	{
		if (nowHaikei == 3 && MainGameScene.slotGameMan.get_pkd_data(86) != 5 && MainGameScene.slotGameMan.get_pkd_data(86) != 6)
		{
			switch (MainGameScene.slotGameMan.m_dirData[45])
			{
			case 1:
				m_High[6] = 127;
				m_Low[6] = 0;
				m_Mode[6] = 28;
				break;
			case 2:
				m_High[6] = 127;
				m_Low[6] = 0;
				m_Mode[6] = 29;
				break;
			}
		}
	}

	public void StageProdReset()
	{
		StopDirection(DIR.HAIKEIPROD);
		if (betHaikeiReset != 0)
		{
			StopDirection(DIR.STAGEPROD);
			dir[17] = new Direction100CMN(this, 127, 2, betHaikeiReset, DIR.STAGEPROD);
			dir[17].start();
			betHaikeiReset = 0;
		}
	}

	public void DisActive(DIR kind)
	{
		if (dir[(int)kind] != null)
		{
			dir[(int)kind].disActive();
		}
	}

	public void StopDirection(DIR kind)
	{
		if (dir[(int)kind] != null)
		{
			dir[(int)kind].end();
			dir[(int)kind] = null;
		}
	}

	public void StopDirection()
	{
		StopDirection(DIR.LEVER);
		StopDirection(DIR.REEL);
		StopDirection(DIR.STOP1);
		StopDirection(DIR.STOP2);
		StopDirection(DIR.STOP3);
		StopDirection(DIR.STOP3OFF);
		StopDirection(DIR.BET);
		StopDirection(DIR.PUSH);
		StopDirection(DIR.LEVER_2);
		StopDirection(DIR.REEL_2);
		StopDirection(DIR.STOP1_2);
		StopDirection(DIR.STOP2_2);
		StopDirection(DIR.STOP3_2);
		StopDirection(DIR.STOP3OFF_2);
		StopDirection(DIR.BET_2);
		StopDirection(DIR.YTK_YAKUTAN);
		m_ytkHigh = byte.MaxValue;
		m_ytkLow = byte.MaxValue;
		m_ytkMode = byte.MaxValue;
		DirectionEvent.prod.KillLayer(40, 130);
	}

	public void StopDirectionStage(DIR kind, byte high, byte low, byte mode)
	{
		if (high != 127 || mode != 2)
		{
			int num = MainGameScene.slotGameMan.get_pdt_data(45);
			int num2 = MainGameScene.slotGameMan.get_pdt_data(49);
			if (num != num2 || high != m_stageHigh || low != m_stageLow || mode != m_stageMode)
			{
				StopDirection(DIR.STAGE);
				StopDirection(DIR.STAGEPROD);
			}
		}
	}

	public void control()
	{
		for (int i = 0; i < 25; i++)
		{
			if (dir[i] != null)
			{
				dir[i].control();
			}
		}
	}

	public void setBGVisible(DIR kind, bool _flag)
	{
		for (int i = 160; i <= 200; i++)
		{
			int id = DirectionEvent.prod.findLayer(i);
			DirectionEvent.prod.SetVisible(id, _flag);
			int id2 = DirectionEvent.prodImg.findLayer(i);
			DirectionEvent.prodImg.SetVisible(id2, _flag);
		}
	}

	public void setDirCommand(int _dirNum, byte _high, byte _low, byte _mode)
	{
		m_High[_dirNum] = _high;
		m_Low[_dirNum] = _low;
		m_Mode[_dirNum] = _mode;
	}

	public void yuugiSound(DIR kind)
	{
	}

	public static int changeMovie(int _playID)
	{
		int result = _playID;
		int hOHStage = MainGameScene.slotGameMan.getHOHStage();
		int num = MainGameScene.slotGameMan.get_pkd_data(93);
		int num2 = MainGameScene.slotGameMan.get_pkd_data(653);
		switch ((MOVIE)_playID)
		{
		case MOVIE.hsl1002_hai1:
		case MOVIE.hsl1002_hai2:
		case MOVIE.hsl1002_hai3:
		case MOVIE.hsl1002_hai4:
		case MOVIE.hsl1002_hai5:
			switch (hOHStage)
			{
			case 0:
				result = 278;
				break;
			case 1:
				result = 280;
				break;
			case 2:
				result = 282;
				break;
			case 3:
				result = 286;
				break;
			case 4:
				result = 284;
				break;
			case 5:
				result = 284;
				break;
			case 6:
				result = 284;
				break;
			case 30:
				result = 284;
				break;
			}
			break;
		case MOVIE.hsl1002_sol:
		case MOVIE.hsl1002_sol3:
		case MOVIE.hsl1002_sol4:
			switch (hOHStage)
			{
			case 0:
				result = 288;
				break;
			case 1:
				result = 288;
				break;
			case 2:
				result = 289;
				break;
			case 3:
				result = 289;
				break;
			case 4:
				result = 290;
				break;
			case 5:
				result = 290;
				break;
			case 6:
				result = 290;
				break;
			case 30:
				result = 290;
				break;
			}
			break;
		case MOVIE.hsl1002_sol_loop:
		case MOVIE.hsl1002_sol3_loop:
		case MOVIE.hsl1002_sol4_loop:
			switch (hOHStage)
			{
			case 0:
				result = 291;
				break;
			case 1:
				result = 291;
				break;
			case 2:
				result = 292;
				break;
			case 3:
				result = 292;
				break;
			case 4:
				result = 293;
				break;
			case 5:
				result = 293;
				break;
			case 6:
				result = 293;
				break;
			case 30:
				result = 293;
				break;
			}
			break;
		case MOVIE.hsl1002_sly:
		case MOVIE.hsl1002_sly3:
		case MOVIE.hsl1002_sly4:
			switch (hOHStage)
			{
			case 0:
				result = 294;
				break;
			case 1:
				result = 294;
				break;
			case 2:
				result = 295;
				break;
			case 3:
				result = 295;
				break;
			case 4:
				result = 296;
				break;
			case 5:
				result = 296;
				break;
			case 6:
				result = 296;
				break;
			case 30:
				result = 296;
				break;
			}
			break;
		case MOVIE.hsl1002_sly_loop:
		case MOVIE.hsl1002_sly3_loop:
		case MOVIE.hsl1002_sly4_loop:
			switch (hOHStage)
			{
			case 0:
				result = 297;
				break;
			case 1:
				result = 297;
				break;
			case 2:
				result = 298;
				break;
			case 3:
				result = 298;
				break;
			case 4:
				result = 299;
				break;
			case 5:
				result = 299;
				break;
			case 6:
				result = 299;
				break;
			case 30:
				result = 299;
				break;
			}
			break;
		case MOVIE.hsl2001_hai1:
		case MOVIE.hsl2001_hai2:
		case MOVIE.hsl2001_hai3:
		case MOVIE.hsl2001_hai4:
		case MOVIE.hsl2001_hai5:
			switch (hOHStage)
			{
			case 0:
				result = 302;
				break;
			case 1:
				result = 306;
				break;
			case 2:
				result = 310;
				break;
			case 3:
				result = 318;
				break;
			case 4:
				result = 314;
				break;
			case 5:
				result = 314;
				break;
			case 6:
				result = 314;
				break;
			case 30:
				result = 314;
				break;
			}
			break;
		case MOVIE.hsl2001_hai1_a:
			if (hOHStage == 0)
			{
				result = 303;
			}
			break;
		case MOVIE.hsl2001_sol:
		case MOVIE.hsl2001_sol_ya:
		case MOVIE.hsl2001_sol_sise:
			switch (hOHStage)
			{
			case 0:
				result = 324;
				break;
			case 1:
				result = 324;
				break;
			case 2:
				result = 325;
				break;
			case 3:
				result = 325;
				break;
			case 4:
				result = 326;
				break;
			case 5:
				result = 326;
				break;
			case 6:
				result = 326;
				break;
			case 30:
				result = 326;
				break;
			}
			break;
		case MOVIE.hsl2001_sol1:
		case MOVIE.hsl2001_sol1_ya:
		case MOVIE.hsl2001_sol1_sise:
			switch (hOHStage)
			{
			case 0:
				result = 327;
				break;
			case 1:
				result = 327;
				break;
			case 2:
				result = 329;
				break;
			case 3:
				result = 329;
				break;
			case 4:
				result = 331;
				break;
			case 5:
				result = 331;
				break;
			case 6:
				result = 331;
				break;
			case 30:
				result = 331;
				break;
			}
			break;
		case MOVIE.hsl2001_sol1_loop:
		case MOVIE.hsl2001_sol1_ya_loop:
		case MOVIE.hsl2001_sol1_sise_loop:
			switch (hOHStage)
			{
			case 0:
				result = 328;
				break;
			case 1:
				result = 328;
				break;
			case 2:
				result = 330;
				break;
			case 3:
				result = 330;
				break;
			case 4:
				result = 332;
				break;
			case 5:
				result = 332;
				break;
			case 6:
				result = 332;
				break;
			case 30:
				result = 332;
				break;
			}
			break;
		case MOVIE.hsl2001_sly:
		case MOVIE.hsl2001_sly3:
		case MOVIE.hsl2001_sly4:
			switch (hOHStage)
			{
			case 0:
				result = 333;
				break;
			case 1:
				result = 333;
				break;
			case 2:
				result = 334;
				break;
			case 3:
				result = 334;
				break;
			case 4:
				result = 335;
				break;
			case 5:
				result = 335;
				break;
			case 6:
				result = 335;
				break;
			case 30:
				result = 335;
				break;
			}
			break;
		case MOVIE.hsl2001_hai1_kyo:
		case MOVIE.hsl2001_hai2_kyo:
		case MOVIE.hsl2001_hai3_kyo:
		case MOVIE.hsl2001_hai4_kyo:
		case MOVIE.hsl2001_hai5_kyo:
			switch (hOHStage)
			{
			case 0:
				result = 305;
				break;
			case 1:
				result = 309;
				break;
			case 2:
				result = 313;
				break;
			case 3:
				result = 321;
				break;
			case 4:
				result = 317;
				break;
			case 5:
				result = 317;
				break;
			case 6:
				result = 317;
				break;
			case 30:
				result = 317;
				break;
			}
			break;
		case MOVIE.hsl2001_sol2:
		case MOVIE.hsl2001_sol2_ya:
		case MOVIE.hsl2001_sol2_sise:
			switch (hOHStage)
			{
			case 0:
				result = 336;
				break;
			case 1:
				result = 336;
				break;
			case 2:
				result = 337;
				break;
			case 3:
				result = 337;
				break;
			case 4:
				result = 338;
				break;
			case 5:
				result = 338;
				break;
			case 6:
				result = 338;
				break;
			case 30:
				result = 338;
				break;
			}
			break;
		case MOVIE.hsl2007_sol_hai1:
		case MOVIE.hsl2007_sol_hai2:
		case MOVIE.hsl2007_sol_hai3:
		case MOVIE.hsl2007_sol_hai4:
		case MOVIE.hsl2007_sol_hai5:
			switch (hOHStage)
			{
			case 0:
				result = 351;
				break;
			case 1:
				result = 352;
				break;
			case 2:
				result = 353;
				break;
			case 3:
				result = 355;
				break;
			case 4:
				result = 354;
				break;
			case 5:
				result = 354;
				break;
			case 6:
				result = 354;
				break;
			case 30:
				result = 354;
				break;
			}
			break;
		case MOVIE.hsl3001_hai1:
		case MOVIE.hsl3001_hai2:
		case MOVIE.hsl3001_hai3:
		case MOVIE.hsl3001_hai4:
		case MOVIE.hsl3001_hai5:
			switch (hOHStage)
			{
			case 0:
				result = 387;
				break;
			case 1:
				result = 389;
				break;
			case 2:
				result = 391;
				break;
			case 3:
				result = 395;
				break;
			case 4:
				result = 393;
				break;
			case 5:
				result = 393;
				break;
			case 6:
				result = 393;
				break;
			case 30:
				result = 393;
				break;
			}
			break;
		case MOVIE.hsl3001_sly:
		case MOVIE.hsl3001_sly3:
		case MOVIE.hsl3001_sly4:
			switch (hOHStage)
			{
			case 0:
				result = 399;
				break;
			case 1:
				result = 399;
				break;
			case 2:
				result = 400;
				break;
			case 3:
				result = 400;
				break;
			case 4:
				result = 401;
				break;
			case 5:
				result = 401;
				break;
			case 6:
				result = 401;
				break;
			case 30:
				result = 401;
				break;
			}
			break;
		case MOVIE.hsl3001_sly_loop:
		case MOVIE.hsl3001_sly3_loop:
		case MOVIE.hsl3001_sly4_loop:
			switch (hOHStage)
			{
			case 0:
				result = 402;
				break;
			case 1:
				result = 402;
				break;
			case 2:
				result = 403;
				break;
			case 3:
				result = 403;
				break;
			case 4:
				result = 404;
				break;
			case 5:
				result = 404;
				break;
			case 6:
				result = 404;
				break;
			case 30:
				result = 404;
				break;
			}
			break;
		case MOVIE.hsl3018_sly1:
		case MOVIE.hsl3018_sly2:
		case MOVIE.hsl3018_sly3:
		case MOVIE.hsl3018_sly4:
		case MOVIE.hsl3018_sly5:
			switch (hOHStage)
			{
			case 0:
				result = 428;
				break;
			case 1:
				result = 429;
				break;
			case 2:
				result = 430;
				break;
			case 3:
				result = 432;
				break;
			case 4:
				result = 431;
				break;
			case 5:
				result = 431;
				break;
			case 6:
				result = 431;
				break;
			case 30:
				result = 431;
				break;
			}
			break;
		case MOVIE.hcp3018_chp1:
		case MOVIE.hcp3018_chp2:
		case MOVIE.hcp3018_chp3:
		case MOVIE.hcp3018_chp4:
		case MOVIE.hcp3018_chp5:
			switch (hOHStage)
			{
			case 0:
				result = 2184;
				break;
			case 1:
				result = 2186;
				break;
			case 2:
				result = 2188;
				break;
			case 3:
				result = 2192;
				break;
			case 4:
				result = 2190;
				break;
			case 5:
				result = 2190;
				break;
			case 6:
				result = 2190;
				break;
			case 30:
				result = 2190;
				break;
			}
			break;
		case MOVIE.hml3018_mil1:
		case MOVIE.hml3018_mil2:
		case MOVIE.hml3018_mil3:
		case MOVIE.hml3018_mil4:
		case MOVIE.hml3018_mil5:
			switch (hOHStage)
			{
			case 0:
				result = 2270;
				break;
			case 1:
				result = 2272;
				break;
			case 2:
				result = 2274;
				break;
			case 3:
				result = 2278;
				break;
			case 4:
				result = 2276;
				break;
			case 5:
				result = 2276;
				break;
			case 6:
				result = 2276;
				break;
			case 30:
				result = 2276;
				break;
			}
			break;
		case MOVIE.hbj3018_brg1:
		case MOVIE.hbj3018_brg2:
		case MOVIE.hbj3018_brg3:
		case MOVIE.hbj3018_brg4:
		case MOVIE.hbj3018_brg5:
			switch (hOHStage)
			{
			case 0:
				result = 2357;
				break;
			case 1:
				result = 2359;
				break;
			case 2:
				result = 2361;
				break;
			case 3:
				result = 2365;
				break;
			case 4:
				result = 2363;
				break;
			case 5:
				result = 2363;
				break;
			case 6:
				result = 2363;
				break;
			case 30:
				result = 2363;
				break;
			}
			break;
		case MOVIE.hsl5001_hai1:
		case MOVIE.hsl5001_hai2:
		case MOVIE.hsl5001_hai3:
		case MOVIE.hsl5001_hai4:
		case MOVIE.hsl5001_hai5:
			switch (hOHStage)
			{
			case 0:
				result = 437;
				break;
			case 1:
				result = 438;
				break;
			case 2:
				result = 439;
				break;
			case 3:
				result = 441;
				break;
			case 4:
				result = 440;
				break;
			case 5:
				result = 440;
				break;
			case 6:
				result = 440;
				break;
			case 30:
				result = 440;
				break;
			}
			break;
		case MOVIE.hsl5001_sol:
		case MOVIE.hsl5001_sol3:
		case MOVIE.hsl5001_sol4:
			switch (hOHStage)
			{
			case 0:
				result = 442;
				break;
			case 1:
				result = 442;
				break;
			case 2:
				result = 443;
				break;
			case 3:
				result = 443;
				break;
			case 4:
				result = 444;
				break;
			case 5:
				result = 444;
				break;
			case 6:
				result = 444;
				break;
			case 30:
				result = 444;
				break;
			}
			break;
		case MOVIE.hsl5002_hai1:
		case MOVIE.hsl5002_hai2:
		case MOVIE.hsl5002_hai3:
		case MOVIE.hsl5002_hai4:
		case MOVIE.hsl5002_hai5:
			switch (hOHStage)
			{
			case 0:
				result = 445;
				break;
			case 1:
				result = 446;
				break;
			case 2:
				result = 447;
				break;
			case 3:
				result = 449;
				break;
			case 4:
				result = 448;
				break;
			case 5:
				result = 448;
				break;
			case 6:
				result = 448;
				break;
			case 30:
				result = 448;
				break;
			}
			break;
		case MOVIE.hsl5002_sol:
		case MOVIE.hsl5002_sol3:
		case MOVIE.hsl5002_sol4:
			switch (hOHStage)
			{
			case 0:
				result = 450;
				break;
			case 1:
				result = 450;
				break;
			case 2:
				result = 451;
				break;
			case 3:
				result = 451;
				break;
			case 4:
				result = 452;
				break;
			case 5:
				result = 452;
				break;
			case 6:
				result = 452;
				break;
			case 30:
				result = 452;
				break;
			}
			break;
		case MOVIE.hsl5003_hai1:
		case MOVIE.hsl5003_hai2:
		case MOVIE.hsl5003_hai3:
		case MOVIE.hsl5003_hai4:
		case MOVIE.hsl5003_hai5:
			switch (hOHStage)
			{
			case 0:
				result = 453;
				break;
			case 1:
				result = 455;
				break;
			case 2:
				result = 457;
				break;
			case 3:
				result = 461;
				break;
			case 4:
				result = 459;
				break;
			case 5:
				result = 459;
				break;
			case 6:
				result = 459;
				break;
			case 30:
				result = 459;
				break;
			}
			break;
		case MOVIE.hsl5003_sol:
		case MOVIE.hsl5003_sol3:
		case MOVIE.hsl5003_sol4:
			switch (hOHStage)
			{
			case 0:
				result = 463;
				break;
			case 1:
				result = 463;
				break;
			case 2:
				result = 465;
				break;
			case 3:
				result = 465;
				break;
			case 4:
				result = 467;
				break;
			case 5:
				result = 467;
				break;
			case 6:
				result = 467;
				break;
			case 30:
				result = 467;
				break;
			}
			break;
		case MOVIE.hsl5003_sol_loop:
		case MOVIE.hsl5003_sol3_loop:
		case MOVIE.hsl5003_sol4_loop:
			switch (hOHStage)
			{
			case 0:
				result = 464;
				break;
			case 1:
				result = 464;
				break;
			case 2:
				result = 466;
				break;
			case 3:
				result = 466;
				break;
			case 4:
				result = 468;
				break;
			case 5:
				result = 468;
				break;
			case 6:
				result = 468;
				break;
			case 30:
				result = 468;
				break;
			}
			break;
		case MOVIE.hsl5004_hai1:
		case MOVIE.hsl5004_hai2:
		case MOVIE.hsl5004_hai3:
		case MOVIE.hsl5004_hai4:
		case MOVIE.hsl5004_hai5:
			switch (hOHStage)
			{
			case 0:
				result = 469;
				break;
			case 1:
				result = 470;
				break;
			case 2:
				result = 471;
				break;
			case 3:
				result = 473;
				break;
			case 4:
				result = 472;
				break;
			case 5:
				result = 472;
				break;
			case 6:
				result = 472;
				break;
			case 30:
				result = 472;
				break;
			}
			break;
		case MOVIE.hsl5004_sol:
		case MOVIE.hsl5004_sol3:
		case MOVIE.hsl5004_sol4:
			switch (hOHStage)
			{
			case 0:
				result = 484;
				break;
			case 1:
				result = 484;
				break;
			case 2:
				result = 485;
				break;
			case 3:
				result = 485;
				break;
			case 4:
				result = 486;
				break;
			case 5:
				result = 486;
				break;
			case 6:
				result = 486;
				break;
			case 30:
				result = 486;
				break;
			}
			break;
		case MOVIE.hsl5004_sly:
		case MOVIE.hsl5004_sly3:
		case MOVIE.hsl5004_sly4:
			switch (hOHStage)
			{
			case 0:
				result = 487;
				break;
			case 1:
				result = 487;
				break;
			case 2:
				result = 488;
				break;
			case 3:
				result = 488;
				break;
			case 4:
				result = 489;
				break;
			case 5:
				result = 489;
				break;
			case 6:
				result = 489;
				break;
			case 30:
				result = 489;
				break;
			}
			break;
		case MOVIE.hsl5007_sly1:
		case MOVIE.hsl5007_sly2:
		case MOVIE.hsl5007_sly3:
		case MOVIE.hsl5007_sly4:
		case MOVIE.hsl5007_sly5:
			switch (hOHStage)
			{
			case 0:
				result = 491;
				break;
			case 1:
				result = 492;
				break;
			case 2:
				result = 493;
				break;
			case 3:
				result = 495;
				break;
			case 4:
				result = 494;
				break;
			case 5:
				result = 494;
				break;
			case 6:
				result = 494;
				break;
			case 30:
				result = 494;
				break;
			}
			break;
		case MOVIE.hcp5007_chp1:
		case MOVIE.hcp5007_chp2:
		case MOVIE.hcp5007_chp3:
		case MOVIE.hcp5007_chp4:
		case MOVIE.hcp5007_chp5:
			switch (hOHStage)
			{
			case 0:
				result = 2207;
				break;
			case 1:
				result = 2208;
				break;
			case 2:
				result = 2209;
				break;
			case 3:
				result = 2211;
				break;
			case 4:
				result = 2210;
				break;
			case 5:
				result = 2210;
				break;
			case 6:
				result = 2210;
				break;
			case 30:
				result = 2210;
				break;
			}
			break;
		case MOVIE.hml5007_mil1:
		case MOVIE.hml5007_mil2:
		case MOVIE.hml5007_mil3:
		case MOVIE.hml5007_mil4:
		case MOVIE.hml5007_mil5:
			switch (hOHStage)
			{
			case 0:
				result = 2293;
				break;
			case 1:
				result = 2294;
				break;
			case 2:
				result = 2295;
				break;
			case 3:
				result = 2297;
				break;
			case 4:
				result = 2296;
				break;
			case 5:
				result = 2296;
				break;
			case 6:
				result = 2296;
				break;
			case 30:
				result = 2296;
				break;
			}
			break;
		case MOVIE.hbj5007_brg1:
		case MOVIE.hbj5007_brg2:
		case MOVIE.hbj5007_brg3:
		case MOVIE.hbj5007_brg4:
		case MOVIE.hbj5007_brg5:
			switch (hOHStage)
			{
			case 0:
				result = 2383;
				break;
			case 1:
				result = 2385;
				break;
			case 2:
				result = 2387;
				break;
			case 3:
				result = 2391;
				break;
			case 4:
				result = 2389;
				break;
			case 5:
				result = 2389;
				break;
			case 6:
				result = 2389;
				break;
			case 30:
				result = 2389;
				break;
			}
			break;
		case MOVIE.hsl5009_sly1:
		case MOVIE.hsl5009_sly2:
		case MOVIE.hsl5009_sly3:
		case MOVIE.hsl5009_sly4:
		case MOVIE.hsl5009_sly5:
			switch (hOHStage)
			{
			case 0:
				result = 498;
				break;
			case 1:
				result = 499;
				break;
			case 2:
				result = 500;
				break;
			case 3:
				result = 502;
				break;
			case 4:
				result = 501;
				break;
			case 5:
				result = 501;
				break;
			case 6:
				result = 501;
				break;
			case 30:
				result = 501;
				break;
			}
			break;
		case MOVIE.hcp5009_chp1:
		case MOVIE.hcp5009_chp2:
		case MOVIE.hcp5009_chp3:
		case MOVIE.hcp5009_chp4:
		case MOVIE.hcp5009_chp5:
			switch (hOHStage)
			{
			case 0:
				result = 2212;
				break;
			case 1:
				result = 2213;
				break;
			case 2:
				result = 2214;
				break;
			case 3:
				result = 2216;
				break;
			case 4:
				result = 2215;
				break;
			case 5:
				result = 2215;
				break;
			case 6:
				result = 2215;
				break;
			case 30:
				result = 2215;
				break;
			}
			break;
		case MOVIE.hml5009_mil1:
		case MOVIE.hml5009_mil2:
		case MOVIE.hml5009_mil3:
		case MOVIE.hml5009_mil4:
		case MOVIE.hml5009_mil5:
			switch (hOHStage)
			{
			case 0:
				result = 2298;
				break;
			case 1:
				result = 2299;
				break;
			case 2:
				result = 2300;
				break;
			case 3:
				result = 2302;
				break;
			case 4:
				result = 2301;
				break;
			case 5:
				result = 2301;
				break;
			case 6:
				result = 2301;
				break;
			case 30:
				result = 2301;
				break;
			}
			break;
		case MOVIE.hbj5009_brg1:
		case MOVIE.hbj5009_brg2:
		case MOVIE.hbj5009_brg3:
		case MOVIE.hbj5009_brg4:
		case MOVIE.hbj5009_brg5:
			switch (hOHStage)
			{
			case 0:
				result = 2393;
				break;
			case 1:
				result = 2394;
				break;
			case 2:
				result = 2395;
				break;
			case 3:
				result = 2397;
				break;
			case 4:
				result = 2396;
				break;
			case 5:
				result = 2396;
				break;
			case 6:
				result = 2396;
				break;
			case 30:
				result = 2396;
				break;
			}
			break;
		case MOVIE.hsl5009_sol:
		case MOVIE.hsl5009_sol3:
		case MOVIE.hsl5009_sol4:
			switch (hOHStage)
			{
			case 0:
				result = 503;
				break;
			case 1:
				result = 503;
				break;
			case 2:
				result = 504;
				break;
			case 3:
				result = 504;
				break;
			case 4:
				result = 505;
				break;
			case 5:
				result = 505;
				break;
			case 6:
				result = 505;
				break;
			case 30:
				result = 505;
				break;
			}
			break;
		case MOVIE.hsl5010_hai1:
		case MOVIE.hsl5010_hai2:
		case MOVIE.hsl5010_hai3:
		case MOVIE.hsl5010_hai4:
		case MOVIE.hsl5010_hai5:
			switch (hOHStage)
			{
			case 0:
				result = 508;
				break;
			case 1:
				result = 509;
				break;
			case 2:
				result = 510;
				break;
			case 3:
				result = 512;
				break;
			case 4:
				result = 511;
				break;
			case 5:
				result = 511;
				break;
			case 6:
				result = 511;
				break;
			case 30:
				result = 511;
				break;
			}
			break;
		case MOVIE.hsl5010_sol:
		case MOVIE.hsl5010_sol3:
		case MOVIE.hsl5010_sol4:
			switch (hOHStage)
			{
			case 0:
				result = 513;
				break;
			case 1:
				result = 513;
				break;
			case 2:
				result = 514;
				break;
			case 3:
				result = 514;
				break;
			case 4:
				result = 515;
				break;
			case 5:
				result = 515;
				break;
			case 6:
				result = 515;
				break;
			case 30:
				result = 515;
				break;
			}
			break;
		case MOVIE.hsl5011_sol:
		case MOVIE.hsl5011_sol3:
		case MOVIE.hsl5011_sol4:
			switch (hOHStage)
			{
			case 0:
				result = 516;
				break;
			case 1:
				result = 516;
				break;
			case 2:
				result = 517;
				break;
			case 3:
				result = 517;
				break;
			case 4:
				result = 518;
				break;
			case 5:
				result = 518;
				break;
			case 6:
				result = 518;
				break;
			case 30:
				result = 518;
				break;
			}
			break;
		case MOVIE.hsl5010_sly:
		case MOVIE.hsl5010_sly3:
		case MOVIE.hsl5010_sly4:
			switch (hOHStage)
			{
			case 0:
				result = 519;
				break;
			case 1:
				result = 519;
				break;
			case 2:
				result = 520;
				break;
			case 3:
				result = 520;
				break;
			case 4:
				result = 521;
				break;
			case 5:
				result = 521;
				break;
			case 6:
				result = 521;
				break;
			case 30:
				result = 521;
				break;
			}
			break;
		case MOVIE.hsl5013_hai1:
		case MOVIE.hsl5013_hai2:
		case MOVIE.hsl5013_hai3:
		case MOVIE.hsl5013_hai4:
		case MOVIE.hsl5013_hai5:
			switch (hOHStage)
			{
			case 0:
				result = 522;
				break;
			case 1:
				result = 523;
				break;
			case 2:
				result = 524;
				break;
			case 3:
				result = 526;
				break;
			case 4:
				result = 525;
				break;
			case 5:
				result = 525;
				break;
			case 6:
				result = 525;
				break;
			case 30:
				result = 525;
				break;
			}
			break;
		case MOVIE.hsl5013_sol:
		case MOVIE.hsl5013_sol3:
		case MOVIE.hsl5013_sol4:
			switch (hOHStage)
			{
			case 0:
				result = 527;
				break;
			case 1:
				result = 527;
				break;
			case 2:
				result = 528;
				break;
			case 3:
				result = 528;
				break;
			case 4:
				result = 529;
				break;
			case 5:
				result = 529;
				break;
			case 6:
				result = 529;
				break;
			case 30:
				result = 529;
				break;
			}
			break;
		case MOVIE.hsl5013_sly:
		case MOVIE.hsl5013_sly3:
		case MOVIE.hsl5013_sly4:
			switch (hOHStage)
			{
			case 0:
				result = 530;
				break;
			case 1:
				result = 530;
				break;
			case 2:
				result = 531;
				break;
			case 3:
				result = 531;
				break;
			case 4:
				result = 532;
				break;
			case 5:
				result = 532;
				break;
			case 6:
				result = 532;
				break;
			case 30:
				result = 532;
				break;
			}
			break;
		case MOVIE.hsl5005_sly:
		case MOVIE.hsl5005_sly3:
		case MOVIE.hsl5005_sly4:
			switch (hOHStage)
			{
			case 0:
				result = 541;
				break;
			case 1:
				result = 541;
				break;
			case 2:
				result = 542;
				break;
			case 3:
				result = 542;
				break;
			case 4:
				result = 543;
				break;
			case 5:
				result = 543;
				break;
			case 6:
				result = 543;
				break;
			case 30:
				result = 543;
				break;
			}
			break;
		case MOVIE.hsl5006_sly:
		case MOVIE.hsl5006_sly3:
		case MOVIE.hsl5006_sly4:
			switch (hOHStage)
			{
			case 0:
				result = 544;
				break;
			case 1:
				result = 544;
				break;
			case 2:
				result = 545;
				break;
			case 3:
				result = 545;
				break;
			case 4:
				result = 546;
				break;
			case 5:
				result = 546;
				break;
			case 6:
				result = 546;
				break;
			case 30:
				result = 546;
				break;
			}
			break;
		case MOVIE.hcp1002_chp:
		case MOVIE.hcp1002_chp_3:
		case MOVIE.hcp1002_chp_4:
			switch (hOHStage)
			{
			case 0:
				result = 2140;
				break;
			case 1:
				result = 2140;
				break;
			case 2:
				result = 2142;
				break;
			case 3:
				result = 2142;
				break;
			case 4:
				result = 2144;
				break;
			case 5:
				result = 2144;
				break;
			case 6:
				result = 2144;
				break;
			case 30:
				result = 2144;
				break;
			}
			break;
		case MOVIE.hcp1002_chp_loop:
		case MOVIE.hcp1002_chp_3_loop:
		case MOVIE.hcp1002_chp_4_loop:
			switch (hOHStage)
			{
			case 0:
				result = 2141;
				break;
			case 1:
				result = 2141;
				break;
			case 2:
				result = 2143;
				break;
			case 3:
				result = 2143;
				break;
			case 4:
				result = 2145;
				break;
			case 5:
				result = 2145;
				break;
			case 6:
				result = 2145;
				break;
			case 30:
				result = 2145;
				break;
			}
			break;
		case MOVIE.hcp2001_chp:
		case MOVIE.hcp2001_chp_3:
		case MOVIE.hcp2001_chp_4:
			switch (hOHStage)
			{
			case 0:
				result = 2146;
				break;
			case 1:
				result = 2146;
				break;
			case 2:
				result = 2147;
				break;
			case 3:
				result = 2147;
				break;
			case 4:
				result = 2148;
				break;
			case 5:
				result = 2148;
				break;
			case 6:
				result = 2148;
				break;
			case 30:
				result = 2148;
				break;
			}
			break;
		case MOVIE.hcp5004_chp:
		case MOVIE.hcp5004_chp_3:
		case MOVIE.hcp5004_chp_4:
			switch (hOHStage)
			{
			case 0:
				result = 2204;
				break;
			case 1:
				result = 2204;
				break;
			case 2:
				result = 2205;
				break;
			case 3:
				result = 2205;
				break;
			case 4:
				result = 2206;
				break;
			case 5:
				result = 2206;
				break;
			case 6:
				result = 2206;
				break;
			case 30:
				result = 2206;
				break;
			}
			break;
		case MOVIE.hcp5010_chp:
		case MOVIE.hcp5010_chp_3:
		case MOVIE.hcp5010_chp_4:
			switch (hOHStage)
			{
			case 0:
				result = 2217;
				break;
			case 1:
				result = 2217;
				break;
			case 2:
				result = 2218;
				break;
			case 3:
				result = 2218;
				break;
			case 4:
				result = 2219;
				break;
			case 5:
				result = 2219;
				break;
			case 6:
				result = 2219;
				break;
			case 30:
				result = 2219;
				break;
			}
			break;
		case MOVIE.hcp5013_chp:
		case MOVIE.hcp5013_chp_3:
		case MOVIE.hcp5013_chp_4:
			switch (hOHStage)
			{
			case 0:
				result = 2220;
				break;
			case 1:
				result = 2220;
				break;
			case 2:
				result = 2221;
				break;
			case 3:
				result = 2221;
				break;
			case 4:
				result = 2222;
				break;
			case 5:
				result = 2222;
				break;
			case 6:
				result = 2222;
				break;
			case 30:
				result = 2222;
				break;
			}
			break;
		case MOVIE.hml1002_mil:
		case MOVIE.hml1002_mil_3:
		case MOVIE.hml1002_mil_4:
			switch (hOHStage)
			{
			case 0:
				result = 2225;
				break;
			case 1:
				result = 2225;
				break;
			case 2:
				result = 2227;
				break;
			case 3:
				result = 2227;
				break;
			case 4:
				result = 2229;
				break;
			case 5:
				result = 2229;
				break;
			case 6:
				result = 2229;
				break;
			case 30:
				result = 2229;
				break;
			}
			break;
		case MOVIE.hml1002_mil_loop:
		case MOVIE.hml1002_mil_3_loop:
		case MOVIE.hml1002_mil_4_loop:
			switch (hOHStage)
			{
			case 0:
				result = 2226;
				break;
			case 1:
				result = 2226;
				break;
			case 2:
				result = 2228;
				break;
			case 3:
				result = 2228;
				break;
			case 4:
				result = 2230;
				break;
			case 5:
				result = 2230;
				break;
			case 6:
				result = 2230;
				break;
			case 30:
				result = 2230;
				break;
			}
			break;
		case MOVIE.hml2001_mil:
		case MOVIE.hml2001_mil_3:
		case MOVIE.hml2001_mil_4:
			switch (hOHStage)
			{
			case 0:
				result = 2231;
				break;
			case 1:
				result = 2231;
				break;
			case 2:
				result = 2232;
				break;
			case 3:
				result = 2232;
				break;
			case 4:
				result = 2233;
				break;
			case 5:
				result = 2233;
				break;
			case 6:
				result = 2233;
				break;
			case 30:
				result = 2233;
				break;
			}
			break;
		case MOVIE.hml5004_mil:
		case MOVIE.hml5004_mil_3:
		case MOVIE.hml5004_mil_4:
			switch (hOHStage)
			{
			case 0:
				result = 2290;
				break;
			case 1:
				result = 2290;
				break;
			case 2:
				result = 2291;
				break;
			case 3:
				result = 2291;
				break;
			case 4:
				result = 2292;
				break;
			case 5:
				result = 2292;
				break;
			case 6:
				result = 2292;
				break;
			case 30:
				result = 2292;
				break;
			}
			break;
		case MOVIE.hml5010_mil:
		case MOVIE.hml5010_mil_3:
		case MOVIE.hml5010_mil_4:
			switch (hOHStage)
			{
			case 0:
				result = 2303;
				break;
			case 1:
				result = 2303;
				break;
			case 2:
				result = 2304;
				break;
			case 3:
				result = 2304;
				break;
			case 4:
				result = 2305;
				break;
			case 5:
				result = 2305;
				break;
			case 6:
				result = 2305;
				break;
			case 30:
				result = 2305;
				break;
			}
			break;
		case MOVIE.hml5013_mil:
		case MOVIE.hml5013_mil_3:
		case MOVIE.hml5013_mil_4:
			switch (hOHStage)
			{
			case 0:
				result = 2306;
				break;
			case 1:
				result = 2306;
				break;
			case 2:
				result = 2307;
				break;
			case 3:
				result = 2307;
				break;
			case 4:
				result = 2308;
				break;
			case 5:
				result = 2308;
				break;
			case 6:
				result = 2308;
				break;
			case 30:
				result = 2308;
				break;
			}
			break;
		case MOVIE.hbj1002_brg:
		case MOVIE.hbj1002_brg_3:
		case MOVIE.hbj1002_brg_4:
			switch (hOHStage)
			{
			case 0:
				result = 2311;
				break;
			case 1:
				result = 2311;
				break;
			case 2:
				result = 2313;
				break;
			case 3:
				result = 2313;
				break;
			case 4:
				result = 2315;
				break;
			case 5:
				result = 2315;
				break;
			case 6:
				result = 2315;
				break;
			case 30:
				result = 2315;
				break;
			}
			break;
		case MOVIE.hbj1002_brg_loop:
		case MOVIE.hbj1002_brg_3_loop:
		case MOVIE.hbj1002_brg_4_loop:
			switch (hOHStage)
			{
			case 0:
				result = 2312;
				break;
			case 1:
				result = 2312;
				break;
			case 2:
				result = 2314;
				break;
			case 3:
				result = 2314;
				break;
			case 4:
				result = 2316;
				break;
			case 5:
				result = 2316;
				break;
			case 6:
				result = 2316;
				break;
			case 30:
				result = 2316;
				break;
			}
			break;
		case MOVIE.hbj2001_brg:
		case MOVIE.hbj2001_brg_3:
		case MOVIE.hbj2001_brg_4:
			switch (hOHStage)
			{
			case 0:
				result = 2317;
				break;
			case 1:
				result = 2317;
				break;
			case 2:
				result = 2318;
				break;
			case 3:
				result = 2318;
				break;
			case 4:
				result = 2319;
				break;
			case 5:
				result = 2319;
				break;
			case 6:
				result = 2319;
				break;
			case 30:
				result = 2319;
				break;
			}
			break;
		case MOVIE.hbj5004_brg:
		case MOVIE.hbj5004_brg_3:
		case MOVIE.hbj5004_brg_4:
			switch (hOHStage)
			{
			case 0:
				result = 2377;
				break;
			case 1:
				result = 2377;
				break;
			case 2:
				result = 2379;
				break;
			case 3:
				result = 2379;
				break;
			case 4:
				result = 2381;
				break;
			case 5:
				result = 2381;
				break;
			case 6:
				result = 2381;
				break;
			case 30:
				result = 2381;
				break;
			}
			break;
		case MOVIE.hbj5010_brg:
		case MOVIE.hbj5010_brg_3:
		case MOVIE.hbj5010_brg_4:
			switch (hOHStage)
			{
			case 0:
				result = 2400;
				break;
			case 1:
				result = 2400;
				break;
			case 2:
				result = 2401;
				break;
			case 3:
				result = 2401;
				break;
			case 4:
				result = 2402;
				break;
			case 5:
				result = 2402;
				break;
			case 6:
				result = 2402;
				break;
			case 30:
				result = 2402;
				break;
			}
			break;
		case MOVIE.hbj5013_brg:
		case MOVIE.hbj5013_brg_3:
		case MOVIE.hbj5013_brg_4:
			switch (hOHStage)
			{
			case 0:
				result = 2403;
				break;
			case 1:
				result = 2403;
				break;
			case 2:
				result = 2404;
				break;
			case 3:
				result = 2404;
				break;
			case 4:
				result = 2405;
				break;
			case 5:
				result = 2405;
				break;
			case 6:
				result = 2405;
				break;
			case 30:
				result = 2405;
				break;
			}
			break;
		case MOVIE.hzp1002_zap:
		case MOVIE.hzp1002_zap_3:
		case MOVIE.hzp1002_zap_4:
			switch (hOHStage)
			{
			case 0:
				result = 2408;
				break;
			case 1:
				result = 2408;
				break;
			case 2:
				result = 2410;
				break;
			case 3:
				result = 2410;
				break;
			case 4:
				result = 2412;
				break;
			case 5:
				result = 2412;
				break;
			case 6:
				result = 2412;
				break;
			case 30:
				result = 2412;
				break;
			}
			break;
		case MOVIE.hzp1002_zap_loop:
		case MOVIE.hzp1002_zap_3_loop:
		case MOVIE.hzp1002_zap_4_loop:
			switch (hOHStage)
			{
			case 0:
				result = 2409;
				break;
			case 1:
				result = 2409;
				break;
			case 2:
				result = 2411;
				break;
			case 3:
				result = 2411;
				break;
			case 4:
				result = 2413;
				break;
			case 5:
				result = 2413;
				break;
			case 6:
				result = 2413;
				break;
			case 30:
				result = 2413;
				break;
			}
			break;
		case MOVIE.hzp2001_zap:
		case MOVIE.hzp2001_zap_3:
		case MOVIE.hzp2001_zap_4:
			switch (hOHStage)
			{
			case 0:
				result = 2414;
				break;
			case 1:
				result = 2414;
				break;
			case 2:
				result = 2415;
				break;
			case 3:
				result = 2415;
				break;
			case 4:
				result = 2416;
				break;
			case 5:
				result = 2416;
				break;
			case 6:
				result = 2416;
				break;
			case 30:
				result = 2416;
				break;
			}
			break;
		case MOVIE.hzp5010_zap:
		case MOVIE.hzp5010_zap_3:
		case MOVIE.hzp5010_zap_4:
			switch (hOHStage)
			{
			case 0:
				result = 2420;
				break;
			case 1:
				result = 2420;
				break;
			case 2:
				result = 2421;
				break;
			case 3:
				result = 2421;
				break;
			case 4:
				result = 2422;
				break;
			case 5:
				result = 2422;
				break;
			case 6:
				result = 2422;
				break;
			case 30:
				result = 2422;
				break;
			}
			break;
		case MOVIE.kkt001:
		case MOVIE.kkt001_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1707;
				break;
			case 1:
				result = 1707;
				break;
			case 2:
				result = 1882;
				break;
			}
			break;
		case MOVIE.kkt001_hai_mati:
		case MOVIE.kkt001_hai_kai:
		case MOVIE.kkt001_hai_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1861;
				break;
			case 1:
				result = 1868;
				break;
			case 2:
				result = 1875;
				break;
			}
			break;
		case MOVIE.kkt002_hai_mati:
		case MOVIE.kkt002_hai_kai:
		case MOVIE.kkt002_hai_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1862;
				break;
			case 1:
				result = 1869;
				break;
			case 2:
				result = 1876;
				break;
			}
			break;
		case MOVIE.kkt002a_blue:
		case MOVIE.kkt002a_blue_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1711;
				break;
			case 1:
				result = 1711;
				break;
			case 2:
				result = 1885;
				break;
			}
			break;
		case MOVIE.kkt002a_blue_loop:
		case MOVIE.kkt002a_blue_ya_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1712;
				break;
			case 1:
				result = 1712;
				break;
			case 2:
				result = 1886;
				break;
			}
			break;
		case MOVIE.kkt002a_green:
		case MOVIE.kkt002a_green_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1715;
				break;
			case 1:
				result = 1715;
				break;
			case 2:
				result = 1889;
				break;
			}
			break;
		case MOVIE.kkt002a_green_loop:
		case MOVIE.kkt002a_green_ya_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1716;
				break;
			case 1:
				result = 1716;
				break;
			case 2:
				result = 1890;
				break;
			}
			break;
		case MOVIE.kkt002a_purple:
		case MOVIE.kkt002a_purple_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1719;
				break;
			case 1:
				result = 1719;
				break;
			case 2:
				result = 1893;
				break;
			}
			break;
		case MOVIE.kkt002a_purple_loop:
		case MOVIE.kkt002a_purple_ya_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1720;
				break;
			case 1:
				result = 1720;
				break;
			case 2:
				result = 1894;
				break;
			}
			break;
		case MOVIE.kkt002a_rainbow:
		case MOVIE.kkt002a_rainbow_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1723;
				break;
			case 1:
				result = 1723;
				break;
			case 2:
				result = 1897;
				break;
			}
			break;
		case MOVIE.kkt002a_rainbow_loop:
		case MOVIE.kkt002a_rainbow_ya_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1724;
				break;
			case 1:
				result = 1724;
				break;
			case 2:
				result = 1898;
				break;
			}
			break;
		case MOVIE.kkt002a_red:
		case MOVIE.kkt002a_red_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1717;
				break;
			case 1:
				result = 1717;
				break;
			case 2:
				result = 1891;
				break;
			}
			break;
		case MOVIE.kkt002a_red_loop:
		case MOVIE.kkt002a_red_ya_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1718;
				break;
			case 1:
				result = 1718;
				break;
			case 2:
				result = 1892;
				break;
			}
			break;
		case MOVIE.kkt002a_tento:
		case MOVIE.kkt002a_tento_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1721;
				break;
			case 1:
				result = 1721;
				break;
			case 2:
				result = 1895;
				break;
			}
			break;
		case MOVIE.kkt002a_tento_loop:
		case MOVIE.kkt002a_tento_ya_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1722;
				break;
			case 1:
				result = 1722;
				break;
			case 2:
				result = 1896;
				break;
			}
			break;
		case MOVIE.kkt002a_white:
		case MOVIE.kkt002a_white_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1709;
				break;
			case 1:
				result = 1709;
				break;
			case 2:
				result = 1883;
				break;
			}
			break;
		case MOVIE.kkt002a_white_loop:
		case MOVIE.kkt002a_white_ya_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1710;
				break;
			case 1:
				result = 1710;
				break;
			case 2:
				result = 1884;
				break;
			}
			break;
		case MOVIE.kkt002a_yellow:
		case MOVIE.kkt002a_yellow_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1713;
				break;
			case 1:
				result = 1713;
				break;
			case 2:
				result = 1887;
				break;
			}
			break;
		case MOVIE.kkt002a_yellow_loop:
		case MOVIE.kkt002a_yellow_ya_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1714;
				break;
			case 1:
				result = 1714;
				break;
			case 2:
				result = 1888;
				break;
			}
			break;
		case MOVIE.kkt002b_blue:
		case MOVIE.kkt002b_blue_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1727;
				break;
			case 1:
				result = 1727;
				break;
			case 2:
				result = 1901;
				break;
			}
			break;
		case MOVIE.kkt002b_blue_loop:
		case MOVIE.kkt002b_blue_ya_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1728;
				break;
			case 1:
				result = 1728;
				break;
			case 2:
				result = 1902;
				break;
			}
			break;
		case MOVIE.kkt002b_green:
		case MOVIE.kkt002b_green_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1731;
				break;
			case 1:
				result = 1731;
				break;
			case 2:
				result = 1905;
				break;
			}
			break;
		case MOVIE.kkt002b_green_loop:
		case MOVIE.kkt002b_green_ya_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1732;
				break;
			case 1:
				result = 1732;
				break;
			case 2:
				result = 1906;
				break;
			}
			break;
		case MOVIE.kkt002b_purple:
		case MOVIE.kkt002b_purple_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1735;
				break;
			case 1:
				result = 1735;
				break;
			case 2:
				result = 1909;
				break;
			}
			break;
		case MOVIE.kkt002b_purple_loop:
		case MOVIE.kkt002b_purple_ya_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1736;
				break;
			case 1:
				result = 1736;
				break;
			case 2:
				result = 1910;
				break;
			}
			break;
		case MOVIE.kkt002b_rainbow:
		case MOVIE.kkt002b_rainbow_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1739;
				break;
			case 1:
				result = 1739;
				break;
			case 2:
				result = 1913;
				break;
			}
			break;
		case MOVIE.kkt002b_rainbow_loop:
		case MOVIE.kkt002b_rainbow_ya_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1740;
				break;
			case 1:
				result = 1740;
				break;
			case 2:
				result = 1914;
				break;
			}
			break;
		case MOVIE.kkt002b_red:
		case MOVIE.kkt002b_red_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1733;
				break;
			case 1:
				result = 1733;
				break;
			case 2:
				result = 1907;
				break;
			}
			break;
		case MOVIE.kkt002b_red_loop:
		case MOVIE.kkt002b_red_ya_loopv:
			switch (hOHStage)
			{
			case 0:
				result = 1734;
				break;
			case 1:
				result = 1734;
				break;
			case 2:
				result = 1908;
				break;
			}
			break;
		case MOVIE.kkt002b_tento:
		case MOVIE.kkt002b_tento_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1737;
				break;
			case 1:
				result = 1737;
				break;
			case 2:
				result = 1911;
				break;
			}
			break;
		case MOVIE.kkt002b_tento_loop:
		case MOVIE.kkt002b_tento_ya_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1738;
				break;
			case 1:
				result = 1738;
				break;
			case 2:
				result = 1912;
				break;
			}
			break;
		case MOVIE.kkt002b_white:
		case MOVIE.kkt002b_white_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1725;
				break;
			case 1:
				result = 1725;
				break;
			case 2:
				result = 1899;
				break;
			}
			break;
		case MOVIE.kkt002b_white_loop:
		case MOVIE.kkt002b_white_ya_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1726;
				break;
			case 1:
				result = 1726;
				break;
			case 2:
				result = 1900;
				break;
			}
			break;
		case MOVIE.kkt002b_yellow:
		case MOVIE.kkt002b_yellow_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1729;
				break;
			case 1:
				result = 1729;
				break;
			case 2:
				result = 1903;
				break;
			}
			break;
		case MOVIE.kkt002b_yellow_loop:
		case MOVIE.kkt002b_yellow_ya_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1730;
				break;
			case 1:
				result = 1730;
				break;
			case 2:
				result = 1904;
				break;
			}
			break;
		case MOVIE.kkt003_hai_mati:
		case MOVIE.kkt003_hai_kai:
		case MOVIE.kkt003_hai_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1863;
				break;
			case 1:
				result = 1870;
				break;
			case 2:
				result = 1877;
				break;
			}
			break;
		case MOVIE.kkt003_hai_mati2:
		case MOVIE.kkt003_hai_kai2:
		case MOVIE.kkt003_hai_ya2:
			switch (hOHStage)
			{
			case 0:
				result = 1864;
				break;
			case 1:
				result = 1871;
				break;
			case 2:
				result = 1878;
				break;
			}
			break;
		case MOVIE.kkt003_sol:
		case MOVIE.kkt003_sol_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1741;
				break;
			case 1:
				result = 1741;
				break;
			case 2:
				result = 1915;
				break;
			}
			break;
		case MOVIE.kkt003a_a_blue:
		case MOVIE.kkt003a_a_blue_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1746;
				break;
			case 1:
				result = 1746;
				break;
			case 2:
				result = 1919;
				break;
			}
			break;
		case MOVIE.kkt003a_a_blue_down:
		case MOVIE.kkt003a_a_blue_ya_down:
			switch (hOHStage)
			{
			case 0:
				result = 1747;
				break;
			case 1:
				result = 1747;
				break;
			case 2:
				result = 1920;
				break;
			}
			break;
		case MOVIE.kkt003a_a_blue_down_loop:
		case MOVIE.kkt003a_a_blue_ya_down_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1748;
				break;
			case 1:
				result = 1748;
				break;
			case 2:
				result = 1921;
				break;
			}
			break;
		case MOVIE.kkt003a_a_green:
		case MOVIE.kkt003a_a_green_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1752;
				break;
			case 1:
				result = 1752;
				break;
			case 2:
				result = 1925;
				break;
			}
			break;
		case MOVIE.kkt003a_a_green_down:
		case MOVIE.kkt003a_a_green_ya_down:
			switch (hOHStage)
			{
			case 0:
				result = 1753;
				break;
			case 1:
				result = 1753;
				break;
			case 2:
				result = 1926;
				break;
			}
			break;
		case MOVIE.kkt003a_a_green_down_loop:
		case MOVIE.kkt003a_a_green_ya_down_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1754;
				break;
			case 1:
				result = 1754;
				break;
			case 2:
				result = 1927;
				break;
			}
			break;
		case MOVIE.kkt003a_a_purple:
		case MOVIE.kkt003a_a_purple_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1758;
				break;
			case 1:
				result = 1758;
				break;
			case 2:
				result = 1931;
				break;
			}
			break;
		case MOVIE.kkt003a_a_purple_down:
		case MOVIE.kkt003a_a_purple_ya_down:
			switch (hOHStage)
			{
			case 0:
				result = 1759;
				break;
			case 1:
				result = 1759;
				break;
			case 2:
				result = 1932;
				break;
			}
			break;
		case MOVIE.kkt003a_a_purple_down_loop:
		case MOVIE.kkt003a_a_purple_ya_down_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1760;
				break;
			case 1:
				result = 1760;
				break;
			case 2:
				result = 1933;
				break;
			}
			break;
		case MOVIE.kkt003a_a_rainbow:
		case MOVIE.kkt003a_a_rainbow_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1764;
				break;
			case 1:
				result = 1764;
				break;
			case 2:
				result = 1937;
				break;
			}
			break;
		case MOVIE.kkt003a_a_rainbow_down:
		case MOVIE.kkt003a_a_rainbow_ya_down:
			switch (hOHStage)
			{
			case 0:
				result = 1765;
				break;
			case 1:
				result = 1765;
				break;
			case 2:
				result = 1938;
				break;
			}
			break;
		case MOVIE.kkt003a_a_rainbow_down_loop:
		case MOVIE.kkt003a_a_rainbow_ya_down_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1766;
				break;
			case 1:
				result = 1766;
				break;
			case 2:
				result = 1939;
				break;
			}
			break;
		case MOVIE.kkt003a_a_red:
		case MOVIE.kkt003a_a_red_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1755;
				break;
			case 1:
				result = 1755;
				break;
			case 2:
				result = 1928;
				break;
			}
			break;
		case MOVIE.kkt003a_a_red_down:
		case MOVIE.kkt003a_a_red_ya_down:
			switch (hOHStage)
			{
			case 0:
				result = 1756;
				break;
			case 1:
				result = 1756;
				break;
			case 2:
				result = 1929;
				break;
			}
			break;
		case MOVIE.kkt003a_a_red_down_loop:
		case MOVIE.kkt003a_a_red_ya_down_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1757;
				break;
			case 1:
				result = 1757;
				break;
			case 2:
				result = 1930;
				break;
			}
			break;
		case MOVIE.kkt003a_a_tento:
		case MOVIE.kkt003a_a_tento_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1761;
				break;
			case 1:
				result = 1761;
				break;
			case 2:
				result = 1934;
				break;
			}
			break;
		case MOVIE.kkt003a_a_tento_down:
		case MOVIE.kkt003a_a_tento_ya_down:
			switch (hOHStage)
			{
			case 0:
				result = 1762;
				break;
			case 1:
				result = 1762;
				break;
			case 2:
				result = 1935;
				break;
			}
			break;
		case MOVIE.kkt003a_a_tento_down_loop:
		case MOVIE.kkt003a_a_tento_ya_down_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1763;
				break;
			case 1:
				result = 1763;
				break;
			case 2:
				result = 1936;
				break;
			}
			break;
		case MOVIE.kkt003a_a_white:
		case MOVIE.kkt003a_a_white_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1743;
				break;
			case 1:
				result = 1743;
				break;
			case 2:
				result = 1916;
				break;
			}
			break;
		case MOVIE.kkt003a_a_white_down:
		case MOVIE.kkt003a_a_white_ya_down:
			switch (hOHStage)
			{
			case 0:
				result = 1744;
				break;
			case 1:
				result = 1744;
				break;
			case 2:
				result = 1917;
				break;
			}
			break;
		case MOVIE.kkt003a_a_white_down_loop:
		case MOVIE.kkt003a_a_white_ya_down_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1745;
				break;
			case 1:
				result = 1745;
				break;
			case 2:
				result = 1918;
				break;
			}
			break;
		case MOVIE.kkt003a_a_yellow:
		case MOVIE.kkt003a_a_yellow_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1749;
				break;
			case 1:
				result = 1749;
				break;
			case 2:
				result = 1922;
				break;
			}
			break;
		case MOVIE.kkt003a_a_yellow_down:
		case MOVIE.kkt003a_a_yellow_ya_down:
			switch (hOHStage)
			{
			case 0:
				result = 1750;
				break;
			case 1:
				result = 1750;
				break;
			case 2:
				result = 1923;
				break;
			}
			break;
		case MOVIE.kkt003a_a_yellow_down_loop:
		case MOVIE.kkt003a_a_yellow_ya_down_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1751;
				break;
			case 1:
				result = 1751;
				break;
			case 2:
				result = 1924;
				break;
			}
			break;
		case MOVIE.kkt003a_b_blue:
		case MOVIE.kkt003a_b_blue_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1792;
				break;
			case 1:
				result = 1792;
				break;
			case 2:
				result = 1965;
				break;
			}
			break;
		case MOVIE.kkt003a_b_green:
		case MOVIE.kkt003a_b_green_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1794;
				break;
			case 1:
				result = 1794;
				break;
			case 2:
				result = 1967;
				break;
			}
			break;
		case MOVIE.kkt003a_b_purple:
		case MOVIE.kkt003a_b_purple_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1796;
				break;
			case 1:
				result = 1796;
				break;
			case 2:
				result = 1969;
				break;
			}
			break;
		case MOVIE.kkt003a_b_rainbow:
		case MOVIE.kkt003a_b_rainbow_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1798;
				break;
			case 1:
				result = 1798;
				break;
			case 2:
				result = 1971;
				break;
			}
			break;
		case MOVIE.kkt003a_b_red:
		case MOVIE.kkt003a_b_red_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1795;
				break;
			case 1:
				result = 1795;
				break;
			case 2:
				result = 1968;
				break;
			}
			break;
		case MOVIE.kkt003a_b_tento:
		case MOVIE.kkt003a_b_tento_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1797;
				break;
			case 1:
				result = 1797;
				break;
			case 2:
				result = 1970;
				break;
			}
			break;
		case MOVIE.kkt003a_b_white:
		case MOVIE.kkt003a_b_white_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1791;
				break;
			case 1:
				result = 1791;
				break;
			case 2:
				result = 1964;
				break;
			}
			break;
		case MOVIE.kkt003a_b_yellow:
		case MOVIE.kkt003a_b_yellow_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1793;
				break;
			case 1:
				result = 1793;
				break;
			case 2:
				result = 1966;
				break;
			}
			break;
		case MOVIE.kkt003b_a_blue:
		case MOVIE.kkt003b_a_blue_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1770;
				break;
			case 1:
				result = 1770;
				break;
			case 2:
				result = 1943;
				break;
			}
			break;
		case MOVIE.kkt003b_a_blue_down:
		case MOVIE.kkt003b_a_blue_ya_down:
			switch (hOHStage)
			{
			case 0:
				result = 1771;
				break;
			case 1:
				result = 1771;
				break;
			case 2:
				result = 1944;
				break;
			}
			break;
		case MOVIE.kkt003b_a_blue_down_loop:
		case MOVIE.kkt003b_a_blue_ya_down_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1772;
				break;
			case 1:
				result = 1772;
				break;
			case 2:
				result = 1945;
				break;
			}
			break;
		case MOVIE.kkt003b_a_green:
		case MOVIE.kkt003b_a_green_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1776;
				break;
			case 1:
				result = 1776;
				break;
			case 2:
				result = 1949;
				break;
			}
			break;
		case MOVIE.kkt003b_a_green_down:
		case MOVIE.kkt003b_a_green_ya_down:
			switch (hOHStage)
			{
			case 0:
				result = 1777;
				break;
			case 1:
				result = 1777;
				break;
			case 2:
				result = 1950;
				break;
			}
			break;
		case MOVIE.kkt003b_a_green_down_loop:
		case MOVIE.kkt003b_a_green_ya_down_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1778;
				break;
			case 1:
				result = 1778;
				break;
			case 2:
				result = 1951;
				break;
			}
			break;
		case MOVIE.kkt003b_a_purple:
		case MOVIE.kkt003b_a_purple_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1782;
				break;
			case 1:
				result = 1782;
				break;
			case 2:
				result = 1955;
				break;
			}
			break;
		case MOVIE.kkt003b_a_purple_down:
		case MOVIE.kkt003b_a_purple_ya_down:
			switch (hOHStage)
			{
			case 0:
				result = 1783;
				break;
			case 1:
				result = 1783;
				break;
			case 2:
				result = 1956;
				break;
			}
			break;
		case MOVIE.kkt003b_a_purple_down_loop:
		case MOVIE.kkt003b_a_purple_ya_down_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1784;
				break;
			case 1:
				result = 1784;
				break;
			case 2:
				result = 1957;
				break;
			}
			break;
		case MOVIE.kkt003b_a_rainbow:
		case MOVIE.kkt003b_a_rainbow_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1788;
				break;
			case 1:
				result = 1788;
				break;
			case 2:
				result = 1961;
				break;
			}
			break;
		case MOVIE.kkt003b_a_rainbow_down:
		case MOVIE.kkt003b_a_rainbow_ya_down:
			switch (hOHStage)
			{
			case 0:
				result = 1789;
				break;
			case 1:
				result = 1789;
				break;
			case 2:
				result = 1962;
				break;
			}
			break;
		case MOVIE.kkt003b_a_rainbow_down_loop:
		case MOVIE.kkt003b_a_rainbow_ya_down_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1790;
				break;
			case 1:
				result = 1790;
				break;
			case 2:
				result = 1963;
				break;
			}
			break;
		case MOVIE.kkt003b_a_red:
		case MOVIE.kkt003b_a_red_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1779;
				break;
			case 1:
				result = 1779;
				break;
			case 2:
				result = 1952;
				break;
			}
			break;
		case MOVIE.kkt003b_a_red_down:
		case MOVIE.kkt003b_a_red_ya_down:
			switch (hOHStage)
			{
			case 0:
				result = 1780;
				break;
			case 1:
				result = 1780;
				break;
			case 2:
				result = 1953;
				break;
			}
			break;
		case MOVIE.kkt003b_a_red_down_loop:
		case MOVIE.kkt003b_a_red_ya_down_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1781;
				break;
			case 1:
				result = 1781;
				break;
			case 2:
				result = 1954;
				break;
			}
			break;
		case MOVIE.kkt003b_a_tento:
		case MOVIE.kkt003b_a_tento_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1785;
				break;
			case 1:
				result = 1785;
				break;
			case 2:
				result = 1958;
				break;
			}
			break;
		case MOVIE.kkt003b_a_tento_down:
		case MOVIE.kkt003b_a_tento_ya_down:
			switch (hOHStage)
			{
			case 0:
				result = 1786;
				break;
			case 1:
				result = 1786;
				break;
			case 2:
				result = 1959;
				break;
			}
			break;
		case MOVIE.kkt003b_a_tento_down_loop:
		case MOVIE.kkt003b_a_tento_ya_down_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1787;
				break;
			case 1:
				result = 1787;
				break;
			case 2:
				result = 1960;
				break;
			}
			break;
		case MOVIE.kkt003b_a_white:
		case MOVIE.kkt003b_a_white_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1767;
				break;
			case 1:
				result = 1767;
				break;
			case 2:
				result = 1940;
				break;
			}
			break;
		case MOVIE.kkt003b_a_white_down:
		case MOVIE.kkt003b_a_white_ya_down:
			switch (hOHStage)
			{
			case 0:
				result = 1768;
				break;
			case 1:
				result = 1768;
				break;
			case 2:
				result = 1941;
				break;
			}
			break;
		case MOVIE.kkt003b_a_white_down_loop:
		case MOVIE.kkt003b_a_white_ya_down_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1769;
				break;
			case 1:
				result = 1769;
				break;
			case 2:
				result = 1942;
				break;
			}
			break;
		case MOVIE.kkt003b_a_yellow:
		case MOVIE.kkt003b_a_yellow_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1773;
				break;
			case 1:
				result = 1773;
				break;
			case 2:
				result = 1946;
				break;
			}
			break;
		case MOVIE.kkt003b_a_yellow_down:
		case MOVIE.kkt003b_a_yellow_ya_down:
			switch (hOHStage)
			{
			case 0:
				result = 1774;
				break;
			case 1:
				result = 1774;
				break;
			case 2:
				result = 1947;
				break;
			}
			break;
		case MOVIE.kkt003b_a_yellow_down_loop:
		case MOVIE.kkt003b_a_yellow_ya_down_loop:
			switch (hOHStage)
			{
			case 0:
				result = 1775;
				break;
			case 1:
				result = 1775;
				break;
			case 2:
				result = 1948;
				break;
			}
			break;
		case MOVIE.kkt003b_b_blue:
		case MOVIE.kkt003b_b_blue_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1800;
				break;
			case 1:
				result = 1800;
				break;
			case 2:
				result = 1973;
				break;
			}
			break;
		case MOVIE.kkt003b_b_green:
		case MOVIE.kkt003b_b_green_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1802;
				break;
			case 1:
				result = 1802;
				break;
			case 2:
				result = 1975;
				break;
			}
			break;
		case MOVIE.kkt003b_b_purple:
		case MOVIE.kkt003b_b_purple_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1804;
				break;
			case 1:
				result = 1804;
				break;
			case 2:
				result = 1977;
				break;
			}
			break;
		case MOVIE.kkt003b_b_rainbow:
		case MOVIE.kkt003b_b_rainbow_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1806;
				break;
			case 1:
				result = 1806;
				break;
			case 2:
				result = 1979;
				break;
			}
			break;
		case MOVIE.kkt003b_b_red:
		case MOVIE.kkt003b_b_red_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1803;
				break;
			case 1:
				result = 1803;
				break;
			case 2:
				result = 1976;
				break;
			}
			break;
		case MOVIE.kkt003b_b_tento:
		case MOVIE.kkt003b_b_tento_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1805;
				break;
			case 1:
				result = 1805;
				break;
			case 2:
				result = 1978;
				break;
			}
			break;
		case MOVIE.kkt003b_b_white:
		case MOVIE.kkt003b_b_white_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1799;
				break;
			case 1:
				result = 1799;
				break;
			case 2:
				result = 1972;
				break;
			}
			break;
		case MOVIE.kkt003b_b_yellow:
		case MOVIE.kkt003b_b_yellow_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1801;
				break;
			case 1:
				result = 1801;
				break;
			case 2:
				result = 1974;
				break;
			}
			break;
		case MOVIE.kkt004_hai_mati:
		case MOVIE.kkt004_hai_kai:
		case MOVIE.kkt004_hai_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1865;
				break;
			case 1:
				result = 1872;
				break;
			case 2:
				result = 1879;
				break;
			}
			break;
		case MOVIE.kkt004_sin:
		case MOVIE.kkt004_sin_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1809;
				break;
			case 1:
				result = 1809;
				break;
			case 2:
				result = 1980;
				break;
			}
			break;
		case MOVIE.kkt004a_blue:
		case MOVIE.kkt004a_blue_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1811;
				break;
			case 1:
				result = 1811;
				break;
			case 2:
				result = 1982;
				break;
			}
			break;
		case MOVIE.kkt004a_green:
		case MOVIE.kkt004a_green_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1813;
				break;
			case 1:
				result = 1813;
				break;
			case 2:
				result = 1984;
				break;
			}
			break;
		case MOVIE.kkt004a_purple:
		case MOVIE.kkt004a_purple_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1815;
				break;
			case 1:
				result = 1815;
				break;
			case 2:
				result = 1986;
				break;
			}
			break;
		case MOVIE.kkt004a_red:
		case MOVIE.kkt004a_red_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1814;
				break;
			case 1:
				result = 1814;
				break;
			case 2:
				result = 1985;
				break;
			}
			break;
		case MOVIE.kkt004a_tento:
		case MOVIE.kkt004a_tento_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1816;
				break;
			case 1:
				result = 1816;
				break;
			case 2:
				result = 1987;
				break;
			}
			break;
		case MOVIE.kkt004a_white:
		case MOVIE.kkt004a_white_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1810;
				break;
			case 1:
				result = 1810;
				break;
			case 2:
				result = 1981;
				break;
			}
			break;
		case MOVIE.kkt004a_yellow:
		case MOVIE.kkt004a_yellow_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1812;
				break;
			case 1:
				result = 1812;
				break;
			case 2:
				result = 1983;
				break;
			}
			break;
		case MOVIE.kkt004b_blue:
		case MOVIE.kkt004b_blue_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1818;
				break;
			case 1:
				result = 1818;
				break;
			case 2:
				result = 1989;
				break;
			}
			break;
		case MOVIE.kkt004b_green:
		case MOVIE.kkt004b_green_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1820;
				break;
			case 1:
				result = 1820;
				break;
			case 2:
				result = 1991;
				break;
			}
			break;
		case MOVIE.kkt004b_purple:
		case MOVIE.kkt004b_purple_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1822;
				break;
			case 1:
				result = 1822;
				break;
			case 2:
				result = 1993;
				break;
			}
			break;
		case MOVIE.kkt004b_red:
		case MOVIE.kkt004b_red_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1821;
				break;
			case 1:
				result = 1821;
				break;
			case 2:
				result = 1992;
				break;
			}
			break;
		case MOVIE.kkt004b_tento:
		case MOVIE.kkt004b_tento_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1823;
				break;
			case 1:
				result = 1823;
				break;
			case 2:
				result = 1994;
				break;
			}
			break;
		case MOVIE.kkt004b_white:
		case MOVIE.kkt004b_white_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1817;
				break;
			case 1:
				result = 1817;
				break;
			case 2:
				result = 1988;
				break;
			}
			break;
		case MOVIE.kkt004b_yellow:
		case MOVIE.kkt004b_yellow_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1819;
				break;
			case 1:
				result = 1819;
				break;
			case 2:
				result = 1990;
				break;
			}
			break;
		case MOVIE.kkt005_a_yellow:
		case MOVIE.kkt005_a_yellow_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1827;
				break;
			case 1:
				result = 1827;
				break;
			case 2:
				result = 1997;
				break;
			}
			break;
		case MOVIE.kkt005_a_blue:
		case MOVIE.kkt005_a_blue_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1826;
				break;
			case 1:
				result = 1826;
				break;
			case 2:
				result = 1996;
				break;
			}
			break;
		case MOVIE.kkt005_a_green:
		case MOVIE.kkt005_a_green_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1828;
				break;
			case 1:
				result = 1828;
				break;
			case 2:
				result = 1998;
				break;
			}
			break;
		case MOVIE.kkt005_a_purple:
		case MOVIE.kkt005_a_purple_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1830;
				break;
			case 1:
				result = 1830;
				break;
			case 2:
				result = 2000;
				break;
			}
			break;
		case MOVIE.kkt005_a_red:
		case MOVIE.kkt005_a_red_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1829;
				break;
			case 1:
				result = 1829;
				break;
			case 2:
				result = 1999;
				break;
			}
			break;
		case MOVIE.kkt005_a_tento:
		case MOVIE.kkt005_a_tento_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1831;
				break;
			case 1:
				result = 1831;
				break;
			case 2:
				result = 2001;
				break;
			}
			break;
		case MOVIE.kkt005_a_white:
		case MOVIE.kkt005_a_white_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1825;
				break;
			case 1:
				result = 1825;
				break;
			case 2:
				result = 1995;
				break;
			}
			break;
		case MOVIE.kkt005_b_blue:
		case MOVIE.kkt005_b_blue_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1833;
				break;
			case 1:
				result = 1833;
				break;
			case 2:
				result = 2003;
				break;
			}
			break;
		case MOVIE.kkt005_b_green:
		case MOVIE.kkt005_b_green_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1835;
				break;
			case 1:
				result = 1835;
				break;
			case 2:
				result = 2005;
				break;
			}
			break;
		case MOVIE.kkt005_b_purple:
		case MOVIE.kkt005_b_purple_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1837;
				break;
			case 1:
				result = 1837;
				break;
			case 2:
				result = 2007;
				break;
			}
			break;
		case MOVIE.kkt005_b_red:
		case MOVIE.kkt005_b_red_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1836;
				break;
			case 1:
				result = 1836;
				break;
			case 2:
				result = 2006;
				break;
			}
			break;
		case MOVIE.kkt005_b_tento:
		case MOVIE.kkt005_b_tento_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1838;
				break;
			case 1:
				result = 1838;
				break;
			case 2:
				result = 2008;
				break;
			}
			break;
		case MOVIE.kkt005_b_white:
		case MOVIE.kkt005_b_white_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1832;
				break;
			case 1:
				result = 1832;
				break;
			case 2:
				result = 2002;
				break;
			}
			break;
		case MOVIE.kkt005_b_yellow:
		case MOVIE.kkt005_b_yellow_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1834;
				break;
			case 1:
				result = 1834;
				break;
			case 2:
				result = 2004;
				break;
			}
			break;
		case MOVIE.kkt005_hai_mati:
		case MOVIE.kkt005_hai_kai:
		case MOVIE.kkt005_hai_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1866;
				break;
			case 1:
				result = 1873;
				break;
			case 2:
				result = 1880;
				break;
			}
			break;
		case MOVIE.kkt010_hai_mati:
		case MOVIE.kkt010_hai_kai:
		case MOVIE.kkt010_hai_ya:
			switch (hOHStage)
			{
			case 0:
				result = 1867;
				break;
			case 1:
				result = 1874;
				break;
			case 2:
				result = 1881;
				break;
			}
			break;
		}
		return result;
	}

	public static int changeSound(int _id)
	{
		int num = MainGameScene.slotGameMan.get_pkd_data(93);
		int num2 = MainGameScene.slotGameMan.get_pkd_data(653);
		int result = _id;
		switch ((SOUND)_id)
		{
		case SOUND.S1383:
		case SOUND.S1385:
		case SOUND.S1386:
		case SOUND.S1390:
		case SOUND.S1497:
			switch (num2)
			{
			case 1:
				result = 1366;
				break;
			case 2:
				result = 1363;
				break;
			case 3:
				result = 1370;
				break;
			case 4:
				result = 1455;
				break;
			case 5:
				result = 1365;
				break;
			default:
				result = 1366;
				break;
			}
			break;
		case SOUND.S1434:
		case SOUND.S1498:
		case SOUND.S1499:
		case SOUND.S1500:
		case SOUND.S1501:
			switch (num2)
			{
			case 1:
				result = 1404;
				break;
			case 2:
				result = 1457;
				break;
			case 3:
				result = 1459;
				break;
			case 4:
				result = 1456;
				break;
			case 5:
				result = 1458;
				break;
			default:
				result = 1404;
				break;
			}
			break;
		case SOUND.S1485:
		case SOUND.S1502:
		case SOUND.S1503:
		case SOUND.S1550:
		case SOUND.S1551:
			switch (num2)
			{
			case 1:
				result = 1443;
				break;
			case 2:
				result = 1502;
				break;
			case 3:
				result = 1460;
				break;
			case 4:
				result = 1503;
				break;
			case 5:
				result = 1461;
				break;
			default:
				result = 1443;
				break;
			}
			break;
		case SOUND.S1531:
		case SOUND.S1535:
		case SOUND.S1540:
		case SOUND.S1546:
		case SOUND.S1552:
			switch (num2)
			{
			case 1:
				result = 1487;
				break;
			case 2:
				result = 1483;
				break;
			case 3:
				result = 1504;
				break;
			case 4:
				result = 1492;
				break;
			case 5:
				result = 1498;
				break;
			default:
				result = 1487;
				break;
			}
			break;
		}
		return result;
	}

	public void changeStageIntarface(int _stage)
	{
		if (MainGameScene.pnlMan.getStageInfo() != _stage)
		{
			MainGameScene.pnlMan.setStageInfo(_stage);
			switch (_stage)
			{
			case 0:
				MainGameScene.pnlMan.setBase(0);
				MainGameScene.pnlMan.setBase(1);
				break;
			case 1:
				MainGameScene.pnlMan.setBase(0);
				MainGameScene.pnlMan.setBase(2);
				break;
			case 2:
				MainGameScene.pnlMan.setBase(0);
				MainGameScene.pnlMan.setBase(3);
				break;
			case 3:
				MainGameScene.pnlMan.setBase(0);
				MainGameScene.pnlMan.setBase(4);
				break;
			case 4:
				MainGameScene.pnlMan.setBase(0);
				MainGameScene.pnlMan.clearCartridge();
				break;
			case 5:
				MainGameScene.pnlMan.setBase(0);
				MainGameScene.pnlMan.setBase(5);
				MainGameScene.pnlMan.setBase(13);
				MainGameScene.pnlMan.setBase(15);
				MainGameScene.pnlMan.setBase(17);
				break;
			case 6:
				MainGameScene.pnlMan.setBase(0);
				MainGameScene.pnlMan.setBase(6);
				MainGameScene.pnlMan.setBase(13);
				MainGameScene.pnlMan.setBase(15);
				MainGameScene.pnlMan.setBase(17);
				break;
			case 7:
				MainGameScene.pnlMan.setBase(0);
				MainGameScene.pnlMan.setBase(5);
				MainGameScene.pnlMan.setBase(13);
				MainGameScene.pnlMan.setBase(15);
				break;
			case 8:
				MainGameScene.pnlMan.setBase(0);
				MainGameScene.pnlMan.setBase(5);
				break;
			case 9:
				MainGameScene.pnlMan.setBase(0);
				MainGameScene.pnlMan.setBase(13);
				MainGameScene.pnlMan.setBase(15);
				MainGameScene.pnlMan.setBase(17);
				MainGameScene.pnlMan.setBase(22);
				MainGameScene.pnlMan.setBase(27);
				break;
			case 10:
				MainGameScene.pnlMan.setBase(0);
				break;
			case 11:
				MainGameScene.pnlMan.setBase(0);
				MainGameScene.pnlMan.clearCartridge();
				break;
			case 12:
				MainGameScene.pnlMan.setBase(0);
				break;
			case 13:
				MainGameScene.pnlMan.setBase(0);
				MainGameScene.pnlMan.setBase(13);
				MainGameScene.pnlMan.setBase(14);
				MainGameScene.pnlMan.setBase(19);
				MainGameScene.pnlMan.setBase(29);
				break;
			case 14:
				MainGameScene.pnlMan.setBase(0);
				MainGameScene.pnlMan.setBase(13);
				MainGameScene.pnlMan.setBase(14);
				MainGameScene.pnlMan.setBase(20);
				MainGameScene.pnlMan.setBase(29);
				break;
			case 15:
				MainGameScene.pnlMan.setBase(0);
				MainGameScene.pnlMan.setBase(13);
				MainGameScene.pnlMan.setBase(14);
				MainGameScene.pnlMan.setBase(19);
				MainGameScene.pnlMan.setBase(29);
				break;
			case 16:
				MainGameScene.pnlMan.setBase(0);
				MainGameScene.pnlMan.setBase(13);
				MainGameScene.pnlMan.setBase(14);
				MainGameScene.pnlMan.setBase(20);
				MainGameScene.pnlMan.setBase(29);
				break;
			case 17:
				MainGameScene.pnlMan.setBase(0);
				MainGameScene.pnlMan.setBase(13);
				MainGameScene.pnlMan.setBase(14);
				MainGameScene.pnlMan.setBase(22);
				MainGameScene.pnlMan.setBase(21);
				break;
			case 18:
				MainGameScene.pnlMan.setBase(0);
				MainGameScene.pnlMan.setBase(13);
				MainGameScene.pnlMan.setBase(14);
				MainGameScene.pnlMan.setBase(22);
				MainGameScene.pnlMan.setBase(21);
				break;
			case 19:
				MainGameScene.pnlMan.setBase(0);
				MainGameScene.pnlMan.setBase(13);
				MainGameScene.pnlMan.setBase(14);
				MainGameScene.pnlMan.setBase(19);
				break;
			case 20:
				MainGameScene.pnlMan.setBase(0);
				MainGameScene.pnlMan.setBase(13);
				MainGameScene.pnlMan.setBase(14);
				MainGameScene.pnlMan.setBase(18);
				break;
			case 21:
				MainGameScene.pnlMan.setBase(0);
				break;
			case 22:
				MainGameScene.pnlMan.setBase(0);
				break;
			case 23:
				MainGameScene.pnlMan.setBase(0);
				MainGameScene.pnlMan.clearCartridge();
				break;
			case 24:
				MainGameScene.pnlMan.setBase(0);
				break;
			case 25:
				MainGameScene.pnlMan.setBase(0);
				MainGameScene.pnlMan.setBase(28);
				MainGameScene.pnlMan.setBase(30);
				break;
			case 26:
				MainGameScene.pnlMan.setBase(0);
				break;
			case 27:
				MainGameScene.pnlMan.setBase(0);
				MainGameScene.pnlMan.setBase(13);
				MainGameScene.pnlMan.setBase(28);
				MainGameScene.pnlMan.setBase(30);
				break;
			case 28:
				MainGameScene.pnlMan.setBase(0);
				MainGameScene.pnlMan.setBase(13);
				MainGameScene.pnlMan.setBase(23);
				MainGameScene.pnlMan.setBase(28);
				MainGameScene.pnlMan.setBase(30);
				break;
			case 29:
				MainGameScene.pnlMan.setBase(0);
				break;
			case 30:
				MainGameScene.pnlMan.setBase(0);
				MainGameScene.pnlMan.setBase(5);
				MainGameScene.pnlMan.setBase(7);
				MainGameScene.pnlMan.setBase(13);
				MainGameScene.pnlMan.setBase(15);
				MainGameScene.pnlMan.setBase(17);
				break;
			}
			MainGameScene.pnlMan.control(_stage);
		}
	}

	public void demoStart()
	{
		dir[24] = new Direction79ODM(this, 75, 0, 1, DIR.DEMO);
		if (dir[24] != null)
		{
			dir[24].start();
		}
		SGLG.sound.Stop(Sound.CH.BGM);
		DirectionLedManager.demoLedStart();
	}

	public void demoClear()
	{
		StopDirection(DIR.DEMO);
		dir[18] = new DirectionYuugiSnd(this, 87, 0, 0, DIR.YUUGISND);
		if (dir[18] != null)
		{
			dir[18].start();
		}
		DirectionLedManager.demoLedEnd();
	}

	public void pbZugaraStop(int _num)
	{
		switch (_num)
		{
		case 0:
			StopDirection(DIR.YUUGISND);
			dir[18] = new DirectionYuugiSnd(this, 87, 0, 1, DIR.YUUGISND);
			if (dir[18] != null)
			{
				dir[18].start();
			}
			break;
		case 1:
			StopDirection(DIR.YUUGISND);
			dir[18] = new DirectionYuugiSnd(this, 87, 0, 2, DIR.YUUGISND);
			if (dir[18] != null)
			{
				dir[18].start();
			}
			break;
		case 2:
			StopDirection(DIR.YUUGISND);
			dir[18] = new DirectionYuugiSnd(this, 87, 0, 3, DIR.YUUGISND);
			if (dir[18] != null)
			{
				dir[18].start();
			}
			break;
		}
	}

	public void chuChe1stStop()
	{
		StopDirection(DIR.YUUGISND);
		dir[18] = new DirectionYuugiSnd(this, 87, 3, 20, DIR.YUUGISND);
		if (dir[18] != null)
		{
			dir[18].start();
		}
	}

	public void logoYakuSound(int _id)
	{
		StopDirection(DIR.YUUGISND);
		dir[18] = new DirectionYuugiSnd(this, 87, 6, (byte)_id, DIR.YUUGISND);
		if (dir[18] != null)
		{
			dir[18].start();
		}
	}

	private void stopYFC()
	{
		if (MainGameScene.slotGameMan.isChainClr())
		{
			StopDirection(DIR.YFC_CHAIN_1);
			StopDirection(DIR.YFC_CHAIN_2);
			StopDirection(DIR.YFC_CHAIN_3);
		}
	}

	private void stopStage()
	{
		m_stageHigh = byte.MaxValue;
		m_stageLow = byte.MaxValue;
		m_stageMode = byte.MaxValue;
		StopDirection(DIR.STAGE);
		StopDirection(DIR.STAGEPROD);
	}

	private void forceKillStageMovies()
	{
		SGLG.prod.Kill_PlayID(193);
		SGLG.prod.Kill_PlayID(194);
		SGLG.prod.Kill_PlayID(195);
		SGLG.prod.Kill_PlayID(197);
		SGLG.prodImg.Kill_PlayID(22);
		SGLG.prodImg.Kill_PlayID(23);
		SGLG.prod.Kill_PlayID(2498);
		SGLG.prod.Kill_PlayID(2497);
		SGLG.prod.Kill_PlayID(2499);
		SGLG.prod.Kill_PlayID(815);
		SGLG.prod.Kill_PlayID(927);
		SGLG.prod.Kill_PlayID(3886);
		SGLG.prod.Kill_PlayID(1425);
		SGLG.prod.Kill_PlayID(2790);
		SGLG.prod.Kill_PlayID(2791);
		SGLG.prod.Kill_PlayID(2514);
		SGLG.prod.Kill_PlayID(2515);
		SGLG.prod.Kill_PlayID(3560);
	}

	public void restartBGM()
	{
		switch (MainGameScene.slotGameMan.m_dirData[45])
		{
		case 0:
		case 1:
			SGLG.sound.Stop(Sound.CH.BGM);
			break;
		case 2:
			Direction5CST.restartBGM();
			break;
		case 3:
			Direction18JST.restartBGM();
			break;
		case 4:
		case 5:
		case 6:
		case 30:
			Direction23AST.restartBGM();
			break;
		case 9:
			Direction33DST.restartBGM();
			break;
		case 7:
		case 8:
		case 10:
		case 11:
		case 12:
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
		case 27:
		case 28:
		case 29:
			break;
		}
	}
}
