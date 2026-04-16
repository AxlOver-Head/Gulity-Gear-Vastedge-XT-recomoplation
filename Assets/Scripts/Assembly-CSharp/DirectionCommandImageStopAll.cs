public class DirectionCommandImageStopAll : DirectionCommandBase
{
	private ProductionImg prod;

	public DirectionCommandImageStopAll(ProductionImg p, int exe)
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
