using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductionAnime : MonoBehaviour
{
	public const int ANIME_MAX = 32;

	private EkisyoAnime[] animes = new EkisyoAnime[32];

	public static List<int> m_PrepareList = new List<int>
	{
		Capacity = 32
	};

	public static List<int> m_DeleteList = new List<int>
	{
		Capacity = 32
	};

	public EkisyoAnime[] getAnimes()
	{
		return animes;
	}

	private void Start()
	{
	}

	public void Dispose(bool _flag)
	{
		if (animes != null)
		{
			for (int i = 0; i < 32; i++)
			{
				if (animes[i] != null && _flag)
				{
					animes[i].terminate();
					animes[i] = null;
				}
			}
		}
		EkisyoAnime.dispose();
	}

	public void init()
	{
		EkisyoAnime.create();
		ClearAnime();
		m_PrepareList.Clear();
		m_DeleteList.Clear();
		ProdAnimeFrameInfo.init();
	}

	public void control()
	{
		for (int i = 0; i < 32; i++)
		{
			if (animes[i].m_Active)
			{
				animes[i].control();
			}
		}
		if (isHold())
		{
			DisableHeldAnime();
		}
	}

	public int find(int _id)
	{
		for (int i = 0; i < 32; i++)
		{
			if (animes[i].m_Active && !animes[i].m_Kill && !animes[i].m_Killing && animes[i].m_AnimeID == _id)
			{
				return i;
			}
		}
		return -1;
	}

	public void ClearAnime()
	{
		for (int i = 0; i < 32; i++)
		{
			animes[i] = new EkisyoAnime();
			animes[i].init();
			animes[i].m_ProdID = i;
		}
	}

	private int searchMakeProd(int _start, int _end)
	{
		int result = -1;
		if (_end > 32)
		{
			_end = 32;
		}
		for (int i = _start; i < _end; i++)
		{
			if (!animes[i].m_Active && !animes[i].m_Prep && !animes[i].m_Play && !animes[i].m_Hold && !animes[i].m_Kill && !animes[i].m_Killing)
			{
				result = i;
				break;
			}
		}
		return result;
	}

	public int MakeAnime(int _playID, float _layer, bool _killSelf, bool _loop, bool _add, bool _trim, float _x, float _y, int priority)
	{
		int num = -1;
		num = searchMakeProd(0, 32);
		if (num < 0)
		{
			return -1;
		}
		for (int i = 0; i < 32; i++)
		{
			if (animes[i].m_Active && _layer == animes[i].m_Z && animes[i].m_Priority > priority && priority >= 0)
			{
				return -1;
			}
		}
		SetLayer(num, _layer);
		SetKillSelf(num, _killSelf);
		SetLoop(num, _loop);
		SetAdditive(num, _add);
		SetTrim(num, _trim);
		SetXY(num, _x, _y);
		SetScale(num, 1f, 1f);
		SetPriority(num, priority);
		animes[num].prepare(_playID);
		return num;
	}

	public void SetAdditive(int _id, bool _additive)
	{
		if (_id >= 0 && _id < 32)
		{
			animes[_id].setAdditive(_additive);
		}
	}

	public void SetKillSelf(int _id, bool _killSelf)
	{
		if (_id >= 0 && _id < 32)
		{
			animes[_id].setKillSelf(_killSelf);
		}
	}

	public void SetKillSelf(bool _killSelf)
	{
		for (int i = 0; i < 32; i++)
		{
			SetKillSelf(i, _killSelf);
		}
	}

	public void SetLoop(int _id, bool _loop)
	{
		if (_id >= 0 && _id < 32)
		{
			animes[_id].setLoop(_loop);
		}
	}

	public void SetTrim(int _id, bool _trim)
	{
		if (_id >= 0 && _id < 32)
		{
			animes[_id].setTrim(_trim);
		}
	}

	public void SetXY(int _id, float _x, float _y)
	{
		if (_id >= 0 && _id < 32)
		{
			animes[_id].setXY(_x, _y);
			animes[_id].updatePosition();
		}
	}

	public void SetPriority(int _id, int priority)
	{
		if (_id >= 0 && _id < 32)
		{
			animes[_id].setPriority(priority);
		}
	}

	public void SetScale(int _id, float _x, float _y)
	{
		if (_id >= 0 && _id < 32)
		{
			animes[_id].setScale(_x, _y);
			animes[_id].updateScale();
			animes[_id].updatePosition();
		}
	}

	public void SetLayer(int _id, float _layer)
	{
		if (_id >= 0 && _id < 32)
		{
			animes[_id].setLayer(_layer);
		}
	}

	public bool IsPlaying(int _id)
	{
		if (_id < 0 || _id >= 32)
		{
			return false;
		}
		return animes[_id].isPlaying();
	}

	public bool IsPlayEnd(int _id)
	{
		if (_id < 0 || _id >= 32)
		{
			return false;
		}
		return animes[_id].isPlayEnd();
	}

	public bool IsStop(int _id)
	{
		if (_id < 0 || _id >= 32)
		{
			return false;
		}
		return animes[_id].isStop();
	}

	public bool IsKill(int _id)
	{
		if (_id < 0 || _id >= 32)
		{
			return false;
		}
		return animes[_id].m_Kill;
	}

	public bool IsKilling(int _id)
	{
		if (_id < 0 || _id >= 32)
		{
			return false;
		}
		return animes[_id].m_Killing;
	}

	public bool IsReady(int _id)
	{
		if (_id < 0 || _id >= 32)
		{
			return false;
		}
		return animes[_id].isReady();
	}

	public bool IsPrep(int _id)
	{
		if (_id < 0 || _id >= 32)
		{
			return false;
		}
		return animes[_id].isPrep();
	}

	public bool IsPaused(int _id)
	{
		if (_id < 0 || _id >= 32)
		{
			return false;
		}
		return animes[_id].isPaused();
	}

	public bool checkPreparing()
	{
		if (animes == null)
		{
			return false;
		}
		for (int i = 0; i < 32; i++)
		{
			if (animes[i] != null && animes[i].m_Active)
			{
				if (IsPrep(i))
				{
					return true;
				}
				if (isHold(i))
				{
					return true;
				}
				if (IsStop(i))
				{
					return true;
				}
				if (!animes[i].IsActive())
				{
					return true;
				}
			}
		}
		return false;
	}

	private IEnumerator coPlayAll()
	{
		bool flag = true;
		do
		{
			if (!flag)
			{
				yield return null;
			}
			flag = true;
			for (int i = 0; i < m_PrepareList.Count; i++)
			{
				if (!animes[m_PrepareList[i]].m_Active || !animes[m_PrepareList[i]].m_Prep)
				{
					if (animes[m_PrepareList[i]].m_Prep)
					{
						Kill(m_PrepareList[i]);
					}
					m_DeleteList.Add(i);
				}
				else if (!animes[m_PrepareList[i]].isReady())
				{
					flag = false;
					break;
				}
			}
			for (int i2 = m_DeleteList.Count - 1; i2 >= 0; i2--)
			{
				m_PrepareList.Remove(m_PrepareList[m_DeleteList[i2]]);
			}
			m_DeleteList.Clear();
		}
		while (!flag);
		foreach (int it in m_PrepareList)
		{
			play(it);
		}
		m_PrepareList.Clear();
	}

	private void play(int it)
	{
		for (int i = 0; i < 32; i++)
		{
			if (i != it && animes[i].m_Active && animes[it].m_Z == animes[i].m_Z)
			{
				if (animes[it].m_Priority < animes[i].m_Priority && animes[it].m_Priority >= 0)
				{
					Kill(it);
					return;
				}
				SetKillSelf(i, true);
				Hold(i);
			}
		}
		animes[it].play();
	}

	public void PlayAll(List<int> list)
	{
		foreach (int item in list)
		{
			if (animes[item].m_Prep)
			{
				m_PrepareList.Add(item);
			}
		}
		StartCoroutine("coPlayAll");
	}

	public void Pause(int _id)
	{
		if (_id >= 0 && _id < 32)
		{
			animes[_id].pause();
		}
	}

	public void Pause()
	{
		for (int i = 0; i < 32; i++)
		{
			Pause(i);
		}
	}

	public void Resume(int _id)
	{
		if (_id >= 0 && _id < 32)
		{
			animes[_id].resume();
		}
	}

	public void Resume()
	{
		for (int i = 0; i < 32; i++)
		{
			Resume(i);
		}
	}

	public void Kill(int _id)
	{
		if (_id >= 0 && _id < 32)
		{
			animes[_id].kill();
		}
	}

	public void Kill_PlayID(int _id)
	{
		for (int i = 0; i < 32; i++)
		{
			if (animes[i].m_AnimeID == _id)
			{
				Kill(i);
			}
		}
	}

	public void KillLayer(int _id1, int _id2)
	{
		if (_id1 < 0 || _id1 >= 32 || _id2 < 0 || _id2 >= 32)
		{
			return;
		}
		float num = 0f;
		float num2 = 0f;
		if (_id1 > _id2)
		{
			num = _id1;
			num2 = _id2;
		}
		else
		{
			num = _id2;
			num2 = _id1;
		}
		for (int i = 0; i < 32; i++)
		{
			if (animes[i].m_Z >= num2 && animes[i].m_Z <= num)
			{
				animes[i].kill();
			}
		}
	}

	public void Kill()
	{
		for (int i = 0; i < 32; i++)
		{
			Kill(i);
		}
	}

	public void SetVisible(int _id, bool _flag)
	{
		if (_id >= 0 && _id < 32)
		{
			animes[_id].setVisible(_flag);
		}
	}

	public void SetVisible(bool _flag)
	{
		for (int i = 0; i < 32; i++)
		{
			SetVisible(i, _flag);
		}
	}

	public void forceSetVisibleOn()
	{
		for (int i = 0; i < 32; i++)
		{
			if (animes[i].m_Visible)
			{
				animes[i].forceSetVisible(true);
			}
		}
	}

	public void forceSetVisibleOff()
	{
		for (int i = 0; i < 32; i++)
		{
			animes[i].forceSetVisible(false);
		}
	}

	public void Hold(int _id)
	{
		if (_id >= 0 && _id < 32)
		{
			animes[_id].stop();
		}
	}

	public void Hold()
	{
		for (int i = 0; i < 32; i++)
		{
			Hold(i);
		}
	}

	public bool isFinalFrame(int _id)
	{
		if (_id < 0 || _id >= 32)
		{
			return false;
		}
		return animes[_id].isFinalFrame();
	}

	public bool isHold(int _id)
	{
		if (_id < 0 || _id >= 32)
		{
			return false;
		}
		return animes[_id].m_Hold;
	}

	public bool isHold()
	{
		for (int i = 0; i < 32; i++)
		{
			if (animes[i].m_Hold)
			{
				return true;
			}
		}
		return false;
	}

	public void DisableHeldAnime()
	{
		for (int i = 0; i < 32; i++)
		{
			animes[i].disableHeldAnime();
		}
	}

	public int GetAnimeID(int _id)
	{
		if (_id < 0 || _id >= 32)
		{
			return -1;
		}
		return animes[_id].m_AnimeID;
	}

	public int GetTotalFrames(int _id)
	{
		if (_id < 0 || _id >= 32)
		{
			return -1;
		}
		return animes[_id].getTotalFrames();
	}

	public float GetX(int _id)
	{
		if (_id < 0 || _id >= 32)
		{
			return 0f;
		}
		return animes[_id].m_X;
	}

	public float GetY(int _id)
	{
		if (_id < 0 || _id >= 32)
		{
			return 0f;
		}
		return animes[_id].m_Y;
	}

	public float GetZ(int _id)
	{
		if (_id < 0 || _id >= 32)
		{
			return 0f;
		}
		return animes[_id].m_Z;
	}

	public int findLayer(float layer)
	{
		for (int i = 0; i < 32; i++)
		{
			if (animes[i].m_Active && !animes[i].m_Kill && !animes[i].m_Killing && layer == animes[i].m_Z)
			{
				return i;
			}
		}
		return -1;
	}

	public int GetCurrentFrame(int _id)
	{
		if (_id < 0 || _id >= 32)
		{
			return 0;
		}
		return animes[_id].getCurrentFrame();
	}

	public bool isDrawNothing()
	{
		for (int i = 0; i < 32; i++)
		{
			if (animes[i].isVisible())
			{
				return false;
			}
		}
		return true;
	}

	public void changePattern(int _id, int _ptn)
	{
		if (_id >= 0 && _id < 32)
		{
			animes[_id].changePattern(_ptn);
		}
	}
}
