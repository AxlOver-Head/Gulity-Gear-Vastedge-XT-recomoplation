public class HallData
{
	public const int SELECT_MAX = 10;

	public const int MEDALS_SEND_NONE = 0;

	public const int MEDALS_SEND_FIST = 1;

	public const int MEDALS_SEND_ATHER_TRANS = 2;

	public int gameDayCnt;

	public int gameCntPre;

	public int dayEvent;

	public int[] persons = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

	public int[] settei = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

	public int[] bill = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

	public int[] npcMoney = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

	public int[] npcCoin = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

	public int[] npcGameCnt = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

	public bool gameStart;

	public bool reviewTap;

	public int sendMedalsFist;

	public void clear()
	{
		for (int i = 0; i < 10; i++)
		{
			persons[i] = -1;
			settei[i] = -1;
			bill[i] = -1;
			npcCoin[i] = -1;
			npcMoney[i] = -1;
			npcGameCnt[i] = 0;
		}
		gameDayCnt = 0;
		dayEvent = 0;
		gameStart = false;
		gameCntPre = 0;
	}
}
