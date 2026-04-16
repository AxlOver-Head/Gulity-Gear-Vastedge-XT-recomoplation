public class DirectionCommandYakumonoMove : DirectionCommandBase
{
	private YakuManager m_Mng;

	private YakuManager.KIND m_Line;

	private int m_ID;

	public DirectionCommandYakumonoMove(YakuManager mng, YakuManager.KIND _line, int _id, int exe)
		: base(exe)
	{
		m_Mng = mng;
		m_Line = _line;
		m_ID = _id;
		m_Class = CLASS.OTHER;
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse && checkExe(cnt))
		{
			m_Mng.start(m_Line, m_ID);
			m_Active = false;
		}
	}

	public override void terminate()
	{
	}
}
