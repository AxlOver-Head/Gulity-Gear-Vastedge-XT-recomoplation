public class DirectionCommandMovieKill : DirectionCommandBase
{
	private Production prod;

	private int m_ProdID = -1;

	public DirectionCommandMovieKill(Production p, int stopID, int exe)
		: base(exe)
	{
		prod = p;
		m_ProdID = stopID;
		m_Class = CLASS.OTHER;
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse && checkExe(cnt))
		{
			prod.Kill_PlayID(m_ProdID);
			m_Active = false;
		}
	}

	public override void terminate()
	{
	}
}
