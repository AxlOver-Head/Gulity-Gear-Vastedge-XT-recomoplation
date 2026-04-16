public class ZugaraManager
{
	private enum ZUGARA
	{
		RED7A = 0,
		WHITE7 = 1,
		BAR = 2,
		REPLAY = 3,
		BEL = 4,
		SUIKA = 5,
		BLANK = 6,
		RED7B = 7,
		CHERRY = 8,
		ICHIGEKI = 9
	}

	public enum Deme
	{
		NON = 0,
		KYO_CHE = 1,
		JYAKU_CHE = 2,
		BEL1 = 3,
		SUIKA = 4,
		BEL9 = 5,
		TYU_CHE = 6,
		BEL13 = 7,
		BEL14 = 8,
		REACH_REP = 9,
		NORMAL_REP = 10,
		JACIN = 11
	}

	public const int WINZU_CHHI2 = 1;

	public const int WINZU_CHHI1 = 2;

	public const int WINZU_CH_LO = 4;

	public const int WINZU_BLA_D = 8;

	public const int WINZU_BLAC4 = 16;

	public const int WINZU_BLAC3 = 32;

	public const int WINZU_BLAC2 = 64;

	public const int WINZU_BLAC1 = 128;

	public const int WINZU_BLAB3 = 1;

	public const int WINZU_BLAB2 = 2;

	public const int WINZU_BLAB1 = 4;

	public const int WINZU_BL_TC = 8;

	public const int WINZU_BL_TB = 16;

	public const int WINZU_BL_TA = 32;

	public const int WINZU_SU_CD = 64;

	public const int WINZU_SU_CN = 128;

	public const int WINZU_BL_CN = 1;

	public const int WINZU_CH_CN = 2;

	public const int WINZU_BL_SY = 4;

	public const int WINZU_BLA_A = 8;

	public const int WINZU_BL_CU = 16;

	public const int WINZU_BL_SV = 32;

	public const int WINZU_BL_CD = 64;

	public const int WINZU_RP_R2 = 1;

	public const int WINZU_RPR1C = 2;

	public const int WINZU_RPR1B = 4;

	public const int WINZU_RPR1A = 8;

	public const int WINZU_RPGF2 = 16;

	public const int WINZU_RPGF1 = 32;

	public const int WINZU_RP1GK = 64;

	public const int WINZU_RP_TP = 128;

	public const int WINZU_RP_SP = 1;

	public const int WINZU_RP_NM = 2;

	public const int WINZU_RPRT4 = 4;

	public const int WINZU_RPRB3 = 8;

	public const int WINZU_RPRB2 = 16;

	public const int WINZU_RPRB1 = 32;

	public const int WINZU_RPGB5 = 64;

	public const int WINZU_RPGB4 = 128;

	public const int WINZU_RPGB3 = 1;

	public const int WINZU_RPGB2 = 2;

	public const int WINZU_RPGB1B = 4;

	public const int WINZU_RPGB1A = 8;

	public const int WINZU_RPRT3 = 16;

	public const int WINZU_RPRT2 = 32;

	public const int WINZU_RPDN2 = 64;

	public const int WINZU_RPDN1 = 128;

	public const int WINZU_KOBOS = 1;

	public const int WINZU_NG_NG = 32;

	public const int WINZU_BNSMB = 64;

	public const int WINZU_BB_PB = 128;

	private static int[][] reelList = new int[21][]
	{
		new int[3] { 3, 4, 4 },
		new int[3] { 4, 3, 3 },
		new int[3] { 8, 8, 5 },
		new int[3] { 9, 4, 2 },
		new int[3] { 5, 3, 4 },
		new int[3] { 3, 5, 3 },
		new int[3] { 4, 1, 9 },
		new int[3] { 1, 6, 6 },
		new int[3] { 3, 4, 4 },
		new int[3] { 4, 3, 3 },
		new int[3] { 5, 5, 5 },
		new int[3] { 8, 4, 1 },
		new int[3] { 2, 2, 4 },
		new int[3] { 3, 4, 3 },
		new int[3] { 4, 3, 5 },
		new int[3] { 5, 9, 8 },
		new int[3] { 3, 4, 4 },
		new int[3] { 4, 3, 3 },
		new int[3] { 7, 5, 4 },
		new int[3],
		new int[3] { 5, 8, 7 }
	};

	public static int getWinZu0(int _left, int _center, int _right)
	{
		int num = reelList[_left][0];
		int num2 = reelList[_center][1];
		int num3 = reelList[_right][2];
		int result = 0;
		if (num == 2 && num2 == 4 && num3 != 3 && num3 != 4 && num3 != 5)
		{
			result = 1;
		}
		if (num == 9 && num2 == 4 && num3 != 3 && num3 != 4 && num3 != 5)
		{
			result = 2;
		}
		if ((num == 2 || num == 9) && num2 == 4 && num3 == 3)
		{
			result = 4;
		}
		if (num == 7 && num3 == 6 && (num2 == 2 || num2 == 9))
		{
			result = 8;
		}
		if (num == 7 && num2 == 6 && (num3 == 1 || num3 == 2 || num3 == 6 || num3 == 7 || num3 == 8))
		{
			result = 16;
		}
		if (num == 7 && num2 == 8 && (num3 == 1 || num3 == 2 || num3 == 6 || num3 == 7 || num3 == 8))
		{
			result = 32;
		}
		return result;
	}

	public static int getWinZu1(int _left, int _center, int _right)
	{
		int num = reelList[_left][0];
		int num2 = reelList[_center][1];
		int num3 = reelList[_right][2];
		int result = 0;
		if (num == 1 && num3 == 6)
		{
			if (num2 == 2)
			{
				result = 4;
			}
			if (num2 == 6)
			{
				result = 2;
			}
			if (num2 == 8)
			{
				result = 1;
			}
			if (num2 == 9)
			{
				result = 4;
			}
		}
		if (num == 3 && (num2 == 2 || num2 == 9) && (num3 == 1 || num3 == 2 || num3 == 6 || num3 == 7 || num3 == 8))
		{
			result = 8;
		}
		if (num == 3 && num2 == 8 && (num3 == 1 || num3 == 2 || num3 == 6 || num3 == 7 || num3 == 8))
		{
			result = 16;
		}
		if (num == 3 && num2 == 6 && (num3 == 1 || num3 == 2 || num3 == 6 || num3 == 7 || num3 == 8))
		{
			result = 32;
		}
		if ((num == 0 || num == 4 || num == 9) && num2 == 5 && (num3 == 1 || num3 == 2 || num3 == 8))
		{
			result = 64;
		}
		if (num == 5 && num2 == 5 && num3 == 5)
		{
			result = 128;
		}
		return result;
	}

	public static int getWinZu2(int _left, int _center, int _right)
	{
		int num = reelList[_left][0];
		int num2 = reelList[_center][1];
		int num3 = reelList[_right][2];
		int result = 0;
		if (num == 4 && num2 == 4 && num3 == 4)
		{
			result = 1;
		}
		if (num == 8 && num2 == 3 && num3 == 4)
		{
			result = 2;
		}
		if ((num == 1 || num == 5 || num == 7 || num == 8) && num2 == 4 && (num3 == 0 || num3 == 3))
		{
			result = 4;
		}
		if ((num == 1 || num == 5 || num == 7 || num == 8) && num2 == 4 && (num3 == 5 || num3 == 9))
		{
			result = 8;
		}
		if ((num == 1 || num == 5 || num == 7 || num == 8) && num2 == 4 && (num3 == 1 || num3 == 2 || num3 == 6 || num3 == 7 || num3 == 8))
		{
			result = 16;
		}
		if (num == 3 && num2 == 4 && (num3 == 1 || num3 == 2 || num3 == 6 || num3 == 7 || num3 == 8))
		{
			result = 32;
		}
		if (num == 3 && num2 == 4 && (num3 == 0 || num3 == 3))
		{
			result = 64;
		}
		return result;
	}

	public static int getWinZu3(int _left, int _center, int _right)
	{
		int num = reelList[_left][0];
		int num2 = reelList[_center][1];
		int num3 = reelList[_right][2];
		int result = 0;
		if (num == 4 && num2 == 3 && num3 == 2)
		{
			result = 1;
		}
		if (num == 4 && num2 == 9 && num3 == 3)
		{
			result = 2;
		}
		if (num == 4 && num2 == 8 && num3 == 3)
		{
			result = 4;
		}
		if (num == 4 && num2 == 5 && num3 == 3)
		{
			result = 8;
		}
		if (num == 4 && num2 == 9 && num3 == 9)
		{
			result = 16;
		}
		if (num == 4 && num2 == 8 && num3 == 9)
		{
			result = 32;
		}
		if (num == 4 && num2 == 5 && num3 == 9)
		{
			result = 32;
		}
		if (num == 9 && num2 == 9 && num3 == 9)
		{
			result = 32;
		}
		if ((num == 1 || num == 2 || num == 5) && num2 == 4 && num3 == 4)
		{
			result = 128;
		}
		return result;
	}

	public static int getWinZu4(int _left, int _center, int _right)
	{
		int num = reelList[_left][0];
		int num2 = reelList[_center][1];
		int num3 = reelList[_right][2];
		int result = 0;
		if (num == 3 && num2 == 3 && num3 == 4)
		{
			result = 1;
		}
		if (num == 3 && num2 == 3 && num3 == 3)
		{
			result = 2;
		}
		if (num == 4 && num2 == 4 && (num3 == 0 || num3 == 5 || num3 == 9))
		{
			result = 4;
		}
		if ((num == 1 || num == 2 || num == 5) && num2 == 3 && num3 == 2)
		{
			result = 8;
		}
		if ((num == 1 || num == 5) && num2 == 2 && num3 == 2)
		{
			result = 16;
		}
		if (num == 2 && num2 == 2 && (num3 == 2 || num3 == 3))
		{
			result = 32;
		}
		if (num == 4 && num2 == 3 && num3 == 7)
		{
			result = 64;
		}
		if ((num == 0 || num == 7) && num2 == 3 && (num3 == 0 || num3 == 7))
		{
			result = 128;
		}
		return result;
	}

	public static int getWinZu5(int _left, int _center, int _right)
	{
		int num = reelList[_left][0];
		int num2 = reelList[_center][1];
		int num3 = reelList[_right][2];
		int result = 0;
		if ((num == 1 || num == 5) && (num2 == 0 || num2 == 5 || num2 == 8 || num2 == 9) && (num3 == 0 || num3 == 7))
		{
			result = 1;
		}
		if ((num == 0 || num == 7) && num2 == 3 && num3 == 4)
		{
			result = 2;
		}
		if (num == 7 && num2 == 0 && (num3 == 0 || num3 == 4 || num3 == 7))
		{
			result = 4;
		}
		if (num == 0 && num2 == 0 && (num3 == 0 || num3 == 4 || num3 == 7))
		{
			result = 8;
		}
		if ((num == 1 || num == 2 || num == 5) && num2 == 3 && (num3 == 0 || num3 == 5 || num3 == 9))
		{
			result = 16;
		}
		if ((num == 1 || num == 5) && num2 == 3 && num3 == 4)
		{
			result = 32;
		}
		if (num == 5 && num2 == 3 && num3 == 3)
		{
			result = 64;
		}
		if (num == 4 && num2 == 3 && num3 == 4)
		{
			result = 128;
		}
		return result;
	}

	public static int getWinZu6(int _left, int _center, int _right)
	{
		int num = reelList[_left][0];
		int num2 = reelList[_center][1];
		int num3 = reelList[_right][2];
		int result = 0;
		if (num == 3 && num2 == 3 && (num3 == 1 || num3 == 2 || num3 == 6 || num3 == 7 || num3 == 8))
		{
			result = 1;
		}
		if (num == 3 && (num2 == 3 || num2 == 5) && (num3 == 0 || num3 == 5 || num3 == 9))
		{
			result = 64;
		}
		if (num == 1 && num2 == 1 && num3 == 1)
		{
			result = 128;
		}
		return result;
	}
}
