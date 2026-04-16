public class DirectionCommandDirectionStopBefore : DirectionCommandBase
{
	private DirectionManager m_Mng;

	private DirectionManager.DIR m_Dir;

	public DirectionCommandDirectionStopBefore(DirectionManager mng, int exe)
		: base(exe)
	{
		m_Mng = mng;
		m_Dir = mng.nowDir;
		m_Class = CLASS.OTHER;
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse && checkExe(cnt))
		{
			for (int i = 0; i < (int)m_Dir; i++)
			{
				m_Mng.DisActive((DirectionManager.DIR)i);
			}
			m_Active = false;
		}
	}

	public override void terminate()
	{
	}
}
