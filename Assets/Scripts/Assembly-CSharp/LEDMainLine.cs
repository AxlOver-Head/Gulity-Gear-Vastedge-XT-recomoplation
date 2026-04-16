using System;

public class LEDMainLine
{
	public static readonly int DATA_NUM = 203;

	public LEDMainPat[] m_Pattern;

	public bool m_Active;

	private bool m_Loop;

	private int m_ID = -1;

	private int m_Cnt;

	private int m_Current;

	private short m_Max;

	public LEDMainLine()
	{
		init();
	}

	public void init()
	{
		m_Active = false;
		m_Loop = false;
		m_ID = -1;
		m_Cnt = 0;
		m_Current = 0;
		m_Max = 0;
		m_Pattern = null;
	}

	public void start(int _id, string path, bool loop)
	{
		stop();
		m_Pattern = load(path);
		m_Active = true;
		m_Loop = loop;
		m_ID = _id;
	}

	public void kstart(int _id, string path, bool loop)
	{
		if (!m_Active || m_ID != _id)
		{
			start(_id, path, loop);
		}
	}

	private LEDMainPat[] load(string path)
	{
		byte[] array = SGLG.readBinary(path + ".led");
		int num = 0;
		m_Max = BitConverter.ToInt16(array, 0);
		num += 2;
		m_Pattern = new LEDMainPat[m_Max];
		for (int i = 0; i < m_Max; i++)
		{
			m_Pattern[i] = new LEDMainPat();
			m_Pattern[i].m_Frame = BitConverter.ToInt16(array, num);
			num += 2;
			Array.Copy(array, num, m_Pattern[i].m_ExecData, 0, DATA_NUM);
			num += DATA_NUM;
		}
		return m_Pattern;
	}

	public void stop()
	{
		init();
	}

	public void control()
	{
		if (!m_Active)
		{
			return;
		}
		m_Cnt++;
		if (m_Cnt < m_Pattern[m_Current].m_Frame)
		{
			return;
		}
		m_Cnt = 0;
		m_Current++;
		if (m_Current >= m_Max)
		{
			if (m_Loop)
			{
				m_Current = 0;
			}
			else
			{
				stop();
			}
		}
	}

	public void blendRewriteAll(byte[] dest)
	{
		Array.Copy(m_Pattern[m_Current].m_ExecData, dest, DATA_NUM);
	}

	public void blendRewrite(byte[] dest, byte[,] flag, int layer)
	{
		short num = 0;
		short num2 = 0;
		for (short num3 = 0; num3 < DATA_NUM; num3++)
		{
			num = (short)((num3 >> 3) & 0xFFFF);
			num2 = (short)(num3 & 7);
			if (((flag[layer, num] >> 7 - num2) & 1) == 1)
			{
				dest[num3] = m_Pattern[m_Current].m_ExecData[num3];
			}
		}
	}
}
