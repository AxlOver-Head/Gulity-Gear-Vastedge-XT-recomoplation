public class DirectionCommandImageChangeScale : DirectionCommandBase
{
	private ProductionImg prod;

	private int m_PlayID;

	private float m_StartX;

	private float m_StartY;

	private float m_DestX;

	private float m_DestY;

	private float m_Layer;

	private int m_Frame;

	public DirectionCommandImageChangeScale(ProductionImg p, float layer, float sx, float sy, float dx, float dy, int frame, int exe)
		: base(exe)
	{
		prod = p;
		m_Layer = layer;
		m_StartX = sx;
		m_StartY = sy;
		m_DestX = dx;
		m_DestY = dy;
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
				float x = m_StartX + (m_DestX - m_StartX) * (float)num2 / (float)m_Frame;
				float y = m_StartY + (m_DestY - m_StartY) * (float)num2 / (float)m_Frame;
				prod.SetScale(num, x, y);
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
