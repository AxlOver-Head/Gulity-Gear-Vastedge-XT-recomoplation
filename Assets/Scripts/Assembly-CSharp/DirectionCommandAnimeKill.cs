public class DirectionCommandAnimeKill : DirectionCommandBase
{
	private ProductionAnime prodAnime;

	private int m_ProdID = -1;

	public DirectionCommandAnimeKill(ProductionAnime p, int stopID, int exe)
		: base(exe)
	{
		prodAnime = p;
		m_ProdID = stopID;
		m_Class = CLASS.OTHER;
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse && checkExe(cnt))
		{
			prodAnime.Kill_PlayID(m_ProdID);
			m_Active = false;
		}
	}

	public override void terminate()
	{
	}
}
