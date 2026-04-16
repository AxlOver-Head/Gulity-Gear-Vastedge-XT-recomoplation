using UnityEngine;

public class GGLSound : MonoBehaviour
{
	public static string[] SoundName = new string[65]
	{
		"00", "01", "02", "03", "04", "07", "08", "09", "10", "0231",
		"0232", "0233", "0234", "0235", "0236", "0237", "0238", "0239", "0240", "0241",
		"0242", "0243", "0244", "0245", "0246", "0247", "0248", "0249", "0250", "0251",
		"0252", "0253", "0254", "0255", "0256", "0257", "0258", "0259", "0260", "0261",
		"0262", "0263", "0264", "0265", "0266", "0267", "0268", "0269", "0270", "0271",
		"0272", "0274", "0275", "0276", "0277", "0278", "0279", "0280", "0281", "0282",
		"0283", "0284", "0285", "0286", "0244_2"
	};

	private GameObject sGoRoot;

	public GameObject[] sGo = new GameObject[16];

	public AudioSource[] aSrc = new AudioSource[16];

	public int[] PlayingIndex = new int[16];

	private AudioClip[] audioClipArray = new AudioClip[SoundName.Length];

	private int LDCount;

	private int LDMax = SoundName.Length;

	private float[] fTimer = new float[16];

	private float[] fVol = new float[16];

	private bool[] bTimer = new bool[16];

	private float m_masterVolume = 1f;

	public AssetBundle bundle;

	public string AUDIO_OBJ = "SOUNDS";

	public void loadSoundFiles()
	{
		for (int i = 0; i < audioClipArray.Length; i++)
		{
			if (bundle != null)
			{
				audioClipArray[i] = bundle.LoadAsset<AudioClip>(SoundName[i]);
			}
			else
			{
				audioClipArray[i] = (AudioClip)Resources.Load("sound/" + SoundName[i]);
			}
			if (audioClipArray[i] == null)
			{
			}
			LDCount = i;
		}
	}

	public bool isLoadComplete()
	{
		return LDCount >= LDMax - 1;
	}

