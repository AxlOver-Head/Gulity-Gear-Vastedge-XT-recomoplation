using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Production : MonoBehaviour
{
	public const int MOVIE_MAX = 40;
	public const int MOVIE_TEX_BEGIN = 99999;

	private EkisyoCRI[] movies = new EkisyoCRI[40];

	public static List<int> m_PrepareList = new List<int>
	{
		Capacity = 40
	};

	public static List<int> m_DeleteList = new List<int>
	{
		Capacity = 40
	};

	public EkisyoCRI[] getMovies()
	{
		return movies;
	}

	private void Start()
	{
	}

	public void Dispose(bool _flag)
	{
		if (movies != null)
		{
			for (int i = 0; i < 40; i++)
			{
				if (!(movies[i] == null))
				{
					movies[i].terminate();
					if (_flag)
					{
						UnityEngine.Object.Destroy(movies[i].gameObject);
						movies[i] = null;
					}
				}
			}
		}
		EkisyoCRI.dispose();
	}

	public void init()
	{
		EkisyoCRI.create();
		ClearMovie();
		m_PrepareList.Clear();
	}

	private void Update()
	{
	}

	public int find(int _id)
	{
		for (int i = 0; i < 40; i++)
		{
			if (movies[i].m_Active && !movies[i].m_Kill && !movies[i].m_Killing && movies[i].m_MovieID == _id)
			{
				return i;
			}
		}
		return -1;
	}

	public void ClearMovie()
	{
		for (int i = 0; i < 40; i++)
		{
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("prefabs/EkisyoCRI"), Vector3.zero, Quaternion.identity);
			EkisyoCRI ekisyoCRI = (EkisyoCRI)gameObject.GetComponent("EkisyoCRI");
			ekisyoCRI.init();
			movies[i] = ekisyoCRI;
			movies[i].m_ProdID = i;
			ProdSGLG.makeUnloadTextureMovie(i, movies[i]);
		}
	}

	private int searchMakeProd(int _start, int _end)
	{
		int result = -1;
		if (_end > 40)
		{
			_end = 40;
		}
		for (int i = _start; i < _end; i++)
		{
			if (!movies[i].m_Active && !movies[i].m_Prep && !movies[i].m_Play && !movies[i].m_Hold && !movies[i].m_Kill && !movies[i].m_Killing)
			{
				result = i;
				break;
			}
		}
		return result;
	}

	public int MakeMovie(int _playID, float _layer, bool _killSelf, bool _loop, bool _add, bool _trim, float _x, float _y, int priority)
	{
		int num = -1;
		int makeMovieProd = ProdSGLG.getMakeMovieProd(_playID);
		int end = makeMovieProd + 2;
		if (makeMovieProd == 0)
		{
			end = 40;
		}
		num = searchMakeProd(makeMovieProd, end);
		if (makeMovieProd > 0 && num < 0)
		{
			num = searchMakeProd(0, 99999);
		}
		if (num < 0)
		{
			return -1;
		}
		for (int i = 0; i < 40; i++)
		{
			if (movies[i].m_Active && _layer == movies[i].m_Z && movies[i].m_Priority > priority && priority >= 0)
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
		SetPriority(num, priority);
		movies[num].prepare(_playID);
		return num;
	}

	public void SetAdditive(int _id, bool _additive)
	{
		if (_id >= 0 && _id < 40)
		{
			movies[_id].setAdditive(_additive);
		}
	}

	public void SetKillSelf(int _id, bool _killSelf)
	{
		if (_id >= 0 && _id < 40)
		{
			movies[_id].setKillSelf(_killSelf);
		}
	}

	public void SetKillSelf(bool _killSelf)
	{
		for (int i = 0; i < 40; i++)
		{
			SetKillSelf(i, _killSelf);
		}
	}

	public void SetLoop(int _id, bool _loop)
	{
		if (_id >= 0 && _id < 40)
		{
			movies[_id].setLoop(_loop);
		}
	}

	public void SetTrim(int _id, bool _trim)
	{
		if (_id >= 0 && _id < 40)
		{
			movies[_id].setTrim(_trim);
		}
	}

	public void SetXY(int _id, float _x, float _y)
	{
		if (_id >= 0 && _id < 40)
		{
			movies[_id].setXY(_x, _y);
			movies[_id].updatePosition();
		}
	}

	public void SetPriority(int _id, int priority)
	{
		if (_id >= 0 && _id < 40)
		{
			movies[_id].setPriority(priority);
		}
	}

	public void SetScale(int _id, float _x, float _y)
	{
		if (_id >= 0 && _id < 40)
		{
			movies[_id].setScale(_x, _y);
			movies[_id].updateScale();
			movies[_id].updatePosition();
		}
	}

	public void SetLayer(int _id, float _layer)
	{
		if (_id >= 0 && _id < 40)
		{
			movies[_id].setLayer(_layer);
		}
	}

	public void AddMovie(int _id, int _playID)
	{
		if (_id >= 0 && _id < 40)
		{
			movies[_id].addMovie(_playID);
		}
	}

	public void SetVolume(int _id, float vol)
	{
		if (_id >= 0 && _id < 40)
		{
			movies[_id].setVolume(vol);
		}
	}

	public bool IsPlaying(int _id)
	{
		if (_id < 0 || _id >= 40)
		{
			return false;
		}
		return movies[_id].isPlaying();
	}

	public bool IsPlayEnd(int _id)
	{
		if (_id < 0 || _id >= 40)
		{
			return false;
		}
		return movies[_id].isPlayEnd();
	}

	public bool IsStop(int _id)
	{
		if (_id < 0 || _id >= 40)
		{
			return false;
		}
		return movies[_id].isStop();
	}

	public bool IsKill(int _id)
	{
		if (_id < 0 || _id >= 40)
		{
			return false;
		}
		return movies[_id].m_Kill;
	}

	public bool IsKilling(int _id)
	{
		if (_id < 0 || _id >= 40)
		{
			return false;
		}
		return movies[_id].m_Killing;
	}

	public bool IsReady(int _id)
	{
		if (_id < 0 || _id >= 40)
		{
			return false;
		}
		return movies[_id].isReady();
	}

	public bool IsDechead(int _id)
	{
		if (_id < 0 || _id >= 40)
		{
			return false;
		}
		return movies[_id].isDechead();
	}

	public bool IsWaitPrep(int _id)
	{
		if (_id < 0 || _id >= 40)
		{
			return false;
		}
		return movies[_id].isWaitPrep();
	}

	public bool IsPrep(int _id)
	{
		if (_id < 0 || _id >= 40)
		{
			return false;
		}
		return movies[_id].isPrep();
	}

	public bool IsPaused(int _id)
	{
		if (_id < 0 || _id >= 40)
		{
			return false;
		}
		return movies[_id].isPaused();
	}

	public bool isReadyStaying()
	{
		for (int i = 0; i < 40; i++)
		{
			if (movies[i].m_Active && IsReady(i))
			{
				return true;
			}
		}
		return false;
	}

	public void playReadyStay()
	{
		for (int i = 0; i < 40; i++)
		{
			if (movies[i].m_Active && IsReady(i))
			{
				play(i);
			}
		}
	}

	public bool checkPreparing()
	{
		for (int i = 0; i < 40; i++)
		{
			if (!movies[i].m_Active)
			{
				movies[i].renderNullCnt = 0;
				continue;
			}
			if (IsDechead(i))
			{
				movies[i].renderNullCnt = 0;
				return true;
			}
			if (IsWaitPrep(i))
			{
				movies[i].renderNullCnt = 0;
				return true;
			}
			if (IsPrep(i))
			{
				movies[i].renderNullCnt = 0;
				return true;
			}
			if (isHold(i))
			{
				movies[i].renderNullCnt = 0;
				return true;
			}
			if (IsStop(i))
			{
				movies[i].renderNullCnt = 0;
				return true;
			}
			
			// VideoPlayer handles texture creation internally
			// This check is no longer needed with Unity's VideoPlayer
			if (movies[i].m_Active)
			{
				// Simply check if the video is ready
				if (!movies[i].isReady())
				{
					movies[i].renderNullCnt = 0;
					return true;
				}
			}
			else
			{
				movies[i].renderNullCnt = 0;
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
				if (!movies[m_PrepareList[i]].m_Active || !movies[m_PrepareList[i]].m_Prep)
				{
					if (movies[m_PrepareList[i]].m_Prep)
					{
						Kill(m_PrepareList[i]);
					}
					m_DeleteList.Add(i);
				}
				else if (!movies[m_PrepareList[i]].isReady())
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
		for (int i = 0; i < 40; i++)
		{
			if (i != it && movies[i].m_Active && movies[it].m_Z == movies[i].m_Z)
			{
				if (movies[it].m_Priority < movies[i].m_Priority && movies[it].m_Priority >= 0)
				{
					Kill(it);
					return;
				}
				SetKillSelf(i, true);
				Hold(i);
			}
		}
		movies[it].play();
	}

	public void PlayAll(List<int> list)
	{
		foreach (int item in list)
		{
			if (movies[item].m_Prep)
			{
				m_PrepareList.Add(item);
			}
		}
		StartCoroutine("coPlayAll");
	}

	public void SusRes_Pause()
	{
		for (int i = 0; i < 40; i++)
		{
			movies[i].susres_pause();
		}
	}

	public void SusRes_Resume()
	{
		for (int i = 0; i < 40; i++)
		{
			movies[i].susres_resume();
		}
	}

	public void Pause(int _id)
	{
		if (_id >= 0 && _id < 40)
		{
			movies[_id].pause();
		}
	}

	public void Pause()
	{
		for (int i = 0; i < 40; i++)
		{
			Pause(i);
		}
	}

	public void Resume(int _id)
	{
		if (_id >= 0 && _id < 40)
		{
			movies[_id].resume();
		}
	}

	public void Resume()
	{
		for (int i = 0; i < 40; i++)
		{
			Resume(i);
		}
	}

	public void Kill(int _id)
	{
		if (_id >= 0 && _id < 40)
		{
			movies[_id].kill();
		}
	}

	public void Kill_PlayID(int _id)
	{
		for (int i = 0; i < 40; i++)
		{
			if (movies[i].m_MovieID == _id)
			{
				Kill(i);
			}
		}
	}

	public void KillLayer(int _id1, int _id2)
	{
		if (_id1 < 0 || _id1 >= 40 || _id2 < 0 || _id2 >= 40)
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
		for (int i = 0; i < 40; i++)
		{
			if (movies[i].m_Z >= num2 && movies[i].m_Z <= num)
			{
				movies[i].kill();
			}
		}
	}

	public void Kill()
	{
		for (int i = 0; i < 40; i++)
		{
			Kill(i);
		}
	}

	public void SetVisible(int _id, bool _flag)
	{
		if (_id >= 0 && _id < 40)
		{
			movies[_id].setVisible(_flag);
		}
	}

	public void SetVisible(bool _flag)
	{
		for (int i = 0; i < 40; i++)
		{
			SetVisible(i, _flag);
		}
	}

	public void forceSetVisibleOn()
	{
		for (int i = 0; i < 40; i++)
		{
			if (movies[i].m_Visible)
			{
				movies[i].forceSetVisible(true);
			}
		}
	}

	public void forceSetVisibleOff()
	{
		for (int i = 0; i < 40; i++)
		{
			movies[i].forceSetVisible(false);
		}
	}

	public void Hold(int _id)
	{
		if (_id >= 0 && _id < 40)
		{
			movies[_id].stop();
		}
	}

	public void Hold()
	{
		for (int i = 0; i < 40; i++)
		{
			Hold(i);
		}
	}

	public bool isBindOK()
	{
		return EkisyoCRI.isBindOK();
	}

	public bool isFinalFrame(int _id)
	{
		if (_id < 0 || _id >= 40)
		{
			return false;
		}
		return movies[_id].isFinalFrame();
	}

	public bool isHold(int _id)
	{
		if (_id < 0 || _id >= 40)
		{
			return false;
		}
		return movies[_id].m_Hold;
	}

	public bool isHold()
	{
		for (int i = 0; i < 40; i++)
		{
			if (movies[i].m_Hold)
			{
				return true;
			}
		}
		return false;
	}

	public void DisableHeldMovie()
	{
		for (int i = 0; i < 40; i++)
		{
			movies[i].disableHeldMovie();
		}
	}

	public int GetMovieID(int _id)
	{
		if (_id < 0 || _id >= 40)
		{
			return -1;
		}
		return movies[_id].m_MovieID;
	}

	public int GetTotalFrames(int _id)
	{
		if (_id < 0 || _id >= 40)
		{
			return -1;
		}
		return movies[_id].getTotalFrames();
	}

	public float GetX(int _id)
	{
		if (_id < 0 || _id >= 40)
		{
			return 0f;
		}
		return movies[_id].m_X;
	}

	public float GetY(int _id)
	{
		if (_id < 0 || _id >= 40)
		{
			return 0f;
		}
		return movies[_id].m_Y;
	}

	public float GetZ(int _id)
	{
		if (_id < 0 || _id >= 40)
		{
			return 0f;
		}
		return movies[_id].m_Z;
	}

	public int findLayer(float layer)
	{
		for (int i = 0; i < 40; i++)
		{
			if (movies[i].m_Active && !movies[i].m_Kill && !movies[i].m_Killing && layer == movies[i].m_Z)
			{
				return i;
			}
		}
		return -1;
	}

	public int GetCurrentFrame(int _id)
	{
		if (_id < 0 || _id >= 40)
		{
			return 0;
		}
		return movies[_id].getCurrentFrame();
	}

	public bool isDrawNothing()
	{
		for (int i = 0; i < 40; i++)
		{
			if (movies[i].GetComponent<Renderer>().enabled)
			{
				return false;
			}
		}
		return true;
	}

	public bool check_87YFC()
	{
		return false;
	}
}