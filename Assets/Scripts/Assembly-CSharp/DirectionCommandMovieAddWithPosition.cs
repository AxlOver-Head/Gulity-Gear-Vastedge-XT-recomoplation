public class DirectionCommandMovieAddWithPosition : DirectionCommandBase
{
	private Production prod;

	private int m_PlayID;

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

	public DirectionCommandMovieAddWithPosition(Production p, int playID, int oldID, bool kill, bool loop, bool add, bool trim, int x, int y, int priority)
		: base(0)
	{
		prod = p;
		m_PlayID = playID;
		m_OldID = oldID;
		m_Kill = kill;
		m_Loop = loop;
		m_Trim = trim;
		m_Add = add;
		m_X = x;
		m_Y = y;
		m_Class = CLASS.ADDMOVIEWITHPOS;
		m_Priority = priority;
	}

	public override void control(int cnt)
	{
		if (!m_Active || m_UnUse)
		{
			return;
		}
		m_OldID = DirectionManager.changeMovie(m_OldID);
		int num = prod.find(m_OldID);
		if (!m_Exec && num >= 0)
		{
			m_Layer = prod.GetZ(num);
			m_Exec = true;
		}
		if (!m_Exec || !prod.isFinalFrame(num))
		{
			return;
		}
		if (prod.IsPlaying(num) || prod.IsPlayEnd(num) || prod.isHold(num))
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
		}
		m_Active = false;
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
