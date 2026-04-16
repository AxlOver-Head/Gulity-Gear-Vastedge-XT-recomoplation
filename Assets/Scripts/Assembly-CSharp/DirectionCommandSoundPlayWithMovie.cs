public class DirectionCommandSoundPlayWithMovie : DirectionCommandBase
{
	private Production prod;

	private Sound sound;

	private DirectionLedManager m_dlm;

	private int m_PlayID;

	private int m_MovieID;

	private Sound.CH m_Ch;

	private bool m_Stop;

	private float m_Volume;

	public DirectionCommandSoundPlayWithMovie(DirectionLedManager dlm, Production p, Sound s, int playID, int movieID, Sound.CH ch, bool stop, float volume, int exe)
		: base(exe)
	{
		m_dlm = dlm;
		prod = p;
		sound = s;
		m_PlayID = playID;
		m_MovieID = movieID;
		m_Ch = ch;
		m_Stop = stop;
		m_Volume = volume;
		m_Class = CLASS.OTHER;
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse)
		{
			int num = prod.find(m_MovieID);
			if (num >= 0 && prod.GetCurrentFrame(num) >= execnt)
			{
				m_PlayID = DirectionManager.changeSound(m_PlayID);
				sound.PlaySound(m_PlayID, m_Ch, m_Stop);
				sound.SetVolume(m_Ch, m_Volume);
				m_dlm.setSndLed((DirectionManager.SOUND)m_PlayID);
				m_Active = false;
			}
		}
	}

	public override void terminate()
	{
		sound.Stop(m_Ch);
	}
}
