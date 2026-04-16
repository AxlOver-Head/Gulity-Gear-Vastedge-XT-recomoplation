public class DirectionCommandAnimeAddWithPosition : DirectionCommandBase
{
	private ProductionAnime prodAnime;

	private int m_PlayID;

	private int m_PatternID;

	private int m_OldID;

	private bool m_Kill;

	private bool m_Loop;

	private bool m_Trim;

	private bool m_Add;

	private float m_X;

	private float m_Y;

	private float m_Layer;

	public int m_ProdID = -1;

	private bool m_Exec;

	private int m_Priority;

	public DirectionCommandAnimeAddWithPosition(ProductionAnime p, int playID, int ptnID, int oldID, bool kill, bool loop, bool add, bool trim, int x, int y, int priority)
		: base(0)
	{
		prodAnime = p;
		m_PlayID = playID;
		m_PatternID = ptnID;
		m_OldID = oldID;
		m_Kill = kill;
		m_Loop = loop;
		m_Trim = trim;
		m_Add = add;
		m_X = x;
		m_Y = y;
		m_Class = CLASS.ADDANIMEWITHPOS;
		m_Priority = priority;
	}

	public override void control(int cnt)
	{
		if (!m_Active || m_UnUse)
		{
			return;
		}
		int num = prodAnime.find(m_OldID);
		if (!m_Exec && num >= 0)
		{
			m_Layer = prodAnime.GetZ(num);
			m_Exec = true;
		}
		if (!m_Exec || !prodAnime.isFinalFrame(num))
		{
			return;
		}
		if (prodAnime.IsPlaying(num) || prodAnime.IsPlayEnd(num) || prodAnime.isHold(num))
		{
			m_ProdID = prodAnime.MakeAnime(m_PlayID, m_Layer, m_Kill, m_Loop, m_Add, m_Trim, m_X, m_Y, m_Priority);
			if (m_ProdID < 0)
			{
				m_UnUse = true;
				return;
			}
			prodAnime.changePattern(m_ProdID, m_PatternID);
			setPlayPush(m_PlayID);
		}
		m_Active = false;
	}

	public override void terminate()
	{
		int num = prodAnime.find(m_PlayID);
		if (num >= 0 && num == m_ProdID)
		{
			prodAnime.Kill(m_ProdID);
			setKillPush(m_PlayID);
		}
	}
}
