public class DirectionCommandAnimePlay : DirectionCommandBase
{
	private ProductionAnime prodAnime;

	private int m_PlayID;

	private int m_PatternID;

	private bool m_Kill;

	private bool m_Loop;

	private bool m_Add;

	private bool m_Trim;

	private int m_X;

	private int m_Y;

	private int m_Layer;

	public int m_ProdID = -1;

	private int m_Priority;

	public DirectionCommandAnimePlay(ProductionAnime p, int playID, int ptnID, bool kill, bool loop, bool add, bool trim, int x, int y, int layer, int exe, int priority)
		: base(exe)
	{
		prodAnime = p;
		m_PlayID = playID;
		m_PatternID = ptnID;
		m_Kill = kill;
		m_Loop = loop;
		m_Add = add;
		m_Trim = trim;
		m_X = x;
		m_Y = y;
		m_Layer = layer;
		m_Class = CLASS.PLAYANIME;
		m_Priority = priority;
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse && checkExe(cnt))
		{
			m_ProdID = prodAnime.MakeAnime(m_PlayID, m_Layer, m_Kill, m_Loop, m_Add, m_Trim, m_X, m_Y, m_Priority);
			if (m_ProdID < 0)
			{
				m_UnUse = true;
				return;
			}
			prodAnime.changePattern(m_ProdID, m_PatternID);
			setPlayPush(m_PlayID);
			m_Active = false;
		}
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
