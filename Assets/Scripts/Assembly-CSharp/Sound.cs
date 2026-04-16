using UnityEngine;

public class Sound : MonoBehaviour
{
	public enum CH
	{
		BGM = 0,
		SE0 = 1,
		SE1 = 2,
		VC0 = 3,
		VC1 = 4,
		VC2 = 5,
		OTHER = 6,
		MAX = 7
	}

	private static readonly int CH_NUM = 4;

	public static readonly int SOUND_MAX = 7 * CH_NUM;

	private SoundCRI[] sounds = new SoundCRI[SOUND_MAX];

	private int[] current = new int[7];

	public SoundCRI[] getSounds()
	{
		return sounds;
	}

	public void SetMasterVolume(float _vol)
	{
		float num = _vol;
		if (num > 1f)
		{
			num = 1f;
		}
		if (num < 0f)
		{
			num = 0f;
		}
		SoundCRI.masterVolume = num;
		for (int i = 0; i < 7; i++)
		{
			for (int j = 0; j < CH_NUM; j++)
			{
				sounds[i * CH_NUM + j].updateVolume();
			}
		}
	}

	private void Start()
	{
	}

	public void init()
	{
		for (int i = 0; i < current.Length; i++)
		{
			current[i] = 0;
		}
		SoundCRI.create();
		ClearSound();
	}

	public void init2()
	{
		SoundCRI.create2();
	}

	public void Dispose(bool _flag)
	{
		if (sounds != null)
		{
			for (int i = 0; i < SOUND_MAX; i++)
			{
				if (!(sounds[i] == null))
				{
					sounds[i].terminate();
					if (_flag)
					{
						Object.Destroy(sounds[i].gameObject);
						sounds[i] = null;
					}
				}
			}
		}
		SoundCRI.UnregisterAcf();
	}

	private void Update()
	{
	}

	public void ClearSound()
	{
		for (int i = 0; i < SOUND_MAX; i++)
		{
			GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("prefabs/SoundCRI"), Vector3.zero, Quaternion.identity);
			SoundCRI soundCRI = (SoundCRI)gameObject.GetComponent("SoundCRI");
			soundCRI.init();
			sounds[i] = soundCRI;
		}
	}

	public void PlaySound(int _playID, CH _ch, bool _stop)
	{
		if (_stop)
		{
			Stop(_ch);
		}
		sounds[(int)_ch * CH_NUM + current[(int)_ch]].play(_playID, _stop);
		if (_ch != CH.BGM)
		{
			current[(int)_ch]++;
			current[(int)_ch] %= CH_NUM;
		}
		MainGameScene.dirLedMan.setSndLed((DirectionManager.SOUND)_playID);
	}

	public int getBGMID()
	{
		return sounds[0 * CH_NUM].m_PlayID;
	}

	public float getBGMVolume()
	{
		return sounds[0 * CH_NUM].m_Volume;
	}

	public void SetVolume(CH _ch, float vol)
	{
		if (_ch >= CH.BGM && _ch < CH.MAX)
		{
			for (int i = 0; i < CH_NUM; i++)
			{
				sounds[(int)_ch * CH_NUM + i].setVolume(vol);
			}
		}
	}

	public bool IsPlaying(CH _ch, int num)
	{
		if (_ch < CH.BGM || _ch >= CH.MAX)
		{
			return false;
		}
		if (num < 0 || num >= CH_NUM)
		{
			return false;
		}
		return sounds[(int)_ch * CH_NUM + num].isPlaying();
	}

	public bool IsPlayEnd(CH _ch, int num)
	{
		if (_ch < CH.BGM || _ch >= CH.MAX)
		{
			return false;
		}
		if (num < 0 || num >= CH_NUM)
		{
			return false;
		}
		return sounds[(int)_ch * CH_NUM + num].isPlayEnd();
	}

	public bool IsStop(CH _ch, int num)
	{
		if (_ch < CH.BGM || _ch >= CH.MAX)
		{
			return false;
		}
		if (num < 0 || num >= CH_NUM)
		{
			return false;
		}
		return sounds[(int)_ch * CH_NUM + num].isStop();
	}

	public void SusRes_Pause()
	{
		for (int i = 0; i < 7; i++)
		{
			for (int j = 0; j < CH_NUM; j++)
			{
				sounds[i * CH_NUM + j].susres_pause();
			}
		}
	}

	public void SusRes_Resume()
	{
		for (int i = 0; i < 7; i++)
		{
			for (int j = 0; j < CH_NUM; j++)
			{
				sounds[i * CH_NUM + j].susres_resume();
			}
		}
	}

	public void Pause(CH _ch)
	{
		if (_ch >= CH.BGM && _ch < CH.MAX)
		{
			for (int i = 0; i < CH_NUM; i++)
			{
				sounds[(int)_ch * CH_NUM + i].pause();
			}
		}
	}

	public void Pause()
	{
		for (int i = 0; i < 7; i++)
		{
			Pause((CH)i);
		}
	}

	public void Resume(CH _ch)
	{
		if (_ch >= CH.BGM && _ch < CH.MAX)
		{
			for (int i = 0; i < CH_NUM; i++)
			{
				sounds[(int)_ch * CH_NUM + i].resume();
			}
		}
	}

	public void Resume()
	{
		for (int i = 0; i < 7; i++)
		{
			Resume((CH)i);
		}
	}

	public void Stop(CH _ch)
	{
		if (_ch >= CH.BGM && _ch < CH.MAX)
		{
			for (int i = 0; i < CH_NUM; i++)
			{
				sounds[(int)_ch * CH_NUM + i].stop();
			}
		}
	}

	public void Stop()
	{
		for (int i = 0; i < 7; i++)
		{
			Stop((CH)i);
		}
	}

	public bool isBindOK()
	{
		return SoundCRI.isBindOK();
	}
}
