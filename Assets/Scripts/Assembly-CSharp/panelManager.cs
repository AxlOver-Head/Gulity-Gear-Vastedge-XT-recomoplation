using UnityEngine;

public class panelManager
{
	public enum PARTS
	{
		NONE = 0,
		ACZ001 = 1,
		ACZ002 = 2,
		ACZ003 = 3,
		ACZ004 = 4,
		ACZ010 = 5,
		ACZ012 = 6,
		ACZ014 = 7,
		CARTRIDGE = 8,
		SYSTEM_GAUGE = 9,
		LIFE_GAUGE = 10,
		TOTAL_GAME = 11,
		BE2001 = 12,
		UI_TOTAL = 13,
		UI_GET = 14,
		UI_GAME = 15,
		UI_PLUS1 = 16,
		UI_LAST = 17,
		UI_LAST_MEDAL = 18,
		UI_GB = 19,
		UI_SGB = 20,
		UI_BATTLE = 21,
		UI_PLUS2 = 22,
		UI_SLASH = 23,
		UI_JAC1 = 24,
		UI_JAC2 = 25,
		UI_NONE = 26,
		UI_SYSTEM_DOR = 27,
		UI_SYSTEM_TEN = 28,
		UI_SYSTEM_POW = 29,
		UI_LIFE_GAUGE = 30
	}

	public enum TYPE
	{
		NORMAL_GAME = 0,
		ART_TRACK = 1,
		BONUS_GET = 2,
		BONUS_GAME = 3,
		BONUS_MAX_GAME = 4,
		BONUS_GET_REMAINING = 5,
		BONUS_End_GET = 6,
		TOTAL_GET = 7,
		TOTAL_GET_BIG = 8,
		REMAINING_GAME = 9,
		TOTAL_GAME = 10,
		END_TOTAL_GAME = 11,
		PLUS_GAME = 12,
		PLUS_GAME_BIG = 13,
		BAO_TURN = 14,
		SLASH = 15,
		ROMAN = 16,
		SLASH_BIG = 17,
		HP_1P = 18,
		HP_2P = 19,
		HP_1P_OLD = 20,
		HP_2P_OLD = 21,
		DAMAGE = 22,
		ATACK_SIDE = 23,
		CARTRIDGE = 24,
		CARTRIDGE_REMAINING = 25,
		JACIN = 26
	}

	public panelACZ001 acz001;

	public panelACZ002 acz002;

	public panelACZ003 acz003;

	public panelACZ004 acz004;

	public panelACZ010 acz010;

	public panelACZ012 acz012;

	public panelACZ014 acz014;

	public panelCARTRIDGE cartridge;

	public panelGAUGE gauge;

	public panelLIFE_GAUGE life;

	public panelTOTAL_GAME total;

	public panelBE2001b be2001;

	public panelBZT7001b bzt7001;

	public int nowSetStageInfo;

	public int m_normal_game;

	public int m_track;

	public int m_bonus_get;

	public int m_bonus_game;

	public int m_bonus_max_game;

	public int m_bonus_get_remaining;

	public int m_bonus_end_get;

	public int m_total_get;

	public int m_total_get_big;

	public int m_remaining_game;

	public int m_total_game;

	public int m_end_total_game;

	public int m_plus_game;

	public int m_plus_game_big;

	public int m_BAO_turn;

	public int m_slash;

	public int m_roman;

	public int m_slash_big;

	public int m_hp_1p;

	public int m_hp_2p;

	public int m_hp_1p_old;

	public int m_hp_2p_old;

	public int m_damage;

	public int m_atack_side;

	public int m_cartridge;

	public int m_cartridge_remaining;

	public bool m_jac_flag;

	private Camera m_Camera;

	public static bool damageFlag;

