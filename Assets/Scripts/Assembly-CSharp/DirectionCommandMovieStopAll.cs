public class DirectionCommandMovieStopAll : DirectionCommandBase
{
	private Production prod;

	public DirectionCommandMovieStopAll(Production p, int exe)
		: base(exe)
	{
		prod = p;
		m_Class = CLASS.OTHER;
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse && checkExe(cnt))
		{
			prod.SetKillSelf(true);
			prod.Hold();
			m_Active = false;
		}
	}

	public override void terminate()
	{
	}
}
