public class DirectionBase
{
	protected DirectionManager mng;

	protected byte high;

	protected byte low;

	protected byte mode;

	protected DirectionManager.DIR m_Dir;

	protected DirectionEvent evt;

	public static readonly int PRIORITY_NORMAL = -1;

	public static readonly int PRIORITY_NAVI = 10000000;

	public DirectionBase(DirectionManager _mng, byte _high, byte _low, byte _mode, DirectionManager.DIR _dir, int priority)
	{
		mng = _mng;
		high = _high;
		low = _low;
		mode = _mode;
		m_Dir = _dir;
		int num = 0;
		evt = new DirectionEvent((priority >= 0) ? (priority + (int)_dir * 10000) : PRIORITY_NORMAL);
	}

	public byte getHigh()
	{
		return high;
	}

	public byte getLow()
	{
		return low;
	}

	public byte getMode()
	{
		return mode;
	}

	public virtual void start()
	{
		evt.start();
	}

	public virtual void end()
	{
		evt.end();
		disActive();
	}

	public virtual void control()
	{
		evt.control();
	}

	public void disActive()
	{
		evt.m_Active = false;
	}
}
