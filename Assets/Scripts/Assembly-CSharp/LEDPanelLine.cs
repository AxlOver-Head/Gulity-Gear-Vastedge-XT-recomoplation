using System;

public class LEDPanelLine
{
	public LEDPanelPat[] m_Pattern;

	public bool m_Active;

	protected bool m_Loop;

	protected int m_ID = -1;

	protected int m_Cnt;

	protected int m_Current;

	protected int m_Length;

	protected short m_Max;

	public LEDPanelLine()
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
		m_Pattern = load(path + ".pld");
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

	protected virtual LEDPanelPat[] load(string path)
	{
		return null;
	}

	protected LEDPanelPat[] load(string path, int num)
	{
		byte[] array = SGLG.readBinary(path);
		int num2 = 0;
		m_Max = BitConverter.ToInt16(array, 0);
		num2 += 2;
		m_Pattern = new LEDPanelPat[m_Max];
		for (int i = 0; i < m_Max; i++)
		{
			m_Pattern[i] = new LEDPanelPat(num);
			m_Pattern[i].m_Frame = (short)(BitConverter.ToInt16(array, num2) / 30);
			num2 += 2;
			Array.Copy(array, num2, m_Pattern[i].m_ExecData, 0, num);
			num2 += num;
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

	public virtual void blendRewrite(byte[] dest)
	{
	}
}
