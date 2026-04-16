public class KoyakuFlag
{
	public enum KOYAKU
	{
		OFF = 0,
		REP = 1,
		TOKU_REP = 2,
		MB = 3,
		BEL = 4,
		KYO_BEL = 5,
		SUIKA = 6,
		JYAKU_CHE = 7,
		KYO_CHE = 8,
		TYU_CHE = 9,
		JYAKU_CHAN = 10,
		KYO_CHAN = 11,
		DESTROY = 12,
		RB = 13,
		R7 = 14,
		W7 = 15,
		MAX = 16
	}

	public static int m_koyakuNum;

	public void init()
	{
		m_koyakuNum = 0;
	}

	public static bool isKoyakuActive(int _num)
	{
		bool result = true;
		int num = MainGameScene.slotGameMan.get_pdt_data(45);
		int num2 = MainGameScene.slotGameMan.get_pkd_data(86);
		int num3 = MainGameScene.slotGameMan.get_koyaku_prm(0);
		long ulDedamaLotState = MainGameScene.slotGameMan.ulDedamaLotState;
		if (_num < 0 || 16 <= _num)
		{
			return false;
		}
		switch (_num)
		{
		case 12:
		{
			int num4 = MainGameScene.slotGameMan.get_pkd_data(439) - MainGameScene.slotGameMan.get_pkd_data(438);
			if ((num < 13 || 16 < num) && num != 25 && num != 27 && num != 28 && (num2 != 4 || (ulDedamaLotState & 0x100000) != 0L))
			{
				result = false;
			}
			break;
		}
		case 13:
			if (num2 == 5 || (num >= 11 && 19 >= num) || (num >= 24 && 29 >= num) || num == 9 || num == 10 || (ulDedamaLotState & 0x100000) != 0L || (ulDedamaLotState & 0x1000) != 0L || (ulDedamaLotState & 0x40) != 0L)
			{
				result = false;
			}
			break;
		case 14:
			if (num2 == 5 || (num >= 11 && 19 >= num) || (num >= 24 && 29 >= num) || num == 9 || num == 10 || (ulDedamaLotState & 0x100000) != 0L || (ulDedamaLotState & 0x1000) != 0L || (ulDedamaLotState & 0x40) != 0L)
			{
				result = false;
			}
			break;
		case 15:
			if (num2 == 5)
			{
				result = false;
			}
			break;
		}
		if ((num2 == 6 || num3 == 1 || num == 22 || num == 23) && _num != 0)
		{
			result = false;
		}
		return result;
	}

	public static void setKoyaku(int _num)
	{
		if (_num >= 0 && 16 > _num)
		{
			m_koyakuNum = _num;
		}
	}

	public static int getKoyaku()
	{
		int num = 0;
		num = m_koyakuNum;
		if (num < 0 || 16 <= num)
		{
			return 0;
		}
		return num;
	}
}