	public panelManager()
	{
		acz001 = new panelACZ001();
		acz002 = new panelACZ002();
		acz003 = new panelACZ003();
		acz004 = new panelACZ004();
		acz010 = new panelACZ010();
		acz012 = new panelACZ012();
		acz014 = new panelACZ014();
		cartridge = new panelCARTRIDGE();
		gauge = new panelGAUGE();
		life = new panelLIFE_GAUGE();
		total = new panelTOTAL_GAME();
		be2001 = new panelBE2001b();
		bzt7001 = new panelBZT7001b();
		nowSetStageInfo = -1;
	}

	public void forceSetVisibleOn()
	{
		if (!(m_Camera == null))
		{
			m_Camera.enabled = true;
		}
	}

	public void forceSetVisibleOff()
	{
		if (!(m_Camera == null))
		{
			m_Camera.enabled = false;
		}
	}

	public void release()
	{
		acz001.release();
		acz002.release();
		acz003.release();
		acz004.release();
		acz010.release();
		acz012.release();
		acz014.release();
		cartridge.release();
		gauge.release();
		life.release();
		total.release();
		be2001.release();
		bzt7001.release();
		acz001 = null;
		acz002 = null;
		acz003 = null;
		acz004 = null;
		acz010 = null;
		acz012 = null;
		acz014 = null;
		cartridge = null;
		gauge = null;
		life = null;
		total = null;
		be2001 = null;
		bzt7001 = null;
	}

	public void init()
	{
		acz001.init();
		acz002.init();
		acz003.init();
		acz004.init();
		acz010.init();
		acz012.init();
		acz014.init();
		cartridge.init();
		gauge.init();
		life.init();
		total.init();
		be2001.init();
		bzt7001.init();
		m_Camera = GameObject.Find("GUIDirection/Camera").GetComponent<Camera>();
	}

	public void control(int _stage)
	{
		acz001.setGame(m_normal_game);
		acz002.setGame(m_normal_game);
		acz003.setGame(m_normal_game);
		acz010.setTrack(m_track);
		acz012.setTrack(m_track);
		switch (_stage)
		{
		case 0:
		case 1:
		case 2:
		case 3:
		case 4:
		case 8:
		case 10:
		case 11:
		case 12:
		case 21:
		case 22:
		case 23:
		case 24:
		case 26:
		case 29:
			onJacIn(-1, false);
			break;
		case 5:
		case 6:
		case 7:
		case 30:
			total.setTotalGet(m_total_get);
			total.setTotalGame(m_total_game);
			if (_stage != 7)
			{
				total.setRemainingGame(m_remaining_game);
				onJacIn(1, m_jac_flag);
			}
			else
			{
				onJacIn(-1, false);
			}
			break;
		case 9:
			total.setTotalGet(m_total_get);
			total.setRemainingGame(m_remaining_game);
			total.setTotalGame(m_total_game);
			total.setPlusGame(m_plus_game);
			onJacIn(1, m_jac_flag);
			break;
		case 13:
		case 15:
		case 19:
			total.setTotalGet(m_total_get);
			total.setBonusGet(m_bonus_get);
			total.setBonusGameGB(m_bonus_max_game - m_bonus_game);
			total.setBonusMaxGame(m_bonus_max_game);
			onJacIn(0, m_jac_flag);
			break;
		case 14:
		case 16:
			total.setTotalGet(m_total_get);
			total.setBonusGet(m_bonus_get);
			total.setBonusGameSGB(m_bonus_max_game - m_bonus_game);
			total.setBonusMaxGame(m_bonus_max_game);
			onJacIn(0, m_jac_flag);
			break;
		case 17:
		case 18:
			total.setTotalGet(m_total_get);
			total.setTotalGame(m_bonus_get);
			total.setPlusGame(m_plus_game);
			total.setBAOTurn(10 - m_BAO_turn);
			onJacIn(0, m_jac_flag);
			break;
		case 20:
			total.setTotalGet(m_total_get);
			total.setBonusGet(m_bonus_get);
			total.setBonusGetRemaining(m_bonus_get_remaining);
			onJacIn(-1, false);
			break;
		case 25:
		case 27:
		case 28:
			total.setTotalGet(m_total_get);
			total.setSlash(m_slash);
			onJacIn(-1, false);
			break;
		}
		be2001.setTotal(m_total_get_big);
		be2001.setGet(m_bonus_end_get);
		bzt7001.setTotal(m_total_game);
		bzt7001.setGet(m_total_get_big);
		acz001.Update();
		acz002.Update();
		acz003.Update();
		acz004.Update();
		acz010.Update();
		acz012.Update();
		acz014.Update();
		cartridge.Update();
		gauge.Update();
		life.Update();
		total.Update();
		be2001.Update();
		bzt7001.Update();
	}

