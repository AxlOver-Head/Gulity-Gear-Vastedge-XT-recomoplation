using UnityEngine;

public class SlotBodySEG_Bet
{
	public enum STATE
	{
		OFF = 0,
		ON = 1
	}

	private const int REP_BET = 3;

	private GameObject[] m_SEG = new GameObject[3];

	private GameObject m_insert;

	private GameObject m_start;

	private GameObject m_replay;

	private STATE m_State;

	private int m_betCnt;

	public void init()
	{
		m_SEG[0] = GameObject.Find("kyoutai/sglg_seg/bet_01");
		m_SEG[1] = GameObject.Find("kyoutai/sglg_seg/bet_02");
		m_SEG[2] = GameObject.Find("kyoutai/sglg_seg/bet_03");
		m_insert = GameObject.Find("kyoutai/sglg_seg/insert");
		m_start = GameObject.Find("kyoutai/sglg_seg/start");
		m_replay = GameObject.Find("kyoutai/sglg_seg/replay");
		for (int i = 0; i < 3; i++)
		{
			m_SEG[i].SetActive(false);
		}
		m_insert.SetActive(true);
		m_start.SetActive(false);
		m_replay.SetActive(false);
		m_betCnt = 0;
	}

	private void betSound()
	{
		if (m_betCnt == 0)
		{
			MainGameScene.sndPlay(2, 15, false, 1f);
		}
	}

	public void betOn(int _num)
	{
		betSound();
		if (m_betCnt < _num)
		{
			m_SEG[m_betCnt].SetActive(true);
			m_betCnt++;
		}
		else if (m_betCnt == _num)
		{
			m_start.SetActive(true);
		}
	}

	public void leverOn(int _num)
	{
		if (m_betCnt < _num)
		{
			for (int i = 0; i < 3; i++)
			{
				m_SEG[i].SetActive(true);
			}
			m_betCnt = _num;
		}
		m_insert.SetActive(false);
		m_start.SetActive(false);
		if (!MainGameScene.slotGameMan.m_replay)
		{
			m_replay.SetActive(false);
		}
	}

	public void stop3Off()
	{
		for (int i = 0; i < 3; i++)
		{
			m_SEG[i].SetActive(false);
		}
		if (!MainGameScene.slotGameMan.m_replay)
		{
			m_insert.SetActive(true);
			m_replay.SetActive(false);
		}
		else
		{
			m_replay.SetActive(true);
		}
		m_betCnt = 0;
	}

	public void result(int _koyaku)
	{
		if (_koyaku >= 1 && 34 >= _koyaku)
		{
			betSound();
			if (m_betCnt < 3)
			{
				m_SEG[m_betCnt].SetActive(true);
				m_betCnt++;
			}
			else if (m_betCnt == 3)
			{
				m_start.SetActive(true);
			}
		}
	}

	public void restart()
	{
		for (int i = 0; i < 3; i++)
		{
			m_SEG[i].SetActive(true);
		}
	}
}
