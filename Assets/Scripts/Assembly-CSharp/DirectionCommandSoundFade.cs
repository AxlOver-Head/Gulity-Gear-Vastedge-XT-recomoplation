public class DirectionCommandSoundFade : DirectionCommandBase
{
	private Sound sound;

	private Sound.CH m_Ch;

	private float m_Start;

	private float m_End;

	private int m_Frame;

	public DirectionCommandSoundFade(Sound s, Sound.CH ch, float start, float end, int frame, int exe)
		: base(exe)
	{
		sound = s;
		m_Ch = ch;
		m_Start = start;
		m_End = end;
		m_Frame = frame;
		m_Class = CLASS.OTHER;
		if (m_Frame <= 0)
		{
			m_Frame = 1;
		}
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse && checkExe(cnt))
		{
			int num = cnt - execnt;
			float vol = m_Start + (m_End - m_Start) * (float)num / (float)m_Frame;
			sound.SetVolume(m_Ch, vol);
			if (cnt >= execnt + m_Frame)
			{
				m_Active = false;
			}
		}
	}

	public override void terminate()
	{
		sound.SetVolume(m_Ch, m_End);
	}
}
