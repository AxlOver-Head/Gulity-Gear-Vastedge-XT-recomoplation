public class DirectionCommandBase
{
	public enum CLASS
	{
		OTHER = 0,
		PLAYMOVIE = 1,
		ADDMOVIE = 2,
		ADDMOVIEWITHPOS = 3,
		ADDMOVIELAYER = 4,
		ADDMOVIEWITHLAYER = 5,
		ADDMOVIEWITHLAYERANDPOS = 6,
		PLAYIMAGE = 7,
		PLAYANIME = 8,
		ADDANIME = 9,
		ADDANIMEWITHPOS = 10,
		ADDANIMELAYER = 11,
		ADDANIMEWITHLAYER = 12,
		ADDANIMEWITHLAYERANDPOS = 13
	}

	public int execnt;

	public bool m_Active = true;

	public bool m_UnUse;

	public CLASS m_Class;

	public DirectionCommandBase(int exe)
	{
		execnt = exe;
	}

	public virtual void control(int cnt)
	{
	}

	public virtual void terminate()
	{
	}

	public bool checkExe(int cnt)
	{
		return cnt >= execnt;
	}

	protected void setPlayPush(int playID)
	{
		switch (playID)
		{
		case 661:
		case 662:
		case 2781:
		case 2948:
		case 2950:
		case 2952:
		case 2954:
		case 2956:
		case 2958:
		case 2960:
		case 3837:
		case 3843:
		case 3849:
		case 3855:
			MainGameScene.pushMan.setCanPush(true);
			break;
		case 3840:
		case 3842:
		case 3846:
		case 3848:
		case 3852:
		case 3854:
		case 3858:
		case 3860:
		case 3861:
			MainGameScene.pushMan.setCanPush(false);
			break;
		}
	}

	protected void setKillPush(int playID)
	{
		if (playID == 661 || playID == 662 || playID == 2781 || playID == 3837 || playID == 3843 || playID == 3849 || playID == 3855)
		{
			MainGameScene.pushMan.setCanPush(false);
		}
	}
}
