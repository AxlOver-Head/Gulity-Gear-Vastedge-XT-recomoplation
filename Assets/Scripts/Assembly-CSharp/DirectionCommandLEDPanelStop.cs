public class DirectionCommandLEDPanelStop : DirectionCommandBase
{
	private LEDPanelManager m_Mng;

	private LEDPanelManager.LINE m_Line;

	public DirectionCommandLEDPanelStop(LEDPanelManager mng, LEDPanelManager.LINE _line, int exe)
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