	public void setParam(TYPE _type, int _num)
	{
		int num = _num;
		if (num > 9999)
		{
			num = 9999;
		}
		if (num < 0)
		{
			num = 0;
		}
		switch (_type)
		{
		case TYPE.NORMAL_GAME:
			m_normal_game = num;
			break;
		case TYPE.ART_TRACK:
			m_track = num;
			break;
		case TYPE.BONUS_GET:
			m_bonus_get = num;
			break;
		case TYPE.BONUS_GAME:
			m_bonus_game = num;
			break;
		case TYPE.BONUS_MAX_GAME:
			m_bonus_max_game = num;
			break;
		case TYPE.BONUS_GET_REMAINING:
			m_bonus_get_remaining = num;
			break;
		case TYPE.BONUS_End_GET:
			m_bonus_end_get = num;
			break;
		case TYPE.TOTAL_GET:
			m_total_get = num;
			break;
		case TYPE.TOTAL_GET_BIG:
			m_total_get_big = num;
			break;
		case TYPE.REMAINING_GAME:
			m_remaining_game = num;
			break;
		case TYPE.TOTAL_GAME:
			m_total_game = num;
			break;
		case TYPE.END_TOTAL_GAME:
			m_end_total_game = num;
			break;
		case TYPE.PLUS_GAME:
			m_plus_game = num;
			break;
		case TYPE.PLUS_GAME_BIG:
			m_plus_game_big = num;
			break;
		case TYPE.BAO_TURN:
			m_BAO_turn = num;
			break;
		case TYPE.SLASH:
			m_slash = num;
			break;
		case TYPE.ROMAN:
			m_roman = num;
			break;
		case TYPE.SLASH_BIG:
			m_slash_big = num;
			break;
		case TYPE.HP_1P:
			m_hp_1p = num;
			break;
		case TYPE.HP_2P:
			m_hp_2p = num;
			break;
		case TYPE.HP_1P_OLD:
			m_hp_1p_old = num;
			break;
		case TYPE.HP_2P_OLD:
			m_hp_2p_old = num;
			break;
		case TYPE.DAMAGE:
			m_damage = num;
			break;
		case TYPE.ATACK_SIDE:
			m_atack_side = num;
			break;
		case TYPE.CARTRIDGE:
			m_cartridge = num;
			break;
		case TYPE.CARTRIDGE_REMAINING:
			m_cartridge_remaining = num;
			break;
		}
	}

	public void setParam(TYPE _type, bool _flag)
	{
		if (_type == TYPE.JACIN)
		{
			m_jac_flag = _flag;
		}
	}

	public void setVisible(int _parts, int _kind, bool flag)
	{
	}

	public void setStageInfo(int _stage)
	{
		nowSetStageInfo = _stage;
	}

	public int getStageInfo()
	{
		return nowSetStageInfo;
	}

