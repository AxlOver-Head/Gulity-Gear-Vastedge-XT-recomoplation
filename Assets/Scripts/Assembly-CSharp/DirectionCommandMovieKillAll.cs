public class DirectionCommandMovieKillAll : DirectionCommandBase
{
	private Production prod;

	public DirectionCommandMovieKillAll(Production p, int exe)
		: base(exe)
	{
		prod = p;
		m_Class = CLASS.OTHER;
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse && checkExe(cnt))
		{
			prod.Kill();
			m_Active = false;
		}
	}

	public override void terminate()
	{
	}
}
