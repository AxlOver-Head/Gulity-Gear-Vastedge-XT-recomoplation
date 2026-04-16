public class DirectionCommandMovieLoop : DirectionCommandBase
{
	private Production prod;

	private int m_PlayID;

	private bool m_Loop;

	public DirectionCommandMovieLoop(Production p, int playID, bool loop, int exe)
		: base(exe)
	{
		prod = p;
		m_PlayID = playID;
		m_Loop = loop;
		m_Class = CLASS.OTHER;
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse && checkExe(cnt))
		{
			int num = prod.find(m_PlayID);
			if (num >= 0)
			{
				prod.SetLoop(num, m_Loop);
				m_Active = false;
			}
		}
	}

	public override void terminate()
	{
	}
}
