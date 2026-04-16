public class DirectionCommandSoundPlay : DirectionCommandBase
{
	private Sound sound;

	private DirectionLedManager m_dlm;

	private int m_PlayID;

	private Sound.CH m_Ch;

	private bool m_Stop;

	private float m_Volume;

	public DirectionCommandSoundPlay(DirectionLedManager dlm, Sound s, int playID, Sound.CH ch, bool stop, float volume, int exe)
		: base(exe)
	{
		m_dlm = dlm;
		sound = s;
		m_PlayID = playID;
		m_Ch = ch;
		m_Stop = stop;
		m_Volume = volume;
		m_Class = CLASS.OTHER;
		if (playID == 1482)
		{
			execnt -= 12;
			if (execnt < 0)
			{
				execnt = 0;
			}
		}
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse && checkExe(cnt))
		{
			m_PlayID = DirectionManager.changeSound(m_PlayID);
			sound.Stop(Sound.CH.VC2);
			sound.PlaySound(m_PlayID, m_Ch, m_Stop);
			sound.SetVolume(m_Ch, m_Volume);
			m_dlm.setSndLed((DirectionManager.SOUND)m_PlayID);
			m_Active = false;
		}
	}

	public override void terminate()
	{
		if (m_Ch != Sound.CH.BGM && m_Ch != Sound.CH.VC2)
		{
			sound.Stop(m_Ch);
		}
	}
}
