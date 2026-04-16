public class DirectionCommandAnimeKillLayer : DirectionCommandBase
{
	private ProductionAnime prodAnime;

	private float m_Layer = -99999f;

	public DirectionCommandAnimeKillLayer(ProductionAnime p, float layer, int exe)
		: base(exe)
	{
		prodAnime = p;
		m_Layer = layer;
		m_Class = CLASS.OTHER;
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse && checkExe(cnt))
		{
			int num = prodAnime.findLayer(m_Layer);
			if (num >= 0)
			{
				prodAnime.Kill(num);
				m_Active = false;
			}
		}
	}

	public override void terminate()
	{
	}
}
