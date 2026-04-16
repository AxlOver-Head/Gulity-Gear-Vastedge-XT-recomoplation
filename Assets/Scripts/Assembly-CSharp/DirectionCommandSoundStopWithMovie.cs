public class DirectionCommandSoundStopWithMovie : DirectionCommandBase
{
	private Production prod;

	private Sound sound;

	private Sound.CH m_Ch;

	private int m_MovieID;

	public DirectionCommandSoundStopWithMovie(Production p, Sound s, Sound.CH ch, int movieID, int exe)
		: base(exe)
	{
		prod = p;
		sound = s;
		m_MovieID = movieID;
		m_Ch = ch;
		m_Class = CLASS.OTHER;
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse)
		{
			int num = prod.find(m_MovieID);
			if (num >= 0 && prod.GetCurrentFrame(num) >= execnt)
			{
				sound.Stop(m_Ch);
				m_Active = false;
			}
		}
	}

	public override void terminate()
	{
	}
}
