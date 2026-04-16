public class MachineData
{
	public int gameCount;

	public int modeMain;

	public int modeSub;

	public int totalGameCount;

	public int artCount;

	public int bnsCount;

	public short mode;

	public short modeArt;

	public int cycleGame;

	public short cycleMode;

	public int yaku;

	public int FLTousen1;

	public int reelStep;

	public int bonusGame;

	public int artGame;

	public int artCntContBtl;

	public int artStockCnt;

	public bool artBtlWin;

	public int jgGame;

	public int hohGame;

	public int artCntVarGame;

	public short hohChar;

	public short hohTension;

	public short hohRivalCharDamage;

	public short hohSolCharDamage;

	public short gbChargeCnt;

	public short rbMap;

	public HistoryData hisData = new HistoryData();

	public void clear()
	{
		modeMain = 0;
		modeSub = 0;
		gameCount = 0;
		artCount = 0;
		totalGameCount = 0;
		bnsCount = 0;
		mode = 0;
		cycleGame = 0;
		cycleMode = 0;
		yaku = 0;
		FLTousen1 = 0;
		reelStep = 0;
		bonusGame = 0;
		artGame = 0;
		artCntContBtl = 0;
		artStockCnt = 0;
		artBtlWin = false;
		jgGame = 0;
		hohGame = 0;
		artCntVarGame = 0;
		modeArt = 0;
		hohChar = 0;
		hohTension = 0;
		hohRivalCharDamage = 0;
		hohSolCharDamage = 0;
		gbChargeCnt = 0;
		rbMap = 0;
		hisData.clear();
	}
}
