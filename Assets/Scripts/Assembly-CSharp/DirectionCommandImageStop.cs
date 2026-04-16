public class DirectionCommandImageStop : DirectionCommandBase
{
	private ProductionImg prod;

	private int m_ProdID = -1;

	public DirectionCommandImageStop(ProductionImg p, int stopID, int exe)
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
			int id = prod.find(m_ProdID);
			prod.Kill(id);
			m_Active = false;
		}
	}

	public override void terminate()
	{
	}
}
