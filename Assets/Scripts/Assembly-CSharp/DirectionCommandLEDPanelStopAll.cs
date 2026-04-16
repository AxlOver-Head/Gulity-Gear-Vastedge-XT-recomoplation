public class DirectionCommandLEDPanelStopAll : DirectionCommandBase
{
	private LEDPanelManager m_Mng;

	public DirectionCommandLEDPanelStopAll(LEDPanelManager mng, int exe)
		: base(exe)
	{
		m_Mng = mng;
		m_Class = CLASS.OTHER;
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse && checkExe(cnt))
		{
			m_Mng.stop();
			m_Active = false;
		}
	}

	public override void terminate()
	{
	}
}
