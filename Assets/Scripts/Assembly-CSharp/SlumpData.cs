public class SlumpData
{
	public static readonly int GAME_MAX = 10000;

	public static readonly int SAVE_GAME = 10;

	public static readonly int DATA_NUM = GAME_MAX / SAVE_GAME;

	public SlumpDataCore[] m_Slump;

	public int m_Current;

	public SlumpDataCore data(int _id)
	{
		if (_id < 0 || _id >= DATA_NUM)
		{
			return null;
		}
		return m_Slump[_id];
	}

	public void init()
	{
		m_Slump = new SlumpDataCore[DATA_NUM];
		m_Current = 0;
		for (int i = 0; i < DATA_NUM; i++)
		{
			m_Slump[i] = new SlumpDataCore();
		}
	}

	public void addData(int _game, int _medal)
	{
		if (m_Current < DATA_NUM)
		{
			m_Slump[m_Current].setData(_game, _medal);
			m_Current++;
		}
	}

	public int getDataNum()
	{
		int num = 0;
		for (int i = 0; i < DATA_NUM && m_Slump[i].active; i++)
		{
			num++;
		}
		return num;
	}

	public int getTateMax()
	{
		int i = 1000;
		for (int j = 0; j < getDataNum(); j++)
		{
			for (; m_Slump[j].medal > i; i += 1000)
			{
			}
			for (; m_Slump[j].medal < -i; i += 1000)
			{
			}
		}
		return i;
	}

	public int getYokoMax()
	{
		int i = 1000;
		if (getDataNum() >= 1)
		{
			for (; m_Slump[getDataNum() - 1].game > i; i += 1000)
			{
			}
		}
		return i;
	}
}
