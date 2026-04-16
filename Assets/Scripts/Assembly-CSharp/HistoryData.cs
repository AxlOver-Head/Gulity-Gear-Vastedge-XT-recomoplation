public class HistoryData
{
	public const int HISTROY_ITEM_MAX = 20;

	public const int HISTROY_ELECTION_PB = 0;

	public const int HISTROY_ELECTION_RB = 1;

	public const int HISTROY_ELECTION_GB = 2;

	public const int HISTROY_ELECTION_SGB = 3;

	public const int HISTROY_ELECTION_ART = 4;

	public int bnsPBCnt;

	public int bnsGBCnt;

	public int bnsSGBCnt;

	public int bnsRBCnt;

	public int artCnt;

	public int bnsBBCntYesterDay;

	public int bnsRBCntYesterDay;

	public int artCntYesterDay;

	public int[] LogTousenYaku = new int[20];

	public int[] LogGameCount = new int[20];

	public int[] LogDouziYaku = new int[20];

	public void setLog(int game, int tousen)
	{
		for (int num = 19; num > 0; num--)
		{
			LogTousenYaku[num] = LogTousenYaku[num - 1];
			LogGameCount[num] = LogGameCount[num - 1];
		}
		LogTousenYaku[0] = tousen;
		LogGameCount[0] = game;
	}

	public void setLog(int douzi)
	{
		for (int num = 19; num > 0; num--)
		{
			LogDouziYaku[num] = LogDouziYaku[num - 1];
		}
		LogDouziYaku[0] = douzi;
	}

	public void clear()
	{
		bnsPBCnt = 0;
		bnsGBCnt = 0;
		bnsSGBCnt = 0;
		bnsRBCnt = 0;
		artCnt = 0;
		for (int i = 0; i < 20; i++)
		{
			LogTousenYaku[i] = -1;
			LogGameCount[i] = 0;
			LogDouziYaku[i] = -1;
		}
	}
}
