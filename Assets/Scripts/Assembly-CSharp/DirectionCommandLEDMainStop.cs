public class DirectionCommandLEDMainStop : DirectionCommandBase
{
	private LEDMainManager m_Mng;

	private LEDMainManager.LINE m_Line;

	public DirectionCommandLEDMainStop(LEDMainManager mng, LEDMainManager.LINE _line, int exe)
		: base(exe)
	{
		m_Mng = mng;
		m_Line = _line;
		m_Class = CLASS.OTHER;
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse && checkExe(cnt))
		{
			m_Mng.stop(m_Line);
			m_Active = false;
		}
	}

	public override void terminate()
	{
	}
}
