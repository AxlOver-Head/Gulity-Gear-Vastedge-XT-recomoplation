public class DirectionCommandAnimeKillAll : DirectionCommandBase
{
	private ProductionAnime prodAnime;

	public DirectionCommandAnimeKillAll(ProductionAnime p, int exe)
		: base(exe)
	{
		prodAnime = p;
		m_Class = CLASS.OTHER;
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse && checkExe(cnt))
		{
			prodAnime.Kill();
			m_Active = false;
		}
	}

	public override void terminate()
	{
	}
}
