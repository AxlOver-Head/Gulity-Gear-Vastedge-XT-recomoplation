public class DirectionCommandAnimeStopAll : DirectionCommandBase
{
	private ProductionAnime prodAnime;

	public DirectionCommandAnimeStopAll(ProductionAnime p, int exe)
		: base(exe)
	{
		prodAnime = p;
		m_Class = CLASS.OTHER;
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse && checkExe(cnt))
		{
			prodAnime.SetKillSelf(true);
			prodAnime.Hold();
			m_Active = false;
		}
	}

	public override void terminate()
	{
	}
}
