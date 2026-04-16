public class DirectionCommandImageColorChange : DirectionCommandBase
{
	private ProductionImg prod;

	private int m_PlayID;

	private int m_StartA;

	private int m_StartR;

	private int m_StartG;

	private int m_StartB;

	private int m_DestA;

	private int m_DestR;

	private int m_DestG;

	private int m_DestB;

	private float m_Layer;

	private int m_Frame;

	public DirectionCommandImageColorChange(ProductionImg p, float layer, int sa, int sr, int sg, int sb, int da, int dr, int dg, int db, int frame, int exe)
		: base(exe)
	{
		prod = p;
		m_Layer = layer;
		m_StartA = sa;
		m_StartR = sr;
		m_StartG = sg;
		m_StartB = sb;
		m_DestA = da;
		m_DestR = dr;
		m_DestG = dg;
		m_DestB = db;
		m_Frame = frame;
		m_Class = CLASS.OTHER;
		if (m_Frame <= 0)
		{
			m_Frame = 1;
		}
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse && checkExe(cnt))
		{
			int num = prod.findLayer(m_Layer);
			if (num >= 0)
			{
				int num2 = cnt - execnt;
				int a = m_StartA + (m_DestA - m_StartA) * num2 / m_Frame;
				int r = m_StartR + (m_DestR - m_StartR) * num2 / m_Frame;
				int g = m_StartG + (m_DestG - m_StartG) * num2 / m_Frame;
				int b = m_StartB + (m_DestB - m_StartB) * num2 / m_Frame;
				prod.SetColor(num, a, r, g, b);
			}
			if (cnt >= execnt + m_Frame)
			{
				m_Active = false;
			}
		}
	}

	public override void terminate()
	{
	}
}
