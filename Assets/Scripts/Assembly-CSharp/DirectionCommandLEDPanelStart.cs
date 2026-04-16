public class DirectionCommandLEDPanelStart : DirectionCommandBase
{
	private LEDPanelManager m_Mng;

	private LEDPanelManager.LINE m_Line;

	private int m_ID;

	private bool m_Loop;

	public DirectionCommandLEDPanelStart(LEDPanelManager mng, LEDPanelManager.LINE _line, int _id, bool _loop, int exe)
		: base(exe)
	{
		m_Mng = mng;
		m_Line = _line;
		m_ID = _id;
		m_Loop = _loop;
		m_Class = CLASS.OTHER;
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse && checkExe(cnt))
		{
			m_Mng.start(m_Line, m_ID, m_Loop);
			m_Active = false;
		}
	}

	public override void terminate()
	{
	}
}
