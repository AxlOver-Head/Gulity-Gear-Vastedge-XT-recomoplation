public class DirectionCommandAnimePause : DirectionCommandBase
{
	private ProductionAnime prodAnime;

	private int m_ProdID = -1;

	public DirectionCommandAnimePause(ProductionAnime p, int pauseID, int exe)
		: base(exe)
	{
		prodAnime = p;
		m_ProdID = pauseID;
		m_Class = CLASS.OTHER;
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse && checkExe(cnt))
		{
			int id = prodAnime.find(m_ProdID);
			prodAnime.Pause(id);
			m_Active = false;
		}
	}

	public override void terminate()
	{
	}
}
