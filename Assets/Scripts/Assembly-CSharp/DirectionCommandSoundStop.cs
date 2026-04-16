public class DirectionCommandSoundStop : DirectionCommandBase
{
	private Sound sound;

	private Sound.CH m_Ch;

	public DirectionCommandSoundStop(Sound s, Sound.CH ch, int exe)
		: base(exe)
	{
		sound = s;
		m_Ch = ch;
		m_Class = CLASS.OTHER;
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse && checkExe(cnt))
		{
			sound.Stop(m_Ch);
			m_Active = false;
		}
	}

	public override void terminate()
	{
	}
}