	public void BundleUnload()
	{
		if (bundle != null)
		{
			bundle.Unload(false);
			bundle = null;
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
		sGoRoot = new GameObject();
		sGoRoot.name = AUDIO_OBJ + "_ROOT";
		sGoRoot.transform.localPosition = Vector3.zero;
		for (int i = 0; i < 16; i++)
		{
			sGo[i] = new GameObject(AUDIO_OBJ);
			sGo[i].transform.position = new Vector3(0f, 0f, 0f);
			sGo[i].transform.parent = sGoRoot.transform;
			aSrc[i] = sGo[i].AddComponent<AudioSource>();
			aSrc[i].spatialBlend = 0f;
			aSrc[i].panStereo = 0f;
			aSrc[i].dopplerLevel = 0f;
			aSrc[i].spread = 0f;
			aSrc[i].ignoreListenerVolume = true;
			aSrc[i].velocityUpdateMode = AudioVelocityUpdateMode.Fixed;
			aSrc[i].volume = m_masterVolume;
			fTimer[i] = 0f;
			bTimer[i] = false;
			fVol[i] = 1f;
			PlayingIndex[i] = -1;
		}
	}

	private void Update()
	{
	}

	public void Release()
	{
	}

	public void setVolumeTimer(int Ch, float vol, float time)
	{
		if (!bTimer[Ch])
		{
			fVol[Ch] = vol;
			fTimer[Ch] = time;
			bTimer[Ch] = true;
		}
	}

	public bool isPlayingSound(int Ch, int snd_id)
	{
		return checkPlaying(Ch, snd_id);
	}

	public void setData(int Ch, int snd_id)
	{
		aSrc[Ch].Stop();
		if (null != audioClipArray[snd_id])
		{
			aSrc[Ch].clip = audioClipArray[snd_id];
		}
		else
		{
			if (bundle != null)
			{
				audioClipArray[snd_id] = bundle.LoadAsset<AudioClip>(SoundName[snd_id]);
			}
			else
			{
				audioClipArray[snd_id] = (AudioClip)Resources.Load("sound/" + SoundName[snd_id]);
			}
			aSrc[Ch].clip = audioClipArray[snd_id];
		}
		PlayingIndex[Ch] = snd_id;
	}

	public void setVolume(int Ch, float vol)
	{
		aSrc[Ch].volume = vol;
	}

	public void setVolumeAll(float vol)
	{
		AudioSource[] array = aSrc;
		foreach (AudioSource audioSource in array)
		{
			audioSource.volume = vol;
		}
	}

	public float getVolume(int ch)
	{
		return aSrc[ch].volume;
	}

	public void setLoop(int Ch, bool Loop)
	{
		aSrc[Ch].loop = Loop;
	}

	public void setMute(int Ch, bool Mute)
	{
		aSrc[Ch].mute = Mute;
	}

	public void setMuteAll(bool Mute)
	{
		AudioSource[] array = aSrc;
		foreach (AudioSource audioSource in array)
		{
			audioSource.mute = Mute;
		}
	}

	public bool checkPlaying(int Ch)
	{
		return aSrc[Ch].isPlaying;
	}

	public bool checkPlaying(int Ch, int snd_id)
	{
		if (aSrc[Ch] != null && aSrc[Ch].isPlaying && (snd_id == -1 || aSrc[Ch].clip.name == SoundName[snd_id]))
		{
			return true;
		}
		return false;
	}

	public void play(int Ch)
	{
		if (aSrc[Ch].clip != null)
		{
			aSrc[Ch].volume = m_masterVolume;
			aSrc[Ch].Play();
		}
	}

	public void pause(int Ch)
	{
		aSrc[Ch].Pause();
	}

	public void all_pause()
	{
		for (int i = 0; i < 16; i++)
		{
			if (aSrc[i] != null)
			{
				aSrc[i].Pause();
			}
		}
	}

	public void all_restart()
	{
		for (int i = 0; i < 16; i++)
		{
			if (aSrc[i] != null && aSrc[i].time != 0f)
			{
				aSrc[i].Play();
			}
		}
	}

	public void stop(int Ch)
	{
		aSrc[Ch].Stop();
		PlayingIndex[Ch] = -1;
	}

	public void stop(int Ch, int snd_index)
	{
		aSrc[Ch].Stop();
		aSrc[Ch].clip = null;
		PlayingIndex[Ch] = -1;
	}

	public void stopAll()
	{
		for (int i = 0; i < aSrc.Length; i++)
		{
			stop(i);
		}
	}

	public int getID(string filename)
	{
		for (int i = 0; i < SoundName.Length; i++)
		{
			if (string.Compare("sound/" + SoundName[i], filename) == 0)
			{
				return i;
			}
		}
		return -1;
	}

	public float getTotalTime(int id)
	{
		return audioClipArray[id].length;
	}

	public float getTime(int ch)
	{
		return aSrc[ch].time;
	}

	public void setTime(int ch, float time)
	{
		aSrc[ch].time = time;
	}

	public void setMasterVolume(int vol)
	{
		m_masterVolume = (float)vol / 10f;
	}

	public bool GetNowPlaySound(int iSnd)
	{
		for (int i = 0; i < PlayingIndex.Length; i++)
		{
			if (PlayingIndex[i] == iSnd)
			{
				return true;
			}
		}
		return false;
	}

	private void OnDestroy()
	{
		for (int i = 0; i < audioClipArray.Length; i++)
		{
			Resources.UnloadAsset(audioClipArray[i]);
			audioClipArray[i] = null;
		}
		for (int j = 0; j < 16; j++)
		{
			Object.Destroy(sGo[j]);
			Object.Destroy(aSrc[j]);
			sGo[j] = null;
			aSrc[j] = null;
		}
		BundleUnload();
	}

	public bool getMute(int ch)
	{
		bool result = false;
		if (aSrc[ch] != null)
		{
			result = aSrc[ch].mute;
		}
		return result;
	}
}
