public class DirectionCommandAnimeStop : DirectionCommandBase
{
	private ProductionAnime prodAnime;

	private int m_ProdID = -1;

	public DirectionCommandAnimeStop(ProductionAnime p, int stopID, int exe)
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
			int id = prodAnime.find(m_ProdID);
			prodAnime.SetKillSelf(id, true);
			prodAnime.Hold(id);
			m_Active = false;
		}
	}

	public override void terminate()
	{
	}
}
