public class DirectionCommandMakeDirection : DirectionCommandBase
{
	private DirectionManager.DIR m_Kind;

	private byte m_High;

	private byte m_Low;

	private byte m_Mode;

	public DirectionCommandMakeDirection(DirectionManager.DIR kind, byte high, byte low, byte mode, int exe)
		: base(exe)
	{
		m_Kind = kind;
		m_High = high;
		m_Low = low;
		m_Mode = mode;
		m_Class = CLASS.OTHER;
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse && checkExe(cnt))
		{
			if (MainGameScene.dirMan.dir[(int)m_Kind] != null)
			{
				MainGameScene.dirMan.StopDirection(m_Kind);
			}
			MainGameScene.dirMan.makeDirection(m_Kind, m_High, m_Low, m_Mode);
			if (MainGameScene.dirMan.dir[(int)m_Kind] != null)
			{
				MainGameScene.dirMan.dir[(int)m_Kind].start();
			}
			m_Active = false;
		}
	}

	public override void terminate()
	{
	}
}
