public class DirectionCommandMoviePause : DirectionCommandBase
{
	private Production prod;

	private int m_ProdID = -1;

	public DirectionCommandMoviePause(Production p, int pauseID, int exe)
		: base(exe)
	{
		prod = p;
		m_ProdID = pauseID;
		m_Class = CLASS.OTHER;
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse && checkExe(cnt))
		{
			int id = prod.find(m_ProdID);
			prod.Pause(id);
			m_Active = false;
		}
	}

	public override void terminate()
	{
	}
}
