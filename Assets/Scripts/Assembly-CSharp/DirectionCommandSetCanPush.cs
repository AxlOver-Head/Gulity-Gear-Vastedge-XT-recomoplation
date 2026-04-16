public class DirectionCommandSetCanPush : DirectionCommandBase
{
	private bool m_Flag;

	public DirectionCommandSetCanPush(bool _flag, int exe)
		: base(exe)
	{
		m_Flag = _flag;
	}

	public override void control(int cnt)
	{
	}

	public override void terminate()
	{
	}
}
