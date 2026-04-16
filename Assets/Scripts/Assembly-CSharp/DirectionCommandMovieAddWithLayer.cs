public class DirectionCommandMovieAddWithLayer : DirectionCommandBase
{
	private Production prod;

	private int m_PlayID;

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

	public DirectionCommandMovieAddWithLayer(Production p, int playID, int oldID, float layer, bool kill, bool loop, bool add, bool trim, int priority)
		: base(0)
	{
		prod = p;
		m_PlayID = playID;
		m_OldID = oldID;
		m_Layer = layer;
		m_Kill = kill;
		m_Loop = loop;
		m_Trim = trim;
		m_Add = add;
		m_Class = CLASS.ADDMOVIEWITHLAYER;
		m_Priority = priority;
		m_OldID = DirectionManager.changeMovie(m_OldID);
	}

	public override void control(int cnt)
	{
		if (!m_Active || m_UnUse)
		{
			return;
		}
		if (!m_Exec)
		{
			EkisyoCRI[] movies = prod.getMovies();
			for (int i = 0; i < 40; i++)
			{
				if (movies[i].m_Active && movies[i].m_MovieID == m_OldID && movies[i].m_Z == m_Layer && !movies[i].m_Kill && !movies[i].m_Killing && prod.isFinalFrame(i))
				{
					m_X = movies[i].m_X;
					m_Y = movies[i].m_Y;
					m_ProdID = i;
					m_Exec = true;
				}
			}
		}
		if (m_Exec)
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
