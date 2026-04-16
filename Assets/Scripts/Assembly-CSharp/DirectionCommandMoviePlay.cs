public class DirectionCommandMoviePlay : DirectionCommandBase
{
	private Production prod;

	private int m_PlayID;

	private bool m_Kill;

	private bool m_Loop;

	private bool m_Add;

	private bool m_Trim;

	private int m_X;

	private int m_Y;

	private int m_Layer;

	public int m_ProdID = -1;

	private int m_Priority;

	public DirectionCommandMoviePlay(Production p, int playID, bool kill, bool loop, bool add, bool trim, int x, int y, int layer, int exe, int priority)
		: base(exe)
	{
		prod = p;
		m_PlayID = playID;
		m_Kill = kill;
		m_Loop = loop;
		m_Add = add;
		m_Trim = trim;
		m_X = x;
		m_Y = y;
		m_Layer = layer;
		m_Class = CLASS.PLAYMOVIE;
		m_Priority = priority;
	}

	public override void control(int cnt)
	{
		if (m_Active && !m_UnUse && checkExe(cnt))
		{
			DirectionYakuManager.setMovieDamageYaku(m_PlayID);
			m_PlayID = DirectionManager.changeMovie(m_PlayID);
			m_ProdID = prod.MakeMovie(m_PlayID, m_Layer, m_Kill, m_Loop, m_Add, m_Trim, m_X, m_Y, m_Priority);
			if (m_ProdID < 0)
			{
				m_UnUse = true;
				return;
			}
			DirectionYakuManager.setMovieYaku(m_PlayID);
			setPlayPush(m_PlayID);
			m_Active = false;
		}
	}

	public override void terminate()
	{
		int num = prod.find(m_PlayID);
		if (num >= 0 && num == m_ProdID)
		{
			prod.Kill(m_ProdID);
			setKillPush(m_PlayID);
		}
	}
}
