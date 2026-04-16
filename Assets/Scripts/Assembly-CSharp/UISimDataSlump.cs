using UnityEngine;

public class UISimDataSlump
{
	public static readonly float WIDTH = 558f;

	public static readonly float HEIGHT = 638f;

	private UISimData parent;

	private SlumpDataSim m_Slump;

	private LineRenderer m_Graph;

	private int m_Length;

	private int m_MaxTate;

	private int m_MaxYoko;

	private UISprite[] m_MaxGame;

	private UISprite[] m_MaxMedal;

	private UISprite[] m_MinMedal;

	public UISimDataSlump(UISimData _parent)
	{
		string text = _parent.name + "/Camera/Anchor2_Center/Panel_4_Slump/";
		string[] name = new string[5] { "Game_Max/00001", "Game_Max/00010", "Game_Max/00100", "Game_Max/01000", "Game_Max/10000" };
		string[] name2 = new string[5] { "Medal_Max/00001", "Medal_Max/00010", "Medal_Max/00100", "Medal_Max/01000", "Medal_Max/10000" };
		string[] name3 = new string[6] { "Medal_Min/00001", "Medal_Min/00010", "Medal_Min/00100", "Medal_Min/01000", "Medal_Min/10000", "Medal_Min/minus" };
		parent = _parent;
		m_MaxGame = parent.setUISprite(text, name);
		m_MaxMedal = parent.setUISprite(text, name2);
		m_MinMedal = parent.setUISprite(text, name3);
		m_Graph = GameObject.Find(text + "Graph").GetComponent<LineRenderer>();
	}

	public void setData(SlumpDataSim slump)
	{
		m_Slump = slump;
		m_MaxTate = m_Slump.getTateMax();
		m_MaxYoko = m_Slump.getYokoMax();
		m_Length = m_Slump.getDataNum();
		m_Graph.SetVertexCount(m_Length);
		for (int i = 0; i < m_Length; i++)
		{
			Vector3 position = makePos(m_Slump.data(i));
			m_Graph.SetPosition(i, position);
		}
		if (m_MaxTate < 1000)
		{
			m_MaxTate = 1000;
		}
		if (m_MaxYoko < 1000)
		{
			m_MaxYoko = 1000;
		}
		if (m_MaxTate > 99999)
		{
			m_MaxTate = 99999;
		}
		if (m_MaxYoko > 99999)
		{
			m_MaxYoko = 99999;
		}
		UISprite[] array = null;
		int num = 0;
		array = m_MaxGame;
		num = m_MaxYoko;
		parent.setSpriteGraphNum(0, num, array[0], false);
		parent.setSpriteGraphNum(1, num, array[1], true);
		parent.setSpriteGraphNum(2, num, array[2], true);
		parent.setSpriteGraphNum(3, num, array[3], true);
		parent.setSpriteGraphNum(4, num, array[4], true);
		array = m_MaxMedal;
		num = m_MaxTate;
		parent.setSpriteGraphNum(0, num, array[0], false);
		parent.setSpriteGraphNum(1, num, array[1], true);
		parent.setSpriteGraphNum(2, num, array[2], true);
		parent.setSpriteGraphNum(3, num, array[3], true);
		parent.setSpriteGraphNum(4, num, array[4], true);
		array = m_MinMedal;
		num = -m_MaxTate;
		parent.setSpriteGraphNum(0, num, array[0], false);
		parent.setSpriteGraphNum(1, num, array[1], true);
		parent.setSpriteGraphNum(2, num, array[2], true);
		parent.setSpriteGraphNum(3, num, array[3], true);
		parent.setSpriteGraphNum(4, num, array[4], true);
		parent.setSpriteGraphMinus(num, array[5], 5);
	}

	private Vector3 makePos(SlumpDataCore data)
	{
		if (data == null)
		{
			return new Vector3(0f, 0f, 0f);
		}
		int num = data.game;
		int num2 = data.medal;
		if (num > 99999)
		{
			num = 99999;
		}
		if (num < 0)
		{
			num = 0;
		}
		if (num2 > 99999)
		{
			num2 = 99999;
		}
		if (num2 < -99999)
		{
			num2 = -99999;
		}
		float x = (float)num * WIDTH / (float)m_MaxYoko;
		float y = (float)num2 * HEIGHT / (float)m_MaxTate / 2f;
		float z = 0f;
		return new Vector3(x, y, z);
	}
}
