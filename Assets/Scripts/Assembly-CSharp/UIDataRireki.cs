using UnityEngine;

public class UIDataRireki
{
	public enum ATARI
	{
		PBB = 0,
		RB = 1,
		BB = 2,
		SBB = 3,
		ART = 4
	}

	public enum YAKU
	{
		CHERRY_C = 0,
		CHERRY_J = 1,
		CHERRY_K = 2,
		BELL_K = 3,
		BELL = 4,
		SUIKA = 5,
		CHANCE_A = 6,
		CHANCE_B = 7,
		CHANCE_C = 8,
		REPLAY = 9
	}

	private UISprite m_Atari;

	private UISprite m_Yaku;

	private UISprite m_Unit;

	private UISprite[] m_Games;

	private int m_ID;

	private UIData parent;

	public UIDataRireki(int _id, UIData _parent)
	{
		string empty = string.Empty;
		string[] name = new string[5] { "num_0_001", "num_0_010", "num_0_100", "num_1_000", "num_0X000" };
		empty = ((_id + 1 < 10) ? ("Data(Clone)/Camera/Anchor1_Top/Panel_3_Rireki/ScrollPanel/Rireki/Rireki_0" + (_id + 1) + "/") : ("Data(Clone)/Camera/Anchor1_Top/Panel_3_Rireki/ScrollPanel/Rireki/Rireki_" + (_id + 1) + "/"));
		m_Atari = GameObject.Find(empty + "Tousen").GetComponent<UISprite>();
		m_Yaku = GameObject.Find(empty + "Yaku").GetComponent<UISprite>();
		m_Unit = GameObject.Find(empty + "Game").GetComponent<UISprite>();
		parent = _parent;
		m_Games = parent.setUISprite(empty, name);
		m_ID = _id;
	}

	public void setData(int _atari, int _yaku, int _game)
	{
		if (_atari < 0)
		{
			m_Atari.color = new Color(1f, 1f, 1f, 0f);
			m_Yaku.color = new Color(1f, 1f, 1f, 0f);
			m_Unit.color = new Color(1f, 1f, 1f, 0f);
			for (int i = 0; i < m_Games.Length; i++)
			{
				m_Games[i].color = new Color(1f, 1f, 1f, 0f);
			}
			return;
		}
		string[] array = new string[5] { "data_rireki_atari_01", "data_rireki_atari_04", "data_rireki_atari_03", "data_rireki_atari_02", "data_rireki_atari_05" };
		string[] array2 = new string[10] { "data_rireki_yaku_01", "data_rireki_yaku_02", "data_rireki_yaku_03", "data_rireki_yaku_04", "data_rireki_yaku_05", "data_rireki_yaku_06", "data_rireki_yaku_07", "data_rireki_yaku_08", "data_rireki_yaku_09", "data_rireki_yaku_10" };
		if (_atari < 0)
		{
			_atari = 0;
		}
		if (_atari > 4)
		{
			_atari = 4;
		}
		if (_yaku < 0)
		{
			_yaku = 0;
		}
		if (_yaku > 9)
		{
			_yaku = 9;
		}
		if (_game < 0)
		{
			_game = 0;
		}
		if (_game > 9999)
		{
			_game = 9999;
		}
		m_Atari.spriteName = array[_atari];
		m_Yaku.spriteName = array2[_yaku];
		parent.setSpriteNum(0, _game, m_Games[0], false);
		parent.setSpriteNum(1, _game, m_Games[1], true);
		parent.setSpriteNum(2, _game, m_Games[2], true);
		parent.setSpriteNum(3, _game, m_Games[3], true);
		parent.setSpriteComma(_game, m_Games[4]);
	}
}
