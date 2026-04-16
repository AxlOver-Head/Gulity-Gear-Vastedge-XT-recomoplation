public class DirectionCommandMovieKillLayer : DirectionCommandBase
{
	private Production prod;

	private float m_Layer = -99999f;

	public DirectionCommandMovieKillLayer(Production p, float layer, int exe)
		: base(exe)
	{
		prod = p;
		m_Layer = layer;
		m_Class = CLASS.OTHER;
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse && checkExe(cnt))
		{
			int num = prod.findLayer(m_Layer);
			if (num >= 0)
			{
				prod.Kill(num);
				m_Active = false;
			}
		}
	}

	public override void terminate()
	{
	}
}
