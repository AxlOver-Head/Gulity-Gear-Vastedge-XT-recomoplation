public class DirectionCommandAnimeLoop : DirectionCommandBase
{
	private ProductionAnime prodAnime;

	private int m_PlayID;

	private bool m_Loop;

	public DirectionCommandAnimeLoop(ProductionAnime p, int playID, bool loop, int exe)
		: base(exe)
	{
		prodAnime = p;
		m_PlayID = playID;
		m_Loop = loop;
		m_Class = CLASS.OTHER;
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse && checkExe(cnt))
		{
			int num = prodAnime.find(m_PlayID);
			if (num >= 0)
			{
				prodAnime.SetLoop(num, m_Loop);
				m_Active = false;
			}
		}
	}

	public override void terminate()
	{
	}
}
