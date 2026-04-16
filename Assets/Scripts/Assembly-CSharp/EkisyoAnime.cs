using UnityEngine;

public class EkisyoAnime
{
	private static GameObject Anchor = null;

	private ProdAnimeSprite m_Sprite;

	public int m_AnimeID = -1;

	public int m_PatternID;

	public int m_ProdID;

	public bool m_Active;

	public bool m_Prep;

	public bool m_Play;

	public bool m_Hold;

	public bool m_Kill;

	public bool m_Killing;

	public bool m_Loop;

	public bool m_Trim;

	public bool m_Additive;

	public bool m_KillSelf;

	public float m_X;

	public float m_Y;

	public float m_Z;

	private float m_W = 1f;

	private float m_H = 1f;

	public float m_ScaleX = 1f;

	public float m_ScaleY = 1f;

	public bool m_Visible;

	public bool m_Pause;

	public int m_Priority;

	public int m_TexW;

	public int m_TexH;

	private static ProdAnimeSprite[][] spriteDB = new ProdAnimeSprite[MainResourceAnime.fileList.Length][];

	public static void create()
	{
	}

	public static void initMainGameScene()
	{
		int num = 0;
		for (int i = 0; i < spriteDB.Length; i++)
		{
			spriteDB[i] = new ProdAnimeSprite[MainResourceAnime.instanceNum[i] + 1];
			for (int j = 0; j < spriteDB[i].Length; j++)
			{
				GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("prefabs/" + MainResourceAnime.fileList[i]), Vector3.zero, Quaternion.identity);
				if (Anchor == null)
				{
					Anchor = GameObject.Find("GUIDirection/Camera/Anchor");
				}
				gameObject.transform.parent = Anchor.transform;
				spriteDB[i][j] = gameObject.GetComponent<ProdAnimeSprite>();
				spriteDB[i][j].SetFile(i, num++);
				spriteDB[i][j].gameObject.SetActive(false);
			}
		}
	}

	public void init()
	{
		m_AnimeID = -1;
		setVisible(false);
	}

	public void control()
	{
		if (!m_Active)
		{
			forceSetVisible(false);
		}
		else if (m_Kill)
		{
			m_Kill = false;
			if (!m_Killing)
			{
				m_Killing = true;
				initParam();
			}
		}
		else
		{
			m_Sprite.control();
			if (!m_Prep && m_Play && !m_Hold && !m_Loop && !m_Kill && !m_Killing && m_KillSelf && isPlayEnd())
			{
				stop();
			}
		}
	}

	public void prepare(int kind)
	{
		if (m_Prep)
		{
			return;
		}
		m_Sprite = null;
		for (int i = 1; i < spriteDB[kind].Length; i++)
		{
			if (!spriteDB[kind][i].isActive && !spriteDB[kind][i].isPrep)
			{
				m_Sprite = spriteDB[kind][i];
				break;
			}
		}
		if (m_Sprite != null)
		{
			m_Sprite.initFromOther(spriteDB[kind][0]);
			m_Sprite.gameObject.SetActive(true);
			m_Prep = true;
			m_Sprite.loop = m_Loop;
			m_Sprite.additiveMode = m_Additive;
			m_Active = true;
			m_AnimeID = kind;
			m_Sprite.Prepare();
			m_Sprite.Pause(false);
		}
	}

	public void setKillSelf(bool flag)
	{
		m_KillSelf = flag;
	}

	public void setLoop(bool flag)
	{
		m_Loop = flag;
	}

	public void setTrim(bool flag)
	{
		m_Trim = flag;
	}

	public void setAdditive(bool _additive)
	{
		m_Additive = _additive;
	}

	public void setXY(float _x, float _y)
	{
		m_X = _x;
		m_Y = _y;
	}

	public void setPriority(int priority)
	{
		m_Priority = priority;
	}

	public void setLayer(float _layer)
	{
		m_Z = _layer;
	}

	public void setScale(float _x, float _y)
	{
		m_ScaleX = _x;
		m_ScaleY = _y;
	}

	public void updatePosition()
	{
		if (!(m_Sprite == null))
		{
			m_Sprite.updatePosition(m_X, m_Y, m_Z);
		}
	}

	public void updateScale()
	{
		if (!(m_Sprite == null))
		{
			m_Sprite.updateScale(m_ScaleX, m_ScaleY);
		}
	}

	public bool isPlaying()
	{
		return m_Play;
	}

	public bool isPlayEnd()
	{
		if (m_Sprite == null)
		{
			return false;
		}
		return m_Sprite.isEnd();
	}

	public bool isStop()
	{
		return m_Hold;
	}

	public bool isReady()
	{
		return m_Active && !m_Play;
	}

	public bool isPrep()
	{
		return m_Prep;
	}

	public bool isPaused()
	{
		return m_Pause;
	}

	public void play()
	{
		if (m_Active && !(m_Sprite == null) && !m_Kill && !m_Killing && !m_Hold)
		{
			updateScale();
			updatePosition();
			m_Sprite.Play();
			m_Sprite.Pause(false);
			m_Play = true;
			m_Prep = false;
			setVisible(true);
			forceSetVisible(false);
		}
	}

	public void pause()
	{
		if (m_Active)
		{
			m_Pause = true;
		}
	}

	public void resume()
	{
		if (m_Active && !m_Hold)
		{
			m_Pause = false;
		}
	}

	public void susres_pause()
	{
		if (!(m_Sprite == null) && m_Active)
		{
			m_Sprite.Pause(true);
		}
	}

	public void susres_resume()
	{
		if (!(m_Sprite == null) && !m_Pause && m_Active && !m_Hold)
		{
			m_Sprite.Pause(false);
		}
	}

	public void stop()
	{
		stop(true);
	}

	private void initParam()
	{
		m_Sprite = null;
		m_Active = false;
		m_Prep = false;
		m_Play = false;
		m_Hold = false;
		m_Kill = false;
		m_Killing = false;
		m_AnimeID = -1;
		m_PatternID = 0;
		m_Loop = false;
		m_Trim = false;
		m_Additive = false;
		m_KillSelf = false;
		m_ScaleX = 1f;
		m_ScaleY = 1f;
		m_X = 0f;
		m_Y = 0f;
		m_Z = 0f;
		m_W = 1f;
		m_H = 1f;
		setVisible(false);
		forceSetVisible(false);
	}

	public void kill()
	{
		if (!(m_Sprite == null) && m_Active && !m_Kill && !m_Killing)
		{
			m_Kill = true;
			setVisible(false);
			m_Sprite.Stop();
		}
	}

	public void setVisible(bool _flag)
	{
		if (m_Active)
		{
			m_Visible = _flag;
			updateVisible();
		}
	}

	private void updateVisible()
	{
		if (!(m_Sprite == null) && !(m_Sprite.gameObject == null) && !(m_Sprite.gameObject.GetComponent<Renderer>() == null))
		{
			m_Sprite.gameObject.GetComponent<Renderer>().enabled = m_Visible;
		}
	}

	public void forceSetVisible(bool _flag)
	{
		if (!(m_Sprite == null) && !(m_Sprite.gameObject == null) && !(m_Sprite.gameObject.GetComponent<Renderer>() == null))
		{
			m_Sprite.gameObject.GetComponent<Renderer>().enabled = _flag;
		}
	}

	public bool isVisible()
	{
		if (m_Sprite == null)
		{
			return false;
		}
		if (m_Sprite.gameObject == null)
		{
			return false;
		}
		if (m_Sprite.gameObject.GetComponent<Renderer>() == null)
		{
			return false;
		}
		return m_Sprite.gameObject.GetComponent<Renderer>().enabled;
	}

	public void stop(bool isHold)
	{
		if (m_Active && !m_Killing && !m_Kill)
		{
			m_Play = false;
			m_Prep = false;
			if (isHold)
			{
				hold();
			}
			else if (m_KillSelf)
			{
				kill();
			}
			else if (!m_Hold)
			{
				hold();
			}
		}
	}

	public void disableHeldAnime()
	{
		if (m_Hold && !m_Kill && !m_Killing)
		{
			m_KillSelf = true;
			stop(false);
		}
	}

	private void hold()
	{
		m_Hold = true;
		pause();
	}

	private void OnMouseDown()
	{
	}

	public void terminate()
	{
		stop(false);
	}

	public static void dispose()
	{
		for (int i = 0; i < spriteDB.Length; i++)
		{
			if (spriteDB[i] == null)
			{
				continue;
			}
			for (int j = 0; j < spriteDB[i].Length; j++)
			{
				if (spriteDB[i][j] != null)
				{
					Object.Destroy(spriteDB[i][j].gameObject);
				}
				spriteDB[i][j] = null;
			}
			spriteDB[i] = null;
		}
	}

	public int getCurrentFrame()
	{
		if (m_Sprite == null)
		{
			return -1;
		}
		return m_Sprite.getCurrentFrame();
	}

	public int getTotalFrames()
	{
		if (m_Sprite == null)
		{
			return -1;
		}
		if (!m_Active)
		{
			return -1;
		}
		if (!isPlaying())
		{
			return -1;
		}
		return m_Sprite.totalFrame;
	}

	public bool isFinalFrame()
	{
		if (!m_Active)
		{
			return false;
		}
		if (m_Prep)
		{
			return false;
		}
		if (m_Hold)
		{
			return true;
		}
		if (getCurrentFrame() >= getTotalFrames() - 1)
		{
			return true;
		}
		return false;
	}

	public void changePattern(int _ptn)
	{
		if (!(m_Sprite == null))
		{
			m_PatternID = _ptn;
			m_Sprite.changePattern(m_AnimeID, m_PatternID);
		}
	}

	public bool IsActive()
	{
		if (m_Sprite == null)
		{
			return false;
		}
		return m_Sprite.gameObject.activeSelf;
	}
}
