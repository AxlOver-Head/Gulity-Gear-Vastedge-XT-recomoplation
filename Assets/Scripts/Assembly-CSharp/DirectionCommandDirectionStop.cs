public class DirectionCommandDirectionStop : DirectionCommandBase
{
	private DirectionManager m_Mng;

	private DirectionManager.DIR m_Dir;

	public DirectionCommandDirectionStop(DirectionManager mng, DirectionManager.DIR dir, int exe)
		: base(exe)
	{
		m_Mng = mng;
		m_Dir = dir;
		m_Class = CLASS.OTHER;
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse && checkExe(cnt))
		{
			m_Mng.DisActive(m_Dir);
			m_Active = false;
		}
	}

	public override void terminate()
	{
	}
}
