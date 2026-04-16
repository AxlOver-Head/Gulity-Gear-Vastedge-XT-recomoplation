public class DirectionCommandImagePlay : DirectionCommandBase
{
	private ProductionImg prod;

	private int m_PlayID;

	private bool m_Add;

	private bool m_Trim;

	private int m_X;

	private int m_Y;

	private int m_Layer;

	public int m_ProdID = -1;

	public DirectionCommandImagePlay(ProductionImg p, int playID, bool add, bool trim, int x, int y, int layer, int exe)
		: base(exe)
	{
		prod = p;
		m_PlayID = playID;
		m_Add = add;
		m_Trim = trim;
		m_X = x;
		m_Y = y;
		m_Layer = layer;
		m_Class = CLASS.PLAYIMAGE;
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse && checkExe(cnt))
		{
			m_ProdID = prod.MakeImage(m_PlayID, m_Layer);
			prod.SetXY(m_ProdID, m_X, m_Y);
			prod.SetTrim(m_ProdID, m_Trim);
			prod.SetAdditive(m_ProdID, m_Add);
			prod.PlayImage(m_ProdID);
			m_Active = false;
		}
	}

	public override void terminate()
	{
		if (prod.find(m_PlayID) == m_ProdID)
		{
			prod.Kill(m_ProdID);
		}
	}
}
