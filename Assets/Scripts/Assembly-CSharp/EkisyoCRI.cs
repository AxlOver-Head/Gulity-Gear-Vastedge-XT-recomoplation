using System.Collections;
using UnityEngine;
using UnityEngine.Video;

public class EkisyoCRI : MonoBehaviour
{
	private const int MOVIE_W = 256;
	private const int MOVIE_H = 144;
	private const float BASE_SCALE_X = 1.5f;
	private const float BASE_SCALE_Y = 2.675f;
	private const float BASE_X = 0f;
	private const float BASE_Y = 0f;

	private static CriFsBinder binder;
	private static uint bindId;

	private VideoPlayer videoPlayer;
	private AudioSource audioSource;

	public int m_MovieID = -1;
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

	public int renderNullCnt;

	// Custom status enum to match old CriManaPlayer.Status
	public enum VideoStatus
	{
		Stop,
		Ready,
		Prep,
		WaitPrep,
		Dechead,
		Playing,
		PlayEnd,
		Error
	}

	public VideoPlayer getPlayer()
	{
		return videoPlayer;
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	public static void create()
	{
		if (binder == null)
		{
			binder = new CriFsBinder();
			setBind();
		}
	}

	private static void setBind()
	{
		bindId = 0;
	}

	public static bool isBindOK()
	{
		return true;
	}

	private void Awake()
{
	Object.DontDestroyOnLoad(base.gameObject);
}

public void init()
{
	m_MovieID = -1;
	if (videoPlayer == null)
	{
		videoPlayer = base.gameObject.AddComponent<VideoPlayer>();
		videoPlayer.playOnAwake = false;
		videoPlayer.waitForFirstFrame = true;
		videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
		
		// Add AudioSource for video audio
		audioSource = base.gameObject.AddComponent<AudioSource>();
		
		// Set the audio source for the VideoPlayer
		videoPlayer.SetTargetAudioSource(0, audioSource);
	}
	setVisible(false);
}

	private void Update()
	{
		if (!isBindOK())
		{
			return;
		}
		if (m_Play)
		{
		}
		if (!m_Active || m_Prep || m_Play || m_Hold || m_Kill || !m_Killing)
		{
		}
		if (m_Kill)
		{
			m_Kill = false;
			if (m_Killing)
			{
				return;
			}
			m_Killing = true;
			StartCoroutine("coKill");
		}
		if (m_Active && !m_Prep && m_Play && !m_Hold && !m_Loop && !m_Kill && !m_Killing && m_KillSelf && isPlayEnd())
		{
			stop();
		}
	}

	public void addMovie(int kind)
	{
		if (isManaPlayerOK() && m_Active)
		{
			m_MovieID = kind;
			bool flag = false;
			if (SetVideoFile(MainResourceMovie.fileList[kind] + ".mp4"))
			{
				// Video file set successfully
			}
		}
	}

	private bool SetVideoFile(string filename)
	{
		if (videoPlayer == null)
			return false;

		string fullPath = SGLG.getStreamingPath() + "/" + filename;
		videoPlayer.url = fullPath;
		return true;
	}

	private IEnumerator coPrepare()
	{
		bool flag = true;
		do
		{
			if (!flag)
			{
				yield return null;
			}
			flag = true;
			if (!isStop())
			{
				flag = false;
			}
		}
		while (!flag);

		SetVideoFile(MainResourceMovie.fileList[m_MovieID] + ".mp4");
		Prepare();
	}

	public void prepare(int kind)
	{
		m_Prep = true;
		videoPlayer.isLooping = m_Loop;
		m_Active = true;
		m_MovieID = kind;
		SetVideoFile(MainResourceMovie.fileList[m_MovieID] + ".mp4");
		Prepare();
	}

	private void Prepare()
	{
		if (videoPlayer != null)
		{
			videoPlayer.Prepare();
		}
	}

	private bool isManaPlayerOK()
	{
		if (videoPlayer == null)
		{
			return false;
		}
		return true;
	}

	public void setKillSelf(bool flag)
	{
		m_KillSelf = flag;
	}

	public void setLoop(bool flag)
	{
		m_Loop = flag;
		if (videoPlayer != null)
			videoPlayer.isLooping = flag;
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
		float num = 0.7525f;
		float num2 = m_W * 1.5f;
		float num3 = m_H * 2.675f;
		float num4 = 0f - num + m_X / 256f * 1.5f;
		float num5 = 0f - num + m_Y / 256f * 2.675f;
		if (!m_Trim)
		{
			num4 += num + (num2 * m_ScaleX - num2) / 2f;
			num5 += num + (num3 * m_ScaleY - num3) / 2f;
		}
		num5 = 0f - num5;
		base.gameObject.transform.position = new Vector3(num4, num5, m_Z);
	}

	public void updateScale()
	{
		m_W = 1f * (float)MainResourceMovie.sizeList[m_MovieID, 0] / 256f;
		m_H = 0.5625f * (float)MainResourceMovie.sizeList[m_MovieID, 1] / 144f;
		base.gameObject.transform.localScale = new Vector3(m_W * m_ScaleX * 1.5f, m_H * m_ScaleY * 2.675f, 0f);
	}

	public void setVolume(float volume)
	{
		if (isManaPlayerOK() && m_Active && audioSource != null)
		{
			audioSource.volume = volume;
		}
	}

	public VideoStatus getStatus()
	{
		if (videoPlayer == null)
			return VideoStatus.Stop;

		if (videoPlayer.isPlaying)
			return VideoStatus.Playing;

		if (!videoPlayer.isPrepared)
			return VideoStatus.Ready;

		return VideoStatus.Stop;
	}

	public bool isPlaying()
	{
		if (!isManaPlayerOK())
		{
			return false;
		}
		return videoPlayer.isPlaying;
	}

	public bool isPlayEnd()
	{
		if (!isManaPlayerOK())
		{
			return false;
		}
		return !videoPlayer.isPlaying && videoPlayer.isPrepared && videoPlayer.frame >= (long)videoPlayer.frameCount - 1;
	}

	public bool isError()
	{
		// VideoPlayer doesn't have explicit error checking like CriManaPlayer
		// You could add error handling via callbacks if needed
		return false;
	}

	public bool isStop()
	{
		if (!isManaPlayerOK())
		{
			return false;
		}
		return !videoPlayer.isPlaying;
	}

	public bool isReady()
	{
		if (!isManaPlayerOK())
		{
			return false;
		}
		return videoPlayer.isPrepared;
	}

	public bool isDechead()
	{
		if (!isManaPlayerOK())
		{
			return false;
		}
		return videoPlayer.isPrepared;
	}

	public bool isWaitPrep()
	{
		if (!isManaPlayerOK())
		{
			return false;
		}
		return !videoPlayer.isPrepared;
	}

	public bool isPrep()
	{
		if (!isManaPlayerOK())
		{
			return false;
		}
		return videoPlayer.isPrepared;
	}

	public bool isPaused()
	{
		if (!isManaPlayerOK())
		{
			return false;
		}
		return m_Pause && videoPlayer.isPrepared;
	}

	public void play()
	{
		if (isManaPlayerOK() && m_Active && !m_Kill && !m_Killing && !m_Hold)
		{
			updateScale();
			updatePosition();
			videoPlayer.Play();
			if (m_Pause)
			{
				Pause();
			}
			m_Play = true;
			m_Prep = false;
			setVisible(true);
			forceSetVisible(false);
		}
	}

	public void pause()
	{
		if (isManaPlayerOK() && m_Active)
		{
			m_Pause = true;
			videoPlayer.Pause();
		}
	}

	public void resume()
	{
		if (isManaPlayerOK() && m_Active && !m_Hold)
		{
			m_Pause = false;
			videoPlayer.Play();
		}
	}

	public void susres_pause()
	{
		if (isManaPlayerOK() && m_Active)
		{
			videoPlayer.Pause();
		}
	}

	public void susres_resume()
	{
		if (!m_Pause && isManaPlayerOK() && m_Active && !m_Hold)
		{
			videoPlayer.Play();
		}
	}

	public void stop()
	{
		stop(true);
	}

	private void initParam()
	{
		m_Active = false;
		m_Prep = false;
		m_Play = false;
		m_Hold = false;
		m_Kill = false;
		m_Killing = false;
		m_MovieID = -1;
		m_Loop = false;
		m_Trim = false;
		m_Additive = false;
		m_KillSelf = false;
		m_Pause = false;
		m_ScaleX = 1f;
		m_ScaleY = 1f;
		m_X = 0f;
		m_Y = 0f;
		m_Z = 0f;
		m_W = 1f;
		m_H = 1f;
		setVisible(false);
		forceSetVisible(false);
		renderNullCnt = 0;
	}

	private IEnumerator coKill()
	{
		bool flag = true;
		do
		{
			if (!flag)
			{
				yield return null;
			}
			flag = true;
			if (!isStop())
			{
				flag = false;
				if (isError())
				{
					flag = true;
				}
			}
		}
		while (!flag);
		initParam();
	}

	public void kill()
	{
		if (m_Active && !m_Kill && !m_Killing)
		{
			m_Kill = true;
			setVisible(false);
			videoPlayer.Stop();
			videoPlayer.url = string.Empty;
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
		base.GetComponent<Renderer>().enabled = m_Visible;
	}

	public void forceSetVisible(bool _flag)
	{
		base.GetComponent<Renderer>().enabled = _flag;
	}

	public void stop(bool isHold)
	{
		if (isManaPlayerOK() && m_Active && !m_Killing && !m_Kill)
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

	public void disableHeldMovie()
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
		binder = null;
	}
	public int getCurrentFrame()
	{
		if (videoPlayer == null)
			return -1;
		return (int)videoPlayer.frame;
	}

	public int getTotalFrames()
	{
		if (!isManaPlayerOK())
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
		return (int)videoPlayer.frameCount;
	}

	public bool isFinalFrame()
	{
		if (!isManaPlayerOK())
		{
			return false;
		}
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

	public void createTexture(int w, int h)
	{
		m_TexW = w;
		m_TexH = h;
		// VideoPlayer handles texture creation internally
		// No action needed here
	}

	private void Pause()
	{
		if (videoPlayer != null)
		{
			videoPlayer.Pause();
		}
	}
}
