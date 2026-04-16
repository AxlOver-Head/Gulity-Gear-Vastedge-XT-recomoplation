public class DirectionCommandAnimeAddWithLayerAndPosition : DirectionCommandBase
{
	private ProductionAnime prodAnime;

	private int m_PlayID;

	private int m_PatternID;

	private int m_OldID;

	private float m_Layer;

	private bool m_Kill;

	private bool m_Loop;

	private bool m_Trim;

	private bool m_Add;

	private float m_X;

	private float m_Y;

	public int m_ProdID = -1;

	private bool m_Exec;

	private int m_Priority;

	public DirectionCommandAnimeAddWithLayerAndPosition(ProductionAnime p, int playID, int ptnID, int oldID, float layer, bool kill, bool loop, bool add, bool trim, int x, int y, int priority)
		: base(0)
	{
		prodAnime = p;
		m_PlayID = playID;
		m_PatternID = ptnID;
		m_OldID = oldID;
		m_Layer = layer;
		m_Kill = kill;
		m_Loop = loop;
		m_Trim = trim;
		m_Add = add;
		m_X = x;
		m_Y = y;
		m_Class = CLASS.ADDANIMEWITHLAYERANDPOS;
		m_Priority = priority;
	}

	public override void control(int cnt)
	{
		if (!m_Active || m_UnUse)
		{
			return;
		}
		if (!m_Exec)
		{
			EkisyoAnime[] animes = prodAnime.getAnimes();
			for (int i = 0; i < 32; i++)
			{
				if (animes[i].m_Active && animes[i].m_AnimeID == m_OldID && animes[i].m_Z == m_Layer && !animes[i].m_Kill && !animes[i].m_Killing && prodAnime.isFinalFrame(i))
				{
					m_ProdID = i;
					m_Exec = true;
				}
			}
		}
		if (m_Exec)
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