	public void setBase(int _parts)
	{
		switch (_parts)
		{
		case 0:
			acz001.allDisable();
			acz002.allDisable();
			acz003.allDisable();
			acz004.allDisable();
			acz010.allDisable();
			acz012.allDisable();
			acz014.allDisable();
			gauge.allDisable();
			life.allDisable();
			total.allDisable();
			be2001.allDisable();
			bzt7001.allDisable();
			break;
		case 1:
			acz001.baseEnable();
			acz002.allDisable();
			acz003.allDisable();
			acz004.allDisable();
			acz010.allDisable();
			acz012.allDisable();
			acz014.allDisable();
			break;
		case 2:
			acz001.allDisable();
			acz002.baseEnable();
			acz003.allDisable();
			acz004.allDisable();
			acz010.allDisable();
			acz012.allDisable();
			acz014.allDisable();
			break;
		case 3:
			acz001.allDisable();
			acz002.allDisable();
			acz003.baseEnable();
			acz004.allDisable();
			acz010.allDisable();
			acz012.allDisable();
			acz014.allDisable();
			break;
		case 4:
			acz001.allDisable();
			acz002.allDisable();
			acz003.allDisable();
			acz004.baseEnable();
			acz010.allDisable();
			acz012.allDisable();
			acz014.allDisable();
			break;
		case 5:
			acz001.allDisable();
			acz002.allDisable();
			acz003.allDisable();
			acz004.allDisable();
			acz010.baseEnable();
			acz012.allDisable();
			acz014.allDisable();
			break;
		case 6:
			acz001.allDisable();
			acz002.allDisable();
			acz003.allDisable();
			acz004.allDisable();
			acz010.allDisable();
			acz012.baseEnable();
			acz014.allDisable();
			break;
		case 7:
			acz014.baseEnable();
			break;
		case 8:
			break;
		case 9:
			break;
		case 10:
			break;
		case 11:
			break;
		case 12:
			break;
		case 13:
			total.dispTotal();
			break;
		case 14:
			total.dispGet();
			break;
		case 15:
			total.dispGame();
			break;
		case 16:
			total.dispPlus1();
			break;
		case 17:
			total.dispLast();
			break;
		case 18:
			total.dispLastMedal();
			break;
		case 19:
			total.dispGB();
			break;
		case 20:
			total.dispSGB();
			break;
		case 21:
			total.dispBattle();
			break;
		case 22:
			total.dispPlus2();
			break;
		case 23:
			total.dispSlash();
			break;
		case 24:
			total.dispJac1();
			break;
		case 25:
			total.dispJac2();
			break;
		case 26:
			total.allDisable();
			break;
		case 27:
			gauge.setDispGauge(0);
			break;
		case 28:
			gauge.setDispGauge(1);
			break;
		case 29:
			gauge.setDispGauge(2);
			break;
		case 30:
			life.allEnable();
			break;
		}
	}

	public void onCartridge(int _idx, int _col)
	{
		cartridge.onDispCartridge(_idx, _col);
	}

	public void offCartridge(int _idx)
	{
		cartridge.offDispCartridge(_idx);
	}

	public void flashCartridge(int _idx)
	{
		cartridge.setFlash(_idx);
	}

	public void clearCartridge()
	{
		cartridge.allDisable();
	}

	public void onBzt7001_total()
	{
		bzt7001.dispTotal();
	}

	public void onBzt7001_get()
	{
		bzt7001.dispGet();
	}

	public void onBe2001_total()
	{
		be2001.dispTotal();
	}

	public void onBe2001_get()
	{
		be2001.dispGet();
	}

	public void onDamage()
	{
		life.setDamage();
		setDamageFlag(false);
	}

	public void onDamageCmd()
	{
		if (getDamageFlag())
		{
			life.setDamage();
		}
	}

	public void onDamageLever(int _atk, int _dmg)
	{
		life.setDamage();
		life.setNowDamage(_atk, _dmg);
		setDamageFlag(false);
	}

	public static void setDamageFlag(bool _flag)
	{
		damageFlag = _flag;
	}

	public static bool getDamageFlag()
	{
		return damageFlag;
	}

	public void onJacIn(int _type, bool _flag)
	{
		if (!_flag)
		{
			total.setJacIn1(false);
			total.setJacIn2(false);
			return;
		}
		switch (_type)
		{
		case 0:
			total.setJacIn2(false);
			total.setJacIn1(true);
			break;
		case 1:
			total.setJacIn1(false);
			total.setJacIn2(true);
			break;
		}
	}
}
